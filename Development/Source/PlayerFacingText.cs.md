# PlayerFacingText.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`3139418DBFDADB072B14D4AAE0385BE858489FC89E1066CC701E710423C1D0CA`。来源：[源码](../../PlayerFacingText.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PlayerFacingText`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-be617f3bd292"></a>

## `NationalSpire.PlayerFacingText.AiError(string) — public static string AiError(string detail)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`NationalSpire.PlayerFacingText.AiErrorPreview(string)`](PlayerFacingText.cs.md#symbol-fc1bb7a47c87)；[`NationalSpire.PlayerFacingText.AiStatus(string)`](PlayerFacingText.cs.md#symbol-6179a4a56aad)

**调用：** [`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`NationalSpire.PlayerFacingText.LongError(string)`](PlayerFacingText.cs.md#symbol-f9422d3b8971)；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.PlayerFacingText.LongError(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(LongError(detail))`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(detail)          ? "未记录错误详情，请重试后查看。" : Diagnostics.Redact(LongError(detail))`
- `NationalSpire.PlayerFacingText.LongError(string)`；输入表达式：`LongError(detail)`；返回值紧邻使用处：`ArgumentSyntax: LongError(detail)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(detail)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(detail)          ? "未记录错误详情，请重试后查看。" : Diagnostics.Redact(LongError(detail))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f9422d3b8971"></a>

## `NationalSpire.PlayerFacingText.LongError(string) — public static string LongError(string detail)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Infer()`](PortraitDesignScreen.cs.md#symbol-84dd4f56a6bf)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.ShowPrivateCommandError(string)`](PrivateMessageScreen.cs.md#symbol-b6171f4aaa2c)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.Diagnostics.RetainError(string, NationalSpire.LogArea, string)`](ErrorDiagnostics.cs.md#symbol-3308746be2f3)；[`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)；[`NationalSpire.PlayerFacingText.AiError(string)`](PlayerFacingText.cs.md#symbol-be617f3bd292)；[`Refresh()`](PromptTestScreen.cs.md#symbol-2f327d34cc7f)；[`ShowMaterial()`](PromptTestScreen.cs.md#symbol-cdc41fbb950f)

**调用：** [`NationalSpire.Diagnostics.ErrorExplanation(string)`](ErrorDiagnostics.cs.md#symbol-5c9c7984b1e7)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`NationalSpire.PlayerFacingText.Field(System.Text.Json.JsonElement, string)`](PlayerFacingText.cs.md#symbol-9d12296da106)；[`NationalSpire.PlayerFacingText.Head(string, int)`](PlayerFacingText.cs.md#symbol-9218219c34ce)；`string?.AsMemory(int, int)`；`string.Contains(string, System.StringComparison)`；`string.Contains(string)`；`string.IndexOf(char)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.LastIndexOf(char)`；`string.StartsWith(string)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Net.WebUtility.HtmlDecode(string?)`；`System.Text.Json.JsonDocument.Parse(System.ReadOnlyMemory<char>, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；`System.Text.RegularExpressions.Regex.Match(string, string, System.Text.RegularExpressions.RegexOptions)`；`System.Text.RegularExpressions.Regex.Match(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.ErrorExplanation(string)`；`NationalSpire.Diagnostics.ErrorTextLimit`；`NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.PlayerFacingText.Field(System.Text.Json.JsonElement, string)`；`NationalSpire.PlayerFacingText.Head(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.ErrorExplanation(string)`；输入表达式：`Diagnostics.ErrorExplanation(detail)`；返回值紧邻使用处：`AssignmentExpressionSyntax: detail = Diagnostics.ErrorExplanation(detail)`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(prefix + Head(reason, Diagnostics.ErrorTextLimit) + metadata)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Diagnostics.Redact(prefix + Head(reason, Diagnostics.ErrorTextLimit) + metadata)`
- `NationalSpire.PlayerFacingText.Field(System.Text.Json.JsonElement, string)`；输入表达式：`Field(error, "message")`；返回值紧邻使用处：`BinaryExpressionSyntax: Field(error, "message") ?? Field(root, "message")                          ?? (error.ValueKind == JsonValueKind.String ? error.GetString() : null)                          ?? Field(root, "detail") ?? detail`
- `NationalSpire.PlayerFacingText.Field(System.Text.Json.JsonElement, string)`；输入表达式：`Field(error, key)`；返回值紧邻使用处：`BinaryExpressionSyntax: Field(error, key) ?? Field(root, key)`
- `NationalSpire.PlayerFacingText.Field(System.Text.Json.JsonElement, string)`；输入表达式：`Field(root, "detail")`；返回值紧邻使用处：`BinaryExpressionSyntax: Field(root, "detail") ?? detail`
- `NationalSpire.PlayerFacingText.Field(System.Text.Json.JsonElement, string)`；输入表达式：`Field(root, "message")`；返回值紧邻使用处：`BinaryExpressionSyntax: Field(root, "message")                          ?? (error.ValueKind == JsonValueKind.String ? error.GetString() : null)                          ?? Field(root, "detail") ?? detail`
- `NationalSpire.PlayerFacingText.Field(System.Text.Json.JsonElement, string)`；输入表达式：`Field(root, key)`；返回值紧邻使用处：`BinaryExpressionSyntax: Field(error, key) ?? Field(root, key)`
- `NationalSpire.PlayerFacingText.Head(string, int)`；输入表达式：`Head(field, 120)`；返回值紧邻使用处：`InterpolationSyntax: {Head(field, 120)}`
- `NationalSpire.PlayerFacingText.Head(string, int)`；输入表达式：`Head(match.Groups[1].Value, 240)`；返回值紧邻使用处：`ArgumentSyntax: Head(match.Groups[1].Value, 240)`
- `NationalSpire.PlayerFacingText.Head(string, int)`；输入表达式：`Head(reason, Diagnostics.ErrorTextLimit)`；返回值紧邻使用处：`BinaryExpressionSyntax: prefix + Head(reason, Diagnostics.ErrorTextLimit)`
- `NationalSpire.PlayerFacingText.Head(string, int)`；输入表达式：`Head(status, 120)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Head(status, 120).Trim`
- `NationalSpire.PlayerFacingText.Head(string, int)`；输入表达式：`Head(text, Diagnostics.ErrorTextLimit - suffix.Length)`；返回值紧邻使用处：`BinaryExpressionSyntax: Head(text, Diagnostics.ErrorTextLimit - suffix.Length) + suffix`
- `string?.AsMemory(int, int)`；输入表达式：`detail.AsMemory(start, end - start + 1)`；返回值紧邻使用处：`ArgumentSyntax: detail.AsMemory(start, end - start + 1)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`reason.Contains("<!DOCTYPE html", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: reason.Contains("<html", StringComparison.OrdinalIgnoreCase) || reason.Contains("<!DOCTYPE html", StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`reason.Contains("<html", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: reason.Contains("<html", StringComparison.OrdinalIgnoreCase) || reason.Contains("<!DOCTYPE html", StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string)`；输入表达式：`h.Contains(heading)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: h => h.Contains(heading)`
- `string.IndexOf(char)`；输入表达式：`detail.IndexOf('{')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = detail.IndexOf('{')`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" · ", headings)`；返回值紧邻使用处：`BinaryExpressionSyntax: " " + string.Join(" · ", headings)`
- `string.LastIndexOf(char)`；输入表达式：`detail.LastIndexOf('}')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = detail.LastIndexOf('}')`
- `string.StartsWith(string)`；输入表达式：`reason.StartsWith(status)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !reason.StartsWith(status)`
- `string.Trim()`；输入表达式：`Head(status, 120).Trim()`；返回值紧邻使用处：`BinaryExpressionSyntax: Head(status, 120).Trim() + "\n"`
- `string.Trim()`；输入表达式：`WebUtility.HtmlDecode(Head(match.Groups[1].Value, 240)).Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = WebUtility.HtmlDecode(Head(match.Groups[1].Value, 240)).Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`headings.Any(h => h.Contains(heading))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !headings.Any(h => h.Contains(heading))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`headings.Add(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: headings.Add(heading);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Net.WebUtility.HtmlDecode(string?)`；输入表达式：`WebUtility.HtmlDecode(Head(match.Groups[1].Value, 240))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WebUtility.HtmlDecode(Head(match.Groups[1].Value, 240)).Trim`
- `System.Text.Json.JsonDocument.Parse(System.ReadOnlyMemory<char>, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(detail.AsMemory(start, end - start + 1))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(detail.AsMemory(start, end - start + 1))`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`error.GetString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: error.ValueKind == JsonValueKind.String ? error.GetString() : null`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("error", out var value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: root.TryGetProperty("error", out var value) ? value : default`
- `System.Text.RegularExpressions.Regex.Match(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.Match(reason, $@"<{tag}\b[^>]*>([^<]*)</{tag}\s*>", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Regex.Match(reason, $@"<{tag}\b[^>]*>([^<]*)</{tag}\s*>", RegexOptions.IgnoreCase)`
- `System.Text.RegularExpressions.Regex.Match(string, string)`；输入表达式：`Regex.Match(detail, @"HTTP \d{3}[^\r\n{<]*")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Regex.Match(detail, @"HTTP \d{3}[^\r\n{<]*").Value`

**赋值（含属性/字段和局部值）：**

- `detail` = `Diagnostics.ErrorExplanation(detail)`
- `metadata` += `$"\n{key}: {Head(field, 120)}"`
- `reason` = `"接口返回了错误网页。" + (headings.Count > 0 ? " " + string.Join(" · ", headings) : "")`
- `reason` = `Field(error, "message") ?? Field(root, "message")                          ?? (error.ValueKind == JsonValueKind.String ? error.GetString() : null)                          ?? Field(root, "detail") ?? detail`

<a id="symbol-9d12296da106"></a>

## `NationalSpire.PlayerFacingText.Field(System.Text.Json.JsonElement, string) — private static string? Field(JsonElement element, string name)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PlayerFacingText.LongError(string)`](PlayerFacingText.cs.md#symbol-f9422d3b8971)

**调用：** `System.Text.Json.JsonElement.ToString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.JsonElement.ToString()`；输入表达式：`value.ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: element.ValueKind == JsonValueKind.Object          && element.TryGetProperty(name, out var value) && value.ValueKind is JsonValueKind.String or JsonValueKind.Number          ? value.ToString() : null`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`element.TryGetProperty(name, out var value)`；返回值紧邻使用处：`BinaryExpressionSyntax: element.ValueKind == JsonValueKind.Object          && element.TryGetProperty(name, out var value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9218219c34ce"></a>

## `NationalSpire.PlayerFacingText.Head(string, int) — private static string Head(string text, int length)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PlayerFacingText.LongError(string)`](PlayerFacingText.cs.md#symbol-f9422d3b8971)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fc1bb7a47c87"></a>

## `NationalSpire.PlayerFacingText.AiErrorPreview(string) — public static string AiErrorPreview(string detail)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)

**调用：** [`NationalSpire.PlayerFacingText.AiError(string)`](PlayerFacingText.cs.md#symbol-be617f3bd292)；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PlayerFacingText.AiError(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PlayerFacingText.AiError(string)`；输入表达式：`AiError(detail)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiError(detail).Replace`
- `string.Replace(string, string?)`；输入表达式：`AiError(detail).Replace("\r", "").Replace("\n", " · ")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiError(detail).Replace("\r", "").Replace("\n", " · ")`
- `string.Replace(string, string?)`；输入表达式：`AiError(detail).Replace("\r", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiError(detail).Replace("\r", "").Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6179a4a56aad"></a>

## `NationalSpire.PlayerFacingText.AiStatus(string) — public static string AiStatus(string status)`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)；[`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)

**调用：** [`NationalSpire.PlayerFacingText.AiError(string)`](PlayerFacingText.cs.md#symbol-be617f3bd292)；`string.Replace(string, string?)`；`string.StartsWith(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.PlayerFacingText.AiError(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PlayerFacingText.AiError(string)`；输入表达式：`AiError(status)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => AiError(status)`
- `string.Replace(string, string?)`；输入表达式：`status.Replace(" 篇 AI 更新", " 篇新内容")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ when status.StartsWith("已发布 ") => status.Replace(" 篇 AI 更新", " 篇新内容")`
- `string.StartsWith(string)`；输入表达式：`status.StartsWith("第 ")`；返回值紧邻使用处：`BinaryExpressionSyntax: status.StartsWith("正在") || status.StartsWith("第 ")`
- `string.StartsWith(string)`；输入表达式：`status.StartsWith("已发布 ")`；返回值紧邻使用处：`WhenClauseSyntax: when status.StartsWith("已发布 ")`
- `string.StartsWith(string)`；输入表达式：`status.StartsWith("正在")`；返回值紧邻使用处：`BinaryExpressionSyntax: status.StartsWith("正在") || status.StartsWith("第 ")`

**赋值（含属性/字段和局部值）：**
