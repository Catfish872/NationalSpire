# LiveRaceHud.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`88CA21352F2C55D91786AF21FCB8207CA51C60C52147E020E2F7B79EA867E4A4`。来源：[源码](../../LiveRaceHud.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveRaceHud`、`NationalSpire.LiveRaceHud.Speech`、`NationalSpire.RivalMapOverlay`。

字段、事件及初始值（源码原样）：

```csharp
public event Action<BroadcastUiState>? LayoutChanged;
private Label _status = null!, _title = null!;
private VBoxContainer _details = null!, _speechStack = null!;
private PanelContainer? _chatRequest;
private LiveRequestButton? _chatRespond;
private string _chatRequestKey = "";
private Tween? _chatFade;
public PanelContainer Panel = panel;
public string Topic = topic;
public double Remaining = remaining;
public Tween? Fade;
public bool Expiring;
public string Speaker = speaker, Text = text;
public AvatarArt? Art = art;
public AvatarIdentity? Identity = identity;
public float Travel;
public float Speed = Random.Shared.Next(81, 100) * 1.3f, OffsetY = Random.Shared.Next(-5, 6);
public int Lane;
private readonly List<Speech> _speeches = [];
private Button _toggle = null!;
private Button _mode = null!;
private Control _floating = null!;
private bool _collapsed, _dragging, _resizePending;
private Vector2 _dragStart, _positionStart;
private BroadcastUiState _layout = new();
private const float ExpandedWidth = 326;
private string _raceName = "赛事转播";
private Vector2[] _path = [];
private Vector2? _marker;
private PanelContainer _badge = null!;
private Label _label = null!;
private CareerAvatar _avatar = null!;
private Tween? _move;
private string _signature = "";
```

<a id="symbol-b5a8cd9a2617"></a>

## `NationalSpire.LiveRaceHud._Ready() — public override void _Ready()`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent, Godot.Control)`](LiveRaceHud.cs.md#symbol-ae898db06879)；[`NationalSpire.LiveRaceHud.Label(string, int, Godot.Color)`](LiveRaceHud.cs.md#symbol-7c6c2c54a433)；[`NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`](LiveRaceHud.cs.md#symbol-5f9621b5d769)；[`NationalSpire.LiveRaceHud.RestorePosition()`](LiveRaceHud.cs.md#symbol-f38a179bccac)；[`NationalSpire.LiveRaceHud.SetCollapsed(bool)`](LiveRaceHud.cs.md#symbol-6fc8e2be97ca)；[`NationalSpire.LiveRaceHud.SetMode(bool)`](LiveRaceHud.cs.md#symbol-5b601a6d9f7f)；`Godot.Button.Button()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetParent()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastUiState.BroadcastUiState()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastUiState.Collapsed`；`NationalSpire.BroadcastUiState.Floating`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.CreateTheme()`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.LiveRaceHud._collapsed`；`NationalSpire.LiveRaceHud._details`；`NationalSpire.LiveRaceHud._floating`；`NationalSpire.LiveRaceHud._layout`；`NationalSpire.LiveRaceHud._mode`；`NationalSpire.LiveRaceHud._resizePending`；`NationalSpire.LiveRaceHud._speechStack`；`NationalSpire.LiveRaceHud._status`；`NationalSpire.LiveRaceHud._title`；`NationalSpire.LiveRaceHud._toggle`；`NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent, Godot.Control)`；`NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent)`；`NationalSpire.LiveRaceHud.ExpandedWidth`；`NationalSpire.LiveRaceHud.Label(string, int, Godot.Color)`；`NationalSpire.LiveRaceHud.LayoutChanged`；`NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`；`NationalSpire.LiveRaceHud.RestorePosition()`；`NationalSpire.LiveRaceHud.SetCollapsed(bool)`；`NationalSpire.LiveRaceHud.SetMode(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = "BroadcastMode", Text = "弹幕", TooltipText = "切换为上方弹幕", FocusMode = FocusModeEnum.None, CustomMinimumSize = new(52, 23) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _mode = new Button { Name = "BroadcastMode", Text = "弹幕", TooltipText = "切换为上方弹幕", FocusMode = FocusModeEnum.None, CustomMinimumSize = new(52, 23) }`
- `Godot.Button.Button()`；输入表达式：`new Button { Text = "−", TooltipText = "收起转播", FocusMode = FocusModeEnum.None, CustomMinimumSize = new Vector2(23, 23) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _toggle = new Button { Text = "−", TooltipText = "收起转播", FocusMode = FocusModeEnum.None, CustomMinimumSize = new Vector2(23, 23) }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 3);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_mode.AddThemeFontSizeOverride("font_size", 13)`；返回值紧邻使用处：`ExpressionStatementSyntax: _mode.AddThemeFontSizeOverride("font_size", 13);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_toggle.AddThemeFontSizeOverride("font_size", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: _toggle.AddThemeFontSizeOverride("font_size", 14);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_toggle.AddThemeStyleboxOverride(state, CareerVisuals.Box(state == "normal" ? "172b3500" : "25404a", "426372", 3, 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: _toggle.AddThemeStyleboxOverride(state, CareerVisuals.Box(state == "normal" ? "172b3500" : "25404a", "426372", 3, 2));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("panel", CareerVisuals.Box("10212bdc", "426372", 6, 7))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("panel", CareerVisuals.Box("10212bdc", "426372", 6, 7));`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "NationalSpireFloatingComments", MouseFilter = MouseFilterEnum.Ignore, ClipContents = true, ZIndex = 100, Theme = Theme }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _floating = new Control { Name = "NationalSpireFloatingComments", MouseFilter = MouseFilterEnum.Ignore, ClipContents = true, ZIndex = 100, Theme = Theme }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_floating.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _floating.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.TopLeft)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetAnchorsAndOffsetsPreset(LayoutPreset.TopLeft);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_details.AddChild(_speechStack)`；返回值紧邻使用处：`ExpressionStatementSyntax: _details.AddChild(_speechStack);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_details.AddChild(_status)`；返回值紧邻使用处：`ExpressionStatementSyntax: _details.AddChild(_status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(_details)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(_details);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`GetParent().AddChild(_floating)`；返回值紧邻使用处：`ExpressionStatementSyntax: GetParent().AddChild(_floating);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(_mode)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(_mode);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(_title)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(_title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(_toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(_toggle);`
- `Godot.Node.GetParent()`；输入表达式：`GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (Control)GetParent()`
- `Godot.Node.GetParent()`；输入表达式：`GetParent()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetParent().AddChild`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new Vector2(ExpandedWidth - 14, 0) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _details = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new Vector2(ExpandedWidth - 14, 0) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Visible = false }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _speechStack = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Visible = false }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(23, 23)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(23, 23)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(ExpandedWidth - 14, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _status.CustomMinimumSize = new Vector2(ExpandedWidth - 14, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(ExpandedWidth - 14, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(ExpandedWidth - 14, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(52, 23)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(52, 23)`
- `NationalSpire.BroadcastUiState.BroadcastUiState()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("10212bdc", "426372", 6, 7)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("10212bdc", "426372", 6, 7)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(state == "normal" ? "172b3500" : "25404a", "426372", 3, 2)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(state == "normal" ? "172b3500" : "25404a", "426372", 3, 2)`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme = CareerVisuals.CreateTheme()`
- `NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent, Godot.Control)`；输入表达式：`DragInput(input, _status)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: input => DragInput(input, _status)`
- `NationalSpire.LiveRaceHud.Label(string, int, Godot.Color)`；输入表达式：`Label("⠿  赛事转播", 14, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _title = Label("⠿  赛事转播", 14, CareerVisuals.Teal)`
- `NationalSpire.LiveRaceHud.Label(string, int, Godot.Color)`；输入表达式：`Label("正在连接赛场", 13, CareerVisuals.Ink)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _status = Label("正在连接赛场", 13, CareerVisuals.Ink)`
- `NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`；输入表达式：`Restore(new())`；返回值紧邻使用处：`ExpressionStatementSyntax: Restore(new());`
- `NationalSpire.LiveRaceHud.RestorePosition()`；输入表达式：`RestorePosition()`；返回值紧邻使用处：`ExpressionStatementSyntax: RestorePosition();`
- `NationalSpire.LiveRaceHud.SetCollapsed(bool)`；输入表达式：`SetCollapsed(_layout.Collapsed)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetCollapsed(_layout.Collapsed);`
- `NationalSpire.LiveRaceHud.SetMode(bool)`；输入表达式：`SetMode(!_layout.Floating)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetMode(!_layout.Floating);`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(_layout)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LayoutChanged?.Invoke(_layout)`

**赋值（含属性/字段和局部值）：**

- `_details` = `new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new Vector2(ExpandedWidth - 14, 0) }`
- `_floating` = `new Control { Name = "NationalSpireFloatingComments", MouseFilter = MouseFilterEnum.Ignore, ClipContents = true, ZIndex = 100, Theme = Theme }`
- `_layout.Collapsed` = `!_collapsed`
- `_mode.Pressed` += `() => { SetMode(!_layout.Floating); LayoutChanged?.Invoke(_layout); }`
- `_mode` = `new Button { Name = "BroadcastMode", Text = "弹幕", TooltipText = "切换为上方弹幕", FocusMode = FocusModeEnum.None, CustomMinimumSize = new(52, 23) }`
- `_resizePending` = `true`
- `_speechStack` = `new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Visible = false }`
- `_status.CustomMinimumSize` = `new Vector2(ExpandedWidth - 14, 0)`
- `_status.GuiInput` += `input => DragInput(input, _status)`
- `_status.MouseDefaultCursorShape` = `CursorShape.Move`
- `_status.MouseFilter` = `MouseFilterEnum.Stop`
- `_status.TooltipText` = `"按住拖动转播位置"`
- `_status` = `Label("正在连接赛场", 13, CareerVisuals.Ink)`
- `_title.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `_title.ClipText` = `true`
- `_title.GuiInput` += `DragInput`
- `_title.MouseDefaultCursorShape` = `CursorShape.Move`
- `_title.MouseFilter` = `MouseFilterEnum.Stop`
- `_title.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `_title.TooltipText` = `"按住拖动转播位置"`
- `_title` = `Label("⠿  赛事转播", 14, CareerVisuals.Teal)`
- `_toggle.Pressed` += `() => { _layout.Collapsed = !_collapsed; SetCollapsed(_layout.Collapsed); RestorePosition(); LayoutChanged?.Invoke(_layout); }`
- `_toggle` = `new Button { Text = "−", TooltipText = "收起转播", FocusMode = FocusModeEnum.None, CustomMinimumSize = new Vector2(23, 23) }`
- `((Control)GetParent()).Resized` += `RestorePosition`
- `body.MinimumSizeChanged` += `() => _resizePending = true`
- `ClipContents` = `true`
- `CustomMinimumSize` = `new Vector2(23, 23)`
- `CustomMinimumSize` = `new Vector2(ExpandedWidth - 14, 0)`
- `CustomMinimumSize` = `new(52, 23)`
- `FocusMode` = `FocusModeEnum.None`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"BroadcastMode"`
- `Name` = `"NationalSpireFloatingComments"`
- `Name` = `"NationalSpireLive"`
- `Text` = `"−"`
- `Text` = `"弹幕"`
- `Theme` = `CareerVisuals.CreateTheme()`
- `Theme` = `Theme`
- `TooltipText` = `"切换为上方弹幕"`
- `TooltipText` = `"收起转播"`
- `Visible` = `false`
- `ZIndex` = `100`
- `ZIndex` = `101`

<a id="symbol-7c6c2c54a433"></a>

## `NationalSpire.LiveRaceHud.Label(string, int, Godot.Color) — private static Label Label(string text, int size, Color color)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Ready()`](LiveRaceHud.cs.md#symbol-b5a8cd9a2617)；[`NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`](LiveRaceHud.cs.md#symbol-53c07f0e6874)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("font_color", color)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("font_color", color);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", size);`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = text, AutowrapMode = TextServer.AutowrapMode.WordSmart, MouseFilter = MouseFilterEnum.Ignore, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = text, AutowrapMode = TextServer.AutowrapMode.WordSmart, MouseFilter = MouseFilterEnum.Ignore, SizeFlagsHorizontal = SizeFlags.ExpandFill }`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `text`

<a id="symbol-5f9621b5d769"></a>

## `NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState) — public void Restore(BroadcastUiState layout)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.LiveRaceHud._Ready()`](LiveRaceHud.cs.md#symbol-b5a8cd9a2617)；[`NationalSpire.LiveRunBridge._Ready()`](LiveRunBridge.cs.md#symbol-26fa8bae2af0)

**调用：** [`NationalSpire.LiveRaceHud.RestorePosition()`](LiveRaceHud.cs.md#symbol-f38a179bccac)；[`NationalSpire.LiveRaceHud.SetCollapsed(bool)`](LiveRaceHud.cs.md#symbol-6fc8e2be97ca)；[`NationalSpire.LiveRaceHud.SetMode(bool)`](LiveRaceHud.cs.md#symbol-5b601a6d9f7f)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastUiState.Collapsed`；`NationalSpire.BroadcastUiState.Floating`；`NationalSpire.LiveRaceHud._layout`；`NationalSpire.LiveRaceHud.RestorePosition()`；`NationalSpire.LiveRaceHud.SetCollapsed(bool)`；`NationalSpire.LiveRaceHud.SetMode(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(RestorePosition).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(RestorePosition).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(RestorePosition)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(RestorePosition).CallDeferred`
- `NationalSpire.LiveRaceHud.RestorePosition()`；输入表达式：`RestorePosition()`；返回值紧邻使用处：`ExpressionStatementSyntax: RestorePosition();`
- `NationalSpire.LiveRaceHud.SetCollapsed(bool)`；输入表达式：`SetCollapsed(layout.Collapsed)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetCollapsed(layout.Collapsed);`
- `NationalSpire.LiveRaceHud.SetMode(bool)`；输入表达式：`SetMode(layout.Floating)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetMode(layout.Floating);`

**赋值（含属性/字段和局部值）：**

- `_layout` = `layout`

<a id="symbol-6506caa3c7b2"></a>

## `NationalSpire.LiveRaceHud.Area — private Vector2 Area`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Node.GetParent()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetParent()`；输入表达式：`GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (Control)GetParent()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f38a179bccac"></a>

## `NationalSpire.LiveRaceHud.RestorePosition() — private void RestorePosition()`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Process(double)`](LiveRaceHud.cs.md#symbol-9fbc413ea758)；[`NationalSpire.LiveRaceHud._Ready()`](LiveRaceHud.cs.md#symbol-b5a8cd9a2617)；[`NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`](LiveRaceHud.cs.md#symbol-5f9621b5d769)

**调用：** [`NationalSpire.LiveRaceHud.ClampPosition()`](LiveRaceHud.cs.md#symbol-5c9bc7848750)；[`NationalSpire.LiveRaceHud.FitHeight()`](LiveRaceHud.cs.md#symbol-47c54b7b7d9f)；`Godot.Vector2.Max(Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastUiState.PositionVersion`；`NationalSpire.BroadcastUiState.X`；`NationalSpire.BroadcastUiState.Y`；`NationalSpire.LiveRaceHud._layout`；`NationalSpire.LiveRaceHud.Area`；`NationalSpire.LiveRaceHud.ClampPosition()`；`NationalSpire.LiveRaceHud.FitHeight()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Max(Godot.Vector2)`；输入表达式：`(Area - Size).Max(Vector2.Zero)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (Area - Size).Max(Vector2.Zero)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Area.X * _layout.X, Area.Y * _layout.Y)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _layout.PositionVersion >= 2 ? new Vector2(Area.X * _layout.X, Area.Y * _layout.Y) : new Vector2(room.X * _layout.X, room.Y * _layout.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Math.Max(0, Area.X - Size.X - 18), 90)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _layout.X < 0 ? new Vector2(Math.Max(0, Area.X - Size.X - 18), 90)              : _layout.PositionVersion >= 2 ? new Vector2(Area.X * _layout.X, Area.Y * _layout.Y) : new Vector2(room.X * _layout.X, room.Y * _layout.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(room.X * _layout.X, room.Y * _layout.Y)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _layout.PositionVersion >= 2 ? new Vector2(Area.X * _layout.X, Area.Y * _layout.Y) : new Vector2(room.X * _layout.X, room.Y * _layout.Y)`
- `NationalSpire.LiveRaceHud.ClampPosition()`；输入表达式：`ClampPosition()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClampPosition();`
- `NationalSpire.LiveRaceHud.FitHeight()`；输入表达式：`FitHeight()`；返回值紧邻使用处：`ExpressionStatementSyntax: FitHeight();`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, Area.X - Size.X - 18)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, Area.X - Size.X - 18)`

**赋值（含属性/字段和局部值）：**

- `Position` = `_layout.X < 0 ? new Vector2(Math.Max(0, Area.X - Size.X - 18), 90)              : _layout.PositionVersion >= 2 ? new Vector2(Area.X * _layout.X, Area.Y * _layout.Y) : new Vector2(room.X * _layout.X, room.Y * _layout.Y)`

<a id="symbol-5c9bc7848750"></a>

## `NationalSpire.LiveRaceHud.ClampPosition() — private void ClampPosition()`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Input(Godot.InputEvent)`](LiveRaceHud.cs.md#symbol-498aab07aecc)；[`NationalSpire.LiveRaceHud.RestorePosition()`](LiveRaceHud.cs.md#symbol-f38a179bccac)；[`NationalSpire.LiveRaceHud.SetCollapsed(bool)`](LiveRaceHud.cs.md#symbol-6fc8e2be97ca)

**调用：** `Godot.Vector2.Clamp(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Max(Godot.Vector2)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud.Area`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Clamp(Godot.Vector2, Godot.Vector2)`；输入表达式：`Position.Clamp(Vector2.Zero, (Area - Size).Max(Vector2.Zero))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Position = Position.Clamp(Vector2.Zero, (Area - Size).Max(Vector2.Zero))`
- `Godot.Vector2.Max(Godot.Vector2)`；输入表达式：`(Area - Size).Max(Vector2.Zero)`；返回值紧邻使用处：`ArgumentSyntax: (Area - Size).Max(Vector2.Zero)`

**赋值（含属性/字段和局部值）：**

- `Position` = `Position.Clamp(Vector2.Zero, (Area - Size).Max(Vector2.Zero))`

<a id="symbol-6fc8e2be97ca"></a>

## `NationalSpire.LiveRaceHud.SetCollapsed(bool) — private void SetCollapsed(bool value)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Ready()`](LiveRaceHud.cs.md#symbol-b5a8cd9a2617)；[`NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`](LiveRaceHud.cs.md#symbol-5f9621b5d769)

**调用：** [`NationalSpire.LiveRaceHud.ClampPosition()`](LiveRaceHud.cs.md#symbol-5c9bc7848750)；[`NationalSpire.LiveRaceHud.FitHeight()`](LiveRaceHud.cs.md#symbol-47c54b7b7d9f)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastUiState.Floating`；`NationalSpire.LiveRaceHud._collapsed`；`NationalSpire.LiveRaceHud._details`；`NationalSpire.LiveRaceHud._floating`；`NationalSpire.LiveRaceHud._layout`；`NationalSpire.LiveRaceHud._mode`；`NationalSpire.LiveRaceHud._raceName`；`NationalSpire.LiveRaceHud._title`；`NationalSpire.LiveRaceHud._toggle`；`NationalSpire.LiveRaceHud.ClampPosition()`；`NationalSpire.LiveRaceHud.FitHeight()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { FitHeight(); ClampPosition(); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { FitHeight(); ClampPosition(); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { FitHeight(); ClampPosition(); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { FitHeight(); ClampPosition(); }).CallDeferred`
- `NationalSpire.LiveRaceHud.ClampPosition()`；输入表达式：`ClampPosition()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClampPosition();`
- `NationalSpire.LiveRaceHud.FitHeight()`；输入表达式：`FitHeight()`；返回值紧邻使用处：`ExpressionStatementSyntax: FitHeight();`

**赋值（含属性/字段和局部值）：**

- `_collapsed` = `value`
- `_details.Visible` = `!value`
- `_floating.Visible` = `_layout.Floating && !value`
- `_mode.Visible` = `!value`
- `_title.Text` = `value ? "转播" : "⠿ " + _raceName`
- `_toggle.Text` = `value ? "+" : "−"`
- `_toggle.TooltipText` = `value ? "展开转播" : "收起转播"`

<a id="symbol-e4440860b387"></a>

## `NationalSpire.LiveRaceHud.AddAction(string, System.Action) — public Button AddAction(string title, Action action)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.LiveRunBridge.UpdateDateGameAction(NationalSpire.DateGameState, double)`](LiveDateGame.cs.md#symbol-e4061f52dd90)

**调用：** `Godot.Button.Button()`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud._details`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = title, FocusMode = FocusModeEnum.None }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = title, FocusMode = FocusModeEnum.None }`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", 13)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", 13);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_details.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: _details.AddChild(button);`

**赋值（含属性/字段和局部值）：**

- `FocusMode` = `FocusModeEnum.None`
- `Text` = `title`
- `button.Pressed` += `action`

<a id="symbol-e42d7e040efa"></a>

## `NationalSpire.LiveRaceHud.ShowChatRequest(string, string, string, NationalSpire.AvatarArt, NationalSpire.AvatarIdentity, double, bool, Godot.Button, System.Action) — public Button ShowChatRequest(string key, string speaker, string text, AvatarArt art, AvatarIdentity identity, double remaining, bool accepted, Button below, Action respond)`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateDateGameAction(NationalSpire.DateGameState, double)`](LiveDateGame.cs.md#symbol-e4061f52dd90)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.CreateTween()`；`Godot.Node.GetIndex(bool)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.PanelContainer.PanelContainer()`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；`Godot.VBoxContainer.VBoxContainer()`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.LiveRaceHud.ClearChatRequest()`](LiveRaceHud.cs.md#symbol-c0be666418f2)；[`NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`](LiveRaceHud.cs.md#symbol-53c07f0e6874)；[`NationalSpire.LiveRequestButton.Hold(bool)`](LiveRequestButton.cs.md#symbol-104cb7b7e93b)；[`NationalSpire.LiveRequestButton.LiveRequestButton()`](LiveRequestButton.cs.md#symbol-e8accbc7d310)；[`NationalSpire.LiveRequestButton.Sync(double, bool)`](LiveRequestButton.cs.md#symbol-c1257288a26f)；`System.Action.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.LiveRaceHud.ClearChatRequest()`；`NationalSpire.LiveRaceHud.ExpandedWidth`；`NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`；`NationalSpire.LiveRaceHud._chatFade`；`NationalSpire.LiveRaceHud._chatRequest`；`NationalSpire.LiveRaceHud._chatRequestKey`；`NationalSpire.LiveRaceHud._chatRespond`；`NationalSpire.LiveRaceHud._details`；`NationalSpire.LiveRaceHud._resizePending`；`NationalSpire.LiveRequestButton.Elapsed`；`NationalSpire.LiveRequestButton.Hold(bool)`；`NationalSpire.LiveRequestButton.Sync(double, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`.Hide()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _chatRequest?.Hide()`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new(1, 1, 1, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatRequest.Modulate = new(1, 1, 1, 0)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_chatRequest.AddThemeStyleboxOverride("panel", CareerVisuals.Box("302634e8", "c690ad", 8, 8))`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatRequest.AddThemeStyleboxOverride("panel", CareerVisuals.Box("302634e8", "c690ad", 8, 8));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_chatRequest.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatRequest.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_details.AddChild(_chatRequest)`；返回值紧邻使用处：`ExpressionStatementSyntax: _details.AddChild(_chatRequest);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(_chatRespond)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(_chatRespond);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(speech)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(speech);`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatFade = CreateTween()`
- `Godot.Node.GetIndex(bool)`；输入表达式：`below.GetIndex()`；返回值紧邻使用处：`ArgumentSyntax: below.GetIndex()`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`_details.MoveChild(_chatRequest, below.GetIndex())`；返回值紧邻使用处：`ExpressionStatementSyntax: _details.MoveChild(_chatRequest, below.GetIndex());`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "DateGameChatRequest", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatRequest = new PanelContainer { Name = "DateGameChatRequest", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`_chatFade.TweenProperty(_chatRequest, "modulate:a", 1f, .25)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatFade.TweenProperty(_chatRequest, "modulate:a", 1f, .25);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("302634e8", "c690ad", 8, 8)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("302634e8", "c690ad", 8, 8)`
- `NationalSpire.LiveRaceHud.ClearChatRequest()`；输入表达式：`ClearChatRequest()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearChatRequest();`
- `NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`；输入表达式：`SpeechPanel(speaker, text, "date/request", art, identity, false, ExpandedWidth - 16)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SpeechPanel(speaker, text, "date/request", art, identity, false, ExpandedWidth - 16)`
- `NationalSpire.LiveRequestButton.Hold(bool)`；输入表达式：`_chatRespond!.Hold(accepted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatRespond!.Hold(accepted);`
- `NationalSpire.LiveRequestButton.Hold(bool)`；输入表达式：`_chatRespond.Hold(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatRespond.Hold(true);`
- `NationalSpire.LiveRequestButton.LiveRequestButton()`；输入表达式：`new LiveRequestButton()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatRespond = new LiveRequestButton()`
- `NationalSpire.LiveRequestButton.Sync(double, bool)`；输入表达式：`_chatRespond.Sync(remaining, accepted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatRespond.Sync(remaining, accepted);`
- `System.Action.Invoke()`；输入表达式：`respond()`；返回值紧邻使用处：`ExpressionStatementSyntax: respond();`

**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"DateGameChatRequest"`
- `_chatFade` = `CreateTween()`
- `_chatRequest.Modulate` = `new(1, 1, 1, 0)`
- `_chatRequestKey` = `key`
- `_chatRequest` = `new PanelContainer { Name = "DateGameChatRequest", MouseFilter = MouseFilterEnum.Ignore }`
- `_chatRespond.Elapsed` += `() => { _chatRequest?.Hide(); _resizePending = true; }`
- `_chatRespond.Pressed` += `() => { _chatRespond.Hold(true); respond(); }`
- `_chatRespond` = `new LiveRequestButton()`
- `_resizePending` = `true`
- `speech.Name` = `"DateGameRequestSpeech"`

<a id="symbol-654af1fb17c1"></a>

## `NationalSpire.LiveRaceHud.HoldChatRequest(bool) — public void HoldChatRequest(bool hold)`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.OpenDateGameChat(double)`](LiveDateGame.cs.md#symbol-6383bcf560b6)；[`NationalSpire.LiveRunBridge.ResumeDateRun()`](LiveDateGame.cs.md#symbol-9d0f51bc5495)；[`NationalSpire.LiveRunBridge.UpdateDateGameAction(NationalSpire.DateGameState, double)`](LiveDateGame.cs.md#symbol-e4061f52dd90)

**调用：** [`NationalSpire.LiveRequestButton.Hold(bool)`](LiveRequestButton.cs.md#symbol-104cb7b7e93b)

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud._chatRespond`；`NationalSpire.LiveRequestButton.Hold(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveRequestButton.Hold(bool)`；输入表达式：`.Hold(hold)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _chatRespond?.Hold(hold)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c0be666418f2"></a>

## `NationalSpire.LiveRaceHud.ClearChatRequest() — public void ClearChatRequest()`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud.ShowChatRequest(string, string, string, NationalSpire.AvatarArt, NationalSpire.AvatarIdentity, double, bool, Godot.Button, System.Action)`](LiveRaceHud.cs.md#symbol-e42d7e040efa)；[`NationalSpire.LiveRunBridge.UpdateDateGameAction(NationalSpire.DateGameState, double)`](LiveDateGame.cs.md#symbol-e4061f52dd90)

**调用：** `Godot.Node.GetParent()`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.Tween.Kill()`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud._chatFade`；`NationalSpire.LiveRaceHud._chatRequest`；`NationalSpire.LiveRaceHud._chatRequestKey`；`NationalSpire.LiveRaceHud._chatRespond`；`NationalSpire.LiveRaceHud._resizePending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetParent()`；输入表达式：`_chatRequest.GetParent()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _chatRequest.GetParent()?.RemoveChild(_chatRequest)`
- `Godot.Node.QueueFree()`；输入表达式：`_chatRequest.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatRequest.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`.RemoveChild(_chatRequest)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _chatRequest.GetParent()?.RemoveChild(_chatRequest)`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _chatFade?.Kill()`

**赋值（含属性/字段和局部值）：**

- `_chatFade` = `null`
- `_chatRequestKey` = `""`
- `_chatRequest` = `null`
- `_chatRespond` = `null`
- `_resizePending` = `true`

<a id="symbol-cfd9d62c7d32"></a>

## `NationalSpire.LiveRaceHud.SetRace(string, string, int, int, bool, double) — public void SetRace(string name, string status, int hp, int maxHp, bool otherAct, double seconds)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.LiveRunBridge.RefreshRace(ref bool)`](LiveRunBridge.cs.md#symbol-f03ac37c2ac4)；[`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud._collapsed`；`NationalSpire.LiveRaceHud._raceName`；`NationalSpire.LiveRaceHud._status`；`NationalSpire.LiveRaceHud._title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_raceName` = `name`
- `_status.Text` = `status + $" · 生命 {hp}/{maxHp}" + (otherAct ? " · 不同幕" : "")`
- `_title.Text` = `"⠿ " + name`

<a id="symbol-53c07f0e6874"></a>

## `NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float) — private PanelContainer SpeechPanel(string speaker, string text, string topic, AvatarArt? art, AvatarIdentity? identity, bool floating, float width = ExpandedWidth)`

来源：源码第 127 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`](LiveRaceHud.cs.md#symbol-1fd8ee1cca63)；[`NationalSpire.LiveRaceHud.SetMode(bool)`](LiveRaceHud.cs.md#symbol-5b601a6d9f7f)；[`NationalSpire.LiveRaceHud.ShowChatRequest(string, string, string, NationalSpire.AvatarArt, NationalSpire.AvatarIdentity, double, bool, Godot.Button, System.Action)`](LiveRaceHud.cs.md#symbol-e42d7e040efa)

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CareerAvatar.CareerAvatar()`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.LiveRaceHud.Label(string, int, Godot.Color)`](LiveRaceHud.cs.md#symbol-7c6c2c54a433)；`string.Replace(string, string?)`；`string.StartsWith(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.LiveRaceHud.ExpandedWidth`；`NationalSpire.LiveRaceHud.Label(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("9ddbd0")`；返回值紧邻使用处：`ConditionalExpressionSyntax: audience ? new Color("9ddbd0") : CareerVisuals.Gold`
- `Godot.Color.Color(string)`；输入表达式：`new Color("c4b1f0")`；返回值紧邻使用处：`ConditionalExpressionSyntax: thought ? new Color("c4b1f0") : audience ? new Color("9ddbd0") : CareerVisuals.Gold`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ded3f4")`；返回值紧邻使用处：`ConditionalExpressionSyntax: thought ? new Color("ded3f4") : CareerVisuals.Ink`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`heading.AddThemeConstantOverride("separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddThemeConstantOverride("separation", 6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`words.AddThemeConstantOverride("separation", floating ? 12 : 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddThemeConstantOverride("separation", floating ? 12 : 4);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box(audience ? "18383df5" : thought ? "273149f5" : topic == "rival_dead" || topic == "player_danger" ? "493139f5" : "382d48f5", audience ? "5b9e99" : thought ? "8592b8" : "b99467", 5, 9))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box(audience ? "18383df5" : thought ? "273149f5" : topic == "rival_dead" || topic == "player_danger" ? "493139f5" : "382d48f5", audience ? "5b9e99" : thought ? "8592b8" : "b99467", 5, 9));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ConditionalExpressionSyntax: floating ? new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore } : new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(byline)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(byline);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(new CareerAvatar { Art = art, Identity = identity, CustomMinimumSize = new Vector2(30, 30), SizeFlagsVertical = SizeFlags.ShrinkCenter })`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(new CareerAvatar { Art = art, Identity = identity, CustomMinimumSize = new Vector2(30, 30), SizeFlagsVertical = SizeFlags.ShrinkCenter });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(words)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(words);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(byline)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(byline);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(heading);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ConditionalExpressionSyntax: floating ? new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore } : new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(30, 30)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(30, 30)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(width - 32, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: content.CustomMinimumSize = new Vector2(width - 32, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(width - 74, 0)`；返回值紧邻使用处：`ConditionalExpressionSyntax: floating ? Vector2.Zero : new Vector2(width - 74, 0)`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Art = art, Identity = identity, CustomMinimumSize = new Vector2(30, 30), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`ArgumentSyntax: new CareerAvatar { Art = art, Identity = identity, CustomMinimumSize = new Vector2(30, 30), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(audience ? "18383df5" : thought ? "273149f5" : topic == "rival_dead" || topic == "player_danger" ? "493139f5" : "382d48f5", audience ? "5b9e99" : thought ? "8592b8" : "b99467", 5, 9)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(audience ? "18383df5" : thought ? "273149f5" : topic == "rival_dead" || topic == "player_danger" ? "493139f5" : "382d48f5", audience ? "5b9e99" : thought ? "8592b8" : "b99467", 5, 9)`
- `NationalSpire.LiveRaceHud.Label(string, int, Godot.Color)`；输入表达式：`Label(floating ? text.Replace("\r", "").Replace("\n", " ") : text, 16, thought ? new Color("ded3f4") : CareerVisuals.Ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Label(floating ? text.Replace("\r", "").Replace("\n", " ") : text, 16, thought ? new Color("ded3f4") : CareerVisuals.Ink)`
- `NationalSpire.LiveRaceHud.Label(string, int, Godot.Color)`；输入表达式：`Label(speaker, 13, thought ? new Color("c4b1f0") : audience ? new Color("9ddbd0") : CareerVisuals.Gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Label(speaker, 13, thought ? new Color("c4b1f0") : audience ? new Color("9ddbd0") : CareerVisuals.Gold)`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("\r", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace("\r", "").Replace`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("\r", "").Replace("\n", " ")`；返回值紧邻使用处：`ConditionalExpressionSyntax: floating ? text.Replace("\r", "").Replace("\n", " ") : text`
- `string.StartsWith(string)`；输入表达式：`topic.StartsWith("audience_")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.StartsWith("audience_") || topic.StartsWith("reply_")`
- `string.StartsWith(string)`；输入表达式：`topic.StartsWith("reply_")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.StartsWith("audience_") || topic.StartsWith("reply_")`
- `string.StartsWith(string)`；输入表达式：`topic.StartsWith("thought_")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = topic.StartsWith("thought_")`

**赋值（含属性/字段和局部值）：**

- `Art` = `art`
- `CustomMinimumSize` = `new Vector2(30, 30)`
- `Identity` = `identity`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `byline.AutowrapMode` = `content.AutowrapMode = TextServer.AutowrapMode.Off`
- `byline.CustomMinimumSize` = `content.CustomMinimumSize = Vector2.Zero`
- `byline.CustomMinimumSize` = `content.CustomMinimumSize = new Vector2(width - 32, 0)`
- `byline.CustomMinimumSize` = `floating ? Vector2.Zero : new Vector2(width - 74, 0)`
- `byline.SizeFlagsHorizontal` = `content.SizeFlagsHorizontal = SizeFlags.ShrinkBegin`
- `content.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `content.CustomMinimumSize` = `Vector2.Zero`
- `content.CustomMinimumSize` = `new Vector2(width - 32, 0)`
- `content.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`

<a id="symbol-1fd8ee1cca63"></a>

## `NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?) — public void Say(string speaker, string text, string topic = "", AvatarArt? art = null, AvatarIdentity? identity = null)`

来源：源码第 151 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；[`NationalSpire.LiveRunBridge.OpenDateGameChat(double)`](LiveDateGame.cs.md#symbol-6383bcf560b6)；[`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** `Godot.Color.Color(float, float, float, float)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.CreateTween()`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；[`NationalSpire.LiveRaceHud.PlaceFloating(NationalSpire.LiveRaceHud.Speech)`](LiveRaceHud.cs.md#symbol-31deb6b2cdda)；[`NationalSpire.LiveRaceHud.RemoveSpeech(NationalSpire.LiveRaceHud.Speech)`](LiveRaceHud.cs.md#symbol-3f10f5cce44e)；`NationalSpire.LiveRaceHud.Speech.Speech(Godot.PanelContainer, string, double, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`；[`NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`](LiveRaceHud.cs.md#symbol-53c07f0e6874)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Clamp(double, double, double)`；`System.Random.Next(int)`；`string.StartsWith(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastUiState.Floating`；`NationalSpire.LiveRaceHud.PlaceFloating(NationalSpire.LiveRaceHud.Speech)`；`NationalSpire.LiveRaceHud.RemoveSpeech(NationalSpire.LiveRaceHud.Speech)`；`NationalSpire.LiveRaceHud.Speech.Fade`；`NationalSpire.LiveRaceHud.Speech.Lane`；`NationalSpire.LiveRaceHud.Speech.Topic`；`NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`；`NationalSpire.LiveRaceHud._floating`；`NationalSpire.LiveRaceHud._layout`；`NationalSpire.LiveRaceHud._resizePending`；`NationalSpire.LiveRaceHud._speechStack`；`NationalSpire.LiveRaceHud._speeches`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, .2f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: panel.Modulate = new Color(1, 1, 1, .2f)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`(_layout.Floating ? _floating : _speechStack).AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: (_layout.Floating ? _floating : _speechStack).AddChild(panel);`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.Fade = CreateTween()`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`item.Fade.TweenProperty(panel, "modulate:a", 1f, .18)`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Fade.TweenProperty(panel, "modulate:a", 1f, .18);`
- `NationalSpire.LiveRaceHud.PlaceFloating(NationalSpire.LiveRaceHud.Speech)`；输入表达式：`PlaceFloating(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: PlaceFloating(item);`
- `NationalSpire.LiveRaceHud.RemoveSpeech(NationalSpire.LiveRaceHud.Speech)`；输入表达式：`RemoveSpeech(_speeches.FirstOrDefault(s => s.Topic is not ("rival_dead" or "rival_clear" or "player_champion" or "player_finished")) ?? _speeches[0])`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveSpeech(_speeches.FirstOrDefault(s => s.Topic is not ("rival_dead" or "rival_clear" or "player_champion" or "player_finished")) ?? _speeches[0]);`
- `NationalSpire.LiveRaceHud.RemoveSpeech(NationalSpire.LiveRaceHud.Speech)`；输入表达式：`RemoveSpeech(old)`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveSpeech(old);`
- `NationalSpire.LiveRaceHud.Speech.Speech(Godot.PanelContainer, string, double, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`；输入表达式：`new Speech(panel, topic, Math.Clamp(text.Length * .19 + 5, 14, 21), speaker, text, art, identity)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Speech(panel, topic, Math.Clamp(text.Length * .19 + 5, 14, 21), speaker, text, art, identity)`
- `NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`；输入表达式：`SpeechPanel(speaker, text, topic, art, identity, _layout.Floating)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SpeechPanel(speaker, text, topic, art, identity, _layout.Floating)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_speeches.Any(s => s.Lane == i)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_speeches.Any(s => s.Lane == i)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_speeches.FirstOrDefault(s => s.Topic is not ("rival_dead" or "rival_clear" or "player_champion" or "player_finished"))`；返回值紧邻使用处：`BinaryExpressionSyntax: _speeches.FirstOrDefault(s => s.Topic is not ("rival_dead" or "rival_clear" or "player_champion" or "player_finished")) ?? _speeches[0]`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0, 3).Where(i => !_speeches.Any(s => s.Lane == i)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Enumerable.Range(0, 3).Where(i => !_speeches.Any(s => s.Lane == i)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_speeches.ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var old in _speeches.ToList()) RemoveSpeech(old);`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_speeches.Where(s => s.Topic.StartsWith("rival_") || s.Topic.StartsWith("gap_") || s.Topic.StartsWith("thought_")).ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var old in _speeches.Where(s => s.Topic.StartsWith("rival_") || s.Topic.StartsWith("gap_") || s.Topic.StartsWith("thought_")).ToList()) RemoveSpeech(old);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Enumerable.Range(0, 3).Where(i => !_speeches.Any(s => s.Lane == i))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, 3).Where(i => !_speeches.Any(s => s.Lane == i)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_speeches.Where(s => s.Topic.StartsWith("rival_") || s.Topic.StartsWith("gap_") || s.Topic.StartsWith("thought_"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _speeches.Where(s => s.Topic.StartsWith("rival_") || s.Topic.StartsWith("gap_") || s.Topic.StartsWith("thought_")).ToList`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_speeches.Add(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: _speeches.Add(item);`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, 3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, 3).Where`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(text.Length * .19 + 5, 14, 21)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(text.Length * .19 + 5, 14, 21)`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(lanes.Length)`；返回值紧邻使用处：`ArgumentSyntax: Random.Shared.Next(lanes.Length)`
- `string.StartsWith(string)`；输入表达式：`s.Topic.StartsWith("gap_")`；返回值紧邻使用处：`BinaryExpressionSyntax: s.Topic.StartsWith("rival_") || s.Topic.StartsWith("gap_")`
- `string.StartsWith(string)`；输入表达式：`s.Topic.StartsWith("rival_")`；返回值紧邻使用处：`BinaryExpressionSyntax: s.Topic.StartsWith("rival_") || s.Topic.StartsWith("gap_")`
- `string.StartsWith(string)`；输入表达式：`s.Topic.StartsWith("thought_")`；返回值紧邻使用处：`BinaryExpressionSyntax: s.Topic.StartsWith("rival_") || s.Topic.StartsWith("gap_") || s.Topic.StartsWith("thought_")`

**赋值（含属性/字段和局部值）：**

- `_resizePending` = `true`
- `_speechStack.Visible` = `!_layout.Floating`
- `item.Fade` = `CreateTween()`
- `item.Lane` = `lanes[Random.Shared.Next(lanes.Length)]`
- `panel.Modulate` = `new Color(1, 1, 1, .2f)`

<a id="symbol-5b601a6d9f7f"></a>

## `NationalSpire.LiveRaceHud.SetMode(bool) — private void SetMode(bool floating)`

来源：源码第 169 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Ready()`](LiveRaceHud.cs.md#symbol-b5a8cd9a2617)；[`NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`](LiveRaceHud.cs.md#symbol-5f9621b5d769)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetParent()`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.Tween.Kill()`；[`NationalSpire.LiveRaceHud.PlaceFloating(NationalSpire.LiveRaceHud.Speech)`](LiveRaceHud.cs.md#symbol-31deb6b2cdda)；[`NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`](LiveRaceHud.cs.md#symbol-53c07f0e6874)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastUiState.Floating`；`NationalSpire.LiveRaceHud.PlaceFloating(NationalSpire.LiveRaceHud.Speech)`；`NationalSpire.LiveRaceHud.Speech.Art`；`NationalSpire.LiveRaceHud.Speech.Expiring`；`NationalSpire.LiveRaceHud.Speech.Fade`；`NationalSpire.LiveRaceHud.Speech.Identity`；`NationalSpire.LiveRaceHud.Speech.Panel`；`NationalSpire.LiveRaceHud.Speech.Speaker`；`NationalSpire.LiveRaceHud.Speech.Text`；`NationalSpire.LiveRaceHud.Speech.Topic`；`NationalSpire.LiveRaceHud.Speech.Travel`；`NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`；`NationalSpire.LiveRaceHud._collapsed`；`NationalSpire.LiveRaceHud._floating`；`NationalSpire.LiveRaceHud._layout`；`NationalSpire.LiveRaceHud._mode`；`NationalSpire.LiveRaceHud._resizePending`；`NationalSpire.LiveRaceHud._speechStack`；`NationalSpire.LiveRaceHud._speeches`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`(floating ? _floating : _speechStack).AddChild(item.Panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: (floating ? _floating : _speechStack).AddChild(item.Panel);`
- `Godot.Node.GetParent()`；输入表达式：`item.Panel.GetParent()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: item.Panel.GetParent().RemoveChild`
- `Godot.Node.GetParent()`；输入表达式：`s.Panel.GetParent()`；返回值紧邻使用处：`BinaryExpressionSyntax: s.Panel.GetParent() == _floating`
- `Godot.Node.QueueFree()`；输入表达式：`item.Panel.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Panel.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`item.Panel.GetParent().RemoveChild(item.Panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Panel.GetParent().RemoveChild(item.Panel);`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: item.Fade?.Kill()`
- `NationalSpire.LiveRaceHud.PlaceFloating(NationalSpire.LiveRaceHud.Speech)`；输入表达式：`PlaceFloating(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: PlaceFloating(item);`
- `NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`；输入表达式：`SpeechPanel(item.Speaker, item.Text, item.Topic, item.Art, item.Identity, floating)`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.Panel = SpeechPanel(item.Speaker, item.Text, item.Topic, item.Art, item.Identity, floating)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_speeches.Any(s => (s.Panel.GetParent() == _floating) != floating)`；返回值紧邻使用处：`BinaryExpressionSyntax: _layout.Floating != floating || _speeches.Any(s => (s.Panel.GetParent() == _floating) != floating)`

**赋值（含属性/字段和局部值）：**

- `_floating.Visible` = `floating && !_collapsed`
- `_layout.Floating` = `floating`
- `_mode.Text` = `floating ? "列表" : "弹幕"`
- `_mode.TooltipText` = `floating ? "切换为列表显示" : "切换为上方弹幕"`
- `_resizePending` = `true`
- `_speechStack.Visible` = `!floating && _speeches.Count > 0`
- `item.Expiring` = `false`
- `item.Panel` = `SpeechPanel(item.Speaker, item.Text, item.Topic, item.Art, item.Identity, floating)`
- `item.Travel` = `0`

<a id="symbol-31deb6b2cdda"></a>

## `NationalSpire.LiveRaceHud.PlaceFloating(NationalSpire.LiveRaceHud.Speech) — private void PlaceFloating(Speech item)`

来源：源码第 185 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Process(double)`](LiveRaceHud.cs.md#symbol-9fbc413ea758)；[`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`](LiveRaceHud.cs.md#symbol-1fd8ee1cca63)；[`NationalSpire.LiveRaceHud.SetMode(bool)`](LiveRaceHud.cs.md#symbol-5b601a6d9f7f)

**调用：** `Godot.Control.GetCombinedMinimumSize()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Abs(float)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud._collapsed`；`NationalSpire.LiveRaceHud.Area`；`NationalSpire.LiveRaceHud.Speech.Lane`；`NationalSpire.LiveRaceHud.Speech.OffsetY`；`NationalSpire.LiveRaceHud.Speech.Panel`；`NationalSpire.LiveRaceHud.Speech.Travel`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`item.Panel.GetCombinedMinimumSize()`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.Panel.Size = item.Panel.GetCombinedMinimumSize()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Area.X - item.Travel, top)`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.Panel.Position = new Vector2(Area.X - item.Travel, top)`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(item.OffsetY)`；返回值紧邻使用处：`BinaryExpressionSyntax: Position.Y + Size.Y + 12 + Math.Abs(item.OffsetY)`

**赋值（含属性/字段和局部值）：**

- `item.Panel.Position` = `new Vector2(Area.X - item.Travel, top)`
- `item.Panel.Size` = `item.Panel.GetCombinedMinimumSize()`
- `top` += `58`
- `top` = `Position.Y + Size.Y + 12 + Math.Abs(item.OffsetY)`

<a id="symbol-3f10f5cce44e"></a>

## `NationalSpire.LiveRaceHud.RemoveSpeech(NationalSpire.LiveRaceHud.Speech) — private void RemoveSpeech(Speech item)`

来源：源码第 198 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Process(double)`](LiveRaceHud.cs.md#symbol-9fbc413ea758)；[`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`](LiveRaceHud.cs.md#symbol-1fd8ee1cca63)

**调用：** `Godot.Node.GetParent()`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.Tween.Kill()`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastUiState.Floating`；`NationalSpire.LiveRaceHud._layout`；`NationalSpire.LiveRaceHud._resizePending`；`NationalSpire.LiveRaceHud._speeches`；`NationalSpire.LiveRaceHud._speechStack`；`NationalSpire.LiveRaceHud.Speech.Fade`；`NationalSpire.LiveRaceHud.Speech.Panel`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetParent()`；输入表达式：`item.Panel.GetParent()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: item.Panel.GetParent().RemoveChild`
- `Godot.Node.QueueFree()`；输入表达式：`item.Panel.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Panel.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`item.Panel.GetParent().RemoveChild(item.Panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Panel.GetParent().RemoveChild(item.Panel);`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: item.Fade?.Kill()`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`_speeches.Remove(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: _speeches.Remove(item);`

**赋值（含属性/字段和局部值）：**

- `_resizePending` = `true`
- `_speechStack.Visible` = `!_layout.Floating && _speeches.Count > 0`

<a id="symbol-9fbc413ea758"></a>

## `NationalSpire.LiveRaceHud._Process(double) — public override void _Process(double delta)`

来源：源码第 203 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveRaceHud.PlaceFloating(NationalSpire.LiveRaceHud.Speech)`](LiveRaceHud.cs.md#symbol-31deb6b2cdda)；[`NationalSpire.LiveRaceHud.RemoveSpeech(NationalSpire.LiveRaceHud.Speech)`](LiveRaceHud.cs.md#symbol-3f10f5cce44e)；[`NationalSpire.LiveRaceHud.RestorePosition()`](LiveRaceHud.cs.md#symbol-f38a179bccac)；`Godot.Callable.From(System.Action)`；`Godot.Node.CreateTween()`；`Godot.Tween.Kill()`；`Godot.Tween.TweenCallback(Godot.Callable)`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastUiState.Floating`；`NationalSpire.LiveRaceHud._dragging`；`NationalSpire.LiveRaceHud._layout`；`NationalSpire.LiveRaceHud._resizePending`；`NationalSpire.LiveRaceHud._speeches`；`NationalSpire.LiveRaceHud.PlaceFloating(NationalSpire.LiveRaceHud.Speech)`；`NationalSpire.LiveRaceHud.RemoveSpeech(NationalSpire.LiveRaceHud.Speech)`；`NationalSpire.LiveRaceHud.RestorePosition()`；`NationalSpire.LiveRaceHud.Speech.Expiring`；`NationalSpire.LiveRaceHud.Speech.Fade`；`NationalSpire.LiveRaceHud.Speech.Panel`；`NationalSpire.LiveRaceHud.Speech.Remaining`；`NationalSpire.LiveRaceHud.Speech.Speed`；`NationalSpire.LiveRaceHud.Speech.Travel`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => RemoveSpeech(item))`；返回值紧邻使用处：`ArgumentSyntax: Callable.From(() => RemoveSpeech(item))`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.Fade = CreateTween()`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: item.Fade?.Kill()`
- `Godot.Tween.TweenCallback(Godot.Callable)`；输入表达式：`item.Fade.TweenCallback(Callable.From(() => RemoveSpeech(item)))`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Fade.TweenCallback(Callable.From(() => RemoveSpeech(item)));`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`item.Fade.TweenProperty(item.Panel, "modulate:a", 0f, .25)`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Fade.TweenProperty(item.Panel, "modulate:a", 0f, .25);`
- `NationalSpire.LiveRaceHud.PlaceFloating(NationalSpire.LiveRaceHud.Speech)`；输入表达式：`PlaceFloating(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: PlaceFloating(item);`
- `NationalSpire.LiveRaceHud.RemoveSpeech(NationalSpire.LiveRaceHud.Speech)`；输入表达式：`RemoveSpeech(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveSpeech(item);`
- `NationalSpire.LiveRaceHud.RemoveSpeech(NationalSpire.LiveRaceHud.Speech)`；输入表达式：`RemoveSpeech(item)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => RemoveSpeech(item)`
- `NationalSpire.LiveRaceHud.RestorePosition()`；输入表达式：`RestorePosition()`；返回值紧邻使用处：`ExpressionStatementSyntax: RestorePosition();`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_speeches.ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in _speeches.ToList())          {              if (_layout.Floating)              {                  item.Travel += (float)delta * item.Speed; PlaceFloating(item);                  if (item.Panel.Position.X + item.Panel.Size.X < 0) RemoveSpeech(item);                  continue;              }              item.Remaining -= delta;              if (item.Remaining > 0 || item.Expiring) continue;              item.Expiring = true; item.Fade?.Kill(); item.Fade = CreateTween(); item.Fade.TweenProperty(item.Panel, "modulate:a", 0f, .25);              item.Fade.TweenCallback(Callable.From(() => RemoveSpeech(item)));          }`

**赋值（含属性/字段和局部值）：**

- `_resizePending` = `false`
- `item.Expiring` = `true`
- `item.Fade` = `CreateTween()`
- `item.Remaining` -= `delta`
- `item.Travel` += `(float)delta * item.Speed`

<a id="symbol-5b9229f65deb"></a>

## `NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent) — private void DragInput(InputEvent input)`

来源：源码第 220 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent, Godot.Control)`](LiveRaceHud.cs.md#symbol-ae898db06879)

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud._title`；`NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent, Godot.Control)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent, Godot.Control)`；输入表达式：`DragInput(input, _title)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DragInput(input, _title)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ae898db06879"></a>

## `NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent, Godot.Control) — private void DragInput(InputEvent input, Control surface)`

来源：源码第 221 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Ready()`](LiveRaceHud.cs.md#symbol-b5a8cd9a2617)；[`NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent)`](LiveRaceHud.cs.md#symbol-5b9229f65deb)

**调用：** [`NationalSpire.LiveRaceHud.BeginDrag(Godot.Vector2)`](LiveRaceHud.cs.md#symbol-c419965aa884)；`Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.Control.AcceptEvent()`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud.BeginDrag(Godot.Vector2)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`surface.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`BinaryExpressionSyntax: surface.GetGlobalTransformWithCanvas() * mouse.Position`
- `Godot.Control.AcceptEvent()`；输入表达式：`surface.AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: surface.AcceptEvent();`
- `NationalSpire.LiveRaceHud.BeginDrag(Godot.Vector2)`；输入表达式：`BeginDrag(surface.GetGlobalTransformWithCanvas() * mouse.Position)`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginDrag(surface.GetGlobalTransformWithCanvas() * mouse.Position);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4faa417822ac"></a>

## `NationalSpire.LiveRaceHud.ParentPoint(Godot.Vector2) — private Vector2 ParentPoint(Vector2 viewportPoint)`

来源：源码第 226 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Input(Godot.InputEvent)`](LiveRaceHud.cs.md#symbol-498aab07aecc)；[`NationalSpire.LiveRaceHud.BeginDrag(Godot.Vector2)`](LiveRaceHud.cs.md#symbol-c419965aa884)

**调用：** `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.Node.GetParent()`；`Godot.Transform2D.AffineInverse()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`((Control)GetParent()).GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ((Control)GetParent()).GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.Node.GetParent()`；输入表达式：`GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (Control)GetParent()`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`((Control)GetParent()).GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: ((Control)GetParent()).GetGlobalTransformWithCanvas().AffineInverse() * viewportPoint`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c419965aa884"></a>

## `NationalSpire.LiveRaceHud.BeginDrag(Godot.Vector2) — private void BeginDrag(Vector2 point)`

来源：源码第 227 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Input(Godot.InputEvent)`](LiveRaceHud.cs.md#symbol-498aab07aecc)；[`NationalSpire.LiveRaceHud.DragInput(Godot.InputEvent, Godot.Control)`](LiveRaceHud.cs.md#symbol-ae898db06879)

**调用：** [`NationalSpire.LiveRaceHud.ParentPoint(Godot.Vector2)`](LiveRaceHud.cs.md#symbol-4faa417822ac)

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud._dragging`；`NationalSpire.LiveRaceHud._dragStart`；`NationalSpire.LiveRaceHud._positionStart`；`NationalSpire.LiveRaceHud.ParentPoint(Godot.Vector2)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveRaceHud.ParentPoint(Godot.Vector2)`；输入表达式：`ParentPoint(point)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dragStart = ParentPoint(point)`

**赋值（含属性/字段和局部值）：**

- `_dragging` = `true`
- `_dragStart` = `ParentPoint(point)`
- `_positionStart` = `Position`

<a id="symbol-5de74836267d"></a>

## `NationalSpire.LiveRaceHud.Hit(Godot.Control, Godot.Vector2) — private static bool Hit(Control surface, Vector2 point)`

来源：源码第 228 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Input(Godot.InputEvent)`](LiveRaceHud.cs.md#symbol-498aab07aecc)

**调用：** `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Rect2.HasPoint(Godot.Vector2)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Transform2D.AffineInverse()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`surface.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: surface.GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`surface.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: surface.IsVisibleInTree()          && new Rect2(Vector2.Zero, surface.Size).HasPoint(surface.GetGlobalTransformWithCanvas().AffineInverse() * point)`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, surface.Size).HasPoint(surface.GetGlobalTransformWithCanvas().AffineInverse() * point)`；返回值紧邻使用处：`BinaryExpressionSyntax: surface.IsVisibleInTree()          && new Rect2(Vector2.Zero, surface.Size).HasPoint(surface.GetGlobalTransformWithCanvas().AffineInverse() * point)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, surface.Size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Rect2(Vector2.Zero, surface.Size).HasPoint`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`surface.GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: surface.GetGlobalTransformWithCanvas().AffineInverse() * point`

**赋值（含属性/字段和局部值）：**


<a id="symbol-498aab07aecc"></a>

## `NationalSpire.LiveRaceHud._Input(Godot.InputEvent) — public override void _Input(InputEvent input)`

来源：源码第 230 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveRaceHud.BeginDrag(Godot.Vector2)`](LiveRaceHud.cs.md#symbol-c419965aa884)；[`NationalSpire.LiveRaceHud.ClampPosition()`](LiveRaceHud.cs.md#symbol-5c9bc7848750)；[`NationalSpire.LiveRaceHud.Hit(Godot.Control, Godot.Vector2)`](LiveRaceHud.cs.md#symbol-5de74836267d)；[`NationalSpire.LiveRaceHud.ParentPoint(Godot.Vector2)`](LiveRaceHud.cs.md#symbol-4faa417822ac)；[`NationalSpire.LiveRaceHud.PublishLayout()`](LiveRaceHud.cs.md#symbol-99588bd0f65a)；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Node.GetViewport()`；`Godot.Viewport.SetInputAsHandled()`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud._dragging`；`NationalSpire.LiveRaceHud._dragStart`；`NationalSpire.LiveRaceHud._mode`；`NationalSpire.LiveRaceHud._positionStart`；`NationalSpire.LiveRaceHud._status`；`NationalSpire.LiveRaceHud._title`；`NationalSpire.LiveRaceHud._toggle`；`NationalSpire.LiveRaceHud.BeginDrag(Godot.Vector2)`；`NationalSpire.LiveRaceHud.ClampPosition()`；`NationalSpire.LiveRaceHud.Hit(Godot.Control, Godot.Vector2)`；`NationalSpire.LiveRaceHud.ParentPoint(Godot.Vector2)`；`NationalSpire.LiveRaceHud.PublishLayout()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsVisibleInTree()`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().SetInputAsHandled`
- `Godot.Viewport.SetInputAsHandled()`；输入表达式：`GetViewport().SetInputAsHandled()`；返回值紧邻使用处：`ExpressionStatementSyntax: GetViewport().SetInputAsHandled();`
- `NationalSpire.LiveRaceHud.BeginDrag(Godot.Vector2)`；输入表达式：`BeginDrag(press.Position)`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginDrag(press.Position);`
- `NationalSpire.LiveRaceHud.ClampPosition()`；输入表达式：`ClampPosition()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClampPosition();`
- `NationalSpire.LiveRaceHud.Hit(Godot.Control, Godot.Vector2)`；输入表达式：`Hit(_mode, press.Position)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Hit(_mode, press.Position)`
- `NationalSpire.LiveRaceHud.Hit(Godot.Control, Godot.Vector2)`；输入表达式：`Hit(_status, press.Position)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hit(_title, press.Position) || Hit(_status, press.Position)`
- `NationalSpire.LiveRaceHud.Hit(Godot.Control, Godot.Vector2)`；输入表达式：`Hit(_title, press.Position)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hit(_title, press.Position) || Hit(_status, press.Position)`
- `NationalSpire.LiveRaceHud.Hit(Godot.Control, Godot.Vector2)`；输入表达式：`Hit(_toggle, press.Position)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Hit(_toggle, press.Position)`
- `NationalSpire.LiveRaceHud.ParentPoint(Godot.Vector2)`；输入表达式：`ParentPoint(motion.Position)`；返回值紧邻使用处：`BinaryExpressionSyntax: _positionStart + ParentPoint(motion.Position)`
- `NationalSpire.LiveRaceHud.PublishLayout()`；输入表达式：`PublishLayout()`；返回值紧邻使用处：`ExpressionStatementSyntax: PublishLayout();`

**赋值（含属性/字段和局部值）：**

- `_dragging` = `false`
- `Position` = `_positionStart + ParentPoint(motion.Position) - _dragStart`

<a id="symbol-99588bd0f65a"></a>

## `NationalSpire.LiveRaceHud.PublishLayout() — private void PublishLayout()`

来源：源码第 241 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud._Input(Godot.InputEvent)`](LiveRaceHud.cs.md#symbol-498aab07aecc)

**调用：** `Godot.Vector2.Max(Godot.Vector2)`；`NationalSpire.BroadcastUiState.BroadcastUiState()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Math.Clamp(float, float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastUiState.Collapsed`；`NationalSpire.BroadcastUiState.Floating`；`NationalSpire.BroadcastUiState.PositionVersion`；`NationalSpire.BroadcastUiState.X`；`NationalSpire.BroadcastUiState.Y`；`NationalSpire.LiveRaceHud._collapsed`；`NationalSpire.LiveRaceHud._layout`；`NationalSpire.LiveRaceHud.Area`；`NationalSpire.LiveRaceHud.LayoutChanged`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Max(Godot.Vector2)`；输入表达式：`Area.Max(Vector2.One)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Area.Max(Vector2.One)`
- `NationalSpire.BroadcastUiState.BroadcastUiState()`；输入表达式：`new BroadcastUiState { Floating = _layout.Floating, PositionVersion = 2, Collapsed = _collapsed, X = Math.Clamp(Position.X / area.X, 0, 1), Y = Math.Clamp(Position.Y / area.Y, 0, 1) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _layout = new BroadcastUiState { Floating = _layout.Floating, PositionVersion = 2, Collapsed = _collapsed, X = Math.Clamp(Position.X / area.X, 0, 1), Y = Math.Clamp(Position.Y / area.Y, 0, 1) }`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(_layout)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LayoutChanged?.Invoke(_layout)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(Position.X / area.X, 0, 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: X = Math.Clamp(Position.X / area.X, 0, 1)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(Position.Y / area.Y, 0, 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Y = Math.Clamp(Position.Y / area.Y, 0, 1)`

**赋值（含属性/字段和局部值）：**

- `_layout` = `new BroadcastUiState { Floating = _layout.Floating, PositionVersion = 2, Collapsed = _collapsed, X = Math.Clamp(Position.X / area.X, 0, 1), Y = Math.Clamp(Position.Y / area.Y, 0, 1) }`
- `Collapsed` = `_collapsed`
- `Floating` = `_layout.Floating`
- `PositionVersion` = `2`
- `X` = `Math.Clamp(Position.X / area.X, 0, 1)`
- `Y` = `Math.Clamp(Position.Y / area.Y, 0, 1)`

<a id="symbol-47c54b7b7d9f"></a>

## `NationalSpire.LiveRaceHud.FitHeight() — private void FitHeight()`

来源：源码第 247 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud.RestorePosition()`](LiveRaceHud.cs.md#symbol-f38a179bccac)；[`NationalSpire.LiveRaceHud.SetCollapsed(bool)`](LiveRaceHud.cs.md#symbol-6fc8e2be97ca)

**调用：** `Godot.Control.GetCombinedMinimumSize()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud._collapsed`；`NationalSpire.LiveRaceHud.ExpandedWidth`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetCombinedMinimumSize().Y`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(_collapsed ? 90 : ExpandedWidth, GetCombinedMinimumSize().Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size = new Vector2(_collapsed ? 90 : ExpandedWidth, GetCombinedMinimumSize().Y)`

**赋值（含属性/字段和局部值）：**

- `Size` = `new Vector2(_collapsed ? 90 : ExpandedWidth, GetCombinedMinimumSize().Y)`

<a id="symbol-dc9c29b00bee"></a>

## `NationalSpire.LiveRaceHud._ExitTree() — public override void _ExitTree()`

来源：源码第 248 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.GetParent()`；`Godot.Node.QueueFree()`；`Godot.Tween.Kill()`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRaceHud.RestorePosition()`；`NationalSpire.LiveRaceHud.Speech.Fade`；`NationalSpire.LiveRaceHud._chatFade`；`NationalSpire.LiveRaceHud._floating`；`NationalSpire.LiveRaceHud._speeches`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_floating)`；返回值紧邻使用处：`IfStatementSyntax: if (GodotObject.IsInstanceValid(_floating)) _floating.QueueFree();`
- `Godot.Node.GetParent()`；输入表达式：`GetParent()`；返回值紧邻使用处：`IsPatternExpressionSyntax: GetParent() is Control parent`
- `Godot.Node.QueueFree()`；输入表达式：`_floating.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _floating.QueueFree();`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _chatFade?.Kill()`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: item.Fade?.Kill()`

**赋值（含属性/字段和局部值）：**

- `parent.Resized` -= `RestorePosition`

<a id="symbol-590c9b7cc64b"></a>

## `NationalSpire.RivalMapOverlay.BadgeOffset — public Vector2 BadgeOffset`

来源：源码第 254 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(25, -48)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new(25, -48)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-499c83567d85"></a>

## `NationalSpire.RivalMapOverlay.Identity — public AvatarIdentity? Identity`

来源：源码第 255 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dfc71022ab26"></a>

## `NationalSpire.RivalMapOverlay.Art — public AvatarArt Art`

来源：源码第 256 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(null, CareerVisuals.Teal, "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new(null, CareerVisuals.Teal, "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-71fa48f8cc62"></a>

## `NationalSpire.RivalMapOverlay._Ready() — public override void _Ready()`

来源：源码第 264 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CareerAvatar.CareerAvatar()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.CreateTheme()`；`NationalSpire.RivalMapOverlay._avatar`；`NationalSpire.RivalMapOverlay._badge`；`NationalSpire.RivalMapOverlay._label`；`NationalSpire.RivalMapOverlay.Art`；`NationalSpire.RivalMapOverlay.Identity`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_label.AddThemeFontSizeOverride("font_size", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: _label.AddThemeFontSizeOverride("font_size", 14);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_badge.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10232deb", "70baba", 8, 6))`；返回值紧邻使用处：`ExpressionStatementSyntax: _badge.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10232deb", "70baba", 8, 6));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _label = new Label { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_badge.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: _badge.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_badge)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_badge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(_avatar)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(_avatar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(_label)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(_label);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new Vector2(125, 72) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _badge = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new Vector2(125, 72) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(125, 72)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(125, 72)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(42, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(42, 42)`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Art = Art, Identity = Identity, CustomMinimumSize = new Vector2(42, 42), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _avatar = new CareerAvatar { Art = Art, Identity = Identity, CustomMinimumSize = new Vector2(42, 42), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("10232deb", "70baba", 8, 6)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("10232deb", "70baba", 8, 6)`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme = CareerVisuals.CreateTheme()`

**赋值（含属性/字段和局部值）：**

- `_avatar` = `new CareerAvatar { Art = Art, Identity = Identity, CustomMinimumSize = new Vector2(42, 42), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `_badge` = `new PanelContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new Vector2(125, 72) }`
- `_label` = `new Label { MouseFilter = MouseFilterEnum.Ignore }`
- `Art` = `Art`
- `CustomMinimumSize` = `new Vector2(125, 72)`
- `CustomMinimumSize` = `new Vector2(42, 42)`
- `Identity` = `Identity`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Theme` = `CareerVisuals.CreateTheme()`
- `ZIndex` = `10`

<a id="symbol-6200daa39f4a"></a>

## `NationalSpire.RivalMapOverlay.RefreshArt(NationalSpire.AvatarArt) — public void RefreshArt(AvatarArt art)`

来源：源码第 273 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`](LiveRunBridge.cs.md#symbol-cedfec15a9e5)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatar.Art`；`NationalSpire.RivalMapOverlay._avatar`；`NationalSpire.RivalMapOverlay.Art`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_avatar.Art` = `art`
- `Art` = `art`

<a id="symbol-683532d7c3b5"></a>

## `NationalSpire.RivalMapOverlay.UpdateState(System.Collections.Generic.List<Godot.Vector2>, Godot.Vector2?, string, int, int, bool) — public void UpdateState(List<Vector2> path, Vector2? marker, string name, int hp, int max, bool dead)`

来源：源码第 274 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Map.ActMap, int)`](Coop/CoopLive.cs.md#symbol-3ddf0280ec69)；[`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`](LiveRunBridge.cs.md#symbol-cedfec15a9e5)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.CanvasItem.QueueRedraw()`；`Godot.CanvasItem.Show()`；`Godot.Node.CreateTween()`；`Godot.Tween.Kill()`；`Godot.Tween.SetEase(Godot.Tween.EaseType)`；`Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `NationalSpire.RivalMapOverlay._badge`；`NationalSpire.RivalMapOverlay._label`；`NationalSpire.RivalMapOverlay._marker`；`NationalSpire.RivalMapOverlay._move`；`NationalSpire.RivalMapOverlay._path`；`NationalSpire.RivalMapOverlay._signature`；`NationalSpire.RivalMapOverlay.BadgeOffset`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_badge.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _badge.Hide();`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.CanvasItem.Show()`；输入表达式：`_badge.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _badge.Show();`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetTrans`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _move?.Kill()`
- `Godot.Tween.SetEase(Godot.Tween.EaseType)`；输入表达式：`CreateTween().SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _move = CreateTween().SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out)`
- `Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`CreateTween().SetTrans(Tween.TransitionType.Cubic)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetTrans(Tween.TransitionType.Cubic).SetEase`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`_move.TweenProperty(_badge, "position", destination, .45)`；返回值紧邻使用处：`ExpressionStatementSyntax: _move.TweenProperty(_badge, "position", destination, .45);`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(';', path)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.Join(';', path) + ":"`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`path.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _path = path.ToArray()`

**赋值（含属性/字段和局部值）：**

- `_badge.Position` = `destination`
- `_label.Text` = `name + $"\n{hp}/{max}" + (dead ? " · 已出局" : "")`
- `_marker` = `marker`
- `_move` = `CreateTween().SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out)`
- `_path` = `path.ToArray()`
- `_signature` = `signature`

<a id="symbol-e871a39d95c0"></a>

## `NationalSpire.RivalMapOverlay._Draw() — public override void _Draw()`

来源：源码第 294 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.RivalMapOverlay._path`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(point, 20, 0, Mathf.Tau, 24, new Color("70baba99"), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(point, 20, 0, Mathf.Tau, 24, new Color("70baba99"), 2, true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(_path, new Color("70baba88"), 3, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(_path, new Color("70baba88"), 3, true);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("70baba88")`；返回值紧邻使用处：`ArgumentSyntax: new Color("70baba88")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("70baba99")`；返回值紧邻使用处：`ArgumentSyntax: new Color("70baba99")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0cbc79eeef2f"></a>

## `NationalSpire.RivalMapOverlay._ExitTree() — public override void _ExitTree()`

来源：源码第 299 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Tween.Kill()`

**字段、属性、事件及方法组引用：** `NationalSpire.RivalMapOverlay._move`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _move?.Kill()`

**赋值（含属性/字段和局部值）：**
