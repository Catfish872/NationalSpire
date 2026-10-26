# DateGameReturn.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`64B6B7FB65299CC0809E3487E89C4EFC6102A681924E5CF0C73AD5CDA372F67C`。来源：[源码](../../DateGameReturn.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateGameReturn`、`NationalSpire.DateGameMenuReturnPatch`、`NationalSpire.DateGameIntroPatch`、`NationalSpire.DateGameSummaryPatch`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private static int _returning;
```

<a id="symbol-b2ead7e6860c"></a>

## `NationalSpire.DateGameReturn.Transitioning — internal static bool Transitioning`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameReturn._returning`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ccc3c072c00e"></a>

## `NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame) — internal static async Task AfterMainMenu(Task original, NGame game)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameMenuReturnPatch.Postfix(MegaCrit.Sts2.Core.Nodes.NGame, ref System.Threading.Tasks.Task)`](DateGameReturn.cs.md#symbol-e14df8a3edfa)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.GetTree()`；`Godot.Node.IsInsideTree()`；[`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-6e4e5b9e498d)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`；`NationalSpire.CareerStore.Data`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；`NationalSpire.DateGameReturn._returning`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(game)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(game)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(game)`；返回值紧邻使用处：`BinaryExpressionSyntax: _returning == 1 && GodotObject.IsInstanceValid(game)`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`game.ToSignal(game.GetTree(), SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.ToSignal(game.GetTree(), SceneTree.SignalName.ProcessFrame)`
- `Godot.Node.GetTree()`；输入表达式：`game.GetTree()`；返回值紧邻使用处：`ArgumentSyntax: game.GetTree()`
- `Godot.Node.IsInsideTree()`；输入表达式：`game.IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !game.IsInsideTree()`
- `NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`；输入表达式：`CareerScreen.ReturnToDate(menu)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerScreen.ReturnToDate(menu);`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: _returning == 1 && GodotObject.IsInstanceValid(game) && CareerStore.IsCurrent(data)`
- `NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；输入表达式：`Pending(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: Pending(data) == null`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("date.game.restore", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("date.game.restore", e);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dcd87a3e58bb"></a>

## `NationalSpire.DateGameReturn.SavedMatch(NationalSpire.CareerData, string, string, MegaCrit.Sts2.Core.Saves.SerializableRun) — internal static CareerMatch? SavedMatch(CareerData data, string host, string offer, SerializableRun saved)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)；[`NationalSpire.DateGameIntroPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen, ref System.Threading.Tasks.Task)`](DateGameReturn.cs.md#symbol-a5f4bae6241d)；[`NationalSpire.DateGameMenuReturnPatch.Postfix(MegaCrit.Sts2.Core.Nodes.NGame, ref System.Threading.Tasks.Task)`](DateGameReturn.cs.md#symbol-e14df8a3edfa)；[`NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`](DateGameReturn.cs.md#symbol-ccc3c072c00e)；[`NationalSpire.DateGameReturn.CurrentRun()`](DateGameReturn.cs.md#symbol-1a4868d5f6b6)；[`NationalSpire.DateGameSummaryPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen, ref System.Threading.Tasks.Task)`](DateGameReturn.cs.md#symbol-1dd3ede7895c)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Status`；`NationalSpire.DateGameState.ReturnPending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.LastOrDefault(m => m.DateGame?.ReturnPending == true && m.Status == "已结算")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => data.Matches.LastOrDefault(m => m.DateGame?.ReturnPending == true && m.Status == "已结算")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1a4868d5f6b6"></a>

## `NationalSpire.DateGameReturn.CurrentRun() — private static bool CurrentRun()`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameReturn.AfterIntro(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen)`](DateGameReturn.cs.md#symbol-74da1cfff354)；[`NationalSpire.DateGameReturn.AfterSummary(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen)`](DateGameReturn.cs.md#symbol-3383d1deaa73)

**调用：** [`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-6e4e5b9e498d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.Id`；`NationalSpire.CareerStore.Data`；`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；`NationalSpire.LiveRunBridge.Current`；`NationalSpire.LiveRunBridge.DateGameMatchId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；输入表达式：`Pending(CareerStore.Data)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Pending(CareerStore.Data) is { } match`

**赋值（含属性/字段和局部值）：**


<a id="symbol-74da1cfff354"></a>

## `NationalSpire.DateGameReturn.AfterIntro(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen) — internal static async Task AfterIntro(Task original, NGameOverScreen screen)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameIntroPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen, ref System.Threading.Tasks.Task)`](DateGameReturn.cs.md#symbol-a5f4bae6241d)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；`HarmonyLib.AccessTools.Field(System.Type, string)`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；[`NationalSpire.DateGameReturn.CurrentRun()`](DateGameReturn.cs.md#symbol-1a4868d5f6b6)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`System.Reflection.FieldInfo.GetValue(object?)`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameReturn.CurrentRun()`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(screen)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(screen)`
- `Godot.Node.IsInsideTree()`；输入表达式：`screen.IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !screen.IsInsideTree()`
- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(NGameOverScreen), "_isAnimatingSummary")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.Field(typeof(NGameOverScreen), "_isAnimatingSummary")?.GetValue(screen)`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(NGameOverScreen), "OpenSummaryScreen")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: AccessTools.Method(typeof(NGameOverScreen), "OpenSummaryScreen")!`
- `NationalSpire.DateGameReturn.CurrentRun()`；输入表达式：`CurrentRun()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CurrentRun()`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("date.game.summary", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("date.game.summary", e);`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`.GetValue(screen)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.Field(typeof(NGameOverScreen), "_isAnimatingSummary")?.GetValue(screen)`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`AccessTools.Method(typeof(NGameOverScreen), "OpenSummaryScreen")!.Invoke(screen, [null])`；返回值紧邻使用处：`ExpressionStatementSyntax: AccessTools.Method(typeof(NGameOverScreen), "OpenSummaryScreen")!.Invoke(screen, [null]);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3383d1deaa73"></a>

## `NationalSpire.DateGameReturn.AfterSummary(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen) — internal static async Task AfterSummary(Task original, NGameOverScreen screen)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameSummaryPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen, ref System.Threading.Tasks.Task)`](DateGameReturn.cs.md#symbol-1dd3ede7895c)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；`MegaCrit.Sts2.Core.Nodes.NGame.ReturnToMainMenuAfterRun()`；[`NationalSpire.DateGameReturn.CurrentRun()`](DateGameReturn.cs.md#symbol-1a4868d5f6b6)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameReturn.CurrentRun()`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(screen)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(screen)`
- `Godot.Node.IsInsideTree()`；输入表达式：`screen.IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !screen.IsInsideTree()`
- `MegaCrit.Sts2.Core.Nodes.NGame.ReturnToMainMenuAfterRun()`；输入表达式：`game.ReturnToMainMenuAfterRun()`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.ReturnToMainMenuAfterRun()`
- `NationalSpire.DateGameReturn.CurrentRun()`；输入表达式：`CurrentRun()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CurrentRun()`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("date.game.return", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("date.game.return", e);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e14df8a3edfa"></a>

## `NationalSpire.DateGameMenuReturnPatch.Postfix(MegaCrit.Sts2.Core.Nodes.NGame, ref System.Threading.Tasks.Task) — public static void Postfix(NGame __instance, ref Task __result)`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`](DateGameReturn.cs.md#symbol-ccc3c072c00e)；[`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-6e4e5b9e498d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStore.Data`；`NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`；`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`；输入表达式：`DateGameReturn.AfterMainMenu(__result, __instance)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result = DateGameReturn.AfterMainMenu(__result, __instance)`
- `NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；输入表达式：`DateGameReturn.Pending(CareerStore.Data)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateGameReturn.Pending(CareerStore.Data) != null`

**赋值（含属性/字段和局部值）：**

- `__result` = `DateGameReturn.AfterMainMenu(__result, __instance)`

<a id="symbol-048458fd551b"></a>

## `NationalSpire.DateGameIntroPatch.Prepare() — public static bool Prepare()`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameSummaryPatch.Prepare()`](DateGameReturn.cs.md#symbol-282ddcbbbd11)

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(NGameOverScreen), "AnimateIn")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.Method(typeof(NGameOverScreen), "AnimateIn")?.ReturnType`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(NGameOverScreen), "AnimateRunSummary")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.Method(typeof(NGameOverScreen), "AnimateRunSummary")?.ReturnType`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(NGameOverScreen), "OpenSummaryScreen")`；返回值紧邻使用处：`BinaryExpressionSyntax: AccessTools.Method(typeof(NGameOverScreen), "OpenSummaryScreen") != null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a5f4bae6241d"></a>

## `NationalSpire.DateGameIntroPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen, ref System.Threading.Tasks.Task) — public static void Postfix(NGameOverScreen __instance, ref Task __result)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateGameReturn.AfterIntro(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen)`](DateGameReturn.cs.md#symbol-74da1cfff354)；[`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-6e4e5b9e498d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStore.Data`；`NationalSpire.DateGameReturn.AfterIntro(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen)`；`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameReturn.AfterIntro(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen)`；输入表达式：`DateGameReturn.AfterIntro(__result, __instance)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result = DateGameReturn.AfterIntro(__result, __instance)`
- `NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；输入表达式：`DateGameReturn.Pending(CareerStore.Data)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateGameReturn.Pending(CareerStore.Data) != null`

**赋值（含属性/字段和局部值）：**

- `__result` = `DateGameReturn.AfterIntro(__result, __instance)`

<a id="symbol-282ddcbbbd11"></a>

## `NationalSpire.DateGameSummaryPatch.Prepare() — public static bool Prepare()`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateGameIntroPatch.Prepare()`](DateGameReturn.cs.md#symbol-048458fd551b)

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameIntroPatch.Prepare()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameIntroPatch.Prepare()`；输入表达式：`DateGameIntroPatch.Prepare()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DateGameIntroPatch.Prepare()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1dd3ede7895c"></a>

## `NationalSpire.DateGameSummaryPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen, ref System.Threading.Tasks.Task) — public static void Postfix(NGameOverScreen __instance, ref Task __result)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateGameReturn.AfterSummary(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen)`](DateGameReturn.cs.md#symbol-3383d1deaa73)；[`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-6e4e5b9e498d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStore.Data`；`NationalSpire.DateGameReturn.AfterSummary(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen)`；`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameReturn.AfterSummary(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen)`；输入表达式：`DateGameReturn.AfterSummary(__result, __instance)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result = DateGameReturn.AfterSummary(__result, __instance)`
- `NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；输入表达式：`DateGameReturn.Pending(CareerStore.Data)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateGameReturn.Pending(CareerStore.Data) != null`

**赋值（含属性/字段和局部值）：**

- `__result` = `DateGameReturn.AfterSummary(__result, __instance)`

<a id="symbol-f14ac682e7c3"></a>

## `NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu) — internal static void ReturnToDate(NMainMenu menu)`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`](DateGameReturn.cs.md#symbol-ccc3c072c00e)；[`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)

**调用：** `Godot.CanvasItem.IsVisibleInTree()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](CareerScreen.cs.md#symbol-2b6ef58a9693)；[`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`](DateGameScreen.cs.md#symbol-8963173330c9)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`](DateGameReturn.cs.md#symbol-6e4e5b9e498d)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerScreen.Current`；`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerStore.Data`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；`NationalSpire.DateGameState.Host`；`NationalSpire.DateGameState.OfferId`；`NationalSpire.DateGameState.ReturnPending`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`.IsVisibleInTree()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: screen._dateView?.IsVisibleInTree()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(menu)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(menu)`
- `Godot.Node.IsInsideTree()`；输入表达式：`menu.IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !menu.IsInsideTree()`
- `NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；输入表达式：`screen.OpenDateSceneReady(game.OfferId, false, true, () => { screen.StartDateGameReply(match, "result"); Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = screen._dateView?.IsVisibleInTree() == true }); })`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.OpenDateSceneReady(game.OfferId, false, true, () => { screen.StartDateGameReply(match, "result"); Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = screen._dateView?.IsVisibleInTree() == true }); });`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`screen.OpenPrivateMessages(game.Host)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.OpenPrivateMessages(game.Host);`
- `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；输入表达式：`OpenView(menu, null, "通讯")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenView(menu, null, "通讯");`
- `NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`；输入表达式：`screen.StartDateGameReply(match, "result")`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.StartDateGameReply(match, "result");`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.DateGameReturn.Pending(NationalSpire.CareerData)`；输入表达式：`DateGameReturn.Pending(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGameReturn.Pending(data)`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, o, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id == game.OfferId && DateScenes.Available(data, o, c)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = screen._dateView?.IsVisibleInTree() == true })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = screen._dateView?.IsVisibleInTree() == true });`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, game.Host)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, game.Host)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Any(o => o.Id == game.OfferId && DateScenes.Available(data, o, c))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Offers.Any(o => o.Id == game.OfferId && DateScenes.Available(data, o, c))`

**赋值（含属性/字段和局部值）：**

- `game.ReturnPending` = `false`
