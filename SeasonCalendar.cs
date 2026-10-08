namespace NationalSpire;

/// <summary>旧赛程保持日期，新赛季使用十二周；绝对日期继续单调递增。</summary>
public static class SeasonCalendar
{
    /// <summary>
    /// 短赛季长度，与最初版本一致：联赛第 18 天结束 → 世界大赛第 19 天开打。
    /// 世界杯在短赛季用 9 天压缩赛程（小组赛 5 + 八强 2 + 半决赛 1 + 决赛 1）第 27 天收官，
    /// 世界总决赛仍是 9 天（每轮隔 2 天，第 19—27 天），第 28 天留作赛末结算与颁奖。
    /// </summary>
    public const int ShortLength = 28;
    /// <summary>长赛季长度。</summary>
    public const int LongLength = 84;

    public static int Length(CareerData d, int season = 0) => d.LongSeasonsFrom > 0 && (season == 0 ? d.Season : season) >= d.LongSeasonsFrom ? LongLength : ShortLength;
    public static int Start(CareerData d, int season = 0)
    {
        season = season == 0 ? d.Season : season;
        return d.LongSeasonsFrom <= 0 || season <= d.LongSeasonsFrom ? (season - 1) * ShortLength
            : (d.LongSeasonsFrom - 1) * ShortLength + (season - d.LongSeasonsFrom) * LongLength;
    }
    public static int End(CareerData d) => Start(d) + Length(d);
    public static int Day(CareerData d, int absolute)
    {
        int change = d.LongSeasonsFrom > 0 ? (d.LongSeasonsFrom - 1) * ShortLength : int.MaxValue;
        return absolute > change ? (absolute - change - 1) % LongLength + 1 : (absolute - 1) % ShortLength + 1;
    }
    public static int LeagueDeadline(CareerData d) => Length(d) == LongLength ? 22 : 10;
    public static int LeagueEnd(CareerData d) => Length(d) == LongLength ? 62 : 18;

    /// <summary>
    /// 由绝对日反推赛季号。这里逐段换算而不是直接 (Day-1)/Length：
    /// 短赛季长度一旦调整，历史日期都是按旧长度排的，必须按当前长度归入各自赛季。
    /// </summary>
    public static int SeasonOf(CareerData d, int absolute)
    {
        int change = d.LongSeasonsFrom > 0 ? (d.LongSeasonsFrom - 1) * ShortLength : int.MaxValue;
        return absolute > change
            ? d.LongSeasonsFrom + (absolute - change - 1) / LongLength
            : (absolute - 1) / ShortLength + 1;
    }

    /// <summary>某个赛季的第一天（绝对日）。</summary>
    public static int StartOfSeason(CareerData d, int season)
    {
        season = Math.Max(1, season);
        return d.LongSeasonsFrom <= 0 || season <= d.LongSeasonsFrom
            ? (season - 1) * ShortLength
            : (d.LongSeasonsFrom - 1) * ShortLength + (season - d.LongSeasonsFrom) * LongLength;
    }
    public static bool Upgrade(CareerData d)
    {
        if (d.Esports.EcosystemVersion < 1 || d.LongSeasonsFrom > 0) return false;
        d.LongSeasonsFrom = d.Season + 1;
        CircuitWorld.EnsureOpenEvents(d);
        return true;
    }
}
