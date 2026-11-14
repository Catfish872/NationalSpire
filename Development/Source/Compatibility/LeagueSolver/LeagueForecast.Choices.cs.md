# Compatibility/LeagueSolver/LeagueForecast.Choices.cs

[返回文件依赖索引](../../../SOURCE_MAP.md)

源码 SHA-256：`79C56C47F009507074D7EDD8A72F2CA2734C32C4C2E134AA7730AF83A6296D08`。来源：[源码](../../../../Compatibility/LeagueSolver/LeagueForecast.Choices.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Solver.LeagueForecast`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly SolverDisplayNames Names=new([],new("DINGY_DAGGER","DINGY_DAGGER","DINGY_DAGGER"),[],[],[],[],[],[],[],false,false);
```

<a id="symbol-0be8b41d9374"></a>

## `NationalSpire.Solver.LeagueForecast.PlayOptions(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, int, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Players.Player, int, System.Func<bool>, System.Action) — private static IEnumerable<(CombatPredictionSimulator,int[])> PlayOptions(CombatPredictionSimulator parent,int slot,Creature? target,Player actor,int width,Func<bool> expired,Action incomplete)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** [`NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger)`](LeagueForecast.cs.md#symbol-9ecdb20e5b06)；[`NationalSpire.Solver.LeagueForecast.MenuKey(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>)`](LeagueForecast.Choices.cs.md#symbol-fae42c60aea3)；`CombatSolver.CardChoiceSupport.BuildChoices(CombatSolver.CardChoiceSpec, CombatSolver.SolverDisplayNames, int, int)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Fork()`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.ManualPlay(CombatSolver.Engine.Common.PredictedCard, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, out CombatSolver.Engine.Common.PredictionTraceFrame?)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；`CombatSolver.PredictionCoverage.Collect(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；`CombatSolver.SimulatedCombatState.BeginActionChoices(System.Collections.Generic.IReadOnlyList<CombatSolver.PlanCardChoice>?)`；`CombatSolver.SimulatedCombatState.EndActionChoices()`；`CombatSolver.TurnStartChoiceSupport.BuildPendingSpec(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, CombatSolver.SimulatedCombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetNetIdForEntry(string)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.Stack<T>.Push(T)`；`System.Collections.Generic.Stack<T>.Stack()`；`System.Collections.Generic.Stack<T>.TryPop(out T)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Math.Min(int, int)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`

**字段、属性、事件及方法组引用：** `(CombatSolver.PlanCardChoice[] path, int[] wire).path`；`(CombatSolver.PlanCardChoice[] path, int[] wire).wire`；`NationalSpire.Solver.LeagueForecast._move`；`NationalSpire.Solver.LeagueForecast.Damage`；`NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger)`；`NationalSpire.Solver.LeagueForecast.MenuKey(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>)`；`NationalSpire.Solver.LeagueForecast.Names`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.CardChoiceSupport.BuildChoices(CombatSolver.CardChoiceSpec, CombatSolver.SolverDisplayNames, int, int)`；输入表达式：`CardChoiceSupport.BuildChoices(spec,Names,width,width)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CardChoiceSupport.BuildChoices(spec,Names,width,width)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Fork()`；输入表达式：`parent.Fork()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =parent.Fork()`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.ManualPlay(CombatSolver.Engine.Common.PredictedCard, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, out CombatSolver.Engine.Common.PredictionTraceFrame?)`；输入表达式：`sim.ManualPlay(card,target,out _)`；返回值紧邻使用处：`AssignmentExpressionSyntax: complete=sim.ManualPlay(card,target,out _)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`sim.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sim.State.GetPlayerCombatState(actor).Hand`
- `CombatSolver.PredictionCoverage.Collect(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；输入表达式：`PredictionCoverage.Collect(sim)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PredictionCoverage.Collect(sim).Any`
- `CombatSolver.SimulatedCombatState.BeginActionChoices(System.Collections.Generic.IReadOnlyList<CombatSolver.PlanCardChoice>?)`；输入表达式：`state.BeginActionChoices(branch.path)`；返回值紧邻使用处：`ExpressionStatementSyntax: state.BeginActionChoices(branch.path);`
- `CombatSolver.SimulatedCombatState.EndActionChoices()`；输入表达式：`state.EndActionChoices()`；返回值紧邻使用处：`ExpressionStatementSyntax: state.EndActionChoices();`
- `CombatSolver.TurnStartChoiceSupport.BuildPendingSpec(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, CombatSolver.SimulatedCombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`TurnStartChoiceSupport.BuildPendingSpec(sim,state,actor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =TurnStartChoiceSupport.BuildPendingSpec(sim,state,actor)`
- `MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetNetIdForEntry(string)`；输入表达式：`ModelIdSerializationCache.GetNetIdForEntry(t.CardId)`；返回值紧邻使用处：`InitializerExpressionSyntax: {ModelIdSerializationCache.GetNetIdForEntry(t.CardId),t.UpgradeLevel,t.OptionOccurrence}`
- `NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger)`；输入表达式：`mark.Copy(Damage.GetOrCreateValue(parent))`；返回值紧邻使用处：`ExpressionStatementSyntax: mark.Copy(Damage.GetOrCreateValue(parent));`
- `NationalSpire.Solver.LeagueForecast.MenuKey(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>)`；输入表达式：`MenuKey(spec.Options.Select(c=>c.Preview))`；返回值紧邻使用处：`ExpressionElementSyntax: MenuKey(spec.Options.Select(c=>c.Preview))`
- `System.Action.Invoke()`；输入表达式：`incomplete()`；返回值紧邻使用处：`ExpressionStatementSyntax: incomplete();`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PredictionCoverage.Collect(sim).Any(g=>!g.Compensated)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PredictionCoverage.Collect(sim).Any(g=>!g.Compensated)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`spec.Options.Select(c=>c.Preview)`；返回值紧邻使用处：`ArgumentSyntax: spec.Options.Select(c=>c.Preview)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`choice.Cards.SelectMany(t=>new[]{ModelIdSerializationCache.GetNetIdForEntry(t.CardId),t.UpgradeLevel,t.OptionOccurrence})`；返回值紧邻使用处：`EqualsValueClauseSyntax: =choice.Cards.SelectMany(t=>new[]{ModelIdSerializationCache.GetNetIdForEntry(t.CardId),t.UpgradeLevel,t.OptionOccurrence})`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`(pending??=new()).Push(([..branch.path,choice],wire))`；返回值紧邻使用处：`ExpressionStatementSyntax: (pending??=new()).Push(([..branch.path,choice],wire));`
- `System.Collections.Generic.Stack<T>.Stack()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: pending??=new()`
- `System.Collections.Generic.Stack<T>.TryPop(out T)`；输入表达式：`pending.TryPop(out branch)`；返回值紧邻使用处：`BinaryExpressionSyntax: pending!=null&&pending.TryPop(out branch)`
- `System.Func<TResult>.Invoke()`；输入表达式：`expired()`；返回值紧邻使用处：`BinaryExpressionSyntax: branch.path.Length>0&&expired()`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(width,options.Count)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(width,options.Count)-1`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Damage.GetOrCreateValue(parent)`；返回值紧邻使用处：`ArgumentSyntax: Damage.GetOrCreateValue(parent)`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Damage.GetOrCreateValue(sim)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Damage.GetOrCreateValue(sim)`

**赋值（含属性/字段和局部值）：**

- `_move` = `mark`
- `_move` = `null`
- `complete` = `sim.ManualPlay(card,target,out _)`
- `ContextId` = `req.ContextId`
- `pending` ??= `new()`
- `SourceId` = `req.SourceId`
- `Timing` = `req.Timing`
- `wire` = `[..wire,(int)spec.SourcePile,MenuKey(spec.Options.Select(c=>c.Preview)),(int)spec.Effect,choice.Cards.Count,..selected]`

<a id="symbol-fae42c60aea3"></a>

## `NationalSpire.Solver.LeagueForecast.MenuKey(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>) — public static int MenuKey(IEnumerable<CardModel> cards)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.PlayOptions(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, int, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Players.Player, int, System.Func<bool>, System.Action)`](LeagueForecast.Choices.cs.md#symbol-0be8b41d9374)

**调用：** `MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetNetIdForEntry(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetNetIdForEntry(string)`；输入表达式：`ModelIdSerializationCache.GetNetIdForEntry(c.Id.Entry)`；返回值紧邻使用处：`BinaryExpressionSyntax: hash*31+ModelIdSerializationCache.GetNetIdForEntry(c.Id.Entry)`

**赋值（含属性/字段和局部值）：**

- `hash` = `hash*31+c.CurrentUpgradeLevel`
- `hash` = `hash*31+ModelIdSerializationCache.GetNetIdForEntry(c.Id.Entry)`

<a id="symbol-621299823e37"></a>

## `NationalSpire.Solver.LeagueForecast.SelectActual(MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, int, int) — public static int[] SelectActual(CardModel[] cards,int pile,string purpose,int effect,int min,int max)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `CombatSolver.CardChoiceSpec.CardChoiceSpec(CombatSolver.PlanChoiceEffect, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, double, string, int?, bool, bool)`；`CombatSolver.CardChoiceSupport.BuildChoices(CombatSolver.CardChoiceSpec, CombatSolver.SolverDisplayNames, int, int)`；`CombatSolver.CardChoiceSupport.MatchesToken(CombatSolver.Engine.Common.PredictedCard, CombatSolver.PlanCardToken)`；`CombatSolver.Engine.Common.PredictedCard.PredictedCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel?)`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.IEnumerable<TSource>.ElementAt<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.Names`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.CardChoiceSpec.CardChoiceSpec(CombatSolver.PlanChoiceEffect, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, double, string, int?, bool, bool)`；输入表达式：`new CardChoiceSpec(kind,(PileType)pile,Math.Min(min,cards.Length),Math.Min(max,cards.Length),options,options,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CardChoiceSpec(kind,(PileType)pile,Math.Min(min,cards.Length),Math.Min(max,cards.Length),options,options,0)`
- `CombatSolver.CardChoiceSupport.BuildChoices(CombatSolver.CardChoiceSpec, CombatSolver.SolverDisplayNames, int, int)`；输入表达式：`CardChoiceSupport.BuildChoices(spec,Names,1,1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CardChoiceSupport.BuildChoices(spec,Names,1,1)`
- `CombatSolver.CardChoiceSupport.MatchesToken(CombatSolver.Engine.Common.PredictedCard, CombatSolver.PlanCardToken)`；输入表达式：`CardChoiceSupport.MatchesToken(x,t)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x=>CardChoiceSupport.MatchesToken(x,t)`
- `CombatSolver.Engine.Common.PredictedCard.PredictedCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel?)`；输入表达式：`new PredictedCard(c)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>new PredictedCard(c)`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(options,options.Where(x=>CardChoiceSupport.MatchesToken(x,t)).ElementAt(t.OptionOccurrence))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t=>Array.IndexOf(options,options.Where(x=>CardChoiceSupport.MatchesToken(x,t)).ElementAt(t.OptionOccurrence))`
- `System.Collections.Generic.IEnumerable<TSource>.ElementAt<TSource>(int)`；输入表达式：`options.Where(x=>CardChoiceSupport.MatchesToken(x,t)).ElementAt(t.OptionOccurrence)`；返回值紧邻使用处：`ArgumentSyntax: options.Where(x=>CardChoiceSupport.MatchesToken(x,t)).ElementAt(t.OptionOccurrence)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`cards.Select(c=>new PredictedCard(c))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.Select(c=>new PredictedCard(c)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ranked[0].Cards.Select(t=>Array.IndexOf(options,options.Where(x=>CardChoiceSupport.MatchesToken(x,t)).ElementAt(t.OptionOccurrence)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ranked[0].Cards.Select(t=>Array.IndexOf(options,options.Where(x=>CardChoiceSupport.MatchesToken(x,t)).ElementAt(t.OptionOccurrence))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`cards.Select(c=>new PredictedCard(c)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =cards.Select(c=>new PredictedCard(c)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0,Math.Min(cards.Length,min)).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return Enumerable.Range(0,Math.Min(cards.Length,min)).ToArray();`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`ranked[0].Cards.Select(t=>Array.IndexOf(options,options.Where(x=>CardChoiceSupport.MatchesToken(x,t)).ElementAt(t.OptionOccurrence))).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return ranked[0].Cards.Select(t=>Array.IndexOf(options,options.Where(x=>CardChoiceSupport.MatchesToken(x,t)).ElementAt(t.OptionOccurrence))).ToArray();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`options.Where(x=>CardChoiceSupport.MatchesToken(x,t))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: options.Where(x=>CardChoiceSupport.MatchesToken(x,t)).ElementAt`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0,Math.Min(cards.Length,min))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,Math.Min(cards.Length,min)).ToArray`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(cards.Length,min)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(cards.Length,min)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(max,cards.Length)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(max,cards.Length)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(min,cards.Length)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(min,cards.Length)`

**赋值（含属性/字段和局部值）：**
