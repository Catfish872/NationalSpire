# StartDiagnostics.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`CC8F39BD73C37C8DA9E179C934DCCC97C8C2E4FA5FA2CBF395FFE4524E6718E0`。来源：[源码](../../StartDiagnostics.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.StartDiagnostics`、`NationalSpire.StartMethodDiagnosticsPatch`、`NationalSpire.StartSessionDiagnosticsPatch`、`NationalSpire.StartResourceRequestDiagnosticsPatch`、`NationalSpire.StartResourceStatusDiagnosticsPatch`、`NationalSpire.StartResourceGetDiagnosticsPatch`、`NationalSpire.StartResourceSyncDiagnosticsPatch`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Stopwatch _clock = Stopwatch.StartNew();
private readonly string _attempt = Guid.NewGuid().ToString("N");
private readonly object _context;
private readonly Dictionary<string, int> _resources = [];
private readonly HashSet<MethodBase> _methods = [];
private readonly HashSet<object> _sessions = [];
private readonly object _gate = new();
private readonly StartDiagnostics? _previous;
private string? _stage;
private bool _finished;
```

<a id="symbol-f6ebc2cf6932"></a>

## `NationalSpire.StartDiagnostics.Current — internal static StartDiagnostics? Current`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2a19f756d610"></a>

## `NationalSpire.StartDiagnostics.StartDiagnostics(NationalSpire.CareerData, NationalSpire.CareerMatch, string, int) — internal StartDiagnostics(CareerData data, CareerMatch match, string character, int ascension)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.StartDiagnostics.Write(string, object?)`](StartDiagnostics.cs.md#symbol-7005259dbbc6)

**字段、属性、事件及方法组引用：** `<anonymous type: string WorldId, int Season, int Day, string Id, string Seed, string character, int ascension, string decision, bool? retry, string PendingMatchId>.decision`；`<anonymous type: string WorldId, int Season, int Day, string Id, string Seed, string character, int ascension, string decision, bool? retry, string PendingMatchId>.retry`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.FailureDecision.Attempt`；`NationalSpire.FailureDecision.RetryRequested`；`NationalSpire.StartDiagnostics._context`；`NationalSpire.StartDiagnostics._previous`；`NationalSpire.StartDiagnostics.Current`；`NationalSpire.StartDiagnostics.Write(string, object?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Write(string, object?)`；输入表达式：`Write("begin", null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("begin", null);`

**赋值（含属性/字段和局部值）：**

- `_context` = `new { data.WorldId, data.Season, data.Day, match.Id, match.Seed, character, ascension,             decision = data.Failure?.Attempt, retry = data.Failure?.RetryRequested, data.PendingMatchId }`
- `_previous` = `Current`
- `Current` = `this`

<a id="symbol-7005259dbbc6"></a>

## `NationalSpire.StartDiagnostics.Write(string, object?) — internal void Write(string phase, object? detail)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.StartDiagnostics.Dispose()`](StartDiagnostics.cs.md#symbol-d25ec7607436)；[`NationalSpire.StartDiagnostics.Finish(string?)`](StartDiagnostics.cs.md#symbol-a9ee66195dc4)；[`NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?)`](StartDiagnostics.cs.md#symbol-1a5c177ce877)；[`NationalSpire.StartDiagnostics.Resource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-e577b991ddf0)；[`NationalSpire.StartDiagnostics.Session(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`](StartDiagnostics.cs.md#symbol-a410c399943e)；[`NationalSpire.StartDiagnostics.Stage(string)`](StartDiagnostics.cs.md#symbol-6350d395f8c5)；[`NationalSpire.StartDiagnostics.StartDiagnostics(NationalSpire.CareerData, NationalSpire.CareerMatch, string, int)`](StartDiagnostics.cs.md#symbol-2a19f756d610)

**调用：** [`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)

**字段、属性、事件及方法组引用：** `<anonymous type: string attempt, double elapsedMs, object context, string phase, string stage, object detail>.attempt`；`<anonymous type: string attempt, double elapsedMs, object context, string phase, string stage, object detail>.context`；`<anonymous type: string attempt, double elapsedMs, object context, string phase, string stage, object detail>.elapsedMs`；`<anonymous type: string attempt, double elapsedMs, object context, string phase, string stage, object detail>.stage`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.StartDiagnostics._attempt`；`NationalSpire.StartDiagnostics._clock`；`NationalSpire.StartDiagnostics._context`；`NationalSpire.StartDiagnostics._stage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.start.progress", new { attempt = _attempt, elapsedMs = _clock.Elapsed.TotalMilliseconds,             context = _context, phase, stage = _stage, detail })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Diagnostics.Record("match.start.progress", new { attempt = _attempt, elapsedMs = _clock.Elapsed.TotalMilliseconds,             context = _context, phase, stage = _stage, detail })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-177465fb0711"></a>

## `NationalSpire.StartDiagnostics.Capture(System.Action) — internal static void Capture(Action action)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.StartDiagnostics.CaptureMethod(System.Reflection.MethodBase, string, System.Exception?)`](StartDiagnostics.cs.md#symbol-c59bb8ad3a48)；[`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)；[`NationalSpire.StartDiagnostics.CaptureSession(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`](StartDiagnostics.cs.md#symbol-e9bb286f7938)；[`NationalSpire.StartDiagnostics.CaptureTask(System.Reflection.MethodBase, System.Threading.Tasks.Task)`](StartDiagnostics.cs.md#symbol-8b75fc5d1ba4)；[`NationalSpire.StartDiagnostics.Observe(System.Reflection.MethodBase, System.Threading.Tasks.Task)`](StartDiagnostics.cs.md#symbol-926d639dd30b)；[`NationalSpire.StartDiagnostics.Session(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`](StartDiagnostics.cs.md#symbol-a410c399943e)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("match.start.observer", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("match.start.observer", error);`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bae16b31099c"></a>

## `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?) — internal void CaptureResource(string path, string phase, int? state = null, Exception? error = null)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.StartResourceGetDiagnosticsPatch.Finalizer(string, System.Exception?)`](StartDiagnostics.cs.md#symbol-d7d59662b518)；[`NationalSpire.StartResourceGetDiagnosticsPatch.Postfix(string)`](StartDiagnostics.cs.md#symbol-7fc57e0d38ac)；[`NationalSpire.StartResourceGetDiagnosticsPatch.Prefix(string)`](StartDiagnostics.cs.md#symbol-2d7ec5da300d)；[`NationalSpire.StartResourceRequestDiagnosticsPatch.Finalizer(string, System.Exception?)`](StartDiagnostics.cs.md#symbol-a63ddd781bb0)；[`NationalSpire.StartResourceRequestDiagnosticsPatch.Postfix(string, Godot.Error)`](StartDiagnostics.cs.md#symbol-9722b034455c)；[`NationalSpire.StartResourceRequestDiagnosticsPatch.Prefix(string)`](StartDiagnostics.cs.md#symbol-5dc012af6ba4)；[`NationalSpire.StartResourceStatusDiagnosticsPatch.Postfix(string, Godot.ResourceLoader.ThreadLoadStatus)`](StartDiagnostics.cs.md#symbol-3759e73d203e)；[`NationalSpire.StartResourceSyncDiagnosticsPatch.Finalizer(string, System.Exception?)`](StartDiagnostics.cs.md#symbol-eb23ff3a95e1)；[`NationalSpire.StartResourceSyncDiagnosticsPatch.Postfix(string)`](StartDiagnostics.cs.md#symbol-e66d9baef666)；[`NationalSpire.StartResourceSyncDiagnosticsPatch.Prefix(string)`](StartDiagnostics.cs.md#symbol-d54051f563c6)

**调用：** [`NationalSpire.StartDiagnostics.Capture(System.Action)`](StartDiagnostics.cs.md#symbol-177465fb0711)；[`NationalSpire.StartDiagnostics.Resource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-e577b991ddf0)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.Capture(System.Action)`；`NationalSpire.StartDiagnostics.Resource(string, string, int?, System.Exception?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Capture(System.Action)`；输入表达式：`Capture(() => Resource(path, phase, state, error))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Capture(() => Resource(path, phase, state, error))`
- `NationalSpire.StartDiagnostics.Resource(string, string, int?, System.Exception?)`；输入表达式：`Resource(path, phase, state, error)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Resource(path, phase, state, error)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c59bb8ad3a48"></a>

## `NationalSpire.StartDiagnostics.CaptureMethod(System.Reflection.MethodBase, string, System.Exception?) — internal void CaptureMethod(MethodBase method, string phase, Exception? error = null)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.StartMethodDiagnosticsPatch.Finalizer(System.Reflection.MethodBase, System.Exception?, NationalSpire.StartDiagnostics?)`](StartDiagnostics.cs.md#symbol-76f3342448ee)；[`NationalSpire.StartMethodDiagnosticsPatch.Prefix(System.Reflection.MethodBase, out NationalSpire.StartDiagnostics?)`](StartDiagnostics.cs.md#symbol-79ee36993a13)

**调用：** [`NationalSpire.StartDiagnostics.Capture(System.Action)`](StartDiagnostics.cs.md#symbol-177465fb0711)；[`NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?)`](StartDiagnostics.cs.md#symbol-1a5c177ce877)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.Capture(System.Action)`；`NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Capture(System.Action)`；输入表达式：`Capture(() => Method(method, phase, error))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Capture(() => Method(method, phase, error))`
- `NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?)`；输入表达式：`Method(method, phase, error)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Method(method, phase, error)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e9bb286f7938"></a>

## `NationalSpire.StartDiagnostics.CaptureSession(MegaCrit.Sts2.Core.Assets.AssetLoadingSession) — internal void CaptureSession(AssetLoadingSession session)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.StartSessionDiagnosticsPatch.Prefix(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`](StartDiagnostics.cs.md#symbol-b050e302cc31)

**调用：** [`NationalSpire.StartDiagnostics.Capture(System.Action)`](StartDiagnostics.cs.md#symbol-177465fb0711)；[`NationalSpire.StartDiagnostics.Session(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`](StartDiagnostics.cs.md#symbol-a410c399943e)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.Capture(System.Action)`；`NationalSpire.StartDiagnostics.Session(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Capture(System.Action)`；输入表达式：`Capture(() => Session(session))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Capture(() => Session(session))`
- `NationalSpire.StartDiagnostics.Session(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`；输入表达式：`Session(session)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Session(session)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8b75fc5d1ba4"></a>

## `NationalSpire.StartDiagnostics.CaptureTask(System.Reflection.MethodBase, System.Threading.Tasks.Task) — internal void CaptureTask(MethodBase method, Task task)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.StartMethodDiagnosticsPatch.Postfix(System.Reflection.MethodBase, System.Threading.Tasks.Task, NationalSpire.StartDiagnostics?)`](StartDiagnostics.cs.md#symbol-5deefec5ae67)

**调用：** [`NationalSpire.StartDiagnostics.Capture(System.Action)`](StartDiagnostics.cs.md#symbol-177465fb0711)；[`NationalSpire.StartDiagnostics.Observe(System.Reflection.MethodBase, System.Threading.Tasks.Task)`](StartDiagnostics.cs.md#symbol-926d639dd30b)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.Capture(System.Action)`；`NationalSpire.StartDiagnostics.Observe(System.Reflection.MethodBase, System.Threading.Tasks.Task)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Capture(System.Action)`；输入表达式：`Capture(() => Observe(method, task))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Capture(() => Observe(method, task))`
- `NationalSpire.StartDiagnostics.Observe(System.Reflection.MethodBase, System.Threading.Tasks.Task)`；输入表达式：`Observe(method, task)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Observe(method, task)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6350d395f8c5"></a>

## `NationalSpire.StartDiagnostics.Stage(string) — internal void Stage(string stage)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.StartDiagnostics.Write(string, object?)`](StartDiagnostics.cs.md#symbol-7005259dbbc6)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics._stage`；`NationalSpire.StartDiagnostics.Write(string, object?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Write(string, object?)`；输入表达式：`Write("stage-begin", null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("stage-begin", null);`
- `NationalSpire.StartDiagnostics.Write(string, object?)`；输入表达式：`Write("stage-complete", null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("stage-complete", null);`

**赋值（含属性/字段和局部值）：**

- `_stage` = `stage`

<a id="symbol-a9ee66195dc4"></a>

## `NationalSpire.StartDiagnostics.Finish(string?) — internal string? Finish(string? error)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.StartDiagnostics.Write(string, object?)`](StartDiagnostics.cs.md#symbol-7005259dbbc6)；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `<anonymous type: string error, string[] pendingResources, int sessions>.pendingResources`；`<anonymous type: string error, string[] pendingResources, int sessions>.sessions`；`NationalSpire.StartDiagnostics._finished`；`NationalSpire.StartDiagnostics._gate`；`NationalSpire.StartDiagnostics._resources`；`NationalSpire.StartDiagnostics._sessions`；`NationalSpire.StartDiagnostics.Write(string, object?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Write(string, object?)`；输入表达式：`Write(error == null ? "complete" : "failed", new { error, pendingResources = _resources.Keys.ToArray(), sessions = _sessions.Count })`；返回值紧邻使用处：`ExpressionStatementSyntax: Write(error == null ? "complete" : "failed", new { error, pendingResources = _resources.Keys.ToArray(), sessions = _sessions.Count });`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_resources.Keys.ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: pendingResources = _resources.Keys.ToArray()`

**赋值（含属性/字段和局部值）：**

- `_finished` = `true`

<a id="symbol-f70ffc60dab9"></a>

## `NationalSpire.StartDiagnostics.Used(System.Reflection.MethodBase?) — private void Used(MethodBase? method)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.StartDiagnostics.Session(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`](StartDiagnostics.cs.md#symbol-a410c399943e)

**调用：** [`NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?)`](StartDiagnostics.cs.md#symbol-1a5c177ce877)；`System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics._gate`；`NationalSpire.StartDiagnostics._methods`；`NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?)`；输入表达式：`Method(method, "observed")`；返回值紧邻使用处：`ExpressionStatementSyntax: Method(method, "observed");`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_methods.Contains(method)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_methods.Contains(method)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1a5c177ce877"></a>

## `NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?) — internal void Method(MethodBase method, string phase, Exception? error = null)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.StartDiagnostics.CaptureMethod(System.Reflection.MethodBase, string, System.Exception?)`](StartDiagnostics.cs.md#symbol-c59bb8ad3a48)；[`NationalSpire.StartDiagnostics.Observe(System.Reflection.MethodBase, System.Threading.Tasks.Task)`](StartDiagnostics.cs.md#symbol-926d639dd30b)；[`NationalSpire.StartDiagnostics.Used(System.Reflection.MethodBase?)`](StartDiagnostics.cs.md#symbol-f70ffc60dab9)

**调用：** [`NationalSpire.StartDiagnostics.Write(string, object?)`](StartDiagnostics.cs.md#symbol-7005259dbbc6)；`HarmonyLib.Harmony.GetPatchInfo(System.Reflection.MethodBase)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Exception.ToString()`；`System.Reflection.MemberInfo.GetCustomAttribute<T>()`；`System.Type.GetMethod(string, System.Reflection.BindingFlags)`

**字段、属性、事件及方法组引用：** `<anonymous type: string method, object patches, string exception>.exception`；`<anonymous type: string method, object patches, string exception>.method`；`<anonymous type: string method, string assembly, <anonymous type: string owner, int priority, string[] before, string[] after, string method, string assembly>[] patches>.assembly`；`<anonymous type: string method, string assembly, <anonymous type: string owner, int priority, string[] before, string[] after, string method, string assembly>[] patches>.method`；`<anonymous type: string method, string assembly, <anonymous type: string owner, int priority, string[] before, string[] after, string method, string assembly>[] patches>.patches`；`<anonymous type: string owner, int priority, string[] before, string[] after, string method, string assembly>.assembly`；`<anonymous type: string owner, int priority, string[] before, string[] after, string method, string assembly>.method`；`NationalSpire.StartDiagnostics._gate`；`NationalSpire.StartDiagnostics._methods`；`NationalSpire.StartDiagnostics.Write(string, object?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.Harmony.GetPatchInfo(System.Reflection.MethodBase)`；输入表达式：`Harmony.GetPatchInfo(m)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Harmony.GetPatchInfo(m)`
- `NationalSpire.StartDiagnostics.Write(string, object?)`；输入表达式：`Write("method-" + phase, new { method = method.DeclaringType?.FullName + "." + method.Name, patches, exception = error?.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("method-" + phase, new { method = method.DeclaringType?.FullName + "." + method.Name, patches, exception = error?.ToString() });`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_methods.Add(method)`；返回值紧邻使用处：`IfStatementSyntax: if (_methods.Add(method))             {                 var state = method.GetCustomAttribute<AsyncStateMachineAttribute>()?.StateMachineType.GetMethod("MoveNext", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);                 patches = new[] { method, state }.OfType<MethodBase>().Select(m =>                 {                     var info = Harmony.GetPatchInfo(m);                     return new                     {                         method = m.DeclaringType?.FullName + "." + m.Name,                         assembly = m.DeclaringType?.Assembly.FullName,                         patches = info?.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,                                 assembly = p.PatchMethod.DeclaringType?.Assembly.FullName }).ToArray()                     };                 }).ToArray();             }`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`.Prefixes.Concat(info.Postfixes)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Prefixes.Concat(info.Postfixes).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,                                 assembly = p.PatchMethod.DeclaringType?.Assembly.FullName })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,                                 assembly = p.PatchMethod.DeclaringType?.Assembly.FullName }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`new[] { method, state }.OfType<MethodBase>().Select(m =>                 {                     var info = Harmony.GetPatchInfo(m);                     return new                     {                         method = m.DeclaringType?.FullName + "." + m.Name,                         assembly = m.DeclaringType?.Assembly.FullName,                         patches = info?.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,                                 assembly = p.PatchMethod.DeclaringType?.Assembly.FullName }).ToArray()                     };                 })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { method, state }.OfType<MethodBase>().Select(m =>                 {                     var info = Harmony.GetPatchInfo(m);                     return new                     {                         method = m.DeclaringType?.FullName + "." + m.Name,                         assembly = m.DeclaringType?.Assembly.FullName,                         patches = info?.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,                                 assembly = p.PatchMethod.DeclaringType?.Assembly.FullName }).ToArray()                     };                 }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,                                 assembly = p.PatchMethod.DeclaringType?.Assembly.FullName }).ToArray()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: info?.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,                                 assembly = p.PatchMethod.DeclaringType?.Assembly.FullName }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[] { method, state }.OfType<MethodBase>().Select(m =>                 {                     var info = Harmony.GetPatchInfo(m);                     return new                     {                         method = m.DeclaringType?.FullName + "." + m.Name,                         assembly = m.DeclaringType?.Assembly.FullName,                         patches = info?.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,                                 assembly = p.PatchMethod.DeclaringType?.Assembly.FullName }).ToArray()                     };                 }).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: patches = new[] { method, state }.OfType<MethodBase>().Select(m =>                 {                     var info = Harmony.GetPatchInfo(m);                     return new                     {                         method = m.DeclaringType?.FullName + "." + m.Name,                         assembly = m.DeclaringType?.Assembly.FullName,                         patches = info?.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,                                 assembly = p.PatchMethod.DeclaringType?.Assembly.FullName }).ToArray()                     };                 }).ToArray()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`new[] { method, state }.OfType<MethodBase>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { method, state }.OfType<MethodBase>().Select`
- `System.Exception.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: error?.ToString()`
- `System.Reflection.MemberInfo.GetCustomAttribute<T>()`；输入表达式：`method.GetCustomAttribute<AsyncStateMachineAttribute>()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: method.GetCustomAttribute<AsyncStateMachineAttribute>()?.StateMachineType.GetMethod("MoveNext", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)`
- `System.Type.GetMethod(string, System.Reflection.BindingFlags)`；输入表达式：`.StateMachineType.GetMethod("MoveNext", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: method.GetCustomAttribute<AsyncStateMachineAttribute>()?.StateMachineType.GetMethod("MoveNext", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)`

**赋值（含属性/字段和局部值）：**

- `patches` = `new[] { method, state }.OfType<MethodBase>().Select(m =>                 {                     var info = Harmony.GetPatchInfo(m);                     return new                     {                         method = m.DeclaringType?.FullName + "." + m.Name,                         assembly = m.DeclaringType?.Assembly.FullName,                         patches = info?.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)                             .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,                                 assembly = p.PatchMethod.DeclaringType?.Assembly.FullName }).ToArray()                     };                 }).ToArray()`

<a id="symbol-e577b991ddf0"></a>

## `NationalSpire.StartDiagnostics.Resource(string, string, int?, System.Exception?) — internal void Resource(string path, string phase, int? state = null, Exception? error = null)`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**调用：** [`NationalSpire.StartDiagnostics.Write(string, object?)`](StartDiagnostics.cs.md#symbol-7005259dbbc6)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Exception.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: string path, int? state, string exception>.exception`；`NationalSpire.StartDiagnostics._gate`；`NationalSpire.StartDiagnostics._resources`；`NationalSpire.StartDiagnostics.Write(string, object?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Write(string, object?)`；输入表达式：`Write("resource-" + phase, new { path, state, exception = error?.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("resource-" + phase, new { path, state, exception = error?.ToString() });`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_resources.Remove(path)`；返回值紧邻使用处：`ExpressionStatementSyntax: _resources.Remove(path);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_resources.TryGetValue(path, out int previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: _resources.TryGetValue(path, out int previous) && previous == state`
- `System.Exception.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: error?.ToString()`

**赋值（含属性/字段和局部值）：**

- `_resources[path]` = `-1`
- `_resources[path]` = `state ?? -1`

<a id="symbol-a410c399943e"></a>

## `NationalSpire.StartDiagnostics.Session(MegaCrit.Sts2.Core.Assets.AssetLoadingSession) — internal void Session(AssetLoadingSession session)`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.StartDiagnostics.CaptureSession(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`](StartDiagnostics.cs.md#symbol-e9bb286f7938)

**调用：** [`NationalSpire.StartDiagnostics.Capture(System.Action)`](StartDiagnostics.cs.md#symbol-177465fb0711)；[`NationalSpire.StartDiagnostics.Used(System.Reflection.MethodBase?)`](StartDiagnostics.cs.md#symbol-f70ffc60dab9)；[`NationalSpire.StartDiagnostics.Write(string, object?)`](StartDiagnostics.cs.md#symbol-7005259dbbc6)；[`NationalSpire.StartResourceSyncDiagnosticsPatch.TargetMethod()`](StartDiagnostics.cs.md#symbol-47f2f491dd7e)；`HarmonyLib.AccessTools.Field(System.Type, string)`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`System.AggregateException.ToString()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.Queue<T>.ToArray()`；`System.Enum.ToString()`；`System.Reflection.FieldInfo.GetValue(object?)`；`System.Threading.Tasks.Task<TResult>.ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)`

**字段、属性、事件及方法组引用：** `<anonymous type: object name, string status, string exception>.exception`；`<anonymous type: object name, string status, string exception>.name`；`<anonymous type: object name, string status, string exception>.status`；`NationalSpire.StartDiagnostics._gate`；`NationalSpire.StartDiagnostics._sessions`；`NationalSpire.StartDiagnostics.Capture(System.Action)`；`NationalSpire.StartDiagnostics.Used(System.Reflection.MethodBase?)`；`NationalSpire.StartDiagnostics.Write(string, object?)`；`NationalSpire.StartResourceSyncDiagnosticsPatch.TargetMethod()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(AssetLoadingSession), name)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.Field(typeof(AssetLoadingSession), name)?.GetValue(session)`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(AssetLoadingSession), name)`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(AssetLoadingSession), name)`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(NAssetLoader), "_Process")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(NAssetLoader), "_Process")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(ResourceLoader), name)`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(ResourceLoader), name)`
- `NationalSpire.StartDiagnostics.Capture(System.Action)`；输入表达式：`Capture(() =>         {             Write("resources-end", new { name = fields["_name"], status = task.Status.ToString(), exception = task.Exception?.ToString() });             lock (_gate) _sessions.Remove(session);         })`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: task => Capture(() =>         {             Write("resources-end", new { name = fields["_name"], status = task.Status.ToString(), exception = task.Exception?.ToString() });             lock (_gate) _sessions.Remove(session);         })`
- `NationalSpire.StartDiagnostics.Used(System.Reflection.MethodBase?)`；输入表达式：`Used(AccessTools.Method(typeof(AssetLoadingSession), name))`；返回值紧邻使用处：`ExpressionStatementSyntax: Used(AccessTools.Method(typeof(AssetLoadingSession), name));`
- `NationalSpire.StartDiagnostics.Used(System.Reflection.MethodBase?)`；输入表达式：`Used(AccessTools.Method(typeof(NAssetLoader), "_Process"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Used(AccessTools.Method(typeof(NAssetLoader), "_Process"));`
- `NationalSpire.StartDiagnostics.Used(System.Reflection.MethodBase?)`；输入表达式：`Used(AccessTools.Method(typeof(ResourceLoader), name))`；返回值紧邻使用处：`ExpressionStatementSyntax: Used(AccessTools.Method(typeof(ResourceLoader), name));`
- `NationalSpire.StartDiagnostics.Used(System.Reflection.MethodBase?)`；输入表达式：`Used(StartResourceSyncDiagnosticsPatch.TargetMethod())`；返回值紧邻使用处：`ExpressionStatementSyntax: Used(StartResourceSyncDiagnosticsPatch.TargetMethod());`
- `NationalSpire.StartDiagnostics.Write(string, object?)`；输入表达式：`Write("resources-begin", fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("resources-begin", fields);`
- `NationalSpire.StartDiagnostics.Write(string, object?)`；输入表达式：`Write("resources-end", new { name = fields["_name"], status = task.Status.ToString(), exception = task.Exception?.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("resources-end", new { name = fields["_name"], status = task.Status.ToString(), exception = task.Exception?.ToString() });`
- `NationalSpire.StartResourceSyncDiagnosticsPatch.TargetMethod()`；输入表达式：`StartResourceSyncDiagnosticsPatch.TargetMethod()`；返回值紧邻使用处：`ArgumentSyntax: StartResourceSyncDiagnosticsPatch.TargetMethod()`
- `System.AggregateException.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: task.Exception?.ToString()`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_sessions.Add(session)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_sessions.Add(session)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`_sessions.Remove(session)`；返回值紧邻使用处：`ExpressionStatementSyntax: _sessions.Remove(session);`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`new[] { "_name", "_toLoad", "_loading", "_finalizing", "_vfxScenes", "_currentVfxPath" }             .ToDictionary(name => name, name => AccessTools.Field(typeof(AssetLoadingSession), name)?.GetValue(session) is Queue<string> paths                 ? (object)paths.ToArray() : AccessTools.Field(typeof(AssetLoadingSession), name)?.GetValue(session))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new[] { "_name", "_toLoad", "_loading", "_finalizing", "_vfxScenes", "_currentVfxPath" }             .ToDictionary(name => name, name => AccessTools.Field(typeof(AssetLoadingSession), name)?.GetValue(session) is Queue<string> paths                 ? (object)paths.ToArray() : AccessTools.Field(typeof(AssetLoadingSession), name)?.GetValue(session))`
- `System.Collections.Generic.Queue<T>.ToArray()`；输入表达式：`paths.ToArray()`；返回值紧邻使用处：`CastExpressionSyntax: (object)paths.ToArray()`
- `System.Enum.ToString()`；输入表达式：`task.Status.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: status = task.Status.ToString()`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`.GetValue(session)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.Field(typeof(AssetLoadingSession), name)?.GetValue(session)`
- `System.Threading.Tasks.Task<TResult>.ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)`；输入表达式：`session.Task.ContinueWith(task => Capture(() =>         {             Write("resources-end", new { name = fields["_name"], status = task.Status.ToString(), exception = task.Exception?.ToString() });             lock (_gate) _sessions.Remove(session);         }), CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = session.Task.ContinueWith(task => Capture(() =>         {             Write("resources-end", new { name = fields["_name"], status = task.Status.ToString(), exception = task.Exception?.ToString() });             lock (_gate) _sessions.Remove(session);         }), CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default)`

**赋值（含属性/字段和局部值）：**

- `_` = `session.Task.ContinueWith(task => Capture(() =>         {             Write("resources-end", new { name = fields["_name"], status = task.Status.ToString(), exception = task.Exception?.ToString() });             lock (_gate) _sessions.Remove(session);         }), CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default)`

<a id="symbol-926d639dd30b"></a>

## `NationalSpire.StartDiagnostics.Observe(System.Reflection.MethodBase, System.Threading.Tasks.Task) — internal void Observe(MethodBase method, Task task)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.StartDiagnostics.CaptureTask(System.Reflection.MethodBase, System.Threading.Tasks.Task)`](StartDiagnostics.cs.md#symbol-8b75fc5d1ba4)

**调用：** [`NationalSpire.StartDiagnostics.Capture(System.Action)`](StartDiagnostics.cs.md#symbol-177465fb0711)；[`NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?)`](StartDiagnostics.cs.md#symbol-1a5c177ce877)；`System.Threading.Tasks.Task.ContinueWith(System.Action<System.Threading.Tasks.Task>, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)`

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.Capture(System.Action)`；`NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Capture(System.Action)`；输入表达式：`Capture(() => Method(method, t.IsCanceled ? "cancelled" : t.IsFaulted ? "failed" : "complete", t.Exception))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t => Capture(() => Method(method, t.IsCanceled ? "cancelled" : t.IsFaulted ? "failed" : "complete", t.Exception))`
- `NationalSpire.StartDiagnostics.Method(System.Reflection.MethodBase, string, System.Exception?)`；输入表达式：`Method(method, t.IsCanceled ? "cancelled" : t.IsFaulted ? "failed" : "complete", t.Exception)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Method(method, t.IsCanceled ? "cancelled" : t.IsFaulted ? "failed" : "complete", t.Exception)`
- `System.Threading.Tasks.Task.ContinueWith(System.Action<System.Threading.Tasks.Task>, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)`；输入表达式：`task.ContinueWith(t => Capture(() => Method(method, t.IsCanceled ? "cancelled" : t.IsFaulted ? "failed" : "complete", t.Exception)),             CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = task.ContinueWith(t => Capture(() => Method(method, t.IsCanceled ? "cancelled" : t.IsFaulted ? "failed" : "complete", t.Exception)),             CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default)`

**赋值（含属性/字段和局部值）：**

- `_` = `task.ContinueWith(t => Capture(() => Method(method, t.IsCanceled ? "cancelled" : t.IsFaulted ? "failed" : "complete", t.Exception)),             CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default)`

<a id="symbol-d25ec7607436"></a>

## `NationalSpire.StartDiagnostics.Dispose() — public void Dispose()`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.Write(string, object?)`](StartDiagnostics.cs.md#symbol-7005259dbbc6)；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `<anonymous type: string[] pendingResources, int sessions>.pendingResources`；`<anonymous type: string[] pendingResources, int sessions>.sessions`；`NationalSpire.StartDiagnostics._finished`；`NationalSpire.StartDiagnostics._gate`；`NationalSpire.StartDiagnostics._methods`；`NationalSpire.StartDiagnostics._previous`；`NationalSpire.StartDiagnostics._resources`；`NationalSpire.StartDiagnostics._sessions`；`NationalSpire.StartDiagnostics._stage`；`NationalSpire.StartDiagnostics.Current`；`NationalSpire.StartDiagnostics.Write(string, object?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.Write(string, object?)`；输入表达式：`Write("left", new { pendingResources = _resources.Keys.ToArray(), sessions = _sessions.Count })`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("left", new { pendingResources = _resources.Keys.ToArray(), sessions = _sessions.Count });`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(Current, this)`；返回值紧邻使用处：`IfStatementSyntax: if (ReferenceEquals(Current, this)) Current = _stage == null ? _previous : null;`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_resources.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _resources.Clear();`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_methods.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _methods.Clear();`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_sessions.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _sessions.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_resources.Keys.ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: pendingResources = _resources.Keys.ToArray()`

**赋值（含属性/字段和局部值）：**

- `Current` = `_stage == null ? _previous : null`

<a id="symbol-71ca31a93ec9"></a>

## `NationalSpire.StartMethodDiagnosticsPatch.TargetMethods() — internal static IEnumerable<MethodBase> TargetMethods()`

来源：源码第 154 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** `<anonymous type: string method, string state>.method`；`<anonymous type: string method, string state>.state`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(type, name)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AccessTools.Method(type, name)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.start.observer", new { method = type.FullName + "." + name, state = "接口不存在" })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("match.start.observer", new { method = type.FullName + "." + name, state = "接口不存在" });`

**赋值（含属性/字段和局部值）：**


<a id="symbol-79ee36993a13"></a>

## `NationalSpire.StartMethodDiagnosticsPatch.Prefix(System.Reflection.MethodBase, out NationalSpire.StartDiagnostics?) — internal static void Prefix(MethodBase __originalMethod, out StartDiagnostics? __state)`

来源：源码第 165 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureMethod(System.Reflection.MethodBase, string, System.Exception?)`](StartDiagnostics.cs.md#symbol-c59bb8ad3a48)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureMethod(System.Reflection.MethodBase, string, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureMethod(System.Reflection.MethodBase, string, System.Exception?)`；输入表达式：`.CaptureMethod(__originalMethod, "begin")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: __state?.CaptureMethod(__originalMethod, "begin")`

**赋值（含属性/字段和局部值）：**

- `__state` = `StartDiagnostics.Current`

<a id="symbol-5deefec5ae67"></a>

## `NationalSpire.StartMethodDiagnosticsPatch.Postfix(System.Reflection.MethodBase, System.Threading.Tasks.Task, NationalSpire.StartDiagnostics?) — internal static void Postfix(MethodBase __originalMethod, Task __result, StartDiagnostics? __state)`

来源：源码第 170 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureTask(System.Reflection.MethodBase, System.Threading.Tasks.Task)`](StartDiagnostics.cs.md#symbol-8b75fc5d1ba4)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureTask(System.Reflection.MethodBase, System.Threading.Tasks.Task)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureTask(System.Reflection.MethodBase, System.Threading.Tasks.Task)`；输入表达式：`.CaptureTask(__originalMethod, __result)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: __state?.CaptureTask(__originalMethod, __result)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-76f3342448ee"></a>

## `NationalSpire.StartMethodDiagnosticsPatch.Finalizer(System.Reflection.MethodBase, System.Exception?, NationalSpire.StartDiagnostics?) — internal static void Finalizer(MethodBase __originalMethod, Exception? __exception, StartDiagnostics? __state)`

来源：源码第 172 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureMethod(System.Reflection.MethodBase, string, System.Exception?)`](StartDiagnostics.cs.md#symbol-c59bb8ad3a48)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureMethod(System.Reflection.MethodBase, string, System.Exception?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureMethod(System.Reflection.MethodBase, string, System.Exception?)`；输入表达式：`.CaptureMethod(__originalMethod, "failed", __exception)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: __state?.CaptureMethod(__originalMethod, "failed", __exception)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b050e302cc31"></a>

## `NationalSpire.StartSessionDiagnosticsPatch.Prefix(MegaCrit.Sts2.Core.Assets.AssetLoadingSession) — internal static void Prefix(AssetLoadingSession session)`

来源：源码第 179 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureSession(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`](StartDiagnostics.cs.md#symbol-e9bb286f7938)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureSession(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureSession(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`；输入表达式：`.CaptureSession(session)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureSession(session)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5dc012af6ba4"></a>

## `NationalSpire.StartResourceRequestDiagnosticsPatch.Prefix(string) — internal static void Prefix(string path)`

来源：源码第 185 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；输入表达式：`.CaptureResource(path, "request")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureResource(path, "request")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9722b034455c"></a>

## `NationalSpire.StartResourceRequestDiagnosticsPatch.Postfix(string, Godot.Error) — internal static void Postfix(string path, Error __result)`

来源：源码第 186 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；输入表达式：`.CaptureResource(path, __result == Error.Ok ? "request-complete" : "failed", (int)__result)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureResource(path, __result == Error.Ok ? "request-complete" : "failed", (int)__result)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a63ddd781bb0"></a>

## `NationalSpire.StartResourceRequestDiagnosticsPatch.Finalizer(string, System.Exception?) — internal static void Finalizer(string path, Exception? __exception)`

来源：源码第 188 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；输入表达式：`.CaptureResource(path, "failed", error: __exception)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureResource(path, "failed", error: __exception)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3759e73d203e"></a>

## `NationalSpire.StartResourceStatusDiagnosticsPatch.Postfix(string, Godot.ResourceLoader.ThreadLoadStatus) — internal static void Postfix(string path, ResourceLoader.ThreadLoadStatus __result)`

来源：源码第 195 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；输入表达式：`.CaptureResource(path, "status", (int)__result)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureResource(path, "status", (int)__result)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2d7ec5da300d"></a>

## `NationalSpire.StartResourceGetDiagnosticsPatch.Prefix(string) — internal static void Prefix(string path)`

来源：源码第 202 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；输入表达式：`.CaptureResource(path, "get-begin")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureResource(path, "get-begin")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7fc57e0d38ac"></a>

## `NationalSpire.StartResourceGetDiagnosticsPatch.Postfix(string) — internal static void Postfix(string path)`

来源：源码第 203 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；输入表达式：`.CaptureResource(path, "get-complete")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureResource(path, "get-complete")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d7d59662b518"></a>

## `NationalSpire.StartResourceGetDiagnosticsPatch.Finalizer(string, System.Exception?) — internal static void Finalizer(string path, Exception? __exception)`

来源：源码第 204 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；输入表达式：`.CaptureResource(path, "failed", error: __exception)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureResource(path, "failed", error: __exception)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-47f2f491dd7e"></a>

## `NationalSpire.StartResourceSyncDiagnosticsPatch.TargetMethod() — internal static MethodBase TargetMethod()`

来源：源码第 211 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.StartDiagnostics.Session(MegaCrit.Sts2.Core.Assets.AssetLoadingSession)`](StartDiagnostics.cs.md#symbol-a410c399943e)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Reflection.MethodBase.GetParameters()`；`System.Type.GetMethods(System.Reflection.BindingFlags)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`typeof(ResourceLoader).GetMethods(BindingFlags.Public | BindingFlags.Static)         .Single(m => m.Name == nameof(ResourceLoader.Load) && !m.IsGenericMethod && m.GetParameters().Length == 3)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => typeof(ResourceLoader).GetMethods(BindingFlags.Public | BindingFlags.Static)         .Single(m => m.Name == nameof(ResourceLoader.Load) && !m.IsGenericMethod && m.GetParameters().Length == 3)`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.GetParameters().Length`
- `System.Type.GetMethods(System.Reflection.BindingFlags)`；输入表达式：`typeof(ResourceLoader).GetMethods(BindingFlags.Public | BindingFlags.Static)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: typeof(ResourceLoader).GetMethods(BindingFlags.Public | BindingFlags.Static)         .Single`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d54051f563c6"></a>

## `NationalSpire.StartResourceSyncDiagnosticsPatch.Prefix(string) — internal static void Prefix(string path)`

来源：源码第 213 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；输入表达式：`.CaptureResource(path, "sync-begin")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureResource(path, "sync-begin")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e66d9baef666"></a>

## `NationalSpire.StartResourceSyncDiagnosticsPatch.Postfix(string) — internal static void Postfix(string path)`

来源：源码第 214 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；输入表达式：`.CaptureResource(path, "sync-complete")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureResource(path, "sync-complete")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eb23ff3a95e1"></a>

## `NationalSpire.StartResourceSyncDiagnosticsPatch.Finalizer(string, System.Exception?) — internal static void Finalizer(string path, Exception? __exception)`

来源：源码第 215 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`](StartDiagnostics.cs.md#symbol-bae16b31099c)

**字段、属性、事件及方法组引用：** `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；`NationalSpire.StartDiagnostics.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.StartDiagnostics.CaptureResource(string, string, int?, System.Exception?)`；输入表达式：`.CaptureResource(path, "failed", error: __exception)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StartDiagnostics.Current?.CaptureResource(path, "failed", error: __exception)`

**赋值（含属性/字段和局部值）：**
