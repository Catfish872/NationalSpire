using System.Text.Json;
using Godot;

namespace NationalSpire;

/// <summary>
/// 局面弹幕库与「串子」生成器。
///
/// 文本全部来自外置 JSON（模组目录下的 <c>situation/lib-*.json</c>），按「知名度档位 × 事件族」组织：
/// 无名选手被冷嘲热讽、有些名气的被阴阳怪气捧一踩一、名声大噪的被无脑护主并顺手踩对手。
/// 库文件缺失或损坏时只停用该来源，不影响解说、转播面板与比赛流程。
/// </summary>
public static class SituationDanmaku
{
    /// <summary>热重载探测间隔（秒）。</summary>
    private const double ProbeInterval = 2;

    /// <summary>本轮对话是否已经用过「泛化」兜底词条，避免每个事件都塞一句泛化嘲讽。</summary>
    private static string _recentGeneric = "";
    private static double _genericUntil;
    private static readonly Dictionary<string, double> Cooldown = [];

    public sealed class Line
    {
        public int Tier { get; set; }
        public string Event { get; set; } = "";
        public string Text { get; set; } = "";
    }

    private sealed class Library
    {
        public int SchemaVersion { get; set; }
        public string Part { get; set; } = "";
        public List<Line> Lines { get; set; } = [];
    }

    private static List<Line>? _lines;
    private static string _source = "(未加载)";
    private static DateTime _stamp;
    private static double _probedAt;
    private static bool _probed;

    /// <summary>
    /// 词库 JSON 的键名是小写（schemaVersion / lines / tier / event / text），C# 属性是 PascalCase，
    /// 而 System.Text.Json 默认区分大小写——不显式打开不区分大小写，三个库都会解析成 0 条且被静默跳过。
    /// </summary>
    private static readonly JsonSerializerOptions Json = new() { PropertyNameCaseInsensitive = true };

    /// <summary>已加载的词条总数与来源，供诊断面板显示。</summary>
    public static int Count => Load().Count;
    public static string Source => _source;

    /// <summary>
    /// 词库文件的最后修改时间快照；变化时自动重新加载。
    /// 这样改完 JSON 存盘即可生效，不必重启游戏。
    /// </summary>
    private static DateTime Stamp()
    {
        DateTime newest = AiDanmakuStore.Stamp;
        foreach (string directory in Directories())
        {
            if (!Directory.Exists(directory)) continue;
            foreach (string path in Directory.GetFiles(directory, "lib-*.json"))
            {
                var written = File.GetLastWriteTimeUtc(path);
                if (written > newest) newest = written;
            }
        }
        return newest;
    }

    /// <summary>
    /// 被局内定时调用；最多每 <see cref="ProbeInterval"/> 秒探测一次文件时间戳，变化则重载词库。
    /// 第一次调用只登记当前时间戳，不会误判成「有更新」。
    /// </summary>
    public static void Refresh()
    {
        double now = Time.GetTicksMsec() / 1000.0;
        if (now - _probedAt < ProbeInterval) return;
        _probedAt = now;
        var stamp = Stamp();
        if (!_probed) { _probed = true; _stamp = stamp; return; }
        if (stamp == _stamp) return;
        GD.Print("[NationalSpire] 局面弹幕库有更新，正在重新加载…");
        Reload();
    }

    /// <summary>知名度档位：1 寂寂无名、2 有些名气、3 名声大噪、4 顶级。</summary>
    public static int Tier(CareerData data)
    {
        // 名气主要由粉丝数决定，荣誉与里程碑作为加成；数值门槛与赛季奖励量级对齐。
        double score = data.Fans + (data.Rating - 1000) * 2.0 + data.Esports.Honors.Count * 60 + data.Esports.Milestones.Count * 25;
        if (data.Esports.Honors.Count >= 8 || data.Fans >= 12000) return 4;
        if (score >= 2000) return 3;
        if (score >= 400) return 2;
        return 1;
    }

    /// <summary>档位的中文名，用于界面与日志。</summary>
    public static string TierName(int tier) => tier switch { 4 => "顶级", 3 => "名声大噪", 2 => "有些名气", _ => "寂寂无名" };

    /// <summary>把播报主题映射到弹幕库的事件族；返回 null 表示这个话题不发串子弹幕。</summary>
    public static string? EventFor(string topic)
    {
        if (string.IsNullOrEmpty(topic)) return null;
        // 尖塔仲裁等严肃话题不参与玩梗。
        if (topic.StartsWith("arbitration") || topic.StartsWith("banned")) return null;
        return topic switch
        {
            "rival_dead" => "rival",
            // 夺冠走「达成成就」族（含从弹幕尖塔导入的成就词条），普通完赛走泛化夸奖。
            "player_champion" => "achieve",
            "player_finished" => "praise",
            "opening" or "early_chat" => "opening",
            _ => topic switch
            {
                _ when topic.StartsWith("gap_") => "gap",
                _ when topic.StartsWith("rival_") => "rival",
                _ when topic.StartsWith("elite") => "elite",
                // 火堆与跳过奖励：这两个都有真实的局内触发源（火堆话题、CardReward.OnSkipped）。
                _ when topic.StartsWith("rest_") => "slack",
                _ when topic.StartsWith("skip_") => "skip_reward",
                _ when topic.StartsWith("question_") => "cheap",
                _ when topic.StartsWith("potion") || topic.StartsWith("discard_") => "potion_waste",
                _ when topic.StartsWith("remove_") => "upgrade",
                _ when topic.StartsWith("buy_") || topic.StartsWith("shop_") => "shop",
                _ when topic.StartsWith("gain_") || topic.StartsWith("reward_") => "upgrade",
                // 出牌与抽牌分属两个语感：一手打得多是「启动」，反复抓牌是「重复抓牌」。
                _ when topic is "cards" or "cards_repeat" => "draw",
                _ when topic is "draws" => "draw_repeat",
                _ when topic.StartsWith("damage_record") => "overkill",
                _ when topic.StartsWith("damage") => "hurt",
                _ when topic.StartsWith("clean") => "clean",
                _ when topic.StartsWith("quick") => "quick",
                _ when topic.StartsWith("recovery") => "death",
                _ when topic.StartsWith("player_hurt") => "hurt",
                _ when topic.StartsWith("player_danger") => "danger",
                _ when topic.StartsWith("boss") => "boss",
                _ when topic.StartsWith("audience_") || topic.StartsWith("reply_") => "mock",
                _ => null
            }
        };
    }

    /// <summary>负面事件族：本族词条缺席时回退到泛化嘲讽，而不是护主夸奖。</summary>
    private static readonly HashSet<string> NegativeFamilies =
        ["hurt", "death", "danger", "elite", "cheap", "draw_repeat", "skip_reward", "potion_waste", "slack", "mock", WorldsFamily];

    /// <summary>
    /// 取 <paramref name="count"/> 条适配当前档位与事件的弹幕文本（占位符已替换）。
    /// 选词从「总库」里按来源比例抽取：静态分库随知名度变化、实时社区库固定 20%、片哥与通用噪音内置，
    /// 使社区更新、广告与常规弹幕自然混在一起，而不是分开发射。
    /// </summary>
    public static List<string> Pick(CareerData data, string? evt, int count, DanmakuFacts facts)
    {
        var result = new List<string>();
        if (count <= 0 || evt == null) return result;
        if (Load().Count == 0) return result;
        int tier = Tier(data);
        double now = Time.GetTicksMsec() / 1000.0;
        foreach (var entry in WeightedPool(data, evt, tier, now, data.WorldStageActive))
        {
            if (result.Count >= count) break;
            if (Cooldown.TryGetValue(entry.Text, out double until) && now < until) continue;
            string text = Fill(entry.Text, facts, data);
            if (text.Length == 0) continue;
            if (result.Contains(text)) continue;
            Cooldown[entry.Text] = now + entry.Cooldown;
            result.Add(text);
            if (entry.Source == PoolSource.Spam) _spamEmitted++;
        }
        // 泛化兜底：本事件族的候选全部在冷却中时，补一句同档位的泛化词条。
        if (result.Count == 0 && _recentGeneric != evt + tier && now > _genericUntil)
        {
            _recentGeneric = evt + tier;
            _genericUntil = now + 6;
            result.AddRange(Pick(data, tier >= 3 ? "praise" : "mock", 1, facts));
        }
        if (Cooldown.Count > 1200) Prune(now);
        return result;
    }

    /// <summary>总库的来源分类，只用于统计与冷却区分，不对外暴露。</summary>
    private enum PoolSource { AdjacentTier, CurrentTier, Community, Spam, Generic, Worlds }

    private readonly record struct Weighted(string Text, PoolSource Source, double Cooldown);

    /// <summary>本场已发出的片哥条数；用于把广告占比限制在一个不惹人烦的总量内。</summary>
    private static int _spamEmitted;
    /// <summary>单场片哥总量上限：比例之外再给一个绝对上限，避免长局里广告越攒越多。</summary>
    public const int SpamPerMatchLimit = 60;

    /// <summary>新的一场开始：重置单场统计。</summary>
    public static void ResetMatchCounters() => _spamEmitted = 0;

    /// <summary>
    /// 构造当前事件下的加权候选：先按来源把各自的条目收进来，再按权重重复投放，
    /// 最后洗牌——于是"抽到某来源的概率"就等于该来源的权重占比。
    /// </summary>
    private static List<Weighted> WeightedPool(CareerData data, string evt, int tier, double now, bool worlds)
    {
        var all = Load();
        var events = EventsFor(evt).ToList();
        int[] weights = WeightsFor(tier, worlds);
        // 先用本族；本族候选太少时把回退族一并纳入，保证加权池有足够样本。
        var primary = Collect(all, evt, tier, worlds);
        var candidates = primary.Count >= 4 ? primary : Collect(all, events, tier, worlds);
        var buckets = new List<Weighted>[6];
        for (int i = 0; i < buckets.Length; i++) buckets[i] = [];
        foreach (var entry in candidates) buckets[(int)entry.Source].Add(entry);

        var weighted = new List<Weighted>();
        for (int source = 0; source < buckets.Length; source++)
        {
            if (buckets[source].Count == 0) continue;
            int slots = Math.Max(1, weights[source]);
            for (int slot = 0; slot < slots; slot++)
                weighted.Add(buckets[source][Random.Shared.Next(buckets[source].Count)]);
        }
        // 某个子库这一局没有可用条目时，把它的份额让给本档静态，避免总概率出现缺口。
        for (int source = 0; source < buckets.Length; source++)
        {
            if (source == (int)PoolSource.CurrentTier || buckets[source].Count > 0) continue;
            var fallback = buckets[(int)PoolSource.CurrentTier];
            if (fallback.Count == 0) continue;
            for (int slot = 0; slot < weights[source]; slot++)
                weighted.Add(fallback[Random.Shared.Next(fallback.Count)]);
        }
        for (int i = weighted.Count - 1; i > 0; i--)
        {
            int j = Random.Shared.Next(i + 1);
            (weighted[i], weighted[j]) = (weighted[j], weighted[i]);
        }
        return weighted;
    }

    /// <summary>收集某个事件的候选：同档静态、相邻档静态、实时社区库、片哥、通用噪音，世界赛期还含世界赛族。</summary>
    private static List<Weighted> Collect(List<Line> all, string evt, int tier, bool worlds)
    {
        int adjacent = tier <= 1 ? 2 : tier >= 4 ? 3 : tier + 1;
        var list = new List<Weighted>();
        var community = AiDanmakuStore.Read();
        foreach (var line in all)
        {
            // 片哥与通用噪音跟具体话题无关，任何事件下都可以出现，各自按内置比例参与加权。
            if (line.Event == SpamFamily)
            {
                if (_spamEmitted < SpamPerMatchLimit) list.Add(new Weighted(line.Text, PoolSource.Spam, FillCooldownSeconds(SpamTemplates.Length)));
                continue;
            }
            if (line.Event == GenericFamily)
            {
                list.Add(new Weighted(line.Text, PoolSource.Generic, FillCooldownSeconds(64)));
                continue;
            }
            // 世界赛专用词条：只在世界赛期间参与，且严格按当前档位（清算梗的语气不能串档）。
            if (line.Event == WorldsFamily)
            {
                if (worlds && line.Tier == tier) list.Add(new Weighted(line.Text, PoolSource.Worlds, CooldownSeconds(10)));
                continue;
            }
            if (line.Event != evt) continue;
            if (line.Tier == tier) list.Add(new Weighted(line.Text, PoolSource.CurrentTier, CooldownSeconds(10)));
            else if (line.Tier == adjacent) list.Add(new Weighted(line.Text, PoolSource.AdjacentTier, CooldownSeconds(10)));
        }
        foreach (var entry in community)
        {
            // AI 在世界赛期间会把清算梗标成 worlds 族，同样只在世界赛期参与。
            if (entry.Event == WorldsFamily)
            {
                if (worlds && entry.Tier == tier)
                    list.Add(new Weighted(entry.Text, PoolSource.Worlds, FillCooldownSeconds(20)));
                continue;
            }
            if (entry.Event != evt) continue;
            // 社区库比例固定，因此它的冷却也固定得比较短，让新内容尽快轮到。
            list.Add(new Weighted(entry.Text, PoolSource.Community, FillCooldownSeconds(20)));
        }
        return list;
    }

    /// <summary>收集多个事件（本族 + 回退族）的候选。</summary>
    private static List<Weighted> Collect(List<Line> all, List<string> events, int tier, bool worlds)
    {
        var list = new List<Weighted>();
        foreach (string evt in events) list.AddRange(Collect(all, evt, tier, worlds));
        return list;
    }

    /// <summary>把占位符模板渲染成最终文本；片哥模板里的 {url} 每次现生成，所以广告域名不会重复。</summary>
    private static bool IsSpam(string text) => text.Contains("{url}");

    /// <summary>
    /// 选词随机性自检：用真实词库跑一批取词，统计重复情况。
    /// 只读不改状态（结果不写进冷却表），供实机诊断确认「不再按固定顺序轮转」。
    /// </summary>
    public static object RandomnessReport(string evt, int picks)
    {
        var all = Load();
        var pool = all.Where(line => line.Event == evt && line.Tier == 1).Select(line => line.Text).ToList();
        if (pool.Count == 0) return new { evt, pool = 0, note = "该事件族没有词条" };
        var picked = new List<string>();
        for (int i = 0; i < picks; i++) picked.Add(Shuffle(all.Where(line => line.Event == evt && line.Tier == 1).ToList(), i).FirstOrDefault()?.Text ?? "");
        picked.RemoveAll(text => text.Length == 0);
        var distinct = picked.Distinct().Count();
        // 连续两次取到同一条的比例，是「眼熟」的直观指标。
        int adjacent = 0;
        for (int i = 1; i < picked.Count; i++) if (picked[i] == picked[i - 1]) adjacent++;
        return new
        {
            evt,
            pool = pool.Count,
            picks = picked.Count,
            distinct,
            coverage = pool.Count == 0 ? 0 : Math.Round(distinct * 100.0 / pool.Count, 1),
            adjacentRepeats = adjacent,
            sample = picked.Take(12).ToList()
        };
    }

    /// <summary>随机打乱一个词条池（Fisher–Yates）。每次取词都重新洗，避免固定顺序轮转。</summary>
    private static List<Line> Shuffle(List<Line> pool, double seedOffset)
    {
        var shuffled = new List<Line>(pool);
        var random = new Random(Random.Shared.Next() ^ (int)(seedOffset * 1000) ^ System.Environment.TickCount);
        for (int i = shuffled.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (shuffled[i], shuffled[j]) = (shuffled[j], shuffled[i]);
        }
        return shuffled;
    }

    /// <summary>
    /// 词条冷却时长：按池子大小自适应。池子越小冷却越短，否则小池会长时间无词可用。
    /// </summary>
    private static double CooldownSeconds(int poolSize) => Math.Clamp(poolSize * 12.0, 60, 600);

    /// <summary>
    /// 补料通道的冷却：比主词库短得多。补料池本身不大（噪音 54 条、广告按额度），
    /// 用主池那种几百秒的冷却会让补料在几十秒内枯竭，进而导致弹幕停止生成。
    /// </summary>
    private static double FillCooldownSeconds(int poolSize) => Math.Clamp(poolSize * 1.5, 6, 60);

    /// <summary>广告域名用的字符集：小写字母与数字，避免出现容易误读的组合。</summary>
    private const string UrlAlphabet = "abcdefghijkmnpqrstuvwxyz23456789";

    /// <summary>广告话术模板；{url} 每次现生成，因此同一条话术也不会重复出现同一个域名。</summary>
    private static readonly string[] SpamTemplates =
    [
        "{url} 兄弟们这里",
        "{url} 全网最全",
        "{url} 懂的都懂",
        "{url} 别问，直接看",
        "{url} 老地方",
        "{url} 前排提醒",
        "{url} 楼主好人",
        "{url} 已三连",
        "{url} 这都能找到",
        "{url} 低调点，别声张"
    ];

    /// <summary>
    /// 生成一个「片哥广告」式域名：四个随机字母数字 + .com。
    /// 走程序化生成而不是写死词条，这样每次出现的域名都不同，不会像固定词条那样被看熟。
    /// 域名是随机串，不会指向任何真实网站。
    /// </summary>
    public static string RandomUrl()
    {
        var builder = new System.Text.StringBuilder(8);
        for (int i = 0; i < 4; i++) builder.Append(UrlAlphabet[Random.Shared.Next(UrlAlphabet.Length)]);
        return builder.Append(".com").ToString();
    }

    /// <summary>生成一条完整的广告弹幕：随机域名 + 随机话术。</summary>
    public static string RandomSpam() => SpamTemplates[Random.Shared.Next(SpamTemplates.Length)].Replace("{url}", RandomUrl());

    /// <summary>
    /// 从整个词库里随便取一条（任意事件族、任意档位），作为「最低同时生成数量」的最后一级补料。
    /// 前两级（通用噪音、广告）都有额度或冷却上限，这一级直接从 960 条自有词库 + 社区库里取，
    /// 保证补料永不枯竭——否则高密度设置下几十秒后就会没内容可发。
    /// </summary>
    /// <summary>
    /// 从总库里随便取一条渲染好的文本，作为「最低同时生成数量」的最后一级补料。
    /// 与 <see cref="Pick"/> 的区别：不挑事件族，任意来源都行，只保证不断流。
    /// </summary>
    public static string? PickAnyFill(DanmakuFacts facts, CareerData data)
    {
        var all = Load();
        if (all.Count == 0) return null;
        double now = Time.GetTicksMsec() / 1000.0;
        // 世界赛期把世界赛词条排到前面，让补料也带上当期语境；非世界赛期跳过它们。
        bool worlds = data.WorldStageActive;
        var ordered = worlds
            ? all.OrderByDescending(line => line.Event == WorldsFamily).ToList()
            : all.Where(line => line.Event != WorldsFamily).ToList();
        if (ordered.Count == 0) return null;
        int start = Random.Shared.Next(ordered.Count);
        for (int i = 0; i < ordered.Count; i++)
        {
            var line = ordered[(start + i) % ordered.Count];
            if (Cooldown.TryGetValue(line.Text, out double until) && now < until) continue;
            string text = Fill(line.Text, facts, data);
            if (text.Length == 0) continue;
            Cooldown[line.Text] = now + 30;
            if (line.Event == SpamFamily) _spamEmitted++;
            return text;
        }
        // 整库都在冷却（极端高密度）时也照发一条，宁可重复也不断流。
        return Fill(ordered[start].Text, facts, data) is { Length: > 0 } fallback ? fallback : null;
    }

    /// <summary>事件族回退顺序：本族优先，然后是身份向的拉踩与泛化词条。</summary>
    private static IEnumerable<string> EventsFor(string evt)
    {
        yield return evt;
        if (evt is not ("target" or "praise" or "mock"))
        {
            yield return "target";
            // 负面事件退到泛化嘲讽，正面事件退到泛化护主，避免语义反转。
            yield return NegativeFamilies.Contains(evt) ? "mock" : "praise";
        }
        if (evt != "mock") yield return "mock";
    }

    private static void Prune(double now)
    {
        foreach (string key in Cooldown.Where(pair => pair.Value < now).Select(pair => pair.Key).ToList()) Cooldown.Remove(key);
    }

    /// <summary>
    /// 替换占位符。整条词条只要有未替换的占位符就整条丢弃——宁可不发，也不要把
    /// <c>{rival}</c> 这样的原文直接显示在屏幕上。
    /// </summary>
    private static string Fill(string template, DanmakuFacts facts, CareerData data)
    {
        string text = template
            .Replace("{name}", facts.Player)
            .Replace("{rival}", facts.Rival)
            .Replace("{country}", facts.Country)
            .Replace("{club}", facts.Club)
            .Replace("{gap}", facts.Gap.ToString())
            .Replace("{loss}", facts.Loss.ToString())
            .Replace("{cards}", facts.Cards.ToString())
            .Replace("{draws}", facts.Draws.ToString())
            .Replace("{turn}", facts.Turn.ToString())
            .Replace("{hp}", facts.Hp.ToString())
            .Replace("{time}", facts.Time)
            .Replace("{card}", facts.Card)
            // 广告域名每次现生成，避免「片哥」弹幕之间也撞同一串。
            .Replace("{url}", RandomUrl());
        if (text.Contains('{') || text.Contains('}')) return "";
        return text.Trim();
    }

    private static List<Line> Load()
    {
        if (_lines != null) return _lines;
        var lines = new List<Line>();
        var sources = new List<string>();
        foreach (string directory in Directories())
        {
            if (!Directory.Exists(directory)) continue;
            foreach (string path in Directory.GetFiles(directory, "lib-*.json").OrderBy(name => name))
            {
                try
                {
                    var library = JsonSerializer.Deserialize<Library>(File.ReadAllText(path), Json);
                    if (library?.Lines == null || library.Lines.Count == 0)
                    {
                        // 文件在但解析出 0 条，通常是字段名不匹配；必须吵出来，不能静默跳过。
                        Diagnostics.Error("danmaku.library.empty", new InvalidDataException($"{Path.GetFileName(path)} 解析出 0 条词条"));
                        continue;
                    }
                    lines.AddRange(Valid(library.Lines));
                    sources.Add(Path.GetFileName(path));
                    if (library.SchemaVersion != 1)
                        GD.PushWarning($"[NationalSpire] 词库 {Path.GetFileName(path)} 的 schemaVersion={library.SchemaVersion}，当前只认 1，可能有字段被忽略。");
                    Diagnostics.Record("danmaku.library", new { file = Path.GetFileName(path), lines = library.Lines.Count, schema = library.SchemaVersion, origin = "file" });
                }
                catch (Exception e) { Diagnostics.Error("danmaku.library", e); }
            }
        }
        // 整合《弹幕尖塔》的词条：同一批事件族下多一份内容来源，缺词时自动互相补位。
        foreach (string path in DanmakuSpireLibraries())
        {
            try
            {
                using var document = JsonDocument.Parse(File.ReadAllText(path));
                if (!document.RootElement.TryGetProperty("groups", out var groups)) continue;
                int merged = 0, skipped = 0;
                foreach (var group in groups.EnumerateArray())
                {
                    string ruleId = group.TryGetProperty("ruleId", out var id) ? id.GetString() ?? "" : "";
                    // 有明确语义映射的按映射归类；其余进通用观众噪音族，避免整库丢弃。
                    string family = DanmakuSpireFamilies.TryGetValue(ruleId, out string? mapped) ? mapped : GenericFamily;
                    if (mapped == null) skipped++;
                    foreach (string field in new[] { "entries", "multiplayerEntries" })
                    {
                        if (!group.TryGetProperty(field, out var entries)) continue;
                        foreach (var entry in entries.EnumerateArray())
                        {
                            string text = entry.TryGetProperty("text", out var value) ? value.GetString() ?? "" : "";
                            if (text.Length == 0) continue;
                            // 词条里的 {card}/{item}/{char} 等占位符我们无法解析，直接跳过而不是把花括号显示出来。
                            if (text.Contains('{')) continue;
                            // 源库里没有 tier 概念，覆盖四档让每档都能取到；风格差异由我们的词条提供。
                            for (int tier = 1; tier <= 4; tier++) lines.Add(new Line { Tier = tier, Event = family, Text = text });
                            merged++;
                        }
                    }
                }
                sources.Add($"{Path.GetFileName(Path.GetDirectoryName(path))}/{Path.GetFileName(path)}(+{merged})");
                Diagnostics.Record("danmaku.library", new { file = path, lines = merged, skipped, origin = "danmakuspire" });
            }
            catch (Exception e) { Diagnostics.Error("danmaku.library.danmakuspire", e); }
        }
        // 片哥广告：模板固定、域名现生成，作为总库里的一个子库参与按比例抽取。
        foreach (string template in SpamTemplates)
            lines.Add(new Line { Tier = SpamTier, Event = SpamFamily, Text = template });
        // 实时社区库：AI 每次社区内容更新后写入的弹幕，与静态词库一起参与抽取。
        var community = AiDanmakuStore.Read();
        foreach (var entry in community)
            lines.Add(new Line { Tier = entry.Tier, Event = entry.Event, Text = entry.Text });
        if (community.Count > 0) sources.Add($"社区库({community.Count})");
        // 外部目录没有可用的词库时，回退到程序集内嵌的同一批 JSON（发布包里就有词条）。
        if (lines.Count == 0)
        {
            foreach (string name in Embedded())
            {
                try
                {
                    var library = JsonSerializer.Deserialize<Library>(name, Json);
                    if (library?.Lines == null || library.Lines.Count == 0) continue;
                    lines.AddRange(Valid(library.Lines));
                    sources.Add("内嵌");
                    Diagnostics.Record("danmaku.library", new { lines = library.Lines.Count, schema = library.SchemaVersion, origin = "embedded" });
                }
                catch (Exception e) { Diagnostics.Error("danmaku.library.embedded", e); }
            }
        }
        _lines = lines;
        _source = sources.Count > 0 ? string.Join("+", sources) : "(未找到词库)";
        _stamp = Stamp();
        GD.Print($"[NationalSpire] 局面弹幕库已加载 {lines.Count} 条：{_source}");
        return _lines;
    }

    /// <summary>
    /// 定位《弹幕尖塔》的规则与词条文件（本地模组目录优先，其次创意工坊订阅目录）。
    /// 找不到就静默跳过，不影响国运尖塔自身功能。
    /// </summary>
    private static IEnumerable<string> DanmakuSpireLibraries()
    {
        var roots = new List<string>();
        string user = ProjectSettings.GlobalizePath("user://");
        // 游戏目录通常是 user:// 上溯三级：<game>/<exe> → user 目录在 %APPDATA%，
        // 因此这里用安装路径与创意工坊清单反查，避免依赖固定盘符。
        foreach (string libraryFile in LibraryFolders())
        {
            try
            {
                using var document = JsonDocument.Parse(File.ReadAllText(libraryFile));
                foreach (var folder in document.RootElement.GetProperty("libraryfolders").EnumerateArray())
                {
                    if (!folder.TryGetProperty("path", out var path)) continue;
                    string root = path.GetString() ?? "";
                    if (root.Length == 0) continue;
                    roots.Add(Path.Combine(root, "steamapps", "workshop", "content", GameAppId, DanmakuSpireWorkshopId));
                }
            }
            catch (Exception e) { Diagnostics.Error("danmaku.workshop", e); }
        }
        if (user.Length > 0)
        {
            roots.Add(Path.Combine(user, "mods", "DanmakuSpire"));
            // %APPDATA%\SlayTheSpire2 → 常见的手动安装位置：同级的 Steam 库里找一遍交给 LibraryFolders 处理。
        }
        foreach (string root in roots.Distinct())
        {
            foreach (string relative in new[] { Path.Combine("content", "danmaku", "rules.json"), "rules.json" })
            {
                string candidate = Path.Combine(root, relative);
                if (File.Exists(candidate)) yield return candidate;
            }
        }
    }

    /// <summary>Steam 各库的 libraryfolders.vdf 候选位置（找不到就返回空，不影响主流程）。</summary>
    private static IEnumerable<string> LibraryFolders()
    {
        var candidates = new List<string>();
        string programFiles = System.Environment.GetEnvironmentVariable("ProgramFiles(x86)") ?? @"C:\Program Files (x86)";
        candidates.Add(Path.Combine(programFiles, "Steam", "steamapps", "libraryfolders.vdf"));
        candidates.Add(Path.Combine(System.Environment.GetEnvironmentVariable("ProgramFiles") ?? @"C:\Program Files", "Steam", "steamapps", "libraryfolders.vdf"));
        foreach (string drive in new[] { "C:", "D:", "E:", "F:", "G:", "H:" })
        {
            candidates.Add(Path.Combine(drive + Path.DirectorySeparatorChar, "steam", "steamapps", "libraryfolders.vdf"));
            candidates.Add(Path.Combine(drive + Path.DirectorySeparatorChar, "SteamLibrary", "steamapps", "libraryfolders.vdf"));
            candidates.Add(Path.Combine(drive + Path.DirectorySeparatorChar, "Steam", "steamapps", "libraryfolders.vdf"));
        }
        return candidates.Where(File.Exists);
    }

    /// <summary>杀戮尖塔 2 的 Steam AppId 与弹幕尖塔的创意工坊 ID。</summary>
    private const string GameAppId = "2868840";
    private const string DanmakuSpireWorkshopId = "3779807977";

    /// <summary>
    /// 弹幕尖塔的规则 ID → 国运尖塔事件族，取自逆向对照表    /// （<c>situation/danmakuspire-rules.md</c>，依据 DLL 内作者自带的规则表，非推测）。
    /// 未列出的规则要么依赖国运尖塔里不存在的原版实体（火炬头、雕刻师、咬人卷轴、建筑师、桥等），
    /// 要么属于多人会话专属，故不整合；它们的内容仍会进通用观众噪音族。
    /// </summary>
    private static readonly Dictionary<string, string> DanmakuSpireFamilies = new(StringComparer.OrdinalIgnoreCase)
    {
        // 受伤 / 濒死 / 危险 / 起手不足
        ["c1"] = "hurt", ["b3"] = "hurt", ["c3"] = "hurt", ["c6"] = "hurt", ["c8"] = "death",
        ["a1"] = "danger", ["a5"] = "danger", ["b1"] = "cheap", ["b2"] = "cheap",
        // 成绩与速度
        ["c9"] = "clean", ["c4"] = "quick", ["b4"] = "quick", ["d1"] = "quick",
        // 高阶数值与溢出
        ["c5"] = "overkill", ["c2"] = "overkill", ["b8"] = "overkill", ["a6"] = "elite",
        // 抓牌与抽牌
        ["e2"] = "draw_repeat", ["e11"] = "draw_repeat", ["e12"] = "draw_repeat",
        ["b5"] = "draw", ["c7"] = "draw", ["e1"] = "draw", ["e14"] = "draw", ["i1"] = "draw",
        // 抓取与升级
        ["e3"] = "upgrade", ["e4"] = "upgrade", ["e5"] = "upgrade", ["f2"] = "upgrade",
        ["g3"] = "upgrade", ["g7"] = "upgrade",
        // 跳过奖励与省钱
        ["e9"] = "skip_reward", ["e7"] = "skip_reward",
        // 药水与摸鱼
        ["b7"] = "potion_waste",
        ["b6"] = "slack", ["g4"] = "slack", ["g5"] = "slack", ["g6"] = "slack", ["i3"] = "slack",
        // 达成与成就
        ["e8"] = "achieve", ["e13"] = "achieve",
        // 身份与情绪
        ["h1"] = "cheap", ["e6"] = "cheap", ["a2"] = "praise", ["a4"] = "praise", ["e10"] = "praise",
        ["a3"] = "opening",
        // 商店
        ["f1"] = "shop", ["f3"] = "shop", ["i2"] = "shop"
    };

    /// <summary>
    /// 通用观众噪音族：弹幕尖塔里没有明确对应触发时机的词条都进这里，
    /// 以很低的频率随机上屏，充当「观众在聊天」的氛围。精确归类后应逐步迁出。
    /// </summary>
    private const string GenericFamily = "generic";
    /// <summary>片哥广告子库的族名与档位标记（档位标记只用于避免与真实档位冲突）。</summary>
    private const string SpamFamily = "spam";
    private const int SpamTier = 0;

    // ── 总库来源比例（百分比）。所有子库合成一个总库，按比例抽取，不再有独立开关。──
    /// <summary>实时社区库的固定比例：保证弹幕与 AI 社区更新保持对齐。</summary>
    public const int CommunityPercent = 20;
    /// <summary>片哥广告的固定比例（内置，不提供设置项）。</summary>
    private const int SpamPercent = 3;
    /// <summary>通用观众噪音的固定比例。</summary>
    private const int GenericPercent = 7;
    /// <summary>世界赛专用词条在世界赛期间的固定比例（平时为 0）。</summary>
    public const int WorldsPercent = 20;
    /// <summary>世界赛族的名字。</summary>
    public const string WorldsFamily = "worlds";

    /// <summary>
    /// 按知名度取各子库在总库中的权重，顺序为
    /// [相邻档静态, 实时社区库, 片哥, 通用噪音, 本档静态, 世界赛专用]。
    /// 世界赛专用只在对局处于世界赛期时占份额，其余子库按 <see cref="AdjacentShare"/> 的分配吃掉剩余部分，
    /// 静态分库补足余额，因此各项严格合计 100。
    /// </summary>
    internal static int[] WeightsFor(int tier, bool worlds = false)
    {
        int index = Math.Clamp(tier, 1, 4) - 1;
        int worldsShare = worlds ? WorldsPercent : 0;
        int staticTotal = 100 - CommunityPercent - SpamPercent - GenericPercent - worldsShare;
        int adjacent = (int)Math.Round(staticTotal * AdjacentShare[index]);
        int current = staticTotal - adjacent;
        return [adjacent, CommunityPercent, SpamPercent, GenericPercent, current, worldsShare];
    }

    /// <summary>相邻档在静态份额里的占比：档位越高越依赖同档，越无名越靠相邻档撑场。</summary>
    private static readonly double[] AdjacentShare = [.48, .48, .45, .42];
    /// <summary>通用观众噪音的最小间隔（秒）；它只做氛围，不能抢占主内容。</summary>
    public const double GenericInterval = 45;

    private static IEnumerable<Line> Valid(List<Line> lines) =>
        lines.Where(line => line.Tier is >= 1 and <= 4 && line.Event.Length > 0 && line.Text.Length > 0);

    /// <summary>读取程序集内嵌的词库（logical name 形如 NationalSpire.Situation.lib-a.json）。</summary>
    private static IEnumerable<string> Embedded()
    {
        var assembly = typeof(SituationDanmaku).Assembly;
        foreach (string name in assembly.GetManifestResourceNames().Where(name => name.StartsWith("NationalSpire.Situation.", StringComparison.Ordinal)).OrderBy(name => name))
        {
            using var stream = assembly.GetManifestResourceStream(name);
            if (stream == null) continue;
            using var reader = new StreamReader(stream, System.Text.Encoding.UTF8);
            yield return reader.ReadToEnd();
        }
    }

    /// <summary>先读模组目录（可热改），再读工程内嵌目录（开发时直接生效）。</summary>
    private static IEnumerable<string> Directories()
    {
        yield return ProjectSettings.GlobalizePath("res://mods/NationalSpire/situation");
        yield return Path.Combine(AppContext.BaseDirectory, "situation");
    }

    /// <summary>清空缓存，供热重载或改库后重新读取；会同步刷新时间戳，避免紧接着又触发一次重载。</summary>
    public static void Reload()
    {
        _lines = null;
        Cooldown.Clear();
        _source = "(未加载)";
        _stamp = Stamp();
        _probed = true;
    }
}

/// <summary>生成一条弹幕时可用的事实，用于替换词条里的占位符。</summary>
public sealed class DanmakuFacts
{
    public string Player = "";
    public string Rival = "";
    public string Country = "";
    public string Club = "";
    public int Gap;
    public int Loss;
    public int Cards;
    public int Draws;
    public int Turn;
    public int Hp;
    public string Time = "";
    /// <summary>本回合或本场最后一张打出的牌名，用于「我说{card}好牌多抓」这类词条。</summary>
    public string Card = "";
}
