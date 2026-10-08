namespace NationalSpire;

public sealed class TeamPreparation
{
    public string CompetitionId { get; set; } = "";
    public string Team { get; set; } = "";
    public int Remaining { get; set; } = 3;
    public HashSet<int> CompletedRounds { get; set; } = [];
}

public static class TeamPreparations
{
    public const int Cost = 1200;
    public static IEnumerable<WorldCompetition> Available(CareerData d) => d.Esports.Competitions.Where(c => c.Season == d.Season
        && c.TeamEvent && !c.Cooperative && !c.Finished && c.Rosters.Values.Any(r => r.Contains("player"))
        && c.Fixtures.Any(f => !f.Finished && (f.HomeId == "player" || f.AwayId == "player" || c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains("player") == true || c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains("player") == true)));
    public static string? Buy(CareerData d, string competitionId)
    {
        if (MatchFailure.Locked(d) is { } locked) return locked;
        var c = Available(d).FirstOrDefault(c => c.Id == competitionId);
        if (c == null) return "当前没有可安排集体备赛的团体赛事。";
        if (d.PendingMatchId != null) return "请在当前比赛结束后安排备赛。";
        if (CareerMoney.Balance(d) < Cost) return "备赛资金不足。";
        string team = c.Rosters.First(r => r.Value.Contains("player")).Key;
        var preparation = d.TeamPreparations.FirstOrDefault(p => p.CompetitionId == c.Id && p.Team == team);
        if (preparation?.Remaining > 0) return "本届赛事的集体备赛仍在生效。";
        d.TeamPreparations.RemoveAll(p => p.CompetitionId == c.Id && p.Team == team);
        d.TeamPreparations.Add(new() { CompetitionId = c.Id, Team = team,
            CompletedRounds = c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select(g => g.Key).ToHashSet() });
        if (OwnedClubs.IsOwner(d)) OwnedClubs.Pay(d, c.Name + "集体备赛", -Cost);
        else { CareerMoney.Add(d, -Cost); CareerMoney.Record(d, c.Name + "集体备赛", -Cost); }
        return null;
    }
    public static double Bonus(CareerData d, string id, int day)
    {
        if (id == "player" || d.HumanIds.Contains(id)) return 0;
        foreach (var p in d.TeamPreparations.Where(p => p.Remaining > 0))
        {
            var c = d.Esports.Competitions.FirstOrDefault(c => c.Id == p.CompetitionId && !c.Finished);
            if (c?.Rosters.GetValueOrDefault(p.Team)?.Contains(id) != true) continue;
            if (c.Fixtures.Any(f => !f.Finished && f.Day == day && (f.HomeTeam == p.Team || f.AwayTeam == p.Team))) return .16;
        }
        return 0;
    }
    public static void Complete(CareerData d, WorldCompetition c, int day)
    {
        foreach (var p in d.TeamPreparations.Where(p => p.CompetitionId == c.Id && p.Remaining > 0))
        foreach (var round in c.Fixtures.Where(f => f.Day <= day && (f.HomeTeam == p.Team || f.AwayTeam == p.Team)).GroupBy(f => f.Round))
            if (round.All(f => f.Finished) && round.Any(f => !f.Walkover) && p.CompletedRounds.Add(round.Key)) p.Remaining--;
    }
}
