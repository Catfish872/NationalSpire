# MarketVisuals.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`40F6A01F16A18FDA9349AA99B8E60A98B8CFE2EF2E7622C4B374F773962E3C7D`。来源：[源码](../../MarketVisuals.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketVisuals`、`NationalSpire.MarketAssetButton`、`NationalSpire.DevelopmentGauge`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<(string, bool, bool), StyleBoxFlat> Cards = [];
private readonly Label _name = new(), _sector = new(), _price = new(), _change = new();
private readonly TextureRect _icon = new() { CustomMinimumSize = new(23, 23), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
        StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
```

<a id="symbol-7251a1de5493"></a>

## `NationalSpire.MarketVisuals.Accent(string) — public static Color Accent(string sector)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketAssetButton.Bind(NationalSpire.MarketAsset, NationalSpire.MarketQuote, bool, bool)`](MarketVisuals.cs.md#symbol-4e16b3f4bac4)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)；[`NationalSpire.MarketVisuals.Card(string, bool, bool)`](MarketVisuals.cs.md#symbol-aef7b9c00c48)

**调用：** `Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new(sector switch {         "训练装备" => "e4b367", "电竞设备" => "a99aef", "日常消费" => "70d4bc", _ => "81b8ec" })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(sector switch {         "训练装备" => "e4b367", "电竞设备" => "a99aef", "日常消费" => "70d4bc", _ => "81b8ec" })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-aef7b9c00c48"></a>

## `NationalSpire.MarketVisuals.Card(string, bool, bool) — public static StyleBoxFlat Card(string sector, bool selected, bool hover = false)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`](MarketVisuals.cs.md#symbol-7d1876899194)

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

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketAssetButton.Bind(NationalSpire.MarketAsset, NationalSpire.MarketQuote, bool, bool)`](MarketVisuals.cs.md#symbol-4e16b3f4bac4)；[`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)

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


<a id="symbol-0f0bdceb25d3"></a>

## `NationalSpire.MarketVisuals.LevelColor(int) — public static Color LevelColor(int level)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.DevelopmentGauge._Draw()`](MarketVisuals.cs.md#symbol-9e79a21d518d)

**调用：** `Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new(level switch {         <= 2 => "b96c7c", <= 4 => "e4ab65", <= 6 => "70d4bc", <= 8 => "ad9ded", _ => "f0cf85" })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(level switch {         <= 2 => "b96c7c", <= 4 => "e4ab65", <= 6 => "70d4bc", <= 8 => "ad9ded", _ => "f0cf85" })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3e8aa8ef1217"></a>

## `NationalSpire.MarketAssetButton.MarketAssetButton() — internal MarketAssetButton()`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshList()`](MarketTerminal.cs.md#symbol-38f64566d7c6)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketVisuals.Accent(string)`](MarketVisuals.cs.md#symbol-7251a1de5493)；[`NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`](MarketVisuals.cs.md#symbol-7d1876899194)；`decimal.ToString(string?)`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketAsset.Sector`；`NationalSpire.MarketAssetButton._change`；`NationalSpire.MarketAssetButton._icon`；`NationalSpire.MarketAssetButton._name`；`NationalSpire.MarketAssetButton._price`；`NationalSpire.MarketAssetButton._sector`；`NationalSpire.MarketQuote.Previous`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketVisuals.Accent(string)`；`NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`quote.Price.ToString("0.0000")`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? quote.Price.ToString("0.0000") : CareerMoney.Format(quote.Price)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("f095a3")`；返回值紧邻使用处：`ConditionalExpressionSyntax: change >= 0 ? CareerVisuals.Teal : new Color("f095a3")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_change.AddThemeColorOverride("font_color", change >= 0 ? CareerVisuals.Teal : new Color("f095a3"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _change.AddThemeColorOverride("font_color", change >= 0 ? CareerVisuals.Teal : new Color("f095a3"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_sector.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector))`；返回值紧邻使用处：`ExpressionStatementSyntax: _sector.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector));`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(quote.Price)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? quote.Price.ToString("0.0000") : CareerMoney.Format(quote.Price)`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(asset.Sector)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _icon.Texture = LifestyleArt.Icon(asset.Sector)`
- `NationalSpire.MarketVisuals.Accent(string)`；输入表达式：`MarketVisuals.Accent(asset.Sector)`；返回值紧邻使用处：`ArgumentSyntax: MarketVisuals.Accent(asset.Sector)`
- `NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`；输入表达式：`MarketVisuals.Style(this, asset.Sector, selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketVisuals.Style(this, asset.Sector, selected);`

**赋值（含属性/字段和局部值）：**

- `_change.Text` = `$"{change:+0.00%;-0.00%;0.00%}"`
- `_icon.Texture` = `LifestyleArt.Icon(asset.Sector)`
- `_name.Text` = `(watched ? "★ " : "") + asset.Name`
- `_price.Text` = `asset.Forex ? quote.Price.ToString("0.0000") : CareerMoney.Format(quote.Price)`
- `_sector.Text` = `asset.Country + "  /  " + asset.Sector`
- `TooltipText` = `asset.Name + " · " + asset.Country + " · " + asset.Sector`

<a id="symbol-2ed7d2937cd4"></a>

## `NationalSpire.DevelopmentGauge.Level — public int Level`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-91afc5ed8f86"></a>

## `NationalSpire.DevelopmentGauge.DevelopmentGauge() — public DevelopmentGauge()`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketVisuals.LevelColor(int)`](MarketVisuals.cs.md#symbol-0f0bdceb25d3)；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(float, float, float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.DevelopmentGauge.Level`；`NationalSpire.MarketVisuals.LevelColor(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(rect, i < Level ? color : new Color("0b1822"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(rect, i < Level ? color : new Color("0b1822"));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；输入表达式：`DrawRect(rect, new Color(color, i < Level ? .8f : .22f), false, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(rect, new Color(color, i < Level ? .8f : .22f), false, 1);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(color, i < Level ? .8f : .22f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(color, i < Level ? .8f : .22f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0b1822")`；返回值紧邻使用处：`ConditionalExpressionSyntax: i < Level ? color : new Color("0b1822")`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(i * (width + 4), 1, width, Size.Y - 2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(i * (width + 4), 1, width, Size.Y - 2)`
- `NationalSpire.MarketVisuals.LevelColor(int)`；输入表达式：`MarketVisuals.LevelColor(Level)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketVisuals.LevelColor(Level)`

**赋值（含属性/字段和局部值）：**
