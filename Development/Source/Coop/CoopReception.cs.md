# Coop/CoopReception.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`C4224F987239169B3CA1BA5754B118C2BD89DB3ECD63CEDF15961698AFB1A69F`。来源：[源码](../../../Coop/CoopReception.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopCoordinator`、`NationalSpire.Coop.CoopCoordinator.ReceivedWork`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Queue<ReceivedWork> _received = [];
private readonly CancellationTokenSource _receiveLifetime = new();
private int _viewReaders;
private (CoopWorld Source, CareerData Data)? _preparedView;
```

<a id="symbol-18b20e1b65f4"></a>

## `NationalSpire.Coop.CoopCoordinator.Receiving — public bool Receiving`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._received`；`NationalSpire.Coop.CoopCoordinator.Host`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a04d6dd348f0"></a>

## `NationalSpire.Coop.CoopCoordinator.RegisterView() — internal void RegisterView()`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.CoopCareerSession(NationalSpire.Coop.CoopCoordinator, Godot.Control)`](CoopCareerSession.cs.md#symbol-be42258ccf13)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._viewReaders`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f6a14f83383d"></a>

## `NationalSpire.Coop.CoopCoordinator.UnregisterView() — internal void UnregisterView()`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.Dispose()`](CoopCareerSession.cs.md#symbol-d673a0c6f401)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._preparedView`；`NationalSpire.Coop.CoopCoordinator._viewReaders`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_preparedView` = `null`

<a id="symbol-242ad3af3c89"></a>

## `NationalSpire.Coop.CoopCoordinator.InterfaceView() — internal CareerData InterfaceView()`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.Refresh()`](CoopCareerSession.cs.md#symbol-d972d69103cb)

**调用：** [`NationalSpire.Coop.CoopRules.InterfaceView(NationalSpire.Coop.CoopWorld, ulong)`](CoopRules.cs.md#symbol-c23013f591a9)；`object.ReferenceEquals(object?, object?)`

**字段、属性、事件及方法组引用：** `(NationalSpire.Coop.CoopWorld Source, NationalSpire.CareerData Data).Data`；`(NationalSpire.Coop.CoopWorld Source, NationalSpire.CareerData Data).Source`；`NationalSpire.Coop.CoopCoordinator._preparedView`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRules.InterfaceView(NationalSpire.Coop.CoopWorld, ulong)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopRules.InterfaceView(NationalSpire.Coop.CoopWorld, ulong)`；输入表达式：`CoopRules.InterfaceView(World!, Self)`；返回值紧邻使用处：`ReturnStatementSyntax: return CoopRules.InterfaceView(World!, Self);`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(ready.Source, World)`；返回值紧邻使用处：`BinaryExpressionSyntax: _preparedView is { } ready && ReferenceEquals(ready.Source, World)`

**赋值（含属性/字段和局部值）：**

- `_preparedView` = `null`

<a id="symbol-1cfc8ada58bd"></a>

## `NationalSpire.Coop.CoopCoordinator.WaitForReceived() — public Task WaitForReceived()`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.Export()`](CoopCareerSession.cs.md#symbol-24a80da4bec4)；[`NationalSpire.Coop.CoopNativeRun.BeginRun()`](CoopNativeRun.cs.md#symbol-77d1b0a8ef74)；[`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)；[`NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`](CoopNativeRun.cs.md#symbol-2d3e3dcdd4d4)

**调用：** `NationalSpire.Coop.CoopCoordinator.ReceivedWork.ReceivedWork(System.Func<bool>, System.Action?, System.Action?, bool)`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Threading.CancellationToken.CancellationToken(bool)`；`System.Threading.Tasks.Task.FromCanceled(System.Threading.CancellationToken)`；`System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource(System.Threading.Tasks.TaskCreationOptions)`；`System.Threading.Tasks.TaskCompletionSource.TrySetCanceled()`；`System.Threading.Tasks.TaskCompletionSource.TrySetResult()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._received`；`NationalSpire.Coop.CoopCoordinator.Receiving`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.ReceivedWork.ReceivedWork(System.Func<bool>, System.Action?, System.Action?, bool)`；输入表达式：`new(() => true, () => done.TrySetResult(), () => done.TrySetCanceled())`；返回值紧邻使用处：`ArgumentSyntax: new(() => true, () => done.TrySetResult(), () => done.TrySetCanceled())`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_received.Enqueue(new(() => true, () => done.TrySetResult(), () => done.TrySetCanceled()))`；返回值紧邻使用处：`ExpressionStatementSyntax: _received.Enqueue(new(() => true, () => done.TrySetResult(), () => done.TrySetCanceled()));`
- `System.Threading.CancellationToken.CancellationToken(bool)`；输入表达式：`new CancellationToken(true)`；返回值紧邻使用处：`ArgumentSyntax: new CancellationToken(true)`
- `System.Threading.Tasks.Task.FromCanceled(System.Threading.CancellationToken)`；输入表达式：`Task.FromCanceled(new CancellationToken(true))`；返回值紧邻使用处：`ReturnStatementSyntax: return Task.FromCanceled(new CancellationToken(true));`
- `System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource(System.Threading.Tasks.TaskCreationOptions)`；输入表达式：`new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously)`
- `System.Threading.Tasks.TaskCompletionSource.TrySetCanceled()`；输入表达式：`done.TrySetCanceled()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => done.TrySetCanceled()`
- `System.Threading.Tasks.TaskCompletionSource.TrySetResult()`；输入表达式：`done.TrySetResult()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => done.TrySetResult()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f7e7dbbfc94b"></a>

## `NationalSpire.Coop.CoopCoordinator.ApplyReceived(System.Action) — public void ApplyReceived(Action action)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.PlayerChanged(NationalSpire.Coop.NativeLobbyApi.Member, bool)`](CoopNativeRun.cs.md#symbol-9053b1c2c84a)

**调用：** [`Apply()`](CoopReception.cs.md#symbol-c9dfe775555c)；`NationalSpire.Coop.CoopCoordinator.ReceivedWork.ReceivedWork(System.Func<bool>, System.Action?, System.Action?, bool)`；`System.Collections.Generic.Queue<T>.Enqueue(T)`

**字段、属性、事件及方法组引用：** `Apply()`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._received`；`NationalSpire.Coop.CoopCoordinator.Receiving`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Apply()`；输入表达式：`Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply();`
- `NationalSpire.Coop.CoopCoordinator.ReceivedWork.ReceivedWork(System.Func<bool>, System.Action?, System.Action?, bool)`；输入表达式：`new(() => true, Apply)`；返回值紧邻使用处：`ArgumentSyntax: new(() => true, Apply)`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_received.Enqueue(new(() => true, Apply))`；返回值紧邻使用处：`ExpressionStatementSyntax: _received.Enqueue(new(() => true, Apply));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c9dfe775555c"></a>

## `Apply() — void Apply()`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.ApplyReceived(System.Action)`](CoopReception.cs.md#symbol-f7e7dbbfc94b)

**调用：** `System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._preparedView`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`

**赋值（含属性/字段和局部值）：**

- `_preparedView` = `null`

<a id="symbol-ebee1cc829c5"></a>

## `NationalSpire.Coop.CoopCoordinator.SubmitReady(NationalSpire.Coop.CoopCommand, System.Action<NationalSpire.Coop.CoopCommand>, System.Action<System.Exception>) — public void SubmitReady(CoopCommand intent, Action<CoopCommand> sending, Action<Exception> failed)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.Send(string, string, string, int, string, System.Action?)`](CoopCareerSession.cs.md#symbol-b761b96e0df4)；[`NationalSpire.Coop.CoopCoordinator.Submit(string, string, string, int, string)`](CoopCoordinator.cs.md#symbol-d7ec39d842f3)；[`NationalSpire.Coop.CoopScreen.Submit(string, string)`](CoopScreen.cs.md#symbol-9efdcfdc1723)

**调用：** [`Submit()`](CoopReception.cs.md#symbol-690f4f77e4f1)；`NationalSpire.Coop.CoopCoordinator.ReceivedWork.ReceivedWork(System.Func<bool>, System.Action?, System.Action?, bool)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.OperationCanceledException.OperationCanceledException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._received`；`NationalSpire.Coop.CoopCoordinator.Receiving`；`Submit()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.ReceivedWork.ReceivedWork(System.Func<bool>, System.Action?, System.Action?, bool)`；输入表达式：`new(() => true, Submit, () => failed(new OperationCanceledException("房间已断开，请返回队伍重新加入。")))`；返回值紧邻使用处：`ArgumentSyntax: new(() => true, Submit, () => failed(new OperationCanceledException("房间已断开，请返回队伍重新加入。")))`
- `Submit()`；输入表达式：`Submit()`；返回值紧邻使用处：`ExpressionStatementSyntax: Submit();`
- `System.Action<T>.Invoke(T)`；输入表达式：`failed(new OperationCanceledException("房间已断开，请返回队伍重新加入。"))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => failed(new OperationCanceledException("房间已断开，请返回队伍重新加入。"))`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_received.Enqueue(new(() => true, Submit, () => failed(new OperationCanceledException("房间已断开，请返回队伍重新加入。"))))`；返回值紧邻使用处：`ExpressionStatementSyntax: _received.Enqueue(new(() => true, Submit, () => failed(new OperationCanceledException("房间已断开，请返回队伍重新加入。"))));`
- `System.OperationCanceledException.OperationCanceledException(string?)`；输入表达式：`new OperationCanceledException("房间已断开，请返回队伍重新加入。")`；返回值紧邻使用处：`ArgumentSyntax: new OperationCanceledException("房间已断开，请返回队伍重新加入。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-690f4f77e4f1"></a>

## `Submit() — void Submit()`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.SubmitReady(NationalSpire.Coop.CoopCommand, System.Action<NationalSpire.Coop.CoopCommand>, System.Action<System.Exception>)`](CoopReception.cs.md#symbol-ebee1cc829c5)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-11ae699cefda)；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCommand.Epoch`；`NationalSpire.Coop.CoopCommand.Revision`；`NationalSpire.Coop.CoopCommand.World`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`；输入表达式：`Retry(command)`；返回值紧邻使用处：`ExpressionStatementSyntax: Retry(command);`
- `System.Action<T>.Invoke(T)`；输入表达式：`failed(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: failed(error);`
- `System.Action<T>.Invoke(T)`；输入表达式：`sending(command)`；返回值紧邻使用处：`ExpressionStatementSyntax: sending(command);`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("房间会话已改变，请重新操作。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("房间会话已改变，请重新操作。");`

**赋值（含属性/字段和局部值）：**

- `Revision` = `World.Revision`

<a id="symbol-a09fec904cc1"></a>

## `NationalSpire.Coop.CoopCoordinator.PumpReceived() — private void PumpReceived()`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)

**调用：** [`NationalSpire.Coop.CoopCoordinator.ReceiveError(System.Exception)`](CoopReception.cs.md#symbol-fb570e3c7ba0)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](../UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.TryPeek(out T)`；`System.Diagnostics.Stopwatch.GetElapsedTime(long)`；`System.Diagnostics.Stopwatch.GetTimestamp()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._received`；`NationalSpire.Coop.CoopCoordinator.ReceivedWork.Finished`；`NationalSpire.Coop.CoopCoordinator.ReceivedWork.Snapshot`；`NationalSpire.Coop.CoopCoordinator.ReceivedWork.Step`；`NationalSpire.Coop.CoopCoordinator.ReceiveError(System.Exception)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CoopReceive`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.ReceiveError(System.Exception)`；输入表达式：`ReceiveError(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: ReceiveError(error);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopReceive)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CoopReceive)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: work.Finished?.Invoke()`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`_received.Dequeue()`；返回值紧邻使用处：`ExpressionStatementSyntax: _received.Dequeue();`
- `System.Collections.Generic.Queue<T>.TryPeek(out T)`；输入表达式：`_received.TryPeek(out var work)`；返回值紧邻使用处：`BinaryExpressionSyntax: !_closed && _received.TryPeek(out var work)`
- `System.Diagnostics.Stopwatch.GetElapsedTime(long)`；输入表达式：`Stopwatch.GetElapsedTime(started)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Stopwatch.GetElapsedTime(started).TotalMilliseconds`
- `System.Diagnostics.Stopwatch.GetTimestamp()`；输入表达式：`Stopwatch.GetTimestamp()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Stopwatch.GetTimestamp()`
- `System.Func<TResult>.Invoke()`；输入表达式：`work.Step()`；返回值紧邻使用处：`AssignmentExpressionSyntax: complete = work.Step()`

**赋值（含属性/字段和局部值）：**

- `complete` = `true`
- `complete` = `work.Step()`

<a id="symbol-fb570e3c7ba0"></a>

## `NationalSpire.Coop.CoopCoordinator.ReceiveError(System.Exception) — private void ReceiveError(Exception error)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.PumpReceived()`](CoopReception.cs.md#symbol-a09fec904cc1)；[`NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-892f19740afa)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.Changed`；`NationalSpire.Coop.CoopCoordinator.Status`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.receive", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.receive", error);`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Changed?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `Status` = `"同步操作失败：" + error.Message`

<a id="symbol-15289643ead0"></a>

## `NationalSpire.Coop.CoopCoordinator.QueueSnapshot(ulong, NationalSpire.Coop.CoopAssembler.Complete) — private void QueueSnapshot(ulong sender, CoopAssembler.Complete complete)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-892f19740afa)

**调用：** [`NationalSpire.Coop.CoopCoordinator.CompleteReplies()`](CoopCoordinator.cs.md#symbol-4f91858a07d3)；`NationalSpire.Coop.CoopCoordinator.ReceivedWork.ReceivedWork(System.Func<bool>, System.Action?, System.Action?, bool)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.Queue<T>.Enqueue(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._received`；`NationalSpire.Coop.CoopCoordinator.Changed`；`NationalSpire.Coop.CoopCoordinator.CompleteReplies()`；`Step()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.CompleteReplies()`；输入表达式：`CompleteReplies()`；返回值紧邻使用处：`ExpressionStatementSyntax: CompleteReplies();`
- `NationalSpire.Coop.CoopCoordinator.ReceivedWork.ReceivedWork(System.Func<bool>, System.Action?, System.Action?, bool)`；输入表达式：`new(Step, () => { if (published) { CompleteReplies(); Changed?.Invoke(); } }, Snapshot: true)`；返回值紧邻使用处：`ArgumentSyntax: new(Step, () => { if (published) { CompleteReplies(); Changed?.Invoke(); } }, Snapshot: true)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Changed?.Invoke()`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_received.Enqueue(new(Step, () => { if (published) { CompleteReplies(); Changed?.Invoke(); } }, Snapshot: true))`；返回值紧邻使用处：`ExpressionStatementSyntax: _received.Enqueue(new(Step, () => { if (published) { CompleteReplies(); Changed?.Invoke(); } }, Snapshot: true));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-41b14a0db411"></a>

## `Step() — bool Step()`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopAssembler.Complete.Decode()`](CoopWire.cs.md#symbol-3bc9f4a00527)；[`NationalSpire.Coop.CoopCoordinator.SaveReceived(NationalSpire.Coop.CoopSnapshot, bool, ulong)`](CoopReception.cs.md#symbol-a9de6eef033e)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；[`NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`](../GroupChats.cs.md#symbol-85bf6e1105fe)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](../UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Runtime.CompilerServices.TaskAwaiter<TResult>.GetResult()`；`System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>, System.Threading.CancellationToken)`；`System.Threading.Tasks.Task<TResult>.GetAwaiter()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.GroupLive`；`NationalSpire.AiService.GroupReasoningLive`；`NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.Coop.CoopAssembler.Complete.Decode()`；`NationalSpire.Coop.CoopCoordinator._preparedView`；`NationalSpire.Coop.CoopCoordinator._receiveLifetime`；`NationalSpire.Coop.CoopCoordinator._seen`；`NationalSpire.Coop.CoopCoordinator._viewReaders`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.SaveReceived(NationalSpire.Coop.CoopSnapshot, bool, ulong)`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Status`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopSnapshot.Run`；`NationalSpire.Coop.CoopSnapshot.World`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.Schema`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CoopDecode`；`NationalSpire.UiPerformance.Work.CoopPublish`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.Complete.Decode()`；输入表达式：`complete.Decode()`；返回值紧邻使用处：`ArgumentSyntax: complete.Decode()`
- `NationalSpire.Coop.CoopCoordinator.SaveReceived(NationalSpire.Coop.CoopSnapshot, bool, ulong)`；输入表达式：`SaveReceived(snapshot, prepare, Self)`；返回值紧邻使用处：`AssignmentExpressionSyntax: saving = SaveReceived(snapshot, prepare, Self)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(World.World);`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<CoopSnapshot>(complete.Decode())`；返回值紧邻使用处：`ReturnStatementSyntax: return CoopJson.Read<CoopSnapshot>(complete.Decode());`
- `NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`；输入表达式：`GroupChats.Busy(g)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.Busy(g)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopDecode)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CoopDecode)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopPublish)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CoopPublish)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`AiService.GroupLive.Remove(World.Id + "/group/" + group.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiService.GroupLive.Remove(World.Id + "/group/" + group.Id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`AiService.GroupReasoningLive.Remove(World.Id + "/group/" + group.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiService.GroupReasoningLive.Remove(World.Id + "/group/" + group.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`snapshot.World.Members.Any(m => m.SteamId == Self)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !snapshot.World.Members.Any(m => m.SteamId == Self)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.World.Chats.Groups.Where(g => !GroupChats.Busy(g))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var group in World.World.Chats.Groups.Where(g => !GroupChats.Busy(g)))             { AiService.GroupLive.Remove(World.Id + "/group/" + group.Id); AiService.GroupReasoningLive.Remove(World.Id + "/group/" + group.Id); }`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("存档成员不匹配。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("存档成员不匹配。");`
- `System.Runtime.CompilerServices.TaskAwaiter<TResult>.GetResult()`；输入表达式：`decoding.GetAwaiter().GetResult()`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot = decoding.GetAwaiter().GetResult()`
- `System.Runtime.CompilerServices.TaskAwaiter<TResult>.GetResult()`；输入表达式：`saving.GetAwaiter().GetResult()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = saving.GetAwaiter().GetResult()`
- `System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>, System.Threading.CancellationToken)`；输入表达式：`Task.Run(() =>                 { using var timing = UiPerformance.Measure(UiPerformance.Work.CoopDecode); return CoopJson.Read<CoopSnapshot>(complete.Decode()); }, _receiveLifetime.Token)`；返回值紧邻使用处：`AssignmentExpressionSyntax: decoding = Task.Run(() =>                 { using var timing = UiPerformance.Measure(UiPerformance.Work.CoopDecode); return CoopJson.Read<CoopSnapshot>(complete.Decode()); }, _receiveLifetime.Token)`
- `System.Threading.Tasks.Task<TResult>.GetAwaiter()`；输入表达式：`decoding.GetAwaiter()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: decoding.GetAwaiter().GetResult`
- `System.Threading.Tasks.Task<TResult>.GetAwaiter()`；输入表达式：`saving.GetAwaiter()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: saving.GetAwaiter().GetResult`

**赋值（含属性/字段和局部值）：**

- `_preparedView` = `prepare && view != null ? (World, view) : null`
- `_seen[sender]` = `DateTime.UtcNow`
- `decoding` = `Task.Run(() =>                 { using var timing = UiPerformance.Measure(UiPerformance.Work.CoopDecode); return CoopJson.Read<CoopSnapshot>(complete.Decode()); }, _receiveLifetime.Token)`
- `NativeSave` = `snapshot.Run`
- `prepare` = `_viewReaders > 0`
- `published` = `true`
- `saving` = `SaveReceived(snapshot, prepare, Self)`
- `snapshot` = `decoding.GetAwaiter().GetResult()`
- `Status` = `"已同步"`
- `World` = `snapshot.World`

<a id="symbol-a9de6eef033e"></a>

## `NationalSpire.Coop.CoopCoordinator.SaveReceived(NationalSpire.Coop.CoopSnapshot, bool, ulong) — private async Task<CareerData?> SaveReceived(CoopSnapshot snapshot, bool prepare, ulong self)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Step()`](CoopReception.cs.md#symbol-41b14a0db411)

**调用：** [`NationalSpire.Coop.CoopRules.InterfaceView(NationalSpire.Coop.CoopWorld, ulong)`](CoopRules.cs.md#symbol-c23013f591a9)；[`NationalSpire.Coop.CoopStorage.SaveAsync(NationalSpire.Coop.CoopWorld, byte[]?, System.Threading.CancellationToken)`](CoopStorage.cs.md#symbol-26bf729f0b72)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](../UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Threading.Tasks.Task.ConfigureAwait(System.Threading.Tasks.ConfigureAwaitOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._receiveLifetime`；`NationalSpire.Coop.CoopCoordinator._storage`；`NationalSpire.Coop.CoopRules.InterfaceView(NationalSpire.Coop.CoopWorld, ulong)`；`NationalSpire.Coop.CoopSnapshot.Run`；`NationalSpire.Coop.CoopSnapshot.World`；`NationalSpire.Coop.CoopStorage.SaveAsync(NationalSpire.Coop.CoopWorld, byte[]?, System.Threading.CancellationToken)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CoopPrepareView`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopRules.InterfaceView(NationalSpire.Coop.CoopWorld, ulong)`；输入表达式：`CoopRules.InterfaceView(snapshot.World, self)`；返回值紧邻使用处：`ReturnStatementSyntax: return CoopRules.InterfaceView(snapshot.World, self);`
- `NationalSpire.Coop.CoopStorage.SaveAsync(NationalSpire.Coop.CoopWorld, byte[]?, System.Threading.CancellationToken)`；输入表达式：`_storage.SaveAsync(snapshot.World, snapshot.Run, _receiveLifetime.Token)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _storage.SaveAsync(snapshot.World, snapshot.Run, _receiveLifetime.Token).ConfigureAwait`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.view.prepare", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.view.prepare", error);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopPrepareView)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CoopPrepareView)`
- `System.Threading.Tasks.Task.ConfigureAwait(System.Threading.Tasks.ConfigureAwaitOptions)`；输入表达式：`_storage.SaveAsync(snapshot.World, snapshot.Run, _receiveLifetime.Token).ConfigureAwait(ConfigureAwaitOptions.ForceYielding)`；返回值紧邻使用处：`AwaitExpressionSyntax: await _storage.SaveAsync(snapshot.World, snapshot.Run, _receiveLifetime.Token).ConfigureAwait(ConfigureAwaitOptions.ForceYielding)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5e40e274e59c"></a>

## `NationalSpire.Coop.CoopCoordinator.CloseReceived() — private void CloseReceived()`

来源：源码第 124 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Dispose()`](CoopCoordinator.cs.md#symbol-a57b33d7004f)

**调用：** `System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.Queue<T>.TryDequeue(out T)`；`System.Threading.CancellationTokenSource.Cancel()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._preparedView`；`NationalSpire.Coop.CoopCoordinator._received`；`NationalSpire.Coop.CoopCoordinator._receiveLifetime`；`NationalSpire.Coop.CoopCoordinator.ReceivedWork.Cancelled`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: work.Cancelled?.Invoke()`
- `System.Collections.Generic.Queue<T>.TryDequeue(out T)`；输入表达式：`_received.TryDequeue(out var work)`；返回值紧邻使用处：`WhileStatementSyntax: while (_received.TryDequeue(out var work)) work.Cancelled?.Invoke();`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`_receiveLifetime.Cancel()`；返回值紧邻使用处：`ExpressionStatementSyntax: _receiveLifetime.Cancel();`

**赋值（含属性/字段和局部值）：**

- `_preparedView` = `null`
