namespace NationalSpire;

/// <summary>球队自身关注和现役选手带来的关注分别计算，转会不重复发放球队关注。</summary>
public static class ClubAudience
{
    public static int Total(CareerData d, string club)
    {
        int own = d.Esports.OwnedClub?.ClubId == club ? d.Esports.OwnedClub.Fans : EsportsWorld.Club(d, club)?.Fans ?? 0;
        var players = d.People.Where(p => p.ClubId == club && !CoachLineups.Coach(p)
            && !(d.Esports.OwnedClub is { } o && o.ClubId == club && o.Coaches.Contains(p.Id) && !o.Starters.Contains(p.Id) && !o.Reserves.Contains(p.Id)))
            .Select(p => (p.Id, Fans: CareerAudience.Followers(p))).ToList();
        string human = GroupChats.Human(d);
        if (d.Esports.ClubId == club && !players.Any(p => p.Id == human)) players.Add((human, d.Fans));
        return own + (int)(players.OrderByDescending(p => p.Fans).Take(3).Sum(p => (long)p.Fans) / 5);
    }
    public static int RoundGain(string kind, int round, bool won) => (int)((won ? 2000 : 500)
        * (kind == "continental" ? 2 * CareerAudience.RoundMultiplier(round) : 1));
    public static void Fixture(CareerData d, WorldCompetition c, WorldFixture f)
    {
        if (!c.TeamEvent || c.Kind is not ("league" or "continental")) return;
        var tie = c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam).ToArray();
        if (tie.Any(x => !x.Finished || x.Draw)) return;
        foreach (string id in new[] { f.HomeTeam, f.AwayTeam })
        {
            if (id == d.Esports.OwnedClub?.ClubId || EsportsWorld.Club(d, id) is not { } club) continue;
            if (!club.AudienceReceipts.Add(c.Id + ":" + f.Round + ":" + f.HomeTeam + ":" + f.AwayTeam)) continue;
            int wins = tie.Count(x => x.WinnerId == (id == x.HomeTeam ? x.HomeId : x.AwayId));
            club.Fans += RoundGain(c.Kind, f.Round, wins > tie.Length / 2);
        }
    }
}
