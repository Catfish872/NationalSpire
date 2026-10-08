using System.Text.Json;

namespace NationalSpire;

/// <summary>
/// 实时社区弹幕的 AI 场景。与静态词库不同，这里的弹幕由 AI 在每次社区内容更新后生成，
/// 内容紧扣刚发生的社区动态，风格跟随玩家在模组设置里选的提示词模板（`danmaku` 场景段）。
/// </summary>
public static partial class AiDanmakuScene
{
    /// <summary>场景 id，对应 PromptLibrary 的可编辑段与提示词模板里的同名键。</summary>
    public const string SceneId = "danmaku";

    /// <summary>一次请求期望的弹幕条数区间，写进提示词里约束输出规模。</summary>
    public const int MinimumPerUpdate = 8, MaximumRequested = 24;

    /// <summary>
    /// 内置的通用创作要求。玩家没有自定义 `danmaku` 场景段时，仅靠这一段 + 档位说明也能产出可用弹幕；
    /// 自定义后自定义段会排在最前，本段作为兜底继续生效。
    /// </summary>
    internal const string Guide = """
        弹幕来自正在看直播的观众，写给同一块屏幕上的其他人看。一口气说完，6—20个汉字，口语，像随手敲上去的，不像解说词，也不是完整成篇的评论。观众从眼前这局比赛和刚看到的社区动态开口，只顾自己在意的那一点。
        这批弹幕要紧扣本次提供的社区动态：刚发出的帖子、回复和周刊要点就是素材，可以接梗、可以阴阳、可以顺着别人的话补半句，也能拿旧事作对比，但不能脱离素材自己编事实，也不要把素材原文抄一遍。
        同一批弹幕里要有不同立场的人：无脑护主、捧一踩一、阴阳怪气、单纯看笑话、自嘲型乐子人都要占位置，观点互相打架才热闹；可以起哄，可以突然改口，可以只丢一句反问就结束。
        不要复述解说词，把解说刚说过的话换个说法再发一遍没有意义；也不要写四平八稳的总结句和正经分析。
        禁止脏话、攻击现实中的真人、涉政涉黄涉暴内容、英文长句；正文不要出现竖线和换行。
        """;

    /// <summary>按知名度档位给出的语气补充，拼在系统提示词末尾。</summary>
    internal static readonly string[] TierGuide =
    [
        "", // 占位：档位从 1 开始
        "寂寂无名的选手没人当真：弹幕多是冷嘲热讽和看笑话，语气轻松，敢替选手下结论，敢胡说走位和牌序，说错了也无所谓。",
        "有些名气，弹幕就开始较真：先夸一句再踩一句，拿成绩、用时和数据挑刺，常把自己说成中立观众，表面讲道理，实际在带节奏。",
        "名声大了，弹幕自动站队：输了也说是运气和数值问题，把对手的胜利说得一文不值，顺手踩同台竞争的另一方，谁质疑就先让对方报段位。",
        "顶级选手的弹幕只认成绩：打得好就准备见证历史，把这一局写进史书；输一局立刻喊塌房，顺手把以前吹上天的旧神拖出来比一遍。"
    ];

    /// <summary>
    /// 世界大赛期间（世界总决赛 / 国家队世界杯 / 洲际俱乐部冠军杯）的追加要求：
    /// 观众会拿外战成绩反复清算。只在世界赛期间拼进系统提示词，平时完全不出现。
    /// </summary>
    internal const string WorldsGuide = """
        现在是世界大赛期间（世界总决赛、国家队世界杯、洲际俱乐部冠军杯），观众的算账味要重起来：外战成绩会被翻出来反复清算，赢了是应该的，输了就要把参赛史整个过一遍。
        世界赛专属的梗按下面的意思用，每个梗都只是素材，要自然融进一句话里，像观众随手敲上去的，绝对不要写成解释这个梗的说明句，也不要一条里硬塞好几个：「大满败」大赛全参加、一个冠军都没拿到；「虚空N冠」冠军是从虚空里数出来的，数字随便换，用来嘲成绩注水；「本质16强」看着走得挺远，本质还是十六强；「本质亚军」看着差点夺冠，命里就是亚军；「游回家」外战出局，夸张成从客场一路游回去；「藏飞机票」回程票早就买好了，暗示自己知道要输。
        这个语境下还能顺手说：外战内行内战幻神、只会打自家人、出国就腿软、签运选手；也可以拿签运、分组、版本和赛程替选手找理由，或者反过来骂这些理由全是借口。
        世界赛的梗同样守这套规矩：6—20个汉字、口语短句、自然融入；禁止脏话、攻击现实中的真人、涉政涉黄涉暴内容、英文长句，正文不要出现竖线和换行。
        """;

    /// <summary>输出协议：约束 JSON 结构与事件族取值，事件族决定弹幕在局内由哪些事件触发时优先抽用。</summary>
    internal const string Protocol = """
        输出一个完整JSON对象，不要输出这个对象之外的任何文字：
        {"danmaku":[{"event":"hurt","text":"这一下掉得也太狠了"},{"event":"elite","text":"{name}打精英跟散步一样"}]}
        danmaku是本批弹幕，条数按本次要求的数量给出（request.count，通常在八到二十四条之间）；尽量覆盖多个事件族，同一个事件族也可以给好几条，够局内反复抽取。
        event是这条弹幕归属的事件族，局内触发对应事件时会优先抽这一族。每个event必须逐字取自下面二十四个名称之一，区分大小写：
        hurt受伤掉血、death濒死或战败、danger血量危险被压制、elite精英战与精英路线、cheap抠门舍不得花钱、draw一回合打出极多牌、draw_repeat反复抽牌、skip_reward跳过卡牌奖励、potion_waste药水乱用或乱弃牌、overkill一次伤害打得特别多、boss首领战、clean打得很干净几乎没挨打、quick速通用时很短、upgrade升级删牌与领奖、shop商店购物、slack火堆休息与摸鱼、achieve夺冠与达成成就、opening开局、gap层数领先或落后、rival对手的进展与淘汰、target把玩家和对手放在一起比、praise顺利完赛值得夸、mock泛泛的嘲讽与看热闹、worlds世界赛清算（只在世界大赛期间使用）。
        text是弹幕正文，6—20个汉字，口语短句。需要引用本次事实时，只能用下面十二个占位符，程序会在上屏前替换成真实内容：
        {name}玩家名、{rival}对手名、{country}赛区、{club}俱乐部、{gap}领先层数、{loss}掉血、{cards}本回合出牌数、{draws}抽牌数、{turn}回合数、{hp}血量、{time}用时、{card}最后打出的牌名。
        没有需要就不要用占位符，不要把十二个都塞进一条；text里出现这十二个之外的任何花括号，该条会被程序整条丢弃。同一批里不要写重复的句子，也不要只换一两个字凑数。
        """;

    /// <summary>组装系统提示词：世界与文风（跟随玩家选择的模板）+ 内置要求 + 档位语气 + 世界赛追加段 + 输出协议。</summary>
    public static string ComposeSystem(AiOptions options, int tier, bool worlds = false)
    {
        var editorial = PromptLibrary.Editorial(options, SceneId);
        var parts = new List<string>();
        if (editorial.Length > 0) parts.Add(editorial);
        // 未自定义 danmaku 场景段时，Editorial 里的那一段就是 Guide 本身，不必再加一遍。
        // 只有玩家自定义了风格，才把 Guide 作为兜底要求补在后面。
        if (PromptLibrary.IsCustom(options, SceneId)) parts.Add(Guide);
        string tierText = TierGuide[Math.Clamp(tier, 1, 4)];
        if (tierText.Length > 0) parts.Add(tierText);
        // 世界赛期间追加清算梗要求，排在档位语气之后、输出协议之前；非世界赛期间完全不进提示词。
        if (worlds) parts.Add(WorldsGuide);
        parts.Add(Protocol);
        return string.Join("\n\n", parts);
    }

    /// <summary>组装用户内容：最近社区动态 + 本场与选手事实；世界赛期间额外带上世界赛标记与措辞。</summary>
    public static string ComposeUser(CareerData data, IEnumerable<CommunityPost> posts, int count, bool worlds = false)
    {
        var recent = posts.Take(8).Select(post => new
        {
            title = post.Title,
            body = Text(post.Body),
            replies = post.Replies.Take(4).Select(reply => Text(reply.Body)).ToArray()
        }).ToArray();
        var payload = new
        {
            request = new
            {
                count = Math.Clamp(count, MinimumPerUpdate, MaximumRequested),
                note = worlds
                    ? "为下面这些社区动态各写若干条观众弹幕，覆盖不同角度。现在是世界大赛期间，可以放开用世界赛清算梗（大满败、虚空N冠、本质16强、本质亚军、游回家、藏飞机票），但每个梗都要自然融进句子。"
                    : "为下面这些社区动态各写若干条观众弹幕，覆盖不同角度。"
            },
            player = new
            {
                name = CareerEngine.Name(data),
                fans = data.Fans,
                rating = data.Rating,
                honors = data.Esports.Honors.Count,
                tier = SituationDanmaku.Tier(data),
                tierName = SituationDanmaku.TierName(SituationDanmaku.Tier(data)),
                day = data.Day,
                season = data.Season,
                worlds
            },
            recentCommunity = recent
        };
        return JsonSerializer.Serialize(payload, new JsonSerializerOptions { WriteIndented = false });
    }

    /// <summary>正文可能很长，截断后交给 AI，避免单条占满上下文。</summary>
    private static string Text(string value)
    {
        string text = (value ?? "").Replace('\r', ' ').Replace('\n', ' ').Trim();
        return text.Length <= 220 ? text : text[..220] + "…";
    }

    /// <summary>
    /// 解析 AI 返回的弹幕。事件族与占位符都做白名单校验，任何一条不合格只丢弃该条。
    /// </summary>
    public static List<AiDanmakuStore.Entry> Parse(string content, int tier)
    {
        var entries = new List<AiDanmakuStore.Entry>();
        using var document = JsonDocument.Parse(Extract(content));
        if (!document.RootElement.TryGetProperty("danmaku", out var array)) throw new InvalidDataException("返回内容缺少 danmaku 数组");
        foreach (var item in array.EnumerateArray())
        {
            string evt = item.TryGetProperty("event", out var eventValue) ? eventValue.GetString() ?? "" : "";
            string text = item.TryGetProperty("text", out var textValue) ? textValue.GetString() ?? "" : "";
            text = text.Replace('\r', ' ').Replace('\n', ' ').Trim();
            if (text.Length == 0 || !Events.Contains(evt)) continue;
            // 占位符白名单之外的整条丢弃，避免把 {xxx} 原样显示到屏幕上。
            if (System.Text.RegularExpressions.Regex.IsMatch(text, @"\{(?!(name|rival|country|club|gap|loss|cards|draws|turn|hp|time|card)\})")) continue;
            if (text.Length > 40) text = text[..40];
            entries.Add(new AiDanmakuStore.Entry { Tier = tier, Event = evt, Text = text, Day = 0 });
        }
        return entries;
    }

    /// <summary>
    /// 从模型回复里取出 JSON 主体。模型有时会用 ```json 代码围栏包裹，或在前后加一句说明，
    /// 直接 Parse 会整批失败，因此这里先剥围栏、再截取最外层花括号范围。
    /// </summary>
    internal static string Extract(string content)
    {
        string text = (content ?? "").Trim();
        if (text.StartsWith("```", StringComparison.Ordinal))
        {
            int firstLine = text.IndexOf('\n');
            int lastFence = text.LastIndexOf("```", StringComparison.Ordinal);
            if (firstLine > 0 && lastFence > firstLine) text = text[(firstLine + 1)..lastFence].Trim();
        }
        int start = text.IndexOf('{');
        int end = text.LastIndexOf('}');
        if (start >= 0 && end > start) text = text[start..(end + 1)];
        return text;
    }

    /// <summary>允许的事件族白名单，与静态词库的事件族保持一致；worlds 是世界赛专用族，仅世界赛期间会用到。</summary>
    internal static readonly HashSet<string> Events = new(StringComparer.Ordinal)
    {
        "hurt", "death", "danger", "elite", "cheap", "draw", "draw_repeat", "skip_reward", "potion_waste", "overkill",
        "boss", "clean", "quick", "upgrade", "shop", "slack", "achieve", "opening", "gap", "rival", "target", "praise", "mock",
        "worlds"
    };
}
