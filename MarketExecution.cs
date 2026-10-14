namespace NationalSpire;

/// <summary>连续报价的现金积分；预览、成交和强平共用，不创建虚拟挂单。</summary>
public static class MarketExecution
{
    public sealed record Fill(decimal Units, decimal Average, decimal EndUnits, decimal EndPrice);
    public sealed record Exit(Fill Fill, decimal Fee, decimal Proceeds, decimal Profit);

    // 内部单位为十美元。规模表示初始报价附近的承接资金，不是单笔上限。
    public static decimal Depth(MarketAsset asset) => asset.Forex ? asset.Country switch
    {
        "美国" => 500_000_000_000m, "日本" => 300_000_000_000m, "英国" => 200_000_000_000m,
        "德国" or "法国" => 150_000_000_000m, "韩国" => 100_000_000_000m, _ => 50_000_000_000m
    } : 50_000_000m + CareerEngine.StableHash(asset.Id) % 150_000_001;

    private static decimal Root(decimal x, int degree)
    {
        if (x == 0) return 0;
        decimal r = (decimal)Math.Pow((double)x, 1.0 / degree);
        for (int i = 0; i < 4; i++) r = degree == 2 ? (r + x / r) / 2 : (2 * r + x / r / r) / 3;
        return r;
    }
    private static (decimal Basis, decimal Depth) Book(MarketAsset asset, MarketQuote q)
        => (q.ExecutionBase > 0 ? q.ExecutionBase : q.Price, q.DepthUnits > 0 ? q.DepthUnits : Depth(asset) / q.Price);

    // 净买入数量 u 对应价格：u>=0 时线性增加；u<0 时按立方根倒数下降，始终为正。
    private static decimal Shape(decimal u, decimal k) => u >= 0 ? 1 + u / (2 * k) : 1 / Root(1 - 3 * u / (2 * k), 3);
    private static decimal Cash(decimal u, decimal b, decimal k)
    {
        if (u >= 0) return b * u * (1 + u / (4 * k));
        decimal r = Root(1 - 3 * u / (2 * k), 3);
        return b * k * (1 - r * r);
    }
    private static decimal Quantity(decimal cash, decimal b, decimal k)
    {
        if (cash >= 0) return 2 * cash / b / (Root(1 + cash / b / k, 2) + 1);
        decimal x = 1 - cash / b / k;
        return 2 * k / 3 * (1 - x * Root(x, 2));
    }
    public static Fill Open(MarketAsset asset, MarketQuote q, decimal notional, int direction)
    {
        var (b, k) = Book(asset, q);
        if (notional == 0) return new(0, q.Price, q.OrderUnits, q.Price);
        decimal end = Quantity(Cash(q.OrderUnits, b, k) + direction * notional, b, k);
        decimal units = Math.Abs(end - q.OrderUnits);
        return new(units, notional / units, end, b * Shape(end, k));
    }
    public static Exit Close(MarketPosition p, MarketQuote q)
    {
        var asset = MarketCatalog.ById[p.Asset]; var (b, k) = Book(asset, q);
        decimal end = q.OrderUnits - p.Direction * p.Units;
        decimal notional = Math.Abs(Cash(end, b, k) - Cash(q.OrderUnits, b, k));
        decimal average = p.Units == 0 ? q.Price : notional / p.Units;
        decimal fee = asset.Forex ? 0 : decimal.Round(notional * CareerMarket.FeeRate, 4);
        decimal proceeds = decimal.Round(Math.Max(0, p.Margin + p.Direction * p.Units * (average - p.Entry) - fee), 4);
        decimal openingFee = p.OpeningFee ?? CareerMarket.OpenFee(asset, p.Margin, p.Leverage);
        return new(new(p.Units, average, end, b * Shape(end, k)), fee, proceeds, proceeds - p.Margin - openingFee);
    }
    public static void Apply(MarketState market, string asset, Fill fill, int day)
    {
        var q = market.Quotes[asset]; var (b, k) = Book(MarketCatalog.ById[asset], q);
        q.ExecutionBase = b; q.DepthUnits = k; q.OrderUnits = fill.EndUnits;
        q.Price = fill.EndPrice;
        if (q.History.Count > 0 && q.History[^1].Day == day) q.History[^1] = new(day, q.Price);
        else q.History.Add(new(day, q.Price));
        if (q.History.Count > CareerMarket.HistoryDays) q.History.RemoveAt(0);
        market.Revision++;
    }
    public static void Reprice(MarketQuote q, decimal price)
    {
        // 外部行情提供新的成交深度。订单推高的报价不能反过来成为下一次消息的估值基础。
        if (q.ExecutionBase > 0) q.DepthUnits *= q.ExecutionBase / price;
        q.ExecutionBase = price; q.OrderUnits = 0;
        q.Price = price;
    }
    public static decimal ReferencePrice(MarketQuote q) => q.ExecutionBase > 0 ? q.ExecutionBase : q.Price;
    public static decimal LiquidationValue(MarketState market, MarketAccount account)
    {
        // 按持仓顺序计算连续平仓，避免把每笔都按第一笔的成交条件相加。
        var quotes = new Dictionary<string, MarketQuote>(); decimal result = account.Cash - account.Debt;
        foreach (var p in account.Positions)
        {
            if (!quotes.TryGetValue(p.Asset, out var q)) quotes[p.Asset] = q = market.Quotes[p.Asset].ExecutionCopy();
            var exit = Close(p, q); var (b, k) = Book(MarketCatalog.ById[p.Asset], q);
            result += exit.Proceeds; q.ExecutionBase = b; q.DepthUnits = k; q.OrderUnits = exit.Fill.EndUnits; q.Price = exit.Fill.EndPrice;
        }
        return result;
    }
}
