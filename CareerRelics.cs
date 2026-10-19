namespace NationalSpire;

public sealed class FigurineState
{
    public int BoughtDay { get; set; }
    public int Uses { get; set; }
    public int Count { get; set; }
    public int Charge { get; set; }
    public int Season { get; set; }
    public int Accrued { get; set; }
    public int AccrualDay { get; set; }
    public bool Ended { get; set; }
    public HashSet<string>? SocialRewards { get; set; }
}

/// <summary>收藏效果只作用于生涯账目、活动与社交，不修改原生对局状态或比赛成绩。</summary>
public static class CareerRelics
{
    public sealed record Item(string Id, string Name, int Price, string Effect, int Uses = 0);
    public static readonly Item[] Catalog = [
        new("MEMBERSHIP_CARD", "会员卡", 3600, "生活和社交费用减少25%。"),
        new("TOOLBOX", "工具箱", 6000, "每轮额外提供三项活动候选。"),
        new("BURNING_BLOOD", "燃烧之血", 4200, "失利时少扣4至8点评分。"),
        new("MAW_BANK", "巨口储蓄罐", 3200, "每天获得$500至1,000，长期生效。"),
        new("VENERABLE_TEA_SET", "古茶具套装", 2800, "完成生活活动后，准备一次内容制作缩短2天的机会，可累积。"),
        new("TUNGSTEN_ROD", "钨合金棍", 1800, "商业亏损补回50%。"),
        new("MEAL_TICKET", "餐券", 600, "料理课、赛后请客和新人接风费用减少50%。"),
        new("THE_COURIER", "送货员", 4000, "手办购买享受七折。"),
        new("ANCHOR", "锚", 2200, "内容与社区费用减少20%。"),
        new("ORICHALCUM", "奥利哈钢", 2400, "失利时少扣3点评分。"),
        new("DREAM_CATCHER", "捕梦网", 3500, "生活活动完成后，下一轮额外提供两项内容候选，机会可累积。"),
        new("POTION_BELT", "药水腰带", 1200, "正常完赛且有剩余药水，获得$2,000至4,000。"),
        new("JUZU_BRACELET", "佛珠手链", 3000, "每轮优先同时提供生活与社交候选。"),
        new("REGAL_PILLOW", "皇家枕头", 2400, "生活活动完成后获得四次比赛评分保护，失利时少扣4分，次数可累积。"),
        new("HAPPY_FLOWER", "开心小花", 2000, "每完成三项活动获得$3,000至6,000。"),
        new("LETTER_OPENER", "开信刀", 3000, "每完成三次内容制作增加2,000至3,500关注。"),
        new("PEN_NIB", "钢笔尖", 3600, "每完成两次内容制作增加1,200至2,000关注。"),
        new("KUNAI", "苦无", 3800, "每次青训支持增加$2,000训练资源。"),
        new("SHURIKEN", "手里剑", 3600, "每完成三次社区活动增加2,000至3,500关注。"),
        new("CENTENNIAL_PUZZLE", "百年积木", 2000, "失利后准备一次内容制作七折机会，可累积。"),
        new("WINGED_BOOTS", "羽翼之靴", 2400, "至少3天的普通活动缩短2天，训练保持完整周期。"),
        new("BAG_OF_PREPARATION", "准备背包", 1000, "内容与社区费用减少20%。"),
        new("SLING_OF_COURAGE", "勇气投石索", 4800, "正常赢下进阶8及以上比赛增加1,000至2,000关注。"),
        new("WHITE_STAR", "白星", 5500, "每次赢下国际赛事获得$8,000至12,000。"),
        new("JEWELED_MASK", "宝石面具", 2600, "完成社交活动额外获得基础6点好感，随攻略难度结算。"),
        new("GOLDEN_PEARL", "金色珍珠", 5000, "商业项目利润额外增加50%。")
    ];
    private static int Roll(CareerData d, string key, int min, int max) => min + CareerEngine.StableHash(d.WorldId + ":figurine:" + key) % (max - min + 1);
    public static bool Has(CareerData d, string id) => d.Life.Figurines.TryGetValue(id, out var s) && !s.Ended;
    private static FigurineState? State(CareerData d, string id) => Has(d, id) ? d.Life.Figurines[id] : null;
    public static bool CanBuy(CareerData d, Item r) => !d.Life.Figurines.ContainsKey(r.Id);
    public static int StockCount(CareerData d)
    {
        int rank = CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country);
        return rank < 0 ? 0 : new[] { 5, 4, 3, 3, 2, 2, 1, 0 }[rank];
    }
    public static void Upgrade(CareerData d)
    {
        if (d.Life.RelicVersion >= 1) return;
        foreach (var (id, state) in d.Life.Figurines)
        {
            if (id == "MAW_BANK") { if (state.Ended) state.Accrued = 0; state.AccrualDay = d.Day; }
            state.Ended = false;
        }
        d.Life.RelicVersion = 1;
    }
    public static void Shop(CareerData d)
    {
        Upgrade(d);
        if (d.Life.RestockDay > d.Day) return;
        var previous = d.Life.Shop.ToHashSet();
        d.Life.Shop = Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))
            .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)).Take(StockCount(d)).Select(r => r.Id).ToList();
        d.Life.RestockDay = d.Day + 14;
    }
    public static IEnumerable<Item> Offers(CareerData d) => d.Life.Shop
        .Select(id => Catalog.FirstOrDefault(r => r.Id == id)).OfType<Item>();
    public static int PurchasePrice(CareerData d, Item item) => Has(d, "THE_COURIER") ? (item.Price * 70 + 99) / 100 : item.Price;
    public static string Status(CareerData d, Item r)
    {
        var s = d.Life.Figurines[r.Id];
        if (r.Uses > 0 && s.Uses <= 0) return "次数已用完 · 商店再次上架后可重新购买";
        if (s.Ended) return "已留作收藏 · 效果结束";
        if (r.Uses > 0) return $"剩余 {s.Uses} 次";
        if (r.Id == "MAW_BANK") return "每日回馈 · 长期生效";
        if (s.Charge > 0) return $"长期生效 · 已准备 {s.Charge} 次";
        return "长期生效";
    }
    public static string? Buy(CareerData d, string id)
    {
        Shop(d);
        var r = Offers(d).FirstOrDefault(r => r.Id == id);
        if (r == null || !CanBuy(d, r)) return "这款手办当前无法购买。";
        int price = PurchasePrice(d, r);
        if (d.Credits < price) return "当前资金不足。";
        Spend(d);
        bool refill = d.Life.Figurines.ContainsKey(id);
        d.Credits -= price; CareerMoney.Record(d, r.Name + (refill ? "手办恢复次数" : "手办"), -price);
        if (refill) { var owned = d.Life.Figurines[id]; owned.Uses = r.Uses; owned.Ended = false; }
        else d.Life.Figurines[id] = new() { BoughtDay = d.Day, AccrualDay = d.Day, Uses = r.Uses };
        CareerStore.Save(d); return null;
    }
    public static void Advance(CareerData d)
    {
        Shop(d);
        var s = State(d, "MAW_BANK");
        if (s == null) return;
        int amount = s.Accrued;
        for (int day = Math.Max(s.AccrualDay, s.BoughtDay) + 1; day <= d.Day; day++) amount += Roll(d, "bank:" + day, 50, 100);
        s.AccrualDay = d.Day; s.Accrued = 0;
        if (amount > 0) { d.Credits += amount; CareerMoney.Record(d, "巨口储蓄罐手办回馈", amount); }
    }
    public static void Spend(CareerData d) => Advance(d);
    private static bool Food(LifeActivity a) => a.Title is "地方料理课" or "赛后请客" or "给新人接风";
    private static bool Media(LifeActivity a) => a.Kind is "内容" or "社区";
    // 逐项折扣相乘，投资本金不参与。
    private static IEnumerable<(string Id, int Amount)> Discounts(CareerData d, LifeActivity a)
    {
        if (a.Kind is "商业" or "事业" or "青训" or "俱乐部") yield break;
        if (Has(d, "MEMBERSHIP_CARD") && a.Kind is "生活" or "社交") yield return ("MEMBERSHIP_CARD", 25);
        if (Food(a) && Has(d, "MEAL_TICKET")) yield return ("MEAL_TICKET", 50);
        if (Media(a) && Has(d, "ANCHOR")) yield return ("ANCHOR", 20);
        if (Media(a) && Has(d, "BAG_OF_PREPARATION")) yield return ("BAG_OF_PREPARATION", 20);
        if (a.Kind == "内容" && State(d, "CENTENNIAL_PUZZLE") is { Charge: > 0 }) yield return ("CENTENNIAL_PUZZLE", 30);
    }
    public static int Cost(CareerData d, LifeActivity a)
    {
        decimal cost = a.Cost;
        foreach (var discount in Discounts(d, a)) cost *= 1 - discount.Amount / 100m;
        if (a.Kind == "内容" && d.Life.Preparation > 0) cost -= Math.Min(24, a.Cost * 12 / 100);
        if (Media(a) && d.Life.Facilities > 0) cost -= Math.Min(24, a.Cost * Math.Min(72, d.Life.Facilities * 24) / 1000);
        return Math.Max(0, (int)cost);
    }
    public static int Duration(CareerData d, LifeActivity a) => (CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a)) ? 28 : Math.Max(1, a.Duration
        - (a.Kind == "内容" && State(d, "VENERABLE_TEA_SET") is { Charge: > 0 } ? 2 : 0)
        - (a.Duration >= 3 && Has(d, "WINGED_BOOTS") ? 2 : 0));
    public static void Accept(CareerData d, LifeActivity a)
    {
        if (a.Kind != "内容") return;
        if (State(d, "CENTENNIAL_PUZZLE") is { Charge: > 0 } puzzle) puzzle.Charge--;
        if (State(d, "VENERABLE_TEA_SET") is { Charge: > 0 } tea) tea.Charge--;
        d.Life.Preparation = 0;
    }
    public static int Training(CareerData d, LifeActivity a)
    {
        if (!Has(d, "KUNAI")) return 0;
        a.Result += "苦无手办带来的训练资源增加 $2,000。"; return 200;
    }
    public static int Business(CareerData d, LifeActivity a, int revenue)
    {
        int delta = revenue - a.Cost;
        if (delta < 0 && Has(d, "TUNGSTEN_ROD"))
        {
            int benefit = -delta / 2;
            if (benefit > 0) { a.Result += $"钨合金棍手办补回 {CareerMoney.Format(benefit)}。"; return revenue + benefit; }
        }
        if (delta > 0 && Has(d, "GOLDEN_PEARL"))
        { int benefit = delta / 2; if (benefit > 0) a.Result += $"金色珍珠手办额外带来 {CareerMoney.Format(benefit)}。"; return revenue + benefit; }
        return revenue;
    }
    public static void Complete(CareerData d, LifeActivity a)
    {
        void Fans(string id, int interval, int min, int max)
        {
            if (State(d, id) is not { } s || ++s.Count % interval != 0) return;
            int n = Roll(d, a.Id + id, min, max); d.Fans += n; a.Result += $"{Catalog.First(r => r.Id == id).Name}手办：额外增加 {n} 位关注者。";
        }
        if (a.Kind == "生活")
        {
            foreach (string id in new[] { "VENERABLE_TEA_SET", "DREAM_CATCHER", "REGAL_PILLOW" })
                if (State(d, id) is { } s) { s.Charge += id == "REGAL_PILLOW" ? 4 : 1; a.Result += Catalog.First(r => r.Id == id).Name + "手办的效果已准备。"; }
        }
        if (a.Kind == "社交" && a.PersonId.Length > 0 && State(d, "JEWELED_MASK") is { } mask)
        {
            int before = PrivateMessages.Favour(d, a.PersonId);
            PrivateMessages.ChangeFavour(d, a.PersonId, 6); a.Result += $"宝石面具手办：好感额外增加{PrivateMessages.Favour(d, a.PersonId) - before}。";
        }
        if (a.Kind == "内容") { Fans("LETTER_OPENER", 3, 2000, 3500); Fans("PEN_NIB", 2, 1200, 2000); }
        if (a.Kind == "社区") Fans("SHURIKEN", 3, 2000, 3500);
        if (State(d, "HAPPY_FLOWER") is { } flower && ++flower.Count % 3 == 0)
        {
            int amount = Roll(d, a.Id + "flower", 300, 600); d.Credits += amount; CareerMoney.Record(d, "开心小花手办回馈", amount);
            a.Result += $"开心小花手办带来 {CareerMoney.Format(amount)}。";
        }
    }
    public static void Match(CareerData d, CareerMatch m, CareerResult result, bool abandoned, int oldRating)
    {
        if (abandoned) return;
        int protection = 0;
        void Protect(string id, int amount)
        { if (amount <= 0) return; int n = Math.Min(amount, Math.Max(0, oldRating - d.Rating)); if (n <= 0) return;
            d.Rating += n; protection += n; result.LifeEffects.Add(Catalog.First(r => r.Id == id).Name + $"手办：本场少扣 {n} 点生涯评分。"); }
        if (!m.PlayerWon && !m.Draw)
        {
            if (Has(d, "BURNING_BLOOD")) Protect("BURNING_BLOOD", Roll(d, m.Id + "blood", 4, 8));
            if (Has(d, "ORICHALCUM")) Protect("ORICHALCUM", 3);
            if (State(d, "REGAL_PILLOW") is { Charge: > 0 }) Protect("REGAL_PILLOW", 4);
            if (State(d, "CENTENNIAL_PUZZLE") is { } puzzle)
            { puzzle.Charge++; result.LifeEffects.Add("百年积木手办：下次内容制作享受七折。"); }
        }
        if (State(d, "REGAL_PILLOW") is { Charge: > 0 } pillow) pillow.Charge--;
        void Cash(string id, int min, int max)
        { int amount = Roll(d, m.Id + id, min, max); d.Credits += amount; result.LifeEffects.Add(Catalog.First(r => r.Id == id).Name + "手办：纪念展示支持 " + CareerMoney.Format(amount) + "。"); }
        if (result.Evidence.PotionsRecorded && result.Evidence.RemainingPotions.Count > 0 && Has(d, "POTION_BELT"))
        { Cash("POTION_BELT", 200, 400); }
        if (m.PlayerWon && m.RequiredAscension >= 8 && Has(d, "SLING_OF_COURAGE"))
        { int n = Roll(d, m.Id + "sling", 1000, 2000); d.Fans += n; result.LifeEffects.Add($"勇气投石索手办：额外增加 {n} 位关注者。"); }
        if (m.PlayerWon && m.Kind is "continental" or "worldcup" or "worldfinal" or "masters" && State(d, "WHITE_STAR") is { } star)
        { star.Season = d.Season; Cash("WHITE_STAR", 800, 1200); }
    }
}
