namespace NationalSpire;

/// <summary>正式赛果的国运贡献；和赛果使用同一次保存，不处理预生成成绩。</summary>
public static class NationalFortune
{
    public static bool Applies(WorldCompetition c) => c.Modern && c.FortuneVersion == 1
        && c.Kind is "continental" or "worldcup" or "worldfinal";

    public static (int Win, int Loss) Amount(string kind, int round) => kind switch
    {
        "worldfinal" => round switch { 1 => (10, 5), 2 => (20, 10), 3 => (60, 30), 4 => (120, 60), 5 => (390, 90), _ => (0, 0) },
        "continental" => round switch { 1 => (10, 5), 2 => (15, 10), 3 => (35, 20), 4 => (120, 30), _ => (0, 0) },
        "worldcup" => round switch { 1 => (30, 15), 2 => (90, 60), 3 => (240, 60), _ => (0, 0) },
        _ => (0, 0)
    };

    public static void Confirm(CareerData d, WorldCompetition c, WorldFixture f)
    {
        if (!Applies(c) || !f.Finished || f.Draw || f.FortuneSettled) return;
        var amounts = Amount(c.Kind, f.Round);
        f.FortuneSettled = true;
        // 合作队伍的一份成绩代表三席团体赛，不随真人数量重复计算。
        int seats = c.TeamEvent && c.Cooperative ? 3 : 1;
        if (!f.Walkover)
        {
            Add(d, c, f, f.HomeId, seats * (c.TeamEvent ? amounts.Loss : f.WinnerId == f.HomeId ? amounts.Win : amounts.Loss));
            Add(d, c, f, f.AwayId, seats * (c.TeamEvent ? amounts.Loss : f.WinnerId == f.AwayId ? amounts.Win : amounts.Loss));
        }
        if (!c.TeamEvent) return;
        var tie = c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam).ToList();
        if (tie.Any(x => !x.Finished || x.Draw) || tie.All(x => x.PromotionSettled)) return;
        string winner = tie.Count(x => x.WinnerId == x.HomeId) > tie.Count(x => x.WinnerId == x.AwayId) ? f.HomeTeam : f.AwayTeam;
        foreach (var game in tie)
        {
            if (game.PromotionSettled) continue;
            game.PromotionSettled = true;
            Add(d, c, game, winner == game.HomeTeam ? game.HomeId : game.AwayId, seats * (amounts.Win - amounts.Loss));
        }
    }

    private static void Add(CareerData d, WorldCompetition c, WorldFixture f, string id, int amount)
    {
        if (amount <= 0 || id.Length == 0) return;
        string country = c.EntrantCountries[id];
        var award = d.Esports.CircuitAwards.FirstOrDefault(a => a.CompetitionId == c.Id && a.PersonId == id);
        if (award == null)
        {
            award = new() { CompetitionId = c.Id, PersonId = id, Country = country, ClubId = c.EntrantClubs[id],
                Season = c.Season, Event = c.Name, Kind = c.Kind, Place = "参赛中", Completed = false };
            d.Esports.CircuitAwards.Add(award);
        }
        award.Day = d.Day; award.Fortune += amount;
        f.Fortune[id] = f.Fortune.GetValueOrDefault(id) + amount;
        var nation = d.Esports.Nations.First(n => n.Country == country);
        nation.Treasury += amount * 2;
        if (id == "player") d.Credits += amount * 20;
        f.DevelopmentChanges.AddRange(NationalDevelopment.Contribute(d, nation, amount));
    }

    public static string Impact(CareerData d, WorldCompetition c, WorldFixture f)
    {
        int amount = f.Fortune.GetValueOrDefault("player");
        string contribution = amount > 0 ? $"本场为{c.EntrantCountries["player"]}贡献{amount}国运，国家奖励{CareerMoney.Format(amount * 20)}。" : "";
        return contribution + string.Join("", f.DevelopmentChanges.Distinct());
    }
}
