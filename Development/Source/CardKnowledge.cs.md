# CardKnowledge.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`083D4787AB867B3A2FD2AC0923C43452BD58E68DFC1A2056631B8D81D0E94DF4`。来源：[源码](../../CardKnowledge.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CardReference`、`NationalSpire.CardKnowledge`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly object Gate = new();
private static string? _version;
private static Dictionary<char, CardReference[]> _index = [];
```

<a id="symbol-ae0e19a353f6"></a>

## `NationalSpire.CardKnowledge.Source — public static Func<IEnumerable<CardReference>> Source`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-597cefafc26b"></a>

## `NationalSpire.CardKnowledge.SourceVersion — public static Func<string> SourceVersion`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b76dcbfb8f66"></a>

## `NationalSpire.CardKnowledge.Find(string) — public static string Find(string text)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)

**调用：** `char.ToUpperInvariant(char)`；`string?.AsSpan(int)`；`string.IsNullOrWhiteSpace(string?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.ReadOnlySpan<char>.StartsWith(System.ReadOnlySpan<char>, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.CardKnowledge._index`；`NationalSpire.CardKnowledge._version`；`NationalSpire.CardKnowledge.Gate`；`NationalSpire.CardKnowledge.Source`；`NationalSpire.CardKnowledge.SourceVersion`；`NationalSpire.CardReference.Description`；`NationalSpire.CardReference.Id`；`NationalSpire.CardReference.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.ToUpperInvariant(char)`；输入表达式：`char.ToUpperInvariant(c.Name[0])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => char.ToUpperInvariant(c.Name[0])`
- `char.ToUpperInvariant(char)`；输入表达式：`char.ToUpperInvariant(text[i])`；返回值紧邻使用处：`ArgumentSyntax: char.ToUpperInvariant(text[i])`
- `string?.AsSpan(int)`；输入表达式：`text.AsSpan(i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AsSpan(i).StartsWith`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(text)) return "";`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", found.Values.Select(c => c.Description))`；返回值紧邻使用处：`BinaryExpressionSyntax: "卡牌参考资料\n以下资料由卡名匹配自动补充。请结合上下文，只有确实在谈对应卡牌时才参考其效果；日常用词按原意理解，顺着当前话题自然回应。\n" + string.Join("\n", found.Values.Select(c => c.Description))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, CardReference>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, CardReference>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`found.TryAdd(card.Id, card)`；返回值紧邻使用处：`ExpressionStatementSyntax: found.TryAdd(card.Id, card);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`index.TryGetValue(char.ToUpperInvariant(text[i]), out var candidates)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !index.TryGetValue(char.ToUpperInvariant(text[i]), out var candidates)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Source().Where(c => c.Name.Length > 0).GroupBy(c => char.ToUpperInvariant(c.Name[0]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Source().Where(c => c.Name.Length > 0).GroupBy(c => char.ToUpperInvariant(c.Name[0]))                     .ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`g.OrderByDescending(c => c.Name.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.OrderByDescending(c => c.Name.Length).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`found.Values.Select(c => c.Description)`；返回值紧邻使用处：`ArgumentSyntax: found.Values.Select(c => c.Description)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`g.OrderByDescending(c => c.Name.Length).ThenBy(c => c.Id, StringComparer.Ordinal).ToArray()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.OrderByDescending(c => c.Name.Length).ThenBy(c => c.Id, StringComparer.Ordinal).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`Source().Where(c => c.Name.Length > 0).GroupBy(c => char.ToUpperInvariant(c.Name[0]))                     .ToDictionary(g => g.Key, g => g.OrderByDescending(c => c.Name.Length).ThenBy(c => c.Id, StringComparer.Ordinal).ToArray())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _index = Source().Where(c => c.Name.Length > 0).GroupBy(c => char.ToUpperInvariant(c.Name[0]))                     .ToDictionary(g => g.Key, g => g.OrderByDescending(c => c.Name.Length).ThenBy(c => c.Id, StringComparer.Ordinal).ToArray())`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Source().Where(c => c.Name.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Source().Where(c => c.Name.Length > 0).GroupBy`
- `System.Func<TResult>.Invoke()`；输入表达式：`Source()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Source().Where`
- `System.Func<TResult>.Invoke()`；输入表达式：`SourceVersion()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SourceVersion()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`g.OrderByDescending(c => c.Name.Length).ThenBy(c => c.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.OrderByDescending(c => c.Name.Length).ThenBy(c => c.Id, StringComparer.Ordinal).ToArray`
- `System.ReadOnlySpan<char>.StartsWith(System.ReadOnlySpan<char>, System.StringComparison)`；输入表达式：`text.AsSpan(i).StartsWith(card.Name, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: card.Name.Length >= longest && text.AsSpan(i).StartsWith(card.Name, StringComparison.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**

- `_index` = `Source().Where(c => c.Name.Length > 0).GroupBy(c => char.ToUpperInvariant(c.Name[0]))                     .ToDictionary(g => g.Key, g => g.OrderByDescending(c => c.Name.Length).ThenBy(c => c.Id, StringComparer.Ordinal).ToArray())`
- `_version` = `version`
- `i` += `longest - 1`
- `index` = `_index`
- `longest` = `card.Name.Length`
