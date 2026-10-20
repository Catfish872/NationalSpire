# Coop/CoopAi.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`F2DCDB52E38FEBC6EE3724CA5D3763BFCAB2B8DF96673414064F23EBF3495E93`。来源：[源码](../../../Coop/CoopAi.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopAi`。

字段、事件及初始值（源码原样）：

```csharp
private bool _running, _pending;
private readonly object _gate = new();
private readonly HashSet<(string Generation, string World, string Epoch, string Message)> _discussions = [];
private string _generation = Guid.NewGuid().ToString("N");
```

<a id="symbol-db98f42d4f99"></a>

## `NationalSpire.Coop.CoopAi.Stop() — public void Stop()`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.SaveAi(NationalSpire.CareerData)`](CoopCareerSession.cs.md#symbol-6fb4f052a4e3)；[`NationalSpire.Coop.CoopRuntime.Disconnect()`](CoopRuntime.cs.md#symbol-a4550fd42c36)

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAi._gate`；`NationalSpire.Coop.CoopAi._generation`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _generation = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**

- `_generation` = `Guid.NewGuid().ToString("N")`

<a id="symbol-3046e7db594f"></a>

## `NationalSpire.Coop.CoopAi.Process(bool) — public Task Process(bool retry = false)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.Generate(bool)`](CoopCareerSession.cs.md#symbol-b759806eeebc)；[`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string)`](CoopRuntime.cs.md#symbol-5c58a004498a)；[`NationalSpire.Coop.CoopRuntime.FinishTerminal()`](CoopRuntime.cs.md#symbol-9dbe454d0582)

**调用：** [`NationalSpire.CommunityThreads.PendingIds(NationalSpire.CareerData)`](../CommunityThreads.cs.md#symbol-1196d0b01b89)；[`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`](CoopAi.cs.md#symbol-b31e3ccef31a)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](CoopAi.cs.md#symbol-b4b98ce85f62)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityThreads.PendingIds(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopAi._discussions`；`NationalSpire.Coop.CoopAi._gate`；`NationalSpire.Coop.CoopAi._generation`；`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`；`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.PendingIds(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.PendingIds(source.World)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.PendingIds(source.World).ToArray`
- `NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`；输入表达式：`ProcessDiscussion(source, key)`；返回值紧邻使用处：`ArgumentSyntax: ProcessDiscussion(source, key)`
- `NationalSpire.Coop.CoopAi.ProcessPublications(bool)`；输入表达式：`ProcessPublications(retry)`；返回值紧邻使用处：`ArgumentSyntax: ProcessPublications(retry)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_discussions.Add(key)`；返回值紧邻使用处：`IfStatementSyntax: if (_discussions.Add(key)) tasks.Add(ProcessDiscussion(source, key));`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`CommunityThreads.PendingIds(source.World).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in CommunityThreads.PendingIds(source.World).ToArray())              {                  var key = (_generation, source.Id, source.Epoch, id);                  if (_discussions.Add(key)) tasks.Add(ProcessDiscussion(source, key));              }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`tasks.Add(ProcessDiscussion(source, key))`；返回值紧邻使用处：`ExpressionStatementSyntax: tasks.Add(ProcessDiscussion(source, key));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`tasks.Add(ProcessPublications(retry))`；返回值紧邻使用处：`ExpressionStatementSyntax: tasks.Add(ProcessPublications(retry));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Task>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Task>()`
- `System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>)`；输入表达式：`Task.WhenAll(tasks)`；返回值紧邻使用处：`ReturnStatementSyntax: return Task.WhenAll(tasks);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b31e3ccef31a"></a>

## `NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message)) — private async Task ProcessDiscussion(CoopWorld source, (string Generation, string World, string Epoch, string Message) key)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopAi.Process(bool)`](CoopAi.cs.md#symbol-3046e7db594f)

**调用：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](../AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](../CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](../CommunityThreads.cs.md#symbol-0da035a7b345)；[`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.Coop.CoopJson.Hash(byte[])`](CoopData.cs.md#symbol-ca6c9ee59a2a)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`NationalSpire.AiOptions.AiOptions()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `(string Generation, string World, string Epoch, string Message).Epoch`；`(string Generation, string World, string Epoch, string Message).Generation`；`(string Generation, string World, string Epoch, string Message).Message`；`(string Generation, string World, string Epoch, string Message).World`；`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.ExternalCurrent`；`NationalSpire.CareerData.ExternalSave`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NeedsReaction`；`NationalSpire.CommunityPost.ReactionGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.NeedsReaction`；`NationalSpire.CommunityReply.ReactionGeneration`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.Coop.CoopAi._discussions`；`NationalSpire.Coop.CoopAi._gate`；`NationalSpire.Coop.CoopAi._generation`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopJson.Hash(byte[])`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([key.Message], data)`；返回值紧邻使用处：`AwaitExpressionSyntax: await AiService.ProcessInteractionsAsync([key.Message], data)`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Ai = AiSettingsStore.Load(new())`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in CommunityThreads.All(data))                  {                      var current = CommunityThreads.All(next.World).FirstOrDefault(p => p.Id == post.Id);                      if (current == null) continue;                      bool updated = false;                      // 每项请求只追加自己的新评论、更新自己的处理状态，保留其他并发请求的结果。                      foreach (var reply in post.Replies.Where(r => !originalReplies.Contains(r.Id)))                          if (!current.Replies.Any(r => r.Id == reply.Id)) { current.Replies.Add(CoopJson.Copy(reply)); updated = true; }                      if (post.Id == key.Message && (current.NeedsReaction != post.NeedsReaction                          || CoopJson.Hash(CoopJson.Bytes(current.ReactionGeneration)) != CoopJson.Hash(CoopJson.Bytes(post.ReactionGeneration))))                      { current.NeedsReaction = post.NeedsReaction; current.ReactionGeneration = CoopJson.Copy(post.ReactionGeneration); updated = true; }                      if (post.Replies.FirstOrDefault(r => r.Id == key.Message) is { } generated                          && current.Replies.FirstOrDefault(r => r.Id == key.Message) is { } existing                          && (existing.NeedsReaction != generated.NeedsReaction                              || CoopJson.Hash(CoopJson.Bytes(existing.ReactionGeneration)) != CoopJson.Hash(CoopJson.Bytes(generated.ReactionGeneration))))                      { existing.NeedsReaction = generated.NeedsReaction; existing.ReactionGeneration = CoopJson.Copy(generated.ReactionGeneration); updated = true; }                      if (updated) { current.Revision++; CommunityThreads.Remember(next.World, current); changed = true; }                  }`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).SelectMany`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(next.World)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(next.World).FirstOrDefault`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.Remember(next.World, current)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.Remember(next.World, current);`
- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`session.Commit(next, session.NativeSave)`；返回值紧邻使用处：`ExpressionStatementSyntax: session.Commit(next, session.NativeSave);`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(current.ReactionGeneration)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(current.ReactionGeneration)`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(existing.ReactionGeneration)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(existing.ReactionGeneration)`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(generated.ReactionGeneration)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(generated.ReactionGeneration)`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(post.ReactionGeneration)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(post.ReactionGeneration)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(generated.ReactionGeneration)`；返回值紧邻使用处：`AssignmentExpressionSyntax: existing.ReactionGeneration = CoopJson.Copy(generated.ReactionGeneration)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(m.Life.Mailbox)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => CoopJson.Copy(m.Life.Mailbox)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(post.ReactionGeneration)`；返回值紧邻使用处：`AssignmentExpressionSyntax: current.ReactionGeneration = CoopJson.Copy(post.ReactionGeneration)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(reply)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Copy(reply)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(session.World!)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(session.World!)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(source.World)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(source.World)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(next.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(next.World);`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(CoopJson.Bytes(current.ReactionGeneration))`；返回值紧邻使用处：`BinaryExpressionSyntax: CoopJson.Hash(CoopJson.Bytes(current.ReactionGeneration)) != CoopJson.Hash(CoopJson.Bytes(post.ReactionGeneration))`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(CoopJson.Bytes(existing.ReactionGeneration))`；返回值紧邻使用处：`BinaryExpressionSyntax: CoopJson.Hash(CoopJson.Bytes(existing.ReactionGeneration)) != CoopJson.Hash(CoopJson.Bytes(generated.ReactionGeneration))`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(CoopJson.Bytes(generated.ReactionGeneration))`；返回值紧邻使用处：`BinaryExpressionSyntax: CoopJson.Hash(CoopJson.Bytes(existing.ReactionGeneration)) != CoopJson.Hash(CoopJson.Bytes(generated.ReactionGeneration))`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(CoopJson.Bytes(post.ReactionGeneration))`；返回值紧邻使用处：`BinaryExpressionSyntax: CoopJson.Hash(CoopJson.Bytes(current.ReactionGeneration)) != CoopJson.Hash(CoopJson.Bytes(post.ReactionGeneration))`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.ai.discussion", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.ai.discussion", e);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`originalReplies.Contains(r.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !originalReplies.Contains(r.Id)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`_discussions.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: _discussions.Remove(key);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`current.Replies.Any(r => r.Id == reply.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !current.Replies.Any(r => r.Id == reply.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(next.World).FirstOrDefault(p => p.Id == post.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(next.World).FirstOrDefault(p => p.Id == post.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`current.Replies.FirstOrDefault(r => r.Id == key.Message)`；返回值紧邻使用处：`IsPatternExpressionSyntax: current.Replies.FirstOrDefault(r => r.Id == key.Message) is { } existing`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.FirstOrDefault(r => r.Id == key.Message)`；返回值紧邻使用处：`IsPatternExpressionSyntax: post.Replies.FirstOrDefault(r => r.Id == key.Message) is { } generated`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CommunityThreads.All(data).SelectMany(p => p.Replies).Select(r => r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).SelectMany(p => p.Replies).Select(r => r.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`CommunityThreads.All(data).SelectMany(p => p.Replies)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).SelectMany(p => p.Replies).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`source.Members.ToDictionary(m => m.PersonId, m => CoopJson.Copy(m.Life.Mailbox))`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.PrivateMemorySources = source.Members.ToDictionary(m => m.PersonId, m => CoopJson.Copy(m.Life.Mailbox))`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`CommunityThreads.All(data).SelectMany(p => p.Replies).Select(r => r.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).SelectMany(p => p.Replies).Select(r => r.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => !originalReplies.Contains(r.Id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var reply in post.Replies.Where(r => !originalReplies.Contains(r.Id)))                          if (!current.Replies.Any(r => r.Id == reply.Id)) { current.Replies.Add(CoopJson.Copy(reply)); updated = true; }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`current.Replies.Add(CoopJson.Copy(reply))`；返回值紧邻使用处：`ExpressionStatementSyntax: current.Replies.Add(CoopJson.Copy(reply));`
- `System.Func<TResult>.Invoke()`；输入表达式：`data.ExternalCurrent()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.ExternalCurrent()`

**赋值（含属性/字段和局部值）：**

- `changed` = `true`
- `current.NeedsReaction` = `post.NeedsReaction`
- `current.ReactionGeneration` = `CoopJson.Copy(post.ReactionGeneration)`
- `data.Ai` = `AiSettingsStore.Load(new())`
- `data.ExternalCurrent` = `() => key.Generation == _generation && session.World?.Id == key.World && session.World?.Epoch == key.Epoch`
- `data.ExternalSave` = `_ =>              {                  lock (_gate)                  {                  if (!data.ExternalCurrent()) return;                  var next = CoopJson.Copy(session.World!); CoopJson.Detached(next.World); bool changed = false;                  foreach (var post in CommunityThreads.All(data))                  {                      var current = CommunityThreads.All(next.World).FirstOrDefault(p => p.Id == post.Id);                      if (current == null) continue;                      bool updated = false;                      // 每项请求只追加自己的新评论、更新自己的处理状态，保留其他并发请求的结果。                      foreach (var reply in post.Replies.Where(r => !originalReplies.Contains(r.Id)))                          if (!current.Replies.Any(r => r.Id == reply.Id)) { current.Replies.Add(CoopJson.Copy(reply)); updated = true; }                      if (post.Id == key.Message && (current.NeedsReaction != post.NeedsReaction                          || CoopJson.Hash(CoopJson.Bytes(current.ReactionGeneration)) != CoopJson.Hash(CoopJson.Bytes(post.ReactionGeneration))))                      { current.NeedsReaction = post.NeedsReaction; current.ReactionGeneration = CoopJson.Copy(post.ReactionGeneration); updated = true; }                      if (post.Replies.FirstOrDefault(r => r.Id == key.Message) is { } generated                          && current.Replies.FirstOrDefault(r => r.Id == key.Message) is { } existing                          && (existing.NeedsReaction != generated.NeedsReaction                              || CoopJson.Hash(CoopJson.Bytes(existing.ReactionGeneration)) != CoopJson.Hash(CoopJson.Bytes(generated.ReactionGeneration))))                      { existing.NeedsReaction = generated.NeedsReaction; existing.ReactionGeneration = CoopJson.Copy(generated.ReactionGeneration); updated = true; }                      if (updated) { current.Revision++; CommunityThreads.Remember(next.World, current); changed = true; }                  }                  if (changed) { next.Revision++; session.Commit(next, session.NativeSave); }                  }              }`
- `data.PrivateMemorySources` = `source.Members.ToDictionary(m => m.PersonId, m => CoopJson.Copy(m.Life.Mailbox))`
- `existing.NeedsReaction` = `generated.NeedsReaction`
- `existing.ReactionGeneration` = `CoopJson.Copy(generated.ReactionGeneration)`
- `updated` = `true`

<a id="symbol-b4b98ce85f62"></a>

## `NationalSpire.Coop.CoopAi.ProcessPublications(bool) — private async Task ProcessPublications(bool retry)`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopAi.Process(bool)`](CoopAi.cs.md#symbol-3046e7db594f)

**调用：** [`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](../AiService.cs.md#symbol-1773c3383336)；[`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?, bool)`](../AiService.cs.md#symbol-4f47e0824ca3)；[`NationalSpire.AiService.RetryWeeklyAsync(int, bool, NationalSpire.CareerData?)`](../AiWeekly.cs.md#symbol-fbf35e9ecdeb)；[`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](../CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](../CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](../CommunityThreads.cs.md#symbol-0da035a7b345)；[`NationalSpire.Coop.CoopAi.Replace(System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.CommunityPost)`](CoopAi.cs.md#symbol-71f4489a3403)；[`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.Coop.CoopJson.Hash(byte[])`](CoopData.cs.md#symbol-ca6c9ee59a2a)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.EventJourney.PublicationsPaused(NationalSpire.CareerData)`](../EventJourney.cs.md#symbol-5010e9adc2fd)；`NationalSpire.AiOptions.AiOptions()`；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Math.Max(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`；`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?, bool)`；`NationalSpire.AiService.RetryWeeklyAsync(int, bool, NationalSpire.CareerData?)`；`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.ExternalCurrent`；`NationalSpire.CareerData.ExternalSave`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.PlayerIntroduction`；`NationalSpire.CareerData.PlayerIntroductionDay`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.CareerPerson.AiIntroduction`；`NationalSpire.CareerPerson.IntroductionDay`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NeedsReaction`；`NationalSpire.CommunityPost.PlayerVotes`；`NationalSpire.CommunityPost.ReactionGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityPost.VoteRevision`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.PlayerVotes`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.Coop.CoopAi._gate`；`NationalSpire.Coop.CoopAi._generation`；`NationalSpire.Coop.CoopAi._pending`；`NationalSpire.Coop.CoopAi._running`；`NationalSpire.Coop.CoopAi.Replace(System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.CommunityPost)`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopJson.Hash(byte[])`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.EventJourney.PublicationsPaused(NationalSpire.CareerData)`；`NationalSpire.LifeEvent.EditionWeek`；`NationalSpire.LifeEvent.Id`；`NationalSpire.WeeklyEdition.Profiles`；`NationalSpire.WeeklyEdition.Week`；`NationalSpire.WeeklyProfile.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessNewsAsync("*", data)`；返回值紧邻使用处：`AwaitExpressionSyntax: await AiService.ProcessNewsAsync("*", data)`
- `NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?, bool)`；输入表达式：`AiService.ProcessPendingAsync(data)`；返回值紧邻使用处：`AwaitExpressionSyntax: await AiService.ProcessPendingAsync(data)`
- `NationalSpire.AiService.RetryWeeklyAsync(int, bool, NationalSpire.CareerData?)`；输入表达式：`AiService.RetryWeeklyAsync(latest.Week, false, data)`；返回值紧邻使用处：`AwaitExpressionSyntax: await AiService.RetryWeeklyAsync(latest.Week, false, data)`
- `NationalSpire.AiService.RetryWeeklyAsync(int, bool, NationalSpire.CareerData?)`；输入表达式：`AiService.RetryWeeklyAsync(latest.Week, true, data)`；返回值紧邻使用处：`AwaitExpressionSyntax: await AiService.RetryWeeklyAsync(latest.Week, true, data)`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Ai = AiSettingsStore.Load(new())`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, profile.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(data, profile.Id)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(next.World, profile.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(next.World, profile.Id)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in CommunityThreads.All(data))                      {                          string hash = CoopJson.Hash(CoopJson.Bytes(post));                          if (knownPosts.GetValueOrDefault(post.Id) == hash) continue;                          var current = CommunityThreads.All(next.World).FirstOrDefault(p => p.Id == post.Id);                          if (current == null || current.SourceBody != post.SourceBody) continue;                          var updated = CoopJson.Copy(post);                          updated.PlayerVotes = current.PlayerVotes; updated.VoteRevision = current.VoteRevision;                          // 只保留任务开始后新增的回复，已被生成结果替换的预制评论不能重新加入。                          var original = originalReplies.GetValueOrDefault(post.Id);                          updated.NeedsReaction = current.NeedsReaction; updated.ReactionGeneration = CoopJson.Copy(current.ReactionGeneration);                          for (int i = 0; i < updated.Replies.Count; i++)                              if (current.Replies.FirstOrDefault(r => r.Id == updated.Replies[i].Id) is { } latest)                              {                                  if (original?.Contains(latest.Id) == true) updated.Replies[i] = CoopJson.Copy(latest);                                  else                                  {                                      updated.Replies[i].PlayerVotes = latest.PlayerVotes;                                  }                              }                          updated.Replies.AddRange(current.Replies.Where(r => original?.Contains(r.Id) != true && !updated.Replies.Any(a => a.Id == r.Id)));                          updated.Revision = Math.Max(current.Revision, updated.Revision) + 1;                          Replace(next.World.Posts, updated); Replace(next.World.SavedThreads, updated);                          CommunityThreads.Remember(next.World, updated); knownPosts[post.Id] = hash; changed = true;                      }`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).ToDictionary`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(next.World)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(next.World).FirstOrDefault`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.Remember(next.World, updated)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.Remember(next.World, updated);`
- `NationalSpire.Coop.CoopAi.Replace(System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.CommunityPost)`；输入表达式：`Replace(next.World.Posts, updated)`；返回值紧邻使用处：`ExpressionStatementSyntax: Replace(next.World.Posts, updated);`
- `NationalSpire.Coop.CoopAi.Replace(System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.CommunityPost)`；输入表达式：`Replace(next.World.SavedThreads, updated)`；返回值紧邻使用处：`ExpressionStatementSyntax: Replace(next.World.SavedThreads, updated);`
- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`session.Commit(next, session.NativeSave)`；返回值紧邻使用处：`ExpressionStatementSyntax: session.Commit(next, session.NativeSave);`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(issue)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(issue)`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(p)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(p)`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(post)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(post)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(current.ReactionGeneration)`；返回值紧邻使用处：`AssignmentExpressionSyntax: updated.ReactionGeneration = CoopJson.Copy(current.ReactionGeneration)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(issue)`；返回值紧邻使用处：`AssignmentExpressionSyntax: next.World.WeeklyEditions[index] = CoopJson.Copy(issue)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(latest)`；返回值紧邻使用处：`AssignmentExpressionSyntax: updated.Replies[i] = CoopJson.Copy(latest)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(m.Life.Mailbox)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => CoopJson.Copy(m.Life.Mailbox)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(memory)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Copy(memory)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(post)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(post)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(session.World!)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(session.World!)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(source.World)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(source.World)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(next.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(next.World);`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(CoopJson.Bytes(issue))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Hash(CoopJson.Bytes(issue))`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(CoopJson.Bytes(p))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CoopJson.Hash(CoopJson.Bytes(p))`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(CoopJson.Bytes(post))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Hash(CoopJson.Bytes(post))`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.ai", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.ai", e);`
- `NationalSpire.EventJourney.PublicationsPaused(NationalSpire.CareerData)`；输入表达式：`EventJourney.PublicationsPaused(session.World.World)`；返回值紧邻使用处：`BinaryExpressionSyntax: !retry && EventJourney.PublicationsPaused(session.World.World)`
- `NationalSpire.EventJourney.PublicationsPaused(NationalSpire.CareerData)`；输入表达式：`EventJourney.PublicationsPaused(source.World)`；返回值紧邻使用处：`BinaryExpressionSyntax: !retry && EventJourney.PublicationsPaused(source.World)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`m.Id.StartsWith($"weekly:{issue.Week}:", StringComparison.Ordinal)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => m.Id.StartsWith($"weekly:{issue.Week}:", StringComparison.Ordinal)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`.Contains(latest.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: original?.Contains(latest.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`.Contains(r.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: original?.Contains(r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`updated.Replies.Any(a => a.Id == r.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !updated.Replies.Any(a => a.Id == r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`next.World.Life.Events.Concat(next.Members.SelectMany(m => m.Life.Events))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: next.World.Life.Events.Concat(next.Members.SelectMany(m => m.Life.Events)).Where`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(next.World).FirstOrDefault(p => p.Id == post.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(next.World).FirstOrDefault(p => p.Id == post.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`current.Replies.FirstOrDefault(r => r.Id == updated.Replies[i].Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: current.Replies.FirstOrDefault(r => r.Id == updated.Replies[i].Id) is { } latest`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`data.WeeklyEditions.LastOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: data.WeeklyEditions.LastOrDefault() is { } latest`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Replies.Select(r => r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.Select(r => r.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`next.Members.SelectMany(m => m.Life.Events)`；返回值紧邻使用处：`ArgumentSyntax: next.Members.SelectMany(m => m.Life.Events)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`CommunityThreads.All(data).ToDictionary(p => p.Id, p => CoopJson.Hash(CoopJson.Bytes(p)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).ToDictionary(p => p.Id, p => CoopJson.Hash(CoopJson.Bytes(p)))`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`CommunityThreads.All(data).ToDictionary(p => p.Id, p => p.Replies.Select(r => r.Id).ToHashSet())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).ToDictionary(p => p.Id, p => p.Replies.Select(r => r.Id).ToHashSet())`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`data.WeeklyEditions.ToDictionary(p => p.Week, p => CoopJson.Hash(CoopJson.Bytes(p)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.WeeklyEditions.ToDictionary(p => p.Week, p => CoopJson.Hash(CoopJson.Bytes(p)))`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`source.Members.ToDictionary(m => m.PersonId, m => CoopJson.Copy(m.Life.Mailbox))`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.PrivateMemorySources = source.Members.ToDictionary(m => m.PersonId, m => CoopJson.Copy(m.Life.Mailbox))`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`p.Replies.Select(r => r.Id).ToHashSet()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Replies.Select(r => r.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`current.Replies.Where(r => original?.Contains(r.Id) != true && !updated.Replies.Any(a => a.Id == r.Id))`；返回值紧邻使用处：`ArgumentSyntax: current.Replies.Where(r => original?.Contains(r.Id) != true && !updated.Replies.Any(a => a.Id == r.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.CommunityMemories.Where(m => m.Id.StartsWith($"weekly:{issue.Week}:", StringComparison.Ordinal))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var memory in data.CommunityMemories.Where(m => m.Id.StartsWith($"weekly:{issue.Week}:", StringComparison.Ordinal)))                          { next.World.CommunityMemories.RemoveAll(m => m.Id == memory.Id); next.World.CommunityMemories.Add(CoopJson.Copy(memory)); }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Life.Events.Where(e => e.EditionWeek == issue.Week)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var activity in data.Life.Events.Where(e => e.EditionWeek == issue.Week))                          {                              foreach (var target in next.World.Life.Events.Concat(next.Members.SelectMany(m => m.Life.Events)).Where(e => e.Id == activity.Id)) target.EditionWeek = issue.Week;                          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`next.World.Life.Events.Concat(next.Members.SelectMany(m => m.Life.Events)).Where(e => e.Id == activity.Id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var target in next.World.Life.Events.Concat(next.Members.SelectMany(m => m.Life.Events)).Where(e => e.Id == activity.Id)) target.EditionWeek = issue.Week;`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`knownPosts.GetValueOrDefault(post.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: knownPosts.GetValueOrDefault(post.Id) == hash`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`knownWeeks.GetValueOrDefault(issue.Week)`；返回值紧邻使用处：`BinaryExpressionSyntax: knownWeeks.GetValueOrDefault(issue.Week) == hash`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`originalReplies.GetValueOrDefault(post.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = originalReplies.GetValueOrDefault(post.Id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`next.World.CommunityMemories.Add(CoopJson.Copy(memory))`；返回值紧邻使用处：`ExpressionStatementSyntax: next.World.CommunityMemories.Add(CoopJson.Copy(memory));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`updated.Replies.AddRange(current.Replies.Where(r => original?.Contains(r.Id) != true && !updated.Replies.Any(a => a.Id == r.Id)))`；返回值紧邻使用处：`ExpressionStatementSyntax: updated.Replies.AddRange(current.Replies.Where(r => original?.Contains(r.Id) != true && !updated.Replies.Any(a => a.Id == r.Id)));`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`next.World.WeeklyEditions.FindIndex(w => w.Week == issue.Week)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = next.World.WeeklyEditions.FindIndex(w => w.Week == issue.Week)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`next.World.CommunityMemories.RemoveAll(m => m.Id == memory.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: next.World.CommunityMemories.RemoveAll(m => m.Id == memory.Id);`
- `System.Func<TResult>.Invoke()`；输入表达式：`data.ExternalCurrent()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.ExternalCurrent()`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(current.Revision, updated.Revision)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(current.Revision, updated.Revision) + 1`

**赋值（含属性/字段和局部值）：**

- `_pending` = `false`
- `_pending` = `true`
- `_running` = `false`
- `_running` = `true`
- `changed` = `true`
- `current.AiIntroduction` = `generated.AiIntroduction`
- `current.IntroductionDay` = `generated.IntroductionDay`
- `data.Ai` = `AiSettingsStore.Load(new())`
- `data.ExternalCurrent` = `() => generation == _generation && session.World?.Id == source.Id && session.World?.Epoch == source.Epoch`
- `data.ExternalSave` = `_ =>                  {                      lock (_gate)                      {                      if (!data.ExternalCurrent()) return;                      var next = CoopJson.Copy(session.World!); CoopJson.Detached(next.World); bool changed = false;                      foreach (var post in CommunityThreads.All(data))                      {                          string hash = CoopJson.Hash(CoopJson.Bytes(post));                          if (knownPosts.GetValueOrDefault(post.Id) == hash) continue;                          var current = CommunityThreads.All(next.World).FirstOrDefault(p => p.Id == post.Id);                          if (current == null || current.SourceBody != post.SourceBody) continue;                          var updated = CoopJson.Copy(post);                          updated.PlayerVotes = current.PlayerVotes; updated.VoteRevision = current.VoteRevision;                          // 只保留任务开始后新增的回复，已被生成结果替换的预制评论不能重新加入。                          var original = originalReplies.GetValueOrDefault(post.Id);                          updated.NeedsReaction = current.NeedsReaction; updated.ReactionGeneration = CoopJson.Copy(current.ReactionGeneration);                          for (int i = 0; i < updated.Replies.Count; i++)                              if (current.Replies.FirstOrDefault(r => r.Id == updated.Replies[i].Id) is { } latest)                              {                                  if (original?.Contains(latest.Id) == true) updated.Replies[i] = CoopJson.Copy(latest);                                  else                                  {                                      updated.Replies[i].PlayerVotes = latest.PlayerVotes;                                  }                              }                          updated.Replies.AddRange(current.Replies.Where(r => original?.Contains(r.Id) != true && !updated.Replies.Any(a => a.Id == r.Id)));                          updated.Revision = Math.Max(current.Revision, updated.Revision) + 1;                          Replace(next.World.Posts, updated); Replace(next.World.SavedThreads, updated);                          CommunityThreads.Remember(next.World, updated); knownPosts[post.Id] = hash; changed = true;                      }                      foreach (var issue in data.WeeklyEditions)                      {                          string hash = CoopJson.Hash(CoopJson.Bytes(issue));                          if (knownWeeks.GetValueOrDefault(issue.Week) == hash) continue;                          int index = next.World.WeeklyEditions.FindIndex(w => w.Week == issue.Week);                          if (index < 0) continue;                          next.World.WeeklyEditions[index] = CoopJson.Copy(issue); knownWeeks[issue.Week] = hash; changed = true;                          foreach (var profile in issue.Profiles)                          {                              var generated = CareerEngine.Person(data, profile.Id);                              var current = CareerEngine.Person(next.World, profile.Id);                              if (generated != null && current != null && generated.IntroductionDay >= current.IntroductionDay)                              { current.AiIntroduction = generated.AiIntroduction; current.IntroductionDay = generated.IntroductionDay; }                          }                          if (data.PlayerIntroductionDay >= next.World.PlayerIntroductionDay)                          { next.World.PlayerIntroduction = data.PlayerIntroduction; next.World.PlayerIntroductionDay = data.PlayerIntroductionDay; }                          foreach (var memory in data.CommunityMemories.Where(m => m.Id.StartsWith($"weekly:{issue.Week}:", StringComparison.Ordinal)))                          { next.World.CommunityMemories.RemoveAll(m => m.Id == memory.Id); next.World.CommunityMemories.Add(CoopJson.Copy(memory)); }                          foreach (var activity in data.Life.Events.Where(e => e.EditionWeek == issue.Week))                          {                              foreach (var target in next.World.Life.Events.Concat(next.Members.SelectMany(m => m.Life.Events)).Where(e => e.Id == activity.Id)) target.EditionWeek = issue.Week;                          }                      }                      if (changed) { next.Revision++; session.Commit(next, session.NativeSave); }                      }                  }`
- `data.PrivateMemorySources` = `source.Members.ToDictionary(m => m.PersonId, m => CoopJson.Copy(m.Life.Mailbox))`
- `knownPosts[post.Id]` = `hash`
- `knownWeeks[issue.Week]` = `hash`
- `next.World.PlayerIntroduction` = `data.PlayerIntroduction`
- `next.World.PlayerIntroductionDay` = `data.PlayerIntroductionDay`
- `next.World.WeeklyEditions[index]` = `CoopJson.Copy(issue)`
- `retry` = `false`
- `target.EditionWeek` = `issue.Week`
- `updated.NeedsReaction` = `current.NeedsReaction`
- `updated.PlayerVotes` = `current.PlayerVotes`
- `updated.ReactionGeneration` = `CoopJson.Copy(current.ReactionGeneration)`
- `updated.Replies[i].PlayerVotes` = `latest.PlayerVotes`
- `updated.Replies[i]` = `CoopJson.Copy(latest)`
- `updated.Revision` = `Math.Max(current.Revision, updated.Revision) + 1`
- `updated.VoteRevision` = `current.VoteRevision`

<a id="symbol-71f4489a3403"></a>

## `NationalSpire.Coop.CoopAi.Replace(System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.CommunityPost) — private static void Replace(List<CommunityPost> posts, CommunityPost updated)`

来源：源码第 158 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](CoopAi.cs.md#symbol-b4b98ce85f62)

**调用：** `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`posts.FindIndex(p => p.Id == updated.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = posts.FindIndex(p => p.Id == updated.Id)`

**赋值（含属性/字段和局部值）：**

- `posts[index]` = `updated`
