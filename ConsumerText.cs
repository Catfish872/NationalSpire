namespace NationalSpire;

/// <summary>
/// 消费品与投资的**全部文案**集中在这里，方便直接改写（逻辑在 ConsumerEngine / ConsumerScreen）。
/// 改文案不用碰任何逻辑；插值用 {人} {队} {地} {价} {粉} 等占位符，由调用方填。
/// 其它系统的文案位置见文末注释。
/// </summary>
public static class ConsumerText
{
    // ── 商城页 ──
    public const string ShopTitle = "商城";
    public const string ShopIntro = "消费主义圣地，买下物品后会自动发帖告诉大家。耐用品买下之后还能使用。";
    public static string ShopBalance(string money, long fans, string segment, int purchases) => $"可用资金 {money} · 粉丝 {fans:N0}（{segment}）· 本季已消费 {purchases} 笔";
    public const string OwnedTitle = "已持有 · 可以使用";
    public static string OwnedLeft(string name, int left) => $"{name} · 本季还有 {left} 种使用可用";
    public static string VerbLine(string verb, int slots, int favor, string fee) => $"{verb} · 最多 {slots} 人 · 每人好感 +{favor} · 招待费 {fee}";
    public const string VerbUsed = "本赛季已用过";
    public const string VerbOpen = "邀请并使用";

    // ── 档位说明（每个档位一行）──
    public const string TierMassHint = "大众：随手可买的小东西，每件每赛季限购一次。";
    public const string TierMiddleHint = "中产：小公寓、私家车之类的资产和一次令人放松的旅行。";
    public const string TierRichHint = "富裕：豪宅等奢侈资产。部分资产在购入后还能解锁相应功能，如招待客人增进关系。";
    public const string TierLuxuryHint = "顶奢：真正的奢侈。价格决定大多数人对它只能仰望。";
    public const string TierPromoHint = "宣发：每项每赛季最多 3 次。买粉炒热度需谨慎。";

    // ── 商品卡状态行 ──
    public const string MassState = "一次性消费品 · 每赛季限购一次";
    public static string RepeatState(int cooldown) => $"体验类 · 每 {cooldown} 天可以再买一次 ";
    public const string DurableState = "耐用品 · 可以反复使用";
    public static string PromoState(int left, int percent) => $"本季还剩 {left} 次炒作机会 · 涨粉 = 当前粉丝的 {percent}%";
    public static string DurableVerbs(string joined) => "使用：" + joined;
    public static string VerbSlot(string name, int slots) => slots > 1 ? $"{name}（{slots} 人）" : $"{name}（1 人）";
    public static string BuyWith(int slots) => $"邀请一起（最多 {slots} 人）";
    public const string Buy = "买了！";

    // ── 帖子正文（发帖是唯一目的；粉丝只在宣发时结算）──
    public static string PurchasePost(string name, int day, string good, string price) =>
        $"第 {day} 天，{name} 买下了{good}（{price}）。";
    public static string PurchasePostWith(string name, int day, string good, string price, string guests) =>
        $"第 {day} 天，{name} 和 {guests} 一起，{good}（{price}）。";

    // ── 宣发类（D20）：四个宣传项都要软化 ──
    // 规则：帖子读起来要像"一件小事偶然被大家讨论起来"，不能出现"买/投放/宣发"字样，
    //      也不能让玩家成为始作俑者（读者必须看不出这是买的）。
    public static string PromoTopic(string id) => id switch
    {
        "hotsearch" => "一段几个月前的旧视频被重新翻了出来",
        "fandom" => "几条粉丝自发剪的应援视频",
        "promo" => "训练室里流出的一段花絮",
        "interview" => "一篇旧采访里的一句话被截了图",
        _ => "一件没人说得清的小事"
    };
    public static string PromoTitle(string topic) => $"热搜 · {topic}";
    public static string PromoPost(string name, int day, string topic, long fans) =>
        $"第 {day} 天，{topic}，评论区从下午吵到深夜，话题就这么挂上了热搜。{name} 本人没有回应。粉丝 +{fans:N0}。";
    public static string PromoGuard = "这件东西不适合带人一起去。";
    public static string PartyPost(string name, int day, string good, string verb, string guests, string fee, int favour) =>
        $"第 {day} 天，{name} 在{good}{verb}，来了 {guests}。招待费 {fee}，每人好感 +{favour}。";

    // ── 邀请 / 选对象 ──
    public const string PickerTitleSuffix = " · 选择对象";
    public const string PickerIntro = "列表把本队成员排在前面；也可以用搜索框按 ID、姓名、国家或俱乐部找。";
    public const string PickerSearchHint = "搜索昵称或姓名（全世界）";
    public const string PickerPick = "选这个人";

    // ── 「为什么不能选他」的每条理由（引擎与界面共用，见 CareerLife.TargetBlockers）──
    // 注意：**国籍不是限制**，所以这里没有"不同国"这一条。
    public const string BlockerSelf = "这是你自己";
    public const string BlockerNotInClub = "不在你的俱乐部";
    public const string BlockerNotProfessional = "不是职业选手";
    public const string BlockerNotYouth = "不是青训选手";
    public static string BlockerFavour(int gate) => PickerNotFamiliar(gate);
    public static string BlockedBy(string reasons) => "不可选：" + reasons;
    public const string NoEligibleTarget = "现在没有既符合条件、又足够熟悉的人。先做几次社交活动，或者先把他招进俱乐部。";
    public const string NoTargetNeeded = "这项安排作用于全员，不需要指定对象。";
    /// <summary>好感不足时的行内说明（阈值跟着引擎走，避免写死后失同步）。</summary>
    public static string PickerNotFamiliar(int gate) => $"还不熟（好感＜{gate}）";
    public const string PickerEmpty = "没有匹配的人。";
    public static string InviteIntro(int slots, int gate, int favour) =>
        $"最多邀请 {slots} 人（好感 ≥ {gate} 才能请动）。每人好感 +{favour}，同赛季重复邀请只 +1。";
    public static string BuyInviteIntro(int slots, int gate) =>
        $"最多带 {slots} 人一起（好感 ≥ {gate} 才能请动）。他们的名字会出现在这条帖子里。";
    public static string InviteFee(string fee) => $"招待费 {fee}";
    public static string InviteChosen(int chosen, int slots) => $"已选 {chosen} / {slots}";
    public const string InviteEmptyHint = "不邀请任何人也可以（自己一个人也算一次使用）。";
    public const string InviteNothing = "你们还不熟，请先把关系处起来。";

    // ── 使用耐用品时的提示（统一叫「使用」，不叫「动用」）──
    public const string UseWrongObject = "这件东西不能这样使用。";
    public const string UseGone = "这件东西已经不在目录里。";
    public const string UseNoSuchVerb = "没有这种使用方式。";
    public static string UseAlreadyUsed(string verb) => $"本赛季这种使用已经用过了（{verb}）。";
    public static string UseFeeShort(string fee) => $"招待费需要 {fee}。";

    // ── 人气榜 ──
    public const string ChartTitle = "人气榜";
    public static string ChartIntro(int others) => $"全世界进阶 8 以上的 {others} 位选手都在这一张榜上；每位真正的粉丝都会为自家idol打榜，不管ta们愿不愿意。";
    public static string ChartMine(int rank, int total, long fans, string segment) => $"你的名次：第 {rank} / {total} 名 · 粉丝 {fans:N0} · {segment}";
    public const string ChartNearby = "你附近";
    public const string ChartRecent = "最近一期：";

    // ── 活动市场（赛场之外）──
    public const string MarketTitle = "市场";
    public static string MarketIntro(bool trading) => "下面是全部可选安排。"
        + (trading ? "训练与经营类：同一类别每月只能有一项在进行中。" : "娱乐与消费类：可以一次安排多项。");
    public const string MarketOrder = "下单！";
    public const string MarketPickOrder = "选择对象并下单";
    public static string MarketPrice(string money, int days, bool longProject) => $"费用 {money} · {days} 天" + (longProject ? " · 长期项目" : "");
    public const string NewOffersTitle = "";    // 原版"新出现的安排"已停用（D13 全面市场化）

    /// <summary>市场列表里还没选对象时，把占位符换成能读的词。</summary>
    public static string Generic(string text) => text.Replace("{人}", "指定对象").Replace("{队}", "你的战队").Replace("{地}", "当地");
}

// ─────────────────────────────
// 其它文案位置（要改直接改这些文件）：
//   * 105 条活动标题 / 目的 / 结果      → LifeCatalog.cs（Build 里的 Group 行，格式 `标题|目的|结果`）
//   * 活动效果文案（点开安排时那句）    → CareerLife.Expected
//   * 手办 26 款名称与效果              → CareerRelics.Catalog
//   * 消费帖以外的社区帖模板            → CareerNarrative.cs
//   * 国运 / 人均 GDP 相关叙述          → NationalDevelopment.cs
//   * 比赛战报措辞                      → MatchRules.Report
// ─────────────────────────────
