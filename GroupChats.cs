using System.Text.Json;

namespace NationalSpire;

public static class GroupChats
{
    public static string Human(CareerData d) => d.LocalHumanId.Length > 0 ? d.LocalHumanId : "player";
    public static long NextOrder(CareerData d) { lock (d.Chats) return ++d.Chats.Order; }
    public static bool IsHuman(CareerData d, string id) => id == "player" || d.HumanIds.Contains(id);
    public static bool CanSpeak(CareerData d, string id) => PrivateMessages.CanChat(d, id) && !SpireArbitration.Muted(CareerEngine.Person(d, id)!);
    public static string SpeechUnavailable(CareerData d, GroupChat g, string id) => !g.Members.Contains(id) ? "人物编号不属于本群。"
        : IsHuman(d, id) ? "模型不能代替玩家发言或决定。"
        : CareerEngine.Person(d, id) == null ? "人物已不存在。"
        : SpireArbitration.Muted(CareerEngine.Person(d, id)!) ? Name(d, id) + "的账号已封禁。" : "";
    public static string Name(CareerData d, string id) => id == Human(d) ? CareerEngine.Name(d) : CareerEngine.DisplayName(d, id);
    public static bool Busy(GroupChat g) => g.Turns.Any(t => t.Status is "queued" or "sending");
    public static IEnumerable<GroupChat> Visible(CareerData d) => d.Chats.Groups.Where(g => g.Members.Contains(Human(d)));
    public static GroupChat Create(CareerData d, string name, IEnumerable<string> members)
    {
        var g = new GroupChat { Name = name.Trim(), Creator = Human(d) };
        if (g.Name.Length == 0) g.Name = "新群聊";
        d.Chats.Groups.Add(g); AddMembers(d, g, members.Prepend(g.Creator)); return g;
    }
    public static void AddMembers(CareerData d, GroupChat g, IEnumerable<string> people)
    {
        foreach (string id in people.Distinct().Where(id => IsHuman(d, id) || d.People.Any(p => p.Id == id)))
        {
            if (g.Members.Contains(id)) continue;
            g.Members.Add(id); g.Alias(id);
            g.Entries.Add(new() { Order = NextOrder(d), Day = d.Day, Author = id, Text = Name(d, id) + "加入了群聊", Notice = true });
        }
        g.Revision++;
    }
    public static PrivateConversation Lane(GroupChat g, string human, string person, string target = "")
    {
        string key = human + "/" + person + "/" + target;
        if (!g.Interactions.TryGetValue(key, out var lane)) g.Interactions[key] = lane = new() { PersonId = person };
        return lane;
    }
    // 在同步执行期间接入已有交互函数；不把群聊正文写进私信记录。
    public static T InLane<T>(CareerData d, GroupChat g, string human, string person, string target, Func<PrivateConversation, T> action)
    {
        var lifeBox = PrivateMessages.Mailbox(d);
        var box = d.PrivateMemorySources.GetValueOrDefault(human) ?? lifeBox;
        d.Life.Mailbox = box;
        var oldConversation = box.Conversations.GetValueOrDefault(person);
        var oldRelation = box.Relations.GetValueOrDefault(person);
        bool other = target.Length > 0 && !IsHuman(d, target);
        string relationKey = person + "/" + target;
        if (other) box.Relations[person] = d.Chats.Relations.GetValueOrDefault(relationKey) ?? new();
        var lane = Lane(g, human, person, target); box.Conversations[person] = lane;
        bool hadLegacy = d.Life.Relationships.TryGetValue(person, out int legacy);
        try { return action(lane); }
        finally
        {
            if (other)
            {
                d.Chats.Relations[relationKey] = box.Relations[person];
                if (oldRelation == null) box.Relations.Remove(person); else box.Relations[person] = oldRelation;
            }
            if (other || human != Human(d))
            { if (hadLegacy) d.Life.Relationships[person] = legacy; else d.Life.Relationships.Remove(person); }
            if (oldConversation == null) box.Conversations.Remove(person); else box.Conversations[person] = oldConversation;
            d.Life.Mailbox = lifeBox;
        }
    }
    public static string? Command(CareerData d, string kind, string id, GroupCommand command)
    {
        if (MatchFailure.Locked(d) is { } locked) return locked;
        if (kind == "group-create") { Create(d, command.Text, command.People); return null; }
        var g = Visible(d).FirstOrDefault(g => g.Id == id);
        if (g == null) return "群聊已不存在。";
        if (kind == "group-read") { g.Seen[Human(d)] = g.Turns.Count(t => t.Status == "complete"); return null; }
        if (kind == "group-add") { AddMembers(d, g, command.People); return null; }
        if (kind == "group-stop") { AiService.CancelGroup(d, g.Id); return null; }
        if (Busy(g)) return "正在回复，请等待本轮结束。";
        if (kind is "group-send" or "group-arbitrate")
        {
            if (kind == "group-arbitrate" && string.IsNullOrWhiteSpace(command.Text)) command.Text = "申请尖塔仲裁，请审理本群往来及此前裁决的履行情况。";
            if (string.IsNullOrWhiteSpace(command.Text) && command.Attachments.Count == 0) return null;
            var t = new GroupTurn { Sender = Human(d), Day = d.Day, Order = NextOrder(d), Text = command.Text, Attachments = command.Attachments,
                ArbitrationTargets = kind == "group-arbitrate" ? command.People.Where(g.Members.Contains).Where(id => PrivateMessages.CanChat(d, id)).Distinct().ToList() : [] };
            foreach (var a in t.Attachments) { a.Id = (++g.LastInteractionNumber).ToString(); a.GroupId = g.Id; a.CoachAccepted = false; }
            if (kind == "group-send" && !g.Members.Any(id => CanSpeak(d, id))) t.Status = "complete";
            g.Turns.Add(t);
        }
        else if (kind == "group-retry")
        {
            if (g.Turns.LastOrDefault() is not { Status: "failed" } failed) return "没有未完成的回复。";
            failed.Status = "queued"; failed.Replies.Clear(); failed.SpeechOrders.Clear(); failed.Raw = failed.Error = failed.Reasoning = "";
        }
        else if (kind == "group-regenerate")
        {
            if (g.Turns.LastOrDefault() is not { Status: "complete" } last || last.Replies.Count == 0 && last.Raw.Length == 0) return "只能重新生成最新一轮完整 NPC 回复。";
            if (last.ArbitrationTargets.Count > 0) return "仲裁结果不能作为普通聊天重新生成。";
            // 先在副本检查整轮能否回退，避免先撤回甲的合同才发现乙的比赛已开始。
            var probe = PreviewCopy(d);
            var probeGroup = probe.Chats.Groups.Single(x => x.Id == g.Id);
            if (Rewind(probe, probeGroup, probeGroup.Turns[^1]) is { } error) return error;
            Rewind(d, g, last);
            last.Status = "queued"; last.Replies.Clear(); last.SpeechOrders.Clear(); last.Raw = last.Error = last.Reasoning = "";
            foreach (var attachment in last.Attachments) attachment.CoachAccepted = false;
            int at = g.Turns.Count - 1;
            g.SmallSummaries.RemoveAll(s => s.Through > at); g.BigSummaries.RemoveAll(s => s.Through > at);
            g.SummarizedThrough = g.SmallSummaries.Concat(g.BigSummaries).Select(s => s.Through).DefaultIfEmpty(0).Max();
        }
        else if (kind == "group-clear")
        {
            foreach (var t in g.Turns) { t.Text = ""; t.Replies.Clear(); t.Raw = t.Reasoning = ""; t.Attachments.Clear(); }
        }
        else if (kind == "group-settings" && command.Settings is { } settings)
        {
            if (settings.SummaryEvery < 1 || settings.RecentRounds < 0 || settings.SmallSummaryLimit < 2 || settings.MergeOldest < 2 || settings.MergeOldest > settings.SmallSummaryLimit) return "请填写有效的总结与保留轮数。";
            g.Settings = settings;
        }
        else if (kind is "group-summary-edit" or "group-summary-delete")
        {
            var list = command.Interaction.Part == "big" ? g.BigSummaries : g.SmallSummaries;
            var summary = list.FirstOrDefault(s => s.Id == command.Interaction.Entry);
            if (summary != null) { if (kind.EndsWith("delete")) list.Remove(summary); else summary.Text = command.Text; }
        }
        else if (kind.StartsWith("group-offer-"))
        {
            var effect = g.Turns.SelectMany(t => t.Effects).LastOrDefault(e => e.Lane == command.Lane && (command.Interaction.Offer.Length == 0 || g.Interactions[e.Lane].Offers.Any(o => o.Id == command.Interaction.Offer && o.TurnId == e.Turn)));
            if (effect == null) return "这项交互已不存在。";
            if (effect.Human != Human(d)) return "这项交互由发起人处理。";
            bool humanActivity = IsHuman(d, effect.Person);
            if (!humanActivity && !PrivateMessages.CanChat(d, effect.Person)) return "该人物已经删除，这项交互不再执行。";
            string? result = InLane(d, g, effect.Human, effect.Person, effect.Target, c =>
            {
                if (!humanActivity) return PrivateMessageCommands.Apply(d, "dm-" + kind[12..], effect.Person, command.Interaction);
                var offer = c.Offers.FirstOrDefault(o => o.Id == command.Interaction.Offer && o.Kind == "activity");
                if (offer == null) return "活动已不存在。";
                if (kind == "group-offer-confirm") return SocialAppointments.Confirm(d, c, offer);
                if (kind == "group-offer-attend") return SocialAppointments.Attend(d, offer);
                if (kind == "group-offer-decline")
                {
                    if (offer.State is not ("待确认" or "已确认")) return "这项活动已处理。";
                    offer.State = "已取消"; return null;
                }
                return "活动操作无效。";
            });
            if (result == null && kind == "group-offer-confirm") GroupArbitration.LinkPublication(d, g, effect.Turn);
            g.Revision++; return result;
        }
        g.Revision++; return null;
    }
    private static string? Rewind(CareerData d, GroupChat g, GroupTurn t)
    {
        foreach (var effect in t.Effects.AsEnumerable().Reverse())
        {
            if (!IsHuman(d, effect.Person) && !PrivateMessages.CanChat(d, effect.Person)) continue;
            string? error = InLane(d, g, effect.Human, effect.Person, effect.Target, c =>
            {
                var turn = c.Turns.FirstOrDefault(x => x.Id == effect.Turn);
                return turn == null ? null : PrivateInteractionHistory.Rewind(d, c, turn);
            });
            if (error != null) return Name(d, effect.Person) + "：" + error;
        }
        foreach (var c in g.Interactions.Values) c.Turns.RemoveAll(x => t.Effects.Any(e => e.Turn == x.Id));
        t.Effects.Clear(); t.Notices.Clear(); return null;
    }
    internal static CareerData PreviewCopy(CareerData d)
    {
        var copy = JsonSerializer.Deserialize<CareerData>(JsonSerializer.Serialize(d))!;
        copy.LocalHumanId = d.LocalHumanId; copy.AvatarWorldId = d.AvatarWorldId;
        copy.PrivateMemorySources = d.PrivateMemorySources.ToDictionary(x => x.Key, x => x.Key == Human(d) ? copy.Life.Mailbox : JsonSerializer.Deserialize<PrivateMailbox>(JsonSerializer.Serialize(x.Value))!);
        copy.ExternalCurrent = () => false; copy.ExternalSave = _ => { };
        return copy;
    }
    public static void Recover(CareerData d)
    {
        foreach (var g in d.Chats.Groups)
        {
            g.SummaryStatus = "";
            foreach (var t in g.Turns.Where(t => t.Status is "queued" or "sending")) { t.Status = "failed"; t.Error = "上次回复中断，可以重试。"; }
        }
    }
    public static void Deleted(CareerData d, string person)
    {
        foreach (var g in d.Chats.Groups.Where(g => g.Members.Contains(person)))
        {
            g.Members.Remove(person); g.Revision++;
            foreach (var offer in g.Interactions.Values.SelectMany(c => c.Offers).Where(o => o.State == "待确认" && (o.ActorId == person || o.Participants.Contains(person)))) offer.State = "已取消";
        }
    }
}
