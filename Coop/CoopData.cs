using System.Text.Encodings.Web;
using System.Text.Json;

namespace NationalSpire.Coop;

public static class CoopJson
{
    public static readonly JsonSerializerOptions Options = new() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
    private static readonly JsonSerializerOptions PublicOptions = PublicSettings();
    private static JsonSerializerOptions PublicSettings()
    {
        var resolver = new System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver();
        resolver.Modifiers.Add(info =>
        {
            if (info.Type == typeof(CareerData))
                info.Properties.Single(p => p.Name == nameof(CareerData.Ai)).Get = value => new AiOptions { Enabled = ((CareerData)value).Ai.Enabled };
        });
        return new(Options) { TypeInfoResolver = resolver };
    }
    // 直接序列化公开字段，避免为删除本地AI配置而复制整份世界。
    public static byte[] PublicBytes<T>(T value) => JsonSerializer.SerializeToUtf8Bytes(value, PublicOptions);
    public static byte[] Bytes<T>(T value) => JsonSerializer.SerializeToUtf8Bytes(value, Options);
    public static T Read<T>(byte[] bytes) => JsonSerializer.Deserialize<T>(bytes, Options) ?? throw new InvalidDataException("数据为空");
    public static T Copy<T>(T value) => Read<T>(Bytes(value));
    public static string Hash(byte[] bytes) => Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(bytes));
    public static void Detached(CareerData d) { d.ExternalSave = _ => { }; d.ExternalCurrent = () => false; }
}

public sealed class CoopWorld
{
    public const int Protocol = 1;
    public int Schema { get; set; } = 1;
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Name { get; set; } = "共同生涯";
    public ulong Owner { get; set; }
    public int Capacity { get; set; } = 2;
    public string Epoch { get; set; } = Guid.NewGuid().ToString("N");
    public long Revision { get; set; }
    public CareerData World { get; set; } = new();
    public List<CoopMember> Members { get; set; } = [];
    public bool RosterLocked { get; set; }
    public bool CareerStarted { get; set; }
    public int EntrySequence { get; set; }
    public CoopProposal? Proposal { get; set; }
    public CoopRun? Run { get; set; }
    public List<CoopSettlement> Settlements { get; set; } = [];
    public HashSet<string> NativeHistoryReceipts { get; set; } = [];
    public Dictionary<string, CoopReceipt> Receipts { get; set; } = [];
    public string LatestCheckpoint { get; set; } = "";
    // 仅同步保存流程使用浅副本；序列化完成前不异步访问共享集合。
    public CoopWorld CheckpointHeader(string id) { var copy = (CoopWorld)MemberwiseClone(); copy.LatestCheckpoint = id; return copy; }
    public CoopWorld RunCheckpoint()
    {
        var copy = (CoopWorld)MemberwiseClone(); copy.Revision++;
        copy.Run = Run?.CheckpointCopy();
        return copy;
    }
}
public sealed class CoopMember
{
    public CareerPerson? Card { get; set; }
    public int SeenCeremonySeason { get; set; }
    public HashSet<string> CeremonyReceipts { get; set; } = [];
    public List<CareerHonor> CeremonyHonors { get; set; } = [];
    public ulong SteamId { get; set; }
    public string PersonId => "human-" + SteamId;
    public string Name { get; set; } = "参赛选手";
    public string Gender { get; set; } = IdentityGender.Unset;
    public string Character { get; set; } = "";
    public bool RandomCharacter { get; set; }
    public int Credits { get; set; }
    public int Fans { get; set; } = 28;
    public int Rating { get; set; } = 1000;
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int Draws { get; set; }
    public int HighestClear { get; set; } = -1;
    public string AvatarFrame { get; set; } = "auto";
    public PlayerAvatar Avatar { get; set; } = new();
    public int PaidSeason { get; set; }
    public CareerLifeState Life { get; set; } = new();
    public List<SponsorContract> Sponsors { get; set; } = [];
    public List<SponsorContract> SponsorOffers { get; set; } = [];
    public List<CareerResult> Results { get; set; } = [];
    public List<string> Aliases { get; set; } = [];
    public Dictionary<string, long> ReadPosts { get; set; } = [];
    public Dictionary<int, long> ReadWeeks { get; set; } = [];
    public string SeenSettlement { get; set; } = "";
}
public sealed class CoopProposal
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Kind { get; set; } = "";
    public string Target { get; set; } = "";
    public int Number { get; set; }
    public string Label { get; set; } = "";
    public HashSet<ulong> Votes { get; set; } = [];
    public HashSet<ulong> Participants { get; set; } = [];
}
public sealed class CoopRun
{
    public string Attempt { get; set; } = Guid.NewGuid().ToString("N");
    public string MatchId { get; set; } = "";
    public string Phase { get; set; } = "preparing";
    public int ResumeCount { get; set; }
    public string FailureReason { get; set; } = "";
    public int Ascension { get; set; }
    public string Seed { get; set; } = "";
    public Dictionary<ulong, string> Characters { get; set; } = [];
    public List<string> Opponents { get; set; } = [];
    public LiveMatchState? Rival { get; set; }
    public Dictionary<string, LiveMatchState> RivalMembers { get; set; } = [];
    public double Clock { get; set; }
    public int Floor { get; set; }
    public int Act { get; set; }
    public List<CoopLivePlayer> Players { get; set; } = [];
    public List<string> Commentary { get; set; } = [];
    public Dictionary<ulong, BroadcastMemory> Broadcasts { get; set; } = [];
    public List<CoopSpeech> Speeches { get; set; } = [];
    public CoopTerminalResult? Terminal { get; set; }
    public CoopRun CheckpointCopy() => (CoopRun)MemberwiseClone();
}
public sealed record CoopTerminalResult(bool Win, int Floor, double Seconds, List<CoopLivePlayer> Players)
{ public Dictionary<ulong, CareerResult> Details { get; set; } = []; }
public sealed record CoopSpeech(string Id, string Speaker, string Text, string Topic)
{ public string Role { get; init; } = "commentator"; }
public sealed record CoopLivePlayer(ulong Id, string Character, int Hp, int MaxHp, bool Dead);
public sealed class CoopSettlement
{
    public string Attempt { get; set; } = "";
    public string MatchId { get; set; } = "";
    public string Title { get; set; } = "";
    public string Outcome { get; set; } = "";
    public bool Cleared { get; set; }
    public int Floor { get; set; }
    public double Seconds { get; set; }
    public int Day { get; set; }
    public Dictionary<ulong, int> Payouts { get; set; } = [];
    public List<CoopLivePlayer> Players { get; set; } = [];
    public SettlementRecord? Rankings { get; set; }
}
public sealed record CoopReceipt(string Fingerprint, string Result, long Revision);
public sealed record CoopCommand(string World, string Epoch, string Id, long Revision, string Kind, string Target = "", string Text = "", int Number = 0, string Parent = "");
public sealed record CoopOutcome(bool Accepted, string Message, bool Duplicate = false);

public sealed class CoopReading
{
 public Dictionary<string,long> Posts {get;set;} = [];
 public Dictionary<int,long> Weeks {get;set;} = [];
 public string Settlement {get;set;} = "";
}
