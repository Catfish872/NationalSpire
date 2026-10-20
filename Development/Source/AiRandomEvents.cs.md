# AiRandomEvents.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F5D13CC1DFC3024A35EA30A0C390F1B4835695B7D5B168D90AC058025B503A50`。来源：[源码](../../AiRandomEvents.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiService`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, CancellationTokenSource> EventRequests = [];
public static readonly Dictionary<string, EventLive> EventLive = [];
```

<a id="symbol-fadf0b2a4925"></a>

## `NationalSpire.AiService.EventKey(NationalSpire.CareerData, string) — public static string EventKey(CareerData d, string id)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.CancelEvent(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-5e66dafe8706)；[`NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-a251022ff4b2)；[`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)；[`NationalSpire.CareerScreen.RefreshRandomEvent()`](RandomEventScreen.cs.md#symbol-54853f1d507f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a251022ff4b2"></a>

## `NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string) — public static bool EventBusy(CareerData d, string id)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshRandomEvent()`](RandomEventScreen.cs.md#symbol-54853f1d507f)；[`NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-605db3348248)

**调用：** [`NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-fadf0b2a4925)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.EventRequests`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`；输入表达式：`EventKey(d, id)`；返回值紧邻使用处：`ArgumentSyntax: EventKey(d, id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`EventRequests.ContainsKey(EventKey(d, id))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => EventRequests.ContainsKey(EventKey(d, id))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5e66dafe8706"></a>

## `NationalSpire.AiService.CancelEvent(NationalSpire.CareerData, string) — public static void CancelEvent(CareerData d, string id)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-9b570a0265e9)；[`NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-3b62c8ad1ca6)

**调用：** [`NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-fadf0b2a4925)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Threading.CancellationTokenSource.Cancel()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.EventRequests`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`；输入表达式：`EventKey(d, id)`；返回值紧邻使用处：`ArgumentSyntax: EventKey(d, id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`EventRequests.TryGetValue(EventKey(d, id), out var cancel)`；返回值紧邻使用处：`IfStatementSyntax: if (EventRequests.TryGetValue(EventKey(d, id), out var cancel)) cancel.Cancel();`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`cancel.Cancel()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.Cancel();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5705d03a72b3"></a>

## `NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?) — public static async Task ProcessEventAsync(Func<CareerData?> current, Action<CareerData> save, string id, Action<EventLive>? progress = null)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?)`](RandomEventScreen.cs.md#symbol-0f39ca3683aa)；[`NationalSpire.Coop.CoopCoordinator.StartEvent(ulong, NationalSpire.Coop.CoopCommand)`](Coop/CoopRandomEvents.cs.md#symbol-b51ea4166eab)

**调用：** [`NationalSpire.AiRequestQueue.Configure(int)`](AiRequestQueue.cs.md#symbol-7bf81d36c27d)；[`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`](AiPrivateMessages.cs.md#symbol-d73b189170eb)；[`NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-fadf0b2a4925)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.RandomEventParser.Feed(string)`](RandomEventData.cs.md#symbol-af55d7453f88)；[`NationalSpire.RandomEventParser.Finish()`](RandomEventData.cs.md#symbol-9fff6310dec5)；[`NationalSpire.RandomEventParser.Validate()`](RandomEventData.cs.md#symbol-39c0a466ac58)；[`NationalSpire.RandomEventPrompts.Compose(NationalSpire.RandomEventRecord, NationalSpire.AiOptions?)`](RandomEventPrompts.cs.md#symbol-81f58f271386)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-20d7a260dcab)；[`Update(bool)`](AiRandomEvents.cs.md#symbol-3cf611dddd72)；`NationalSpire.RandomEventParser.RandomEventParser()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Math.Clamp(int, int, int)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`；`System.Threading.CancellationTokenSource.CancellationTokenSource(System.TimeSpan)`；`System.TimeSpan.FromMinutes(long)`

**字段、属性、事件及方法组引用：** `<anonymous type: string id, string error>.error`；`NationalSpire.AiOptions.MaxConcurrentRequests`；`NationalSpire.AiOptions.RequestTimeoutMinutes`；`NationalSpire.AiRequestQueue.Configure(int)`；`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`；`NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.EventLive`；`NationalSpire.AiService.EventRequests`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.PrivateForegroundQueue`；`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；`NationalSpire.CareerData.Ai`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.RandomEventParser.Feed(string)`；`NationalSpire.RandomEventParser.Finish()`；`NationalSpire.RandomEventParser.Options`；`NationalSpire.RandomEventParser.Story`；`NationalSpire.RandomEventParser.Title`；`NationalSpire.RandomEventParser.Validate()`；`NationalSpire.RandomEventPrompts.Compose(NationalSpire.RandomEventRecord, NationalSpire.AiOptions?)`；`NationalSpire.RandomEventRecord.Error`；`NationalSpire.RandomEventRecord.Options`；`NationalSpire.RandomEventRecord.Reasoning`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEventRecord.Story`；`NationalSpire.RandomEventRecord.Title`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；`Update(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.Configure(int)`；输入表达式：`PrivateForegroundQueue.Configure(d.Ai.MaxConcurrentRequests)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateForegroundQueue.Configure(d.Ai.MaxConcurrentRequests);`
- `NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`；输入表达式：`EnterPrivateQueue(d, key, cancel.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await EnterPrivateQueue(d, key, cancel.Token)`
- `NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`；输入表达式：`EventKey(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: EventKey(d, id) != key`
- `NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`；输入表达式：`EventKey(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: EventKey(d, id) == key`
- `NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`；输入表达式：`EventKey(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EventKey(d, id)`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(error)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: error = FailureReason(error)`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(error)`；返回值紧邻使用处：`ConditionalExpressionSyntax: error is OperationCanceledException ? "生成已停止，可以重试或跳过。" : FailureReason(error)`
- `NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；输入表达式：`RequestPrivateAsync(d.Ai, RandomEventPrompts.Compose(e, d.Ai), true, chunk =>             {                 parser.Feed(chunk); phase = "正在书写"; Update();             }, cancel.Token, reasoning: chunk => { thoughts.Append(chunk); phase = "正在思考"; Update(); }, context: key, task: "event")`；返回值紧邻使用处：`AwaitExpressionSyntax: await RequestPrivateAsync(d.Ai, RandomEventPrompts.Compose(e, d.Ai), true, chunk =>             {                 parser.Feed(chunk); phase = "正在书写"; Update();             }, cancel.Token, reasoning: chunk => { thoughts.Append(chunk); phase = "正在思考"; Update(); }, context: key, task: "event")`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("event.failed", new { id, error = FailureReason(error) })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("event.failed", new { id, error = FailureReason(error) });`
- `NationalSpire.RandomEventParser.Feed(string)`；输入表达式：`parser.Feed(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.Feed(chunk);`
- `NationalSpire.RandomEventParser.Finish()`；输入表达式：`parser.Finish()`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.Finish();`
- `NationalSpire.RandomEventParser.RandomEventParser()`；输入表达式：`new RandomEventParser()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new RandomEventParser()`
- `NationalSpire.RandomEventParser.Validate()`；输入表达式：`parser.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.Validate();`
- `NationalSpire.RandomEventPrompts.Compose(NationalSpire.RandomEventRecord, NationalSpire.AiOptions?)`；输入表达式：`RandomEventPrompts.Compose(e, d.Ai)`；返回值紧邻使用处：`ArgumentSyntax: RandomEventPrompts.Compose(e, d.Ai)`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Find(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: RandomEvents.Find(d, id) is { State: "generating" } latest`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Find(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: RandomEvents.Find(d, id) is not { State: "generating" } e`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Find(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: RandomEvents.Find(d, id) is not { State: "generating" } latest`
- `System.Action<T>.Invoke(T)`；输入表达式：`save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: save(d);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`EventRequests.ContainsKey(key)`；返回值紧邻使用处：`IfStatementSyntax: if (EventRequests.ContainsKey(key)) return;`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`EventLive.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: EventLive.Remove(key);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`EventRequests.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: EventRequests.Remove(key);`
- `System.Func<TResult>.Invoke()`；输入表达式：`current()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d = current()`
- `System.Func<TResult>.Invoke()`；输入表达式：`current()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = current()`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30)`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`thoughts.Append(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: thoughts.Append(chunk);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new System.Text.StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new System.Text.StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`thoughts.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: latest.Reasoning = thoughts.ToString()`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`cancel.Token.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.Token.ThrowIfCancellationRequested();`
- `System.Threading.CancellationTokenSource.CancellationTokenSource(System.TimeSpan)`；输入表达式：`new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30)))`
- `System.TimeSpan.FromMinutes(long)`；输入表达式：`TimeSpan.FromMinutes(Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30))`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromMinutes(Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30))`
- `Update(bool)`；输入表达式：`Update()`；返回值紧邻使用处：`ExpressionStatementSyntax: Update();`
- `Update(bool)`；输入表达式：`Update(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Update(true);`

**赋值（含属性/字段和局部值）：**

- `d` = `current()`
- `EventRequests[key]` = `cancel`
- `latest.Error` = `""`
- `latest.Error` = `error is OperationCanceledException ? "生成已停止，可以重试或跳过。" : FailureReason(error)`
- `latest.Options` = `parser.Options`
- `latest.Reasoning` = `thoughts.ToString()`
- `latest.State` = `"ready"`
- `latest.State` = `latest.Options.Count > 0 ? "ready" : "failed"`
- `latest.Story` = `parser.Story`
- `latest.Title` = `parser.Title`
- `phase` = `"等待响应"`
- `phase` = `"正在书写"`
- `phase` = `"正在思考"`

<a id="symbol-3cf611dddd72"></a>

## `Update(bool) — void Update(bool force = false)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`NationalSpire.EventLive.EventLive(string, string, int)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.EventLive`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.EventLive.Choices`；`NationalSpire.EventLive.Phase`；`NationalSpire.EventLive.Reasoning`；`NationalSpire.RandomEventParser.LiveStory`；`NationalSpire.RandomEventParser.Options`；`NationalSpire.RandomEventParser.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("event.progress", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("event.progress", error);`
- `NationalSpire.EventLive.EventLive(string, string, int)`；输入表达式：`new EventLive(parser.Title, parser.LiveStory, parser.Options.Count)                 { Choices = parser.Options.ToList(), Reasoning = thoughts.ToString(), Phase = phase }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new EventLive(parser.Title, parser.LiveStory, parser.Options.Count)                 { Choices = parser.Options.ToList(), Reasoning = thoughts.ToString(), Phase = phase }`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(live)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: progress?.Invoke(live)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`parser.Options.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Choices = parser.Options.ToList()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`thoughts.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Reasoning = thoughts.ToString()`

**赋值（含属性/字段和局部值）：**

- `Choices` = `parser.Options.ToList()`
- `EventLive[key]` = `live`
- `last` = `Environment.TickCount64`
- `Phase` = `phase`
- `Reasoning` = `thoughts.ToString()`
