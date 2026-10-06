namespace NationalSpire;

/// <summary>旧赛程保持日期，新赛季使用十二周；绝对日期继续单调递增。</summary>
public static class SeasonCalendar
{
    public static int Length(CareerData d, int season = 0) => d.LongSeasonsFrom > 0 && (season == 0 ? d.Season : season) >= d.LongSeasonsFrom ? 84 : 28;
    public static int Start(CareerData d, int season = 0)
    {
        season = season == 0 ? d.Season : season;
        return d.LongSeasonsFrom <= 0 || season <= d.LongSeasonsFrom ? (season - 1) * 28
            : (d.LongSeasonsFrom - 1) * 28 + (season - d.LongSeasonsFrom) * 84;
    }
    public static int End(CareerData d) => Start(d) + Length(d);
    public static int Day(CareerData d, int absolute)
    {
        int change = d.LongSeasonsFrom > 0 ? (d.LongSeasonsFrom - 1) * 28 : int.MaxValue;
        return absolute > change ? (absolute - change - 1) % 84 + 1 : (absolute - 1) % 28 + 1;
    }
    public static int LeagueDeadline(CareerData d) => Length(d) == 84 ? 22 : 10;
    public static int LeagueEnd(CareerData d) => Length(d) == 84 ? 62 : 18;
    public static bool Upgrade(CareerData d)
    {
        if (d.Esports.EcosystemVersion < 1 || d.LongSeasonsFrom > 0) return false;
        d.LongSeasonsFrom = d.Season + 1;
        CircuitWorld.EnsureOpenEvents(d);
        return true;
    }
}
