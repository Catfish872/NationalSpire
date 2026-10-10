namespace NationalSpire;

/// <summary>群聊属于生涯，原始消息只保存一份；跨会话上下文通过来源读取。</summary>
public sealed class ChatWorld
{
    public long Order { get; set; }
    public List<GroupChat> Groups { get; set; } = [];
    public Dictionary<string, PrivateRelation> Relations { get; set; } = [];
}
public sealed class GroupChat
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Name { get; set; } = "";
    public string Creator { get; set; } = "";
    public List<string> Members { get; set; } = [];
    public Dictionary<string, string> Aliases { get; set; } = [];
    public List<GroupEntry> Entries { get; set; } = [];
    public List<GroupTurn> Turns { get; set; } = [];
    public List<PrivateSummary> SmallSummaries { get; set; } = [];
    public List<PrivateSummary> BigSummaries { get; set; } = [];
    public Dictionary<string, PrivateConversation> Interactions { get; set; } = [];
    public Dictionary<string, int> Seen { get; set; } = [];
    public GroupHistorySettings Settings { get; set; } = new();
    public int SummarizedThrough { get; set; }
    public long LastInteractionNumber { get; set; }
    public long Revision { get; set; }
    public string SummaryError { get; set; } = "";
    public string SummaryStatus { get; set; } = "";
    public string Alias(string id)
    {
        if (!Aliases.TryGetValue(id, out var value)) Aliases[id] = value = "p" + (Aliases.Count + 1);
        return value;
    }
    public string Resolve(string alias) => Aliases.FirstOrDefault(x => x.Value == alias).Key ?? (Members.Contains(alias) ? alias : "");
}
public sealed class GroupHistorySettings
{
    public int SummaryEvery { get; set; } = 25;
    public int RecentRounds { get; set; } = 25;
    public int SmallSummaryLimit { get; set; } = 10;
    public int MergeOldest { get; set; } = 5;
}
public sealed class GroupEntry
{
    public long Order { get; set; }
    public int Day { get; set; }
    public string Author { get; set; } = "";
    public string Text { get; set; } = "";
    public string TurnId { get; set; } = "";
    public bool Notice { get; set; }
}
public sealed class GroupTurn
{
    public List<string> ArbitrationTargets { get; set; } = [];
    public List<long> SpeechOrders { get; set; } = [];
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Sender { get; set; } = "";
    public int Day { get; set; }
    public long Order { get; set; }
    public string Text { get; set; } = "";
    public List<PrivateOffer> Attachments { get; set; } = [];
    public string Status { get; set; } = "queued";
    public string Error { get; set; } = "";
    public string Raw { get; set; } = "";
    public string Reasoning { get; set; } = "";
    public List<GroupEntry> Replies { get; set; } = [];
    public List<GroupEffect> Effects { get; set; } = [];
    public List<string> Notices { get; set; } = [];
}
public sealed class GroupEffect
{
    public string Person { get; set; } = "";
    public string Human { get; set; } = "";
    public string Target { get; set; } = "";
    public string Lane { get; set; } = "";
    public string Turn { get; set; } = "";
    public string Text { get; set; } = "";
}
public sealed class GroupCommand
{
    public string Text { get; set; } = "";
    public List<string> People { get; set; } = [];
    public List<PrivateOffer> Attachments { get; set; } = [];
    public string Lane { get; set; } = "";
    public PrivateMessageCommand Interaction { get; set; } = new();
    public GroupHistorySettings? Settings { get; set; }
}
