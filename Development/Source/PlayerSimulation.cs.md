# PlayerSimulation.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6D47BAAD0605910CC71339C48307AF51C400ABEC8AF1D95FD162DD342C97047D`。来源：[源码](../../PlayerSimulation.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PlayerSimulation`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-a3059e9b8f34"></a>

## `NationalSpire.PlayerSimulation.Sample(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<NationalSpire.CareerResult>?, int?) — public static RunPerformance Sample(CareerData d, CareerMatch match, IEnumerable<CareerResult>? history = null, int? ascension = null)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.PlayerSimulation.Run(NationalSpire.CareerData, NationalSpire.CareerMatch, string, string, int?)`](PlayerSimulation.cs.md#symbol-4d8d262e25f1)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`](MatchRules.cs.md#symbol-a0517de2db43)；[`NationalSpire.MatchRules.CompletionCenter(bool, double)`](MatchRules.cs.md#symbol-40633d1bd8b1)；[`NationalSpire.MatchRules.RivalTimeScale(int)`](MatchRules.cs.md#symbol-47435ccfb229)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；`System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Floor(double)`；`System.Math.Max(double, double)`；`System.Math.Min(double, double)`；`System.Random.Next(int)`；`System.Random.NextDouble()`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.RivalLevel`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerResult.PlayedAscension`；`NationalSpire.CareerResult.RunSeconds`；`NationalSpire.CareerResult.Simulated`；`NationalSpire.CareerResult.Win`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`；`NationalSpire.MatchRules.CompletionCenter(bool, double)`；`NationalSpire.MatchRules.RivalTimeScale(int)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.PlayerSimulation`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + ":player-simulation:" + match.Seed)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(d.WorldId + ":player-simulation:" + match.Seed)`
- `NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`；输入表达式：`MatchRules.ClearChance(d, p, levelPlayed)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => MatchRules.ClearChance(d, p, levelPlayed)`
- `NationalSpire.MatchRules.CompletionCenter(bool, double)`；输入表达式：`MatchRules.CompletionCenter(true, chance)`；返回值紧邻使用处：`BinaryExpressionSyntax: MatchRules.CompletionCenter(true, chance) + (d.CooperativeMembers > 1 ? 1800 : 0)`
- `NationalSpire.MatchRules.RivalTimeScale(int)`；输入表达式：`MatchRules.RivalTimeScale(d.RivalLevel)`；返回值紧邻使用处：`AssignmentExpressionSyntax: mean *= MatchRules.RivalTimeScale(d.RivalLevel)`
- `NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；输入表达式：`new(clear, floor, similar.Average(r => r.RunSeconds!.Value))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(clear, floor, similar.Average(r => r.RunSeconds!.Value));`
- `NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；输入表达式：`new(true, 0, mean)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(true, 0, mean);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.PlayerSimulation)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.PlayerSimulation)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`professionals.Average(p => MatchRules.ClearChance(d, p, levelPlayed))`；返回值紧邻使用处：`ConditionalExpressionSyntax: professionals.Length == 0 ? .2 : professionals.Average(p => MatchRules.ClearChance(d, p, levelPlayed))`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`similar.Average(r => r.RunSeconds!.Value)`；返回值紧邻使用处：`ArgumentSyntax: similar.Average(r => r.RunSeconds!.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`records.Count(r => r.Win)`；返回值紧邻使用处：`CastExpressionSyntax: (double)records.Count(r => r.Win)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`g.First()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.First()`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`(history ?? d.Results).Where(r => r.Outcome != "退赛" && r.RunSeconds is > 0)              .GroupBy(r => r.MatchId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (history ?? d.Results).Where(r => r.Outcome != "退赛" && r.RunSeconds is > 0)              .GroupBy(r => r.MatchId).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`(history ?? d.Results).Where(r => r.Outcome != "退赛" && r.RunSeconds is > 0)              .GroupBy(r => r.MatchId).Select(g => g.First())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (history ?? d.Results).Where(r => r.Outcome != "退赛" && r.RunSeconds is > 0)              .GroupBy(r => r.MatchId).Select(g => g.First()).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`(history ?? d.Results).Where(r => r.Outcome != "退赛" && r.RunSeconds is > 0)              .GroupBy(r => r.MatchId).Select(g => g.First()).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (history ?? d.Results).Where(r => r.Outcome != "退赛" && r.RunSeconds is > 0)              .GroupBy(r => r.MatchId).Select(g => g.First()).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.People.Where(EsportsWorld.IsProfessional).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(EsportsWorld.IsProfessional).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`records.Where(r => !r.Simulated).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = records.Where(r => !r.Simulated).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`records.Where(r => (r.PlayedAscension ?? r.Ascension) == levelPlayed).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = records.Where(r => (r.PlayedAscension ?? r.Ascension) == levelPlayed).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`records.Where(r => r.Win == clear).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = records.Where(r => r.Win == clear).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(history ?? d.Results).Where(r => r.Outcome != "退赛" && r.RunSeconds is > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (history ?? d.Results).Where(r => r.Outcome != "退赛" && r.RunSeconds is > 0)              .GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(EsportsWorld.IsProfessional)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(EsportsWorld.IsProfessional).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`records.Where(r => !r.Simulated)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: records.Where(r => !r.Simulated).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`records.Where(r => (r.PlayedAscension ?? r.Ascension) == levelPlayed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: records.Where(r => (r.PlayedAscension ?? r.Ascension) == levelPlayed).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`records.Where(r => r.Win == clear)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: records.Where(r => r.Win == clear).ToArray`
- `System.Math.Floor(double)`；输入表达式：`Math.Floor(match.OpponentSeconds.Value)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Floor(match.OpponentSeconds.Value) - 1`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(.001, Math.Floor(match.OpponentSeconds.Value) - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(.001, Math.Floor(match.OpponentSeconds.Value) - 1)`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(mean, Math.Max(.001, Math.Floor(match.OpponentSeconds.Value) - 1))`；返回值紧邻使用处：`AssignmentExpressionSyntax: mean = Math.Min(mean, Math.Max(.001, Math.Floor(match.OpponentSeconds.Value) - 1))`
- `System.Random.Next(int)`；输入表达式：`rng.Next(similar.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(similar.Length)`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.NextDouble() < (double)records.Count(r => r.Win) / records.Length`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash(d.WorldId + ":player-simulation:" + match.Seed))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(CareerEngine.StableHash(d.WorldId + ":player-simulation:" + match.Seed))`

**赋值（含属性/字段和局部值）：**

- `mean` *= `MatchRules.RivalTimeScale(d.RivalLevel)`
- `mean` = `Math.Min(mean, Math.Max(.001, Math.Floor(match.OpponentSeconds.Value) - 1))`
- `records` = `actual`
- `records` = `level`

<a id="symbol-4d8d262e25f1"></a>

## `NationalSpire.PlayerSimulation.Run(NationalSpire.CareerData, NationalSpire.CareerMatch, string, string, int?) — public static string? Run(CareerData d, CareerMatch match, string character, string characterId, int? ascension = null)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchRules.cs.md#symbol-cc58cecfce28)；[`NationalSpire.MatchRules.PrepareSeed(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchRules.cs.md#symbol-27c230d3a150)；[`NationalSpire.PlayerSimulation.Sample(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<NationalSpire.CareerResult>?, int?)`](PlayerSimulation.cs.md#symbol-a3059e9b8f34)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Status`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.MatchRules.PrepareSeed(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.PlayerSimulation.Sample(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<NationalSpire.CareerResult>?, int?)`；`NationalSpire.RunPerformance.Cleared`；`NationalSpire.RunPerformance.Floor`；`NationalSpire.RunPerformance.Seconds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`；输入表达式：`CareerEngine.FinishMatch(d, match, result.Cleared, false, result.Floor, character, ascension ?? match.RequiredAscension, [], result.Seconds,              characterId: characterId, confirmFailure: true, simulated: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.FinishMatch(d, match, result.Cleared, false, result.Floor, character, ascension ?? match.RequiredAscension, [], result.Seconds,              characterId: characterId, confirmFailure: true, simulated: true);`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EsportsWorld.EntryReason(d, match)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.EntryReason(d, match) is { } error`
- `NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchRules.PrepareOpponent(d, match)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchRules.PrepareOpponent(d, match);`
- `NationalSpire.MatchRules.PrepareSeed(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchRules.PrepareSeed(d, match)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchRules.PrepareSeed(d, match);`
- `NationalSpire.PlayerSimulation.Sample(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<NationalSpire.CareerResult>?, int?)`；输入表达式：`Sample(d, match, ascension: ascension)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Sample(d, match, ascension: ascension)`

**赋值（含属性/字段和局部值）：**
