# ExtensionData.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`CA949CDA4082250C23A468276AB6629726C7402EBCD8B0B3BAED0475545AB67A`。来源：[源码](../../ExtensionData.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ExtensibleData`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-1fa8341fd359"></a>

## `NationalSpire.ExtensibleData.Extra — public Dictionary<string, object?> Extra`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-10d93305a071"></a>

## `NationalSpire.ExtensibleData.ExtensionValue<T>(string, System.Func<T>) — public T ExtensionValue<T>(string key, Func<T> create)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Text.Json.JsonElement.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ExtensibleData.Extra`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Extra.TryGetValue(key, out var raw)`；返回值紧邻使用处：`IfStatementSyntax: if (Extra.TryGetValue(key, out var raw))          {              if (raw is T value) return value;              if (raw is JsonElement json && json.ValueKind != JsonValueKind.Null)              {                  T? decoded = json.Deserialize<T>();                  if (decoded != null) { Extra[key] = decoded; return decoded; }              }          }`
- `System.Func<TResult>.Invoke()`；输入表达式：`create()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = create()`
- `System.Text.Json.JsonElement.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`json.Deserialize<T>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = json.Deserialize<T>()`

**赋值（含属性/字段和局部值）：**

- `Extra[key]` = `decoded`
- `Extra[key]` = `result`

<a id="symbol-603f379fa83a"></a>

## `NationalSpire.ExtensibleData.OnDeserialized() — public void OnDeserialized()`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Text.Json.JsonElement.GetString()`

**字段、属性、事件及方法组引用：** `NationalSpire.ExtensibleData.Extra`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Extra.Keys.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string key in Extra.Keys.ToArray())              if (Extra[key] is JsonElement json)                  Extra[key] = json.ValueKind switch                  {                      JsonValueKind.String => json.GetString(), JsonValueKind.True => true,                      JsonValueKind.False => false, JsonValueKind.Null => null, _ => json                  };`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`json.GetString()`；返回值紧邻使用处：`SwitchExpressionArmSyntax: JsonValueKind.String => json.GetString()`

**赋值（含属性/字段和局部值）：**

- `Extra[key]` = `json.ValueKind switch                  {                      JsonValueKind.String => json.GetString(), JsonValueKind.True => true,                      JsonValueKind.False => false, JsonValueKind.Null => null, _ => json                  }`

<a id="symbol-e92ffbabd9a6"></a>

## `NationalSpire.ExtensibleData.CopyExtra() — public Dictionary<string, object?> CopyExtra()`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneMemories.CopyLine(NationalSpire.DateSceneLine)`](DateSceneMemories.cs.md#symbol-0929ad334607)；[`NationalSpire.DateScenes.DisplayParts(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-2d444f7f549e)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Text.Json.JsonSerializer.SerializeToElement<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ExtensibleData.Extra`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`Extra.ToDictionary(p => p.Key,          p => p.Value is null or string or ValueType ? p.Value : (object?)JsonSerializer.SerializeToElement(p.Value))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Extra.ToDictionary(p => p.Key,          p => p.Value is null or string or ValueType ? p.Value : (object?)JsonSerializer.SerializeToElement(p.Value))`
- `System.Text.Json.JsonSerializer.SerializeToElement<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.SerializeToElement(p.Value)`；返回值紧邻使用处：`CastExpressionSyntax: (object?)JsonSerializer.SerializeToElement(p.Value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1152bf46669b"></a>

## `NationalSpire.ExtensibleData.SameExtra(NationalSpire.ExtensibleData, NationalSpire.ExtensibleData) — public static bool SameExtra(ExtensibleData a, ExtensibleData b)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneMemories.SameLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine)`](DateSceneMemories.cs.md#symbol-f89ef1794aeb)

**调用：** `object.Equals(object?, object?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.JsonElement.DeepEquals(System.Text.Json.JsonElement, System.Text.Json.JsonElement)`；`System.Text.Json.JsonSerializer.SerializeToElement<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ExtensibleData.Extra`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.Equals(object?, object?)`；输入表达式：`Equals(p.Value, value)`；返回值紧邻使用处：`BinaryExpressionSyntax: Equals(p.Value, value) || JsonElement.DeepEquals(JsonSerializer.SerializeToElement(p.Value), JsonSerializer.SerializeToElement(value))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`b.Extra.TryGetValue(p.Key, out var value)`；返回值紧邻使用处：`BinaryExpressionSyntax: b.Extra.TryGetValue(p.Key, out var value)              && (Equals(p.Value, value) || JsonElement.DeepEquals(JsonSerializer.SerializeToElement(p.Value), JsonSerializer.SerializeToElement(value)))`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`a.Extra.All(p => b.Extra.TryGetValue(p.Key, out var value)              && (Equals(p.Value, value) || JsonElement.DeepEquals(JsonSerializer.SerializeToElement(p.Value), JsonSerializer.SerializeToElement(value))))`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Extra.Count == b.Extra.Count          && a.Extra.All(p => b.Extra.TryGetValue(p.Key, out var value)              && (Equals(p.Value, value) || JsonElement.DeepEquals(JsonSerializer.SerializeToElement(p.Value), JsonSerializer.SerializeToElement(value))))`
- `System.Text.Json.JsonElement.DeepEquals(System.Text.Json.JsonElement, System.Text.Json.JsonElement)`；输入表达式：`JsonElement.DeepEquals(JsonSerializer.SerializeToElement(p.Value), JsonSerializer.SerializeToElement(value))`；返回值紧邻使用处：`BinaryExpressionSyntax: Equals(p.Value, value) || JsonElement.DeepEquals(JsonSerializer.SerializeToElement(p.Value), JsonSerializer.SerializeToElement(value))`
- `System.Text.Json.JsonSerializer.SerializeToElement<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.SerializeToElement(p.Value)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.SerializeToElement(p.Value)`
- `System.Text.Json.JsonSerializer.SerializeToElement<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.SerializeToElement(value)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.SerializeToElement(value)`

**赋值（含属性/字段和局部值）：**
