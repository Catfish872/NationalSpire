# ClubAudience.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B47B6DAE486BB0D46E41873ECB6204700857439077512A6FADE708A84E9FE8DB`。来源：[源码](../../ClubAudience.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ClubAudience`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-6a78e48d0de3"></a>

## `NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string) — public static int Total(CareerData d, string club)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubDirectory(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-27a995f7ce9f)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CircuitLedger.CreateContract(NationalSpire.CareerData, string, int)`](CircuitLedger.cs.md#symbol-fe0f4a1b42d8)；[`NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`](ClubOperations.cs.md#symbol-213a7e731998)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)

**调用：** [`NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`](CareerAudience.cs.md#symbol-c169fde4fb8f)；[`NationalSpire.CoachLineups.Coach(NationalSpire.CareerPerson)`](CoachLineups.cs.md#symbol-86e0b50ffb0e)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `(string Id, int Fans).Fans`；`(string Id, int Fans).Id`；`NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`；`NationalSpire.CareerClub.Fans`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CoachLineups.Coach(NationalSpire.CareerPerson)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Coaches`；`NationalSpire.OwnedClubState.Fans`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Starters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`；输入表达式：`CareerAudience.Followers(p)`；返回值紧邻使用处：`ArgumentSyntax: Fans: CareerAudience.Followers(p)`
- `NationalSpire.CoachLineups.Coach(NationalSpire.CareerPerson)`；输入表达式：`CoachLineups.Coach(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CoachLineups.Coach(p)`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, club)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: EsportsWorld.Club(d, club)?.Fans`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChats.Human(d)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`players.Any(p => p.Id == human)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !players.Any(p => p.Id == human)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`players.OrderByDescending(p => p.Fans)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: players.OrderByDescending(p => p.Fans).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.People.Where(p => p.ClubId == club && !CoachLineups.Coach(p)             && !(d.Esports.OwnedClub is { } o && o.ClubId == club && o.Coaches.Contains(p.Id) && !o.Starters.Contains(p.Id) && !o.Reserves.Contains(p.Id)))             .Select(p => (p.Id, Fans: CareerAudience.Followers(p)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId == club && !CoachLineups.Coach(p)             && !(d.Esports.OwnedClub is { } o && o.ClubId == club && o.Coaches.Contains(p.Id) && !o.Starters.Contains(p.Id) && !o.Reserves.Contains(p.Id)))             .Select(p => (p.Id, Fans: CareerAudience.Followers(p))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`players.OrderByDescending(p => p.Fans).Take(3).Sum(p => (long)p.Fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: players.OrderByDescending(p => p.Fans).Take(3).Sum(p => (long)p.Fans) / 5`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`players.OrderByDescending(p => p.Fans).Take(3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: players.OrderByDescending(p => p.Fans).Take(3).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => p.ClubId == club && !CoachLineups.Coach(p)             && !(d.Esports.OwnedClub is { } o && o.ClubId == club && o.Coaches.Contains(p.Id) && !o.Starters.Contains(p.Id) && !o.Reserves.Contains(p.Id)))             .Select(p => (p.Id, Fans: CareerAudience.Followers(p))).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => p.ClubId == club && !CoachLineups.Coach(p)             && !(d.Esports.OwnedClub is { } o && o.ClubId == club && o.Coaches.Contains(p.Id) && !o.Starters.Contains(p.Id) && !o.Reserves.Contains(p.Id)))             .Select(p => (p.Id, Fans: CareerAudience.Followers(p))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.ClubId == club && !CoachLineups.Coach(p)             && !(d.Esports.OwnedClub is { } o && o.ClubId == club && o.Coaches.Contains(p.Id) && !o.Starters.Contains(p.Id) && !o.Reserves.Contains(p.Id)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId == club && !CoachLineups.Coach(p)             && !(d.Esports.OwnedClub is { } o && o.ClubId == club && o.Coaches.Contains(p.Id) && !o.Starters.Contains(p.Id) && !o.Reserves.Contains(p.Id)))             .Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`players.Add((human, d.Fans))`；返回值紧邻使用处：`ExpressionStatementSyntax: players.Add((human, d.Fans));`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Coaches.Contains(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.OwnedClub is { } o && o.ClubId == club && o.Coaches.Contains(p.Id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Reserves.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.Reserves.Contains(p.Id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Starters.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.Starters.Contains(p.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-10f11d54fbbe"></a>

## `NationalSpire.ClubAudience.RoundGain(string, int, bool) — public static int RoundGain(string kind, int round, bool won)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](ClubAudience.cs.md#symbol-2ba02e4068ba)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)

**调用：** [`NationalSpire.CareerAudience.RoundMultiplier(int)`](CareerAudience.cs.md#symbol-14e208558d78)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.RoundMultiplier(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.RoundMultiplier(int)`；输入表达式：`CareerAudience.RoundMultiplier(round)`；返回值紧邻使用处：`BinaryExpressionSyntax: 2 * CareerAudience.RoundMultiplier(round)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2ba02e4068ba"></a>

## `NationalSpire.ClubAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture) — public static void Fixture(CareerData d, WorldCompetition c, WorldFixture f)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerAudience.cs.md#symbol-889a215412c7)

**调用：** [`NationalSpire.ClubAudience.RoundGain(string, int, bool)`](ClubAudience.cs.md#symbol-10f11d54fbbe)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.AudienceReceipts`；`NationalSpire.CareerClub.Fans`；`NationalSpire.CareerData.Esports`；`NationalSpire.ClubAudience.RoundGain(string, int, bool)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Draw`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubAudience.RoundGain(string, int, bool)`；输入表达式：`RoundGain(c.Kind, f.Round, wins > tie.Length / 2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: club.Fans += RoundGain(c.Kind, f.Round, wins > tie.Length / 2)`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, id) is not { } club`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`club.AudienceReceipts.Add(c.Id + ":" + f.Round + ":" + f.HomeTeam + ":" + f.AwayTeam)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !club.AudienceReceipts.Add(c.Id + ":" + f.Round + ":" + f.HomeTeam + ":" + f.AwayTeam)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Any(x => !x.Finished || x.Draw)`；返回值紧邻使用处：`IfStatementSyntax: if (tie.Any(x => !x.Finished || x.Draw)) return;`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(x => x.WinnerId == (id == x.HomeTeam ? x.HomeId : x.AwayId))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tie.Count(x => x.WinnerId == (id == x.HomeTeam ? x.HomeId : x.AwayId))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(x => x.Round == f.Round && x.HomeTeam == f.HomeTeam && x.AwayTeam == f.AwayTeam).ToArray`

**赋值（含属性/字段和局部值）：**

- `club.Fans` += `RoundGain(c.Kind, f.Round, wins > tie.Length / 2)`
