namespace NationalSpire;

/// <summary>每次刷新商城读取一次本人购买记录，只用于展示，不写入存档。</summary>
public sealed class ConsumerPurchases
{
    private readonly Dictionary<string, int> _days;
    private readonly HashSet<string> _current = [];
    private readonly Dictionary<string, int> _promotions;
    public ConsumerPurchases(CareerData data)
    {
        var state = data.Life.Consumer;
        _days = new(state.BoughtDay);
        _promotions = state.Season == data.Season ? new(state.PromoUsed) : [];
        foreach (var item in state.Goods)
        {
            if (!_days.TryGetValue(item.Id, out int day) || item.BoughtDay > day) _days[item.Id] = item.BoughtDay;
            if (item.Season == data.Season) _current.Add(item.Id);
        }
    }
    public bool Owned(Good good) => good.Collectible && _days.ContainsKey(good.Id);
    public int Day(Good good) => _days.GetValueOrDefault(good.Id);
    public bool ThisSeason(Good good) => _current.Contains(good.Id);
    public int Promotions(Good good) => _promotions.GetValueOrDefault(good.Id);
    public IEnumerable<Good> Collection => ConsumerCatalog.All.Where(Owned);
    public string Label(Good good) => good.Promo ? $"{Promotions(good)} / {ConsumerCatalog.PromoPerSeason}"
        : ThisSeason(good) ? good.Repeatable ? "本季已体验" : "本季已购" : Owned(good) ? "已收藏" : "";
}
