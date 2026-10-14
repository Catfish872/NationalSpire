# NationalFortune.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`14D24F4FE6268CC35A5EC0FF54A85CF0E23412EC2925576CCD3FDD1F7D99FC0B`。来源：[源码](../../NationalFortune.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.NationalFortune`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-236169683705"></a>

## `NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition) — public static bool Applies(WorldCompetition c)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.MatchImpact(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CircuitLedger.cs.md#symbol-5c41de2c3969)；[`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.NationalFortune.Confirm(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](NationalFortune.cs.md#symbol-e7b2ae3450b4)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.WorldCompetition.FortuneVersion`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a091b3ef1f3e"></a>

## `NationalSpire.NationalFortune.Amount(string, int) — public static (int Win, int Loss) Amount(string kind, int round)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalFortune.Confirm(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](NationalFortune.cs.md#symbol-e7b2ae3450b4)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e7b2ae3450b4"></a>

## `NationalSpire.NationalFortune.Confirm(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture) — public static void Confirm(CareerData d, WorldCompetition c, WorldFixture f)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`](EsportsWorld.cs.md#symbol-f16aef3da82a)

**调用：** [`NationalSpire.NationalFortune.Add(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, int)`](NationalFortune.cs.md#symbol-b9fd32a76496)；[`NationalSpire.NationalFortune.Amount(string, int)`](NationalFortune.cs.md#symbol-a091b3ef1f3e)；[`NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`](NationalFortune.cs.md#symbol-236169683705)；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(int Win, int Loss).Loss`；`(int Win, int Loss).Win`；`NationalSpire.NationalFortune.Add(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, int)`；`NationalSpire.NationalFortune.Amount(string, int)`；`NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Draw`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.FortuneSettled`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.PromotionSettled`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.Walkover`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NationalFortune.Add(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, int)`；输入表达式：`Add(d, c, f, f.AwayId, seats * (c.TeamEvent ? amounts.Loss : f.WinnerId == f.AwayId ? amounts.Win : amounts.Loss))`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(d, c, f, f.AwayId, seats * (c.TeamEvent ? amounts.Loss : f.WinnerId == f.AwayId ? amounts.Win : amounts.Loss));`
- `NationalSpire.NationalFortune.Add(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, int)`；输入表达式：`Add(d, c, f, f.HomeId, seats * (c.TeamEvent ? amounts.Loss : f.WinnerId == f.HomeId ? amounts.Win : amounts.Loss))`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(d, c, f, f.HomeId, seats * (c.TeamEvent ? amounts.Loss : f.WinnerId == f.HomeId ? amounts.Win : amounts.Loss));`
- `NationalSpire.NationalFortune.Add(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, int)`；输入表达式：`Add(d, c, game, winner == game.HomeTeam ? game.HomeId : game.AwayId, seats * (amounts.Win - amounts.Loss))`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(d, c, game, winner == game.HomeTeam ? game.HomeId : game.AwayId, seats * (amounts.Win - amounts.Loss));`
- `NationalSpire.NationalFortune.Amount(string, int)`；输入表达式：`Amount(c.Kind, f.Round)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Amount(c.Kind, f.Round)`
- `NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`；输入表达式：`Applies(c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Applies(c)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.All(x => x.PromotionSettled)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Any(x => !x.Finished || x.Draw) || tie.All(x => x.PromotionSettled)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Any(x => !x.Finished || x.Draw)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Any(x => !x.Finished || x.Draw) || tie.All(x => x.PromotionSettled)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(x => x.WinnerId == x.AwayId)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Count(x => x.WinnerId == x.HomeId) > tie.Count(x => x.WinnerId == x.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(x => x.WinnerId == x.HomeId)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Count(x => x.WinnerId == x.HomeId) > tie.Count(x => x.WinnerId == x.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam).ToList`

**赋值（含属性/字段和局部值）：**

- `f.FortuneSettled` = `true`
- `game.PromotionSettled` = `true`

<a id="symbol-b9fd32a76496"></a>

## `NationalSpire.NationalFortune.Add(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, int) — private static void Add(CareerData d, WorldCompetition c, WorldFixture f, string id, int amount)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalFortune.Confirm(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](NationalFortune.cs.md#symbol-e7b2ae3450b4)

**调用：** [`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-abd0a463c72f)；`NationalSpire.CircuitAward.CircuitAward()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CircuitAward.ClubId`；`NationalSpire.CircuitAward.CompetitionId`；`NationalSpire.CircuitAward.Completed`；`NationalSpire.CircuitAward.Country`；`NationalSpire.CircuitAward.Day`；`NationalSpire.CircuitAward.Event`；`NationalSpire.CircuitAward.Fortune`；`NationalSpire.CircuitAward.Kind`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Place`；`NationalSpire.CircuitAward.Season`；`NationalSpire.EsportsCareer.CircuitAwards`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NationalLegacy.Treasury`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.DevelopmentChanges`；`NationalSpire.WorldFixture.Fortune`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitAward.CircuitAward()`；输入表达式：`new() { CompetitionId = c.Id, PersonId = id, Country = country, ClubId = c.EntrantClubs[id],                  Season = c.Season, Event = c.Name, Kind = c.Kind, Place = "参赛中", Completed = false }`；返回值紧邻使用处：`AssignmentExpressionSyntax: award = new() { CompetitionId = c.Id, PersonId = id, Country = country, ClubId = c.EntrantClubs[id],                  Season = c.Season, Event = c.Name, Kind = c.Kind, Place = "参赛中", Completed = false }`
- `NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`；输入表达式：`NationalDevelopment.Contribute(d, nation, amount)`；返回值紧邻使用处：`ArgumentSyntax: NationalDevelopment.Contribute(d, nation, amount)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Nations.First(n => n.Country == country)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Nations.First(n => n.Country == country)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.FirstOrDefault(a => a.CompetitionId == c.Id && a.PersonId == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.CircuitAwards.FirstOrDefault(a => a.CompetitionId == c.Id && a.PersonId == id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`f.Fortune.GetValueOrDefault(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: f.Fortune.GetValueOrDefault(id) + amount`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.CircuitAwards.Add(award)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.CircuitAwards.Add(award);`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`f.DevelopmentChanges.AddRange(NationalDevelopment.Contribute(d, nation, amount))`；返回值紧邻使用处：`ExpressionStatementSyntax: f.DevelopmentChanges.AddRange(NationalDevelopment.Contribute(d, nation, amount));`

**赋值（含属性/字段和局部值）：**

- `award.Day` = `d.Day`
- `award.Fortune` += `amount`
- `award` = `new() { CompetitionId = c.Id, PersonId = id, Country = country, ClubId = c.EntrantClubs[id],                  Season = c.Season, Event = c.Name, Kind = c.Kind, Place = "参赛中", Completed = false }`
- `ClubId` = `c.EntrantClubs[id]`
- `CompetitionId` = `c.Id`
- `Completed` = `false`
- `Country` = `country`
- `d.Credits` += `amount * 20`
- `Event` = `c.Name`
- `f.Fortune[id]` = `f.Fortune.GetValueOrDefault(id) + amount`
- `Kind` = `c.Kind`
- `nation.Treasury` += `amount * 2`
- `PersonId` = `id`
- `Place` = `"参赛中"`
- `Season` = `c.Season`

<a id="symbol-96a45ca5bf6b"></a>

## `NationalSpire.NationalFortune.Impact(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture) — public static string Impact(CareerData d, WorldCompetition c, WorldFixture f)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.MatchImpact(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CircuitLedger.cs.md#symbol-5c41de2c3969)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldFixture.DevelopmentChanges`；`NationalSpire.WorldFixture.Fortune`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(amount * 20)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(amount * 20)}`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("", f.DevelopmentChanges.Distinct())`；返回值紧邻使用处：`BinaryExpressionSyntax: contribution + string.Join("", f.DevelopmentChanges.Distinct())`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`f.DevelopmentChanges.Distinct()`；返回值紧邻使用处：`ArgumentSyntax: f.DevelopmentChanges.Distinct()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`f.Fortune.GetValueOrDefault("player")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = f.Fortune.GetValueOrDefault("player")`

**赋值（含属性/字段和局部值）：**
