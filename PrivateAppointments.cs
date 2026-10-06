namespace NationalSpire;

public static class PrivateAppointments
{
    public static int Date(CareerData data, PrivateOffer offer) => SeasonCalendar.Start(data, offer.Season) + offer.Day;
    public static string Busy(CareerData data, string person, int date)
        => string.Join("、", Schedule(data, person, date).Select(s => s.Event).Distinct());
    public sealed record ScheduleEntry(int Day, string Event, string Description, bool Occupied = true);
    public static List<ScheduleEntry> Schedule(CareerData data, string person, int date)
    {
        var p = CareerEngine.Person(data, person);
        string player = CareerEngine.Name(data);
        var matches = data.Matches.Where(m => m.Day == date && m.Status is "待赛" or "进行中"
            && (m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null))
            .Select(m => new ScheduleEntry(date, m.Event, m.Id == data.PendingMatchId || m.Status == "进行中"
                ? $"{player}正在参加{m.Event}，对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}。"
                : m.Registered ? $"{player}已报名{m.Event}，对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}，比赛尚未开始。"
                : $"{player}可以报名{m.Event}，目前尚未报名；报名后预定对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}。", m.Registered || m.Id == data.PendingMatchId || m.Status == "进行中"));
        var participants = data.HumanIds.Append("player").Append(person).ToHashSet();
        bool TeamInvolved(WorldCompetition competition, string team) => team.Length > 0 &&
            (team == p?.ClubId || team == data.Esports.ClubId || competition.Rosters.GetValueOrDefault(team)?.Any(participants.Contains) == true);
        string FixtureText(WorldFixture f, WorldCompetition c)
        {
            string Side(string id, string team) => team.Length > 0 ? (c.Kind == "worldcup" ? team : EsportsWorld.ClubName(data, team)) : CareerEngine.DisplayName(data, id);
            string HumanName(string id) => id == "player" || id == data.LocalHumanId ? player : CareerEngine.DisplayName(data, id);
            var involved = new List<string>();
            foreach (string id in participants.Where(id => id != person && (f.HomeId == id || f.AwayId == id || f.HomeParticipants.Contains(id) || f.AwayParticipants.Contains(id)))) involved.Add(HumanName(id));
            if (!involved.Contains(player) && data.Esports.ClubId.Length > 0 && (f.HomeTeam == data.Esports.ClubId || f.AwayTeam == data.Esports.ClubId)) involved.Add(player + "所属俱乐部");
            if (f.HomeId == person || f.AwayId == person || f.HomeParticipants.Contains(person) || f.AwayParticipants.Contains(person)) involved.Add(p!.PublicName);
            else if (p?.ClubId.Length > 0 && (f.HomeTeam == p.ClubId || f.AwayTeam == p.ClubId)) involved.Add(p.PublicName + "所属俱乐部");
            foreach (string id in participants.Where(id => c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains(id) == true || c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains(id) == true))
            {
                string name = id == person ? p!.PublicName : HumanName(id);
                if (!involved.Any(s => s.StartsWith(name, StringComparison.Ordinal))) involved.Add(name + "所属队伍");
            }
            return $"{string.Join("、", involved.Distinct())}有{c.Name}的赛程安排，对阵为{Side(f.HomeId, f.HomeTeam)}与{Side(f.AwayId, f.AwayTeam)}，进阶{f.Ascension}，比赛尚未结束。";
        }
        var fixtures = data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => f.Day == date && !f.Finished
            && (participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)
                || TeamInvolved(c, f.HomeTeam) || TeamInvolved(c, f.AwayTeam)))
            // 已报名的同一场玩家赛事已含日期、双方和进阶，避免重复成两项安排。
            .Where(f => !data.Matches.Any(m => m.Day == date && m.CompetitionId == c.Id && m.FixtureId == f.Id
                && m.Status is "待赛" or "进行中" && (m.Registered || m.Id == data.PendingMatchId)))
            .Select(f => new ScheduleEntry(date, c.Name, FixtureText(f, c))));
        return matches.Concat(fixtures).Distinct().ToList();
    }
    public static string DateText(CareerData data, int date)
    {
        int season = Math.Max(1, data.Season);
        while (season > 1 && date <= SeasonCalendar.Start(data, season)) season--;
        while (date > SeasonCalendar.Start(data, season) + SeasonCalendar.Length(data, season)) season++;
        return $"第{season}赛季第{date - SeasonCalendar.Start(data, season)}天";
    }
    public static string DateRanges(CareerData data, IEnumerable<int> dates)
    {
        var values = dates.Distinct().Order().ToArray();
        if (values.Length == 0) return "暂无";
        var ranges = new List<string>(); int start = values[0], end = start;
        void Add() => ranges.Add(start == end ? DateText(data, start) : DateText(data, start)[..^1] + "至" + SeasonCalendar.Day(data, end) + "天");
        foreach (int date in values.Skip(1))
        {
            if (date == end + 1 && SeasonCalendar.Day(data, date) != 1) { end = date; continue; }
            Add(); start = end = date;
        }
        Add(); return string.Join("、", ranges);
    }
    public static string? Error(CareerData data, string person, PrivateOffer offer)
    {
        if (!PrivateMessages.CanChat(data, person)) return "这位选手无法约战。";
        if (offer.Season < data.Season || offer.Season > data.Season + 1 || offer.Day < 1 || offer.Day > SeasonCalendar.Length(data, offer.Season)) return "请选择本赛季或下赛季的有效日期。";
        if (offer.Ascension is < 0 or > 10 || offer.Mode is not ("切磋" or "挑战")) return "约战设置无效。";
        int date = Date(data, offer);
        if (date < data.Day) return "不能安排已经过去的日期。";
        return null;
    }
    public static string? Confirm(CareerData data, string person, PrivateOffer offer)
    {
        if (offer.State != "待确认") return "这项邀约已处理。";
        if (Error(data, person, offer) is { } error) return error;
        var before = PrivateInteractionHistory.Capture(data, person);
        if (offer.ReplacesOfferId.Length > 0)
        {
            var previous = PrivateMessages.Conversation(data, person).Offers.FirstOrDefault(o => o.Id == offer.ReplacesOfferId);
            if (previous != null && Cancel(data, previous) is { } cancellationError) return cancellationError;
        }
        var match = new CareerMatch { Day = Date(data, offer), Event = "私信" + offer.Mode + " · " + CareerEngine.DisplayName(data, person), OpponentId = person,
            Kind = offer.Mode == "挑战" ? "private-challenge" : "private-friendly", RequiredAscension = offer.Ascension, Registered = true, Prize = 0 };
        data.Matches.Add(match); offer.MatchId = match.Id; offer.State = "已确认";
        if (PrivateMessages.Conversation(data, person).Turns.FirstOrDefault(t => t.Id == offer.TurnId) is { } turn)
            PrivateInteractionHistory.Record(data, person, turn, before);
        return null;
    }
    public static void Respond(CareerData data, PrivateConversation c, PrivateTurn turn, Dictionary<string, string> fields, string action)
    {
        if (action is not ("接受" or "邀请" or "拒绝" or "改期")) return;
        int Read(string key, int fallback) => int.TryParse(fields.GetValueOrDefault(key), out int value) ? value : fallback;
        var request = turn.Attachments.LastOrDefault(a => a.Kind == "match" && a.Season == Read("Season", a.Season) && a.Day == Read("Day", a.Day))
            ?? turn.Attachments.LastOrDefault(a => a.Kind == "match") ?? (turn.Request?.Kind == "match" ? turn.Request : null);
        var active = c.Offers.Where(o => o.Kind == "match" && o.State is "待确认" or "已确认").ToList();
        var previous = active.LastOrDefault(o => o.Season == Read("Season", -1) && o.Day == Read("Day", -1)) ?? active.LastOrDefault();
        var basis = request ?? previous;
        var offer = new PrivateOffer { Kind = "match", ResponseAction = action, TurnId = turn.Id,
            Season = Read("Season", basis?.Season ?? data.Season), Day = Read("Day", basis?.Day ?? SeasonCalendar.Day(data, data.Day)),
            Ascension = Read("Ascension", 0), Mode = string.IsNullOrWhiteSpace(fields.GetValueOrDefault("Mode")) ? "切磋" : fields["Mode"] };
        if (action == "拒绝")
        {
            // 玩家本轮附件是独立提议，不因拒绝新提议而取消另一项已约好的比赛。
            if (request != null) previous = active.LastOrDefault(o => o.Season == request.Season && o.Day == request.Day && o.Ascension == request.Ascension && o.Mode == request.Mode);
            else if (fields.ContainsKey("Day")) previous = active.LastOrDefault(o => o.Season == offer.Season && o.Day == offer.Day);
            if (previous != null)
            {
                if (Cancel(data, previous) is { } error) { turn.Error += "\n" + error; return; }
                previous.State = "已拒绝";
            }
            offer.State = "已拒绝"; c.Offers.Add(offer); return;
        }
        if (Error(data, c.PersonId, offer) is { } invalid) { offer.State = "无效"; offer.Detail = invalid; c.Offers.Add(offer); return; }
        if (action == "改期" && previous != null)
        {
            if (previous.State == "已确认") offer.ReplacesOfferId = previous.Id;
            else previous.State = "已改期";
        }
        else
        {
            var same = active.LastOrDefault(o => o.Season == offer.Season && o.Day == offer.Day && o.Ascension == offer.Ascension && o.Mode == offer.Mode);
            if (same != null) { same.ResponseAction = action; return; }
        }
        c.Offers.Add(offer);
    }
    public static string? Cancel(CareerData data, PrivateOffer offer)
    {
        if (offer.MatchId.Length > 0)
        {
            var match = data.Matches.FirstOrDefault(m => m.Id == offer.MatchId);
            if (match != null && (match.Status != "待赛" || data.PendingMatchId == match.Id)) return "这场约战已经开始。";
            if (match != null) { match.Registered = false; match.Status = "已取消"; }
        }
        offer.State = "已取消"; return null;
    }
    public static bool IsPrivate(CareerMatch match) => match.Kind is "private-friendly" or "private-challenge";
    public static bool IsPrivate(CareerResult result) => result.Kind is "private-friendly" or "private-challenge";
}

public static class PrivateContracts
{
    public static string Guidance(CareerData data, CareerPerson p)
    {
        if (OwnedClubs.TransferReserved(data, p.Id)) return $"{p.PublicName}已经签订加盟合同，具体条款和加盟时间见当前资料。";
        var q = OwnedClubs.Quote(p, "steady");
        return $"参考报价为签字费 {q.Signing * 10} 美元，周薪 {q.Wage * 10} 美元，胜场奖金 {q.WinBonus * 10} 美元。金额、合同周数及首发、轮换或青训席位均按双方商谈确定。"
            + (p.ClubId.Length > 0 ? $"转会费另付 {OwnedClubs.TransferFee(p) * 10} 美元，下赛季加盟。" : "自由选手确认签约后立即加入。")
            + $"当前好感 {PrivateMessages.Favour(data, p.Id)}。";
    }
    public static string? Error(CareerData data, string person, PrivateOffer offer)
    {
        if (!OwnedClubs.CanOperate(data)) return "合同由自建俱乐部管理者确认。";
        var p = CareerEngine.Person(data, person);
        if (p == null || !PrivateMessages.CanChat(data, person) || p.ClubId == data.Esports.ClubId) return "该选手暂不接受签约。";
        if (offer.Weeks <= 0 || offer.Weeks > (int.MaxValue - data.Day) / 7 || offer.Role is not ("首发" or "轮换" or "青训")) return "合同需要有效的正数周数及阵容席位。";
        return OwnedClubs.SigningError(data, new() { PersonId = person, Plan = "steady", Position = offer.Role }, p.ClubId.Length > 0);
    }
    public static string? Confirm(CareerData data, string person, PrivateOffer offer, string replacement)
    {
        if (offer.State != "待确认") return "这份报价已处理。";
        if (Error(data, person, offer) is { } error) return error;
        var p = CareerEngine.Person(data, person)!;
        var terms = OwnedClubs.Quote(p, "steady");
        terms.Signing = offer.Signing / 10m; terms.Wage = offer.Wage / 10m; terms.WinBonus = offer.WinBonus / 10m; terms.Days = offer.Weeks * 7;
        var signing = new ClubSigning { PersonId = person, Plan = "steady", Position = offer.Role, ReplaceId = replacement };
        var before = PrivateInteractionHistory.Capture(data, person, true);
        string? result = p.ClubId.Length > 0 ? OwnedClubs.ArrangeTransfer(data, signing, terms) : OwnedClubs.Recruit(data, signing, terms);
        if (result == null)
        {
            offer.State = "已确认";
            if (PrivateMessages.Conversation(data, person).Turns.FirstOrDefault(t => t.Id == offer.TurnId) is { } turn)
                PrivateInteractionHistory.Record(data, person, turn, before, true);
        }
        return result;
    }
}

