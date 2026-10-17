# CommunityVotes.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`BA7CA6FE03798A864C1886120A63788682FC70A2F2A691B3995FA0DA3793799D`。来源：[源码](../../CommunityVotes.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CommunityVotes`。

字段、事件及初始值（源码原样）：

```csharp
private const int AudienceMultiplier = 6;
private const int PlayerReplyMultiplier = 16;
private static readonly (string Text, int Tone)[] Expressions =
    [
        ("不同意", -1), ("不赞同", -1), ("不支持", -1), ("不认可", -1), ("说得不对", -1),
        ("并非垃圾", 0), ("不是垃圾", 0), ("不是造谣", 0), ("没有造谣", 0),
        ("支持", 1), ("赞同", 1), ("认可", 1), ("说得对", 1), ("恭喜", 1), ("加油", 1),
        ("感谢", 1), ("谢谢", 1), ("精彩", 1), ("厉害", 1), ("👍", 1),
        ("反对", -1), ("质疑", -1), ("胡说", -1), ("造谣", -1), ("垃圾", -1), ("恶心", -1), ("👎", -1)
    ];
```

<a id="symbol-6ae34f6f4987"></a>

## `NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData) — public static string VoterId(CareerData data)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-37dbe54453ea)；[`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-9cdbeae87bc5)；[`Vote(int)`](CommunityScreen.cs.md#symbol-7043154d7107)

**调用：** `string.IsNullOrEmpty(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(data.LocalHumanId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrEmpty(data.LocalHumanId) ? "player" : data.LocalHumanId`

**赋值（含属性/字段和局部值）：**


<a id="symbol-37dbe54453ea"></a>

## `NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost) — public static int Choice(CareerData data, CommunityPost post)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-b1f9e0610615)；[`Vote(int)`](CommunityScreen.cs.md#symbol-7043154d7107)

**调用：** [`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`](CommunityVotes.cs.md#symbol-64add1fe8f21)；[`NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`](CommunityVotes.cs.md#symbol-6ae34f6f4987)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.PlayerVotes`；`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`；`NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`；输入表达式：`Choice(post.PlayerVotes, VoterId(data))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Choice(post.PlayerVotes, VoterId(data))`
- `NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`；输入表达式：`VoterId(data)`；返回值紧邻使用处：`ArgumentSyntax: VoterId(data)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9cdbeae87bc5"></a>

## `NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply) — public static int Choice(CareerData data, CommunityReply reply)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-b1f9e0610615)；[`Vote(int)`](CommunityScreen.cs.md#symbol-7043154d7107)

**调用：** [`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`](CommunityVotes.cs.md#symbol-64add1fe8f21)；[`NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`](CommunityVotes.cs.md#symbol-6ae34f6f4987)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityReply.PlayerVotes`；`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`；`NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`；输入表达式：`Choice(reply.PlayerVotes, VoterId(data))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Choice(reply.PlayerVotes, VoterId(data))`
- `NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`；输入表达式：`VoterId(data)`；返回值紧邻使用处：`ArgumentSyntax: VoterId(data)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-90f30ba43b83"></a>

## `NationalSpire.CommunityVotes.Score(NationalSpire.CommunityPost) — public static long Score(CommunityPost post)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-b1f9e0610615)

**调用：** [`NationalSpire.CommunityVotes.AudienceScore(int?)`](CommunityVotes.cs.md#symbol-9f70e52b989b)；[`NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`](CommunityVotes.cs.md#symbol-597f1c902b0a)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.AudienceScore`；`NationalSpire.CommunityPost.PlayerVotes`；`NationalSpire.CommunityVotes.AudienceScore(int?)`；`NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityVotes.AudienceScore(int?)`；输入表达式：`AudienceScore(post.AudienceScore)`；返回值紧邻使用处：`ArgumentSyntax: AudienceScore(post.AudienceScore)`
- `NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`；输入表达式：`Score(AudienceScore(post.AudienceScore), post.PlayerVotes)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Score(AudienceScore(post.AudienceScore), post.PlayerVotes)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c51f3ec0b04f"></a>

## `NationalSpire.CommunityVotes.Score(NationalSpire.CareerData, NationalSpire.CommunityReply) — public static long Score(CareerData data, CommunityReply reply)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-b1f9e0610615)

**调用：** [`NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-64a35a4c39c2)；[`NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`](CommunityVotes.cs.md#symbol-597f1c902b0a)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityReply.PlayerVotes`；`NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply)`；`NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply)`；输入表达式：`AudienceScore(data, reply)`；返回值紧邻使用处：`ArgumentSyntax: AudienceScore(data, reply)`
- `NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`；输入表达式：`Score(AudienceScore(data, reply), reply.PlayerVotes)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Score(AudienceScore(data, reply), reply.PlayerVotes)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9f70e52b989b"></a>

## `NationalSpire.CommunityVotes.AudienceScore(int?) — public static long AudienceScore(int? basis)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Score(NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-90f30ba43b83)；[`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-b1f9e0610615)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityVotes.AudienceMultiplier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-64a35a4c39c2"></a>

## `NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply) — public static long AudienceScore(CareerData data, CommunityReply reply)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Score(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-c51f3ec0b04f)；[`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-b1f9e0610615)

**调用：** [`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityReply.AudienceScore`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityVotes.AudienceMultiplier`；`NationalSpire.CommunityVotes.PlayerReplyMultiplier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, reply.AuthorId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CommunityThreads.IsHuman(data, reply.AuthorId) ? PlayerReplyMultiplier : AudienceMultiplier`

**赋值（含属性/字段和局部值）：**


<a id="symbol-324728201fc4"></a>

## `NationalSpire.CommunityVotes.Update(NationalSpire.CareerData, NationalSpire.CommunityPost) — public static void Update(CareerData data, CommunityPost post)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)

**调用：** [`Calculate(string, string, string, string, bool, int)`](CommunityVotes.cs.md#symbol-54fc15197a4f)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `Calculate(string, string, string, string, bool, int)`；`Fans(string)`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityPost.AudienceScore`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.MatchKind`；`NationalSpire.CommunityPost.MentionedPeople`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityPost.VoteRevision`；`NationalSpire.CommunityReply.AudienceScore`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.MentionedPeople`；`NationalSpire.CommunityReply.ParentId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Calculate(string, string, string, string, bool, int)`；输入表达式：`Calculate(post.Id, post.AuthorId, post.Title + "\n" + post.Body,              post.MentionedPeople.FirstOrDefault() ?? post.RelatedPeople.FirstOrDefault(p => p != post.AuthorId) ?? "", true, post.Replies.Count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Calculate(post.Id, post.AuthorId, post.Title + "\n" + post.Body,              post.MentionedPeople.FirstOrDefault() ?? post.RelatedPeople.FirstOrDefault(p => p != post.AuthorId) ?? "", true, post.Replies.Count)`
- `Calculate(string, string, string, string, bool, int)`；输入表达式：`Calculate(reply.Id, reply.AuthorId, reply.Body, target, false, children[reply.Id].Count())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Calculate(reply.Id, reply.AuthorId, reply.Body, target, false, children[reply.Id].Count())`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, int>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`replies.TryGetValue(reply.ParentId, out var parent)`；返回值紧邻使用处：`ConditionalExpressionSyntax: replies.TryGetValue(reply.ParentId, out var parent) ? parent.AuthorId : post.AuthorId`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`post.RelatedPeople.Select(Fans).DefaultIfEmpty(0).Max()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.RelatedPeople.Select(Fans).DefaultIfEmpty(0).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`children[reply.Id].Count()`；返回值紧邻使用处：`ArgumentSyntax: children[reply.Id].Count()`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`post.RelatedPeople.Select(Fans).DefaultIfEmpty(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.RelatedPeople.Select(Fans).DefaultIfEmpty(0).Max`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`post.MentionedPeople.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: post.MentionedPeople.FirstOrDefault() ?? post.RelatedPeople.FirstOrDefault(p => p != post.AuthorId) ?? ""`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`reply.MentionedPeople.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: reply.MentionedPeople.FirstOrDefault()                  ?? (replies.TryGetValue(reply.ParentId, out var parent) ? parent.AuthorId : post.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.RelatedPeople.FirstOrDefault(p => p != post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: post.RelatedPeople.FirstOrDefault(p => p != post.AuthorId) ?? ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`post.RelatedPeople.Select(Fans)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.RelatedPeople.Select(Fans).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.People.ToDictionary(p => p.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.ToDictionary(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`post.Replies.ToDictionary(r => r.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.ToDictionary(r => r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`post.Replies.ToLookup(r => r.ParentId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.ToLookup(r => r.ParentId)`

**赋值（含属性/字段和局部值）：**

- `changed` |= `post.AudienceScore != root`
- `changed` |= `reply.AudienceScore != next`
- `post.AudienceScore` = `root`
- `reply.AudienceScore` = `next`

<a id="symbol-49d932e36f8d"></a>

## `Fans(string) — int Fans(string id)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Calculate(string, string, string, string, bool, int)`](CommunityVotes.cs.md#symbol-54fc15197a4f)

**调用：** [`NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`](CareerAudience.cs.md#symbol-c169fde4fb8f)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.LocalHumanId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`；输入表达式：`CareerAudience.Followers(person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: people.TryGetValue(id, out var person) ? CareerAudience.Followers(person) : 0`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`followers.TryGetValue(id, out int count)`；返回值紧邻使用处：`IfStatementSyntax: if (followers.TryGetValue(id, out int count)) return count;`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`people.TryGetValue(id, out var person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: people.TryGetValue(id, out var person) ? CareerAudience.Followers(person) : 0`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: followers[id] = Math.Max(0, count)`

**赋值（含属性/字段和局部值）：**

- `count` = `id == "player" || id == data.LocalHumanId ? data.Fans                  : people.TryGetValue(id, out var person) ? CareerAudience.Followers(person) : 0`
- `followers[id]` = `Math.Max(0, count)`

<a id="symbol-54fc15197a4f"></a>

## `Calculate(string, string, string, string, bool, int) — int Calculate(string id, string author, string body, string target, bool main, int responses)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Update(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-324728201fc4)

**调用：** [`Fans(string)`](CommunityVotes.cs.md#symbol-49d932e36f8d)；[`NationalSpire.CommunityVotes.Tone(string)`](CommunityVotes.cs.md#symbol-7543cddd6c93)；[`NationalSpire.CommunityVotes.Variation(string, string)`](CommunityVotes.cs.md#symbol-92501d24e9b4)；`string.Contains(string, System.StringComparison)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Clamp(double, double, double)`；`System.Math.Log(double)`；`System.Math.Log10(double)`；`System.Math.Min(double, double)`；`System.Math.Round(double)`；`System.Math.Sqrt(double)`

**字段、属性、事件及方法组引用：** `Fans(string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Connections`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CareerPerson.Titles`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityVotes.Tone(string)`；`NationalSpire.CommunityVotes.Variation(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Fans(string)`；输入表达式：`Fans(author)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Fans(author)`
- `Fans(string)`；输入表达式：`Fans(target)`；返回值紧邻使用处：`ConditionalExpressionSyntax: target == author ? 0 : Fans(target)`
- `NationalSpire.CommunityVotes.Tone(string)`；输入表达式：`Tone(body)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Tone(body)`
- `NationalSpire.CommunityVotes.Variation(string, string)`；输入表达式：`Variation(seed, "reach")`；返回值紧邻使用处：`BinaryExpressionSyntax: .7 * Variation(seed, "reach")`
- `NationalSpire.CommunityVotes.Variation(string, string)`；输入表达式：`Variation(seed, "stance")`；返回值紧邻使用处：`BinaryExpressionSyntax: 2 * Variation(seed, "stance")`
- `string.Contains(string, System.StringComparison)`；输入表达式：`person.Role.Contains("职业", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: person.Role.Contains("职业", StringComparison.Ordinal) || person.Titles > 0`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`people.TryGetValue(author, out var person)`；返回值紧邻使用处：`IfStatementSyntax: if (people.TryGetValue(author, out var person))              {                  if (person.Connections.Contains(target)) support += .03 * tone;                  if (people.TryGetValue(target, out var other) && other.ClubId.Length > 0                      && (person.ClubId == other.ClubId || person.SupportedClubId == other.ClubId)) support += .04 * tone;                  if (person.Role.Contains("职业", StringComparison.Ordinal) || person.Titles > 0) support += .02;              }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`people.TryGetValue(target, out var other)`；返回值紧邻使用处：`BinaryExpressionSyntax: people.TryGetValue(target, out var other) && other.ClubId.Length > 0`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`person.Connections.Contains(target)`；返回值紧邻使用处：`IfStatementSyntax: if (person.Connections.Contains(target)) support += .03 * tone;`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(support, .05, .95)`；返回值紧邻使用处：`AssignmentExpressionSyntax: support = Math.Clamp(support, .05, .95)`
- `System.Math.Log(double)`；输入表达式：`Math.Log(1 + responses)`；返回值紧邻使用处：`BinaryExpressionSyntax: .2 * Math.Log(1 + responses)`
- `System.Math.Log10(double)`；输入表达式：`Math.Log10(1d + fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: .018 * Math.Log10(1d + fans)`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(.12, .018 * Math.Log10(1d + fans))`；返回值紧邻使用处：`BinaryExpressionSyntax: .56 + Math.Min(.12, .018 * Math.Log10(1d + fans))`
- `System.Math.Round(double)`；输入表达式：`Math.Round(reach * (.65 + .7 * Variation(seed, "reach")) * (2 * support - 1))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(reach * (.65 + .7 * Variation(seed, "reach")) * (2 * support - 1))`
- `System.Math.Sqrt(double)`；输入表达式：`Math.Sqrt(fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: 12 + Math.Sqrt(fans)`
- `System.Math.Sqrt(double)`；输入表达式：`Math.Sqrt(prominence)`；返回值紧邻使用处：`BinaryExpressionSyntax: .25 * Math.Sqrt(prominence)`
- `System.Math.Sqrt(double)`；输入表达式：`Math.Sqrt(targetFans / (1d + fans + targetFans))`；返回值紧邻使用处：`BinaryExpressionSyntax: .22 * tone * Math.Sqrt(targetFans / (1d + fans + targetFans))`

**赋值（含属性/字段和局部值）：**

- `reach` *= `.6`
- `support` += `.02`
- `support` += `.03 * tone`
- `support` += `.04 * tone`
- `support` += `.22 * tone * Math.Sqrt(targetFans / (1d + fans + targetFans))`
- `support` = `Math.Clamp(support, .05, .95)`

<a id="symbol-92501d24e9b4"></a>

## `NationalSpire.CommunityVotes.Variation(string, string) — private static double Variation(string seed, string purpose)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Calculate(string, string, string, string, bool, int)`](CommunityVotes.cs.md#symbol-54fc15197a4f)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(seed + ":audience:" + purpose)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(seed + ":audience:" + purpose) / (double)int.MaxValue`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7543cddd6c93"></a>

## `NationalSpire.CommunityVotes.Tone(string) — private static int Tone(string body)`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Calculate(string, string, string, string, bool, int)`](CommunityVotes.cs.md#symbol-54fc15197a4f)

**调用：** `string?.AsSpan(int)`；`System.Math.Sign(int)`；`System.ReadOnlySpan<char>.StartsWith(System.ReadOnlySpan<char>, System.StringComparison)`

**字段、属性、事件及方法组引用：** `(string Text, int Tone).Text`；`(string Text, int Tone).Tone`；`NationalSpire.CommunityVotes.Expressions`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string?.AsSpan(int)`；输入表达式：`body.AsSpan(i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.AsSpan(i).StartsWith`
- `System.Math.Sign(int)`；输入表达式：`Math.Sign(total)`；返回值紧邻使用处：`ReturnStatementSyntax: return Math.Sign(total);`
- `System.ReadOnlySpan<char>.StartsWith(System.ReadOnlySpan<char>, System.StringComparison)`；输入表达式：`body.AsSpan(i).StartsWith(expression.Text, StringComparison.Ordinal)`；返回值紧邻使用处：`IfStatementSyntax: if (body.AsSpan(i).StartsWith(expression.Text, StringComparison.Ordinal))                  { total += expression.Tone; i += expression.Text.Length - 1; break; }`

**赋值（含属性/字段和局部值）：**

- `i` += `expression.Text.Length - 1`
- `total` += `expression.Tone`

<a id="symbol-64add1fe8f21"></a>

## `NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string) — private static int Choice(Dictionary<string, int>? votes, string voter)`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-37dbe54453ea)；[`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-9cdbeae87bc5)；[`NationalSpire.CommunityVotes.SetVote(NationalSpire.CareerData, string, string, int, string)`](CommunityVotes.cs.md#symbol-99e71e3dfed8)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(voter)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: votes?.GetValueOrDefault(voter)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-597f1c902b0a"></a>

## `NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?) — private static long Score(long audience, Dictionary<string, int>? votes)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Score(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-c51f3ec0b04f)；[`NationalSpire.CommunityVotes.Score(NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-90f30ba43b83)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`.Values.Where(v => v is -1 or 1).Sum(v => (long)v)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: votes?.Values.Where(v => v is -1 or 1).Sum(v => (long)v)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Values.Where(v => v is -1 or 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Values.Where(v => v is -1 or 1).Sum`

**赋值（含属性/字段和局部值）：**


<a id="symbol-99e71e3dfed8"></a>

## `NationalSpire.CommunityVotes.SetVote(NationalSpire.CareerData, string, string, int, string) — public static bool SetVote(CareerData data, string postId, string replyId, int vote, string voterId = "player")`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`Vote(int)`](CommunityScreen.cs.md#symbol-7043154d7107)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`](CommunityVotes.cs.md#symbol-64add1fe8f21)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.PlayerVotes`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.VoteRevision`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.PlayerVotes`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).FirstOrDefault`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, voterId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.IsHuman(data, voterId)`
- `NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`；输入表达式：`Choice(votes, voterId)`；返回值紧邻使用处：`BinaryExpressionSyntax: Choice(votes, voterId) == vote`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`votes.Remove(voterId)`；返回值紧邻使用处：`ExpressionStatementSyntax: votes.Remove(voterId);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).FirstOrDefault(p => p.Id == postId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.All(data).FirstOrDefault(p => p.Id == postId)              ?? throw new InvalidOperationException("帖子已不存在。")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.FirstOrDefault(r => r.Id == replyId)`；返回值紧邻使用处：`BinaryExpressionSyntax: post.Replies.FirstOrDefault(r => r.Id == replyId)              ?? throw new InvalidOperationException("回复的楼层已不存在。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("回复的楼层已不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("回复的楼层已不存在。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("帖子已不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("帖子已不存在。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("投票玩家无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("投票玩家无效。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("赞踩选择无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("赞踩选择无效。");`

**赋值（含属性/字段和局部值）：**

- `post.PlayerVotes` ??= `[]`
- `reply.PlayerVotes` ??= `[]`
- `votes[voterId]` = `vote`
