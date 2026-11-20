# DuelReport.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`126F8F14DEC5FF8F91E6714F78EFF8124C4A5E683CD7BC3001FA3083A9241514`。来源：[源码](../../DuelReport.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DuelReport`、`NationalSpire.DuelReplay`、`NationalSpire.DuelReplayStep`、`NationalSpire.DuelParticipant`、`NationalSpire.DuelRound`、`NationalSpire.DuelCardFace`、`NationalSpire.DuelCardStep`、`NationalSpire.DuelSequenceRun`、`NationalSpire.DuelTurnTotals`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-9e9dbd840989"></a>

## `NationalSpire.DuelReport.OpponentOpens — public bool OpponentOpens`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a057ca744e35"></a>

## `NationalSpire.DuelReport.PlayersWon — public bool PlayersWon`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fdc691a0c8ac"></a>

## `NationalSpire.DuelReport.Note — public string Note`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-850c4d515be4"></a>

## `NationalSpire.DuelReport.People — public List<DuelParticipant> People`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ffeafcb7da7c"></a>

## `NationalSpire.DuelReport.Rounds — public List<DuelRound> Rounds`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-28113d96dcfb"></a>

## `NationalSpire.DuelReport.PlayedFaces — public List<DuelCardFace> PlayedFaces`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8ca64be51a70"></a>

## `NationalSpire.DuelReport.Replay — public DuelReplay? Replay`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-73d092aa7f0e"></a>

## `NationalSpire.DuelReport.Describe(System.Collections.Generic.IEnumerable<string>?) — public string Describe(IEnumerable<string>? providedCards = null)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.MatchContext(NationalSpire.CareerData, NationalSpire.CommunityPost)`](AiContext.cs.md#symbol-eaa3e44ce66a)；[`NationalSpire.MatchRules.Report(NationalSpire.CareerMatch, NationalSpire.CareerResult, bool)`](MatchRules.cs.md#symbol-ca4b0ef64a9d)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)；[`NationalSpire.PrivatePublicContext.AppendRecentResults(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateCareerContext.cs.md#symbol-8c2348c334d4)；[`NationalSpire.RunEvidence.ForPrompt(System.Collections.Generic.IEnumerable<string>?)`](RunEvidence.cs.md#symbol-7c9b35b61b80)；[`NationalSpire.RunEvidence.Summary()`](RunEvidence.cs.md#symbol-d852a24404b2)

**调用：** [`Side(bool)`](DuelReport.cs.md#symbol-b643ed871123)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.StringBuilder.Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.AppendJoin<T>(string?, System.Collections.Generic.IEnumerable<T>)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `Card(NationalSpire.DuelCardStep)`；`NationalSpire.DuelCardFace.Text`；`NationalSpire.DuelParticipant.Character`；`NationalSpire.DuelParticipant.Deck`；`NationalSpire.DuelParticipant.EndHp`；`NationalSpire.DuelParticipant.EndMax`；`NationalSpire.DuelParticipant.Name`；`NationalSpire.DuelParticipant.OpenHp`；`NationalSpire.DuelParticipant.OpenMax`；`NationalSpire.DuelParticipant.Opponent`；`NationalSpire.DuelReport.Note`；`NationalSpire.DuelReport.OpponentOpens`；`NationalSpire.DuelReport.People`；`NationalSpire.DuelReport.PlayedFaces`；`NationalSpire.DuelReport.PlayersWon`；`NationalSpire.DuelReport.Rounds`；`NationalSpire.DuelRound.Number`；`NationalSpire.DuelRound.Sequence`；`NationalSpire.DuelRound.Totals`；`NationalSpire.DuelSequenceRun.Cards`；`NationalSpire.DuelSequenceRun.Repeats`；`NationalSpire.DuelTurnTotals.Attack`；`NationalSpire.DuelTurnTotals.Block`；`NationalSpire.DuelTurnTotals.Cards`；`NationalSpire.DuelTurnTotals.Damage`；`NationalSpire.DuelTurnTotals.Doom`；`NationalSpire.DuelTurnTotals.DoomIntent`；`NationalSpire.DuelTurnTotals.Draw`；`NationalSpire.DuelTurnTotals.Energy`；`NationalSpire.GameText.Plain(string)`；`Side(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Side(bool)`；输入表达式：`Side(!PlayersWon)`；返回值紧邻使用处：`InterpolationSyntax: {Side(!PlayersWon)}`
- `Side(bool)`；输入表达式：`Side(false)`；返回值紧邻使用处：`InterpolationSyntax: {Side(false)}`
- `Side(bool)`；输入表达式：`Side(OpponentOpens)`；返回值紧邻使用处：`InterpolationSyntax: {Side(OpponentOpens)}`
- `Side(bool)`；输入表达式：`Side(true)`；返回值紧邻使用处：`InterpolationSyntax: {Side(true)}`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" → ",run.Cards.Select(Card))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =string.Join(" → ",run.Cards.Select(Card))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`round.Totals.Select((s, i) =>                 $"{People[i].Name} 出牌{s.Cards}，攻击意图{s.Attack}，格挡{s.Block}，伤害{s.Damage}，抽牌{s.Draw}，耗能{s.Energy}" +                 (s.DoomIntent == 0 && s.Doom == 0 ? "" : $"，灾厄意图{s.DoomIntent}，施加{s.Doom}"))`；返回值紧邻使用处：`ArgumentSyntax: round.Totals.Select((s, i) =>                 $"{People[i].Name} 出牌{s.Cards}，攻击意图{s.Attack}，格挡{s.Block}，伤害{s.Damage}，抽牌{s.Draw}，耗能{s.Energy}" +                 (s.DoomIntent == 0 && s.Doom == 0 ? "" : $"，灾厄意图{s.DoomIntent}，施加{s.Doom}"))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`(providedCards ?? []).Select(GameText.Plain)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (providedCards ?? []).Select(GameText.Plain).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Deck.Select(f=>f.Text)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Deck.Select(f=>f.Text).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`PlayedFaces.Select(f=>f.Text)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PlayedFaces.Select(f=>f.Text).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`r.Sequence.Select(run=>{                 string part=string.Join(" → ",run.Cards.Select(Card));                 return run.Repeats==1?part:"（"+part+"）×"+run.Repeats;             })`；返回值紧邻使用处：`ArgumentSyntax: r.Sequence.Select(run=>{                 string part=string.Join(" → ",run.Cards.Select(Card));                 return run.Repeats==1?part:"（"+part+"）×"+run.Repeats;             })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`run.Cards.Select(Card)`；返回值紧邻使用处：`ArgumentSyntax: run.Cards.Select(Card)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`(providedCards ?? []).Select(GameText.Plain).ToHashSet(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (providedCards ?? []).Select(GameText.Plain).ToHashSet(StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`p.Deck.Select(f=>f.Text).Where(seen.Add).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = p.Deck.Select(f=>f.Text).Where(seen.Add).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`PlayedFaces.Select(f=>f.Text).Where(seen.Add).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayedFaces.Select(f=>f.Text).Where(seen.Add).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Rounds.Where(r => r.Sequence.Count > 0).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Rounds.Where(r => r.Sequence.Count > 0).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Deck.Select(f=>f.Text).Where(seen.Add)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Deck.Select(f=>f.Text).Where(seen.Add).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PlayedFaces.Select(f=>f.Text).Where(seen.Add)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PlayedFaces.Select(f=>f.Text).Where(seen.Add).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Rounds.Where(r => r.Sequence.Count > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Rounds.Where(r => r.Sequence.Count > 0).ToList`
- `System.Text.StringBuilder.Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`text.Append($"{Side(false)} 对阵 {Side(true)}，{Side(OpponentOpens)}先手。共 {Rounds.Count} 回合，{Side(!PlayersWon)}获胜。")`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append($"{Side(false)} 对阵 {Side(true)}，{Side(OpponentOpens)}先手。共 {Rounds.Count} 回合，{Side(!PlayersWon)}获胜。");`
- `System.Text.StringBuilder.Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`text.Append($"\n{p.Name}（{p.Character}）  生命 {p.OpenHp}/{p.OpenMax} → {p.EndHp}/{p.EndMax}")`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append($"\n{p.Name}（{p.Character}）  生命 {p.OpenHp}/{p.OpenMax} → {p.EndHp}/{p.EndMax}");`
- `System.Text.StringBuilder.Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`text.Append($"\n{p.Name}的部分牌面  ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Append($"\n{p.Name}的部分牌面  ").AppendJoin`
- `System.Text.StringBuilder.Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`text.Append($"\n第{r.Number}回合  ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Append($"\n第{r.Number}回合  ").AppendJoin`
- `System.Text.StringBuilder.Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`text.Append($"\n第{round.Number}回合  ")`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append($"\n第{round.Number}回合  ");`
- `System.Text.StringBuilder.Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`text.Append($"\n其中{highlights.Count}个关键回合的完整出牌顺序")`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append($"\n其中{highlights.Count}个关键回合的完整出牌顺序");`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`text.Append("\n关键回合另见牌面  ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Append("\n关键回合另见牌面  ").AppendJoin`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`text.Append("\n玩家的牌组信息见正式战报。")`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append("\n玩家的牌组信息见正式战报。");`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`text.Append("\n逐回合战况按选手列出。格挡记录实际抵消量，伤害记录对方实际失血。")`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append("\n逐回合战况按选手列出。格挡记录实际抵消量，伤害记录对方实际失血。");`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`text.Append(Note)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append(Note);`
- `System.Text.StringBuilder.AppendJoin<T>(string?, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`text.Append("\n关键回合另见牌面  ").AppendJoin("；", extra)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append("\n关键回合另见牌面  ").AppendJoin("；", extra);`
- `System.Text.StringBuilder.AppendJoin<T>(string?, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`text.Append($"\n{p.Name}的部分牌面  ").AppendJoin("；", sample)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append($"\n{p.Name}的部分牌面  ").AppendJoin("；", sample);`
- `System.Text.StringBuilder.AppendJoin<T>(string?, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`text.Append($"\n第{r.Number}回合  ").AppendJoin(" → ",r.Sequence.Select(run=>{                 string part=string.Join(" → ",run.Cards.Select(Card));                 return run.Repeats==1?part:"（"+part+"）×"+run.Repeats;             }))`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append($"\n第{r.Number}回合  ").AppendJoin(" → ",r.Sequence.Select(run=>{                 string part=string.Join(" → ",run.Cards.Select(Card));                 return run.Repeats==1?part:"（"+part+"）×"+run.Repeats;             }));`
- `System.Text.StringBuilder.AppendJoin<T>(string?, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`text.AppendJoin(" ／ ", round.Totals.Select((s, i) =>                 $"{People[i].Name} 出牌{s.Cards}，攻击意图{s.Attack}，格挡{s.Block}，伤害{s.Damage}，抽牌{s.Draw}，耗能{s.Energy}" +                 (s.DoomIntent == 0 && s.Doom == 0 ? "" : $"，灾厄意图{s.DoomIntent}，施加{s.Doom}")))`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AppendJoin(" ／ ", round.Totals.Select((s, i) =>                 $"{People[i].Name} 出牌{s.Cards}，攻击意图{s.Attack}，格挡{s.Block}，伤害{s.Damage}，抽牌{s.Draw}，耗能{s.Energy}" +                 (s.DoomIntent == 0 && s.Doom == 0 ? "" : $"，灾厄意图{s.DoomIntent}，施加{s.Doom}")));`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`text.ToString()`；返回值紧邻使用处：`ReturnStatementSyntax: return text.ToString();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b643ed871123"></a>

## `Side(bool) — string Side(bool rival)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelReport.Describe(System.Collections.Generic.IEnumerable<string>?)`](DuelReport.cs.md#symbol-73d092aa7f0e)

**调用：** `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DuelParticipant.Name`；`NationalSpire.DuelParticipant.Opponent`；`NationalSpire.DuelReport.People`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", People.Where(p => p.Opponent == rival).Select(p => p.Name))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => string.Join("、", People.Where(p => p.Opponent == rival).Select(p => p.Name))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`People.Where(p => p.Opponent == rival).Select(p => p.Name)`；返回值紧邻使用处：`ArgumentSyntax: People.Where(p => p.Opponent == rival).Select(p => p.Name)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`People.Where(p => p.Opponent == rival)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: People.Where(p => p.Opponent == rival).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9321403c9bbe"></a>

## `Card(NationalSpire.DuelCardStep) — string Card(DuelCardStep step)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DuelCardStep.Actor`；`NationalSpire.DuelCardStep.Card`；`NationalSpire.DuelCardStep.Generated`；`NationalSpire.DuelCardStep.Target`；`NationalSpire.DuelParticipant.Name`；`NationalSpire.DuelReport.People`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `last` = `step.Actor`

<a id="symbol-d52f5774d5b8"></a>

## `NationalSpire.DuelReplay.Faces — public List<DuelCardFace> Faces`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-59131c1c925d"></a>

## `NationalSpire.DuelReplay.Decks — public List<List<int>> Decks`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4c7c298ca910"></a>

## `NationalSpire.DuelReplay.Rounds — public Dictionary<int,List<DuelReplayStep>> Rounds`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b33f7eff0a3e"></a>

## `NationalSpire.DuelParticipant.PersonId — public string PersonId`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5f3fd4ac7b6d"></a>

## `NationalSpire.DuelParticipant.Name — public string Name`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-55619591d7ac"></a>

## `NationalSpire.DuelParticipant.Character — public string Character`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9b666dceb3a8"></a>

## `NationalSpire.DuelParticipant.Opponent — public bool Opponent`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bf8064516725"></a>

## `NationalSpire.DuelParticipant.OpenHp — public int OpenHp`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-47be1b5958ae"></a>

## `NationalSpire.DuelParticipant.OpenMax — public int OpenMax`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a52524961a5d"></a>

## `NationalSpire.DuelParticipant.EndHp — public int EndHp`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b356dd992ddd"></a>

## `NationalSpire.DuelParticipant.EndMax — public int EndMax`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f3263e1ba911"></a>

## `NationalSpire.DuelParticipant.Deck — public List<DuelCardFace> Deck`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7f88ccfd8527"></a>

## `NationalSpire.DuelRound.Number — public int Number`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2b264824bf98"></a>

## `NationalSpire.DuelRound.Totals — public List<DuelTurnTotals> Totals`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-734304709a9d"></a>

## `NationalSpire.DuelRound.Sequence — public List<DuelSequenceRun> Sequence`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a53451130e63"></a>

## `NationalSpire.DuelTurnTotals.Cards — public int Cards`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-558c4c563887"></a>

## `NationalSpire.DuelTurnTotals.Draw — public int Draw`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-645a991d0726"></a>

## `NationalSpire.DuelTurnTotals.Energy — public int Energy`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6612be2c1597"></a>

## `NationalSpire.DuelTurnTotals.Attack — public int Attack`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1c6170225d60"></a>

## `NationalSpire.DuelTurnTotals.DoomIntent — public int DoomIntent`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9576e203c1ef"></a>

## `NationalSpire.DuelTurnTotals.Doom — public int Doom`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dd33829793f8"></a>

## `NationalSpire.DuelTurnTotals.Block — public int Block`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bf0ee9802ac1"></a>

## `NationalSpire.DuelTurnTotals.Damage — public int Damage`

来源：源码第 102 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
