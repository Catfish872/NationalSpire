using System.Runtime.CompilerServices;
using System.Text;

namespace NationalSpire;

public sealed record EventPoolEntry(string Title, string Detail);
public sealed record EventPoolCategory(string Id, string Name, string Group);
public sealed record RandomEventSeed(string Category, string Detail);

/// <summary>模板按分类保存覆盖内容；生成、编辑与交换文件共用此入口。</summary>
public static class EventPools
{
    public static readonly EventPoolCategory[] Categories =
        new[] { "日常", "饮食", "阅读", "户外", "夜色", "训练", "手作", "交易", "相聚", "音乐" }
            .Select(n => new EventPoolCategory("event:" + n, n, "随机事件"))
            .Concat(WorldEvents.Topics.Select(t => t.Key).Distinct().Select(n => new EventPoolCategory("daily:" + n, n, "普通日常")))
            .Concat(WorldEvents.MatchTopics.Select(t => t.Key).Distinct().Select(n => new EventPoolCategory("daily:" + n, n, "赛后日常"))).ToArray();
    private static readonly Dictionary<string, EventPoolEntry[]> Defaults = Categories.ToDictionary(c => c.Id, c =>
        c.Group == "随机事件" ? RandomEventSeeds.All.Where(s => RandomEventSeeds.Category(s) == c.Name).Select(s => new EventPoolEntry("", s)).ToArray()
        : WorldEvents.Topics.Concat(WorldEvents.MatchTopics).Where(t => t.Key == c.Name).Select(t => new EventPoolEntry(t.Title, t.Detail)).ToArray());
    private static readonly HashSet<string> MatchCategories = WorldEvents.MatchTopics.Select(t => t.Key).ToHashSet();
    private static readonly ConditionalWeakTable<AiOptions, Cache> Caches = new();
    private sealed class Cache
    {
        public string Template = "";
        public Dictionary<string, List<EventPoolEntry>>? Source;
        public Snapshot? Value;
    }
    public sealed class Snapshot
    {
        public RandomEventSeed[] Random { get; init; } = [];
        internal WorldEvents.Topic[] Daily { get; init; } = [];
        public int DailyCount => Daily.Length;
        public bool RandomUsesDefault { get; init; }
    }
    public static bool IsMatchCategory(string category) => MatchCategories.Contains(category);
    public static IReadOnlyList<EventPoolEntry> Default(string id) => Defaults[id];
    public static Dictionary<string, List<EventPoolEntry>> Copy(IReadOnlyDictionary<string, List<EventPoolEntry>> source)
        => source.ToDictionary(p => p.Key, p => p.Value.ToList());
    public static Dictionary<string, List<EventPoolEntry>> Overrides(AiOptions options, string? template = null)
        => options.EventPoolOverrides.TryGetValue(template ?? PromptLibrary.TemplateId(options), out var bank) ? Copy(bank) : new();
    public static IReadOnlyList<EventPoolEntry> Entries(IReadOnlyDictionary<string, List<EventPoolEntry>> bank, string id)
        => bank.TryGetValue(id, out var entries) ? entries : Defaults[id];
    public static void Validate(IReadOnlyDictionary<string, List<EventPoolEntry>> bank)
    {
        foreach (var (id, entries) in bank)
        {
            if (!Defaults.ContainsKey(id)) throw new ArgumentException("事件池分类不存在：" + id);
            if (entries == null) throw new ArgumentException("事件池分类需要使用条目列表：" + id);
            for (int i = 0; i < entries.Count; i++)
                if (entries[i] == null || string.IsNullOrWhiteSpace(entries[i].Detail) || (id.StartsWith("daily:") && string.IsNullOrWhiteSpace(entries[i].Title)))
                    throw new ArgumentException($"{id} 第 {i + 1} 条需要填写" + (id.StartsWith("daily:") ? "标题和内容。" : "素材内容。"));
        }
    }
    public static void Save(AiOptions options, IReadOnlyDictionary<string, List<EventPoolEntry>> bank, string? template = null)
    {
        Validate(bank);
        options.EventPoolOverrides[template ?? PromptLibrary.TemplateId(options)] = Copy(bank);
        Caches.Remove(options);
    }
    public static Snapshot Get(AiOptions options)
    {
        string template = PromptLibrary.TemplateId(options);
        options.EventPoolOverrides.TryGetValue(template, out var source);
        var cache = Caches.GetOrCreateValue(options);
        if (cache.Value != null && cache.Template == template && ReferenceEquals(cache.Source, source)) return cache.Value;
        cache.Template = template; cache.Source = source;
        return cache.Value = Build(source ?? new());
    }
    // 共同世界的日程由房主推进，持久化世界只保存公开 AI 状态；素材读取房主本机模板。
    public static Snapshot Get(CareerData data) => Get(data.CooperativeMembers > 1 ? AiSettingsStore.Load(data.Ai) : data.Ai);
    public static Snapshot Build(IReadOnlyDictionary<string, List<EventPoolEntry>> bank)
    {
        // 未修改分类保留原始排列，维持默认池的抽取结果。
        var replaced = new HashSet<string>();
        var random = new List<RandomEventSeed>();
        foreach (string seed in RandomEventSeeds.All)
        {
            string category = RandomEventSeeds.Category(seed), id = "event:" + category;
            if (!bank.TryGetValue(id, out var entries)) random.Add(new(category, seed));
            else if (replaced.Add(id)) random.AddRange(entries.Select(e => new RandomEventSeed(category, e.Detail)));
        }
        foreach (var category in Categories.Where(c => c.Group == "随机事件"))
            if (bank.TryGetValue(category.Id, out var entries) && replaced.Add(category.Id))
                random.AddRange(entries.Select(e => new RandomEventSeed(category.Name, e.Detail)));
        var daily = new List<WorldEvents.Topic>();
        foreach (var topic in WorldEvents.Topics.Concat(WorldEvents.MatchTopics))
        {
            string id = "daily:" + topic.Key;
            if (!bank.TryGetValue(id, out var entries)) daily.Add(topic);
            else if (replaced.Add(id)) daily.AddRange(entries.Select(e => new WorldEvents.Topic(topic.Key, e.Title, e.Detail)));
        }
        bool fallback = random.Count == 0;
        if (fallback) random.AddRange(RandomEventSeeds.All.Select(s => new RandomEventSeed(RandomEventSeeds.Category(s), s)));
        return new() { Random = random.ToArray(), Daily = daily.ToArray(), RandomUsesDefault = fallback };
    }
    public static RandomEventSeed SelectRandom(AiOptions options, ISet<string> recent, Random random)
    {
        var all = Get(options).Random;
        var candidates = all.Where(s => !recent.Contains(s.Detail)).ToArray();
        if (candidates.Length == 0) candidates = all;
        return candidates[random.Next(candidates.Length)];
    }
    public static string BulkText(string id, IEnumerable<EventPoolEntry> entries)
    {
        static string Escape(string s) => s.Replace("\\", "\\\\").Replace("\r", "").Replace("\n", "\\n").Replace("｜", "\\｜");
        return string.Join("\n", entries.Select(e => (id.StartsWith("daily:") ? Escape(e.Title) + "｜" : "") + Escape(e.Detail)));
    }
    public static List<EventPoolEntry> ParseBulk(string id, string text)
    {
        var result = new List<EventPoolEntry>(); int line = 0;
        foreach (string raw in text.Replace("\r", "").Split('\n'))
        {
            line++; if (string.IsNullOrWhiteSpace(raw)) continue;
            var fields = new List<string>(); var current = new StringBuilder();
            for (int i = 0; i < raw.Length; i++)
            {
                char c = raw[i];
                if (c == '\\' && i + 1 < raw.Length && raw[i + 1] is 'n' or '\\' or '｜')
                { c = raw[++i]; current.Append(c == 'n' ? '\n' : c); }
                else if (c == '｜' && fields.Count == 0 && id.StartsWith("daily:")) { fields.Add(current.ToString().Trim()); current.Clear(); }
                else current.Append(c);
            }
            fields.Add(current.ToString().Trim());
            if (fields.Any(string.IsNullOrWhiteSpace) || (id.StartsWith("daily:") && fields.Count != 2))
                throw new ArgumentException($"第 {line} 行：" + (id.StartsWith("daily:") ? "请填写标题｜内容。" : "请填写素材内容。"));
            result.Add(new(fields.Count == 2 ? fields[0] : "", fields[^1]));
        }
        return result;
    }
}
