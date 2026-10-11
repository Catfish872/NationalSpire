# TeamPreparation.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`EFB871EA797C5D1BEB66098F6766C958429C54720245F8DDBA2F4CC166F5CB25`。来源：[源码](../../TeamPreparation.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.TeamPreparation`、`NationalSpire.TeamPreparations`。

字段、事件及初始值（源码原样）：

```csharp
public const int Cost = 1200;
```

<a id="symbol-c0dc0580266d"></a>

## `NationalSpire.TeamPreparation.CompetitionId — public string CompetitionId`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4e2e42f72a9a"></a>

## `NationalSpire.TeamPreparation.Team — public string Team`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3829da2334dd"></a>

## `NationalSpire.TeamPreparation.Remaining — public int Remaining`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4e71cc1faf89"></a>

## `NationalSpire.TeamPreparation.CompletedRounds — public HashSet<int> CompletedRounds`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f2f72b62407b"></a>

## `NationalSpire.TeamPreparations.Available(NationalSpire.CareerData) — public static IEnumerable<WorldCompetition> Available(CareerData d)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData)`](TeamPreparationScreen.cs.md#symbol-57b7570c5a7d)；[`NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`](TeamPreparation.cs.md#symbol-440f4ccf2595)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => !f.Finished && (f.HomeId == "player" || f.AwayId == "player" || c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains("player") == true || c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains("player") == true))`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Season == d.Season         && c.TeamEvent && !c.Cooperative && !c.Finished && c.Rosters.Values.Any(r => r.Contains("player"))         && c.Fixtures.Any(f => !f.Finished && (f.HomeId == "player" || f.AwayId == "player" || c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains("player") == true || c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains("player") == true))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Rosters.Values.Any(r => r.Contains("player"))`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Season == d.Season         && c.TeamEvent && !c.Cooperative && !c.Finished && c.Rosters.Values.Any(r => r.Contains("player"))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season         && c.TeamEvent && !c.Cooperative && !c.Finished && c.Rosters.Values.Any(r => r.Contains("player"))         && c.Fixtures.Any(f => !f.Finished && (f.HomeId == "player" || f.AwayId == "player" || c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains("player") == true || c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains("player") == true)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.Competitions.Where(c => c.Season == d.Season         && c.TeamEvent && !c.Cooperative && !c.Finished && c.Rosters.Values.Any(r => r.Contains("player"))         && c.Fixtures.Any(f => !f.Finished && (f.HomeId == "player" || f.AwayId == "player" || c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains("player") == true || c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains("player") == true)))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.Rosters.GetValueOrDefault(f.AwayTeam)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains("player")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.Rosters.GetValueOrDefault(f.HomeTeam)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains("player")`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`.Contains("player")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains("player")`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`.Contains("player")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains("player")`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`r.Contains("player")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => r.Contains("player")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-440f4ccf2595"></a>

## `NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string) — public static string? Buy(CareerData d, string competitionId)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData)`](TeamPreparationScreen.cs.md#symbol-57b7570c5a7d)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`](LifeData.cs.md#symbol-bcb55555a432)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-7f4fa41ad4c0)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`](TeamPreparation.cs.md#symbol-f2f72b62407b)；`NationalSpire.TeamPreparation.TeamPreparation()`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.TeamPreparations`；`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.TeamPreparation.CompetitionId`；`NationalSpire.TeamPreparation.CompletedRounds`；`NationalSpire.TeamPreparation.Remaining`；`NationalSpire.TeamPreparation.Team`；`NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`；`NationalSpire.TeamPreparations.Cost`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；输入表达式：`CareerMoney.Add(d, -Cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Add(d, -Cost);`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d) < Cost`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, c.Name + "集体备赛", -Cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, c.Name + "集体备赛", -Cost);`
- `NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；输入表达式：`MatchFailure.Locked(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: MatchFailure.Locked(d) is { } locked`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.IsOwner(d)`；返回值紧邻使用处：`IfStatementSyntax: if (OwnedClubs.IsOwner(d)) OwnedClubs.Pay(d, c.Name + "集体备赛", -Cost);         else { CareerMoney.Add(d, -Cost); CareerMoney.Record(d, c.Name + "集体备赛", -Cost); }`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`OwnedClubs.Pay(d, c.Name + "集体备赛", -Cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.Pay(d, c.Name + "集体备赛", -Cost);`
- `NationalSpire.TeamPreparation.TeamPreparation()`；输入表达式：`new() { CompetitionId = c.Id, Team = team,             CompletedRounds = c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select(g => g.Key).ToHashSet() }`；返回值紧邻使用处：`ArgumentSyntax: new() { CompetitionId = c.Id, Team = team,             CompletedRounds = c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select(g => g.Key).ToHashSet() }`
- `NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`；输入表达式：`Available(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Available(d).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.All(f => f.Finished)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.All(f => f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Rosters.First(r => r.Value.Contains("player"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Rosters.First(r => r.Value.Contains("player")).Key`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Available(d).FirstOrDefault(c => c.Id == competitionId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Available(d).FirstOrDefault(c => c.Id == competitionId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.TeamPreparations.FirstOrDefault(p => p.CompetitionId == c.Id && p.Team == team)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.TeamPreparations.FirstOrDefault(p => p.CompetitionId == c.Id && p.Team == team)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select(g => g.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select(g => g.Key).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select(g => g.Key).ToHashSet()`；返回值紧邻使用处：`AssignmentExpressionSyntax: CompletedRounds = c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select(g => g.Key).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.TeamPreparations.Add(new() { CompetitionId = c.Id, Team = team,             CompletedRounds = c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select(g => g.Key).ToHashSet() })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.TeamPreparations.Add(new() { CompetitionId = c.Id, Team = team,             CompletedRounds = c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select(g => g.Key).ToHashSet() });`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`r.Value.Contains("player")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => r.Value.Contains("player")`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.TeamPreparations.RemoveAll(p => p.CompetitionId == c.Id && p.Team == team)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.TeamPreparations.RemoveAll(p => p.CompetitionId == c.Id && p.Team == team);`

**赋值（含属性/字段和局部值）：**

- `CompetitionId` = `c.Id`
- `CompletedRounds` = `c.Fixtures.Where(f => f.HomeTeam == team || f.AwayTeam == team).GroupBy(f => f.Round).Where(g => g.All(f => f.Finished)).Select(g => g.Key).ToHashSet()`
- `Team` = `team`

<a id="symbol-3064e4d52a71"></a>

## `NationalSpire.TeamPreparations.Bonus(NationalSpire.CareerData, string, int) — public static double Bonus(CareerData d, string id, int day)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`](MatchRules.cs.md#symbol-92264d5fcfdd)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.TeamPreparations`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.TeamPreparation.CompetitionId`；`NationalSpire.TeamPreparation.Remaining`；`NationalSpire.TeamPreparation.Team`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeTeam`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => !f.Finished && f.Day == day && (f.HomeTeam == p.Team || f.AwayTeam == p.Team))`；返回值紧邻使用处：`IfStatementSyntax: if (c.Fixtures.Any(f => !f.Finished && f.Day == day && (f.HomeTeam == p.Team || f.AwayTeam == p.Team))) return .16;`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == p.CompetitionId && !c.Finished)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.FirstOrDefault(c => c.Id == p.CompetitionId && !c.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.TeamPreparations.Where(p => p.Remaining > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var p in d.TeamPreparations.Where(p => p.Remaining > 0))         {             var c = d.Esports.Competitions.FirstOrDefault(c => c.Id == p.CompetitionId && !c.Finished);             if (c?.Rosters.GetValueOrDefault(p.Team)?.Contains(id) != true) continue;             if (c.Fixtures.Any(f => !f.Finished && f.Day == day && (f.HomeTeam == p.Team || f.AwayTeam == p.Team))) return .16;         }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Rosters.GetValueOrDefault(p.Team)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Rosters.GetValueOrDefault(p.Team)?.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`.Contains(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Rosters.GetValueOrDefault(p.Team)?.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "player" || d.HumanIds.Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c4cffd0043d5"></a>

## `NationalSpire.TeamPreparations.Complete(NationalSpire.CareerData, NationalSpire.WorldCompetition, int) — public static void Complete(CareerData d, WorldCompetition c, int day)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool)`](EsportsWorld.cs.md#symbol-ae784907b7fa)

**调用：** `System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.TeamPreparations`；`NationalSpire.TeamPreparation.CompetitionId`；`NationalSpire.TeamPreparation.CompletedRounds`；`NationalSpire.TeamPreparation.Remaining`；`NationalSpire.TeamPreparation.Team`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.Walkover`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`p.CompletedRounds.Add(round.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: round.All(f => f.Finished) && round.Any(f => !f.Walkover) && p.CompletedRounds.Add(round.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`round.All(f => f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: round.All(f => f.Finished) && round.Any(f => !f.Walkover)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`round.Any(f => !f.Walkover)`；返回值紧邻使用处：`BinaryExpressionSyntax: round.All(f => f.Finished) && round.Any(f => !f.Walkover)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f => f.Day <= day && (f.HomeTeam == p.Team || f.AwayTeam == p.Team)).GroupBy(f => f.Round)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var round in c.Fixtures.Where(f => f.Day <= day && (f.HomeTeam == p.Team || f.AwayTeam == p.Team)).GroupBy(f => f.Round))             if (round.All(f => f.Finished) && round.Any(f => !f.Walkover) && p.CompletedRounds.Add(round.Key)) p.Remaining--;`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.Day <= day && (f.HomeTeam == p.Team || f.AwayTeam == p.Team))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Day <= day && (f.HomeTeam == p.Team || f.AwayTeam == p.Team)).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.TeamPreparations.Where(p => p.CompetitionId == c.Id && p.Remaining > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var p in d.TeamPreparations.Where(p => p.CompetitionId == c.Id && p.Remaining > 0))         foreach (var round in c.Fixtures.Where(f => f.Day <= day && (f.HomeTeam == p.Team || f.AwayTeam == p.Team)).GroupBy(f => f.Round))             if (round.All(f => f.Finished) && round.Any(f => !f.Walkover) && p.CompletedRounds.Add(round.Key)) p.Remaining--;`

**赋值（含属性/字段和局部值）：**
