# FailureDecision.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A7AFDB4C9883E52EFE1A12A2026972607E7F0D9512F1D6D3C7609EC77973A987`。来源：[源码](../../FailureDecision.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.FailureDecision`、`NationalSpire.MatchFailure`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-2f62eb9c1fe5"></a>

## `NationalSpire.FailureDecision.Attempt — public string Attempt`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3368a04ee7ad"></a>

## `NationalSpire.FailureDecision.Result — public CareerResult Result`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.CareerResult.CareerResult()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerResult.CareerResult()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7d06fda43061"></a>

## `NationalSpire.FailureDecision.Opponent — public RunPerformance? Opponent`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-137c89eb115e"></a>

## `NationalSpire.FailureDecision.Abandoned — public bool Abandoned`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4f91fec66710"></a>

## `NationalSpire.FailureDecision.RetryRequested — public bool RetryRequested`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7f4fa41ad4c0"></a>

## `NationalSpire.MatchFailure.Locked(NationalSpire.CareerData) — public static string? Locked(CareerData d)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](CareerEngine.cs.md#symbol-a453368fed28)；[`NationalSpire.CareerStore.SwitchCareer(string)`](CareerStore.cs.md#symbol-67c415b86d89)；[`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.GroupChats.CommandCore(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-136432a1ec5d)；[`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)；[`NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`](TeamPreparation.cs.md#symbol-440f4ccf2595)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-00e4a5993844"></a>

## `NationalSpire.MatchFailure.Record(NationalSpire.CareerData, string) — public static void Record(CareerData d, string stage)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.Prepare(NationalSpire.Coop.CoopWorld, string, int, System.Collections.Generic.IReadOnlySet<string>, System.Collections.Generic.IReadOnlySet<ulong>?)`](Coop/CoopRules.cs.md#symbol-570bf786ec18)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.MatchFailure.Confirm(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-e4be787ed490)；[`NationalSpire.MatchFailure.Retry(NationalSpire.CareerData, bool)`](FailureDecision.cs.md#symbol-e81edcf0cf5a)

**调用：** [`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `<anonymous type: string WorldId, int Season, int Day, string stage, NationalSpire.FailureDecision decision, <anonymous type: string Id, string Seed, string Status, int? ChosenAscension, bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds> match>.decision`；`<anonymous type: string WorldId, int Season, int Day, string stage, NationalSpire.FailureDecision decision, <anonymous type: string Id, string Seed, string Status, int? ChosenAscension, bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds> match>.match`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerMatch.ChosenAscension`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentFloor`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.FailureDecision.Result`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.decision", new     {         d.WorldId, d.Season, d.Day, stage, decision = d.Failure,         match = d.Matches.Where(m => m.Id == d.Failure?.Result.MatchId).Select(m => new         { m.Id, m.Seed, m.Status, m.ChosenAscension, m.OpponentPrepared, m.OpponentWon, m.OpponentFloor, m.OpponentSeconds }).FirstOrDefault()     })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Diagnostics.Record("match.decision", new     {         d.WorldId, d.Season, d.Day, stage, decision = d.Failure,         match = d.Matches.Where(m => m.Id == d.Failure?.Result.MatchId).Select(m => new         { m.Id, m.Seed, m.Status, m.ChosenAscension, m.OpponentPrepared, m.OpponentWon, m.OpponentFloor, m.OpponentSeconds }).FirstOrDefault()     })`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`d.Matches.Where(m => m.Id == d.Failure?.Result.MatchId).Select(m => new         { m.Id, m.Seed, m.Status, m.ChosenAscension, m.OpponentPrepared, m.OpponentWon, m.OpponentFloor, m.OpponentSeconds }).FirstOrDefault()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: match = d.Matches.Where(m => m.Id == d.Failure?.Result.MatchId).Select(m => new         { m.Id, m.Seed, m.Status, m.ChosenAscension, m.OpponentPrepared, m.OpponentWon, m.OpponentFloor, m.OpponentSeconds }).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Matches.Where(m => m.Id == d.Failure?.Result.MatchId).Select(m => new         { m.Id, m.Seed, m.Status, m.ChosenAscension, m.OpponentPrepared, m.OpponentWon, m.OpponentFloor, m.OpponentSeconds })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.Where(m => m.Id == d.Failure?.Result.MatchId).Select(m => new         { m.Id, m.Seed, m.Status, m.ChosenAscension, m.OpponentPrepared, m.OpponentWon, m.OpponentFloor, m.OpponentSeconds }).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => m.Id == d.Failure?.Result.MatchId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.Where(m => m.Id == d.Failure?.Result.MatchId).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e4be787ed490"></a>

## `NationalSpire.MatchFailure.Confirm(NationalSpire.CareerData) — public static void Confirm(CareerData d)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)

**调用：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.MatchFailure.Record(NationalSpire.CareerData, string)`](FailureDecision.cs.md#symbol-00e4a5993844)；[`NationalSpire.MatchFailure.RestoreMatch(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-a1d56f5af7ac)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.Cards`；`NationalSpire.CareerResult.Character`；`NationalSpire.CareerResult.CharacterId`；`NationalSpire.CareerResult.DeckSummary`；`NationalSpire.CareerResult.Evidence`；`NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.PlayedAscension`；`NationalSpire.CareerResult.RunSeconds`；`NationalSpire.CareerResult.Simulated`；`NationalSpire.CareerResult.Win`；`NationalSpire.FailureDecision.Abandoned`；`NationalSpire.FailureDecision.Result`；`NationalSpire.MatchFailure.Record(NationalSpire.CareerData, string)`；`NationalSpire.MatchFailure.RestoreMatch(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`；输入表达式：`CareerEngine.FinishMatch(d, match, r.Win, failure.Abandoned, r.Floor, r.Character,             r.PlayedAscension ?? r.Ascension, r.Cards, r.RunSeconds ?? 0, r.DeckSummary, r.Evidence, r.CharacterId, confirmFailure: true, simulated: r.Simulated)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.FinishMatch(d, match, r.Win, failure.Abandoned, r.Floor, r.Character,             r.PlayedAscension ?? r.Ascension, r.Cards, r.RunSeconds ?? 0, r.DeckSummary, r.Evidence, r.CharacterId, confirmFailure: true, simulated: r.Simulated);`
- `NationalSpire.MatchFailure.Record(NationalSpire.CareerData, string)`；输入表达式：`Record(d, "confirm")`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(d, "confirm");`
- `NationalSpire.MatchFailure.RestoreMatch(NationalSpire.CareerData)`；输入表达式：`RestoreMatch(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RestoreMatch(d)`

**赋值（含属性/字段和局部值）：**

- `d.Failure` = `null`

<a id="symbol-e81edcf0cf5a"></a>

## `NationalSpire.MatchFailure.Retry(NationalSpire.CareerData, bool) — public static CareerMatch Retry(CareerData d, bool newSeed)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.MatchFailure.Record(NationalSpire.CareerData, string)`](FailureDecision.cs.md#symbol-00e4a5993844)；[`NationalSpire.MatchFailure.RestoreMatch(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-a1d56f5af7ac)；`NationalSpire.BroadcastMemory.BroadcastMemory()`；`string.ToUpperInvariant()`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.PendingSince`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.PlayerFloor`；`NationalSpire.CareerMatch.PlayerSeconds`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.FailureDecision.RetryRequested`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.MatchFailure.Record(NationalSpire.CareerData, string)`；`NationalSpire.MatchFailure.RestoreMatch(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BroadcastMemory.BroadcastMemory()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: m.Live.Commentary = new()`
- `NationalSpire.MatchFailure.Record(NationalSpire.CareerData, string)`；输入表达式：`Record(d, newSeed ? "retry-new" : "retry-same")`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(d, newSeed ? "retry-new" : "retry-same");`
- `NationalSpire.MatchFailure.RestoreMatch(NationalSpire.CareerData)`；输入表达式：`RestoreMatch(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RestoreMatch(d)`
- `string.ToUpperInvariant()`；输入表达式：`Guid.NewGuid().ToString("N")[..12].ToUpperInvariant()`；返回值紧邻使用处：`BinaryExpressionSyntax: "NS" + Guid.NewGuid().ToString("N")[..12].ToUpperInvariant()`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ElementAccessExpressionSyntax: Guid.NewGuid().ToString("N")[..12]`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("没有待选择的比赛结果。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("没有待选择的比赛结果。")`

**赋值（含属性/字段和局部值）：**

- `d.PendingMatchId` = `null`
- `d.PendingSince` = `0`
- `failure.RetryRequested` = `true`
- `m.Draw` = `m.PlayerWon = false`
- `m.Live.Commentary` = `new()`
- `m.Live` = `null`
- `m.OpponentPrepared` = `false`
- `m.OpponentSeconds` = `null`
- `m.PlayerFloor` = `0`
- `m.PlayerSeconds` = `null`
- `m.PlayerWon` = `false`
- `m.Seed` = `"NS" + Guid.NewGuid().ToString("N")[..12].ToUpperInvariant()`

<a id="symbol-a1d56f5af7ac"></a>

## `NationalSpire.MatchFailure.RestoreMatch(NationalSpire.CareerData) — public static CareerMatch RestoreMatch(CareerData d)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.MatchFailure.Confirm(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-e4be787ed490)；[`NationalSpire.MatchFailure.Retry(NationalSpire.CareerData, bool)`](FailureDecision.cs.md#symbol-e81edcf0cf5a)

**调用：** [`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`](MatchRules.cs.md#symbol-8fd1cedc82b2)；`NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerMatch.ChosenAscension`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentFloor`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.PlayedAscension`；`NationalSpire.CareerResult.Seed`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.FailureDecision.Opponent`；`NationalSpire.FailureDecision.Result`；`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`；`NationalSpire.RunPerformance.Cleared`；`NationalSpire.RunPerformance.Floor`；`NationalSpire.RunPerformance.Seconds`；`NationalSpire.WorldCompetition.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`；输入表达式：`MatchRules.Simulate(d, match.OpponentId, match.RequiredAscension,                 d.WorldId + (d.CooperativeMembers > 1 ? ":coop:" : ":") + failure.Result.Seed,                 match.Day, d.CooperativeMembers > 1, d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId), failure.Result.Seed)`；返回值紧邻使用处：`ConditionalExpressionSyntax: match.Seed == failure.Result.Seed && match.OpponentPrepared && match.OpponentSeconds.HasValue             ? new(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds.Value)             : MatchRules.Simulate(d, match.OpponentId, match.RequiredAscension,                 d.WorldId + (d.CooperativeMembers > 1 ? ":coop:" : ":") + failure.Result.Seed,                 match.Day, d.CooperativeMembers > 1, d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId), failure.Result.Seed)`
- `NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；输入表达式：`new(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds.Value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: match.Seed == failure.Result.Seed && match.OpponentPrepared && match.OpponentSeconds.HasValue             ? new(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds.Value)             : MatchRules.Simulate(d, match.OpponentId, match.RequiredAscension,                 d.WorldId + (d.CooperativeMembers > 1 ? ":coop:" : ":") + failure.Result.Seed,                 match.Day, d.CooperativeMembers > 1, d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId), failure.Result.Seed)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId)`；返回值紧邻使用处：`ArgumentSyntax: d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Single(m => m.Id == failure.Result.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Matches.Single(m => m.Id == failure.Result.MatchId)`

**赋值（含属性/字段和局部值）：**

- `failure.Opponent` ??= `match.Seed == failure.Result.Seed && match.OpponentPrepared && match.OpponentSeconds.HasValue             ? new(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds.Value)             : MatchRules.Simulate(d, match.OpponentId, match.RequiredAscension,                 d.WorldId + (d.CooperativeMembers > 1 ? ":coop:" : ":") + failure.Result.Seed,                 match.Day, d.CooperativeMembers > 1, d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId), failure.Result.Seed)`
- `match.ChosenAscension` = `failure.Result.PlayedAscension ?? failure.Result.Ascension`
- `match.OpponentFloor` = `opponent.Floor`
- `match.OpponentPrepared` = `true`
- `match.OpponentSeconds` = `opponent.Seconds`
- `match.OpponentWon` = `opponent.Cleared`
- `match.Seed` = `failure.Result.Seed`
