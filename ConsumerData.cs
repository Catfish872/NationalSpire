namespace NationalSpire;

public sealed record ConsumerOrder(string Verb, List<string> Guests);

/// <summary>消费品存档状态。只存玩家侧数据；NPC 粉丝在 CareerPerson.Fans。</summary>
public sealed class ConsumerState
{
    /// <summary>已持有：耐用品、一次性消费品、体验票根。一次性品 Consumed 后只留记录。</summary>
    public List<OwnedGood> Goods { get; set; } = [];
    /// <summary>条目 → 最近一次购买的游戏日；一次性品每赛季 1 次，体验类 28 天冷却。</summary>
    public Dictionary<string, int> BoughtDay { get; set; } = [];
    /// <summary>运营类本季已买次数：id → 次数（每项每赛季最多 3 次）。</summary>
    public Dictionary<string, int> PromoUsed { get; set; } = [];
    public int Season { get; set; }
    /// <summary>本季被邀请过的人 → 次数：第一次 +Favor，之后只 +1。</summary>
    public Dictionary<string, int> InvitedThisSeason { get; set; } = [];
    public long LifetimeSpent { get; set; }
    public int PurchaseCount { get; set; }
    public int PartyCount { get; set; }
}

public sealed class OwnedGood
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public int BoughtDay { get; set; }
    public int Season { get; set; }
    public int Price { get; set; }
    public bool Durable { get; set; }
    /// <summary>一次性消费品。</summary>
    public bool Consumed { get; set; }
    /// <summary>本季已用过的动词 id；换季清空，所以每件道具每种活动每季各 1 次。</summary>
    public List<string> UsedVerbs { get; set; } = [];
    public int UsedSeason { get; set; }
}

/// <summary>耐用品活动：Slots 为邀请人数，Favor 为首次邀请的好感变化。</summary>
public sealed record GoodVerb(string Id, string Name, int Slots, int Favor);

/// <summary>商品 Price 为显示美元金额；只有宣发活动增加关注，普通消费产生社区事件。</summary>
public sealed record Good(string Id, string Tier, string Category, string Name, int Price, GoodVerb[] Verbs, bool Repeatable = false, bool Promo = false, int Slots = 0)
{
    public bool Durable => Verbs.Length > 0;
}

/// <summary>消费品目录：四档+ 运营；分类用于商城二级菜单。</summary>
public static class ConsumerCatalog
{
    public const string Mass = "大众", Middle = "中产", Rich = "富裕", Luxury = "顶奢", Promo = "运营";
    public static readonly string[] TierOrder = [Mass, Middle, Rich, Luxury, Promo];
    public const int PromoPerSeason = 3;      // 运营每项每赛季 3 次
    public const int RepeatCooldown = 28;     // 体验类冷却 = 游戏内一个月

    public static readonly Good[] All = Build();
    public static Good? Get(string id) => All.FirstOrDefault(g => g.Id == id);
    public static IEnumerable<Good> InTier(string tier) => All.Where(g => g.Tier == tier);
    public static IEnumerable<string> Categories(string tier) => All.Where(g => g.Tier == tier).Select(g => g.Category).Distinct();

    private static Good[] Build()
    {
        var list = new List<Good>();
        void Item(string tier, string category, string id, string name, int price, bool repeatable = false, bool promo = false, int slots = 0)
            => list.Add(new(id, tier, category, name, price, [], repeatable, promo, slots));
        void Wear(string tier, string category, string id, string name, int price, params GoodVerb[] verbs)
            => list.Add(new(id, tier, category, name, price, verbs));

        // ── 大众 $10–$10,000：超市套路，能写就能买 ──
        Item(Mass, "零食甜品", "icecream", "街角甜筒", 20);
        Item(Mass, "零食甜品", "milktea", "限定奶茶", 30);
        Item(Mass, "零食甜品", "cake", "生日蛋糕", 120);
        Item(Mass, "零食甜品", "coffee", "手冲咖啡豆", 150);
        Item(Mass, "零食甜品", "hotpot", "请客火锅", 300, slots: 3);
        Item(Mass, "数码", "mouse", "电竞鼠标", 900);
        Item(Mass, "数码", "keyboard", "机械键盘", 2_000);
        Item(Mass, "数码", "earbuds", "降噪耳机", 2_500);
        Item(Mass, "数码", "console", "家用主机", 3_000);
        Item(Mass, "数码", "monitor", "高刷显示器", 3_500);
        Item(Mass, "数码", "watch", "智能手表", 4_000);
        Item(Mass, "数码", "phone", "旗舰手机", 6_000);
        Item(Mass, "数码", "projector", "家用投影", 7_000);
        Item(Mass, "数码", "camera", "专业相机", 8_000);
        Item(Mass, "数码", "laptop", "高性能笔记本", 9_500);
        Item(Mass, "穿戴", "sunglasses", "设计师墨镜", 1_800);
        Item(Mass, "穿戴", "jacket", "户外冲锋衣", 2_200);
        Item(Mass, "穿戴", "sneakers", "限量球鞋", 2_800);
        Item(Mass, "穿戴", "suit", "定制西服", 9_000);
        Item(Mass, "家居", "plant", "桌边绿植", 200);
        Item(Mass, "家居", "lamp", "暖光台灯", 400);
        Item(Mass, "家居", "chair", "可调节工作椅", 2_400);
        Item(Mass, "家居", "bedding", "高档床品", 2_600);
        Item(Mass, "家居", "airpurifier", "静音空气净化器", 3_200);
        Item(Mass, "家居", "coffeemachine", "高级咖啡机", 5_000);
        Item(Mass, "娱乐", "movie", "包场看电影", 600, slots: 3);
        Item(Mass, "娱乐", "gameroom", "游戏厅通宵", 800, slots: 3);
        Item(Mass, "娱乐", "karaoke", "KTV 包厢", 1_000, slots: 3);
        Item(Mass, "娱乐", "theatre", "小剧场包场", 1_200, slots: 3);
        Item(Mass, "娱乐", "concert", "演唱会门票", 1_500, slots: 3);
        Item(Mass, "收藏", "magazine", "创刊号杂志", 700);
        Item(Mass, "收藏", "poster", "限量签名海报", 1_600);
        Item(Mass, "收藏", "figure", "纪念手办", 3_600);
        Item(Mass, "收藏", "jersey", "亲签球衣", 4_500);

        // ── 中产 $30,000–$100,000：无 party 功能的耐用品 + 可每月重复的体验 ──
        Item(Middle, "出行", "ebike", "高端电助力车", 30_000);
        Item(Middle, "出行", "car", "私家车", 45_000);
        Item(Middle, "穿戴", "luxwatch", "高级腕表", 60_000);
        Item(Middle, "数码", "cinema", "家庭影院", 90_000);
        Item(Middle, "居住", "apartment", "小公寓首付", 80_000);
        Item(Middle, "居住", "studio", "独立工作室", 100_000);
        Item(Middle, "健康", "coach", "私教课包", 50_000);
        Item(Middle, "旅行", "spa", "温泉度假", 30_000, repeatable: true, slots: 3);
        Item(Middle, "旅行", "foodtour", "美食巡礼", 35_000, repeatable: true, slots: 3);
        Item(Middle, "旅行", "ski", "滑雪季卡", 40_000, repeatable: true);
        Item(Middle, "旅行", "beach", "海岛度假", 70_000, repeatable: true, slots: 3);

        // ── 富裕 $300,000–$1,000,000：耐用品带动词，每种活动每季各 1 次 ──
        Item(Rich, "旅行", "luxtravel", "超级奢侈旅游", 300_000, repeatable: true, slots: 3);   // 娱乐：可带 3 人，每月一次
        Wear(Rich, "出行", "suv", "硬派越野车", 350_000,
            new("camp", "露营同行", 4, 10), new("offroad", "越野体验", 2, 10), new("convoy", "车队巡游", 6, 10));
        Wear(Rich, "收藏", "cellar", "私人酒窖", 350_000,
            new("tasting", "品酒会", 6, 10), new("auction", "小型拍卖夜", 6, 10), new("gift", "赠酒", 1, 10));
        Wear(Rich, "娱乐", "theater", "私人影音室", 400_000,
            new("premiere", "首映观影会", 6, 10), new("marathon", "通宵影展", 4, 10), new("review", "复盘放映", 6, 10));
        Wear(Rich, "出行", "sportscar", "跑车", 500_000,
            new("drive", "载一人兜风", 1, 10), new("show", "车友聚会", 6, 10), new("roadtrip", "自驾远行", 2, 10));
        Wear(Rich, "居住", "villa", "独栋别墅", 800_000,
            new("party", "办一场 party", 6, 10), new("dinner", "家宴", 6, 10), new("openhouse", "开放日", 6, 10));
        Wear(Rich, "居住", "penthouse", "顶层公寓", 1_000_000,
            new("party", "楼顶 party", 6, 10), new("view", "夜景小聚", 4, 10), new("brunch", "周末早午餐", 6, 10));

        // ── 顶奢 $2,000,000+：名誉收藏（同构、规格更高）──
        Wear(Luxury, "居住", "estate", "庄园", 2_500_000,
            new("party", "庄园宴会", 6, 12), new("garden", "花园茶会", 6, 12), new("open", "庄园开放日", 6, 12));
        Wear(Luxury, "收藏", "art", "当代艺术收藏", 3_000_000,
            new("preview", "私人预展", 6, 12), new("salon", "艺术沙龙", 6, 12), new("loan", "出借展出", 1, 12));
        Wear(Luxury, "出行", "yacht", "大型游艇", 6_000_000,
            new("sail", "出海", 6, 12), new("dinner", "海上晚宴", 6, 12), new("regatta", "帆船观摩", 6, 12));
        Wear(Luxury, "居住", "island", "私人岛屿", 20_000_000,
            new("feast", "岛宴", 6, 15), new("retreat", "闭门集训营", 6, 15), new("festival", "岛上音乐节", 6, 15));

        // ── 运营：每项每赛季 3 次，价格固定不递增 ──
        Item(Promo, "热搜", "hotsearch", "买热搜", 50_000, promo: true);
        Item(Promo, "热搜", "fandom", "粉丝团运营", 30_000, promo: true);
        Item(Promo, "推广", "promo", "推广投放", 120_000, promo: true);
        Item(Promo, "推广", "interview", "专访投放", 250_000, promo: true);
        return list.ToArray();
    }
}
