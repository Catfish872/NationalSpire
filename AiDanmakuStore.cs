using System.Text.Json;

namespace NationalSpire;

/// <summary>
/// 实时社区弹幕库：每次 AI 社区内容更新后，把「刚刚发生的社区动态」转写成一批弹幕存到这里，
/// 局内与静态词库一起参与抽取。文件放在用户目录，按天累积。
/// 清理策略：按生涯日每 7 天淘汰一轮过时条目（社区话题的时效性就在一周左右），
/// 同时保留条数上限兜底，避免无限膨胀。
/// </summary>
public static class AiDanmakuStore
{
    /// <summary>保留的最大条数；超出后按时间淘汰最旧的。</summary>
    public const int MaximumEntries = 400;
    /// <summary>单次 AI 更新最多接收的条数，防止一次返回过多。</summary>
    public const int MaximumPerUpdate = 60;
    /// <summary>
    /// 过时条目的存活天数：超过这个天数的社区弹幕不再参与抽取。
    /// 社区讨论的话题一周后基本就凉了，留着只会让弹幕库和当前局势脱节。
    /// </summary>
    public const int ExpiryDays = 7;
    /// <summary>清理后至少保留的条数：全过期时保留最新一批，避免弹幕库被清空。</summary>
    public const int MinimumKept = 20;

    public sealed class Entry
    {
        public int Tier { get; set; }
        public string Event { get; set; } = "";
        public string Text { get; set; } = "";
        /// <summary>写入时的生涯日，用于淘汰与诊断。</summary>
        public int Day { get; set; }
    }

    private sealed class Payload
    {
        public int SchemaVersion { get; set; }
        public int UpdatedDay { get; set; }
        /// <summary>上次按周清理的生涯日；0 表示还没清理过。</summary>
        public int LastPurgeDay { get; set; }
        public List<Entry> Entries { get; set; } = [];
    }

    private static readonly JsonSerializerOptions Json = new() { PropertyNameCaseInsensitive = true, WriteIndented = true };
    private static readonly object Gate = new();
    private static Payload? _cache;

    /// <summary>
    /// 存储路径。与 Godot 的 user:// 一致，但先用纯 .NET 拼出来：
    /// 读 ProjectSettings 会触发引擎静态构造，离开引擎进程直接访问违例（脱机工具跑不了），
    /// 而且原生崩不属于可捕获异常。只有默认位置不存在时才回退问引擎，兼容自定义 user_dir 的安装。
    /// </summary>
    private static string Path
    {
        get
        {
            string appData = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            string direct = System.IO.Path.Combine(appData, "SlayTheSpire2", "national_spire_ai_danmaku.json");
            try { if (File.Exists(direct) || Directory.Exists(System.IO.Path.GetDirectoryName(direct)!)) return direct; }
            catch { return direct; }
            try { return Godot.ProjectSettings.GlobalizePath("user://national_spire_ai_danmaku.json"); }
            catch { return direct; }
        }
    }

    /// <summary>社区库文件的最后写入时间；用于让局内选词器感知社区库更新并重新加载。</summary>
    public static DateTime Stamp
    {
        get
        {
            try { return File.Exists(Path) ? File.GetLastWriteTimeUtc(Path) : DateTime.MinValue; }
            catch { return DateTime.MinValue; }
        }
    }

    /// <summary>当前库里的条数与最近更新时间，供界面与诊断显示。</summary>
    public static (int Count, int UpdatedDay) Stats()
    {
        var payload = Load();
        return (payload.Entries.Count, payload.UpdatedDay);
    }

    /// <summary>库里的生涯日跨度与下次清理的日；供界面显示"哪些内容会被清掉"。</summary>
    public static (int Oldest, int Newest) Span()
    {
        var payload = Load();
        if (payload.Entries.Count == 0) return (0, 0);
        return (payload.Entries.Min(entry => entry.Day), payload.Entries.Max(entry => entry.Day));
    }

    /// <summary>
    /// 按周清理过时条目：每 7 个生涯日淘汰一批超过 <see cref="ExpiryDays"/> 天的旧弹幕。
    /// 用「上次清理日」而不是每天扫描，既避免频繁写盘，也让清理节奏和社区话题的周期一致。
    /// 返回被淘汰的条数。
    /// </summary>
    public static int PurgeStale(int day)
    {
        lock (Gate)
        {
            var payload = Load();
            if (day <= 0) return 0;
            // 距上次清理不足 7 天就先不动；首次调用（LastPurgeDay=0）立即清一次。
            if (payload.LastPurgeDay > 0 && day - payload.LastPurgeDay < ExpiryDays) return 0;
            int removed = Prune(payload, day);
            payload.LastPurgeDay = day;
            if (removed > 0 || payload.LastPurgeDay == day) Save(payload);
            if (removed > 0) Diagnostics.Record("danmaku.community.purged", $"第 {day} 天清理过时弹幕 {removed} 条，剩余 {payload.Entries.Count} 条");
            return removed;
        }
    }

    /// <summary>按 <see cref="ExpiryDays"/> 淘汰过时条目；全过期时至少留下最新的一批。</summary>
    private static int Prune(Payload payload, int day)
    {
        int before = payload.Entries.Count;
        if (before == 0) return 0;
        int cutoff = day - ExpiryDays;
        var kept = payload.Entries.Where(entry => entry.Day > cutoff).ToList();
        // 全部过期（例如跳过很多天）时保留最新的 MinimumKept 条，避免社区库彻底空掉。
        if (kept.Count == 0)
            kept = payload.Entries.OrderByDescending(entry => entry.Day).Take(MinimumKept)
                .OrderBy(entry => entry.Day).ToList();
        payload.Entries = kept;
        // 条数上限兜底：清理后仍超上限时再截断最旧的。
        if (payload.Entries.Count > MaximumEntries)
            payload.Entries.RemoveRange(0, payload.Entries.Count - MaximumEntries);
        return before - payload.Entries.Count;
    }

    /// <summary>读取全部条目（只读快照）。</summary>
    public static List<Entry> Read()
    {
        lock (Gate) return [.. Load().Entries];
    }

    /// <summary>把一次 AI 生成的弹幕并入库；返回真正新增的条数。</summary>
    public static int Merge(IEnumerable<Entry> entries, int day)
    {
        lock (Gate)
        {
            var payload = Load();
            int added = 0;
            foreach (var entry in entries)
            {
                string text = (entry.Text ?? "").Replace('\r', ' ').Replace('\n', ' ').Trim();
                if (text.Length == 0 || entry.Event.Length == 0) continue;
                if (entry.Tier is < 1 or > 4) continue;
                // 同一句话不重复入库，避免多次更新后同一句反复出现。
                if (payload.Entries.Any(existing => existing.Text == text)) continue;
                payload.Entries.Add(new Entry { Tier = entry.Tier, Event = entry.Event, Text = text, Day = day });
                added++;
            }
            // 先按周清理过时条目，再入库本次更新：否则旧话题会一直占着加权抽取的名额。
            Prune(payload, day);
            payload.UpdatedDay = day;
            payload.SchemaVersion = 1;
            Save(payload);
            return added;
        }
    }

    /// <summary>清空社区库（界面上的重置按钮用）。</summary>
    public static void Clear()
    {
        lock (Gate)
        {
            var payload = Load();
            payload.Entries.Clear();
            payload.UpdatedDay = 0;
            payload.LastPurgeDay = 0;
            Save(payload);
        }
    }

    private static Payload Load()
    {
        if (_cache != null) return _cache;
        try
        {
            if (File.Exists(Path))
            {
                var payload = JsonSerializer.Deserialize<Payload>(File.ReadAllText(Path), Json);
                if (payload != null)
                {
                    payload.Entries.RemoveAll(entry => string.IsNullOrWhiteSpace(entry.Text) || entry.Event.Length == 0 || entry.Tier is < 1 or > 4);
                    return _cache = payload;
                }
            }
        }
        catch (Exception e) { Diagnostics.Error("danmaku.community.load", e); }
        return _cache = new Payload();
    }

    private static void Save(Payload payload)
    {
        try
        {
            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Path)!);
            File.WriteAllText(Path, JsonSerializer.Serialize(payload, Json));
            _cache = payload;
        }
        catch (Exception e) { Diagnostics.Error("danmaku.community.save", e); }
    }
}
