namespace NationalSpire;

public sealed class GroupDeparture
{
    public long ThroughOrder { get; set; }
    public List<PrivateSummary> SmallSummaries { get; set; } = [];
    public List<PrivateSummary> BigSummaries { get; set; } = [];
}

/// <summary>会话入口管理与人物可读取的群聊时间范围共用同一份成员资料。</summary>
public static class ChatMembership
{
    public static bool Knows(GroupChat g, string person) => !g.Forgotten && (g.Members.Contains(person) || g.Departures.ContainsKey(person));
    public static bool Knows(GroupChat g, string person, long order) => Knows(g, person)
        && order >= g.MemoryStarts.GetValueOrDefault(person)
        && (g.Members.Contains(person) || order <= g.Departures[person].ThroughOrder);
    public static IEnumerable<string> Readers(GroupChat g, long order) => g.Members.Concat(g.Departures.Keys).Distinct().Where(p => Knows(g, p, order));
    public static bool SummaryKnown(GroupChat g, string person, PrivateSummary summary) => summary.From >= 0 && summary.Through > summary.From
        && summary.Through <= g.Turns.Count && Knows(g, person, g.Turns[summary.From].Order) && Knows(g, person, g.Turns[summary.Through - 1].Order);
    public static IEnumerable<PrivateSummary> Summaries(GroupChat g, string person, bool big) =>
        (g.Members.Contains(person) ? big ? g.BigSummaries : g.SmallSummaries
            : g.Departures.TryGetValue(person, out var departed) ? big ? departed.BigSummaries : departed.SmallSummaries : [])
        .Where(s => SummaryKnown(g, person, s));
    public static string? Private(CareerData d, PrivateConversation c, string action)
    {
        if (action == "restore") { c.Hidden = false; return null; }
        if (c.Turns.Any(t => t.Status is "queued" or "sending")) return "请结束当前回复后管理会话。";
        c.Hidden = true;
        if (PrivateMessages.Mailbox(d).LastPerson == c.PersonId) PrivateMessages.Mailbox(d).LastPerson = "";
        if (action == "forget")
        {
            c.Forgotten = true;
            foreach (var offer in c.Offers) offer.MemoryDeleted = true;
            c.Turns.Clear(); c.SmallSummaries.Clear(); c.BigSummaries.Clear(); c.ContextStart = 0;
            c.SummaryStatus = c.SummaryError = c.SummaryRequest = ""; c.SeenCount = 0; c.MemoryRevision++;
            c.Proactive.Unanswered = 0;
            Invalidate(d, [c.PersonId]);
        }
        return null;
    }
    public static string? Group(CareerData d, GroupChat g, string action, string person = "")
    {
        if (!g.Members.Contains(GroupChats.Human(d))) return "请先加入群聊。";
        if (GroupChats.Busy(g)) return "请结束当前回复后管理群聊。";
        if (action == "restore") { g.Dissolved = false; g.Revision++; return null; }
        if (action is "kick" or "kick-forget")
        {
            if (person == GroupChats.Human(d) || !g.Members.Contains(person)) return "请选择其他群成员。";
            if (action == "kick") g.Departures[person] = new() { ThroughOrder = d.Chats.Order,
                SmallSummaries = g.SmallSummaries.ToList(), BigSummaries = g.BigSummaries.ToList() };
            else { g.Departures.Remove(person); g.MemoryStarts[person] = d.Chats.Order + 1; Invalidate(d, [person]); }
            g.Members.Remove(person);
            g.Entries.Add(new() { Order = GroupChats.NextOrder(d), Day = d.Day, Author = person, Notice = true, Text = GroupChats.Name(d, person) + "已离开群聊" });
        }
        else
        {
            g.Dissolved = true;
            if (action == "forget")
            {
                Invalidate(d, g.Members.Concat(g.Departures.Keys).ToArray());
                g.Forgotten = true; g.Turns.Clear(); g.Entries.Clear(); g.SmallSummaries.Clear(); g.BigSummaries.Clear();
                g.SummarizedThrough = 0; g.SummaryError = g.SummaryStatus = ""; g.Departures.Clear();
                foreach (var lane in g.Interactions.Values) { lane.Turns.Clear(); lane.SmallSummaries.Clear(); lane.BigSummaries.Clear(); }
            }
        }
        g.Revision++; return null;
    }
    private static void Invalidate(CareerData d, IEnumerable<string> people)
    {
        var ids = people.ToHashSet();
        foreach (var box in ChatTimeline.Mailboxes(d).Select(x => x.Value))
            foreach (var c in box.Conversations.Values.Where(c => ids.Contains(c.PersonId)))
            {
                foreach (var turn in c.Turns) turn.Context = "";
                c.SmallSummaries.Clear(); c.BigSummaries.Clear(); c.ContextStart = 0; c.MemoryRevision++;
            }
    }
}
