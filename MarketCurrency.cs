namespace NationalSpire;

/// <summary>交易指令始终传入房间资产编号和结算价。单人以开局国籍报价，联机以全队参赛国报价。</summary>
internal readonly struct MarketCurrency(MarketState market, MarketAsset asset)
{
    internal MarketCurrency(CareerData data, MarketAsset asset) : this(data.Market, asset) { }
    private MarketAsset? Base => asset.Forex ? MarketCatalog.ById.GetValueOrDefault("forex:" + market.QuoteCountry) : null;
    internal static string BaseName(CareerData d) => MarketCatalog.ById.TryGetValue("forex:" + d.Market.QuoteCountry, out var b) ? Unit(b) : "人民币";
    internal bool Inverse => Base?.Id == asset.Id;
    private static string Unit(MarketAsset item) => item.Name[(item.Name.IndexOf('/') + 1)..].Trim();
    internal MarketAsset Display => Base is { } b ? asset with { Name = Unit(b) + " / " + (Inverse ? "人民币" : Unit(asset)), Country = Inverse ? "中国" : asset.Country } : asset;
    internal decimal Price(decimal price, decimal basePrice) => price <= 0 || basePrice <= 0 ? price : Inverse ? 1m / price : price / basePrice;
    internal decimal Price(decimal price) => Base is { } b ? Price(price, market.Quotes[b.Id].Price) : price;
    internal string FillText(string action, decimal price) => Display.Name + action + " · 成交价" + Price(price).ToString("0.00000");
    internal decimal Settlement(decimal price) => Base is not { } b || price <= 0 ? price : Inverse ? 1m / price : price * market.Quotes[b.Id].Price;
    internal MarketQuote Quote(bool history = false)
    {
        var q = market.Quotes[asset.Id];
        if (Base is not { } b) return q;
        var reference = market.Quotes[b.Id]; var view = q.ExecutionCopy();
        view.Price = Price(q.Price, reference.Price); view.Previous = Price(q.Previous, reference.Previous);
        if (history)
        {
            var points = reference.History; int i = 0; var unit = this;
            view.History = q.History.Select(p =>
            {
                while (i + 1 < points.Count && points[i + 1].Day <= p.Day) i++;
                return new MarketPoint(p.Day, unit.Price(p.Price, points.Count > 0 ? points[i].Price : reference.Price));
            }).ToList();
        }
        return view;
    }
}
