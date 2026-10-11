# FailureDecision.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`7D971C67AC9A21E15BE6C90A4D0A26638ADD8C5EFF0F7FDF7409301B7509D92C`。来源：[源码](../../FailureDecision.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

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


<a id="symbol-137c89eb115e"></a>

## `NationalSpire.FailureDecision.Abandoned — public bool Abandoned`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4f91fec66710"></a>

## `NationalSpire.FailureDecision.RetryRequested — public bool RetryRequested`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7f4fa41ad4c0"></a>

## `NationalSpire.MatchFailure.Locked(NationalSpire.CareerData) — public static string? Locked(CareerData d)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](CareerEngine.cs.md#symbol-a453368fed28)；[`NationalSpire.CareerStore.SwitchCareer(string)`](CareerStore.cs.md#symbol-67c415b86d89)；[`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)；[`NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`](TeamPreparation.cs.md#symbol-440f4ccf2595)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e4be787ed490"></a>

## `NationalSpire.MatchFailure.Confirm(NationalSpire.CareerData) — public static void Confirm(CareerData d)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)

**调用：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool)`](CareerEngine.cs.md#symbol-2cb7c2afebf9)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.Cards`；`NationalSpire.CareerResult.Character`；`NationalSpire.CareerResult.CharacterId`；`NationalSpire.CareerResult.DeckSummary`；`NationalSpire.CareerResult.Evidence`；`NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.PlayedAscension`；`NationalSpire.CareerResult.RunSeconds`；`NationalSpire.CareerResult.Win`；`NationalSpire.FailureDecision.Abandoned`；`NationalSpire.FailureDecision.Result`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool)`；输入表达式：`CareerEngine.FinishMatch(d, match, r.Win, failure.Abandoned, r.Floor, r.Character,             r.PlayedAscension ?? r.Ascension, r.Cards, r.RunSeconds ?? 0, r.DeckSummary, r.Evidence, r.CharacterId, confirmFailure: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.FinishMatch(d, match, r.Win, failure.Abandoned, r.Floor, r.Character,             r.PlayedAscension ?? r.Ascension, r.Cards, r.RunSeconds ?? 0, r.DeckSummary, r.Evidence, r.CharacterId, confirmFailure: true);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.FirstOrDefault(m => m.Id == r.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Matches.FirstOrDefault(m => m.Id == r.MatchId)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("待确认比赛记录缺失。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("待确认比赛记录缺失。");`

**赋值（含属性/字段和局部值）：**

- `d.Failure` = `null`

<a id="symbol-e81edcf0cf5a"></a>

## `NationalSpire.MatchFailure.Retry(NationalSpire.CareerData, bool) — public static CareerMatch Retry(CareerData d, bool newSeed)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** `string.ToUpperInvariant()`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.PendingSince`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.PlayerFloor`；`NationalSpire.CareerMatch.PlayerSeconds`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.FailureDecision.Result`；`NationalSpire.FailureDecision.RetryRequested`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.ToUpperInvariant()`；输入表达式：`Guid.NewGuid().ToString("N")[..12].ToUpperInvariant()`；返回值紧邻使用处：`BinaryExpressionSyntax: "NS" + Guid.NewGuid().ToString("N")[..12].ToUpperInvariant()`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Single(m => m.Id == failure.Result.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Matches.Single(m => m.Id == failure.Result.MatchId)`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ElementAccessExpressionSyntax: Guid.NewGuid().ToString("N")[..12]`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("没有待选择的失败。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("没有待选择的失败。")`

**赋值（含属性/字段和局部值）：**

- `d.PendingMatchId` = `null`
- `d.PendingSince` = `0`
- `failure.RetryRequested` = `true`
- `m.Draw` = `m.PlayerWon = false`
- `m.Live` = `null`
- `m.OpponentPrepared` = `false`
- `m.OpponentSeconds` = `null`
- `m.PlayerFloor` = `0`
- `m.PlayerSeconds` = `null`
- `m.PlayerWon` = `false`
- `m.Seed` = `"NS" + Guid.NewGuid().ToString("N")[..12].ToUpperInvariant()`
