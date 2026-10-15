namespace NationalSpire;

/// <summary>买卖分别累计承接数量；预览、成交和强平共用相同积分公式。</summary>
public static class MarketExecution
{
    public sealed record Fill(MarketNumber Units, decimal Average, MarketNumber EndUnits, decimal EndPrice, int Direction);
    public sealed record Exit(Fill Fill, MarketNumber Fee, decimal Proceeds, decimal Profit);

    // 内部单位为十美元。规模表示初始报价附近的承接资金，不是单笔上限。
    public static decimal Depth(MarketAsset asset) => asset.Forex ? asset.Country switch
    {
        "美国" => 500_000_000_000m, "日本" => 300_000_000_000m, "英国" => 200_000_000_000m,
        "德国" or "法国" => 150_000_000_000m, "韩国" => 100_000_000_000m, _ => 50_000_000_000m
    } : 50_000_000m + CareerEngine.StableHash(asset.Id) % 150_000_001;

    private static MarketNumber Root(MarketNumber x, int degree)
    {
        if (x == 0) return 0;
        var r = MarketNumber.Parse(Math.Pow((double)x, 1.0 / degree).ToString("R", System.Globalization.CultureInfo.InvariantCulture));
        for (int i = 0; i < 4; i++) r = degree == 2 ? (r + x / r) / 2 : (2 * r + x / r / r) / 3;
        return r;
    }
    private static (decimal Basis, decimal Depth) Book(MarketAsset asset, MarketQuote q)
        => (q.ExecutionBase > 0 ? q.ExecutionBase : q.Price, q.DepthUnits > 0 ? q.DepthUnits : Depth(asset) / q.Price);
    private static MarketNumber Used(MarketQuote q, int direction)
        => direction > 0 ? q.BuyUnits ?? MarketNumber.Max(0, q.OrderUnits) : q.SellUnits ?? MarketNumber.Max(0, -q.OrderUnits);
    private static MarketNumber Shape(MarketNumber units, decimal depth, int direction)
        => direction > 0 ? 1 + units / (2 * depth) : 1 / Root(1 + 3 * units / (2 * depth), 3);

    public static Fill Open(MarketAsset asset, MarketQuote q, decimal notional, int direction)
    {
        var (b, k) = Book(asset, q); var start = Used(q, direction);
        if (notional == 0) return new(0, (decimal)(b * Shape(start, k, direction)), start, q.Price, direction);
        MarketNumber units;
        if (direction > 0)
        {
            var slope = 1 + start / (2 * k);
            units = 2 * (MarketNumber)notional / b / (Root(slope * slope + (MarketNumber)notional / b / k, 2) + slope);
        }
        else
        {
            var previous = Root(1 + 3 * start / (2 * k), 3);
            var next = Root(previous * previous + (MarketNumber)notional / b / k, 2);
            // 差的因式分解保留大额累计成交后的小额订单精度。
            units = 2 * (MarketNumber)notional / (3 * b) * (next * next + next * previous + previous * previous) / (next + previous);
        }
        var end = start + units;
        return new(units, (decimal)(notional / units), end, (decimal)(b * Shape(end, k, direction)), direction);
    }
    public static Exit Close(MarketPosition p, MarketQuote q)
    {
        var asset = MarketCatalog.ById[p.Asset]; var (b, k) = Book(asset, q);
        int direction = -p.Direction;
        var start = Used(q, direction); var end = start + p.Units;
        MarketNumber average;
        if (direction > 0) average = b * (1 + (start + end) / (4 * k));
        else
        {
            var first = Root(1 + 3 * start / (2 * k), 3);
            var last = Root(1 + 3 * end / (2 * k), 3);
            average = 1.5m * b * (last + first) / (last * last + last * first + first * first);
        }
        // 先用扩展精度完成盈亏，再将实际到账转回账户金额。超出保证金的成本止于该仓位。
        var fee = asset.Forex ? (MarketNumber)0 : MarketNumber.Round(average * p.Units * CareerMarket.FeeRate, 4);
        decimal proceeds = (decimal)MarketNumber.Round(MarketNumber.Max(0, p.Margin + p.Direction * p.Units * (average - p.Entry) - fee), 4);
        decimal openingFee = p.OpeningFee ?? CareerMarket.OpenFee(asset, p.Margin, p.Leverage);
        return new(new(p.Units, (decimal)average, end, (decimal)(b * Shape(end, k, direction)), direction), fee, proceeds, proceeds - p.Margin - openingFee);
    }
    private static void Consume(MarketQuote q, MarketAsset asset, Fill fill)
    {
        var (b, k) = Book(asset, q);
        q.BuyUnits = fill.Direction > 0 ? fill.EndUnits : Used(q, 1);
        q.SellUnits = fill.Direction < 0 ? fill.EndUnits : Used(q, -1);
        q.ExecutionBase = b; q.DepthUnits = k; q.OrderUnits = 0;
        q.Price = b;
    }
    public static void Apply(MarketState market, string asset, Fill fill, int day)
    {
        var q = market.Quotes[asset]; Consume(q, MarketCatalog.ById[asset], fill);
        if (q.History.Count > 0 && q.History[^1].Day == day) q.History[^1] = new(day, q.Price);
        else q.History.Add(new(day, q.Price));
        if (q.History.Count > CareerMarket.HistoryDays) q.History.RemoveAt(0);
        market.Revision++;
    }
    public static void Reprice(MarketQuote q, decimal price)
    {
        // 外部行情提供新的成交深度。订单推高的报价不能反过来成为下一次消息的估值基础。
        if (q.ExecutionBase > 0) q.DepthUnits *= q.ExecutionBase / price;
        q.ExecutionBase = price; q.OrderUnits = 0; q.BuyUnits = q.SellUnits = 0;
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
            var exit = Close(p, q);
            result += exit.Proceeds; Consume(q, MarketCatalog.ById[p.Asset], exit.Fill);
        }
        return result;
    }
}
