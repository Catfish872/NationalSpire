namespace NationalSpire;

public static class CharacterDeletion
{
    public static string? Delete(CareerData d, string id)
    {
        var person = d.People.FirstOrDefault(p => p.Id == id);
        if (person?.CreatedCard != true || id == "player" || d.HumanIds.Contains(id)) return "只能删除自建NPC角色。";
        if (MatchFailure.Locked(d) is { } locked) return locked;
        if (d.PendingMatchId != null) return "请在当前比赛结束后删除角色。";
        AiService.CancelPrivate(d, id);
        d.DeletedPeople[id] = person; d.People.Remove(person);
        CoachLineups.Deleted(d, id);
        if (d.Esports.OwnedClub is { } owned)
        {
            foreach (var transfer in owned.Transfers.Where(t => !t.Arrived && t.Contract.PersonId == id))
            {
                OwnedClubs.Pay(d, "取消" + person.PublicName + "转会", transfer.Fee + transfer.Contract.Signing);
                if (EsportsWorld.Club(d, transfer.SellerId) is { } seller) seller.Budget -= transfer.Fee;
            }
            owned.Transfers.RemoveAll(t => t.Contract.PersonId == id);
            owned.Contracts.RemoveAll(t => t.PersonId == id);
            owned.Starters.Remove(id); owned.Reserves.Remove(id); owned.Youth.Remove(id); owned.Coaches.Remove(id); owned.CoachAppointments.RemoveAll(a => a.PersonId == id); ClubCoaching.StopTraining(d, id); owned.HumanPayDue.Remove(id);
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
            var replacement = Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))
                .OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).FirstOrDefault();
            string substitute = replacement?.Id ?? id;
            if (replacement != null)
            {
                foreach (var roster in c.Rosters.Values) for (int i = 0; i < roster.Count; i++) if (roster[i] == id) roster[i] = substitute;
                c.EntrantCountries[substitute] = replacement.Country; c.EntrantClubs[substitute] = replacement.ClubId;
                if (!c.Entrants.Contains(substitute)) c.Entrants.Add(substitute);
                if (!c.Table.Any(t => t.PersonId == substitute)) c.Table.Add(new() { PersonId = substitute });
                foreach (var f in c.Fixtures.Where(f => !f.Finished))
                { if (f.HomeId == id) f.HomeId = substitute; if (f.AwayId == id) f.AwayId = substitute; }
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
