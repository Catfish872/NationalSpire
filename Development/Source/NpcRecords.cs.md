# NpcRecords.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`18C3628541416A12BDE1D5DC1C28EDC9691DCCE775D4AE53DA2D4F8739F97E3E`。来源：[源码](../../NpcRecords.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.NpcRecords`。

字段、事件及初始值（源码原样）：

```csharp
public const int Version = 1;
```

<a id="symbol-13b4702fac73"></a>

## `NationalSpire.NpcRecords.Ensure(NationalSpire.CareerData) — public static bool Ensure(CareerData data)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](Coop/CoopCoordinator.cs.md#symbol-778097f34ec3)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.NpcRecords.Initialize(NationalSpire.CareerPerson, int)`](NpcRecords.cs.md#symbol-321539fa4eea)；[`NationalSpire.NpcRecords.RestorePrivateClears(NationalSpire.CareerData)`](NpcRecords.cs.md#symbol-09ad91cd55b4)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.WeeklyPersonBaselines`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.EditedCard`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.RecordVersion`；`NationalSpire.CareerPerson.Role`；`NationalSpire.NpcRecords.Initialize(NationalSpire.CareerPerson, int)`；`NationalSpire.NpcRecords.RestorePrivateClears(NationalSpire.CareerData)`；`NationalSpire.NpcRecords.Version`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(data.WorldId + ":records:" + person.Id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(data.WorldId + ":records:" + person.Id)`
- `NationalSpire.NpcRecords.Initialize(NationalSpire.CareerPerson, int)`；输入表达式：`Initialize(person, CareerEngine.StableHash(data.WorldId + ":records:" + person.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: Initialize(person, CareerEngine.StableHash(data.WorldId + ":records:" + person.Id));`
- `NationalSpire.NpcRecords.RestorePrivateClears(NationalSpire.CareerData)`；输入表达式：`RestorePrivateClears(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RestorePrivateClears(data)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`data.WeeklyPersonBaselines.Remove(person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.WeeklyPersonBaselines.Remove(person.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => !data.HumanIds.Contains(p.Id) && p.Id != "player" && p.Role != "联机选手")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var person in data.People.Where(p => !data.HumanIds.Contains(p.Id) && p.Id != "player" && p.Role != "联机选手"))         {             if (person.EditedCard || person.RecordVersion >= Version) continue;             Initialize(person, CareerEngine.StableHash(data.WorldId + ":records:" + person.Id));             // 迁移补齐的是开档前履历，不计为本期新增通关。             data.WeeklyPersonBaselines.Remove(person.Id);             changed = true;         }`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.HumanIds.Contains(p.Id)`

**赋值（含属性/字段和局部值）：**

- `changed` = `true`

<a id="symbol-09ad91cd55b4"></a>

## `NationalSpire.NpcRecords.RestorePrivateClears(NationalSpire.CareerData) — public static bool RestorePrivateClears(CareerData data)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NpcRecords.Ensure(NationalSpire.CareerData)`](NpcRecords.cs.md#symbol-13b4702fac73)

**调用：** [`NationalSpire.NpcRecords.RecordPrivateClear(NationalSpire.CareerData, NationalSpire.CareerMatch)`](NpcRecords.cs.md#symbol-43e8a659d2a2)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`](PrivateAppointments.cs.md#symbol-32f6566791d2)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Status`；`NationalSpire.NpcRecords.RecordPrivateClear(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NpcRecords.RecordPrivateClear(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`RecordPrivateClear(data, match)`；返回值紧邻使用处：`AssignmentExpressionSyntax: changed |= RecordPrivateClear(data, match)`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；输入表达式：`PrivateAppointments.IsPrivate(m)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Day <= data.Day && m.Status == "已结算" && PrivateAppointments.IsPrivate(m)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m => m.Day <= data.Day && m.Status == "已结算" && PrivateAppointments.IsPrivate(m))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var match in data.Matches.Where(m => m.Day <= data.Day && m.Status == "已结算" && PrivateAppointments.IsPrivate(m)))             changed |= RecordPrivateClear(data, match);`

**赋值（含属性/字段和局部值）：**

- `changed` |= `RecordPrivateClear(data, match)`

<a id="symbol-43e8a659d2a2"></a>

## `NationalSpire.NpcRecords.RecordPrivateClear(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static bool RecordPrivateClear(CareerData data, CareerMatch match)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.NpcRecords.RestorePrivateClears(NationalSpire.CareerData)`](NpcRecords.cs.md#symbol-09ad91cd55b4)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`](PrivateAppointments.cs.md#symbol-32f6566791d2)；`double.IsFinite(double)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.PrivateHighestClear`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `double.IsFinite(double)`；输入表达式：`double.IsFinite(match.OpponentSeconds.Value)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !double.IsFinite(match.OpponentSeconds.Value)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, match.OpponentId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, match.OpponentId) is not { } person`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；输入表达式：`PrivateAppointments.IsPrivate(match)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateAppointments.IsPrivate(match)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(match.OpponentId)`；返回值紧邻使用处：`BinaryExpressionSyntax: !PrivateAppointments.IsPrivate(match) || match.Status != "已结算" || !match.OpponentPrepared || !match.OpponentWon             || match.OpponentSeconds is not > 0 || !double.IsFinite(match.OpponentSeconds.Value)             || match.RequiredAscension is < 0 or > 10 || data.HumanIds.Contains(match.OpponentId)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(person.MaxAscension, highest)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(person.MaxAscension, highest)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(person.PrivateHighestClear, match.RequiredAscension)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(person.PrivateHighestClear, match.RequiredAscension)`

**赋值（含属性/字段和局部值）：**

- `person.MaxAscension` = `max`
- `person.PrivateHighestClear` = `highest`

<a id="symbol-321539fa4eea"></a>

## `NationalSpire.NpcRecords.Initialize(NationalSpire.CareerPerson, int) — public static void Initialize(CareerPerson person, int seed)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitPeople.Add(NationalSpire.CareerData, string, string, string, string, int)`](CircuitPeople.cs.md#symbol-1bc89c911651)；[`NationalSpire.NpcRecords.Ensure(NationalSpire.CareerData)`](NpcRecords.cs.md#symbol-13b4702fac73)；[`NationalSpire.OwnedClubs.InitializeRecruit(NationalSpire.CareerData, NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-16ca5da8a4ee)

**调用：** `System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`；`System.Math.Round(double)`；`System.Random.NextDouble()`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.AiIntroduction`；`NationalSpire.CareerPerson.IntroductionDay`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.RecordVersion`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.NpcRecords.Version`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(person.MaxAscension, 0, 10)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(person.MaxAscension, 0, 10)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, person.Losses)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, person.Losses) * rate`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(minimum, wins)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(minimum, wins)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(person.Wins, Math.Max(minimum, wins))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(person.Wins, Math.Max(minimum, wins))`
- `System.Math.Round(double)`；输入表达式：`Math.Round(Math.Max(0, person.Losses) * rate / (1 - rate))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(Math.Max(0, person.Losses) * rate / (1 - rate))`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.NextDouble() * (level >= 6 ? .14 : .07)`
- `System.Random.Random(int)`；输入表达式：`new Random(seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(seed)`

**赋值（含属性/字段和局部值）：**

- `person.AiIntroduction` = `""`
- `person.IntroductionDay` = `0`
- `person.RecordVersion` = `Version`
- `person.Wins` = `updated`
