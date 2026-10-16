namespace NationalSpire;

/// <summary>公共行情只生成一次；个人账户只在报价变更、日期推进和本人下单时处理。</summary>
public static class CareerMarket
{
    public const int HistoryDays = 180;
    public const decimal DailyInterest = .0003m;
    public const decimal FeeRate = .001m;
    public static bool Initialize(CareerData d)
    {
        if (d.Market.CatalogVersion == MarketCatalog.Version && d.Market.CheckedQuoteCount == d.Market.Quotes.Count) return UpgradePricing(d);
        bool changed = false;
        if (d.Market.LastDay == 0) { d.Market.LastDay = d.Day; changed = true; }
        foreach (var asset in MarketCatalog.Assets)
        {
            bool added = !d.Market.Quotes.TryGetValue(asset.Id, out var quote);
            if (added)
            {
                quote = new() { Price = asset.Initial, Previous = asset.Initial, History = [new(d.Day, asset.Initial)] };
                d.Market.Quotes[asset.Id] = quote; changed = true;
            }
            // 已完成起始曲线的存档继续使用原报价和历史；本次只为缺少行情的品牌生成曲线。
            if (!added && d.Market.CatalogVersion is not (0 or 1)) continue;
            var first = quote!.History.FirstOrDefault() ?? new MarketPoint(d.Day, quote.Price);
            int missing = Math.Max(0, 60 - quote.History.Count);
            var history = new List<MarketPoint>(); decimal price = first.Price;
            for (int day = first.Day - 1; day >= first.Day - missing; day--)
            {
                var random = new Random(CareerEngine.StableHash($"{d.WorldId}:history:{asset.Id}:{day}"));
                price *= (decimal)Math.Exp(-MarketDynamics.Gaussian(random) * MarketDynamics.Volatility(d.WorldId, asset));
                history.Add(new(day, price));
            }
            history.Reverse(); history.AddRange(quote.History); quote.History = history;
            if (missing > 0) quote.SyntheticThrough = first.Day - 1;
            if (quote.Previous == quote.Price && quote.History.Count == 60 && missing == 59) quote.Previous = quote.History[^2].Price;
        }
        changed |= d.Market.CatalogVersion != MarketCatalog.Version;
        d.Market.CatalogVersion = MarketCatalog.Version;
        d.Market.CheckedQuoteCount = d.Market.Quotes.Count;
        return UpgradePricing(d) || changed;
    }
    private static bool UpgradePricing(CareerData d)
    {
        if (d.Market.PricingVersion >= 1) return false;
        foreach (var q in d.Market.Quotes.Values)
        {
            q.SignalDay = d.Day;
            q.AppliedSignal = Math.Clamp(q.PendingSignal, -4, 4);
            if (q.AppliedSignal != 0) Price(q, d.Day, q.Price * (decimal)Math.Exp(-(double)q.AppliedSignal * .01));
        }
        d.Market.PricingVersion = 1; d.Market.Revision++;
        if (d.Market.Quotes.Values.Any(q => q.AppliedSignal != 0)) Accounts(d, d.Day);
        return true;
    }
    public static MarketNumber Equity(MarketPosition position, decimal price)
        => position.Margin + position.Direction * position.Units * (price - position.Entry);
    public static decimal Net(MarketState market, MarketAccount account)
        => MarketExecution.LiquidationValue(market, account);

    internal static void Record(MarketAccount account, int day, string text, decimal change)
    {
        account.Trades.Add(new(day, text, change, account.Cash));
        if (account.Trades.Count > 120) account.Trades.RemoveAt(0);
    }
    public static void Account(MarketState market, MarketAccount account, int day)
        => Accounts(market, [account], day);
    private static bool Forced(MarketPosition p, MarketQuote quote)
        => (MarketCatalog.ById[p.Asset].Forex || p.Direction < 0 || p.Leverage > 1)
            && MarketExecution.Close(p, quote).Proceeds <= (p.InitialMargin ?? p.Margin) * .1m;
    public static void Accounts(MarketState market, IReadOnlyList<MarketAccount> accounts, int day)
    {
        MarketClearing.Settle(market, accounts, day);
        foreach (var account in accounts)
        {
            if (account.InterestDay == 0) account.InterestDay = day;
            while (account.InterestDay < day)
            {
                decimal interest = decimal.Round(account.Debt * account.InterestRate, 4);
                account.Debt += interest; account.InterestDay++;
                if (interest > 0) Record(account, account.InterestDay, "借款利息", -interest);
            }
        }
        // 每次成交前记录全部已触发仓位，避免前一笔平仓改变报价后漏掉其他人的止损。
        var pending = new Queue<(MarketAccount Account, MarketPosition Position, bool Forced)>();
        var triggered = new HashSet<MarketPosition>();
        while (true)
        {
            foreach (var owner in accounts)
            foreach (var position in owner.Positions)
            {
                if (position.ExecutionVersion == 1) continue;
                if (triggered.Contains(position)) continue;
                var quote = market.Quotes[position.Asset]; decimal price = MarketExecution.ReferencePrice(quote);
                bool forced = Forced(position, quote);
                bool stop = position.StopPrice is { } limit && (position.Direction > 0 ? price <= limit : price >= limit);
                if ((forced || stop) && triggered.Add(position)) pending.Enqueue((owner, position, forced));
            }
            if (!pending.TryDequeue(out var item)) break;
            var (account, p, wasForced) = item;
            bool liquidated = wasForced || Forced(p, market.Quotes[p.Asset]);
            var exit = MarketExecution.Close(p, market.Quotes[p.Asset]);
            MarketExecution.Apply(market, p.Asset, exit.Fill, day);
            account.Cash += exit.Proceeds; account.Positions.Remove(p);
            Record(account, day, MarketCatalog.ById[p.Asset].Name + (liquidated ? "强制平仓" : "止损平仓") + " · 成交价" + exit.Fill.Average.ToString("0.00000"), exit.Proceeds);
        }
    }
    private static void Accounts(CareerData d, int day)
    {
        if (d.MarketAccounts != null) d.MarketAccounts(d, day);
        else if (d.CooperativeMembers <= 1) Account(d.Market, d.Life.Trading, day);
    }
    private static void Price(MarketQuote quote, int day, decimal price)
    {
        MarketExecution.Reprice(quote, Math.Max(.000001m, decimal.Round(price, 6)));
        if (quote.History.Count > 0 && quote.History[^1].Day == day) quote.History[^1] = new(day, quote.Price);
        else quote.History.Add(new(day, quote.Price));
        if (quote.History.Count > HistoryDays) quote.History.RemoveAt(0);
    }
    private static void Price(CareerData data, string asset, int day, decimal price)
    {
        var quote = data.Market.Quotes[asset];
        if (quote.ClearingDepthUnits == 0) Price(quote, day, price);
        else MarketClearing.Reprice(data.Market, asset, MarketClearing.Accounts(data), day, Math.Max(.000001m, decimal.Round(price, 6)));
    }
    public static void Advance(CareerData d)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.MarketAdvance);
        Initialize(d);
        if (d.Market.LastDay >= d.Day) { Accounts(d, d.Day); return; }
        var season = d.Esports.CircuitAwards.Where(a => a.Season == d.Season).GroupBy(a => a.Country).ToDictionary(g => g.Key, g => g.Sum(a => (double)a.Fortune));
        var total = d.Esports.CircuitAwards.GroupBy(a => a.Country).ToDictionary(g => g.Key, g => g.Sum(a => (double)a.Fortune));
        var anchors = MarketDynamics.Anchors(d);
        var brands = MarketCatalog.Assets.Where(a => !a.Forex).ToArray();
        for (int day = d.Market.LastDay + 1; day <= d.Day; day++)
        {
            var business = new Random(CareerEngine.StableHash($"{d.WorldId}:business:{day}"));
            string eventAsset = business.NextDouble() < .25 ? brands[business.Next(brands.Length)].Id : "";
            double businessChange = (business.NextDouble() < .5 ? -1 : 1) * (.005 + business.NextDouble() * .02);
            foreach (var asset in MarketCatalog.Assets)
            {
                var quote = d.Market.Quotes[asset.Id]; quote.Previous = quote.Price;
                decimal reference = MarketExecution.ReferencePrice(quote);
                var random = new Random(CareerEngine.StableHash($"{d.WorldId}:market:{day}:{asset.Id}"));
                double sigma = MarketDynamics.Volatility(d.WorldId, asset);
                double noise = MarketDynamics.Noise(d.WorldId, day, asset, random);
                double drift = asset.Forex ? Math.Clamp(.0000012 * (total.GetValueOrDefault(asset.Country) - total.GetValueOrDefault("中国"))
                    + .000003 * (season.GetValueOrDefault(asset.Country) - season.GetValueOrDefault("中国")), -.0005, .0005) : 0;
                // 两项衡量外币相对人民币走强；1 CNY 兑换的外币数量应随之下降。
                double change = -drift + sigma * noise + MarketDynamics.Shock(random, sigma)
                    - .03 * Math.Log((double)(reference / anchors[asset.Id])) + (asset.Id == eventAsset ? businessChange : 0);
                Price(d, asset.Id, day, reference * (decimal)Math.Exp(change));
                quote.PendingSignal = quote.AppliedSignal = 0; quote.SignalDay = day;
                if (asset.Id == eventAsset) MarketDynamics.AddEvent(d, new(day, asset.Id,
                    asset.Name + (businessChange > 0 ? "公布销售增长消息" : "公布供应与成本压力消息"), businessChange));
            }
            d.Market.LastDay = day; d.Market.Revision++; Accounts(d, day);
        }
        Accounts(d, d.Day);
    }
    public static void Fixture(CareerData d, WorldCompetition c, WorldFixture fixture)
    {
        if (!fixture.Finished || fixture.Draw || fixture.MarketSettled) return;
        var tie = c.TeamEvent ? c.Fixtures.Where(f => f.Round == fixture.Round && f.HomeTeam == fixture.HomeTeam && f.AwayTeam == fixture.AwayTeam).ToArray() : [fixture];
        if (tie.Any(f => !f.Finished || f.Draw) || tie.Any(f => f.MarketSettled)) return;
        foreach (var f in tie) f.MarketSettled = true;
        if (tie.All(f => f.Walkover)) return;
        Initialize(d);
        bool home = tie.Count(f => f.WinnerId == f.HomeId) > tie.Count(f => f.WinnerId == f.AwayId);
        int last = CircuitWorld.RoundCount(c);
        double elimination = fixture.Round >= last ? 0 : -Math.Pow(.5, fixture.Round - 1);
        var signals = new Dictionary<string, double>();
        var partners = MarketDynamics.Links(d).GroupBy(p => p.Brand).ToDictionary(g => g.Key, g => g.ToArray());
        var outcomes = tie.SelectMany(f => new[] { (Id: f.HomeId, Won: home), (Id: f.AwayId, Won: !home) }).Distinct().ToArray();
        foreach (var (id, won) in outcomes)
        {
            if (c.Kind is not ("worldcup" or "worldfinal")) continue;
            string nation = c.EntrantCountries.GetValueOrDefault(id) ?? CareerEngine.Person(d, id)?.Country ?? d.Esports.Country;
            double signal = won ? 1 + (fixture.Round == last ? 2 : 0) : elimination;
            signals[nation] = signals.GetValueOrDefault(nation) + signal / tie.Length;
        }
        var sponsorOutcomes = tie.SelectMany(f => SeasonCeremony.Participants(d, c, f, true)
            .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))
            .Concat(SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId)))).Distinct().ToArray();
        foreach (var asset in MarketCatalog.Assets)
        {
            var quote = d.Market.Quotes[asset.Id];
            if (asset.Forex)
            {
                double signal = signals.GetValueOrDefault(asset.Country) - signals.GetValueOrDefault("中国");
                if (quote.SignalDay != d.Day) { quote.SignalDay = d.Day; quote.PendingSignal = quote.AppliedSignal = 0; }
                quote.PendingSignal += (decimal)signal;
                decimal applied = Math.Clamp(quote.PendingSignal, -4, 4);
                decimal delta = applied - quote.AppliedSignal;
                decimal forexBefore = quote.Price;
                if (delta != 0) Price(d, asset.Id, d.Day, MarketExecution.ReferencePrice(quote) * (decimal)Math.Exp(-(double)delta * .01));
                quote.AppliedSignal = applied;
                if (signal != 0) MarketDynamics.AddEvent(d, new(d.Day, asset.Id, c.Name + "赛果已计入当前汇率。", (double)(quote.Price / forexBefore - 1), Competition: c.Id));
                continue;
            }
            if (!partners.TryGetValue(asset.Name, out var links)) continue;
            var related = new List<(string Id, string Detail, double Signal)>();
            foreach (var link in links)
            {
                var seats = sponsorOutcomes.Where(p => link.Club ? (c.EntrantClubs.GetValueOrDefault(p.Id) ?? EsportsWorld.ClubOf(d, p.Id)) == link.Target
                        : p.Id == link.Target || p.Id == "player" && d.HumanIds.Count == 0 && link.Target == GroupChats.Human(d)).Distinct().ToArray();
                if (seats.Length == 0) continue;
                double signal = seats.Average(p => MarketDynamics.ResultSignal(c, fixture.Round, link.Club ? p.TeamWon : p.Won));
                string subject = link.Club ? EsportsWorld.ClubName(d, link.Target) : CareerEngine.DisplayName(d, link.Target);
                related.Add((seats[0].Id, (link.Club ? "俱乐部赞助：" : "个人代言：") + subject + (signal > 0 ? "获胜" : signal < 0 ? "失利" : "本轮无净利好"), signal));
            }
            if (related.Count == 0) continue;
            double change = MarketDynamics.BrandChange(d.WorldId, asset, related.Average(p => p.Signal));
            decimal before = quote.Price;
            Price(d, asset.Id, d.Day, MarketExecution.ReferencePrice(quote) * (decimal)Math.Exp(change));
            double actual = (double)(quote.Price / before - 1);
            MarketDynamics.AddEvent(d, new(d.Day, asset.Id, asset.Name + " · " + string.Join("；", related.Select(p => p.Detail))
                + $"；{c.Name}第{fixture.Round}轮，品牌报价{actual:+0.00%;-0.00%;0.00%}。", actual, related[0].Id, c.Id));
        }
        d.Market.Revision++; Accounts(d, d.Day);
    }
    public static readonly int[] Leverages = [1, 2, 3, 5, 10, 20, 50, 100];
    public static decimal OpenFee(MarketAsset asset, decimal margin, int leverage) => decimal.Round(margin * leverage * (asset.Forex ? .00005m + leverage * .000005m : FeeRate), 4);
    public static decimal BudgetMargin(MarketAsset asset, decimal cash, int leverage, int percent)
    {
        decimal budget = cash * percent / 100;
        decimal margin = decimal.Floor(budget / (1 + OpenFee(asset, 100000, leverage) / 100000) * 1000) / 1000;
        // 一内部货币单位等于十美元；按美分向下取整，最后使用实际手续费精度核对。
        if (margin + OpenFee(asset, margin, leverage) > budget) margin -= .001m;
        else if (margin + .001m + OpenFee(asset, margin + .001m, leverage) <= budget) margin += .001m;
        return margin;
    }
    public static string? Trade(CareerData d, MarketOrder order)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.MarketTrade);
        var account = d.Life.Trading;
        if (order.Amount < 0) return "请输入有效金额。";
        if (order.Action is "open" or "close" or "margin" or "stop" && order.QuoteRevision != d.Market.Revision) return "报价已更新，请查看最新价格后确认。";
        decimal amount = decimal.Round(order.Amount, 4);
        switch (order.Action)
        {
            case "deposit":
                if (amount <= 0 || amount > CareerMoney.Balance(d)) return "可用资金不足。";
                CareerMoney.Add(d, -amount); account.Cash += amount; CareerMoney.Record(d, "交易账户转入", -amount); break;
            case "withdraw":
                if (amount <= 0 || amount > account.Cash) return "交易账户余额不足。";
                CareerMoney.Add(d, amount); account.Cash -= amount; CareerMoney.Record(d, "交易账户转出", amount); amount = -amount; break;
            case "borrow":
                if (account.Debt > 0) return "请先偿还现有借款。";
                if (amount < 50 || amount > 5000) return "单笔借款为$500至$50,000。";
                account.InterestRate = amount <= 500 ? .0002m : amount <= 2000 ? .0004m : .0007m;
                account.Debt += amount; account.Cash += amount; account.InterestDay = d.Day; break;
            case "repay":
                if (amount <= 0 || amount > account.Cash || amount > account.Debt) return "还款金额超过余额或欠款。";
                account.Debt -= amount; account.Cash -= amount; amount = -amount; break;
            case "repay-all":
                amount = account.Debt;
                if (amount <= 0) return "当前没有借款。";
                if (amount > account.Cash) return "交易账户余额不足，还差" + CareerMoney.Format(amount - account.Cash) + "。";
                account.Cash -= amount; account.Debt = 0; amount = -amount; break;
            case "open":
                if (!MarketCatalog.ById.TryGetValue(order.Asset, out var asset)) return "找不到这项资产。";
                if (!Leverages.Contains(order.Leverage) || order.Direction is not (-1 or 1)) return "请选择有效的杠杆和买卖方向。";
                decimal fee = OpenFee(asset, amount, order.Leverage);
                if (amount <= 0 || amount + fee > account.Cash) return "余额不足以支付本金与手续费。";
                var preview = MarketClearing.Preview(d, order, false);
                if (!preview.Accepted) return preview.Reason + "，请调整保证金或杠杆后确认。";
                MarketClearing.Commit(d.Market, asset.Id, preview, d.Day);
                account.Cash -= amount + fee;
                account.Positions.Add(new() { Id = ++account.NextPosition, Asset = asset.Id, Entry = preview.Average, Margin = amount, InitialMargin = amount, OpeningFee = fee,
                    Units = preview.Units, Direction = order.Direction, Leverage = order.Leverage, ExecutionVersion = 1 });
                amount = -(amount + fee); break;
            case "margin":
                var funded = account.Positions.FirstOrDefault(p => p.Id == order.Position);
                if (funded == null) return "这笔持仓已经结束。";
                if (amount <= 0 || amount > account.Cash) return "追加金额须大于零且不超过交易账户余额。";
                funded.InitialMargin ??= funded.Margin;
                funded.OpeningFee ??= OpenFee(MarketCatalog.ById[funded.Asset], funded.Margin, funded.Leverage);
                funded.Margin += amount; account.Cash -= amount; amount = -amount;
                if (funded.ExecutionVersion == 1) d.Market.Revision++;
                break;
            case "stop":
                var protectedPosition = account.Positions.FirstOrDefault(p => p.Id == order.Position);
                if (protectedPosition == null) return "这笔持仓已经结束。";
                decimal current = protectedPosition.ExecutionVersion == 1 ? d.Market.Quotes[protectedPosition.Asset].Price : MarketExecution.ReferencePrice(d.Market.Quotes[protectedPosition.Asset]);
                if (order.StopPrice is { } stopPrice && (stopPrice <= 0 || (protectedPosition.Direction > 0 ? stopPrice >= current : stopPrice <= current)))
                    return protectedPosition.Direction > 0 ? "做多止损价须大于零且低于当前报价。" : "做空止损价须高于当前报价。";
                protectedPosition.StopPrice = order.StopPrice; amount = 0;
                if (protectedPosition.ExecutionVersion == 1) d.Market.Revision++;
                break;
            case "close":
                var position = account.Positions.FirstOrDefault(p => p.Id == order.Position);
                if (position == null) return "这笔持仓已经结束。";
                if (position.ExecutionVersion == 1)
                {
                    var closing = MarketClearing.Close(d.Market, MarketClearing.Accounts(d), position);
                    MarketClearing.Commit(d.Market, position.Asset, closing, d.Day);
                    Accounts(d, d.Day); return null;
                }
                var exit = MarketExecution.Close(position, d.Market.Quotes[position.Asset]);
                amount = exit.Proceeds;
                account.Cash += amount; account.Positions.Remove(position);
                MarketExecution.Apply(d.Market, position.Asset, exit.Fill, d.Day); break;
            default: return "交易操作无效。";
        }
        Record(account, d.Day, order.Action switch { "deposit" => "转入", "withdraw" => "转出", "borrow" => "借款", "repay" or "repay-all" => "还款", "open" => MarketCatalog.ById[order.Asset].Name + "建仓", "margin" => "追加保证金", "stop" => order.StopPrice == null ? "取消止损" : "设置止损", _ => "平仓" }, amount);
        if (order.Action is "open" or "close") Accounts(d, d.Day);
        return null;
    }
}
