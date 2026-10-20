# MarketVisuals.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0BFE123FA666E6AC0C9B2D72A9BB56C48B120FA4BEAC0610074B3A8430BF7790`。来源：[源码](../../MarketVisuals.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketVisuals`、`NationalSpire.MarketAssetButton`、`NationalSpire.MarketEventRow`、`NationalSpire.DevelopmentGauge`、`NationalSpire.MarketPositionCard`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<(string, bool, bool), StyleBoxFlat> Cards = [];
private static readonly Dictionary<(string, int), StyleBoxFlat> Actions = [];
private readonly Label _name = new(), _sector = new(), _price = new(), _change = new();
private readonly TextureRect _icon = new() { CustomMinimumSize = new(23, 23), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
        StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
private readonly Label _day = new(), _title = new(), _change = new();
private readonly Label _title = new(), _terms = new(), _profit = new(), _proceeds = new(), _preview = new();
private readonly TextureRect _icon = new() { CustomMinimumSize = new(24, 24), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
        StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
private readonly Button _close;
private readonly HBoxContainer _actions = new();
private readonly VBoxContainer _editor = new() { Visible = false };
private readonly MarketAmountInput _input = new() { MinValue = 0, MaxValue = long.MaxValue * 10.0, AllowGreater = true, SizeFlagsHorizontal = SizeFlags.ExpandFill };
private readonly Button _apply, _clear;
private readonly Action<MarketOrder> _submit;
private MarketPosition? _position;
private MarketQuote? _quote;
private long _revision;
private bool _margin;
```

<a id="symbol-7251a1de5493"></a>

## `NationalSpire.MarketVisuals.Accent(string) — public static Color Accent(string sector)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketAssetButton.Bind(NationalSpire.MarketAsset, NationalSpire.MarketQuote, bool, bool)`](MarketVisuals.cs.md#symbol-4e16b3f4bac4)；[`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`](MarketVisuals.cs.md#symbol-fd36a7e27494)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)；[`NationalSpire.MarketVisuals.ActionStyle(Godot.Button, string)`](MarketVisuals.cs.md#symbol-5703b8242580)；[`NationalSpire.MarketVisuals.Card(string, bool, bool)`](MarketVisuals.cs.md#symbol-aef7b9c00c48)

**调用：** `Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new(sector switch {          "训练装备" => "e4b367", "电竞设备" => "a99aef", "日常消费" or "做多" => "70d4bc", "做空" => "f095a3", _ => "81b8ec" })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(sector switch {          "训练装备" => "e4b367", "电竞设备" => "a99aef", "日常消费" or "做多" => "70d4bc", "做空" => "f095a3", _ => "81b8ec" })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-aef7b9c00c48"></a>

## `NationalSpire.MarketVisuals.Card(string, bool, bool) — public static StyleBoxFlat Card(string sector, bool selected, bool hover = false)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`](MarketVisuals.cs.md#symbol-fd36a7e27494)；[`NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`](MarketVisuals.cs.md#symbol-7d1876899194)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.MarketVisuals.Accent(string)`](MarketVisuals.cs.md#symbol-7251a1de5493)；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Color.Lerp(Godot.Color, float)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.MarketVisuals.Accent(string)`；`NationalSpire.MarketVisuals.Cards`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(accent, selected ? .95f : hover ? .65f : .26f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BorderColor = new Color(accent, selected ? .95f : hover ? .65f : .26f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(new Color("10202d").Lerp(accent, selected ? .19f : hover ? .13f : .055f), .94f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BgColor = new Color(new Color("10202d").Lerp(accent, selected ? .19f : hover ? .13f : .055f), .94f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("10202d")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Color("10202d").Lerp`
- `Godot.Color.Lerp(Godot.Color, float)`；输入表达式：`new Color("10202d").Lerp(accent, selected ? .19f : hover ? .13f : .055f)`；返回值紧邻使用处：`ArgumentSyntax: new Color("10202d").Lerp(accent, selected ? .19f : hover ? .13f : .055f)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0e1e2b", "345363", 9, 12)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style = CareerVisuals.Box("0e1e2b", "345363", 9, 12)`
- `NationalSpire.MarketVisuals.Accent(string)`；输入表达式：`Accent(sector)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Accent(sector)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Cards.TryGetValue(key, out var style)`；返回值紧邻使用处：`IfStatementSyntax: if (Cards.TryGetValue(key, out var style)) return style;`

**赋值（含属性/字段和局部值）：**

- `Cards[key]` = `style`
- `style.BgColor` = `new Color(new Color("10202d").Lerp(accent, selected ? .19f : hover ? .13f : .055f), .94f)`
- `style.BorderColor` = `new Color(accent, selected ? .95f : hover ? .65f : .26f)`
- `style.BorderWidthLeft` = `selected ? 4 : 3`
- `style` = `CareerVisuals.Box("0e1e2b", "345363", 9, 12)`

<a id="symbol-7d1876899194"></a>

## `NationalSpire.MarketVisuals.Style(Godot.Button, string, bool) — public static void Style(Button button, string sector, bool selected = false)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketAssetButton.Bind(NationalSpire.MarketAsset, NationalSpire.MarketQuote, bool, bool)`](MarketVisuals.cs.md#symbol-4e16b3f4bac4)；[`NationalSpire.MarketEventRow.MarketEventRow()`](MarketVisuals.cs.md#symbol-b32cc5c2b62a)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)

**调用：** [`NationalSpire.MarketVisuals.Card(string, bool, bool)`](MarketVisuals.cs.md#symbol-aef7b9c00c48)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketVisuals.Card(string, bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover", Card(sector, selected, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover", Card(sector, selected, true));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", Card(sector, selected))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", Card(sector, selected));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("pressed", Card(sector, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("pressed", Card(sector, true));`
- `NationalSpire.MarketVisuals.Card(string, bool, bool)`；输入表达式：`Card(sector, selected, true)`；返回值紧邻使用处：`ArgumentSyntax: Card(sector, selected, true)`
- `NationalSpire.MarketVisuals.Card(string, bool, bool)`；输入表达式：`Card(sector, selected)`；返回值紧邻使用处：`ArgumentSyntax: Card(sector, selected)`
- `NationalSpire.MarketVisuals.Card(string, bool, bool)`；输入表达式：`Card(sector, true)`；返回值紧邻使用处：`ArgumentSyntax: Card(sector, true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5703b8242580"></a>

## `NationalSpire.MarketVisuals.ActionStyle(Godot.Button, string) — public static void ActionStyle(Button button, string action)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketVisuals.Accent(string)`](MarketVisuals.cs.md#symbol-7251a1de5493)；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Color.Lerp(Godot.Color, float)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.MarketVisuals.Accent(string)`；`NationalSpire.MarketVisuals.Actions`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(accent, .65f + strength * .15f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BorderColor = new Color(accent, .65f + strength * .15f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("10232f")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Color("10232f").Lerp`
- `Godot.Color.Lerp(Godot.Color, float)`；输入表达式：`new Color("10232f").Lerp(accent, .12f + strength * .09f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BgColor = new Color("10232f").Lerp(accent, .12f + strength * .09f)`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride(state == "normal" ? "font_color" : "font_" + state + "_color", accent)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride(state == "normal" ? "font_color" : "font_" + state + "_color", accent);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, style)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, style);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(0, 48)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("10232f", "345363", 7, 10)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style = CareerVisuals.Box("10232f", "345363", 7, 10)`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(action)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.Icon = LifestyleArt.Icon(action)`
- `NationalSpire.MarketVisuals.Accent(string)`；输入表达式：`Accent(action)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Accent(action)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Actions.TryGetValue((action, strength), out var style)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Actions.TryGetValue((action, strength), out var style)`

**赋值（含属性/字段和局部值）：**

- `Actions[(action, strength)]` = `style`
- `button.CustomMinimumSize` = `new(0, 48)`
- `button.Icon` = `LifestyleArt.Icon(action)`
- `style.BgColor` = `new Color("10232f").Lerp(accent, .12f + strength * .09f)`
- `style.BorderColor` = `new Color(accent, .65f + strength * .15f)`
- `style` = `CareerVisuals.Box("10232f", "345363", 7, 10)`

<a id="symbol-0f0bdceb25d3"></a>

## `NationalSpire.MarketVisuals.LevelColor(int) — public static Color LevelColor(int level)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.DevelopmentGauge._Draw()`](MarketVisuals.cs.md#symbol-9e79a21d518d)

**调用：** `Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new(level switch {          <= 2 => "b96c7c", <= 4 => "e4ab65", <= 6 => "70d4bc", <= 8 => "ad9ded", _ => "f0cf85" })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(level switch {          <= 2 => "b96c7c", <= 4 => "e4ab65", <= 6 => "70d4bc", <= 8 => "ad9ded", _ => "f0cf85" })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3e8aa8ef1217"></a>

## `NationalSpire.MarketAssetButton.MarketAssetButton() — internal MarketAssetButton()`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAssetButton._change`；`NationalSpire.MarketAssetButton._icon`；`NationalSpire.MarketAssetButton._name`；`NationalSpire.MarketAssetButton._price`；`NationalSpire.MarketAssetButton._sector`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("e5eef2")`；返回值紧邻使用处：`ArgumentSyntax: new Color("e5eef2")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_name.AddThemeColorOverride("font_color", new Color("e5eef2"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _name.AddThemeColorOverride("font_color", new Color("e5eef2"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + side, side == "left" ? 14 : 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + side, side == "left" ? 14 : 9);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", label == _sector ? 12 : 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", label == _sector ? 12 : 16);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(_sector)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(_sector);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(quote)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(quote);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(_icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(_icon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(_name)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(_name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`quote.AddChild(_change)`；返回值紧邻使用处：`ExpressionStatementSyntax: quote.AddChild(_change);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`quote.AddChild(_price)`；返回值紧邻使用处：`ExpressionStatementSyntax: quote.AddChild(_price);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 92)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 92)`

**赋值（含属性/字段和局部值）：**

- `_change.HorizontalAlignment` = `HorizontalAlignment.Right`
- `_name.SizeFlagsStretchRatio` = `5`
- `CustomMinimumSize` = `new(0, 92)`
- `label.ClipText` = `true`
- `label.MouseFilter` = `MouseFilterEnum.Ignore`
- `label.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-4e16b3f4bac4"></a>

## `NationalSpire.MarketAssetButton.Bind(NationalSpire.MarketAsset, NationalSpire.MarketQuote, bool, bool) — internal void Bind(MarketAsset asset, MarketQuote quote, bool watched, bool selected)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshList()`](MarketTerminal.cs.md#symbol-38f64566d7c6)

**调用：** [`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-9439f9696cab)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketVisuals.Accent(string)`](MarketVisuals.cs.md#symbol-7251a1de5493)；[`NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`](MarketVisuals.cs.md#symbol-7d1876899194)；`decimal.ToString(string?)`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketAsset.Sector`；`NationalSpire.MarketAssetButton._change`；`NationalSpire.MarketAssetButton._icon`；`NationalSpire.MarketAssetButton._name`；`NationalSpire.MarketAssetButton._price`；`NationalSpire.MarketAssetButton._sector`；`NationalSpire.MarketQuote.Previous`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketVisuals.Accent(string)`；`NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`quote.Price.ToString("0.0000")`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? quote.Price.ToString("0.0000") : CareerMoney.Compact(quote.Price)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("f095a3")`；返回值紧邻使用处：`ConditionalExpressionSyntax: change >= 0 ? CareerVisuals.Teal : new Color("f095a3")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_change.AddThemeColorOverride("font_color", change >= 0 ? CareerVisuals.Teal : new Color("f095a3"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _change.AddThemeColorOverride("font_color", change >= 0 ? CareerVisuals.Teal : new Color("f095a3"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_sector.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector))`；返回值紧邻使用处：`ExpressionStatementSyntax: _sector.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector));`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(quote.Price)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? quote.Price.ToString("0.0000") : CareerMoney.Compact(quote.Price)`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(asset.Sector)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _icon.Texture = LifestyleArt.Icon(asset.Sector)`
- `NationalSpire.MarketVisuals.Accent(string)`；输入表达式：`MarketVisuals.Accent(asset.Sector)`；返回值紧邻使用处：`ArgumentSyntax: MarketVisuals.Accent(asset.Sector)`
- `NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`；输入表达式：`MarketVisuals.Style(this, asset.Sector, selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketVisuals.Style(this, asset.Sector, selected);`

**赋值（含属性/字段和局部值）：**

- `_change.Text` = `$"{change:+0.00%;-0.00%;0.00%}"`
- `_icon.Texture` = `LifestyleArt.Icon(asset.Sector)`
- `_name.Text` = `(watched ? "★ " : "") + asset.Name`
- `_price.Text` = `asset.Forex ? quote.Price.ToString("0.0000") : CareerMoney.Compact(quote.Price)`
- `_sector.Text` = `asset.Country + "  /  " + asset.Sector`
- `TooltipText` = `asset.Name + " · " + asset.Country + " · " + asset.Sector`

<a id="symbol-b32cc5c2b62a"></a>

## `NationalSpire.MarketEventRow.MarketEventRow() — internal MarketEventRow()`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`](MarketVisuals.cs.md#symbol-7d1876899194)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Muted`；`NationalSpire.MarketEventRow._change`；`NationalSpire.MarketEventRow._day`；`NationalSpire.MarketEventRow._title`；`NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_day.AddThemeColorOverride("font_color", CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _day.AddThemeColorOverride("font_color", CareerVisuals.Muted);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + side, 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + side, 8);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", label == _day ? 12 : 15)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", label == _day ? 12 : 15);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(_change)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(_change);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(text);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`text.AddChild(_day)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddChild(_day);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`text.AddChild(_title)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddChild(_title);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 62)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 62)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(72, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _change.CustomMinimumSize = new(72, 0)`
- `NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`；输入表达式：`MarketVisuals.Style(this, "", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketVisuals.Style(this, "", false);`

**赋值（含属性/字段和局部值）：**

- `_change.CustomMinimumSize` = `new(72, 0)`
- `_change.HorizontalAlignment` = `HorizontalAlignment.Right`
- `_change.VerticalAlignment` = `VerticalAlignment.Center`
- `_title.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `_title.MaxLinesVisible` = `2`
- `_title.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `CustomMinimumSize` = `new(0, 62)`
- `label.MouseFilter` = `MouseFilterEnum.Ignore`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-a69640a62077"></a>

## `NationalSpire.MarketEventRow.Bind(NationalSpire.CareerData, NationalSpire.MarketEvent, string) — internal void Bind(CareerData data, MarketEvent item, string title)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)

**调用：** [`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`double.ToString(string?)`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.MarketEvent.Change`；`NationalSpire.MarketEvent.Day`；`NationalSpire.MarketEvent.Person`；`NationalSpire.MarketEventRow._change`；`NationalSpire.MarketEventRow._day`；`NationalSpire.MarketEventRow._title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `double.ToString(string?)`；输入表达式：`item.Change.ToString("+0.00%;-0.00%;0.00%")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _change.Text = item.Change.ToString("+0.00%;-0.00%;0.00%")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("f095a3")`；返回值紧邻使用处：`ConditionalExpressionSyntax: item.Change >= 0 ? CareerVisuals.Teal : new Color("f095a3")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_change.AddThemeColorOverride("font_color", item.Change >= 0 ? CareerVisuals.Teal : new Color("f095a3"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _change.AddThemeColorOverride("font_color", item.Change >= 0 ? CareerVisuals.Teal : new Color("f095a3"));`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, item.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, item.Day)}`

**赋值（含属性/字段和局部值）：**

- `_change.Text` = `item.Change.ToString("+0.00%;-0.00%;0.00%")`
- `_day.Text` = `$"{GameCalendar.Text(data, item.Day)}"`
- `_title.Text` = `title`
- `MouseDefaultCursorShape` = `item.Person.Length > 0 ? CursorShape.PointingHand : CursorShape.Arrow`

<a id="symbol-2ed7d2937cd4"></a>

## `NationalSpire.DevelopmentGauge.Level — public int Level`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8fcafb01d662"></a>

## `NationalSpire.DevelopmentGauge.Enhancement — public double Enhancement`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-91afc5ed8f86"></a>

## `NationalSpire.DevelopmentGauge.DevelopmentGauge() — public DevelopmentGauge()`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 16)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 16)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 16)`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-9e79a21d518d"></a>

## `NationalSpire.DevelopmentGauge._Draw() — public override void _Draw()`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketVisuals.LevelColor(int)`](MarketVisuals.cs.md#symbol-0f0bdceb25d3)；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Gold`；`NationalSpire.DevelopmentGauge.Enhancement`；`NationalSpire.DevelopmentGauge.Level`；`NationalSpire.MarketVisuals.LevelColor(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(0, 0), new(Size.X, 0), new Color(CareerVisuals.Gold, .65f), 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(0, 0), new(Size.X, 0), new Color(CareerVisuals.Gold, .65f), 2);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(0, Size.Y - 4, Size.X * (float)Enhancement, 3), CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(0, Size.Y - 4, Size.X * (float)Enhancement, 3), CareerVisuals.Gold);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(rect, i < Level ? color : new Color("0b1822"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(rect, i < Level ? color : new Color("0b1822"));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；输入表达式：`DrawRect(rect, new Color(color, i < Level ? .8f : .22f), false, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(rect, new Color(color, i < Level ? .8f : .22f), false, 1);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(CareerVisuals.Gold, .65f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(CareerVisuals.Gold, .65f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(color, i < Level ? .8f : .22f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(color, i < Level ? .8f : .22f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0b1822")`；返回值紧邻使用处：`ConditionalExpressionSyntax: i < Level ? color : new Color("0b1822")`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(0, Size.Y - 4, Size.X * (float)Enhancement, 3)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(0, Size.Y - 4, Size.X * (float)Enhancement, 3)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(i * (width + 4), 1, width, Size.Y - 2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(i * (width + 4), 1, width, Size.Y - 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 0)`；返回值紧邻使用处：`ArgumentSyntax: new(0, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X, 0)`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X, 0)`
- `NationalSpire.MarketVisuals.LevelColor(int)`；输入表达式：`MarketVisuals.LevelColor(Level)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketVisuals.LevelColor(Level)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-66bfead77ff7"></a>

## `NationalSpire.MarketPositionCard.MarketPositionCard(System.Action, System.Action<NationalSpire.MarketOrder>) — internal MarketPositionCard(Action close, Action<MarketOrder> submit)`

来源：源码第 157 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`ActionButton(string, string, System.Action)`](MarketVisuals.cs.md#symbol-183827086673)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketPositionCard.Edit(bool)`](MarketVisuals.cs.md#symbol-cbcb21a0a9e2)；[`NationalSpire.MarketPositionCard.Preview()`](MarketVisuals.cs.md#symbol-5a8785632454)；[`NationalSpire.MarketPositionCard.Send(NationalSpire.MarketOrder)`](MarketVisuals.cs.md#symbol-75caf63f639d)；`Godot.Button.Button()`；`Godot.CanvasItem.Hide()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`

**字段、属性、事件及方法组引用：** `ActionButton(string, string, System.Action)`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.MarketPosition.Id`；`NationalSpire.MarketPositionCard._actions`；`NationalSpire.MarketPositionCard._apply`；`NationalSpire.MarketPositionCard._clear`；`NationalSpire.MarketPositionCard._close`；`NationalSpire.MarketPositionCard._editor`；`NationalSpire.MarketPositionCard._icon`；`NationalSpire.MarketPositionCard._input`；`NationalSpire.MarketPositionCard._position`；`NationalSpire.MarketPositionCard._preview`；`NationalSpire.MarketPositionCard._proceeds`；`NationalSpire.MarketPositionCard._profit`；`NationalSpire.MarketPositionCard._revision`；`NationalSpire.MarketPositionCard._submit`；`NationalSpire.MarketPositionCard._terms`；`NationalSpire.MarketPositionCard._title`；`NationalSpire.MarketPositionCard.Apply()`；`NationalSpire.MarketPositionCard.Edit(bool)`；`NationalSpire.MarketPositionCard.Preview()`；`NationalSpire.MarketPositionCard.Send(NationalSpire.MarketOrder)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `ActionButton(string, string, System.Action)`；输入表达式：`ActionButton("取消止损", "清除", () => Send(new("stop", Position: _position!.Id, QuoteRevision: _revision)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _clear = ActionButton("取消止损", "清除", () => Send(new("stop", Position: _position!.Id, QuoteRevision: _revision)))`
- `ActionButton(string, string, System.Action)`；输入表达式：`ActionButton("确认追加", "确认", Apply)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _apply = ActionButton("确认追加", "确认", Apply)`
- `ActionButton(string, string, System.Action)`；输入表达式：`ActionButton("设置止损", "交易市场", () => Edit(false))`；返回值紧邻使用处：`ArgumentSyntax: ActionButton("设置止损", "交易市场", () => Edit(false))`
- `ActionButton(string, string, System.Action)`；输入表达式：`ActionButton("收起", "收起", () => _editor.Hide())`；返回值紧邻使用处：`ArgumentSyntax: ActionButton("收起", "收起", () => _editor.Hide())`
- `ActionButton(string, string, System.Action)`；输入表达式：`ActionButton("追加保证金", "外汇", () => Edit(true))`；返回值紧邻使用处：`ArgumentSyntax: ActionButton("追加保证金", "外汇", () => Edit(true))`
- `Godot.Button.Button()`；输入表达式：`new Button { Text = "平仓", Icon = LifestyleArt.Icon("交易市场"), CustomMinimumSize = new(80, 36) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _close = new Button { Text = "平仓", Icon = LifestyleArt.Icon("交易市场"), CustomMinimumSize = new(80, 36) }`
- `Godot.CanvasItem.Hide()`；输入表达式：`_editor.Hide()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => _editor.Hide()`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_terms.AddThemeColorOverride("font_color", CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _terms.AddThemeColorOverride("font_color", CareerVisuals.Muted);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", label == _title ? 18 : 15)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", label == _title ? 18 : 15);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_actions.AddChild(ActionButton("设置止损", "交易市场", () => Edit(false)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _actions.AddChild(ActionButton("设置止损", "交易市场", () => Edit(false)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_actions.AddChild(ActionButton("追加保证金", "外汇", () => Edit(true)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _actions.AddChild(ActionButton("追加保证金", "外汇", () => Edit(true)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_editor.AddChild(_input)`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.AddChild(_input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_editor.AddChild(_preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.AddChild(_preview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_editor.AddChild(buttons)`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.AddChild(buttons);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(_actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(_actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(_editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(_editor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(_proceeds)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(_proceeds);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(_profit)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(_profit);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(_terms)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(_terms);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(_apply)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(_apply);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(_clear)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(_clear);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(ActionButton("收起", "收起", () => _editor.Hide()))`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(ActionButton("收起", "收起", () => _editor.Hide()));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(_close)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(_close);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(_icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(_icon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(_title)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(_title);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(80, 36)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(80, 36)`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon("交易市场")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Icon = LifestyleArt.Icon("交易市场")`
- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new("stop", Position: _position!.Id, QuoteRevision: _revision)`；返回值紧邻使用处：`ArgumentSyntax: new("stop", Position: _position!.Id, QuoteRevision: _revision)`
- `NationalSpire.MarketPositionCard.Edit(bool)`；输入表达式：`Edit(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Edit(false)`
- `NationalSpire.MarketPositionCard.Edit(bool)`；输入表达式：`Edit(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Edit(true)`
- `NationalSpire.MarketPositionCard.Preview()`；输入表达式：`Preview()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Preview()`
- `NationalSpire.MarketPositionCard.Send(NationalSpire.MarketOrder)`；输入表达式：`Send(new("stop", Position: _position!.Id, QuoteRevision: _revision))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Send(new("stop", Position: _position!.Id, QuoteRevision: _revision))`

**赋值（含属性/字段和局部值）：**

- `_apply` = `ActionButton("确认追加", "确认", Apply)`
- `_clear` = `ActionButton("取消止损", "清除", () => Send(new("stop", Position: _position!.Id, QuoteRevision: _revision)))`
- `_close.Pressed` += `close`
- `_close` = `new Button { Text = "平仓", Icon = LifestyleArt.Icon("交易市场"), CustomMinimumSize = new(80, 36) }`
- `_input.ValueChanged` += `_ => Preview()`
- `_submit` = `submit`
- `CustomMinimumSize` = `new(80, 36)`
- `Icon` = `LifestyleArt.Icon("交易市场")`
- `label.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `label.MouseFilter` = `MouseFilterEnum.Ignore`
- `label.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `"平仓"`

<a id="symbol-183827086673"></a>

## `ActionButton(string, string, System.Action) — Button ActionButton(string title, string icon, Action action)`

来源：源码第 167 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketPositionCard.MarketPositionCard(System.Action, System.Action<NationalSpire.MarketOrder>)`](MarketVisuals.cs.md#symbol-66bfead77ff7)

**调用：** [`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；`Godot.Button.Button()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.LifestyleArt.Icon(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = title, Icon = LifestyleArt.Icon(icon), SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 36) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = title, Icon = LifestyleArt.Icon(icon), SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 36) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 36)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 36)`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(icon)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Icon = LifestyleArt.Icon(icon)`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `action`
- `CustomMinimumSize` = `new(0, 36)`
- `Icon` = `LifestyleArt.Icon(icon)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `title`

<a id="symbol-fd36a7e27494"></a>

## `NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool) — internal void Bind(MarketPosition? p, MarketQuote? quote, long revision = 0, MarketExecution.Exit? projected = null, bool pending = false)`

来源：源码第 187 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshAccount(bool)`](MarketTerminal.cs.md#symbol-9559baf40113)；[`NationalSpire.MarketTerminal.Unbind()`](MarketTerminal.cs.md#symbol-76844d4631c4)

**调用：** [`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-9439f9696cab)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerMoney.Format(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-c64f7b9abf31)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)；[`NationalSpire.MarketPositionCard.Price(decimal)`](MarketVisuals.cs.md#symbol-acc535d1e8c4)；[`NationalSpire.MarketQuote.ExecutionCopy()`](CareerMarketData.cs.md#symbol-0dd7cd2eabdc)；[`NationalSpire.MarketVisuals.Accent(string)`](MarketVisuals.cs.md#symbol-7251a1de5493)；[`NationalSpire.MarketVisuals.Card(string, bool, bool)`](MarketVisuals.cs.md#symbol-aef7b9c00c48)；`decimal.ToString(string?)`；`Godot.CanvasItem.Hide()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerMoney.Format(NationalSpire.MarketNumber)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketAsset.Sector`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Exit.Fee`；`NationalSpire.MarketExecution.Exit.Fill`；`NationalSpire.MarketExecution.Exit.Proceeds`；`NationalSpire.MarketExecution.Exit.Profit`；`NationalSpire.MarketExecution.Fill.Average`；`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Entry`；`NationalSpire.MarketPosition.ExecutionVersion`；`NationalSpire.MarketPosition.Leverage`；`NationalSpire.MarketPosition.Margin`；`NationalSpire.MarketPosition.StopPrice`；`NationalSpire.MarketPosition.Units`；`NationalSpire.MarketPositionCard._actions`；`NationalSpire.MarketPositionCard._close`；`NationalSpire.MarketPositionCard._editor`；`NationalSpire.MarketPositionCard._icon`；`NationalSpire.MarketPositionCard._position`；`NationalSpire.MarketPositionCard._proceeds`；`NationalSpire.MarketPositionCard._profit`；`NationalSpire.MarketPositionCard._quote`；`NationalSpire.MarketPositionCard._revision`；`NationalSpire.MarketPositionCard._terms`；`NationalSpire.MarketPositionCard._title`；`NationalSpire.MarketPositionCard.Price(decimal)`；`NationalSpire.MarketQuote.ExecutionCopy()`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketVisuals.Accent(string)`；`NationalSpire.MarketVisuals.Card(string, bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`exit.Fill.Average.ToString("0.00000")`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? exit.Fill.Average.ToString("0.00000") : CareerMoney.Compact(exit.Fill.Average)`
- `Godot.CanvasItem.Hide()`；输入表达式：`_editor.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.Hide();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("f095a3")`；返回值紧邻使用处：`ConditionalExpressionSyntax: profit >= 0 ? CareerVisuals.Teal : new Color("f095a3")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_profit.AddThemeColorOverride("font_color", profit >= 0 ? CareerVisuals.Teal : new Color("f095a3"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _profit.AddThemeColorOverride("font_color", profit >= 0 ? CareerVisuals.Teal : new Color("f095a3"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_title.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector))`；返回值紧邻使用处：`ExpressionStatementSyntax: _title.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("panel", MarketVisuals.Card(asset.Sector, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("panel", MarketVisuals.Card(asset.Sector, false));`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(exit.Fee)`；返回值紧邻使用处：`BinaryExpressionSyntax: "预计成交均价 " + (asset.Forex ? exit.Fill.Average.ToString("0.00000") : CareerMoney.Compact(exit.Fill.Average))              + "\n平仓手续费 " + CareerMoney.Compact(exit.Fee)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(exit.Fill.Average)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? exit.Fill.Average.ToString("0.00000") : CareerMoney.Compact(exit.Fill.Average)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(exit.Proceeds)`；返回值紧邻使用处：`BinaryExpressionSyntax: "预计成交均价 " + (asset.Forex ? exit.Fill.Average.ToString("0.00000") : CareerMoney.Compact(exit.Fill.Average))              + "\n平仓手续费 " + CareerMoney.Compact(exit.Fee) + " · 预计到账 " + CareerMoney.Compact(exit.Proceeds)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(p.Entry * p.Units)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Compact(p.Entry * p.Units)}`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(p.Margin)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Compact(p.Margin)}`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(profit)`；返回值紧邻使用处：`BinaryExpressionSyntax: "平仓预计净盈亏 " + (profit > 0 ? "+" : "") + CareerMoney.Compact(profit)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(exit.Proceeds)`；返回值紧邻使用处：`BinaryExpressionSyntax: "平仓手续费 " + CareerMoney.Format(exit.Fee) + " · 预计到账 " + CareerMoney.Format(exit.Proceeds)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(p.Margin)`；返回值紧邻使用处：`BinaryExpressionSyntax: "保证金 " + CareerMoney.Format(p.Margin)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(profit)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _profit.TooltipText = CareerMoney.Format(profit)`
- `NationalSpire.CareerMoney.Format(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Format(exit.Fee)`；返回值紧邻使用处：`BinaryExpressionSyntax: "平仓手续费 " + CareerMoney.Format(exit.Fee)`
- `NationalSpire.CareerMoney.Format(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Format(p.Entry * p.Units)`；返回值紧邻使用处：`BinaryExpressionSyntax: "保证金 " + CareerMoney.Format(p.Margin) + " · 初始仓位 " + CareerMoney.Format(p.Entry * p.Units)`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(asset.Sector)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _icon.Texture = LifestyleArt.Icon(asset.Sector)`
- `NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.Close(p, quote!)`；返回值紧邻使用处：`BinaryExpressionSyntax: projected ?? MarketExecution.Close(p, quote!)`
- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(quote)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _quote.Price = MarketExecution.ReferencePrice(quote)`
- `NationalSpire.MarketPositionCard.Price(decimal)`；输入表达式：`Price(p.Entry)`；返回值紧邻使用处：`BinaryExpressionSyntax: $"保证金 {CareerMoney.Compact(p.Margin)}  ·  初始仓位 {CareerMoney.Compact(p.Entry * p.Units)}\n建仓价 "              + Price(p.Entry)`
- `NationalSpire.MarketPositionCard.Price(decimal)`；输入表达式：`Price(stop)`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.StopPrice is { } stop ? Price(stop) : "未设置"`
- `NationalSpire.MarketQuote.ExecutionCopy()`；输入表达式：`quote.ExecutionCopy()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _quote = quote.ExecutionCopy()`
- `NationalSpire.MarketVisuals.Accent(string)`；输入表达式：`MarketVisuals.Accent(asset.Sector)`；返回值紧邻使用处：`ArgumentSyntax: MarketVisuals.Accent(asset.Sector)`
- `NationalSpire.MarketVisuals.Card(string, bool, bool)`；输入表达式：`MarketVisuals.Card(asset.Sector, false)`；返回值紧邻使用处：`ArgumentSyntax: MarketVisuals.Card(asset.Sector, false)`

**赋值（含属性/字段和局部值）：**

- `_actions.Visible` = `p != null`
- `_close.Visible` = `_icon.Visible = _terms.Visible = _profit.Visible = _proceeds.Visible = p != null`
- `_icon.Texture` = `LifestyleArt.Icon(asset.Sector)`
- `_icon.Visible` = `_terms.Visible = _profit.Visible = _proceeds.Visible = p != null`
- `_position` = `p`
- `_proceeds.MouseFilter` = `MouseFilterEnum.Pass`
- `_proceeds.Text` = `""`
- `_proceeds.Text` = `"预计成交均价 " + (asset.Forex ? exit.Fill.Average.ToString("0.00000") : CareerMoney.Compact(exit.Fill.Average))              + "\n平仓手续费 " + CareerMoney.Compact(exit.Fee) + " · 预计到账 " + CareerMoney.Compact(exit.Proceeds)`
- `_proceeds.TooltipText` = `"平仓手续费 " + CareerMoney.Format(exit.Fee) + " · 预计到账 " + CareerMoney.Format(exit.Proceeds)`
- `_proceeds.Visible` = `p != null`
- `_profit.MouseFilter` = `_proceeds.MouseFilter = MouseFilterEnum.Pass`
- `_profit.Text` = `"平仓预计净盈亏 " + (profit > 0 ? "+" : "") + CareerMoney.Compact(profit)`
- `_profit.Text` = `"正在计算平仓报价"`
- `_profit.TooltipText` = `CareerMoney.Format(profit)`
- `_profit.Visible` = `_proceeds.Visible = p != null`
- `_quote.Price` = `MarketExecution.ReferencePrice(quote)`
- `_quote` = `quote.ExecutionCopy()`
- `_quote` = `quote`
- `_revision` = `revision`
- `_terms.MouseFilter` = `_profit.MouseFilter = _proceeds.MouseFilter = MouseFilterEnum.Pass`
- `_terms.Text` = `$"保证金 {CareerMoney.Compact(p.Margin)}  ·  初始仓位 {CareerMoney.Compact(p.Entry * p.Units)}\n建仓价 "              + Price(p.Entry) + " · 止损 " + (p.StopPrice is { } stop ? Price(stop) : "未设置")`
- `_terms.TooltipText` = `"保证金 " + CareerMoney.Format(p.Margin) + " · 初始仓位 " + CareerMoney.Format(p.Entry * p.Units)`
- `_terms.Visible` = `_profit.Visible = _proceeds.Visible = p != null`
- `_title.Text` = `"暂无持仓"`
- `_title.Text` = `asset.Name + $"  ·  {(p.Direction > 0 ? "做多 ↑" : "做空 ↓")}  开仓 {p.Leverage}×"`

<a id="symbol-acc535d1e8c4"></a>

## `NationalSpire.MarketPositionCard.Price(decimal) — private string Price(decimal value)`

来源：源码第 211 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`](MarketVisuals.cs.md#symbol-fd36a7e27494)；[`NationalSpire.MarketPositionCard.Preview()`](MarketVisuals.cs.md#symbol-5a8785632454)

**调用：** [`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-9439f9696cab)；`decimal.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPositionCard._position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`value.ToString("0.00000")`；返回值紧邻使用处：`ConditionalExpressionSyntax: MarketCatalog.ById[_position!.Asset].Forex ? value.ToString("0.00000") : CareerMoney.Compact(value)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MarketCatalog.ById[_position!.Asset].Forex ? value.ToString("0.00000") : CareerMoney.Compact(value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f728ef30cb62"></a>

## `NationalSpire.MarketPositionCard.DisplayScale — private decimal DisplayScale`

来源：源码第 212 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPositionCard._position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-cbcb21a0a9e2"></a>

## `NationalSpire.MarketPositionCard.Edit(bool) — private void Edit(bool margin)`

来源：源码第 213 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketPositionCard.MarketPositionCard(System.Action, System.Action<NationalSpire.MarketOrder>)`](MarketVisuals.cs.md#symbol-66bfead77ff7)

**调用：** [`NationalSpire.MarketAmountInput.SetAmount(decimal)`](MarketAmountInput.cs.md#symbol-b73158988cf2)；[`NationalSpire.MarketPositionCard.Preview()`](MarketVisuals.cs.md#symbol-5a8785632454)；`Godot.CanvasItem.Show()`；`Godot.Control.GrabFocus()`；`Godot.SpinBox.GetLineEdit()`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAmountInput.SetAmount(decimal)`；`NationalSpire.MarketPosition.StopPrice`；`NationalSpire.MarketPositionCard._apply`；`NationalSpire.MarketPositionCard._clear`；`NationalSpire.MarketPositionCard._editor`；`NationalSpire.MarketPositionCard._input`；`NationalSpire.MarketPositionCard._margin`；`NationalSpire.MarketPositionCard._position`；`NationalSpire.MarketPositionCard._quote`；`NationalSpire.MarketPositionCard.DisplayScale`；`NationalSpire.MarketPositionCard.Preview()`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`_editor.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.Show();`
- `Godot.Control.GrabFocus()`；输入表达式：`_input.GetLineEdit().GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: _input.GetLineEdit().GrabFocus();`
- `Godot.SpinBox.GetLineEdit()`；输入表达式：`_input.GetLineEdit()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _input.GetLineEdit().GrabFocus`
- `NationalSpire.MarketAmountInput.SetAmount(decimal)`；输入表达式：`_input.SetAmount(margin ? 0 : (_position.StopPrice ?? _quote!.Price) * DisplayScale)`；返回值紧邻使用处：`ExpressionStatementSyntax: _input.SetAmount(margin ? 0 : (_position.StopPrice ?? _quote!.Price) * DisplayScale);`
- `NationalSpire.MarketPositionCard.Preview()`；输入表达式：`Preview()`；返回值紧邻使用处：`ExpressionStatementSyntax: Preview();`

**赋值（含属性/字段和局部值）：**

- `_apply.Text` = `margin ? "确认追加" : "保存止损"`
- `_clear.Visible` = `!margin && _position.StopPrice != null`
- `_input.Prefix` = `margin || DisplayScale == 10 ? "$" : ""`
- `_input.Step` = `margin || DisplayScale == 10 ? .01 : .00001`
- `_margin` = `margin`

<a id="symbol-5a8785632454"></a>

## `NationalSpire.MarketPositionCard.Preview() — private void Preview()`

来源：源码第 223 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketPositionCard.Edit(bool)`](MarketVisuals.cs.md#symbol-cbcb21a0a9e2)；[`NationalSpire.MarketPositionCard.MarketPositionCard(System.Action, System.Action<NationalSpire.MarketOrder>)`](MarketVisuals.cs.md#symbol-66bfead77ff7)

**调用：** [`Leverage(NationalSpire.MarketNumber)`](MarketVisuals.cs.md#symbol-160df92af6e9)；[`NationalSpire.CareerMarket.Equity(NationalSpire.MarketPosition, decimal)`](CareerMarket.cs.md#symbol-3e50cb7c29a1)；[`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-9439f9696cab)；[`NationalSpire.MarketPositionCard.Price(decimal)`](MarketVisuals.cs.md#symbol-acc535d1e8c4)

**字段、属性、事件及方法组引用：** `Leverage(NationalSpire.MarketNumber)`；`NationalSpire.CareerMarket.Equity(NationalSpire.MarketPosition, decimal)`；`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；`NationalSpire.MarketAmountInput.Amount`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Margin`；`NationalSpire.MarketPositionCard._input`；`NationalSpire.MarketPositionCard._margin`；`NationalSpire.MarketPositionCard._position`；`NationalSpire.MarketPositionCard._preview`；`NationalSpire.MarketPositionCard._quote`；`NationalSpire.MarketPositionCard.Price(decimal)`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Leverage(NationalSpire.MarketNumber)`；输入表达式：`Leverage(equity + addition)`；返回值紧邻使用处：`BinaryExpressionSyntax: "保证金 " + CareerMoney.Compact(_position.Margin) + " → " + CareerMoney.Compact(_position.Margin + addition)              + "\n实际杠杆 " + Leverage(equity) + " → " + Leverage(equity + addition)`
- `Leverage(NationalSpire.MarketNumber)`；输入表达式：`Leverage(equity)`；返回值紧邻使用处：`BinaryExpressionSyntax: "保证金 " + CareerMoney.Compact(_position.Margin) + " → " + CareerMoney.Compact(_position.Margin + addition)              + "\n实际杠杆 " + Leverage(equity)`
- `NationalSpire.CareerMarket.Equity(NationalSpire.MarketPosition, decimal)`；输入表达式：`CareerMarket.Equity(_position, _quote!.Price)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerMarket.Equity(_position, _quote!.Price)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(_position.Margin + addition)`；返回值紧邻使用处：`BinaryExpressionSyntax: "保证金 " + CareerMoney.Compact(_position.Margin) + " → " + CareerMoney.Compact(_position.Margin + addition)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(_position.Margin)`；返回值紧邻使用处：`BinaryExpressionSyntax: "保证金 " + CareerMoney.Compact(_position.Margin)`
- `NationalSpire.MarketPositionCard.Price(decimal)`；输入表达式：`Price(_quote!.Price)`；返回值紧邻使用处：`BinaryExpressionSyntax: "当前报价 " + Price(_quote!.Price)`

**赋值（含属性/字段和局部值）：**

- `_preview.Text` = `"保证金 " + CareerMoney.Compact(_position.Margin) + " → " + CareerMoney.Compact(_position.Margin + addition)              + "\n实际杠杆 " + Leverage(equity) + " → " + Leverage(equity + addition) + " · 追加免手续费"`
- `_preview.Text` = `"当前报价 " + Price(_quote!.Price) + (_position.Direction > 0 ? "；低于此价设置止损。" : "；高于此价设置止损。") + "\n触发后按实际成交均价平仓。"`

<a id="symbol-160df92af6e9"></a>

## `Leverage(NationalSpire.MarketNumber) — string Leverage(MarketNumber funds)`

来源：源码第 229 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketPositionCard.Preview()`](MarketVisuals.cs.md#symbol-5a8785632454)

**调用：** [`NationalSpire.MarketNumber.ToString(string?)`](MarketNumber.cs.md#symbol-0137dc156117)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.ToString(string?)`；`NationalSpire.MarketPosition.Units`；`NationalSpire.MarketPositionCard._position`；`NationalSpire.MarketPositionCard._quote`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.ToString(string?)`；输入表达式：`(_quote.Price * _position.Units / funds).ToString("0.##")`；返回值紧邻使用处：`BinaryExpressionSyntax: (_quote.Price * _position.Units / funds).ToString("0.##") + "×"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dd2c5ccf395d"></a>

## `NationalSpire.MarketPositionCard.Apply() — private void Apply()`

来源：源码第 233 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketPositionCard.Send(NationalSpire.MarketOrder)`](MarketVisuals.cs.md#symbol-75caf63f639d)；`Godot.SpinBox.Apply()`；`NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAmountInput.Amount`；`NationalSpire.MarketPosition.Id`；`NationalSpire.MarketPositionCard._editor`；`NationalSpire.MarketPositionCard._input`；`NationalSpire.MarketPositionCard._margin`；`NationalSpire.MarketPositionCard._position`；`NationalSpire.MarketPositionCard._revision`；`NationalSpire.MarketPositionCard.DisplayScale`；`NationalSpire.MarketPositionCard.Send(NationalSpire.MarketOrder)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.SpinBox.Apply()`；输入表达式：`_input.Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: _input.Apply();`
- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new("margin", Amount: _input.Amount / 10, Position: _position.Id, QuoteRevision: _revision)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _margin ? new("margin", Amount: _input.Amount / 10, Position: _position.Id, QuoteRevision: _revision)              : new("stop", Position: _position.Id, QuoteRevision: _revision, StopPrice: _input.Amount / DisplayScale)`
- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new("stop", Position: _position.Id, QuoteRevision: _revision, StopPrice: _input.Amount / DisplayScale)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _margin ? new("margin", Amount: _input.Amount / 10, Position: _position.Id, QuoteRevision: _revision)              : new("stop", Position: _position.Id, QuoteRevision: _revision, StopPrice: _input.Amount / DisplayScale)`
- `NationalSpire.MarketPositionCard.Send(NationalSpire.MarketOrder)`；输入表达式：`Send(_margin ? new("margin", Amount: _input.Amount / 10, Position: _position.Id, QuoteRevision: _revision)              : new("stop", Position: _position.Id, QuoteRevision: _revision, StopPrice: _input.Amount / DisplayScale))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(_margin ? new("margin", Amount: _input.Amount / 10, Position: _position.Id, QuoteRevision: _revision)              : new("stop", Position: _position.Id, QuoteRevision: _revision, StopPrice: _input.Amount / DisplayScale));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-75caf63f639d"></a>

## `NationalSpire.MarketPositionCard.Send(NationalSpire.MarketOrder) — private void Send(MarketOrder order)`

来源：源码第 240 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketPositionCard.Apply()`](MarketVisuals.cs.md#symbol-dd2c5ccf395d)；[`NationalSpire.MarketPositionCard.MarketPositionCard(System.Action, System.Action<NationalSpire.MarketOrder>)`](MarketVisuals.cs.md#symbol-66bfead77ff7)

**调用：** `Godot.CanvasItem.Hide()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.MarketPositionCard._editor`；`NationalSpire.MarketPositionCard._submit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_editor.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.Hide();`
- `System.Action<T>.Invoke(T)`；输入表达式：`_submit(order)`；返回值紧邻使用处：`ExpressionStatementSyntax: _submit(order);`

**赋值（含属性/字段和局部值）：**
