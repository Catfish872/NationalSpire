# SocialAppointments.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F1F0003B15CDC09DF1C6F90BE9D5A3B601EFBC61F61C0BEACE49FB054B2F5BDD`。来源：[源码](../../SocialAppointments.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.SocialAppointments`。

字段、事件及初始值（源码原样）：

```csharp
public const string ExpiredDate = "填写的邀约日期已过期，请重新约定日期";
public const string Protocol = """
玩家主动提出或暗示活动意愿时，才可商谈活动，名称与内容按双方交流自定。只有下列标记生成待确认约定，口头答应不产生记录；玩家确认后记入日程。
[Activity: 邀请, Title: 一起看录像, Season: 2, Day: 18, Detail: 讨论今天的比赛]
修改已有约定使用 [Activity: 改期, Id: 14, Season: 2, Day: 19]，取消使用 [Activity: 取消, Id: 14]，Id 填对应活动的编号。活动不等同比赛，不自行承诺资金或能力奖励。
""";
```

<a id="symbol-56b98eeeac09"></a>

## `NationalSpire.SocialAppointments.StatusText(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string StatusText(CareerData d, PrivateOffer o)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`](GroupChatPrompts.cs.md#symbol-ccc55b5e837d)；[`NationalSpire.PrivateMessagePrompts.OfferContext(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessagePrompts.cs.md#symbol-67bd27e9ea35)

**调用：** [`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.State`；`NationalSpire.SocialAppointments.ExpiredDate`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, o)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, o) < d.Day`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0596ed8dd544"></a>

## `NationalSpire.SocialAppointments.All(NationalSpire.CareerData) — public static IEnumerable<(PrivateConversation Conversation, PrivateOffer Offer)> All(CareerData d)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`](PrivateAppointments.cs.md#symbol-8d91a4d33a55)；[`NationalSpire.SocialAppointments.Due(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-d348017d127b)；[`NationalSpire.SocialAppointments.Expire(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-53508b4eaa4e)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Human(d) + "/"`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(d).SelectMany`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations`
- `string.StartsWith(string)`；输入表达式：`x.Key.StartsWith(GroupChats.Human(d) + "/")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x => x.Key.StartsWith(GroupChats.Human(d) + "/")`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Values.Concat(GroupChats.Visible(d).SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations.Values.Concat(GroupChats.Visible(d).SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Offers.Where(o => o.Kind == "activity").Select(o => (c, o))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Offers.Where(o => o.Kind == "activity").Select(o => (c, o))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`GroupChats.Visible(d).SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Visible(d).SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Values.Concat(GroupChats.Visible(d).SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))).SelectMany(c => c.Offers.Where(o => o.Kind == "activity").Select(o => (c, o)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateMessages.Mailbox(d).Conversations.Values.Concat(GroupChats.Visible(d).SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))).SelectMany(c => c.Offers.Where(o => o.Kind == "activity").Select(o => (c, o)))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Where(o => o.Kind == "activity")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Offers.Where(o => o.Kind == "activity").Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d348017d127b"></a>

## `NationalSpire.SocialAppointments.Due(NationalSpire.CareerData) — public static IEnumerable<(PrivateConversation Conversation, PrivateOffer Offer)> Due(CareerData d)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int)`](CareerEngine.cs.md#symbol-e733e6d47318)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.Coop.CoopRules.ExecuteProposal(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-fecbe30f550e)

**调用：** [`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-0596ed8dd544)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(NationalSpire.PrivateConversation Conversation, NationalSpire.PrivateOffer Offer).Offer`；`NationalSpire.CareerData.Day`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.State`；`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, x.Offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, x.Offer) == d.Day`
- `NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`；输入表达式：`All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(d).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`All(d).Where(x => x.Offer.State == "已确认" && PrivateAppointments.Date(d, x.Offer) == d.Day)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => All(d).Where(x => x.Offer.State == "已确认" && PrivateAppointments.Date(d, x.Offer) == d.Day)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-53508b4eaa4e"></a>

## `NationalSpire.SocialAppointments.Expire(NationalSpire.CareerData) — public static void Expire(CareerData d)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** [`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`](PrivateMessageData.cs.md#symbol-2a4d65cc20f8)；[`NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`](PrivateMessageData.cs.md#symbol-ad3e5a4298ba)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；`int.TryParse(string?, out int)`；`NationalSpire.PrivateOffer.PrivateOffer()`；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.ReplacesOfferId`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SocialAppointments.ExpiredDate`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(fields.GetValueOrDefault("Day"), out int day)`；返回值紧邻使用处：`ConditionalExpressionSyntax: int.TryParse(fields.GetValueOrDefault("Day"), out int day) ? day : -1`
- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(fields.GetValueOrDefault("Season"), out int season)`；返回值紧邻使用处：`ConditionalExpressionSyntax: int.TryParse(fields.GetValueOrDefault("Season"), out int season) ? season : -1`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, o)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, o) < d.Day`
- `NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；输入表达式：`PrivateInteractionIds.Ensure(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionIds.Ensure(c);`
- `NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`；输入表达式：`PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id"))`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id"))`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = "activity", TurnId = t.Id, Title = fields.GetValueOrDefault("Title", old?.Title ?? ""),              Detail = fields.GetValueOrDefault("Detail", old?.Detail ?? ""), ReplacesOfferId = old?.Id ?? "" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = "activity", TurnId = t.Id, Title = fields.GetValueOrDefault("Title", old?.Title ?? ""),              Detail = fields.GetValueOrDefault("Detail", old?.Detail ?? ""), ReplacesOfferId = old?.Id ?? "" }`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d, o.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Day > SeasonCalendar.Length(d, o.Season)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(o.Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(o.Title) || o.Season < 1`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.FirstOrDefault(o => o.Kind == "activity" && o.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Offers.FirstOrDefault(o => o.Kind == "activity" && o.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Activity", "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fields.GetValueOrDefault("Activity", "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Detail", old?.Detail ?? "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Detail = fields.GetValueOrDefault("Detail", old?.Detail ?? "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Title", old?.Title ?? "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Title = fields.GetValueOrDefault("Title", old?.Title ?? "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Day")`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault("Day")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Id")`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault("Id")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Season")`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault("Season")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Offers.Add(o)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Add(o);`

**赋值（含属性/字段和局部值）：**

- `Detail` = `fields.GetValueOrDefault("Detail", old?.Detail ?? "")`
- `Kind` = `"activity"`
- `o.Day` = `int.TryParse(fields.GetValueOrDefault("Day"), out int day) ? day : -1`
- `o.Season` = `int.TryParse(fields.GetValueOrDefault("Season"), out int season) ? season : -1`
- `o.State` = `"已过期"`
- `old.State` = `"已取消"`
- `ReplacesOfferId` = `old?.Id ?? ""`
- `t.Error` += `"\n" + ExpiredDate`
- `t.Error` += `"\n活动编号或动作无效。"`
- `t.Error` += `"\n活动需要名称和有效日期。"`
- `Title` = `fields.GetValueOrDefault("Title", old?.Title ?? "")`
- `TurnId` = `t.Id`

<a id="symbol-2f0b4ecea199"></a>

## `NationalSpire.SocialAppointments.Confirm(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer) — public static string? Confirm(CareerData d, PrivateConversation c, PrivateOffer o)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-9eda496612ca)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.ReplacesOfferId`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.SocialAppointments.ExpiredDate`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, o)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, o) < d.Day`
- `NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；输入表达式：`PrivateInteractionHistory.Capture(d, c.PersonId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: source == null ? null : PrivateInteractionHistory.Capture(d, c.PersonId)`
- `NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；输入表达式：`PrivateInteractionHistory.Record(d, c.PersonId, source, before)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.Record(d, c.PersonId, source, before);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.FirstOrDefault(x => x.Id == o.ReplacesOfferId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: c.Offers.FirstOrDefault(x => x.Id == o.ReplacesOfferId) is { } old`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.FirstOrDefault(t => t.Id == o.TurnId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.FirstOrDefault(t => t.Id == o.TurnId)`

**赋值（含属性/字段和局部值）：**

- `o.State` = `"已确认"`
- `old.State` = `"已改期"`

<a id="symbol-4dbc4f79108f"></a>

## `NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string? Attend(CareerData d, PrivateOffer o)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, o)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, o) != d.Day`

**赋值（含属性/字段和局部值）：**

- `o.State` = `"已赴约"`
