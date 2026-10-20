namespace NationalSpire;

public sealed class ProactiveChatSettings
{
    public bool Enabled { get; set; }
    public bool FinalAlwaysReply { get; set; }
    public int MatchChance { get; set; } = 25;
    public int EventChance { get; set; } = 25;
    public int DayChance { get; set; }
    public int UnansweredLimit { get; set; } = 3;
    public int Unanswered { get; set; }
    public int EventDay { get; set; }
    public HashSet<string> SeenEvents { get; set; } = [];
    public string LastTrigger { get; set; } = "";
}

public static class ProactiveChats
{
    public static void CountReplies(PrivateConversation c) => c.Proactive.Unanswered = c.Turns.AsEnumerable().Reverse()
        .TakeWhile(t => t.ProactiveReason.Length > 0 || t.User.Length == 0 && t.Attachments.Count == 0 && t.Request == null)
        .Count(t => t.ProactiveReason.Length > 0 && t.Status == "complete");
    public static void CountReplies(GroupChat g, string human)
    {
        if (g.Proactive.TryGetValue(human, out var settings)) settings.Unanswered = g.Turns.Where(t => t.Sender == human).Reverse()
            .TakeWhile(t => t.ProactiveReason.Length > 0 || t.Text.Length == 0 && t.Attachments.Count == 0)
            .Count(t => t.ProactiveReason.Length > 0 && t.Status == "complete");
    }
    public static string? Configure(ProactiveChatSettings target, ProactiveChatSettings value)
    {
        if (value.MatchChance is < 0 or > 100 || value.EventChance is < 0 or > 100 || value.DayChance is < 0 or > 100 || value.UnansweredLimit < 1)
            return "概率填写0至100，等待回应的轮数至少为1。";
        target.Enabled = value.Enabled; target.FinalAlwaysReply = value.FinalAlwaysReply;
        target.MatchChance = value.MatchChance; target.EventChance = value.EventChance;
        target.DayChance = value.DayChance; target.UnansweredLimit = value.UnansweredLimit;
        return null;
    }
    public static string Prompt(string reason, bool last) => "本次由人物主动联系。触发原因：" + reason
        + "\n请结合已有交流、人物身份与关系，自然地发起简短对话。"
        + (last ? "\n此前主动联系尚未得到玩家回应。本次表达后等待玩家回复，按人物性格自然收尾。" : "");
    public static ProactiveChatSettings Settings(CareerData d, GroupChat g)
    {
        string human = GroupChats.Human(d);
        if (!g.Proactive.TryGetValue(human, out var settings)) g.Proactive[human] = settings = new();
        return settings;
    }
    public static void Trigger(CareerData d, CareerMatch? match = null)
    {
        if (!d.Ai.Enabled) return;
        string trigger = match == null ? "day:" + d.Day : "match:" + match.Id;
        var competition = match == null ? null : d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId);
        bool final = competition is { Kind: "worldfinal" or "continental" or "worldcup" }
            && match!.Round == CircuitWorld.RoundCount(competition);
        var events = d.Life.Events.Where(e => e.Day == d.Day).ToArray();
        string? Reason(ProactiveChatSettings settings, string conversation, IReadOnlyCollection<string> people)
        {
            if (!settings.Enabled || settings.Unanswered >= settings.UnansweredLimit || settings.LastTrigger == trigger) return null;
            settings.LastTrigger = trigger;
            if (settings.EventDay != d.Day) { settings.SeenEvents.Clear(); settings.EventDay = d.Day; }
            var related = events.Where(e => !settings.SeenEvents.Contains(e.Id) && e.People.Any(people.Contains)).ToArray();
            foreach (var e in related) settings.SeenEvents.Add(e.Id);
            var random = new Random(CareerEngine.StableHash(d.WorldId + ":proactive:" + GroupChats.Human(d) + ":" + conversation + ":" + trigger));
            bool Hit(int chance) => random.Next(100) < Math.Clamp(chance, 0, 100);
            if (match != null && Hit(settings.FinalAlwaysReply && final ? 100 : settings.MatchChance)) return match.Event + "已经结束，" + (match.Draw ? "双方战平。" : match.PlayerWon ? "玩家获胜。" : "玩家失利。")
                + "对手：" + CareerEngine.DisplayName(d, match.OpponentId) + "。";
            if (related.Length > 0 && Hit(settings.EventChance)) return string.Join("\n", related.Select(e => e.Title + "：" + e.Detail));
            if (match == null && related.Length == 0 && Hit(settings.DayChance)) return PrivateAppointments.DateText(d, d.Day) + "，人物想起此前的交流，希望问候或分享近况。";
            return null;
        }
        foreach (var c in PrivateMessages.Mailbox(d).Conversations.Values.ToArray())
        {
            if (c.Hidden || !GroupChats.CanSpeak(d, c.PersonId) || c.Turns.LastOrDefault()?.Status is "queued" or "sending") continue;
            CountReplies(c);
            if (Reason(c.Proactive, c.PersonId, [c.PersonId]) is not { } reason) continue;
            var turn = PrivateMessages.Enqueue(d, c.PersonId, "", proactiveReason: reason);
            turn.ProactiveLast = c.Proactive.Unanswered + 1 >= c.Proactive.UnansweredLimit;
        }
        foreach (var g in GroupChats.Visible(d))
        {
            if (GroupChats.Busy(g) || !g.Members.Any(id => GroupChats.CanSpeak(d, id))) continue;
            if (!g.Proactive.TryGetValue(GroupChats.Human(d), out var settings)) continue;
            CountReplies(g, GroupChats.Human(d));
            if (Reason(settings, g.Id, g.Members) is not { } reason) continue;
            g.Turns.Add(new() { Sender = GroupChats.Human(d), Day = d.Day, Order = GroupChats.NextOrder(d), ProactiveReason = reason,
                ProactiveLast = settings.Unanswered + 1 >= settings.UnansweredLimit });
            g.Revision++;
        }
    }
    public static void StartQueued(CareerData d)
    {
        foreach (var c in PrivateMessages.Mailbox(d).Conversations.Values.ToArray())
            if (!c.Hidden && c.Turns.LastOrDefault() is { Status: "queued", ProactiveReason.Length: > 0 })
                _ = AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, c.PersonId);
        foreach (var g in GroupChats.Visible(d).ToArray())
            if (g.Turns.LastOrDefault() is { Status: "queued", ProactiveReason.Length: > 0 })
                _ = AiService.ProcessGroupAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, g.Id);
    }
}
