# CommunityVotes.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0768961B7889E6BE8FB03F1AB503F9F7F9CEC3497F95C731D627C97BD600B7E7`。来源：[源码](../../CommunityVotes.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CommunityVotes`。

字段、事件及初始值（源码原样）：

```csharp
private const int AudienceMultiplier = 6;
private const int PlayerReplyMultiplier = 16;
```

<a id="symbol-6ae34f6f4987"></a>

## `NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData) — public static string VoterId(CareerData data)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-37dbe54453ea)；[`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-9cdbeae87bc5)；[`Vote(int)`](CommunityScreen.cs.md#symbol-9b125b1411ff)

**调用：** `string.IsNullOrEmpty(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(data.LocalHumanId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrEmpty(data.LocalHumanId) ? "player" : data.LocalHumanId`

**赋值（含属性/字段和局部值）：**


<a id="symbol-37dbe54453ea"></a>

## `NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost) — public static int Choice(CareerData data, CommunityPost post)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-c0ab06df0388)；[`Vote(int)`](CommunityScreen.cs.md#symbol-9b125b1411ff)

**调用：** [`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`](CommunityVotes.cs.md#symbol-64add1fe8f21)；[`NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`](CommunityVotes.cs.md#symbol-6ae34f6f4987)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.PlayerVotes`；`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`；`NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`；输入表达式：`Choice(post.PlayerVotes, VoterId(data))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Choice(post.PlayerVotes, VoterId(data))`
- `NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`；输入表达式：`VoterId(data)`；返回值紧邻使用处：`ArgumentSyntax: VoterId(data)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9cdbeae87bc5"></a>

## `NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply) — public static int Choice(CareerData data, CommunityReply reply)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-c0ab06df0388)；[`Vote(int)`](CommunityScreen.cs.md#symbol-9b125b1411ff)

**调用：** [`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`](CommunityVotes.cs.md#symbol-64add1fe8f21)；[`NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`](CommunityVotes.cs.md#symbol-6ae34f6f4987)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityReply.PlayerVotes`；`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`；`NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`；输入表达式：`Choice(reply.PlayerVotes, VoterId(data))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Choice(reply.PlayerVotes, VoterId(data))`
- `NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`；输入表达式：`VoterId(data)`；返回值紧邻使用处：`ArgumentSyntax: VoterId(data)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-90f30ba43b83"></a>

## `NationalSpire.CommunityVotes.Score(NationalSpire.CommunityPost) — public static long Score(CommunityPost post)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-c0ab06df0388)

**调用：** [`NationalSpire.CommunityVotes.AudienceScore(int?)`](CommunityVotes.cs.md#symbol-9f70e52b989b)；[`NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`](CommunityVotes.cs.md#symbol-597f1c902b0a)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.AiNetScore`；`NationalSpire.CommunityPost.PlayerVotes`；`NationalSpire.CommunityVotes.AudienceScore(int?)`；`NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityVotes.AudienceScore(int?)`；输入表达式：`AudienceScore(post.AiNetScore)`；返回值紧邻使用处：`ArgumentSyntax: AudienceScore(post.AiNetScore)`
- `NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`；输入表达式：`Score(AudienceScore(post.AiNetScore), post.PlayerVotes)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Score(AudienceScore(post.AiNetScore), post.PlayerVotes)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c51f3ec0b04f"></a>

## `NationalSpire.CommunityVotes.Score(NationalSpire.CareerData, NationalSpire.CommunityReply) — public static long Score(CareerData data, CommunityReply reply)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-c0ab06df0388)

**调用：** [`NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-64a35a4c39c2)；[`NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`](CommunityVotes.cs.md#symbol-597f1c902b0a)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityReply.PlayerVotes`；`NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply)`；`NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply)`；输入表达式：`AudienceScore(data, reply)`；返回值紧邻使用处：`ArgumentSyntax: AudienceScore(data, reply)`
- `NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?)`；输入表达式：`Score(AudienceScore(data, reply), reply.PlayerVotes)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Score(AudienceScore(data, reply), reply.PlayerVotes)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9f70e52b989b"></a>

## `NationalSpire.CommunityVotes.AudienceScore(int?) — public static long AudienceScore(int? basis)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Score(NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-90f30ba43b83)；[`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-c0ab06df0388)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityVotes.AudienceMultiplier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-64a35a4c39c2"></a>

## `NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply) — public static long AudienceScore(CareerData data, CommunityReply reply)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Score(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-c51f3ec0b04f)；[`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-c0ab06df0388)

**调用：** [`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityReply.AiNetScore`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityVotes.AudienceMultiplier`；`NationalSpire.CommunityVotes.PlayerReplyMultiplier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, reply.AuthorId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CommunityThreads.IsHuman(data, reply.AuthorId) ? PlayerReplyMultiplier : AudienceMultiplier`

**赋值（含属性/字段和局部值）：**


<a id="symbol-64add1fe8f21"></a>

## `NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string) — private static int Choice(Dictionary<string, int>? votes, string voter)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-37dbe54453ea)；[`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-9cdbeae87bc5)；[`NationalSpire.CommunityVotes.SetVote(NationalSpire.CareerData, string, string, int, string)`](CommunityVotes.cs.md#symbol-99e71e3dfed8)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(voter)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: votes?.GetValueOrDefault(voter)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-597f1c902b0a"></a>

## `NationalSpire.CommunityVotes.Score(long, System.Collections.Generic.Dictionary<string, int>?) — private static long Score(long audience, Dictionary<string, int>? votes)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVotes.Score(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-c51f3ec0b04f)；[`NationalSpire.CommunityVotes.Score(NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-90f30ba43b83)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`.Values.Where(v => v is -1 or 1).Sum(v => (long)v)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: votes?.Values.Where(v => v is -1 or 1).Sum(v => (long)v)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Values.Where(v => v is -1 or 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Values.Where(v => v is -1 or 1).Sum`

**赋值（含属性/字段和局部值）：**


<a id="symbol-99e71e3dfed8"></a>

## `NationalSpire.CommunityVotes.SetVote(NationalSpire.CareerData, string, string, int, string) — public static bool SetVote(CareerData data, string postId, string replyId, int vote, string voterId = "player")`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`Vote(int)`](CommunityScreen.cs.md#symbol-9b125b1411ff)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`](CommunityVotes.cs.md#symbol-64add1fe8f21)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.PlayerVotes`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.VoteRevision`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.PlayerVotes`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).FirstOrDefault`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, voterId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.IsHuman(data, voterId)`
- `NationalSpire.CommunityVotes.Choice(System.Collections.Generic.Dictionary<string, int>?, string)`；输入表达式：`Choice(votes, voterId)`；返回值紧邻使用处：`BinaryExpressionSyntax: Choice(votes, voterId) == vote`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`votes.Remove(voterId)`；返回值紧邻使用处：`ExpressionStatementSyntax: votes.Remove(voterId);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).FirstOrDefault(p => p.Id == postId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.All(data).FirstOrDefault(p => p.Id == postId) ?? throw new InvalidOperationException("帖子已不存在。")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.FirstOrDefault(r => r.Id == replyId)`；返回值紧邻使用处：`BinaryExpressionSyntax: post.Replies.FirstOrDefault(r => r.Id == replyId) ?? throw new InvalidOperationException("回复的楼层已不存在。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("回复的楼层已不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("回复的楼层已不存在。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("帖子已不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("帖子已不存在。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("投票玩家无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("投票玩家无效。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("赞踩选择无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("赞踩选择无效。");`

**赋值（含属性/字段和局部值）：**

- `post.PlayerVotes` ??= `[]`
- `reply.PlayerVotes` ??= `[]`
- `votes[voterId]` = `vote`

<a id="symbol-62957e04a626"></a>

## `NationalSpire.CommunityVotes.ApplyScore(NationalSpire.CommunityPost, int?, long) — public static bool ApplyScore(CommunityPost post, int? score, long sourceRevision)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyDiscussionCore(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, NationalSpire.AiService.DiscussionPermission>)`](AiDiscussion.cs.md#symbol-6abdfac46f41)；[`NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?)`](AiService.cs.md#symbol-5cb9c2055e1c)；[`NationalSpire.Coop.CoopAi.MergeDiscussionScores(NationalSpire.CommunityPost, NationalSpire.CommunityPost, System.Collections.Generic.Dictionary<(string Post, string Reply), (int? Score, long Revision)>)`](Coop/CoopAi.cs.md#symbol-bf25f3b77c21)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](Coop/CoopAi.cs.md#symbol-b4b98ce85f62)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.AiNetScore`；`NationalSpire.CommunityPost.AiScoreRevision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `post.AiNetScore` = `score`
- `post.AiScoreRevision` = `sourceRevision`

<a id="symbol-b9bf9c21b949"></a>

## `NationalSpire.CommunityVotes.ApplyScore(NationalSpire.CommunityReply, int?, long) — public static bool ApplyScore(CommunityReply reply, int? score, long sourceRevision)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyDiscussionCore(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, NationalSpire.AiService.DiscussionPermission>)`](AiDiscussion.cs.md#symbol-6abdfac46f41)；[`NationalSpire.AiService.ParseReplies(System.Text.Json.JsonElement, NationalSpire.CommunityPost, System.Collections.Generic.ISet<string>, bool, int, System.Collections.Generic.ISet<string>?, long?)`](AiDiscussion.cs.md#symbol-cc4afef5e780)；[`NationalSpire.Coop.CoopAi.MergeDiscussionScores(NationalSpire.CommunityPost, NationalSpire.CommunityPost, System.Collections.Generic.Dictionary<(string Post, string Reply), (int? Score, long Revision)>)`](Coop/CoopAi.cs.md#symbol-bf25f3b77c21)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](Coop/CoopAi.cs.md#symbol-b4b98ce85f62)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityReply.AiNetScore`；`NationalSpire.CommunityReply.AiScoreRevision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `reply.AiNetScore` = `score`
- `reply.AiScoreRevision` = `sourceRevision`
