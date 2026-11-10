# LogPerformance.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`12425ED03E13770EA6601DDCF105642BF7C700C38F2534A19E23BC4463853FFD`。来源：[源码](../../LogPerformance.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Diagnostics`、`NationalSpire.Diagnostics.LogWork`、`NationalSpire.Diagnostics.LogCost`、`NationalSpire.Diagnostics.LogMeasure`。

字段、事件及初始值（源码原样）：

```csharp
public long Count, Ticks, Bytes, MaxTicks, MaxBytes;
public string SlowestCategory = "";
public string LargestAllocationCategory = "";
public DateTimeOffset SlowestUtc, LargestAllocationUtc;
private static readonly object CostGate = new();
private static readonly LogCost[] Costs = Enumerable.Range(0, 8).Select(_ => new LogCost()).ToArray();
private static readonly DateTimeOffset CostStarted = DateTimeOffset.UtcNow;
private static int _peakEvents, _peakEventChars;
private static string _performanceWriteError = "";
private readonly long _start = Stopwatch.GetTimestamp();
private readonly long _bytes = GC.GetAllocatedBytesForCurrentThread();
```

<a id="symbol-75d22d30761d"></a>

## `NationalSpire.Diagnostics.LogMeasure.Dispose() — public void Dispose()`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`](MatchDiagnostics.cs.md#symbol-2f83ebe4626e)

**调用：** `System.Diagnostics.Stopwatch.GetTimestamp()`；`System.GC.GetAllocatedBytesForCurrentThread()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.CostGate`；`NationalSpire.Diagnostics.Costs`；`NationalSpire.Diagnostics.LogCost.Bytes`；`NationalSpire.Diagnostics.LogCost.Count`；`NationalSpire.Diagnostics.LogCost.LargestAllocationCategory`；`NationalSpire.Diagnostics.LogCost.LargestAllocationUtc`；`NationalSpire.Diagnostics.LogCost.MaxBytes`；`NationalSpire.Diagnostics.LogCost.MaxTicks`；`NationalSpire.Diagnostics.LogCost.SlowestCategory`；`NationalSpire.Diagnostics.LogCost.SlowestUtc`；`NationalSpire.Diagnostics.LogCost.Ticks`；`NationalSpire.Diagnostics.LogMeasure._bytes`；`NationalSpire.Diagnostics.LogMeasure._start`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Diagnostics.Stopwatch.GetTimestamp()`；输入表达式：`Stopwatch.GetTimestamp()`；返回值紧邻使用处：`BinaryExpressionSyntax: Stopwatch.GetTimestamp() - _start`
- `System.GC.GetAllocatedBytesForCurrentThread()`；输入表达式：`GC.GetAllocatedBytesForCurrentThread()`；返回值紧邻使用处：`BinaryExpressionSyntax: GC.GetAllocatedBytesForCurrentThread() - _bytes`

**赋值（含属性/字段和局部值）：**

- `cost.Bytes` += `bytes`
- `cost.LargestAllocationCategory` = `category`
- `cost.LargestAllocationUtc` = `DateTimeOffset.UtcNow`
- `cost.MaxBytes` = `bytes`
- `cost.MaxTicks` = `ticks`
- `cost.SlowestCategory` = `category`
- `cost.SlowestUtc` = `DateTimeOffset.UtcNow`
- `cost.Ticks` += `ticks`

<a id="symbol-c6739ec14de2"></a>

## `NationalSpire.Diagnostics.LoggingPerformance() — public static object LoggingPerformance()`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.CapturePeerLogs(string, string, string?)`](Diagnostics.cs.md#symbol-8481032d98dd)；[`NationalSpire.Diagnostics.SaveLoggingPerformance()`](LogPerformance.cs.md#symbol-076f9dd0d161)

**调用：** `System.Collections.Generic.IEnumerable<long>.Sum()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.distinctCredentials`；`<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.errorKinds`；`<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.eventCharacters`；`<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.events`；`<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.expiredPendingRecords`；`<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.peakEventCharacters`；`<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.peakEvents`；`<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.pendingBytes`；`<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.pendingRecords`；`<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.performanceWriteError`；`<anonymous type: int events, int eventCharacters, int peakEvents, int peakEventCharacters, int errorKinds, int distinctCredentials, string writeError, string performanceWriteError, int pendingRecords, long pendingBytes, long expiredPendingRecords>.writeError`；`<anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>.allocatedBytes`；`<anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>.count`；`<anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>.largestAllocationCategory`；`<anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>.largestAllocationUtc`；`<anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>.maxAllocatedBytes`；`<anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>.maxMs`；`<anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>.slowestCategory`；`<anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>.slowestUtc`；`<anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>.stage`；`<anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>.totalMs`；`<anonymous type: System.DateTimeOffset startedUtc, System.DateTimeOffset capturedUtc, int processId, object retained, string note, <anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>[] stages>.capturedUtc`；`<anonymous type: System.DateTimeOffset startedUtc, System.DateTimeOffset capturedUtc, int processId, object retained, string note, <anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>[] stages>.note`；`<anonymous type: System.DateTimeOffset startedUtc, System.DateTimeOffset capturedUtc, int processId, object retained, string note, <anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>[] stages>.processId`；`<anonymous type: System.DateTimeOffset startedUtc, System.DateTimeOffset capturedUtc, int processId, object retained, string note, <anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>[] stages>.stages`；`<anonymous type: System.DateTimeOffset startedUtc, System.DateTimeOffset capturedUtc, int processId, object retained, string note, <anonymous type: string stage, long count, double totalMs, double maxMs, long allocatedBytes, long maxAllocatedBytes, string slowestCategory, System.DateTimeOffset slowestUtc, string largestAllocationCategory, System.DateTimeOffset largestAllocationUtc>[] stages>.startedUtc`；`NationalSpire.Diagnostics._eventChars`；`NationalSpire.Diagnostics._expiredPendingRecords`；`NationalSpire.Diagnostics._peakEventChars`；`NationalSpire.Diagnostics._peakEvents`；`NationalSpire.Diagnostics._performanceWriteError`；`NationalSpire.Diagnostics._writeError`；`NationalSpire.Diagnostics.CostGate`；`NationalSpire.Diagnostics.Costs`；`NationalSpire.Diagnostics.CostStarted`；`NationalSpire.Diagnostics.ErrorCounts`；`NationalSpire.Diagnostics.Events`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.LogCost.Bytes`；`NationalSpire.Diagnostics.LogCost.Count`；`NationalSpire.Diagnostics.LogCost.LargestAllocationCategory`；`NationalSpire.Diagnostics.LogCost.LargestAllocationUtc`；`NationalSpire.Diagnostics.LogCost.MaxBytes`；`NationalSpire.Diagnostics.LogCost.MaxTicks`；`NationalSpire.Diagnostics.LogCost.SlowestCategory`；`NationalSpire.Diagnostics.LogCost.SlowestUtc`；`NationalSpire.Diagnostics.LogCost.Ticks`；`NationalSpire.Diagnostics.PendingBytes`；`NationalSpire.Diagnostics.PendingLogs`；`NationalSpire.Diagnostics.Secrets`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<long>.Sum()`；输入表达式：`PendingBytes.Values.Sum()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: pendingBytes = PendingBytes.Values.Sum()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`Costs.Select((cost, index) => new { stage = ((LogWork)index).ToString(), count = cost.Count,                     totalMs = cost.Ticks * 1000d / Stopwatch.Frequency, maxMs = cost.MaxTicks * 1000d / Stopwatch.Frequency,                     allocatedBytes = cost.Bytes, maxAllocatedBytes = cost.MaxBytes,                     slowestCategory = cost.SlowestCategory, slowestUtc = cost.SlowestUtc,                     largestAllocationCategory = cost.LargestAllocationCategory, largestAllocationUtc = cost.LargestAllocationUtc })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Costs.Select((cost, index) => new { stage = ((LogWork)index).ToString(), count = cost.Count,                     totalMs = cost.Ticks * 1000d / Stopwatch.Frequency, maxMs = cost.MaxTicks * 1000d / Stopwatch.Frequency,                     allocatedBytes = cost.Bytes, maxAllocatedBytes = cost.MaxBytes,                     slowestCategory = cost.SlowestCategory, slowestUtc = cost.SlowestUtc,                     largestAllocationCategory = cost.LargestAllocationCategory, largestAllocationUtc = cost.LargestAllocationUtc }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`PendingLogs.Values.Sum(q => q.Count)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: pendingRecords = PendingLogs.Values.Sum(q => q.Count)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Costs.Select((cost, index) => new { stage = ((LogWork)index).ToString(), count = cost.Count,                     totalMs = cost.Ticks * 1000d / Stopwatch.Frequency, maxMs = cost.MaxTicks * 1000d / Stopwatch.Frequency,                     allocatedBytes = cost.Bytes, maxAllocatedBytes = cost.MaxBytes,                     slowestCategory = cost.SlowestCategory, slowestUtc = cost.SlowestUtc,                     largestAllocationCategory = cost.LargestAllocationCategory, largestAllocationUtc = cost.LargestAllocationUtc }).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: stages = Costs.Select((cost, index) => new { stage = ((LogWork)index).ToString(), count = cost.Count,                     totalMs = cost.Ticks * 1000d / Stopwatch.Frequency, maxMs = cost.MaxTicks * 1000d / Stopwatch.Frequency,                     allocatedBytes = cost.Bytes, maxAllocatedBytes = cost.MaxBytes,                     slowestCategory = cost.SlowestCategory, slowestUtc = cost.SlowestUtc,                     largestAllocationCategory = cost.LargestAllocationCategory, largestAllocationUtc = cost.LargestAllocationUtc }).ToArray()`
- `System.Enum.ToString()`；输入表达式：`((LogWork)index).ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: stage = ((LogWork)index).ToString()`

**赋值（含属性/字段和局部值）：**

- `retained` = `new { events = Events.Count, eventCharacters = _eventChars,             peakEvents = _peakEvents, peakEventCharacters = _peakEventChars, errorKinds = ErrorCounts.Count,             distinctCredentials = Secrets.Count, writeError = _writeError, performanceWriteError = _performanceWriteError,             pendingRecords = PendingLogs.Values.Sum(q => q.Count), pendingBytes = PendingBytes.Values.Sum(), expiredPendingRecords = _expiredPendingRecords }`

<a id="symbol-076f9dd0d161"></a>

## `NationalSpire.Diagnostics.SaveLoggingPerformance() — private static void SaveLoggingPerformance()`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.Diagnostics()`](Diagnostics.cs.md#symbol-16a6340430bd)；[`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)

**调用：** [`NationalSpire.Diagnostics.LoggingPerformance()`](LogPerformance.cs.md#symbol-c6739ec14de2)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`NationalSpire.UiPerformance.Snapshot()`](UiPerformance.cs.md#symbol-962540a1e803)；`System.Exception.GetType()`；`System.IO.Directory.Exists(string?)`；`System.IO.File.WriteAllText(string, string?)`；`System.IO.Path.Combine(string, string)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics._directory`；`NationalSpire.Diagnostics._performanceWriteError`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.Json`；`NationalSpire.Diagnostics.LoggingPerformance()`；`NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.UiPerformance.Snapshot()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.LoggingPerformance()`；输入表达式：`LoggingPerformance()`；返回值紧邻使用处：`ArgumentSyntax: LoggingPerformance()`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(JsonSerializer.Serialize(LoggingPerformance(), Json))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Redact(JsonSerializer.Serialize(LoggingPerformance(), Json))`
- `NationalSpire.UiPerformance.Snapshot()`；输入表达式：`UiPerformance.Snapshot()`；返回值紧邻使用处：`ArgumentSyntax: UiPerformance.Snapshot()`
- `System.Exception.GetType()`；输入表达式：`e.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.GetType().Name`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(directory)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Directory.Exists(directory)`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(Path.Combine(directory, "logging-performance.json"), json)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(Path.Combine(directory, "logging-performance.json"), json);`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(Path.Combine(directory, "ui-performance.json"), JsonSerializer.Serialize(UiPerformance.Snapshot(), Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(Path.Combine(directory, "ui-performance.json"), JsonSerializer.Serialize(UiPerformance.Snapshot(), Json));`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(directory, "logging-performance.json")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(directory, "logging-performance.json")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(directory, "ui-performance.json")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(directory, "ui-performance.json")`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(LoggingPerformance(), Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(LoggingPerformance(), Json)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(UiPerformance.Snapshot(), Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(UiPerformance.Snapshot(), Json)`

**赋值（含属性/字段和局部值）：**

- `_performanceWriteError` = `e.GetType().Name + ": " + e.Message`
- `directory` = `_directory`
