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
        .Where(s => (s.Accepted || EsportsWorld.Club(d, s.TargetId) != null) && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0);
    public sealed record SponsorLink(string Brand, string Target, bool Club);
    public static SponsorLink[] Links(CareerData d)
    {
        bool Active(SponsorContract s) => s.Accepted && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0;
        var links = Sponsors(d).Select(s => new SponsorLink(s.Brand, s.TargetId, EsportsWorld.Club(d, s.TargetId) != null)).ToList();
        // player 是当前合作席位，提供器只返回本次参赛成员的合同。同品牌只算一份关系。
        foreach (string id in d.HumanIds.Prepend("player"))
            foreach (var sponsor in (d.MarketSponsors?.Invoke(id) ?? []).Where(Active)) links.Add(new(sponsor.Brand, id, false));
        if (d.Esports.OwnedClub is { Sponsor: { } owned } club && owned.EndDay >= d.Day) links.Add(new(owned.Brand, club.ClubId, true));
        return links.Distinct().ToArray();
    }
    public static Dictionary<string, HashSet<string>> Partners(CareerData d, SponsorLink[]? links = null)
    {
        var partners = new Dictionary<string, HashSet<string>>();
        var roster = d.People.Where(p => p.ClubId.Length > 0 && !CoachLineups.Coach(p))
            .GroupBy(p => p.ClubId).ToDictionary(g => g.Key, g => g.Select(p => p.Id).ToArray());
        foreach (var link in links ?? Links(d))
        {
            if (!partners.TryGetValue(link.Brand, out var people)) partners[link.Brand] = people = [];
            if (link.Club && d.Esports.OwnedClub is { } owned && owned.ClubId == link.Target)
                people.UnionWith(owned.Starters.Concat(owned.Reserves).Concat(owned.Youth));
            else if (link.Club && roster.TryGetValue(link.Target, out var players)) people.UnionWith(players);
            else people.Add(link.Target);
        }
        return partners;
    }
    public static double ResultSignal(WorldCompetition c, int round, bool won)
        => c.Kind is "continental" or "worldcup" or "worldfinal"
            ? won ? round == CircuitWorld.RoundCount(c) ? 3 : 1 : round >= CircuitWorld.RoundCount(c) ? 0 : -Math.Pow(.5, round - 1)
            : won ? 1 : -1;
    public static double BrandChange(string world, MarketAsset asset, double signal)
        => signal * .015 * Volatility(world, asset) / .008 * Sensitivity(world, asset.Id);
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
    public static MarketEvent[] NewsCandidates(CareerData d) => d.Market.NewsDay > 0 && d.Day - d.Market.NewsDay < 7 ? []
        : d.Market.Events.Where(e => e.Day > d.Market.NewsDay && e.Day >= d.Day - 7 && e.Day <= d.Day).TakeLast(8).ToArray();
    public static bool TryPublish(CareerData d)
    {
        var recent = NewsCandidates(d);
        if (recent.Length == 0) return false;
        var assets = recent.Select(e => e.Asset).Distinct().Where(MarketCatalog.ById.ContainsKey).Select(id => MarketCatalog.ById[id]).ToArray();
        string facts = string.Join("\n", recent.Select(e => $"第{e.Day}天：{e.Text}")) + "\n最新行情：" + string.Join("；", assets.Select(a => a.Name + " " + (a.Forex ? d.Market.Quotes[a.Id].Price.ToString("0.0000") : CareerMoney.Format(d.Market.Quotes[a.Id].Price))));
        foreach (var group in recent.Where(e => e.Competition.Length > 0).GroupBy(e => e.Competition))
        {
            var c = d.Esports.Competitions.FirstOrDefault(c => c.Id == group.Key);
            if (c != null) facts += "\n" + WorldEvents.FixtureFacts(d, c, c.Fixtures.Where(f => group.Any(e => e.Day == f.Day)));
        }
        if (assets.Any(a => a.Forex)) facts += "\n外汇报价表示1人民币兑换的外币数量；上涨表示人民币升值，下降表示人民币贬值。";
        facts += "\n围绕具体选手、俱乐部、品牌和赛事组织报道与讨论；经营消息没有对应赛事时，按经营消息报道。";
        CareerEngine.Publish(d, "market-news-" + d.Day, "赛场之外 · 品牌与汇市动态", facts, "市场动态", true, recent.Select(e => e.Person).Where(id => id.Length > 0).Distinct().ToList());
        d.Market.NewsDay = d.Day; return true;
    }
}
