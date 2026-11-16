# Compatibility/LeagueSolver/LeagueForecast.Projection.cs

[返回文件依赖索引](../../../SOURCE_MAP.md)

源码 SHA-256：`9BEF88F536459813CC23010321BFFB1137F5C5E6291046B32F485FBDB7AA8A6E`。来源：[源码](../../../../Compatibility/LeagueSolver/LeagueForecast.Projection.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Solver.LeagueForecast`、`NationalSpire.Solver.LeagueForecast.CaptureProjection`。

字段、事件及初始值（源码原样）：

```csharp
private readonly HashSet<Type> _unmodelledPlays=[];
[ThreadStatic] private static CaptureProjection? _capture;
internal readonly RunState Run;
internal readonly CombatState Board;
internal readonly HashSet<Type> Unmodelled;
internal readonly AbstractModel[] RunSubscribers,CombatSubscribers;
private readonly CaptureProjection? _previous;
```

<a id="symbol-163109bb6d15"></a>

## `NationalSpire.Solver.LeagueForecast.SetRunRules(MegaCrit.Sts2.Core.Runs.RunState, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RunModel>) — [UnsafeAccessor(UnsafeAccessorKind.Method,Name="set_RunModels")]     private static extern void SetRunRules(RunState run,IReadOnlyList<RunModel> rules);`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.ProjectRunRules(MegaCrit.Sts2.Core.Runs.RunState)`](LeagueForecast.Projection.cs.md#symbol-9126065de703)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9126065de703"></a>

## `NationalSpire.Solver.LeagueForecast.ProjectRunRules(MegaCrit.Sts2.Core.Runs.RunState) — private static void ProjectRunRules(RunState run)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Capture(bool)`](LeagueForecast.cs.md#symbol-1c0fdc3118f7)

**调用：** [`Known(MegaCrit.Sts2.Core.Models.RunModel)`](LeagueForecast.Projection.cs.md#symbol-102f4472ae60)；[`NationalSpire.Solver.LeagueForecast.SetRunRules(MegaCrit.Sts2.Core.Runs.RunState, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RunModel>)`](LeagueForecast.Projection.cs.md#symbol-163109bb6d15)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Known(MegaCrit.Sts2.Core.Models.RunModel)`；`NationalSpire.Solver.LeagueForecast.SetRunRules(MegaCrit.Sts2.Core.Runs.RunState, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RunModel>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Known(MegaCrit.Sts2.Core.Models.RunModel)`；输入表达式：`Known(r)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Known(r)`
- `NationalSpire.Solver.LeagueForecast.SetRunRules(MegaCrit.Sts2.Core.Runs.RunState, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RunModel>)`；输入表达式：`SetRunRules(run,run.RunModels.Where(Known).ToArray())`；返回值紧邻使用处：`ExpressionStatementSyntax: SetRunRules(run,run.RunModels.Where(Known).ToArray());`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`run.RunModels.Any(r=>!Known(r))`；返回值紧邻使用处：`IfStatementSyntax: if(run.RunModels.Any(r=>!Known(r)))SetRunRules(run,run.RunModels.Where(Known).ToArray());`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`run.RunModels.Where(Known).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: run.RunModels.Where(Known).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`run.RunModels.Where(Known)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: run.RunModels.Where(Known).ToArray`

**赋值（含属性/字段和局部值）：**


<a id="symbol-102f4472ae60"></a>

## `Known(MegaCrit.Sts2.Core.Models.RunModel) — static bool Known(RunModel rule)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.ProjectRunRules(MegaCrit.Sts2.Core.Runs.RunState)`](LeagueForecast.Projection.cs.md#symbol-9126065de703)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-42e407d1105a"></a>

## `NationalSpire.Solver.LeagueForecast.CaptureProjection.CaptureProjection(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Combat.CombatState, System.Collections.Generic.HashSet<System.Type>) — internal CaptureProjection(RunState run,CombatState board,HashSet<Type> unmodelled)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Capture(bool)`](LeagueForecast.cs.md#symbol-1c0fdc3118f7)

**调用：** [`NationalSpire.Solver.LeagueForecast.CaptureProjection.Supported(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>, string)`](LeagueForecast.Projection.cs.md#symbol-46d29f8b6749)；`MegaCrit.Sts2.Core.Modding.ModHelper.IterateAllCombatStateSubscribers(MegaCrit.Sts2.Core.Combat.CombatState)`；`MegaCrit.Sts2.Core.Modding.ModHelper.IterateAllRunStateSubscribers(MegaCrit.Sts2.Core.Runs.RunState)`；`System.Collections.Generic.HashSet<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._capture`；`NationalSpire.Solver.LeagueForecast.CaptureProjection._previous`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.Board`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.CombatSubscribers`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.Run`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.RunSubscribers`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.Supported(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>, string)`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.Unmodelled`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Modding.ModHelper.IterateAllCombatStateSubscribers(MegaCrit.Sts2.Core.Combat.CombatState)`；输入表达式：`ModHelper.IterateAllCombatStateSubscribers(board)`；返回值紧邻使用处：`ArgumentSyntax: ModHelper.IterateAllCombatStateSubscribers(board)`
- `MegaCrit.Sts2.Core.Modding.ModHelper.IterateAllRunStateSubscribers(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`ModHelper.IterateAllRunStateSubscribers(run)`；返回值紧邻使用处：`ArgumentSyntax: ModHelper.IterateAllRunStateSubscribers(run)`
- `NationalSpire.Solver.LeagueForecast.CaptureProjection.Supported(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>, string)`；输入表达式：`Supported(ModHelper.IterateAllCombatStateSubscribers(board),"combat")`；返回值紧邻使用处：`AssignmentExpressionSyntax: CombatSubscribers=Supported(ModHelper.IterateAllCombatStateSubscribers(board),"combat")`
- `NationalSpire.Solver.LeagueForecast.CaptureProjection.Supported(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>, string)`；输入表达式：`Supported(ModHelper.IterateAllRunStateSubscribers(run),"run")`；返回值紧邻使用处：`AssignmentExpressionSyntax: RunSubscribers=Supported(ModHelper.IterateAllRunStateSubscribers(run),"run")`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`Unmodelled.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: Unmodelled.Clear();`

**赋值（含属性/字段和局部值）：**

- `_capture` = `this`
- `_previous` = `_capture`
- `Board` = `board`
- `CombatSubscribers` = `Supported(ModHelper.IterateAllCombatStateSubscribers(board),"combat")`
- `Run` = `run`
- `RunSubscribers` = `Supported(ModHelper.IterateAllRunStateSubscribers(run),"run")`
- `Unmodelled` = `unmodelled`

<a id="symbol-46d29f8b6749"></a>

## `NationalSpire.Solver.LeagueForecast.CaptureProjection.Supported(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>, string) — private static AbstractModel[] Supported(IEnumerable<AbstractModel> models,string scope)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.CaptureProjection.CaptureProjection(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Combat.CombatState, System.Collections.Generic.HashSet<System.Type>)`](LeagueForecast.Projection.cs.md#symbol-42e407d1105a)

**调用：** `CombatSolver.PredictionModHookSubscriberCapture.ValidateSubscriber(MegaCrit.Sts2.Core.Models.AbstractModel, string)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.PredictionModHookSubscriberCapture.ValidateSubscriber(MegaCrit.Sts2.Core.Models.AbstractModel, string)`；输入表达式：`PredictionModHookSubscriberCapture.ValidateSubscriber(m,scope)`；返回值紧邻使用处：`ExpressionStatementSyntax: PredictionModHookSubscriberCapture.ValidateSubscriber(m,scope);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`models.Where(m=>{                 try{PredictionModHookSubscriberCapture.ValidateSubscriber(m,scope);return true;}                 catch(NotSupportedException){return false;}             }).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>             models.Where(m=>{                 try{PredictionModHookSubscriberCapture.ValidateSubscriber(m,scope);return true;}                 catch(NotSupportedException){return false;}             }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`models.Where(m=>{                 try{PredictionModHookSubscriberCapture.ValidateSubscriber(m,scope);return true;}                 catch(NotSupportedException){return false;}             })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: models.Where(m=>{                 try{PredictionModHookSubscriberCapture.ValidateSubscriber(m,scope);return true;}                 catch(NotSupportedException){return false;}             }).ToArray`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a04dfd575c0e"></a>

## `NationalSpire.Solver.LeagueForecast.CaptureProjection.Dispose() — public void Dispose()`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._capture`；`NationalSpire.Solver.LeagueForecast.CaptureProjection._previous`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_capture` = `_previous`

<a id="symbol-71f51d5d4f7c"></a>

## `NationalSpire.Solver.LeagueForecast.InstallProjection(HarmonyLib.Harmony) — private static void InstallProjection(Harmony h)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Prepare()`](LeagueForecast.cs.md#symbol-f2559c94c021)

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(ModHelper),nameof(ModHelper.IterateAllCombatStateSubscribers))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(ModHelper),nameof(ModHelper.IterateAllCombatStateSubscribers))`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(ModHelper),nameof(ModHelper.IterateAllRunStateSubscribers))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(ModHelper),nameof(ModHelper.IterateAllRunStateSubscribers))`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(PredictionModPatchAudit),"AuditCardOnPlay")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(PredictionModPatchAudit),"AuditCardOnPlay")`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.Method(typeof(ModHelper),nameof(ModHelper.IterateAllCombatStateSubscribers)),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(CombatSubscribers)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.Method(typeof(ModHelper),nameof(ModHelper.IterateAllCombatStateSubscribers)),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(CombatSubscribers)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.Method(typeof(ModHelper),nameof(ModHelper.IterateAllRunStateSubscribers)),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(RunSubscribers)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.Method(typeof(ModHelper),nameof(ModHelper.IterateAllRunStateSubscribers)),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(RunSubscribers)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.Method(typeof(PredictionModPatchAudit),"AuditCardOnPlay"),finalizer:new HarmonyMethod(typeof(LeagueForecast),nameof(CardAudit)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.Method(typeof(PredictionModPatchAudit),"AuditCardOnPlay"),finalizer:new HarmonyMethod(typeof(LeagueForecast),nameof(CardAudit)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(CardAudit))`；返回值紧邻使用处：`ArgumentSyntax: finalizer:new HarmonyMethod(typeof(LeagueForecast),nameof(CardAudit))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(CombatSubscribers))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(CombatSubscribers))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueForecast),nameof(RunSubscribers))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(RunSubscribers))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9c4a3dab814f"></a>

## `NationalSpire.Solver.LeagueForecast.RunSubscribers(MegaCrit.Sts2.Core.Runs.RunState, ref System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>) — private static bool RunSubscribers(RunState __0,ref IEnumerable<AbstractModel> __result)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `object.ReferenceEquals(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._capture`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.Run`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.RunSubscribers`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(__0,p.Run)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(__0,p.Run)`

**赋值（含属性/字段和局部值）：**

- `__result` = `p.RunSubscribers`

<a id="symbol-13c03b06f4f6"></a>

## `NationalSpire.Solver.LeagueForecast.CombatSubscribers(MegaCrit.Sts2.Core.Combat.CombatState, ref System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>) — private static bool CombatSubscribers(CombatState __0,ref IEnumerable<AbstractModel> __result)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `object.ReferenceEquals(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._capture`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.Board`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.CombatSubscribers`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(__0,p.Board)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(__0,p.Board)`

**赋值（含属性/字段和局部值）：**

- `__result` = `p.CombatSubscribers`

<a id="symbol-4f53cb641075"></a>

## `NationalSpire.Solver.LeagueForecast.CardAudit(System.Type, ref CombatSolver.PredictionModPatchAudit.ForeignPatch?, CombatSolver.AdaptedCardOnPlayMirrors.Registration?, System.Exception?) — private static Exception? CardAudit(Type type,ref PredictionModPatchAudit.ForeignPatch? firstForeign,         AdaptedCardOnPlayMirrors.Registration? __result,Exception? __exception)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.HashSet<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._capture`；`NationalSpire.Solver.LeagueForecast.CaptureProjection.Unmodelled`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`p.Unmodelled.Add(type)`；返回值紧邻使用处：`ExpressionStatementSyntax: p.Unmodelled.Add(type);`

**赋值（含属性/字段和局部值）：**

- `firstForeign` = `null`
