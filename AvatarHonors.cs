namespace NationalSpire;

public sealed record AvatarFrame(string Id, string Name, string Color, int Grade, string Requirement);
public sealed record AvatarIdentity(AvatarFrame Frame, int Ascension, string Role, string Proof)
{
    public string Description => Frame.Name + (Role.Length > 0 ? " · " + Role : "")
        + (Ascension >= 0 ? $"\n最高通关进阶 {Ascension}" : "") + (Proof.Length > 0 ? "\n" + Proof : "");
}

/// <summary>展示荣誉独立保存；战报窗口缩减和赛季积分到期不会收回已获得的头像框。</summary>
public static class AvatarHonors
{
    public static readonly AvatarFrame[] Frames =
    [
        new("plain", "素色", "526b78", 0, "初始可用"),
        new("academy", "青训新秀", "66bcae", 1, "取得青训资格"),
        new("pro", "职业选手", "b5c7d8", 2, "取得职业资格"),
        new("international", "国际舞台", "75aee6", 3, "完成一场国际赛事对局"),
        new("ranked", "世界名将", "a8a5ed", 4, "进入世界积分榜前 32 名"),
        new("elite", "世界顶尖", "e7ba70", 5, "进入世界积分榜前 8 名"),
        new("quarter", "世界八强", "c194e9", 6, "获得世界总决赛八强或更高名次"),
        new("semi", "世界四强", "edc98b", 7, "获得世界总决赛四强或更高名次"),
        new("champion", "世界之冠", "ffe1a0", 8, "获得世界总决赛冠军")
    ];
    private static bool International(string kind) => kind is "worldfinal" or "worldcup" or "continental";
    private sealed class Ranking
    {
        public int Day, Season, Awards = -1;
        public Dictionary<string, int> Places = [];
    }
    private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<CareerData, Ranking> Rankings = new();
    private static int Rank(CareerData d, string id)
    {
        var cache = Rankings.GetOrCreateValue(d);
        if (cache.Day != d.Day || cache.Season != d.Season || cache.Awards != d.Esports.CircuitAwards.Count)
        {
            cache.Day = d.Day; cache.Season = d.Season; cache.Awards = d.Esports.CircuitAwards.Count;
            var scores = d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)
                .GroupBy(a => a.PersonId).Select(g => (Id: g.Key, Points: g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)))
                .OrderByDescending(p => p.Points).ThenBy(p => p.Id, StringComparer.Ordinal).ToList();
            cache.Places = scores.Select((p, i) => (p.Id, Rank: i + 1)).ToDictionary(p => p.Id, p => p.Rank);
        }
        return cache.Places.GetValueOrDefault(id, int.MaxValue);
    }
    private static Dictionary<string, string> Earned(CareerData d, string id)
    {
        var result = new Dictionary<string, string> { ["plain"] = "" };
        var person = CareerEngine.Person(d, id);
        int license = id == "player" || d.HumanIds.Contains(id) ? d.Esports.License : person?.Role switch
        { "职业选手" or "世界顶尖" or "退役选手" => 3, "青训选手" => 2, _ => 0 };
        string season = $"第 {d.Season} 赛季获得";
        if (license >= 2) result["academy"] = "已取得青训资格";
        if (license >= 3) result["pro"] = "已取得职业资格";
        if (d.Esports.Competitions.Any(c => International(c.Kind) && c.Fixtures.Any(f => f.Finished && !f.Walkover && (f.HomeId == id || f.AwayId == id)))
            || d.Results.Any(r => id == "player" && International(r.Kind) && r.Outcome != "退赛")) result["international"] = season;
        int rank = Rank(d, id);
        if (rank <= 32) result["ranked"] = $"第 {d.Season} 赛季 · 世界积分榜第 {rank} 名";
        if (rank <= 8 || person?.Role == "世界顶尖") result["elite"] = rank <= 8 ? $"第 {d.Season} 赛季 · 世界积分榜第 {rank} 名" : "世界顶尖选手";
        foreach (var award in d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Kind == "worldfinal" && a.Stage > 0 && a.Stage <= 8).OrderBy(a => a.Season))
        {
            string proof = $"第 {award.Season} 赛季 · {award.Event} · {award.Place}";
            result.TryAdd("quarter", proof);
            if (award.Stage <= 4) result.TryAdd("semi", proof);
            if (award.Place == "冠军") result.TryAdd("champion", proof);
        }
        return result;
    }
    public static void Capture(CareerData d)
    {
        if (d.Esports.BestClear is >= 0 and <= 10) d.AvatarHighestClear = Math.Max(d.AvatarHighestClear, d.Esports.BestClear);
        // 旧版存档只恢复仍有依据的通关进阶；赛事胜负与是否通关分别判断。
        foreach (var r in d.Results.Where(r => r.Win))
        {
            int ascension = r.PlayedAscension ?? (r.OfficialAscensionVerified ? r.Ascension : -1);
            if (ascension is >= 0 and <= 10) d.AvatarHighestClear = Math.Max(d.AvatarHighestClear, ascension);
        }
        foreach (var pair in Earned(d, "player")) d.AvatarFrames.TryAdd(pair.Key, pair.Value);
    }
    public static string Role(CareerData d, string id)
    {
        if (id == "player") return "";
        var p = CareerEngine.Person(d, id); if (p == null) return "";
        foreach (string role in new[] { "解说员", "主播", "教练", "赛事记者", "退役选手" })
            if (p.Role == role || p.Identities.Contains(role)) return role;
        return "";
    }
    public static AvatarIdentity ForPerson(CareerData d, string id)
    {
        var earned = id == "player" || d.HumanIds.Contains(id) ? d.AvatarFrames : Earned(d, id);
        var best = Frames.LastOrDefault(f => earned.ContainsKey(f.Id)) ?? Frames[0];
        string selection = id == "player" ? d.SelectedAvatarFrame : d.HumanFrames.GetValueOrDefault(id, "auto");
        var frame = selection != "auto" && earned.ContainsKey(selection)
            ? Frames.FirstOrDefault(f => f.Id == selection) ?? best : best;
        var person = CareerEngine.Person(d, id);
        int highest = id == "player" ? d.AvatarHighestClear : d.HumanClears.TryGetValue(id, out int cleared) ? cleared : person is { Wins: > 0 } ? person.MaxAscension : -1;
        if (person != null && id != "player" && !d.HumanIds.Contains(id)) highest = Math.Max(highest, person.PrivateHighestClear);
        return new(frame, highest, Role(d, id), earned.GetValueOrDefault(frame.Id, ""));
    }
    public static bool Select(CareerData d, string frame)
    {
        if (frame != "auto" && (!Frames.Any(f => f.Id == frame) || !d.AvatarFrames.ContainsKey(frame))) return false;
        d.SelectedAvatarFrame = frame; return true;
    }
    public static string Byline(CareerData d, string id)
    {
        var identity = ForPerson(d, id);
        string title = identity.Role.Length > 0 ? identity.Role : "赛事解说";
        if (identity.Frame.Grade >= 2) title += " · " + (identity.Frame.Id == "pro" && CareerEngine.Person(d, id)?.Role == "退役选手" ? "退役选手" : identity.Frame.Name);
        return CareerEngine.DisplayName(d, id) + "  |  " + title;
    }
}
