namespace NationalSpire;

public sealed record PromptSection(string Id, string Name, string DefaultText);
public sealed record PromptTemplate(string Id, string Name, string Description);

/// <summary>仅保存主动修改的创作要求；未覆盖的部分始终跟随模组默认值。</summary>
public static partial class PromptLibrary
{
    public static IReadOnlyList<PromptSection> LegacySections { get; } =
    [
        new("world", "世界观与游戏知识", """
        创作背景：《杀戮尖塔2》的电竞世界里，其他人的水平下降1000倍，玩家保持正常水平。故事中的人物把自己的水平当作生活常态。普通玩家主要挑战进阶0—3；青训在进阶6约有四至六成通关率；职业门槛是取得进阶8通关记录，普通职业选手在进阶7约有五至六成通关率；世界第一水平在进阶8约有五成通关率，顶尖选手凭自己在进阶9偶有突破；进阶10通常需要顶级选手与多名专家集中筛选极佳种子，才有极小机会通过一次。失败既可能发生在首幕，也常发生在后两幕。
        人物习惯从固定流派、熟悉的核心牌和自己的练习经历理解成绩，对玩家兼顾抽牌、攻防、资源和终局的构筑方式感到陌生。评价尺度来自各自能力与经历：真实的速度、资源余量、徽章和连续成绩会带来佩服、好奇、学习意愿，也会改变过去的判断。日常交流仍有各自关心的话题和立场。
        赛事按通关、用时、楼层决定成绩：通关者优先；双方通关比较用时；双方止步比较到达楼层。赛报中的“赛事进阶”是这场赛事的公开进阶。
        这个世界的非职业选手完整通关平均花费八十至九十分钟，职业选手平均约一小时；强者参加较低进阶比赛会更稳、更快，大多数通关仍在四十五分钟以上。三十五分钟左右在当地已属于罕见的速通表现，中途失败的用时随止步楼层缩短。具体评论结合本场用时、赛事级别和已有记录形成。
        世界中的普通玩家主要观赛和参加社区杯；青训通过选拔争取职业席位；职业选手效力于俱乐部。国内联赛连接世界大赛资格，洲际杯代表俱乐部，两赛季一届的世界杯代表国家；奇数赛季的世界总决赛决出个人冠军，其荣誉公示至下届结束。国际赛事的国运贡献用于选手奖励、国内训练与青训发展。人物身份、俱乐部归属、晋级与荣誉以本次资料中记载的状态为准。
        游戏知识：铁甲战士常使用力量、生命与消耗；静默猎手常使用中毒、弃牌与多次攻击；故障机器人的球位、充能、触发和集中影响攻防；亡灵契约师的奥斯蒂可以承受部分攻击伤害并参与攻击，末日是另一条输出线；储君使用辉星，部分卡牌同时消耗能量和辉星。
        """),
        new("voice", "社区共同文风", """
        发言是人物此刻真正在意的一件事：喜爱的选手赢了会开心、想学的打法看懂一半会追问、自己的判断落空会尴尬或改口，失利也可能带来遗憾、恼火与安慰。情绪从本人经历、支持对象和眼前事实生长，强弱随事件分量变化。人物可以省略大家已知的赛报，直接说自己的反应；短句、迟疑、反问、接话、自嘲和熟人间的打趣都属于自然交流。克制的人也有自己的态度和在意之处。
        尖塔社区口吻资源：
        “我说xxxx有没有懂的”：表达某种观点，语气偏轻松、随口。
        “别带/带吧多带”：起哄带某种梗或节奏，或在被带节奏时自嘲。
        “xxxx了”：把卡牌名称当作动作或状态，借它形容眼前相似的行为或局面。keyCards和当前讨论提供的卡名可以成为这种联想的素材，贴切程度和接话兴致决定人物是否顺口借用。
        “尝试攻杀大怪/尝试塞一张愤怒”：梗源是一位主播因策略问题排除攻杀大怪的路线，寻找通关世界线时持续受阻，最后作弊向弃牌堆塞了一张愤怒，随后承认作弊。常在遇到难以通过的怪物时引用；发言语义是借用这段典故调侃困难。
        “塔学疑云”：熟悉机制表现得与常见情况相异或相反，又因代码问题难以解释。
        这些表达供人物随语境选用。贴切场景可以直说，其他场景也可以借意引申；具体选用取决于身份、性格、熟悉程度与谈话走向。普通玩家和休闲观众通常更爱接梗，职业选手相对克制，熟人关系和个人习惯会影响这一倾向。
        相关历史帮助人物记住发生过的事和彼此的态度。本次发言从眼前的新变化接着往下聊，近期出现过的开头、比喻、数字感叹和结论可以换一个关注点；只有确实延续的话题才承接原话。人物说出自己能知道的事情，语气贴合身份与关系，成绩带来的情绪和疑问落在具体细节上。
        """),
        new("news", "自动发帖", """
        标题与正文由发帖者结合事实和人物立场独立创作。发帖者从自己关心的事情展开，评论者可以回应正文，也可以接着其他人的话讨论。真实表现与世界水平之间的差距、过去的交手、原有看法和个人偏好都可成为话题。篇幅通常为标题12—28字、正文60—140字、回复20—60字，随素材与谈话需要调整。
        """),
        new("discussion", "玩家帖子与回复", """
        回复通常20—80字，复杂话题可展开。
        """),
        new("profiles", "选手介绍", """
        结合本期的变化与过去的经历写成连续的人物介绍。保留仍有依据的特点，新的事实可以推动评价发展。介绍可侧重近期状态、成绩的分量、长期特点或职业发展，选取与此人经历最相关的内容。正反馈来自实际成绩在这个世界中的价值。每人通常50—100字，素材较少时可更简短。保留有依据的人物特点，本期新增经历决定更新重点，使介绍自然发展。
        """),
        new("weekly", "双周刊", """
        根据题材选择有价值的叙述角度，比赛的资源、速度、对手、历史交手和选手变化都可形成观察。选题之间保持各自的关注点，文章的长度和结构随素材展开。标题通常12—24字，正文80—180字，资料较少时可更简短，段落用换行表示。已报道的事实可以简短承接，这一期侧重后来发生的变化，选择贴合题材的新开头与观察角度。
        advertisement=true的文章采用轻松的推广口吻，创意来自给定选手、俱乐部、实际合作品牌及广告方向，读者是故事里的观众。
        """),
        new("group", "群聊提示词", GroupChatPrompts.Guide),
        new("group-summary", "群聊小总结", GroupChatPrompts.SmallSummary),
        new("group-long-summary", "群聊大总结", GroupChatPrompts.BigSummary),
        new("private", "私信提示词", PrivateMessagePrompts.Guide),
        new("private-summary", "私信小总结", PrivateMessagePrompts.SmallSummary),
        new("private-long-summary", "私信大总结", PrivateMessagePrompts.BigSummary),
    ];
    private static string Normalize(string value) => value.Replace("\r\n", "\n").Trim();
    internal static string MergePrivateText(string guide, string style)
    {
        guide = Normalize(guide); style = Normalize(style);
        if (style.Length == 0 || guide.Contains(style, StringComparison.Ordinal)) return guide;
        string previous = Normalize(PrivateMessagePrompts.LegacyStyle);
        return guide.Contains(previous, StringComparison.Ordinal) ? guide.Replace(previous, style) : guide + "\n\n" + style;
    }
    public static void MergePrivatePrompt(AiOptions options)
    {
        if (options.PrivatePromptVersion >= 1) return;
        foreach (var custom in options.CustomPromptTemplates.Values)
            if (custom.Sections.Remove("private-style", out var style))
                custom.Sections["private"] = MergePrivateText(custom.Sections.GetValueOrDefault("private", PrivateMessagePrompts.Guide), style);
        void Merge(Dictionary<string, string> values, string template)
        {
            bool hasStyle = values.Remove("private-style", out var style);
            // 仅迁移实际保存的旧模块，不给已有私信原文追加默认文风。
            if (!hasStyle) return;
            string fallback = options.CustomPromptTemplates.GetValueOrDefault(template)?.Sections.GetValueOrDefault("private") ?? PrivateMessagePrompts.Guide;
            values["private"] = MergePrivateText(values.GetValueOrDefault("private", fallback), style!);
        }
        Merge(options.PromptOverrides, options.PromptTemplate);
        foreach (var bank in options.PromptTemplateOverrides) Merge(bank.Value, bank.Key);
        options.PrivatePromptVersion = 1;
    }
    public static bool IsCustom(AiOptions options, string id) => options.PromptOverrides?.TryGetValue(id, out var text) == true && !string.IsNullOrWhiteSpace(text);
    public static string Get(AiOptions options, string id)
    {
        MergePrivatePrompt(options);
        string fallback = Default(options, id);
        return options.PromptOverrides != null && options.PromptOverrides.TryGetValue(id, out var custom)
            && !string.IsNullOrWhiteSpace(custom) ? custom : fallback;
    }
    public static void Save(AiOptions options, string id, string text)
    {
        MergePrivatePrompt(options);
        string fallback = Default(options, id);
        if (string.IsNullOrWhiteSpace(text)) throw new ArgumentException("提示词不能为空。");
        options.PromptOverrides ??= new();
        if (Normalize(text) == Normalize(fallback)) options.PromptOverrides.Remove(id);
        else options.PromptOverrides[id] = text.Trim();
    }
    public static void Reset(AiOptions options, string id) => options.PromptOverrides?.Remove(id);
    public static string Editorial(AiOptions options, string scene) => string.Join("\n\n",
        new[] { Get(options, "world"), scene is "news" or "discussion" ? Get(options, "voice") : "", Get(options, scene) }
            .Where(s => s.Length > 0));
}
