# DateGameReturn.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`2B0C618098401FBBD9F8B06B88A3D377D8A8E99FEAF642A4BD929E9427C67DC1`。来源：[源码](../../DateGameReturn.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateGameReturn`、`NationalSpire.DateGameMenuReturnPatch`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private static int _returning;
private static WeakReference<CareerData>? _finishedData;
private static string _finishedId = "";
```

<a id="symbol-99e1aff837b0"></a>

## `NationalSpire.DateGameReturn.RecordBoundHistory(NationalSpire.CareerData, NationalSpire.CareerMatch) — internal static void RecordBoundHistory(CareerData d, CareerMatch match)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-4495455c88ce)

**调用：** `System.WeakReference<T>.WeakReference(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingSettlementId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.DateGameReturn._finishedData`；`NationalSpire.DateGameReturn._finishedId`；`NationalSpire.FailureDecision.Result`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.WeakReference<T>.WeakReference(T)`；输入表达式：`new(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _finishedData = new(d)`

**赋值（含属性/字段和局部值）：**

- `_finishedData` = `new(d)`
- `_finishedId` = `match.Id`

<a id="symbol-14d846fbc7ad"></a>

## `NationalSpire.DateGameReturn.RecordedId(NationalSpire.CareerData) — private static string RecordedId(CareerData d)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameReturn.ReturnId(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-dadaa559acbd)

**调用：** `System.WeakReference<T>.TryGetTarget(out T)`；`object.ReferenceEquals(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingSettlementId`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.DateGameReturn._finishedData`；`NationalSpire.DateGameReturn._finishedId`；`NationalSpire.FailureDecision.Result`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.WeakReference<T>.TryGetTarget(out T)`；输入表达式：`.TryGetTarget(out var origin)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _finishedData?.TryGetTarget(out var origin)`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(origin, d)`；返回值紧邻使用处：`BinaryExpressionSyntax: _finishedData?.TryGetTarget(out var origin) == true && ReferenceEquals(origin, d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dadaa559acbd"></a>

## `NationalSpire.DateGameReturn.ReturnId(NationalSpire.CareerData) — internal static string ReturnId(CareerData d)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)

**调用：** [`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-6e4e5b9e498d)；[`NationalSpire.DateGameReturn.RecordedId(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-14d846fbc7ad)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.Id`；`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；`NationalSpire.DateGameReturn.RecordedId(NationalSpire.CareerData)`；`NationalSpire.DateGameReturn.Transitioning`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；输入表达式：`Pending(d)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Pending(d)?.Id`
- `NationalSpire.DateGameReturn.RecordedId(NationalSpire.CareerData)`；输入表达式：`RecordedId(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RecordedId(d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b92a1a6d51b9"></a>

## `NationalSpire.DateGameReturn.Opened() — internal static void Opened()`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameReturn._finishedData`；`NationalSpire.DateGameReturn._finishedId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_finishedData` = `null`
- `_finishedId` = `""`

<a id="symbol-b2ead7e6860c"></a>

## `NationalSpire.DateGameReturn.Transitioning — internal static bool Transitioning`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameReturn._returning`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4a9b25f806ab"></a>

## `NationalSpire.DateGameReturn.BeginFinalReturn() — internal static void BeginFinalReturn()`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameMenuReturnPatch.Prefix()`](DateGameReturn.cs.md#symbol-454ae48db0d8)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameReturn._returning`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2976188cf0aa"></a>

## `NationalSpire.DateGameReturn.EndFinalReturn() — internal static void EndFinalReturn()`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameMenuReturnPatch.Finalizer(System.Exception?)`](DateGameReturn.cs.md#symbol-1406b5555e6a)；[`NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`](DateGameReturn.cs.md#symbol-ccc3c072c00e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameReturn._returning`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ccc3c072c00e"></a>

## `NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame) — internal static async Task AfterMainMenu(Task original, NGame game)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameMenuReturnPatch.Postfix(MegaCrit.Sts2.Core.Nodes.NGame, ref System.Threading.Tasks.Task)`](DateGameReturn.cs.md#symbol-e14df8a3edfa)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；[`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)；[`NationalSpire.DateGameReturn.EndFinalReturn()`](DateGameReturn.cs.md#symbol-2976188cf0aa)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`；`NationalSpire.Coop.CoopRuntime.Bound`；`NationalSpire.DateGameReturn.EndFinalReturn()`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(game)`；返回值紧邻使用处：`BinaryExpressionSyntax: !Coop.CoopRuntime.Bound && GodotObject.IsInstanceValid(game)`
- `Godot.Node.IsInsideTree()`；输入表达式：`game.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: !Coop.CoopRuntime.Bound && GodotObject.IsInstanceValid(game) && game.IsInsideTree()`
- `NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`；输入表达式：`CareerScreen.ReturnToDate(menu)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerScreen.ReturnToDate(menu);`
- `NationalSpire.DateGameReturn.EndFinalReturn()`；输入表达式：`EndFinalReturn()`；返回值紧邻使用处：`ExpressionStatementSyntax: EndFinalReturn();`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("match.return.menu", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("match.return.menu", e);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dcd87a3e58bb"></a>

## `NationalSpire.DateGameReturn.SavedMatch(NationalSpire.CareerData, string, string, MegaCrit.Sts2.Core.Saves.SerializableRun) — internal static CareerMatch? SavedMatch(CareerData data, string host, string offer, SerializableRun saved)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameReturn.PrepareSavedResume(NationalSpire.CareerData, string, string)`](DateGameReturn.cs.md#symbol-5f5af2e8993e)

**调用：** `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；[`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?)`](CareerRunBinding.cs.md#symbol-814ae5a03226)；[`NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-a63bde99754a)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.Id`；`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?)`；`NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .CharacterId?.ToString()`
- `NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?)`；输入表达式：`CareerRunBinding.Find(data, saved.SerializableRng?.Seed ?? "", saved.Players?.FirstOrDefault()?.CharacterId?.ToString() ?? "", saved.Ascension, saved.Players?.Count ?? 0, saved.GameMode == GameMode.Standard, saved.StartTime)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerRunBinding.Find(data, saved.SerializableRng?.Seed ?? "", saved.Players?.FirstOrDefault()?.CharacterId?.ToString() ?? "", saved.Ascension, saved.Players?.Count ?? 0, saved.GameMode == GameMode.Standard, saved.StartTime)?.Id`
- `NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`；输入表达式：`DateGames.InProgress(data, host, offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGames.InProgress(data, host, offer)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .FirstOrDefault()?.CharacterId?.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5f5af2e8993e"></a>

## `NationalSpire.DateGameReturn.PrepareSavedResume(NationalSpire.CareerData, string, string) — internal static Action PrepareSavedResume(CareerData data, string host, string offer)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ResumeDateGame()`](DateGameScreen.cs.md#symbol-fa0cab10e943)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；`HarmonyLib.AccessTools.Field(System.Type, string)`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；[`NationalSpire.DateGameReturn.SavedMatch(NationalSpire.CareerData, string, string, MegaCrit.Sts2.Core.Saves.SerializableRun)`](DateGameReturn.cs.md#symbol-dcd87a3e58bb)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](RuntimeApi.cs.md#symbol-65f56c93bd1a)；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.MissingMethodException.MissingMethodException(string?)`；`System.Reflection.FieldInfo.GetValue(object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.DateGameReturn.SavedMatch(NationalSpire.CareerData, string, string, MegaCrit.Sts2.Core.Saves.SerializableRun)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(menu)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(menu)`
- `Godot.Node.IsInsideTree()`；输入表达式：`menu.IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !menu.IsInsideTree()`
- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(NMainMenu), "_readRunSaveResult")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.Field(typeof(NMainMenu), "_readRunSaveResult")?.GetValue(menu)`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(NMainMenu), "OnContinueButtonPressed", [typeof(NButton)])`；返回值紧邻使用处：`BinaryExpressionSyntax: AccessTools.Method(typeof(NMainMenu), "OnContinueButtonPressed", [typeof(NButton)]) ?? throw new MissingMethodException("原版继续游戏入口不可用，请从主菜单继续游戏。")`
- `NationalSpire.DateGameReturn.SavedMatch(NationalSpire.CareerData, string, string, MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`SavedMatch(data, host, offer, result.SaveData)`；返回值紧邻使用处：`BinaryExpressionSyntax: SavedMatch(data, host, offer, result.SaveData) == null`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("date.game.resume.saved", new { match = data.PendingMatchId, result.SaveData.StartTime, result.SaveData.CurrentActIndex })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("date.game.resume.saved", new { match = data.PendingMatchId, result.SaveData.StartTime, result.SaveData.CurrentActIndex });`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(resume, menu, (object?)null)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => RuntimeApi.Invoke(resume, menu, (object?)null)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("主菜单恢复入口尚未就绪，请返回主菜单继续游戏。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("主菜单恢复入口尚未就绪，请返回主菜单继续游戏。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("原版存档与本次约会对局不匹配，请返回对应生涯继续游戏。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("原版存档与本次约会对局不匹配，请返回对应生涯继续游戏。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("原版对局存档读取失败，请返回主菜单检查继续游戏入口。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("原版对局存档读取失败，请返回主菜单检查继续游戏入口。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("当前原版对局仍在运行，请先关闭生涯界面返回对局。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("当前原版对局仍在运行，请先关闭生涯界面返回对局。");`
- `System.MissingMethodException.MissingMethodException(string?)`；输入表达式：`new MissingMethodException("原版继续游戏入口不可用，请从主菜单继续游戏。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new MissingMethodException("原版继续游戏入口不可用，请从主菜单继续游戏。")`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`.GetValue(menu)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.Field(typeof(NMainMenu), "_readRunSaveResult")?.GetValue(menu)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6e4e5b9e498d"></a>

## `NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData) — public static CareerMatch? Pending(CareerData data)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameReturn.ReturnId(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-dadaa559acbd)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Status`；`NationalSpire.DateGameState.ReturnPending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.LastOrDefault(m => m.DateGame?.ReturnPending == true && m.Status == "已结算")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => data.Matches.LastOrDefault(m => m.DateGame?.ReturnPending == true && m.Status == "已结算")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-454ae48db0d8"></a>

## `NationalSpire.DateGameMenuReturnPatch.Prefix() — public static void Prefix()`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateGameReturn.BeginFinalReturn()`](DateGameReturn.cs.md#symbol-4a9b25f806ab)

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameReturn.BeginFinalReturn()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameReturn.BeginFinalReturn()`；输入表达式：`DateGameReturn.BeginFinalReturn()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DateGameReturn.BeginFinalReturn()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e14df8a3edfa"></a>

## `NationalSpire.DateGameMenuReturnPatch.Postfix(MegaCrit.Sts2.Core.Nodes.NGame, ref System.Threading.Tasks.Task) — public static void Postfix(NGame __instance, ref Task __result)`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`](DateGameReturn.cs.md#symbol-ccc3c072c00e)

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`；输入表达式：`DateGameReturn.AfterMainMenu(__result, __instance)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result = DateGameReturn.AfterMainMenu(__result, __instance)`

**赋值（含属性/字段和局部值）：**

- `__result` = `DateGameReturn.AfterMainMenu(__result, __instance)`

<a id="symbol-1406b5555e6a"></a>

## `NationalSpire.DateGameMenuReturnPatch.Finalizer(System.Exception?) — public static void Finalizer(Exception? __exception)`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateGameReturn.EndFinalReturn()`](DateGameReturn.cs.md#symbol-2976188cf0aa)

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameReturn.EndFinalReturn()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameReturn.EndFinalReturn()`；输入表达式：`DateGameReturn.EndFinalReturn()`；返回值紧邻使用处：`ExpressionStatementSyntax: DateGameReturn.EndFinalReturn();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f14ac682e7c3"></a>

## `NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu) — internal static void ReturnToDate(NMainMenu menu)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`](DateGameReturn.cs.md#symbol-ccc3c072c00e)；[`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；[`NationalSpire.CareerScreen.OpenCareerView(Godot.Control, NationalSpire.ICareerSession?, string?, string)`](CareerScreen.cs.md#symbol-3d547eb16e05)；[`NationalSpire.DateGameReturn.Opened()`](DateGameReturn.cs.md#symbol-b92a1a6d51b9)；[`NationalSpire.DateGameReturn.ReturnId(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-dadaa559acbd)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Current`；`NationalSpire.CareerScreen.OpenCareerView(Godot.Control, NationalSpire.ICareerSession?, string?, string)`；`NationalSpire.CareerStore.Data`；`NationalSpire.DateGameReturn.Opened()`；`NationalSpire.DateGameReturn.ReturnId(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(menu)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(menu)`
- `Godot.Node.IsInsideTree()`；输入表达式：`menu.IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !menu.IsInsideTree()`
- `NationalSpire.CareerScreen.OpenCareerView(Godot.Control, NationalSpire.ICareerSession?, string?, string)`；输入表达式：`OpenCareerView(menu, null, "结算", id)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenCareerView(menu, null, "结算", id);`
- `NationalSpire.DateGameReturn.Opened()`；输入表达式：`DateGameReturn.Opened()`；返回值紧邻使用处：`ExpressionStatementSyntax: DateGameReturn.Opened();`
- `NationalSpire.DateGameReturn.ReturnId(NationalSpire.CareerData)`；输入表达式：`DateGameReturn.ReturnId(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DateGameReturn.ReturnId(data)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9e75de0044f4"></a>

## `NationalSpire.CareerScreen.ResumeSettledDate(NationalSpire.CareerData, NationalSpire.CareerMatch) — private bool ResumeSettledDate(CareerData data, CareerMatch match)`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult)`](MatchArenaScreen.cs.md#symbol-e4b38ce6c04b)

**调用：** `Godot.CanvasItem.IsVisibleInTree()`；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`](DateGameScreen.cs.md#symbol-8963173330c9)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.DateGameState.Host`；`NationalSpire.DateGameState.OfferId`；`NationalSpire.DateGameState.ReturnPending`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`.IsVisibleInTree()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateView?.IsVisibleInTree()`
- `NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；输入表达式：`OpenDateSceneReady(game.OfferId, false, true, () => { StartDateGameReply(match, "result"); Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = _dateView?.IsVisibleInTree() == true }); })`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateSceneReady(game.OfferId, false, true, () => { StartDateGameReply(match, "result"); Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = _dateView?.IsVisibleInTree() == true }); });`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(game.Host)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(game.Host);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`；输入表达式：`StartDateGameReply(match, "result")`；返回值紧邻使用处：`ExpressionStatementSyntax: StartDateGameReply(match, "result");`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, o, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id == game.OfferId && DateScenes.Available(data, o, c)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = _dateView?.IsVisibleInTree() == true })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = _dateView?.IsVisibleInTree() == true });`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, game.Host)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, game.Host)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Any(o => o.Id == game.OfferId && DateScenes.Available(data, o, c))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Offers.Any(o => o.Id == game.OfferId && DateScenes.Available(data, o, c))`

**赋值（含属性/字段和局部值）：**

- `_reviewId` = `""`
- `_tab` = `"赛事"`
- `game.ReturnPending` = `false`
