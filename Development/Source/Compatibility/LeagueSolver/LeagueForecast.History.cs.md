# Compatibility/LeagueSolver/LeagueForecast.History.cs

[返回文件依赖索引](../../../SOURCE_MAP.md)

源码 SHA-256：`DD788CBEA4248CA2D2E9F82B860F92727837245FCF425008044A8C6F3F64AB9B`。来源：[源码](../../../../Compatibility/LeagueSolver/LeagueForecast.History.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Solver.LeagueForecast`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly AccessTools.FieldRef<PlayerCombatState,int> StarBalance=AccessTools.FieldRefAccess<PlayerCombatState,int>("_stars");
[ThreadStatic] private static RootCombatHistorySnapshot? _mappedHistory;
private static readonly AccessTools.FieldRef<CardPlayFinishedEntry,bool> Ethereal=AccessTools.FieldRefAccess<CardPlayFinishedEntry,bool>("<WasEthereal>k__BackingField");
```

<a id="symbol-63c85315202e"></a>

## `NationalSpire.Solver.LeagueForecast.UseMappedHistory(ref CombatSolver.RootCombatHistorySnapshot) — private static bool UseMappedHistory(ref RootCombatHistorySnapshot __result)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._mappedHistory`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `__result` = `_mappedHistory`

<a id="symbol-6f96751f4567"></a>

## `NationalSpire.Solver.LeagueForecast.MapHistory(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature>) — private RootCombatHistorySnapshot MapHistory(CombatState board,Player actor,Dictionary<Creature,Creature> creatures)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Capture(bool)`](LeagueForecast.cs.md#symbol-1c0fdc3118f7)

**调用：** [`Card(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueForecast.History.cs.md#symbol-aff755945fab)；[`Play(MegaCrit.Sts2.Core.Entities.Cards.CardPlay)`](LeagueForecast.History.cs.md#symbol-6a4e6de3d2ca)；[`Result(MegaCrit.Sts2.Core.Entities.Creatures.DamageResult)`](LeagueForecast.History.cs.md#symbol-9e291d75ab55)；[`Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](LeagueForecast.History.cs.md#symbol-b78dec6094c2)；`CombatSolver.RootCombatHistorySnapshot.RootCombatHistorySnapshot(MegaCrit.Sts2.Core.Combat.History.Entries.CardPlayStartedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CardPlayFinishedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.DamageReceivedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.PowerReceivedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CardDiscardedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CreatureAttackedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.EnergySpentEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.StarsModifiedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CardDrawnEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CardExhaustedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.BlockGainedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CardGeneratedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.OrbChanneledEntry[])`；`HarmonyLib.AccessTools.FieldRef<T, F>.Invoke(T)`（委托实际目标见流程文档）；`MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry.HappenedThisTurn(MegaCrit.Sts2.Core.Combat.ICombatState?)`；`MegaCrit.Sts2.Core.Combat.History.Entries.BlockGainedEntry.BlockGainedEntry(int, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.CardDiscardedEntry.CardDiscardedEntry(MegaCrit.Sts2.Core.Models.CardModel, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.CardDrawnEntry.CardDrawnEntry(MegaCrit.Sts2.Core.Models.CardModel, int, MegaCrit.Sts2.Core.Combat.CombatSide, bool, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.CardExhaustedEntry.CardExhaustedEntry(MegaCrit.Sts2.Core.Models.CardModel, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.CardGeneratedEntry.CardGeneratedEntry(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player?, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.CardPlayFinishedEntry.CardPlayFinishedEntry(MegaCrit.Sts2.Core.Entities.Cards.CardPlay, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.CardPlayStartedEntry.CardPlayStartedEntry(MegaCrit.Sts2.Core.Entities.Cards.CardPlay, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.CreatureAttackedEntry.CreatureAttackedEntry(MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.DamageReceivedEntry.DamageReceivedEntry(MegaCrit.Sts2.Core.Entities.Creatures.DamageResult, MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.EnergySpentEntry.EnergySpentEntry(int, MegaCrit.Sts2.Core.Entities.Players.Player, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.OrbChanneledEntry.OrbChanneledEntry(MegaCrit.Sts2.Core.Models.OrbModel, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.PowerReceivedEntry.PowerReceivedEntry(MegaCrit.Sts2.Core.Models.PowerModel, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Combat.History.Entries.StarsModifiedEntry.StarsModifiedEntry(int, MegaCrit.Sts2.Core.Entities.Players.Player, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；`MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `Card(MegaCrit.Sts2.Core.Models.CardModel)`；`NationalSpire.Solver.LeagueForecast._live`；`NationalSpire.Solver.LeagueForecast._originals`；`NationalSpire.Solver.LeagueForecast.Ethereal`；`Play(MegaCrit.Sts2.Core.Entities.Cards.CardPlay)`；`Result(MegaCrit.Sts2.Core.Entities.Creatures.DamageResult)`；`Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Card(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`Card(a.Card)`；返回值紧邻使用处：`ArgumentSyntax: Card(a.Card)`
- `Card(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`Card(a.CardSource)`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.CardSource==null?null:Card(a.CardSource)`
- `CombatSolver.RootCombatHistorySnapshot.RootCombatHistorySnapshot(MegaCrit.Sts2.Core.Combat.History.Entries.CardPlayStartedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CardPlayFinishedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.DamageReceivedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.PowerReceivedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CardDiscardedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CreatureAttackedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.EnergySpentEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.StarsModifiedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CardDrawnEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CardExhaustedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.BlockGainedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.CardGeneratedEntry[], MegaCrit.Sts2.Core.Combat.History.Entries.OrbChanneledEntry[])`；输入表达式：`new([..started],[..finished],[..damage],[..powers],[..discard],[..attacks],[..energy],[..stars],[..draws],[..exhaust],[..blocks],[..generated],[..orbs])`；返回值紧邻使用处：`ReturnStatementSyntax: return new([..started],[..finished],[..damage],[..powers],[..discard],[..attacks],[..energy],[..stars],[..draws],[..exhaust],[..blocks],[..generated],[..orbs]);`
- `HarmonyLib.AccessTools.FieldRef<T, F>.Invoke(T)`；输入表达式：`Ethereal(end)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Ethereal(end)=a.WasEthereal`
- `MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry.HappenedThisTurn(MegaCrit.Sts2.Core.Combat.ICombatState?)`；输入表达式：`e.HappenedThisTurn(live)`；返回值紧邻使用处：`ConditionalExpressionSyntax: e.HappenedThisTurn(live)?board.RoundNumber:0`
- `MegaCrit.Sts2.Core.Combat.History.Entries.BlockGainedEntry.BlockGainedEntry(int, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(a.Amount,a.Props,a.CardPlay==null?null:Play(a.CardPlay),Target(a.Receiver)!,turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(a.Amount,a.Props,a.CardPlay==null?null:Play(a.CardPlay),Target(a.Receiver)!,turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.CardDiscardedEntry.CardDiscardedEntry(MegaCrit.Sts2.Core.Models.CardModel, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(Card(a.Card),turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(Card(a.Card),turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.CardDrawnEntry.CardDrawnEntry(MegaCrit.Sts2.Core.Models.CardModel, int, MegaCrit.Sts2.Core.Combat.CombatSide, bool, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(Card(a.Card),turn,side,a.FromHandDraw,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(Card(a.Card),turn,side,a.FromHandDraw,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.CardExhaustedEntry.CardExhaustedEntry(MegaCrit.Sts2.Core.Models.CardModel, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(Card(a.Card),turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(Card(a.Card),turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.CardGeneratedEntry.CardGeneratedEntry(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player?, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(Card(a.Card),a.Creator==_live?actor:a.Creator,turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(Card(a.Card),a.Creator==_live?actor:a.Creator,turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.CardPlayFinishedEntry.CardPlayFinishedEntry(MegaCrit.Sts2.Core.Entities.Cards.CardPlay, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new CardPlayFinishedEntry(Play(a.CardPlay),turn,side,history,roster)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CardPlayFinishedEntry(Play(a.CardPlay),turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.CardPlayStartedEntry.CardPlayStartedEntry(MegaCrit.Sts2.Core.Entities.Cards.CardPlay, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(Play(a.CardPlay),turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(Play(a.CardPlay),turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.CreatureAttackedEntry.CreatureAttackedEntry(MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(Target(a.Actor)!,a.DamageResults.Select(Result).ToArray(),turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(Target(a.Actor)!,a.DamageResults.Select(Result).ToArray(),turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.DamageReceivedEntry.DamageReceivedEntry(MegaCrit.Sts2.Core.Entities.Creatures.DamageResult, MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(Result(a.Result),Target(a.Receiver)!,Target(a.Dealer),a.CardSource==null?null:Card(a.CardSource),turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(Result(a.Result),Target(a.Receiver)!,Target(a.Dealer),a.CardSource==null?null:Card(a.CardSource),turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.EnergySpentEntry.EnergySpentEntry(int, MegaCrit.Sts2.Core.Entities.Players.Player, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(a.Amount,actor,turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(a.Amount,actor,turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.OrbChanneledEntry.OrbChanneledEntry(MegaCrit.Sts2.Core.Models.OrbModel, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(orb,turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(orb,turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.PowerReceivedEntry.PowerReceivedEntry(MegaCrit.Sts2.Core.Models.PowerModel, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(a.Power,a.Amount,Target(a.Applier),turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(a.Power,a.Amount,Target(a.Applier),turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Combat.History.Entries.StarsModifiedEntry.StarsModifiedEntry(int, MegaCrit.Sts2.Core.Entities.Players.Player, int, MegaCrit.Sts2.Core.Combat.CombatSide, MegaCrit.Sts2.Core.Combat.History.CombatHistory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player>)`；输入表达式：`new(a.Amount,actor,turn,side,history,roster)`；返回值紧邻使用处：`ArgumentSyntax: new(a.Amount,actor,turn,side,history,roster)`
- `MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；输入表达式：`a.Orb.MutableClone()`；返回值紧邻使用处：`CastExpressionSyntax: (OrbModel)a.Orb.MutableClone()`
- `Play(MegaCrit.Sts2.Core.Entities.Cards.CardPlay)`；输入表达式：`Play(a.CardPlay)`；返回值紧邻使用处：`ArgumentSyntax: Play(a.CardPlay)`
- `Play(MegaCrit.Sts2.Core.Entities.Cards.CardPlay)`；输入表达式：`Play(a.CardPlay)`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.CardPlay==null?null:Play(a.CardPlay)`
- `Result(MegaCrit.Sts2.Core.Entities.Creatures.DamageResult)`；输入表达式：`Result(a.Result)`；返回值紧邻使用处：`ArgumentSyntax: Result(a.Result)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<CardPlay,CardPlay>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<CardPlay,CardPlay>()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`a.DamageResults.Select(Result)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: a.DamageResults.Select(Result).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`a.DamageResults.Select(Result).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: a.DamageResults.Select(Result).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`_originals.ToDictionary(p=>p.Value,p=>p.Key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_originals.ToDictionary(p=>p.Value,p=>p.Key)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`attacks.Add(new(Target(a.Actor)!,a.DamageResults.Select(Result).ToArray(),turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: attacks.Add(new(Target(a.Actor)!,a.DamageResults.Select(Result).ToArray(),turn,side,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`blocks.Add(new(a.Amount,a.Props,a.CardPlay==null?null:Play(a.CardPlay),Target(a.Receiver)!,turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: blocks.Add(new(a.Amount,a.Props,a.CardPlay==null?null:Play(a.CardPlay),Target(a.Receiver)!,turn,side,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`damage.Add(new(Result(a.Result),Target(a.Receiver)!,Target(a.Dealer),a.CardSource==null?null:Card(a.CardSource),turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: damage.Add(new(Result(a.Result),Target(a.Receiver)!,Target(a.Dealer),a.CardSource==null?null:Card(a.CardSource),turn,side,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`discard.Add(new(Card(a.Card),turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: discard.Add(new(Card(a.Card),turn,side,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`draws.Add(new(Card(a.Card),turn,side,a.FromHandDraw,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: draws.Add(new(Card(a.Card),turn,side,a.FromHandDraw,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`energy.Add(new(a.Amount,actor,turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: energy.Add(new(a.Amount,actor,turn,side,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`exhaust.Add(new(Card(a.Card),turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: exhaust.Add(new(Card(a.Card),turn,side,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`finished.Add(end)`；返回值紧邻使用处：`ExpressionStatementSyntax: finished.Add(end);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`generated.Add(new(Card(a.Card),a.Creator==_live?actor:a.Creator,turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: generated.Add(new(Card(a.Card),a.Creator==_live?actor:a.Creator,turn,side,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`orbs.Add(new(orb,turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: orbs.Add(new(orb,turn,side,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`powers.Add(new(a.Power,a.Amount,Target(a.Applier),turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: powers.Add(new(a.Power,a.Amount,Target(a.Applier),turn,side,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`stars.Add(new(a.Amount,actor,turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: stars.Add(new(a.Amount,actor,turn,side,history,roster));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`started.Add(new(Play(a.CardPlay),turn,side,history,roster))`；返回值紧邻使用处：`ExpressionStatementSyntax: started.Add(new(Play(a.CardPlay),turn,side,history,roster));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<BlockGainedEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<BlockGainedEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CardDiscardedEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<CardDiscardedEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CardDrawnEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<CardDrawnEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CardExhaustedEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<CardExhaustedEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CardGeneratedEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<CardGeneratedEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CardPlayFinishedEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<CardPlayFinishedEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CardPlayStartedEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<CardPlayStartedEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CreatureAttackedEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<CreatureAttackedEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DamageReceivedEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<DamageReceivedEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<EnergySpentEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<EnergySpentEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<OrbChanneledEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<OrbChanneledEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<PowerReceivedEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<PowerReceivedEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<StarsModifiedEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<StarsModifiedEntry>()`
- `Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Target(a.Actor)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Target(a.Actor)!`
- `Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Target(a.Applier)`；返回值紧邻使用处：`ArgumentSyntax: Target(a.Applier)`
- `Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Target(a.Dealer)`；返回值紧邻使用处：`ArgumentSyntax: Target(a.Dealer)`
- `Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Target(a.Receiver)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Target(a.Receiver)!`

**赋值（含属性/字段和局部值）：**

- `Ethereal(end)` = `a.WasEthereal`
- `orb.Owner` = `actor`
- `orb.Owner` = `null!`

<a id="symbol-b78dec6094c2"></a>

## `Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?) — Creature? Target(Creature? c)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.MapHistory(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`](LeagueForecast.History.cs.md#symbol-6f96751f4567)；[`Play(MegaCrit.Sts2.Core.Entities.Cards.CardPlay)`](LeagueForecast.History.cs.md#symbol-6a4e6de3d2ca)；[`Result(MegaCrit.Sts2.Core.Entities.Creatures.DamageResult)`](LeagueForecast.History.cs.md#symbol-9e291d75ab55)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`creatures.GetValueOrDefault(c,c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c==null?null:creatures.GetValueOrDefault(c,c)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-aff755945fab"></a>

## `Card(MegaCrit.Sts2.Core.Models.CardModel) — CardModel Card(CardModel c)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.MapHistory(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`](LeagueForecast.History.cs.md#symbol-6f96751f4567)；[`Play(MegaCrit.Sts2.Core.Entities.Cards.CardPlay)`](LeagueForecast.History.cs.md#symbol-6a4e6de3d2ca)

**调用：** `MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._live`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；输入表达式：`c.MutableClone()`；返回值紧邻使用处：`CastExpressionSyntax: (CardModel)c.MutableClone()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`originals.TryGetValue(c,out var copy)`；返回值紧邻使用处：`IfStatementSyntax: if(originals.TryGetValue(c,out var copy))return copy;`

**赋值（含属性/字段和局部值）：**

- `copy.Owner` = `actor`
- `copy.Owner` = `null!`
- `copy` = `(CardModel)c.MutableClone()`
- `originals[c]` = `copy`

<a id="symbol-6a4e6de3d2ca"></a>

## `Play(MegaCrit.Sts2.Core.Entities.Cards.CardPlay) — CardPlay Play(CardPlay p)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.MapHistory(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`](LeagueForecast.History.cs.md#symbol-6f96751f4567)

**调用：** [`Card(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueForecast.History.cs.md#symbol-aff755945fab)；[`Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](LeagueForecast.History.cs.md#symbol-b78dec6094c2)；`MegaCrit.Sts2.Core.Entities.Cards.CardPlay.CardPlay()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `Card(MegaCrit.Sts2.Core.Models.CardModel)`；`NationalSpire.Solver.LeagueForecast._live`；`Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Card(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`Card(p.Card)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Card=Card(p.Card)`
- `MegaCrit.Sts2.Core.Entities.Cards.CardPlay.CardPlay()`；输入表达式：`new(){Card=Card(p.Card),Player=p.Player==_live?actor:p.Player,Target=Target(p.Target),                 Resources=p.Resources,IsAutoPlay=p.IsAutoPlay,ResultPile=p.ResultPile,PlayCount=p.PlayCount,PlayIndex=p.PlayIndex}`；返回值紧邻使用处：`AssignmentExpressionSyntax: plays[p]=new(){Card=Card(p.Card),Player=p.Player==_live?actor:p.Player,Target=Target(p.Target),                 Resources=p.Resources,IsAutoPlay=p.IsAutoPlay,ResultPile=p.ResultPile,PlayCount=p.PlayCount,PlayIndex=p.PlayIndex}`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`plays.TryGetValue(p,out var copy)`；返回值紧邻使用处：`IfStatementSyntax: if(plays.TryGetValue(p,out var copy))return copy;`
- `Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Target(p.Target)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Target=Target(p.Target)`

**赋值（含属性/字段和局部值）：**

- `Card` = `Card(p.Card)`
- `IsAutoPlay` = `p.IsAutoPlay`
- `PlayCount` = `p.PlayCount`
- `Player` = `p.Player==_live?actor:p.Player`
- `PlayIndex` = `p.PlayIndex`
- `plays[p]` = `new(){Card=Card(p.Card),Player=p.Player==_live?actor:p.Player,Target=Target(p.Target),                 Resources=p.Resources,IsAutoPlay=p.IsAutoPlay,ResultPile=p.ResultPile,PlayCount=p.PlayCount,PlayIndex=p.PlayIndex}`
- `Resources` = `p.Resources`
- `ResultPile` = `p.ResultPile`
- `Target` = `Target(p.Target)`

<a id="symbol-9e291d75ab55"></a>

## `Result(MegaCrit.Sts2.Core.Entities.Creatures.DamageResult) — DamageResult Result(DamageResult d)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.MapHistory(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`](LeagueForecast.History.cs.md#symbol-6f96751f4567)

**调用：** [`Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](LeagueForecast.History.cs.md#symbol-b78dec6094c2)；`MegaCrit.Sts2.Core.Entities.Creatures.DamageResult.DamageResult(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.ValueProps.ValueProp)`

**字段、属性、事件及方法组引用：** `Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Creatures.DamageResult.DamageResult(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；输入表达式：`new(Target(d.Receiver)!,d.Props){OriginalTarget=Target(d.OriginalTarget)!,             BlockedDamage=d.BlockedDamage,UnblockedDamage=d.UnblockedDamage,OverkillDamage=d.OverkillDamage,IntendedHpLoss=d.IntendedHpLoss,             WasTargetKilled=d.WasTargetKilled,WasFullyBlocked=d.WasFullyBlocked,WasBlockBroken=d.WasBlockBroken}`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>new(Target(d.Receiver)!,d.Props){OriginalTarget=Target(d.OriginalTarget)!,             BlockedDamage=d.BlockedDamage,UnblockedDamage=d.UnblockedDamage,OverkillDamage=d.OverkillDamage,IntendedHpLoss=d.IntendedHpLoss,             WasTargetKilled=d.WasTargetKilled,WasFullyBlocked=d.WasFullyBlocked,WasBlockBroken=d.WasBlockBroken}`
- `Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Target(d.OriginalTarget)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Target(d.OriginalTarget)!`
- `Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Target(d.Receiver)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Target(d.Receiver)!`

**赋值（含属性/字段和局部值）：**

- `BlockedDamage` = `d.BlockedDamage`
- `IntendedHpLoss` = `d.IntendedHpLoss`
- `OriginalTarget` = `Target(d.OriginalTarget)!`
- `OverkillDamage` = `d.OverkillDamage`
- `UnblockedDamage` = `d.UnblockedDamage`
- `WasBlockBroken` = `d.WasBlockBroken`
- `WasFullyBlocked` = `d.WasFullyBlocked`
- `WasTargetKilled` = `d.WasTargetKilled`
