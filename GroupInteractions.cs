namespace NationalSpire;

using System.Text.Json;
using System.Text.RegularExpressions;

public static class GroupInteractions
{
    public static void Apply(CareerData d, GroupChat g, GroupTurn t, IEnumerable<Dictionary<string, string>> actions)
    {
        if (t.Effects.Count > 0) return;
        var attachments = t.Attachments.Concat(g.Turns.TakeWhile(previous => previous != t).Reverse().SelectMany(previous => previous.Attachments))
            .DistinctBy(a => a.Id).ToArray();
        var pending = new Dictionary<(string Actor, string Target), List<Dictionary<string, string>>>();
        foreach (var source in Expand(g, t, actions, attachments))
        {
            string actor = g.Resolve(source.GetValueOrDefault("Actor", ""));
            if (source.ContainsKey("Activity") && source.TryGetValue("Id", out string? activityId) && activityId != "0")
            {
                // 同一附件使用发起者的交互记录，成员分别确认时共同更新同一项日程。
                var existing = g.Interactions.FirstOrDefault(lane =>
                {
                    string? id = PrivateInteractionIds.Resolve(lane.Value, activityId);
                    return lane.Value.Offers.Any(o => o.Kind == "activity" && o.Id == id);
                });
                if (existing.Value != null) actor = existing.Value.PersonId;
                else if (attachments.Any(a => a.Kind == "activity" && a.Id == activityId))
                    actor = g.Turns.FirstOrDefault(previous => previous.Attachments.Any(a => a.Kind == "activity" && a.Id == activityId))?.Sender ?? t.Sender;
            }
            if (actor.Length == 0 && source.ContainsKey("Gift"))
            {
                var gifts = t.Attachments.Where(a => a.Kind == "gift" && (!source.ContainsKey("Id") || a.Id == source["Id"])).ToArray();
                if (gifts.Length == 1) actor = gifts[0].ActorId;
            }
            string target = g.Resolve(source.GetValueOrDefault("Target", ""));
            bool humanActivity = source.ContainsKey("Activity") && g.Members.Contains(actor) && GroupChats.IsHuman(d, actor);
            string unavailable = humanActivity ? "" : GroupChats.SpeechUnavailable(d, g, actor);
            if (unavailable.Length > 0) { t.Notices.Add("交互未生效：" + unavailable); continue; }
            if (source.ContainsKey("Target") && !g.Members.Contains(target)) { t.Notices.Add(GroupChats.Name(d, actor) + "的交互未生效：对象编号无效。"); continue; }
            if (humanActivity) target = actor;
            else if (target.Length == 0) target = t.Sender;
            if (source.ContainsKey("Match") && !GroupChats.IsHuman(d, target))
            { t.Notices.Add(GroupChats.Name(d, actor) + "与" + GroupChats.Name(d, target) + "的约战：当前版本暂不支持 NPC 间约战，后续更新支持。"); continue; }
            if ((source.ContainsKey("Favour") || source.ContainsKey("Attitude") || source.ContainsKey("Relationship")) && !g.Members.Contains(target))
            { t.Notices.Add(GroupChats.Name(d, actor) + "的关系变化未生效：对象编号无效。"); continue; }
            var fields = new Dictionary<string, string>(source, StringComparer.OrdinalIgnoreCase);
            foreach (string name in new[] { "Actor", "Target", "Participants", "Related", "Coach" }) fields.Remove(name);
            var key = (actor, target);
            if (!pending.TryGetValue(key, out var list)) pending[key] = list = [];
            // 参与人保留在本次交互上，不通过正文猜测身份。
            fields["GroupParticipants"] = source.GetValueOrDefault("Participants", "");
            fields["GroupRelated"] = source.GetValueOrDefault("Related", "");
            if (fields.ContainsKey("Activity") && list.FirstOrDefault(previous => previous.Count == fields.Count
                && fields.Where(field => field.Key != "GroupParticipants").All(field => previous.TryGetValue(field.Key, out var value) && value == field.Value)) is { } sameActivity)
            {
                sameActivity["GroupParticipants"] = string.Join("|", ResolvePeople(g, sameActivity["GroupParticipants"] + "|" + fields["GroupParticipants"]).Select(g.Alias));
                continue;
            }
            if (fields.ContainsKey("Training") && list.Any(previous => previous.Count == fields.Count
                && fields.All(field => previous.TryGetValue(field.Key, out var value) && value == field.Value))) continue;
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
                    Attachments = attachments.Where(a => t.Attachments.Contains(a) || fields.Any(f => a.Kind is "training" or "activity" && a.Id == f.GetValueOrDefault("Id")))
                        .Where(a => a.Kind == "activity" || (a.Kind == "match" ? a.Participants.Contains(key.Actor)
                            : a.Participants.Count == 0 || a.Participants.Contains(key.Actor) || a.ActorId == key.Actor)).ToList() };
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
                        "activity" => f.GetValueOrDefault("Activity") is "邀请" or "改期" or "接受"
                            && f.GetValueOrDefault("Season", o.Season.ToString()) == o.Season.ToString() && f.GetValueOrDefault("Day", o.Day.ToString()) == o.Day.ToString()
                            && f.GetValueOrDefault("Title", o.Title) == o.Title && f.GetValueOrDefault("Detail", o.Detail) == o.Detail,
                        _ => false
                    });
                    if (f != null) metadata.Remove(f);
                    var participants = ResolvePeople(g, f?.GetValueOrDefault("GroupParticipants", "") ?? "");
                    if (participants.Count > 0)
                    {
                        if (o.Kind == "activity" && o.State == "已确认" && !participants.ToHashSet().SetEquals(o.Participants)) o.State = "待确认";
                        o.Participants = participants;
                    }
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

    private static IEnumerable<Dictionary<string, string>> Expand(GroupChat g, GroupTurn t,
        IEnumerable<Dictionary<string, string>> actions, PrivateOffer[] attachments)
    {
        foreach (var source in actions)
        {
            if (source.ContainsKey("Training"))
            {
                var plan = attachments.FirstOrDefault(a => a.Kind == "training" && a.Id == source.GetValueOrDefault("Id"));
                var people = ResolvePeople(g, source.GetValueOrDefault("Actor", ""));
                if (people.Count == 0) { yield return source; continue; }
                foreach (string person in people)
                {
                    // 旧回复中的教练同意不再是训练执行条件，受训者决定分别进入原登记流程。
                    if (person == plan?.CoachId) continue;
                    yield return new(source, StringComparer.OrdinalIgnoreCase) { ["Actor"] = g.Alias(person) };
                }
            }
            else if (source.ContainsKey("Activity") && !source.ContainsKey("Participants"))
            {
                string id = source.GetValueOrDefault("Id", "");
                var original = attachments.FirstOrDefault(a => a.Kind == "activity" && a.Id == id);
                var existing = g.Interactions.Values.SelectMany(lane => lane.Offers.Where(o => o.Kind == "activity"
                    && o.Id == PrivateInteractionIds.Resolve(lane, id))).FirstOrDefault();
                string people = source.GetValueOrDefault("Actor", "");
                // 逐人接受同一活动仍指向附件中的完整安排。
                if (original != null && source.GetValueOrDefault("Activity") == "接受")
                    people = string.Join("|", original.Participants.Select(g.Alias));
                else if (ResolvePeople(g, people).Count <= 1 && (existing ?? original) is { } basis)
                    people = string.Join("|", basis.Participants.Select(g.Alias));
                yield return new(source, StringComparer.OrdinalIgnoreCase) { ["Actor"] = g.Alias(t.Sender), ["Participants"] = people };
            }
            else yield return source;
        }
    }

    /// <summary>仅转换模型材料中的旧活动字段，聊天及存档原文保持原值。</summary>
    public static string PromptText(string text)
    {
        if (!text.Contains("Participants", StringComparison.Ordinal)) return text;
        text = Regex.Replace(text, @"\[Activity:[^\r\n\]]+\]", match =>
        {
            var parser = new PrivateStreamParser("Actor", "Participants"); parser.Feed(match.Value); parser.Finish();
            var fields = parser.Directives.FirstOrDefault();
            if (fields == null || !fields.Remove("Participants", out string? people)) return match.Value;
            fields["Actor"] = people;
            return "[" + string.Join(", ", fields.Select(field => field.Key + ": " + field.Value)) + "]";
        });
        return Regex.Replace(text, "\\{[^{}]*\"Participants\"[^{}]*\\}", match =>
        {
            Dictionary<string, JsonElement>? fields;
            try { fields = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(match.Value); }
            catch (JsonException) { return match.Value; }
            if (fields == null || !fields.ContainsKey("Activity") || !fields.Remove("Participants", out var people)) return match.Value;
            fields["Actor"] = people;
            return JsonSerializer.Serialize(fields, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
        });
    }
}
