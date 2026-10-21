# PrivateMessages.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B4077BA0677A1A0CB9D99FA1A81FFC2BAB90D1D47985D704E93E21EF56D6713A`。来源：[源码](../../PrivateMessages.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PrivateMessages`、`NationalSpire.PrivateStreamParser`。

字段、事件及初始值（源码原样）：

```csharp
private readonly string[] _extraFields;
private readonly StringBuilder _visible = new(), _pending = new();
private int _depth;
```

<a id="symbol-b69ec8c11bc6"></a>

## `NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn) — public static bool VisibleInCommunications(PrivateTurn turn)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.PrivateMessages.UnreadInCommunications(NationalSpire.PrivateConversation)`](PrivateMessages.cs.md#symbol-8f55a4576019)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneRequest.Ending`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-eb7a8aaa6a38"></a>

## `NationalSpire.PrivateMessages.ListedInCommunications(NationalSpire.PrivateConversation) — public static bool ListedInCommunications(PrivateConversation c)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.ChatContacts.List(NationalSpire.CareerData, NationalSpire.ChatContactPreferences, string, string)`](ChatContacts.cs.md#symbol-9d6a9ed3895a)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.EventOnly`；`NationalSpire.PrivateConversation.Hidden`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateTurn.RequestKind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.RequestKind != "event")`；返回值紧邻使用处：`BinaryExpressionSyntax: !c.EventOnly || c.Turns.Any(t => t.RequestKind != "event")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8f55a4576019"></a>

## `NationalSpire.PrivateMessages.UnreadInCommunications(NationalSpire.PrivateConversation) — public static int UnreadInCommunications(PrivateConversation c)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)；[`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)

**调用：** [`NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`](PrivateMessages.cs.md#symbol-b69ec8c11bc6)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.SeenCount`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`；输入表达式：`VisibleInCommunications(t)`；返回值紧邻使用处：`BinaryExpressionSyntax: t.RequestKind != "event" && VisibleInCommunications(t)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Where(t => t.Status == "complete").Skip(Math.Max(0, c.SeenCount)).Count(t => t.RequestKind != "event" && VisibleInCommunications(t))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => c.Turns.Where(t => t.Status == "complete").Skip(Math.Max(0, c.SeenCount)).Count(t => t.RequestKind != "event" && VisibleInCommunications(t))`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`c.Turns.Where(t => t.Status == "complete").Skip(Math.Max(0, c.SeenCount))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Where(t => t.Status == "complete").Skip(Math.Max(0, c.SeenCount)).Count`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Where(t => t.Status == "complete")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Where(t => t.Status == "complete").Skip`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, c.SeenCount)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, c.SeenCount)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81234ccf975f"></a>

## `NationalSpire.PrivateMessages.PublicMemory(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int) — public static object[] PublicMemory(CareerData data, CareerPerson person, IEnumerable<CommunityPost> posts, int day)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?, NationalSpire.ChatTimeline.PublicMemoryRequest?)`](AiDiscussion.cs.md#symbol-7fe54dbd182e)

**调用：** [`Available(NationalSpire.PrivateSummary)`](PrivateMessages.cs.md#symbol-145e6bf8e43d)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；[`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`](PrivateMessageData.cs.md#symbol-2a4d65cc20f8)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.CareerData, NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`](PrivateMessagePrompts.cs.md#symbol-2e632c46656c)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`Summary(NationalSpire.PrivateSummary?)`](PrivateMessages.cs.md#symbol-67573b4afbf4)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `(int Index, int Season, int Day, string Speaker, string Text).Day`；`(int Index, int Season, int Day, string Speaker, string Text).Index`；`(int Index, int Season, int Day, string Speaker, string Text).Speaker`；`(int Index, int Season, int Day, string Speaker, string Text).Text`；`<anonymous type: string 日期, string 发言人, string 内容>.发言人`；`<anonymous type: string 日期, string 发言人, string 内容>.内容`；`<anonymous type: string 日期, string 发言人, string 内容>.日期`；`Available(NationalSpire.PrivateSummary)`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.CareerData, NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Impression`；`NationalSpire.PrivateRelation.Relationship`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Through`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Season`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.UserDeleted`；`Summary(NationalSpire.PrivateSummary?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Available(NationalSpire.PrivateSummary)`；输入表达式：`Available(s)`；返回值紧邻使用处：`BinaryExpressionSyntax: Available(s) && s.Through > (big?.Through ?? 0)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, human)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.DisplayName(data, human)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CommunityThreads.IsHuman(data, id)`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(data, m.Day)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 日期 = PrivateAppointments.DateText(data, m.Day)`
- `NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；输入表达式：`PrivateInteractionIds.Ensure(conversation)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionIds.Ensure(conversation);`
- `NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.CareerData, NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`；输入表达式：`PrivateMessagePrompts.UserText(data, t, conversation)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessagePrompts.UserText(data, t, conversation)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`Mailbox(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: human == "player" || human == data.LocalHumanId ? Mailbox(data) : null`
- `Summary(NationalSpire.PrivateSummary?)`；输入表达式：`Summary(big)`；返回值紧邻使用处：`AssignmentExpressionSyntax: entry["长期摘要"] = Summary(big)`
- `Summary(NationalSpire.PrivateSummary?)`；输入表达式：`Summary(small)`；返回值紧邻使用处：`AssignmentExpressionSyntax: entry["近期摘要"] = Summary(small)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, object?> { ["对象"] = name, ["对象Id"] = human,                  ["关系"] = relation?.Relationship ?? "初识", ["好感"] = relation?.Favour ?? 0, ["印象"] = relation?.Impression ?? "" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, object?> { ["对象"] = name, ["对象Id"] = human,                  ["关系"] = relation?.Relationship ?? "初识", ["好感"] = relation?.Favour ?? 0, ["印象"] = relation?.Impression ?? "" }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`box.Conversations.TryGetValue(person.Id, out var conversation)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.Conversations.TryGetValue(person.Id, out var conversation);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`box.Relations.TryGetValue(person.Id, out var relation)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.Relations.TryGetValue(person.Id, out var relation);`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`posts.SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))              .Where(id => CommunityThreads.IsHuman(data, id)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))              .Where(id => CommunityThreads.IsHuman(data, id)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.BigSummaries.LastOrDefault(Available)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.BigSummaries.LastOrDefault(Available)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.SmallSummaries.LastOrDefault(s => Available(s) && s.Through > (big?.Through ?? 0))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.SmallSummaries.LastOrDefault(s => Available(s) && s.Through > (big?.Through ?? 0))`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`conversation.Turns.Select((t, i) => (t, i)).Reverse().SelectMany(item =>                  {                      var (t, i) = item;                      var lines = new List<(int Index, int Season, int Day, string Speaker, string Text)>();                      if (t.Status != "complete" || t.Day > day) return lines;                      if (!t.ReplyDeleted) lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply));                      if (!t.UserDeleted) lines.Add((i, t.Season, t.Day, t.RequestKind == "event" ? "共同经历" : name, PrivateMessagePrompts.UserText(data, t, conversation)));                      return lines;                  }).Take(10).Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Turns.Select((t, i) => (t, i)).Reverse().SelectMany(item =>                  {                      var (t, i) = item;                      var lines = new List<(int Index, int Season, int Day, string Speaker, string Text)>();                      if (t.Status != "complete" || t.Day > day) return lines;                      if (!t.ReplyDeleted) lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply));                      if (!t.UserDeleted) lines.Add((i, t.Season, t.Day, t.RequestKind == "event" ? "共同经历" : name, PrivateMessagePrompts.UserText(data, t, conversation)));                      return lines;                  }).Take(10).Reverse().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`conversation.Turns.Select((t, i) => (t, i)).Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Turns.Select((t, i) => (t, i)).Reverse().SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`conversation.Turns.Select((t, i) => (t, i))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Turns.Select((t, i) => (t, i)).Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`messages.Select(m => new { 日期 = PrivateAppointments.DateText(data, m.Day), 发言人 = m.Speaker, 内容 = m.Text })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: messages.Select(m => new { 日期 = PrivateAppointments.DateText(data, m.Day), 发言人 = m.Speaker, 内容 = m.Text }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Replies.Select(r => r.AuthorId)`；返回值紧邻使用处：`ArgumentSyntax: p.Replies.Select(r => r.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`conversation.Turns.Select((t, i) => (t, i)).Reverse().SelectMany(item =>                  {                      var (t, i) = item;                      var lines = new List<(int Index, int Season, int Day, string Speaker, string Text)>();                      if (t.Status != "complete" || t.Day > day) return lines;                      if (!t.ReplyDeleted) lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply));                      if (!t.UserDeleted) lines.Add((i, t.Season, t.Day, t.RequestKind == "event" ? "共同经历" : name, PrivateMessagePrompts.UserText(data, t, conversation)));                      return lines;                  })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Turns.Select((t, i) => (t, i)).Reverse().SelectMany(item =>                  {                      var (t, i) = item;                      var lines = new List<(int Index, int Season, int Day, string Speaker, string Text)>();                      if (t.Status != "complete" || t.Day > day) return lines;                      if (!t.ReplyDeleted) lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply));                      if (!t.UserDeleted) lines.Add((i, t.Season, t.Day, t.RequestKind == "event" ? "共同经历" : name, PrivateMessagePrompts.UserText(data, t, conversation)));                      return lines;                  }).Take`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`posts.SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))              .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`conversation.Turns.Select((t, i) => (t, i)).Reverse().SelectMany(item =>                  {                      var (t, i) = item;                      var lines = new List<(int Index, int Season, int Day, string Speaker, string Text)>();                      if (t.Status != "complete" || t.Day > day) return lines;                      if (!t.ReplyDeleted) lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply));                      if (!t.UserDeleted) lines.Add((i, t.Season, t.Day, t.RequestKind == "event" ? "共同经历" : name, PrivateMessagePrompts.UserText(data, t, conversation)));                      return lines;                  }).Take(10)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Turns.Select((t, i) => (t, i)).Reverse().SelectMany(item =>                  {                      var (t, i) = item;                      var lines = new List<(int Index, int Season, int Day, string Speaker, string Text)>();                      if (t.Status != "complete" || t.Day > day) return lines;                      if (!t.ReplyDeleted) lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply));                      if (!t.UserDeleted) lines.Add((i, t.Season, t.Day, t.RequestKind == "event" ? "共同经历" : name, PrivateMessagePrompts.UserText(data, t, conversation)));                      return lines;                  }).Take(10).Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`conversation.Turns.Select((t, i) => (t, i)).Reverse().SelectMany(item =>                  {                      var (t, i) = item;                      var lines = new List<(int Index, int Season, int Day, string Speaker, string Text)>();                      if (t.Status != "complete" || t.Day > day) return lines;                      if (!t.ReplyDeleted) lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply));                      if (!t.UserDeleted) lines.Add((i, t.Season, t.Day, t.RequestKind == "event" ? "共同经历" : name, PrivateMessagePrompts.UserText(data, t, conversation)));                      return lines;                  }).Take(10).Reverse().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Turns.Select((t, i) => (t, i)).Reverse().SelectMany(item =>                  {                      var (t, i) = item;                      var lines = new List<(int Index, int Season, int Day, string Speaker, string Text)>();                      if (t.Status != "complete" || t.Day > day) return lines;                      if (!t.ReplyDeleted) lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply));                      if (!t.UserDeleted) lines.Add((i, t.Season, t.Day, t.RequestKind == "event" ? "共同经历" : name, PrivateMessagePrompts.UserText(data, t, conversation)));                      return lines;                  }).Take(10).Reverse().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`messages.Select(m => new { 日期 = PrivateAppointments.DateText(data, m.Day), 发言人 = m.Speaker, 内容 = m.Text }).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: entry["最近记录"] = messages.Select(m => new { 日期 = PrivateAppointments.DateText(data, m.Day), 发言人 = m.Speaker, 内容 = m.Text }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`posts.SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))              .Where(id => CommunityThreads.IsHuman(data, id)).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = posts.SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))              .Where(id => CommunityThreads.IsHuman(data, id)).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`posts.SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))              .Where(id => CommunityThreads.IsHuman(data, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))              .Where(id => CommunityThreads.IsHuman(data, id)).Distinct`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.PrivateMemorySources.GetValueOrDefault(human)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.PrivateMemorySources.GetValueOrDefault(human)                  ?? (human == "player" || human == data.LocalHumanId ? Mailbox(data) : null)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply))`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add((i, t.Season, t.Day, t.RequestKind == "event" ? "共同经历" : name, PrivateMessagePrompts.UserText(data, t, conversation)))`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add((i, t.Season, t.Day, t.RequestKind == "event" ? "共同经历" : name, PrivateMessagePrompts.UserText(data, t, conversation)));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(entry);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(int Index, int Season, int Day, string Speaker, string Text)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(int Index, int Season, int Day, string Speaker, string Text)>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<object>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<object>()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`result.ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return result.ToArray();`

**赋值（含属性/字段和局部值）：**

- `["对象"]` = `name`
- `["对象Id"]` = `human`
- `["关系"]` = `relation?.Relationship ?? "初识"`
- `["好感"]` = `relation?.Favour ?? 0`
- `["印象"]` = `relation?.Impression ?? ""`
- `entry["近期摘要"]` = `Summary(small)`
- `entry["说明"]` = `$"以下是{person.PublicName}与{name}的私信摘要和最近记录。摘要由{person.PublicName}以第一人称记录，其中‘我’指{person.PublicName}，‘你’指{name}。"`
- `entry["长期摘要"]` = `Summary(big)`
- `entry["最近记录"]` = `messages.Select(m => new { 日期 = PrivateAppointments.DateText(data, m.Day), 发言人 = m.Speaker, 内容 = m.Text }).ToArray()`
- `small` = `null`
- `var (t, i)` = `item`

<a id="symbol-145e6bf8e43d"></a>

## `Available(NationalSpire.PrivateSummary) — bool Available(PrivateSummary s)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.PublicMemory(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`](PrivateMessages.cs.md#symbol-81234ccf975f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateSummary.Through`；`NationalSpire.PrivateTurn.Day`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-67573b4afbf4"></a>

## `Summary(NationalSpire.PrivateSummary?) — object? Summary(PrivateSummary? s)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.PublicMemory(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`](PrivateMessages.cs.md#symbol-81234ccf975f)

**调用：** [`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `<anonymous type: string 日期, string 内容>.内容`；`<anonymous type: string 日期, string 内容>.日期`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateSummary.Through`；`NationalSpire.PrivateTurn.Day`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(data, end.Day)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(data, end.Day)}`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(data, start.Day)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(data, start.Day)}`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(s.From, 0, conversation.Turns.Count - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(s.From, 0, conversation.Turns.Count - 1)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2e8d90d01925"></a>

## `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData) — public static PrivateMailbox Mailbox(CareerData data)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`](NpcAvatarFrameScreen.cs.md#symbol-ca2807c0402f)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PickerRing(Godot.HBoxContainer, NationalSpire.CareerData, string)`](ConsumerGiftControls.cs.md#symbol-e35b8d3e088f)；[`NationalSpire.CareerScreen.PrivateSettings()`](PrivateMessageScreen.cs.md#symbol-e86e401f7314)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.CareerScreen.RestoreChatDialog()`](ChatManagementScreen.cs.md#symbol-812702bacb1e)；[`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)；[`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)；[`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.ChatContacts.EventIndicators(NationalSpire.CareerData)`](ChatContacts.cs.md#symbol-e894a486e226)；[`NationalSpire.ChatContacts.List(NationalSpire.CareerData, NationalSpire.ChatContactPreferences, string, string)`](ChatContacts.cs.md#symbol-9d6a9ed3895a)；[`NationalSpire.ChatMembership.Private(NationalSpire.CareerData, NationalSpire.PrivateConversation, string)`](ChatMembership.cs.md#symbol-9c321c19150a)；[`NationalSpire.ChatTimeline.PrivateHistory(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?)`](ChatTimeline.cs.md#symbol-4c7ee0ce6871)；[`NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`](GroupChats.cs.md#symbol-167e5090d91a)；[`NationalSpire.NpcAvatarFrames.Select(NationalSpire.CareerData, string, string)`](NpcAvatarFrames.cs.md#symbol-8c2dcfe0344a)；[`NationalSpire.PortraitDesigns.Messages(NationalSpire.CareerData, string, NationalSpire.PortraitDesign)`](PortraitDesign.cs.md#symbol-3f8b0db3fc3f)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`](PrivateInteractionUndo.cs.md#symbol-25f3da26ec8f)；[`NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-dd91210e87c0)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)；[`NationalSpire.PrivateMessageCommands.RecordFailure(NationalSpire.CareerData, string, NationalSpire.PrivateMessageCommand, string)`](PrivateMessageCommands.cs.md#symbol-b4c1683dbba9)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；[`NationalSpire.PrivateMessages.PublicMemory(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`](PrivateMessages.cs.md#symbol-81234ccf975f)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.ProactiveChats.StartQueued(NationalSpire.CareerData)`](ProactiveChats.cs.md#symbol-67e715945068)；[`NationalSpire.ProactiveChats.Trigger(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](ProactiveChats.cs.md#symbol-2f5328ae3c0f)；[`NationalSpire.RandomEvents.Remember(NationalSpire.CareerData, NationalSpire.RandomEventRecord, string, string)`](RandomEvents.cs.md#symbol-e25f0d98c349)；[`NationalSpire.RelationshipPresentation.CompleteWedding(NationalSpire.CareerData, string)`](RelationshipPresentation.cs.md#symbol-49a406ddaa23)；[`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-0596ed8dd544)；[`NationalSpire.SpireArbitration.Complete(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, NationalSpire.ArbitrationDecision)`](SpireArbitration.cs.md#symbol-7bc24f64a697)；[`NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-35e35b4dd8e0)；[`Save()`](NpcAvatarFrameScreen.cs.md#symbol-a1802dcac073)

**调用：** [`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerLifeState)`](PrivateMessages.cs.md#symbol-1497deb3b218)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerLifeState)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerLifeState)`；输入表达式：`Mailbox(data.Life)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Mailbox(data.Life)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1497deb3b218"></a>

## `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerLifeState) — public static PrivateMailbox Mailbox(CareerLifeState life)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.RefreshPeople(NationalSpire.Coop.CoopWorld)`](Coop/CoopRules.cs.md#symbol-8025e01818d7)；[`NationalSpire.PrivateMessages.EditRelation(NationalSpire.CareerData, NationalSpire.CareerLifeState, string, string, NationalSpire.CharacterRelationEdit)`](PrivateMessages.cs.md#symbol-721322de5dd7)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)

**调用：** [`NationalSpire.PrivateMessages.RemoveDeletedOffers(NationalSpire.PrivateConversation)`](PrivateMessages.cs.md#symbol-b239ace74471)；`NationalSpire.PrivateRelation.PrivateRelation()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.CareerLifeState.Relationships`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMailbox.Version`；`NationalSpire.PrivateMessages.RemoveDeletedOffers(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Relationship`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.RemoveDeletedOffers(NationalSpire.PrivateConversation)`；输入表达式：`RemoveDeletedOffers(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveDeletedOffers(c);`
- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new() { Favour = Math.Clamp(value * 3, -100, 100), Relationship = value > 0 ? "熟人" : "初识" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Favour = Math.Clamp(value * 3, -100, 100), Relationship = value > 0 ? "熟人" : "初识" }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`box.Relations.TryAdd(id, new() { Favour = Math.Clamp(value * 3, -100, 100), Relationship = value > 0 ? "熟人" : "初识" })`；返回值紧邻使用处：`ExpressionStatementSyntax: box.Relations.TryAdd(id, new() { Favour = Math.Clamp(value * 3, -100, 100), Relationship = value > 0 ? "熟人" : "初识" });`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`life.Relationships.ToArray()`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (id, value) in life.Relationships.ToArray())              {                  box.Relations.TryAdd(id, new() { Favour = Math.Clamp(value * 3, -100, 100), Relationship = value > 0 ? "熟人" : "初识" });                  life.Relationships[id] = box.Relations[id].Favour;              }`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(value * 3, -100, 100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Favour = Math.Clamp(value * 3, -100, 100)`

**赋值（含属性/字段和局部值）：**

- `box.Version` = `1`
- `box.Version` = `2`
- `Favour` = `Math.Clamp(value * 3, -100, 100)`
- `life.Relationships[id]` = `box.Relations[id].Favour`
- `Relationship` = `value > 0 ? "熟人" : "初识"`

<a id="symbol-b239ace74471"></a>

## `NationalSpire.PrivateMessages.RemoveDeletedOffers(NationalSpire.PrivateConversation) — public static void RemoveDeletedOffers(PrivateConversation c)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Recover(NationalSpire.CareerLifeState)`](PrivateMessageCommands.cs.md#symbol-1ce050227fd9)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerLifeState)`](PrivateMessages.cs.md#symbol-1497deb3b218)；[`NationalSpire.PrivateMessages.Manage(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, NationalSpire.PrivateMessageCommand)`](PrivateMessages.cs.md#symbol-2b57951bede9)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Id == o.TurnId && !t.UserDeleted && !t.ReplyDeleted)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Turns.Any(t => t.Id == o.TurnId && !t.UserDeleted && !t.ReplyDeleted)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`c.Offers.RemoveAll(o => o.State is not ("已确认" or "已赴约") &&              !c.Turns.Any(t => t.Id == o.TurnId && !t.UserDeleted && !t.ReplyDeleted))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Offers.RemoveAll(o => o.State is not ("已确认" or "已赴约") &&              !c.Turns.Any(t => t.Id == o.TurnId && !t.UserDeleted && !t.ReplyDeleted))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8a6bb6e78fa5"></a>

## `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string) — public static PrivateRelation Relation(CareerData data, string id)`

来源：源码第 88 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Changed(bool)`](ConsumerPickerScreen.cs.md#symbol-1a2f8d82e83f)；[`NationalSpire.CareerScreen.GroupActions()`](GroupChatDialogs.cs.md#symbol-38cd67d996b6)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`](NpcAvatarFrameScreen.cs.md#symbol-ca2807c0402f)；[`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)；[`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`](NpcAvatarFrames.cs.md#symbol-312d47fec9fa)；[`NationalSpire.OathAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](OathAttachments.cs.md#symbol-9abb4f75eb8f)；[`NationalSpire.OathAttachments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](OathAttachments.cs.md#symbol-80bb2ac38dee)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`](PrivateInteractionUndo.cs.md#symbol-25f3da26ec8f)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)；[`NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-886f350e91dc)；[`NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`](RandomEventPrompts.cs.md#symbol-a96ac205ab9d)；[`NationalSpire.RelationshipGifts.Accept(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-821bf6a43163)；[`NationalSpire.RelationshipPresentation.CompleteWedding(NationalSpire.CareerData, string)`](RelationshipPresentation.cs.md#symbol-49a406ddaa23)

**调用：** [`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`NationalSpire.PrivateRelation.PrivateRelation()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`Mailbox(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Mailbox(data)`
- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation = new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`box.Relations.TryGetValue(id, out var relation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !box.Relations.TryGetValue(id, out var relation)`

**赋值（含属性/字段和局部值）：**

- `box.Relations[id]` = `relation = new()`
- `relation` = `new()`

<a id="symbol-13f25fec3dea"></a>

## `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string) — public static int Favour(CareerData data, string id)`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.DiscussionFavour(NationalSpire.CareerData, string, NationalSpire.CommunityPost, System.Collections.Generic.ISet<string>)`](AiDiscussion.cs.md#symbol-17d3d2eafe88)；[`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?, NationalSpire.ChatTimeline.PublicMemoryRequest?)`](AiDiscussion.cs.md#symbol-7fe54dbd182e)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.ReplyAttitudes(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>, string)`](AiDiscussion.cs.md#symbol-fdff22dfb023)；[`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)；[`NationalSpire.PrivateContracts.Guidance(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateAppointments.cs.md#symbol-3c22aa703fb0)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateMessages.ConfirmFavour(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessages.cs.md#symbol-056e9f8e0046)；[`NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-09ecc3f9af33)；[`NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`](RandomEventPrompts.cs.md#symbol-a96ac205ab9d)；[`NationalSpire.RelationshipGifts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-a99c2d3aea53)；[`Refresh()`](PeoplePickerScreen.cs.md#symbol-dd4db64669ab)；[`ShowRows()`](PeoplePickerScreen.cs.md#symbol-0dac44c0ee6b)

**调用：** [`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateRelation.Favour`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Mailbox(data).Relations`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`Mailbox(data).Relations.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Mailbox(data).Relations.GetValueOrDefault(id)?.Favour`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c703192e56c0"></a>

## `NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int) — public static void ChangeFavour(CareerData data, string id, int delta)`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CareerRelics.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-f756311e9342)；[`NationalSpire.ConsumerAttachments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`](ConsumerAttachments.cs.md#symbol-c0f0a7c39a70)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerEngine.cs.md#symbol-2d5bf22bd5bc)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateMessages.ConfirmFavour(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessages.cs.md#symbol-056e9f8e0046)；[`NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-886f350e91dc)

**调用：** [`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Relationships`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`Relation(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Relation(data, id)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(relation.Favour + delta, -100, 100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation.Favour = Math.Clamp(relation.Favour + delta, -100, 100)`

**赋值（含属性/字段和局部值）：**

- `data.Life.Relationships[id]` = `relation.Favour`
- `relation.Favour` = `Math.Clamp(relation.Favour + delta, -100, 100)`

<a id="symbol-721322de5dd7"></a>

## `NationalSpire.PrivateMessages.EditRelation(NationalSpire.CareerData, NationalSpire.CareerLifeState, string, string, NationalSpire.CharacterRelationEdit) — public static void EditRelation(CareerData data, CareerLifeState life, string human, string id, CharacterRelationEdit edit)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, NationalSpire.CareerLifeState?, string?)`](CharacterCards.cs.md#symbol-a50771d297a5)

**调用：** [`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`](PrivateInteractionUndo.cs.md#symbol-9f5887b5e53e)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerLifeState)`](PrivateMessages.cs.md#symbol-1497deb3b218)；`NationalSpire.PrivateRelation.PrivateRelation()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerLifeState.Relationships`；`NationalSpire.CharacterRelationEdit.Favour`；`NationalSpire.CharacterRelationEdit.Impression`；`NationalSpire.CharacterRelationEdit.Relationship`；`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerLifeState)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Impression`；`NationalSpire.PrivateRelation.Relationship`；`NationalSpire.PrivateRelation.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`PrivateInteractionHistory.PreserveRelation(box, data.Chats, human, id, fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.PreserveRelation(box, data.Chats, human, id, fields);`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerLifeState)`；输入表达式：`Mailbox(life)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Mailbox(life)`
- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation = new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`box.Relations.TryGetValue(id, out var relation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !box.Relations.TryGetValue(id, out var relation)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`fields.Add(nameof(PrivateRelation.Favour))`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.Add(nameof(PrivateRelation.Favour));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`fields.Add(nameof(PrivateRelation.Impression))`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.Add(nameof(PrivateRelation.Impression));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`fields.Add(nameof(PrivateRelation.Relationship))`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.Add(nameof(PrivateRelation.Relationship));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`

**赋值（含属性/字段和局部值）：**

- `box.Relations[id]` = `relation = new()`
- `life.Relationships[id]` = `favour`
- `relation.Favour` = `favour`
- `relation.Impression` = `edit.Impression`
- `relation.Relationship` = `edit.Relationship`
- `relation` = `new()`

<a id="symbol-f1f120717f00"></a>

## `NationalSpire.PrivateMessages.RelationshipLabel(int) — public static string RelationshipLabel(int favour)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-83ba4c7aed0f"></a>

## `NationalSpire.PrivateMessages.IsChatNpc(NationalSpire.CareerData, string) — private static bool IsChatNpc(CareerData data, string id)`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-a6a32e618e4c)

**调用：** `System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.HumanIds.Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-25194feb6779"></a>

## `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string) — public static bool CanChat(CareerData data, string id)`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Members()`](ConsumerPickerScreen.cs.md#symbol-d527b6ec3f7c)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)；[`NationalSpire.CareerScreen.GroupActions()`](GroupChatDialogs.cs.md#symbol-38cd67d996b6)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)；[`NationalSpire.CareerScreen.ReportDiscussion(string, string)`](ArbitrationScreen.cs.md#symbol-4223b2b95c14)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-be8cf79217b4)；[`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.CareerTraining.RecordLesson(NationalSpire.CareerData, string, NationalSpire.PrivateLearning)`](CareerTraining.cs.md#symbol-20ac1d8e57c7)；[`NationalSpire.CareerTraining.RecordMood(NationalSpire.CareerData, string, NationalSpire.PrivateMood)`](CareerTraining.cs.md#symbol-ef124ea1d16b)；[`NationalSpire.ChatContacts.List(NationalSpire.CareerData, NationalSpire.ChatContactPreferences, string, string)`](ChatContacts.cs.md#symbol-9d6a9ed3895a)；[`NationalSpire.CommunityReporting.Create(NationalSpire.CareerData, string, string, string)`](CommunityReporting.cs.md#symbol-6bbc23d16690)；[`NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-2aa34d35c1b8)；[`NationalSpire.Coop.CoopCoordinator.ReceivePrivate(NationalSpire.Coop.CoopWire, System.DateTime)`](Coop/CoopPrivateMessages.cs.md#symbol-eca8b0236539)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChats.CanSpeak(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-bc138d545f34)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.GroupChats.Rewind(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChats.cs.md#symbol-d45d31e160a9)；[`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-e7f8b7355ddf)；[`NationalSpire.PrivateContracts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-dbd791b573e7)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateProfileChanges.Publish(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateProfileChanges.cs.md#symbol-930916e1d31b)；[`NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-09ecc3f9af33)；[`NationalSpire.RandomEvents.Remember(NationalSpire.CareerData, NationalSpire.RandomEventRecord, string, string)`](RandomEvents.cs.md#symbol-e25f0d98c349)；[`NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-605db3348248)；[`Pick(string, System.Action, bool)`](GroupChatDialogs.cs.md#symbol-859a67dfed9d)；[`Refresh()`](MentionComposer.cs.md#symbol-13231b1d37b1)；[`Show(bool)`](ConsumerPickerScreen.cs.md#symbol-af2149f1e8fd)

**调用：** [`NationalSpire.PrivateMessages.IsChatNpc(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-83ba4c7aed0f)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.PrivateMessages.IsChatNpc(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.IsChatNpc(NationalSpire.CareerData, string)`；输入表达式：`IsChatNpc(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsChatNpc(data, id) && data.People.Any(p => p.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Any(p => p.Id == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsChatNpc(data, id) && data.People.Any(p => p.Id == id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a6a32e618e4c"></a>

## `NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData) — public static IEnumerable<CareerPerson> ChatCandidates(CareerData data)`

来源：源码第 119 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunitySharing.Recipients(NationalSpire.CareerData, string)`](CommunitySharing.cs.md#symbol-8baa01608a2d)

**调用：** [`NationalSpire.PrivateMessages.IsChatNpc(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-83ba4c7aed0f)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.PrivateMessages.IsChatNpc(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.IsChatNpc(NationalSpire.CareerData, string)`；输入表达式：`IsChatNpc(data, p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => IsChatNpc(data, p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => IsChatNpc(data, p.Id))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => data.People.Where(p => IsChatNpc(data, p.Id))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3712b7336055"></a>

## `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string) — public static PrivateConversation Conversation(CareerData data, string id)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)；[`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)；[`NationalSpire.CareerScreen.BindChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-e22063fef4cb)；[`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.EditFailedDateScene()`](DateSceneScreen.cs.md#symbol-11eaa513a64e)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.PreviewPrivatePrompt()`](PrivateMessageScreen.cs.md#symbol-aefc38a1fba3)；[`NationalSpire.CareerScreen.PrivateArbitrationDialog()`](ArbitrationScreen.cs.md#symbol-63e3d9aaa6df)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)；[`NationalSpire.CareerScreen.PrivateMessageMenu(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-9a1e5f17a52a)；[`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)；[`NationalSpire.CareerScreen.ProactiveChatDialog()`](ChatManagementScreen.cs.md#symbol-f9397f5fb6b7)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.RegenerateDateScene()`](DateSceneScreen.cs.md#symbol-c589255edb6a)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-be8cf79217b4)；[`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.Coop.CoopRules.ConfirmPrivateMatch(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal)`](Coop/CoopPrivateMessages.cs.md#symbol-ec0e4056cf90)；[`NationalSpire.Coop.CoopRules.PrivateCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopPrivateMessages.cs.md#symbol-d33f4b1ffce8)；[`NationalSpire.PrivateAppointments.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-3089895d205a)；[`NationalSpire.PrivateContracts.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, string)`](PrivateAppointments.cs.md#symbol-1c0ddcc69a05)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`](PrivateInteractionUndo.cs.md#symbol-25f3da26ec8f)；[`NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-dd91210e87c0)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)；[`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`](PrivateMessages.cs.md#symbol-0e61d4a7bbb5)；[`NationalSpire.PrivatePublicContext.AppendCareerDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivateCareerContext.cs.md#symbol-2e7904202268)

**调用：** [`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`NationalSpire.PrivateConversation.PrivateConversation()`；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateConversation.PrivateConversation()`；输入表达式：`new() { PersonId = id }`；返回值紧邻使用处：`AssignmentExpressionSyntax: c = new() { PersonId = id }`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`CanChat(data, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanChat(data, id)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`Mailbox(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Mailbox(data)`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("只能与 NPC 私信。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("只能与 NPC 私信。");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`box.Conversations.TryGetValue(id, out var c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !box.Conversations.TryGetValue(id, out var c)`

**赋值（含属性/字段和局部值）：**

- `box.Conversations[id]` = `c = new() { PersonId = id }`
- `c` = `new() { PersonId = id }`
- `PersonId` = `id`

<a id="symbol-0e61d4a7bbb5"></a>

## `NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool) — public static PrivateTurn Enqueue(CareerData data, string id, string text, PrivateOffer? request = null, List<PrivateOffer>? attachments = null, string proactiveReason = "", bool queueAfterCurrent = false)`

来源：源码第 127 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)；[`NationalSpire.ProactiveChats.Trigger(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](ProactiveChats.cs.md#symbol-2f5328ae3c0f)

**调用：** [`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-c362351c7a43)；[`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`](PrivateMessageData.cs.md#symbol-2a4d65cc20f8)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`NationalSpire.PrivateTurn.PrivateTurn()`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Season`；`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.Forgotten`；`NationalSpire.PrivateConversation.Hidden`；`NationalSpire.PrivateConversation.Proactive`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.ProactiveReason`；`NationalSpire.PrivateTurn.Request`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Season`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserOrder`；`NationalSpire.ProactiveChatSettings.Unanswered`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；输入表达式：`GroupChats.NextOrder(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: UserOrder = GroupChats.NextOrder(data)`
- `NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；输入表达式：`PrivateInteractionIds.Ensure(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionIds.Ensure(c);`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`Conversation(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Conversation(data, id)`
- `NationalSpire.PrivateTurn.PrivateTurn()`；输入表达式：`new PrivateTurn { ProactiveReason = proactiveReason, UserOrder = GroupChats.NextOrder(data), User = text.Trim(), Day = data.Day, Season = data.Season, Request = request, RequestKind = request?.Kind ?? "", Attachments = attachments ?? [] }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateTurn { ProactiveReason = proactiveReason, UserOrder = GroupChats.NextOrder(data), User = text.Trim(), Day = data.Day, Season = data.Season, Request = request, RequestKind = request?.Kind ?? "", Attachments = attachments ?? [] }`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(text) && attachments?.Count is not > 0`
- `string.Trim()`；输入表达式：`text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: User = text.Trim()`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请填写消息或添加附件，正文最多 8000 字。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请填写消息或添加附件，正文最多 8000 字。");`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`BinaryExpressionSyntax: !queueAfterCurrent && c.Turns.Any(t => t.Status is "queued" or "sending")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Turns.Add(turn)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Turns.Add(turn);`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请等待当前回复，或先停止生成。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请等待当前回复，或先停止生成。");`

**赋值（含属性/字段和局部值）：**

- `Attachments` = `attachments ?? []`
- `c.Forgotten` = `false`
- `c.Hidden` = `false`
- `c.Proactive.Unanswered` = `0`
- `Day` = `data.Day`
- `ProactiveReason` = `proactiveReason`
- `Request` = `request`
- `RequestKind` = `request?.Kind ?? ""`
- `Season` = `data.Season`
- `User` = `text.Trim()`
- `UserOrder` = `GroupChats.NextOrder(data)`

<a id="symbol-3f3045d6546b"></a>

## `NationalSpire.PrivateMessages.Completed(NationalSpire.PrivateConversation) — public static int Completed(PrivateConversation c)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)；[`NationalSpire.PrivateMessages.Manage(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, NationalSpire.PrivateMessageCommand)`](PrivateMessages.cs.md#symbol-2b57951bede9)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-3776534c6c5a)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.ContextStart`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Skip(c.ContextStart).Count(t => t.Status == "complete" && !(t.UserDeleted && t.ReplyDeleted))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => c.Turns.Skip(c.ContextStart).Count(t => t.Status == "complete" && !(t.UserDeleted && t.ReplyDeleted))`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`c.Turns.Skip(c.ContextStart)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Skip(c.ContextStart).Count`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f2d6d9cf9c86"></a>

## `NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>) — public static string? PrepareAttachments(CareerData data, string person, List<PrivateOffer> attachments)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.AiGeneratedText.Different(string, string)`](AiGeneratedText.cs.md#symbol-8a7bdafb8195)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ChatAttachments.cs.md#symbol-4e7c361b1f77)；[`NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ClubCoaching.cs.md#symbol-061ee769bb78)；[`NationalSpire.CoachLineups.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](CoachLineups.cs.md#symbol-be04a02d4a9c)；[`NationalSpire.CoachLineups.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](CoachLineups.cs.md#symbol-fac9e8c2eaeb)；[`NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](CommunitySharing.cs.md#symbol-b6e3b5a6b60e)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.MatchRules.Time(double?)`](MatchRules.cs.md#symbol-13ecc28f8403)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-e7f8b7355ddf)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?, bool)`](PrivatePublicContext.cs.md#symbol-b4d8110deb5b)；`NationalSpire.PrivateOffer.PrivateOffer()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `(string Original, string Ai).Ai`；`(string Original, string Ai).Original`；`NationalSpire.AiGeneratedText.Different(string, string)`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.Cards`；`NationalSpire.CareerResult.Day`；`NationalSpire.CareerResult.Event`；`NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerResult.PlayedAscension`；`NationalSpire.CareerResult.RunSeconds`；`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；`NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.CoachLineups.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.CoachLineups.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunitySharing.Kind`；`NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.MatchRules.Time(double?)`；`NationalSpire.OathAttachments.Kind`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.AiDetail`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.PostRevision`；`NationalSpire.PrivateOffer.Quote`；`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiGeneratedText.Different(string, string)`；输入表达式：`AiGeneratedText.Different(a.Detail, p.Title + "\n" + text.Ai)`；返回值紧邻使用处：`AssignmentExpressionSyntax: a.AiDetail = AiGeneratedText.Different(a.Detail, p.Title + "\n" + text.Ai)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, person)!`
- `NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；输入表达式：`ChatAttachments.Prepare(data, person, a)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ChatAttachments.Prepare(data, person, a) is { } error`
- `NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`ClubCoaching.TrainingError(data, person, a)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ClubCoaching.TrainingError(data, person, a) is { } error`
- `NationalSpire.CoachLineups.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`CoachLineups.Error(data, person, a)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CoachLineups.Error(data, person, a) is { } error`
- `NationalSpire.CoachLineups.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`CoachLineups.Prepare(data, a)`；返回值紧邻使用处：`AssignmentExpressionSyntax: a.Detail = CoachLineups.Prepare(data, a)`
- `NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`CommunitySharing.Prepare(data, prepared)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CommunitySharing.Prepare(data, prepared) is { } error`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).FirstOrDefault`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, r.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, r.Day)}`
- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`MatchRules.Time(r.RunSeconds)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.Time(r.RunSeconds)}`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.CanOperate(data)`
- `NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Error(data, person, a)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateAppointments.Error(data, person, a) is { } error`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = a.Kind, Quote = a.Quote }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = a.Kind, Quote = a.Quote }`
- `NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?, bool)`；输入表达式：`PrivatePublicContext.PostTexts(data, p, CareerEngine.Person(data, person)!)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivatePublicContext.PostTexts(data, p, CareerEngine.Person(data, person)!)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", r.Cards.Take(8))`；返回值紧邻使用处：`BinaryExpressionSyntax: $"{GameCalendar.Text(data, r.Day)} · {r.Event} · {r.Outcome} · 进阶{r.PlayedAscension ?? r.Ascension} · 第{r.Floor}层 · {MatchRules.Time(r.RunSeconds)}\n" + string.Join("、", r.Cards.Take(8))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).FirstOrDefault(p => p.Id == a.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).FirstOrDefault(p => p.Id == a.MatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Results.FirstOrDefault(r => r.MatchId == a.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Results.FirstOrDefault(r => r.MatchId == a.MatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`r.Cards.Take(8)`；返回值紧邻使用处：`ArgumentSyntax: r.Cards.Take(8)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`quotes.Add((a, prepared))`；返回值紧邻使用处：`ExpressionStatementSyntax: quotes.Add((a, prepared));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(PrivateOffer Target, PrivateOffer Prepared)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(PrivateOffer Target, PrivateOffer Prepared)>()`

**赋值（含属性/字段和局部值）：**

- `a.AiDetail` = `AiGeneratedText.Different(a.Detail, p.Title + "\n" + text.Ai)`
- `a.Detail` = `$"{GameCalendar.Text(data, r.Day)} · {r.Event} · {r.Outcome} · 进阶{r.PlayedAscension ?? r.Ascension} · 第{r.Floor}层 · {MatchRules.Time(r.RunSeconds)}\n" + string.Join("、", r.Cards.Take(8))`
- `a.Detail` = `CoachLineups.Prepare(data, a)`
- `a.Detail` = `p.Title + "\n" + text.Original`
- `a.PostRevision` = `p.Revision`
- `Kind` = `a.Kind`
- `Quote` = `a.Quote`
- `target.AiDetail` = `prepared.AiDetail`
- `target.Detail` = `prepared.Detail`
- `target.MatchId` = `prepared.MatchId`
- `target.PostRevision` = `prepared.PostRevision`
- `target.Quote` = `prepared.Quote`

<a id="symbol-125ddcdf1602"></a>

## `NationalSpire.PrivateMessages.AttachmentTitle(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string AttachmentTitle(CareerData data, PrivateOffer a)`

来源：源码第 178 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-5c877df45b85)；[`NationalSpire.CareerScreen.PrivateAttachmentHeading(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-a28ca2e86dec)；[`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChatPrompts.cs.md#symbol-28b2a2534bee)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.CareerData, NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`](PrivateMessagePrompts.cs.md#symbol-2e632c46656c)

**调用：** [`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityQuote.ReplyId`；`NationalSpire.CommunityReporting.Kind`；`NationalSpire.CommunitySharing.Kind`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.OathAttachments.Kind`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Ascension`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.Quantity`；`NationalSpire.PrivateOffer.Quote`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.Weeks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, PrivateAppointments.Date(data, a))`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, PrivateAppointments.Date(data, a))}`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, a)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.Date(data, a)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2b57951bede9"></a>

## `NationalSpire.PrivateMessages.Manage(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, NationalSpire.PrivateMessageCommand) — public static string? Manage(CareerData data, PrivateConversation c, string kind, PrivateMessageCommand command)`

来源：源码第 187 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.PrivateMessages.Completed(NationalSpire.PrivateConversation)`](PrivateMessages.cs.md#symbol-3f3045d6546b)；[`NationalSpire.PrivateMessages.RemoveDeletedOffers(NationalSpire.PrivateConversation)`](PrivateMessages.cs.md#symbol-b239ace74471)；[`NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`](PrivateMessageData.cs.md#symbol-db2a1a2d7b09)；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.ContextStart`；`NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.SeenCount`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.SummaryError`；`NationalSpire.PrivateConversation.SummaryRequest`；`NationalSpire.PrivateConversation.SummaryStatus`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.Text`；`NationalSpire.PrivateMessages.Completed(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateMessages.RemoveDeletedOffers(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Id`；`NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateSummary.Through`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.Context`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Reasoning`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Request`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Completed(NationalSpire.PrivateConversation)`；输入表达式：`Completed(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: Completed(c) == 0`
- `NationalSpire.PrivateMessages.RemoveDeletedOffers(NationalSpire.PrivateConversation)`；输入表达式：`RemoveDeletedOffers(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveDeletedOffers(c);`
- `NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；输入表达式：`summary.IsLatest(c.SmallSummaries.Concat(c.BigSummaries))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = summary.IsLatest(c.SmallSummaries.Concat(c.BigSummaries))`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(command.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: !delete && string.IsNullOrWhiteSpace(command.Text)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(command.Text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(command.Text)) return "总结不能为空。";`
- `string.Trim()`；输入表达式：`command.Text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: summary.Text = command.Text.Trim()`
- `string.Trim()`；输入表达式：`command.Text.Trim()`；返回值紧邻使用处：`ConditionalExpressionSyntax: delete ? "" : command.Text.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.SmallSummaries.Concat(c.BigSummaries).Any(s => s.From <= summary.From && s.Through >= summary.Through)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.SmallSummaries.Concat(c.BigSummaries).Any(s => s.From <= summary.From && s.Through >= summary.Through)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`IfStatementSyntax: if (c.Turns.Any(t => t.Status is "queued" or "sending")) return "请先等待回复完成，或停止生成。";`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`c.SmallSummaries.Concat(c.BigSummaries)`；返回值紧邻使用处：`ArgumentSyntax: c.SmallSummaries.Concat(c.BigSummaries)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`c.SmallSummaries.Concat(c.BigSummaries)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.SmallSummaries.Concat(c.BigSummaries).Any`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Count(t => t.Status == "complete")`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.SeenCount = c.Turns.Count(t => t.Status == "complete")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.FirstOrDefault(t => t.Id == command.Entry)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.FirstOrDefault(t => t.Id == command.Entry)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`list.FirstOrDefault(s => s.Id == command.Entry)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = list.FirstOrDefault(s => s.Id == command.Entry)`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`t.Attachments.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: t.Attachments.Clear();`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`list.Remove(summary)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.Remove(summary);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(c.ContextStart, summary.From)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.ContextStart = Math.Min(c.ContextStart, summary.From)`

**赋值（含属性/字段和局部值）：**

- `c.ContextStart` = `c.Turns.Count`
- `c.ContextStart` = `Math.Min(c.ContextStart, summary.From)`
- `c.SeenCount` = `c.Turns.Count(t => t.Status == "complete")`
- `c.SummaryError` = `""`
- `c.SummaryRequest` = `command.Part == "big" ? "big" : "small"`
- `summary.Text` = `command.Text.Trim()`
- `t.Context` = `""`
- `t.Context` = `t.Reasoning = ""`
- `t.Reasoning` = `""`
- `t.Reply` = `delete ? "" : command.Text.Trim()`
- `t.Reply` = `t.Context = t.Reasoning = ""`
- `t.ReplyDeleted` = `delete`
- `t.ReplyDeleted` = `true`
- `t.Request` = `null`
- `t.User` = `delete ? "" : command.Text.Trim()`
- `t.User` = `t.Reply = t.Context = t.Reasoning = ""`
- `t.UserDeleted` = `delete`
- `t.UserDeleted` = `t.ReplyDeleted = true`

<a id="symbol-50e1856a4dce"></a>

## `NationalSpire.PrivateMessages.FinishSmallSummary(NationalSpire.PrivateConversation, NationalSpire.PrivateHistorySettings, int, string) — public static void FinishSmallSummary(PrivateConversation c, PrivateHistorySettings settings, int snapshotEnd, string text)`

来源：源码第 230 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)

**调用：** `NationalSpire.PrivateSummary.PrivateSummary()`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `(NationalSpire.PrivateTurn t, int i).i`；`(NationalSpire.PrivateTurn t, int i).t`；`NationalSpire.PrivateConversation.ContextStart`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.SummaryError`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateHistorySettings.RecentRounds`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateSummary.Through`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateSummary.PrivateSummary()`；输入表达式：`new() { Text = text.Trim(), From = c.ContextStart, Through = snapshotEnd }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = text.Trim(), From = c.ContextStart, Through = snapshotEnd }`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(text)) throw new InvalidDataException("聊天总结返回了空内容。");`
- `string.Trim()`；输入表达式：`text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = text.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`c.Turns.Select((t, i) => (t, i))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Select((t, i) => (t, i)).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`c.Turns.Select((t, i) => (t, i)).Where(x => x.t.Status == "complete" && !(x.t.UserDeleted && x.t.ReplyDeleted)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.Select((t, i) => (t, i)).Where(x => x.t.Status == "complete" && !(x.t.UserDeleted && x.t.ReplyDeleted)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Select((t, i) => (t, i)).Where(x => x.t.Status == "complete" && !(x.t.UserDeleted && x.t.ReplyDeleted))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Select((t, i) => (t, i)).Where(x => x.t.Status == "complete" && !(x.t.UserDeleted && x.t.ReplyDeleted)).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.SmallSummaries.Add(new() { Text = text.Trim(), From = c.ContextStart, Through = snapshotEnd })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.SmallSummaries.Add(new() { Text = text.Trim(), From = c.ContextStart, Through = snapshotEnd });`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("聊天总结返回了空内容。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("聊天总结返回了空内容。");`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(c.ContextStart, Math.Min(snapshotEnd, recent))`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.ContextStart = Math.Max(c.ContextStart, Math.Min(snapshotEnd, recent))`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(snapshotEnd, recent)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(snapshotEnd, recent)`

**赋值（含属性/字段和局部值）：**

- `c.ContextStart` = `Math.Max(c.ContextStart, Math.Min(snapshotEnd, recent))`
- `c.SummaryError` = `""`
- `From` = `c.ContextStart`
- `Text` = `text.Trim()`
- `Through` = `snapshotEnd`

<a id="symbol-171af55402a5"></a>

## `NationalSpire.PrivateMessages.FinishBigSummary(NationalSpire.PrivateConversation, System.Collections.Generic.IReadOnlyCollection<string>, string) — public static void FinishBigSummary(PrivateConversation c, IReadOnlyCollection<string> ids, string text)`

来源：源码第 239 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)

**调用：** `NationalSpire.PrivateSummary.PrivateSummary()`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.SummaryError`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Id`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateSummary.Through`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateSummary.PrivateSummary()`；输入表达式：`new() { Text = text.Trim(), From = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Min(s => s.From), Through = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Max(s => s.Through) }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = text.Trim(), From = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Min(s => s.From), Through = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Max(s => s.Through) }`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(text)) throw new InvalidDataException("长期总结返回了空内容。");`
- `string.Trim()`；输入表达式：`text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = text.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`ids.All(id => c.SmallSummaries.Any(s => s.Id == id))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ids.All(id => c.SmallSummaries.Any(s => s.Id == id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.SmallSummaries.Any(s => s.Id == id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => c.SmallSummaries.Any(s => s.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`ids.Contains(s.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => ids.Contains(s.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, int>)`；输入表达式：`c.SmallSummaries.Where(s => ids.Contains(s.Id)).Max(s => s.Through)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Through = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Max(s => s.Through)`
- `System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, int>)`；输入表达式：`c.SmallSummaries.Where(s => ids.Contains(s.Id)).Min(s => s.From)`；返回值紧邻使用处：`AssignmentExpressionSyntax: From = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Min(s => s.From)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.SmallSummaries.Where(s => ids.Contains(s.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.SmallSummaries.Where(s => ids.Contains(s.Id)).Max`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.SmallSummaries.Where(s => ids.Contains(s.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.SmallSummaries.Where(s => ids.Contains(s.Id)).Min`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.BigSummaries.Add(new() { Text = text.Trim(), From = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Min(s => s.From), Through = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Max(s => s.Through) })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.BigSummaries.Add(new() { Text = text.Trim(), From = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Min(s => s.From), Through = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Max(s => s.Through) });`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`c.SmallSummaries.RemoveAll(s => ids.Contains(s.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: c.SmallSummaries.RemoveAll(s => ids.Contains(s.Id));`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("长期总结返回了空内容。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("长期总结返回了空内容。");`

**赋值（含属性/字段和局部值）：**

- `c.SummaryError` = `""`
- `From` = `c.SmallSummaries.Where(s => ids.Contains(s.Id)).Min(s => s.From)`
- `Text` = `text.Trim()`
- `Through` = `c.SmallSummaries.Where(s => ids.Contains(s.Id)).Max(s => s.Through)`

<a id="symbol-7bf623828ccc"></a>

## `NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?) — public static void Apply(CareerData data, PrivateConversation c, PrivateTurn turn, IReadOnlyList<Dictionary<string, string>> directives, int? originalFavour = null)`

来源：源码第 246 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`](CareerTraining.cs.md#symbol-cd61283f2c46)；[`NationalSpire.CareerTraining.RecordLesson(NationalSpire.CareerData, string, NationalSpire.PrivateLearning)`](CareerTraining.cs.md#symbol-20ac1d8e57c7)；[`NationalSpire.CareerTraining.RecordMood(NationalSpire.CareerData, string, NationalSpire.PrivateMood)`](CareerTraining.cs.md#symbol-ef124ea1d16b)；[`NationalSpire.ChatAttachments.Gift(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](ChatAttachments.cs.md#symbol-cc6db06cee88)；[`NationalSpire.ClubCoaching.AcceptTraining(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](ClubCoaching.cs.md#symbol-fc1017e0877c)；[`NationalSpire.CoachLineups.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](CoachLineups.cs.md#symbol-902b00bf585f)；[`NationalSpire.OathAttachments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](OathAttachments.cs.md#symbol-80bb2ac38dee)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`NationalSpire.PrivateAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>, string)`](PrivateAppointments.cs.md#symbol-32d5ee024249)；[`NationalSpire.PrivateContracts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-dbd791b573e7)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`](PrivateInteractionUndo.cs.md#symbol-25f3da26ec8f)；[`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-9eda496612ca)；[`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`](PrivateMessageData.cs.md#symbol-2a4d65cc20f8)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；[`NationalSpire.PrivateMessages.FavourTarget(System.Collections.Generic.Dictionary<string, string>)`](PrivateMessages.cs.md#symbol-7c897c933b2f)；[`NationalSpire.PrivateMessages.Money(System.Collections.Generic.Dictionary<string, string>, string)`](PrivateMessages.cs.md#symbol-38c108fc097f)；[`NationalSpire.PrivateMessages.Number(System.Collections.Generic.Dictionary<string, string>, string)`](PrivateMessages.cs.md#symbol-70e2aa1cfa91)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange)`](PrivateProfileChanges.cs.md#symbol-c409575d5f79)；[`NationalSpire.SocialAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](SocialAppointments.cs.md#symbol-33a4725630bd)；[`NationalSpire.SpireArbitration.ShockDay(NationalSpire.CareerPerson, int)`](SpireArbitration.cs.md#symbol-fe9f0ad5c9c7)；`int.TryParse(string?, out int)`；`NationalSpire.PrivateLearning.PrivateLearning()`；`NationalSpire.PrivateMood.PrivateMood()`；`NationalSpire.PrivateOffer.PrivateOffer()`；`NationalSpire.PrivateProfileChange.PrivateProfileChange()`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Abs(int)`；`System.Math.Abs(long)`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；`NationalSpire.CareerTraining.RecordLesson(NationalSpire.CareerData, string, NationalSpire.PrivateLearning)`；`NationalSpire.CareerTraining.RecordMood(NationalSpire.CareerData, string, NationalSpire.PrivateMood)`；`NationalSpire.ChatAttachments.Gift(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.ClubCoaching.AcceptTraining(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.CoachLineups.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.OathAttachments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.PrivateAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>, string)`；`NationalSpire.PrivateContracts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`；`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateLearning.Id`；`NationalSpire.PrivateLearning.Reason`；`NationalSpire.PrivateLearning.Source`；`NationalSpire.PrivateLearning.Strength`；`NationalSpire.PrivateLearning.Topic`；`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.FavourTarget(System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.PrivateMessages.Money(System.Collections.Generic.Dictionary<string, string>, string)`；`NationalSpire.PrivateMessages.Number(System.Collections.Generic.Dictionary<string, string>, string)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMood.Day`；`NationalSpire.PrivateMood.Days`；`NationalSpire.PrivateMood.Id`；`NationalSpire.PrivateMood.Reason`；`NationalSpire.PrivateMood.Source`；`NationalSpire.PrivateMood.Strength`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.FavourBefore`；`NationalSpire.PrivateOffer.FavourTargets`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Role`；`NationalSpire.PrivateOffer.Signing`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateOffer.Wage`；`NationalSpire.PrivateOffer.Weeks`；`NationalSpire.PrivateOffer.WinBonus`；`NationalSpire.PrivateProfileChange.After`；`NationalSpire.PrivateProfileChange.Field`；`NationalSpire.PrivateProfileChange.Reason`；`NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Impression`；`NationalSpire.PrivateRelation.Relationship`；`NationalSpire.PrivateRelation.Revision`；`NationalSpire.PrivateTurn.Applied`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Learning`；`NationalSpire.PrivateTurn.Mood`；`NationalSpire.PrivateTurn.ProfileChanges`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.SocialAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.SpireArbitration.ShockDay(NationalSpire.CareerPerson, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(fields.GetValueOrDefault("Days"), out int parsedDays)`；返回值紧邻使用处：`BinaryExpressionSyntax: int.TryParse(fields.GetValueOrDefault("Days"), out int parsedDays) && parsedDays is >= 7 and <= 21`
- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(moodValue, out int parsedMood)`；返回值紧邻使用处：`BinaryExpressionSyntax: int.TryParse(moodValue, out int parsedMood) && parsedMood is >= -3 and <= 3`
- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(strength, out int amount)`；返回值紧邻使用处：`BinaryExpressionSyntax: int.TryParse(strength, out int amount) && amount != 0`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, c.PersonId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, c.PersonId)!`
- `NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；输入表达式：`CareerTraining.MoodLevel(CareerEngine.Person(data, c.PersonId)!, data.Day)`；返回值紧邻使用处：`ArgumentSyntax: CareerTraining.MoodLevel(CareerEngine.Person(data, c.PersonId)!, data.Day)`
- `NationalSpire.CareerTraining.RecordLesson(NationalSpire.CareerData, string, NationalSpire.PrivateLearning)`；输入表达式：`CareerTraining.RecordLesson(data, c.PersonId, lesson)`；返回值紧邻使用处：`IfStatementSyntax: if (CareerTraining.RecordLesson(data, c.PersonId, lesson)) turn.Learning = lesson;`
- `NationalSpire.CareerTraining.RecordMood(NationalSpire.CareerData, string, NationalSpire.PrivateMood)`；输入表达式：`CareerTraining.RecordMood(data, c.PersonId, change)`；返回值紧邻使用处：`IfStatementSyntax: if (CareerTraining.RecordMood(data, c.PersonId, change)) turn.Mood = change;`
- `NationalSpire.ChatAttachments.Gift(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`ChatAttachments.Gift(data, c, turn, fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: ChatAttachments.Gift(data, c, turn, fields);`
- `NationalSpire.ClubCoaching.AcceptTraining(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`ClubCoaching.AcceptTraining(data, c, turn, fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubCoaching.AcceptTraining(data, c, turn, fields);`
- `NationalSpire.CoachLineups.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`CoachLineups.Respond(data, c, turn, fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoachLineups.Respond(data, c, turn, fields);`
- `NationalSpire.OathAttachments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`OathAttachments.Respond(data, c, turn, fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: OathAttachments.Respond(data, c, turn, fields);`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.TryGetValue("Contract", out var contract) && contract == "要价" && OwnedClubs.CanOperate(data)`
- `NationalSpire.PrivateAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>, string)`；输入表达式：`PrivateAppointments.Respond(data, c, turn, fields, action)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateAppointments.Respond(data, c, turn, fields, action);`
- `NationalSpire.PrivateContracts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`PrivateContracts.Error(data, c.PersonId, offer)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateContracts.Error(data, c.PersonId, offer) is { } error`
- `NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`；输入表达式：`PrivateInteractionHistory.Capture(data, c.PersonId, gifts: directives.Any(f => f.ContainsKey("Gift") || f.ContainsKey("Activity")))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateInteractionHistory.Capture(data, c.PersonId, gifts: directives.Any(f => f.ContainsKey("Gift") || f.ContainsKey("Activity")))`
- `NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；输入表达式：`PrivateInteractionHistory.Record(data, c.PersonId, turn, before)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.Record(data, c.PersonId, turn, before);`
- `NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；输入表达式：`PrivateInteractionIds.Ensure(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionIds.Ensure(c);`
- `NationalSpire.PrivateLearning.PrivateLearning()`；输入表达式：`new PrivateLearning { Id = turn.Id, Source = source, Topic = topic, Strength = amount, Reason = reason }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateLearning { Id = turn.Id, Source = source, Topic = topic, Strength = amount, Reason = reason }`
- `NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；输入表达式：`ChangeFavour(data, c.PersonId, target - relation.Favour)`；返回值紧邻使用处：`ExpressionStatementSyntax: ChangeFavour(data, c.PersonId, target - relation.Favour);`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`Favour(data, c.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Favour(data, c.PersonId)`
- `NationalSpire.PrivateMessages.FavourTarget(System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`FavourTarget(fields)`；返回值紧邻使用处：`IsPatternExpressionSyntax: FavourTarget(fields) is int target`
- `NationalSpire.PrivateMessages.Money(System.Collections.Generic.Dictionary<string, string>, string)`；输入表达式：`Money(fields, "Signing")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Signing = Money(fields, "Signing")`
- `NationalSpire.PrivateMessages.Money(System.Collections.Generic.Dictionary<string, string>, string)`；输入表达式：`Money(fields, "Wage")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Wage = Money(fields, "Wage")`
- `NationalSpire.PrivateMessages.Money(System.Collections.Generic.Dictionary<string, string>, string)`；输入表达式：`Money(fields, "WinBonus")`；返回值紧邻使用处：`AssignmentExpressionSyntax: WinBonus = Money(fields, "WinBonus")`
- `NationalSpire.PrivateMessages.Number(System.Collections.Generic.Dictionary<string, string>, string)`；输入表达式：`Number(fields, "Weeks")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Weeks = Number(fields, "Weeks")`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`Relation(data, c.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Relation(data, c.PersonId)`
- `NationalSpire.PrivateMood.PrivateMood()`；输入表达式：`new PrivateMood { Id = turn.Id, Strength = mood, Day = data.Day, Days = days, Reason = reason,                      Source = turn.Id }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateMood { Id = turn.Id, Strength = mood, Day = data.Day, Days = days, Reason = reason,                      Source = turn.Id }`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = "contract", TurnId = turn.Id, Signing = Money(fields, "Signing"), Wage = Money(fields, "Wage"), WinBonus = Money(fields, "WinBonus"), Weeks = Number(fields, "Weeks"), Role = fields.GetValueOrDefault("Role", "轮换") }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = "contract", TurnId = turn.Id, Signing = Money(fields, "Signing"), Wage = Money(fields, "Wage"), WinBonus = Money(fields, "WinBonus"), Weeks = Number(fields, "Weeks"), Role = fields.GetValueOrDefault("Role", "轮换") }`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Kind = "favour", TurnId = turn.Id, FavourBefore = favourBefore, FavourTargets = favourTargets }`；返回值紧邻使用处：`ArgumentSyntax: new() { Kind = "favour", TurnId = turn.Id, FavourBefore = favourBefore, FavourTargets = favourTargets }`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Kind = "publish", TurnId = turn.Id, Title = title, Detail = body }`；返回值紧邻使用处：`ArgumentSyntax: new() { Kind = "publish", TurnId = turn.Id, Title = title, Detail = body }`
- `NationalSpire.PrivateProfileChange.PrivateProfileChange()`；输入表达式：`new PrivateProfileChange { Field = field, After = fields.GetValueOrDefault("Value", ""), Reason = fields.GetValueOrDefault("Reason", "") }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateProfileChange { Field = field, After = fields.GetValueOrDefault("Value", ""), Reason = fields.GetValueOrDefault("Reason", "") }`
- `NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange)`；输入表达式：`PrivateProfileChanges.Apply(person, change)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateProfileChanges.Apply(person, change)`
- `NationalSpire.SocialAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`SocialAppointments.Respond(data, c, turn, fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: SocialAppointments.Respond(data, c, turn, fields);`
- `NationalSpire.SpireArbitration.ShockDay(NationalSpire.CareerPerson, int)`；输入表达式：`SpireArbitration.ShockDay(CareerEngine.Person(data, c.PersonId)!, data.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: SpireArbitration.ShockDay(CareerEngine.Person(data, c.PersonId)!, data.Day) >= 0`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(body)`；返回值紧邻使用处：`BinaryExpressionSyntax: turn.Status != "complete" || turn.ReplyDeleted || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(body)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(title)`；返回值紧邻使用处：`BinaryExpressionSyntax: turn.Status != "complete" || turn.ReplyDeleted || string.IsNullOrWhiteSpace(title)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(turn.Reply)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(turn.Reply)`
- `string.Trim()`；输入表达式：`fields.GetValueOrDefault("Reason", "").Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fields.GetValueOrDefault("Reason", "").Trim()`
- `string.Trim()`；输入表达式：`fields.GetValueOrDefault("Topic", "").Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fields.GetValueOrDefault("Topic", "").Trim()`
- `string.Trim()`；输入表达式：`impression.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation.Impression = impression.Trim()`
- `string.Trim()`；输入表达式：`label.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation.Relationship = label.Trim()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`f.ContainsKey("Activity")`；返回值紧邻使用处：`BinaryExpressionSyntax: f.ContainsKey("Gift") || f.ContainsKey("Activity")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`f.ContainsKey("Gift")`；返回值紧邻使用处：`BinaryExpressionSyntax: f.ContainsKey("Gift") || f.ContainsKey("Activity")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Activity")`；返回值紧邻使用处：`IfStatementSyntax: if (fields.ContainsKey("Activity")) SocialAppointments.Respond(data, c, turn, fields);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Attitude")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Favour")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Gift")`；返回值紧邻使用处：`IfStatementSyntax: if (fields.ContainsKey("Gift")) ChatAttachments.Gift(data, c, turn, fields);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Lineup")`；返回值紧邻使用处：`IfStatementSyntax: if (fields.ContainsKey("Lineup")) CoachLineups.Respond(data, c, turn, fields);              else if (fields.TryGetValue("Post", out var publication) && publication == "发布")              {                  string title = fields.GetValueOrDefault("Title", ""), body = fields.GetValueOrDefault("Body", "");                  if (turn.Status != "complete" || turn.ReplyDeleted || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(body)) { turn.Error = "帖子缺少标题或正文，未发布。"; continue; }                  c.Offers.Add(new() { Kind = "publish", TurnId = turn.Id, Title = title, Detail = body });              }              else if (fields.TryGetValue("Profile", out var field))              {                  var change = new PrivateProfileChange { Field = field, After = fields.GetValueOrDefault("Value", ""), Reason = fields.GetValueOrDefault("Reason", "") };                  var person = CareerEngine.Person(data, c.PersonId)!;                  if (turn.Status != "complete" || !PrivateProfileChanges.Apply(person, change)) { turn.Error = "档案变化字段或内容无效，未执行。"; continue; }                  turn.ProfileChanges.Add(change);              }              else if (fields.TryGetValue("Mood", out var moodValue) && turn.Mood == null)              {                  string reason = fields.GetValueOrDefault("Reason", "").Trim();                  if (turn.Status != "complete") continue;                  int mood = int.TryParse(moodValue, out int parsedMood) && parsedMood is >= -3 and <= 3                      ? parsedMood : (int)Math.Round(CareerTraining.MoodLevel(CareerEngine.Person(data, c.PersonId)!, data.Day));                  int days = int.TryParse(fields.GetValueOrDefault("Days"), out int parsedDays) && parsedDays is >= 7 and <= 21 ? parsedDays : 14;                  if (SpireArbitration.ShockDay(CareerEngine.Person(data, c.PersonId)!, data.Day) >= 0)                  { turn.Error += "\n仲裁处罚期间维持最低状态，本次普通状态更新未执行。"; continue; }                  var change = new PrivateMood { Id = turn.Id, Strength = mood, Day = data.Day, Days = days, Reason = reason,                      Source = turn.Id };                  if (CareerTraining.RecordMood(data, c.PersonId, change)) turn.Mood = change;              }              else if (fields.TryGetValue("Skill", out var strength) && turn.Learning == null)              {                  string reason = fields.GetValueOrDefault("Reason", "").Trim();                  string topic = fields.GetValueOrDefault("Topic", "").Trim();                  bool valid = int.TryParse(strength, out int amount) && amount != 0 && Math.Abs((long)amount) <= 3                      && turn.Status == "complete" && !turn.ReplyDeleted && !string.IsNullOrWhiteSpace(turn.Reply);                  if (topic.Length == 0) topic = "综合";                  if (!valid) { turn.Error = "水平变化程度无效，请填写 -3 至 -1 或 1 至 3。"; continue; }                  string source = turn.Id;                  var lesson = new PrivateLearning { Id = turn.Id, Source = source, Topic = topic, Strength = amount, Reason = reason };                  if (CareerTraining.RecordLesson(data, c.PersonId, lesson)) turn.Learning = lesson;              }              else if (fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship"))              {                  var relation = Relation(data, c.PersonId);                  if (!confirmFavour && FavourTarget(fields) is int target)                      ChangeFavour(data, c.PersonId, target - relation.Favour);                  if (fields.TryGetValue("Attitude", out var impression)) relation.Impression = impression.Trim();                  if (fields.TryGetValue("Relationship", out var label)) relation.Relationship = label.Trim();                  relation.Revision++;              }              else if (fields.TryGetValue("Match", out var action))              {                  PrivateAppointments.Respond(data, c, turn, fields, action);              }              else if (fields.TryGetValue("Contract", out var contract) && contract == "要价" && OwnedClubs.CanOperate(data))              {                  var offer = new PrivateOffer { Kind = "contract", TurnId = turn.Id, Signing = Money(fields, "Signing"), Wage = Money(fields, "Wage"), WinBonus = Money(fields, "WinBonus"), Weeks = Number(fields, "Weeks"), Role = fields.GetValueOrDefault("Role", "轮换") };                  if (PrivateContracts.Error(data, c.PersonId, offer) is { } error) { offer.State = "无效"; offer.Detail = error; }                  c.Offers.Add(offer);              }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Oath")`；返回值紧邻使用处：`IfStatementSyntax: if (fields.ContainsKey("Oath")) OathAttachments.Respond(data, c, turn, fields);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Relationship")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Training")`；返回值紧邻使用处：`IfStatementSyntax: if (fields.ContainsKey("Training")) ClubCoaching.AcceptTraining(data, c, turn, fields);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Attitude", out var impression)`；返回值紧邻使用处：`IfStatementSyntax: if (fields.TryGetValue("Attitude", out var impression)) relation.Impression = impression.Trim();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Contract", out var contract)`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.TryGetValue("Contract", out var contract) && contract == "要价"`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Match", out var action)`；返回值紧邻使用处：`IfStatementSyntax: if (fields.TryGetValue("Match", out var action))              {                  PrivateAppointments.Respond(data, c, turn, fields, action);              }              else if (fields.TryGetValue("Contract", out var contract) && contract == "要价" && OwnedClubs.CanOperate(data))              {                  var offer = new PrivateOffer { Kind = "contract", TurnId = turn.Id, Signing = Money(fields, "Signing"), Wage = Money(fields, "Wage"), WinBonus = Money(fields, "WinBonus"), Weeks = Number(fields, "Weeks"), Role = fields.GetValueOrDefault("Role", "轮换") };                  if (PrivateContracts.Error(data, c.PersonId, offer) is { } error) { offer.State = "无效"; offer.Detail = error; }                  c.Offers.Add(offer);              }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Mood", out var moodValue)`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.TryGetValue("Mood", out var moodValue) && turn.Mood == null`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Post", out var publication)`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.TryGetValue("Post", out var publication) && publication == "发布"`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Profile", out var field)`；返回值紧邻使用处：`IfStatementSyntax: if (fields.TryGetValue("Profile", out var field))              {                  var change = new PrivateProfileChange { Field = field, After = fields.GetValueOrDefault("Value", ""), Reason = fields.GetValueOrDefault("Reason", "") };                  var person = CareerEngine.Person(data, c.PersonId)!;                  if (turn.Status != "complete" || !PrivateProfileChanges.Apply(person, change)) { turn.Error = "档案变化字段或内容无效，未执行。"; continue; }                  turn.ProfileChanges.Add(change);              }              else if (fields.TryGetValue("Mood", out var moodValue) && turn.Mood == null)              {                  string reason = fields.GetValueOrDefault("Reason", "").Trim();                  if (turn.Status != "complete") continue;                  int mood = int.TryParse(moodValue, out int parsedMood) && parsedMood is >= -3 and <= 3                      ? parsedMood : (int)Math.Round(CareerTraining.MoodLevel(CareerEngine.Person(data, c.PersonId)!, data.Day));                  int days = int.TryParse(fields.GetValueOrDefault("Days"), out int parsedDays) && parsedDays is >= 7 and <= 21 ? parsedDays : 14;                  if (SpireArbitration.ShockDay(CareerEngine.Person(data, c.PersonId)!, data.Day) >= 0)                  { turn.Error += "\n仲裁处罚期间维持最低状态，本次普通状态更新未执行。"; continue; }                  var change = new PrivateMood { Id = turn.Id, Strength = mood, Day = data.Day, Days = days, Reason = reason,                      Source = turn.Id };                  if (CareerTraining.RecordMood(data, c.PersonId, change)) turn.Mood = change;              }              else if (fields.TryGetValue("Skill", out var strength) && turn.Learning == null)              {                  string reason = fields.GetValueOrDefault("Reason", "").Trim();                  string topic = fields.GetValueOrDefault("Topic", "").Trim();                  bool valid = int.TryParse(strength, out int amount) && amount != 0 && Math.Abs((long)amount) <= 3                      && turn.Status == "complete" && !turn.ReplyDeleted && !string.IsNullOrWhiteSpace(turn.Reply);                  if (topic.Length == 0) topic = "综合";                  if (!valid) { turn.Error = "水平变化程度无效，请填写 -3 至 -1 或 1 至 3。"; continue; }                  string source = turn.Id;                  var lesson = new PrivateLearning { Id = turn.Id, Source = source, Topic = topic, Strength = amount, Reason = reason };                  if (CareerTraining.RecordLesson(data, c.PersonId, lesson)) turn.Learning = lesson;              }              else if (fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship"))              {                  var relation = Relation(data, c.PersonId);                  if (!confirmFavour && FavourTarget(fields) is int target)                      ChangeFavour(data, c.PersonId, target - relation.Favour);                  if (fields.TryGetValue("Attitude", out var impression)) relation.Impression = impression.Trim();                  if (fields.TryGetValue("Relationship", out var label)) relation.Relationship = label.Trim();                  relation.Revision++;              }              else if (fields.TryGetValue("Match", out var action))              {                  PrivateAppointments.Respond(data, c, turn, fields, action);              }              else if (fields.TryGetValue("Contract", out var contract) && contract == "要价" && OwnedClubs.CanOperate(data))              {                  var offer = new PrivateOffer { Kind = "contract", TurnId = turn.Id, Signing = Money(fields, "Signing"), Wage = Money(fields, "Wage"), WinBonus = Money(fields, "WinBonus"), Weeks = Number(fields, "Weeks"), Role = fields.GetValueOrDefault("Role", "轮换") };                  if (PrivateContracts.Error(data, c.PersonId, offer) is { } error) { offer.State = "无效"; offer.Detail = error; }                  c.Offers.Add(offer);              }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Relationship", out var label)`；返回值紧邻使用处：`IfStatementSyntax: if (fields.TryGetValue("Relationship", out var label)) relation.Relationship = label.Trim();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Skill", out var strength)`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.TryGetValue("Skill", out var strength) && turn.Learning == null`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`directives.Any(f => f.ContainsKey("Gift") || f.ContainsKey("Activity"))`；返回值紧邻使用处：`ArgumentSyntax: gifts: directives.Any(f => f.ContainsKey("Gift") || f.ContainsKey("Activity"))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`directives.Select(FavourTarget)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: directives.Select(FavourTarget).OfType<int>`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`directives.Select(FavourTarget).OfType<int>().ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = directives.Select(FavourTarget).OfType<int>().ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Body", "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fields.GetValueOrDefault("Body", "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Reason", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Reason = fields.GetValueOrDefault("Reason", "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Reason", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: fields.GetValueOrDefault("Reason", "").Trim`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Role", "轮换")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Role = fields.GetValueOrDefault("Role", "轮换")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Title", "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fields.GetValueOrDefault("Title", "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Topic", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: fields.GetValueOrDefault("Topic", "").Trim`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Value", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: After = fields.GetValueOrDefault("Value", "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Days")`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault("Days")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Offers.Add(new() { Kind = "favour", TurnId = turn.Id, FavourBefore = favourBefore, FavourTargets = favourTargets })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Add(new() { Kind = "favour", TurnId = turn.Id, FavourBefore = favourBefore, FavourTargets = favourTargets });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Offers.Add(new() { Kind = "publish", TurnId = turn.Id, Title = title, Detail = body })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Add(new() { Kind = "publish", TurnId = turn.Id, Title = title, Detail = body });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Offers.Add(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Add(offer);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`turn.ProfileChanges.Add(change)`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.ProfileChanges.Add(change);`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`directives.Select(FavourTarget).OfType<int>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: directives.Select(FavourTarget).OfType<int>().ToList`
- `System.Math.Abs(int)`；输入表达式：`Math.Abs(preceding - favourBefore)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(preceding - favourBefore) > 10`
- `System.Math.Abs(int)`；输入表达式：`Math.Abs(target - preceding)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(target - preceding) > 10`
- `System.Math.Abs(long)`；输入表达式：`Math.Abs((long)amount)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs((long)amount) <= 3`
- `System.Math.Round(double)`；输入表达式：`Math.Round(CareerTraining.MoodLevel(CareerEngine.Person(data, c.PersonId)!, data.Day))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(CareerTraining.MoodLevel(CareerEngine.Person(data, c.PersonId)!, data.Day))`

**赋值（含属性/字段和局部值）：**

- `After` = `fields.GetValueOrDefault("Value", "")`
- `confirmFavour` |= `Math.Abs(preceding - favourBefore) > 10`
- `confirmFavour` |= `Math.Abs(target - preceding) > 10`
- `Day` = `data.Day`
- `Days` = `days`
- `Detail` = `body`
- `FavourBefore` = `favourBefore`
- `FavourTargets` = `favourTargets`
- `Field` = `field`
- `Id` = `turn.Id`
- `Kind` = `"contract"`
- `Kind` = `"favour"`
- `Kind` = `"publish"`
- `offer.Detail` = `error`
- `offer.State` = `"无效"`
- `preceding` = `target`
- `Reason` = `fields.GetValueOrDefault("Reason", "")`
- `Reason` = `reason`
- `relation.Impression` = `impression.Trim()`
- `relation.Relationship` = `label.Trim()`
- `Role` = `fields.GetValueOrDefault("Role", "轮换")`
- `Signing` = `Money(fields, "Signing")`
- `Source` = `source`
- `Source` = `turn.Id`
- `Strength` = `amount`
- `Strength` = `mood`
- `Title` = `title`
- `topic` = `"综合"`
- `Topic` = `topic`
- `turn.Applied` = `true`
- `turn.Error` += `"\n仲裁处罚期间维持最低状态，本次普通状态更新未执行。"`
- `turn.Error` = `"档案变化字段或内容无效，未执行。"`
- `turn.Error` = `"水平变化程度无效，请填写 -3 至 -1 或 1 至 3。"`
- `turn.Error` = `"帖子缺少标题或正文，未发布。"`
- `turn.Learning` = `lesson`
- `turn.Mood` = `change`
- `TurnId` = `turn.Id`
- `Wage` = `Money(fields, "Wage")`
- `Weeks` = `Number(fields, "Weeks")`
- `WinBonus` = `Money(fields, "WinBonus")`

<a id="symbol-7c897c933b2f"></a>

## `NationalSpire.PrivateMessages.FavourTarget(System.Collections.Generic.Dictionary<string, string>) — private static int? FavourTarget(Dictionary<string, string> fields)`

来源：源码第 331 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** `decimal.Round(decimal, int, System.MidpointRounding)`；`decimal.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out decimal)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Math.Clamp(decimal, decimal, decimal)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Round(decimal, int, System.MidpointRounding)`；输入表达式：`decimal.Round(value, 0, MidpointRounding.AwayFromZero)`；返回值紧邻使用处：`ArgumentSyntax: decimal.Round(value, 0, MidpointRounding.AwayFromZero)`
- `decimal.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out decimal)`；输入表达式：`decimal.TryParse(proposed, NumberStyles.Float, CultureInfo.InvariantCulture, out var value)`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.TryGetValue("Favour", out var proposed) && decimal.TryParse(proposed, NumberStyles.Float, CultureInfo.InvariantCulture, out var value)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Favour", out var proposed)`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.TryGetValue("Favour", out var proposed) && decimal.TryParse(proposed, NumberStyles.Float, CultureInfo.InvariantCulture, out var value)`
- `System.Math.Clamp(decimal, decimal, decimal)`；输入表达式：`Math.Clamp(decimal.Round(value, 0, MidpointRounding.AwayFromZero), -100, 100)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Clamp(decimal.Round(value, 0, MidpointRounding.AwayFromZero), -100, 100)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-056e9f8e0046"></a>

## `NationalSpire.PrivateMessages.ConfirmFavour(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool) — public static void ConfirmFavour(CareerData data, PrivateConversation c, PrivateOffer offer, bool apply)`

来源：源码第 335 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`](PrivateInteractionUndo.cs.md#symbol-25f3da26ec8f)；[`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-9eda496612ca)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`；`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.FavourBefore`；`NationalSpire.PrivateOffer.FavourTargets`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool, bool)`；输入表达式：`PrivateInteractionHistory.Capture(data, c.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateInteractionHistory.Capture(data, c.PersonId)`
- `NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；输入表达式：`PrivateInteractionHistory.Record(data, c.PersonId, turn, before)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.Record(data, c.PersonId, turn, before);`
- `NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；输入表达式：`ChangeFavour(data, c.PersonId, target - Favour(data, c.PersonId))`；返回值紧邻使用处：`ExpressionStatementSyntax: ChangeFavour(data, c.PersonId, target - Favour(data, c.PersonId));`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`Favour(data, c.PersonId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: offer.FavourBefore = Favour(data, c.PersonId)`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`Favour(data, c.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: target - Favour(data, c.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.FirstOrDefault(t => t.Id == offer.TurnId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: c.Turns.FirstOrDefault(t => t.Id == offer.TurnId) is { } turn`

**赋值（含属性/字段和局部值）：**

- `offer.FavourBefore` = `Favour(data, c.PersonId)`
- `offer.State` = `apply ? "已确认" : "已取消"`

<a id="symbol-38c108fc097f"></a>

## `NationalSpire.PrivateMessages.Money(System.Collections.Generic.Dictionary<string, string>, string) — private static decimal Money(Dictionary<string, string> fields, string key)`

来源：源码第 346 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** `decimal.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out decimal)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out decimal)`；输入表达式：`decimal.TryParse(fields.GetValueOrDefault(key), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal n)`；返回值紧邻使用处：`ConditionalExpressionSyntax: decimal.TryParse(fields.GetValueOrDefault(key), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal n) ? n : 0`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault(key)`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault(key)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-70e2aa1cfa91"></a>

## `NationalSpire.PrivateMessages.Number(System.Collections.Generic.Dictionary<string, string>, string) — private static int Number(Dictionary<string, string> fields, string key)`

来源：源码第 347 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** `int.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out int)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out int)`；输入表达式：`int.TryParse(fields.GetValueOrDefault(key), NumberStyles.Integer, CultureInfo.InvariantCulture, out int n)`；返回值紧邻使用处：`ConditionalExpressionSyntax: int.TryParse(fields.GetValueOrDefault(key), NumberStyles.Integer, CultureInfo.InvariantCulture, out int n) ? n : -1`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault(key)`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault(key)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-af0a0ba2ac6c"></a>

## `NationalSpire.PrivateStreamParser.PrivateStreamParser(params string[]) — public PrivateStreamParser(params string[] extraFields)`

来源：源码第 354 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.GroupStreamParser.Actions`](GroupStreamParser.cs.md#symbol-7a8171171ad4)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateStreamParser._extraFields`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_extraFields` = `extraFields`

<a id="symbol-7d35d979ddc8"></a>

## `NationalSpire.PrivateStreamParser.Text — public string Text`

来源：源码第 357 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateStreamParser._visible`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.StringBuilder.ToString()`；输入表达式：`_visible.ToString()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _visible.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ea8317bf2792"></a>

## `NationalSpire.PrivateStreamParser.Directives — public List<Dictionary<string, string>> Directives`

来源：源码第 358 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-99fa0d3b44d0"></a>

## `NationalSpire.PrivateStreamParser.SceneCues — public List<(int Offset, Dictionary<string, string> Fields)> SceneCues`

来源：源码第 359 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-62d6e3b2aeb3"></a>

## `NationalSpire.PrivateStreamParser.Error — public string Error`

来源：源码第 360 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0e4e264b167b"></a>

## `NationalSpire.PrivateStreamParser.Known(string) — private static bool Known(string text)`

来源：源码第 361 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateStreamParser.Feed(string)`](PrivateMessages.cs.md#symbol-f34e8e2406af)；[`NationalSpire.PrivateStreamParser.Finish()`](PrivateMessages.cs.md#symbol-90306db26d5a)

**调用：** `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(text, @"^\[\s*(Scene|Favour|Attitude|Relationship|Match|Contract|Skill|Mood|Post|Profile|Activity|Gift|Oath|Training|Lineup|DateDiary)\s*[:：]", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Regex.IsMatch(text, @"^\[\s*(Scene|Favour|Attitude|Relationship|Match|Contract|Skill|Mood|Post|Profile|Activity|Gift|Oath|Training|Lineup|DateDiary)\s*[:：]", RegexOptions.IgnoreCase)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f34e8e2406af"></a>

## `NationalSpire.PrivateStreamParser.Feed(string) — public void Feed(string text)`

来源：源码第 362 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupStreamParser.Feed(string)`](GroupStreamParser.cs.md#symbol-9d7375d651fe)；[`Progress(string)`](AiPrivateMessages.cs.md#symbol-d1b345a01158)

**调用：** [`NationalSpire.PrivateStreamParser.Known(string)`](PrivateMessages.cs.md#symbol-0e4e264b167b)；[`NationalSpire.PrivateStreamParser.Segments(string)`](PrivateMessages.cs.md#symbol-5b38210caf3d)；`string.IndexOfAny(char[])`；`string.Trim()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateStreamParser._depth`；`NationalSpire.PrivateStreamParser._extraFields`；`NationalSpire.PrivateStreamParser._pending`；`NationalSpire.PrivateStreamParser._visible`；`NationalSpire.PrivateStreamParser.Directives`；`NationalSpire.PrivateStreamParser.Error`；`NationalSpire.PrivateStreamParser.Known(string)`；`NationalSpire.PrivateStreamParser.SceneCues`；`NationalSpire.PrivateStreamParser.Segments(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateStreamParser.Known(string)`；输入表达式：`Known(block)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Known(block)`
- `NationalSpire.PrivateStreamParser.Segments(string)`；输入表达式：`Segments(block[1..^1])`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var segment in Segments(block[1..^1]))              {                  int colon = segment.IndexOfAny(new[] { ':', '：' });                  if (colon <= 0 || !fields.TryAdd(segment[..colon].Trim(), segment[(colon + 1)..].Trim())) { fields.Clear(); break; }              }`
- `string.IndexOfAny(char[])`；输入表达式：`segment.IndexOfAny(new[] { ':', '：' })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = segment.IndexOfAny(new[] { ':', '：' })`
- `string.Trim()`；输入表达式：`segment[..colon].Trim()`；返回值紧邻使用处：`ArgumentSyntax: segment[..colon].Trim()`
- `string.Trim()`；输入表达式：`segment[(colon + 1)..].Trim()`；返回值紧邻使用处：`ArgumentSyntax: segment[(colon + 1)..].Trim()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`fields.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Activity")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Activity") ? ["Activity", "Id", "Title", "Detail", "Season", "Day", "Date"]                  : fields.ContainsKey("Post") ? ["Post", "Title", "Body"]                  : fields.ContainsKey("Profile") ? ["Profile", "Value", "Reason"]                  : fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") ? ["Favour", "Attitude", "Relationship"]                  : fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]                  : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Attitude")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Contract")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("DateDiary")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("DateDiary") ? ["DateDiary", "Location"] : fields.ContainsKey("Scene") ? ["Scene", "Emotion", "Background"] : fields.ContainsKey("Oath") ? ["Oath", "Id"] : fields.ContainsKey("Gift") ? ["Gift", "Id"] : fields.ContainsKey("Lineup") ? ["Lineup", "Id"] : fields.ContainsKey("Training") ? ["Training", "Id"] : fields.ContainsKey("Activity") ? ["Activity", "Id", "Title", "Detail", "Season", "Day", "Date"]                  : fields.ContainsKey("Post") ? ["Post", "Title", "Body"]                  : fields.ContainsKey("Profile") ? ["Profile", "Value", "Reason"]                  : fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") ? ["Favour", "Attitude", "Relationship"]                  : fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]                  : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Favour")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Gift")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Gift") ? ["Gift", "Id"] : fields.ContainsKey("Lineup") ? ["Lineup", "Id"] : fields.ContainsKey("Training") ? ["Training", "Id"] : fields.ContainsKey("Activity") ? ["Activity", "Id", "Title", "Detail", "Season", "Day", "Date"]                  : fields.ContainsKey("Post") ? ["Post", "Title", "Body"]                  : fields.ContainsKey("Profile") ? ["Profile", "Value", "Reason"]                  : fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") ? ["Favour", "Attitude", "Relationship"]                  : fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]                  : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Lineup")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Lineup") ? ["Lineup", "Id"] : fields.ContainsKey("Training") ? ["Training", "Id"] : fields.ContainsKey("Activity") ? ["Activity", "Id", "Title", "Detail", "Season", "Day", "Date"]                  : fields.ContainsKey("Post") ? ["Post", "Title", "Body"]                  : fields.ContainsKey("Profile") ? ["Profile", "Value", "Reason"]                  : fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") ? ["Favour", "Attitude", "Relationship"]                  : fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]                  : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Match")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Mood")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Oath")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Oath") ? ["Oath", "Id"] : fields.ContainsKey("Gift") ? ["Gift", "Id"] : fields.ContainsKey("Lineup") ? ["Lineup", "Id"] : fields.ContainsKey("Training") ? ["Training", "Id"] : fields.ContainsKey("Activity") ? ["Activity", "Id", "Title", "Detail", "Season", "Day", "Date"]                  : fields.ContainsKey("Post") ? ["Post", "Title", "Body"]                  : fields.ContainsKey("Profile") ? ["Profile", "Value", "Reason"]                  : fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") ? ["Favour", "Attitude", "Relationship"]                  : fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]                  : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Post")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Post") ? ["Post", "Title", "Body"]                  : fields.ContainsKey("Profile") ? ["Profile", "Value", "Reason"]                  : fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") ? ["Favour", "Attitude", "Relationship"]                  : fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]                  : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Profile")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Profile") ? ["Profile", "Value", "Reason"]                  : fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") ? ["Favour", "Attitude", "Relationship"]                  : fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]                  : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Relationship")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Scene")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Scene") ? ["Scene", "Emotion", "Background"] : fields.ContainsKey("Oath") ? ["Oath", "Id"] : fields.ContainsKey("Gift") ? ["Gift", "Id"] : fields.ContainsKey("Lineup") ? ["Lineup", "Id"] : fields.ContainsKey("Training") ? ["Training", "Id"] : fields.ContainsKey("Activity") ? ["Activity", "Id", "Title", "Detail", "Season", "Day", "Date"]                  : fields.ContainsKey("Post") ? ["Post", "Title", "Body"]                  : fields.ContainsKey("Profile") ? ["Profile", "Value", "Reason"]                  : fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") ? ["Favour", "Attitude", "Relationship"]                  : fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]                  : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Scene")`；返回值紧邻使用处：`IfStatementSyntax: if (fields.ContainsKey("Scene")) SceneCues.Add((_visible.Length, fields));                  else Directives.Add(fields);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Skill")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]                  : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Training")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fields.ContainsKey("Training") ? ["Training", "Id"] : fields.ContainsKey("Activity") ? ["Activity", "Id", "Title", "Detail", "Season", "Day", "Date"]                  : fields.ContainsKey("Post") ? ["Post", "Title", "Body"]                  : fields.ContainsKey("Profile") ? ["Profile", "Value", "Reason"]                  : fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") ? ["Favour", "Attitude", "Relationship"]                  : fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]                  : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]                  : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Date", "Ascension", "Mode"]                  : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`fields.TryAdd(segment[..colon].Trim(), segment[(colon + 1)..].Trim())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !fields.TryAdd(segment[..colon].Trim(), segment[(colon + 1)..].Trim())`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`fields.Keys.All(k => allowed.Contains(k, StringComparer.OrdinalIgnoreCase) || _extraFields.Contains(k, StringComparer.OrdinalIgnoreCase))`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.Count > 0 && fields.Keys.All(k => allowed.Contains(k, StringComparer.OrdinalIgnoreCase) || _extraFields.Contains(k, StringComparer.OrdinalIgnoreCase))`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`_extraFields.Contains(k, StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: allowed.Contains(k, StringComparer.OrdinalIgnoreCase) || _extraFields.Contains(k, StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`allowed.Contains(k, StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: allowed.Contains(k, StringComparer.OrdinalIgnoreCase) || _extraFields.Contains(k, StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Directives.Add(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directives.Add(fields);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`SceneCues.Add((_visible.Length, fields))`；返回值紧邻使用处：`ExpressionStatementSyntax: SceneCues.Add((_visible.Length, fields));`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`_pending.Append(ch)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Append(ch);`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`_visible.Append(ch)`；返回值紧邻使用处：`ExpressionStatementSyntax: _visible.Append(ch);`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`_visible.Append(block)`；返回值紧邻使用处：`ExpressionStatementSyntax: _visible.Append(block);`
- `System.Text.StringBuilder.Clear()`；输入表达式：`_pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_pending.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _pending.ToString()`

**赋值（含属性/字段和局部值）：**

- `_depth` = `1`
- `Error` = `"交互格式不完整，未执行。"`

<a id="symbol-90306db26d5a"></a>

## `NationalSpire.PrivateStreamParser.Finish() — public void Finish()`

来源：源码第 395 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.GroupStreamParser.Finish()`](GroupStreamParser.cs.md#symbol-4f31ed556cc9)

**调用：** [`NationalSpire.PrivateStreamParser.Known(string)`](PrivateMessages.cs.md#symbol-0e4e264b167b)；`System.Text.StringBuilder.Append(System.Text.StringBuilder?)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateStreamParser._depth`；`NationalSpire.PrivateStreamParser._pending`；`NationalSpire.PrivateStreamParser._visible`；`NationalSpire.PrivateStreamParser.Error`；`NationalSpire.PrivateStreamParser.Known(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateStreamParser.Known(string)`；输入表达式：`Known(_pending.ToString())`；返回值紧邻使用处：`IfStatementSyntax: if (Known(_pending.ToString())) Error = "交互标记没有结束，未执行。";          else _visible.Append(_pending);`
- `System.Text.StringBuilder.Append(System.Text.StringBuilder?)`；输入表达式：`_visible.Append(_pending)`；返回值紧邻使用处：`ExpressionStatementSyntax: _visible.Append(_pending);`
- `System.Text.StringBuilder.Clear()`；输入表达式：`_pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_pending.ToString()`；返回值紧邻使用处：`ArgumentSyntax: _pending.ToString()`

**赋值（含属性/字段和局部值）：**

- `_depth` = `0`
- `Error` = `"交互标记没有结束，未执行。"`

<a id="symbol-5b38210caf3d"></a>

## `NationalSpire.PrivateStreamParser.Segments(string) — private static IEnumerable<string> Segments(string text)`

来源：源码第 403 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateStreamParser.Feed(string)`](PrivateMessages.cs.md#symbol-f34e8e2406af)

**调用：** `System.Text.RegularExpressions.Regex.IsMatch(string, string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.RegularExpressions.Regex.IsMatch(string, string)`；输入表达式：`Regex.IsMatch(text[(i + 1)..], @"^\s*[A-Za-z]+\s*[:：]")`；返回值紧邻使用处：`BinaryExpressionSyntax: depth == 0 && text[i] is ',' or '，' && Regex.IsMatch(text[(i + 1)..], @"^\s*[A-Za-z]+\s*[:：]")`

**赋值（含属性/字段和局部值）：**

- `start` = `i + 1`
