# LogStorage.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`35537F8EC35A79A565E48B9752F83CF8216890795C934DF138F7E4338A4CB3AA`。来源：[源码](../../LogStorage.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Diagnostics`、`NationalSpire.Diagnostics.PendingLog`、`NationalSpire.Diagnostics.LogWriter`。

字段、事件及初始值（源码原样）：

```csharp
private const int RetainedLogFiles = 5;
private static readonly Dictionary<string, Queue<PendingLog>> PendingLogs = [];
private static readonly Dictionary<string, long> PendingBytes = [];
private static Task? _retryLogs;
private static long _expiredPendingRecords;
internal readonly string Path = path;
internal readonly FileStream Stream = stream;
internal bool NeedsTrim = true;
private static readonly Dictionary<string, LogWriter> LogWriters = [];
```

<a id="symbol-c1c1366e47c0"></a>

## `NationalSpire.Diagnostics.CloseLogWriter(string) — private static void CloseLogWriter(string name)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.AppendLog(string, string)`](LogStorage.cs.md#symbol-fff9b7250296)；[`NationalSpire.Diagnostics.CloseLogWriters()`](LogStorage.cs.md#symbol-ed3035167e62)

**调用：** [`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey, out TValue)`；`System.Exception.ToString()`；`System.IO.Stream.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics._writeError`；`NationalSpire.Diagnostics.LogWriter.Stream`；`NationalSpire.Diagnostics.LogWriters`；`NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(error.ToString())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _writeError = Redact(error.ToString())`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey, out TValue)`；输入表达式：`LogWriters.Remove(name, out var writer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LogWriters.Remove(name, out var writer)`
- `System.Exception.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`ArgumentSyntax: error.ToString()`
- `System.IO.Stream.Dispose()`；输入表达式：`writer.Stream.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.Stream.Dispose();`

**赋值（含属性/字段和局部值）：**

- `_writeError` = `Redact(error.ToString())`

<a id="symbol-ed3035167e62"></a>

## `NationalSpire.Diagnostics.CloseLogWriters() — private static void CloseLogWriters()`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.Configure(string)`](Diagnostics.cs.md#symbol-4dd1cd0d7324)；[`NationalSpire.Diagnostics.Diagnostics()`](Diagnostics.cs.md#symbol-16a6340430bd)

**调用：** [`NationalSpire.Diagnostics.CloseLogWriter(string)`](LogStorage.cs.md#symbol-c1c1366e47c0)；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.CloseLogWriter(string)`；`NationalSpire.Diagnostics.LogWriters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.CloseLogWriter(string)`；输入表达式：`CloseLogWriter(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseLogWriter(name);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`LogWriters.Keys.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string name in LogWriters.Keys.ToArray()) CloseLogWriter(name);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f84080f52bcb"></a>

## `NationalSpire.Diagnostics.LogFiles(string, string) — private static FileInfo[] LogFiles(string directory, string name)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.AppendLog(string, string)`](LogStorage.cs.md#symbol-fff9b7250296)；[`NationalSpire.Diagnostics.ReadLogs(string)`](LogStorage.cs.md#symbol-a180c6c02b7d)

**调用：** `string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.IO.DirectoryInfo.DirectoryInfo(string)`；`System.IO.DirectoryInfo.EnumerateFiles(string)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string, System.StringComparison)`；输入表达式：`f.Name.StartsWith(name + ".previous", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))         .OrderByDescending(f => f.Name == name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))         .OrderByDescending(f => f.Name == name).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))         .OrderByDescending(f => f.Name == name).ThenByDescending(f => f.LastWriteTimeUtc).ThenByDescending(f => f.Name).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))         .OrderByDescending(f => f.Name == name).ThenByDescending(f => f.LastWriteTimeUtc).ThenByDescending(f => f.Name).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))         .OrderByDescending`
- `System.IO.DirectoryInfo.DirectoryInfo(string)`；输入表达式：`new DirectoryInfo(directory)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(directory).EnumerateFiles`
- `System.IO.DirectoryInfo.EnumerateFiles(string)`；输入表达式：`new DirectoryInfo(directory).EnumerateFiles(name + "*")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))         .OrderByDescending(f => f.Name == name).ThenByDescending(f => f.LastWriteTimeUtc).ThenByDescending(f => f.Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))         .OrderByDescending(f => f.Name == name).ThenByDescending(f => f.LastWriteTimeUtc).ThenByDescending(f => f.Name).ToArray`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))         .OrderByDescending(f => f.Name == name).ThenByDescending(f => f.LastWriteTimeUtc)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(directory).EnumerateFiles(name + "*")         .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))         .OrderByDescending(f => f.Name == name).ThenByDescending(f => f.LastWriteTimeUtc).ThenByDescending`

**赋值（含属性/字段和局部值）：**


<a id="symbol-365cff1c19cd"></a>

## `NationalSpire.Diagnostics.LegacyLogs(string, string) — private static IEnumerable<KeyValuePair<string, string>> LegacyLogs(string folder, string pattern)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.ReadEventRecords()`](EventDiagnostics.cs.md#symbol-40b02ea907c8)；[`NationalSpire.Diagnostics.ReadMatchTraces(string?)`](MatchDiagnostics.cs.md#symbol-98c47503da5b)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.OpenTraceSnapshot(string, out long)`](MatchDiagnostics.cs.md#symbol-8f11b54b7a73)；`NationalSpire.Diagnostics.TraceSnapshot.TraceSnapshot(System.IO.FileStream, long)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.KeyValuePair<TKey, TValue>.KeyValuePair(TKey, TValue)`；`System.IO.Directory.Exists(string?)`；`System.IO.Directory.GetFiles(string, string, System.IO.SearchOption)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetFileName(string?)`；`System.IO.StreamReader.ReadToEnd()`；`System.IO.StreamReader.StreamReader(System.IO.Stream, System.Text.Encoding, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics._directory`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.OpenTraceSnapshot(string, out long)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Error("log.legacy.read", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Error("log.legacy.read", error);`
- `NationalSpire.Diagnostics.OpenTraceSnapshot(string, out long)`；输入表达式：`OpenTraceSnapshot(file, out long length)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OpenTraceSnapshot(file, out long length)`
- `NationalSpire.Diagnostics.TraceSnapshot.TraceSnapshot(System.IO.FileStream, long)`；输入表达式：`new TraceSnapshot(input, length)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TraceSnapshot(input, length)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`files.OrderBy(File.GetLastWriteTimeUtc)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string file in files.OrderBy(File.GetLastWriteTimeUtc))         {             string? value = null;             try { using var input = OpenTraceSnapshot(file, out long length); using var snapshot = new TraceSnapshot(input, length);                 using var reader = new StreamReader(snapshot, Encoding.UTF8, true); value = reader.ReadToEnd(); }             catch (Exception error) { Error("log.legacy.read", error); }             if (value != null) yield return new(Path.GetFileName(file), value);         }`
- `System.Collections.Generic.KeyValuePair<TKey, TValue>.KeyValuePair(TKey, TValue)`；输入表达式：`new(Path.GetFileName(file), value)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(Path.GetFileName(file), value);`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Directory.Exists(path) ? Directory.GetFiles(path, pattern, SearchOption.AllDirectories) : []`
- `System.IO.Directory.GetFiles(string, string, System.IO.SearchOption)`；输入表达式：`Directory.GetFiles(path, pattern, SearchOption.AllDirectories)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Directory.Exists(path) ? Directory.GetFiles(path, pattern, SearchOption.AllDirectories) : []`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(root, folder)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(root, folder)`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(file)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetFileName(file)`
- `System.IO.StreamReader.ReadToEnd()`；输入表达式：`reader.ReadToEnd()`；返回值紧邻使用处：`AssignmentExpressionSyntax: value = reader.ReadToEnd()`
- `System.IO.StreamReader.StreamReader(System.IO.Stream, System.Text.Encoding, bool)`；输入表达式：`new StreamReader(snapshot, Encoding.UTF8, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamReader(snapshot, Encoding.UTF8, true)`

**赋值（含属性/字段和局部值）：**

- `files` = `Directory.Exists(path) ? Directory.GetFiles(path, pattern, SearchOption.AllDirectories) : []`
- `root` = `_directory`
- `value` = `reader.ReadToEnd()`

<a id="symbol-1531bef92f07"></a>

## `NationalSpire.Diagnostics.MigrateLogs() — private static void MigrateLogs()`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.Configure(string)`](Diagnostics.cs.md#symbol-4dd1cd0d7324)

**调用：** [`NationalSpire.Diagnostics.AppendLog(string, string)`](LogStorage.cs.md#symbol-fff9b7250296)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；`string.TrimEnd(params char[]?)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Exception.ToString()`；`System.IO.Directory.Exists(string?)`；`System.IO.Directory.GetFiles(string, string, System.IO.SearchOption)`；`System.IO.File.Delete(string)`；`System.IO.File.ReadAllText(string, System.Text.Encoding)`；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `(string Folder, string Pattern, string Name).Folder`；`(string Folder, string Pattern, string Name).Name`；`(string Folder, string Pattern, string Name).Pattern`；`NationalSpire.Diagnostics._directory`；`NationalSpire.Diagnostics._writeError`；`NationalSpire.Diagnostics.AppendLog(string, string)`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.AppendLog(string, string)`；输入表达式：`AppendLog(Path.Combine(_directory, source.Name), value)`；返回值紧邻使用处：`IfStatementSyntax: if (AppendLog(Path.Combine(_directory, source.Name), value)) File.Delete(file);`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(error.ToString())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _writeError = Redact(error.ToString())`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(File.ReadAllText(file, Encoding.UTF8))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Redact(File.ReadAllText(file, Encoding.UTF8)).TrimEnd`
- `string.TrimEnd(params char[]?)`；输入表达式：`Redact(File.ReadAllText(file, Encoding.UTF8)).TrimEnd('\r', '\n')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Redact(File.ReadAllText(file, Encoding.UTF8)).TrimEnd('\r', '\n')`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Directory.GetFiles(folder, source.Pattern, SearchOption.AllDirectories).OrderBy(File.GetLastWriteTimeUtc)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string file in Directory.GetFiles(folder, source.Pattern, SearchOption.AllDirectories).OrderBy(File.GetLastWriteTimeUtc))                     {                         // 旧文件整体成功写入后才移除，读取失败的文件仍可随报告导出。                         string value = Redact(File.ReadAllText(file, Encoding.UTF8)).TrimEnd('\r', '\n');                         if (AppendLog(Path.Combine(_directory, source.Name), value)) File.Delete(file);                     }`
- `System.Exception.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`ArgumentSyntax: error.ToString()`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(folder)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Directory.Exists(folder)`
- `System.IO.Directory.GetFiles(string, string, System.IO.SearchOption)`；输入表达式：`Directory.GetFiles(folder, source.Pattern, SearchOption.AllDirectories)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.GetFiles(folder, source.Pattern, SearchOption.AllDirectories).OrderBy`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(file)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(file);`
- `System.IO.File.ReadAllText(string, System.Text.Encoding)`；输入表达式：`File.ReadAllText(file, Encoding.UTF8)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(file, Encoding.UTF8)`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(_directory, source.Folder)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(_directory, source.Folder)`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(_directory, source.Name)`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(_directory, source.Name)`

**赋值（含属性/字段和局部值）：**

- `_writeError` = `Redact(error.ToString())`

<a id="symbol-fff9b7250296"></a>

## `NationalSpire.Diagnostics.AppendLog(string, string) — private static bool AppendLog(string path, string line)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.MigrateLogs()`](LogStorage.cs.md#symbol-1531bef92f07)；[`NationalSpire.Diagnostics.RetryLogs()`](LogStorage.cs.md#symbol-6e55ab193118)；[`NationalSpire.Diagnostics.WriteLog(string, string)`](LogStorage.cs.md#symbol-8e704b8bed92)

**调用：** [`Append(System.IO.FileStream, string)`](LogStorage.cs.md#symbol-0b793656967b)；[`NationalSpire.Diagnostics.CloseLogWriter(string)`](LogStorage.cs.md#symbol-c1c1366e47c0)；[`NationalSpire.Diagnostics.LogFiles(string, string)`](LogStorage.cs.md#symbol-f84080f52bcb)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`Open()`](LogStorage.cs.md#symbol-bf2ba4796195)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Exception.ToString()`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string)`；`System.IO.FileInfo.Delete()`；`System.IO.Path.GetDirectoryName(string?)`；`System.IO.Path.GetFileName(string?)`

**字段、属性、事件及方法组引用：** `Append(System.IO.FileStream, string)`；`NationalSpire.Diagnostics._writeError`；`NationalSpire.Diagnostics.CloseLogWriter(string)`；`NationalSpire.Diagnostics.LogFiles(string, string)`；`NationalSpire.Diagnostics.LogLimit`；`NationalSpire.Diagnostics.LogWriter.NeedsTrim`；`NationalSpire.Diagnostics.LogWriter.Path`；`NationalSpire.Diagnostics.LogWriter.Stream`；`NationalSpire.Diagnostics.LogWriters`；`NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.Diagnostics.RetainedLogFiles`；`Open()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Append(System.IO.FileStream, string)`；输入表达式：`Append(writer.Stream, line)`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(writer.Stream, line);`
- `NationalSpire.Diagnostics.CloseLogWriter(string)`；输入表达式：`CloseLogWriter(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseLogWriter(name);`
- `NationalSpire.Diagnostics.LogFiles(string, string)`；输入表达式：`LogFiles(Path.GetDirectoryName(path)!, name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LogFiles(Path.GetDirectoryName(path)!, name).Skip`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(error.ToString())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _writeError = Redact(error.ToString())`
- `Open()`；输入表达式：`Open()`；返回值紧邻使用处：`AssignmentExpressionSyntax: writer ??= Open()`
- `Open()`；输入表达式：`Open()`；返回值紧邻使用处：`AssignmentExpressionSyntax: writer = Open()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`LogWriters.TryGetValue(name, out var writer)`；返回值紧邻使用处：`BinaryExpressionSyntax: LogWriters.TryGetValue(name, out var writer) && writer.Path != path`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`LogFiles(Path.GetDirectoryName(path)!, name).Skip(RetainedLogFiles)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var file in LogFiles(Path.GetDirectoryName(path)!, name).Skip(RetainedLogFiles))                     try { file.Delete(); }                     catch (Exception error) { writer.NeedsTrim = true; _writeError = Redact(error.ToString()); }`
- `System.Exception.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`ArgumentSyntax: error.ToString()`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: "." + DateTime.UtcNow.Ticks + "-" + Guid.NewGuid().ToString("N")`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(archive)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(archive)) archive += "." + DateTime.UtcNow.Ticks + "-" + Guid.NewGuid().ToString("N");`
- `System.IO.File.Move(string, string)`；输入表达式：`File.Move(path, archive)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(path, archive);`
- `System.IO.FileInfo.Delete()`；输入表达式：`file.Delete()`；返回值紧邻使用处：`ExpressionStatementSyntax: file.Delete();`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(path)!`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetFileName(path)`

**赋值（含属性/字段和局部值）：**

- `_writeError` = `Redact(error.ToString())`
- `archive` += `"." + DateTime.UtcNow.Ticks + "-" + Guid.NewGuid().ToString("N")`
- `writer.NeedsTrim` = `false`
- `writer.NeedsTrim` = `true`
- `writer` ??= `Open()`
- `writer` = `null`
- `writer` = `Open()`

<a id="symbol-bf2ba4796195"></a>

## `Open() — LogWriter Open()`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.AppendLog(string, string)`](LogStorage.cs.md#symbol-fff9b7250296)

**调用：** `NationalSpire.Diagnostics.LogWriter.LogWriter(string, System.IO.FileStream)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；`System.IO.Path.GetDirectoryName(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.LogWriters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.LogWriter.LogWriter(string, System.IO.FileStream)`；输入表达式：`new LogWriter(path, new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read | FileShare.Delete))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LogWriter(path, new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read | FileShare.Delete))`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(Path.GetDirectoryName(path)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(Path.GetDirectoryName(path)!);`
- `System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；输入表达式：`new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read | FileShare.Delete)`；返回值紧邻使用处：`ArgumentSyntax: new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read | FileShare.Delete)`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(path)!`

**赋值（含属性/字段和局部值）：**

- `LogWriters[name]` = `opened`

<a id="symbol-0b793656967b"></a>

## `Append(System.IO.FileStream, string) — static void Append(FileStream output, string value)`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.AppendLog(string, string)`](LogStorage.cs.md#symbol-fff9b7250296)

**调用：** `System.IO.FileStream.Flush()`；`System.IO.FileStream.SetLength(long)`；`System.IO.FileStream.Write(System.ReadOnlySpan<byte>)`；`System.Text.Encoding.GetBytes(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.FileStream.Flush()`；输入表达式：`output.Flush()`；返回值紧邻使用处：`ExpressionStatementSyntax: output.Flush();`
- `System.IO.FileStream.SetLength(long)`；输入表达式：`output.SetLength(start)`；返回值紧邻使用处：`ExpressionStatementSyntax: output.SetLength(start);`
- `System.IO.FileStream.Write(System.ReadOnlySpan<byte>)`；输入表达式：`output.Write(bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: output.Write(bytes);`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Encoding.UTF8.GetBytes(value + "\n")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Encoding.UTF8.GetBytes(value + "\n")`

**赋值（含属性/字段和局部值）：**

- `output.Position` = `start`

<a id="symbol-8e704b8bed92"></a>

## `NationalSpire.Diagnostics.WriteLog(string, string) — private static void WriteLog(string name, string line)`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.RecordEvent(string, string, string, object)`](EventDiagnostics.cs.md#symbol-4f71ceb40a6e)；[`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`](MatchDiagnostics.cs.md#symbol-2f83ebe4626e)

**调用：** [`NationalSpire.Diagnostics.AppendLog(string, string)`](LogStorage.cs.md#symbol-fff9b7250296)；`NationalSpire.Diagnostics.PendingLog.PendingLog(string, string, int)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Collections.Generic.Queue<T>.Queue()`；`System.IO.Path.Combine(string, string)`；`System.Text.Encoding.GetByteCount(string)`；`System.Threading.Tasks.Task.Run(System.Func<System.Threading.Tasks.Task?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics._directory`；`NationalSpire.Diagnostics._expiredPendingRecords`；`NationalSpire.Diagnostics._retryLogs`；`NationalSpire.Diagnostics.AppendLog(string, string)`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.LogLimit`；`NationalSpire.Diagnostics.PendingBytes`；`NationalSpire.Diagnostics.PendingLog.Bytes`；`NationalSpire.Diagnostics.PendingLogs`；`NationalSpire.Diagnostics.RetainedLogFiles`；`NationalSpire.Diagnostics.RetryLogs()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.AppendLog(string, string)`；输入表达式：`AppendLog(path, line)`；返回值紧邻使用处：`BinaryExpressionSyntax: (!PendingLogs.TryGetValue(name, out var pending) || pending.Count == 0) && AppendLog(path, line)`
- `NationalSpire.Diagnostics.PendingLog.PendingLog(string, string, int)`；输入表达式：`new(path, line, bytes)`；返回值紧邻使用处：`ArgumentSyntax: new(path, line, bytes)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`PendingLogs.TryGetValue(name, out var pending)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PendingLogs.TryGetValue(name, out var pending)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PendingBytes.GetValueOrDefault(name)`；返回值紧邻使用处：`BinaryExpressionSyntax: PendingBytes.GetValueOrDefault(name) + bytes`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`pending.Dequeue()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pending.Dequeue().Bytes`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`pending.Enqueue(new(path, line, bytes))`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.Enqueue(new(path, line, bytes));`
- `System.Collections.Generic.Queue<T>.Queue()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: pending ??= new()`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(_directory, name)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(_directory, name)`
- `System.Text.Encoding.GetByteCount(string)`；输入表达式：`Encoding.UTF8.GetByteCount(line)`；返回值紧邻使用处：`BinaryExpressionSyntax: Encoding.UTF8.GetByteCount(line) + 1`
- `System.Threading.Tasks.Task.Run(System.Func<System.Threading.Tasks.Task?>)`；输入表达式：`Task.Run(RetryLogs)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _retryLogs = Task.Run(RetryLogs)`

**赋值（含属性/字段和局部值）：**

- `_retryLogs` = `Task.Run(RetryLogs)`
- `pending` ??= `new()`
- `PendingBytes[name]` = `retained`
- `PendingLogs[name]` = `pending`
- `retained` -= `pending.Dequeue().Bytes`

<a id="symbol-6e55ab193118"></a>

## `NationalSpire.Diagnostics.RetryLogs() — private static async Task RetryLogs()`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Diagnostics.AppendLog(string, string)`](LogStorage.cs.md#symbol-fff9b7250296)；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.TryPeek(out T)`；`System.Threading.Tasks.Task.ConfigureAwait(bool)`；`System.Threading.Tasks.Task.Delay(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics._retryLogs`；`NationalSpire.Diagnostics.AppendLog(string, string)`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.PendingBytes`；`NationalSpire.Diagnostics.PendingLog.Bytes`；`NationalSpire.Diagnostics.PendingLog.Line`；`NationalSpire.Diagnostics.PendingLog.Path`；`NationalSpire.Diagnostics.PendingLogs`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.AppendLog(string, string)`；输入表达式：`AppendLog(record.Path, record.Line)`；返回值紧邻使用处：`BinaryExpressionSyntax: pair.Value.TryPeek(out var record) && AppendLog(record.Path, record.Line)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`PendingLogs.Values.All(q => q.Count == 0)`；返回值紧邻使用处：`IfStatementSyntax: if (PendingLogs.Values.All(q => q.Count == 0)) { _retryLogs = null; return; }`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`pair.Value.Dequeue()`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.Value.Dequeue();`
- `System.Collections.Generic.Queue<T>.TryPeek(out T)`；输入表达式：`pair.Value.TryPeek(out var record)`；返回值紧邻使用处：`BinaryExpressionSyntax: pair.Value.TryPeek(out var record) && AppendLog(record.Path, record.Line)`
- `System.Threading.Tasks.Task.ConfigureAwait(bool)`；输入表达式：`Task.Delay(1000).ConfigureAwait(false)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Delay(1000).ConfigureAwait(false)`
- `System.Threading.Tasks.Task.Delay(int)`；输入表达式：`Task.Delay(1000)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Task.Delay(1000).ConfigureAwait`

**赋值（含属性/字段和局部值）：**

- `_retryLogs` = `null`
- `PendingBytes[pair.Key]` -= `record.Bytes`

<a id="symbol-a180c6c02b7d"></a>

## `NationalSpire.Diagnostics.ReadLogs(string) — private static IEnumerable<KeyValuePair<string, string>> ReadLogs(string name)`

来源：源码第 165 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.ErrorDetail(string)`](ErrorDiagnostics.cs.md#symbol-1825d5559456)；[`NationalSpire.Diagnostics.ReadEventRecords()`](EventDiagnostics.cs.md#symbol-40b02ea907c8)；[`NationalSpire.Diagnostics.ReadMatchTraces(string?)`](MatchDiagnostics.cs.md#symbol-98c47503da5b)

**调用：** [`NationalSpire.Diagnostics.LogFiles(string, string)`](LogStorage.cs.md#symbol-f84080f52bcb)；[`NationalSpire.Diagnostics.OpenTraceSnapshot(string, out long)`](MatchDiagnostics.cs.md#symbol-8f11b54b7a73)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；`NationalSpire.Diagnostics.TraceSnapshot.TraceSnapshot(System.IO.FileStream, long)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.KeyValuePair<TKey, TValue>.KeyValuePair(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Exception.ToString()`；`System.IO.Directory.Exists(string?)`；`System.IO.Path.GetDirectoryName(string?)`；`System.IO.Stream.Dispose()`；`System.IO.StreamReader.ReadToEnd()`；`System.IO.StreamReader.StreamReader(System.IO.Stream, System.Text.Encoding?, bool, int, bool)`

**字段、属性、事件及方法组引用：** `(string Name, NationalSpire.Diagnostics.TraceSnapshot Stream).Name`；`(string Name, NationalSpire.Diagnostics.TraceSnapshot Stream).Stream`；`NationalSpire.Diagnostics._directory`；`NationalSpire.Diagnostics._writeError`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.LogFiles(string, string)`；`NationalSpire.Diagnostics.OpenTraceSnapshot(string, out long)`；`NationalSpire.Diagnostics.PendingLog.Line`；`NationalSpire.Diagnostics.PendingLog.Path`；`NationalSpire.Diagnostics.PendingLogs`；`NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.LogFiles(string, string)`；输入表达式：`LogFiles(directory, name)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Directory.Exists(directory) ? LogFiles(directory, name) : []`
- `NationalSpire.Diagnostics.OpenTraceSnapshot(string, out long)`；输入表达式：`OpenTraceSnapshot(file.FullName, out long length)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OpenTraceSnapshot(file.FullName, out long length)`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(error.ToString())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _writeError = Redact(error.ToString())`
- `NationalSpire.Diagnostics.TraceSnapshot.TraceSnapshot(System.IO.FileStream, long)`；输入表达式：`new(input, length)`；返回值紧邻使用处：`ArgumentSyntax: new(input, length)`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join('\n', queue.Where(p => Path.GetDirectoryName(p.Path) == directory).Select(p => p.Line))`；返回值紧邻使用处：`ConditionalExpressionSyntax: PendingLogs.TryGetValue(name, out var queue)                 ? string.Join('\n', queue.Where(p => Path.GetDirectoryName(p.Path) == directory).Select(p => p.Line)) : ""`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`PendingLogs.TryGetValue(name, out var queue)`；返回值紧邻使用处：`ConditionalExpressionSyntax: PendingLogs.TryGetValue(name, out var queue)                 ? string.Join('\n', queue.Where(p => Path.GetDirectoryName(p.Path) == directory).Select(p => p.Line)) : ""`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`(Directory.Exists(directory) ? LogFiles(directory, name) : []).Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var file in (Directory.Exists(directory) ? LogFiles(directory, name) : []).Reverse())                     try { var input = OpenTraceSnapshot(file.FullName, out long length); snapshots.Add((file.Name, new(input, length))); }                     catch (Exception error) { _writeError = Redact(error.ToString()); }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`queue.Where(p => Path.GetDirectoryName(p.Path) == directory).Select(p => p.Line)`；返回值紧邻使用处：`ArgumentSyntax: queue.Where(p => Path.GetDirectoryName(p.Path) == directory).Select(p => p.Line)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`queue.Where(p => Path.GetDirectoryName(p.Path) == directory)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: queue.Where(p => Path.GetDirectoryName(p.Path) == directory).Select`
- `System.Collections.Generic.KeyValuePair<TKey, TValue>.KeyValuePair(TKey, TValue)`；输入表达式：`new(item.Name, text)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(item.Name, text);`
- `System.Collections.Generic.KeyValuePair<TKey, TValue>.KeyValuePair(TKey, TValue)`；输入表达式：`new(name + ".pending", pending)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(name + ".pending", pending);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`snapshots.Add((file.Name, new(input, length)))`；返回值紧邻使用处：`ExpressionStatementSyntax: snapshots.Add((file.Name, new(input, length)));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Name, TraceSnapshot Stream)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(string Name, TraceSnapshot Stream)>()`
- `System.Exception.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`ArgumentSyntax: error.ToString()`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(directory)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Directory.Exists(directory) ? LogFiles(directory, name) : []`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(p.Path)`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetDirectoryName(p.Path) == directory`
- `System.IO.Stream.Dispose()`；输入表达式：`item.Stream.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Stream.Dispose();`
- `System.IO.StreamReader.ReadToEnd()`；输入表达式：`reader.ReadToEnd()`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = reader.ReadToEnd()`
- `System.IO.StreamReader.StreamReader(System.IO.Stream, System.Text.Encoding?, bool, int, bool)`；输入表达式：`new StreamReader(item.Stream, Encoding.UTF8, true, leaveOpen: true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamReader(item.Stream, Encoding.UTF8, true, leaveOpen: true)`

**赋值（含属性/字段和局部值）：**

- `_writeError` = `Redact(error.ToString())`
- `directory` = `_directory`
- `pending` = `PendingLogs.TryGetValue(name, out var queue)                 ? string.Join('\n', queue.Where(p => Path.GetDirectoryName(p.Path) == directory).Select(p => p.Line)) : ""`
- `text` = `reader.ReadToEnd()`
