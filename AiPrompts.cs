namespace NationalSpire;

public static partial class AiService
{
    internal static string ComposeSystem(AiOptions options, string scene)
    {
        string protocol = scene switch
        {
            "news" => EvidencePrompt + SystemPrompt,
            "discussion" => EvidencePrompt + DiscussionPrompt,
            "profiles" => WeeklyProfilePrompt,
            "weekly" => WeeklyNewsPrompt,
            _ => throw new ArgumentException("未知创作场景。")
        };
        return PromptLibrary.Editorial(options, scene) + "\n\n" + protocol;
    }

    private const string EvidencePrompt = """
        people提供人物身份、水平与关系，personality按中文字段说明性格类型、判断事情的习惯、交往习惯、面对压力、玩笑偏好、亲疏立场和求知倾向。人物资料用于保持身份和性格连贯，发言关注正在聊的话。

        对局资料的字段含义：officialAscension和Ascension为赛事公开进阶；Outcome是比赛胜负，cleared和Win是对局通关状态；elapsed是游戏记录的对局用时，按小时、分钟和整数秒表示。deck是结算牌组清单，keyCards是其中部分卡牌的文字。finishEvidence.FinalHp/MaxHp记录最后房间结束时的生命/生命上限；RemainingPotions是结算库存；PotionsRecorded=true表示库存记录完整，空列表表示库存为零；PotionsUsed是本局药水使用总次数；Badges的Name和Description是原生徽章名称与判定条件。null表示资料未知。
        finishEvidence.DefeatedEncounters记录本局已击败的精英与BOSS，Act为幕数，Floor为累计楼层，Kind为Elite或Boss，Name为遭遇名称；多人记录属于全队共同战果。null表示未记录，空列表表示没有确认击败的精英或BOSS。
        playerRecord.cooperation记录截至cooperationAsOfDay的俱乐部归属与个人赞助状态，待确认邀请代表接洽阶段，已签约关系按所列合同期限生效。
        """;
    private const string SystemPrompt = """

        你创作尖塔玩家论坛的帖子及跟帖。每篇帖子由输入AuthorId对应的人物发表，正文和回复面向论坛玩家。player.name是玩家称呼。
        输入posts的topic为事件主题、facts为事件记录，同时提供日期、类别和allowedAuthors；match提供本场双方的成绩、玩家牌组、结算证据及相关历史；people提供本次人物资料。人物资料的有效日期见profileAsOfDay与introductionAsOfDay。发帖时点见eventDay，引用素材的日期截至该时点。
        communityMemory是检索到的相关历史：fact为事件记录，opinion为署名人物当时的观点；引用观点时保留人物与时间归属。playerRecord提供玩家最近的公开记录和周刊介绍，honors与seasonHistory提供已取得的荣誉和赛季成绩。schedules记录各AsOfDay当时公布的近期日程，Upcoming逐条说明具名选手的报名状态，RecentMeetings是已完成的交手，RelatedFixtures是相关人物的公开对阵。
        输出一个完整JSON对象，结构如下：
        {"posts":[{"id":"t1","title":"标题","body":"正文","replies":[{"id":"r1","authorId":"u1","parentId":"","body":"评论"},{"id":"r2","authorId":"u2","parentId":"r1","body":"接话"}]}]}
        每个输入帖子编号恰好返回一次。t编号原样取自posts.Id；每条authorId选自该帖allowedAuthors，这些是本帖当前可参与讨论的人物。replyCount是参考人数，实际参与者、回复人数和长短由话题决定。
        每帖新回复使用r1、r2等局部编号；parentId为空表示新楼层，填前面的r编号表示回复那一层。按父楼层在前、子回复在后的顺序列出，层数按交流需要展开。样例展示字段关系，实际人物、内容和对话形状由本次资料与讨论走向决定。
        """;
    private const string DiscussionPrompt = """

        你延续尖塔玩家论坛中的聊天。queued列出本次等待回应的发帖或留言，kind说明类型，postId定位帖子；对应原文在targets的Body或conversation中。每项queued内容都应得到回应，按原文的AuthorId识别说话者，玩家称呼见player.name。帖子中的mentionRequests记录提及对象，每个requiredAuthors人物都须回应对应messageId，并在covers中包含该消息。
        targets是本次可继续讨论的帖子。Body是正文，bodyKind=fact表示事件记录，opinion表示署名观点；officialRecord是官方记录，match是赛事资料，conversation是帖子讨论，conversationScope说明资料范围。people提供可参与的人物资料，otherSpeakers帮助识别引用中的其他说话者。playerRecord和career提供玩家的公开履历。schedule记录AsOfDay当天已公布的日程：Upcoming逐条说明具名选手的报名状态，RecentMeetings提供已完成的交手，RelatedFixtures是相关人物的近期对阵。
        memory是按人物和话题检索的历史记忆：fact为事件记录，opinion为人物当时的观点，引用保留归属。人物的回应可以承接这些经历，谈话重点与语气由这次留言、既有关系和性格共同决定。
        输出一个完整JSON对象：{"reactions":[{"postId":"t1","replies":[{"id":"r1","authorId":"u1","parentId":"c1","body":"回应内容"}]}]}
        reactions列出本次产生回复的帖子，每个postId出现一次，选自targets.Id。authorId选自该帖allowedAuthors。t为帖子编号，u为人物编号，c为已有楼层编号，均原样使用。程序保留玩家原文，将新回复加入对应讨论。
        每帖新回复依次使用r1、r2等局部编号。parentId为空表示新楼层，填本帖提供的c编号表示回复旧楼层，填前面的r编号表示继续接话；按父级在前、子级在后排列。
        直接回复queued的c编号，或在queued的原帖下新盖楼，程序会自动建立回应关系。合并回应多条留言或到后续相关帖子回应时，增加covers字段，值为此次回应的queued编号，例如"covers":["c1","c2"]；parentId仍表示目标帖子中的父楼层。
        样例说明字段和引用关系，具体人数、楼层结构与谈话走向由实际交流决定。
        """;
    private const string WeeklyProfilePrompt = """

        你是双周人物档案编辑，为profiles中全部列出的选手更新介绍。fromDay与asOfDay是本期起止日期。
        profiles中Id是人物编号，Name是姓名，Background是身份、俱乐部和惯用风格，History是历史统计，ThisWeek是本期正式比赛及结算资料，Previous是上一版编辑评价。累计通关/失败统计包含训练，正式比赛胜负见ThisWeek；玩家的结算生命是最后房间结束时的状态，剩余药水是结算库存，徽章括号内文字为原生判定条件。
        输出一个完整JSON对象：{"profiles":[{"id":"u1","body":"更新后的介绍"},{"id":"player","body":"玩家介绍"}]}。
        每个输入Id恰好返回一次，原样使用编号。body是当前完整介绍，程序用它更新档案并保存为下一期的历史评价。
        """;
    private const string WeeklyNewsPrompt = """

        你是尖塔双周刊编辑，为社区轮播精选撰写文章。fromDay与asOfDay是本期起止日期，week是截止周次。
        slides提供本期选题：Id是文章编号，Topic是题材，Facts是程序整理的正式赛果、事件及牌面资料，advertisement表示品牌或俱乐部推广。cooperation是截至asOfDay的玩家合作状态。结算生命指最后房间结束时的状态，剩余药水指结算库存，徽章描述是原生判定条件。每个选题的配图和展示顺序已经由程序安排。
        profiles提供相关人物的身份和截至本期末的介绍；memory是相关旧事，fact为事件记录，opinion为署名观点。schedule是本期末的公开日程快照，Upcoming逐条说明具名选手的报名状态，RecentMeetings是已完成的交手，RelatedFixtures是相关人物的近期对阵。文章可以连接本期与过去的经历，事件时间与观点归属按资料呈现。
        输出一个完整JSON对象：{"slides":[{"id":"s1","title":"标题","body":"完整正文"}]}。
        每个输入Id恰好返回一次，原样使用s编号；title与body分别是该篇标题和完整正文。
        """;
}

