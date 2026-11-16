# Compatibility/LeagueSolver/LeagueForecast.cs

[返回文件依赖索引](../../../SOURCE_MAP.md)

源码 SHA-256：`4C858F2A2579E113729B4A6ACE0523EB2DD74A46911BCB2551A3F5FFFA68409B`。来源：[源码](../../../../Compatibility/LeagueSolver/LeagueForecast.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Solver.LeagueForecast`、`NationalSpire.Solver.LeagueForecast.Ledger`、`NationalSpire.Solver.LeagueForecast.Play`、`NationalSpire.Solver.LeagueForecast.Branch`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Player _live;
private readonly int _tier;
private readonly bool _legend;
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
private readonly CancellationToken _exit;
[ThreadStatic] private static Ledger? _move;
[ThreadStatic] private static (Creature? Dealer,Creature? Target) _incoming;
private int liveEnergy,liveStars;
private readonly Dictionary<Creature,int> _aims=[];
```

<a id="symbol-9ecdb20e5b06"></a>

## `NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger) — internal void Copy(Ledger src)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, out NationalSpire.Solver.LeagueForecast.Ledger, out int)`](LeagueForecast.cs.md#symbol-5ad747f95c4c)；[`NationalSpire.Solver.LeagueForecast.PlayOptions(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, int, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Players.Player, int, System.Func<bool>, System.Action)`](LeagueForecast.Choices.cs.md#symbol-0be8b41d9374)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.Ledger.Hits`；`NationalSpire.Solver.LeagueForecast.Ledger.Stacks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `Hits[p.Key]` = `p.Value`
- `Stacks[p.Key]` = `p.Value`

<a id="symbol-a574f29e7b90"></a>

## `NationalSpire.Solver.LeagueForecast.LastChoices — public int[] LastChoices`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-40dd0840824d"></a>

## `NationalSpire.Solver.LeagueForecast.Continuation() — public (CardModel,int,int[])[] Continuation()`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeWhile<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.Queue<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._route`；`NationalSpire.Solver.LeagueForecast.Play.Aim`；`NationalSpire.Solver.LeagueForecast.Play.Choices`；`NationalSpire.Solver.LeagueForecast.Play.Live`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_route.TakeWhile(x=>x.Live!=null).Select(x=>(x.Live!,x.Aim,x.Choices))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _route.TakeWhile(x=>x.Live!=null).Select(x=>(x.Live!,x.Aim,x.Choices)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.TakeWhile<TSource>(System.Func<TSource, bool>)`；输入表达式：`_route.TakeWhile(x=>x.Live!=null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _route.TakeWhile(x=>x.Live!=null).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_route.TakeWhile(x=>x.Live!=null).Select(x=>(x.Live!,x.Aim,x.Choices)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_route.TakeWhile(x=>x.Live!=null).Select(x=>(x.Live!,x.Aim,x.Choices)).ToArray()`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_route.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _route.Clear();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-09c85ea08804"></a>

## `NationalSpire.Solver.LeagueForecast.LastAim — public int LastAim`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-12efc28d9ce8"></a>

## `NationalSpire.Solver.LeagueForecast.EndTurn — public bool EndTurn`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0b56edd1208e"></a>

## `NationalSpire.Solver.LeagueForecast.LeagueForecast(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], System.Func<int, int>, int, System.Threading.CancellationToken) — public LeagueForecast(Player rival,int tier,string[] setup,Func<int,int> addedDoom,int preference,CancellationToken exit=default)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Solver.LeagueForecast.Prepare()`](LeagueForecast.cs.md#symbol-f2559c94c021)；`System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEnumerable<T>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._addedDoom`；`NationalSpire.Solver.LeagueForecast._exit`；`NationalSpire.Solver.LeagueForecast._legend`；`NationalSpire.Solver.LeagueForecast._live`；`NationalSpire.Solver.LeagueForecast._preferredTarget`；`NationalSpire.Solver.LeagueForecast._setup`；`NationalSpire.Solver.LeagueForecast._tier`；`NationalSpire.Solver.LeagueForecast.Prepare()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Solver.LeagueForecast.Prepare()`；输入表达式：`Prepare()`；返回值紧邻使用处：`ExpressionStatementSyntax: Prepare();`
- `System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new(setup)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _setup=new(setup)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(tier,2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _tier=Math.Min(tier,2)`

**赋值（含属性/字段和局部值）：**

- `_addedDoom` = `addedDoom`
- `_exit` = `exit`
- `_legend` = `tier==3`
- `_live` = `rival`
- `_preferredTarget` = `preference`
- `_setup` = `new(setup)`
- `_tier` = `Math.Min(tier,2)`

<a id="symbol-f2559c94c021"></a>

## `NationalSpire.Solver.LeagueForecast.Prepare() — public static void Prepare()`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.LeagueForecast(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], System.Func<int, int>, int, System.Threading.CancellationToken)`](LeagueForecast.cs.md#symbol-0b56edd1208e)

**调用：** [`NationalSpire.Solver.LeagueForecast.InstallProjection(HarmonyLib.Harmony)`](LeagueForecast.Projection.cs.md#symbol-71f51d5d4f7c)；`HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertySetter(System.Type, string)`；`HarmonyLib.Harmony.Harmony(string)`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.IEnumerable.Cast<TResult>()`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`；`System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(System.Type)`；`System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(System.RuntimeMethodHandle)`；`System.Type.GetConstructors()`；`System.Type.GetMethods(System.Reflection.BindingFlags)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueOwnTurnLoss.Effects`；`NationalSpire.Solver.LeagueForecast._installed`；`NationalSpire.Solver.LeagueForecast.InstallProjection(HarmonyLib.Harmony)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(AfterCardPlayedMirrors),"HandleStranglePower")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(AfterCardPlayedMirrors),"HandleStranglePower")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(AfterDamageReceivedMirrors),"Handle"+effect.Name)`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(AfterDamageReceivedMirrors),"Handle"+effect.Name)`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(PowerLifecycleSupport),"ResolvePowerAmountChanges")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(PowerLifecycleSupport),"ResolvePowerAmountChanges")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(CombatPredictionSimulator),"Damage",[typeof(IReadOnlyList<Creature>),typeof(decimal),typeof(ValueProp),typeof(Creature),typeof(PredictedCard),typeof(CardPlay),typeof(ModifyDamageHookType)])`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.Method(typeof(CombatPredictionSimulator),"Damage",[typeof(IReadOnlyList<Creature>),typeof(decimal),typeof(ValueProp),typeof(Creature),typeof(PredictedCard),typeof(CardPlay),typeof(ModifyDamageHookType)])`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(CombatSolverLog),"Write")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(CombatSolverLog),"Write")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(PredictionModPatchAudit),"TryDescribeForeignPatch")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(PredictionModPatchAudit),"TryDescribeForeignPatch")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(RootCombatHistorySnapshot),"Capture")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(RootCombatHistorySnapshot),"Capture")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(SimulatedCombatState),"ModifyPowerAmountForRelics")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(SimulatedCombatState),"ModifyPowerAmountForRelics")`
- `HarmonyLib.AccessTools.PropertySetter(System.Type, string)`；输入表达式：`AccessTools.PropertySetter(typeof(Entry),"Logger")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.PropertySetter(typeof(Entry),"Logger").Invoke`
- `HarmonyLib.Harmony.Harmony(string)`；输入表达式：`new Harmony("nationalspire.league.forecast")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Harmony("nationalspire.league.forecast")`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.DeclaredMethod(typeof(AfterCardPlayedMirrors),"HandleStranglePower"),transpiler:new HarmonyMethod(typeof(LeagueForecast),nameof(StrangleSource)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.DeclaredMethod(typeof(AfterCardPlayedMirrors),"HandleStranglePower"),transpiler:new HarmonyMethod(typeof(LeagueForecast),nameof(StrangleSource)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.DeclaredMethod(typeof(AfterDamageReceivedMirrors),"Handle"+effect.Name),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(OwnTurnLoss)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.DeclaredMethod(typeof(AfterDamageReceivedMirrors),"Handle"+effect.Name),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(OwnTurnLoss)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.DeclaredMethod(typeof(PowerLifecycleSupport),"ResolvePowerAmountChanges"),transpiler:new HarmonyMethod(typeof(LeagueForecast),nameof(FleshSource)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.DeclaredMethod(typeof(PowerLifecycleSupport),"ResolvePowerAmountChanges"),transpiler:new HarmonyMethod(typeof(LeagueForecast),nameof(FleshSource)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.Method(typeof(CombatSolverLog),"Write"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(DebugOutput)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.Method(typeof(CombatSolverLog),"Write"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(DebugOutput)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.Method(typeof(PredictionModPatchAudit),"TryDescribeForeignPatch"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(MirroredIntent)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.Method(typeof(PredictionModPatchAudit),"TryDescribeForeignPatch"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(MirroredIntent)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.Method(typeof(RootCombatHistorySnapshot),"Capture"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(UseMappedHistory)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.Method(typeof(RootCombatHistorySnapshot),"Capture"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(UseMappedHistory)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.Method(typeof(SimulatedCombatState),"ModifyPowerAmountForRelics"),postfix:new HarmonyMethod(typeof(LeagueForecast),nameof(SimDoom)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.Method(typeof(SimulatedCombatState),"ModifyPowerAmountForRelics"),postfix:new HarmonyMethod(typeof(LeagueForecast),nameof(SimDoom)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(method,prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(Intent)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(method,prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(Intent)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(DebugOutput))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(DebugOutput))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(FleshSource))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueForecast),nameof(FleshSource))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(Intent))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(Intent))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(MirroredIntent))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(MirroredIntent))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(OwnTurnLoss))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(OwnTurnLoss))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(SimDoom))`；返回值紧邻使用处：`ArgumentSyntax: postfix:new HarmonyMethod(typeof(LeagueForecast),nameof(SimDoom))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(StrangleSource))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueForecast),nameof(StrangleSource))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(UseMappedHistory))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(UseMappedHistory))`
- `NationalSpire.Solver.LeagueForecast.InstallProjection(HarmonyLib.Harmony)`；输入表达式：`InstallProjection(harmony)`；返回值紧邻使用处：`ExpressionStatementSyntax: InstallProjection(harmony);`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`type.GetMethods(System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.DeclaredOnly).Cast<System.Reflection.MethodBase>().Concat(type.GetConstructors())`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var m in type.GetMethods(System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.DeclaredOnly).Cast<System.Reflection.MethodBase>().Concat(type.GetConstructors()))                  if(!m.ContainsGenericParameters && !m.IsAbstract && (m.IsConstructor||m.Name is "Capture" or "ManualPlay" or "Fork" or "CanPlay" or "Damage"))                      RuntimeHelpers.PrepareMethod(m.MethodHandle);`
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

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Diagnostics.Debug.WriteLine(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Diagnostics.Debug.WriteLine(string?)`；输入表达式：`Debug.WriteLine(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: Debug.WriteLine(message);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-40c880ec0bdb"></a>

## `NationalSpire.Solver.LeagueForecast.OwnTurnLoss(CombatSolver.Engine.InCombat.Mirrors.Hooks.Damage.AfterDamageReceivedMirrorContext) — private static bool OwnTurnLoss(AfterDamageReceivedMirrorContext context)`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `(MegaCrit.Sts2.Core.Entities.Creatures.Creature? Dealer, MegaCrit.Sts2.Core.Entities.Creatures.Creature? Target).Dealer`；`(MegaCrit.Sts2.Core.Entities.Creatures.Creature? Dealer, MegaCrit.Sts2.Core.Entities.Creatures.Creature? Target).Target`；`NationalSpire.Solver.LeagueForecast._incoming`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-16de46b59acf"></a>

## `NationalSpire.Solver.LeagueForecast.SimDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref int) — private static void SimDoom(PowerModel power,Creature target,Creature? applier,ref int __result)`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ea0ad41d99dc"></a>

## `NationalSpire.Solver.LeagueForecast.StrangleSource(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>) — private static IEnumerable<CodeInstruction> StrangleSource(IEnumerable<CodeInstruction> code)`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；`HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；`HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueForecast),nameof(StrangleIntent))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(LeagueForecast),nameof(StrangleIntent))`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(System.Reflection.Emit.OpCodes.Call,AccessTools.Method(typeof(LeagueForecast),nameof(StrangleIntent)))`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(System.Reflection.Emit.OpCodes.Call,AccessTools.Method(typeof(LeagueForecast),nameof(StrangleIntent)));`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0).MoveLabelsFrom`
- `HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；输入表达式：`new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);`
- `HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；输入表达式：`new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0).MoveLabelsFrom(i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`IsPatternExpressionSyntax: m.GetParameters() is [var first,_,_,_]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7e85e324168b"></a>

## `NationalSpire.Solver.LeagueForecast.StrangleIntent(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.Powers.StranglePower) — private static IReadOnlyList<DamageResult> StrangleIntent(CombatPredictionSimulator sim,Creature target,decimal amount,ValueProp props,Creature? dealer,StranglePower power)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Solver.LeagueForecast.PowerIntent(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](LeagueForecast.cs.md#symbol-7a755a8721d9)

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.PowerIntent(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Solver.LeagueForecast.PowerIntent(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`PowerIntent(sim,target,amount,props&~ValueProp.Unblockable,power.Applier??dealer)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>          PowerIntent(sim,target,amount,props&~ValueProp.Unblockable,power.Applier??dealer)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-22b118bdea4b"></a>

## `NationalSpire.Solver.LeagueForecast.FleshSource(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>) — private static IEnumerable<CodeInstruction> FleshSource(IEnumerable<CodeInstruction> code)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`object.Equals(object?, object?)`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueForecast),nameof(PowerIntent))`；返回值紧邻使用处：`AssignmentExpressionSyntax: i.operand=AccessTools.Method(typeof(LeagueForecast),nameof(PowerIntent))`
- `object.Equals(object?, object?)`；输入表达式：`Equals(i.operand,nameof(SleightOfFleshPower))`；返回值紧邻使用处：`BinaryExpressionSyntax: i.opcode==System.Reflection.Emit.OpCodes.Ldstr&&Equals(i.operand,nameof(SleightOfFleshPower))`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`IsPatternExpressionSyntax: m.GetParameters() is [var t,_,_,_]`

**赋值（含属性/字段和局部值）：**

- `flesh` = `false`
- `flesh` = `true`
- `i.opcode` = `System.Reflection.Emit.OpCodes.Call`
- `i.operand` = `AccessTools.Method(typeof(LeagueForecast),nameof(PowerIntent))`

<a id="symbol-7a755a8721d9"></a>

## `NationalSpire.Solver.LeagueForecast.PowerIntent(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?) — private static IReadOnlyList<DamageResult> PowerIntent(CombatPredictionSimulator sim,Creature target,decimal amount,ValueProp props,Creature? dealer)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.StrangleIntent(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.Powers.StranglePower)`](LeagueForecast.cs.md#symbol-7e85e324168b)

**调用：** `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Damage(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Damage(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`；输入表达式：`sim.Damage([target],amount,props,dealer,null,null)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>          sim.Damage([target],amount,props,dealer,null,null)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1ac552693ff5"></a>

## `NationalSpire.Solver.LeagueForecast.Intent(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>) — private static bool Intent(CombatPredictionSimulator __instance,IReadOnlyList<Creature> targets,decimal amount,ValueProp props,Creature? dealer,          PredictedCard? cardSource,CardPlay? cardPlay,ModifyDamageHookType modifyDamageHookType,ref IReadOnlyList<DamageResult> __result)`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `CombatSolver.Engine.InCombat.Mirrors.HookMirrors.ModifyDamage(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.ResolveDamageSource(CombatSolver.Engine.Common.PredictedCard?)`；`MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Entities.Creatures.DamageResult.DamageResult(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(decimal, decimal)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.Damage`；`NationalSpire.Solver.LeagueForecast.Ledger.Hits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.Engine.InCombat.Mirrors.HookMirrors.ModifyDamage(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`；输入表达式：`HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType&~ModifyDamageHookType.Cap)`；返回值紧邻使用处：`ArgumentSyntax: HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType&~ModifyDamageHookType.Cap)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.ResolveDamageSource(CombatSolver.Engine.Common.PredictedCard?)`；输入表达式：`__instance.ResolveDamageSource(cardSource)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: __instance.ResolveDamageSource(cardSource).Kind`
- `MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`__instance.State.CombatState.GetOpponentsOf(targets[0])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: __instance.State.CombatState.GetOpponentsOf(targets[0]).FirstOrDefault`
- `MegaCrit.Sts2.Core.Entities.Creatures.DamageResult.DamageResult(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；输入表达式：`new DamageResult(t,props)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t=>new DamageResult(t,props)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`targets.Any(t=>t.Side==dealer.Side)`；返回值紧邻使用处：`BinaryExpressionSyntax: dealer==null||targets.Any(t=>t.Side==dealer.Side)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`__instance.State.CombatState.GetOpponentsOf(targets[0]).FirstOrDefault(c=>c.IsAlive)`；返回值紧邻使用处：`AssignmentExpressionSyntax: dealer=__instance.State.CombatState.GetOpponentsOf(targets[0]).FirstOrDefault(c=>c.IsAlive)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`targets.Select(t=>new DamageResult(t,props))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: targets.Select(t=>new DamageResult(t,props)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`targets.Select(t=>new DamageResult(t,props)).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=targets.Select(t=>new DamageResult(t,props)).ToArray()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`log.Hits.GetValueOrDefault(t)`；返回值紧邻使用处：`BinaryExpressionSyntax: log.Hits.GetValueOrDefault(t)+value`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0,HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType&~ModifyDamageHookType.Cap))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(0,HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType&~ModifyDamageHookType.Cap))`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Damage.TryGetValue(__instance,out var log)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Damage.TryGetValue(__instance,out var log)`

**赋值（含属性/字段和局部值）：**

- `__result` = `targets.Select(t=>new DamageResult(t,props)).ToArray()`
- `dealer` = `__instance.State.CombatState.GetOpponentsOf(targets[0]).FirstOrDefault(c=>c.IsAlive)`
- `log.Hits[t]` = `log.Hits.GetValueOrDefault(t)+value`
- `props` &= `~ValueProp.Unblockable`

<a id="symbol-25d92d14be68"></a>

## `NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[]) — public async Task<CardModel?> Choose(decimal[] amounts,int[] properties,bool[] capped,int[] dealers)`

来源：源码第 137 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, out NationalSpire.Solver.LeagueForecast.Ledger, out int)`](LeagueForecast.cs.md#symbol-5ad747f95c4c)；[`HandValue(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, CombatSolver.SimulatedCombatState)`](LeagueForecast.cs.md#symbol-6fe64af03c5c)；[`ImprovesStatus()`](LeagueForecast.cs.md#symbol-7198ff2a64ff)；[`LivingPet(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`](LeagueForecast.cs.md#symbol-61226e5575f6)；[`MelodyChance(MegaCrit.Sts2.Core.Entities.Cards.CardTag)`](LeagueForecast.cs.md#symbol-4497d59a5f80)；[`NationalSpire.Solver.LeagueForecast.Capture(bool)`](LeagueForecast.cs.md#symbol-1c0fdc3118f7)；[`NationalSpire.Solver.LeagueForecast.Dispose()`](LeagueForecast.cs.md#symbol-6cb7d1f580d7)；[`NationalSpire.Solver.LeagueForecast.PlayOptions(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, int, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Players.Player, int, System.Func<bool>, System.Action)`](LeagueForecast.Choices.cs.md#symbol-0be8b41d9374)；[`OutOfTime()`](LeagueForecast.cs.md#symbol-3218bef2d5b1)；[`Pile(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`](LeagueForecast.cs.md#symbol-e81d6412b9f1)；[`Reach(int)`](LeagueForecast.cs.md#symbol-432f6cb0ae06)；[`Setup(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`](LeagueForecast.cs.md#symbol-0fd555495aa8)；[`Take()`](LeagueForecast.cs.md#symbol-da6318aedee4)；`CombatSolver.Engine.InCombat.Mirrors.Orbs.OrbMirrors.GetEvokeValue(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Models.OrbModel)`；`CombatSolver.Engine.InCombat.Mirrors.Orbs.OrbMirrors.GetPassiveValue(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Models.OrbModel)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.CanPlay(CombatSolver.Engine.Common.PredictedCard)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；`CombatSolver.SimulatedCombatState.EffectivePowers()`；`CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.SimulatedCombatState.GetOstyMaxHp(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Players.Player)`；`CombatSolver.StateFingerprintBuilder.Add(decimal)`；`CombatSolver.StateFingerprintBuilder.Add(int)`；`CombatSolver.StateFingerprintBuilder.Add(string?)`；`CombatSolver.StateFingerprintBuilder.Add(uint)`；`CombatSolver.StateFingerprintBuilder.Finish()`；`CombatSolver.StateFingerprintBuilder.StateFingerprintBuilder()`；`CombatSolver.StrategicEffectContext.Build(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, int, int, int, CombatSolver.StrategicEffectRequirements, bool)`；`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.ContainsKey(string)`；`MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；`NationalSpire.Solver.LeagueForecast.Branch.Branch(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, System.Collections.Generic.List<NationalSpire.Solver.LeagueForecast.Play>, decimal)`；`NationalSpire.Solver.LeagueForecast.Play.Play(MegaCrit.Sts2.Core.Models.CardModel?, string, int, int, int[])`；`object.GetType()`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<decimal>.Sum()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, int, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.List(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Collections.IEnumerable.Cast<TResult>()`；`System.Diagnostics.Stopwatch.GetElapsedTime(long)`；`System.Diagnostics.Stopwatch.GetTimestamp()`；`System.Diagnostics.Stopwatch.StartNew()`；`System.Environment.GetEnvironmentVariable(string)`；`System.GC.GetAllocatedBytesForCurrentThread()`；`System.IO.File.AppendAllText(string, string?)`；`System.IO.Path.Combine(string, string)`；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Max(decimal, decimal)`；`System.Math.Max(int, int)`；`System.Math.Min(decimal, decimal)`；`System.Math.Min(int, int)`；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`；`System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`

**字段、属性、事件及方法组引用：** `EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, out NationalSpire.Solver.LeagueForecast.Ledger, out int)`；`HandValue(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, CombatSolver.SimulatedCombatState)`；`ImprovesStatus()`；`LivingPet(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；`MelodyChance(MegaCrit.Sts2.Core.Entities.Cards.CardTag)`；`NationalSpire.Solver.LeagueForecast._actor`；`NationalSpire.Solver.LeagueForecast._aims`；`NationalSpire.Solver.LeagueForecast._captured`；`NationalSpire.Solver.LeagueForecast._exit`；`NationalSpire.Solver.LeagueForecast._legend`；`NationalSpire.Solver.LeagueForecast._live`；`NationalSpire.Solver.LeagueForecast._originals`；`NationalSpire.Solver.LeagueForecast._preferredTarget`；`NationalSpire.Solver.LeagueForecast._route`；`NationalSpire.Solver.LeagueForecast._tier`；`NationalSpire.Solver.LeagueForecast._unmodelledPlays`；`NationalSpire.Solver.LeagueForecast.Branch.Route`；`NationalSpire.Solver.LeagueForecast.Branch.Score`；`NationalSpire.Solver.LeagueForecast.Branch.Sim`；`NationalSpire.Solver.LeagueForecast.Capture(bool)`；`NationalSpire.Solver.LeagueForecast.Dispose()`；`NationalSpire.Solver.LeagueForecast.EndTurn`；`NationalSpire.Solver.LeagueForecast.Ledger.Hits`；`NationalSpire.Solver.LeagueForecast.Ledger.Stacks`；`NationalSpire.Solver.LeagueForecast.liveEnergy`；`NationalSpire.Solver.LeagueForecast.liveStars`；`NationalSpire.Solver.LeagueForecast.Play.Id`；`NationalSpire.Solver.LeagueForecast.Play.Level`；`NationalSpire.Solver.LeagueForecast.PlayOptions(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, int, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Players.Player, int, System.Func<bool>, System.Action)`；`Order(int)`；`OutOfTime()`；`Pile(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`；`Reach(int)`；`Setup(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；`Take()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.Engine.InCombat.Mirrors.Orbs.OrbMirrors.GetEvokeValue(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Models.OrbModel)`；输入表达式：`OrbMirrors.GetEvokeValue(root,o)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id.Entry+"="+OrbMirrors.GetEvokeValue(root,o)`
- `CombatSolver.Engine.InCombat.Mirrors.Orbs.OrbMirrors.GetEvokeValue(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Models.OrbModel)`；输入表达式：`OrbMirrors.GetEvokeValue(sim,orb)`；返回值紧邻使用处：`ArgumentSyntax: OrbMirrors.GetEvokeValue(sim,orb)`
- `CombatSolver.Engine.InCombat.Mirrors.Orbs.OrbMirrors.GetPassiveValue(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Models.OrbModel)`；输入表达式：`OrbMirrors.GetPassiveValue(sim,orb)`；返回值紧邻使用处：`ArgumentSyntax: OrbMirrors.GetPassiveValue(sim,orb)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.CanPlay(CombatSolver.Engine.Common.PredictedCard)`；输入表达式：`parent.Sim.CanPlay(move)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !parent.Sim.CanPlay(move)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`parent.Sim.State.GetCreature(t)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parent.Sim.State.GetCreature(t).IsAlive`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`root.State.GetCreature(actor.Creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =root.State.GetCreature(actor.Creature)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`root.State.GetCreature(t)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: root.State.GetCreature(t).Block`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`root.State.GetCreature(t)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: root.State.GetCreature(t).CurrentHp`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`root.State.GetCreature(target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =root.State.GetCreature(target)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`sim.State.GetCreature(actor.Creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sim.State.GetCreature(actor.Creature)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`sim.State.GetCreature(target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sim.State.GetCreature(target)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`parent.Sim.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =parent.Sim.State.GetPlayerCombatState(actor)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`root.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =root.State.GetPlayerCombatState(actor)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`root.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: root.State.GetPlayerCombatState(actor).Hand`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`root.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: root.State.GetPlayerCombatState(actor).OrbQueue`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`sim.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sim.State.GetPlayerCombatState(actor)`
- `CombatSolver.SimulatedCombatState.EffectivePowers()`；输入表达式：`combat.EffectivePowers()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var power in combat.EffectivePowers()){fingerprint.Add(power.Owner.CombatId??uint.MaxValue);fingerprint.Add(power.Id.Entry);fingerprint.Add(power.Amount);}`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<DoomPower>(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target)`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<DoomPower>(target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =combat.GetAmount<DoomPower>(target)`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<PoisonPower>(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target)`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`initial.GetAmount<CorruptionPower>(actor.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: initial.GetAmount<CorruptionPower>(actor.Creature)>0`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`initial.GetAmount<DoomPower>(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: stacked-initial.GetAmount<DoomPower>(target)`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`initial.GetAmount<PoisonPower>(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target)`
- `CombatSolver.SimulatedCombatState.GetOstyMaxHp(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`combat.GetOstyMaxHp(sim,actor)`；返回值紧邻使用处：`ArgumentSyntax: combat.GetOstyMaxHp(sim,actor)`
- `CombatSolver.StateFingerprintBuilder.Add(decimal)`；输入表达式：`fingerprint.Add(mark.Hits.GetValueOrDefault(target))`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(mark.Hits.GetValueOrDefault(target));`
- `CombatSolver.StateFingerprintBuilder.Add(decimal)`；输入表达式：`fingerprint.Add(OrbMirrors.GetEvokeValue(sim,orb))`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(OrbMirrors.GetEvokeValue(sim,orb));`
- `CombatSolver.StateFingerprintBuilder.Add(decimal)`；输入表达式：`fingerprint.Add(OrbMirrors.GetPassiveValue(sim,orb))`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(OrbMirrors.GetPassiveValue(sim,orb));`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(combat.GetOstyMaxHp(sim,actor))`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(combat.GetOstyMaxHp(sim,actor));`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(handState.Energy)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(handState.Energy);`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(handState.OrbQueue.Capacity)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(handState.OrbQueue.Capacity);`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(handState.Stars)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(handState.Stars);`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(LivingPet(sim))`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(LivingPet(sim));`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(mark.Stacks.GetValueOrDefault(target))`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(mark.Stacks.GetValueOrDefault(target));`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(own.Block)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(own.Block);`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(own.CurrentHp)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(own.CurrentHp);`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(power.Amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(power.Amount);`
- `CombatSolver.StateFingerprintBuilder.Add(string?)`；输入表达式：`fingerprint.Add(orb.Id.Entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(orb.Id.Entry);`
- `CombatSolver.StateFingerprintBuilder.Add(string?)`；输入表达式：`fingerprint.Add(power.Id.Entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(power.Id.Entry);`
- `CombatSolver.StateFingerprintBuilder.Add(uint)`；输入表达式：`fingerprint.Add(power.Owner.CombatId??uint.MaxValue)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(power.Owner.CombatId??uint.MaxValue);`
- `CombatSolver.StateFingerprintBuilder.Finish()`；输入表达式：`fingerprint.Finish()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =fingerprint.Finish()`
- `CombatSolver.StateFingerprintBuilder.StateFingerprintBuilder()`；输入表达式：`new StateFingerprintBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new StateFingerprintBuilder()`
- `CombatSolver.StrategicEffectContext.Build(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, int, int, int, CombatSolver.StrategicEffectRequirements, bool)`；输入表达式：`StrategicEffectContext.Build(cards,targets.Sum(t=>root.State.GetCreature(t).CurrentHp),                  (int)amounts.Where((_,i)=>properties[i]!=-1).Sum(),properties.Count(p=>p!=-1),                  (StrategicEffectRequirements)(-1),initial.GetAmount<CorruptionPower>(actor.Creature)>0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =StrategicEffectContext.Build(cards,targets.Sum(t=>root.State.GetCreature(t).CurrentHp),                  (int)amounts.Where((_,i)=>properties[i]!=-1).Sum(),properties.Count(p=>p!=-1),                  (StrategicEffectRequirements)(-1),initial.GetAmount<CorruptionPower>(actor.Creature)>0)`
- `EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, out NationalSpire.Solver.LeagueForecast.Ledger, out int)`；输入表达式：`EndHealth(root,out var pass,out int basePet)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EndHealth(root,out var pass,out int basePet)`
- `EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, out NationalSpire.Solver.LeagueForecast.Ledger, out int)`；输入表达式：`EndHealth(sim,out var mark,out int petAfterHits)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EndHealth(sim,out var mark,out int petAfterHits)`
- `HandValue(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, CombatSolver.SimulatedCombatState)`；输入表达式：`HandValue(handState.Hand.Cards,combat)`；返回值紧邻使用处：`BinaryExpressionSyntax: HandValue(handState.Hand.Cards,combat)-hand`
- `HandValue(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, CombatSolver.SimulatedCombatState)`；输入表达式：`HandValue(root.State.GetPlayerCombatState(actor).Hand.Cards,initial)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HandValue(root.State.GetPlayerCombatState(actor).Hand.Cards,initial)`
- `ImprovesStatus()`；输入表达式：`ImprovesStatus()`；返回值紧邻使用处：`ConditionalExpressionSyntax: chosen.Route.Count==0?ImprovesStatus():score>chosen.Score`
- `LivingPet(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；输入表达式：`LivingPet(sim)`；返回值紧邻使用处：`ArgumentSyntax: LivingPet(sim)`
- `MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.ContainsKey(string)`；输入表达式：`c.Preview.DynamicVars.ContainsKey("Stars")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>c.Preview.DynamicVars.ContainsKey("Stars")`
- `MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；输入表达式：`c.CanPlay()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>c.CanPlay()`
- `MelodyChance(MegaCrit.Sts2.Core.Entities.Cards.CardTag)`；输入表达式：`MelodyChance(CardTag.Cho)`；返回值紧邻使用处：`BinaryExpressionSyntax: MelodyChance(CardTag.Wah)+MelodyChance(CardTag.Cho)`
- `MelodyChance(MegaCrit.Sts2.Core.Entities.Cards.CardTag)`；输入表达式：`MelodyChance(CardTag.Ki)`；返回值紧邻使用处：`BinaryExpressionSyntax: MelodyChance(CardTag.Wah)+MelodyChance(CardTag.Cho)+MelodyChance(CardTag.Ki)`
- `MelodyChance(MegaCrit.Sts2.Core.Entities.Cards.CardTag)`；输入表达式：`MelodyChance(CardTag.Wah)`；返回值紧邻使用处：`BinaryExpressionSyntax: MelodyChance(CardTag.Wah)+MelodyChance(CardTag.Cho)`
- `NationalSpire.Solver.LeagueForecast.Branch.Branch(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, System.Collections.Generic.List<NationalSpire.Solver.LeagueForecast.Play>, decimal)`；输入表达式：`new Branch(sim,route,score)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Branch(sim,route,score)`
- `NationalSpire.Solver.LeagueForecast.Branch.Branch(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, System.Collections.Generic.List<NationalSpire.Solver.LeagueForecast.Play>, decimal)`；输入表达式：`new(root,[],0)`；返回值紧邻使用处：`InitializerExpressionSyntax: {new(root,[],0)}`
- `NationalSpire.Solver.LeagueForecast.Capture(bool)`；输入表达式：`Capture(amounts.Any(v=>v>0))`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (root,targets)=Capture(amounts.Any(v=>v>0))`
- `NationalSpire.Solver.LeagueForecast.Dispose()`；输入表达式：`Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dispose();`
- `NationalSpire.Solver.LeagueForecast.Play.Play(MegaCrit.Sts2.Core.Models.CardModel?, string, int, int, int[])`；输入表达式：`new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1),choices)`；返回值紧邻使用处：`InitializerExpressionSyntax: {new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1),choices)}`
- `NationalSpire.Solver.LeagueForecast.PlayOptions(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, int, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Players.Player, int, System.Func<bool>, System.Action)`；输入表达式：`PlayOptions(parent.Sim,i,aim,actor,3+2*_tier,OutOfTime,()=>incomplete=true)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var result in PlayOptions(parent.Sim,i,aim,actor,3+2*_tier,OutOfTime,()=>incomplete=true)){                          var (sim,choices)=result;                          var handState=sim.State.GetPlayerCombatState(actor);var card=move;                          expanded++;                          var combat=(SimulatedCombatState)sim.State.CombatState;                          var own=sim.State.GetCreature(actor.Creature);                          var life=EndHealth(sim,out var mark,out int petAfterHits);                          // 已替主人承伤的生命不能重复计分。保留下来的奥斯提还能承伤，并能为后续出击提供伤害。                          decimal setup=Setup(sim)-baseSetup+(petAfterHits-basePet)*petWeight;                          decimal pressure=0;bool lethal=true;                          foreach(var target in targets){                              var foe=root.State.GetCreature(target);var enemy=sim.State.GetCreature(target);int hp=foe.CurrentHp;                              decimal attack=mark.Hits.GetValueOrDefault(target),hit=attack+hp-enemy.CurrentHp;                              int stacked=combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target);                              pressure+=(combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit);                              int activeDoom=combat.GetAmount<DoomPower>(target);                              decimal through=Math.Max(0,attack-foe.Block);                              if(activeDoom>0&&activeDoom>=enemy.CurrentHp-through&&life>0)pressure+=hp;                              lethal&=through>=enemy.CurrentHp;                          }                          // 生命宽裕时，只有确实换到持续收益，才可接受一部分本能挡下的失血。                          decimal investment=_legend&&setup>0&&life>reserve?Math.Max(0,Math.Min(setup,Math.Min(life-reserve,me.CurrentHp-life)))*.6m:0;                          decimal end=pressure-passPressure+setup+investment+(life-baseLife)*1.6m+(life>0&&baseLife<=0?10000:life<=0&&baseLife>0?-10000:0)                              +(handState.Stars-liveStars)*.5m;                          // 真实新增的有利状态可打破停手平局；不把玩家身上的虚弱倒算成已经登记的攻击减伤。                          bool ImprovesStatus()=>combat.EffectivePowers().Any(p=>p.Amount>0&&                              (p.Owner==actor.Creature?p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Buff:                              p.Owner.Side!=actor.Creature.Side&&p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Debuff)                              && !initial.EffectivePowers().Any(q=>q.Owner==p.Owner&&q.Id==p.Id&&q.Amount>=p.Amount));                          decimal score=end+(HandValue(handState.Hand.Cards,combat)-hand)*.8m+(handState.Energy-liveEnergy)*1.25m;                          var route=new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1),choices)};var b=new Branch(sim,route,score);                          if(end>bestEnd||end==bestEnd&&(chosen.Route.Count==0?ImprovesStatus():score>chosen.Score)){chosen=b;bestEnd=end;}                          if(lethal&&life>0)return b;                          var fingerprint=new StateFingerprintBuilder();                          fingerprint.Add(handState.Energy);fingerprint.Add(handState.Stars);fingerprint.Add(own.Block);fingerprint.Add(own.CurrentHp);                          if(summon){fingerprint.Add(LivingPet(sim));fingerprint.Add(combat.GetOstyMaxHp(sim,actor));}                          void Pile(IReadOnlyList<PredictedCard> cards){fingerprint.Add(cards.Count);foreach(var c in cards){var preview=c.Preview;fingerprint.Add(preview.Id.Entry);fingerprint.Add(preview.CurrentUpgradeLevel);                              if(forge&&preview is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade){fingerprint.Add(preview.DynamicVars.Damage.BaseValue);fingerprint.Add(preview.DynamicVars.HitCount.IntValue);}}}                          Pile(handState.Hand.Cards);Pile(handState.DrawPile.Cards);Pile(handState.DiscardPile.Cards);Pile(handState.ExhaustPile.Cards);                          fingerprint.Add(handState.OrbQueue.Capacity);                          foreach(var orb in handState.OrbQueue.Orbs){fingerprint.Add(orb.Id.Entry);fingerprint.Add(OrbMirrors.GetPassiveValue(sim,orb));fingerprint.Add(OrbMirrors.GetEvokeValue(sim,orb));}                          foreach(var power in combat.EffectivePowers()){fingerprint.Add(power.Owner.CombatId??uint.MaxValue);fingerprint.Add(power.Id.Entry);fingerprint.Add(power.Amount);}                          foreach(var target in targets){fingerprint.Add(mark.Hits.GetValueOrDefault(target));fingerprint.Add(mark.Stacks.GetValueOrDefault(target));}                          var key=fingerprint.Finish();                          if(visited.TryGetValue(key,out var old)&&old>=score)continue;visited[key]=score;layer.Add(b);                          }`
- `object.GetType()`；输入表达式：`move.Preview.GetType()`；返回值紧邻使用处：`ArgumentSyntax: move.Preview.GetType()`
- `OutOfTime()`；输入表达式：`OutOfTime()`；返回值紧邻使用处：`BinaryExpressionSyntax: attempted&&OutOfTime()`
- `Pile(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`；输入表达式：`Pile(handState.DiscardPile.Cards)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pile(handState.DiscardPile.Cards);`
- `Pile(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`；输入表达式：`Pile(handState.DrawPile.Cards)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pile(handState.DrawPile.Cards);`
- `Pile(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`；输入表达式：`Pile(handState.ExhaustPile.Cards)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pile(handState.ExhaustPile.Cards);`
- `Pile(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`；输入表达式：`Pile(handState.Hand.Cards)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pile(handState.Hand.Cards);`
- `Reach(int)`；输入表达式：`Reach(cards.Count(c=>c.Preview.CanonicalStarCost>0||c.Preview.HasStarCostX))`；返回值紧邻使用处：`ConditionalExpressionSyntax: forge?Reach(cards.Count(c=>c.Preview.CanonicalStarCost>0||c.Preview.HasStarCostX)):0`
- `Reach(int)`；输入表达式：`Reach(cards.Count(c=>c.Preview.DynamicVars.ContainsKey("Stars")))`；返回值紧邻使用处：`ConditionalExpressionSyntax: forge?Reach(cards.Count(c=>c.Preview.DynamicVars.ContainsKey("Stars"))):0`
- `Reach(int)`；输入表达式：`Reach(cards.Sum(c=>c.Preview.HasStarCostX?4:Math.Max(0,c.Preview.CanonicalStarCost)))`；返回值紧邻使用处：`ConditionalExpressionSyntax: forge?Reach(cards.Sum(c=>c.Preview.HasStarCostX?4:Math.Max(0,c.Preview.CanonicalStarCost))):0`
- `Setup(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；输入表达式：`Setup(root)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Setup(root)`
- `Setup(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；输入表达式：`Setup(sim)`；返回值紧邻使用处：`BinaryExpressionSyntax: Setup(sim)-baseSetup`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(' ',_route.Select(s=>s.Id+(s.Level>0?"+":"")))`；返回值紧邻使用处：`InterpolationSyntax: {string.Join(' ',_route.Select(s=>s.Id+(s.Level>0?"+":"")))}`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',',root.State.GetPlayerCombatState(actor).OrbQueue.Orbs.Select(o=>o.Id.Entry+"="+OrbMirrors.GetEvokeValue(root,o)))`；返回值紧邻使用处：`InterpolationSyntax: {string.Join(',',root.State.GetPlayerCombatState(actor).OrbQueue.Orbs.Select(o=>o.Id.Entry+"="+OrbMirrors.GetEvokeValue(root,o)))}`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<(CardModel,int),decimal>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<(CardModel,int),decimal>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<StateFingerprint,decimal>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<StateFingerprint,decimal>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`visited.TryGetValue(key,out var old)`；返回值紧邻使用处：`BinaryExpressionSyntax: visited.TryGetValue(key,out var old)&&old>=score`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_unmodelledPlays.Contains(move.Preview.GetType())`；返回值紧邻使用处：`IfStatementSyntax: if(_unmodelledPlays.Contains(move.Preview.GetType())){incomplete=true;continue;}`
- `System.Collections.Generic.IEnumerable<decimal>.Sum()`；输入表达式：`amounts.Sum()`；返回值紧邻使用处：`ArgumentSyntax: amounts.Sum()`
- `System.Collections.Generic.IEnumerable<decimal>.Sum()`；输入表达式：`amounts.Where((_,i)=>properties[i]!=-1).Sum()`；返回值紧邻使用处：`CastExpressionSyntax: (int)amounts.Where((_,i)=>properties[i]!=-1).Sum()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`amounts.Any(v=>v>0)`；返回值紧邻使用处：`ArgumentSyntax: amounts.Any(v=>v>0)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`cards.Any(c=>c.Preview is MegaCrit.Sts2.Core.Models.Cards.SummonForth or MegaCrit.Sts2.Core.Models.Cards.Conqueror or MegaCrit.Sts2.Core.Models.Cards.SwordSage)`；返回值紧邻使用处：`BinaryExpressionSyntax: forge&&cards.Any(c=>c.Preview is MegaCrit.Sts2.Core.Models.Cards.SummonForth or MegaCrit.Sts2.Core.Models.Cards.Conqueror or MegaCrit.Sts2.Core.Models.Cards.SwordSage)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`realHand.Any(c=>c.CanPlay())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !realHand.Any(c=>c.CanPlay())`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`rootPlayer.Hand.Cards.Concat(rootPlayer.DrawPile.Cards).Concat(rootPlayer.DiscardPile.Cards)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rootPlayer.Hand.Cards.Concat(rootPlayer.DrawPile.Cards).Concat(rootPlayer.DiscardPile.Cards).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`rootPlayer.Hand.Cards.Concat(rootPlayer.DrawPile.Cards)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rootPlayer.Hand.Cards.Concat(rootPlayer.DrawPile.Cards).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`c.Preview.Tags.Contains(CardTag.OstyAttack)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>c.Preview.Tags.Contains(CardTag.OstyAttack)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`cards.Count(c=>c.Preview.CanonicalStarCost>0||c.Preview.HasStarCostX)`；返回值紧邻使用处：`ArgumentSyntax: cards.Count(c=>c.Preview.CanonicalStarCost>0||c.Preview.HasStarCostX)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`cards.Count(c=>c.Preview.DynamicVars.ContainsKey("Stars"))`；返回值紧邻使用处：`ArgumentSyntax: cards.Count(c=>c.Preview.DynamicVars.ContainsKey("Stars"))`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`cards.Count(c=>c.Preview.Tags.Contains(CardTag.OstyAttack))`；返回值紧邻使用处：`ArgumentSyntax: cards.Count(c=>c.Preview.Tags.Contains(CardTag.OstyAttack))`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`properties.Count(p=>p!=-1)`；返回值紧邻使用处：`ArgumentSyntax: properties.Count(p=>p!=-1)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`targets.FirstOrDefault(t=>_aims[t]==id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id=>targets.FirstOrDefault(t=>_aims[t]==id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Enumerable.Range(0,ps.Hand.Cards.Count).OrderBy(Order)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(int i in Enumerable.Range(0,ps.Hand.Cards.Count).OrderBy(Order)){                          var move=ps.Hand.Cards[i];if(_unmodelledPlays.Contains(move.Preview.GetType())){incomplete=true;continue;}                          try{if(!parent.Sim.CanPlay(move))continue;}catch(NotSupportedException){incomplete=true;continue;}                          foreach(var aim in move.Preview.TargetType==TargetType.AnyEnemy?aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>():new Creature?[]{move.Preview.TargetType is TargetType.AnyAlly or TargetType.Self?actor.Creature:null}){                          if(attempted&&OutOfTime()){incomplete=true;return chosen;}                          attempted=true;                          // 直接出牌与每一种中途选择使用同一套攻防评分，复用上游的候选与动作回放。                          foreach(var result in PlayOptions(parent.Sim,i,aim,actor,3+2*_tier,OutOfTime,()=>incomplete=true)){                          var (sim,choices)=result;                          var handState=sim.State.GetPlayerCombatState(actor);var card=move;                          expanded++;                          var combat=(SimulatedCombatState)sim.State.CombatState;                          var own=sim.State.GetCreature(actor.Creature);                          var life=EndHealth(sim,out var mark,out int petAfterHits);                          // 已替主人承伤的生命不能重复计分。保留下来的奥斯提还能承伤，并能为后续出击提供伤害。                          decimal setup=Setup(sim)-baseSetup+(petAfterHits-basePet)*petWeight;                          decimal pressure=0;bool lethal=true;                          foreach(var target in targets){                              var foe=root.State.GetCreature(target);var enemy=sim.State.GetCreature(target);int hp=foe.CurrentHp;                              decimal attack=mark.Hits.GetValueOrDefault(target),hit=attack+hp-enemy.CurrentHp;                              int stacked=combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target);                              pressure+=(combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit);                              int activeDoom=combat.GetAmount<DoomPower>(target);                              decimal through=Math.Max(0,attack-foe.Block);                              if(activeDoom>0&&activeDoom>=enemy.CurrentHp-through&&life>0)pressure+=hp;                              lethal&=through>=enemy.CurrentHp;                          }                          // 生命宽裕时，只有确实换到持续收益，才可接受一部分本能挡下的失血。                          decimal investment=_legend&&setup>0&&life>reserve?Math.Max(0,Math.Min(setup,Math.Min(life-reserve,me.CurrentHp-life)))*.6m:0;                          decimal end=pressure-passPressure+setup+investment+(life-baseLife)*1.6m+(life>0&&baseLife<=0?10000:life<=0&&baseLife>0?-10000:0)                              +(handState.Stars-liveStars)*.5m;                          // 真实新增的有利状态可打破停手平局；不把玩家身上的虚弱倒算成已经登记的攻击减伤。                          bool ImprovesStatus()=>combat.EffectivePowers().Any(p=>p.Amount>0&&                              (p.Owner==actor.Creature?p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Buff:                              p.Owner.Side!=actor.Creature.Side&&p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Debuff)                              && !initial.EffectivePowers().Any(q=>q.Owner==p.Owner&&q.Id==p.Id&&q.Amount>=p.Amount));                          decimal score=end+(HandValue(handState.Hand.Cards,combat)-hand)*.8m+(handState.Energy-liveEnergy)*1.25m;                          var route=new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1),choices)};var b=new Branch(sim,route,score);                          if(end>bestEnd||end==bestEnd&&(chosen.Route.Count==0?ImprovesStatus():score>chosen.Score)){chosen=b;bestEnd=end;}                          if(lethal&&life>0)return b;                          var fingerprint=new StateFingerprintBuilder();                          fingerprint.Add(handState.Energy);fingerprint.Add(handState.Stars);fingerprint.Add(own.Block);fingerprint.Add(own.CurrentHp);                          if(summon){fingerprint.Add(LivingPet(sim));fingerprint.Add(combat.GetOstyMaxHp(sim,actor));}                          void Pile(IReadOnlyList<PredictedCard> cards){fingerprint.Add(cards.Count);foreach(var c in cards){var preview=c.Preview;fingerprint.Add(preview.Id.Entry);fingerprint.Add(preview.CurrentUpgradeLevel);                              if(forge&&preview is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade){fingerprint.Add(preview.DynamicVars.Damage.BaseValue);fingerprint.Add(preview.DynamicVars.HitCount.IntValue);}}}                          Pile(handState.Hand.Cards);Pile(handState.DrawPile.Cards);Pile(handState.DiscardPile.Cards);Pile(handState.ExhaustPile.Cards);                          fingerprint.Add(handState.OrbQueue.Capacity);                          foreach(var orb in handState.OrbQueue.Orbs){fingerprint.Add(orb.Id.Entry);fingerprint.Add(OrbMirrors.GetPassiveValue(sim,orb));fingerprint.Add(OrbMirrors.GetEvokeValue(sim,orb));}                          foreach(var power in combat.EffectivePowers()){fingerprint.Add(power.Owner.CombatId??uint.MaxValue);fingerprint.Add(power.Id.Entry);fingerprint.Add(power.Amount);}                          foreach(var target in targets){fingerprint.Add(mark.Hits.GetValueOrDefault(target));fingerprint.Add(mark.Stacks.GetValueOrDefault(target));}                          var key=fingerprint.Finish();                          if(visited.TryGetValue(key,out var old)&&old>=score)continue;visited[key]=score;layer.Add(b);                          }                          }                      }`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`layer.OrderByDescending(b=>b.Score)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: layer.OrderByDescending(b=>b.Score).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`targets.OrderByDescending(t=>_aims[t]==_preferredTarget)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: targets.OrderByDescending(t=>_aims[t]==_preferredTarget).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_route.Select(s=>s.Id+(s.Level>0?"+":""))`；返回值紧邻使用处：`ArgumentSyntax: _route.Select(s=>s.Id+(s.Level>0?"+":""))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`dealers.Select(id=>targets.FirstOrDefault(t=>_aims[t]==id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: dealers.Select(id=>targets.FirstOrDefault(t=>_aims[t]==id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`root.State.GetPlayerCombatState(actor).OrbQueue.Orbs.Select(o=>o.Id.Entry+"="+OrbMirrors.GetEvokeValue(root,o))`；返回值紧邻使用处：`ArgumentSyntax: root.State.GetPlayerCombatState(actor).OrbQueue.Orbs.Select(o=>o.Id.Entry+"="+OrbMirrors.GetEvokeValue(root,o))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`targets.Sum(t=>Math.Min(root.State.GetCreature(t).CurrentHp+root.State.GetCreature(t).Block,pass.Hits.GetValueOrDefault(t)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =targets.Sum(t=>Math.Min(root.State.GetCreature(t).CurrentHp+root.State.GetCreature(t).Block,pass.Hits.GetValueOrDefault(t)))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`cards.Sum(c=>c.Preview.HasStarCostX?4:Math.Max(0,c.Preview.CanonicalStarCost))`；返回值紧邻使用处：`ArgumentSyntax: cards.Sum(c=>c.Preview.HasStarCostX?4:Math.Max(0,c.Preview.CanonicalStarCost))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`targets.Sum(t=>root.State.GetCreature(t).CurrentHp)`；返回值紧邻使用处：`ArgumentSyntax: targets.Sum(t=>root.State.GetCreature(t).CurrentHp)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`layer.OrderByDescending(b=>b.Score).Take(3+_tier*2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`dealers.Select(id=>targets.FirstOrDefault(t=>_aims[t]==id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =dealers.Select(id=>targets.FirstOrDefault(t=>_aims[t]==id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`rootPlayer.Hand.Cards.Concat(rootPlayer.DrawPile.Cards).Concat(rootPlayer.DiscardPile.Cards).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =rootPlayer.Hand.Cards.Concat(rootPlayer.DrawPile.Cards).Concat(rootPlayer.DiscardPile.Cards).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`targets.OrderByDescending(t=>_aims[t]==_preferredTarget).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _preferredTarget<0?targets:targets.OrderByDescending(t=>_aims[t]==_preferredTarget).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: front=layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, int, bool>)`；输入表达式：`amounts.Where((_,i)=>properties[i]!=-1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: amounts.Where((_,i)=>properties[i]!=-1).Sum`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_aims.GetValueOrDefault(aim,-1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: aim==null?-1:_aims.GetValueOrDefault(aim,-1)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_originals.GetValueOrDefault(card.Original)`；返回值紧邻使用处：`ArgumentSyntax: _originals.GetValueOrDefault(card.Original)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`mark.Hits.GetValueOrDefault(target)`；返回值紧邻使用处：`ArgumentSyntax: mark.Hits.GetValueOrDefault(target)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`mark.Hits.GetValueOrDefault(target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =mark.Hits.GetValueOrDefault(target)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`mark.Stacks.GetValueOrDefault(target)`；返回值紧邻使用处：`ArgumentSyntax: mark.Stacks.GetValueOrDefault(target)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`mark.Stacks.GetValueOrDefault(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`pass.Hits.GetValueOrDefault(t)`；返回值紧邻使用处：`ArgumentSyntax: pass.Hits.GetValueOrDefault(t)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`layer.Add(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: layer.Add(b);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Branch>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<Branch>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Branch>{new(root,[],0)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<Branch>{new(root,[],0)}`
- `System.Collections.Generic.List<T>.List(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1),choices)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1),choices)}`
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
- `System.IO.File.AppendAllText(string, string?)`；输入表达式：`File.AppendAllText(Path.Combine(report,"solver-review.txt"),$"{_captured++} capture={capture:F1}ms total={watch.Elapsed.TotalMilliseconds:F1}ms search={searchMs:F1}ms captureBytes={captureBytes} searchBytes={searchBytes} expanded={expanded} orbs={string.Join(',',root.State.GetPlayerCombatState(actor).OrbQueue.Orbs.Select(o=>o.Id.Entry+"="+OrbMirrors.GetEvokeValue(root,o)))} route={string.Join(' ',_route.Select(s=>s.Id+(s.Level>0?"+":"")))}\n")`；返回值紧邻使用处：`ExpressionStatementSyntax: File.AppendAllText(Path.Combine(report,"solver-review.txt"),$"{_captured++} capture={capture:F1}ms total={watch.Elapsed.TotalMilliseconds:F1}ms search={searchMs:F1}ms captureBytes={captureBytes} searchBytes={searchBytes} expanded={expanded} orbs={string.Join(',',root.State.GetPlayerCombatState(actor).OrbQueue.Orbs.Select(o=>o.Id.Entry+"="+OrbMirrors.GetEvokeValue(root,o)))} route={string.Join(' ',_route.Select(s=>s.Id+(s.Level>0?"+":"")))}\n");`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(report,"solver-review.txt")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(report,"solver-review.txt")`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0,ps.Hand.Cards.Count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,ps.Hand.Cards.Count).OrderBy`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0,attack-foe.Block)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(0,attack-foe.Block)`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0,Math.Min(setup,Math.Min(life-reserve,me.CurrentHp-life)))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0,Math.Min(setup,Math.Min(life-reserve,me.CurrentHp-life)))*.6m`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(me.MaxHp/3m,amounts.Sum())`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(me.MaxHp/3m,amounts.Sum())`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,c.Preview.CanonicalStarCost)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Preview.HasStarCostX?4:Math.Max(0,c.Preview.CanonicalStarCost)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,future.RemainingTurns-1)`；返回值紧邻使用处：`BinaryExpressionSyntax: (MelodyChance(CardTag.Wah)+MelodyChance(CardTag.Cho)+MelodyChance(CardTag.Ki))*Math.Max(0,future.RemainingTurns-1)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,future.RemainingTurns-1)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0,future.RemainingTurns-1)*3`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,future.RemainingTurns-1)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0,future.RemainingTurns-1)*5m`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,cards.Length)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0,future.RemainingTurns-1)*5m/Math.Max(1,cards.Length)`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(1m,Math.Max(0,future.RemainingTurns-1)*5m/Math.Max(1,cards.Length))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(1m,Math.Max(0,future.RemainingTurns-1)*5m/Math.Max(1,cards.Length))`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(hp+foe.Block,hit)`；返回值紧邻使用处：`BinaryExpressionSyntax: (combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit)`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(life-reserve,me.CurrentHp-life)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(life-reserve,me.CurrentHp-life)`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(root.State.GetCreature(t).CurrentHp+root.State.GetCreature(t).Block,pass.Hits.GetValueOrDefault(t))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t=>Math.Min(root.State.GetCreature(t).CurrentHp+root.State.GetCreature(t).Block,pass.Hits.GetValueOrDefault(t))`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(setup,Math.Min(life-reserve,me.CurrentHp-life))`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(setup,Math.Min(life-reserve,me.CurrentHp-life))`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(4,cards.Count(c=>c.Preview.Tags.Contains(CardTag.OstyAttack)))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(4,cards.Count(c=>c.Preview.Tags.Contains(CardTag.OstyAttack)))*.125m`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(Math.Max(0,future.RemainingTurns-1)*3,future.ReachableCards)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(Math.Max(0,future.RemainingTurns-1)*3,future.ReachableCards)`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`_exit.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: _exit.ThrowIfCancellationRequested();`
- `System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`；输入表达式：`Task.Run(()=>{              long allocated=report==null?0:GC.GetAllocatedBytesForCurrentThread();long started=Stopwatch.GetTimestamp();              try{              var clock=Stopwatch.StartNew();var me=root.State.GetCreature(actor.Creature);              bool OutOfTime(){_exit.ThrowIfCancellationRequested();return clock.Elapsed.TotalMilliseconds>=18+6*_tier;}              bool summon=_legend&&actor.Character.Id.Entry=="NECROBINDER";              int LivingPet(CombatPredictionSimulator sim)=>summon&&sim.State.GetOsty(actor) is {} pet?sim.State.GetCreature(pet).CurrentHp:0;              decimal EndHealth(CombatPredictionSimulator sim,out Ledger mark,out int petAfterHits){                  mark=Damage.GetOrCreateValue(sim);                  bool orbs=sim.State.GetPlayerCombatState(actor).OrbQueue.Orbs.Count!=0;                  var end=orbs||amounts.Length!=0?sim.Fork():sim;                  if(orbs){                      var projected=Damage.GetOrCreateValue(end);projected.Copy(mark);                      if(OrbLifecycleSupport.TriggerBeforeTurnEnd(end,(SimulatedCombatState)end.State.CombatState,actor))mark=projected;                      else end=sim.Fork();                      // 来袭意图在这个副本上真实扣血，不能再次记为下一轮的攻击。                      Damage.Remove(end);                  }                  if(amounts.Length==0){petAfterHits=LivingPet(end);var hp=end.State.GetCreature(actor.Creature).CurrentHp;return ((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)>=hp?0:hp;}                  var defending=end.State.GetCreature(actor.Creature);int added=0;                  for(int k=0;k<amounts.Length&&end.State.GetCreature(actor.Creature).IsAlive;k++)                      if(properties[k]==-1){added+=(int)(amounts[k]-defending.DamageBlock(amounts[k],ValueProp.Move));}else{                          var state=(SimulatedCombatState)end.State.CombatState;var props=(ValueProp)properties[k];decimal amount=amounts[k];                          if(attackers[k] is {} attacker && props.IsPoweredAttack() && state.GetAmount<VulnerablePower>(attacker)>0 && state.GetPower<ColossusPower>(actor.Creature) is {} defense)                              amount*=defense.DynamicVars["DamageDecrease"].BaseValue;                          var attackerForHit=attackers[k]??targets[0];                          _incoming=(attackerForHit,actor.Creature);                          try{end.Damage([actor.Creature],amount,props,attackerForHit,null,null,capped[k]?ModifyDamageHookType.Cap:ModifyDamageHookType.None);}                          finally{_incoming=default;}                      }                  petAfterHits=LivingPet(end);                  return !defending.IsAlive||((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)>=defending.CurrentHp?0:Math.Max(.1m,defending.CurrentHp-added*.85m);              }              var initial=(SimulatedCombatState)root.State.CombatState;              bool fool=actor.Character.Id.Entry=="FOOL";              int HandValue(IReadOnlyList<PredictedCard> cards,SimulatedCombatState state){                  if(!fool)return cards.Count;                  int sadness=0;foreach(var c in cards)if(c.Preview.Id.Entry=="SADNESS")sadness++;                  // 每层狂喜可在下个回合转化一张悲伤；其余悲伤会继续占用手牌位置。                  return cards.Count-sadness-Math.Max(0,sadness-state.GetAmount<EcstasyPower>(actor.Creature));              }              var baseLife=EndHealth(root,out var pass,out int basePet);              var rootPlayer=root.State.GetPlayerCombatState(actor);              var cards=rootPlayer.Hand.Cards.Concat(rootPlayer.DrawPile.Cards).Concat(rootPlayer.DiscardPile.Cards).ToArray();              var future=StrategicEffectContext.Build(cards,targets.Sum(t=>root.State.GetCreature(t).CurrentHp),                  (int)amounts.Where((_,i)=>properties[i]!=-1).Sum(),properties.Count(p=>p!=-1),                  (StrategicEffectRequirements)(-1),initial.GetAmount<CorruptionPower>(actor.Creature)>0);              decimal petWeight=summon&&future.RemainingTurns>1?.5m+Math.Min(4,cards.Count(c=>c.Preview.Tags.Contains(CardTag.OstyAttack)))*.125m:0;              decimal reserve=Math.Max(me.MaxHp/3m,amounts.Sum());              bool forge=_legend&&actor.Character.Id.Entry=="REGENT";              bool bladePlan=forge&&cards.Any(c=>c.Preview is MegaCrit.Sts2.Core.Models.Cards.SummonForth or MegaCrit.Sts2.Core.Models.Cards.Conqueror or MegaCrit.Sts2.Core.Models.Cards.SwordSage);              // 按牌组里实际还会抽到的耗星牌估计需求。黑洞按产星或耗星的次数触发，星之子按花掉的星数触发。              decimal opportunities=Math.Min(Math.Max(0,future.RemainingTurns-1)*3,future.ReachableCards);              decimal Reach(int n)=>opportunities*n/Math.Max(1,cards.Length);              decimal spendEvents=forge?Reach(cards.Count(c=>c.Preview.CanonicalStarCost>0||c.Preview.HasStarCostX)):0;              decimal starDemand=forge?Reach(cards.Sum(c=>c.Preview.HasStarCostX?4:Math.Max(0,c.Preview.CanonicalStarCost))):0;              decimal printedGain=forge?Reach(cards.Count(c=>c.Preview.DynamicVars.ContainsKey("Stars"))):0;              // 每回合每种旋律最多触发一次。按剩余牌组中该旋律的张数，估算三张可出牌中出现该旋律的机会。              decimal MelodyChance(CardTag tag){                  int count=cards.Count(c=>c.Preview.Tags.Contains(tag));decimal miss=1;                  for(int i=0;i<Math.Min(3,cards.Length);i++)miss*=Math.Max(0,cards.Length-count-i)/(decimal)(cards.Length-i);                  return 1-miss;              }              decimal melodies=_legend&&fool?(MelodyChance(CardTag.Wah)+MelodyChance(CardTag.Cho)+MelodyChance(CardTag.Ki))*Math.Max(0,future.RemainingTurns-1):0;              var upgradeValues=new Dictionary<(CardModel,int),decimal>();              decimal access=Math.Min(1m,Math.Max(0,future.RemainingTurns-1)*5m/Math.Max(1,cards.Length));              // 牌堆中真实发生的升级仍能在以后的抽牌中生效；已消耗的牌不再计入。              decimal KeptCards(SimPlayerCombatState ps){                  if(!_legend||access<=0)return 0;                  decimal bladeValue=0,upgrades=0;                  void Visit(IReadOnlyList<PredictedCard> pile){                      for(int i=0;i<pile.Count;i++){var card=pile[i];var liveCard=card.Original;var next=card.Preview;                          if(bladePlan&&next is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade blade&&!blade.IsDupe)                              bladeValue=Math.Max(bladeValue,blade.DynamicVars.Damage.BaseValue*blade.DynamicVars.HitCount.IntValue);                          if(ReferenceEquals(liveCard,next)||next.CurrentUpgradeLevel<=liveCard.CurrentUpgradeLevel)continue;                          var key=(liveCard,next.CurrentUpgradeLevel);                          if(!upgradeValues.TryGetValue(key,out var gain)){                              // 仅比较升级本身，避免把同一条路线里额外铸造的剑伤算成升级收益。                              var upgraded=new PredictedCard(liveCard);                              for(int j=liveCard.CurrentUpgradeLevel;j<next.CurrentUpgradeLevel;j++)upgraded.Upgrade();                              var after=upgraded.Preview;                              gain=(decimal)(CardChoiceSupport.CardValue(after)-CardChoiceSupport.CardValue(liveCard))                                  +4*(liveCard.EnergyCost.GetWithModifiers(CostModifiers.None)-after.EnergyCost.GetWithModifiers(CostModifiers.None));                              upgradeValues[key]=gain;                          }                          upgrades+=gain;                      }                  }                  Visit(ps.Hand.Cards);Visit(ps.DrawPile.Cards);Visit(ps.DiscardPile.Cards);                  return Math.Min(bladeValue,future.EnemyHp)*.65m+access*upgrades;              }              decimal Setup(CombatPredictionSimulator sim){                  if(_tier==0)return 0;                  var combat=(SimulatedCombatState)sim.State.CombatState;                  var ps=sim.State.GetPlayerCombatState(actor);var powers=combat.EffectivePowers();                  decimal value=0;                  foreach(var power in powers){                      if(!StrategicEffectMirrors.Contributes(power,actor.Creature))continue;                      var ctx=power is DarkEmbracePower?future.WithExhaustDrawTiming(powers,ps.Hand.Cards,actor.Creature):future;                      decimal v=StrategicEffectModel.Evaluate(power,ctx).RetentionValue;                      // 空球栏保留集中以后启动的价值。已经成型的能力继续叠层时，边际收益渐减。                      if(power is FocusPower&&!ps.OrbQueue.Orbs.Any(o=>o is not MegaCrit.Sts2.Core.Models.Orbs.PlasmaOrb))v*=.35m;                      value+=16*v/(12+v);                      // 上游已估算剩余回合、可触发次数和敌方生命。只有后续回合确有收益才增加启动价值。                      if(_legend&&future.RemainingTurns>1&&v>12)value+=24*(v-12)/(36+v);                  }                  if(forge&&starDemand>0){                      int throne=combat.GetAmount<TheSealedThronePower>(actor.Creature),genesis=combat.GetAmount<GenesisPower>(actor.Creature);                      decimal events=(throne>0?opportunities:0)+(genesis>0?Math.Max(0,future.RemainingTurns-1):0);                      decimal supply=opportunities*throne+Math.Max(0,future.RemainingTurns-1)*genesis;                      // 有相应的耗星牌才能兑现资源。黑洞每个产星事件只触发一次，囤积星数不能重复计为伤害。                      decimal usable=Math.Min(starDemand,Math.Max(0,supply+printedGain+ps.Stars));                      value+=Math.Min(starDemand,supply)*1.5m                          +Math.Min(future.EnemyHp,combat.GetAmount<BlackHolePower>(actor.Creature)*(events+printedGain+Math.Min(usable,spendEvents)))*.65m                          +Math.Min(future.IncomingDamage,combat.GetAmount<ChildOfTheStarsPower>(actor.Creature)*usable)*.6m;                  }                  if(melodies>0){                      // 失落鲁特琴直接打出牌顶，曲中意只抽牌，不能把两种回报按同一价值计算。                      value+=Math.Min(future.EnemyHp,melodies*(combat.GetAmount<LostLutePower>(actor.Creature)*Math.Clamp(future.AverageCardValue,3,9)                          +combat.GetAmount<MotifPower>(actor.Creature)*2))*.8m;                  }                  return value+KeptCards(ps)+.5m*CombatBeamSolver.OrbRetentionValue(sim,ps.OrbQueue.Orbs,targets.Length);              }              decimal baseSetup=Setup(root);              decimal passPressure=targets.Sum(t=>Math.Min(root.State.GetCreature(t).CurrentHp+root.State.GetCreature(t).Block,pass.Hits.GetValueOrDefault(t)));              int hand=HandValue(root.State.GetPlayerCombatState(actor).Hand.Cards,initial);                            var front=new List<Branch>{new(root,[],0)};var chosen=front[0];var visited=new Dictionary<StateFingerprint,decimal>();              // 能量和手牌在推演途中可以支持后续动作；回合结束后的普通手牌与未用能量不能当作已获得的收益。              decimal bestEnd=0;              for(int depth=0;depth<24&&front.Count>0;depth++){                  var layer=new List<Branch>();                  foreach(var parent in front){                      var ps=parent.Sim.State.GetPlayerCombatState(actor);                      // 优先推演已经能发挥作用的牌；获得星星或消耗能量后，下一层按新次数重新排序。                      var beforePlay=(SimulatedCombatState)parent.Sim.State.CombatState;                      int Order(int i){                          var c=ps.Hand.Cards[i].Preview;                          // 先展开免费补充手牌或能量的分支，给同回合的准备牌和终结牌留出推演时间。                          if(_legend&&c.EnergyCost.GetAmountToSpend()==0&&(c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("Cards")))return -2;                          if(forge&&c is MegaCrit.Sts2.Core.Models.Cards.Conqueror&&ps.Hand.Cards.Any(p=>p.Preview is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade))return -1;                          if(c switch{                          MegaCrit.Sts2.Core.Models.Cards.Radiate=>beforePlay.GetStarsGainedThisTurn(actor)==0,                          MegaCrit.Sts2.Core.Models.Cards.HelixDrill=>beforePlay.GetEnergySpentThisTurn(actor)==0,                          MegaCrit.Sts2.Core.Models.Cards.LunarBlast=>beforePlay.GetSkillCardsPlayedThisTurn(actor.Creature)==0,                          _=>false})return 2;                          return c.Type==CardType.Power||_setup.Contains(c.Id.Entry)||CardEffectSpecRegistry.Contains(c)||                              c.DynamicVars.ContainsKey("Cards")||c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("WeakPower")||                              c.DynamicVars.ContainsKey("VulnerablePower")||c.DynamicVars.ContainsKey("StrengthPower")?0:1;                      }                      foreach(int i in Enumerable.Range(0,ps.Hand.Cards.Count).OrderBy(Order)){                          var move=ps.Hand.Cards[i];if(_unmodelledPlays.Contains(move.Preview.GetType())){incomplete=true;continue;}                          try{if(!parent.Sim.CanPlay(move))continue;}catch(NotSupportedException){incomplete=true;continue;}                          foreach(var aim in move.Preview.TargetType==TargetType.AnyEnemy?aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>():new Creature?[]{move.Preview.TargetType is TargetType.AnyAlly or TargetType.Self?actor.Creature:null}){                          if(attempted&&OutOfTime()){incomplete=true;return chosen;}                          attempted=true;                          // 直接出牌与每一种中途选择使用同一套攻防评分，复用上游的候选与动作回放。                          foreach(var result in PlayOptions(parent.Sim,i,aim,actor,3+2*_tier,OutOfTime,()=>incomplete=true)){                          var (sim,choices)=result;                          var handState=sim.State.GetPlayerCombatState(actor);var card=move;                          expanded++;                          var combat=(SimulatedCombatState)sim.State.CombatState;                          var own=sim.State.GetCreature(actor.Creature);                          var life=EndHealth(sim,out var mark,out int petAfterHits);                          // 已替主人承伤的生命不能重复计分。保留下来的奥斯提还能承伤，并能为后续出击提供伤害。                          decimal setup=Setup(sim)-baseSetup+(petAfterHits-basePet)*petWeight;                          decimal pressure=0;bool lethal=true;                          foreach(var target in targets){                              var foe=root.State.GetCreature(target);var enemy=sim.State.GetCreature(target);int hp=foe.CurrentHp;                              decimal attack=mark.Hits.GetValueOrDefault(target),hit=attack+hp-enemy.CurrentHp;                              int stacked=combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target);                              pressure+=(combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit);                              int activeDoom=combat.GetAmount<DoomPower>(target);                              decimal through=Math.Max(0,attack-foe.Block);                              if(activeDoom>0&&activeDoom>=enemy.CurrentHp-through&&life>0)pressure+=hp;                              lethal&=through>=enemy.CurrentHp;                          }                          // 生命宽裕时，只有确实换到持续收益，才可接受一部分本能挡下的失血。                          decimal investment=_legend&&setup>0&&life>reserve?Math.Max(0,Math.Min(setup,Math.Min(life-reserve,me.CurrentHp-life)))*.6m:0;                          decimal end=pressure-passPressure+setup+investment+(life-baseLife)*1.6m+(life>0&&baseLife<=0?10000:life<=0&&baseLife>0?-10000:0)                              +(handState.Stars-liveStars)*.5m;                          // 真实新增的有利状态可打破停手平局；不把玩家身上的虚弱倒算成已经登记的攻击减伤。                          bool ImprovesStatus()=>combat.EffectivePowers().Any(p=>p.Amount>0&&                              (p.Owner==actor.Creature?p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Buff:                              p.Owner.Side!=actor.Creature.Side&&p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Debuff)                              && !initial.EffectivePowers().Any(q=>q.Owner==p.Owner&&q.Id==p.Id&&q.Amount>=p.Amount));                          decimal score=end+(HandValue(handState.Hand.Cards,combat)-hand)*.8m+(handState.Energy-liveEnergy)*1.25m;                          var route=new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1),choices)};var b=new Branch(sim,route,score);                          if(end>bestEnd||end==bestEnd&&(chosen.Route.Count==0?ImprovesStatus():score>chosen.Score)){chosen=b;bestEnd=end;}                          if(lethal&&life>0)return b;                          var fingerprint=new StateFingerprintBuilder();                          fingerprint.Add(handState.Energy);fingerprint.Add(handState.Stars);fingerprint.Add(own.Block);fingerprint.Add(own.CurrentHp);                          if(summon){fingerprint.Add(LivingPet(sim));fingerprint.Add(combat.GetOstyMaxHp(sim,actor));}                          void Pile(IReadOnlyList<PredictedCard> cards){fingerprint.Add(cards.Count);foreach(var c in cards){var preview=c.Preview;fingerprint.Add(preview.Id.Entry);fingerprint.Add(preview.CurrentUpgradeLevel);                              if(forge&&preview is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade){fingerprint.Add(preview.DynamicVars.Damage.BaseValue);fingerprint.Add(preview.DynamicVars.HitCount.IntValue);}}}                          Pile(handState.Hand.Cards);Pile(handState.DrawPile.Cards);Pile(handState.DiscardPile.Cards);Pile(handState.ExhaustPile.Cards);                          fingerprint.Add(handState.OrbQueue.Capacity);                          foreach(var orb in handState.OrbQueue.Orbs){fingerprint.Add(orb.Id.Entry);fingerprint.Add(OrbMirrors.GetPassiveValue(sim,orb));fingerprint.Add(OrbMirrors.GetEvokeValue(sim,orb));}                          foreach(var power in combat.EffectivePowers()){fingerprint.Add(power.Owner.CombatId??uint.MaxValue);fingerprint.Add(power.Id.Entry);fingerprint.Add(power.Amount);}                          foreach(var target in targets){fingerprint.Add(mark.Hits.GetValueOrDefault(target));fingerprint.Add(mark.Stacks.GetValueOrDefault(target));}                          var key=fingerprint.Finish();                          if(visited.TryGetValue(key,out var old)&&old>=score)continue;visited[key]=score;layer.Add(b);                          }                          }                      }                  }                  front=layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList();              }              return chosen;              }finally{if(report!=null){searchMs=Stopwatch.GetElapsedTime(started).TotalMilliseconds;searchBytes=GC.GetAllocatedBytesForCurrentThread()-allocated;}}          })`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Run(()=>{              long allocated=report==null?0:GC.GetAllocatedBytesForCurrentThread();long started=Stopwatch.GetTimestamp();              try{              var clock=Stopwatch.StartNew();var me=root.State.GetCreature(actor.Creature);              bool OutOfTime(){_exit.ThrowIfCancellationRequested();return clock.Elapsed.TotalMilliseconds>=18+6*_tier;}              bool summon=_legend&&actor.Character.Id.Entry=="NECROBINDER";              int LivingPet(CombatPredictionSimulator sim)=>summon&&sim.State.GetOsty(actor) is {} pet?sim.State.GetCreature(pet).CurrentHp:0;              decimal EndHealth(CombatPredictionSimulator sim,out Ledger mark,out int petAfterHits){                  mark=Damage.GetOrCreateValue(sim);                  bool orbs=sim.State.GetPlayerCombatState(actor).OrbQueue.Orbs.Count!=0;                  var end=orbs||amounts.Length!=0?sim.Fork():sim;                  if(orbs){                      var projected=Damage.GetOrCreateValue(end);projected.Copy(mark);                      if(OrbLifecycleSupport.TriggerBeforeTurnEnd(end,(SimulatedCombatState)end.State.CombatState,actor))mark=projected;                      else end=sim.Fork();                      // 来袭意图在这个副本上真实扣血，不能再次记为下一轮的攻击。                      Damage.Remove(end);                  }                  if(amounts.Length==0){petAfterHits=LivingPet(end);var hp=end.State.GetCreature(actor.Creature).CurrentHp;return ((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)>=hp?0:hp;}                  var defending=end.State.GetCreature(actor.Creature);int added=0;                  for(int k=0;k<amounts.Length&&end.State.GetCreature(actor.Creature).IsAlive;k++)                      if(properties[k]==-1){added+=(int)(amounts[k]-defending.DamageBlock(amounts[k],ValueProp.Move));}else{                          var state=(SimulatedCombatState)end.State.CombatState;var props=(ValueProp)properties[k];decimal amount=amounts[k];                          if(attackers[k] is {} attacker && props.IsPoweredAttack() && state.GetAmount<VulnerablePower>(attacker)>0 && state.GetPower<ColossusPower>(actor.Creature) is {} defense)                              amount*=defense.DynamicVars["DamageDecrease"].BaseValue;                          var attackerForHit=attackers[k]??targets[0];                          _incoming=(attackerForHit,actor.Creature);                          try{end.Damage([actor.Creature],amount,props,attackerForHit,null,null,capped[k]?ModifyDamageHookType.Cap:ModifyDamageHookType.None);}                          finally{_incoming=default;}                      }                  petAfterHits=LivingPet(end);                  return !defending.IsAlive||((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)>=defending.CurrentHp?0:Math.Max(.1m,defending.CurrentHp-added*.85m);              }              var initial=(SimulatedCombatState)root.State.CombatState;              bool fool=actor.Character.Id.Entry=="FOOL";              int HandValue(IReadOnlyList<PredictedCard> cards,SimulatedCombatState state){                  if(!fool)return cards.Count;                  int sadness=0;foreach(var c in cards)if(c.Preview.Id.Entry=="SADNESS")sadness++;                  // 每层狂喜可在下个回合转化一张悲伤；其余悲伤会继续占用手牌位置。                  return cards.Count-sadness-Math.Max(0,sadness-state.GetAmount<EcstasyPower>(actor.Creature));              }              var baseLife=EndHealth(root,out var pass,out int basePet);              var rootPlayer=root.State.GetPlayerCombatState(actor);              var cards=rootPlayer.Hand.Cards.Concat(rootPlayer.DrawPile.Cards).Concat(rootPlayer.DiscardPile.Cards).ToArray();              var future=StrategicEffectContext.Build(cards,targets.Sum(t=>root.State.GetCreature(t).CurrentHp),                  (int)amounts.Where((_,i)=>properties[i]!=-1).Sum(),properties.Count(p=>p!=-1),                  (StrategicEffectRequirements)(-1),initial.GetAmount<CorruptionPower>(actor.Creature)>0);              decimal petWeight=summon&&future.RemainingTurns>1?.5m+Math.Min(4,cards.Count(c=>c.Preview.Tags.Contains(CardTag.OstyAttack)))*.125m:0;              decimal reserve=Math.Max(me.MaxHp/3m,amounts.Sum());              bool forge=_legend&&actor.Character.Id.Entry=="REGENT";              bool bladePlan=forge&&cards.Any(c=>c.Preview is MegaCrit.Sts2.Core.Models.Cards.SummonForth or MegaCrit.Sts2.Core.Models.Cards.Conqueror or MegaCrit.Sts2.Core.Models.Cards.SwordSage);              // 按牌组里实际还会抽到的耗星牌估计需求。黑洞按产星或耗星的次数触发，星之子按花掉的星数触发。              decimal opportunities=Math.Min(Math.Max(0,future.RemainingTurns-1)*3,future.ReachableCards);              decimal Reach(int n)=>opportunities*n/Math.Max(1,cards.Length);              decimal spendEvents=forge?Reach(cards.Count(c=>c.Preview.CanonicalStarCost>0||c.Preview.HasStarCostX)):0;              decimal starDemand=forge?Reach(cards.Sum(c=>c.Preview.HasStarCostX?4:Math.Max(0,c.Preview.CanonicalStarCost))):0;              decimal printedGain=forge?Reach(cards.Count(c=>c.Preview.DynamicVars.ContainsKey("Stars"))):0;              // 每回合每种旋律最多触发一次。按剩余牌组中该旋律的张数，估算三张可出牌中出现该旋律的机会。              decimal MelodyChance(CardTag tag){                  int count=cards.Count(c=>c.Preview.Tags.Contains(tag));decimal miss=1;                  for(int i=0;i<Math.Min(3,cards.Length);i++)miss*=Math.Max(0,cards.Length-count-i)/(decimal)(cards.Length-i);                  return 1-miss;              }              decimal melodies=_legend&&fool?(MelodyChance(CardTag.Wah)+MelodyChance(CardTag.Cho)+MelodyChance(CardTag.Ki))*Math.Max(0,future.RemainingTurns-1):0;              var upgradeValues=new Dictionary<(CardModel,int),decimal>();              decimal access=Math.Min(1m,Math.Max(0,future.RemainingTurns-1)*5m/Math.Max(1,cards.Length));              // 牌堆中真实发生的升级仍能在以后的抽牌中生效；已消耗的牌不再计入。              decimal KeptCards(SimPlayerCombatState ps){                  if(!_legend||access<=0)return 0;                  decimal bladeValue=0,upgrades=0;                  void Visit(IReadOnlyList<PredictedCard> pile){                      for(int i=0;i<pile.Count;i++){var card=pile[i];var liveCard=card.Original;var next=card.Preview;                          if(bladePlan&&next is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade blade&&!blade.IsDupe)                              bladeValue=Math.Max(bladeValue,blade.DynamicVars.Damage.BaseValue*blade.DynamicVars.HitCount.IntValue);                          if(ReferenceEquals(liveCard,next)||next.CurrentUpgradeLevel<=liveCard.CurrentUpgradeLevel)continue;                          var key=(liveCard,next.CurrentUpgradeLevel);                          if(!upgradeValues.TryGetValue(key,out var gain)){                              // 仅比较升级本身，避免把同一条路线里额外铸造的剑伤算成升级收益。                              var upgraded=new PredictedCard(liveCard);                              for(int j=liveCard.CurrentUpgradeLevel;j<next.CurrentUpgradeLevel;j++)upgraded.Upgrade();                              var after=upgraded.Preview;                              gain=(decimal)(CardChoiceSupport.CardValue(after)-CardChoiceSupport.CardValue(liveCard))                                  +4*(liveCard.EnergyCost.GetWithModifiers(CostModifiers.None)-after.EnergyCost.GetWithModifiers(CostModifiers.None));                              upgradeValues[key]=gain;                          }                          upgrades+=gain;                      }                  }                  Visit(ps.Hand.Cards);Visit(ps.DrawPile.Cards);Visit(ps.DiscardPile.Cards);                  return Math.Min(bladeValue,future.EnemyHp)*.65m+access*upgrades;              }              decimal Setup(CombatPredictionSimulator sim){                  if(_tier==0)return 0;                  var combat=(SimulatedCombatState)sim.State.CombatState;                  var ps=sim.State.GetPlayerCombatState(actor);var powers=combat.EffectivePowers();                  decimal value=0;                  foreach(var power in powers){                      if(!StrategicEffectMirrors.Contributes(power,actor.Creature))continue;                      var ctx=power is DarkEmbracePower?future.WithExhaustDrawTiming(powers,ps.Hand.Cards,actor.Creature):future;                      decimal v=StrategicEffectModel.Evaluate(power,ctx).RetentionValue;                      // 空球栏保留集中以后启动的价值。已经成型的能力继续叠层时，边际收益渐减。                      if(power is FocusPower&&!ps.OrbQueue.Orbs.Any(o=>o is not MegaCrit.Sts2.Core.Models.Orbs.PlasmaOrb))v*=.35m;                      value+=16*v/(12+v);                      // 上游已估算剩余回合、可触发次数和敌方生命。只有后续回合确有收益才增加启动价值。                      if(_legend&&future.RemainingTurns>1&&v>12)value+=24*(v-12)/(36+v);                  }                  if(forge&&starDemand>0){                      int throne=combat.GetAmount<TheSealedThronePower>(actor.Creature),genesis=combat.GetAmount<GenesisPower>(actor.Creature);                      decimal events=(throne>0?opportunities:0)+(genesis>0?Math.Max(0,future.RemainingTurns-1):0);                      decimal supply=opportunities*throne+Math.Max(0,future.RemainingTurns-1)*genesis;                      // 有相应的耗星牌才能兑现资源。黑洞每个产星事件只触发一次，囤积星数不能重复计为伤害。                      decimal usable=Math.Min(starDemand,Math.Max(0,supply+printedGain+ps.Stars));                      value+=Math.Min(starDemand,supply)*1.5m                          +Math.Min(future.EnemyHp,combat.GetAmount<BlackHolePower>(actor.Creature)*(events+printedGain+Math.Min(usable,spendEvents)))*.65m                          +Math.Min(future.IncomingDamage,combat.GetAmount<ChildOfTheStarsPower>(actor.Creature)*usable)*.6m;                  }                  if(melodies>0){                      // 失落鲁特琴直接打出牌顶，曲中意只抽牌，不能把两种回报按同一价值计算。                      value+=Math.Min(future.EnemyHp,melodies*(combat.GetAmount<LostLutePower>(actor.Creature)*Math.Clamp(future.AverageCardValue,3,9)                          +combat.GetAmount<MotifPower>(actor.Creature)*2))*.8m;                  }                  return value+KeptCards(ps)+.5m*CombatBeamSolver.OrbRetentionValue(sim,ps.OrbQueue.Orbs,targets.Length);              }              decimal baseSetup=Setup(root);              decimal passPressure=targets.Sum(t=>Math.Min(root.State.GetCreature(t).CurrentHp+root.State.GetCreature(t).Block,pass.Hits.GetValueOrDefault(t)));              int hand=HandValue(root.State.GetPlayerCombatState(actor).Hand.Cards,initial);                            var front=new List<Branch>{new(root,[],0)};var chosen=front[0];var visited=new Dictionary<StateFingerprint,decimal>();              // 能量和手牌在推演途中可以支持后续动作；回合结束后的普通手牌与未用能量不能当作已获得的收益。              decimal bestEnd=0;              for(int depth=0;depth<24&&front.Count>0;depth++){                  var layer=new List<Branch>();                  foreach(var parent in front){                      var ps=parent.Sim.State.GetPlayerCombatState(actor);                      // 优先推演已经能发挥作用的牌；获得星星或消耗能量后，下一层按新次数重新排序。                      var beforePlay=(SimulatedCombatState)parent.Sim.State.CombatState;                      int Order(int i){                          var c=ps.Hand.Cards[i].Preview;                          // 先展开免费补充手牌或能量的分支，给同回合的准备牌和终结牌留出推演时间。                          if(_legend&&c.EnergyCost.GetAmountToSpend()==0&&(c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("Cards")))return -2;                          if(forge&&c is MegaCrit.Sts2.Core.Models.Cards.Conqueror&&ps.Hand.Cards.Any(p=>p.Preview is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade))return -1;                          if(c switch{                          MegaCrit.Sts2.Core.Models.Cards.Radiate=>beforePlay.GetStarsGainedThisTurn(actor)==0,                          MegaCrit.Sts2.Core.Models.Cards.HelixDrill=>beforePlay.GetEnergySpentThisTurn(actor)==0,                          MegaCrit.Sts2.Core.Models.Cards.LunarBlast=>beforePlay.GetSkillCardsPlayedThisTurn(actor.Creature)==0,                          _=>false})return 2;                          return c.Type==CardType.Power||_setup.Contains(c.Id.Entry)||CardEffectSpecRegistry.Contains(c)||                              c.DynamicVars.ContainsKey("Cards")||c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("WeakPower")||                              c.DynamicVars.ContainsKey("VulnerablePower")||c.DynamicVars.ContainsKey("StrengthPower")?0:1;                      }                      foreach(int i in Enumerable.Range(0,ps.Hand.Cards.Count).OrderBy(Order)){                          var move=ps.Hand.Cards[i];if(_unmodelledPlays.Contains(move.Preview.GetType())){incomplete=true;continue;}                          try{if(!parent.Sim.CanPlay(move))continue;}catch(NotSupportedException){incomplete=true;continue;}                          foreach(var aim in move.Preview.TargetType==TargetType.AnyEnemy?aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>():new Creature?[]{move.Preview.TargetType is TargetType.AnyAlly or TargetType.Self?actor.Creature:null}){                          if(attempted&&OutOfTime()){incomplete=true;return chosen;}                          attempted=true;                          // 直接出牌与每一种中途选择使用同一套攻防评分，复用上游的候选与动作回放。                          foreach(var result in PlayOptions(parent.Sim,i,aim,actor,3+2*_tier,OutOfTime,()=>incomplete=true)){                          var (sim,choices)=result;                          var handState=sim.State.GetPlayerCombatState(actor);var card=move;                          expanded++;                          var combat=(SimulatedCombatState)sim.State.CombatState;                          var own=sim.State.GetCreature(actor.Creature);                          var life=EndHealth(sim,out var mark,out int petAfterHits);                          // 已替主人承伤的生命不能重复计分。保留下来的奥斯提还能承伤，并能为后续出击提供伤害。                          decimal setup=Setup(sim)-baseSetup+(petAfterHits-basePet)*petWeight;                          decimal pressure=0;bool lethal=true;                          foreach(var target in targets){                              var foe=root.State.GetCreature(target);var enemy=sim.State.GetCreature(target);int hp=foe.CurrentHp;                              decimal attack=mark.Hits.GetValueOrDefault(target),hit=attack+hp-enemy.CurrentHp;                              int stacked=combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target);                              pressure+=(combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit);                              int activeDoom=combat.GetAmount<DoomPower>(target);                              decimal through=Math.Max(0,attack-foe.Block);                              if(activeDoom>0&&activeDoom>=enemy.CurrentHp-through&&life>0)pressure+=hp;                              lethal&=through>=enemy.CurrentHp;                          }                          // 生命宽裕时，只有确实换到持续收益，才可接受一部分本能挡下的失血。                          decimal investment=_legend&&setup>0&&life>reserve?Math.Max(0,Math.Min(setup,Math.Min(life-reserve,me.CurrentHp-life)))*.6m:0;                          decimal end=pressure-passPressure+setup+investment+(life-baseLife)*1.6m+(life>0&&baseLife<=0?10000:life<=0&&baseLife>0?-10000:0)                              +(handState.Stars-liveStars)*.5m;                          // 真实新增的有利状态可打破停手平局；不把玩家身上的虚弱倒算成已经登记的攻击减伤。                          bool ImprovesStatus()=>combat.EffectivePowers().Any(p=>p.Amount>0&&                              (p.Owner==actor.Creature?p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Buff:                              p.Owner.Side!=actor.Creature.Side&&p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Debuff)                              && !initial.EffectivePowers().Any(q=>q.Owner==p.Owner&&q.Id==p.Id&&q.Amount>=p.Amount));                          decimal score=end+(HandValue(handState.Hand.Cards,combat)-hand)*.8m+(handState.Energy-liveEnergy)*1.25m;                          var route=new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1),choices)};var b=new Branch(sim,route,score);                          if(end>bestEnd||end==bestEnd&&(chosen.Route.Count==0?ImprovesStatus():score>chosen.Score)){chosen=b;bestEnd=end;}                          if(lethal&&life>0)return b;                          var fingerprint=new StateFingerprintBuilder();                          fingerprint.Add(handState.Energy);fingerprint.Add(handState.Stars);fingerprint.Add(own.Block);fingerprint.Add(own.CurrentHp);                          if(summon){fingerprint.Add(LivingPet(sim));fingerprint.Add(combat.GetOstyMaxHp(sim,actor));}                          void Pile(IReadOnlyList<PredictedCard> cards){fingerprint.Add(cards.Count);foreach(var c in cards){var preview=c.Preview;fingerprint.Add(preview.Id.Entry);fingerprint.Add(preview.CurrentUpgradeLevel);                              if(forge&&preview is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade){fingerprint.Add(preview.DynamicVars.Damage.BaseValue);fingerprint.Add(preview.DynamicVars.HitCount.IntValue);}}}                          Pile(handState.Hand.Cards);Pile(handState.DrawPile.Cards);Pile(handState.DiscardPile.Cards);Pile(handState.ExhaustPile.Cards);                          fingerprint.Add(handState.OrbQueue.Capacity);                          foreach(var orb in handState.OrbQueue.Orbs){fingerprint.Add(orb.Id.Entry);fingerprint.Add(OrbMirrors.GetPassiveValue(sim,orb));fingerprint.Add(OrbMirrors.GetEvokeValue(sim,orb));}                          foreach(var power in combat.EffectivePowers()){fingerprint.Add(power.Owner.CombatId??uint.MaxValue);fingerprint.Add(power.Id.Entry);fingerprint.Add(power.Amount);}                          foreach(var target in targets){fingerprint.Add(mark.Hits.GetValueOrDefault(target));fingerprint.Add(mark.Stacks.GetValueOrDefault(target));}                          var key=fingerprint.Finish();                          if(visited.TryGetValue(key,out var old)&&old>=score)continue;visited[key]=score;layer.Add(b);                          }                          }                      }                  }                  front=layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList();              }              return chosen;              }finally{if(report!=null){searchMs=Stopwatch.GetElapsedTime(started).TotalMilliseconds;searchBytes=GC.GetAllocatedBytesForCurrentThread()-allocated;}}          })`
- `Take()`；输入表达式：`Take()`；返回值紧邻使用处：`IsPatternExpressionSyntax: Take() is {} next`
- `Take()`；输入表达式：`Take()`；返回值紧邻使用处：`ReturnStatementSyntax: return Take();`

**赋值（含属性/字段和局部值）：**

- `attempted` = `true`
- `bestEnd` = `end`
- `chosen` = `b`
- `EndTurn` = `best.Route.Count==0&&!incomplete&&expanded>0`
- `EndTurn` = `false`
- `front` = `layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList()`
- `incomplete` = `true`
- `lethal` &= `through>=enemy.CurrentHp`
- `pressure` += `(combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit)`
- `pressure` += `hp`
- `searchBytes` = `GC.GetAllocatedBytesForCurrentThread()-allocated`
- `searchMs` = `Stopwatch.GetElapsedTime(started).TotalMilliseconds`
- `var (root,targets)` = `Capture(amounts.Any(v=>v>0))`
- `var (sim,choices)` = `result`
- `visited[key]` = `score`

<a id="symbol-da6318aedee4"></a>

## `Take() — CardModel? Take()`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** `MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Queue<T>.TryDequeue(out T)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._route`；`NationalSpire.Solver.LeagueForecast.LastAim`；`NationalSpire.Solver.LeagueForecast.LastChoices`；`NationalSpire.Solver.LeagueForecast.Play.Aim`；`NationalSpire.Solver.LeagueForecast.Play.Choices`；`NationalSpire.Solver.LeagueForecast.Play.Id`；`NationalSpire.Solver.LeagueForecast.Play.Level`；`NationalSpire.Solver.LeagueForecast.Play.Live`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；输入表达式：`c.CanPlay()`；返回值紧邻使用处：`BinaryExpressionSyntax: (next.Live==null?c.Id.Entry==next.Id:ReferenceEquals(c,next.Live))&&c.CurrentUpgradeLevel==next.Level&&c.CanPlay()`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(c,next.Live)`；返回值紧邻使用处：`ConditionalExpressionSyntax: next.Live==null?c.Id.Entry==next.Id:ReferenceEquals(c,next.Live)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`realHand.FirstOrDefault(c=>(next.Live==null?c.Id.Entry==next.Id:ReferenceEquals(c,next.Live))&&c.CurrentUpgradeLevel==next.Level&&c.CanPlay())`；返回值紧邻使用处：`ReturnStatementSyntax: return realHand.FirstOrDefault(c=>(next.Live==null?c.Id.Entry==next.Id:ReferenceEquals(c,next.Live))&&c.CurrentUpgradeLevel==next.Level&&c.CanPlay());`
- `System.Collections.Generic.Queue<T>.TryDequeue(out T)`；输入表达式：`_route.TryDequeue(out var next)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_route.TryDequeue(out var next)`

**赋值（含属性/字段和局部值）：**

- `LastAim` = `next.Aim`
- `LastChoices` = `next.Choices`

<a id="symbol-3218bef2d5b1"></a>

## `OutOfTime() — bool OutOfTime()`

来源：源码第 154 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** `System.Threading.CancellationToken.ThrowIfCancellationRequested()`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._exit`；`NationalSpire.Solver.LeagueForecast._tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`_exit.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: _exit.ThrowIfCancellationRequested();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-61226e5575f6"></a>

## `LivingPet(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator) — int LivingPet(CombatPredictionSimulator sim)`

来源：源码第 156 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, out NationalSpire.Solver.LeagueForecast.Ledger, out int)`](LeagueForecast.cs.md#symbol-5ad747f95c4c)；[`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetOsty(MegaCrit.Sts2.Core.Entities.Players.Player)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`sim.State.GetCreature(pet)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sim.State.GetCreature(pet).CurrentHp`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetOsty(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`sim.State.GetOsty(actor)`；返回值紧邻使用处：`IsPatternExpressionSyntax: sim.State.GetOsty(actor) is {} pet`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5ad747f95c4c"></a>

## `EndHealth(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, out NationalSpire.Solver.LeagueForecast.Ledger, out int) — decimal EndHealth(CombatPredictionSimulator sim,out Ledger mark,out int petAfterHits)`

来源：源码第 157 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** [`LivingPet(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`](LeagueForecast.cs.md#symbol-61226e5575f6)；[`NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger)`](LeagueForecast.cs.md#symbol-9ecdb20e5b06)；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Damage(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Fork()`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；`CombatSolver.Engine.InCombat.Simulation.SimCreatureState.DamageBlock(decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；`CombatSolver.OrbLifecycleSupport.TriggerBeforeTurnEnd(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, CombatSolver.SimulatedCombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；`CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.SimulatedCombatState.GetPower<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.ValueProps.ValueProp.IsPoweredAttack()`；`System.Math.Max(decimal, decimal)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.Remove(TKey)`

**字段、属性、事件及方法组引用：** `LivingPet(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；`NationalSpire.Solver.LeagueForecast._incoming`；`NationalSpire.Solver.LeagueForecast.Damage`；`NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Damage(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, CombatSolver.Engine.Common.PredictedCard?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`；输入表达式：`end.Damage([actor.Creature],amount,props,attackerForHit,null,null,capped[k]?ModifyDamageHookType.Cap:ModifyDamageHookType.None)`；返回值紧邻使用处：`ExpressionStatementSyntax: end.Damage([actor.Creature],amount,props,attackerForHit,null,null,capped[k]?ModifyDamageHookType.Cap:ModifyDamageHookType.None);`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Fork()`；输入表达式：`sim.Fork()`；返回值紧邻使用处：`AssignmentExpressionSyntax: end=sim.Fork()`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.Fork()`；输入表达式：`sim.Fork()`；返回值紧邻使用处：`ConditionalExpressionSyntax: orbs||amounts.Length!=0?sim.Fork():sim`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`end.State.GetCreature(actor.Creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =end.State.GetCreature(actor.Creature)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`end.State.GetCreature(actor.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: end.State.GetCreature(actor.Creature).CurrentHp`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`end.State.GetCreature(actor.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: end.State.GetCreature(actor.Creature).IsAlive`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`sim.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sim.State.GetPlayerCombatState(actor).OrbQueue`
- `CombatSolver.Engine.InCombat.Simulation.SimCreatureState.DamageBlock(decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；输入表达式：`defending.DamageBlock(amounts[k],ValueProp.Move)`；返回值紧邻使用处：`BinaryExpressionSyntax: amounts[k]-defending.DamageBlock(amounts[k],ValueProp.Move)`
- `CombatSolver.OrbLifecycleSupport.TriggerBeforeTurnEnd(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, CombatSolver.SimulatedCombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`OrbLifecycleSupport.TriggerBeforeTurnEnd(end,(SimulatedCombatState)end.State.CombatState,actor)`；返回值紧邻使用处：`IfStatementSyntax: if(OrbLifecycleSupport.TriggerBeforeTurnEnd(end,(SimulatedCombatState)end.State.CombatState,actor))mark=projected;                      else end=sim.Fork();`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: ((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)>=defending.CurrentHp`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: ((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)>=hp`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetAmount<VulnerablePower>(attacker)`；返回值紧邻使用处：`BinaryExpressionSyntax: state.GetAmount<VulnerablePower>(attacker)>0`
- `CombatSolver.SimulatedCombatState.GetPower<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetPower<ColossusPower>(actor.Creature)`；返回值紧邻使用处：`IsPatternExpressionSyntax: state.GetPower<ColossusPower>(actor.Creature) is {} defense`
- `LivingPet(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`；输入表达式：`LivingPet(end)`；返回值紧邻使用处：`AssignmentExpressionSyntax: petAfterHits=LivingPet(end)`
- `MegaCrit.Sts2.Core.ValueProps.ValueProp.IsPoweredAttack()`；输入表达式：`props.IsPoweredAttack()`；返回值紧邻使用处：`BinaryExpressionSyntax: attackers[k] is {} attacker && props.IsPoweredAttack()`
- `NationalSpire.Solver.LeagueForecast.Ledger.Copy(NationalSpire.Solver.LeagueForecast.Ledger)`；输入表达式：`projected.Copy(mark)`；返回值紧邻使用处：`ExpressionStatementSyntax: projected.Copy(mark);`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(.1m,defending.CurrentHp-added*.85m)`；返回值紧邻使用处：`ConditionalExpressionSyntax: !defending.IsAlive||((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)>=defending.CurrentHp?0:Math.Max(.1m,defending.CurrentHp-added*.85m)`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Damage.GetOrCreateValue(end)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Damage.GetOrCreateValue(end)`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Damage.GetOrCreateValue(sim)`；返回值紧邻使用处：`AssignmentExpressionSyntax: mark=Damage.GetOrCreateValue(sim)`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.Remove(TKey)`；输入表达式：`Damage.Remove(end)`；返回值紧邻使用处：`ExpressionStatementSyntax: Damage.Remove(end);`

**赋值（含属性/字段和局部值）：**

- `_incoming` = `(attackerForHit,actor.Creature)`
- `_incoming` = `default`
- `added` += `(int)(amounts[k]-defending.DamageBlock(amounts[k],ValueProp.Move))`
- `amount` *= `defense.DynamicVars["DamageDecrease"].BaseValue`
- `end` = `sim.Fork()`
- `mark` = `Damage.GetOrCreateValue(sim)`
- `mark` = `projected`
- `petAfterHits` = `LivingPet(end)`

<a id="symbol-6fe64af03c5c"></a>

## `HandValue(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, CombatSolver.SimulatedCombatState) — int HandValue(IReadOnlyList<PredictedCard> cards,SimulatedCombatState state)`

来源：源码第 185 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetAmount<EcstasyPower>(actor.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: sadness-state.GetAmount<EcstasyPower>(actor.Creature)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,sadness-state.GetAmount<EcstasyPower>(actor.Creature))`；返回值紧邻使用处：`BinaryExpressionSyntax: cards.Count-sadness-Math.Max(0,sadness-state.GetAmount<EcstasyPower>(actor.Creature))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-432f6cb0ae06"></a>

## `Reach(int) — decimal Reach(int n)`

来源：源码第 203 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** `System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,cards.Length)`；返回值紧邻使用处：`BinaryExpressionSyntax: opportunities*n/Math.Max(1,cards.Length)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4497d59a5f80"></a>

## `MelodyChance(MegaCrit.Sts2.Core.Entities.Cards.CardTag) — decimal MelodyChance(CardTag tag)`

来源：源码第 208 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`c.Preview.Tags.Contains(tag)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>c.Preview.Tags.Contains(tag)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`cards.Count(c=>c.Preview.Tags.Contains(tag))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =cards.Count(c=>c.Preview.Tags.Contains(tag))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,cards.Length-count-i)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0,cards.Length-count-i)/(decimal)(cards.Length-i)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(3,cards.Length)`；返回值紧邻使用处：`BinaryExpressionSyntax: i<Math.Min(3,cards.Length)`

**赋值（含属性/字段和局部值）：**

- `miss` *= `Math.Max(0,cards.Length-count-i)/(decimal)(cards.Length-i)`

<a id="symbol-6bd052e66592"></a>

## `KeptCards(CombatSolver.Engine.InCombat.Simulation.SimPlayerCombatState) — decimal KeptCards(SimPlayerCombatState ps)`

来源：源码第 217 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Setup(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator)`](LeagueForecast.cs.md#symbol-0fd555495aa8)

**调用：** [`Visit(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`](LeagueForecast.cs.md#symbol-e0f8ea4c762e)；`System.Math.Min(decimal, decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._legend`；`Visit(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(bladeValue,future.EnemyHp)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(bladeValue,future.EnemyHp)*.65m`
- `Visit(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`；输入表达式：`Visit(ps.DiscardPile.Cards)`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(ps.DiscardPile.Cards);`
- `Visit(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`；输入表达式：`Visit(ps.DrawPile.Cards)`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(ps.DrawPile.Cards);`
- `Visit(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>)`；输入表达式：`Visit(ps.Hand.Cards)`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(ps.Hand.Cards);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e0f8ea4c762e"></a>

## `Visit(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>) — void Visit(IReadOnlyList<PredictedCard> pile)`

来源：源码第 220 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`KeptCards(CombatSolver.Engine.InCombat.Simulation.SimPlayerCombatState)`](LeagueForecast.cs.md#symbol-6bd052e66592)

**调用：** `CombatSolver.CardChoiceSupport.CardValue(MegaCrit.Sts2.Core.Models.CardModel)`；`CombatSolver.Engine.Common.PredictedCard.PredictedCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel?)`；`CombatSolver.Engine.Common.PredictedCard.Upgrade()`；`MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost.GetWithModifiers(MegaCrit.Sts2.Core.Entities.Cards.CostModifiers)`；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Math.Max(decimal, decimal)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.CardChoiceSupport.CardValue(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`CardChoiceSupport.CardValue(after)`；返回值紧邻使用处：`BinaryExpressionSyntax: CardChoiceSupport.CardValue(after)-CardChoiceSupport.CardValue(liveCard)`
- `CombatSolver.CardChoiceSupport.CardValue(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`CardChoiceSupport.CardValue(liveCard)`；返回值紧邻使用处：`BinaryExpressionSyntax: CardChoiceSupport.CardValue(after)-CardChoiceSupport.CardValue(liveCard)`
- `CombatSolver.Engine.Common.PredictedCard.PredictedCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel?)`；输入表达式：`new PredictedCard(liveCard)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PredictedCard(liveCard)`
- `CombatSolver.Engine.Common.PredictedCard.Upgrade()`；输入表达式：`upgraded.Upgrade()`；返回值紧邻使用处：`ExpressionStatementSyntax: upgraded.Upgrade();`
- `MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost.GetWithModifiers(MegaCrit.Sts2.Core.Entities.Cards.CostModifiers)`；输入表达式：`after.EnergyCost.GetWithModifiers(CostModifiers.None)`；返回值紧邻使用处：`BinaryExpressionSyntax: liveCard.EnergyCost.GetWithModifiers(CostModifiers.None)-after.EnergyCost.GetWithModifiers(CostModifiers.None)`
- `MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost.GetWithModifiers(MegaCrit.Sts2.Core.Entities.Cards.CostModifiers)`；输入表达式：`liveCard.EnergyCost.GetWithModifiers(CostModifiers.None)`；返回值紧邻使用处：`BinaryExpressionSyntax: liveCard.EnergyCost.GetWithModifiers(CostModifiers.None)-after.EnergyCost.GetWithModifiers(CostModifiers.None)`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(liveCard,next)`；返回值紧邻使用处：`BinaryExpressionSyntax: ReferenceEquals(liveCard,next)||next.CurrentUpgradeLevel<=liveCard.CurrentUpgradeLevel`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`upgradeValues.TryGetValue(key,out var gain)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !upgradeValues.TryGetValue(key,out var gain)`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(bladeValue,blade.DynamicVars.Damage.BaseValue*blade.DynamicVars.HitCount.IntValue)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bladeValue=Math.Max(bladeValue,blade.DynamicVars.Damage.BaseValue*blade.DynamicVars.HitCount.IntValue)`

**赋值（含属性/字段和局部值）：**

- `bladeValue` = `Math.Max(bladeValue,blade.DynamicVars.Damage.BaseValue*blade.DynamicVars.HitCount.IntValue)`
- `gain` = `(decimal)(CardChoiceSupport.CardValue(after)-CardChoiceSupport.CardValue(liveCard))                                  +4*(liveCard.EnergyCost.GetWithModifiers(CostModifiers.None)-after.EnergyCost.GetWithModifiers(CostModifiers.None))`
- `upgrades` += `gain`
- `upgradeValues[key]` = `gain`

<a id="symbol-0fd555495aa8"></a>

## `Setup(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator) — decimal Setup(CombatPredictionSimulator sim)`

来源：源码第 241 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** [`KeptCards(CombatSolver.Engine.InCombat.Simulation.SimPlayerCombatState)`](LeagueForecast.cs.md#symbol-6bd052e66592)；`CombatSolver.CombatBeamSolver.OrbRetentionValue(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.OrbModel>, int)`；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；`CombatSolver.SimulatedCombatState.EffectivePowers()`；`CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.StrategicEffectContext.WithExhaustDrawTiming(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.PowerModel>, System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.StrategicEffectMirrors.Contributes(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.StrategicEffectModel.Evaluate(MegaCrit.Sts2.Core.Models.PowerModel, CombatSolver.StrategicEffectContext)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(decimal, decimal)`；`System.Math.Max(int, int)`；`System.Math.Min(decimal, decimal)`

**字段、属性、事件及方法组引用：** `KeptCards(CombatSolver.Engine.InCombat.Simulation.SimPlayerCombatState)`；`NationalSpire.Solver.LeagueForecast._legend`；`NationalSpire.Solver.LeagueForecast._tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.CombatBeamSolver.OrbRetentionValue(CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.OrbModel>, int)`；输入表达式：`CombatBeamSolver.OrbRetentionValue(sim,ps.OrbQueue.Orbs,targets.Length)`；返回值紧邻使用处：`BinaryExpressionSyntax: .5m*CombatBeamSolver.OrbRetentionValue(sim,ps.OrbQueue.Orbs,targets.Length)`
- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionState.GetPlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`sim.State.GetPlayerCombatState(actor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sim.State.GetPlayerCombatState(actor)`
- `CombatSolver.SimulatedCombatState.EffectivePowers()`；输入表达式：`combat.EffectivePowers()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =combat.EffectivePowers()`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<BlackHolePower>(actor.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<BlackHolePower>(actor.Creature)*(events+printedGain+Math.Min(usable,spendEvents))`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<ChildOfTheStarsPower>(actor.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<ChildOfTheStarsPower>(actor.Creature)*usable`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<GenesisPower>(actor.Creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =combat.GetAmount<GenesisPower>(actor.Creature)`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<LostLutePower>(actor.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<LostLutePower>(actor.Creature)*Math.Clamp(future.AverageCardValue,3,9)`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<MotifPower>(actor.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<MotifPower>(actor.Creature)*2`
- `CombatSolver.SimulatedCombatState.GetAmount<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`combat.GetAmount<TheSealedThronePower>(actor.Creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =combat.GetAmount<TheSealedThronePower>(actor.Creature)`
- `CombatSolver.StrategicEffectContext.WithExhaustDrawTiming(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.PowerModel>, System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`future.WithExhaustDrawTiming(powers,ps.Hand.Cards,actor.Creature)`；返回值紧邻使用处：`ConditionalExpressionSyntax: power is DarkEmbracePower?future.WithExhaustDrawTiming(powers,ps.Hand.Cards,actor.Creature):future`
- `CombatSolver.StrategicEffectMirrors.Contributes(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`StrategicEffectMirrors.Contributes(power,actor.Creature)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !StrategicEffectMirrors.Contributes(power,actor.Creature)`
- `CombatSolver.StrategicEffectModel.Evaluate(MegaCrit.Sts2.Core.Models.PowerModel, CombatSolver.StrategicEffectContext)`；输入表达式：`StrategicEffectModel.Evaluate(power,ctx)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: StrategicEffectModel.Evaluate(power,ctx).RetentionValue`
- `KeptCards(CombatSolver.Engine.InCombat.Simulation.SimPlayerCombatState)`；输入表达式：`KeptCards(ps)`；返回值紧邻使用处：`BinaryExpressionSyntax: value+KeptCards(ps)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`ps.OrbQueue.Orbs.Any(o=>o is not MegaCrit.Sts2.Core.Models.Orbs.PlasmaOrb)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ps.OrbQueue.Orbs.Any(o=>o is not MegaCrit.Sts2.Core.Models.Orbs.PlasmaOrb)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(future.AverageCardValue,3,9)`；返回值紧邻使用处：`BinaryExpressionSyntax: combat.GetAmount<LostLutePower>(actor.Creature)*Math.Clamp(future.AverageCardValue,3,9)`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0,supply+printedGain+ps.Stars)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,supply+printedGain+ps.Stars)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,future.RemainingTurns-1)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0,future.RemainingTurns-1)*genesis`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,future.RemainingTurns-1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: genesis>0?Math.Max(0,future.RemainingTurns-1):0`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(future.EnemyHp,combat.GetAmount<BlackHolePower>(actor.Creature)*(events+printedGain+Math.Min(usable,spendEvents)))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(future.EnemyHp,combat.GetAmount<BlackHolePower>(actor.Creature)*(events+printedGain+Math.Min(usable,spendEvents)))*.65m`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(future.EnemyHp,melodies*(combat.GetAmount<LostLutePower>(actor.Creature)*Math.Clamp(future.AverageCardValue,3,9)                          +combat.GetAmount<MotifPower>(actor.Creature)*2))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(future.EnemyHp,melodies*(combat.GetAmount<LostLutePower>(actor.Creature)*Math.Clamp(future.AverageCardValue,3,9)                          +combat.GetAmount<MotifPower>(actor.Creature)*2))*.8m`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(future.IncomingDamage,combat.GetAmount<ChildOfTheStarsPower>(actor.Creature)*usable)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(future.IncomingDamage,combat.GetAmount<ChildOfTheStarsPower>(actor.Creature)*usable)*.6m`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(starDemand,Math.Max(0,supply+printedGain+ps.Stars))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(starDemand,Math.Max(0,supply+printedGain+ps.Stars))`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(starDemand,supply)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(starDemand,supply)*1.5m`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(usable,spendEvents)`；返回值紧邻使用处：`BinaryExpressionSyntax: events+printedGain+Math.Min(usable,spendEvents)`

**赋值（含属性/字段和局部值）：**

- `v` *= `.35m`
- `value` += `16*v/(12+v)`
- `value` += `24*(v-12)/(36+v)`
- `value` += `Math.Min(future.EnemyHp,melodies*(combat.GetAmount<LostLutePower>(actor.Creature)*Math.Clamp(future.AverageCardValue,3,9)                          +combat.GetAmount<MotifPower>(actor.Creature)*2))*.8m`
- `value` += `Math.Min(starDemand,supply)*1.5m                          +Math.Min(future.EnemyHp,combat.GetAmount<BlackHolePower>(actor.Creature)*(events+printedGain+Math.Min(usable,spendEvents)))*.65m                          +Math.Min(future.IncomingDamage,combat.GetAmount<ChildOfTheStarsPower>(actor.Creature)*usable)*.6m`

<a id="symbol-8d10ec45aa4a"></a>

## `Order(int) — int Order(int i)`

来源：源码第 286 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `CombatSolver.CardEffectSpecRegistry.Contains(MegaCrit.Sts2.Core.Models.CardModel)`；`CombatSolver.SimulatedCombatState.GetEnergySpentThisTurn(MegaCrit.Sts2.Core.Entities.Players.Player)`；`CombatSolver.SimulatedCombatState.GetSkillCardsPlayedThisTurn(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`CombatSolver.SimulatedCombatState.GetStarsGainedThisTurn(MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost.GetAmountToSpend()`；`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.ContainsKey(string)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._legend`；`NationalSpire.Solver.LeagueForecast._setup`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.CardEffectSpecRegistry.Contains(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`CardEffectSpecRegistry.Contains(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Type==CardType.Power||_setup.Contains(c.Id.Entry)||CardEffectSpecRegistry.Contains(c)`
- `CombatSolver.SimulatedCombatState.GetEnergySpentThisTurn(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`beforePlay.GetEnergySpentThisTurn(actor)`；返回值紧邻使用处：`BinaryExpressionSyntax: beforePlay.GetEnergySpentThisTurn(actor)==0`
- `CombatSolver.SimulatedCombatState.GetSkillCardsPlayedThisTurn(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`beforePlay.GetSkillCardsPlayedThisTurn(actor.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: beforePlay.GetSkillCardsPlayedThisTurn(actor.Creature)==0`
- `CombatSolver.SimulatedCombatState.GetStarsGainedThisTurn(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`beforePlay.GetStarsGainedThisTurn(actor)`；返回值紧邻使用处：`BinaryExpressionSyntax: beforePlay.GetStarsGainedThisTurn(actor)==0`
- `MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost.GetAmountToSpend()`；输入表达式：`c.EnergyCost.GetAmountToSpend()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.EnergyCost.GetAmountToSpend()==0`
- `MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.ContainsKey(string)`；输入表达式：`c.DynamicVars.ContainsKey("Cards")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("Cards")`
- `MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.ContainsKey(string)`；输入表达式：`c.DynamicVars.ContainsKey("Cards")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Type==CardType.Power||_setup.Contains(c.Id.Entry)||CardEffectSpecRegistry.Contains(c)||                              c.DynamicVars.ContainsKey("Cards")`
- `MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.ContainsKey(string)`；输入表达式：`c.DynamicVars.ContainsKey("Energy")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("Cards")`
- `MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.ContainsKey(string)`；输入表达式：`c.DynamicVars.ContainsKey("Energy")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Type==CardType.Power||_setup.Contains(c.Id.Entry)||CardEffectSpecRegistry.Contains(c)||                              c.DynamicVars.ContainsKey("Cards")||c.DynamicVars.ContainsKey("Energy")`
- `MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.ContainsKey(string)`；输入表达式：`c.DynamicVars.ContainsKey("StrengthPower")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Type==CardType.Power||_setup.Contains(c.Id.Entry)||CardEffectSpecRegistry.Contains(c)||                              c.DynamicVars.ContainsKey("Cards")||c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("WeakPower")||                              c.DynamicVars.ContainsKey("VulnerablePower")||c.DynamicVars.ContainsKey("StrengthPower")`
- `MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.ContainsKey(string)`；输入表达式：`c.DynamicVars.ContainsKey("VulnerablePower")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Type==CardType.Power||_setup.Contains(c.Id.Entry)||CardEffectSpecRegistry.Contains(c)||                              c.DynamicVars.ContainsKey("Cards")||c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("WeakPower")||                              c.DynamicVars.ContainsKey("VulnerablePower")`
- `MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.ContainsKey(string)`；输入表达式：`c.DynamicVars.ContainsKey("WeakPower")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Type==CardType.Power||_setup.Contains(c.Id.Entry)||CardEffectSpecRegistry.Contains(c)||                              c.DynamicVars.ContainsKey("Cards")||c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("WeakPower")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_setup.Contains(c.Id.Entry)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Type==CardType.Power||_setup.Contains(c.Id.Entry)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`ps.Hand.Cards.Any(p=>p.Preview is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade)`；返回值紧邻使用处：`BinaryExpressionSyntax: forge&&c is MegaCrit.Sts2.Core.Models.Cards.Conqueror&&ps.Hand.Cards.Any(p=>p.Preview is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7198ff2a64ff"></a>

## `ImprovesStatus() — bool ImprovesStatus()`

来源：源码第 332 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** `CombatSolver.SimulatedCombatState.EffectivePowers()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.SimulatedCombatState.EffectivePowers()`；输入表达式：`combat.EffectivePowers()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: combat.EffectivePowers().Any`
- `CombatSolver.SimulatedCombatState.EffectivePowers()`；输入表达式：`initial.EffectivePowers()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: initial.EffectivePowers().Any`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`combat.EffectivePowers().Any(p=>p.Amount>0&&                              (p.Owner==actor.Creature?p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Buff:                              p.Owner.Side!=actor.Creature.Side&&p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Debuff)                              && !initial.EffectivePowers().Any(q=>q.Owner==p.Owner&&q.Id==p.Id&&q.Amount>=p.Amount))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>combat.EffectivePowers().Any(p=>p.Amount>0&&                              (p.Owner==actor.Creature?p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Buff:                              p.Owner.Side!=actor.Creature.Side&&p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Debuff)                              && !initial.EffectivePowers().Any(q=>q.Owner==p.Owner&&q.Id==p.Id&&q.Amount>=p.Amount))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`initial.EffectivePowers().Any(q=>q.Owner==p.Owner&&q.Id==p.Id&&q.Amount>=p.Amount)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !initial.EffectivePowers().Any(q=>q.Owner==p.Owner&&q.Id==p.Id&&q.Amount>=p.Amount)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e81d6412b9f1"></a>

## `Pile(System.Collections.Generic.IReadOnlyList<CombatSolver.Engine.Common.PredictedCard>) — void Pile(IReadOnlyList<PredictedCard> cards)`

来源：源码第 343 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** `CombatSolver.StateFingerprintBuilder.Add(decimal)`；`CombatSolver.StateFingerprintBuilder.Add(int)`；`CombatSolver.StateFingerprintBuilder.Add(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.StateFingerprintBuilder.Add(decimal)`；输入表达式：`fingerprint.Add(preview.DynamicVars.Damage.BaseValue)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(preview.DynamicVars.Damage.BaseValue);`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(cards.Count)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(cards.Count);`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(preview.CurrentUpgradeLevel)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(preview.CurrentUpgradeLevel);`
- `CombatSolver.StateFingerprintBuilder.Add(int)`；输入表达式：`fingerprint.Add(preview.DynamicVars.HitCount.IntValue)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(preview.DynamicVars.HitCount.IntValue);`
- `CombatSolver.StateFingerprintBuilder.Add(string?)`；输入表达式：`fingerprint.Add(preview.Id.Entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: fingerprint.Add(preview.Id.Entry);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1c0fdc3118f7"></a>

## `NationalSpire.Solver.LeagueForecast.Capture(bool) — private (CombatPredictionSimulator,Creature[]) Capture(bool attacking)`

来源：源码第 370 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** [`Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueForecast.cs.md#symbol-254fe0ec53c4)；[`NationalSpire.Solver.LeagueForecast.CaptureProjection.CaptureProjection(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Combat.CombatState, System.Collections.Generic.HashSet<System.Type>)`](LeagueForecast.Projection.cs.md#symbol-42e407d1105a)；[`NationalSpire.Solver.LeagueForecast.MapHistory(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`](LeagueForecast.History.cs.md#symbol-6f96751f4567)；[`NationalSpire.Solver.LeagueForecast.ProjectRunRules(MegaCrit.Sts2.Core.Runs.RunState)`](LeagueForecast.Projection.cs.md#symbol-9126065de703)；`CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.CombatPredictionSimulator(MegaCrit.Sts2.Core.Combat.ICombatState)`；`CombatSolver.SimulatedCombatState.SimulatedCombatState(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Models.AbstractModel[]?)`；`HarmonyLib.AccessTools.Field(System.Type, string)`；`HarmonyLib.AccessTools.FieldRef<T, F>.Invoke(T)`（委托实际目标见流程文档）；`MegaCrit.Sts2.Core.Combat.CombatState.AddCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Combat.CombatState.AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Combat.CombatState.AddPlayer(MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Combat.CombatState.CombatState(MegaCrit.Sts2.Core.Models.EncounterModel?, MegaCrit.Sts2.Core.Runs.IRunState?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel>?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RunModel>?, MegaCrit.Sts2.Core.Models.Dread.DominionModel?)`；`MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature(MegaCrit.Sts2.Core.Models.MonsterModel, MegaCrit.Sts2.Core.Combat.CombatSide, string?)`；`MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Entities.Cards.CardPile.AddInternal(MegaCrit.Sts2.Core.Models.CardModel, int, bool)`；`MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot.ArrowSlot(MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.AddCapacity(int)`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.Clear()`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.Insert(int, MegaCrit.Sts2.Core.Models.OrbModel)`；`MegaCrit.Sts2.Core.Entities.Players.Player.AddRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel, int, bool)`；`MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；`MegaCrit.Sts2.Core.Entities.Players.Player.RemoveRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel, bool)`；`MegaCrit.Sts2.Core.Entities.Players.Player.ResetCombatState()`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AddPetInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.GainEnergy(decimal)`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.IncrementTurnNumber()`；`MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；`MegaCrit.Sts2.Core.Models.ActModel.ToMutable()`；`MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；`MegaCrit.Sts2.Core.Models.MonsterModel.RollMove(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；`MegaCrit.Sts2.Core.Models.MonsterModel.SetUpForCombat()`；`MegaCrit.Sts2.Core.Models.MonsterModel.ToMutable()`；`MegaCrit.Sts2.Core.Models.RelicModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic)`；`MegaCrit.Sts2.Core.Models.RelicModel.ToSerializable()`；`MegaCrit.Sts2.Core.Runs.RunRngSet.LoadFromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet)`；`MegaCrit.Sts2.Core.Runs.RunRngSet.ToSerializable()`；`MegaCrit.Sts2.Core.Runs.RunState.CreateForNewRun(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, MegaCrit.Sts2.Core.Runs.GameMode, bool, int, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Reflection.FieldInfo.GetValue(object?)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`

**字段、属性、事件及方法组引用：** `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.Solver.LeagueForecast._actor`；`NationalSpire.Solver.LeagueForecast._aims`；`NationalSpire.Solver.LeagueForecast._live`；`NationalSpire.Solver.LeagueForecast._mappedHistory`；`NationalSpire.Solver.LeagueForecast._originals`；`NationalSpire.Solver.LeagueForecast._unmodelledPlays`；`NationalSpire.Solver.LeagueForecast.Damage`；`NationalSpire.Solver.LeagueForecast.liveEnergy`；`NationalSpire.Solver.LeagueForecast.liveStars`；`NationalSpire.Solver.LeagueForecast.MapHistory(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；`NationalSpire.Solver.LeagueForecast.ProjectRunRules(MegaCrit.Sts2.Core.Runs.RunState)`；`NationalSpire.Solver.LeagueForecast.StarBalance`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.Engine.InCombat.Simulation.CombatPredictionSimulator.CombatPredictionSimulator(MegaCrit.Sts2.Core.Combat.ICombatState)`；输入表达式：`new CombatPredictionSimulator(new SimulatedCombatState(board))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CombatPredictionSimulator(new SimulatedCombatState(board))`
- `CombatSolver.SimulatedCombatState.SimulatedCombatState(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Models.AbstractModel[]?)`；输入表达式：`new SimulatedCombatState(board)`；返回值紧邻使用处：`ArgumentSyntax: new SimulatedCombatState(board)`
- `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Copy(_live.Creature,actor.Creature)`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(_live.Creature,actor.Creature);`
- `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Copy(realPet,pet)`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(realPet,pet);`
- `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Copy(realTargets[i],targets[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(realTargets[i],targets[i]);`
- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(PlayerCombatState),"_arrows")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Field(typeof(PlayerCombatState),"_arrows").GetValue`
- `HarmonyLib.AccessTools.FieldRef<T, F>.Invoke(T)`；输入表达式：`StarBalance(ps)`；返回值紧邻使用处：`AssignmentExpressionSyntax: StarBalance(ps)=old.Stars`
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
- `MegaCrit.Sts2.Core.Runs.RunRngSet.LoadFromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet)`；输入表达式：`run.Rng.LoadFromSerializable(_live.RunState.Rng.ToSerializable())`；返回值紧邻使用处：`ExpressionStatementSyntax: run.Rng.LoadFromSerializable(_live.RunState.Rng.ToSerializable());`
- `MegaCrit.Sts2.Core.Runs.RunRngSet.ToSerializable()`；输入表达式：`_live.RunState.Rng.ToSerializable()`；返回值紧邻使用处：`ArgumentSyntax: _live.RunState.Rng.ToSerializable()`
- `MegaCrit.Sts2.Core.Runs.RunState.CreateForNewRun(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, MegaCrit.Sts2.Core.Runs.GameMode, bool, int, string)`；输入表达式：`RunState.CreateForNewRun([actor],_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList(),[],GameMode.Standard,false,0,_live.RunState.Rng.StringSeed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =RunState.CreateForNewRun([actor],_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList(),[],GameMode.Standard,false,0,_live.RunState.Rng.StringSeed)`
- `NationalSpire.Solver.LeagueForecast.CaptureProjection.CaptureProjection(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Combat.CombatState, System.Collections.Generic.HashSet<System.Type>)`；输入表达式：`new CaptureProjection(run,board,_unmodelledPlays)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CaptureProjection(run,board,_unmodelledPlays)`
- `NationalSpire.Solver.LeagueForecast.MapHistory(MegaCrit.Sts2.Core.Combat.CombatState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；输入表达式：`MapHistory(board,actor,creatures)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _mappedHistory=MapHistory(board,actor,creatures)`
- `NationalSpire.Solver.LeagueForecast.ProjectRunRules(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`ProjectRunRules(run)`；返回值紧邻使用处：`ExpressionStatementSyntax: ProjectRunRules(run);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_originals.Add(card,original)`；返回值紧邻使用处：`ExpressionStatementSyntax: _originals.Add(card,original);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`arrows.Add(slot,next)`；返回值紧邻使用处：`ExpressionStatementSyntax: arrows.Add(slot,next);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`creatures.Add(realTargets[i],targets[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: creatures.Add(realTargets[i],targets[i]);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<ArrowSlot,ArrowSlot>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<ArrowSlot,ArrowSlot>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<Creature,Creature>{{_live.Creature,actor.Creature}}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<Creature,Creature>{{_live.Creature,actor.Creature}}`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`ps.AllPiles.First(p=>p.Type==pile.Type)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ps.AllPiles.First(p=>p.Type==pile.Type)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`realTargets.Select(other=>{              MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);              board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;          })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: realTargets.Select(other=>{              MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);              board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;          }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`actor.Relics.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var r in actor.Relics.ToArray())actor.RemoveRelicInternal(r,true);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`realTargets.Select(other=>{              MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);              board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;          }).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =realTargets.Select(other=>{              MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);              board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;          }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList()`；返回值紧邻使用处：`ArgumentSyntax: _live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`slots.Add(next)`；返回值紧邻使用处：`ExpressionStatementSyntax: slots.Add(next);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`slots.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: slots.Clear();`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`AccessTools.Field(typeof(PlayerCombatState),"_arrows").GetValue(ps)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: AccessTools.Field(typeof(PlayerCombatState),"_arrows").GetValue(ps)!`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Damage.GetOrCreateValue(root)`；返回值紧邻使用处：`ExpressionStatementSyntax: Damage.GetOrCreateValue(root);`

**赋值（含属性/字段和局部值）：**

- `_actor` = `actor`
- `_aims[target]` = `checked((int)other.CombatId!.Value)`
- `_mappedHistory` = `MapHistory(board,actor,creatures)`
- `_mappedHistory` = `null`
- `board.RoundNumber` = `_live.Creature.CombatState!.RoundNumber`
- `card.Owner` = `null!`
- `clone.Owner` = `actor`
- `clone.Owner` = `null!`
- `creatures[sourcePet]` = `copyPet`
- `DestroyAfterImpaled` = `slot.DestroyAfterImpaled`
- `liveEnergy` = `old.Energy`
- `liveStars` = `old.Stars`
- `StarBalance(ps)` = `old.Stars`
- `Status` = `slot.Status`

<a id="symbol-254fe0ec53c4"></a>

## `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — void Copy(Creature src,Creature dst)`

来源：源码第 387 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 415 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AfterCombatEnd()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._actor`；`NationalSpire.Solver.LeagueForecast._aims`；`NationalSpire.Solver.LeagueForecast._originals`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AfterCombatEnd()`；输入表达式：`.AfterCombatEnd()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .PlayerCombatState?.AfterCombatEnd()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_aims.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _aims.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_originals.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _originals.Clear();`

**赋值（含属性/字段和局部值）：**

- `_actor` = `null`
