# Compatibility/LeagueSolver/LeagueForecast.cs

[返回文件依赖索引](../../../SOURCE_MAP.md)

源码 SHA-256：`EDB7371748EEBED7FB11113E8C1E4F162CF8C143F88F687B7EED11A399F61855`。来源：[源码](../../../../Compatibility/LeagueSolver/LeagueForecast.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Solver.LeagueForecast`、`NationalSpire.Solver.LeagueForecast.Ledger`、`NationalSpire.Solver.LeagueForecast.Play`、`NationalSpire.Solver.LeagueForecast.Branch`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Player _live;
private readonly int _tier;
private static bool _installed;
internal readonly Dictionary<Creature,decimal> Hits=[];
internal readonly Dictionary<Creature,int> Stacks=[];
private static readonly ConditionalWeakTable<CombatPredictionSimulator,Ledger> Damage=new();
private readonly Queue<Play> _route=[];
private readonly Dictionary<CardModel,CardModel> _originals=new(ReferenceEqualityComparer.Instance);
private Player? _actor;
private int _captured;
private readonly HashSet<string> _setup;
private static Func<int,int> _addedDoom=null!;
private readonly int _preferredTarget;
[ThreadStatic] private static Ledger? _move;
private int liveEnergy,liveStars;
private readonly Dictionary<Creature,int> _aims=[];
```

<a id="symbol-9ecdb20e5b06"></a>

## `NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger) — internal void Copy(Ledger src)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[])`](LeagueForecast.cs.md#symbol-9ae84c39d167)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.Ledger.Hits`；`NationalSpire.Solver.LeagueForecast.Ledger.Stacks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `Hits[p.Key]` = `p.Value`
- `Stacks[p.Key]` = `p.Value`

<a id="symbol-40dd0840824d"></a>

## `NationalSpire.Solver.LeagueForecast.Continuation() — public (CardModel,int)[] Continuation()`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeWhile<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.Queue<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._route`；`NationalSpire.Solver.LeagueForecast.Play.Aim`；`NationalSpire.Solver.LeagueForecast.Play.Live`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_route.TakeWhile(x=>x.Live!=null).Select(x=>(x.Live!,x.Aim))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _route.TakeWhile(x=>x.Live!=null).Select(x=>(x.Live!,x.Aim)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.TakeWhile<TSource>(System.Func<TSource, bool>)`；输入表达式：`_route.TakeWhile(x=>x.Live!=null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _route.TakeWhile(x=>x.Live!=null).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_route.TakeWhile(x=>x.Live!=null).Select(x=>(x.Live!,x.Aim)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_route.TakeWhile(x=>x.Live!=null).Select(x=>(x.Live!,x.Aim)).ToArray()`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_route.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _route.Clear();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-09c85ea08804"></a>

## `NationalSpire.Solver.LeagueForecast.LastAim — public int LastAim`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1a48d346adcb"></a>

## `NationalSpire.Solver.LeagueForecast.LeagueForecast(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], System.Func<int, int>, int) — public LeagueForecast(Player rival,int tier,string[] setup,Func<int,int> addedDoom,int preference)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Solver.LeagueForecast.Prepare()`](LeagueForecast.cs.md#symbol-f2559c94c021)；`System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEnumerable<T>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._addedDoom`；`NationalSpire.Solver.LeagueForecast._live`；`NationalSpire.Solver.LeagueForecast._preferredTarget`；`NationalSpire.Solver.LeagueForecast._setup`；`NationalSpire.Solver.LeagueForecast._tier`；`NationalSpire.Solver.LeagueForecast.Prepare()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Solver.LeagueForecast.Prepare()`；输入表达式：`Prepare()`；返回值紧邻使用处：`ExpressionStatementSyntax: Prepare();`
- `System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new(setup)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _setup=new(setup)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(tier,2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _tier=Math.Min(tier,2)`

**赋值（含属性/字段和局部值）：**

- `_addedDoom` = `addedDoom`
- `_live` = `rival`
- `_preferredTarget` = `preference`
- `_setup` = `new(setup)`
- `_tier` = `Math.Min(tier,2)`

<a id="symbol-f2559c94c021"></a>

## `NationalSpire.Solver.LeagueForecast.Prepare() — public static void Prepare()`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.LeagueForecast(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], System.Func<int, int>, int)`](LeagueForecast.cs.md#symbol-1a48d346adcb)

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertySetter(System.Type, string)`；`HarmonyLib.Harmony.Harmony(string)`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.IEnumerable.Cast<TResult>()`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`；`System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(System.Type)`；`System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(System.RuntimeMethodHandle)`；`System.Type.GetConstructors()`；`System.Type.GetMethods(System.Reflection.BindingFlags)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._installed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(CombatPredictionSimulator),"Damage",[typeof(IReadOnlyList<Creature>),typeof(decimal),typeof(ValueProp),typeof(Creature),typeof(PredictedCard),typeof(CardPlay),typeof(ModifyDamageHookType)])`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.Method(typeof(CombatPredictionSimulator),"Damage",[typeof(IReadOnlyList<Creature>),typeof(decimal),typeof(ValueProp),typeof(Creature),typeof(PredictedCard),typeof(CardPlay),typeof(ModifyDamageHookType)])`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(CombatSolverLog),"Write")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(CombatSolverLog),"Write")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(PredictionModPatchAudit),"TryDescribeForeignPatch")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(PredictionModPatchAudit),"TryDescribeForeignPatch")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(SimulatedCombatState),"ModifyPowerAmountForRelics")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(SimulatedCombatState),"ModifyPowerAmountForRelics")`
- `HarmonyLib.AccessTools.PropertySetter(System.Type, string)`；输入表达式：`AccessTools.PropertySetter(typeof(Entry),"Logger")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.PropertySetter(typeof(Entry),"Logger").Invoke`
- `HarmonyLib.Harmony.Harmony(string)`；输入表达式：`new Harmony("nationalspire.league.forecast")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Harmony("nationalspire.league.forecast")`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.Method(typeof(CombatSolverLog),"Write"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(DebugOutput)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.Method(typeof(CombatSolverLog),"Write"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(DebugOutput)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.Method(typeof(PredictionModPatchAudit),"TryDescribeForeignPatch"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(MirroredIntent)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.Method(typeof(PredictionModPatchAudit),"TryDescribeForeignPatch"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(MirroredIntent)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.Method(typeof(SimulatedCombatState),"ModifyPowerAmountForRelics"),postfix:new HarmonyMethod(typeof(LeagueForecast),nameof(SimDoom)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.Method(typeof(SimulatedCombatState),"ModifyPowerAmountForRelics"),postfix:new HarmonyMethod(typeof(LeagueForecast),nameof(SimDoom)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(method,prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(Intent)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(method,prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(Intent)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(DebugOutput))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(DebugOutput))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(Intent))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(Intent))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(MirroredIntent))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(MirroredIntent))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(SimDoom))`；返回值紧邻使用处：`ArgumentSyntax: postfix:new HarmonyMethod(typeof(LeagueForecast),nameof(SimDoom))`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`type.GetMethods(System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.DeclaredOnly).Cast<System.Reflection.MethodBase>().Concat(type.GetConstructors())`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var m in type.GetMethods(System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.DeclaredOnly).Cast<System.Reflection.MethodBase>().Concat(type.GetConstructors()))                 if(!m.ContainsGenericParameters && !m.IsAbstract && (m.IsConstructor||m.Name is "Capture" or "ManualPlay" or "Fork" or "CanPlay" or "Damage"))                     RuntimeHelpers.PrepareMethod(m.MethodHandle);`
- `System.Collections.IEnumerable.Cast<TResult>()`；输入表达式：`type.GetMethods(System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.DeclaredOnly).Cast<System.Reflection.MethodBase>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: type.GetMethods(System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.DeclaredOnly).Cast<System.Reflection.MethodBase>().Concat`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`AccessTools.PropertySetter(typeof(Entry),"Logger").Invoke(null,[RuntimeHelpers.GetUninitializedObject(typeof(CombatSolverLog))])`；返回值紧邻使用处：`ExpressionStatementSyntax: AccessTools.PropertySetter(typeof(Entry),"Logger").Invoke(null,[RuntimeHelpers.GetUninitializedObject(typeof(CombatSolverLog))]);`
- `System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(System.Type)`；输入表达式：`RuntimeHelpers.GetUninitializedObject(typeof(CombatSolverLog))`；返回值紧邻使用处：`ExpressionElementSyntax: RuntimeHelpers.GetUninitializedObject(typeof(CombatSolverLog))`
- `System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(System.RuntimeMethodHandle)`；输入表达式：`RuntimeHelpers.PrepareMethod(m.MethodHandle)`；返回值紧邻使用处：`ExpressionStatementSyntax: RuntimeHelpers.PrepareMethod(m.MethodHandle);`
- `System.Type.GetConstructors()`；输入表达式：`type.GetConstructors()`；返回值紧邻使用处：`ArgumentSyntax: type.GetConstructors()`
- `System.Type.GetMethods(System.Reflection.BindingFlags)`；输入表达式：`type.GetMethods(System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.DeclaredOnly)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: type.GetMethods(System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.DeclaredOnly).Cast<System.Reflection.MethodBase>`

**赋值（含属性/字段和局部值）：**

- `_installed` = `true`
- `CombatSolver.Engine.InCombat.Mirrors.Cards.OnPlay.CardOnPlayMirrors.AllowInference` = `true`

<a id="symbol-9f6b4b8a6854"></a>

## `NationalSpire.Solver.LeagueForecast.DebugOutput(string) — private static bool DebugOutput(string message)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Diagnostics.Debug.WriteLine(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Diagnostics.Debug.WriteLine(string?)`；输入表达式：`Debug.WriteLine(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: Debug.WriteLine(message);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-16de46b59acf"></a>

## `NationalSpire.Solver.LeagueForecast.SimDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref int) — private static void SimDoom(PowerModel power,Creature target,Creature? applier,ref int __result)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._addedDoom`；`NationalSpire.Solver.LeagueForecast._move`；`NationalSpire.Solver.LeagueForecast.Ledger.Stacks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_move.Stacks.GetValueOrDefault(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: _move.Stacks.GetValueOrDefault(target)+__result`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`_addedDoom(__result)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=_addedDoom(__result)`

**赋值（含属性/字段和局部值）：**

- `__result` = `_addedDoom(__result)`
- `__result` = `0`
- `_move.Stacks[target]` = `_move.Stacks.GetValueOrDefault(target)+__result`

<a id="symbol-0840e82b2cf1"></a>

## `NationalSpire.Solver.LeagueForecast.MirroredIntent(HarmonyLib.Patch, System.Reflection.MethodBase) — private static bool MirroredIntent(Patch patch,System.Reflection.MethodBase target)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1ac552693ff5"></a>

## `NationalSpire.Solver.LeagueForecast.Intent(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>) — private static bool Intent(CombatPredictionSimulator __instance,IReadOnlyList<Creature> targets,decimal amount,ValueProp props,Creature? dealer,         PredictedCard? cardSource,CardPlay? cardPlay,ModifyDamageHookType modifyDamageHookType,ref IReadOnlyList<DamageResult> __result)`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `CombatSolver.Engine.InCombat.Mirrors.HookMirrors.ModifyDamage(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.ResolveDamageSource(CombatSolver.Engine.Common.PredictedCard?)`；`MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Entities.Creatures.DamageResult.DamageResult(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(decimal, decimal)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.Damage`；`NationalSpire.Solver.LeagueForecast.Ledger.Hits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.Engine.InCombat.Mirrors.HookMirrors.ModifyDamage(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`；输入表达式：`HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType)`；返回值紧邻使用处：`ArgumentSyntax: HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.ResolveDamageSource(CombatSolver.Engine.Common.PredictedCard?)`；输入表达式：`__instance.ResolveDamageSource(cardSource)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: __instance.ResolveDamageSource(cardSource).Kind`
- `MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`__instance.State.CombatState.GetOpponentsOf(targets[0])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: __instance.State.CombatState.GetOpponentsOf(targets[0]).FirstOrDefault`
- `MegaCrit.Sts2.Core.Entities.Creatures.DamageResult.DamageResult(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；输入表达式：`new DamageResult(t,props)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t=>new DamageResult(t,props)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`targets.Any(t=>t.Side==dealer.Side)`；返回值紧邻使用处：`BinaryExpressionSyntax: dealer==null||targets.Any(t=>t.Side==dealer.Side)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`__instance.State.CombatState.GetOpponentsOf(targets[0]).FirstOrDefault(c=>c.IsAlive)`；返回值紧邻使用处：`AssignmentExpressionSyntax: dealer=__instance.State.CombatState.GetOpponentsOf(targets[0]).FirstOrDefault(c=>c.IsAlive)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`targets.Select(t=>new DamageResult(t,props))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: targets.Select(t=>new DamageResult(t,props)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`targets.Select(t=>new DamageResult(t,props)).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=targets.Select(t=>new DamageResult(t,props)).ToArray()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`log.Hits.GetValueOrDefault(t)`；返回值紧邻使用处：`BinaryExpressionSyntax: log.Hits.GetValueOrDefault(t)+Math.Max(0,HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType))`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0,HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType))`；返回值紧邻使用处：`BinaryExpressionSyntax: log.Hits.GetValueOrDefault(t)+Math.Max(0,HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType))`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Damage.TryGetValue(__instance,out var log)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Damage.TryGetValue(__instance,out var log)`

**赋值（含属性/字段和局部值）：**

- `__result` = `targets.Select(t=>new DamageResult(t,props)).ToArray()`
- `dealer` = `__instance.State.CombatState.GetOpponentsOf(targets[0]).FirstOrDefault(c=>c.IsAlive)`
- `log.Hits[t]` = `log.Hits.GetValueOrDefault(t)+Math.Max(0,HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType))`
- `props` &= `~ValueProp.Unblockable`

<a id="symbol-9ae84c39d167"></a>

## `NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[]) — public async Task<CardModel?> Choose(decimal[] amounts,int[] properties)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Codes(System.Collections.Generic.IEnumerable<CombatSolver.Engine.Common.PredictedCard>)`](LeagueForecast.cs.md#symbol-f327865c6573)；[`EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`](LeagueForecast.cs.md#symbol-67b8dece69f8)；[`HandValue(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, CombatSolver.SimulatedCombatState)`](LeagueForecast.cs.md#symbol-a330cc419ce8)；[`NationalSpire.Solver.LeagueForecast.Capture(bool)`](LeagueForecast.cs.md#symbol-1c0fdc3118f7)；[`NationalSpire.Solver.LeagueForecast.Dispose()`](LeagueForecast.cs.md#symbol-6cb7d1f580d7)；[`NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger)`](LeagueForecast.cs.md#symbol-9ecdb20e5b06)；[`Take()`](LeagueForecast.cs.md#symbol-e389eacf5382)；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.CanPlay(CombatSolver.Engine.Common.PredictedCard)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Fork()`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.ManualPlay(CombatSolver.Engine.Common.PredictedCard, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, out CombatSolver.Engine.Common.PredictionTraceFrame?)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；`CombatSolver.PredictionCoverage.Collect(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；`CombatSolver.SimulatedCombatState.BeginActionChoices(System.Collections.Generic.IReadOnlyList<CombatSolver.PlanCardChoice>?)`；`CombatSolver.SimulatedCombatState.EndActionChoices()`；`CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；`NationalSpire.Solver.LeagueForecast.Branch.Branch(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, System.Collections.Generic.List<NationalSpire.Solver.LeagueForecast.Play>, decimal, decimal)`；`NationalSpire.Solver.LeagueForecast.Play.Play(MegaCrit.Sts2.Core.Models.CardModel?, string, int, int)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.List(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Collections.IEnumerable.Cast<TResult>()`；`System.Diagnostics.Stopwatch.GetElapsedTime(long)`；`System.Diagnostics.Stopwatch.GetTimestamp()`；`System.Diagnostics.Stopwatch.StartNew()`；`System.Environment.GetEnvironmentVariable(string)`；`System.GC.GetAllocatedBytesForCurrentThread()`；`System.IO.File.AppendAllText(string, string?)`；`System.IO.Path.Combine(string, string)`；`System.Math.Max(decimal, decimal)`；`System.Math.Min(decimal, decimal)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；`System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`

**字段、属性、事件及方法组引用：** `Codes(System.Collections.Generic.IEnumerable<CombatSolver.Engine.Common.PredictedCard>)`；`EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；`HandValue(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, CombatSolver.SimulatedCombatState)`；`NationalSpire.Solver.LeagueForecast._actor`；`NationalSpire.Solver.LeagueForecast._aims`；`NationalSpire.Solver.LeagueForecast._captured`；`NationalSpire.Solver.LeagueForecast._live`；`NationalSpire.Solver.LeagueForecast._move`；`NationalSpire.Solver.LeagueForecast._originals`；`NationalSpire.Solver.LeagueForecast._preferredTarget`；`NationalSpire.Solver.LeagueForecast._route`；`NationalSpire.Solver.LeagueForecast._setup`；`NationalSpire.Solver.LeagueForecast._tier`；`NationalSpire.Solver.LeagueForecast.Branch.Route`；`NationalSpire.Solver.LeagueForecast.Branch.Score`；`NationalSpire.Solver.LeagueForecast.Branch.Setup`；`NationalSpire.Solver.LeagueForecast.Branch.Sim`；`NationalSpire.Solver.LeagueForecast.Capture(bool)`；`NationalSpire.Solver.LeagueForecast.Damage`；`NationalSpire.Solver.LeagueForecast.Dispose()`；`NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger)`；`NationalSpire.Solver.LeagueForecast.Ledger.Hits`；`NationalSpire.Solver.LeagueForecast.Ledger.Stacks`；`NationalSpire.Solver.LeagueForecast.liveEnergy`；`NationalSpire.Solver.LeagueForecast.liveStars`；`NationalSpire.Solver.LeagueForecast.Play.Id`；`NationalSpire.Solver.LeagueForecast.Play.Level`；`Take()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Codes(System.Collections.Generic.IEnumerable<CombatSolver.Engine.Common.PredictedCard>)`；输入表达式：`Codes(handState.DiscardPile.Cards)`；返回值紧邻使用处：`BinaryExpressionSyntax: handState.Energy+"/"+handState.Stars+"/"+own.Block+"/"+Codes(handState.Hand.Cards)+"/"+Codes(handState.DrawPile.Cards)+"/"+Codes(handState.DiscardPile.Cards)`
- `Codes(System.Collections.Generic.IEnumerable<CombatSolver.Engine.Common.PredictedCard>)`；输入表达式：`Codes(handState.DrawPile.Cards)`；返回值紧邻使用处：`BinaryExpressionSyntax: handState.Energy+"/"+handState.Stars+"/"+own.Block+"/"+Codes(handState.Hand.Cards)+"/"+Codes(handState.DrawPile.Cards)`
- `Codes(System.Collections.Generic.IEnumerable<CombatSolver.Engine.Common.PredictedCard>)`；输入表达式：`Codes(handState.Hand.Cards)`；返回值紧邻使用处：`BinaryExpressionSyntax: handState.Energy+"/"+handState.Stars+"/"+own.Block+"/"+Codes(handState.Hand.Cards)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.CanPlay(CombatSolver.Engine.Common.PredictedCard)`；输入表达式：`parent.Sim.CanPlay(move)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !parent.Sim.CanPlay(move)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Fork()`；输入表达式：`parent.Sim.Fork()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =parent.Sim.Fork()`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.ManualPlay(CombatSolver.Engine.Common.PredictedCard, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, out CombatSolver.Engine.Common.PredictionTraceFrame?)`；输入表达式：`sim.ManualPlay(card,aim,out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !sim.ManualPlay(card,aim,out _)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`parent.Sim.State.GetCreature(t)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parent.Sim.State.GetCreature(t).IsAlive`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`root.State.GetCreature(actor.Creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =root.State.GetCreature(actor.Creature)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`root.State.GetCreature(target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =root.State.GetCreature(target)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`sim.State.GetCreature(actor.Creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sim.State.GetCreature(actor.Creature)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`sim.State.GetCreature(target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sim.State.GetCreature(target)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`parent.Sim.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =parent.Sim.State.GetPlayerCombatState(actor)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`root.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: root.State.GetPlayerCombatState(actor).Hand`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`sim.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sim.State.GetPlayerCombatState(actor)`
- `CombatSolver.PredictionCoverage.Collect(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；输入表达式：`PredictionCoverage.Collect(sim)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PredictionCoverage.Collect(sim).Any`
- `CombatSolver.SimulatedCombatState.BeginActionChoices(System.Collections.Generic.IReadOnlyList<CombatSolver.PlanCardChoice>?)`；输入表达式：`combat.BeginActionChoices((IReadOnlyList<PlanCardChoice>?)null)`；返回值紧邻使用处：`ExpressionStatementSyntax: combat.BeginActionChoices((IReadOnlyList<PlanCardChoice>?)null);`
- `CombatSolver.SimulatedCombatState.EndActionChoices()`；输入表达式：`combat.EndActionChoices()`；返回值紧邻使用处：`ExpressionStatementSyntax: combat.EndActionChoices();`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<DoomPower>(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target)`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<PoisonPower>(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target)`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`initial.GetAmount<DoomPower>(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: stacked-initial.GetAmount<DoomPower>(target)`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`initial.GetAmount<PoisonPower>(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target)`
- `EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；输入表达式：`EndHealth(root)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EndHealth(root)`
- `EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；输入表达式：`EndHealth(sim)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EndHealth(sim)`
- `HandValue(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, CombatSolver.SimulatedCombatState)`；输入表达式：`HandValue(handState.Hand.Cards,combat)`；返回值紧邻使用处：`BinaryExpressionSyntax: HandValue(handState.Hand.Cards,combat)-hand`
- `HandValue(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, CombatSolver.SimulatedCombatState)`；输入表达式：`HandValue(root.State.GetPlayerCombatState(actor).Hand.Cards,initial)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HandValue(root.State.GetPlayerCombatState(actor).Hand.Cards,initial)`
- `MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；输入表达式：`c.CanPlay()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>c.CanPlay()`
- `NationalSpire.Solver.LeagueForecast.Branch.Branch(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, System.Collections.Generic.List<NationalSpire.Solver.LeagueForecast.Play>, decimal, decimal)`；输入表达式：`new Branch(sim,route,score,setup)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Branch(sim,route,score,setup)`
- `NationalSpire.Solver.LeagueForecast.Branch.Branch(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, System.Collections.Generic.List<NationalSpire.Solver.LeagueForecast.Play>, decimal, decimal)`；输入表达式：`new(root,[],0)`；返回值紧邻使用处：`InitializerExpressionSyntax: {new(root,[],0)}`
- `NationalSpire.Solver.LeagueForecast.Capture(bool)`；输入表达式：`Capture(amounts.Any(v=>v>0))`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (root,targets)=Capture(amounts.Any(v=>v>0))`
- `NationalSpire.Solver.LeagueForecast.Dispose()`；输入表达式：`Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dispose();`
- `NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger)`；输入表达式：`mark.Copy(Damage.GetOrCreateValue(parent.Sim))`；返回值紧邻使用处：`ExpressionStatementSyntax: mark.Copy(Damage.GetOrCreateValue(parent.Sim));`
- `NationalSpire.Solver.LeagueForecast.Play.Play(MegaCrit.Sts2.Core.Models.CardModel?, string, int, int)`；输入表达式：`new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1))`；返回值紧邻使用处：`InitializerExpressionSyntax: {new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1))}`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(' ',_route.Select(s=>s.Id+(s.Level>0?"+":"")))`；返回值紧邻使用处：`InterpolationSyntax: {string.Join(' ',_route.Select(s=>s.Id+(s.Level>0?"+":"")))}`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string,decimal>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<string,decimal>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`visited.TryGetValue(key,out var old)`；返回值紧邻使用处：`BinaryExpressionSyntax: visited.TryGetValue(key,out var old)&&old>=score`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_setup.Contains(card.Preview.Id.Entry)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_setup.Contains(card.Preview.Id.Entry)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`amounts.Any(v=>v>0)`；返回值紧邻使用处：`ArgumentSyntax: amounts.Any(v=>v>0)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PredictionCoverage.Collect(sim).Any(g=>!g.Compensated)`；返回值紧邻使用处：`BinaryExpressionSyntax: sim.HasRisk&&PredictionCoverage.Collect(sim).Any(g=>!g.Compensated)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`realHand.Any(c=>c.CanPlay())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !realHand.Any(c=>c.CanPlay())`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`layer.OrderByDescending(b=>b.Score)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: layer.OrderByDescending(b=>b.Score).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`targets.OrderByDescending(t=>_aims[t]==_preferredTarget)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: targets.OrderByDescending(t=>_aims[t]==_preferredTarget).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_route.Select(s=>s.Id+(s.Level>0?"+":""))`；返回值紧邻使用处：`ArgumentSyntax: _route.Select(s=>s.Id+(s.Level>0?"+":""))`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`layer.OrderByDescending(b=>b.Score).Take(3+_tier*2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`targets.OrderByDescending(t=>_aims[t]==_preferredTarget).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _preferredTarget<0?targets:targets.OrderByDescending(t=>_aims[t]==_preferredTarget).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: front=layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_aims.GetValueOrDefault(aim,-1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: aim==null?-1:_aims.GetValueOrDefault(aim,-1)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_originals.GetValueOrDefault(card.Original)`；返回值紧邻使用处：`ArgumentSyntax: _originals.GetValueOrDefault(card.Original)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`mark.Hits.GetValueOrDefault(target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =mark.Hits.GetValueOrDefault(target)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`mark.Stacks.GetValueOrDefault(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`layer.Add(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: layer.Add(b);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Branch>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<Branch>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Branch>{new(root,[],0)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<Branch>{new(root,[],0)}`
- `System.Collections.Generic.List<T>.List(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1))}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1))}`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_route.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _route.Clear();`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_route.Enqueue(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _route.Enqueue(id);`
- `System.Collections.IEnumerable.Cast<TResult>()`；输入表达式：`aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: move.Preview.TargetType==TargetType.AnyEnemy?aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>():new Creature?[]{move.Preview.TargetType is TargetType.AnyAlly or TargetType.Self?actor.Creature:null}`
- `System.Diagnostics.Stopwatch.GetElapsedTime(long)`；输入表达式：`Stopwatch.GetElapsedTime(started)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Stopwatch.GetElapsedTime(started).TotalMilliseconds`
- `System.Diagnostics.Stopwatch.GetTimestamp()`；输入表达式：`Stopwatch.GetTimestamp()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Stopwatch.GetTimestamp()`
- `System.Diagnostics.Stopwatch.StartNew()`；输入表达式：`Stopwatch.StartNew()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Stopwatch.StartNew()`
- `System.Environment.GetEnvironmentVariable(string)`；输入表达式：`Environment.GetEnvironmentVariable("LEAGUE_PREVIEW_ROOT")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Environment.GetEnvironmentVariable("LEAGUE_PREVIEW_ROOT")`
- `System.GC.GetAllocatedBytesForCurrentThread()`；输入表达式：`GC.GetAllocatedBytesForCurrentThread()`；返回值紧邻使用处：`BinaryExpressionSyntax: GC.GetAllocatedBytesForCurrentThread()-allocated`
- `System.GC.GetAllocatedBytesForCurrentThread()`；输入表达式：`GC.GetAllocatedBytesForCurrentThread()`；返回值紧邻使用处：`BinaryExpressionSyntax: GC.GetAllocatedBytesForCurrentThread()-before`
- `System.GC.GetAllocatedBytesForCurrentThread()`；输入表达式：`GC.GetAllocatedBytesForCurrentThread()`；返回值紧邻使用处：`ConditionalExpressionSyntax: report==null?0:GC.GetAllocatedBytesForCurrentThread()`
- `System.IO.File.AppendAllText(string, string?)`；输入表达式：`File.AppendAllText(Path.Combine(report,"solver-review.txt"),$"{_captured++} capture={capture:F1}ms total={watch.Elapsed.TotalMilliseconds:F1}ms search={searchMs:F1}ms captureBytes={captureBytes} searchBytes={searchBytes} expanded={expanded} route={string.Join(' ',_route.Select(s=>s.Id+(s.Level>0?"+":"")))}\n")`；返回值紧邻使用处：`ExpressionStatementSyntax: File.AppendAllText(Path.Combine(report,"solver-review.txt"),$"{_captured++} capture={capture:F1}ms total={watch.Elapsed.TotalMilliseconds:F1}ms search={searchMs:F1}ms captureBytes={captureBytes} searchBytes={searchBytes} expanded={expanded} route={string.Join(' ',_route.Select(s=>s.Id+(s.Level>0?"+":"")))}\n");`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(report,"solver-review.txt")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(report,"solver-review.txt")`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0,attack-foe.Block)`；返回值紧邻使用处：`BinaryExpressionSyntax: enemy.CurrentHp-Math.Max(0,attack-foe.Block)`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(hp+foe.Block,hit)`；返回值紧邻使用处：`BinaryExpressionSyntax: (combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit)`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Damage.GetOrCreateValue(parent.Sim)`；返回值紧邻使用处：`ArgumentSyntax: Damage.GetOrCreateValue(parent.Sim)`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Damage.GetOrCreateValue(sim)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Damage.GetOrCreateValue(sim)`
- `System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`；输入表达式：`Task.Run(()=>{             long allocated=report==null?0:GC.GetAllocatedBytesForCurrentThread();long started=Stopwatch.GetTimestamp();             try{             var clock=Stopwatch.StartNew();var me=root.State.GetCreature(actor.Creature);             decimal EndHealth(CombatPredictionSimulator sim){                 if(amounts.Length==0)return sim.State.GetCreature(actor.Creature).CurrentHp;                 var end=sim.Fork();var defending=end.State.GetCreature(actor.Creature);int held=((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature),added=0;                 for(int k=0;k<amounts.Length&&end.State.GetCreature(actor.Creature).IsAlive;k++)                     if(properties[k]==-1){added+=(int)(amounts[k]-defending.DamageBlock(amounts[k],ValueProp.Move));}else end.Damage([actor.Creature],amounts[k],(ValueProp)properties[k],targets[0],null,null,ModifyDamageHookType.None);                 return !defending.IsAlive||held+added>=defending.CurrentHp?0:Math.Max(.1m,defending.CurrentHp-added*.85m);             }             var initial=(SimulatedCombatState)root.State.CombatState;             bool fool=actor.Character.Id.Entry=="FOOL";             int HandValue(IReadOnlyList<PredictedCard> cards,SimulatedCombatState state){                 if(!fool)return cards.Count;                 int sadness=0;foreach(var c in cards)if(c.Preview.Id.Entry=="SADNESS")sadness++;                 // 每层狂喜可在下个回合转化一张悲伤；其余悲伤会继续占用手牌位置。                 return cards.Count-sadness-Math.Max(0,sadness-state.GetAmount<EcstasyPower>(actor.Creature));             }             var baseLife=EndHealth(root);int hand=HandValue(root.State.GetPlayerCombatState(actor).Hand.Cards,initial);                          var front=new List<Branch>{new(root,[],0)};var chosen=front[0];var visited=new Dictionary<string,decimal>();             for(int depth=0;depth<24&&front.Count>0;depth++){                 var layer=new List<Branch>();                 foreach(var parent in front){                     var ps=parent.Sim.State.GetPlayerCombatState(actor);                     for(int i=0;i<ps.Hand.Cards.Count;i++){                         if(expanded>0&&clock.Elapsed.TotalMilliseconds>=18+6*_tier)return chosen;                         var move=ps.Hand.Cards[i];if(!parent.Sim.CanPlay(move))continue;                         foreach(var aim in move.Preview.TargetType==TargetType.AnyEnemy?aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>():new Creature?[]{move.Preview.TargetType is TargetType.AnyAlly or TargetType.Self?actor.Creature:null}){                         var sim=parent.Sim.Fork();var mark=Damage.GetOrCreateValue(sim);mark.Copy(Damage.GetOrCreateValue(parent.Sim));                         var handState=sim.State.GetPlayerCombatState(actor);var card=handState.Hand.Cards[i];                                                  expanded++;                         var combat=(SimulatedCombatState)sim.State.CombatState;                         combat.BeginActionChoices((IReadOnlyList<PlanCardChoice>?)null);                         _move=mark;try{if(!sim.ManualPlay(card,aim,out _)||sim.HasPendingChoice||sim.HasRisk&&PredictionCoverage.Collect(sim).Any(g=>!g.Compensated))continue;}                         catch(PredictionUnsupportedException){continue;}                         finally{_move=null;combat.EndActionChoices();}                         var own=sim.State.GetCreature(actor.Creature);                         var life=EndHealth(sim);                         // 当回合可以安全建立的能力也有价值。计分只影响路线排序，不额外搜索未来回合。                         decimal setup=parent.Setup;                         if(_tier>0&&card.Preview.Type==CardType.Power){                             bool core=_setup.Contains(card.Preview.Id.Entry);                             setup+=core?5+3*_tier:2+_tier;                         }                         decimal pressure=0;bool lethal=true;                         foreach(var target in targets){                             var foe=root.State.GetCreature(target);var enemy=sim.State.GetCreature(target);int hp=foe.CurrentHp;                             decimal attack=mark.Hits.GetValueOrDefault(target),hit=attack+hp-enemy.CurrentHp;                             int stacked=combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target);                             pressure+=(combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit);                             if(stacked>0&&stacked>=enemy.CurrentHp-Math.Max(0,attack-foe.Block)&&life>0)pressure+=hp;                             lethal&=hit>=hp+foe.Block;                         }                         decimal score=pressure+setup+(life-baseLife)*1.6m+(life>0&&baseLife<=0?10000:life<=0&&baseLife>0?-10000:0)                             +(HandValue(handState.Hand.Cards,combat)-hand)*.8m                             +(handState.Energy-liveEnergy)*1.25m+(handState.Stars-liveStars)*.5m                             + (parent.Route.Count+1)*.03m;                         var route=new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1))};var b=new Branch(sim,route,score,setup);                         if(score>chosen.Score||chosen.Route.Count==0)chosen=b;                         if(lethal&&life>0)return chosen;                         string Codes(IEnumerable<PredictedCard> pile)=>string.Join(',',pile.Select(c=>c.Preview.IsUpgraded?c.Preview.Id.Entry+"+":c.Preview.Id.Entry));                         string key=handState.Energy+"/"+handState.Stars+"/"+own.Block+"/"+Codes(handState.Hand.Cards)+"/"+Codes(handState.DrawPile.Cards)+"/"+Codes(handState.DiscardPile.Cards);                         if(visited.TryGetValue(key,out var old)&&old>=score)continue;visited[key]=score;layer.Add(b);                         }                     }                 }                 front=layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList();             }             return chosen;             }finally{if(report!=null){searchMs=Stopwatch.GetElapsedTime(started).TotalMilliseconds;searchBytes=GC.GetAllocatedBytesForCurrentThread()-allocated;}}         })`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Run(()=>{             long allocated=report==null?0:GC.GetAllocatedBytesForCurrentThread();long started=Stopwatch.GetTimestamp();             try{             var clock=Stopwatch.StartNew();var me=root.State.GetCreature(actor.Creature);             decimal EndHealth(CombatPredictionSimulator sim){                 if(amounts.Length==0)return sim.State.GetCreature(actor.Creature).CurrentHp;                 var end=sim.Fork();var defending=end.State.GetCreature(actor.Creature);int held=((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature),added=0;                 for(int k=0;k<amounts.Length&&end.State.GetCreature(actor.Creature).IsAlive;k++)                     if(properties[k]==-1){added+=(int)(amounts[k]-defending.DamageBlock(amounts[k],ValueProp.Move));}else end.Damage([actor.Creature],amounts[k],(ValueProp)properties[k],targets[0],null,null,ModifyDamageHookType.None);                 return !defending.IsAlive||held+added>=defending.CurrentHp?0:Math.Max(.1m,defending.CurrentHp-added*.85m);             }             var initial=(SimulatedCombatState)root.State.CombatState;             bool fool=actor.Character.Id.Entry=="FOOL";             int HandValue(IReadOnlyList<PredictedCard> cards,SimulatedCombatState state){                 if(!fool)return cards.Count;                 int sadness=0;foreach(var c in cards)if(c.Preview.Id.Entry=="SADNESS")sadness++;                 // 每层狂喜可在下个回合转化一张悲伤；其余悲伤会继续占用手牌位置。                 return cards.Count-sadness-Math.Max(0,sadness-state.GetAmount<EcstasyPower>(actor.Creature));             }             var baseLife=EndHealth(root);int hand=HandValue(root.State.GetPlayerCombatState(actor).Hand.Cards,initial);                          var front=new List<Branch>{new(root,[],0)};var chosen=front[0];var visited=new Dictionary<string,decimal>();             for(int depth=0;depth<24&&front.Count>0;depth++){                 var layer=new List<Branch>();                 foreach(var parent in front){                     var ps=parent.Sim.State.GetPlayerCombatState(actor);                     for(int i=0;i<ps.Hand.Cards.Count;i++){                         if(expanded>0&&clock.Elapsed.TotalMilliseconds>=18+6*_tier)return chosen;                         var move=ps.Hand.Cards[i];if(!parent.Sim.CanPlay(move))continue;                         foreach(var aim in move.Preview.TargetType==TargetType.AnyEnemy?aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>():new Creature?[]{move.Preview.TargetType is TargetType.AnyAlly or TargetType.Self?actor.Creature:null}){                         var sim=parent.Sim.Fork();var mark=Damage.GetOrCreateValue(sim);mark.Copy(Damage.GetOrCreateValue(parent.Sim));                         var handState=sim.State.GetPlayerCombatState(actor);var card=handState.Hand.Cards[i];                                                  expanded++;                         var combat=(SimulatedCombatState)sim.State.CombatState;                         combat.BeginActionChoices((IReadOnlyList<PlanCardChoice>?)null);                         _move=mark;try{if(!sim.ManualPlay(card,aim,out _)||sim.HasPendingChoice||sim.HasRisk&&PredictionCoverage.Collect(sim).Any(g=>!g.Compensated))continue;}                         catch(PredictionUnsupportedException){continue;}                         finally{_move=null;combat.EndActionChoices();}                         var own=sim.State.GetCreature(actor.Creature);                         var life=EndHealth(sim);                         // 当回合可以安全建立的能力也有价值。计分只影响路线排序，不额外搜索未来回合。                         decimal setup=parent.Setup;                         if(_tier>0&&card.Preview.Type==CardType.Power){                             bool core=_setup.Contains(card.Preview.Id.Entry);                             setup+=core?5+3*_tier:2+_tier;                         }                         decimal pressure=0;bool lethal=true;                         foreach(var target in targets){                             var foe=root.State.GetCreature(target);var enemy=sim.State.GetCreature(target);int hp=foe.CurrentHp;                             decimal attack=mark.Hits.GetValueOrDefault(target),hit=attack+hp-enemy.CurrentHp;                             int stacked=combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target);                             pressure+=(combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit);                             if(stacked>0&&stacked>=enemy.CurrentHp-Math.Max(0,attack-foe.Block)&&life>0)pressure+=hp;                             lethal&=hit>=hp+foe.Block;                         }                         decimal score=pressure+setup+(life-baseLife)*1.6m+(life>0&&baseLife<=0?10000:life<=0&&baseLife>0?-10000:0)                             +(HandValue(handState.Hand.Cards,combat)-hand)*.8m                             +(handState.Energy-liveEnergy)*1.25m+(handState.Stars-liveStars)*.5m                             + (parent.Route.Count+1)*.03m;                         var route=new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1))};var b=new Branch(sim,route,score,setup);                         if(score>chosen.Score||chosen.Route.Count==0)chosen=b;                         if(lethal&&life>0)return chosen;                         string Codes(IEnumerable<PredictedCard> pile)=>string.Join(',',pile.Select(c=>c.Preview.IsUpgraded?c.Preview.Id.Entry+"+":c.Preview.Id.Entry));                         string key=handState.Energy+"/"+handState.Stars+"/"+own.Block+"/"+Codes(handState.Hand.Cards)+"/"+Codes(handState.DrawPile.Cards)+"/"+Codes(handState.DiscardPile.Cards);                         if(visited.TryGetValue(key,out var old)&&old>=score)continue;visited[key]=score;layer.Add(b);                         }                     }                 }                 front=layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList();             }             return chosen;             }finally{if(report!=null){searchMs=Stopwatch.GetElapsedTime(started).TotalMilliseconds;searchBytes=GC.GetAllocatedBytesForCurrentThread()-allocated;}}         })`
- `Take()`；输入表达式：`Take()`；返回值紧邻使用处：`IsPatternExpressionSyntax: Take() is {} next`
- `Take()`；输入表达式：`Take()`；返回值紧邻使用处：`ReturnStatementSyntax: return Take();`

**赋值（含属性/字段和局部值）：**

- `_move` = `mark`
- `_move` = `null`
- `chosen` = `b`
- `front` = `layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList()`
- `lethal` &= `hit>=hp+foe.Block`
- `pressure` += `(combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit)`
- `pressure` += `hp`
- `searchBytes` = `GC.GetAllocatedBytesForCurrentThread()-allocated`
- `searchMs` = `Stopwatch.GetElapsedTime(started).TotalMilliseconds`
- `setup` += `core?5+3*_tier:2+_tier`
- `var (root,targets)` = `Capture(amounts.Any(v=>v>0))`
- `visited[key]` = `score`

<a id="symbol-e389eacf5382"></a>

## `Take() — CardModel? Take()`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[])`](LeagueForecast.cs.md#symbol-9ae84c39d167)

**调用：** `MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Queue<T>.TryDequeue(out T)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._route`；`NationalSpire.Solver.LeagueForecast.LastAim`；`NationalSpire.Solver.LeagueForecast.Play.Aim`；`NationalSpire.Solver.LeagueForecast.Play.Id`；`NationalSpire.Solver.LeagueForecast.Play.Level`；`NationalSpire.Solver.LeagueForecast.Play.Live`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；输入表达式：`c.CanPlay()`；返回值紧邻使用处：`BinaryExpressionSyntax: (next.Live==null?c.Id.Entry==next.Id:ReferenceEquals(c,next.Live))&&c.CurrentUpgradeLevel==next.Level&&c.CanPlay()`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(c,next.Live)`；返回值紧邻使用处：`ConditionalExpressionSyntax: next.Live==null?c.Id.Entry==next.Id:ReferenceEquals(c,next.Live)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`realHand.FirstOrDefault(c=>(next.Live==null?c.Id.Entry==next.Id:ReferenceEquals(c,next.Live))&&c.CurrentUpgradeLevel==next.Level&&c.CanPlay())`；返回值紧邻使用处：`ReturnStatementSyntax: return realHand.FirstOrDefault(c=>(next.Live==null?c.Id.Entry==next.Id:ReferenceEquals(c,next.Live))&&c.CurrentUpgradeLevel==next.Level&&c.CanPlay());`
- `System.Collections.Generic.Queue<T>.TryDequeue(out T)`；输入表达式：`_route.TryDequeue(out var next)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_route.TryDequeue(out var next)`

**赋值（含属性/字段和局部值）：**

- `LastAim` = `next.Aim`

<a id="symbol-67b8dece69f8"></a>

## `EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator) — decimal EndHealth(CombatPredictionSimulator sim)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[])`](LeagueForecast.cs.md#symbol-9ae84c39d167)

**调用：** `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Damage(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Fork()`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.Engine.InCombat.Simulation.SimCreatureState.DamageBlock(decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；`CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`System.Math.Max(decimal, decimal)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Damage(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`；输入表达式：`end.Damage([actor.Creature],amounts[k],(ValueProp)properties[k],targets[0],null,null,ModifyDamageHookType.None)`；返回值紧邻使用处：`ExpressionStatementSyntax: end.Damage([actor.Creature],amounts[k],(ValueProp)properties[k],targets[0],null,null,ModifyDamageHookType.None);`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Fork()`；输入表达式：`sim.Fork()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sim.Fork()`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`end.State.GetCreature(actor.Creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =end.State.GetCreature(actor.Creature)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`end.State.GetCreature(actor.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: end.State.GetCreature(actor.Creature).IsAlive`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`sim.State.GetCreature(actor.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sim.State.GetCreature(actor.Creature).CurrentHp`
- `CombatSolver.Engine.InCombat.Simulation.SimCreatureState.DamageBlock(decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；输入表达式：`defending.DamageBlock(amounts[k],ValueProp.Move)`；返回值紧邻使用处：`BinaryExpressionSyntax: amounts[k]-defending.DamageBlock(amounts[k],ValueProp.Move)`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(.1m,defending.CurrentHp-added*.85m)`；返回值紧邻使用处：`ConditionalExpressionSyntax: !defending.IsAlive||held+added>=defending.CurrentHp?0:Math.Max(.1m,defending.CurrentHp-added*.85m)`

**赋值（含属性/字段和局部值）：**

- `added` += `(int)(amounts[k]-defending.DamageBlock(amounts[k],ValueProp.Move))`

<a id="symbol-a330cc419ce8"></a>

## `HandValue(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, CombatSolver.SimulatedCombatState) — int HandValue(IReadOnlyList<PredictedCard> cards,SimulatedCombatState state)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[])`](LeagueForecast.cs.md#symbol-9ae84c39d167)

**调用：** `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetAmount<EcstasyPower>(actor.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: sadness-state.GetAmount<EcstasyPower>(actor.Creature)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,sadness-state.GetAmount<EcstasyPower>(actor.Creature))`；返回值紧邻使用处：`BinaryExpressionSyntax: cards.Count-sadness-Math.Max(0,sadness-state.GetAmount<EcstasyPower>(actor.Creature))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f327865c6573"></a>

## `Codes(System.Collections.Generic.IEnumerable<CombatSolver.Engine.Common.PredictedCard>) — string Codes(IEnumerable<PredictedCard> pile)`

来源：源码第 165 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[])`](LeagueForecast.cs.md#symbol-9ae84c39d167)

**调用：** `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',',pile.Select(c=>c.Preview.IsUpgraded?c.Preview.Id.Entry+"+":c.Preview.Id.Entry))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>string.Join(',',pile.Select(c=>c.Preview.IsUpgraded?c.Preview.Id.Entry+"+":c.Preview.Id.Entry))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`pile.Select(c=>c.Preview.IsUpgraded?c.Preview.Id.Entry+"+":c.Preview.Id.Entry)`；返回值紧邻使用处：`ArgumentSyntax: pile.Select(c=>c.Preview.IsUpgraded?c.Preview.Id.Entry+"+":c.Preview.Id.Entry)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1c0fdc3118f7"></a>

## `NationalSpire.Solver.LeagueForecast.Capture(bool) — private (CombatPredictionSimulator,Creature[]) Capture(bool attacking)`

来源：源码第 183 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[])`](LeagueForecast.cs.md#symbol-9ae84c39d167)

**调用：** [`Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueForecast.cs.md#symbol-caff8847f109)；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.CombatPredictionSimulator(MegaCrit.Sts2.Core.Combat.ICombatState)`；`CombatSolver.SimulatedCombatState.SimulatedCombatState(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Models.AbstractModel[]?)`；`HarmonyLib.AccessTools.Field(System.Type, string)`；`MegaCrit.Sts2.Core.Combat.CombatState.AddCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Combat.CombatState.AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Combat.CombatState.AddPlayer(MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Combat.CombatState.CombatState(MegaCrit.Sts2.Core.Models.EncounterModel?, MegaCrit.Sts2.Core.Runs.IRunState?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel>?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RunModel>?, MegaCrit.Sts2.Core.Models.Dread.DominionModel?)`；`MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature(MegaCrit.Sts2.Core.Models.MonsterModel, MegaCrit.Sts2.Core.Combat.CombatSide, string?)`；`MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Entities.Cards.CardPile.AddInternal(MegaCrit.Sts2.Core.Models.CardModel, int, bool)`；`MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot.ArrowSlot(MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.AddCapacity(int)`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.Clear()`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.Insert(int, MegaCrit.Sts2.Core.Models.OrbModel)`；`MegaCrit.Sts2.Core.Entities.Players.Player.AddRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel, int, bool)`；`MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；`MegaCrit.Sts2.Core.Entities.Players.Player.RemoveRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel, bool)`；`MegaCrit.Sts2.Core.Entities.Players.Player.ResetCombatState()`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AddPetInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.GainEnergy(decimal)`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.GainStars(decimal)`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.IncrementTurnNumber()`；`MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；`MegaCrit.Sts2.Core.Models.ActModel.ToMutable()`；`MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；`MegaCrit.Sts2.Core.Models.MonsterModel.RollMove(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；`MegaCrit.Sts2.Core.Models.MonsterModel.SetUpForCombat()`；`MegaCrit.Sts2.Core.Models.MonsterModel.ToMutable()`；`MegaCrit.Sts2.Core.Models.RelicModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic)`；`MegaCrit.Sts2.Core.Models.RelicModel.ToSerializable()`；`MegaCrit.Sts2.Core.Runs.RunState.CreateForNewRun(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, MegaCrit.Sts2.Core.Runs.GameMode, bool, int, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Reflection.FieldInfo.GetValue(object?)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`

**字段、属性、事件及方法组引用：** `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.Solver.LeagueForecast._actor`；`NationalSpire.Solver.LeagueForecast._aims`；`NationalSpire.Solver.LeagueForecast._live`；`NationalSpire.Solver.LeagueForecast._originals`；`NationalSpire.Solver.LeagueForecast.Damage`；`NationalSpire.Solver.LeagueForecast.liveEnergy`；`NationalSpire.Solver.LeagueForecast.liveStars`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.CombatPredictionSimulator(MegaCrit.Sts2.Core.Combat.ICombatState)`；输入表达式：`new CombatPredictionSimulator(new SimulatedCombatState(board))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CombatPredictionSimulator(new SimulatedCombatState(board))`
- `CombatSolver.SimulatedCombatState.SimulatedCombatState(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Models.AbstractModel[]?)`；输入表达式：`new SimulatedCombatState(board)`；返回值紧邻使用处：`ArgumentSyntax: new SimulatedCombatState(board)`
- `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Copy(_live.Creature,actor.Creature)`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(_live.Creature,actor.Creature);`
- `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Copy(realPet,pet)`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(realPet,pet);`
- `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Copy(realTargets[i],targets[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(realTargets[i],targets[i]);`
- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(PlayerCombatState),"_arrows")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Field(typeof(PlayerCombatState),"_arrows").GetValue`
- `MegaCrit.Sts2.Core.Combat.CombatState.AddCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`board.AddCard(card,actor)`；返回值紧邻使用处：`ExpressionStatementSyntax: board.AddCard(card,actor);`
- `MegaCrit.Sts2.Core.Combat.CombatState.AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`board.AddCreature(pet)`；返回值紧邻使用处：`ExpressionStatementSyntax: board.AddCreature(pet);`
- `MegaCrit.Sts2.Core.Combat.CombatState.AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`board.AddCreature(target)`；返回值紧邻使用处：`ExpressionStatementSyntax: board.AddCreature(target);`
- `MegaCrit.Sts2.Core.Combat.CombatState.AddPlayer(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`board.AddPlayer(actor)`；返回值紧邻使用处：`ExpressionStatementSyntax: board.AddPlayer(actor);`
- `MegaCrit.Sts2.Core.Combat.CombatState.CombatState(MegaCrit.Sts2.Core.Models.EncounterModel?, MegaCrit.Sts2.Core.Runs.IRunState?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel>?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RunModel>?, MegaCrit.Sts2.Core.Models.Dread.DominionModel?)`；输入表达式：`new CombatState(runState:run,badgeModels:run.BadgeModels,runModels:run.RunModels)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CombatState(runState:run,badgeModels:run.BadgeModels,runModels:run.RunModels)`
- `MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature(MegaCrit.Sts2.Core.Models.MonsterModel, MegaCrit.Sts2.Core.Combat.CombatSide, string?)`；输入表达式：`board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null)`
- `MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature(MegaCrit.Sts2.Core.Models.MonsterModel, MegaCrit.Sts2.Core.Combat.CombatSide, string?)`；输入表达式：`board.CreateCreature(ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable(),CombatSide.Player,null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =board.CreateCreature(ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable(),CombatSide.Player,null)`
- `MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`_live.Creature.CombatState!.GetOpponentsOf(_live.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where`
- `MegaCrit.Sts2.Core.Entities.Cards.CardPile.AddInternal(MegaCrit.Sts2.Core.Models.CardModel, int, bool)`；输入表达式：`dest.AddInternal(card,-1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: dest.AddInternal(card,-1,true);`
- `MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot.ArrowSlot(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`new ArrowSlot(actor){Status=slot.Status,DestroyAfterImpaled=slot.DestroyAfterImpaled}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ArrowSlot(actor){Status=slot.Status,DestroyAfterImpaled=slot.DestroyAfterImpaled}`
- `MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.AddCapacity(int)`；输入表达式：`ps.OrbQueue.AddCapacity(old.OrbQueue.Capacity-ps.OrbQueue.Capacity)`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.OrbQueue.AddCapacity(old.OrbQueue.Capacity-ps.OrbQueue.Capacity);`
- `MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.Clear()`；输入表达式：`ps.OrbQueue.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.OrbQueue.Clear();`
- `MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.Insert(int, MegaCrit.Sts2.Core.Models.OrbModel)`；输入表达式：`ps.OrbQueue.Insert(ps.OrbQueue.Orbs.Count,clone)`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.OrbQueue.Insert(ps.OrbQueue.Orbs.Count,clone);`
- `MegaCrit.Sts2.Core.Entities.Players.Player.AddRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel, int, bool)`；输入表达式：`actor.AddRelicInternal(RelicModel.FromSerializable(r.ToSerializable()),-1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: actor.AddRelicInternal(RelicModel.FromSerializable(r.ToSerializable()),-1,true);`
- `MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；输入表达式：`Player.CreateForNewRun(_live.Character,_live.UnlockState,1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Player.CreateForNewRun(_live.Character,_live.UnlockState,1)`
- `MegaCrit.Sts2.Core.Entities.Players.Player.RemoveRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel, bool)`；输入表达式：`actor.RemoveRelicInternal(r,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: actor.RemoveRelicInternal(r,true);`
- `MegaCrit.Sts2.Core.Entities.Players.Player.ResetCombatState()`；输入表达式：`actor.ResetCombatState()`；返回值紧邻使用处：`ExpressionStatementSyntax: actor.ResetCombatState();`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AddPetInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`ps.AddPetInternal(pet)`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.AddPetInternal(pet);`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.GainEnergy(decimal)`；输入表达式：`ps.GainEnergy(old.Energy-ps.Energy)`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.GainEnergy(old.Energy-ps.Energy);`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.GainStars(decimal)`；输入表达式：`ps.GainStars(old.Stars-ps.Stars)`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.GainStars(old.Stars-ps.Stars);`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.IncrementTurnNumber()`；输入表达式：`ps.IncrementTurnNumber()`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.IncrementTurnNumber();`
- `MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；输入表达式：`orb.MutableClone()`；返回值紧邻使用处：`CastExpressionSyntax: (OrbModel)orb.MutableClone()`
- `MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；输入表达式：`original.MutableClone()`；返回值紧邻使用处：`CastExpressionSyntax: (CardModel)original.MutableClone()`
- `MegaCrit.Sts2.Core.Models.ActModel.ToMutable()`；输入表达式：`a.CanonicalInstance.ToMutable()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a=>a.CanonicalInstance.ToMutable()`
- `MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；输入表达式：`ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable`
- `MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；输入表达式：`ModelDb.Monster<MockAttackMonster>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>()`
- `MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；输入表达式：`ModelDb.Monster<MockPlatingMonster>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>()`
- `MegaCrit.Sts2.Core.Models.MonsterModel.RollMove(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；输入表达式：`target.Monster.RollMove([actor.Creature])`；返回值紧邻使用处：`ExpressionStatementSyntax: target.Monster.RollMove([actor.Creature]);`
- `MegaCrit.Sts2.Core.Models.MonsterModel.SetUpForCombat()`；输入表达式：`target.Monster!.SetUpForCombat()`；返回值紧邻使用处：`ExpressionStatementSyntax: target.Monster!.SetUpForCombat();`
- `MegaCrit.Sts2.Core.Models.MonsterModel.ToMutable()`；输入表达式：`enemy.ToMutable()`；返回值紧邻使用处：`ArgumentSyntax: enemy.ToMutable()`
- `MegaCrit.Sts2.Core.Models.MonsterModel.ToMutable()`；输入表达式：`ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable()`；返回值紧邻使用处：`ArgumentSyntax: ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable()`
- `MegaCrit.Sts2.Core.Models.RelicModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic)`；输入表达式：`RelicModel.FromSerializable(r.ToSerializable())`；返回值紧邻使用处：`ArgumentSyntax: RelicModel.FromSerializable(r.ToSerializable())`
- `MegaCrit.Sts2.Core.Models.RelicModel.ToSerializable()`；输入表达式：`r.ToSerializable()`；返回值紧邻使用处：`ArgumentSyntax: r.ToSerializable()`
- `MegaCrit.Sts2.Core.Runs.RunState.CreateForNewRun(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, MegaCrit.Sts2.Core.Runs.GameMode, bool, int, string)`；输入表达式：`RunState.CreateForNewRun([actor],_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList(),[],GameMode.Standard,false,0,"league-forecast")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =RunState.CreateForNewRun([actor],_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList(),[],GameMode.Standard,false,0,"league-forecast")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_originals.Add(card,original)`；返回值紧邻使用处：`ExpressionStatementSyntax: _originals.Add(card,original);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`arrows.Add(slot,next)`；返回值紧邻使用处：`ExpressionStatementSyntax: arrows.Add(slot,next);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<ArrowSlot,ArrowSlot>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<ArrowSlot,ArrowSlot>()`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`ps.AllPiles.First(p=>p.Type==pile.Type)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ps.AllPiles.First(p=>p.Type==pile.Type)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`realTargets.Select(other=>{             MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);             board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;         })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: realTargets.Select(other=>{             MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);             board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;         }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`actor.Relics.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var r in actor.Relics.ToArray())actor.RemoveRelicInternal(r,true);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`realTargets.Select(other=>{             MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);             board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;         }).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =realTargets.Select(other=>{             MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);             board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;         }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList()`；返回值紧邻使用处：`ArgumentSyntax: _live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`slots.Add(next)`；返回值紧邻使用处：`ExpressionStatementSyntax: slots.Add(next);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`slots.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: slots.Clear();`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`AccessTools.Field(typeof(PlayerCombatState),"_arrows").GetValue(ps)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: AccessTools.Field(typeof(PlayerCombatState),"_arrows").GetValue(ps)!`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Damage.GetOrCreateValue(root)`；返回值紧邻使用处：`ExpressionStatementSyntax: Damage.GetOrCreateValue(root);`

**赋值（含属性/字段和局部值）：**

- `_actor` = `actor`
- `_aims[target]` = `checked((int)other.CombatId!.Value)`
- `card.Owner` = `null!`
- `clone.Owner` = `actor`
- `clone.Owner` = `null!`
- `DestroyAfterImpaled` = `slot.DestroyAfterImpaled`
- `liveEnergy` = `old.Energy`
- `liveStars` = `old.Stars`
- `Status` = `slot.Status`

<a id="symbol-caff8847f109"></a>

## `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — void Copy(Creature src,Creature dst)`

来源：源码第 199 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Capture(bool)`](LeagueForecast.cs.md#symbol-1c0fdc3118f7)

**调用：** `MegaCrit.Sts2.Core.Entities.Creatures.Creature.GainBlockInternal(decimal)`；`MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetCurrentHpInternal(decimal)`；`MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetMaxHpInternal(decimal)`；`MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；`MegaCrit.Sts2.Core.Models.PowerModel.ApplyInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, bool)`；`MegaCrit.Sts2.Core.Models.Powers.ImpaledPower.AddArrow(MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot)`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._live`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.GainBlockInternal(decimal)`；输入表达式：`dst.GainBlockInternal(src.Block)`；返回值紧邻使用处：`ExpressionStatementSyntax: dst.GainBlockInternal(src.Block);`
- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetCurrentHpInternal(decimal)`；输入表达式：`dst.SetCurrentHpInternal(src.CurrentHp)`；返回值紧邻使用处：`ExpressionStatementSyntax: dst.SetCurrentHpInternal(src.CurrentHp);`
- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetMaxHpInternal(decimal)`；输入表达式：`dst.SetMaxHpInternal(src.MaxHp)`；返回值紧邻使用处：`ExpressionStatementSyntax: dst.SetMaxHpInternal(src.MaxHp);`
- `MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；输入表达式：`power.MutableClone()`；返回值紧邻使用处：`CastExpressionSyntax: (PowerModel)power.MutableClone()`
- `MegaCrit.Sts2.Core.Models.PowerModel.ApplyInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, bool)`；输入表达式：`copy.ApplyInternal(dst,power.Amount,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.ApplyInternal(dst,power.Amount,true);`
- `MegaCrit.Sts2.Core.Models.Powers.ImpaledPower.AddArrow(MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot)`；输入表达式：`impaled.AddArrow(arrow)`；返回值紧邻使用处：`ExpressionStatementSyntax: impaled.AddArrow(arrow);`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(realTargets,power.Applier)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Array.IndexOf(realTargets,power.Applier) is int i`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`arrows.TryGetValue(a,out var arrow)`；返回值紧邻使用处：`IfStatementSyntax: if(arrows.TryGetValue(a,out var arrow))impaled.AddArrow(arrow);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`foreign.Arrows.Any(arrows.ContainsKey)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !foreign.Arrows.Any(arrows.ContainsKey)`

**赋值（含属性/字段和局部值）：**

- `copy.Applier` = `power.Applier==_live.Creature?actor.Creature:Array.IndexOf(realTargets,power.Applier) is int i&&i>=0?targets[i]:null`

<a id="symbol-6cb7d1f580d7"></a>

## `NationalSpire.Solver.LeagueForecast.Dispose() — public void Dispose()`

来源：源码第 220 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[])`](LeagueForecast.cs.md#symbol-9ae84c39d167)

**调用：** `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AfterCombatEnd()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._actor`；`NationalSpire.Solver.LeagueForecast._aims`；`NationalSpire.Solver.LeagueForecast._originals`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AfterCombatEnd()`；输入表达式：`.AfterCombatEnd()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .PlayerCombatState?.AfterCombatEnd()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_aims.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _aims.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_originals.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _originals.Clear();`

**赋值（含属性/字段和局部值）：**

- `_actor` = `null`
