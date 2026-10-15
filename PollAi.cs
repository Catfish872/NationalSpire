using System.Text.Json;

namespace NationalSpire;

/// <summary>
/// 投票与 AI 的衔接：注入与回读。
///
/// 独立成类，不做 AiService 的 partial —— AiService 有静态构造函数（会读密钥、
/// 碰 Godot 运行时），把纯文本与纯解析挂上去会拖进不必要的初始化依赖。
///
/// 与玩家的模板提示词分开：投票的输出格式是**程序规定**的，
/// 玩家不该也不能改它（改坏了整批解析会失败）。
/// </summary>
public static class PollAi
{
    /// <summary>
    /// 投票的注入对象。帖级与回复级共用，只有输出位置不同（见 replyLevel）。
    ///
    /// 两种状态，互斥：
    ///   · 还没投出结果 → 附 <c>howTo</c>，让模型填票数（投票结果 为 null）
    ///   · 已经投出结果 → 附 <c>投票结果</c>，供后续讨论与发帖引用；不再要求模型重填
    ///
    /// ⚠️ 曾经只注入 question/options/facts，**不带结果** ——
    /// 于是 AI 知道「有个投票、问题是啥」，却看不到社区投出来的票，
    /// 后续讨论完全引用不到。这是实测发现的缺口。
    /// </summary>
    public static object PromptFor(CareerData data, CommunityPoll poll, CareerMatch? match, bool replyLevel)
    {
        bool voted = poll.Total > 0;
        return new
        {
            question = poll.Question,
            options = poll.Options,
            facts = PollFacts.Describe(data, poll.Question, poll.Options, match),
            // 只给票数，**不给「社区整体怎么看」的结论**。
            //
            // 曾经附带一句总结，结果那条总结被每一条回复原样复述 ——
            // 所有回复都从同一句话出发，高度趋同。
            // 现在只给原始数字，各人按自己的性格与立场去读，自然分化：
            // 有人读出「一半人不服」，有人只关心领先那项，有人抬杠说不该这么投。
            投票结果 = voted
                ? new { 票数 = poll.Votes.ToArray(), 总票数 = poll.Total }
                : null,
            howTo = voted ? BuildResultInstruction(poll) : BuildInstruction(poll, replyLevel),
        };
    }

    /// <summary>
    /// 帖子的投票注入对象。**没有投票时返回 null**，
    /// 所以不带投票的帖子在提示词里零开销。
    ///
    /// 注入失败时会记一条 `poll.miss` 诊断 —— 曾经出现过「投票明明建了、
    /// 请求里却是 poll:null」的情况，而日志只留了结果、没留原因，排查全靠猜。
    /// 现在把**为什么没注入**直接写进日志。
    /// </summary>
    public static object? PollPromptForPost(CareerData data, CommunityPost post)
    {
        var poll = PollSchedule.Of(data, post);
        if (poll == null)
        {
            // 只有「这帖本该有投票」才值得记 —— 用 Posts 里是否有该 PostId 判断
            if (data.Polls.Any(x => x.PostId == post.Id))
                Diagnostics.Record("poll.miss", new
                {
                    postId = post.Id, post.EventKey, way = "Of()=null",
                    note = "该 PostId 有投票，但不是帖级（ReplyId 非空？）",
                    all = data.Polls.Where(x => x.PostId == post.Id)
                        .Select(x => new { x.Kind, replyId = x.ReplyId, x.IsValid }).ToArray(),
                });
            return null;
        }
        if (!poll.IsValid)
        {
            Diagnostics.Record("poll.miss", new
            {
                postId = post.Id, post.EventKey, way = "!IsValid", poll.Kind,
                question = poll.Question, opts = poll.Options.Count, optsEmpty = string.Join(",", poll.Options),
                votes = poll.Votes.Count, questionEmpty = poll.Question.Trim().Length == 0,
            });
            return null;
        }
        var match = poll.Kind == nameof(PollKind.MatchWinner) || poll.Kind == nameof(PollKind.StreakEnd)
            || poll.Kind == nameof(PollKind.RaiseStake) || poll.Kind == nameof(PollKind.DeckWorth)
            || poll.Kind == nameof(PollKind.BiggestUpset) || poll.Kind == nameof(PollKind.Revenge)
            || poll.Kind == nameof(PollKind.CivilWar) || poll.Kind == nameof(PollKind.TitleRace)
            ? data.Matches.FirstOrDefault(m => post.EventKey == "prematch-" + m.Id || post.EventKey == "match" + m.Id)
            : null;
        // 注入成功也记一条 —— 否则日志里只有失败，看不出「到底注入过没有」。
        // 投票很稀疏（约每周 2 条），这点日志量可以接受。
        Diagnostics.Record("poll.inject", new
        {
            postId = post.Id, post.EventKey, poll.Kind, poll.Question,
            voted = poll.Total > 0, opts = poll.Options.Count,
        });
        return PromptFor(data, poll, match, replyLevel: false);
    }

    /// <summary>回复级投票（玩家发起）。挂在 conversation 条目上。</summary>
    public static object? PollPromptForReply(CareerData data, CommunityReply reply)
    {
        var poll = PollSchedule.OfReply(data, reply);
        return poll == null || !poll.IsValid ? null : PromptFor(data, poll, null, replyLevel: true);
    }

    /// <summary>
    /// 投票**已有结果**时的指令（后续讨论引用）。
    ///
    /// 此前这里返回 null —— 于是 AI 拿到一组数字却没有任何说明，多半直接忽略，
    /// 回复各写各的。实测确认过：票数进了请求，回复里却一个字都没提。
    /// </summary>
    private static string BuildResultInstruction(CommunityPoll poll)
    {
        var lines = new List<string>
        {
            "帖子/回复上挂着这个投票，poll.投票结果 是社区已经投出来的数字。",
            "**你的发言要在意这组数字**：可以引用谁领先、谁几乎没人选，也可以不服这个结果、"
            + "质疑票是怎么投的。完全绕开它、只聊自己的事，这投票就白做了。",
            "但别所有人都重复同一句——有人盯领先项，有人替冷门项说话，"
            + "有人干脆不理。同一组数字，各人读出各自的角度。",
        };
        if (KindHint.TryGetValue(poll.Kind, out var hint)) lines.Add($"本投票属于「{poll.Kind}」类。{hint}");
        return string.Join('\n', lines);
    }

    /// <summary>
    /// 这类投票的票型规律。**这是投票者可参考的「社区通常怎么投」**，
    /// 避免所有投票都写成同一种形状（角色类被写成碾压、国家类被写成均匀等）。
    ///
    /// 菜单由程序汇总 —— 与玩家的模板提示词无关，互不干扰。
    /// </summary>
    private static readonly Dictionary<string, string> KindHint = new()
    {
        [nameof(PollKind.MatchWinner)] = "对战预测。有公认强者就碾压；实力接近或状态矛盾就均衡、争吵激烈。",
        [nameof(PollKind.StreakEnd)] = "连胜终结。多数人期待连胜继续，但总有一批想看终结、唱反调。",
        [nameof(PollKind.TitleRace)] = "夺冠预测。热门集中在前几位，冷门各有死忠。",
        [nameof(PollKind.RaiseStake)] = "规则争议。自我挑战派与规则公平派对立，票型偏两极并拌有大量反串。",
        [nameof(PollKind.Revenge)] = "复仇战。看好与否取决于近期状态，两派并存。",
        [nameof(PollKind.CivilWar)] = "内战。按支持的选手分裂，想两边都赢的旁观者不少。",
        [nameof(PollKind.DeckWorth)] = "牌组评价。各人主玩角色与打法不同，答案天然分散，不该一边倒。",
        [nameof(PollKind.BiggestUpset)] = "爆冷判断。以弱胜强算不算爆冷，会按对双方实力的观感分歧。",
        [nameof(PollKind.ShouldEnter)] = "是否参赛。机会派与保守派对立。",
        [nameof(PollKind.TransferWorth)] = "转会评价。按对该选手与新俱乐部的观感分化。",
        [nameof(PollKind.WorldLifePick)] = "日常偏好。纯看个人兴趣，票型最分散，反串戏谑最多。",
        [nameof(PollKind.TournamentUpset)] = "意外判断。结果已定，投的是「意不意外」，按赛前名气与实际成绩的反差分化。",
        [nameof(PollKind.HonorWeight)] = "荣誉评价。按这份荣誉的级别与得来难度分化，会有不少人不当回事。",
        [nameof(PollKind.SeasonOutlook)] = "赛季展望。乐观与保守两派，按玩家当前状态分化。",
        [nameof(PollKind.NextMove)] = "路线建议。各人按自己的打法和偏好给主意，答案天然分散。",
        [nameof(PollKind.NationalStrength)] = "国家对比。本国必投自家，死敌互踩，人多国多票。"
            + "票型分散是阵营把共识切碎了，不是没有共识，回复里要体现这一点。",
    };

    /// <summary>该类型是否有预设的调性描述。玩家发起的类型（PlayerAsked）没有。</summary>
    public static bool HasKindHint(string kind) => KindHint.ContainsKey(kind);

    /// <summary>拼出这条投票的完整说明：类型规律 + 规模 + 输出格式。</summary>
    private static string BuildInstruction(CommunityPoll poll, bool replyLevel = false)
    {
        var lines = new List<string>();
        // 第一句就锁死：投票已由程序建好，模型只填结果。
        // 曾经因为输出字段叫「投票」、而注入对象也叫 poll（含 question/options），
        // 模型把它当成「提议一个新投票」，回了个 {"投票":{"问题":…,"选项":[…]}}，
        // 票数永远读不到。用**不同的字段名**把两种语义分开。
        lines.Add(replyLevel
            ? "这条回复上挂着一个投票，**已经由程序建好**，你只负责填结果，不要另提问题或另给选项。"
            : "这帖的投票**已经由程序建好**，你只负责填结果，不要另提问题或另给选项。");
        // ⚠️ 必须写清**放在哪一层**。曾写成「请在返回的 JSON 里加上」，
        // 模型据此把 投票结果 放到了 **JSON 顶层**（它的推理里明说了
        // 「top level or post level? I'll go top-level」），而解析器是在
        // **帖子对象内**读的 → 票数永远读不到、显示 0 票。
        // 帖子批里有多个帖子时，顶层更是无法区分投给谁。
        lines.Add(replyLevel
            ? """请在**回应这条留言的那条回复的对象里**加上："投票结果":{"票数":[<每个选项一个非负整数，顺序与 poll.options 一致>]}"""
            : """请在**这个帖子的对象里**加上（不是 JSON 顶层）："投票结果":{"票数":[<每个选项一个非负整数，顺序与 poll.options 一致>]}""");
        lines.Add("poll 里已经给出问题与选项，直接按它们填票数即可。禁止改写问题、禁止增删或改动选项、禁止再输出一个「投票」字段。");

        if (KindHint.TryGetValue(poll.Kind, out var hint))
        {
            lines.Add($"本投票属于「{poll.Kind}」类。{hint}");
        }
        else
        {
            // 玩家发起的投票没有类型提示 —— 程序不预设调性，由模型读问题本身来判断。
            // 不做关键词分类：关键词猜不准，而模型读得懂问题自己的语气。
            lines.Add("程序没有为这个问题预设性质。先读问题本身再定票型："
                    + "严肃的预测或评价偏集中、票数跟着事实走；"
                    + "闲聊、抬杠、娱乐性质的问题则更散、更爱唱反调；"
                    + "问题里双方无从分辨时，两派并立、票数接近。");
        }
        lines.Add("判断票数时参考 poll.facts 提供的事实，不要随机填、也不要各选项平均分配。");
        lines.Add("有公认强者就拉开差距；事实互相矛盾（如实力强但近况差）就票数接近、分歧明显；没有可判断依据时再分散。");
        lines.Add($"票数总量参照社区规模，不超过 {poll.Scale} 票。");

        // ★ 顺序要求：先定票数，再写回复。
        //
        // 实测教训：票数与回复是**同一次产出**，而提示词此前只说「填票数」，
        // 没说要让回复基于它。结果 AI 把两件事当独立任务 —— 回复完全没引用票数，
        // 各写各的，投票等于白做。
        // 关键是让 AI 明白：**这些数字是它自己刚定的**，回复应当围绕它们展开。
        lines.Add("**先定下这一组票数，再写下面的回复。** 票数是你自己给出的，"
                + "所以回复里的人基于这组数字说话：谁多谁少、哪一项领先、哪一项几乎没人选，"
                + "意见因此分成几派。**不要让所有回复都绕开票数各说各的** —— 那这投票就没意义了。");
        lines.Add("但每人只说自己关心的那部分：有人盯着领先项，有人替冷门项不服，"
                + "有人质疑这票投得不对。分歧从同一组数字里长出来，不要所有人同一个调子。");
        return string.Join('\n', lines);
    }

    /// <summary>
    /// 从条目里读票数。帖级读**帖子对象**、回复级读**某条回复对象**，格式一致。
    /// 只做**格式校验**（个数与选项一致、非负整数），不做内容一致性校验 ——
    /// 判断「多少票算势均力敌」是语义判断，不该塞回程序。
    /// </summary>
    public static bool TryReadVoteResult(JsonElement item, int optionCount, out List<int> votes)
    {
        votes = [];
        // 先认新字段名；再兜底认旧名，且**必须带票数**才算数 ——
        // 模型「提议新投票」时也用过「投票」这个键（内容是问题+选项），不能误读。
        if (!TryObject(item, "投票结果", out var v) && !TryObject(item, "投票", out v)) return false;
        if (!v.TryGetProperty("票数", out var raw) || raw.ValueKind != JsonValueKind.Array) return false;

        var list = new List<int>();
        foreach (var one in raw.EnumerateArray())
            // 负票数按无效处理（用 -1 标记），不能夹成 0 —— 那会让脏数据蒙混过关
            list.Add(one.ValueKind == JsonValueKind.Number && one.TryGetInt32(out var n) ? n : -1);
        if (list.Count != optionCount || list.Any(x => x < 0)) return false;

        votes = list;
        return true;
    }

    /// <summary>
    /// 读票数。**只读票数** —— 「总结」已不再产出，下游要的是原始数字，
    /// 解读留给每条回复自己。
    ///
    /// <paramref name="fallback"/>：模型偶尔把 投票结果 放到 **JSON 顶层**
    /// （实测其推理原话是「top level or post level? I'll go top-level」）。
    /// 调用方**仅在批内只有一条帖子时**才传顶层元素兜底 —— 多条帖子时
    /// 顶层无法区分投给谁，宁可判为未填也不猜。
    /// </summary>
    public static void ReadPoll(JsonElement item, CommunityPoll? poll, JsonElement fallback = default)
    {
        if (poll == null) return;
        if (!TryReadVoteResult(item, poll.Options.Count, out var votes)
            && !(fallback.ValueKind == JsonValueKind.Object
                 && TryReadVoteResult(fallback, poll.Options.Count, out votes)))
        {
            // 回读失败也要留证据：曾经连着三轮 0 票，而日志只记「应用成功」，
            // 完全看不出票数没读进来。记下期望的选项数与模型实际的返回形状。
            Diagnostics.Record("poll.readmiss", new
            {
                postId = poll.PostId, poll.Kind, want = poll.Options.Count,
                itemHasVote = item.TryGetProperty("投票结果", out _) || item.TryGetProperty("投票", out _),
                fallbackKind = fallback.ValueKind.ToString(),
                itemText = item.GetRawText().Length > 600 ? item.GetRawText()[..600] : item.GetRawText(),
            });
            return;
        }
        poll.Votes = votes;
    }

    private static bool TryObject(JsonElement item, string name, out JsonElement value)
    {
        if (item.TryGetProperty(name, out value) && value.ValueKind == JsonValueKind.Object) return true;
        value = default;
        return false;
    }
}
