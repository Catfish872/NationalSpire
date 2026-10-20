# DateSceneView.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`EDB1D6673C45A0BE76F35DD1E18454E36B99B234AF85EED23BBD8D5A8E84656B`。来源：[源码](../../DateSceneView.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneView`、`NationalSpire.DateChoiceButton`。

字段、事件及初始值（源码原样）：

```csharp
public Action? Advance, Submit, AddAttachment, Settings, Exit, Tick, RetryStop, ReturnToEdit, Regenerate;
public Func<bool>? Blocked;
public Func<string>? HistoryText;
public const double InstantSpeed = 300;
private TextureRect _background = null!, _backgroundPrevious = null!, _sprite = null!;
private ShaderMaterial _backgroundMaterial = null!;
private ShaderMaterial _previousBackgroundMaterial = null!;
private Texture2D? _backgroundTexture, _previousBackgroundTexture, _queuedBackgroundTexture;
private string _backgroundId = "";
private string _queuedBackgroundId = "";
private float _backgroundBlend = 1;
private Control _dialog = null!;
private Control _interface = null!;
private HBoxContainer _navigation = null!;
private float _spriteScale = 1, _spriteX, _spriteY;
private PanelContainer _nameBox = null!;
private Control _favourHost = null!;
private AffectionBadge _favourBadge = null!;
private Label _relationText = null!, _relationDetail = null!;
private int? _lastFavour;
private double _deltaUntil;
private string _favourDelta = "";
private bool _showAffectionBadge = true;
private MarginContainer _margin = null!;
private Gradient _glass = null!;
private PanelContainer _history = null!;
private RichTextLabel _historyText = null!;
private int _historyScrollPending;
private VBoxContainer _body = null!, _composer = null!;
private RichTextLabel _text = null!;
private FontVariation _lineFont = null!, _editorFont = null!, _nameFont = null!, _historyFont = null!;
private readonly Dictionary<(ulong Font, int Size), float> _fontGaps = [];
private Label _name = null!, _hint = null!;
private HBoxContainer _settings = null!;
private ScrollContainer _attachmentScroll = null!;
private double _poll, _typing;
private float _alpha, _targetAlpha, _jump;
private float _jumpDuration = .28f, _jumpHeight = 9;
private float _spriteBaseY;
private bool _hintDismissed, _firstTypeFrame, _layingOut;
private readonly Dictionary<ulong, float> _headRatios = [];
private Button _waitAction = null!, _editFailure = null!;
private static readonly Color Ink = new("eff4f6");
```

<a id="symbol-e3663899b3ff"></a>

## `NationalSpire.DateSceneView.Editor — public TextEdit Editor`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8a0dc7cb8645"></a>

## `NationalSpire.DateSceneView.Attachments — public VBoxContainer Attachments`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d78a2d9d6cc0"></a>

## `NationalSpire.DateSceneView.Send — public Button Send`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d85856d49164"></a>

## `NationalSpire.DateSceneView.Status — public Label Status`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-01943e25d925"></a>

## `NationalSpire.DateSceneView.RegenerateButton — public Button RegenerateButton`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ab4c46aae8fa"></a>

## `NationalSpire.DateSceneView.HistoryOpen — public bool HistoryOpen`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._history`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c60e9e0ce6d0"></a>

## `NationalSpire.DateSceneView.DialogueHidden — public bool DialogueHidden`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._interface`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9900b682d7cd"></a>

## `NationalSpire.DateSceneView.InputMode — public bool InputMode`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-29d6e17b566c"></a>

## `NationalSpire.DateSceneView.TextSpeed — public double TextSpeed`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7da14922fda4"></a>

## `NationalSpire.DateSceneView.AffectionVisibility(bool) — public void AffectionVisibility(bool visible)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Apply()`](DateSceneScreen.cs.md#symbol-42869169eaa3)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)

**调用：** [`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._favourHost`；`NationalSpire.DateSceneView._showAffectionBadge`；`NationalSpire.DateSceneView.Layout()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`

**赋值（含属性/字段和局部值）：**

- `_favourHost.Visible` = `visible`
- `_showAffectionBadge` = `visible`

<a id="symbol-949c1add6c05"></a>

## `NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation) — public void Relationship(PrivateRelation relation)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** [`NationalSpire.AffectionBadge.Bind(NationalSpire.PrivateRelation)`](AffectionVisuals.cs.md#symbol-4ff387bfe107)；`Godot.Time.GetTicksMsec()`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionBadge.Bind(NationalSpire.PrivateRelation)`；`NationalSpire.DateSceneView._deltaUntil`；`NationalSpire.DateSceneView._favourBadge`；`NationalSpire.DateSceneView._favourDelta`；`NationalSpire.DateSceneView._lastFavour`；`NationalSpire.DateSceneView._relationDetail`；`NationalSpire.DateSceneView._relationText`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Impression`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.Relationship`；`NationalSpire.PrivateRelation.SelectedBond`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Time.GetTicksMsec()`；输入表达式：`Time.GetTicksMsec()`；返回值紧邻使用处：`BinaryExpressionSyntax: Time.GetTicksMsec() + 3500`
- `Godot.Time.GetTicksMsec()`；输入表达式：`Time.GetTicksMsec()`；返回值紧邻使用处：`BinaryExpressionSyntax: Time.GetTicksMsec() < _deltaUntil`
- `NationalSpire.AffectionBadge.Bind(NationalSpire.PrivateRelation)`；输入表达式：`_favourBadge.Bind(relation)`；返回值紧邻使用处：`ExpressionStatementSyntax: _favourBadge.Bind(relation);`

**赋值（含属性/字段和局部值）：**

- `_deltaUntil` = `Time.GetTicksMsec() + 3500`
- `_favourDelta` = `$"  {relation.Favour - previous:+0;-0}"`
- `_lastFavour` = `relation.Favour`
- `_relationDetail.Text` = `relation.Impression`
- `_relationText.Text` = `(relation.OathConfirmed ? "誓约" : relation.SelectedBond >= 1 ? "恋人" : relation.Relationship)              + (Time.GetTicksMsec() < _deltaUntil ? _favourDelta : "")`

<a id="symbol-1ed75a76342e"></a>

## `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int) — private Button ActionButton(string text, Action action, string name, int width = 100)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Button.Button()`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = name, Text = text, CustomMinimumSize = new(width, 48), FocusMode = FocusModeEnum.None }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = name, Text = text, CustomMinimumSize = new(width, 48), FocusMode = FocusModeEnum.None }`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("38576b", "99c5ce", 7, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("38576b", "99c5ce", 7, 10));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("243d50", "638698", 7, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("243d50", "638698", 7, 10));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(width, 48)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("243d50", "638698", 7, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("243d50", "638698", 7, 10)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("38576b", "99c5ce", 7, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("38576b", "99c5ce", 7, 10)`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `action`
- `CustomMinimumSize` = `new(width, 48)`
- `FocusMode` = `FocusModeEnum.None`
- `Name` = `name`
- `Text` = `text`

<a id="symbol-db339768c993"></a>

## `NationalSpire.DateSceneView._Ready() — public override void _Ready()`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`](CommunityReplyExpressions.cs.md#symbol-c53b052266e4)；[`NationalSpire.DateSceneAssetStore.ContinueHintDismissed()`](DateSceneAssets.cs.md#symbol-ac5aec527a9d)；[`NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`](DateSceneView.cs.md#symbol-1ed75a76342e)；[`NationalSpire.DateSceneView.CloseHistory()`](DateSceneView.cs.md#symbol-83672fb8ae11)；[`NationalSpire.DateSceneView.OpenHistory()`](DateSceneView.cs.md#symbol-a52c1f416ddc)；[`NationalSpire.DateSceneView.Preferences(int, double, double)`](DateSceneView.cs.md#symbol-878552c24bd8)；[`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`](DateSceneView.cs.md#symbol-32ea38e8c82d)；[`NationalSpire.DateSceneView.ShowWaiting(string, bool)`](DateSceneView.cs.md#symbol-c6c25a66fde3)；[`SpacedFont(Godot.Control, string)`](DateSceneView.cs.md#symbol-e28b8217360a)；`Godot.Button.Button()`；`Godot.Color.Color(float, float, float, float)`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AcceptEvent()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Gradient.Gradient()`；`Godot.GradientTexture2D.GradientTexture2D()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Label.Label()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.PanelContainer.PanelContainer()`；`Godot.RichTextLabel.RichTextLabel()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.Shader.Shader()`；`Godot.ShaderMaterial.ShaderMaterial()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.TextEdit.TextEdit()`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.AffectionBadge.AffectionBadge()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.IEnumerable.OfType<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`；`NationalSpire.DateSceneAssetStore.ContinueHintDismissed()`；`NationalSpire.DateSceneView._attachmentScroll`；`NationalSpire.DateSceneView._background`；`NationalSpire.DateSceneView._backgroundMaterial`；`NationalSpire.DateSceneView._backgroundPrevious`；`NationalSpire.DateSceneView._body`；`NationalSpire.DateSceneView._composer`；`NationalSpire.DateSceneView._dialog`；`NationalSpire.DateSceneView._editFailure`；`NationalSpire.DateSceneView._editorFont`；`NationalSpire.DateSceneView._favourBadge`；`NationalSpire.DateSceneView._favourHost`；`NationalSpire.DateSceneView._glass`；`NationalSpire.DateSceneView._hint`；`NationalSpire.DateSceneView._hintDismissed`；`NationalSpire.DateSceneView._history`；`NationalSpire.DateSceneView._historyFont`；`NationalSpire.DateSceneView._historyText`；`NationalSpire.DateSceneView._interface`；`NationalSpire.DateSceneView._lineFont`；`NationalSpire.DateSceneView._margin`；`NationalSpire.DateSceneView._name`；`NationalSpire.DateSceneView._nameBox`；`NationalSpire.DateSceneView._nameFont`；`NationalSpire.DateSceneView._navigation`；`NationalSpire.DateSceneView._previousBackgroundMaterial`；`NationalSpire.DateSceneView._relationDetail`；`NationalSpire.DateSceneView._relationText`；`NationalSpire.DateSceneView._settings`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView._waitAction`；`NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；`NationalSpire.DateSceneView.AddAttachment`；`NationalSpire.DateSceneView.Attachments`；`NationalSpire.DateSceneView.Click(Godot.InputEvent)`；`NationalSpire.DateSceneView.CloseHistory()`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.Exit`；`NationalSpire.DateSceneView.HistoryOpen`；`NationalSpire.DateSceneView.Ink`；`NationalSpire.DateSceneView.Layout()`；`NationalSpire.DateSceneView.OpenHistory()`；`NationalSpire.DateSceneView.Preferences(int, double, double)`；`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；`NationalSpire.DateSceneView.Regenerate`；`NationalSpire.DateSceneView.RegenerateButton`；`NationalSpire.DateSceneView.RetryStop`；`NationalSpire.DateSceneView.ReturnToEdit`；`NationalSpire.DateSceneView.Send`；`NationalSpire.DateSceneView.Settings`；`NationalSpire.DateSceneView.ShowWaiting(string, bool)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateSceneView.Submit`；`SpacedFont(Godot.Control, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = "DateRelationshipDetails", TooltipText = "查看关系与印象", MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = "DateRelationshipDetails", TooltipText = "查看关系与印象", MouseDefaultCursorShape = CursorShape.PointingHand }`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0,0,0,.75f)`；返回值紧邻使用处：`ExpressionElementSyntax: new Color(0,0,0,.75f)`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0,0,0,0)`；返回值紧邻使用处：`ExpressionElementSyntax: new Color(0,0,0,0)`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0,0,0,1)`；返回值紧邻使用处：`ExpressionElementSyntax: new Color(0,0,0,1)`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new(1,1,1,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Modulate = new(1,1,1,0)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0d1926")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new Color("0d1926")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("172330")`；返回值紧邻使用处：`ArgumentSyntax: new Color("172330")`
- `Godot.Color.Color(string)`；输入表达式：`new("a8bcc8")`；返回值紧邻使用处：`ArgumentSyntax: new("a8bcc8")`
- `Godot.Color.Color(string)`；输入表达式：`new("b3c7cf")`；返回值紧邻使用处：`ArgumentSyntax: new("b3c7cf")`
- `Godot.Color.Color(string)`；输入表达式：`new("c1d1d8")`；返回值紧邻使用处：`ArgumentSyntax: new("c1d1d8")`
- `Godot.Color.Color(string)`；输入表达式：`new("ead09c")`；返回值紧邻使用处：`ArgumentSyntax: new("ead09c")`
- `Godot.Color.Color(string)`；输入表达式：`new("eadce5")`；返回值紧邻使用处：`ArgumentSyntax: new("eadce5")`
- `Godot.Color.Color(string)`；输入表达式：`new("f1ccdf")`；返回值紧邻使用处：`ArgumentSyntax: new("f1ccdf")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Name = "DateBackdrop", Color = new Color("0d1926"), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Name = "DateBackdrop", Color = new Color("0d1926"), MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Control.AcceptEvent()`；输入表达式：`AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: AcceptEvent();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_hint.AddThemeColorOverride("font_color", new("b3c7cf"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _hint.AddThemeColorOverride("font_color", new("b3c7cf"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_historyText.AddThemeColorOverride("default_color", Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: _historyText.AddThemeColorOverride("default_color", Ink);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_name.AddThemeColorOverride("font_color", new("ead09c"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _name.AddThemeColorOverride("font_color", new("ead09c"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_relationDetail.AddThemeColorOverride("font_color", new("eadce5"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _relationDetail.AddThemeColorOverride("font_color", new("eadce5"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_relationText.AddThemeColorOverride("font_color", new("f1ccdf"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _relationText.AddThemeColorOverride("font_color", new("f1ccdf"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_text.AddThemeColorOverride("default_color", Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: _text.AddThemeColorOverride("default_color", Ink);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride(state, Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride(state, Colors.White);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`historyHint.AddThemeColorOverride("font_color", new("a8bcc8"))`；返回值紧邻使用处：`ExpressionStatementSyntax: historyHint.AddThemeColorOverride("font_color", new("a8bcc8"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`historyTitle.AddThemeColorOverride("font_color", new("ead09c"))`；返回值紧邻使用处：`ExpressionStatementSyntax: historyTitle.AddThemeColorOverride("font_color", new("ead09c"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`Send.AddThemeColorOverride("font_color", new Color("172330"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send.AddThemeColorOverride("font_color", new Color("172330"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`Status.AddThemeColorOverride("font_color", new("c1d1d8"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Status.AddThemeColorOverride("font_color", new("c1d1d8"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_body.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: _body.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_composer.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: _composer.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_margin.AddThemeConstantOverride("margin_bottom", 64)`；返回值紧邻使用处：`ExpressionStatementSyntax: _margin.AddThemeConstantOverride("margin_bottom", 64);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_margin.AddThemeConstantOverride("margin_top", 40)`；返回值紧邻使用处：`ExpressionStatementSyntax: _margin.AddThemeConstantOverride("margin_top", 40);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_navigation.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: _navigation.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_relationDetail.AddThemeConstantOverride("outline_size", 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: _relationDetail.AddThemeConstantOverride("outline_size", 5);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_settings.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: _settings.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`historyBody.AddThemeConstantOverride("separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: historyBody.AddThemeConstantOverride("separation", 22);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tools.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_historyText.AddThemeFontSizeOverride("normal_font_size", 27)`；返回值紧邻使用处：`ExpressionStatementSyntax: _historyText.AddThemeFontSizeOverride("normal_font_size", 27);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_name.AddThemeFontSizeOverride("font_size", 31)`；返回值紧邻使用处：`ExpressionStatementSyntax: _name.AddThemeFontSizeOverride("font_size", 31);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_relationText.AddThemeFontSizeOverride("font_size", 19)`；返回值紧邻使用处：`ExpressionStatementSyntax: _relationText.AddThemeFontSizeOverride("font_size", 19);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_text.AddThemeFontSizeOverride("normal_font_size", 30)`；返回值紧邻使用处：`ExpressionStatementSyntax: _text.AddThemeFontSizeOverride("normal_font_size", 30);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`Editor.AddThemeFontSizeOverride("font_size", 30)`；返回值紧邻使用处：`ExpressionStatementSyntax: Editor.AddThemeFontSizeOverride("font_size", 30);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`historyHint.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: historyHint.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`historyTitle.AddThemeFontSizeOverride("font_size", 28)`；返回值紧邻使用处：`ExpressionStatementSyntax: historyTitle.AddThemeFontSizeOverride("font_size", 28);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`Status.AddThemeFontSizeOverride("font_size", 15)`；返回值紧邻使用处：`ExpressionStatementSyntax: Status.AddThemeFontSizeOverride("font_size", 15);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_history.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10202bf5", "547787", 0, 42))`；返回值紧邻使用处：`ExpressionStatementSyntax: _history.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10202bf5", "547787", 0, 42));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_historyText.AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: _historyText.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_nameBox.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172b3dd9", "63869880", 5, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: _nameBox.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172b3dd9", "63869880", 5, 12));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`Editor.AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: Editor.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`Editor.AddThemeStyleboxOverride("normal", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: Editor.AddThemeStyleboxOverride("normal", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`relationButton.AddThemeStyleboxOverride("hover", CareerVisuals.Box("302d42ec", "e5b8cf", 14, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: relationButton.AddThemeStyleboxOverride("hover", CareerVisuals.Box("302d42ec", "e5b8cf", 14, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`relationButton.AddThemeStyleboxOverride("normal", CareerVisuals.Box("182838dc", "b38ba780", 14, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: relationButton.AddThemeStyleboxOverride("normal", CareerVisuals.Box("182838dc", "b38ba780", 14, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`Send.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 7, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 7, 10));`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "DateDialogue", MouseFilter = MouseFilterEnum.Stop }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dialog = new Control { Name = "DateDialogue", MouseFilter = MouseFilterEnum.Stop }`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "DateFavour", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _favourHost = new Control { Name = "DateFavour", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "DateInterface", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _interface = new Control { Name = "DateInterface", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Control.Control()`；输入表达式：`new Control { Position = new(8, 4), Size = new(80, 68), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { Position = new(8, 4), Size = new(80, 68), MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_background.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _background.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_backgroundPrevious.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _backgroundPrevious.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_history.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _history.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_interface.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _interface.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`backdrop.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: backdrop.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`glass.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: glass.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`relationButton.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: relationButton.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Gradient.Gradient()`；输入表达式：`new Gradient { Offsets = [0, .05f, 1], Colors = [new Color(0,0,0,0), new Color(0,0,0,.75f), new Color(0,0,0,1)] }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _glass = new Gradient { Offsets = [0, .05f, 1], Colors = [new Color(0,0,0,0), new Color(0,0,0,.75f), new Color(0,0,0,1)] }`
- `Godot.GradientTexture2D.GradientTexture2D()`；输入表达式：`new GradientTexture2D { Width = 4, Height = 2048, FillFrom = new(.5f, 0), FillTo = new(.5f, 1),              Gradient = _glass }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture = new GradientTexture2D { Width = 4, Height = 2048, FillFrom = new(.5f, 0), FillTo = new(.5f, 1),              Gradient = _glass }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "DateHoverBar", Alignment = BoxContainer.AlignmentMode.Center, MouseFilter = MouseFilterEnum.Stop, Modulate = new(1,1,1,0) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _settings = new HBoxContainer { Name = "DateHoverBar", Alignment = BoxContainer.AlignmentMode.Center, MouseFilter = MouseFilterEnum.Stop, Modulate = new(1,1,1,0) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "DateNavigation" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _navigation = new HBoxContainer { Name = "DateNavigation" }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Label.Label()`；输入表达式：`new Label { Name = "DateAdvanceHint", Text = "单击继续  ›", HorizontalAlignment = HorizontalAlignment.Right, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _hint = new Label { Name = "DateAdvanceHint", Text = "单击继续  ›", HorizontalAlignment = HorizontalAlignment.Right, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label { Name = "DateImpression", Position = new(0, 84), Size = new(280, 0), AutowrapMode = TextServer.AutowrapMode.WordSmart, Visible = false, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _relationDetail = new Label { Name = "DateImpression", Position = new(0, 84), Size = new(280, 0), AutowrapMode = TextServer.AutowrapMode.WordSmart, Visible = false, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label { Name = "DateRelationship", Position = new(96, 23), Size = new(170, 30), TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _relationText = new Label { Name = "DateRelationship", Position = new(96, 23), Size = new(170, 30), TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label { Name = "DateSpeaker", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _name = new Label { Name = "DateSpeaker", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label { Name = "DateStatus", AutowrapMode = TextServer.AutowrapMode.WordSmart, MaxLinesVisible = 2, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Status = new Label { Name = "DateStatus", AutowrapMode = TextServer.AutowrapMode.WordSmart, MaxLinesVisible = 2, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = "对话记录" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = "对话记录" }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = "滚轮 / PageUp / PageDown 浏览 · Q / 右键 / Esc 返回", HorizontalAlignment = HorizontalAlignment.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = "滚轮 / PageUp / PageDown 浏览 · Q / 右键 / Esc 返回", HorizontalAlignment = HorizontalAlignment.Center }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { MouseFilter = MouseFilterEnum.Pass }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _margin = new MarginContainer { MouseFilter = MouseFilterEnum.Pass }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_attachmentScroll.AddChild(Attachments)`；返回值紧邻使用处：`ExpressionStatementSyntax: _attachmentScroll.AddChild(Attachments);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_body.AddChild(_composer)`；返回值紧邻使用处：`ExpressionStatementSyntax: _body.AddChild(_composer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_body.AddChild(_editFailure)`；返回值紧邻使用处：`ExpressionStatementSyntax: _body.AddChild(_editFailure);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_body.AddChild(_hint)`；返回值紧邻使用处：`ExpressionStatementSyntax: _body.AddChild(_hint);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_body.AddChild(_text)`；返回值紧邻使用处：`ExpressionStatementSyntax: _body.AddChild(_text);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_body.AddChild(_waitAction)`；返回值紧邻使用处：`ExpressionStatementSyntax: _body.AddChild(_waitAction);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_body.AddChild(Status)`；返回值紧邻使用处：`ExpressionStatementSyntax: _body.AddChild(Status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_composer.AddChild(_attachmentScroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: _composer.AddChild(_attachmentScroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_composer.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: _composer.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_composer.AddChild(Editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: _composer.AddChild(Editor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_dialog.AddChild(_margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dialog.AddChild(_margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_dialog.AddChild(glass)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dialog.AddChild(glass);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_favourHost.AddChild(_relationDetail)`；返回值紧邻使用处：`ExpressionStatementSyntax: _favourHost.AddChild(_relationDetail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_favourHost.AddChild(_relationText)`；返回值紧邻使用处：`ExpressionStatementSyntax: _favourHost.AddChild(_relationText);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_favourHost.AddChild(badge)`；返回值紧邻使用处：`ExpressionStatementSyntax: _favourHost.AddChild(badge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_favourHost.AddChild(relationButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: _favourHost.AddChild(relationButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_history.AddChild(historyBody)`；返回值紧邻使用处：`ExpressionStatementSyntax: _history.AddChild(historyBody);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_interface.AddChild(_dialog)`；返回值紧邻使用处：`ExpressionStatementSyntax: _interface.AddChild(_dialog);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_interface.AddChild(_favourHost)`；返回值紧邻使用处：`ExpressionStatementSyntax: _interface.AddChild(_favourHost);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_interface.AddChild(_nameBox)`；返回值紧邻使用处：`ExpressionStatementSyntax: _interface.AddChild(_nameBox);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_interface.AddChild(_navigation)`；返回值紧邻使用处：`ExpressionStatementSyntax: _interface.AddChild(_navigation);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_interface.AddChild(_settings)`；返回值紧邻使用处：`ExpressionStatementSyntax: _interface.AddChild(_settings);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_margin.AddChild(_body)`；返回值紧邻使用处：`ExpressionStatementSyntax: _margin.AddChild(_body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_nameBox.AddChild(_name)`；返回值紧邻使用处：`ExpressionStatementSyntax: _nameBox.AddChild(_name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_navigation.AddChild(ActionButton("历史记录  Q", () => { if (HistoryOpen) CloseHistory(); else OpenHistory(); }, "DateHistoryButton", 145))`；返回值紧邻使用处：`ExpressionStatementSyntax: _navigation.AddChild(ActionButton("历史记录  Q", () => { if (HistoryOpen) CloseHistory(); else OpenHistory(); }, "DateHistoryButton", 145));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_navigation.AddChild(ActionButton("退出约会  Esc", () => Exit?.Invoke(), "DateExit", 155))`；返回值紧邻使用处：`ExpressionStatementSyntax: _navigation.AddChild(ActionButton("退出约会  Esc", () => Exit?.Invoke(), "DateExit", 155));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_settings.AddChild(ActionButton("场景设置", () => Settings?.Invoke(), "DateSettings", 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: _settings.AddChild(ActionButton("场景设置", () => Settings?.Invoke(), "DateSettings", 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_settings.AddChild(RegenerateButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: _settings.AddChild(RegenerateButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Send)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Send);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(tools)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(tools);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_background)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_background);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_backgroundPrevious)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_backgroundPrevious);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_history)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_history);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_interface)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_interface);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_sprite)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_sprite);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(backdrop)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(backdrop);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`badge.AddChild(_favourBadge)`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.AddChild(_favourBadge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`historyBody.AddChild(_historyText)`；返回值紧邻使用处：`ExpressionStatementSyntax: historyBody.AddChild(_historyText);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`historyBody.AddChild(historyHint)`；返回值紧邻使用处：`ExpressionStatementSyntax: historyBody.AddChild(historyHint);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`historyBody.AddChild(historyTitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: historyBody.AddChild(historyTitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(ActionButton("+", () => AddAttachment?.Invoke(), "DateAttachments", 48))`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddChild(ActionButton("+", () => AddAttachment?.Invoke(), "DateAttachments", 48));`
- `Godot.Node.GetChildren(bool)`；输入表达式：`_settings.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _settings.GetChildren().OfType<Button>`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "DateHistory", Visible = false, MouseFilter = MouseFilterEnum.Stop }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _history = new PanelContainer { Name = "DateHistory", Visible = false, MouseFilter = MouseFilterEnum.Stop }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "DateSpeakerBox", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _nameBox = new PanelContainer { Name = "DateSpeakerBox", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.RichTextLabel.RichTextLabel()`；输入表达式：`new RichTextLabel { Name = "DateHistoryText", BbcodeEnabled = false, ScrollActive = true, SizeFlagsVertical = SizeFlags.ExpandFill, SelectionEnabled = true, FocusMode = FocusModeEnum.All }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _historyText = new RichTextLabel { Name = "DateHistoryText", BbcodeEnabled = false, ScrollActive = true, SizeFlagsVertical = SizeFlags.ExpandFill, SelectionEnabled = true, FocusMode = FocusModeEnum.All }`
- `Godot.RichTextLabel.RichTextLabel()`；输入表达式：`new RichTextLabel { Name = "DateLine", BbcodeEnabled = false, ScrollActive = true, SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Pass,              VisibleCharactersBehavior = TextServer.VisibleCharactersBehavior.GlyphsLtr }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _text = new RichTextLabel { Name = "DateLine", BbcodeEnabled = false, ScrollActive = true, SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Pass,              VisibleCharactersBehavior = TextServer.VisibleCharactersBehavior.GlyphsLtr }`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { Visible = false, CustomMinimumSize = new(0, 80), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _attachmentScroll = new ScrollContainer { Visible = false, CustomMinimumSize = new(0, 80), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.Shader.Shader()`；输入表达式：`new Shader { Code = """              shader_type canvas_item;              uniform bool blur_on = true;              uniform float blur_radius = 3.0;              uniform float fade_alpha = 1.0;              void fragment() {                  // Pyramid levels prefilter every pixel; tent reconstruction smooths level transitions.                  vec4 original = textureLod(TEXTURE, UV, 0.0);                  vec4 color = original;                  if (blur_on && blur_radius > 0.0) {                      float level = log2(max(1.0, blur_radius));                      vec2 step_uv = TEXTURE_PIXEL_SIZE * max(1.0, blur_radius) * 0.65;                      vec4 sum = vec4(0.0);                      for (int x=-1; x<=1; x++) { for (int y=-1; y<=1; y++) {                          float weight = (x==0 ? 2.0 : 1.0) * (y==0 ? 2.0 : 1.0);                          sum += textureLod(TEXTURE, clamp(UV+vec2(float(x),float(y))*step_uv,vec2(0.0),vec2(1.0)), level) * weight;                      }}                      color = mix(original, sum / 16.0, min(1.0, blur_radius));                  }                  COLOR=vec4(color.rgb,color.a*fade_alpha);              }              """ }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Shader = new Shader { Code = """              shader_type canvas_item;              uniform bool blur_on = true;              uniform float blur_radius = 3.0;              uniform float fade_alpha = 1.0;              void fragment() {                  // Pyramid levels prefilter every pixel; tent reconstruction smooths level transitions.                  vec4 original = textureLod(TEXTURE, UV, 0.0);                  vec4 color = original;                  if (blur_on && blur_radius > 0.0) {                      float level = log2(max(1.0, blur_radius));                      vec2 step_uv = TEXTURE_PIXEL_SIZE * max(1.0, blur_radius) * 0.65;                      vec4 sum = vec4(0.0);                      for (int x=-1; x<=1; x++) { for (int y=-1; y<=1; y++) {                          float weight = (x==0 ? 2.0 : 1.0) * (y==0 ? 2.0 : 1.0);                          sum += textureLod(TEXTURE, clamp(UV+vec2(float(x),float(y))*step_uv,vec2(0.0),vec2(1.0)), level) * weight;                      }}                      color = mix(original, sum / 16.0, min(1.0, blur_radius));                  }                  COLOR=vec4(color.rgb,color.a*fade_alpha);              }              """ }`
- `Godot.ShaderMaterial.ShaderMaterial()`；输入表达式：`new ShaderMaterial { Shader = _backgroundMaterial.Shader }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _previousBackgroundMaterial = new ShaderMaterial { Shader = _backgroundMaterial.Shader }`
- `Godot.ShaderMaterial.ShaderMaterial()`；输入表达式：`new ShaderMaterial { Shader = new Shader { Code = """              shader_type canvas_item;              uniform bool blur_on = true;              uniform float blur_radius = 3.0;              uniform float fade_alpha = 1.0;              void fragment() {                  // Pyramid levels prefilter every pixel; tent reconstruction smooths level transitions.                  vec4 original = textureLod(TEXTURE, UV, 0.0);                  vec4 color = original;                  if (blur_on && blur_radius > 0.0) {                      float level = log2(max(1.0, blur_radius));                      vec2 step_uv = TEXTURE_PIXEL_SIZE * max(1.0, blur_radius) * 0.65;                      vec4 sum = vec4(0.0);                      for (int x=-1; x<=1; x++) { for (int y=-1; y<=1; y++) {                          float weight = (x==0 ? 2.0 : 1.0) * (y==0 ? 2.0 : 1.0);                          sum += textureLod(TEXTURE, clamp(UV+vec2(float(x),float(y))*step_uv,vec2(0.0),vec2(1.0)), level) * weight;                      }}                      color = mix(original, sum / 16.0, min(1.0, blur_radius));                  }                  COLOR=vec4(color.rgb,color.a*fade_alpha);              }              """ } }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _backgroundMaterial = new ShaderMaterial { Shader = new Shader { Code = """              shader_type canvas_item;              uniform bool blur_on = true;              uniform float blur_radius = 3.0;              uniform float fade_alpha = 1.0;              void fragment() {                  // Pyramid levels prefilter every pixel; tent reconstruction smooths level transitions.                  vec4 original = textureLod(TEXTURE, UV, 0.0);                  vec4 color = original;                  if (blur_on && blur_radius > 0.0) {                      float level = log2(max(1.0, blur_radius));                      vec2 step_uv = TEXTURE_PIXEL_SIZE * max(1.0, blur_radius) * 0.65;                      vec4 sum = vec4(0.0);                      for (int x=-1; x<=1; x++) { for (int y=-1; y<=1; y++) {                          float weight = (x==0 ? 2.0 : 1.0) * (y==0 ? 2.0 : 1.0);                          sum += textureLod(TEXTURE, clamp(UV+vec2(float(x),float(y))*step_uv,vec2(0.0),vec2(1.0)), level) * weight;                      }}                      color = mix(original, sum / 16.0, min(1.0, blur_radius));                  }                  COLOR=vec4(color.rgb,color.a*fade_alpha);              }              """ } }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "DateInput", PlaceholderText = "输入回应…", SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 65), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Editor = new TextEdit { Name = "DateInput", PlaceholderText = "输入回应…", SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 65), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _background = new TextureRect { ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Name = "DateGlass", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, Texture = new GradientTexture2D { Width = 4, Height = 2048, FillFrom = new(.5f, 0), FillTo = new(.5f, 1),              Gradient = _glass }, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextureRect { Name = "DateGlass", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, Texture = new GradientTexture2D { Width = 4, Height = 2048, FillFrom = new(.5f, 0), FillTo = new(.5f, 1),              Gradient = _glass }, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Name = "DatePreviousBackground", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _backgroundPrevious = new TextureRect { Name = "DatePreviousBackground", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Name = "DateSprite", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sprite = new TextureRect { Name = "DateSprite", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Pass }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _body = new VBoxContainer { MouseFilter = MouseFilterEnum.Pass }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Attachments = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _composer = new VBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(.5f, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: FillFrom = new(.5f, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(.5f, 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: FillTo = new(.5f, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 65)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 65)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 80)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 80)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 84)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Position = new(0, 84)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(170, 30)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size = new(170, 30)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(280, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size = new(280, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(8, 4)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Position = new(8, 4)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(80, 68)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size = new(80, 68)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(96, 23)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Position = new(96, 23)`
- `NationalSpire.AffectionBadge.AffectionBadge()`；输入表达式：`new AffectionBadge()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _favourBadge = new AffectionBadge()`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("10202bf5", "547787", 0, 42)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("10202bf5", "547787", 0, 42)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172b3dd9", "63869880", 5, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("172b3dd9", "63869880", 5, 12)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("182838dc", "b38ba780", 14, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("182838dc", "b38ba780", 14, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("302d42ec", "e5b8cf", 14, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("302d42ec", "e5b8cf", 14, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("d9bd7e", "f0dca7", 7, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("d9bd7e", "f0dca7", 7, 10)`
- `NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`；输入表达式：`CommunityReplyExpressions.Attach(Editor, _composer, tools, actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityReplyExpressions.Attach(Editor, _composer, tools, actions);`
- `NationalSpire.DateSceneAssetStore.ContinueHintDismissed()`；输入表达式：`DateSceneAssetStore.ContinueHintDismissed()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _hintDismissed = DateSceneAssetStore.ContinueHintDismissed()`
- `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；输入表达式：`ActionButton("+", () => AddAttachment?.Invoke(), "DateAttachments", 48)`；返回值紧邻使用处：`ArgumentSyntax: ActionButton("+", () => AddAttachment?.Invoke(), "DateAttachments", 48)`
- `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；输入表达式：`ActionButton("编辑文字", () => ReturnToEdit?.Invoke(), "DateFailureEdit", 150)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _editFailure = ActionButton("编辑文字", () => ReturnToEdit?.Invoke(), "DateFailureEdit", 150)`
- `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；输入表达式：`ActionButton("场景设置", () => Settings?.Invoke(), "DateSettings", 140)`；返回值紧邻使用处：`ArgumentSyntax: ActionButton("场景设置", () => Settings?.Invoke(), "DateSettings", 140)`
- `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；输入表达式：`ActionButton("发送", () => Submit?.Invoke(), "DateSend", 150)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Send = ActionButton("发送", () => Submit?.Invoke(), "DateSend", 150)`
- `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；输入表达式：`ActionButton("历史记录  Q", () => { if (HistoryOpen) CloseHistory(); else OpenHistory(); }, "DateHistoryButton", 145)`；返回值紧邻使用处：`ArgumentSyntax: ActionButton("历史记录  Q", () => { if (HistoryOpen) CloseHistory(); else OpenHistory(); }, "DateHistoryButton", 145)`
- `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；输入表达式：`ActionButton("停止生成", () => RetryStop?.Invoke(), "DateWaitAction", 150)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _waitAction = ActionButton("停止生成", () => RetryStop?.Invoke(), "DateWaitAction", 150)`
- `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；输入表达式：`ActionButton("退出约会  Esc", () => Exit?.Invoke(), "DateExit", 155)`；返回值紧邻使用处：`ArgumentSyntax: ActionButton("退出约会  Esc", () => Exit?.Invoke(), "DateExit", 155)`
- `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；输入表达式：`ActionButton("重新生成", () => Regenerate?.Invoke(), "DateRegenerate", 140)`；返回值紧邻使用处：`AssignmentExpressionSyntax: RegenerateButton = ActionButton("重新生成", () => Regenerate?.Invoke(), "DateRegenerate", 140)`
- `NationalSpire.DateSceneView.CloseHistory()`；输入表达式：`CloseHistory()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseHistory();`
- `NationalSpire.DateSceneView.OpenHistory()`；输入表达式：`OpenHistory()`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenHistory();`
- `NationalSpire.DateSceneView.Preferences(int, double, double)`；输入表达式：`Preferences(1, 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: Preferences(1, 0);`
- `NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；输入表达式：`Presentation(1, 0, 0, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Presentation(1, 0, 0, true);`
- `NationalSpire.DateSceneView.ShowWaiting(string, bool)`；输入表达式：`ShowWaiting("正在准备场景…")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowWaiting("正在准备场景…");`
- `SpacedFont(Godot.Control, string)`；输入表达式：`SpacedFont(_historyText, "normal_font")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _historyFont = SpacedFont(_historyText, "normal_font")`
- `SpacedFont(Godot.Control, string)`；输入表达式：`SpacedFont(_name, "font")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _nameFont = SpacedFont(_name, "font")`
- `SpacedFont(Godot.Control, string)`；输入表达式：`SpacedFont(_text, "normal_font")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _lineFont = SpacedFont(_text, "normal_font")`
- `SpacedFont(Godot.Control, string)`；输入表达式：`SpacedFont(Editor, "font")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _editorFont = SpacedFont(Editor, "font")`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AddAttachment?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Exit?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Regenerate?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RetryStop?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ReturnToEdit?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Settings?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Submit?.Invoke()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`_settings.GetChildren().OfType<Button>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var button in _settings.GetChildren().OfType<Button>())          {              foreach (string state in new[] { "normal", "hover", "pressed", "focus", "disabled" }) button.AddThemeStyleboxOverride(state, new StyleBoxEmpty());              foreach (string state in new[] { "font_color", "font_hover_color", "font_pressed_color", "font_focus_color" }) button.AddThemeColorOverride(state, Colors.White);          }`

**赋值（含属性/字段和局部值）：**

- `_attachmentScroll` = `new ScrollContainer { Visible = false, CustomMinimumSize = new(0, 80), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `_background.Material` = `_backgroundMaterial`
- `_background.TextureFilter` = `TextureFilterEnum.LinearWithMipmaps`
- `_background` = `new TextureRect { ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore }`
- `_backgroundMaterial` = `new ShaderMaterial { Shader = new Shader { Code = """              shader_type canvas_item;              uniform bool blur_on = true;              uniform float blur_radius = 3.0;              uniform float fade_alpha = 1.0;              void fragment() {                  // Pyramid levels prefilter every pixel; tent reconstruction smooths level transitions.                  vec4 original = textureLod(TEXTURE, UV, 0.0);                  vec4 color = original;                  if (blur_on && blur_radius > 0.0) {                      float level = log2(max(1.0, blur_radius));                      vec2 step_uv = TEXTURE_PIXEL_SIZE * max(1.0, blur_radius) * 0.65;                      vec4 sum = vec4(0.0);                      for (int x=-1; x<=1; x++) { for (int y=-1; y<=1; y++) {                          float weight = (x==0 ? 2.0 : 1.0) * (y==0 ? 2.0 : 1.0);                          sum += textureLod(TEXTURE, clamp(UV+vec2(float(x),float(y))*step_uv,vec2(0.0),vec2(1.0)), level) * weight;                      }}                      color = mix(original, sum / 16.0, min(1.0, blur_radius));                  }                  COLOR=vec4(color.rgb,color.a*fade_alpha);              }              """ } }`
- `_backgroundPrevious.Material` = `_previousBackgroundMaterial`
- `_backgroundPrevious.TextureFilter` = `TextureFilterEnum.LinearWithMipmaps`
- `_backgroundPrevious` = `new TextureRect { Name = "DatePreviousBackground", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore }`
- `_body.MinimumSizeChanged` += `Layout`
- `_body` = `new VBoxContainer { MouseFilter = MouseFilterEnum.Pass }`
- `_composer` = `new VBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`
- `_dialog.GuiInput` += `Click`
- `_dialog` = `new Control { Name = "DateDialogue", MouseFilter = MouseFilterEnum.Stop }`
- `_editFailure.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `_editFailure` = `ActionButton("编辑文字", () => ReturnToEdit?.Invoke(), "DateFailureEdit", 150)`
- `_editorFont` = `SpacedFont(Editor, "font")`
- `_favourBadge` = `new AffectionBadge()`
- `_favourHost` = `new Control { Name = "DateFavour", MouseFilter = MouseFilterEnum.Ignore }`
- `_glass` = `new Gradient { Offsets = [0, .05f, 1], Colors = [new Color(0,0,0,0), new Color(0,0,0,.75f), new Color(0,0,0,1)] }`
- `_hint` = `new Label { Name = "DateAdvanceHint", Text = "单击继续  ›", HorizontalAlignment = HorizontalAlignment.Right, MouseFilter = MouseFilterEnum.Ignore }`
- `_hintDismissed` = `DateSceneAssetStore.ContinueHintDismissed()`
- `_history` = `new PanelContainer { Name = "DateHistory", Visible = false, MouseFilter = MouseFilterEnum.Stop }`
- `_historyFont` = `SpacedFont(_historyText, "normal_font")`
- `_historyText` = `new RichTextLabel { Name = "DateHistoryText", BbcodeEnabled = false, ScrollActive = true, SizeFlagsVertical = SizeFlags.ExpandFill, SelectionEnabled = true, FocusMode = FocusModeEnum.All }`
- `_interface` = `new Control { Name = "DateInterface", MouseFilter = MouseFilterEnum.Ignore }`
- `_lineFont` = `SpacedFont(_text, "normal_font")`
- `_margin` = `new MarginContainer { MouseFilter = MouseFilterEnum.Pass }`
- `_name.MinimumSizeChanged` += `Layout`
- `_name` = `new Label { Name = "DateSpeaker", MouseFilter = MouseFilterEnum.Ignore }`
- `_nameBox` = `new PanelContainer { Name = "DateSpeakerBox", MouseFilter = MouseFilterEnum.Ignore }`
- `_nameFont` = `SpacedFont(_name, "font")`
- `_navigation` = `new HBoxContainer { Name = "DateNavigation" }`
- `_previousBackgroundMaterial` = `new ShaderMaterial { Shader = _backgroundMaterial.Shader }`
- `_relationDetail.Visible` = `!_relationDetail.Visible`
- `_relationDetail` = `new Label { Name = "DateImpression", Position = new(0, 84), Size = new(280, 0), AutowrapMode = TextServer.AutowrapMode.WordSmart, Visible = false, MouseFilter = MouseFilterEnum.Ignore }`
- `_relationText` = `new Label { Name = "DateRelationship", Position = new(96, 23), Size = new(170, 30), TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, MouseFilter = MouseFilterEnum.Ignore }`
- `_settings` = `new HBoxContainer { Name = "DateHoverBar", Alignment = BoxContainer.AlignmentMode.Center, MouseFilter = MouseFilterEnum.Stop, Modulate = new(1,1,1,0) }`
- `_sprite` = `new TextureRect { Name = "DateSprite", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`
- `_text` = `new RichTextLabel { Name = "DateLine", BbcodeEnabled = false, ScrollActive = true, SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Pass,              VisibleCharactersBehavior = TextServer.VisibleCharactersBehavior.GlyphsLtr }`
- `_waitAction.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `_waitAction` = `ActionButton("停止生成", () => RetryStop?.Invoke(), "DateWaitAction", 150)`
- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `Attachments` = `new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `BbcodeEnabled` = `false`
- `Code` = `"""              shader_type canvas_item;              uniform bool blur_on = true;              uniform float blur_radius = 3.0;              uniform float fade_alpha = 1.0;              void fragment() {                  // Pyramid levels prefilter every pixel; tent reconstruction smooths level transitions.                  vec4 original = textureLod(TEXTURE, UV, 0.0);                  vec4 color = original;                  if (blur_on && blur_radius > 0.0) {                      float level = log2(max(1.0, blur_radius));                      vec2 step_uv = TEXTURE_PIXEL_SIZE * max(1.0, blur_radius) * 0.65;                      vec4 sum = vec4(0.0);                      for (int x=-1; x<=1; x++) { for (int y=-1; y<=1; y++) {                          float weight = (x==0 ? 2.0 : 1.0) * (y==0 ? 2.0 : 1.0);                          sum += textureLod(TEXTURE, clamp(UV+vec2(float(x),float(y))*step_uv,vec2(0.0),vec2(1.0)), level) * weight;                      }}                      color = mix(original, sum / 16.0, min(1.0, blur_radius));                  }                  COLOR=vec4(color.rgb,color.a*fade_alpha);              }              """`
- `Color` = `new Color("0d1926")`
- `Colors` = `[new Color(0,0,0,0), new Color(0,0,0,.75f), new Color(0,0,0,1)]`
- `CustomMinimumSize` = `new(0, 65)`
- `CustomMinimumSize` = `new(0, 80)`
- `Editor.GuiInput` += `input => { if (input is InputEventKey { Pressed: true, Echo: false, CtrlPressed: true, Keycode: Key.Enter }) { AcceptEvent(); Submit?.Invoke(); } }`
- `Editor` = `new TextEdit { Name = "DateInput", PlaceholderText = "输入回应…", SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 65), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `FillFrom` = `new(.5f, 0)`
- `FillTo` = `new(.5f, 1)`
- `FocusMode` = `FocusModeEnum.All`
- `Gradient` = `_glass`
- `GuiInput` += `Click`
- `Height` = `2048`
- `HorizontalAlignment` = `HorizontalAlignment.Center`
- `HorizontalAlignment` = `HorizontalAlignment.Right`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `MaxLinesVisible` = `2`
- `Modulate` = `new(1,1,1,0)`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `MouseFilter` = `MouseFilterEnum.Pass`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"DateAdvanceHint"`
- `Name` = `"DateBackdrop"`
- `Name` = `"DateDialogue"`
- `Name` = `"DateFavour"`
- `Name` = `"DateGlass"`
- `Name` = `"DateHistory"`
- `Name` = `"DateHistoryText"`
- `Name` = `"DateHoverBar"`
- `Name` = `"DateImpression"`
- `Name` = `"DateInput"`
- `Name` = `"DateInterface"`
- `Name` = `"DateLine"`
- `Name` = `"DateNavigation"`
- `Name` = `"DatePreviousBackground"`
- `Name` = `"DateRelationship"`
- `Name` = `"DateRelationshipDetails"`
- `Name` = `"DateScene"`
- `Name` = `"DateSpeaker"`
- `Name` = `"DateSpeakerBox"`
- `Name` = `"DateSprite"`
- `Name` = `"DateStatus"`
- `Offsets` = `[0, .05f, 1]`
- `PlaceholderText` = `"输入回应…"`
- `Position` = `new(0, 84)`
- `Position` = `new(8, 4)`
- `Position` = `new(96, 23)`
- `RegenerateButton` = `ActionButton("重新生成", () => Regenerate?.Invoke(), "DateRegenerate", 140)`
- `relationButton.Pressed` += `() => _relationDetail.Visible = !_relationDetail.Visible`
- `Resized` += `Layout`
- `ScrollActive` = `true`
- `SelectionEnabled` = `true`
- `Send` = `ActionButton("发送", () => Submit?.Invoke(), "DateSend", 150)`
- `Shader` = `_backgroundMaterial.Shader`
- `Shader` = `new Shader { Code = """              shader_type canvas_item;              uniform bool blur_on = true;              uniform float blur_radius = 3.0;              uniform float fade_alpha = 1.0;              void fragment() {                  // Pyramid levels prefilter every pixel; tent reconstruction smooths level transitions.                  vec4 original = textureLod(TEXTURE, UV, 0.0);                  vec4 color = original;                  if (blur_on && blur_radius > 0.0) {                      float level = log2(max(1.0, blur_radius));                      vec2 step_uv = TEXTURE_PIXEL_SIZE * max(1.0, blur_radius) * 0.65;                      vec4 sum = vec4(0.0);                      for (int x=-1; x<=1; x++) { for (int y=-1; y<=1; y++) {                          float weight = (x==0 ? 2.0 : 1.0) * (y==0 ? 2.0 : 1.0);                          sum += textureLod(TEXTURE, clamp(UV+vec2(float(x),float(y))*step_uv,vec2(0.0),vec2(1.0)), level) * weight;                      }}                      color = mix(original, sum / 16.0, min(1.0, blur_radius));                  }                  COLOR=vec4(color.rgb,color.a*fade_alpha);              }              """ }`
- `Size` = `new(170, 30)`
- `Size` = `new(280, 0)`
- `Size` = `new(80, 68)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `Status` = `new Label { Name = "DateStatus", AutowrapMode = TextServer.AutowrapMode.WordSmart, MaxLinesVisible = 2, MouseFilter = MouseFilterEnum.Ignore }`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCovered`
- `Text` = `"单击继续  ›"`
- `Text` = `"对话记录"`
- `Text` = `"滚轮 / PageUp / PageDown 浏览 · Q / 右键 / Esc 返回"`
- `TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `Texture` = `new GradientTexture2D { Width = 4, Height = 2048, FillFrom = new(.5f, 0), FillTo = new(.5f, 1),              Gradient = _glass }`
- `TooltipText` = `"查看关系与印象"`
- `Visible` = `false`
- `VisibleCharactersBehavior` = `TextServer.VisibleCharactersBehavior.GlyphsLtr`
- `Width` = `4`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`
- `ZIndex` = `30`

<a id="symbol-e28b8217360a"></a>

## `SpacedFont(Godot.Control, string) — FontVariation SpacedFont(Control control, string key)`

来源：源码第 181 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)

**调用：** `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；`Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；`Godot.FontVariation.FontVariation()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`control.AddThemeFontOverride(key, font)`；返回值紧邻使用处：`ExpressionStatementSyntax: control.AddThemeFontOverride(key, font);`
- `Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；输入表达式：`control.GetThemeFont(key)`；返回值紧邻使用处：`AssignmentExpressionSyntax: BaseFont = control.GetThemeFont(key)`
- `Godot.FontVariation.FontVariation()`；输入表达式：`new FontVariation { BaseFont = control.GetThemeFont(key) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new FontVariation { BaseFont = control.GetThemeFont(key) }`

**赋值（含属性/字段和局部值）：**

- `BaseFont` = `control.GetThemeFont(key)`

<a id="symbol-cb37d8aeee1d"></a>

## `NationalSpire.DateSceneView.Click(Godot.InputEvent) — private void Click(InputEvent e)`

来源：源码第 190 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateSceneAssetStore.DismissContinueHint()`](DateSceneAssets.cs.md#symbol-f98f286cc92d)；`Godot.CanvasItem.Hide()`；`Godot.Control.AcceptEvent()`；`Godot.RichTextLabel.GetTotalCharacterCount()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.DismissContinueHint()`；`NationalSpire.DateSceneView._hint`；`NationalSpire.DateSceneView._hintDismissed`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView.Advance`；`NationalSpire.DateSceneView.Blocked`；`NationalSpire.DateSceneView.DialogueHidden`；`NationalSpire.DateSceneView.HistoryOpen`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_hint.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _hint.Hide();`
- `Godot.Control.AcceptEvent()`；输入表达式：`AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: AcceptEvent();`
- `Godot.RichTextLabel.GetTotalCharacterCount()`；输入表达式：`_text.GetTotalCharacterCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: _text.VisibleCharacters < _text.GetTotalCharacterCount()`
- `NationalSpire.DateSceneAssetStore.DismissContinueHint()`；输入表达式：`DateSceneAssetStore.DismissContinueHint()`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.DismissContinueHint();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Advance?.Invoke()`
- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Blocked?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_hintDismissed` = `true`
- `_text.VisibleCharacters` = `-1`
- `Status.Text` = `error.Message`

<a id="symbol-557ca90aab66"></a>

## `NationalSpire.DateSceneView._Input(Godot.InputEvent) — public override void _Input(InputEvent e)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateSceneView.CloseHistory()`](DateSceneView.cs.md#symbol-83672fb8ae11)；[`NationalSpire.DateSceneView.OpenHistory()`](DateSceneView.cs.md#symbol-a52c1f416ddc)；[`NationalSpire.DateSceneView.SetDialogueVisible(bool)`](DateSceneView.cs.md#symbol-11800b4bb8d0)；[`NationalSpire.DateSceneView.WaitingClick(Godot.Vector2)`](DateSceneWaiting.cs.md#symbol-883b2e576cb3)；`Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Node.GetParent()`；`Godot.Node.GetViewport()`；`Godot.Rect2.HasPoint(Godot.Vector2)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.RichTextLabel.GetVScrollBar()`；`Godot.TextEdit.GetVScrollBar()`；`Godot.Transform2D.AffineInverse()`；`Godot.Viewport.GuiGetFocusOwner()`；`Godot.Viewport.GuiGetHoveredControl()`；`Godot.Viewport.SetInputAsHandled()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Math.Clamp(double, double, double)`；`System.Math.Max(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._attachmentScroll`；`NationalSpire.DateSceneView._historyScrollPending`；`NationalSpire.DateSceneView._historyText`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView.Blocked`；`NationalSpire.DateSceneView.CloseHistory()`；`NationalSpire.DateSceneView.DialogueHidden`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.HistoryOpen`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.OpenHistory()`；`NationalSpire.DateSceneView.SetDialogueVisible(bool)`；`NationalSpire.DateSceneView.WaitingClick(Godot.Vector2)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`_text.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _text.GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`Editor.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Editor.GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`_text.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: !HistoryOpen && _text.IsVisibleInTree()`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`Editor.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: !HistoryOpen && InputMode && Editor.IsVisibleInTree()`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsVisibleInTree()`
- `Godot.Node.GetParent()`；输入表达式：`hovered.GetParent()`；返回值紧邻使用处：`AssignmentExpressionSyntax: hovered = hovered.GetParent()`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetHoveredControl`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().SetInputAsHandled`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, _text.Size).HasPoint(_text.GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position)`；返回值紧邻使用处：`BinaryExpressionSyntax: !HistoryOpen && _text.IsVisibleInTree()                  && new Rect2(Vector2.Zero, _text.Size).HasPoint(_text.GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position)`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Editor.Size).HasPoint(Editor.GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position)`；返回值紧邻使用处：`BinaryExpressionSyntax: !HistoryOpen && InputMode && Editor.IsVisibleInTree()                  && new Rect2(Vector2.Zero, Editor.Size).HasPoint(Editor.GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position)`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size).HasPoint(GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !new Rect2(Vector2.Zero, Size).HasPoint(GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position)`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size).HasPoint(GetGlobalTransformWithCanvas().AffineInverse() * right.Position)`；返回值紧邻使用处：`BinaryExpressionSyntax: e is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Right } right              && new Rect2(Vector2.Zero, Size).HasPoint(GetGlobalTransformWithCanvas().AffineInverse() * right.Position)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, _text.Size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Rect2(Vector2.Zero, _text.Size).HasPoint`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Editor.Size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Rect2(Vector2.Zero, Editor.Size).HasPoint`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Rect2(Vector2.Zero, Size).HasPoint`
- `Godot.RichTextLabel.GetVScrollBar()`；输入表达式：`_historyText.GetVScrollBar()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _historyText.GetVScrollBar()`
- `Godot.RichTextLabel.GetVScrollBar()`；输入表达式：`_text.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _text.GetVScrollBar().MaxValue`
- `Godot.RichTextLabel.GetVScrollBar()`；输入表达式：`_text.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _text.GetVScrollBar().Page`
- `Godot.TextEdit.GetVScrollBar()`；输入表达式：`Editor.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Editor.GetVScrollBar().MaxValue`
- `Godot.TextEdit.GetVScrollBar()`；输入表达式：`Editor.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Editor.GetVScrollBar().Page`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`_text.GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: _text.GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`Editor.GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: Editor.GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: GetGlobalTransformWithCanvas().AffineInverse() * click.Position`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: GetGlobalTransformWithCanvas().AffineInverse() * right.Position`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`IsPatternExpressionSyntax: GetViewport().GuiGetFocusOwner() is not (TextEdit or LineEdit)`
- `Godot.Viewport.GuiGetHoveredControl()`；输入表达式：`GetViewport().GuiGetHoveredControl()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetViewport().GuiGetHoveredControl()`
- `Godot.Viewport.SetInputAsHandled()`；输入表达式：`GetViewport().SetInputAsHandled()`；返回值紧邻使用处：`ExpressionStatementSyntax: GetViewport().SetInputAsHandled();`
- `NationalSpire.DateSceneView.CloseHistory()`；输入表达式：`CloseHistory()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseHistory();`
- `NationalSpire.DateSceneView.OpenHistory()`；输入表达式：`OpenHistory()`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenHistory();`
- `NationalSpire.DateSceneView.SetDialogueVisible(bool)`；输入表达式：`SetDialogueVisible(DialogueHidden)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetDialogueVisible(DialogueHidden);`
- `NationalSpire.DateSceneView.WaitingClick(Godot.Vector2)`；输入表达式：`WaitingClick(GetGlobalTransformWithCanvas().AffineInverse() * click.Position)`；返回值紧邻使用处：`BinaryExpressionSyntax: e is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Left } click              && WaitingClick(GetGlobalTransformWithCanvas().AffineInverse() * click.Position)`
- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Blocked?.Invoke()`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(bar.Value + (up ? -distance : distance), bar.MinValue, bottom)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bar.Value = Math.Clamp(bar.Value + (up ? -distance : distance), bar.MinValue, bottom)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(60, bar.Page * .85)`；返回值紧邻使用处：`ConditionalExpressionSyntax: e is InputEventKey ? Math.Max(60, bar.Page * .85) : 70`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(bar.MinValue, bar.MaxValue - bar.Page)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(bar.MinValue, bar.MaxValue - bar.Page)`

**赋值（含属性/字段和局部值）：**

- `bar.Value` = `Math.Clamp(bar.Value + (up ? -distance : distance), bar.MinValue, bottom)`
- `hovered` = `hovered.GetParent()`

<a id="symbol-a52c1f416ddc"></a>

## `NationalSpire.DateSceneView.OpenHistory() — private void OpenHistory()`

来源：源码第 245 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Input(Godot.InputEvent)`](DateSceneView.cs.md#symbol-557ca90aab66)；[`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)

**调用：** `Godot.CanvasItem.Show()`；`Godot.Control.GrabFocus()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._history`；`NationalSpire.DateSceneView._historyScrollPending`；`NationalSpire.DateSceneView._historyText`；`NationalSpire.DateSceneView.HistoryText`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`_history.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _history.Show();`
- `Godot.Control.GrabFocus()`；输入表达式：`_historyText.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: _historyText.GrabFocus();`
- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: HistoryText?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_historyScrollPending` = `2`
- `_historyText.Text` = `HistoryText?.Invoke() ?? "约会开始后的对话会显示在这里。"`

<a id="symbol-83672fb8ae11"></a>

## `NationalSpire.DateSceneView.CloseHistory() — private void CloseHistory()`

来源：源码第 250 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Input(Godot.InputEvent)`](DateSceneView.cs.md#symbol-557ca90aab66)；[`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)；[`NationalSpire.DateSceneView.GoBack()`](DateSceneView.cs.md#symbol-c97afbe9881b)

**调用：** [`NationalSpire.DateSceneView.SetDialogueVisible(bool)`](DateSceneView.cs.md#symbol-11800b4bb8d0)；`Godot.CanvasItem.Hide()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._history`；`NationalSpire.DateSceneView._historyScrollPending`；`NationalSpire.DateSceneView.SetDialogueVisible(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_history.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _history.Hide();`
- `NationalSpire.DateSceneView.SetDialogueVisible(bool)`；输入表达式：`SetDialogueVisible(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetDialogueVisible(true);`

**赋值（含属性/字段和局部值）：**

- `_historyScrollPending` = `0`

<a id="symbol-11800b4bb8d0"></a>

## `NationalSpire.DateSceneView.SetDialogueVisible(bool) — private void SetDialogueVisible(bool visible)`

来源：源码第 255 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Input(Godot.InputEvent)`](DateSceneView.cs.md#symbol-557ca90aab66)；[`NationalSpire.DateSceneView.CloseHistory()`](DateSceneView.cs.md#symbol-83672fb8ae11)

**调用：** `Godot.Control.GrabFocus()`；`Godot.Control.ReleaseFocus()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._interface`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.InputMode`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GrabFocus()`；输入表达式：`Editor.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: Editor.GrabFocus();`
- `Godot.Control.ReleaseFocus()`；输入表达式：`Editor.ReleaseFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: Editor.ReleaseFocus();`

**赋值（含属性/字段和局部值）：**

- `_interface.Visible` = `visible`

<a id="symbol-c97afbe9881b"></a>

## `NationalSpire.DateSceneView.GoBack() — public void GoBack()`

来源：源码第 260 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateSceneView.CloseHistory()`](DateSceneView.cs.md#symbol-83672fb8ae11)；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.CloseHistory()`；`NationalSpire.DateSceneView.Exit`；`NationalSpire.DateSceneView.HistoryOpen`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.CloseHistory()`；输入表达式：`CloseHistory()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseHistory();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Exit?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-80b96be1ed4b"></a>

## `NationalSpire.DateSceneView.Layout() — private void Layout()`

来源：源码第 264 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.AffectionVisibility(bool)`](DateSceneView.cs.md#symbol-7da14922fda4)；[`NationalSpire.DateSceneView.BeginWaiting()`](DateSceneWaiting.cs.md#symbol-289036db5043)；[`NationalSpire.DateSceneView.EndWaiting()`](DateSceneWaiting.cs.md#symbol-03e797c35180)；[`NationalSpire.DateSceneView.Preferences(int, double, double)`](DateSceneView.cs.md#symbol-878552c24bd8)；[`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`](DateSceneView.cs.md#symbol-32ea38e8c82d)；[`NationalSpire.DateSceneView.ShowInput(string, bool)`](DateSceneView.cs.md#symbol-4f0d075ed97b)；[`NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D)`](DateSceneView.cs.md#symbol-1801b5d93aa1)

**调用：** [`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`](DateSceneWaiting.cs.md#symbol-9b17a8ece561)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；`Godot.GodotObject.GetInstanceId()`；`Godot.Gradient.SetOffset(int, float)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._body`；`NationalSpire.DateSceneView._dialog`；`NationalSpire.DateSceneView._favourHost`；`NationalSpire.DateSceneView._glass`；`NationalSpire.DateSceneView._headRatios`；`NationalSpire.DateSceneView._layingOut`；`NationalSpire.DateSceneView._margin`；`NationalSpire.DateSceneView._name`；`NationalSpire.DateSceneView._nameBox`；`NationalSpire.DateSceneView._navigation`；`NationalSpire.DateSceneView._positionAnchor`；`NationalSpire.DateSceneView._settings`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._spriteBaseY`；`NationalSpire.DateSceneView._spriteScale`；`NationalSpire.DateSceneView._spriteX`；`NationalSpire.DateSceneView._spriteY`；`NationalSpire.DateSceneView._waitingAnchor`；`NationalSpire.DateSceneView._waitingShift`；`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；`NationalSpire.DateSceneView.WaitingDefault`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_margin.AddThemeConstantOverride("margin_" + side, (int)inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: _margin.AddThemeConstantOverride("margin_" + side, (int)inset);`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_body.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _body.GetCombinedMinimumSize().Y`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_name.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _name.GetCombinedMinimumSize().Y`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_nameBox.GetCombinedMinimumSize()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _nameBox.Size = _nameBox.GetCombinedMinimumSize()`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`_nameBox.GetThemeStylebox("panel")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _nameBox.GetThemeStylebox("panel").ContentMarginRight`
- `Godot.GodotObject.GetInstanceId()`；输入表达式：`anchor.GetInstanceId()`；返回值紧邻使用处：`ArgumentSyntax: anchor.GetInstanceId()`
- `Godot.Gradient.SetOffset(int, float)`；输入表达式：`_glass.SetOffset(1, Math.Min(.99f, 15 / panelHeight))`；返回值紧邻使用处：`ExpressionStatementSyntax: _glass.SetOffset(1, Math.Min(.99f, 15 / panelHeight));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(height * .62f * 1.3f, height * .93f * 1.3f)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(height * .62f * 1.3f, height * .93f * 1.3f) * _spriteScale`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new((width - _sprite.Size.X) * .5f + _spriteX + _waitingShift, _spriteBaseY)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sprite.Position = new((width - _sprite.Size.X) * .5f + _spriteX + _waitingShift, _spriteBaseY)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, height - panelHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dialog.Position = new(0, height - panelHeight)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(280, 76)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _favourHost.Size = new(280, 76)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(320, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _navigation.Size = new(320, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(inset - 12, _dialog.Position.Y - _nameBox.Size.Y - 8)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _nameBox.Position = new(inset - 12, _dialog.Position.Y - _nameBox.Size.Y - 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width - 310, 90)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _favourHost.Position = new(width - 310, 90)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width - 354, 22)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _navigation.Position = new(width - 354, 22)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width * .25f, height * .945f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _settings.Position = new(width * .25f, height * .945f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width * .5f, Math.Max(48, height * .05f))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _settings.Size = new(width * .5f, Math.Max(48, height * .05f))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width, panelHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dialog.Size = new(width, panelHeight)`
- `NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；输入表达式：`RememberSprite(anchor)`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberSprite(anchor);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_headRatios.GetValueOrDefault(anchor.GetInstanceId())`；返回值紧邻使用处：`ConditionalExpressionSyntax: anchor == null ? 0 : _headRatios.GetValueOrDefault(anchor.GetInstanceId())`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(28, _name.GetCombinedMinimumSize().Y + 18)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(28, _name.GetCombinedMinimumSize().Y + 18)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(48, height * .05f)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(48, height * .05f)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(height * .32f, _body.GetCombinedMinimumSize().Y + 104)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(height * .32f, _body.GetCombinedMinimumSize().Y + 104)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(.99f, 15 / panelHeight)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(.99f, 15 / panelHeight)`

**赋值（含属性/字段和局部值）：**

- `_dialog.Position` = `new(0, height - panelHeight)`
- `_dialog.Size` = `new(width, panelHeight)`
- `_favourHost.Position` = `new(width - 310, 90)`
- `_favourHost.Size` = `new(280, 76)`
- `_layingOut` = `false`
- `_layingOut` = `true`
- `_nameBox.GetThemeStylebox("panel").ContentMarginRight` = `12`
- `_nameBox.Position` = `new(inset - 12, _dialog.Position.Y - _nameBox.Size.Y - 8)`
- `_nameBox.Size` = `_nameBox.GetCombinedMinimumSize()`
- `_navigation.Position` = `new(width - 354, 22)`
- `_navigation.Size` = `new(320, 44)`
- `_positionAnchor` ??= `WaitingDefault ?? _waitingAnchor ?? _sprite.Texture`
- `_settings.Position` = `new(width * .25f, height * .945f)`
- `_settings.Size` = `new(width * .5f, Math.Max(48, height * .05f))`
- `_sprite.Position` = `new((width - _sprite.Size.X) * .5f + _spriteX + _waitingShift, _spriteBaseY)`
- `_sprite.Size` = `new Vector2(height * .62f * 1.3f, height * .93f * 1.3f) * _spriteScale`
- `_spriteBaseY` = `height * .4f - top * _sprite.Size.Y - 160 + _spriteY`

<a id="symbol-fecef0523d98"></a>

## `NationalSpire.DateSceneView.SetTextSpacing(Godot.FontVariation, int, double) — private void SetTextSpacing(FontVariation font, int size, double extra)`

来源：源码第 287 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.Preferences(int, double, double)`](DateSceneView.cs.md#symbol-878552c24bd8)

**调用：** `double.IsFinite(double)`；`Godot.Font.GetRids()`；`Godot.Font.GetSpacing(Godot.TextServer.SpacingType)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.GodotObject.GetInstanceId()`；`Godot.TextServer.FontGetGlyphAdvance(Godot.Rid, long, long)`；`Godot.TextServer.FontGetGlyphIndex(Godot.Rid, long, long, long)`；`Godot.TextServer.FontGetGlyphSize(Godot.Rid, Godot.Vector2I, long)`；`Godot.TextServer.FontHasChar(Godot.Rid, long)`；`Godot.TextServerManager.GetPrimaryInterface()`；`Godot.Vector2I.Vector2I(int, int)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Math.Clamp(double, double, double)`；`System.Math.Max(float, float)`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._fontGaps`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `double.IsFinite(double)`；输入表达式：`double.IsFinite(extra)`；返回值紧邻使用处：`ConditionalExpressionSyntax: double.IsFinite(extra) ? extra : 1`
- `Godot.Font.GetRids()`；输入表达式：`source.GetRids()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var rid in source.GetRids())                  {                      if (!server.FontHasChar(rid, character)) continue;                      long glyph = server.FontGetGlyphIndex(rid, size, character, 0);                      float advance = server.FontGetGlyphAdvance(rid, size, glyph).X;                      float ink = server.FontGetGlyphSize(rid, new Vector2I(size, 0), glyph).X;                      if (advance > ink && ink > 0) { total += advance - ink; count++; }                      break;                  }`
- `Godot.Font.GetSpacing(Godot.TextServer.SpacingType)`；输入表达式：`source.GetSpacing(TextServer.SpacingType.Glyph)`；返回值紧邻使用处：`BinaryExpressionSyntax: source.GetSpacing(TextServer.SpacingType.Glyph) + (int)Math.Round(gap * Math.Clamp(double.IsFinite(extra) ? extra : 1, 0, 3))`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`source.GetStringSize(sample, fontSize: size)`；返回值紧邻使用处：`ExpressionStatementSyntax: source.GetStringSize(sample, fontSize: size);`
- `Godot.GodotObject.GetInstanceId()`；输入表达式：`source.GetInstanceId()`；返回值紧邻使用处：`ArgumentSyntax: source.GetInstanceId()`
- `Godot.TextServer.FontGetGlyphAdvance(Godot.Rid, long, long)`；输入表达式：`server.FontGetGlyphAdvance(rid, size, glyph)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: server.FontGetGlyphAdvance(rid, size, glyph).X`
- `Godot.TextServer.FontGetGlyphIndex(Godot.Rid, long, long, long)`；输入表达式：`server.FontGetGlyphIndex(rid, size, character, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = server.FontGetGlyphIndex(rid, size, character, 0)`
- `Godot.TextServer.FontGetGlyphSize(Godot.Rid, Godot.Vector2I, long)`；输入表达式：`server.FontGetGlyphSize(rid, new Vector2I(size, 0), glyph)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: server.FontGetGlyphSize(rid, new Vector2I(size, 0), glyph).X`
- `Godot.TextServer.FontHasChar(Godot.Rid, long)`；输入表达式：`server.FontHasChar(rid, character)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !server.FontHasChar(rid, character)`
- `Godot.TextServerManager.GetPrimaryInterface()`；输入表达式：`TextServerManager.GetPrimaryInterface()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TextServerManager.GetPrimaryInterface()`
- `Godot.Vector2I.Vector2I(int, int)`；输入表达式：`new Vector2I(size, 0)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2I(size, 0)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_fontGaps.TryGetValue(key, out float gap)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_fontGaps.TryGetValue(key, out float gap)`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(double.IsFinite(extra) ? extra : 1, 0, 3)`；返回值紧邻使用处：`BinaryExpressionSyntax: gap * Math.Clamp(double.IsFinite(extra) ? extra : 1, 0, 3)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(1, size * .08f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: count > 0 ? total / count : Math.Max(1, size * .08f)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(gap * Math.Clamp(double.IsFinite(extra) ? extra : 1, 0, 3))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(gap * Math.Clamp(double.IsFinite(extra) ? extra : 1, 0, 3))`

**赋值（含属性/字段和局部值）：**

- `_fontGaps[key]` = `gap = count > 0 ? total / count : Math.Max(1, size * .08f)`
- `font.SpacingGlyph` = `source.GetSpacing(TextServer.SpacingType.Glyph) + (int)Math.Round(gap * Math.Clamp(double.IsFinite(extra) ? extra : 1, 0, 3))`
- `gap` = `count > 0 ? total / count : Math.Max(1, size * .08f)`
- `total` += `advance - ink`

<a id="symbol-878552c24bd8"></a>

## `NationalSpire.DateSceneView.Preferences(int, double, double) — public void Preferences(int fontSize, double fade, double spacing = 1)`

来源：源码第 309 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Apply()`](DateSceneScreen.cs.md#symbol-42869169eaa3)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)

**调用：** [`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；[`NationalSpire.DateSceneView.SetTextSpacing(Godot.FontVariation, int, double)`](DateSceneView.cs.md#symbol-fecef0523d98)；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Font.GetHeight(int)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Clamp(double, double, double)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._editorFont`；`NationalSpire.DateSceneView._glass`；`NationalSpire.DateSceneView._historyFont`；`NationalSpire.DateSceneView._historyText`；`NationalSpire.DateSceneView._lineFont`；`NationalSpire.DateSceneView._name`；`NationalSpire.DateSceneView._nameFont`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.Layout()`；`NationalSpire.DateSceneView.SetTextSpacing(Godot.FontVariation, int, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0,0,0,.75f * (1 - amount))`；返回值紧邻使用处：`ExpressionElementSyntax: new Color(0,0,0,.75f * (1 - amount))`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0,0,0,0)`；返回值紧邻使用处：`ExpressionElementSyntax: new Color(0,0,0,0)`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0,0,0,1 - .5f * amount)`；返回值紧邻使用处：`ExpressionElementSyntax: new Color(0,0,0,1 - .5f * amount)`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_historyText.AddThemeFontSizeOverride("normal_font_size", 27 + offset)`；返回值紧邻使用处：`ExpressionStatementSyntax: _historyText.AddThemeFontSizeOverride("normal_font_size", 27 + offset);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_name.AddThemeFontSizeOverride("font_size", 31 + offset)`；返回值紧邻使用处：`ExpressionStatementSyntax: _name.AddThemeFontSizeOverride("font_size", 31 + offset);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_text.AddThemeFontSizeOverride("normal_font_size", 30 + offset)`；返回值紧邻使用处：`ExpressionStatementSyntax: _text.AddThemeFontSizeOverride("normal_font_size", 30 + offset);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`Editor.AddThemeFontSizeOverride("font_size", 30 + offset)`；返回值紧邻使用处：`ExpressionStatementSyntax: Editor.AddThemeFontSizeOverride("font_size", 30 + offset);`
- `Godot.Font.GetHeight(int)`；输入表达式：`_lineFont.GetHeight(30 + offset)`；返回值紧邻使用处：`BinaryExpressionSyntax: _lineFont.GetHeight(30 + offset) * 3`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, _lineFont.GetHeight(30 + offset) * 3 + 8)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _text.CustomMinimumSize = new(0, _lineFont.GetHeight(30 + offset) * 3 + 8)`
- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `NationalSpire.DateSceneView.SetTextSpacing(Godot.FontVariation, int, double)`；输入表达式：`SetTextSpacing(_editorFont, 30 + offset, spacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetTextSpacing(_editorFont, 30 + offset, spacing);`
- `NationalSpire.DateSceneView.SetTextSpacing(Godot.FontVariation, int, double)`；输入表达式：`SetTextSpacing(_historyFont, 27 + offset, spacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetTextSpacing(_historyFont, 27 + offset, spacing);`
- `NationalSpire.DateSceneView.SetTextSpacing(Godot.FontVariation, int, double)`；输入表达式：`SetTextSpacing(_lineFont, 30 + offset, spacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetTextSpacing(_lineFont, 30 + offset, spacing);`
- `NationalSpire.DateSceneView.SetTextSpacing(Godot.FontVariation, int, double)`；输入表达式：`SetTextSpacing(_nameFont, 31 + offset, spacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetTextSpacing(_nameFont, 31 + offset, spacing);`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(fade, 0, 1)`；返回值紧邻使用处：`CastExpressionSyntax: (float)Math.Clamp(fade, 0, 1)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(fontSize, 0, 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Clamp(fontSize, 0, 2) - 1`

**赋值（含属性/字段和局部值）：**

- `_glass.Colors` = `[new Color(0,0,0,0), new Color(0,0,0,.75f * (1 - amount)), new Color(0,0,0,1 - .5f * amount)]`
- `_text.CustomMinimumSize` = `new(0, _lineFont.GetHeight(30 + offset) * 3 + 8)`

<a id="symbol-32ea38e8c82d"></a>

## `NationalSpire.DateSceneView.Presentation(double, double, double, bool) — public void Presentation(double scale, double x, double y, bool outline)`

来源：源码第 320 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Apply()`](DateSceneScreen.cs.md#symbol-42869169eaa3)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)

**调用：** [`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；`double.IsFinite(double)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`System.Math.Clamp(double, double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._spriteScale`；`NationalSpire.DateSceneView._spriteX`；`NationalSpire.DateSceneView._spriteY`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.Layout()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `double.IsFinite(double)`；输入表达式：`double.IsFinite(scale)`；返回值紧邻使用处：`ConditionalExpressionSyntax: double.IsFinite(scale) ? scale : 1`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(x)`；返回值紧邻使用处：`ConditionalExpressionSyntax: double.IsFinite(x) ? x : 0`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(y)`；返回值紧邻使用处：`ConditionalExpressionSyntax: double.IsFinite(y) ? y : 0`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_text.AddThemeColorOverride("font_outline_color", Colors.Black)`；返回值紧邻使用处：`ExpressionStatementSyntax: _text.AddThemeColorOverride("font_outline_color", Colors.Black);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`Editor.AddThemeColorOverride("font_outline_color", Colors.Black)`；返回值紧邻使用处：`ExpressionStatementSyntax: Editor.AddThemeColorOverride("font_outline_color", Colors.Black);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_text.AddThemeConstantOverride("outline_size", outline ? 4 : 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: _text.AddThemeConstantOverride("outline_size", outline ? 4 : 0);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`Editor.AddThemeConstantOverride("outline_size", outline ? 4 : 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: Editor.AddThemeConstantOverride("outline_size", outline ? 4 : 0);`
- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(double.IsFinite(scale) ? scale : 1, .25, 2.5)`；返回值紧邻使用处：`CastExpressionSyntax: (float)Math.Clamp(double.IsFinite(scale) ? scale : 1, .25, 2.5)`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(double.IsFinite(x) ? x : 0, -4096, 4096)`；返回值紧邻使用处：`CastExpressionSyntax: (float)Math.Clamp(double.IsFinite(x) ? x : 0, -4096, 4096)`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(double.IsFinite(y) ? y : 0, -4096, 4096)`；返回值紧邻使用处：`CastExpressionSyntax: (float)Math.Clamp(double.IsFinite(y) ? y : 0, -4096, 4096)`

**赋值（含属性/字段和局部值）：**

- `_spriteScale` = `(float)Math.Clamp(double.IsFinite(scale) ? scale : 1, .25, 2.5)`
- `_spriteX` = `(float)Math.Clamp(double.IsFinite(x) ? x : 0, -4096, 4096)`
- `_spriteY` = `(float)Math.Clamp(double.IsFinite(y) ? y : 0, -4096, 4096)`

<a id="symbol-9c58edcaf529"></a>

## `NationalSpire.DateSceneView.Background(string, bool, double) — public void Background(string background, bool blur, double amount = 3)`

来源：源码第 329 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.SelectDateBackground(string)`](DateSceneScreen.cs.md#symbol-4d37da1a3f4b)

**调用：** [`NationalSpire.DateSceneView.BeginBackground(Godot.Texture2D, string)`](DateSceneView.cs.md#symbol-99d35c646db1)；[`NationalSpire.DateSceneView.CreateBackground(string)`](DateSceneView.cs.md#symbol-30a197722f91)；`double.IsFinite(double)`；`Godot.GodotObject.Dispose()`；`Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；`System.Math.Clamp(double, double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._backgroundBlend`；`NationalSpire.DateSceneView._backgroundId`；`NationalSpire.DateSceneView._backgroundMaterial`；`NationalSpire.DateSceneView._backgroundTexture`；`NationalSpire.DateSceneView._previousBackgroundMaterial`；`NationalSpire.DateSceneView._queuedBackgroundId`；`NationalSpire.DateSceneView._queuedBackgroundTexture`；`NationalSpire.DateSceneView.BeginBackground(Godot.Texture2D, string)`；`NationalSpire.DateSceneView.CreateBackground(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `double.IsFinite(double)`；输入表达式：`double.IsFinite(amount)`；返回值紧邻使用处：`ConditionalExpressionSyntax: double.IsFinite(amount) ? Math.Clamp(amount, 0, 20) : 3`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _queuedBackgroundTexture?.Dispose()`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`_backgroundMaterial.SetShaderParameter("blur_on", blur)`；返回值紧邻使用处：`ExpressionStatementSyntax: _backgroundMaterial.SetShaderParameter("blur_on", blur);`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`_backgroundMaterial.SetShaderParameter("blur_radius", radius)`；返回值紧邻使用处：`ExpressionStatementSyntax: _backgroundMaterial.SetShaderParameter("blur_radius", radius);`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`_previousBackgroundMaterial.SetShaderParameter("blur_on", blur)`；返回值紧邻使用处：`ExpressionStatementSyntax: _previousBackgroundMaterial.SetShaderParameter("blur_on", blur);`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`_previousBackgroundMaterial.SetShaderParameter("blur_radius", radius)`；返回值紧邻使用处：`ExpressionStatementSyntax: _previousBackgroundMaterial.SetShaderParameter("blur_radius", radius);`
- `NationalSpire.DateSceneView.BeginBackground(Godot.Texture2D, string)`；输入表达式：`BeginBackground(texture, background)`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginBackground(texture, background);`
- `NationalSpire.DateSceneView.CreateBackground(string)`；输入表达式：`CreateBackground(background)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CreateBackground(background)`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(amount, 0, 20)`；返回值紧邻使用处：`ConditionalExpressionSyntax: double.IsFinite(amount) ? Math.Clamp(amount, 0, 20) : 3`

**赋值（含属性/字段和局部值）：**

- `_queuedBackgroundId` = `""`
- `_queuedBackgroundId` = `background`
- `_queuedBackgroundTexture` = `null`
- `_queuedBackgroundTexture` = `texture`

<a id="symbol-30a197722f91"></a>

## `NationalSpire.DateSceneView.CreateBackground(string) — public static Texture2D CreateBackground(string background)`

来源：源码第 342 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.Background(string, bool, double)`](DateSceneView.cs.md#symbol-9c58edcaf529)；[`NationalSpire.RandomEventArt.Load(string)`](RandomEventArt.cs.md#symbol-5147b98e47ca)；[`Preview()`](DateSceneBackgroundScreen.cs.md#symbol-1531e6366b73)

**调用：** [`NationalSpire.DateSceneBackgrounds.Pixels(string)`](DateSceneBackgrounds.cs.md#symbol-3098b5a3a6eb)；`Godot.Color.Color(string)`；`Godot.Image.CreateEmpty(int, int, bool, Godot.Image.Format)`；`Godot.Image.Fill(Godot.Color)`；`Godot.Image.GenerateMipmaps(bool)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneBackgrounds.Pixels(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("0d1926")`；返回值紧邻使用处：`ArgumentSyntax: new Color("0d1926")`
- `Godot.Image.CreateEmpty(int, int, bool, Godot.Image.Format)`；输入表达式：`Image.CreateEmpty(1, 1, false, Image.Format.Rgba8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Image.CreateEmpty(1, 1, false, Image.Format.Rgba8)`
- `Godot.Image.Fill(Godot.Color)`；输入表达式：`image.Fill(new Color("0d1926"))`；返回值紧邻使用处：`ExpressionStatementSyntax: image.Fill(new Color("0d1926"));`
- `Godot.Image.GenerateMipmaps(bool)`；输入表达式：`pixels.GenerateMipmaps()`；返回值紧邻使用处：`ExpressionStatementSyntax: pixels.GenerateMipmaps();`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`ReturnStatementSyntax: return ImageTexture.CreateFromImage(image);`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(pixels)`；返回值紧邻使用处：`ReturnStatementSyntax: return ImageTexture.CreateFromImage(pixels);`
- `NationalSpire.DateSceneBackgrounds.Pixels(string)`；输入表达式：`DateSceneBackgrounds.Pixels(background)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneBackgrounds.Pixels(background)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-99d35c646db1"></a>

## `NationalSpire.DateSceneView.BeginBackground(Godot.Texture2D, string) — private void BeginBackground(Texture2D texture, string id)`

来源：源码第 353 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Process(double)`](DateSceneView.cs.md#symbol-e901780018ca)；[`NationalSpire.DateSceneView.Background(string, bool, double)`](DateSceneView.cs.md#symbol-9c58edcaf529)

**调用：** `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._background`；`NationalSpire.DateSceneView._backgroundBlend`；`NationalSpire.DateSceneView._backgroundId`；`NationalSpire.DateSceneView._backgroundMaterial`；`NationalSpire.DateSceneView._backgroundPrevious`；`NationalSpire.DateSceneView._backgroundTexture`；`NationalSpire.DateSceneView._previousBackgroundTexture`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`_backgroundMaterial.SetShaderParameter("fade_alpha", _backgroundBlend)`；返回值紧邻使用处：`ExpressionStatementSyntax: _backgroundMaterial.SetShaderParameter("fade_alpha", _backgroundBlend);`

**赋值（含属性/字段和局部值）：**

- `_background.Texture` = `texture`
- `_backgroundBlend` = `_previousBackgroundTexture == null ? 1 : 0`
- `_backgroundId` = `id`
- `_backgroundPrevious.Texture` = `_previousBackgroundTexture`
- `_backgroundTexture` = `texture`
- `_previousBackgroundTexture` = `_backgroundTexture`

<a id="symbol-73e48672e1bd"></a>

## `NationalSpire.DateSceneView._ExitTree() — public override void _ExitTree()`

来源：源码第 359 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._backgroundTexture`；`NationalSpire.DateSceneView._editorFont`；`NationalSpire.DateSceneView._historyFont`；`NationalSpire.DateSceneView._lineFont`；`NationalSpire.DateSceneView._nameFont`；`NationalSpire.DateSceneView._previousBackgroundTexture`；`NationalSpire.DateSceneView._queuedBackgroundTexture`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _backgroundTexture?.Dispose()`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _editorFont?.Dispose()`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _historyFont?.Dispose()`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _lineFont?.Dispose()`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _nameFont?.Dispose()`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _previousBackgroundTexture?.Dispose()`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _queuedBackgroundTexture?.Dispose()`

**赋值（含属性/字段和局部值）：**

- `_backgroundTexture` = `_previousBackgroundTexture = _queuedBackgroundTexture = null`
- `_previousBackgroundTexture` = `_queuedBackgroundTexture = null`
- `_queuedBackgroundTexture` = `null`

<a id="symbol-1801b5d93aa1"></a>

## `NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D) — public void ShowLine(DateSceneLine line, string speaker, Texture2D sprite)`

来源：源码第 365 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** [`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；[`NationalSpire.DateSceneView.EndWaiting()`](DateSceneWaiting.cs.md#symbol-03e797c35180)；[`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；[`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`](DateSceneWaiting.cs.md#symbol-9b17a8ece561)；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.Color.Color(float, float, float, float)`；`Godot.RichTextLabel.ScrollToLine(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.DateSceneView._alpha`；`NationalSpire.DateSceneView._composer`；`NationalSpire.DateSceneView._editFailure`；`NationalSpire.DateSceneView._favourHost`；`NationalSpire.DateSceneView._firstTypeFrame`；`NationalSpire.DateSceneView._hint`；`NationalSpire.DateSceneView._hintDismissed`；`NationalSpire.DateSceneView._jump`；`NationalSpire.DateSceneView._jumpDuration`；`NationalSpire.DateSceneView._jumpHeight`；`NationalSpire.DateSceneView._name`；`NationalSpire.DateSceneView._nameBox`；`NationalSpire.DateSceneView._showAffectionBadge`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._targetAlpha`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView._typing`；`NationalSpire.DateSceneView._waitAction`；`NationalSpire.DateSceneView.EndWaiting()`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.InstantSpeed`；`NationalSpire.DateSceneView.Layout()`；`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateSceneView.TextSpeed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_composer.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _composer.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_editFailure.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _editFailure.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_waitAction.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitAction.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`_text.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _text.Show();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1,1,1,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sprite.Modulate = new Color(1,1,1,0)`
- `Godot.RichTextLabel.ScrollToLine(int)`；输入表达式：`_text.ScrollToLine(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: _text.ScrollToLine(0);`
- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DateScenes.DisplayText(line)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _text.Text = DateScenes.DisplayText(line)`
- `NationalSpire.DateSceneView.EndWaiting()`；输入表达式：`EndWaiting()`；返回值紧邻使用处：`ExpressionStatementSyntax: EndWaiting();`
- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；输入表达式：`RememberSprite(sprite)`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberSprite(sprite);`

**赋值（含属性/字段和局部值）：**

- `_alpha` = `0`
- `_favourHost.Visible` = `_showAffectionBadge`
- `_firstTypeFrame` = `true`
- `_hint.Visible` = `!_hintDismissed`
- `_jump` = `line.Narration ? 0 : _jumpDuration`
- `_jumpDuration` = `line.Emotion == "excited" ? .48f : .28f`
- `_jumpHeight` = `line.Emotion == "excited" ? 23 : 9`
- `_name.Text` = `speaker`
- `_name.Visible` = `_nameBox.Visible = !line.Narration`
- `_nameBox.Visible` = `!line.Narration`
- `_sprite.Modulate` = `new Color(1,1,1,0)`
- `_sprite.Texture` = `sprite`
- `_targetAlpha` = `line.Narration ? 0 : 1`
- `_text.Text` = `DateScenes.DisplayText(line)`
- `_text.VisibleCharacters` = `TextSpeed >= InstantSpeed ? -1 : 0`
- `_typing` = `0`
- `InputMode` = `false`
- `Status.Text` = `""`

<a id="symbol-4f0d075ed97b"></a>

## `NationalSpire.DateSceneView.ShowInput(string, bool) — public void ShowInput(string name, bool keepWaiting = false)`

来源：源码第 382 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditFailedDateScene()`](DateSceneScreen.cs.md#symbol-11eaa513a64e)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** [`NationalSpire.DateSceneView.EndWaiting()`](DateSceneWaiting.cs.md#symbol-03e797c35180)；[`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.Control.GrabFocus()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._composer`；`NationalSpire.DateSceneView._editFailure`；`NationalSpire.DateSceneView._favourHost`；`NationalSpire.DateSceneView._hint`；`NationalSpire.DateSceneView._name`；`NationalSpire.DateSceneView._nameBox`；`NationalSpire.DateSceneView._showAffectionBadge`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView._waitAction`；`NationalSpire.DateSceneView.DialogueHidden`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.EndWaiting()`；`NationalSpire.DateSceneView.HistoryOpen`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.Layout()`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_editFailure.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _editFailure.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_hint.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _hint.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_text.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _text.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_waitAction.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitAction.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`_composer.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _composer.Show();`
- `Godot.CanvasItem.Show()`；输入表达式：`_name.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _name.Show();`
- `Godot.CanvasItem.Show()`；输入表达式：`_nameBox.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _nameBox.Show();`
- `Godot.Control.GrabFocus()`；输入表达式：`Editor.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: Editor.GrabFocus();`
- `NationalSpire.DateSceneView.EndWaiting()`；输入表达式：`EndWaiting()`；返回值紧邻使用处：`ExpressionStatementSyntax: EndWaiting();`
- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`

**赋值（含属性/字段和局部值）：**

- `_favourHost.Visible` = `_showAffectionBadge`
- `_name.Text` = `name`
- `InputMode` = `true`
- `Status.Text` = `""`

<a id="symbol-eecb2292c03b"></a>

## `NationalSpire.DateSceneView.AppendLine(NationalSpire.DateSceneLine) — public void AppendLine(DateSceneLine line)`

来源：源码第 387 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** [`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)

**字段、属性、事件及方法组引用：** `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.DateSceneView._text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DateScenes.DisplayText(line)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateScenes.DisplayText(line)`

**赋值（含属性/字段和局部值）：**

- `_text.Text` = `text`
- `_text.VisibleCharacters` = `visible`

<a id="symbol-e7a96de3c199"></a>

## `NationalSpire.DateSceneView.Streaming(bool) — public void Streaming(bool active)`

来源：源码第 395 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._waitAction`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_waitAction.Text` = `"停止生成"`
- `_waitAction.Visible` = `active`
- `Status.Text` = `active ? "正在续写…" : ""`

<a id="symbol-c6c25a66fde3"></a>

## `NationalSpire.DateSceneView.ShowWaiting(string, bool) — public void ShowWaiting(string status, bool failed = false)`

来源：源码第 400 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)

**调用：** [`NationalSpire.DateSceneView.BeginWaiting()`](DateSceneWaiting.cs.md#symbol-289036db5043)；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._composer`；`NationalSpire.DateSceneView._editFailure`；`NationalSpire.DateSceneView._favourHost`；`NationalSpire.DateSceneView._hint`；`NationalSpire.DateSceneView._name`；`NationalSpire.DateSceneView._nameBox`；`NationalSpire.DateSceneView._showAffectionBadge`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView._waitAction`；`NationalSpire.DateSceneView.BeginWaiting()`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_composer.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _composer.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_hint.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _hint.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_name.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _name.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_nameBox.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _nameBox.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_text.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _text.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`_waitAction.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitAction.Show();`
- `NationalSpire.DateSceneView.BeginWaiting()`；输入表达式：`BeginWaiting()`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginWaiting();`

**赋值（含属性/字段和局部值）：**

- `_editFailure.Visible` = `failed`
- `_favourHost.Visible` = `_showAffectionBadge`
- `_waitAction.Text` = `failed ? "重新生成" : "停止生成"`
- `InputMode` = `false`
- `Status.Text` = `status`

<a id="symbol-f99d5e4e9b59"></a>

## `NationalSpire.DateSceneView.ShowAttachments() — public void ShowAttachments()`

来源：源码第 402 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditFailedDateScene()`](DateSceneScreen.cs.md#symbol-11eaa513a64e)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** `Godot.Node.GetChildCount(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._attachmentScroll`；`NationalSpire.DateSceneView.Attachments`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetChildCount(bool)`；输入表达式：`Attachments.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: Attachments.GetChildCount() > 0`

**赋值（含属性/字段和局部值）：**

- `_attachmentScroll.Visible` = `Attachments.GetChildCount() > 0`

<a id="symbol-e901780018ca"></a>

## `NationalSpire.DateSceneView._Process(double) — public override void _Process(double delta)`

来源：源码第 403 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateSceneView.BeginBackground(Godot.Texture2D, string)`](DateSceneView.cs.md#symbol-99d35c646db1)；[`NationalSpire.DateSceneView.TickWaiting(double)`](DateSceneWaiting.cs.md#symbol-bb1239eb8331)；`Godot.CanvasItem.GetLocalMousePosition()`；`Godot.Color.Color(float, float, float, float)`；`Godot.GodotObject.Dispose()`；`Godot.Mathf.MoveToward(float, float, float)`；`Godot.RichTextLabel.GetTotalCharacterCount()`；`Godot.RichTextLabel.GetVScrollBar()`；`Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；`Godot.Vector2.Vector2(float, float)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`；`System.Math.Min(int, int)`；`System.MathF.Abs(float)`；`System.MathF.Sin(float)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._alpha`；`NationalSpire.DateSceneView._backgroundBlend`；`NationalSpire.DateSceneView._backgroundMaterial`；`NationalSpire.DateSceneView._backgroundPrevious`；`NationalSpire.DateSceneView._firstTypeFrame`；`NationalSpire.DateSceneView._historyScrollPending`；`NationalSpire.DateSceneView._historyText`；`NationalSpire.DateSceneView._jump`；`NationalSpire.DateSceneView._jumpDuration`；`NationalSpire.DateSceneView._jumpHeight`；`NationalSpire.DateSceneView._poll`；`NationalSpire.DateSceneView._previousBackgroundTexture`；`NationalSpire.DateSceneView._queuedBackgroundId`；`NationalSpire.DateSceneView._queuedBackgroundTexture`；`NationalSpire.DateSceneView._settings`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._spriteBaseY`；`NationalSpire.DateSceneView._targetAlpha`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView._typing`；`NationalSpire.DateSceneView._waiting`；`NationalSpire.DateSceneView._waitingDoubleBounce`；`NationalSpire.DateSceneView.BeginBackground(Godot.Texture2D, string)`；`NationalSpire.DateSceneView.Blocked`；`NationalSpire.DateSceneView.DialogueHidden`；`NationalSpire.DateSceneView.HistoryOpen`；`NationalSpire.DateSceneView.InstantSpeed`；`NationalSpire.DateSceneView.TextSpeed`；`NationalSpire.DateSceneView.Tick`；`NationalSpire.DateSceneView.TickWaiting(double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetLocalMousePosition()`；输入表达式：`GetLocalMousePosition()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetLocalMousePosition().Y`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1,1,1,_alpha)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sprite.Modulate = new Color(1,1,1,_alpha)`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1,1,1,Mathf.MoveToward(_settings.Modulate.A, hover ? 1 : 0, (float)delta * 7))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _settings.Modulate = new Color(1,1,1,Mathf.MoveToward(_settings.Modulate.A, hover ? 1 : 0, (float)delta * 7))`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _previousBackgroundTexture?.Dispose()`
- `Godot.Mathf.MoveToward(float, float, float)`；输入表达式：`Mathf.MoveToward(_alpha, _targetAlpha, (float)delta * 4)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _alpha = Mathf.MoveToward(_alpha, _targetAlpha, (float)delta * 4)`
- `Godot.Mathf.MoveToward(float, float, float)`；输入表达式：`Mathf.MoveToward(_settings.Modulate.A, hover ? 1 : 0, (float)delta * 7)`；返回值紧邻使用处：`ArgumentSyntax: Mathf.MoveToward(_settings.Modulate.A, hover ? 1 : 0, (float)delta * 7)`
- `Godot.RichTextLabel.GetTotalCharacterCount()`；输入表达式：`_text.GetTotalCharacterCount()`；返回值紧邻使用处：`ArgumentSyntax: _text.GetTotalCharacterCount()`
- `Godot.RichTextLabel.GetVScrollBar()`；输入表达式：`_historyText.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _historyText.GetVScrollBar().MaxValue`
- `Godot.RichTextLabel.GetVScrollBar()`；输入表达式：`_historyText.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _historyText.GetVScrollBar().Value`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`_backgroundMaterial.SetShaderParameter("fade_alpha", _backgroundBlend)`；返回值紧邻使用处：`ExpressionStatementSyntax: _backgroundMaterial.SetShaderParameter("fade_alpha", _backgroundBlend);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(_sprite.Position.X, _spriteBaseY - (_jump > 0 ? bounce * _jumpHeight : 0))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sprite.Position = new(_sprite.Position.X, _spriteBaseY - (_jump > 0 ? bounce * _jumpHeight : 0))`
- `NationalSpire.DateSceneView.BeginBackground(Godot.Texture2D, string)`；输入表达式：`BeginBackground(queued, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginBackground(queued, id);`
- `NationalSpire.DateSceneView.TickWaiting(double)`；输入表达式：`TickWaiting(delta)`；返回值紧邻使用处：`ExpressionStatementSyntax: TickWaiting(delta);`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Tick?.Invoke()`
- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Blocked?.Invoke()`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, _jump - (float)delta)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _jump = Math.Max(0, _jump - (float)delta)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(1, _backgroundBlend + (float)delta / .45f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _backgroundBlend = Math.Min(1, _backgroundBlend + (float)delta / .45f)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_text.GetTotalCharacterCount(), (int)_typing)`；返回值紧邻使用处：`ConditionalExpressionSyntax: TextSpeed >= InstantSpeed ? -1 : Math.Min(_text.GetTotalCharacterCount(), (int)_typing)`
- `System.MathF.Abs(float)`；输入表达式：`MathF.Abs(MathF.Sin(phase * MathF.PI * (_waitingDoubleBounce ? 2 : 1)))`；返回值紧邻使用处：`ConditionalExpressionSyntax: _waiting ? MathF.Abs(MathF.Sin(phase * MathF.PI * (_waitingDoubleBounce ? 2 : 1)))              : _jumpHeight > 9 ? MathF.Abs(MathF.Sin(phase * MathF.PI * 2)) * (1 - phase * .55f) : MathF.Sin(phase * MathF.PI)`
- `System.MathF.Abs(float)`；输入表达式：`MathF.Abs(MathF.Sin(phase * MathF.PI * 2))`；返回值紧邻使用处：`BinaryExpressionSyntax: MathF.Abs(MathF.Sin(phase * MathF.PI * 2)) * (1 - phase * .55f)`
- `System.MathF.Sin(float)`；输入表达式：`MathF.Sin(phase * MathF.PI * (_waitingDoubleBounce ? 2 : 1))`；返回值紧邻使用处：`ArgumentSyntax: MathF.Sin(phase * MathF.PI * (_waitingDoubleBounce ? 2 : 1))`
- `System.MathF.Sin(float)`；输入表达式：`MathF.Sin(phase * MathF.PI * 2)`；返回值紧邻使用处：`ArgumentSyntax: MathF.Sin(phase * MathF.PI * 2)`
- `System.MathF.Sin(float)`；输入表达式：`MathF.Sin(phase * MathF.PI)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _jumpHeight > 9 ? MathF.Abs(MathF.Sin(phase * MathF.PI * 2)) * (1 - phase * .55f) : MathF.Sin(phase * MathF.PI)`

**赋值（含属性/字段和局部值）：**

- `_alpha` = `Mathf.MoveToward(_alpha, _targetAlpha, (float)delta * 4)`
- `_backgroundBlend` = `Math.Min(1, _backgroundBlend + (float)delta / .45f)`
- `_backgroundPrevious.Texture` = `null`
- `_firstTypeFrame` = `false`
- `_historyText.GetVScrollBar().Value` = `_historyText.GetVScrollBar().MaxValue`
- `_jump` = `Math.Max(0, _jump - (float)delta)`
- `_poll` += `delta`
- `_poll` = `0`
- `_previousBackgroundTexture` = `null`
- `_queuedBackgroundId` = `""`
- `_queuedBackgroundTexture` = `null`
- `_settings.Modulate` = `new Color(1,1,1,Mathf.MoveToward(_settings.Modulate.A, hover ? 1 : 0, (float)delta * 7))`
- `_sprite.Modulate` = `new Color(1,1,1,_alpha)`
- `_sprite.Position` = `new(_sprite.Position.X, _spriteBaseY - (_jump > 0 ? bounce * _jumpHeight : 0))`
- `_text.VisibleCharacters` = `TextSpeed >= InstantSpeed ? -1 : Math.Min(_text.GetTotalCharacterCount(), (int)_typing)`
- `_typing` += `delta * TextSpeed`

<a id="symbol-6826c700a52c"></a>

## `NationalSpire.DateChoiceButton.Caption — public string Caption`

来源：源码第 439 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-69a824616bcd"></a>

## `NationalSpire.DateChoiceButton.Subtitle — public string Subtitle`

来源：源码第 440 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-70ed57d7136f"></a>

## `NationalSpire.DateChoiceButton.Public — public bool Public`

来源：源码第 441 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3644c38e1546"></a>

## `NationalSpire.DateChoiceButton._Ready() — public override void _Ready()`

来源：源码第 442 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride(state, new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride(state, new StyleBoxEmpty());`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`

**赋值（含属性/字段和局部值）：**

- `FocusEntered` += `QueueRedraw`
- `FocusExited` += `QueueRedraw`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseEntered` += `QueueRedraw`
- `MouseExited` += `QueueRedraw`
- `Resized` += `QueueRedraw`

<a id="symbol-424dfaee9c25"></a>

## `NationalSpire.DateChoiceButton._Draw() — public override void _Draw()`

来源：源码第 448 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.BaseButton.IsHovered()`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；`Godot.Color.Color(string)`；`Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；`Godot.Control.HasFocus()`；`Godot.Font.GetAscent(int)`；`Godot.Font.GetDescent(int)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateChoiceButton.Caption`；`NationalSpire.DateChoiceButton.Public`；`NationalSpire.DateChoiceButton.Subtitle`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([star + new Vector2(0, -5), star + new Vector2(2, -1), star + new Vector2(5, 0), star + new Vector2(2, 1), star + new Vector2(0, 5), star + new Vector2(-2, 1), star + new Vector2(-5, 0), star + new Vector2(-2, -1)], accent)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([star + new Vector2(0, -5), star + new Vector2(2, -1), star + new Vector2(5, 0), star + new Vector2(2, 1), star + new Vector2(0, 5), star + new Vector2(-2, 1), star + new Vector2(-5, 0), star + new Vector2(-2, -1)], accent);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(polygon, new Color(Public ? hover ? "4d4335" : "34333a" : hover ? "52394e" : "352c42"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(polygon, new Color(Public ? hover ? "4d4335" : "34333a" : hover ? "52394e" : "352c42"));`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([..polygon, polygon[0]], accent with { A = hover ? 1 : .65f }, 1.4f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([..polygon, polygon[0]], accent with { A = hover ? 1 : .65f }, 1.4f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([c + new Vector2(-r, -r * .6f), c + new Vector2(0, r * .15f), c + new Vector2(r, -r * .6f)], accent, 1.4f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([c + new Vector2(-r, -r * .6f), c + new Vector2(0, r * .15f), c + new Vector2(r, -r * .6f)], accent, 1.4f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([c + new Vector2(-r, -r * .6f), c + new Vector2(r, -r * .6f), c + new Vector2(r, r * .6f), c + new Vector2(-r, r * .6f), c + new Vector2(-r, -r * .6f)], accent, 1.4f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([c + new Vector2(-r, -r * .6f), c + new Vector2(r, -r * .6f), c + new Vector2(r, r * .6f), c + new Vector2(-r, r * .6f), c + new Vector2(-r, -r * .6f)], accent, 1.4f, true);`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, new(14, 121), Subtitle, HorizontalAlignment.Center, w - 28, 15, new Color("c8bccb"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, new(14, 121), Subtitle, HorizontalAlignment.Center, w - 28, 15, new Color("c8bccb"));`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, new(large ? (w - tw) / 2 : 45, large ? 88 : (h + font.GetAscent(size) - font.GetDescent(size)) / 2), Caption, fontSize: size, modulate: accent)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, new(large ? (w - tw) / 2 : 45, large ? 88 : (h + font.GetAscent(size) - font.GetDescent(size)) / 2), Caption, fontSize: size, modulate: accent);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("c8bccb")`；返回值紧邻使用处：`ArgumentSyntax: new Color("c8bccb")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(Public ? hover ? "4d4335" : "34333a" : hover ? "52394e" : "352c42")`；返回值紧邻使用处：`ArgumentSyntax: new Color(Public ? hover ? "4d4335" : "34333a" : hover ? "52394e" : "352c42")`
- `Godot.Color.Color(string)`；输入表达式：`new(Public ? "e4c98e" : "e5b1cd")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new(Public ? "e4c98e" : "e5b1cd")`
- `Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；输入表达式：`GetThemeFont("font")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetThemeFont("font")`
- `Godot.Control.HasFocus()`；输入表达式：`HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `Godot.Font.GetAscent(int)`；输入表达式：`font.GetAscent(size)`；返回值紧邻使用处：`BinaryExpressionSyntax: h + font.GetAscent(size)`
- `Godot.Font.GetDescent(int)`；输入表达式：`font.GetDescent(size)`；返回值紧邻使用处：`BinaryExpressionSyntax: h + font.GetAscent(size) - font.GetDescent(size)`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`font.GetStringSize(Caption, fontSize: size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: font.GetStringSize(Caption, fontSize: size).X`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-2, -1)`；返回值紧邻使用处：`BinaryExpressionSyntax: star + new Vector2(-2, -1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-2, 1)`；返回值紧邻使用处：`BinaryExpressionSyntax: star + new Vector2(-2, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-5, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: star + new Vector2(-5, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-r, -r * .6f)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(-r, -r * .6f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-r, r * .6f)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(-r, r * .6f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, -5)`；返回值紧邻使用处：`BinaryExpressionSyntax: star + new Vector2(0, -5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 5)`；返回值紧邻使用处：`BinaryExpressionSyntax: star + new Vector2(0, 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, r * .15f)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(0, r * .15f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(2, -1)`；返回值紧邻使用处：`BinaryExpressionSyntax: star + new Vector2(2, -1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(2, 1)`；返回值紧邻使用处：`BinaryExpressionSyntax: star + new Vector2(2, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(5, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: star + new Vector2(5, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(r + 7, -r)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(r + 7, -r)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(r, -r * .6f)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(r, -r * .6f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(r, r * .6f)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(r, r * .6f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(1, cut)`；返回值紧邻使用处：`ExpressionElementSyntax: new(1, cut)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(1, h - 1)`；返回值紧邻使用处：`ExpressionElementSyntax: new(1, h - 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(14, 121)`；返回值紧邻使用处：`ArgumentSyntax: new(14, 121)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(25, h / 2)`；返回值紧邻使用处：`ConditionalExpressionSyntax: large ? new(w / 2, 40) : new(25, h / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(cut, 1)`；返回值紧邻使用处：`ExpressionElementSyntax: new(cut, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(large ? (w - tw) / 2 : 45, large ? 88 : (h + font.GetAscent(size) - font.GetDescent(size)) / 2)`；返回值紧邻使用处：`ArgumentSyntax: new(large ? (w - tw) / 2 : 45, large ? 88 : (h + font.GetAscent(size) - font.GetDescent(size)) / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w - 1, 1)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w - 1, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w - 1, h - cut)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w - 1, h - cut)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w - cut, h - 1)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w - cut, h - 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w / 2, 40)`；返回值紧邻使用处：`ConditionalExpressionSyntax: large ? new(w / 2, 40) : new(25, h / 2)`

**赋值（含属性/字段和局部值）：**

- `A` = `hover ? 1 : .65f`
