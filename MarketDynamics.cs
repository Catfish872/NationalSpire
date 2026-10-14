namespace NationalSpire;

/// <summary>同一生涯的品牌特征固定；随机变化仅由生涯、交易日和资产编号决定。</summary>
public static class MarketDynamics
{
    public static double Gaussian(Random random) => Math.Sqrt(-2 * Math.Log(1 - random.NextDouble())) * Math.Cos(2 * Math.PI * random.NextDouble());
    public static double Volatility(string world, MarketAsset asset)
    {
        if (asset.Forex) return .008;
        double individual = CareerEngine.StableHash(world + ":volatility:" + asset.Id) % 10001 / 10000.0;
        return asset.Sector switch { "训练装备" => .012 + individual * .013, "电竞设备" => .014 + individual * .016, _ => .009 + individual * .009 };
    }
    public static double Sensitivity(string world, string id) => .7 + (CareerEngine.StableHash(world + ":sensitivity:" + id) % 10001) / 10000.0 * .6;
    public static double Shock(Random random, double sigma)
    {
        double trigger = random.NextDouble(), magnitude = random.NextDouble(), sign = random.NextDouble();
        return trigger < .02 ? Math.Clamp((sign < .5 ? -1 : 1) * (1.5 + 2 * magnitude) * sigma, -.028, .028) : 0;
    }
    public static double Noise(string world, int day, MarketAsset asset, Random random)
    {
        if (asset.Forex) return Gaussian(random);
        double country = Gaussian(new Random(CareerEngine.StableHash($"{world}:country:{day}:{asset.Country}")));
        double sector = Gaussian(new Random(CareerEngine.StableHash($"{world}:sector:{day}:{asset.Sector}")));
        return .3 * country + .4 * sector + Math.Sqrt(.75) * Gaussian(random);
    }
    public static IEnumerable<SponsorContract> Sponsors(CareerData d) => d.Esports.Sponsors
        .Where(s => s.Accepted && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0);
    public static Dictionary<string, HashSet<string>> Partners(CareerData d)
    {
        var partners = new Dictionary<string, HashSet<string>>();
        var roster = d.People.Where(p => p.ClubId.Length > 0 && !CoachLineups.Coach(p))
            .GroupBy(p => p.ClubId).ToDictionary(g => g.Key, g => g.Select(p => p.Id).ToArray());
        void Add(string brand, string id)
        {
            if (!partners.TryGetValue(brand, out var people)) partners[brand] = people = [];
            if (roster.TryGetValue(id, out var players)) people.UnionWith(players);
            else people.Add(id);
        }
        foreach (var sponsor in Sponsors(d)) Add(sponsor.Brand, sponsor.TargetId);
        foreach (var sponsor in (d.MarketSponsors?.Invoke("player") ?? []).Where(s => s.Accepted && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0)) Add(sponsor.Brand, "player");
        foreach (string human in d.HumanIds)
            foreach (var sponsor in (d.MarketSponsors?.Invoke(human) ?? []).Where(s => s.Accepted && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0)) Add(sponsor.Brand, human);
        if (d.Esports.OwnedClub is { Sponsor: { } owned } club && owned.EndDay >= d.Day)
        {
            foreach (string id in club.Starters.Concat(club.Reserves).Concat(club.Youth).Distinct()) Add(owned.Brand, id);
        }
        return partners;
    }
    public static Dictionary<string, decimal> Anchors(CareerData d)
    {
        var partners = Partners(d);
        var fans = d.People.ToDictionary(p => p.Id, CareerAudience.Followers);
        fans[GroupChats.Human(d)] = d.Fans;
        var countries = d.Esports.Nations.ToDictionary(n => n.Country);
        return MarketCatalog.Assets.ToDictionary(a => a.Id, a =>
        {
            if (a.Forex) return a.Initial;
            double levels = 5;
            if (countries.TryGetValue(a.Country, out var country))
                levels = a.Sector switch {
                    "训练装备" => (NationalDevelopment.Level(country, "industry") + NationalDevelopment.Level(country, "infrastructure")) / 2.0,
                    "电竞设备" => NationalDevelopment.Level(country, "services"),
                    _ => (NationalDevelopment.Level(country, "income") + NationalDevelopment.Level(country, "services")) / 2.0 };
            double followers = partners.GetValueOrDefault(a.Name)?.Sum(id => (double)fans.GetValueOrDefault(id)) ?? 0;
            return a.Initial * (decimal)(Math.Pow(1.02, levels - 5) * Math.Pow(1 + followers / 100000, .1));
        });
    }
    public static void AddEvent(CareerData d, MarketEvent value)
    {
        d.Market.Events.Add(value);
        if (d.Market.Events.Count > 240) d.Market.Events.RemoveRange(0, d.Market.Events.Count - 240);
    }
    public static bool TryPublish(CareerData d)
    {
        if (d.Market.NewsDay == d.Day) return false;
        var recent = d.Market.Events.Where(e => e.Day > d.Market.NewsDay && e.Day <= d.Day).TakeLast(8).ToArray();
        if (recent.Length == 0) return false;
        var assets = recent.Select(e => e.Asset).Distinct().Where(MarketCatalog.ById.ContainsKey).Select(id => MarketCatalog.ById[id]);
        string facts = string.Join("\n", recent.Select(e => $"第{e.Day}天：{e.Text}")) + "\n最新行情：" + string.Join("；", assets.Select(a => a.Name + " " + (a.Forex ? d.Market.Quotes[a.Id].Price.ToString("0.0000") : CareerMoney.Format(d.Market.Quotes[a.Id].Price))));
        if (assets.Any(a => a.Forex)) facts += "\n外汇报价表示1人民币兑换的外币数量；上涨表示人民币升值，下降表示人民币贬值。";
        CareerEngine.Publish(d, "market-news-" + d.Day, "赛场之外 · 品牌与汇市动态", facts, "市场动态", true, recent.Select(e => e.Person).Where(id => id.Length > 0).Distinct().ToList());
        d.Market.NewsDay = d.Day; return true;
    }
}
