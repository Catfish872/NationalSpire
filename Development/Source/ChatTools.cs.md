# ChatTools.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`BDB0C17F7CD431097EFA2C9F088AE2F63E3FA69910A068A0C8E4502802B3D693`。来源：[源码](../../ChatTools.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ChatTools`、`NationalSpire.ChatTools.Scope`、`NationalSpire.ChatTools.Feature`、`NationalSpire.ChatToolCall`、`NationalSpire.ChatToolRequest`、`NationalSpire.ChatReplyStream`、`NationalSpire.ChatReplyStream.Frame`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly AsyncLocal<bool> PromptMode = new();
public const string ActivityIntentGuidance = "玩家主动提出活动，就视为有参加意愿；人物答应后就登记活动。无须玩家再重复确认或说明具体小时。";
public const string TeachingGuidance = "先区分讲解者与学习者。玩家讲解自己已经掌握的做法，属于教学；只有听取新做法、形成新理解并决定采用的非玩家的NPC，才按上述条件登记学习变化。玩家被教学、NPC作为教学者时，不登记学习变化。只有NPC获得教学时，才登记学习变化";
public const string Guidance = "每轮通过一次 send_message 提交完整回复。先在 Reasoning 中整理本轮相关事实、人物反应和交互决定，再在 Replies 中按顺序填写完整的角色回复，最后在 Interactions 中登记全部实际交互；没有交互填 []。Reasoning 供玩家展开查看，Reply 是聊天正文，沿用当前模板的文风、人物语言与篇幅要求。根据本轮话语和上下文判断交互：新约定采用邀请；处理已有待处理卡片时，按其实际种类和编号登记接受、拒绝或改期。已经确认并赴约的活动按当前场景继续交流。人物在交流中形成长期性格、观念或习惯变化时，按 profile 说明填写交互；同时发生学习变化时，再按 skill 说明填写对应交互。先核实信息再评价属于 profile 的判断依据；学会选牌、出牌或构筑等具体做法属于 skill。两者同时发生时分别填写。各项交互的适用条件与参数含义见 Interactions。";
public const string OrdinaryGuidance = "普通交流指本轮没有符合各项交互说明、需要登记的决定或变化：没有比赛约战、训练计划、阵容调整、生活活动、合同、赠礼、誓约或代发帖子的决定，没有好感、态度、关系、长期学习、临时状态或长期人物资料变化，也没有本次要求提交的约会日记。只有这些交互均未发生时，Interactions 才填 []，Replies 仍填写完整正文。约会、出游和按日期安排的交流、聊天都属于生活活动。例如玩家提出今晚交流一下，人物答应后，本轮就有生活活动邀请，按 activity 填写。已经赴约后的交谈，根据本轮实际发生的变化登记交互。";
public static readonly string GroupSpeech = "Replies 按实际发言顺序填写，每段先填 Speaker 人物编号，再填该人物的完整 Reply；Speaker 填本群可发言的 NPC 编号，真人消息由本人发送。交互中的 Actor、Target 各按其说明填写。\n" + GroupChatPrompts.SpeechFormat.Split('\n')[1];
public const string AttachmentGuide = "请根据附件的内容和实际商谈，在 send_message 的 Interactions 中登记处理结果。参数使用这个附件的编号、人物与日期；接受、拒绝或改期按对应交互说明填写。";
private readonly StringBuilder _arguments = new();
private readonly Dictionary<string, ChatTools.Feature> _features;
private readonly Dictionary<int, ChatReplyStream> _streams = [];
public char Kind = kind;
public bool Replies = replies, Paragraph = paragraph, KeyExpected = kind == '{', Opened;
public string Key = "";
public Dictionary<string, string> Metadata = [];
public StringBuilder Pending = new();
private readonly Stack<Frame> _frames = new();
private readonly StringBuilder _token = new();
private bool _quoted, _key, _escape;
private int _unicodeLeft, _unicode;
private string _field = "";
private Frame? _owner;
```

<a id="symbol-90e497fd0db7"></a>

## `NationalSpire.ChatTools.InPrompt — public static bool InPrompt`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTools.PromptMode`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ad4027d40944"></a>

## `NationalSpire.ChatTools.Enabled(NationalSpire.AiOptions, bool?) — public static bool Enabled(AiOptions options, bool? mode)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.CareerScreen.PreviewPrivatePrompt()`](PrivateMessageScreen.cs.md#symbol-aefc38a1fba3)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.ChatTools`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-707a5bc989b5"></a>

## `NationalSpire.ChatTools.Enter(bool) — public static IDisposable Enter(bool enabled)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** `NationalSpire.ChatTools.Scope.Scope(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTools.PromptMode`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTools.Scope.Scope(bool)`；输入表达式：`new Scope(previous)`；返回值紧邻使用处：`ReturnStatementSyntax: return new Scope(previous);`

**赋值（含属性/字段和局部值）：**

- `PromptMode.Value` = `enabled`

<a id="symbol-b2e448137bf1"></a>

## `NationalSpire.ChatTools.Scope.Dispose() — public void Dispose()`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTools.PromptMode`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `PromptMode.Value` = `previous`

<a id="symbol-5f8a91babba0"></a>

## `NationalSpire.ChatTools.CompletePrompt(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool) — public static List<Dictionary<string, string>> CompletePrompt(List<Dictionary<string, string>> messages, bool ending = false)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)

**调用：** [`NationalSpire.GroupInteractions.PromptText(string)`](GroupInteractions.cs.md#symbol-f13ffcf92c94)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTools.InPrompt`；`NationalSpire.DateDiaries.ToolEnding`；`NationalSpire.GroupInteractions.PromptText(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupInteractions.PromptText(string)`；输入表达式：`GroupInteractions.PromptText(message["content"])`；返回值紧邻使用处：`AssignmentExpressionSyntax: message["content"] = GroupInteractions.PromptText(message["content"])`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["role"] = "system", ["content"] = ending ? DateDiaries.ToolEnding : "请调用 send_message 完成本轮回复，按 Reasoning、Replies、Interactions 的顺序填写。Reasoning 根据本轮提供的事实整理人物反应与实际交互决定；Replies 保持前文模板要求的文风、人物语言和篇幅，填写完整正文。正文中已经作出的交互决定，包括邀请、接受、拒绝、改期，以及学习、状态和人物资料变化，都在 Interactions 中填写对应交互。普通聊天也填写完整 Replies，确实没有交互时 Interactions 填 []。" }`；返回值紧邻使用处：`ArgumentSyntax: new() { ["role"] = "system", ["content"] = ending ? DateDiaries.ToolEnding : "请调用 send_message 完成本轮回复，按 Reasoning、Replies、Interactions 的顺序填写。Reasoning 根据本轮提供的事实整理人物反应与实际交互决定；Replies 保持前文模板要求的文风、人物语言和篇幅，填写完整正文。正文中已经作出的交互决定，包括邀请、接受、拒绝、改期，以及学习、状态和人物资料变化，都在 Interactions 中填写对应交互。普通聊天也填写完整 Replies，确实没有交互时 Interactions 填 []。" }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`messages.Add(new() { ["role"] = "system", ["content"] = ending ? DateDiaries.ToolEnding : "请调用 send_message 完成本轮回复，按 Reasoning、Replies、Interactions 的顺序填写。Reasoning 根据本轮提供的事实整理人物反应与实际交互决定；Replies 保持前文模板要求的文风、人物语言和篇幅，填写完整正文。正文中已经作出的交互决定，包括邀请、接受、拒绝、改期，以及学习、状态和人物资料变化，都在 Interactions 中填写对应交互。普通聊天也填写完整 Replies，确实没有交互时 Interactions 填 []。" })`；返回值紧邻使用处：`ExpressionStatementSyntax: messages.Add(new() { ["role"] = "system", ["content"] = ending ? DateDiaries.ToolEnding : "请调用 send_message 完成本轮回复，按 Reasoning、Replies、Interactions 的顺序填写。Reasoning 根据本轮提供的事实整理人物反应与实际交互决定；Replies 保持前文模板要求的文风、人物语言和篇幅，填写完整正文。正文中已经作出的交互决定，包括邀请、接受、拒绝、改期，以及学习、状态和人物资料变化，都在 Interactions 中填写对应交互。普通聊天也填写完整 Replies，确实没有交互时 Interactions 填 []。" });`

**赋值（含属性/字段和局部值）：**

- `["content"]` = `ending ? DateDiaries.ToolEnding : "请调用 send_message 完成本轮回复，按 Reasoning、Replies、Interactions 的顺序填写。Reasoning 根据本轮提供的事实整理人物反应与实际交互决定；Replies 保持前文模板要求的文风、人物语言和篇幅，填写完整正文。正文中已经作出的交互决定，包括邀请、接受、拒绝、改期，以及学习、状态和人物资料变化，都在 Interactions 中填写对应交互。普通聊天也填写完整 Replies，确实没有交互时 Interactions 填 []。"`
- `["role"]` = `"system"`
- `message["content"]` = `GroupInteractions.PromptText(message["content"])`

<a id="symbol-0f2c54f8dd7f"></a>

## `NationalSpire.ChatTools.Features(bool) — private static Feature[] Features(bool group)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`](ChatTools.cs.md#symbol-da501aed0ab9)

**调用：** [`NationalSpire.ChatTools.ActivityProtocol(bool)`](ChatTools.cs.md#symbol-af007775b7fa)；`NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatAttachments.GiftProtocol`；`NationalSpire.ChatAttachments.GroupGiftProtocol`；`NationalSpire.ChatTools.ActivityProtocol(bool)`；`NationalSpire.ChatTools.TeachingGuidance`；`NationalSpire.ClubCoaching.GroupProtocol`；`NationalSpire.ClubCoaching.Protocol`；`NationalSpire.CoachLineups.Protocol`；`NationalSpire.OathAttachments.GroupProtocol`；`NationalSpire.OathAttachments.Protocol`；`NationalSpire.PrivateMessagePrompts.ContractProtocol`；`NationalSpire.PrivateMessagePrompts.MatchProtocol`；`NationalSpire.PrivateMessagePrompts.MoodProtocol`；`NationalSpire.PrivateMessagePrompts.PostProtocol`；`NationalSpire.PrivateMessagePrompts.ProfileProtocol`；`NationalSpire.PrivateMessagePrompts.Protocol`；`NationalSpire.PrivateMessagePrompts.SkillProtocol`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTools.ActivityProtocol(bool)`；输入表达式：`ActivityProtocol(group)`；返回值紧邻使用处：`ArgumentSyntax: ActivityProtocol(group)`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("activity", "Activity", ActivityProtocol(group), ["Activity", "Id", "Title", "Date", "Detail"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("activity", "Activity", ActivityProtocol(group), ["Activity", "Id", "Title", "Date", "Detail"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("contract", "Contract", PrivateMessagePrompts.ContractProtocol, ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("contract", "Contract", PrivateMessagePrompts.ContractProtocol, ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("gift", "Gift", group ? ChatAttachments.GroupGiftProtocol : ChatAttachments.GiftProtocol, ["Gift", "Id"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("gift", "Gift", group ? ChatAttachments.GroupGiftProtocol : ChatAttachments.GiftProtocol, ["Gift", "Id"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("lineup", "Lineup", CoachLineups.Protocol, ["Lineup", "Id"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("lineup", "Lineup", CoachLineups.Protocol, ["Lineup", "Id"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("match", "Match", PrivateMessagePrompts.MatchProtocol, ["Match", "Date", "Ascension", "Mode"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("match", "Match", PrivateMessagePrompts.MatchProtocol, ["Match", "Date", "Ascension", "Mode"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("mood", "Mood", PrivateMessagePrompts.MoodProtocol, ["Mood", "Days", "Reason"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("mood", "Mood", PrivateMessagePrompts.MoodProtocol, ["Mood", "Days", "Reason"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("oath", "Oath", group ? OathAttachments.GroupProtocol : OathAttachments.Protocol, ["Oath", "Id"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("oath", "Oath", group ? OathAttachments.GroupProtocol : OathAttachments.Protocol, ["Oath", "Id"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("post", "Post", PrivateMessagePrompts.PostProtocol, ["Post", "Title", "Body"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("post", "Post", PrivateMessagePrompts.PostProtocol, ["Post", "Title", "Body"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("profile", "Profile", PrivateMessagePrompts.ProfileProtocol, ["Profile", "Value", "Reason"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("profile", "Profile", PrivateMessagePrompts.ProfileProtocol, ["Profile", "Value", "Reason"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("relationship", "", PrivateMessagePrompts.Protocol, ["Favour", "Attitude", "Relationship"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("relationship", "", PrivateMessagePrompts.Protocol, ["Favour", "Attitude", "Relationship"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("skill", "Skill", PrivateMessagePrompts.SkillProtocol.Replace("正向变化须能由", TeachingGuidance + "\n正向变化须能由"), ["Skill", "Topic", "Reason"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("skill", "Skill", PrivateMessagePrompts.SkillProtocol.Replace("正向变化须能由", TeachingGuidance + "\n正向变化须能由"), ["Skill", "Topic", "Reason"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("training", "Training", group ? ClubCoaching.GroupProtocol : ClubCoaching.Protocol, ["Training", "Id"])`；返回值紧邻使用处：`ExpressionElementSyntax: new("training", "Training", group ? ClubCoaching.GroupProtocol : ClubCoaching.Protocol, ["Training", "Id"])`
- `string.Replace(string, string?)`；输入表达式：`PrivateMessagePrompts.SkillProtocol.Replace("正向变化须能由", TeachingGuidance + "\n正向变化须能由")`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessagePrompts.SkillProtocol.Replace("正向变化须能由", TeachingGuidance + "\n正向变化须能由")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-af007775b7fa"></a>

## `NationalSpire.ChatTools.ActivityProtocol(bool) — private static string ActivityProtocol(bool group)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTools.Features(bool)`](ChatTools.cs.md#symbol-0f2c54f8dd7f)

**调用：** `string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.SocialAppointments.GroupProtocol`；`NationalSpire.SocialAppointments.Protocol`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(string, string?)`；输入表达式：`(group ? SocialAppointments.GroupProtocol : SocialAppointments.Protocol)          .Replace("玩家主动提出或暗示活动意愿时，可以商谈活动。", "")          .Replace("Activity 填邀请、接受、改期或取消；Id 填对应活动编号，新提议填0；Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。",              "Activity 填邀请、接受、改期或取消；Id 填对应活动编号。玩家只用聊天文字提出新活动时，人物同意参加后填写 Activity 为邀请、Id 为0；本轮附有活动卡片时，接受该安排填写 Activity 为接受、Id 为附件编号。Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。")          .Replace("接受玩家提出的活动：", "接受玩家活动附件中的安排：")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => (group ? SocialAppointments.GroupProtocol : SocialAppointments.Protocol)          .Replace("玩家主动提出或暗示活动意愿时，可以商谈活动。", "")          .Replace("Activity 填邀请、接受、改期或取消；Id 填对应活动编号，新提议填0；Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。",              "Activity 填邀请、接受、改期或取消；Id 填对应活动编号。玩家只用聊天文字提出新活动时，人物同意参加后填写 Activity 为邀请、Id 为0；本轮附有活动卡片时，接受该安排填写 Activity 为接受、Id 为附件编号。Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。")          .Replace("接受玩家提出的活动：", "接受玩家活动附件中的安排：")`
- `string.Replace(string, string?)`；输入表达式：`(group ? SocialAppointments.GroupProtocol : SocialAppointments.Protocol)          .Replace("玩家主动提出或暗示活动意愿时，可以商谈活动。", "")          .Replace("Activity 填邀请、接受、改期或取消；Id 填对应活动编号，新提议填0；Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。",              "Activity 填邀请、接受、改期或取消；Id 填对应活动编号。玩家只用聊天文字提出新活动时，人物同意参加后填写 Activity 为邀请、Id 为0；本轮附有活动卡片时，接受该安排填写 Activity 为接受、Id 为附件编号。Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (group ? SocialAppointments.GroupProtocol : SocialAppointments.Protocol)          .Replace("玩家主动提出或暗示活动意愿时，可以商谈活动。", "")          .Replace("Activity 填邀请、接受、改期或取消；Id 填对应活动编号，新提议填0；Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。",              "Activity 填邀请、接受、改期或取消；Id 填对应活动编号。玩家只用聊天文字提出新活动时，人物同意参加后填写 Activity 为邀请、Id 为0；本轮附有活动卡片时，接受该安排填写 Activity 为接受、Id 为附件编号。Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。")          .Replace`
- `string.Replace(string, string?)`；输入表达式：`(group ? SocialAppointments.GroupProtocol : SocialAppointments.Protocol)          .Replace("玩家主动提出或暗示活动意愿时，可以商谈活动。", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (group ? SocialAppointments.GroupProtocol : SocialAppointments.Protocol)          .Replace("玩家主动提出或暗示活动意愿时，可以商谈活动。", "")          .Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f5d3458d67bf"></a>

## `NationalSpire.ChatTools.Describe(string) — public static string Describe(string protocol)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatAttachments.ResponseInstructions(NationalSpire.CareerData, NationalSpire.PrivateOffer, string, NationalSpire.GroupChat?, string)`](ChatAttachments.cs.md#symbol-f98de794e2ca)；[`NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`](ChatTools.cs.md#symbol-da501aed0ab9)

**调用：** [`NationalSpire.PrivateStreamParser.Feed(string)`](PrivateMessages.cs.md#symbol-f34e8e2406af)；[`NationalSpire.PrivateStreamParser.Finish()`](PrivateMessages.cs.md#symbol-90306db26d5a)；[`NationalSpire.PrivateStreamParser.PrivateStreamParser(params string[])`](PrivateMessages.cs.md#symbol-af0a0ba2ac6c)；`int.TryParse(string?, out int)`；`string.Replace(string, string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；`System.Text.RegularExpressions.Regex.Replace(string, string, System.Text.RegularExpressions.MatchEvaluator)`

**字段、属性、事件及方法组引用：** `(int Offset, System.Collections.Generic.Dictionary<string, string> Fields).Fields`；`NationalSpire.PrivateStreamParser.Directives`；`NationalSpire.PrivateStreamParser.Feed(string)`；`NationalSpire.PrivateStreamParser.Finish()`；`NationalSpire.PrivateStreamParser.SceneCues`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(p.Value, out int n)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Key is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" && int.TryParse(p.Value, out int n)`
- `NationalSpire.PrivateStreamParser.Feed(string)`；输入表达式：`sample.Feed(m.Value)`；返回值紧邻使用处：`ExpressionStatementSyntax: sample.Feed(m.Value);`
- `NationalSpire.PrivateStreamParser.Finish()`；输入表达式：`sample.Finish()`；返回值紧邻使用处：`ExpressionStatementSyntax: sample.Finish();`
- `NationalSpire.PrivateStreamParser.PrivateStreamParser(params string[])`；输入表达式：`new PrivateStreamParser("Actor", "Target", "Participants", "Related", "Coach")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateStreamParser("Actor", "Target", "Participants", "Related", "Coach")`
- `string.Replace(string, string?)`；输入表达式：`result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")              .Replace("隐藏日记标记", "日记工具参数").Replace("标记", "工具参数").Replace("交互格式", "工具参数").Replace("方括号内的内容使用全角括号代替半角方括号。", "")`；返回值紧邻使用处：`ReturnStatementSyntax: return result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")              .Replace("隐藏日记标记", "日记工具参数").Replace("标记", "工具参数").Replace("交互格式", "工具参数").Replace("方括号内的内容使用全角括号代替半角方括号。", "");`
- `string.Replace(string, string?)`；输入表达式：`result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")              .Replace("隐藏日记标记", "日记工具参数").Replace("标记", "工具参数").Replace("交互格式", "工具参数")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")              .Replace("隐藏日记标记", "日记工具参数").Replace("标记", "工具参数").Replace("交互格式", "工具参数").Replace`
- `string.Replace(string, string?)`；输入表达式：`result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")              .Replace("隐藏日记标记", "日记工具参数").Replace("标记", "工具参数")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")              .Replace("隐藏日记标记", "日记工具参数").Replace("标记", "工具参数").Replace`
- `string.Replace(string, string?)`；输入表达式：`result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")              .Replace("隐藏日记标记", "日记工具参数")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")              .Replace("隐藏日记标记", "日记工具参数").Replace`
- `string.Replace(string, string?)`；输入表达式：`result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")              .Replace`
- `string.Replace(string, string?)`；输入表达式：`result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")              .Replace`
- `string.Replace(string, string?)`；输入表达式：`result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")              .Replace`
- `string.Replace(string, string?)`；输入表达式：`result.Replace("在正文后附加", "调用对应工具")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Replace("在正文后附加", "调用对应工具").Replace`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Activity")`；返回值紧邻使用处：`IfStatementSyntax: if (fields.ContainsKey("Activity")) fields["Type"] = "activity";`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Training")`；返回值紧邻使用处：`IfStatementSyntax: if (fields.ContainsKey("Training")) fields["Type"] = "training";`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`sample.Directives.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: sample.Directives.FirstOrDefault() ?? sample.SceneCues.FirstOrDefault().Fields`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`sample.SceneCues.FirstOrDefault()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sample.SceneCues.FirstOrDefault().Fields`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`fields.ToDictionary(p => p.Key, p =>                  p.Key is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" && int.TryParse(p.Value, out int n) ? (object)n : p.Value)`；返回值紧邻使用处：`ArgumentSyntax: fields.ToDictionary(p => p.Key, p =>                  p.Key is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" && int.TryParse(p.Value, out int n) ? (object)n : p.Value)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(fields.ToDictionary(p => p.Key, p =>                  p.Key is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" && int.TryParse(p.Value, out int n) ? (object)n : p.Value),                  new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`；返回值紧邻使用处：`ReturnStatementSyntax: return JsonSerializer.Serialize(fields.ToDictionary(p => p.Key, p =>                  p.Key is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" && int.TryParse(p.Value, out int n) ? (object)n : p.Value),                  new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });`
- `System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；输入表达式：`new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`；返回值紧邻使用处：`ArgumentSyntax: new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`
- `System.Text.RegularExpressions.Regex.Replace(string, string, System.Text.RegularExpressions.MatchEvaluator)`；输入表达式：`Regex.Replace(protocol, @"\[(?:Favour|Attitude|Relationship|Match|Contract|Skill|Mood|Post|Profile|Activity|Gift|Oath|Training|Lineup|Scene|DateDiary):[^\r\n\]]+\]", m =>          {              var sample = new PrivateStreamParser("Actor", "Target", "Participants", "Related", "Coach"); sample.Feed(m.Value); sample.Finish();              var fields = sample.Directives.FirstOrDefault() ?? sample.SceneCues.FirstOrDefault().Fields;              if (fields == null) return m.Value;              if (fields.ContainsKey("Training")) fields["Type"] = "training";              if (fields.ContainsKey("Activity")) fields["Type"] = "activity";              return JsonSerializer.Serialize(fields.ToDictionary(p => p.Key, p =>                  p.Key is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" && int.TryParse(p.Value, out int n) ? (object)n : p.Value),                  new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });          })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Regex.Replace(protocol, @"\[(?:Favour|Attitude|Relationship|Match|Contract|Skill|Mood|Post|Profile|Activity|Gift|Oath|Training|Lineup|Scene|DateDiary):[^\r\n\]]+\]", m =>          {              var sample = new PrivateStreamParser("Actor", "Target", "Participants", "Related", "Coach"); sample.Feed(m.Value); sample.Finish();              var fields = sample.Directives.FirstOrDefault() ?? sample.SceneCues.FirstOrDefault().Fields;              if (fields == null) return m.Value;              if (fields.ContainsKey("Training")) fields["Type"] = "training";              if (fields.ContainsKey("Activity")) fields["Type"] = "activity";              return JsonSerializer.Serialize(fields.ToDictionary(p => p.Key, p =>                  p.Key is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" && int.TryParse(p.Value, out int n) ? (object)n : p.Value),                  new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });          })`

**赋值（含属性/字段和局部值）：**

- `Encoder` = `System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping`
- `fields["Type"]` = `"activity"`
- `fields["Type"]` = `"training"`

<a id="symbol-da501aed0ab9"></a>

## `NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?) — public static ChatToolRequest Create(CareerData data, PrivateConversation? conversation = null, PrivateTurn? turn = null, GroupChat? group = null)`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.CareerScreen.PreviewGroupPrompt()`](GroupChatDialogs.cs.md#symbol-b6bc7a2d0206)；[`NationalSpire.CareerScreen.PreviewPrivatePrompt()`](PrivateMessageScreen.cs.md#symbol-aefc38a1fba3)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.ChatToolRequest.ChatToolRequest(System.Collections.Generic.IEnumerable<NationalSpire.ChatTools.Feature>, object[], bool)`](ChatTools.cs.md#symbol-6a6f6970a865)；[`NationalSpire.ChatTools.Describe(string)`](ChatTools.cs.md#symbol-f5d3458d67bf)；[`NationalSpire.ChatTools.Features(bool)`](ChatTools.cs.md#symbol-0f2c54f8dd7f)；[`NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-42aa2fbcaa1f)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-11345d1ef285)；`NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Replace(string, string?)`；`string.Split(char, System.StringSplitOptions)`；`System.Array.Empty<T>()`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Except<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, int, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Linq.Enumerable.Range(int, int)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`

**字段、属性、事件及方法组引用：** `<anonymous type: object[] anyOf>.anyOf`；`<anonymous type: string description, object[] anyOf>.anyOf`；`<anonymous type: string description, object[] anyOf>.description`；`<anonymous type: string name, bool strict, string description, <anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties> parameters>.description`；`<anonymous type: string name, bool strict, string description, <anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties> parameters>.name`；`<anonymous type: string name, bool strict, string description, <anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties> parameters>.parameters`；`<anonymous type: string name, bool strict, string description, <anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties> parameters>.strict`；`<anonymous type: string Reasoning, System.Collections.Generic.Dictionary<string, object>[] Replies, System.Collections.Generic.Dictionary<string, object>[] Interactions>.Interactions`；`<anonymous type: string Reasoning, System.Collections.Generic.Dictionary<string, object>[] Replies, System.Collections.Generic.Dictionary<string, object>[] Interactions>.Reasoning`；`<anonymous type: string Reasoning, System.Collections.Generic.Dictionary<string, object>[] Replies, System.Collections.Generic.Dictionary<string, object>[] Interactions>.Replies`；`<anonymous type: string type, <anonymous type: string name, bool strict, string description, <anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties> parameters> function>.function`；`<anonymous type: string type, <anonymous type: string name, bool strict, string description, <anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties> parameters> function>.type`；`<anonymous type: string type, string description, <anonymous type: object[] anyOf> items>.description`；`<anonymous type: string type, string description, <anonymous type: object[] anyOf> items>.items`；`<anonymous type: string type, string description, <anonymous type: object[] anyOf> items>.type`；`<anonymous type: string type, string description, <anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties> items>.description`；`<anonymous type: string type, string description, <anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties> items>.items`；`<anonymous type: string type, string description, <anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties> items>.type`；`<anonymous type: string type, string description>.description`；`<anonymous type: string type, string description>.type`；`<anonymous type: string type, string[] enum>.@enum`；`<anonymous type: string type, string[] enum>.type`；`<anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties>.additionalProperties`；`<anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties>.properties`；`<anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties>.required`；`<anonymous type: string type, System.Collections.Generic.Dictionary<string, object> properties, string[] required, bool additionalProperties>.type`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.ChatTools.ActivityIntentGuidance`；`NationalSpire.ChatTools.Describe(string)`；`NationalSpire.ChatTools.Feature.Description`；`NationalSpire.ChatTools.Feature.Fields`；`NationalSpire.ChatTools.Feature.Key`；`NationalSpire.ChatTools.Feature.Name`；`NationalSpire.ChatTools.Features(bool)`；`NationalSpire.ChatTools.Guidance`；`NationalSpire.ChatTools.OrdinaryGuidance`；`NationalSpire.DateDiaries.ToolEnding`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.GroupChatPrompts.ActorFormat`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, conversation.PersonId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, conversation.PersonId) is { } person`
- `NationalSpire.ChatToolRequest.ChatToolRequest(System.Collections.Generic.IEnumerable<NationalSpire.ChatTools.Feature>, object[], bool)`；输入表达式：`new(features, tools, group != null)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(features, tools, group != null);`
- `NationalSpire.ChatTools.Describe(string)`；输入表达式：`Describe(DateScenes.Guidance(active, tools: true))`；返回值紧邻使用处：`ConditionalExpressionSyntax: turn?.Scene is { Ending: false } active              ? Describe(DateScenes.Guidance(active, tools: true)) : "按发言顺序填写完整正文。"`
- `NationalSpire.ChatTools.Describe(string)`；输入表达式：`Describe(f.Description)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Describe(f.Description)`
- `NationalSpire.ChatTools.Describe(string)`；输入表达式：`Describe(string.Join("\n", GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6)))`；返回值紧邻使用处：`BinaryExpressionSyntax: description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")                      .Replace("玩家提供了具体、适用条件明确的做法", "交流中提供了具体、适用条件明确的做法")                      + "\n" + Describe(string.Join("\n", GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6)))`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("date_diary", "DateDiary", DateDiaries.ToolEnding, ["DateDiary", "Location"])`；返回值紧邻使用处：`ArgumentSyntax: new("date_diary", "DateDiary", DateDiaries.ToolEnding, ["DateDiary", "Location"])`
- `NationalSpire.ChatTools.Feature.Feature(string, string, string, string[])`；输入表达式：`new("scene", "Scene", DateScenes.Guidance(scene, tools: true), ["Scene", "Emotion", "Background"])`；返回值紧邻使用处：`ArgumentSyntax: new("scene", "Scene", DateScenes.Guidance(scene, tools: true), ["Scene", "Emotion", "Background"])`
- `NationalSpire.ChatTools.Features(bool)`；输入表达式：`Features(group != null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Features(group != null).ToList`
- `NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool)`；输入表达式：`DateScenes.Guidance(active, tools: true)`；返回值紧邻使用处：`ArgumentSyntax: DateScenes.Guidance(active, tools: true)`
- `NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool)`；输入表达式：`DateScenes.Guidance(scene, tools: true)`；返回值紧邻使用处：`ArgumentSyntax: DateScenes.Guidance(scene, tools: true)`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.CanOperate(data) && person.ClubId != data.Esports.ClubId`
- `NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`；输入表达式：`OwnedClubs.IsRecruitable(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.CanOperate(data) && person.ClubId != data.Esports.ClubId && OwnedClubs.IsRecruitable(person)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6))`；返回值紧邻使用处：`ArgumentSyntax: string.Join("\n", GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6))`
- `string.Replace(string, string?)`；输入表达式：`description.Replace("对应工具", "对应交互项").Replace("本工具", "本交互项")`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: description = description.Replace("对应工具", "对应交互项").Replace("本工具", "本交互项")`
- `string.Replace(string, string?)`；输入表达式：`description.Replace("对应工具", "对应交互项")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: description.Replace("对应工具", "对应交互项").Replace`
- `string.Replace(string, string?)`；输入表达式：`description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")                      .Replace("玩家提供了具体、适用条件明确的做法", "交流中提供了具体、适用条件明确的做法")`；返回值紧邻使用处：`BinaryExpressionSyntax: description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")                      .Replace("玩家提供了具体、适用条件明确的做法", "交流中提供了具体、适用条件明确的做法")                      + "\n"`
- `string.Replace(string, string?)`；输入表达式：`description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")                      .Replace`
- `string.Replace(string, string?)`；输入表达式：`description.Replace("普通聊天无需附带任何工具参数。", "本轮没有上述学习变化时省略 skill 交互，其他交互按各自说明判断。")`；返回值紧邻使用处：`AssignmentExpressionSyntax: description = description.Replace("普通聊天无需附带任何工具参数。", "本轮没有上述学习变化时省略 skill 交互，其他交互按各自说明判断。")`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`GroupChatPrompts.ActorFormat.Split('\n')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChatPrompts.ActorFormat.Split('\n').Where`
- `System.Array.Empty<T>()`；输入表达式：`Array.Empty<string>()`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => Array.Empty<string>()`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(optional, p.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 << Array.IndexOf(optional, p.Key)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, object>              {                  ["Reasoning"] = new { type = "string", description = (group != null ? "区分生活活动与比赛约战：生活活动已有日期且成员明确同意参加时，按已谈妥的活动内容和完整参与者登记同一项活动邀请；比赛约战再填写比赛进阶与方式。" : "") + "先核对人物、日期、待处理卡片的实际类型和编号、当前活动是否已经确认或赴约，再根据已有事实和交流资料整理人物反应、回复安排及实际交互决定。新约定采用邀请；正在履行的活动继续当前场景。" },                  ["Replies"] = new { type = "array", description = replyDescription, items = new { type = "object", properties = replyProperties, required = replyProperties.Keys.ToArray(), additionalProperties = false } },                  ["Interactions"] = new { type = "array", description = ending ? DateDiaries.ToolEnding : "必须填写本轮的全部实际交互，无交互填 []。每项的 Type 选择其类型，其余字段按该项说明填写。", items = new { anyOf = interactions } }              }`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: properties = new Dictionary<string, object>              {                  ["Reasoning"] = new { type = "string", description = (group != null ? "区分生活活动与比赛约战：生活活动已有日期且成员明确同意参加时，按已谈妥的活动内容和完整参与者登记同一项活动邀请；比赛约战再填写比赛进阶与方式。" : "") + "先核对人物、日期、待处理卡片的实际类型和编号、当前活动是否已经确认或赴约，再根据已有事实和交流资料整理人物反应、回复安排及实际交互决定。新约定采用邀请；正在履行的活动继续当前场景。" },                  ["Replies"] = new { type = "array", description = replyDescription, items = new { type = "object", properties = replyProperties, required = replyProperties.Keys.ToArray(), additionalProperties = false } },                  ["Interactions"] = new { type = "array", description = ending ? DateDiaries.ToolEnding : "必须填写本轮的全部实际交互，无交互填 []。每项的 Type 选择其类型，其余字段按该项说明填写。", items = new { anyOf = interactions } }              }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, object>              {                  ["type"] = k is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" ? "integer" : "string",                  ["description"] = k switch                  {                      "Actor" => f.Name == "activity" ? "已经谈妥的完整活动参与者编号，包括参加活动的玩家，多人以竖线分隔。"                          : f.Name == "training" ? "本次接受或拒绝训练的全部受训者编号，多人以竖线分隔。" : "作出决定或变化的人物编号。",                      "Target" => "关系或约战的对方人物编号。",                      "Related" => "发帖希望回应的人物编号，以竖线分隔。",                      "Coach" => "训练教练的人物编号。",                      "Id" => "邀请新活动填0；接受、拒绝或改期时填写本轮对应类型的待处理卡片实际编号。",                      _ => "含义和适用条件见本工具说明中的 " + k + "。"                  }              }`；返回值紧邻使用处：`CastExpressionSyntax: (object)new Dictionary<string, object>              {                  ["type"] = k is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" ? "integer" : "string",                  ["description"] = k switch                  {                      "Actor" => f.Name == "activity" ? "已经谈妥的完整活动参与者编号，包括参加活动的玩家，多人以竖线分隔。"                          : f.Name == "training" ? "本次接受或拒绝训练的全部受训者编号，多人以竖线分隔。" : "作出决定或变化的人物编号。",                      "Target" => "关系或约战的对方人物编号。",                      "Related" => "发帖希望回应的人物编号，以竖线分隔。",                      "Coach" => "训练教练的人物编号。",                      "Id" => "邀请新活动填0；接受、拒绝或改期时填写本轮对应类型的待处理卡片实际编号。",                      _ => "含义和适用条件见本工具说明中的 " + k + "。"                  }              }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, object> { ["Type"] = "match", ["Match"] = "邀请", ["Date"] = "2026-01-18", ["Ascension"] = 6, ["Mode"] = "切磋" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, object> { ["Type"] = "match", ["Match"] = "邀请", ["Date"] = "2026-01-18", ["Ascension"] = 6, ["Mode"] = "切磋" }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, object>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, object>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["Type"] = "activity", ["Activity"] = "邀请", ["Id"] = "0", ["Title"] = "一起看录像", ["Date"] = "2026-01-18", ["Detail"] = "讨论今天的比赛", ["Actor"] = "p1|p2|p3" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: exampleAction = new() { ["Type"] = "activity", ["Activity"] = "邀请", ["Id"] = "0", ["Title"] = "一起看录像", ["Date"] = "2026-01-18", ["Detail"] = "讨论今天的比赛", ["Actor"] = "p1|p2|p3" }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["Type"] = "date_diary", ["DateDiary"] = "今天和他按约定见面，聊起各自最近的生活。原本只想简单说几句，后来却越聊越放松。离开时，我还惦记着刚才没说完的话。", ["Location"] = "地点未明确" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: exampleAction = new() { ["Type"] = "date_diary", ["DateDiary"] = "今天和他按约定见面，聊起各自最近的生活。原本只想简单说几句，后来却越聊越放松。离开时，我还惦记着刚才没说完的话。", ["Location"] = "地点未明确" }`
- `System.Collections.Generic.IEnumerable<TSource>.Except<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`properties.Keys.Except(required)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: properties.Keys.Except(required).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Enumerable.Range(0, 1 << optional.Length).Select(mask =>              {                  var selected = properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value);                  return (object)new { type = "object", properties = selected, required = selected.Keys.ToArray(), additionalProperties = false };              })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, 1 << optional.Length).Select(mask =>              {                  var selected = properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value);                  return (object)new { type = "object", properties = selected, required = selected.Keys.ToArray(), additionalProperties = false };              }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`features.Where(f => f.Name != "scene").Select(f =>          {              var fields = f.Fields.ToList();              if (group != null) fields.Add("Actor");              if (group != null) fields.AddRange(f.Name switch              {                  "relationship" or "match" => ["Target"],                  "post" => ["Related"], _ => Array.Empty<string>()              });              var properties = fields.ToDictionary(k => k, k => (object)new Dictionary<string, object>              {                  ["type"] = k is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" ? "integer" : "string",                  ["description"] = k switch                  {                      "Actor" => f.Name == "activity" ? "已经谈妥的完整活动参与者编号，包括参加活动的玩家，多人以竖线分隔。"                          : f.Name == "training" ? "本次接受或拒绝训练的全部受训者编号，多人以竖线分隔。" : "作出决定或变化的人物编号。",                      "Target" => "关系或约战的对方人物编号。",                      "Related" => "发帖希望回应的人物编号，以竖线分隔。",                      "Coach" => "训练教练的人物编号。",                      "Id" => "邀请新活动填0；接受、拒绝或改期时填写本轮对应类型的待处理卡片实际编号。",                      _ => "含义和适用条件见本工具说明中的 " + k + "。"                  }              });              properties["Type"] = new { type = "string", @enum = new[] { f.Name } };              var required = new List<string> { "Type" };              if (f.Key.Length > 0) required.AddRange(f.Fields);              if (group != null) required.Add("Actor");              if (group != null && f.Name is "relationship" or "match") required.Add("Target");              // 活动意愿统一放在工具总说明，字段说明只保留动作与参数规则。              string description = Describe(f.Description);              if (f.Name == "skill") description = description.Replace("普通聊天无需附带任何工具参数。", "本轮没有上述学习变化时省略 skill 交互，其他交互按各自说明判断。");              if (group != null)                  description = description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")                      .Replace("玩家提供了具体、适用条件明确的做法", "交流中提供了具体、适用条件明确的做法")                      + "\n" + Describe(string.Join("\n", GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6)));                // 严格格式要求对象内的字段全部必填，用字段组合保留原协议的可省略参数。              string[] optional = properties.Keys.Except(required).ToArray();              object[] variants = Enumerable.Range(0, 1 << optional.Length).Select(mask =>              {                  var selected = properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value);                  return (object)new { type = "object", properties = selected, required = selected.Keys.ToArray(), additionalProperties = false };              }).ToArray();              return (object)new { description = description.Replace("对应工具", "对应交互项").Replace("本工具", "本交互项"), anyOf = variants };          })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: features.Where(f => f.Name != "scene").Select(f =>          {              var fields = f.Fields.ToList();              if (group != null) fields.Add("Actor");              if (group != null) fields.AddRange(f.Name switch              {                  "relationship" or "match" => ["Target"],                  "post" => ["Related"], _ => Array.Empty<string>()              });              var properties = fields.ToDictionary(k => k, k => (object)new Dictionary<string, object>              {                  ["type"] = k is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" ? "integer" : "string",                  ["description"] = k switch                  {                      "Actor" => f.Name == "activity" ? "已经谈妥的完整活动参与者编号，包括参加活动的玩家，多人以竖线分隔。"                          : f.Name == "training" ? "本次接受或拒绝训练的全部受训者编号，多人以竖线分隔。" : "作出决定或变化的人物编号。",                      "Target" => "关系或约战的对方人物编号。",                      "Related" => "发帖希望回应的人物编号，以竖线分隔。",                      "Coach" => "训练教练的人物编号。",                      "Id" => "邀请新活动填0；接受、拒绝或改期时填写本轮对应类型的待处理卡片实际编号。",                      _ => "含义和适用条件见本工具说明中的 " + k + "。"                  }              });              properties["Type"] = new { type = "string", @enum = new[] { f.Name } };              var required = new List<string> { "Type" };              if (f.Key.Length > 0) required.AddRange(f.Fields);              if (group != null) required.Add("Actor");              if (group != null && f.Name is "relationship" or "match") required.Add("Target");              // 活动意愿统一放在工具总说明，字段说明只保留动作与参数规则。              string description = Describe(f.Description);              if (f.Name == "skill") description = description.Replace("普通聊天无需附带任何工具参数。", "本轮没有上述学习变化时省略 skill 交互，其他交互按各自说明判断。");              if (group != null)                  description = description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")                      .Replace("玩家提供了具体、适用条件明确的做法", "交流中提供了具体、适用条件明确的做法")                      + "\n" + Describe(string.Join("\n", GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6)));                // 严格格式要求对象内的字段全部必填，用字段组合保留原协议的可省略参数。              string[] optional = properties.Keys.Except(required).ToArray();              object[] variants = Enumerable.Range(0, 1 << optional.Length).Select(mask =>              {                  var selected = properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value);                  return (object)new { type = "object", properties = selected, required = selected.Keys.ToArray(), additionalProperties = false };              }).ToArray();              return (object)new { description = description.Replace("对应工具", "对应交互项").Replace("本工具", "本交互项"), anyOf = variants };          }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0, 1 << optional.Length).Select(mask =>              {                  var selected = properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value);                  return (object)new { type = "object", properties = selected, required = selected.Keys.ToArray(), additionalProperties = false };              }).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Enumerable.Range(0, 1 << optional.Length).Select(mask =>              {                  var selected = properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value);                  return (object)new { type = "object", properties = selected, required = selected.Keys.ToArray(), additionalProperties = false };              }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`features.Where(f => f.Name != "scene").Select(f =>          {              var fields = f.Fields.ToList();              if (group != null) fields.Add("Actor");              if (group != null) fields.AddRange(f.Name switch              {                  "relationship" or "match" => ["Target"],                  "post" => ["Related"], _ => Array.Empty<string>()              });              var properties = fields.ToDictionary(k => k, k => (object)new Dictionary<string, object>              {                  ["type"] = k is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" ? "integer" : "string",                  ["description"] = k switch                  {                      "Actor" => f.Name == "activity" ? "已经谈妥的完整活动参与者编号，包括参加活动的玩家，多人以竖线分隔。"                          : f.Name == "training" ? "本次接受或拒绝训练的全部受训者编号，多人以竖线分隔。" : "作出决定或变化的人物编号。",                      "Target" => "关系或约战的对方人物编号。",                      "Related" => "发帖希望回应的人物编号，以竖线分隔。",                      "Coach" => "训练教练的人物编号。",                      "Id" => "邀请新活动填0；接受、拒绝或改期时填写本轮对应类型的待处理卡片实际编号。",                      _ => "含义和适用条件见本工具说明中的 " + k + "。"                  }              });              properties["Type"] = new { type = "string", @enum = new[] { f.Name } };              var required = new List<string> { "Type" };              if (f.Key.Length > 0) required.AddRange(f.Fields);              if (group != null) required.Add("Actor");              if (group != null && f.Name is "relationship" or "match") required.Add("Target");              // 活动意愿统一放在工具总说明，字段说明只保留动作与参数规则。              string description = Describe(f.Description);              if (f.Name == "skill") description = description.Replace("普通聊天无需附带任何工具参数。", "本轮没有上述学习变化时省略 skill 交互，其他交互按各自说明判断。");              if (group != null)                  description = description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")                      .Replace("玩家提供了具体、适用条件明确的做法", "交流中提供了具体、适用条件明确的做法")                      + "\n" + Describe(string.Join("\n", GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6)));                // 严格格式要求对象内的字段全部必填，用字段组合保留原协议的可省略参数。              string[] optional = properties.Keys.Except(required).ToArray();              object[] variants = Enumerable.Range(0, 1 << optional.Length).Select(mask =>              {                  var selected = properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value);                  return (object)new { type = "object", properties = selected, required = selected.Keys.ToArray(), additionalProperties = false };              }).ToArray();              return (object)new { description = description.Replace("对应工具", "对应交互项").Replace("本工具", "本交互项"), anyOf = variants };          }).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = features.Where(f => f.Name != "scene").Select(f =>          {              var fields = f.Fields.ToList();              if (group != null) fields.Add("Actor");              if (group != null) fields.AddRange(f.Name switch              {                  "relationship" or "match" => ["Target"],                  "post" => ["Related"], _ => Array.Empty<string>()              });              var properties = fields.ToDictionary(k => k, k => (object)new Dictionary<string, object>              {                  ["type"] = k is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" ? "integer" : "string",                  ["description"] = k switch                  {                      "Actor" => f.Name == "activity" ? "已经谈妥的完整活动参与者编号，包括参加活动的玩家，多人以竖线分隔。"                          : f.Name == "training" ? "本次接受或拒绝训练的全部受训者编号，多人以竖线分隔。" : "作出决定或变化的人物编号。",                      "Target" => "关系或约战的对方人物编号。",                      "Related" => "发帖希望回应的人物编号，以竖线分隔。",                      "Coach" => "训练教练的人物编号。",                      "Id" => "邀请新活动填0；接受、拒绝或改期时填写本轮对应类型的待处理卡片实际编号。",                      _ => "含义和适用条件见本工具说明中的 " + k + "。"                  }              });              properties["Type"] = new { type = "string", @enum = new[] { f.Name } };              var required = new List<string> { "Type" };              if (f.Key.Length > 0) required.AddRange(f.Fields);              if (group != null) required.Add("Actor");              if (group != null && f.Name is "relationship" or "match") required.Add("Target");              // 活动意愿统一放在工具总说明，字段说明只保留动作与参数规则。              string description = Describe(f.Description);              if (f.Name == "skill") description = description.Replace("普通聊天无需附带任何工具参数。", "本轮没有上述学习变化时省略 skill 交互，其他交互按各自说明判断。");              if (group != null)                  description = description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")                      .Replace("玩家提供了具体、适用条件明确的做法", "交流中提供了具体、适用条件明确的做法")                      + "\n" + Describe(string.Join("\n", GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6)));                // 严格格式要求对象内的字段全部必填，用字段组合保留原协议的可省略参数。              string[] optional = properties.Keys.Except(required).ToArray();              object[] variants = Enumerable.Range(0, 1 << optional.Length).Select(mask =>              {                  var selected = properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value);                  return (object)new { type = "object", properties = selected, required = selected.Keys.ToArray(), additionalProperties = false };              }).ToArray();              return (object)new { description = description.Replace("对应工具", "对应交互项").Replace("本工具", "本交互项"), anyOf = variants };          }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`properties.Keys.Except(required).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = properties.Keys.Except(required).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`replyProperties.Keys.ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: required = replyProperties.Keys.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`selected.Keys.ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: required = selected.Keys.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`fields.ToDictionary(k => k, k => (object)new Dictionary<string, object>              {                  ["type"] = k is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" ? "integer" : "string",                  ["description"] = k switch                  {                      "Actor" => f.Name == "activity" ? "已经谈妥的完整活动参与者编号，包括参加活动的玩家，多人以竖线分隔。"                          : f.Name == "training" ? "本次接受或拒绝训练的全部受训者编号，多人以竖线分隔。" : "作出决定或变化的人物编号。",                      "Target" => "关系或约战的对方人物编号。",                      "Related" => "发帖希望回应的人物编号，以竖线分隔。",                      "Coach" => "训练教练的人物编号。",                      "Id" => "邀请新活动填0；接受、拒绝或改期时填写本轮对应类型的待处理卡片实际编号。",                      _ => "含义和适用条件见本工具说明中的 " + k + "。"                  }              })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fields.ToDictionary(k => k, k => (object)new Dictionary<string, object>              {                  ["type"] = k is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" ? "integer" : "string",                  ["description"] = k switch                  {                      "Actor" => f.Name == "activity" ? "已经谈妥的完整活动参与者编号，包括参加活动的玩家，多人以竖线分隔。"                          : f.Name == "training" ? "本次接受或拒绝训练的全部受训者编号，多人以竖线分隔。" : "作出决定或变化的人物编号。",                      "Target" => "关系或约战的对方人物编号。",                      "Related" => "发帖希望回应的人物编号，以竖线分隔。",                      "Coach" => "训练教练的人物编号。",                      "Id" => "邀请新活动填0；接受、拒绝或改期时填写本轮对应类型的待处理卡片实际编号。",                      _ => "含义和适用条件见本工具说明中的 " + k + "。"                  }              })`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`f.Fields.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = f.Fields.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Features(group != null).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Features(group != null).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`features.Where(f => f.Name != "scene")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: features.Where(f => f.Name != "scene").Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, int, bool>)`；输入表达式：`GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6)`；返回值紧邻使用处：`ArgumentSyntax: GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`features.Add(new("date_diary", "DateDiary", DateDiaries.ToolEnding, ["DateDiary", "Location"]))`；返回值紧邻使用处：`ExpressionStatementSyntax: features.Add(new("date_diary", "DateDiary", DateDiaries.ToolEnding, ["DateDiary", "Location"]));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`features.Add(new("scene", "Scene", DateScenes.Guidance(scene, tools: true), ["Scene", "Emotion", "Background"]))`；返回值紧邻使用处：`ExpressionStatementSyntax: features.Add(new("scene", "Scene", DateScenes.Guidance(scene, tools: true), ["Scene", "Emotion", "Background"]));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`fields.Add("Actor")`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.Add("Actor");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`required.Add("Actor")`；返回值紧邻使用处：`ExpressionStatementSyntax: required.Add("Actor");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`required.Add("Target")`；返回值紧邻使用处：`ExpressionStatementSyntax: required.Add("Target");`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`fields.AddRange(f.Name switch              {                  "relationship" or "match" => ["Target"],                  "post" => ["Related"], _ => Array.Empty<string>()              })`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddRange(f.Name switch              {                  "relationship" or "match" => ["Target"],                  "post" => ["Related"], _ => Array.Empty<string>()              });`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`required.AddRange(f.Fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: required.AddRange(f.Fields);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`required.Contains(p.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string> { "Type" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string> { "Type" }`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`features.RemoveAll(f => f.Name == "contract")`；返回值紧邻使用处：`ExpressionStatementSyntax: features.RemoveAll(f => f.Name == "contract");`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, 1 << optional.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, 1 << optional.Length).Select`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new { Reasoning = exampleReasoning, Replies = new[] { exampleReply }, Interactions = new[] { exampleAction } }, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonSerializer.Serialize(new { Reasoning = exampleReasoning, Replies = new[] { exampleReply }, Interactions = new[] { exampleAction } }, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`
- `System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；输入表达式：`new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`；返回值紧邻使用处：`ArgumentSyntax: new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`

**赋值（含属性/字段和局部值）：**

- `["Activity"]` = `"邀请"`
- `["Actor"]` = `"p1|p2|p3"`
- `["Ascension"]` = `6`
- `["Date"]` = `"2026-01-18"`
- `["DateDiary"]` = `"今天和他按约定见面，聊起各自最近的生活。原本只想简单说几句，后来却越聊越放松。离开时，我还惦记着刚才没说完的话。"`
- `["description"]` = `k switch                  {                      "Actor" => f.Name == "activity" ? "已经谈妥的完整活动参与者编号，包括参加活动的玩家，多人以竖线分隔。"                          : f.Name == "training" ? "本次接受或拒绝训练的全部受训者编号，多人以竖线分隔。" : "作出决定或变化的人物编号。",                      "Target" => "关系或约战的对方人物编号。",                      "Related" => "发帖希望回应的人物编号，以竖线分隔。",                      "Coach" => "训练教练的人物编号。",                      "Id" => "邀请新活动填0；接受、拒绝或改期时填写本轮对应类型的待处理卡片实际编号。",                      _ => "含义和适用条件见本工具说明中的 " + k + "。"                  }`
- `["Detail"]` = `"讨论今天的比赛"`
- `["Id"]` = `"0"`
- `["Interactions"]` = `new { type = "array", description = ending ? DateDiaries.ToolEnding : "必须填写本轮的全部实际交互，无交互填 []。每项的 Type 选择其类型，其余字段按该项说明填写。", items = new { anyOf = interactions } }`
- `["Location"]` = `"地点未明确"`
- `["Match"]` = `"邀请"`
- `["Mode"]` = `"切磋"`
- `["Reasoning"]` = `new { type = "string", description = (group != null ? "区分生活活动与比赛约战：生活活动已有日期且成员明确同意参加时，按已谈妥的活动内容和完整参与者登记同一项活动邀请；比赛约战再填写比赛进阶与方式。" : "") + "先核对人物、日期、待处理卡片的实际类型和编号、当前活动是否已经确认或赴约，再根据已有事实和交流资料整理人物反应、回复安排及实际交互决定。新约定采用邀请；正在履行的活动继续当前场景。" }`
- `["Replies"]` = `new { type = "array", description = replyDescription, items = new { type = "object", properties = replyProperties, required = replyProperties.Keys.ToArray(), additionalProperties = false } }`
- `["Title"]` = `"一起看录像"`
- `["Type"]` = `"activity"`
- `["Type"]` = `"date_diary"`
- `["Type"]` = `"match"`
- `["type"]` = `k is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" ? "integer" : "string"`
- `description` = `description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")                      .Replace("玩家提供了具体、适用条件明确的做法", "交流中提供了具体、适用条件明确的做法")                      + "\n" + Describe(string.Join("\n", GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7                          || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4                          || f.Name == "post" && index == 6)))`
- `description` = `description.Replace("普通聊天无需附带任何工具参数。", "本轮没有上述学习变化时省略 skill 交互，其他交互按各自说明判断。")`
- `Encoder` = `System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping`
- `exampleAction` = `new() { ["Type"] = "activity", ["Activity"] = "邀请", ["Id"] = "0", ["Title"] = "一起看录像", ["Date"] = "2026-01-18", ["Detail"] = "讨论今天的比赛", ["Actor"] = "p1|p2|p3" }`
- `exampleAction` = `new() { ["Type"] = "date_diary", ["DateDiary"] = "今天和他按约定见面，聊起各自最近的生活。原本只想简单说几句，后来却越聊越放松。离开时，我还惦记着刚才没说完的话。", ["Location"] = "地点未明确" }`
- `exampleReasoning` = `"本次相处已结束，根据完整记录发送感想，并整理这场约会的日记。"`
- `exampleReply["Background"]` = `"current"`
- `exampleReply["Emotion"]` = `exampleScene.DefaultEmotionId`
- `exampleReply["Reply"]` = `"今天和你聊得很开心，回去路上还在想我们刚才说的事。"`
- `exampleReply["Reply"]` = `"明天一起看录像吧，我把今天没弄明白的地方整理好。"`
- `exampleReply["Reply"]` = `"明天再切磋一局吧，我把今天没弄明白的地方整理好。"`
- `exampleReply["Scene"]` = `"dialogue"`
- `exampleReply["Speaker"]` = `"p2"`
- `properties["Type"]` = `new { type = "string", @enum = new[] { f.Name } }`
- `replyProperties["Reply"]` = `new { type = "string", description = "本段完整正文，保持当前模板要求的文风与篇幅，包含角色语言或约会旁白。" }`
- `replyProperties["Speaker"]` = `new { type = "string", description = "本段实际发言者，填写本群可发言的NPC编号，先于 Reply 填写。" }`
- `replyProperties[key]` = `new { type = "string", description = "沿用本次约会场景资料中的 " + key + "，先于 Reply 填写。" }`

<a id="symbol-26de08375cb2"></a>

## `NationalSpire.ChatToolCall.Index — public int Index`

来源：源码第 170 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b0b47c5b5c3a"></a>

## `NationalSpire.ChatToolCall.Id — public string Id`

来源：源码第 171 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-67adb9ba4232"></a>

## `NationalSpire.ChatToolCall.Name — public string Name`

来源：源码第 172 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dd8f2a17d98e"></a>

## `NationalSpire.ChatToolCall.Arguments — public string Arguments`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatToolCall._arguments`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.StringBuilder.Append(string?)`；输入表达式：`_arguments.Append(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: _arguments.Append(value);`
- `System.Text.StringBuilder.Clear()`；输入表达式：`_arguments.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _arguments.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_arguments.ToString()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _arguments.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-506dc7ff027a"></a>

## `NationalSpire.ChatToolCall.AppendArguments(string?) — internal void AppendArguments(string? value)`

来源：源码第 175 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatToolRequest.Feed(System.Text.Json.JsonElement, System.Action<string>?, System.Action<string>?)`](ChatTools.cs.md#symbol-bfdf106e5cdf)

**调用：** `System.Text.StringBuilder.Append(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatToolCall._arguments`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.StringBuilder.Append(string?)`；输入表达式：`_arguments.Append(value)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _arguments.Append(value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b2b4bdc5fb26"></a>

## `NationalSpire.ChatToolRequest.Definitions — public object[] Definitions`

来源：源码第 183 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f0e45d8163b1"></a>

## `NationalSpire.ChatToolRequest.Group — public bool Group`

来源：源码第 184 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-032fd2ff57e7"></a>

## `NationalSpire.ChatToolRequest.Calls — public List<ChatToolCall> Calls`

来源：源码第 185 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b4a7eebf120a"></a>

## `NationalSpire.ChatToolRequest.Error — public string Error`

来源：源码第 186 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6a6f6970a865"></a>

## `NationalSpire.ChatToolRequest.ChatToolRequest(System.Collections.Generic.IEnumerable<NationalSpire.ChatTools.Feature>, object[], bool) — internal ChatToolRequest(IEnumerable<ChatTools.Feature> features, object[] definitions, bool group)`

来源：源码第 187 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`](ChatTools.cs.md#symbol-da501aed0ab9)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IEqualityComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatToolRequest._features`；`NationalSpire.ChatToolRequest.Definitions`；`NationalSpire.ChatToolRequest.Group`；`NationalSpire.ChatTools.Feature.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`features.ToDictionary(f => f.Name, StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _features = features.ToDictionary(f => f.Name, StringComparer.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**

- `_features` = `features.ToDictionary(f => f.Name, StringComparer.OrdinalIgnoreCase)`
- `Definitions` = `definitions`
- `Group` = `group`

<a id="symbol-bfdf106e5cdf"></a>

## `NationalSpire.ChatToolRequest.Feed(System.Text.Json.JsonElement, System.Action<string>?, System.Action<string>?) — public void Feed(JsonElement message, Action<string>? progress = null, Action<string>? reasoning = null)`

来源：源码第 189 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Event()`](AiPrivateMessages.cs.md#symbol-29b10fe25b87)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string, NationalSpire.ChatToolRequest?)`](AiPrivateMessages.cs.md#symbol-bab48bdb57c8)

**调用：** [`NationalSpire.ChatReplyStream.Feed(string, System.Action<string>?, System.Action<string>?)`](ChatTools.cs.md#symbol-3c38f9bbe535)；[`NationalSpire.ChatToolCall.AppendArguments(string?)`](ChatTools.cs.md#symbol-506dc7ff027a)；`NationalSpire.ChatReplyStream.ChatReplyStream(bool)`；`NationalSpire.ChatToolCall.ChatToolCall()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.GetInt32()`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatReplyStream.Feed(string, System.Action<string>?, System.Action<string>?)`；`NationalSpire.ChatToolCall.AppendArguments(string?)`；`NationalSpire.ChatToolCall.Arguments`；`NationalSpire.ChatToolCall.Id`；`NationalSpire.ChatToolCall.Index`；`NationalSpire.ChatToolCall.Name`；`NationalSpire.ChatToolRequest._streams`；`NationalSpire.ChatToolRequest.Calls`；`NationalSpire.ChatToolRequest.Group`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatReplyStream.ChatReplyStream(bool)`；输入表达式：`new(Group)`；返回值紧邻使用处：`AssignmentExpressionSyntax: reader = new(Group)`
- `NationalSpire.ChatReplyStream.Feed(string, System.Action<string>?, System.Action<string>?)`；输入表达式：`reader.Feed(args.GetString() ?? "", progress, reasoning)`；返回值紧邻使用处：`ExpressionStatementSyntax: reader.Feed(args.GetString() ?? "", progress, reasoning);`
- `NationalSpire.ChatReplyStream.Feed(string, System.Action<string>?, System.Action<string>?)`；输入表达式：`reader.Feed(call.Arguments, progress, reasoning)`；返回值紧邻使用处：`ExpressionStatementSyntax: reader.Feed(call.Arguments, progress, reasoning);`
- `NationalSpire.ChatToolCall.AppendArguments(string?)`；输入表达式：`call.AppendArguments(args.GetString())`；返回值紧邻使用处：`ExpressionStatementSyntax: call.AppendArguments(args.GetString());`
- `NationalSpire.ChatToolCall.ChatToolCall()`；输入表达式：`new() { Index = index }`；返回值紧邻使用处：`AssignmentExpressionSyntax: call = new() { Index = index }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_streams.TryGetValue(index, out var reader)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_streams.TryGetValue(index, out var reader)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Calls.FirstOrDefault(c => c.Index == index)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Calls.FirstOrDefault(c => c.Index == index)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Calls.Add(call)`；返回值紧邻使用处：`ExpressionStatementSyntax: Calls.Add(call);`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`calls.EnumerateArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in calls.EnumerateArray())          {              int index = item.TryGetProperty("index", out var n) ? n.GetInt32() : fallback; fallback++;              var call = Calls.FirstOrDefault(c => c.Index == index);              if (call == null) { call = new() { Index = index }; Calls.Add(call); }              if (item.TryGetProperty("id", out var id)) call.Id += id.GetString();              if (item.TryGetProperty("function", out var function))              {                  if (function.TryGetProperty("name", out var name)) call.Name += name.GetString();                  if (function.TryGetProperty("arguments", out var args)) call.AppendArguments(args.GetString());                  if (call.Name == "send_message")                  {                      if (!_streams.TryGetValue(index, out var reader))                      { reader = new(Group); _streams[index] = reader; reader.Feed(call.Arguments, progress, reasoning); }                      else if (function.TryGetProperty("arguments", out args)) reader.Feed(args.GetString() ?? "", progress, reasoning);                  }              }          }`
- `System.Text.Json.JsonElement.GetInt32()`；输入表达式：`n.GetInt32()`；返回值紧邻使用处：`ConditionalExpressionSyntax: item.TryGetProperty("index", out var n) ? n.GetInt32() : fallback`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`args.GetString()`；返回值紧邻使用处：`ArgumentSyntax: args.GetString()`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`args.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: args.GetString() ?? ""`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`id.GetString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: call.Id += id.GetString()`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`name.GetString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: call.Name += name.GetString()`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`function.TryGetProperty("arguments", out args)`；返回值紧邻使用处：`IfStatementSyntax: if (function.TryGetProperty("arguments", out args)) reader.Feed(args.GetString() ?? "", progress, reasoning);`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`function.TryGetProperty("arguments", out var args)`；返回值紧邻使用处：`IfStatementSyntax: if (function.TryGetProperty("arguments", out var args)) call.AppendArguments(args.GetString());`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`function.TryGetProperty("name", out var name)`；返回值紧邻使用处：`IfStatementSyntax: if (function.TryGetProperty("name", out var name)) call.Name += name.GetString();`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`item.TryGetProperty("function", out var function)`；返回值紧邻使用处：`IfStatementSyntax: if (item.TryGetProperty("function", out var function))              {                  if (function.TryGetProperty("name", out var name)) call.Name += name.GetString();                  if (function.TryGetProperty("arguments", out var args)) call.AppendArguments(args.GetString());                  if (call.Name == "send_message")                  {                      if (!_streams.TryGetValue(index, out var reader))                      { reader = new(Group); _streams[index] = reader; reader.Feed(call.Arguments, progress, reasoning); }                      else if (function.TryGetProperty("arguments", out args)) reader.Feed(args.GetString() ?? "", progress, reasoning);                  }              }`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`item.TryGetProperty("id", out var id)`；返回值紧邻使用处：`IfStatementSyntax: if (item.TryGetProperty("id", out var id)) call.Id += id.GetString();`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`item.TryGetProperty("index", out var n)`；返回值紧邻使用处：`ConditionalExpressionSyntax: item.TryGetProperty("index", out var n) ? n.GetInt32() : fallback`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`message.TryGetProperty("tool_calls", out var calls)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !message.TryGetProperty("tool_calls", out var calls)`

**赋值（含属性/字段和局部值）：**

- `_streams[index]` = `reader`
- `call.Id` += `id.GetString()`
- `call.Name` += `name.GetString()`
- `call` = `new() { Index = index }`
- `Index` = `index`
- `reader` = `new(Group)`

<a id="symbol-229eb9d26f21"></a>

## `NationalSpire.ChatToolRequest.Read() — private IEnumerable<(Dictionary<string, string> Fields, string Reply, string Speaker)> Read()`

来源：源码第 212 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatToolRequest.Apply(NationalSpire.PrivateStreamParser)`](ChatTools.cs.md#symbol-2741ec79193e)；[`NationalSpire.ChatToolRequest.FallbackText()`](ChatTools.cs.md#symbol-e2b21aa13bda)

**调用：** [`NationalSpire.ChatToolRequest.ReadItem(string, System.Text.Json.JsonElement)`](ChatTools.cs.md#symbol-cd510b59d78a)；[`NationalSpire.ChatToolRequest.RecordError(string, string)`](ChatTools.cs.md#symbol-af4909caab69)；[`NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`](ChatTools.cs.md#symbol-781c76caa651)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatToolCall.Arguments`；`NationalSpire.ChatToolCall.Index`；`NationalSpire.ChatToolCall.Name`；`NationalSpire.ChatToolRequest.Calls`；`NationalSpire.ChatToolRequest.ReadItem(string, System.Text.Json.JsonElement)`；`NationalSpire.ChatToolRequest.RecordError(string, string)`；`NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatToolRequest.ReadItem(string, System.Text.Json.JsonElement)`；输入表达式：`ReadItem(call.Name, root)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ReadItem(call.Name, root) is { } legacy`
- `NationalSpire.ChatToolRequest.ReadItem(string, System.Text.Json.JsonElement)`；输入表达式：`ReadItem(Value(type), item)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ReadItem(Value(type), item) is { } action`
- `NationalSpire.ChatToolRequest.RecordError(string, string)`；输入表达式：`RecordError(call.Name, "参数应为对象")`；返回值紧邻使用处：`ExpressionStatementSyntax: RecordError(call.Name, "参数应为对象");`
- `NationalSpire.ChatToolRequest.RecordError(string, string)`；输入表达式：`RecordError(call.Name, "正文段落应为对象")`；返回值紧邻使用处：`ExpressionStatementSyntax: RecordError(call.Name, "正文段落应为对象");`
- `NationalSpire.ChatToolRequest.RecordError(string, string)`；输入表达式：`RecordError(call.Name, e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: RecordError(call.Name, e.Message);`
- `NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`；输入表达式：`Value(simple)`；返回值紧邻使用处：`ArgumentSyntax: Value(simple)`
- `NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`；输入表达式：`Value(speaker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: reply.TryGetProperty("Speaker", out var speaker) ? Value(speaker) : ""`
- `NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`；输入表达式：`Value(speaker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: root.TryGetProperty("Speaker", out var speaker) ? Value(speaker) : ""`
- `NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`；输入表达式：`Value(text)`；返回值紧邻使用处：`ConditionalExpressionSyntax: reply.TryGetProperty("Reply", out var text) ? Value(text) : ""`
- `NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`；输入表达式：`Value(type)`；返回值紧邻使用处：`ArgumentSyntax: Value(type)`
- `NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`；输入表达式：`Value(value)`；返回值紧邻使用处：`AssignmentExpressionSyntax: fields[key] = Value(value)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Calls.OrderBy(c => c.Index)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var call in Calls.OrderBy(c => c.Index))          {              JsonDocument? json = null;              try              {                  json = JsonDocument.Parse(call.Arguments);              }              catch (JsonException e) { RecordError(call.Name, e.Message); }              if (json == null) continue;              using (json)              {                  var root = json.RootElement;                  if (call.Name != "send_message")                  {                      if (ReadItem(call.Name, root) is { } legacy) yield return legacy;                      continue;                  }                  if (root.ValueKind != JsonValueKind.Object) { RecordError(call.Name, "参数应为对象"); continue; }                  if (root.TryGetProperty("Replies", out var replies) && replies.ValueKind == JsonValueKind.Array)                      foreach (var reply in replies.EnumerateArray())                      {                          if (reply.ValueKind != JsonValueKind.Object) { RecordError(call.Name, "正文段落应为对象"); continue; }                          var fields = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);                          foreach (string key in new[] { "Scene", "Emotion", "Background" })                              if (reply.TryGetProperty(key, out var value)) fields[key] = Value(value);                          yield return (fields, reply.TryGetProperty("Reply", out var text) ? Value(text) : "", reply.TryGetProperty("Speaker", out var speaker) ? Value(speaker) : "");                      }                  if (root.TryGetProperty("Reply", out var simple)) yield return (new(), Value(simple), root.TryGetProperty("Speaker", out var speaker) ? Value(speaker) : "");                  if (root.TryGetProperty("Interactions", out var interactions) && interactions.ValueKind == JsonValueKind.Array)                      foreach (var item in interactions.EnumerateArray())                          if (item.ValueKind == JsonValueKind.Object && item.TryGetProperty("Type", out var type)                              && ReadItem(Value(type), item) is { } action) yield return action;              }          }`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(call.Arguments)`；返回值紧邻使用处：`AssignmentExpressionSyntax: json = JsonDocument.Parse(call.Arguments)`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`interactions.EnumerateArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in interactions.EnumerateArray())                          if (item.ValueKind == JsonValueKind.Object && item.TryGetProperty("Type", out var type)                              && ReadItem(Value(type), item) is { } action) yield return action;`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`replies.EnumerateArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var reply in replies.EnumerateArray())                      {                          if (reply.ValueKind != JsonValueKind.Object) { RecordError(call.Name, "正文段落应为对象"); continue; }                          var fields = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);                          foreach (string key in new[] { "Scene", "Emotion", "Background" })                              if (reply.TryGetProperty(key, out var value)) fields[key] = Value(value);                          yield return (fields, reply.TryGetProperty("Reply", out var text) ? Value(text) : "", reply.TryGetProperty("Speaker", out var speaker) ? Value(speaker) : "");                      }`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`item.TryGetProperty("Type", out var type)`；返回值紧邻使用处：`BinaryExpressionSyntax: item.ValueKind == JsonValueKind.Object && item.TryGetProperty("Type", out var type)`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`reply.TryGetProperty("Reply", out var text)`；返回值紧邻使用处：`ConditionalExpressionSyntax: reply.TryGetProperty("Reply", out var text) ? Value(text) : ""`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`reply.TryGetProperty("Speaker", out var speaker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: reply.TryGetProperty("Speaker", out var speaker) ? Value(speaker) : ""`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`reply.TryGetProperty(key, out var value)`；返回值紧邻使用处：`IfStatementSyntax: if (reply.TryGetProperty(key, out var value)) fields[key] = Value(value);`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("Interactions", out var interactions)`；返回值紧邻使用处：`BinaryExpressionSyntax: root.TryGetProperty("Interactions", out var interactions) && interactions.ValueKind == JsonValueKind.Array`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("Replies", out var replies)`；返回值紧邻使用处：`BinaryExpressionSyntax: root.TryGetProperty("Replies", out var replies) && replies.ValueKind == JsonValueKind.Array`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("Reply", out var simple)`；返回值紧邻使用处：`IfStatementSyntax: if (root.TryGetProperty("Reply", out var simple)) yield return (new(), Value(simple), root.TryGetProperty("Speaker", out var speaker) ? Value(speaker) : "");`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("Speaker", out var speaker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: root.TryGetProperty("Speaker", out var speaker) ? Value(speaker) : ""`

**赋值（含属性/字段和局部值）：**

- `fields[key]` = `Value(value)`
- `json` = `JsonDocument.Parse(call.Arguments)`

<a id="symbol-781c76caa651"></a>

## `NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement) — private string Value(JsonElement value)`

来源：源码第 249 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatToolRequest.Read()`](ChatTools.cs.md#symbol-229eb9d26f21)；[`NationalSpire.ChatToolRequest.ReadItem(string, System.Text.Json.JsonElement)`](ChatTools.cs.md#symbol-cd510b59d78a)

**调用：** [`NationalSpire.ChatToolRequest.RecordError(string, string)`](ChatTools.cs.md#symbol-af4909caab69)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.GetRawText()`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatToolRequest.RecordError(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatToolRequest.RecordError(string, string)`；输入表达式：`RecordError("send_message", e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: RecordError("send_message", e.Message);`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("|", value.EnumerateArray().Select(v => v.ToString()))`；返回值紧邻使用处：`ConditionalExpressionSyntax: value.ValueKind == JsonValueKind.Array ? string.Join("|", value.EnumerateArray().Select(v => v.ToString())) : value.ToString()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`value.EnumerateArray().Select(v => v.ToString())`；返回值紧邻使用处：`ArgumentSyntax: value.EnumerateArray().Select(v => v.ToString())`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`value.EnumerateArray()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: value.EnumerateArray().Select`
- `System.Text.Json.JsonElement.GetRawText()`；输入表达式：`value.GetRawText()`；返回值紧邻使用处：`ReturnStatementSyntax: return value.GetRawText();`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`value.GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: value.GetString()!`
- `System.Text.Json.JsonElement.ToString()`；输入表达式：`v.ToString()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: v => v.ToString()`
- `System.Text.Json.JsonElement.ToString()`；输入表达式：`value.ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: value.ValueKind == JsonValueKind.Array ? string.Join("|", value.EnumerateArray().Select(v => v.ToString())) : value.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cd510b59d78a"></a>

## `NationalSpire.ChatToolRequest.ReadItem(string, System.Text.Json.JsonElement) — private (Dictionary<string, string> Fields, string Reply, string Speaker)? ReadItem(string name, JsonElement item)`

来源：源码第 255 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatToolRequest.Read()`](ChatTools.cs.md#symbol-229eb9d26f21)

**调用：** [`NationalSpire.ChatToolRequest.RecordError(string, string)`](ChatTools.cs.md#symbol-af4909caab69)；[`NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`](ChatTools.cs.md#symbol-781c76caa651)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Text.Json.JsonElement.EnumerateObject()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatToolRequest._features`；`NationalSpire.ChatToolRequest.Group`；`NationalSpire.ChatToolRequest.RecordError(string, string)`；`NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`；`NationalSpire.ChatTools.Feature.Fields`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatToolRequest.RecordError(string, string)`；输入表达式：`RecordError(name, "参数应为对象")`；返回值紧邻使用处：`ExpressionStatementSyntax: RecordError(name, "参数应为对象");`
- `NationalSpire.ChatToolRequest.RecordError(string, string)`；输入表达式：`RecordError(name, "未知交互类型")`；返回值紧邻使用处：`ExpressionStatementSyntax: RecordError(name, "未知交互类型");`
- `NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`；输入表达式：`Value(p.Value)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Value(p.Value)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_features.TryGetValue(name, out var feature)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_features.TryGetValue(name, out var feature)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`feature.Fields.Contains(p.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: feature.Fields.Contains(p.Name) || Group && p.Name is "Actor" or "Target" or "Participants" or "Related" or "Coach"`
- `System.Text.Json.JsonElement.EnumerateObject()`；输入表达式：`item.EnumerateObject()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var p in item.EnumerateObject())          {              string value = Value(p.Value);              if (p.Name == "Reply") reply = value;              else if (p.Name == "Speaker") speaker = value;              else if (feature.Fields.Contains(p.Name) || Group && p.Name is "Actor" or "Target" or "Participants" or "Related" or "Coach") fields[p.Name] = value;          }`

**赋值（含属性/字段和局部值）：**

- `fields[p.Name]` = `value`
- `reply` = `value`
- `speaker` = `value`

<a id="symbol-af4909caab69"></a>

## `NationalSpire.ChatToolRequest.RecordError(string, string) — private void RecordError(string name, string reason)`

来源：源码第 269 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatToolRequest.Read()`](ChatTools.cs.md#symbol-229eb9d26f21)；[`NationalSpire.ChatToolRequest.ReadItem(string, System.Text.Json.JsonElement)`](ChatTools.cs.md#symbol-cd510b59d78a)；[`NationalSpire.ChatToolRequest.Value(System.Text.Json.JsonElement)`](ChatTools.cs.md#symbol-781c76caa651)

**调用：** `string.Contains(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatToolRequest.Error`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Contains(string, System.StringComparison)`；输入表达式：`Error.Contains(text, StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Error.Contains(text, StringComparison.Ordinal)`

**赋值（含属性/字段和局部值）：**

- `Error` += `"\n" + text`

<a id="symbol-e2b21aa13bda"></a>

## `NationalSpire.ChatToolRequest.FallbackText() — public string FallbackText()`

来源：源码第 271 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`FinishText()`](AiPrivateMessages.cs.md#symbol-105a40137cba)

**调用：** [`NationalSpire.ChatToolRequest.Read()`](ChatTools.cs.md#symbol-229eb9d26f21)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `(System.Collections.Generic.Dictionary<string, string> Fields, string Reply, string Speaker).Fields`；`(System.Collections.Generic.Dictionary<string, string> Fields, string Reply, string Speaker).Reply`；`(System.Collections.Generic.Dictionary<string, string> Fields, string Reply, string Speaker).Speaker`；`NationalSpire.ChatToolRequest.Group`；`NationalSpire.ChatToolRequest.Read()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatToolRequest.Read()`；输入表达式：`Read()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Read().Where`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", replies)`；返回值紧邻使用处：`ReturnStatementSyntax: return string.Join("\n", replies);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`x.Fields.ContainsKey("Scene")`；返回值紧邻使用处：`BinaryExpressionSyntax: x.Fields.Count == 0 || x.Fields.ContainsKey("Scene")`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`seen.Add(text)`；返回值紧邻使用处：`BinaryExpressionSyntax: x.Fields.Count == 0 || x.Fields.ContainsKey("Scene") || seen.Add(text)`
- `System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；输入表达式：`new HashSet<string>(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>(StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Read().Where(x => x.Reply.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var x in Read().Where(x => x.Reply.Length > 0))          {              string text = Group ? "[Speaker: " + (x.Speaker.Length > 0 ? x.Speaker : x.Fields.GetValueOrDefault("Actor", "")) + "]\n" + x.Reply : x.Reply;              if (x.Fields.Count == 0 || x.Fields.ContainsKey("Scene") || seen.Add(text)) replies.Add(text);          }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`x.Fields.GetValueOrDefault("Actor", "")`；返回值紧邻使用处：`ConditionalExpressionSyntax: x.Speaker.Length > 0 ? x.Speaker : x.Fields.GetValueOrDefault("Actor", "")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`replies.Add(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: replies.Add(text);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2741ec79193e"></a>

## `NationalSpire.ChatToolRequest.Apply(NationalSpire.PrivateStreamParser) — public void Apply(PrivateStreamParser parser)`

来源：源码第 281 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)

**调用：** [`NationalSpire.ChatToolRequest.Read()`](ChatTools.cs.md#symbol-229eb9d26f21)；`string.IndexOf(string, int, System.StringComparison)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatToolRequest.Read()`；`NationalSpire.PrivateStreamParser.Directives`；`NationalSpire.PrivateStreamParser.SceneCues`；`NationalSpire.PrivateStreamParser.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatToolRequest.Read()`；输入表达式：`Read()`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (fields, reply, _) in Read())          {              if (fields.ContainsKey("Scene"))              {                  int offset = parser.Text.IndexOf(reply, sceneOffset, StringComparison.Ordinal);                  parser.SceneCues.Add((Math.Max(0, offset), fields));                  if (offset >= 0) sceneOffset = offset + reply.Length;              }              else if (fields.Count > 0 && !parser.Directives.Any(old => old.Count == fields.Count && old.All(p => fields.GetValueOrDefault(p.Key) == p.Value))) parser.Directives.Add(fields);          }`
- `string.IndexOf(string, int, System.StringComparison)`；输入表达式：`parser.Text.IndexOf(reply, sceneOffset, StringComparison.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = parser.Text.IndexOf(reply, sceneOffset, StringComparison.Ordinal)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Scene")`；返回值紧邻使用处：`IfStatementSyntax: if (fields.ContainsKey("Scene"))              {                  int offset = parser.Text.IndexOf(reply, sceneOffset, StringComparison.Ordinal);                  parser.SceneCues.Add((Math.Max(0, offset), fields));                  if (offset >= 0) sceneOffset = offset + reply.Length;              }              else if (fields.Count > 0 && !parser.Directives.Any(old => old.Count == fields.Count && old.All(p => fields.GetValueOrDefault(p.Key) == p.Value))) parser.Directives.Add(fields);`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`old.All(p => fields.GetValueOrDefault(p.Key) == p.Value)`；返回值紧邻使用处：`BinaryExpressionSyntax: old.Count == fields.Count && old.All(p => fields.GetValueOrDefault(p.Key) == p.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`parser.Directives.Any(old => old.Count == fields.Count && old.All(p => fields.GetValueOrDefault(p.Key) == p.Value))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !parser.Directives.Any(old => old.Count == fields.Count && old.All(p => fields.GetValueOrDefault(p.Key) == p.Value))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault(p.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.GetValueOrDefault(p.Key) == p.Value`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`parser.Directives.Add(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.Directives.Add(fields);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`parser.SceneCues.Add((Math.Max(0, offset), fields))`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.SceneCues.Add((Math.Max(0, offset), fields));`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, offset)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, offset)`

**赋值（含属性/字段和局部值）：**

- `sceneOffset` = `offset + reply.Length`

<a id="symbol-3c38f9bbe535"></a>

## `NationalSpire.ChatReplyStream.Feed(string, System.Action<string>?, System.Action<string>?) — public void Feed(string chunk, Action<string>? progress, Action<string>? reasoning)`

来源：源码第 314 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatToolRequest.Feed(System.Text.Json.JsonElement, System.Action<string>?, System.Action<string>?)`](ChatTools.cs.md#symbol-bfdf106e5cdf)

**调用：** [`Character(char)`](ChatTools.cs.md#symbol-ea611f3d7f57)；[`Flush(NationalSpire.ChatReplyStream.Frame)`](ChatTools.cs.md#symbol-d73653f05501)；`NationalSpire.ChatReplyStream.Frame.Frame(char, bool, bool)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.Stack<T>.Push(T)`；`System.Collections.Generic.Stack<T>.TryPeek(out T)`；`System.Collections.Generic.Stack<T>.TryPop(out T)`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `Character(char)`；`Flush(NationalSpire.ChatReplyStream.Frame)`；`NationalSpire.ChatReplyStream._escape`；`NationalSpire.ChatReplyStream._field`；`NationalSpire.ChatReplyStream._frames`；`NationalSpire.ChatReplyStream._key`；`NationalSpire.ChatReplyStream._owner`；`NationalSpire.ChatReplyStream._quoted`；`NationalSpire.ChatReplyStream._token`；`NationalSpire.ChatReplyStream._unicode`；`NationalSpire.ChatReplyStream._unicodeLeft`；`NationalSpire.ChatReplyStream.Frame.Key`；`NationalSpire.ChatReplyStream.Frame.KeyExpected`；`NationalSpire.ChatReplyStream.Frame.Kind`；`NationalSpire.ChatReplyStream.Frame.Metadata`；`NationalSpire.ChatReplyStream.Frame.Opened`；`NationalSpire.ChatReplyStream.Frame.Paragraph`；`NationalSpire.ChatReplyStream.Frame.Replies`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Character(char)`；输入表达式：`Character((char)_unicode)`；返回值紧邻使用处：`ExpressionStatementSyntax: Character((char)_unicode);`
- `Character(char)`；输入表达式：`Character(c switch { 'n' => '\n', 'r' => '\r', 't' => '\t', 'b' => '\b', 'f' => '\f', _ => c })`；返回值紧邻使用处：`ExpressionStatementSyntax: Character(c switch { 'n' => '\n', 'r' => '\r', 't' => '\t', 'b' => '\b', 'f' => '\f', _ => c });`
- `Character(char)`；输入表达式：`Character(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: Character(c);`
- `Flush(NationalSpire.ChatReplyStream.Frame)`；输入表达式：`Flush(_owner)`；返回值紧邻使用处：`ExpressionStatementSyntax: Flush(_owner);`
- `Flush(NationalSpire.ChatReplyStream.Frame)`；输入表达式：`Flush(frame)`；返回值紧邻使用处：`ExpressionStatementSyntax: Flush(frame);`
- `NationalSpire.ChatReplyStream.Frame.Frame(char, bool, bool)`；输入表达式：`new(c, c == '[' && parent?.Key == "Replies", c == '{' && parent?.Replies == true)`；返回值紧邻使用处：`ArgumentSyntax: new(c, c == '[' && parent?.Key == "Replies", c == '{' && parent?.Replies == true)`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(analysis.ToString())`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: reasoning?.Invoke(analysis.ToString())`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(output.ToString())`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: progress?.Invoke(output.ToString())`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`_frames.Push(new(c, c == '[' && parent?.Key == "Replies", c == '{' && parent?.Replies == true))`；返回值紧邻使用处：`ExpressionStatementSyntax: _frames.Push(new(c, c == '[' && parent?.Key == "Replies", c == '{' && parent?.Replies == true));`
- `System.Collections.Generic.Stack<T>.TryPeek(out T)`；输入表达式：`_frames.TryPeek(out var parent)`；返回值紧邻使用处：`ExpressionStatementSyntax: _frames.TryPeek(out var parent);`
- `System.Collections.Generic.Stack<T>.TryPop(out T)`；输入表达式：`_frames.TryPop(out var frame)`；返回值紧邻使用处：`BinaryExpressionSyntax: _frames.TryPop(out var frame) && frame.Paragraph`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`output.Append('\n')`；返回值紧邻使用处：`ExpressionStatementSyntax: output.Append('\n');`
- `System.Text.StringBuilder.Clear()`；输入表达式：`_token.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _token.Clear();`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_token.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _owner.Key = _token.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_token.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _owner.Metadata[_field] = _token.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`analysis.ToString()`；返回值紧邻使用处：`ArgumentSyntax: analysis.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`output.ToString()`；返回值紧邻使用处：`ArgumentSyntax: output.ToString()`

**赋值（含属性/字段和局部值）：**

- `_escape` = `false`
- `_escape` = `true`
- `_field` = `parent?.Key ?? ""`
- `_key` = `parent?.KeyExpected == true`
- `_owner.Key` = `_token.ToString()`
- `_owner.KeyExpected` = `false`
- `_owner.Metadata[_field]` = `_token.ToString()`
- `_owner` = `parent`
- `_quoted` = `false`
- `_quoted` = `true`
- `_unicode` = `(_unicode << 4) + digit`
- `_unicode` = `0`
- `_unicodeLeft` = `4`
- `parent.Key` = `""`
- `parent.KeyExpected` = `true`

<a id="symbol-d73653f05501"></a>

## `Flush(NationalSpire.ChatReplyStream.Frame) — void Flush(Frame frame)`

来源：源码第 317 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatReplyStream.Feed(string, System.Action<string>?, System.Action<string>?)`](ChatTools.cs.md#symbol-3c38f9bbe535)

**调用：** `char.IsHighSurrogate(char)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.Remove(int, int)`；`System.Text.StringBuilder.ToString(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatReplyStream.Frame.Metadata`；`NationalSpire.ChatReplyStream.Frame.Opened`；`NationalSpire.ChatReplyStream.Frame.Paragraph`；`NationalSpire.ChatReplyStream.Frame.Pending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsHighSurrogate(char)`；输入表达式：`char.IsHighSurrogate(frame.Pending[count - 1])`；返回值紧邻使用处：`IfStatementSyntax: if (char.IsHighSurrogate(frame.Pending[count - 1])) count--;`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`frame.Metadata.ContainsKey("Scene")`；返回值紧邻使用处：`IfStatementSyntax: if (frame.Metadata.ContainsKey("Scene"))                      output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append(frame.Metadata.GetValueOrDefault("Emotion", "neutral"))                          .Append(", Background: ").Append(frame.Metadata.GetValueOrDefault("Background", "current")).Append(']');`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`frame.Metadata.ContainsKey("Speaker")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !frame.Metadata.ContainsKey("Speaker")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`frame.Metadata.GetValueOrDefault("Background", "current")`；返回值紧邻使用处：`ArgumentSyntax: frame.Metadata.GetValueOrDefault("Background", "current")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`frame.Metadata.GetValueOrDefault("Emotion", "neutral")`；返回值紧邻使用处：`ArgumentSyntax: frame.Metadata.GetValueOrDefault("Emotion", "neutral")`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append(frame.Metadata.GetValueOrDefault("Emotion", "neutral"))                          .Append(", Background: ").Append(frame.Metadata.GetValueOrDefault("Background", "current")).Append(']')`；返回值紧邻使用处：`ExpressionStatementSyntax: output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append(frame.Metadata.GetValueOrDefault("Emotion", "neutral"))                          .Append(", Background: ").Append(frame.Metadata.GetValueOrDefault("Background", "current")).Append(']');`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`analysis.Append(frame.Pending.ToString(0, count))`；返回值紧邻使用处：`ExpressionStatementSyntax: analysis.Append(frame.Pending.ToString(0, count));`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append(frame.Metadata.GetValueOrDefault("Emotion", "neutral"))                          .Append(", Background: ").Append(frame.Metadata.GetValueOrDefault("Background", "current"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append(frame.Metadata.GetValueOrDefault("Emotion", "neutral"))                          .Append(", Background: ").Append(frame.Metadata.GetValueOrDefault("Background", "current")).Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append(frame.Metadata.GetValueOrDefault("Emotion", "neutral"))                          .Append(", Background: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append(frame.Metadata.GetValueOrDefault("Emotion", "neutral"))                          .Append(", Background: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append(frame.Metadata.GetValueOrDefault("Emotion", "neutral"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append(frame.Metadata.GetValueOrDefault("Emotion", "neutral"))                          .Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`output.Append("[Scene: ").Append(frame.Metadata["Scene"])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`output.Append("[Scene: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: output.Append("[Scene: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`output.Append("[Speaker: ").Append(frame.Metadata["Speaker"]).Append("]\n")`；返回值紧邻使用处：`ExpressionStatementSyntax: output.Append("[Speaker: ").Append(frame.Metadata["Speaker"]).Append("]\n");`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`output.Append("[Speaker: ").Append(frame.Metadata["Speaker"])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: output.Append("[Speaker: ").Append(frame.Metadata["Speaker"]).Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`output.Append("[Speaker: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: output.Append("[Speaker: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`output.Append(frame.Pending.ToString(0, count))`；返回值紧邻使用处：`ExpressionStatementSyntax: output.Append(frame.Pending.ToString(0, count));`
- `System.Text.StringBuilder.Remove(int, int)`；输入表达式：`frame.Pending.Remove(0, count)`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.Pending.Remove(0, count);`
- `System.Text.StringBuilder.ToString(int, int)`；输入表达式：`frame.Pending.ToString(0, count)`；返回值紧邻使用处：`ArgumentSyntax: frame.Pending.ToString(0, count)`

**赋值（含属性/字段和局部值）：**

- `frame.Opened` = `true`

<a id="symbol-ea611f3d7f57"></a>

## `Character(char) — void Character(char c)`

来源：源码第 335 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatReplyStream.Feed(string, System.Action<string>?, System.Action<string>?)`](ChatTools.cs.md#symbol-3c38f9bbe535)

**调用：** `System.Text.StringBuilder.Append(char)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatReplyStream._field`；`NationalSpire.ChatReplyStream._frames`；`NationalSpire.ChatReplyStream._key`；`NationalSpire.ChatReplyStream._owner`；`NationalSpire.ChatReplyStream._token`；`NationalSpire.ChatReplyStream.Frame.Paragraph`；`NationalSpire.ChatReplyStream.Frame.Pending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.StringBuilder.Append(char)`；输入表达式：`_owner.Pending.Append(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: _owner.Pending.Append(c);`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`_token.Append(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: _token.Append(c);`

**赋值（含属性/字段和局部值）：**
