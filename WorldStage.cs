namespace NationalSpire;

/// <summary>
/// 世界大赛状态。用户要求把「世界赛是否开始」做成一个显式变量：开始时 true，结束时 false。
/// 判定与刷新都集中在这里，供弹幕层按世界赛优先抽取专用词条，也供界面与提示词判断语境。
///
/// 口径：世界总决赛（worldfinal）与国家队世界杯（worldcup）属于「世界赛」；
/// 洲际俱乐部冠军杯（continental）是国际赛事但不计入，避免一年里大半时间都算世界赛。
/// </summary>
public static class WorldStage
{
    /// <summary>属于「世界赛」的赛事类型。</summary>
    private static readonly string[] Kinds = ["worldfinal", "worldcup"];

    /// <summary>最后一场世界赛结束后的缓冲天数：结算与赛后清算也算在世界赛期内。</summary>
    private const int AfterglowDays = 7;
    /// <summary>玩家比赛开始前的提前天数：抽签到开打之间的备战期也算世界赛期内。</summary>
    private const int LeadDays = 2;

    /// <summary>
    /// 世界赛是否已经开始。
    /// 口径是「玩家正在经历世界赛」：自己还有没打完的世界赛对决、刚刚打完（赛后清算期）、
    /// 或者即将开打。这样弹幕里的清算梗针对的是玩家本人的外战成绩，
    /// 而不是玩家没参加世界赛时也在刷「大满败」。
    /// </summary>
    public static bool IsActive(CareerData data)
    {
        var competitions = data.Esports.Competitions.Where(c => Kinds.Contains(c.Kind) && c.Season == data.Season).ToList();
        if (competitions.Count == 0) return false;
        var fixtures = competitions.SelectMany(c => c.Fixtures)
            .Where(f => f.HomeId == "player" || f.AwayId == "player" || f.HomeParticipants.Contains("player") || f.AwayParticipants.Contains("player"))
            .ToList();
        if (fixtures.Count == 0) return false;
        if (fixtures.Any(f => !f.Finished)) return true;
        int lastDay = fixtures.Select(f => f.Day).DefaultIfEmpty(0).Max();
        if (lastDay > 0 && data.Day - lastDay <= AfterglowDays) return true;
        // 下一场世界赛就在这几天：也算世界赛期，让赛前挖苦（藏飞机票之类）有出场机会。
        int nextDay = fixtures.Where(f => f.Day > data.Day).Select(f => f.Day).DefaultIfEmpty(0).Min();
        return nextDay > 0 && nextDay - data.Day <= LeadDays;
    }

    /// <summary>
    /// 刷新显式状态变量。开始时置 true、结束时置 false；
    /// 状态没有变化时不写盘，避免每天空存一次存档。
    /// </summary>
    public static void Refresh(CareerData data) => data.WorldStageActive = IsActive(data);

    /// <summary>当前世界赛的名称，用于界面与日志。</summary>
    public static string Name(CareerData data)
    {
        var competition = data.Esports.Competitions.FirstOrDefault(c => Kinds.Contains(c.Kind) && c.Season == data.Season && !c.Finished)
            ?? data.Esports.Competitions.FirstOrDefault(c => Kinds.Contains(c.Kind) && c.Season == data.Season);
        return competition?.Name ?? "世界大赛";
    }
}
