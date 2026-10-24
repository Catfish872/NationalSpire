using System.Text.Json;

namespace NationalSpire;

public static class RandomEventPrompts
{
    private static readonly JsonSerializerOptions Json = new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
    private const string Participants = "资料中的相关人物是本次参与者。人物效果使用本次参与者中的人物编号；相关人物为空时，创作玩家独自经历的单人事件。";
    private const string PlayerFacts = "玩家信息必须以提供的事实为基准，不允许编造玩家的历史经历和比赛战绩。";
    internal const string WorldGuidance = "世界观资料用于保持社会背景、人物认知和实力尺度一致。故事以本次素材中的人物、处境和情感为中心，让世界设定通过生活细节自然体现。卡牌、怪物和打法知识在情节确有需要时使用，不要强行套用或强制使用；普通生活题材按其自身的趣味展开。叙述文风与人物语言遵循随机事件模板中的创作要求，文笔优美引人入胜。";
    public const string Story = """
为玩家创作一段精彩、自然以及有趣的互动故事，并根据情况提供2-4个行动选项。故事需要保持完整，玩家的选项应当是故事的最终决定，无论如何在选择后这段故事会结束，所以你不能在选项里留下需要后续推进的故事发展伏笔。
以玩家的游戏体验为核心目标，在事件中禁止做出无解困局、全部负面等导致玩家游戏体验下降的故事。
""";
    private const string LegacyInitialFormat = """
按顺序输出逐行JSON：标题、故事正文、行动选项。每段正文使用一条story记录。每个选项包含option行动文字、result选择后的完整结局、effects实际效果。效果与结局相符，数值正负表示增加和减少。没有数值变化时effects填写空数组。
故事和选项文字使用人物称呼，效果使用人物编号。result写明今天已经完成的结局；约战写明已经约定，其他交易、检测、退款等在本次结局内完成。涉及金额时，文字中的收支合计与wallet保持一致。
格式示例：
{"title":"雨后的屋檐"}
{"story":"街角的雨停了，橱窗里还挂着几串水珠。"}
{"option":"留下来修好设备","result":"你们完成修理，店员重新点亮了招牌。","effects":[{"wallet":-800},{"favour":"p2","value":3}]}
{"option":"借用备用设备","result":"备用设备顺利接上电源，这次聚会照常结束。","effects":[]}
""";
    private const string LegacyEffects = """
可用效果及完整字段示例：
{"wallet":-800}：玩家钱包变化，单位美元。
{"fans":150}：玩家关注人数变化。
{"clubFans":150}：玩家经营俱乐部的关注人数变化。
{"item":"mouse","count":1}：玩家库存变化；商品编号来自本轮资料。
{"favour":"p2","value":3}：指定人物对玩家的好感变化。
{"impression":"p2","text":"愿意花时间把小事做好的人"}：指定人物对玩家的印象。
{"status":"p2","name":"轻松专注","percent":2,"days":3}：人物模拟发挥的临时加成，percent填百分比，2表示2%，负数表示减弱。
{"learning":"p2","percent":0.1}：人物长期模拟水平变化，0.1表示0.1%。
{"market":"brand_id","percent":1.2}：指定品牌参考报价变化1.2%。
{"development":"中国","points":2}：该国获得2点国运对应的建设投入。
{"challenge":"p2","date":"2026-01-18","ascension":6,"mode":"切磋"}：与该人物约定一场比赛；mode填写切磋或挑战。选中后直接加入日程。
人物、商品、品牌和日期采用本轮资料。临时状态通常为±1%至±3%、持续2至5天；长期学习通常为0.05%至0.2%；品牌行情通常为±0.3%至±1.5%；国运建设通常1至3点。好感一般变化1至4点，重要互动5至8点。资金与关注根据本轮经济参考、人物身份和事情规模选择。每项效果只填写对应示例中的字段。
人物的行为承接其身份、关系和已知经历；资料中的恶意行为可选人物才可针对玩家实施欺骗、陷害或胁迫。人物也可以帮助玩家、提供提醒或与玩家共同遭遇问题。
""";
    // 旧模板包含这段完整原文，导入时继续据此分离固定格式。
    public const string Format = LegacyInitialFormat + "\n" + LegacyEffects;
    public static readonly string InitialFormat = LegacyInitialFormat.Replace("，数值正负表示增加和减少", "");
    internal static string EffectInstructions(CareerData data) => """
可用效果及完整字段示例：

{"wallet":-800}：玩家钱包变化，单位美元。正数表示收入，负数表示支出。

{"fans":150}：玩家关注人数变化，填写整数。
""" + (OwnedClubs.IsOwner(data) ? "\n\n{\"clubFans\":150}：玩家经营俱乐部的关注人数变化，填写整数。" : "") + "\n\n" + """
{"item":"mouse","count":1}：玩家库存变化。item填写本轮商品资料中的商品编号；count填写整数，正数表示获得，负数表示消耗。

{"favour":"p2","value":3}：指定NPC对玩家的好感变化。favour填写NPC的人物编号，value填写整数。

{"impression":"p2","text":"愿意花时间把小事做好的人"}：指定NPC对玩家的印象。impression填写NPC的人物编号，text填写更新后的印象。

{"status":"p2","name":"轻松专注","percent":2,"days":3}：指定NPC在模拟比赛中的临时发挥变化。status填写NPC的人物编号，name填写状态名称，percent填写百分比，days填写持续的正整数天数。2表示增加2%，负数表示减弱。

{"learning":"p2","percent":0.1}：指定NPC的长期模拟比赛能力变化。learning填写NPC的人物编号，percent填写百分比，0.1表示增加0.1%，负数表示减弱。

{"market":"brand_id","percent":1.2}：指定品牌参考报价变化。market填写本轮品牌资料中的品牌编号，percent填写百分比，1.2表示上涨1.2%，负数表示下跌。

{"development":"中国","points":2}：指定国家获得建设投入。development填写本轮国家资料中的国家名称，points填写非负整数，2表示2点国运对应的建设投入。

{"challenge":"p2","date":"2026-01-18","ascension":6,"mode":"切磋"}：玩家与指定NPC约定一场比赛。challenge填写NPC的人物编号，date填写公历日期，ascension填写0至10的整数，mode填写切磋或挑战。日期采用本赛季或下赛季中尚未过去的日期。选中后直接加入日程。

favour、impression、status、learning、challenge中的人物编号均指NPC，不能填写玩家编号、玩家昵称或人物姓名。status和learning调整NPC的模拟比赛能力，不能用于改变玩家的实战能力。
""" + "\n\n" + Participants + "示例中的人物编号、商品编号、品牌编号和日期仅用于说明格式，实际填写采用本轮资料。\n\n" + """
临时状态通常为±1%至±3%、持续2至5天；长期学习通常为0.05%至0.2%；品牌行情通常为±0.3%至±1.5%；国运建设通常1至3点。好感一般变化1至4点，重要互动5至8点。资金与关注根据本轮经济参考、人物身份和事情规模选择。

一个选项可以包含多个效果，每个效果分别填写一个JSON对象，每项效果只填写对应示例中的字段。没有实际变化时，effects填写空数组。

人物的行为承接其身份、关系和已知经历；资料中的恶意行为可选人物才可针对玩家实施欺骗、陷害或胁迫。人物也可以帮助玩家、提供提醒或与玩家共同遭遇问题。
""" + "\n\n" + PlayerFacts;
    public const string Continuation = """
上轮故事已经生成完成。玩家现在提出了一项自定义行动，本轮任务是承接已有故事，为这项行动写出完整结局及实际效果。

沿用前文模板中的文风、人物塑造和游戏体验要求。根据前文提供的信息和玩家的实际选择，将这个故事推进到结束，结束段文本在50-200字左右。

结局应当延续上文故事的文风、叙述口吻和人物说话方式，按照前文模板中的具体文风要求写成故事正文的结尾，让玩家能够读到行动发生后的故事。

本轮输出一条JSON记录，包含result、effects两个字段：
result填写这项行动结束后的完整结局。
effects按照前文的效果字段规则填写实际变化；没有实际变化时填写空数组。
""";
    internal static string PlayerRecord(CareerData data) => JsonSerializer.Serialize(new
    {
        玩家资料 = PrivatePublicContext.PlayerProfile(data),
        玩家战绩 = new
        {
            近期比赛 = data.Results.OrderByDescending(r => r.Day).Take(5).Select(r => new
            {
                日期 = GameCalendar.Iso(data, r.Day), 赛事 = r.Event, 对手 = r.Opponent, 结果 = r.Outcome
            })
        }
    }, Json);
    public static List<Dictionary<string, string>> Compose(CareerData data, RandomEventRecord record, AiOptions? options = null, bool custom = false)
    {
        List<Dictionary<string, string>> messages =
        [new() { ["role"] = "system", ["content"] = PromptLibrary.Get(options ?? data.Ai, "world") + "\n\n" + WorldGuidance + "\n\n" + EffectInstructions(data) },
         new() { ["role"] = "user", ["content"] = (options == null ? Story : PromptLibrary.Get(options, "event")) + "\n" + (record.PublicPosts.Length > 0 ? record.PublicPosts + "\n" : "") + PlayerRecord(data) + "\n" + record.Materials }];
        if (custom)
        {
            messages.Add(new() { ["role"] = "assistant", ["content"] = JsonSerializer.Serialize(new { title = record.Title, story = record.Story }, Json) });
            messages.Add(new() { ["role"] = "user", ["content"] = Continuation + "\n" + JsonSerializer.Serialize(new { action = record.CustomAction }, Json) });
        }
        else messages.Add(new() { ["role"] = "user", ["content"] = InitialFormat });
        return messages;
    }
    public static string Materials(CareerData d, RandomEventRecord e)
    {
        var people = e.People.Select(id => CareerEngine.Person(d, id)!).ToArray();
        var search = new CommunityMemorySearch.Request();
        var recentPlayerPosts = search.RecentPlayerPosts(d, d.Day);
        e.PublicPosts = PrivatePublicContext.PostBodies(d, recentPlayerPosts);
        var memories = CommunityMemorySearch.Retrieve(d, e.Seed, e.People.Append(GroupChats.Human(d)), d.Day, new HashSet<string>(), 8, request: search);
        return JsonSerializer.Serialize(new
        {
            日期 = GameCalendar.Iso(d, d.Day), 事件时段 = "故事与所选结局都发生在今天，选择完成后游戏日期保持当天。约战效果登记未来比赛，当前结局写到约定达成为止。", 玩家 = CareerEngine.Name(d), 故事素材 = e.Seed,
            相关人物 = people.Select(p => new { 编号 = p.Id, 资料 = PrivatePublicContext.CharacterProfile(d, p), 经历 = PrivatePublicContext.Profiles(d, p, includeConversation: false, includePlayer: false), 好感 = PrivateMessages.Favour(d, p.Id), 关系 = PrivateMessages.Relation(d, p.Id) }),
            恶意行为可选人物 = people.Where(p => PrivateMessages.Favour(d, p.Id) <= 0).Select(p => p.Id),
            会话总结 = ChatTimeline.Summaries(d, e.People),
            近期交流 = ChatTimeline.External(d, e.People).DistinctBy(x => (x.Order, x.Source)).OrderBy(x => x.Day).ThenBy(x => x.Order).TakeLast(20).Select(x => ChatTimeline.Text(d, x)),
            社区资料 = PrivatePublicContext.CommunitySources(d, memories, e.People.Append(GroupChats.Human(d)), e.Seed, search, recentPlayerPosts),
            国家生活 = NationalDevelopment.Context(d, people.Select(p => p.Country).Append(d.Esports.Country)),
            当天比赛 = d.Matches.Where(m => m.Day == d.Day).Select(m => new { m.Event, m.Status, m.OpponentId, m.PlayerWon, m.PlayerFloor, m.PlayerSeconds }),
            当天活动 = SocialAppointments.All(d).Where(a => PrivateAppointments.Date(d, a.Offer) == d.Day).Select(a => new { a.Offer.Title, a.Offer.Detail, a.Offer.State }),
            经济参考 = new { 钱包美元 = CareerMoney.Balance(d) * 10, 个人关注 = d.Fans, 经营俱乐部 = d.Esports.OwnedClub?.ClubId,
                日常收入参考美元 = Math.Max(100, CareerIncome.PersonalAttention(d.Fans) * 10 / 7), 资金建议 = "日常花费或小额报酬接近日常收入参考的5%至25%；重要机会可达50%至150%。根据实际商品价格和具体交易调整。" },
            商品 = ConsumerCatalog.All.Where(g => g.Collectible).Select(g => new { 编号 = g.Id, g.Name, 价格美元 = ConsumerEngine.Price(g), 库存 = d.Life.Consumer.Goods.Where(x => x.Id == g.Id && !x.Consumed).Sum(x => x.Quantity) }),
            品牌 = MarketCatalog.Assets.Where(a => !a.Forex).Select(a => new { 编号 = a.Id, a.Name }),
            俱乐部 = d.Esports.Clubs.Where(c => c.Id == d.Esports.ClubId || people.Any(p => p.ClubId == c.Id)).Select(c => new { c.Id, c.Name })
        }, Json);
    }
}
