# PromptLibrary.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`DD8ADE81C5C89FF2D83CD78115A250A22147E5A86548156A846CA9C8B04AC166`。来源：[源码](../../PromptLibrary.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PromptSection`、`NationalSpire.PromptTemplate`、`NationalSpire.PromptLibrary`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-5896cd50dee2"></a>

## `NationalSpire.PromptLibrary.LegacySections — public static IReadOnlyList<PromptSection> LegacySections`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.PromptSection.PromptSection(string, string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupChatPrompts.BigSummary`；`NationalSpire.GroupChatPrompts.Guide`；`NationalSpire.GroupChatPrompts.SmallSummary`；`NationalSpire.PrivateMessagePrompts.BigSummary`；`NationalSpire.PrivateMessagePrompts.Guide`；`NationalSpire.PrivateMessagePrompts.SmallSummary`；`NationalSpire.RandomEventPrompts.Story`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("discussion", "玩家帖子与回复", """          回复通常20—80字，复杂话题可展开。          """)`；返回值紧邻使用处：`ExpressionElementSyntax: new("discussion", "玩家帖子与回复", """          回复通常20—80字，复杂话题可展开。          """)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("event", "随机事件", RandomEventPrompts.Story)`；返回值紧邻使用处：`ExpressionElementSyntax: new("event", "随机事件", RandomEventPrompts.Story)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("group-long-summary", "群聊大总结", GroupChatPrompts.BigSummary)`；返回值紧邻使用处：`ExpressionElementSyntax: new("group-long-summary", "群聊大总结", GroupChatPrompts.BigSummary)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("group-summary", "群聊小总结", GroupChatPrompts.SmallSummary)`；返回值紧邻使用处：`ExpressionElementSyntax: new("group-summary", "群聊小总结", GroupChatPrompts.SmallSummary)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("group", "群聊提示词", GroupChatPrompts.Guide)`；返回值紧邻使用处：`ExpressionElementSyntax: new("group", "群聊提示词", GroupChatPrompts.Guide)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("news", "自动发帖", """          标题与正文由发帖者结合事实和人物立场独立创作。发帖者从自己关心的事情展开，评论者可以回应正文，也可以接着其他人的话讨论。真实表现与世界水平之间的差距、过去的交手、原有看法和个人偏好都可成为话题。篇幅通常为标题12—28字、正文60—140字、回复20—60字，随素材与谈话需要调整。          """)`；返回值紧邻使用处：`ExpressionElementSyntax: new("news", "自动发帖", """          标题与正文由发帖者结合事实和人物立场独立创作。发帖者从自己关心的事情展开，评论者可以回应正文，也可以接着其他人的话讨论。真实表现与世界水平之间的差距、过去的交手、原有看法和个人偏好都可成为话题。篇幅通常为标题12—28字、正文60—140字、回复20—60字，随素材与谈话需要调整。          """)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("private-long-summary", "私信大总结", PrivateMessagePrompts.BigSummary)`；返回值紧邻使用处：`ExpressionElementSyntax: new("private-long-summary", "私信大总结", PrivateMessagePrompts.BigSummary)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("private-summary", "私信小总结", PrivateMessagePrompts.SmallSummary)`；返回值紧邻使用处：`ExpressionElementSyntax: new("private-summary", "私信小总结", PrivateMessagePrompts.SmallSummary)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("private", "私信提示词", PrivateMessagePrompts.Guide)`；返回值紧邻使用处：`ExpressionElementSyntax: new("private", "私信提示词", PrivateMessagePrompts.Guide)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("profiles", "选手介绍", """          结合本期的变化与过去的经历写成连续的人物介绍。保留仍有依据的特点，新的事实可以推动评价发展。介绍可侧重近期状态、成绩的分量、长期特点或职业发展，选取与此人经历最相关的内容。正反馈来自实际成绩在这个世界中的价值。每人通常50—100字，素材较少时可更简短。保留有依据的人物特点，本期新增经历决定更新重点，使介绍自然发展。          """)`；返回值紧邻使用处：`ExpressionElementSyntax: new("profiles", "选手介绍", """          结合本期的变化与过去的经历写成连续的人物介绍。保留仍有依据的特点，新的事实可以推动评价发展。介绍可侧重近期状态、成绩的分量、长期特点或职业发展，选取与此人经历最相关的内容。正反馈来自实际成绩在这个世界中的价值。每人通常50—100字，素材较少时可更简短。保留有依据的人物特点，本期新增经历决定更新重点，使介绍自然发展。          """)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("voice", "社区共同文风", """          发言是人物此刻真正在意的一件事：喜爱的选手赢了会开心、想学的打法看懂一半会追问、自己的判断落空会尴尬或改口，失利也可能带来遗憾、恼火与安慰。情绪从本人经历、支持对象和眼前事实生长，强弱随事件分量变化。人物可以省略大家已知的赛报，直接说自己的反应；短句、迟疑、反问、接话、自嘲和熟人间的打趣都属于自然交流。克制的人也有自己的态度和在意之处。          尖塔社区口吻资源：          “我说xxxx有没有懂的”：表达某种观点，语气偏轻松、随口。          “别带/带吧多带”：起哄带某种梗或节奏，或在被带节奏时自嘲。          “xxxx了”：把卡牌名称当作动作或状态，借它形容眼前相似的行为或局面。keyCards和当前讨论提供的卡名可以成为这种联想的素材，贴切程度和接话兴致决定人物是否顺口借用。          “尝试攻杀大怪/尝试塞一张愤怒”：梗源是一位主播因策略问题排除攻杀大怪的路线，寻找通关世界线时持续受阻，最后作弊向弃牌堆塞了一张愤怒，随后承认作弊。常在遇到难以通过的怪物时引用；发言语义是借用这段典故调侃困难。          “塔学疑云”：熟悉机制表现得与常见情况相异或相反，又因代码问题难以解释。          这些表达供人物随语境选用。贴切场景可以直说，其他场景也可以借意引申；具体选用取决于身份、性格、熟悉程度与谈话走向。普通玩家和休闲观众通常更爱接梗，职业选手相对克制，熟人关系和个人习惯会影响这一倾向。          相关历史帮助人物记住发生过的事和彼此的态度。本次发言从眼前的新变化接着往下聊，近期出现过的开头、比喻、数字感叹和结论可以换一个关注点；只有确实延续的话题才承接原话。人物说出自己能知道的事情，语气贴合身份与关系，成绩带来的情绪和疑问落在具体细节上。          """)`；返回值紧邻使用处：`ExpressionElementSyntax: new("voice", "社区共同文风", """          发言是人物此刻真正在意的一件事：喜爱的选手赢了会开心、想学的打法看懂一半会追问、自己的判断落空会尴尬或改口，失利也可能带来遗憾、恼火与安慰。情绪从本人经历、支持对象和眼前事实生长，强弱随事件分量变化。人物可以省略大家已知的赛报，直接说自己的反应；短句、迟疑、反问、接话、自嘲和熟人间的打趣都属于自然交流。克制的人也有自己的态度和在意之处。          尖塔社区口吻资源：          “我说xxxx有没有懂的”：表达某种观点，语气偏轻松、随口。          “别带/带吧多带”：起哄带某种梗或节奏，或在被带节奏时自嘲。          “xxxx了”：把卡牌名称当作动作或状态，借它形容眼前相似的行为或局面。keyCards和当前讨论提供的卡名可以成为这种联想的素材，贴切程度和接话兴致决定人物是否顺口借用。          “尝试攻杀大怪/尝试塞一张愤怒”：梗源是一位主播因策略问题排除攻杀大怪的路线，寻找通关世界线时持续受阻，最后作弊向弃牌堆塞了一张愤怒，随后承认作弊。常在遇到难以通过的怪物时引用；发言语义是借用这段典故调侃困难。          “塔学疑云”：熟悉机制表现得与常见情况相异或相反，又因代码问题难以解释。          这些表达供人物随语境选用。贴切场景可以直说，其他场景也可以借意引申；具体选用取决于身份、性格、熟悉程度与谈话走向。普通玩家和休闲观众通常更爱接梗，职业选手相对克制，熟人关系和个人习惯会影响这一倾向。          相关历史帮助人物记住发生过的事和彼此的态度。本次发言从眼前的新变化接着往下聊，近期出现过的开头、比喻、数字感叹和结论可以换一个关注点；只有确实延续的话题才承接原话。人物说出自己能知道的事情，语气贴合身份与关系，成绩带来的情绪和疑问落在具体细节上。          """)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("weekly", "双周刊", """          根据题材选择有价值的叙述角度，比赛的资源、速度、对手、历史交手和选手变化都可形成观察。选题之间保持各自的关注点，文章的长度和结构随素材展开。标题通常12—24字，正文80—180字，资料较少时可更简短，段落用换行表示。已报道的事实可以简短承接，这一期侧重后来发生的变化，选择贴合题材的新开头与观察角度。          advertisement=true的文章采用轻松的推广口吻，创意来自给定选手、俱乐部、实际合作品牌及广告方向，读者是故事里的观众。          """)`；返回值紧邻使用处：`ExpressionElementSyntax: new("weekly", "双周刊", """          根据题材选择有价值的叙述角度，比赛的资源、速度、对手、历史交手和选手变化都可形成观察。选题之间保持各自的关注点，文章的长度和结构随素材展开。标题通常12—24字，正文80—180字，资料较少时可更简短，段落用换行表示。已报道的事实可以简短承接，这一期侧重后来发生的变化，选择贴合题材的新开头与观察角度。          advertisement=true的文章采用轻松的推广口吻，创意来自给定选手、俱乐部、实际合作品牌及广告方向，读者是故事里的观众。          """)`
- `NationalSpire.PromptSection.PromptSection(string, string, string)`；输入表达式：`new("world", "世界观与游戏知识", """          创作背景：《杀戮尖塔2》的电竞世界里，其他人的水平下降1000倍，玩家保持正常水平。故事中的人物把自己的水平当作生活常态。普通玩家主要挑战进阶0—3；青训在进阶6约有四至六成通关率；职业门槛是取得进阶8通关记录，普通职业选手在进阶7约有五至六成通关率；世界第一水平在进阶8约有五成通关率，顶尖选手凭自己在进阶9偶有突破；进阶10通常需要顶级选手与多名专家集中筛选极佳种子，才有极小机会通过一次。失败既可能发生在首幕，也常发生在后两幕。          人物习惯从固定流派、熟悉的核心牌和自己的练习经历理解成绩，对玩家兼顾抽牌、攻防、资源和终局的构筑方式感到陌生。评价尺度来自各自能力与经历：真实的速度、资源余量、徽章和连续成绩会带来佩服、好奇、学习意愿，也会改变过去的判断。日常交流仍有各自关心的话题和立场。          赛事按通关、用时、楼层决定成绩：通关者优先；双方通关比较用时；双方止步比较到达楼层。赛报中的“赛事进阶”是这场赛事的公开进阶。          这个世界的非职业选手完整通关平均花费八十至九十分钟，职业选手平均约一小时；强者参加较低进阶比赛会更稳、更快，大多数通关仍在四十五分钟以上。三十五分钟左右在当地已属于罕见的速通表现，中途失败的用时随止步楼层缩短。具体评论结合本场用时、赛事级别和已有记录形成。          世界中的普通玩家主要观赛和参加社区杯；青训通过选拔争取职业席位；职业选手效力于俱乐部。国内联赛连接世界大赛资格，洲际杯代表俱乐部，两赛季一届的世界杯代表国家；奇数赛季的世界总决赛决出个人冠军，其荣誉公示至下届结束。国际赛事的国运贡献用于选手奖励、国家建设，以及国内训练与青训发展。相关国家的当前条件和本次变化见所列资料。人物身份、俱乐部归属、晋级与荣誉以本次资料中记载的状态为准。          游戏知识：铁甲战士常使用力量、生命与消耗；静默猎手常使用中毒、弃牌与多次攻击；故障机器人的球位、充能、触发和集中影响攻防；亡灵契约师的奥斯蒂可以承受部分攻击伤害并参与攻击，末日是另一条输出线；储君使用辉星，部分卡牌同时消耗能量和辉星。          """)`；返回值紧邻使用处：`ExpressionElementSyntax: new("world", "世界观与游戏知识", """          创作背景：《杀戮尖塔2》的电竞世界里，其他人的水平下降1000倍，玩家保持正常水平。故事中的人物把自己的水平当作生活常态。普通玩家主要挑战进阶0—3；青训在进阶6约有四至六成通关率；职业门槛是取得进阶8通关记录，普通职业选手在进阶7约有五至六成通关率；世界第一水平在进阶8约有五成通关率，顶尖选手凭自己在进阶9偶有突破；进阶10通常需要顶级选手与多名专家集中筛选极佳种子，才有极小机会通过一次。失败既可能发生在首幕，也常发生在后两幕。          人物习惯从固定流派、熟悉的核心牌和自己的练习经历理解成绩，对玩家兼顾抽牌、攻防、资源和终局的构筑方式感到陌生。评价尺度来自各自能力与经历：真实的速度、资源余量、徽章和连续成绩会带来佩服、好奇、学习意愿，也会改变过去的判断。日常交流仍有各自关心的话题和立场。          赛事按通关、用时、楼层决定成绩：通关者优先；双方通关比较用时；双方止步比较到达楼层。赛报中的“赛事进阶”是这场赛事的公开进阶。          这个世界的非职业选手完整通关平均花费八十至九十分钟，职业选手平均约一小时；强者参加较低进阶比赛会更稳、更快，大多数通关仍在四十五分钟以上。三十五分钟左右在当地已属于罕见的速通表现，中途失败的用时随止步楼层缩短。具体评论结合本场用时、赛事级别和已有记录形成。          世界中的普通玩家主要观赛和参加社区杯；青训通过选拔争取职业席位；职业选手效力于俱乐部。国内联赛连接世界大赛资格，洲际杯代表俱乐部，两赛季一届的世界杯代表国家；奇数赛季的世界总决赛决出个人冠军，其荣誉公示至下届结束。国际赛事的国运贡献用于选手奖励、国家建设，以及国内训练与青训发展。相关国家的当前条件和本次变化见所列资料。人物身份、俱乐部归属、晋级与荣誉以本次资料中记载的状态为准。          游戏知识：铁甲战士常使用力量、生命与消耗；静默猎手常使用中毒、弃牌与多次攻击；故障机器人的球位、充能、触发和集中影响攻防；亡灵契约师的奥斯蒂可以承受部分攻击伤害并参与攻击，末日是另一条输出线；储君使用辉星，部分卡牌同时消耗能量和辉星。          """)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d988613378c8"></a>

## `NationalSpire.PromptLibrary.Normalize(string) — private static string Normalize(string value)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PromptLibrary.MergePrivateText(string, string)`](PromptLibrary.cs.md#symbol-7b690052ba47)；[`NationalSpire.PromptLibrary.Save(NationalSpire.AiOptions, string, string)`](PromptLibrary.cs.md#symbol-101a181e9f40)

**调用：** `string.Replace(string, string?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(string, string?)`；输入表达式：`value.Replace("\r\n", "\n")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: value.Replace("\r\n", "\n").Trim`
- `string.Trim()`；输入表达式：`value.Replace("\r\n", "\n").Trim()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => value.Replace("\r\n", "\n").Trim()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7b690052ba47"></a>

## `NationalSpire.PromptLibrary.MergePrivateText(string, string) — internal static string MergePrivateText(string guide, string style)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Merge(System.Collections.Generic.Dictionary<string, string>, string)`](PromptLibrary.cs.md#symbol-92376ebef44d)；[`NationalSpire.PromptLibrary.MergePrivatePrompt(NationalSpire.AiOptions)`](PromptLibrary.cs.md#symbol-b864e7d26d29)；[`NationalSpire.PromptTransfer.Validate(NationalSpire.PromptTransfer.Bundle)`](PromptTransfer.cs.md#symbol-c81f82a79264)

**调用：** [`NationalSpire.PromptLibrary.Normalize(string)`](PromptLibrary.cs.md#symbol-d988613378c8)；`string.Contains(string, System.StringComparison)`；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateMessagePrompts.LegacyStyle`；`NationalSpire.PromptLibrary.Normalize(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.Normalize(string)`；输入表达式：`Normalize(guide)`；返回值紧邻使用处：`AssignmentExpressionSyntax: guide = Normalize(guide)`
- `NationalSpire.PromptLibrary.Normalize(string)`；输入表达式：`Normalize(PrivateMessagePrompts.LegacyStyle)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Normalize(PrivateMessagePrompts.LegacyStyle)`
- `NationalSpire.PromptLibrary.Normalize(string)`；输入表达式：`Normalize(style)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style = Normalize(style)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`guide.Contains(previous, StringComparison.Ordinal)`；返回值紧邻使用处：`ConditionalExpressionSyntax: guide.Contains(previous, StringComparison.Ordinal) ? guide.Replace(previous, style) : guide + "\n\n" + style`
- `string.Contains(string, System.StringComparison)`；输入表达式：`guide.Contains(style, StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: style.Length == 0 || guide.Contains(style, StringComparison.Ordinal)`
- `string.Replace(string, string?)`；输入表达式：`guide.Replace(previous, style)`；返回值紧邻使用处：`ConditionalExpressionSyntax: guide.Contains(previous, StringComparison.Ordinal) ? guide.Replace(previous, style) : guide + "\n\n" + style`

**赋值（含属性/字段和局部值）：**

- `guide` = `Normalize(guide)`
- `style` = `Normalize(style)`

<a id="symbol-b864e7d26d29"></a>

## `NationalSpire.PromptLibrary.MergePrivatePrompt(NationalSpire.AiOptions) — public static void MergePrivatePrompt(AiOptions options)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`](PromptLibrary.cs.md#symbol-3f64d002bbbe)；[`NationalSpire.PromptLibrary.Save(NationalSpire.AiOptions, string, string)`](PromptLibrary.cs.md#symbol-101a181e9f40)

**调用：** [`Merge(System.Collections.Generic.Dictionary<string, string>, string)`](PromptLibrary.cs.md#symbol-92376ebef44d)；[`NationalSpire.PromptLibrary.MergePrivateText(string, string)`](PromptLibrary.cs.md#symbol-7b690052ba47)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `Merge(System.Collections.Generic.Dictionary<string, string>, string)`；`NationalSpire.AiOptions.CustomPromptTemplates`；`NationalSpire.AiOptions.PrivatePromptVersion`；`NationalSpire.AiOptions.PromptOverrides`；`NationalSpire.AiOptions.PromptTemplate`；`NationalSpire.AiOptions.PromptTemplateOverrides`；`NationalSpire.CustomPromptTemplate.Sections`；`NationalSpire.PrivateMessagePrompts.Guide`；`NationalSpire.PromptLibrary.MergePrivateText(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Merge(System.Collections.Generic.Dictionary<string, string>, string)`；输入表达式：`Merge(bank.Value, bank.Key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Merge(bank.Value, bank.Key);`
- `Merge(System.Collections.Generic.Dictionary<string, string>, string)`；输入表达式：`Merge(options.PromptOverrides, options.PromptTemplate)`；返回值紧邻使用处：`ExpressionStatementSyntax: Merge(options.PromptOverrides, options.PromptTemplate);`
- `NationalSpire.PromptLibrary.MergePrivateText(string, string)`；输入表达式：`MergePrivateText(custom.Sections.GetValueOrDefault("private", PrivateMessagePrompts.Guide), style)`；返回值紧邻使用处：`AssignmentExpressionSyntax: custom.Sections["private"] = MergePrivateText(custom.Sections.GetValueOrDefault("private", PrivateMessagePrompts.Guide), style)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey, out TValue)`；输入表达式：`custom.Sections.Remove("private-style", out var style)`；返回值紧邻使用处：`IfStatementSyntax: if (custom.Sections.Remove("private-style", out var style))                  custom.Sections["private"] = MergePrivateText(custom.Sections.GetValueOrDefault("private", PrivateMessagePrompts.Guide), style);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`custom.Sections.GetValueOrDefault("private", PrivateMessagePrompts.Guide)`；返回值紧邻使用处：`ArgumentSyntax: custom.Sections.GetValueOrDefault("private", PrivateMessagePrompts.Guide)`

**赋值（含属性/字段和局部值）：**

- `custom.Sections["private"]` = `MergePrivateText(custom.Sections.GetValueOrDefault("private", PrivateMessagePrompts.Guide), style)`
- `options.PrivatePromptVersion` = `1`

<a id="symbol-92376ebef44d"></a>

## `Merge(System.Collections.Generic.Dictionary<string, string>, string) — void Merge(Dictionary<string, string> values, string template)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PromptLibrary.MergePrivatePrompt(NationalSpire.AiOptions)`](PromptLibrary.cs.md#symbol-b864e7d26d29)

**调用：** [`NationalSpire.PromptLibrary.MergePrivateText(string, string)`](PromptLibrary.cs.md#symbol-7b690052ba47)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.CustomPromptTemplates`；`NationalSpire.CustomPromptTemplate.Sections`；`NationalSpire.PrivateMessagePrompts.Guide`；`NationalSpire.PromptLibrary.MergePrivateText(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.MergePrivateText(string, string)`；输入表达式：`MergePrivateText(values.GetValueOrDefault("private", fallback), style!)`；返回值紧邻使用处：`AssignmentExpressionSyntax: values["private"] = MergePrivateText(values.GetValueOrDefault("private", fallback), style!)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey, out TValue)`；输入表达式：`values.Remove("private-style", out var style)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = values.Remove("private-style", out var style)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`values.GetValueOrDefault("private", fallback)`；返回值紧邻使用处：`ArgumentSyntax: values.GetValueOrDefault("private", fallback)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Sections.GetValueOrDefault("private")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: options.CustomPromptTemplates.GetValueOrDefault(template)?.Sections.GetValueOrDefault("private")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`options.CustomPromptTemplates.GetValueOrDefault(template)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: options.CustomPromptTemplates.GetValueOrDefault(template)?.Sections.GetValueOrDefault("private")`

**赋值（含属性/字段和局部值）：**

- `values["private"]` = `MergePrivateText(values.GetValueOrDefault("private", fallback), style!)`

<a id="symbol-09cee4947d64"></a>

## `NationalSpire.PromptLibrary.EditableText(string, string) — internal static string EditableText(string id, string text)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PromptLibrary.Default(NationalSpire.AiOptions, string)`](PromptTemplates.cs.md#symbol-7db48705d31b)；[`NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`](PromptLibrary.cs.md#symbol-3f64d002bbbe)；[`NationalSpire.PromptLibrary.Save(NationalSpire.AiOptions, string, string)`](PromptLibrary.cs.md#symbol-101a181e9f40)；[`NationalSpire.PromptTransfer.Export(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, string>)`](PromptTransfer.cs.md#symbol-0bce76771cbe)；[`NationalSpire.PromptTransfer.Validate(NationalSpire.PromptTransfer.Bundle)`](PromptTransfer.cs.md#symbol-c81f82a79264)

**调用：** `string.Contains(string, System.StringComparison)`；`string.Replace(string, string?, System.StringComparison)`；`string.Replace(string, string?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventPrompts.Format`；`NationalSpire.RandomEventPrompts.Story`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Contains(string, System.StringComparison)`；输入表达式：`normalized.Contains(format, StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !normalized.Contains(format, StringComparison.Ordinal)`
- `string.Replace(string, string?, System.StringComparison)`；输入表达式：`normalized.Replace(format, "", StringComparison.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: normalized.Replace(format, "", StringComparison.Ordinal).Trim`
- `string.Replace(string, string?)`；输入表达式：`RandomEventPrompts.Format.Replace("\r\n", "\n")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RandomEventPrompts.Format.Replace("\r\n", "\n")`
- `string.Replace(string, string?)`；输入表达式：`RandomEventPrompts.Story.Replace("\r\n", "\n")`；返回值紧邻使用处：`BinaryExpressionSyntax: story == RandomEventPrompts.Story.Replace("\r\n", "\n")`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("\r\n", "\n")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.Replace("\r\n", "\n")`
- `string.Trim()`；输入表达式：`normalized.Replace(format, "", StringComparison.Ordinal).Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = normalized.Replace(format, "", StringComparison.Ordinal).Trim()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6fd3bcbfdaca"></a>

## `NationalSpire.PromptLibrary.IsCustom(NationalSpire.AiOptions, string) — public static bool IsCustom(AiOptions options, string id)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Show()`](PromptScreen.cs.md#symbol-26218fc52477)

**调用：** `string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.PromptOverrides`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(text)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`.TryGetValue(id, out var text)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: options.PromptOverrides?.TryGetValue(id, out var text)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3f64d002bbbe"></a>

## `NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string) — public static string Get(AiOptions options, string id)`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ChangeTemplate(System.Action, string, bool)`](PromptScreen.cs.md#symbol-32c868c23420)；[`NationalSpire.AiService.Summarize(NationalSpire.CareerData, string, string, string)`](AiPrivateMessages.cs.md#symbol-1ec00f25b0bb)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.Coop.CoopCoordinator.Broadcast()`](Coop/CoopCoordinator.cs.md#symbol-8a047804722d)；[`NationalSpire.GroupChatPrompts.Section(NationalSpire.CareerData, string)`](GroupChatPrompts.cs.md#symbol-faefbd7982b5)；[`NationalSpire.PortraitDesigns.Messages(NationalSpire.CareerData, string, NationalSpire.PortraitDesign)`](PortraitDesign.cs.md#symbol-3f8b0db3fc3f)；[`NationalSpire.PrivateMessagePrompts.Section(NationalSpire.CareerData, string)`](PrivateMessagePrompts.cs.md#symbol-9529e63edd53)；[`NationalSpire.PromptLibrary.CreateTemplate(NationalSpire.AiOptions, string, string)`](CustomPromptTemplates.cs.md#symbol-89804de92137)；[`NationalSpire.PromptLibrary.Editorial(NationalSpire.AiOptions, string)`](PromptLibrary.cs.md#symbol-cdd41a28416a)；[`NationalSpire.RandomEventPrompts.Compose(NationalSpire.RandomEventRecord, NationalSpire.AiOptions?)`](RandomEventPrompts.cs.md#symbol-81f58f271386)；[`SaveDrafts()`](PromptScreen.cs.md#symbol-52d59cd4371f)

**调用：** [`NationalSpire.PromptLibrary.Default(NationalSpire.AiOptions, string)`](PromptTemplates.cs.md#symbol-7db48705d31b)；[`NationalSpire.PromptLibrary.EditableText(string, string)`](PromptLibrary.cs.md#symbol-09cee4947d64)；[`NationalSpire.PromptLibrary.MergePrivatePrompt(NationalSpire.AiOptions)`](PromptLibrary.cs.md#symbol-b864e7d26d29)；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.PromptOverrides`；`NationalSpire.PromptLibrary.Default(NationalSpire.AiOptions, string)`；`NationalSpire.PromptLibrary.EditableText(string, string)`；`NationalSpire.PromptLibrary.MergePrivatePrompt(NationalSpire.AiOptions)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.Default(NationalSpire.AiOptions, string)`；输入表达式：`Default(options, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Default(options, id)`
- `NationalSpire.PromptLibrary.EditableText(string, string)`；输入表达式：`EditableText(id, custom)`；返回值紧邻使用处：`ConditionalExpressionSyntax: options.PromptOverrides != null && options.PromptOverrides.TryGetValue(id, out var custom)              && !string.IsNullOrWhiteSpace(custom) ? EditableText(id, custom) : fallback`
- `NationalSpire.PromptLibrary.EditableText(string, string)`；输入表达式：`EditableText(id, legacyEvent)`；返回值紧邻使用处：`ReturnStatementSyntax: return EditableText(id, legacyEvent);`
- `NationalSpire.PromptLibrary.MergePrivatePrompt(NationalSpire.AiOptions)`；输入表达式：`MergePrivatePrompt(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: MergePrivatePrompt(options);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(custom)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(custom)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(legacyEvent)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(legacyEvent)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`options.PromptOverrides.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !options.PromptOverrides.ContainsKey(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`options.PromptOverrides.TryGetValue("events", out var legacyEvent)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "event" && !options.PromptOverrides.ContainsKey(id) && options.PromptOverrides.TryGetValue("events", out var legacyEvent)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`options.PromptOverrides.TryGetValue(id, out var custom)`；返回值紧邻使用处：`BinaryExpressionSyntax: options.PromptOverrides != null && options.PromptOverrides.TryGetValue(id, out var custom)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-101a181e9f40"></a>

## `NationalSpire.PromptLibrary.Save(NationalSpire.AiOptions, string, string) — public static void Save(AiOptions options, string id, string text)`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)；[`SaveDrafts()`](PromptScreen.cs.md#symbol-52d59cd4371f)

**调用：** [`NationalSpire.PromptLibrary.Default(NationalSpire.AiOptions, string)`](PromptTemplates.cs.md#symbol-7db48705d31b)；[`NationalSpire.PromptLibrary.EditableText(string, string)`](PromptLibrary.cs.md#symbol-09cee4947d64)；[`NationalSpire.PromptLibrary.MergePrivatePrompt(NationalSpire.AiOptions)`](PromptLibrary.cs.md#symbol-b864e7d26d29)；[`NationalSpire.PromptLibrary.Normalize(string)`](PromptLibrary.cs.md#symbol-d988613378c8)；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.PromptOverrides`；`NationalSpire.PromptLibrary.Default(NationalSpire.AiOptions, string)`；`NationalSpire.PromptLibrary.EditableText(string, string)`；`NationalSpire.PromptLibrary.MergePrivatePrompt(NationalSpire.AiOptions)`；`NationalSpire.PromptLibrary.Normalize(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.Default(NationalSpire.AiOptions, string)`；输入表达式：`Default(options, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Default(options, id)`
- `NationalSpire.PromptLibrary.EditableText(string, string)`；输入表达式：`EditableText(id, text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = EditableText(id, text)`
- `NationalSpire.PromptLibrary.MergePrivatePrompt(NationalSpire.AiOptions)`；输入表达式：`MergePrivatePrompt(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: MergePrivatePrompt(options);`
- `NationalSpire.PromptLibrary.Normalize(string)`；输入表达式：`Normalize(fallback)`；返回值紧邻使用处：`BinaryExpressionSyntax: Normalize(text) == Normalize(fallback)`
- `NationalSpire.PromptLibrary.Normalize(string)`；输入表达式：`Normalize(text)`；返回值紧邻使用处：`BinaryExpressionSyntax: Normalize(text) == Normalize(fallback)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(text)) throw new ArgumentException("提示词不能为空。");`
- `string.Trim()`；输入表达式：`text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.PromptOverrides[id] = text.Trim()`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("提示词不能为空。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("提示词不能为空。");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.PromptOverrides ??= new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`options.PromptOverrides.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.PromptOverrides.Remove(id);`

**赋值（含属性/字段和局部值）：**

- `options.PromptOverrides[id]` = `text.Trim()`
- `options.PromptOverrides` ??= `new()`
- `text` = `EditableText(id, text)`

<a id="symbol-c28599eab58e"></a>

## `NationalSpire.PromptLibrary.Reset(NationalSpire.AiOptions, string) — public static void Reset(AiOptions options, string id)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.PromptOverrides`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`.Remove(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: options.PromptOverrides?.Remove(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cdd41a28416a"></a>

## `NationalSpire.PromptLibrary.Editorial(NationalSpire.AiOptions, string) — public static string Editorial(AiOptions options, string scene)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ComposeSystem(NationalSpire.AiOptions, string)`](AiPrompts.cs.md#symbol-7a07a16bbdcd)

**调用：** [`NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`](PromptLibrary.cs.md#symbol-3f64d002bbbe)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`；输入表达式：`Get(options, "voice")`；返回值紧邻使用处：`ConditionalExpressionSyntax: scene is "news" or "discussion" ? Get(options, "voice") : ""`
- `NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`；输入表达式：`Get(options, "world")`；返回值紧邻使用处：`InitializerExpressionSyntax: { Get(options, "world"), scene is "news" or "discussion" ? Get(options, "voice") : "", Get(options, scene) }`
- `NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`；输入表达式：`Get(options, scene)`；返回值紧邻使用处：`InitializerExpressionSyntax: { Get(options, "world"), scene is "news" or "discussion" ? Get(options, "voice") : "", Get(options, scene) }`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n",          new[] { Get(options, "world"), scene is "news" or "discussion" ? Get(options, "voice") : "", Get(options, scene) }              .Where(s => s.Length > 0))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => string.Join("\n\n",          new[] { Get(options, "world"), scene is "news" or "discussion" ? Get(options, "voice") : "", Get(options, scene) }              .Where(s => s.Length > 0))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { Get(options, "world"), scene is "news" or "discussion" ? Get(options, "voice") : "", Get(options, scene) }              .Where(s => s.Length > 0)`；返回值紧邻使用处：`ArgumentSyntax: new[] { Get(options, "world"), scene is "news" or "discussion" ? Get(options, "voice") : "", Get(options, scene) }              .Where(s => s.Length > 0)`

**赋值（含属性/字段和局部值）：**
