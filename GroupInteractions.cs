namespace NationalSpire;

public static class GroupInteractions
{
    public static void Apply(CareerData d, GroupChat g, GroupTurn t, IEnumerable<Dictionary<string, string>> actions)
    {
        if (t.Effects.Count > 0) return;
        var pending = new Dictionary<(string Actor, string Target), List<Dictionary<string, string>>>();
        foreach (var source in actions)
        {
            string actor = g.Resolve(source.GetValueOrDefault("Actor", ""));
            string target = g.Resolve(source.GetValueOrDefault("Target", ""));
            bool humanActivity = source.ContainsKey("Activity") && g.Members.Contains(actor) && GroupChats.IsHuman(d, actor);
            string unavailable = humanActivity ? "" : GroupChats.SpeechUnavailable(d, g, actor);
            if (unavailable.Length > 0) { t.Notices.Add("交互未生效：" + unavailable); continue; }
            if (source.ContainsKey("Target") && !g.Members.Contains(target)) { t.Notices.Add(GroupChats.Name(d, actor) + "的交互未生效：对象编号无效。"); continue; }
            if (humanActivity) target = actor;
            else if (target.Length == 0) target = t.Sender;
            if (source.ContainsKey("Match") && !GroupChats.IsHuman(d, target))
            { t.Notices.Add(GroupChats.Name(d, actor) + "与" + GroupChats.Name(d, target) + "的约战：当前版本暂不支持 NPC 间约战，后续更新支持。"); continue; }
            if (source.ContainsKey("Training") && t.Attachments.FirstOrDefault(a => a.Id == source.GetValueOrDefault("Id") && a.CoachId == actor) is { } plan)
            {
                plan.CoachAccepted = source["Training"] is "同意" or "接受";
                t.Notices.Add(GroupChats.Name(d, actor) + (plan.CoachAccepted ? "接受负责训练计划" : "拒绝负责训练计划") + " " + plan.Id); continue;
            }
            if ((source.ContainsKey("Favour") || source.ContainsKey("Attitude") || source.ContainsKey("Relationship")) && !g.Members.Contains(target))
            { t.Notices.Add(GroupChats.Name(d, actor) + "的关系变化未生效：对象编号无效。"); continue; }
            var fields = new Dictionary<string, string>(source, StringComparer.OrdinalIgnoreCase);
            foreach (string name in new[] { "Actor", "Target", "Participants", "Related", "Coach" }) fields.Remove(name);
            var key = (actor, target);
            if (!pending.TryGetValue(key, out var list)) pending[key] = list = [];
            // 参与人保留在本次交互上，不通过正文猜测身份。
            fields["GroupParticipants"] = source.GetValueOrDefault("Participants", "");
            fields["GroupRelated"] = source.GetValueOrDefault("Related", "");
            list.Add(fields);
        }
        foreach (var (key, fields) in pending)
        {
            string human = GroupChats.IsHuman(d, key.Target) ? key.Target : t.Sender;
            string target = key.Target == human ? "" : key.Target;
            GroupChats.InLane(d, g, human, key.Actor, target, c =>
            {
                string turnId = t.Id + ":" + key.Actor + ":" + target;
                var local = new PrivateTurn { Id = turnId, Status = "complete", Day = t.Day, Season = d.Season, User = t.Text,
                    Reply = string.Join("\n", t.Replies.Where(r => r.Author == key.Actor).Select(r => r.Text)),
                    Attachments = t.Attachments.Where(a => a.Kind == "match" ? a.Participants.Contains(key.Actor)
                        : a.Participants.Count == 0 || a.Participants.Contains(key.Actor) || a.ActorId == key.Actor).ToList() };
                // 无正文的有效决定仍有明确行为描述，沿用私信交互的完整回复条件。
                if (local.Reply.Length == 0) local.Reply = string.Join("；", fields.Select(f => string.Join("，", f.Select(x => x.Key + ":" + x.Value))));
                c.Turns.Add(local);
                foreach (var a in local.Attachments) if (long.TryParse(a.Id, out long n)) { c.InteractionNumbers[a.Id] = n; c.LastInteractionNumber = Math.Max(c.LastInteractionNumber, n); }
                int before = PrivateMessages.Favour(d, key.Actor);
                var oldIds = c.Offers.Select(o => o.Id).ToHashSet();
                c.LastInteractionNumber = Math.Max(c.LastInteractionNumber, g.LastInteractionNumber);
                if (GroupChats.IsHuman(d, key.Actor))
                {
                    // 玩家活动只改变约定，不能进入 NPC 的好感、能力或合同处理。
                    var snapshot = PrivateInteractionHistory.Capture(d, key.Actor);
                    foreach (var f in fields) SocialAppointments.Respond(d, c, local, f);
                    local.Applied = true;
                    PrivateInteractionHistory.Record(d, key.Actor, local, snapshot);
                }
                else PrivateMessages.Apply(d, c, local, fields);
                foreach (var offer in c.Offers) PrivateInteractionIds.Number(c, offer);
                g.LastInteractionNumber = Math.Max(g.LastInteractionNumber, c.LastInteractionNumber);
                var metadata = fields.ToList();
                foreach (var o in c.Offers.Where(o => !oldIds.Contains(o.Id)))
                {
                    o.GroupId = g.Id; o.ActorId = key.Actor;
                    var f = metadata.FirstOrDefault(f => o.Kind switch
                    {
                        "publish" => f.GetValueOrDefault("Post") == "发布" && f.GetValueOrDefault("Title") == o.Title && f.GetValueOrDefault("Body") == o.Detail,
                        "activity" => f.GetValueOrDefault("Activity") is "邀请" or "改期"
                            && f.GetValueOrDefault("Season") == o.Season.ToString() && f.GetValueOrDefault("Day") == o.Day.ToString()
                            && f.GetValueOrDefault("Title", o.Title) == o.Title && f.GetValueOrDefault("Detail", o.Detail) == o.Detail,
                        _ => false
                    });
                    if (f != null) metadata.Remove(f);
                    o.Participants = ResolvePeople(g, f?.GetValueOrDefault("GroupParticipants", "") ?? "");
                    if (o.Participants.Count == 0 && c.Offers.FirstOrDefault(old => old.Id == o.ReplacesOfferId) is { } previous) o.Participants = previous.Participants.ToList();
                    if (o.Kind == "activity" && o.Participants.Count == 0) o.Participants = [t.Sender, key.Actor];
                    o.RelatedPeople = ResolvePeople(g, f?.GetValueOrDefault("GroupRelated", "") ?? "");
                }
                int after = PrivateMessages.Favour(d, key.Actor);
                string towards = "对" + GroupChats.Name(d, key.Target);
                string note = before != after ? towards + "好感 " + before + " → " + after : "";
                if (fields.Any(f => f.ContainsKey("Attitude"))) note += "  " + towards + "的印象已更新";
                if (fields.Any(f => f.ContainsKey("Relationship"))) note += "  与" + GroupChats.Name(d, key.Target) + "的关系：" + PrivateMessages.Relation(d, key.Actor).Relationship;
                if (local.Learning != null) note += "  学习：" + local.Learning.Topic;
                if (local.Mood != null) note += "  状态已更新";
                foreach (var change in local.ProfileChanges) note += "  " + PrivateProfileChanges.Label(change.Field) + "已更新";
                if (local.Error.Length > 0) t.Notices.Add(GroupChats.Name(d, key.Actor) + "：" + local.Error);
                t.Effects.Add(new() { Human = human, Person = key.Actor, Target = target, Lane = human + "/" + key.Actor + "/" + target, Turn = turnId, Text = note.Trim() });
                return true;
            });
        }
    }
    public static List<string> ResolvePeople(GroupChat g, string text) => text.Trim('[', ']').Split(new[] { ',', '，', ';', '；', '|', ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(g.Resolve).Where(g.Members.Contains).Distinct().ToList();
}
