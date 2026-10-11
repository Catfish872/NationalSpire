# AiRequestQueue.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8BF0043DB9645390868ED214B5BBD4E94DF1A4AF8141A16C541E5C9A44D670F1`。来源：[源码](../../AiRequestQueue.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiRequestQueue`、`NationalSpire.AiRequestQueue.Pending`、`NationalSpire.AiRequestQueue.Lease`。

字段、事件及初始值（源码原样）：

```csharp
private readonly object _gate = new();
private readonly List<Pending> _waiting = [];
private readonly HashSet<(CareerData Data, string Key)> _occupied = [];
private int _active;
private int _limit = 3;
private int _released;
```

<a id="symbol-7bf81d36c27d"></a>

## `NationalSpire.AiRequestQueue.Configure(int) — internal void Configure(int limit)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.EnterQueueAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`](AiService.cs.md#symbol-364b38bdda09)；[`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.RefreshConcurrency(NationalSpire.AiOptions?)`](AiService.cs.md#symbol-19e0ca89f9d7)

**调用：** [`NationalSpire.AiRequestQueue.Dispatch()`](AiRequestQueue.cs.md#symbol-11f0d1431a21)；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiRequestQueue._gate`；`NationalSpire.AiRequestQueue._limit`；`NationalSpire.AiRequestQueue.Dispatch()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.Dispatch()`；输入表达式：`Dispatch()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dispatch();`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(limit, 1, 16)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _limit = Math.Clamp(limit, 1, 16)`

**赋值（含属性/字段和局部值）：**

- `_limit` = `Math.Clamp(limit, 1, 16)`

<a id="symbol-b1465ed1e33c"></a>

## `NationalSpire.AiRequestQueue.EnterAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Action<string>?) — internal Task<IDisposable> EnterAsync(CareerData data, IEnumerable<string> keys, Action<string>? waiting = null)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`](AiPrivateMessages.cs.md#symbol-d73b189170eb)；[`NationalSpire.AiService.EnterQueueAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`](AiService.cs.md#symbol-364b38bdda09)

**调用：** [`NationalSpire.AiRequestQueue.Dispatch()`](AiRequestQueue.cs.md#symbol-11f0d1431a21)；`NationalSpire.AiRequestQueue.Pending.Pending(System.Collections.Generic.HashSet<(NationalSpire.CareerData Data, string Key)>, System.Threading.Tasks.TaskCompletionSource<System.IDisposable>, System.Action<string>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Threading.Tasks.TaskCompletionSource<TResult>.TaskCompletionSource(System.Threading.Tasks.TaskCreationOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiRequestQueue._gate`；`NationalSpire.AiRequestQueue._waiting`；`NationalSpire.AiRequestQueue.Dispatch()`；`NationalSpire.AiRequestQueue.Pending.Completion`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.Dispatch()`；输入表达式：`Dispatch()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dispatch();`
- `NationalSpire.AiRequestQueue.Pending.Pending(System.Collections.Generic.HashSet<(NationalSpire.CareerData Data, string Key)>, System.Threading.Tasks.TaskCompletionSource<System.IDisposable>, System.Action<string>?)`；输入表达式：`new Pending(keys.Select(key => (data, key)).ToHashSet(), new(TaskCreationOptions.RunContinuationsAsynchronously), waiting)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Pending(keys.Select(key => (data, key)).ToHashSet(), new(TaskCreationOptions.RunContinuationsAsynchronously), waiting)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`keys.Select(key => (data, key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: keys.Select(key => (data, key)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`keys.Select(key => (data, key)).ToHashSet()`；返回值紧邻使用处：`ArgumentSyntax: keys.Select(key => (data, key)).ToHashSet()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_waiting.Add(request)`；返回值紧邻使用处：`ExpressionStatementSyntax: _waiting.Add(request);`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.TaskCompletionSource(System.Threading.Tasks.TaskCreationOptions)`；输入表达式：`new(TaskCreationOptions.RunContinuationsAsynchronously)`；返回值紧邻使用处：`ArgumentSyntax: new(TaskCreationOptions.RunContinuationsAsynchronously)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-11f0d1431a21"></a>

## `NationalSpire.AiRequestQueue.Dispatch() — private void Dispatch()`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiRequestQueue.Configure(int)`](AiRequestQueue.cs.md#symbol-7bf81d36c27d)；[`NationalSpire.AiRequestQueue.EnterAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Action<string>?)`](AiRequestQueue.cs.md#symbol-b1465ed1e33c)；[`NationalSpire.AiRequestQueue.Lease.Dispose()`](AiRequestQueue.cs.md#symbol-fc9e7d97b3fe)

**调用：** `NationalSpire.AiRequestQueue.Lease.Lease(NationalSpire.AiRequestQueue, System.Collections.Generic.HashSet<(NationalSpire.CareerData Data, string Key)>)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.HashSet<T>.Overlaps(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.HashSet<T>.UnionWith(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Collections.Generic.List<T>.ToArray()`；`System.Threading.Tasks.TaskCompletionSource<TResult>.SetResult(TResult)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiRequestQueue._active`；`NationalSpire.AiRequestQueue._limit`；`NationalSpire.AiRequestQueue._occupied`；`NationalSpire.AiRequestQueue._waiting`；`NationalSpire.AiRequestQueue.Pending.Completion`；`NationalSpire.AiRequestQueue.Pending.Keys`；`NationalSpire.AiRequestQueue.Pending.Waiting`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.Lease.Lease(NationalSpire.AiRequestQueue, System.Collections.Generic.HashSet<(NationalSpire.CareerData Data, string Key)>)`；输入表达式：`new Lease(this, request.Keys)`；返回值紧邻使用处：`ArgumentSyntax: new Lease(this, request.Keys)`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke("")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: request.Waiting?.Invoke("")`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke("已达到最大并发数，正在等待空位……")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: request.Waiting?.Invoke("已达到最大并发数，正在等待空位……")`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke("这份内容正在更新，完成后继续……")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: request.Waiting?.Invoke("这份内容正在更新，完成后继续……")`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<(CareerData Data, string Key)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<(CareerData Data, string Key)>()`
- `System.Collections.Generic.HashSet<T>.Overlaps(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`request.Keys.Overlaps(_occupied)`；返回值紧邻使用处：`BinaryExpressionSyntax: request.Keys.Overlaps(_occupied) || request.Keys.Overlaps(earlier)`
- `System.Collections.Generic.HashSet<T>.Overlaps(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`request.Keys.Overlaps(earlier)`；返回值紧邻使用处：`BinaryExpressionSyntax: request.Keys.Overlaps(_occupied) || request.Keys.Overlaps(earlier)`
- `System.Collections.Generic.HashSet<T>.UnionWith(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`_occupied.UnionWith(request.Keys)`；返回值紧邻使用处：`ExpressionStatementSyntax: _occupied.UnionWith(request.Keys);`
- `System.Collections.Generic.HashSet<T>.UnionWith(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`earlier.UnionWith(request.Keys)`；返回值紧邻使用处：`ExpressionStatementSyntax: earlier.UnionWith(request.Keys);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`_waiting.Remove(request)`；返回值紧邻使用处：`ExpressionStatementSyntax: _waiting.Remove(request);`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`_waiting.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var request in _waiting.ToArray())         {             if (_active >= _limit) { request.Waiting?.Invoke("已达到最大并发数，正在等待空位……"); continue; }             if (request.Keys.Overlaps(_occupied) || request.Keys.Overlaps(earlier))             { request.Waiting?.Invoke("这份内容正在更新，完成后继续……"); earlier.UnionWith(request.Keys); continue; }             _waiting.Remove(request); _active++; _occupied.UnionWith(request.Keys);             request.Waiting?.Invoke("");             request.Completion.SetResult(new Lease(this, request.Keys));         }`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.SetResult(TResult)`；输入表达式：`request.Completion.SetResult(new Lease(this, request.Keys))`；返回值紧邻使用处：`ExpressionStatementSyntax: request.Completion.SetResult(new Lease(this, request.Keys));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fc9e7d97b3fe"></a>

## `NationalSpire.AiRequestQueue.Lease.Dispose() — public void Dispose()`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AiRequestQueue.Dispatch()`](AiRequestQueue.cs.md#symbol-11f0d1431a21)；`System.Collections.Generic.HashSet<T>.ExceptWith(System.Collections.Generic.IEnumerable<T>)`；`System.Threading.Interlocked.Exchange(ref int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiRequestQueue._active`；`NationalSpire.AiRequestQueue._gate`；`NationalSpire.AiRequestQueue._occupied`；`NationalSpire.AiRequestQueue.Dispatch()`；`NationalSpire.AiRequestQueue.Lease._released`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.Dispatch()`；输入表达式：`owner.Dispatch()`；返回值紧邻使用处：`ExpressionStatementSyntax: owner.Dispatch();`
- `System.Collections.Generic.HashSet<T>.ExceptWith(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`owner._occupied.ExceptWith(keys)`；返回值紧邻使用处：`ExpressionStatementSyntax: owner._occupied.ExceptWith(keys);`
- `System.Threading.Interlocked.Exchange(ref int, int)`；输入表达式：`Interlocked.Exchange(ref _released, 1)`；返回值紧邻使用处：`BinaryExpressionSyntax: Interlocked.Exchange(ref _released, 1) != 0`

**赋值（含属性/字段和局部值）：**
