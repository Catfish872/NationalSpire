# SocialAppointments.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`339382204B4E8FA331C6960E9FB77EDB65E3F7F12B2852D1A7E1CFF72DA76496`。来源：[源码](../../SocialAppointments.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.SocialAppointments`。

字段、事件及初始值（源码原样）：

```csharp
public const string ExpiredDate = "填写的邀约日期已过期，请重新约定日期";
public const string Protocol = """
玩家主动提出或暗示活动意愿时，可以商谈活动。人物同意参加、提出新邀请、商定改期或决定取消时，必须在本轮回复中输出对应的 Activity 标记，程序据此登记活动。
每条活动标记完整填写 Activity、Id、Title、Date、Detail。
Activity 填邀请、接受、改期或取消；Id 填对应活动编号，新提议填0；Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。
提出新活动：
[Activity: 邀请, Id: 0, Title: 一起看录像, Date: 2026-01-18, Detail: 讨论今天的比赛]
接受玩家提出的活动：
[Activity: 接受, Id: 14, Title: 一起看录像, Date: 2026-01-18, Detail: 讨论今天的比赛]
商谈改期：
[Activity: 改期, Id: 14, Title: 一起看录像, Date: 2026-01-19, Detail: 讨论今天的比赛]
谢绝或取消活动：
[Activity: 取消, Id: 14, Title: 一起看录像, Date: 2026-01-18, Detail: 讨论今天的比赛]
接受时按玩家附件填写活动资料；改期时填写商谈后的日期和内容；取消时填写对应活动的资料。
只有标记才登记交互，口头答应无法触发实际效果。
""";
```

<a id="symbol-56b98eeeac09"></a>

## `NationalSpire.SocialAppointments.StatusText(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string StatusText(CareerData d, PrivateOffer o)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`](GroupChatPrompts.cs.md#symbol-ccc55b5e837d)；[`NationalSpire.PrivateMessagePrompts.OfferContext(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessagePrompts.cs.md#symbol-67bd27e9ea35)

**调用：** [`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.State`；`NationalSpire.SocialAppointments.ExpiredDate`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, o)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, o) < d.Day`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d06f06e1cd36"></a>

## `NationalSpire.SocialAppointments.GroupProtocol — public static string GroupProtocol`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.SocialAppointments.Protocol`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(string, string?)`；输入表达式：`Protocol          .Replace("每条活动标记完整填写 Activity、Id、Title、Date、Detail。", "群聊活动完整填写 Activity、Id、Title、Date、Detail、Actor。Actor 填已经谈妥的完整参与者编号，包括参加活动的玩家，多人以竖线分隔。一项共同活动输出一条标记。处理活动附件时，逐一核对附件中的参与者，将已谈妥的完整名单填写到 Actor。")          .Replace("Detail: 讨论今天的比赛]", "Detail: 讨论今天的比赛, Actor: p1|p2|p3]")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Protocol          .Replace("每条活动标记完整填写 Activity、Id、Title、Date、Detail。", "群聊活动完整填写 Activity、Id、Title、Date、Detail、Actor。Actor 填已经谈妥的完整参与者编号，包括参加活动的玩家，多人以竖线分隔。一项共同活动输出一条标记。处理活动附件时，逐一核对附件中的参与者，将已谈妥的完整名单填写到 Actor。")          .Replace("Detail: 讨论今天的比赛]", "Detail: 讨论今天的比赛, Actor: p1|p2|p3]")`
- `string.Replace(string, string?)`；输入表达式：`Protocol          .Replace("每条活动标记完整填写 Activity、Id、Title、Date、Detail。", "群聊活动完整填写 Activity、Id、Title、Date、Detail、Actor。Actor 填已经谈妥的完整参与者编号，包括参加活动的玩家，多人以竖线分隔。一项共同活动输出一条标记。处理活动附件时，逐一核对附件中的参与者，将已谈妥的完整名单填写到 Actor。")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Protocol          .Replace("每条活动标记完整填写 Activity、Id、Title、Date、Detail。", "群聊活动完整填写 Activity、Id、Title、Date、Detail、Actor。Actor 填已经谈妥的完整参与者编号，包括参加活动的玩家，多人以竖线分隔。一项共同活动输出一条标记。处理活动附件时，逐一核对附件中的参与者，将已谈妥的完整名单填写到 Actor。")          .Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0596ed8dd544"></a>

## `NationalSpire.SocialAppointments.All(NationalSpire.CareerData) — public static IEnumerable<(PrivateConversation Conversation, PrivateOffer Offer)> All(CareerData d)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.NextEventDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-0dbe0f2d1cdc)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`](PrivateAppointments.cs.md#symbol-8d91a4d33a55)；[`NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`](RandomEventPrompts.cs.md#symbol-a96ac205ab9d)；[`NationalSpire.SocialAppointments.Due(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-d348017d127b)；[`NationalSpire.SocialAppointments.Expire(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-53508b4eaa4e)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.StartsWith(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.DateSourceGroup`；`NationalSpire.PrivateOffer.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Human(d) + "/"`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Values.Concat(d.Chats.Groups.SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations.Values.Concat(d.Chats.Groups.SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0).Select(o => (c, o))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0).Select(o => (c, o))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Values.Concat(d.Chats.Groups.SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))).SelectMany(c => c.Offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0).Select(o => (c, o)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateMessages.Mailbox(d).Conversations.Values.Concat(d.Chats.Groups.SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))).SelectMany(c => c.Offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0).Select(o => (c, o)))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`d.Chats.Groups.SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))`；返回值紧邻使用处：`ArgumentSyntax: d.Chats.Groups.SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select`
- `string.StartsWith(string)`；输入表达式：`x.Key.StartsWith(GroupChats.Human(d) + "/")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x => x.Key.StartsWith(GroupChats.Human(d) + "/")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d348017d127b"></a>

## `NationalSpire.SocialAppointments.Due(NationalSpire.CareerData) — public static IEnumerable<(PrivateConversation Conversation, PrivateOffer Offer)> Due(CareerData d)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.Coop.CoopRules.ExecuteProposal(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-fecbe30f550e)

**调用：** [`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-0596ed8dd544)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(NationalSpire.PrivateConversation Conversation, NationalSpire.PrivateOffer Offer).Offer`；`NationalSpire.CareerData.Day`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.State`；`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, x.Offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, x.Offer) == d.Day`
- `NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`；输入表达式：`All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(d).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`All(d).Where(x => x.Offer.State == "已确认" && PrivateAppointments.Date(d, x.Offer) == d.Day)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => All(d).Where(x => x.Offer.State == "已确认" && PrivateAppointments.Date(d, x.Offer) == d.Day)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-53508b4eaa4e"></a>

## `NationalSpire.SocialAppointments.Expire(NationalSpire.CareerData) — public static void Expire(CareerData d)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)；[`NationalSpire.Coop.CoopRules.AdvanceMembers(NationalSpire.Coop.CoopWorld)`](Coop/CoopRules.cs.md#symbol-bc24477e89ba)

**调用：** [`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-0596ed8dd544)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(NationalSpire.PrivateConversation Conversation, NationalSpire.PrivateOffer Offer).Offer`；`NationalSpire.CareerData.Day`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.State`；`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, x.Offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, x.Offer) < d.Day`
- `NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`；输入表达式：`All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(d).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`All(d).Where(x => x.Offer.State == "已确认" && PrivateAppointments.Date(d, x.Offer) < d.Day)`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (_, o) in All(d).Where(x => x.Offer.State == "已确认" && PrivateAppointments.Date(d, x.Offer) < d.Day)) o.State = "未赴约";`

**赋值（含属性/字段和局部值）：**

- `o.State` = `"未赴约"`

<a id="symbol-33a4725630bd"></a>

## `NationalSpire.SocialAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>) — public static void Respond(CareerData d, PrivateConversation c, PrivateTurn t, Dictionary<string, string> fields)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** [`NationalSpire.ChatAttachments.Find(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, string, System.Collections.Generic.Dictionary<string, string>)`](ChatAttachments.cs.md#symbol-10ee34a4e855)；[`NationalSpire.ConsumerAttachments.Resolve(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`](ConsumerAttachments.cs.md#symbol-f88b230b016a)；[`NationalSpire.GameCalendar.NormalizeFields(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, string>)`](GameCalendar.cs.md#symbol-65b6dda6244b)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`](PrivateMessageData.cs.md#symbol-2a4d65cc20f8)；[`NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`](PrivateMessageData.cs.md#symbol-ad3e5a4298ba)；`NationalSpire.PrivateOffer.PrivateOffer()`；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`int.TryParse(string?, out int)`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.ChatAttachments.Find(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, string, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.ConsumerAttachments.Resolve(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`；`NationalSpire.GameCalendar.NormalizeFields(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`；`NationalSpire.PrivateOffer.ConsumerAttachmentId`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GoodVerb`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.ReplacesOfferId`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.ServiceId`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateOffer.WeddingServiceIds`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SocialAppointments.ExpiredDate`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatAttachments.Find(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, string, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`ChatAttachments.Find(c, t, "activity", fields)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ChatAttachments.Find(c, t, "activity", fields)`
- `NationalSpire.ConsumerAttachments.Resolve(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`；输入表达式：`ConsumerAttachments.Resolve(d, cancelled, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerAttachments.Resolve(d, cancelled, false);`
- `NationalSpire.ConsumerAttachments.Resolve(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`；输入表达式：`ConsumerAttachments.Resolve(d, o, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerAttachments.Resolve(d, o, true);`
- `NationalSpire.GameCalendar.NormalizeFields(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`GameCalendar.NormalizeFields(d, fields)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GameCalendar.NormalizeFields(d, fields)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`ExpressionElementSyntax: GroupChats.Human(d)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, o)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, o) < d.Day`
- `NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；输入表达式：`PrivateInteractionIds.Ensure(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionIds.Ensure(c);`
- `NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`；输入表达式：`PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id"))`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id"))`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = "activity", TurnId = t.Id, Title = fields.GetValueOrDefault("Title", basis?.Title ?? ""), Detail = fields.GetValueOrDefault("Detail", basis?.Detail ?? ""), ReplacesOfferId = old?.Id ?? "", ConsumerAttachmentId = basis?.ConsumerAttachmentId ?? "", ServiceId = basis?.ServiceId ?? "", WeddingServiceIds = basis?.WeddingServiceIds.ToList() ?? [], GoodId = basis?.GoodId ?? "", GoodVerb = basis?.GoodVerb ?? "", Participants = basis?.Participants.ToList() ?? [GroupChats.Human(d), c.PersonId] }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = "activity", TurnId = t.Id, Title = fields.GetValueOrDefault("Title", basis?.Title ?? ""), Detail = fields.GetValueOrDefault("Detail", basis?.Detail ?? ""), ReplacesOfferId = old?.Id ?? "", ConsumerAttachmentId = basis?.ConsumerAttachmentId ?? "", ServiceId = basis?.ServiceId ?? "", WeddingServiceIds = basis?.WeddingServiceIds.ToList() ?? [], GoodId = basis?.GoodId ?? "", GoodVerb = basis?.GoodVerb ?? "", Participants = basis?.Participants.ToList() ?? [GroupChats.Human(d), c.PersonId] }`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Id = attachment.Id, Kind = "activity", TurnId = t.Id, Title = attachment.Title, Detail = attachment.Detail, Season = attachment.Season, Day = attachment.Day, Participants = attachment.Participants.ToList(), State = "已取消" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = attachment.Id, Kind = "activity", TurnId = t.Id, Title = attachment.Title, Detail = attachment.Detail, Season = attachment.Season, Day = attachment.Day, Participants = attachment.Participants.ToList(), State = "已取消" }`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d, o.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Day > SeasonCalendar.Length(d, o.Season)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.FirstOrDefault(o => o.Kind == "activity" && o.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Offers.FirstOrDefault(o => o.Kind == "activity" && o.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.FirstOrDefault(o => o.Kind == "activity" && o.Id == attachment.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: old = c.Offers.FirstOrDefault(o => o.Kind == "activity" && o.Id == attachment.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`.Participants.ToList()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: basis?.Participants.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`.WeddingServiceIds.ToList()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: basis?.WeddingServiceIds.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`attachment.Participants.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Participants = attachment.Participants.ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Day")`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault("Day")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Id")`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault("Id")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Season")`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault("Season")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Activity", "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fields.GetValueOrDefault("Activity", "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Detail", basis?.Detail ?? "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Detail = fields.GetValueOrDefault("Detail", basis?.Detail ?? "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Id", "")`；返回值紧邻使用处：`IsPatternExpressionSyntax: fields.GetValueOrDefault("Id", "") is "" or "0"`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Title", basis?.Title ?? "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Title = fields.GetValueOrDefault("Title", basis?.Title ?? "")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Offers.Add(new() { Id = attachment.Id, Kind = "activity", TurnId = t.Id, Title = attachment.Title, Detail = attachment.Detail, Season = attachment.Season, Day = attachment.Day, Participants = attachment.Participants.ToList(), State = "已取消" })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Add(new() { Id = attachment.Id, Kind = "activity", TurnId = t.Id, Title = attachment.Title, Detail = attachment.Detail, Season = attachment.Season, Day = attachment.Day, Participants = attachment.Participants.ToList(), State = "已取消" });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Offers.Add(o)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Add(o);`
- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(fields.GetValueOrDefault("Day"), out int day)`；返回值紧邻使用处：`ConditionalExpressionSyntax: int.TryParse(fields.GetValueOrDefault("Day"), out int day) ? day : basis?.Day ?? -1`
- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(fields.GetValueOrDefault("Season"), out int season)`；返回值紧邻使用处：`ConditionalExpressionSyntax: int.TryParse(fields.GetValueOrDefault("Season"), out int season) ? season : basis?.Season ?? -1`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(o.Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(o.Title) || o.Season < 1`

**赋值（含属性/字段和局部值）：**

- `ConsumerAttachmentId` = `basis?.ConsumerAttachmentId ?? ""`
- `Day` = `attachment.Day`
- `Detail` = `attachment.Detail`
- `Detail` = `fields.GetValueOrDefault("Detail", basis?.Detail ?? "")`
- `GoodId` = `basis?.GoodId ?? ""`
- `GoodVerb` = `basis?.GoodVerb ?? ""`
- `Id` = `attachment.Id`
- `Kind` = `"activity"`
- `Participants` = `attachment.Participants.ToList()`
- `Participants` = `basis?.Participants.ToList() ?? [GroupChats.Human(d), c.PersonId]`
- `ReplacesOfferId` = `old?.Id ?? ""`
- `Season` = `attachment.Season`
- `ServiceId` = `basis?.ServiceId ?? ""`
- `State` = `"已取消"`
- `Title` = `attachment.Title`
- `Title` = `fields.GetValueOrDefault("Title", basis?.Title ?? "")`
- `TurnId` = `t.Id`
- `WeddingServiceIds` = `basis?.WeddingServiceIds.ToList() ?? []`
- `action` = `"邀请"`
- `o.Day` = `int.TryParse(fields.GetValueOrDefault("Day"), out int day) ? day : basis?.Day ?? -1`
- `o.Id` = `attachment!.Id`
- `o.Season` = `int.TryParse(fields.GetValueOrDefault("Season"), out int season) ? season : basis?.Season ?? -1`
- `o.State` = `"已确认"`
- `o.State` = `"已过期"`
- `old.State` = `"已取消"`
- `old` = `c.Offers.FirstOrDefault(o => o.Kind == "activity" && o.Id == attachment.Id)`
- `t.Error` += `"\n" + ExpiredDate`
- `t.Error` += `"\n活动需要名称和有效日期。"`
- `t.Error` += `"\n请在活动附件中明确本次处理的活动编号。"`

<a id="symbol-2f0b4ecea199"></a>

## `NationalSpire.SocialAppointments.Confirm(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer) — public static string? Confirm(CareerData d, PrivateConversation c, PrivateOffer o)`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.CommandCore(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-136432a1ec5d)；[`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

**调用：** [`NationalSpire.ConsumerAttachments.Resolve(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`](ConsumerAttachments.cs.md#symbol-f88b230b016a)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`](PrivateInteractionUndo.cs.md#symbol-25f3da26ec8f)；[`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-9eda496612ca)；[`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-9b3600926b30)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.ConsumerAttachments.Resolve(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`；`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.ReplacesOfferId`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.SocialAppointments.ExpiredDate`；`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerAttachments.Resolve(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`；输入表达式：`ConsumerAttachments.Resolve(d, o, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerAttachments.Resolve(d, o, true);`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, o)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, o) < d.Day`
- `NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`；输入表达式：`PrivateInteractionHistory.Capture(d, c.PersonId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: source == null ? null : PrivateInteractionHistory.Capture(d, c.PersonId)`
- `NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；输入表达式：`PrivateInteractionHistory.Record(d, c.PersonId, source, before)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.Record(d, c.PersonId, source, before);`
- `NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.Error(d, o)`；返回值紧邻使用处：`IsPatternExpressionSyntax: WeddingAppointments.Error(d, o) is { } weddingError`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.FirstOrDefault(x => x.Id == o.ReplacesOfferId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: c.Offers.FirstOrDefault(x => x.Id == o.ReplacesOfferId) is { } old`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.FirstOrDefault(t => t.Id == o.TurnId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.FirstOrDefault(t => t.Id == o.TurnId)`

**赋值（含属性/字段和局部值）：**

- `o.State` = `"已确认"`
- `old.State` = `"已改期"`

<a id="symbol-59e09ef2b579"></a>

## `NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool) — public static string? Attend(CareerData d, PrivateOffer o, bool publicly = false, bool scene = false)`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGroupBridge.Begin(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-3f1369ff69ca)；[`NationalSpire.GroupChats.CommandCore(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-136432a1ec5d)；[`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

**调用：** [`NationalSpire.ConsumerAttachments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`](ConsumerAttachments.cs.md#symbol-c0f0a7c39a70)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerEngine.cs.md#symbol-2d5bf22bd5bc)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-47965830082f)；[`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-4cb46102c2e0)；[`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-9b3600926b30)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.ConsumerAttachments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；`NationalSpire.Good.InstantActivity`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GoodVerb`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.PublicAttendance`；`NationalSpire.PrivateOffer.State`；`NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerAttachments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`；输入表达式：`ConsumerAttachments.Attend(d, o, publicly)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerAttachments.Attend(d, o, publicly) is { } paidError`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(o.GoodId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(o.GoodId)?.InstantActivity`
- `NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；输入表达式：`ConsumerEngine.Use(d, o.GoodId, o.GoodVerb, people, publicly)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerEngine.Use(d, o.GoodId, o.GoodVerb, people, publicly) is { } error`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(d, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(d, id)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, o)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, o) != d.Day`
- `NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PublishAttendance(d, o)`；返回值紧邻使用处：`ExpressionStatementSyntax: PublishAttendance(d, o);`
- `NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.Complete(d, o)`；返回值紧邻使用处：`ExpressionStatementSyntax: WeddingAppointments.Complete(d, o);`
- `NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.Error(d, o)`；返回值紧邻使用处：`IsPatternExpressionSyntax: WeddingAppointments.Error(d, o) is { } weddingError`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.IsWedding(o)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !WeddingAppointments.IsWedding(o)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Participants.Where(id => !GroupChats.IsHuman(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct`

**赋值（含属性/字段和局部值）：**

- `o.PublicAttendance` = `publicly`
- `o.State` = `"已赴约"`

<a id="symbol-47965830082f"></a>

## `NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer) — internal static void PublishAttendance(CareerData d, PrivateOffer o)`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool)`](SocialAppointments.cs.md#symbol-59e09ef2b579)；[`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-4cb46102c2e0)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-b0c3ba2ccdb6)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.DisplayName(d, id)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d, GroupChats.Human(d) + "/appointment-" + o.Id, "消费与生活", o.Title + "已完成", $"{CareerEngine.Name(d)}与{string.Join("、", people.Select(id => CareerEngine.DisplayName(d, id)))}参加了{o.Title}。活动内容：{o.Detail}。{WeddingAppointments.Description(d, o)}活动已经完成。", [GroupChats.Human(d), .. people])`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(d, GroupChats.Human(d) + "/appointment-" + o.Id, "消费与生活", o.Title + "已完成", $"{CareerEngine.Name(d)}与{string.Join("、", people.Select(id => CareerEngine.DisplayName(d, id)))}参加了{o.Title}。活动内容：{o.Detail}。{WeddingAppointments.Description(d, o)}活动已经完成。", [GroupChats.Human(d), .. people]);`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Human(d) + "/appointment-"`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`ExpressionElementSyntax: GroupChats.Human(d)`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(d, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(d, id)`
- `NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.Description(d, o)`；返回值紧邻使用处：`InterpolationSyntax: {WeddingAppointments.Description(d, o)}`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`people.Select(id => CareerEngine.DisplayName(d, id))`；返回值紧邻使用处：`ArgumentSyntax: people.Select(id => CareerEngine.DisplayName(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Participants.Where(id => !GroupChats.IsHuman(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", people.Select(id => CareerEngine.DisplayName(d, id)))`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、", people.Select(id => CareerEngine.DisplayName(d, id)))}`

**赋值（含属性/字段和局部值）：**
