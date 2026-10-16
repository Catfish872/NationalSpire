# ChatHistoryPage.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C111F6564E8EAA6C6308CBC04CBEC441839F1F90AB478AD6F9D5AE294454F25E`。来源：[源码](../../ChatHistoryPage.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ChatHistoryPage<T>`。

字段、事件及初始值（源码原样）：

```csharp
private IReadOnlyList<T>? _source;
private int _sourceCount = -1;
private long _revision = -1;
private List<T> _turns = [];
private bool _initial = true;
```

<a id="symbol-08feda303a6a"></a>

## `NationalSpire.ChatHistoryPage<T>.Size — public int Size`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-05d953af69e6"></a>

## `NationalSpire.ChatHistoryPage<T>.Page — public int Page`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7575769ebaa8"></a>

## `NationalSpire.ChatHistoryPage<T>.Count — public int Count`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ChatHistoryPage<T>._turns`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-92e91ba48b2b"></a>

## `NationalSpire.ChatHistoryPage<T>.Pages — public int Pages`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatHistoryPage<T>.Count`；`NationalSpire.ChatHistoryPage<T>.Size`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, (Count + Size - 1) / Size)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Math.Max(1, (Count + Size - 1) / Size)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ea1f76fda01b"></a>

## `NationalSpire.ChatHistoryPage<T>.IsLatest — public bool IsLatest`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ChatHistoryPage<T>.Page`；`NationalSpire.ChatHistoryPage<T>.Pages`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0f7bd342c1ea"></a>

## `NationalSpire.ChatHistoryPage<T>.Visible — public IEnumerable<T> Visible`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatHistoryPage<T>._turns`；`NationalSpire.ChatHistoryPage<T>.Page`；`NationalSpire.ChatHistoryPage<T>.Size`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`_turns.Skip(Page * Size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _turns.Skip(Page * Size).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`_turns.Skip(Page * Size).Take(Size)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _turns.Skip(Page * Size).Take(Size)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-378fec03d162"></a>

## `NationalSpire.ChatHistoryPage<T>.Next — public T? Next`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatHistoryPage<T>._turns`；`NationalSpire.ChatHistoryPage<T>.Page`；`NationalSpire.ChatHistoryPage<T>.Size`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`_turns.Skip((Page + 1) * Size).FirstOrDefault()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _turns.Skip((Page + 1) * Size).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`_turns.Skip((Page + 1) * Size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _turns.Skip((Page + 1) * Size).FirstOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e836f7b91e73"></a>

## `NationalSpire.ChatHistoryPage<T>.Reset(int) — public void Reset(int size)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.ResetChatPage()`](ChatHistoryScreen.cs.md#symbol-0a8a3b0ae98b)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ChatHistoryPage<T>._initial`；`NationalSpire.ChatHistoryPage<T>._revision`；`NationalSpire.ChatHistoryPage<T>._source`；`NationalSpire.ChatHistoryPage<T>._sourceCount`；`NationalSpire.ChatHistoryPage<T>._turns`；`NationalSpire.ChatHistoryPage<T>.Page`；`NationalSpire.ChatHistoryPage<T>.Size`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_initial` = `true`
- `_revision` = `-1`
- `_source` = `null`
- `_sourceCount` = `-1`
- `_turns` = `[]`
- `Page` = `0`
- `Size` = `size`

<a id="symbol-b8e49a1a30f0"></a>

## `NationalSpire.ChatHistoryPage<T>.Bind(System.Collections.Generic.IReadOnlyList<T>, long, System.Func<T, bool>, bool) — public bool Bind(IReadOnlyList<T> source, long revision, Func<T, bool> visible, bool follow)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BindChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-e22063fef4cb)

**调用：** [`NationalSpire.ChatHistoryPage<T>.Latest()`](ChatHistoryPage.cs.md#symbol-d95554cbf6e7)；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatHistoryPage<T>._initial`；`NationalSpire.ChatHistoryPage<T>._revision`；`NationalSpire.ChatHistoryPage<T>._source`；`NationalSpire.ChatHistoryPage<T>._sourceCount`；`NationalSpire.ChatHistoryPage<T>._turns`；`NationalSpire.ChatHistoryPage<T>.IsLatest`；`NationalSpire.ChatHistoryPage<T>.Latest()`；`NationalSpire.ChatHistoryPage<T>.Page`；`NationalSpire.ChatHistoryPage<T>.Pages`；`NationalSpire.ChatHistoryPage<T>.Size`；`NationalSpire.ChatHistoryPage<T>.Visible`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatHistoryPage<T>.Latest()`；输入表达式：`Latest()`；返回值紧邻使用处：`ExpressionStatementSyntax: Latest();`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(_source, source)`；返回值紧邻使用处：`BinaryExpressionSyntax: ReferenceEquals(_source, source) && _sourceCount == source.Count`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`Visible.Select(id).FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: Visible.Select(id).FirstOrDefault() ?? ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Visible.Select(id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Visible.Select(id).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`source.Where(visible).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _turns = source.Where(visible).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`source.Where(visible)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.Where(visible).ToList`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`_turns.FindIndex(t => id(t) == anchor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _turns.FindIndex(t => id(t) == anchor)`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`id(t)`；返回值紧邻使用处：`BinaryExpressionSyntax: id(t) == anchor`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(Page, Pages - 1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: index >= 0 ? index / Size : Math.Min(Page, Pages - 1)`

**赋值（含属性/字段和局部值）：**

- `_initial` = `false`
- `_revision` = `revision`
- `_source` = `source`
- `_sourceCount` = `source.Count`
- `_turns` = `source.Where(visible).ToList()`
- `Page` = `index >= 0 ? index / Size : Math.Min(Page, Pages - 1)`

<a id="symbol-27c362fe5d02"></a>

## `NationalSpire.ChatHistoryPage<T>.Move(int) — public void Move(int page)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChangeChatPage(int)`](ChatHistoryScreen.cs.md#symbol-0e399328f32b)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.ChatHistoryPage<T>.Resize(int)`](ChatHistoryPage.cs.md#symbol-03212ab16f78)

**调用：** `System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatHistoryPage<T>.Page`；`NationalSpire.ChatHistoryPage<T>.Pages`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(page, 0, Pages - 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Page = Math.Clamp(page, 0, Pages - 1)`

**赋值（含属性/字段和局部值）：**

- `Page` = `Math.Clamp(page, 0, Pages - 1)`

<a id="symbol-d95554cbf6e7"></a>

## `NationalSpire.ChatHistoryPage<T>.Latest() — public void Latest()`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LatestChatPage()`](ChatHistoryScreen.cs.md#symbol-566a2e34c9dd)；[`NationalSpire.ChatHistoryPage<T>.Bind(System.Collections.Generic.IReadOnlyList<T>, long, System.Func<T, bool>, bool)`](ChatHistoryPage.cs.md#symbol-b8e49a1a30f0)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ChatHistoryPage<T>.Page`；`NationalSpire.ChatHistoryPage<T>.Pages`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `Page` = `Pages - 1`

<a id="symbol-03212ab16f78"></a>

## `NationalSpire.ChatHistoryPage<T>.Resize(int) — public void Resize(int size)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildChatPagination(Godot.HBoxContainer)`](ChatHistoryScreen.cs.md#symbol-28d387d79595)

**调用：** [`NationalSpire.ChatHistoryPage<T>.Move(int)`](ChatHistoryPage.cs.md#symbol-27c362fe5d02)

**字段、属性、事件及方法组引用：** `NationalSpire.ChatHistoryPage<T>.Move(int)`；`NationalSpire.ChatHistoryPage<T>.Page`；`NationalSpire.ChatHistoryPage<T>.Size`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatHistoryPage<T>.Move(int)`；输入表达式：`Move(first / Size)`；返回值紧邻使用处：`ExpressionStatementSyntax: Move(first / Size);`

**赋值（含属性/字段和局部值）：**

- `Size` = `size`
