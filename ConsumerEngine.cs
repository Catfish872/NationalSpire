namespace NationalSpire;

/// <summary>
/// 消费品与投资 · 引擎（设计文档《消费品与投资-设计.md》§5–§7）。
/// 关键约定（文档 D6 批注）：<b>粉丝在行为完成的那一刻结算</b>，帖子只是事后宣布这件事，不参与发粉。
/// </summary>
public static class ConsumerEngine
{
    public const int Version = 1;
    public const int InviteFavourGate = 5;    // D5：好感 ≥ 5 才能被邀请
    public const int PartnerFavour = 1;       // 同场受邀者彼此 +1
    public const int RepeatFavour = 1;        // 同一人本季重复受邀只 +1
    public const int NpcFanFloor = 8;         // 进人气榜的最低进阶

    // ───────────────────────── 迁移与季节 ─────────────────────────

    public static void Ensure(CareerData d)
    {
        EnsureNpcFans(d);
        ResetSeason(d);
        d.Consumer.Version = Version;
    }

    /// <summary>给所有进阶 ≥ 8 的 NPC 一个初始粉丝（只在缺失时写，不覆盖已有值）。</summary>
    private static void EnsureNpcFans(CareerData d)
    {
        foreach (var p in d.People.Where(p => p.MaxAscension >= NpcFanFloor))
        {
            if (p.Fans > 0) continue;
            int seed = CareerEngine.StableHash(d.WorldId + ":fans:" + p.Id);
            p.Fans = p.MaxAscension >= 9
                ? 400_000 + seed % 600_000
                : 8_000 + Math.Max(0, p.Rating - 1200) * 120 + seed % 60_000;
        }
    }

    /// <summary>换季时清掉"本季已用"的计数：每种动用每件道具每季各 1 次、运营每项每季 3 次。</summary>
    private static void ResetSeason(CareerData d)
    {
        if (d.Consumer.Season == d.Season) return;
        d.Consumer.Season = d.Season;
        foreach (var good in d.Consumer.Goods) { good.UsedVerbs.Clear(); good.UsedSeason = d.Season; }
        d.Consumer.PromoUsed.Clear();
        d.Consumer.InvitedThisSeason.Clear();
        d.Consumer.PromoSeason = d.Season;
        d.Consumer.DropSettled.RemoveWhere(x => !x.StartsWith(d.Season + ":", StringComparison.Ordinal));
    }

    public static void SeasonStart(CareerData d)
    {
        Ensure(d);
        NpcSeasonGrowth(d);
    }

    /// <summary>NPC 按自己的战绩（评分 / 胜场 / 冠军数）涨粉，确定性、不用随机数引擎。</summary>
    private static void NpcSeasonGrowth(CareerData d)
    {
        foreach (var p in d.People.Where(p => p.MaxAscension >= NpcFanFloor))
        {
            int seed = CareerEngine.StableHash($"{d.WorldId}:{d.Season}:npcfans:{p.Id}");
            int gain = Math.Max(0, p.Rating - 1_100) * 30 + p.Wins * 120 + p.Titles * 25_000 + seed % 4_000;
            if (p.MaxAscension >= 9) gain = gain * 3 / 2;
            p.Fans += gain;
        }
    }

    // ───────────────────────── 粉丝刻度 ─────────────────────────

    /// <summary>8 段刻度（只用于内部对齐与界面分档，不显示"段"这个字）。</summary>
    private static readonly long[] SegmentFloor = [0, 1_000, 5_000, 20_000, 100_000, 500_000, 2_000_000, 10_000_000, 50_000_000];
    public static int SegmentOf(long fans) { int s = 1; for (int i = 1; i < SegmentFloor.Length; i++) if (fans >= SegmentFloor[i]) s = i; return s; }
    public static string SegmentLabel(long fans) => SegmentOf(fans) switch
    {
        1 => "社区小有名气", 2 => "城市赛级", 3 => "职业新人", 4 => "联赛主力",
        5 => "明星选手", 6 => "洲际级明星", 7 => "世界级偶像", _ => "传奇"
    };

    /// <summary>粉丝档 0–4（5.5 的收益阶梯）。</summary>
    public static int MoneyTier(long fans) => fans >= 2_000_000 ? 4 : fans >= 500_000 ? 3 : fans >= 100_000 ? 2 : fans >= 20_000 ? 1 : 0;
    /// <summary>赞助报价倍率（5.5）。</summary>
    public static double QuoteMultiplier(long fans) => new[] { 1.00, 1.15, 1.35, 1.60, 2.00 }[MoneyTier(fans)];
    /// <summary>商业活动回款加成的百分点（只吃粉丝档，不吃冠军数）。</summary>
    public static int CommercialBonus(long fans) => new[] { 0, 3, 6, 10, 15 }[MoneyTier(fans)];

    /// <summary>帖子里统一用这句宣布涨粉（D6：行为完成时就已结算）。</summary>
    public static string FanLine(int delta) => delta > 0 ? $"粉丝 +{delta:N0}。" : delta < 0 ? $"粉丝 −{Math.Abs((long)delta):N0}。" : "";

    // ───────────────────────── 赛事：涨粉与掉粉 ─────────────────────────

    /// <summary>单场胜/平/负的粉丝变化（D14/D17）。返回实际变化量；掉粉只在"未通关且输"时发生。</summary>
    public static int MatchFans(CareerData d, CareerMatch m, bool cleared, bool forfeit, int floor, double multiplier)
    {
        if (forfeit) return 0;
        if (m.PlayerWon)
        {
            int gain = MatchRules.Reward(MatchFanBase(m.Kind), multiplier);
            d.Fans += gain; return gain;
        }
        if (m.Draw)
        {
            int gain = MatchRules.Reward(MatchFanBase(m.Kind) * 2 / 5, multiplier);
            d.Fans += gain; return gain;
        }
        if (cleared) return 0;            // 通关了但输给更快的对手 → 不掉粉
        return FanDrop(d, m);             // 未通关且输
    }

    public static int MatchFanBase(string kind) => kind switch
    {
        "league" => 600, "continental" => 2_000, "worldcup" => 2_000, "worldfinal" => 5_000,
        "masters" => 1_500, "open" => 800, "academy" => 600, "city" => 400, "local" => 200, _ => 300
    };

    /// <summary>掉粉：联赛固定 300–1,000（越早越多）；杯赛按出局轮次，首轮 1% 封顶。</summary>
    private static int FanDrop(CareerData d, CareerMatch m)
    {
        if (m.Kind == "private-friendly" || m.Kind == "private-challenge") return 0;   // 私人约战不惩罚
        string token = $"{d.Season}:{m.Kind}";
        if (!d.Consumer.DropSettled.Add(token)) return 0;                               // 每赛季每类赛事只结算一次
        int drop;
        if (m.Kind == "league")
        {
            int total = RoundCountOf(d, m, 5);
            drop = Math.Clamp(300 + (total - Math.Max(1, m.Round)) * 150, 300, 1_000);
        }
        else
        {
            if (m.CompetitionId.Length == 0) { d.Consumer.DropSettled.Remove(token); return 0; }
            int total = RoundCountOf(d, m, 4);
            int round = Math.Max(1, m.Round);
            double rate = round <= 1 ? 0.010 : round == 2 ? 0.005 : round >= total ? 0.0015 : 0.001;
            drop = (int)Math.Round(d.Fans * rate, MidpointRounding.AwayFromZero);
        }
        int floor = (int)(d.Fans * 0.9);                                                // 兜底线：一次暴毙不清零
        drop = Math.Clamp(drop, 0, Math.Max(0, d.Fans - floor));
        d.Fans -= drop;
        return -drop;
    }

    private static int RoundCountOf(CareerData d, CareerMatch m, int fallback)
    {
        var competition = d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId);
        return competition == null ? fallback : CircuitWorld.RoundCount(competition);
    }

    /// <summary>奖杯与里程碑（D14：全部固定整数）。用里程碑原文里的量级做兜底，只覆盖已知的四类奖杯。</summary>
    public static int TrophyFans(string id, string title, int fallback)
    {
        if (id.Contains("worldfinal", StringComparison.Ordinal) || title.Contains("世界总决赛", StringComparison.Ordinal)) return 1_000_000;
        if (title.Contains("世界杯", StringComparison.Ordinal)) return 500_000;
        if (title.Contains("洲际", StringComparison.Ordinal)) return 150_000;
        if (title.Contains("联赛", StringComparison.Ordinal) && title.Contains("冠军", StringComparison.Ordinal)) return 100_000;
        return fallback;
    }

    /// <summary>颁奖礼（D15：只有 MVP 三类走百分比，奖杯固定整数）。返回给玩家的粉丝数。</summary>
    public static int AwardFans(CareerData d, string title)
    {
        if (title.StartsWith("年度最佳选手", StringComparison.Ordinal)) return Percent(d, 0.50, 800_000);
        if (title.StartsWith("赛季最佳选手", StringComparison.Ordinal)) return Percent(d, 0.12, 500_000);
        if (title.EndsWith("MVP", StringComparison.Ordinal)) return Percent(d, 0.08, 300_000);
        if (title.StartsWith("赛季最佳新秀", StringComparison.Ordinal)) return 200_000;
        if (title.StartsWith("年度最佳新秀", StringComparison.Ordinal)) return 300_000;
        return 0;   // 俱乐部类奖项不给个人粉丝
    }

    private static int Percent(CareerData d, double rate, int floorValue) => Math.Max(floorValue, (int)Math.Round(d.Fans * rate, MidpointRounding.AwayFromZero));

    /// <summary>生活 / 社交活动的粉丝（旧公式 ×20，落到新尺子）。</summary>
    public static int LifeActivityFans(int legacyAmount) => legacyAmount * 20;

    // ───────────────────────── 购买 ─────────────────────────

    public static string? BuyError(CareerData d, Good good)
    {
        int price = good.Price;
        if (CareerMoney.Balance(d) < price / 10) return "当前资金不足。";
        if (good.Promo)
        {
            if (d.Consumer.PromoUsed.GetValueOrDefault(good.Id) >= ConsumerCatalog.PromoPerSeason) return $"{good.Name}本赛季已经做过 {ConsumerCatalog.PromoPerSeason} 次，下一赛季再来。";
            return null;
        }
        if (good.Durable)
        {
            if (d.Consumer.Goods.Any(g => g.Id == good.Id && g.Durable)) return "这件已经在你名下了。";
            return null;
        }
        if (!d.Consumer.BoughtDay.TryGetValue(good.Id, out int day)) return null;
        if (good.Repeatable) return d.Day - day < ConsumerCatalog.RepeatCooldown ? $"这类体验每月一次（还有 {ConsumerCatalog.RepeatCooldown - (d.Day - day)} 天）。" : null;
        return d.Consumer.Goods.Any(g => g.Id == good.Id && g.Season == d.Season) ? "这类消费品每赛季限购一次。" : null;
    }

    /// <summary>购买：只发帖（D18：普通购买不涨粉，只有宣发涨粉）。
    /// Slots &gt; 0 的商品可以带人（最多 Slots 个），名单会进帖子与相关人物；不允许带人时传空。</summary>
    public static string? Buy(CareerData d, string id, IReadOnlyList<string>? invitees = null)
    {
        var good = ConsumerCatalog.Get(id);
        if (good == null) return "找不到这件商品。";
        if (BuyError(d, good) is { } error) return error;
        // 先校验再截断：不能把塞进来的人静默丢掉（Take(0) 会假装没这回事）。
        var invited = (invitees ?? []).ToList();
        if (invited.Count > 0 && good.Slots == 0) return ConsumerText.PromoGuard;
        var guests = invited.Take(good.Slots).ToList();
        if (guests.Count > 0 && guests.Any(g => PrivateMessages.Favour(d, g) < InviteFavourGate)) return ConsumerText.InviteNothing;
        int price = good.Price / 10;                                  // 内部单位
        // D18：只有宣发（运营）涨粉；普通购买只发一条"我买了什么"的帖子，粉丝不动。
        int fans = good.Promo ? (int)Math.Round(d.Fans * PromoPercent(good.Id) / 100.0, MidpointRounding.AwayFromZero) : 0;
        d.Credits -= price;
        CareerMoney.Record(d, good.Name, -price);
        d.Consumer.BoughtDay[good.Id] = d.Day;
        d.Consumer.LifetimeSpent += price;
        d.Consumer.PurchaseCount++;
        if (good.Promo)
        {
            d.Consumer.PromoUsed[good.Id] = d.Consumer.PromoUsed.GetValueOrDefault(good.Id) + 1;
            d.Consumer.PromoSeason = d.Season;
        }
        else
        {
            d.Consumer.Goods.Add(new() { Id = good.Id, Name = good.Name, BoughtDay = d.Day, Season = d.Season, Price = price, Durable = good.Durable, Consumed = !good.Durable, UsedSeason = d.Season });
        }
        d.Fans += fans;
        PublishPurchase(d, good, fans, guests);
        CareerStore.Save(d);
        return null;
    }

    public static int PromoPercent(string id) => id switch { "hotsearch" => 10, "fandom" => 3, "promo" => 8, "interview" => 15, _ => 5 };

    private static void PublishPurchase(CareerData d, Good good, int fans, List<string> guests)
    {
        string name = CareerEngine.Name(d);
        string title, body, category;
        if (good.Promo)
        {
            // D20：宣发帖软化——像一件小事偶然上了热搜，不写"买/投放/宣发"，不指认玩家。
            string topic = ConsumerText.PromoTopic(good.Id);
            title = ConsumerText.PromoTitle(topic);
            body = ConsumerText.PromoPost(name, d.Day, topic, fans);
            category = "热搜";
        }
        else
        {
            string price = $"${good.Price:N0}";
            var names = guests.Select(g => CareerEngine.DisplayName(d, g)).ToList();
            title = $"{name} · {good.Name}";
            body = names.Count > 0
                ? ConsumerText.PurchasePostWith(name, d.Day, good.Name, price, string.Join("、", names))
                : ConsumerText.PurchasePost(name, d.Day, good.Name, price);
            category = "消费与生活";
        }
        CareerEngine.Publish(d, $"shop-{good.Id}-{d.Day}", title, body, category, true, ["player", .. guests]);
    }

    // ───────────────────────── 使用（耐用品）─────────────────────────

    public static OwnedGood? Find(CareerData d, string id) => d.Consumer.Goods.FirstOrDefault(g => g.Id == id);

    public static GoodVerb? Verb(string id, string verbId) => ConsumerCatalog.Get(id)?.Verbs.FirstOrDefault(v => v.Id == verbId);

    /// <summary>本季还能动用几次（每种动词各 1 次）。</summary>
    public static int VerbsLeft(CareerData d, OwnedGood good)
    {
        Ensure(d);
        var def = ConsumerCatalog.Get(good.Id);
        if (def == null) return 0;
        return def.Verbs.Count(v => !good.UsedVerbs.Contains(v.Id));
    }

    /// <summary>可邀请名单：所有好感 ≥ 门槛的人（不限于职业选手）。本队成员优先，其次按名气。</summary>
    public static List<CareerPerson> InviteCandidates(CareerData d) => d.People
        .Where(p => p.Id != "player" && PrivateMessages.Favour(d, p.Id) >= InviteFavourGate)
        .OrderByDescending(p => p.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId)
        .ThenByDescending(p => p.Fans).ToList();

    /// <summary>使用一件耐用品：扣招待费、加好感、发帖。invitees 超过 Slots 会被截断。**不涨粉**（D18：只有宣发涨粉）。</summary>
    public static string? Use(CareerData d, string goodId, string verbId, IReadOnlyList<string> invitees)
    {
        var good = Find(d, goodId);
        if (good == null || !good.Durable) return ConsumerText.UseWrongObject;
        var def = ConsumerCatalog.Get(goodId);
        if (def == null) return ConsumerText.UseGone;
        var verb = Verb(goodId, verbId);
        if (verb == null) return ConsumerText.UseNoSuchVerb;
        Ensure(d);
        if (good.UsedVerbs.Contains(verb.Id)) return ConsumerText.UseAlreadyUsed(verb.Name);
        var selected = invitees.Take(verb.Slots).ToList();
        if (selected.Any(id => PrivateMessages.Favour(d, id) < InviteFavourGate)) return ConsumerText.InviteNothing;
        int fee = HospitalityFee(def);
        if (CareerMoney.Balance(d) < fee / 10) return ConsumerText.UseFeeShort($"${fee:N0}");
        d.Credits -= fee / 10;
        CareerMoney.Record(d, good.Name + " · " + verb.Name + "招待费", -(fee / 10));
        good.UsedVerbs.Add(verb.Id);
        good.UsedSeason = d.Season;
        d.Consumer.PartyCount++;
        foreach (string id in selected)
        {
            int count = d.Consumer.InvitedThisSeason.GetValueOrDefault(id);
            PrivateMessages.ChangeFavour(d, id, count == 0 ? verb.Favor : RepeatFavour);
            d.Consumer.InvitedThisSeason[id] = count + 1;
        }
        var names = selected.Select(id => CareerEngine.DisplayName(d, id)).ToList();
        // D18：动用只给好感与帖子，不涨粉。
        string guests = names.Count > 0 ? $"{names.Count} 人：{string.Join("、", names)}" : "没有别人（就自己一个）";
        string body = ConsumerText.PartyPost(CareerEngine.Name(d), d.Day, good.Name, verb.Name, guests, $"${fee:N0}", verb.Favor);
        CareerEngine.Publish(d, $"party-{good.Id}-{verb.Id}-{d.Season}", $"{CareerEngine.Name(d)} 的{good.Name} · {verb.Name}", body, "消费与生活", true, ["player", .. selected]);
        CareerStore.Save(d);
        return null;
    }

    /// <summary>招待费梯度：大众 1,000 / 中产 2,000 / 富裕 5,000 / 顶奢 10,000。</summary>
    public static int HospitalityFee(Good good) => good.Tier switch
    {
        ConsumerCatalog.Mass => 1_000, ConsumerCatalog.Middle => 2_000, ConsumerCatalog.Rich => 5_000, ConsumerCatalog.Luxury => 10_000, _ => 5_000
    };

    // ───────────────────────── 人气榜 ─────────────────────────

    public sealed record ChartRow(string Id, string Name, long Fans, bool Player, string Club);

    public static List<ChartRow> Chart(CareerData d)
    {
        Ensure(d);
        var rows = d.People.Where(p => p.MaxAscension >= NpcFanFloor)
            .Select(p => new ChartRow(p.Id, p.PublicName, p.Fans, false, p.ClubId.Length > 0 ? EsportsWorld.ClubName(d, p.ClubId) : ""))
            .ToList();
        rows.Add(new ChartRow("player", CareerEngine.Name(d), d.Fans, true, d.Esports.ClubId.Length > 0 ? EsportsWorld.ClubName(d, d.Esports.ClubId) : ""));
        return rows.OrderByDescending(r => r.Fans).ThenBy(r => r.Id, StringComparer.Ordinal).ToList();
    }

    public static int Rank(CareerData d) => Chart(d).FindIndex(r => r.Player) + 1;

    /// <summary>每月一条人气榜帖（D8：榜位只是荣誉，不影响任何收益）。</summary>
    public static void ChartPost(CareerData d)
    {
        if (d.Day % ConsumerCatalog.RepeatCooldown != 0) return;
        var rows = Chart(d);
        int rank = rows.FindIndex(r => r.Player) + 1;
        var me = rows[rank - 1];
        var ahead = rank > 1 ? rows[rank - 2] : null;
        string top = string.Join("、", rows.Take(3).Select((r, i) => $"{i + 1}. {r.Name}（{r.Fans:N0}）"));
        string body = $"第 {d.Season} 赛季第 {d.Day} 天人气榜。前三：{top}。{CareerEngine.Name(d)} 排在第 {rank} 名，粉丝 {me.Fans:N0}"
            + (ahead != null ? $"，距离第 {rank - 1} 名的 {ahead.Name} 还差 {ahead.Fans - me.Fans:N0}。" : "，目前是榜首。");
        d.Consumer.LastChartRank = rank;
        d.Consumer.LastChartLine = body;
        CareerEngine.Publish(d, $"chart-{d.Day}", $"人气榜 · 第 {d.Season} 赛季第 {d.Day} 天", body, "人气榜", true, ["player"]);
    }

    /// <summary>日期推进时的钩子：到 28 天倍数就发人气榜。</summary>
    public static void DailyTick(CareerData d)
    {
        if (d.Esports.EcosystemVersion < 1) return;
        ChartPost(d);
    }
}
