# CareerMigration.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`15CF79E9C5E718C7F55E9E5EAFEE1A1C8B20CA0E8B06871749FE1FEAF0BCBE46`。来源：[源码](../../CareerMigration.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerMigration`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-94c0855d9c16"></a>

## `NationalSpire.CareerMigration.UpgradeRules(NationalSpire.CareerData) — public static void UpgradeRules(CareerData data)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerNarrative.Reply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`](CareerNarrative.cs.md#symbol-6be1cdf0085f)；[`NationalSpire.MatchRules.Report(NationalSpire.CareerMatch, NationalSpire.CareerResult, bool)`](MatchRules.cs.md#symbol-ca4b0ef64a9d)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerResult)`](PrivateAppointments.cs.md#symbol-31b52db37f88)；`NationalSpire.CareerHonor.CareerHonor()`；`string.Replace(string, string?)`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CareerData.Version`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerHonor.Day`；`NationalSpire.CareerHonor.Detail`；`NationalSpire.CareerHonor.Id`；`NationalSpire.CareerHonor.Season`；`NationalSpire.CareerHonor.Title`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.PlayedAscension`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerNarrative.Reply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.Day`；`NationalSpire.CareerResult.Kind`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.OfficialAscensionVerified`；`NationalSpire.CareerResult.PlayedAscension`；`NationalSpire.CareerResult.Win`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityPost.Analysis`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.RelatedFacts`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.EsportsCareer.BestClear`；`NationalSpire.EsportsCareer.Honors`；`NationalSpire.EsportsCareer.Initialized`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsCareer.Milestones`；`NationalSpire.MatchRules.Report(NationalSpire.CareerMatch, NationalSpire.CareerResult, bool)`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerResult)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, reply.AuthorId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, reply.AuthorId) is { } person`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(post.Id + person.Id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(post.Id + person.Id)`
- `NationalSpire.CareerHonor.CareerHonor()`；输入表达式：`new CareerHonor { Id = id, Title = $"进阶 {result.Ascension} 通关认证", Day = result.Day,                  Season = Math.Max(1, (result.Day - 1) / 28 + 1), Detail = "根据赛事规定进阶核实的通关履历。" }`；返回值紧邻使用处：`ArgumentSyntax: new CareerHonor { Id = id, Title = $"进阶 {result.Ascension} 通关认证", Day = result.Day,                  Season = Math.Max(1, (result.Day - 1) / 28 + 1), Detail = "根据赛事规定进阶核实的通关履历。" }`
- `NationalSpire.CareerNarrative.Reply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`；输入表达式：`CareerNarrative.Reply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: reply.Body = CareerNarrative.Reply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id))`
- `NationalSpire.MatchRules.Report(NationalSpire.CareerMatch, NationalSpire.CareerResult, bool)`；输入表达式：`MatchRules.Report(match, result)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.Body = MatchRules.Report(match, result)`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerResult)`；输入表达式：`PrivateAppointments.IsPrivate(r)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateAppointments.IsPrivate(r)`
- `string.Replace(string, string?)`；输入表达式：`memory.Text.Replace("胜负属于整队，不能写成几场个人单挑。", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: memory.Text = memory.Text.Replace("胜负属于整队，不能写成几场个人单挑。", "")`
- `string.Replace(string, string?)`；输入表达式：`post.RelatedFacts.Replace("胜负属于整队，不能写成几场个人单挑。", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.RelatedFacts = post.RelatedFacts.Replace("胜负属于整队，不能写成几场个人单挑。", "")`
- `string.Replace(string, string?)`；输入表达式：`post.SourceBody.Replace("胜负属于整队，不能写成几场个人单挑。", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.SourceBody = post.SourceBody.Replace("胜负属于整队，不能写成几场个人单挑。", "")`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("clear-")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: h => h.Id.StartsWith("clear-")`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("clear-")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => id.StartsWith("clear-")`
- `string.StartsWith(string)`；输入表达式：`p.EventKey.StartsWith("honor-clear-")`；返回值紧邻使用处：`BinaryExpressionSyntax: p.EventKey.StartsWith("honor-clear-") || p.EventKey.StartsWith("match")              && !data.Results.Any(r => r.OfficialAscensionVerified && p.EventKey == "match" + r.MatchId)`
- `string.StartsWith(string)`；输入表达式：`p.EventKey.StartsWith("match")`；返回值紧邻使用处：`BinaryExpressionSyntax: p.EventKey.StartsWith("match")              && !data.Results.Any(r => r.OfficialAscensionVerified && p.EventKey == "match" + r.MatchId)`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max()`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Esports.BestClear = data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Results.Any(r => r.OfficialAscensionVerified && p.EventKey == "match" + r.MatchId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.Results.Any(r => r.OfficialAscensionVerified && p.EventKey == "match" + r.MatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Results.Any(r => r.Win && r.Ascension >= 8)`；返回值紧邻使用处：`BinaryExpressionSyntax: !data.Esports.Initialized && data.Results.Any(r => r.Win && r.Ascension >= 8)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`data.Posts.Concat(data.SavedThreads)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in data.Posts.Concat(data.SavedThreads))          {              post.SourceBody = post.SourceBody.Replace("胜负属于整队，不能写成几场个人单挑。", "");              post.RelatedFacts = post.RelatedFacts.Replace("胜负属于整队，不能写成几场个人单挑。", "");          }`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Results.Where(r => r.Win && r.OfficialAscensionVerified && r.Ascension >= 8).DistinctBy(r => r.Ascension)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var result in data.Results.Where(r => r.Win && r.OfficialAscensionVerified && r.Ascension >= 8).DistinctBy(r => r.Ascension))          {              string id = "clear-" + result.Ascension;              data.Esports.Milestones.Add(id);              data.Esports.Honors.Add(new CareerHonor { Id = id, Title = $"进阶 {result.Ascension} 通关认证", Day = result.Day,                  Season = Math.Max(1, (result.Day - 1) / 28 + 1), Detail = "根据赛事规定进阶核实的通关履历。" });          }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => m.Id == result.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.FirstOrDefault(m => m.Id == result.MatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Posts.FirstOrDefault(p => p.EventKey == "match" + result.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Posts.FirstOrDefault(p => p.EventKey == "match" + result.MatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Results.Where(r => r.Win && r.OfficialAscensionVerified && r.Ascension >= 8)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.Where(r => r.Win && r.OfficialAscensionVerified && r.Ascension >= 8).DistinctBy`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`data.Esports.Honors.Add(new CareerHonor { Id = id, Title = $"进阶 {result.Ascension} 通关认证", Day = result.Day,                  Season = Math.Max(1, (result.Day - 1) / 28 + 1), Detail = "根据赛事规定进阶核实的通关履历。" })`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Esports.Honors.Add(new CareerHonor { Id = id, Title = $"进阶 {result.Ascension} 通关认证", Day = result.Day,                  Season = Math.Max(1, (result.Day - 1) / 28 + 1), Detail = "根据赛事规定进阶核实的通关履历。" });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`data.Esports.Milestones.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Esports.Milestones.Add(id);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`data.Esports.Honors.RemoveAll(h => h.Id.StartsWith("clear-"))`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Esports.Honors.RemoveAll(h => h.Id.StartsWith("clear-"));`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`data.Esports.Milestones.RemoveAll(id => id.StartsWith("clear-"))`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Esports.Milestones.RemoveAll(id => id.StartsWith("clear-"));`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`data.Posts.RemoveAll(p => p.EventKey.StartsWith("honor-clear-") || p.EventKey.StartsWith("match")              && !data.Results.Any(r => r.OfficialAscensionVerified && p.EventKey == "match" + r.MatchId))`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Posts.RemoveAll(p => p.EventKey.StartsWith("honor-clear-") || p.EventKey.StartsWith("match")              && !data.Results.Any(r => r.OfficialAscensionVerified && p.EventKey == "match" + r.MatchId));`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, (result.Day - 1) / 28 + 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Season = Math.Max(1, (result.Day - 1) / 28 + 1)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(data.Esports.License, 3)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Esports.License = Math.Max(data.Esports.License, 3)`

**赋值（含属性/字段和局部值）：**

- `data.Esports.BestClear` = `data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max()`
- `data.Esports.License` = `Math.Max(data.Esports.License, 3)`
- `data.Version` = `4`
- `Day` = `result.Day`
- `Detail` = `"根据赛事规定进阶核实的通关履历。"`
- `Id` = `id`
- `memory.Text` = `memory.Text.Replace("胜负属于整队，不能写成几场个人单挑。", "")`
- `post.Analysis` = `""`
- `post.Body` = `MatchRules.Report(match, result)`
- `post.RelatedFacts` = `post.RelatedFacts.Replace("胜负属于整队，不能写成几场个人单挑。", "")`
- `post.SourceBody` = `post.SourceBody.Replace("胜负属于整队，不能写成几场个人单挑。", "")`
- `reply.Body` = `CareerNarrative.Reply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id))`
- `result.Ascension` = `official.Value`
- `result.OfficialAscensionVerified` = `official.HasValue`
- `result.PlayedAscension` ??= `match?.PlayedAscension ?? result.Ascension`
- `Season` = `Math.Max(1, (result.Day - 1) / 28 + 1)`
- `Title` = `$"进阶 {result.Ascension} 通关认证"`
