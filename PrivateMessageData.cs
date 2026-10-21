namespace NationalSpire;

public sealed class PrivateMailbox
{
    public Dictionary<string, string> NpcAvatarFrames { get; set; } = [];
    public string LastPerson { get; set; } = "";
    public int Version { get; set; }
    public PrivateHistorySettings Settings { get; set; } = new();
    public Dictionary<string, PrivateConversation> Conversations { get; set; } = [];
    public Dictionary<string, PrivateRelation> Relations { get; set; } = [];
}
public sealed class PrivateHistorySettings
{
    public int MaximumRounds { get; set; } = 50;
    public int RecentRounds { get; set; } = 10;
    public int SmallSummaryLimit { get; set; } = 10;
    public int MergeOldest { get; set; } = 5;
    public void Validate()
    {
        if (MaximumRounds is < 5 or > 500 || RecentRounds < 0 || RecentRounds >= MaximumRounds
            || SmallSummaryLimit is < 2 or > 100 || MergeOldest < 2 || MergeOldest > SmallSummaryLimit)
            throw new ArgumentException("保留轮数须小于最大轮数；合并数量须在 2 与小总结上限之间。");
    }
}
public sealed class PrivateRelation : System.Text.Json.Serialization.IJsonOnDeserializing, System.Text.Json.Serialization.IJsonOnDeserialized
{
    private int _favour;
    private string _relationship = "初识";
    private bool _deserializing;
    public int Favour
    {
        get => _favour;
        set
        {
            int next = Math.Clamp(value, -100, 100);
            if (next == _favour) return;
            AnimationFrom = DisplayFavour(); AnimationStarted = Environment.TickCount64;
            _favour = next;
            if (!_deserializing) RefreshAppearance();
        }
    }
    public string Impression { get; set; } = "";
    public string Relationship
    {
        get => _relationship;
        set { _relationship = value ?? ""; if (!_deserializing) RefreshAppearance(); }
    }
    public long Revision { get; set; }
    public int HighestBond { get; set; }
    public int? SelectedBond { get; set; }
    public bool RingReceived { get; set; }
    public bool WeddingCompleted { get; set; }
    public bool OathConfirmed { get; set; }
    [System.Text.Json.Serialization.JsonIgnore] public RelationshipAppearance Appearance { get; private set; } = new(2, false, false);
    internal int AnimationFrom { get; private set; }
    internal long AnimationStarted { get; private set; }
    internal int DisplayFavour()
    {
        double elapsed = Math.Max(0, Environment.TickCount64 - AnimationStarted);
        int steps = Math.Abs(_favour - AnimationFrom);
        double duration = Math.Min(750, Math.Max(180, steps * 35));
        return elapsed >= duration ? _favour : AnimationFrom + Math.Sign(_favour - AnimationFrom) * (int)(steps * elapsed / duration);
    }
    internal void RefreshAppearance()
    {
        bool lover = OathConfirmed || SelectedBond >= 1;
        Appearance = new(RelationshipPresentation.Tier(_favour), lover, _favour >= 85 && !OathConfirmed);
        HighestBond = Math.Max(HighestBond, OathConfirmed ? 2 : lover ? 1 : 0);
    }
    void System.Text.Json.Serialization.IJsonOnDeserializing.OnDeserializing() => _deserializing = true;
    void System.Text.Json.Serialization.IJsonOnDeserialized.OnDeserialized()
    {
        _deserializing = false; RefreshAppearance(); AnimationFrom = _favour; AnimationStarted = 0;
    }
}
public sealed class PrivateConversation
{
    public List<DateDiary> DateDiaries { get; set; } = [];
    public bool EventOnly { get; set; }
    public Dictionary<string, string> DateSceneStates { get; set; } = [];
    public bool Hidden { get; set; }
    public bool Forgotten { get; set; }
    public ProactiveChatSettings Proactive { get; set; } = new();
    // 简短编号属于会话，删除或重新生成不回收，内部关联仍使用原始 Id。
    public long LastInteractionNumber { get; set; }
    public Dictionary<string, long> InteractionNumbers { get; set; } = [];
    public long LastReplyOrder { get; set; }
    public long MemoryRevision { get; set; }
    public string SummaryStatus { get; set; } = "";
    public string SummaryRequest { get; set; } = "";
    public string PersonId { get; set; } = "";
    public List<PrivateTurn> Turns { get; set; } = [];
    public int ContextStart { get; set; }
    public List<PrivateSummary> SmallSummaries { get; set; } = [];
    public List<PrivateSummary> BigSummaries { get; set; } = [];
    public string SummaryError { get; set; } = "";
    public int SeenCount { get; set; }
    public List<PrivateOffer> Offers { get; set; } = [];
}
public sealed class PrivateTurn
{
    public DateSceneRequest? Scene { get; set; }
    public List<DateSceneLine> SceneLines { get; set; } = [];
    public string ProactiveReason { get; set; } = "";
    public bool ProactiveLast { get; set; }
    public long UserOrder { get; set; }
    public long ReplyOrder { get; set; }
    public List<PrivateInteractionUndo> InteractionUndo { get; set; } = [];
    public ArbitrationRecord? Arbitration { get; set; }
    public List<PrivateProfileChange> ProfileChanges { get; set; } = [];
    public List<PrivateOffer> Attachments { get; set; } = [];
    public bool UserDeleted { get; set; }
    public bool ReplyDeleted { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public int Day { get; set; }
    public int Season { get; set; }
    public string User { get; set; } = "";
    public string Reply { get; set; } = "";
    public string Reasoning { get; set; } = "";
    public bool Regenerating { get; set; }
    public string PreviousReply { get; set; } = "";
    public string PreviousReasoning { get; set; } = "";
    public string Context { get; set; } = "";
    public string Status { get; set; } = "queued";
    public string Error { get; set; } = "";
    public bool Applied { get; set; }
    public PrivateLearning? Learning { get; set; }
    public PrivateMood? Mood { get; set; }
    public string RequestKind { get; set; } = "";
    public PrivateOffer? Request { get; set; }
}
public sealed class PrivateLearning
{
    public string Id { get; set; } = "";
    public string Source { get; set; } = "";
    public string Topic { get; set; } = "";
    public string Reason { get; set; } = "";
    public int Strength { get; set; }
    public int Ascension { get; set; }
    public double Before { get; set; }
    public double After { get; set; }
}
public sealed class PrivateMood
{
    public string Id { get; set; } = "";
    public string Source { get; set; } = "";
    public int Strength { get; set; }
    public int Day { get; set; }
    public int Days { get; set; }
    public string Reason { get; set; } = "";
    public int Ascension { get; set; }
    public double Before { get; set; }
    public double After { get; set; }
}
public sealed class PrivateSummary
{
    public int From { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Text { get; set; } = "";
    public int Through { get; set; }
    public bool IsLatest(IEnumerable<PrivateSummary> summaries) => !summaries.Any(s => s.Through > Through);
}
public sealed class PrivateOffer
{
    public string ConsumerAttachmentId { get; set; } = "";
    public int RelationshipIntent { get; set; }
    public bool MemoryDeleted { get; set; }
    public string GoodId { get; set; } = "";
    public string GoodVerb { get; set; } = "";
    public int Quantity { get; set; } = 1;
    public bool PublicAttendance { get; set; }
    public string ServiceId { get; set; } = "";
    public string GroupId { get; set; } = "";
    public string CoachId { get; set; } = "";
    public bool CoachAccepted { get; set; }
    public string ActorId { get; set; } = "";
    public List<string> Participants { get; set; } = [];
    public List<string> RelatedPeople { get; set; } = [];
    public int FavourBefore { get; set; }
    public List<int> FavourTargets { get; set; } = [];
    public string FirstPerson { get; set; } = "";
    public string SecondPerson { get; set; } = "";
    public string ReplacesOfferId { get; set; } = "";
    public long PostRevision { get; set; }
    public string Title { get; set; } = "";
    public string ResponseAction { get; set; } = "";
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string TurnId { get; set; } = "";
    public string Kind { get; set; } = "";
    public string State { get; set; } = "待确认";
    public string Detail { get; set; } = "";
    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
    public string? AiDetail { get; set; }
    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
    public CommunityQuote? Quote { get; set; }
    public int Season { get; set; }
    public int Day { get; set; }
    public int Ascension { get; set; }
    public string Mode { get; set; } = "切磋";
    public decimal Signing { get; set; }
    public decimal Wage { get; set; }
    public decimal WinBonus { get; set; }
    public int Weeks { get; set; } = 8;
    public string Role { get; set; } = "轮换";
    public string MatchId { get; set; } = "";
}

public sealed class CommunityQuote
{
    public string PostId { get; set; } = "";
    public string ReplyId { get; set; } = "";
    public string ParentId { get; set; } = "";
    public long PostRevision { get; set; }
    public string PostTitle { get; set; } = "";
    public string PostAuthorId { get; set; } = "";
    public string PostAuthorName { get; set; } = "";
    public string PostBody { get; set; } = "";
    public string PostSourceBody { get; set; } = "";
    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
    public string? PostAiSourceBody { get; set; }
    public int PostDay { get; set; }
    public string AuthorId { get; set; } = "";
    public string AuthorName { get; set; } = "";
    public string Body { get; set; } = "";
    public int Day { get; set; }
    public List<CommunityQuoteReply> Parents { get; set; } = [];
}

public sealed class CommunityQuoteReply
{
    public string Id { get; set; } = "";
    public string ParentId { get; set; } = "";
    public string AuthorId { get; set; } = "";
    public string AuthorName { get; set; } = "";
    public string Body { get; set; } = "";
    public int Day { get; set; }
}

public static class PrivateInteractionIds
{
    public static string Number(PrivateConversation conversation, PrivateOffer offer)
    {
        if (!conversation.InteractionNumbers.TryGetValue(offer.Id, out long number))
        {
            number = ++conversation.LastInteractionNumber;
            conversation.InteractionNumbers.Add(offer.Id, number);
        }
        return number.ToString(System.Globalization.CultureInfo.InvariantCulture);
    }

    public static void Ensure(PrivateConversation conversation)
    {
        var offers = conversation.Offers.ToLookup(o => o.TurnId);
        foreach (var turn in conversation.Turns)
        {
            foreach (var attachment in turn.Attachments.Where(a => a.Kind is "training" or "lineup" or "gift" or "activity")) Number(conversation, attachment);
            if (turn.Request is { Kind: "training" or "lineup" or "activity" } request) Number(conversation, request);
            foreach (var offer in offers[turn.Id].Where(o => o.Kind == "activity")) Number(conversation, offer);
        }
        foreach (var offer in conversation.Offers.Where(o => o.Kind == "activity")) Number(conversation, offer);
    }

    public static string? Resolve(PrivateConversation conversation, string? number)
    {
        if (number == null) return null;
        // 旧回复和旧存档仍可使用完整编号。
        if (conversation.InteractionNumbers.ContainsKey(number)) return number;
        if (long.TryParse(number, System.Globalization.NumberStyles.None, System.Globalization.CultureInfo.InvariantCulture, out long value))
            return conversation.InteractionNumbers.FirstOrDefault(p => p.Value == value).Key ?? number;
        return number;
    }
}
