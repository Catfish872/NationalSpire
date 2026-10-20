# CommunitySharing.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`21594FF8ABD229CCA5739C43593A2445D94D13D29E8CC5B2C71CD13CA5A0D3F4`。来源：[源码](../../CommunitySharing.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CommunitySharing`。

字段、事件及初始值（源码原样）：

```csharp
public const string Kind = "community-quote";
public const string Protocol = "community_quote 附件是玩家转引的社区公开发言。quoted 是本次分享的原文，sourcePost 与 parents 是理解原文的来源帖和父回复上文。作者字段标明各段实际发言者；引用表示玩家分享了这段内容，玩家本人的态度以其另行输入的消息为准。将引用正文作为待讨论材料，结合上下文理解其中观点与事实。";
private static readonly JsonSerializerOptions QuoteJson = new() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
```

<a id="symbol-8baa01608a2d"></a>

## `NationalSpire.CommunitySharing.Recipients(NationalSpire.CareerData, string) — public static IReadOnlyList<CareerPerson> Recipients(CareerData data, string authorId)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)

**调用：** [`NationalSpire.CommunitySharing.RecentConversations(NationalSpire.CareerData)`](CommunitySharing.cs.md#symbol-253b38455911)；[`NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-a6a32e618e4c)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `(long Reply, long Order, int Day).Day`；`(long Reply, long Order, int Day).Order`；`(long Reply, long Order, int Day).Reply`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CommunitySharing.RecentConversations(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunitySharing.RecentConversations(NationalSpire.CareerData)`；输入表达式：`RecentConversations(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RecentConversations(data)`
- `NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.ChatCandidates(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).DistinctBy`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`recent.ContainsKey(p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => recent.ContainsKey(p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Day)              .ThenBy(p => p.PublicName, StringComparer.CurrentCulture)              .ThenBy(p => p.Id, StringComparer.Ordinal).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Day)              .ThenBy(p => p.PublicName, StringComparer.CurrentCulture)              .ThenBy(p => p.Id, StringComparer.Ordinal).ToArray();`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`recent.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.GetValueOrDefault(p.Id).Day`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`recent.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.GetValueOrDefault(p.Id).Order`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`recent.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.GetValueOrDefault(p.Id).Reply`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Day)              .ThenBy(p => p.PublicName, StringComparer.CurrentCulture)              .ThenBy(p => p.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Day)              .ThenBy(p => p.PublicName, StringComparer.CurrentCulture)              .ThenBy(p => p.Id, StringComparer.Ordinal).ToArray`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Day)              .ThenBy(p => p.PublicName, StringComparer.CurrentCulture)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Day)              .ThenBy(p => p.PublicName, StringComparer.CurrentCulture)              .ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Day)              .ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)              .ThenByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)              .ThenByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)              .OrderByDescending(p => p.Id == authorId)              .ThenByDescending(p => recent.ContainsKey(p.Id))              .ThenByDescending`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8b3d5962100a"></a>

## `NationalSpire.CommunitySharing.RecentRecipients(NationalSpire.CareerData) — public static HashSet<string> RecentRecipients(CareerData data)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)

**调用：** [`NationalSpire.CommunitySharing.RecentConversations(NationalSpire.CareerData)`](CommunitySharing.cs.md#symbol-253b38455911)；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunitySharing.RecentConversations(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunitySharing.RecentConversations(NationalSpire.CareerData)`；输入表达式：`RecentConversations(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: RecentConversations(data).Keys`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`RecentConversations(data).Keys.ToHashSet(StringComparer.Ordinal)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => RecentConversations(data).Keys.ToHashSet(StringComparer.Ordinal)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-253b38455911"></a>

## `NationalSpire.CommunitySharing.RecentConversations(NationalSpire.CareerData) — private static Dictionary<string, (long Reply, long Order, int Day)> RecentConversations(CareerData data)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunitySharing.RecentRecipients(NationalSpire.CareerData)`](CommunitySharing.cs.md#symbol-8b3d5962100a)；[`NationalSpire.CommunitySharing.Recipients(NationalSpire.CareerData, string)`](CommunitySharing.cs.md#symbol-8baa01608a2d)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Math.Max(int, int)`；`System.Math.Max(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.PrivateConversation.LastReplyOrder`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.ReplyOrder`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`；`NationalSpire.PrivateTurn.UserOrder`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, (long Reply, long Order, int Day)>(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, (long Reply, long Order, int Day)>(StringComparer.Ordinal)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(day, turn.Day)`；返回值紧邻使用处：`AssignmentExpressionSyntax: day = Math.Max(day, turn.Day)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(order, Math.Max(turn.UserOrder, turn.ReplyOrder))`；返回值紧邻使用处：`AssignmentExpressionSyntax: order = Math.Max(order, Math.Max(turn.UserOrder, turn.ReplyOrder))`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(turn.UserOrder, turn.ReplyOrder)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(turn.UserOrder, turn.ReplyOrder)`

**赋值（含属性/字段和局部值）：**

- `day` = `Math.Max(day, turn.Day)`
- `hasMessages` = `true`
- `order` = `Math.Max(order, Math.Max(turn.UserOrder, turn.ReplyOrder))`
- `recent[id]` = `(conversation.LastReplyOrder, order, day)`

<a id="symbol-3ee15fb08761"></a>

## `NationalSpire.CommunitySharing.Create(NationalSpire.CareerData, string, string) — public static PrivateOffer Create(CareerData data, string postId, string replyId = "")`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ReportDiscussion(string, string)`](ArbitrationScreen.cs.md#symbol-4223b2b95c14)；[`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)；[`NationalSpire.CommunityReporting.Create(NationalSpire.CareerData, string, string, string)`](CommunityReporting.cs.md#symbol-6bbc23d16690)

**调用：** [`NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](CommunitySharing.cs.md#symbol-b6e3b5a6b60e)；`NationalSpire.CommunityQuote.CommunityQuote()`；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityQuote.PostId`；`NationalSpire.CommunityQuote.ReplyId`；`NationalSpire.CommunitySharing.Kind`；`NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Quote`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityQuote.CommunityQuote()`；输入表达式：`new() { PostId = postId, ReplyId = replyId }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Quote = new() { PostId = postId, ReplyId = replyId }`
- `NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`Prepare(data, attachment)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Prepare(data, attachment) is { } error`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = Kind, Quote = new() { PostId = postId, ReplyId = replyId } }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = Kind, Quote = new() { PostId = postId, ReplyId = replyId } }`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException(error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException(error);`

**赋值（含属性/字段和局部值）：**

- `Kind` = `Kind`
- `PostId` = `postId`
- `Quote` = `new() { PostId = postId, ReplyId = replyId }`
- `ReplyId` = `replyId`

<a id="symbol-b6e3b5a6b60e"></a>

## `NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string? Prepare(CareerData data, PrivateOffer attachment)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunitySharing.Create(NationalSpire.CareerData, string, string)`](CommunitySharing.cs.md#symbol-3ee15fb08761)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** [`NationalSpire.AiGeneratedText.Different(string, string)`](AiGeneratedText.cs.md#symbol-8a7bdafb8195)；[`NationalSpire.AiGeneratedText.Source(NationalSpire.CommunityPost)`](AiGeneratedText.cs.md#symbol-ac6ac5681f0e)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CommunitySharing.Text(NationalSpire.CareerData, NationalSpire.CommunityQuote)`](CommunitySharing.cs.md#symbol-276822babdcb)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`NationalSpire.CommunityQuote.CommunityQuote()`；`NationalSpire.CommunityQuoteReply.CommunityQuoteReply()`；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Reverse()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiGeneratedText.Different(string, string)`；`NationalSpire.AiGeneratedText.Source(NationalSpire.CommunityPost)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityQuote.AuthorId`；`NationalSpire.CommunityQuote.AuthorName`；`NationalSpire.CommunityQuote.Body`；`NationalSpire.CommunityQuote.Day`；`NationalSpire.CommunityQuote.ParentId`；`NationalSpire.CommunityQuote.Parents`；`NationalSpire.CommunityQuote.PostAiSourceBody`；`NationalSpire.CommunityQuote.PostAuthorId`；`NationalSpire.CommunityQuote.PostAuthorName`；`NationalSpire.CommunityQuote.PostBody`；`NationalSpire.CommunityQuote.PostDay`；`NationalSpire.CommunityQuote.PostId`；`NationalSpire.CommunityQuote.PostRevision`；`NationalSpire.CommunityQuote.PostSourceBody`；`NationalSpire.CommunityQuote.PostTitle`；`NationalSpire.CommunityQuote.ReplyId`；`NationalSpire.CommunityQuoteReply.AuthorId`；`NationalSpire.CommunityQuoteReply.AuthorName`；`NationalSpire.CommunityQuoteReply.Body`；`NationalSpire.CommunityQuoteReply.Day`；`NationalSpire.CommunityQuoteReply.Id`；`NationalSpire.CommunityQuoteReply.ParentId`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ParentId`；`NationalSpire.CommunitySharing.Kind`；`NationalSpire.CommunitySharing.Text(NationalSpire.CareerData, NationalSpire.CommunityQuote)`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.GameText.Plain(string)`；`NationalSpire.PrivateOffer.AiDetail`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.PostRevision`；`NationalSpire.PrivateOffer.Quote`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiGeneratedText.Different(string, string)`；输入表达式：`AiGeneratedText.Different(quote.PostSourceBody, GameText.Plain(AiGeneratedText.Source(post)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: quote.PostAiSourceBody = AiGeneratedText.Different(quote.PostSourceBody, GameText.Plain(AiGeneratedText.Source(post)))`
- `NationalSpire.AiGeneratedText.Source(NationalSpire.CommunityPost)`；输入表达式：`AiGeneratedText.Source(post)`；返回值紧邻使用处：`ArgumentSyntax: AiGeneratedText.Source(post)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, parent.AuthorId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: AuthorName = CareerEngine.DisplayName(data, parent.AuthorId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, post.AuthorId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: PostAuthorName = CareerEngine.DisplayName(data, post.AuthorId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, selected?.AuthorId ?? post.AuthorId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: AuthorName = CareerEngine.DisplayName(data, selected?.AuthorId ?? post.AuthorId)`
- `NationalSpire.CommunityQuote.CommunityQuote()`；输入表达式：`new CommunityQuote          {              PostId = post.Id, ReplyId = replyId, ParentId = selected?.ParentId ?? "", PostRevision = post.Revision,              PostTitle = post.Title, PostAuthorId = post.AuthorId, PostAuthorName = CareerEngine.DisplayName(data, post.AuthorId),              PostBody = post.Body, PostDay = post.Day,              AuthorId = selected?.AuthorId ?? post.AuthorId, AuthorName = CareerEngine.DisplayName(data, selected?.AuthorId ?? post.AuthorId),              Body = selected?.Body ?? post.Body, Day = selected?.Day ?? post.Day          }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CommunityQuote          {              PostId = post.Id, ReplyId = replyId, ParentId = selected?.ParentId ?? "", PostRevision = post.Revision,              PostTitle = post.Title, PostAuthorId = post.AuthorId, PostAuthorName = CareerEngine.DisplayName(data, post.AuthorId),              PostBody = post.Body, PostDay = post.Day,              AuthorId = selected?.AuthorId ?? post.AuthorId, AuthorName = CareerEngine.DisplayName(data, selected?.AuthorId ?? post.AuthorId),              Body = selected?.Body ?? post.Body, Day = selected?.Day ?? post.Day          }`
- `NationalSpire.CommunityQuoteReply.CommunityQuoteReply()`；输入表达式：`new() { Id = parent.Id, ParentId = parent.ParentId, AuthorId = parent.AuthorId,                  AuthorName = CareerEngine.DisplayName(data, parent.AuthorId), Body = parent.Body, Day = parent.Day }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = parent.Id, ParentId = parent.ParentId, AuthorId = parent.AuthorId,                  AuthorName = CareerEngine.DisplayName(data, parent.AuthorId), Body = parent.Body, Day = parent.Day }`
- `NationalSpire.CommunitySharing.Text(NationalSpire.CareerData, NationalSpire.CommunityQuote)`；输入表达式：`Text(data, quote)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(data, quote)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).FirstOrDefault`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.IsHuman(data, post.AuthorId)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(AiGeneratedText.Source(post))`；返回值紧邻使用处：`ArgumentSyntax: GameText.Plain(AiGeneratedText.Source(post))`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(post.SourceBody)`；返回值紧邻使用处：`AssignmentExpressionSyntax: quote.PostSourceBody = GameText.Plain(post.SourceBody)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(selected?.Body ?? post.Body)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(selected?.Body ?? post.Body)) return "引用的内容正在准备中。";`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(source.PostId)`；返回值紧邻使用处：`BinaryExpressionSyntax: attachment.Kind != Kind || attachment.Quote is not { } source || string.IsNullOrWhiteSpace(source.PostId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, CommunityReply>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: replyId.Length > 0              ? post.Replies.Where(r => r.Day <= data.Day).DistinctBy(r => r.Id).ToDictionary(r => r.Id)              : new Dictionary<string, CommunityReply>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`replies.TryGetValue(parentId, out var parent)`；返回值紧邻使用处：`BinaryExpressionSyntax: replies.TryGetValue(parentId, out var parent) && seen.Add(parent.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`replies.TryGetValue(replyId, out selected)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !replies.TryGetValue(replyId, out selected)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`seen.Add(parent.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: replies.TryGetValue(parentId, out var parent) && seen.Add(parent.Id)`
- `System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；输入表达式：`new HashSet<string>(StringComparer.Ordinal) { replyId }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>(StringComparer.Ordinal) { replyId }`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`post.Replies.Where(r => r.Day <= data.Day).DistinctBy(r => r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= data.Day).DistinctBy(r => r.Id).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).FirstOrDefault(p => p.Id == source.PostId && p.Day <= data.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).FirstOrDefault(p => p.Id == source.PostId && p.Day <= data.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`post.Replies.Where(r => r.Day <= data.Day).DistinctBy(r => r.Id).ToDictionary(r => r.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: replyId.Length > 0              ? post.Replies.Where(r => r.Day <= data.Day).DistinctBy(r => r.Id).ToDictionary(r => r.Id)              : new Dictionary<string, CommunityReply>()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => r.Day <= data.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= data.Day).DistinctBy`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`quote.Parents.Add(new() { Id = parent.Id, ParentId = parent.ParentId, AuthorId = parent.AuthorId,                  AuthorName = CareerEngine.DisplayName(data, parent.AuthorId), Body = parent.Body, Day = parent.Day })`；返回值紧邻使用处：`ExpressionStatementSyntax: quote.Parents.Add(new() { Id = parent.Id, ParentId = parent.ParentId, AuthorId = parent.AuthorId,                  AuthorName = CareerEngine.DisplayName(data, parent.AuthorId), Body = parent.Body, Day = parent.Day });`
- `System.Collections.Generic.List<T>.Reverse()`；输入表达式：`quote.Parents.Reverse()`；返回值紧邻使用处：`ExpressionStatementSyntax: quote.Parents.Reverse();`

**赋值（含属性/字段和局部值）：**

- `attachment.AiDetail` = `aiDetail`
- `attachment.Detail` = `detail`
- `attachment.MatchId` = `post.Id`
- `attachment.PostRevision` = `post.Revision`
- `attachment.Quote` = `quote`
- `AuthorId` = `parent.AuthorId`
- `AuthorId` = `selected?.AuthorId ?? post.AuthorId`
- `AuthorName` = `CareerEngine.DisplayName(data, parent.AuthorId)`
- `AuthorName` = `CareerEngine.DisplayName(data, selected?.AuthorId ?? post.AuthorId)`
- `Body` = `parent.Body`
- `Body` = `selected?.Body ?? post.Body`
- `Day` = `parent.Day`
- `Day` = `selected?.Day ?? post.Day`
- `Id` = `parent.Id`
- `parentId` = `parent.ParentId`
- `ParentId` = `parent.ParentId`
- `ParentId` = `selected?.ParentId ?? ""`
- `PostAuthorId` = `post.AuthorId`
- `PostAuthorName` = `CareerEngine.DisplayName(data, post.AuthorId)`
- `PostBody` = `post.Body`
- `PostDay` = `post.Day`
- `PostId` = `post.Id`
- `PostRevision` = `post.Revision`
- `PostTitle` = `post.Title`
- `quote.PostAiSourceBody` = `AiGeneratedText.Different(quote.PostSourceBody, GameText.Plain(AiGeneratedText.Source(post)))`
- `quote.PostSourceBody` = `GameText.Plain(post.SourceBody)`
- `ReplyId` = `replyId`

<a id="symbol-276822babdcb"></a>

## `NationalSpire.CommunitySharing.Text(NationalSpire.CareerData, NationalSpire.CommunityQuote) — public static string Text(CareerData data, CommunityQuote quote)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiGeneratedText.Attachment(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](AiGeneratedText.cs.md#symbol-ac6a46b66492)；[`NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](CommunitySharing.cs.md#symbol-b6e3b5a6b60e)

**调用：** [`NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-baf7d6edae6c)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent>.author`；`<anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent>.authorId`；`<anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent>.body`；`<anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent>.date`；`<anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent>.id`；`<anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent>.recordedEvent`；`<anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent>.revision`；`<anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent>.title`；`<anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body>.author`；`<anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body>.authorId`；`<anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body>.body`；`<anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body>.date`；`<anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body>.id`；`<anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body>.kind`；`<anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body>.parentId`；`<anonymous type: string id, string parentId, string authorId, string author, string date, string body>.author`；`<anonymous type: string id, string parentId, string authorId, string author, string date, string body>.authorId`；`<anonymous type: string id, string parentId, string authorId, string author, string date, string body>.body`；`<anonymous type: string id, string parentId, string authorId, string author, string date, string body>.date`；`<anonymous type: string id, string parentId, string authorId, string author, string date, string body>.id`；`<anonymous type: string id, string parentId, string authorId, string author, string date, string body>.parentId`；`<anonymous type: string type, <anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent> sourcePost, System.Collections.Generic.IEnumerable<<anonymous type: string id, string parentId, string authorId, string author, string date, string body>> parents, <anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body> quoted>.parents`；`<anonymous type: string type, <anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent> sourcePost, System.Collections.Generic.IEnumerable<<anonymous type: string id, string parentId, string authorId, string author, string date, string body>> parents, <anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body> quoted>.quoted`；`<anonymous type: string type, <anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent> sourcePost, System.Collections.Generic.IEnumerable<<anonymous type: string id, string parentId, string authorId, string author, string date, string body>> parents, <anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body> quoted>.sourcePost`；`<anonymous type: string type, <anonymous type: string id, long revision, string title, string authorId, string author, string date, string body, string recordedEvent> sourcePost, System.Collections.Generic.IEnumerable<<anonymous type: string id, string parentId, string authorId, string author, string date, string body>> parents, <anonymous type: string id, string kind, string parentId, string authorId, string author, string date, string body> quoted>.type`；`NationalSpire.CommunityQuote.AuthorId`；`NationalSpire.CommunityQuote.AuthorName`；`NationalSpire.CommunityQuote.Body`；`NationalSpire.CommunityQuote.Day`；`NationalSpire.CommunityQuote.ParentId`；`NationalSpire.CommunityQuote.Parents`；`NationalSpire.CommunityQuote.PostAiSourceBody`；`NationalSpire.CommunityQuote.PostAuthorId`；`NationalSpire.CommunityQuote.PostAuthorName`；`NationalSpire.CommunityQuote.PostBody`；`NationalSpire.CommunityQuote.PostDay`；`NationalSpire.CommunityQuote.PostId`；`NationalSpire.CommunityQuote.PostRevision`；`NationalSpire.CommunityQuote.PostSourceBody`；`NationalSpire.CommunityQuote.PostTitle`；`NationalSpire.CommunityQuote.ReplyId`；`NationalSpire.CommunityQuoteReply.AuthorId`；`NationalSpire.CommunityQuoteReply.AuthorName`；`NationalSpire.CommunityQuoteReply.Body`；`NationalSpire.CommunityQuoteReply.Day`；`NationalSpire.CommunityQuoteReply.Id`；`NationalSpire.CommunityQuoteReply.ParentId`；`NationalSpire.CommunitySharing.QuoteJson`；`NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Iso(data, p.Day)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: date = GameCalendar.Iso(data, p.Day)`
- `NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Iso(data, quote.Day)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: date = GameCalendar.Iso(data, quote.Day)`
- `NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Iso(data, quote.PostDay)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: date = GameCalendar.Iso(data, quote.PostDay)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`quote.Parents.Select(p => new { id = p.Id, parentId = p.ParentId, authorId = p.AuthorId, author = p.AuthorName, date = GameCalendar.Iso(data, p.Day), body = p.Body })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: parents = quote.Parents.Select(p => new { id = p.Id, parentId = p.ParentId, authorId = p.AuthorId, author = p.AuthorName, date = GameCalendar.Iso(data, p.Day), body = p.Body })`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new      {          type = "community_quote",          sourcePost = new { id = quote.PostId, revision = quote.PostRevision, title = quote.PostTitle, authorId = quote.PostAuthorId,              author = quote.PostAuthorName, date = GameCalendar.Iso(data, quote.PostDay), body = quote.ReplyId.Length > 0 ? quote.PostBody : null,              recordedEvent = quote.PostAiSourceBody ?? quote.PostSourceBody },          parents = quote.Parents.Select(p => new { id = p.Id, parentId = p.ParentId, authorId = p.AuthorId, author = p.AuthorName, date = GameCalendar.Iso(data, p.Day), body = p.Body }),          quoted = new { id = quote.ReplyId.Length == 0 ? quote.PostId : quote.ReplyId, kind = quote.ReplyId.Length == 0 ? "post" : "reply",              parentId = quote.ParentId, authorId = quote.AuthorId, author = quote.AuthorName, date = GameCalendar.Iso(data, quote.Day), body = quote.Body }      }, QuoteJson)`；返回值紧邻使用处：`BinaryExpressionSyntax: "玩家分享的社区引用（按原作者身份理解）：\n" + JsonSerializer.Serialize(new      {          type = "community_quote",          sourcePost = new { id = quote.PostId, revision = quote.PostRevision, title = quote.PostTitle, authorId = quote.PostAuthorId,              author = quote.PostAuthorName, date = GameCalendar.Iso(data, quote.PostDay), body = quote.ReplyId.Length > 0 ? quote.PostBody : null,              recordedEvent = quote.PostAiSourceBody ?? quote.PostSourceBody },          parents = quote.Parents.Select(p => new { id = p.Id, parentId = p.ParentId, authorId = p.AuthorId, author = p.AuthorName, date = GameCalendar.Iso(data, p.Day), body = p.Body }),          quoted = new { id = quote.ReplyId.Length == 0 ? quote.PostId : quote.ReplyId, kind = quote.ReplyId.Length == 0 ? "post" : "reply",              parentId = quote.ParentId, authorId = quote.AuthorId, author = quote.AuthorName, date = GameCalendar.Iso(data, quote.Day), body = quote.Body }      }, QuoteJson)`

**赋值（含属性/字段和局部值）：**
