# AffectionCompetition.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A5CD32D1E5DD5E52C4CA51968B67000A3AD9F8482DC42237BE19D1B8B4D0145C`。来源：[源码](../../AffectionCompetition.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AffectionCompetition`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-4ab3be7106e1"></a>

## `NationalSpire.AffectionCompetition.Reference(NationalSpire.CareerData, string) — public static (string Player, int Favour) Reference(CareerData data, string person)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionCompetition.Favour(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-d7d960542e2d)；[`NationalSpire.AffectionCompetition.Teammate(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-5496ff92273c)

**调用：** [`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanFavours`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Favour(data, person)`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(data, person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == data.LocalHumanId ? PrivateMessages.Favour(data, person) : data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person) ?? 0`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`data.HumanIds.Select(id => (Player: id, Favour: id == data.LocalHumanId ? PrivateMessages.Favour(data, person) : data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person) ?? 0)) .OrderByDescending(p => p.Favour).ThenBy(p => p.Player, StringComparer.Ordinal).First()`；返回值紧邻使用处：`ReturnStatementSyntax: return data.HumanIds.Select(id => (Player: id, Favour: id == data.LocalHumanId ? PrivateMessages.Favour(data, person) : data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person) ?? 0)) .OrderByDescending(p => p.Favour).ThenBy(p => p.Player, StringComparer.Ordinal).First();`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.HumanIds.Select(id => (Player: id, Favour: id == data.LocalHumanId ? PrivateMessages.Favour(data, person) : data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person) ?? 0)) .OrderByDescending(p => p.Favour)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.HumanIds.Select(id => (Player: id, Favour: id == data.LocalHumanId ? PrivateMessages.Favour(data, person) : data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person) ?? 0)) .OrderByDescending(p => p.Favour).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.HumanIds.Select(id => (Player: id, Favour: id == data.LocalHumanId ? PrivateMessages.Favour(data, person) : data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person) ?? 0))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.HumanIds.Select(id => (Player: id, Favour: id == data.LocalHumanId ? PrivateMessages.Favour(data, person) : data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person) ?? 0)) .OrderByDescending`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(person)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.HumanFavours.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`data.HumanIds.Select(id => (Player: id, Favour: id == data.LocalHumanId ? PrivateMessages.Favour(data, person) : data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person) ?? 0)) .OrderByDescending(p => p.Favour).ThenBy(p => p.Player, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.HumanIds.Select(id => (Player: id, Favour: id == data.LocalHumanId ? PrivateMessages.Favour(data, person) : data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person) ?? 0)) .OrderByDescending(p => p.Favour).ThenBy(p => p.Player, StringComparer.Ordinal).First`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d7d960542e2d"></a>

## `NationalSpire.AffectionCompetition.Favour(NationalSpire.CareerData, string) — public static int Favour(CareerData data, string person)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionCompetition.Direct(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-d6534118ff70)；[`NationalSpire.AffectionCompetition.Growth(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-34950d0c3f4b)

**调用：** [`NationalSpire.AffectionCompetition.Reference(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-4ab3be7106e1)

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionCompetition.Reference(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionCompetition.Reference(NationalSpire.CareerData, string)`；输入表达式：`Reference(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Reference(data, person).Favour`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5496ff92273c"></a>

## `NationalSpire.AffectionCompetition.Teammate(NationalSpire.CareerData, string) — public static bool Teammate(CareerData data, string person)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionCompetition.Direct(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-d6534118ff70)；[`NationalSpire.AffectionCompetition.Growth(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-34950d0c3f4b)

**调用：** [`NationalSpire.AffectionCompetition.Reference(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-4ab3be7106e1)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionCompetition.Reference(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.EsportsCareer.ClubId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionCompetition.Reference(NationalSpire.CareerData, string)`；输入表达式：`Reference(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Reference(data, person).Player`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(data, person)?.ClubId`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, player)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(data, player)?.ClubId`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6395a3e6d33b"></a>

## `NationalSpire.AffectionCompetition.Eligible(NationalSpire.CareerData, string) — private static bool Eligible(CareerData data, string person)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionCompetition.Direct(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-d6534118ff70)；[`NationalSpire.AffectionCompetition.Growth(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-34950d0c3f4b)

**调用：** `System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.AffectionLinkedClearChance`；`NationalSpire.CareerData.HumanIds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.HumanIds.Contains(person)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-34950d0c3f4b"></a>

## `NationalSpire.AffectionCompetition.Growth(NationalSpire.CareerData, string) — public static double Growth(CareerData data, string person)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionCompetition.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity)`](AffectionCompetition.cs.md#symbol-66c772141d54)；[`NationalSpire.CareerTraining.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-8fa9f91feb98)；[`NationalSpire.CareerTraining.ExpectedGrowth(NationalSpire.CareerData, NationalSpire.LifeActivity, string, int)`](CareerTraining.cs.md#symbol-19da8bbb9563)；[`NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`](CareerTraining.cs.md#symbol-8d0cf5a9811c)；[`NationalSpire.CareerTraining.RecordLesson(NationalSpire.CareerData, string, NationalSpire.PrivateLearning)`](CareerTraining.cs.md#symbol-20ac1d8e57c7)；[`NationalSpire.OwnedClubs.PracticeBonus(NationalSpire.CareerData, string, int, int?)`](OwnedClubs.cs.md#symbol-5b2c48d0615a)；[`NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`](TeamPreparation.cs.md#symbol-440f4ccf2595)

**调用：** [`NationalSpire.AffectionCompetition.Eligible(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-6395a3e6d33b)；[`NationalSpire.AffectionCompetition.Favour(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-d7d960542e2d)；[`NationalSpire.AffectionCompetition.Teammate(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-5496ff92273c)；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionCompetition.Eligible(NationalSpire.CareerData, string)`；`NationalSpire.AffectionCompetition.Favour(NationalSpire.CareerData, string)`；`NationalSpire.AffectionCompetition.Teammate(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionCompetition.Eligible(NationalSpire.CareerData, string)`；输入表达式：`Eligible(data, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Eligible(data, person)`
- `NationalSpire.AffectionCompetition.Favour(NationalSpire.CareerData, string)`；输入表达式：`Favour(data, person)`；返回值紧邻使用处：`ArgumentSyntax: Favour(data, person)`
- `NationalSpire.AffectionCompetition.Teammate(NationalSpire.CareerData, string)`；输入表达式：`Teammate(data, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Teammate(data, person)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(Favour(data, person), -50, 100)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(Favour(data, person), -50, 100)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d6534118ff70"></a>

## `NationalSpire.AffectionCompetition.Direct(NationalSpire.CareerData, string) — public static double Direct(CareerData data, string person)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`](MatchRules.cs.md#symbol-92264d5fcfdd)

**调用：** [`NationalSpire.AffectionCompetition.Eligible(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-6395a3e6d33b)；[`NationalSpire.AffectionCompetition.Favour(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-d7d960542e2d)；[`NationalSpire.AffectionCompetition.Teammate(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-5496ff92273c)；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionCompetition.Eligible(NationalSpire.CareerData, string)`；`NationalSpire.AffectionCompetition.Favour(NationalSpire.CareerData, string)`；`NationalSpire.AffectionCompetition.Teammate(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionCompetition.Eligible(NationalSpire.CareerData, string)`；输入表达式：`Eligible(data, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Eligible(data, person)`
- `NationalSpire.AffectionCompetition.Favour(NationalSpire.CareerData, string)`；输入表达式：`Favour(data, person)`；返回值紧邻使用处：`ArgumentSyntax: Favour(data, person)`
- `NationalSpire.AffectionCompetition.Teammate(NationalSpire.CareerData, string)`；输入表达式：`Teammate(data, person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Teammate(data, person) ? favour >= 0 ? favour / 1000d : favour / 500d : -Math.Max(0, favour) / 1000d`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(Favour(data, person), -50, 100)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(Favour(data, person), -50, 100)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, favour)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: -Math.Max(0, favour)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-66c772141d54"></a>

## `NationalSpire.AffectionCompetition.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static void Snapshot(CareerData data, LifeActivity activity)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerTraining.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity, bool)`](CareerTraining.cs.md#symbol-feb4623577e9)；[`NationalSpire.ClubPrograms.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-48edcdfd89d0)

**调用：** [`NationalSpire.AffectionCompetition.Growth(NationalSpire.CareerData, string)`](AffectionCompetition.cs.md#symbol-34950d0c3f4b)；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionCompetition.Growth(NationalSpire.CareerData, string)`；`NationalSpire.LifeActivity.AffectionGrowth`；`NationalSpire.LifeActivity.TrainingTargets`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionCompetition.Growth(NationalSpire.CareerData, string)`；输入表达式：`Growth(data, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => Growth(data, id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`activity.TrainingTargets.ToDictionary(id => id, id => Growth(data, id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: activity.AffectionGrowth = activity.TrainingTargets.ToDictionary(id => id, id => Growth(data, id))`

**赋值（含属性/字段和局部值）：**

- `activity.AffectionGrowth` = `activity.TrainingTargets.ToDictionary(id => id, id => Growth(data, id))`

<a id="symbol-33c39b9340c5"></a>

## `NationalSpire.AffectionCompetition.Temporary(NationalSpire.CareerData, NationalSpire.LifeActivity, string) — public static double Temporary(CareerData data, LifeActivity activity, string person)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerTraining.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-8fa9f91feb98)；[`NationalSpire.CareerTraining.Temporary(NationalSpire.CareerData, string, int, bool)`](CareerTraining.cs.md#symbol-3a66a2b5dee0)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.AffectionLinkedClearChance`；`NationalSpire.LifeActivity.AffectionGrowth`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`activity.AffectionGrowth.GetValueOrDefault(person, 1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.AffectionLinkedClearChance ? activity.AffectionGrowth.GetValueOrDefault(person, 1) : 1`

**赋值（含属性/字段和局部值）：**


<a id="symbol-febdbaec2db0"></a>

## `NationalSpire.AffectionCompetition.Set(NationalSpire.CareerData, bool) — public static void Set(CareerData data, bool enabled)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AffectionSettings(NationalSpire.CareerData)`](AffectionSettingsScreen.cs.md#symbol-2fc9af32beab)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-5df788f3061f)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.AffectionLinkedClearChance`；`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；输入表达式：`CareerTraining.InvalidateForecast(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.InvalidateForecast(data);`

**赋值（含属性/字段和局部值）：**

- `data.AffectionLinkedClearChance` = `enabled`
