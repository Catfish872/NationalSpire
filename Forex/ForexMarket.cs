namespace ForexSpire;

/// <summary>零宿主依赖的每日结算。正常调用必须逐日提供真实事实。</summary>
public static class ForexMarket
{
    public static void Initialize(ForexState state, int day, IEnumerable<ForexFixture> baseline, string worldId = "")
    {
        state.Account ??= new();
        state.Account.Positions ??= [];
        state.Prices ??= [];
        state.Candles ??= [];
        state.Records ??= [];
        state.SettledFixtures ??= [];
        state.SignalledRounds ??= [];
        foreach (var pair in ForexRules.Pairs)
        {
            if (!state.Prices.TryGetValue(pair.Id, out double price) || !double.IsFinite(price) || price <= 0)
                state.Prices[pair.Id] = pair.Initial;
            if (!state.Candles.TryGetValue(pair.Id, out var history) || history == null)
                state.Candles[pair.Id] = history = [];
            if (history.Count == 0) history.Add(state.Prices[pair.Id]);
        }
        ForexHistory.Ensure(state, day, worldId);
        if (state.Initialized) return;
        foreach (var fixture in baseline) state.SettledFixtures.Add(fixture.Key);
        state.LastDay = day;
        state.Initialized = true;
    }

    public static Dictionary<string, double> ConsumeSignals(ForexState state, IEnumerable<ForexFixture> fixtures, int day)
    {
        var bulls = new Dictionary<string, double>();
        foreach (var fixture in fixtures)
        {
            if (!ForexMath.IsInternational(fixture.Kind) || fixture.Round < 1 ||
                fixture.Round > ForexMath.LastRoundOf(fixture.Kind) || fixture.Key.Length == 0 ||
                fixture.HomeCountry.Length == 0 || fixture.AwayCountry.Length == 0) continue;
            if (!state.SettledFixtures.Add(fixture.Key)) continue;
            int lastRound = ForexMath.LastRoundOf(fixture.Kind);
            var round = new CompRoundEvent
            {
                Round = fixture.Round,
                Results = [(fixture.HomeCountry, fixture.HomeWon, fixture.HomeWon && fixture.Round == lastRound),
                    (fixture.AwayCountry, !fixture.HomeWon, !fixture.HomeWon && fixture.Round == lastRound)]
            };
            var changes = ForexCore.Aggregate([round], lastRound);
            foreach (var (country, signal) in changes)
                bulls[country] = bulls.GetValueOrDefault(country) + signal;
            string detail = string.Join("、", changes.Select(c => c.Key + " " + c.Value.ToString("+0.##;-0.##;0", System.Globalization.CultureInfo.InvariantCulture)));
            state.Record(day, "signal", fixture.Competition + " · 第" + fixture.Round + "轮：" + (detail.Length > 0 ? detail : "国家信号相互抵消"));
        }
        return bulls;
    }

    public static bool Advance(ForexState state, ForexDay facts)
    {
        if (!state.Initialized) throw new InvalidOperationException("外汇尚未初始化。");
        if (facts.Day <= state.LastDay) return false;
        if (facts.Day != state.LastDay + 1)
            throw new InvalidOperationException("外汇日期与生涯日期不连续，不能使用今天的赛果补算历史。");
        var bulls = ConsumeSignals(state, facts.Fixtures, facts.Day);
        foreach (var pair in ForexRules.Pairs)
        {
            double open = state.Prices[pair.Id];
            var rng = new ForexRandom(Seed(facts.WorldId, facts.Day, facts.Season, pair.Id));
            double z = rng.Gaussian();
            double shock = ForexMath.FatTail(rng.NextDouble(), rng.NextDouble(), rng.NextDouble(),
                ForexRules.FatTailChance, ForexRules.FatTailMin, ForexRules.FatTailMax, ForexRules.DailySigma, ForexRules.FatTailCap);
            double signal = ForexCore.SignalFor(bulls, pair.Country, ForexRules.BaseCountry, ForexRules.SignalNetCap, ForexRules.SignalUnit);
            double close = ForexCore.StepPrice(open, pair.Initial,
                ForexMath.ClampDrift(facts.Drift.GetValueOrDefault(pair.Id), ForexRules.DriftCap),
                signal, ForexRules.DailySigma, z, shock, ForexRules.MeanReversion);
            if (!double.IsFinite(close)) throw new InvalidOperationException("汇率超出有效范围。");
            state.Prices[pair.Id] = close;
            var history = state.Candles[pair.Id];
            history.Add(close);
            if (history.Count > ForexState.MaxCandles) history.RemoveRange(0, history.Count - ForexState.MaxCandles);
            ForexHistory.Append(state, pair, facts, open, close);
        }
        SettleAccount(state, facts.Day);
        state.LastDay = facts.Day;
        state.Record(facts.Day, "daily", "7 条货币对已收盘 · 持仓 " + state.Account.Positions.Count + " 笔");
        return true;
    }

    public static void SettleAccount(ForexState state, int day)
    {
        if (state.Account.Loan is { Owed: > 0 } loan)
        {
            double before = loan.Owed;
            loan.Owed = ForexMath.AccrueInterest(loan.Owed, loan.DailyRate);
            state.Record(day, "interest", "借款日计息", loan.Owed - before);
        }
        for (int i = state.Account.Positions.Count - 1; i >= 0; i--)
        {
            var pos = state.Account.Positions[i];
            double price = state.Prices.GetValueOrDefault(pos.Pair, pos.Entry);
            if (!pos.IsLiquidatable(price)) continue;
            double payout = Math.Max(0, pos.Equity(price));
            state.Account.Cash += payout;
            state.Account.Positions.RemoveAt(i);
            state.Record(day, "liquidation", pos.Pair + " " + (pos.Dir > 0 ? "多" : "空") + " " + pos.Leverage + "× 已强平", payout - pos.Margin);
        }
    }

    public static ulong Seed(string worldId, int day, int season, string pair)
    {
        unchecked
        {
            ulong h = 14695981039346656037UL;
            foreach (char c in $"{worldId}:{day}:{pair}") { h ^= c; h *= 1099511628211UL; }
            uint seasonHash = 2166136261;
            foreach (char c in season.ToString(System.Globalization.CultureInfo.InvariantCulture)) { seasonHash ^= c; seasonHash *= 16777619; }
            return h ^ (seasonHash & 0x7fffffff);
        }
    }
}

internal sealed class ForexRandom(ulong seed)
{
    private ulong _state = seed == 0 ? 88172645463325252UL : seed;
    public double NextDouble()
    {
        ulong x = _state; x ^= x << 13; x ^= x >> 7; x ^= x << 17; _state = x;
        return (x >> 11) * (1.0 / 9007199254740992.0);
    }
    public double Gaussian() => Math.Sqrt(-2 * Math.Log(Math.Max(NextDouble(), 1e-12))) * Math.Cos(2 * Math.PI * NextDouble());
}

