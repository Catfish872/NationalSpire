# CircuitWorld.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6F65FC7AA6AB0F49F26096D4C3D4493BA8EEBAE1C7CD3196E527ED040C58E099`。来源：[源码](../../CircuitWorld.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CircuitWorld`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly int[] LeagueDays = [10, 12, 14, 16, 18];
```

<a id="symbol-74904a83d22a"></a>

## `NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string) — public static string TeamName(CareerData d, WorldCompetition c, string team)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CircuitLedger.MatchImpact(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CircuitLedger.cs.md#symbol-5c41de2c3969)；[`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.SettlementRecords.Capture(NationalSpire.CareerData, NationalSpire.CareerMatch, int)`](SettlementRecord.cs.md#symbol-8ce7adcb9168)；[`NationalSpire.SettlementRecords.CaptureCompetition(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.WorldCompetition, int, System.Collections.Generic.Dictionary<string, int>)`](SettlementRecord.cs.md#symbol-62f41904fd5e)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** [`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)

**字段、属性、事件及方法组引用：** `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, team)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Kind == "worldcup" ? team : EsportsWorld.ClubName(d, team)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-95620df3f1f6"></a>

## `NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition) — public static int RoundCount(WorldCompetition c)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.CircuitWorld.AddTie(NationalSpire.WorldCompetition, string, string, int, int)`](CircuitWorld.cs.md#symbol-92e308352d2e)；[`NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`](CircuitWorld.cs.md#symbol-b35defbcdb7c)；[`NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-51faa8d5ccbd)；[`NationalSpire.SettlementRecords.Capture(NationalSpire.CareerData, NationalSpire.CareerMatch, int)`](SettlementRecord.cs.md#symbol-8ce7adcb9168)

**调用：** `System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`c.Fixtures.Select(f => f.Round).DefaultIfEmpty(5).Max()`；返回值紧邻使用处：`ArgumentSyntax: c.Fixtures.Select(f => f.Round).DefaultIfEmpty(5).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`c.Fixtures.Select(f => f.Round).DefaultIfEmpty(5)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Select(f => f.Round).DefaultIfEmpty(5).Max`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Fixtures.Select(f => f.Round)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Select(f => f.Round).DefaultIfEmpty`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(5, c.Fixtures.Select(f => f.Round).DefaultIfEmpty(5).Max())`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Kind == "league" ? Math.Max(5, c.Fixtures.Select(f => f.Round).DefaultIfEmpty(5).Max()) : c.Kind == "worldfinal" ? 5 : c.Kind == "worldcup" ? 3 : 4`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b35defbcdb7c"></a>

## `NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int) — public static string RoundName(WorldCompetition c, int round)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)；[`NationalSpire.CircuitLedger.MatchImpact(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CircuitLedger.cs.md#symbol-5c41de2c3969)；[`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-bf4a0401a0ec)；[`Round(int)`](SettlementRecord.cs.md#symbol-33205503597c)

**调用：** [`NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-95620df3f1f6)

**字段、属性、事件及方法组引用：** `NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；`NationalSpire.WorldCompetition.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；输入表达式：`RoundCount(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: RoundCount(c) - round`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ca39b3e6a0f0"></a>

## `NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition) — public static List<CareerStanding> TeamTable(WorldCompetition c)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)；[`NationalSpire.CircuitWorld.AdvanceCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition, int, bool)`](CircuitWorld.cs.md#symbol-0318d361b72c)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-51faa8d5ccbd)；[`NationalSpire.SettlementRecords.Capture(NationalSpire.CareerData, NationalSpire.CareerMatch, int)`](SettlementRecord.cs.md#symbol-8ce7adcb9168)；[`NationalSpire.SettlementRecords.CaptureCompetition(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.WorldCompetition, int, System.Collections.Generic.Dictionary<string, int>)`](SettlementRecord.cs.md#symbol-62f41904fd5e)

**调用：** `NationalSpire.CareerStanding.CareerStanding()`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `(int Round, string HomeTeam, string AwayTeam).AwayTeam`；`(int Round, string HomeTeam, string AwayTeam).HomeTeam`；`NationalSpire.CareerStanding.Clears`；`NationalSpire.CareerStanding.Draws`；`NationalSpire.CareerStanding.Losses`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CareerStanding.Points`；`NationalSpire.CareerStanding.Wins`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Teams`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStanding.CareerStanding()`；输入表达式：`new CareerStanding { PersonId = id }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => new CareerStanding { PersonId = id }`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.All(f => f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Count() >= (c.Cooperative ? 1 : 3) && g.All(f => f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Count() >= (c.Cooperative ? 1 : 3)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(f => f.WinnerId == f.AwayId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tie.Count(f => f.WinnerId == f.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(f => f.WinnerId == f.HomeId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tie.Count(f => f.WinnerId == f.HomeId)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`table.OrderByDescending(t => t.Points)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: table.OrderByDescending(t => t.Points).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Teams.Select(id => new CareerStanding { PersonId = id })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Teams.Select(id => new CareerStanding { PersonId = id }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Teams.Select(id => new CareerStanding { PersonId = id }).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Teams.Select(id => new CareerStanding { PersonId = id }).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`table.OrderByDescending(t => t.Points).ThenByDescending(t => t.Clears).ThenBy(t => t.PersonId, StringComparer.Ordinal).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return table.OrderByDescending(t => t.Points).ThenByDescending(t => t.Clears).ThenBy(t => t.PersonId, StringComparer.Ordinal).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Count() >= (c.Cooperative ? 1 : 3) && g.All(f => f.Finished))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var tie in c.Fixtures.GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Count() >= (c.Cooperative ? 1 : 3) && g.All(f => f.Finished)))          {              int home = tie.Count(f => f.WinnerId == f.HomeId), away = tie.Count(f => f.WinnerId == f.AwayId);              foreach (var row in table.Where(t => t.PersonId == tie.Key.HomeTeam || t.PersonId == tie.Key.AwayTeam))              {                  bool won = row.PersonId == tie.Key.HomeTeam ? home > away : away > home;                  row.Clears += row.PersonId == tie.Key.HomeTeam ? home : away;                  if (home == away) { row.Draws++; row.Points++; } else if (won) { row.Wins++; row.Points += 3; } else row.Losses++;              }          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`table.Where(t => t.PersonId == tie.Key.HomeTeam || t.PersonId == tie.Key.AwayTeam)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var row in table.Where(t => t.PersonId == tie.Key.HomeTeam || t.PersonId == tie.Key.AwayTeam))              {                  bool won = row.PersonId == tie.Key.HomeTeam ? home > away : away > home;                  row.Clears += row.PersonId == tie.Key.HomeTeam ? home : away;                  if (home == away) { row.Draws++; row.Points++; } else if (won) { row.Wins++; row.Points += 3; } else row.Losses++;              }`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`table.OrderByDescending(t => t.Points).ThenByDescending(t => t.Clears).ThenBy(t => t.PersonId, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: table.OrderByDescending(t => t.Points).ThenByDescending(t => t.Clears).ThenBy(t => t.PersonId, StringComparer.Ordinal).ToList`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`table.OrderByDescending(t => t.Points).ThenByDescending(t => t.Clears)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: table.OrderByDescending(t => t.Points).ThenByDescending(t => t.Clears).ThenBy`

**赋值（含属性/字段和局部值）：**

- `PersonId` = `id`
- `row.Clears` += `row.PersonId == tie.Key.HomeTeam ? home : away`
- `row.Points` += `3`

<a id="symbol-8e4cfe18b2fe"></a>

## `NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData) — public static void StartSeason(CareerData d)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.CreateNew(bool, int)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.Coop.CoopRules.Create(ulong, string, string, int, string)`](Coop/CoopRules.cs.md#symbol-768ae6d9f0c2)；[`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-1e2b623aabf2)

**调用：** [`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)；[`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-03130719dfb2)；[`NationalSpire.CircuitPeople.SeasonChange(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-d77bf6cf914a)；[`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-43c8211433d7)；[`NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`](CircuitWorld.cs.md#symbol-a4180110ef1d)；[`NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-73f52bc89477)；[`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c152f62d57e4)；[`NationalSpire.CoachLineups.SeasonStart(NationalSpire.CareerData)`](CoachLineups.cs.md#symbol-e6f5b5e37a12)；[`NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-2429e4910b3f)；[`NationalSpire.OwnedClubSchedule.ApplyNextRegion(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-f50b11cb9486)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`；`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`；`NationalSpire.CircuitPeople.SeasonChange(NationalSpire.CareerData)`；`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`；`NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`；`NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`；`NationalSpire.CoachLineups.SeasonStart(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.NationalTeam`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData)`；`NationalSpire.OwnedClubSchedule.ApplyNextRegion(NationalSpire.CareerData)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`；输入表达式：`CircuitLedger.SeasonStart(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitLedger.SeasonStart(d);`
- `NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`；输入表达式：`CircuitPeople.Replenish(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitPeople.Replenish(d);`
- `NationalSpire.CircuitPeople.SeasonChange(NationalSpire.CareerData)`；输入表达式：`CircuitPeople.SeasonChange(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitPeople.SeasonChange(d);`
- `NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`；输入表达式：`AutoEntry(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: AutoEntry(d);`
- `NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`；输入表达式：`BuildLeague(d, nation, $"league-{d.Season}-{nation}")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BuildLeague(d, nation, $"league-{d.Season}-{nation}")`
- `NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData)`；输入表达式：`EnsureOpenEvents(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: EnsureOpenEvents(d);`
- `NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.SeasonStart(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubCoaching.SeasonStart(d);`
- `NationalSpire.CoachLineups.SeasonStart(NationalSpire.CareerData)`；输入表达式：`CoachLineups.SeasonStart(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoachLineups.SeasonStart(d);`
- `NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ArriveTransfers(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.ArriveTransfers(d);`
- `NationalSpire.OwnedClubSchedule.ApplyNextRegion(NationalSpire.CareerData)`；输入表达式：`OwnedClubSchedule.ApplyNextRegion(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubSchedule.ApplyNextRegion(d);`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SeasonCalendar.Start(d)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Any(c => c.Modern && c.Season == d.Season && c.Kind == "league")`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Competitions.Any(c => c.Modern && c.Season == d.Season && c.Kind == "league")) { AutoEntry(d); return; }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Competitions.Add(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Competitions.Add(c);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Esports.Competitions.RemoveAll(c => c.Season < d.Season - 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Competitions.RemoveAll(c => c.Season < d.Season - 4);`

**赋值（含属性/字段和局部值）：**

- `d.Esports.NationalTeam` = `false`

<a id="symbol-a4180110ef1d"></a>

## `NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string) — public static WorldCompetition BuildLeague(CareerData d, string nation, string id)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-8e4cfe18b2fe)；[`NationalSpire.OwnedClubSchedule.Rebuild(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](OwnedClubSchedule.cs.md#symbol-def76591afef)

**调用：** [`NationalSpire.CircuitWorld.AddTie(NationalSpire.WorldCompetition, string, string, int, int)`](CircuitWorld.cs.md#symbol-92e308352d2e)；[`NationalSpire.CircuitWorld.Snapshot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-77e4a21ef766)；[`NationalSpire.CoachLineups.Roster(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-e679a8998422)；[`NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-d58acd091dd3)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`NationalSpire.WorldCompetition.WorldCompetition()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Insert(int, T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CircuitWorld.AddTie(NationalSpire.WorldCompetition, string, string, int, int)`；`NationalSpire.CircuitWorld.Snapshot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.CoachLineups.Roster(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.CalendarDays`；`NationalSpire.WorldCompetition.CalendarStart`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.PrizeVersion`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldCompetition.Teams`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.AddTie(NationalSpire.WorldCompetition, string, string, int, int)`；输入表达式：`AddTie(c, rotation[i], rotation[^(i + 1)], r, day)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddTie(c, rotation[i], rotation[^(i + 1)], r, day);`
- `NationalSpire.CircuitWorld.Snapshot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`Snapshot(d, c)`；返回值紧邻使用处：`ExpressionStatementSyntax: Snapshot(d, c);`
- `NationalSpire.CoachLineups.Roster(NationalSpire.CareerData, string)`；输入表达式：`CoachLineups.Roster(d, team)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.OwnedClub?.ClubId == team ? OwnedClubSchedule.OfficialRoster(d)                  : CoachLineups.Roster(d, team)`
- `NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData)`；输入表达式：`OwnedClubSchedule.OfficialRoster(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.OwnedClub?.ClubId == team ? OwnedClubSchedule.OfficialRoster(d)                  : CoachLineups.Roster(d, team)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CalendarDays = SeasonCalendar.Length(d)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SeasonCalendar.Start(d)`
- `NationalSpire.WorldCompetition.WorldCompetition()`；输入表达式：`new WorldCompetition { Id = id, Name = nation + "俱乐部联赛", Kind = "league", Country = nation,              Season = d.Season, CalendarStart = start, CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1,              Cooperative = d.CooperativeMembers > 1, TeamEvent = true, Teams = d.Esports.Clubs.Where(t => t.Country == nation).Select(t => t.Id).ToList() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new WorldCompetition { Id = id, Name = nation + "俱乐部联赛", Kind = "league", Country = nation,              Season = d.Season, CalendarStart = start, CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1,              Cooperative = d.CooperativeMembers > 1, TeamEvent = true, Teams = d.Esports.Clubs.Where(t => t.Country == nation).Select(t => t.Id).ToList() }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Esports.Clubs.Where(t => t.Country == nation).Select(t => t.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(t => t.Country == nation).Select(t => t.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Teams.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Teams.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.Clubs.Where(t => t.Country == nation).Select(t => t.Id).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Teams = d.Esports.Clubs.Where(t => t.Country == nation).Select(t => t.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.Where(t => t.Country == nation)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(t => t.Country == nation).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`rotation.Add("")`；返回值紧邻使用处：`ExpressionStatementSyntax: rotation.Add("");`
- `System.Collections.Generic.List<T>.Insert(int, T)`；输入表达式：`rotation.Insert(1, rotation[^1])`；返回值紧邻使用处：`ExpressionStatementSyntax: rotation.Insert(1, rotation[^1]);`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`rotation.RemoveAt(rotation.Count - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: rotation.RemoveAt(rotation.Count - 1);`

**赋值（含属性/字段和局部值）：**

- `c.Rosters[team]` = `d.Esports.OwnedClub?.ClubId == team ? OwnedClubSchedule.OfficialRoster(d)                  : CoachLineups.Roster(d, team)`
- `CalendarDays` = `SeasonCalendar.Length(d)`
- `CalendarStart` = `start`
- `Cooperative` = `d.CooperativeMembers > 1`
- `Country` = `nation`
- `Id` = `id`
- `Kind` = `"league"`
- `Modern` = `true`
- `Name` = `nation + "俱乐部联赛"`
- `PrizeVersion` = `1`
- `Season` = `d.Season`
- `TeamEvent` = `true`
- `Teams` = `d.Esports.Clubs.Where(t => t.Country == nation).Select(t => t.Id).ToList()`

<a id="symbol-43c8211433d7"></a>

## `NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData) — public static void AutoEntry(CareerData d)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)；[`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CircuitWorld.AdvanceCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition, int, bool)`](CircuitWorld.cs.md#symbol-0318d361b72c)；[`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-8e4cfe18b2fe)；[`NationalSpire.Coop.CoopRules.ExecuteProposal(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-fecbe30f550e)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)

**调用：** [`NationalSpire.CircuitWorld.EnrollLeague(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-8744d18514f7)；[`NationalSpire.EsportsWorld.CanEnterMasters(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-62a2968b7960)；[`NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-b694be794ed8)；[`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；[`NationalSpire.SeasonCalendar.LeagueDeadline(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-bca858704a5e)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.AutoQualifiers`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RegistrationDeclined`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CircuitWorld.EnrollLeague(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsWorld.CanEnterMasters(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.LeagueDeadline(NationalSpire.CareerData)`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.PlayerEntered`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.EnrollLeague(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`EnrollLeague(d, league)`；返回值紧邻使用处：`ExpressionStatementSyntax: EnrollLeague(d, league);`
- `NationalSpire.EsportsWorld.CanEnterMasters(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.CanEnterMasters(d)`；返回值紧邻使用处：`IfStatementSyntax: if (EsportsWorld.CanEnterMasters(d))          {              var record = d.Matches.FirstOrDefault(m => m.Kind == "masters" && m.Day >= d.Day && m.Status == "待赛");              if (record != null) record.Registered = true;          }`
- `NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.ClearInvalidRegistrations(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: EsportsWorld.ClearInvalidRegistrations(d);`
- `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.PlayerLeague(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EsportsWorld.PlayerLeague(d)`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(d, d.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Day(d, d.Day) <= SeasonCalendar.LeagueDeadline(d)`
- `NationalSpire.SeasonCalendar.LeagueDeadline(NationalSpire.CareerData)`；输入表达式：`SeasonCalendar.LeagueDeadline(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Day(d, d.Day) <= SeasonCalendar.LeagueDeadline(d)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.FirstOrDefault(m => m.Kind == "masters" && m.Day >= d.Day && m.Status == "待赛")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Matches.FirstOrDefault(m => m.Kind == "masters" && m.Day >= d.Day && m.Status == "待赛")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.OrderBy(m => m.Day).FirstOrDefault(m => m.Kind == stage && m.Day >= d.Day && m.Status == "待赛" && !m.RegistrationDeclined)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Matches.OrderBy(m => m.Day).FirstOrDefault(m => m.Kind == stage && m.Day >= d.Day && m.Status == "待赛" && !m.RegistrationDeclined)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Matches.OrderBy(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.OrderBy(m => m.Day).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Matches.OrderBy(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.OrderBy(m => m.Day).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Matches.OrderBy(m => m.Day).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Matches = d.Matches.OrderBy(m => m.Day).ToList()`

**赋值（含属性/字段和局部值）：**

- `d.Matches` = `d.Matches.OrderBy(m => m.Day).ToList()`
- `next.Registered` = `true`
- `record.Registered` = `true`

<a id="symbol-73f52bc89477"></a>

## `NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData) — public static void EnsureOpenEvents(CareerData d)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-8e4cfe18b2fe)；[`NationalSpire.SeasonCalendar.Upgrade(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-52079aa15d28)

**调用：** [`Add(int, string, string, int, int, System.Func<NationalSpire.CareerPerson, bool>)`](CircuitWorld.cs.md#symbol-e0bbb699d364)；[`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `Add(int, string, string, int, int, System.Func<NationalSpire.CareerPerson, bool>)`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Role`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(int, string, string, int, int, System.Func<NationalSpire.CareerPerson, bool>)`；输入表达式：`Add(length, "masters", "世界纪录邀请赛", 10, 1200, p => p.MaxAscension >= 9 && !ClubCoaching.IsCoach(p))`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(length, "masters", "世界纪录邀请赛", 10, 1200, p => p.MaxAscension >= 9 && !ClubCoaching.IsCoach(p));`
- `Add(int, string, string, int, int, System.Func<NationalSpire.CareerPerson, bool>)`；输入表达式：`Add(offset + 11, "open", "赛区巡回公开赛", 7, 190, EsportsWorld.IsProfessional)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(offset + 11, "open", "赛区巡回公开赛", 7, 190, EsportsWorld.IsProfessional);`
- `Add(int, string, string, int, int, System.Func<NationalSpire.CareerPerson, bool>)`；输入表达式：`Add(offset + 3, "local", offset == 0 ? "街区周末杯" : "社区周末公开杯", 0, 45, p => p.Role == "普通玩家" && !ClubCoaching.IsCoach(p))`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(offset + 3, "local", offset == 0 ? "街区周末杯" : "社区周末公开杯", 0, 45, p => p.Role == "普通玩家" && !ClubCoaching.IsCoach(p));`
- `Add(int, string, string, int, int, System.Func<NationalSpire.CareerPerson, bool>)`；输入表达式：`Add(offset + 6, "city", "城市新秀公开赛", 3, 100, p => p.Role == "青训选手" && !ClubCoaching.IsCoach(p))`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(offset + 6, "city", "城市新秀公开赛", 3, 100, p => p.Role == "青训选手" && !ClubCoaching.IsCoach(p));`
- `Add(int, string, string, int, int, System.Func<NationalSpire.CareerPerson, bool>)`；输入表达式：`Add(offset + 9, "academy", "职业青训选拔赛", 6, 180, p => p.Role == "青训选手" && !ClubCoaching.IsCoach(p))`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(offset + 9, "academy", "职业青训选拔赛", 6, 180, p => p.Role == "青训选手" && !ClubCoaching.IsCoach(p));`
- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`ClubCoaching.IsCoach(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ClubCoaching.IsCoach(p)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SeasonCalendar.Length(d)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SeasonCalendar.Start(d)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Matches.OrderBy(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.OrderBy(m => m.Day).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Matches.OrderBy(m => m.Day).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Matches = d.Matches.OrderBy(m => m.Day).ToList()`

**赋值（含属性/字段和局部值）：**

- `d.Matches` = `d.Matches.OrderBy(m => m.Day).ToList()`
- `offset` += `14`

<a id="symbol-e0bbb699d364"></a>

## `Add(int, string, string, int, int, System.Func<NationalSpire.CareerPerson, bool>) — void Add(int day, string kind, string name, int asc, int prize, Func<CareerPerson, bool> eligible)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-73f52bc89477)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；`NationalSpire.CareerMatch.CareerMatch()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Prize`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.EsportsCareer.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + kind + absolute)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(d.WorldId + kind + absolute) % people.Count`
- `NationalSpire.CareerMatch.CareerMatch()`；输入表达式：`new() { Day = absolute, Kind = kind, Event = name, RequiredAscension = asc, Prize = prize,                  OpponentId = opponent.Id, Seed = $"NS{d.Season}-{kind}-{day}-{d.WorldId}" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Day = absolute, Kind = kind, Event = name, RequiredAscension = asc, Prize = prize,                  OpponentId = opponent.Id, Seed = $"NS{d.Season}-{kind}-{day}-{d.WorldId}" }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Any(m => m.Kind == kind && m.Day == absolute)`；返回值紧邻使用处：`BinaryExpressionSyntax: absolute < d.Day || d.Matches.Any(m => m.Kind == kind && m.Day == absolute)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`d.People.Where(p => p.Country == d.Esports.Country && eligible(p)).OrderBy(p => p.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == d.Esports.Country && eligible(p)).OrderBy(p => p.Id, StringComparer.Ordinal).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => p.Country == d.Esports.Country && eligible(p)).OrderBy(p => p.Id, StringComparer.Ordinal).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => p.Country == d.Esports.Country && eligible(p)).OrderBy(p => p.Id, StringComparer.Ordinal).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Country == d.Esports.Country && eligible(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == d.Esports.Country && eligible(p)).OrderBy`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Matches.Add(new() { Day = absolute, Kind = kind, Event = name, RequiredAscension = asc, Prize = prize,                  OpponentId = opponent.Id, Seed = $"NS{d.Season}-{kind}-{day}-{d.WorldId}" })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.Add(new() { Day = absolute, Kind = kind, Event = name, RequiredAscension = asc, Prize = prize,                  OpponentId = opponent.Id, Seed = $"NS{d.Season}-{kind}-{day}-{d.WorldId}" });`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`eligible(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Country == d.Esports.Country && eligible(p)`

**赋值（含属性/字段和局部值）：**

- `Day` = `absolute`
- `Event` = `name`
- `Kind` = `kind`
- `OpponentId` = `opponent.Id`
- `Prize` = `prize`
- `RequiredAscension` = `asc`
- `Seed` = `$"NS{d.Season}-{kind}-{day}-{d.WorldId}"`

<a id="symbol-8744d18514f7"></a>

## `NationalSpire.CircuitWorld.EnrollLeague(NationalSpire.CareerData, NationalSpire.WorldCompetition) — public static void EnrollLeague(CareerData d, WorldCompetition c)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-43c8211433d7)；[`NationalSpire.OwnedClubSchedule.Rebuild(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](OwnedClubSchedule.cs.md#symbol-def76591afef)

**调用：** [`NationalSpire.CircuitWorld.Replace(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`](CircuitWorld.cs.md#symbol-5de3ffb44c8c)；[`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-bf4a0401a0ec)；[`NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c5c2fb20bef5)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Standings`；`NationalSpire.CircuitWorld.Replace(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`；`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldCompetition.PlayerReplacedId`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Table`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.Replace(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`；输入表达式：`Replace(d, c, c.PlayerReplacedId, "player")`；返回值紧邻使用处：`ExpressionStatementSyntax: Replace(d, c, c.PlayerReplacedId, "player");`
- `NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`SchedulePlayer(d, c)`；返回值紧邻使用处：`ExpressionStatementSyntax: SchedulePlayer(d, c);`
- `NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerReserve(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: ClubCoaching.PlayerReserve(d) || c.PlayerEntered`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`c.Rosters.TryGetValue(d.Esports.ClubId, out var roster)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Rosters.TryGetValue(d.Esports.ClubId, out var roster)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`roster.Contains("player")`；返回值紧邻使用处：`ConditionalExpressionSyntax: roster.Contains("player") ? "" : roster[0]`

**赋值（含属性/字段和局部值）：**

- `c.PlayerEntered` = `true`
- `c.PlayerReplacedId` = `roster.Contains("player") ? "" : roster[0]`
- `d.Standings` = `c.Table`

<a id="symbol-713aae182e5e"></a>

## `NationalSpire.CircuitWorld.LeavePreseason(NationalSpire.CareerData) — public static void LeavePreseason(CareerData d)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)

**调用：** [`NationalSpire.CircuitWorld.Replace(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`](CircuitWorld.cs.md#symbol-5de3ffb44c8c)；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.Standings`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CircuitWorld.Replace(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldCompetition.PlayerReplacedId`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.Finished`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.Replace(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`；输入表达式：`Replace(d, c, "player", c.PlayerReplacedId)`；返回值紧邻使用处：`ExpressionStatementSyntax: Replace(d, c, "player", c.PlayerReplacedId);`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.All(f => !f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Season == d.Season && c.Modern && c.Kind == "league" && c.PlayerEntered && c.Fixtures.All(f => !f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Modern && c.Kind == "league" && c.PlayerEntered && c.Fixtures.All(f => !f.Finished))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && c.Modern && c.Kind == "league" && c.PlayerEntered && c.Fixtures.All(f => !f.Finished)))          {              if (c.PlayerReplacedId.Length > 0) Replace(d, c, "player", c.PlayerReplacedId);              c.PlayerEntered = false; c.PlayerReplacedId = "";              d.Matches.RemoveAll(m => m.CompetitionId == c.Id); d.Standings = [];          }`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Matches.RemoveAll(m => m.CompetitionId == c.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.RemoveAll(m => m.CompetitionId == c.Id);`

**赋值（含属性/字段和局部值）：**

- `c.PlayerEntered` = `false`
- `c.PlayerReplacedId` = `""`
- `d.Standings` = `[]`

<a id="symbol-77e4a21ef766"></a>

## `NationalSpire.CircuitWorld.Snapshot(NationalSpire.CareerData, NationalSpire.WorldCompetition) — private static void Snapshot(CareerData d, WorldCompetition c)`

来源：源码第 129 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`](CircuitWorld.cs.md#symbol-a4180110ef1d)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)

**调用：** [`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；[`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-4649beba59f6)；`NationalSpire.CareerStanding.CareerStanding()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldCompetition.TeamEvent`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStanding.CareerStanding()`；输入表达式：`new CareerStanding { PersonId = id }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => new CareerStanding { PersonId = id }`
- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubOf(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => EsportsWorld.ClubOf(d, id)`
- `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.CountryOf(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => EsportsWorld.CountryOf(d, id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`c.Entrants.Concat(c.Rosters.Values.SelectMany(x => x))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Entrants.Concat(c.Rosters.Values.SelectMany(x => x)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`c.Entrants.Concat(c.Rosters.Values.SelectMany(x => x)).Distinct()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Entrants.Concat(c.Rosters.Values.SelectMany(x => x)).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`c.Rosters.Values.SelectMany(x => c.Cooperative ? x.Take(1) : x).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Rosters.Values.SelectMany(x => c.Cooperative ? x.Take(1) : x).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Entrants.Select(id => new CareerStanding { PersonId = id })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Entrants.Select(id => new CareerStanding { PersonId = id }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`c.Rosters.Values.SelectMany(x => c.Cooperative ? x.Take(1) : x)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Rosters.Values.SelectMany(x => c.Cooperative ? x.Take(1) : x).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`c.Rosters.Values.SelectMany(x => x)`；返回值紧邻使用处：`ArgumentSyntax: c.Rosters.Values.SelectMany(x => x)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`x.Take(1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Cooperative ? x.Take(1) : x`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`participants.ToDictionary(id => id, id => EsportsWorld.ClubOf(d, id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantClubs = participants.ToDictionary(id => id, id => EsportsWorld.ClubOf(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`participants.ToDictionary(id => id, id => EsportsWorld.CountryOf(d, id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantCountries = participants.ToDictionary(id => id, id => EsportsWorld.CountryOf(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Entrants.Select(id => new CareerStanding { PersonId = id }).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.Table = c.Entrants.Select(id => new CareerStanding { PersonId = id }).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Rosters.Values.SelectMany(x => c.Cooperative ? x.Take(1) : x).Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.Entrants = c.Rosters.Values.SelectMany(x => c.Cooperative ? x.Take(1) : x).Distinct().ToList()`

**赋值（含属性/字段和局部值）：**

- `c.Cooperative` = `d.CooperativeMembers > 1`
- `c.EntrantClubs` = `participants.ToDictionary(id => id, id => EsportsWorld.ClubOf(d, id))`
- `c.EntrantCountries` = `participants.ToDictionary(id => id, id => EsportsWorld.CountryOf(d, id))`
- `c.Entrants` = `c.Rosters.Values.SelectMany(x => c.Cooperative ? x.Take(1) : x).Distinct().ToList()`
- `c.Table` = `c.Entrants.Select(id => new CareerStanding { PersonId = id }).ToList()`
- `PersonId` = `id`

<a id="symbol-5de3ffb44c8c"></a>

## `NationalSpire.CircuitWorld.Replace(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string) — private static void Replace(CareerData d, WorldCompetition c, string oldId, string newId)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.EnrollLeague(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-8744d18514f7)；[`NationalSpire.CircuitWorld.LeavePreseason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-713aae182e5e)

**调用：** [`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；[`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-4649beba59f6)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStanding.PersonId`；`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.HomeId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubOf(d, newId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantClubs[newId] = EsportsWorld.ClubOf(d, newId)`
- `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.CountryOf(d, newId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantCountries[newId] = EsportsWorld.CountryOf(d, newId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`c.EntrantClubs.Remove(oldId)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.EntrantClubs.Remove(oldId);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`c.EntrantCountries.Remove(oldId)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.EntrantCountries.Remove(oldId);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Table.Where(t => t.PersonId == oldId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var row in c.Table.Where(t => t.PersonId == oldId)) row.PersonId = newId;`

**赋值（含属性/字段和局部值）：**

- `c.EntrantClubs[newId]` = `EsportsWorld.ClubOf(d, newId)`
- `c.EntrantCountries[newId]` = `EsportsWorld.CountryOf(d, newId)`
- `c.Entrants[i]` = `newId`
- `f.AwayId` = `newId`
- `f.HomeId` = `newId`
- `roster[i]` = `newId`
- `row.PersonId` = `newId`

<a id="symbol-0e5325fbcfe1"></a>

## `NationalSpire.CircuitWorld.DayOf(NationalSpire.WorldCompetition, int) — private static int DayOf(WorldCompetition c, int round)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.AddRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int)`](CircuitWorld.cs.md#symbol-a8864822cc92)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.WorldCompetition.CalendarDays`；`NationalSpire.WorldCompetition.CalendarStart`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-92e308352d2e"></a>

## `NationalSpire.CircuitWorld.AddTie(NationalSpire.WorldCompetition, string, string, int, int) — private static void AddTie(WorldCompetition c, string home, string away, int round, int day)`

来源：源码第 149 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.AddRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int)`](CircuitWorld.cs.md#symbol-a8864822cc92)；[`NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`](CircuitWorld.cs.md#symbol-a4180110ef1d)

**调用：** [`NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-95620df3f1f6)；`NationalSpire.WorldFixture.WorldFixture()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.Ascension`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；输入表达式：`RoundCount(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: round == RoundCount(c)`
- `NationalSpire.WorldFixture.WorldFixture()`；输入表达式：`new() { Id = $"{c.Id}-{round}-{c.Fixtures.Count}", Day = day, Round = round,              HomeTeam = home, AwayTeam = away, HomeId = c.Rosters[home][i], AwayId = c.Rosters[away][i], Ascension = asc }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = $"{c.Id}-{round}-{c.Fixtures.Count}", Day = day, Round = round,              HomeTeam = home, AwayTeam = away, HomeId = c.Rosters[home][i], AwayId = c.Rosters[away][i], Ascension = asc }`
- `NationalSpire.WorldFixture.WorldFixture()`；输入表达式：`new() { Id = $"{c.Id}-{round}-{c.Fixtures.Count}", Day = day, Round = round, HomeId = home, AwayId = away, Ascension = asc }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = $"{c.Id}-{round}-{c.Fixtures.Count}", Day = day, Round = round, HomeId = home, AwayId = away, Ascension = asc }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Fixtures.Add(new() { Id = $"{c.Id}-{round}-{c.Fixtures.Count}", Day = day, Round = round,              HomeTeam = home, AwayTeam = away, HomeId = c.Rosters[home][i], AwayId = c.Rosters[away][i], Ascension = asc })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Fixtures.Add(new() { Id = $"{c.Id}-{round}-{c.Fixtures.Count}", Day = day, Round = round,              HomeTeam = home, AwayTeam = away, HomeId = c.Rosters[home][i], AwayId = c.Rosters[away][i], Ascension = asc });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Fixtures.Add(new() { Id = $"{c.Id}-{round}-{c.Fixtures.Count}", Day = day, Round = round, HomeId = home, AwayId = away, Ascension = asc })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Fixtures.Add(new() { Id = $"{c.Id}-{round}-{c.Fixtures.Count}", Day = day, Round = round, HomeId = home, AwayId = away, Ascension = asc });`

**赋值（含属性/字段和局部值）：**

- `Ascension` = `asc`
- `AwayId` = `away`
- `AwayId` = `c.Rosters[away][i]`
- `AwayTeam` = `away`
- `Day` = `day`
- `HomeId` = `c.Rosters[home][i]`
- `HomeId` = `home`
- `HomeTeam` = `home`
- `Id` = `$"{c.Id}-{round}-{c.Fixtures.Count}"`
- `Round` = `round`

<a id="symbol-a8864822cc92"></a>

## `NationalSpire.CircuitWorld.AddRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int) — private static void AddRound(WorldCompetition c, List<string> entrants, int round)`

来源：源码第 156 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.AdvanceCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition, int, bool)`](CircuitWorld.cs.md#symbol-0318d361b72c)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)

**调用：** [`NationalSpire.CircuitWorld.AddTie(NationalSpire.WorldCompetition, string, string, int, int)`](CircuitWorld.cs.md#symbol-92e308352d2e)；[`NationalSpire.CircuitWorld.DayOf(NationalSpire.WorldCompetition, int)`](CircuitWorld.cs.md#symbol-0e5325fbcfe1)

**字段、属性、事件及方法组引用：** `NationalSpire.CircuitWorld.AddTie(NationalSpire.WorldCompetition, string, string, int, int)`；`NationalSpire.CircuitWorld.DayOf(NationalSpire.WorldCompetition, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.AddTie(NationalSpire.WorldCompetition, string, string, int, int)`；输入表达式：`AddTie(c, entrants[i * 2], entrants[i * 2 + 1], round, DayOf(c, round))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddTie(c, entrants[i * 2], entrants[i * 2 + 1], round, DayOf(c, round));`
- `NationalSpire.CircuitWorld.DayOf(NationalSpire.WorldCompetition, int)`；输入表达式：`DayOf(c, round)`；返回值紧邻使用处：`ArgumentSyntax: DayOf(c, round)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bf4a0401a0ec"></a>

## `NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition) — public static void SchedulePlayer(CareerData d, WorldCompetition c)`

来源：源码第 160 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.AdvanceCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition, int, bool)`](CircuitWorld.cs.md#symbol-0318d361b72c)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.CircuitWorld.EnrollLeague(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-8744d18514f7)；[`NationalSpire.CircuitWorld.UpdatePlayerMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition, System.Collections.Generic.IReadOnlySet<string>)`](CircuitWorld.cs.md#symbol-550cd6bd9364)；[`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-6b77d7c9e9bf)

**调用：** [`NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`](CircuitWorld.cs.md#symbol-b35defbcdb7c)；`NationalSpire.CareerMatch.CareerMatch()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Prize`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Round`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.PrizeVersion`；`NationalSpire.WorldFixture.Ascension`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMatch.CareerMatch()`；输入表达式：`new() { CompetitionId = c.Id, FixtureId = f.Id, Round = f.Round, Day = f.Day, Kind = c.Kind,                  Event = c.Name + " · " + RoundName(c, f.Round), OpponentId = f.HomeId == "player" ? f.AwayId : f.HomeId,                  RequiredAscension = f.Ascension, Prize = c.Kind == "league" ? 260 : c.Kind == "worldfinal" ? c.PrizeVersion >= 1 ? 0 : 600 + f.Round * 200 : 400 + f.Round * 180,                  Registered = true, Seed = $"NS-{d.WorldId}-{f.Id}" }`；返回值紧邻使用处：`ArgumentSyntax: new() { CompetitionId = c.Id, FixtureId = f.Id, Round = f.Round, Day = f.Day, Kind = c.Kind,                  Event = c.Name + " · " + RoundName(c, f.Round), OpponentId = f.HomeId == "player" ? f.AwayId : f.HomeId,                  RequiredAscension = f.Ascension, Prize = c.Kind == "league" ? 260 : c.Kind == "worldfinal" ? c.PrizeVersion >= 1 ? 0 : 600 + f.Round * 200 : 400 + f.Round * 180,                  Registered = true, Seed = $"NS-{d.WorldId}-{f.Id}" }`
- `NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`；输入表达式：`RoundName(c, f.Round)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Name + " · " + RoundName(c, f.Round)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Any(m => m.FixtureId == f.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (d.Matches.Any(m => m.FixtureId == f.Id)) continue;`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Matches.OrderBy(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.OrderBy(m => m.Day).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Matches.OrderBy(m => m.Day).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Matches = d.Matches.OrderBy(m => m.Day).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => !f.Finished && (f.HomeId == "player" || f.AwayId == "player"))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var f in c.Fixtures.Where(f => !f.Finished && (f.HomeId == "player" || f.AwayId == "player")))          {              if (d.Matches.Any(m => m.FixtureId == f.Id)) continue;              d.Matches.Add(new() { CompetitionId = c.Id, FixtureId = f.Id, Round = f.Round, Day = f.Day, Kind = c.Kind,                  Event = c.Name + " · " + RoundName(c, f.Round), OpponentId = f.HomeId == "player" ? f.AwayId : f.HomeId,                  RequiredAscension = f.Ascension, Prize = c.Kind == "league" ? 260 : c.Kind == "worldfinal" ? c.PrizeVersion >= 1 ? 0 : 600 + f.Round * 200 : 400 + f.Round * 180,                  Registered = true, Seed = $"NS-{d.WorldId}-{f.Id}" });          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Matches.Add(new() { CompetitionId = c.Id, FixtureId = f.Id, Round = f.Round, Day = f.Day, Kind = c.Kind,                  Event = c.Name + " · " + RoundName(c, f.Round), OpponentId = f.HomeId == "player" ? f.AwayId : f.HomeId,                  RequiredAscension = f.Ascension, Prize = c.Kind == "league" ? 260 : c.Kind == "worldfinal" ? c.PrizeVersion >= 1 ? 0 : 600 + f.Round * 200 : 400 + f.Round * 180,                  Registered = true, Seed = $"NS-{d.WorldId}-{f.Id}" })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.Add(new() { CompetitionId = c.Id, FixtureId = f.Id, Round = f.Round, Day = f.Day, Kind = c.Kind,                  Event = c.Name + " · " + RoundName(c, f.Round), OpponentId = f.HomeId == "player" ? f.AwayId : f.HomeId,                  RequiredAscension = f.Ascension, Prize = c.Kind == "league" ? 260 : c.Kind == "worldfinal" ? c.PrizeVersion >= 1 ? 0 : 600 + f.Round * 200 : 400 + f.Round * 180,                  Registered = true, Seed = $"NS-{d.WorldId}-{f.Id}" });`

**赋值（含属性/字段和局部值）：**

- `CompetitionId` = `c.Id`
- `d.Matches` = `d.Matches.OrderBy(m => m.Day).ToList()`
- `Day` = `f.Day`
- `Event` = `c.Name + " · " + RoundName(c, f.Round)`
- `FixtureId` = `f.Id`
- `Kind` = `c.Kind`
- `OpponentId` = `f.HomeId == "player" ? f.AwayId : f.HomeId`
- `Prize` = `c.Kind == "league" ? 260 : c.Kind == "worldfinal" ? c.PrizeVersion >= 1 ? 0 : 600 + f.Round * 200 : 400 + f.Round * 180`
- `Registered` = `true`
- `RequiredAscension` = `f.Ascension`
- `Round` = `f.Round`
- `Seed` = `$"NS-{d.WorldId}-{f.Id}"`

<a id="symbol-055c6e88b6b6"></a>

## `NationalSpire.CircuitWorld.ActiveTie(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.WorldFixture>) — internal static bool ActiveTie(CareerData d, IEnumerable<WorldFixture> tie)`

来源：源码第 172 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueRosterRepair.Apply(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](LeagueRosterRepair.cs.md#symbol-fdba5c7c50e5)；[`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-ba8eef47d52c)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.FailureDecision.Result`；`NationalSpire.WorldFixture.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Any(m =>          (m.Id == d.PendingMatchId || m.Id == d.Failure?.Result.MatchId) && tie.Any(f => f.Id == m.FixtureId))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Matches.Any(m =>          (m.Id == d.PendingMatchId || m.Id == d.Failure?.Result.MatchId) && tie.Any(f => f.Id == m.FixtureId))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Any(f => f.Id == m.FixtureId)`；返回值紧邻使用处：`BinaryExpressionSyntax: (m.Id == d.PendingMatchId || m.Id == d.Failure?.Result.MatchId) && tie.Any(f => f.Id == m.FixtureId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-550cd6bd9364"></a>

## `NationalSpire.CircuitWorld.UpdatePlayerMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition, System.Collections.Generic.IReadOnlySet<string>) — internal static void UpdatePlayerMatches(CareerData d, WorldCompetition c, IReadOnlySet<string> changed)`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueRosterRepair.Apply(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](LeagueRosterRepair.cs.md#symbol-fdba5c7c50e5)；[`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-ba8eef47d52c)

**调用：** [`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-bf4a0401a0ec)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.FailureDecision.Result`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`SchedulePlayer(d, c)`；返回值紧邻使用处：`ExpressionStatementSyntax: SchedulePlayer(d, c);`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.First(f => f.Id == m.FixtureId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: c.Fixtures.First(f => f.Id == m.FixtureId) is { } f`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`changed.Contains(m.FixtureId)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.CompetitionId == c.Id && changed.Contains(m.FixtureId)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Matches.RemoveAll(m => m.CompetitionId == c.Id && changed.Contains(m.FixtureId) && m.Status == "待赛"              && m.Id != d.PendingMatchId && m.Id != d.Failure?.Result.MatchId              && c.Fixtures.First(f => f.Id == m.FixtureId) is { } f              && (f.HomeId != "player" && f.AwayId != "player" || m.OpponentId != (f.HomeId == "player" ? f.AwayId : f.HomeId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.RemoveAll(m => m.CompetitionId == c.Id && changed.Contains(m.FixtureId) && m.Status == "待赛"              && m.Id != d.PendingMatchId && m.Id != d.Failure?.Result.MatchId              && c.Fixtures.First(f => f.Id == m.FixtureId) is { } f              && (f.HomeId != "player" && f.AwayId != "player" || m.OpponentId != (f.HomeId == "player" ? f.AwayId : f.HomeId)));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0318d361b72c"></a>

## `NationalSpire.CircuitWorld.AdvanceCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition, int, bool) — public static void AdvanceCompetition(CareerData d, WorldCompetition c, int day, bool publish)`

来源：源码第 183 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool)`](EsportsWorld.cs.md#symbol-ae784907b7fa)

**调用：** [`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.CircuitWorld.AddRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int)`](CircuitWorld.cs.md#symbol-a8864822cc92)；[`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-43c8211433d7)；[`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-bf4a0401a0ec)；[`NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-ca39b3e6a0f0)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(string HomeTeam, string AwayTeam).AwayTeam`；`(string HomeTeam, string AwayTeam).HomeTeam`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CareerStanding.Wins`；`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`；`NationalSpire.CircuitWorld.AddRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int)`；`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`；`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`；`NationalSpire.WorldCompetition.ChampionId`；`NationalSpire.WorldCompetition.ChampionTeam`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`；输入表达式：`CircuitLedger.Settle(d, c, publish)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitLedger.Settle(d, c, publish);`
- `NationalSpire.CircuitWorld.AddRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int)`；输入表达式：`AddRound(c, winners, today[0].Round + 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddRound(c, winners, today[0].Round + 1);`
- `NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`；输入表达式：`AutoEntry(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: AutoEntry(d);`
- `NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`SchedulePlayer(d, c)`；返回值紧邻使用处：`ExpressionStatementSyntax: SchedulePlayer(d, c);`
- `NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`；输入表达式：`TeamTable(c)`；返回值紧邻使用处：`ElementAccessExpressionSyntax: TeamTable(c)[0]`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => !f.Finished)`；返回值紧邻使用处：`IfStatementSyntax: if (c.Fixtures.Any(f => !f.Finished)) return;`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`today.Any(f => !f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: today.Count == 0 || today.Any(f => !f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Count(f => f.WinnerId == id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => c.Fixtures.Count(f => f.WinnerId == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Count(f => f.WinnerId == f.AwayId)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Count(f => f.WinnerId == f.HomeId) > g.Count(f => f.WinnerId == f.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Count(f => f.WinnerId == f.HomeId)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Count(f => f.WinnerId == f.HomeId) > g.Count(f => f.WinnerId == f.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`c.Rosters[c.ChampionTeam].OrderByDescending(id => c.Table.FirstOrDefault(t => t.PersonId == id)?.Wins ?? 0).First()`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.ChampionId = c.Rosters[c.ChampionTeam].OrderByDescending(id => c.Table.FirstOrDefault(t => t.PersonId == id)?.Wins ?? 0).First()`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`c.Rosters[winners[0]].OrderByDescending(id => c.Fixtures.Count(f => f.WinnerId == id)).First()`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent ? c.Rosters[winners[0]].OrderByDescending(id => c.Fixtures.Count(f => f.WinnerId == id)).First() : winners[0]`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Table.FirstOrDefault(t => t.PersonId == id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Table.FirstOrDefault(t => t.PersonId == id)?.Wins`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`today.GroupBy(f => (f.HomeTeam, f.AwayTeam))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: today.GroupBy(f => (f.HomeTeam, f.AwayTeam))                  .Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Rosters[c.ChampionTeam].OrderByDescending(id => c.Table.FirstOrDefault(t => t.PersonId == id)?.Wins ?? 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Rosters[c.ChampionTeam].OrderByDescending(id => c.Table.FirstOrDefault(t => t.PersonId == id)?.Wins ?? 0).First`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Rosters[winners[0]].OrderByDescending(id => c.Fixtures.Count(f => f.WinnerId == id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Rosters[winners[0]].OrderByDescending(id => c.Fixtures.Count(f => f.WinnerId == id)).First`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`today.GroupBy(f => (f.HomeTeam, f.AwayTeam))                  .Select(g => g.Count(f => f.WinnerId == f.HomeId) > g.Count(f => f.WinnerId == f.AwayId) ? g.Key.HomeTeam : g.Key.AwayTeam)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: today.GroupBy(f => (f.HomeTeam, f.AwayTeam))                  .Select(g => g.Count(f => f.WinnerId == f.HomeId) > g.Count(f => f.WinnerId == f.AwayId) ? g.Key.HomeTeam : g.Key.AwayTeam).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`today.Select(f => f.WinnerId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: today.Select(f => f.WinnerId).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Fixtures.Where(f => f.Day == day).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.Where(f => f.Day == day).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`today.GroupBy(f => (f.HomeTeam, f.AwayTeam))                  .Select(g => g.Count(f => f.WinnerId == f.HomeId) > g.Count(f => f.WinnerId == f.AwayId) ? g.Key.HomeTeam : g.Key.AwayTeam).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent ? today.GroupBy(f => (f.HomeTeam, f.AwayTeam))                  .Select(g => g.Count(f => f.WinnerId == f.HomeId) > g.Count(f => f.WinnerId == f.AwayId) ? g.Key.HomeTeam : g.Key.AwayTeam).ToList()                  : today.Select(f => f.WinnerId).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`today.Select(f => f.WinnerId).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent ? today.GroupBy(f => (f.HomeTeam, f.AwayTeam))                  .Select(g => g.Count(f => f.WinnerId == f.HomeId) > g.Count(f => f.WinnerId == f.AwayId) ? g.Key.HomeTeam : g.Key.AwayTeam).ToList()                  : today.Select(f => f.WinnerId).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.Day == day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Day == day).ToList`

**赋值（含属性/字段和局部值）：**

- `c.ChampionId` = `c.Rosters[c.ChampionTeam].OrderByDescending(id => c.Table.FirstOrDefault(t => t.PersonId == id)?.Wins ?? 0).First()`
- `c.ChampionId` = `c.TeamEvent ? c.Rosters[winners[0]].OrderByDescending(id => c.Fixtures.Count(f => f.WinnerId == id)).First() : winners[0]`
- `c.ChampionTeam` = `c.TeamEvent ? winners[0] : ""`
- `c.ChampionTeam` = `TeamTable(c)[0].PersonId`
- `c.Finished` = `true`

<a id="symbol-cb2c18d20a39"></a>

## `NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool) — public static void CreateFinals(CareerData d, bool publish)`

来源：源码第 208 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool)`](EsportsWorld.cs.md#symbol-ae784907b7fa)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`](CircuitLedger.cs.md#symbol-73238d706495)；[`NationalSpire.CircuitWorld.AddRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int)`](CircuitWorld.cs.md#symbol-a8864822cc92)；[`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-bf4a0401a0ec)；[`NationalSpire.CircuitWorld.Snapshot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-77e4a21ef766)；[`NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-ca39b3e6a0f0)；[`NationalSpire.CoachLineups.Roster(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-e679a8998422)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-fce13966e68e)；[`NationalSpire.EsportsWorld.RatingOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3cac74060cf6)；[`NationalSpire.EsportsWorld.StageName(string)`](EsportsWorld.cs.md#symbol-c0445cae874d)；[`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；[`NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-d58acd091dd3)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`NationalSpire.WorldCompetition.WorldCompetition()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Max(int, int)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `(NationalSpire.CareerStanding Table, string Country).Country`；`(NationalSpire.CareerStanding Table, string Country).Table`；`NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.DeletedPeople`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerStanding.Clears`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CareerStanding.Points`；`NationalSpire.CareerStanding.Wins`；`NationalSpire.CircuitAward.Kind`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Place`；`NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`；`NationalSpire.CircuitWorld.AddRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int)`；`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.CircuitWorld.Snapshot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`；`NationalSpire.CoachLineups.Roster(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.BestClear`；`NationalSpire.EsportsCareer.CircuitAwards`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.NationalTeam`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.RatingOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.StageName(string)`；`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.CalendarDays`；`NationalSpire.WorldCompetition.CalendarStart`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.FortuneVersion`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldCompetition.PrizeVersion`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldCompetition.Teams`；`NationalSpire.WorldFixture.Finished`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, previousChampion)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, previousChampion) is { } defending`
- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "draw-" + d.Season, "世界大赛签表公布", (finalSeason ? "世界总决赛32位选手就位。" : "") + $"{cup.Name}公布阵容。"              + (finalSeason && final.PlayerEntered ? $"{CareerEngine.Name(d)}取得世界总决赛席位。" : "") + (cup.PlayerEntered ? $"{CareerEngine.Name(d)}入选{(kind == "worldcup" ? d.Esports.Country : EsportsWorld.ClubName(d, d.Esports.ClubId))}首发阵容。" : ""), "国际赛事", true,              finalSeason && final.PlayerEntered || cup.PlayerEntered ? ["player"] : [])`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "draw-" + d.Season, "世界大赛签表公布", (finalSeason ? "世界总决赛32位选手就位。" : "") + $"{cup.Name}公布阵容。"              + (finalSeason && final.PlayerEntered ? $"{CareerEngine.Name(d)}取得世界总决赛席位。" : "") + (cup.PlayerEntered ? $"{CareerEngine.Name(d)}入选{(kind == "worldcup" ? d.Esports.Country : EsportsWorld.ClubName(d, d.Esports.ClubId))}首发阵容。" : ""), "国际赛事", true,              finalSeason && final.PlayerEntered || cup.PlayerEntered ? ["player"] : []);`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + d.Season + id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.StableHash(d.WorldId + d.Season + id)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + d.Season + kind + id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.StableHash(d.WorldId + d.Season + kind + id)`
- `NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`；输入表达式：`CircuitLedger.Points(d, t.PersonId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t => CircuitLedger.Points(d, t.PersonId)`
- `NationalSpire.CircuitWorld.AddRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int)`；输入表达式：`AddRound(cup, cup.Teams, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddRound(cup, cup.Teams, 1);`
- `NationalSpire.CircuitWorld.AddRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int)`；输入表达式：`AddRound(final, final.Entrants, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddRound(final, final.Entrants, 1);`
- `NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`SchedulePlayer(d, cup)`；返回值紧邻使用处：`ExpressionStatementSyntax: SchedulePlayer(d, cup);`
- `NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`SchedulePlayer(d, final)`；返回值紧邻使用处：`ExpressionStatementSyntax: SchedulePlayer(d, final);`
- `NationalSpire.CircuitWorld.Snapshot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`Snapshot(d, cup)`；返回值紧邻使用处：`ExpressionStatementSyntax: Snapshot(d, cup);`
- `NationalSpire.CircuitWorld.Snapshot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`Snapshot(d, final)`；返回值紧邻使用处：`ExpressionStatementSyntax: Snapshot(d, final);`
- `NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`；输入表达式：`TeamTable(league)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: TeamTable(league).Take`
- `NationalSpire.CoachLineups.Roster(NationalSpire.CareerData, string)`；输入表达式：`CoachLineups.Roster(d, team.PersonId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.OwnedClub?.ClubId == team.PersonId ? OwnedClubSchedule.OfficialRoster(d) : CoachLineups.Roster(d, team.PersonId)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, d.Esports.ClubId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: kind == "worldcup" ? d.Esports.Country : EsportsWorld.ClubName(d, d.Esports.ClubId)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(defending)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(d, previousChampion) is { } defending && EsportsWorld.IsProfessional(defending)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.ClubId == team.PersonId && EsportsWorld.IsProfessional(p)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Country == league.Country && EsportsWorld.IsProfessional(p)`
- `NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`；输入表达式：`EsportsWorld.Ranked(c)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EsportsWorld.Ranked(c).Where`
- `NationalSpire.EsportsWorld.RatingOf(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.RatingOf(d, t.PersonId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t => EsportsWorld.RatingOf(d, t.PersonId)`
- `NationalSpire.EsportsWorld.StageName(string)`；输入表达式：`EsportsWorld.StageName(kind)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = EsportsWorld.StageName(kind)`
- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ActiveHumans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.ActiveHumans(d).Skip`
- `NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData)`；输入表达式：`OwnedClubSchedule.OfficialRoster(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.OwnedClub?.ClubId == team.PersonId ? OwnedClubSchedule.OfficialRoster(d) : CoachLineups.Roster(d, team.PersonId)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CalendarDays = SeasonCalendar.Length(d)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CalendarStart = SeasonCalendar.Start(d)`
- `NationalSpire.WorldCompetition.WorldCompetition()`；输入表达式：`new WorldCompetition { FortuneVersion = 1, Id = $"{kind}-{d.Season}", Kind = kind, Name = EsportsWorld.StageName(kind), Country = "国际", Season = d.Season, CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1, TeamEvent = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new WorldCompetition { FortuneVersion = 1, Id = $"{kind}-{d.Season}", Kind = kind, Name = EsportsWorld.StageName(kind), Country = "国际", Season = d.Season, CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1, TeamEvent = true }`
- `NationalSpire.WorldCompetition.WorldCompetition()`；输入表达式：`new WorldCompetition { FortuneVersion = 1, Id = finalId, Kind = "worldfinal", Name = "世界总决赛", Country = "国际", Season = d.Season,              CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1, Entrants = qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + id)).ToList(), PlayerEntered = qualified.Contains("player") }`；返回值紧邻使用处：`AssignmentExpressionSyntax: final ??= new WorldCompetition { FortuneVersion = 1, Id = finalId, Kind = "worldfinal", Name = "世界总决赛", Country = "国际", Season = d.Season,              CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1, Entrants = qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + id)).ToList(), PlayerEntered = qualified.Contains("player") }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.DeletedPeople.ContainsKey(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(previousChampion)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.DeletedPeople.ContainsKey(previousChampion)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(roster[i])`；返回值紧邻使用处：`BinaryExpressionSyntax: d.DeletedPeople.ContainsKey(roster[i]) && d.People.Where(p => p.ClubId == team.PersonId && EsportsWorld.IsProfessional(p) && !roster.Contains(p.Id))                          .OrderByDescending(p => p.Rating).FirstOrDefault() is { } replacement`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(t.PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.DeletedPeople.ContainsKey(t.PersonId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(x.Table.PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.DeletedPeople.ContainsKey(x.Table.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`final.Fixtures.All(f => !f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: final != null && !final.Finished && final.Fixtures.All(f => !f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Any(c => c.Season == d.Season && c.Kind is "continental" or "worldcup")`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Competitions.Any(c => c.Season == d.Season && c.Kind is "continental" or "worldcup")) return;`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`leagues.Any(c => !c.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: leagues.Count != 8 || leagues.Any(c => !c.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`leagues.Any(c => c.PlayerEntered)`；返回值紧邻使用处：`ConditionalExpressionSyntax: previousChampion == "player" ? leagues.Any(c => c.PlayerEntered) : CareerEngine.Person(d, previousChampion) is { } defending && EsportsWorld.IsProfessional(defending)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`leagues.SelectMany(c => EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2).Select(t => t.PersonId)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2).Select(t => t.PersonId)).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`qualified.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: qualified.Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`d.People.Where(p => p.ClubId == team.PersonId && EsportsWorld.IsProfessional(p) && !roster.Contains(p.Id))                          .OrderByDescending(p => p.Rating).FirstOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: d.People.Where(p => p.ClubId == team.PersonId && EsportsWorld.IsProfessional(p) && !roster.Contains(p.Id))                          .OrderByDescending(p => p.Rating).FirstOrDefault() is { } replacement`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`selection.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: selection.FirstOrDefault() == "player"`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == finalId && c.Kind == "worldfinal" && c.Season == d.Season)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.FirstOrDefault(c => c.Id == finalId && c.Kind == "worldfinal" && c.Season == d.Season)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.LastOrDefault(a => a.Kind == "worldfinal" && a.Place == "冠军")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Esports.CircuitAwards.LastOrDefault(a => a.Kind == "worldfinal" && a.Place == "冠军")?.PersonId`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cup.Teams.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + kind + id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cup.Teams.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + kind + id)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + id)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => p.ClubId == team.PersonId && EsportsWorld.IsProfessional(p) && !roster.Contains(p.Id))                          .OrderByDescending(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId == team.PersonId && EsportsWorld.IsProfessional(p) && !roster.Contains(p.Id))                          .OrderByDescending(p => p.Rating).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))                      .OrderByDescending(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))                      .OrderByDescending(p => p.Rating).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending(p => p.Rating).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending(x => x.Table.Points)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending(x => x.Table.Points).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`leagues.SelectMany(c => c.Table).OrderByDescending(t => CircuitLedger.Points(d, t.PersonId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => c.Table).OrderByDescending(t => CircuitLedger.Points(d, t.PersonId))              .ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId)))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))                      .OrderByDescending(p => p.Rating).Take(Math.Max(0, needed - selection.Count)).Select(p => p.Id)`；返回值紧邻使用处：`ArgumentSyntax: d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))                      .OrderByDescending(p => p.Rating).Take(Math.Max(0, needed - selection.Count)).Select(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending(p => p.Rating).Take(d.CooperativeMembers - 1).Select(p => p.Id)`；返回值紧邻使用处：`ArgumentSyntax: d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending(p => p.Rating).Take(d.CooperativeMembers - 1).Select(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2).Select(t => t.PersonId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2).Select(t => t.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending(x => x.Table.Points).ThenByDescending(x => x.Table.Clears).Take(d.CooperativeMembers > 1 ? 1 : 3).Select(x => x.Table.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending(x => x.Table.Points).ThenByDescending(x => x.Table.Clears).Take(d.CooperativeMembers > 1 ? 1 : 3).Select(x => x.Table.PersonId).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`leagues.SelectMany(c => c.Table).OrderByDescending(t => CircuitLedger.Points(d, t.PersonId))              .ThenByDescending(t => t.Wins).ThenByDescending(t => EsportsWorld.RatingOf(d, t.PersonId)).Select(t => t.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = leagues.SelectMany(c => c.Table).OrderByDescending(t => CircuitLedger.Points(d, t.PersonId))              .ThenByDescending(t => t.Wins).ThenByDescending(t => EsportsWorld.RatingOf(d, t.PersonId)).Select(t => t.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`leagues.SelectMany(c => c.Table)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => c.Table).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`leagues.SelectMany(c => EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2).Select(t => t.PersonId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2).Select(t => t.PersonId)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`OwnedClubs.ActiveHumans(d).Skip(1)`；返回值紧邻使用处：`ArgumentSyntax: OwnedClubs.ActiveHumans(d).Skip(1)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`candidates.Where(id => !d.DeletedPeople.ContainsKey(id) && !qualified.Contains(id)).Take(32 - qualified.Count)`；返回值紧邻使用处：`ArgumentSyntax: candidates.Where(id => !d.DeletedPeople.ContainsKey(id) && !qualified.Contains(id)).Take(32 - qualified.Count)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`current.Where(id => !roster.Contains(id)).Take(needed - roster.Count)`；返回值紧邻使用处：`ArgumentSyntax: current.Where(id => !roster.Contains(id)).Take(needed - roster.Count)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))                      .OrderByDescending(p => p.Rating).Take(Math.Max(0, needed - selection.Count))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))                      .OrderByDescending(p => p.Rating).Take(Math.Max(0, needed - selection.Count)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending(p => p.Rating).Take(d.CooperativeMembers - 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending(p => p.Rating).Take(d.CooperativeMembers - 1).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending(x => x.Table.Points).ThenByDescending(x => x.Table.Clears).Take(d.CooperativeMembers > 1 ? 1 : 3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending(x => x.Table.Points).ThenByDescending(x => x.Table.Clears).Take(d.CooperativeMembers > 1 ? 1 : 3).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`TeamTable(league).Take(2)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var team in TeamTable(league).Take(2))              {                  cup.Teams.Add(team.PersonId);                  var roster = league.Rosters[team.PersonId].ToList();                  for (int i = 0; i < roster.Count; i++)                      if (d.DeletedPeople.ContainsKey(roster[i]) && d.People.Where(p => p.ClubId == team.PersonId && EsportsWorld.IsProfessional(p) && !roster.Contains(p.Id))                          .OrderByDescending(p => p.Rating).FirstOrDefault() is { } replacement) roster[i] = replacement.Id;                  int needed = d.CooperativeMembers > 1 ? d.CooperativeMembers : 3;                  if (roster.Count < needed)                  {                      // 历史名单保留原样，只为新杯赛补入当前阵容中的缺位人员。                      var current = d.Esports.OwnedClub?.ClubId == team.PersonId ? OwnedClubSchedule.OfficialRoster(d) : CoachLineups.Roster(d, team.PersonId);                      roster.AddRange(current.Where(id => !roster.Contains(id)).Take(needed - roster.Count));                  }                  cup.Rosters[team.PersonId] = roster;              }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`cup.Teams.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + kind + id)).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: cup.Teams = cup.Teams.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + kind + id)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Modern && c.Kind == "league").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.Where(c => c.Season == d.Season && c.Modern && c.Kind == "league").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`league.Rosters[team.PersonId].ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = league.Rosters[team.PersonId].ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending(x => x.Table.Points).ThenByDescending(x => x.Table.Clears).Take(d.CooperativeMembers > 1 ? 1 : 3).Select(x => x.Table.PersonId).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending(x => x.Table.Points).ThenByDescending(x => x.Table.Clears).Take(d.CooperativeMembers > 1 ? 1 : 3).Select(x => x.Table.PersonId).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`leagues.SelectMany(c => EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2).Select(t => t.PersonId)).Distinct().ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = leagues.SelectMany(c => EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take(2).Select(t => t.PersonId)).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`qualified.Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: qualified = qualified.Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + id)).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Entrants = qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + id)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(id => !d.DeletedPeople.ContainsKey(id) && !qualified.Contains(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(id => !d.DeletedPeople.ContainsKey(id) && !qualified.Contains(id)).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`current.Where(id => !roster.Contains(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: current.Where(id => !roster.Contains(id)).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Modern && c.Kind == "league")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && c.Modern && c.Kind == "league").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.ClubId == team.PersonId && EsportsWorld.IsProfessional(p) && !roster.Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId == team.PersonId && EsportsWorld.IsProfessional(p) && !roster.Contains(p.Id))                          .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))                      .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EsportsWorld.Ranked(c).Where(t => !d.DeletedPeople.ContainsKey(t.PersonId)).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.EntrantCountries.GetValueOrDefault(t.PersonId)`；返回值紧邻使用处：`ArgumentSyntax: Country: c.EntrantCountries.GetValueOrDefault(t.PersonId)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`cup.Teams.Add(league.Country)`；返回值紧邻使用处：`ExpressionStatementSyntax: cup.Teams.Add(league.Country);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`cup.Teams.Add(team.PersonId)`；返回值紧邻使用处：`ExpressionStatementSyntax: cup.Teams.Add(team.PersonId);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Competitions.Add(cup)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Competitions.Add(cup);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Competitions.Add(final)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Competitions.Add(final);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`qualified.Add(previousChampion)`；返回值紧邻使用处：`ExpressionStatementSyntax: qualified.Add(previousChampion);`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`qualified.AddRange(candidates.Where(id => !d.DeletedPeople.ContainsKey(id) && !qualified.Contains(id)).Take(32 - qualified.Count))`；返回值紧邻使用处：`ExpressionStatementSyntax: qualified.AddRange(candidates.Where(id => !d.DeletedPeople.ContainsKey(id) && !qualified.Contains(id)).Take(32 - qualified.Count));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`roster.AddRange(current.Where(id => !roster.Contains(id)).Take(needed - roster.Count))`；返回值紧邻使用处：`ExpressionStatementSyntax: roster.AddRange(current.Where(id => !roster.Contains(id)).Take(needed - roster.Count));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`selection.AddRange(d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))                      .OrderByDescending(p => p.Rating).Take(Math.Max(0, needed - selection.Count)).Select(p => p.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: selection.AddRange(d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id) && !selection.Contains(p.Id))                      .OrderByDescending(p => p.Rating).Take(Math.Max(0, needed - selection.Count)).Select(p => p.Id));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`selection.AddRange(d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending(p => p.Rating).Take(d.CooperativeMembers - 1).Select(p => p.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: selection.AddRange(d.People.Where(p => p.Country == league.Country && EsportsWorld.IsProfessional(p) && p.Id != selection[0] && !d.HumanIds.Contains(p.Id)).OrderByDescending(p => p.Rating).Take(d.CooperativeMembers - 1).Select(p => p.Id));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`selection.AddRange(OwnedClubs.ActiveHumans(d).Skip(1))`；返回值紧邻使用处：`ExpressionStatementSyntax: selection.AddRange(OwnedClubs.ActiveHumans(d).Skip(1));`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`cup.Entrants.Contains("player")`；返回值紧邻使用处：`AssignmentExpressionSyntax: cup.PlayerEntered = cup.Entrants.Contains("player")`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(p.Id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`qualified.Contains("player")`；返回值紧邻使用处：`AssignmentExpressionSyntax: PlayerEntered = qualified.Contains("player")`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`qualified.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !qualified.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`roster.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !roster.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`roster.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !roster.Contains(p.Id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`selection.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !selection.Contains(p.Id)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Esports.Competitions.RemoveAll(c => c != final && c.Id == finalId && c.Kind == "worldfinal" && c.Season == d.Season                  && System.Text.Json.JsonSerializer.Serialize(c) == saved)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Competitions.RemoveAll(c => c != final && c.Id == finalId && c.Kind == "worldfinal" && c.Season == d.Season                  && System.Text.Json.JsonSerializer.Serialize(c) == saved);`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending(x => x.Table.Points).ThenByDescending(x => x.Table.Clears)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => c.Table.Select(t => (Table: t, Country: c.EntrantCountries.GetValueOrDefault(t.PersonId))))                      .Where(x => x.Country == league.Country && !d.DeletedPeople.ContainsKey(x.Table.PersonId) && (x.Table.PersonId != "player" || d.Esports.BestClear >= 8))                      .OrderByDescending(x => x.Table.Points).ThenByDescending(x => x.Table.Clears).Take`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`leagues.SelectMany(c => c.Table).OrderByDescending(t => CircuitLedger.Points(d, t.PersonId))              .ThenByDescending(t => t.Wins).ThenByDescending(t => EsportsWorld.RatingOf(d, t.PersonId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => c.Table).OrderByDescending(t => CircuitLedger.Points(d, t.PersonId))              .ThenByDescending(t => t.Wins).ThenByDescending(t => EsportsWorld.RatingOf(d, t.PersonId)).Select`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`leagues.SelectMany(c => c.Table).OrderByDescending(t => CircuitLedger.Points(d, t.PersonId))              .ThenByDescending(t => t.Wins)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: leagues.SelectMany(c => c.Table).OrderByDescending(t => CircuitLedger.Points(d, t.PersonId))              .ThenByDescending(t => t.Wins).ThenByDescending`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, needed - selection.Count)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, needed - selection.Count)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: System.Text.Json.JsonSerializer.Serialize(c) == saved`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(final)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Text.Json.JsonSerializer.Serialize(final)`

**赋值（含属性/字段和局部值）：**

- `CalendarDays` = `SeasonCalendar.Length(d)`
- `CalendarStart` = `SeasonCalendar.Start(d)`
- `Country` = `"国际"`
- `cup.PlayerEntered` = `cup.Entrants.Contains("player")`
- `cup.Rosters[league.Country]` = `selection`
- `cup.Rosters[team.PersonId]` = `roster`
- `cup.Teams` = `cup.Teams.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + kind + id)).ToList()`
- `d.Esports.NationalTeam` = `kind == "worldcup" && cup.PlayerEntered`
- `Entrants` = `qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + id)).ToList()`
- `final` ??= `new WorldCompetition { FortuneVersion = 1, Id = finalId, Kind = "worldfinal", Name = "世界总决赛", Country = "国际", Season = d.Season,              CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d), Modern = true, PrizeVersion = 1, Entrants = qualified.OrderBy(id => CareerEngine.StableHash(d.WorldId + d.Season + id)).ToList(), PlayerEntered = qualified.Contains("player") }`
- `FortuneVersion` = `1`
- `Id` = `$"{kind}-{d.Season}"`
- `Id` = `finalId`
- `Kind` = `"worldfinal"`
- `Kind` = `kind`
- `Modern` = `true`
- `Name` = `"世界总决赛"`
- `Name` = `EsportsWorld.StageName(kind)`
- `PlayerEntered` = `qualified.Contains("player")`
- `PrizeVersion` = `1`
- `qualified` = `qualified.Distinct().ToList()`
- `roster[i]` = `replacement.Id`
- `Season` = `d.Season`
- `TeamEvent` = `true`

<a id="symbol-561246434113"></a>

## `NationalSpire.CircuitWorld.ReplayTie(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static bool ReplayTie(CareerData d, CareerMatch m)`

来源：源码第 284 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.MatchRules.RandomizeSeed(string, string, int)`](MatchRules.cs.md#symbol-287afca401f9)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.PendingSince`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Decider`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.PlayerSeconds`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerMatch.SeedRandomized`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.MatchRules.RandomizeSeed(string, string, int)`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Modern`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.MatchRules.RandomizeSeed(string, string, int)`；输入表达式：`MatchRules.RandomizeSeed(m.Seed)`；返回值紧邻使用处：`AssignmentExpressionSyntax: m.Seed = MatchRules.RandomizeSeed(m.Seed)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)?.Modern`

**赋值（含属性/字段和局部值）：**

- `d.PendingMatchId` = `null`
- `d.PendingSince` = `0`
- `m.Decider` = `"上一局双方成绩相同，本场更换种子加赛。"`
- `m.Draw` = `false`
- `m.OpponentPrepared` = `false`
- `m.OpponentSeconds` = `null`
- `m.PlayerSeconds` = `null`
- `m.Seed` = `MatchRules.RandomizeSeed(m.Seed)`
- `m.SeedRandomized` = `true`

<a id="symbol-4d6f1758c06b"></a>

## `NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string) — public static List<CareerPerson> CooperativeRoster(CareerData d, WorldCompetition? c, string leaderId, string seed)`

来源：源码第 291 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerAudience.cs.md#symbol-889a215412c7)；[`NationalSpire.CircuitWorld.CooperativePerformance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int?)`](CircuitWorld.cs.md#symbol-72dc5f2576da)；[`NationalSpire.CommentatorSelection.Participants(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`](CommentatorSelection.cs.md#symbol-e47ee769b462)；[`NationalSpire.Coop.CoopRules.Opponents(NationalSpire.Coop.CoopWorld, NationalSpire.CareerMatch)`](Coop/CoopRules.cs.md#symbol-ddfb352cda97)；[`NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`](EsportsWorld.cs.md#symbol-f16aef3da82a)；[`NationalSpire.MatchRules.TeamChance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int, int)`](MatchRules.cs.md#symbol-bd837370982f)；[`NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`](SeasonCeremony.cs.md#symbol-c038c48114b1)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Abs(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.DeletedPeople`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Rosters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.Person(d, id)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, leaderId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(d, leaderId) ?? throw new InvalidOperationException("对手不存在。")`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(seed + p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerEngine.StableHash(seed + p.Id)`
- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`ClubCoaching.IsCoach(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ClubCoaching.IsCoach(p)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.ClubId == leader.ClubId && EsportsWorld.IsProfessional(p)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.DeletedPeople.ContainsKey(id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { leader }.Concat(pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy(p => CareerEngine.StableHash(seed + p.Id)).Take(d.CooperativeMembers - 1))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { leader }.Concat(pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy(p => CareerEngine.StableHash(seed + p.Id)).Take(d.CooperativeMembers - 1)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { leaderId }.Concat(official)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { leaderId }.Concat(official).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`new[] { leaderId }.Concat(official).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { leaderId }.Concat(official).Distinct().Where`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Rosters.Values.FirstOrDefault(r => r.Contains(leaderId))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c?.Rosters.Values.FirstOrDefault(r => r.Contains(leaderId))`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")                  .Select(id => CareerEngine.Person(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")                  .Select(id => CareerEngine.Person(d, id)).OfType<CareerPerson>`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")                  .Select(id => CareerEngine.Person(d, id)).OfType<CareerPerson>().Take(d.CooperativeMembers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")                  .Select(id => CareerEngine.Person(d, id)).OfType<CareerPerson>().Take(d.CooperativeMembers).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy(p => CareerEngine.StableHash(seed + p.Id)).Take(d.CooperativeMembers - 1)`；返回值紧邻使用处：`ArgumentSyntax: pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy(p => CareerEngine.StableHash(seed + p.Id)).Take(d.CooperativeMembers - 1)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`new[] { leader }.Concat(pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy(p => CareerEngine.StableHash(seed + p.Id)).Take(d.CooperativeMembers - 1)).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return new[] { leader }.Concat(pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy(p => CareerEngine.StableHash(seed + p.Id)).Take(d.CooperativeMembers - 1)).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")                  .Select(id => CareerEngine.Person(d, id)).OfType<CareerPerson>().Take(d.CooperativeMembers).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")                  .Select(id => CareerEngine.Person(d, id)).OfType<CareerPerson>().Take(d.CooperativeMembers).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Id != leaderId && !d.HumanIds.Contains(p.Id) && p.Country == leader.Country && !ClubCoaching.IsCoach(p))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => p.Id != leaderId && !d.HumanIds.Contains(p.Id) && p.Country == leader.Country && !ClubCoaching.IsCoach(p))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")                  .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(EsportsWorld.IsProfessional)`；返回值紧邻使用处：`AssignmentExpressionSyntax: pool = pool.Where(EsportsWorld.IsProfessional)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(p => p.ClubId == leader.ClubId && EsportsWorld.IsProfessional(p))`；返回值紧邻使用处：`AssignmentExpressionSyntax: pool = pool.Where(p => p.ClubId == leader.ClubId && EsportsWorld.IsProfessional(p))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(p.Id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`r.Contains(leaderId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => r.Contains(leaderId)`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")                  .Select(id => CareerEngine.Person(d, id)).OfType<CareerPerson>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { leaderId }.Concat(official).Distinct().Where(id => !d.DeletedPeople.ContainsKey(id) && !d.HumanIds.Contains(id) && id != "player")                  .Select(id => CareerEngine.Person(d, id)).OfType<CareerPerson>().Take`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("对手不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("对手不存在。")`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy(p => CareerEngine.StableHash(seed + p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.OrderBy(p => Math.Abs(p.MaxAscension - leader.MaxAscension)).ThenBy(p => CareerEngine.StableHash(seed + p.Id)).Take`
- `System.Math.Abs(int)`；输入表达式：`Math.Abs(p.MaxAscension - leader.MaxAscension)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Math.Abs(p.MaxAscension - leader.MaxAscension)`

**赋值（含属性/字段和局部值）：**

- `pool` = `pool.Where(EsportsWorld.IsProfessional)`
- `pool` = `pool.Where(p => p.ClubId == leader.ClubId && EsportsWorld.IsProfessional(p))`

<a id="symbol-dd22ca4c2081"></a>

## `NationalSpire.CircuitWorld.EnsureHumanRosters(NationalSpire.CareerData) — public static void EnsureHumanRosters(CareerData d)`

来源：源码第 306 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.SetParticipants(NationalSpire.Coop.CoopWorld, System.Collections.Generic.IReadOnlySet<ulong>)`](Coop/CoopParticipants.cs.md#symbol-bc80580d2b20)

**调用：** [`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；[`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-4649beba59f6)；[`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.TeamEvent`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubOf(d, id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantClubs[id] = EsportsWorld.ClubOf(d, id)`
- `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.CountryOf(d, id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantCountries[id] = EsportsWorld.CountryOf(d, id)`
- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ActiveHumans(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.ActiveHumans(d)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Rosters.Where(pair => pair.Value.Contains("player")).Select(pair => pair.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Rosters.Where(pair => pair.Value.Contains("player")).Select(pair => pair.Key).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`active.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.Rosters[team] = active.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Rosters.Where(pair => pair.Value.Contains("player")).Select(pair => pair.Key).ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string team in c.Rosters.Where(pair => pair.Value.Contains("player")).Select(pair => pair.Key).ToList())          {              c.Rosters[team] = active.ToList();              foreach (string id in c.Rosters[team])              { c.EntrantCountries[id] = EsportsWorld.CountryOf(d, id); c.EntrantClubs[id] = EsportsWorld.ClubOf(d, id); }          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Rosters.Where(pair => pair.Value.Contains("player"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Rosters.Where(pair => pair.Value.Contains("player")).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Cooperative && c.TeamEvent && !c.Finished)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && c.Cooperative && c.TeamEvent && !c.Finished))          foreach (string team in c.Rosters.Where(pair => pair.Value.Contains("player")).Select(pair => pair.Key).ToList())          {              c.Rosters[team] = active.ToList();              foreach (string id in c.Rosters[team])              { c.EntrantCountries[id] = EsportsWorld.CountryOf(d, id); c.EntrantClubs[id] = EsportsWorld.ClubOf(d, id); }          }`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`pair.Value.Contains("player")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: pair => pair.Value.Contains("player")`

**赋值（含属性/字段和局部值）：**

- `c.EntrantClubs[id]` = `EsportsWorld.ClubOf(d, id)`
- `c.EntrantCountries[id]` = `EsportsWorld.CountryOf(d, id)`
- `c.Rosters[team]` = `active.ToList()`

<a id="symbol-72dc5f2576da"></a>

## `NationalSpire.CircuitWorld.CooperativePerformance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int?) — public static CareerPerson CooperativePerformance(CareerData d, WorldCompetition? c, string id, string seed, int? day = null)`

来源：源码第 318 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`](MatchRules.cs.md#symbol-8fd1cedc82b2)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`](CareerTraining.cs.md#symbol-cd61283f2c46)；[`NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`](CircuitWorld.cs.md#symbol-4d6f1758c06b)；`NationalSpire.CareerPerson.CareerPerson()`；`NationalSpire.NpcLearning.NpcLearning()`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；`System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArbitrationRecord.Sanction`；`NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Arbitrations`；`NationalSpire.CareerPerson.Form`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Learning`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；`NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.NpcLearning.ChanceShift`；`NationalSpire.NpcLearning.MoodAggregated`；`NationalSpire.NpcLearning.MoodDay`；`NationalSpire.NpcLearning.MoodStrength`；`NationalSpire.NpcLearning.MoodUntil`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson { Id = id, Arbitrations = roster.SelectMany(p => p.Arbitrations).Where(r => r.Sanction is "禁赛" or "封号").ToList(), Rating = (int)roster.Average(p => p.Rating), MaxAscension = (int)Math.Round(roster.Average(p => p.MaxAscension)),              Learning = new() { MoodAggregated = true, ChanceShift = roster.Average(p => p.Learning.ChanceShift), MoodStrength = roster.Average(p => CareerTraining.MoodLevel(p, day ?? d.Day)), MoodDay = day ?? d.Day, MoodUntil = (day ?? d.Day) + 1 },              Form = roster[0].Form, Role = roster.All(EsportsWorld.IsProfessional) ? "职业选手" : "普通玩家" }`；返回值紧邻使用处：`ReturnStatementSyntax: return new CareerPerson { Id = id, Arbitrations = roster.SelectMany(p => p.Arbitrations).Where(r => r.Sanction is "禁赛" or "封号").ToList(), Rating = (int)roster.Average(p => p.Rating), MaxAscension = (int)Math.Round(roster.Average(p => p.MaxAscension)),              Learning = new() { MoodAggregated = true, ChanceShift = roster.Average(p => p.Learning.ChanceShift), MoodStrength = roster.Average(p => CareerTraining.MoodLevel(p, day ?? d.Day)), MoodDay = day ?? d.Day, MoodUntil = (day ?? d.Day) + 1 },              Form = roster[0].Form, Role = roster.All(EsportsWorld.IsProfessional) ? "职业选手" : "普通玩家" };`
- `NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；输入表达式：`CareerTraining.MoodLevel(p, day ?? d.Day)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerTraining.MoodLevel(p, day ?? d.Day)`
- `NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`；输入表达式：`CooperativeRoster(d, c, id, seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CooperativeRoster(d, c, id, seed)`
- `NationalSpire.NpcLearning.NpcLearning()`；输入表达式：`new() { MoodAggregated = true, ChanceShift = roster.Average(p => p.Learning.ChanceShift), MoodStrength = roster.Average(p => CareerTraining.MoodLevel(p, day ?? d.Day)), MoodDay = day ?? d.Day, MoodUntil = (day ?? d.Day) + 1 }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Learning = new() { MoodAggregated = true, ChanceShift = roster.Average(p => p.Learning.ChanceShift), MoodStrength = roster.Average(p => CareerTraining.MoodLevel(p, day ?? d.Day)), MoodDay = day ?? d.Day, MoodUntil = (day ?? d.Day) + 1 }`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`roster.All(EsportsWorld.IsProfessional)`；返回值紧邻使用处：`ConditionalExpressionSyntax: roster.All(EsportsWorld.IsProfessional) ? "职业选手" : "普通玩家"`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`roster.Average(p => CareerTraining.MoodLevel(p, day ?? d.Day))`；返回值紧邻使用处：`AssignmentExpressionSyntax: MoodStrength = roster.Average(p => CareerTraining.MoodLevel(p, day ?? d.Day))`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`roster.Average(p => p.Learning.ChanceShift)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ChanceShift = roster.Average(p => p.Learning.ChanceShift)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, int>)`；输入表达式：`roster.Average(p => p.MaxAscension)`；返回值紧邻使用处：`ArgumentSyntax: roster.Average(p => p.MaxAscension)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, int>)`；输入表达式：`roster.Average(p => p.Rating)`；返回值紧邻使用处：`CastExpressionSyntax: (int)roster.Average(p => p.Rating)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`roster.SelectMany(p => p.Arbitrations)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: roster.SelectMany(p => p.Arbitrations).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`roster.SelectMany(p => p.Arbitrations).Where(r => r.Sanction is "禁赛" or "封号").ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Arbitrations = roster.SelectMany(p => p.Arbitrations).Where(r => r.Sanction is "禁赛" or "封号").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`roster.SelectMany(p => p.Arbitrations).Where(r => r.Sanction is "禁赛" or "封号")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: roster.SelectMany(p => p.Arbitrations).Where(r => r.Sanction is "禁赛" or "封号").ToList`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("对手队伍人数不足。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("对手队伍人数不足。");`
- `System.Math.Round(double)`；输入表达式：`Math.Round(roster.Average(p => p.MaxAscension))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(roster.Average(p => p.MaxAscension))`

**赋值（含属性/字段和局部值）：**

- `Arbitrations` = `roster.SelectMany(p => p.Arbitrations).Where(r => r.Sanction is "禁赛" or "封号").ToList()`
- `ChanceShift` = `roster.Average(p => p.Learning.ChanceShift)`
- `Form` = `roster[0].Form`
- `Id` = `id`
- `Learning` = `new() { MoodAggregated = true, ChanceShift = roster.Average(p => p.Learning.ChanceShift), MoodStrength = roster.Average(p => CareerTraining.MoodLevel(p, day ?? d.Day)), MoodDay = day ?? d.Day, MoodUntil = (day ?? d.Day) + 1 }`
- `MaxAscension` = `(int)Math.Round(roster.Average(p => p.MaxAscension))`
- `MoodAggregated` = `true`
- `MoodDay` = `day ?? d.Day`
- `MoodStrength` = `roster.Average(p => CareerTraining.MoodLevel(p, day ?? d.Day))`
- `MoodUntil` = `(day ?? d.Day) + 1`
- `Rating` = `(int)roster.Average(p => p.Rating)`
- `Role` = `roster.All(EsportsWorld.IsProfessional) ? "职业选手" : "普通玩家"`
