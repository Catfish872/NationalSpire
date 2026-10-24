namespace NationalSpire;

/// <summary>离队统一解除当前归属、移交自建队及更新未开打的俱乐部对阵。</summary>
public static class ClubDeparture
{
    public static string? Error(CareerData d)
    {
        if (d.Esports.ClubId.Length == 0) return "当前已是自由选手。";
        if (d.PendingMatchId != null || d.Failure != null) return "请先完成当前比赛，再退出俱乐部。";
        if (d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.Rosters.ContainsKey(d.Esports.ClubId))
            .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == d.Esports.ClubId || f.AwayTeam == d.Esports.ClubId)
                .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)))
            .Any(tie => tie.Any(f => f.Finished) && tie.Any(f => !f.Finished) || CircuitWorld.ActiveTie(d, tie)))
            return "请先完成已经开打的同组对阵，再退出俱乐部。";
        return null;
    }
    public static string? Leave(CareerData d)
    {
        if (Error(d) is { } error) return error;
        string clubId = d.Esports.ClubId;
        var club = EsportsWorld.Club(d, clubId)!;
        var humans = OwnedClubs.Humans(d).Append("player").ToHashSet();
        if (OwnedClubs.IsOwner(d))
        {
            var own = d.Esports.OwnedClub!;
            club.Fans = own.Fans;
            club.PreferredStarters = own.Starters.Where(id => !humans.Contains(id)).ToList();
            club.Transfers.AddRange(own.Transfers.Where(t => !t.Arrived));
            d.Esports.CoachTraining.AddRange(own.CoachTraining);
            club.Identity = "";
            CareerCommerce.ConfigureClub(d, club, false);
            d.Esports.OwnedClub = null;
        }
        foreach (var p in d.People.Where(p => humans.Contains(p.Id))) { p.ClubId = ""; p.ClubPosition = ""; }
        foreach (var plan in ClubCoaching.TrainingPlans(d).Where(p => p.ClubId == clubId && p.State == "进行中")) plan.State = "已取消";
        foreach (var request in d.Esports.LineupRequests.Where(r => r.ClubId == clubId && r.State == "待生效"
            && (humans.Contains(r.Actor) || humans.Contains(r.First) || humans.Contains(r.Second)))) request.State = "已取消";
        d.Esports.ClubId = ""; d.Esports.PlayerContract = null;
        CircuitPeople.Replenish(d);
        OwnedClubSchedule.RefreshClub(d, clubId);
        d.Standings = [];
        EsportsWorld.RefreshClubOffers(d);
        CareerTraining.InvalidateForecast(d);
        CareerLife.AddEvent(d, "club-left-" + Guid.NewGuid().ToString("N"), "转会", CareerEngine.Name(d) + "离开" + club.Name,
            CareerEngine.Name(d) + "离开" + club.Name + "，成为自由选手。", humans.ToList(), true);
        CareerStore.Save(d);
        return null;
    }
}
