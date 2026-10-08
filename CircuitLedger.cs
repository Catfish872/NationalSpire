namespace NationalSpire;

/// <summary>赛事积分、国家贡献和商业合同统一由已确认的比赛结果结算。</summary>
public static class CircuitLedger
{
    public static string MatchImpact(CareerData d, CareerMatch m)
    {
        var c = d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId && c.Modern);
        if (c == null) return "";
        string text = "";
        var f = c.Fixtures.FirstOrDefault(f => f.Id == m.FixtureId);
        if (c.TeamEvent && f != null)
        {
            var tie = c.Fixtures.Where(t => t.Round == f.Round && t.HomeTeam == f.HomeTeam && t.AwayTeam == f.AwayTeam).ToList();
            text = $"{CircuitWorld.TeamName(d, c, f.HomeTeam)} {tie.Count(t => t.WinnerId == t.HomeId)}:{tie.Count(t => t.WinnerId == t.AwayId)} {CircuitWorld.TeamName(d, c, f.AwayTeam)}。";
        }
        if (c.Kind == "worldfinal") text += c.ChampionId == "player" ? $"{CareerEngine.Name(d)}成为本届世界总决赛冠军。" : m.PlayerWon ? $"{CareerEngine.Name(d)}晋级{CircuitWorld.RoundName(c, m.Round + 1)}。" : $"{CareerEngine.Name(d)}止步{CircuitWorld.RoundName(c, m.Round)}。";
        var award = d.Esports.CircuitAwards.FirstOrDefault(a => a.CompetitionId == c.Id && a.PersonId == "player");
        if (award != null) text += $"本项赛事获得{award.Points}世界积分、贡献{award.Fortune}国运。";
        return text;
    }
    public static IEnumerable<CircuitAward> Counted(CareerData d, string id) => d.Esports.CircuitAwards
        .Where(a => a.PersonId == id && a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)
        .OrderByDescending(a => a.Points).ThenByDescending(a => a.Season).Take(6);
    public static int Points(CareerData d, string id) => Counted(d, id).Sum(a => a.Points);
    public static int Year(int season) => (season - 1) / 4 + 1;
    public static int Fortune(CareerData d, string country, int? year = null) => d.Esports.CircuitAwards
        .Where(a => a.Country == country && Year(a.Season) == (year ?? Year(d.Season))).Sum(a => a.Fortune);
    public static List<(string Country, int Points)> NationTable(CareerData d) => EsportsWorld.Countries
        .Select(country => (Country: country, Points: Fortune(d, country))).OrderByDescending(x => x.Points).ThenBy(x => x.Country, StringComparer.Ordinal).ToList();
    public static string PublicStanding(CareerData d, string id, int day)
    {
        var recent = d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= day).OrderByDescending(a => a.Day).Take(2);
        return string.Join("；", recent.Select(a => $"第{a.Season}赛季{a.Event}{a.Place}，贡献{a.Fortune}国运"));
    }
    public static void Settle(CareerData d, WorldCompetition c, bool publish)
    {
        if (!c.Finished || d.Esports.CircuitAwards.Any(a => a.CompetitionId == c.Id)) return;
        OwnedClubs.SettleAchievements(d);
        int roundCount = CircuitWorld.RoundCount(c);
        foreach (string id in c.Entrants)
        {
            bool champion = c.TeamEvent ? c.Rosters[c.ChampionTeam].Contains(id) : id == c.ChampionId;
            int lastRound = c.Fixtures.Where(f => f.HomeId == id || f.AwayId == id).Select(f => f.Round).DefaultIfEmpty(1).Max();
            int rank = c.Kind == "league" ? EsportsWorld.Ranked(c).ToList().FindIndex(t => t.PersonId == id) + 1 : champion ? 1 : 1 << (roundCount - lastRound + 1);
            string place = c.Kind == "league" ? $"个人第{rank}名" : champion ? "冠军" : rank == 2 ? "亚军" : $"{rank}强";
            int points = c.Kind == "league" ? rank switch { 1 => 300, 2 => 180, <= 4 => 105, <= 8 => 54, _ => 20 }
                : c.Kind == "worldfinal" ? rank switch { 1 => 1500, 2 => 900, 4 => 525, 8 => 270, 16 => 120, _ => 50 }
                // 世界杯个人赛：小组赛止步（rank 16）也要给分，否则打进正赛却零收获。
                : c.Kind == "worldcup" ? rank switch { 1 => 900, 2 => 450, 4 => 200, 8 => 100, 16 => 40, _ => 20 } : 0;
            int fortune = c.Kind == "league" ? 0 : c.Kind == "worldfinal" ? rank switch { 1 => 600, 2 => 300, 4 => 150, 8 => 60, _ => 15 }
                : (c.Kind == "worldcup" ? 2 : 1) * (rank switch { 1 => 180, 2 => 90, 4 => 45, 8 => 30, _ => 15 });
            var award = new CircuitAward { CompetitionId = c.Id, PersonId = id, Country = c.EntrantCountries[id], ClubId = c.EntrantClubs[id],
                Season = c.Season, Day = d.Day, Event = c.Name, Kind = c.Kind, Stage = rank, Place = place, Points = points, Fortune = fortune };
            d.Esports.CircuitAwards.Add(award);
            if (champion && CareerEngine.Person(d, id) is { } person) person.Titles++;
            var nation = d.Esports.Nations.FirstOrDefault(n => n.Country == award.Country);
            if (nation != null) nation.Treasury += fortune * 2;
            if (id == "player")
            {
                int dividend = fortune * 2; d.Credits += dividend;
                int placementPrize = c.PrizeVersion >= 1 && c.Kind == "worldfinal" ? rank switch { 1 => 50000, 2 => 25000, 4 => 10000, 8 => 5000, 16 => 2000, _ => 1000 } : 0;
                d.Credits += placementPrize; d.Life.PrizeTotal += placementPrize;
                string detail = $"{CareerEngine.Name(d)}取得{c.Name}{place}，世界积分增加{points}，为{award.Country}贡献{fortune}国运，国家奖励{CareerMoney.Format(dividend)}。" + (placementPrize > 0 ? $"本届名次奖金{CareerMoney.Format(placementPrize)}。" : "");
                if (champion) EsportsWorld.Milestone(d, c.Id, c.Name + "冠军", detail, c.Kind == "worldfinal" ? 3000 : 1200, c.PrizeVersion >= 1 && c.Kind == "worldfinal" ? 0 : 1000);
                Remember(d, "award-" + c.Id, detail, ["player"]);
            }
        }
        if (c.Kind != "league")
            foreach (var country in (c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId]).Select(id => c.EntrantCountries[id]).Distinct())
            { var nation = d.Esports.Nations.FirstOrDefault(n => n.Country == country); if (nation != null) nation.Titles++; }
        if (c.ChampionTeam.Length > 0 && EsportsWorld.Club(d, c.ChampionTeam) is { } club) { club.Titles++; int teamPrize = c.Modern ? 8000 : 800; if (club.Id == d.Esports.OwnedClub?.ClubId) OwnedClubs.Pay(d, c.Name + "球队冠军奖金", teamPrize);
            else { club.Budget += teamPrize; ClubOperations.Entry(club, d.Day, c.Name + "球队冠军奖金", teamPrize); } }
        string winner = c.TeamEvent ? CircuitWorld.TeamName(d, c, c.ChampionTeam) : CareerEngine.DisplayName(d, c.ChampionId);
        string report = $"第{c.Season}赛季{c.Name}落幕，{winner}夺冠。";
        if (c.Kind != "league")
        {
            var top = NationTable(d)[0]; report += $"国运榜目前由{top.Country}领跑，贡献{top.Points}。";
        }
        Remember(d, "champion-" + c.Id, report, c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId]);
        if (publish && (c.Kind != "league" || c.Country == d.Esports.Country || c.PlayerEntered)) CareerEngine.Publish(d, "champion-" + c.Id, winner + "捧起" + c.Name + "奖杯", report, c.Kind == "league" ? "国内联赛" : "国际赛事", true,
            c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId]);
    }
    public static void Remember(CareerData d, string id, string text, List<string> people)
    {
        if (d.CommunityMemories.Any(m => m.Id == id)) return;
        d.CommunityMemories.Add(new() { Id = id, PostId = id, Day = d.Day, Kind = "fact", Text = text, People = people.ToList() });
    }
    public static void SeasonStart(CareerData d)
    {
        if (d.Esports.LastDividendSeason >= d.Season) return;
        d.Esports.LastDividendSeason = d.Season;
        if (d.Season > 1)
        {
            int previousYear = Year(d.Season - 1);
            foreach (var nation in d.Esports.Nations)
            {
                int gain = Math.Min(1500, Fortune(d, nation.Country, previousYear));
                int spending = Math.Min(nation.Treasury, gain); nation.Treasury -= spending; nation.Development += spending;
                foreach (var club in d.Esports.Clubs.Where(c => c.Country == nation.Country))
                {
                    int share = spending / d.Esports.Clubs.Count(c => c.Country == nation.Country);
                    if (club.Id == d.Esports.OwnedClub?.ClubId) OwnedClubs.Pay(d, "赛区发展支持", share);
                    else club.Budget += share;
                }
                if (spending > 0)
                {
                    var youth = d.People.Where(p => p.Country == nation.Country && p.Role == "青训选手").OrderBy(p => CareerEngine.StableHash(p.Id + d.Season)).FirstOrDefault();
                    if (youth != null) { CareerLife.Grow(d, youth, spending / 2, "national-" + d.Season); Remember(d, $"academy-grant-{nation.Country}-{d.Season}", $"{nation.Country}投入{CareerMoney.Format(spending)}国运奖金支持国内训练与青训，{youth.PublicName}获得训练计划支持。", [youth.Id]); }
                }
            }
        }
        foreach (var club in d.Esports.Clubs.Where(c => c.Id != d.Esports.OwnedClub?.ClubId))
        {
            var contract = d.Esports.Sponsors.LastOrDefault(s => s.TargetId == club.Id && s.EndSeason >= d.Season);
            if (contract == null)
            {
                contract = CreateContract(d, club.Id, club.Titles > 0 ? 2 : 1); d.Esports.Sponsors.Add(contract);
            }
            if (contract.PaidSeason < d.Season) { club.Budget += contract.Retainer; ClubOperations.Entry(club, d.Day, contract.Brand + "赞助到账", contract.Retainer); contract.PaidSeason = d.Season; }
        }
        CareerCommerce.SeasonStart(d);
    }
    private static SponsorContract CreateContract(CareerData d, string target, int tier)
    {
        string[] names = Enumerable.Range(0, 3).SelectMany(plan => RegionalOrganizations.Sponsors(EsportsWorld.Club(d, target)?.Country ?? d.Esports.Country, plan)).ToArray();
        int pick = CareerEngine.StableHash(d.WorldId + target + d.Season) % names.Length;
        int support = CareerCommerce.IdentityIndex(d, target) switch { 0 => 3200, 1 => 2000, 2 => 4200, _ => 1600 };
        return new() { Id = target + "-" + d.Season, Brand = names[pick], TargetId = target, StartSeason = d.Season, EndSeason = d.Season + 1,
            Accepted = true, SignedDay = d.Day, Retainer = tier * support, WinBonus = 0,
            Description = RegionalOrganizations.SponsorDescription(names[pick]), Slogan = RegionalOrganizations.SponsorSlogan(names[pick]) };
    }
    public static void PlayerMatch(CareerData d, CareerMatch m)
    {
        CareerCommerce.PlayerMatch(d, m);
    }
}
