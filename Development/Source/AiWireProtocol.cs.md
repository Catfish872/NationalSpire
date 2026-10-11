# AiWireProtocol.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`99A84FC3E751ABE43E1FCE0C004F6EA1D9FB4857C41572F643886E46C2D802B5`。来源：[源码](../../AiWireProtocol.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiWireProtocol`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly System.Text.Json.JsonSerializerOptions Json = new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
private readonly Dictionary<string, string> _encode = new();
private readonly Dictionary<string, string> _decode = new();
private readonly List<(string Earlier, string Current)> _names = [];
private static readonly HashSet<string> IdFields = ["id", "Id", "authorId", "AuthorId", "parentId", "ParentId", "postId", "PostId", "allowedAuthors", "requiredAuthors", "messageId", "People"];
```

<a id="symbol-ebb8d59c054e"></a>

## `NationalSpire.AiWireProtocol.AiWireProtocol(NationalSpire.CareerData) — internal AiWireProtocol(CareerData data)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-28e7b92711a0)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`Add(string, string)`](AiWireProtocol.cs.md#symbol-3184fc1626bd)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `Add(string, string)`；`NationalSpire.AiWireProtocol._names`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.PlayerNameAliases`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(string, string)`；输入表达式：`Add(p.Id, "t" + ++post)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(p.Id, "t" + ++post);`
- `Add(string, string)`；输入表达式：`Add(p.Id, "u" + ++person)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(p.Id, "u" + ++person);`
- `Add(string, string)`；输入表达式：`Add(r.Id, "c" + ++comment)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(r.Id, "c" + ++comment);`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(data)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: a != CareerEngine.Name(data)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var p in CommunityThreads.All(data))          {              Add(p.Id, "t" + ++post);              foreach (var r in p.Replies) Add(r.Id, "c" + ++comment);          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.PlayerNameAliases.Where(a => a != CareerEngine.Name(data) && a.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string alias in data.PlayerNameAliases.Where(a => a != CareerEngine.Name(data) && a.Length > 0))              _names.Add((alias, CareerEngine.Name(data)));`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.HandleAliases.Where(a => a != p.PublicName && a.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string alias in p.HandleAliases.Where(a => a != p.PublicName && a.Length > 0)) _names.Add((alias, p.PublicName));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_names.Add((alias, CareerEngine.Name(data)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _names.Add((alias, CareerEngine.Name(data)));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_names.Add((alias, p.PublicName))`；返回值紧邻使用处：`ExpressionStatementSyntax: _names.Add((alias, p.PublicName));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3184fc1626bd"></a>

## `Add(string, string) — void Add(string id, string shortId)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiWireProtocol.AiWireProtocol(NationalSpire.CareerData)`](AiWireProtocol.cs.md#symbol-ebb8d59c054e)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWireProtocol._decode`；`NationalSpire.AiWireProtocol._encode`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_decode.Add(shortId, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _decode.Add(shortId, id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`_encode.TryAdd(id, shortId)`；返回值紧邻使用处：`BinaryExpressionSyntax: id.Length > 0 && id != "player" && _encode.TryAdd(id, shortId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bcdcbacd353a"></a>

## `NationalSpire.AiWireProtocol.Encode(string) — internal string Encode(string context)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildNewsPayload(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, NationalSpire.AiWireProtocol)`](AiService.cs.md#symbol-b632d49f74a4)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`](AiWireProtocol.cs.md#symbol-4c74b3828c4a)；`string.Contains(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Text.Json.Nodes.JsonArray.JsonArray(params System.Text.Json.Nodes.JsonNode?[])`；`System.Text.Json.Nodes.JsonNode.Parse(string, System.Text.Json.Nodes.JsonNodeOptions?, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`；`System.Text.Json.Nodes.JsonObject.Remove(string)`

**字段、属性、事件及方法组引用：** `(string Earlier, string Current).Current`；`(string Earlier, string Current).Earlier`；`NationalSpire.AiWireProtocol._encode`；`NationalSpire.AiWireProtocol._names`；`NationalSpire.AiWireProtocol.Json`；`NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Rewrite(node, _encode)`；返回值紧邻使用处：`ExpressionStatementSyntax: Rewrite(node, _encode);`
- `string.Contains(string, System.StringComparison)`；输入表达式：`readable.Contains(n.Earlier, StringComparison.Ordinal)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: n => readable.Contains(n.Earlier, StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`_names.Where(n => readable.Contains(n.Earlier, StringComparison.Ordinal)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _names.Where(n => readable.Contains(n.Earlier, StringComparison.Ordinal)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`referenced.Select(n => (JsonNode)new JsonObject                  { ["原ID"] = n.Earlier, ["现ID"] = n.Current })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: referenced.Select(n => (JsonNode)new JsonObject                  { ["原ID"] = n.Earlier, ["现ID"] = n.Current }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_names.Where(n => readable.Contains(n.Earlier, StringComparison.Ordinal)).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _names.Where(n => readable.Contains(n.Earlier, StringComparison.Ordinal)).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`referenced.Select(n => (JsonNode)new JsonObject                  { ["原ID"] = n.Earlier, ["现ID"] = n.Current }).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: referenced.Select(n => (JsonNode)new JsonObject                  { ["原ID"] = n.Earlier, ["现ID"] = n.Current }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_names.Where(n => readable.Contains(n.Earlier, StringComparison.Ordinal))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _names.Where(n => readable.Contains(n.Earlier, StringComparison.Ordinal)).Distinct`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`memories.OfType<JsonObject>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var memory in memories.OfType<JsonObject>()) { memory.Remove("Id"); memory.Remove("PostId"); }`
- `System.Text.Json.Nodes.JsonArray.JsonArray(params System.Text.Json.Nodes.JsonNode?[])`；输入表达式：`new JsonArray(referenced.Select(n => (JsonNode)new JsonObject                  { ["原ID"] = n.Earlier, ["现ID"] = n.Current }).ToArray())`；返回值紧邻使用处：`AssignmentExpressionSyntax: node["nameHistory"] = new JsonArray(referenced.Select(n => (JsonNode)new JsonObject                  { ["原ID"] = n.Earlier, ["现ID"] = n.Current }).ToArray())`
- `System.Text.Json.Nodes.JsonNode.Parse(string, System.Text.Json.Nodes.JsonNodeOptions?, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonNode.Parse(context)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonNode.Parse(context)!`
- `System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`node.ToJsonString(Json)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = node.ToJsonString(Json)`
- `System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`node.ToJsonString(Json)`；返回值紧邻使用处：`ReturnStatementSyntax: return node.ToJsonString(Json);`
- `System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`new JsonObject                  { ["原ID"] = n.Earlier, ["现ID"] = n.Current }`；返回值紧邻使用处：`CastExpressionSyntax: (JsonNode)new JsonObject                  { ["原ID"] = n.Earlier, ["现ID"] = n.Current }`
- `System.Text.Json.Nodes.JsonObject.Remove(string)`；输入表达式：`memory.Remove("Id")`；返回值紧邻使用处：`ExpressionStatementSyntax: memory.Remove("Id");`
- `System.Text.Json.Nodes.JsonObject.Remove(string)`；输入表达式：`memory.Remove("PostId")`；返回值紧邻使用处：`ExpressionStatementSyntax: memory.Remove("PostId");`

**赋值（含属性/字段和局部值）：**

- `["现ID"]` = `n.Current`
- `["原ID"]` = `n.Earlier`
- `node["nameHistory"]` = `new JsonArray(referenced.Select(n => (JsonNode)new JsonObject                  { ["原ID"] = n.Earlier, ["现ID"] = n.Current }).ToArray())`

<a id="symbol-1b2e04d42691"></a>

## `NationalSpire.AiWireProtocol.Decode(string, bool, string?) — internal string Decode(string response, bool normalizeFields = true, string? expectedArray = null)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)

**调用：** [`NationalSpire.AiWireProtocol.NormalizeFields(System.Text.Json.Nodes.JsonNode)`](AiWireProtocol.cs.md#symbol-ee9bc80e3996)；[`NationalSpire.AiWireProtocol.ReadBody(string, bool, string?)`](AiWireProtocol.cs.md#symbol-9f5c579e6675)；[`NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`](AiWireProtocol.cs.md#symbol-4c74b3828c4a)；`System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWireProtocol._decode`；`NationalSpire.AiWireProtocol.Json`；`NationalSpire.AiWireProtocol.NormalizeFields(System.Text.Json.Nodes.JsonNode)`；`NationalSpire.AiWireProtocol.ReadBody(string, bool, string?)`；`NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiWireProtocol.NormalizeFields(System.Text.Json.Nodes.JsonNode)`；输入表达式：`NormalizeFields(node)`；返回值紧邻使用处：`ExpressionStatementSyntax: NormalizeFields(node);`
- `NationalSpire.AiWireProtocol.ReadBody(string, bool, string?)`；输入表达式：`ReadBody(response, normalizeFields, expectedArray)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadBody(response, normalizeFields, expectedArray)`
- `NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Rewrite(node, _decode)`；返回值紧邻使用处：`ExpressionStatementSyntax: Rewrite(node, _decode);`
- `System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`node.ToJsonString(Json)`；返回值紧邻使用处：`ReturnStatementSyntax: return node.ToJsonString(Json);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9f5c579e6675"></a>

## `NationalSpire.AiWireProtocol.ReadBody(string, bool, string?) — private static JsonNode ReadBody(string response, bool extract, string? expectedArray)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiWireProtocol.Decode(string, bool, string?)`](AiWireProtocol.cs.md#symbol-1b2e04d42691)

**调用：** [`NationalSpire.AiWireProtocol.HasRows(System.Text.Json.Nodes.JsonNode, string, bool)`](AiWireProtocol.cs.md#symbol-f2beb4ab79a2)；[`NationalSpire.AiWireProtocol.UnwrapLeadingBlocks(string)`](AiWireProtocol.cs.md#symbol-47f257a4fe86)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Stack<T>.Peek()`；`System.Collections.Generic.Stack<T>.Pop()`；`System.Collections.Generic.Stack<T>.Push(T)`；`System.Collections.Generic.Stack<T>.Stack()`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.Nodes.JsonNode.Parse(string, System.Text.Json.Nodes.JsonNodeOptions?, System.Text.Json.JsonDocumentOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWireProtocol.HasRows(System.Text.Json.Nodes.JsonNode, string, bool)`；`NationalSpire.AiWireProtocol.UnwrapLeadingBlocks(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiWireProtocol.HasRows(System.Text.Json.Nodes.JsonNode, string, bool)`；输入表达式：`HasRows(candidate, expectedArray, true)`；返回值紧邻使用处：`ConditionalExpressionSyntax: expectedArray != null ? HasRows(candidate, expectedArray, true)                  : new[] { "posts", "reactions", "slides", "profiles" }.Any(key => HasRows(candidate, key, true))`
- `NationalSpire.AiWireProtocol.HasRows(System.Text.Json.Nodes.JsonNode, string, bool)`；输入表达式：`HasRows(candidate, key, true)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: key => HasRows(candidate, key, true)`
- `NationalSpire.AiWireProtocol.HasRows(System.Text.Json.Nodes.JsonNode, string, bool)`；输入表达式：`HasRows(direct, expectedArray, false)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !HasRows(direct, expectedArray, false)`
- `NationalSpire.AiWireProtocol.UnwrapLeadingBlocks(string)`；输入表达式：`UnwrapLeadingBlocks(response)`；返回值紧邻使用处：`AssignmentExpressionSyntax: response = UnwrapLeadingBlocks(response)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { "posts", "reactions", "slides", "profiles" }.Any(key => HasRows(candidate, key, true))`；返回值紧邻使用处：`ConditionalExpressionSyntax: expectedArray != null ? HasRows(candidate, expectedArray, true)                  : new[] { "posts", "reactions", "slides", "profiles" }.Any(key => HasRows(candidate, key, true))`
- `System.Collections.Generic.Stack<T>.Peek()`；输入表达式：`brackets.Peek()`；返回值紧邻使用处：`BinaryExpressionSyntax: brackets.Peek() != (c == '}' ? '{' : '[')`
- `System.Collections.Generic.Stack<T>.Pop()`；输入表达式：`brackets.Pop()`；返回值紧邻使用处：`ExpressionStatementSyntax: brackets.Pop();`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`brackets.Push(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: brackets.Push(c);`
- `System.Collections.Generic.Stack<T>.Stack()`；输入表达式：`new Stack<char>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Stack<char>()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("模型返回的 JSON 括号不匹配")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("模型返回的 JSON 括号不匹配");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("模型返回的 JSON 片段未完整结束")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("模型返回的 JSON 片段未完整结束");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("模型返回了多份符合要求的 JSON，无法确定最终正文")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("模型返回了多份符合要求的 JSON，无法确定最终正文");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("模型返回内容中没有符合本次请求的完整 JSON 正文")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("模型返回内容中没有符合本次请求的完整 JSON 正文")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("模型正文缺少 " + expectedArray + " 数组")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("模型正文缺少 " + expectedArray + " 数组");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("模型正文需要是 JSON 对象")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("模型正文需要是 JSON 对象");`
- `System.Text.Json.Nodes.JsonNode.Parse(string, System.Text.Json.Nodes.JsonNodeOptions?, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonNode.Parse(response)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonNode.Parse(response)`
- `System.Text.Json.Nodes.JsonNode.Parse(string, System.Text.Json.Nodes.JsonNodeOptions?, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonNode.Parse(response[start..(index + 1)])`；返回值紧邻使用处：`AssignmentExpressionSyntax: candidate = JsonNode.Parse(response[start..(index + 1)])`

**赋值（含属性/字段和局部值）：**

- `candidate` = `JsonNode.Parse(response[start..(index + 1)])`
- `escaped` = `false`
- `escaped` = `true`
- `quoted` = `escaped = false`
- `quoted` = `false`
- `quoted` = `true`
- `response` = `UnwrapLeadingBlocks(response)`
- `selected` = `candidate`
- `start` = `-1`
- `start` = `index`

<a id="symbol-47f257a4fe86"></a>

## `NationalSpire.AiWireProtocol.UnwrapLeadingBlocks(string) — private static string UnwrapLeadingBlocks(string response)`

来源：源码第 107 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiWireProtocol.ReadBody(string, bool, string?)`](AiWireProtocol.cs.md#symbol-9f5c579e6675)

**调用：** `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Trim()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.RegularExpressions.Regex.Escape(string)`；`System.Text.RegularExpressions.Regex.Match(string, string)`；`System.Text.RegularExpressions.Regex.Matches(string, string, System.Text.RegularExpressions.RegexOptions)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", blocks)`；返回值紧邻使用处：`ReturnStatementSyntax: return string.Join("\n", blocks);`
- `string.Trim()`；输入表达式：`response.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = response.Trim()`
- `string.Trim()`；输入表达式：`text[after..].Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text[after..].Trim()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`blocks.Add(text[begin..end])`；返回值紧邻使用处：`ExpressionStatementSyntax: blocks.Add(text[begin..end]);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("模型返回的标签未完整闭合")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("模型返回的标签未完整闭合");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("模型返回的前置说明未完整结束")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("模型返回的前置说明未完整结束");`
- `System.Text.RegularExpressions.Regex.Escape(string)`；输入表达式：`System.Text.RegularExpressions.Regex.Escape(opening.Groups[1].Value)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Text.RegularExpressions.Regex.Escape(opening.Groups[1].Value)`
- `System.Text.RegularExpressions.Regex.Match(string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Match(text, @"\A<([\p{L}_][\p{L}\p{N}_.:-]*)(?:\s+[^<>]*)?>")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Text.RegularExpressions.Regex.Match(text, @"\A<([\p{L}_][\p{L}\p{N}_.:-]*)(?:\s+[^<>]*)?>")`
- `System.Text.RegularExpressions.Regex.Matches(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`System.Text.RegularExpressions.Regex.Matches(text[begin..], @"<(/?)" + name + @"(?:\s+[^<>]*)?>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Text.RegularExpressions.Regex.Matches(text[begin..], @"<(/?)" + name + @"(?:\s+[^<>]*)?>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)`

**赋值（含属性/字段和局部值）：**

- `after` = `-1`
- `after` = `end + 1`
- `after` = `end + boundary.Length`
- `begin` = `1`
- `begin` = `opening.Length`
- `depth` += `boundary.Groups[1].Length == 0 ? 1 : -1`
- `end` = `-1`
- `end` = `begin + boundary.Index`
- `end` = `i`
- `text` = `remainder`

<a id="symbol-f2beb4ab79a2"></a>

## `NationalSpire.AiWireProtocol.HasRows(System.Text.Json.Nodes.JsonNode, string, bool) — private static bool HasRows(JsonNode node, string name, bool requireRows)`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiWireProtocol.ReadBody(string, bool, string?)`](AiWireProtocol.cs.md#symbol-9f5c579e6675)

**调用：** `string.Equals(string?, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.Nodes.JsonNode.AsObject()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Equals(string?, System.StringComparison)`；输入表达式：`p.Key.Equals(name, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Key.Equals(name, StringComparison.OrdinalIgnoreCase)              && p.Value is JsonArray rows`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`node.AsObject().Any(p => p.Key.Equals(name, StringComparison.OrdinalIgnoreCase)              && p.Value is JsonArray rows && (!requireRows || rows.Count > 0))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => node.AsObject().Any(p => p.Key.Equals(name, StringComparison.OrdinalIgnoreCase)              && p.Value is JsonArray rows && (!requireRows || rows.Count > 0))`
- `System.Text.Json.Nodes.JsonNode.AsObject()`；输入表达式：`node.AsObject()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: node.AsObject().Any`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ee9bc80e3996"></a>

## `NationalSpire.AiWireProtocol.NormalizeFields(System.Text.Json.Nodes.JsonNode) — private static void NormalizeFields(JsonNode node)`

来源：源码第 151 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiWireProtocol.Decode(string, bool, string?)`](AiWireProtocol.cs.md#symbol-1b2e04d42691)；[`NationalSpire.AiWireProtocol.NormalizeFields(System.Text.Json.Nodes.JsonNode)`](AiWireProtocol.cs.md#symbol-ee9bc80e3996)

**调用：** [`NationalSpire.AiWireProtocol.NormalizeFields(System.Text.Json.Nodes.JsonNode)`](AiWireProtocol.cs.md#symbol-ee9bc80e3996)；`string.ToLowerInvariant()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.Nodes.JsonObject.ContainsKey(string)`；`System.Text.Json.Nodes.JsonObject.Remove(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWireProtocol.NormalizeFields(System.Text.Json.Nodes.JsonNode)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiWireProtocol.NormalizeFields(System.Text.Json.Nodes.JsonNode)`；输入表达式：`NormalizeFields(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: NormalizeFields(value);`
- `string.ToLowerInvariant()`；输入表达式：`key.ToLowerInvariant()`；返回值紧邻使用处：`SwitchExpressionSyntax: key.ToLowerInvariant() switch                  {                      "profiles" => "profiles", "slides" => "slides", "posts" => "posts", "reactions" => "reactions", "replies" => "replies", "id" => "id", "postid" => "postId",                      "authorid" => "authorId", "parentid" => "parentId", "body" => "body", "title" => "title", _ => key                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`obj.Select(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: obj.Select(p => p.Key).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`obj.Select(p => p.Key).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string key in obj.Select(p => p.Key).ToArray())              {                  string canonical = key.ToLowerInvariant() switch                  {                      "profiles" => "profiles", "slides" => "slides", "posts" => "posts", "reactions" => "reactions", "replies" => "replies", "id" => "id", "postid" => "postId",                      "authorid" => "authorId", "parentid" => "parentId", "body" => "body", "title" => "title", _ => key                  };                  var value = obj[key];                  if (canonical != key)                  {                      if (obj.ContainsKey(canonical)) throw new InvalidDataException("返回字段重复");                      obj.Remove(key); obj[canonical] = value;                  }                  if (value != null) NormalizeFields(value);              }`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("返回字段重复")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("返回字段重复");`
- `System.Text.Json.Nodes.JsonObject.ContainsKey(string)`；输入表达式：`obj.ContainsKey(canonical)`；返回值紧邻使用处：`IfStatementSyntax: if (obj.ContainsKey(canonical)) throw new InvalidDataException("返回字段重复");`
- `System.Text.Json.Nodes.JsonObject.Remove(string)`；输入表达式：`obj.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: obj.Remove(key);`

**赋值（含属性/字段和局部值）：**

- `obj[canonical]` = `value`

<a id="symbol-4c74b3828c4a"></a>

## `NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool) — private static void Rewrite(JsonNode node, Dictionary<string, string> map, bool identifiers = false)`

来源：源码第 171 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiWireProtocol.Decode(string, bool, string?)`](AiWireProtocol.cs.md#symbol-1b2e04d42691)；[`NationalSpire.AiWireProtocol.Encode(string)`](AiWireProtocol.cs.md#symbol-bcdcbacd353a)；[`NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`](AiWireProtocol.cs.md#symbol-4c74b3828c4a)

**调用：** [`NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`](AiWireProtocol.cs.md#symbol-4c74b3828c4a)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Text.Json.Nodes.JsonValue.TryGetValue<T>(out T?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWireProtocol.IdFields`；`NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Rewrite(value, map, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Rewrite(value, map, id);`
- `NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Rewrite(value, map, identifiers)`；返回值紧邻使用处：`ExpressionStatementSyntax: Rewrite(value, map, identifiers);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`map.TryGetValue(raw, out var replacement)`；返回值紧邻使用处：`BinaryExpressionSyntax: id && value is JsonValue text && text.TryGetValue<string>(out var raw) && map.TryGetValue(raw, out var replacement)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`map.TryGetValue(raw, out var replacement)`；返回值紧邻使用处：`BinaryExpressionSyntax: identifiers && value is JsonValue text && text.TryGetValue<string>(out var raw) && map.TryGetValue(raw, out var replacement)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`IdFields.Contains(key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = IdFields.Contains(key)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`obj.Select(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: obj.Select(p => p.Key).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`obj.Select(p => p.Key).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var key in obj.Select(p => p.Key).ToArray())              {                  var value = obj[key]; bool id = IdFields.Contains(key);                  if (id && value is JsonValue text && text.TryGetValue<string>(out var raw) && map.TryGetValue(raw, out var replacement)) obj[key] = replacement;                  else if (value != null) Rewrite(value, map, id);              }`
- `System.Text.Json.Nodes.JsonValue.TryGetValue<T>(out T?)`；输入表达式：`text.TryGetValue<string>(out var raw)`；返回值紧邻使用处：`BinaryExpressionSyntax: id && value is JsonValue text && text.TryGetValue<string>(out var raw)`
- `System.Text.Json.Nodes.JsonValue.TryGetValue<T>(out T?)`；输入表达式：`text.TryGetValue<string>(out var raw)`；返回值紧邻使用处：`BinaryExpressionSyntax: identifiers && value is JsonValue text && text.TryGetValue<string>(out var raw)`

**赋值（含属性/字段和局部值）：**

- `array[i]` = `replacement`
- `obj[key]` = `replacement`
