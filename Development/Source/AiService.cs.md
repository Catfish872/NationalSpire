# AiService.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`77B85AD51C3BE4A336ED732243B0F4745D0BA0BFFADF9A90FB3642E5746531F3`。来源：[源码](../../AiService.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiService`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly AiRequestQueue Queue = new();
private static readonly SemaphoreSlim StartGate = new(1, 1);
private static readonly System.Net.Http.HttpClient Client = new() { Timeout = System.Threading.Timeout.InfiniteTimeSpan };
private static readonly JsonSerializerOptions Json = new() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
internal static readonly HttpRequestOptionsKey<TimeSpan> TimeoutOption = new("NationalSpire.Timeout");
private static DateTimeOffset _lastRequest;
private static string? _sessionKey = AiSettingsStore.ReadKey();
private static readonly Dictionary<string, string> ProfileKeys = new();
```

<a id="symbol-19e0ca89f9d7"></a>

## `NationalSpire.AiService.RefreshConcurrency(NationalSpire.AiOptions?) — public static void RefreshConcurrency(AiOptions? options = null)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.Coop.CoopCareerSession.SaveAi(NationalSpire.CareerData)`](Coop/CoopCareerSession.cs.md#symbol-6fb4f052a4e3)

**调用：** [`NationalSpire.AiRequestQueue.Configure(int)`](AiRequestQueue.cs.md#symbol-7bf81d36c27d)

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.MaxConcurrentRequests`；`NationalSpire.AiRequestQueue.Configure(int)`；`NationalSpire.AiService.Queue`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerStore.Data`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.Configure(int)`；输入表达式：`Queue.Configure((options ?? CareerStore.Data.Ai).MaxConcurrentRequests)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Queue.Configure((options ?? CareerStore.Data.Ai).MaxConcurrentRequests)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-364b38bdda09"></a>

## `NationalSpire.AiService.EnterQueueAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>) — private static Task<IDisposable> EnterQueueAsync(CareerData data, IEnumerable<string> keys, IEnumerable<AiWorkState> works)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`NationalSpire.AiRequestQueue.Configure(int)`](AiRequestQueue.cs.md#symbol-7bf81d36c27d)；[`NationalSpire.AiRequestQueue.EnterAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Action<string>?)`](AiRequestQueue.cs.md#symbol-b1465ed1e33c)；[`NationalSpire.AiService.SetWaiting(System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>, string)`](AiService.cs.md#symbol-8465c04298d9)；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.MaxConcurrentRequests`；`NationalSpire.AiRequestQueue.Configure(int)`；`NationalSpire.AiRequestQueue.EnterAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Action<string>?)`；`NationalSpire.AiService.Queue`；`NationalSpire.AiService.SetWaiting(System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>, string)`；`NationalSpire.CareerData.Ai`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.Configure(int)`；输入表达式：`Queue.Configure(data.Ai.MaxConcurrentRequests)`；返回值紧邻使用处：`ExpressionStatementSyntax: Queue.Configure(data.Ai.MaxConcurrentRequests);`
- `NationalSpire.AiRequestQueue.EnterAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Action<string>?)`；输入表达式：`Queue.EnterAsync(data, keys, reason => SetWaiting(states, reason))`；返回值紧邻使用处：`ReturnStatementSyntax: return Queue.EnterAsync(data, keys, reason => SetWaiting(states, reason));`
- `NationalSpire.AiService.SetWaiting(System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>, string)`；输入表达式：`SetWaiting(states, reason)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: reason => SetWaiting(states, reason)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`works.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = works.ToArray()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8465c04298d9"></a>

## `NationalSpire.AiService.SetWaiting(System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>, string) — private static void SetWaiting(IEnumerable<AiWorkState> works, string reason)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.EnterQueueAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`](AiService.cs.md#symbol-364b38bdda09)；[`NationalSpire.AiService.WaitForRequestStartAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`](AiService.cs.md#symbol-5ba7da409ec8)

**调用：** [`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.State`；`NationalSpire.AiWorkState.WaitReason`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.wait", reason)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.wait", reason);`

**赋值（含属性/字段和局部值）：**

- `changed` = `true`
- `work.WaitReason` = `reason`

<a id="symbol-5ba7da409ec8"></a>

## `NationalSpire.AiService.WaitForRequestStartAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>) — private static async Task WaitForRequestStartAsync(CareerData data, IEnumerable<AiWorkState> works)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`NationalSpire.AiService.SetWaiting(System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>, string)`](AiService.cs.md#symbol-8465c04298d9)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Math.Clamp(int, int, int)`；`System.Math.Min(double, double)`；`System.Threading.SemaphoreSlim.Release()`；`System.Threading.SemaphoreSlim.WaitAsync()`；`System.Threading.Tasks.Task.Delay(System.TimeSpan)`；`System.TimeSpan.FromMilliseconds(double)`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.MinimumIntervalSeconds`；`NationalSpire.AiService._lastRequest`；`NationalSpire.AiService.SetWaiting(System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>, string)`；`NationalSpire.AiService.StartGate`；`NationalSpire.AiService.Status`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.SetWaiting(System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>, string)`；输入表达式：`SetWaiting(states, "")`；返回值紧邻使用处：`ExpressionStatementSyntax: SetWaiting(states, "");`
- `NationalSpire.AiService.SetWaiting(System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>, string)`；输入表达式：`SetWaiting(states, "正在等待前一项发送，随后按请求间隔继续……")`；返回值紧邻使用处：`ExpressionStatementSyntax: SetWaiting(states, "正在等待前一项发送，随后按请求间隔继续……");`
- `NationalSpire.AiService.SetWaiting(System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>, string)`；输入表达式：`SetWaiting(states, $"正在等待请求间隔（设置为 {interval} 秒）……")`；返回值紧邻使用处：`ExpressionStatementSyntax: SetWaiting(states, $"正在等待请求间隔（设置为 {interval} 秒）……");`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Ai.Enabled && CareerStore.IsCurrent(data)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`works.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = works.ToArray()`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(data.Ai.MinimumIntervalSeconds, 0, 300)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(data.Ai.MinimumIntervalSeconds, 0, 300)`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(500, wait.TotalMilliseconds)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(500, wait.TotalMilliseconds)`
- `System.Threading.SemaphoreSlim.Release()`；输入表达式：`StartGate.Release()`；返回值紧邻使用处：`ExpressionStatementSyntax: StartGate.Release();`
- `System.Threading.SemaphoreSlim.WaitAsync()`；输入表达式：`StartGate.WaitAsync()`；返回值紧邻使用处：`AwaitExpressionSyntax: await StartGate.WaitAsync()`
- `System.Threading.Tasks.Task.Delay(System.TimeSpan)`；输入表达式：`Task.Delay(TimeSpan.FromMilliseconds(Math.Min(500, wait.TotalMilliseconds)))`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Delay(TimeSpan.FromMilliseconds(Math.Min(500, wait.TotalMilliseconds)))`
- `System.TimeSpan.FromMilliseconds(double)`；输入表达式：`TimeSpan.FromMilliseconds(Math.Min(500, wait.TotalMilliseconds))`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromMilliseconds(Math.Min(500, wait.TotalMilliseconds))`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(interval)`；返回值紧邻使用处：`BinaryExpressionSyntax: TimeSpan.FromSeconds(interval) - (DateTimeOffset.UtcNow - _lastRequest)`

**赋值（含属性/字段和局部值）：**

- `_lastRequest` = `DateTimeOffset.UtcNow`
- `Status` = `"等待请求间隔"`

<a id="symbol-aad664840095"></a>

## `NationalSpire.AiService.SendAsync(System.Net.Http.HttpRequestMessage, NationalSpire.CareerData, string, string, System.Collections.Generic.IEnumerable<string>) — private static async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CareerData data, string trace, string kind, IEnumerable<string> targets)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.RegisterSecret(string?)`](Diagnostics.cs.md#symbol-4f621c46a4ca)；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Diagnostics.Stopwatch.StartNew()`；`System.Exception.ToString()`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.Math.Clamp(int, int, int)`；`System.Net.Http.HttpContent.ReadAsStringAsync()`；`System.Net.Http.HttpRequestOptions.Set<TValue>(System.Net.Http.HttpRequestOptionsKey<TValue>, TValue)`；`System.Net.Http.HttpResponseMessage.Dispose()`；`System.TimeSpan.FromMinutes(long)`；`System.Uri.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: string trace, string kind, int status, long elapsedMilliseconds, int characters, string body>.characters`；`<anonymous type: string trace, string kind, int status, long elapsedMilliseconds, int characters, string body>.elapsedMilliseconds`；`<anonymous type: string trace, string kind, int status, long elapsedMilliseconds, int characters, string body>.status`；`<anonymous type: string trace, string kind, long elapsedMilliseconds, string exception>.elapsedMilliseconds`；`<anonymous type: string trace, string kind, long elapsedMilliseconds, string exception>.exception`；`<anonymous type: string trace, string kind, string[] targets, int Day, int Season, string endpoint, int RequestTimeoutMinutes, int MaxConcurrentRequests, string payload>.endpoint`；`<anonymous type: string trace, string kind, string[] targets, int Day, int Season, string endpoint, int RequestTimeoutMinutes, int MaxConcurrentRequests, string payload>.payload`；`<anonymous type: string trace, string kind, string[] targets, int Day, int Season, string endpoint, int RequestTimeoutMinutes, int MaxConcurrentRequests, string payload>.targets`；`NationalSpire.AiOptions.MaxConcurrentRequests`；`NationalSpire.AiOptions.RequestTimeoutMinutes`；`NationalSpire.AiService.TimeoutOption`；`NationalSpire.AiService.Transport`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Season`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.RegisterSecret(string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.request", new { trace, kind, targets = targets.ToArray(), data.Day, data.Season,              endpoint = request.RequestUri?.ToString(), data.Ai.RequestTimeoutMinutes, data.Ai.MaxConcurrentRequests,              payload = request.Content == null ? "" : await request.Content.ReadAsStringAsync() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.request", new { trace, kind, targets = targets.ToArray(), data.Day, data.Season,              endpoint = request.RequestUri?.ToString(), data.Ai.RequestTimeoutMinutes, data.Ai.MaxConcurrentRequests,              payload = request.Content == null ? "" : await request.Content.ReadAsStringAsync() });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.response", new { trace, kind, status = (int)response.StatusCode,                  elapsedMilliseconds = timer.ElapsedMilliseconds, characters = body.Length, body })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.response", new { trace, kind, status = (int)response.StatusCode,                  elapsedMilliseconds = timer.ElapsedMilliseconds, characters = body.Length, body });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.transport-failed", new { trace, kind, elapsedMilliseconds = timer.ElapsedMilliseconds, exception = e.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.transport-failed", new { trace, kind, elapsedMilliseconds = timer.ElapsedMilliseconds, exception = e.ToString() });`
- `NationalSpire.Diagnostics.RegisterSecret(string?)`；输入表达式：`Diagnostics.RegisterSecret(request.Headers.Authorization?.Parameter)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RegisterSecret(request.Headers.Authorization?.Parameter);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`targets.ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: targets = targets.ToArray()`
- `System.Diagnostics.Stopwatch.StartNew()`；输入表达式：`System.Diagnostics.Stopwatch.StartNew()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Diagnostics.Stopwatch.StartNew()`
- `System.Exception.ToString()`；输入表达式：`e.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: exception = e.ToString()`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`Transport(request)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Transport(request)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)`
- `System.Net.Http.HttpContent.ReadAsStringAsync()`；输入表达式：`request.Content.ReadAsStringAsync()`；返回值紧邻使用处：`AwaitExpressionSyntax: await request.Content.ReadAsStringAsync()`
- `System.Net.Http.HttpContent.ReadAsStringAsync()`；输入表达式：`response.Content.ReadAsStringAsync()`；返回值紧邻使用处：`AwaitExpressionSyntax: await response.Content.ReadAsStringAsync()`
- `System.Net.Http.HttpRequestOptions.Set<TValue>(System.Net.Http.HttpRequestOptionsKey<TValue>, TValue)`；输入表达式：`request.Options.Set(TimeoutOption, TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)))`；返回值紧邻使用处：`ExpressionStatementSyntax: request.Options.Set(TimeoutOption, TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)));`
- `System.Net.Http.HttpResponseMessage.Dispose()`；输入表达式：`response.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: response.Dispose();`
- `System.TimeSpan.FromMinutes(long)`；输入表达式：`TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30))`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30))`
- `System.Uri.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: request.RequestUri?.ToString()`

**赋值（含属性/字段和局部值）：**

- `response` = `await Transport(request)`

<a id="symbol-410b124871a3"></a>

## `NationalSpire.AiService.SendTransportAsync(System.Net.Http.HttpRequestMessage) — private static async Task<HttpResponseMessage> SendTransportAsync(HttpRequestMessage request)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Net.Http.HttpClient.SendAsync(System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken)`；`System.Net.Http.HttpRequestOptions.TryGetValue<TValue>(System.Net.Http.HttpRequestOptionsKey<TValue>, out TValue)`；`System.Threading.CancellationTokenSource.CancellationTokenSource(System.TimeSpan)`；`System.TimeSpan.FromMinutes(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.Client`；`NationalSpire.AiService.TimeoutOption`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Net.Http.HttpClient.SendAsync(System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken)`；输入表达式：`Client.SendAsync(request, timeout.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Client.SendAsync(request, timeout.Token)`
- `System.Net.Http.HttpRequestOptions.TryGetValue<TValue>(System.Net.Http.HttpRequestOptionsKey<TValue>, out TValue)`；输入表达式：`request.Options.TryGetValue(TimeoutOption, out var value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: request.Options.TryGetValue(TimeoutOption, out var value) ? value : TimeSpan.FromMinutes(10)`
- `System.Threading.CancellationTokenSource.CancellationTokenSource(System.TimeSpan)`；输入表达式：`new CancellationTokenSource(duration)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CancellationTokenSource(duration)`
- `System.TimeSpan.FromMinutes(long)`；输入表达式：`TimeSpan.FromMinutes(10)`；返回值紧邻使用处：`ConditionalExpressionSyntax: request.Options.TryGetValue(TimeoutOption, out var value) ? value : TimeSpan.FromMinutes(10)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0c9455c33d68"></a>

## `NationalSpire.AiService.Status — public static string Status`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c6e168d63685"></a>

## `NationalSpire.AiService.CurrentKey — private static string? CurrentKey`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.IsNullOrWhiteSpace(string?)`；`System.Environment.GetEnvironmentVariable(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService._sessionKey`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(_sessionKey)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(_sessionKey)`
- `System.Environment.GetEnvironmentVariable(string)`；输入表达式：`System.Environment.GetEnvironmentVariable("NATIONAL_SPIRE_API_KEY")`；返回值紧邻使用处：`ConditionalExpressionSyntax: !string.IsNullOrWhiteSpace(_sessionKey) ? _sessionKey : System.Environment.GetEnvironmentVariable("NATIONAL_SPIRE_API_KEY")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-804c4895eb32"></a>

## `NationalSpire.AiService.SetSessionKey(string) — public static void SetSessionKey(string value)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.AiService._sessionKey`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_sessionKey` = `value`

<a id="symbol-96c9adf50cfa"></a>

## `NationalSpire.AiService.ProfileKey(string) — public static string? ProfileKey(string profile)`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Load(string, bool)`](AiSettingsPanel.cs.md#symbol-96678e748257)；[`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`](AiService.cs.md#symbol-8c02bb75b41a)；[`NationalSpire.AiService.FetchModelsAsync(string, string?, string)`](AiModels.cs.md#symbol-142ecf753d1d)；[`NationalSpire.AiService.HasProfileKey(string)`](AiService.cs.md#symbol-79f735f59baf)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** [`NationalSpire.AiSettingsStore.ReadKey(string)`](AiSettingsStore.cs.md#symbol-ca446a961f94)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiRouting.Default`；`NationalSpire.AiService.CurrentKey`；`NationalSpire.AiService.ProfileKeys`；`NationalSpire.AiSettingsStore.ReadKey(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiSettingsStore.ReadKey(string)`；输入表达式：`AiSettingsStore.ReadKey(profile)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ProfileKeys.TryGetValue(profile, out var key) ? key : AiSettingsStore.ReadKey(profile)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`ProfileKeys.TryGetValue(profile, out var key)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ProfileKeys.TryGetValue(profile, out var key) ? key : AiSettingsStore.ReadKey(profile)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-79f735f59baf"></a>

## `NationalSpire.AiService.HasProfileKey(string) — public static bool HasProfileKey(string profile)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`CommitKey()`](AiSettingsPanel.cs.md#symbol-965bdffd5689)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** [`NationalSpire.AiService.ProfileKey(string)`](AiService.cs.md#symbol-96c9adf50cfa)；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProfileKey(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ProfileKey(string)`；输入表达式：`ProfileKey(profile)`；返回值紧邻使用处：`ArgumentSyntax: ProfileKey(profile)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(ProfileKey(profile))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(ProfileKey(profile))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8c02bb75b41a"></a>

## `NationalSpire.AiService.Connection(NationalSpire.AiOptions, string) — public static AiConnection Connection(AiOptions options, string task)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildNewsPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.AiWireProtocol, string?)`](AiService.cs.md#symbol-847b058813c9)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)；[`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)

**调用：** [`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`](AiRouting.cs.md#symbol-ccbfd0b083bc)；[`NationalSpire.AiService.ProfileKey(string)`](AiService.cs.md#symbol-96c9adf50cfa)；`NationalSpire.AiConnection.AiConnection(string, string, string, string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiConnectionProfile.Endpoint`；`NationalSpire.AiConnectionProfile.Model`；`NationalSpire.AiConnectionProfile.Name`；`NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`；`NationalSpire.AiService.ProfileKey(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiConnection.AiConnection(string, string, string, string, string?)`；输入表达式：`new(id, profile.Name, profile.Endpoint, profile.Model, ProfileKey(id))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(id, profile.Name, profile.Endpoint, profile.Model, ProfileKey(id));`
- `NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`；输入表达式：`AiRouting.ProfileId(options, task)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiRouting.ProfileId(options, task)`
- `NationalSpire.AiService.ProfileKey(string)`；输入表达式：`ProfileKey(id)`；返回值紧邻使用处：`ArgumentSyntax: ProfileKey(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-017daf4a239c"></a>

## `NationalSpire.AiService.PersistKey(string, string) — public static string? PersistKey(string value, string profile = AiRouting.Default)`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`CommitKey()`](AiSettingsPanel.cs.md#symbol-965bdffd5689)

**调用：** [`NationalSpire.AiSettingsStore.SaveKey(string, string)`](AiSettingsStore.cs.md#symbol-5e3165a11a8d)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.RegisterSecret(string?)`](Diagnostics.cs.md#symbol-4f621c46a4ca)；`string.IsNullOrWhiteSpace(string?)`；`System.Exception.GetType()`

**字段、属性、事件及方法组引用：** `<anonymous type: bool deleting, bool available, string error>.available`；`<anonymous type: bool deleting, bool available, string error>.error`；`<anonymous type: bool deleting, bool available>.available`；`NationalSpire.AiRouting.Default`；`NationalSpire.AiService._sessionKey`；`NationalSpire.AiService.HasKey`；`NationalSpire.AiService.ProfileKeys`；`NationalSpire.AiSettingsStore.SaveKey(string, string)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.RegisterSecret(string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiSettingsStore.SaveKey(string, string)`；输入表达式：`AiSettingsStore.SaveKey(value, profile)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiSettingsStore.SaveKey(value, profile);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.credential.save-failed", new { deleting, available = HasKey, error = e.GetType().Name })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.credential.save-failed", new { deleting, available = HasKey, error = e.GetType().Name });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.credential.saved", new { deleting, available = HasKey })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.credential.saved", new { deleting, available = HasKey });`
- `NationalSpire.Diagnostics.RegisterSecret(string?)`；输入表达式：`Diagnostics.RegisterSecret(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RegisterSecret(value);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(value)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.IsNullOrWhiteSpace(value)`
- `System.Exception.GetType()`；输入表达式：`e.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.GetType().Name`

**赋值（含属性/字段和局部值）：**

- `_sessionKey` = `value`
- `ProfileKeys[profile]` = `value`

<a id="symbol-d342b956ee1a"></a>

## `NationalSpire.AiService.HasKey — public static bool HasKey`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.CurrentKey`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(CurrentKey)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(CurrentKey)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a50bcbf6dda5"></a>

## `NationalSpire.AiService.FailureReason(System.Exception) — internal static string FailureReason(Exception error)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.FetchModelsAsync(string, string?, string)`](AiModels.cs.md#symbol-142ecf753d1d)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)；[`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`](AiGroupChats.cs.md#symbol-1e6e737dbe88)；[`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`Notify()`](AiGroupChats.cs.md#symbol-57c976501a7f)；[`Notify(string)`](AiPrivateMessages.cs.md#symbol-c0fe3566d8ec)

**调用：** [`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Exception.GetType()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(prefix + string.Join("\n", messages))`；返回值紧邻使用处：`ReturnStatementSyntax: return Diagnostics.Redact(prefix + string.Join("\n", messages));`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", messages)`；返回值紧邻使用处：`BinaryExpressionSyntax: prefix + string.Join("\n", messages)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`messages.Add(current.GetType().Name + ": " + current.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: messages.Add(current.GetType().Name + ": " + current.Message);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Exception.GetType()`；输入表达式：`current.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: current.GetType().Name`

**赋值（含属性/字段和局部值）：**

- `current` = `current.InnerException`

<a id="symbol-80abc5b58bda"></a>

## `NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage) — internal static async Task<string> HttpFailure(HttpResponseMessage response)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.FetchModelsAsync(string, string?, string)`](AiModels.cs.md#symbol-142ecf753d1d)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；`System.Net.Http.HttpContent.ReadAsStringAsync()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(          $"HTTP {(int)response.StatusCode} {response.ReasonPhrase}\n" + await response.Content.ReadAsStringAsync())`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Diagnostics.Redact(          $"HTTP {(int)response.StatusCode} {response.ReasonPhrase}\n" + await response.Content.ReadAsStringAsync())`
- `System.Net.Http.HttpContent.ReadAsStringAsync()`；输入表达式：`response.Content.ReadAsStringAsync()`；返回值紧邻使用处：`AwaitExpressionSyntax: await response.Content.ReadAsStringAsync()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e8b1c4ed9086"></a>

## `NationalSpire.AiService.TryGetEndpoint(string?, out System.Uri) — internal static bool TryGetEndpoint(string? endpoint, out Uri uri)`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** `string.EndsWith(string, System.StringComparison)`；`string.IsNullOrEmpty(string?)`；`string.Trim()`；`string.TrimEnd(char)`；`System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`；`System.UriBuilder.UriBuilder(System.Uri)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.EndsWith(string, System.StringComparison)`；输入表达式：`path.EndsWith("/chat/completions", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !path.EndsWith("/chat/completions", StringComparison.OrdinalIgnoreCase)`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(parsed.Host)`；返回值紧邻使用处：`BinaryExpressionSyntax: !Uri.TryCreate(endpoint?.Trim(), UriKind.Absolute, out var parsed)              || parsed.Scheme is not ("http" or "https") || string.IsNullOrEmpty(parsed.Host)`
- `string.Trim()`；输入表达式：`.Trim()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: endpoint?.Trim()`
- `string.TrimEnd(char)`；输入表达式：`builder.Path.TrimEnd('/')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = builder.Path.TrimEnd('/')`
- `System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`；输入表达式：`Uri.TryCreate(endpoint?.Trim(), UriKind.Absolute, out var parsed)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Uri.TryCreate(endpoint?.Trim(), UriKind.Absolute, out var parsed)`
- `System.UriBuilder.UriBuilder(System.Uri)`；输入表达式：`new UriBuilder(parsed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new UriBuilder(parsed)`

**赋值（含属性/字段和局部值）：**

- `builder.Path` = `path`
- `path` += `"/chat/completions"`
- `uri` = `builder.Uri`
- `uri` = `null!`

<a id="symbol-8243488b636b"></a>

## `NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?) — public static async Task ProcessPendingAsync(CareerData? requestedData = null)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](Coop/CoopAi.cs.md#symbol-b4b98ce85f62)；[`NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-4495455c88ce)；[`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)

**调用：** [`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)；[`NationalSpire.AiService.ProcessWeeklyAsync(NationalSpire.CareerData?)`](AiWeekly.cs.md#symbol-bb0ee823dfc4)；`System.Threading.Tasks.Task.WhenAll(params System.Threading.Tasks.Task[])`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`；`NationalSpire.AiService.ProcessWeeklyAsync(NationalSpire.CareerData?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`；输入表达式：`ProcessNewsAsync(null, requestedData)`；返回值紧邻使用处：`ArgumentSyntax: ProcessNewsAsync(null, requestedData)`
- `NationalSpire.AiService.ProcessWeeklyAsync(NationalSpire.CareerData?)`；输入表达式：`ProcessWeeklyAsync(requestedData)`；返回值紧邻使用处：`ArgumentSyntax: ProcessWeeklyAsync(requestedData)`
- `System.Threading.Tasks.Task.WhenAll(params System.Threading.Tasks.Task[])`；输入表达式：`Task.WhenAll(ProcessNewsAsync(null, requestedData), ProcessWeeklyAsync(requestedData))`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.WhenAll(ProcessNewsAsync(null, requestedData), ProcessWeeklyAsync(requestedData))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4e15401241c3"></a>

## `NationalSpire.AiService.RetryNewsAsync(string) — public static Task RetryNewsAsync(string postId)`

来源：源码第 142 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, bool)`](CareerScreen.cs.md#symbol-d5523b24e9f1)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)

**调用：** [`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`；输入表达式：`ProcessNewsAsync(postId)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProcessNewsAsync(postId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-411839f2efbd"></a>

## `NationalSpire.AiService.RetryFailedNewsAsync() — public static Task RetryFailedNewsAsync()`

来源：源码第 143 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)

**调用：** [`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`；输入表达式：`ProcessNewsAsync("*")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProcessNewsAsync("*")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-58a2eca2fa68"></a>

## `NationalSpire.AiService.SelectNewsBatch(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int) — internal static List<CommunityPost> SelectNewsBatch(IEnumerable<CommunityPost> candidates, int count)`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`](PublicationBacklog.cs.md#symbol-28c8b28b12c8)

**字段、属性、事件及方法组引用：** `NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`；输入表达式：`PublicationBacklog.Select(candidates, count)`；返回值紧邻使用处：`ReturnStatementSyntax: return PublicationBacklog.Select(candidates, count);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1773c3383336"></a>

## `NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?) — public static async Task ProcessNewsAsync(string? retryId, CareerData? requestedData = null)`

来源：源码第 149 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?)`](AiService.cs.md#symbol-8243488b636b)；[`NationalSpire.AiService.RetryFailedNewsAsync()`](AiService.cs.md#symbol-411839f2efbd)；[`NationalSpire.AiService.RetryNewsAsync(string)`](AiService.cs.md#symbol-4e15401241c3)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](Coop/CoopAi.cs.md#symbol-b4b98ce85f62)

**调用：** [`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.CareerEngine.ExcludedAutomaticPreview(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CareerEngine.cs.md#symbol-ff6b96537297)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；[`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`](CommunityThreads.cs.md#symbol-981631ecddfc)；[`NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool)`](PublicationBacklog.cs.md#symbol-37eb1c83d725)；[`NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`](PublicationBacklog.cs.md#symbol-28c8b28b12c8)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Chunk<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Except<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.MaxNewsPosts`；`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`；`NationalSpire.AiService.Status`；`NationalSpire.AiWorkState.State`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.ExcludedAutomaticPreview(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CareerStore.Data`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；`NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool)`；`NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`；输入表达式：`ProcessNewsBatchAsync(data, batch.ToList())`；返回值紧邻使用处：`AwaitExpressionSyntax: await ProcessNewsBatchAsync(data, batch.ToList())`
- `NationalSpire.CareerEngine.ExcludedAutomaticPreview(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CareerEngine.ExcludedAutomaticPreview(data, p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerEngine.ExcludedAutomaticPreview(data, p)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, p.AuthorId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.IsHuman(data, p.AuthorId)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, r.AuthorId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => CommunityThreads.IsHuman(data, r.AuthorId)`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.Remember(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.Remember(data, post);`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(post.NewsGeneration, "queued")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(post.NewsGeneration, "queued");`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(post.NewsGeneration, "superseded")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(post.NewsGeneration, "superseded");`
- `NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool)`；输入表达式：`PublicationBacklog.Compact(data, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: PublicationBacklog.Compact(data, false);`
- `NationalSpire.PublicationBacklog.Select(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, NationalSpire.CareerData?)`；输入表达式：`PublicationBacklog.Select(candidates, data.Ai.MaxNewsPosts, data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: retryId != null && retryId != "*" ? candidates : PublicationBacklog.Select(candidates, data.Ai.MaxNewsPosts, data)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))`
- `System.Collections.Generic.IEnumerable<TSource>.Chunk<TSource>(int)`；输入表达式：`pending.Chunk(5)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var batch in pending.Chunk(5)) await ProcessNewsBatchAsync(data, batch.ToList());`
- `System.Collections.Generic.IEnumerable<TSource>.Except<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`candidates.Except(pending)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in candidates.Except(pending))              {                  post.AiPending = false;                  CommunityThreads.SetWork(post.NewsGeneration, "superseded");              }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`batch.ToList()`；返回值紧邻使用处：`ArgumentSyntax: batch.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CommunityThreads.All(data).Where(p => !CareerEngine.ExcludedAutomaticPreview(data, p) && !CommunityThreads.IsHuman(data, p.AuthorId)              && (retryId != null ? (retryId == "*" || p.Id == retryId) && p.NewsGeneration.State == "failed"                  : p.AiPending && p.Day >= data.Day - 7 && p.NewsGeneration.State == "idle" && !p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))))              .ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).Where(p => !CareerEngine.ExcludedAutomaticPreview(data, p) && !CommunityThreads.IsHuman(data, p.AuthorId)              && (retryId != null ? (retryId == "*" || p.Id == retryId) && p.NewsGeneration.State == "failed"                  : p.AiPending && p.Day >= data.Day - 7 && p.NewsGeneration.State == "idle" && !p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))))              .ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Where(p => !CareerEngine.ExcludedAutomaticPreview(data, p) && !CommunityThreads.IsHuman(data, p.AuthorId)              && (retryId != null ? (retryId == "*" || p.Id == retryId) && p.NewsGeneration.State == "failed"                  : p.AiPending && p.Day >= data.Day - 7 && p.NewsGeneration.State == "idle" && !p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => !CareerEngine.ExcludedAutomaticPreview(data, p) && !CommunityThreads.IsHuman(data, p.AuthorId)              && (retryId != null ? (retryId == "*" || p.Id == retryId) && p.NewsGeneration.State == "failed"                  : p.AiPending && p.Day >= data.Day - 7 && p.NewsGeneration.State == "idle" && !p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))))              .ToList`

**赋值（含属性/字段和局部值）：**

- `post.AiPending` = `false`
- `Status` = `"离线社区模式"`

<a id="symbol-483c895c168a"></a>

## `NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>) — private static async Task ProcessNewsBatchAsync(CareerData data, List<CommunityPost> pending)`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)

**调用：** [`Fail(string)`](AiService.cs.md#symbol-e404a196f39a)；`Godot.GD.PushWarning(string)`；[`NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?)`](AiService.cs.md#symbol-5cb9c2055e1c)；[`NationalSpire.AiService.BuildNewsPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.AiWireProtocol, string?)`](AiService.cs.md#symbol-847b058813c9)；[`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`](AiService.cs.md#symbol-8c02bb75b41a)；[`NationalSpire.AiService.EnterQueueAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`](AiService.cs.md#symbol-364b38bdda09)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`](AiService.cs.md#symbol-80abc5b58bda)；[`NationalSpire.AiService.ReadResponseCompletion(System.Net.Http.HttpResponseMessage)`](AiService.cs.md#symbol-4f223cb1164e)；[`NationalSpire.AiService.SendAsync(System.Net.Http.HttpRequestMessage, NationalSpire.CareerData, string, string, System.Collections.Generic.IEnumerable<string>)`](AiService.cs.md#symbol-aad664840095)；[`NationalSpire.AiService.TryGetEndpoint(string?, out System.Uri)`](AiService.cs.md#symbol-e8b1c4ed9086)；[`NationalSpire.AiService.WaitForRequestStartAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`](AiService.cs.md#symbol-5ba7da409ec8)；[`NationalSpire.AiWireProtocol.AiWireProtocol(NationalSpire.CareerData)`](AiWireProtocol.cs.md#symbol-ebb8d59c054e)；[`NationalSpire.AiWireProtocol.Decode(string, bool, string?)`](AiWireProtocol.cs.md#symbol-1b2e04d42691)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；[`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`](CommunityThreads.cs.md#symbol-981631ecddfc)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.DateTime.ToString(string?)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IDisposable.Dispose()`；`System.Net.Http.Headers.AuthenticationHeaderValue.AuthenticationHeaderValue(string, string?)`；`System.Net.Http.HttpRequestMessage.HttpRequestMessage(System.Net.Http.HttpMethod, System.Uri?)`；`System.Net.Http.StringContent.StringContent(string, System.Text.Encoding?, string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`int.Parse(string)`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `Fail(string)`；`NationalSpire.AiConnection.Endpoint`；`NationalSpire.AiConnection.Key`；`NationalSpire.AiConnection.Model`；`NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.RequestDay`；`NationalSpire.AiOptions.RequestsToday`；`NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?)`；`NationalSpire.AiService.BuildNewsPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.AiWireProtocol, string?)`；`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；`NationalSpire.AiService.EnterQueueAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`；`NationalSpire.AiService.Json`；`NationalSpire.AiService.ReadResponseCompletion(System.Net.Http.HttpResponseMessage)`；`NationalSpire.AiService.SendAsync(System.Net.Http.HttpRequestMessage, NationalSpire.CareerData, string, string, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.AiService.Status`；`NationalSpire.AiService.TryGetEndpoint(string?, out System.Uri)`；`NationalSpire.AiService.WaitForRequestStartAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`；`NationalSpire.AiWireProtocol.Decode(string, bool, string?)`；`NationalSpire.AiWorkState.State`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Fail(string)`；输入表达式：`Fail("接口地址无效，请填写完整的 http:// 或 https:// 地址")`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail("接口地址无效，请填写完整的 http:// 或 https:// 地址");`
- `Fail(string)`；输入表达式：`Fail("未设置密钥")`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail("未设置密钥");`
- `Fail(string)`；输入表达式：`Fail(FailureReason(e))`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(FailureReason(e));`
- `Fail(string)`；输入表达式：`Fail(await HttpFailure(response))`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(await HttpFailure(response));`
- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("[NationalSpire] 新闻生成：" + failure)`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("[NationalSpire] 新闻生成：" + failure);`
- `NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?)`；输入表达式：`ApplyNewsResponse(data, pending, content, snapshots.ToDictionary(p => p.Id, p => p.Revision))`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyNewsResponse(data, pending, content, snapshots.ToDictionary(p => p.Id, p => p.Revision));`
- `NationalSpire.AiService.BuildNewsPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.AiWireProtocol, string?)`；输入表达式：`BuildNewsPayload(data, snapshots, wire, model)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BuildNewsPayload(data, snapshots, wire, model)`
- `NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；输入表达式：`Connection(data.Ai, "news")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Connection(data.Ai, "news")`
- `NationalSpire.AiService.EnterQueueAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`；输入表达式：`EnterQueueAsync(data, pending.Select(p => "post:" + p.Id), pending.Select(p => p.NewsGeneration))`；返回值紧邻使用处：`AwaitExpressionSyntax: await EnterQueueAsync(data, pending.Select(p => "post:" + p.Id), pending.Select(p => p.NewsGeneration))`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`ArgumentSyntax: FailureReason(e)`
- `NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`；输入表达式：`HttpFailure(response)`；返回值紧邻使用处：`AwaitExpressionSyntax: await HttpFailure(response)`
- `NationalSpire.AiService.ReadResponseCompletion(System.Net.Http.HttpResponseMessage)`；输入表达式：`ReadResponseCompletion(response)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ReadResponseCompletion(response)`
- `NationalSpire.AiService.SendAsync(System.Net.Http.HttpRequestMessage, NationalSpire.CareerData, string, string, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`SendAsync(request, data, trace, "news", pending.Select(p => p.Id))`；返回值紧邻使用处：`AwaitExpressionSyntax: await SendAsync(request, data, trace, "news", pending.Select(p => p.Id))`
- `NationalSpire.AiService.TryGetEndpoint(string?, out System.Uri)`；输入表达式：`TryGetEndpoint(endpoint, out var uri)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !TryGetEndpoint(endpoint, out var uri)`
- `NationalSpire.AiService.WaitForRequestStartAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`；输入表达式：`WaitForRequestStartAsync(data, pending.Select(p => p.NewsGeneration))`；返回值紧邻使用处：`AwaitExpressionSyntax: await WaitForRequestStartAsync(data, pending.Select(p => p.NewsGeneration))`
- `NationalSpire.AiWireProtocol.AiWireProtocol(NationalSpire.CareerData)`；输入表达式：`new AiWireProtocol(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new AiWireProtocol(data)`
- `NationalSpire.AiWireProtocol.Decode(string, bool, string?)`；输入表达式：`wire.Decode(await ReadResponseCompletion(response), expectedArray: "posts")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = wire.Decode(await ReadResponseCompletion(response), expectedArray: "posts")`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(data)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.Remember(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.Remember(data, post);`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(p.NewsGeneration, "superseded")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(p.NewsGeneration, "superseded");`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(post.NewsGeneration, "failed", failure)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(post.NewsGeneration, "failed", failure);`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(post.NewsGeneration, "sending")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(post.NewsGeneration, "sending");`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("ai.news:" + trace, e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("ai.news:" + trace, e);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.applied", new { trace, kind = "news", posts = pending.Select(p => p.Id).ToArray() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.applied", new { trace, kind = "news", posts = pending.Select(p => p.Id).ToArray() });`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`pending.Any(p => p.NewsGeneration.State == "superseded")`；返回值紧邻使用处：`IfStatementSyntax: if (pending.Any(p => p.NewsGeneration.State == "superseded")) { foreach (var p in pending) { p.AiPending = false; CommunityThreads.SetWork(p.NewsGeneration, "superseded"); } return; }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`pending.Select(p => "post:" + p.Id)`；返回值紧邻使用处：`ArgumentSyntax: pending.Select(p => "post:" + p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`pending.Select(p => JsonSerializer.Deserialize<CommunityPost>(JsonSerializer.Serialize(p, Json))!)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pending.Select(p => JsonSerializer.Deserialize<CommunityPost>(JsonSerializer.Serialize(p, Json))!).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`pending.Select(p => p.Id)`；返回值紧邻使用处：`ArgumentSyntax: pending.Select(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`pending.Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pending.Select(p => p.Id).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`pending.Select(p => p.NewsGeneration)`；返回值紧邻使用处：`ArgumentSyntax: pending.Select(p => p.NewsGeneration)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`pending.Select(p => p.Id).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: posts = pending.Select(p => p.Id).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`snapshots.ToDictionary(p => p.Id, p => p.Revision)`；返回值紧邻使用处：`ArgumentSyntax: snapshots.ToDictionary(p => p.Id, p => p.Revision)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`pending.Select(p => JsonSerializer.Deserialize<CommunityPost>(JsonSerializer.Serialize(p, Json))!).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = pending.Select(p => JsonSerializer.Deserialize<CommunityPost>(JsonSerializer.Serialize(p, Json))!).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pending.Where(p => p.NewsGeneration.State is not ("completed" or "superseded"))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in pending.Where(p => p.NewsGeneration.State is not ("completed" or "superseded"))) { CommunityThreads.SetWork(post.NewsGeneration, "failed", failure); post.Revision++; CommunityThreads.Remember(data, post); }`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`pending.RemoveAll(p => p.NewsGeneration.State == "superseded")`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.RemoveAll(p => p.NewsGeneration.State == "superseded");`
- `System.DateTime.ToString(string?)`；输入表达式：`DateTime.UtcNow.ToString("yyyyMMdd")`；返回值紧邻使用处：`ArgumentSyntax: DateTime.UtcNow.ToString("yyyyMMdd")`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`
- `System.IDisposable.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: lease?.Dispose()`
- `System.Net.Http.Headers.AuthenticationHeaderValue.AuthenticationHeaderValue(string, string?)`；输入表达式：`new AuthenticationHeaderValue("Bearer", key)`；返回值紧邻使用处：`AssignmentExpressionSyntax: request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", key)`
- `System.Net.Http.HttpRequestMessage.HttpRequestMessage(System.Net.Http.HttpMethod, System.Uri?)`；输入表达式：`new HttpRequestMessage(HttpMethod.Post, uri)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HttpRequestMessage(HttpMethod.Post, uri)`
- `System.Net.Http.StringContent.StringContent(string, System.Text.Encoding?, string?)`；输入表达式：`new StringContent(payload, Encoding.UTF8, "application/json")`；返回值紧邻使用处：`AssignmentExpressionSyntax: request.Content = new StringContent(payload, Encoding.UTF8, "application/json")`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<CommunityPost>(JsonSerializer.Serialize(p, Json))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<CommunityPost>(JsonSerializer.Serialize(p, Json))!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(p, Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(p, Json)`
- `int.Parse(string)`；输入表达式：`int.Parse(DateTime.UtcNow.ToString("yyyyMMdd"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = int.Parse(DateTime.UtcNow.ToString("yyyyMMdd"))`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(key)) { Fail("未设置密钥"); return; }`

**赋值（含属性/字段和局部值）：**

- `Status` = `"正在生成社区讨论"`
- `Status` = `$"已发布 {pending.Count} 篇 AI 更新"`
- `data.Ai.RequestDay` = `today`
- `data.Ai.RequestsToday` = `0`
- `lease` = `await EnterQueueAsync(data, pending.Select(p => "post:" + p.Id), pending.Select(p => p.NewsGeneration))`
- `p.AiPending` = `false`
- `request.Content` = `new StringContent(payload, Encoding.UTF8, "application/json")`
- `request.Headers.Authorization` = `new AuthenticationHeaderValue("Bearer", key)`

<a id="symbol-e404a196f39a"></a>

## `Fail(string) — void Fail(string message)`

来源：源码第 178 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `failure` = `message`
- `Status` = `message`

<a id="symbol-28e7b92711a0"></a>

## `NationalSpire.AiService.BuildPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>) — private static string BuildPayload(CareerData data, List<CommunityPost> pending)`

来源：源码第 229 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AiService.BuildNewsPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.AiWireProtocol, string?)`](AiService.cs.md#symbol-847b058813c9)；[`NationalSpire.AiWireProtocol.AiWireProtocol(NationalSpire.CareerData)`](AiWireProtocol.cs.md#symbol-ebb8d59c054e)

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.BuildNewsPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.AiWireProtocol, string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.BuildNewsPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.AiWireProtocol, string?)`；输入表达式：`BuildNewsPayload(data, pending, new AiWireProtocol(data))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => BuildNewsPayload(data, pending, new AiWireProtocol(data))`
- `NationalSpire.AiWireProtocol.AiWireProtocol(NationalSpire.CareerData)`；输入表达式：`new AiWireProtocol(data)`；返回值紧邻使用处：`ArgumentSyntax: new AiWireProtocol(data)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-847b058813c9"></a>

## `NationalSpire.AiService.BuildNewsPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.AiWireProtocol, string?) — private static string BuildNewsPayload(CareerData data, List<CommunityPost> pending, AiWireProtocol wire, string? model = null)`

来源：源码第 230 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-28e7b92711a0)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)

**调用：** [`NationalSpire.AiService.BuildPrompt(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-73679a979463)；[`NationalSpire.AiService.ComposeSystem(NationalSpire.AiOptions, string)`](AiPrompts.cs.md#symbol-7a07a16bbdcd)；[`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`](AiService.cs.md#symbol-8c02bb75b41a)；[`NationalSpire.AiWireProtocol.Encode(string)`](AiWireProtocol.cs.md#symbol-bcdcbacd353a)；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string model, bool stream, <anonymous type: string role, string content>[] messages>.messages`；`<anonymous type: string model, bool stream, <anonymous type: string role, string content>[] messages>.model`；`<anonymous type: string model, bool stream, <anonymous type: string role, string content>[] messages>.stream`；`<anonymous type: string role, string content>.content`；`<anonymous type: string role, string content>.role`；`NationalSpire.AiConnection.Model`；`NationalSpire.AiService.BuildPrompt(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`；`NationalSpire.AiService.ComposeSystem(NationalSpire.AiOptions, string)`；`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；`NationalSpire.AiService.Json`；`NationalSpire.AiWireProtocol.Encode(string)`；`NationalSpire.CareerData.Ai`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.BuildPrompt(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`；输入表达式：`BuildPrompt(data, pending)`；返回值紧邻使用处：`ArgumentSyntax: BuildPrompt(data, pending)`
- `NationalSpire.AiService.ComposeSystem(NationalSpire.AiOptions, string)`；输入表达式：`ComposeSystem(data.Ai, "news")`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: content = ComposeSystem(data.Ai, "news")`
- `NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；输入表达式：`Connection(data.Ai, "news")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Connection(data.Ai, "news").Model`
- `NationalSpire.AiWireProtocol.Encode(string)`；输入表达式：`wire.Encode(BuildPrompt(data, pending))`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: content = wire.Encode(BuildPrompt(data, pending))`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new      {          model = model ?? Connection(data.Ai, "news").Model,          stream = false,          messages = new[] { new { role = "system", content = ComposeSystem(data.Ai, "news") }, new { role = "user", content = wire.Encode(BuildPrompt(data, pending)) } }      }, Json)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => JsonSerializer.Serialize(new      {          model = model ?? Connection(data.Ai, "news").Model,          stream = false,          messages = new[] { new { role = "system", content = ComposeSystem(data.Ai, "news") }, new { role = "user", content = wire.Encode(BuildPrompt(data, pending)) } }      }, Json)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-73679a979463"></a>

## `NationalSpire.AiService.BuildPrompt(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>) — private static string BuildPrompt(CareerData data, List<CommunityPost> pending)`

来源：源码第 237 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildNewsPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.AiWireProtocol, string?)`](AiService.cs.md#symbol-847b058813c9)

**调用：** [`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiContext.cs.md#symbol-7b21630a9e2c)

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`；输入表达式：`BuildNewsContext(data, pending)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => BuildNewsContext(data, pending)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-330f476ef7b2"></a>

## `NationalSpire.AiService.NewsCommenters(NationalSpire.CommunityPost, int) — private static IEnumerable<string> NewsCommenters(CommunityPost post, int postCount)`

来源：源码第 239 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiContext.cs.md#symbol-7b21630a9e2c)；[`NationalSpire.AiService.PromptPeople(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-8981dbfc57ac)；[`NewsPerson(NationalSpire.CareerPerson)`](AiContext.cs.md#symbol-9af6051969fe)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`post.Replies.Select(r => r.AuthorId).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Select(r => r.AuthorId).Distinct().Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`post.Replies.Select(r => r.AuthorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Select(r => r.AuthorId).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`post.Replies.Select(r => r.AuthorId).Distinct().Take(postCount > 1 ? 5 : int.MaxValue)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => post.Replies.Select(r => r.AuthorId).Distinct().Take(postCount > 1 ? 5 : int.MaxValue)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8981dbfc57ac"></a>

## `NationalSpire.AiService.PromptPeople(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>) — private static List<CareerPerson> PromptPeople(CareerData data, List<CommunityPost> pending)`

来源：源码第 242 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiContext.cs.md#symbol-7b21630a9e2c)

**调用：** [`NationalSpire.AiService.NewsCommenters(NationalSpire.CommunityPost, int)`](AiService.cs.md#symbol-330f476ef7b2)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.NewsCommenters(NationalSpire.CommunityPost, int)`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.NewsCommenters(NationalSpire.CommunityPost, int)`；输入表达式：`NewsCommenters(p, pending.Count)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => NewsCommenters(p, pending.Count)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.IsHuman(data, p.Id)`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SpireArbitration.Muted(p)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ids.Contains(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ids.Contains(p.Id) && !CommunityThreads.IsHuman(data, p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`pending.Select(p => p.AuthorId).Concat(pending.SelectMany(p => NewsCommenters(p, pending.Count)))              .Concat(pending.SelectMany(p => p.RelatedPeople))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pending.Select(p => p.AuthorId).Concat(pending.SelectMany(p => NewsCommenters(p, pending.Count)))              .Concat(pending.SelectMany(p => p.RelatedPeople)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`pending.Select(p => p.AuthorId).Concat(pending.SelectMany(p => NewsCommenters(p, pending.Count)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pending.Select(p => p.AuthorId).Concat(pending.SelectMany(p => NewsCommenters(p, pending.Count)))              .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`pending.Select(p => p.AuthorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pending.Select(p => p.AuthorId).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`pending.SelectMany(p => NewsCommenters(p, pending.Count))`；返回值紧邻使用处：`ArgumentSyntax: pending.SelectMany(p => NewsCommenters(p, pending.Count))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`pending.SelectMany(p => p.RelatedPeople)`；返回值紧邻使用处：`ArgumentSyntax: pending.SelectMany(p => p.RelatedPeople)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`pending.Select(p => p.AuthorId).Concat(pending.SelectMany(p => NewsCommenters(p, pending.Count)))              .Concat(pending.SelectMany(p => p.RelatedPeople)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = pending.Select(p => p.AuthorId).Concat(pending.SelectMany(p => NewsCommenters(p, pending.Count)))              .Concat(pending.SelectMany(p => p.RelatedPeople)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.People.Where(p => ids.Contains(p.Id) && !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p)).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return data.People.Where(p => ids.Contains(p.Id) && !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p)).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => ids.Contains(p.Id) && !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => ids.Contains(p.Id) && !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p)).ToList`

**赋值（含属性/字段和局部值）：**


<a id="symbol-51fbbe9c81d2"></a>

## `NationalSpire.AiService.ApplyResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string) — private static void ApplyResponse(CareerData data, List<CommunityPost> pending, string content)`

来源：源码第 249 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?)`](AiService.cs.md#symbol-5cb9c2055e1c)

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?)`；输入表达式：`ApplyNewsResponse(data, pending, content)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ApplyNewsResponse(data, pending, content)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5cb9c2055e1c"></a>

## `NationalSpire.AiService.ApplyNewsResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, System.Collections.Generic.Dictionary<string, long>?) — private static void ApplyNewsResponse(CareerData data, List<CommunityPost> pending, string content, Dictionary<string, long>? sourceRevisions = null)`

来源：源码第 251 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyResponse(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, string)`](AiService.cs.md#symbol-51fbbe9c81d2)；[`NationalSpire.AiService.ApplyTestResponse(NationalSpire.CareerData, NationalSpire.PromptTestSession, string)`](PromptTesting.cs.md#symbol-7208c4c08018)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)

**调用：** [`NationalSpire.AiService.ParseReplies(System.Text.Json.JsonElement, NationalSpire.CommunityPost, System.Collections.Generic.ISet<string>, bool, int, System.Collections.Generic.ISet<string>?, long?)`](AiDiscussion.cs.md#symbol-cc4afef5e780)；[`NationalSpire.AiService.ReadNetScore(System.Text.Json.JsonElement)`](AiDiscussion.cs.md#symbol-fca1e32de6dc)；[`NationalSpire.AiService.ReplyAuthors(NationalSpire.CareerData)`](AiDiscussion.cs.md#symbol-cd4df223dc51)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；[`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`](CommunityThreads.cs.md#symbol-981631ecddfc)；[`NationalSpire.CommunityVotes.ApplyScore(NationalSpire.CommunityPost, int?, long)`](CommunityVotes.cs.md#symbol-62957e04a626)；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.List()`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ParseReplies(System.Text.Json.JsonElement, NationalSpire.CommunityPost, System.Collections.Generic.ISet<string>, bool, int, System.Collections.Generic.ISet<string>?, long?)`；`NationalSpire.AiService.ReadNetScore(System.Text.Json.JsonElement)`；`NationalSpire.AiService.ReplyAuthors(NationalSpire.CareerData)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.Analysis`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityPost.SourceTitle`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；`NationalSpire.CommunityVotes.ApplyScore(NationalSpire.CommunityPost, int?, long)`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ParseReplies(System.Text.Json.JsonElement, NationalSpire.CommunityPost, System.Collections.Generic.ISet<string>, bool, int, System.Collections.Generic.ISet<string>?, long?)`；输入表达式：`ParseReplies(item.GetProperty("replies"), post, authors, false, data.Day, sourceRevision: revision)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ParseReplies(item.GetProperty("replies"), post, authors, false, data.Day, sourceRevision: revision)`
- `NationalSpire.AiService.ReadNetScore(System.Text.Json.JsonElement)`；输入表达式：`ReadNetScore(item)`；返回值紧邻使用处：`ArgumentSyntax: ReadNetScore(item)`
- `NationalSpire.AiService.ReplyAuthors(NationalSpire.CareerData)`；输入表达式：`ReplyAuthors(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReplyAuthors(data)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, post.AuthorId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, post.AuthorId) is { } author`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, r.AuthorId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, r.AuthorId) is { } p`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: post == null || CommunityThreads.IsHuman(data, post.AuthorId)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, r.AuthorId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => CommunityThreads.IsHuman(data, r.AuthorId)`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.Remember(data, item.Post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.Remember(data, item.Post);`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(item.Post.NewsGeneration, "completed")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(item.Post.NewsGeneration, "completed");`
- `NationalSpire.CommunityVotes.ApplyScore(NationalSpire.CommunityPost, int?, long)`；输入表达式：`CommunityVotes.ApplyScore(item.Post, item.Score, item.Revision)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityVotes.ApplyScore(item.Post, item.Score, item.Revision);`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(author)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, post.AuthorId) is { } author && SpireArbitration.Muted(author)`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, r.AuthorId) is { } p && SpireArbitration.Muted(p)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`seen.Add(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !seen.Add(id)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`item.Post.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))`；返回值紧邻使用处：`IfStatementSyntax: if (item.Post.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))) item.Post.Replies.AddRange(item.Replies); else item.Post.Replies = item.Replies;`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`replies.Any(r => CareerEngine.Person(data, r.AuthorId) is { } p && SpireArbitration.Muted(p))`；返回值紧邻使用处：`BinaryExpressionSyntax: replies.Any(r => CareerEngine.Person(data, r.AuthorId) is { } p && SpireArbitration.Muted(p)) || CareerEngine.Person(data, post.AuthorId) is { } author && SpireArbitration.Muted(author)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`pending.FirstOrDefault(p => p.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = pending.FirstOrDefault(p => p.Id == id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(post.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: sourceRevisions?.GetValueOrDefault(post.Id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`staged.Add((post, title, body, replies, ReadNetScore(item), revision))`；返回值紧邻使用处：`ExpressionStatementSyntax: staged.Add((post, title, body, replies, ReadNetScore(item), revision));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`item.Post.Replies.AddRange(item.Replies)`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Post.Replies.AddRange(item.Replies);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(CommunityPost Post, string Title, string Body, List<CommunityReply> Replies, int? Score, long Revision)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(CommunityPost Post, string Title, string Body, List<CommunityReply> Replies, int? Score, long Revision)>()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("发言者受到封号处分，本次内容未发布。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("发言者受到封号处分，本次内容未发布。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("帖子 ID 不符合请求")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("帖子 ID 不符合请求");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("批次不完整")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("批次不完整");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("标题无效")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("标题无效");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("正文无效")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("正文无效");`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(content)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(content)`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`parsed.RootElement.GetProperty("posts").EnumerateArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in parsed.RootElement.GetProperty("posts").EnumerateArray()) { string id = item.GetProperty("id").GetString() ?? ""; var post = pending.FirstOrDefault(p => p.Id == id); if (post == null || CommunityThreads.IsHuman(data, post.AuthorId) || !seen.Add(id)) throw new InvalidDataException("帖子 ID 不符合请求"); string body = item.GetProperty("body").GetString() ?? ""; string title = item.GetProperty("title").GetString() ?? ""; if (string.IsNullOrWhiteSpace(title)) throw new InvalidDataException("标题无效"); if (string.IsNullOrWhiteSpace(body)) throw new InvalidDataException("正文无效"); long revision = sourceRevisions?.GetValueOrDefault(post.Id) ?? post.Revision; var replies = ParseReplies(item.GetProperty("replies"), post, authors, false, data.Day, sourceRevision: revision); if (replies.Any(r => CareerEngine.Person(data, r.AuthorId) is { } p && SpireArbitration.Muted(p)) || CareerEngine.Person(data, post.AuthorId) is { } author && SpireArbitration.Muted(author)) throw new InvalidDataException("发言者受到封号处分，本次内容未发布。"); staged.Add((post, title, body, replies, ReadNetScore(item), revision)); }`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`item.GetProperty("body")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: item.GetProperty("body").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`item.GetProperty("id")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: item.GetProperty("id").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`item.GetProperty("replies")`；返回值紧邻使用处：`ArgumentSyntax: item.GetProperty("replies")`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`item.GetProperty("title")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: item.GetProperty("title").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`parsed.RootElement.GetProperty("posts")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parsed.RootElement.GetProperty("posts").EnumerateArray`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`item.GetProperty("body").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: item.GetProperty("body").GetString() ?? ""`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`item.GetProperty("id").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: item.GetProperty("id").GetString() ?? ""`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`item.GetProperty("title").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: item.GetProperty("title").GetString() ?? ""`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(body)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(body)) throw new InvalidDataException("正文无效");`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(title)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(title)) throw new InvalidDataException("标题无效");`

**赋值（含属性/字段和局部值）：**

- `item.Post.AiPending` = `false`
- `item.Post.Analysis` = `""`
- `item.Post.Body` = `item.Body`
- `item.Post.Replies` = `item.Replies`
- `item.Post.SourceBody` = `item.Post.Body`
- `item.Post.SourceTitle` = `item.Post.Title`
- `item.Post.Title` = `item.Title`

<a id="symbol-4f223cb1164e"></a>

## `NationalSpire.AiService.ReadResponseCompletion(System.Net.Http.HttpResponseMessage) — internal static async Task<string> ReadResponseCompletion(HttpResponseMessage response)`

来源：源码第 287 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`NationalSpire.AiService.ReadCompletion(System.Text.Json.JsonElement)`](AiService.cs.md#symbol-5620d387b01b)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；`System.IO.InvalidDataException.InvalidDataException(string?, System.Exception?)`；`System.Net.Http.HttpContent.ReadAsStringAsync()`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ReadCompletion(System.Text.Json.JsonElement)`；`NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ReadCompletion(System.Text.Json.JsonElement)`；输入表达式：`ReadCompletion(document.RootElement)`；返回值紧邻使用处：`ReturnStatementSyntax: return ReadCompletion(document.RootElement);`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact($"HTTP {(int)response.StatusCode} {response.ReasonPhrase}\n" + body)`；返回值紧邻使用处：`ArgumentSyntax: Diagnostics.Redact($"HTTP {(int)response.StatusCode} {response.ReasonPhrase}\n" + body)`
- `System.IO.InvalidDataException.InvalidDataException(string?, System.Exception?)`；输入表达式：`new InvalidDataException(Diagnostics.Redact($"HTTP {(int)response.StatusCode} {response.ReasonPhrase}\n" + body), error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(Diagnostics.Redact($"HTTP {(int)response.StatusCode} {response.ReasonPhrase}\n" + body), error);`
- `System.Net.Http.HttpContent.ReadAsStringAsync()`；输入表达式：`response.Content.ReadAsStringAsync()`；返回值紧邻使用处：`AwaitExpressionSyntax: await response.Content.ReadAsStringAsync()`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(body)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(body)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5620d387b01b"></a>

## `NationalSpire.AiService.ReadCompletion(System.Text.Json.JsonElement) — private static string ReadCompletion(JsonElement envelope)`

来源：源码第 300 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ReadResponseCompletion(System.Net.Http.HttpResponseMessage)`](AiService.cs.md#symbol-4f223cb1164e)

**调用：** `string.IsNullOrWhiteSpace(string?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetRawText()`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(content)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(content)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("模型未返回内容")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("模型未返回内容")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("模型未正常结束输出")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("模型未正常结束输出");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(error.GetRawText())`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(error.GetRawText());`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`choice.GetProperty("message").GetProperty("content")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choice.GetProperty("message").GetProperty("content").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`choice.GetProperty("message")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choice.GetProperty("message").GetProperty`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`envelope.GetProperty("choices")`；返回值紧邻使用处：`ElementAccessExpressionSyntax: envelope.GetProperty("choices")[0]`
- `System.Text.Json.JsonElement.GetRawText()`；输入表达式：`error.GetRawText()`；返回值紧邻使用处：`ArgumentSyntax: error.GetRawText()`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`choice.GetProperty("message").GetProperty("content").GetString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = choice.GetProperty("message").GetProperty("content").GetString()`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`reason.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: reason.GetString() != "stop"`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`choice.TryGetProperty("finish_reason", out var reason)`；返回值紧邻使用处：`BinaryExpressionSyntax: choice.TryGetProperty("finish_reason", out var reason) && reason.ValueKind != JsonValueKind.Null`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`envelope.TryGetProperty("error", out var error)`；返回值紧邻使用处：`IfStatementSyntax: if (envelope.TryGetProperty("error", out var error)) throw new InvalidDataException(error.GetRawText());`

**赋值（含属性/字段和局部值）：**
