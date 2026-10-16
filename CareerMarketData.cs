namespace NationalSpire;

public sealed record MarketAsset(string Id, string Name, string Country, string Sector, bool Forex, decimal Initial);
public sealed class MarketState
{
    public MarketState RevisionCopy() => (MarketState)MemberwiseClone();
    internal int CheckedQuoteCount { get; set; } = -1;
    public int PricingVersion { get; set; }
    public int CatalogVersion { get; set; }
    public int LastDay { get; set; }
    public long Revision { get; set; }
    public int NewsDay { get; set; }
    public List<MarketEvent> Events { get; set; } = [];
    public Dictionary<string, MarketQuote> Quotes { get; set; } = [];
}
public sealed class MarketQuote
{
    public decimal ClearingDepthUnits { get; set; }
    public decimal LongUnits { get; set; }
    public decimal ShortUnits { get; set; }
    public decimal ExecutionBase { get; set; }
    public decimal DepthUnits { get; set; }
    public decimal OrderUnits { get; set; }
    public MarketNumber? BuyUnits { get; set; }
    public MarketNumber? SellUnits { get; set; }
    public int SignalDay { get; set; }
    public decimal AppliedSignal { get; set; }
    public MarketQuote ExecutionCopy() => (MarketQuote)MemberwiseClone();
    public decimal Price { get; set; }
    public decimal Previous { get; set; }
    public int SyntheticThrough { get; set; } = int.MinValue;
    public decimal PendingSignal { get; set; }
    public List<MarketPoint> History { get; set; } = [];
}
public sealed record MarketPoint(int Day, decimal Price);
public sealed record MarketEvent(int Day, string Asset, string Text, double Change, string Person = "", string Competition = "");
public sealed class MarketAccount
{
    public decimal Cash { get; set; }
    public decimal Debt { get; set; }
    public int InterestDay { get; set; }
    public decimal InterestRate { get; set; } = CareerMarket.DailyInterest;
    public int NextPosition { get; set; }
    public List<MarketPosition> Positions { get; set; } = [];
    public List<MarketTrade> Trades { get; set; } = [];
}
public sealed class MarketPosition
{
    // 缺省为旧成交规则；新订单明确写入1，读档无需遍历或改写旧持仓。
    public int ExecutionVersion { get; set; }
    public decimal? InitialMargin { get; set; }
    public decimal? StopPrice { get; set; }
    public decimal? OpeningFee { get; set; }
    public int Id { get; set; }
    public string Asset { get; set; } = "";
    public decimal Entry { get; set; }
    public decimal Margin { get; set; }
    public MarketNumber Units { get; set; }
    public int Leverage { get; set; } = 1;
    public int Direction { get; set; } = 1;
}
public sealed record MarketTrade(int Day, string Text, decimal Change, decimal Balance);
public sealed record MarketOrder(string Action, string Asset = "", decimal Amount = 0, int Direction = 1, int Leverage = 1, int Position = 0, long QuoteRevision = 0, decimal? StopPrice = null);
public sealed record MarketInspection(string Asset, decimal Amount, int Leverage, int[] Positions, bool Suggest = false);
public sealed record MarketOrderPreview(bool Accepted, string Reason, decimal Margin, decimal Average, decimal Fee);
public sealed record MarketInspectionResult(long Revision, decimal Net, MarketOrderPreview Buy, MarketOrderPreview Sell, Dictionary<int, MarketExecution.Exit> Exits);

public static class MarketCatalog
{
    public static readonly IReadOnlyList<MarketAsset> Assets = Build();
    public static readonly IReadOnlyDictionary<string, MarketAsset> ById = Assets.ToDictionary(a => a.Id);
    public static readonly int Version = CareerEngine.StableHash("market-catalog:60:" + string.Join("\n", Assets.Select(a => a.Id)));
    private static List<MarketAsset> Build()
    {
        var all = new List<MarketAsset>();
        foreach (var (country, sector, brand) in RegionalOrganizations.SponsorCatalog())
            all.Add(new("brand:" + country + ":" + brand, brand, country, new[] { "训练装备", "电竞设备", "日常消费" }[sector], false,
                10 + CareerEngine.StableHash(country + brand) % 90));
        foreach (var (country, name, initial) in new (string, string, decimal)[] {
            ("日本", "日元", 20.50m), ("韩国", "韩元", 190m), ("德国", "马克", .255m), ("法国", "法郎", .855m),
            ("巴西", "雷亚尔", .82m), ("英国", "英镑", .11m), ("美国", "美元", .14m) })
            all.Add(new("forex:" + country, "人民币 / " + name, country, "外汇", true, initial));
        return all;
    }
}
