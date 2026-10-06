namespace NationalSpire;

/// <summary>公开日程快照只记录已公布的对阵及历史赛果，不读取预先模拟的结果。</summary>
public sealed class PublicSchedule
{
    public int AsOfDay { get; set; }
    public List<PublicMatch> Upcoming { get; set; } = [];
    public List<PublicMeeting> RecentMeetings { get; set; } = [];
    public List<PublicMatch> RelatedFixtures { get; set; } = [];

    // 保留存档快照，发送时为每条资料补齐当事人和状态含义。
    public static object? ForPrompt(PublicSchedule? schedule) => schedule == null ? null : new
    {
        schedule.AsOfDay,
        资料日期 = $"生涯第{schedule.AsOfDay}天，以下Day均为生涯累计日期",
        Upcoming = schedule.Upcoming.Select(m => new { m.Day, m.Event, m.Ascension,
            参赛情况 = m.Status == "可报名，尚未报名"
                ? $"{m.Home}可以报名{m.Event}，目前尚未报名；报名后预定对手为{m.Away}。"
                : $"{m.Home}在{m.Event}的状态为{m.Status}，对手为{m.Away}。" }),
        RecentMeetings = schedule.RecentMeetings.Select(m => new { m.Day, m.Event, m.Ascension,
            比赛记录 = $"{(m.Participant.Length > 0 ? m.Participant : "玩家")}对阵{m.Opponent}，{(m.Participant.Length > 0 ? m.Participant : "玩家")}的赛果为{m.Outcome}，表现为{m.Performance}。" }),
        RelatedFixtures = schedule.RelatedFixtures.Select(m => new { m.Day, m.Event, m.Ascension,
            对阵情况 = $"{m.Home}与{m.Away}将在{m.Event}交手，{m.Status}。" })
    };

    public static PublicSchedule Capture(CareerData data, IEnumerable<string> related)
    {
        var upcoming = data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")
            .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)
            .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId).ThenBy(m => m.Day).Take(3).OrderBy(m => m.Day).ToList();
        var opponents = upcoming.Select(m => m.OpponentId).ToHashSet();
        var past = data.Results.Where(r => r.OfficialAscensionVerified && r.Day <= data.Day && r.Kind != "private-friendly").ToList();
        var meetings = past.TakeLast(2).Concat(opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))
            .OfType<CareerResult>()).DistinctBy(r => r.MatchId).OrderByDescending(r => r.Day).Take(5);
        var subjects = related.Where(id => id != "player" && id != "desk").ToHashSet();
        return new()
        {
            AsOfDay = data.Day,
            Upcoming = upcoming.Select(m => new PublicMatch { Day = m.Day, Event = m.Event, Ascension = m.RequiredAscension,
                Home = CareerEngine.Name(data), Away = CareerEngine.DisplayName(data, m.OpponentId),
                Status = m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名" }).ToList(),
            RecentMeetings = meetings.Select(r => new PublicMeeting { Day = r.Day, Event = r.Event, Participant = CareerEngine.Name(data),
                Opponent = CareerEngine.DisplayName(data, r.OpponentId), Outcome = r.Outcome, Ascension = r.Ascension,
                Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds) }).ToList(),
            RelatedFixtures = data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day
                && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"
                && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch
                { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),
                    Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy(f => f.Day).Take(2).ToList()
        };
    }
}
public sealed class PublicMatch
{
    public int Day { get; set; }
    public string Event { get; set; } = "";
    public string Home { get; set; } = "";
    public string Away { get; set; } = "";
    public int Ascension { get; set; }
    public string Status { get; set; } = "";
}
public sealed class PublicMeeting
{
    public string Participant { get; set; } = "";
    public int Day { get; set; }
    public string Event { get; set; } = "";
    public string Opponent { get; set; } = "";
    public string Outcome { get; set; } = "";
    public int Ascension { get; set; }
    public string Performance { get; set; } = "";
}
