namespace NationalSpire;

/// <summary>正式赛果的国运贡献；和赛果使用同一次保存，不处理预生成成绩。</summary>
public static class NationalFortune
{
    public static bool Applies(WorldCompetition c) => c.Modern && c.FortuneVersion == 1
        && c.Kind is "continental" or "worldcup" or "worldfinal";

    public static (int Win, int Loss) Amount(string kind, int round) => kind switch
    {
        "worldfinal" => round switch { 1 => (75, -75), 2 => (80, -80), 3 => (90, -90), 4 => (100, -100), 5 => (255, -255), _ => (0, 0) },
        "continental" => round switch { 1 => (20, -20), 2 => (35, -35), 3 => (45, -45), 4 => (80, -80), _ => (0, 0) },
        "worldcup" => round switch { 1 => (60, -60), 2 => (90, -90), 3 => (210, -210), _ => (0, 0) },
        _ => (0, 0)
    };

    public static void Confirm(CareerData d, WorldCompetition c, WorldFixture f)
    {
        if (!Applies(c) || !f.Finished || f.Draw || f.FortuneSettled) return;
        var amounts = Amount(c.Kind, f.Round);
        f.FortuneSettled = true;
        var development = new Dictionary<string, int>();
        // 合作队伍的一份成绩代表三席团体赛，不随真人数量重复计算。
        int seats = c.TeamEvent && c.Cooperative ? 3 : 1;
        if (!c.TeamEvent)
        {
            if (c.EntrantCountries[f.HomeId] == c.EntrantCountries[f.AwayId]) return;
            Add(d, c, f, f.HomeId, f.WinnerId == f.HomeId ? amounts.Win : amounts.Loss, development);
            Add(d, c, f, f.AwayId, f.WinnerId == f.AwayId ? amounts.Win : amounts.Loss, development);
            Develop(d, f, development, f.Id);
            return;
        }
        var tie = c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam).ToList();
        if (tie.Any(x => !x.Finished || x.Draw) || tie.All(x => x.PromotionSettled)) return;
        string winner = tie.Count(x => x.WinnerId == x.HomeId) > tie.Count(x => x.WinnerId == x.AwayId) ? f.HomeTeam : f.AwayTeam;
        foreach (var game in tie)
        {
            if (game.PromotionSettled) continue;
            game.PromotionSettled = true;
            if (c.EntrantCountries[game.HomeId] == c.EntrantCountries[game.AwayId]) continue;
            Add(d, c, game, game.HomeId, seats * (winner == game.HomeTeam ? amounts.Win : amounts.Loss) - game.Fortune.GetValueOrDefault(game.HomeId), development);
            Add(d, c, game, game.AwayId, seats * (winner == game.AwayTeam ? amounts.Win : amounts.Loss) - game.Fortune.GetValueOrDefault(game.AwayId), development);
        }
        Develop(d, f, development, $"{c.Id}:{f.Round}:{f.HomeTeam}:{f.AwayTeam}");
    }

    private static void Add(CareerData d, WorldCompetition c, WorldFixture f, string id, int amount, Dictionary<string, int> development)
    {
        if (amount == 0 || id.Length == 0) return;
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
        if (id == "player" && amount > 0) d.Credits += amount * 20;
        development[country] = development.GetValueOrDefault(country) + amount;
    }

    private static void Develop(CareerData d, WorldFixture fixture, Dictionary<string, int> development, string source)
    {
        foreach (var (country, amount) in development)
            if (amount != 0) fixture.DevelopmentChanges.AddRange(NationalDevelopment.Contribute(d, d.Esports.Nations.First(n => n.Country == country), amount, source));
    }

    public static string Impact(CareerData d, WorldCompetition c, WorldFixture f)
    {
        int amount = f.Fortune.GetValueOrDefault("player");
        string contribution = amount > 0 ? $"本场为{c.EntrantCountries["player"]}贡献{amount}国运，国家奖励{CareerMoney.Format(amount * 20)}。"
            : amount < 0 ? $"本场{c.EntrantCountries["player"]}国运减少{-amount}。" : "";
        return contribution + string.Join("", f.DevelopmentChanges.Distinct());
    }
}
