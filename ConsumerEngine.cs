namespace NationalSpire;

/// <summary>消费写入当前玩家 Life；联机通过现有个人视图及 Capture 提交。</summary>
public static class ConsumerEngine
{
    public const int InviteFavourGate = 5;
    public static void Ensure(CareerData d)
    {
        var s = d.Life.Consumer;
        if (s.InventoryVersion >= 1) return;
        foreach (var good in s.Goods.Where(g => ConsumerCatalog.Get(g.Id)?.Collectible == true)) good.Consumed = false;
        foreach (var purchase in s.BoughtDay.Where(p => ConsumerCatalog.Get(p.Key)?.Collectible == true && !s.Goods.Any(g => g.Id == p.Key)))
        {
            var good = ConsumerCatalog.Get(purchase.Key)!;
            s.Goods.Add(new() { Id = good.Id, Name = good.Name, BoughtDay = purchase.Value, Durable = good.Durable, Price = Price(good) / 10 });
        }
        s.InventoryVersion = 1;
    }
    public static long Uses(CareerData d, string id) => d.Life.Consumer.Season == d.Season ? d.Life.Consumer.PromoUsed.GetValueOrDefault(id) : 0;
    public static int Price(Good good) => good.Category == "数码" && good.Tier == ConsumerCatalog.Mass ? Math.Max(10, good.Price / 5)
        : good.Id == "ebike" ? 6000 : good.Price;
    public static string? BuyError(CareerData d, Good good, int quantity = 1)
    {
        if (quantity < 1) return "请选择购买数量。";
        if (CareerMoney.Balance(d) < Price(good) / 10m * quantity) return "当前资金不足。";
        return null;
    }
    public static bool CanInvite(CareerData d, string id) => id != "player" && !d.HumanIds.Contains(id)
        && PrivateMessages.CanChat(d, id) && PrivateMessages.Favour(d, id) >= InviteFavourGate;
    private static string? Guests(CareerData d, IReadOnlyList<string> ids, int slots)
        => ids.Count > slots || ids.Distinct().Count() != ids.Count ? "邀请名单超过人数或存在重复。"
            : ids.Any(id => !CanInvite(d, id)) ? "邀请对象需要能够联系，且好感达到5。" : null;
    private static void Season(CareerData d)
    {
        var s = d.Life.Consumer;
        if (s.Season == d.Season) return;
        s.Season = d.Season; s.PromoUsed.Clear(); s.InvitedThisSeason.Clear();
        foreach (var good in s.Goods) { good.UsedVerbs.Clear(); good.UsedSeason = d.Season; }
        // 耐用品始终保留；已消费物品的历史由账目和帖子保留。
        s.Goods.RemoveAll(g => g.Consumed && g.Season < d.Season - 1);
    }
    public static string? Buy(CareerData d, string id, IReadOnlyList<string>? invitees = null, int quantity = 1)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.ConsumerOperation);
        Ensure(d);
        var good = ConsumerCatalog.Get(id);
        if (good == null) return "找不到这件商品。";
        if (BuyError(d, good, quantity) is { } error) return error;
        var guests = invitees ?? [];
        if (Guests(d, guests, good.Slots) is { } invalid) return invalid;
        Season(d);
        var s = d.Life.Consumer;
        int fans = 0;
        if (good.Promo) fans = PromotionGain(Price(good), Uses(d, id), quantity);
        decimal cost = Price(good) / 10m * quantity;
        CareerMoney.Add(d, -cost); CareerMoney.Record(d, good.Name, -cost);
        s.PurchaseCount += quantity; s.LifetimeSpent += cost; s.BoughtDay[id] = d.Day;
        if (good.Promo) s.PromoUsed[id] = Uses(d, id) + quantity;
        else if (good.Collectible)
        {
            ChangeInventory(d, good, quantity);
        }
        d.Fans += fans;
        string names = string.Join("、", guests.Select(g => CareerEngine.DisplayName(d, g)));
        string body = $"{CareerEngine.Name(d)}花费${cost * 10:N0}购买{good.Name}×{quantity}。" + (names.Length > 0 ? $"同行者：{names}。" : "") + (fans > 0 ? $"活动结束后新增关注{fans}。" : "");
        ConsumerEvents.Purchase(d, body, guests);
        return null;
    }
    public static int HospitalityFee(Good good) => good.Tier == ConsumerCatalog.Luxury ? 10000 : good.Tier == ConsumerCatalog.Rich ? 5000 : 1000;
    public static void ChangeInventory(CareerData d, Good good, long quantity)
    {
        if (quantity < 0)
        {
            foreach (var stack in d.Life.Consumer.Goods.Where(g => g.Id == good.Id && !g.Consumed).ToArray())
            {
                long used = Math.Min(stack.Quantity, -quantity); stack.Quantity -= used; quantity += used;
                if (stack.Quantity == 0) d.Life.Consumer.Goods.Remove(stack);
                if (quantity == 0) break;
            }
            return;
        }
        var owned = d.Life.Consumer.Goods.FirstOrDefault(g => g.Id == good.Id && !g.Consumed);
        if (owned != null) { owned.Quantity += quantity; if (owned.Quantity == 0) d.Life.Consumer.Goods.Remove(owned); }
        else if (quantity > 0) d.Life.Consumer.Goods.Add(new() { Id = good.Id, Name = good.Name, Quantity = quantity, BoughtDay = d.Day, Season = d.Season, Price = Price(good) / 10, Durable = good.Durable, UsedSeason = d.Season });
    }
    public static int PromotionGain(int price, long used, int quantity)
    {
        long denominator = used + 2, end = denominator + quantity - 1, result = 0;
        while (denominator <= end)
        {
            long gain = (long)Math.Round(price / (double)denominator);
            if (gain == 0) break;
            long boundary = 2L * price / (2 * gain - 1);
            if (2L * price % (2 * gain - 1) == 0 && gain % 2 == 1) boundary--;
            long last = Math.Min(end, boundary);
            result += gain * (last - denominator + 1); denominator = last + 1;
        }
        return (int)result;
    }
    public static string? Use(CareerData d, string goodId, string verbId, IReadOnlyList<string> guests, bool publicly = true)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.ConsumerOperation);
        var s = d.Life.Consumer;
        var owned = s.Goods.FirstOrDefault(g => g.Id == goodId && g.Durable && g.Quantity > 0);
        var good = ConsumerCatalog.Get(goodId);
        var verb = good?.Verbs.FirstOrDefault(v => v.Id == verbId);
        if (owned == null || good == null || verb == null) return "没有这项可使用的物品。";
        if (owned.UsedSeason == d.Season && owned.UsedVerbs.Contains(verbId)) return "本赛季已经举办过这项活动。";
        if (Guests(d, guests, verb.Slots) is { } error) return error;
        decimal cost = HospitalityFee(good) / 10m;
        if (CareerMoney.Balance(d) < cost) return "招待费用不足。";
        Season(d);
        CareerMoney.Add(d, -cost); CareerMoney.Record(d, verb.Name + "招待费", -cost);
        owned.UsedVerbs.Add(verbId); owned.UsedSeason = d.Season; s.PartyCount++;
        foreach (string id in guests)
        {
            int count = s.InvitedThisSeason.GetValueOrDefault(id);
            PrivateMessages.ChangeFavour(d, id, count == 0 ? verb.Favor : 1);
            s.InvitedThisSeason[id] = count + 1;
        }
        if (publicly) ConsumerEvents.Activity(d, good, verb, guests);
        return null;
    }
}
