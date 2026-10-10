namespace NationalSpire;

public static class CharacterDeletion
{
    internal const string MissingStarter = "请先补充一名符合首发资格的轮换或青训。";
    internal static List<CareerPerson> StarterCandidates(CareerData d, string exclude = "") => ClubCoaching.Replacements(d, exclude)
        .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement
            && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))
        .Select(id => d.People.First(p => p.Id == id)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).ToList();
    public static CareerPerson? StarterReplacement(CareerData d, string id) => NeedsReplacement(d, id) ? StarterCandidates(d, id).FirstOrDefault() : null;
    private static bool NeedsReplacement(CareerData d, string id) => d.Esports.OwnedClub is { } own
        && own.Starters.Contains(id) && own.Starters.Count <= Math.Max(3, OwnedClubs.ActiveHumans(d).Count);
    internal static bool DeletedStarterVacancy(CareerData d) => d.Esports.OwnedClub is { } own
        && own.Starters.Count < Math.Max(3, OwnedClubs.ActiveHumans(d).Count)
        && d.DeletedPeople.Values.Any(p => p.CreatedCard && p.ClubId == own.ClubId && p.ClubPosition == "首发");
    private static void Promote(CareerData d, CareerPerson person, int index)
    {
        var own = d.Esports.OwnedClub!;
        ClubCoaching.Move(d, person.Id, "首发");
        own.Starters.Remove(person.Id); own.Starters.Insert(index, person.Id);
        OwnedClubs.UpdateRosterRole(person, "首发"); CareerTraining.InvalidateForecast(d);
    }
    // 只补删除首发遗留的空位；已安排的合格替补优先，历史出场与待遇保持原样。
    internal static bool RepairStarters(CareerData d, bool updateSchedule = true)
    {
        if (!DeletedStarterVacancy(d) || d.PendingMatchId != null || d.Failure != null) return false;
        var own = d.Esports.OwnedClub!;
        int missing = Math.Max(3, OwnedClubs.ActiveHumans(d).Count) - own.Starters.Count;
        var scheduled = d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId))
            .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)
                .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Any(f => !f.Finished))
                .SelectMany(g => g.Select((f, index) => (Id: f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId, Index: index))))
            .ToList();
        var candidates = StarterCandidates(d).OrderBy(p => scheduled.Any(s => s.Id == p.Id) ? 0 : 1).ToList();
        if (candidates.Count < missing) return false;
        var replacements = new List<(WorldCompetition Competition, WorldFixture Fixture, CareerPerson Person)>();
        foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent
            && c.Kind is "league" or "continental" && c.Rosters.ContainsKey(own.ClubId)))
        foreach (var f in c.Fixtures.Where(f => !f.Finished && (f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)))
        {
            string id = f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId;
            if (!d.DeletedPeople.TryGetValue(id, out var old) || old.ClubId != own.ClubId || old.ClubPosition != "首发") continue;
            var p = candidates.FirstOrDefault(p => Available(c, f, own.ClubId, p)
                && !replacements.Any(r => r.Competition == c && r.Fixture.Round == f.Round
                    && r.Fixture.HomeTeam == f.HomeTeam && r.Fixture.AwayTeam == f.AwayTeam && r.Person.Id == p.Id));
            if (p == null) return false;
            replacements.Add((c, f, p));
        }
        foreach (var p in candidates.Take(missing))
        {
            int index = scheduled.FindIndex(s => s.Id == p.Id);
            Promote(d, p, index < 0 ? own.Starters.Count : Math.Min(scheduled[index].Index, own.Starters.Count));
        }
        foreach (var (c, f, p) in replacements)
        {
            if (f.HomeTeam == own.ClubId) f.HomeId = p.Id; else f.AwayId = p.Id;
            if (!c.Entrants.Contains(p.Id)) { c.Entrants.Add(p.Id); c.Table.Add(new() { PersonId = p.Id }); }
            c.EntrantClubs[p.Id] = own.ClubId; c.EntrantCountries[p.Id] = p.Country;
        }
        if (updateSchedule) OwnedClubSchedule.UpdateLineup(d);
        return true;
    }
    private static bool Available(WorldCompetition c, WorldFixture f, string club, CareerPerson p) => !c.Fixtures.Any(other => other.Id != f.Id
        && other.Round == f.Round && other.HomeTeam == f.HomeTeam && other.AwayTeam == f.AwayTeam
        && (other.HomeTeam == club ? other.HomeId : other.AwayId) == p.Id);
    public static string? Delete(CareerData d, string id)
    {
        var person = d.People.FirstOrDefault(p => p.Id == id);
        if (person?.CreatedCard != true || id == "player" || d.HumanIds.Contains(id)) return "只能删除自建NPC角色。";
        if (MatchFailure.Locked(d) is { } locked) return locked;
        if (d.PendingMatchId != null) return "请在当前比赛结束后删除角色。";
        var starter = StarterReplacement(d, id);
        if (NeedsReplacement(d, id) && starter == null) return MissingStarter;
        var substitutes = starter == null ? [] : StarterCandidates(d, id);
        var ownClub = d.Esports.OwnedClub;
        bool OwnedTeam(WorldCompetition c) => starter != null && c.TeamEvent && c.Kind is "league" or "continental"
            && c.Rosters.ContainsKey(ownClub!.ClubId) && person.ClubId == ownClub.ClubId;
        if (d.Esports.Competitions.Where(c => !c.Finished && OwnedTeam(c)).Any(c => c.Fixtures.Any(f => !f.Finished
            && (f.HomeId == id || f.AwayId == id) && !substitutes.Any(p => Available(c, f, ownClub!.ClubId, p))))) return MissingStarter;
        AiService.CancelPrivate(d, id);
        GroupChats.Deleted(d, id);
        d.DeletedPeople[id] = person; d.People.Remove(person);
        CoachLineups.Deleted(d, id);
        ClubCoaching.StopTraining(d, id);
        if (d.Esports.OwnedClub is { } owned)
        {
            foreach (var transfer in owned.Transfers.Where(t => !t.Arrived && t.Contract.PersonId == id))
            {
                OwnedClubs.Pay(d, "取消" + person.PublicName + "转会", transfer.Fee + transfer.Contract.Signing);
                if (EsportsWorld.Club(d, transfer.SellerId) is { } seller) seller.Budget -= transfer.Fee;
            }
            owned.Transfers.RemoveAll(t => t.Contract.PersonId == id);
            owned.Contracts.RemoveAll(t => t.PersonId == id);
            int index = owned.Starters.IndexOf(id);
            owned.Starters.Remove(id); owned.Reserves.Remove(id); owned.Youth.Remove(id); owned.Coaches.Remove(id); owned.CoachAppointments.RemoveAll(a => a.PersonId == id); owned.HumanPayDue.Remove(id);
            if (starter != null) Promote(d, starter, index);
        }
        var box = PrivateMessages.Mailbox(d);
        if (box.LastPerson == id) box.LastPerson = "";
        box.Conversations.Remove(id); box.Relations.Remove(id);
        foreach (var a in d.Life.Activities)
        {
            a.TrainingTargets.Remove(id);
            if (a.PersonId == id && a.Status is "可安排" or "进行中") { a.Status = "已取消"; a.Result = "角色已删除。"; }
        }
        CircuitPeople.Replenish(d);
        foreach (var c in d.Esports.Competitions.Where(c => !c.Finished && (c.Entrants.Contains(id) || c.Rosters.Values.Any(r => r.Contains(id))
            || c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id)))))
        {
            var replacement = OwnedTeam(c) ? starter : Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))
                .OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).FirstOrDefault();
            string substitute = replacement?.Id ?? id;
            if (replacement != null)
            {
                foreach (var roster in c.Rosters.Values) for (int i = 0; i < roster.Count; i++) if (roster[i] == id) roster[i] = substitute;
                c.EntrantCountries[substitute] = replacement.Country; c.EntrantClubs[substitute] = replacement.ClubId;
                if (!c.Entrants.Contains(substitute)) c.Entrants.Add(substitute);
                if (!c.Table.Any(t => t.PersonId == substitute)) c.Table.Add(new() { PersonId = substitute });
                foreach (var f in c.Fixtures.Where(f => !f.Finished))
                {
                    if (f.HomeId != id && f.AwayId != id) continue;
                    string next = OwnedTeam(c) ? substitutes.First(p => Available(c, f, ownClub!.ClubId, p)).Id : substitute;
                    if (f.HomeId == id) f.HomeId = next; else f.AwayId = next;
                    if (OwnedTeam(c))
                    {
                        if (!c.Entrants.Contains(next)) { c.Entrants.Add(next); c.Table.Add(new() { PersonId = next }); }
                        c.EntrantCountries[next] = EsportsWorld.CountryOf(d, next); c.EntrantClubs[next] = EsportsWorld.ClubOf(d, next);
                    }
                }
            }
            foreach (var m in d.Matches.Where(m => m.CompetitionId == c.Id && m.OpponentId == id && m.Status == "待赛"))
            { m.OpponentId = substitute; m.OpponentPrepared = false; m.OpponentSeconds = null; m.Live = null; if (replacement == null) { m.Status = "轮空"; m.Registered = false; } }
        }
        foreach (var m in d.Matches.Where(m => m.OpponentId == id && m.Status == "待赛" && m.CompetitionId.Length == 0))
        {
            var replacement = PrivateAppointments.IsPrivate(m) ? null : Candidates(d, new() { Kind = m.Kind }, person).OrderByDescending(p => p.Rating).FirstOrDefault();
            if (replacement == null) { m.Status = "已取消"; m.Registered = false; }
            else { m.OpponentId = replacement.Id; m.OpponentPrepared = false; m.OpponentSeconds = null; m.Live = null; }
        }
        CircuitPeople.Replenish(d);
        if (starter != null) OwnedClubSchedule.UpdateLineup(d);
        return null;
    }
    private static IEnumerable<CareerPerson> Candidates(CareerData d, WorldCompetition c, CareerPerson old)
    {
        var pool = d.People.Where(p => !d.HumanIds.Contains(p.Id));
        return c.Kind switch
        {
            "league" or "continental" => pool.Where(p => p.ClubId == old.ClubId && EsportsWorld.IsProfessional(p)),
            "worldcup" => pool.Where(p => p.Country == old.Country && EsportsWorld.IsProfessional(p)),
            "worldfinal" or "masters" => pool.Where(p => p.MaxAscension >= 9 && EsportsWorld.IsProfessional(p)),
            "local" => pool.Where(p => p.Country == old.Country && p.Role == "普通玩家"),
            "city" or "academy" => pool.Where(p => p.Country == old.Country && p.Role == "青训选手"),
            _ => pool.Where(p => p.Country == old.Country && EsportsWorld.IsProfessional(p))
        };
    }
}
