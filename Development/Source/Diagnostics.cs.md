# Diagnostics.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5B02EE816E86A9DFF72C2B885D2390B1E1675DF6D8374DAA54817AB63267BA97`。来源：[源码](../../Diagnostics.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Diagnostics`。

字段、事件及初始值（源码原样）：

```csharp
public const string ModVersion = "0.27.11";
private const int LogLimit = 2 * 1024 * 1024;
private static readonly object Gate = new();
private static readonly Queue<string> Events = new();
private static readonly HashSet<string> Secrets = [];
private static (string Raw, string Url, string Json)[] SecretForms = [];
private static readonly string UserHome = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
private static readonly string EscapedUserHome = UserHome.Replace("\\", "\\\\");
private static readonly Dictionary<string, int> ErrorCounts = [];
private static readonly JsonSerializerOptions Json = new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
private static string? _directory;
private static int _eventChars;
private static string _writeError = "";
```

<a id="symbol-a50687dc715c"></a>

## `NationalSpire.Diagnostics.RecordStartFailure(string, System.Exception, System.Collections.Generic.IReadOnlyDictionary<string, System.Func<object?>>, string) — public static string RecordStartFailure(string stage, Exception error,          IReadOnlyDictionary<string, Func<object?>> context, string category = "match.start")`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Exception.GetBaseException()`；`System.Exception.ToString()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `<anonymous type: string readError>.readError`；`<anonymous type: string stage, string modVersion, System.Collections.Generic.Dictionary<string, object?> context, string exception>.context`；`<anonymous type: string stage, string modVersion, System.Collections.Generic.Dictionary<string, object?> context, string exception>.exception`；`<anonymous type: string stage, string modVersion, System.Collections.Generic.Dictionary<string, object?> context, string exception>.modVersion`；`NationalSpire.Diagnostics.ModVersion`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Record(category, new { stage, modVersion = ModVersion, context = values, exception = error.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(category, new { stage, modVersion = ModVersion, context = values, exception = error.ToString() });`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(error.GetBaseException().Message)`；返回值紧邻使用处：`InterpolationSyntax: {Redact(error.GetBaseException().Message)}`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, object?>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, object?>()`
- `System.Exception.GetBaseException()`；输入表达式：`error.GetBaseException()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: error.GetBaseException().Message`
- `System.Exception.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: exception = error.ToString()`
- `System.Exception.ToString()`；输入表达式：`readError.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: readError = readError.ToString()`
- `System.Func<TResult>.Invoke()`；输入表达式：`item.Value()`；返回值紧邻使用处：`AssignmentExpressionSyntax: values[item.Key] = item.Value()`

**赋值（含属性/字段和局部值）：**

- `values[item.Key]` = `item.Value()`
- `values[item.Key]` = `new { readError = readError.ToString() }`

<a id="symbol-e91a93fc3428"></a>

## `NationalSpire.Diagnostics.RuntimeSnapshot — public static Func<object>? RuntimeSnapshot`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-16a6340430bd"></a>

## `NationalSpire.Diagnostics.Diagnostics() — static Diagnostics()`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Diagnostics.SaveLoggingPerformance()`](LogPerformance.cs.md#symbol-076f9dd0d161)

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.SaveLoggingPerformance()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.SaveLoggingPerformance()`；输入表达式：`SaveLoggingPerformance()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: (_, _) => SaveLoggingPerformance()`

**赋值（含属性/字段和局部值）：**

- `AppDomain.CurrentDomain.ProcessExit` += `(_, _) => SaveLoggingPerformance()`

<a id="symbol-4dd1cd0d7324"></a>

## `NationalSpire.Diagnostics.Configure(string) — public static void Configure(string directory)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)

**调用：** [`NationalSpire.Diagnostics.MigrateLogs()`](LogStorage.cs.md#symbol-1531bef92f07)

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics._directory`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.MigrateLogs()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.MigrateLogs()`；输入表达式：`MigrateLogs()`；返回值紧邻使用处：`ExpressionStatementSyntax: MigrateLogs();`

**赋值（含属性/字段和局部值）：**

- `_directory` = `directory`

<a id="symbol-4f621c46a4ca"></a>

## `NationalSpire.Diagnostics.RegisterSecret(string?) — public static void RegisterSecret(string? secret)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.FetchModelsAsync(string, string?, string)`](AiModels.cs.md#symbol-142ecf753d1d)；[`NationalSpire.AiService.PersistKey(string, string)`](AiService.cs.md#symbol-017daf4a239c)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string, NationalSpire.ChatToolRequest?)`](AiPrivateMessages.cs.md#symbol-bab48bdb57c8)；[`NationalSpire.AiService.SendAsync(System.Net.Http.HttpRequestMessage, NationalSpire.CareerData, string, string, System.Collections.Generic.IEnumerable<string>)`](AiService.cs.md#symbol-aad664840095)；[`NationalSpire.AiSettingsStore.ReadKey(string)`](AiSettingsStore.cs.md#symbol-ca446a961f94)；[`NationalSpire.CareerStore.ExportDiagnostics()`](CareerStore.cs.md#symbol-bdb986450a1c)；[`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)

**调用：** `string.IsNullOrEmpty(string?)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Uri.EscapeDataString(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.Json`；`NationalSpire.Diagnostics.SecretForms`；`NationalSpire.Diagnostics.Secrets`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(secret)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrEmpty(secret)) return;`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`Secrets.Add(secret)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Secrets.Add(secret)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Secrets.OrderByDescending(s => s.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Secrets.OrderByDescending(s => s.Length)                  .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Secrets.OrderByDescending(s => s.Length)                  .Select(s => (s, Uri.EscapeDataString(s), JsonSerializer.Serialize(s, Json)[1..^1]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Secrets.OrderByDescending(s => s.Length)                  .Select(s => (s, Uri.EscapeDataString(s), JsonSerializer.Serialize(s, Json)[1..^1])).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Secrets.OrderByDescending(s => s.Length)                  .Select(s => (s, Uri.EscapeDataString(s), JsonSerializer.Serialize(s, Json)[1..^1])).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: SecretForms = Secrets.OrderByDescending(s => s.Length)                  .Select(s => (s, Uri.EscapeDataString(s), JsonSerializer.Serialize(s, Json)[1..^1])).ToArray()`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(s, Json)`；返回值紧邻使用处：`ElementAccessExpressionSyntax: JsonSerializer.Serialize(s, Json)[1..^1]`
- `System.Uri.EscapeDataString(string)`；输入表达式：`Uri.EscapeDataString(s)`；返回值紧邻使用处：`ArgumentSyntax: Uri.EscapeDataString(s)`

**赋值（含属性/字段和局部值）：**

- `SecretForms` = `Secrets.OrderByDescending(s => s.Length)                  .Select(s => (s, Uri.EscapeDataString(s), JsonSerializer.Serialize(s, Json)[1..^1])).ToArray()`

<a id="symbol-f014e01c492a"></a>

## `NationalSpire.Diagnostics.Redact(string) — public static string Redact(string text)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`LogFile(string, string)`](Diagnostics.cs.md#symbol-939c3680e915)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.FetchModelsAsync(string, string?, string)`](AiModels.cs.md#symbol-142ecf753d1d)；[`NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`](AiService.cs.md#symbol-80abc5b58bda)；[`NationalSpire.AiService.ReadResponseCompletion(System.Net.Http.HttpResponseMessage)`](AiService.cs.md#symbol-4f223cb1164e)；[`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](Coop/CoopDiagnostics.cs.md#symbol-fefabf8d6a26)；[`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`](Coop/CoopNativeRun.cs.md#symbol-fa50e38bdb28)；[`NationalSpire.Coop.CoopNativeRun.Message(NationalSpire.Coop.CoopWire)`](Coop/CoopNativeRun.cs.md#symbol-3f383e39c601)；[`NationalSpire.Diagnostics.AppendLog(string, string)`](LogStorage.cs.md#symbol-fff9b7250296)；[`NationalSpire.Diagnostics.CapturePeerLogs(string, string, string?)`](Diagnostics.cs.md#symbol-8481032d98dd)；[`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)；[`NationalSpire.Diagnostics.MigrateLogs()`](LogStorage.cs.md#symbol-1531bef92f07)；[`NationalSpire.Diagnostics.ReadLogs(string)`](LogStorage.cs.md#symbol-a180c6c02b7d)；[`NationalSpire.Diagnostics.ReadMatchTraces(string?)`](MatchDiagnostics.cs.md#symbol-98c47503da5b)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.RecordEvent(string, string, string, object)`](EventDiagnostics.cs.md#symbol-4f71ceb40a6e)；[`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`](MatchDiagnostics.cs.md#symbol-2f83ebe4626e)；[`NationalSpire.Diagnostics.RecordStartFailure(string, System.Exception, System.Collections.Generic.IReadOnlyDictionary<string, System.Func<object?>>, string)`](Diagnostics.cs.md#symbol-a50687dc715c)；[`NationalSpire.Diagnostics.SaveLoggingPerformance()`](LogPerformance.cs.md#symbol-076f9dd0d161)；[`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)；[`NationalSpire.PlayerFacingText.AiError(string)`](PlayerFacingText.cs.md#symbol-be617f3bd292)；[`Section(string, System.Func<object>)`](Diagnostics.cs.md#symbol-5046f5179bb2)；[`Trim()`](LogStorage.cs.md#symbol-474d1ee1eea1)；[`Write(string, string)`](Diagnostics.cs.md#symbol-ce12a81c6025)

**调用：** `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；`string.Replace(string, string?, System.StringComparison)`；`System.Text.RegularExpressions.Regex.Replace(string, string, string)`

**字段、属性、事件及方法组引用：** `(string Raw, string Url, string Json).Json`；`(string Raw, string Url, string Json).Raw`；`(string Raw, string Url, string Json).Url`；`NationalSpire.Diagnostics.EscapedUserHome`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.LogWork.Redact`；`NationalSpire.Diagnostics.SecretForms`；`NationalSpire.Diagnostics.UserHome`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.Redact)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LogMeasure(LogWork.Redact)`
- `string.Replace(string, string?, System.StringComparison)`；输入表达式：`text.Replace(secret.Json, "[已隐藏凭据]", StringComparison.Ordinal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace(secret.Json, "[已隐藏凭据]", StringComparison.Ordinal)`
- `string.Replace(string, string?, System.StringComparison)`；输入表达式：`text.Replace(secret.Raw, "[已隐藏凭据]", StringComparison.Ordinal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace(secret.Raw, "[已隐藏凭据]", StringComparison.Ordinal)`
- `string.Replace(string, string?, System.StringComparison)`；输入表达式：`text.Replace(secret.Url, "[已隐藏凭据]", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace(secret.Url, "[已隐藏凭据]", StringComparison.OrdinalIgnoreCase)`
- `string.Replace(string, string?, System.StringComparison)`；输入表达式：`text.Replace(UserHome, "[用户目录]", StringComparison.OrdinalIgnoreCase)              .Replace(EscapedUserHome, "[用户目录]", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace(UserHome, "[用户目录]", StringComparison.OrdinalIgnoreCase)              .Replace(EscapedUserHome, "[用户目录]", StringComparison.OrdinalIgnoreCase)`
- `string.Replace(string, string?, System.StringComparison)`；输入表达式：`text.Replace(UserHome, "[用户目录]", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace(UserHome, "[用户目录]", StringComparison.OrdinalIgnoreCase)              .Replace`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`Regex.Replace(text, @"(?i)((?:api[_-]?key|authorization|access[_-]?token|password|secret)(?:\\?[""'])?\s*[:=]\s*(?:\\?[""'])?)[^\s,""'<>}\\]+", "$1[已隐藏凭据]")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = Regex.Replace(text, @"(?i)((?:api[_-]?key|authorization|access[_-]?token|password|secret)(?:\\?[""'])?\s*[:=]\s*(?:\\?[""'])?)[^\s,""'<>}\\]+", "$1[已隐藏凭据]")`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`Regex.Replace(text, @"(?i)(bearer\s+)[^\s""<>\\]+", "$1[已隐藏凭据]")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = Regex.Replace(text, @"(?i)(bearer\s+)[^\s""<>\\]+", "$1[已隐藏凭据]")`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`Regex.Replace(text, @"(?i)(https?://)[^/\s:@]+:[^/\s@]+@", "$1[已隐藏凭据]@")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = Regex.Replace(text, @"(?i)(https?://)[^/\s:@]+:[^/\s@]+@", "$1[已隐藏凭据]@")`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`Regex.Replace(text, @"([?&][\w.-]+=)[^\s&#""<>\\]+", "$1[已隐藏参数]")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = Regex.Replace(text, @"([?&][\w.-]+=)[^\s&#""<>\\]+", "$1[已隐藏参数]")`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`Regex.Replace(text, @"\bsk-[A-Za-z0-9_-]{8,}\b", "[已隐藏凭据]")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = Regex.Replace(text, @"\bsk-[A-Za-z0-9_-]{8,}\b", "[已隐藏凭据]")`

**赋值（含属性/字段和局部值）：**

- `forms` = `SecretForms`
- `text` = `Regex.Replace(text, @"(?i)((?:api[_-]?key|authorization|access[_-]?token|password|secret)(?:\\?[""'])?\s*[:=]\s*(?:\\?[""'])?)[^\s,""'<>}\\]+", "$1[已隐藏凭据]")`
- `text` = `Regex.Replace(text, @"(?i)(bearer\s+)[^\s""<>\\]+", "$1[已隐藏凭据]")`
- `text` = `Regex.Replace(text, @"(?i)(https?://)[^/\s:@]+:[^/\s@]+@", "$1[已隐藏凭据]@")`
- `text` = `Regex.Replace(text, @"([?&][\w.-]+=)[^\s&#""<>\\]+", "$1[已隐藏参数]")`
- `text` = `Regex.Replace(text, @"\bsk-[A-Za-z0-9_-]{8,}\b", "[已隐藏凭据]")`
- `text` = `text.Replace(secret.Json, "[已隐藏凭据]", StringComparison.Ordinal)`
- `text` = `text.Replace(secret.Raw, "[已隐藏凭据]", StringComparison.Ordinal)`
- `text` = `text.Replace(secret.Url, "[已隐藏凭据]", StringComparison.OrdinalIgnoreCase)`
- `text` = `text.Replace(UserHome, "[用户目录]", StringComparison.OrdinalIgnoreCase)              .Replace(EscapedUserHome, "[用户目录]", StringComparison.OrdinalIgnoreCase)`

<a id="symbol-1b5632793cd0"></a>

## `NationalSpire.Diagnostics.Record(string, object) — public static void Record(string category, object detail)`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`](AiPrivateMessages.cs.md#symbol-d73b189170eb)；[`NationalSpire.AiService.FetchModelsAsync(string, string?, string)`](AiModels.cs.md#symbol-142ecf753d1d)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.PersistKey(string, string)`](AiService.cs.md#symbol-017daf4a239c)；[`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)；[`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string, NationalSpire.ChatToolRequest?)`](AiPrivateMessages.cs.md#symbol-bab48bdb57c8)；[`NationalSpire.AiService.SendAsync(System.Net.Http.HttpRequestMessage, NationalSpire.CareerData, string, string, System.Collections.Generic.IEnumerable<string>)`](AiService.cs.md#symbol-aad664840095)；[`NationalSpire.AiService.SetWaiting(System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>, string)`](AiService.cs.md#symbol-8465c04298d9)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)；[`NationalSpire.AiSettingsStore.ReadKey(string)`](AiSettingsStore.cs.md#symbol-ca446a961f94)；[`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)；[`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`](Coop/CoopCoordinator.cs.md#symbol-ec0c662c6de0)；[`NationalSpire.Coop.CoopCoordinator.RecordJoinError(string)`](Coop/CoopCoordinator.cs.md#symbol-a8a225b353ea)；[`NationalSpire.Coop.CoopNativeRun.Message(NationalSpire.Coop.CoopWire)`](Coop/CoopNativeRun.cs.md#symbol-3f383e39c601)；[`NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`](Coop/CoopNativeRun.cs.md#symbol-5825a51bfef3)；[`NationalSpire.Coop.CoopNativeRun.Update()`](Coop/CoopNativeRun.cs.md#symbol-f8b6c697410f)；[`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](Coop/CoopRuntime.cs.md#symbol-60fe2cb26a8e)；[`NationalSpire.Coop.CoopSaveEntryPatch.Prefix()`](Coop/CoopRuntime.cs.md#symbol-17b0cee32be9)；[`NationalSpire.Coop.CoopSteamRunPlatform.LeaveOriginalLobby(System.Threading.CancellationToken)`](Coop/CoopNativeRun.cs.md#symbol-e4d08012a590)；[`NationalSpire.DateGameReturn.PrepareSavedResume(NationalSpire.CareerData, string, string)`](DateGameReturn.cs.md#symbol-5f5af2e8993e)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.RecordStartFailure(string, System.Exception, System.Collections.Generic.IReadOnlyDictionary<string, System.Func<object?>>, string)`](Diagnostics.cs.md#symbol-a50687dc715c)；[`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)；[`NationalSpire.GameBridge.RecoverPending()`](GameBridge.cs.md#symbol-7e7d899f5086)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](LiveMaps.cs.md#symbol-c878186b1e5a)；[`NationalSpire.LiveRunBridge._Ready()`](LiveRunBridge.cs.md#symbol-26fa8bae2af0)；[`NationalSpire.LiveRunBridge.Attach(MegaCrit.Sts2.Core.Nodes.NRun, MegaCrit.Sts2.Core.Runs.RunState)`](LiveRunBridge.cs.md#symbol-1af74b766122)；[`NationalSpire.LiveRunBridge.RefreshRace(ref bool)`](LiveRunBridge.cs.md#symbol-f03ac37c2ac4)；[`NationalSpire.MatchFailure.Record(NationalSpire.CareerData, string)`](FailureDecision.cs.md#symbol-00e4a5993844)；[`NationalSpire.MatchStartWatch.ObserveLoad(System.Threading.Tasks.Task, string)`](MatchStartWatch.cs.md#symbol-c5e7fd26211f)；[`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)；[`NationalSpire.MatchStartWatch.Stage(string)`](MatchStartWatch.cs.md#symbol-ad0a1e036443)；[`Notify()`](AiGroupChats.cs.md#symbol-57c976501a7f)；[`Notify(string)`](AiPrivateMessages.cs.md#symbol-1138954c6e9e)；[`Recorded(NationalSpire.RunPerformance)`](PlayerSimulation.cs.md#symbol-b90a45085274)

**调用：** [`NationalSpire.Diagnostics.LogMeasure.Dispose()`](LogPerformance.cs.md#symbol-75d22d30761d)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`NationalSpire.Diagnostics.WriteLog(string, string)`](LogStorage.cs.md#symbol-8e704b8bed92)；`NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Exception.GetType()`；`System.Math.Max(int, int)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `<anonymous type: System.DateTimeOffset utc, string category, string detail, bool clipped>.clipped`；`<anonymous type: System.DateTimeOffset utc, string category, string detail, bool clipped>.detail`；`<anonymous type: System.DateTimeOffset utc, string category, string detail, bool clipped>.utc`；`NationalSpire.Diagnostics._directory`；`NationalSpire.Diagnostics._eventChars`；`NationalSpire.Diagnostics._peakEventChars`；`NationalSpire.Diagnostics._peakEvents`；`NationalSpire.Diagnostics._writeError`；`NationalSpire.Diagnostics.Events`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.Json`；`NationalSpire.Diagnostics.LogLimit`；`NationalSpire.Diagnostics.LogMeasure.Dispose()`；`NationalSpire.Diagnostics.LogWork.Record`；`NationalSpire.Diagnostics.LogWork.Serialize`；`NationalSpire.Diagnostics.LogWork.WaitForWrite`；`NationalSpire.Diagnostics.LogWork.Write`；`NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.Diagnostics.WriteLog(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.LogMeasure.Dispose()`；输入表达式：`waiting.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: waiting.Dispose();`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.Record, category)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LogMeasure(LogWork.Record, category)`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.Serialize, category)`；返回值紧邻使用处：`UsingStatementSyntax: using (new LogMeasure(LogWork.Serialize, category)) body = detail is string s ? s : JsonSerializer.Serialize(detail, Json);`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.Serialize, category)`；返回值紧邻使用处：`UsingStatementSyntax: using (new LogMeasure(LogWork.Serialize, category)) line = JsonSerializer.Serialize(new { utc = DateTimeOffset.UtcNow, category, detail = body, clipped = false }, Json);`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.WaitForWrite, category)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LogMeasure(LogWork.WaitForWrite, category)`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.Write, category)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LogMeasure(LogWork.Write, category)`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(body)`；返回值紧邻使用处：`AssignmentExpressionSyntax: body = Redact(body)`
- `NationalSpire.Diagnostics.WriteLog(string, string)`；输入表达式：`WriteLog("national-spire.log", line)`；返回值紧邻使用处：`ExpressionStatementSyntax: WriteLog("national-spire.log", line);`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`Events.Dequeue()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Events.Dequeue().Length`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`Events.Enqueue(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: Events.Enqueue(line);`
- `System.Exception.GetType()`；输入表达式：`e.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.GetType().Name`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(_peakEventChars, _eventChars)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _peakEventChars = Math.Max(_peakEventChars, _eventChars)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(_peakEvents, Events.Count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _peakEvents = Math.Max(_peakEvents, Events.Count)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(detail, Json)`；返回值紧邻使用处：`ConditionalExpressionSyntax: detail is string s ? s : JsonSerializer.Serialize(detail, Json)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new { utc = DateTimeOffset.UtcNow, category, detail = body, clipped = false }, Json)`；返回值紧邻使用处：`AssignmentExpressionSyntax: line = JsonSerializer.Serialize(new { utc = DateTimeOffset.UtcNow, category, detail = body, clipped = false }, Json)`

**赋值（含属性/字段和局部值）：**

- `_eventChars` -= `Events.Dequeue().Length`
- `_eventChars` += `line.Length`
- `_peakEventChars` = `Math.Max(_peakEventChars, _eventChars)`
- `_peakEvents` = `Math.Max(_peakEvents, Events.Count)`
- `_writeError` = `e.GetType().Name + ": " + e.Message`
- `body` = `detail is string s ? s : JsonSerializer.Serialize(detail, Json)`
- `body` = `Redact(body)`
- `line` = `JsonSerializer.Serialize(new { utc = DateTimeOffset.UtcNow, category, detail = body, clipped = false }, Json)`

<a id="symbol-cb39203375a5"></a>

## `NationalSpire.Diagnostics.Error(string, System.Exception) — public static void Error(string category, Exception error)`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string, NationalSpire.ChatToolRequest?)`](AiPrivateMessages.cs.md#symbol-bab48bdb57c8)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)；[`NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`](AvatarAssets.cs.md#symbol-92f1e0aef1b2)；[`NationalSpire.CameoAssets.ForPerson(string)`](CameoAssets.cs.md#symbol-c95ad2877552)；[`NationalSpire.CameoAssets.Load(string, string)`](CameoAssets.cs.md#symbol-2f79106cbc73)；[`NationalSpire.CareerScreen.BuildChatToolToggle(Godot.HBoxContainer)`](ChatToolToggle.cs.md#symbol-cdbc2a8ad7ca)；[`NationalSpire.CareerScreen.ResumeDateGame()`](DateGameScreen.cs.md#symbol-fa0cab10e943)；[`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CharacterCards.Save(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`](CharacterCards.cs.md#symbol-4bce7f6af16c)；[`NationalSpire.CharacterIdentity.ReadDefinitions()`](CharacterIdentity.cs.md#symbol-201cf0836885)；[`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`](Coop/CoopAi.cs.md#symbol-b31e3ccef31a)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](Coop/CoopAi.cs.md#symbol-b4b98ce85f62)；[`NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`](Coop/CoopBroadcast.cs.md#symbol-845730f8a94c)；[`NationalSpire.Coop.CoopCompatibility.Check(bool)`](Coop/CoopCompatibility.cs.md#symbol-c71e5d5de570)；[`NationalSpire.Coop.CoopCoordinator.CollectDiagnosticReports(System.TimeSpan?)`](Coop/CoopDiagnostics.cs.md#symbol-44ff9d375651)；[`NationalSpire.Coop.CoopCoordinator.PumpDiagnostics()`](Coop/CoopDiagnostics.cs.md#symbol-3c9a89501f77)；[`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](Coop/CoopDiagnostics.cs.md#symbol-fefabf8d6a26)；[`NationalSpire.Coop.CoopCoordinator.ReceiveError(System.Exception)`](Coop/CoopReception.cs.md#symbol-fb570e3c7ba0)；[`NationalSpire.Coop.CoopCoordinator.ReceiveMarket(ulong, NationalSpire.Coop.CoopWire)`](Coop/CoopMarket.cs.md#symbol-1d6c27a5f526)；[`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](Coop/CoopCoordinator.cs.md#symbol-796041df5e9f)；[`NationalSpire.Coop.CoopCoordinator.SaveReceived(NationalSpire.Coop.CoopSnapshot, bool, ulong)`](Coop/CoopReception.cs.md#symbol-a9de6eef033e)；[`NationalSpire.Coop.CoopCoordinator.SendDiagnostic<T>(ulong, string, T)`](Coop/CoopDiagnostics.cs.md#symbol-88bc4c237586)；[`NationalSpire.Coop.CoopHistoryPatch.Prefix(MegaCrit.Sts2.Core.Runs.RunHistory)`](Coop/CoopRuntime.cs.md#symbol-1eda71dc88b5)；[`NationalSpire.Coop.CoopLive.ConfirmStop()`](Coop/CoopLive.cs.md#symbol-30b59f1772bc)；[`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`](Coop/CoopNativeRun.cs.md#symbol-fa50e38bdb28)；[`NationalSpire.Coop.CoopRuntime._Process(double)`](Coop/CoopRuntime.cs.md#symbol-ec1513bd09b1)；[`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](Coop/CoopRuntime.cs.md#symbol-60fe2cb26a8e)；[`NationalSpire.Coop.CoopSaveEntryPatch.Prefix()`](Coop/CoopRuntime.cs.md#symbol-17b0cee32be9)；[`NationalSpire.Coop.CoopSavePatch.Prefix(MegaCrit.Sts2.Core.Saves.SerializableRun, bool, ref System.Threading.Tasks.Task)`](Coop/CoopRuntime.cs.md#symbol-5743aede4fef)；[`NationalSpire.Coop.CoopSettings.SaveLayout(NationalSpire.BroadcastUiState)`](Coop/CoopRuntime.cs.md#symbol-3613d13461fc)；[`NationalSpire.Coop.CoopSteam.Update()`](Coop/CoopSteam.cs.md#symbol-fa8dda1e0359)；[`NationalSpire.DateGameReturn.AfterIntro(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen)`](DateGameReturn.cs.md#symbol-74da1cfff354)；[`NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`](DateGameReturn.cs.md#symbol-ccc3c072c00e)；[`NationalSpire.DateGameReturn.AfterSummary(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen)`](DateGameReturn.cs.md#symbol-3383d1deaa73)；[`NationalSpire.Diagnostics.LegacyLogs(string, string)`](LogStorage.cs.md#symbol-365cff1c19cd)；[`NationalSpire.Diagnostics.ReadEventRecords()`](EventDiagnostics.cs.md#symbol-40b02ea907c8)；[`NationalSpire.Diagnostics.ReadMatchTraces(string?)`](MatchDiagnostics.cs.md#symbol-98c47503da5b)；[`NationalSpire.Diagnostics.RecordEvent(string, string, string, object)`](EventDiagnostics.cs.md#symbol-4f71ceb40a6e)；[`NationalSpire.Diagnostics.RecordEventCheck(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption, string)`](EventDiagnostics.cs.md#symbol-cb8ce43827bb)；[`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`](MatchDiagnostics.cs.md#symbol-2f83ebe4626e)；[`NationalSpire.EconomicActions.Persist(NationalSpire.CareerData, System.Action)`](EconomicActions.cs.md#symbol-d99b9fe32a07)；[`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)；[`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer)`](GameBridge.cs.md#symbol-2ddde8df91f3)；[`NationalSpire.GameBridge.RecoverPending()`](GameBridge.cs.md#symbol-7e7d899f5086)；[`NationalSpire.GameCardKnowledge.Read()`](GameCardKnowledge.cs.md#symbol-58b00f45030f)；[`NationalSpire.GameCompatibility.Version()`](GameCompatibility.cs.md#symbol-f20a223e98d6)；[`NationalSpire.HistoryPatch.Postfix(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-6216c9815a00)；[`NationalSpire.LiveCompatibility.Install(HarmonyLib.Harmony, System.Reflection.Assembly)`](LiveCompatibility.cs.md#symbol-a0d94fdc9a3a)；[`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](LiveMaps.cs.md#symbol-c878186b1e5a)；[`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`](LiveRunBridge.cs.md#symbol-65a24868959d)；[`NationalSpire.LiveRunBridge.OpenDateGameChat(double)`](LiveDateGame.cs.md#symbol-6383bcf560b6)；[`NationalSpire.LiveRunBridge.RefreshRace(ref bool)`](LiveRunBridge.cs.md#symbol-f03ac37c2ac4)；[`NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`](LiveShopObserver.cs.md#symbol-76febe44c2f1)；[`NationalSpire.MarketTerminal.RequestInspection()`](MarketTerminal.cs.md#symbol-332ba74db6e5)；[`NationalSpire.MatchStartWatch.HasSavedRun()`](MatchStartWatch.cs.md#symbol-d420f386eebf)；[`NationalSpire.MatchStartWatch.ObserveLoad(System.Threading.Tasks.Task, string)`](MatchStartWatch.cs.md#symbol-c5e7fd26211f)；[`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)；[`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)；[`NationalSpire.RelicArt.Read(string)`](RelicArt.cs.md#symbol-1d35c476ee42)；[`Update(bool)`](AiRandomEvents.cs.md#symbol-50eeae8392fe)

**调用：** [`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Exception.GetType()`；`System.Exception.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: int occurrences, string exception>.exception`；`<anonymous type: int occurrences, string exception>.occurrences`；`NationalSpire.Diagnostics.ErrorCounts`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Record(category, new { occurrences = count, exception = error.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(category, new { occurrences = count, exception = error.ToString() });`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`ErrorCounts.ContainsKey(signature)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ErrorCounts.ContainsKey(signature)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`ErrorCounts.Remove(ErrorCounts.Keys.First())`；返回值紧邻使用处：`ExpressionStatementSyntax: ErrorCounts.Remove(ErrorCounts.Keys.First());`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`ErrorCounts.Keys.First()`；返回值紧邻使用处：`ArgumentSyntax: ErrorCounts.Keys.First()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`ErrorCounts.GetValueOrDefault(signature)`；返回值紧邻使用处：`BinaryExpressionSyntax: ErrorCounts.GetValueOrDefault(signature) + 1`
- `System.Exception.GetType()`；输入表达式：`error.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: error.GetType().Name`
- `System.Exception.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: exception = error.ToString()`

**赋值（含属性/字段和局部值）：**

- `count` = `ErrorCounts.GetValueOrDefault(signature) + 1`
- `ErrorCounts[signature]` = `count`

<a id="symbol-8481032d98dd"></a>

## `NationalSpire.Diagnostics.CapturePeerLogs(string, string, string?) — public static Dictionary<string, string> CapturePeerLogs(string gameLogDirectory, string status, string? worldId = null)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?)`](Coop/CoopRuntime.cs.md#symbol-5c58a004498a)

**调用：** [`NationalSpire.Diagnostics.LoggingPerformance()`](LogPerformance.cs.md#symbol-c6739ec14de2)；[`NationalSpire.Diagnostics.ReadEventRecords()`](EventDiagnostics.cs.md#symbol-40b02ea907c8)；[`NationalSpire.Diagnostics.ReadLogs(string)`](LogStorage.cs.md#symbol-a180c6c02b7d)；[`NationalSpire.Diagnostics.ReadMatchTraces(string?)`](MatchDiagnostics.cs.md#symbol-98c47503da5b)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`NationalSpire.UiPerformance.Snapshot()`](UiPerformance.cs.md#symbol-962540a1e803)；[`Tail(string, string)`](Diagnostics.cs.md#symbol-6b3c008ce557)；`NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`string.TrimEnd(char)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.IO.Directory.Exists(string?)`；`System.IO.DirectoryInfo.DirectoryInfo(string)`；`System.IO.DirectoryInfo.EnumerateFiles(string)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string modVersion, System.DateTimeOffset exportedUtc, string status, object logging>.exportedUtc`；`<anonymous type: string modVersion, System.DateTimeOffset exportedUtc, string status, object logging>.logging`；`<anonymous type: string modVersion, System.DateTimeOffset exportedUtc, string status, object logging>.modVersion`；`NationalSpire.Diagnostics._directory`；`NationalSpire.Diagnostics.ErrorCounts`；`NationalSpire.Diagnostics.Events`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.Json`；`NationalSpire.Diagnostics.LoggingPerformance()`；`NationalSpire.Diagnostics.LogWork.Capture`；`NationalSpire.Diagnostics.ModVersion`；`NationalSpire.Diagnostics.ReadEventRecords()`；`NationalSpire.Diagnostics.ReadLogs(string)`；`NationalSpire.Diagnostics.ReadMatchTraces(string?)`；`NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.Diagnostics.RuntimeSnapshot`；`NationalSpire.UiPerformance.Snapshot()`；`Tail(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.LoggingPerformance()`；输入表达式：`LoggingPerformance()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: logging = LoggingPerformance()`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.Capture)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LogMeasure(LogWork.Capture)`
- `NationalSpire.Diagnostics.ReadEventRecords()`；输入表达式：`ReadEventRecords()`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["random-events.jsonl"] = ReadEventRecords()`
- `NationalSpire.Diagnostics.ReadLogs(string)`；输入表达式：`ReadLogs("national-spire.log")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var log in ReadLogs("national-spire.log")) files["mod-logs/" + log.Key] = log.Value;`
- `NationalSpire.Diagnostics.ReadMatchTraces(string?)`；输入表达式：`ReadMatchTraces(worldId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ReadMatchTraces(worldId).Select`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(p.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Redact(p.Value)`
- `NationalSpire.UiPerformance.Snapshot()`；输入表达式：`UiPerformance.Snapshot()`；返回值紧邻使用处：`ArgumentSyntax: UiPerformance.Snapshot()`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join('\n', Events)`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["session-events.jsonl"] = string.Join('\n', Events)`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join('\n', notes)`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["notes.txt"] = string.Join('\n', notes)`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join('\n', ReadMatchTraces(worldId).Select(p => p.Value.TrimEnd('\n')))`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["latest-match.jsonl"] = string.Join('\n', ReadMatchTraces(worldId).Select(p => p.Value.TrimEnd('\n')))`
- `string.TrimEnd(char)`；输入表达式：`p.Value.TrimEnd('\n')`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Value.TrimEnd('\n')`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log").OrderByDescending(f => f.LastWriteTimeUtc)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log").OrderByDescending(f => f.LastWriteTimeUtc).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ReadMatchTraces(worldId).Select(p => p.Value.TrimEnd('\n'))`；返回值紧邻使用处：`ArgumentSyntax: ReadMatchTraces(worldId).Select(p => p.Value.TrimEnd('\n'))`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log").OrderByDescending(f => f.LastWriteTimeUtc).Take(5)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var log in new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log").OrderByDescending(f => f.LastWriteTimeUtc).Take(5))                  Tail(log.FullName, "game-log-" + (++index) + ".txt");`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`files.ToDictionary(p => p.Key, p => Redact(p.Value))`；返回值紧邻使用处：`ReturnStatementSyntax: return files.ToDictionary(p => p.Key, p => Redact(p.Value));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`notes.Add("未找到游戏日志。")`；返回值紧邻使用处：`ExpressionStatementSyntax: notes.Add("未找到游戏日志。");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`notes.Add(e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: notes.Add(e.Message);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Func<TResult>.Invoke()`；输入表达式：`RuntimeSnapshot()`；返回值紧邻使用处：`ArgumentSyntax: RuntimeSnapshot()`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(gameLogDirectory)`；返回值紧邻使用处：`IfStatementSyntax: if (Directory.Exists(gameLogDirectory)) foreach (var log in new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log").OrderByDescending(f => f.LastWriteTimeUtc).Take(5))                  Tail(log.FullName, "game-log-" + (++index) + ".txt");`
- `System.IO.DirectoryInfo.DirectoryInfo(string)`；输入表达式：`new DirectoryInfo(gameLogDirectory)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(gameLogDirectory).EnumerateFiles`
- `System.IO.DirectoryInfo.EnumerateFiles(string)`；输入表达式：`new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log").OrderByDescending`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(ErrorCounts, Json)`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["error-counts.json"] = JsonSerializer.Serialize(ErrorCounts, Json)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new { modVersion = ModVersion, exportedUtc = DateTimeOffset.UtcNow, status, logging = LoggingPerformance() }, Json)`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["summary.json"] = JsonSerializer.Serialize(new { modVersion = ModVersion, exportedUtc = DateTimeOffset.UtcNow, status, logging = LoggingPerformance() }, Json)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(RuntimeSnapshot(), Json)`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["runtime.json"] = JsonSerializer.Serialize(RuntimeSnapshot(), Json)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(UiPerformance.Snapshot(), Json)`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["ui-performance.json"] = JsonSerializer.Serialize(UiPerformance.Snapshot(), Json)`
- `Tail(string, string)`；输入表达式：`Tail(log.FullName, "game-log-" + (++index) + ".txt")`；返回值紧邻使用处：`ExpressionStatementSyntax: Tail(log.FullName, "game-log-" + (++index) + ".txt");`

**赋值（含属性/字段和局部值）：**

- `directory` = `_directory`
- `files["error-counts.json"]` = `JsonSerializer.Serialize(ErrorCounts, Json)`
- `files["latest-match.jsonl"]` = `string.Join('\n', ReadMatchTraces(worldId).Select(p => p.Value.TrimEnd('\n')))`
- `files["mod-logs/" + log.Key]` = `log.Value`
- `files["notes.txt"]` = `string.Join('\n', notes)`
- `files["random-events.jsonl"]` = `ReadEventRecords()`
- `files["runtime.json"]` = `JsonSerializer.Serialize(RuntimeSnapshot(), Json)`
- `files["session-events.jsonl"]` = `string.Join('\n', Events)`
- `files["summary.json"]` = `JsonSerializer.Serialize(new { modVersion = ModVersion, exportedUtc = DateTimeOffset.UtcNow, status, logging = LoggingPerformance() }, Json)`
- `files["ui-performance.json"]` = `JsonSerializer.Serialize(UiPerformance.Snapshot(), Json)`

<a id="symbol-6b3c008ce557"></a>

## `Tail(string, string) — void Tail(string path, string entry)`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.CapturePeerLogs(string, string, string?)`](Diagnostics.cs.md#symbol-8481032d98dd)

**调用：** `NationalSpire.Diagnostics.TraceSnapshot.TraceSnapshot(System.IO.FileStream, long)`；`System.Collections.Generic.List<T>.Add(T)`；`System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；`System.IO.Path.GetFileName(string?)`；`System.IO.StreamReader.ReadToEnd()`；`System.IO.StreamReader.StreamReader(System.IO.Stream, System.Text.Encoding, bool)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.TraceSnapshot.TraceSnapshot(System.IO.FileStream, long)`；输入表达式：`new TraceSnapshot(input, input.Length)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TraceSnapshot(input, input.Length)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`notes.Add(entry + " ← " + Path.GetFileName(path))`；返回值紧邻使用处：`ExpressionStatementSyntax: notes.Add(entry + " ← " + Path.GetFileName(path));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`notes.Add(entry + "：" + e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: notes.Add(entry + "：" + e.Message);`
- `System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；输入表达式：`new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete)`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: entry + " ← " + Path.GetFileName(path)`
- `System.IO.StreamReader.ReadToEnd()`；输入表达式：`reader.ReadToEnd()`；返回值紧邻使用处：`AssignmentExpressionSyntax: files[entry] = reader.ReadToEnd()`
- `System.IO.StreamReader.StreamReader(System.IO.Stream, System.Text.Encoding, bool)`；输入表达式：`new StreamReader(snapshot, Encoding.UTF8, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamReader(snapshot, Encoding.UTF8, true)`

**赋值（含属性/字段和局部值）：**

- `files[entry]` = `reader.ReadToEnd()`

<a id="symbol-a22f068c4d41"></a>

## `NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?) — public static string Export(CareerData data, string careerPath, string gameLogDirectory, string aiStatus, object? cooperative = null, IReadOnlyDictionary<string, string>? peerReports = null)`

来源：源码第 161 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.ExportDiagnostics()`](CareerStore.cs.md#symbol-bdb986450a1c)；[`NationalSpire.Coop.CoopCareerSession.Export()`](Coop/CoopCareerSession.cs.md#symbol-24a80da4bec4)

**调用：** [`LogFile(string, string)`](Diagnostics.cs.md#symbol-939c3680e915)；[`NationalSpire.Diagnostics.LogMeasure.Dispose()`](LogPerformance.cs.md#symbol-75d22d30761d)；[`NationalSpire.Diagnostics.ReadEventRecords()`](EventDiagnostics.cs.md#symbol-40b02ea907c8)；[`NationalSpire.Diagnostics.ReadLogs(string)`](LogStorage.cs.md#symbol-a180c6c02b7d)；[`NationalSpire.Diagnostics.ReadMatchTraces(string?)`](MatchDiagnostics.cs.md#symbol-98c47503da5b)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`NationalSpire.Diagnostics.SaveLoggingPerformance()`](LogPerformance.cs.md#symbol-076f9dd0d161)；[`Section(string, System.Func<object>)`](Diagnostics.cs.md#symbol-5046f5179bb2)；[`Write(string, string)`](Diagnostics.cs.md#symbol-ce12a81c6025)；`NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；`string.Join(char, params string?[])`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.AppDomain.GetAssemblies()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.Queue<T>.ToArray()`；`System.DateTime.ToString(string?)`；`System.Exception.ToString()`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode)`；`System.IO.Directory.Exists(string?)`；`System.IO.DirectoryInfo.DirectoryInfo(string)`；`System.IO.DirectoryInfo.EnumerateFiles(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；`System.IO.Path.Combine(string, string)`；`System.Reflection.Assembly.GetName()`；`System.Version.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: string modVersion, System.DateTimeOffset exportedUtc, string os, string runtime, int Day, int Season, int Version, string PendingMatchId, string SelectedCharacter, int SelectedAscension, string aiStatus, int matches, int results, int posts>.exportedUtc`；`<anonymous type: string modVersion, System.DateTimeOffset exportedUtc, string os, string runtime, int Day, int Season, int Version, string PendingMatchId, string SelectedCharacter, int SelectedAscension, string aiStatus, int matches, int results, int posts>.matches`；`<anonymous type: string modVersion, System.DateTimeOffset exportedUtc, string os, string runtime, int Day, int Season, int Version, string PendingMatchId, string SelectedCharacter, int SelectedAscension, string aiStatus, int matches, int results, int posts>.modVersion`；`<anonymous type: string modVersion, System.DateTimeOffset exportedUtc, string os, string runtime, int Day, int Season, int Version, string PendingMatchId, string SelectedCharacter, int SelectedAscension, string aiStatus, int matches, int results, int posts>.os`；`<anonymous type: string modVersion, System.DateTimeOffset exportedUtc, string os, string runtime, int Day, int Season, int Version, string PendingMatchId, string SelectedCharacter, int SelectedAscension, string aiStatus, int matches, int results, int posts>.posts`；`<anonymous type: string modVersion, System.DateTimeOffset exportedUtc, string os, string runtime, int Day, int Season, int Version, string PendingMatchId, string SelectedCharacter, int SelectedAscension, string aiStatus, int matches, int results, int posts>.results`；`<anonymous type: string modVersion, System.DateTimeOffset exportedUtc, string os, string runtime, int Day, int Season, int Version, string PendingMatchId, string SelectedCharacter, int SelectedAscension, string aiStatus, int matches, int results, int posts>.runtime`；`<anonymous type: string name, string version>.name`；`<anonymous type: string name, string version>.version`；`LogFile(string, string)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.SelectedAscension`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerData.Version`；`NationalSpire.CareerData.WorldId`；`NationalSpire.Diagnostics._directory`；`NationalSpire.Diagnostics._writeError`；`NationalSpire.Diagnostics.ErrorCounts`；`NationalSpire.Diagnostics.Events`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.LoggingPerformance()`；`NationalSpire.Diagnostics.LogMeasure.Dispose()`；`NationalSpire.Diagnostics.LogWork.Export`；`NationalSpire.Diagnostics.ModVersion`；`NationalSpire.Diagnostics.ReadEventRecords()`；`NationalSpire.Diagnostics.ReadLogs(string)`；`NationalSpire.Diagnostics.ReadMatchTraces(string?)`；`NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.Diagnostics.RuntimeSnapshot`；`NationalSpire.Diagnostics.SaveLoggingPerformance()`；`NationalSpire.UiPerformance.Snapshot()`；`Section(string, System.Func<object>)`；`Write(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `LogFile(string, string)`；输入表达式：`LogFile(log.FullName, "game-logs/" + log.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: LogFile(log.FullName, "game-logs/" + log.Name);`
- `LogFile(string, string)`；输入表达式：`LogFile(Path.Combine(performanceDirectory, "logging-performance.json"), "logging-last-snapshot.json")`；返回值紧邻使用处：`ExpressionStatementSyntax: LogFile(Path.Combine(performanceDirectory, "logging-performance.json"), "logging-last-snapshot.json");`
- `LogFile(string, string)`；输入表达式：`LogFile(Path.Combine(performanceDirectory, "ui-performance.json"), "ui-last-snapshot.json")`；返回值紧邻使用处：`ExpressionStatementSyntax: LogFile(Path.Combine(performanceDirectory, "ui-performance.json"), "ui-last-snapshot.json");`
- `NationalSpire.Diagnostics.LogMeasure.Dispose()`；输入表达式：`measure.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: measure.Dispose();`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.Export)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LogMeasure(LogWork.Export)`
- `NationalSpire.Diagnostics.ReadEventRecords()`；输入表达式：`ReadEventRecords()`；返回值紧邻使用处：`ArgumentSyntax: ReadEventRecords()`
- `NationalSpire.Diagnostics.ReadLogs(string)`；输入表达式：`ReadLogs("national-spire.log")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var log in ReadLogs("national-spire.log")) Write("mod-logs/" + log.Key, log.Value);`
- `NationalSpire.Diagnostics.ReadMatchTraces(string?)`；输入表达式：`ReadMatchTraces(data.WorldId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var trace in ReadMatchTraces(data.WorldId)) Write("matches/" + trace.Key, trace.Value);`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(_writeError)`；返回值紧邻使用处：`BinaryExpressionSyntax: "运行日志写入失败：" + Redact(_writeError)`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(e.ToString())`；返回值紧邻使用处：`BinaryExpressionSyntax: "游戏日志读取失败：" + Redact(e.ToString())`
- `NationalSpire.Diagnostics.SaveLoggingPerformance()`；输入表达式：`SaveLoggingPerformance()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveLoggingPerformance();`
- `Section(string, System.Func<object>)`；输入表达式：`Section("assemblies.json", () => AppDomain.CurrentDomain.GetAssemblies().Select(a => new { name = a.GetName().Name, version = a.GetName().Version?.ToString() }).OrderBy(a => a.name).ToArray())`；返回值紧邻使用处：`ExpressionStatementSyntax: Section("assemblies.json", () => AppDomain.CurrentDomain.GetAssemblies().Select(a => new { name = a.GetName().Name, version = a.GetName().Version?.ToString() }).OrderBy(a => a.name).ToArray());`
- `Section(string, System.Func<object>)`；输入表达式：`Section("career.json", () => data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Section("career.json", () => data);`
- `Section(string, System.Func<object>)`；输入表达式：`Section("cooperative.json", () => cooperative)`；返回值紧邻使用处：`ExpressionStatementSyntax: Section("cooperative.json", () => cooperative);`
- `Section(string, System.Func<object>)`；输入表达式：`Section("error-counts.json", () => ErrorCounts.ToDictionary(p => p.Key, p => p.Value))`；返回值紧邻使用处：`ExpressionStatementSyntax: Section("error-counts.json", () => ErrorCounts.ToDictionary(p => p.Key, p => p.Value));`
- `Section(string, System.Func<object>)`；输入表达式：`Section("logging-performance.json", LoggingPerformance)`；返回值紧邻使用处：`ExpressionStatementSyntax: Section("logging-performance.json", LoggingPerformance);`
- `Section(string, System.Func<object>)`；输入表达式：`Section("runtime.json", RuntimeSnapshot)`；返回值紧邻使用处：`ExpressionStatementSyntax: Section("runtime.json", RuntimeSnapshot);`
- `Section(string, System.Func<object>)`；输入表达式：`Section("summary.json", () => new { modVersion = ModVersion, exportedUtc = DateTimeOffset.UtcNow,                  os = System.Runtime.InteropServices.RuntimeInformation.OSDescription, runtime = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,                  data.Day, data.Season, data.Version, data.PendingMatchId, data.SelectedCharacter, data.SelectedAscension, aiStatus,                  matches = data.Matches.Count, results = data.Results.Count, posts = data.Posts.Count })`；返回值紧邻使用处：`ExpressionStatementSyntax: Section("summary.json", () => new { modVersion = ModVersion, exportedUtc = DateTimeOffset.UtcNow,                  os = System.Runtime.InteropServices.RuntimeInformation.OSDescription, runtime = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,                  data.Day, data.Season, data.Version, data.PendingMatchId, data.SelectedCharacter, data.SelectedAscension, aiStatus,                  matches = data.Matches.Count, results = data.Results.Count, posts = data.Posts.Count });`
- `Section(string, System.Func<object>)`；输入表达式：`Section("ui-performance.json", UiPerformance.Snapshot)`；返回值紧邻使用处：`ExpressionStatementSyntax: Section("ui-performance.json", UiPerformance.Snapshot);`
- `string.Join(char, params string?[])`；输入表达式：`string.Join('\n', events)`；返回值紧邻使用处：`ArgumentSyntax: string.Join('\n', events)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", notes)`；返回值紧邻使用处：`ConditionalExpressionSyntax: notes.Count == 0 ? "所有项目读取完成。" : string.Join("\n", notes)`
- `System.AppDomain.GetAssemblies()`；输入表达式：`AppDomain.CurrentDomain.GetAssemblies()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AppDomain.CurrentDomain.GetAssemblies().Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`AppDomain.CurrentDomain.GetAssemblies().Select(a => new { name = a.GetName().Name, version = a.GetName().Version?.ToString() }).OrderBy(a => a.name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AppDomain.CurrentDomain.GetAssemblies().Select(a => new { name = a.GetName().Name, version = a.GetName().Version?.ToString() }).OrderBy(a => a.name).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")                      .OrderByDescending(f => f.LastWriteTimeUtc)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")                      .OrderByDescending(f => f.LastWriteTimeUtc).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`AppDomain.CurrentDomain.GetAssemblies().Select(a => new { name = a.GetName().Name, version = a.GetName().Version?.ToString() })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AppDomain.CurrentDomain.GetAssemblies().Select(a => new { name = a.GetName().Name, version = a.GetName().Version?.ToString() }).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")                      .OrderByDescending(f => f.LastWriteTimeUtc).Take(5)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")                      .OrderByDescending(f => f.LastWriteTimeUtc).Take(5).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`AppDomain.CurrentDomain.GetAssemblies().Select(a => new { name = a.GetName().Name, version = a.GetName().Version?.ToString() }).OrderBy(a => a.name).ToArray()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => AppDomain.CurrentDomain.GetAssemblies().Select(a => new { name = a.GetName().Name, version = a.GetName().Version?.ToString() }).OrderBy(a => a.name).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")                      .OrderByDescending(f => f.LastWriteTimeUtc).Take(5).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: Directory.Exists(gameLogDirectory) ? new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")                      .OrderByDescending(f => f.LastWriteTimeUtc).Take(5).ToArray() : []`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`ErrorCounts.ToDictionary(p => p.Key, p => p.Value)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ErrorCounts.ToDictionary(p => p.Key, p => p.Value)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`notes.Add("未找到游戏日志；其余报告内容已保留。")`；返回值紧邻使用处：`ExpressionStatementSyntax: notes.Add("未找到游戏日志；其余报告内容已保留。");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`notes.Add("游戏日志读取失败：" + Redact(e.ToString()))`；返回值紧邻使用处：`ExpressionStatementSyntax: notes.Add("游戏日志读取失败：" + Redact(e.ToString()));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`notes.Add("运行日志写入失败：" + Redact(_writeError))`；返回值紧邻使用处：`ExpressionStatementSyntax: notes.Add("运行日志写入失败：" + Redact(_writeError));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`notes.Add("runtime.json：当前环境未提供游戏运行状态。")`；返回值紧邻使用处：`ExpressionStatementSyntax: notes.Add("runtime.json：当前环境未提供游戏运行状态。");`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Collections.Generic.Queue<T>.ToArray()`；输入表达式：`Events.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: events = Events.ToArray()`
- `System.DateTime.ToString(string?)`；输入表达式：`DateTime.UtcNow.ToString("yyyyMMdd-HHmmss-fff")`；返回值紧邻使用处：`BinaryExpressionSyntax: careerPath + ".diagnostics-" + DateTime.UtcNow.ToString("yyyyMMdd-HHmmss-fff")`
- `System.Exception.ToString()`；输入表达式：`e.ToString()`；返回值紧邻使用处：`ArgumentSyntax: e.ToString()`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ElementAccessExpressionSyntax: Guid.NewGuid().ToString("N")[..6]`
- `System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode)`；输入表达式：`new ZipArchive(file, ZipArchiveMode.Create)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ZipArchive(file, ZipArchiveMode.Create)`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(gameLogDirectory)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Directory.Exists(gameLogDirectory) ? new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")                      .OrderByDescending(f => f.LastWriteTimeUtc).Take(5).ToArray() : []`
- `System.IO.DirectoryInfo.DirectoryInfo(string)`；输入表达式：`new DirectoryInfo(gameLogDirectory)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(gameLogDirectory).EnumerateFiles`
- `System.IO.DirectoryInfo.EnumerateFiles(string)`；输入表达式：`new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")                      .OrderByDescending`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(path)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(path);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(Path.Combine(performanceDirectory, "logging-performance.json"))`；返回值紧邻使用处：`BinaryExpressionSyntax: performanceDirectory != null && File.Exists(Path.Combine(performanceDirectory, "logging-performance.json"))`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(Path.Combine(performanceDirectory, "ui-performance.json"))`；返回值紧邻使用处：`BinaryExpressionSyntax: performanceDirectory != null && File.Exists(Path.Combine(performanceDirectory, "ui-performance.json"))`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(path)) File.Delete(path);`
- `System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；输入表达式：`new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.None)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.None)`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(performanceDirectory, "logging-performance.json")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(performanceDirectory, "logging-performance.json")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(performanceDirectory, "ui-performance.json")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(performanceDirectory, "ui-performance.json")`
- `System.Reflection.Assembly.GetName()`；输入表达式：`a.GetName()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: a.GetName().Name`
- `System.Reflection.Assembly.GetName()`；输入表达式：`a.GetName()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: a.GetName().Version`
- `System.Version.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: a.GetName().Version?.ToString()`
- `Write(string, string)`；输入表达式：`Write("说明.txt", "问题报告 v" + ModVersion + "\n\n包含当前模组生涯、比赛种子及路线、社区和生成状态、运行环境、最近请求与错误记录。\n"                  + "AI 请求记录含发送的提示词和收到的内容，便于排查上下文与格式问题。凭据已自动隐藏。\n"                  + "请同时说明操作步骤、发生时间以及预期结果。截图可另附。\n"                  + "普通运行、随机事件和比赛日志各保留最近五份文件，达到约2 MiB后在下一条写入前轮换；超过轮换点的完整记录仍然保留。较早文件随轮换清除。\n"                  + "随机事件包含完整请求、原始回复和效果检查现场；比赛日志按本生涯编号导出。队友报告包含其保留范围内的完整记录。\n"                  + "日志读取到导出开始时的完整记录边界；凭据自动隐藏，文件全文随报告导出。\n"                  + "导出缺失项：\n" + (notes.Count == 0 ? "所有项目读取完成。" : string.Join("\n", notes)))`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("说明.txt", "问题报告 v" + ModVersion + "\n\n包含当前模组生涯、比赛种子及路线、社区和生成状态、运行环境、最近请求与错误记录。\n"                  + "AI 请求记录含发送的提示词和收到的内容，便于排查上下文与格式问题。凭据已自动隐藏。\n"                  + "请同时说明操作步骤、发生时间以及预期结果。截图可另附。\n"                  + "普通运行、随机事件和比赛日志各保留最近五份文件，达到约2 MiB后在下一条写入前轮换；超过轮换点的完整记录仍然保留。较早文件随轮换清除。\n"                  + "随机事件包含完整请求、原始回复和效果检查现场；比赛日志按本生涯编号导出。队友报告包含其保留范围内的完整记录。\n"                  + "日志读取到导出开始时的完整记录边界；凭据自动隐藏，文件全文随报告导出。\n"                  + "导出缺失项：\n" + (notes.Count == 0 ? "所有项目读取完成。" : string.Join("\n", notes)));`
- `Write(string, string)`；输入表达式：`Write("matches/" + trace.Key, trace.Value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("matches/" + trace.Key, trace.Value);`
- `Write(string, string)`；输入表达式：`Write("mod-logs/" + log.Key, log.Value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("mod-logs/" + log.Key, log.Value);`
- `Write(string, string)`；输入表达式：`Write("random-events.jsonl", ReadEventRecords())`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("random-events.jsonl", ReadEventRecords());`
- `Write(string, string)`；输入表达式：`Write("session-events.jsonl", string.Join('\n', events))`；返回值紧邻使用处：`ExpressionStatementSyntax: Write("session-events.jsonl", string.Join('\n', events));`
- `Write(string, string)`；输入表达式：`Write(report.Key, report.Value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write(report.Key, report.Value);`

**赋值（含属性/字段和局部值）：**

- `directory` = `_directory`
- `events` = `Events.ToArray()`
- `performanceDirectory` = `_directory`

<a id="symbol-ce12a81c6025"></a>

## `Write(string, string) — void Write(string name, string value)`

来源：源码第 170 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`LogFile(string, string)`](Diagnostics.cs.md#symbol-939c3680e915)；[`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)；[`Section(string, System.Func<object>)`](Diagnostics.cs.md#symbol-5046f5179bb2)

**调用：** [`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；`System.IO.Compression.ZipArchive.CreateEntry(string, System.IO.Compression.CompressionLevel)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.StreamWriter.StreamWriter(System.IO.Stream, System.Text.Encoding)`；`System.IO.StreamWriter.Write(string?)`；`System.Text.UTF8Encoding.UTF8Encoding(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(value)`；返回值紧邻使用处：`ArgumentSyntax: Redact(value)`
- `System.IO.Compression.ZipArchive.CreateEntry(string, System.IO.Compression.CompressionLevel)`；输入表达式：`zip.CreateEntry(name, CompressionLevel.Fastest)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: zip.CreateEntry(name, CompressionLevel.Fastest).Open`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`zip.CreateEntry(name, CompressionLevel.Fastest).Open()`；返回值紧邻使用处：`ArgumentSyntax: zip.CreateEntry(name, CompressionLevel.Fastest).Open()`
- `System.IO.StreamWriter.StreamWriter(System.IO.Stream, System.Text.Encoding)`；输入表达式：`new StreamWriter(zip.CreateEntry(name, CompressionLevel.Fastest).Open(), new UTF8Encoding(false))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamWriter(zip.CreateEntry(name, CompressionLevel.Fastest).Open(), new UTF8Encoding(false))`
- `System.IO.StreamWriter.Write(string?)`；输入表达式：`writer.Write(Redact(value))`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.Write(Redact(value));`
- `System.Text.UTF8Encoding.UTF8Encoding(bool)`；输入表达式：`new UTF8Encoding(false)`；返回值紧邻使用处：`ArgumentSyntax: new UTF8Encoding(false)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5046f5179bb2"></a>

## `Section(string, System.Func<object>) — void Section(string name, Func<object> read)`

来源：源码第 175 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)

**调用：** [`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`Write(string, string)`](Diagnostics.cs.md#symbol-ce12a81c6025)；`System.Collections.Generic.List<T>.Add(T)`；`System.Exception.ToString()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Json`；`NationalSpire.Diagnostics.Redact(string)`；`Write(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(e.ToString())`；返回值紧邻使用处：`BinaryExpressionSyntax: name + "：" + Redact(e.ToString())`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`notes.Add(name + "：" + Redact(e.ToString()))`；返回值紧邻使用处：`ExpressionStatementSyntax: notes.Add(name + "：" + Redact(e.ToString()));`
- `System.Exception.ToString()`；输入表达式：`e.ToString()`；返回值紧邻使用处：`ArgumentSyntax: e.ToString()`
- `System.Func<TResult>.Invoke()`；输入表达式：`read()`；返回值紧邻使用处：`ArgumentSyntax: read()`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(read(), Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(read(), Json)`
- `Write(string, string)`；输入表达式：`Write(name, JsonSerializer.Serialize(read(), Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: Write(name, JsonSerializer.Serialize(read(), Json));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-939c3680e915"></a>

## `LogFile(string, string) — void LogFile(string log, string entry)`

来源：源码第 180 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)

**调用：** [`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`Write(string, string)`](Diagnostics.cs.md#symbol-ce12a81c6025)；`NationalSpire.Diagnostics.TraceSnapshot.TraceSnapshot(System.IO.FileStream, long)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Exception.ToString()`；`System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；`System.IO.StreamReader.ReadToEnd()`；`System.IO.StreamReader.StreamReader(System.IO.Stream, System.Text.Encoding, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Redact(string)`；`Write(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(e.ToString())`；返回值紧邻使用处：`BinaryExpressionSyntax: entry + "：" + Redact(e.ToString())`
- `NationalSpire.Diagnostics.TraceSnapshot.TraceSnapshot(System.IO.FileStream, long)`；输入表达式：`new TraceSnapshot(input, input.Length)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TraceSnapshot(input, input.Length)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`notes.Add(entry + "：" + Redact(e.ToString()))`；返回值紧邻使用处：`ExpressionStatementSyntax: notes.Add(entry + "：" + Redact(e.ToString()));`
- `System.Exception.ToString()`；输入表达式：`e.ToString()`；返回值紧邻使用处：`ArgumentSyntax: e.ToString()`
- `System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；输入表达式：`new FileStream(log, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new FileStream(log, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete)`
- `System.IO.StreamReader.ReadToEnd()`；输入表达式：`reader.ReadToEnd()`；返回值紧邻使用处：`ArgumentSyntax: reader.ReadToEnd()`
- `System.IO.StreamReader.StreamReader(System.IO.Stream, System.Text.Encoding, bool)`；输入表达式：`new StreamReader(snapshot, Encoding.UTF8, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamReader(snapshot, Encoding.UTF8, true)`
- `Write(string, string)`；输入表达式：`Write(entry, reader.ReadToEnd())`；返回值紧邻使用处：`ExpressionStatementSyntax: Write(entry, reader.ReadToEnd());`

**赋值（含属性/字段和局部值）：**
