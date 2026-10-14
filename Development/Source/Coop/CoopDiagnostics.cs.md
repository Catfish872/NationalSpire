# Coop/CoopDiagnostics.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`2E39B826C5852B6A23376AE4BE450817B3C5FB0CC50D126FEC80EABE43E145D6`。来源：[源码](../../../Coop/CoopDiagnostics.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopDiagnosticRequest`、`NationalSpire.Coop.CoopDiagnosticPart`、`NationalSpire.Coop.CoopCoordinator`。

字段、事件及初始值（源码原样）：

```csharp
private string _diagnosticId = "", _diagnosticEpoch = "";
private DateTime _lastDiagnosticRequest;
private readonly Dictionary<ulong, CoopAssembler> _diagnosticAssemblers = [];
private readonly Dictionary<ulong, Dictionary<string, string>> _diagnosticReports = [];
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

## `NationalSpire.Coop.CoopCoordinator.CollectDiagnostics(System.TimeSpan?) — public async Task<Dictionary<string, string>> CollectDiagnostics(TimeSpan? timeout = null)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.Export()`](CoopCareerSession.cs.md#symbol-24a80da4bec4)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；`NationalSpire.Coop.CoopAssembler.CoopAssembler()`；`NationalSpire.Coop.CoopDiagnosticRequest.CoopDiagnosticRequest(string, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Threading.Tasks.Task.Delay(int)`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `<anonymous type: ulong SteamId, string Name, string status>.status`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._diagnosticAssemblers`；`NationalSpire.Coop.CoopCoordinator._diagnosticEpoch`；`NationalSpire.Coop.CoopCoordinator._diagnosticId`；`NationalSpire.Coop.CoopCoordinator._diagnosticReports`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.CoopAssembler()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticAssemblers[member.SteamId] = new()`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(member.SteamId, "diagnostics-request", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(member.SteamId, "diagnostics-request", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch));`
- `NationalSpire.Coop.CoopDiagnosticRequest.CoopDiagnosticRequest(string, string)`；输入表达式：`new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch)`；返回值紧邻使用处：`ArgumentSyntax: new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_diagnosticAssemblers.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _diagnosticAssemblers.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_diagnosticReports.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _diagnosticReports.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_diagnosticReports.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_diagnosticReports.ContainsKey(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_diagnosticReports.TryGetValue(member.SteamId, out var report)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _diagnosticReports.TryGetValue(member.SteamId, out var report)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`online.Contains(m.SteamId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => online.Contains(m.SteamId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`online.Contains(member.SteamId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: online.Contains(member.SteamId) ? "超时或连接中断" : "离线，无法收集"`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_diagnosticAssemblers.Keys.Any(id => !_diagnosticReports.ContainsKey(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: !_closed && World?.Epoch == _diagnosticEpoch && DateTime.UtcNow < until                 && _diagnosticAssemblers.Keys.Any(id => !_diagnosticReports.ContainsKey(id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`World.Members.Where(m => m.SteamId != Self).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = World.Members.Where(m => m.SteamId != Self).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`members.Where(m => online.Contains(m.SteamId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var member in members.Where(m => online.Contains(m.SteamId)))             {                 _diagnosticAssemblers[member.SteamId] = new();                 Send(member.SteamId, "diagnostics-request", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch));             }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.Where(m => m.SteamId != Self)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: World.Members.Where(m => m.SteamId != Self).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`statuses.Add(new { member.SteamId, member.Name, status = received ? "已收集" : online.Contains(member.SteamId) ? "超时或连接中断" : "离线，无法收集" })`；返回值紧邻使用处：`ExpressionStatementSyntax: statuses.Add(new { member.SteamId, member.Name, status = received ? "已收集" : online.Contains(member.SteamId) ? "超时或连接中断" : "离线，无法收集" });`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<object>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<object>()`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticId = Guid.NewGuid().ToString("N")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("正在收集队友报告，请稍候。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("正在收集队友报告，请稍候。");`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(statuses, CoopJson.Options)`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["peers/collection.json"] = JsonSerializer.Serialize(statuses, CoopJson.Options)`
- `System.Threading.Tasks.Task.Delay(int)`；输入表达式：`Task.Delay(100)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Delay(100)`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(20)`；返回值紧邻使用处：`BinaryExpressionSyntax: timeout ?? TimeSpan.FromSeconds(20)`

**赋值（含属性/字段和局部值）：**

- `_diagnosticAssemblers[member.SteamId]` = `new()`
- `_diagnosticEpoch` = `World.Epoch`
- `_diagnosticId` = `""`
- `_diagnosticId` = `Guid.NewGuid().ToString("N")`
- `files["peers/collection.json"]` = `JsonSerializer.Serialize(statuses, CoopJson.Options)`
- `files[$"peers/{member.SteamId}/{entry.Key}"]` = `entry.Value`

<a id="symbol-fefabf8d6a26"></a>

## `NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire) — private void ReceiveDiagnostic(ulong sender, CoopWire wire)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)

**调用：** [`NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart)`](CoopWire.cs.md#symbol-b544da8202a5)；[`NationalSpire.Coop.CoopAssembler.Split(byte[])`](CoopWire.cs.md#symbol-67ad26af4646)；[`NationalSpire.Coop.CoopCoordinator.AllowedReportName(string)`](CoopDiagnostics.cs.md#symbol-9034c731e516)；[`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-4239da75be84)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；[`NationalSpire.Diagnostics.Redact(string)`](../Diagnostics.cs.md#symbol-f014e01c492a)；`NationalSpire.Coop.CoopDiagnosticPart.CoopDiagnosticPart(string, string, NationalSpire.Coop.CoopPart)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Exception.ToString()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Guid.TryParseExact(string?, string?, out System.Guid)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart)`；`NationalSpire.Coop.CoopAssembler.Split(byte[])`；`NationalSpire.Coop.CoopCoordinator._diagnosticAssemblers`；`NationalSpire.Coop.CoopCoordinator._diagnosticEpoch`；`NationalSpire.Coop.CoopCoordinator._diagnosticId`；`NationalSpire.Coop.CoopCoordinator._diagnosticReports`；`NationalSpire.Coop.CoopCoordinator._lastDiagnosticRequest`；`NationalSpire.Coop.CoopCoordinator.AllowedReportName(string)`；`NationalSpire.Coop.CoopCoordinator.CaptureDiagnostics`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopDiagnosticPart.Epoch`；`NationalSpire.Coop.CoopDiagnosticPart.Id`；`NationalSpire.Coop.CoopDiagnosticPart.Part`；`NationalSpire.Coop.CoopDiagnosticRequest.Epoch`；`NationalSpire.Coop.CoopDiagnosticRequest.Id`；`NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.Coop.CoopPart.Total`；`NationalSpire.Coop.CoopWire.Kind`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart)`；输入表达式：`assembler.Add(part.Part)`；返回值紧邻使用处：`IsPatternExpressionSyntax: assembler.Add(part.Part) is not { } bytes`
- `NationalSpire.Coop.CoopAssembler.Split(byte[])`；输入表达式：`CoopAssembler.Split(CoopJson.Bytes(safe))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var part in CoopAssembler.Split(CoopJson.Bytes(safe)))                 Send(sender, "diagnostics-part", new CoopDiagnosticPart(request.Id, request.Epoch, part));`
- `NationalSpire.Coop.CoopCoordinator.AllowedReportName(string)`；输入表达式：`AllowedReportName(key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AllowedReportName(key)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopDiagnosticPart>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<CoopDiagnosticPart>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopDiagnosticRequest>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<CoopDiagnosticRequest>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(sender, "diagnostics-part", new CoopDiagnosticPart(request.Id, request.Epoch, part))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(sender, "diagnostics-part", new CoopDiagnosticPart(request.Id, request.Epoch, part));`
- `NationalSpire.Coop.CoopDiagnosticPart.CoopDiagnosticPart(string, string, NationalSpire.Coop.CoopPart)`；输入表达式：`new CoopDiagnosticPart(request.Id, request.Epoch, part)`；返回值紧邻使用处：`ArgumentSyntax: new CoopDiagnosticPart(request.Id, request.Epoch, part)`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(safe)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(safe)`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<Dictionary<string, string>>(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Read<Dictionary<string, string>>(bytes)`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(error.ToString())`；返回值紧邻使用处：`BinaryExpressionSyntax: "读取日志失败：" + Diagnostics.Redact(error.ToString())`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(p.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Diagnostics.Redact(p.Value)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_diagnosticReports.ContainsKey(sender)`；返回值紧邻使用处：`BinaryExpressionSyntax: part.Id != _diagnosticId || part.Epoch != _diagnosticEpoch || _diagnosticReports.ContainsKey(sender)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["notes.txt"] = "此客户端无法提供运行日志。" }`；返回值紧邻使用处：`BinaryExpressionSyntax: CaptureDiagnostics?.Invoke() ?? new() { ["notes.txt"] = "此客户端无法提供运行日志。" }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["notes.txt"] = "读取日志失败：" + Diagnostics.Redact(error.ToString()) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: files = new() { ["notes.txt"] = "读取日志失败：" + Diagnostics.Redact(error.ToString()) }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_diagnosticAssemblers.TryGetValue(sender, out var assembler)`；返回值紧邻使用处：`BinaryExpressionSyntax: wire.Kind == "diagnostics-part" && Host && _diagnosticId.Length > 0 && _diagnosticAssemblers.TryGetValue(sender, out var assembler)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`files.Keys.Any(key => !AllowedReportName(key))`；返回值紧邻使用处：`BinaryExpressionSyntax: files.Count > 16 || files.Keys.Any(key => !AllowedReportName(key))`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _diagnosticReports[sender] = files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))`
- `System.Exception.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`ArgumentSyntax: error.ToString()`
- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CaptureDiagnostics?.Invoke()`
- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(request.Id, "N", out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Guid.TryParseExact(request.Id, "N", out _)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("队友报告超出大小限制。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("队友报告超出大小限制。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("队友报告解压后超出大小限制。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("队友报告解压后超出大小限制。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("队友报告条目无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("队友报告条目无效。");`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(10)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - _lastDiagnosticRequest < TimeSpan.FromSeconds(10)`

**赋值（含属性/字段和局部值）：**

- `_diagnosticReports[sender]` = `files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))`
- `_lastDiagnosticRequest` = `DateTime.UtcNow`
- `["notes.txt"]` = `"此客户端无法提供运行日志。"`
- `["notes.txt"]` = `"读取日志失败：" + Diagnostics.Redact(error.ToString())`
- `files` = `CaptureDiagnostics?.Invoke() ?? new() { ["notes.txt"] = "此客户端无法提供运行日志。" }`
- `files` = `new() { ["notes.txt"] = "读取日志失败：" + Diagnostics.Redact(error.ToString()) }`

<a id="symbol-9034c731e516"></a>

## `NationalSpire.Coop.CoopCoordinator.AllowedReportName(string) — private static bool AllowedReportName(string name)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](CoopDiagnostics.cs.md#symbol-fefabf8d6a26)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
