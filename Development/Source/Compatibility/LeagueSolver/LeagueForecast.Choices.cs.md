# Compatibility/LeagueSolver/LeagueForecast.Choices.cs

[返回文件依赖索引](../../../SOURCE_MAP.md)

源码 SHA-256：`4DD8AB37BD4E6C61895925FACAE33E8F118E42E6B1075E48033E1A41FC5DD2FF`。来源：[源码](../../../../Compatibility/LeagueSolver/LeagueForecast.Choices.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Solver.LeagueForecast`、`NationalSpire.Solver.LeagueForecast.SelectionMenu`、`NationalSpire.Solver.LeagueForecast.SelectionPath`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-fae42c60aea3"></a>

## `NationalSpire.Solver.LeagueForecast.MenuKey(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>) — public static int MenuKey(IEnumerable<CardModel> cards)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Solver.LeagueForecast.HashMenu(System.Collections.Generic.IEnumerable<(string Id, int Level)>)`](LeagueForecast.Choices.cs.md#symbol-c1acb17c4015)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.HashMenu(System.Collections.Generic.IEnumerable<(string Id, int Level)>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Solver.LeagueForecast.HashMenu(System.Collections.Generic.IEnumerable<(string Id, int Level)>)`；输入表达式：`HashMenu(cards.Select(c=>(c.Id.Entry,c.CurrentUpgradeLevel)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => HashMenu(cards.Select(c=>(c.Id.Entry,c.CurrentUpgradeLevel)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`cards.Select(c=>(c.Id.Entry,c.CurrentUpgradeLevel))`；返回值紧邻使用处：`ArgumentSyntax: cards.Select(c=>(c.Id.Entry,c.CurrentUpgradeLevel))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c1acb17c4015"></a>

## `NationalSpire.Solver.LeagueForecast.HashMenu(System.Collections.Generic.IEnumerable<(string Id, int Level)>) — private static int HashMenu(IEnumerable<(string Id,int Level)> cards)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.MenuKey(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>)`](LeagueForecast.Choices.cs.md#symbol-fae42c60aea3)；[`NationalSpire.Solver.LeagueForecast.ReadMenu(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotAction, in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, CombatSolver.HotKernel.HotChoiceSelection[], byte[], int, MegaCrit.Sts2.Core.Entities.Cards.PileType, CombatSolver.PlanChoiceEffect)`](LeagueForecast.Choices.cs.md#symbol-9ea1ee0600f1)

**调用：** `MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetNetIdForEntry(string)`

**字段、属性、事件及方法组引用：** `(string Id, int Level).Id`；`(string Id, int Level).Level`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetNetIdForEntry(string)`；输入表达式：`ModelIdSerializationCache.GetNetIdForEntry(card.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: hash*31+ModelIdSerializationCache.GetNetIdForEntry(card.Id)`

**赋值（含属性/字段和局部值）：**

- `hash` = `hash*31+card.Level`
- `hash` = `hash*31+ModelIdSerializationCache.GetNetIdForEntry(card.Id)`

<a id="symbol-a22d1c5371f2"></a>

## `NationalSpire.Solver.LeagueForecast.ExtendChoices(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotAction, in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotSearch.HotEvalLookup, CombatSolver.HotKernel.HotExecScratch, NationalSpire.Solver.LeagueForecast.SelectionPath, System.Collections.Generic.Stack<NationalSpire.Solver.LeagueForecast.SelectionPath>, int, int) — private static void ExtendChoices(in CombatHotState before,HotAction action,in CombatHotState state,HotColdSidecar? cold,HotRules rules,HotEvalLookup lookup,HotExecScratch scratch,          SelectionPath prior,Stack<SelectionPath> branches,int width,int incoming)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Expand(NationalSpire.Solver.LeagueForecast.Branch, System.Func<bool>)`](LeagueForecast.cs.md#symbol-24851435ee76)

**调用：** [`NationalSpire.Solver.LeagueForecast.ReadMenu(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotAction, in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, CombatSolver.HotKernel.HotChoiceSelection[], byte[], int, MegaCrit.Sts2.Core.Entities.Cards.PileType, CombatSolver.PlanChoiceEffect)`](LeagueForecast.Choices.cs.md#symbol-9ea1ee0600f1)；`CombatSolver.HotKernel.HotCombatEngine.EnumerateChoiceOptionsWithClasses(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, System.Span<CombatSolver.HotKernel.HotChoiceSelection>, System.Span<byte>)`；`CombatSolver.HotKernel.HotCombatEngine.GetPowerAmountById(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotRules, byte, CombatSolver.HotKernel.HotPowerId)`；`CombatSolver.HotSearch.HotPlanMaterializer.InferPlanChoiceEffect(ushort, CombatSolver.HotKernel.HotChoiceKind, CombatSolver.HotKernel.HotRules)`；`CombatSolver.HotSearch.HotPlanMaterializer.MapPileType(CombatSolver.HotKernel.HotChoiceKind)`；`CombatSolver.HotSearch.HotRolloutEvaluator.TryPickDeterministicGreedyChoice(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotSearch.HotCardRoleFlags[]?, CombatSolver.HotKernel.HotChoiceKind, ushort, byte, byte, int, bool, CombatSolver.HotKernel.HotChoiceSelection[], int, System.ReadOnlySpan<CombatSolver.HotKernel.HotChoiceSelection>, out CombatSolver.HotKernel.HotChoiceSelection)`；`NationalSpire.Solver.LeagueForecast.SelectionPath.SelectionPath(CombatSolver.HotKernel.HotChoiceSelection[], NationalSpire.Solver.LeagueForecast.SelectionMenu[])`；`System.Array.IndexOf<T>(T[], T, int, int)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.Stack<T>.Push(T)`；`System.Linq.Enumerable.Range(int, int)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.ReadMenu(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotAction, in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, CombatSolver.HotKernel.HotChoiceSelection[], byte[], int, MegaCrit.Sts2.Core.Entities.Cards.PileType, CombatSolver.PlanChoiceEffect)`；`NationalSpire.Solver.LeagueForecast.SelectionMenu.Cards`；`NationalSpire.Solver.LeagueForecast.SelectionMenu.Group`；`NationalSpire.Solver.LeagueForecast.SelectionMenu.Options`；`NationalSpire.Solver.LeagueForecast.SelectionMenu.Pile`；`NationalSpire.Solver.LeagueForecast.SelectionPath.Menus`；`NationalSpire.Solver.LeagueForecast.SelectionPath.Selections`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.HotKernel.HotCombatEngine.EnumerateChoiceOptionsWithClasses(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, System.Span<CombatSolver.HotKernel.HotChoiceSelection>, System.Span<byte>)`；输入表达式：`HotCombatEngine.EnumerateChoiceOptionsWithClasses(in state,cold,rules,scratch,options,copies)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HotCombatEngine.EnumerateChoiceOptionsWithClasses(in state,cold,rules,scratch,options,copies)`
- `CombatSolver.HotKernel.HotCombatEngine.GetPowerAmountById(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotRules, byte, CombatSolver.HotKernel.HotPowerId)`；输入表达式：`HotCombatEngine.GetPowerAmountById(in state,rules,0,HotPowerId.RetainHandPower)`；返回值紧邻使用处：`BinaryExpressionSyntax: HotCombatEngine.GetPowerAmountById(in state,rules,0,HotPowerId.RetainHandPower)>0`
- `CombatSolver.HotSearch.HotPlanMaterializer.InferPlanChoiceEffect(ushort, CombatSolver.HotKernel.HotChoiceKind, CombatSolver.HotKernel.HotRules)`；输入表达式：`HotPlanMaterializer.InferPlanChoiceEffect(scratch.PendingChoiceSourceCardDefId,kind,rules)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HotPlanMaterializer.InferPlanChoiceEffect(scratch.PendingChoiceSourceCardDefId,kind,rules)`
- `CombatSolver.HotSearch.HotPlanMaterializer.MapPileType(CombatSolver.HotKernel.HotChoiceKind)`；输入表达式：`HotPlanMaterializer.MapPileType(kind)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HotPlanMaterializer.MapPileType(kind)`
- `CombatSolver.HotSearch.HotRolloutEvaluator.TryPickDeterministicGreedyChoice(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotSearch.HotCardRoleFlags[]?, CombatSolver.HotKernel.HotChoiceKind, ushort, byte, byte, int, bool, CombatSolver.HotKernel.HotChoiceSelection[], int, System.ReadOnlySpan<CombatSolver.HotKernel.HotChoiceSelection>, out CombatSolver.HotKernel.HotChoiceSelection)`；输入表达式：`HotRolloutEvaluator.TryPickDeterministicGreedyChoice(in state,cold,rules,lookup.CardRoles,kind,              scratch.PendingChoiceSourceCardDefId,scratch.PendingChoiceMin,scratch.PendingChoiceMax,              Math.Max(0,incoming-state.Player.Block),retain,options,count,prior.Selections,out var preferred)`；返回值紧邻使用处：`IfStatementSyntax: if(HotRolloutEvaluator.TryPickDeterministicGreedyChoice(in state,cold,rules,lookup.CardRoles,kind,              scratch.PendingChoiceSourceCardDefId,scratch.PendingChoiceMin,scratch.PendingChoiceMax,              Math.Max(0,incoming-state.Player.Block),retain,options,count,prior.Selections,out var preferred))              recommended=Array.IndexOf(options,preferred,0,count);`
- `NationalSpire.Solver.LeagueForecast.ReadMenu(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotAction, in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, CombatSolver.HotKernel.HotChoiceSelection[], byte[], int, MegaCrit.Sts2.Core.Entities.Cards.PileType, CombatSolver.PlanChoiceEffect)`；输入表达式：`ReadMenu(in before,action,in state,cold,rules,scratch,options,copies,count,pile,effect)`；返回值紧邻使用处：`ConditionalExpressionSyntax: merge?previous!:ReadMenu(in before,action,in state,cold,rules,scratch,options,copies,count,pile,effect)`
- `NationalSpire.Solver.LeagueForecast.SelectionPath.SelectionPath(CombatSolver.HotKernel.HotChoiceSelection[], NationalSpire.Solver.LeagueForecast.SelectionMenu[])`；输入表达式：`new([..prior.Selections,options[i]],menus)`；返回值紧邻使用处：`ArgumentSyntax: new([..prior.Selections,options[i]],menus)`
- `System.Array.IndexOf<T>(T[], T, int, int)`；输入表达式：`Array.IndexOf(options,preferred,0,count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: recommended=Array.IndexOf(options,preferred,0,count)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`menu.Options.TryGetValue(options[i].CardUidOrIndex,out var token)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !menu.Options.TryGetValue(options[i].CardUidOrIndex,out var token)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`prior.Menus.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =prior.Menus.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Enumerable.Range(0,count).OrderByDescending(i=>i==recommended)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,count).OrderByDescending(i=>i==recommended)              .ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`Enumerable.Range(0,count).OrderByDescending(i=>i==recommended)              .ThenByDescending(i=>options[i].Kind==HotChoiceKind.None).Take(width).Reverse()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Enumerable.Range(0,count).OrderByDescending(i=>i==recommended)              .ThenByDescending(i=>options[i].Kind==HotChoiceKind.None).Take(width).Reverse()`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`Enumerable.Range(0,count).OrderByDescending(i=>i==recommended)              .ThenByDescending(i=>options[i].Kind==HotChoiceKind.None).Take(width)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,count).OrderByDescending(i=>i==recommended)              .ThenByDescending(i=>options[i].Kind==HotChoiceKind.None).Take(width).Reverse`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`menu.Cards.Add(token)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.Cards.Add(token);`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`branches.Push(new([..prior.Selections,options[i]],menus))`；返回值紧邻使用处：`ExpressionStatementSyntax: branches.Push(new([..prior.Selections,options[i]],menus));`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0,count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,count).OrderByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Enumerable.Range(0,count).OrderByDescending(i=>i==recommended)              .ThenByDescending(i=>options[i].Kind==HotChoiceKind.None)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,count).OrderByDescending(i=>i==recommended)              .ThenByDescending(i=>options[i].Kind==HotChoiceKind.None).Take`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,incoming-state.Player.Block)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,incoming-state.Player.Block)`

**赋值（含属性/字段和局部值）：**

- `Cards` = `[..source.Cards]`
- `recommended` = `Array.IndexOf(options,preferred,0,count)`

<a id="symbol-9ea1ee0600f1"></a>

## `NationalSpire.Solver.LeagueForecast.ReadMenu(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotAction, in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, CombatSolver.HotKernel.HotChoiceSelection[], byte[], int, MegaCrit.Sts2.Core.Entities.Cards.PileType, CombatSolver.PlanChoiceEffect) — private static SelectionMenu ReadMenu(in CombatHotState before,HotAction action,in CombatHotState state,HotColdSidecar? cold,          HotRules rules,HotExecScratch scratch,HotChoiceSelection[] options,byte[] copies,int count,PileType pile,PlanChoiceEffect effect)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.ExtendChoices(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotAction, in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotSearch.HotEvalLookup, CombatSolver.HotKernel.HotExecScratch, NationalSpire.Solver.LeagueForecast.SelectionPath, System.Collections.Generic.Stack<NationalSpire.Solver.LeagueForecast.SelectionPath>, int, int)`](LeagueForecast.Choices.cs.md#symbol-a22d1c5371f2)

**调用：** [`Add(ushort, string, int)`](LeagueForecast.Choices.cs.md#symbol-43656af2c8c9)；[`NationalSpire.Solver.LeagueForecast.HashMenu(System.Collections.Generic.IEnumerable<(string Id, int Level)>)`](LeagueForecast.Choices.cs.md#symbol-c1acb17c4015)；`CombatSolver.HotKernel.HotCombatEngine.AreChoiceEquivalentCards(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotPileKind, int, int, in CombatSolver.HotKernel.HotCard, in CombatSolver.HotKernel.HotCard, CombatSolver.HotKernel.HotColdSidecar?)`；`CombatSolver.HotKernel.HotCombatEngine.FindCardIndexByUid(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotPileKind, ushort)`；`CombatSolver.HotKernel.HotCombatEngine.GetPendingExcludedChoiceUids()`；`CombatSolver.HotKernel.HotCombatEngine.GetPendingFilteredChoiceUids()`；`CombatSolver.HotKernel.HotCombatEngine.GetPendingGeneratedChoiceOptions()`；`CombatSolver.HotKernel.HotCombatEngine.MatchesChoiceFilter(in CombatSolver.HotKernel.CombatHotState, in CombatSolver.HotKernel.HotCard, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotCustomCardId)`；`CombatSolver.HotKernel.HotPiles.ZoneCount(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotPileKind)`；`CombatSolver.HotKernel.HotPiles.ZoneStart(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotPileKind)`；`CombatSolver.HotSearch.HotPlanMaterializer.MapHotPileKind(CombatSolver.HotKernel.HotChoiceKind)`；`CombatSolver.HotSearch.HotPlanMaterializer.ShouldUpgradeGeneratedChoiceOptions(in CombatSolver.HotKernel.CombatHotState, in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotAction, ushort)`；`NationalSpire.Solver.LeagueForecast.SelectionMenu.SelectionMenu(ushort, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, CombatSolver.PlanChoiceEffect, System.Collections.Generic.Dictionary<ushort, (string Id, int Level, int Occurrence)>, System.Collections.Generic.List<(string Id, int Level, int Occurrence)>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.List<T>.List()`；`System.ReadOnlySpan<T>.Contains<T>(T)`

**字段、属性、事件及方法组引用：** `Add(ushort, string, int)`；`NationalSpire.Solver.LeagueForecast.HashMenu(System.Collections.Generic.IEnumerable<(string Id, int Level)>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(ushort, string, int)`；输入表达式：`Add((ushort)i,def.Entry,upgrade && def.MaxUpgradeLevel>0?1:0)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add((ushort)i,def.Entry,upgrade && def.MaxUpgradeLevel>0?1:0);`
- `Add(ushort, string, int)`；输入表达式：`Add(card.CardUid,rules.Cards[card.CardDefId].Entry,card.UpgradeLevel)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(card.CardUid,rules.Cards[card.CardDefId].Entry,card.UpgradeLevel);`
- `CombatSolver.HotKernel.HotCombatEngine.AreChoiceEquivalentCards(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotPileKind, int, int, in CombatSolver.HotKernel.HotCard, in CombatSolver.HotKernel.HotCard, CombatSolver.HotKernel.HotColdSidecar?)`；输入表达式：`HotCombatEngine.AreChoiceEquivalentCards(in state,zone,idx-start,offset,in state.Cards[idx],in card,cold)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !HotCombatEngine.AreChoiceEquivalentCards(in state,zone,idx-start,offset,in state.Cards[idx],in card,cold)`
- `CombatSolver.HotKernel.HotCombatEngine.FindCardIndexByUid(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotPileKind, ushort)`；输入表达式：`HotCombatEngine.FindCardIndexByUid(in state,zone,options[i].CardUidOrIndex)`；返回值紧邻使用处：`ConditionalExpressionSyntax: options[i].Kind==HotChoiceKind.None?-1:HotCombatEngine.FindCardIndexByUid(in state,zone,options[i].CardUidOrIndex)`
- `CombatSolver.HotKernel.HotCombatEngine.GetPendingExcludedChoiceUids()`；输入表达式：`HotCombatEngine.GetPendingExcludedChoiceUids()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HotCombatEngine.GetPendingExcludedChoiceUids()`
- `CombatSolver.HotKernel.HotCombatEngine.GetPendingFilteredChoiceUids()`；输入表达式：`HotCombatEngine.GetPendingFilteredChoiceUids()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HotCombatEngine.GetPendingFilteredChoiceUids()`
- `CombatSolver.HotKernel.HotCombatEngine.GetPendingGeneratedChoiceOptions()`；输入表达式：`HotCombatEngine.GetPendingGeneratedChoiceOptions()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HotCombatEngine.GetPendingGeneratedChoiceOptions()`
- `CombatSolver.HotKernel.HotCombatEngine.MatchesChoiceFilter(in CombatSolver.HotKernel.CombatHotState, in CombatSolver.HotKernel.HotCard, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotCustomCardId)`；输入表达式：`HotCombatEngine.MatchesChoiceFilter(in state,in card,rules,filter)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !HotCombatEngine.MatchesChoiceFilter(in state,in card,rules,filter)`
- `CombatSolver.HotKernel.HotPiles.ZoneCount(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotPileKind)`；输入表达式：`HotPiles.ZoneCount(in state,zone)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HotPiles.ZoneCount(in state,zone)`
- `CombatSolver.HotKernel.HotPiles.ZoneStart(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotPileKind)`；输入表达式：`HotPiles.ZoneStart(in state,zone)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HotPiles.ZoneStart(in state,zone)`
- `CombatSolver.HotSearch.HotPlanMaterializer.MapHotPileKind(CombatSolver.HotKernel.HotChoiceKind)`；输入表达式：`HotPlanMaterializer.MapHotPileKind(kind)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HotPlanMaterializer.MapHotPileKind(kind)`
- `CombatSolver.HotSearch.HotPlanMaterializer.ShouldUpgradeGeneratedChoiceOptions(in CombatSolver.HotKernel.CombatHotState, in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotAction, ushort)`；输入表达式：`HotPlanMaterializer.ShouldUpgradeGeneratedChoiceOptions(in before,in state,rules,action,source)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HotPlanMaterializer.ShouldUpgradeGeneratedChoiceOptions(in before,in state,rules,action,source)`
- `NationalSpire.Solver.LeagueForecast.HashMenu(System.Collections.Generic.IEnumerable<(string Id, int Level)>)`；输入表达式：`HashMenu(cards)`；返回值紧邻使用处：`ArgumentSyntax: HashMenu(cards)`
- `NationalSpire.Solver.LeagueForecast.SelectionMenu.SelectionMenu(ushort, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, CombatSolver.PlanChoiceEffect, System.Collections.Generic.Dictionary<ushort, (string Id, int Level, int Occurrence)>, System.Collections.Generic.List<(string Id, int Level, int Occurrence)>)`；输入表达式：`new(scratch.PendingChoiceGroupSeq,pile,HashMenu(cards),effect,byUid,[])`；返回值紧邻使用处：`ReturnStatementSyntax: return new(scratch.PendingChoiceGroupSeq,pile,HashMenu(cards),effect,byUid,[]);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<(string,int),int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<(string,int),int>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<ushort,(string Id,int Level,int Occurrence)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<ushort,(string Id,int Level,int Occurrence)>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Id,int Level)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<(string Id,int Level)>()`
- `System.ReadOnlySpan<T>.Contains<T>(T)`；输入表达式：`excluded.Contains(card.CardUid)`；返回值紧邻使用处：`BinaryExpressionSyntax: (!selected.IsEmpty && !selected.Contains(card.CardUid)) || excluded.Contains(card.CardUid)`
- `System.ReadOnlySpan<T>.Contains<T>(T)`；输入表达式：`selected.Contains(card.CardUid)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !selected.Contains(card.CardUid)`

**赋值（含属性/字段和局部值）：**

- `indices[i]` = `options[i].Kind==HotChoiceKind.None?-1:HotCombatEngine.FindCardIndexByUid(in state,zone,options[i].CardUidOrIndex)`

<a id="symbol-43656af2c8c9"></a>

## `Add(ushort, string, int) — void Add(ushort uid,string id,int level)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.ReadMenu(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotAction, in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, CombatSolver.HotKernel.HotChoiceSelection[], byte[], int, MegaCrit.Sts2.Core.Entities.Cards.PileType, CombatSolver.PlanChoiceEffect)`](LeagueForecast.Choices.cs.md#symbol-9ea1ee0600f1)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`byUid.Add(uid,(id,level,occurrence))`；返回值紧邻使用处：`ExpressionStatementSyntax: byUid.Add(uid,(id,level,occurrence));`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`seen.GetValueOrDefault(key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =seen.GetValueOrDefault(key)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`cards.Add(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: cards.Add(key);`

**赋值（含属性/字段和局部值）：**

- `seen[key]` = `occurrence+1`

<a id="symbol-b547a4c82a32"></a>

## `NationalSpire.Solver.LeagueForecast.Wire(NationalSpire.Solver.LeagueForecast.SelectionPath) — private static int[] Wire(SelectionPath path)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Expand(NationalSpire.Solver.LeagueForecast.Branch, System.Func<bool>)`](LeagueForecast.cs.md#symbol-24851435ee76)

**调用：** `MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetNetIdForEntry(string)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.SelectionMenu.Cards`；`NationalSpire.Solver.LeagueForecast.SelectionMenu.Effect`；`NationalSpire.Solver.LeagueForecast.SelectionMenu.Hash`；`NationalSpire.Solver.LeagueForecast.SelectionMenu.Pile`；`NationalSpire.Solver.LeagueForecast.SelectionPath.Menus`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetNetIdForEntry(string)`；输入表达式：`ModelIdSerializationCache.GetNetIdForEntry(id)`；返回值紧邻使用处：`ExpressionElementSyntax: ModelIdSerializationCache.GetNetIdForEntry(id)`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`result.AddRange([(int)menu.Pile,menu.Hash,(int)menu.Effect,menu.Cards.Count])`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AddRange([(int)menu.Pile,menu.Hash,(int)menu.Effect,menu.Cards.Count]);`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`result.AddRange([ModelIdSerializationCache.GetNetIdForEntry(id),level,occurrence])`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AddRange([ModelIdSerializationCache.GetNetIdForEntry(id),level,occurrence]);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<int>()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`result.ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return result.ToArray();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-621299823e37"></a>

## `NationalSpire.Solver.LeagueForecast.SelectActual(MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, int, int) — public static int[] SelectActual(CardModel[] cards,int pile,string purpose,int effect,int min,int max)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Solver.LeagueForecast.Capture(bool)`](LeagueForecast.Projection.cs.md#symbol-1c0fdc3118f7)；[`NationalSpire.Solver.LeagueForecast.OriginalCards(in CombatSolver.HotKernel.CombatHotState)`](LeagueForecast.Projection.cs.md#symbol-22dc42205291)；`CombatSolver.HotKernel.HotChoiceSelection.HotChoiceSelection(CombatSolver.HotKernel.HotChoiceKind, ushort, ushort)`；`CombatSolver.HotKernel.HotCombatEngine.GetPowerAmountById(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotRules, byte, CombatSolver.HotKernel.HotPowerId)`；`CombatSolver.HotSearch.HotEvalLookup.HotEvalLookup(CombatSolver.HotKernel.HotRules)`；`CombatSolver.HotSearch.HotRolloutEvaluator.ComputeGenericChoiceCardQuality(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotSearch.HotCardRoleFlags[]?, CombatSolver.HotKernel.HotChoiceSelection, int, int, bool, bool)`；`NationalSpire.Solver.LeagueForecast.LeagueForecast(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], System.Func<int, int>, int, System.Threading.CancellationToken)`；`System.Array.FindIndex<T>(T[], System.Predicate<T>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `(int Index, int Value).Index`；`(int Index, int Value).Value`；`NationalSpire.Solver.LeagueForecast.Capture(bool)`；`NationalSpire.Solver.LeagueForecast.OriginalCards(in CombatSolver.HotKernel.CombatHotState)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.HotKernel.HotChoiceSelection.HotChoiceSelection(CombatSolver.HotKernel.HotChoiceKind, ushort, ushort)`；输入表达式：`new(kind,originalIds.GetValueOrDefault(cards[i],ushort.MaxValue),(ushort)def)`；返回值紧邻使用处：`ArgumentSyntax: new(kind,originalIds.GetValueOrDefault(cards[i],ushort.MaxValue),(ushort)def)`
- `CombatSolver.HotKernel.HotCombatEngine.GetPowerAmountById(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotRules, byte, CombatSolver.HotKernel.HotPowerId)`；输入表达式：`HotCombatEngine.GetPowerAmountById(in state,bundle.Rules,0,HotPowerId.RetainHandPower)`；返回值紧邻使用处：`BinaryExpressionSyntax: HotCombatEngine.GetPowerAmountById(in state,bundle.Rules,0,HotPowerId.RetainHandPower)>0`
- `CombatSolver.HotSearch.HotEvalLookup.HotEvalLookup(CombatSolver.HotKernel.HotRules)`；输入表达式：`new HotEvalLookup(bundle.Rules)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HotEvalLookup(bundle.Rules)`
- `CombatSolver.HotSearch.HotRolloutEvaluator.ComputeGenericChoiceCardQuality(in CombatSolver.HotKernel.CombatHotState, CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotSearch.HotCardRoleFlags[]?, CombatSolver.HotKernel.HotChoiceSelection, int, int, bool, bool)`；输入表达式：`HotRolloutEvaluator.ComputeGenericChoiceCardQuality(in state,bundle.RootCold,bundle.Rules,lookup.CardRoles,                  new(kind,originalIds.GetValueOrDefault(cards[i],ushort.MaxValue),(ushort)def),0,state.Energy,upgrade,                  HotCombatEngine.GetPowerAmountById(in state,bundle.Rules,0,HotPowerId.RetainHandPower)>0)`；返回值紧邻使用处：`ConditionalExpressionSyntax: def<=0?0:HotRolloutEvaluator.ComputeGenericChoiceCardQuality(in state,bundle.RootCold,bundle.Rules,lookup.CardRoles,                  new(kind,originalIds.GetValueOrDefault(cards[i],ushort.MaxValue),(ushort)def),0,state.Energy,upgrade,                  HotCombatEngine.GetPowerAmountById(in state,bundle.Rules,0,HotPowerId.RetainHandPower)>0)`
- `NationalSpire.Solver.LeagueForecast.Capture(bool)`；输入表达式：`projection.Capture(false)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: projection.Capture(false).HotRoot`
- `NationalSpire.Solver.LeagueForecast.LeagueForecast(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], System.Func<int, int>, int, System.Threading.CancellationToken)`；输入表达式：`new LeagueForecast(owner,0,[],v=>v,-1,default)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueForecast(owner,0,[],v=>v,-1,default)`
- `NationalSpire.Solver.LeagueForecast.OriginalCards(in CombatSolver.HotKernel.CombatHotState)`；输入表达式：`projection.OriginalCards(in state)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: projection.OriginalCards(in state).ToDictionary`
- `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；输入表达式：`Array.FindIndex(defs,d=>d?.Entry==cards[i].Id.Entry)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Array.FindIndex(defs,d=>d?.Entry==cards[i].Id.Entry)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`cards.Select(c=>c.Owner).FirstOrDefault(p=>p?.Creature.CombatState!=null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =cards.Select(c=>c.Owner).FirstOrDefault(p=>p?.Creature.CombatState!=null)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ranked.OrderBy(x=>x.Value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: drop?ranked.OrderBy(x=>x.Value):ranked.OrderByDescending(x=>x.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ranked.OrderByDescending(x=>x.Value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: drop?ranked.OrderBy(x=>x.Value):ranked.OrderByDescending(x=>x.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`cards.Select(c=>c.Owner)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.Select(c=>c.Owner).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ordered.Take(Math.Min(drop?min:max,cards.Length)).Select(x=>x.Index)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ordered.Take(Math.Min(drop?min:max,cards.Length)).Select(x=>x.Index).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`ordered.Take(Math.Min(drop?min:max,cards.Length))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ordered.Take(Math.Min(drop?min:max,cards.Length)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0,Math.Min(min,cards.Length)).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return Enumerable.Range(0,Math.Min(min,cards.Length)).ToArray();`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`ordered.Take(Math.Min(drop?min:max,cards.Length)).Select(x=>x.Index).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return ordered.Take(Math.Min(drop?min:max,cards.Length)).Select(x=>x.Index).ToArray();`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`projection.OriginalCards(in state).ToDictionary(pair=>pair.Value,pair=>pair.Key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =projection.OriginalCards(in state).ToDictionary(pair=>pair.Value,pair=>pair.Key)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`originalIds.GetValueOrDefault(cards[i],ushort.MaxValue)`；返回值紧邻使用处：`ArgumentSyntax: originalIds.GetValueOrDefault(cards[i],ushort.MaxValue)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`ranked.Add((i,value))`；返回值紧邻使用处：`ExpressionStatementSyntax: ranked.Add((i,value));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(int Index,int Value)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<(int Index,int Value)>()`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0,Math.Min(min,cards.Length))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,Math.Min(min,cards.Length)).ToArray`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(drop?min:max,cards.Length)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(drop?min:max,cards.Length)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(min,cards.Length)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(min,cards.Length)`

**赋值（含属性/字段和局部值）：**
