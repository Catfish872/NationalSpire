namespace NationalSpire;

/// <summary>开赛前重排受影响赛区的联赛；开赛后的参赛地区变更留到下赛季执行。</summary>
public static class OwnedClubSchedule
{
    public static void Join(CareerData d, string? previousRegion = null)
    {
        if (!OwnedClubs.CanJoinThisSeason(d)) throw new InvalidOperationException("联赛已经开始，不能创建俱乐部。");
        var own = d.Esports.OwnedClub!;
        var old = EsportsWorld.PlayerLeague(d) ?? throw new InvalidOperationException("本季联赛不存在。");
        own.PreviousLeague = old;
        own.PreviousMatches = System.Text.Json.JsonSerializer.Deserialize<List<CareerMatch>>(System.Text.Json.JsonSerializer.Serialize(d.Matches.Where(m => m.CompetitionId == old.Id).ToList()))!;
        Rebuild(d, new[] { old.Country, previousRegion ?? old.Country });
    }
    private static void Rebuild(CareerData d, IEnumerable<string> regions)
    {
        foreach (string region in regions.Distinct())
        {
            var old = d.Esports.Competitions.Single(c => c.Season == d.Season && c.Kind == "league" && c.Country == region);
            d.Matches.RemoveAll(m => m.CompetitionId == old.Id);
            var league = CircuitWorld.BuildLeague(d, region, $"league-{d.Season}-{region}-expanded");
            d.Esports.Competitions[d.Esports.Competitions.IndexOf(old)] = league;
        }
        CircuitWorld.EnrollLeague(d, EsportsWorld.PlayerLeague(d)!);
    }
    public static string? ChangeRegion(CareerData d, string region)
    {
        if (!OwnedClubs.IsOwner(d)) return "当前没有自建俱乐部。";
        if (!EsportsWorld.Countries.Contains(region)) return "请选择参赛地区。";
        var copy = System.Text.Json.JsonSerializer.Deserialize<CareerData>(System.Text.Json.JsonSerializer.Serialize(d))!;
        var own = copy.Esports.OwnedClub!;
        var club = EsportsWorld.Club(copy, own.ClubId)!;
        if (region == club.Country) own.NextRegion = "";
        else if (OwnedClubs.CanJoinThisSeason(copy))
        {
            string previous = club.Country;
            club.Country = region; own.NextRegion = "";
            Rebuild(copy, new[] { previous, region });
        }
        else own.NextRegion = region;
        var original = (d.Esports, d.Matches, d.Standings);
        try
        {
            d.Esports = copy.Esports; d.Matches = copy.Matches; d.Standings = copy.Standings;
            CareerStore.Save(d);
        }
        catch { (d.Esports, d.Matches, d.Standings) = original; throw; }
        return null;
    }
    public static void ApplyNextRegion(CareerData d)
    {
        if (d.Esports.OwnedClub is not { NextRegion.Length: > 0 } own) return;
        if (EsportsWorld.Club(d, own.ClubId) is { } club) club.Country = own.NextRegion;
        own.NextRegion = "";
    }
    public static List<string> OfficialRoster(CareerData d) => d.CooperativeMembers > 1
        ? new[] { "player" }.Concat(OwnedClubs.ActiveHumans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId ?? d.HumanIds.FirstOrDefault()))).ToList()
        : d.Esports.OwnedClub!.Starters.ToList();
    public static void UpdateLineup(CareerData d)
    {
        CharacterDeletion.RepairStarters(d, updateSchedule: false);
        if (CharacterDeletion.DeletedStarterVacancy(d)) return;
        var own = d.Esports.OwnedClub!;
        foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId)))
        {
            var roster = OfficialRoster(d); c.Rosters[own.ClubId] = roster;
            var changed = new HashSet<string>();
            foreach (var tie in c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)
                .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.All(f => !f.Finished) && !CircuitWorld.ActiveTie(d, g)))
            {
                int i = 0;
                foreach (var f in tie)
                {
                    string id = roster[i++];
                    if ((f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId) == id) continue;
                    if (f.HomeTeam == own.ClubId) f.HomeId = id; else f.AwayId = id;
                    changed.Add(f.Id);
                }
            }
            foreach (string id in c.Cooperative ? roster.Take(1) : roster)
            {
                if (!c.Entrants.Contains(id)) { c.Entrants.Add(id); c.Table.Add(new() { PersonId = id }); }
                c.EntrantClubs[id] = own.ClubId; c.EntrantCountries[id] = d.Esports.Country;
            }
            if (changed.Count > 0) CircuitWorld.UpdatePlayerMatches(d, c, changed);
        }
    }
}
