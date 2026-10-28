# ErrorDiagnostics.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`427929E28CE30BA2EB3847905B65C5D7C93F5A97D5B822001EFF3A6F51D7A197`。来源：[源码](../../ErrorDiagnostics.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Diagnostics`。

字段、事件及初始值（源码原样）：

```csharp
internal const int ErrorTextLimit = 1000;
private const string ErrorReference = "\n诊断编号：";
```

<a id="symbol-3308746be2f3"></a>

## `NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string) — internal static string RetainError(string error, LogArea area, string context)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Keep(string, NationalSpire.LogArea, string)`](ErrorDiagnostics.cs.md#symbol-1d034e3f9d97)；[`NationalSpire.Diagnostics.RetainLifeErrors(NationalSpire.CareerLifeState, string)`](ErrorDiagnostics.cs.md#symbol-352228579747)；[`NationalSpire.Diagnostics.RetainMailboxErrors(NationalSpire.PrivateMailbox, string)`](ErrorDiagnostics.cs.md#symbol-00bf5510a307)

**调用：** [`NationalSpire.Diagnostics.BeginLog(NationalSpire.LogArea, string)`](LogRouting.cs.md#symbol-da8a28a9e81e)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.PlayerFacingText.LongError(string)`](PlayerFacingText.cs.md#symbol-f9422d3b8971)；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.BeginLog(NationalSpire.LogArea, string)`；`NationalSpire.Diagnostics.ErrorReference`；`NationalSpire.Diagnostics.ErrorTextLimit`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.PlayerFacingText.LongError(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.BeginLog(NationalSpire.LogArea, string)`；输入表达式：`BeginLog(area, context)`；返回值紧邻使用处：`UsingStatementSyntax: using (BeginLog(area, context)) Record("error.full", new { id, context, error });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Record("error.full", new { id, context, error })`；返回值紧邻使用处：`ExpressionStatementSyntax: Record("error.full", new { id, context, error });`
- `NationalSpire.PlayerFacingText.LongError(string)`；输入表达式：`PlayerFacingText.LongError(error)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayerFacingText.LongError(error)`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5c9c7984b1e7"></a>

## `NationalSpire.Diagnostics.ErrorExplanation(string) — internal static string ErrorExplanation(string error)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PlayerFacingText.LongError(string)`](PlayerFacingText.cs.md#symbol-f9422d3b8971)

**调用：** [`NationalSpire.Diagnostics.ReadErrorReference(string, out int, out string, out int)`](ErrorDiagnostics.cs.md#symbol-ef265abed991)

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.ReadErrorReference(string, out int, out string, out int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.ReadErrorReference(string, out int, out string, out int)`；输入表达式：`ReadErrorReference(error, out _, out _, out int marker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ReadErrorReference(error, out _, out _, out int marker) ? error[..marker] : error`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ef265abed991"></a>

## `NationalSpire.Diagnostics.ReadErrorReference(string, out int, out string, out int) — private static bool ReadErrorReference(string error, out int area, out string id, out int marker)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.ErrorDetail(string)`](ErrorDiagnostics.cs.md#symbol-1825d5559456)；[`NationalSpire.Diagnostics.ErrorExplanation(string)`](ErrorDiagnostics.cs.md#symbol-5c9c7984b1e7)

**调用：** `int.TryParse(string?, out int)`；`string.LastIndexOf(string, System.StringComparison)`；`string.Split(char, System.StringSplitOptions)`；`System.Guid.TryParseExact(string?, string?, out System.Guid)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.ErrorReference`；`NationalSpire.Diagnostics.LogNames`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(reference[0], out area)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !int.TryParse(reference[0], out area)`
- `string.LastIndexOf(string, System.StringComparison)`；输入表达式：`error.LastIndexOf(ErrorReference, StringComparison.Ordinal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: marker = error.LastIndexOf(ErrorReference, StringComparison.Ordinal)`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`error[(marker + ErrorReference.Length)..].Split('/')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = error[(marker + ErrorReference.Length)..].Split('/')`
- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(reference[1], "N", out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Guid.TryParseExact(reference[1], "N", out _)`

**赋值（含属性/字段和局部值）：**

- `area` = `0`
- `id` = `""`
- `id` = `reference[1]`
- `marker` = `error.LastIndexOf(ErrorReference, StringComparison.Ordinal)`

<a id="symbol-1825d5559456"></a>

## `NationalSpire.Diagnostics.ErrorDetail(string) — public static string ErrorDetail(string error)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)

**调用：** [`Find(string)`](ErrorDiagnostics.cs.md#symbol-6548d66541ca)；[`NationalSpire.Diagnostics.ReadErrorReference(string, out int, out string, out int)`](ErrorDiagnostics.cs.md#symbol-ef265abed991)；[`NationalSpire.Diagnostics.ReadLogs(string)`](LogStorage.cs.md#symbol-a180c6c02b7d)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；`System.Collections.Generic.Queue<T>.ToArray()`；`System.IO.StringReader.ReadLine()`；`System.IO.StringReader.StringReader(string)`

**字段、属性、事件及方法组引用：** `Find(string)`；`NationalSpire.Diagnostics.Events`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.LogNames`；`NationalSpire.Diagnostics.ReadErrorReference(string, out int, out string, out int)`；`NationalSpire.Diagnostics.ReadLogs(string)`；`NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Find(string)`；输入表达式：`Find(line)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Find(line) is { } original`
- `NationalSpire.Diagnostics.ReadErrorReference(string, out int, out string, out int)`；输入表达式：`ReadErrorReference(error, out int area, out string reference, out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReadErrorReference(error, out int area, out string reference, out _)`
- `NationalSpire.Diagnostics.ReadLogs(string)`；输入表达式：`ReadLogs(LogNames[area])`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var file in ReadLogs(LogNames[area]))         {             using var reader = new StringReader(file.Value);             while (reader.ReadLine() is { } line) if (Find(line) is { } original) return original;         }`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(error)`；返回值紧邻使用处：`BinaryExpressionSyntax: Redact(error) + "\n完整报错已超出该功能最近5份日志的保留范围。"`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(error)`；返回值紧邻使用处：`ReturnStatementSyntax: return Redact(error);`
- `System.Collections.Generic.Queue<T>.ToArray()`；输入表达式：`Events.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: recent = Events.ToArray()`
- `System.IO.StringReader.ReadLine()`；输入表达式：`reader.ReadLine()`；返回值紧邻使用处：`IsPatternExpressionSyntax: reader.ReadLine() is { } line`
- `System.IO.StringReader.StringReader(string)`；输入表达式：`new StringReader(file.Value)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringReader(file.Value)`

**赋值（含属性/字段和局部值）：**

- `recent` = `Events.ToArray()`

<a id="symbol-6548d66541ca"></a>

## `Find(string) — string? Find(string line)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.ErrorDetail(string)`](ErrorDiagnostics.cs.md#symbol-1825d5559456)

**调用：** `string.Contains(string, System.StringComparison)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Contains(string, System.StringComparison)`；输入表达式：`line.Contains(reference, StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !line.Contains(reference, StringComparison.Ordinal)`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(body.GetString()!)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(body.GetString()!)`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(line)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(line)`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`body.GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: body.GetString()!`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`category.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: category.GetString() != "error.full"`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`id.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: id.GetString() == reference`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`original.GetString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: detail.RootElement.ValueKind == JsonValueKind.Object && detail.RootElement.TryGetProperty("id", out var id)                     && id.ValueKind == JsonValueKind.String && id.GetString() == reference                     && detail.RootElement.TryGetProperty("error", out var original) && original.ValueKind == JsonValueKind.String ? original.GetString() : null`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`detail.RootElement.TryGetProperty("error", out var original)`；返回值紧邻使用处：`BinaryExpressionSyntax: detail.RootElement.ValueKind == JsonValueKind.Object && detail.RootElement.TryGetProperty("id", out var id)                     && id.ValueKind == JsonValueKind.String && id.GetString() == reference                     && detail.RootElement.TryGetProperty("error", out var original)`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`detail.RootElement.TryGetProperty("id", out var id)`；返回值紧邻使用处：`BinaryExpressionSyntax: detail.RootElement.ValueKind == JsonValueKind.Object && detail.RootElement.TryGetProperty("id", out var id)`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`row.RootElement.TryGetProperty("category", out var category)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !row.RootElement.TryGetProperty("category", out var category)`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`row.RootElement.TryGetProperty("detail", out var body)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !row.RootElement.TryGetProperty("detail", out var body)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-83a342d01ea6"></a>

## `NationalSpire.Diagnostics.RetainErrors(NationalSpire.CareerData) — internal static bool RetainErrors(CareerData data)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`](Coop/CoopData.cs.md#symbol-3f5e7638f9e9)；[`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)；[`NationalSpire.Diagnostics.RetainErrors(NationalSpire.Coop.CoopWorld)`](ErrorDiagnostics.cs.md#symbol-fd99f468e9e7)

**调用：** [`Keep(string, NationalSpire.LogArea, string)`](ErrorDiagnostics.cs.md#symbol-1d034e3f9d97)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.Diagnostics.RetainLifeErrors(NationalSpire.CareerLifeState, string)`](ErrorDiagnostics.cs.md#symbol-352228579747)；[`NationalSpire.Diagnostics.RetainMailboxErrors(NationalSpire.PrivateMailbox, string)`](ErrorDiagnostics.cs.md#symbol-00bf5510a307)；[`Work(NationalSpire.AiWorkState, NationalSpire.LogArea, string)`](ErrorDiagnostics.cs.md#symbol-1c8ddad9d5ad)

**字段、属性、事件及方法组引用：** `Keep(string, NationalSpire.LogArea, string)`；`NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerData.WorldId`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.ReactionGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ReactionGeneration`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.Diagnostics.RetainLifeErrors(NationalSpire.CareerLifeState, string)`；`NationalSpire.Diagnostics.RetainMailboxErrors(NationalSpire.PrivateMailbox, string)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChat.SummaryError`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupTurn.Error`；`NationalSpire.GroupTurn.Id`；`NationalSpire.GroupTurn.Notices`；`NationalSpire.LogArea.Community`；`NationalSpire.LogArea.Group`；`NationalSpire.LogArea.Weekly`；`NationalSpire.PrivateConversation.SummaryError`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.WeeklyEdition.NewsWork`；`NationalSpire.WeeklyEdition.ProfilesWork`；`NationalSpire.WeeklyEdition.Week`；`Work(NationalSpire.AiWorkState, NationalSpire.LogArea, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Keep(string, NationalSpire.LogArea, string)`；输入表达式：`Keep(conversation.Value.SummaryError, LogArea.Group, context + "/interaction/" + conversation.Key + "/summary")`；返回值紧邻使用处：`AssignmentExpressionSyntax: conversation.Value.SummaryError = Keep(conversation.Value.SummaryError, LogArea.Group, context + "/interaction/" + conversation.Key + "/summary")`
- `Keep(string, NationalSpire.LogArea, string)`；输入表达式：`Keep(group.SummaryError, LogArea.Group, context + "/summary")`；返回值紧邻使用处：`AssignmentExpressionSyntax: group.SummaryError = Keep(group.SummaryError, LogArea.Group, context + "/summary")`
- `Keep(string, NationalSpire.LogArea, string)`；输入表达式：`Keep(turn.Error, LogArea.Group, context + "/" + turn.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Error = Keep(turn.Error, LogArea.Group, context + "/" + turn.Id)`
- `Keep(string, NationalSpire.LogArea, string)`；输入表达式：`Keep(turn.Error, LogArea.Group, context + "/interaction/" + conversation.Key + "/" + turn.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Error = Keep(turn.Error, LogArea.Group, context + "/interaction/" + conversation.Key + "/" + turn.Id)`
- `Keep(string, NationalSpire.LogArea, string)`；输入表达式：`Keep(turn.Notices[i], LogArea.Group, context + "/" + turn.Id + "/notice/" + i)`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Notices[i] = Keep(turn.Notices[i], LogArea.Group, context + "/" + turn.Id + "/notice/" + i)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in CommunityThreads.All(data))         {             string context = world + "/post/" + post.Id;             Work(post.NewsGeneration, LogArea.Community, context + "/news");             Work(post.ReactionGeneration, LogArea.Community, context + "/reaction");             foreach (var reply in post.Replies) Work(reply.ReactionGeneration, LogArea.Community, context + "/reply/" + reply.Id);         }`
- `NationalSpire.Diagnostics.RetainLifeErrors(NationalSpire.CareerLifeState, string)`；输入表达式：`RetainLifeErrors(data.Life, world + "/" + data.LocalHumanId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RetainLifeErrors(data.Life, world + "/" + data.LocalHumanId)`
- `NationalSpire.Diagnostics.RetainMailboxErrors(NationalSpire.PrivateMailbox, string)`；输入表达式：`RetainMailboxErrors(source.Value, world + "/" + source.Key)`；返回值紧邻使用处：`AssignmentExpressionSyntax: changed |= RetainMailboxErrors(source.Value, world + "/" + source.Key)`
- `Work(NationalSpire.AiWorkState, NationalSpire.LogArea, string)`；输入表达式：`Work(issue.NewsWork, LogArea.Weekly, world + "/weekly/" + issue.Week + "/news")`；返回值紧邻使用处：`ExpressionStatementSyntax: Work(issue.NewsWork, LogArea.Weekly, world + "/weekly/" + issue.Week + "/news");`
- `Work(NationalSpire.AiWorkState, NationalSpire.LogArea, string)`；输入表达式：`Work(issue.ProfilesWork, LogArea.Weekly, world + "/weekly/" + issue.Week + "/profiles")`；返回值紧邻使用处：`ExpressionStatementSyntax: Work(issue.ProfilesWork, LogArea.Weekly, world + "/weekly/" + issue.Week + "/profiles");`
- `Work(NationalSpire.AiWorkState, NationalSpire.LogArea, string)`；输入表达式：`Work(post.NewsGeneration, LogArea.Community, context + "/news")`；返回值紧邻使用处：`ExpressionStatementSyntax: Work(post.NewsGeneration, LogArea.Community, context + "/news");`
- `Work(NationalSpire.AiWorkState, NationalSpire.LogArea, string)`；输入表达式：`Work(post.ReactionGeneration, LogArea.Community, context + "/reaction")`；返回值紧邻使用处：`ExpressionStatementSyntax: Work(post.ReactionGeneration, LogArea.Community, context + "/reaction");`
- `Work(NationalSpire.AiWorkState, NationalSpire.LogArea, string)`；输入表达式：`Work(reply.ReactionGeneration, LogArea.Community, context + "/reply/" + reply.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Work(reply.ReactionGeneration, LogArea.Community, context + "/reply/" + reply.Id);`

**赋值（含属性/字段和局部值）：**

- `changed` |= `RetainMailboxErrors(source.Value, world + "/" + source.Key)`
- `conversation.Value.SummaryError` = `Keep(conversation.Value.SummaryError, LogArea.Group, context + "/interaction/" + conversation.Key + "/summary")`
- `group.SummaryError` = `Keep(group.SummaryError, LogArea.Group, context + "/summary")`
- `turn.Error` = `Keep(turn.Error, LogArea.Group, context + "/" + turn.Id)`
- `turn.Error` = `Keep(turn.Error, LogArea.Group, context + "/interaction/" + conversation.Key + "/" + turn.Id)`
- `turn.Notices[i]` = `Keep(turn.Notices[i], LogArea.Group, context + "/" + turn.Id + "/notice/" + i)`

<a id="symbol-1c8ddad9d5ad"></a>

## `Work(NationalSpire.AiWorkState, NationalSpire.LogArea, string) — void Work(AiWorkState work, LogArea area, string context)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.RetainErrors(NationalSpire.CareerData)`](ErrorDiagnostics.cs.md#symbol-83a342d01ea6)

**调用：** [`Keep(string, NationalSpire.LogArea, string)`](ErrorDiagnostics.cs.md#symbol-1d034e3f9d97)

**字段、属性、事件及方法组引用：** `Keep(string, NationalSpire.LogArea, string)`；`NationalSpire.AiWorkState.Error`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Keep(string, NationalSpire.LogArea, string)`；输入表达式：`Keep(work.Error, area, context)`；返回值紧邻使用处：`AssignmentExpressionSyntax: work.Error = Keep(work.Error, area, context)`

**赋值（含属性/字段和局部值）：**

- `work.Error` = `Keep(work.Error, area, context)`

<a id="symbol-1d034e3f9d97"></a>

## `Keep(string, NationalSpire.LogArea, string) — string Keep(string error, LogArea area, string context)`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.RetainErrors(NationalSpire.CareerData)`](ErrorDiagnostics.cs.md#symbol-83a342d01ea6)；[`Work(NationalSpire.AiWorkState, NationalSpire.LogArea, string)`](ErrorDiagnostics.cs.md#symbol-1c8ddad9d5ad)

**调用：** [`NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`](ErrorDiagnostics.cs.md#symbol-3308746be2f3)

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.ErrorTextLimit`；`NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`；输入表达式：`RetainError(error, area, context)`；返回值紧邻使用处：`ReturnStatementSyntax: return RetainError(error, area, context);`

**赋值（含属性/字段和局部值）：**

- `changed` |= `error.Length > ErrorTextLimit`

<a id="symbol-00bf5510a307"></a>

## `NationalSpire.Diagnostics.RetainMailboxErrors(NationalSpire.PrivateMailbox, string) — private static bool RetainMailboxErrors(PrivateMailbox mailbox, string context)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.RetainErrors(NationalSpire.CareerData)`](ErrorDiagnostics.cs.md#symbol-83a342d01ea6)；[`NationalSpire.Diagnostics.RetainLifeErrors(NationalSpire.CareerLifeState, string)`](ErrorDiagnostics.cs.md#symbol-352228579747)

**调用：** [`NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`](ErrorDiagnostics.cs.md#symbol-3308746be2f3)

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.ErrorTextLimit`；`NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`；`NationalSpire.LogArea.Private`；`NationalSpire.PrivateConversation.SummaryError`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`；输入表达式：`RetainError(pair.Value.SummaryError, LogArea.Private, conversation + "/summary")`；返回值紧邻使用处：`AssignmentExpressionSyntax: pair.Value.SummaryError = RetainError(pair.Value.SummaryError, LogArea.Private, conversation + "/summary")`
- `NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`；输入表达式：`RetainError(turn.Error, LogArea.Private, conversation + "/" + turn.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Error = RetainError(turn.Error, LogArea.Private, conversation + "/" + turn.Id)`

**赋值（含属性/字段和局部值）：**

- `changed` |= `pair.Value.SummaryError.Length > ErrorTextLimit`
- `changed` |= `turn.Error.Length > ErrorTextLimit`
- `pair.Value.SummaryError` = `RetainError(pair.Value.SummaryError, LogArea.Private, conversation + "/summary")`
- `turn.Error` = `RetainError(turn.Error, LogArea.Private, conversation + "/" + turn.Id)`

<a id="symbol-352228579747"></a>

## `NationalSpire.Diagnostics.RetainLifeErrors(NationalSpire.CareerLifeState, string) — private static bool RetainLifeErrors(CareerLifeState life, string context)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.RetainErrors(NationalSpire.CareerData)`](ErrorDiagnostics.cs.md#symbol-83a342d01ea6)；[`NationalSpire.Diagnostics.RetainErrors(NationalSpire.Coop.CoopWorld)`](ErrorDiagnostics.cs.md#symbol-fd99f468e9e7)

**调用：** [`NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`](ErrorDiagnostics.cs.md#symbol-3308746be2f3)；[`NationalSpire.Diagnostics.RetainMailboxErrors(NationalSpire.PrivateMailbox, string)`](ErrorDiagnostics.cs.md#symbol-00bf5510a307)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.Diagnostics.ErrorTextLimit`；`NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`；`NationalSpire.Diagnostics.RetainMailboxErrors(NationalSpire.PrivateMailbox, string)`；`NationalSpire.LogArea.Event`；`NationalSpire.RandomEventRecord.Error`；`NationalSpire.RandomEventRecord.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`；输入表达式：`RetainError(record.Error, LogArea.Event, context + "/event/" + record.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: record.Error = RetainError(record.Error, LogArea.Event, context + "/event/" + record.Id)`
- `NationalSpire.Diagnostics.RetainMailboxErrors(NationalSpire.PrivateMailbox, string)`；输入表达式：`RetainMailboxErrors(life.Mailbox, context)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RetainMailboxErrors(life.Mailbox, context)`

**赋值（含属性/字段和局部值）：**

- `changed` |= `record.Error.Length > ErrorTextLimit`
- `record.Error` = `RetainError(record.Error, LogArea.Event, context + "/event/" + record.Id)`

<a id="symbol-fd99f468e9e7"></a>

## `NationalSpire.Diagnostics.RetainErrors(NationalSpire.Coop.CoopWorld) — internal static void RetainErrors(CoopWorld world)`

来源：源码第 133 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`](Coop/CoopData.cs.md#symbol-3f5e7638f9e9)；[`NationalSpire.Coop.CoopStorage.Load(string)`](Coop/CoopStorage.cs.md#symbol-efe4d419a020)；[`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)

**调用：** [`NationalSpire.Diagnostics.RetainErrors(NationalSpire.CareerData)`](ErrorDiagnostics.cs.md#symbol-83a342d01ea6)；[`NationalSpire.Diagnostics.RetainLifeErrors(NationalSpire.CareerLifeState, string)`](ErrorDiagnostics.cs.md#symbol-352228579747)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Diagnostics.RetainErrors(NationalSpire.CareerData)`；`NationalSpire.Diagnostics.RetainLifeErrors(NationalSpire.CareerLifeState, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.RetainErrors(NationalSpire.CareerData)`；输入表达式：`RetainErrors(world.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: RetainErrors(world.World);`
- `NationalSpire.Diagnostics.RetainLifeErrors(NationalSpire.CareerLifeState, string)`；输入表达式：`RetainLifeErrors(member.Life, world.Id + "/" + member.PersonId)`；返回值紧邻使用处：`ExpressionStatementSyntax: RetainLifeErrors(member.Life, world.Id + "/" + member.PersonId);`

**赋值（含属性/字段和局部值）：**
