namespace NationalSpire;

/// <summary>新仓共用一条数量价格曲线。预览在数值副本中逐段成交，确认后一次提交结果。</summary>
public static class MarketClearing
{
    public sealed record Closed(MarketAccount Owner, MarketPosition Position, MarketExecution.Exit Exit, string Reason);
    public sealed class Result
    {
        public required MarketQuote Quote { get; init; }
        public List<Closed> Closed { get; } = [];
        public decimal Margin { get; internal set; }
        public decimal Units { get; internal set; }
        public decimal Average { get; internal set; }
        public decimal Fee { get; internal set; }
        public bool Accepted { get; internal set; }
        public string Reason { get; internal set; } = "";
    }
    public static IReadOnlyList<MarketAccount> Accounts(CareerData d) => d.TradingAccounts?.Invoke() ?? [d.Life.Trading];
    public static MarketOrderPreview Summary(Result r) => new(r.Accepted, r.Reason, r.Margin, r.Average, r.Fee);
    public static MarketInspectionResult Inspect(CareerData d, MarketInspection request)
    {
        var buy = Preview(d, new("open", request.Asset, request.Amount, 1, request.Leverage), request.Suggest);
        var sell = Preview(d, new("open", request.Asset, request.Amount, -1, request.Leverage), request.Suggest);
        var exits = d.Life.Trading.Positions.Where(p => request.Positions.Contains(p.Id)).ToDictionary(p => p.Id, p => PreviewClose(d, p));
        return new(d.Market.Revision, MarketExecution.LiquidationValue(d.Market, d.Life.Trading, Accounts(d)), Summary(buy), Summary(sell), exits);
    }
    public static decimal Price(MarketQuote q)
        => MarketExecution.ReferencePrice(q) * (q.ClearingDepthUnits > 0 ? 1 + (q.LongUnits - q.ShortUnits) / (2 * q.ClearingDepthUnits) : 1);
    private static decimal Capacity(MarketAsset a, MarketQuote q)
        => q.ClearingDepthUnits > 0 ? q.ClearingDepthUnits : MarketExecution.Depth(a) / MarketExecution.ReferencePrice(q);
    private static decimal Average(MarketQuote q, decimal units, int direction)
        => MarketExecution.ReferencePrice(q) * (1 + (q.LongUnits - q.ShortUnits) / (2 * q.ClearingDepthUnits) + direction * units / (4 * q.ClearingDepthUnits));
    private static decimal Quantity(MarketQuote q, decimal notional, int direction)
    {
        if (notional == 0) return 0;
        decimal b = MarketExecution.ReferencePrice(q), k = q.ClearingDepthUnits;
        decimal slope = 1 + (q.LongUnits - q.ShortUnits) / (2 * k);
        decimal square = slope * slope + direction * notional / b / k;
        decimal root = (decimal)Math.Sqrt((double)square);
        for (int i = 0; i < 3; i++) root = (root + square / root) / 2;
        return 2 * (notional / b) / (slope + root);
    }
    private static decimal ExitRate(MarketAsset a) => a.Forex ? 0 : CareerMarket.FeeRate;
    public static MarketExecution.Exit Exit(MarketPosition p, MarketQuote q)
        => Exit(p, Average(q, (decimal)p.Units, -p.Direction));
    private static MarketExecution.Exit Exit(MarketPosition p, decimal average)
    {
        decimal fee = decimal.Round((decimal)p.Units * average * ExitRate(MarketCatalog.ById[p.Asset]), 4);
        decimal proceeds = Math.Max(0, decimal.Round(p.Margin + (decimal)p.Units * p.Direction * (average - p.Entry) - fee, 4));
        return new(new(p.Units, average, 0, 0, -p.Direction), fee, proceeds,
            proceeds - p.Margin - (p.OpeningFee ?? CareerMarket.OpenFee(MarketCatalog.ById[p.Asset], p.Margin, p.Leverage)));
    }
    private sealed class Slot
    {
        public readonly MarketAccount Owner;
        public readonly MarketPosition Position;
        public readonly decimal Units, Fraction, CashBasis, PriceCoefficient, AdverseCoefficient;
        public readonly bool MarginApplies;
        public bool Active = true;
        public Slot(MarketAccount owner, MarketPosition p, decimal capacity)
        {
            Owner = owner; Position = p; Units = (decimal)p.Units; Fraction = Units / (4 * capacity);
            decimal rate = ExitRate(MarketCatalog.ById[p.Asset]);
            CashBasis = p.Margin - p.Direction * Units * p.Entry;
            PriceCoefficient = Units * (p.Direction - rate); AdverseCoefficient = Units * (1 - p.Direction * rate);
            MarginApplies = MarketCatalog.ById[p.Asset].Forex || p.Direction < 0 || p.Leverage > 1;
        }
        public decimal Remaining(decimal basis, decimal longFactor, decimal shortFactor)
            => CashBasis + PriceCoefficient * basis * (Position.Direction > 0 ? longFactor + Fraction : shortFactor - Fraction);
    }
    private sealed class Work(Slot slot, string reason)
    {
        public readonly Slot Slot = slot;
        public readonly string Reason = reason;
        public decimal Remaining = slot.Units;
        public decimal Notional;
    }
    private sealed class Session
    {
        public readonly Result Result;
        private readonly List<Slot> slots;
        private readonly MarketAsset asset;
        private readonly MarketAccount previewOwner;
        private MarketQuote Q => Result.Quote;
        public Session(MarketAsset asset, MarketQuote quote, IReadOnlyList<MarketAccount> accounts)
        {
            this.asset = asset;
            previewOwner = accounts[0];
            Result = new() { Quote = quote.ExecutionCopy() };
            Q.ExecutionBase = MarketExecution.ReferencePrice(quote);
            Q.ClearingDepthUnits = Capacity(asset, quote);
            slots = accounts.SelectMany(a => a.Positions.Where(p => p.Asset == asset.Id && p.ExecutionVersion == 1).Select(p => new Slot(a, p, Q.ClearingDepthUnits))).ToList();
        }
        private (Slot? Slot, decimal Units, string Reason) Next(decimal units, int direction, bool opening)
        {
            Slot? first = null; string reason = ""; decimal earliest = units;
            decimal basis = MarketExecution.ReferencePrice(Q), price = Price(Q), slope = basis / (2 * Q.ClearingDepthUnits);
            decimal longFactor = 1 - Q.ShortUnits / (2 * Q.ClearingDepthUnits), shortFactor = 1 + Q.LongUnits / (2 * Q.ClearingDepthUnits);
            // 价格和最坏平仓剩余资金在当前成交段内均为一次函数，直接求首次触发数量。
            foreach (var slot in slots)
            {
                if (!slot.Active) continue;
                var p = slot.Position;
                if (slot.MarginApplies)
                {
                    decimal remaining = slot.Remaining(basis, longFactor, shortFactor);
                    // 开多增大空仓风险，开空增大多仓风险；平仓仅改善对向风险。
                    decimal riskSlope = opening && p.Direction == -direction
                        ? -slot.AdverseCoefficient * slope : 0;
                    decimal at = remaining <= .000000001m ? 0 : riskSlope < 0 ? -remaining / riskSlope : decimal.MaxValue;
                    if (at <= earliest) { first = slot; earliest = at; reason = "强制平仓"; }
                }
                if (p.StopPrice is { } stop)
                {
                    decimal distance = p.Direction * (price - stop);
                    decimal change = p.Direction * direction * slope;
                    decimal at = distance <= .000000000001m ? 0 : change < 0 ? -distance / change : decimal.MaxValue;
                    if (at < earliest || at == earliest && first == null) { first = slot; earliest = at; reason = "止损平仓"; }
                }
            }
            return (first, earliest, reason);
        }
        private decimal Move(decimal units, int direction, bool opening)
        {
            decimal value = units * Average(Q, units, direction);
            if (opening ? direction > 0 : direction < 0) Q.LongUnits += opening ? units : -units;
            else Q.ShortUnits += opening ? units : -units;
            Q.Price = Price(Q);
            return value;
        }
        public void Close(MarketPosition position, string reason = "平仓")
        {
            var first = slots.First(s => ReferenceEquals(s.Position, position));
            if (!first.Active) return;
            Close(first, reason);
        }
        private void Close(Slot first, string reason)
        {
            var stack = new Stack<Work>(); first.Active = false; stack.Push(new(first, reason));
            while (stack.TryPeek(out var work))
            {
                int direction = -work.Slot.Position.Direction;
                var next = Next(work.Remaining, direction, false);
                work.Notional += Move(next.Units, direction, false); work.Remaining -= next.Units;
                if (next.Slot != null)
                {
                    next.Slot.Active = false; stack.Push(new(next.Slot, next.Reason)); continue;
                }
                stack.Pop();
                var p = work.Slot.Position;
                Result.Closed.Add(new(work.Slot.Owner, p, Exit(p, work.Notional / (decimal)p.Units), work.Reason));
            }
        }
        public void Settle()
        {
            while (true)
            {
                var next = Next(0, 1, false);
                if (next.Slot == null) return;
                Close(next.Slot, next.Reason);
            }
        }
        public void Reprice(decimal target)
        {
            Settle();
            while (Q.ExecutionBase != target)
            {
                decimal start = MarketExecution.ReferencePrice(Q), end = target;
                decimal longFactor = 1 - Q.ShortUnits / (2 * Q.ClearingDepthUnits), shortFactor = 1 + Q.LongUnits / (2 * Q.ClearingDepthUnits);
                Slot? first = null; string reason = ""; decimal fraction = 1;
                foreach (var slot in slots)
                {
                    if (!slot.Active) continue;
                    var p = slot.Position;
                    if (slot.MarginApplies)
                    {
                        decimal from = slot.Remaining(start, longFactor, shortFactor), to = slot.Remaining(end, longFactor, shortFactor);
                        if (to <= 0 && to < from)
                        {
                            decimal t = Math.Max(0, from / (from - to));
                            if (t <= fraction) { first = slot; fraction = t; reason = "强制平仓"; }
                        }
                    }
                    if (p.StopPrice is { } stop)
                    {
                        decimal from = p.Direction * (Price(Q) - stop), to = p.Direction * (Price(Q) * end / start - stop);
                        if (to <= 0 && to < from)
                        {
                            decimal t = Math.Max(0, from / (from - to));
                            if (t < fraction || t == fraction && first == null) { first = slot; fraction = t; reason = "止损平仓"; }
                        }
                    }
                }
                Q.ExecutionBase = start + (end - start) * fraction; Q.Price = Price(Q);
                if (first == null) break;
                Close(first, reason);
            }
            Q.Price = Price(Q);
        }
        public void Open(decimal margin, int leverage, int direction)
        {
            decimal spent = 0, units = 0;
            // 先按可用数量限定中间计算范围，巨大输入金额仍以原值参与是否完整成交的判断。
            MarketNumber wanted = (MarketNumber)margin * leverage;
            while ((MarketNumber)spent < wanted)
            {
                decimal available = Q.ClearingDepthUnits - (direction > 0 ? Q.LongUnits : Q.ShortUnits);
                if (available <= 0) { Result.Reason = "当前可成交数量已用完"; break; }
                decimal maximum = available * Average(Q, available, direction);
                decimal budget = (decimal)(wanted - spent < maximum ? wanted - spent : maximum);
                decimal quantity = Math.Min(available, Quantity(Q, budget, direction));
                var next = Next(quantity, direction, true);
                decimal value = Move(next.Units, direction, true);
                spent += value; units += next.Units;
                if (next.Slot != null) { Close(next.Slot, next.Reason); continue; }
                if (budget == maximum && wanted - spent > .00000001m) Result.Reason = "订单超过当前可成交数量";
                break;
            }
            Result.Margin = spent / leverage; Result.Units = units; Result.Average = units > 0 ? spent / units : Price(Q);
            Result.Fee = CareerMarket.OpenFee(asset, Result.Margin, leverage);
            var p = new MarketPosition { Asset = asset.Id, Margin = Result.Margin, Entry = Result.Average, Units = units, Leverage = leverage, Direction = direction, ExecutionVersion = 1 };
            var risk = new Slot(previewOwner, p, Q.ClearingDepthUnits);
            bool viable = units > 0 && (!risk.MarginApplies || risk.Remaining(MarketExecution.ReferencePrice(Q),
                1 - Q.ShortUnits / (2 * Q.ClearingDepthUnits), 1 + Q.LongUnits / (2 * Q.ClearingDepthUnits)) > .000000001m);
            Result.Accepted = viable && MarketNumber.Max(wanted - spent, spent - wanted) <= .00000001m;
            if (!viable) Result.Reason = "这笔订单的保证金不足以覆盖当前成交和平仓成本";
        }
    }
    public static Result Preview(CareerData d, MarketOrder order, bool suggest = true)
    {
        var a = MarketCatalog.ById[order.Asset]; var accounts = Accounts(d);
        Result Run(decimal margin) { var s = new Session(a, d.Market.Quotes[a.Id], accounts); s.Open(margin, order.Leverage, order.Direction); return s.Result; }
        var result = Run(order.Amount);
        if (result.Accepted || !suggest || order.Amount <= 0) return result;
        decimal low = 0, high = Math.Min(order.Amount, result.Margin);
        string reason = result.Reason;
        decimal capacityMargin = decimal.Floor(high * 1000) / 1000;
        var capacity = Run(capacityMargin);
        if (capacity.Accepted)
        {
            capacity.Accepted = false; capacity.Reason = reason; capacity.Margin = capacityMargin;
            capacity.Fee = CareerMarket.OpenFee(a, capacityMargin, order.Leverage); return capacity;
        }
        // 按美分建议金额；每次候选均经历完整强平与止损顺序，最终提交重新使用同一入口。
        for (int i = 0; i < 48 && high - low > .0005m; i++)
        {
            decimal middle = (low + high) / 2;
            if (Run(middle).Accepted) low = middle; else high = middle;
        }
        decimal suggested = decimal.Floor(low * 1000) / 1000;
        result = Run(suggested); result.Accepted = false; result.Reason = reason;
        result.Margin = suggested; result.Fee = CareerMarket.OpenFee(a, suggested, order.Leverage);
        return result;
    }
    public static Result Close(MarketState market, IReadOnlyList<MarketAccount> accounts, MarketPosition p)
    {
        var s = new Session(MarketCatalog.ById[p.Asset], market.Quotes[p.Asset], accounts); s.Close(p); s.Result.Accepted = true; return s.Result;
    }
    public static MarketExecution.Exit PreviewClose(CareerData d, MarketPosition p)
        => p.ExecutionVersion == 0 ? MarketExecution.Close(p, d.Market.Quotes[p.Asset])
            : Close(d.Market, Accounts(d), p).Closed.Single(c => ReferenceEquals(c.Position, p)).Exit;
    public static decimal LiquidationValue(MarketState market, MarketAccount account, IReadOnlyList<MarketAccount> accounts)
    {
        var sessions = new Dictionary<string, Session>(); decimal result = account.Cash - account.Debt;
        foreach (var p in account.Positions)
        {
            if (!sessions.TryGetValue(p.Asset, out var session)) sessions[p.Asset] = session = new(MarketCatalog.ById[p.Asset], market.Quotes[p.Asset], accounts);
            if (p.ExecutionVersion == 1) session.Close(p);
            else
            {
                var q = session.Result.Quote; var exit = MarketExecution.Close(p, q);
                result += exit.Proceeds; MarketExecution.Consume(q, MarketCatalog.ById[p.Asset], exit.Fill);
            }
        }
        return result + sessions.Values.Sum(s => s.Result.Closed.Where(c => ReferenceEquals(c.Owner, account)).Sum(c => c.Exit.Proceeds));
    }
    public static void Commit(MarketState market, string asset, Result result, int day)
    {
        var q = market.Quotes[asset];
        q.ClearingDepthUnits = result.Quote.ClearingDepthUnits; q.LongUnits = result.Quote.LongUnits; q.ShortUnits = result.Quote.ShortUnits;
        q.ExecutionBase = result.Quote.ExecutionBase; q.Price = Price(q);
        foreach (var closed in result.Closed)
        {
            closed.Owner.Cash += closed.Exit.Proceeds; closed.Owner.Positions.Remove(closed.Position);
            CareerMarket.Record(closed.Owner, day, MarketCatalog.ById[asset].Name + closed.Reason + " · 成交价" + closed.Exit.Fill.Average.ToString("0.00000"), closed.Exit.Proceeds);
        }
        History(market, asset, day);
    }
    private static void History(MarketState market, string asset, int day)
    {
        var q = market.Quotes[asset];
        if (q.History.Count > 0 && q.History[^1].Day == day) q.History[^1] = new(day, q.Price); else q.History.Add(new(day, q.Price));
        if (q.History.Count > CareerMarket.HistoryDays) q.History.RemoveAt(0);
        market.Revision++;
    }
    public static void Reprice(MarketState market, string asset, IReadOnlyList<MarketAccount> accounts, int day, decimal price)
    {
        var s = new Session(MarketCatalog.ById[asset], market.Quotes[asset], accounts); s.Reprice(price);
        // 旧仓继续获得原先的每日深度刷新，新仓数量继续占用可成交数量。
        MarketExecution.Reprice(market.Quotes[asset], price);
        Commit(market, asset, s.Result, day);
    }
    public static void Settle(MarketState market, IReadOnlyList<MarketAccount> accounts, int day)
    {
        foreach (var asset in accounts.SelectMany(a => a.Positions).Where(p => p.ExecutionVersion == 1).Select(p => p.Asset).Distinct().ToArray())
        {
            var s = new Session(MarketCatalog.ById[asset], market.Quotes[asset], accounts); s.Settle();
            if (s.Result.Closed.Count > 0) Commit(market, asset, s.Result, day);
        }
    }
}
