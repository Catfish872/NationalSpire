# ChatTimeline.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9C26E49EEE2282BC41D894CEDD1AEA0B44EC7F0E7F43A5DE8F43B146CCDFDAB0`。来源：[源码](../../ChatTimeline.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ChatTimeline`、`NationalSpire.ChatTimeline.Item`、`NationalSpire.ChatTimeline.PublicMemoryRequest`。

字段、事件及初始值（源码原样）：

```csharp
public const string Privacy = "历史中穿插的外部会话记录，表示交流在相应位置发生于其他私信或群聊，不表示内容曾发送到当前会话。只有标注的知情人物知道其中内容；其他人物依据知情人在当前会话实际说出的内容回应。来源摘要中的我、你按照标注的作者和对象理解。";
public const string PrivateHistoryNote = "聊天记录中可能穿插有外部会话记录，表示这段交流记录在对应时间发生于其他群聊。";
private readonly Dictionary<(string Group, int Day), object> _records = [];
```

<a id="symbol-8b6515c12ceb"></a>

## `NationalSpire.ChatTimeline.RelatedGroups(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string) — public static IEnumerable<GroupChat> RelatedGroups(CareerData d, IEnumerable<string> people, string excludeGroup = "")`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-9e2563e0bf97)；[`NationalSpire.ChatTimeline.Summaries(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-2b6ae7313c3c)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)

**调用：** [`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(d, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(d, id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Members.Any(members.Contains)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Id != excludeGroup && g.Members.Any(members.Contains)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`people.Where(id => !GroupChats.IsHuman(d, id)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = people.Where(id => !GroupChats.IsHuman(d, id)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Chats.Groups.Where(g => g.Id != excludeGroup && g.Members.Any(members.Contains))`；返回值紧邻使用处：`ReturnStatementSyntax: return d.Chats.Groups.Where(g => g.Id != excludeGroup && g.Members.Any(members.Contains));`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Where(id => !GroupChats.IsHuman(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Where(id => !GroupChats.IsHuman(d, id)).ToHashSet`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9e2563e0bf97"></a>

## `NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string) — public static IEnumerable<Item> External(CareerData d, IEnumerable<string> people, string excludeGroup = "", string excludePrivate = "")`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.PrivateHistory(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?)`](ChatTimeline.cs.md#symbol-4c7ee0ce6871)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)

**调用：** `NationalSpire.ChatTimeline.Item.Item(long, int, string, string, string)`；[`NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData)`](ChatTimeline.cs.md#symbol-4c52c52dffbc)；[`NationalSpire.ChatTimeline.RelatedGroups(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string)`](ChatTimeline.cs.md#symbol-8b6515c12ceb)；[`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`](GroupChatPrompts.cs.md#symbol-28b2a2534bee)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`](PrivateMessagePrompts.cs.md#symbol-a6aa8a8392b1)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData)`；`NationalSpire.ChatTimeline.RelatedGroups(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string)`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupEntry.Author`；`NationalSpire.GroupEntry.Day`；`NationalSpire.GroupEntry.Order`；`NationalSpire.GroupEntry.Text`；`NationalSpire.GroupTurn.Attachments`；`NationalSpire.GroupTurn.Day`；`NationalSpire.GroupTurn.Order`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.Sender`；`NationalSpire.GroupTurn.Status`；`NationalSpire.GroupTurn.Text`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.ReplyOrder`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.UserDeleted`；`NationalSpire.PrivateTurn.UserOrder`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTimeline.Item.Item(long, int, string, string, string)`；输入表达式：`new(r.Order, r.Day, "user", GroupChats.Name(d, r.Author) + "：" + r.Text, source)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(r.Order, r.Day, "user", GroupChats.Name(d, r.Author) + "：" + r.Text, source);`
- `NationalSpire.ChatTimeline.Item.Item(long, int, string, string, string)`；输入表达式：`new(t.Order, t.Day, "user", GroupChats.Name(d, t.Sender) + "：" + GroupChatPrompts.UserText(d, g, t), source)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(t.Order, t.Day, "user", GroupChats.Name(d, t.Sender) + "：" + GroupChatPrompts.UserText(d, g, t), source);`
- `NationalSpire.ChatTimeline.Item.Item(long, int, string, string, string)`；输入表达式：`new(t.ReplyOrder, t.Day, "user", GroupChats.Name(d, c.PersonId) + "：" + t.Reply, source)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(t.ReplyOrder, t.Day, "user", GroupChats.Name(d, c.PersonId) + "：" + t.Reply, source);`
- `NationalSpire.ChatTimeline.Item.Item(long, int, string, string, string)`；输入表达式：`new(t.UserOrder, t.Day, "user", GroupChats.Name(d, human) + "：" + PrivateMessagePrompts.UserText(t, c), source)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(t.UserOrder, t.Day, "user", GroupChats.Name(d, human) + "：" + PrivateMessagePrompts.UserText(t, c), source);`
- `NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData)`；输入表达式：`Mailboxes(d)`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (human, box) in Mailboxes(d)) { foreach (var c in box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d)))) { string source = $"私信：{GroupChats.Name(d, human)}与{GroupChats.Name(d, c.PersonId)}；知情人：{GroupChats.Name(d, human)}、{GroupChats.Name(d, c.PersonId)}"; foreach (var t in c.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast(5)) { if (!t.UserDeleted) yield return new(t.UserOrder, t.Day, "user", GroupChats.Name(d, human) + "：" + PrivateMessagePrompts.UserText(t, c), source); if (!t.ReplyDeleted) yield return new(t.ReplyOrder, t.Day, "user", GroupChats.Name(d, c.PersonId) + "：" + t.Reply, source); } } }`
- `NationalSpire.ChatTimeline.RelatedGroups(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string)`；输入表达式：`RelatedGroups(d, members, excludeGroup)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var g in RelatedGroups(d, members, excludeGroup)) { string source = $"群聊《{g.Name}》；知情人：{string.Join("、", g.Members.Select(id => GroupChats.Name(d, id)))}"; foreach (var t in g.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast(5)) { if (t.Text.Length > 0 || t.Attachments.Count > 0) yield return new(t.Order, t.Day, "user", GroupChats.Name(d, t.Sender) + "：" + GroupChatPrompts.UserText(d, g, t), source); foreach (var r in t.Replies) yield return new(r.Order, r.Day, "user", GroupChats.Name(d, r.Author) + "：" + r.Text, source); } }`
- `NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`；输入表达式：`GroupChatPrompts.UserText(d, g, t)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(d, t.Sender) + "：" + GroupChatPrompts.UserText(d, g, t)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: human != GroupChats.Human(d)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, c.PersonId)`；返回值紧邻使用处：`InterpolationSyntax: {GroupChats.Name(d, c.PersonId)}`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, c.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(d, c.PersonId) + "："`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, human)`；返回值紧邻使用处：`InterpolationSyntax: {GroupChats.Name(d, human)}`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, human)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(d, human) + "："`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(d, id)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, r.Author)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(d, r.Author) + "："`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, t.Sender)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(d, t.Sender) + "："`
- `NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`；输入表达式：`PrivateMessagePrompts.UserText(t, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(d, human) + "：" + PrivateMessagePrompts.UserText(t, c)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`members.Contains(c.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Members.Select(id => GroupChats.Name(d, id))`；返回值紧邻使用处：`ArgumentSyntax: g.Members.Select(id => GroupChats.Name(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`c.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast(5)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var t in c.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast(5)) { if (!t.UserDeleted) yield return new(t.UserOrder, t.Day, "user", GroupChats.Name(d, human) + "：" + PrivateMessagePrompts.UserText(t, c), source); if (!t.ReplyDeleted) yield return new(t.ReplyOrder, t.Day, "user", GroupChats.Name(d, c.PersonId) + "：" + t.Reply, source); }`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`g.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast(5)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var t in g.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast(5)) { if (t.Text.Length > 0 || t.Attachments.Count > 0) yield return new(t.Order, t.Day, "user", GroupChats.Name(d, t.Sender) + "：" + GroupChatPrompts.UserText(d, g, t), source); foreach (var r in t.Replies) yield return new(r.Order, r.Day, "user", GroupChats.Name(d, r.Author) + "：" + r.Text, source); }`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`people.ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = people.ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d)))) { string source = $"私信：{GroupChats.Name(d, human)}与{GroupChats.Name(d, c.PersonId)}；知情人：{GroupChats.Name(d, human)}、{GroupChats.Name(d, c.PersonId)}"; foreach (var t in c.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast(5)) { if (!t.UserDeleted) yield return new(t.UserOrder, t.Day, "user", GroupChats.Name(d, human) + "：" + PrivateMessagePrompts.UserText(t, c), source); if (!t.ReplyDeleted) yield return new(t.ReplyOrder, t.Day, "user", GroupChats.Name(d, c.PersonId) + "：" + t.Reply, source); } }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", g.Members.Select(id => GroupChats.Name(d, id)))`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、", g.Members.Select(id => GroupChats.Name(d, id)))}`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4c52c52dffbc"></a>

## `NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData) — public static IEnumerable<KeyValuePair<string, PrivateMailbox>> Mailboxes(CareerData d)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-9e2563e0bf97)；[`NationalSpire.ChatTimeline.Summaries(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-2b6ae7313c3c)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.KeyValuePair.Create<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(d)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`d.PrivateMemorySources.Concat(new[] { KeyValuePair.Create(GroupChats.Human(d), d.Life.Mailbox) })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.PrivateMemorySources.Concat(new[] { KeyValuePair.Create(GroupChats.Human(d), d.Life.Mailbox) }).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.PrivateMemorySources.Concat(new[] { KeyValuePair.Create(GroupChats.Human(d), d.Life.Mailbox) }).DistinctBy(p => p.Key)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.PrivateMemorySources.Concat(new[] { KeyValuePair.Create(GroupChats.Human(d), d.Life.Mailbox) }).DistinctBy(p => p.Key)`
- `System.Collections.Generic.KeyValuePair.Create<TKey, TValue>(TKey, TValue)`；输入表达式：`KeyValuePair.Create(GroupChats.Human(d), d.Life.Mailbox)`；返回值紧邻使用处：`InitializerExpressionSyntax: { KeyValuePair.Create(GroupChats.Human(d), d.Life.Mailbox) }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2b6ae7313c3c"></a>

## `NationalSpire.ChatTimeline.Summaries(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string) — public static string Summaries(CareerData d, IEnumerable<string> people, string excludeGroup = "", string excludePrivate = "")`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?, bool)`](PrivateMessagePrompts.cs.md#symbol-e8c8e5f35407)

**调用：** [`Add(string, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`](ChatTimeline.cs.md#symbol-2096e77594ab)；[`NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData)`](ChatTimeline.cs.md#symbol-4c52c52dffbc)；[`NationalSpire.ChatTimeline.RelatedGroups(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string)`](ChatTimeline.cs.md#symbol-8b6515c12ceb)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `Add(string, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；`NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData)`；`NationalSpire.ChatTimeline.RelatedGroups(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string)`；`NationalSpire.GroupChat.BigSummaries`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChat.SmallSummaries`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateMailbox.Conversations`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(string, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；输入表达式：`Add($"群聊《{g.Name}》；知情人：{string.Join("、", g.Members.Select(id => GroupChats.Name(d, id)))}。", g.BigSummaries, g.SmallSummaries)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add($"群聊《{g.Name}》；知情人：{string.Join("、", g.Members.Select(id => GroupChats.Name(d, id)))}。", g.BigSummaries, g.SmallSummaries);`
- `Add(string, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；输入表达式：`Add($"私信知情人：{GroupChats.Name(d, human)}、{GroupChats.Name(d, c.PersonId)}。第一人称总结作者：{GroupChats.Name(d, c.PersonId)}，对象：{GroupChats.Name(d, human)}。", c.BigSummaries, c.SmallSummaries)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add($"私信知情人：{GroupChats.Name(d, human)}、{GroupChats.Name(d, c.PersonId)}。第一人称总结作者：{GroupChats.Name(d, c.PersonId)}，对象：{GroupChats.Name(d, human)}。", c.BigSummaries, c.SmallSummaries);`
- `NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData)`；输入表达式：`Mailboxes(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Mailboxes(d).OrderBy`
- `NationalSpire.ChatTimeline.RelatedGroups(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string)`；输入表达式：`RelatedGroups(d, members, excludeGroup)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: RelatedGroups(d, members, excludeGroup).OrderBy`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: human != GroupChats.Human(d)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, c.PersonId)`；返回值紧邻使用处：`InterpolationSyntax: {GroupChats.Name(d, c.PersonId)}`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, human)`；返回值紧邻使用处：`InterpolationSyntax: {GroupChats.Name(d, human)}`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(d, id)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", g.Members.Select(id => GroupChats.Name(d, id)))`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、", g.Members.Select(id => GroupChats.Name(d, id)))}`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`members.Contains(c.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d))`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d))).OrderBy(c => c.PersonId, StringComparer.Ordinal)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d))).OrderBy(c => c.PersonId, StringComparer.Ordinal))                  Add($"私信知情人：{GroupChats.Name(d, human)}、{GroupChats.Name(d, c.PersonId)}。第一人称总结作者：{GroupChats.Name(d, c.PersonId)}，对象：{GroupChats.Name(d, human)}。", c.BigSummaries, c.SmallSummaries);`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`Mailboxes(d).OrderBy(x => x.Key, StringComparer.Ordinal)`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (human, box) in Mailboxes(d).OrderBy(x => x.Key, StringComparer.Ordinal))              foreach (var c in box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d))).OrderBy(c => c.PersonId, StringComparer.Ordinal))                  Add($"私信知情人：{GroupChats.Name(d, human)}、{GroupChats.Name(d, c.PersonId)}。第一人称总结作者：{GroupChats.Name(d, c.PersonId)}，对象：{GroupChats.Name(d, human)}。", c.BigSummaries, c.SmallSummaries);`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`RelatedGroups(d, members, excludeGroup).OrderBy(g => g.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var g in RelatedGroups(d, members, excludeGroup).OrderBy(g => g.Id, StringComparer.Ordinal))              Add($"群聊《{g.Name}》；知情人：{string.Join("、", g.Members.Select(id => GroupChats.Name(d, id)))}。", g.BigSummaries, g.SmallSummaries);`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Members.Select(id => GroupChats.Name(d, id))`；返回值紧邻使用处：`ArgumentSyntax: g.Members.Select(id => GroupChats.Name(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`people.ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = people.ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d))).OrderBy`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`b.ToString()`；返回值紧邻使用处：`ReturnStatementSyntax: return b.ToString();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2096e77594ab"></a>

## `Add(string, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>) — void Add(string source, IEnumerable<PrivateSummary> big, IEnumerable<PrivateSummary> small)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.Summaries(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-2b6ae7313c3c)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Text.StringBuilder.AppendLine(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateSummary.Through`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`big.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = big.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`small.LastOrDefault(s => s.Through > (large?.Through ?? 0))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = small.LastOrDefault(s => s.Through > (large?.Through ?? 0))`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine("</private_memory>")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine("</private_memory>");`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine("<private_memory>").AppendLine(source)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine("<private_memory>").AppendLine(source);`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine("<private_memory>")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: b.AppendLine("<private_memory>").AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine($"近期总结（第{recent.From + 1}至{recent.Through}轮）：" + recent.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"近期总结（第{recent.From + 1}至{recent.Through}轮）：" + recent.Text);`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine($"长期总结（第{large.From + 1}至{large.Through}轮）：" + large.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"长期总结（第{large.From + 1}至{large.Through}轮）：" + large.Text);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-127674c9926b"></a>

## `NationalSpire.ChatTimeline.Text(NationalSpire.CareerData, NationalSpire.ChatTimeline.Item) — public static string Text(CareerData d, Item item)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?, bool)`](PrivateMessagePrompts.cs.md#symbol-e8c8e5f35407)

**调用：** [`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTimeline.Item.Day`；`NationalSpire.ChatTimeline.Item.Order`；`NationalSpire.ChatTimeline.Item.Source`；`NationalSpire.ChatTimeline.Item.Text`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, item.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: "<private_memory>\n" + item.Source + "\n" + PrivateAppointments.DateText(d, item.Day)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4c7ee0ce6871"></a>

## `NationalSpire.ChatTimeline.PrivateHistory(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?) — public static IEnumerable<Item> PrivateHistory(CareerData d, PrivateConversation c, PrivateTurn? pending)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?, bool)`](PrivateMessagePrompts.cs.md#symbol-e8c8e5f35407)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-9e2563e0bf97)；`NationalSpire.ChatTimeline.Item.Item(long, int, string, string, string)`；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`](PrivateMessagePrompts.cs.md#symbol-a6aa8a8392b1)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<long>.Min()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`；`NationalSpire.ChatTimeline.Item.Day`；`NationalSpire.ChatTimeline.Item.Order`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.PrivateConversation.ContextStart`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateHistorySettings.RecentRounds`；`NationalSpire.PrivateMailbox.Settings`；`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.ReplyOrder`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Season`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.UserDeleted`；`NationalSpire.PrivateTurn.UserOrder`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`；输入表达式：`External(d, [c.PersonId], excludePrivate: c.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: External(d, [c.PersonId], excludePrivate: c.PersonId) .Where`
- `NationalSpire.ChatTimeline.Item.Item(long, int, string, string, string)`；输入表达式：`new(t.ReplyOrder, t.Day, "assistant", t.Reply)`；返回值紧邻使用处：`ArgumentSyntax: new(t.ReplyOrder, t.Day, "assistant", t.Reply)`
- `NationalSpire.ChatTimeline.Item.Item(long, int, string, string, string)`；输入表达式：`new(t.UserOrder, t.Day, "user", $"第 {t.Season} 赛季第 {SeasonCalendar.Day(d, t.Day)} 天，{CareerEngine.Name(d)}" + (t.RequestKind == "arbitration" ? "提交给官方的仲裁申请\n" : $"发给{GroupChats.Name(d, c.PersonId)}的消息\n") + PrivateMessagePrompts.UserText(t, c))`；返回值紧邻使用处：`ArgumentSyntax: new(t.UserOrder, t.Day, "user", $"第 {t.Season} 赛季第 {SeasonCalendar.Day(d, t.Day)} 天，{CareerEngine.Name(d)}" + (t.RequestKind == "arbitration" ? "提交给官方的仲裁申请\n" : $"发给{GroupChats.Name(d, c.PersonId)}的消息\n") + PrivateMessagePrompts.UserText(t, c))`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, c.PersonId)`；返回值紧邻使用处：`InterpolationSyntax: {GroupChats.Name(d, c.PersonId)}`
- `NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`；输入表达式：`PrivateMessagePrompts.UserText(t, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: $"第 {t.Season} 赛季第 {SeasonCalendar.Day(d, t.Day)} 天，{CareerEngine.Name(d)}" + (t.RequestKind == "arbitration" ? "提交给官方的仲裁申请\n" : $"发给{GroupChats.Name(d, c.PersonId)}的消息\n") + PrivateMessagePrompts.UserText(t, c)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Settings`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(d, t.Day)`；返回值紧邻使用处：`InterpolationSyntax: {SeasonCalendar.Day(d, t.Day)}`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`own.Concat(External(d, [c.PersonId], excludePrivate: c.PersonId) .Where(x => x.Order >= start && (pending == null || pending.UserOrder == 0 || x.Order < pending.UserOrder)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: own.Concat(External(d, [c.PersonId], excludePrivate: c.PersonId) .Where(x => x.Order >= start && (pending == null || pending.UserOrder == 0 || x.Order < pending.UserOrder))) .OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`recent.TakeLast(Math.Max(1, retained)).Select(t => t.UserOrder).DefaultIfEmpty(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.TakeLast(Math.Max(1, retained)).Select(t => t.UserOrder).DefaultIfEmpty(0).Min`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`own.Concat(External(d, [c.PersonId], excludePrivate: c.PersonId) .Where(x => x.Order >= start && (pending == null || pending.UserOrder == 0 || x.Order < pending.UserOrder))) .OrderBy(x => x.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: own.Concat(External(d, [c.PersonId], excludePrivate: c.PersonId) .Where(x => x.Order >= start && (pending == null || pending.UserOrder == 0 || x.Order < pending.UserOrder))) .OrderBy(x => x.Day).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`recent.TakeLast(Math.Max(1, retained)).Select(t => t.UserOrder)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.TakeLast(Math.Max(1, retained)).Select(t => t.UserOrder).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`c.Turns.Skip(c.ContextStart)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Skip(c.ContextStart).Where`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`recent.TakeLast(Math.Max(1, retained))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.TakeLast(Math.Max(1, retained)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`c.Turns.Where(t => t.Status == "complete").ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.Where(t => t.Status == "complete").ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`External(d, [c.PersonId], excludePrivate: c.PersonId) .Where(x => x.Order >= start && (pending == null || pending.UserOrder == 0 || x.Order < pending.UserOrder))`；返回值紧邻使用处：`ArgumentSyntax: External(d, [c.PersonId], excludePrivate: c.PersonId) .Where(x => x.Order >= start && (pending == null || pending.UserOrder == 0 || x.Order < pending.UserOrder))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Skip(c.ContextStart).Where(t => t.Status == "complete" && t != pending)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var t in c.Turns.Skip(c.ContextStart).Where(t => t.Status == "complete" && t != pending)) { if (!t.UserDeleted) own.Add(new(t.UserOrder, t.Day, "user", $"第 {t.Season} 赛季第 {SeasonCalendar.Day(d, t.Day)} 天，{CareerEngine.Name(d)}" + (t.RequestKind == "arbitration" ? "提交给官方的仲裁申请\n" : $"发给{GroupChats.Name(d, c.PersonId)}的消息\n") + PrivateMessagePrompts.UserText(t, c))); if (!t.ReplyDeleted) own.Add(new(t.ReplyOrder, t.Day, "assistant", t.Reply)); }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Where(t => t.Status == "complete")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Where(t => t.Status == "complete").ToArray`
- `System.Collections.Generic.IEnumerable<long>.Min()`；输入表达式：`recent.TakeLast(Math.Max(1, retained)).Select(t => t.UserOrder).DefaultIfEmpty(0).Min()`；返回值紧邻使用处：`ConditionalExpressionSyntax: recent.Length > retained ? recent.TakeLast(Math.Max(1, retained)).Select(t => t.UserOrder).DefaultIfEmpty(0).Min() : 0`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`own.Add(new(t.ReplyOrder, t.Day, "assistant", t.Reply))`；返回值紧邻使用处：`ExpressionStatementSyntax: own.Add(new(t.ReplyOrder, t.Day, "assistant", t.Reply));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`own.Add(new(t.UserOrder, t.Day, "user", $"第 {t.Season} 赛季第 {SeasonCalendar.Day(d, t.Day)} 天，{CareerEngine.Name(d)}" + (t.RequestKind == "arbitration" ? "提交给官方的仲裁申请\n" : $"发给{GroupChats.Name(d, c.PersonId)}的消息\n") + PrivateMessagePrompts.UserText(t, c)))`；返回值紧邻使用处：`ExpressionStatementSyntax: own.Add(new(t.UserOrder, t.Day, "user", $"第 {t.Season} 赛季第 {SeasonCalendar.Day(d, t.Day)} 天，{CareerEngine.Name(d)}" + (t.RequestKind == "arbitration" ? "提交给官方的仲裁申请\n" : $"发给{GroupChats.Name(d, c.PersonId)}的消息\n") + PrivateMessagePrompts.UserText(t, c)));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Item>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Item>()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`own.Concat(External(d, [c.PersonId], excludePrivate: c.PersonId) .Where(x => x.Order >= start && (pending == null || pending.UserOrder == 0 || x.Order < pending.UserOrder))) .OrderBy(x => x.Day).ThenBy(x => x.Order)`；返回值紧邻使用处：`ReturnStatementSyntax: return own.Concat(External(d, [c.PersonId], excludePrivate: c.PersonId) .Where(x => x.Order >= start && (pending == null || pending.UserOrder == 0 || x.Order < pending.UserOrder))) .OrderBy(x => x.Day).ThenBy(x => x.Order);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, retained)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, retained)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-26f194fa1e79"></a>

## `NationalSpire.ChatTimeline.PublicMemories(NationalSpire.CareerData, string, int) — public static object[] PublicMemories(CareerData d, string person, int day)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?, NationalSpire.ChatTimeline.PublicMemoryRequest?)`](AiDiscussion.cs.md#symbol-7fe54dbd182e)

**调用：** [`NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, int)`](ChatTimeline.cs.md#symbol-ecb3c5ed00bc)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, int)`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, int)`；输入表达式：`PublicMemory(d, g, day)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => PublicMemory(d, g, day)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Chats.Groups.Where(g => g.Members.Contains(person)).Select(g => PublicMemory(d, g, day))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Chats.Groups.Where(g => g.Members.Contains(person)).Select(g => PublicMemory(d, g, day)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.Chats.Groups.Where(g => g.Members.Contains(person)).Select(g => PublicMemory(d, g, day)).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Chats.Groups.Where(g => g.Members.Contains(person)).Select(g => PublicMemory(d, g, day)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Chats.Groups.Where(g => g.Members.Contains(person))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Chats.Groups.Where(g => g.Members.Contains(person)).Select`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(person)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Members.Contains(person)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ecb3c5ed00bc"></a>

## `NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, int) — private static object PublicMemory(CareerData d, GroupChat g, int day)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.PublicMemories(NationalSpire.CareerData, string, int)`](ChatTimeline.cs.md#symbol-26f194fa1e79)；[`NationalSpire.ChatTimeline.PublicMemoryRequest.For(string, int)`](ChatTimeline.cs.md#symbol-98e994f42924)

**调用：** [`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `<anonymous type: string 群聊, string 说明, string[] 知情人, string 大总结, string 小总结, <anonymous type: string 日期, System.Collections.Generic.IEnumerable<<anonymous type: string 人物, string 内容>> 发言, string 玩家姓名, string 玩家消息>[] 最近记录>.大总结`；`<anonymous type: string 群聊, string 说明, string[] 知情人, string 大总结, string 小总结, <anonymous type: string 日期, System.Collections.Generic.IEnumerable<<anonymous type: string 人物, string 内容>> 发言, string 玩家姓名, string 玩家消息>[] 最近记录>.群聊`；`<anonymous type: string 群聊, string 说明, string[] 知情人, string 大总结, string 小总结, <anonymous type: string 日期, System.Collections.Generic.IEnumerable<<anonymous type: string 人物, string 内容>> 发言, string 玩家姓名, string 玩家消息>[] 最近记录>.说明`；`<anonymous type: string 群聊, string 说明, string[] 知情人, string 大总结, string 小总结, <anonymous type: string 日期, System.Collections.Generic.IEnumerable<<anonymous type: string 人物, string 内容>> 发言, string 玩家姓名, string 玩家消息>[] 最近记录>.小总结`；`<anonymous type: string 群聊, string 说明, string[] 知情人, string 大总结, string 小总结, <anonymous type: string 日期, System.Collections.Generic.IEnumerable<<anonymous type: string 人物, string 内容>> 发言, string 玩家姓名, string 玩家消息>[] 最近记录>.知情人`；`<anonymous type: string 群聊, string 说明, string[] 知情人, string 大总结, string 小总结, <anonymous type: string 日期, System.Collections.Generic.IEnumerable<<anonymous type: string 人物, string 内容>> 发言, string 玩家姓名, string 玩家消息>[] 最近记录>.最近记录`；`<anonymous type: string 人物, string 内容>.内容`；`<anonymous type: string 人物, string 内容>.人物`；`<anonymous type: string 日期, System.Collections.Generic.IEnumerable<<anonymous type: string 人物, string 内容>> 发言, string 玩家姓名, string 玩家消息>.发言`；`<anonymous type: string 日期, System.Collections.Generic.IEnumerable<<anonymous type: string 人物, string 内容>> 发言, string 玩家姓名, string 玩家消息>.日期`；`<anonymous type: string 日期, System.Collections.Generic.IEnumerable<<anonymous type: string 人物, string 内容>> 发言, string 玩家姓名, string 玩家消息>.玩家消息`；`<anonymous type: string 日期, System.Collections.Generic.IEnumerable<<anonymous type: string 人物, string 内容>> 发言, string 玩家姓名, string 玩家消息>.玩家姓名`；`NationalSpire.GroupChat.BigSummaries`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChat.SmallSummaries`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupEntry.Author`；`NationalSpire.GroupEntry.Text`；`NationalSpire.GroupTurn.Day`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.Sender`；`NationalSpire.GroupTurn.Status`；`NationalSpire.GroupTurn.Text`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateSummary.Through`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(d, id)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, r.Author)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 人物 = GroupChats.Name(d, r.Author)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, t.Sender)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 玩家姓名 = GroupChats.Name(d, t.Sender)`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, t.Day)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 日期 = PrivateAppointments.DateText(d, t.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.BigSummaries.LastOrDefault(s => s.Through > 0 && s.Through <= g.Turns.Count && g.Turns[s.Through - 1].Day <= day)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: g.BigSummaries.LastOrDefault(s => s.Through > 0 && s.Through <= g.Turns.Count && g.Turns[s.Through - 1].Day <= day)?.Text`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.SmallSummaries.LastOrDefault(s => s.Through > 0 && s.Through <= g.Turns.Count && g.Turns[s.Through - 1].Day <= day)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: g.SmallSummaries.LastOrDefault(s => s.Through > 0 && s.Through <= g.Turns.Count && g.Turns[s.Through - 1].Day <= day)?.Text`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Members.Select(id => GroupChats.Name(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Members.Select(id => GroupChats.Name(d, id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Turns.Where(t => t.Status == "complete" && t.Day <= day).TakeLast(5).Select(t => new { 日期 = PrivateAppointments.DateText(d, t.Day), 发言 = t.Replies.Select(r => new { 人物 = GroupChats.Name(d, r.Author), 内容 = r.Text }), 玩家姓名 = GroupChats.Name(d, t.Sender), 玩家消息 = t.Text })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Where(t => t.Status == "complete" && t.Day <= day).TakeLast(5).Select(t => new { 日期 = PrivateAppointments.DateText(d, t.Day), 发言 = t.Replies.Select(r => new { 人物 = GroupChats.Name(d, r.Author), 内容 = r.Text }), 玩家姓名 = GroupChats.Name(d, t.Sender), 玩家消息 = t.Text }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`t.Replies.Select(r => new { 人物 = GroupChats.Name(d, r.Author), 内容 = r.Text })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 发言 = t.Replies.Select(r => new { 人物 = GroupChats.Name(d, r.Author), 内容 = r.Text })`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`g.Turns.Where(t => t.Status == "complete" && t.Day <= day).TakeLast(5)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Where(t => t.Status == "complete" && t.Day <= day).TakeLast(5).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`g.Members.Select(id => GroupChats.Name(d, id)).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 知情人 = g.Members.Select(id => GroupChats.Name(d, id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`g.Turns.Where(t => t.Status == "complete" && t.Day <= day).TakeLast(5).Select(t => new { 日期 = PrivateAppointments.DateText(d, t.Day), 发言 = t.Replies.Select(r => new { 人物 = GroupChats.Name(d, r.Author), 内容 = r.Text }), 玩家姓名 = GroupChats.Name(d, t.Sender), 玩家消息 = t.Text }).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 最近记录 = g.Turns.Where(t => t.Status == "complete" && t.Day <= day).TakeLast(5).Select(t => new { 日期 = PrivateAppointments.DateText(d, t.Day), 发言 = t.Replies.Select(r => new { 人物 = GroupChats.Name(d, r.Author), 内容 = r.Text }), 玩家姓名 = GroupChats.Name(d, t.Sender), 玩家消息 = t.Text }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Where(t => t.Status == "complete" && t.Day <= day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Where(t => t.Status == "complete" && t.Day <= day).TakeLast`

**赋值（含属性/字段和局部值）：**


<a id="symbol-98e994f42924"></a>

## `NationalSpire.ChatTimeline.PublicMemoryRequest.For(string, int) — public string[] For(string person, int day)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?, NationalSpire.ChatTimeline.PublicMemoryRequest?)`](AiDiscussion.cs.md#symbol-7fe54dbd182e)

**调用：** [`NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, int)`](ChatTimeline.cs.md#symbol-ecb3c5ed00bc)；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `<anonymous type: string reference, object content>.content`；`<anonymous type: string reference, object content>.reference`；`NationalSpire.CareerData.Chats`；`NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, int)`；`NationalSpire.ChatTimeline.PublicMemoryRequest._records`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, int)`；输入表达式：`PublicMemory(data, g, day)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: content = PublicMemory(data, g, day)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_records.Add((g.Id, day), new { reference = id, content = PublicMemory(data, g, day) })`；返回值紧邻使用处：`ExpressionStatementSyntax: _records.Add((g.Id, day), new { reference = id, content = PublicMemory(data, g, day) });`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_records.ContainsKey((g.Id, day))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_records.ContainsKey((g.Id, day))`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`data.Chats.Groups.Where(g => g.Members.Contains(person))              .OrderBy(g => g.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Chats.Groups.Where(g => g.Members.Contains(person))              .OrderBy(g => g.Id, StringComparer.Ordinal).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.Chats.Groups.Where(g => g.Members.Contains(person))              .OrderBy(g => g.Id, StringComparer.Ordinal).Select(g =>              {                  string id = g.Id + ":" + day;                  if (!_records.ContainsKey((g.Id, day))) _records.Add((g.Id, day), new { reference = id, content = PublicMemory(data, g, day) });                  return id;              })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Chats.Groups.Where(g => g.Members.Contains(person))              .OrderBy(g => g.Id, StringComparer.Ordinal).Select(g =>              {                  string id = g.Id + ":" + day;                  if (!_records.ContainsKey((g.Id, day))) _records.Add((g.Id, day), new { reference = id, content = PublicMemory(data, g, day) });                  return id;              }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`data.Chats.Groups.Where(g => g.Members.Contains(person))              .OrderBy(g => g.Id, StringComparer.Ordinal).Select(g =>              {                  string id = g.Id + ":" + day;                  if (!_records.ContainsKey((g.Id, day))) _records.Add((g.Id, day), new { reference = id, content = PublicMemory(data, g, day) });                  return id;              }).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => data.Chats.Groups.Where(g => g.Members.Contains(person))              .OrderBy(g => g.Id, StringComparer.Ordinal).Select(g =>              {                  string id = g.Id + ":" + day;                  if (!_records.ContainsKey((g.Id, day))) _records.Add((g.Id, day), new { reference = id, content = PublicMemory(data, g, day) });                  return id;              }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Chats.Groups.Where(g => g.Members.Contains(person))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Chats.Groups.Where(g => g.Members.Contains(person))              .OrderBy`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(person)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Members.Contains(person)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a2c0a45029e5"></a>

## `NationalSpire.ChatTimeline.PublicMemoryRequest.Records — public object[] Records`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `(string Group, int Day).Day`；`(string Group, int Day).Group`；`NationalSpire.ChatTimeline.PublicMemoryRequest._records`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`_records.OrderBy(x => x.Key.Group, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _records.OrderBy(x => x.Key.Group, StringComparer.Ordinal).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_records.OrderBy(x => x.Key.Group, StringComparer.Ordinal).ThenBy(x => x.Key.Day).Select(x => x.Value)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _records.OrderBy(x => x.Key.Group, StringComparer.Ordinal).ThenBy(x => x.Key.Day).Select(x => x.Value).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_records.OrderBy(x => x.Key.Group, StringComparer.Ordinal).ThenBy(x => x.Key.Day).Select(x => x.Value).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _records.OrderBy(x => x.Key.Group, StringComparer.Ordinal).ThenBy(x => x.Key.Day).Select(x => x.Value).ToArray()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`_records.OrderBy(x => x.Key.Group, StringComparer.Ordinal).ThenBy(x => x.Key.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _records.OrderBy(x => x.Key.Group, StringComparer.Ordinal).ThenBy(x => x.Key.Day).Select`

**赋值（含属性/字段和局部值）：**
