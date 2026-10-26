# PercentageAllocation.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`94A88CA896FA6019389B3080E2ED562EEDFB8907C507C221A543A2E111CA44A7`。来源：[源码](../../PercentageAllocation.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PercentageAllocation`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-deabc46c0872"></a>

## `NationalSpire.PercentageAllocation.Normalize(System.Collections.Generic.IEnumerable<double>) — public static double[] Normalize(IEnumerable<double> weights)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PercentageAllocation.Adjust(System.Collections.Generic.IReadOnlyList<double>, int, double, System.Collections.Generic.IReadOnlyList<bool>?)`](PercentageAllocation.cs.md#symbol-1fb1ed9d9944)；[`Weights()`](NpcGenerationScreen.cs.md#symbol-3c35095e983c)

**调用：** `System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Floor(double)`；`double.IsFinite(double)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("比例应为有效的非负数。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("比例应为有效的非负数。");`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`values.Any(x => !double.IsFinite(x) || x < 0)`；返回值紧邻使用处：`IfStatementSyntax: if (values.Any(x => !double.IsFinite(x) || x < 0)) throw new ArgumentException("比例应为有效的非负数。");`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Enumerable.Range(0, units.Length).OrderByDescending(i => raw[i] - units[i])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, units.Length).OrderByDescending(i => raw[i] - units[i]).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`raw.Select(x => (int)Math.Floor(x))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: raw.Select(x => (int)Math.Floor(x)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`units.Select(x => x / 10d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: units.Select(x => x / 10d).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`values.Select(x => total > 0 ? x / total * 1000 : 1000d / values.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: values.Select(x => total > 0 ? x / total * 1000 : 1000d / values.Length).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`Enumerable.Range(0, units.Length).OrderByDescending(i => raw[i] - units[i]).Take(1000 - units.Sum())`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (int i in Enumerable.Range(0, units.Length).OrderByDescending(i => raw[i] - units[i]).Take(1000 - units.Sum())) units[i]++;`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`raw.Select(x => (int)Math.Floor(x)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = raw.Select(x => (int)Math.Floor(x)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`units.Select(x => x / 10d).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return units.Select(x => x / 10d).ToArray();`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`values.Select(x => total > 0 ? x / total * 1000 : 1000d / values.Length).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = values.Select(x => total > 0 ? x / total * 1000 : 1000d / values.Length).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`weights.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = weights.ToArray()`
- `System.Collections.Generic.IEnumerable<double>.Sum()`；输入表达式：`values.Sum()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = values.Sum()`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`units.Sum()`；返回值紧邻使用处：`BinaryExpressionSyntax: 1000 - units.Sum()`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, units.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, units.Length).OrderByDescending`
- `System.Math.Floor(double)`；输入表达式：`Math.Floor(x)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Floor(x)`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(x)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !double.IsFinite(x)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1fb1ed9d9944"></a>

## `NationalSpire.PercentageAllocation.Adjust(System.Collections.Generic.IReadOnlyList<double>, int, double, System.Collections.Generic.IReadOnlyList<bool>?) — public static double[] Adjust(IReadOnlyList<double> percentages, int edited, double value, IReadOnlyList<bool>? locked = null)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Weights()`](NpcGenerationScreen.cs.md#symbol-3c35095e983c)

**调用：** [`NationalSpire.PercentageAllocation.Normalize(System.Collections.Generic.IEnumerable<double>)`](PercentageAllocation.cs.md#symbol-deabc46c0872)；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Abs(int)`；`System.Math.Clamp(double, double, double)`；`System.Math.Min(int, int)`；`System.Math.Round(double)`；`System.Math.Sign(int)`；`double.IsFinite(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.PercentageAllocation.Normalize(System.Collections.Generic.IEnumerable<double>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PercentageAllocation.Normalize(System.Collections.Generic.IEnumerable<double>)`；输入表达式：`Normalize(percentages)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Normalize(percentages).Select`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请选择有效的比例。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请选择有效的比例。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("锁定状态应与比例项目对应。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("锁定状态应与比例项目对应。");`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Normalize(percentages).Select(x => (int)Math.Round(x * 10))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Normalize(percentages).Select(x => (int)Math.Round(x * 10)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`units.Select(x => x / 10d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: units.Select(x => x / 10d).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`available.Sum(i => units[i])`；返回值紧邻使用处：`BinaryExpressionSyntax: units[edited] + available.Sum(i => units[i])`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0, units.Length).Where(i => i != edited && locked?[i] != true).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Enumerable.Range(0, units.Length).Where(i => i != edited && locked?[i] != true).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Normalize(percentages).Select(x => (int)Math.Round(x * 10)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Normalize(percentages).Select(x => (int)Math.Round(x * 10)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`available.Where(i => sign > 0 ? units[i] < 1000 : units[i] > 0).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = available.Where(i => sign > 0 ? units[i] < 1000 : units[i] > 0).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`units.Select(x => x / 10d).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return units.Select(x => x / 10d).ToArray();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Enumerable.Range(0, units.Length).Where(i => i != edited && locked?[i] != true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, units.Length).Where(i => i != edited && locked?[i] != true).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`available.Where(i => sign > 0 ? units[i] < 1000 : units[i] > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(i => sign > 0 ? units[i] < 1000 : units[i] > 0).ToArray`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`units.Sum()`；返回值紧邻使用处：`BinaryExpressionSyntax: 1000 - units.Sum()`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, units.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, units.Length).Where`
- `System.Math.Abs(int)`；输入表达式：`Math.Abs(delta)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Abs(delta)`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(value, 0, capacity / 10d)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Clamp(value, 0, capacity / 10d) * 10`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(share + (n < extra ? 1 : 0), sign > 0 ? 1000 - units[i] : units[i])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(share + (n < extra ? 1 : 0), sign > 0 ? 1000 - units[i] : units[i])`
- `System.Math.Round(double)`；输入表达式：`Math.Round(Math.Clamp(value, 0, capacity / 10d) * 10)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(Math.Clamp(value, 0, capacity / 10d) * 10)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(x * 10)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(x * 10)`
- `System.Math.Sign(int)`；输入表达式：`Math.Sign(delta)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Sign(delta)`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(value)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !double.IsFinite(value)`

**赋值（含属性/字段和局部值）：**

- `delta` -= `sign * change`
- `units[edited]` = `(int)Math.Round(Math.Clamp(value, 0, capacity / 10d) * 10)`
- `units[i]` += `sign * change`
