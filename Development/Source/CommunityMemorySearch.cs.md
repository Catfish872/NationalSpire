# CommunityMemorySearch.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`DADA30D476354BBB8EB86CB508204DDD318DE2EFC875F9D669DBA1D6CD0716D3`。来源：[源码](../../CommunityMemorySearch.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CommunityMemorySearch`、`NationalSpire.CommunityMemorySearch.Request`、`NationalSpire.CommunityMemorySearch.PostActivity`、`NationalSpire.CommunityMemorySearch.ReplyTerms`、`NationalSpire.CommunityMemorySearch.Document`、`NationalSpire.CommunityMemorySearch.Search`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Dictionary<string, HashSet<string>> _terms = new(StringComparer.Ordinal);
private readonly Dictionary<(CareerData Data, int Day, string Query), Search> _searches = [];
private readonly Dictionary<(CareerData Data, int Day), Dictionary<string, PostActivity>> _posts = [];
private readonly Dictionary<(CommunityPost Post, string Query), bool> _topics = [];
private readonly Dictionary<(CareerData Data, int Day, string Person), List<CommunityMemory>> _acquaintances = [];
private readonly Dictionary<(CareerData Data, int Day), (Dictionary<string, CommunityPost> Posts, ILookup<string, CommunityMemory> People)> _acquaintancePools = [];
private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<CareerData, System.Collections.Concurrent.ConcurrentDictionary<string, (string Text, HashSet<string> Terms)>> Indexes = new();
private static readonly HashSet<string> ConversationNoise = ["今天", "明天", "昨天", "什么", "为什", "么是", "怎么", "知道", "这个", "那个", "现在", "时候", "事情", "没有", "不是", "可以", "还是", "到底", "一下", "你好", "在吗", "在不", "不在", "你说", "说的", "我们", "你们", "自己", "能不", "不能", "觉得"];
private string _text = "";
private HashSet<string> _terms = [];
private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<CommunityReply, ReplyTerms> ReplyIndexes = new();
```

<a id="symbol-67dafab02c86"></a>

## `NationalSpire.CommunityMemorySearch.Request.AcquaintancePool(NationalSpire.CareerData) — internal (Dictionary<string, CommunityPost> Posts, ILookup<string, CommunityMemory> People) AcquaintancePool(CareerData data)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-5c9e3196ce58)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(string id, NationalSpire.CommunityMemory m).id`；`(string id, NationalSpire.CommunityMemory m).m`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Day`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemorySearch.Request._acquaintancePools`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).DistinctBy`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.NewsPending(data, post)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_acquaintancePools.Add(key, pool)`；返回值紧邻使用处：`ExpressionStatementSyntax: _acquaintancePools.Add(key, pool);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_acquaintancePools.TryGetValue(key, out var pool)`；返回值紧邻使用处：`IfStatementSyntax: if (_acquaintancePools.TryGetValue(key, out var pool)) return pool;`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`posts.TryGetValue(m.PostId, out var post)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !posts.TryGetValue(m.PostId, out var post)`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`data.CommunityMemories.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.CommunityMemories.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`m.People.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.People.Distinct().Select`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CommunityThreads.All(data).DistinctBy(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).DistinctBy(p => p.Id).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`data.CommunityMemories.AsEnumerable().Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.CommunityMemories.AsEnumerable().Reverse().Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`m.People.Distinct().Select(id => (id, m))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => m.People.Distinct().Select(id => (id, m))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`available.SelectMany(m => m.People.Distinct().Select(id => (id, m)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.SelectMany(m => m.People.Distinct().Select(id => (id, m))).ToLookup`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CommunityThreads.All(data).DistinctBy(p => p.Id).ToDictionary(p => p.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).DistinctBy(p => p.Id).ToDictionary(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`available.SelectMany(m => m.People.Distinct().Select(id => (id, m))).ToLookup(x => x.id, x => x.m)`；返回值紧邻使用处：`ArgumentSyntax: available.SelectMany(m => m.People.Distinct().Select(id => (id, m))).ToLookup(x => x.id, x => x.m)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.CommunityMemories.AsEnumerable().Reverse().Where(m => m.Day <= data.Day &&                  (!posts.TryGetValue(m.PostId, out var post) || !CommunityThreads.NewsPending(data, post)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.CommunityMemories.AsEnumerable().Reverse().Where(m => m.Day <= data.Day &&                  (!posts.TryGetValue(m.PostId, out var post) || !CommunityThreads.NewsPending(data, post)))`

**赋值（含属性/字段和局部值）：**

- `pool` = `(posts, available.SelectMany(m => m.People.Distinct().Select(id => (id, m))).ToLookup(x => x.id, x => x.m))`

<a id="symbol-6d86e3dcd515"></a>

## `NationalSpire.CommunityMemorySearch.Request.Posts(NationalSpire.CareerData) — internal Dictionary<string, PostActivity> Posts(CareerData data)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.SelectCommunity(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-434624537026)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；`NationalSpire.CommunityMemorySearch.PostActivity.PostActivity(NationalSpire.CommunityPost, System.Collections.Generic.Dictionary<string, int>, bool)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CommunityMemorySearch.Request._posts`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.PostActivity.PostActivity(NationalSpire.CommunityPost, System.Collections.Generic.Dictionary<string, int>, bool)`；输入表达式：`new PostActivity(p, activity, p.AuthorId == human || p.RelatedPeople.Contains(human) || activity.ContainsKey(human))`；返回值紧邻使用处：`ReturnStatementSyntax: return new PostActivity(p, activity, p.AuthorId == human || p.RelatedPeople.Contains(human) || activity.ContainsKey(human));`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.NewsPending(data, p)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_posts.Add(key, posts)`；返回值紧邻使用处：`ExpressionStatementSyntax: _posts.Add(key, posts);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`activity.ContainsKey(human)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.AuthorId == human || p.RelatedPeople.Contains(human) || activity.ContainsKey(human)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_posts.TryGetValue(key, out var posts)`；返回值紧邻使用处：`IfStatementSyntax: if (_posts.TryGetValue(key, out var posts)) return posts;`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`p.Replies.Where(r => r.Day <= data.Day).GroupBy(r => r.AuthorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.Where(r => r.Day <= data.Day).GroupBy(r => r.AuthorId).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, int>)`；输入表达式：`g.Max(r => r.Day)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Max(r => r.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`CommunityThreads.All(data).Where(p => p.Day <= data.Day && !CommunityThreads.NewsPending(data, p)).ToDictionary(p => p.Id, p =>              {                  var activity = p.Replies.Where(r => r.Day <= data.Day).GroupBy(r => r.AuthorId).ToDictionary(g => g.Key, g => g.Max(r => r.Day));                  return new PostActivity(p, activity, p.AuthorId == human || p.RelatedPeople.Contains(human) || activity.ContainsKey(human));              })`；返回值紧邻使用处：`AssignmentExpressionSyntax: posts = CommunityThreads.All(data).Where(p => p.Day <= data.Day && !CommunityThreads.NewsPending(data, p)).ToDictionary(p => p.Id, p =>              {                  var activity = p.Replies.Where(r => r.Day <= data.Day).GroupBy(r => r.AuthorId).ToDictionary(g => g.Key, g => g.Max(r => r.Day));                  return new PostActivity(p, activity, p.AuthorId == human || p.RelatedPeople.Contains(human) || activity.ContainsKey(human));              })`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`p.Replies.Where(r => r.Day <= data.Day).GroupBy(r => r.AuthorId).ToDictionary(g => g.Key, g => g.Max(r => r.Day))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = p.Replies.Where(r => r.Day <= data.Day).GroupBy(r => r.AuthorId).ToDictionary(g => g.Key, g => g.Max(r => r.Day))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Where(p => p.Day <= data.Day && !CommunityThreads.NewsPending(data, p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => p.Day <= data.Day && !CommunityThreads.NewsPending(data, p)).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Replies.Where(r => r.Day <= data.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.Where(r => r.Day <= data.Day).GroupBy`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`p.RelatedPeople.Contains(human)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.AuthorId == human || p.RelatedPeople.Contains(human)`

**赋值（含属性/字段和局部值）：**

- `posts` = `CommunityThreads.All(data).Where(p => p.Day <= data.Day && !CommunityThreads.NewsPending(data, p)).ToDictionary(p => p.Id, p =>              {                  var activity = p.Replies.Where(r => r.Day <= data.Day).GroupBy(r => r.AuthorId).ToDictionary(g => g.Key, g => g.Max(r => r.Day));                  return new PostActivity(p, activity, p.AuthorId == human || p.RelatedPeople.Contains(human) || activity.ContainsKey(human));              })`

<a id="symbol-e2d99449e7e2"></a>

## `NationalSpire.CommunityMemorySearch.Request.Topic(NationalSpire.CommunityPost, string) — internal bool Topic(CommunityPost post, string query)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?, int?)`](PrivatePublicContext.cs.md#symbol-58aebbb834b8)；[`Topic(NationalSpire.CommunityPost)`](PrivatePublicContext.cs.md#symbol-ba0de9837f75)

**调用：** [`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-9f4e57953da4)；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`；`NationalSpire.CommunityMemorySearch.Request._topics`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`；输入表达式：`MatchesTopic(query, post.Title + "\n" + post.Body, this)`；返回值紧邻使用处：`AssignmentExpressionSyntax: result = MatchesTopic(query, post.Title + "\n" + post.Body, this)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_topics.Add((post, query), result = MatchesTopic(query, post.Title + "\n" + post.Body, this))`；返回值紧邻使用处：`ExpressionStatementSyntax: _topics.Add((post, query), result = MatchesTopic(query, post.Title + "\n" + post.Body, this));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_topics.TryGetValue((post, query), out bool result)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_topics.TryGetValue((post, query), out bool result)`

**赋值（含属性/字段和局部值）：**

- `result` = `MatchesTopic(query, post.Title + "\n" + post.Body, this)`

<a id="symbol-a0786238240c"></a>

## `NationalSpire.CommunityMemorySearch.Request.Acquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson) — internal List<CommunityMemory> Acquaintance(CareerData data, CareerPerson person)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.SelectCommunity(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-434624537026)

**调用：** [`NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-5c9e3196ce58)；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.List<T>.List(System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.CommunityMemorySearch.Request?)`；`NationalSpire.CommunityMemorySearch.Request._acquaintances`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.CommunityMemorySearch.Request?)`；输入表达式：`PrivateAcquaintance(data, person, this)`；返回值紧邻使用处：`AssignmentExpressionSyntax: records = PrivateAcquaintance(data, person, this)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_acquaintances.Add(key, records = PrivateAcquaintance(data, person, this))`；返回值紧邻使用处：`ExpressionStatementSyntax: _acquaintances.Add(key, records = PrivateAcquaintance(data, person, this));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_acquaintances.TryGetValue(key, out var records)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_acquaintances.TryGetValue(key, out var records)`
- `System.Collections.Generic.List<T>.List(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new(records)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(records);`

**赋值（含属性/字段和局部值）：**

- `records` = `PrivateAcquaintance(data, person, this)`

<a id="symbol-44f4b761a62f"></a>

## `NationalSpire.CommunityMemorySearch.Request.Prepare(NationalSpire.CareerData, int, string) — internal Search Prepare(CareerData data, int day, string query)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)

**调用：** [`NationalSpire.CommunityMemorySearch.BuildSearch(NationalSpire.CareerData, int, System.Collections.Generic.HashSet<string>)`](CommunityMemorySearch.cs.md#symbol-a0f6a3280fc9)；[`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`](CommunityMemorySearch.cs.md#symbol-291651d7ac15)；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.BuildSearch(NationalSpire.CareerData, int, System.Collections.Generic.HashSet<string>)`；`NationalSpire.CommunityMemorySearch.Request._searches`；`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.BuildSearch(NationalSpire.CareerData, int, System.Collections.Generic.HashSet<string>)`；输入表达式：`BuildSearch(data, day, GetTerms(query))`；返回值紧邻使用处：`AssignmentExpressionSyntax: search = BuildSearch(data, day, GetTerms(query))`
- `NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；输入表达式：`GetTerms(query)`；返回值紧邻使用处：`ArgumentSyntax: GetTerms(query)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_searches.Add(key, search = BuildSearch(data, day, GetTerms(query)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _searches.Add(key, search = BuildSearch(data, day, GetTerms(query)));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_searches.TryGetValue(key, out var search)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_searches.TryGetValue(key, out var search)`

**赋值（含属性/字段和局部值）：**

- `search` = `BuildSearch(data, day, GetTerms(query))`

<a id="symbol-291651d7ac15"></a>

## `NationalSpire.CommunityMemorySearch.Request.GetTerms(string) — internal HashSet<string> GetTerms(string text)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-9f4e57953da4)；[`NationalSpire.CommunityMemorySearch.Request.Prepare(NationalSpire.CareerData, int, string)`](CommunityMemorySearch.cs.md#symbol-44f4b761a62f)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)；[`NationalSpire.CommunityMemorySearch.TopicScore(string, NationalSpire.CommunityReply, NationalSpire.CommunityMemorySearch.Request)`](CommunityMemorySearch.cs.md#symbol-719e0030a43a)；[`NationalSpire.CommunityPromptContext.SelectReplies(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, System.Collections.Generic.IEnumerable<string>, string, NationalSpire.CommunityMemorySearch.Request)`](CommunityPromptContext.cs.md#symbol-bf9e66b04457)

**调用：** [`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.Request._terms`；`NationalSpire.CommunityMemorySearch.Terms(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: terms = Terms(text)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_terms.Add(text, terms = Terms(text))`；返回值紧邻使用处：`ExpressionStatementSyntax: _terms.Add(text, terms = Terms(text));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_terms.TryGetValue(text, out var terms)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_terms.TryGetValue(text, out var terms)`

**赋值（含属性/字段和局部值）：**

- `terms` = `Terms(text)`

<a id="symbol-96d927ec7e23"></a>

## `NationalSpire.CommunityMemorySearch.Terms(string) — private static HashSet<string> Terms(string text)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.BuildSearch(NationalSpire.CareerData, int, System.Collections.Generic.HashSet<string>)`](CommunityMemorySearch.cs.md#symbol-a0f6a3280fc9)；[`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-9f4e57953da4)；[`NationalSpire.CommunityMemorySearch.ReplyTerms.Get(string)`](CommunityMemorySearch.cs.md#symbol-a1e834000caf)；[`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`](CommunityMemorySearch.cs.md#symbol-291651d7ac15)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)

**调用：** [`Chinese(char)`](CommunityMemorySearch.cs.md#symbol-3031147dca39)；[`Latin(char)`](CommunityMemorySearch.cs.md#symbol-f0dba47a47e5)；`string.Substring(int, int)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`

**字段、属性、事件及方法组引用：** `Chinese(char)`；`Latin(char)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Chinese(char)`；输入表达式：`Chinese(text[i])`；返回值紧邻使用处：`BinaryExpressionSyntax: i < text.Length && Chinese(text[i])`
- `Chinese(char)`；输入表达式：`Chinese(text[i])`；返回值紧邻使用处：`IfStatementSyntax: if (Chinese(text[i]))              {                  while (i < text.Length && Chinese(text[i])) i++;                  for (int j = start; j + 1 < i; j++) terms.Add(text.Substring(j, 2));              }              else i++;`
- `Latin(char)`；输入表达式：`Latin(text[i])`；返回值紧邻使用处：`BinaryExpressionSyntax: i < text.Length && Latin(text[i])`
- `Latin(char)`；输入表达式：`Latin(text[i])`；返回值紧邻使用处：`IfStatementSyntax: if (Latin(text[i]))              {                  while (i < text.Length && Latin(text[i])) i++;                  terms.Add(text[start..i]);              }              else if (Chinese(text[i]))              {                  while (i < text.Length && Chinese(text[i])) i++;                  for (int j = start; j + 1 < i; j++) terms.Add(text.Substring(j, 2));              }              else i++;`
- `string.Substring(int, int)`；输入表达式：`text.Substring(j, 2)`；返回值紧邻使用处：`ArgumentSyntax: text.Substring(j, 2)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`terms.Add(text.Substring(j, 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: terms.Add(text.Substring(j, 2));`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`terms.Add(text[start..i])`；返回值紧邻使用处：`ExpressionStatementSyntax: terms.Add(text[start..i]);`
- `System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；输入表达式：`new HashSet<string>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>(StringComparer.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f0dba47a47e5"></a>

## `Latin(char) — static bool Latin(char c)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3031147dca39"></a>

## `Chinese(char) — static bool Chinese(char c)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9f4e57953da4"></a>

## `NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?) — public static bool MatchesTopic(string query, string text, Request? request = null)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.Request.Topic(NationalSpire.CommunityPost, string)`](CommunityMemorySearch.cs.md#symbol-e2d99449e7e2)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?, bool)`](PrivatePublicContext.cs.md#symbol-b4d8110deb5b)

**调用：** [`NationalSpire.CommunityMemorySearch.MatchesTopic(System.Collections.Generic.HashSet<string>, System.Collections.Generic.HashSet<string>)`](CommunityMemorySearch.cs.md#symbol-84bd8ee29a0a)；[`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`](CommunityMemorySearch.cs.md#symbol-291651d7ac15)；[`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.ConversationNoise`；`NationalSpire.CommunityMemorySearch.MatchesTopic(System.Collections.Generic.HashSet<string>, System.Collections.Generic.HashSet<string>)`；`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；`NationalSpire.CommunityMemorySearch.Terms(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.MatchesTopic(System.Collections.Generic.HashSet<string>, System.Collections.Generic.HashSet<string>)`；输入表达式：`MatchesTopic(queryTerms, textTerms)`；返回值紧邻使用处：`ReturnStatementSyntax: return MatchesTopic(queryTerms, textTerms);`
- `NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；输入表达式：`.GetTerms(query)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: request?.GetTerms(query)`
- `NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；输入表达式：`.GetTerms(text)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: request?.GetTerms(text)`
- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(query)`；返回值紧邻使用处：`BinaryExpressionSyntax: request?.GetTerms(query) ?? Terms(query)`
- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(text)`；返回值紧邻使用处：`BinaryExpressionSyntax: request?.GetTerms(text) ?? Terms(text)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ConversationNoise.Contains(t)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ConversationNoise.Contains(t)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`queryTerms.Count(t => !ConversationNoise.Contains(t))`；返回值紧邻使用处：`BinaryExpressionSyntax: queryTerms.Count(t => !ConversationNoise.Contains(t)) < 2`

**赋值（含属性/字段和局部值）：**


<a id="symbol-84bd8ee29a0a"></a>

## `NationalSpire.CommunityMemorySearch.MatchesTopic(System.Collections.Generic.HashSet<string>, System.Collections.Generic.HashSet<string>) — private static bool MatchesTopic(HashSet<string> queryTerms, HashSet<string> textTerms)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-9f4e57953da4)

**调用：** `System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.ConversationNoise`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ConversationNoise.Contains(term)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ConversationNoise.Contains(term)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`textTerms.Contains(term)`；返回值紧邻使用处：`BinaryExpressionSyntax: !ConversationNoise.Contains(term) && textTerms.Contains(term)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a1e834000caf"></a>

## `NationalSpire.CommunityMemorySearch.ReplyTerms.Get(string) — internal HashSet<string> Get(string text)`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.TopicScore(System.Collections.Generic.HashSet<string>, NationalSpire.CommunityReply)`](CommunityMemorySearch.cs.md#symbol-1574d9dfc61f)

**调用：** [`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.ReplyTerms._terms`；`NationalSpire.CommunityMemorySearch.ReplyTerms._text`；`NationalSpire.CommunityMemorySearch.Terms(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _terms = Terms(text)`

**赋值（含属性/字段和局部值）：**

- `_terms` = `Terms(text)`
- `_text` = `text`

<a id="symbol-719e0030a43a"></a>

## `NationalSpire.CommunityMemorySearch.TopicScore(string, NationalSpire.CommunityReply, NationalSpire.CommunityMemorySearch.Request) — public static double TopicScore(string query, CommunityReply reply, Request request)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`](CommunityMemorySearch.cs.md#symbol-291651d7ac15)；[`NationalSpire.CommunityMemorySearch.TopicScore(System.Collections.Generic.HashSet<string>, NationalSpire.CommunityReply)`](CommunityMemorySearch.cs.md#symbol-1574d9dfc61f)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；`NationalSpire.CommunityMemorySearch.TopicScore(System.Collections.Generic.HashSet<string>, NationalSpire.CommunityReply)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；输入表达式：`request.GetTerms(query)`；返回值紧邻使用处：`ArgumentSyntax: request.GetTerms(query)`
- `NationalSpire.CommunityMemorySearch.TopicScore(System.Collections.Generic.HashSet<string>, NationalSpire.CommunityReply)`；输入表达式：`TopicScore(request.GetTerms(query), reply)`；返回值紧邻使用处：`ReturnStatementSyntax: return TopicScore(request.GetTerms(query), reply);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1574d9dfc61f"></a>

## `NationalSpire.CommunityMemorySearch.TopicScore(System.Collections.Generic.HashSet<string>, NationalSpire.CommunityReply) — internal static double TopicScore(HashSet<string> queryTerms, CommunityReply reply)`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.TopicScore(string, NationalSpire.CommunityReply, NationalSpire.CommunityMemorySearch.Request)`](CommunityMemorySearch.cs.md#symbol-719e0030a43a)；[`NationalSpire.CommunityPromptContext.SelectReplies(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, System.Collections.Generic.IEnumerable<string>, string, NationalSpire.CommunityMemorySearch.Request)`](CommunityPromptContext.cs.md#symbol-bf9e66b04457)

**调用：** [`NationalSpire.CommunityMemorySearch.ReplyTerms.Get(string)`](CommunityMemorySearch.cs.md#symbol-a1e834000caf)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Math.Max(int, int)`；`System.Math.Sqrt(double)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.ConversationNoise`；`NationalSpire.CommunityMemorySearch.ReplyIndexes`；`NationalSpire.CommunityMemorySearch.ReplyTerms.Get(string)`；`NationalSpire.CommunityReply.Body`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.ReplyTerms.Get(string)`；输入表达式：`ReplyIndexes.GetOrCreateValue(reply).Get(reply.Body)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReplyIndexes.GetOrCreateValue(reply).Get(reply.Body)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ConversationNoise.Contains(term)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ConversationNoise.Contains(term)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`larger.Contains(term)`；返回值紧邻使用处：`BinaryExpressionSyntax: !ConversationNoise.Contains(term) && larger.Contains(term)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, terms.Count)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, terms.Count)`
- `System.Math.Sqrt(double)`；输入表达式：`Math.Sqrt(Math.Max(1, terms.Count))`；返回值紧邻使用处：`BinaryExpressionSyntax: matches / Math.Sqrt(Math.Max(1, terms.Count))`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`ReplyIndexes.GetOrCreateValue(reply)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ReplyIndexes.GetOrCreateValue(reply).Get`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5c9e3196ce58"></a>

## `NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.CommunityMemorySearch.Request?) — public static List<CommunityMemory> PrivateAcquaintance(CareerData data, CareerPerson person, Request? request = null)`

来源：源码第 126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.Request.Acquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CommunityMemorySearch.cs.md#symbol-a0786238240c)

**调用：** [`NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`](AiGeneratedText.cs.md#symbol-ff263d7615f1)；[`NationalSpire.CommunityMemorySearch.Request.AcquaintancePool(NationalSpire.CareerData)`](CommunityMemorySearch.cs.md#symbol-67dafab02c86)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`NationalSpire.CommunityMemory.CommunityMemory()`；`NationalSpire.CommunityMemorySearch.Request.Request()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `(System.Collections.Generic.Dictionary<string, NationalSpire.CommunityPost> Posts, System.Linq.ILookup<string, NationalSpire.CommunityMemory> People).People`；`(System.Collections.Generic.Dictionary<string, NationalSpire.CommunityPost> Posts, System.Linq.ILookup<string, NationalSpire.CommunityMemory> People).Posts`；`NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityMemorySearch.Request.AcquaintancePool(NationalSpire.CareerData)`；`NationalSpire.CommunityPost.Title`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CommunityAcquaintance`；`Own(NationalSpire.CommunityMemory)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；输入表达式：`AiGeneratedText.Memory(m)`；返回值紧邻使用处：`ConditionalExpressionSyntax: posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)`
- `NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；输入表达式：`AiGeneratedText.Memory(m)`；返回值紧邻使用处：`InterpolationSyntax: {AiGeneratedText.Memory(m)}`
- `NationalSpire.CommunityMemory.CommunityMemory()`；输入表达式：`new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          }`
- `NationalSpire.CommunityMemorySearch.Request.AcquaintancePool(NationalSpire.CareerData)`；输入表达式：`(request ?? new()).AcquaintancePool(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (request ?? new()).AcquaintancePool(data)`
- `NationalSpire.CommunityMemorySearch.Request.Request()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: request ?? new()`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CommunityAcquaintance)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CommunityAcquaintance)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`posts.TryGetValue(m.PostId, out var post)`；返回值紧邻使用处：`ConditionalExpressionSyntax: posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`person.HandleAliases.Append(person.PublicName)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: person.HandleAliases.Append(person.PublicName).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`own.Concat(shared)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: own.Concat(shared).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`own.Concat(shared).DistinctBy(m => m.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: own.Concat(shared).DistinctBy(m => m.Id).Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))              .OrderByDescending(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))              .OrderByDescending(m => m.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`available.Where(Own).OrderByDescending(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(Own).OrderByDescending(m => m.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`own.Concat(shared).DistinctBy(m => m.Id).Select(m => new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: own.Concat(shared).DistinctBy(m => m.Id).Select(m => new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))              .OrderByDescending(m => m.Day).Take(2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))              .OrderByDescending(m => m.Day).Take(2)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`available.Where(Own).OrderByDescending(m => m.Day).Take(3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = available.Where(Own).OrderByDescending(m => m.Day).Take(3)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`own.Concat(shared).DistinctBy(m => m.Id).Select(m => new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          }).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return own.Concat(shared).DistinctBy(m => m.Id).Select(m => new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          }).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))              .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`available.Where(Own)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(Own).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`m.People.Contains(human)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`m.People.Contains(person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Kind == "fact" && m.People.Contains(person.Id)`

**赋值（含属性/字段和局部值）：**

- `Day` = `m.Day`
- `Id` = `m.Id`
- `Kind` = `m.Kind`
- `People` = `m.People`
- `PostId` = `m.PostId`
- `Text` = `posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)`

<a id="symbol-b0ac4439e971"></a>

## `Own(NationalSpire.CommunityMemory) — bool Own(CommunityMemory m)`

来源：源码第 134 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string, System.StringComparison)`；输入表达式：`m.Text.StartsWith(name + "：", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Text.StartsWith(name + "：", StringComparison.Ordinal) || m.Text.StartsWith(name + "发帖", StringComparison.Ordinal)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`m.Text.StartsWith(name + "发帖", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Text.StartsWith(name + "：", StringComparison.Ordinal) || m.Text.StartsWith(name + "发帖", StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`names.Any(name =>              m.Text.StartsWith(name + "：", StringComparison.Ordinal) || m.Text.StartsWith(name + "发帖", StringComparison.Ordinal))`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Kind == "opinion" && m.People.Contains(person.Id) && names.Any(name =>              m.Text.StartsWith(name + "：", StringComparison.Ordinal) || m.Text.StartsWith(name + "发帖", StringComparison.Ordinal))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`m.People.Contains(person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Kind == "opinion" && m.People.Contains(person.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f933ce4e4ad8"></a>

## `NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?) — public static List<CommunityMemory> Retrieve(CareerData data, string query, IEnumerable<string> people, int day, ISet<string> excludedPosts, int count = 6, ISet<string>? excludedMemories = null, bool requireTopic = false, Request? request = null)`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiContext.cs.md#symbol-7b21630a9e2c)；[`NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string)`](PromptTesting.cs.md#symbol-c81f52ee7090)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.PrivatePublicContext.SelectCommunity(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-434624537026)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** [`NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`](AiGeneratedText.cs.md#symbol-ff263d7615f1)；[`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`](CommunityMemorySearch.cs.md#symbol-291651d7ac15)；[`NationalSpire.CommunityMemorySearch.Request.Prepare(NationalSpire.CareerData, int, string)`](CommunityMemorySearch.cs.md#symbol-44f4b761a62f)；[`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`NationalSpire.CommunityMemory.CommunityMemory()`；`NationalSpire.CommunityMemorySearch.Request.Request()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>, System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Log(double)`

**字段、属性、事件及方法组引用：** `(string id, int weight).id`；`(string id, int weight).weight`；`NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityMemorySearch.ConversationNoise`；`NationalSpire.CommunityMemorySearch.Document.Matches`；`NationalSpire.CommunityMemorySearch.Document.Memory`；`NationalSpire.CommunityMemorySearch.Document.Topic`；`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；`NationalSpire.CommunityMemorySearch.Request.Prepare(NationalSpire.CareerData, int, string)`；`NationalSpire.CommunityMemorySearch.Search.ById`；`NationalSpire.CommunityMemorySearch.Search.ByPost`；`NationalSpire.CommunityMemorySearch.Search.Documents`；`NationalSpire.CommunityMemorySearch.Search.Frequencies`；`NationalSpire.CommunityMemorySearch.Search.Topics`；`NationalSpire.CommunityMemorySearch.Terms(string)`；`NationalSpire.GameText.Plain(string)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CommunityRetrieve`；`Score(NationalSpire.CommunityMemorySearch.Document)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；输入表达式：`AiGeneratedText.Memory(d.Memory)`；返回值紧邻使用处：`ArgumentSyntax: AiGeneratedText.Memory(d.Memory)`
- `NationalSpire.CommunityMemory.CommunityMemory()`；输入表达式：`new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) }`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory`
- `NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；输入表达式：`.GetTerms(query)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: request?.GetTerms(query)`
- `NationalSpire.CommunityMemorySearch.Request.Prepare(NationalSpire.CareerData, int, string)`；输入表达式：`(request ?? new()).Prepare(data, day, query)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (request ?? new()).Prepare(data, day, query)`
- `NationalSpire.CommunityMemorySearch.Request.Request()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: request ?? new()`
- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(query)`；返回值紧邻使用处：`BinaryExpressionSyntax: request?.GetTerms(query) ?? Terms(query)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(AiGeneratedText.Memory(d.Memory))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = GameText.Plain(AiGeneratedText.Memory(d.Memory))`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CommunityRetrieve)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CommunityRetrieve)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, int>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, int>(search.Frequencies, StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, int>(search.Frequencies, StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ConversationNoise.Contains(t)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ConversationNoise.Contains(t)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`excludedIds.Contains(d.Memory.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !excludedIds.Contains(d.Memory.Id)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`BinaryExpressionSyntax: excludedMemories ?? new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Memory.People.Any(identities.ContainsKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`(excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey).Select(id => search.ById[id]).Concat(excludedPosts.SelectMany(id => search.ByPost[id]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey).Select(id => search.ById[id]).Concat(excludedPosts.SelectMany(id => search.ByPost[id])).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`queryTerms.Count(t => !ConversationNoise.Contains(t))`；返回值紧邻使用处：`BinaryExpressionSyntax: queryTerms.Count(t => !ConversationNoise.Contains(t)) < 2`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`people.Where(id => id != "player" && id != "desk").Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Where(id => id != "player" && id != "desk").Distinct()              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`(excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey).Select(id => search.ById[id]).Concat(excludedPosts.SelectMany(id => search.ByPost[id])).DistinctBy(d => d.Memory.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey).Select(id => search.ById[id]).Concat(excludedPosts.SelectMany(id => search.ByPost[id])).DistinctBy(d => d.Memory.Id).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`(requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`people.Where(id => id != "player" && id != "desk").Distinct()              .Select((id, index) => (id, weight: index < 3 ? 8 : 3))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Where(id => id != "player" && id != "desk").Distinct()              .Select((id, index) => (id, weight: index < 3 ? 8 : 3)).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`(excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey).Select(id => search.ById[id])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey).Select(id => search.ById[id]).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`(requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count).Select(d => d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count).Select(d => d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`excluded.Select(d => d.Memory.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: excluded.Select(d => d.Memory.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`excludedPosts.SelectMany(id => search.ByPost[id])`；返回值紧邻使用处：`ArgumentSyntax: excludedPosts.SelectMany(id => search.ByPost[id])`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`(requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`(excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey).Select(id => search.ById[id]).Concat(excludedPosts.SelectMany(id => search.ByPost[id])).DistinctBy(d => d.Memory.Id).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey).Select(id => search.ById[id]).Concat(excludedPosts.SelectMany(id => search.ByPost[id])).DistinctBy(d => d.Memory.Id).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>, System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`frequencies.Where(p => p.Value > 0).ToDictionary(p => p.Key, p => Math.Log(1 + (countAvailable + 1.0) / p.Value), StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = frequencies.Where(p => p.Value > 0).ToDictionary(p => p.Key, p => Math.Log(1 + (countAvailable + 1.0) / p.Value), StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`people.Where(id => id != "player" && id != "desk").Distinct()              .Select((id, index) => (id, weight: index < 3 ? 8 : 3)).ToDictionary(x => x.id, x => x.weight)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = people.Where(id => id != "player" && id != "desk").Distinct()              .Select((id, index) => (id, weight: index < 3 ? 8 : 3)).ToDictionary(x => x.id, x => x.weight)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`excluded.Select(d => d.Memory.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = excluded.Select(d => d.Memory.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`(requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count).Select(d => d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return (requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count).Select(d => d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`frequencies.Where(p => p.Value > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: frequencies.Where(p => p.Value > 0).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Where(id => id != "player" && id != "desk")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Where(id => id != "player" && id != "desk").Distinct`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`perPost.GetValueOrDefault(d.Memory.PostId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = perPost.GetValueOrDefault(d.Memory.PostId)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`(requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where`
- `System.Math.Log(double)`；输入表达式：`Math.Log(1 + (countAvailable + 1.0) / p.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Math.Log(1 + (countAvailable + 1.0) / p.Value)`

**赋值（含属性/字段和局部值）：**

- `Day` = `d.Memory.Day`
- `Id` = `d.Memory.Id`
- `Kind` = `d.Memory.Kind`
- `People` = `d.Memory.People`
- `perPost[d.Memory.PostId]` = `used + 1`
- `PostId` = `d.Memory.PostId`
- `Text` = `GameText.Plain(AiGeneratedText.Memory(d.Memory))`

<a id="symbol-15004463e36f"></a>

## `Score(NationalSpire.CommunityMemorySearch.Document) — double Score(Document doc)`

来源：源码第 159 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(int, int)`；`System.Math.Sqrt(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemorySearch.Document.Matches`；`NationalSpire.CommunityMemorySearch.Document.Memory`；`NationalSpire.CommunityMemorySearch.Document.TermCount`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；输入表达式：`doc.Matches.Sum(t => weights[t])`；返回值紧邻使用处：`BinaryExpressionSyntax: doc.Matches.Sum(t => weights[t]) / Math.Sqrt(Math.Max(1, doc.TermCount))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`doc.Memory.People.Sum(id => identities.GetValueOrDefault(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: doc.Matches.Sum(t => weights[t]) / Math.Sqrt(Math.Max(1, doc.TermCount))              + doc.Memory.People.Sum(id => identities.GetValueOrDefault(id))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`identities.GetValueOrDefault(id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => identities.GetValueOrDefault(id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, day - doc.Memory.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, day - doc.Memory.Day) / 28.0`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, doc.TermCount)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, doc.TermCount)`
- `System.Math.Sqrt(double)`；输入表达式：`Math.Sqrt(Math.Max(1, doc.TermCount))`；返回值紧邻使用处：`BinaryExpressionSyntax: doc.Matches.Sum(t => weights[t]) / Math.Sqrt(Math.Max(1, doc.TermCount))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-77f32d8cd38f"></a>

## `NationalSpire.CommunityMemorySearch.Search.Documents — internal List<Document> Documents`

来源：源码第 172 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2d0c63df71e1"></a>

## `NationalSpire.CommunityMemorySearch.Search.Frequencies — internal Dictionary<string, int> Frequencies`

来源：源码第 173 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-aa4075f7ac47"></a>

## `NationalSpire.CommunityMemorySearch.Search.ById — internal Dictionary<string, Document> ById`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemorySearch.Document.Memory`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`documents.ToDictionary(d => d.Memory.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = documents.ToDictionary(d => d.Memory.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8c863ffedea1"></a>

## `NationalSpire.CommunityMemorySearch.Search.ByPost — internal ILookup<string, Document> ByPost`

来源：源码第 175 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemorySearch.Document.Memory`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`documents.ToLookup(d => d.Memory.PostId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = documents.ToLookup(d => d.Memory.PostId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-aecf87589881"></a>

## `NationalSpire.CommunityMemorySearch.Search.Topics — internal List<Document> Topics`

来源：源码第 176 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.Document.Topic`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`documents.Where(d => d.Topic).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = documents.Where(d => d.Topic).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`documents.Where(d => d.Topic)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: documents.Where(d => d.Topic).ToList`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a0f6a3280fc9"></a>

## `NationalSpire.CommunityMemorySearch.BuildSearch(NationalSpire.CareerData, int, System.Collections.Generic.HashSet<string>) — private static Search BuildSearch(CareerData data, int day, HashSet<string> queryTerms)`

来源：源码第 178 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.Request.Prepare(NationalSpire.CareerData, int, string)`](CommunityMemorySearch.cs.md#symbol-44f4b761a62f)

**调用：** [`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；`NationalSpire.CommunityMemorySearch.Document.Document(NationalSpire.CommunityMemory, int, string[], bool)`；`NationalSpire.CommunityMemorySearch.Search.Search(System.Collections.Generic.List<NationalSpire.CommunityMemorySearch.Document>, System.Collections.Generic.Dictionary<string, int>)`；`System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`

**字段、属性、事件及方法组引用：** `(string Text, System.Collections.Generic.HashSet<string> Terms).Terms`；`(string Text, System.Collections.Generic.HashSet<string> Terms).Text`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityMemorySearch.ConversationNoise`；`NationalSpire.CommunityMemorySearch.Indexes`；`NationalSpire.CommunityMemorySearch.Terms(string)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.Document.Document(NationalSpire.CommunityMemory, int, string[], bool)`；输入表达式：`new(memory, cached.Terms.Count, matches, matches.Count(t => !ConversationNoise.Contains(t)) >= 2)`；返回值紧邻使用处：`ArgumentSyntax: new(memory, cached.Terms.Count, matches, matches.Count(t => !ConversationNoise.Contains(t)) >= 2)`
- `NationalSpire.CommunityMemorySearch.Search.Search(System.Collections.Generic.List<NationalSpire.CommunityMemorySearch.Document>, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`new(documents, frequencies)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(documents, frequencies);`
- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(memory.Text)`；返回值紧邻使用处：`ArgumentSyntax: Terms(memory.Text)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CommunityThreads.NewsPending(data, p)`
- `System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`index.TryGetValue(memory.Id, out var cached)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !index.TryGetValue(memory.Id, out var cached)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ConversationNoise.Contains(t)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ConversationNoise.Contains(t)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`unpublished.Contains(m.PostId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !unpublished.Contains(m.PostId)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`matches.Count(t => !ConversationNoise.Contains(t))`；返回值紧邻使用处：`BinaryExpressionSyntax: matches.Count(t => !ConversationNoise.Contains(t)) >= 2`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select(p => p.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`(queryTerms.Count < cached.Terms.Count ? queryTerms.Where(cached.Terms.Contains) : cached.Terms.Where(queryTerms.Contains)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (queryTerms.Count < cached.Terms.Count ? queryTerms.Where(cached.Terms.Contains) : cached.Terms.Where(queryTerms.Contains)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select(p => p.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select(p => p.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`cached.Terms.Where(queryTerms.Contains)`；返回值紧邻使用处：`ConditionalExpressionSyntax: queryTerms.Count < cached.Terms.Count ? queryTerms.Where(cached.Terms.Contains) : cached.Terms.Where(queryTerms.Contains)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.CommunityMemories.Where(m => m.Day <= day && (m.Kind != "opinion" || !unpublished.Contains(m.PostId)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var memory in data.CommunityMemories.Where(m => m.Day <= day && (m.Kind != "opinion" || !unpublished.Contains(m.PostId))))          {              if (!index.TryGetValue(memory.Id, out var cached) || cached.Text != memory.Text)                  index[memory.Id] = cached = (memory.Text, Terms(memory.Text));              var matches = (queryTerms.Count < cached.Terms.Count ? queryTerms.Where(cached.Terms.Contains) : cached.Terms.Where(queryTerms.Contains)).ToArray();              foreach (string term in matches) frequencies[term] = frequencies.GetValueOrDefault(term) + 1;              documents.Add(new(memory, cached.Terms.Count, matches, matches.Count(t => !ConversationNoise.Contains(t)) >= 2));          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`queryTerms.Where(cached.Terms.Contains)`；返回值紧邻使用处：`ConditionalExpressionSyntax: queryTerms.Count < cached.Terms.Count ? queryTerms.Where(cached.Terms.Contains) : cached.Terms.Where(queryTerms.Contains)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`frequencies.GetValueOrDefault(term)`；返回值紧邻使用处：`BinaryExpressionSyntax: frequencies.GetValueOrDefault(term) + 1`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`documents.Add(new(memory, cached.Terms.Count, matches, matches.Count(t => !ConversationNoise.Contains(t)) >= 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: documents.Add(new(memory, cached.Terms.Count, matches, matches.Count(t => !ConversationNoise.Contains(t)) >= 2));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Document>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Document>()`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Indexes.GetOrCreateValue(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Indexes.GetOrCreateValue(data)`

**赋值（含属性/字段和局部值）：**

- `cached` = `(memory.Text, Terms(memory.Text))`
- `frequencies[term]` = `frequencies.GetValueOrDefault(term) + 1`
- `index[memory.Id]` = `cached = (memory.Text, Terms(memory.Text))`
