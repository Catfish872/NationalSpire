# MatchRules.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`02E3E389DBBC616B496411B107B2CEBDA0C82E303EA284F843D4131492BC37A3`。来源：[源码](../../MatchRules.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.RunPerformance`、`NationalSpire.ChanceFactors`、`NationalSpire.MatchRules`。

字段、事件及初始值（源码原样）：

```csharp
private const string SeedCharacters = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ";
```

<a id="symbol-9c10d376ab64"></a>

## `NationalSpire.ChanceFactors.Bonus — public double Bonus`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ChanceFactors.Growth`；`NationalSpire.ChanceFactors.Mood`；`NationalSpire.ChanceFactors.Practice`；`NationalSpire.ChanceFactors.Skill`；`NationalSpire.ChanceFactors.Training`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-af480d7f5fec"></a>

## `NationalSpire.ChanceFactors.Final — public double Final`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MatchRules.ApplyBonuses(double, double)`](MatchRules.cs.md#symbol-106ba804f7f1)

**字段、属性、事件及方法组引用：** `NationalSpire.ChanceFactors.Basis`；`NationalSpire.ChanceFactors.Bonus`；`NationalSpire.MatchRules.ApplyBonuses(double, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRules.ApplyBonuses(double, double)`；输入表达式：`MatchRules.ApplyBonuses(Basis, Bonus)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => MatchRules.ApplyBonuses(Basis, Bonus)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-065d0664a7cb"></a>

## `NationalSpire.ChanceFactors.Display() — public string Display()`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)

**调用：** [`Percent(double)`](MatchRules.cs.md#symbol-d40856cf62ca)；`System.Math.Abs(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChanceFactors.Basis`；`NationalSpire.ChanceFactors.Bonus`；`NationalSpire.ChanceFactors.Final`；`NationalSpire.ChanceFactors.Growth`；`NationalSpire.ChanceFactors.Mood`；`NationalSpire.ChanceFactors.Practice`；`NationalSpire.ChanceFactors.Skill`；`NationalSpire.ChanceFactors.Training`；`Percent(double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Percent(double)`；输入表达式：`Percent(Basis)`；返回值紧邻使用处：`BinaryExpressionSyntax: "基础" + Percent(Basis)`
- `Percent(double)`；输入表达式：`Percent(Final)`；返回值紧邻使用处：`BinaryExpressionSyntax: Percent(Final) + "（"`
- `Percent(double)`；输入表达式：`Percent(Math.Abs(value))`；返回值紧邻使用处：`BinaryExpressionSyntax: (value > 0 ? " + " : " − ") + name + Percent(Math.Abs(value))`
- `Percent(double)`；输入表达式：`Percent(total - Final)`；返回值紧邻使用处：`BinaryExpressionSyntax: " − 高概率衰减" + Percent(total - Final)`
- `System.Math.Abs(double)`；输入表达式：`Math.Abs(value)`；返回值紧邻使用处：`ArgumentSyntax: Math.Abs(value)`

**赋值（含属性/字段和局部值）：**

- `formula` += `" − 高概率衰减" + Percent(total - Final)`
- `formula` += `"，最低0%"`
- `formula` += `(value > 0 ? " + " : " − ") + name + Percent(Math.Abs(value))`

<a id="symbol-d40856cf62ca"></a>

## `Percent(double) — static string Percent(double value)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChanceFactors.Display()`](MatchRules.cs.md#symbol-065d0664a7cb)

**调用：** `double.ToString(string?, System.IFormatProvider?)`；`System.Math.Abs(double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `double.ToString(string?, System.IFormatProvider?)`；输入表达式：`(value * 100).ToString(              value != 0 && Math.Abs(value * 100) < .01 ? "0.##########" : "0.##",              System.Globalization.CultureInfo.InvariantCulture)`；返回值紧邻使用处：`BinaryExpressionSyntax: (value * 100).ToString(              value != 0 && Math.Abs(value * 100) < .01 ? "0.##########" : "0.##",              System.Globalization.CultureInfo.InvariantCulture) + "%"`
- `System.Math.Abs(double)`；输入表达式：`Math.Abs(value * 100)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(value * 100) < .01`

**赋值（含属性/字段和局部值）：**


<a id="symbol-73f327295a53"></a>

## `NationalSpire.MatchRules.PreferredAscension(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static int PreferredAscension(CareerData data, CareerMatch match)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** `System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.SelectedAscension`；`NationalSpire.CareerMatch.ChosenAscension`；`NationalSpire.CareerMatch.RequiredAscension`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(match.ChosenAscension ?? data.SelectedAscension, match.RequiredAscension, 10)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Math.Clamp(match.ChosenAscension ?? data.SelectedAscension, match.RequiredAscension, 10)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-47435ccfb229"></a>

## `NationalSpire.MatchRules.RivalTimeScale(int) — public static double RivalTimeScale(int level)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`](MatchRules.cs.md#symbol-ce476ea84a29)；[`NationalSpire.PlayerSimulation.Sample(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<NationalSpire.CareerResult>?, int?)`](PlayerSimulation.cs.md#symbol-a3059e9b8f34)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7a4196460ee7"></a>

## `NationalSpire.MatchRules.SetRivalLevel(NationalSpire.CareerData, int) — public static void SetRivalLevel(CareerData data, int level)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** `System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.RivalLevel`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.PlayedAscension`；`NationalSpire.CareerMatch.PlayerSeconds`；`NationalSpire.CareerMatch.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请选择有效的局内 AI 水平。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请选择有效的局内 AI 水平。");`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m => m.Status == "待赛" && m.Live == null && m.PlayedAscension == null && m.PlayerSeconds == null)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var match in data.Matches.Where(m => m.Status == "待赛" && m.Live == null && m.PlayedAscension == null && m.PlayerSeconds == null))          { match.OpponentPrepared = false; match.OpponentSeconds = null; }`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请在本场比赛结束后调整。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请在本场比赛结束后调整。");`

**赋值（含属性/字段和局部值）：**

- `data.RivalLevel` = `level`
- `match.OpponentPrepared` = `false`
- `match.OpponentSeconds` = `null`

<a id="symbol-287afca401f9"></a>

## `NationalSpire.MatchRules.RandomizeSeed(string, string, int) — public static string RandomizeSeed(string seed, string kind = "", int season = 0)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.ReplayTie(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CircuitWorld.cs.md#symbol-561246434113)；[`NationalSpire.MatchRules.PrepareSeed(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchRules.cs.md#symbol-27c230d3a150)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；`string.Contains(string, System.StringComparison)`；`string.StartsWith(string, System.StringComparison)`；`string.String(System.ReadOnlySpan<char>)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Math.Abs(int)`；`System.Security.Cryptography.RandomNumberGenerator.GetInt32(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.MatchRules.SeedCharacters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(seed)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`seed.Contains(value, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: value => seed.Contains(value, StringComparison.OrdinalIgnoreCase)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`seed.StartsWith("NS", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: seed.Length == 14 && seed.StartsWith("NS", StringComparison.Ordinal)`
- `string.String(System.ReadOnlySpan<char>)`；输入表达式：`new string(random)`；返回值紧邻使用处：`BinaryExpressionSyntax: prefix + new string(random)`
- `string.String(System.ReadOnlySpan<char>)`；输入表达式：`new string(schedule)`；返回值紧邻使用处：`BinaryExpressionSyntax: "NS" + eventCode + SeedCharacters[Math.Abs(season) % SeedCharacters.Length] + new string(schedule)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`seed.All(SeedCharacters.Contains)`；返回值紧邻使用处：`BinaryExpressionSyntax: seed.Length == 14 && seed.StartsWith("NS", StringComparison.Ordinal)              && seed.All(SeedCharacters.Contains)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { "worldfinal", "worldcup", "continental", "league", "academy", "local", "city", "masters", "open" }                      .FirstOrDefault(value => seed.Contains(value, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`BinaryExpressionSyntax: new[] { "worldfinal", "worldcup", "continental", "league", "academy", "local", "city", "masters", "open" }                      .FirstOrDefault(value => seed.Contains(value, StringComparison.OrdinalIgnoreCase)) ?? "legacy"`
- `System.Math.Abs(int)`；输入表达式：`Math.Abs(season)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(season) % SeedCharacters.Length`
- `System.Security.Cryptography.RandomNumberGenerator.GetInt32(int)`；输入表达式：`System.Security.Cryptography.RandomNumberGenerator.GetInt32(SeedCharacters.Length)`；返回值紧邻使用处：`ArgumentSyntax: System.Security.Cryptography.RandomNumberGenerator.GetInt32(SeedCharacters.Length)`

**赋值（含属性/字段和局部值）：**

- `identity` /= `SeedCharacters.Length`
- `kind` = `new[] { "worldfinal", "worldcup", "continental", "league", "academy", "local", "city", "masters", "open" }                      .FirstOrDefault(value => seed.Contains(value, StringComparison.OrdinalIgnoreCase)) ?? "legacy"`
- `prefix` = `"NS" + eventCode + SeedCharacters[Math.Abs(season) % SeedCharacters.Length] + new string(schedule)`
- `prefix` = `seed[..8]`
- `random[i]` = `SeedCharacters[System.Security.Cryptography.RandomNumberGenerator.GetInt32(SeedCharacters.Length)]`
- `schedule[i]` = `SeedCharacters[identity % SeedCharacters.Length]`

<a id="symbol-27c230d3a150"></a>

## `NationalSpire.MatchRules.PrepareSeed(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static void PrepareSeed(CareerData data, CareerMatch match)`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Prepare(NationalSpire.Coop.CoopWorld, string, int, System.Collections.Generic.IReadOnlySet<string>, System.Collections.Generic.IReadOnlySet<ulong>?)`](Coop/CoopRules.cs.md#symbol-570bf786ec18)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.PlayerSimulation.Run(NationalSpire.CareerData, NationalSpire.CareerMatch, string, string, int?)`](PlayerSimulation.cs.md#symbol-4d8d262e25f1)

**调用：** [`NationalSpire.MatchRules.RandomizeSeed(string, string, int)`](MatchRules.cs.md#symbol-287afca401f9)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.PlayedAscension`；`NationalSpire.CareerMatch.PlayerSeconds`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerMatch.SeedRandomized`；`NationalSpire.CareerMatch.Status`；`NationalSpire.MatchRules.RandomizeSeed(string, string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRules.RandomizeSeed(string, string, int)`；输入表达式：`RandomizeSeed(match.Seed, match.Kind, data.Season)`；返回值紧邻使用处：`AssignmentExpressionSyntax: next = RandomizeSeed(match.Seed, match.Kind, data.Season)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Any(other => other.Id != match.Id && other.Seed == next)`；返回值紧邻使用处：`BinaryExpressionSyntax: next == match.Seed || data.Matches.Any(other => other.Id != match.Id && other.Seed == next)`

**赋值（含属性/字段和局部值）：**

- `match.OpponentPrepared` = `false`
- `match.OpponentSeconds` = `null`
- `match.Seed` = `next`
- `match.SeedRandomized` = `true`
- `next` = `RandomizeSeed(match.Seed, match.Kind, data.Season)`

<a id="symbol-13057648d955"></a>

## `NationalSpire.MatchRules.RatingEffect(NationalSpire.CareerPerson) — private static double RatingEffect(CareerPerson person)`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`](MatchRules.cs.md#symbol-4f16d2879002)

**调用：** `System.Math.Log(double)`；`System.Math.Max(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Rating`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Log(double)`；输入表达式：`Math.Log(value)`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 + Math.Log(value)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(-1, value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: value <= 1 ? Math.Max(-1, value) : 1 + Math.Log(value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7d569e72b64e"></a>

## `NationalSpire.MatchRules.ClearChance(NationalSpire.CareerPerson, int, double, int?) — public static double ClearChance(CareerPerson person, int officialAscension, double chanceBonus = 0, int? day = null)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.Simulate(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`](MatchRules.cs.md#symbol-5c3948362434)

**调用：** [`NationalSpire.CareerTraining.MoodBonus(NationalSpire.CareerPerson, int)`](CareerTraining.cs.md#symbol-c4594213bd74)；[`NationalSpire.CareerTraining.SkillBonus(NationalSpire.CareerPerson)`](CareerTraining.cs.md#symbol-9666787c9619)；[`NationalSpire.MatchRules.ApplyBonuses(double, double)`](MatchRules.cs.md#symbol-106ba804f7f1)；[`NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`](MatchRules.cs.md#symbol-4f16d2879002)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerTraining.MoodBonus(NationalSpire.CareerPerson, int)`；`NationalSpire.CareerTraining.SkillBonus(NationalSpire.CareerPerson)`；`NationalSpire.MatchRules.ApplyBonuses(double, double)`；`NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerTraining.MoodBonus(NationalSpire.CareerPerson, int)`；输入表达式：`CareerTraining.MoodBonus(person, day.Value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: day.HasValue ? CareerTraining.MoodBonus(person, day.Value) : 0`
- `NationalSpire.CareerTraining.SkillBonus(NationalSpire.CareerPerson)`；输入表达式：`CareerTraining.SkillBonus(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: chanceBonus + CareerTraining.SkillBonus(person)`
- `NationalSpire.MatchRules.ApplyBonuses(double, double)`；输入表达式：`ApplyBonuses(BaseChance(person, officialAscension), chanceBonus + CareerTraining.SkillBonus(person)              + (day.HasValue ? CareerTraining.MoodBonus(person, day.Value) : 0))`；返回值紧邻使用处：`ReturnStatementSyntax: return ApplyBonuses(BaseChance(person, officialAscension), chanceBonus + CareerTraining.SkillBonus(person)              + (day.HasValue ? CareerTraining.MoodBonus(person, day.Value) : 0));`
- `NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`；输入表达式：`BaseChance(person, officialAscension)`；返回值紧邻使用处：`ArgumentSyntax: BaseChance(person, officialAscension)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4f16d2879002"></a>

## `NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int) — public static double BaseChance(CareerPerson person, int officialAscension)`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerPerson, int, double, int?)`](MatchRules.cs.md#symbol-7d569e72b64e)；[`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`](MatchRules.cs.md#symbol-92264d5fcfdd)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivatePublicContext.cs.md#symbol-3d184de3074e)

**调用：** [`NationalSpire.CareerEngine.WinChance(int, int)`](CareerEngine.cs.md#symbol-da7e19461394)；[`NationalSpire.MatchRules.CustomChanceAtAscension(double, int, int)`](MatchRules.cs.md#symbol-928c3ecd1094)；[`NationalSpire.MatchRules.RatingEffect(NationalSpire.CareerPerson)`](MatchRules.cs.md#symbol-13057648d955)；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Math.Exp(double)`；`System.Math.Max(double, double)`；`System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.WinChance(int, int)`；`NationalSpire.CareerPerson.CustomClearChance`；`NationalSpire.CareerPerson.Form`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.MatchRules.CustomChanceAtAscension(double, int, int)`；`NationalSpire.MatchRules.RatingEffect(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.WinChance(int, int)`；输入表达式：`CareerEngine.WinChance(officialAscension, person.MaxAscension)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.WinChance(officialAscension, person.MaxAscension)              * Math.Exp(rating * 0.06 + form * 0.008)`
- `NationalSpire.MatchRules.CustomChanceAtAscension(double, int, int)`；输入表达式：`CustomChanceAtAscension(custom, person.MaxAscension, officialAscension)`；返回值紧邻使用处：`ReturnStatementSyntax: return CustomChanceAtAscension(custom, person.MaxAscension, officialAscension);`
- `NationalSpire.MatchRules.RatingEffect(NationalSpire.CareerPerson)`；输入表达式：`RatingEffect(person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RatingEffect(person)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`person.Form.TakeLast(5).Sum(c => c == '胜' ? 1 : c == '负' ? -1 : 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = person.Form.TakeLast(5).Sum(c => c == '胜' ? 1 : c == '负' ? -1 : 0)`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`person.Form.TakeLast(5)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: person.Form.TakeLast(5).Sum`
- `System.Math.Exp(double)`；输入表达式：`Math.Exp(rating * 0.06 + form * 0.008)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.WinChance(officialAscension, person.MaxAscension)              * Math.Exp(rating * 0.06 + form * 0.008)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0.00001, CareerEngine.WinChance(officialAscension, person.MaxAscension)              * Math.Exp(rating * 0.06 + form * 0.008))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(0.00001, CareerEngine.WinChance(officialAscension, person.MaxAscension)              * Math.Exp(rating * 0.06 + form * 0.008))`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(0.35, officialAscension - person.MaxAscension)`；返回值紧邻使用处：`AssignmentExpressionSyntax: chance *= Math.Pow(0.35, officialAscension - person.MaxAscension)`

**赋值（含属性/字段和局部值）：**

- `chance` *= `Math.Pow(0.35, officialAscension - person.MaxAscension)`

<a id="symbol-106ba804f7f1"></a>

## `NationalSpire.MatchRules.ApplyBonuses(double, double) — public static double ApplyBonuses(double basis, double bonus)`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChanceFactors.Final`](MatchRules.cs.md#symbol-af480d7f5fec)；[`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerPerson, int, double, int?)`](MatchRules.cs.md#symbol-7d569e72b64e)

**调用：** `System.Math.Clamp(double, double, double)`；`System.Math.Max(double, double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(total, 0, 1)`；返回值紧邻使用处：`ReturnStatementSyntax: return Math.Clamp(total, 0, 1);`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(.94, basis)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(.94, basis)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-92264d5fcfdd"></a>

## `NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool) — public static ChanceFactors Evaluate(CareerData data, CareerPerson person, int ascension, int? day = null, bool includePractice = true)`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.TeamMatchBonus(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, int, int)`](CareerLife.cs.md#symbol-1fcea966dfa4)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerTraining.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-8fa9f91feb98)；[`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`](MatchRules.cs.md#symbol-a0517de2db43)；[`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`](MatchRules.cs.md#symbol-8fd1cedc82b2)；[`NationalSpire.MatchRules.TeamChance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int, int)`](MatchRules.cs.md#symbol-bd837370982f)；[`NationalSpire.OwnedClubs.PracticeContribution(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`](OwnedClubs.cs.md#symbol-6e1b22fd81bb)

**调用：** [`NationalSpire.CareerTraining.MoodBonus(NationalSpire.CareerPerson, int)`](CareerTraining.cs.md#symbol-c4594213bd74)；[`NationalSpire.CareerTraining.Permanent(NationalSpire.CareerData, string, int)`](CareerTraining.cs.md#symbol-e4aeba396356)；[`NationalSpire.CareerTraining.SkillBonus(NationalSpire.CareerPerson)`](CareerTraining.cs.md#symbol-9666787c9619)；[`NationalSpire.CareerTraining.Temporary(NationalSpire.CareerData, string, int, bool)`](CareerTraining.cs.md#symbol-3a66a2b5dee0)；[`NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`](MatchRules.cs.md#symbol-4f16d2879002)；[`NationalSpire.OwnedClubs.PracticeBonus(NationalSpire.CareerData, string, int, int?)`](OwnedClubs.cs.md#symbol-5b2c48d0615a)；[`NationalSpire.TeamPreparations.Bonus(NationalSpire.CareerData, string, int)`](TeamPreparation.cs.md#symbol-3064e4d52a71)；`NationalSpire.ChanceFactors.ChanceFactors(double, double, double, double, double, double, double)`；`System.Math.Max(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerTraining.MoodBonus(NationalSpire.CareerPerson, int)`；`NationalSpire.CareerTraining.Permanent(NationalSpire.CareerData, string, int)`；`NationalSpire.CareerTraining.SkillBonus(NationalSpire.CareerPerson)`；`NationalSpire.CareerTraining.Temporary(NationalSpire.CareerData, string, int, bool)`；`NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`；`NationalSpire.OwnedClubs.PracticeBonus(NationalSpire.CareerData, string, int, int?)`；`NationalSpire.TeamPreparations.Bonus(NationalSpire.CareerData, string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerTraining.MoodBonus(NationalSpire.CareerPerson, int)`；输入表达式：`CareerTraining.MoodBonus(person, date)`；返回值紧邻使用处：`ArgumentSyntax: CareerTraining.MoodBonus(person, date)`
- `NationalSpire.CareerTraining.Permanent(NationalSpire.CareerData, string, int)`；输入表达式：`CareerTraining.Permanent(data, person.Id, ascension)`；返回值紧邻使用处：`ArgumentSyntax: CareerTraining.Permanent(data, person.Id, ascension)`
- `NationalSpire.CareerTraining.SkillBonus(NationalSpire.CareerPerson)`；输入表达式：`CareerTraining.SkillBonus(person)`；返回值紧邻使用处：`ArgumentSyntax: CareerTraining.SkillBonus(person)`
- `NationalSpire.CareerTraining.Temporary(NationalSpire.CareerData, string, int, bool)`；输入表达式：`CareerTraining.Temporary(data, person.Id, date, true)`；返回值紧邻使用处：`ArgumentSyntax: CareerTraining.Temporary(data, person.Id, date, true)`
- `NationalSpire.CareerTraining.Temporary(NationalSpire.CareerData, string, int, bool)`；输入表达式：`CareerTraining.Temporary(data, person.Id, date)`；返回值紧邻使用处：`ArgumentSyntax: CareerTraining.Temporary(data, person.Id, date)`
- `NationalSpire.ChanceFactors.ChanceFactors(double, double, double, double, double, double, double)`；输入表达式：`new(BaseChance(person, ascension), CareerTraining.Permanent(data, person.Id, ascension),              includePractice ? OwnedClubs.PracticeBonus(data, person.Id, ascension, date) : 0,              Math.Max(CareerTraining.Temporary(data, person.Id, date), TeamPreparations.Bonus(data, person.Id, date)), CareerTraining.SkillBonus(person),              CareerTraining.MoodBonus(person, date), CareerTraining.Temporary(data, person.Id, date, true))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(BaseChance(person, ascension), CareerTraining.Permanent(data, person.Id, ascension),              includePractice ? OwnedClubs.PracticeBonus(data, person.Id, ascension, date) : 0,              Math.Max(CareerTraining.Temporary(data, person.Id, date), TeamPreparations.Bonus(data, person.Id, date)), CareerTraining.SkillBonus(person),              CareerTraining.MoodBonus(person, date), CareerTraining.Temporary(data, person.Id, date, true));`
- `NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`；输入表达式：`BaseChance(person, ascension)`；返回值紧邻使用处：`ArgumentSyntax: BaseChance(person, ascension)`
- `NationalSpire.OwnedClubs.PracticeBonus(NationalSpire.CareerData, string, int, int?)`；输入表达式：`OwnedClubs.PracticeBonus(data, person.Id, ascension, date)`；返回值紧邻使用处：`ConditionalExpressionSyntax: includePractice ? OwnedClubs.PracticeBonus(data, person.Id, ascension, date) : 0`
- `NationalSpire.TeamPreparations.Bonus(NationalSpire.CareerData, string, int)`；输入表达式：`TeamPreparations.Bonus(data, person.Id, date)`；返回值紧邻使用处：`ArgumentSyntax: TeamPreparations.Bonus(data, person.Id, date)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(CareerTraining.Temporary(data, person.Id, date), TeamPreparations.Bonus(data, person.Id, date))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(CareerTraining.Temporary(data, person.Id, date), TeamPreparations.Bonus(data, person.Id, date))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a0517de2db43"></a>

## `NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?) — public static double ClearChance(CareerData data, CareerPerson person, int ascension, int? day = null)`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerTraining.RecordLesson(NationalSpire.CareerData, string, NationalSpire.PrivateLearning)`](CareerTraining.cs.md#symbol-20ac1d8e57c7)；[`NationalSpire.CareerTraining.RecordMood(NationalSpire.CareerData, string, NationalSpire.PrivateMood)`](CareerTraining.cs.md#symbol-ef124ea1d16b)；[`NationalSpire.CoachLineups.RefreshAiStarters(NationalSpire.CareerData)`](CoachLineups.cs.md#symbol-f8128db20387)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PlayerSimulation.Sample(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<NationalSpire.CareerResult>?, int?)`](PlayerSimulation.cs.md#symbol-a3059e9b8f34)；[`NationalSpire.PrivatePublicContext.AppendClubDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerClub, string, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivateCareerContext.cs.md#symbol-7b4c2e1f7909)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivatePublicContext.cs.md#symbol-3d184de3074e)

**调用：** [`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`](MatchRules.cs.md#symbol-92264d5fcfdd)

**字段、属性、事件及方法组引用：** `NationalSpire.ChanceFactors.Final`；`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`；输入表达式：`Evaluate(data, person, ascension, day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Evaluate(data, person, ascension, day).Final`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bd837370982f"></a>

## `NationalSpire.MatchRules.TeamChance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int, int) — public static ChanceFactors TeamChance(CareerData data, WorldCompetition? competition, string id, string rosterSeed, int ascension, int day)`

来源：源码第 128 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`](MatchRules.cs.md#symbol-8fd1cedc82b2)

**调用：** [`NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`](CircuitWorld.cs.md#symbol-4d6f1758c06b)；[`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`](MatchRules.cs.md#symbol-92264d5fcfdd)；`NationalSpire.ChanceFactors.ChanceFactors(double, double, double, double, double, double, double)`；`System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.ChanceFactors.Basis`；`NationalSpire.ChanceFactors.Defense`；`NationalSpire.ChanceFactors.Growth`；`NationalSpire.ChanceFactors.Mood`；`NationalSpire.ChanceFactors.Practice`；`NationalSpire.ChanceFactors.Skill`；`NationalSpire.ChanceFactors.Training`；`NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`；`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChanceFactors.ChanceFactors(double, double, double, double, double, double, double)`；输入表达式：`new(values.Average(v => v.Basis), values.Average(v => v.Growth), values.Average(v => v.Practice),              values.Average(v => v.Training), values.Average(v => v.Skill), values.Average(v => v.Mood), values.Average(v => v.Defense))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(values.Average(v => v.Basis), values.Average(v => v.Growth), values.Average(v => v.Practice),              values.Average(v => v.Training), values.Average(v => v.Skill), values.Average(v => v.Mood), values.Average(v => v.Defense));`
- `NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`；输入表达式：`CircuitWorld.CooperativeRoster(data, competition, id, rosterSeed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CircuitWorld.CooperativeRoster(data, competition, id, rosterSeed)`
- `NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`；输入表达式：`Evaluate(data, p, ascension, day)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Evaluate(data, p, ascension, day)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`values.Average(v => v.Basis)`；返回值紧邻使用处：`ArgumentSyntax: values.Average(v => v.Basis)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`values.Average(v => v.Defense)`；返回值紧邻使用处：`ArgumentSyntax: values.Average(v => v.Defense)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`values.Average(v => v.Growth)`；返回值紧邻使用处：`ArgumentSyntax: values.Average(v => v.Growth)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`values.Average(v => v.Mood)`；返回值紧邻使用处：`ArgumentSyntax: values.Average(v => v.Mood)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`values.Average(v => v.Practice)`；返回值紧邻使用处：`ArgumentSyntax: values.Average(v => v.Practice)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`values.Average(v => v.Skill)`；返回值紧邻使用处：`ArgumentSyntax: values.Average(v => v.Skill)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`values.Average(v => v.Training)`；返回值紧邻使用处：`ArgumentSyntax: values.Average(v => v.Training)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`roster.Select(p => Evaluate(data, p, ascension, day))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: roster.Select(p => Evaluate(data, p, ascension, day)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`roster.Select(p => Evaluate(data, p, ascension, day)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = roster.Select(p => Evaluate(data, p, ascension, day)).ToList()`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("对手队伍人数不足。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("对手队伍人数不足。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8fd1cedc82b2"></a>

## `NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?) — public static RunPerformance Simulate(CareerData data, string id, int ascension, string seed, int? day = null,          bool cooperative = false, WorldCompetition? competition = null, string? rosterSeed = null)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.SimulateWorld(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-f80c37dd1019)；[`NationalSpire.CircuitPeople.SeasonChange(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-d77bf6cf914a)；[`NationalSpire.Coop.CoopRules.Prepare(NationalSpire.Coop.CoopWorld, string, int, System.Collections.Generic.IReadOnlySet<string>, System.Collections.Generic.IReadOnlySet<ulong>?)`](Coop/CoopRules.cs.md#symbol-570bf786ec18)；[`NationalSpire.MatchFailure.RestoreMatch(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-a1d56f5af7ac)；[`NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchRules.cs.md#symbol-cc58cecfce28)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`Run(string, string)`](EsportsWorld.cs.md#symbol-f996697a7a19)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CircuitWorld.CooperativePerformance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int?)`](CircuitWorld.cs.md#symbol-72dc5f2576da)；[`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`](MatchRules.cs.md#symbol-92264d5fcfdd)；[`NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`](MatchRules.cs.md#symbol-ce476ea84a29)；[`NationalSpire.MatchRules.TeamChance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int, int)`](MatchRules.cs.md#symbol-bd837370982f)；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.RivalLevel`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.ChanceFactors.Defense`；`NationalSpire.ChanceFactors.Final`；`NationalSpire.CircuitWorld.CooperativePerformance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int?)`；`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`；`NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`；`NationalSpire.MatchRules.TeamChance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, id) ?? throw new InvalidOperationException("选手不存在。")`
- `NationalSpire.CircuitWorld.CooperativePerformance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int?)`；输入表达式：`CircuitWorld.CooperativePerformance(data, competition, id, rosterSeed ?? seed, date)`；返回值紧邻使用处：`ConditionalExpressionSyntax: cooperative ? CircuitWorld.CooperativePerformance(data, competition, id, rosterSeed ?? seed, date)              : CareerEngine.Person(data, id) ?? throw new InvalidOperationException("选手不存在。")`
- `NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`；输入表达式：`Evaluate(data, person, ascension, date)`；返回值紧邻使用处：`ConditionalExpressionSyntax: cooperative ? TeamChance(data, competition, id, rosterSeed ?? seed, ascension, date)              : Evaluate(data, person, ascension, date)`
- `NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`；输入表达式：`SimulatePerformance(person, ascension, seed, cooperative, factors.Final, factors.Defense, data.RivalLevel, date)`；返回值紧邻使用处：`ReturnStatementSyntax: return SimulatePerformance(person, ascension, seed, cooperative, factors.Final, factors.Defense, data.RivalLevel, date);`
- `NationalSpire.MatchRules.TeamChance(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string, int, int)`；输入表达式：`TeamChance(data, competition, id, rosterSeed ?? seed, ascension, date)`；返回值紧邻使用处：`ConditionalExpressionSyntax: cooperative ? TeamChance(data, competition, id, rosterSeed ?? seed, ascension, date)              : Evaluate(data, person, ascension, date)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("选手不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("选手不存在。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-928c3ecd1094"></a>

## `NationalSpire.MatchRules.CustomChanceAtAscension(double, int, int) — private static double CustomChanceAtAscension(double custom, int highest, int ascension)`

来源：源码第 149 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`](MatchRules.cs.md#symbol-4f16d2879002)

**调用：** [`NationalSpire.CareerEngine.WinChance(int, int)`](CareerEngine.cs.md#symbol-da7e19461394)；`System.Math.Clamp(double, double, double)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(double, double)`；`System.Math.Min(double, double)`；`System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.WinChance(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.WinChance(int, int)`；输入表达式：`CareerEngine.WinChance(highest, highest)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.WinChance(highest, highest)`
- `NationalSpire.CareerEngine.WinChance(int, int)`；输入表达式：`CareerEngine.WinChance(level, highest)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.WinChance(level, highest)`
- `NationalSpire.CareerEngine.WinChance(int, int)`；输入表达式：`CareerEngine.WinChance(level, highest)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.WinChance(level, highest)`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(custom, 0, 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: custom = Math.Clamp(custom, 0, 1)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(ascension, 0, 10)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ascension = Math.Clamp(ascension, 0, 10)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(highest, 0, 10)`；返回值紧邻使用处：`AssignmentExpressionSyntax: highest = Math.Clamp(highest, 0, 10)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(target, CareerEngine.WinChance(level, highest))`；返回值紧邻使用处：`AssignmentExpressionSyntax: target = Math.Max(target, CareerEngine.WinChance(level, highest))`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(target, next)`；返回值紧邻使用处：`AssignmentExpressionSyntax: target = Math.Min(target, next)`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(.35, level - highest)`；返回值紧邻使用处：`AssignmentExpressionSyntax: next *= Math.Pow(.35, level - highest)`

**赋值（含属性/字段和局部值）：**

- `ascension` = `Math.Clamp(ascension, 0, 10)`
- `custom` = `Math.Clamp(custom, 0, 1)`
- `highest` = `Math.Clamp(highest, 0, 10)`
- `next` *= `Math.Pow(.35, level - highest)`
- `target` = `Math.Max(target, CareerEngine.WinChance(level, highest))`
- `target` = `Math.Min(target, next)`

<a id="symbol-5c3948362434"></a>

## `NationalSpire.MatchRules.Simulate(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?) — public static RunPerformance Simulate(CareerPerson person, int officialAscension, string seed, bool cooperative = false, double chanceBonus = 0, double defenseBonus = 0, int rivalLevel = 1000, int? day = null)`

来源：源码第 173 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerPerson, int, double, int?)`](MatchRules.cs.md#symbol-7d569e72b64e)；[`NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`](MatchRules.cs.md#symbol-ce476ea84a29)

**字段、属性、事件及方法组引用：** `NationalSpire.MatchRules.ClearChance(NationalSpire.CareerPerson, int, double, int?)`；`NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRules.ClearChance(NationalSpire.CareerPerson, int, double, int?)`；输入表达式：`ClearChance(person, officialAscension, chanceBonus, day)`；返回值紧邻使用处：`ArgumentSyntax: ClearChance(person, officialAscension, chanceBonus, day)`
- `NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`；输入表达式：`SimulatePerformance(person, officialAscension, seed, cooperative, ClearChance(person, officialAscension, chanceBonus, day), defenseBonus, rivalLevel, day)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => SimulatePerformance(person, officialAscension, seed, cooperative, ClearChance(person, officialAscension, chanceBonus, day), defenseBonus, rivalLevel, day)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ce476ea84a29"></a>

## `NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?) — private static RunPerformance SimulatePerformance(CareerPerson person, int officialAscension, string seed, bool cooperative, double chance, double defenseBonus, int rivalLevel, int? day)`

来源：源码第 176 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`](MatchRules.cs.md#symbol-8fd1cedc82b2)；[`NationalSpire.MatchRules.Simulate(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`](MatchRules.cs.md#symbol-5c3948362434)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.MatchRules.CompletionSeconds(bool, double, bool, System.Random)`](MatchRules.cs.md#symbol-09269659b03b)；[`NationalSpire.MatchRules.FailureFloor(double, double, double, double)`](MatchRules.cs.md#symbol-faa68f24f6e3)；[`NationalSpire.MatchRules.RivalTimeScale(int)`](MatchRules.cs.md#symbol-47435ccfb229)；[`NationalSpire.SpireArbitration.Banned(NationalSpire.CareerPerson, int)`](SpireArbitration.cs.md#symbol-05f06b3ee7b9)；`NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；`System.Math.Round(double)`；`System.Random.NextDouble()`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.MatchRules.CompletionSeconds(bool, double, bool, System.Random)`；`NationalSpire.MatchRules.FailureFloor(double, double, double, double)`；`NationalSpire.MatchRules.RivalTimeScale(int)`；`NationalSpire.SpireArbitration.Banned(NationalSpire.CareerPerson, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"performance:{seed}:{person.Id}:{officialAscension}")`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash($"performance:{seed}:{person.Id}:{officialAscension}")`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(person)`；返回值紧邻使用处：`ArgumentSyntax: EsportsWorld.IsProfessional(person)`
- `NationalSpire.MatchRules.CompletionSeconds(bool, double, bool, System.Random)`；输入表达式：`CompletionSeconds(EsportsWorld.IsProfessional(person), chance, cooperative, rng)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CompletionSeconds(EsportsWorld.IsProfessional(person), chance, cooperative, rng)`
- `NationalSpire.MatchRules.FailureFloor(double, double, double, double)`；输入表达式：`FailureFloor(chance, defenseBonus, stage, rng.NextDouble())`；返回值紧邻使用处：`ConditionalExpressionSyntax: clear ? 0 : FailureFloor(chance, defenseBonus, stage, rng.NextDouble())`
- `NationalSpire.MatchRules.RivalTimeScale(int)`；输入表达式：`RivalTimeScale(rivalLevel)`；返回值紧邻使用处：`BinaryExpressionSyntax: original * RivalTimeScale(rivalLevel)`
- `NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；输入表达式：`new(clear, floor, original * RivalTimeScale(rivalLevel))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(clear, floor, original * RivalTimeScale(rivalLevel));`
- `NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；输入表达式：`new(false, -1, 0)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(false, -1, 0);`
- `NationalSpire.SpireArbitration.Banned(NationalSpire.CareerPerson, int)`；输入表达式：`SpireArbitration.Banned(person, day ?? 0)`；返回值紧邻使用处：`IfStatementSyntax: if (SpireArbitration.Banned(person, day ?? 0)) return new(false, -1, 0);`
- `System.Math.Round(double)`；输入表达式：`Math.Round(seconds * floor / 50)`；返回值紧邻使用处：`ConditionalExpressionSyntax: clear ? seconds : Math.Round(seconds * floor / 50)`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`ArgumentSyntax: rng.NextDouble()`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = rng.NextDouble()`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash($"performance:{seed}:{person.Id}:{officialAscension}"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(CareerEngine.StableHash($"performance:{seed}:{person.Id}:{officialAscension}"))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-09269659b03b"></a>

## `NationalSpire.MatchRules.CompletionSeconds(bool, double, bool, System.Random) — internal static double CompletionSeconds(bool professional, double chance, bool cooperative, Random rng)`

来源：源码第 190 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`](MatchRules.cs.md#symbol-ce476ea84a29)

**调用：** [`NationalSpire.MatchRules.CompletionCenter(bool, double)`](MatchRules.cs.md#symbol-40633d1bd8b1)；`System.Math.Cos(double)`；`System.Math.Log(double)`；`System.Math.Round(double)`；`System.Math.Sqrt(double)`；`System.Random.NextDouble()`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchRules.CompletionCenter(bool, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRules.CompletionCenter(bool, double)`；输入表达式：`CompletionCenter(professional, chance)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CompletionCenter(professional, chance)`
- `System.Math.Cos(double)`；输入表达式：`Math.Cos(2 * Math.PI * rng.NextDouble())`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Sqrt(-2 * Math.Log(1 - rng.NextDouble())) * Math.Cos(2 * Math.PI * rng.NextDouble())`
- `System.Math.Log(double)`；输入表达式：`Math.Log(1 - rng.NextDouble())`；返回值紧邻使用处：`BinaryExpressionSyntax: -2 * Math.Log(1 - rng.NextDouble())`
- `System.Math.Round(double)`；输入表达式：`Math.Round(seconds)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Round(seconds) + (cooperative ? 1800 : 0)`
- `System.Math.Sqrt(double)`；输入表达式：`Math.Sqrt(-2 * Math.Log(1 - rng.NextDouble()))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Sqrt(-2 * Math.Log(1 - rng.NextDouble())) * Math.Cos(2 * Math.PI * rng.NextDouble())`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 - rng.NextDouble()`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: 2 * Math.PI * rng.NextDouble()`

**赋值（含属性/字段和局部值）：**

- `seconds` = `mean + baseline * .07 * normal`

<a id="symbol-40633d1bd8b1"></a>

## `NationalSpire.MatchRules.CompletionCenter(bool, double) — internal static double CompletionCenter(bool professional, double chance)`

来源：源码第 206 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.CompletionSeconds(bool, double, bool, System.Random)`](MatchRules.cs.md#symbol-09269659b03b)；[`NationalSpire.PlayerSimulation.Sample(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<NationalSpire.CareerResult>?, int?)`](PlayerSimulation.cs.md#symbol-a3059e9b8f34)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-faa68f24f6e3"></a>

## `NationalSpire.MatchRules.FailureFloor(double, double, double, double) — internal static int FailureFloor(double chance, double defenseBonus, double stageRoll, double floorRoll)`

来源：源码第 209 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`](MatchRules.cs.md#symbol-ce476ea84a29)

**调用：** `System.Math.Clamp(double, double, double)`；`System.Math.Max(double, double)`；`System.Math.Min(double, double)`；`System.Math.Min(int, int)`；`System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(chance, 0, 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(chance, 0, 1)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0, defenseBonus)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, defenseBonus)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0, early - .05)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, early - .05)`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(Math.Max(0, defenseBonus), Math.Max(0, early - .05))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Math.Max(0, defenseBonus), Math.Max(0, early - .05))`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(count - 1, (int)(position * count))`；返回值紧邻使用处：`BinaryExpressionSyntax: first + Math.Min(count - 1, (int)(position * count))`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(floorRoll, 1 / (1 + 2 * strength))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Pow(floorRoll, 1 / (1 + 2 * strength))`

**赋值（含属性/字段和局部值）：**

- `early` -= `reduction`
- `late` += `reduction`
- `var (first, count)` = `stageRoll < early ? (4, 13) : stageRoll >= 1 - late ? (35, 16) : (18, 16)`

<a id="symbol-08f53c7e29ff"></a>

## `NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance) — public static int Compare(RunPerformance left, RunPerformance right)`

来源：源码第 223 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.EsportsWorld.SimulateFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](EsportsWorld.cs.md#symbol-562b8ecacdbf)；[`NationalSpire.LiveRunBridge.RunEnded(bool)`](LiveRunBridge.cs.md#symbol-d5b5bb6d87cd)；[`NationalSpire.PlayerSimulation.VaryTime(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.RunPerformance)`](PlayerSimulation.cs.md#symbol-5df053d02744)

**调用：** `bool.CompareTo(bool)`；`double.CompareTo(double)`；`int.CompareTo(int)`；`System.Math.Floor(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.RunPerformance.Cleared`；`NationalSpire.RunPerformance.Floor`；`NationalSpire.RunPerformance.Seconds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `bool.CompareTo(bool)`；输入表达式：`left.Cleared.CompareTo(right.Cleared)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = left.Cleared.CompareTo(right.Cleared)`
- `double.CompareTo(double)`；输入表达式：`Math.Floor(right.Seconds).CompareTo(Math.Floor(left.Seconds))`；返回值紧邻使用处：`ConditionalExpressionSyntax: left.Cleared ? Math.Floor(right.Seconds).CompareTo(Math.Floor(left.Seconds)) : left.Floor.CompareTo(right.Floor)`
- `int.CompareTo(int)`；输入表达式：`left.Floor.CompareTo(right.Floor)`；返回值紧邻使用处：`ConditionalExpressionSyntax: left.Cleared ? Math.Floor(right.Seconds).CompareTo(Math.Floor(left.Seconds)) : left.Floor.CompareTo(right.Floor)`
- `System.Math.Floor(double)`；输入表达式：`Math.Floor(left.Seconds)`；返回值紧邻使用处：`ArgumentSyntax: Math.Floor(left.Seconds)`
- `System.Math.Floor(double)`；输入表达式：`Math.Floor(right.Seconds)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Math.Floor(right.Seconds).CompareTo`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cc58cecfce28"></a>

## `NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static void PrepareOpponent(CareerData data, CareerMatch match)`

来源：源码第 230 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.LiveRunBridge.EnsurePlan()`](LiveRunBridge.cs.md#symbol-0dd1ac28e6cd)；[`NationalSpire.PlayerSimulation.Run(NationalSpire.CareerData, NationalSpire.CareerMatch, string, string, int?)`](PlayerSimulation.cs.md#symbol-4d8d262e25f1)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`](MatchRules.cs.md#symbol-8fd1cedc82b2)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.OpponentFloor`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerPerson.Id`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`；`NationalSpire.RunPerformance.Cleared`；`NationalSpire.RunPerformance.Floor`；`NationalSpire.RunPerformance.Seconds`；`NationalSpire.WorldCompetition.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, match.OpponentId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, match.OpponentId) ?? throw new InvalidOperationException("对手不存在")`
- `NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`；输入表达式：`Simulate(data, person.Id, match.RequiredAscension, data.WorldId + ":" + match.Seed, match.Day,              data.CooperativeMembers > 1, data.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId), match.Seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Simulate(data, person.Id, match.RequiredAscension, data.WorldId + ":" + match.Seed, match.Day,              data.CooperativeMembers > 1, data.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId), match.Seed)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId)`；返回值紧邻使用处：`ArgumentSyntax: data.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("对手不存在")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("对手不存在")`

**赋值（含属性/字段和局部值）：**

- `match.OpponentFloor` = `result.Floor`
- `match.OpponentPrepared` = `true`
- `match.OpponentSeconds` = `result.Seconds`
- `match.OpponentWon` = `result.Cleared`

<a id="symbol-b48ada8f4fc0"></a>

## `NationalSpire.MatchRules.RewardMultiplier(int, int) — public static double RewardMultiplier(int officialAscension, int playedAscension)`

来源：源码第 240 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`UpdateReward()`](CareerScreen.cs.md#symbol-d4a08b3c3dea)

**调用：** `System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(playedAscension - officialAscension, 0, 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Clamp(playedAscension - officialAscension, 0, 10) * 0.15`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1b4687e2daa3"></a>

## `NationalSpire.MatchRules.Reward(int, double) — public static int Reward(int amount, double multiplier)`

来源：源码第 241 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAudience.MatchGain(string, int, bool, bool, bool, int, double, int)`](CareerAudience.cs.md#symbol-58faacd06f00)；[`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)；[`UpdateReward()`](CareerScreen.cs.md#symbol-d4a08b3c3dea)

**调用：** `System.Math.Round(double, System.MidpointRounding)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Round(double, System.MidpointRounding)`；输入表达式：`Math.Round(amount * multiplier, MidpointRounding.AwayFromZero)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(amount * multiplier, MidpointRounding.AwayFromZero)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-13ecc28f8403"></a>

## `NationalSpire.MatchRules.Time(double?) — public static string Time(double? seconds)`

来源：源码第 242 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.MatchContext(NationalSpire.CareerData, NationalSpire.CommunityPost)`](AiContext.cs.md#symbol-eaa3e44ce66a)；[`NationalSpire.AiService.PlayerPublicRecord(NationalSpire.CareerData, int, bool)`](AiContext.cs.md#symbol-99772c8e0814)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShowArchive()`](CareerScreen.cs.md#symbol-ce008839cea8)；[`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.LiveCommentary.PlayerVictory(NationalSpire.BroadcastMemory, bool, double, int, int, string, string, string)`](LiveMoments.cs.md#symbol-44f4d20ad966)；[`NationalSpire.LiveCommentary.Rival(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, string, string, string, double)`](LiveAtmosphere.cs.md#symbol-5475ccc1b529)；[`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)；[`NationalSpire.MatchRules.Performance(bool, int, double?)`](MatchRules.cs.md#symbol-b38635e79223)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)；[`NationalSpire.RandomEvents.RememberMatches(NationalSpire.CareerData)`](RandomEvents.cs.md#symbol-f818531770d4)；[`NationalSpire.SettlementRecords.Capture(NationalSpire.CareerData, NationalSpire.CareerMatch, int)`](SettlementRecord.cs.md#symbol-8ce7adcb9168)；[`Performance(bool, int, double?)`](SettlementRecord.cs.md#symbol-17097482a0e8)

**调用：** `double.IsFinite(double)`；`System.Math.Floor(double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `double.IsFinite(double)`；输入表达式：`double.IsFinite(seconds.Value)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !double.IsFinite(seconds.Value)`
- `System.Math.Floor(double)`；输入表达式：`Math.Floor(seconds.Value)`；返回值紧邻使用处：`CastExpressionSyntax: (long)Math.Floor(seconds.Value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b38635e79223"></a>

## `NationalSpire.MatchRules.Performance(bool, int, double?) — public static string Performance(bool cleared, int floor, double? seconds)`

来源：源码第 248 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CommunityThreads.RememberMatch(NationalSpire.CareerData, NationalSpire.CareerResult)`](CommunityThreads.cs.md#symbol-fe6de6f8dd52)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.MatchRules.Report(NationalSpire.CareerMatch, NationalSpire.CareerResult, bool)`](MatchRules.cs.md#symbol-ca4b0ef64a9d)；[`NationalSpire.PrivatePublicContext.AppendRecentResults(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateCareerContext.cs.md#symbol-8c2348c334d4)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivatePublicContext.cs.md#symbol-3d184de3074e)；[`NationalSpire.PublicSchedule.Capture(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](PublicSchedule.cs.md#symbol-0253014360da)；[`NationalSpire.SettlementRecords.Capture(NationalSpire.CareerData, NationalSpire.CareerMatch, int)`](SettlementRecord.cs.md#symbol-8ce7adcb9168)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)；[`NationalSpire.WorldEvents.FixtureFacts(NationalSpire.CareerData, NationalSpire.WorldCompetition, System.Collections.Generic.IEnumerable<NationalSpire.WorldFixture>)`](WorldEvents.cs.md#symbol-04c812704f65)；[`Performance(bool, int, double?)`](SettlementRecord.cs.md#symbol-17097482a0e8)；[`WeekStats(string)`](WeeklyJournal.cs.md#symbol-5e7fc4449ac6)

**调用：** [`NationalSpire.MatchRules.Time(double?)`](MatchRules.cs.md#symbol-13ecc28f8403)

**字段、属性、事件及方法组引用：** `NationalSpire.MatchRules.Time(double?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`Time(seconds)`；返回值紧邻使用处：`BinaryExpressionSyntax: "通关 · " + Time(seconds)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a28dd7ef0ece"></a>

## `NationalSpire.MatchRules.AscensionLabel(NationalSpire.CareerResult) — public static string AscensionLabel(CareerResult result)`

来源：源码第 249 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.OfficialAscensionVerified`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ac72157cbb56"></a>

## `NationalSpire.MatchRules.ChallengeNote(NationalSpire.CareerResult, bool) — public static string? ChallengeNote(CareerResult result, bool cooperative = false)`

来源：源码第 250 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.MatchContext(NationalSpire.CareerData, NationalSpire.CommunityPost)`](AiContext.cs.md#symbol-eaa3e44ce66a)；[`NationalSpire.AiService.PlayerPublicRecord(NationalSpire.CareerData, int, bool)`](AiContext.cs.md#symbol-99772c8e0814)；[`NationalSpire.CommunityThreads.RememberMatch(NationalSpire.CareerData, NationalSpire.CareerResult)`](CommunityThreads.cs.md#symbol-fe6de6f8dd52)；[`NationalSpire.MatchRules.Report(NationalSpire.CareerMatch, NationalSpire.CareerResult, bool)`](MatchRules.cs.md#symbol-ca4b0ef64a9d)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.OfficialAscensionVerified`；`NationalSpire.CareerResult.PlayedAscension`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ca4b0ef64a9d"></a>

## `NationalSpire.MatchRules.Report(NationalSpire.CareerMatch, NationalSpire.CareerResult, bool) — public static string Report(CareerMatch match, CareerResult result, bool cooperative = false)`

来源：源码第 254 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.CareerMigration.UpgradeRules(NationalSpire.CareerData)`](CareerMigration.cs.md#symbol-94c0855d9c16)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.MatchRules.ChallengeNote(NationalSpire.CareerResult, bool)`](MatchRules.cs.md#symbol-ac72157cbb56)；[`NationalSpire.MatchRules.Performance(bool, int, double?)`](MatchRules.cs.md#symbol-b38635e79223)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMatch.Decider`；`NationalSpire.CareerMatch.OpponentFloor`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.Opponent`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerResult.RunSeconds`；`NationalSpire.CareerResult.Simulated`；`NationalSpire.CareerResult.Win`；`NationalSpire.MatchRules.ChallengeNote(NationalSpire.CareerResult, bool)`；`NationalSpire.MatchRules.Performance(bool, int, double?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(match.Seed)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(match.Seed) % 4`
- `NationalSpire.MatchRules.ChallengeNote(NationalSpire.CareerResult, bool)`；输入表达式：`ChallengeNote(result, cooperative)`；返回值紧邻使用处：`BinaryExpressionSyntax: (result.Simulated ? "模拟赛果。" : "") + $"赛事进阶 {match.RequiredAscension}。" + ChallengeNote(result, cooperative)`
- `NationalSpire.MatchRules.Performance(bool, int, double?)`；输入表达式：`Performance(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Performance(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds)`
- `NationalSpire.MatchRules.Performance(bool, int, double?)`；输入表达式：`Performance(result.Win, result.Floor, result.RunSeconds)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Performance(result.Win, result.Floor, result.RunSeconds)`

**赋值（含属性/字段和局部值）：**
