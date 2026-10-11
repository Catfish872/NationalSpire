# PublicationBacklog.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`744D5BB4C1A48FBB6983B5323F32ADF433A307055933D1B0FF498F604087772F`。来源：[源码](../../PublicationBacklog.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PublicationBacklog`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-dd2c343a219d"></a>

## `NationalSpire.PublicationBacklog.Latest(NationalSpire.CareerData, NationalSpire.WeeklyEdition) — public static bool Latest(CareerData data, WeeklyEdition issue)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Current()`](AiWeekly.cs.md#symbol-d26127c44e7d)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool)`](PublicationBacklog.cs.md#symbol-37eb1c83d725)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.WeeklyEdition.Week`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.Any(w => w.Week > issue.Week)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.WeeklyEditions.Any(w => w.Week > issue.Week)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-28c8b28b12c8"></a>

## `NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?) — public static List<CommunityPost> Select(IEnumerable<CommunityPost> candidates, int count, CareerData? data = null)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)；[`NationalSpire.AiService.SelectNewsBatch(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`](AiService.cs.md#symbol-58a2eca2fa68)；[`NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool)`](PublicationBacklog.cs.md#symbol-37eb1c83d725)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`Topic(NationalSpire.CommunityPost)`](PublicationBacklog.cs.md#symbol-7df3ed0b103a)；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Clamp(int, int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.MaximumNewsPostCount`；`NationalSpire.AiWorkState.State`；`NationalSpire.CareerData.Day`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.Priority`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`Topic(NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where`
- `string.StartsWith(string)`；输入表达式：`p.EventKey.StartsWith("match")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.EventKey.StartsWith("match")`
- `string.StartsWith(string)`；输入表达式：`p.EventKey.StartsWith("prematch-")`；返回值紧邻使用处：`BinaryExpressionSyntax: p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`ordered.DistinctBy(Topic).Concat(ordered)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ordered.DistinctBy(Topic).Concat(ordered).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`recent.Count(r => Topic(r) == Topic(p))`；返回值紧邻使用处：`BinaryExpressionSyntax: recent.Count(r => Topic(r) == Topic(p)) * 4`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ordered.DistinctBy(Topic).Concat(ordered).DistinctBy(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ordered.DistinctBy(Topic).Concat(ordered).DistinctBy(p => p.Id).Take`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ordered.DistinctBy(Topic)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ordered.DistinctBy(Topic).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))             .ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CommunityThreads.All(data).Where(p => p.NewsGeneration.State == "completed")             .OrderByDescending(p => p.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => p.NewsGeneration.State == "completed")             .OrderByDescending(p => p.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`CommunityThreads.All(data).Where(p => p.NewsGeneration.State == "completed")             .OrderByDescending(p => p.Day).Take(8)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => p.NewsGeneration.State == "completed")             .OrderByDescending(p => p.Day).Take(8).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`ordered.DistinctBy(Topic).Concat(ordered).DistinctBy(p => p.Id).Take(Math.Clamp(count, 1, AiOptions.MaximumNewsPostCount))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ordered.DistinctBy(Topic).Concat(ordered).DistinctBy(p => p.Id).Take(Math.Clamp(count, 1, AiOptions.MaximumNewsPostCount)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))             .ThenByDescending(p => p.EventKey.StartsWith("match"))             .ThenByDescending(p => p.Priority * 10 - Math.Min(15, recent.Count(r => Topic(r) == Topic(p)) * 4))             .ThenByDescending(p => p.Day).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))             .ThenByDescending(p => p.EventKey.StartsWith("match"))             .ThenByDescending(p => p.Priority * 10 - Math.Min(15, recent.Count(r => Topic(r) == Topic(p)) * 4))             .ThenByDescending(p => p.Day).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CommunityThreads.All(data).Where(p => p.NewsGeneration.State == "completed")             .OrderByDescending(p => p.Day).Take(8).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: data == null ? [] : CommunityThreads.All(data).Where(p => p.NewsGeneration.State == "completed")             .OrderByDescending(p => p.Day).Take(8).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`ordered.DistinctBy(Topic).Concat(ordered).DistinctBy(p => p.Id).Take(Math.Clamp(count, 1, AiOptions.MaximumNewsPostCount)).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return ordered.DistinctBy(Topic).Concat(ordered).DistinctBy(p => p.Id).Take(Math.Clamp(count, 1, AiOptions.MaximumNewsPostCount)).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Where(p => p.NewsGeneration.State == "completed")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => p.NewsGeneration.State == "completed")             .OrderByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))             .ThenByDescending(p => p.EventKey.StartsWith("match"))             .ThenByDescending(p => p.Priority * 10 - Math.Min(15, recent.Count(r => Topic(r) == Topic(p)) * 4))             .ThenByDescending(p => p.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))             .ThenByDescending(p => p.EventKey.StartsWith("match"))             .ThenByDescending(p => p.Priority * 10 - Math.Min(15, recent.Count(r => Topic(r) == Topic(p)) * 4))             .ThenByDescending(p => p.Day).ToList`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))             .ThenByDescending(p => p.EventKey.StartsWith("match"))             .ThenByDescending(p => p.Priority * 10 - Math.Min(15, recent.Count(r => Topic(r) == Topic(p)) * 4))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))             .ThenByDescending(p => p.EventKey.StartsWith("match"))             .ThenByDescending(p => p.Priority * 10 - Math.Min(15, recent.Count(r => Topic(r) == Topic(p)) * 4))             .ThenByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))             .ThenByDescending(p => p.EventKey.StartsWith("match"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))             .ThenByDescending(p => p.EventKey.StartsWith("match"))             .ThenByDescending`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(count, 1, AiOptions.MaximumNewsPostCount)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(count, 1, AiOptions.MaximumNewsPostCount)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(15, recent.Count(r => Topic(r) == Topic(p)) * 4)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Priority * 10 - Math.Min(15, recent.Count(r => Topic(r) == Topic(p)) * 4)`
- `Topic(NationalSpire.CommunityPost)`；输入表达式：`Topic(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: Topic(r) == Topic(p)`
- `Topic(NationalSpire.CommunityPost)`；输入表达式：`Topic(r)`；返回值紧邻使用处：`BinaryExpressionSyntax: Topic(r) == Topic(p)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7df3ed0b103a"></a>

## `Topic(NationalSpire.CommunityPost) — string Topic(CommunityPost p)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`](PublicationBacklog.cs.md#symbol-28c8b28b12c8)

**调用：** `string.StartsWith(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.NewsTopic`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string)`；输入表达式：`p.EventKey.StartsWith("champion-")`；返回值紧邻使用处：`BinaryExpressionSyntax: p.EventKey.StartsWith("roundup-") || p.EventKey.StartsWith("knockout-") || p.EventKey.StartsWith("champion-")`
- `string.StartsWith(string)`；输入表达式：`p.EventKey.StartsWith("knockout-")`；返回值紧邻使用处：`BinaryExpressionSyntax: p.EventKey.StartsWith("roundup-") || p.EventKey.StartsWith("knockout-")`
- `string.StartsWith(string)`；输入表达式：`p.EventKey.StartsWith("life-update-")`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.EventKey.StartsWith("life-update-") ? "player-life" : p.NewsTopic.Length > 0 ? p.NewsTopic : p.Category`
- `string.StartsWith(string)`；输入表达式：`p.EventKey.StartsWith("match")`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.EventKey.StartsWith("match") ? "player-match"             : p.EventKey.StartsWith("roundup-") || p.EventKey.StartsWith("knockout-") || p.EventKey.StartsWith("champion-") ? "world-match"             : p.EventKey.StartsWith("life-update-") ? "player-life" : p.NewsTopic.Length > 0 ? p.NewsTopic : p.Category`
- `string.StartsWith(string)`；输入表达式：`p.EventKey.StartsWith("roundup-")`；返回值紧邻使用处：`BinaryExpressionSyntax: p.EventKey.StartsWith("roundup-") || p.EventKey.StartsWith("knockout-")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-37eb1c83d725"></a>

## `NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool) — public static void Compact(CareerData data, bool selectNews = true)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)；[`NationalSpire.AiService.ProcessWeeklyAsync(NationalSpire.CareerData?)`](AiWeekly.cs.md#symbol-bb0ee823dfc4)；[`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int)`](CareerEngine.cs.md#symbol-e733e6d47318)；[`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** [`NationalSpire.CareerEngine.ExcludedAutomaticPreview(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CareerEngine.cs.md#symbol-ff6b96537297)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`](CommunityThreads.cs.md#symbol-981631ecddfc)；[`NationalSpire.PublicationBacklog.Latest(NationalSpire.CareerData, NationalSpire.WeeklyEdition)`](PublicationBacklog.cs.md#symbol-dd2c343a219d)；[`NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`](PublicationBacklog.cs.md#symbol-28c8b28b12c8)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.MaxNewsPosts`；`NationalSpire.AiWorkState.State`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerEngine.ExcludedAutomaticPreview(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；`NationalSpire.PublicationBacklog.Latest(NationalSpire.CareerData, NationalSpire.WeeklyEdition)`；`NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`；`NationalSpire.WeeklyEdition.NewsWork`；`NationalSpire.WeeklyEdition.ProfilesWork`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.ExcludedAutomaticPreview(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CareerEngine.ExcludedAutomaticPreview(data, p)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.ExcludedAutomaticPreview(data, p)             && p.NewsGeneration.State != "completed"`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(post.NewsGeneration, "superseded")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(post.NewsGeneration, "superseded");`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(work, "superseded")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(work, "superseded");`
- `NationalSpire.PublicationBacklog.Latest(NationalSpire.CareerData, NationalSpire.WeeklyEdition)`；输入表达式：`Latest(data, w)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Latest(data, w)`
- `NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`；输入表达式：`Select(recent, data.Ai.MaxNewsPosts, data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Select(recent, data.Ai.MaxNewsPosts, data).Select`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`selected.Contains(post.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !selected.Contains(post.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Replies.Any(r => r.AuthorId == "player")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !p.Replies.Any(r => r.AuthorId == "player")`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`recent.Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.Select(p => p.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Select(recent, data.Ai.MaxNewsPosts, data).Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Select(recent, data.Ai.MaxNewsPosts, data).Select(p => p.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`recent.Select(p => p.Id).ToHashSet()`；返回值紧邻使用处：`ConditionalExpressionSyntax: selectNews ? Select(recent, data.Ai.MaxNewsPosts, data).Select(p => p.Id).ToHashSet() : recent.Select(p => p.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`Select(recent, data.Ai.MaxNewsPosts, data).Select(p => p.Id).ToHashSet()`；返回值紧邻使用处：`ConditionalExpressionSyntax: selectNews ? Select(recent, data.Ai.MaxNewsPosts, data).Select(p => p.Id).ToHashSet() : recent.Select(p => p.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`automatic.Where(p => p.Day >= data.Day - 6 && p.AiPending && p.NewsGeneration.State is "idle" or "queued" or "sending").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = automatic.Where(p => p.Day >= data.Day - 6 && p.AiPending && p.NewsGeneration.State is "idle" or "queued" or "sending").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CommunityThreads.All(data).Where(p => p.AuthorId != "player" && !p.Replies.Any(r => r.AuthorId == "player")             && p.NewsGeneration.State != "completed").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).Where(p => p.AuthorId != "player" && !p.Replies.Any(r => r.AuthorId == "player")             && p.NewsGeneration.State != "completed").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`automatic.Where(p => p.Day >= data.Day - 6 && p.AiPending && p.NewsGeneration.State is "idle" or "queued" or "sending")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: automatic.Where(p => p.Day >= data.Day - 6 && p.AiPending && p.NewsGeneration.State is "idle" or "queued" or "sending").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Where(p => CareerEngine.ExcludedAutomaticPreview(data, p)             && p.NewsGeneration.State != "completed")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in CommunityThreads.All(data).Where(p => CareerEngine.ExcludedAutomaticPreview(data, p)             && p.NewsGeneration.State != "completed"))         {             post.AiPending = false;             CommunityThreads.SetWork(post.NewsGeneration, "superseded");         }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Where(p => p.AuthorId != "player" && !p.Replies.Any(r => r.AuthorId == "player")             && p.NewsGeneration.State != "completed")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => p.AuthorId != "player" && !p.Replies.Any(r => r.AuthorId == "player")             && p.NewsGeneration.State != "completed").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.Where(w => !Latest(data, w))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var issue in data.WeeklyEditions.Where(w => !Latest(data, w)))             foreach (var work in new[] { issue.ProfilesWork, issue.NewsWork })                 if (work.State is "idle" or "queued" or "sending" or "failed") CommunityThreads.SetWork(work, "superseded");`

**赋值（含属性/字段和局部值）：**

- `post.AiPending` = `false`
