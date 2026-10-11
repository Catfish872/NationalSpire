# OwnedClubSchedule.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`E75CFEF8AD2F06C88D9AAD6288836C9AA134113F9C413E02C9450F9F69A18F4E`。来源：[源码](../../OwnedClubSchedule.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OwnedClubSchedule`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-e637b6152d8b"></a>

## `NationalSpire.OwnedClubSchedule.Join(NationalSpire.CareerData, string?) — public static void Join(CareerData d, string? previousRegion = null)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)

**调用：** [`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；[`NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-9b2deafefa7e)；[`NationalSpire.OwnedClubSchedule.Rebuild(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](OwnedClubSchedule.cs.md#symbol-def76591afef)；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData)`；`NationalSpire.OwnedClubSchedule.Rebuild(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.OwnedClubState.PreviousLeague`；`NationalSpire.OwnedClubState.PreviousMatches`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.PlayerLeague(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.PlayerLeague(d) ?? throw new InvalidOperationException("本季联赛不存在。")`
- `NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanJoinThisSeason(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.CanJoinThisSeason(d)`
- `NationalSpire.OwnedClubSchedule.Rebuild(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`Rebuild(d, new[] { old.Country, previousRegion ?? old.Country })`；返回值紧邻使用处：`ExpressionStatementSyntax: Rebuild(d, new[] { old.Country, previousRegion ?? old.Country });`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Matches.Where(m => m.CompetitionId == old.Id).ToList()`；返回值紧邻使用处：`ArgumentSyntax: d.Matches.Where(m => m.CompetitionId == old.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => m.CompetitionId == old.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.Where(m => m.CompetitionId == old.Id).ToList`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("本季联赛不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("本季联赛不存在。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("联赛已经开始，不能创建俱乐部。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("联赛已经开始，不能创建俱乐部。");`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Deserialize<List<CareerMatch>>(System.Text.Json.JsonSerializer.Serialize(d.Matches.Where(m => m.CompetitionId == old.Id).ToList()))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: System.Text.Json.JsonSerializer.Deserialize<List<CareerMatch>>(System.Text.Json.JsonSerializer.Serialize(d.Matches.Where(m => m.CompetitionId == old.Id).ToList()))!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(d.Matches.Where(m => m.CompetitionId == old.Id).ToList())`；返回值紧邻使用处：`ArgumentSyntax: System.Text.Json.JsonSerializer.Serialize(d.Matches.Where(m => m.CompetitionId == old.Id).ToList())`

**赋值（含属性/字段和局部值）：**

- `own.PreviousLeague` = `old`
- `own.PreviousMatches` = `System.Text.Json.JsonSerializer.Deserialize<List<CareerMatch>>(System.Text.Json.JsonSerializer.Serialize(d.Matches.Where(m => m.CompetitionId == old.Id).ToList()))!`

<a id="symbol-def76591afef"></a>

## `NationalSpire.OwnedClubSchedule.Rebuild(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>) — private static void Rebuild(CareerData d, IEnumerable<string> regions)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubSchedule.ChangeRegion(NationalSpire.CareerData, string)`](OwnedClubSchedule.cs.md#symbol-b24bb65463ab)；[`NationalSpire.OwnedClubSchedule.Join(NationalSpire.CareerData, string?)`](OwnedClubSchedule.cs.md#symbol-e637b6152d8b)

**调用：** [`NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`](CircuitWorld.cs.md#symbol-a4180110ef1d)；[`NationalSpire.CircuitWorld.EnrollLeague(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-8744d18514f7)；[`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`；`NationalSpire.CircuitWorld.EnrollLeague(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`；输入表达式：`CircuitWorld.BuildLeague(d, region, $"league-{d.Season}-{region}-expanded")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CircuitWorld.BuildLeague(d, region, $"league-{d.Season}-{region}-expanded")`
- `NationalSpire.CircuitWorld.EnrollLeague(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`CircuitWorld.EnrollLeague(d, EsportsWorld.PlayerLeague(d)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.EnrollLeague(d, EsportsWorld.PlayerLeague(d)!);`
- `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.PlayerLeague(d)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: EsportsWorld.PlayerLeague(d)!`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`regions.Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string region in regions.Distinct())          {              var old = d.Esports.Competitions.Single(c => c.Season == d.Season && c.Kind == "league" && c.Country == region);              d.Matches.RemoveAll(m => m.CompetitionId == old.Id);              var league = CircuitWorld.BuildLeague(d, region, $"league-{d.Season}-{region}-expanded");              d.Esports.Competitions[d.Esports.Competitions.IndexOf(old)] = league;          }`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Single(c => c.Season == d.Season && c.Kind == "league" && c.Country == region)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.Single(c => c.Season == d.Season && c.Kind == "league" && c.Country == region)`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`d.Esports.Competitions.IndexOf(old)`；返回值紧邻使用处：`ArgumentSyntax: d.Esports.Competitions.IndexOf(old)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Matches.RemoveAll(m => m.CompetitionId == old.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.RemoveAll(m => m.CompetitionId == old.Id);`

**赋值（含属性/字段和局部值）：**

- `d.Esports.Competitions[d.Esports.Competitions.IndexOf(old)]` = `league`

<a id="symbol-b24bb65463ab"></a>

## `NationalSpire.OwnedClubSchedule.ChangeRegion(NationalSpire.CareerData, string) — public static string? ChangeRegion(CareerData d, string region)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-9b2deafefa7e)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubSchedule.Rebuild(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](OwnedClubSchedule.cs.md#symbol-def76591afef)；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Country`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Standings`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubSchedule.Rebuild(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.NextRegion`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(copy, own.ClubId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: EsportsWorld.Club(copy, own.ClubId)!`
- `NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanJoinThisSeason(copy)`；返回值紧邻使用处：`IfStatementSyntax: if (OwnedClubs.CanJoinThisSeason(copy))          {              string previous = club.Country;              club.Country = region; own.NextRegion = "";              Rebuild(copy, new[] { previous, region });          }          else own.NextRegion = region;`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.IsOwner(d)`
- `NationalSpire.OwnedClubSchedule.Rebuild(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`Rebuild(copy, new[] { previous, region })`；返回值紧邻使用处：`ExpressionStatementSyntax: Rebuild(copy, new[] { previous, region });`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`EsportsWorld.Countries.Contains(region)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !EsportsWorld.Countries.Contains(region)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Deserialize<CareerData>(System.Text.Json.JsonSerializer.Serialize(d))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: System.Text.Json.JsonSerializer.Deserialize<CareerData>(System.Text.Json.JsonSerializer.Serialize(d))!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(d)`；返回值紧邻使用处：`ArgumentSyntax: System.Text.Json.JsonSerializer.Serialize(d)`

**赋值（含属性/字段和局部值）：**

- `(d.Esports, d.Matches, d.Standings)` = `original`
- `club.Country` = `region`
- `d.Esports` = `copy.Esports`
- `d.Matches` = `copy.Matches`
- `d.Standings` = `copy.Standings`
- `own.NextRegion` = `""`
- `own.NextRegion` = `region`

<a id="symbol-f50b11cb9486"></a>

## `NationalSpire.OwnedClubSchedule.ApplyNextRegion(NationalSpire.CareerData) — public static void ApplyNextRegion(CareerData d)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-8e4cfe18b2fe)

**调用：** [`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Country`；`NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.NextRegion`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, own.ClubId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, own.ClubId) is { } club`

**赋值（含属性/字段和局部值）：**

- `club.Country` = `own.NextRegion`
- `own.NextRegion` = `""`

<a id="symbol-d58acd091dd3"></a>

## `NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData) — public static List<string> OfficialRoster(CareerData d)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`](CircuitWorld.cs.md#symbol-a4180110ef1d)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.LeagueRosterRepair.Apply(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](LeagueRosterRepair.cs.md#symbol-fdba5c7c50e5)；[`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-ba8eef47d52c)

**调用：** [`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ManagerId`；`NationalSpire.OwnedClubState.Starters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ActiveHumans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.ActiveHumans(d).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "player" }.Concat(OwnedClubs.ActiveHumans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId ?? d.HumanIds.FirstOrDefault())))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { "player" }.Concat(OwnedClubs.ActiveHumans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId ?? d.HumanIds.FirstOrDefault()))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`d.HumanIds.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.OwnedClub?.ManagerId ?? d.HumanIds.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.OwnedClub!.Starters.ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.CooperativeMembers > 1          ? new[] { "player" }.Concat(OwnedClubs.ActiveHumans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId ?? d.HumanIds.FirstOrDefault()))).ToList()          : d.Esports.OwnedClub!.Starters.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`new[] { "player" }.Concat(OwnedClubs.ActiveHumans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId ?? d.HumanIds.FirstOrDefault()))).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.CooperativeMembers > 1          ? new[] { "player" }.Concat(OwnedClubs.ActiveHumans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId ?? d.HumanIds.FirstOrDefault()))).ToList()          : d.Esports.OwnedClub!.Starters.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`OwnedClubs.ActiveHumans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId ?? d.HumanIds.FirstOrDefault()))`；返回值紧邻使用处：`ArgumentSyntax: OwnedClubs.ActiveHumans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId ?? d.HumanIds.FirstOrDefault()))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ba8eef47d52c"></a>

## `NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData) — public static void UpdateLineup(CareerData d)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`](CharacterDeletion.cs.md#symbol-c88a1645b627)；[`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-bad0a27b1a6b)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)

**调用：** [`NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData)`](CharacterDeletion.cs.md#symbol-a8f554428afa)；[`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`](CharacterDeletion.cs.md#symbol-c88a1645b627)；[`NationalSpire.CircuitWorld.ActiveTie(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.WorldFixture>)`](CircuitWorld.cs.md#symbol-055c6e88b6b6)；[`NationalSpire.CircuitWorld.UpdatePlayerMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition, System.Collections.Generic.IReadOnlySet<string>)`](CircuitWorld.cs.md#symbol-550cd6bd9364)；[`NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-d58acd091dd3)；`NationalSpire.CareerStanding.CareerStanding()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData)`；`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`；`NationalSpire.CircuitWorld.ActiveTie(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.WorldFixture>)`；`NationalSpire.CircuitWorld.UpdatePlayerMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition, System.Collections.Generic.IReadOnlySet<string>)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStanding.CareerStanding()`；输入表达式：`new() { PersonId = id }`；返回值紧邻使用处：`ArgumentSyntax: new() { PersonId = id }`
- `NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData)`；输入表达式：`CharacterDeletion.DeletedStarterVacancy(d)`；返回值紧邻使用处：`IfStatementSyntax: if (CharacterDeletion.DeletedStarterVacancy(d)) return;`
- `NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`；输入表达式：`CharacterDeletion.RepairStarters(d, updateSchedule: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: CharacterDeletion.RepairStarters(d, updateSchedule: false);`
- `NationalSpire.CircuitWorld.ActiveTie(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.WorldFixture>)`；输入表达式：`CircuitWorld.ActiveTie(d, g)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CircuitWorld.ActiveTie(d, g)`
- `NationalSpire.CircuitWorld.UpdatePlayerMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition, System.Collections.Generic.IReadOnlySet<string>)`；输入表达式：`CircuitWorld.UpdatePlayerMatches(d, c, changed)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.UpdatePlayerMatches(d, c, changed);`
- `NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData)`；输入表达式：`OfficialRoster(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OfficialRoster(d)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`c.Rosters.ContainsKey(own.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`changed.Add(f.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: changed.Add(f.Id);`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.All(f => !f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.All(f => !f.Finished) && !CircuitWorld.ActiveTie(d, g)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`roster.Take(1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Cooperative ? roster.Take(1) : roster`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.All(f => !f.Finished) && !CircuitWorld.ActiveTie(d, g))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var tie in c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.All(f => !f.Finished) && !CircuitWorld.ActiveTie(d, g)))              {                  int i = 0;                  foreach (var f in tie)                  {                      string id = roster[i++];                      if ((f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId) == id) continue;                      if (f.HomeTeam == own.ClubId) f.HomeId = id; else f.AwayId = id;                      changed.Add(f.Id);                  }              }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId)))          {              var roster = OfficialRoster(d); c.Rosters[own.ClubId] = roster;              var changed = new HashSet<string>();              foreach (var tie in c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.All(f => !f.Finished) && !CircuitWorld.ActiveTie(d, g)))              {                  int i = 0;                  foreach (var f in tie)                  {                      string id = roster[i++];                      if ((f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId) == id) continue;                      if (f.HomeTeam == own.ClubId) f.HomeId = id; else f.AwayId = id;                      changed.Add(f.Id);                  }              }              foreach (string id in c.Cooperative ? roster.Take(1) : roster)              {                  if (!c.Entrants.Contains(id)) { c.Entrants.Add(id); c.Table.Add(new() { PersonId = id }); }                  c.EntrantClubs[id] = own.ClubId; c.EntrantCountries[id] = d.Esports.Country;              }              if (changed.Count > 0) CircuitWorld.UpdatePlayerMatches(d, c, changed);          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Entrants.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Entrants.Add(id);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Table.Add(new() { PersonId = id })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Table.Add(new() { PersonId = id });`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`c.Entrants.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Entrants.Contains(id)`

**赋值（含属性/字段和局部值）：**

- `c.EntrantClubs[id]` = `own.ClubId`
- `c.EntrantCountries[id]` = `d.Esports.Country`
- `c.Rosters[own.ClubId]` = `roster`
- `f.AwayId` = `id`
- `f.HomeId` = `id`
- `PersonId` = `id`
