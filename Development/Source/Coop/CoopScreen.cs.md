# Coop/CoopScreen.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`354DB42D764572540B785DD766EBFE7F00784E9D347AB48D8B0A03F8B4E8BCD3`。来源：[源码](../../../Coop/CoopScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopScreen`。

字段、事件及初始值（源码原样）：

```csharp
private Control _stage = null!;
private VBoxContainer _body = null!;
private VBoxContainer _footer = null!;
private Label _status = null!;
private Button _back = null!;
private readonly List<CanvasItem> _hidden = [];
private string _message = "", _presence = "";
private long _revision = -1;
private int _entrySequence = -1;
private double _tick;
private bool _working;
private Control? _dialog;
private CoopCommand? _pending;
private CoopCoordinator? _replySession;
```

<a id="symbol-923ed4561aa8"></a>

## `NationalSpire.Coop.CoopScreen.Current — public static CoopScreen? Current`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d60a6967537d"></a>

## `NationalSpire.Coop.CoopScreen.DefaultFocusedControl — public Control? DefaultFocusedControl`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopScreen._back`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9bd66df90b49"></a>

## `NationalSpire.Coop.CoopScreen.Runtime — private CoopRuntime Runtime`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopRuntime.Ensure()`](CoopRuntime.cs.md#symbol-e0212127f782)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime.Ensure()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopRuntime.Ensure()`；输入表达式：`CoopRuntime.Ensure()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => CoopRuntime.Ensure()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8ad8fd6fff78"></a>

## `NationalSpire.Coop.CoopScreen.Session — private CoopCoordinator? Session`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopScreen.Runtime`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ea5fafed6b79"></a>

## `NationalSpire.Coop.CoopScreen.OpenSaved(Godot.Control, string) — public static void OpenSaved(Control menu, string id)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](../CareerLibraryScreen.cs.md#symbol-57e1d5f83960)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](../CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.Coop.CoopRuntime.Disconnect()`](CoopRuntime.cs.md#symbol-a4550fd42c36)；[`NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string)`](CoopScreen.cs.md#symbol-af359fd6d523)；[`NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`](CoopScreen.cs.md#symbol-c9ac083daf6c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Data`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Disconnect()`；`NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string)`；`NationalSpire.Coop.CoopScreen.Current`；`NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(CareerStore.Data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(CareerStore.Data)`
- `NationalSpire.Coop.CoopRuntime.Disconnect()`；输入表达式：`.Disconnect()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CoopRuntime.Current?.Disconnect()`
- `NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string)`；输入表达式：`screen.Connect(true, CareerEngine.Name(CareerStore.Data), saved: id)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.Connect(true, CareerEngine.Name(CareerStore.Data), saved: id);`
- `NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`；输入表达式：`Open(menu)`；返回值紧邻使用处：`ExpressionStatementSyntax: Open(menu);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c9ac083daf6c"></a>

## `NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool) — public static void Open(Control menu, bool stayInRoom = false)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.OpenRoom()`](CoopCareerSession.cs.md#symbol-cf5687c76814)；[`NationalSpire.Coop.CoopMenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](CoopRuntime.cs.md#symbol-898c6637244f)；[`NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`](CoopScreen.cs.md#symbol-eee7991d404e)；[`NationalSpire.Coop.CoopScreen.OpenSaved(Godot.Control, string)`](CoopScreen.cs.md#symbol-ea5fafed6b79)

**调用：** [`NationalSpire.CareerVisuals.CreateTheme()`](../CareerVisuals.cs.md#symbol-a5f88af9f360)；`Godot.CanvasItem.Hide()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`NationalSpire.Coop.CoopScreen.CoopScreen()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.IEnumerable.OfType<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.CreateTheme()`；`NationalSpire.Coop.CoopScreen._hidden`；`NationalSpire.Coop.CoopScreen.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`child.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: child.Hide();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(Current)`；返回值紧邻使用处：`BinaryExpressionSyntax: Current != null && IsInstanceValid(Current)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`menu.AddChild(screen)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.AddChild(screen);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`menu.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: menu.GetChildren().OfType<CanvasItem>`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme = CareerVisuals.CreateTheme()`
- `NationalSpire.Coop.CoopScreen.CoopScreen()`；输入表达式：`new CoopScreen { Name = "NationalSpireMultiplayerLobby", ZIndex = 100, Theme = CareerVisuals.CreateTheme() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CoopScreen { Name = "NationalSpireMultiplayerLobby", ZIndex = 100, Theme = CareerVisuals.CreateTheme() }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`menu.GetChildren().OfType<CanvasItem>().Where(c => c.Visible)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in menu.GetChildren().OfType<CanvasItem>().Where(c => c.Visible)) { screen._hidden.Add(child); child.Hide(); }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`screen._hidden.Add(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen._hidden.Add(child);`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`menu.GetChildren().OfType<CanvasItem>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: menu.GetChildren().OfType<CanvasItem>().Where`

**赋值（含属性/字段和局部值）：**

- `Current` = `screen`
- `Name` = `"NationalSpireMultiplayerLobby"`
- `Theme` = `CareerVisuals.CreateTheme()`
- `ZIndex` = `100`

<a id="symbol-eee7991d404e"></a>

## `NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control) — public static void OpenCareerOrRoom(Control menu)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Open(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, string?)`](../CareerScreen.cs.md#symbol-b760e48de501)；[`NationalSpire.Coop.CoopMenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](CoopRuntime.cs.md#symbol-898c6637244f)；[`NationalSpire.Coop.CoopRuntime._Process(double)`](CoopRuntime.cs.md#symbol-ec1513bd09b1)

**调用：** [`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](../CareerScreen.cs.md#symbol-2b6ef58a9693)；[`NationalSpire.Coop.CoopCareerSession.CoopCareerSession(NationalSpire.Coop.CoopCoordinator, Godot.Control)`](CoopCareerSession.cs.md#symbol-be42258ccf13)；[`NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`](CoopScreen.cs.md#symbol-c9ac083daf6c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`；`NationalSpire.Coop.CoopWorld.CareerStarted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；输入表达式：`CareerScreen.OpenView(menu, new CoopCareerSession(session, menu))`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerScreen.OpenView(menu, new CoopCareerSession(session, menu));`
- `NationalSpire.Coop.CoopCareerSession.CoopCareerSession(NationalSpire.Coop.CoopCoordinator, Godot.Control)`；输入表达式：`new CoopCareerSession(session, menu)`；返回值紧邻使用处：`ArgumentSyntax: new CoopCareerSession(session, menu)`
- `NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`；输入表达式：`Open(menu)`；返回值紧邻使用处：`ExpressionStatementSyntax: Open(menu);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3f7660e3fc51"></a>

## `NationalSpire.Coop.CoopScreen.CloseCurrent() — public static void CloseCurrent()`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteamRunPlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-b889ef6fb033)；[`NationalSpire.Coop.CoopSteamRunPlatform.BeginSaved(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-dc951f669f46)

**调用：** [`NationalSpire.Coop.CoopScreen.Close()`](CoopScreen.cs.md#symbol-96fa80fbf85e)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopScreen.Close()`；`NationalSpire.Coop.CoopScreen.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(Current)`；返回值紧邻使用处：`BinaryExpressionSyntax: Current != null && IsInstanceValid(Current)`
- `NationalSpire.Coop.CoopScreen.Close()`；输入表达式：`Current.Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Current.Close();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-96fa80fbf85e"></a>

## `NationalSpire.Coop.CoopScreen.Close() — private void Close()`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.CloseCurrent()`](CoopScreen.cs.md#symbol-3f7660e3fc51)；[`NationalSpire.Coop.CoopScreen.EnterCareer()`](CoopScreen.cs.md#symbol-88e296cd2158)；[`NationalSpire.Coop.CoopScreen.Leave()`](CoopScreen.cs.md#symbol-187bb3392c96)

**调用：** `Godot.CanvasItem.Show()`；`Godot.Node.QueueFree()`；`MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ActiveScreenContext.Update()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.Replied`；`NationalSpire.Coop.CoopScreen._hidden`；`NationalSpire.Coop.CoopScreen._replySession`；`NationalSpire.Coop.CoopScreen.Current`；`NationalSpire.Coop.CoopScreen.Replied(NationalSpire.Coop.CoopReply)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`node.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: node.Show();`
- `Godot.Node.QueueFree()`；输入表达式：`QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueFree();`
- `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ActiveScreenContext.Update()`；输入表达式：`ActiveScreenContext.Instance.Update()`；返回值紧邻使用处：`ExpressionStatementSyntax: ActiveScreenContext.Instance.Update();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_hidden.Where(IsInstanceValid)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var node in _hidden.Where(IsInstanceValid)) node.Show();`

**赋值（含属性/字段和局部值）：**

- `_replySession.Replied` -= `Replied`
- `Current` = `null`

<a id="symbol-88e296cd2158"></a>

## `NationalSpire.Coop.CoopScreen.EnterCareer() — private void EnterCareer()`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen._Process(double)`](CoopScreen.cs.md#symbol-ac85af6ab46f)

**调用：** [`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](../CareerScreen.cs.md#symbol-2b6ef58a9693)；[`NationalSpire.Coop.CoopCareerSession.CoopCareerSession(NationalSpire.Coop.CoopCoordinator, Godot.Control)`](CoopCareerSession.cs.md#symbol-be42258ccf13)；[`NationalSpire.Coop.CoopScreen.Close()`](CoopScreen.cs.md#symbol-96fa80fbf85e)；`Godot.Node.GetParent()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；`NationalSpire.Coop.CoopScreen.Close()`；`NationalSpire.Coop.CoopScreen.Session`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetParent()`；输入表达式：`GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (Control)GetParent()`
- `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；输入表达式：`CareerScreen.OpenView(menu, new CoopCareerSession(session, menu))`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerScreen.OpenView(menu, new CoopCareerSession(session, menu));`
- `NationalSpire.Coop.CoopCareerSession.CoopCareerSession(NationalSpire.Coop.CoopCoordinator, Godot.Control)`；输入表达式：`new CoopCareerSession(session, menu)`；返回值紧邻使用处：`ArgumentSyntax: new CoopCareerSession(session, menu)`
- `NationalSpire.Coop.CoopScreen.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5affb9c9c17f"></a>

## `NationalSpire.Coop.CoopScreen._Ready() — public override void _Ready()`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`](CoopScreen.cs.md#symbol-806347605946)；[`NationalSpire.Coop.CoopScreen.Fit()`](CoopScreen.cs.md#symbol-6b20e36f164d)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)；[`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`](CoopScreen.cs.md#symbol-2120a3a9f30d)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`NationalSpire.BroadcastBackdrop.BroadcastBackdrop()`；`NationalSpire.BroadcastScroll.BroadcastScroll()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopScreen._back`；`NationalSpire.Coop.CoopScreen._body`；`NationalSpire.Coop.CoopScreen._entrySequence`；`NationalSpire.Coop.CoopScreen._footer`；`NationalSpire.Coop.CoopScreen._stage`；`NationalSpire.Coop.CoopScreen._status`；`NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；`NationalSpire.Coop.CoopScreen.Fit()`；`NationalSpire.Coop.CoopScreen.Leave()`；`NationalSpire.Coop.CoopScreen.Render()`；`NationalSpire.Coop.CoopScreen.Session`；`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；`NationalSpire.Coop.CoopWorld.EntrySequence`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_body.AddThemeConstantOverride("separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: _body.AddThemeConstantOverride("separation", 22);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`frame.AddThemeConstantOverride("separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.AddThemeConstantOverride("separation", 24);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + edge, 38)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + edge, 38);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`padding.AddThemeConstantOverride("margin_bottom", 28)`；返回值紧邻使用处：`ExpressionStatementSyntax: padding.AddThemeConstantOverride("margin_bottom", 28);`
- `Godot.Control.Control()`；输入表达式：`new Control()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _stage = new Control()`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`background.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: background.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_stage)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_stage);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(background)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(background);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`frame.AddChild(_footer)`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.AddChild(_footer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`frame.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`frame.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(brand)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(brand);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(frame)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(frame);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`padding.AddChild(_body)`；返回值紧邻使用处：`ExpressionStatementSyntax: padding.AddChild(_body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(padding)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(padding);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _body = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _footer = new VBoxContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `NationalSpire.BroadcastBackdrop.BroadcastBackdrop()`；输入表达式：`new BroadcastBackdrop()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastBackdrop()`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(header, "返回主菜单", Leave, 180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _back = Button(header, "返回主菜单", Leave, 180)`
- `NationalSpire.Coop.CoopScreen.Fit()`；输入表达式：`Fit()`；返回值紧邻使用处：`ExpressionStatementSyntax: Fit();`
- `NationalSpire.Coop.CoopScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(brand, "国运尖塔：多人模式", 32, CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(brand, "国运尖塔：多人模式", 32, CareerVisuals.Gold);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(brand, "一起攀登，同一支队伍，同一个赛季。", 17, CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(brand, "一起攀登，同一支队伍，同一个赛季。", 17, CareerVisuals.Muted);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(frame, "", 17, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _status = Text(frame, "", 17, CareerVisuals.Teal)`

**赋值（含属性/字段和局部值）：**

- `_back` = `Button(header, "返回主菜单", Leave, 180)`
- `_body` = `new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_entrySequence` = `Session?.World?.EntrySequence ?? -1`
- `_footer` = `new VBoxContainer()`
- `_stage` = `new Control()`
- `_status` = `Text(frame, "", 17, CareerVisuals.Teal)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Resized` += `Fit`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`

<a id="symbol-6b20e36f164d"></a>

## `NationalSpire.Coop.CoopScreen.Fit() — private void Fit()`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen._Ready()`](CoopScreen.cs.md#symbol-5affb9c9c17f)

**调用：** `Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopScreen._stage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(1600, 1000)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _stage.Size = new(1600, 1000)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X / 1600f, Size.Y / 1000f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Size.X / 1600f, Size.Y / 1000f)`

**赋值（含属性/字段和局部值）：**

- `_stage.Position` = `(Size - _stage.Size * scale) / 2`
- `_stage.Scale` = `Vector2.One * scale`
- `_stage.Size` = `new(1600, 1000)`

<a id="symbol-ac85af6ab46f"></a>

## `NationalSpire.Coop.CoopScreen._Process(double) — public override void _Process(double delta)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopScreen.EnterCareer()`](CoopScreen.cs.md#symbol-88e296cd2158)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Linq.Enumerable.Empty<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.Status`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopScreen._dialog`；`NationalSpire.Coop.CoopScreen._entrySequence`；`NationalSpire.Coop.CoopScreen._message`；`NationalSpire.Coop.CoopScreen._presence`；`NationalSpire.Coop.CoopScreen._revision`；`NationalSpire.Coop.CoopScreen._status`；`NationalSpire.Coop.CoopScreen._tick`；`NationalSpire.Coop.CoopScreen._working`；`NationalSpire.Coop.CoopScreen.EnterCareer()`；`NationalSpire.Coop.CoopScreen.Render()`；`NationalSpire.Coop.CoopScreen.Session`；`NationalSpire.Coop.CoopWorld.CareerStarted`；`NationalSpire.Coop.CoopWorld.EntrySequence`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.Run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopScreen.EnterCareer()`；输入表达式：`EnterCareer()`；返回值紧邻使用处：`ExpressionStatementSyntax: EnterCareer();`
- `NationalSpire.Coop.CoopScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',', Session?.Online.Order() ?? Enumerable.Empty<ulong>())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join(',', Session?.Online.Order() ?? Enumerable.Empty<ulong>())`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`.Online.Order()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Session?.Online.Order()`
- `System.Linq.Enumerable.Empty<TResult>()`；输入表达式：`Enumerable.Empty<ulong>()`；返回值紧邻使用处：`BinaryExpressionSyntax: Session?.Online.Order() ?? Enumerable.Empty<ulong>()`

**赋值（含属性/字段和局部值）：**

- `_entrySequence` = `world.EntrySequence`
- `_status.Text` = `_message.Length > 0 ? _message : _working ? "正在连接 Steam 房间……" : Session?.World is { } w ? $"等待房间 · 在线 {Session.Online.Count} 人 · " + (w.Run != null ? "已载入未完成的比赛" : w.CareerStarted ? "生涯进度已载入" : "等待开始生涯") : "2—4 人组队 · 房主保存进度 · 单人存档保持独立"`
- `_status.Text` = `Session.Status`
- `_tick` += `delta`
- `_tick` = `0`

<a id="symbol-5fc019f0fab0"></a>

## `NationalSpire.Coop.CoopScreen._Input(Godot.InputEvent) — public override void _Input(InputEvent input)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopScreen.Leave()`](CoopScreen.cs.md#symbol-187bb3392c96)；`Godot.Node.GetViewport()`；`Godot.Node.QueueFree()`；`Godot.Viewport.SetInputAsHandled()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopScreen._dialog`；`NationalSpire.Coop.CoopScreen.Leave()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().SetInputAsHandled`
- `Godot.Node.QueueFree()`；输入表达式：`_dialog.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dialog.QueueFree();`
- `Godot.Viewport.SetInputAsHandled()`；输入表达式：`GetViewport().SetInputAsHandled()`；返回值紧邻使用处：`ExpressionStatementSyntax: GetViewport().SetInputAsHandled();`
- `NationalSpire.Coop.CoopScreen.Leave()`；输入表达式：`Leave()`；返回值紧邻使用处：`ExpressionStatementSyntax: Leave();`

**赋值（含属性/字段和局部值）：**

- `_dialog` = `null`

<a id="symbol-187bb3392c96"></a>

## `NationalSpire.Coop.CoopScreen.Leave() — private void Leave()`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen._Input(Godot.InputEvent)`](CoopScreen.cs.md#symbol-5fc019f0fab0)

**调用：** [`NationalSpire.Coop.CoopRuntime.CancelConnection()`](CoopRuntime.cs.md#symbol-e77a969fcfd3)；[`NationalSpire.Coop.CoopRuntime.Disconnect()`](CoopRuntime.cs.md#symbol-a4550fd42c36)；[`NationalSpire.Coop.CoopScreen.Close()`](CoopScreen.cs.md#symbol-96fa80fbf85e)；[`NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`](CoopScreen.cs.md#symbol-cbbe81fc6508)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime.CancelConnection()`；`NationalSpire.Coop.CoopRuntime.Disconnect()`；`NationalSpire.Coop.CoopScreen._working`；`NationalSpire.Coop.CoopScreen.Close()`；`NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`；`NationalSpire.Coop.CoopScreen.Runtime`；`NationalSpire.Coop.CoopScreen.Session`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopRuntime.CancelConnection()`；输入表达式：`Runtime.CancelConnection()`；返回值紧邻使用处：`ExpressionStatementSyntax: Runtime.CancelConnection();`
- `NationalSpire.Coop.CoopRuntime.Disconnect()`；输入表达式：`Runtime.Disconnect()`；返回值紧邻使用处：`ExpressionStatementSyntax: Runtime.Disconnect();`
- `NationalSpire.Coop.CoopScreen.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`
- `NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`；输入表达式：`Confirm("离开房间", "离开后队伍会等待你重新加入，已经保存的生涯进度会保留。", () => { Runtime.Disconnect(); Close(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Confirm("离开房间", "离开后队伍会等待你重新加入，已经保存的生涯进度会保留。", () => { Runtime.Disconnect(); Close(); });`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2120a3a9f30d"></a>

## `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?) — private static Label Text(Node parent, string value, int size = 19, Color? color = null)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen._Ready()`](CoopScreen.cs.md#symbol-5affb9c9c17f)；[`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`](CoopScreen.cs.md#symbol-eab6cd747232)；[`NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`](CoopScreen.cs.md#symbol-cbbe81fc6508)；[`NationalSpire.Coop.CoopScreen.Entrance()`](CoopScreen.cs.md#symbol-ef98f9c7ba09)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](CoopScreen.cs.md#symbol-b46abec89d85)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("font_color", color ?? CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("font_color", color ?? CareerVisuals.Ink);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", size);`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = value, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = value, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(label);`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `value`

<a id="symbol-806347605946"></a>

## `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int) — private static Button Button(Node parent, string text, Action action, int width = 220)`

来源：源码第 107 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen._Ready()`](CoopScreen.cs.md#symbol-5affb9c9c17f)；[`NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`](CoopScreen.cs.md#symbol-cbbe81fc6508)；[`NationalSpire.Coop.CoopScreen.Entrance()`](CoopScreen.cs.md#symbol-ef98f9c7ba09)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](CoopScreen.cs.md#symbol-b46abec89d85)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(button);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width, 50)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(width, 50)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Text = text, CustomMinimumSize = new(width, 50), SizeFlagsHorizontal = SizeFlags.ShrinkBegin }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Text = text, CustomMinimumSize = new(width, 50), SizeFlagsHorizontal = SizeFlags.ShrinkBegin }`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `action`
- `CustomMinimumSize` = `new(width, 50)`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `Text` = `text`

<a id="symbol-eab6cd747232"></a>

## `NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?) — private static VBoxContainer Card(Node parent, string title, Color? accent = null)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`](CoopScreen.cs.md#symbol-cbbe81fc6508)；[`NationalSpire.Coop.CoopScreen.Entrance()`](CoopScreen.cs.md#symbol-ef98f9c7ba09)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](CoopScreen.cs.md#symbol-b46abec89d85)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](../CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`](CoopScreen.cs.md#symbol-2120a3a9f30d)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`NationalSpire.BroadcastPanel.BroadcastPanel()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastPanel.Accent`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 15)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 15);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142431", "375061", 10, 25))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142431", "375061", 10, 25));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(panel);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `NationalSpire.BroadcastPanel.BroadcastPanel()`；输入表达式：`new BroadcastPanel { Accent = accent ?? CareerVisuals.Teal, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastPanel { Accent = accent ?? CareerVisuals.Teal, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("142431", "375061", 10, 25)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("142431", "375061", 10, 25)`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(box, title, 25, CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(box, title, 25, CareerVisuals.Gold);`

**赋值（含属性/字段和局部值）：**

- `Accent` = `accent ?? CareerVisuals.Teal`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-5ca0d288e876"></a>

## `NationalSpire.Coop.CoopScreen.Input(Godot.Node, string, string) — private static LineEdit Input(Node parent, string placeholder, string value = "")`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.Entrance()`](CoopScreen.cs.md#symbol-ef98f9c7ba09)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](CoopScreen.cs.md#symbol-b46abec89d85)

**调用：** `Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { PlaceholderText = placeholder, Text = value, CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { PlaceholderText = placeholder, Text = value, CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(line);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 48)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 48)`
- `PlaceholderText` = `placeholder`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `value`

<a id="symbol-cbbe81fc6508"></a>

## `NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string) — private void Confirm(string title, string question, Action action, string confirmText = "确认")`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.Entrance()`](CoopScreen.cs.md#symbol-ef98f9c7ba09)；[`NationalSpire.Coop.CoopScreen.Leave()`](CoopScreen.cs.md#symbol-187bb3392c96)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](CoopScreen.cs.md#symbol-b46abec89d85)

**调用：** [`NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`](CoopScreen.cs.md#symbol-806347605946)；[`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`](CoopScreen.cs.md#symbol-eab6cd747232)；[`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`](CoopScreen.cs.md#symbol-2120a3a9f30d)；`Godot.CenterContainer.CenterContainer()`；`Godot.Color.Color(float, float, float, float)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopScreen._dialog`；`NationalSpire.Coop.CoopScreen._message`；`NationalSpire.Coop.CoopScreen._stage`；`NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CenterContainer()`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new(0, 0, 0, .8f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new(0, 0, 0, .8f)`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Color = new(0, 0, 0, .8f), MouseFilter = MouseFilterEnum.Stop }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Color = new(0, 0, 0, .8f), MouseFilter = MouseFilterEnum.Stop }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(wrapper)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(wrapper);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(center);`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { CustomMinimumSize = new(720, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { CustomMinimumSize = new(720, 0) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(720, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(720, 0)`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(row, "取消", () => { shade.QueueFree(); _dialog = null; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(row, "取消", () => { shade.QueueFree(); _dialog = null; });`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(row, confirmText, () => { shade.QueueFree(); _dialog = null; try { action(); } catch (Exception e) { _message = e.Message; } })`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(row, confirmText, () => { shade.QueueFree(); _dialog = null; try { action(); } catch (Exception e) { _message = e.Message; } });`
- `NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；输入表达式：`Card(wrapper, title)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card(wrapper, title)`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(body, question)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(body, question);`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`

**赋值（含属性/字段和局部值）：**

- `_dialog` = `null`
- `_dialog` = `shade`
- `_message` = `e.Message`
- `Color` = `new(0, 0, 0, .8f)`
- `CustomMinimumSize` = `new(720, 0)`
- `MouseFilter` = `MouseFilterEnum.Stop`

<a id="symbol-af359fd6d523"></a>

## `NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string) — private async void Connect(bool host, string name, int capacity = 2, string country = "中国", string code = "", string saved = "")`

来源：源码第 126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.Entrance()`](CoopScreen.cs.md#symbol-ef98f9c7ba09)；[`NationalSpire.Coop.CoopScreen.OpenSaved(Godot.Control, string)`](CoopScreen.cs.md#symbol-ea5fafed6b79)

**调用：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string)`](CoopRuntime.cs.md#symbol-5c58a004498a)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string)`；`NationalSpire.Coop.CoopScreen._entrySequence`；`NationalSpire.Coop.CoopScreen._message`；`NationalSpire.Coop.CoopScreen._working`；`NationalSpire.Coop.CoopScreen.Render()`；`NationalSpire.Coop.CoopScreen.Runtime`；`NationalSpire.Coop.CoopScreen.Session`；`NationalSpire.Coop.CoopWorld.EntrySequence`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && !IsQueuedForDeletion()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(this) || IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsQueuedForDeletion()`
- `NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string)`；输入表达式：`Runtime.Connect(host, name, name.Trim() + "的队伍", capacity, country, code, saved)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Runtime.Connect(host, name, name.Trim() + "的队伍", capacity, country, code, saved)`
- `NationalSpire.Coop.CoopScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `string.Trim()`；输入表达式：`name.Trim()`；返回值紧邻使用处：`BinaryExpressionSyntax: name.Trim() + "的队伍"`

**赋值（含属性/字段和局部值）：**

- `_entrySequence` = `Session?.World?.EntrySequence ?? -1`
- `_message` = `"房间已创建，请先邀请队友。"`
- `_message` = `"已加入房间，正在等待队友。"`
- `_message` = `"正在连接 Steam 房间……"`
- `_message` = `e.Message`
- `_working` = `false`
- `_working` = `true`

<a id="symbol-9efdcfdc1723"></a>

## `NationalSpire.Coop.CoopScreen.Submit(string, string) — private void Submit(string kind, string target = "")`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](CoopScreen.cs.md#symbol-b46abec89d85)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-11ae699cefda)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)；`NationalSpire.Coop.CoopCommand.CoopCommand(string, string, string, long, string, string, string, int, string)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.Replied`；`NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopScreen._message`；`NationalSpire.Coop.CoopScreen._pending`；`NationalSpire.Coop.CoopScreen._replySession`；`NationalSpire.Coop.CoopScreen.Render()`；`NationalSpire.Coop.CoopScreen.Replied(NationalSpire.Coop.CoopReply)`；`NationalSpire.Coop.CoopScreen.Session`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCommand.CoopCommand(string, string, string, long, string, string, string, int, string)`；输入表达式：`new(world.Id, world.Epoch, Guid.NewGuid().ToString("N"), world.Revision, kind, target)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pending = new(world.Id, world.Epoch, Guid.NewGuid().ToString("N"), world.Revision, kind, target)`
- `NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`；输入表达式：`Session.Retry(_pending)`；返回值紧邻使用处：`ExpressionStatementSyntax: Session.Retry(_pending);`
- `NationalSpire.Coop.CoopScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ArgumentSyntax: Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**

- `_message` = `e.Message`
- `_message` = `kind == "confirm" ? "已提交准备，等待同步。" : "正在同步。"`
- `_pending` = `new(world.Id, world.Epoch, Guid.NewGuid().ToString("N"), world.Revision, kind, target)`
- `_pending` = `null`
- `_replySession.Replied` -= `Replied`
- `_replySession` = `Session`
- `Session.Replied` += `Replied`

<a id="symbol-9a00bed0ae7c"></a>

## `NationalSpire.Coop.CoopScreen.Replied(NationalSpire.Coop.CoopReply) — private void Replied(CoopReply reply)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCommand.Id`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopOutcome.Accepted`；`NationalSpire.Coop.CoopOutcome.Message`；`NationalSpire.Coop.CoopReply.Id`；`NationalSpire.Coop.CoopReply.Outcome`；`NationalSpire.Coop.CoopScreen._message`；`NationalSpire.Coop.CoopScreen._pending`；`NationalSpire.Coop.CoopScreen.Render()`；`NationalSpire.Coop.CoopScreen.Session`；`NationalSpire.Coop.CoopWorld.Proposal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`

**赋值（含属性/字段和局部值）：**

- `_message` = `reply.Outcome.Accepted ? (Session?.World?.Proposal != null ? "已准备，等待队友。" : "已完成。") : reply.Outcome.Message`
- `_pending` = `null`

<a id="symbol-adc6058122f7"></a>

## `NationalSpire.Coop.CoopScreen.Render() — private void Render()`

来源：源码第 149 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen._Process(double)`](CoopScreen.cs.md#symbol-ac85af6ab46f)；[`NationalSpire.Coop.CoopScreen._Ready()`](CoopScreen.cs.md#symbol-5affb9c9c17f)；[`NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string)`](CoopScreen.cs.md#symbol-af359fd6d523)；[`NationalSpire.Coop.CoopScreen.Entrance()`](CoopScreen.cs.md#symbol-ef98f9c7ba09)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)；[`NationalSpire.Coop.CoopScreen.Replied(NationalSpire.Coop.CoopReply)`](CoopScreen.cs.md#symbol-9a00bed0ae7c)；[`NationalSpire.Coop.CoopScreen.Submit(string, string)`](CoopScreen.cs.md#symbol-9efdcfdc1723)

**调用：** [`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](../CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.Coop.CoopRuntime.Disconnect()`](CoopRuntime.cs.md#symbol-a4550fd42c36)；[`NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`](CoopScreen.cs.md#symbol-806347605946)；[`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`](CoopScreen.cs.md#symbol-eab6cd747232)；[`NationalSpire.Coop.CoopScreen.Entrance()`](CoopScreen.cs.md#symbol-ef98f9c7ba09)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)；[`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`](CoopScreen.cs.md#symbol-2120a3a9f30d)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](CoopScreen.cs.md#symbol-b46abec89d85)；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Linq.Enumerable.Empty<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRuntime.Disconnect()`；`NationalSpire.Coop.CoopScreen._body`；`NationalSpire.Coop.CoopScreen._footer`；`NationalSpire.Coop.CoopScreen._presence`；`NationalSpire.Coop.CoopScreen._revision`；`NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；`NationalSpire.Coop.CoopScreen.Entrance()`；`NationalSpire.Coop.CoopScreen.Render()`；`NationalSpire.Coop.CoopScreen.Runtime`；`NationalSpire.Coop.CoopScreen.Session`；`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`；`NationalSpire.Coop.CoopWorld.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_body)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_body);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_footer)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_footer);`
- `NationalSpire.Coop.CoopRuntime.Disconnect()`；输入表达式：`Runtime.Disconnect()`；返回值紧邻使用处：`ExpressionStatementSyntax: Runtime.Disconnect();`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(sync, "取消加入", () => { Runtime.Disconnect(); Render(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(sync, "取消加入", () => { Runtime.Disconnect(); Render(); });`
- `NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；输入表达式：`Card(_body, "正在同步房间")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card(_body, "正在同步房间")`
- `NationalSpire.Coop.CoopScreen.Entrance()`；输入表达式：`Entrance()`；返回值紧邻使用处：`ExpressionStatementSyntax: Entrance();`
- `NationalSpire.Coop.CoopScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(sync, "等待房主发送队伍和存档信息。首次加入可能需要一点时间。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(sync, "等待房主发送队伍和存档信息。首次加入可能需要一点时间。");`
- `NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`；输入表达式：`WaitingRoom(Session.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: WaitingRoom(Session.World);`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',', Session?.Online.Order() ?? Enumerable.Empty<ulong>())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _presence = string.Join(',', Session?.Online.Order() ?? Enumerable.Empty<ulong>())`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`.Online.Order()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Session?.Online.Order()`
- `System.Linq.Enumerable.Empty<TResult>()`；输入表达式：`Enumerable.Empty<ulong>()`；返回值紧邻使用处：`BinaryExpressionSyntax: Session?.Online.Order() ?? Enumerable.Empty<ulong>()`

**赋值（含属性/字段和局部值）：**

- `_presence` = `string.Join(',', Session?.Online.Order() ?? Enumerable.Empty<ulong>())`
- `_revision` = `Session?.World?.Revision ?? -1`

<a id="symbol-ef98f9c7ba09"></a>

## `NationalSpire.Coop.CoopScreen.Entrance() — private void Entrance()`

来源：源码第 158 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)

**调用：** [`NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`](CoopScreen.cs.md#symbol-806347605946)；[`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`](CoopScreen.cs.md#symbol-eab6cd747232)；[`NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`](CoopScreen.cs.md#symbol-cbbe81fc6508)；[`NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string)`](CoopScreen.cs.md#symbol-af359fd6d523)；[`NationalSpire.Coop.CoopScreen.Input(Godot.Node, string, string)`](CoopScreen.cs.md#symbol-5ca0d288e876)；[`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)；[`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`](CoopScreen.cs.md#symbol-2120a3a9f30d)；[`NationalSpire.Coop.CoopStorage.Delete(string)`](CoopStorage.cs.md#symbol-cf3c1fbdf7f4)；[`NationalSpire.Coop.CoopStorage.List()`](CoopStorage.cs.md#symbol-987dca599488)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](../SeasonCalendar.cs.md#symbol-0f707d2c9895)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.DisplayServer.ClipboardGet()`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.GetItemText(int)`；`Godot.OptionButton.GetSelectedId()`；`Godot.OptionButton.OptionButton()`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.PlayerName`；`NationalSpire.CareerVisuals.Lime`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopScreen._body`；`NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；`NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`；`NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string)`；`NationalSpire.Coop.CoopScreen.Input(Godot.Node, string, string)`；`NationalSpire.Coop.CoopScreen.Render()`；`NationalSpire.Coop.CoopScreen.Session`；`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；`NationalSpire.Coop.CoopSettings.Storage`；`NationalSpire.Coop.CoopStorage.Checkpoint.World`；`NationalSpire.Coop.CoopStorage.Delete(string)`；`NationalSpire.Coop.CoopStorage.List()`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Name`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`choices.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`columns.AddThemeConstantOverride("h_separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddThemeConstantOverride("h_separation", 24);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 14);`
- `Godot.DisplayServer.ClipboardGet()`；输入表达式：`DisplayServer.ClipboardGet()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DisplayServer.ClipboardGet().Trim`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_body.AddChild(columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: _body.AddChild(columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choices.AddChild(count)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddChild(count);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choices.AddChild(country)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddChild(country);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`host.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: host.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`join.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: join.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`saves.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: saves.AddChild(row);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`count.AddItem(n + " 人队伍", n)`；返回值紧邻使用处：`ExpressionStatementSyntax: count.AddItem(n + " 人队伍", n);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`country.AddItem(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: country.AddItem(c);`
- `Godot.OptionButton.GetItemText(int)`；输入表达式：`country.GetItemText(country.Selected)`；返回值紧邻使用处：`ArgumentSyntax: country.GetItemText(country.Selected)`
- `Godot.OptionButton.GetSelectedId()`；输入表达式：`count.GetSelectedId()`；返回值紧邻使用处：`ArgumentSyntax: count.GetSelectedId()`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton()`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(actions, "加入房间", () => Connect(false, name.Text, code: code.Text), 180)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(actions, "加入房间", () => Connect(false, name.Text, code: code.Text), 180);`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(actions, "粘贴邀请码", () => code.Text = DisplayServer.ClipboardGet().Trim(), 190)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(actions, "粘贴邀请码", () => code.Text = DisplayServer.ClipboardGet().Trim(), 190);`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(host, "创建房间并邀请队友", () => Connect(true, name.Text, count.GetSelectedId(), country.GetItemText(country.Selected)), 300)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(host, "创建房间并邀请队友", () => Connect(true, name.Text, count.GetSelectedId(), country.GetItemText(country.Selected)), 300);`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(row, "继续并邀请", () => Connect(true, name.Text, saved: cp.World.Id), 190)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(row, "继续并邀请", () => Connect(true, name.Text, saved: cp.World.Id), 190);`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(row, "删除", () => Confirm("删除多人存档", $"{cp.World.Name} · 第{cp.World.World.Season}赛季第{SeasonCalendar.Day(cp.World.World, cp.World.World.Day)}天\n从列表移除，文件保留在本机备份中。", () =>              {                  if (Session?.World?.Id == cp.World.Id) throw new InvalidOperationException("请先退出这份生涯的房间，再删除存档。");                  CoopSettings.Storage.Delete(cp.World.Id); Render();              }, "删除"), 100)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(row, "删除", () => Confirm("删除多人存档", $"{cp.World.Name} · 第{cp.World.World.Season}赛季第{SeasonCalendar.Day(cp.World.World, cp.World.World.Day)}天\n从列表移除，文件保留在本机备份中。", () =>              {                  if (Session?.World?.Id == cp.World.Id) throw new InvalidOperationException("请先退出这份生涯的房间，再删除存档。");                  CoopSettings.Storage.Delete(cp.World.Id); Render();              }, "删除"), 100);`
- `NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；输入表达式：`Card(_body, "你的选手名字")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card(_body, "你的选手名字")`
- `NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；输入表达式：`Card(_body, "已有多人生涯")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card(_body, "已有多人生涯")`
- `NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；输入表达式：`Card(columns, "创建房间", CareerVisuals.Lime)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card(columns, "创建房间", CareerVisuals.Lime)`
- `NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；输入表达式：`Card(columns, "加入朋友的房间")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card(columns, "加入朋友的房间")`
- `NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`；输入表达式：`Confirm("删除多人存档", $"{cp.World.Name} · 第{cp.World.World.Season}赛季第{SeasonCalendar.Day(cp.World.World, cp.World.World.Day)}天\n从列表移除，文件保留在本机备份中。", () =>              {                  if (Session?.World?.Id == cp.World.Id) throw new InvalidOperationException("请先退出这份生涯的房间，再删除存档。");                  CoopSettings.Storage.Delete(cp.World.Id); Render();              }, "删除")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Confirm("删除多人存档", $"{cp.World.Name} · 第{cp.World.World.Season}赛季第{SeasonCalendar.Day(cp.World.World, cp.World.World.Day)}天\n从列表移除，文件保留在本机备份中。", () =>              {                  if (Session?.World?.Id == cp.World.Id) throw new InvalidOperationException("请先退出这份生涯的房间，再删除存档。");                  CoopSettings.Storage.Delete(cp.World.Id); Render();              }, "删除")`
- `NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string)`；输入表达式：`Connect(false, name.Text, code: code.Text)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Connect(false, name.Text, code: code.Text)`
- `NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string)`；输入表达式：`Connect(true, name.Text, count.GetSelectedId(), country.GetItemText(country.Selected))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Connect(true, name.Text, count.GetSelectedId(), country.GetItemText(country.Selected))`
- `NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string)`；输入表达式：`Connect(true, name.Text, saved: cp.World.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Connect(true, name.Text, saved: cp.World.Id)`
- `NationalSpire.Coop.CoopScreen.Input(Godot.Node, string, string)`；输入表达式：`Input(identity, "进入队伍后显示的名字", CareerEngine.PlayerName)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Input(identity, "进入队伍后显示的名字", CareerEngine.PlayerName)`
- `NationalSpire.Coop.CoopScreen.Input(Godot.Node, string, string)`；输入表达式：`Input(join, "在这里粘贴房间邀请码")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Input(join, "在这里粘贴房间邀请码")`
- `NationalSpire.Coop.CoopScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(host, "创建后邀请朋友，进入生涯安排赛事，开赛时全员准备。", 18, CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(host, "创建后邀请朋友，进入生涯安排赛事，开赛时全员准备。", 18, CareerVisuals.Muted);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(join, "让房主在等待房间中复制邀请码发给你，然后粘贴到这里。", 18, CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(join, "让房主在等待房间中复制邀请码发给你，然后粘贴到这里。", 18, CareerVisuals.Muted);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(row, $"{cp.World.Name} · 第 {cp.World.World.Day} 天 · {cp.World.Members.Count} 位成员", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(row, $"{cp.World.Name} · 第 {cp.World.World.Day} 天 · {cp.World.Members.Count} 位成员", 18);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(saves, "房主重新打开存档后可邀请朋友加入。删除只移除本机这份存档。", 17, CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(saves, "房主重新打开存档后可邀请朋友加入。删除只移除本机这份存档。", 17, CareerVisuals.Muted);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(saves, "尚无多人存档。创建房间后会自动保存。", 18, CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(saves, "尚无多人存档。创建房间后会自动保存。", 18, CareerVisuals.Muted);`
- `NationalSpire.Coop.CoopStorage.Delete(string)`；输入表达式：`CoopSettings.Storage.Delete(cp.World.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopSettings.Storage.Delete(cp.World.Id);`
- `NationalSpire.Coop.CoopStorage.List()`；输入表达式：`CoopSettings.Storage.List()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CoopSettings.Storage.List().ToList`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(cp.World.World, cp.World.World.Day)`；返回值紧邻使用处：`InterpolationSyntax: {SeasonCalendar.Day(cp.World.World, cp.World.World.Day)}`
- `string.Trim()`；输入表达式：`DisplayServer.ClipboardGet().Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: code.Text = DisplayServer.ClipboardGet().Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`checkpoints.OrderByDescending(c => c.World.World.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var cp in checkpoints.OrderByDescending(c => c.World.World.Day))          {              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 14); saves.AddChild(row);              Text(row, $"{cp.World.Name} · 第 {cp.World.World.Day} 天 · {cp.World.Members.Count} 位成员", 18);              Button(row, "继续并邀请", () => Connect(true, name.Text, saved: cp.World.Id), 190);              Button(row, "删除", () => Confirm("删除多人存档", $"{cp.World.Name} · 第{cp.World.World.Season}赛季第{SeasonCalendar.Day(cp.World.World, cp.World.World.Day)}天\n从列表移除，文件保留在本机备份中。", () =>              {                  if (Session?.World?.Id == cp.World.Id) throw new InvalidOperationException("请先退出这份生涯的房间，再删除存档。");                  CoopSettings.Storage.Delete(cp.World.Id); Render();              }, "删除"), 100);          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CoopSettings.Storage.List().ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopSettings.Storage.List().ToList()`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先退出这份生涯的房间，再删除存档。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先退出这份生涯的房间，再删除存档。");`

**赋值（含属性/字段和局部值）：**

- `code.Name` = `"LobbyInviteInput"`
- `code.Text` = `DisplayServer.ClipboardGet().Trim()`
- `Columns` = `2`
- `name.Name` = `"LobbyPlayerName"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-b46abec89d85"></a>

## `NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld) — private void WaitingRoom(CoopWorld world)`

来源：源码第 187 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.Render()`](CoopScreen.cs.md#symbol-adc6058122f7)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](../AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](../CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](../CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`](CoopScreen.cs.md#symbol-806347605946)；[`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`](CoopScreen.cs.md#symbol-eab6cd747232)；[`NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`](CoopScreen.cs.md#symbol-cbbe81fc6508)；[`NationalSpire.Coop.CoopScreen.Input(Godot.Node, string, string)`](CoopScreen.cs.md#symbol-5ca0d288e876)；[`NationalSpire.Coop.CoopScreen.Submit(string, string)`](CoopScreen.cs.md#symbol-9efdcfdc1723)；[`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`](CoopScreen.cs.md#symbol-2120a3a9f30d)；[`NationalSpire.GameBridge.Characters()`](../GameBridge.cs.md#symbol-1233494dda40)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.DisplayServer.ClipboardSet(string)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.CareerAvatar.CareerAvatar()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.RandomCharacterChoice`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Lime`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCoordinator.Full`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopMember.Character`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.RandomCharacter`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopProposal.Id`；`NationalSpire.Coop.CoopProposal.Kind`；`NationalSpire.Coop.CoopProposal.Label`；`NationalSpire.Coop.CoopProposal.Participants`；`NationalSpire.Coop.CoopProposal.Votes`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.Terminal`；`NationalSpire.Coop.CoopRuntime.InviteCode`；`NationalSpire.Coop.CoopScreen._body`；`NationalSpire.Coop.CoopScreen._footer`；`NationalSpire.Coop.CoopScreen._message`；`NationalSpire.Coop.CoopScreen._pending`；`NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；`NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`；`NationalSpire.Coop.CoopScreen.EnterCareer()`；`NationalSpire.Coop.CoopScreen.Input(Godot.Node, string, string)`；`NationalSpire.Coop.CoopScreen.Runtime`；`NationalSpire.Coop.CoopScreen.Session`；`NationalSpire.Coop.CoopScreen.Submit(string, string)`；`NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；`NationalSpire.Coop.CoopWorld.CareerStarted`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Coop.CoopWorld.Proposal`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.GameBridge.Characters()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`code.AddThemeColorOverride("font_uneditable_color", CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: code.AddThemeColorOverride("font_uneditable_color", CareerVisuals.Ink);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`choices.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`members.AddThemeConstantOverride("h_separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: members.AddThemeConstantOverride("h_separation", 20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`members.AddThemeConstantOverride("v_separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: members.AddThemeConstantOverride("v_separation", 20);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`code.AddThemeStyleboxOverride("read_only", CareerVisuals.Box("102b39", "47788a", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: code.AddThemeStyleboxOverride("read_only", CareerVisuals.Box("102b39", "47788a", 8, 14));`
- `Godot.DisplayServer.ClipboardSet(string)`；输入表达式：`DisplayServer.ClipboardSet(Runtime.InviteCode)`；返回值紧邻使用处：`ExpressionStatementSyntax: DisplayServer.ClipboardSet(Runtime.InviteCode);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_body.AddChild(members)`；返回值紧邻使用处：`ExpressionStatementSyntax: _body.AddChild(members);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`invite.AddChild(inviteActions)`；返回值紧邻使用处：`ExpressionStatementSyntax: invite.AddChild(inviteActions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ready.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: ready.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new CareerAvatar { Art = CareerAvatars.ForPerson(world.World, member.PersonId), Identity = AvatarHonors.ForPerson(world.World, member.PersonId), CustomMinimumSize = new(72,72) })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new CareerAvatar { Art = CareerAvatars.ForPerson(world.World, member.PersonId), Identity = AvatarHonors.ForPerson(world.World, member.PersonId), CustomMinimumSize = new(72,72) });`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(72,72)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(72,72)`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`.Title.GetFormattedText()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == characterId)?.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`character.Title.GetFormattedText()`；返回值紧邻使用处：`BinaryExpressionSyntax: (!member.RandomCharacter && member.Character == character.Id.ToString() ? "✓ " : "") + character.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString() == characterId`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`character.Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: character.Id.ToString()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`character.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: member.Character == character.Id.ToString()`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(world.World, member.PersonId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Identity = AvatarHonors.ForPerson(world.World, member.PersonId)`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Art = CareerAvatars.ForPerson(world.World, member.PersonId), Identity = AvatarHonors.ForPerson(world.World, member.PersonId), CustomMinimumSize = new(72,72) }`；返回值紧邻使用处：`ArgumentSyntax: new CareerAvatar { Art = CareerAvatars.ForPerson(world.World, member.PersonId), Identity = AvatarHonors.ForPerson(world.World, member.PersonId), CustomMinimumSize = new(72,72) }`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(world.World, member.PersonId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Art = CareerAvatars.ForPerson(world.World, member.PersonId)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("102b39", "47788a", 8, 14)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("102b39", "47788a", 8, 14)`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(choices, "按当前队伍重赛", () => Submit("restart-run"), 240)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(choices, "按当前队伍重赛", () => Submit("restart-run"), 240);`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(choices, "弃赛", () => Confirm("确认弃赛", "本场记为弃赛，保留生涯成员。", () => Submit("abandon-run")), 110)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(choices, "弃赛", () => Confirm("确认弃赛", "本场记为弃赛，保留生涯成员。", () => Submit("abandon-run")), 110);`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(choices, (!member.RandomCharacter && member.Character == character.Id.ToString() ? "✓ " : "") + character.Title.GetFormattedText(), () => Submit("character", character.Id.ToString()), 180)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(choices, (!member.RandomCharacter && member.Character == character.Id.ToString() ? "✓ " : "") + character.Title.GetFormattedText(), () => Submit("character", character.Id.ToString()), 180);`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(choices, (member.RandomCharacter ? "✓ " : "") + "随机角色", () => Submit("character", CareerEngine.RandomCharacterChoice), 180)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(choices, (member.RandomCharacter ? "✓ " : "") + "随机角色", () => Submit("character", CareerEngine.RandomCharacterChoice), 180);`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(inviteActions, "复制邀请码", () => { DisplayServer.ClipboardSet(Runtime.InviteCode); _message = "邀请码已复制，现在可以发送给朋友。"; }, 210)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(inviteActions, "复制邀请码", () => { DisplayServer.ClipboardSet(Runtime.InviteCode); _message = "邀请码已复制，现在可以发送给朋友。"; }, 210);`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(ready, "继续已保存的比赛", () => Submit("propose-resume"), 300)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(ready, "继续已保存的比赛", () => Submit("propose-resume"), 300)`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(ready, "进入多人生涯", () => Submit("propose-enter"), 300)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(ready, "进入多人生涯", () => Submit("propose-enter"), 300)`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(ready, "进入多人生涯", EnterCareer, 240)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(ready, "进入多人生涯", EnterCareer, 240);`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(ready, "取消这项安排", () => Submit("cancel"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(ready, "取消这项安排", () => Submit("cancel"));`
- `NationalSpire.Coop.CoopScreen.Button(Godot.Node, string, System.Action, int)`；输入表达式：`Button(ready, voted ? "已准备，等待队友" : proposal.Kind == "resume" ? "准备继续比赛" : "准备开赛", () => Submit("confirm", proposal.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(ready, voted ? "已准备，等待队友" : proposal.Kind == "resume" ? "准备继续比赛" : "准备开赛", () => Submit("confirm", proposal.Id))`
- `NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；输入表达式：`Card(_body, "邀请队友", CareerVisuals.Lime)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card(_body, "邀请队友", CareerVisuals.Lime)`
- `NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`；输入表达式：`Card(members, member == null ? "等待队友加入" : member.Name + (member.SteamId == world.Owner ? " · 房主" : "") + (Session!.Online.Contains(member.SteamId) ? " · 在线" : " · 轮换"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card(members, member == null ? "等待队友加入" : member.Name + (member.SteamId == world.Owner ? " · 房主" : "") + (Session!.Online.Contains(member.SteamId) ? " · 在线" : " · 轮换"))`
- `NationalSpire.Coop.CoopScreen.Confirm(string, string, System.Action, string)`；输入表达式：`Confirm("确认弃赛", "本场记为弃赛，保留生涯成员。", () => Submit("abandon-run"))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Confirm("确认弃赛", "本场记为弃赛，保留生涯成员。", () => Submit("abandon-run"))`
- `NationalSpire.Coop.CoopScreen.Input(Godot.Node, string, string)`；输入表达式：`Input(invite, "正在取得邀请码", Runtime.InviteCode)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Input(invite, "正在取得邀请码", Runtime.InviteCode)`
- `NationalSpire.Coop.CoopScreen.Submit(string, string)`；输入表达式：`Submit("abandon-run")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Submit("abandon-run")`
- `NationalSpire.Coop.CoopScreen.Submit(string, string)`；输入表达式：`Submit("cancel")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Submit("cancel")`
- `NationalSpire.Coop.CoopScreen.Submit(string, string)`；输入表达式：`Submit("character", CareerEngine.RandomCharacterChoice)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Submit("character", CareerEngine.RandomCharacterChoice)`
- `NationalSpire.Coop.CoopScreen.Submit(string, string)`；输入表达式：`Submit("character", character.Id.ToString())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Submit("character", character.Id.ToString())`
- `NationalSpire.Coop.CoopScreen.Submit(string, string)`；输入表达式：`Submit("confirm", proposal.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Submit("confirm", proposal.Id)`
- `NationalSpire.Coop.CoopScreen.Submit(string, string)`；输入表达式：`Submit("propose-enter")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Submit("propose-enter")`
- `NationalSpire.Coop.CoopScreen.Submit(string, string)`；输入表达式：`Submit("propose-resume")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Submit("propose-resume")`
- `NationalSpire.Coop.CoopScreen.Submit(string, string)`；输入表达式：`Submit("restart-run")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Submit("restart-run")`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(card, "将邀请码发给朋友，这个位置正在等他。", 18, CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(card, "将邀请码发给朋友，这个位置正在等他。", 18, CareerVisuals.Muted);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(card, "选择你的角色", 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(card, "选择你的角色", 17, CareerVisuals.Teal);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(card, characterId == CareerEngine.RandomCharacterChoice ? "正在准备比赛，随机角色将在开赛时确定。" : "本场角色已保存，继续比赛时自动使用。", 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(card, characterId == CareerEngine.RandomCharacterChoice ? "正在准备比赛，随机角色将在开赛时确定。" : "本场角色已保存，继续比赛时自动使用。", 17, CareerVisuals.Teal);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(invite, world.CareerStarted ? "生涯进度已保留。离线队友可使用下面的邀请码重新加入，无需重复确认进入大厅。" : "房间已经建立。把下面的邀请码发给朋友，对方在“多人模式 → 加入朋友的房间”中粘贴。", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(invite, world.CareerStarted ? "生涯进度已保留。离线队友可使用下面的邀请码重新加入，无需重复确认进入大厅。" : "房间已经建立。把下面的邀请码发给朋友，对方在“多人模式 → 加入朋友的房间”中粘贴。", 18);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(inviteActions, "每次重新打开房间都会生成新的邀请码。", 16, CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(inviteActions, "每次重新打开房间都会生成新的邀请码。", 16, CareerVisuals.Muted);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(ready, !Session!.Full ? "比赛和角色已保存，等待原队友加入后继续。" : "角色沿用本场存档。房主发起继续，全员确认后恢复比赛。", 18, CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(ready, !Session!.Full ? "比赛和角色已保存，等待原队友加入后继续。" : "角色沿用本场存档。房主发起继续，全员确认后恢复比赛。", 18, CareerVisuals.Muted);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(ready, "等待房主发起继续比赛。", 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(ready, "等待房主发起继续比赛。", 17, CareerVisuals.Teal);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(ready, "可直接进入生涯，开赛和恢复比赛时全员准备。", 18, CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(ready, "可直接进入生涯，开赛和恢复比赛时全员准备。", 18, CareerVisuals.Muted);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(ready, "正在完成比赛转场，请稍候。", 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(ready, "正在完成比赛转场，请稍候。", 17, CareerVisuals.Teal);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(ready, proposal.Label)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(ready, proposal.Label);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(ready, string.Join("  /  ", world.Members.Where(m => proposal.Participants.Contains(m.SteamId)).Select(m => m.Name + (proposal.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认"))), 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(ready, string.Join("  /  ", world.Members.Where(m => proposal.Participants.Contains(m.SteamId)).Select(m => m.Name + (proposal.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认"))), 17, CareerVisuals.Teal);`
- `NationalSpire.Coop.CoopScreen.Text(Godot.Node, string, int, Godot.Color?)`；输入表达式：`Text(row, (Session!.Online.Contains(member.SteamId) ? "已连接" : "暂时离线") + " · " + characterName, 19)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(row, (Session!.Online.Contains(member.SteamId) ? "已连接" : "暂时离线") + " · " + characterName, 19);`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var character in GameBridge.Characters())              { Button(choices, (!member.RandomCharacter && member.Character == character.Id.ToString() ? "✓ " : "") + character.Title.GetFormattedText(), () => Submit("character", character.Id.ToString()), 180); }`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("  /  ", world.Members.Where(m => proposal.Participants.Contains(m.SteamId)).Select(m => m.Name + (proposal.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认")))`；返回值紧邻使用处：`ArgumentSyntax: string.Join("  /  ", world.Members.Where(m => proposal.Participants.Contains(m.SteamId)).Select(m => m.Name + (proposal.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认")))`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`proposal.Participants.Contains(m.SteamId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => proposal.Participants.Contains(m.SteamId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`proposal.Votes.Contains(m.SteamId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: proposal.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认"`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`proposal.Votes.Contains(Session!.Self)`；返回值紧邻使用处：`BinaryExpressionSyntax: proposal.Votes.Contains(Session!.Self) || _pending is { Kind: "confirm" } pending && pending.Target == proposal.Id`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`Session!.Online.Contains(m.SteamId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => Session!.Online.Contains(m.SteamId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`Session!.Online.Contains(member.SteamId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Session!.Online.Contains(member.SteamId) ? " · 在线" : " · 轮换"`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`Session!.Online.Contains(member.SteamId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Session!.Online.Contains(member.SteamId) ? "已连接" : "暂时离线"`
- `System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；输入表达式：`displayed.ElementAtOrDefault(i)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = displayed.ElementAtOrDefault(i)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == characterId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == characterId)?.Title.GetFormattedText()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`world.Members.OrderByDescending(m => Session!.Online.Contains(m.SteamId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members.OrderByDescending(m => Session!.Online.Contains(m.SteamId)).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`world.Members.Where(m => proposal.Participants.Contains(m.SteamId)).Select(m => m.Name + (proposal.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认"))`；返回值紧邻使用处：`ArgumentSyntax: world.Members.Where(m => proposal.Participants.Contains(m.SteamId)).Select(m => m.Name + (proposal.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认"))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`world.Members.OrderByDescending(m => Session!.Online.Contains(m.SteamId)).ThenBy(m => m.SteamId != world.Owner).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = world.Members.OrderByDescending(m => Session!.Online.Contains(m.SteamId)).ThenBy(m => m.SteamId != world.Owner).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.Members.Where(m => proposal.Participants.Contains(m.SteamId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members.Where(m => proposal.Participants.Contains(m.SteamId)).Select`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Characters.GetValueOrDefault(member.SteamId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: world.Run?.Characters.GetValueOrDefault(member.SteamId)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`world.Members.OrderByDescending(m => Session!.Online.Contains(m.SteamId)).ThenBy(m => m.SteamId != world.Owner)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members.OrderByDescending(m => Session!.Online.Contains(m.SteamId)).ThenBy(m => m.SteamId != world.Owner).ToList`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(2, displayed.Count)`；返回值紧邻使用处：`BinaryExpressionSyntax: i < Math.Max(2, displayed.Count)`

**赋值（含属性/字段和局部值）：**

- `_message` = `"邀请码已复制，现在可以发送给朋友。"`
- `approve.Disabled` = `voted`
- `Art` = `CareerAvatars.ForPerson(world.World, member.PersonId)`
- `characterName` = `"随机角色 · 开赛时确定"`
- `code.Editable` = `false`
- `code.Name` = `"RoomInviteCode"`
- `Columns` = `2`
- `CustomMinimumSize` = `new(72,72)`
- `enter.Disabled` = `!Session!.Host`
- `Identity` = `AvatarHonors.ForPerson(world.World, member.PersonId)`
- `resume.Disabled` = `!Session.Full || savedRun.Phase != "paused" || savedRun.Terminal != null`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
