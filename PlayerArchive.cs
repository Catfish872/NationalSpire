using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;

namespace NationalSpire;

public sealed record ArchiveCharacter(string Name, int Wins, int Losses, int UnlockedAscension, long Streak, long Playtime, string CharacterId = "");
public sealed class ArchiveSnapshot
{
    public int Profile { get; init; }
    public int Wins { get; init; }
    public int Losses { get; init; }
    public long Playtime { get; init; }
    public long Floors { get; init; }
    public long Streak { get; init; }
    public int Cards { get; init; }
    public int Relics { get; init; }
    public List<ArchiveCharacter> Characters { get; init; } = [];
    public List<RunHistory> Recent { get; init; } = [];
    public string WinRate => Wins + Losses == 0 ? "—" : $"{100.0 * Wins / (Wins + Losses):0.#}%";
}

public static class PlayerArchive
{
    private static string _key = "";
    private static bool _recentLoaded;
    private static ArchiveSnapshot? _cached;
    public static void Invalidate() => _cached = null;
    public static ArchiveSnapshot Read(bool includeRecent = true)
    {
        var save = SaveManager.Instance;
        var p = save.Progress;
        string key = $"{save.CurrentProfileId}:{p.UniqueId}:{p.Wins}:{p.Losses}:{p.TotalPlaytime}";
        if (_cached != null && _key == key && (!includeRecent || _recentLoaded)) return _cached;
        var recent = new List<RunHistory>();
        // 累计数据直接读取统计，只读取最近 12 份完整战报，避免每次打开页面扫描全部历史。
        foreach (var file in (includeRecent ? save.GetAllRunHistoryNames() : Enumerable.Empty<string>()).OrderByDescending(x => x, StringComparer.Ordinal).Take(12))
        {
            try { var r = save.LoadRunHistory(file); if (r.Success && r.SaveData != null) recent.Add(r.SaveData); }
            catch { /* 单份历史损坏不影响其他统计。 */ }
        }
        _key = key; _recentLoaded = includeRecent;
        return _cached = new ArchiveSnapshot
        {
            Profile = save.CurrentProfileId, Wins = p.Wins, Losses = p.Losses, Playtime = p.TotalPlaytime,
            Floors = p.FloorsClimbed, Streak = p.BestWinStreak, Cards = p.DiscoveredCards.Count, Relics = p.DiscoveredRelics.Count,
            Characters = p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,
                kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))
                .OrderByDescending(c => c.Wins + c.Losses).ToList(),
            Recent = recent.OrderByDescending(r => r.StartTime).ToList()
        };
    }
    public static string CharacterName(ModelId id)
    {
        try { return ModelDb.GetByIdOrNull<CharacterModel>(id)?.Title.GetFormattedText() ?? id.Entry; }
        catch { return id.Entry; }
    }
}
