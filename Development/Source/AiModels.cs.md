# AiModels.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A1571C68AC31088E229E666F2F7DAD90CD03FBB0E08C194C191CEE4A536E0807`。来源：[源码](../../AiModels.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiService`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-fcc71ebee8ac"></a>

## `NationalSpire.AiService.ModelsEndpoint(string) — internal static Uri ModelsEndpoint(string endpoint)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.FetchModelsAsync(string, string?, string)`](AiModels.cs.md#symbol-142ecf753d1d)

**调用：** `string.EndsWith(string, System.StringComparison)`；`string.Trim()`；`string.TrimEnd(char)`；`System.ArgumentException.ArgumentException(string?)`；`System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`；`System.UriBuilder.UriBuilder(System.Uri)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.EndsWith(string, System.StringComparison)`；输入表达式：`path.EndsWith("/chat/completions", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (path.EndsWith("/chat/completions", StringComparison.OrdinalIgnoreCase)) path = path[..^"/chat/completions".Length] + "/models";          else if (!path.EndsWith("/models", StringComparison.OrdinalIgnoreCase)) path = path.Length == 0 ? "/v1/models" : path + "/models";`
- `string.EndsWith(string, System.StringComparison)`；输入表达式：`path.EndsWith("/models", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !path.EndsWith("/models", StringComparison.OrdinalIgnoreCase)`
- `string.Trim()`；输入表达式：`endpoint.Trim()`；返回值紧邻使用处：`ArgumentSyntax: endpoint.Trim()`
- `string.TrimEnd(char)`；输入表达式：`builder.Path.TrimEnd('/')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = builder.Path.TrimEnd('/')`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请填写完整的 http:// 或 https:// 服务地址。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请填写完整的 http:// 或 https:// 服务地址。");`
- `System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`；输入表达式：`Uri.TryCreate(endpoint.Trim(), UriKind.Absolute, out var address)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Uri.TryCreate(endpoint.Trim(), UriKind.Absolute, out var address)`
- `System.UriBuilder.UriBuilder(System.Uri)`；输入表达式：`new UriBuilder(address) { Fragment = "" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new UriBuilder(address) { Fragment = "" }`

**赋值（含属性/字段和局部值）：**

- `builder.Path` = `path`
- `Fragment` = `""`
- `path` = `path.Length == 0 ? "/v1/models" : path + "/models"`
- `path` = `path[..^"/chat/completions".Length] + "/models"`

<a id="symbol-142ecf753d1d"></a>

## `NationalSpire.AiService.FetchModelsAsync(string, string?, string) — public static async Task<IReadOnlyList<string>> FetchModelsAsync(string endpoint, string? enteredKey, string profile = AiRouting.Default)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** [`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`](AiService.cs.md#symbol-80abc5b58bda)；[`NationalSpire.AiService.ModelsEndpoint(string)`](AiModels.cs.md#symbol-fcc71ebee8ac)；[`NationalSpire.AiService.ProfileKey(string)`](AiService.cs.md#symbol-96c9adf50cfa)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`NationalSpire.Diagnostics.RegisterSecret(string?)`](Diagnostics.cs.md#symbol-4f621c46a4ca)；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.IO.InvalidDataException.InvalidDataException(string?, System.Exception?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Net.Http.Headers.AuthenticationHeaderValue.AuthenticationHeaderValue(string, string?)`；`System.Net.Http.HttpContent.ReadAsStringAsync()`；`System.Net.Http.HttpRequestMessage.HttpRequestMessage(System.Net.Http.HttpMethod, System.Uri?)`；`System.Net.Http.HttpRequestOptions.Set<TValue>(System.Net.Http.HttpRequestOptionsKey<TValue>, TValue)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；`System.TimeSpan.FromSeconds(long)`；`System.Uri.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: int status, string body>.status`；`<anonymous type: string endpoint, string credential>.credential`；`<anonymous type: string endpoint, string credential>.endpoint`；`<anonymous type: string error>.error`；`NationalSpire.AiRouting.Default`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`；`NationalSpire.AiService.ModelsEndpoint(string)`；`NationalSpire.AiService.ProfileKey(string)`；`NationalSpire.AiService.TimeoutOption`；`NationalSpire.AiService.Transport`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.Diagnostics.RegisterSecret(string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: error = FailureReason(e)`
- `NationalSpire.AiService.HttpFailure(System.Net.Http.HttpResponseMessage)`；输入表达式：`HttpFailure(response)`；返回值紧邻使用处：`AwaitExpressionSyntax: await HttpFailure(response)`
- `NationalSpire.AiService.ModelsEndpoint(string)`；输入表达式：`ModelsEndpoint(endpoint)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ModelsEndpoint(endpoint)`
- `NationalSpire.AiService.ProfileKey(string)`；输入表达式：`ProfileKey(profile)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(enteredKey) ? ProfileKey(profile) : enteredKey.Trim()`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.models.failed", new { error = FailureReason(e) })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.models.failed", new { error = FailureReason(e) });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.models.request", new { endpoint = uri.ToString(), credential = string.IsNullOrWhiteSpace(enteredKey) ? "saved" : "input" })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.models.request", new { endpoint = uri.ToString(), credential = string.IsNullOrWhiteSpace(enteredKey) ? "saved" : "input" });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.models.response", new { status = (int)response.StatusCode, body })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.models.response", new { status = (int)response.StatusCode, body });`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(body)`；返回值紧邻使用处：`BinaryExpressionSyntax: "接口没有返回模型列表。\n" + Diagnostics.Redact(body)`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(rawBody)`；返回值紧邻使用处：`BinaryExpressionSyntax: "接口返回的内容不是有效的模型列表 JSON。\n" + Diagnostics.Redact(rawBody)`
- `NationalSpire.Diagnostics.RegisterSecret(string?)`；输入表达式：`Diagnostics.RegisterSecret(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RegisterSecret(key);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(enteredKey)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(enteredKey) ? "saved" : "input"`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(enteredKey)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(enteredKey) ? ProfileKey(profile) : enteredKey.Trim()`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(id)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(key)) throw new InvalidOperationException("请先填写 API 密钥。");`
- `string.Trim()`；输入表达式：`enteredKey.Trim()`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(enteredKey) ? ProfileKey(profile) : enteredKey.Trim()`
- `System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；输入表达式：`rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select(row => row.GetProperty("id").GetString()!).Where(id => !string.IsNullOrWhiteSpace(id))                  .Distinct(StringComparer.Ordinal).Order(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select(row => row.GetProperty("id").GetString()!).Where(id => !string.IsNullOrWhiteSpace(id))                  .Distinct(StringComparer.Ordinal).Order(StringComparer.OrdinalIgnoreCase).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select(row => row.GetProperty("id").GetString()!).Where(id => !string.IsNullOrWhiteSpace(id))                  .Distinct(StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select(row => row.GetProperty("id").GetString()!).Where(id => !string.IsNullOrWhiteSpace(id))                  .Distinct(StringComparer.Ordinal).Order`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select(row => row.GetProperty("id").GetString()!)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select(row => row.GetProperty("id").GetString()!).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select(row => row.GetProperty("id").GetString()!).Where(id => !string.IsNullOrWhiteSpace(id))                  .Distinct(StringComparer.Ordinal).Order(StringComparer.OrdinalIgnoreCase).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select(row => row.GetProperty("id").GetString()!).Where(id => !string.IsNullOrWhiteSpace(id))                  .Distinct(StringComparer.Ordinal).Order(StringComparer.OrdinalIgnoreCase).ToArray();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select(row => row.GetProperty("id").GetString()!).Where(id => !string.IsNullOrWhiteSpace(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select(row => row.GetProperty("id").GetString()!).Where(id => !string.IsNullOrWhiteSpace(id))                  .Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)                  .Select`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`Transport(request)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Transport(request)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先填写 API 密钥。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先填写 API 密钥。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException(await HttpFailure(response))`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException(await HttpFailure(response));`
- `System.IO.InvalidDataException.InvalidDataException(string?, System.Exception?)`；输入表达式：`new InvalidDataException("接口返回的内容不是有效的模型列表 JSON。\n" + Diagnostics.Redact(rawBody), e)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("接口返回的内容不是有效的模型列表 JSON。\n" + Diagnostics.Redact(rawBody), e);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("接口没有返回模型列表。\n" + Diagnostics.Redact(body))`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("接口没有返回模型列表。\n" + Diagnostics.Redact(body));`
- `System.Net.Http.Headers.AuthenticationHeaderValue.AuthenticationHeaderValue(string, string?)`；输入表达式：`new AuthenticationHeaderValue("Bearer", key)`；返回值紧邻使用处：`AssignmentExpressionSyntax: request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", key)`
- `System.Net.Http.HttpContent.ReadAsStringAsync()`；输入表达式：`response.Content.ReadAsStringAsync()`；返回值紧邻使用处：`AwaitExpressionSyntax: await response.Content.ReadAsStringAsync()`
- `System.Net.Http.HttpRequestMessage.HttpRequestMessage(System.Net.Http.HttpMethod, System.Uri?)`；输入表达式：`new HttpRequestMessage(HttpMethod.Get, uri)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HttpRequestMessage(HttpMethod.Get, uri)`
- `System.Net.Http.HttpRequestOptions.Set<TValue>(System.Net.Http.HttpRequestOptionsKey<TValue>, TValue)`；输入表达式：`request.Options.Set(TimeoutOption, TimeSpan.FromSeconds(30))`；返回值紧邻使用处：`ExpressionStatementSyntax: request.Options.Set(TimeoutOption, TimeSpan.FromSeconds(30));`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(body)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(body)`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`rows.EnumerateArray()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.EnumerateArray().Where`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`row.GetProperty("id")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetProperty("id").GetString`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`row.GetProperty("id").GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: row.GetProperty("id").GetString()!`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("data", out var rows)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !root.TryGetProperty("data", out var rows)`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`row.TryGetProperty("id", out var id)`；返回值紧邻使用处：`BinaryExpressionSyntax: row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id)`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(30)`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromSeconds(30)`
- `System.Uri.ToString()`；输入表达式：`uri.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: endpoint = uri.ToString()`

**赋值（含属性/字段和局部值）：**

- `rawBody` = `body`
- `request.Headers.Authorization` = `new AuthenticationHeaderValue("Bearer", key)`
