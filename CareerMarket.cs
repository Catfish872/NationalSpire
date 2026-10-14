namespace NationalSpire;

/// <summary>公共行情只生成一次；个人账户只在报价变更、日期推进和本人下单时处理。</summary>
public static class CareerMarket
{
    public const int HistoryDays = 180;
    public const decimal DailyInterest = .0003m;
    public const decimal FeeRate = .001m;
    public static bool Initialize(CareerData d)
    {
        if (d.Market.CatalogVersion == 2) return false;
        bool changed = false;
        foreach (var asset in MarketCatalog.Assets)
            if (!d.Market.Quotes.ContainsKey(asset.Id))
            {
                d.Market.Quotes[asset.Id] = new() { Price = asset.Initial, Previous = asset.Initial, History = [new(d.Day, asset.Initial)] };
                changed = true;
            }
        if (d.Market.LastDay == 0) { d.Market.LastDay = d.Day; changed = true; }
        foreach (var asset in MarketCatalog.Assets)
        {
            var quote = d.Market.Quotes[asset.Id];
            var first = quote.History.FirstOrDefault() ?? new MarketPoint(d.Day, quote.Price);
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
        d.Market.CatalogVersion = 2; changed = true;
        return changed;
    }
    public static decimal Equity(MarketPosition position, decimal price)
        => position.Margin + position.Direction * position.Units * (price - position.Entry);
    public static decimal Net(MarketState market, MarketAccount account)
        => account.Cash - account.Debt + account.Positions.Sum(p => Math.Max(0, Equity(p, market.Quotes[p.Asset].Price)));

    private static void Record(MarketAccount account, int day, string text, decimal change)
    {
        account.Trades.Add(new(day, text, change, account.Cash));
        if (account.Trades.Count > 120) account.Trades.RemoveAt(0);
    }
    public static void Account(MarketState market, MarketAccount account, int day)
    {
        if (account.InterestDay == 0) account.InterestDay = day;
        while (account.InterestDay < day)
        {
            decimal interest = decimal.Round(account.Debt * account.InterestRate, 4);
            account.Debt += interest; account.InterestDay++;
            if (interest > 0) Record(account, account.InterestDay, "借款利息", -interest);
        }
        foreach (var p in account.Positions.ToArray())
        {
            if (!MarketCatalog.ById[p.Asset].Forex && p.Leverage == 1) continue;
            decimal equity = Equity(p, market.Quotes[p.Asset].Price);
            if (equity > p.Margin * .1m) continue;
            decimal returned = CloseValue(p, market.Quotes[p.Asset].Price);
            account.Cash += returned; account.Positions.Remove(p);
            Record(account, day, MarketCatalog.ById[p.Asset].Name + "平仓 · 报价" + market.Quotes[p.Asset].Price, returned);
        }
    }
    private static void Accounts(CareerData d, int day)
    {
        if (d.MarketAccounts != null) d.MarketAccounts(d, day);
        else if (d.CooperativeMembers <= 1) Account(d.Market, d.Life.Trading, day);
    }
    private static void Price(MarketQuote quote, int day, decimal price)
    {
        quote.Price = Math.Max(.000001m, decimal.Round(price, 6));
        if (quote.History.Count > 0 && quote.History[^1].Day == day) quote.History[^1] = new(day, quote.Price);
        else quote.History.Add(new(day, quote.Price));
        if (quote.History.Count > HistoryDays) quote.History.RemoveAt(0);
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
                var random = new Random(CareerEngine.StableHash($"{d.WorldId}:market:{day}:{asset.Id}"));
                double sigma = MarketDynamics.Volatility(d.WorldId, asset);
                double noise = MarketDynamics.Noise(d.WorldId, day, asset, random);
                double drift = asset.Forex ? Math.Clamp(.0000012 * (total.GetValueOrDefault(asset.Country) - total.GetValueOrDefault("中国"))
                    + .000003 * (season.GetValueOrDefault(asset.Country) - season.GetValueOrDefault("中国")), -.0005, .0005) : 0;
                double signal = asset.Forex ? (double)Math.Clamp(quote.PendingSignal, -4, 4) * .01 : 0;
                // 两项衡量外币相对人民币走强；1 CNY 兑换的外币数量应随之下降。
                double change = -drift - signal + sigma * noise + MarketDynamics.Shock(random, sigma)
                    - .03 * Math.Log((double)(quote.Price / anchors[asset.Id])) + (asset.Id == eventAsset ? businessChange : 0);
                Price(quote, day, quote.Price * (decimal)Math.Exp(change)); quote.PendingSignal = 0;
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
        bool international = c.Kind is "continental" or "worldcup" or "worldfinal";
        int last = CircuitWorld.RoundCount(c);
        double elimination = fixture.Round >= last ? 0 : -Math.Pow(.5, fixture.Round - 1);
        var signals = new Dictionary<string, double>();
        var people = MarketDynamics.Partners(d);
        var outcomes = tie.SelectMany(f => new[] { (Id: f.HomeId, Won: home), (Id: f.AwayId, Won: !home) }).Distinct().ToArray();
        foreach (var (id, won) in outcomes)
        {
            if (c.Kind is not ("worldcup" or "worldfinal")) continue;
            string nation = c.EntrantCountries.GetValueOrDefault(id) ?? CareerEngine.Person(d, id)?.Country ?? d.Esports.Country;
            double signal = won ? 1 + (fixture.Round == last ? 2 : 0) : elimination;
            signals[nation] = signals.GetValueOrDefault(nation) + signal / tie.Length;
        }
        foreach (var asset in MarketCatalog.Assets)
        {
            var quote = d.Market.Quotes[asset.Id];
            if (asset.Forex)
            {
                double signal = signals.GetValueOrDefault(asset.Country) - signals.GetValueOrDefault("中国");
                quote.PendingSignal += (decimal)signal;
                if (signal != 0) MarketDynamics.AddEvent(d, new(d.Day, asset.Id, c.Name + "赛果已形成汇市消息，将于下一交易日计入报价。", signal, Competition: c.Id));
                continue;
            }
            if (!people.TryGetValue(asset.Name, out var associated)) continue;
            var related = outcomes.Where(p => associated.Contains(p.Id) || p.Id == "player" && associated.Contains(GroupChats.Human(d))).ToArray();
            if (related.Length == 0) continue;
            double change = related.Average(p => international ? p.Won ? .005 + (fixture.Round == last ? .01 : 0) : .005 * elimination : p.Won ? .002 : -.001);
            change *= MarketDynamics.Sensitivity(d.WorldId, asset.Id);
            Price(quote, d.Day, quote.Price * (decimal)Math.Exp(change));
            MarketDynamics.AddEvent(d, new(d.Day, asset.Id, asset.Name + "合作选手完成" + c.Name + $"第{fixture.Round}轮，品牌报价{change:+0.00%;-0.00%;0.00%}。", change, related[0].Id, c.Id));
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
    public static decimal CloseValue(MarketPosition position, decimal price)
        => decimal.Round(Math.Max(0, Equity(position, price) - (MarketCatalog.ById[position.Asset].Forex ? 0 : Math.Abs(position.Units * price) * FeeRate)), 4);
    public static string? Trade(CareerData d, MarketOrder order)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.MarketTrade);
        var account = d.Life.Trading;
        if (order.Amount < 0 || order.Amount > int.MaxValue) return "请输入有效金额。";
        if (order.Action is "open" or "close" && order.QuoteRevision != d.Market.Revision) return "报价已更新，请查看最新价格后确认。";
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
            case "open":
                if (!MarketCatalog.ById.TryGetValue(order.Asset, out var asset)) return "找不到这项资产。";
                if (!Leverages.Contains(order.Leverage) || order.Direction is not (-1 or 1) || !asset.Forex && order.Direction != 1) return "请选择有效的杠杆；品牌股票支持买入。";
                decimal fee = OpenFee(asset, amount, order.Leverage);
                if (amount <= 0 || amount + fee > account.Cash) return "余额不足以支付本金与手续费。";
                decimal price = d.Market.Quotes[asset.Id].Price;
                account.Cash -= amount + fee;
                account.Positions.Add(new() { Id = ++account.NextPosition, Asset = asset.Id, Entry = price, Margin = amount,
                    Units = amount * order.Leverage / price, Direction = order.Direction, Leverage = order.Leverage });
                amount = -(amount + fee); break;
            case "close":
                var position = account.Positions.FirstOrDefault(p => p.Id == order.Position);
                if (position == null) return "这笔持仓已经结束。";
                decimal current = d.Market.Quotes[position.Asset].Price;
                amount = CloseValue(position, current);
                account.Cash += amount; account.Positions.Remove(position); break;
            default: return "交易操作无效。";
        }
        Record(account, d.Day, order.Action switch { "deposit" => "转入", "withdraw" => "转出", "borrow" => "借款", "repay" => "还款", "open" => MarketCatalog.ById[order.Asset].Name + "建仓", _ => "平仓" }, amount);
        return null;
    }
}
