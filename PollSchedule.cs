namespace NationalSpire;

/// <summary>投票类型。每种有自己的触发条件与票型规律。</summary>
public enum PollKind
{
    MatchWinner,    // 赛前：这场谁会赢
    StreakEnd,      // 赛前：连胜终结（半决赛 + 连胜 > 5）
    TitleRace,      // 赛前/进程：这届谁夺冠（八强起）
    RaiseStake,     // 赛前：抬进阶值不值
    Revenge,        // 赛前：能赢回来吗
    CivilWar,       // 赛前：内战更想看谁赢
    DeckWorth,      // 赛后：这套牌组值不值得抄
    BiggestUpset,   // 进程：这场算爆冷吗
    ShouldEnter,    // 资格：该不该去打
    TransferWorth,  // 转会：这笔转会值不值
    WorldLifePick,  // 日常：你更想看他分享哪种日常
    TournamentUpset,// 进程：这届/这轮最意外的是谁
    HonorWeight,    // 里程碑：这份荣誉含金量够不够
    SeasonOutlook,  // 赛季：这赛季能走多远
    NextMove,       // 生涯：下一步该做什么
    NationalStrength,// 国际赛：哪国最强
}

/// <summary>程序定好的问题与选项。票数与总结由 AI 在同一次生成里给。</summary>
public sealed record PollAsk(string Question, List<string> Options);

/// <summary>
/// 社区投票的类型判定与调度。
///
/// 两条设计原则：
///   ① 投票不一定是预测 —— 评价类与判断类在事后同样成立。
///   ② 只有「靠可见数据就能形成意见」的问题才成立 ——
///      AI 只有数据、没看过对局过程，所以「哪一关最精彩」这类一律不做。
///
/// 调度才是真正的闸门：多个触发条件恒真（玩家几乎每场都抬进阶、
/// 通关必有牌组），「条件满足即触发」会让每场战报都带投票。
/// 所以条件是**候选资格**，密度上限才决定发不发。
/// </summary>
public static class PollSchedule
{
    /// <summary>近 7 天最多几帖带投票。这是决定产出量的唯一旋钮。</summary>
    public const int MaxPerWeek = 2;

    /// <summary>两次投票贴之间至少间隔的天数。</summary>
    public const int CooldownDays = 1;

    /// <summary>连续抬段多少次才算「反复抬」。</summary>
    public const int RaiseStreakMin = 3;

    /// <summary>对手高出多少分才算「越级挑战」。</summary>
    public const int RaiseGapMin = 100;

    /// <summary>连胜多少场才算「在连胜」。</summary>
    public const int StreakMin = 6;

    /// <summary>双方评分差超过这个值就没有悬念，不发对战类投票。</summary>
    public const int GapMax = 80;

    /// <summary>「排名前列」的门槛：本国前 N / 世界前 N。</summary>
    public const int TopDomestic = 10;
    public const int TopWorld = 10;

    // ---------- 轮次 ----------

    /// <summary>各赛事总轮数，与 CircuitWorld.RoundCount 同构。</summary>
    public static int RoundCount(string kind) => kind switch
    {
        "worldfinal" => 5,
        "worldcup" => 3,
        "league" => 3,
        _ => 4,
    };

    /// <summary>淘汰赛的最后两轮才算半决赛 / 决赛；联赛没有淘汰赛。</summary>
    public static bool IsSemifinal(string kind, int round) => kind != "league" && round == RoundCount(kind) - 1;
    public static bool IsFinal(string kind, int round) => kind != "league" && round == RoundCount(kind);

    /// <summary>
    /// 该轮开打时还剩多少人：1=决赛，2=半决赛，4=八强。
    ///
    /// 轮次编号在不同赛事里含义不同（世界总决赛八强是第 3 轮、
    /// 世界杯八强是第 1 轮），所以**比剩余人数**才是跨赛事可比的口径。
    /// </summary>
    public static int EntrantsAt(string kind, int round) => 1 << (RoundCount(kind) - round + 1);

    /// <summary>八强或更后（八强、半决赛、决赛）。</summary>
    public static bool IsQuarterfinalsOrLater(string kind, int round)
        => IsKnockout(kind) && EntrantsAt(kind, round) <= 8;

    private static readonly string[] KnockoutKinds = ["worldfinal", "worldcup", "continental", "masters"];
    public static bool IsKnockout(string kind) => KnockoutKinds.Contains(kind);

    // ---------- 权重 ----------

    /// <summary>话题强度。稀有、层级高、争议强的话题排前面。</summary>
    public static int Weight(PollKind kind) => kind switch
    {
        PollKind.StreakEnd => 100,      // 最稀有
        PollKind.TitleRace => 90,
        PollKind.RaiseStake => 85,
        PollKind.DeckWorth => 80,       // 唯一的赛后类型
        PollKind.BiggestUpset => 70,
        PollKind.Revenge => 65,
        PollKind.ShouldEnter => 60,
        PollKind.CivilWar => 55,
        PollKind.TransferWorth => 40,
        PollKind.WorldLifePick => 35,
        PollKind.TournamentUpset => 65,
        PollKind.HonorWeight => 50,
        PollKind.SeasonOutlook => 55,
        PollKind.NextMove => 45,
        PollKind.NationalStrength => 75,     // 国家类话题很强，必然阵营对撞
        _ => 20,                        // MatchWinner 太基础，容易腻
    };

    // ---------- 调度 ----------

    /// <summary>取某帖的**帖级**投票（程序自动发起的那种）。回复级投票用 <see cref="OfReply"/>。</summary>
    ///
    /// **已作废的帖子视同没有投票。**
    ///
    /// 原因：`PublicationBacklog.Select` 每个 Topic 只留一条，落选的帖被
    /// `AiService` 标成 `superseded` 且 `AiPending = false` —— 它永远不会生成，
    /// 也不会进任何 AI 请求，票数因此永远是 0。
    ///
    /// 更麻烦的是上游有个**整批连坐**：`AiService` 发现批次里有 `superseded`
    /// 就把整批一起作废。并发的生成请求各自重筛 backlog，会把在飞的帖子挤掉，
    /// 所以「建了票、注入成功、进了批次」的帖子也可能被作废（实测遇到）。
    ///
    /// 这是上游的调度机制，改不动；但**我的查询层不该把它当成一个投票**——
    /// 界面上显示「该投票已作废」既多余又误导，直接当作没有即可。
    public static CommunityPoll? Of(CareerData d, CommunityPost post)
        => post == null || post.NewsGeneration.State == "superseded"
            ? null
            : d.Polls.FirstOrDefault(p => p.PostId == post.Id && p.ReplyId.Length == 0);

    /// <summary>取某条回复上的投票（玩家发起）。</summary>
    public static CommunityPoll? OfReply(CareerData d, CommunityReply reply)
        => reply == null ? null : d.Polls.FirstOrDefault(p => p.ReplyId == reply.Id);

    /// <summary>某帖相关的全部投票（含帖级与各回复级），供列表页统计。</summary>
    public static List<CommunityPoll> ForPost(CareerData d, CommunityPost post)
    {
        if (post == null) return [];
        var ids = post.Replies.Select(r => r.Id).ToHashSet();
        return d.Polls.Where(p => p.PostId == post.Id || ids.Contains(p.ReplyId)).ToList();
    }

    /// <summary>
    /// 选出当天最该带投票的那一帖。**纯函数，不写存档、不碰 Godot**，便于测试。
    /// 返回 null 表示当天没有合适的候选。
    /// </summary>
    public static (PollKind Kind, CommunityPost Post, PollAsk Ask)? Select(CareerData d)
    {
        var today = d.Posts.Where(p => p.Day == d.Day).ToList();
        if (today.Count == 0) return null;

        var candidates = new List<(PollKind Kind, CommunityPost Post, PollAsk Ask)>();
        foreach (var post in today) Collect(d, post, candidates);
        if (candidates.Count == 0) return null;

        return candidates.OrderByDescending(c => Weight(c.Kind)).First();
    }

    /// <summary>
    /// 每次有新帖产生后调用。按**当天全部帖子**重新评估，取权重最高的候选；
    /// 若当天已有投票而新候选更强，则替换掉。
    ///
    /// 为什么要「重评」而不是「先到先得」：一天的帖子是分批产生的
    /// （日常帖在日推进时，战报帖在比赛结算时），先来的可能权重很低，
    /// 会把名额占掉，让更好的话题失去机会。
    /// </summary>
    public static int Run(CareerData d)
    {
        var best = Select(d);
        if (best == null) return 0;
        var (kind, post, ask) = best.Value;

        // 选项不足 2 个的候选直接丢弃：投出去也是非法投票（IsValid 为 false，
        // 注入会静默返回 null，界面上却显示一个 0 票的空壳）。
        // 这是对**所有**类型的兜底 —— 触发条件的辅助函数各自也该自查，但不能只靠它们。
        if (ask.Options.Count < 2 || ask.Options.Any(string.IsNullOrWhiteSpace)) return 0;

        var todayIds = d.Posts.Where(p => p.Day == d.Day).Select(p => p.Id).ToHashSet();
        // 只看**帖级**投票：玩家发起的回复级投票不参与调度，也不该挡住自动投票
        var existing = d.Polls.FirstOrDefault(x => todayIds.Contains(x.PostId) && x.ReplyId.Length == 0);
        if (existing != null)
        {
            // 当天已有自动投票：只在新的更强时才替换
            if (!Enum.TryParse<PollKind>(existing.Kind, out var had)) return 0;
            if (Weight(kind) <= Weight(had)) return 0;
            d.Polls.Remove(existing);
        }
        else if (!CanPublish(d)) return 0;

        d.Polls.Add(new CommunityPoll
        {
            PostId = post.Id,
            ReplyId = "",
            Kind = kind.ToString(),
            Scale = ScaleFor(d, post),
            Question = ask.Question,
            Options = ask.Options,
            Votes = ask.Options.Select(_ => 0).ToList(),
        });

        // PollLog 不在这里维护 —— 见 Prune：它按现存有效投票重算，
        // 这样帖子被上游作废时额度会自动退回。
        Prune(d);
        CareerStore.Save(d);
        Diagnostics.Record("poll", $"投票贴：{kind}「{ask.Question}」← {post.EventKey}");
        return 1;
    }

    /// <summary>
    /// 每天推进时调用。清掉作废帖的投票，并按现存有效投票重算额度。
    ///
    /// 为什么必须每天跑：建票点（`Publish`）只在当天有新帖时才触发，
    /// 而帖子被上游作废（`superseded`）可能发生在建票之后。
    /// 只靠建票时的 <see cref="Prune"/>，从作废到下次建票之间额度会一直算错，
    /// 玩家在这段时间里什么投票都等不到。
    /// </summary>
    public static void Advance(CareerData d) => Prune(d);

    /// <summary>投票条数上限。回复级投票让「每帖可多投」，不设上限会一直涨。</summary>
    public const int MaxPolls = 400;

    /// <summary>
    /// 清理孤儿投票。帖子被 TrimFeed 移出 Posts 且未进 SavedThreads 时，
    /// 挂在它上面的投票就永远显示不出来了。
    ///
    /// 帖子被收纳进 SavedThreads 时保留 —— `CommunityThreads.All` 是
    /// `Posts ∪ SavedThreads`，那种帖仍然查得到、也算得出票。
    /// </summary>
    public static int Prune(CareerData d)
    {
        // ⚠️ 必须用 Posts ∪ SavedThreads —— 与 CommunityThreads.All 一致。
        // 曾漏掉 SavedThreads，导致帖子被收纳后它的投票被静默删除（注释与代码矛盾）。
        var live = d.Posts.Concat(d.SavedThreads).ToList();
        var livePosts = live.Select(p => p.Id).ToHashSet();
        var liveReplies = live.SelectMany(p => p.Replies.Select(r => r.Id)).ToHashSet();
        // 已作废的帖永远不会生成，挂在它上面的投票也永远不会有票 —— 一并清掉。
        var deadPosts = live.Where(p => p.NewsGeneration.State == "superseded").Select(p => p.Id).ToHashSet();

        int removed = d.Polls.RemoveAll(p =>
            !livePosts.Contains(p.PostId)                                  // 帖子彻底没了
            || deadPosts.Contains(p.PostId)                                // 帖子已作废，永不生成
            || (p.ReplyId.Length > 0 && !liveReplies.Contains(p.ReplyId))); // 挂的回复没了

        if (d.Polls.Count > MaxPolls)
            d.Polls.RemoveRange(0, d.Polls.Count - MaxPolls);

        // 额度按**现存有效投票**重算，顺带把 PollLog 的所有权收归这里。
        //
        // 为什么必须重算：建票时记了 PollLog，但帖子若被上游作废（superseded），
        // 票永远不会出，那一天的额度却没退 —— 玩家白等一周还等不到投票（实测遇到）。
        // 只算**帖级**（自动发起）的：玩家自己发的投票不受密度限制，不该占额度。
        var dayOf = new Dictionary<string, int>();
        foreach (var post in live) dayOf[post.Id] = post.Day;
        d.PollLog = d.Polls
            .Where(p => p.ReplyId.Length == 0)
            .Select(p => dayOf.TryGetValue(p.PostId, out var day) ? day : -1)
            .Where(day => day >= 0)
            .Distinct().OrderBy(x => x).ToList();
        return removed;
    }

    /// <summary>冷却与密度闸门。这是决定「投票贴有多少」的地方。</summary>
    public static bool CanPublish(CareerData d)
    {
        if (d.PollLog.Count > 0 && d.Day - d.PollLog[^1] <= CooldownDays) return false;
        return d.PollLog.Count(x => x > d.Day - 7) < MaxPerWeek;
    }

    // ---------- 候选收集 ----------

    private static void Collect(CareerData d, CommunityPost post, List<(PollKind, CommunityPost, PollAsk)> into)
    {
        void Add(PollKind kind, PollAsk ask) => into.Add((kind, post, ask));

        var match = MatchOf(d, post);
        if (match != null) { CollectMatch(d, match, post, Add); return; }

        var key = post.EventKey;
        if (key.StartsWith("transfer-")) CollectTransfer(d, post, Add);
        else if (key.StartsWith("world-life-")) CollectWorldLife(post, Add);
        else if (key.StartsWith("draw-")) CollectDraw(d, post, Add);
        // 洲际杯 / 世界杯的签表：问「哪国最强」。国家类必然按阵营分裂。
        // 国运表在赛季初期可能还没有数据，不足 3 国时不发 —— 否则会产出选项过少的非法投票。
        else if (key.StartsWith("international-entry-") && TopCountries(d).Count >= 3)
            Add(PollKind.NationalStrength, new PollAsk("哪国最强？", TopCountries(d)));
        else if (key.StartsWith("qualification-"))
            Add(PollKind.ShouldEnter, new PollAsk("这趟国际赛事该去吗？", ["该去", "再等等"]));
        // 冠军产生：问「这届谁最意外」。结果已定，但「意不意外」是靠赛前评分推出的，可见。
        else if (key.StartsWith("champion-"))
            Add(PollKind.TournamentUpset, new PollAsk("这届最意外的是谁？", Contenders(d)));
        // 淘汰赛 / 海外战报：问「这轮算不算意外」
        else if (key.StartsWith("knockout-") || key.StartsWith("roundup-"))
            Add(PollKind.TournamentUpset, new PollAsk("这轮结果算意外吗？", ["算", "不算", "说不好"]));
        // 生涯里程碑：问含金量
        else if (key.StartsWith("honor-"))
            Add(PollKind.HonorWeight, new PollAsk("这份荣誉含金量够不够？", ["够", "一般", "不够"]));
        // 赛季开幕：问这赛季能走多远
        else if (key.StartsWith("season-"))
            Add(PollKind.SeasonOutlook, new PollAsk("这赛季能走多远？", ["联赛前列", "拿到国际资格", "夺冠"]));
        // 生涯进展：问下一步
        else if (key.StartsWith("life-update-") || key.StartsWith("club-update-"))
            Add(PollKind.NextMove, new PollAsk("下一步该做什么？", ["多打比赛", "稳状态", "谈合同"]));
    }

    /// <summary>国运排名前几的国家，用于「哪国最强」。</summary>
    private static List<string> TopCountries(CareerData d)
        => CircuitLedger.NationTable(d).Take(4).Select(x => x.Country).ToList();

    /// <summary>候选名单：世界前 5 与本国前 3 的并集，去掉玩家（用于「最意外」这类）。</summary>
    private static List<string> Contenders(CareerData d)
    {
        var names = d.People.Where(EsportsWorld.IsProfessional)
            .OrderByDescending(p => p.Rating).Take(5).Select(p => p.PublicName).ToList();
        names.AddRange(d.People.Where(p => EsportsWorld.IsProfessional(p) && p.Country == d.Esports.Country)
            .OrderByDescending(p => p.Rating).Take(3).Select(p => p.PublicName));
        var list = names.Distinct().Take(4).ToList();
        // 不足 4 个时补玩家，避免选项过少
        if (list.Count < 3) list.Add(CareerEngine.Name(d));
        return list.Distinct().Take(4).ToList();
    }

    /// <summary>帖子里对应的比赛。prematch / match 的事件键都带比赛编号。</summary>
    private static CareerMatch? MatchOf(CareerData d, CommunityPost post)
    {
        var key = post.EventKey;
        string? id = key.StartsWith("prematch-") ? key["prematch-".Length..]
            : key.StartsWith("match") ? key["match".Length..]
            : null;
        if (string.IsNullOrEmpty(id)) return null;
        return d.Matches.FirstOrDefault(m => m.Id == id);
    }

    private static void CollectMatch(CareerData d, CareerMatch m, CommunityPost post,
                                     Action<PollKind, PollAsk> add)
    {
        var opponent = CareerEngine.Person(d, m.OpponentId);
        var opp = opponent?.PublicName ?? "对手";
        var me = CareerEngine.Name(d);

        if (post.EventKey.StartsWith("prematch-")) { CollectPreMatch(d, m, opponent, add); return; }

        // 赛后：战报帖。结果已定，但「评价类」仍然成立。
        var result = d.Results.LastOrDefault(r => r.MatchId == m.Id);
        if (result == null) return;

        // 牌组值不值得抄 —— 唯一成立的赛后类型（牌组是完全可见的对象）
        if (result.Win && result.DeckSummary.Count > 0)
            add(PollKind.DeckWorth, new PollAsk("这套牌组值不值得抄？", ["值得", "不值得", "看人"]));

        // 爆冷：赛前落后却赢了，用「评分 vs 结果」判断，可见
        var mine = d.PlayerCard?.Rating ?? d.Rating;
        if (result.Win && opponent != null && opponent.Rating > mine + RaiseGapMin)
            add(PollKind.BiggestUpset, new PollAsk("这场算爆冷吗？", ["算", "不算"]));
    }

    private static void CollectPreMatch(CareerData d, CareerMatch m, CareerPerson? opponent,
                                        Action<PollKind, PollAsk> add)
    {
        var opp = opponent?.PublicName ?? "对手";
        var me = CareerEngine.Name(d);
        var mine = d.PlayerCard?.Rating ?? d.Rating;
        var theirs = opponent?.Rating ?? 0;
        var gap = Math.Abs(mine - theirs);

        // A3 连胜终结：半决赛或决赛 + 连胜 ≥ 6。
        // 同赛事已经发过同类型就不再发，避免半决赛决赛连着问同一件事。
        if ((IsSemifinal(m.Kind, m.Round) || IsFinal(m.Kind, m.Round))
            && d.Esports.WinStreak >= StreakMin
            && !AlreadyAsked(d, m, PollKind.StreakEnd))
        {
            add(PollKind.StreakEnd, new PollAsk($"还有人能终结 {me} 的连胜吗？", ["能", "不能"]));
            return;
        }

        // A4 抬进阶：连续抬段 ≥ 3 次，且（对手高 100 分以上 或 总决赛）
        if (ConsecutiveRaiseStreak(d) >= RaiseStreakMin
            && (theirs - mine > RaiseGapMin || IsFinal(m.Kind, m.Round)))
        {
            add(PollKind.RaiseStake, new PollAsk("这把抬进阶值不值？", ["值", "不值"]));
            return;
        }

        // A6 夺冠预测：八强或更后（用剩余人数判断，跨赛事可比）
        if (IsQuarterfinalsOrLater(m.Kind, m.Round))
        {
            add(PollKind.TitleRace, new PollAsk("这届谁夺冠？", TitleContenders(d, m)));
            return;
        }

        // A5 对战预测的触发面：只在
        //   · 世界总决赛 / 半决赛
        //   · 或双方都在本国前 10
        //   · 或双方都在世界前 10
        // 且评分差 ≤ 80（有悬念）时才发。
        // 注意顺序：八强及更后统一走上面的夺冠预测，这里只处理更早的轮次。
        var notable = m.Kind == "worldfinal" || IsSemifinal(m.Kind, m.Round)
                   || BothRanked(d, opponent, national: true) || BothRanked(d, opponent, national: false);
        if (notable && gap <= GapMax)
        {
            if (d.Esports.Duels.Any(x => x.PersonId == m.OpponentId && x.Losses > 0))
                add(PollKind.Revenge, new PollAsk("这次能赢回来吗？", ["能", "不能"]));
            else if (opponent != null && opponent.Country == d.Esports.Country)
                add(PollKind.CivilWar, new PollAsk("这场内战更想看谁赢？", [me, opp, "都想看"]));
            else
                add(PollKind.MatchWinner, new PollAsk("这场谁会赢？", [me, opp]));
        }
    }

    /// <summary>同一赛事里是否已经发过同类型的投票。</summary>
    private static bool AlreadyAsked(CareerData d, CareerMatch m, PollKind kind)
    {
        var prefix = m.CompetitionId.Length > 0 ? m.CompetitionId : m.Kind;
        return d.Polls.Any(x => x.Kind == kind.ToString()
            && d.Posts.Any(p => p.Id == x.PostId && RelatedToCompetition(d, p, prefix)));
    }

    private static bool RelatedToCompetition(CareerData d, CommunityPost post, string competitionId)
    {
        var key = post.EventKey;
        var id = key.StartsWith("prematch-") ? key["prematch-".Length..]
               : key.StartsWith("match") ? key["match".Length..] : null;
        return id != null && d.Matches.Any(x => x.Id == id && x.CompetitionId == competitionId);
    }

    /// <summary>双方是否都在排名前列（本国前 10 或世界前 10）。</summary>
    private static bool BothRanked(CareerData d, CareerPerson? opponent, bool national)
    {
        if (opponent == null) return false;
        // 玩家是 PlayerCard，不在 d.People 里，必须单独并进来 ——
        // 否则排名池永远不含玩家，这个判定就恒为 false。
        var pool = d.People.Where(EsportsWorld.IsProfessional).ToList();
        var me = d.PlayerCard;
        if (me != null) pool.Add(me);
        if (national) pool = pool.Where(p => p.Country == d.Esports.Country).ToList();
        var top = pool.OrderByDescending(p => p.Rating).Take(national ? TopDomestic : TopWorld)
                      .Select(p => p.Id).ToHashSet();
        return top.Contains(opponent.Id) && top.Contains(me?.Id ?? "player");
    }

    private static void CollectTransfer(CareerData d, CommunityPost post, Action<PollKind, PollAsk> add)
    {
        if (post.RelatedPeople.Any(id => CareerEngine.Person(d, id) != null))
            add(PollKind.TransferWorth, new PollAsk("这笔转会值不值？", ["值", "不值", "看后续"]));
    }

    private static void CollectWorldLife(CommunityPost post, Action<PollKind, PollAsk> add)
    {
        if (post.NewsTopic is "兴趣" or "往事" or "生活")
            add(PollKind.WorldLifePick,
                new PollAsk("你更想看他分享哪种日常？", ["训练之外的兴趣", "以前的老故事", "现在的状态"]));
    }

    // ---------- 工具 ----------

    /// <summary>玩家连续抬进阶的场次（从最近一场往回数）。</summary>
    public static int ConsecutiveRaiseStreak(CareerData d)
    {
        int n = 0;
        for (int i = d.Results.Count - 1; i >= 0; i--)
        {
            var r = d.Results[i];
            if (r.PlayedAscension > r.Ascension) n++;
            else break;
        }
        return n;
    }

    /// <summary>夺冠候选：世界前 5 与本国前 3 的并集（A6）。</summary>
    private static List<string> TitleContenders(CareerData d, CareerMatch? m)
    {
        var names = new List<string> { CareerEngine.Name(d) };
        names.AddRange(d.People.Where(EsportsWorld.IsProfessional)
            .OrderByDescending(p => p.Rating).Take(5).Select(p => p.PublicName));
        names.AddRange(d.People.Where(p => EsportsWorld.IsProfessional(p) && p.Country == d.Esports.Country)
            .OrderByDescending(p => p.Rating).Take(3).Select(p => p.PublicName));
        return names.Distinct().Take(4).ToList();
    }

    /// <summary>签表帖：赛事开始时就开夺冠预测（A6）。</summary>
    private static void CollectDraw(CareerData d, CommunityPost post, Action<PollKind, PollAsk> add)
    {
        add(PollKind.TitleRace, new PollAsk("这届谁夺冠？", TitleContenders(d, null)));
    }

    // ---------- 票数规模（C3）----------

    /// <summary>
    /// 票数上限按赛事级别定：世界总决赛 1000、本国比赛 200、社区俱乐部 100。
    /// 规模同时约束票数总量，也决定提示词里给出的参照量级。
    /// </summary>
    /// <summary>
    /// 票数规模上限。只看**帖子所属赛事的层级** —— 问题出现在哪个帖子，
    /// 就触达那批读者。玩家发起的投票也走这里（它同样挂在某条帖子下）。
    /// </summary>
    public static int ScaleFor(CareerData d, CommunityPost post)
    {
        var match = MatchOf(d, post);
        return match?.Kind switch
        {
            "worldfinal" or "worldcup" or "continental" => 1000,
            "masters" or "open" or "league" or "city" or "academy" => 200,
            "local" => 100,
            _ => 100,   // 转会、日常、签表等非比赛帖
        };
    }

}
