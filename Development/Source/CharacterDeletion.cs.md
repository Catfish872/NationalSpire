# CharacterDeletion.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9C824868289C1D00B1C1800C3945692F3A187D9FB71DE0C5D83DB0D16FA9E197`。来源：[源码](../../CharacterDeletion.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CharacterDeletion`。

字段、事件及初始值（源码原样）：

```csharp
internal const string MissingStarter = "请先补充一名符合首发资格的轮换或青训。";
```

<a id="symbol-3d7604fa699e"></a>

## `NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string) — internal static List<CareerPerson> StarterCandidates(CareerData d, string exclude = "")`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`](CharacterDeletion.cs.md#symbol-c88a1645b627)；[`NationalSpire.CharacterDeletion.StarterReplacement(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-ef7276d6a37c)

**调用：** [`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；`NationalSpire.CoachLineupRequest.First`；`NationalSpire.CoachLineupRequest.Second`；`NationalSpire.CoachLineupRequest.State`；`NationalSpire.EsportsCareer.LineupRequests`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.PlayerReplacement`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；输入表达式：`ClubCoaching.Replacements(d, exclude)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.Replacements(d, exclude)          .Where`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.Humans(d).Contains`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id))`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.First(p => p.Id == id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => d.People.First(p => p.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ClubCoaching.Replacements(d, exclude)          .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement              && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))          .Select(id => d.People.First(p => p.Id == id)).OrderByDescending(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.Replacements(d, exclude)          .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement              && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))          .Select(id => d.People.First(p => p.Id == id)).OrderByDescending(p => p.Rating).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ClubCoaching.Replacements(d, exclude)          .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement              && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))          .Select(id => d.People.First(p => p.Id == id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.Replacements(d, exclude)          .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement              && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))          .Select(id => d.People.First(p => p.Id == id)).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`ClubCoaching.Replacements(d, exclude)          .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement              && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))          .Select(id => d.People.First(p => p.Id == id)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ClubCoaching.Replacements(d, exclude)          .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement              && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))          .Select(id => d.People.First(p => p.Id == id)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ClubCoaching.Replacements(d, exclude)          .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement              && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.Replacements(d, exclude)          .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement              && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))          .Select`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`OwnedClubs.Humans(d).Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.Humans(d).Contains(id)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`ClubCoaching.Replacements(d, exclude)          .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement              && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))          .Select(id => d.People.First(p => p.Id == id)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.Replacements(d, exclude)          .Where(id => !OwnedClubs.Humans(d).Contains(id) && id != d.Esports.OwnedClub!.PlayerReplacement              && !d.Esports.LineupRequests.Any(r => r.State == "待生效" && (r.First == id || r.Second == id)))          .Select(id => d.People.First(p => p.Id == id)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).ToList`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ef7276d6a37c"></a>

## `NationalSpire.CharacterDeletion.StarterReplacement(NationalSpire.CareerData, string) — public static CareerPerson? StarterReplacement(CareerData d, string id)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)

**调用：** [`NationalSpire.CharacterDeletion.NeedsReplacement(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-9fff1f12bd20)；[`NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-3d7604fa699e)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CharacterDeletion.NeedsReplacement(NationalSpire.CareerData, string)`；`NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterDeletion.NeedsReplacement(NationalSpire.CareerData, string)`；输入表达式：`NeedsReplacement(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: NeedsReplacement(d, id) ? StarterCandidates(d, id).FirstOrDefault() : null`
- `NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`；输入表达式：`StarterCandidates(d, id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: StarterCandidates(d, id).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`StarterCandidates(d, id).FirstOrDefault()`；返回值紧邻使用处：`ConditionalExpressionSyntax: NeedsReplacement(d, id) ? StarterCandidates(d, id).FirstOrDefault() : null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9fff1f12bd20"></a>

## `NationalSpire.CharacterDeletion.NeedsReplacement(NationalSpire.CareerData, string) — private static bool NeedsReplacement(CareerData d, string id)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.CharacterDeletion.StarterReplacement(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-ef7276d6a37c)

**调用：** [`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.Starters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ActiveHumans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.ActiveHumans(d).Count`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`own.Starters.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.OwnedClub is { } own          && own.Starters.Contains(id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(3, OwnedClubs.ActiveHumans(d).Count)`；返回值紧邻使用处：`BinaryExpressionSyntax: own.Starters.Count <= Math.Max(3, OwnedClubs.ActiveHumans(d).Count)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a8f554428afa"></a>

## `NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData) — internal static bool DeletedStarterVacancy(CareerData d)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`](CharacterDeletion.cs.md#symbol-c88a1645b627)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)；[`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData, bool)`](OwnedClubSchedule.cs.md#symbol-57e159140286)

**调用：** [`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DeletedPeople`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.CareerPerson.CreatedCard`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Starters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ActiveHumans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.ActiveHumans(d).Count`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.DeletedPeople.Values.Any(p => p.CreatedCard && p.ClubId == own.ClubId && p.ClubPosition == "首发")`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.OwnedClub is { } own          && own.Starters.Count < Math.Max(3, OwnedClubs.ActiveHumans(d).Count)          && d.DeletedPeople.Values.Any(p => p.CreatedCard && p.ClubId == own.ClubId && p.ClubPosition == "首发")`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(3, OwnedClubs.ActiveHumans(d).Count)`；返回值紧邻使用处：`BinaryExpressionSyntax: own.Starters.Count < Math.Max(3, OwnedClubs.ActiveHumans(d).Count)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fdd2ed81eace"></a>

## `NationalSpire.CharacterDeletion.Promote(NationalSpire.CareerData, NationalSpire.CareerPerson, int) — private static void Promote(CareerData d, CareerPerson person, int index)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`](CharacterDeletion.cs.md#symbol-c88a1645b627)

**调用：** [`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-5df788f3061f)；[`NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-62e6f802776a)；[`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-64e7ad9283a5)；`System.Collections.Generic.List<T>.Insert(int, T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubState.Starters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；输入表达式：`CareerTraining.InvalidateForecast(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.InvalidateForecast(d);`
- `NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`；输入表达式：`ClubCoaching.Move(d, person.Id, "首发")`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubCoaching.Move(d, person.Id, "首发");`
- `NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；输入表达式：`OwnedClubs.UpdateRosterRole(person, "首发")`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.UpdateRosterRole(person, "首发");`
- `System.Collections.Generic.List<T>.Insert(int, T)`；输入表达式：`own.Starters.Insert(index, person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: own.Starters.Insert(index, person.Id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`own.Starters.Remove(person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: own.Starters.Remove(person.Id);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c88a1645b627"></a>

## `NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool) — internal static bool RepairStarters(CareerData d, bool updateSchedule = true)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`](OwnedClubs.cs.md#symbol-3b98b543bc03)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)；[`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData, bool)`](OwnedClubSchedule.cs.md#symbol-57e159140286)

**调用：** [`NationalSpire.CharacterDeletion.Available(NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, NationalSpire.CareerPerson)`](CharacterDeletion.cs.md#symbol-e6326820a99c)；[`NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData)`](CharacterDeletion.cs.md#symbol-a8f554428afa)；[`NationalSpire.CharacterDeletion.Promote(NationalSpire.CareerData, NationalSpire.CareerPerson, int)`](CharacterDeletion.cs.md#symbol-fdd2ed81eace)；[`NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-3d7604fa699e)；[`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；[`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData, bool)`](OwnedClubSchedule.cs.md#symbol-57e159140286)；`NationalSpire.CareerStanding.CareerStanding()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `(NationalSpire.WorldCompetition Competition, NationalSpire.WorldFixture Fixture, NationalSpire.CareerPerson Person).Competition`；`(NationalSpire.WorldCompetition Competition, NationalSpire.WorldFixture Fixture, NationalSpire.CareerPerson Person).Fixture`；`(NationalSpire.WorldCompetition Competition, NationalSpire.WorldFixture Fixture, NationalSpire.CareerPerson Person).Person`；`(string Id, int Index).Id`；`(string Id, int Index).Index`；`NationalSpire.CareerData.DeletedPeople`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CharacterDeletion.Available(NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, NationalSpire.CareerPerson)`；`NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData)`；`NationalSpire.CharacterDeletion.Promote(NationalSpire.CareerData, NationalSpire.CareerPerson, int)`；`NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData, bool)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStanding.CareerStanding()`；输入表达式：`new() { PersonId = p.Id }`；返回值紧邻使用处：`ArgumentSyntax: new() { PersonId = p.Id }`
- `NationalSpire.CharacterDeletion.Available(NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, NationalSpire.CareerPerson)`；输入表达式：`Available(c, f, own.ClubId, p)`；返回值紧邻使用处：`BinaryExpressionSyntax: Available(c, f, own.ClubId, p)                  && !replacements.Any(r => r.Competition == c && r.Fixture.Round == f.Round                      && r.Fixture.HomeTeam == f.HomeTeam && r.Fixture.AwayTeam == f.AwayTeam && r.Person.Id == p.Id)`
- `NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData)`；输入表达式：`DeletedStarterVacancy(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DeletedStarterVacancy(d)`
- `NationalSpire.CharacterDeletion.Promote(NationalSpire.CareerData, NationalSpire.CareerPerson, int)`；输入表达式：`Promote(d, p, index < 0 ? own.Starters.Count : Math.Min(scheduled[index].Index, own.Starters.Count))`；返回值紧邻使用处：`ExpressionStatementSyntax: Promote(d, p, index < 0 ? own.Starters.Count : Math.Min(scheduled[index].Index, own.Starters.Count));`
- `NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`；输入表达式：`StarterCandidates(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: StarterCandidates(d).OrderBy`
- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ActiveHumans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.ActiveHumans(d).Count`
- `NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData, bool)`；输入表达式：`OwnedClubSchedule.UpdateLineup(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubSchedule.UpdateLineup(d);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`c.Rosters.ContainsKey(own.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Season == d.Season && !c.Finished && c.TeamEvent              && c.Kind is "league" or "continental" && c.Rosters.ContainsKey(own.ClubId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`c.Rosters.ContainsKey(own.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`d.DeletedPeople.TryGetValue(id, out var old)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.DeletedPeople.TryGetValue(id, out var old)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Any(f => !f.Finished)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Any(f => !f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`replacements.Any(r => r.Competition == c && r.Fixture.Round == f.Round                      && r.Fixture.HomeTeam == f.HomeTeam && r.Fixture.AwayTeam == f.AwayTeam && r.Person.Id == p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !replacements.Any(r => r.Competition == c && r.Fixture.Round == f.Round                      && r.Fixture.HomeTeam == f.HomeTeam && r.Fixture.AwayTeam == f.AwayTeam && r.Person.Id == p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`scheduled.Any(s => s.Id == p.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: scheduled.Any(s => s.Id == p.Id) ? 0 : 1`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.FirstOrDefault(p => Available(c, f, own.ClubId, p)                  && !replacements.Any(r => r.Competition == c && r.Fixture.Round == f.Round                      && r.Fixture.HomeTeam == f.HomeTeam && r.Fixture.AwayTeam == f.AwayTeam && r.Person.Id == p.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = candidates.FirstOrDefault(p => Available(c, f, own.ClubId, p)                  && !replacements.Any(r => r.Competition == c && r.Fixture.Round == f.Round                      && r.Fixture.HomeTeam == f.HomeTeam && r.Fixture.AwayTeam == f.AwayTeam && r.Person.Id == p.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`StarterCandidates(d).OrderBy(p => scheduled.Any(s => s.Id == p.Id) ? 0 : 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: StarterCandidates(d).OrderBy(p => scheduled.Any(s => s.Id == p.Id) ? 0 : 1).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`g.Select((f, index) => (Id: f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId, Index: index))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Select((f, index) => (Id: f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId, Index: index))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Any(f => !f.Finished))                  .SelectMany(g => g.Select((f, index) => (Id: f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId, Index: index)))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Any(f => !f.Finished))                  .SelectMany(g => g.Select((f, index) => (Id: f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId, Index: index)))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId))              .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Any(f => !f.Finished))                  .SelectMany(g => g.Select((f, index) => (Id: f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId, Index: index))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId))              .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Any(f => !f.Finished))                  .SelectMany(g => g.Select((f, index) => (Id: f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId, Index: index))))              .ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`candidates.Take(missing)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var p in candidates.Take(missing))          {              int index = scheduled.FindIndex(s => s.Id == p.Id);              Promote(d, p, index < 0 ? own.Starters.Count : Math.Min(scheduled[index].Index, own.Starters.Count));          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId))              .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Any(f => !f.Finished))                  .SelectMany(g => g.Select((f, index) => (Id: f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId, Index: index))))              .ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId))              .SelectMany(c => c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Any(f => !f.Finished))                  .SelectMany(g => g.Select((f, index) => (Id: f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId, Index: index))))              .ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`StarterCandidates(d).OrderBy(p => scheduled.Any(s => s.Id == p.Id) ? 0 : 1).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = StarterCandidates(d).OrderBy(p => scheduled.Any(s => s.Id == p.Id) ? 0 : 1).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => !f.Finished && (f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var f in c.Fixtures.Where(f => !f.Finished && (f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)))          {              string id = f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId;              if (!d.DeletedPeople.TryGetValue(id, out var old) || old.ClubId != own.ClubId || old.ClubPosition != "首发") continue;              var p = candidates.FirstOrDefault(p => Available(c, f, own.ClubId, p)                  && !replacements.Any(r => r.Competition == c && r.Fixture.Round == f.Round                      && r.Fixture.HomeTeam == f.HomeTeam && r.Fixture.AwayTeam == f.AwayTeam && r.Person.Id == p.Id));              if (p == null) return false;              replacements.Add((c, f, p));          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Any(f => !f.Finished))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Any(f => !f.Finished))                  .SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)                  .GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent              && c.Kind is "league" or "continental" && c.Rosters.ContainsKey(own.ClubId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent              && c.Kind is "league" or "continental" && c.Rosters.ContainsKey(own.ClubId)))          foreach (var f in c.Fixtures.Where(f => !f.Finished && (f.HomeTeam == own.ClubId || f.AwayTeam == own.ClubId)))          {              string id = f.HomeTeam == own.ClubId ? f.HomeId : f.AwayId;              if (!d.DeletedPeople.TryGetValue(id, out var old) || old.ClubId != own.ClubId || old.ClubPosition != "首发") continue;              var p = candidates.FirstOrDefault(p => Available(c, f, own.ClubId, p)                  && !replacements.Any(r => r.Competition == c && r.Fixture.Round == f.Round                      && r.Fixture.HomeTeam == f.HomeTeam && r.Fixture.AwayTeam == f.AwayTeam && r.Person.Id == p.Id));              if (p == null) return false;              replacements.Add((c, f, p));          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished && c.TeamEvent && c.Rosters.ContainsKey(own.ClubId))              .SelectMany`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Entrants.Add(p.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Entrants.Add(p.Id);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Table.Add(new() { PersonId = p.Id })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Table.Add(new() { PersonId = p.Id });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`replacements.Add((c, f, p))`；返回值紧邻使用处：`ExpressionStatementSyntax: replacements.Add((c, f, p));`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`c.Entrants.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Entrants.Contains(p.Id)`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`scheduled.FindIndex(s => s.Id == p.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = scheduled.FindIndex(s => s.Id == p.Id)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(WorldCompetition Competition, WorldFixture Fixture, CareerPerson Person)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(WorldCompetition Competition, WorldFixture Fixture, CareerPerson Person)>()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(3, OwnedClubs.ActiveHumans(d).Count)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(3, OwnedClubs.ActiveHumans(d).Count) - own.Starters.Count`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(scheduled[index].Index, own.Starters.Count)`；返回值紧邻使用处：`ConditionalExpressionSyntax: index < 0 ? own.Starters.Count : Math.Min(scheduled[index].Index, own.Starters.Count)`

**赋值（含属性/字段和局部值）：**

- `c.EntrantClubs[p.Id]` = `own.ClubId`
- `c.EntrantCountries[p.Id]` = `p.Country`
- `f.AwayId` = `p.Id`
- `f.HomeId` = `p.Id`
- `PersonId` = `p.Id`

<a id="symbol-e6326820a99c"></a>

## `NationalSpire.CharacterDeletion.Available(NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, NationalSpire.CareerPerson) — private static bool Available(WorldCompetition c, WorldFixture f, string club, CareerPerson p)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`](CharacterDeletion.cs.md#symbol-c88a1645b627)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Id`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(other => other.Id != f.Id          && other.Round == f.Round && other.HomeTeam == f.HomeTeam && other.AwayTeam == f.AwayTeam          && (other.HomeTeam == club ? other.HomeId : other.AwayId) == p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Fixtures.Any(other => other.Id != f.Id          && other.Round == f.Round && other.HomeTeam == f.HomeTeam && other.AwayTeam == f.AwayTeam          && (other.HomeTeam == club ? other.HomeId : other.AwayId) == p.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2eb70f838afa"></a>

## `NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string) — public static string? Delete(CareerData d, string id)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-14a6fc19e1c1)；[`NationalSpire.CharacterDeletion.Available(NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, NationalSpire.CareerPerson)`](CharacterDeletion.cs.md#symbol-e6326820a99c)；[`NationalSpire.CharacterDeletion.Candidates(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.CareerPerson)`](CharacterDeletion.cs.md#symbol-5613d18b588d)；[`NationalSpire.CharacterDeletion.NeedsReplacement(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-9fff1f12bd20)；[`NationalSpire.CharacterDeletion.Promote(NationalSpire.CareerData, NationalSpire.CareerPerson, int)`](CharacterDeletion.cs.md#symbol-fdd2ed81eace)；[`NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-3d7604fa699e)；[`NationalSpire.CharacterDeletion.StarterReplacement(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-ef7276d6a37c)；[`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-03130719dfb2)；[`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-eacca79a5d86)；[`NationalSpire.CoachLineups.Deleted(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-3582186565b4)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；[`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-4649beba59f6)；[`NationalSpire.GroupChats.Deleted(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-7bed226ca03c)；[`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-7f4fa41ad4c0)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData, bool)`](OwnedClubSchedule.cs.md#symbol-57e159140286)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`](PrivateAppointments.cs.md#symbol-32f6566791d2)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`OwnedTeam(NationalSpire.WorldCompetition)`](CharacterDeletion.cs.md#symbol-ce810d438bf7)；`NationalSpire.CareerStanding.CareerStanding()`；`NationalSpire.WorldCompetition.WorldCompetition()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`；`NationalSpire.CareerClub.Budget`；`NationalSpire.CareerData.DeletedPeople`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.People`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.CreatedCard`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CharacterDeletion.Available(NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, NationalSpire.CareerPerson)`；`NationalSpire.CharacterDeletion.Candidates(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.CareerPerson)`；`NationalSpire.CharacterDeletion.MissingStarter`；`NationalSpire.CharacterDeletion.NeedsReplacement(NationalSpire.CareerData, string)`；`NationalSpire.CharacterDeletion.Promote(NationalSpire.CareerData, NationalSpire.CareerPerson, int)`；`NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`；`NationalSpire.CharacterDeletion.StarterReplacement(NationalSpire.CareerData, string)`；`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`；`NationalSpire.CoachAppointment.PersonId`；`NationalSpire.CoachLineups.Deleted(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Deleted(NationalSpire.CareerData, string)`；`NationalSpire.LifeActivity.PersonId`；`NationalSpire.LifeActivity.Result`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeActivity.TrainingTargets`；`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData, bool)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.CoachAppointments`；`NationalSpire.OwnedClubState.Coaches`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.HumanPayDue`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedClubState.Transfers`；`NationalSpire.OwnedClubState.Youth`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Signing`；`NationalSpire.OwnedTransfer.Arrived`；`NationalSpire.OwnedTransfer.Contract`；`NationalSpire.OwnedTransfer.Fee`；`NationalSpire.OwnedTransfer.SellerId`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.LastPerson`；`NationalSpire.PrivateMailbox.NpcAvatarFrames`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`OwnedTeam(NationalSpire.WorldCompetition)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`；输入表达式：`AiService.CancelPrivate(d, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiService.CancelPrivate(d, id);`
- `NationalSpire.CareerStanding.CareerStanding()`；输入表达式：`new() { PersonId = next }`；返回值紧邻使用处：`ArgumentSyntax: new() { PersonId = next }`
- `NationalSpire.CareerStanding.CareerStanding()`；输入表达式：`new() { PersonId = substitute }`；返回值紧邻使用处：`ArgumentSyntax: new() { PersonId = substitute }`
- `NationalSpire.CharacterDeletion.Available(NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, NationalSpire.CareerPerson)`；输入表达式：`Available(c, f, ownClub!.ClubId, p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Available(c, f, ownClub!.ClubId, p)`
- `NationalSpire.CharacterDeletion.Candidates(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.CareerPerson)`；输入表达式：`Candidates(d, c, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Candidates(d, c, person).Where`
- `NationalSpire.CharacterDeletion.Candidates(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.CareerPerson)`；输入表达式：`Candidates(d, new() { Kind = m.Kind }, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Candidates(d, new() { Kind = m.Kind }, person).OrderByDescending`
- `NationalSpire.CharacterDeletion.NeedsReplacement(NationalSpire.CareerData, string)`；输入表达式：`NeedsReplacement(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: NeedsReplacement(d, id) && starter == null`
- `NationalSpire.CharacterDeletion.Promote(NationalSpire.CareerData, NationalSpire.CareerPerson, int)`；输入表达式：`Promote(d, starter, index)`；返回值紧邻使用处：`ExpressionStatementSyntax: Promote(d, starter, index);`
- `NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`；输入表达式：`StarterCandidates(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: starter == null ? [] : StarterCandidates(d, id)`
- `NationalSpire.CharacterDeletion.StarterReplacement(NationalSpire.CareerData, string)`；输入表达式：`StarterReplacement(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = StarterReplacement(d, id)`
- `NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`；输入表达式：`CircuitPeople.Replenish(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitPeople.Replenish(d);`
- `NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`；输入表达式：`ClubCoaching.StopTraining(d, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubCoaching.StopTraining(d, id);`
- `NationalSpire.CoachLineups.Deleted(NationalSpire.CareerData, string)`；输入表达式：`CoachLineups.Deleted(d, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoachLineups.Deleted(d, id);`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, transfer.SellerId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, transfer.SellerId) is { } seller`
- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubOf(d, next)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantClubs[next] = EsportsWorld.ClubOf(d, next)`
- `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.CountryOf(d, next)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantCountries[next] = EsportsWorld.CountryOf(d, next)`
- `NationalSpire.GroupChats.Deleted(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Deleted(d, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupChats.Deleted(d, id);`
- `NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；输入表达式：`MatchFailure.Locked(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: MatchFailure.Locked(d) is { } locked`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`OwnedClubs.Pay(d, "取消" + person.PublicName + "转会", transfer.Fee + transfer.Contract.Signing)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.Pay(d, "取消" + person.PublicName + "转会", transfer.Fee + transfer.Contract.Signing);`
- `NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData, bool)`；输入表达式：`OwnedClubSchedule.UpdateLineup(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubSchedule.UpdateLineup(d);`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；输入表达式：`PrivateAppointments.IsPrivate(m)`；返回值紧邻使用处：`ConditionalExpressionSyntax: PrivateAppointments.IsPrivate(m) ? null : Candidates(d, new() { Kind = m.Kind }, person).OrderByDescending(p => p.Rating).FirstOrDefault()`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(d)`
- `NationalSpire.WorldCompetition.WorldCompetition()`；输入表达式：`new() { Kind = m.Kind }`；返回值紧邻使用处：`ArgumentSyntax: new() { Kind = m.Kind }`
- `OwnedTeam(NationalSpire.WorldCompetition)`；输入表达式：`OwnedTeam(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: !c.Finished && OwnedTeam(c)`
- `OwnedTeam(NationalSpire.WorldCompetition)`；输入表达式：`OwnedTeam(c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: OwnedTeam(c) ? starter : Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))                  .OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).FirstOrDefault()`
- `OwnedTeam(NationalSpire.WorldCompetition)`；输入表达式：`OwnedTeam(c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: OwnedTeam(c) ? substitutes.First(p => Available(c, f, ownClub!.ClubId, p)).Id : substitute`
- `OwnedTeam(NationalSpire.WorldCompetition)`；输入表达式：`OwnedTeam(c)`；返回值紧邻使用处：`IfStatementSyntax: if (OwnedTeam(c))                      {                          if (!c.Entrants.Contains(next)) { c.Entrants.Add(next); c.Table.Add(new() { PersonId = next }); }                          c.EntrantCountries[next] = EsportsWorld.CountryOf(d, next); c.EntrantClubs[next] = EsportsWorld.ClubOf(d, next);                      }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`box.Conversations.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.Conversations.Remove(id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`box.NpcAvatarFrames.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.NpcAvatarFrames.Remove(id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`box.Relations.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.Relations.Remove(id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`owned.HumanPayDue.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.HumanPayDue.Remove(id);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => !f.Finished              && (f.HomeId == id || f.AwayId == id) && !substitutes.Any(p => Available(c, f, ownClub!.ClubId, p)))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Fixtures.Any(f => !f.Finished              && (f.HomeId == id || f.AwayId == id) && !substitutes.Any(p => Available(c, f, ownClub!.ClubId, p)))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id))`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Entrants.Contains(id) || c.Rosters.Values.Any(r => r.Contains(id))              || c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Rosters.Values.Any(r => r.Contains(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Entrants.Contains(id) || c.Rosters.Values.Any(r => r.Contains(id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Rosters.Values.Any(r => r.Contains(p.Id))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Rosters.Values.Any(r => r.Contains(p.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Table.Any(t => t.PersonId == substitute)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Table.Any(t => t.PersonId == substitute)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => !c.Finished && OwnedTeam(c)).Any(c => c.Fixtures.Any(f => !f.Finished              && (f.HomeId == id || f.AwayId == id) && !substitutes.Any(p => Available(c, f, ownClub!.ClubId, p))))`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Competitions.Where(c => !c.Finished && OwnedTeam(c)).Any(c => c.Fixtures.Any(f => !f.Finished              && (f.HomeId == id || f.AwayId == id) && !substitutes.Any(p => Available(c, f, ownClub!.ClubId, p))))) return MissingStarter;`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`substitutes.Any(p => Available(c, f, ownClub!.ClubId, p))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !substitutes.Any(p => Available(c, f, ownClub!.ClubId, p))`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`substitutes.First(p => Available(c, f, ownClub!.ClubId, p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: substitutes.First(p => Available(c, f, ownClub!.ClubId, p)).Id`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))                  .OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).FirstOrDefault()`；返回值紧邻使用处：`ConditionalExpressionSyntax: OwnedTeam(c) ? starter : Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))                  .OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`Candidates(d, new() { Kind = m.Kind }, person).OrderByDescending(p => p.Rating).FirstOrDefault()`；返回值紧邻使用处：`ConditionalExpressionSyntax: PrivateAppointments.IsPrivate(m) ? null : Candidates(d, new() { Kind = m.Kind }, person).OrderByDescending(p => p.Rating).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.FirstOrDefault(p => p.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.FirstOrDefault(p => p.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))                  .OrderByDescending(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))                  .OrderByDescending(p => p.Rating).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Candidates(d, new() { Kind = m.Kind }, person).OrderByDescending(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Candidates(d, new() { Kind = m.Kind }, person).OrderByDescending(p => p.Rating).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => !f.Finished)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var f in c.Fixtures.Where(f => !f.Finished))                  {                      if (f.HomeId != id && f.AwayId != id) continue;                      string next = OwnedTeam(c) ? substitutes.First(p => Available(c, f, ownClub!.ClubId, p)).Id : substitute;                      if (f.HomeId == id) f.HomeId = next; else f.AwayId = next;                      if (OwnedTeam(c))                      {                          if (!c.Entrants.Contains(next)) { c.Entrants.Add(next); c.Table.Add(new() { PersonId = next }); }                          c.EntrantCountries[next] = EsportsWorld.CountryOf(d, next); c.EntrantClubs[next] = EsportsWorld.ClubOf(d, next);                      }                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))                  .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => !c.Finished && (c.Entrants.Contains(id) || c.Rosters.Values.Any(r => r.Contains(id))              || c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id))))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in d.Esports.Competitions.Where(c => !c.Finished && (c.Entrants.Contains(id) || c.Rosters.Values.Any(r => r.Contains(id))              || c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id)))))          {              var replacement = OwnedTeam(c) ? starter : Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))                  .OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).FirstOrDefault();              string substitute = replacement?.Id ?? id;              if (replacement != null)              {                  foreach (var roster in c.Rosters.Values) for (int i = 0; i < roster.Count; i++) if (roster[i] == id) roster[i] = substitute;                  c.EntrantCountries[substitute] = replacement.Country; c.EntrantClubs[substitute] = replacement.ClubId;                  if (!c.Entrants.Contains(substitute)) c.Entrants.Add(substitute);                  if (!c.Table.Any(t => t.PersonId == substitute)) c.Table.Add(new() { PersonId = substitute });                  foreach (var f in c.Fixtures.Where(f => !f.Finished))                  {                      if (f.HomeId != id && f.AwayId != id) continue;                      string next = OwnedTeam(c) ? substitutes.First(p => Available(c, f, ownClub!.ClubId, p)).Id : substitute;                      if (f.HomeId == id) f.HomeId = next; else f.AwayId = next;                      if (OwnedTeam(c))                      {                          if (!c.Entrants.Contains(next)) { c.Entrants.Add(next); c.Table.Add(new() { PersonId = next }); }                          c.EntrantCountries[next] = EsportsWorld.CountryOf(d, next); c.EntrantClubs[next] = EsportsWorld.ClubOf(d, next);                      }                  }              }              foreach (var m in d.Matches.Where(m => m.CompetitionId == c.Id && m.OpponentId == id && m.Status == "待赛"))              { m.OpponentId = substitute; m.OpponentPrepared = false; m.OpponentSeconds = null; m.Live = null; if (replacement == null) { m.Status = "轮空"; m.Registered = false; } }          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => !c.Finished && OwnedTeam(c))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => !c.Finished && OwnedTeam(c)).Any`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => m.CompetitionId == c.Id && m.OpponentId == id && m.Status == "待赛")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var m in d.Matches.Where(m => m.CompetitionId == c.Id && m.OpponentId == id && m.Status == "待赛"))              { m.OpponentId = substitute; m.OpponentPrepared = false; m.OpponentSeconds = null; m.Live = null; if (replacement == null) { m.Status = "轮空"; m.Registered = false; } }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => m.OpponentId == id && m.Status == "待赛" && m.CompetitionId.Length == 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var m in d.Matches.Where(m => m.OpponentId == id && m.Status == "待赛" && m.CompetitionId.Length == 0))          {              var replacement = PrivateAppointments.IsPrivate(m) ? null : Candidates(d, new() { Kind = m.Kind }, person).OrderByDescending(p => p.Rating).FirstOrDefault();              if (replacement == null) { m.Status = "已取消"; m.Registered = false; }              else { m.OpponentId = replacement.Id; m.OpponentPrepared = false; m.OpponentSeconds = null; m.Live = null; }          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`owned.Transfers.Where(t => !t.Arrived && t.Contract.PersonId == id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var transfer in owned.Transfers.Where(t => !t.Arrived && t.Contract.PersonId == id))              {                  OwnedClubs.Pay(d, "取消" + person.PublicName + "转会", transfer.Fee + transfer.Contract.Signing);                  if (EsportsWorld.Club(d, transfer.SellerId) is { } seller) seller.Budget -= transfer.Fee;              }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Entrants.Add(next)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Entrants.Add(next);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Entrants.Add(substitute)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Entrants.Add(substitute);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Table.Add(new() { PersonId = next })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Table.Add(new() { PersonId = next });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Table.Add(new() { PersonId = substitute })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Table.Add(new() { PersonId = substitute });`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`c.Entrants.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Entrants.Contains(id) || c.Rosters.Values.Any(r => r.Contains(id))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`c.Entrants.Contains(next)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Entrants.Contains(next)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`c.Entrants.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Entrants.Contains(p.Id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`c.Entrants.Contains(substitute)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Entrants.Contains(substitute)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: person?.CreatedCard != true || id == "player" || d.HumanIds.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`r.Contains(id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => r.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`r.Contains(p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => r.Contains(p.Id)`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`owned.Starters.IndexOf(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = owned.Starters.IndexOf(id)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`a.TrainingTargets.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: a.TrainingTargets.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`d.People.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.People.Remove(person);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`owned.Coaches.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Coaches.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`owned.Reserves.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Reserves.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`owned.Starters.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Starters.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`owned.Youth.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Youth.Remove(id);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`owned.CoachAppointments.RemoveAll(a => a.PersonId == id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.CoachAppointments.RemoveAll(a => a.PersonId == id);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`owned.Contracts.RemoveAll(t => t.PersonId == id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Contracts.RemoveAll(t => t.PersonId == id);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`owned.Transfers.RemoveAll(t => t.Contract.PersonId == id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Transfers.RemoveAll(t => t.Contract.PersonId == id);`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))                  .OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Candidates(d, c, person).Where(p => !c.Entrants.Contains(p.Id) && !c.Rosters.Values.Any(r => r.Contains(p.Id)))                  .OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).FirstOrDefault`

**赋值（含属性/字段和局部值）：**

- `a.Result` = `"角色已删除。"`
- `a.Status` = `"已取消"`
- `box.LastPerson` = `""`
- `c.EntrantClubs[next]` = `EsportsWorld.ClubOf(d, next)`
- `c.EntrantClubs[substitute]` = `replacement.ClubId`
- `c.EntrantCountries[next]` = `EsportsWorld.CountryOf(d, next)`
- `c.EntrantCountries[substitute]` = `replacement.Country`
- `d.DeletedPeople[id]` = `person`
- `f.AwayId` = `next`
- `f.HomeId` = `next`
- `Kind` = `m.Kind`
- `m.Live` = `null`
- `m.OpponentId` = `replacement.Id`
- `m.OpponentId` = `substitute`
- `m.OpponentPrepared` = `false`
- `m.OpponentSeconds` = `null`
- `m.Registered` = `false`
- `m.Status` = `"轮空"`
- `m.Status` = `"已取消"`
- `PersonId` = `next`
- `PersonId` = `substitute`
- `roster[i]` = `substitute`
- `seller.Budget` -= `transfer.Fee`

<a id="symbol-ce810d438bf7"></a>

## `OwnedTeam(NationalSpire.WorldCompetition) — bool OwnedTeam(WorldCompetition c)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.ClubId`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.TeamEvent`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`c.Rosters.ContainsKey(ownClub!.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: starter != null && c.TeamEvent && c.Kind is "league" or "continental"              && c.Rosters.ContainsKey(ownClub!.ClubId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5613d18b588d"></a>

## `NationalSpire.CharacterDeletion.Candidates(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.CareerPerson) — private static IEnumerable<CareerPerson> Candidates(CareerData d, WorldCompetition c, CareerPerson old)`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)

**调用：** [`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Role`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.WorldCompetition.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.ClubId == old.ClubId && EsportsWorld.IsProfessional(p)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Country == old.Country && EsportsWorld.IsProfessional(p)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.MaxAscension >= 9 && EsportsWorld.IsProfessional(p)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => !d.HumanIds.Contains(p.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => !d.HumanIds.Contains(p.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(p => p.ClubId == old.ClubId && EsportsWorld.IsProfessional(p))`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "league" or "continental" => pool.Where(p => p.ClubId == old.ClubId && EsportsWorld.IsProfessional(p))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(p => p.Country == old.Country && EsportsWorld.IsProfessional(p))`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => pool.Where(p => p.Country == old.Country && EsportsWorld.IsProfessional(p))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(p => p.Country == old.Country && EsportsWorld.IsProfessional(p))`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "worldcup" => pool.Where(p => p.Country == old.Country && EsportsWorld.IsProfessional(p))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(p => p.Country == old.Country && p.Role == "普通玩家")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "local" => pool.Where(p => p.Country == old.Country && p.Role == "普通玩家")`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(p => p.Country == old.Country && p.Role == "青训选手")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "city" or "academy" => pool.Where(p => p.Country == old.Country && p.Role == "青训选手")`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(p => p.MaxAscension >= 9 && EsportsWorld.IsProfessional(p))`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "worldfinal" or "masters" => pool.Where(p => p.MaxAscension >= 9 && EsportsWorld.IsProfessional(p))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(p.Id)`

**赋值（含属性/字段和局部值）：**
