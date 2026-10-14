# CareerAudience.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`2A2C16FE0E94C9E17C4D592031C35070639FC88622154A15CFE420717089F458`。来源：[源码](../../CareerAudience.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerAudience`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly (int Floor, string Name)[] Titles = [(0, "社区小有名气"), (5000, "城市赛级"), (20000, "职业新人"), (100000, "联赛主力"), (500000, "明星选手"), (2000000, "洲际级明星"), (10000000, "世界级偶像"), (50000000, "传奇")];
```

<a id="symbol-84c90f2dbee3"></a>

## `NationalSpire.CareerAudience.Title(int) — public static string Title(int fans)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Last<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(int Floor, string Name).Floor`；`(int Floor, string Name).Name`；`NationalSpire.CareerAudience.Titles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Last<TSource>(System.Func<TSource, bool>)`；输入表达式：`Titles.Last(t => fans >= t.Floor)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Titles.Last(t => fans >= t.Floor).Name`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7ca5980a38d5"></a>

## `NationalSpire.CareerAudience.Followers(NationalSpire.CareerData, string) — public static int Followers(CareerData d, string id)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerAudience.cs.md#symbol-889a215412c7)；[`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.SeasonCeremony.Close(NationalSpire.CareerData)`](SeasonCeremony.cs.md#symbol-245a6f827582)

**调用：** [`NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`](CareerAudience.cs.md#symbol-c169fde4fb8f)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`；输入表达式：`Followers(p)`；返回值紧邻使用处：`ReturnStatementSyntax: return Followers(p);`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(d, id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c169fde4fb8f"></a>

## `NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson) — public static int Followers(CareerPerson p)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAudience.Followers(NationalSpire.CareerData, string)`](CareerAudience.cs.md#symbol-7ca5980a38d5)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`](ClubAudience.cs.md#symbol-6a78e48d0de3)；[`NationalSpire.SeasonCeremony.Close(NationalSpire.CareerData)`](SeasonCeremony.cs.md#symbol-245a6f827582)

**调用：** `System.Math.Clamp(int, int, int)`；`System.Math.Exp(double)`；`System.Math.Min(int, int)`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Fans`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Titles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(p.Rating - 1000, -500, 1400)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Clamp(p.Rating - 1000, -500, 1400) / 350.0`
- `System.Math.Exp(double)`；输入表达式：`Math.Exp(Math.Clamp(p.Rating - 1000, -500, 1400) / 350.0)`；返回值紧邻使用处：`BinaryExpressionSyntax: 400 * Math.Exp(Math.Clamp(p.Rating - 1000, -500, 1400) / 350.0)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(p.Titles, 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(p.Titles, 10) * 1500`
- `System.Math.Round(double)`；输入表达式：`Math.Round(400 * Math.Exp(Math.Clamp(p.Rating - 1000, -500, 1400) / 350.0) + Math.Min(p.Titles, 10) * 1500)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(400 * Math.Exp(Math.Clamp(p.Rating - 1000, -500, 1400) / 350.0) + Math.Min(p.Titles, 10) * 1500)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-58faacd06f00"></a>

## `NationalSpire.CareerAudience.MatchGain(string, int, bool, bool, bool, int, double, int) — public static int MatchGain(string kind, int ascension, bool won, bool draw, bool forfeit, int floor, double multiplier = 1, int round = 1)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerAudience.cs.md#symbol-889a215412c7)；[`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)

**调用：** [`NationalSpire.CareerAudience.RoundMultiplier(int)`](CareerAudience.cs.md#symbol-14e208558d78)；[`NationalSpire.MatchRules.Reward(int, double)`](MatchRules.cs.md#symbol-1b4687e2daa3)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.RoundMultiplier(int)`；`NationalSpire.MatchRules.Reward(int, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.RoundMultiplier(int)`；输入表达式：`RoundMultiplier(round)`；返回值紧邻使用处：`ConditionalExpressionSyntax: kind is "continental" or "worldcup" or "worldfinal" ? RoundMultiplier(round) : 1`
- `NationalSpire.MatchRules.Reward(int, double)`；输入表达式：`MatchRules.Reward((int)(basis * stage * .4), multiplier)`；返回值紧邻使用处：`ConditionalExpressionSyntax: draw ? MatchRules.Reward((int)(basis * stage * .4), multiplier) : Math.Max(3, floor / 3)`
- `NationalSpire.MatchRules.Reward(int, double)`；输入表达式：`MatchRules.Reward((int)(basis * stage), multiplier)`；返回值紧邻使用处：`ConditionalExpressionSyntax: won ? MatchRules.Reward((int)(basis * stage), multiplier)              : draw ? MatchRules.Reward((int)(basis * stage * .4), multiplier) : Math.Max(3, floor / 3)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(3, floor / 3)`；返回值紧邻使用处：`ConditionalExpressionSyntax: draw ? MatchRules.Reward((int)(basis * stage * .4), multiplier) : Math.Max(3, floor / 3)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-14e208558d78"></a>

## `NationalSpire.CareerAudience.RoundMultiplier(int) — public static double RoundMultiplier(int round)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAudience.MatchGain(string, int, bool, bool, bool, int, double, int)`](CareerAudience.cs.md#symbol-58faacd06f00)；[`NationalSpire.ClubAudience.RoundGain(string, int, bool)`](ClubAudience.cs.md#symbol-10f11d54fbbe)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-db3851edffc4"></a>

## `NationalSpire.CareerAudience.ChampionGain(string) — public static int ChampionGain(string kind)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f8e484fe597e"></a>

## `NationalSpire.CareerAudience.QuoteMultiplier(int) — public static double QuoteMultiplier(int fans)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAudience.Quote(int, int)`](CareerAudience.cs.md#symbol-b5169ddb9dda)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)

**调用：** `System.Math.Max(int, int)`；`System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, fans) / 100000.0`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(1 + Math.Max(0, fans) / 100000.0, .6390841180914144)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Math.Pow(1 + Math.Max(0, fans) / 100000.0, .6390841180914144)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6230afa93ab3"></a>

## `NationalSpire.CareerAudience.ClubMultiplier(int) — public static double ClubMultiplier(int fans)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.CreateContract(NationalSpire.CareerData, string, int)`](CircuitLedger.cs.md#symbol-fe0f4a1b42d8)；[`NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`](ClubOperations.cs.md#symbol-213a7e731998)；[`NationalSpire.OwnedClubs.AudienceIncome(int)`](OwnedClubs.cs.md#symbol-b2b3c8e1de88)；[`NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`](OwnedClubs.cs.md#symbol-c9d09ed04c48)；[`NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int)`](OwnedClubs.cs.md#symbol-27e3d96628f4)

**调用：** `System.Math.Max(int, int)`；`System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, fans) / 100000.0`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(1 + Math.Max(0, fans) / 100000.0, .662800438550683)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Math.Pow(1 + Math.Max(0, fans) / 100000.0, .662800438550683)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b5169ddb9dda"></a>

## `NationalSpire.CareerAudience.Quote(int, int) — public static int Quote(int original, int fans)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)

**调用：** [`NationalSpire.CareerAudience.QuoteMultiplier(int)`](CareerAudience.cs.md#symbol-f8e484fe597e)；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.QuoteMultiplier(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.QuoteMultiplier(int)`；输入表达式：`QuoteMultiplier(fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: original * QuoteMultiplier(fans)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(original * QuoteMultiplier(fans))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(original * QuoteMultiplier(fans))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d4f18e34de92"></a>

## `NationalSpire.CareerAudience.PromotionGain(int, int, int) — public static int PromotionGain(int fans, int price, int used)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)

**调用：** `System.Math.Round(double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Round(double)`；输入表达式：`Math.Round(price / 2.0 / (1 + .5 * used))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(price / 2.0 / (1 + .5 * used))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-889a215412c7"></a>

## `NationalSpire.CareerAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture) — public static void Fixture(CareerData d, WorldCompetition c, WorldFixture f)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`](EsportsWorld.cs.md#symbol-f16aef3da82a)

**调用：** [`NationalSpire.CareerAudience.Followers(NationalSpire.CareerData, string)`](CareerAudience.cs.md#symbol-7ca5980a38d5)；[`NationalSpire.CareerAudience.MatchGain(string, int, bool, bool, bool, int, double, int)`](CareerAudience.cs.md#symbol-58faacd06f00)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`](CircuitWorld.cs.md#symbol-4d6f1758c06b)；[`NationalSpire.ClubAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](ClubAudience.cs.md#symbol-2ba02e4068ba)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.Followers(NationalSpire.CareerData, string)`；`NationalSpire.CareerAudience.MatchGain(string, int, bool, bool, bool, int, double, int)`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Fans`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`；`NationalSpire.ClubAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldFixture.Ascension`；`NationalSpire.WorldFixture.AwayFloor`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Draw`；`NationalSpire.WorldFixture.HomeFloor`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.Walkover`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.Followers(NationalSpire.CareerData, string)`；输入表达式：`Followers(d, person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Followers(d, person.Id) + MatchGain(c.Kind, f.Ascension, f.WinnerId == id, f.Draw, f.Walkover, id == f.HomeId ? f.HomeFloor : f.AwayFloor, round: f.Round)`
- `NationalSpire.CareerAudience.MatchGain(string, int, bool, bool, bool, int, double, int)`；输入表达式：`MatchGain(c.Kind, f.Ascension, f.WinnerId == id, f.Draw, f.Walkover, id == f.HomeId ? f.HomeFloor : f.AwayFloor, round: f.Round)`；返回值紧邻使用处：`BinaryExpressionSyntax: Followers(d, person.Id) + MatchGain(c.Kind, f.Ascension, f.WinnerId == id, f.Draw, f.Walkover, id == f.HomeId ? f.HomeFloor : f.AwayFloor, round: f.Round)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`；输入表达式：`CircuitWorld.CooperativeRoster(d, c, id, f.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Cooperative ? CircuitWorld.CooperativeRoster(d, c, id, f.Id) : [CareerEngine.Person(d, id)!]`
- `NationalSpire.ClubAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；输入表达式：`ClubAudience.Fixture(d, c, f)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubAudience.Fixture(d, c, f);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Where(p => p != null)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var person in people.Where(p => p != null))                  person.Fans = Followers(d, person.Id) + MatchGain(c.Kind, f.Ascension, f.WinnerId == id, f.Draw, f.Walkover, id == f.HomeId ? f.HomeFloor : f.AwayFloor, round: f.Round);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "player" || d.HumanIds.Contains(id)`

**赋值（含属性/字段和局部值）：**

- `person.Fans` = `Followers(d, person.Id) + MatchGain(c.Kind, f.Ascension, f.WinnerId == id, f.Draw, f.Walkover, id == f.HomeId ? f.HomeFloor : f.AwayFloor, round: f.Round)`
