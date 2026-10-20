namespace NationalSpire;

/// <summary>选手关注数与商业报价共用的数值入口。</summary>
public static class CareerAudience
{
    public static readonly (int Floor, string Name)[] Titles = [(0, "社区小有名气"), (5000, "城市赛级"), (20000, "职业新人"), (100000, "联赛主力"), (500000, "明星选手"), (2000000, "洲际级明星"), (10000000, "世界级偶像"), (50000000, "传奇")];
    public static string Title(int fans) => Titles.Last(t => fans >= t.Floor).Name;
    public static int Followers(CareerData d, string id)
    {
        if (id == "player" || id == d.LocalHumanId) return d.Fans;
        var p = CareerEngine.Person(d, id);
        if (p == null) return 0;
        return Followers(p);
    }
    public static int Followers(CareerPerson p) => p.Fans ?? (int)Math.Round(400 * Math.Exp(Math.Clamp(p.Rating - 1000, -500, 1400) / 350.0) + Math.Min(p.Titles, 10) * 1500);
    public static int MatchGain(string kind, int ascension, bool won, bool draw, bool forfeit, int floor, double multiplier = 1, int round = 1)
    {
        if (kind is "private-friendly" or "private-challenge" || forfeit) return 0;
        int basis = kind switch { "league" => 600, "continental" => 2000, "worldcup" => 3000, "worldfinal" or "masters" => 5000, _ => 150 };
        double stage = kind is "continental" or "worldcup" or "worldfinal" ? RoundMultiplier(round) : 1;
        return won ? MatchRules.Reward((int)(basis * stage), multiplier)
            : draw ? MatchRules.Reward((int)(basis * stage * .4), multiplier) : Math.Max(3, floor / 3);
    }
    public static double RoundMultiplier(int round) => round switch { <= 1 => 1, 2 => 1.5, 3 => 2, 4 => 3, _ => 4 };
    public static int ChampionGain(string kind) => kind switch { "league" => 100000, "continental" => 150000, "worldcup" => 500000, "worldfinal" => 1000000, _ => 0 };
    // 连续曲线统一用于赞助报价、当前合同展示及实际付款。
    public static double QuoteMultiplier(int fans) => Math.Pow(1 + Math.Max(0, fans) / 100000.0, .6390841180914144);
    public static double ClubMultiplier(int fans) => Math.Pow(1 + Math.Max(0, fans) / 100000.0, .662800438550683);
    public static int Quote(int original, int fans) => (int)Math.Round(original * QuoteMultiplier(fans));
    public static int PromotionGain(int fans, int price, long used) => (int)Math.Round(price / 2.0 / (1 + .5 * used));
    public static void Fixture(CareerData d, WorldCompetition c, WorldFixture f)
    {
        ClubAudience.Fixture(d, c, f);
        foreach (string id in new[] { f.HomeId, f.AwayId })
        {
            if (id == "player" || d.HumanIds.Contains(id)) continue;
            var people = c.Cooperative ? CircuitWorld.CooperativeRoster(d, c, id, f.Id) : [CareerEngine.Person(d, id)!];
            foreach (var person in people.Where(p => p != null))
                person.Fans = Followers(d, person.Id) + MatchGain(c.Kind, f.Ascension, f.WinnerId == id, f.Draw, f.Walkover, id == f.HomeId ? f.HomeFloor : f.AwayFloor, round: f.Round);
        }
    }
}
