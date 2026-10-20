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
    public static void TransferArrived(CareerData d, string seller)
    {
        // 原有补员入口维持俱乐部人数；已编排的赛前签表同步采用双方到队后的名单。
        CircuitPeople.Replenish(d);
        UpdateLineup(d);
        foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league"
            && c.Rosters.ContainsKey(seller) && c.Fixtures.All(f => !f.Finished) && c.Fixtures.All(f => f.Day > d.Day)))
        {
            var old = c.Rosters[seller];
            var roster = old.Where(id => CareerEngine.Person(d, id)?.ClubId == seller).ToList();
            roster.AddRange(CoachLineups.Roster(d, seller).Where(id => !roster.Contains(id)).Take(old.Count - roster.Count));
            SetLineup(d, c, seller, roster);
        }
        foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league"
            && (c.Rosters.ContainsKey(seller) || c.Rosters.ContainsKey(d.Esports.OwnedClub!.ClubId))
            && c.Fixtures.All(f => !f.Finished && f.Day > d.Day)))
        {
            var entrants = c.Rosters.Values.SelectMany(r => c.Cooperative ? r.Take(1) : r).ToHashSet();
            c.Entrants.RemoveAll(id => !entrants.Contains(id));
            c.Table.RemoveAll(row => !entrants.Contains(row.PersonId));
            foreach (string id in entrants)
                if (!c.Table.Any(row => row.PersonId == id)) c.Table.Add(new() { PersonId = id });
            foreach (string id in c.EntrantClubs.Keys.Where(id => !c.Rosters.Values.Any(r => r.Contains(id))).ToArray())
            { c.EntrantClubs.Remove(id); c.EntrantCountries.Remove(id); }
        }
    }
    public static void UpdateLineup(CareerData d, bool playerPositionChanged = false)
    {
        CharacterDeletion.RepairStarters(d, updateSchedule: false);
        if (CharacterDeletion.DeletedStarterVacancy(d)) return;
        var own = d.Esports.OwnedClub!;
        foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId)))
        {
            SetLineup(d, c, own.ClubId, OfficialRoster(d));
            if (playerPositionChanged)
            {
                // 当季出场由实际对阵保留，尚未出场的退报名者退出个人积分统计。
                var participants = c.Fixtures.SelectMany(f => new[] { f.HomeId, f.AwayId }).Concat(c.Rosters.Values.SelectMany(r => r)).ToHashSet();
                foreach (string id in c.Entrants.Where(id => !participants.Contains(id)).ToArray())
                {
                    c.Entrants.Remove(id); c.Table.RemoveAll(row => row.PersonId == id);
                    c.EntrantClubs.Remove(id); c.EntrantCountries.Remove(id);
                }
                c.PlayerEntered = participants.Contains("player"); c.PlayerReplacedId = "";
                if (c.Kind == "league") d.Standings = c.PlayerEntered ? c.Table : [];
            }
        }
    }
    public static string PlayerPositionTiming(CareerData d)
    {
        string club = d.Esports.OwnedClub!.ClubId;
        var upcoming = d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(club))
            .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == club || f.AwayTeam == club)
                .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam))
                .Where(tie => tie.All(f => !f.Finished) && !CircuitWorld.ActiveTie(d, tie))
                .Select(tie => (Competition: c, Fixture: tie.First())))
            .OrderBy(x => x.Fixture.Day).FirstOrDefault();
        return upcoming.Competition == null ? "席位立即调整，后续俱乐部赛事按新阵容安排。"
            : "从" + PrivateAppointments.DateText(d, upcoming.Fixture.Day) + "的" + upcoming.Competition.Name + " · "
                + CircuitWorld.RoundName(upcoming.Competition, upcoming.Fixture.Round) + "起使用新阵容。已开打的整轮对阵按原名单完成。";
    }
    private static void SetLineup(CareerData d, WorldCompetition c, string club, List<string> roster)
    {
        c.Rosters[club] = roster;
        var changed = new HashSet<string>();
        foreach (var tie in c.Fixtures.Where(f => f.HomeTeam == club || f.AwayTeam == club)
            .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.All(f => !f.Finished) && !CircuitWorld.ActiveTie(d, g)))
        {
            int i = 0;
            foreach (var f in tie)
            {
                string id = roster[i++];
                if ((f.HomeTeam == club ? f.HomeId : f.AwayId) == id) continue;
                if (f.HomeTeam == club) f.HomeId = id; else f.AwayId = id;
                changed.Add(f.Id);
            }
        }
        foreach (string id in c.Cooperative ? roster.Take(1) : roster)
        {
            if (!c.Entrants.Contains(id)) { c.Entrants.Add(id); c.Table.Add(new() { PersonId = id }); }
            c.EntrantClubs[id] = club; c.EntrantCountries[id] = EsportsWorld.Club(d, club)!.Country;
        }
        if (changed.Count > 0) CircuitWorld.UpdatePlayerMatches(d, c, changed);
    }
}
