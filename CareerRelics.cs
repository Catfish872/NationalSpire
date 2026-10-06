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
        new("MEMBERSHIP_CARD", "会员卡", 360, "生活和社交活动费用减少约 5%，每次最多省 $100。"),
        new("TOOLBOX", "工具箱", 600, "每轮活动多提供一个候选，仍然只能选择一项。"),
        new("BURNING_BLOOD", "燃烧之血", 420, "正常参赛失利后，少扣 1—2 点生涯评分。"),
        new("MAW_BANK", "巨口储蓄罐", 32, "接下来 14 天，每天存入 $10—20；下一次活动或手办消费时取出并停止储蓄。到期自动取出。"),
        new("VENERABLE_TEA_SET", "古茶具套装", 280, "完成生活活动后，下一次内容制作缩短 1 天；最多保留一次。"),
        new("TUNGSTEN_ROD", "钨合金棍", 180, "商业项目亏损时补回亏损的 20%，每次最多 $150，共 3 次。盈利时不消耗次数。", 3),
        new("MEAL_TICKET", "餐券", 60, "料理课、赛后请客或新人接风每次减免 $50，共 5 次。", 5),
        new("THE_COURIER", "送货员", 400, "后续购买手办享受 85 折，重新购买限次手办也适用。"),
        new("ANCHOR", "锚", 220, "每赛季第一次内容或社区活动减免 $100。"),
        new("ORICHALCUM", "奥利哈钢", 240, "没有任何活动正在进行时，正常参赛失利少扣 1 点生涯评分。"),
        new("DREAM_CATCHER", "捕梦网", 350, "完成生活活动后，下一轮额外提供一项内容制作候选，仍然只选一项。"),
        new("POTION_BELT", "药水腰带", 120, "正常完成比赛且有剩余药水时，获得 $20—40 纪念展示支持，共 6 次。", 6),
        new("JUZU_BRACELET", "佛珠手链", 300, "每轮至少提供一项生活或社交活动。"),
        new("REGAL_PILLOW", "皇家枕头", 240, "完成生活活动后，为接下来两场正常参赛各提供 1 点失利评分保护；次数不叠加。"),
        new("HAPPY_FLOWER", "开心小花", 200, "每完成三项活动，获得 $30—60 的小额创作回馈。"),
        new("LETTER_OPENER", "开信刀", 300, "每完成三项内容制作，额外增加 20—35 位关注者。"),
        new("PEN_NIB", "钢笔尖", 360, "每完成两项内容制作，额外增加 12—20 位关注者。"),
        new("KUNAI", "苦无", 380, "每完成三次青训支持，为该次培养增加 $200 的训练资源，仍受培养上限约束。"),
        new("SHURIKEN", "手里剑", 360, "每完成三次社区活动，额外增加 20—35 位关注者。"),
        new("CENTENNIAL_PUZZLE", "百年积木", 200, "每赛季首次正常参赛失利后，下次内容制作减免 $100。"),
        new("WINGED_BOOTS", "羽翼之靴", 240, "下一项至少 3 天的活动缩短 1 天，共 3 次；不会缩短至不足 1 天。", 3),
        new("BAG_OF_PREPARATION", "准备背包", 100, "接下来三次内容或社区活动，每次减免 $60。", 3),
        new("SLING_OF_COURAGE", "勇气投石索", 480, "正常赢下进阶 8 及以上的比赛时，额外增加 5—10 位关注者。"),
        new("WHITE_STAR", "白星", 550, "每赛季首次赢下国际赛事，获得 $80—120 的纪念展示支持。"),
        new("JEWELED_MASK", "宝石面具", 260, "首次与某位人物完成社交活动时，好感额外增加 3。"),
        new("GOLDEN_PEARL", "金色珍珠", 500, "商业项目盈利时，额外获得利润的 5%，每次最多 $100。")
    ];
    private static int Roll(CareerData d, string key, int min, int max) => min + CareerEngine.StableHash(d.WorldId + ":figurine:" + key) % (max - min + 1);
    public static bool Has(CareerData d, string id) => d.Life.Figurines.TryGetValue(id, out var s) && !s.Ended;
    private static FigurineState? State(CareerData d, string id) => Has(d, id) ? d.Life.Figurines[id] : null;
    public static bool CanBuy(CareerData d, Item r) => !d.Life.Figurines.TryGetValue(r.Id, out var s) || r.Uses > 0 && s.Uses <= 0;
    public static void Shop(CareerData d)
    {
        // 旧档本期货架只保留原顺序的前四件；购买后不补位，防止同一期连续展示整个库存。
        if (d.Life.Shop.Count > 4) d.Life.Shop = d.Life.Shop.Take(4).ToList();
        if (d.Life.RestockDay > d.Day) return;
        var previous = d.Life.Shop.ToHashSet();
        d.Life.Shop = Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))
            .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)).Take(4).Select(r => r.Id).ToList();
        d.Life.RestockDay = d.Day + 14;
    }
    public static IEnumerable<Item> Offers(CareerData d) => d.Life.Shop.Take(4)
        .Select(id => Catalog.FirstOrDefault(r => r.Id == id)).OfType<Item>();
    public static int PurchasePrice(CareerData d, Item item) => Has(d, "THE_COURIER") ? (item.Price * 85 + 99) / 100 : item.Price;
    public static string Status(CareerData d, Item r)
    {
        var s = d.Life.Figurines[r.Id];
        if (r.Uses > 0 && s.Uses <= 0) return "次数已用完 · 商店再次上架后可重新购买";
        if (s.Ended) return "已留作收藏 · 效果结束";
        if (r.Uses > 0) return $"剩余 {s.Uses} 次";
        if (r.Id == "MAW_BANK") return $"已存入 {CareerMoney.Format(s.Accrued)} · 第 {s.BoughtDay + 14} 天到期";
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
        int end = Math.Min(d.Day, s.BoughtDay + 14);
        for (int day = Math.Max(s.AccrualDay, s.BoughtDay) + 1; day <= end; day++) s.Accrued += Roll(d, "bank:" + day, 1, 2);
        s.AccrualDay = end;
        if (d.Day >= s.BoughtDay + 14) CashBank(d, s);
    }
    private static void CashBank(CareerData d, FigurineState s)
    {
        d.Credits += s.Accrued; CareerMoney.Record(d, "巨口储蓄罐手办取款", s.Accrued); s.Ended = true;
    }
    public static void Spend(CareerData d)
    {
        Advance(d);
        if (State(d, "MAW_BANK") is { } s) CashBank(d, s);
    }
    private static bool Food(LifeActivity a) => a.Title is "地方料理课" or "赛后请客" or "给新人接风";
    private static bool Media(LifeActivity a) => a.Kind is "内容" or "社区";
    // 优惠不作用于投资本金；各项优惠按固定顺序分摊，总额不超过原价的五分之一。
    private static IEnumerable<(string Id, int Amount)> Discounts(CareerData d, LifeActivity a)
    {
        if (a.Kind is "商业" or "事业" or "青训" or "俱乐部") yield break;
        if (Has(d, "MEMBERSHIP_CARD") && a.Kind is "生活" or "社交") yield return ("MEMBERSHIP_CARD", Math.Min(10, a.Cost * 5 / 100));
        if (Food(a) && State(d, "MEAL_TICKET") is { Uses: > 0 }) yield return ("MEAL_TICKET", 5);
        if (Media(a) && State(d, "ANCHOR") is { } anchor && anchor.Season != d.Season) yield return ("ANCHOR", 10);
        if (Media(a) && State(d, "BAG_OF_PREPARATION") is { Uses: > 0 }) yield return ("BAG_OF_PREPARATION", 6);
        if (a.Kind == "内容" && State(d, "CENTENNIAL_PUZZLE") is { Charge: > 0 }) yield return ("CENTENNIAL_PUZZLE", 10);
        if (a.Kind == "内容" && d.Life.Preparation > 0) yield return ("rest", Math.Min(24, a.Cost * 12 / 100));
        if (Media(a) && d.Life.Facilities > 0) yield return ("facilities", Math.Min(24, a.Cost * Math.Min(72, d.Life.Facilities * 24) / 1000));
    }
    public static int Cost(CareerData d, LifeActivity a) => a.Cost - Math.Min(a.Cost / 5, Discounts(d, a).Sum(x => x.Amount));
    public static int Duration(CareerData d, LifeActivity a) => (CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a)) ? 28 : Math.Max(1, a.Duration
        - (a.Kind == "内容" && State(d, "VENERABLE_TEA_SET") is { Charge: > 0 } ? 1 : 0)
        - (a.Duration >= 3 && State(d, "WINGED_BOOTS") is { Uses: > 0 } ? 1 : 0));
    private static void Use(CareerData d, string id)
    {
        var s = d.Life.Figurines[id];
        if (Catalog.First(r => r.Id == id).Uses > 0 && --s.Uses <= 0) s.Ended = true;
    }
    public static void Accept(CareerData d, LifeActivity a)
    {
        int budget = a.Cost / 5;
        foreach (var (id, amount) in Discounts(d, a).ToList())
        {
            int used = Math.Min(budget, amount); if (used <= 0) continue; budget -= used;
            if (id == "rest") { d.Life.Preparation = 0; continue; }
            if (id == "facilities") continue;
            if (id == "ANCHOR") d.Life.Figurines[id].Season = d.Season;
            if (id == "CENTENNIAL_PUZZLE") d.Life.Figurines[id].Charge = 0;
            Use(d, id);
        }
        if (a.Kind == "内容" && State(d, "VENERABLE_TEA_SET") is { Charge: > 0 } tea) tea.Charge = 0;
        if (!CareerTraining.IsTraining(a) && a.Duration >= 3 && State(d, "WINGED_BOOTS") is { Uses: > 0 }) Use(d, "WINGED_BOOTS");
    }
    public static int Training(CareerData d, LifeActivity a)
    {
        if (State(d, "KUNAI") is not { } s || ++s.Count % 3 != 0) return 0;
        a.Result += "苦无手办带来的训练资源增加 $200。"; return 20;
    }
    public static int Business(CareerData d, LifeActivity a, int revenue)
    {
        int delta = revenue - a.Cost;
        if (delta < 0 && State(d, "TUNGSTEN_ROD") is { Uses: > 0 })
        {
            int benefit = Math.Min(15, -delta / 5);
            if (benefit > 0) { Use(d, "TUNGSTEN_ROD"); a.Result += $"钨合金棍手办补回 {CareerMoney.Format(benefit)}。"; return revenue + benefit; }
        }
        if (delta > 0 && Has(d, "GOLDEN_PEARL"))
        { int benefit = Math.Min(10, delta / 20); if (benefit > 0) a.Result += $"金色珍珠手办额外带来 {CareerMoney.Format(benefit)}。"; return revenue + benefit; }
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
                if (State(d, id) is { } s) { s.Charge = id == "REGAL_PILLOW" ? 2 : 1; a.Result += Catalog.First(r => r.Id == id).Name + "手办的效果已准备。"; }
        }
        if (a.Kind == "社交" && a.PersonId.Length > 0 && State(d, "JEWELED_MASK") is { } mask)
        {
            // 旧存档从活动记录恢复领取名单，之后按人物保存，避免好感变化导致重复领取。
            mask.SocialRewards ??= d.Life.Activities.Where(x => x.Result.Contains("宝石面具手办"))
                .Select(x => x.PersonId).ToHashSet();
            if (mask.SocialRewards.Add(a.PersonId))
            { PrivateMessages.ChangeFavour(d, a.PersonId, 3); a.Result += "宝石面具手办：好感额外增加 3。"; }
        }
        if (a.Kind == "内容") { Fans("LETTER_OPENER", 3, 20, 35); Fans("PEN_NIB", 2, 12, 20); }
        if (a.Kind == "社区") Fans("SHURIKEN", 3, 20, 35);
        if (State(d, "HAPPY_FLOWER") is { } flower && ++flower.Count % 3 == 0)
        {
            int amount = Roll(d, a.Id + "flower", 3, 6); d.Credits += amount; CareerMoney.Record(d, "开心小花手办回馈", amount);
            a.Result += $"开心小花手办带来 {CareerMoney.Format(amount)}。";
        }
    }
    public static void Match(CareerData d, CareerMatch m, CareerResult result, bool abandoned, int oldRating)
    {
        if (abandoned) return;
        int protection = 0;
        void Protect(string id, int amount)
        { if (amount <= 0) return; int n = Math.Min(amount, Math.Max(0, Math.Min(3 - protection, oldRating - d.Rating))); if (n <= 0) return;
            d.Rating += n; protection += n; result.LifeEffects.Add(Catalog.First(r => r.Id == id).Name + $"手办：本场少扣 {n} 点生涯评分。"); }
        if (!m.PlayerWon && !m.Draw)
        {
            if (Has(d, "BURNING_BLOOD")) Protect("BURNING_BLOOD", Roll(d, m.Id + "blood", 1, 2));
            if (Has(d, "ORICHALCUM") && !d.Life.Activities.Any(a => a.Status == "进行中")) Protect("ORICHALCUM", 1);
            if (State(d, "REGAL_PILLOW") is { Charge: > 0 }) Protect("REGAL_PILLOW", 1);
            if (State(d, "CENTENNIAL_PUZZLE") is { } puzzle && puzzle.Season != d.Season)
            { puzzle.Season = d.Season; puzzle.Charge = 1; result.LifeEffects.Add("百年积木手办：下次内容制作可减免 $100。"); }
        }
        if (State(d, "REGAL_PILLOW") is { Charge: > 0 } pillow) pillow.Charge--;
        void Cash(string id, int min, int max)
        { int amount = Roll(d, m.Id + id, min, max); d.Credits += amount; result.LifeEffects.Add(Catalog.First(r => r.Id == id).Name + "手办：纪念展示支持 " + CareerMoney.Format(amount) + "。"); }
        if (result.Evidence.PotionsRecorded && result.Evidence.RemainingPotions.Count > 0 && State(d, "POTION_BELT") is { Uses: > 0 })
        { Cash("POTION_BELT", 2, 4); Use(d, "POTION_BELT"); }
        if (m.PlayerWon && m.RequiredAscension >= 8 && Has(d, "SLING_OF_COURAGE"))
        { int n = Roll(d, m.Id + "sling", 5, 10); d.Fans += n; result.LifeEffects.Add($"勇气投石索手办：额外增加 {n} 位关注者。"); }
        if (m.PlayerWon && m.Kind is "continental" or "worldcup" or "worldfinal" or "masters" && State(d, "WHITE_STAR") is { } star && star.Season != d.Season)
        { star.Season = d.Season; Cash("WHITE_STAR", 8, 12); }
    }
}
