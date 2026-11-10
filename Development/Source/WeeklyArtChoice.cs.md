# WeeklyArtChoice.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0025F1E1DAFA079E4FD05D1E73A0E41ABC39B80FF6CBD4CACB95DB2538E26473`。来源：[源码](../../WeeklyArtChoice.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.WeeklyArtChoice`、`NationalSpire.WeeklyArtChoice.Card`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-f72366311c26"></a>

## `NationalSpire.WeeklyArtChoice.Order(System.Collections.Generic.IEnumerable<NationalSpire.WeeklyArtChoice.Card>, int, string, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<string>) — public static IEnumerable<string> Order(IEnumerable<Card> cards, int importance, string seed, IEnumerable<string> recent, IEnumerable<string> sameIssue)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`](AvatarAssets.cs.md#symbol-92f1e0aef1b2)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.WeeklyArtChoice.Card.Id`；`NationalSpire.WeeklyArtChoice.Card.Rarity`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(seed + ":" + c.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => CareerEngine.StableHash(seed + ":" + c.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`current.Contains(c.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => current.Contains(c.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`old.Contains(c.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => old.Contains(c.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.DistinctBy(c => c.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.DistinctBy(c => c.Id).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy(c => current.Contains(c.Id)).ThenBy(c => old.Contains(c.Id))             .ThenBy(c => CareerEngine.StableHash(seed + ":" + c.Id)).ThenBy(c => c.Id, StringComparer.Ordinal).Select(c => c.Id)`；返回值紧邻使用处：`ReturnStatementSyntax: return cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy(c => current.Contains(c.Id)).ThenBy(c => old.Contains(c.Id))             .ThenBy(c => CareerEngine.StableHash(seed + ":" + c.Id)).ThenBy(c => c.Id, StringComparer.Ordinal).Select(c => c.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`recent.ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = recent.ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`sameIssue.ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = sameIssue.ToHashSet()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy(c => current.Contains(c.Id)).ThenBy(c => old.Contains(c.Id))             .ThenBy(c => CareerEngine.StableHash(seed + ":" + c.Id)).ThenBy(c => c.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy(c => current.Contains(c.Id)).ThenBy(c => old.Contains(c.Id))             .ThenBy(c => CareerEngine.StableHash(seed + ":" + c.Id)).ThenBy(c => c.Id, StringComparer.Ordinal).Select`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy(c => current.Contains(c.Id)).ThenBy(c => old.Contains(c.Id))             .ThenBy(c => CareerEngine.StableHash(seed + ":" + c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy(c => current.Contains(c.Id)).ThenBy(c => old.Contains(c.Id))             .ThenBy(c => CareerEngine.StableHash(seed + ":" + c.Id)).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy(c => current.Contains(c.Id)).ThenBy(c => old.Contains(c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy(c => current.Contains(c.Id)).ThenBy(c => old.Contains(c.Id))             .ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy(c => current.Contains(c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)             .ThenBy(c => current.Contains(c.Id)).ThenBy`

**赋值（含属性/字段和局部值）：**
