# Coop/CoopRuntime.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`F486C6DC2E4AA41E036F5F3C2FED6AC3B55CDDB1CF4C192135E53FA7EA23BB71`。来源：[源码](../../../Coop/CoopRuntime.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopSettings`、`NationalSpire.Coop.ICoopPauseScene`、`NationalSpire.Coop.CoopGamePauseScene`、`NationalSpire.Coop.CoopRuntime`、`NationalSpire.Coop.CoopMenuPatch`、`NationalSpire.Coop.CoopContextPatch`、`NationalSpire.Coop.CoopPathPatch`、`NationalSpire.Coop.CoopSaveEntryPatch`、`NationalSpire.Coop.CoopSavePatch`、`NationalSpire.Coop.CoopHistoryPatch`、`NationalSpire.Coop.CoopReturnPatch`、`NationalSpire.Coop.CoopDisconnectMenuPatch`。

字段、事件及初始值（源码原样）：

```csharp
private CoopSteam? _connecting;
private bool _busy, _pausing;
private Task? _pauseTask;
private string _completedPause = "";
private string _nativeAttempt = "";
private int _connectionGeneration;
private double _liveTick;
private CoopLive? _live;
private bool _resumeRequired;
private int _pausedCount;
```

<a id="symbol-4bf7c114c5ca"></a>

## `NationalSpire.Coop.CoopSettings.Root — public static string Root`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_coop")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProjectSettings.GlobalizePath("user://national_spire_coop")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8a88cc1ce770"></a>

## `NationalSpire.Coop.CoopSettings.Storage — public static CoopStorage Storage`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.Coop.CoopStorage.CoopStorage(string)`；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopSettings.Root`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.CoopStorage(string)`；输入表达式：`new(Path.Combine(Root, "worlds"))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(Path.Combine(Root, "worlds"))`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(Root, "worlds")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(Root, "worlds")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7bdef2452208"></a>

## `NationalSpire.Coop.CoopSettings.ReadLayout() — public static BroadcastUiState ReadLayout()`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；`NationalSpire.BroadcastUiState.BroadcastUiState()`；`System.IO.File.ReadAllBytes(string)`；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.Coop.CoopSettings.Root`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BroadcastUiState.BroadcastUiState()`；输入表达式：`new()`；返回值紧邻使用处：`ReturnStatementSyntax: return new();`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<BroadcastUiState>(File.ReadAllBytes(Path.Combine(Root, "hud.json")))`；返回值紧邻使用处：`ReturnStatementSyntax: return CoopJson.Read<BroadcastUiState>(File.ReadAllBytes(Path.Combine(Root, "hud.json")));`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(Path.Combine(Root, "hud.json"))`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllBytes(Path.Combine(Root, "hud.json"))`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(Root, "hud.json")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(Root, "hud.json")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3613d13461fc"></a>

## `NationalSpire.Coop.CoopSettings.SaveLayout(NationalSpire.BroadcastUiState) — public static void SaveLayout(BroadcastUiState layout)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](CoopLive.cs.md#symbol-fe745d15ee63)

**调用：** [`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllBytes(string, byte[])`；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopSettings.Root`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(layout)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(layout)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.hud.layout", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.hud.layout", e);`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(Root)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(Root);`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(path + ".tmp", path, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(path + ".tmp", path, true);`
- `System.IO.File.WriteAllBytes(string, byte[])`；输入表达式：`File.WriteAllBytes(path + ".tmp", CoopJson.Bytes(layout))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllBytes(path + ".tmp", CoopJson.Bytes(layout));`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(Root, "hud.json")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(Root, "hud.json")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f340f58b5d41"></a>

## `NationalSpire.Coop.ICoopPauseScene.NeedsReturn —  bool NeedsReturn`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-66f31117cc59"></a>

## `NationalSpire.Coop.ICoopPauseScene.ReturnToMenu() — Task ReturnToMenu();`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](CoopRuntime.cs.md#symbol-60fe2cb26a8e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7904dd0288b5"></a>

## `NationalSpire.Coop.ICoopPauseScene.Reveal() — Task Reveal();`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](CoopRuntime.cs.md#symbol-60fe2cb26a8e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-23bb3e7b66ff"></a>

## `NationalSpire.Coop.CoopGamePauseScene.NeedsReturn — public bool NeedsReturn`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2a0603698313"></a>

## `NationalSpire.Coop.CoopGamePauseScene.ReturnToMenu() — public Task ReturnToMenu()`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Nodes.NGame.ReturnToMainMenu()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Nodes.NGame.ReturnToMainMenu()`；输入表达式：`NGame.Instance!.ReturnToMainMenu()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => NGame.Instance!.ReturnToMainMenu()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-24611476df11"></a>

## `NationalSpire.Coop.CoopGamePauseScene.Reveal() — public async Task Reveal()`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；输入表达式：`game.Transition.FadeIn(.2f)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.Transition.FadeIn(.2f)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b4769c4e2a82"></a>

## `NationalSpire.Coop.CoopRuntime.Current — public static CoopRuntime? Current`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-97958e8d9c7a"></a>

## `NationalSpire.Coop.CoopRuntime.Session — public CoopCoordinator? Session`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ad8671a0a910"></a>

## `NationalSpire.Coop.CoopRuntime.Native — public CoopNativeRun? Native`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-83ce140d9f57"></a>

## `NationalSpire.Coop.CoopRuntime.Ai — public CoopAi? Ai`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-57c09e168b10"></a>

## `NationalSpire.Coop.CoopRuntime.Status — public string Status`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f4b36d28b2b6"></a>

## `NationalSpire.Coop.CoopRuntime.InviteCode — public string InviteCode`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d687ecf6c789"></a>

## `NationalSpire.Coop.CoopRuntime.PauseScene — public ICoopPauseScene PauseScene`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.Coop.CoopGamePauseScene.CoopGamePauseScene()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopGamePauseScene.CoopGamePauseScene()`；输入表达式：`new CoopGamePauseScene()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CoopGamePauseScene()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bf4e09b82f0e"></a>

## `NationalSpire.Coop.CoopRuntime.Pausing — public bool Pausing`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime._pausing`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9cf957dc5a04"></a>

## `NationalSpire.Coop.CoopRuntime.MenuReturn — public Task? MenuReturn`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-08729fcdd228"></a>

## `NationalSpire.Coop.CoopRuntime.ReturningToMenu — public bool ReturningToMenu`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime.MenuReturn`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-156e8d28f378"></a>

## `NationalSpire.Coop.CoopRuntime.Bound — public static bool Bound`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e0212127f782"></a>

## `NationalSpire.Coop.CoopRuntime.Ensure() — public static CoopRuntime Ensure()`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.Runtime`](CoopScreen.cs.md#symbol-9bd66df90b49)

**调用：** `Godot.Engine.GetMainLoop()`；`Godot.GodotObject.CallDeferred(Godot.StringName, params Godot.Variant[])`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`NationalSpire.Coop.CoopRuntime.CoopRuntime()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Engine.GetMainLoop()`；输入表达式：`Engine.GetMainLoop()`；返回值紧邻使用处：`CastExpressionSyntax: (SceneTree)Engine.GetMainLoop()`
- `Godot.GodotObject.CallDeferred(Godot.StringName, params Godot.Variant[])`；输入表达式：`((SceneTree)Engine.GetMainLoop()).Root.CallDeferred(Node.MethodName.AddChild, runtime)`；返回值紧邻使用处：`ExpressionStatementSyntax: ((SceneTree)Engine.GetMainLoop()).Root.CallDeferred(Node.MethodName.AddChild, runtime);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(Current)`；返回值紧邻使用处：`BinaryExpressionSyntax: Current != null && IsInstanceValid(Current)`
- `NationalSpire.Coop.CoopRuntime.CoopRuntime()`；输入表达式：`new CoopRuntime { Name = "NationalSpireCooperative" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CoopRuntime { Name = "NationalSpireCooperative" }`

**赋值（含属性/字段和局部值）：**

- `Current` = `runtime`
- `Name` = `"NationalSpireCooperative"`

<a id="symbol-252dd3ac9940"></a>

## `NationalSpire.Coop.CoopRuntime.Compatibility — public static string Compatibility`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopContentIdentity.Create(string, uint, System.Collections.Generic.IEnumerable<string>?)`](CoopContentIdentity.cs.md#symbol-e677ecf56ae1)；`MegaCrit.Sts2.Core.Modding.ModManager.GetNonGameplayRelevantModNameList()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopContentIdentity.Create(string, uint, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.Diagnostics.ModVersion`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Modding.ModManager.GetNonGameplayRelevantModNameList()`；输入表达式：`MegaCrit.Sts2.Core.Modding.ModManager.GetNonGameplayRelevantModNameList()`；返回值紧邻使用处：`ArgumentSyntax: MegaCrit.Sts2.Core.Modding.ModManager.GetNonGameplayRelevantModNameList()`
- `NationalSpire.Coop.CoopContentIdentity.Create(string, uint, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`CoopContentIdentity.Create(Diagnostics.ModVersion, ModelIdSerializationCache.Hash,          MegaCrit.Sts2.Core.Modding.ModManager.GetNonGameplayRelevantModNameList())`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => CoopContentIdentity.Create(Diagnostics.ModVersion, ModelIdSerializationCache.Hash,          MegaCrit.Sts2.Core.Modding.ModManager.GetNonGameplayRelevantModNameList())`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5c58a004498a"></a>

## `NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string) — public async Task Connect(bool host, string name, string worldName = "共同生涯", int capacity = 2, string country = "中国", string code = "", string savedId = "")`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string)`](CoopScreen.cs.md#symbol-af359fd6d523)

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.Coop.CoopAi.Process(bool)`](CoopAi.cs.md#symbol-3046e7db594f)；[`NationalSpire.Coop.CoopCompatibility.Check(bool)`](CoopCompatibility.cs.md#symbol-c71e5d5de570)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](CoopCoordinator.cs.md#symbol-778097f34ec3)；[`NationalSpire.Coop.CoopRules.Create(ulong, string, string, int, string)`](CoopRules.cs.md#symbol-768ae6d9f0c2)；[`NationalSpire.Coop.CoopSteam.CoopSteam()`](CoopSteam.cs.md#symbol-b1f078737dd8)；[`NationalSpire.Coop.CoopSteam.Dispose()`](CoopSteam.cs.md#symbol-e6ebd27b8764)；[`NationalSpire.Coop.CoopSteam.Host(int)`](CoopSteam.cs.md#symbol-2ebe266758ac)；[`NationalSpire.Coop.CoopSteam.Join(string)`](CoopSteam.cs.md#symbol-d63147221932)；[`NationalSpire.Coop.CoopStorage.LoadAsync(string)`](CoopStorage.cs.md#symbol-98401b01dd9e)；[`NationalSpire.Diagnostics.CapturePeerLogs(string, string, string?)`](../Diagnostics.cs.md#symbol-8481032d98dd)；[`NationalSpire.GameBridge.Characters()`](../GameBridge.cs.md#symbol-1233494dda40)；`Godot.ProjectSettings.GlobalizePath(string)`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.AiOptions.AiOptions()`；`NationalSpire.Coop.CoopAi.CoopAi(NationalSpire.Coop.CoopCoordinator)`；`NationalSpire.Coop.CoopLive.CoopLive(NationalSpire.Coop.CoopCoordinator)`；`NationalSpire.Coop.CoopNativeRun.CoopNativeRun(NationalSpire.Coop.CoopCoordinator, NationalSpire.Coop.ICoopNativePlatform?)`；`NationalSpire.Coop.CoopStorage.Checkpoint.Checkpoint(NationalSpire.Coop.CoopWorld, byte[]?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.OperationCanceledException.OperationCanceledException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.WorldId`；`NationalSpire.Coop.CoopAi.Process(bool)`；`NationalSpire.Coop.CoopCompatibility.Check(bool)`；`NationalSpire.Coop.CoopCoordinator.CaptureDiagnostics`；`NationalSpire.Coop.CoopCoordinator.RunMessage`；`NationalSpire.Coop.CoopCoordinator.TriggerAi`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopNativeRun.Message(NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopNativeRun.Status`；`NationalSpire.Coop.CoopRules.Create(ulong, string, string, int, string)`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopRun.Terminal`；`NationalSpire.Coop.CoopRuntime._busy`；`NationalSpire.Coop.CoopRuntime._connecting`；`NationalSpire.Coop.CoopRuntime._connectionGeneration`；`NationalSpire.Coop.CoopRuntime._live`；`NationalSpire.Coop.CoopRuntime._nativeAttempt`；`NationalSpire.Coop.CoopRuntime._pausedCount`；`NationalSpire.Coop.CoopRuntime._pausing`；`NationalSpire.Coop.CoopRuntime._resumeRequired`；`NationalSpire.Coop.CoopRuntime.Ai`；`NationalSpire.Coop.CoopRuntime.Compatibility`；`NationalSpire.Coop.CoopRuntime.InviteCode`；`NationalSpire.Coop.CoopRuntime.Native`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopRuntime.Status`；`NationalSpire.Coop.CoopSettings.Storage`；`NationalSpire.Coop.CoopSteam.Code`；`NationalSpire.Coop.CoopSteam.Dispose()`；`NationalSpire.Coop.CoopSteam.Host(int)`；`NationalSpire.Coop.CoopSteam.Join(string)`；`NationalSpire.Coop.CoopSteam.Self`；`NationalSpire.Coop.CoopSteam.Token`；`NationalSpire.Coop.CoopStorage.Checkpoint.World`；`NationalSpire.Coop.CoopStorage.LoadAsync(string)`；`NationalSpire.Coop.CoopWorld.CareerStarted`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Coop.CoopWorld.RosterLocked`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Diagnostics.CapturePeerLogs(string, string, string?)`；`NationalSpire.GameBridge.Characters()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://logs")`；返回值紧邻使用处：`ArgumentSyntax: ProjectSettings.GlobalizePath("user://logs")`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Id.ToString()`
- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiSettingsStore.Load(new()).Enabled`
- `NationalSpire.Coop.CoopAi.CoopAi(NationalSpire.Coop.CoopCoordinator)`；输入表达式：`new(Session)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Ai = new(Session)`
- `NationalSpire.Coop.CoopAi.Process(bool)`；输入表达式：`Ai.Process()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Ai.Process()`
- `NationalSpire.Coop.CoopCompatibility.Check(bool)`；输入表达式：`CoopCompatibility.Check()`；返回值紧邻使用处：`IsPatternExpressionSyntax: CoopCompatibility.Check() is { } compatibilityError`
- `NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`；输入表达式：`new(_connecting, CoopSettings.Storage, Compatibility, _connecting.Token, name, GameBridge.Characters().Select(c => c.Id.ToString()).ToHashSet(), checkpoint)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Session = new(_connecting, CoopSettings.Storage, Compatibility, _connecting.Token, name, GameBridge.Characters().Select(c => c.Id.ToString()).ToHashSet(), checkpoint)`
- `NationalSpire.Coop.CoopLive.CoopLive(NationalSpire.Coop.CoopCoordinator)`；输入表达式：`new(Session)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _live = new(Session)`
- `NationalSpire.Coop.CoopNativeRun.CoopNativeRun(NationalSpire.Coop.CoopCoordinator, NationalSpire.Coop.ICoopNativePlatform?)`；输入表达式：`new(Session)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Native = new(Session)`
- `NationalSpire.Coop.CoopRules.Create(ulong, string, string, int, string)`；输入表达式：`CoopRules.Create(_connecting.Self, worldName, name, capacity, country)`；返回值紧邻使用处：`ArgumentSyntax: CoopRules.Create(_connecting.Self, worldName, name, capacity, country)`
- `NationalSpire.Coop.CoopSteam.CoopSteam()`；输入表达式：`new CoopSteam()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _connecting = new CoopSteam()`
- `NationalSpire.Coop.CoopSteam.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _connecting?.Dispose()`
- `NationalSpire.Coop.CoopSteam.Host(int)`；输入表达式：`_connecting.Host(4)`；返回值紧邻使用处：`AwaitExpressionSyntax: await _connecting.Host(4)`
- `NationalSpire.Coop.CoopSteam.Join(string)`；输入表达式：`_connecting.Join(code)`；返回值紧邻使用处：`AwaitExpressionSyntax: await _connecting.Join(code)`
- `NationalSpire.Coop.CoopStorage.Checkpoint.Checkpoint(NationalSpire.Coop.CoopWorld, byte[]?)`；输入表达式：`new(CoopRules.Create(_connecting.Self, worldName, name, capacity, country), null)`；返回值紧邻使用处：`ConditionalExpressionSyntax: savedId.Length > 0 ? await CoopSettings.Storage.LoadAsync(savedId) : new(CoopRules.Create(_connecting.Self, worldName, name, capacity, country), null)`
- `NationalSpire.Coop.CoopStorage.LoadAsync(string)`；输入表达式：`CoopSettings.Storage.LoadAsync(savedId)`；返回值紧邻使用处：`AwaitExpressionSyntax: await CoopSettings.Storage.LoadAsync(savedId)`
- `NationalSpire.Diagnostics.CapturePeerLogs(string, string, string?)`；输入表达式：`Diagnostics.CapturePeerLogs(ProjectSettings.GlobalizePath("user://logs"), Native?.Status ?? Status, Session.World?.World.WorldId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Diagnostics.CapturePeerLogs(ProjectSettings.GlobalizePath("user://logs"), Native?.Status ?? Status, Session.World?.World.WorldId)`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`GameBridge.Characters().Select(c => c.Id.ToString())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().Select(c => c.Id.ToString()).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`GameBridge.Characters().Select(c => c.Id.ToString()).ToHashSet()`；返回值紧邻使用处：`ArgumentSyntax: GameBridge.Characters().Select(c => c.Id.ToString()).ToHashSet()`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先退出当前房间或对局。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先退出当前房间或对局。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("这个检查点属于另一名主机。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("这个检查点属于另一名主机。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException(compatibilityError)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException(compatibilityError);`
- `System.OperationCanceledException.OperationCanceledException(string?)`；输入表达式：`new OperationCanceledException("已取消连接。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new OperationCanceledException("已取消连接。");`

**赋值（含属性/字段和局部值）：**

- `_` = `Ai.Process()`
- `_busy` = `false`
- `_busy` = `true`
- `_connecting` = `new CoopSteam()`
- `_connecting` = `null`
- `_live` = `new(Session)`
- `_nativeAttempt` = `Session.World?.Run?.Attempt ?? ""`
- `_pausedCount` = `Session.World?.Run?.ResumeCount ?? 0`
- `_resumeRequired` = `Session.World?.Run != null`
- `Ai` = `new(Session)`
- `checkpoint.World.CareerStarted` |= `checkpoint.World.RosterLocked || checkpoint.World.World.Day > 1`
- `checkpoint.World.World.Ai.Enabled` = `AiSettingsStore.Load(new()).Enabled`
- `checkpoint` = `savedId.Length > 0 ? await CoopSettings.Storage.LoadAsync(savedId) : new(CoopRules.Create(_connecting.Self, worldName, name, capacity, country), null)`
- `InviteCode` = `_connecting.Code`
- `Native` = `new(Session)`
- `savedRun.Phase` = `"paused"`
- `Session.CaptureDiagnostics` = `() => Diagnostics.CapturePeerLogs(ProjectSettings.GlobalizePath("user://logs"), Native?.Status ?? Status, Session.World?.World.WorldId)`
- `Session.RunMessage` += `Native.Message`
- `Session.TriggerAi` += `kind => { if (kind is "confirm" or "failure-confirm" or "post" or "reply" or "dm-confirm" or "dm-arbitration-apology" or "group-offer-confirm") _ = Ai.Process(); }`
- `Session` = `new(_connecting, CoopSettings.Storage, Compatibility, _connecting.Token, name, GameBridge.Characters().Select(c => c.Id.ToString()).ToHashSet(), checkpoint)`
- `Status` = `"房间已连接"`

<a id="symbol-e77a969fcfd3"></a>

## `NationalSpire.Coop.CoopRuntime.CancelConnection() — public void CancelConnection()`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.Leave()`](CoopScreen.cs.md#symbol-187bb3392c96)

**调用：** [`NationalSpire.Coop.CoopSteam.Dispose()`](CoopSteam.cs.md#symbol-e6ebd27b8764)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime._connecting`；`NationalSpire.Coop.CoopRuntime._connectionGeneration`；`NationalSpire.Coop.CoopSteam.Dispose()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopSteam.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _connecting?.Dispose()`

**赋值（含属性/字段和局部值）：**

- `_connecting` = `null`

<a id="symbol-ec1513bd09b1"></a>

## `NationalSpire.Coop.CoopRuntime._Process(double) — public override void _Process(double delta)`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)；[`NationalSpire.Coop.CoopLive.Update()`](CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.Coop.CoopNativeRun.Close()`](CoopNativeRun.cs.md#symbol-c8afc67dbfe3)；[`NationalSpire.Coop.CoopNativeRun.PumpPendingNetwork()`](CoopNativeRun.cs.md#symbol-1e34d21d8d03)；[`NationalSpire.Coop.CoopNativeRun.Update()`](CoopNativeRun.cs.md#symbol-f8b6c697410f)；[`NationalSpire.Coop.CoopRuntime.FinishTerminal()`](CoopRuntime.cs.md#symbol-9dbe454d0582)；[`NationalSpire.Coop.CoopRuntime.Pause()`](CoopRuntime.cs.md#symbol-4d6b5e85d748)；[`NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`](CoopScreen.cs.md#symbol-eee7991d404e)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Current`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Tick()`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopLive.Update()`；`NationalSpire.Coop.CoopNativeRun.Close()`；`NationalSpire.Coop.CoopNativeRun.Entering`；`NationalSpire.Coop.CoopNativeRun.HasConnection`；`NationalSpire.Coop.CoopNativeRun.Launched`；`NationalSpire.Coop.CoopNativeRun.NeedsPause`；`NationalSpire.Coop.CoopNativeRun.PumpPendingNetwork()`；`NationalSpire.Coop.CoopNativeRun.Update()`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopRun.Terminal`；`NationalSpire.Coop.CoopRuntime._completedPause`；`NationalSpire.Coop.CoopRuntime._live`；`NationalSpire.Coop.CoopRuntime._liveTick`；`NationalSpire.Coop.CoopRuntime._nativeAttempt`；`NationalSpire.Coop.CoopRuntime._pausedCount`；`NationalSpire.Coop.CoopRuntime._pausing`；`NationalSpire.Coop.CoopRuntime._resumeRequired`；`NationalSpire.Coop.CoopRuntime.FinishTerminal()`；`NationalSpire.Coop.CoopRuntime.Native`；`NationalSpire.Coop.CoopRuntime.Pause()`；`NationalSpire.Coop.CoopRuntime.ReturningToMenu`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopRuntime.Status`；`NationalSpire.Coop.CoopScreen.Current`；`NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`；`NationalSpire.Coop.CoopWorld.Proposal`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Tick()`；输入表达式：`.Tick()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Session?.Tick()`
- `NationalSpire.Coop.CoopLive.Update()`；输入表达式：`.Update()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _live?.Update()`
- `NationalSpire.Coop.CoopNativeRun.Close()`；输入表达式：`.Close()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Native?.Close()`
- `NationalSpire.Coop.CoopNativeRun.PumpPendingNetwork()`；输入表达式：`.PumpPendingNetwork()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Native?.PumpPendingNetwork()`
- `NationalSpire.Coop.CoopNativeRun.Update()`；输入表达式：`.Update()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Native?.Update()`
- `NationalSpire.Coop.CoopRuntime.FinishTerminal()`；输入表达式：`FinishTerminal()`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishTerminal();`
- `NationalSpire.Coop.CoopRuntime.Pause()`；输入表达式：`Pause()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Pause()`
- `NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`；输入表达式：`CoopScreen.OpenCareerOrRoom(menu)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopScreen.OpenCareerOrRoom(menu);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.runtime", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.runtime", e);`

**赋值（含属性/字段和局部值）：**

- `_` = `Pause()`
- `_completedPause` = `""`
- `_liveTick` += `delta`
- `_liveTick` = `0`
- `_nativeAttempt` = `attempt`
- `_pausedCount` = `paused.ResumeCount`
- `_resumeRequired` = `false`
- `_resumeRequired` = `Session.World?.Run?.Phase == "paused"`
- `_resumeRequired` = `true`
- `Status` = `e.Message`

<a id="symbol-4d6b5e85d748"></a>

## `NationalSpire.Coop.CoopRuntime.Pause() — public Task Pause()`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopDisconnectMenuPatch.Prefix(MegaCrit.Sts2.Core.Runs.RunManager, ref System.Threading.Tasks.Task)`](CoopRuntime.cs.md#symbol-a193812f456a)；[`NationalSpire.Coop.CoopLive.ConfirmStop()`](CoopLive.cs.md#symbol-30b59f1772bc)；[`NationalSpire.Coop.CoopRuntime._Process(double)`](CoopRuntime.cs.md#symbol-ec1513bd09b1)

**调用：** [`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](CoopRuntime.cs.md#symbol-60fe2cb26a8e)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopNativeRun.HasConnection`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopRuntime._completedPause`；`NationalSpire.Coop.CoopRuntime._pauseTask`；`NationalSpire.Coop.CoopRuntime.Native`；`NationalSpire.Coop.CoopRuntime.PauseCore(string)`；`NationalSpire.Coop.CoopRuntime.PauseScene`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.ICoopPauseScene.NeedsReturn`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopRuntime.PauseCore(string)`；输入表达式：`PauseCore(key)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pauseTask = PauseCore(key)`

**赋值（含属性/字段和局部值）：**

- `_pauseTask` = `PauseCore(key)`

<a id="symbol-60fe2cb26a8e"></a>

## `NationalSpire.Coop.CoopRuntime.PauseCore(string) — private async Task PauseCore(string key)`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Pause()`](CoopRuntime.cs.md#symbol-4d6b5e85d748)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`](CoopCoordinator.cs.md#symbol-99375ad602b4)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopLive.Close()`](CoopLive.cs.md#symbol-85319a2fb491)；[`NationalSpire.Coop.CoopNativeRun.Close()`](CoopNativeRun.cs.md#symbol-c8afc67dbfe3)；[`NationalSpire.Coop.CoopNativeRun.StopConnection()`](CoopNativeRun.cs.md#symbol-173b8340e058)；[`NationalSpire.Coop.CoopNativeRun.WaitForEntry()`](CoopNativeRun.cs.md#symbol-c81cf8511287)；[`NationalSpire.Coop.ICoopPauseScene.ReturnToMenu()`](CoopRuntime.cs.md#symbol-66f31117cc59)；[`NationalSpire.Coop.ICoopPauseScene.Reveal()`](CoopRuntime.cs.md#symbol-7904dd0288b5)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Record(string, object)`](../Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`](../MatchDiagnostics.cs.md#symbol-2f83ebe4626e)；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.GetTree()`；`System.Threading.Tasks.Task.WaitAsync(System.TimeSpan)`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `<anonymous type: bool Host, bool? remote>.remote`；`<anonymous type: bool Host, string Attempt, int ResumeCount, string Phase, bool? remote>.remote`；`<anonymous type: string epoch, string attempt, int resume>.attempt`；`<anonymous type: string epoch, string attempt, int resume>.epoch`；`<anonymous type: string epoch, string attempt, int resume>.resume`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopLive.Close()`；`NationalSpire.Coop.CoopNativeRun.Close()`；`NationalSpire.Coop.CoopNativeRun.LastError`；`NationalSpire.Coop.CoopNativeRun.PauseRequestedByHost`；`NationalSpire.Coop.CoopNativeRun.StopConnection()`；`NationalSpire.Coop.CoopNativeRun.WaitForEntry()`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.FailureReason`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopRun.Terminal`；`NationalSpire.Coop.CoopRuntime._completedPause`；`NationalSpire.Coop.CoopRuntime._live`；`NationalSpire.Coop.CoopRuntime._pausedCount`；`NationalSpire.Coop.CoopRuntime._pausing`；`NationalSpire.Coop.CoopRuntime._resumeRequired`；`NationalSpire.Coop.CoopRuntime.MenuReturn`；`NationalSpire.Coop.CoopRuntime.Native`；`NationalSpire.Coop.CoopRuntime.PauseScene`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopRuntime.Status`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Proposal`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.ICoopPauseScene.NeedsReturn`；`NationalSpire.Coop.ICoopPauseScene.ReturnToMenu()`；`NationalSpire.Coop.ICoopPauseScene.Reveal()`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame)`
- `Godot.Node.GetTree()`；输入表达式：`GetTree()`；返回值紧邻使用处：`ArgumentSyntax: GetTree()`
- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`session.Commit(paused, session.NativeSave)`；返回值紧邻使用处：`ExpressionStatementSyntax: session.Commit(paused, session.NativeSave);`
- `NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`；输入表达式：`session.SendRun("run-pause", new { epoch = session.World.Epoch, attempt = run.Attempt, resume = run.ResumeCount })`；返回值紧邻使用处：`ExpressionStatementSyntax: session.SendRun("run-pause", new { epoch = session.World.Epoch, attempt = run.Attempt, resume = run.ResumeCount });`
- `NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`；输入表达式：`session.SendRun("run-return", new { epoch = session.World.Epoch, attempt = run.Attempt, resume = run.ResumeCount })`；返回值紧邻使用处：`ExpressionStatementSyntax: session.SendRun("run-return", new { epoch = session.World.Epoch, attempt = run.Attempt, resume = run.ResumeCount });`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(session.World)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(session.World)`
- `NationalSpire.Coop.CoopLive.Close()`；输入表达式：`.Close()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _live?.Close()`
- `NationalSpire.Coop.CoopNativeRun.Close()`；输入表达式：`.Close()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: native?.Close()`
- `NationalSpire.Coop.CoopNativeRun.StopConnection()`；输入表达式：`.StopConnection()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: native?.StopConnection()`
- `NationalSpire.Coop.CoopNativeRun.WaitForEntry()`；输入表达式：`native.WaitForEntry()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: native.WaitForEntry().WaitAsync`
- `NationalSpire.Coop.ICoopPauseScene.ReturnToMenu()`；输入表达式：`PauseScene.ReturnToMenu()`；返回值紧邻使用处：`AwaitExpressionSyntax: await PauseScene.ReturnToMenu()`
- `NationalSpire.Coop.ICoopPauseScene.Reveal()`；输入表达式：`PauseScene.Reveal()`；返回值紧邻使用处：`AwaitExpressionSyntax: await PauseScene.Reveal()`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.pause.entry-timeout", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.pause.entry-timeout", e);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.pause.fade-in", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.pause.fade-in", e);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.pause", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.pause", e);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("coop.pause.begin", new { session.Host, run.Attempt, run.ResumeCount, run.Phase, remote = native?.PauseRequestedByHost })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("coop.pause.begin", new { session.Host, run.Attempt, run.ResumeCount, run.Phase, remote = native?.PauseRequestedByHost });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("coop.pause.end", new { key })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("coop.pause.end", new { key });`
- `NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`；输入表达式：`Diagnostics.RecordMatch(session.World!, "pause", new { session.Host, remote = native?.PauseRequestedByHost }, includePlan: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RecordMatch(session.World!, "pause", new { session.Host, remote = native?.PauseRequestedByHost }, includePlan: true);`
- `System.Threading.Tasks.Task.WaitAsync(System.TimeSpan)`；输入表达式：`native.WaitForEntry().WaitAsync(TimeSpan.FromSeconds(8))`；返回值紧邻使用处：`AwaitExpressionSyntax: await native.WaitForEntry().WaitAsync(TimeSpan.FromSeconds(8))`
- `System.Threading.Tasks.Task.WaitAsync(System.TimeSpan)`；输入表达式：`returning.WaitAsync(TimeSpan.FromSeconds(30))`；返回值紧邻使用处：`AwaitExpressionSyntax: await returning.WaitAsync(TimeSpan.FromSeconds(30))`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(30)`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromSeconds(30)`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(8)`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromSeconds(8)`

**赋值（含属性/字段和局部值）：**

- `_completedPause` = `key`
- `_pausedCount` = `session.World?.Run?.ResumeCount ?? 0`
- `_pausing` = `false`
- `_pausing` = `true`
- `_resumeRequired` = `session.World?.Run != null`
- `paused.Proposal` = `null`
- `paused.Run!.Phase` = `"paused"`
- `paused.Run.FailureReason` = `native?.LastError ?? ""`
- `Status` = `"暂停转场失败，最近检查点仍保留。请退出游戏后恢复：" + e.Message`
- `Status` = `native?.LastError.Length > 0 ? "比赛连接失败：" + native.LastError : "比赛已暂停。全员返回后可从最近检查点继续。"`

<a id="symbol-8fec1ccea16a"></a>

## `NationalSpire.Coop.CoopRuntime.ResumeRequired — public bool ResumeRequired`

来源：源码第 197 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime._resumeRequired`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a4550fd42c36"></a>

## `NationalSpire.Coop.CoopRuntime.Disconnect() — public void Disconnect()`

来源：源码第 198 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.ConfirmStop()`](CoopLive.cs.md#symbol-30b59f1772bc)；[`NationalSpire.Coop.CoopScreen.Leave()`](CoopScreen.cs.md#symbol-187bb3392c96)；[`NationalSpire.Coop.CoopScreen.OpenSaved(Godot.Control, string)`](CoopScreen.cs.md#symbol-ea5fafed6b79)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)

**调用：** [`NationalSpire.Coop.CoopAi.Stop()`](CoopAi.cs.md#symbol-db98f42d4f99)；[`NationalSpire.Coop.CoopCoordinator.Dispose()`](CoopCoordinator.cs.md#symbol-a57b33d7004f)；[`NationalSpire.Coop.CoopLive.Close()`](CoopLive.cs.md#symbol-85319a2fb491)；[`NationalSpire.Coop.CoopNativeRun.Close()`](CoopNativeRun.cs.md#symbol-c8afc67dbfe3)；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAi.Stop()`；`NationalSpire.Coop.CoopCoordinator.Dispose()`；`NationalSpire.Coop.CoopLive.Close()`；`NationalSpire.Coop.CoopNativeRun.Close()`；`NationalSpire.Coop.CoopNativeRun.Entering`；`NationalSpire.Coop.CoopRuntime._live`；`NationalSpire.Coop.CoopRuntime._resumeRequired`；`NationalSpire.Coop.CoopRuntime.Ai`；`NationalSpire.Coop.CoopRuntime.InviteCode`；`NationalSpire.Coop.CoopRuntime.Native`；`NationalSpire.Coop.CoopRuntime.Session`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAi.Stop()`；输入表达式：`.Stop()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Ai?.Stop()`
- `NationalSpire.Coop.CoopCoordinator.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Session?.Dispose()`
- `NationalSpire.Coop.CoopLive.Close()`；输入表达式：`.Close()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _live?.Close()`
- `NationalSpire.Coop.CoopNativeRun.Close()`；输入表达式：`.Close()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Native?.Close()`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先完成转场并保存退出当前对局。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先完成转场并保存退出当前对局。");`

**赋值（含属性/字段和局部值）：**

- `_live` = `null`
- `_resumeRequired` = `false`
- `Ai` = `null`
- `InviteCode` = `""`
- `Native` = `null`
- `Session` = `null`

<a id="symbol-732476d12d29"></a>

## `NationalSpire.Coop.CoopRuntime.Complete(MegaCrit.Sts2.Core.Runs.RunHistory) — public void Complete(RunHistory history)`

来源：源码第 204 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopHistoryPatch.Prefix(MegaCrit.Sts2.Core.Runs.RunHistory)`](CoopRuntime.cs.md#symbol-1eda71dc88b5)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopRuntime.FinishTerminal()`](CoopRuntime.cs.md#symbol-9dbe454d0582)；[`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`](../MatchDiagnostics.cs.md#symbol-2f83ebe4626e)；[`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer)`](../GameBridge.cs.md#symbol-2ddde8df91f3)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.Coop.CoopLivePlayer.CoopLivePlayer(ulong, string, int, int, bool)`；`NationalSpire.Coop.CoopTerminalResult.CoopTerminalResult(bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: bool Host, bool Win, bool WasAbandoned, float RunTime, System.Collections.Generic.IEnumerable<<anonymous type: int act, System.Collections.Generic.IEnumerable<<anonymous type: string kind, System.Collections.Generic.IEnumerable<<anonymous type: string kind, string model, int TurnsTaken>> rooms, System.Collections.Generic.IEnumerable<<anonymous type: ulong PlayerId, int CurrentHp, int MaxHp, int DamageTaken, int HpHealed>> players>> steps>> route>.route`；`<anonymous type: int act, System.Collections.Generic.IEnumerable<<anonymous type: string kind, System.Collections.Generic.IEnumerable<<anonymous type: string kind, string model, int TurnsTaken>> rooms, System.Collections.Generic.IEnumerable<<anonymous type: ulong PlayerId, int CurrentHp, int MaxHp, int DamageTaken, int HpHealed>> players>> steps>.act`；`<anonymous type: int act, System.Collections.Generic.IEnumerable<<anonymous type: string kind, System.Collections.Generic.IEnumerable<<anonymous type: string kind, string model, int TurnsTaken>> rooms, System.Collections.Generic.IEnumerable<<anonymous type: ulong PlayerId, int CurrentHp, int MaxHp, int DamageTaken, int HpHealed>> players>> steps>.steps`；`<anonymous type: string kind, string model, int TurnsTaken>.kind`；`<anonymous type: string kind, string model, int TurnsTaken>.model`；`<anonymous type: string kind, System.Collections.Generic.IEnumerable<<anonymous type: string kind, string model, int TurnsTaken>> rooms, System.Collections.Generic.IEnumerable<<anonymous type: ulong PlayerId, int CurrentHp, int MaxHp, int DamageTaken, int HpHealed>> players>.kind`；`<anonymous type: string kind, System.Collections.Generic.IEnumerable<<anonymous type: string kind, string model, int TurnsTaken>> rooms, System.Collections.Generic.IEnumerable<<anonymous type: ulong PlayerId, int CurrentHp, int MaxHp, int DamageTaken, int HpHealed>> players>.players`；`<anonymous type: string kind, System.Collections.Generic.IEnumerable<<anonymous type: string kind, string model, int TurnsTaken>> rooms, System.Collections.Generic.IEnumerable<<anonymous type: ulong PlayerId, int CurrentHp, int MaxHp, int DamageTaken, int HpHealed>> players>.rooms`；`NationalSpire.CareerResult.Evidence`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.Full`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopNativeRun.NeedsPause`；`NationalSpire.Coop.CoopRun.Ascension`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopRun.Terminal`；`NationalSpire.Coop.CoopRuntime._pausing`；`NationalSpire.Coop.CoopRuntime._resumeRequired`；`NationalSpire.Coop.CoopRuntime.FinishTerminal()`；`NationalSpire.Coop.CoopRuntime.Native`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopRuntime.Status`；`NationalSpire.Coop.CoopTerminalResult.Details`；`NationalSpire.Coop.CoopWorld.NativeHistoryReceipts`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`；`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer)`；`NationalSpire.RunEvidence.FinalHp`；`NationalSpire.RunEvidence.MaxHp`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: room.ModelId?.ToString()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`p.Character.ToString()`；返回值紧邻使用处：`ArgumentSyntax: p.Character.ToString()`
- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`Session.Commit(recorded, Session.NativeSave)`；返回值紧邻使用处：`ExpressionStatementSyntax: Session.Commit(recorded, Session.NativeSave);`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(Session.World)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(Session.World)`
- `NationalSpire.Coop.CoopLivePlayer.CoopLivePlayer(ulong, string, int, int, bool)`；输入表达式：`new CoopLivePlayer(p.Id, p.Character.ToString(), evidence.FinalHp ?? 0, evidence.MaxHp ?? 0, evidence.FinalHp == 0)`；返回值紧邻使用处：`ReturnStatementSyntax: return new CoopLivePlayer(p.Id, p.Character.ToString(), evidence.FinalHp ?? 0, evidence.MaxHp ?? 0, evidence.FinalHp == 0);`
- `NationalSpire.Coop.CoopRuntime.FinishTerminal()`；输入表达式：`FinishTerminal()`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishTerminal();`
- `NationalSpire.Coop.CoopTerminalResult.CoopTerminalResult(bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>)`；输入表达式：`new(history.Win && !history.WasAbandoned, history.MapPointHistory.Sum(a => a.Count), history.RunTime, players) { Details = details }`；返回值紧邻使用处：`AssignmentExpressionSyntax: recorded.Run!.Terminal = new(history.Win && !history.WasAbandoned, history.MapPointHistory.Sum(a => a.Count), history.RunTime, players) { Details = details }`
- `NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`；输入表达式：`Diagnostics.RecordMatch(Session.World, "native-completed", new          {              Session.Host, history.Win, history.WasAbandoned, history.RunTime,              route = history.MapPointHistory.Select((act, index) => new              {                  act = index, steps = act.Select(point => new                  {                      kind = point.MapPointType.ToString(),                      rooms = point.Rooms.Select(room => new { kind = room.RoomType.ToString(), model = room.ModelId?.ToString(), room.TurnsTaken }),                      players = point.PlayerStats.Select(p => new { p.PlayerId, p.CurrentHp, p.MaxHp, p.DamageTaken, p.HpHealed })                  })              })          }, includePlan: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RecordMatch(Session.World, "native-completed", new          {              Session.Host, history.Win, history.WasAbandoned, history.RunTime,              route = history.MapPointHistory.Select((act, index) => new              {                  act = index, steps = act.Select(point => new                  {                      kind = point.MapPointType.ToString(),                      rooms = point.Rooms.Select(room => new { kind = room.RoomType.ToString(), model = room.ModelId?.ToString(), room.TurnsTaken }),                      players = point.PlayerStats.Select(p => new { p.PlayerId, p.CurrentHp, p.MaxHp, p.DamageTaken, p.HpHealed })                  })              })          }, includePlan: true);`
- `NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer)`；输入表达式：`GameBridge.ReadPlayerHistory(history, p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => GameBridge.ReadPlayerHistory(history, p)`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',', history.Players.Select(p => p.Id).Order())`；返回值紧邻使用处：`BinaryExpressionSyntax: history.StartTime + "/" + history.Seed + "/" + history.Ascension + "/" + string.Join(',', history.Players.Select(p => p.Id).Order())`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`recorded.NativeHistoryReceipts.Add(historyKey)`；返回值紧邻使用处：`ExpressionStatementSyntax: recorded.NativeHistoryReceipts.Add(historyKey);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`Session.World.NativeHistoryReceipts.Contains(historyKey)`；返回值紧邻使用处：`IfStatementSyntax: if (Session.World.NativeHistoryReceipts.Contains(historyKey)) return;`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`history.Players.Select(p => p.Id).Order()`；返回值紧邻使用处：`ArgumentSyntax: history.Players.Select(p => p.Id).Order()`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`history.Players.Select(p => p.Id).Order()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.Players.Select(p => p.Id).Order().SequenceEqual`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`run.Characters.Keys.Order()`；返回值紧邻使用处：`ArgumentSyntax: run.Characters.Keys.Order()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`history.MapPointHistory.Select((act, index) => new              {                  act = index, steps = act.Select(point => new                  {                      kind = point.MapPointType.ToString(),                      rooms = point.Rooms.Select(room => new { kind = room.RoomType.ToString(), model = room.ModelId?.ToString(), room.TurnsTaken }),                      players = point.PlayerStats.Select(p => new { p.PlayerId, p.CurrentHp, p.MaxHp, p.DamageTaken, p.HpHealed })                  })              })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: route = history.MapPointHistory.Select((act, index) => new              {                  act = index, steps = act.Select(point => new                  {                      kind = point.MapPointType.ToString(),                      rooms = point.Rooms.Select(room => new { kind = room.RoomType.ToString(), model = room.ModelId?.ToString(), room.TurnsTaken }),                      players = point.PlayerStats.Select(p => new { p.PlayerId, p.CurrentHp, p.MaxHp, p.DamageTaken, p.HpHealed })                  })              })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`act.Select(point => new                  {                      kind = point.MapPointType.ToString(),                      rooms = point.Rooms.Select(room => new { kind = room.RoomType.ToString(), model = room.ModelId?.ToString(), room.TurnsTaken }),                      players = point.PlayerStats.Select(p => new { p.PlayerId, p.CurrentHp, p.MaxHp, p.DamageTaken, p.HpHealed })                  })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: steps = act.Select(point => new                  {                      kind = point.MapPointType.ToString(),                      rooms = point.Rooms.Select(room => new { kind = room.RoomType.ToString(), model = room.ModelId?.ToString(), room.TurnsTaken }),                      players = point.PlayerStats.Select(p => new { p.PlayerId, p.CurrentHp, p.MaxHp, p.DamageTaken, p.HpHealed })                  })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`history.Players.Select(p =>          {              var evidence = details[p.Id].Evidence;              return new CoopLivePlayer(p.Id, p.Character.ToString(), evidence.FinalHp ?? 0, evidence.MaxHp ?? 0, evidence.FinalHp == 0);          })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.Players.Select(p =>          {              var evidence = details[p.Id].Evidence;              return new CoopLivePlayer(p.Id, p.Character.ToString(), evidence.FinalHp ?? 0, evidence.MaxHp ?? 0, evidence.FinalHp == 0);          }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`history.Players.Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.Players.Select(p => p.Id).Order`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`point.PlayerStats.Select(p => new { p.PlayerId, p.CurrentHp, p.MaxHp, p.DamageTaken, p.HpHealed })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: players = point.PlayerStats.Select(p => new { p.PlayerId, p.CurrentHp, p.MaxHp, p.DamageTaken, p.HpHealed })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`point.Rooms.Select(room => new { kind = room.RoomType.ToString(), model = room.ModelId?.ToString(), room.TurnsTaken })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: rooms = point.Rooms.Select(room => new { kind = room.RoomType.ToString(), model = room.ModelId?.ToString(), room.TurnsTaken })`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`history.Players.Select(p => p.Id).Order().SequenceEqual(run.Characters.Keys.Order())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !history.Players.Select(p => p.Id).Order().SequenceEqual(run.Characters.Keys.Order())`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`history.MapPointHistory.Sum(a => a.Count)`；返回值紧邻使用处：`ArgumentSyntax: history.MapPointHistory.Sum(a => a.Count)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`history.Players.ToDictionary(p => p.Id, p => GameBridge.ReadPlayerHistory(history, p))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = history.Players.ToDictionary(p => p.Id, p => GameBridge.ReadPlayerHistory(history, p))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`history.Players.Select(p =>          {              var evidence = details[p.Id].Evidence;              return new CoopLivePlayer(p.Id, p.Character.ToString(), evidence.FinalHp ?? 0, evidence.MaxHp ?? 0, evidence.FinalHp == 0);          }).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = history.Players.Select(p =>          {              var evidence = details[p.Id].Evidence;              return new CoopLivePlayer(p.Id, p.Character.ToString(), evidence.FinalHp ?? 0, evidence.MaxHp ?? 0, evidence.FinalHp == 0);          }).ToList()`
- `System.Enum.ToString()`；输入表达式：`point.MapPointType.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: kind = point.MapPointType.ToString()`
- `System.Enum.ToString()`；输入表达式：`room.RoomType.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: kind = room.RoomType.ToString()`

**赋值（含属性/字段和局部值）：**

- `Details` = `details`
- `recorded.Run!.Terminal` = `new(history.Win && !history.WasAbandoned, history.MapPointHistory.Sum(a => a.Count), history.RunTime, players) { Details = details }`
- `Status` = `"比赛已暂停，等待全队恢复后继续。"`

<a id="symbol-9dbe454d0582"></a>

## `NationalSpire.Coop.CoopRuntime.FinishTerminal() — private void FinishTerminal()`

来源：源码第 239 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime._Process(double)`](CoopRuntime.cs.md#symbol-ec1513bd09b1)；[`NationalSpire.Coop.CoopRuntime.Complete(MegaCrit.Sts2.Core.Runs.RunHistory)`](CoopRuntime.cs.md#symbol-732476d12d29)

**调用：** [`NationalSpire.Coop.CoopAi.Process(bool)`](CoopAi.cs.md#symbol-3046e7db594f)；[`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](CoopRules.cs.md#symbol-926ebe8770ca)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.Coop.CoopAi.Process(bool)`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.Terminal`；`NationalSpire.Coop.CoopRuntime.Ai`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopRuntime.Status`；`NationalSpire.Coop.CoopTerminalResult.Details`；`NationalSpire.Coop.CoopTerminalResult.Floor`；`NationalSpire.Coop.CoopTerminalResult.Players`；`NationalSpire.Coop.CoopTerminalResult.Seconds`；`NationalSpire.Coop.CoopTerminalResult.Win`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAi.Process(bool)`；输入表达式：`Ai!.Process()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Ai!.Process()`
- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`Session.Commit(next, null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Session.Commit(next, null);`
- `NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`；输入表达式：`CoopRules.Settle(Session.World, run.Attempt, result.Win, false, result.Floor, result.Seconds, result.Players, result.Details)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopRules.Settle(Session.World, run.Attempt, result.Win, false, result.Floor, result.Seconds, result.Players, result.Details)`

**赋值（含属性/字段和局部值）：**

- `_` = `Ai!.Process()`
- `Status` = `next.World.Failure == null ? "比赛已经结算" : "请选择重赛或确认失败"`

<a id="symbol-898c6637244f"></a>

## `NationalSpire.Coop.CoopMenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu) — public static void Postfix(NMainMenu __instance)`

来源：源码第 250 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.CreateTheme()`](../CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`](CoopScreen.cs.md#symbol-c9ac083daf6c)；[`NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`](CoopScreen.cs.md#symbol-eee7991d404e)；[`NationalSpire.MainMenuEntries.Bind(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, Godot.Button)`](../MainMenuEntries.cs.md#symbol-04f3caa98ff1)；`Godot.Button.Button()`；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.CreateTheme()`；`NationalSpire.Coop.CoopRuntime.Bound`；`NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`；`NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`；`NationalSpire.MainMenuEntries.Bind(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, Godot.Button)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = "国运尖塔：多人模式", Theme = CareerVisuals.CreateTheme() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = "国运尖塔：多人模式", Theme = CareerVisuals.CreateTheme() }`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => CoopScreen.OpenCareerOrRoom(__instance)).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => CoopScreen.OpenCareerOrRoom(__instance)).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => CoopScreen.OpenCareerOrRoom(__instance))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => CoopScreen.OpenCareerOrRoom(__instance)).CallDeferred`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`button.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.BottomLeft)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.BottomLeft);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`__instance.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: __instance.AddChild(button);`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme = CareerVisuals.CreateTheme()`
- `NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`；输入表达式：`CoopScreen.Open(__instance)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => CoopScreen.Open(__instance)`
- `NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`；输入表达式：`CoopScreen.OpenCareerOrRoom(__instance)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => CoopScreen.OpenCareerOrRoom(__instance)`
- `NationalSpire.MainMenuEntries.Bind(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, Godot.Button)`；输入表达式：`MainMenuEntries.Bind(__instance, button)`；返回值紧邻使用处：`ExpressionStatementSyntax: MainMenuEntries.Bind(__instance, button);`

**赋值（含属性/字段和局部值）：**

- `button.OffsetBottom` = `-114`
- `button.OffsetLeft` = `40`
- `button.OffsetRight` = `350`
- `button.OffsetTop` = `-178`
- `button.Pressed` += `() => CoopScreen.Open(__instance)`
- `Text` = `"国运尖塔：多人模式"`
- `Theme` = `CareerVisuals.CreateTheme()`

<a id="symbol-31e8f4b35077"></a>

## `NationalSpire.Coop.CoopContextPatch.Postfix(ref MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext?) — public static void Postfix(ref IScreenContext? __result)`

来源：源码第 262 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopScreen.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `__result` = `CoopScreen.Current`

<a id="symbol-1fc3feae7479"></a>

## `NationalSpire.Coop.CoopPathPatch.Postfix(string, ref string) — public static void Postfix(string fileName, ref string __result)`

来源：源码第 267 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.StartsWith(string, System.StringComparison)`；`System.IO.Path.GetFileName(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRuntime.Bound`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string, System.StringComparison)`；输入表达式：`fileName.StartsWith("current_run_mp", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: CoopRuntime.Bound && fileName.StartsWith("current_run_mp", StringComparison.Ordinal)`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(fileName)`；返回值紧邻使用处：`BinaryExpressionSyntax: "national_spire_coop_native/" + CoopRuntime.Current!.Session!.World!.Id + "/" + Path.GetFileName(fileName)`

**赋值（含属性/字段和局部值）：**

- `__result` = `"national_spire_coop_native/" + CoopRuntime.Current!.Session!.World!.Id + "/" + Path.GetFileName(fileName)`

<a id="symbol-b92b27282db4"></a>

## `NationalSpire.Coop.CoopSaveEntryPatch.TargetMethod() — public static MethodBase TargetMethod()`

来源：源码第 276 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(RunSaveManager), nameof(RunSaveManager.SaveRun), [typeof(MegaCrit.Sts2.Core.Rooms.AbstractRoom)])`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => AccessTools.Method(typeof(RunSaveManager), nameof(RunSaveManager.SaveRun), [typeof(MegaCrit.Sts2.Core.Rooms.AbstractRoom)])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-17b0cee32be9"></a>

## `NationalSpire.Coop.CoopSaveEntryPatch.Prefix() — public static void Prefix()`

来源：源码第 277 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Record(string, object)`](../Diagnostics.cs.md#symbol-1b5632793cd0)；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: bool shouldSave, string network, string attempt, int? floor, string phase>.attempt`；`<anonymous type: bool shouldSave, string network, string attempt, int? floor, string phase>.floor`；`<anonymous type: bool shouldSave, string network, string attempt, int? floor, string phase>.network`；`<anonymous type: bool shouldSave, string network, string attempt, int? floor, string phase>.phase`；`<anonymous type: bool shouldSave, string network, string attempt, int? floor, string phase>.shouldSave`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Floor`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRuntime.Bound`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.autosave.diagnostics", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.autosave.diagnostics", error);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("coop.autosave.request", new { shouldSave = RunManager.Instance.ShouldSave,              network = RunManager.Instance.NetService.Type.ToString(), attempt = CoopRuntime.Current?.Session?.World?.Run?.Attempt,              floor = CoopRuntime.Current?.Session?.World?.Run?.Floor, phase = CoopRuntime.Current?.Session?.World?.Run?.Phase })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("coop.autosave.request", new { shouldSave = RunManager.Instance.ShouldSave,              network = RunManager.Instance.NetService.Type.ToString(), attempt = CoopRuntime.Current?.Session?.World?.Run?.Attempt,              floor = CoopRuntime.Current?.Session?.World?.Run?.Floor, phase = CoopRuntime.Current?.Session?.World?.Run?.Phase });`
- `System.Enum.ToString()`；输入表达式：`RunManager.Instance.NetService.Type.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: network = RunManager.Instance.NetService.Type.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0b112d9b0a96"></a>

## `NationalSpire.Coop.CoopSavePatch.TargetMethod() — public static MethodBase TargetMethod()`

来源：源码第 288 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(RunSaveManager), nameof(RunSaveManager.SaveRun), [typeof(SerializableRun), typeof(bool)])`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => AccessTools.Method(typeof(RunSaveManager), nameof(RunSaveManager.SaveRun), [typeof(SerializableRun), typeof(bool)])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5743aede4fef"></a>

## `NationalSpire.Coop.CoopSavePatch.Prefix(MegaCrit.Sts2.Core.Saves.SerializableRun, bool, ref System.Threading.Tasks.Task) — public static bool Prefix(SerializableRun save, bool isMultiplayer, ref Task __result)`

来源：源码第 289 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-5825a51bfef3)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`System.Threading.Tasks.Task.FromException(System.Exception)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`；`NationalSpire.Coop.CoopRuntime.Bound`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Native`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`CoopRuntime.Current!.Native!.Save(save)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopRuntime.Current!.Native!.Save(save);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.checkpoint", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.checkpoint", e);`
- `System.Threading.Tasks.Task.FromException(System.Exception)`；输入表达式：`Task.FromException(e)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result = Task.FromException(e)`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.CompletedTask`
- `__result` = `Task.FromException(e)`

<a id="symbol-1eda71dc88b5"></a>

## `NationalSpire.Coop.CoopHistoryPatch.Prefix(MegaCrit.Sts2.Core.Runs.RunHistory) — public static bool Prefix(RunHistory history)`

来源：源码第 300 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopRuntime.Complete(MegaCrit.Sts2.Core.Runs.RunHistory)`](CoopRuntime.cs.md#symbol-732476d12d29)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime.Bound`；`NationalSpire.Coop.CoopRuntime.Complete(MegaCrit.Sts2.Core.Runs.RunHistory)`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopRuntime.Complete(MegaCrit.Sts2.Core.Runs.RunHistory)`；输入表达式：`CoopRuntime.Current!.Complete(history)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopRuntime.Current!.Complete(history);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.settlement", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.settlement", e);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a584f317618c"></a>

## `NationalSpire.Coop.CoopReturnPatch.Postfix(System.Threading.Tasks.Task) — public static void Postfix(Task __result)`

来源：源码第 312 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime.Bound`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.MenuReturn`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `CoopRuntime.Current!.MenuReturn` = `__result`

<a id="symbol-a193812f456a"></a>

## `NationalSpire.Coop.CoopDisconnectMenuPatch.Prefix(MegaCrit.Sts2.Core.Runs.RunManager, ref System.Threading.Tasks.Task) — public static bool Prefix(RunManager __instance, ref Task __result)`

来源：源码第 320 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopNativeRun.OwnsConnection(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService)`](CoopNativeRun.cs.md#symbol-9ae33170e5e0)；[`NationalSpire.Coop.CoopRuntime.Pause()`](CoopRuntime.cs.md#symbol-4d6b5e85d748)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopNativeRun.OwnsConnection(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService)`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Native`；`NationalSpire.Coop.CoopRuntime.Pause()`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.Run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopNativeRun.OwnsConnection(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService)`；输入表达式：`.OwnsConnection(__instance.NetService)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: runtime.Native?.OwnsConnection(__instance.NetService)`
- `NationalSpire.Coop.CoopRuntime.Pause()`；输入表达式：`runtime.Pause()`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result = runtime.Pause()`

**赋值（含属性/字段和局部值）：**

- `__result` = `runtime.Pause()`
