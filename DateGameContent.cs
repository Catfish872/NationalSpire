using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace NationalSpire;

public sealed class DateGameTiming
{
    public double SpeechSeconds { get; set; } = 7;
    public double ChatSeconds { get; set; } = DateGames.ChatRequestInterval;
    public int FastMinimumFloor { get; set; } = 20;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public double AmbientMinimumSeconds { get; set; } // 读取旧文件；新触发器已取消定时闲聊。
}

/// <summary>仅保存玩家改过的条目；默认内容继续随模组更新。</summary>
public sealed class DateVoiceEdits
{
    public Dictionary<string, string> Lines { get; set; } = [];
    public Dictionary<string, string> Remarks { get; set; } = [];
    public Dictionary<string, List<string>> Triggers { get; set; } = [];
}

/// <summary>可往返的约会对局内容包；验证通过后一次应用，作用域为当前生涯的约会对局。</summary>
public static class DateGameContent
{
    public sealed class Phrase
    {
        public string Context { get; set; } = "";
        public string[] Variables { get; set; } = [];
        public string Text { get; set; } = "";
    }
    public sealed class Profile
    {
        [JsonRequired] public string Name { get; set; } = "";
        [JsonRequired] public Dictionary<string, string> Lines { get; set; } = [];
        [JsonRequired] public Dictionary<string, string> Remarks { get; set; } = [];
        public Dictionary<string, TriggerSpeech> Triggers { get; set; } = [];
    }
    public sealed class TriggerSpeech
    {
        public string Condition { get; set; } = "";
        [JsonRequired] public List<string> Lines { get; set; } = [];
    }
    public sealed class RuleSetting
    {
        [JsonRequired] public string Trigger { get; set; } = "";
        [JsonRequired] public bool Enabled { get; set; }
        [JsonRequired] public bool Chat { get; set; }
        [JsonRequired] public double Threshold { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Lines { get; set; } // v1 公共候选句兼容读取。
    }
    public sealed class Bundle
    {
        [JsonRequired] public string Format { get; set; } = "national-spire-date-game-content";
        [JsonRequired] public int Version { get; set; } = 2;
        [JsonRequired] public DateGameTiming Timing { get; set; } = new();
        [JsonRequired] public List<DateGameRule> Rules { get; set; } = [];
        [JsonRequired] public Dictionary<string, string> Conditions { get; set; } = [];
        [JsonRequired] public Dictionary<string, Phrase> Catalog { get; set; } = [];
        [JsonRequired] public Dictionary<string, Profile> Profiles { get; set; } = [];
    }
    public sealed class VoiceFile
    {
        [JsonRequired] public string Format { get; set; } = "national-spire-date-game-voice";
        [JsonRequired] public int Version { get; set; } = 2;
        [JsonRequired] public string Personality { get; set; } = "";
        [JsonRequired] public Profile Profile { get; set; } = new();
        [JsonRequired] public Dictionary<string, Phrase> Catalog { get; set; } = [];
    }
    public sealed class RuleFile
    {
        [JsonRequired] public string Format { get; set; } = "national-spire-date-game-rules";
        [JsonRequired] public int Version { get; set; } = 2;
        [JsonRequired] public DateGameTiming Timing { get; set; } = new();
        [JsonRequired] public List<RuleSetting> Rules { get; set; } = [];
        [JsonRequired] public Dictionary<string, string> Conditions { get; set; } = [];
    }
    private static readonly JsonSerializerOptions Json = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow, MaxDepth = 32
    };
    private static readonly Lazy<Dictionary<string, Phrase>> Catalog = new(BuildCatalog);
    public static string Key(string source) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(source)))[..24].ToLowerInvariant();
    private static string[] Variables(string source) => Regex.Matches(source, @"\{[^{}]+\}").Select(m => m.Value).Distinct().Order(StringComparer.Ordinal).ToArray();
    private static Dictionary<string, Phrase> BuildCatalog()
    {
        var result = new Dictionary<string, Phrase>();
        void Add(string context, IEnumerable<string> lines)
        {
            foreach (string text in lines.Where(t => t.Length > 0))
            {
                string key = Key(text);
                if (result.TryGetValue(key, out var previous)) previous.Context += " / " + context;
                else result[key] = new() { Context = context, Text = text, Variables = Variables(text) };
            }
        }
        foreach (var (context, lines) in LiveCommentary.DateContentBanks()) Add(context, lines);
        foreach (var (context, lines) in LiveVoiceCatalog.Banks.Where(p => p.Key.StartsWith("thought_", StringComparison.Ordinal) || (p.Key.StartsWith("host_", StringComparison.Ordinal) || p.Key.StartsWith("shop_", StringComparison.Ordinal)))) Add("内心或现场发言：" + context, lines);
        foreach (var (context, lines) in LiveSpeechComposer.Endings.Where(p => p.Key.StartsWith("thought_", StringComparison.Ordinal) || (p.Key.StartsWith("host_", StringComparison.Ordinal) || p.Key.StartsWith("shop_", StringComparison.Ordinal)) || p.Key.StartsWith("world_", StringComparison.Ordinal))) Add("可选补句：" + context, lines);
        return result;
    }
    public static Dictionary<string, string> DefaultRemarks(string profile)
    {
        int index = Array.IndexOf(DateGameVoices.Ids, profile);
        return DateGameVoices.Remarks.ToDictionary(p => p.Key, p => index <= 0 ? "" : p.Value[index - 1]);
    }
    public static Bundle Snapshot(CareerData data, List<DateGameRule>? drafts = null)
    {
        var bundle = new Bundle { Timing = Coop.CoopJson.Copy(data.DateGameTiming), Rules = Coop.CoopJson.Copy(DateGames.UpgradeRules(drafts ?? data.DateGameRules)),
            Catalog = Coop.CoopJson.Copy(Catalog.Value), Conditions = Conditions() };
        bundle.Timing.FastMinimumFloor = Math.Max(20, bundle.Timing.FastMinimumFloor); bundle.Timing.AmbientMinimumSeconds = 0;
        foreach (var rule in bundle.Rules)
            foreach (string text in rule.Lines.Where(t => t.Length > 0))
                bundle.Catalog.TryAdd(Key(text), new() { Context = "请求或事件台词：" + rule.Trigger, Text = text, Variables = [] });
        for (int i = 0; i < DateGameVoices.Ids.Length; i++)
        {
            string id = DateGameVoices.Ids[i];
            var edits = data.DateGameVoiceEdits.GetValueOrDefault(id);
            bundle.Profiles[id] = new() { Name = DateGameVoices.Labels[i],
                Lines = bundle.Catalog.ToDictionary(p => p.Key, p => edits?.Lines.GetValueOrDefault(p.Key) ?? p.Value.Text),
                Remarks = DefaultRemarks(id).ToDictionary(p => p.Key, p => edits?.Remarks.GetValueOrDefault(p.Key) ?? p.Value),
                Triggers = bundle.Rules.ToDictionary(r => r.Trigger, r => new TriggerSpeech {
                    Condition = bundle.Conditions[r.Trigger], Lines = DateGameVoices.EventLines(data, id, r).ToList() }) };
        }
        return bundle;
    }
    public static string Export(CareerData data, List<DateGameRule>? drafts = null) => JsonSerializer.Serialize(Snapshot(data, drafts), Json);
    public static Bundle Read(string text)
    {
        using var document = Parse(text);
        var bundle = JsonSerializer.Deserialize<Bundle>(text, Json) ?? throw new InvalidDataException("文件为空。");
        if (bundle.Format == "national-spire-date-game-content" && bundle.Version == 1 && bundle.Rules != null && bundle.Timing != null && bundle.Catalog != null && bundle.Profiles != null)
        {
            var ids = DateGames.Defaults().Select(r => r.Trigger).Concat(["start", "ambient"]).ToHashSet();
            if (bundle.Rules.Any(r => r == null || !ids.Remove(r.Trigger))) throw new InvalidDataException("旧版文件含未知或重复的触发编号。");
            bundle.Rules = DateGames.UpgradeRules(bundle.Rules); bundle.Timing.FastMinimumFloor = Math.Max(20, bundle.Timing.FastMinimumFloor);
            bundle.Timing.AmbientMinimumSeconds = 0; bundle.Version = 2; bundle.Conditions = Conditions();
            foreach (var rule in bundle.Rules)
                foreach (string line in rule.Lines)
                    if (bundle.Catalog.TryAdd(Key(line), new() { Text = line, Context = "请求或事件台词：" + rule.Trigger }))
                        foreach (var profile in bundle.Profiles.Values) profile.Lines.TryAdd(Key(line), line);
        }
        Validate(bundle); return bundle;
    }
    private static JsonDocument Parse(string text)
    {
        if (Encoding.UTF8.GetByteCount(text) > 24 * 1024 * 1024) throw new InvalidDataException("台词文件超过24MB，请缩短内容后再导入。");
        var document = JsonDocument.Parse(text, new() { MaxDepth = 32 });
        try { CheckDuplicateKeys(document.RootElement); return document; }
        catch { document.Dispose(); throw; }
    }
    public static string Import(CareerData data, string text)
    {
        using var document = Parse(text);
        string? format = document.RootElement.TryGetProperty("format", out var field) ? field.GetString() : null;
        if (format == "national-spire-date-game-voice")
        {
            var file = JsonSerializer.Deserialize<VoiceFile>(text, Json)!;
            if (file.Version is not (1 or 2) || !DateGameVoices.Ids.Contains(file.Personality)) throw new InvalidDataException("性格文件版本或编号无效。");
            var bundle = new Bundle { Rules = DateGames.UpgradeRules(data.DateGameRules), Catalog = file.Catalog, Profiles = new() { [file.Personality] = file.Profile } };
            Validate(bundle, partial: true);
            if (file.Version == 2 && file.Profile.Triggers.Count != bundle.Rules.Count) throw new InvalidDataException("性格文件需保留全部十种事件的触发编号及候选台词。");
            data.DateGameVoiceEdits[file.Personality] = Edits(file.Personality, file.Profile, file.Catalog, bundle.Rules);
            return "已读取“" + DateGameVoices.Labels[Array.IndexOf(DateGameVoices.Ids, file.Personality)] + "”的台词";
        }
        if (format == "national-spire-date-game-rules")
        {
            var file = JsonSerializer.Deserialize<RuleFile>(text, Json)!;
            if (file.Version is not (1 or 2) || file.Rules == null || file.Rules.Any(r => r == null || (file.Version == 1 ? r.Lines == null : r.Lines != null))) throw new InvalidDataException("触发规则文件版本或字段无效。");
            var current = DateGames.UpgradeRules(data.DateGameRules).ToDictionary(r => r.Trigger);
            var rules = file.Rules.Select(r => new DateGameRule { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold,
                Lines = r.Lines?.ToList() ?? current.GetValueOrDefault(r.Trigger)?.Lines.ToList() ?? [] }).ToList();
            Validate(new() { Rules = rules, Timing = file.Timing, Conditions = file.Conditions, Catalog = Catalog.Value }, partial: true);
            data.DateGameRules = rules; data.DateGameTiming = Coop.CoopJson.Copy(file.Timing);
            return "已读取公共触发条件";
        }
        if (format == "national-spire-date-game-content") { Apply(data, Read(text)); return "已读取旧版综合文件并升级触发条件"; }
        throw new InvalidDataException("请选择对局发言性格文件或公共触发条件文件。");
    }
    private static void CheckDuplicateKeys(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Object)
        {
            var names = new HashSet<string>(StringComparer.Ordinal);
            foreach (var field in element.EnumerateObject())
            {
                if (!names.Add(field.Name)) throw new InvalidDataException("文件中有重复字段：" + field.Name);
                CheckDuplicateKeys(field.Value);
            }
        }
        else if (element.ValueKind == JsonValueKind.Array) foreach (var item in element.EnumerateArray()) CheckDuplicateKeys(item);
    }
    public static void Validate(Bundle bundle, bool partial = false)
    {
        void Require(bool condition, string message) { if (!condition) throw new InvalidDataException(message); }
        Require(bundle.Format == "national-spire-date-game-content" && bundle.Version == 2, "请选择当前版本的约会对局内容。");
        Require(bundle.Timing != null && bundle.Rules != null && bundle.Profiles != null && bundle.Catalog != null && bundle.Conditions != null, "文件缺少完整的规则或台词内容。");
        var timing = bundle.Timing!;
        Require(new[] { timing.SpeechSeconds, timing.ChatSeconds }.All(v => double.IsFinite(v) && v >= 0 && v <= 3600)
            && timing.FastMinimumFloor is >= 20 and <= 999, "间隔需在0～3600秒之间，快速推进起始楼层需在20～999之间。");
        var triggers = DateGames.Defaults().Select(r => r.Trigger).ToHashSet();
        Require(bundle.Rules!.Count == triggers.Count && bundle.Rules.All(r => r != null && triggers.Remove(r.Trigger)) && triggers.Count == 0, "请保留十种事件的原编号，每种出现一次。");
        foreach (var rule in bundle.Rules)
        {
            Require(double.IsFinite(rule.Threshold) && rule.Threshold is >= 0 and <= 3600, "事件阈值需在0～3600之间：" + rule.Trigger);
            Require(rule.Lines != null && rule.Lines.Count <= 100 && (!rule.Enabled || rule.Lines.Count > 0), "启用的事件需要1～100句台词：" + rule.Trigger);
            foreach (string line in rule.Lines!) Require(!string.IsNullOrWhiteSpace(line) && line.Length <= 1000 && !line.Contains('{') && !line.Contains('}'), "事件台词需为1～1000字的普通文本：" + rule.Trigger);
        }
        Require(bundle.Catalog!.Count <= Catalog.Value.Count + 800, "条目数量超出范围。");
        // 旧事件台词仍可作为参考保留；实际触发使用rules中的新台词。
        foreach (var (key, phrase) in bundle.Catalog)
            Require(phrase != null && phrase.Text != null && key == Key(phrase.Text) && phrase.Text.Length <= 4000
                && (Catalog.Value.ContainsKey(key) || phrase.Context?.StartsWith("请求或事件台词：", StringComparison.Ordinal) == true), "条目编号或原文已改变，请只编辑profiles中的台词：" + key);
        Require(Catalog.Value.Keys.All(bundle.Catalog.ContainsKey), "文件缺少当前版本台词。请重新导出完整文件再编辑。");
        Require(partial ? bundle.Profiles!.Keys.All(DateGameVoices.Ids.Contains) : bundle.Profiles!.Count == DateGameVoices.Ids.Length && DateGameVoices.Ids.All(bundle.Profiles.ContainsKey), "台词版本编号不完整或无效。");
        foreach (var (id, profile) in bundle.Profiles)
        {
            Require(profile != null && profile.Lines != null && profile.Remarks != null && profile.Triggers != null, "台词版本内容不完整：" + id);
            Require(profile!.Lines!.Count == bundle.Catalog.Count && bundle.Catalog.Keys.All(profile.Lines.ContainsKey), "请保留全部台词编号：" + id);
            foreach (var (key, line) in profile.Lines)
            {
                Require(line != null && line.Length <= 4000 && !string.IsNullOrWhiteSpace(line), "台词需为1～4000字：" + id + "/" + key);
                Require(Variables(line!).SequenceEqual(Variables(bundle.Catalog[key].Text))
                    && Regex.Replace(line!, @"\{[^{}]+\}", "").IndexOfAny(['{', '}']) < 0, "请保留原句中花括号及其中的名称：" + id + "/" + key);
            }
            Require(profile.Remarks!.Count == DateGameVoices.Remarks.Count && DateGameVoices.Remarks.Keys.All(profile.Remarks.ContainsKey), "请保留全部性格补句类别：" + id);
            foreach (var line in profile.Remarks.Values) Require(line != null && line.Length <= 1000 && !line.Contains('{') && !line.Contains('}'), "性格补句请使用1000字以内的普通文本，可留空。");
            Require(profile.Triggers!.Keys.All(key => bundle.Rules.Any(r => r.Trigger == key)), "事件台词包含未知触发编号：" + id);
            foreach (var (trigger, speech) in profile.Triggers)
            {
                Require(speech != null && speech.Lines != null && speech.Lines.Count <= 100
                    && (!bundle.Rules.Single(r => r.Trigger == trigger).Enabled || speech.Lines.Count > 0), "启用的事件需要1～100句性格台词：" + id + "/" + trigger);
                foreach (string line in speech!.Lines!) Require(!string.IsNullOrWhiteSpace(line) && line.Length <= 4000 && !line.Contains('{') && !line.Contains('}'), "事件台词需为1～4000字的普通文本：" + id + "/" + trigger);
            }
        }
    }
    private static DateVoiceEdits Edits(string id, Profile profile, Dictionary<string, Phrase> catalog, List<DateGameRule> rules)
    {
        var defaults = DefaultRemarks(id);
        var edits = new DateVoiceEdits { Lines = profile.Lines.Where(p => p.Value != catalog[p.Key].Text).ToDictionary(),
            Remarks = profile.Remarks.Where(p => p.Value != defaults[p.Key]).ToDictionary() };
        var baseline = new CareerData { DateGameVoiceEdits = new() { [id] = edits } };
        foreach (var (trigger, speech) in profile.Triggers)
            if (!speech.Lines.SequenceEqual(DateGameVoices.EventLines(baseline, id, rules.Single(r => r.Trigger == trigger))))
                edits.Triggers[trigger] = speech.Lines.ToList();
        return edits;
    }
    public static void Apply(CareerData data, Bundle bundle)
    {
        Validate(bundle);
        var edits = new Dictionary<string, DateVoiceEdits>();
        foreach (var (id, profile) in bundle.Profiles)
        {
            edits[id] = Edits(id, profile, bundle.Catalog, bundle.Rules);
        }
        data.DateGameRules = Coop.CoopJson.Copy(bundle.Rules);
        data.DateGameTiming = Coop.CoopJson.Copy(bundle.Timing);
        data.DateGameVoiceEdits = edits;
    }
    public static string RewritePhrase(CareerData data, string profile, string source)
        => data.DateGameVoiceEdits.TryGetValue(profile, out var edits) && edits.Lines.Count > 0 ? edits.Lines.GetValueOrDefault(Key(source), source) : source;
    public static string Remark(CareerData data, string profile, string family, string fallback)
        => data.DateGameVoiceEdits.GetValueOrDefault(profile)?.Remarks.GetValueOrDefault(family) ?? fallback;
    public static string Write(string directory, CareerData data, List<DateGameRule>? drafts = null)
    {
        Directory.CreateDirectory(directory);
        string path = Path.Combine(directory, $"约会对局台词-{DateTime.Now:yyyyMMdd-HHmmss}-{Guid.NewGuid().ToString("N")[..6]}.zip");
        string temporary = path + ".tmp";
        try
        {
            using (var zip = ZipFile.Open(temporary, ZipArchiveMode.Create))
                foreach (var (name, text) in Files(data, drafts))
                { using var writer = new StreamWriter(zip.CreateEntry(name).Open(), new UTF8Encoding(false)); writer.Write(text); }
            File.Move(temporary, path); return path;
        }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
    public static Dictionary<string, string> Files(CareerData data, List<DateGameRule>? drafts = null)
    {
        var bundle = Snapshot(data, drafts); var files = new Dictionary<string, string>();
        Validate(bundle);
        // 新导出将事件按稳定触发编号组织，每句只保留一个编辑位置。
        bundle.Catalog = bundle.Catalog.Where(p => Catalog.Value.ContainsKey(p.Key)).ToDictionary();
        foreach (var (id, profile) in bundle.Profiles)
        {
            profile.Lines = profile.Lines.Where(p => bundle.Catalog.ContainsKey(p.Key)).ToDictionary();
            files["对局发言_" + profile.Name + ".json"] = JsonSerializer.Serialize(new VoiceFile { Personality = id, Profile = profile, Catalog = bundle.Catalog }, Json);
        }
        files["对局触发条件.json"] = JsonSerializer.Serialize(new RuleFile { Timing = bundle.Timing,
            Rules = bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }).ToList(), Conditions = Conditions() }, Json);
        files["使用说明.md"] = Guide; return files;
    }
    private static Dictionary<string, string> Conditions() => new()
    {
        ["fast"] = "玩家至少前进20层，并到达timing.fastMinimumFloor层后，累计用时/当前楼层<=threshold秒；整局一次。",
        ["act1"] = "玩家进入第二幕（通过第一幕）；整局一次。",
        ["act2"] = "玩家进入第三幕（通过第二幕）；整局一次。",
        ["npc-death"] = "NPC模拟对局已死亡；每名NPC一次。",
        ["npc-damage"] = "NPC本层开始生命减当前生命，占最大生命比例>=threshold%；以受伤NPC所在幕计，全体NPC共用每幕一次。",
        ["player-danger"] = "玩家当前生命占最大生命比例<=threshold%；整局一次。",
        ["gold-spent"] = "原版房间历史记录的玩家单层GoldSpent>=threshold金币（默认300）；每幕一次，获得金币不抵扣花费。",
        ["elite-fast"] = "完整观察精英战开始到胜利的原版对局计时，用时严格小于threshold秒（默认30）；每幕一次。战斗中途载入时跳过此次计时。",
        ["boss-fast"] = "完整观察首领战开始到胜利的原版对局计时，用时严格小于threshold秒（默认60）；每幕一次。战斗中途载入时跳过此次计时。",
        ["floor-gap"] = "玩家与任一NPC的楼层差绝对值>=threshold（默认12）；全体NPC共用每局一次。",
        ["priority"] = "按rules的排列顺序检查。所有事件受speechSeconds限制；请求聊天从上次请求出现时起至少间隔20秒，chatSeconds可设定更长间隔。已有待回应请求时等待处理。先播出台词，玩家点击回应请求后等待当前动作结束，再暂停进入约会。"
    };
    public const string Guide = """
        # 约会对局发言与触发条件

        每种性格是一份独立 JSON：对局发言_男性默认、女性默认、傲娇、无口、抖M、雌小鬼、小妈妈。可以只把需要修改的一份交给 AI。
        每份性格文件同时包含普通对局发言和十种事件的请求聊天台词。公共阈值、开关和冷却保存在“对局触发条件.json”。

        ## 编辑并导入

        1. 修改触发事件的台词：在性格文件的 profile.triggers 下找到事件（例如 fast），直接编辑其 lines 列表，每项是一句完整候选台词，可以增删。旁边的 condition 解释触发时机，实际数值由公共条件文件控制。
        2. 修改普通解说与内心发言：编辑 profile.lines，情境补句在 profile.remarks（可以留空）。catalog 提供这部分原句的用途和对照；保留编号以及 {hp}、{damage} 等花括号里的名称，游戏会填入真实数据。
        3. 保存为 JSON。在“模组设置 → 约会对局发言与触发 → 导入台词JSON”中选择这一份文件。可依次导入其他性格。
        4. 检查后点击“保存”。单份性格文件只更新对应性格；公共条件文件只更新触发规则。取消编辑会保留之前的设置。

        例如在“对局发言_傲娇.json”中，把 profile.triggers.fast.lines 改为 ["跑这么快，也稍微等等我呀。", "这一路的选择，你待会儿给我讲讲。"]。快速推进触发时，该性格会随机说其中一句；其他性格保留自己的候选句。
        事件 lines 已经是完整发言，游戏会直接使用，并保留原本先发言、后请求聊天的流程。这里的句子可独立增删，普通发言区的补句应用于普通解说。
        可以把这句话连同文件发给 AI：请保留字段名、触发事件编号、普通台词编号和花括号里的名称，按我的要求修改 profile 中的台词与补句，重点改写 profile.triggers 每个事件的 lines，返回完整的这个性格 JSON 文件。

        ## 调整公共条件

        rules 中 enabled 是开关，chat 表示发言后是否请求聊天，threshold 是阈值；conditions 说明单位、比较方式和次数限制。排列 rules 可以调整检查优先级。事件候选台词统一在各性格文件的 profile.triggers 中编辑。
        timing 中 speechSeconds 是事件发言间隔，chatSeconds 是请求聊天间隔（从上次请求出现时起计算，最短20秒），fastMinimumFloor 是快速推进的起始楼层（至少20层）。

        默认包含：快速推进、通过第一幕、通过第二幕、NPC倒下、NPC大量受伤、玩家低生命、单层花费300金币、30秒内精英胜利、60秒内首领胜利、双方相差12层。
        大量受伤、单层消费、精英速胜、首领速胜各自每幕一次；进度差距每局一次。精英与首领用时采用严格小于阈值。
        先播出台词，再由玩家点击“回应请求”；游戏在当前动作完成后打开约会。冷却期间发生的消费、战斗等事实会保留，等待播报。
        各性格的事件候选句通过 fast、gold-spent 等固定事件编号对应，可直接编辑后单独导入。调整公共阈值会保留已经编辑的各性格台词。

        原有普通解说、内心活动、商店、出牌等台词也包含在各性格文件中，继续使用原有播报时机。start 和 ambient 已从这组约会请求条件移除。
        旧版综合文件及第一版分性格文件仍可导入；综合文件会更新全部性格。旧台词改写会在下次导出时归入相应事件。新导出的文件始终按性格拆分。建议修改前保留一份导出备份。
        """;
}
