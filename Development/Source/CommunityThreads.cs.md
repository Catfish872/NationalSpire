# CommunityThreads.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1F23C42CD428AEE6BA8F22F385D40173A2D93A157C47391638367C09A80D7897`。来源：[源码](../../CommunityThreads.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CommunityThreads`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-1d3cb55b1636"></a>

## `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string) — public static bool IsHuman(CareerData data, string id)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string)`](AiService.cs.md#symbol-5cb9c2055e1c)；[`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.AiService.BuildWeeklyContext(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool)`](AiWeekly.cs.md#symbol-d24065dcfca3)；[`NationalSpire.AiService.DiscussionFavour(NationalSpire.CareerData, string, NationalSpire.CommunityPost, System.Collections.Generic.ISet<string>)`](AiDiscussion.cs.md#symbol-17d3d2eafe88)；[`NationalSpire.AiService.DiscussionPeople(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Collections.Generic.ISet<string>)`](AiDiscussion.cs.md#symbol-02eb53d0adba)；[`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?, NationalSpire.ChatTimeline.PublicMemoryRequest?)`](AiDiscussion.cs.md#symbol-7fe54dbd182e)；[`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)；[`NationalSpire.AiService.PromptPeople(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-8981dbfc57ac)；[`NationalSpire.AiService.ReplyAttitudes(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>, string)`](AiDiscussion.cs.md#symbol-fdff22dfb023)；[`NationalSpire.AiService.ReplyAuthors(NationalSpire.CareerData)`](AiDiscussion.cs.md#symbol-cd4df223dc51)；[`NationalSpire.AiWireProtocol.AddMemorySources(System.Text.Json.Nodes.JsonNode)`](AiWireProtocol.cs.md#symbol-724c4b9d095b)；[`NationalSpire.CareerScreen.DiscussionActions(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityShareScreen.cs.md#symbol-411381a49420)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CommunityMemorySearch.Request.RecentPlayerPosts(NationalSpire.CareerData, int)`](CommunityMemorySearch.cs.md#symbol-4ac65acae692)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?)`](CommunityMemorySearch.cs.md#symbol-43d223752125)；[`NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`](CommunityMentions.cs.md#symbol-a915a754512b)；[`NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](CommunitySharing.cs.md#symbol-b6e3b5a6b60e)；[`NationalSpire.CommunityThreads.Audience(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-a16197b41bab)；[`NationalSpire.CommunityThreads.MarkProgramRead(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-7398f6d1a869)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；[`NationalSpire.CommunityThreads.OfflineReactions(NationalSpire.CareerData, System.Collections.Generic.IReadOnlySet<string>)`](CommunityThreads.cs.md#symbol-6d730155cd69)；[`NationalSpire.CommunityThreads.Pending(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-39b964026d46)；[`NationalSpire.CommunityThreads.PendingIds(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-1196d0b01b89)；[`NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-e83d7ef9fb98)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；[`NationalSpire.CommunityThreads.SetInteractionState(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, string, string)`](CommunityThreads.cs.md#symbol-1400c993f787)；[`NationalSpire.CommunityThreads.TrimFeed(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-460bb0bb6649)；[`NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-64a35a4c39c2)；[`NationalSpire.CommunityVotes.SetVote(NationalSpire.CareerData, string, string, int, string)`](CommunityVotes.cs.md#symbol-99e71e3dfed8)；[`NationalSpire.PrivateMessages.PublicMemory(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`](PrivateMessages.cs.md#symbol-81234ccf975f)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson?, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?, bool)`](PrivatePublicContext.cs.md#symbol-b4d8110deb5b)；[`NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`](PublicationBacklog.cs.md#symbol-28c8b28b12c8)

**调用：** `System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "player" || data.HumanIds.Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1400c993f787"></a>

## `NationalSpire.CommunityThreads.SetInteractionState(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, string, string) — public static void SetInteractionState(CareerData data, ISet<string> ids, string state, string error = "")`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`](CommunityThreads.cs.md#symbol-981631ecddfc)；`System.Collections.Generic.ICollection<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.PersonalPost`；`NationalSpire.CommunityPost.ReactionGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ReactionGeneration`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`All(data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in All(data))          {              if (ids.Contains(post.Id) && (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost)) SetWork(post.ReactionGeneration, state, error);              foreach (var reply in post.Replies.Where(r => ids.Contains(r.Id) && CommunityThreads.IsHuman(data, r.AuthorId))) SetWork(reply.ReactionGeneration, state, error);          }`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, r.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: ids.Contains(r.Id) && CommunityThreads.IsHuman(data, r.AuthorId)`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`SetWork(post.ReactionGeneration, state, error)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetWork(post.ReactionGeneration, state, error);`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`SetWork(reply.ReactionGeneration, state, error)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetWork(reply.ReactionGeneration, state, error);`
- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`ids.Contains(post.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ids.Contains(post.Id) && (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost)`
- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`ids.Contains(r.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ids.Contains(r.Id) && CommunityThreads.IsHuman(data, r.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => ids.Contains(r.Id) && CommunityThreads.IsHuman(data, r.AuthorId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var reply in post.Replies.Where(r => ids.Contains(r.Id) && CommunityThreads.IsHuman(data, r.AuthorId))) SetWork(reply.ReactionGeneration, state, error);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-981631ecddfc"></a>

## `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string) — public static void SetWork(AiWorkState work, string state, string error = "")`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Fail(string)`](AiWeekly.cs.md#symbol-c3796a0893a9)；[`NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string)`](AiService.cs.md#symbol-5cb9c2055e1c)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)；[`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)；[`NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-e83d7ef9fb98)；[`NationalSpire.CommunityThreads.SetInteractionState(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, string, string)`](CommunityThreads.cs.md#symbol-1400c993f787)；[`NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool)`](PublicationBacklog.cs.md#symbol-37eb1c83d725)；[`NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-182dc6fd73e0)；[`NationalSpire.WeeklyJournal.Recover(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-f465ec0d1539)；[`Recover(NationalSpire.AiWorkState, bool)`](CommunityThreads.cs.md#symbol-bdccfa7732e1)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.Error`；`NationalSpire.AiWorkState.State`；`NationalSpire.AiWorkState.WaitReason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `work.Error` = `error`
- `work.State` = `state`
- `work.WaitReason` = `""`

<a id="symbol-e83d7ef9fb98"></a>

## `NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData) — public static bool RecoverInterrupted(CareerData data)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](Coop/CoopCoordinator.cs.md#symbol-778097f34ec3)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`](CommunityThreads.cs.md#symbol-981631ecddfc)；[`Recover(NationalSpire.AiWorkState, bool)`](CommunityThreads.cs.md#symbol-bdccfa7732e1)

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.Error`；`NationalSpire.AiWorkState.State`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.EditorialVersion`；`NationalSpire.CommunityPost.NeedsReaction`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.PersonalPost`；`NationalSpire.CommunityPost.ReactionGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.NeedsReaction`；`NationalSpire.CommunityReply.ReactionGeneration`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；`Recover(NationalSpire.AiWorkState, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`All(data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in All(data))          {              if (post.NewsGeneration.State == "failed" && post.NewsGeneration.Error == "今日请求额度已用完")              { post.NewsGeneration.Error = "旧版调用限制已移除，可重试"; changed = true; }              Recover(post.ReactionGeneration, (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost) && post.NeedsReaction);              foreach (var r in post.Replies) Recover(r.ReactionGeneration, CommunityThreads.IsHuman(data, r.AuthorId) && r.NeedsReaction);              if (post.NewsGeneration.State is "queued" or "sending")              { SetWork(post.NewsGeneration, "failed", "上次生成中断，可重试"); changed = true; }              else if (post.EditorialVersion == 0 && !post.AiPending && post.SourceBody.Length > 0 && post.NewsGeneration.State == "idle")              { SetWork(post.NewsGeneration, "completed"); changed = true; }          }`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, r.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.IsHuman(data, r.AuthorId) && r.NeedsReaction`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`SetWork(post.NewsGeneration, "completed")`；返回值紧邻使用处：`ExpressionStatementSyntax: SetWork(post.NewsGeneration, "completed");`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`SetWork(post.NewsGeneration, "failed", "上次生成中断，可重试")`；返回值紧邻使用处：`ExpressionStatementSyntax: SetWork(post.NewsGeneration, "failed", "上次生成中断，可重试");`
- `Recover(NationalSpire.AiWorkState, bool)`；输入表达式：`Recover(post.ReactionGeneration, (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost) && post.NeedsReaction)`；返回值紧邻使用处：`ExpressionStatementSyntax: Recover(post.ReactionGeneration, (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost) && post.NeedsReaction);`
- `Recover(NationalSpire.AiWorkState, bool)`；输入表达式：`Recover(r.ReactionGeneration, CommunityThreads.IsHuman(data, r.AuthorId) && r.NeedsReaction)`；返回值紧邻使用处：`ExpressionStatementSyntax: Recover(r.ReactionGeneration, CommunityThreads.IsHuman(data, r.AuthorId) && r.NeedsReaction);`

**赋值（含属性/字段和局部值）：**

- `changed` = `true`
- `post.NewsGeneration.Error` = `"旧版调用限制已移除，可重试"`

<a id="symbol-bdccfa7732e1"></a>

## `Recover(NationalSpire.AiWorkState, bool) — void Recover(AiWorkState work, bool pending)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-e83d7ef9fb98)

**调用：** [`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`](CommunityThreads.cs.md#symbol-981631ecddfc)

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.Error`；`NationalSpire.AiWorkState.State`；`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`SetWork(work, "failed", "上次回应未完成，可重试")`；返回值紧邻使用处：`ExpressionStatementSyntax: SetWork(work, "failed", "上次回应未完成，可重试");`

**赋值（含属性/字段和局部值）：**

- `changed` = `true`
- `work.Error` = `"旧版调用限制已移除，可重试"`

<a id="symbol-35173ffbb055"></a>

## `NationalSpire.CommunityThreads.All(NationalSpire.CareerData) — public static IEnumerable<CommunityPost> All(CareerData data)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyDiscussionCore(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, NationalSpire.AiService.DiscussionPermission>)`](AiDiscussion.cs.md#symbol-6abdfac46f41)；[`NationalSpire.AiService.ApplyTestResponse(NationalSpire.CareerData, NationalSpire.PromptTestSession, string)`](PromptTesting.cs.md#symbol-7208c4c08018)；[`NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string)`](PromptTesting.cs.md#symbol-c81f52ee7090)；[`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)；[`NationalSpire.AiService.ReactionTargets(NationalSpire.CareerData, System.Collections.Generic.ISet<string>)`](AiDiscussion.cs.md#symbol-1c8534d2a5f2)；[`NationalSpire.AiService.TestSources(NationalSpire.CareerData, string)`](PromptTesting.cs.md#symbol-bac6770dfaa1)；[`NationalSpire.AiWireProtocol.AddMemorySources(System.Text.Json.Nodes.JsonNode)`](AiWireProtocol.cs.md#symbol-724c4b9d095b)；[`NationalSpire.AiWireProtocol.AiWireProtocol(NationalSpire.CareerData)`](AiWireProtocol.cs.md#symbol-ebb8d59c054e)；[`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)；[`NationalSpire.CareerEngine.PublishMatchDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-1e1428a365f6)；[`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)；[`NationalSpire.CareerLife.RefreshPublicFacts(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-e81d9b416e03)；[`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)；[`NationalSpire.CareerScreen.CompleteThreadReply(string, string, string)`](CommunityScreen.cs.md#symbol-d9fcfe778254)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-825caeb63a3b)；[`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int)`](PeoplePickerScreen.cs.md#symbol-80a307ead785)；[`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)；[`NationalSpire.CareerScreen.RefreshSettlementDiscussion(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ab0215572f9e)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-cfc51eea9b9f)；[`NationalSpire.CareerScreen.UpdateNavigation()`](CareerNavigation.cs.md#symbol-a6094a69b6d7)；[`NationalSpire.CommunityMemorySearch.BuildSearch(NationalSpire.CareerData, int, System.Collections.Generic.HashSet<string>)`](CommunityMemorySearch.cs.md#symbol-a0f6a3280fc9)；[`NationalSpire.CommunityMemorySearch.Request.AcquaintancePool(NationalSpire.CareerData)`](CommunityMemorySearch.cs.md#symbol-67dafab02c86)；[`NationalSpire.CommunityMemorySearch.Request.Posts(NationalSpire.CareerData)`](CommunityMemorySearch.cs.md#symbol-6d86e3dcd515)；[`NationalSpire.CommunityReporting.Create(NationalSpire.CareerData, string, string, string)`](CommunityReporting.cs.md#symbol-6bbc23d16690)；[`NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](CommunitySharing.cs.md#symbol-b6e3b5a6b60e)；[`NationalSpire.CommunityThreads.MarkProgramRead(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-7398f6d1a869)；[`NationalSpire.CommunityThreads.Normalize(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-95e97a5c9007)；[`NationalSpire.CommunityThreads.OfflineReactions(NationalSpire.CareerData, System.Collections.Generic.IReadOnlySet<string>)`](CommunityThreads.cs.md#symbol-6d730155cd69)；[`NationalSpire.CommunityThreads.Pending(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-39b964026d46)；[`NationalSpire.CommunityThreads.PendingIds(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-1196d0b01b89)；[`NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-e83d7ef9fb98)；[`NationalSpire.CommunityThreads.SetInteractionState(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, string, string)`](CommunityThreads.cs.md#symbol-1400c993f787)；[`NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string)`](CommunityThreads.cs.md#symbol-4de765d004ff)；[`NationalSpire.CommunityThreads.Unread(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-a39689737c6f)；[`NationalSpire.CommunityVotes.SetVote(NationalSpire.CareerData, string, string, int, string)`](CommunityVotes.cs.md#symbol-99e71e3dfed8)；[`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`](Coop/CoopAi.cs.md#symbol-b31e3ccef31a)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](Coop/CoopAi.cs.md#symbol-b4b98ce85f62)；[`NationalSpire.Coop.CoopCareerSession.SaveReading(NationalSpire.CareerData)`](Coop/CoopCareerSession.cs.md#symbol-34fbd3119785)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`](Coop/CoopRules.cs.md#symbol-99be42ec0491)；[`NationalSpire.Coop.CoopRules.InterfaceView(NationalSpire.Coop.CoopWorld, ulong)`](Coop/CoopRules.cs.md#symbol-c23013f591a9)；[`NationalSpire.Diagnostics.RetainErrors(NationalSpire.CareerData)`](ErrorDiagnostics.cs.md#symbol-83a342d01ea6)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)；[`NationalSpire.PrivateProfileChanges.Publish(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateProfileChanges.cs.md#symbol-930916e1d31b)；[`NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool)`](PublicationBacklog.cs.md#symbol-37eb1c83d725)；[`NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`](PublicationBacklog.cs.md#symbol-28c8b28b12c8)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)；[`Vote(int)`](CommunityScreen.cs.md#symbol-8f211a670431)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CommunityPost.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`data.Posts.Concat(data.SavedThreads)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Posts.Concat(data.SavedThreads).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Posts.Concat(data.SavedThreads).DistinctBy(p => p.Id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => data.Posts.Concat(data.SavedThreads).DistinctBy(p => p.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3e0f576a5190"></a>

## `NationalSpire.CommunityThreads.ContextReplies(NationalSpire.CommunityPost, int, bool, System.Collections.Generic.IEnumerable<string>?) — public static List<CommunityReply> ContextReplies(CommunityPost post, int day, bool complete = false, IEnumerable<string>? anchors = null)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.CommunityReporting.Create(NationalSpire.CareerData, string, string, string)`](CommunityReporting.cs.md#symbol-6bbc23d16690)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson?, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?, bool)`](PrivatePublicContext.cs.md#symbol-b4d8110deb5b)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ParentId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`index.TryGetValue(parent, out var reply)`；返回值紧邻使用处：`BinaryExpressionSyntax: index.TryGetValue(parent, out var reply) && chosen.Add(parent)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`chosen.Add(parent)`；返回值紧邻使用处：`BinaryExpressionSyntax: index.TryGetValue(parent, out var reply) && chosen.Add(parent)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`chosen.Contains(r.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => chosen.Contains(r.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`focus.Contains(r.ParentId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => focus.Contains(r.ParentId)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`replies.Take(2).Concat(replies.TakeLast(16)).Select(r => r.Id).Concat(focus)              .Concat(replies.Where(r => focus.Contains(r.ParentId)).Select(r => r.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: replies.Take(2).Concat(replies.TakeLast(16)).Select(r => r.Id).Concat(focus)              .Concat(replies.Where(r => focus.Contains(r.ParentId)).Select(r => r.Id)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`replies.Take(2).Concat(replies.TakeLast(16)).Select(r => r.Id).Concat(focus)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: replies.Take(2).Concat(replies.TakeLast(16)).Select(r => r.Id).Concat(focus)              .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`replies.Take(2).Concat(replies.TakeLast(16))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: replies.Take(2).Concat(replies.TakeLast(16)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`post.Replies.Where(r => r.Day <= day).DistinctBy(r => r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= day).DistinctBy(r => r.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`replies.Take(2).Concat(replies.TakeLast(16)).Select(r => r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: replies.Take(2).Concat(replies.TakeLast(16)).Select(r => r.Id).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`replies.Where(r => focus.Contains(r.ParentId)).Select(r => r.Id)`；返回值紧邻使用处：`ArgumentSyntax: replies.Where(r => focus.Contains(r.ParentId)).Select(r => r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`replies.Take(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: replies.Take(2).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`replies.TakeLast(16)`；返回值紧邻使用处：`ArgumentSyntax: replies.TakeLast(16)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`chosen.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in chosen.ToArray())          {              string parent = index[id].ParentId;              while (index.TryGetValue(parent, out var reply) && chosen.Add(parent)) parent = reply.ParentId;          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`replies.ToDictionary(r => r.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = replies.ToDictionary(r => r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`(anchors ?? []).Where(index.ContainsKey).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (anchors ?? []).Where(index.ContainsKey).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`replies.Take(2).Concat(replies.TakeLast(16)).Select(r => r.Id).Concat(focus)              .Concat(replies.Where(r => focus.Contains(r.ParentId)).Select(r => r.Id)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = replies.Take(2).Concat(replies.TakeLast(16)).Select(r => r.Id).Concat(focus)              .Concat(replies.Where(r => focus.Contains(r.ParentId)).Select(r => r.Id)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`post.Replies.Where(r => r.Day <= day).DistinctBy(r => r.Id).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.Where(r => r.Day <= day).DistinctBy(r => r.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`replies.Where(r => chosen.Contains(r.Id)).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return replies.Where(r => chosen.Contains(r.Id)).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(anchors ?? []).Where(index.ContainsKey)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (anchors ?? []).Where(index.ContainsKey).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => r.Day <= day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= day).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`replies.Where(r => chosen.Contains(r.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: replies.Where(r => chosen.Contains(r.Id)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`replies.Where(r => focus.Contains(r.ParentId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: replies.Where(r => focus.Contains(r.ParentId)).Select`

**赋值（含属性/字段和局部值）：**

- `parent` = `reply.ParentId`

<a id="symbol-87fd384e7842"></a>

## `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost) — public static bool NewsPending(CareerData data, CommunityPost post)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, bool)`](CareerScreen.cs.md#symbol-d5523b24e9f1)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`](CommunityScreen.cs.md#symbol-85990747d510)；[`NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-f92fad8b113e)；[`NationalSpire.CommunityMemorySearch.BuildSearch(NationalSpire.CareerData, int, System.Collections.Generic.HashSet<string>)`](CommunityMemorySearch.cs.md#symbol-a0f6a3280fc9)；[`NationalSpire.CommunityMemorySearch.Request.AcquaintancePool(NationalSpire.CareerData)`](CommunityMemorySearch.cs.md#symbol-67dafab02c86)；[`NationalSpire.CommunityMemorySearch.Request.Posts(NationalSpire.CareerData)`](CommunityMemorySearch.cs.md#symbol-6d86e3dcd515)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)

**调用：** [`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiWorkState.State`；`NationalSpire.CareerData.Ai`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.IsHuman(data, post.AuthorId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a39689737c6f"></a>

## `NationalSpire.CommunityThreads.Unread(NationalSpire.CareerData) — public static int Unread(CareerData data)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.UpdateCommunityBadge()`](CommunityScreen.cs.md#symbol-09dc30b97d0c)；[`NationalSpire.CommunityUpdateButton._Process(double)`](CommunityScreen.cs.md#symbol-ae698159460a)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SeenRevision`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(data).Count`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`All(data).Count(p => p.Revision > p.SeenRevision)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => All(data).Count(p => p.Revision > p.SeenRevision)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-39b964026d46"></a>

## `NationalSpire.CommunityThreads.Pending(NationalSpire.CareerData) — public static IEnumerable<CommunityReply> Pending(CareerData data)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityThreads.PendingIds(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-1196d0b01b89)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.NeedsReaction`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(data).SelectMany`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, r.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.IsHuman(data, r.AuthorId) && r.NeedsReaction`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`All(data).SelectMany(p => p.Replies)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(data).SelectMany(p => p.Replies).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`All(data).SelectMany(p => p.Replies).Where(r => CommunityThreads.IsHuman(data, r.AuthorId) && r.NeedsReaction)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => All(data).SelectMany(p => p.Replies).Where(r => CommunityThreads.IsHuman(data, r.AuthorId) && r.NeedsReaction)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1196d0b01b89"></a>

## `NationalSpire.CommunityThreads.PendingIds(NationalSpire.CareerData) — public static IEnumerable<string> PendingIds(CareerData data)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyDiscussionCore(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, NationalSpire.AiService.DiscussionPermission>)`](AiDiscussion.cs.md#symbol-6abdfac46f41)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.Coop.CoopAi.Process(bool)`](Coop/CoopAi.cs.md#symbol-3046e7db594f)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityThreads.Pending(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-39b964026d46)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NeedsReaction`；`NationalSpire.CommunityPost.PersonalPost`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.Pending(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(data).Where`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, p.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.IsHuman(data, p.AuthorId) || p.PersonalPost`
- `NationalSpire.CommunityThreads.Pending(NationalSpire.CareerData)`；输入表达式：`Pending(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Pending(data).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`Pending(data).Select(r => r.Id)          .Concat(All(data).Where(p => (CommunityThreads.IsHuman(data, p.AuthorId) || p.PersonalPost) && p.NeedsReaction).Select(p => p.Id))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Pending(data).Select(r => r.Id)          .Concat(All(data).Where(p => (CommunityThreads.IsHuman(data, p.AuthorId) || p.PersonalPost) && p.NeedsReaction).Select(p => p.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`All(data).Where(p => (CommunityThreads.IsHuman(data, p.AuthorId) || p.PersonalPost) && p.NeedsReaction).Select(p => p.Id)`；返回值紧邻使用处：`ArgumentSyntax: All(data).Where(p => (CommunityThreads.IsHuman(data, p.AuthorId) || p.PersonalPost) && p.NeedsReaction).Select(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Pending(data).Select(r => r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Pending(data).Select(r => r.Id)          .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`All(data).Where(p => (CommunityThreads.IsHuman(data, p.AuthorId) || p.PersonalPost) && p.NeedsReaction)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(data).Where(p => (CommunityThreads.IsHuman(data, p.AuthorId) || p.PersonalPost) && p.NeedsReaction).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d9b68d9a8f52"></a>

## `NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string) — public static CommunityPost Publish(CareerData data, string title, string body)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`](CommunityMentions.cs.md#symbol-a915a754512b)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；[`NationalSpire.CommunityThreads.TrimFeed(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-460bb0bb6649)；`NationalSpire.CommunityPost.CommunityPost()`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Collections.Generic.List<T>.Insert(int, T)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.MatchKind`；`NationalSpire.CommunityPost.MentionedPeople`；`NationalSpire.CommunityPost.NeedsReaction`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.SeenRevision`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.TrimFeed(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`；输入表达式：`CommunityMentions.Resolve(data, post.Title + "\n" + post.Body)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.MentionedPeople = CommunityMentions.Resolve(data, post.Title + "\n" + post.Body)`
- `NationalSpire.CommunityPost.CommunityPost()`；输入表达式：`new CommunityPost { Title = title.Trim(), Body = body.Trim(), AuthorId = "player", Day = data.Day,              Category = "玩家讨论", MatchKind = "local", RelatedPeople = ["player"], NeedsReaction = true, SeenRevision = 1 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CommunityPost { Title = title.Trim(), Body = body.Trim(), AuthorId = "player", Day = data.Day,              Category = "玩家讨论", MatchKind = "local", RelatedPeople = ["player"], NeedsReaction = true, SeenRevision = 1 }`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`Remember(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: Remember(data, post);`
- `NationalSpire.CommunityThreads.TrimFeed(NationalSpire.CareerData)`；输入表达式：`TrimFeed(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: TrimFeed(data);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(body)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(body)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(title)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(body)`
- `string.Trim()`；输入表达式：`body.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Body = body.Trim()`
- `string.Trim()`；输入表达式：`title.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Title = title.Trim()`
- `System.Collections.Generic.List<T>.Insert(int, T)`；输入表达式：`data.Posts.Insert(0, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Posts.Insert(0, post);`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请填写标题和正文。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请填写标题和正文。");`

**赋值（含属性/字段和局部值）：**

- `AuthorId` = `"player"`
- `Body` = `body.Trim()`
- `Category` = `"玩家讨论"`
- `Day` = `data.Day`
- `MatchKind` = `"local"`
- `NeedsReaction` = `true`
- `post.MentionedPeople` = `CommunityMentions.Resolve(data, post.Title + "\n" + post.Body)`
- `RelatedPeople` = `["player"]`
- `SeenRevision` = `1`
- `Title` = `title.Trim()`

<a id="symbol-95e97a5c9007"></a>

## `NationalSpire.CommunityThreads.Normalize(NationalSpire.CareerData) — public static bool Normalize(CareerData data)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](Coop/CoopCoordinator.cs.md#symbol-778097f34ec3)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；`string.IsNullOrEmpty(string?)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.Math.Max(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CommunityVersion`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.MatchKind`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ParentId`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`All(data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in All(data))          {              if (data.CommunityVersion < 2)              {                  post.Revision = Math.Max(1, post.Revision);                  var known = new HashSet<string>();                  foreach (var r in post.Replies)                  {                      if (string.IsNullOrEmpty(r.Id) || known.Contains(r.Id)) r.Id = Guid.NewGuid().ToString("N");                      if (!known.Contains(r.ParentId)) r.ParentId = "";                      known.Add(r.Id); if (r.Day == 0) r.Day = post.Day;                  }                  post.MatchKind = data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)?.Kind ?? post.MatchKind;              }              Remember(data, post);          }`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`Remember(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: Remember(data, post);`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(r.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrEmpty(r.Id) || known.Contains(r.Id)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`known.Add(r.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: known.Add(r.Id);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`known.Contains(r.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrEmpty(r.Id) || known.Contains(r.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`known.Contains(r.ParentId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !known.Contains(r.ParentId)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)?.Kind`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`AssignmentExpressionSyntax: r.Id = Guid.NewGuid().ToString("N")`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(1, post.Revision)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.Revision = Math.Max(1, post.Revision)`

**赋值（含属性/字段和局部值）：**

- `data.CommunityVersion` = `6`
- `post.MatchKind` = `data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)?.Kind ?? post.MatchKind`
- `post.Revision` = `Math.Max(1, post.Revision)`
- `r.Day` = `post.Day`
- `r.Id` = `Guid.NewGuid().ToString("N")`
- `r.ParentId` = `""`

<a id="symbol-d891e2f0e3ea"></a>

## `NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost) — public static void MarkRead(CareerData data, CommunityPost post)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SeenRevision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`

**赋值（含属性/字段和局部值）：**

- `post.SeenRevision` = `post.Revision`

<a id="symbol-7398f6d1a869"></a>

## `NationalSpire.CommunityThreads.MarkProgramRead(NationalSpire.CareerData) — public static int MarkProgramRead(CareerData data)`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.State`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SeenRevision`；`NationalSpire.CommunityReply.AiGenerated`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(data).Where`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, p.AuthorId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.IsHuman(data, p.AuthorId)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, r.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.IsHuman(data, r.AuthorId) || r.AiGenerated`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId) || r.AiGenerated)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId) || r.AiGenerated)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`All(data).Where(p => !CommunityThreads.IsHuman(data, p.AuthorId) && p.NewsGeneration.State != "completed"              && !p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId) || r.AiGenerated) && p.Revision > p.SeenRevision)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in All(data).Where(p => !CommunityThreads.IsHuman(data, p.AuthorId) && p.NewsGeneration.State != "completed"              && !p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId) || r.AiGenerated) && p.Revision > p.SeenRevision))          { post.SeenRevision = post.Revision; count++; }`

**赋值（含属性/字段和局部值）：**

- `post.SeenRevision` = `post.Revision`

<a id="symbol-4de765d004ff"></a>

## `NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string) — public static CommunityReply Submit(CareerData data, CommunityPost post, string parentId, string body)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`](CommunityMentions.cs.md#symbol-a915a754512b)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；`NationalSpire.CommunityReply.CommunityReply()`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.List<T>.Add(T)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SeenRevision`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.MentionedPeople`；`NationalSpire.CommunityReply.NeedsReaction`；`NationalSpire.CommunityReply.ParentId`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`；输入表达式：`CommunityMentions.Resolve(data, reply.Body)`；返回值紧邻使用处：`AssignmentExpressionSyntax: reply.MentionedPeople = CommunityMentions.Resolve(data, reply.Body)`
- `NationalSpire.CommunityReply.CommunityReply()`；输入表达式：`new CommunityReply { AuthorId = "player", ParentId = parentId, Body = body.Trim(), Day = data.Day, NeedsReaction = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CommunityReply { AuthorId = "player", ParentId = parentId, Body = body.Trim(), Day = data.Day, NeedsReaction = true }`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(data).Contains`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`Remember(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: Remember(data, post);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(body)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(body)) throw new InvalidOperationException("请先填写回复内容。");`
- `string.Trim()`；输入表达式：`body.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Body = body.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Any(r => r.Id == parentId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !post.Replies.Any(r => r.Id == parentId)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`All(data).Contains(post)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !All(data).Contains(post)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`post.Replies.Add(reply)`；返回值紧邻使用处：`ExpressionStatementSyntax: post.Replies.Add(reply);`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("回复目标已不存在。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("回复目标已不存在。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先填写回复内容。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先填写回复内容。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("帖子已不存在。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("帖子已不存在。");`

**赋值（含属性/字段和局部值）：**

- `AuthorId` = `"player"`
- `Body` = `body.Trim()`
- `Day` = `data.Day`
- `NeedsReaction` = `true`
- `ParentId` = `parentId`
- `post.AiPending` = `false`
- `post.SeenRevision` = `post.Revision`
- `reply.MentionedPeople` = `CommunityMentions.Resolve(data, reply.Body)`

<a id="symbol-fb1ac30b1414"></a>

## `NationalSpire.CommunityThreads.MakeOfflineThreads(NationalSpire.CommunityPost) — public static void MakeOfflineThreads(CommunityPost post)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ParentId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(post.Id + i)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(post.Id + i) % 3`

**赋值（含属性/字段和局部值）：**

- `reply.Body` = `new[] { "接着这层说一句，", "看完上面的讨论，", "我也在关注这个，", "这事我想再补一句：" }[i % 4] + reply.Body`
- `reply.Day` = `post.Day`
- `reply.ParentId` = `post.Replies[i - 1].Id`

<a id="symbol-fd915269624a"></a>

## `NationalSpire.CommunityThreads.Position(NationalSpire.CommunityPost, NationalSpire.CommunityReply) — public static (int Floor, int Depth) Position(CommunityPost post, CommunityReply reply)`

来源：源码第 127 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityThreads.OfflineReactions(NationalSpire.CareerData, System.Collections.Generic.IReadOnlySet<string>)`](CommunityThreads.cs.md#symbol-6d730155cd69)

**调用：** `System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeWhile<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ParentId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`seen.Add(parent.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: root.ParentId.Length > 0 && post.Replies.FirstOrDefault(r => r.Id == root.ParentId) is { } parent && seen.Add(parent.Id)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string> { reply.Id }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string> { reply.Id }`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`post.Replies.Where(r => r.ParentId.Length == 0).TakeWhile(r => r.Id != root.Id).Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: post.Replies.Where(r => r.ParentId.Length == 0).TakeWhile(r => r.Id != root.Id).Count() + 1`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.FirstOrDefault(r => r.Id == root.ParentId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: post.Replies.FirstOrDefault(r => r.Id == root.ParentId) is { } parent`
- `System.Collections.Generic.IEnumerable<TSource>.TakeWhile<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => r.ParentId.Length == 0).TakeWhile(r => r.Id != root.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.ParentId.Length == 0).TakeWhile(r => r.Id != root.Id).Count`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => r.ParentId.Length == 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.ParentId.Length == 0).TakeWhile`

**赋值（含属性/字段和局部值）：**

- `root` = `parent`

<a id="symbol-7120f3e9af63"></a>

## `NationalSpire.CommunityThreads.ReadingOrder(NationalSpire.CommunityPost) — public static List<CommunityReply> ReadingOrder(CommunityPost post)`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityDiscussionLayout.Build(NationalSpire.CommunityPost, System.Collections.Generic.IReadOnlySet<string>)`](CommunityDiscussionLayout.cs.md#symbol-abc2f068bbc7)

**调用：** `System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.Stack<T>.Push(T)`；`System.Collections.Generic.Stack<T>.Stack(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.Stack<T>.TryPop(out T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ParentId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`seen.Add(r.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => seen.Add(r.Id)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`seen.Add(reply.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !seen.Add(reply.Id)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`children[""].Reverse()`；返回值紧邻使用处：`ArgumentSyntax: children[""].Reverse()`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`children[reply.Id].Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in children[reply.Id].Reverse()) stack.Push(child);`
- `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`post.Replies.ToLookup(r => r.ParentId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.ToLookup(r => r.ParentId)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => seen.Add(r.Id))`；返回值紧邻使用处：`ArgumentSyntax: post.Replies.Where(r => seen.Add(r.Id))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(reply)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(reply);`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`result.AddRange(post.Replies.Where(r => seen.Add(r.Id)))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AddRange(post.Replies.Where(r => seen.Add(r.Id)));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CommunityReply>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<CommunityReply>()`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`stack.Push(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: stack.Push(child);`
- `System.Collections.Generic.Stack<T>.Stack(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new Stack<CommunityReply>(children[""].Reverse())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Stack<CommunityReply>(children[""].Reverse())`
- `System.Collections.Generic.Stack<T>.TryPop(out T)`；输入表达式：`stack.TryPop(out var reply)`；返回值紧邻使用处：`WhileStatementSyntax: while (stack.TryPop(out var reply))          {              if (!seen.Add(reply.Id)) continue;              result.Add(reply);              foreach (var child in children[reply.Id].Reverse()) stack.Push(child);          }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a16197b41bab"></a>

## `NationalSpire.CommunityThreads.Audience(NationalSpire.CareerData, NationalSpire.CommunityPost) — public static List<CareerPerson> Audience(CareerData data, CommunityPost post)`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.DiscussionPeople(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Collections.Generic.ISet<string>)`](AiDiscussion.cs.md#symbol-02eb53d0adba)；[`NationalSpire.CommunityThreads.OfflineReactions(NationalSpire.CareerData, System.Collections.Generic.IReadOnlySet<string>)`](CommunityThreads.cs.md#symbol-6d730155cd69)

**调用：** [`NationalSpire.CareerNarrative.Audience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`](CareerNarrative.cs.md#symbol-34f9cbe529c8)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)；`NationalSpire.CareerMatch.CareerMatch()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerNarrative.Audience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.MatchKind`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMatch.CareerMatch()`；输入表达式：`new CareerMatch { Kind = post.MatchKind }`；返回值紧邻使用处：`ConditionalExpressionSyntax: post.MatchKind.Length == 0 ? null : new CareerMatch { Kind = post.MatchKind }`
- `NationalSpire.CareerNarrative.Audience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`；输入表达式：`CareerNarrative.Audience(data, post.EventKey, post.Category, match, related)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerNarrative.Audience(data, post.EventKey, post.Category, match, related).Where`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`IsHuman(data, p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsHuman(data, p.Id)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: IsHuman(data, post.AuthorId) ? new List<string> { post.AuthorId } : post.RelatedPeople`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SpireArbitration.Muted(p)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)              ?? (post.MatchKind.Length == 0 ? null : new CareerMatch { Kind = post.MatchKind })`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CareerNarrative.Audience(data, post.EventKey, post.Category, match, related).Where(p => !IsHuman(data, p.Id) && !SpireArbitration.Muted(p)).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return CareerNarrative.Audience(data, post.EventKey, post.Category, match, related).Where(p => !IsHuman(data, p.Id) && !SpireArbitration.Muted(p)).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CareerNarrative.Audience(data, post.EventKey, post.Category, match, related).Where(p => !IsHuman(data, p.Id) && !SpireArbitration.Muted(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerNarrative.Audience(data, post.EventKey, post.Category, match, related).Where(p => !IsHuman(data, p.Id) && !SpireArbitration.Muted(p)).ToList`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string> { post.AuthorId }`；返回值紧邻使用处：`ConditionalExpressionSyntax: IsHuman(data, post.AuthorId) ? new List<string> { post.AuthorId } : post.RelatedPeople`

**赋值（含属性/字段和局部值）：**

- `Kind` = `post.MatchKind`

<a id="symbol-6d730155cd69"></a>

## `NationalSpire.CommunityThreads.OfflineReactions(NationalSpire.CareerData, System.Collections.Generic.IReadOnlySet<string>) — public static void OfflineReactions(CareerData data, IReadOnlySet<string> requested)`

来源：源码第 156 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.Audience(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-a16197b41bab)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityThreads.Position(NationalSpire.CommunityPost, NationalSpire.CommunityReply)`](CommunityThreads.cs.md#symbol-fd915269624a)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)；`NationalSpire.CommunityReply.CommunityReply()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `(int Floor, int Depth).Floor`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Temperament`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.MentionedPeople`；`NationalSpire.CommunityPost.NeedsReaction`；`NationalSpire.CommunityPost.PersonalPost`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.MentionedPeople`；`NationalSpire.CommunityReply.NeedsReaction`；`NationalSpire.CommunityReply.ParentId`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.Audience(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.Position(NationalSpire.CommunityPost, NationalSpire.CommunityReply)`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Name(data)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(last.Id + p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerEngine.StableHash(last.Id + p.Id)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(last.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(last.Id) % 3`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(post.Id + p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerEngine.StableHash(post.Id + p.Id)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(post.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(post.Id) % 3`
- `NationalSpire.CommunityReply.CommunityReply()`；输入表达式：`new CommunityReply { AuthorId = person.Id, Day = data.Day,                          Body = new[] { "看到本人发帖了，先来留个位置。我也在这个赛区玩，平时主要看社区杯。", "楼主也逛这里啊。我刚结束自己的对局，过来看看大家在聊什么。", "来了，这边熟悉的名字越来越多了。" }[CareerEngine.StableHash(post.Id) % 3] }`；返回值紧邻使用处：`ArgumentSyntax: new CommunityReply { AuthorId = person.Id, Day = data.Day,                          Body = new[] { "看到本人发帖了，先来留个位置。我也在这个赛区玩，平时主要看社区杯。", "楼主也逛这里啊。我刚结束自己的对局，过来看看大家在聊什么。", "来了，这边熟悉的名字越来越多了。" }[CareerEngine.StableHash(post.Id) % 3] }`
- `NationalSpire.CommunityReply.CommunityReply()`；输入表达式：`new CommunityReply { AuthorId = person.Id, ParentId = last.Id, Day = data.Day, Body = body }`；返回值紧邻使用处：`ArgumentSyntax: new CommunityReply { AuthorId = person.Id, ParentId = last.Id, Day = data.Day, Body = body }`
- `NationalSpire.CommunityReply.CommunityReply()`；输入表达式：`new() { AuthorId = author, ParentId = id == post.Id ? "" : id, Day = data.Day, Body = "看到你叫我了，我过来看看。" }`；返回值紧邻使用处：`ArgumentSyntax: new() { AuthorId = author, ParentId = id == post.Id ? "" : id, Day = data.Day, Body = "看到你叫我了，我过来看看。" }`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All(data).ToList`
- `NationalSpire.CommunityThreads.Audience(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`Audience(data, post)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Audience(data, post)`
- `NationalSpire.CommunityThreads.Audience(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`Audience(data, post)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Audience(data, post).OrderBy`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`IsHuman(data, a)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsHuman(data, a)`
- `NationalSpire.CommunityThreads.Position(NationalSpire.CommunityPost, NationalSpire.CommunityReply)`；输入表达式：`Position(post, r)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Position(post, r).Floor`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`Remember(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: Remember(data, post);`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SpireArbitration.Muted(p)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`answered.Add((person.Id, post.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: answered.Add((person.Id, post.Id));`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`answered.Add((person.Id, r.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: answered.Add((person.Id, r.Id));`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`answered.Contains((author, id))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !answered.Contains((author, id))`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<(string Author, string Request)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<(string Author, string Request)>()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Any(p => p.Id == a && !SpireArbitration.Muted(p))`；返回值紧邻使用处：`BinaryExpressionSyntax: data.People.Any(p => p.Id == a && !SpireArbitration.Muted(p)) && !IsHuman(data, a)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`requests.Select(r => (r.Id, r.MentionedPeople)).Concat(root ? [(post.Id, post.MentionedPeople)] : [])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = requests.Select(r => (r.Id, r.MentionedPeople)).Concat(root ? [(post.Id, post.MentionedPeople)] : [])`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`audience.OrderBy(p => CareerEngine.StableHash(last.Id + p.Id)).FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: audience.FirstOrDefault(p => p.Id == target?.AuthorId)                      ?? audience.OrderBy(p => CareerEngine.StableHash(last.Id + p.Id)).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`Audience(data, post).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)).FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Audience(data, post).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`audience.FirstOrDefault(p => p.Id == target?.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: audience.FirstOrDefault(p => p.Id == target?.AuthorId)                      ?? audience.OrderBy(p => CareerEngine.StableHash(last.Id + p.Id)).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.FirstOrDefault(r => r.Id == last.ParentId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.FirstOrDefault(r => r.Id == last.ParentId)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`requests.GroupBy(r => Position(post, r).Floor)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var group in requests.GroupBy(r => Position(post, r).Floor))              {                  var last = group.Last();                  var target = post.Replies.FirstOrDefault(r => r.Id == last.ParentId);                  var audience = Audience(data, post);                  var person = audience.FirstOrDefault(p => p.Id == target?.AuthorId)                      ?? audience.OrderBy(p => CareerEngine.StableHash(last.Id + p.Id)).FirstOrDefault();                  if (person == null) continue;                  string name = CareerEngine.Name(data);                  string body = person.Temperament switch                  {                      "谨慎求证" => $"{name}这条我看了。我自己的成绩还不稳定，暂时不敢把打法讲得太满。",                      "热情直率" => $"{name}本人也来聊了！我平时就在这个区看比赛，没想到能在评论区碰见。",                      _ => new[] { "这层有意思，平时光顾着看战报，很少看到当事人来聊。", "看到了。我自己还经常在前面几层翻车，先听大家聊。", "刚翻到这里，前面的讨论也补看了。" }[CareerEngine.StableHash(last.Id) % 3]                  };                  post.Replies.Add(new CommunityReply { AuthorId = person.Id, ParentId = last.Id, Day = data.Day, Body = body });                  foreach (var r in group) { r.NeedsReaction = false; answered.Add((person.Id, r.Id)); }              }`
- `System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；输入表达式：`group.Last()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = group.Last()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`audience.OrderBy(p => CareerEngine.StableHash(last.Id + p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: audience.OrderBy(p => CareerEngine.StableHash(last.Id + p.Id)).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Audience(data, post).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Audience(data, post).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`requests.Select(r => (r.Id, r.MentionedPeople))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: requests.Select(r => (r.Id, r.MentionedPeople)).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`All(data).ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in All(data).ToList())          {              var requests = post.Replies.Where(r => r.NeedsReaction && requested.Contains(r.Id)).ToList();              bool root = (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost) && post.NeedsReaction && requested.Contains(post.Id);              if (requests.Count == 0 && !root) continue;              var answered = new HashSet<(string Author, string Request)>();              if (root)              {                  var person = Audience(data, post).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)).FirstOrDefault();                  if (person != null)                  {                      post.Replies.Add(new CommunityReply { AuthorId = person.Id, Day = data.Day,                          Body = new[] { "看到本人发帖了，先来留个位置。我也在这个赛区玩，平时主要看社区杯。", "楼主也逛这里啊。我刚结束自己的对局，过来看看大家在聊什么。", "来了，这边熟悉的名字越来越多了。" }[CareerEngine.StableHash(post.Id) % 3] });                      post.NeedsReaction = false;                      answered.Add((person.Id, post.Id));                  }              }              foreach (var group in requests.GroupBy(r => Position(post, r).Floor))              {                  var last = group.Last();                  var target = post.Replies.FirstOrDefault(r => r.Id == last.ParentId);                  var audience = Audience(data, post);                  var person = audience.FirstOrDefault(p => p.Id == target?.AuthorId)                      ?? audience.OrderBy(p => CareerEngine.StableHash(last.Id + p.Id)).FirstOrDefault();                  if (person == null) continue;                  string name = CareerEngine.Name(data);                  string body = person.Temperament switch                  {                      "谨慎求证" => $"{name}这条我看了。我自己的成绩还不稳定，暂时不敢把打法讲得太满。",                      "热情直率" => $"{name}本人也来聊了！我平时就在这个区看比赛，没想到能在评论区碰见。",                      _ => new[] { "这层有意思，平时光顾着看战报，很少看到当事人来聊。", "看到了。我自己还经常在前面几层翻车，先听大家聊。", "刚翻到这里，前面的讨论也补看了。" }[CareerEngine.StableHash(last.Id) % 3]                  };                  post.Replies.Add(new CommunityReply { AuthorId = person.Id, ParentId = last.Id, Day = data.Day, Body = body });                  foreach (var r in group) { r.NeedsReaction = false; answered.Add((person.Id, r.Id)); }              }              var mentionRequests = requests.Select(r => (r.Id, r.MentionedPeople)).Concat(root ? [(post.Id, post.MentionedPeople)] : []);              foreach (var (id, authors) in mentionRequests)                  foreach (string author in authors.Where(a => data.People.Any(p => p.Id == a && !SpireArbitration.Muted(p)) && !IsHuman(data, a)))                      if (!answered.Contains((author, id)))                          post.Replies.Add(new() { AuthorId = author, ParentId = id == post.Id ? "" : id, Day = data.Day, Body = "看到你叫我了，我过来看看。" });              post.Revision++; Remember(data, post);          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`post.Replies.Where(r => r.NeedsReaction && requested.Contains(r.Id)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.Where(r => r.NeedsReaction && requested.Contains(r.Id)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`authors.Where(a => data.People.Any(p => p.Id == a && !SpireArbitration.Muted(p)) && !IsHuman(data, a))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string author in authors.Where(a => data.People.Any(p => p.Id == a && !SpireArbitration.Muted(p)) && !IsHuman(data, a)))                      if (!answered.Contains((author, id)))                          post.Replies.Add(new() { AuthorId = author, ParentId = id == post.Id ? "" : id, Day = data.Day, Body = "看到你叫我了，我过来看看。" });`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => r.NeedsReaction && requested.Contains(r.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.NeedsReaction && requested.Contains(r.Id)).ToList`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`requested.Contains(post.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost) && post.NeedsReaction && requested.Contains(post.Id)`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`requested.Contains(r.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: r.NeedsReaction && requested.Contains(r.Id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`post.Replies.Add(new CommunityReply { AuthorId = person.Id, Day = data.Day,                          Body = new[] { "看到本人发帖了，先来留个位置。我也在这个赛区玩，平时主要看社区杯。", "楼主也逛这里啊。我刚结束自己的对局，过来看看大家在聊什么。", "来了，这边熟悉的名字越来越多了。" }[CareerEngine.StableHash(post.Id) % 3] })`；返回值紧邻使用处：`ExpressionStatementSyntax: post.Replies.Add(new CommunityReply { AuthorId = person.Id, Day = data.Day,                          Body = new[] { "看到本人发帖了，先来留个位置。我也在这个赛区玩，平时主要看社区杯。", "楼主也逛这里啊。我刚结束自己的对局，过来看看大家在聊什么。", "来了，这边熟悉的名字越来越多了。" }[CareerEngine.StableHash(post.Id) % 3] });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`post.Replies.Add(new CommunityReply { AuthorId = person.Id, ParentId = last.Id, Day = data.Day, Body = body })`；返回值紧邻使用处：`ExpressionStatementSyntax: post.Replies.Add(new CommunityReply { AuthorId = person.Id, ParentId = last.Id, Day = data.Day, Body = body });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`post.Replies.Add(new() { AuthorId = author, ParentId = id == post.Id ? "" : id, Day = data.Day, Body = "看到你叫我了，我过来看看。" })`；返回值紧邻使用处：`ExpressionStatementSyntax: post.Replies.Add(new() { AuthorId = author, ParentId = id == post.Id ? "" : id, Day = data.Day, Body = "看到你叫我了，我过来看看。" });`

**赋值（含属性/字段和局部值）：**

- `AuthorId` = `author`
- `AuthorId` = `person.Id`
- `Body` = `"看到你叫我了，我过来看看。"`
- `Body` = `body`
- `Body` = `new[] { "看到本人发帖了，先来留个位置。我也在这个赛区玩，平时主要看社区杯。", "楼主也逛这里啊。我刚结束自己的对局，过来看看大家在聊什么。", "来了，这边熟悉的名字越来越多了。" }[CareerEngine.StableHash(post.Id) % 3]`
- `Day` = `data.Day`
- `ParentId` = `id == post.Id ? "" : id`
- `ParentId` = `last.Id`
- `post.NeedsReaction` = `false`
- `r.NeedsReaction` = `false`

<a id="symbol-0da035a7b345"></a>

## `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost) — public static void Remember(CareerData data, CommunityPost post)`

来源：源码第 201 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyDiscussionCore(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, NationalSpire.AiService.DiscussionPermission>)`](AiDiscussion.cs.md#symbol-6abdfac46f41)；[`NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string)`](AiService.cs.md#symbol-5cb9c2055e1c)；[`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)；[`NationalSpire.CareerEngine.CreateNew(bool, int)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CommunityThreads.Normalize(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-95e97a5c9007)；[`NationalSpire.CommunityThreads.OfflineReactions(NationalSpire.CareerData, System.Collections.Generic.IReadOnlySet<string>)`](CommunityThreads.cs.md#symbol-6d730155cd69)；[`NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string)`](CommunityThreads.cs.md#symbol-d9b68d9a8f52)；[`NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string)`](CommunityThreads.cs.md#symbol-4de765d004ff)；[`NationalSpire.CommunityThreads.TrimFeed(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-460bb0bb6649)；[`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`](Coop/CoopAi.cs.md#symbol-b31e3ccef31a)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](Coop/CoopAi.cs.md#symbol-b4b98ce85f62)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](Coop/CoopRules.cs.md#symbol-926ebe8770ca)；[`NationalSpire.PrivateProfileChanges.Publish(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateProfileChanges.cs.md#symbol-930916e1d31b)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CommunityMentions.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityMentions.cs.md#symbol-1948490083a8)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；[`NationalSpire.CommunityVotes.Update(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-324728201fc4)；[`Put(NationalSpire.CommunityMemory)`](CommunityThreads.cs.md#symbol-490c20b53f98)；`NationalSpire.CommunityMemory.CommunityMemory()`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.State`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CommunityMemory.AiText`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityMentions.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityPost.AiSourceBody`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.PersonalPost`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityPost.SourceTitle`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityVotes.Update(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`Put(NationalSpire.CommunityMemory)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, post.AuthorId) + "发帖："`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, post.AuthorId) + "发帖《"`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, r.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, r.AuthorId) + "："`
- `NationalSpire.CommunityMemory.CommunityMemory()`；输入表达式：`new CommunityMemory { Id = post.Id + ":" + r.Id, PostId = post.Id, Day = r.Day, Kind = "opinion", People = [r.AuthorId], Text = CareerEngine.DisplayName(data, r.AuthorId) + "：" + r.Body }`；返回值紧邻使用处：`ArgumentSyntax: new CommunityMemory { Id = post.Id + ":" + r.Id, PostId = post.Id, Day = r.Day, Kind = "opinion", People = [r.AuthorId], Text = CareerEngine.DisplayName(data, r.AuthorId) + "：" + r.Body }`
- `NationalSpire.CommunityMemory.CommunityMemory()`；输入表达式：`new CommunityMemory { Id = post.Id + ":editorial", PostId = post.Id, Day = post.Day, Kind = "opinion", People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList(),                  Text = CareerEngine.DisplayName(data, post.AuthorId) + "发帖《" + post.Title + "》：" + post.Body }`；返回值紧邻使用处：`ArgumentSyntax: new CommunityMemory { Id = post.Id + ":editorial", PostId = post.Id, Day = post.Day, Kind = "opinion", People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList(),                  Text = CareerEngine.DisplayName(data, post.AuthorId) + "发帖《" + post.Title + "》：" + post.Body }`
- `NationalSpire.CommunityMemory.CommunityMemory()`；输入表达式：`new CommunityMemory { Id = post.Id + ":fact", PostId = post.Id, Day = post.Day, Kind = CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? "opinion" : "fact", People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList(),              Text = (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? CareerEngine.DisplayName(data, post.AuthorId) + "发帖：" : "") + (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + (post.SourceBody.Length > 0 ? post.SourceBody : post.Body),              AiText = post.AiSourceBody == null ? null : (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + post.AiSourceBody }`；返回值紧邻使用处：`ArgumentSyntax: new CommunityMemory { Id = post.Id + ":fact", PostId = post.Id, Day = post.Day, Kind = CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? "opinion" : "fact", People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList(),              Text = (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? CareerEngine.DisplayName(data, post.AuthorId) + "发帖：" : "") + (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + (post.SourceBody.Length > 0 ? post.SourceBody : post.Body),              AiText = post.AiSourceBody == null ? null : (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + post.AiSourceBody }`
- `NationalSpire.CommunityMentions.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityMentions.Remember(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityMentions.Remember(data, post);`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`NewsPending(data, post)`；返回值紧邻使用处：`IfStatementSyntax: if (NewsPending(data, post))          { data.CommunityMemories.RemoveAll(m => m.PostId == post.Id && m.Kind == "opinion"); return; }`
- `NationalSpire.CommunityVotes.Update(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityVotes.Update(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityVotes.Update(data, post);`
- `Put(NationalSpire.CommunityMemory)`；输入表达式：`Put(new CommunityMemory { Id = post.Id + ":" + r.Id, PostId = post.Id, Day = r.Day, Kind = "opinion", People = [r.AuthorId], Text = CareerEngine.DisplayName(data, r.AuthorId) + "：" + r.Body })`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(new CommunityMemory { Id = post.Id + ":" + r.Id, PostId = post.Id, Day = r.Day, Kind = "opinion", People = [r.AuthorId], Text = CareerEngine.DisplayName(data, r.AuthorId) + "：" + r.Body });`
- `Put(NationalSpire.CommunityMemory)`；输入表达式：`Put(new CommunityMemory { Id = post.Id + ":editorial", PostId = post.Id, Day = post.Day, Kind = "opinion", People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList(),                  Text = CareerEngine.DisplayName(data, post.AuthorId) + "发帖《" + post.Title + "》：" + post.Body })`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(new CommunityMemory { Id = post.Id + ":editorial", PostId = post.Id, Day = post.Day, Kind = "opinion", People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList(),                  Text = CareerEngine.DisplayName(data, post.AuthorId) + "发帖《" + post.Title + "》：" + post.Body });`
- `Put(NationalSpire.CommunityMemory)`；输入表达式：`Put(new CommunityMemory { Id = post.Id + ":fact", PostId = post.Id, Day = post.Day, Kind = CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? "opinion" : "fact", People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList(),              Text = (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? CareerEngine.DisplayName(data, post.AuthorId) + "发帖：" : "") + (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + (post.SourceBody.Length > 0 ? post.SourceBody : post.Body),              AiText = post.AiSourceBody == null ? null : (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + post.AiSourceBody })`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(new CommunityMemory { Id = post.Id + ":fact", PostId = post.Id, Day = post.Day, Kind = CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? "opinion" : "fact", People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList(),              Text = (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? CareerEngine.DisplayName(data, post.AuthorId) + "发帖：" : "") + (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + (post.SourceBody.Length > 0 ? post.SourceBody : post.Body),              AiText = post.AiSourceBody == null ? null : (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + post.AiSourceBody });`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`post.RelatedPeople.Append(post.AuthorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.RelatedPeople.Append(post.AuthorId).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`post.RelatedPeople.Append(post.AuthorId).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.RelatedPeople.Append(post.AuthorId).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`post.Replies.TakeLast(12)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var r in post.Replies.TakeLast(12))              Put(new CommunityMemory { Id = post.Id + ":" + r.Id, PostId = post.Id, Day = r.Day, Kind = "opinion", People = [r.AuthorId], Text = CareerEngine.DisplayName(data, r.AuthorId) + "：" + r.Body });`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`post.RelatedPeople.Append(post.AuthorId).Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList()`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`data.CommunityMemories.RemoveAll(m => m.PostId == post.Id && m.Kind == "opinion")`；返回值紧邻使用处：`ExpressionStatementSyntax: data.CommunityMemories.RemoveAll(m => m.PostId == post.Id && m.Kind == "opinion");`

**赋值（含属性/字段和局部值）：**

- `AiText` = `post.AiSourceBody == null ? null : (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + post.AiSourceBody`
- `Day` = `post.Day`
- `Day` = `r.Day`
- `Id` = `post.Id + ":" + r.Id`
- `Id` = `post.Id + ":editorial"`
- `Id` = `post.Id + ":fact"`
- `Kind` = `"opinion"`
- `Kind` = `CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? "opinion" : "fact"`
- `People` = `[r.AuthorId]`
- `People` = `post.RelatedPeople.Append(post.AuthorId).Distinct().ToList()`
- `PostId` = `post.Id`
- `Text` = `(CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? CareerEngine.DisplayName(data, post.AuthorId) + "发帖：" : "") + (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + (post.SourceBody.Length > 0 ? post.SourceBody : post.Body)`
- `Text` = `CareerEngine.DisplayName(data, post.AuthorId) + "发帖《" + post.Title + "》：" + post.Body`
- `Text` = `CareerEngine.DisplayName(data, r.AuthorId) + "：" + r.Body`

<a id="symbol-490c20b53f98"></a>

## `Put(NationalSpire.CommunityMemory) — void Put(CommunityMemory memory)`

来源：源码第 205 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)

**调用：** `System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CommunityMemory.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`data.CommunityMemories.Add(memory)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.CommunityMemories.Add(memory);`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`data.CommunityMemories.FindIndex(m => m.Id == memory.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.CommunityMemories.FindIndex(m => m.Id == memory.Id)`

**赋值（含属性/字段和局部值）：**

- `data.CommunityMemories[i]` = `memory`

<a id="symbol-fe6de6f8dd52"></a>

## `NationalSpire.CommunityThreads.RememberMatch(NationalSpire.CareerData, NationalSpire.CareerResult) — public static void RememberMatch(CareerData data, CareerResult result)`

来源：源码第 221 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)

**调用：** [`NationalSpire.AiGeneratedText.Different(string, string)`](AiGeneratedText.cs.md#symbol-8a7bdafb8195)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CharacterIdentity.ForResult(NationalSpire.CareerResult)`](CharacterIdentity.cs.md#symbol-6c3ca5d0abad)；[`NationalSpire.MatchRules.ChallengeNote(NationalSpire.CareerResult, bool)`](MatchRules.cs.md#symbol-ac72157cbb56)；[`NationalSpire.MatchRules.Performance(bool, int, double?)`](MatchRules.cs.md#symbol-b38635e79223)；[`NationalSpire.RunEvidence.Summary()`](RunEvidence.cs.md#symbol-d852a24404b2)；`NationalSpire.CommunityMemory.CommunityMemory()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiGeneratedText.Different(string, string)`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.Character`；`NationalSpire.CareerResult.Day`；`NationalSpire.CareerResult.DeckSummary`；`NationalSpire.CareerResult.Event`；`NationalSpire.CareerResult.Evidence`；`NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.Opponent`；`NationalSpire.CareerResult.OpponentId`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerResult.RatingDelta`；`NationalSpire.CareerResult.RunSeconds`；`NationalSpire.CareerResult.Win`；`NationalSpire.CareerResult.WorldImpact`；`NationalSpire.CharacterIdentity.ForResult(NationalSpire.CareerResult)`；`NationalSpire.CommunityMemory.AiText`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.Id`；`NationalSpire.MatchRules.ChallengeNote(NationalSpire.CareerResult, bool)`；`NationalSpire.MatchRules.Performance(bool, int, double?)`；`NationalSpire.RunEvidence.Summary()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiGeneratedText.Different(string, string)`；输入表达式：`AiGeneratedText.Different(original, beginning + CharacterIdentity.ForResult(result) + ending)`；返回值紧邻使用处：`AssignmentExpressionSyntax: AiText = AiGeneratedText.Different(original, beginning + CharacterIdentity.ForResult(result) + ending)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(data)}`
- `NationalSpire.CharacterIdentity.ForResult(NationalSpire.CareerResult)`；输入表达式：`CharacterIdentity.ForResult(result)`；返回值紧邻使用处：`BinaryExpressionSyntax: beginning + CharacterIdentity.ForResult(result)`
- `NationalSpire.CommunityMemory.CommunityMemory()`；输入表达式：`new CommunityMemory { Id = id, PostId = post.Id, Day = result.Day,              People = ["player", result.OpponentId], Text = original,              AiText = AiGeneratedText.Different(original, beginning + CharacterIdentity.ForResult(result) + ending) }`；返回值紧邻使用处：`ArgumentSyntax: new CommunityMemory { Id = id, PostId = post.Id, Day = result.Day,              People = ["player", result.OpponentId], Text = original,              AiText = AiGeneratedText.Different(original, beginning + CharacterIdentity.ForResult(result) + ending) }`
- `NationalSpire.MatchRules.ChallengeNote(NationalSpire.CareerResult, bool)`；输入表达式：`MatchRules.ChallengeNote(result, data.CooperativeMembers > 1)`；返回值紧邻使用处：`BinaryExpressionSyntax: $"对阵{result.Opponent}。赛事进阶 {result.Ascension}，{result.Outcome}；{MatchRules.Performance(result.Win, result.Floor, result.RunSeconds)}；评分变化 {result.RatingDelta:+0;-0;0}。" + MatchRules.ChallengeNote(result, data.CooperativeMembers > 1)`
- `NationalSpire.MatchRules.Performance(bool, int, double?)`；输入表达式：`MatchRules.Performance(result.Win, result.Floor, result.RunSeconds)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.Performance(result.Win, result.Floor, result.RunSeconds)}`
- `NationalSpire.RunEvidence.Summary()`；输入表达式：`result.Evidence.Summary()`；返回值紧邻使用处：`BinaryExpressionSyntax: $"对阵{result.Opponent}。赛事进阶 {result.Ascension}，{result.Outcome}；{MatchRules.Performance(result.Win, result.Floor, result.RunSeconds)}；评分变化 {result.RatingDelta:+0;-0;0}。" + MatchRules.ChallengeNote(result, data.CooperativeMembers > 1) + "卡组：" + string.Join("，", result.DeckSummary) + "。" + result.Evidence.Summary()`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("，", result.DeckSummary)`；返回值紧邻使用处：`BinaryExpressionSyntax: $"对阵{result.Opponent}。赛事进阶 {result.Ascension}，{result.Outcome}；{MatchRules.Performance(result.Win, result.Floor, result.RunSeconds)}；评分变化 {result.RatingDelta:+0;-0;0}。" + MatchRules.ChallengeNote(result, data.CooperativeMembers > 1) + "卡组：" + string.Join("，", result.DeckSummary)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.CommunityMemories.Any(m => m.Id == id)`；返回值紧邻使用处：`IfStatementSyntax: if (data.CommunityMemories.Any(m => m.Id == id)) return;`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Posts.FirstOrDefault(p => p.EventKey == "match" + result.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Posts.FirstOrDefault(p => p.EventKey == "match" + result.MatchId)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`data.CommunityMemories.Add(new CommunityMemory { Id = id, PostId = post.Id, Day = result.Day,              People = ["player", result.OpponentId], Text = original,              AiText = AiGeneratedText.Different(original, beginning + CharacterIdentity.ForResult(result) + ending) })`；返回值紧邻使用处：`ExpressionStatementSyntax: data.CommunityMemories.Add(new CommunityMemory { Id = id, PostId = post.Id, Day = result.Day,              People = ["player", result.OpponentId], Text = original,              AiText = AiGeneratedText.Different(original, beginning + CharacterIdentity.ForResult(result) + ending) });`

**赋值（含属性/字段和局部值）：**

- `AiText` = `AiGeneratedText.Different(original, beginning + CharacterIdentity.ForResult(result) + ending)`
- `Day` = `result.Day`
- `Id` = `id`
- `People` = `["player", result.OpponentId]`
- `PostId` = `post.Id`
- `Text` = `original`

<a id="symbol-460bb0bb6649"></a>

## `NationalSpire.CommunityThreads.TrimFeed(NationalSpire.CareerData) — public static void TrimFeed(CareerData data)`

来源：源码第 234 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string)`](CommunityThreads.cs.md#symbol-d9b68d9a8f52)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.PrivateProfileChanges.Publish(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateProfileChanges.cs.md#symbol-930916e1d31b)

**调用：** [`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveRange(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.PersonalPost`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: post.PersonalPost || CommunityThreads.IsHuman(data, post.AuthorId)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, r.AuthorId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => CommunityThreads.IsHuman(data, r.AuthorId)`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`Remember(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: Remember(data, post);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.SavedThreads.Any(p => p.Id == post.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.SavedThreads.Any(p => p.Id == post.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))`；返回值紧邻使用处：`BinaryExpressionSyntax: post.PersonalPost || CommunityThreads.IsHuman(data, post.AuthorId) || post.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`data.Posts.Skip(120)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Posts.Skip(120).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.Posts.Skip(120).ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in data.Posts.Skip(120).ToList())          {              Remember(data, post);              // 玩家参与过的完整讨论永久保留，避免队列及楼中楼引用悬空。              if ((post.PersonalPost || CommunityThreads.IsHuman(data, post.AuthorId) || post.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))) && !data.SavedThreads.Any(p => p.Id == post.Id)) data.SavedThreads.Add(post);          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`data.SavedThreads.Add(post)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.SavedThreads.Add(post);`
- `System.Collections.Generic.List<T>.RemoveRange(int, int)`；输入表达式：`data.Posts.RemoveRange(120, data.Posts.Count - 120)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Posts.RemoveRange(120, data.Posts.Count - 120);`

**赋值（含属性/字段和局部值）：**
