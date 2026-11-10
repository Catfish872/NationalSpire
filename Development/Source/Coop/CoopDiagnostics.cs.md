# Coop/CoopDiagnostics.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`036C284AA4EB103386D6B6F6A6D27C43F88CD51D37173EB6723B9FCF4234CFA1`。来源：[源码](../../../Coop/CoopDiagnostics.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopDiagnosticRequest`、`NationalSpire.Coop.CoopDiagnosticPart`、`NationalSpire.Coop.CoopCoordinator`。

字段、事件及初始值（源码原样）：

```csharp
private string _diagnosticId = "", _diagnosticEpoch = "";
private readonly Dictionary<ulong, CoopAssembler> _diagnosticAssemblers = [];
private readonly Dictionary<ulong, Dictionary<string, string>> _diagnosticReports = [];
private readonly Dictionary<ulong, Task<Dictionary<string, string>>> _diagnosticDecoding = [];
private Task<Dictionary<string, string>>? _diagnosticCollection;
private CoopDiagnosticRequest? _diagnosticSending;
private Task<CoopPart[]>? _diagnosticPreparing;
private Queue<int> _diagnosticIndices = [];
private bool _diagnosticSendStarted;
```

<a id="symbol-8e9d7682906f"></a>

## `NationalSpire.Coop.CoopCoordinator.CaptureDiagnostics — public Func<Dictionary<string, string>>? CaptureDiagnostics`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3673c645e7c7"></a>

## `NationalSpire.Coop.CoopCoordinator.CollectDiagnostics(System.TimeSpan?) — public Task<Dictionary<string, string>> CollectDiagnostics(TimeSpan? timeout = null)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.Export()`](CoopCareerSession.cs.md#symbol-24a80da4bec4)

**调用：** [`NationalSpire.Coop.CoopCoordinator.CollectDiagnosticReports(System.TimeSpan?)`](CoopDiagnostics.cs.md#symbol-44ff9d375651)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._diagnosticCollection`；`NationalSpire.Coop.CoopCoordinator.CollectDiagnosticReports(System.TimeSpan?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.CollectDiagnosticReports(System.TimeSpan?)`；输入表达式：`CollectDiagnosticReports(timeout)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticCollection = CollectDiagnosticReports(timeout)`

**赋值（含属性/字段和局部值）：**

- `_diagnosticCollection` = `CollectDiagnosticReports(timeout)`

<a id="symbol-44ff9d375651"></a>

## `NationalSpire.Coop.CoopCoordinator.CollectDiagnosticReports(System.TimeSpan?) — private async Task<Dictionary<string, string>> CollectDiagnosticReports(TimeSpan? timeout)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.CollectDiagnostics(System.TimeSpan?)`](CoopDiagnostics.cs.md#symbol-3673c645e7c7)

**调用：** [`NationalSpire.Coop.CoopAssembler.Missing()`](CoopWire.cs.md#symbol-dcb9a42ff122)；[`NationalSpire.Coop.CoopCoordinator.SendDiagnostic<T>(ulong, string, T)`](CoopDiagnostics.cs.md#symbol-88bc4c237586)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`NationalSpire.Coop.CoopAssembler.CoopAssembler(bool)`；`NationalSpire.Coop.CoopDiagnosticRequest.CoopDiagnosticRequest(string, string, int[]?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Threading.Tasks.Task.Delay(int)`；`System.Threading.Tasks.Task.WhenAll<TResult>(params System.Threading.Tasks.Task<TResult>[])`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `<anonymous type: ulong SteamId, string Name, string status>.status`；`NationalSpire.Coop.CoopAssembler.Missing()`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._diagnosticAssemblers`；`NationalSpire.Coop.CoopCoordinator._diagnosticDecoding`；`NationalSpire.Coop.CoopCoordinator._diagnosticEpoch`；`NationalSpire.Coop.CoopCoordinator._diagnosticId`；`NationalSpire.Coop.CoopCoordinator._diagnosticReports`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.SendDiagnostic<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.CoopAssembler(bool)`；输入表达式：`new(diagnostic: true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticAssemblers[member.SteamId] = new(diagnostic: true)`
- `NationalSpire.Coop.CoopAssembler.Missing()`；输入表达式：`pair.Value.Missing()`；返回值紧邻使用处：`ArgumentSyntax: pair.Value.Missing()`
- `NationalSpire.Coop.CoopCoordinator.SendDiagnostic<T>(ulong, string, T)`；输入表达式：`SendDiagnostic(member.SteamId, "diagnostics-done", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch))`；返回值紧邻使用处：`ExpressionStatementSyntax: SendDiagnostic(member.SteamId, "diagnostics-done", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch));`
- `NationalSpire.Coop.CoopCoordinator.SendDiagnostic<T>(ulong, string, T)`；输入表达式：`SendDiagnostic(pair.Key, "diagnostics-request", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch, pair.Value.Missing()))`；返回值紧邻使用处：`ExpressionStatementSyntax: SendDiagnostic(pair.Key, "diagnostics-request", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch, pair.Value.Missing()));`
- `NationalSpire.Coop.CoopDiagnosticRequest.CoopDiagnosticRequest(string, string, int[]?)`；输入表达式：`new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch, pair.Value.Missing())`；返回值紧邻使用处：`ArgumentSyntax: new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch, pair.Value.Missing())`
- `NationalSpire.Coop.CoopDiagnosticRequest.CoopDiagnosticRequest(string, string, int[]?)`；输入表达式：`new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch)`；返回值紧邻使用处：`ArgumentSyntax: new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.diagnostics.finish", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.diagnostics.finish", error);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_diagnosticAssemblers.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _diagnosticAssemblers.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_diagnosticDecoding.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _diagnosticDecoding.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_diagnosticReports.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _diagnosticReports.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_diagnosticDecoding.ContainsKey(p.Key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_diagnosticDecoding.ContainsKey(p.Key)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_diagnosticReports.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_diagnosticReports.ContainsKey(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_diagnosticReports.ContainsKey(p.Key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_diagnosticReports.ContainsKey(p.Key)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_diagnosticReports.TryGetValue(member.SteamId, out var report)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _diagnosticReports.TryGetValue(member.SteamId, out var report)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`Online.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !_diagnosticReports.ContainsKey(id) && Online.Contains(id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`online.Contains(m.SteamId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => online.Contains(m.SteamId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`online.Contains(member.SteamId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: online.Contains(member.SteamId) ? "超时或连接中断，已保留本机报告" : "离线，无法收集"`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`Online.Contains(p.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: !_diagnosticReports.ContainsKey(p.Key) && !_diagnosticDecoding.ContainsKey(p.Key) && Online.Contains(p.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_diagnosticAssemblers.Keys.Any(id => !_diagnosticReports.ContainsKey(id) && Online.Contains(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: !_closed && World?.Epoch == _diagnosticEpoch                 && (timeout == null || DateTime.UtcNow - started < timeout)                 && _diagnosticAssemblers.Keys.Any(id => !_diagnosticReports.ContainsKey(id) && Online.Contains(id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_diagnosticDecoding.Values.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: _diagnosticDecoding.Values.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`World.Members.Where(m => m.SteamId != Self).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = World.Members.Where(m => m.SteamId != Self).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_diagnosticAssemblers.Where(p => !_diagnosticReports.ContainsKey(p.Key) && !_diagnosticDecoding.ContainsKey(p.Key) && Online.Contains(p.Key))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var pair in _diagnosticAssemblers.Where(p => !_diagnosticReports.ContainsKey(p.Key) && !_diagnosticDecoding.ContainsKey(p.Key) && Online.Contains(p.Key)))                         SendDiagnostic(pair.Key, "diagnostics-request", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch, pair.Value.Missing()));`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`members.Where(m => online.Contains(m.SteamId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var member in members.Where(m => online.Contains(m.SteamId))) _diagnosticAssemblers[member.SteamId] = new(diagnostic: true);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.Where(m => m.SteamId != Self)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: World.Members.Where(m => m.SteamId != Self).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`statuses.Add(new { member.SteamId, member.Name, status = received ? "已收集" : online.Contains(member.SteamId) ? "超时或连接中断，已保留本机报告" : "离线，无法收集" })`；返回值紧邻使用处：`ExpressionStatementSyntax: statuses.Add(new { member.SteamId, member.Name, status = received ? "已收集" : online.Contains(member.SteamId) ? "超时或连接中断，已保留本机报告" : "离线，无法收集" });`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<object>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<object>()`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticId = Guid.NewGuid().ToString("N")`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(statuses, CoopJson.Options)`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["peers/collection.json"] = JsonSerializer.Serialize(statuses, CoopJson.Options)`
- `System.Threading.Tasks.Task.Delay(int)`；输入表达式：`Task.Delay(100)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Delay(100)`
- `System.Threading.Tasks.Task.WhenAll<TResult>(params System.Threading.Tasks.Task<TResult>[])`；输入表达式：`Task.WhenAll(_diagnosticDecoding.Values.ToArray())`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.WhenAll(_diagnosticDecoding.Values.ToArray())`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(3)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - requested >= TimeSpan.FromSeconds(3)`

**赋值（含属性/字段和局部值）：**

- `_diagnosticAssemblers[member.SteamId]` = `new(diagnostic: true)`
- `_diagnosticEpoch` = `World.Epoch`
- `_diagnosticId` = `""`
- `_diagnosticId` = `Guid.NewGuid().ToString("N")`
- `files["peers/collection.json"]` = `JsonSerializer.Serialize(statuses, CoopJson.Options)`
- `files[$"peers/{member.SteamId}/{entry.Key}"]` = `entry.Value`
- `requested` = `DateTime.UtcNow`

<a id="symbol-88bc4c237586"></a>

## `NationalSpire.Coop.CoopCoordinator.SendDiagnostic<T>(ulong, string, T) — private void SendDiagnostic<T>(ulong peer, string kind, T value)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.CollectDiagnosticReports(System.TimeSpan?)`](CoopDiagnostics.cs.md#symbol-44ff9d375651)；[`NationalSpire.Coop.CoopCoordinator.PumpDiagnostics()`](CoopDiagnostics.cs.md#symbol-3c9a89501f77)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(peer, kind, value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(peer, kind, value);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.diagnostics.send", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.diagnostics.send", error);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3c9a89501f77"></a>

## `NationalSpire.Coop.CoopCoordinator.PumpDiagnostics() — private void PumpDiagnostics()`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)

**调用：** [`NationalSpire.Coop.CoopCoordinator.SendDiagnostic<T>(ulong, string, T)`](CoopDiagnostics.cs.md#symbol-88bc4c237586)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`NationalSpire.Coop.CoopAssembler.CoopAssembler(bool)`；`NationalSpire.Coop.CoopDiagnosticPart.CoopDiagnosticPart(string, string, NationalSpire.Coop.CoopPart)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Collections.Generic.Queue<T>.Queue(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.Queue<T>.TryDequeue(out T)`；`System.Linq.Enumerable.Range(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._diagnosticAssemblers`；`NationalSpire.Coop.CoopCoordinator._diagnosticDecoding`；`NationalSpire.Coop.CoopCoordinator._diagnosticIndices`；`NationalSpire.Coop.CoopCoordinator._diagnosticPreparing`；`NationalSpire.Coop.CoopCoordinator._diagnosticReports`；`NationalSpire.Coop.CoopCoordinator._diagnosticSending`；`NationalSpire.Coop.CoopCoordinator._diagnosticSendStarted`；`NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.SendDiagnostic<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopDiagnosticRequest.Epoch`；`NationalSpire.Coop.CoopDiagnosticRequest.Id`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.CoopAssembler(bool)`；输入表达式：`new(diagnostic: true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticAssemblers[pair.Key] = new(diagnostic: true)`
- `NationalSpire.Coop.CoopCoordinator.SendDiagnostic<T>(ulong, string, T)`；输入表达式：`SendDiagnostic(World!.Owner, "diagnostics-part", new CoopDiagnosticPart(sending.Id, sending.Epoch, prepared.Result[index]))`；返回值紧邻使用处：`ExpressionStatementSyntax: SendDiagnostic(World!.Owner, "diagnostics-part", new CoopDiagnosticPart(sending.Id, sending.Epoch, prepared.Result[index]));`
- `NationalSpire.Coop.CoopDiagnosticPart.CoopDiagnosticPart(string, string, NationalSpire.Coop.CoopPart)`；输入表达式：`new CoopDiagnosticPart(sending.Id, sending.Epoch, prepared.Result[index])`；返回值紧邻使用处：`ArgumentSyntax: new CoopDiagnosticPart(sending.Id, sending.Epoch, prepared.Result[index])`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.diagnostics.decode", pair.Value.Exception!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.diagnostics.decode", pair.Value.Exception!);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.diagnostics.prepare", prepared.Exception!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.diagnostics.prepare", prepared.Exception!);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_diagnosticDecoding.Remove(pair.Key)`；返回值紧邻使用处：`ExpressionStatementSyntax: _diagnosticDecoding.Remove(pair.Key);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`Online.Contains(World.Owner)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Online.Contains(World.Owner)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_diagnosticDecoding.Where(p => p.Value.IsCompleted).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var pair in _diagnosticDecoding.Where(p => p.Value.IsCompleted).ToArray())         {             _diagnosticDecoding.Remove(pair.Key);             if (pair.Value.IsCompletedSuccessfully) _diagnosticReports[pair.Key] = pair.Value.Result;             else { Diagnostics.Error("coop.diagnostics.decode", pair.Value.Exception!); _diagnosticAssemblers[pair.Key] = new(diagnostic: true); }         }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_diagnosticDecoding.Where(p => p.Value.IsCompleted)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _diagnosticDecoding.Where(p => p.Value.IsCompleted).ToArray`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_diagnosticIndices.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _diagnosticIndices.Clear();`
- `System.Collections.Generic.Queue<T>.Queue(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new(Enumerable.Range(0, prepared.Result.Length))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticIndices = new(Enumerable.Range(0, prepared.Result.Length))`
- `System.Collections.Generic.Queue<T>.TryDequeue(out T)`；输入表达式：`_diagnosticIndices.TryDequeue(out int index)`；返回值紧邻使用处：`IfStatementSyntax: if (_diagnosticIndices.TryDequeue(out int index))             SendDiagnostic(World!.Owner, "diagnostics-part", new CoopDiagnosticPart(sending.Id, sending.Epoch, prepared.Result[index]));`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, prepared.Result.Length)`；返回值紧邻使用处：`ArgumentSyntax: Enumerable.Range(0, prepared.Result.Length)`

**赋值（含属性/字段和局部值）：**

- `_diagnosticAssemblers[pair.Key]` = `new(diagnostic: true)`
- `_diagnosticIndices` = `new(Enumerable.Range(0, prepared.Result.Length))`
- `_diagnosticPreparing` = `null`
- `_diagnosticReports[pair.Key]` = `pair.Value.Result`
- `_diagnosticSending` = `null`
- `_diagnosticSendStarted` = `true`

<a id="symbol-fefabf8d6a26"></a>

## `NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire) — private void ReceiveDiagnostic(ulong sender, CoopWire wire)`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)

**调用：** [`NationalSpire.Coop.CoopAssembler.Collect(NationalSpire.Coop.CoopPart, System.DateTime)`](CoopWire.cs.md#symbol-35fc52cbee4a)；[`NationalSpire.Coop.CoopAssembler.Complete.Decode(bool)`](CoopWire.cs.md#symbol-8c8a54666033)；[`NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`](CoopWire.cs.md#symbol-d89dceccb833)；[`NationalSpire.Coop.CoopCoordinator.AllowedReportName(string)`](CoopDiagnostics.cs.md#symbol-9034c731e516)；[`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-4239da75be84)；[`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Redact(string)`](../Diagnostics.cs.md#symbol-f014e01c492a)；`NationalSpire.Coop.CoopAssembler.CoopAssembler(bool)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Collections.Generic.Queue<T>.Queue(System.Collections.Generic.IEnumerable<T>)`；`System.Exception.ToString()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Guid.TryParseExact(string?, string?, out System.Guid)`；`System.Linq.Enumerable.Range(int, int)`；`System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`；`System.Threading.Tasks.Task<TResult>.ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>, System.Threading.Tasks.TaskContinuationOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAssembler.Collect(NationalSpire.Coop.CoopPart, System.DateTime)`；`NationalSpire.Coop.CoopAssembler.Complete.Decode(bool)`；`NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`；`NationalSpire.Coop.CoopCoordinator._diagnosticAssemblers`；`NationalSpire.Coop.CoopCoordinator._diagnosticDecoding`；`NationalSpire.Coop.CoopCoordinator._diagnosticEpoch`；`NationalSpire.Coop.CoopCoordinator._diagnosticId`；`NationalSpire.Coop.CoopCoordinator._diagnosticIndices`；`NationalSpire.Coop.CoopCoordinator._diagnosticPreparing`；`NationalSpire.Coop.CoopCoordinator._diagnosticReports`；`NationalSpire.Coop.CoopCoordinator._diagnosticSending`；`NationalSpire.Coop.CoopCoordinator._diagnosticSendStarted`；`NationalSpire.Coop.CoopCoordinator.AllowedReportName(string)`；`NationalSpire.Coop.CoopCoordinator.CaptureDiagnostics`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopDiagnosticPart.Epoch`；`NationalSpire.Coop.CoopDiagnosticPart.Id`；`NationalSpire.Coop.CoopDiagnosticPart.Part`；`NationalSpire.Coop.CoopDiagnosticRequest.Epoch`；`NationalSpire.Coop.CoopDiagnosticRequest.Id`；`NationalSpire.Coop.CoopDiagnosticRequest.Missing`；`NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.Coop.CoopWire.Kind`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.Collect(NationalSpire.Coop.CoopPart, System.DateTime)`；输入表达式：`assembler.Collect(part.Part, DateTime.UtcNow)`；返回值紧邻使用处：`IsPatternExpressionSyntax: assembler.Collect(part.Part, DateTime.UtcNow) is not { } complete`
- `NationalSpire.Coop.CoopAssembler.Complete.Decode(bool)`；输入表达式：`complete.Decode(diagnostic: true)`；返回值紧邻使用处：`ArgumentSyntax: complete.Decode(diagnostic: true)`
- `NationalSpire.Coop.CoopAssembler.CoopAssembler(bool)`；输入表达式：`new(diagnostic: true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticAssemblers[sender] = new(diagnostic: true)`
- `NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`；输入表达式：`CoopAssembler.Split(CoopJson.Bytes(files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))), diagnostic: true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CoopAssembler.Split(CoopJson.Bytes(files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))), diagnostic: true).ToArray`
- `NationalSpire.Coop.CoopCoordinator.AllowedReportName(string)`；输入表达式：`AllowedReportName(p.Key)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => AllowedReportName(p.Key)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopDiagnosticPart>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<CoopDiagnosticPart>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopDiagnosticRequest>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<CoopDiagnosticRequest>(wire)`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value)))`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value)))`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<Dictionary<string, string>>(complete.Decode(diagnostic: true))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CoopJson.Read<Dictionary<string, string>>(complete.Decode(diagnostic: true))                     .Where`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.diagnostics.receive", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.diagnostics.receive", error);`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(error.ToString())`；返回值紧邻使用处：`BinaryExpressionSyntax: "读取日志失败：" + Diagnostics.Redact(error.ToString())`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(p.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Diagnostics.Redact(p.Value)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_diagnosticAssemblers.ContainsKey(sender)`；返回值紧邻使用处：`BinaryExpressionSyntax: Host && _diagnosticAssemblers.ContainsKey(sender)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_diagnosticDecoding.ContainsKey(sender)`；返回值紧邻使用处：`BinaryExpressionSyntax: part.Id != _diagnosticId || part.Epoch != _diagnosticEpoch || _diagnosticReports.ContainsKey(sender) || _diagnosticDecoding.ContainsKey(sender)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_diagnosticReports.ContainsKey(sender)`；返回值紧邻使用处：`BinaryExpressionSyntax: part.Id != _diagnosticId || part.Epoch != _diagnosticEpoch || _diagnosticReports.ContainsKey(sender)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["notes.txt"] = "此客户端无法提供运行日志。" }`；返回值紧邻使用处：`BinaryExpressionSyntax: CaptureDiagnostics?.Invoke() ?? new() { ["notes.txt"] = "此客户端无法提供运行日志。" }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["notes.txt"] = "读取日志失败：" + Diagnostics.Redact(error.ToString()) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: files = new() { ["notes.txt"] = "读取日志失败：" + Diagnostics.Redact(error.ToString()) }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_diagnosticAssemblers.TryGetValue(sender, out var assembler)`；返回值紧邻使用处：`BinaryExpressionSyntax: wire.Kind == "diagnostics-part" && Host && _diagnosticId.Length > 0 && _diagnosticAssemblers.TryGetValue(sender, out var assembler)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`CoopAssembler.Split(CoopJson.Bytes(files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))), diagnostic: true).ToArray()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => CoopAssembler.Split(CoopJson.Bytes(files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))), diagnostic: true).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0, ready.Result.Length).ToArray()`；返回值紧邻使用处：`BinaryExpressionSyntax: request.Missing ?? Enumerable.Range(0, ready.Result.Length).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`CoopJson.Read<Dictionary<string, string>>(complete.Decode(diagnostic: true))                     .Where(p => AllowedReportName(p.Key)).ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => CoopJson.Read<Dictionary<string, string>>(complete.Decode(diagnostic: true))                     .Where(p => AllowedReportName(p.Key)).ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))`；返回值紧邻使用处：`ArgumentSyntax: files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(request.Missing ?? Enumerable.Range(0, ready.Result.Length).ToArray()).Where(i => i >= 0 && i < ready.Result.Length)`；返回值紧邻使用处：`ArgumentSyntax: (request.Missing ?? Enumerable.Range(0, ready.Result.Length).ToArray()).Where(i => i >= 0 && i < ready.Result.Length)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CoopJson.Read<Dictionary<string, string>>(complete.Decode(diagnostic: true))                     .Where(p => AllowedReportName(p.Key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CoopJson.Read<Dictionary<string, string>>(complete.Decode(diagnostic: true))                     .Where(p => AllowedReportName(p.Key)).ToDictionary`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_diagnosticIndices.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _diagnosticIndices.Clear();`
- `System.Collections.Generic.Queue<T>.Queue(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new((request.Missing ?? Enumerable.Range(0, ready.Result.Length).ToArray()).Where(i => i >= 0 && i < ready.Result.Length))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticIndices = new((request.Missing ?? Enumerable.Range(0, ready.Result.Length).ToArray()).Where(i => i >= 0 && i < ready.Result.Length))`
- `System.Exception.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`ArgumentSyntax: error.ToString()`
- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CaptureDiagnostics?.Invoke()`
- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(request.Id, "N", out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Guid.TryParseExact(request.Id, "N", out _)`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, ready.Result.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, ready.Result.Length).ToArray`
- `System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`；输入表达式：`Task.Run(() => CoopAssembler.Split(CoopJson.Bytes(files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))), diagnostic: true).ToArray())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticPreparing = Task.Run(() => CoopAssembler.Split(CoopJson.Bytes(files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))), diagnostic: true).ToArray())`
- `System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`；输入表达式：`Task.Run(() => CoopJson.Read<Dictionary<string, string>>(complete.Decode(diagnostic: true))                     .Where(p => AllowedReportName(p.Key)).ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticDecoding[sender] = Task.Run(() => CoopJson.Read<Dictionary<string, string>>(complete.Decode(diagnostic: true))                     .Where(p => AllowedReportName(p.Key)).ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value)))`
- `System.Threading.Tasks.Task<TResult>.ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>, System.Threading.Tasks.TaskContinuationOptions)`；输入表达式：`_diagnosticPreparing.ContinueWith(task => { _ = task.Exception; }, TaskContinuationOptions.OnlyOnFaulted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = _diagnosticPreparing.ContinueWith(task => { _ = task.Exception; }, TaskContinuationOptions.OnlyOnFaulted)`

**赋值（含属性/字段和局部值）：**

- `_` = `_diagnosticPreparing.ContinueWith(task => { _ = task.Exception; }, TaskContinuationOptions.OnlyOnFaulted)`
- `_` = `task.Exception`
- `_diagnosticAssemblers[sender]` = `new(diagnostic: true)`
- `_diagnosticDecoding[sender]` = `Task.Run(() => CoopJson.Read<Dictionary<string, string>>(complete.Decode(diagnostic: true))                     .Where(p => AllowedReportName(p.Key)).ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value)))`
- `_diagnosticIndices` = `new((request.Missing ?? Enumerable.Range(0, ready.Result.Length).ToArray()).Where(i => i >= 0 && i < ready.Result.Length))`
- `_diagnosticPreparing` = `null`
- `_diagnosticPreparing` = `Task.Run(() => CoopAssembler.Split(CoopJson.Bytes(files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))), diagnostic: true).ToArray())`
- `_diagnosticSending` = `null`
- `_diagnosticSending` = `request`
- `_diagnosticSendStarted` = `false`
- `["notes.txt"]` = `"此客户端无法提供运行日志。"`
- `["notes.txt"]` = `"读取日志失败：" + Diagnostics.Redact(error.ToString())`
- `files` = `CaptureDiagnostics?.Invoke() ?? new() { ["notes.txt"] = "此客户端无法提供运行日志。" }`
- `files` = `new() { ["notes.txt"] = "读取日志失败：" + Diagnostics.Redact(error.ToString()) }`

<a id="symbol-07bc8f9e58a0"></a>

## `NationalSpire.Coop.CoopCoordinator.CloseDiagnostics() — private void CloseDiagnostics()`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Dispose()`](CoopCoordinator.cs.md#symbol-a57b33d7004f)

**调用：** `System.Collections.Generic.Queue<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._diagnosticCollection`；`NationalSpire.Coop.CoopCoordinator._diagnosticIndices`；`NationalSpire.Coop.CoopCoordinator._diagnosticPreparing`；`NationalSpire.Coop.CoopCoordinator._diagnosticSending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_diagnosticIndices.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _diagnosticIndices.Clear();`

**赋值（含属性/字段和局部值）：**

- `_diagnosticCollection` = `null`
- `_diagnosticPreparing` = `null`
- `_diagnosticSending` = `null`

<a id="symbol-9034c731e516"></a>

## `NationalSpire.Coop.CoopCoordinator.AllowedReportName(string) — private static bool AllowedReportName(string name)`

来源：源码第 143 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](CoopDiagnostics.cs.md#symbol-fefabf8d6a26)

**调用：** `string.Contains(char)`；`string.Contains(string)`；`string.StartsWith(char)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Contains(char)`；输入表达式：`name.Contains(':')`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !name.Contains(':')`
- `string.Contains(char)`；输入表达式：`name.Contains('\\')`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !name.Contains('\\')`
- `string.Contains(string)`；输入表达式：`name.Contains("..")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !name.Contains("..")`
- `string.StartsWith(char)`；输入表达式：`name.StartsWith('/')`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !name.StartsWith('/')`

**赋值（含属性/字段和局部值）：**
