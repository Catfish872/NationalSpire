namespace NationalSpire;

public sealed class SettlementRecord
{
    public CompetitionReview? Competition { get; set; }
    public int Season { get; set; }
    public List<SettlementStanding> Standings { get; set; } = [];
    public List<string> Honors { get; set; } = [];
    public string OpponentPerformance { get; set; } = "";
    public string Decider { get; set; } = "";
    public int Rating { get; set; }
    public int Fans { get; set; }
    public int Credits { get; set; }
}
public sealed class SettlementStanding
{
    public string Title { get; set; } = "";
    public string Value { get; set; } = "";
    public string Detail { get; set; } = "";
    public List<string> Nearby { get; set; } = [];
}

public static partial class SettlementRecords
{
    public static string InitialTab(CareerData d) => d.PendingSettlementId.Length > 0
        && d.Results.Any(r => r.MatchId == d.PendingSettlementId) ? "结算" : "首页";
    public static SettlementRecord Capture(CareerData d, CareerMatch m, int season)
    {
        var snapshot = new SettlementRecord { Season = season, Rating = d.Rating, Fans = d.Fans, Credits = d.Credits,
            OpponentPerformance = MatchRules.Performance(m.OpponentWon, m.OpponentFloor, m.OpponentSeconds)
                + (!m.OpponentWon && m.OpponentSeconds > 0 ? " · " + MatchRules.Time(m.OpponentSeconds) : ""), Decider = m.Decider };
        var c = d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId);
        if (c?.Kind == "league")
        {
            AddTable("联赛个人", EsportsWorld.Ranked(c).ToList(), "player", id => CareerEngine.DisplayName(d, id));
            string club = c.EntrantClubs.GetValueOrDefault("player", "");
            if (c.TeamEvent && club.Length > 0) AddTable("俱乐部联赛", CircuitWorld.TeamTable(c), club, id => CircuitWorld.TeamName(d, c, id));
        }
        if (c != null && c.Kind != "league")
        {
            string team = c.Rosters.FirstOrDefault(p => p.Value.Contains("player")).Key ?? "";
            var award = d.Esports.CircuitAwards.FirstOrDefault(a => a.CompetitionId == c.Id && a.PersonId == "player");
            string value;
            if (c.ChampionId == "player" || team.Length > 0 && c.ChampionTeam == team) value = "冠军";
            else if (award != null) value = award.Place;
            else if (c.TeamEvent)
            {
                var fixture = c.Fixtures.FirstOrDefault(f => f.Id == m.FixtureId);
                var tie = c.Fixtures.Where(f => fixture != null && f.Round == fixture.Round && f.HomeTeam == fixture.HomeTeam && f.AwayTeam == fixture.AwayTeam).ToList();
                int won = tie.Count(f => f.Finished && (f.HomeTeam == team && f.WinnerId == f.HomeId || f.AwayTeam == team && f.WinnerId == f.AwayId));
                int lost = tie.Count(f => f.Finished && !f.Draw && (f.HomeTeam == team && f.WinnerId == f.AwayId || f.AwayTeam == team && f.WinnerId == f.HomeId));
                value = won >= (c.Cooperative ? 1 : 2) ? m.Round >= CircuitWorld.RoundCount(c) ? "冠军" : "晋级下一轮"
                    : lost >= (c.Cooperative ? 1 : 2) ? "本轮止步" : "本轮进行中";
            }
            else value = m.PlayerWon ? "晋级下一轮" : "本轮止步";
            snapshot.Standings.Add(new() { Title = c.TeamEvent ? c.Kind == "worldcup" ? "国家队赛况" : "俱乐部赛况" : "个人淘汰赛",
                Value = value, Detail = c.Name + (team.Length > 0 ? " · " + CircuitWorld.TeamName(d, c, team) : "") });
        }
        var totals = d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > season - 4 && a.Season <= season)
            .GroupBy(a => a.PersonId).ToDictionary(g => g.Key, g => g.OrderByDescending(a => a.Points)
                .ThenByDescending(a => a.Season).Take(6).Sum(a => a.Points));
        var points = totals.Select(p => (Id: p.Key, Points: p.Value)).ToList();
        int own = totals.GetValueOrDefault("player");
        snapshot.Standings.Add(new() { Title = "世界积分", Value = own > 0 ? $"第 {points.Count(r => r.Points > own) + 1} 名" : "尚未上榜",
            Detail = own > 0 ? $"{own} 积分 · 同分并列" : "参加职业联赛和世界总决赛，积累世界积分" });
        if (c?.Kind is "worldcup" or "continental" or "worldfinal")
        {
            string nation = c.EntrantCountries.GetValueOrDefault("player", d.Esports.Country);
            var nations = EsportsWorld.Countries.Select(n => (Name: n, Points: CircuitLedger.Fortune(d, n, CircuitLedger.Year(season)))).ToList();
            int score = nations.FirstOrDefault(n => n.Name == nation).Points;
            snapshot.Standings.Add(new() { Title = "国家国运", Value = score > 0 ? $"第 {nations.Count(n => n.Points > score) + 1} 名" : "尚无国运积分",
                Detail = $"{nation} · {score} 国运 · 同分并列" });
        }
        if (c != null) snapshot.Competition = CaptureCompetition(d, m, c, season, totals);
        return snapshot;
        void AddTable(string title, List<CareerStanding> table, string id, Func<string, string> name)
        {
            int index = table.FindIndex(r => r.PersonId == id); if (index < 0) return;
            var row = table[index];
            var nearby = Enumerable.Range(Math.Max(0, Math.Min(index - 1, table.Count - 4)), Math.Min(4, table.Count));
            snapshot.Standings.Add(new() { Title = title, Value = $"第 {index + 1} 名", Detail = $"{row.Points} 分 · {row.Wins} 胜 {row.Draws} 平 {row.Losses} 负",
                Nearby = nearby.Select(i => $"{(table[i].PersonId == id ? "▸" : " ")} {i + 1:00}  {name(table[i].PersonId)} · {table[i].Points} 分").ToList() });
        }
    }
}

/// <summary>保存结算时的赛事全貌；后续日期推进不改变已展示的排名和比较起点。</summary>
public sealed class CompetitionReview
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public int CapturedDay { get; set; }
    public int? PreviousMatchDay { get; set; }
    public List<string> CompletedFixtures { get; set; } = [];
    public List<CompetitionTable> Tables { get; set; } = [];
    public List<CompetitionScore> Scores { get; set; } = [];
}
public sealed class CompetitionTable
{
    public string Id { get; set; } = "";
    public string Title { get; set; } = "";
    public string Note { get; set; } = "";
    public List<CompetitionRow> Rows { get; set; } = [];
}
public sealed class CompetitionRow
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public bool PlayerRelated { get; set; }
    public int Rank { get; set; }
    public int Points { get; set; }
    public int? PreviousRank { get; set; }
    public int? PreviousPoints { get; set; }
    public string Record { get; set; } = "";
}
public sealed class CompetitionScore
{
    public int Day { get; set; }
    public string Round { get; set; } = "";
    public string Home { get; set; } = "";
    public string Away { get; set; } = "";
    public string Score { get; set; } = "";
    public string Outcome { get; set; } = "";
    public bool PlayerRelated { get; set; }
}

public static partial class SettlementRecords
{
    private static CompetitionReview CaptureCompetition(CareerData d, CareerMatch m, WorldCompetition c, int season, Dictionary<string, int> worldPoints)
    {
        // 只比较最近一次同赛事结算；旧记录缺失时，不跨过它借用更早的比较起点。
        var previousResult = d.Results.LastOrDefault(r => r.MatchId != m.Id && r.CompetitionId == c.Id);
        var previous = previousResult?.Settlement is { } old && old.Season == season && old.Competition?.Id == c.Id ? old.Competition : null;
        string FixtureKey(WorldFixture f) => f.Id.Length > 0 ? f.Id : $"{f.Round}:{f.Day}:{f.HomeId}:{f.AwayId}";
        var done = c.Fixtures.Where(f => f.Finished).ToList();
        var review = new CompetitionReview { Id = c.Id, Name = c.Name, CapturedDay = d.Day,
            PreviousMatchDay = previous != null ? previousResult!.Day : null,
            CompletedFixtures = done.Select(FixtureKey).Distinct().ToList() };
        string team = c.Rosters.FirstOrDefault(p => p.Value.Contains("player")).Key ?? c.EntrantClubs.GetValueOrDefault("player", "");
        if (c.Kind == "league")
        {
            AddLeagueTable("personal", "选手积分榜", EsportsWorld.Ranked(c).ToList(), "player", id => CareerEngine.DisplayName(d, id));
            if (c.TeamEvent) AddLeagueTable("teams", "俱乐部积分榜", CircuitWorld.TeamTable(c), team, id => CircuitWorld.TeamName(d, c, id));
        }
        if (worldPoints.Count > 0 && c.Entrants.Append("player").Any(id => worldPoints.GetValueOrDefault(id) > 0))
        {
            // 只保存本赛事参赛者的世界名次，避免每场重复保存整个世界的选手档案。
            var table = new CompetitionTable { Id = "world", Title = "参赛选手 · 世界积分", Note = "本赛事参赛选手的世界排名 · 同分并列" };
            foreach (string id in c.Entrants.Append("player").Distinct().OrderByDescending(id => worldPoints.GetValueOrDefault(id)).ThenBy(id => id, StringComparer.Ordinal))
            {
                int points = worldPoints.GetValueOrDefault(id);
                table.Rows.Add(Row(table.Id, id, CareerEngine.DisplayName(d, id), id == "player",
                    points > 0 ? 1 + worldPoints.Values.Count(p => p > points) : 0, points, ""));
            }
            review.Tables.Add(table);
        }
        if (c.Kind is "worldcup" or "continental" or "worldfinal")
        {
            string nation = c.EntrantCountries.GetValueOrDefault("player", d.Esports.Country);
            var countries = EsportsWorld.Countries.Select(n => (Id: n, Points: CircuitLedger.Fortune(d, n, CircuitLedger.Year(season))))
                .OrderByDescending(n => n.Points).ThenBy(n => n.Id, StringComparer.Ordinal).ToList();
            var table = new CompetitionTable { Id = "nations", Title = "国家国运榜", Note = "当前年度国运 · 同分并列" };
            foreach (var n in countries) table.Rows.Add(Row(table.Id, n.Id, n.Id, n.Id == nation,
                n.Points > 0 ? 1 + countries.Count(p => p.Points > n.Points) : 0, n.Points, ""));
            review.Tables.Add(table);
        }
        var known = previous?.CompletedFixtures.ToHashSet() ?? [];
        string Round(int round) => c.Modern ? CircuitWorld.RoundName(c, round) : $"第 {round} 轮";
        if (c.TeamEvent)
        {
            foreach (var tie in c.Fixtures.GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam))
                .Where(g => g.Any(f => f.Finished && !known.Contains(FixtureKey(f)))).OrderByDescending(g => g.Max(f => f.Day)))
            {
                int home = tie.Count(f => f.Finished && !f.Draw && f.WinnerId == f.HomeId);
                int away = tie.Count(f => f.Finished && !f.Draw && f.WinnerId == f.AwayId);
                bool complete = tie.All(f => f.Finished);
                string winner = home == away ? "" : CircuitWorld.TeamName(d, c, home > away ? tie.Key.HomeTeam : tie.Key.AwayTeam);
                review.Scores.Add(new() { Day = tie.Where(f => f.Finished).Max(f => f.Day), Round = Round(tie.Key.Round),
                    Home = CircuitWorld.TeamName(d, c, tie.Key.HomeTeam), Away = CircuitWorld.TeamName(d, c, tie.Key.AwayTeam),
                    Score = $"{home} : {away}", PlayerRelated = tie.Key.HomeTeam == team || tie.Key.AwayTeam == team,
                    Outcome = !complete ? "进行中" : winner.Length == 0 ? "平局" : c.Kind == "league" ? winner + " 获胜"
                        : winner + (c.ChampionTeam == (home > away ? tie.Key.HomeTeam : tie.Key.AwayTeam) ? " 夺冠" : " 晋级") });
            }
        }
        else
        {
            foreach (var f in done.Where(f => !known.Contains(FixtureKey(f))).OrderByDescending(f => f.Day).ThenByDescending(f => f.Round))
                review.Scores.Add(new() { Day = f.Day, Round = Round(f.Round), Home = CareerEngine.DisplayName(d, f.HomeId), Away = CareerEngine.DisplayName(d, f.AwayId),
                    Score = f.Draw ? "平局" : "VS", PlayerRelated = f.HomeId == "player" || f.AwayId == "player",
                    Outcome = f.Draw ? "双方战平" : CareerEngine.DisplayName(d, f.WinnerId) + (f.Walkover ? " 获胜（对手退赛）"
                        : c.ChampionId == f.WinnerId ? " 夺冠" : c.Kind == "league" ? " 获胜" : " 晋级") });
        }
        return review;
        CompetitionRow Row(string table, string id, string name, bool own, int rank, int points, string record)
        {
            var oldRow = previous?.Tables.FirstOrDefault(t => t.Id == table)?.Rows.FirstOrDefault(r => r.Id == id);
            return new() { Id = id, Name = name, PlayerRelated = own, Rank = rank, Points = points, Record = record,
                PreviousRank = oldRow?.Rank, PreviousPoints = oldRow?.Points };
        }
        void AddLeagueTable(string id, string title, List<CareerStanding> standings, string own, Func<string, string> name)
        {
            var table = new CompetitionTable { Id = id, Title = title, Note = "积分相同时，按赛事规则排列" };
            for (int i = 0; i < standings.Count; i++)
            {
                var r = standings[i]; table.Rows.Add(Row(id, r.PersonId, name(r.PersonId), r.PersonId == own, i + 1, r.Points, $"{r.Wins}胜 {r.Draws}平 {r.Losses}负"));
            }
            review.Tables.Add(table);
        }
    }
}
