namespace NationalSpire;

/// <summary>修复重复报名遗留的当前联赛，保留已经实际完成的比赛及奖励。</summary>
internal static class LeagueRosterRepair
{
    internal static bool Affected(CareerData d, WorldCompetition c) => c.Modern && c.Kind == "league"
        && c.Season == d.Season && !c.Finished && c.PlayerEntered && c.PlayerReplacedId.Length > 0
        && c.Rosters.TryGetValue(d.Esports.ClubId, out var roster) && roster.Contains("player")
        && (c.Entrants.Count(id => id == "player") > 1 || c.Table.Count(t => t.PersonId == "player") > 1
            || c.Fixtures.Where(f => f.HomeTeam == d.Esports.ClubId || f.AwayTeam == d.Esports.ClubId)
                .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Any(g => g.Count(f => f.HomeId == "player" || f.AwayId == "player") > 1)
            || d.Matches.Any(m => m.CompetitionId == c.Id && c.Fixtures.Any(f => f.Id == m.FixtureId && f.HomeId != "player" && f.AwayId != "player")));

    internal static bool Apply(CareerData d, WorldCompetition c)
    {
        if (!Affected(d, c)) return false;
        string club = d.Esports.ClubId, displaced = c.PlayerReplacedId;
        var roster = c.Rosters[club];
        bool rosterChanged = roster.Count(id => id == "player") > 1;
        if (rosterChanged)
        {
            if (d.Esports.OwnedClub?.ClubId == club) c.Rosters[club] = roster = OwnedClubSchedule.OfficialRoster(d);
            else roster[roster.IndexOf("player")] = displaced;
        }
        var changed = new HashSet<string>();
        bool deferred = false;
        var matches = d.Matches.Where(m => m.CompetitionId == c.Id).ToDictionary(m => m.FixtureId);
        var results = d.Results.ToDictionary(r => r.MatchId);
        foreach (var tie in c.Fixtures.Where(f => f.HomeTeam == club || f.AwayTeam == club)
            .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)))
        {
            if (CircuitWorld.ActiveTie(d, tie)) { deferred = true; continue; }
            // 以正式战报确认历史出场者，不能用今天的阵容改写已经打完的比赛。
            foreach (var f in tie.Where(f => f.Finished))
            {
                if (!matches.TryGetValue(f.Id, out var m) || !results.TryGetValue(m.Id, out var r)) continue;
                bool home = f.HomeTeam == club;
                if ((home ? f.HomeId : f.AwayId) == "player") continue;
                if (home)
                {
                    f.HomeId = "player"; f.HomeCleared = r.Win; f.HomeFloor = r.Floor; f.HomeSeconds = r.RunSeconds;
                    f.AwayCleared = m.OpponentWon; f.AwayFloor = m.OpponentFloor; f.AwaySeconds = m.OpponentSeconds;
                    f.HomeParticipants = r.PlayerParticipants.Count > 0 ? r.PlayerParticipants.ToList() : ["player"];
                }
                else
                {
                    f.AwayId = "player"; f.AwayCleared = r.Win; f.AwayFloor = r.Floor; f.AwaySeconds = r.RunSeconds;
                    f.HomeCleared = m.OpponentWon; f.HomeFloor = m.OpponentFloor; f.HomeSeconds = m.OpponentSeconds;
                    f.AwayParticipants = r.PlayerParticipants.Count > 0 ? r.PlayerParticipants.ToList() : ["player"];
                }
                changed.Add(f.Id);
            }
            var used = tie.Where(f => f.Finished).Select(f => f.HomeTeam == club ? f.HomeId : f.AwayId).ToHashSet();
            int i = 0;
            foreach (var f in tie)
            {
                string id = roster[i++];
                if (f.Finished) continue;
                if (used.Contains(id)) id = roster.First(person => !used.Contains(person));
                used.Add(id);
                if (matches.TryGetValue(f.Id, out var scheduled) && scheduled.Status == "待赛"
                    && (id != "player" || scheduled.OpponentId != (f.HomeTeam == club ? f.AwayId : f.HomeId))) changed.Add(f.Id);
                if ((f.HomeTeam == club ? f.HomeId : f.AwayId) == id) continue;
                if (f.HomeTeam == club) f.HomeId = id; else f.AwayId = id;
                changed.Add(f.Id);
            }
        }
        if (deferred && !rosterChanged && changed.Count == 0 && c.Entrants.Distinct().Count() == c.Entrants.Count
            && c.Table.Select(t => t.PersonId).Distinct().Count() == c.Table.Count) return false;
        c.Entrants = c.Entrants.Concat(c.Cooperative ? roster.Take(1) : roster).Distinct().ToList();
        foreach (string id in roster)
        {
            c.EntrantClubs[id] = club;
            c.EntrantCountries[id] = EsportsWorld.CountryOf(d, id);
        }
        c.Table = c.Entrants.Select(id => new CareerStanding { PersonId = id }).ToList();
        foreach (var f in c.Fixtures.Where(f => f.Finished))
        foreach (var row in c.Table.Where(t => t.PersonId == f.HomeId || t.PersonId == f.AwayId))
        {
            if (row.PersonId == f.HomeId ? f.HomeCleared : f.AwayCleared) row.Clears++;
            if (f.Draw) { row.Draws++; row.Points++; }
            else if (row.PersonId == f.WinnerId) { row.Wins++; row.Points += 3; }
            else row.Losses++;
        }
        if (!deferred) c.PlayerReplacedId = "";
        d.Standings = c.Table;
        CircuitWorld.UpdatePlayerMatches(d, c, changed);
        return true;
    }
}
