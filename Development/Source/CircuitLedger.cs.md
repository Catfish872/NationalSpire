# CircuitLedger.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`46AE6DC066E265AB03988C4EEF010332351C7554660B418B1691D2E8DB4BB9D9`。来源：[源码](../../CircuitLedger.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CircuitLedger`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-5c41de2c3969"></a>

## `NationalSpire.CircuitLedger.MatchImpact(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static string MatchImpact(CareerData d, CareerMatch m)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`](CircuitWorld.cs.md#symbol-b35defbcdb7c)；[`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](CircuitWorld.cs.md#symbol-74904a83d22a)；[`NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`](NationalFortune.cs.md#symbol-236169683705)；[`NationalSpire.NationalFortune.Impact(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](NationalFortune.cs.md#symbol-96a45ca5bf6b)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMatch.Round`；`NationalSpire.CircuitAward.CompetitionId`；`NationalSpire.CircuitAward.Completed`；`NationalSpire.CircuitAward.Fortune`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Points`；`NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`；`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；`NationalSpire.EsportsCareer.CircuitAwards`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`；`NationalSpire.NationalFortune.Impact(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；`NationalSpire.WorldCompetition.ChampionId`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`；输入表达式：`CircuitWorld.RoundName(c, m.Round + 1)`；返回值紧邻使用处：`InterpolationSyntax: {CircuitWorld.RoundName(c, m.Round + 1)}`
- `NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`；输入表达式：`CircuitWorld.RoundName(c, m.Round)`；返回值紧邻使用处：`InterpolationSyntax: {CircuitWorld.RoundName(c, m.Round)}`
- `NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`CircuitWorld.TeamName(d, c, f.AwayTeam)`；返回值紧邻使用处：`InterpolationSyntax: {CircuitWorld.TeamName(d, c, f.AwayTeam)}`
- `NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`CircuitWorld.TeamName(d, c, f.HomeTeam)`；返回值紧邻使用处：`InterpolationSyntax: {CircuitWorld.TeamName(d, c, f.HomeTeam)}`
- `NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`；输入表达式：`NationalFortune.Applies(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: f != null && NationalFortune.Applies(c)`
- `NationalSpire.NationalFortune.Impact(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；输入表达式：`NationalFortune.Impact(d, c, f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text += NationalFortune.Impact(d, c, f)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(t => t.WinnerId == t.AwayId)`；返回值紧邻使用处：`InterpolationSyntax: {tie.Count(t => t.WinnerId == t.AwayId)}`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(t => t.WinnerId == t.HomeId)`；返回值紧邻使用处：`InterpolationSyntax: {tie.Count(t => t.WinnerId == t.HomeId)}`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.FirstOrDefault(f => f.Id == m.FixtureId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.FirstOrDefault(f => f.Id == m.FixtureId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.FirstOrDefault(a => a.CompetitionId == c.Id && a.PersonId == "player")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.CircuitAwards.FirstOrDefault(a => a.CompetitionId == c.Id && a.PersonId == "player")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId && c.Modern)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId && c.Modern)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Fixtures.Where(t => t.Round == f.Round && t.HomeTeam == f.HomeTeam && t.AwayTeam == f.AwayTeam).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.Where(t => t.Round == f.Round && t.HomeTeam == f.HomeTeam && t.AwayTeam == f.AwayTeam).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(t => t.Round == f.Round && t.HomeTeam == f.HomeTeam && t.AwayTeam == f.AwayTeam)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(t => t.Round == f.Round && t.HomeTeam == f.HomeTeam && t.AwayTeam == f.AwayTeam).ToList`

**赋值（含属性/字段和局部值）：**

- `text` += `$"{CircuitWorld.TeamName(d, c, f.HomeTeam)} {tie.Count(t => t.WinnerId == t.HomeId)}:{tie.Count(t => t.WinnerId == t.AwayId)} {CircuitWorld.TeamName(d, c, f.AwayTeam)}。"`
- `text` += `$"本项赛事获得{award.Points}世界积分、累计贡献{award.Fortune}国运。"`
- `text` += `c.ChampionId == "player" ? $"{CareerEngine.Name(d)}成为本届世界总决赛冠军。" : m.PlayerWon ? $"{CareerEngine.Name(d)}晋级{CircuitWorld.RoundName(c, m.Round + 1)}。" : $"{CareerEngine.Name(d)}止步{CircuitWorld.RoundName(c, m.Round)}。"`
- `text` += `NationalFortune.Impact(d, c, f)`

<a id="symbol-43f817507bfc"></a>

## `NationalSpire.CircuitLedger.Counted(NationalSpire.CareerData, string) — public static IEnumerable<CircuitAward> Counted(CareerData d, string id)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`](CircuitLedger.cs.md#symbol-73238d706495)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Points`；`NationalSpire.CircuitAward.Season`；`NationalSpire.EsportsCareer.CircuitAwards`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.CircuitAwards          .Where(a => a.PersonId == id && a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)          .OrderByDescending(a => a.Points)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards          .Where(a => a.PersonId == id && a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)          .OrderByDescending(a => a.Points).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.Esports.CircuitAwards          .Where(a => a.PersonId == id && a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)          .OrderByDescending(a => a.Points).ThenByDescending(a => a.Season).Take(6)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.CircuitAwards          .Where(a => a.PersonId == id && a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)          .OrderByDescending(a => a.Points).ThenByDescending(a => a.Season).Take(6)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards          .Where(a => a.PersonId == id && a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards          .Where(a => a.PersonId == id && a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)          .OrderByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.CircuitAwards          .Where(a => a.PersonId == id && a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)          .OrderByDescending(a => a.Points).ThenByDescending(a => a.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards          .Where(a => a.PersonId == id && a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)          .OrderByDescending(a => a.Points).ThenByDescending(a => a.Season).Take`

**赋值（含属性/字段和局部值）：**


<a id="symbol-73238d706495"></a>

## `NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string) — public static int Points(CareerData d, string id)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)

**调用：** [`NationalSpire.CircuitLedger.Counted(NationalSpire.CareerData, string)`](CircuitLedger.cs.md#symbol-43f817507bfc)；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CircuitAward.Points`；`NationalSpire.CircuitLedger.Counted(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitLedger.Counted(NationalSpire.CareerData, string)`；输入表达式：`Counted(d, id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Counted(d, id).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`Counted(d, id).Sum(a => a.Points)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Counted(d, id).Sum(a => a.Points)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bd9f405cdea7"></a>

## `NationalSpire.CircuitLedger.Year(int) — public static int Year(int season)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b665478390f0)；[`NationalSpire.CircuitLedger.Fortune(NationalSpire.CareerData, string, int?)`](CircuitLedger.cs.md#symbol-7d3715dcef4e)；[`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)；[`NationalSpire.SeasonCeremony.Capture(NationalSpire.CareerData, int)`](SeasonCeremony.cs.md#symbol-aa8a4ae9c2d5)；[`NationalSpire.SeasonCeremony.Preview(NationalSpire.CareerData)`](SeasonCeremony.cs.md#symbol-0a574d9cff35)；[`NationalSpire.SettlementRecords.Capture(NationalSpire.CareerData, NationalSpire.CareerMatch, int)`](SettlementRecord.cs.md#symbol-8ce7adcb9168)；[`NationalSpire.SettlementRecords.CaptureCompetition(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.WorldCompetition, int, System.Collections.Generic.Dictionary<string, int>)`](SettlementRecord.cs.md#symbol-62f41904fd5e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7d3715dcef4e"></a>

## `NationalSpire.CircuitLedger.Fortune(NationalSpire.CareerData, string, int?) — public static int Fortune(CareerData d, string country, int? year = null)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-4344e458a80a)；[`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)；[`NationalSpire.SettlementRecords.Capture(NationalSpire.CareerData, NationalSpire.CareerMatch, int)`](SettlementRecord.cs.md#symbol-8ce7adcb9168)；[`NationalSpire.SettlementRecords.CaptureCompetition(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.WorldCompetition, int, System.Collections.Generic.Dictionary<string, int>)`](SettlementRecord.cs.md#symbol-62f41904fd5e)

**调用：** [`NationalSpire.CircuitLedger.Year(int)`](CircuitLedger.cs.md#symbol-bd9f405cdea7)；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CircuitAward.Country`；`NationalSpire.CircuitAward.Fortune`；`NationalSpire.CircuitAward.Season`；`NationalSpire.CircuitLedger.Year(int)`；`NationalSpire.EsportsCareer.CircuitAwards`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitLedger.Year(int)`；输入表达式：`Year(a.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: Year(a.Season) == (year ?? Year(d.Season))`
- `NationalSpire.CircuitLedger.Year(int)`；输入表达式：`Year(d.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: year ?? Year(d.Season)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`d.Esports.CircuitAwards          .Where(a => a.Country == country && Year(a.Season) == (year ?? Year(d.Season))).Sum(a => a.Fortune)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.CircuitAwards          .Where(a => a.Country == country && Year(a.Season) == (year ?? Year(d.Season))).Sum(a => a.Fortune)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards          .Where(a => a.Country == country && Year(a.Season) == (year ?? Year(d.Season)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards          .Where(a => a.Country == country && Year(a.Season) == (year ?? Year(d.Season))).Sum`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4344e458a80a"></a>

## `NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData) — public static List<(string Country, int Points)> NationTable(CareerData d)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.StockCount(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-108387b6c9d0)；[`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)；[`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b665478390f0)；[`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)

**调用：** [`NationalSpire.CircuitLedger.Fortune(NationalSpire.CareerData, string, int?)`](CircuitLedger.cs.md#symbol-7d3715dcef4e)；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `(string Country, int Points).Country`；`(string Country, int Points).Points`；`NationalSpire.CircuitLedger.Fortune(NationalSpire.CareerData, string, int?)`；`NationalSpire.EsportsWorld.Countries`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitLedger.Fortune(NationalSpire.CareerData, string, int?)`；输入表达式：`Fortune(d, country)`；返回值紧邻使用处：`ArgumentSyntax: Points: Fortune(d, country)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`EsportsWorld.Countries          .Select(country => (Country: country, Points: Fortune(d, country))).OrderByDescending(x => x.Points)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EsportsWorld.Countries          .Select(country => (Country: country, Points: Fortune(d, country))).OrderByDescending(x => x.Points).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`EsportsWorld.Countries          .Select(country => (Country: country, Points: Fortune(d, country)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EsportsWorld.Countries          .Select(country => (Country: country, Points: Fortune(d, country))).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`EsportsWorld.Countries          .Select(country => (Country: country, Points: Fortune(d, country))).OrderByDescending(x => x.Points).ThenBy(x => x.Country, StringComparer.Ordinal).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => EsportsWorld.Countries          .Select(country => (Country: country, Points: Fortune(d, country))).OrderByDescending(x => x.Points).ThenBy(x => x.Country, StringComparer.Ordinal).ToList()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`EsportsWorld.Countries          .Select(country => (Country: country, Points: Fortune(d, country))).OrderByDescending(x => x.Points).ThenBy(x => x.Country, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EsportsWorld.Countries          .Select(country => (Country: country, Points: Fortune(d, country))).OrderByDescending(x => x.Points).ThenBy(x => x.Country, StringComparer.Ordinal).ToList`

**赋值（含属性/字段和局部值）：**


<a id="symbol-08cb65a2d635"></a>

## `NationalSpire.CircuitLedger.PublicStanding(NationalSpire.CareerData, string, int) — public static string PublicStanding(CareerData d, string id, int day)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?, NationalSpire.ChatTimeline.PublicMemoryRequest?)`](AiDiscussion.cs.md#symbol-7fe54dbd182e)；[`NationalSpire.AiService.PlayerPublicRecord(NationalSpire.CareerData, int, bool)`](AiContext.cs.md#symbol-99772c8e0814)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CircuitAward.Day`；`NationalSpire.CircuitAward.Event`；`NationalSpire.CircuitAward.Fortune`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Place`；`NationalSpire.CircuitAward.Season`；`NationalSpire.EsportsCareer.CircuitAwards`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("；", recent.Select(a => $"第{a.Season}赛季{a.Event}{a.Place}，贡献{a.Fortune}国运"))`；返回值紧邻使用处：`ReturnStatementSyntax: return string.Join("；", recent.Select(a => $"第{a.Season}赛季{a.Event}{a.Place}，贡献{a.Fortune}国运"));`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= day).OrderByDescending(a => a.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= day).OrderByDescending(a => a.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`recent.Select(a => $"第{a.Season}赛季{a.Event}{a.Place}，贡献{a.Fortune}国运")`；返回值紧邻使用处：`ArgumentSyntax: recent.Select(a => $"第{a.Season}赛季{a.Event}{a.Place}，贡献{a.Fortune}国运")`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= day).OrderByDescending(a => a.Day).Take(2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= day).OrderByDescending(a => a.Day).Take(2)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= day).OrderByDescending`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8ff7b69864e0"></a>

## `NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool) — public static void Settle(CareerData d, WorldCompetition c, bool publish)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.AdvanceCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition, int, bool)`](CircuitWorld.cs.md#symbol-0318d361b72c)

**调用：** [`NationalSpire.AvatarHonors.InvalidateRankings(NationalSpire.CareerData)`](AvatarHonors.cs.md#symbol-9fa8fce765cc)；[`NationalSpire.CareerAudience.ChampionGain(string)`](CareerAudience.cs.md#symbol-db3851edffc4)；[`NationalSpire.CareerAudience.Followers(NationalSpire.CareerData, string)`](CareerAudience.cs.md#symbol-7ca5980a38d5)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-4344e458a80a)；[`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`](CircuitLedger.cs.md#symbol-0791637c974d)；[`NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-95620df3f1f6)；[`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](CircuitWorld.cs.md#symbol-74904a83d22a)；[`NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`](ClubOperations.cs.md#symbol-a68dccdac5af)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`](EsportsWorld.cs.md#symbol-83220601bb1f)；[`NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-fce13966e68e)；[`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-abd0a463c72f)；[`NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`](NationalFortune.cs.md#symbol-236169683705)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-51faa8d5ccbd)；`NationalSpire.CircuitAward.CircuitAward()`；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `(string Country, int Points).Country`；`(string Country, int Points).Points`；`NationalSpire.AvatarHonors.InvalidateRankings(NationalSpire.CareerData)`；`NationalSpire.CareerAudience.ChampionGain(string)`；`NationalSpire.CareerAudience.Followers(NationalSpire.CareerData, string)`；`NationalSpire.CareerClub.Budget`；`NationalSpire.CareerClub.Fans`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Titles`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerLifeState.PrizeTotal`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerPerson.Fans`；`NationalSpire.CareerPerson.Titles`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CircuitAward.ClubId`；`NationalSpire.CircuitAward.CompetitionId`；`NationalSpire.CircuitAward.Completed`；`NationalSpire.CircuitAward.Country`；`NationalSpire.CircuitAward.Day`；`NationalSpire.CircuitAward.Event`；`NationalSpire.CircuitAward.Fortune`；`NationalSpire.CircuitAward.Kind`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Place`；`NationalSpire.CircuitAward.Points`；`NationalSpire.CircuitAward.Season`；`NationalSpire.CircuitAward.Stage`；`NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData)`；`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；`NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`；`NationalSpire.EsportsCareer.CircuitAwards`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`；`NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`；`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`；`NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NationalLegacy.Titles`；`NationalSpire.NationalLegacy.Treasury`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.WorldCompetition.ChampionId`；`NationalSpire.WorldCompetition.ChampionTeam`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldCompetition.PrizeVersion`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarHonors.InvalidateRankings(NationalSpire.CareerData)`；输入表达式：`AvatarHonors.InvalidateRankings(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: AvatarHonors.InvalidateRankings(d);`
- `NationalSpire.CareerAudience.ChampionGain(string)`；输入表达式：`CareerAudience.ChampionGain(c.Kind)`；返回值紧邻使用处：`ArgumentSyntax: CareerAudience.ChampionGain(c.Kind)`
- `NationalSpire.CareerAudience.ChampionGain(string)`；输入表达式：`CareerAudience.ChampionGain(c.Kind)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerAudience.Followers(d, id) + CareerAudience.ChampionGain(c.Kind)`
- `NationalSpire.CareerAudience.Followers(NationalSpire.CareerData, string)`；输入表达式：`CareerAudience.Followers(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerAudience.Followers(d, id) + CareerAudience.ChampionGain(c.Kind)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, c.ChampionId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent ? CircuitWorld.TeamName(d, c, c.ChampionTeam) : CareerEngine.DisplayName(d, c.ChampionId)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, id) is { } person`
- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "champion-" + c.Id, winner + "捧起" + c.Name + "奖杯", report, c.Kind == "league" ? "国内联赛" : "国际赛事", true,              c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId])`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "champion-" + c.Id, winner + "捧起" + c.Name + "奖杯", report, c.Kind == "league" ? "国内联赛" : "国际赛事", true,              c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId]);`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(dividend)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(dividend)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(placementPrize)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(placementPrize)}`
- `NationalSpire.CircuitAward.CircuitAward()`；输入表达式：`new CircuitAward { CompetitionId = c.Id, PersonId = id, Country = c.EntrantCountries[id], ClubId = c.EntrantClubs[id],                      Season = c.Season, Event = c.Name, Kind = c.Kind }`；返回值紧邻使用处：`AssignmentExpressionSyntax: award = new CircuitAward { CompetitionId = c.Id, PersonId = id, Country = c.EntrantCountries[id], ClubId = c.EntrantClubs[id],                      Season = c.Season, Event = c.Name, Kind = c.Kind }`
- `NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData)`；输入表达式：`NationTable(d)`；返回值紧邻使用处：`ElementAccessExpressionSyntax: NationTable(d)[0]`
- `NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；输入表达式：`Remember(d, "award-" + c.Id, detail, ["player"])`；返回值紧邻使用处：`ExpressionStatementSyntax: Remember(d, "award-" + c.Id, detail, ["player"]);`
- `NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；输入表达式：`Remember(d, "champion-" + c.Id, report, c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId])`；返回值紧邻使用处：`ExpressionStatementSyntax: Remember(d, "champion-" + c.Id, report, c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId]);`
- `NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；输入表达式：`CircuitWorld.RoundCount(c)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CircuitWorld.RoundCount(c)`
- `NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`CircuitWorld.TeamName(d, c, c.ChampionTeam)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent ? CircuitWorld.TeamName(d, c, c.ChampionTeam) : CareerEngine.DisplayName(d, c.ChampionId)`
- `NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`；输入表达式：`ClubOperations.Entry(club, d.Day, c.Name + "球队冠军奖金", teamPrize)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubOperations.Entry(club, d.Day, c.Name + "球队冠军奖金", teamPrize);`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, c.ChampionTeam)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, c.ChampionTeam) is { } club`
- `NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`；输入表达式：`EsportsWorld.Milestone(d, c.Id, c.Name + "冠军", detail, CareerAudience.ChampionGain(c.Kind), c.PrizeVersion >= 1 && c.Kind == "worldfinal" ? 0 : 1000)`；返回值紧邻使用处：`ExpressionStatementSyntax: EsportsWorld.Milestone(d, c.Id, c.Name + "冠军", detail, CareerAudience.ChampionGain(c.Kind), c.PrizeVersion >= 1 && c.Kind == "worldfinal" ? 0 : 1000);`
- `NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`；输入表达式：`EsportsWorld.Ranked(c)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EsportsWorld.Ranked(c).ToList`
- `NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`；输入表达式：`NationalDevelopment.Contribute(d, nation, fortune)`；返回值紧邻使用处：`ExpressionStatementSyntax: NationalDevelopment.Contribute(d, nation, fortune);`
- `NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`；输入表达式：`NationalFortune.Applies(c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: NationalFortune.Applies(c) ? 0 : fortune * 20`
- `NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`；输入表达式：`NationalFortune.Applies(c)`；返回值紧邻使用处：`IfStatementSyntax: if (NationalFortune.Applies(c)) fortune = award.Fortune;`
- `NationalSpire.NationalFortune.Applies(NationalSpire.WorldCompetition)`；输入表达式：`NationalFortune.Applies(c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !NationalFortune.Applies(c)`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`OwnedClubs.Pay(d, c.Name + "球队冠军奖金", teamPrize)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.Pay(d, c.Name + "球队冠军奖金", teamPrize);`
- `NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.SettleAchievements(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.SettleAchievements(d);`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`c.Fixtures.Where(f => f.HomeId == id || f.AwayId == id).Select(f => f.Round).DefaultIfEmpty(1).Max()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.Where(f => f.HomeId == id || f.AwayId == id).Select(f => f.Round).DefaultIfEmpty(1).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.Any(a => a.CompetitionId == c.Id && a.Completed)`；返回值紧邻使用处：`BinaryExpressionSyntax: !c.Finished || d.Esports.CircuitAwards.Any(a => a.CompetitionId == c.Id && a.Completed)`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`c.Fixtures.Where(f => f.HomeId == id || f.AwayId == id).Select(f => f.Round).DefaultIfEmpty(1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeId == id || f.AwayId == id).Select(f => f.Round).DefaultIfEmpty(1).Max`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`(c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId]).Select(id => c.EntrantCountries[id]).Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var country in (c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId]).Select(id => c.EntrantCountries[id]).Distinct())              { var nation = d.Esports.Nations.FirstOrDefault(n => n.Country == country); if (nation != null) nation.Titles++; }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.FirstOrDefault(a => a.CompetitionId == c.Id && a.PersonId == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.CircuitAwards.FirstOrDefault(a => a.CompetitionId == c.Id && a.PersonId == id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Nations.FirstOrDefault(n => n.Country == award.Country)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Nations.FirstOrDefault(n => n.Country == award.Country)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Nations.FirstOrDefault(n => n.Country == country)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Nations.FirstOrDefault(n => n.Country == country)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`(c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId]).Select(id => c.EntrantCountries[id])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (c.TeamEvent ? c.Rosters[c.ChampionTeam] : [c.ChampionId]).Select(id => c.EntrantCountries[id]).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Fixtures.Where(f => f.HomeId == id || f.AwayId == id).Select(f => f.Round)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeId == id || f.AwayId == id).Select(f => f.Round).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`EsportsWorld.Ranked(c).ToList()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EsportsWorld.Ranked(c).ToList().FindIndex`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeId == id || f.AwayId == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeId == id || f.AwayId == id).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.CircuitAwards.Add(award)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.CircuitAwards.Add(award);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`c.Rosters[c.ChampionTeam].Contains(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent ? c.Rosters[c.ChampionTeam].Contains(id) : id == c.ChampionId`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(id)`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`EsportsWorld.Ranked(c).ToList().FindIndex(t => t.PersonId == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.Ranked(c).ToList().FindIndex(t => t.PersonId == id) + 1`

**赋值（含属性/字段和局部值）：**

- `award.Completed` = `true`
- `award.Day` = `d.Day`
- `award.Fortune` = `fortune`
- `award.Place` = `place`
- `award.Points` = `points`
- `award.Stage` = `rank`
- `award` = `new CircuitAward { CompetitionId = c.Id, PersonId = id, Country = c.EntrantCountries[id], ClubId = c.EntrantClubs[id],                      Season = c.Season, Event = c.Name, Kind = c.Kind }`
- `club.Budget` += `teamPrize`
- `club.Fans` += `c.Kind == "continental" ? 500000 : 300000`
- `ClubId` = `c.EntrantClubs[id]`
- `CompetitionId` = `c.Id`
- `Country` = `c.EntrantCountries[id]`
- `d.Credits` += `dividend`
- `d.Credits` += `placementPrize`
- `d.Life.PrizeTotal` += `placementPrize`
- `Event` = `c.Name`
- `fortune` = `award.Fortune`
- `Kind` = `c.Kind`
- `nation.Treasury` += `fortune * 2`
- `person.Fans` = `CareerAudience.Followers(d, id) + CareerAudience.ChampionGain(c.Kind)`
- `PersonId` = `id`
- `report` += `$"国运榜目前由{top.Country}领跑，贡献{top.Points}。"`
- `Season` = `c.Season`

<a id="symbol-0791637c974d"></a>

## `NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>) — public static void Remember(CareerData d, string id, string text, List<string> people)`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CameoContent.CloseEdition(NationalSpire.CareerData, NationalSpire.WeeklyEdition)`](CameoContent.cs.md#symbol-6770922220c7)；[`NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CareerCommerce.cs.md#symbol-61ee1540f58f)；[`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)；[`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.CircuitPeople.SeasonChange(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-d77bf6cf914a)

**调用：** `NationalSpire.CommunityMemory.CommunityMemory()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Day`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemory.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemory.CommunityMemory()`；输入表达式：`new() { Id = id, PostId = id, Day = d.Day, Kind = "fact", Text = text, People = people.ToList() }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = id, PostId = id, Day = d.Day, Kind = "fact", Text = text, People = people.ToList() }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.CommunityMemories.Any(m => m.Id == id)`；返回值紧邻使用处：`IfStatementSyntax: if (d.CommunityMemories.Any(m => m.Id == id)) return;`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`people.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: People = people.ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.CommunityMemories.Add(new() { Id = id, PostId = id, Day = d.Day, Kind = "fact", Text = text, People = people.ToList() })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.CommunityMemories.Add(new() { Id = id, PostId = id, Day = d.Day, Kind = "fact", Text = text, People = people.ToList() });`

**赋值（含属性/字段和局部值）：**

- `Day` = `d.Day`
- `Id` = `id`
- `Kind` = `"fact"`
- `People` = `people.ToList()`
- `PostId` = `id`
- `Text` = `text`

<a id="symbol-b971fd6392cb"></a>

## `NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData) — public static void SeasonStart(CareerData d)`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-8e4cfe18b2fe)

**调用：** [`NationalSpire.CareerCommerce.SeasonStart(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-f162ea564744)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerLife.Grow(NationalSpire.CareerData, NationalSpire.CareerPerson, int, string)`](CareerLife.cs.md#symbol-1479dc400873)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CircuitLedger.CreateContract(NationalSpire.CareerData, string, int)`](CircuitLedger.cs.md#symbol-fe0f4a1b42d8)；[`NationalSpire.CircuitLedger.Fortune(NationalSpire.CareerData, string, int?)`](CircuitLedger.cs.md#symbol-7d3715dcef4e)；[`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`](CircuitLedger.cs.md#symbol-0791637c974d)；[`NationalSpire.CircuitLedger.Year(int)`](CircuitLedger.cs.md#symbol-bd9f405cdea7)；[`NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`](ClubOperations.cs.md#symbol-a68dccdac5af)；[`NationalSpire.NationalDevelopment.SeasonStart(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-e74fea2f7dca)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d66156cc1ea9)；[`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Budget`；`NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Titles`；`NationalSpire.CareerCommerce.SeasonStart(NationalSpire.CareerData)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLife.Grow(NationalSpire.CareerData, NationalSpire.CareerPerson, int, string)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CircuitLedger.CreateContract(NationalSpire.CareerData, string, int)`；`NationalSpire.CircuitLedger.Fortune(NationalSpire.CareerData, string, int?)`；`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.CircuitLedger.Year(int)`；`NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.LastDividendSeason`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsCareer.Sponsors`；`NationalSpire.NationalDevelopment.SeasonStart(NationalSpire.CareerData)`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NationalLegacy.Development`；`NationalSpire.NationalLegacy.Treasury`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.SponsorContract.Brand`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.PaidSeason`；`NationalSpire.SponsorContract.TargetId`；`NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`；`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.SeasonStart(NationalSpire.CareerData)`；输入表达式：`CareerCommerce.SeasonStart(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerCommerce.SeasonStart(d);`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(p.Id + d.Season)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerEngine.StableHash(p.Id + d.Season)`
- `NationalSpire.CareerLife.Grow(NationalSpire.CareerData, NationalSpire.CareerPerson, int, string)`；输入表达式：`CareerLife.Grow(d, youth, spending / 2, "national-" + d.Season)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.Grow(d, youth, spending / 2, "national-" + d.Season);`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(spending)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(spending)}`
- `NationalSpire.CircuitLedger.CreateContract(NationalSpire.CareerData, string, int)`；输入表达式：`CreateContract(d, club.Id, club.Titles > 0 ? 2 : 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: contract = CreateContract(d, club.Id, club.Titles > 0 ? 2 : 1)`
- `NationalSpire.CircuitLedger.Fortune(NationalSpire.CareerData, string, int?)`；输入表达式：`Fortune(d, nation.Country, previousYear)`；返回值紧邻使用处：`ArgumentSyntax: Fortune(d, nation.Country, previousYear)`
- `NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；输入表达式：`Remember(d, $"academy-grant-{nation.Country}-{d.Season}", $"{nation.Country}投入{CareerMoney.Format(spending)}国运奖金支持国内训练与青训，{youth.PublicName}获得训练计划支持。", [youth.Id])`；返回值紧邻使用处：`ExpressionStatementSyntax: Remember(d, $"academy-grant-{nation.Country}-{d.Season}", $"{nation.Country}投入{CareerMoney.Format(spending)}国运奖金支持国内训练与青训，{youth.PublicName}获得训练计划支持。", [youth.Id]);`
- `NationalSpire.CircuitLedger.Year(int)`；输入表达式：`Year(d.Season - 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Year(d.Season - 1)`
- `NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`；输入表达式：`ClubOperations.Entry(club, d.Day, contract.Brand + "赞助到账", payment)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubOperations.Entry(club, d.Day, contract.Brand + "赞助到账", payment);`
- `NationalSpire.NationalDevelopment.SeasonStart(NationalSpire.CareerData)`；输入表达式：`NationalDevelopment.SeasonStart(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: NationalDevelopment.SeasonStart(d);`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`OwnedClubs.Pay(d, "赛区发展支持", share)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.Pay(d, "赛区发展支持", share);`
- `NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.Initialize(d, contract)`；返回值紧邻使用处：`ExpressionStatementSyntax: SponsorIncome.Initialize(d, contract);`
- `NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.Retainer(d, contract)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SponsorIncome.Retainer(d, contract)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.Count(c => c.Country == nation.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: spending / d.Esports.Clubs.Count(c => c.Country == nation.Country)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`d.People.Where(p => p.Country == nation.Country && p.Role == "青训选手").OrderBy(p => CareerEngine.StableHash(p.Id + d.Season)).FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => p.Country == nation.Country && p.Role == "青训选手").OrderBy(p => CareerEngine.StableHash(p.Id + d.Season)).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Sponsors.LastOrDefault(s => s.TargetId == club.Id && s.EndSeason >= d.Season)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Sponsors.LastOrDefault(s => s.TargetId == club.Id && s.EndSeason >= d.Season)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => p.Country == nation.Country && p.Role == "青训选手").OrderBy(p => CareerEngine.StableHash(p.Id + d.Season))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == nation.Country && p.Role == "青训选手").OrderBy(p => CareerEngine.StableHash(p.Id + d.Season)).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.Where(c => c.Country == nation.Country)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var club in d.Esports.Clubs.Where(c => c.Country == nation.Country))                  {                      int share = spending / d.Esports.Clubs.Count(c => c.Country == nation.Country);                      if (club.Id == d.Esports.OwnedClub?.ClubId) OwnedClubs.Pay(d, "赛区发展支持", share);                      else club.Budget += share;                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.Where(c => c.Id != d.Esports.OwnedClub?.ClubId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var club in d.Esports.Clubs.Where(c => c.Id != d.Esports.OwnedClub?.ClubId))          {              var contract = d.Esports.Sponsors.LastOrDefault(s => s.TargetId == club.Id && s.EndSeason >= d.Season);              if (contract == null)              {                  contract = CreateContract(d, club.Id, club.Titles > 0 ? 2 : 1); d.Esports.Sponsors.Add(contract);              }              SponsorIncome.Initialize(d, contract);              if (contract.PaidSeason < d.Season) { int payment = SponsorIncome.Retainer(d, contract); club.Budget += payment; ClubOperations.Entry(club, d.Day, contract.Brand + "赞助到账", payment); contract.PaidSeason = d.Season; }          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Country == nation.Country && p.Role == "青训选手")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == nation.Country && p.Role == "青训选手").OrderBy`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Sponsors.Add(contract)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Sponsors.Add(contract);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(1500, Fortune(d, nation.Country, previousYear))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(1500, Fortune(d, nation.Country, previousYear))`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(nation.Treasury, gain)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(nation.Treasury, gain)`

**赋值（含属性/字段和局部值）：**

- `club.Budget` += `payment`
- `club.Budget` += `share`
- `contract.PaidSeason` = `d.Season`
- `contract` = `CreateContract(d, club.Id, club.Titles > 0 ? 2 : 1)`
- `d.Esports.LastDividendSeason` = `d.Season`
- `nation.Development` += `spending`
- `nation.Treasury` -= `spending`

<a id="symbol-fe0f4a1b42d8"></a>

## `NationalSpire.CircuitLedger.CreateContract(NationalSpire.CareerData, string, int) — private static SponsorContract CreateContract(CareerData d, string target, int tier)`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)

**调用：** [`NationalSpire.CareerAudience.ClubMultiplier(int)`](CareerAudience.cs.md#symbol-6230afa93ab3)；[`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`](CareerCommerce.cs.md#symbol-e72ebe7c108f)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`](ClubAudience.cs.md#symbol-6a78e48d0de3)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.RegionalOrganizations.SponsorDescription(string)`](RegionalOrganizations.cs.md#symbol-421e3c666278)；[`NationalSpire.RegionalOrganizations.Sponsors(string, int)`](RegionalOrganizations.cs.md#symbol-f76b5db64641)；[`NationalSpire.RegionalOrganizations.SponsorSlogan(string)`](RegionalOrganizations.cs.md#symbol-473ef110259c)；`NationalSpire.SponsorContract.SponsorContract()`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.ClubMultiplier(int)`；`NationalSpire.CareerClub.Country`；`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.RegionalOrganizations.SponsorDescription(string)`；`NationalSpire.RegionalOrganizations.Sponsors(string, int)`；`NationalSpire.RegionalOrganizations.SponsorSlogan(string)`；`NationalSpire.SponsorContract.Accepted`；`NationalSpire.SponsorContract.BaseRetainer`；`NationalSpire.SponsorContract.BaseWinBonus`；`NationalSpire.SponsorContract.Brand`；`NationalSpire.SponsorContract.Description`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.Id`；`NationalSpire.SponsorContract.Retainer`；`NationalSpire.SponsorContract.SignedDay`；`NationalSpire.SponsorContract.Slogan`；`NationalSpire.SponsorContract.StartSeason`；`NationalSpire.SponsorContract.TargetId`；`NationalSpire.SponsorContract.WinBonus`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.ClubMultiplier(int)`；输入表达式：`CareerAudience.ClubMultiplier(ClubAudience.Total(d, target))`；返回值紧邻使用处：`BinaryExpressionSyntax: tier * support * CareerAudience.ClubMultiplier(ClubAudience.Total(d, target))`
- `NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；输入表达式：`CareerCommerce.IdentityIndex(d, target)`；返回值紧邻使用处：`SwitchExpressionSyntax: CareerCommerce.IdentityIndex(d, target) switch { 0 => 3200, 1 => 2000, 2 => 4200, _ => 1600 }`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + target + d.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(d.WorldId + target + d.Season) % names.Length`
- `NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；输入表达式：`ClubAudience.Total(d, target)`；返回值紧邻使用处：`ArgumentSyntax: ClubAudience.Total(d, target)`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, target)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: EsportsWorld.Club(d, target)?.Country`
- `NationalSpire.RegionalOrganizations.SponsorDescription(string)`；输入表达式：`RegionalOrganizations.SponsorDescription(names[pick])`；返回值紧邻使用处：`AssignmentExpressionSyntax: Description = RegionalOrganizations.SponsorDescription(names[pick])`
- `NationalSpire.RegionalOrganizations.Sponsors(string, int)`；输入表达式：`RegionalOrganizations.Sponsors(EsportsWorld.Club(d, target)?.Country ?? d.Esports.Country, plan)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: plan => RegionalOrganizations.Sponsors(EsportsWorld.Club(d, target)?.Country ?? d.Esports.Country, plan)`
- `NationalSpire.RegionalOrganizations.SponsorSlogan(string)`；输入表达式：`RegionalOrganizations.SponsorSlogan(names[pick])`；返回值紧邻使用处：`AssignmentExpressionSyntax: Slogan = RegionalOrganizations.SponsorSlogan(names[pick])`
- `NationalSpire.SponsorContract.SponsorContract()`；输入表达式：`new() { Id = target + "-" + d.Season, Brand = names[pick], TargetId = target, StartSeason = d.Season, EndSeason = d.Season + 1,              Accepted = true, SignedDay = d.Day, BaseRetainer = tier * support, BaseWinBonus = 0, Retainer = (int)Math.Round(tier * support * CareerAudience.ClubMultiplier(ClubAudience.Total(d, target))), WinBonus = 0,              Description = RegionalOrganizations.SponsorDescription(names[pick]), Slogan = RegionalOrganizations.SponsorSlogan(names[pick]) }`；返回值紧邻使用处：`ReturnStatementSyntax: return new() { Id = target + "-" + d.Season, Brand = names[pick], TargetId = target, StartSeason = d.Season, EndSeason = d.Season + 1,              Accepted = true, SignedDay = d.Day, BaseRetainer = tier * support, BaseWinBonus = 0, Retainer = (int)Math.Round(tier * support * CareerAudience.ClubMultiplier(ClubAudience.Total(d, target))), WinBonus = 0,              Description = RegionalOrganizations.SponsorDescription(names[pick]), Slogan = RegionalOrganizations.SponsorSlogan(names[pick]) };`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`Enumerable.Range(0, 3).SelectMany(plan => RegionalOrganizations.Sponsors(EsportsWorld.Club(d, target)?.Country ?? d.Esports.Country, plan))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, 3).SelectMany(plan => RegionalOrganizations.Sponsors(EsportsWorld.Club(d, target)?.Country ?? d.Esports.Country, plan)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0, 3).SelectMany(plan => RegionalOrganizations.Sponsors(EsportsWorld.Club(d, target)?.Country ?? d.Esports.Country, plan)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Enumerable.Range(0, 3).SelectMany(plan => RegionalOrganizations.Sponsors(EsportsWorld.Club(d, target)?.Country ?? d.Esports.Country, plan)).ToArray()`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, 3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, 3).SelectMany`
- `System.Math.Round(double)`；输入表达式：`Math.Round(tier * support * CareerAudience.ClubMultiplier(ClubAudience.Total(d, target)))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(tier * support * CareerAudience.ClubMultiplier(ClubAudience.Total(d, target)))`

**赋值（含属性/字段和局部值）：**

- `Accepted` = `true`
- `BaseRetainer` = `tier * support`
- `BaseWinBonus` = `0`
- `Brand` = `names[pick]`
- `Description` = `RegionalOrganizations.SponsorDescription(names[pick])`
- `EndSeason` = `d.Season + 1`
- `Id` = `target + "-" + d.Season`
- `Retainer` = `(int)Math.Round(tier * support * CareerAudience.ClubMultiplier(ClubAudience.Total(d, target)))`
- `SignedDay` = `d.Day`
- `Slogan` = `RegionalOrganizations.SponsorSlogan(names[pick])`
- `StartSeason` = `d.Season`
- `TargetId` = `target`
- `WinBonus` = `0`

<a id="symbol-dd115cb81ebf"></a>

## `NationalSpire.CircuitLedger.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static void PlayerMatch(CareerData d, CareerMatch m)`

来源：源码第 149 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)

**调用：** [`NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CareerCommerce.cs.md#symbol-61ee1540f58f)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`CareerCommerce.PlayerMatch(d, m)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerCommerce.PlayerMatch(d, m);`

**赋值（含属性/字段和局部值）：**
