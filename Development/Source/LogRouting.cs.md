# LogRouting.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B8CC6D4B636EC8AB1172EAF96448D8128AB367E1690A903331225F124C709A54`。来源：[源码](../../LogRouting.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LogArea`、`NationalSpire.Diagnostics`、`NationalSpire.Diagnostics.LogContext`、`NationalSpire.Diagnostics.LogScope`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly string[] LogNames = ["national-spire.log", "private.jsonl", "group.jsonl", "community.jsonl",
        "weekly.jsonl", "random-events.jsonl", "matches.jsonl", "storage.jsonl"];
private static readonly AsyncLocal<LogContext?> CurrentLog = new();
```

<a id="symbol-13c5abc013bb"></a>

## `NationalSpire.Diagnostics.LogScope.Dispose() — public void Dispose()`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.CurrentLog`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `CurrentLog.Value` = `previous`

<a id="symbol-da8a28a9e81e"></a>

## `NationalSpire.Diagnostics.BeginLog(NationalSpire.LogArea, string) — internal static IDisposable BeginLog(LogArea area, string context)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)；[`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`](AiGroupChats.cs.md#symbol-1e6e737dbe88)；[`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)；[`NationalSpire.Diagnostics.RequestLog(string, string)`](LogRouting.cs.md#symbol-540e5c8b5f99)；[`NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`](ErrorDiagnostics.cs.md#symbol-3308746be2f3)

**调用：** `NationalSpire.Diagnostics.LogContext.LogContext(NationalSpire.LogArea, string)`；`NationalSpire.Diagnostics.LogScope.LogScope(NationalSpire.Diagnostics.LogContext?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.CurrentLog`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.LogContext.LogContext(NationalSpire.LogArea, string)`；输入表达式：`new(area, context)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CurrentLog.Value = new(area, context)`
- `NationalSpire.Diagnostics.LogScope.LogScope(NationalSpire.Diagnostics.LogContext?)`；输入表达式：`new LogScope(previous)`；返回值紧邻使用处：`ReturnStatementSyntax: return new LogScope(previous);`

**赋值（含属性/字段和局部值）：**

- `CurrentLog.Value` = `new(area, context)`

<a id="symbol-540e5c8b5f99"></a>

## `NationalSpire.Diagnostics.RequestLog(string, string) — internal static IDisposable RequestLog(string task, string context)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string, NationalSpire.ChatToolRequest?)`](AiPrivateMessages.cs.md#symbol-bab48bdb57c8)

**调用：** [`NationalSpire.Diagnostics.BeginLog(NationalSpire.LogArea, string)`](LogRouting.cs.md#symbol-da8a28a9e81e)

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.BeginLog(NationalSpire.LogArea, string)`；`NationalSpire.Diagnostics.CurrentLog`；`NationalSpire.Diagnostics.LogContext.Area`；`NationalSpire.Diagnostics.LogContext.Context`；`NationalSpire.LogArea.Event`；`NationalSpire.LogArea.Group`；`NationalSpire.LogArea.Private`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.BeginLog(NationalSpire.LogArea, string)`；输入表达式：`BeginLog(CurrentLog.Value?.Area ?? (task switch         { "group" => LogArea.Group, "event" => LogArea.Event, _ => LogArea.Private }),             context.Length > 0 ? context : CurrentLog.Value?.Context ?? "")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => BeginLog(CurrentLog.Value?.Area ?? (task switch         { "group" => LogArea.Group, "event" => LogArea.Event, _ => LogArea.Private }),             context.Length > 0 ? context : CurrentLog.Value?.Context ?? "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6d7aaac27858"></a>

## `NationalSpire.Diagnostics.AreaFor(string) — private static LogArea AreaFor(string category)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)

**调用：** `string.IndexOf(char)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.CurrentLog`；`NationalSpire.Diagnostics.LogContext.Area`；`NationalSpire.LogArea.Community`；`NationalSpire.LogArea.Event`；`NationalSpire.LogArea.Group`；`NationalSpire.LogArea.Match`；`NationalSpire.LogArea.Private`；`NationalSpire.LogArea.Runtime`；`NationalSpire.LogArea.Storage`；`NationalSpire.LogArea.Weekly`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IndexOf(char)`；输入表达式：`category.IndexOf('.')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = category.IndexOf('.')`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e00fc55f50c9"></a>

## `NationalSpire.Diagnostics.ReadAutomaticLogs() — private static IEnumerable<KeyValuePair<string, string>> ReadAutomaticLogs()`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.CapturePeerLogs(string, string, string?)`](Diagnostics.cs.md#symbol-8481032d98dd)；[`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.LogNames`；`NationalSpire.Diagnostics.ReadLogs(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`LogNames.SelectMany(ReadLogs)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => LogNames.SelectMany(ReadLogs)`

**赋值（含属性/字段和局部值）：**
