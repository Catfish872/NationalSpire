namespace NationalSpire;

public sealed class CareerData
{
    public FailureDecision? Failure { get; set; }
    [System.Text.Json.Serialization.JsonIgnore] public Dictionary<string, PrivateMailbox> PrivateMemorySources { get; set; } = [];
    public Dictionary<string, Dictionary<string, int>> HumanFavours { get; set; } = [];
    public Dictionary<string, string> PrivatePromptSnapshot { get; set; } = [];
    public CareerPerson? PlayerCard { get; set; }
    public Dictionary<string, PlayerDevelopment> Development { get; set; } = [];
    public Dictionary<string, int> ProfessionalDebuts { get; set; } = [];
    public HashSet<string> CeremonyRewardReceipts { get; set; } = [];
    public int DebutVersion { get; set; }
    [System.Text.Json.Serialization.JsonIgnore] public string AvatarWorldId { get; set; } = "";
    [System.Text.Json.Serialization.JsonIgnore] public string LocalHumanId { get; set; } = "";
    public int CooperativeMembers { get; set; } = 1;
    public int RivalLevel { get; set; } = 1000;
    public bool RandomCharacter { get; set; }
    public List<string> HumanIds { get; set; } = [];
    public Dictionary<string, string> HumanFrames { get; set; } = [];
    public Dictionary<string, PlayerAvatar> HumanAvatars { get; set; } = [];
    public PlayerAvatar SelectedAvatar { get; set; } = new();
    public Dictionary<string, int> HumanClears { get; set; } = [];
    [System.Text.Json.Serialization.JsonIgnore] public Action<CareerData>? ExternalSave { get; set; }
    [System.Text.Json.Serialization.JsonIgnore] public Func<bool>? ExternalCurrent { get; set; }
    public CameoState Cameos { get; set; } = new();
    public string PlayerAlias { get; set; } = "";
    public string PlayerGender { get; set; } = IdentityGender.Unset;
    public List<string> PlayerNameAliases { get; set; } = [];
    public string PendingSettlementId { get; set; } = "";
    public int PendingCeremonySeason { get; set; }
    public List<CeremonyRecord> Ceremonies { get; set; } = [];
    public CareerLifeState Life { get; set; } = new();
    public int AvatarHighestClear { get; set; } = -1;
    public string SelectedAvatarFrame { get; set; } = "auto";
    public Dictionary<string, string> AvatarFrames { get; set; } = [];
    public int LongSeasonsFrom { get; set; }
    public bool AutoQualifiers { get; set; } = true;
    public BroadcastUiState BroadcastUi { get; set; } = new();
    public List<WeeklyEdition> WeeklyEditions { get; set; } = [];
    public Dictionary<string, string> WeeklyPersonBaselines { get; set; } = [];
    public string PlayerIntroduction { get; set; } = "";
    public int PlayerIntroductionDay { get; set; }
    public int Version { get; set; } = 4;
    public int ContentVersion { get; set; }
    public int ContentPoolVersion { get; set; }
    public Dictionary<string, List<string>> BroadcastHistory { get; set; } = [];
    public int IdentityVersion { get; set; }
    public int CommunityVersion { get; set; }
    public List<CommunityPost> SavedThreads { get; set; } = [];
    public List<CommunityMemory> CommunityMemories { get; set; } = [];
    public EsportsCareer Esports { get; set; } = new();
    public string WorldId { get; set; } = Guid.NewGuid().ToString("N")[..8];
    public int Draws { get; set; }
    public long PendingSince { get; set; }
    public int Day { get; set; } = 1;
    public int Season { get; set; } = 1;
    public int Rating { get; set; } = 1000;
    public int Fans { get; set; } = 28;
    public int Credits { get; set; } = 0;
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int SelectedAscension { get; set; }
    public string SelectedCharacter { get; set; } = "";
    public string? PendingMatchId { get; set; }
    public List<CareerMatch> Matches { get; set; } = [];
    public List<CareerPerson> People { get; set; } = [];
    public Dictionary<string, CareerPerson> DeletedPeople { get; set; } = [];
    public List<string> MatchHumanIds { get; set; } = [];
    public HashSet<string> PendingHistoryExcluded { get; set; } = [];
    public List<TeamPreparation> TeamPreparations { get; set; } = [];
    public List<CommunityPost> Posts { get; set; } = [];
    public List<CareerResult> Results { get; set; } = [];
    public List<CareerStanding> Standings { get; set; } = [];
    public List<SeasonRecap> SeasonHistory { get; set; } = [];
    public AiOptions Ai { get; set; } = new();
}

public sealed class CareerStanding
{
    public int Clears { get; set; }
    public int Draws { get; set; }
    public string PersonId { get; set; } = "";
    public int Points { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
}

public sealed class SeasonRecap
{
    public int Season { get; set; }
    public int Rank { get; set; }
    public int Points { get; set; }
    public int Prize { get; set; }
}

public sealed class CareerMatch
{
    public List<string> CommentatorIds { get; set; } = [];
    public bool RegistrationDeclined { get; set; }
    public LiveMatchState? Live { get; set; }
    public string Kind { get; set; } = "legacy";
    public string CompetitionId { get; set; } = "";
    public string FixtureId { get; set; } = "";
    public int Round { get; set; }
    public string Decider { get; set; } = "";
    public bool Draw { get; set; }
    public int? PlayedAscension { get; set; }
    public int? ChosenAscension { get; set; }
    public bool OpponentPrepared { get; set; }
    public double? OpponentSeconds { get; set; }
    public double? PlayerSeconds { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public int Day { get; set; }
    public string Event { get; set; } = "";
    public string OpponentId { get; set; } = "";
    public string Seed { get; set; } = "";
    public bool SeedRandomized { get; set; }
    public int Prize { get; set; }
    public int RequiredAscension { get; set; }
    public bool Registered { get; set; }
    public string Status { get; set; } = "待赛";
    public bool PlayerWon { get; set; }
    public bool OpponentWon { get; set; }
    public int OpponentFloor { get; set; }
    public int PlayerFloor { get; set; }
}

public sealed class CareerPerson
{
    public string ClubPosition { get; set; } = "";
    public List<ArbitrationRecord> Arbitrations { get; set; } = [];
    public HashSet<string> PrivateProfileReceipts { get; set; } = [];
    public bool EditedCard { get; set; }
    public bool CreatedCard { get; set; }
    public string AbilityTemplate { get; set; } = "";
    public double? CustomClearChance { get; set; }
    public NpcLearning Learning { get; set; } = new();
    public PlayerAvatar Avatar { get; set; } = new();
    public string Gender { get; set; } = "";
    public double RatingGrowthRemainder { get; set; }
    public int RecordVersion { get; set; }
    public int RecruitVersion { get; set; }
    public int RecordedWinStreak { get; set; }
    public int RecordedStreakAscension { get; set; } = -1;
    public string CameoId { get; set; } = "";
    public List<string> Identities { get; set; } = [];
    public List<string> Connections { get; set; } = [];
    public PersonalityProfile Personality { get; set; } = new();
    public string AiIntroduction { get; set; } = "";
    public int IntroductionDay { get; set; }
    public string Temperament { get; set; } = "";
    public string Biography { get; set; } = "";
    public string SupportedClubId { get; set; } = "";
    public string Country { get; set; } = "中国";
    public string ClubId { get; set; } = "";
    public string Form { get; set; } = "";
    public int Titles { get; set; }
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public List<string> HandleAliases { get; set; } = [];
    public string Handle { get; set; } = "";
    [System.Text.Json.Serialization.JsonIgnore]
    public string PublicName => Handle.Length > 0 ? Handle : Name;
    public string Region { get; set; } = "";
    public string Character { get; set; } = "";
    public string Style { get; set; } = "";
    public int MaxAscension { get; set; }
    public int PrivateHighestClear { get; set; } = -1;
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int Rating { get; set; }
    public string Role { get; set; } = "观众";
    public string Voice { get; set; } = "";
}

public sealed class CommunityPost
{
    public bool PersonalPost { get; set; }
    public List<string> MentionedPeople { get; set; } = [];
    public string NewsTopic { get; set; } = "";
    public string RelatedFacts { get; set; } = "";
    public PublicSchedule? Schedule { get; set; }
    public List<CareerPerson> PeopleAtEvent { get; set; } = [];
    public AiWorkState NewsGeneration { get; set; } = new();
    public AiWorkState ReactionGeneration { get; set; } = new();
    public bool NeedsReaction { get; set; }
    public string MatchKind { get; set; } = "";
    public long Revision { get; set; } = 1;
    public long SeenRevision { get; set; }
    public int EditorialVersion { get; set; }
    public string SourceTitle { get; set; } = "";
    public string SourceBody { get; set; } = "";
    public int Priority { get; set; } = 1;
    public string Category { get; set; } = "社区";
    public List<string> RelatedPeople { get; set; } = [];
    public string Analysis { get; set; } = "";
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public int Day { get; set; }
    public string EventKey { get; set; } = "";
    public string Title { get; set; } = "";
    public string AuthorId { get; set; } = "";
    public string Body { get; set; } = "";
    public List<CommunityReply> Replies { get; set; } = [];
    public bool AiPending { get; set; }
}

public sealed class CommunityReply
{
    public List<string> MentionedPeople { get; set; } = [];
    public bool AiGenerated { get; set; }
    public AiWorkState ReactionGeneration { get; set; } = new();
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string ParentId { get; set; } = "";
    public int Day { get; set; }
    public bool NeedsReaction { get; set; }
    public List<string> Covers { get; set; } = [];
    public string AuthorId { get; set; } = "";
    public string Body { get; set; } = "";
}

public sealed class AiWorkState
{
    [System.Text.Json.Serialization.JsonIgnore]
    public string WaitReason { get; set; } = "";
    public string State { get; set; } = "idle";
    public string Error { get; set; } = "";
}

public sealed class CommunityMemory
{
    public string Id { get; set; } = "";
    public string PostId { get; set; } = "";
    public int Day { get; set; }
    public string Kind { get; set; } = "fact";
    public List<string> People { get; set; } = [];
    public string Text { get; set; } = "";
}

public sealed class CareerResult
{
    public List<string> PlayerParticipants { get; set; } = [];
    public List<string> OpponentParticipants { get; set; } = [];
    public List<string> LifeEffects { get; set; } = [];
    public SettlementRecord? Settlement { get; set; }
    public string WorldImpact { get; set; } = "";
    public RunEvidence Evidence { get; set; } = new();
    public List<string> DeckSummary { get; set; } = [];
    public bool OfficialAscensionVerified { get; set; } = true;
    public int? PlayedAscension { get; set; }
    public double? RunSeconds { get; set; }
    public double RewardMultiplier { get; set; } = 1;
    public string OpponentId { get; set; } = "";
    public string CompetitionId { get; set; } = "";
    public string Kind { get; set; } = "legacy";
    public string MatchId { get; set; } = "";
    public string Outcome { get; set; } = "";
    public int RatingDelta { get; set; }
    public int FansDelta { get; set; }
    public int Prize { get; set; }
    public int Day { get; set; }
    public string Event { get; set; } = "";
    public string Opponent { get; set; } = "";
    public string CharacterId { get; set; } = "";
    public string Character { get; set; } = "";
    public int Ascension { get; set; }
    public bool Win { get; set; }
    public int Floor { get; set; }
    public string Seed { get; set; } = "";
    public List<string> Cards { get; set; } = [];
}

public sealed class AiOptions : System.Text.Json.Serialization.IJsonOnDeserializing, System.Text.Json.Serialization.IJsonOnDeserialized
{
    public int PrivatePromptVersion { get; set; }
    public string PromptTemplate { get; set; } = PromptLibrary.DefaultTemplate;
    public Dictionary<string, CustomPromptTemplate> CustomPromptTemplates { get; set; } = new();
    public Dictionary<string, Dictionary<string, string>> PromptTemplateOverrides { get; set; } = new();
    public Dictionary<string, string> PromptOverrides { get; set; } = new();
    public int MaxConcurrentRequests { get; set; } = 3;
    public int MinimumIntervalSeconds { get; set; } = 60;
    public int RequestTimeoutMinutes { get; set; } = 10;
    public bool Enabled { get; set; }
    public string Endpoint { get; set; } = "https://api.deepseek.com/v1";
    public int EndpointFormatVersion { get; set; } = 1;
    void System.Text.Json.Serialization.IJsonOnDeserializing.OnDeserializing() => EndpointFormatVersion = 0;
    void System.Text.Json.Serialization.IJsonOnDeserialized.OnDeserialized()
    {
        // 仅迁移未记录地址规则的旧配置，保持旧版实际请求地址不变。
        if (EndpointFormatVersion == 0 && Uri.TryCreate(Endpoint?.Trim(), UriKind.Absolute, out var uri)
            && uri.Scheme is "http" or "https" && uri.AbsolutePath.TrimEnd('/').Length == 0)
            Endpoint = new UriBuilder(uri) { Path = "/v1" }.Uri.AbsoluteUri;
        EndpointFormatVersion = 1;
    }

    public string Model { get; set; } = "deepseek-flash";
    public const int MaximumNewsPostCount = 20;
    public int MaxNewsPosts { get; set; } = 3;
    public int RequestsToday { get; set; }
    public int RequestDay { get; set; }
}

