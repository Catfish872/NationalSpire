# ContentPools.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`E486208F6C0D1D306F15573B71B164397E560D5B67E3FC22B1FB2297BFEC99BF`。来源：[源码](../../ContentPools.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ContentPools`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-5d478310fd36"></a>

## `NationalSpire.ContentPools.Words(string) — internal static string[] Words(string text)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.HumanNames.Rows(string)`](HumanNames.cs.md#symbol-7db9e99023b2)；[`NationalSpire.WorldPeople.WorldPeople()`](ExpandedPeople.cs.md#symbol-e0e51594f12d)

**调用：** `string.Split(char, System.StringSplitOptions)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Split(char, System.StringSplitOptions)`；输入表达式：`text.Split(' ', StringSplitOptions.RemoveEmptyEntries)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => text.Split(' ', StringSplitOptions.RemoveEmptyEntries)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0a02f29bf822"></a>

## `NationalSpire.ContentPools.Append(System.Collections.Generic.Dictionary<string, string[]>, string) — internal static void Append(Dictionary<string, string[]> target, string text)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveCommentary.RefreshCommentary()`](CommentaryRefresh.cs.md#symbol-e65d5ff87a87)；[`NationalSpire.LiveCommentary.ReplaceBank(System.Collections.Generic.Dictionary<string, string[]>, string)`](CommentaryRefresh.cs.md#symbol-bf541bb1ad03)；[`NationalSpire.LiveSpeechComposer.Create()`](LiveSpeechComposer.cs.md#symbol-2d212bce6757)；[`NationalSpire.LiveVoiceCatalog.Create()`](LiveVoiceCatalog.cs.md#symbol-401bebd9f275)；[`NationalSpire.NarrativeText.NarrativeText()`](ExpandedNarrative.cs.md#symbol-871dd311d8d4)；[`NationalSpire.WorldPeople.WorldPeople()`](ExpandedPeople.cs.md#symbol-e0e51594f12d)

**调用：** `string.IndexOf(char)`；`string.Split(char, System.StringSplitOptions)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IndexOf(char)`；输入表达式：`row.IndexOf('=')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = row.IndexOf('=')`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries)`；返回值紧邻使用处：`ArgumentSyntax: row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries)`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`text.Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string row in text.Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))         {             int split = row.IndexOf('=');             string key = row[..split];             target[key] = target.GetValueOrDefault(key, []).Concat(row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries)).Distinct().ToArray();         }`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`target.GetValueOrDefault(key, []).Concat(row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: target.GetValueOrDefault(key, []).Concat(row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`target.GetValueOrDefault(key, []).Concat(row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: target.GetValueOrDefault(key, []).Concat(row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`target.GetValueOrDefault(key, []).Concat(row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries)).Distinct().ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: target[key] = target.GetValueOrDefault(key, []).Concat(row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries)).Distinct().ToArray()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`target.GetValueOrDefault(key, [])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: target.GetValueOrDefault(key, []).Concat`

**赋值（含属性/字段和局部值）：**

- `target[key]` = `target.GetValueOrDefault(key, []).Concat(row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries)).Distinct().ToArray()`
