# PromptTesting.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`55A5DAE57B748909EBD705481D713EA010CCCE483DFA2E7712EBBB0CBE49A4B9`。来源：[源码](../../PromptTesting.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiService`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-bac6770dfaa1"></a>

## `NationalSpire.AiService.TestSources(NationalSpire.CareerData, string) — public static List<PromptTestSource> TestSources(CareerData data, string scene)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ChooseSources()`](PromptTestScreen.cs.md#symbol-b495d2c3d047)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`NationalSpire.PromptTestSource.PromptTestSource(string, string, string, int)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.WeeklyEdition.Profiles`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklyEdition.Week`；`NationalSpire.WeeklyProfile.Id`；`NationalSpire.WeeklyProfile.Name`；`NationalSpire.WeeklySlide.Id`；`NationalSpire.WeeklySlide.Title`；`NationalSpire.WeeklySlide.Topic`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).OrderByDescending`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where`
- `NationalSpire.PromptTestSource.PromptTestSource(string, string, string, int)`；输入表达式：`new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}")`
- `NationalSpire.PromptTestSource.PromptTestSource(string, string, string, int)`；输入表达式：`new PromptTestSource(scene, p.Id, $"第 {w.Week} 周 · {p.Name}", w.Week)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new PromptTestSource(scene, p.Id, $"第 {w.Week} 周 · {p.Name}", w.Week)`
- `NationalSpire.PromptTestSource.PromptTestSource(string, string, string, int)`；输入表达式：`new PromptTestSource(scene, s.Id, $"第 {w.Week} 周 · {(s.Title.Length > 0 ? s.Title : s.Topic)}", w.Week)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => new PromptTestSource(scene, s.Id, $"第 {w.Week} 周 · {(s.Title.Length > 0 ? s.Title : s.Topic)}", w.Week)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Any(who => who.Id == p.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.AuthorId != "player" && data.People.Any(who => who.Id == p.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CommunityThreads.All(data).OrderByDescending(p => p.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).OrderByDescending(p => p.Day)              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CommunityThreads.All(data).Where(p => p.AuthorId != "player" && data.People.Any(who => who.Id == p.AuthorId))              .OrderByDescending(p => p.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => p.AuthorId != "player" && data.People.Any(who => who.Id == p.AuthorId))              .OrderByDescending(p => p.Day).Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.WeeklyEditions.OrderByDescending(w => w.Week)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CommunityThreads.All(data).OrderByDescending(p => p.Day)              .Select(p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).OrderByDescending(p => p.Day)              .Select(p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}")).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CommunityThreads.All(data).Where(p => p.AuthorId != "player" && data.People.Any(who => who.Id == p.AuthorId))              .OrderByDescending(p => p.Day).Select(p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => p.AuthorId != "player" && data.People.Any(who => who.Id == p.AuthorId))              .OrderByDescending(p => p.Day).Select(p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}")).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`w.Profiles              .Select(p => new PromptTestSource(scene, p.Id, $"第 {w.Week} 周 · {p.Name}", w.Week))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: w => w.Profiles              .Select(p => new PromptTestSource(scene, p.Id, $"第 {w.Week} 周 · {p.Name}", w.Week))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`w.Slides              .Select(s => new PromptTestSource(scene, s.Id, $"第 {w.Week} 周 · {(s.Title.Length > 0 ? s.Title : s.Topic)}", w.Week))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: w => w.Slides              .Select(s => new PromptTestSource(scene, s.Id, $"第 {w.Week} 周 · {(s.Title.Length > 0 ? s.Title : s.Topic)}", w.Week))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany(w => w.Profiles              .Select(p => new PromptTestSource(scene, p.Id, $"第 {w.Week} 周 · {p.Name}", w.Week)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany(w => w.Profiles              .Select(p => new PromptTestSource(scene, p.Id, $"第 {w.Week} 周 · {p.Name}", w.Week))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany(w => w.Slides              .Select(s => new PromptTestSource(scene, s.Id, $"第 {w.Week} 周 · {(s.Title.Length > 0 ? s.Title : s.Topic)}", w.Week)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany(w => w.Slides              .Select(s => new PromptTestSource(scene, s.Id, $"第 {w.Week} 周 · {(s.Title.Length > 0 ? s.Title : s.Topic)}", w.Week))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CommunityThreads.All(data).OrderByDescending(p => p.Day)              .Select(p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}")).ToList()`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "discussion" => CommunityThreads.All(data).OrderByDescending(p => p.Day)              .Select(p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}")).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CommunityThreads.All(data).Where(p => p.AuthorId != "player" && data.People.Any(who => who.Id == p.AuthorId))              .OrderByDescending(p => p.Day).Select(p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}")).ToList()`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "news" => CommunityThreads.All(data).Where(p => p.AuthorId != "player" && data.People.Any(who => who.Id == p.AuthorId))              .OrderByDescending(p => p.Day).Select(p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}")).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany(w => w.Profiles              .Select(p => new PromptTestSource(scene, p.Id, $"第 {w.Week} 周 · {p.Name}", w.Week))).ToList()`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "profiles" => data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany(w => w.Profiles              .Select(p => new PromptTestSource(scene, p.Id, $"第 {w.Week} 周 · {p.Name}", w.Week))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany(w => w.Slides              .Select(s => new PromptTestSource(scene, s.Id, $"第 {w.Week} 周 · {(s.Title.Length > 0 ? s.Title : s.Topic)}", w.Week))).ToList()`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "weekly" => data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany(w => w.Slides              .Select(s => new PromptTestSource(scene, s.Id, $"第 {w.Week} 周 · {(s.Title.Length > 0 ? s.Title : s.Topic)}", w.Week))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Where(p => p.AuthorId != "player" && data.People.Any(who => who.Id == p.AuthorId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => p.AuthorId != "player" && data.People.Any(who => who.Id == p.AuthorId))              .OrderByDescending`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c5a391862684"></a>

## `NationalSpire.AiService.TestCopy<T>(T) — private static T TestCopy<T>(T source)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string)`](PromptTesting.cs.md#symbol-c81f52ee7090)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.Json`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(source, Json))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(source, Json))!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(source, Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(source, Json)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c81f52ee7090"></a>

## `NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string) — public static PromptTestSession CreateTestSession(CareerData data, PromptTestSource source, string message = "")`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Prepare()`](PromptTestScreen.cs.md#symbol-bb12916e300a)

**调用：** [`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiContext.cs.md#symbol-7b21630a9e2c)；[`NationalSpire.AiService.BuildWeeklyContext(NationalSpire.WeeklyEdition, bool)`](AiWeekly.cs.md#symbol-68c73eee1d19)；[`NationalSpire.AiService.TestCopy<T>(T)`](PromptTesting.cs.md#symbol-c5a391862684)；[`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`NationalSpire.CommunityReply.CommunityReply()`；`NationalSpire.PromptTestSession.PromptTestSession()`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`；`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`；`NationalSpire.AiService.BuildWeeklyContext(NationalSpire.WeeklyEdition, bool)`；`NationalSpire.AiService.TestCopy<T>(T)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`；`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.NeedsReaction`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.PromptTestSession.Context`；`NationalSpire.PromptTestSession.Message`；`NationalSpire.PromptTestSession.Owner`；`NationalSpire.PromptTestSession.Snapshot`；`NationalSpire.PromptTestSession.Source`；`NationalSpire.PromptTestSession.TargetId`；`NationalSpire.PromptTestSource.Id`；`NationalSpire.PromptTestSource.Scene`；`NationalSpire.PromptTestSource.Week`；`NationalSpire.WeeklyEdition.EndDay`；`NationalSpire.WeeklyEdition.Memory`；`NationalSpire.WeeklyEdition.Profiles`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklyEdition.StartDay`；`NationalSpire.WeeklyEdition.Week`；`NationalSpire.WeeklyProfile.Id`；`NationalSpire.WeeklyProfile.Previous`；`NationalSpire.WeeklyProfile.Updated`；`NationalSpire.WeeklySlide.Id`；`NationalSpire.WeeklySlide.People`；`NationalSpire.WeeklySlide.Topic`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`；输入表达式：`BuildDiscussionPrompt(snapshot, new HashSet<string> { target }, [post])`；返回值紧邻使用处：`AssignmentExpressionSyntax: context = BuildDiscussionPrompt(snapshot, new HashSet<string> { target }, [post])`
- `NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`；输入表达式：`BuildNewsContext(snapshot, [post])`；返回值紧邻使用处：`AssignmentExpressionSyntax: context = BuildNewsContext(snapshot, [post])`
- `NationalSpire.AiService.BuildWeeklyContext(NationalSpire.WeeklyEdition, bool)`；输入表达式：`BuildWeeklyContext(issue, source.Scene == "profiles")`；返回值紧邻使用处：`AssignmentExpressionSyntax: context = BuildWeeklyContext(issue, source.Scene == "profiles")`
- `NationalSpire.AiService.TestCopy<T>(T)`；输入表达式：`TestCopy(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TestCopy(data)`
- `NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`；输入表达式：`CareerLife.Ensure(snapshot)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.Ensure(snapshot);`
- `NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`；输入表达式：`CommunityMemorySearch.Retrieve(snapshot, issue.Slides[0].Topic, issue.Slides[0].People,                      issue.StartDay - 1, new HashSet<string>(), 5)`；返回值紧邻使用处：`AssignmentExpressionSyntax: issue.Memory = CommunityMemorySearch.Retrieve(snapshot, issue.Slides[0].Topic, issue.Slides[0].People,                      issue.StartDay - 1, new HashSet<string>(), 5)`
- `NationalSpire.CommunityReply.CommunityReply()`；输入表达式：`new CommunityReply { AuthorId = "player", Day = snapshot.Day, Body = message.Trim(), NeedsReaction = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CommunityReply { AuthorId = "player", Day = snapshot.Day, Body = message.Trim(), NeedsReaction = true }`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(snapshot)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(snapshot).Single`
- `NationalSpire.PromptTestSession.PromptTestSession()`；输入表达式：`new() { Source = source, Message = message, Snapshot = snapshot, Owner = data, Context = context, TargetId = target }`；返回值紧邻使用处：`ReturnStatementSyntax: return new() { Source = source, Message = message, Snapshot = snapshot, Owner = data, Context = context, TargetId = target };`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(message)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(message)) throw new ArgumentException("请填写用来测试的留言。");`
- `string.Trim()`；输入表达式：`message.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Body = message.Trim()`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请填写用来测试的留言。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请填写用来测试的留言。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("未知测试场景。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("未知测试场景。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("选手介绍材料已失效，请重新选择。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("选手介绍材料已失效，请重新选择。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("周刊材料已失效，请重新选择。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("周刊材料已失效，请重新选择。");`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string> { target }`；返回值紧邻使用处：`ArgumentSyntax: new HashSet<string> { target }`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`ArgumentSyntax: new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`snapshot.WeeklyEditions.Where(w => w.EndDay < issue.EndDay).OrderByDescending(w => w.EndDay)                      .SelectMany(w => w.Profiles).FirstOrDefault(p => p.Id == profile.Id && p.Updated.Length > 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = snapshot.WeeklyEditions.Where(w => w.EndDay < issue.EndDay).OrderByDescending(w => w.EndDay)                      .SelectMany(w => w.Profiles).FirstOrDefault(p => p.Id == profile.Id && p.Updated.Length > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`snapshot.WeeklyEditions.Where(w => w.EndDay < issue.EndDay).OrderByDescending(w => w.EndDay)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: snapshot.WeeklyEditions.Where(w => w.EndDay < issue.EndDay).OrderByDescending(w => w.EndDay)                      .SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`snapshot.WeeklyEditions.Where(w => w.EndDay < issue.EndDay).OrderByDescending(w => w.EndDay)                      .SelectMany(w => w.Profiles)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: snapshot.WeeklyEditions.Where(w => w.EndDay < issue.EndDay).OrderByDescending(w => w.EndDay)                      .SelectMany(w => w.Profiles).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(snapshot).Single(p => p.Id == source.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(snapshot).Single(p => p.Id == source.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`snapshot.WeeklyEditions.Single(w => w.Week == source.Week)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = snapshot.WeeklyEditions.Single(w => w.Week == source.Week)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`issue.Profiles.Where(p => p.Id == source.Id).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: issue.Profiles = issue.Profiles.Where(p => p.Id == source.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`issue.Slides.Where(s => s.Id == source.Id).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: issue.Slides = issue.Slides.Where(s => s.Id == source.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`issue.Profiles.Where(p => p.Id == source.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: issue.Profiles.Where(p => p.Id == source.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`issue.Slides.Where(s => s.Id == source.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: issue.Slides.Where(s => s.Id == source.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`snapshot.WeeklyEditions.Where(w => w.EndDay < issue.EndDay)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: snapshot.WeeklyEditions.Where(w => w.EndDay < issue.EndDay).OrderByDescending`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`post.Replies.Add(reply)`；返回值紧邻使用处：`ExpressionStatementSyntax: post.Replies.Add(reply);`

**赋值（含属性/字段和局部值）：**

- `AuthorId` = `"player"`
- `Body` = `message.Trim()`
- `context` = `BuildDiscussionPrompt(snapshot, new HashSet<string> { target }, [post])`
- `context` = `BuildNewsContext(snapshot, [post])`
- `context` = `BuildWeeklyContext(issue, source.Scene == "profiles")`
- `Context` = `context`
- `Day` = `snapshot.Day`
- `issue.Memory` = `CommunityMemorySearch.Retrieve(snapshot, issue.Slides[0].Topic, issue.Slides[0].People,                      issue.StartDay - 1, new HashSet<string>(), 5)`
- `issue.Profiles` = `issue.Profiles.Where(p => p.Id == source.Id).ToList()`
- `issue.Slides` = `issue.Slides.Where(s => s.Id == source.Id).ToList()`
- `Message` = `message`
- `NeedsReaction` = `true`
- `Owner` = `data`
- `profile.Previous` = `prior.Updated`
- `Snapshot` = `snapshot`
- `Source` = `source`
- `target` = `reply.Id`
- `TargetId` = `target`

<a id="symbol-48585ad62c60"></a>

## `NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool) — public static async Task TestPromptAsync(CareerData owner, PromptTestSession test, IReadOnlyDictionary<string, string> drafts, bool confirmedExternalSend = false)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)

**调用：** [`Current()`](PromptTesting.cs.md#symbol-6f98b36ada7b)；[`NationalSpire.AiService.ApplyTestResponse(NationalSpire.CareerData, NationalSpire.PromptTestSession, string)`](PromptTesting.cs.md#symbol-7208c4c08018)；[`NationalSpire.AiService.ComposeSystem(NationalSpire.AiOptions, string)`](AiPrompts.cs.md#symbol-7a07a16bbdcd)；[`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`](AiService.cs.md#symbol-8c02bb75b41a)；[`NationalSpire.AiService.EnterQueueAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`](AiService.cs.md#symbol-364b38bdda09)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`](AiService.cs.md#symbol-80abc5b58bda)；[`NationalSpire.AiService.ReadResponseCompletion(System.Net.Http.HttpResponseMessage)`](AiService.cs.md#symbol-4f223cb1164e)；[`NationalSpire.AiService.SendAsync(System.Net.Http.HttpRequestMessage, NationalSpire.CareerData, string, string, System.Collections.Generic.IEnumerable<string>)`](AiService.cs.md#symbol-aad664840095)；[`NationalSpire.AiService.TestCopy<T>(T)`](PromptTesting.cs.md#symbol-c5a391862684)；[`NationalSpire.AiService.TryGetEndpoint(string?, out System.Uri)`](AiService.cs.md#symbol-e8b1c4ed9086)；[`NationalSpire.AiService.WaitForRequestStartAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`](AiService.cs.md#symbol-5ba7da409ec8)；[`NationalSpire.AiWireProtocol.AiWireProtocol(NationalSpire.CareerData)`](AiWireProtocol.cs.md#symbol-ebb8d59c054e)；[`NationalSpire.AiWireProtocol.Decode(string, bool, string?)`](AiWireProtocol.cs.md#symbol-1b2e04d42691)；[`NationalSpire.AiWireProtocol.Encode(string)`](AiWireProtocol.cs.md#symbol-bcdcbacd353a)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`](CommunityThreads.cs.md#symbol-981631ecddfc)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.PromptLibrary.Save(NationalSpire.AiOptions, string, string)`](PromptLibrary.cs.md#symbol-101a181e9f40)；`int.Parse(string)`；`object.ReferenceEquals(object?, object?)`；`string.IsNullOrWhiteSpace(string?)`；`System.ArgumentException.ArgumentException(string?)`；`System.DateTime.ToString(string?)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.Net.Http.Headers.AuthenticationHeaderValue.AuthenticationHeaderValue(string, string?)`；`System.Net.Http.HttpRequestMessage.HttpRequestMessage(System.Net.Http.HttpMethod, System.Uri?)`；`System.Net.Http.StringContent.StringContent(string, System.Text.Encoding?, string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string model, bool stream, <anonymous type: string role, string content>[] messages>.messages`；`<anonymous type: string model, bool stream, <anonymous type: string role, string content>[] messages>.model`；`<anonymous type: string model, bool stream, <anonymous type: string role, string content>[] messages>.stream`；`<anonymous type: string role, string content>.content`；`<anonymous type: string role, string content>.role`；`Current()`；`NationalSpire.AiConnection.Endpoint`；`NationalSpire.AiConnection.Key`；`NationalSpire.AiConnection.Model`；`NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.RequestDay`；`NationalSpire.AiOptions.RequestsToday`；`NationalSpire.AiService.ApplyTestResponse(NationalSpire.CareerData, NationalSpire.PromptTestSession, string)`；`NationalSpire.AiService.ComposeSystem(NationalSpire.AiOptions, string)`；`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；`NationalSpire.AiService.EnterQueueAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`；`NationalSpire.AiService.Json`；`NationalSpire.AiService.ReadResponseCompletion(System.Net.Http.HttpResponseMessage)`；`NationalSpire.AiService.SendAsync(System.Net.Http.HttpRequestMessage, NationalSpire.CareerData, string, string, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.AiService.TestCopy<T>(T)`；`NationalSpire.AiService.TryGetEndpoint(string?, out System.Uri)`；`NationalSpire.AiService.WaitForRequestStartAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`；`NationalSpire.AiWireProtocol.Decode(string, bool, string?)`；`NationalSpire.AiWireProtocol.Encode(string)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.PromptLibrary.Save(NationalSpire.AiOptions, string, string)`；`NationalSpire.PromptTestSession.Context`；`NationalSpire.PromptTestSession.Owner`；`NationalSpire.PromptTestSession.Previous`；`NationalSpire.PromptTestSession.Result`；`NationalSpire.PromptTestSession.Running`；`NationalSpire.PromptTestSession.Snapshot`；`NationalSpire.PromptTestSession.Source`；`NationalSpire.PromptTestSession.Work`；`NationalSpire.PromptTestSource.Id`；`NationalSpire.PromptTestSource.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Current()`；输入表达式：`Current()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Current()`
- `int.Parse(string)`；输入表达式：`int.Parse(DateTime.UtcNow.ToString("yyyyMMdd"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = int.Parse(DateTime.UtcNow.ToString("yyyyMMdd"))`
- `NationalSpire.AiService.ApplyTestResponse(NationalSpire.CareerData, NationalSpire.PromptTestSession, string)`；输入表达式：`ApplyTestResponse(data, test, content)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ApplyTestResponse(data, test, content)`
- `NationalSpire.AiService.ComposeSystem(NationalSpire.AiOptions, string)`；输入表达式：`ComposeSystem(options, test.Source.Scene)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: content = ComposeSystem(options, test.Source.Scene)`
- `NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；输入表达式：`Connection(owner.Ai, test.Source.Scene)`；返回值紧邻使用处：`BinaryExpressionSyntax: Connection(owner.Ai, test.Source.Scene) != connection`
- `NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；输入表达式：`Connection(owner.Ai, test.Source.Scene)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Connection(owner.Ai, test.Source.Scene)`
- `NationalSpire.AiService.EnterQueueAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`；输入表达式：`EnterQueueAsync(owner, ["prompt-preview"], [test.Work])`；返回值紧邻使用处：`AwaitExpressionSyntax: await EnterQueueAsync(owner, ["prompt-preview"], [test.Work])`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`ConditionalExpressionSyntax: e is ArgumentException ? e.Message : FailureReason(e)`
- `NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`；输入表达式：`HttpFailure(response)`；返回值紧邻使用处：`AwaitExpressionSyntax: await HttpFailure(response)`
- `NationalSpire.AiService.ReadResponseCompletion(System.Net.Http.HttpResponseMessage)`；输入表达式：`ReadResponseCompletion(response)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ReadResponseCompletion(response)`
- `NationalSpire.AiService.SendAsync(System.Net.Http.HttpRequestMessage, NationalSpire.CareerData, string, string, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`SendAsync(request, owner, trace, "prompt-test-" + test.Source.Scene, [test.Source.Id])`；返回值紧邻使用处：`AwaitExpressionSyntax: await SendAsync(request, owner, trace, "prompt-test-" + test.Source.Scene, [test.Source.Id])`
- `NationalSpire.AiService.TestCopy<T>(T)`；输入表达式：`TestCopy(owner.Ai)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TestCopy(owner.Ai)`
- `NationalSpire.AiService.TestCopy<T>(T)`；输入表达式：`TestCopy(test.Snapshot)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TestCopy(test.Snapshot)`
- `NationalSpire.AiService.TryGetEndpoint(string?, out System.Uri)`；输入表达式：`TryGetEndpoint(connection.Endpoint, out var uri)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !TryGetEndpoint(connection.Endpoint, out var uri)`
- `NationalSpire.AiService.WaitForRequestStartAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`；输入表达式：`WaitForRequestStartAsync(owner, [test.Work])`；返回值紧邻使用处：`AwaitExpressionSyntax: await WaitForRequestStartAsync(owner, [test.Work])`
- `NationalSpire.AiWireProtocol.AiWireProtocol(NationalSpire.CareerData)`；输入表达式：`new AiWireProtocol(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new AiWireProtocol(data)`
- `NationalSpire.AiWireProtocol.Decode(string, bool, string?)`；输入表达式：`wire.Decode(await ReadResponseCompletion(response), expectedArray: test.Source.Scene switch                  { "discussion" => "reactions", "weekly" => "slides", "profiles" => "profiles", _ => "posts" })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = wire.Decode(await ReadResponseCompletion(response), expectedArray: test.Source.Scene switch                  { "discussion" => "reactions", "weekly" => "slides", "profiles" => "profiles", _ => "posts" })`
- `NationalSpire.AiWireProtocol.Encode(string)`；输入表达式：`wire.Encode(test.Context)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: content = wire.Encode(test.Context)`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(owner)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(owner)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(owner)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(owner);`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(test.Work, "completed")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(test.Work, "completed");`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(test.Work, "failed", e is ArgumentException ? e.Message : FailureReason(e))`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(test.Work, "failed", e is ArgumentException ? e.Message : FailureReason(e));`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(test.Work, "queued")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(test.Work, "queued");`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(test.Work, "sending")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(test.Work, "sending");`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("ai.prompt-test:" + trace, e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("ai.prompt-test:" + trace, e);`
- `NationalSpire.PromptLibrary.Save(NationalSpire.AiOptions, string, string)`；输入表达式：`PromptLibrary.Save(options, draft.Key, draft.Value)`；返回值紧邻使用处：`ExpressionStatementSyntax: PromptLibrary.Save(options, draft.Key, draft.Value);`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(test.Owner, owner)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(test.Owner, owner)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(key)) throw new ArgumentException("请先在 模组设置中填写密钥。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("接口地址无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("接口地址无效。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("接收方案已改变，请重新确认。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("接收方案已改变，请重新确认。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请先在 模组设置中开启 AI。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请先在 模组设置中开启 AI。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请先在 模组设置中填写密钥。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请先在 模组设置中填写密钥。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("设置或生涯已切换，本次结果已放弃。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("设置或生涯已切换，本次结果已放弃。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("设置或生涯已切换，请重新测试。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("设置或生涯已切换，请重新测试。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("生涯已切换，请重新选择材料。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("生涯已切换，请重新选择材料。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException(await HttpFailure(response))`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException(await HttpFailure(response));`
- `System.DateTime.ToString(string?)`；输入表达式：`DateTime.UtcNow.ToString("yyyyMMdd")`；返回值紧邻使用处：`ArgumentSyntax: DateTime.UtcNow.ToString("yyyyMMdd")`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`
- `System.Net.Http.Headers.AuthenticationHeaderValue.AuthenticationHeaderValue(string, string?)`；输入表达式：`new AuthenticationHeaderValue("Bearer", key)`；返回值紧邻使用处：`AssignmentExpressionSyntax: request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", key)`
- `System.Net.Http.HttpRequestMessage.HttpRequestMessage(System.Net.Http.HttpMethod, System.Uri?)`；输入表达式：`new HttpRequestMessage(HttpMethod.Post, uri)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HttpRequestMessage(HttpMethod.Post, uri)`
- `System.Net.Http.StringContent.StringContent(string, System.Text.Encoding?, string?)`；输入表达式：`new StringContent(payload, Encoding.UTF8, "application/json")`；返回值紧邻使用处：`AssignmentExpressionSyntax: request.Content = new StringContent(payload, Encoding.UTF8, "application/json")`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new { model = connection.Model, stream = false,                  messages = new[] { new { role = "system", content = ComposeSystem(options, test.Source.Scene) },                      new { role = "user", content = wire.Encode(test.Context) } } }, Json)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonSerializer.Serialize(new { model = connection.Model, stream = false,                  messages = new[] { new { role = "system", content = ComposeSystem(options, test.Source.Scene) },                      new { role = "user", content = wire.Encode(test.Context) } } }, Json)`

**赋值（含属性/字段和局部值）：**

- `owner.Ai.RequestDay` = `today`
- `owner.Ai.RequestsToday` = `0`
- `request.Content` = `new StringContent(payload, Encoding.UTF8, "application/json")`
- `request.Headers.Authorization` = `new AuthenticationHeaderValue("Bearer", key)`
- `test.Previous` = `test.Result`
- `test.Result` = `preview`
- `test.Running` = `false`
- `test.Running` = `true`

<a id="symbol-6f98b36ada7b"></a>

## `Current() — bool Current()`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(owner)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerStore.IsCurrent(owner) && owner.Ai.Enabled`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7208c4c08018"></a>

## `NationalSpire.AiService.ApplyTestResponse(NationalSpire.CareerData, NationalSpire.PromptTestSession, string) — private static string ApplyTestResponse(CareerData data, PromptTestSession test, string content)`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`NationalSpire.AiService.ApplyDiscussionCore(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, NationalSpire.AiService.DiscussionPermission>)`](AiDiscussion.cs.md#symbol-6abdfac46f41)；[`NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?)`](AiService.cs.md#symbol-5cb9c2055e1c)；[`NationalSpire.AiService.ApplyWeeklyResponse(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, string)`](AiWeekly.cs.md#symbol-48defc4d8c32)；[`NationalSpire.AiService.ReadDiscussionPermissions(string)`](AiDiscussion.cs.md#symbol-b2aef7cbc651)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ApplyDiscussionCore(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, NationalSpire.AiService.DiscussionPermission>)`；`NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?)`；`NationalSpire.AiService.ApplyWeeklyResponse(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, string)`；`NationalSpire.AiService.ReadDiscussionPermissions(string)`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ParentId`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.PromptTestSession.Context`；`NationalSpire.PromptTestSession.Message`；`NationalSpire.PromptTestSession.Source`；`NationalSpire.PromptTestSession.TargetId`；`NationalSpire.PromptTestSource.Id`；`NationalSpire.PromptTestSource.Scene`；`NationalSpire.PromptTestSource.Week`；`NationalSpire.WeeklyEdition.Profiles`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklyEdition.Week`；`NationalSpire.WeeklyProfile.Name`；`NationalSpire.WeeklyProfile.Updated`；`NationalSpire.WeeklySlide.Body`；`NationalSpire.WeeklySlide.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ApplyDiscussionCore(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, NationalSpire.AiService.DiscussionPermission>)`；输入表达式：`ApplyDiscussionCore(data, new HashSet<string> { test.TargetId }, [post], content, ReadDiscussionPermissions(test.Context))`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDiscussionCore(data, new HashSet<string> { test.TargetId }, [post], content, ReadDiscussionPermissions(test.Context));`
- `NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?)`；输入表达式：`ApplyNewsResponse(data, [post], content)`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyNewsResponse(data, [post], content);`
- `NationalSpire.AiService.ApplyWeeklyResponse(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, string)`；输入表达式：`ApplyWeeklyResponse(data, issue, profiles, content)`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyWeeklyResponse(data, issue, profiles, content);`
- `NationalSpire.AiService.ReadDiscussionPermissions(string)`；输入表达式：`ReadDiscussionPermissions(test.Context)`；返回值紧邻使用处：`ArgumentSyntax: ReadDiscussionPermissions(test.Context)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, parent.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: " → " + CareerEngine.DisplayName(data, parent.AuthorId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, post.AuthorId)`；返回值紧邻使用处：`InitializerExpressionSyntax: { post.Title, CareerEngine.DisplayName(data, post.AuthorId), post.Body }`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, r.AuthorId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, r.AuthorId)}`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Single`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`oldIds.Contains(r.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !oldIds.Contains(r.Id)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string> { test.TargetId }`；返回值紧邻使用处：`ArgumentSyntax: new HashSet<string> { test.TargetId }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.FirstOrDefault(p => p.Id == r.ParentId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.FirstOrDefault(p => p.Id == r.ParentId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`issue.Profiles.Select(p => p.Name + "\n" + p.Updated)`；返回值紧邻使用处：`ArgumentSyntax: issue.Profiles.Select(p => p.Name + "\n" + p.Updated)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`issue.Slides.Select(s => s.Title + "\n" + s.Body)`；返回值紧邻使用处：`ArgumentSyntax: issue.Slides.Select(s => s.Title + "\n" + s.Body)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`post.Replies.Select(r => r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Select(r => r.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Single(p => p.Id == test.Source.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).Single(p => p.Id == test.Source.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.Single(w => w.Week == test.Source.Week)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.WeeklyEditions.Single(w => w.Week == test.Source.Week)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`post.Replies.Select(r => r.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.Select(r => r.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`post.Replies.Where(r => !oldIds.Contains(r.Id)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.Where(r => !oldIds.Contains(r.Id)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => !oldIds.Contains(r.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => !oldIds.Contains(r.Id)).ToList`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add("测试留言：" + test.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add("测试留言：" + test.Message);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add($"{i + 1}. {CareerEngine.DisplayName(data, r.AuthorId)}" + (parent == null ? "" : " → " + CareerEngine.DisplayName(data, parent.AuthorId)) + "\n" + r.Body)`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add($"{i + 1}. {CareerEngine.DisplayName(data, r.AuthorId)}" + (parent == null ? "" : " → " + CareerEngine.DisplayName(data, parent.AuthorId)) + "\n" + r.Body);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string> { post.Title, CareerEngine.DisplayName(data, post.AuthorId), post.Body }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string> { post.Title, CareerEngine.DisplayName(data, post.AuthorId), post.Body }`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n", issue.Profiles.Select(p => p.Name + "\n" + p.Updated))`；返回值紧邻使用处：`ConditionalExpressionSyntax: profiles ? string.Join("\n\n", issue.Profiles.Select(p => p.Name + "\n" + p.Updated)) : string.Join("\n\n", issue.Slides.Select(s => s.Title + "\n" + s.Body))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n", issue.Slides.Select(s => s.Title + "\n" + s.Body))`；返回值紧邻使用处：`ConditionalExpressionSyntax: profiles ? string.Join("\n\n", issue.Profiles.Select(p => p.Name + "\n" + p.Updated)) : string.Join("\n\n", issue.Slides.Select(s => s.Title + "\n" + s.Body))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n", lines)`；返回值紧邻使用处：`ReturnStatementSyntax: return string.Join("\n\n", lines);`

**赋值（含属性/字段和局部值）：**
