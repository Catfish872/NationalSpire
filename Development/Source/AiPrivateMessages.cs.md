# AiPrivateMessages.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A5F31DDB9A92ECD5D4D9638C8E4E4A582C931928B1EBDE65DD357840E7DD82CE`。来源：[源码](../../AiPrivateMessages.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiService`。

字段、事件及初始值（源码原样）：

```csharp
internal static Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> PrivateTransport =
        (request, token) => Client!.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, token);
private static readonly Dictionary<string, CancellationTokenSource> PrivateRequests = [];
private static readonly HashSet<string> PrivateSummaries = [];
private static readonly AiRequestQueue PrivateForegroundQueue = new();
private static readonly SemaphoreSlim PrivateSummaryQueue = new(1, 1);
public static readonly Dictionary<string, (string Turn, string Text)> PrivateLive = [];
public static readonly Dictionary<string, (string Turn, string Text)> PrivateReasoningLive = [];
public static readonly Dictionary<string, (string Turn, List<DateSceneLine> Lines)> PrivateSceneLive = [];
```

<a id="symbol-97ba03595bc3"></a>

## `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string) — public static string PrivateKey(CareerData data, string person)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-14a6fc19e1c1)；[`NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-57be9d2323cb)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-14a6fc19e1c1"></a>

## `NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string) — public static void CancelPrivate(CareerData data, string person)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-97ba03595bc3)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Threading.CancellationTokenSource.Cancel()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.PrivateRequests`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`PrivateKey(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PrivateKey(data, person)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`PrivateRequests.TryGetValue(PrivateKey(data, person), out var cancel)`；返回值紧邻使用处：`IfStatementSyntax: if (PrivateRequests.TryGetValue(PrivateKey(data, person), out var cancel)) cancel.Cancel();`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`cancel.Cancel()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.Cancel();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-57be9d2323cb"></a>

## `NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string) — public static bool PrivateBusy(CareerData data, string person)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-97ba03595bc3)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.PrivateRequests`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`PrivateKey(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PrivateKey(data, person)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`PrivateRequests.ContainsKey(PrivateKey(data, person))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateRequests.ContainsKey(PrivateKey(data, person))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-88f72cb1c19e"></a>

## `NationalSpire.AiService.SummarizePrivateManually(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string) — public static Task SummarizePrivateManually(Func<CareerData?> current, Action<CareerData> save, string person)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`](Coop/CoopPrivateMessages.cs.md#symbol-ebc3f29b5eb6)

**调用：** [`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`；输入表达式：`SummarizePrivateAsync(current, save, person)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => SummarizePrivateAsync(current, save, person)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-935c714481c1"></a>

## `NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?) — public static async Task ProcessPrivateAsync(Func<CareerData?> current, Action<CareerData> save, string person,          Action<string, string>? progress = null)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`](Coop/CoopPrivateMessages.cs.md#symbol-ebc3f29b5eb6)；[`NationalSpire.ProactiveChats.StartQueued(NationalSpire.CareerData)`](ProactiveChats.cs.md#symbol-67e715945068)

**调用：** [`NationalSpire.AiRequestQueue.Configure(int)`](AiRequestQueue.cs.md#symbol-7bf81d36c27d)；[`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`](AiPrivateMessages.cs.md#symbol-d73b189170eb)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-97ba03595bc3)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)；[`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-00bcca1f004c)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-c362351c7a43)；[`NationalSpire.PrivateMessageCommands.RestoreInterrupted(NationalSpire.PrivateTurn, string)`](PrivateMessageCommands.cs.md#symbol-82b01f18fa69)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateStreamParser.Finish()`](PrivateMessages.cs.md#symbol-90306db26d5a)；[`NationalSpire.PrivateStreamParser.PrivateStreamParser(params string[])`](PrivateMessages.cs.md#symbol-af0a0ba2ac6c)；[`NationalSpire.ProactiveChats.CountReplies(NationalSpire.PrivateConversation)`](ProactiveChats.cs.md#symbol-3222decf7fd6)；[`NationalSpire.SpireArbitration.Complete(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, NationalSpire.ArbitrationDecision)`](SpireArbitration.cs.md#symbol-7bc24f64a697)；[`NationalSpire.SpireArbitration.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](SpireArbitration.cs.md#symbol-6116255f39e7)；[`NationalSpire.SpireArbitration.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](SpireArbitration.cs.md#symbol-b1beb5c71e60)；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)；[`NationalSpire.SpireArbitration.Parse(string)`](SpireArbitration.cs.md#symbol-79b7629027ea)；[`Notify(string)`](AiPrivateMessages.cs.md#symbol-1138954c6e9e)；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.List()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(long, long)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`；`System.Threading.CancellationTokenSource.CancellationTokenSource(System.TimeSpan)`；`System.TimeSpan.FromMinutes(long)`

**字段、属性、事件及方法组引用：** `(string Turn, string Text).Text`；`<anonymous type: string person, string turnId, string error>.error`；`NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.MaxConcurrentRequests`；`NationalSpire.AiOptions.RequestTimeoutMinutes`；`NationalSpire.AiRequestQueue.Configure(int)`；`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.PrivateForegroundQueue`；`NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.PrivateLive`；`NationalSpire.AiService.PrivateReasoningLive`；`NationalSpire.AiService.PrivateRequests`；`NationalSpire.AiService.PrivateSceneLive`；`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.LastReplyOrder`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessageCommands.RestoreInterrupted(NationalSpire.PrivateTurn, string)`；`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`；`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`；`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateStreamParser.Directives`；`NationalSpire.PrivateStreamParser.Error`；`NationalSpire.PrivateStreamParser.Finish()`；`NationalSpire.PrivateStreamParser.Text`；`NationalSpire.PrivateTurn.Context`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.PreviousReasoning`；`NationalSpire.PrivateTurn.PreviousReply`；`NationalSpire.PrivateTurn.Reasoning`；`NationalSpire.PrivateTurn.Regenerating`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyOrder`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.SceneLines`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.ProactiveChats.CountReplies(NationalSpire.PrivateConversation)`；`NationalSpire.SpireArbitration.Complete(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, NationalSpire.ArbitrationDecision)`；`NationalSpire.SpireArbitration.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`；`NationalSpire.SpireArbitration.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；`NationalSpire.SpireArbitration.Parse(string)`；`Notify(string)`；`Progress(string)`；`Thinking(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.Configure(int)`；输入表达式：`PrivateForegroundQueue.Configure(data.Ai.MaxConcurrentRequests)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateForegroundQueue.Configure(data.Ai.MaxConcurrentRequests);`
- `NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`；输入表达式：`EnterPrivateQueue(data, key, cancel.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await EnterPrivateQueue(data, key, cancel.Token)`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: error = FailureReason(e)`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`ConditionalExpressionSyntax: e is OperationCanceledException ? "生成已停止或超时，可以重试。" : FailureReason(e)`
- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`PrivateKey(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateKey(data, person) != key`
- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`PrivateKey(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateKey(data, person) == key`
- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`PrivateKey(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateKey(data, person)`
- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`PrivateKey(latest, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateKey(latest, person) == key`
- `NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；输入表达式：`RequestPrivateAsync(data.Ai, messages, true, Progress, cancel.Token, Thinking, "private/" + key + "/" + turnId)`；返回值紧邻使用处：`AwaitExpressionSyntax: await RequestPrivateAsync(data.Ai, messages, true, Progress, cancel.Token, Thinking, "private/" + key + "/" + turnId)`
- `NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；输入表达式：`RequestPrivateAsync(data.Ai, SpireArbitration.Compose(data, conversation, turn), false, null, cancel.Token, chunk => record.Append(chunk), "private/" + key + "/" + turnId, task: "arbitration")`；返回值紧邻使用处：`AwaitExpressionSyntax: await RequestPrivateAsync(data.Ai, SpireArbitration.Compose(data, conversation, turn), false, null, cancel.Token, chunk => record.Append(chunk), "private/" + key + "/" + turnId, task: "arbitration")`
- `NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`；输入表达式：`SummarizePrivateAsync(current, save, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = SummarizePrivateAsync(current, save, person)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, person)!`
- `NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`；输入表达式：`DateScenes.TaggedLines(parser, turn.Scene)`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.SceneLines = DateScenes.TaggedLines(parser, turn.Scene)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("private.failed", new { person, turnId, error = FailureReason(e) })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("private.failed", new { person, turnId, error = FailureReason(e) });`
- `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；输入表达式：`GroupChats.NextOrder(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.ReplyOrder = GroupChats.NextOrder(data)`
- `NationalSpire.PrivateMessageCommands.RestoreInterrupted(NationalSpire.PrivateTurn, string)`；输入表达式：`PrivateMessageCommands.RestoreInterrupted(failed, e is OperationCanceledException ? "生成已停止或超时，可以重试。" : FailureReason(e))`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessageCommands.RestoreInterrupted(failed, e is OperationCanceledException ? "生成已停止或超时，可以重试。" : FailureReason(e));`
- `NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`；输入表达式：`PrivateMessagePrompts.Compose(data, conversation, turn, turn.Context, contextSpans)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessagePrompts.Compose(data, conversation, turn, turn.Context, contextSpans)`
- `NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`；输入表达式：`PrivateMessagePrompts.Context(data, conversation, turn, contextSpans)`；返回值紧邻使用处：`ConditionalExpressionSyntax: turn.RequestKind == "arbitration" ? SpireArbitration.Context(data, conversation, turn)                  : PrivateMessagePrompts.Context(data, conversation, turn, contextSpans)`
- `NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`；输入表达式：`PrivateMessages.Apply(data, conversation, turn, parser.Directives, originalFavour)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.Apply(data, conversation, turn, parser.Directives, originalFavour);`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: data != null && PrivateKey(data, person) == key && PrivateMessages.CanChat(data, person)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, person)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(latest, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: resolve() is { } latest && PrivateMessages.CanChat(latest, person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: conversation = PrivateMessages.Conversation(data, person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, person).Turns`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(data, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: originalFavour = PrivateMessages.Favour(data, person)`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Favour(data, person)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `NationalSpire.PrivateStreamParser.Finish()`；输入表达式：`parser.Finish()`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.Finish();`
- `NationalSpire.PrivateStreamParser.PrivateStreamParser(params string[])`；输入表达式：`new PrivateStreamParser()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateStreamParser()`
- `NationalSpire.ProactiveChats.CountReplies(NationalSpire.PrivateConversation)`；输入表达式：`ProactiveChats.CountReplies(conversation)`；返回值紧邻使用处：`ExpressionStatementSyntax: ProactiveChats.CountReplies(conversation);`
- `NationalSpire.SpireArbitration.Complete(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, NationalSpire.ArbitrationDecision)`；输入表达式：`SpireArbitration.Complete(data, conversation, turn, decision)`；返回值紧邻使用处：`ExpressionStatementSyntax: SpireArbitration.Complete(data, conversation, turn, decision);`
- `NationalSpire.SpireArbitration.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`；输入表达式：`SpireArbitration.Compose(data, conversation, turn)`；返回值紧邻使用处：`ArgumentSyntax: SpireArbitration.Compose(data, conversation, turn)`
- `NationalSpire.SpireArbitration.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`；输入表达式：`SpireArbitration.Context(data, conversation, turn)`；返回值紧邻使用处：`ConditionalExpressionSyntax: turn.RequestKind == "arbitration" ? SpireArbitration.Context(data, conversation, turn)                  : PrivateMessagePrompts.Context(data, conversation, turn, contextSpans)`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(CareerEngine.Person(data, person)!)`；返回值紧邻使用处：`BinaryExpressionSyntax: turn.RequestKind != "arbitration" && SpireArbitration.Muted(CareerEngine.Person(data, person)!)`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(CareerEngine.Person(data, person)!)`；返回值紧邻使用处：`IfStatementSyntax: if (SpireArbitration.Muted(CareerEngine.Person(data, person)!)) throw new InvalidOperationException("该角色账号已封禁，普通私信已停止。");`
- `NationalSpire.SpireArbitration.Parse(string)`；输入表达式：`SpireArbitration.Parse(response)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SpireArbitration.Parse(response)`
- `Notify(string)`；输入表达式：`Notify(turn.Reply)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notify(turn.Reply);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(parser.Text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(parser.Text)) throw new InvalidDataException("私信回复为空。");`
- `string.Trim()`；输入表达式：`parser.Text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Reply = parser.Text.Trim()`
- `System.Action<T>.Invoke(T)`；输入表达式：`save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: save(data);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`PrivateRequests.ContainsKey(key)`；返回值紧邻使用处：`IfStatementSyntax: if (PrivateRequests.ContainsKey(key)) return;`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`PrivateLive.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateLive.Remove(key);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`PrivateReasoningLive.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateReasoningLive.Remove(key);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`PrivateRequests.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateRequests.Remove(key);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`PrivateSceneLive.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateSceneLive.Remove(key);`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.First(t => t.Id == turnId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn = conversation.Turns.First(t => t.Id == turnId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.FirstOrDefault(t => t.Status == "queued")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Turns.FirstOrDefault(t => t.Status == "queued")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(data, person).Turns.FirstOrDefault(t => t.Id == turnId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person).Turns.FirstOrDefault(t => t.Id == turnId)`
- `System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, long>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.Max(x => x.LastReplyOrder)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.Max(x => x.LastReplyOrder) + 1`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateLive.GetValueOrDefault(key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateLive.GetValueOrDefault(key).Text`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateReasoningLive.GetValueOrDefault(key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateReasoningLive.GetValueOrDefault(key).Text`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<PrivateMessagePrompts.ContextSpan>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<PrivateMessagePrompts.ContextSpan>()`
- `System.Func<TResult>.Invoke()`；输入表达式：`current()`；返回值紧邻使用处：`AssignmentExpressionSyntax: data = current()`
- `System.Func<TResult>.Invoke()`；输入表达式：`current()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = current()`
- `System.Func<TResult>.Invoke()`；输入表达式：`resolve()`；返回值紧邻使用处：`IsPatternExpressionSyntax: resolve() is { } latest`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("该角色账号已封禁，普通私信已停止。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("该角色账号已封禁，普通私信已停止。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先启用 AI。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先启用 AI。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("私信回复为空。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("私信回复为空。");`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(DateTime.UtcNow.Ticks, PrivateMessages.Mailbox(data).Conversations.Values.Max(x => x.LastReplyOrder) + 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: conversation.LastReplyOrder = Math.Max(DateTime.UtcNow.Ticks, PrivateMessages.Mailbox(data).Conversations.Values.Max(x => x.LastReplyOrder) + 1)`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`record.Append(chunk)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: chunk => record.Append(chunk)`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`reasoning.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Reasoning = reasoning.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`record.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Reasoning = record.ToString()`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`cancel.Token.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.Token.ThrowIfCancellationRequested();`
- `System.Threading.CancellationTokenSource.CancellationTokenSource(System.TimeSpan)`；输入表达式：`new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)))`
- `System.TimeSpan.FromMinutes(long)`；输入表达式：`TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30))`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30))`

**赋值（含属性/字段和局部值）：**

- `_` = `SummarizePrivateAsync(current, save, person)`
- `conversation.LastReplyOrder` = `Math.Max(DateTime.UtcNow.Ticks, PrivateMessages.Mailbox(data).Conversations.Values.Max(x => x.LastReplyOrder) + 1)`
- `conversation` = `PrivateMessages.Conversation(data, person)`
- `current` = `() => resolve() is { } latest && PrivateMessages.CanChat(latest, person) && PrivateKey(latest, person) == key ? latest : null`
- `data` = `current()`
- `failed.Reasoning` = `PrivateReasoningLive.GetValueOrDefault(key).Text ?? ""`
- `failed.Reply` = `PrivateLive.GetValueOrDefault(key).Text ?? ""`
- `originalFavour` = `PrivateMessages.Favour(data, person)`
- `PrivateRequests[key]` = `cancel`
- `turn.Context` = `turn.RequestKind == "arbitration" ? SpireArbitration.Context(data, conversation, turn)                  : PrivateMessagePrompts.Context(data, conversation, turn, contextSpans)`
- `turn.Error` = `""`
- `turn.Error` = `parser.Error`
- `turn.PreviousReasoning` = `""`
- `turn.PreviousReply` = `turn.PreviousReasoning = ""`
- `turn.Reasoning` = `reasoning.ToString()`
- `turn.Reasoning` = `record.ToString()`
- `turn.Regenerating` = `false`
- `turn.Reply` = `parser.Text.Trim()`
- `turn.ReplyOrder` = `GroupChats.NextOrder(data)`
- `turn.SceneLines` = `DateScenes.TaggedLines(parser, turn.Scene)`
- `turn.Status` = `"complete"`
- `turn.Status` = `"sending"`
- `turn` = `conversation.Turns.First(t => t.Id == turnId)`

<a id="symbol-1138954c6e9e"></a>

## `Notify(string) — void Notify(string text)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`Progress(string)`](AiPrivateMessages.cs.md#symbol-d1b345a01158)；[`Thinking(string)`](AiPrivateMessages.cs.md#symbol-87339ddf1e41)

**调用：** [`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `<anonymous type: string person, string error>.error`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: error = FailureReason(e)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("private.delivery.failed", new { person, error = FailureReason(e) })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("private.delivery.failed", new { person, error = FailureReason(e) });`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke(turnId, text)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: progress?.Invoke(turnId, text)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d1b345a01158"></a>

## `Progress(string) — void Progress(string chunk)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-00bcca1f004c)；[`NationalSpire.PrivateStreamParser.Feed(string)`](PrivateMessages.cs.md#symbol-f34e8e2406af)；[`Notify(string)`](AiPrivateMessages.cs.md#symbol-1138954c6e9e)

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateLive`；`NationalSpire.AiService.PrivateSceneLive`；`NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`；`NationalSpire.PrivateStreamParser.Feed(string)`；`NationalSpire.PrivateStreamParser.Text`；`NationalSpire.PrivateTurn.Scene`；`Notify(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`；输入表达式：`DateScenes.TaggedLines(parser, turn.Scene)`；返回值紧邻使用处：`ArgumentSyntax: DateScenes.TaggedLines(parser, turn.Scene)`
- `NationalSpire.PrivateStreamParser.Feed(string)`；输入表达式：`parser.Feed(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.Feed(chunk);`
- `Notify(string)`；输入表达式：`Notify(parser.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notify(parser.Text);`

**赋值（含属性/字段和局部值）：**

- `lastProgress` = `DateTime.UtcNow`
- `PrivateLive[key]` = `(turnId, parser.Text)`
- `PrivateSceneLive[key]` = `(turnId, DateScenes.TaggedLines(parser, turn.Scene))`

<a id="symbol-87339ddf1e41"></a>

## `Thinking(string) — void Thinking(string chunk)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Notify(string)`](AiPrivateMessages.cs.md#symbol-1138954c6e9e)；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateReasoningLive`；`NationalSpire.PrivateStreamParser.Text`；`Notify(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Notify(string)`；输入表达式：`Notify(parser.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notify(parser.Text);`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`reasoning.Append(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: reasoning.Append(chunk);`
- `System.Text.StringBuilder.ToString()`；输入表达式：`reasoning.ToString()`；返回值紧邻使用处：`ArgumentSyntax: reasoning.ToString()`

**赋值（含属性/字段和局部值）：**

- `lastProgress` = `DateTime.UtcNow`
- `PrivateReasoningLive[key]` = `(turnId, reasoning.ToString())`

<a id="symbol-d73b189170eb"></a>

## `NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken) — private static async Task<IDisposable> EnterPrivateQueue(CareerData data, string key, CancellationToken token)`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.InferPortraitAsync(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, System.Threading.CancellationToken)`](AiPortraitDesign.cs.md#symbol-b767cc172aa6)；[`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)；[`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`NationalSpire.AiRequestQueue.EnterAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Action<string>?)`](AiRequestQueue.cs.md#symbol-b1465ed1e33c)；[`ReleasePending()`](AiPrivateMessages.cs.md#symbol-b77fbc43b15f)；`System.Threading.Tasks.Task<TResult>.WaitAsync(System.Threading.CancellationToken)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiRequestQueue.EnterAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Action<string>?)`；`NationalSpire.AiService.PrivateForegroundQueue`；`ReleasePending()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.EnterAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Action<string>?)`；输入表达式：`PrivateForegroundQueue.EnterAsync(data, [key])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateForegroundQueue.EnterAsync(data, [key])`
- `ReleasePending()`；输入表达式：`ReleasePending()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = ReleasePending()`
- `System.Threading.Tasks.Task<TResult>.WaitAsync(System.Threading.CancellationToken)`；输入表达式：`pending.WaitAsync(token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await pending.WaitAsync(token)`

**赋值（含属性/字段和局部值）：**

- `_` = `ReleasePending()`

<a id="symbol-b77fbc43b15f"></a>

## `ReleasePending() — async Task ReleasePending()`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`](AiPrivateMessages.cs.md#symbol-d73b189170eb)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4da425dc52d5"></a>

## `NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string) — internal static async Task<string> RequestPrivateAsync(AiOptions options, List<Dictionary<string, string>> messages, bool stream,          Action<string>? progress, CancellationToken token, Action<string>? reasoning = null, string context = "", string task = "private")`

来源：源码第 143 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.InferPortraitAsync(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, System.Threading.CancellationToken)`](AiPortraitDesign.cs.md#symbol-b767cc172aa6)；[`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)；[`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.SummaryRequest(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, string)`](AiPrivateMessages.cs.md#symbol-1b3123f418a5)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`Event()`](AiPrivateMessages.cs.md#symbol-16230d29c1cb)；[`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`](AiService.cs.md#symbol-8c02bb75b41a)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`](AiService.cs.md#symbol-80abc5b58bda)；[`NationalSpire.AiService.PrivateReasoning(System.Text.Json.JsonElement)`](AiPrivateMessages.cs.md#symbol-417a8e8e5b88)；[`NationalSpire.AiService.TryGetEndpoint(string?, out System.Uri)`](AiService.cs.md#symbol-e8b1c4ed9086)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.RegisterSecret(string?)`](Diagnostics.cs.md#symbol-4f621c46a4ca)；[`NationalSpire.LeadingReasoningStream.Feed(string)`](LeadingReasoningStream.cs.md#symbol-db75a9cd1314)；[`NationalSpire.LeadingReasoningStream.Finish()`](LeadingReasoningStream.cs.md#symbol-90a675c31e54)；[`RememberUsage(System.Text.Json.JsonElement)`](AiPrivateMessages.cs.md#symbol-d96c700935c7)；`NationalSpire.LeadingReasoningStream.LeadingReasoningStream(System.Action<string>, System.Action<string>)`；`string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(string, System.StringComparison)`；`string.TrimStart()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Enum.ToString()`；`System.Func<T1, T2, TResult>.Invoke(T1, T2)`（委托实际目标见流程文档）；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.IOException.IOException(string?)`；`System.IO.StreamReader.ReadLineAsync(System.Threading.CancellationToken)`；`System.IO.StreamReader.StreamReader(System.IO.Stream)`；`System.Net.Http.Headers.AuthenticationHeaderValue.AuthenticationHeaderValue(string, string?)`；`System.Net.Http.HttpContent.ReadAsStreamAsync(System.Threading.CancellationToken)`；`System.Net.Http.HttpContent.ReadAsStringAsync(System.Threading.CancellationToken)`；`System.Net.Http.HttpRequestException.HttpRequestException(string?)`；`System.Net.Http.HttpRequestMessage.HttpRequestMessage(System.Net.Http.HttpMethod, System.Uri?)`；`System.Net.Http.StringContent.StringContent(string, System.Text.Encoding?, string?)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.EnumerateObject()`；`System.Text.Json.JsonElement.GetArrayLength()`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.ToString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: string model, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> messages, bool stream>.model`；`<anonymous type: string trace, string context, bool stream, string Model, string ProfileId, int messages, int characters>.characters`；`<anonymous type: string trace, string context, bool stream, string Model, string ProfileId, int messages, int characters>.messages`；`<anonymous type: string trace, string context, string Model, string ProfileId, bool stream, string error, string content, string reasoning>.content`；`<anonymous type: string trace, string context, string Model, string ProfileId, bool stream, string error, string content, string reasoning>.error`；`<anonymous type: string trace, string context, string Model, string ProfileId, bool stream, string error, string content, string reasoning>.reasoning`；`<anonymous type: string trace, string context, string[] fields, string choices>.choices`；`<anonymous type: string trace, string context, string[] fields, string choices>.fields`；`Event()`；`NationalSpire.AiConnection.Endpoint`；`NationalSpire.AiConnection.Key`；`NationalSpire.AiConnection.Model`；`NationalSpire.AiConnection.ProfileId`；`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`；`NationalSpire.AiService.Json`；`NationalSpire.AiService.PrivateReasoning(System.Text.Json.JsonElement)`；`NationalSpire.AiService.PrivateTransport`；`NationalSpire.AiService.TryGetEndpoint(string?, out System.Uri)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.RegisterSecret(string?)`；`NationalSpire.LeadingReasoningStream.Feed(string)`；`NationalSpire.LeadingReasoningStream.Finish()`；`RememberUsage(System.Text.Json.JsonElement)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Event()`；输入表达式：`Event()`；返回值紧邻使用处：`ExpressionStatementSyntax: Event();`
- `NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；输入表达式：`Connection(options, task)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Connection(options, task)`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`AssignmentExpressionSyntax: failure = FailureReason(e)`
- `NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`；输入表达式：`HttpFailure(response)`；返回值紧邻使用处：`AwaitExpressionSyntax: await HttpFailure(response)`
- `NationalSpire.AiService.PrivateReasoning(System.Text.Json.JsonElement)`；输入表达式：`PrivateReasoning(message)`；返回值紧邻使用处：`ArgumentSyntax: PrivateReasoning(message)`
- `NationalSpire.AiService.TryGetEndpoint(string?, out System.Uri)`；输入表达式：`TryGetEndpoint(connection.Endpoint, out var endpoint)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !TryGetEndpoint(connection.Endpoint, out var endpoint)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("private.transport", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("private.transport", e);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("private.request", new { trace, context, stream, connection.Model, connection.ProfileId, messages = messages.Count, characters = messages.Sum(m => m["content"].Length) })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("private.request", new { trace, context, stream, connection.Model, connection.ProfileId, messages = messages.Count, characters = messages.Sum(m => m["content"].Length) });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("private.response_structure", new { trace, context, fields = document.RootElement.EnumerateObject().Select(p => p.Name).ToArray(), choices = choices.ValueKind.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("private.response_structure", new { trace, context, fields = document.RootElement.EnumerateObject().Select(p => p.Name).ToArray(), choices = choices.ValueKind.ToString() });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("private.response", new { trace, context, connection.Model, connection.ProfileId, stream, error = failure, content = received.ToString(), reasoning = thoughts.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("private.response", new { trace, context, connection.Model, connection.ProfileId, stream, error = failure, content = received.ToString(), reasoning = thoughts.ToString() });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("private.usage", new { trace, context, usage })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("private.usage", new { trace, context, usage });`
- `NationalSpire.Diagnostics.RegisterSecret(string?)`；输入表达式：`Diagnostics.RegisterSecret(connection.Key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RegisterSecret(connection.Key);`
- `NationalSpire.LeadingReasoningStream.Feed(string)`；输入表达式：`leading.Feed(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: leading.Feed(chunk);`
- `NationalSpire.LeadingReasoningStream.Finish()`；输入表达式：`leading.Finish()`；返回值紧邻使用处：`ExpressionStatementSyntax: leading.Finish();`
- `NationalSpire.LeadingReasoningStream.LeadingReasoningStream(System.Action<string>, System.Action<string>)`；输入表达式：`new LeadingReasoningStream(chunk => { visible.Append(chunk); onContent?.Invoke(chunk); }, reasoning)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LeadingReasoningStream(chunk => { visible.Append(chunk); onContent?.Invoke(chunk); }, reasoning)`
- `RememberUsage(System.Text.Json.JsonElement)`；输入表达式：`RememberUsage(document.RootElement)`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberUsage(document.RootElement);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(connection.Key)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(connection.Key)) throw new InvalidOperationException("请先在模组设置中保存密钥。");`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(contentValue.GetString())`；返回值紧邻使用处：`BinaryExpressionSyntax: !message.TryGetProperty("content", out var contentValue) || contentValue.ValueKind != JsonValueKind.String || string.IsNullOrWhiteSpace(contentValue.GetString())`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`line.StartsWith("data:", StringComparison.Ordinal)`；返回值紧邻使用处：`IfStatementSyntax: if (line.StartsWith("data:", StringComparison.Ordinal)) { if (eventData.Length > 0) eventData.Append('\n'); eventData.Append(line[5..].TrimStart()); }`
- `string.TrimStart()`；输入表达式：`line[5..].TrimStart()`；返回值紧邻使用处：`ArgumentSyntax: line[5..].TrimStart()`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(chunk)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: onContent?.Invoke(chunk)`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(chunk)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: onReasoning?.Invoke(chunk)`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(content)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: progress?.Invoke(content)`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(PrivateReasoning(message))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: reasoning?.Invoke(PrivateReasoning(message))`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("接口地址无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("接口地址无效。");`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`document.RootElement.EnumerateObject().Select(p => p.Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: document.RootElement.EnumerateObject().Select(p => p.Name).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`messages.Sum(m => m["content"].Length)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: characters = messages.Sum(m => m["content"].Length)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`document.RootElement.EnumerateObject().Select(p => p.Name).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: fields = document.RootElement.EnumerateObject().Select(p => p.Name).ToArray()`
- `System.Enum.ToString()`；输入表达式：`choices.ValueKind.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: choices = choices.ValueKind.ToString()`
- `System.Func<T1, T2, TResult>.Invoke(T1, T2)`；输入表达式：`PrivateTransport(request, token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await PrivateTransport(request, token)`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先在模组设置中保存密钥。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先在模组设置中保存密钥。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("回复未完整结束：" + finish.GetString())`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("回复未完整结束：" + finish.GetString());`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("接口返回了空回复，请重试。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("接口返回了空回复，请重试。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("接口回复缺少消息内容。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("接口回复缺少消息内容。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("接口未返回可读取的回复内容。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("接口未返回可读取的回复内容。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("私信回复过长，已停止接收。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("私信回复过长，已停止接收。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(error.ToString())`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(error.ToString());`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException("回复连接提前结束，交互未执行，请重试。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new IOException("回复连接提前结束，交互未执行，请重试。");`
- `System.IO.StreamReader.ReadLineAsync(System.Threading.CancellationToken)`；输入表达式：`reader.ReadLineAsync(token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await reader.ReadLineAsync(token)`
- `System.IO.StreamReader.StreamReader(System.IO.Stream)`；输入表达式：`new StreamReader(await response.Content.ReadAsStreamAsync(token))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamReader(await response.Content.ReadAsStreamAsync(token))`
- `System.Net.Http.Headers.AuthenticationHeaderValue.AuthenticationHeaderValue(string, string?)`；输入表达式：`new AuthenticationHeaderValue("Bearer", connection.Key)`；返回值紧邻使用处：`AssignmentExpressionSyntax: request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", connection.Key)`
- `System.Net.Http.HttpContent.ReadAsStreamAsync(System.Threading.CancellationToken)`；输入表达式：`response.Content.ReadAsStreamAsync(token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await response.Content.ReadAsStreamAsync(token)`
- `System.Net.Http.HttpContent.ReadAsStringAsync(System.Threading.CancellationToken)`；输入表达式：`response.Content.ReadAsStringAsync(token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await response.Content.ReadAsStringAsync(token)`
- `System.Net.Http.HttpRequestException.HttpRequestException(string?)`；输入表达式：`new HttpRequestException(await HttpFailure(response))`；返回值紧邻使用处：`ThrowStatementSyntax: throw new HttpRequestException(await HttpFailure(response));`
- `System.Net.Http.HttpRequestMessage.HttpRequestMessage(System.Net.Http.HttpMethod, System.Uri?)`；输入表达式：`new HttpRequestMessage(HttpMethod.Post, endpoint)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HttpRequestMessage(HttpMethod.Post, endpoint)`
- `System.Net.Http.StringContent.StringContent(string, System.Text.Encoding?, string?)`；输入表达式：`new StringContent(JsonSerializer.Serialize(new { model = connection.Model, messages, stream }, Json), Encoding.UTF8, "application/json")`；返回值紧邻使用处：`AssignmentExpressionSyntax: request.Content = new StringContent(JsonSerializer.Serialize(new { model = connection.Model, messages, stream }, Json), Encoding.UTF8, "application/json")`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(body)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(body)`
- `System.Text.Json.JsonElement.EnumerateObject()`；输入表达式：`document.RootElement.EnumerateObject()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: document.RootElement.EnumerateObject().Select`
- `System.Text.Json.JsonElement.GetArrayLength()`；输入表达式：`choices.GetArrayLength()`；返回值紧邻使用处：`BinaryExpressionSyntax: choices.GetArrayLength() == 0`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`contentValue.GetString()`；返回值紧邻使用处：`ArgumentSyntax: contentValue.GetString()`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`contentValue.GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: contentValue.GetString()!`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`finish.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: "回复未完整结束：" + finish.GetString()`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`finish.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: finish.GetString() != "stop"`
- `System.Text.Json.JsonElement.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`ArgumentSyntax: error.ToString()`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`choice.TryGetProperty("finish_reason", out var finish)`；返回值紧邻使用处：`BinaryExpressionSyntax: choice.TryGetProperty("finish_reason", out var finish) && finish.ValueKind == JsonValueKind.String`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`choice.TryGetProperty("message", out var message)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !choice.TryGetProperty("message", out var message)`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`document.RootElement.TryGetProperty("choices", out var choices)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !document.RootElement.TryGetProperty("choices", out var choices)`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`document.RootElement.TryGetProperty("error", out var error)`；返回值紧邻使用处：`IfStatementSyntax: if (document.RootElement.TryGetProperty("error", out var error)) throw new InvalidDataException(error.ToString());`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`message.TryGetProperty("content", out var contentValue)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !message.TryGetProperty("content", out var contentValue)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new { model = connection.Model, messages, stream }, Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(new { model = connection.Model, messages, stream }, Json)`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`eventData.Append('\n')`；返回值紧邻使用处：`ExpressionStatementSyntax: eventData.Append('\n');`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`eventData.Append(line[5..].TrimStart())`；返回值紧邻使用处：`ExpressionStatementSyntax: eventData.Append(line[5..].TrimStart());`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`received.Append(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: received.Append(chunk);`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`thoughts.Append(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: thoughts.Append(chunk);`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`visible.Append(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: visible.Append(chunk);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`received.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: content = received.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`thoughts.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: reasoning = thoughts.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`visible.ToString()`；返回值紧邻使用处：`ReturnStatementSyntax: return visible.ToString();`

**赋值（含属性/字段和局部值）：**

- `failure` = `FailureReason(e)`
- `progress` = `chunk => { received.Append(chunk); leading.Feed(chunk); }`
- `reasoning` = `chunk => { thoughts.Append(chunk); onReasoning?.Invoke(chunk); }`
- `request.Content` = `new StringContent(JsonSerializer.Serialize(new { model = connection.Model, messages, stream }, Json), Encoding.UTF8, "application/json")`
- `request.Headers.Authorization` = `new AuthenticationHeaderValue("Bearer", connection.Key)`

<a id="symbol-d96c700935c7"></a>

## `RememberUsage(System.Text.Json.JsonElement) — void RememberUsage(JsonElement root)`

来源：源码第 159 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Event()`](AiPrivateMessages.cs.md#symbol-16230d29c1cb)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)

**调用：** `System.Text.Json.JsonElement.Clone()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.JsonElement.Clone()`；输入表达式：`usage.Clone()`；返回值紧邻使用处：`AssignmentExpressionSyntax: lastUsage = usage.Clone()`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("usage", out var usage)`；返回值紧邻使用处：`BinaryExpressionSyntax: root.TryGetProperty("usage", out var usage) && usage.ValueKind == JsonValueKind.Object`

**赋值（含属性/字段和局部值）：**

- `lastUsage` = `usage.Clone()`

<a id="symbol-16230d29c1cb"></a>

## `Event() — void Event()`

来源：源码第 190 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)

**调用：** [`NationalSpire.AiService.PrivateReasoning(System.Text.Json.JsonElement)`](AiPrivateMessages.cs.md#symbol-417a8e8e5b88)；[`RememberUsage(System.Text.Json.JsonElement)`](AiPrivateMessages.cs.md#symbol-d96c700935c7)；`string.Trim()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.GetArrayLength()`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.ToString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateReasoning(System.Text.Json.JsonElement)`；`RememberUsage(System.Text.Json.JsonElement)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.PrivateReasoning(System.Text.Json.JsonElement)`；输入表达式：`PrivateReasoning(delta)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateReasoning(delta)`
- `RememberUsage(System.Text.Json.JsonElement)`；输入表达式：`RememberUsage(root)`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberUsage(root);`
- `string.Trim()`；输入表达式：`eventData.ToString().Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = eventData.ToString().Trim()`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(chunk)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: progress?.Invoke(chunk)`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(thought)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: reasoning?.Invoke(thought)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("私信回复未完整结束：" + finish.GetString())`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("私信回复未完整结束：" + finish.GetString());`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(error.ToString())`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(error.ToString());`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(content)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(content)`
- `System.Text.Json.JsonElement.GetArrayLength()`；输入表达式：`choices.GetArrayLength()`；返回值紧邻使用处：`BinaryExpressionSyntax: choices.GetArrayLength() == 0`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`finish.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: "私信回复未完整结束：" + finish.GetString()`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`finish.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: finish.GetString() != "stop"`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`text.GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: text.GetString()!`
- `System.Text.Json.JsonElement.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`ArgumentSyntax: error.ToString()`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`delta.TryGetProperty("content", out var text)`；返回值紧邻使用处：`BinaryExpressionSyntax: delta.TryGetProperty("content", out var text) && text.ValueKind == JsonValueKind.String`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`first.TryGetProperty("delta", out var delta)`；返回值紧邻使用处：`IfStatementSyntax: if (first.TryGetProperty("delta", out var delta))                  {                      string thought = PrivateReasoning(delta); reasoningSize += thought.Length;                      if (thought.Length > 0) reasoning?.Invoke(thought);                      if (delta.TryGetProperty("content", out var text) && text.ValueKind == JsonValueKind.String)                      { string chunk = text.GetString()!; result.Append(chunk); progress?.Invoke(chunk); }                  }`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`first.TryGetProperty("finish_reason", out var finish)`；返回值紧邻使用处：`BinaryExpressionSyntax: first.TryGetProperty("finish_reason", out var finish) && finish.ValueKind == JsonValueKind.String`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("choices", out var choices)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !root.TryGetProperty("choices", out var choices)`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("error", out var error)`；返回值紧邻使用处：`IfStatementSyntax: if (root.TryGetProperty("error", out var error)) throw new InvalidDataException(error.ToString());`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Append(chunk);`
- `System.Text.StringBuilder.Clear()`；输入表达式：`eventData.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: eventData.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`eventData.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: eventData.ToString().Trim`

**赋值（含属性/字段和局部值）：**

- `completed` = `true`
- `done` = `true`
- `reasoningSize` += `thought.Length`

<a id="symbol-417a8e8e5b88"></a>

## `NationalSpire.AiService.PrivateReasoning(System.Text.Json.JsonElement) — private static string PrivateReasoning(JsonElement message)`

来源：源码第 230 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Event()`](AiPrivateMessages.cs.md#symbol-16230d29c1cb)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)

**调用：** `System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.JsonElement.GetString()`；输入表达式：`value.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: value.GetString() ?? ""`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`message.TryGetProperty(key, out var value)`；返回值紧邻使用处：`BinaryExpressionSyntax: message.TryGetProperty(key, out var value) && value.ValueKind == JsonValueKind.String`

**赋值（含属性/字段和局部值）：**


<a id="symbol-198521296d15"></a>

## `NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string) — private static async Task SummarizePrivateAsync(Func<CareerData?> current, Action<CareerData> save, string person)`

来源：源码第 236 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.SummarizePrivateManually(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-88f72cb1c19e)

**调用：** [`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-97ba03595bc3)；[`NationalSpire.AiService.Summarize(NationalSpire.CareerData, string, string, string)`](AiPrivateMessages.cs.md#symbol-1ec00f25b0bb)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.PrivateHistorySettings.Validate()`](PrivateMessageData.cs.md#symbol-2608e8077b19)；[`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`](PrivateMessageData.cs.md#symbol-2a4d65cc20f8)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.CareerData, NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`](PrivateMessagePrompts.cs.md#symbol-2e632c46656c)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Completed(NationalSpire.PrivateConversation)`](PrivateMessages.cs.md#symbol-3f3045d6546b)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.FinishBigSummary(NationalSpire.PrivateConversation, System.Collections.Generic.IReadOnlyCollection<string>, string)`](PrivateMessages.cs.md#symbol-171af55402a5)；[`NationalSpire.PrivateMessages.FinishSmallSummary(NationalSpire.PrivateConversation, NationalSpire.PrivateHistorySettings, int, string)`](PrivateMessages.cs.md#symbol-50e1856a4dce)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.FindLastIndex(System.Predicate<T>)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string 日期, string 玩家, string 你>.你`；`<anonymous type: string 日期, string 玩家, string 你>.日期`；`<anonymous type: string 日期, string 玩家, string 你>.玩家`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.Json`；`NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.PrivateSummaries`；`NationalSpire.AiService.Summarize(NationalSpire.CareerData, string, string, string)`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.PrivateConversation.ContextStart`；`NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.SummaryError`；`NationalSpire.PrivateConversation.SummaryRequest`；`NationalSpire.PrivateConversation.SummaryStatus`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateHistorySettings.MaximumRounds`；`NationalSpire.PrivateHistorySettings.MergeOldest`；`NationalSpire.PrivateHistorySettings.SmallSummaryLimit`；`NationalSpire.PrivateHistorySettings.Validate()`；`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateMailbox.Settings`；`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.CareerData, NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Completed(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.FinishBigSummary(NationalSpire.PrivateConversation, System.Collections.Generic.IReadOnlyCollection<string>, string)`；`NationalSpire.PrivateMessages.FinishSmallSummary(NationalSpire.PrivateConversation, NationalSpire.PrivateHistorySettings, int, string)`；`NationalSpire.PrivateSummary.Id`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`BinaryExpressionSyntax: "记忆总结失败，下次回复后重试：" + FailureReason(e)`
- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`PrivateKey(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateKey(data, person)`
- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`PrivateKey(latest, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateKey(latest, person) == key`
- `NationalSpire.AiService.Summarize(NationalSpire.CareerData, string, string, string)`；输入表达式：`Summarize(data, person, "private-long-summary", string.Join("\n\n", snapshot.Select(s => s.Text)))`；返回值紧邻使用处：`AwaitExpressionSyntax: await Summarize(data, person, "private-long-summary", string.Join("\n\n", snapshot.Select(s => s.Text)))`
- `NationalSpire.AiService.Summarize(NationalSpire.CareerData, string, string, string)`；输入表达式：`Summarize(data, person, "private-summary", JsonSerializer.Serialize(snapshot, Json))`；返回值紧邻使用处：`AwaitExpressionSyntax: await Summarize(data, person, "private-summary", JsonSerializer.Serialize(snapshot, Json))`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, t.Day)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 日期 = GameCalendar.Text(data, t.Day)`
- `NationalSpire.PrivateHistorySettings.Validate()`；输入表达式：`settings.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.Validate();`
- `NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；输入表达式：`PrivateInteractionIds.Ensure(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionIds.Ensure(c);`
- `NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.CareerData, NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`；输入表达式：`PrivateMessagePrompts.UserText(data, t, c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: t.UserDeleted ? null : PrivateMessagePrompts.UserText(data, t, c)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, person)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(latest, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: resolve() is { } latest && PrivateMessages.CanChat(latest, person)`
- `NationalSpire.PrivateMessages.Completed(NationalSpire.PrivateConversation)`；输入表达式：`PrivateMessages.Completed(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Completed(c) > settings.MaximumRounds`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c = PrivateMessages.Conversation(data, person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateMessages.Conversation(data, person) is { } c`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, person).MemoryRevision`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, person).SummaryError`
- `NationalSpire.PrivateMessages.FinishBigSummary(NationalSpire.PrivateConversation, System.Collections.Generic.IReadOnlyCollection<string>, string)`；输入表达式：`PrivateMessages.FinishBigSummary(c, snapshot.Select(s => s.Id).ToArray(), text)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.FinishBigSummary(c, snapshot.Select(s => s.Id).ToArray(), text);`
- `NationalSpire.PrivateMessages.FinishSmallSummary(NationalSpire.PrivateConversation, NationalSpire.PrivateHistorySettings, int, string)`；输入表达式：`PrivateMessages.FinishSmallSummary(c, data.Life.Mailbox.Settings, end, text)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.FinishSmallSummary(c, data.Life.Mailbox.Settings, end, text);`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n", snapshot.Select(s => s.Text))`；返回值紧邻使用处：`ArgumentSyntax: string.Join("\n\n", snapshot.Select(s => s.Text))`
- `System.Action<T>.Invoke(T)`；输入表达式：`save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: save(data);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`PrivateSummaries.Add(key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateSummaries.Add(key)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`PrivateSummaries.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateSummaries.Remove(key);`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Turns.Skip(c.ContextStart).Take(end - c.ContextStart).Where(t => t.Status == "complete" && !(t.UserDeleted && t.ReplyDeleted)).Select(t => new { 日期 = GameCalendar.Text(data, t.Day), 玩家 = t.UserDeleted ? null : PrivateMessagePrompts.UserText(data, t, c), 你 = t.ReplyDeleted ? null : t.Reply })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Skip(c.ContextStart).Take(end - c.ContextStart).Where(t => t.Status == "complete" && !(t.UserDeleted && t.ReplyDeleted)).Select(t => new { 日期 = GameCalendar.Text(data, t.Day), 玩家 = t.UserDeleted ? null : PrivateMessagePrompts.UserText(data, t, c), 你 = t.ReplyDeleted ? null : t.Reply }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`snapshot.Select(s => s.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: snapshot.Select(s => s.Id).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`snapshot.Select(s => s.Text)`；返回值紧邻使用处：`ArgumentSyntax: snapshot.Select(s => s.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`c.Turns.Skip(c.ContextStart)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Skip(c.ContextStart).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`c.SmallSummaries.Take(settings.MergeOldest)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.SmallSummaries.Take(settings.MergeOldest).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`c.Turns.Skip(c.ContextStart).Take(end - c.ContextStart)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Skip(c.ContextStart).Take(end - c.ContextStart).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`c.SmallSummaries.Take(settings.MergeOldest).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.SmallSummaries.Take(settings.MergeOldest).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`c.Turns.Skip(c.ContextStart).Take(end - c.ContextStart).Where(t => t.Status == "complete" && !(t.UserDeleted && t.ReplyDeleted)).Select(t => new { 日期 = GameCalendar.Text(data, t.Day), 玩家 = t.UserDeleted ? null : PrivateMessagePrompts.UserText(data, t, c), 你 = t.ReplyDeleted ? null : t.Reply }).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.Skip(c.ContextStart).Take(end - c.ContextStart).Where(t => t.Status == "complete" && !(t.UserDeleted && t.ReplyDeleted)).Select(t => new { 日期 = GameCalendar.Text(data, t.Day), 玩家 = t.UserDeleted ? null : PrivateMessagePrompts.UserText(data, t, c), 你 = t.ReplyDeleted ? null : t.Reply }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`snapshot.Select(s => s.Id).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: snapshot.Select(s => s.Id).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Skip(c.ContextStart).Take(end - c.ContextStart).Where(t => t.Status == "complete" && !(t.UserDeleted && t.ReplyDeleted))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Skip(c.ContextStart).Take(end - c.ContextStart).Where(t => t.Status == "complete" && !(t.UserDeleted && t.ReplyDeleted)).Select`
- `System.Collections.Generic.List<T>.FindLastIndex(System.Predicate<T>)`；输入表达式：`c.Turns.FindLastIndex(t => t.Status == "complete")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Turns.FindLastIndex(t => t.Status == "complete") + 1`
- `System.Func<TResult>.Invoke()`；输入表达式：`current()`；返回值紧邻使用处：`AssignmentExpressionSyntax: data = current()`
- `System.Func<TResult>.Invoke()`；输入表达式：`current()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = current()`
- `System.Func<TResult>.Invoke()`；输入表达式：`resolve()`；返回值紧邻使用处：`IsPatternExpressionSyntax: resolve() is { } latest`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(snapshot, Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(snapshot, Json)`

**赋值（含属性/字段和局部值）：**

- `c.SummaryRequest` = `""`
- `c.SummaryStatus` = `""`
- `c.SummaryStatus` = `"正在合并长期记忆"`
- `c.SummaryStatus` = `"正在整理聊天记忆"`
- `c` = `PrivateMessages.Conversation(data, person)`
- `current` = `() => resolve() is { } latest && PrivateMessages.CanChat(latest, person) && PrivateKey(latest, person) == key ? latest : null`
- `data` = `current()`
- `PrivateMessages.Conversation(data, person).SummaryError` = `"记忆总结失败，下次回复后重试：" + FailureReason(e)`
- `settings` = `data.Life.Mailbox.Settings`

<a id="symbol-1ec00f25b0bb"></a>

## `NationalSpire.AiService.Summarize(NationalSpire.CareerData, string, string, string) — private static Task<string> Summarize(CareerData data, string person, string section, string content)`

来源：源码第 281 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)

**调用：** [`NationalSpire.AiService.SummaryRequest(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, string)`](AiPrivateMessages.cs.md#symbol-1b3123f418a5)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.PersonalityLibrary.PromptProfile(NationalSpire.PersonalityProfile)`](PersonalityLibrary.cs.md#symbol-cc24e5415a31)；[`NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`](PromptLibrary.cs.md#symbol-3f64d002bbbe)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.Json`；`NationalSpire.AiService.SummaryRequest(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, string)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.PersonalityLibrary.ProfileUsage`；`NationalSpire.PersonalityLibrary.PromptProfile(NationalSpire.PersonalityProfile)`；`NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.SummaryRequest(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, string)`；输入表达式：`SummaryRequest(data.Ai, messages, "private-summary")`；返回值紧邻使用处：`ReturnStatementSyntax: return SummaryRequest(data.Ai, messages, "private-summary");`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(data)}`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, person)!`
- `NationalSpire.PersonalityLibrary.PromptProfile(NationalSpire.PersonalityProfile)`；输入表达式：`PersonalityLibrary.PromptProfile(p.Personality)`；返回值紧邻使用处：`ArgumentSyntax: PersonalityLibrary.PromptProfile(p.Personality)`
- `NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`；输入表达式：`PromptLibrary.Get(data.Ai, section)`；返回值紧邻使用处：`BinaryExpressionSyntax: PromptLibrary.Get(data.Ai, section) + $"\n你是{p.PublicName}，以{p.PublicName}的第一人称整理与玩家{CareerEngine.Name(data)}的聊天。\n{p.PublicName}的性格 "`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["role"] = "system", ["content"] = PromptLibrary.Get(data.Ai, section) + $"\n你是{p.PublicName}，以{p.PublicName}的第一人称整理与玩家{CareerEngine.Name(data)}的聊天。\n{p.PublicName}的性格 " + JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(p.Personality), Json) + "\n性格使用说明：" + PersonalityLibrary.ProfileUsage }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { ["role"] = "system", ["content"] = PromptLibrary.Get(data.Ai, section) + $"\n你是{p.PublicName}，以{p.PublicName}的第一人称整理与玩家{CareerEngine.Name(data)}的聊天。\n{p.PublicName}的性格 " + JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(p.Personality), Json) + "\n性格使用说明：" + PersonalityLibrary.ProfileUsage }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["role"] = "user", ["content"] = content }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { ["role"] = "user", ["content"] = content }`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(p.Personality), Json)`；返回值紧邻使用处：`BinaryExpressionSyntax: PromptLibrary.Get(data.Ai, section) + $"\n你是{p.PublicName}，以{p.PublicName}的第一人称整理与玩家{CareerEngine.Name(data)}的聊天。\n{p.PublicName}的性格 " + JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(p.Personality), Json)`

**赋值（含属性/字段和局部值）：**

- `["content"]` = `content`
- `["content"]` = `PromptLibrary.Get(data.Ai, section) + $"\n你是{p.PublicName}，以{p.PublicName}的第一人称整理与玩家{CareerEngine.Name(data)}的聊天。\n{p.PublicName}的性格 " + JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(p.Personality), Json) + "\n性格使用说明：" + PersonalityLibrary.ProfileUsage`
- `["role"]` = `"system"`
- `["role"]` = `"user"`

<a id="symbol-1b3123f418a5"></a>

## `NationalSpire.AiService.SummaryRequest(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, string) — private static async Task<string> SummaryRequest(AiOptions options, List<Dictionary<string, string>> messages, string task)`

来源：源码第 287 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.Summarize(NationalSpire.CareerData, string, string, string)`](AiPrivateMessages.cs.md#symbol-1ec00f25b0bb)；[`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`](AiGroupChats.cs.md#symbol-1e6e737dbe88)

**调用：** [`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)；`System.Math.Clamp(int, int, int)`；`System.Threading.CancellationTokenSource.CancellationTokenSource(System.TimeSpan)`；`System.Threading.SemaphoreSlim.Release()`；`System.Threading.SemaphoreSlim.WaitAsync(System.Threading.CancellationToken)`；`System.TimeSpan.FromMinutes(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.RequestTimeoutMinutes`；`NationalSpire.AiService.PrivateSummaryQueue`；`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；输入表达式：`RequestPrivateAsync(options, messages, false, null, timeout.Token, task: task)`；返回值紧邻使用处：`AwaitExpressionSyntax: await RequestPrivateAsync(options, messages, false, null, timeout.Token, task: task)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(options.RequestTimeoutMinutes, 2, 30)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(options.RequestTimeoutMinutes, 2, 30)`
- `System.Threading.CancellationTokenSource.CancellationTokenSource(System.TimeSpan)`；输入表达式：`new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(options.RequestTimeoutMinutes, 2, 30)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(options.RequestTimeoutMinutes, 2, 30)))`
- `System.Threading.SemaphoreSlim.Release()`；输入表达式：`PrivateSummaryQueue.Release()`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateSummaryQueue.Release();`
- `System.Threading.SemaphoreSlim.WaitAsync(System.Threading.CancellationToken)`；输入表达式：`PrivateSummaryQueue.WaitAsync(timeout.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await PrivateSummaryQueue.WaitAsync(timeout.Token)`
- `System.TimeSpan.FromMinutes(long)`；输入表达式：`TimeSpan.FromMinutes(Math.Clamp(options.RequestTimeoutMinutes, 2, 30))`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromMinutes(Math.Clamp(options.RequestTimeoutMinutes, 2, 30))`

**赋值（含属性/字段和局部值）：**
