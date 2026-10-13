namespace ForexSpire;

/// <summary>日K的展示区间；价格与清算仍只使用实际日收盘。Synthetic只标前置模拟历史。</summary>
public sealed class ForexCandle
{
    public int Day { get; set; }
    public double Open { get; set; }
    public double High { get; set; }
    public double Low { get; set; }
    public double Close { get; set; }
    public bool Synthetic { get; set; }
}

public static class ForexHistory
{
    public const int WarmupCount = 60;

    public static ForexCandle Candle(int day, double open, double close, ForexRandomSource random, bool synthetic = false)
    {
        double wick = Math.Max(Math.Abs(close - open) * .2, Math.Max(open, close) * ForexRules.DailySigma * (.12 + random.NextDouble() * .55));
        return new() { Day = day, Open = open, Close = close,
            High = Math.Max(open, close) + wick, Low = Math.Max(.0000001, Math.Min(open, close) - wick), Synthetic = synthetic };
    }

    public static void Ensure(ForexState state, int day, string worldId)
    {
        state.Bars ??= [];
        foreach (var pair in ForexRules.Pairs)
        {
            if (state.Bars.TryGetValue(pair.Id, out var existing) && existing is { Count: > 0 }) continue;
            var closes = state.Candles[pair.Id];
            int lastDay = state.Initialized ? state.LastDay : day;
            int firstDay = lastDay - closes.Count + 1;
            var random = new ForexRandomSource(ForexMarket.Seed(worldId, firstDay, 0, pair.Id) ^ 0xC4A7D1E5UL);
            // 反向生成：最后一根的收盘严格锚定已有报价，不改账户或真实收盘序列。
            var past = new double[WarmupCount + 2];
            past[^1] = closes[0];
            for (int i = past.Length - 2; i >= 0; i--)
                past[i] = past[i + 1] * Math.Exp(-random.Gaussian() * ForexRules.DailySigma);
            var bars = new List<ForexCandle>();
            for (int i = 0; i < WarmupCount; i++)
                bars.Add(Candle(firstDay - WarmupCount + i, past[i], past[i + 1], random, true));
            for (int i = 0; i < closes.Count; i++)
                bars.Add(Candle(firstDay + i, i == 0 ? past[WarmupCount] : closes[i - 1],
                    i == closes.Count - 1 ? state.Prices[pair.Id] : closes[i], random));
            if (bars.Count > ForexState.MaxCandles) bars.RemoveRange(0, bars.Count - ForexState.MaxCandles);
            state.Bars[pair.Id] = bars;
        }
        state.ForexVersion = 3;
    }

    public static void Append(ForexState state, ForexPair pair, ForexDay facts, double open, double close)
    {
        var random = new ForexRandomSource(ForexMarket.Seed(facts.WorldId, facts.Day, facts.Season, pair.Id) ^ 0xC4A7D1E5UL);
        var bars = state.Bars[pair.Id];
        bars.Add(Candle(facts.Day, open, close, random));
        if (bars.Count > ForexState.MaxCandles) bars.RemoveRange(0, bars.Count - ForexState.MaxCandles);
    }
}

/// <summary>独立展示RNG，不消耗定价RNG；历史和影线不会改变行情或强平。</summary>
public sealed class ForexRandomSource(ulong seed)
{
    private ulong _state = seed == 0 ? 88172645463325252UL : seed;
    public double NextDouble()
    {
        ulong x = _state; x ^= x << 13; x ^= x >> 7; x ^= x << 17; _state = x;
        return (x >> 11) * (1.0 / 9007199254740992.0);
    }
    public double Gaussian() => Math.Sqrt(-2 * Math.Log(Math.Max(NextDouble(), 1e-12))) * Math.Cos(2 * Math.PI * NextDouble());
}

