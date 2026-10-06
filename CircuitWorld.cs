namespace NationalSpire;

/// <summary>按固定日期运行联赛、团队杯赛和个人总决赛；资格自动落实到日程。</summary>
public static class CircuitWorld
{
    public static readonly int[] LeagueDays = [10, 12, 14, 16, 18];
    public static string TeamName(CareerData d, WorldCompetition c, string team) => c.Kind == "worldcup" ? team : EsportsWorld.ClubName(d, team);
    public static int RoundCount(WorldCompetition c) => c.Kind == "league" ? Math.Max(5, c.Fixtures.Select(f => f.Round).DefaultIfEmpty(5).Max()) : c.Kind == "worldfinal" ? 5 : c.Kind == "worldcup" ? 3 : 4;
    public static string RoundName(WorldCompetition c, int round) => c.Kind == "league" ? $"第 {round} 轮" : (1 << (RoundCount(c) - round + 1)) switch
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
        CircuitLedger.SeasonStart(d);
        CircuitPeople.SeasonChange(d);
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
                : d.People.Where(p => p.ClubId == team && EsportsWorld.IsProfessional(p))
                    .OrderByDescending(p => p.Rating + CareerEngine.StableHash(d.WorldId + p.Id + d.Season) % 180)
                    .Take(d.CooperativeMembers > 1 ? d.CooperativeMembers : 3).Select(p => p.Id).ToList();
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
        for (int offset = 0; offset < length; offset += 14)
        {
            if (offset + 3 <= length) Add(offset + 3, "local", offset == 0 ? "街区周末杯" : "社区周末公开杯", 0, 45, p => p.Role == "普通玩家");
            if (offset + 6 <= length) Add(offset + 6, "city", "城市新秀公开赛", 3, 100, p => p.Role == "青训选手");
            if (offset + 9 <= length) Add(offset + 9, "academy", "职业青训选拔赛", 6, 180, p => p.Role == "青训选手");
            if (offset + 11 <= length) Add(offset + 11, "open", "赛区巡回公开赛", 7, 190, EsportsWorld.IsProfessional);
        }
        Add(length, "masters", "世界纪录邀请赛", 10, 1200, p => p.MaxAscension >= 9);
        d.Matches = d.Matches.OrderBy(m => m.Day).ToList();
    }
    public static void EnrollLeague(CareerData d, WorldCompetition c)
    {
        if (c.PlayerEntered || !c.Rosters.TryGetValue(d.Esports.ClubId, out var roster)) return;
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
    private static int DayOf(WorldCompetition c, int round) => c.CalendarDays == 84 ? c.CalendarStart + (c.Kind == "worldfinal" ? 63 + round * 4 : 64 + round * 4)
        : (c.Season - 1) * 28 + (c.Kind == "worldfinal" ? 17 + round * 2 : 18 + round * 2);
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
            if (d.Matches.Any(m => m.FixtureId == f.Id)) continue;
            d.Matches.Add(new() { CompetitionId = c.Id, FixtureId = f.Id, Round = f.Round, Day = f.Day, Kind = c.Kind,
                Event = c.Name + " · " + RoundName(c, f.Round), OpponentId = f.HomeId == "player" ? f.AwayId : f.HomeId,
                RequiredAscension = f.Ascension, Prize = c.Kind == "league" ? 260 : c.Kind == "worldfinal" ? c.PrizeVersion >= 1 ? 0 : 600 + f.Round * 200 : 400 + f.Round * 180,
                Registered = true, Seed = $"NS-{d.WorldId}-{f.Id}" });
        }
        d.Matches = d.Matches.OrderBy(m => m.Day).ToList();
    }
    public static void AdvanceCompetition(CareerData d, WorldCompetition c, int day, bool publish)
    {
        if (c.Finished) return;
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
            var winners = c.TeamEvent ? today.GroupBy(f => (f.HomeTeam, f.AwayTeam))
                .Select(g => g.Count(f => f.WinnerId == f.HomeId) > g.Count(f => f.WinnerId == f.AwayId) ? g.Key.HomeTeam : g.Key.AwayTeam).ToList()
                : today.Select(f => f.WinnerId).ToList();
            if (winners.Count > 1)
            {
                AddRound(c, winners, today[0].Round + 1); SchedulePlayer(d, c); return;
            }
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
        var qualified = leagues.SelectMany(c => EsportsWorld.Ranked(c).Take(2).Select(t => t.PersonId)).Distinct().ToList();
        string previousChampion = d.Esports.CircuitAwards.LastOrDefault(a => a.Kind == "worldfinal" && a.Place == "冠军")?.PersonId ?? "";
        if (previousChampion.Length > 0 && (previousChampion == "player" ? leagues.Any(c => c.PlayerEntered) : CareerEngine.Person(d, previousChampion) is { } defending && EsportsWorld.IsProfessional(defending))) qualified.Add(previousChampion);
        qualified = qualified.Distinct().ToList();
        var candidates = leagues.SelectMany(c => c.Table).OrderByDescending(t => CircuitLedger.Points(d, t.PersonId))
            .ThenByDescending(t => t.Wins).ThenByDescending(t => EsportsWorld.RatingOf(d, t.PersonId)).Select(t => t.PersonId);
        qualified.AddRange(candidates.Where(id => !qualified.Contains(id)).Take(32 - qualified.Count));
        var final = new WorldCompetition { Id = $"worldfinal-{d.Season}", Kind = "worldfinal", Name = "世界总决赛", Country = "国际", Season = d.Season,
            CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1, Entrants = qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + id)).ToList(), PlayerEntered = qualified.Contains("player") };
        bool finalSeason = d.Season % 2 == 1;
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
                    .Where(x => x.Country == league.Country && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))
                    .OrderByDescending(x => x.Table.Points).ThenByDescending(x => x.Table.Clears).Take(d.CooperativeMembers > 1 ? 1 : 3).Select(x => x.Table.PersonId).ToList();
                if (d.CooperativeMembers > 1 && selection[0] == "player")
                    selection.AddRange(OwnedClubs.Humans(d).Skip(1));
                else if (d.CooperativeMembers > 1)
                    selection.AddRange(d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending(p => p.Rating).Take(d.CooperativeMembers - 1).Select(p => p.Id));
                cup.Rosters[league.Country] = selection;
            }
            else foreach (var team in TeamTable(league).Take(2))
            { cup.Teams.Add(team.PersonId); cup.Rosters[team.PersonId] = league.Rosters[team.PersonId].ToList(); }
        }
        cup.Teams = cup.Teams.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + kind + id)).ToList();
        Snapshot(d, cup); cup.PlayerEntered = cup.Entrants.Contains("player");
        d.Esports.NationalTeam = kind == "worldcup" && cup.PlayerEntered;
        AddRound(cup, cup.Teams, 1); d.Esports.Competitions.Add(cup); SchedulePlayer(d, cup);
        if (publish) CareerEngine.Publish(d, "draw-" + d.Season, "世界大赛签表公布", (finalSeason ? "世界总决赛32位选手就位。" : "") + $"{cup.Name}公布阵容。"
            + (finalSeason && final.PlayerEntered ? $"{CareerEngine.Name(d)}取得世界总决赛席位。" : "") + (cup.PlayerEntered ? $"{CareerEngine.Name(d)}入选{(kind == "worldcup" ? d.Esports.Country : EsportsWorld.ClubName(d, d.Esports.ClubId))}首发阵容。" : ""), "国际赛事", true,
            finalSeason && final.PlayerEntered || cup.PlayerEntered ? ["player"] : []);
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
            var members = new[] { leaderId }.Concat(official).Distinct().Where(id => !d.HumanIds.Contains(id) && id != "player")
                .Select(id => CareerEngine.Person(d, id)).OfType<CareerPerson>().Take(d.CooperativeMembers).ToList();
            if (members.Count == d.CooperativeMembers) return members;
        }
        var pool = d.People.Where(p => p.Id != leaderId && !d.HumanIds.Contains(p.Id) && p.Country == leader.Country);
        if (c?.Kind is "league" or "continental" or "worldfinal") pool = pool.Where(p => p.ClubId == leader.ClubId && EsportsWorld.IsProfessional(p));
        if (c?.Kind == "worldcup") pool = pool.Where(EsportsWorld.IsProfessional);
        return new[] { leader }.Concat(pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy(p => CareerEngine.StableHash(seed + p.Id)).Take(d.CooperativeMembers - 1)).ToList();
    }
    public static void EnsureHumanRosters(CareerData d)
    {
        if (d.CooperativeMembers < 2 || d.HumanIds.Count != d.CooperativeMembers) return;
        foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && c.Cooperative && c.TeamEvent && !c.Finished))
        foreach (string team in c.Rosters.Where(pair => pair.Value.Contains("player")).Select(pair => pair.Key).ToList())
        {
            c.Rosters[team] = new[] { "player" }.Concat(d.HumanIds.Skip(1)).ToList();
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
