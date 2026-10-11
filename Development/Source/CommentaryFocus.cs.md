# CommentaryFocus.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B94E2037291991345302D2936F80BE666ED066F3767862B52D0F66575224C5F8`。来源：[源码](../../CommentaryFocus.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveCommentary`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-63c4d695beeb"></a>

## `NationalSpire.LiveCommentary.FocusHistory(NationalSpire.BroadcastMemory, string) — private static List<string> FocusHistory(BroadcastMemory memory, string category)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveCommentary.ChooseFocus(NationalSpire.BroadcastMemory, string, System.Collections.Generic.IEnumerable<string>, string, System.Func<string, string>)`](CommentaryFocus.cs.md#symbol-780e8bcd69dc)；[`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`](LiveMoments.cs.md#symbol-d358a4a6cc39)；[`NationalSpire.LiveCommentary.RememberFocus(NationalSpire.BroadcastMemory, string, string)`](CommentaryFocus.cs.md#symbol-8c5e2b08bbdb)；[`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.SharedPhrases`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`memory.SharedPhrases.GetValueOrDefault(key, [])`；返回值紧邻使用处：`ReturnStatementSyntax: return memory.SharedPhrases.GetValueOrDefault(key, []);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8c5e2b08bbdb"></a>

## `NationalSpire.LiveCommentary.RememberFocus(NationalSpire.BroadcastMemory, string, string) — private static void RememberFocus(BroadcastMemory memory, string category, string focus)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveCommentary.PlayerVictory(NationalSpire.BroadcastMemory, bool, double, int, int, string, string, string)`](LiveMoments.cs.md#symbol-44f4d20ad966)；[`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)

**调用：** [`NationalSpire.LiveCommentary.FocusHistory(NationalSpire.BroadcastMemory, string)`](CommentaryFocus.cs.md#symbol-63c4d695beeb)；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveRange(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.SharedPhrases`；`NationalSpire.LiveCommentary.FocusHistory(NationalSpire.BroadcastMemory, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveCommentary.FocusHistory(NationalSpire.BroadcastMemory, string)`；输入表达式：`FocusHistory(memory, category)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FocusHistory(memory, category)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`values.Add(focus)`；返回值紧邻使用处：`ExpressionStatementSyntax: values.Add(focus);`
- `System.Collections.Generic.List<T>.RemoveRange(int, int)`；输入表达式：`values.RemoveRange(0, values.Count - 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: values.RemoveRange(0, values.Count - 24);`

**赋值（含属性/字段和局部值）：**

- `memory.SharedPhrases["$focus:" + category]` = `values`

<a id="symbol-780e8bcd69dc"></a>

## `NationalSpire.LiveCommentary.ChooseFocus(NationalSpire.BroadcastMemory, string, System.Collections.Generic.IEnumerable<string>, string, System.Func<string, string>) — private static string? ChooseFocus(BroadcastMemory memory, string category, IEnumerable<string> candidates,         string seed, Func<string, string> family)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveCommentary.Atmosphere(NationalSpire.BroadcastMemory, NationalSpire.AtmosphereContext, string, double)`](LiveAtmosphere.cs.md#symbol-0b25ed42c5ca)；[`NationalSpire.LiveCommentary.Finish(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`](LiveCommentary.cs.md#symbol-243aedb210e3)；[`NationalSpire.LiveCommentary.ObserveTurn(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`](LiveCommentary.cs.md#symbol-8cbc1ed10ae3)；[`NationalSpire.LiveCommentary.PlayerVictory(NationalSpire.BroadcastMemory, bool, double, int, int, string, string, string)`](LiveMoments.cs.md#symbol-44f4d20ad966)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.LiveCommentary.FocusHistory(NationalSpire.BroadcastMemory, string)`](CommentaryFocus.cs.md#symbol-63c4d695beeb)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.LiveCommentary.FocusHistory(NationalSpire.BroadcastMemory, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(seed + ":focus:" + t)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(seed + ":focus:" + t) % 100`
- `NationalSpire.LiveCommentary.FocusHistory(NationalSpire.BroadcastMemory, string)`；输入表达式：`FocusHistory(memory, category)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: FocusHistory(memory, category).TakeLast`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`choices.Any(t => family(t) != history.LastOrDefault())`；返回值紧邻使用处：`IfStatementSyntax: if (choices.Any(t => family(t) != history.LastOrDefault()))             choices.RemoveAll(t => family(t) == history.LastOrDefault());`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`history.Count(h => h == family(t))`；返回值紧邻使用处：`BinaryExpressionSyntax: history.Count(h => h == family(t)) * 100`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`candidates.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`choices.OrderBy(t => history.Count(h => h == family(t)) * 100             + CareerEngine.StableHash(seed + ":focus:" + t) % 100).FirstOrDefault()`；返回值紧邻使用处：`ReturnStatementSyntax: return choices.OrderBy(t => history.Count(h => h == family(t)) * 100             + CareerEngine.StableHash(seed + ":focus:" + t) % 100).FirstOrDefault();`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`history.LastOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: family(t) != history.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`history.LastOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: family(t) == history.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`choices.OrderBy(t => history.Count(h => h == family(t)) * 100             + CareerEngine.StableHash(seed + ":focus:" + t) % 100)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choices.OrderBy(t => history.Count(h => h == family(t)) * 100             + CareerEngine.StableHash(seed + ":focus:" + t) % 100).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`FocusHistory(memory, category).TakeLast(category == "victory" ? 6 : 12)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: FocusHistory(memory, category).TakeLast(category == "victory" ? 6 : 12).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`candidates.Distinct().ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = candidates.Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`FocusHistory(memory, category).TakeLast(category == "victory" ? 6 : 12).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FocusHistory(memory, category).TakeLast(category == "victory" ? 6 : 12).ToList()`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`choices.RemoveAll(t => family(t) == history.LastOrDefault())`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.RemoveAll(t => family(t) == history.LastOrDefault());`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`family(t)`；返回值紧邻使用处：`BinaryExpressionSyntax: family(t) != history.LastOrDefault()`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`family(t)`；返回值紧邻使用处：`BinaryExpressionSyntax: family(t) == history.LastOrDefault()`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`family(t)`；返回值紧邻使用处：`BinaryExpressionSyntax: h == family(t)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0e93da952279"></a>

## `NationalSpire.LiveCommentary.TopicFamily(string) — private static string TopicFamily(string topic)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8a2891030435"></a>

## `NationalSpire.LiveCommentary.DetailFamily(string) — private static string DetailFamily(string topic)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`](LiveMoments.cs.md#symbol-d358a4a6cc39)；[`NationalSpire.LiveCommentary.PlayerVictory(NationalSpire.BroadcastMemory, bool, double, int, int, string, string, string)`](LiveMoments.cs.md#symbol-44f4d20ad966)；[`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
