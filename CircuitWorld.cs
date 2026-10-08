namespace NationalSpire;

/// <summary>按固定日期运行联赛、团队杯赛和个人总决赛；资格自动落实到日程。</summary>
public static class CircuitWorld
{
    public static readonly int[] LeagueDays = [10, 12, 14, 16, 18];
    public static string TeamName(CareerData d, WorldCompetition c, string team) => c.Kind == "worldcup" ? team : EsportsWorld.ClubName(d, team);
    public static int RoundCount(WorldCompetition c) => c.Kind == "league" ? Math.Max(5, c.Fixtures.Select(f => f.Round).DefaultIfEmpty(5).Max())
        : c.Kind == "worldfinal" ? 5
        : GroupRounds(c) ? WorldCupGroupDays + 3
        : 4;
    /// <summary>世界杯淘汰赛的轮次标签：小组赛 5 轮之后依次是八强、半决赛、决赛。</summary>
    public static string KnockoutName(int round) => (1 << (WorldCupGroupDays + 3 - round + 1)) switch
    { 2 => "决赛", 4 => "半决赛", 8 => "八强赛", _ => "淘汰赛" };
    public static string RoundName(WorldCompetition c, int round) => c.Kind == "league" ? $"第 {round} 轮"
        // 世界杯：前 5 轮是小组赛，之后 3 轮是八强/半决赛/决赛。
        : GroupRounds(c) ? round <= WorldCupGroupDays ? $"小组赛第 {round} 轮" : KnockoutName(round)
        // 世界总决赛与洲际杯仍是纯淘汰赛：轮次 → 三十二强 / 十六强 / 八强 / 半决赛 / 决赛
        : (1 << (RoundCount(c) - round + 1)) switch
    { 2 => "决赛", 4 => "半决赛", 8 => "八强赛", 16 => "十六强赛", _ => "三十二强赛" };
    public static List<CareerStanding> TeamTable(WorldCompetition c)
    {
        var table = c.Teams.Select(id => new CareerStanding { PersonId = id }).ToList();
        foreach (var tie in c.Fixtures.GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Count() >= (c.Cooperative ? 1 : 3) && g.All(f => f.Finished)))
        {
            int home = tie.Count(f => f.WinnerId == f.HomeId), away = tie.Count(f => f.WinnerId == f.AwayId);
            foreach (var row in table.Where(t => t.PersonId == tie.Key.HomeTeam || t.PersonId == tie.Key.AwayTeam))
            {
                bool won = row.PersonId == tie.Key.HomeTeam ? home > away : away > home;
                row.Clears += row.PersonId == tie.Key.HomeTeam ? home : away;
                if (home == away) { row.Draws++; row.Points++; } else if (won) { row.Wins++; row.Points += 3; } else row.Losses++;
            }
        }
        return table.OrderByDescending(t => t.Points).ThenByDescending(t => t.Clears).ThenBy(t => t.PersonId, StringComparer.Ordinal).ToList();
    }
    public static void StartSeason(CareerData d)
    {
        if (d.Esports.Competitions.Any(c => c.Modern && c.Season == d.Season && c.Kind == "league")) { AutoEntry(d); return; }
        int start = SeasonCalendar.Start(d);
        d.Esports.NationalTeam = false;
        d.Esports.Competitions.RemoveAll(c => c.Season < d.Season - 4);
        OwnedClubSchedule.ApplyNextRegion(d);
        OwnedClubs.ArriveTransfers(d);
        ClubCoaching.SeasonStart(d);
        CircuitPeople.Replenish(d);
        CircuitLedger.SeasonStart(d);
        CircuitPeople.SeasonChange(d);
        CircuitPeople.Replenish(d);
        CoachLineups.SeasonStart(d);
        foreach (string nation in EsportsWorld.Countries)
        {
            var c = BuildLeague(d, nation, $"league-{d.Season}-{nation}");
            d.Esports.Competitions.Add(c);
        }
        EnsureOpenEvents(d);
        AutoEntry(d);
    }
    public static WorldCompetition BuildLeague(CareerData d, string nation, string id)
    {
        int start = SeasonCalendar.Start(d);
        var c = new WorldCompetition { Id = id, Name = nation + "俱乐部联赛", Kind = "league", Country = nation,
            Season = d.Season, CalendarStart = start, CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1,
            Cooperative = d.CooperativeMembers > 1, TeamEvent = true, Teams = d.Esports.Clubs.Where(t => t.Country == nation).Select(t => t.Id).ToList() };
        foreach (string team in c.Teams)
            c.Rosters[team] = d.Esports.OwnedClub?.ClubId == team ? OwnedClubSchedule.OfficialRoster(d)
                : CoachLineups.Roster(d, team);
        Snapshot(d, c);
        var rotation = c.Teams.ToList(); if (rotation.Count % 2 != 0) rotation.Add("");
        int rounds = rotation.Count - 1;
        for (int r = 1; r <= rounds; r++)
        {
            int day = start + (c.CalendarDays == 84 ? 22 + (r - 1) * 40 / (rounds - 1) : 10 + (r - 1) * 8 / (rounds - 1));
            for (int i = 0; i < rotation.Count / 2; i++)
                if (rotation[i].Length > 0 && rotation[^(i + 1)].Length > 0) AddTie(c, rotation[i], rotation[^(i + 1)], r, day);
            rotation.Insert(1, rotation[^1]); rotation.RemoveAt(rotation.Count - 1);
        }
        return c;
    }
    public static void AutoEntry(CareerData d)
    {
        EsportsWorld.ClearInvalidRegistrations(d);
        if (d.Esports.EcosystemVersion < 1) return;
        string stage = d.Esports.License switch { 0 => "local", 1 => "city", 2 => "academy", _ => "league" };
        var league = EsportsWorld.PlayerLeague(d);
        if (stage == "league" && league?.Modern == true && !league.PlayerEntered && d.Esports.ClubId.Length > 0 && SeasonCalendar.Day(d, d.Day) <= SeasonCalendar.LeagueDeadline(d))
            EnrollLeague(d, league);
        if (stage != "league" && d.AutoQualifiers)
        {
            var next = d.Matches.OrderBy(m => m.Day).FirstOrDefault(m => m.Kind == stage && m.Day >= d.Day && m.Status == "待赛" && !m.RegistrationDeclined);
            if (next != null) next.Registered = true;
        }
        if (d.Esports.Honors.Any(h => h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-")) && d.Esports.BestClear >= 9)
        {
            var record = d.Matches.FirstOrDefault(m => m.Kind == "masters" && m.Day >= d.Day && m.Status == "待赛");
            if (record != null) record.Registered = true;
        }
        d.Matches = d.Matches.OrderBy(m => m.Day).ToList();
    }
    public static void EnsureOpenEvents(CareerData d)
    {
        int start = SeasonCalendar.Start(d), length = SeasonCalendar.Length(d);
        void Add(int day, string kind, string name, int asc, int prize, Func<CareerPerson, bool> eligible)
        {
            int absolute = start + day;
            if (absolute < d.Day || d.Matches.Any(m => m.Kind == kind && m.Day == absolute)) return;
            var people = d.People.Where(p => p.Country == d.Esports.Country && eligible(p)).OrderBy(p => p.Id, StringComparer.Ordinal).ToList();
            if (people.Count == 0) return;
            var opponent = people[CareerEngine.StableHash(d.WorldId + kind + absolute) % people.Count];
            d.Matches.Add(new() { Day = absolute, Kind = kind, Event = name, RequiredAscension = asc, Prize = prize,
                OpponentId = opponent.Id, Seed = $"NS{d.Season}-{kind}-{day}-{d.WorldId}" });
        }
        // 独立固定办赛日；玩家选择参赛，比赛资格并不消耗后续机会。
        // 世界大赛窗口（联赛结束次日到世界杯决赛）不排公开赛，避免玩家同一天被排到两场比赛。
        int cupOpen = SeasonCalendar.LeagueEnd(d) + 1;
        int cupClose = cupOpen + WorldCupGroupDays + 6;
        for (int offset = 0; offset < length; offset += 14)
        {
            bool Clash(int day) => day >= cupOpen && day <= cupClose;
            if (offset + 3 <= length && !Clash(offset + 3)) Add(offset + 3, "local", offset == 0 ? "街区周末杯" : "社区周末公开杯", 0, 45, p => p.Role == "普通玩家" && !ClubCoaching.IsCoach(p));
            if (offset + 6 <= length && !Clash(offset + 6)) Add(offset + 6, "city", "城市新秀公开赛", 3, 100, p => p.Role == "青训选手" && !ClubCoaching.IsCoach(p));
            if (offset + 9 <= length && !Clash(offset + 9)) Add(offset + 9, "academy", "职业青训选拔赛", 6, 180, p => p.Role == "青训选手" && !ClubCoaching.IsCoach(p));
            if (offset + 11 <= length && !Clash(offset + 11)) Add(offset + 11, "open", "赛区巡回公开赛", 7, 190, EsportsWorld.IsProfessional);
        }
        if (!(length >= cupOpen && length <= cupClose)) Add(length, "masters", "世界纪录邀请赛", 10, 1200, p => p.MaxAscension >= 9 && !ClubCoaching.IsCoach(p));
        d.Matches = d.Matches.OrderBy(m => m.Day).ToList();
    }
    public static void EnrollLeague(CareerData d, WorldCompetition c)
    {
        if (ClubCoaching.PlayerReserve(d) || c.PlayerEntered || !c.Rosters.TryGetValue(d.Esports.ClubId, out var roster)) return;
        c.PlayerReplacedId = roster[0] == "player" ? "" : roster[0];
        if (roster[0] != "player") Replace(d, c, roster[0], "player");
        c.PlayerEntered = true; d.Standings = c.Table; SchedulePlayer(d, c);
    }
    public static void LeavePreseason(CareerData d)
    {
        foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && c.Modern && c.Kind == "league" && c.PlayerEntered && c.Fixtures.All(f => !f.Finished)))
        {
            Replace(d, c, "player", c.PlayerReplacedId); c.PlayerEntered = false; c.PlayerReplacedId = "";
            d.Matches.RemoveAll(m => m.CompetitionId == c.Id); d.Standings = [];
        }
    }
    private static void Snapshot(CareerData d, WorldCompetition c)
    {
        c.Cooperative = d.CooperativeMembers > 1;
        if (c.TeamEvent) c.Entrants = c.Rosters.Values.SelectMany(x => c.Cooperative ? x.Take(1) : x).Distinct().ToList();
        var participants = c.Entrants.Concat(c.Rosters.Values.SelectMany(x => x)).Distinct();
        c.EntrantCountries = participants.ToDictionary(id => id, id => EsportsWorld.CountryOf(d, id));
        c.EntrantClubs = participants.ToDictionary(id => id, id => EsportsWorld.ClubOf(d, id));
        c.Table = c.Entrants.Select(id => new CareerStanding { PersonId = id }).ToList();
    }
    private static void Replace(CareerData d, WorldCompetition c, string oldId, string newId)
    {
        foreach (var roster in c.Rosters.Values) for (int i = 0; i < roster.Count; i++) if (roster[i] == oldId) roster[i] = newId;
        for (int i = 0; i < c.Entrants.Count; i++) if (c.Entrants[i] == oldId) c.Entrants[i] = newId;
        foreach (var row in c.Table.Where(t => t.PersonId == oldId)) row.PersonId = newId;
        foreach (var f in c.Fixtures) { if (f.HomeId == oldId) f.HomeId = newId; if (f.AwayId == oldId) f.AwayId = newId; }
        c.EntrantClubs.Remove(oldId); c.EntrantCountries.Remove(oldId);
        c.EntrantClubs[newId] = EsportsWorld.ClubOf(d, newId); c.EntrantCountries[newId] = EsportsWorld.CountryOf(d, newId);
    }
    /// <summary>
    /// 纯淘汰赛赛事的轮次日：世界总决赛 5 轮、洲际杯 4 轮。
    /// 长赛季用「赛季起始 + 63/64 + 轮次×4」，短赛季用「赛季起始 + 17/18 + 轮次×2」。
    /// 短赛季长度已从 28 天改为 34 天，所以这里用 SeasonCalendar 的常量而不是写死的 28。
    /// </summary>
    private static int DayOf(WorldCompetition c, int round) => c.CalendarDays == 84
        ? c.CalendarStart + (c.Kind == "worldfinal" ? 63 + round * 4 : 64 + round * 4)
        : (c.Season - 1) * SeasonCalendar.ShortLength + (c.Kind == "worldfinal" ? 17 + round * 2 : 18 + round * 2);
    private static void AddTie(WorldCompetition c, string home, string away, int round, int day)
    {
        int asc = c.Kind != "league" && round == RoundCount(c) ? 9 : 8;
        if (!c.TeamEvent) c.Fixtures.Add(new() { Id = $"{c.Id}-{round}-{c.Fixtures.Count}", Day = day, Round = round, HomeId = home, AwayId = away, Ascension = asc });
        else for (int i = 0; i < (c.Cooperative ? 1 : 3); i++) c.Fixtures.Add(new() { Id = $"{c.Id}-{round}-{c.Fixtures.Count}", Day = day, Round = round,
            HomeTeam = home, AwayTeam = away, HomeId = c.Rosters[home][i], AwayId = c.Rosters[away][i], Ascension = asc });
    }
    private static void AddRound(WorldCompetition c, List<string> entrants, int round)
    {
        for (int i = 0; i < entrants.Count / 2; i++) AddTie(c, entrants[i * 2], entrants[i * 2 + 1], round, DayOf(c, round));
    }
    public static void SchedulePlayer(CareerData d, WorldCompetition c)
    {
        foreach (var f in c.Fixtures.Where(f => !f.Finished && (f.HomeId == "player" || f.AwayId == "player")))
        {
            // 淘汰赛占位（FixtureId 为空）只是日历上的行程提示，不是可参加的比赛，跳过。
            if (f.Id.Length == 0) continue;
            if (d.Matches.Any(m => m.FixtureId == f.Id)) continue;
            bool finished = f.Finished;
            string winner = f.WinnerId.Length == 0 ? "待定" : CareerEngine.DisplayName(d, f.WinnerId);
            var entry = new CareerMatch
            {
                CompetitionId = c.Id, FixtureId = f.Id, Round = f.Round, Day = f.Day, Kind = c.Kind,
                Event = c.Name + " · " + RoundName(c, f.Round), OpponentId = f.HomeId == "player" ? f.AwayId : f.HomeId,
                RequiredAscension = f.Ascension, Prize = c.Kind == "league" ? 260 : c.Kind == "worldfinal" ? c.PrizeVersion >= 1 ? 0 : 600 + f.Round * 200 : 400 + f.Round * 180,
                Registered = true, Seed = $"NS-{d.WorldId}-{f.Id}",
                Summary = finished
                    ? $"{CareerEngine.DisplayName(d, f.HomeId)} vs {CareerEngine.DisplayName(d, f.AwayId)} —— {winner}晋级"
                    : $"{CareerEngine.DisplayName(d, f.HomeId)} vs {CareerEngine.DisplayName(d, f.AwayId)}"
            };
            d.Matches.Add(entry);
        }
        d.Matches = d.Matches.OrderBy(m => m.Day).ToList();
    }
    public static void AdvanceCompetition(CareerData d, WorldCompetition c, int day, bool publish)
    {
        if (c.Finished) return;
        // 世界杯：小组赛全部打完后先开八强（每天一场、逐轮推进），此时当天没有比赛。
        if (GroupFormat(c) && c.GroupStage)
        {
            if (TryStartWorldCupKnockout(d, c)) { SchedulePlayer(d, c); return; }
            if (c.Fixtures.Any(f => !f.Finished)) return;
        }
        var today = c.Fixtures.Where(f => f.Day == day).ToList();
        if (today.Count == 0 || today.Any(f => !f.Finished)) return;
        if (c.Kind == "league")
        {
            if (c.Fixtures.Any(f => !f.Finished)) return;
            c.ChampionTeam = TeamTable(c)[0].PersonId;
            c.ChampionId = c.Rosters[c.ChampionTeam].OrderByDescending(id => c.Table.FirstOrDefault(t => t.PersonId == id)?.Wins ?? 0).First();
        }
        else
        {
            // 淘汰赛改为「每场单独一天」后，同一天只打 1 场，不能再拿当天的场次判定是否打完一轮：
            // 必须等同一轮（Round）的所有场次都结束，才由这一轮的胜者生成下一轮。
            int round = today[0].Round;
            var roundFixtures = c.Fixtures.Where(f => f.Round == round).ToList();
            if (GroupFormat(c) && roundFixtures.Any(f => !f.Finished)) return;
            // 胜者取自整轮而不是当天：每场单独一天时，当天只有 1 场，只取当天会把单个胜者误判成最终冠军。
            var decided = GroupFormat(c) ? roundFixtures : today;
            var winners = c.TeamEvent ? decided.GroupBy(f => (f.HomeTeam, f.AwayTeam))
                .Select(g => g.Count(f => f.WinnerId == f.HomeId) > g.Count(f => f.WinnerId == f.AwayId) ? g.Key.HomeTeam : g.Key.AwayTeam).ToList()
                : decided.Select(f => f.WinnerId).ToList();
            if (winners.Count > 1)
            {
                int nextRound = round + 1;
                if (GroupFormat(c))
                {
                    // 长赛季每天一场：本轮最后一场的次日开始逐场铺开。
                    // 短赛季一轮跨多天：下一轮从本轮最后一天的次日开始，每天摊 perDay 场
                    // （八强 2 天 × 2 场、半决赛 1 天 × 2 场），这样 9 天赛程刚好收在赛季最后一天。
                    int day2 = roundFixtures.Max(f => f.Day) + 1;
                    int span = KnockoutSpan(d, nextRound);
                    int total = winners.Count / 2;
                    int perDay = (int)Math.Ceiling(total / (double)span);
                    for (int i = 0; i + 1 < winners.Count; i += 2)
                    {
                        AddTie(c, winners[i], winners[i + 1], nextRound, day2 + (i / 2) / perDay);
                    }
                    ResolveKnockoutPlaceholders(d, c, nextRound);
                }
                else AddRound(c, winners, nextRound);
                SchedulePlayer(d, c); return;
            }
            // 只剩一场且已是决赛：把决赛占位换成真实对阵，日历上就能看到决赛结果对应的那一场。
            if (GroupFormat(c)) ResolveKnockoutPlaceholders(d, c, round);
            c.ChampionTeam = c.TeamEvent ? winners[0] : "";
            c.ChampionId = c.TeamEvent ? c.Rosters[winners[0]].OrderByDescending(id => c.Fixtures.Count(f => f.WinnerId == id)).First() : winners[0];
        }
        c.Finished = true; CircuitLedger.Settle(d, c, publish); AutoEntry(d);
    }
    public static void CreateFinals(CareerData d, bool publish)
    {
        if (d.Esports.Competitions.Any(c => c.Season == d.Season && c.Kind is "continental" or "worldcup")) return;
        var leagues = d.Esports.Competitions.Where(c => c.Season == d.Season && c.Modern && c.Kind == "league").ToList();
        if (leagues.Count != 8 || leagues.Any(c => !c.Finished)) return;
        // 国内个人表现前二自动进入总决赛，其余席位按有效积分和本季表现补齐。
        var qualified = leagues.SelectMany(c => EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2).Select(t => t.PersonId)).Distinct().ToList();
        string previousChampion = d.Esports.CircuitAwards.LastOrDefault(a => a.Kind == "worldfinal" && a.Place == "冠军")?.PersonId ?? "";
        if (previousChampion.Length > 0 && !d.DeletedPeople.ContainsKey(previousChampion) && (previousChampion == "player" ? leagues.Any(c => c.PlayerEntered) : CareerEngine.Person(d, previousChampion) is { } defending && EsportsWorld.IsProfessional(defending))) qualified.Add(previousChampion);
        qualified = qualified.Distinct().ToList();
        var candidates = leagues.SelectMany(c => c.Table).OrderByDescending(t => CircuitLedger.Points(d, t.PersonId))
            .ThenByDescending(t => t.Wins).ThenByDescending(t => EsportsWorld.RatingOf(d, t.PersonId)).Select(t => t.PersonId);
        qualified.AddRange(candidates.Where(id => !d.DeletedPeople.ContainsKey(id) && !qualified.Contains(id)).Take(32 - qualified.Count));
        var final = new WorldCompetition { Id = $"worldfinal-{d.Season}", Kind = "worldfinal", Name = "世界总决赛", Country = "国际", Season = d.Season,
            CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1, Entrants = qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + id)).ToList(), PlayerEntered = qualified.Contains("player") };
        bool finalSeason = d.Season % 2 == 1;
        // 世界总决赛保持原来的 32 人纯淘汰赛：抽一次签，胜者逐轮晋级，每轮隔 2 天。
        if (finalSeason) { Snapshot(d, final); AddRound(final, final.Entrants, 1); d.Esports.Competitions.Add(final); SchedulePlayer(d, final); }
        string kind = d.Season % 2 == 0 ? "worldcup" : "continental";
        var cup = new WorldCompetition { Id = $"{kind}-{d.Season}", Kind = kind, Name = EsportsWorld.StageName(kind), Country = "国际", Season = d.Season, CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1, TeamEvent = true };
        foreach (var league in leagues)
        {
            if (kind == "worldcup")
            {
                cup.Teams.Add(league.Country);
                // 代表资格按照国籍和本季个人赛果计算，支持海外俱乐部选手归队。
                var selection = leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))
                    .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))
                    .OrderByDescending(x => x.Table.Points).ThenByDescending(x => x.Table.Clears).Take(d.CooperativeMembers > 1 ? 1 : 3).Select(x => x.Table.PersonId).ToList();
                if (d.CooperativeMembers > 1 && selection.FirstOrDefault() == "player")
                    selection.AddRange(OwnedClubs.ActiveHumans(d).Skip(1));
                else if (d.CooperativeMembers > 1 && selection.Count > 0)
                    selection.AddRange(d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending(p => p.Rating).Take(d.CooperativeMembers - 1).Select(p => p.Id));
                int needed = d.CooperativeMembers > 1 ? d.CooperativeMembers : 3;
                selection.AddRange(d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))
                    .OrderByDescending(p => p.Rating).Take(Math.Max(0, needed - selection.Count)).Select(p => p.Id));
                cup.Rosters[league.Country] = selection;
                // 世界杯是个人赛：入选的 3 人各自为战，按国籍记入国家队。
                foreach (string id in selection) if (!cup.Entrants.Contains(id)) cup.Entrants.Add(id);
            }
            else foreach (var team in TeamTable(league).Take(2))
            {
                cup.Teams.Add(team.PersonId);
                var roster = league.Rosters[team.PersonId].ToList();
                for (int i = 0; i < roster.Count; i++)
                    if (d.DeletedPeople.ContainsKey(roster[i]) && d.People.Where(p => p.ClubId == team.PersonId && EsportsWorld.IsProfessional(p) && !roster.Contains(p.Id))
                        .OrderByDescending(p => p.Rating).FirstOrDefault() is { } replacement) roster[i] = replacement.Id;
                cup.Rosters[team.PersonId] = roster;
            }
        }
        // 世界杯改为个人赛：不设团队胜负，也不再有 TeamEvent 的三人三场。
        if (GroupFormat(cup)) { cup.TeamEvent = false; cup.Entrants = cup.Entrants.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + "cup" + id)).ToList(); }
        cup.Teams = cup.Teams.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + kind + id)).ToList();
        Snapshot(d, cup); cup.PlayerEntered = cup.Entrants.Contains("player");
        d.Esports.NationalTeam = kind == "worldcup" && cup.PlayerEntered;
        if (GroupFormat(cup)) CreateWorldCupSchedule(d, cup);
        else AddRound(cup, cup.Teams, 1);
        d.Esports.Competitions.Add(cup); SchedulePlayer(d, cup);
        // 只有走小组赛赛制的世界杯需要铺淘汰赛占位；世界总决赛是纯淘汰赛，按原样处理。
        if (GroupFormat(cup)) ScheduleKnockoutPlaceholders(d, cup);
        if (publish) CareerEngine.Publish(d, "draw-" + d.Season, "世界大赛签表公布", (finalSeason ? "世界总决赛32位选手就位。" : "") + $"{cup.Name}公布阵容。"
            + (finalSeason && final.PlayerEntered ? $"{CareerEngine.Name(d)}取得世界总决赛席位。" : "") + (cup.PlayerEntered ? $"{CareerEngine.Name(d)}入选{(kind == "worldcup" ? d.Esports.Country : EsportsWorld.ClubName(d, d.Esports.ClubId))}首发阵容。" : ""), "国际赛事", true,
            finalSeason && final.PlayerEntered || cup.PlayerEntered ? ["player"] : []);
    }

    // ── 世界杯赛程：4 组 × 6 人小组赛 5 天 + 八强 4 天 + 半决赛 2 天 + 决赛 1 天 = 12 天 ──

    /// <summary>小组数量与每组人数（24 人 = 4 组 × 6 人）。</summary>
    public const int WorldCupGroups = 4, WorldCupGroupSize = 6;
    /// <summary>参赛人数：4 组 × 6 人 = 24 人。世界总决赛仍是 32 人纯淘汰赛，不用这个规模。</summary>
    public const int WorldCupPlayers = WorldCupGroups * WorldCupGroupSize;
    /// <summary>小组赛占用的天数（组内单循环：每人 5 场，每轮每组 3 场同时进行）。</summary>
    public const int WorldCupGroupDays = 5;
    /// <summary>
    /// 世界杯淘汰赛总天数。长赛季（84 天）时间充裕，每天一场：八强 4 + 半决赛 2 + 决赛 1 = 7 天，全程 12 天。
    /// 短赛季（28 天）联赛第 18 天结束、赛季第 28 天收尾，只剩 10 天可用，因此压缩为
    /// 八强 2 天（每天 2 场）+ 半决赛 1 天（2 场同时）+ 决赛 1 天 = 4 天，全程 9 天（第 19—27 天）。
    /// </summary>
    public static int KnockoutDays(CareerData d) => SeasonCalendar.Length(d) == SeasonCalendar.LongLength ? 7 : 4;
    /// <summary>淘汰赛每轮在短赛季里跨几天；下标 = round - WorldCupGroupDays - 1（八强、半决赛、决赛）。</summary>
    private static readonly int[] ShortKnockoutSpan = [2, 1, 1];
    /// <summary>某一轮在短赛季里占用的天数；长赛季固定 1 天。</summary>
    private static int KnockoutSpan(CareerData d, int round) =>
        SeasonCalendar.Length(d) == SeasonCalendar.LongLength ? 1 : ShortKnockoutSpan[Math.Clamp(round - WorldCupGroupDays - 1, 0, 2)];
    /// <summary>
    /// 是否采用「小组赛 + 淘汰赛」新赛制：只有国家队世界杯改成了个人赛，
    /// 世界总决赛保持原来的 32 人纯淘汰赛。
    /// </summary>
    public static bool GroupFormat(WorldCompetition c) => c.Kind == "worldcup";
    /// <summary>是否按「小组赛 + 淘汰赛」读轮次（与 <see cref="GroupFormat"/> 区分：后者决定建赛方式）。</summary>
    private static bool GroupRounds(WorldCompetition c) => c.Kind == "worldcup";

    /// <summary>世界杯开赛日：联赛结束的次日。短赛季第 18 天结束 → 第 19 天开打；长赛季第 62 天 → 第 63 天。</summary>
    private static int WorldCupStart(CareerData d) => SeasonCalendar.StartOfSeason(d, d.Season) + SeasonCalendar.LeagueEnd(d) + 1;

    /// <summary>是否在世界大赛里看到淘汰赛的日程占位（供界面与日历标注）。</summary>
    public static bool WaitingKnockout(WorldCompetition c, int day) =>
        GroupFormat(c) && c.GroupStage && day >= c.GroupStartDay + WorldCupGroupDays
        && day < c.GroupStartDay + WorldCupGroupDays + 7;

    /// <summary>淘汰赛占位场次的对手标记：对阵要等上一轮打完才能确定。</summary>
    public const string KnockoutTbd = "tbd";

    /// <summary>
    /// 淘汰赛赛程占位：对阵要等上一轮打完才知道，但每一轮占用的日子是固定的。
    /// 这里把整届淘汰赛的 7 个比赛日全部写进玩家日程——不管他有没有出线——
    /// 日历上就能看到"八强赛 / 半决赛 / 决赛"的轮次，点进去还能看到对决双方与晋级情况，
    /// 不会出现"某几天只显示赛事名"的空白。对阵与胜者在每轮打完后由
    /// <see cref="ResolveKnockoutPlaceholders"/> 回填。
    /// </summary>
    public static void ScheduleKnockoutPlaceholders(CareerData d, WorldCompetition c)
    {
        if (!GroupFormat(c)) return;
        d.Matches.RemoveAll(m => m.CompetitionId == c.Id && m.FixtureId.Length == 0);
        int[] counts = [4, 2, 1];
        int day = c.GroupStartDay + WorldCupGroupDays;
        for (int round = WorldCupGroupDays + 1; round <= WorldCupGroupDays + counts.Length; round++)
        {
            int matches = counts[round - WorldCupGroupDays - 1];
            string label = KnockoutName(round);
            // 短赛季里一轮跨多天：每天摊几场由 KnockoutSpan 决定（八强 2 天 × 2 场，半决赛 1 天 × 2 场）。
            int span = KnockoutSpan(d, round);
            int perDay = (int)Math.Ceiling(matches / (double)span);
            for (int offset = 0; offset < matches; offset++)
            {
                d.Matches.Add(new CareerMatch
                {
                    CompetitionId = c.Id, FixtureId = "", Round = round, Day = day + offset / perDay, Kind = c.Kind,
                    Event = $"{c.Name} · {label}（第 {offset + 1} 场，签表待定）", OpponentId = KnockoutTbd,
                    RequiredAscension = round == WorldCupGroupDays + 3 ? 9 : 8,
                    Prize = 400 + round * 180, Registered = false,
                    Seed = $"NS-{d.WorldId}-{c.Id}-{label}-{offset}"
                });
            }
            day += span;
        }
        d.Matches = d.Matches.OrderBy(m => m.Day).ToList();
    }

    /// <summary>
    /// 小组赛出线后用真实对阵替换占位：
    /// 玩家参与的那一场变成正式比赛（待报名），其余同轮场次从日程里移除——
    /// 否则一次八强会在日历上列出四场，看起来像要连打四场。
    /// 玩家已被淘汰时整轮移除。
    /// </summary>
    /// <summary>
    /// 一轮打完后回填对阵与晋级结果：日历与详情页都能看到谁对谁、谁赢了。
    /// 玩家参与的场次变成可报名的正式比赛；没参与的场次保留为赛程记录（不报名，只作展示）。
    /// </summary>
    public static void ResolveKnockoutPlaceholders(CareerData d, WorldCompetition c, int round)
    {
        var real = c.Fixtures.Where(f => f.Round == round).ToList();
        if (real.Count == 0) return;
        var rows = d.Matches.Where(m => m.CompetitionId == c.Id && m.FixtureId.Length == 0 && m.Round == round).ToList();
        foreach (var fixture in real)
        {
            // 玩家那一场在 SchedulePlayer 里已经建过日程，不能重复添加。
            if (d.Matches.Any(m => m.FixtureId == fixture.Id)) continue;
            var row = rows.FirstOrDefault(m => m.Day == fixture.Day);
            if (row == null)
            {
                row = new CareerMatch
                {
                    CompetitionId = c.Id, Round = round, Day = fixture.Day, Kind = c.Kind,
                    Prize = 400 + round * 180, Registered = false, Seed = $"NS-{d.WorldId}-{fixture.Id}"
                };
                d.Matches.Add(row);
            }
            bool mine = fixture.HomeId == "player" || fixture.AwayId == "player";
            bool finished = fixture.Finished;
            string winner = fixture.WinnerId;
            string winnerName = winner.Length == 0 ? "待定" : CareerEngine.DisplayName(d, winner);
            row.FixtureId = fixture.Id;
            row.Event = $"{c.Name} · {KnockoutName(round)}";
            row.OpponentId = mine ? (fixture.HomeId == "player" ? fixture.AwayId : fixture.HomeId) : KnockoutTbd;
            row.RequiredAscension = fixture.Ascension;
            // 已经打完的那一轮直接把结果写进摘要，日历与详情页不点开也能看到晋级情况。
            string home = CareerEngine.DisplayName(d, fixture.HomeId), away = CareerEngine.DisplayName(d, fixture.AwayId);
            row.Summary = finished
                ? $"{home} vs {away} —— {winnerName}晋级"
                : $"{home} vs {away} —— 胜者晋级下一轮";
            row.Registered = false;
        }
        // 占位比真实场次多出的部分（正常情况下不会出现）直接清掉，避免留下空壳。
        foreach (var row in rows.Where(m => m.FixtureId.Length == 0)) d.Matches.Remove(row);
        d.Matches = d.Matches.OrderBy(m => m.Day).ToList();
    }

    /// <summary>按小组赛 + 淘汰赛铺排世界杯全部场次。</summary>
    private static void CreateWorldCupSchedule(CareerData d, WorldCompetition c)
    {
        c.CalendarDays = SeasonCalendar.Length(d);
        // 开赛日记录在赛事自身上：长赛季联赛到第 62 天，开赛日必须跟着缩放。
        c.GroupStartDay = WorldCupStart(d);
        var pool = c.Entrants.Distinct().ToList();
        // 按稳定哈希分组，保证同一存档每次构造分组一致。
        var ordered = pool.OrderBy(id => CareerEngine.StableHash(d.WorldId + c.Season + "group" + id)).ToList();
        c.Groups.Clear(); c.GroupOfPlayer.Clear();
        for (int g = 0; g < WorldCupGroups; g++)
        {
            string name = ((char)('A' + g)).ToString();
            var members = ordered.Skip(g * WorldCupGroupSize).Take(WorldCupGroupSize).ToList();
            if (members.Count < 2) continue;
            c.Groups[name] = members;
            foreach (string id in members) c.GroupOfPlayer[id] = name;
        }
        c.GroupStage = true;
        // 小组赛还没打，先把淘汰赛的日子占上，日历上就能看到完整的 12 天赛程。
        ScheduleKnockoutPlaceholders(d, c);
        // 组内单循环：用轮转法排 5 轮，每轮每组 3 场同时开打。
        foreach (var (name, members) in c.Groups)
        {
            var rotation = members.ToList();
            if (rotation.Count % 2 != 0) rotation.Add("");
            int rounds = rotation.Count - 1;
            for (int r = 0; r < rounds; r++)
            {
                int day = c.GroupStartDay + r;
                for (int i = 0; i < rotation.Count / 2; i++)
                {
                    string home = rotation[i], away = rotation[^(i + 1)];
                    if (home.Length == 0 || away.Length == 0) continue;
                    c.Fixtures.Add(new WorldFixture
                    {
                        Id = $"{c.Id}-g{r + 1}-{c.Fixtures.Count}", Day = day, Round = r + 1,
                        HomeId = home, AwayId = away, Ascension = 8, HomeTeam = name, AwayTeam = name
                    });
                }
                rotation.Insert(1, rotation[^1]); rotation.RemoveAt(rotation.Count - 1);
            }
        }
    }

    /// <summary>小组赛积分榜：按小组分别统计，胜 3 分、平 1 分。</summary>
    public static List<CareerStanding> GroupTable(WorldCompetition c, string group)
    {
        if (!c.Groups.TryGetValue(group, out var members)) return [];
        var table = members.Select(id => new CareerStanding { PersonId = id }).ToList();
        foreach (var f in c.Fixtures.Where(f => f.Round <= WorldCupGroupDays && f.Finished && c.GroupOfPlayer.GetValueOrDefault(f.HomeId) == group))
        {
            var home = table.FirstOrDefault(t => t.PersonId == f.HomeId);
            var away = table.FirstOrDefault(t => t.PersonId == f.AwayId);
            if (f.Draw)
            {
                if (home != null) { home.Draws++; home.Points++; }
                if (away != null) { away.Draws++; away.Points++; }
                continue;
            }
            bool homeWon = f.WinnerId == f.HomeId;
            var winner = homeWon ? home : away;
            var loser = homeWon ? away : home;
            if (winner != null) { winner.Wins++; winner.Points += 3; }
            if (loser != null) loser.Losses++;
        }
        return table.OrderByDescending(t => t.Points)
            .ThenByDescending(t => t.Wins)
            .ThenByDescending(t => CareerEngine.StableHash(c.Id + t.PersonId))
            .ToList();
    }

    /// <summary>小组赛是否已全部结束（该打的日子都打完、没有未完成场次）。</summary>
    private static bool GroupPhaseFinished(WorldCompetition c) =>
        c.Fixtures.Where(f => f.Round <= WorldCupGroupDays).All(f => f.Finished);

    /// <summary>
    /// 小组赛结束后生成八强：每组前二出线，随机配对（不按组固定交叉）。
    /// 之后八强、半决赛、决赛各占一天，每场单独一天。
    /// </summary>
    private static bool TryStartWorldCupKnockout(CareerData d, WorldCompetition c)
    {
        if (!c.GroupStage || !GroupPhaseFinished(c)) return false;
        var qualified = c.Groups.Keys.OrderBy(name => name, StringComparer.Ordinal)
            .SelectMany(group => GroupTable(c, group).Take(2).Select(t => t.PersonId)).ToList();
        // 出线人数不足 2 人时不要清掉小组赛标记，否则该赛事会永久卡在无法推进的状态。
        if (qualified.Count < 2) return false;
        c.GroupStage = false;
        int day = c.GroupStartDay + WorldCupGroupDays;
        var shuffled = qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + c.Season + "ko" + id)).ToList();
        // 八强 4 场也每场单独一天，之后半决赛、决赛各自继续往后顺延。
        for (int i = 0; i + 1 < shuffled.Count; i += 2) { AddTie(c, shuffled[i], shuffled[i + 1], WorldCupGroupDays + 1, day); day++; }
        ResolveKnockoutPlaceholders(d, c, WorldCupGroupDays + 1);
        return true;
    }
    public static bool ReplayTie(CareerData d, CareerMatch m)
    {
        if (!m.Draw || d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)?.Modern != true) return false;
        m.Seed = MatchRules.RandomizeSeed(m.Seed); m.SeedRandomized = true; m.OpponentPrepared = false; m.OpponentSeconds = null; m.PlayerSeconds = null; m.Draw = false;
        m.Decider = "上一局双方成绩相同，本场更换种子加赛。";
        d.PendingMatchId = null; d.PendingSince = 0; CareerStore.Save(d); return true;
    }
    public static List<CareerPerson> CooperativeRoster(CareerData d, WorldCompetition? c, string leaderId, string seed)
    {
        var leader = CareerEngine.Person(d, leaderId) ?? throw new InvalidOperationException("对手不存在。");
        var official = c?.Rosters.Values.FirstOrDefault(r => r.Contains(leaderId));
        if (official != null)
        {
            var members = new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")
                .Select(id => CareerEngine.Person(d, id)).OfType<CareerPerson>().Take(d.CooperativeMembers).ToList();
            if (members.Count == d.CooperativeMembers) return members;
        }
        var pool = d.People.Where(p => p.Id != leaderId && !d.HumanIds.Contains(p.Id) && p.Country == leader.Country && !ClubCoaching.IsCoach(p));
        if (c?.Kind is "league" or "continental" or "worldfinal") pool = pool.Where(p => p.ClubId == leader.ClubId && EsportsWorld.IsProfessional(p));
        if (c?.Kind == "worldcup") pool = pool.Where(EsportsWorld.IsProfessional);
        return new[] { leader }.Concat(pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy(p => CareerEngine.StableHash(seed + p.Id)).Take(d.CooperativeMembers - 1)).ToList();
    }
    public static void EnsureHumanRosters(CareerData d)
    {
        var active = OwnedClubs.ActiveHumans(d);
        if (d.CooperativeMembers < 2 || active.Count != d.CooperativeMembers) return;
        foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && c.Cooperative && c.TeamEvent && !c.Finished))
        foreach (string team in c.Rosters.Where(pair => pair.Value.Contains("player")).Select(pair => pair.Key).ToList())
        {
            c.Rosters[team] = active.ToList();
            foreach (string id in c.Rosters[team])
            { c.EntrantCountries[id] = EsportsWorld.CountryOf(d, id); c.EntrantClubs[id] = EsportsWorld.ClubOf(d, id); }
        }
    }
    public static CareerPerson CooperativePerformance(CareerData d, WorldCompetition? c, string id, string seed, int? day = null)
    {
        if (d.CooperativeMembers < 2) return CareerEngine.Person(d, id)!;
        var roster = CooperativeRoster(d, c, id, seed);
        if (roster.Count != d.CooperativeMembers) throw new InvalidOperationException("对手队伍人数不足。");
        return new CareerPerson { Id = id, Arbitrations = roster.SelectMany(p => p.Arbitrations).Where(r => r.Sanction is "禁赛" or "封号").ToList(), Rating = (int)roster.Average(p => p.Rating), MaxAscension = (int)Math.Round(roster.Average(p => p.MaxAscension)),
            Learning = new() { MoodAggregated = true, ChanceShift = roster.Average(p => p.Learning.ChanceShift), MoodStrength = roster.Average(p => CareerTraining.MoodLevel(p, day ?? d.Day)), MoodDay = day ?? d.Day, MoodUntil = (day ?? d.Day) + 1 },
            Form = roster[0].Form, Role = roster.All(EsportsWorld.IsProfessional) ? "职业选手" : "普通玩家" };
    }
}
