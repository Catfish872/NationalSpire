namespace NationalSpire;

/// <summary>消费写入当前玩家 Life；联机通过现有个人视图及 Capture 提交。</summary>
public static class ConsumerEngine
{
    public const int InviteFavourGate = 5;
    public static int Uses(CareerData d, string id) => d.Life.Consumer.Season == d.Season ? d.Life.Consumer.PromoUsed.GetValueOrDefault(id) : 0;
    public static int Price(Good good) => good.Category == "数码" && good.Tier == ConsumerCatalog.Mass ? Math.Max(10, good.Price / 5)
        : good.Id == "ebike" ? 6000 : good.Price;
    public static string? BuyError(CareerData d, Good good)
    {
        var state = d.Life.Consumer;
        if (CareerMoney.Balance(d) < Price(good) / 10m) return "当前资金不足。";
        if (good.Promo) return Uses(d, good.Id) >= ConsumerCatalog.PromoPerSeason ? "本赛季已完成三次" : null;
        if (good.Durable && state.Goods.Any(g => g.Id == good.Id)) return "已经拥有";
        if (good.Repeatable && state.BoughtDay.TryGetValue(good.Id, out int day) && d.Day - day < ConsumerCatalog.RepeatCooldown) return "本月已经体验";
        if (!good.Repeatable && state.Goods.Any(g => g.Id == good.Id && g.Season == d.Season)) return "本赛季已经购买";
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
        s.Goods.RemoveAll(g => !g.Durable && g.Season < d.Season - 1);
    }
    public static string? Buy(CareerData d, string id, IReadOnlyList<string>? invitees = null)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.ConsumerOperation);
        var good = ConsumerCatalog.Get(id);
        if (good == null) return "找不到这件商品。";
        if (BuyError(d, good) is { } error) return error;
        var guests = invitees ?? [];
        if (Guests(d, guests, good.Slots) is { } invalid) return invalid;
        Season(d);
        var s = d.Life.Consumer;
        int fans = good.Promo ? CareerAudience.PromotionGain(d.Fans, Price(good), Uses(d, id)) : 0;
        decimal cost = Price(good) / 10m;
        CareerMoney.Add(d, -cost); CareerMoney.Record(d, good.Name, -cost);
        s.PurchaseCount++; s.LifetimeSpent += (long)cost; s.BoughtDay[id] = d.Day;
        if (good.Promo) s.PromoUsed[id] = Uses(d, id) + 1;
        else s.Goods.Add(new() { Id = id, Name = good.Name, BoughtDay = d.Day, Season = d.Season, Price = (int)cost, Durable = good.Durable, Consumed = !good.Durable, UsedSeason = d.Season });
        d.Fans += fans;
        string names = string.Join("、", guests.Select(g => CareerEngine.DisplayName(d, g)));
        string body = $"{CareerEngine.Name(d)}花费${Price(good):N0}购买{good.Name}。" + (names.Length > 0 ? $"同行者：{names}。" : "") + (fans > 0 ? $"活动结束后新增关注{fans}。" : "");
        ConsumerEvents.Purchase(d, body, guests);
        return null;
    }
    public static int HospitalityFee(Good good) => good.Tier == ConsumerCatalog.Luxury ? 10000 : good.Tier == ConsumerCatalog.Rich ? 5000 : 1000;
    public static string? Use(CareerData d, string goodId, string verbId, IReadOnlyList<string> guests)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.ConsumerOperation);
        var s = d.Life.Consumer;
        var owned = s.Goods.FirstOrDefault(g => g.Id == goodId && g.Durable);
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
        ConsumerEvents.Activity(d, good, verb, guests);
        return null;
    }
}
