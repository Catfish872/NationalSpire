namespace NationalSpire;

/// <summary>每场固定解说组合，同赛区优先轮换；保存人选后，继续比赛沿用原组合。</summary>
public static class CommentatorSelection
{
    public static HashSet<string> Participants(CareerData data, CareerMatch match, IEnumerable<string>? opponents = null)
    {
        var ids = data.HumanIds.Append("player").Append(match.OpponentId).Concat(opponents ?? []).ToHashSet();
        var competition = data.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId);
        var fixture = competition?.Fixtures.FirstOrDefault(f => f.Id == match.FixtureId);
        if (competition != null && fixture != null)
        {
            ids.Add(fixture.HomeId); ids.Add(fixture.AwayId);
            if (competition.TeamEvent)
                foreach (string team in new[] { fixture.HomeTeam, fixture.AwayTeam })
                    if (competition.Rosters.TryGetValue(team, out var roster)) ids.UnionWith(roster);
        }
        if (data.CooperativeMembers > 1)
            ids.UnionWith(CircuitWorld.CooperativeRoster(data, competition, match.OpponentId, match.Seed).Select(p => p.Id));
        return ids;
    }
    public static IReadOnlyList<CareerPerson> ForMatch(CareerData data, CareerMatch match, IEnumerable<string>? opponents = null)
    {
        var participants = Participants(data, match, opponents);
        var all = data.People.Where(p => !participants.Contains(p.Id) && (p.Role == "解说员" || p.Identities.Contains("解说员"))).ToList();
        var saved = match.CommentatorIds.Select(id => all.FirstOrDefault(p => p.Id == id)).OfType<CareerPerson>().DistinctBy(p => p.Id).Take(2).ToList();
        if (saved.Count == 2) return saved;
        var local = all.Where(p => p.Country == data.Esports.Country).ToList();
        var pool = local.Count >= 2 ? local : local.Concat(all.Except(local)).ToList();
        var history = data.Matches.Where(m => m.Id != match.Id && m.Day <= match.Day && m.CommentatorIds.Count > 0).ToList();
        var previous = history.OrderByDescending(m => m.Day).FirstOrDefault()?.CommentatorIds ?? [];
        var chosen = saved.Concat(pool.Where(p => !saved.Contains(p)).OrderBy(p => local.Contains(p) ? 0 : 1)
            .ThenBy(p => previous.Contains(p.Id) ? 1 : 0)
            .ThenBy(p => history.Count(m => m.CommentatorIds.Contains(p.Id)))
            .ThenBy(p => CareerEngine.StableHash(data.WorldId + match.Id + p.Id))).Take(2).ToList();
        match.CommentatorIds = chosen.Select(p => p.Id).ToList();
        return chosen;
    }
}
