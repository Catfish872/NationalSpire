# Compatibility/LeagueSolver/LeagueForecast.DuelRules.cs

[返回文件依赖索引](../../../SOURCE_MAP.md)

源码 SHA-256：`8A8B9001F02E2DAC0F61EDE92CA72B30203B82F44E833B4210CB6B0AB70EAA20`。来源：[源码](../../../../Compatibility/LeagueSolver/LeagueForecast.DuelRules.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Solver.LeagueForecast`、`NationalSpire.Solver.LeagueForecast.PlannedHit`、`NationalSpire.Solver.LeagueForecast.IntentLedger`。

字段、事件及初始值（源码原样）：

```csharp
internal readonly List<PlannedHit> Moves = [];
internal readonly Func<int, int> ScaleDoom = scaleDoom;
[ThreadStatic] private static IntentLedger? _outgoing;
[ThreadStatic] private static Player? _historyPlayer;
[ThreadStatic] private static bool _poison;
private static readonly HashSet<CardKeyword> GameKeywords = typeof(CardKeyword).GetFields()
        .Where(field => field.IsLiteral).Select(field => (CardKeyword)field.GetValue(null)!).ToHashSet();
[ThreadStatic] private static byte? _delivery;
[ThreadStatic] private static bool _capped;
private static readonly HashSet<HotPowerId> OwnPowers = OwnTurnEffects<HotPowerId>();
private static readonly HashSet<HotRelicId> OwnRelics = OwnTurnEffects<HotRelicId>();
```

<a id="symbol-2e7418156564"></a>

## `NationalSpire.Solver.LeagueForecast.IntentLedger.Fork() — internal IntentLedger Fork()`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Evaluate(NationalSpire.Solver.LeagueForecast.Branch, out bool)`](LeagueForecast.cs.md#symbol-cee91d662755)；[`NationalSpire.Solver.LeagueForecast.TryStep(ref CombatSolver.HotKernel.CombatHotState, ref CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, CombatSolver.HotKernel.HotAction, System.ReadOnlySpan<CombatSolver.HotKernel.HotChoiceSelection>, NationalSpire.Solver.LeagueForecast.IntentLedger, out NationalSpire.Solver.LeagueForecast.IntentLedger)`](LeagueForecast.DuelRules.cs.md#symbol-183c973443ee)

**调用：** `NationalSpire.Solver.LeagueForecast.IntentLedger.IntentLedger(System.Func<int, int>)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.IntentLedger.Moves`；`NationalSpire.Solver.LeagueForecast.IntentLedger.ScaleDoom`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Solver.LeagueForecast.IntentLedger.IntentLedger(System.Func<int, int>)`；输入表达式：`new IntentLedger(ScaleDoom)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new IntentLedger(ScaleDoom)`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`child.Moves.AddRange(Moves)`；返回值紧邻使用处：`ExpressionStatementSyntax: child.Moves.AddRange(Moves);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-64d43e425e59"></a>

## `NationalSpire.Solver.LeagueForecast.InstallDuelHooks() — private static void InstallDuelHooks()`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Prepare()`](LeagueForecast.Projection.cs.md#symbol-f2559c94c021)

**调用：** [`Patch(System.Type, string, string)`](LeagueForecast.DuelRules.cs.md#symbol-184475bc40cc)；`HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.Harmony.Harmony(string)`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`

**字段、属性、事件及方法组引用：** `Patch(System.Type, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(HotCombatEngine),nameof(HotCombatEngine.TriggerPoison))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(HotCombatEngine),nameof(HotCombatEngine.TriggerPoison))`
- `HarmonyLib.Harmony.Harmony(string)`；输入表达式：`new Harmony("nationalspire.league.forecast")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Harmony("nationalspire.league.forecast")`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(HotCombatEngine),nameof(HotCombatEngine.TriggerPoison)),             prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(StartPoison)),             finalizer:new HarmonyMethod(typeof(LeagueForecast),nameof(FinishPoison)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(HotCombatEngine),nameof(HotCombatEngine.TriggerPoison)),             prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(StartPoison)),             finalizer:new HarmonyMethod(typeof(LeagueForecast),nameof(FinishPoison)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(FinishPoison))`；返回值紧邻使用处：`ArgumentSyntax: finalizer:new HarmonyMethod(typeof(LeagueForecast),nameof(FinishPoison))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(StartPoison))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(StartPoison))`
- `Patch(System.Type, string, string)`；输入表达式：`Patch(typeof(HotCombatEngine), nameof(HotCombatEngine.ApplyPowerCore), nameof(DeclareDoom))`；返回值紧邻使用处：`ExpressionStatementSyntax: Patch(typeof(HotCombatEngine), nameof(HotCombatEngine.ApplyPowerCore), nameof(DeclareDoom));`
- `Patch(System.Type, string, string)`；输入表达式：`Patch(typeof(HotCombatEngine), nameof(HotCombatEngine.DealDamageInternal), nameof(DeclareAttack))`；返回值紧邻使用处：`ExpressionStatementSyntax: Patch(typeof(HotCombatEngine), nameof(HotCombatEngine.DealDamageInternal), nameof(DeclareAttack));`
- `Patch(System.Type, string, string)`；输入表达式：`Patch(typeof(HotCombatEngine), nameof(HotCombatEngine.DispatchCorePowerHook), nameof(ApplyDuelPower))`；返回值紧邻使用处：`ExpressionStatementSyntax: Patch(typeof(HotCombatEngine), nameof(HotCombatEngine.DispatchCorePowerHook), nameof(ApplyDuelPower));`
- `Patch(System.Type, string, string)`；输入表达式：`Patch(typeof(HotKeywords), nameof(HotKeywords.FromEnumerable), nameof(ProjectKeywords))`；返回值紧邻使用处：`ExpressionStatementSyntax: Patch(typeof(HotKeywords), nameof(HotKeywords.FromEnumerable), nameof(ProjectKeywords));`
- `Patch(System.Type, string, string)`；输入表达式：`Patch(typeof(HotRelics), nameof(HotRelics.HandleAfterDamageReceived), nameof(OwnTurnRelic))`；返回值紧邻使用处：`ExpressionStatementSyntax: Patch(typeof(HotRelics), nameof(HotRelics.HandleAfterDamageReceived), nameof(OwnTurnRelic));`
- `Patch(System.Type, string, string)`；输入表达式：`Patch(typeof(HotRootBuilder), nameof(HotRootBuilder.CaptureLiveHistoryAndMelodies), nameof(ReadOpponentHistory))`；返回值紧邻使用处：`ExpressionStatementSyntax: Patch(typeof(HotRootBuilder), nameof(HotRootBuilder.CaptureLiveHistoryAndMelodies), nameof(ReadOpponentHistory));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-184475bc40cc"></a>

## `Patch(System.Type, string, string) — void Patch(Type type, string method, string prefix)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.InstallDuelHooks()`](LeagueForecast.DuelRules.cs.md#symbol-64d43e425e59)

**调用：** `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(type, method)`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(type, method)`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(type, method),                 prefix: new HarmonyMethod(typeof(LeagueForecast), prefix))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>             h.Patch(AccessTools.DeclaredMethod(type, method),                 prefix: new HarmonyMethod(typeof(LeagueForecast), prefix))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast), prefix)`；返回值紧邻使用处：`ArgumentSyntax: prefix: new HarmonyMethod(typeof(LeagueForecast), prefix)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-38dec9f4f9c1"></a>

## `NationalSpire.Solver.LeagueForecast.ProjectKeywords(ref System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword>?) — private static void ProjectKeywords(ref IEnumerable<CardKeyword>? __0)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.GameKeywords`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`__0.Where(GameKeywords.Contains)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __0 = __0.Where(GameKeywords.Contains)`

**赋值（含属性/字段和局部值）：**

- `__0` = `__0.Where(GameKeywords.Contains)`

<a id="symbol-1a3ee84633e5"></a>

## `NationalSpire.Solver.LeagueForecast.ReadOpponentHistory(ref MegaCrit.Sts2.Core.Combat.CombatState, ref MegaCrit.Sts2.Core.Entities.Players.Player) — private static void ReadOpponentHistory(ref CombatState __0, ref Player __1)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._historyPlayer`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `__0` = `(CombatState)opponent.Creature.CombatState!`
- `__1` = `opponent`

<a id="symbol-183c973443ee"></a>

## `NationalSpire.Solver.LeagueForecast.TryStep(ref CombatSolver.HotKernel.CombatHotState, ref CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, CombatSolver.HotKernel.HotAction, System.ReadOnlySpan<CombatSolver.HotKernel.HotChoiceSelection>, NationalSpire.Solver.LeagueForecast.IntentLedger, out NationalSpire.Solver.LeagueForecast.IntentLedger) — private static HotStepResult TryStep(ref CombatHotState state, ref HotColdSidecar? cold, HotRules rules,         HotExecScratch scratch, HotAction action, ReadOnlySpan<HotChoiceSelection> choices,         IntentLedger parent, out IntentLedger child)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Expand(NationalSpire.Solver.LeagueForecast.Branch, System.Func<bool>)`](LeagueForecast.cs.md#symbol-24851435ee76)

**调用：** [`NationalSpire.Solver.LeagueForecast.IntentLedger.Fork()`](LeagueForecast.DuelRules.cs.md#symbol-2e7418156564)；`CombatSolver.HotKernel.HotCombatEngine.Step(ref CombatSolver.HotKernel.CombatHotState, ref CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, CombatSolver.HotKernel.HotAction, System.ReadOnlySpan<CombatSolver.HotKernel.HotChoiceSelection>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._outgoing`；`NationalSpire.Solver.LeagueForecast.IntentLedger.Fork()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.HotKernel.HotCombatEngine.Step(ref CombatSolver.HotKernel.CombatHotState, ref CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, CombatSolver.HotKernel.HotAction, System.ReadOnlySpan<CombatSolver.HotKernel.HotChoiceSelection>)`；输入表达式：`HotCombatEngine.Step(ref state, ref cold, rules, scratch, action, choices)`；返回值紧邻使用处：`ReturnStatementSyntax: return HotCombatEngine.Step(ref state, ref cold, rules, scratch, action, choices);`
- `NationalSpire.Solver.LeagueForecast.IntentLedger.Fork()`；输入表达式：`parent.Fork()`；返回值紧邻使用处：`AssignmentExpressionSyntax: child = parent.Fork()`

**赋值（含属性/字段和局部值）：**

- `_outgoing` = `child = parent.Fork()`
- `_outgoing` = `previous`
- `child` = `parent.Fork()`

<a id="symbol-2e10c1dd3b88"></a>

## `NationalSpire.Solver.LeagueForecast.OwnTurnEffects<T>() — private static HashSet<T> OwnTurnEffects<T>() where T: struct,Enum`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Enum.GetValues<TEnum>()`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueOwnTurnLoss.Effects`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`LeagueOwnTurnLoss.Effects.Any(effect=>effect.Name==id.ToString())`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id=>LeagueOwnTurnLoss.Effects.Any(effect=>effect.Name==id.ToString())`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`Enum.GetValues<T>().Where(id=>LeagueOwnTurnLoss.Effects.Any(effect=>effect.Name==id.ToString())).ToHashSet()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>         Enum.GetValues<T>().Where(id=>LeagueOwnTurnLoss.Effects.Any(effect=>effect.Name==id.ToString())).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Enum.GetValues<T>().Where(id=>LeagueOwnTurnLoss.Effects.Any(effect=>effect.Name==id.ToString()))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enum.GetValues<T>().Where(id=>LeagueOwnTurnLoss.Effects.Any(effect=>effect.Name==id.ToString())).ToHashSet`
- `System.Enum.GetValues<TEnum>()`；输入表达式：`Enum.GetValues<T>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enum.GetValues<T>().Where`
- `System.Enum.ToString()`；输入表达式：`id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: effect.Name==id.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9890f21c1dc3"></a>

## `NationalSpire.Solver.LeagueForecast.StartPoison(out bool) — private static void StartPoison(out bool __state)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._poison`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `__state` = `_poison`
- `_poison` = `true`

<a id="symbol-5ddc93a28dec"></a>

## `NationalSpire.Solver.LeagueForecast.FinishPoison(bool) — private static void FinishPoison(bool __state)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._poison`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_poison` = `__state`

<a id="symbol-6e33e64a8b81"></a>

## `NationalSpire.Solver.LeagueForecast.ApplyDuelPower(CombatSolver.HotKernel.HotHookMask, CombatSolver.HotKernel.HotPowerId, ref CombatSolver.HotKernel.HotHookArgs) — private static bool ApplyDuelPower([HarmonyArgument(4)]HotHookMask hook,[HarmonyArgument(6)]HotPowerId powerId,[HarmonyArgument(7)]ref HotHookArgs args)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._capped`；`NationalSpire.Solver.LeagueForecast._delivery`；`NationalSpire.Solver.LeagueForecast._outgoing`；`NationalSpire.Solver.LeagueForecast.OwnPowers`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`OwnPowers.Contains(powerId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnPowers.Contains(powerId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ed37189f1943"></a>

## `NationalSpire.Solver.LeagueForecast.OwnTurnRelic(CombatSolver.HotKernel.HotRelicId, ref CombatSolver.HotKernel.HotHookArgs) — private static bool OwnTurnRelic([HarmonyArgument(4)]HotRelicId relicId,[HarmonyArgument(7)]ref HotHookArgs args)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._delivery`；`NationalSpire.Solver.LeagueForecast.OwnRelics`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`OwnRelics.Contains(relicId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnRelics.Contains(relicId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0a97df9d01dc"></a>

## `NationalSpire.Solver.LeagueForecast.Deliver(ref CombatSolver.HotKernel.CombatHotState, ref CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, byte, decimal, bool, bool, bool) — private static void Deliver(ref CombatHotState state,ref HotColdSidecar? cold,HotRules rules,HotExecScratch scratch,         byte dealer,decimal amount,bool powered,bool unblockable,bool capped)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Evaluate(NationalSpire.Solver.LeagueForecast.Branch, out bool)`](LeagueForecast.cs.md#symbol-cee91d662755)

**调用：** `CombatSolver.HotKernel.HotCombatEngine.DealDamageInternal(ref CombatSolver.HotKernel.CombatHotState, ref CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, byte, byte, int, bool, bool, int, ushort, bool, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._capped`；`NationalSpire.Solver.LeagueForecast._delivery`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.HotKernel.HotCombatEngine.DealDamageInternal(ref CombatSolver.HotKernel.CombatHotState, ref CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, byte, byte, int, bool, bool, int, ushort, bool, bool)`；输入表达式：`HotCombatEngine.DealDamageInternal(ref state,ref cold,rules,scratch,dealer,0,(int)amount,powered,unblockable,-1,0,capOnlyModifiers:true)`；返回值紧邻使用处：`ExpressionStatementSyntax: HotCombatEngine.DealDamageInternal(ref state,ref cold,rules,scratch,dealer,0,(int)amount,powered,unblockable,-1,0,capOnlyModifiers:true);`

**赋值（含属性/字段和局部值）：**

- `_capped` = `capped`
- `_capped` = `false`
- `_delivery` = `dealer`
- `_delivery` = `null`

<a id="symbol-e62f58f780ee"></a>

## `NationalSpire.Solver.LeagueForecast.DeclareAttack(ref CombatSolver.HotKernel.CombatHotState, ref CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, byte, byte, int, bool, bool, int, ushort, bool, ref int) — private static bool DeclareAttack([HarmonyArgument(0)]ref CombatHotState s, [HarmonyArgument(1)]ref HotColdSidecar? cold,         [HarmonyArgument(2)]HotRules rules, [HarmonyArgument(3)]HotExecScratch scratch, [HarmonyArgument(4)]byte dealerSlot,         [HarmonyArgument(5)]byte targetSlot, [HarmonyArgument(6)]int baseDamage, [HarmonyArgument(7)]bool isPoweredAttack, [HarmonyArgument(8)]bool isUnblockable,         [HarmonyArgument(9)]int cardIdx, [HarmonyArgument(10)]ushort cardDefId, [HarmonyArgument(12)]bool capOnlyModifiers, ref int __result)`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `CombatSolver.HotKernel.HotCombatEngine.ComputeModifiedDamage(ref CombatSolver.HotKernel.CombatHotState, ref CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, byte, byte, int, bool, int, ushort, bool)`；`CombatSolver.HotKernel.HotCombatEngine.GetCreatureRef(ref CombatSolver.HotKernel.CombatHotState, byte)`；`CombatSolver.HotKernel.HotCombatEngine.IsCreatureSlotValid(in CombatSolver.HotKernel.CombatHotState, byte)`；`NationalSpire.Solver.LeagueForecast.PlannedHit.PlannedHit(byte, byte, decimal, bool, bool)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._outgoing`；`NationalSpire.Solver.LeagueForecast._poison`；`NationalSpire.Solver.LeagueForecast.IntentLedger.Moves`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.HotKernel.HotCombatEngine.ComputeModifiedDamage(ref CombatSolver.HotKernel.CombatHotState, ref CombatSolver.HotKernel.HotColdSidecar?, CombatSolver.HotKernel.HotRules, CombatSolver.HotKernel.HotExecScratch, byte, byte, int, bool, int, ushort, bool)`；输入表达式：`HotCombatEngine.ComputeModifiedDamage(ref s, ref cold, rules, scratch,             dealerSlot, targetSlot, baseDamage, isPoweredAttack, cardIdx, cardDefId, capOnlyModifiers)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = HotCombatEngine.ComputeModifiedDamage(ref s, ref cold, rules, scratch,             dealerSlot, targetSlot, baseDamage, isPoweredAttack, cardIdx, cardDefId, capOnlyModifiers)`
- `CombatSolver.HotKernel.HotCombatEngine.GetCreatureRef(ref CombatSolver.HotKernel.CombatHotState, byte)`；输入表达式：`HotCombatEngine.GetCreatureRef(ref s, dealerSlot)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: HotCombatEngine.GetCreatureRef(ref s, dealerSlot).CurrentHp`
- `CombatSolver.HotKernel.HotCombatEngine.GetCreatureRef(ref CombatSolver.HotKernel.CombatHotState, byte)`；输入表达式：`HotCombatEngine.GetCreatureRef(ref s, targetSlot)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: HotCombatEngine.GetCreatureRef(ref s, targetSlot).CurrentHp`
- `CombatSolver.HotKernel.HotCombatEngine.IsCreatureSlotValid(in CombatSolver.HotKernel.CombatHotState, byte)`；输入表达式：`HotCombatEngine.IsCreatureSlotValid(in s, dealerSlot)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !HotCombatEngine.IsCreatureSlotValid(in s, dealerSlot)`
- `CombatSolver.HotKernel.HotCombatEngine.IsCreatureSlotValid(in CombatSolver.HotKernel.CombatHotState, byte)`；输入表达式：`HotCombatEngine.IsCreatureSlotValid(in s, targetSlot)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !HotCombatEngine.IsCreatureSlotValid(in s, targetSlot)`
- `NationalSpire.Solver.LeagueForecast.PlannedHit.PlannedHit(byte, byte, decimal, bool, bool)`；输入表达式：`new(dealerSlot, targetSlot, amount, false, isUnblockable)`；返回值紧邻使用处：`ArgumentSyntax: new(dealerSlot, targetSlot, amount, false, isUnblockable)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`ledger.Moves.Add(new(dealerSlot, targetSlot, amount, false, isUnblockable))`；返回值紧邻使用处：`ExpressionStatementSyntax: ledger.Moves.Add(new(dealerSlot, targetSlot, amount, false, isUnblockable));`

**赋值（含属性/字段和局部值）：**

- `__result` = `0`
- `dealerSlot` = `0`
- `HotCombatEngine.t_lastHitTotalPlusOverkill` = `0`

<a id="symbol-431a6013e6ac"></a>

## `NationalSpire.Solver.LeagueForecast.DeclareDoom(CombatSolver.HotKernel.HotRules, byte, byte, ushort, ref int, ref int) — private static bool DeclareDoom([HarmonyArgument(2)]HotRules rules, [HarmonyArgument(4)]byte ownerSlot,         [HarmonyArgument(5)]byte applierSlot, [HarmonyArgument(6)]ushort powerDefId,         [HarmonyArgument(7)]ref int amount, ref int __result)`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `CombatSolver.HotKernel.HotRules.GetPowerDefId(CombatSolver.HotKernel.HotPowerId)`；`NationalSpire.Solver.LeagueForecast.PlannedHit.PlannedHit(byte, byte, decimal, bool, bool)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._outgoing`；`NationalSpire.Solver.LeagueForecast.IntentLedger.Moves`；`NationalSpire.Solver.LeagueForecast.IntentLedger.ScaleDoom`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.HotKernel.HotRules.GetPowerDefId(CombatSolver.HotKernel.HotPowerId)`；输入表达式：`rules.GetPowerDefId(HotPowerId.DoomPower)`；返回值紧邻使用处：`BinaryExpressionSyntax: powerDefId != rules.GetPowerDefId(HotPowerId.DoomPower)`
- `NationalSpire.Solver.LeagueForecast.PlannedHit.PlannedHit(byte, byte, decimal, bool, bool)`；输入表达式：`new(applierSlot, ownerSlot, amount, true)`；返回值紧邻使用处：`ArgumentSyntax: new(applierSlot, ownerSlot, amount, true)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`ledger.Moves.Add(new(applierSlot, ownerSlot, amount, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: ledger.Moves.Add(new(applierSlot, ownerSlot, amount, true));`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`ledger.ScaleDoom(amount)`；返回值紧邻使用处：`AssignmentExpressionSyntax: amount = ledger.ScaleDoom(amount)`

**赋值（含属性/字段和局部值）：**

- `__result` = `0`
- `amount` = `ledger.ScaleDoom(amount)`
