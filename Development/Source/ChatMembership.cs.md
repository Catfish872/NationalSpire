# ChatMembership.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`3F73EC3075950CA638797F7129BEAEEF9553416A8A63F50CC409EF1DD3D810A0`。来源：[源码](../../ChatMembership.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GroupDeparture`、`NationalSpire.ChatMembership`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-4024ca4bcdcd"></a>

## `NationalSpire.GroupDeparture.ThroughOrder — public long ThroughOrder`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-aab66143f586"></a>

## `NationalSpire.GroupDeparture.SmallSummaries — public List<PrivateSummary> SmallSummaries`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0d06b2d7fc41"></a>

## `NationalSpire.GroupDeparture.BigSummaries — public List<PrivateSummary> BigSummaries`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8f9049933d9c"></a>

## `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string) — public static bool Knows(GroupChat g, string person)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`](ChatMembership.cs.md#symbol-209a25070cf3)；[`NationalSpire.ChatTimeline.PublicMemories(NationalSpire.CareerData, string, int)`](ChatTimeline.cs.md#symbol-26f194fa1e79)；[`NationalSpire.ChatTimeline.PublicMemoryRequest.For(string, int)`](ChatTimeline.cs.md#symbol-98e994f42924)；[`NationalSpire.ChatTimeline.RelatedGroups(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string)`](ChatTimeline.cs.md#symbol-8b6515c12ceb)；[`NationalSpire.ChatTimeline.Summaries(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-2b6ae7313c3c)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`](GroupChatPrompts.cs.md#symbol-ccc55b5e837d)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupChat.Departures`；`NationalSpire.GroupChat.Forgotten`；`NationalSpire.GroupChat.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`g.Departures.ContainsKey(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Members.Contains(person) || g.Departures.ContainsKey(person)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Members.Contains(person) || g.Departures.ContainsKey(person)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-209a25070cf3"></a>

## `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long) — public static bool Knows(GroupChat g, string person, long order)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatMembership.Readers(NationalSpire.GroupChat, long)`](ChatMembership.cs.md#symbol-a4ae1a8cfedd)；[`NationalSpire.ChatMembership.SummaryKnown(NationalSpire.GroupChat, string, NationalSpire.PrivateSummary)`](ChatMembership.cs.md#symbol-2ba5971064c6)；[`NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-9e2563e0bf97)；[`NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, string, int)`](ChatTimeline.cs.md#symbol-6c6e8fc3c1d7)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`](GroupChatPrompts.cs.md#symbol-ccc55b5e837d)

**调用：** [`NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string)`](ChatMembership.cs.md#symbol-8f9049933d9c)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string)`；`NationalSpire.GroupChat.Departures`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.MemoryStarts`；`NationalSpire.GroupDeparture.ThroughOrder`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string)`；输入表达式：`Knows(g, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: Knows(g, person)         && order >= g.MemoryStarts.GetValueOrDefault(person)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`g.MemoryStarts.GetValueOrDefault(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: order >= g.MemoryStarts.GetValueOrDefault(person)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Members.Contains(person) || order <= g.Departures[person].ThroughOrder`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a4ae1a8cfedd"></a>

## `NationalSpire.ChatMembership.Readers(NationalSpire.GroupChat, long) — public static IEnumerable<string> Readers(GroupChat g, long order)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-9e2563e0bf97)；[`NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, string, int)`](ChatTimeline.cs.md#symbol-6c6e8fc3c1d7)

**调用：** [`NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`](ChatMembership.cs.md#symbol-209a25070cf3)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`；`NationalSpire.GroupChat.Departures`；`NationalSpire.GroupChat.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`；输入表达式：`Knows(g, p, order)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Knows(g, p, order)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`g.Members.Concat(g.Departures.Keys)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Members.Concat(g.Departures.Keys).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`g.Members.Concat(g.Departures.Keys).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Members.Concat(g.Departures.Keys).Distinct().Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Members.Concat(g.Departures.Keys).Distinct().Where(p => Knows(g, p, order))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => g.Members.Concat(g.Departures.Keys).Distinct().Where(p => Knows(g, p, order))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2ba5971064c6"></a>

## `NationalSpire.ChatMembership.SummaryKnown(NationalSpire.GroupChat, string, NationalSpire.PrivateSummary) — public static bool SummaryKnown(GroupChat g, string person, PrivateSummary summary)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatMembership.Summaries(NationalSpire.GroupChat, string, bool)`](ChatMembership.cs.md#symbol-31f40076e0a8)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)

**调用：** [`NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`](ChatMembership.cs.md#symbol-209a25070cf3)

**字段、属性、事件及方法组引用：** `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupTurn.Order`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Through`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`；输入表达式：`Knows(g, person, g.Turns[summary.From].Order)`；返回值紧邻使用处：`BinaryExpressionSyntax: summary.From >= 0 && summary.Through > summary.From         && summary.Through <= g.Turns.Count && Knows(g, person, g.Turns[summary.From].Order)`
- `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`；输入表达式：`Knows(g, person, g.Turns[summary.Through - 1].Order)`；返回值紧邻使用处：`BinaryExpressionSyntax: summary.From >= 0 && summary.Through > summary.From         && summary.Through <= g.Turns.Count && Knows(g, person, g.Turns[summary.From].Order) && Knows(g, person, g.Turns[summary.Through - 1].Order)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-31f40076e0a8"></a>

## `NationalSpire.ChatMembership.Summaries(NationalSpire.GroupChat, string, bool) — public static IEnumerable<PrivateSummary> Summaries(GroupChat g, string person, bool big)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, string, int)`](ChatTimeline.cs.md#symbol-6c6e8fc3c1d7)；[`NationalSpire.ChatTimeline.Summaries(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-2b6ae7313c3c)

**调用：** [`NationalSpire.ChatMembership.SummaryKnown(NationalSpire.GroupChat, string, NationalSpire.PrivateSummary)`](ChatMembership.cs.md#symbol-2ba5971064c6)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatMembership.SummaryKnown(NationalSpire.GroupChat, string, NationalSpire.PrivateSummary)`；`NationalSpire.GroupChat.BigSummaries`；`NationalSpire.GroupChat.Departures`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.SmallSummaries`；`NationalSpire.GroupDeparture.BigSummaries`；`NationalSpire.GroupDeparture.SmallSummaries`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatMembership.SummaryKnown(NationalSpire.GroupChat, string, NationalSpire.PrivateSummary)`；输入表达式：`SummaryKnown(g, person, s)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => SummaryKnown(g, person, s)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`g.Departures.TryGetValue(person, out var departed)`；返回值紧邻使用处：`ConditionalExpressionSyntax: g.Departures.TryGetValue(person, out var departed) ? big ? departed.BigSummaries : departed.SmallSummaries : []`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(g.Members.Contains(person) ? big ? g.BigSummaries : g.SmallSummaries             : g.Departures.TryGetValue(person, out var departed) ? big ? departed.BigSummaries : departed.SmallSummaries : [])         .Where(s => SummaryKnown(g, person, s))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>         (g.Members.Contains(person) ? big ? g.BigSummaries : g.SmallSummaries             : g.Departures.TryGetValue(person, out var departed) ? big ? departed.BigSummaries : departed.SmallSummaries : [])         .Where(s => SummaryKnown(g, person, s))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: g.Members.Contains(person) ? big ? g.BigSummaries : g.SmallSummaries             : g.Departures.TryGetValue(person, out var departed) ? big ? departed.BigSummaries : departed.SmallSummaries : []`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9c321c19150a"></a>

## `NationalSpire.ChatMembership.Private(NationalSpire.CareerData, NationalSpire.PrivateConversation, string) — public static string? Private(CareerData d, PrivateConversation c, string action)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.ChatMembership.Invalidate(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](ChatMembership.cs.md#symbol-2c63c8fb55a6)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatMembership.Invalidate(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.ContextStart`；`NationalSpire.PrivateConversation.Forgotten`；`NationalSpire.PrivateConversation.Hidden`；`NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Proactive`；`NationalSpire.PrivateConversation.SeenCount`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.SummaryError`；`NationalSpire.PrivateConversation.SummaryRequest`；`NationalSpire.PrivateConversation.SummaryStatus`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.LastPerson`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.MemoryDeleted`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.ProactiveChatSettings.Unanswered`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatMembership.Invalidate(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`Invalidate(d, [c.PersonId])`；返回值紧邻使用处：`ExpressionStatementSyntax: Invalidate(d, [c.PersonId]);`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).LastPerson`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`IfStatementSyntax: if (c.Turns.Any(t => t.Status is "queued" or "sending")) return "请结束当前回复后管理会话。";`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`c.BigSummaries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: c.BigSummaries.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`c.SmallSummaries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: c.SmallSummaries.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`c.Turns.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Turns.Clear();`

**赋值（含属性/字段和局部值）：**

- `c.ContextStart` = `0`
- `c.Forgotten` = `true`
- `c.Hidden` = `false`
- `c.Hidden` = `true`
- `c.Proactive.Unanswered` = `0`
- `c.SeenCount` = `0`
- `c.SummaryError` = `c.SummaryRequest = ""`
- `c.SummaryRequest` = `""`
- `c.SummaryStatus` = `c.SummaryError = c.SummaryRequest = ""`
- `offer.MemoryDeleted` = `true`
- `PrivateMessages.Mailbox(d).LastPerson` = `""`

<a id="symbol-7a79d9cbc629"></a>

## `NationalSpire.ChatMembership.Group(NationalSpire.CareerData, NationalSpire.GroupChat, string, string) — public static string? Group(CareerData d, GroupChat g, string action, string person = "")`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)

**调用：** [`NationalSpire.ChatMembership.Invalidate(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](ChatMembership.cs.md#symbol-2c63c8fb55a6)；[`NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`](GroupChats.cs.md#symbol-85bf6e1105fe)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-c362351c7a43)；`NationalSpire.GroupDeparture.GroupDeparture()`；`NationalSpire.GroupEntry.GroupEntry()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Day`；`NationalSpire.ChatMembership.Invalidate(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.ChatWorld.Order`；`NationalSpire.GroupChat.BigSummaries`；`NationalSpire.GroupChat.Departures`；`NationalSpire.GroupChat.Dissolved`；`NationalSpire.GroupChat.Entries`；`NationalSpire.GroupChat.Forgotten`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.MemoryStarts`；`NationalSpire.GroupChat.Revision`；`NationalSpire.GroupChat.SmallSummaries`；`NationalSpire.GroupChat.SummarizedThrough`；`NationalSpire.GroupChat.SummaryError`；`NationalSpire.GroupChat.SummaryStatus`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；`NationalSpire.GroupDeparture.BigSummaries`；`NationalSpire.GroupDeparture.SmallSummaries`；`NationalSpire.GroupDeparture.ThroughOrder`；`NationalSpire.GroupEntry.Author`；`NationalSpire.GroupEntry.Day`；`NationalSpire.GroupEntry.Notice`；`NationalSpire.GroupEntry.Order`；`NationalSpire.GroupEntry.Text`；`NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.Turns`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatMembership.Invalidate(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`Invalidate(d, [person])`；返回值紧邻使用处：`ExpressionStatementSyntax: Invalidate(d, [person]);`
- `NationalSpire.ChatMembership.Invalidate(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`Invalidate(d, g.Members.Concat(g.Departures.Keys).ToArray())`；返回值紧邻使用处：`ExpressionStatementSyntax: Invalidate(d, g.Members.Concat(g.Departures.Keys).ToArray());`
- `NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`；输入表达式：`GroupChats.Busy(g)`；返回值紧邻使用处：`IfStatementSyntax: if (GroupChats.Busy(g)) return "请结束当前回复后管理群聊。";`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(d)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: person == GroupChats.Human(d)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(d, person) + "已离开群聊"`
- `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；输入表达式：`GroupChats.NextOrder(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Order = GroupChats.NextOrder(d)`
- `NationalSpire.GroupDeparture.GroupDeparture()`；输入表达式：`new() { ThroughOrder = d.Chats.Order,                 SmallSummaries = g.SmallSummaries.ToList(), BigSummaries = g.BigSummaries.ToList() }`；返回值紧邻使用处：`AssignmentExpressionSyntax: g.Departures[person] = new() { ThroughOrder = d.Chats.Order,                 SmallSummaries = g.SmallSummaries.ToList(), BigSummaries = g.BigSummaries.ToList() }`
- `NationalSpire.GroupEntry.GroupEntry()`；输入表达式：`new() { Order = GroupChats.NextOrder(d), Day = d.Day, Author = person, Notice = true, Text = GroupChats.Name(d, person) + "已离开群聊" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Order = GroupChats.NextOrder(d), Day = d.Day, Author = person, Notice = true, Text = GroupChats.Name(d, person) + "已离开群聊" }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`g.Departures.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Departures.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`g.Departures.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Departures.Remove(person);`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`g.Members.Concat(g.Departures.Keys)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Members.Concat(g.Departures.Keys).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`g.Members.Concat(g.Departures.Keys).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: g.Members.Concat(g.Departures.Keys).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`g.BigSummaries.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: BigSummaries = g.BigSummaries.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`g.SmallSummaries.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: SmallSummaries = g.SmallSummaries.ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`g.Entries.Add(new() { Order = GroupChats.NextOrder(d), Day = d.Day, Author = person, Notice = true, Text = GroupChats.Name(d, person) + "已离开群聊" })`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Entries.Add(new() { Order = GroupChats.NextOrder(d), Day = d.Day, Author = person, Notice = true, Text = GroupChats.Name(d, person) + "已离开群聊" });`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`g.BigSummaries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: g.BigSummaries.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`g.Entries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Entries.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`g.SmallSummaries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: g.SmallSummaries.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`g.Turns.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Turns.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`lane.BigSummaries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: lane.BigSummaries.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`lane.SmallSummaries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: lane.SmallSummaries.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`lane.Turns.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: lane.Turns.Clear();`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(GroupChats.Human(d))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !g.Members.Contains(GroupChats.Human(d))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !g.Members.Contains(person)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`g.Members.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Members.Remove(person);`

**赋值（含属性/字段和局部值）：**

- `Author` = `person`
- `BigSummaries` = `g.BigSummaries.ToList()`
- `Day` = `d.Day`
- `g.Departures[person]` = `new() { ThroughOrder = d.Chats.Order,                 SmallSummaries = g.SmallSummaries.ToList(), BigSummaries = g.BigSummaries.ToList() }`
- `g.Dissolved` = `false`
- `g.Dissolved` = `true`
- `g.Forgotten` = `true`
- `g.MemoryStarts[person]` = `d.Chats.Order + 1`
- `g.SummarizedThrough` = `0`
- `g.SummaryError` = `g.SummaryStatus = ""`
- `g.SummaryStatus` = `""`
- `Notice` = `true`
- `Order` = `GroupChats.NextOrder(d)`
- `SmallSummaries` = `g.SmallSummaries.ToList()`
- `Text` = `GroupChats.Name(d, person) + "已离开群聊"`
- `ThroughOrder` = `d.Chats.Order`

<a id="symbol-2c63c8fb55a6"></a>

## `NationalSpire.ChatMembership.Invalidate(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>) — private static void Invalidate(CareerData d, IEnumerable<string> people)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatMembership.Group(NationalSpire.CareerData, NationalSpire.GroupChat, string, string)`](ChatMembership.cs.md#symbol-7a79d9cbc629)；[`NationalSpire.ChatMembership.Private(NationalSpire.CareerData, NationalSpire.PrivateConversation, string)`](ChatMembership.cs.md#symbol-9c321c19150a)

**调用：** [`NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData)`](ChatTimeline.cs.md#symbol-4c52c52dffbc)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.ContextStart`；`NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateTurn.Context`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData)`；输入表达式：`ChatTimeline.Mailboxes(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatTimeline.Mailboxes(d).Select`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ids.Contains(c.PersonId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => ids.Contains(c.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ChatTimeline.Mailboxes(d).Select(x => x.Value)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var box in ChatTimeline.Mailboxes(d).Select(x => x.Value))             foreach (var c in box.Conversations.Values.Where(c => ids.Contains(c.PersonId)))             {                 foreach (var turn in c.Turns) turn.Context = "";                 c.SmallSummaries.Clear(); c.BigSummaries.Clear(); c.ContextStart = 0; c.MemoryRevision++;             }`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`people.ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = people.ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`box.Conversations.Values.Where(c => ids.Contains(c.PersonId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in box.Conversations.Values.Where(c => ids.Contains(c.PersonId)))             {                 foreach (var turn in c.Turns) turn.Context = "";                 c.SmallSummaries.Clear(); c.BigSummaries.Clear(); c.ContextStart = 0; c.MemoryRevision++;             }`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`c.BigSummaries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: c.BigSummaries.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`c.SmallSummaries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: c.SmallSummaries.Clear();`

**赋值（含属性/字段和局部值）：**

- `c.ContextStart` = `0`
- `turn.Context` = `""`
