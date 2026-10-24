# ClubDeparture.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`FED4F1951D981E40E551888A40969BB49579CC1EED646DAA6B390B45D3DC3531`。来源：[源码](../../ClubDeparture.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ClubDeparture`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-6a8d833b4197"></a>

## `NationalSpire.ClubDeparture.Error(NationalSpire.CareerData) — public static string? Error(CareerData d)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubLeaveDialog()`](ClubDepartureScreen.cs.md#symbol-6954ceb20cdf)；[`NationalSpire.ClubDeparture.Leave(NationalSpire.CareerData)`](ClubDeparture.cs.md#symbol-1579a5b3a3c8)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CircuitWorld.ActiveTie(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.WorldFixture>)`](CircuitWorld.cs.md#symbol-055c6e88b6b6)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Season`；`NationalSpire.CircuitWorld.ActiveTie(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.WorldFixture>)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.ActiveTie(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.WorldFixture>)`；输入表达式：`CircuitWorld.ActiveTie(d, tie)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Any(f => f.Finished) && tie.Any(f => !f.Finished) || CircuitWorld.ActiveTie(d, tie)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`c.Rosters.ContainsKey(d.Esports.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Season == d.Season && !c.Finished && c.Rosters.ContainsKey(d.Esports.ClubId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.Rosters.ContainsKey(d.Esports.ClubId))             .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == d.Esports.ClubId || f.AwayTeam == d.Esports.ClubId)                 .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)))             .Any(tie => tie.Any(f => f.Finished) && tie.Any(f => !f.Finished) || CircuitWorld.ActiveTie(d, tie))`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.Rosters.ContainsKey(d.Esports.ClubId))             .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == d.Esports.ClubId || f.AwayTeam == d.Esports.ClubId)                 .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)))             .Any(tie => tie.Any(f => f.Finished) && tie.Any(f => !f.Finished) || CircuitWorld.ActiveTie(d, tie)))             return "请先完成已经开打的同组对阵，再退出俱乐部。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Any(f => !f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Any(f => f.Finished) && tie.Any(f => !f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Any(f => f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Any(f => f.Finished) && tie.Any(f => !f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == d.Esports.ClubId || f.AwayTeam == d.Esports.ClubId)                 .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Fixtures.Where(f => f.HomeTeam == d.Esports.ClubId || f.AwayTeam == d.Esports.ClubId)                 .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.Rosters.ContainsKey(d.Esports.ClubId))             .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == d.Esports.ClubId || f.AwayTeam == d.Esports.ClubId)                 .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.Rosters.ContainsKey(d.Esports.ClubId))             .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == d.Esports.ClubId || f.AwayTeam == d.Esports.ClubId)                 .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)))             .Any`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == d.Esports.ClubId || f.AwayTeam == d.Esports.ClubId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == d.Esports.ClubId || f.AwayTeam == d.Esports.ClubId)                 .GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.Rosters.ContainsKey(d.Esports.ClubId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.Rosters.ContainsKey(d.Esports.ClubId))             .SelectMany`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1579a5b3a3c8"></a>

## `NationalSpire.ClubDeparture.Leave(NationalSpire.CareerData) — public static string? Leave(CareerData d)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubLeaveDialog()`](ClubDepartureScreen.cs.md#symbol-6954ceb20cdf)；[`NationalSpire.Coop.CoopRules.ExecuteProposal(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-fecbe30f550e)

**调用：** [`NationalSpire.CareerCommerce.ConfigureClub(NationalSpire.CareerData, NationalSpire.CareerClub, bool)`](CareerCommerce.cs.md#symbol-87ae7b47fe11)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-5df788f3061f)；[`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-03130719dfb2)；[`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-1ed5bef75319)；[`NationalSpire.ClubDeparture.Error(NationalSpire.CareerData)`](ClubDeparture.cs.md#symbol-6a8d833b4197)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.EsportsWorld.RefreshClubOffers(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-11dee47d7b53)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubSchedule.RefreshClub(NationalSpire.CareerData, string)`](OwnedClubSchedule.cs.md#symbol-d65310152f62)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Fans`；`NationalSpire.CareerClub.Identity`；`NationalSpire.CareerClub.Name`；`NationalSpire.CareerClub.PreferredStarters`；`NationalSpire.CareerClub.Transfers`；`NationalSpire.CareerCommerce.ConfigureClub(NationalSpire.CareerData, NationalSpire.CareerClub, bool)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Standings`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；`NationalSpire.ClubDeparture.Error(NationalSpire.CareerData)`；`NationalSpire.CoachLineupRequest.Actor`；`NationalSpire.CoachLineupRequest.ClubId`；`NationalSpire.CoachLineupRequest.First`；`NationalSpire.CoachLineupRequest.Second`；`NationalSpire.CoachLineupRequest.State`；`NationalSpire.CoachTrainingPlan.ClubId`；`NationalSpire.CoachTrainingPlan.State`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.CoachTraining`；`NationalSpire.EsportsCareer.LineupRequests`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsCareer.PlayerContract`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.RefreshClubOffers(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubSchedule.RefreshClub(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.CoachTraining`；`NationalSpire.OwnedClubState.Fans`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedClubState.Transfers`；`NationalSpire.OwnedTransfer.Arrived`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.ConfigureClub(NationalSpire.CareerData, NationalSpire.CareerClub, bool)`；输入表达式：`CareerCommerce.ConfigureClub(d, club, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerCommerce.ConfigureClub(d, club, false);`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + "离开"`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d, "club-left-" + Guid.NewGuid().ToString("N"), "转会", CareerEngine.Name(d) + "离开" + club.Name,             CareerEngine.Name(d) + "离开" + club.Name + "，成为自由选手。", humans.ToList(), true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(d, "club-left-" + Guid.NewGuid().ToString("N"), "转会", CareerEngine.Name(d) + "离开" + club.Name,             CareerEngine.Name(d) + "离开" + club.Name + "，成为自由选手。", humans.ToList(), true);`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；输入表达式：`CareerTraining.InvalidateForecast(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.InvalidateForecast(d);`
- `NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`；输入表达式：`CircuitPeople.Replenish(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitPeople.Replenish(d);`
- `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.TrainingPlans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.TrainingPlans(d).Where`
- `NationalSpire.ClubDeparture.Error(NationalSpire.CareerData)`；输入表达式：`Error(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Error(d) is { } error`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, clubId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: EsportsWorld.Club(d, clubId)!`
- `NationalSpire.EsportsWorld.RefreshClubOffers(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.RefreshClubOffers(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: EsportsWorld.RefreshClubOffers(d);`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.Humans(d).Append`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.IsOwner(d)`；返回值紧邻使用处：`IfStatementSyntax: if (OwnedClubs.IsOwner(d))         {             var own = d.Esports.OwnedClub!;             club.Fans = own.Fans;             club.PreferredStarters = own.Starters.Where(id => !humans.Contains(id)).ToList();             club.Transfers.AddRange(own.Transfers.Where(t => !t.Arrived));             d.Esports.CoachTraining.AddRange(own.CoachTraining);             club.Identity = "";             CareerCommerce.ConfigureClub(d, club, false);             d.Esports.OwnedClub = null;         }`
- `NationalSpire.OwnedClubSchedule.RefreshClub(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubSchedule.RefreshClub(d, clubId)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubSchedule.RefreshClub(d, clubId);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`humans.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !humans.Contains(id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`humans.Contains(p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => humans.Contains(p.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`humans.Contains(r.Actor)`；返回值紧邻使用处：`BinaryExpressionSyntax: humans.Contains(r.Actor) || humans.Contains(r.First)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`humans.Contains(r.First)`；返回值紧邻使用处：`BinaryExpressionSyntax: humans.Contains(r.Actor) || humans.Contains(r.First)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`humans.Contains(r.Second)`；返回值紧邻使用处：`BinaryExpressionSyntax: humans.Contains(r.Actor) || humans.Contains(r.First) || humans.Contains(r.Second)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`OwnedClubs.Humans(d).Append("player")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.Humans(d).Append("player").ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`OwnedClubs.Humans(d).Append("player").ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.Humans(d).Append("player").ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`humans.ToList()`；返回值紧邻使用处：`ArgumentSyntax: humans.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`own.Starters.Where(id => !humans.Contains(id)).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: club.PreferredStarters = own.Starters.Where(id => !humans.Contains(id)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ClubCoaching.TrainingPlans(d).Where(p => p.ClubId == clubId && p.State == "进行中")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var plan in ClubCoaching.TrainingPlans(d).Where(p => p.ClubId == clubId && p.State == "进行中")) plan.State = "已取消";`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.LineupRequests.Where(r => r.ClubId == clubId && r.State == "待生效"             && (humans.Contains(r.Actor) || humans.Contains(r.First) || humans.Contains(r.Second)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var request in d.Esports.LineupRequests.Where(r => r.ClubId == clubId && r.State == "待生效"             && (humans.Contains(r.Actor) || humans.Contains(r.First) || humans.Contains(r.Second)))) request.State = "已取消";`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => humans.Contains(p.Id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var p in d.People.Where(p => humans.Contains(p.Id))) { p.ClubId = ""; p.ClubPosition = ""; }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`own.Starters.Where(id => !humans.Contains(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: own.Starters.Where(id => !humans.Contains(id)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`own.Transfers.Where(t => !t.Arrived)`；返回值紧邻使用处：`ArgumentSyntax: own.Transfers.Where(t => !t.Arrived)`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`club.Transfers.AddRange(own.Transfers.Where(t => !t.Arrived))`；返回值紧邻使用处：`ExpressionStatementSyntax: club.Transfers.AddRange(own.Transfers.Where(t => !t.Arrived));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`d.Esports.CoachTraining.AddRange(own.CoachTraining)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.CoachTraining.AddRange(own.CoachTraining);`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: "club-left-" + Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**

- `club.Fans` = `own.Fans`
- `club.Identity` = `""`
- `club.PreferredStarters` = `own.Starters.Where(id => !humans.Contains(id)).ToList()`
- `d.Esports.ClubId` = `""`
- `d.Esports.OwnedClub` = `null`
- `d.Esports.PlayerContract` = `null`
- `d.Standings` = `[]`
- `p.ClubId` = `""`
- `p.ClubPosition` = `""`
- `plan.State` = `"已取消"`
- `request.State` = `"已取消"`
