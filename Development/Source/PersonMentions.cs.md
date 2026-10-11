# PersonMentions.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`CBE666E2165AD43E441A7586C96007B2988A357C1DABAEB24D0E5289D95F4003`。来源：[源码](../../PersonMentions.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PersonMentions`、`NationalSpire.PersonMentions.Match`、`NationalSpire.PersonMentions.Branch`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Branch _root = new();
```

<a id="symbol-fd8fe0b5f338"></a>

## `NationalSpire.PersonMentions.Branch.Children — public Dictionary<char, Branch> Children`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1dbce4a10241"></a>

## `NationalSpire.PersonMentions.Branch.People — public HashSet<string> People`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-53fac6a2c838"></a>

## `NationalSpire.PersonMentions.PersonMentions(System.Collections.Generic.IEnumerable<(string Id, string Name)>) — public PersonMentions(IEnumerable<(string Id, string Name)> names)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`](MentionScreen.cs.md#symbol-2764c9b1b0cd)

**调用：** `char.ToUpperInvariant(char)`；`NationalSpire.PersonMentions.Branch.Branch()`；`string.Trim()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.PersonMentions._root`；`NationalSpire.PersonMentions.Branch.Children`；`NationalSpire.PersonMentions.Branch.People`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.ToUpperInvariant(char)`；输入表达式：`char.ToUpperInvariant(raw)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = char.ToUpperInvariant(raw)`
- `NationalSpire.PersonMentions.Branch.Branch()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: child = new()`
- `string.Trim()`；输入表达式：`name.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: name.Trim().Length`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`node.Children.TryGetValue(c, out var child)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !node.Children.TryGetValue(c, out var child)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`node.People.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: node.People.Add(id);`

**赋值（含属性/字段和局部值）：**

- `child` = `new()`
- `node.Children[c]` = `child = new()`
- `node` = `child`

<a id="symbol-f13ab45ad1a5"></a>

## `NationalSpire.PersonMentions.Latin(char) — private static bool Latin(char c)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PersonMentions.Find(string, System.Collections.Generic.IEnumerable<string>?)`](PersonMentions.cs.md#symbol-c1807cb3a9db)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c1807cb3a9db"></a>

## `NationalSpire.PersonMentions.Find(string, System.Collections.Generic.IEnumerable<string>?) — public List<Match> Find(string text, IEnumerable<string>? related = null)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`](MentionScreen.cs.md#symbol-2764c9b1b0cd)

**调用：** [`NationalSpire.PersonMentions.Latin(char)`](PersonMentions.cs.md#symbol-f13ab45ad1a5)；`char.ToUpperInvariant(char)`；`NationalSpire.PersonMentions.Match.Match(int, int, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.PersonMentions._root`；`NationalSpire.PersonMentions.Branch.Children`；`NationalSpire.PersonMentions.Branch.People`；`NationalSpire.PersonMentions.Latin(char)`；`NationalSpire.PersonMentions.Match.Length`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.ToUpperInvariant(char)`；输入表达式：`char.ToUpperInvariant(text[end])`；返回值紧邻使用处：`ArgumentSyntax: char.ToUpperInvariant(text[end])`
- `NationalSpire.PersonMentions.Latin(char)`；输入表达式：`Latin(text[end + 1])`；返回值紧邻使用处：`BinaryExpressionSyntax: Latin(text[end]) && end + 1 < text.Length && Latin(text[end + 1])`
- `NationalSpire.PersonMentions.Latin(char)`；输入表达式：`Latin(text[end])`；返回值紧邻使用处：`BinaryExpressionSyntax: Latin(text[end]) && end + 1 < text.Length`
- `NationalSpire.PersonMentions.Latin(char)`；输入表达式：`Latin(text[start - 1])`；返回值紧邻使用处：`BinaryExpressionSyntax: Latin(text[start]) && start > 0 && Latin(text[start - 1])`
- `NationalSpire.PersonMentions.Latin(char)`；输入表达式：`Latin(text[start])`；返回值紧邻使用处：`BinaryExpressionSyntax: Latin(text[start]) && start > 0`
- `NationalSpire.PersonMentions.Match.Match(int, int, string)`；输入表达式：`new(start, end - start + 1, candidates[0])`；返回值紧邻使用处：`ConditionalExpressionSyntax: candidates.Count == 1 ? new(start, end - start + 1, candidates[0]) : null`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`node.Children.TryGetValue(char.ToUpperInvariant(text[end]), out node)`；返回值紧邻使用处：`BinaryExpressionSyntax: end < text.Length && node.Children.TryGetValue(char.ToUpperInvariant(text[end]), out node)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`.ToHashSet()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: related?.ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`node.People.ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: node.People.Count == 1 ? node.People.ToList() : node.People.Where(context.Contains).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`node.People.Where(context.Contains).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: node.People.Count == 1 ? node.People.ToList() : node.People.Where(context.Contains).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`node.People.Where(context.Contains)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: node.People.Where(context.Contains).ToList`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(best)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(best);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Match>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Match>()`

**赋值（含属性/字段和局部值）：**

- `best` = `candidates.Count == 1 ? new(start, end - start + 1, candidates[0]) : null`
- `start` += `best.Length - 1`
