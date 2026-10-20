namespace NationalSpire;

/// <summary>每次刷新商城读取一次本人购买记录，只用于展示，不写入存档。</summary>
public sealed class ConsumerPurchases
{
    private readonly Dictionary<string, int> _days;
    private readonly HashSet<string> _current = [];
    private readonly Dictionary<string, long> _promotions;
    private readonly Dictionary<string, long> _quantities;
    public ConsumerPurchases(CareerData data)
    {
        var state = data.Life.Consumer;
        _days = new(state.BoughtDay);
        _promotions = state.Season == data.Season ? new(state.PromoUsed) : [];
        _quantities = state.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id).ToDictionary(g => g.Key, g => g.Sum(x => x.Quantity));
        foreach (var item in state.Goods)
        {
            if (!_days.TryGetValue(item.Id, out int day) || item.BoughtDay > day) _days[item.Id] = item.BoughtDay;
            if (item.Season == data.Season) _current.Add(item.Id);
        }
    }
    public long Quantity(Good good) => _quantities.GetValueOrDefault(good.Id);
    public bool Owned(Good good) => good.Collectible && Quantity(good) > 0;
    public int Day(Good good) => _days.GetValueOrDefault(good.Id);
    public bool ThisSeason(Good good) => _current.Contains(good.Id);
    public long Promotions(Good good) => _promotions.GetValueOrDefault(good.Id);
    public IEnumerable<Good> Collection => ConsumerCatalog.All.Where(Owned);
    public string Label(Good good) => good.Promo ? $"本季 {Promotions(good)} 次"
        : Owned(good) ? $"持有 ×{Quantity(good)}" : good.Collectible ? "" : "即时消费";
}
