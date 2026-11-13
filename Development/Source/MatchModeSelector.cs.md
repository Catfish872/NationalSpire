# MatchModeSelector.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A3F960CCE56E1C48CFDB13E58EAA6054F8071789B05C1D23C314EA076DCF12DF`。来源：[源码](../../MatchModeSelector.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MatchModeSelector`。

字段、事件及初始值（源码原样）：

```csharp
public event Action<string, int>? Changed;
private readonly Dictionary<string, int> _levels = [];
private readonly Dictionary<string, Button> _modes = [];
private static readonly Dictionary<string, Texture2D> CenteredIcons = [];
private Label _number = null!, _name = null!;
private Button _previous = null!, _next = null!;
private int _required;
private bool _editable;
```

<a id="symbol-5fccfe2639ac"></a>

## `NationalSpire.MatchModeSelector.Mode — public string Mode`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Standard`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-40d6d4889c96"></a>

## `NationalSpire.MatchModeSelector.Level — public int Level`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModeSelector._levels`；`NationalSpire.MatchModeSelector.Mode`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-eb2e7b96be62"></a>

## `NationalSpire.MatchModeSelector.RecordedAscension — public int RecordedAscension`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MatchModes.RecordedAscension(string, int)`](MatchModes.cs.md#symbol-8f51795c3dbb)

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.RecordedAscension(string, int)`；`NationalSpire.MatchModeSelector.Level`；`NationalSpire.MatchModeSelector.Mode`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchModes.RecordedAscension(string, int)`；输入表达式：`MatchModes.RecordedAscension(Mode, Level)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => MatchModes.RecordedAscension(Mode, Level)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4f90e83b12de"></a>

## `NationalSpire.MatchModeSelector.MatchModeSelector() — public MatchModeSelector()`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-40bbec50deea"></a>

## `NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool) — public MatchModeSelector(CareerData data, CareerMatch match, bool editable = true)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateGameStartDialog(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-c88ac7d5c81a)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.MatchModes.Name(string)`](MatchModes.cs.md#symbol-a1829e04c6f6)；[`NationalSpire.MatchModes.Preferred(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchModes.cs.md#symbol-a20fef0677c1)；[`NationalSpire.MatchModes.PreferredLevel(NationalSpire.CareerData, NationalSpire.CareerMatch, string)`](MatchModes.cs.md#symbol-e35c7590a177)；[`NationalSpire.MatchModeSelector.Adjust(int)`](MatchModeSelector.cs.md#symbol-01759e00270d)；[`NationalSpire.MatchModeSelector.Arrow(string, System.Action)`](MatchModeSelector.cs.md#symbol-e175821844f6)；[`NationalSpire.MatchModeSelector.CenteredIcon(string)`](MatchModeSelector.cs.md#symbol-f8a59e5b517b)；[`NationalSpire.MatchModeSelector.Refresh()`](MatchModeSelector.cs.md#symbol-a545b72dd8c3)；[`NationalSpire.MatchModeSelector.Style(string, bool, bool)`](MatchModeSelector.cs.md#symbol-3fbe9ce98195)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Button.Button()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.MatchModes.All`；`NationalSpire.MatchModes.Available(string)`；`NationalSpire.MatchModes.Blitz`；`NationalSpire.MatchModes.Dread`；`NationalSpire.MatchModes.Name(string)`；`NationalSpire.MatchModes.Preferred(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.MatchModes.PreferredLevel(NationalSpire.CareerData, NationalSpire.CareerMatch, string)`；`NationalSpire.MatchModeSelector._editable`；`NationalSpire.MatchModeSelector._levels`；`NationalSpire.MatchModeSelector._modes`；`NationalSpire.MatchModeSelector._name`；`NationalSpire.MatchModeSelector._next`；`NationalSpire.MatchModeSelector._number`；`NationalSpire.MatchModeSelector._previous`；`NationalSpire.MatchModeSelector._required`；`NationalSpire.MatchModeSelector.Adjust(int)`；`NationalSpire.MatchModeSelector.Arrow(string, System.Action)`；`NationalSpire.MatchModeSelector.CenteredIcon(string)`；`NationalSpire.MatchModeSelector.Changed`；`NationalSpire.MatchModeSelector.Level`；`NationalSpire.MatchModeSelector.Mode`；`NationalSpire.MatchModeSelector.Refresh()`；`NationalSpire.MatchModeSelector.Style(string, bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`button.SetPressedNoSignal(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetPressedNoSignal(true);`
- `Godot.Button.Button()`；输入表达式：`new Button { Name = mode + "Mode", Icon = CenteredIcon(path), IconAlignment = HorizontalAlignment.Center, ExpandIcon = true, ToggleMode = true,                 TooltipText = MatchModes.Name(mode), Disabled = !editable, CustomMinimumSize = new(46, 44),                 FocusMode = FocusModeEnum.None }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = mode + "Mode", Icon = CenteredIcon(path), IconAlignment = HorizontalAlignment.Center, ExpandIcon = true, ToggleMode = true,                 TooltipText = MatchModes.Name(mode), Disabled = !editable, CustomMinimumSize = new(46, 44),                 FocusMode = FocusModeEnum.None }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeConstantOverride("icon_max_width", 30)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeConstantOverride("icon_max_width", 30);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_name.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: _name.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_number.AddThemeFontSizeOverride("font_size", 28)`；返回值紧邻使用处：`ExpressionStatementSyntax: _number.AddThemeFontSizeOverride("font_size", 28);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("disabled", Style(mode, false, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("disabled", Style(mode, false, false));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover_pressed", Style(mode, true, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover_pressed", Style(mode, true, true));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover", Style(mode, false, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover", Style(mode, false, true));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", Style(mode, false, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", Style(mode, false, false));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("pressed", Style(mode, true, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("pressed", Style(mode, true, false));`
- `Godot.Label.Label()`；输入表达式：`new Label { CustomMinimumSize = new(82, 0), VerticalAlignment = VerticalAlignment.Center }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _name = new Label { CustomMinimumSize = new(82, 0), VerticalAlignment = VerticalAlignment.Center }`
- `Godot.Label.Label()`；输入表达式：`new Label { Name = "MatchAscension", CustomMinimumSize = new(40, 44),             HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _number = new Label { Name = "MatchAscension", CustomMinimumSize = new(40, 44),             HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_name)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_next)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_next);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_number)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_number);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_previous);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(button);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(40, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(40, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(46, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(46, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(82, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(82, 0)`
- `NationalSpire.MatchModes.Name(string)`；输入表达式：`MatchModes.Name(mode)`；返回值紧邻使用处：`AssignmentExpressionSyntax: TooltipText = MatchModes.Name(mode)`
- `NationalSpire.MatchModes.Preferred(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchModes.Preferred(data, match)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Mode = MatchModes.Preferred(data, match)`
- `NationalSpire.MatchModes.PreferredLevel(NationalSpire.CareerData, NationalSpire.CareerMatch, string)`；输入表达式：`MatchModes.PreferredLevel(data, match, mode)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _levels[mode] = MatchModes.PreferredLevel(data, match, mode)`
- `NationalSpire.MatchModeSelector.Adjust(int)`；输入表达式：`Adjust(-1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Adjust(-1)`
- `NationalSpire.MatchModeSelector.Adjust(int)`；输入表达式：`Adjust(1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Adjust(1)`
- `NationalSpire.MatchModeSelector.Arrow(string, System.Action)`；输入表达式：`Arrow("left", () => Adjust(-1))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _previous = Arrow("left", () => Adjust(-1))`
- `NationalSpire.MatchModeSelector.Arrow(string, System.Action)`；输入表达式：`Arrow("right", () => Adjust(1))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _next = Arrow("right", () => Adjust(1))`
- `NationalSpire.MatchModeSelector.CenteredIcon(string)`；输入表达式：`CenteredIcon(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Icon = CenteredIcon(path)`
- `NationalSpire.MatchModeSelector.Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `NationalSpire.MatchModeSelector.Style(string, bool, bool)`；输入表达式：`Style(mode, false, false)`；返回值紧邻使用处：`ArgumentSyntax: Style(mode, false, false)`
- `NationalSpire.MatchModeSelector.Style(string, bool, bool)`；输入表达式：`Style(mode, false, true)`；返回值紧邻使用处：`ArgumentSyntax: Style(mode, false, true)`
- `NationalSpire.MatchModeSelector.Style(string, bool, bool)`；输入表达式：`Style(mode, true, false)`；返回值紧邻使用处：`ArgumentSyntax: Style(mode, true, false)`
- `NationalSpire.MatchModeSelector.Style(string, bool, bool)`；输入表达式：`Style(mode, true, true)`；返回值紧邻使用处：`ArgumentSyntax: Style(mode, true, true)`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke(Mode, Level)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Changed?.Invoke(Mode, Level)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_modes.Add(mode, button)`；返回值紧邻使用处：`ExpressionStatementSyntax: _modes.Add(mode, button);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`MatchModes.All.Where(MatchModes.Available)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string mode in MatchModes.All.Where(MatchModes.Available))         {             _levels[mode] = MatchModes.PreferredLevel(data, match, mode);             string path = mode switch             {                 MatchModes.Blitz => "res://images/packed/character_select/blitz_top_bar_icon.png",                 MatchModes.Dread => "res://images/packed/character_select/dread_top_bar_icon.png",                 _ => "res://images/atlases/ui_atlas.sprites/top_bar/top_bar_ascension.tres"             };             var button = new Button { Name = mode + "Mode", Icon = CenteredIcon(path), IconAlignment = HorizontalAlignment.Center, ExpandIcon = true, ToggleMode = true,                 TooltipText = MatchModes.Name(mode), Disabled = !editable, CustomMinimumSize = new(46, 44),                 FocusMode = FocusModeEnum.None };             button.AddThemeConstantOverride("icon_max_width", 30);             button.AddThemeStyleboxOverride("normal", Style(mode, false, false));             button.AddThemeStyleboxOverride("disabled", Style(mode, false, false));             button.AddThemeStyleboxOverride("hover", Style(mode, false, true));             button.AddThemeStyleboxOverride("pressed", Style(mode, true, false));             button.AddThemeStyleboxOverride("hover_pressed", Style(mode, true, true));             button.Pressed += () =>             {                 if (Mode == mode) { button.SetPressedNoSignal(true); return; }                 Mode = mode; Refresh(); Changed?.Invoke(Mode, Level);             };             _modes.Add(mode, button); AddChild(button);         }`

**赋值（含属性/字段和局部值）：**

- `_editable` = `editable`
- `_levels[mode]` = `MatchModes.PreferredLevel(data, match, mode)`
- `_name` = `new Label { CustomMinimumSize = new(82, 0), VerticalAlignment = VerticalAlignment.Center }`
- `_next` = `Arrow("right", () => Adjust(1))`
- `_number` = `new Label { Name = "MatchAscension", CustomMinimumSize = new(40, 44),             HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center }`
- `_previous` = `Arrow("left", () => Adjust(-1))`
- `_required` = `match.RequiredAscension`
- `button.Pressed` += `() =>             {                 if (Mode == mode) { button.SetPressedNoSignal(true); return; }                 Mode = mode; Refresh(); Changed?.Invoke(Mode, Level);             }`
- `CustomMinimumSize` = `new(40, 44)`
- `CustomMinimumSize` = `new(46, 44)`
- `CustomMinimumSize` = `new(82, 0)`
- `Disabled` = `!editable`
- `ExpandIcon` = `true`
- `FocusMode` = `FocusModeEnum.None`
- `HorizontalAlignment` = `HorizontalAlignment.Center`
- `Icon` = `CenteredIcon(path)`
- `IconAlignment` = `HorizontalAlignment.Center`
- `Mode` = `MatchModes.Preferred(data, match)`
- `Mode` = `mode`
- `Name` = `"MatchAscension"`
- `Name` = `"MatchModeSelector"`
- `Name` = `mode + "Mode"`
- `ToggleMode` = `true`
- `TooltipText` = `MatchModes.Name(mode)`
- `VerticalAlignment` = `VerticalAlignment.Center`

<a id="symbol-c02fca14b28d"></a>

## `NationalSpire.MatchModeSelector.Tint(string) — private static Color Tint(string mode)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModeSelector.Refresh()`](MatchModeSelector.cs.md#symbol-a545b72dd8c3)；[`NationalSpire.MatchModeSelector.Style(string, bool, bool)`](MatchModeSelector.cs.md#symbol-3fbe9ce98195)

**调用：** `Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Blitz`；`NationalSpire.MatchModes.Dread`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new(mode switch     { MatchModes.Blitz => "71daca", MatchModes.Dread => "df9bb7", _ => "e9ba79" })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(mode switch     { MatchModes.Blitz => "71daca", MatchModes.Dread => "df9bb7", _ => "e9ba79" })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f8a59e5b517b"></a>

## `NationalSpire.MatchModeSelector.CenteredIcon(string) — private static Texture2D CenteredIcon(string path)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModeSelector.Arrow(string, System.Action)`](MatchModeSelector.cs.md#symbol-e175821844f6)；[`NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](MatchModeSelector.cs.md#symbol-40bbec50deea)

**调用：** `Godot.AtlasTexture.AtlasTexture()`；`Godot.Image.GetUsedRect()`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`Godot.Texture2D.GetImage()`；`Godot.Texture2D.GetSize()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModeSelector.CenteredIcons`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.AtlasTexture.AtlasTexture()`；输入表达式：`new AtlasTexture { Atlas = texture, Region = region, Margin = new Rect2(padding / 2, padding) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new AtlasTexture { Atlas = texture, Region = region, Margin = new Rect2(padding / 2, padding) }`
- `Godot.Image.GetUsedRect()`；输入表达式：`image.GetUsedRect()`；返回值紧邻使用处：`AssignmentExpressionSyntax: region = image.GetUsedRect()`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(padding / 2, padding)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Margin = new Rect2(padding / 2, padding)`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<Texture2D>(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ResourceLoader.Load<Texture2D>(path)`
- `Godot.Texture2D.GetImage()`；输入表达式：`original.GetImage()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = original.GetImage()`
- `Godot.Texture2D.GetSize()`；输入表达式：`original.GetSize()`；返回值紧邻使用处：`BinaryExpressionSyntax: original.GetSize() - region.Size`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`CenteredIcons.Add(path, centered)`；返回值紧邻使用处：`ExpressionStatementSyntax: CenteredIcons.Add(path, centered);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`CenteredIcons.TryGetValue(path, out var cached)`；返回值紧邻使用处：`IfStatementSyntax: if (CenteredIcons.TryGetValue(path, out var cached)) return cached;`

**赋值（含属性/字段和局部值）：**

- `Atlas` = `texture`
- `Margin` = `new Rect2(padding / 2, padding)`
- `padding` = `atlas.Margin.Size`
- `padding` = `original.GetSize() - region.Size`
- `region` = `atlas.Region`
- `region` = `image.GetUsedRect()`
- `Region` = `region`
- `texture` = `atlas.Atlas`
- `texture` = `original`

<a id="symbol-3fbe9ce98195"></a>

## `NationalSpire.MatchModeSelector.Style(string, bool, bool) — private static StyleBoxFlat Style(string mode, bool selected, bool hover)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](MatchModeSelector.cs.md#symbol-40bbec50deea)

**调用：** [`NationalSpire.MatchModeSelector.Tint(string)`](MatchModeSelector.cs.md#symbol-c02fca14b28d)；`Godot.Color.Color(Godot.Color, float)`；`Godot.StyleBoxFlat.StyleBoxFlat()`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModeSelector.Tint(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new(color, .9f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: BorderColor = new(color, .9f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new(color, selected ? hover ? .22f : .14f : hover ? .09f : 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: BgColor = new(color, selected ? hover ? .22f : .14f : hover ? .09f : 0)`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat { BgColor = new(color, selected ? hover ? .22f : .14f : hover ? .09f : 0),             BorderColor = new(color, .9f), BorderWidthBottom = selected ? 2 : 0,             CornerRadiusTopLeft = 7, CornerRadiusTopRight = 7, CornerRadiusBottomLeft = 7, CornerRadiusBottomRight = 7,             ContentMarginLeft = 7, ContentMarginRight = 7, ContentMarginTop = 5, ContentMarginBottom = 5 }`；返回值紧邻使用处：`ReturnStatementSyntax: return new StyleBoxFlat { BgColor = new(color, selected ? hover ? .22f : .14f : hover ? .09f : 0),             BorderColor = new(color, .9f), BorderWidthBottom = selected ? 2 : 0,             CornerRadiusTopLeft = 7, CornerRadiusTopRight = 7, CornerRadiusBottomLeft = 7, CornerRadiusBottomRight = 7,             ContentMarginLeft = 7, ContentMarginRight = 7, ContentMarginTop = 5, ContentMarginBottom = 5 };`
- `NationalSpire.MatchModeSelector.Tint(string)`；输入表达式：`Tint(mode)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Tint(mode)`

**赋值（含属性/字段和局部值）：**

- `BgColor` = `new(color, selected ? hover ? .22f : .14f : hover ? .09f : 0)`
- `BorderColor` = `new(color, .9f)`
- `BorderWidthBottom` = `selected ? 2 : 0`
- `ContentMarginBottom` = `5`
- `ContentMarginLeft` = `7`
- `ContentMarginRight` = `7`
- `ContentMarginTop` = `5`
- `CornerRadiusBottomLeft` = `7`
- `CornerRadiusBottomRight` = `7`
- `CornerRadiusTopLeft` = `7`
- `CornerRadiusTopRight` = `7`

<a id="symbol-e175821844f6"></a>

## `NationalSpire.MatchModeSelector.Arrow(string, System.Action) — private Button Arrow(string direction, Action action)`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](MatchModeSelector.cs.md#symbol-40bbec50deea)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.MatchModeSelector.CenteredIcon(string)`](MatchModeSelector.cs.md#symbol-f8a59e5b517b)；`Godot.Button.Button()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.MatchModeSelector.CenteredIcon(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = "Ascension" + direction, ExpandIcon = true, CustomMinimumSize = new(30, 38),             Icon = CenteredIcon("res://images/atlases/ui_atlas.sprites/settings_tiny_" + direction + "_arrow.tres"), IconAlignment = HorizontalAlignment.Center,             FocusMode = FocusModeEnum.None }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = "Ascension" + direction, ExpandIcon = true, CustomMinimumSize = new(30, 38),             Icon = CenteredIcon("res://images/atlases/ui_atlas.sprites/settings_tiny_" + direction + "_arrow.tres"), IconAlignment = HorizontalAlignment.Center,             FocusMode = FocusModeEnum.None }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeConstantOverride("icon_max_width", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeConstantOverride("icon_max_width", 16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("disabled", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("disabled", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("29475466", "00000000", 5, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("29475466", "00000000", 5, 4));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("34596999", "00000000", 5, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("34596999", "00000000", 5, 4));`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(30, 38)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(30, 38)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("29475466", "00000000", 5, 4)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("29475466", "00000000", 5, 4)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("34596999", "00000000", 5, 4)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("34596999", "00000000", 5, 4)`
- `NationalSpire.MatchModeSelector.CenteredIcon(string)`；输入表达式：`CenteredIcon("res://images/atlases/ui_atlas.sprites/settings_tiny_" + direction + "_arrow.tres")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Icon = CenteredIcon("res://images/atlases/ui_atlas.sprites/settings_tiny_" + direction + "_arrow.tres")`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `action`
- `CustomMinimumSize` = `new(30, 38)`
- `ExpandIcon` = `true`
- `FocusMode` = `FocusModeEnum.None`
- `Icon` = `CenteredIcon("res://images/atlases/ui_atlas.sprites/settings_tiny_" + direction + "_arrow.tres")`
- `IconAlignment` = `HorizontalAlignment.Center`
- `Name` = `"Ascension" + direction`

<a id="symbol-01759e00270d"></a>

## `NationalSpire.MatchModeSelector.Adjust(int) — private void Adjust(int change)`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](MatchModeSelector.cs.md#symbol-40bbec50deea)

**调用：** [`NationalSpire.MatchModes.Maximum(string)`](MatchModes.cs.md#symbol-1f84e144cf3c)；[`NationalSpire.MatchModes.Minimum(string, int)`](MatchModes.cs.md#symbol-438383af5a8b)；[`NationalSpire.MatchModeSelector.Refresh()`](MatchModeSelector.cs.md#symbol-a545b72dd8c3)；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Maximum(string)`；`NationalSpire.MatchModes.Minimum(string, int)`；`NationalSpire.MatchModeSelector._levels`；`NationalSpire.MatchModeSelector._required`；`NationalSpire.MatchModeSelector.Changed`；`NationalSpire.MatchModeSelector.Level`；`NationalSpire.MatchModeSelector.Mode`；`NationalSpire.MatchModeSelector.Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchModes.Maximum(string)`；输入表达式：`MatchModes.Maximum(Mode)`；返回值紧邻使用处：`ArgumentSyntax: MatchModes.Maximum(Mode)`
- `NationalSpire.MatchModes.Minimum(string, int)`；输入表达式：`MatchModes.Minimum(Mode, _required)`；返回值紧邻使用处：`ArgumentSyntax: MatchModes.Minimum(Mode, _required)`
- `NationalSpire.MatchModeSelector.Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke(Mode, Level)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Changed?.Invoke(Mode, Level)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(Level + change, MatchModes.Minimum(Mode, _required), MatchModes.Maximum(Mode))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _levels[Mode] = Math.Clamp(Level + change, MatchModes.Minimum(Mode, _required), MatchModes.Maximum(Mode))`

**赋值（含属性/字段和局部值）：**

- `_levels[Mode]` = `Math.Clamp(Level + change, MatchModes.Minimum(Mode, _required), MatchModes.Maximum(Mode))`

<a id="symbol-a545b72dd8c3"></a>

## `NationalSpire.MatchModeSelector.Refresh() — private void Refresh()`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModeSelector.Adjust(int)`](MatchModeSelector.cs.md#symbol-01759e00270d)；[`NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](MatchModeSelector.cs.md#symbol-40bbec50deea)

**调用：** [`NationalSpire.MatchModes.Maximum(string)`](MatchModes.cs.md#symbol-1f84e144cf3c)；[`NationalSpire.MatchModes.Minimum(string, int)`](MatchModes.cs.md#symbol-438383af5a8b)；[`NationalSpire.MatchModes.Name(string)`](MatchModes.cs.md#symbol-a1829e04c6f6)；[`NationalSpire.MatchModeSelector.Tint(string)`](MatchModeSelector.cs.md#symbol-c02fca14b28d)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Color.Color(float, float, float, float)`；`int.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Dread`；`NationalSpire.MatchModes.Maximum(string)`；`NationalSpire.MatchModes.Minimum(string, int)`；`NationalSpire.MatchModes.Name(string)`；`NationalSpire.MatchModeSelector._editable`；`NationalSpire.MatchModeSelector._modes`；`NationalSpire.MatchModeSelector._name`；`NationalSpire.MatchModeSelector._next`；`NationalSpire.MatchModeSelector._number`；`NationalSpire.MatchModeSelector._previous`；`NationalSpire.MatchModeSelector._required`；`NationalSpire.MatchModeSelector.Level`；`NationalSpire.MatchModeSelector.Mode`；`NationalSpire.MatchModeSelector.Tint(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`button.SetPressedNoSignal(mode == Mode)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetPressedNoSignal(mode == Mode);`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, _next.Disabled ? .25f : .9f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _next.Modulate = new Color(1, 1, 1, _next.Disabled ? .25f : .9f)`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, _previous.Disabled ? .25f : .9f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _previous.Modulate = new Color(1, 1, 1, _previous.Disabled ? .25f : .9f)`
- `int.ToString()`；输入表达式：`Level.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _number.Text = Level.ToString()`
- `NationalSpire.MatchModes.Maximum(string)`；输入表达式：`MatchModes.Maximum(Mode)`；返回值紧邻使用处：`BinaryExpressionSyntax: Level >= MatchModes.Maximum(Mode)`
- `NationalSpire.MatchModes.Minimum(string, int)`；输入表达式：`MatchModes.Minimum(Mode, _required)`；返回值紧邻使用处：`BinaryExpressionSyntax: Level <= MatchModes.Minimum(Mode, _required)`
- `NationalSpire.MatchModes.Name(string)`；输入表达式：`MatchModes.Name(Mode)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _name.Text = MatchModes.Name(Mode)`
- `NationalSpire.MatchModeSelector.Tint(string)`；输入表达式：`Tint(Mode)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _name.Modulate = Tint(Mode)`
- `NationalSpire.MatchModeSelector.Tint(string)`；输入表达式：`Tint(Mode)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _number.Modulate = Tint(Mode)`

**赋值（含属性/字段和局部值）：**

- `_name.Modulate` = `Tint(Mode)`
- `_name.Text` = `MatchModes.Name(Mode)`
- `_next.Disabled` = `!_editable || Mode == MatchModes.Dread || Level >= MatchModes.Maximum(Mode)`
- `_next.Modulate` = `new Color(1, 1, 1, _next.Disabled ? .25f : .9f)`
- `_number.Modulate` = `Tint(Mode)`
- `_number.Text` = `Level.ToString()`
- `_previous.Disabled` = `!_editable || Mode == MatchModes.Dread || Level <= MatchModes.Minimum(Mode, _required)`
- `_previous.Modulate` = `new Color(1, 1, 1, _previous.Disabled ? .25f : .9f)`
