# ConsumerPickerScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`499F808039A0AC313B4059CDAD995247DC50F32CE6DE222F098622302AE96675`。来源：[源码](../../ConsumerPickerScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CareerScreen.ConsumerChoice`、`NationalSpire.CareerScreen.ConsumerEdit`。

字段、事件及初始值（源码原样）：

```csharp
public ConsumerChoice? Choice;
public HashSet<string> People = [];
public HashSet<string> WeddingServices = [];
public string Group = "", Title = "", Detail = "";
public int Quantity = 1, Season, Day, Relationship;
```

<a id="symbol-22e991401891"></a>

## `NationalSpire.CareerScreen.ConsumerChoice.Caption — public string Caption`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerChoice.Good`；`NationalSpire.CareerScreen.ConsumerChoice.Verb`；`NationalSpire.Good.Name`；`NationalSpire.GoodVerb.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0e622d990712"></a>

## `NationalSpire.CareerScreen.ConsumerChoice.Category — public string Category`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerChoice.Good`；`NationalSpire.Good.Category`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bb172ffeb4df"></a>

## `NationalSpire.CareerScreen.ConsumerChoice.Key — public string Key`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerChoice.Good`；`NationalSpire.CareerScreen.ConsumerChoice.Service`；`NationalSpire.CareerScreen.ConsumerChoice.Verb`；`NationalSpire.Good.Id`；`NationalSpire.GoodVerb.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-74f147844628"></a>

## `NationalSpire.CareerScreen.ConsumerChoice.ActivityDetail(NationalSpire.CareerData) — public string ActivityDetail(CareerData data)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Changed(bool)`](ConsumerPickerScreen.cs.md#symbol-4cac190b7ec0)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerChoice.Good`；`NationalSpire.CareerScreen.ConsumerChoice.Verb`；`NationalSpire.Good.Name`；`NationalSpire.GoodVerb.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e5ebf63e6d3e"></a>

## `NationalSpire.CareerScreen.ConsumerProducts(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerChoice[], NationalSpire.CareerScreen.ConsumerEdit, System.Action) — private void ConsumerProducts(VBoxContainer box, ConsumerChoice[] choices, ConsumerEdit edit, Action changed)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`Refresh()`](ConsumerPickerScreen.cs.md#symbol-8376c45db5bc)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.ConsumerChoice.Category`；`NationalSpire.CareerScreen.ConsumerChoice.Good`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._muted`；`NationalSpire.ConsumerCatalog.TierOrder`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.Good.Tier`；`Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`b.SetPressedNoSignal(b.Text == value)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.SetPressedNoSignal(b.Text == value);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`tab.SetPressedNoSignal(value == category)`；返回值紧邻使用处：`ExpressionStatementSyntax: tab.SetPressedNoSignal(value == category);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`tab.SetPressedNoSignal(value == tier)`；返回值紧邻使用处：`ExpressionStatementSyntax: tab.SetPressedNoSignal(value == tier);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`footer.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tabs.AddThemeConstantOverride("h_separation", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddThemeConstantOverride("h_separation", 7);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tabs.AddThemeConstantOverride("v_separation", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddThemeConstantOverride("v_separation", 7);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tiers.AddThemeConstantOverride("h_separation", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: tiers.AddThemeConstantOverride("h_separation", 7);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tiers.AddThemeConstantOverride("v_separation", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: tiers.AddThemeConstantOverride("v_separation", 7);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`tab.AddThemeFontSizeOverride("font_size", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: tab.AddThemeFontSizeOverride("font_size", 14);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Name = "AttachmentProductGrid", Columns = 5, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Name = "AttachmentProductGrid", Columns = 5, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer { Name = "AttachmentProductTiers" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer { Name = "AttachmentProductTiers" }`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "AttachmentProductSearch", PlaceholderText = "搜索商品或活动名称", CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "AttachmentProductSearch", PlaceholderText = "搜索商品或活动名称", CustomMinimumSize = new(0, 42) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(footer)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(footer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(tabs)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(tabs);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(tiers)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(tiers);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(next)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(next);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(previous);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(tab)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(tab);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tiers.AddChild(tab)`；返回值紧邻使用处：`ExpressionStatementSyntax: tiers.AddChild(tab);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`tabs.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tabs.GetChildren().OfType<Button>`
- `Godot.Node.GetChildren(bool)`；输入表达式：`tiers.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tiers.GetChildren().OfType<Button>`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 34)`；返回值紧邻使用处：`AssignmentExpressionSyntax: tab.CustomMinimumSize = new(0, 34)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("←", () => { }, 48)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("←", () => { }, 48)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("→", () => { }, 48)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("→", () => { }, 48)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(value, value == category, () => { category = value; page = 0; foreach (var b in tabs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == value); Refresh(); }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton(value, value == category, () => { category = value; page = 0; foreach (var b in tabs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == value); Refresh(); }, 0)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(value, value == tier, () => { tier = value; page = 0; foreach (var b in tiers.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == value); Refresh(); }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton(value, value == tier, () => { tier = value; page = 0; foreach (var b in tiers.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == value); Refresh(); }, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 15, _muted)`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(g)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Good is { } g ? ConsumerEngine.Price(g) : 0`
- `Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`choices.Any(c => c.Good?.Tier == t)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t => choices.Any(c => c.Good?.Tier == t)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "全部" }.Concat(ConsumerCatalog.TierOrder.Where(t => choices.Any(c => c.Good?.Tier == t)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string value in new[] { "全部" }.Concat(ConsumerCatalog.TierOrder.Where(t => choices.Any(c => c.Good?.Tier == t)))) { var tab = FilterButton(value, value == tier, () => { tier = value; page = 0; foreach (var b in tiers.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == value); Refresh(); }, 0); tab.Name = "AttachmentTier_" + value; tab.ToggleMode = true; tab.SetPressedNoSignal(value == tier); tab.CustomMinimumSize = new(0, 34); tab.AddThemeFontSizeOverride("font_size", 14); tiers.AddChild(tab); }`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "全部" }.Concat(choices.Select(c => c.Category).Distinct())`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string value in new[] { "全部" }.Concat(choices.Select(c => c.Category).Distinct())) { var tab = FilterButton(value, value == category, () => { category = value; page = 0; foreach (var b in tabs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == value); Refresh(); }, 0); tab.ToggleMode = true; tab.SetPressedNoSignal(value == category); tab.CustomMinimumSize = new(0, 34); tab.AddThemeFontSizeOverride("font_size", 14); tabs.AddChild(tab); }`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`choices.Select(c => c.Category).Distinct()`；返回值紧邻使用处：`ArgumentSyntax: choices.Select(c => c.Category).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`choices.OrderByDescending(c => c.Good == null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choices.OrderByDescending(c => c.Good == null).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`choices.Select(c => c.Category)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choices.Select(c => c.Category).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`choices.OrderByDescending(c => c.Good == null).ThenByDescending(c => c.Good is { } g ? ConsumerEngine.Price(g) : 0).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = choices.OrderByDescending(c => c.Good == null).ThenByDescending(c => c.Good is { } g ? ConsumerEngine.Price(g) : 0).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ConsumerCatalog.TierOrder.Where(t => choices.Any(c => c.Good?.Tier == t))`；返回值紧邻使用处：`ArgumentSyntax: ConsumerCatalog.TierOrder.Where(t => choices.Any(c => c.Good?.Tier == t))`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`tabs.GetChildren().OfType<Button>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var b in tabs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == value);`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`tiers.GetChildren().OfType<Button>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var b in tiers.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == value);`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`choices.OrderByDescending(c => c.Good == null).ThenByDescending(c => c.Good is { } g ? ConsumerEngine.Price(g) : 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choices.OrderByDescending(c => c.Good == null).ThenByDescending(c => c.Good is { } g ? ConsumerEngine.Price(g) : 0).ToArray`
- `string.Trim()`；输入表达式：`text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: query = text.Trim()`

**赋值（含属性/字段和局部值）：**

- `Columns` = `5`
- `CustomMinimumSize` = `new(0, 42)`
- `Name` = `"AttachmentProductGrid"`
- `Name` = `"AttachmentProductSearch"`
- `Name` = `"AttachmentProductTiers"`
- `PlaceholderText` = `"搜索商品或活动名称"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `category` = `value`
- `label.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `next.Name` = `"AttachmentProductsNext"`
- `next.Pressed` += `() => { page++; Refresh(); }`
- `page` = `0`
- `previous.Name` = `"AttachmentProductsPrevious"`
- `previous.Pressed` += `() => { page--; Refresh(); }`
- `query` = `text.Trim()`
- `search.TextChanged` += `text => { query = text.Trim(); page = 0; Refresh(); }`
- `tab.CustomMinimumSize` = `new(0, 34)`
- `tab.Name` = `"AttachmentTier_" + value`
- `tab.ToggleMode` = `true`
- `tier` = `value`

<a id="symbol-8376c45db5bc"></a>

## `Refresh() — void Refresh()`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerProducts(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerChoice[], NationalSpire.CareerScreen.ConsumerEdit, System.Action)`](ConsumerPickerScreen.cs.md#symbol-e5ebf63e6d3e)；[`Refresh()`](ConsumerPickerScreen.cs.md#symbol-8376c45db5bc)

**调用：** `Godot.Button.Button()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerAttachments.cs.md#symbol-6c24344e1310)；[`NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`](ConsumerVisuals.cs.md#symbol-4d4df8cb62c8)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；`NationalSpire.LifestyleArt.LifestyleArt()`；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；[`Refresh()`](ConsumerPickerScreen.cs.md#symbol-8376c45db5bc)；`System.Action.Invoke()`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`；`string.Contains(string, System.StringComparison)`；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerChoice.Caption`；`NationalSpire.CareerScreen.ConsumerChoice.Category`；`NationalSpire.CareerScreen.ConsumerChoice.Good`；`NationalSpire.CareerScreen.ConsumerChoice.Key`；`NationalSpire.CareerScreen.ConsumerChoice.ServicePerson`；`NationalSpire.CareerScreen.ConsumerChoice.Verb`；`NationalSpire.CareerScreen.ConsumerEdit.Choice`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`；`NationalSpire.Good.Category`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.Good.Tier`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.LifestyleArt.Category`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.LifestyleArt.ProductId`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.ConsumerProducts`；`Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = "AttachmentProduct_" + choice.Key.Replace("/", "_"), CustomMinimumSize = new(0, 138), SizeFlagsHorizontal = SizeFlags.ExpandFill, TooltipText = choice.Caption + (choice.Good == null ? "" : " · " + choice.Good.Name) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = "AttachmentProduct_" + choice.Key.Replace("/", "_"), CustomMinimumSize = new(0, 138), SizeFlagsHorizontal = SizeFlags.ExpandFill, TooltipText = choice.Caption + (choice.Good == null ? "" : " · " + choice.Good.Name) }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + side, 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + side, 9);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(detail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(0, 61), MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(0, 61), MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(new TextureRect { Texture = LifestyleArt.Icon("活动与计划"), CustomMinimumSize = new(0, 61), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(new TextureRect { Texture = LifestyleArt.Icon("活动与计划"), CustomMinimumSize = new(0, 61), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(content);`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = LifestyleArt.Icon("活动与计划"), CustomMinimumSize = new(0, 61), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new TextureRect { Texture = LifestyleArt.Icon("活动与计划"), CustomMinimumSize = new(0, 61), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 138)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 138)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 61)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 61)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(choice.Caption, 16, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(choice.Caption, 16, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(choice.Good == null ? "填写自己的安排" : choice.ServicePerson.Length > 0 ? GroupChats.Name(ViewData, choice.ServicePerson) + " · " + choice.Good.Name : choice.Verb != null ? choice.Good.Name : "持有 " + ConsumerAttachments.Available(ViewData, choice.Good), 13, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(choice.Good == null ? "填写自己的安排" : choice.ServicePerson.Length > 0 ? GroupChats.Name(ViewData, choice.ServicePerson) + " · " + choice.Good.Name : choice.Verb != null ? choice.Good.Name : "持有 " + ConsumerAttachments.Available(ViewData, choice.Good), 13, CareerVisuals.Teal)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(grid);`
- `NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerAttachments.Available(ViewData, choice.Good)`；返回值紧邻使用处：`BinaryExpressionSyntax: "持有 " + ConsumerAttachments.Available(ViewData, choice.Good)`
- `NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`；输入表达式：`ConsumerVisuals.ProductStyle(card, false, edit.Choice?.Key == choice.Key)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerVisuals.ProductStyle(card, false, edit.Choice?.Key == choice.Key);`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, choice.ServicePerson)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(ViewData, choice.ServicePerson) + " · "`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon("活动与计划")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture = LifestyleArt.Icon("活动与计划")`
- `NationalSpire.LifestyleArt.LifestyleArt()`；输入表达式：`new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(0, 61), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(0, 61), MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.ConsumerProducts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.ConsumerProducts)`
- `Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `System.Action.Invoke()`；输入表达式：`changed()`；返回值紧邻使用处：`ExpressionStatementSyntax: changed();`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`items.Skip(page * 10)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: items.Skip(page * 10).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`items.Skip(page * 10).Take(10)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var choice in items.Skip(page * 10).Take(10)) { var card = new Button { Name = "AttachmentProduct_" + choice.Key.Replace("/", "_"), CustomMinimumSize = new(0, 138), SizeFlagsHorizontal = SizeFlags.ExpandFill, TooltipText = choice.Caption + (choice.Good == null ? "" : " · " + choice.Good.Name) }; ConsumerVisuals.ProductStyle(card, false, edit.Choice?.Key == choice.Key); grid.AddChild(card); var margin = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }; card.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); foreach (string side in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + side, 9); var content = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; content.AddThemeConstantOverride("separation", 4); margin.AddChild(content); if (choice.Good is { } good) content.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(0, 61), MouseFilter = MouseFilterEnum.Ignore }); else content.AddChild(new TextureRect { Texture = LifestyleArt.Icon("活动与计划"), CustomMinimumSize = new(0, 61), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }); var name = Text(choice.Caption, 16, _ink); name.MouseFilter = MouseFilterEnum.Ignore; name.MaxLinesVisible = 2; content.AddChild(name); var detail = Text(choice.Good == null ? "填写自己的安排" : choice.ServicePerson.Length > 0 ? GroupChats.Name(ViewData, choice.ServicePerson) + " · " + choice.Good.Name : choice.Verb != null ? choice.Good.Name : "持有 " + ConsumerAttachments.Available(ViewData, choice.Good), 13, CareerVisuals.Teal); detail.MouseFilter = MouseFilterEnum.Ignore; detail.MaxLinesVisible = 2; content.AddChild(detail); card.Pressed += () => { edit.Choice = choice; changed(); Refresh(); }; }`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`ordered.Where(c => category == "全部" || c.Category == category).Where(c => tier == "全部" || c.Good?.Tier == tier) .Where(c => c.Caption.Contains(query, StringComparison.OrdinalIgnoreCase) || c.Good?.Name.Contains(query, StringComparison.OrdinalIgnoreCase) == true).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ordered.Where(c => category == "全部" || c.Category == category).Where(c => tier == "全部" || c.Good?.Tier == tier) .Where(c => c.Caption.Contains(query, StringComparison.OrdinalIgnoreCase) || c.Good?.Name.Contains(query, StringComparison.OrdinalIgnoreCase) == true).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ordered.Where(c => category == "全部" || c.Category == category)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ordered.Where(c => category == "全部" || c.Category == category).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ordered.Where(c => category == "全部" || c.Category == category).Where(c => tier == "全部" || c.Good?.Tier == tier)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ordered.Where(c => category == "全部" || c.Category == category).Where(c => tier == "全部" || c.Good?.Tier == tier) .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ordered.Where(c => category == "全部" || c.Category == category).Where(c => tier == "全部" || c.Good?.Tier == tier) .Where(c => c.Caption.Contains(query, StringComparison.OrdinalIgnoreCase) || c.Good?.Name.Contains(query, StringComparison.OrdinalIgnoreCase) == true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ordered.Where(c => category == "全部" || c.Category == category).Where(c => tier == "全部" || c.Good?.Tier == tier) .Where(c => c.Caption.Contains(query, StringComparison.OrdinalIgnoreCase) || c.Good?.Name.Contains(query, StringComparison.OrdinalIgnoreCase) == true).ToArray`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(page, 0, Math.Max(0, (items.Length - 1) / 10))`；返回值紧邻使用处：`AssignmentExpressionSyntax: page = Math.Clamp(page, 0, Math.Max(0, (items.Length - 1) / 10))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, (items.Length - 1) / 10)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, (items.Length - 1) / 10)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, (items.Length + 9) / 10)`；返回值紧邻使用处：`InterpolationSyntax: {Math.Max(1, (items.Length + 9) / 10)}`
- `string.Contains(string, System.StringComparison)`；输入表达式：`.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Good?.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`c.Caption.Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Caption.Contains(query, StringComparison.OrdinalIgnoreCase) || c.Good?.Name.Contains(query, StringComparison.OrdinalIgnoreCase) == true`
- `string.Replace(string, string?)`；输入表达式：`choice.Key.Replace("/", "_")`；返回值紧邻使用处：`BinaryExpressionSyntax: "AttachmentProduct_" + choice.Key.Replace("/", "_")`

**赋值（含属性/字段和局部值）：**

- `Category` = `good.Category + " " + good.Name`
- `CustomMinimumSize` = `new(0, 138)`
- `CustomMinimumSize` = `new(0, 61)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"AttachmentProduct_" + choice.Key.Replace("/", "_")`
- `ProductId` = `good.Id`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Texture` = `LifestyleArt.Icon("活动与计划")`
- `TooltipText` = `choice.Caption + (choice.Good == null ? "" : " · " + choice.Good.Name)`
- `card.Pressed` += `() => { edit.Choice = choice; changed(); Refresh(); }`
- `detail.MaxLinesVisible` = `2`
- `detail.MouseFilter` = `MouseFilterEnum.Ignore`
- `edit.Choice` = `choice`
- `label.Text` = `items.Length == 0 ? "暂无匹配商品" : $"第 {page + 1} / {Math.Max(1, (items.Length + 9) / 10)} 页 · 共 {items.Length} 项"`
- `name.MaxLinesVisible` = `2`
- `name.MouseFilter` = `MouseFilterEnum.Ignore`
- `next.Disabled` = `(page + 1) * 10 >= items.Length`
- `page` = `Math.Clamp(page, 0, Math.Max(0, (items.Length - 1) / 10))`
- `previous.Disabled` = `page == 0`

<a id="symbol-0f5d28176960"></a>

## `NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?) — private void ConsumerEditor(bool activity, ConsumerComposer? shop, PrivateOffer? previous = null, string goodId = "", string verbId = "", ConsumerEdit? retained = null)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerTarget(NationalSpire.Good, bool)`](ConsumerCommerceScreen.cs.md#symbol-4d2c83181e84)；[`NationalSpire.CareerScreen.PrivateActivityPicker(string, string, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`](ChatAttachmentScreen.cs.md#symbol-1f0cb820099b)；[`NationalSpire.CareerScreen.PrivateGiftPicker(NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`](ChatAttachmentScreen.cs.md#symbol-bd49b7253d4e)；[`ReturnEditor()`](ConsumerPickerScreen.cs.md#symbol-3854743a5c61)

**调用：** [`Calendar()`](ConsumerPickerScreen.cs.md#symbol-8eb2036c6dbc)；[`Changed(bool)`](ConsumerPickerScreen.cs.md#symbol-4cac190b7ec0)；[`Error(string)`](ConsumerPickerScreen.cs.md#symbol-2499f8db4ac1)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Hide()`；`Godot.CheckButton.CheckButton()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.SpinBox.SpinBox()`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`](ConsumerCommerceScreen.cs.md#symbol-f3a03a858f88)；[`NationalSpire.CareerScreen.ConsumerChoice.ActivityDetail(NationalSpire.CareerData)`](ConsumerPickerScreen.cs.md#symbol-74f147844628)；`NationalSpire.CareerScreen.ConsumerChoice.ConsumerChoice(NationalSpire.Good?, NationalSpire.GoodVerb?, string, string)`；`NationalSpire.CareerScreen.ConsumerEdit.ConsumerEdit()`；[`NationalSpire.CareerScreen.ConsumerProducts(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerChoice[], NationalSpire.CareerScreen.ConsumerEdit, System.Action)`](ConsumerPickerScreen.cs.md#symbol-e5ebf63e6d3e)；[`NationalSpire.CareerScreen.ConsumerRecipients(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerEdit, bool, System.Action)`](ConsumerPickerScreen.cs.md#symbol-d76de74a5483)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ChatAttachments.cs.md#symbol-4e7c361b1f77)；[`NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerAttachments.cs.md#symbol-6c24344e1310)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；`NationalSpire.ConsumerComposer.ConsumerComposer(string, string, string, System.Collections.Generic.List<string>)`；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.ConsumerQuantity.ConsumerQuantity()`](ConsumerGiftControls.cs.md#symbol-0eddfdec0f89)；[`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`NationalSpire.LifestyleArt.LifestyleArt()`；`NationalSpire.PrivateOffer.PrivateOffer()`；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；[`NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](WeddingAppointments.cs.md#symbol-e0e8b388fcb4)；[`NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-920147fd431a)；[`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`；`System.Math.Min(int, int)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `Calendar()`；`Changed(bool)`；`Error(string)`；`FitContent()`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`；`NationalSpire.CareerScreen.ConsumerChoice.ActivityDetail(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ConsumerChoice.Caption`；`NationalSpire.CareerScreen.ConsumerChoice.Good`；`NationalSpire.CareerScreen.ConsumerChoice.Service`；`NationalSpire.CareerScreen.ConsumerChoice.Verb`；`NationalSpire.CareerScreen.ConsumerEdit.Choice`；`NationalSpire.CareerScreen.ConsumerEdit.Day`；`NationalSpire.CareerScreen.ConsumerEdit.Detail`；`NationalSpire.CareerScreen.ConsumerEdit.Group`；`NationalSpire.CareerScreen.ConsumerEdit.People`；`NationalSpire.CareerScreen.ConsumerEdit.Quantity`；`NationalSpire.CareerScreen.ConsumerEdit.Relationship`；`NationalSpire.CareerScreen.ConsumerEdit.Season`；`NationalSpire.CareerScreen.ConsumerEdit.Title`；`NationalSpire.CareerScreen.ConsumerEdit.WeddingServices`；`NationalSpire.CareerScreen.ConsumerProducts(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerChoice[], NationalSpire.CareerScreen.ConsumerEdit, System.Action)`；`NationalSpire.CareerScreen.ConsumerRecipients(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerEdit, bool, System.Action)`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._groupSelection`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；`NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerCatalog.All`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerComposer.Good`；`NationalSpire.ConsumerComposer.Group`；`NationalSpire.ConsumerComposer.People`；`NationalSpire.ConsumerComposer.Person`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerQuantity.Changed`；`NationalSpire.ConsumerQuantity.Initialize(int)`；`NationalSpire.ConsumerQuantity.Maximum`；`NationalSpire.ConsumerQuantity.Minimum`；`NationalSpire.ConsumerQuantity.Valid`；`NationalSpire.ConsumerQuantity.Value`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.Good.Activities`；`NationalSpire.Good.Category`；`NationalSpire.Good.Giftable`；`NationalSpire.Good.Id`；`NationalSpire.Good.Instant`；`NationalSpire.Good.Name`；`NationalSpire.Good.Tier`；`NationalSpire.GoodVerb.Id`；`NationalSpire.GoodVerb.Name`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.LifestyleArt.Category`；`NationalSpire.LifestyleArt.ProductId`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GoodVerb`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.Quantity`；`NationalSpire.PrivateOffer.RelationshipIntent`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.ServiceId`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.WeddingServiceIds`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.ConsumerEditor`；`NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`；`NationalSpire.WeddingAppointments.Verb`；`ReturnEditor()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Calendar()`；输入表达式：`Calendar()`；返回值紧邻使用处：`ExpressionStatementSyntax: Calendar();`
- `Changed(bool)`；输入表达式：`Changed()`；返回值紧邻使用处：`ExpressionStatementSyntax: Changed();`
- `Changed(bool)`；输入表达式：`Changed(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Changed(true)`
- `Changed(bool)`；输入表达式：`Changed(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Changed(true);`
- `Error(string)`；输入表达式：`Error("请输入有效的赠礼数量。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Error("请输入有效的赠礼数量。");`
- `Error(string)`；输入表达式：`Error("请选择物品或活动。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Error("请选择物品或活动。");`
- `Error(string)`；输入表达式：`Error("请选择至少一位结婚对象。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Error("请选择至少一位结婚对象。");`
- `Error(string)`；输入表达式：`Error(activity ? "请选择同行者。" : "请选择接收礼物的人。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Error(activity ? "请选择同行者。" : "请选择接收礼物的人。");`
- `Error(string)`；输入表达式：`Error(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: Error(message);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`b.SetPressedNoSignal(b.Text == choice.Caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.SetPressedNoSignal(b.Text == choice.Caption);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`button.SetPressedNoSignal(edit.Choice == choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetPressedNoSignal(edit.Choice == choice);`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => ConsumerAttachmentConfirmation(composer, attachment, ReturnEditor)).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => ConsumerAttachmentConfirmation(composer, attachment, ReturnEditor)).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => ConsumerAttachmentConfirmation(composer, attachment, ReturnEditor))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => ConsumerAttachmentConfirmation(composer, attachment, ReturnEditor)).CallDeferred`
- `Godot.CanvasItem.Hide()`；输入表达式：`error.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: error.Hide();`
- `Godot.CheckButton.CheckButton()`；输入表达式：`new CheckButton { Text = "附加确定恋人关系的请求", ButtonPressed = edit.Relationship == 1 }`；返回值紧邻使用处：`AssignmentExpressionSyntax: relationship = new CheckButton { Text = "附加确定恋人关系的请求", ButtonPressed = edit.Relationship == 1 }`
- `Godot.Color.Color(string)`；输入表达式：`new("efb3aa")`；返回值紧邻使用处：`ArgumentSyntax: new("efb3aa")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`columns.AddThemeConstantOverride("separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddThemeConstantOverride("separation", 22);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`recipients.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: recipients.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`settings.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`product.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203b48", "526f7a", 9, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: product.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203b48", "526f7a", 9, 14));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "ActivityTitle", Text = edit.Title, PlaceholderText = "活动名称", CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: title = new LineEdit { Name = "ActivityTitle", Text = edit.Title, PlaceholderText = "活动名称", CustomMinimumSize = new(0, 42) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(selection)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(selection);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(recipients)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(recipients);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(settings)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(settings);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`dates.AddChild(calendar)`；返回值紧邻使用处：`ExpressionStatementSyntax: dates.AddChild(calendar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`info.AddChild(Text("现有 " + ConsumerAttachments.Available(d, good) + " 件 · 确认后补购所需数量", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: info.AddChild(Text("现有 " + ConsumerAttachments.Available(d, good) + " 件 · 确认后补购所需数量", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`info.AddChild(Text($"${ConsumerEngine.Price(good):N0}", 27, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: info.AddChild(Text($"${ConsumerEngine.Price(good):N0}", 27, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`info.AddChild(Text(good.Category + " · " + good.Tier, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: info.AddChild(Text(good.Category + " · " + good.Tier, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`product.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: product.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(date)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(date);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(info)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(info);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(90, 90) })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(90, 90) });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(season)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(season);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(Text("赠礼数量", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(Text("赠礼数量", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(Text((activity ? "同行者 · " : "接收者 · ") + string.Join("、", edit.People.Select(id => GroupChats.Name(d, id))), 16, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(Text((activity ? "同行者 · " : "接收者 · ") + string.Join("、", edit.People.Select(id => GroupChats.Name(d, id))), 16, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(dates)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(dates);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(detail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(hint)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(hint);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(product)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(product);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(quantity)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(quantity);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(relationship)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(relationship);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(verbs)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(verbs);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(wedding)`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(wedding);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`verbs.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: verbs.AddChild(button);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`verbs.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: verbs.GetChildren().OfType<Button>`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(0, 210), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(0, 210), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { Name = "ConsumerEditorScroll", CustomMinimumSize = new(0, Math.Max(240, Math.Min(650, _stage.Size.Y - 230))), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { Name = "ConsumerEditorScroll", CustomMinimumSize = new(0, Math.Max(240, Math.Min(650, _stage.Size.Y - 230))), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = edit.Season, Prefix = "赛季 ", CustomMinimumSize = new(150, 40), UpdateOnTextChanged = true }`；返回值紧邻使用处：`AssignmentExpressionSyntax: season = new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = edit.Season, Prefix = "赛季 ", CustomMinimumSize = new(150, 40), UpdateOnTextChanged = true }`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "ActivityDetail", Text = edit.Detail, PlaceholderText = "补充活动内容", CustomMinimumSize = new(0, 72), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`AssignmentExpressionSyntax: detail = new TextEdit { Name = "ActivityDetail", Text = edit.Detail, PlaceholderText = "补充活动内容", CustomMinimumSize = new(0, 72), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "WeddingPartners" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: wedding = new VBoxContainer { Name = "WeddingPartners" }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 210)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 210)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 72)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 72)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, Math.Max(240, Math.Min(650, _stage.Size.Y - 230)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, Math.Max(240, Math.Min(650, _stage.Size.Y - 230)))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(150, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(150, 40)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(90, 90)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(90, 90)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: box.CustomMinimumSize = new(width, 0)`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(attachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachPrivate(attachment);`
- `NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`；输入表达式：`ConsumerAttachmentConfirmation(composer, attachment, ReturnEditor)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConsumerAttachmentConfirmation(composer, attachment, ReturnEditor)`
- `NationalSpire.CareerScreen.ConsumerChoice.ActivityDetail(NationalSpire.CareerData)`；输入表达式：`.ActivityDetail(d)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: edit.Choice?.ActivityDetail(d)`
- `NationalSpire.CareerScreen.ConsumerChoice.ConsumerChoice(NationalSpire.Good?, NationalSpire.GoodVerb?, string, string)`；输入表达式：`new ConsumerChoice(ConsumerCatalog.Get(s.GoodId), WeddingAppointments.Verb, s.Id, s.Person)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => new ConsumerChoice(ConsumerCatalog.Get(s.GoodId), WeddingAppointments.Verb, s.Id, s.Person)`
- `NationalSpire.CareerScreen.ConsumerChoice.ConsumerChoice(NationalSpire.Good?, NationalSpire.GoodVerb?, string, string)`；输入表达式：`new ConsumerChoice(g)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => new ConsumerChoice(g)`
- `NationalSpire.CareerScreen.ConsumerChoice.ConsumerChoice(NationalSpire.Good?, NationalSpire.GoodVerb?, string, string)`；输入表达式：`new ConsumerChoice(g, v)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: v => new ConsumerChoice(g, v)`
- `NationalSpire.CareerScreen.ConsumerChoice.ConsumerChoice(NationalSpire.Good?, NationalSpire.GoodVerb?, string, string)`；输入表达式：`new ConsumerChoice(null)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new ConsumerChoice(null) }`
- `NationalSpire.CareerScreen.ConsumerEdit.ConsumerEdit()`；输入表达式：`new ConsumerEdit { People = initialPeople.Where(id => id.Length > 0 && !GroupChats.IsHuman(d, id)).ToHashSet(), Group = group, Season = previous?.Season ?? d.Season, Day = previous?.Day ?? SeasonCalendar.Day(d, d.Day), Quantity = previous?.Quantity ?? 1, Relationship = previous?.RelationshipIntent ?? 0 }`；返回值紧邻使用处：`BinaryExpressionSyntax: retained ?? new ConsumerEdit { People = initialPeople.Where(id => id.Length > 0 && !GroupChats.IsHuman(d, id)).ToHashSet(), Group = group, Season = previous?.Season ?? d.Season, Day = previous?.Day ?? SeasonCalendar.Day(d, d.Day), Quantity = previous?.Quantity ?? 1, Relationship = previous?.RelationshipIntent ?? 0 }`
- `NationalSpire.CareerScreen.ConsumerProducts(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerChoice[], NationalSpire.CareerScreen.ConsumerEdit, System.Action)`；输入表达式：`ConsumerProducts(body, choices, edit, () => Changed(true))`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerProducts(body, choices, edit, () => Changed(true));`
- `NationalSpire.CareerScreen.ConsumerRecipients(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerEdit, bool, System.Action)`；输入表达式：`ConsumerRecipients(recipients, edit, activity, () => { Changed(); Calendar(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerRecipients(recipients, edit, activity, () => { Changed(); Calendar(); });`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(choice.Caption, edit.Choice == choice, () => { edit.Choice = choice; Changed(true); foreach (var b in verbs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == choice.Caption); }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton(choice.Caption, edit.Choice == choice, () => { edit.Choice = choice; Changed(true); foreach (var b in verbs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == choice.Caption); }, 0)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog(activity ? "约定活动" : "赠送礼物", "", () => { if (edit.Choice == null) { Error("请选择物品或活动。"); return false; } if (edit.People.Count == 0) { Error(activity ? "请选择同行者。" : "请选择接收礼物的人。"); return false; } if (!activity && quantity?.Valid != true) { Error("请输入有效的赠礼数量。"); return false; } string target = edit.People.First(); string[] weddingIds = activity && edit.Choice.Service.Length > 0 ? new[] { edit.Choice.Service }.Concat(edit.WeddingServices).Where(edit.WeddingServices.Contains).Distinct().ToArray() : []; if (activity && edit.Choice.Service.Length > 0 && weddingIds.Length == 0) { Error("请选择至少一位结婚对象。"); return false; } string weddingGood = weddingIds.Length > 0 ? WeddingAppointments.Services(d).FirstOrDefault(s => s.Id == weddingIds[0]).GoodId : ""; var attachment = new PrivateOffer { Kind = activity ? "activity" : "gift", Quantity = activity ? 1 : edit.Quantity, GoodId = edit.Choice.Good?.Id ?? "", GoodVerb = edit.Choice.Verb?.Id ?? "", ServiceId = edit.Choice.Service, WeddingServiceIds = weddingIds.ToList(), Title = edit.Title.Trim(), Detail = edit.Detail.Trim(), Season = edit.Season, Day = edit.Day, RelationshipIntent = relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0, ActorId = target, Participants = activity ? new[] { GroupChats.Human(d) }.Concat(edit.People).ToList() : [target] }; if (weddingIds.Length > 0) { attachment.ServiceId = weddingIds[0]; attachment.GoodId = weddingGood ?? ""; } if (ChatAttachments.Prepare(d, target, attachment, shopping: shopping) is { } message) { Error(message); return false; } var composer = new ConsumerComposer(attachment.GoodId, target, edit.Group, edit.People.ToList()); if (shopping || edit.Choice.Good?.Instant == true) { Callable.From(() => ConsumerAttachmentConfirmation(composer, attachment, ReturnEditor)).CallDeferred(); } else AttachPrivate(attachment); return true; }, shopping || edit.Choice?.Good?.Instant == true ? "确认费用" : "添加到消息", box => { float width = Math.Min(1120, _stage.Size.X - 100); box.CustomMinimumSize = new(width, 0); box.AddThemeConstantOverride("separation", 14); var scroll = new ScrollContainer { Name = "ConsumerEditorScroll", CustomMinimumSize = new(0, Math.Max(240, Math.Min(650, _stage.Size.Y - 230))), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var body = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; body.AddThemeConstantOverride("separation", 14); scroll.AddChild(body); void FitContent() { float height = Math.Clamp(body.GetCombinedMinimumSize().Y, 180, Math.Max(240, Math.Min(650, _stage.Size.Y - 230))); if (scroll.CustomMinimumSize.Y != height) scroll.CustomMinimumSize = new(0, height); } body.MinimumSizeChanged += FitContent; body.Resized += FitContent; selection = Text(edit.Choice?.Caption ?? "选择物品", 22, _gold); selection.Name = "ConsumerSelectedProduct"; body.AddChild(selection); if (!shopping) ConsumerProducts(body, choices, edit, () => Changed(true)); var columns = new HBoxContainer(); columns.AddThemeConstantOverride("separation", 22); body.AddChild(columns); var settings = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; settings.AddThemeConstantOverride("separation", 12); columns.AddChild(settings); if (shopping && edit.Choice?.Good is { } good) { var product = new PanelContainer(); product.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203b48", "526f7a", 9, 14)); settings.AddChild(product); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 14); product.AddChild(row); row.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(90, 90) }); var info = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(info); info.AddChild(Text(good.Category + " · " + good.Tier, 14, _muted)); info.AddChild(Text($"${ConsumerEngine.Price(good):N0}", 27, CareerVisuals.Teal)); info.AddChild(Text("现有 " + ConsumerAttachments.Available(d, good) + " 件 · 确认后补购所需数量", 14, _muted)); if (activity && choices.Length > 1) { var verbs = new HFlowContainer(); settings.AddChild(verbs); foreach (var choice in choices) { var button = FilterButton(choice.Caption, edit.Choice == choice, () => { edit.Choice = choice; Changed(true); foreach (var b in verbs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == choice.Caption); }, 0); button.ToggleMode = true; button.SetPressedNoSignal(edit.Choice == choice); verbs.AddChild(button); } } } if (!activity) { settings.AddChild(Text("赠礼数量", 15, _muted)); quantity = new ConsumerQuantity { Name = "GiftQuantity", Minimum = 1, Maximum = int.MaxValue }; quantity.Initialize(edit.Quantity); settings.AddChild(quantity); quantity.Changed += () => edit.Quantity = quantity.Value; relationship = new CheckButton { Text = "附加确定恋人关系的请求", ButtonPressed = edit.Relationship == 1 }; settings.AddChild(relationship); relationship.Toggled += value => edit.Relationship = value ? 1 : 0; hint = Text("", 15, CareerVisuals.Teal); settings.AddChild(hint); } else { title = new LineEdit { Name = "ActivityTitle", Text = edit.Title, PlaceholderText = "活动名称", CustomMinimumSize = new(0, 42) }; title.TextChanged += value => edit.Title = value; settings.AddChild(title); detail = new TextEdit { Name = "ActivityDetail", Text = edit.Detail, PlaceholderText = "补充活动内容", CustomMinimumSize = new(0, 72), WrapMode = TextEdit.LineWrappingMode.Boundary }; detail.TextChanged += () => edit.Detail = detail.Text; settings.AddChild(detail); wedding = new VBoxContainer { Name = "WeddingPartners" }; settings.AddChild(wedding); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); settings.AddChild(row); season = new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = edit.Season, Prefix = "赛季 ", CustomMinimumSize = new(150, 40), UpdateOnTextChanged = true }; row.AddChild(season); date = Text(GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day), 16, CareerVisuals.Teal); row.AddChild(date); var dates = new ScrollContainer { CustomMinimumSize = new(0, 210), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; settings.AddChild(dates); calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; dates.AddChild(calendar); season.ValueChanged += value => { edit.Season = (int)value; edit.Day = Math.Min(edit.Day, SeasonCalendar.Length(d, edit.Season)); date.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day); Calendar(); }; Calendar(); } if (shopping) { var recipients = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; recipients.AddThemeConstantOverride("separation", 10); columns.AddChild(recipients); ConsumerRecipients(recipients, edit, activity, () => { Changed(); Calendar(); }); } else settings.AddChild(Text((activity ? "同行者 · " : "接收者 · ") + string.Join("、", edit.People.Select(id => GroupChats.Name(d, id))), 16, CareerVisuals.Teal)); error = Text("", 16, new("efb3aa")); error.Name = "ConsumerEditorError"; error.Hide(); box.AddChild(error); Changed(); }, returnOutsideChat: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(activity ? "约定活动" : "赠送礼物", "", () => { if (edit.Choice == null) { Error("请选择物品或活动。"); return false; } if (edit.People.Count == 0) { Error(activity ? "请选择同行者。" : "请选择接收礼物的人。"); return false; } if (!activity && quantity?.Valid != true) { Error("请输入有效的赠礼数量。"); return false; } string target = edit.People.First(); string[] weddingIds = activity && edit.Choice.Service.Length > 0 ? new[] { edit.Choice.Service }.Concat(edit.WeddingServices).Where(edit.WeddingServices.Contains).Distinct().ToArray() : []; if (activity && edit.Choice.Service.Length > 0 && weddingIds.Length == 0) { Error("请选择至少一位结婚对象。"); return false; } string weddingGood = weddingIds.Length > 0 ? WeddingAppointments.Services(d).FirstOrDefault(s => s.Id == weddingIds[0]).GoodId : ""; var attachment = new PrivateOffer { Kind = activity ? "activity" : "gift", Quantity = activity ? 1 : edit.Quantity, GoodId = edit.Choice.Good?.Id ?? "", GoodVerb = edit.Choice.Verb?.Id ?? "", ServiceId = edit.Choice.Service, WeddingServiceIds = weddingIds.ToList(), Title = edit.Title.Trim(), Detail = edit.Detail.Trim(), Season = edit.Season, Day = edit.Day, RelationshipIntent = relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0, ActorId = target, Participants = activity ? new[] { GroupChats.Human(d) }.Concat(edit.People).ToList() : [target] }; if (weddingIds.Length > 0) { attachment.ServiceId = weddingIds[0]; attachment.GoodId = weddingGood ?? ""; } if (ChatAttachments.Prepare(d, target, attachment, shopping: shopping) is { } message) { Error(message); return false; } var composer = new ConsumerComposer(attachment.GoodId, target, edit.Group, edit.People.ToList()); if (shopping || edit.Choice.Good?.Instant == true) { Callable.From(() => ConsumerAttachmentConfirmation(composer, attachment, ReturnEditor)).CallDeferred(); } else AttachPrivate(attachment); return true; }, shopping || edit.Choice?.Good?.Instant == true ? "确认费用" : "添加到消息", box => { float width = Math.Min(1120, _stage.Size.X - 100); box.CustomMinimumSize = new(width, 0); box.AddThemeConstantOverride("separation", 14); var scroll = new ScrollContainer { Name = "ConsumerEditorScroll", CustomMinimumSize = new(0, Math.Max(240, Math.Min(650, _stage.Size.Y - 230))), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var body = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; body.AddThemeConstantOverride("separation", 14); scroll.AddChild(body); void FitContent() { float height = Math.Clamp(body.GetCombinedMinimumSize().Y, 180, Math.Max(240, Math.Min(650, _stage.Size.Y - 230))); if (scroll.CustomMinimumSize.Y != height) scroll.CustomMinimumSize = new(0, height); } body.MinimumSizeChanged += FitContent; body.Resized += FitContent; selection = Text(edit.Choice?.Caption ?? "选择物品", 22, _gold); selection.Name = "ConsumerSelectedProduct"; body.AddChild(selection); if (!shopping) ConsumerProducts(body, choices, edit, () => Changed(true)); var columns = new HBoxContainer(); columns.AddThemeConstantOverride("separation", 22); body.AddChild(columns); var settings = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; settings.AddThemeConstantOverride("separation", 12); columns.AddChild(settings); if (shopping && edit.Choice?.Good is { } good) { var product = new PanelContainer(); product.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203b48", "526f7a", 9, 14)); settings.AddChild(product); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 14); product.AddChild(row); row.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(90, 90) }); var info = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(info); info.AddChild(Text(good.Category + " · " + good.Tier, 14, _muted)); info.AddChild(Text($"${ConsumerEngine.Price(good):N0}", 27, CareerVisuals.Teal)); info.AddChild(Text("现有 " + ConsumerAttachments.Available(d, good) + " 件 · 确认后补购所需数量", 14, _muted)); if (activity && choices.Length > 1) { var verbs = new HFlowContainer(); settings.AddChild(verbs); foreach (var choice in choices) { var button = FilterButton(choice.Caption, edit.Choice == choice, () => { edit.Choice = choice; Changed(true); foreach (var b in verbs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == choice.Caption); }, 0); button.ToggleMode = true; button.SetPressedNoSignal(edit.Choice == choice); verbs.AddChild(button); } } } if (!activity) { settings.AddChild(Text("赠礼数量", 15, _muted)); quantity = new ConsumerQuantity { Name = "GiftQuantity", Minimum = 1, Maximum = int.MaxValue }; quantity.Initialize(edit.Quantity); settings.AddChild(quantity); quantity.Changed += () => edit.Quantity = quantity.Value; relationship = new CheckButton { Text = "附加确定恋人关系的请求", ButtonPressed = edit.Relationship == 1 }; settings.AddChild(relationship); relationship.Toggled += value => edit.Relationship = value ? 1 : 0; hint = Text("", 15, CareerVisuals.Teal); settings.AddChild(hint); } else { title = new LineEdit { Name = "ActivityTitle", Text = edit.Title, PlaceholderText = "活动名称", CustomMinimumSize = new(0, 42) }; title.TextChanged += value => edit.Title = value; settings.AddChild(title); detail = new TextEdit { Name = "ActivityDetail", Text = edit.Detail, PlaceholderText = "补充活动内容", CustomMinimumSize = new(0, 72), WrapMode = TextEdit.LineWrappingMode.Boundary }; detail.TextChanged += () => edit.Detail = detail.Text; settings.AddChild(detail); wedding = new VBoxContainer { Name = "WeddingPartners" }; settings.AddChild(wedding); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); settings.AddChild(row); season = new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = edit.Season, Prefix = "赛季 ", CustomMinimumSize = new(150, 40), UpdateOnTextChanged = true }; row.AddChild(season); date = Text(GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day), 16, CareerVisuals.Teal); row.AddChild(date); var dates = new ScrollContainer { CustomMinimumSize = new(0, 210), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; settings.AddChild(dates); calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; dates.AddChild(calendar); season.ValueChanged += value => { edit.Season = (int)value; edit.Day = Math.Min(edit.Day, SeasonCalendar.Length(d, edit.Season)); date.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day); Calendar(); }; Calendar(); } if (shopping) { var recipients = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; recipients.AddThemeConstantOverride("separation", 10); columns.AddChild(recipients); ConsumerRecipients(recipients, edit, activity, () => { Changed(); Calendar(); }); } else settings.AddChild(Text((activity ? "同行者 · " : "接收者 · ") + string.Join("、", edit.People.Select(id => GroupChats.Name(d, id))), 16, CareerVisuals.Teal)); error = Text("", 16, new("efb3aa")); error.Name = "ConsumerEditorError"; error.Hide(); box.AddChild(error); Changed(); }, returnOutsideChat: true);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: hint = Text("", 15, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, new("efb3aa"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 16, new("efb3aa"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("现有 " + ConsumerAttachments.Available(d, good) + " 件 · 确认后补购所需数量", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("现有 " + ConsumerAttachments.Available(d, good) + " 件 · 确认后补购所需数量", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("赠礼数量", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("赠礼数量", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"${ConsumerEngine.Price(good):N0}", 27, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text($"${ConsumerEngine.Price(good):N0}", 27, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((activity ? "同行者 · " : "接收者 · ") + string.Join("、", edit.People.Select(id => GroupChats.Name(d, id))), 16, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text((activity ? "同行者 · " : "接收者 · ") + string.Join("、", edit.People.Select(id => GroupChats.Name(d, id))), 16, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day), 16, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: date = Text(GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day), 16, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(edit.Choice?.Caption ?? "选择物品", 22, _gold)`；返回值紧邻使用处：`AssignmentExpressionSyntax: selection = Text(edit.Choice?.Caption ?? "选择物品", 22, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(good.Category + " · " + good.Tier, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(good.Category + " · " + good.Tier, 14, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203b48", "526f7a", 9, 14)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203b48", "526f7a", 9, 14)`
- `NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；输入表达式：`ChatAttachments.Prepare(d, target, attachment, shopping: shopping)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ChatAttachments.Prepare(d, target, attachment, shopping: shopping) is { } message`
- `NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerAttachments.Available(d, g)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerAttachments.Available(d, g) > 0`
- `NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerAttachments.Available(d, good)`；返回值紧邻使用处：`BinaryExpressionSyntax: "现有 " + ConsumerAttachments.Available(d, good)`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(s.GoodId)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerCatalog.Get(s.GoodId)`
- `NationalSpire.ConsumerComposer.ConsumerComposer(string, string, string, System.Collections.Generic.List<string>)`；输入表达式：`new ConsumerComposer(attachment.GoodId, target, edit.Group, edit.People.ToList())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ConsumerComposer(attachment.GoodId, target, edit.Group, edit.People.ToList())`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(good)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerEngine.Price(good):N0}`
- `NationalSpire.ConsumerQuantity.ConsumerQuantity()`；输入表达式：`new ConsumerQuantity { Name = "GiftQuantity", Minimum = 1, Maximum = int.MaxValue }`；返回值紧邻使用处：`AssignmentExpressionSyntax: quantity = new ConsumerQuantity { Name = "GiftQuantity", Minimum = 1, Maximum = int.MaxValue }`
- `NationalSpire.ConsumerQuantity.Initialize(int)`；输入表达式：`quantity.Initialize(edit.Quantity)`；返回值紧邻使用处：`ExpressionStatementSyntax: quantity.Initialize(edit.Quantity);`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day)`；返回值紧邻使用处：`ArgumentSyntax: GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day)`；返回值紧邻使用处：`AssignmentExpressionSyntax: date.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`InitializerExpressionSyntax: { GroupChats.Human(d) }`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(d, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(d, id)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(d, id)`
- `NationalSpire.LifestyleArt.LifestyleArt()`；输入表达式：`new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(90, 90) }`；返回值紧邻使用处：`ArgumentSyntax: new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(90, 90) }`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = activity ? "activity" : "gift", Quantity = activity ? 1 : edit.Quantity, GoodId = edit.Choice.Good?.Id ?? "", GoodVerb = edit.Choice.Verb?.Id ?? "", ServiceId = edit.Choice.Service, WeddingServiceIds = weddingIds.ToList(), Title = edit.Title.Trim(), Detail = edit.Detail.Trim(), Season = edit.Season, Day = edit.Day, RelationshipIntent = relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0, ActorId = target, Participants = activity ? new[] { GroupChats.Human(d) }.Concat(edit.People).ToList() : [target] }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = activity ? "activity" : "gift", Quantity = activity ? 1 : edit.Quantity, GoodId = edit.Choice.Good?.Id ?? "", GoodVerb = edit.Choice.Verb?.Id ?? "", ServiceId = edit.Choice.Service, WeddingServiceIds = weddingIds.ToList(), Title = edit.Title.Trim(), Detail = edit.Detail.Trim(), Season = edit.Season, Day = edit.Day, RelationshipIntent = relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0, ActorId = target, Participants = activity ? new[] { GroupChats.Human(d) }.Concat(edit.People).ToList() : [target] }`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(d, d.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: previous?.Day ?? SeasonCalendar.Day(d, d.Day)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d, edit.Season)`；返回值紧邻使用处：`ArgumentSyntax: SeasonCalendar.Length(d, edit.Season)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d, edit.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d, edit.Season) + edit.Day`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.ConsumerEditor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.ConsumerEditor)`
- `NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`WeddingAppointments.ForParticipants(d, initialPeople)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WeddingAppointments.ForParticipants(d, initialPeople).Select`
- `NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.ServiceIds(previous)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WeddingAppointments.ServiceIds(previous).ToHashSet`
- `NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`；输入表达式：`WeddingAppointments.Services(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WeddingAppointments.Services(d).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`ConsumerCatalog.All.Where(g => shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0).SelectMany(g => g.Activities.Select(v => new ConsumerChoice(g, v))) .Concat(shopping ? [] : WeddingAppointments.ForParticipants(d, initialPeople).Select(s => new ConsumerChoice(ConsumerCatalog.Get(s.GoodId), WeddingAppointments.Verb, s.Id, s.Person)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ConsumerCatalog.All.Where(g => shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0).SelectMany(g => g.Activities.Select(v => new ConsumerChoice(g, v))) .Concat(shopping ? [] : WeddingAppointments.ForParticipants(d, initialPeople).Select(s => new ConsumerChoice(ConsumerCatalog.Get(s.GoodId), WeddingAppointments.Verb, s.Id, s.Person))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { GroupChats.Human(d) }.Concat(edit.People)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { GroupChats.Human(d) }.Concat(edit.People).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { edit.Choice.Service }.Concat(edit.WeddingServices)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { edit.Choice.Service }.Concat(edit.WeddingServices).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { new ConsumerChoice(null) }.Concat(choices)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { new ConsumerChoice(null) }.Concat(choices).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`new[] { edit.Choice.Service }.Concat(edit.WeddingServices).Where(edit.WeddingServices.Contains).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { edit.Choice.Service }.Concat(edit.WeddingServices).Where(edit.WeddingServices.Contains).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`edit.People.First()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = edit.People.First()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`choices.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: choices.FirstOrDefault()?.Verb?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`choices.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: choices.FirstOrDefault(c => c.Good?.Id == (previous?.GoodId ?? (shopping ? shop!.Good : goodId)) && (!activity || c.Verb?.Id == (previous?.GoodVerb ?? (shopping ? choices.FirstOrDefault()?.Verb?.Id : verbId))) && (previous?.ServiceId is not { Length: > 0 } || c.Service == previous.ServiceId)) ?? choices.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`WeddingAppointments.Services(d).FirstOrDefault(s => s.Id == weddingIds[0])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WeddingAppointments.Services(d).FirstOrDefault(s => s.Id == weddingIds[0]).GoodId`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`choices.FirstOrDefault(c => c.Good?.Id == (previous?.GoodId ?? (shopping ? shop!.Good : goodId)) && (!activity || c.Verb?.Id == (previous?.GoodVerb ?? (shopping ? choices.FirstOrDefault()?.Verb?.Id : verbId))) && (previous?.ServiceId is not { Length: > 0 } || c.Service == previous.ServiceId))`；返回值紧邻使用处：`BinaryExpressionSyntax: choices.FirstOrDefault(c => c.Good?.Id == (previous?.GoodId ?? (shopping ? shop!.Good : goodId)) && (!activity || c.Verb?.Id == (previous?.GoodVerb ?? (shopping ? choices.FirstOrDefault()?.Verb?.Id : verbId))) && (previous?.ServiceId is not { Length: > 0 } || c.Service == previous.ServiceId)) ?? choices.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ConsumerCatalog.All.Where(g => g.Giftable && (shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0)).Select(g => new ConsumerChoice(g))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ConsumerCatalog.All.Where(g => g.Giftable && (shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0)).Select(g => new ConsumerChoice(g)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`WeddingAppointments.ForParticipants(d, initialPeople).Select(s => new ConsumerChoice(ConsumerCatalog.Get(s.GoodId), WeddingAppointments.Verb, s.Id, s.Person))`；返回值紧邻使用处：`ConditionalExpressionSyntax: shopping ? [] : WeddingAppointments.ForParticipants(d, initialPeople).Select(s => new ConsumerChoice(ConsumerCatalog.Get(s.GoodId), WeddingAppointments.Verb, s.Id, s.Person))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`edit.People.Select(id => GroupChats.Name(d, id))`；返回值紧邻使用处：`ArgumentSyntax: edit.People.Select(id => GroupChats.Name(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Activities.Select(v => new ConsumerChoice(g, v))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Activities.Select(v => new ConsumerChoice(g, v))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`ConsumerCatalog.All.Where(g => shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0).SelectMany(g => g.Activities.Select(v => new ConsumerChoice(g, v)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ConsumerCatalog.All.Where(g => shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0).SelectMany(g => g.Activities.Select(v => new ConsumerChoice(g, v))) .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`ConsumerCatalog.All.Where(g => g.Giftable && (shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0)).Select(g => new ConsumerChoice(g)).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: activity ? ConsumerCatalog.All.Where(g => shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0).SelectMany(g => g.Activities.Select(v => new ConsumerChoice(g, v))) .Concat(shopping ? [] : WeddingAppointments.ForParticipants(d, initialPeople).Select(s => new ConsumerChoice(ConsumerCatalog.Get(s.GoodId), WeddingAppointments.Verb, s.Id, s.Person))).ToArray() : ConsumerCatalog.All.Where(g => g.Giftable && (shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0)).Select(g => new ConsumerChoice(g)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`ConsumerCatalog.All.Where(g => shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0).SelectMany(g => g.Activities.Select(v => new ConsumerChoice(g, v))) .Concat(shopping ? [] : WeddingAppointments.ForParticipants(d, initialPeople).Select(s => new ConsumerChoice(ConsumerCatalog.Get(s.GoodId), WeddingAppointments.Verb, s.Id, s.Person))).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: activity ? ConsumerCatalog.All.Where(g => shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0).SelectMany(g => g.Activities.Select(v => new ConsumerChoice(g, v))) .Concat(shopping ? [] : WeddingAppointments.ForParticipants(d, initialPeople).Select(s => new ConsumerChoice(ConsumerCatalog.Get(s.GoodId), WeddingAppointments.Verb, s.Id, s.Person))).ToArray() : ConsumerCatalog.All.Where(g => g.Giftable && (shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0)).Select(g => new ConsumerChoice(g)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[] { edit.Choice.Service }.Concat(edit.WeddingServices).Where(edit.WeddingServices.Contains).Distinct().ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: activity && edit.Choice.Service.Length > 0 ? new[] { edit.Choice.Service }.Concat(edit.WeddingServices).Where(edit.WeddingServices.Contains).Distinct().ToArray() : []`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[] { new ConsumerChoice(null) }.Concat(choices).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: choices = new[] { new ConsumerChoice(null) }.Concat(choices).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`WeddingAppointments.ServiceIds(previous).ToHashSet()`；返回值紧邻使用处：`ConditionalExpressionSyntax: previous != null ? WeddingAppointments.ServiceIds(previous).ToHashSet() : edit.Choice?.Service is { Length: > 0 } service ? [service] : []`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`initialPeople.Where(id => id.Length > 0 && !GroupChats.IsHuman(d, id)).ToHashSet()`；返回值紧邻使用处：`AssignmentExpressionSyntax: People = initialPeople.Where(id => id.Length > 0 && !GroupChats.IsHuman(d, id)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`edit.People.ToList()`；返回值紧邻使用处：`ArgumentSyntax: edit.People.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`new[] { GroupChats.Human(d) }.Concat(edit.People).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: activity ? new[] { GroupChats.Human(d) }.Concat(edit.People).ToList() : [target]`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`weddingIds.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: WeddingServiceIds = weddingIds.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ConsumerCatalog.All.Where(g => g.Giftable && (shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ConsumerCatalog.All.Where(g => g.Giftable && (shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ConsumerCatalog.All.Where(g => shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ConsumerCatalog.All.Where(g => shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`initialPeople.Where(id => id.Length > 0 && !GroupChats.IsHuman(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: initialPeople.Where(id => id.Length > 0 && !GroupChats.IsHuman(d, id)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { edit.Choice.Service }.Concat(edit.WeddingServices).Where(edit.WeddingServices.Contains)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { edit.Choice.Service }.Concat(edit.WeddingServices).Where(edit.WeddingServices.Contains).Distinct`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string> { person }`；返回值紧邻使用处：`ConditionalExpressionSyntax: group.Length > 0 ? _groupSelection : new List<string> { person }`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`verbs.GetChildren().OfType<Button>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var b in verbs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == choice.Caption);`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(240, Math.Min(650, _stage.Size.Y - 230))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(240, Math.Min(650, _stage.Size.Y - 230))`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(1120, _stage.Size.X - 100)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(1120, _stage.Size.X - 100)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(650, _stage.Size.Y - 230)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(650, _stage.Size.Y - 230)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(edit.Day, SeasonCalendar.Length(d, edit.Season))`；返回值紧邻使用处：`AssignmentExpressionSyntax: edit.Day = Math.Min(edit.Day, SeasonCalendar.Length(d, edit.Season))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", edit.People.Select(id => GroupChats.Name(d, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: (activity ? "同行者 · " : "接收者 · ") + string.Join("、", edit.People.Select(id => GroupChats.Name(d, id)))`
- `string.Trim()`；输入表达式：`edit.Detail.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Detail = edit.Detail.Trim()`
- `string.Trim()`；输入表达式：`edit.Title.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Title = edit.Title.Trim()`

**赋值（含属性/字段和局部值）：**

- `ActorId` = `target`
- `ButtonPressed` = `edit.Relationship == 1`
- `Category` = `good.Category + " " + good.Name`
- `CustomMinimumSize` = `new(0, 210)`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(0, 72)`
- `CustomMinimumSize` = `new(0, Math.Max(240, Math.Min(650, _stage.Size.Y - 230)))`
- `CustomMinimumSize` = `new(150, 40)`
- `CustomMinimumSize` = `new(90, 90)`
- `Day` = `edit.Day`
- `Day` = `previous?.Day ?? SeasonCalendar.Day(d, d.Day)`
- `Detail` = `edit.Detail.Trim()`
- `GoodId` = `edit.Choice.Good?.Id ?? ""`
- `GoodVerb` = `edit.Choice.Verb?.Id ?? ""`
- `Group` = `group`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Kind` = `activity ? "activity" : "gift"`
- `MaxValue` = `int.MaxValue`
- `Maximum` = `int.MaxValue`
- `MinValue` = `d.Season`
- `Minimum` = `1`
- `Name` = `"ActivityDetail"`
- `Name` = `"ActivityTitle"`
- `Name` = `"ConsumerEditorScroll"`
- `Name` = `"GiftQuantity"`
- `Name` = `"WeddingPartners"`
- `Participants` = `activity ? new[] { GroupChats.Human(d) }.Concat(edit.People).ToList() : [target]`
- `People` = `initialPeople.Where(id => id.Length > 0 && !GroupChats.IsHuman(d, id)).ToHashSet()`
- `PlaceholderText` = `"活动名称"`
- `PlaceholderText` = `"补充活动内容"`
- `Prefix` = `"赛季 "`
- `ProductId` = `good.Id`
- `Quantity` = `activity ? 1 : edit.Quantity`
- `Quantity` = `previous?.Quantity ?? 1`
- `RelationshipIntent` = `relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0`
- `Relationship` = `previous?.RelationshipIntent ?? 0`
- `Season` = `edit.Season`
- `Season` = `previous?.Season ?? d.Season`
- `ServiceId` = `edit.Choice.Service`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `"附加确定恋人关系的请求"`
- `Text` = `edit.Detail`
- `Text` = `edit.Title`
- `Title` = `edit.Title.Trim()`
- `UpdateOnTextChanged` = `true`
- `Value` = `edit.Season`
- `WeddingServiceIds` = `weddingIds.ToList()`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`
- `attachment.GoodId` = `weddingGood ?? ""`
- `attachment.ServiceId` = `weddingIds[0]`
- `body.MinimumSizeChanged` += `FitContent`
- `body.Resized` += `FitContent`
- `box.CustomMinimumSize` = `new(width, 0)`
- `button.ToggleMode` = `true`
- `calendar` = `new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `choices` = `new[] { new ConsumerChoice(null) }.Concat(choices).ToArray()`
- `date.Text` = `GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day)`
- `date` = `Text(GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day), 16, CareerVisuals.Teal)`
- `detail.TextChanged` += `() => edit.Detail = detail.Text`
- `detail` = `new TextEdit { Name = "ActivityDetail", Text = edit.Detail, PlaceholderText = "补充活动内容", CustomMinimumSize = new(0, 72), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `edit.Choice` = `choice`
- `edit.Choice` = `choices.FirstOrDefault(c => c.Good?.Id == (previous?.GoodId ?? (shopping ? shop!.Good : goodId)) && (!activity || c.Verb?.Id == (previous?.GoodVerb ?? (shopping ? choices.FirstOrDefault()?.Verb?.Id : verbId))) && (previous?.ServiceId is not { Length: > 0 } || c.Service == previous.ServiceId)) ?? choices.FirstOrDefault()`
- `edit.Day` = `Math.Min(edit.Day, SeasonCalendar.Length(d, edit.Season))`
- `edit.Detail` = `detail.Text`
- `edit.Detail` = `previous?.Detail ?? (activity ? edit.Choice?.ActivityDetail(d) ?? "" : "")`
- `edit.Quantity` = `quantity.Value`
- `edit.Relationship` = `value ? 1 : 0`
- `edit.Season` = `(int)value`
- `edit.Title` = `previous?.Title ?? edit.Choice?.Verb?.Name ?? ""`
- `edit.Title` = `value`
- `edit.WeddingServices` = `previous != null ? WeddingAppointments.ServiceIds(previous).ToHashSet() : edit.Choice?.Service is { Length: > 0 } service ? [service] : []`
- `error.Name` = `"ConsumerEditorError"`
- `error` = `Text("", 16, new("efb3aa"))`
- `hint` = `Text("", 15, CareerVisuals.Teal)`
- `quantity.Changed` += `() => edit.Quantity = quantity.Value`
- `quantity` = `new ConsumerQuantity { Name = "GiftQuantity", Minimum = 1, Maximum = int.MaxValue }`
- `relationship.Toggled` += `value => edit.Relationship = value ? 1 : 0`
- `relationship` = `new CheckButton { Text = "附加确定恋人关系的请求", ButtonPressed = edit.Relationship == 1 }`
- `season.ValueChanged` += `value => { edit.Season = (int)value; edit.Day = Math.Min(edit.Day, SeasonCalendar.Length(d, edit.Season)); date.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day); Calendar(); }`
- `season` = `new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = edit.Season, Prefix = "赛季 ", CustomMinimumSize = new(150, 40), UpdateOnTextChanged = true }`
- `selection.Name` = `"ConsumerSelectedProduct"`
- `selection` = `Text(edit.Choice?.Caption ?? "选择物品", 22, _gold)`
- `title.TextChanged` += `value => edit.Title = value`
- `title` = `new LineEdit { Name = "ActivityTitle", Text = edit.Title, PlaceholderText = "活动名称", CustomMinimumSize = new(0, 42) }`
- `wedding` = `new VBoxContainer { Name = "WeddingPartners" }`

<a id="symbol-2499f8db4ac1"></a>

## `Error(string) — void Error(string text)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Changed(bool)`](ConsumerPickerScreen.cs.md#symbol-4cac190b7ec0)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`WeddingChoices()`](ConsumerPickerScreen.cs.md#symbol-667c9af3e555)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `error!.Text` = `text`
- `error.Visible` = `text.Length > 0`

<a id="symbol-58bbb914e92d"></a>

## `WeddingCost() — void WeddingCost()`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`WeddingChoices()`](ConsumerPickerScreen.cs.md#symbol-667c9af3e555)

**调用：** [`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](WeddingAppointments.cs.md#symbol-e0e8b388fcb4)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerEdit.People`；`NationalSpire.CareerScreen.ConsumerEdit.WeddingServices`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.Good.Name`；`NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(g.Key)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(g.Key)?.Name`
- `NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`WeddingAppointments.ForParticipants(d, edit.People)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WeddingAppointments.ForParticipants(d, edit.People).Where`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`edit.WeddingServices.Contains(s.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => edit.WeddingServices.Contains(s.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Count()`；返回值紧邻使用处：`InterpolationSyntax: {g.Count()}`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`selected.GroupBy(s => s.GoodId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: selected.GroupBy(s => s.GoodId).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`selected.GroupBy(s => s.GoodId).Select(g => $"{ConsumerCatalog.Get(g.Key)?.Name} ×{g.Count()}")`；返回值紧邻使用处：`ArgumentSyntax: selected.GroupBy(s => s.GoodId).Select(g => $"{ConsumerCatalog.Get(g.Key)?.Name} ×{g.Count()}")`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`WeddingAppointments.ForParticipants(d, edit.People).Where(s => edit.WeddingServices.Contains(s.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = WeddingAppointments.ForParticipants(d, edit.People).Where(s => edit.WeddingServices.Contains(s.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`WeddingAppointments.ForParticipants(d, edit.People).Where(s => edit.WeddingServices.Contains(s.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WeddingAppointments.ForParticipants(d, edit.People).Where(s => edit.WeddingServices.Contains(s.Id)).ToArray`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", selected.GroupBy(s => s.GoodId).Select(g => $"{ConsumerCatalog.Get(g.Key)?.Name} ×{g.Count()}"))`；返回值紧邻使用处：`ConditionalExpressionSyntax: selected.Length == 0 ? "请选择结婚对象" : string.Join("、", selected.GroupBy(s => s.GoodId).Select(g => $"{ConsumerCatalog.Get(g.Key)?.Name} ×{g.Count()}"))`

**赋值（含属性/字段和局部值）：**

- `weddingCost.Text` = `$"结婚对象 {selected.Length} 人 · 本场使用 " + (selected.Length == 0 ? "请选择结婚对象" : string.Join("、", selected.GroupBy(s => s.GoodId).Select(g => $"{ConsumerCatalog.Get(g.Key)?.Name} ×{g.Count()}")))`

<a id="symbol-667c9af3e555"></a>

## `WeddingChoices() — void WeddingChoices()`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Changed(bool)`](ConsumerPickerScreen.cs.md#symbol-4cac190b7ec0)

**调用：** [`Error(string)`](ConsumerPickerScreen.cs.md#symbol-2499f8db4ac1)；`Godot.CheckButton.CheckButton()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](WeddingAppointments.cs.md#symbol-e0e8b388fcb4)；`System.Array.FindIndex<T>(T[], System.Predicate<T>)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；[`WeddingCost()`](ConsumerPickerScreen.cs.md#symbol-58bbb914e92d)

**字段、属性、事件及方法组引用：** `Error(string)`；`NationalSpire.CareerScreen.ConsumerChoice.Service`；`NationalSpire.CareerScreen.ConsumerEdit.Choice`；`NationalSpire.CareerScreen.ConsumerEdit.People`；`NationalSpire.CareerScreen.ConsumerEdit.WeddingServices`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.Good.Name`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；`WeddingCost()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Error(string)`；输入表达式：`Error("")`；返回值紧邻使用处：`ExpressionStatementSyntax: Error("");`
- `Godot.CheckButton.CheckButton()`；输入表达式：`new CheckButton { Name = "WeddingPartner_" + service.Person, Text = GroupChats.Name(d, service.Person) + " · " + ConsumerCatalog.Get(service.GoodId)?.Name, ButtonPressed = edit.WeddingServices.Contains(service.Id), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckButton { Name = "WeddingPartner_" + service.Person, Text = GroupChats.Name(d, service.Person) + " · " + ConsumerCatalog.Get(service.GoodId)?.Name, ButtonPressed = edit.WeddingServices.Contains(service.Id), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(toggle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(use)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(use);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`wedding.AddChild(Text("结婚对象 · 可同时选择多位，其余同行者作为宾客", 15, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: wedding.AddChild(Text("结婚对象 · 可同时选择多位，其余同行者作为宾客", 15, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`wedding.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: wedding.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`wedding.AddChild(weddingCost)`；返回值紧邻使用处：`ExpressionStatementSyntax: wedding.AddChild(weddingCost);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`use.AddItem($"{ConsumerCatalog.Get(item.GoodId)?.Name} · 可用 {item.Remaining} 份")`；返回值紧邻使用处：`ExpressionStatementSyntax: use.AddItem($"{ConsumerCatalog.Get(item.GoodId)?.Name} · 可用 {item.Remaining} 份");`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "WeddingService_" + service.Person, CustomMinimumSize = new(210, 40) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "WeddingService_" + service.Person, CustomMinimumSize = new(210, 40) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`use.Select(Array.FindIndex(available, item => item.Id == selectedId))`；返回值紧邻使用处：`ExpressionStatementSyntax: use.Select(Array.FindIndex(available, item => item.Id == selectedId));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(210, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(210, 40)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: weddingCost = Text("", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("结婚对象 · 可同时选择多位，其余同行者作为宾客", 15, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text("结婚对象 · 可同时选择多位，其余同行者作为宾客", 15, CareerVisuals.Teal)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(wedding)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(wedding);`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(chosen.GoodId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(chosen.GoodId)?.Name`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(item.GoodId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(item.GoodId)?.Name`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(service.GoodId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(service.GoodId)?.Name`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, chosen.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(d, chosen.Person) + " · "`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, service.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(d, service.Person) + " · "`
- `NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`WeddingAppointments.ForParticipants(d, edit.People)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WeddingAppointments.ForParticipants(d, edit.People).GroupBy`
- `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；输入表达式：`Array.FindIndex(available, item => item.Id == selectedId)`；返回值紧邻使用处：`ArgumentSyntax: Array.FindIndex(available, item => item.Id == selectedId)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`edit.WeddingServices.Add(selectedId)`；返回值紧邻使用处：`ExpressionStatementSyntax: edit.WeddingServices.Add(selectedId);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`edit.WeddingServices.Contains(s.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => edit.WeddingServices.Contains(s.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`edit.WeddingServices.Contains(service.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ButtonPressed = edit.WeddingServices.Contains(service.Id)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`edit.WeddingServices.Remove(other.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: edit.WeddingServices.Remove(other.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`personServices.First()`；返回值紧邻使用处：`AssignmentExpressionSyntax: service = personServices.First()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`personServices.FirstOrDefault(s => edit.WeddingServices.Contains(s.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = personServices.FirstOrDefault(s => edit.WeddingServices.Contains(s.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`WeddingAppointments.ForParticipants(d, edit.People).GroupBy(s => s.Person)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var personServices in WeddingAppointments.ForParticipants(d, edit.People).GroupBy(s => s.Person)) { var service = personServices.FirstOrDefault(s => edit.WeddingServices.Contains(s.Id)); if (service.Id == null) service = personServices.First(); var available = personServices.ToArray(); string selectedId = service.Id; var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); wedding.AddChild(row); var toggle = new CheckButton { Name = "WeddingPartner_" + service.Person, Text = GroupChats.Name(d, service.Person) + " · " + ConsumerCatalog.Get(service.GoodId)?.Name, ButtonPressed = edit.WeddingServices.Contains(service.Id), SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(toggle); toggle.Toggled += value => { foreach (var other in available) edit.WeddingServices.Remove(other.Id); if (value) edit.WeddingServices.Add(selectedId); if (error != null) Error(""); WeddingCost(); }; if (available.Length > 1) { var use = new OptionButton { Name = "WeddingService_" + service.Person, CustomMinimumSize = new(210, 40) }; foreach (var item in available) use.AddItem($"{ConsumerCatalog.Get(item.GoodId)?.Name} · 可用 {item.Remaining} 份"); use.Select(Array.FindIndex(available, item => item.Id == selectedId)); row.AddChild(use); use.ItemSelected += index => { foreach (var other in available) edit.WeddingServices.Remove(other.Id); var chosen = available[(int)index]; selectedId = chosen.Id; toggle.Text = GroupChats.Name(d, chosen.Person) + " · " + ConsumerCatalog.Get(chosen.GoodId)?.Name; if (toggle.ButtonPressed) edit.WeddingServices.Add(selectedId); if (error != null) Error(""); WeddingCost(); }; } }`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`personServices.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = personServices.ToArray()`
- `WeddingCost()`；输入表达式：`WeddingCost()`；返回值紧邻使用处：`ExpressionStatementSyntax: WeddingCost();`

**赋值（含属性/字段和局部值）：**

- `ButtonPressed` = `edit.WeddingServices.Contains(service.Id)`
- `CustomMinimumSize` = `new(210, 40)`
- `Name` = `"WeddingPartner_" + service.Person`
- `Name` = `"WeddingService_" + service.Person`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `GroupChats.Name(d, service.Person) + " · " + ConsumerCatalog.Get(service.GoodId)?.Name`
- `selectedId` = `chosen.Id`
- `service` = `personServices.First()`
- `toggle.Text` = `GroupChats.Name(d, chosen.Person) + " · " + ConsumerCatalog.Get(chosen.GoodId)?.Name`
- `toggle.Toggled` += `value => { foreach (var other in available) edit.WeddingServices.Remove(other.Id); if (value) edit.WeddingServices.Add(selectedId); if (error != null) Error(""); WeddingCost(); }`
- `use.ItemSelected` += `index => { foreach (var other in available) edit.WeddingServices.Remove(other.Id); var chosen = available[(int)index]; selectedId = chosen.Id; toggle.Text = GroupChats.Name(d, chosen.Person) + " · " + ConsumerCatalog.Get(chosen.GoodId)?.Name; if (toggle.ButtonPressed) edit.WeddingServices.Add(selectedId); if (error != null) Error(""); WeddingCost(); }`
- `wedding.Visible` = `edit.Choice?.Service.Length > 0`
- `weddingCost.Name` = `"WeddingConsumption"`
- `weddingCost` = `Text("", 15, _muted)`
- `weddingCost` = `null`

<a id="symbol-8eb2036c6dbc"></a>

## `Calendar() — void Calendar()`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)

**调用：** [`NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`](AppointmentCalendarScreen.cs.md#symbol-b5cb4cb371f4)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`；`NationalSpire.CareerScreen.ConsumerEdit.Day`；`NationalSpire.CareerScreen.ConsumerEdit.People`；`NationalSpire.CareerScreen.ConsumerEdit.Season`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`calendar.AddChild(AppointmentCalendar(d, edit.Season, edit.People.ToArray(), edit.Day, value => { edit.Day = value; date!.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + value); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: calendar.AddChild(AppointmentCalendar(d, edit.Season, edit.People.ToArray(), edit.Day, value => { edit.Day = value; date!.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + value); }));`
- `NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`；输入表达式：`AppointmentCalendar(d, edit.Season, edit.People.ToArray(), edit.Day, value => { edit.Day = value; date!.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + value); })`；返回值紧邻使用处：`ArgumentSyntax: AppointmentCalendar(d, edit.Season, edit.People.ToArray(), edit.Day, value => { edit.Day = value; date!.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + value); })`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(calendar)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(calendar);`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + value)`；返回值紧邻使用处：`AssignmentExpressionSyntax: date!.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + value)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d, edit.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d, edit.Season) + value`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`edit.People.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: edit.People.ToArray()`

**赋值（含属性/字段和局部值）：**

- `date!.Text` = `GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + value)`
- `edit.Day` = `value`

<a id="symbol-4cac190b7ec0"></a>

## `Changed(bool) — void Changed(bool product = false)`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)

**调用：** [`Error(string)`](ConsumerPickerScreen.cs.md#symbol-2499f8db4ac1)；`Godot.Node.FindChild(string, bool, bool)`；[`NationalSpire.CareerScreen.ConsumerChoice.ActivityDetail(NationalSpire.CareerData)`](ConsumerPickerScreen.cs.md#symbol-74f147844628)；[`NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerAttachments.cs.md#symbol-6c24344e1310)；[`NationalSpire.ConsumerQuantity.SetValue(int)`](ConsumerGiftControls.cs.md#symbol-e2e90c4c8401)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.RelationshipGifts.Special(string)`](RelationshipGifts.cs.md#symbol-d05881b51110)；[`NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](WeddingAppointments.cs.md#symbol-e0e8b388fcb4)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`；`System.Math.Min(long, long)`；[`WeddingChoices()`](ConsumerPickerScreen.cs.md#symbol-667c9af3e555)

**字段、属性、事件及方法组引用：** `Error(string)`；`NationalSpire.CareerScreen.ConsumerChoice.ActivityDetail(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ConsumerChoice.Caption`；`NationalSpire.CareerScreen.ConsumerChoice.Good`；`NationalSpire.CareerScreen.ConsumerChoice.Service`；`NationalSpire.CareerScreen.ConsumerChoice.ServicePerson`；`NationalSpire.CareerScreen.ConsumerChoice.Verb`；`NationalSpire.CareerScreen.ConsumerEdit.Choice`；`NationalSpire.CareerScreen.ConsumerEdit.Detail`；`NationalSpire.CareerScreen.ConsumerEdit.People`；`NationalSpire.CareerScreen.ConsumerEdit.Quantity`；`NationalSpire.CareerScreen.ConsumerEdit.Title`；`NationalSpire.CareerScreen.ConsumerEdit.WeddingServices`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerQuantity.Maximum`；`NationalSpire.ConsumerQuantity.SetValue(int)`；`NationalSpire.ConsumerQuantity.Value`；`NationalSpire.Good.Id`；`NationalSpire.Good.Instant`；`NationalSpire.GoodVerb.Name`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.SelectedBond`；`NationalSpire.RelationshipGifts.Special(string)`；`NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；`WeddingChoices()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Error(string)`；输入表达式：`Error("")`；返回值紧邻使用处：`ExpressionStatementSyntax: Error("");`
- `Godot.Node.FindChild(string, bool, bool)`；输入表达式：`.FindChild("CareerDialogConfirm", true, false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dialogOverlay?.FindChild("CareerDialogConfirm", true, false)`
- `NationalSpire.CareerScreen.ConsumerChoice.ActivityDetail(NationalSpire.CareerData)`；输入表达式：`.ActivityDetail(d)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: edit.Choice?.ActivityDetail(d)`
- `NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerAttachments.Available(d, g)`；返回值紧邻使用处：`ConditionalExpressionSyntax: edit.Choice?.Good is { } g ? ConsumerAttachments.Available(d, g) : 1`
- `NationalSpire.ConsumerQuantity.SetValue(int)`；输入表达式：`quantity.SetValue(Math.Min(edit.Quantity, quantity.Maximum))`；返回值紧邻使用处：`ExpressionStatementSyntax: quantity.SetValue(Math.Min(edit.Quantity, quantity.Maximum));`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.Length > 0 ? PrivateMessages.Relation(d, id) : null`
- `NationalSpire.RelationshipGifts.Special(string)`；输入表达式：`RelationshipGifts.Special(edit.Choice?.Good?.Id ?? "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RelationshipGifts.Special(edit.Choice?.Good?.Id ?? "")`
- `NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`WeddingAppointments.ForParticipants(d, [edit.Choice.ServicePerson])`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var other in WeddingAppointments.ForParticipants(d, [edit.Choice.ServicePerson])) edit.WeddingServices.Remove(other.Id);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`edit.WeddingServices.Add(service)`；返回值紧邻使用处：`ExpressionStatementSyntax: edit.WeddingServices.Add(service);`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`edit.WeddingServices.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: edit.WeddingServices.Clear();`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`edit.WeddingServices.Remove(other.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: edit.WeddingServices.Remove(other.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`edit.People.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: edit.People.FirstOrDefault() ?? ""`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, quantity.Maximum)`；返回值紧邻使用处：`AssignmentExpressionSyntax: quantity.Maximum = Math.Max(1, quantity.Maximum)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(edit.Quantity, quantity.Maximum)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(edit.Quantity, quantity.Maximum)`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(int.MaxValue, edit.Choice?.Good is { } g ? ConsumerAttachments.Available(d, g) : 1)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(int.MaxValue, edit.Choice?.Good is { } g ? ConsumerAttachments.Available(d, g) : 1)`
- `WeddingChoices()`；输入表达式：`WeddingChoices()`；返回值紧邻使用处：`ExpressionStatementSyntax: WeddingChoices();`

**赋值（含属性/字段和局部值）：**

- `confirm.Text` = `shopping || edit.Choice?.Good?.Instant == true ? "确认费用" : "添加到消息"`
- `detail!.Text` = `edit.Detail`
- `edit.Detail` = `edit.Choice?.ActivityDetail(d) ?? ""`
- `edit.Quantity` = `quantity.Value`
- `edit.Title` = `edit.Choice?.Verb?.Name ?? ""`
- `hint!.Text` = `special ? "对方接收后，玩家可以在聊天的“+”号中选择“约定活动”，并选择其中的婚礼活动。从该入口完成婚礼即可正式缔结誓约。" : relationship.Visible ? "对方接受礼物后，确定恋人关系。" : ""`
- `hint.Visible` = `hint.Text.Length > 0`
- `quantity.Maximum` = `Math.Max(1, quantity.Maximum)`
- `quantity.Maximum` = `shopping ? int.MaxValue : (int)Math.Min(int.MaxValue, edit.Choice?.Good is { } g ? ConsumerAttachments.Available(d, g) : 1)`
- `relationship.Visible` = `id.Length > 0 && !special && relation!.Favour >= 60 && relation.SelectedBond is not >= 1 && !relation.OathConfirmed`
- `selection!.Text` = `edit.Choice?.Caption ?? "暂无可用物品"`
- `title!.Text` = `edit.Title`

<a id="symbol-3854743a5c61"></a>

## `ReturnEditor() — void ReturnEditor()`

来源：源码第 175 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`；输入表达式：`ConsumerEditor(activity, shop, previous, goodId, verbId, edit)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ConsumerEditor(activity, shop, previous, goodId, verbId, edit)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-526ebcd28e67"></a>

## `FitContent() — void FitContent()`

来源：源码第 204 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.GetCombinedMinimumSize()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Clamp(float, float, float)`；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._stage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`body.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.GetCombinedMinimumSize().Y`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: scroll.CustomMinimumSize = new(0, height)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(body.GetCombinedMinimumSize().Y, 180, Math.Max(240, Math.Min(650, _stage.Size.Y - 230)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(body.GetCombinedMinimumSize().Y, 180, Math.Max(240, Math.Min(650, _stage.Size.Y - 230)))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(240, Math.Min(650, _stage.Size.Y - 230))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(240, Math.Min(650, _stage.Size.Y - 230))`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(650, _stage.Size.Y - 230)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(650, _stage.Size.Y - 230)`

**赋值（含属性/字段和局部值）：**

- `scroll.CustomMinimumSize` = `new(0, height)`

<a id="symbol-d76de74a5483"></a>

## `NationalSpire.CareerScreen.ConsumerRecipients(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerEdit, bool, System.Action) — private void ConsumerRecipients(VBoxContainer parent, ConsumerEdit edit, bool activity, Action changed)`

来源：源码第 249 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`Show(bool)`](ConsumerPickerScreen.cs.md#symbol-bfd48d04a658)；`System.Action.Invoke()`；`System.Collections.Generic.HashSet<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerEdit.Group`；`NationalSpire.CareerScreen.ConsumerEdit.People`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerScreen.ViewData`；`Show(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 10);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(tabs)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(tabs);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(direct)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(direct);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(groupsTab)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(groupsTab);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton("私聊", edit.Group.Length == 0, () => { edit.Group = ""; edit.People.Clear(); Show(false); changed(); }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton("私聊", edit.Group.Length == 0, () => { edit.Group = ""; edit.People.Clear(); Show(false); changed(); }, 0)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton("群聊", edit.Group.Length > 0, () => { edit.Group = ""; edit.People.Clear(); Show(true); changed(); }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton("群聊", edit.Group.Length > 0, () => { edit.Group = ""; edit.People.Clear(); Show(true); changed(); }, 0)`
- `Show(bool)`；输入表达式：`Show(edit.Group.Length > 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: Show(edit.Group.Length > 0);`
- `Show(bool)`；输入表达式：`Show(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Show(false);`
- `Show(bool)`；输入表达式：`Show(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Show(true);`
- `System.Action.Invoke()`；输入表达式：`changed()`；返回值紧邻使用处：`ExpressionStatementSyntax: changed();`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`edit.People.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: edit.People.Clear();`

**赋值（含属性/字段和局部值）：**

- `direct.Name` = `"RecipientDirect"`
- `direct.ToggleMode` = `true`
- `edit.Group` = `""`
- `groupsTab.Name` = `"RecipientGroups"`
- `groupsTab.ToggleMode` = `true`

<a id="symbol-bfd48d04a658"></a>

## `Show(bool) — void Show(bool groups)`

来源：源码第 253 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerRecipients(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerEdit, bool, System.Action)`](ConsumerPickerScreen.cs.md#symbol-d76de74a5483)

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`Groups()`](ConsumerPickerScreen.cs.md#symbol-0aa3d7203ee8)；[`Members()`](ConsumerPickerScreen.cs.md#symbol-cf168b0ee57f)；[`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool)`](PeoplePickerScreen.cs.md#symbol-80a307ead785)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.IEnumerable.OfType<TResult>()`

**字段、属性、事件及方法组引用：** `Groups()`；`Members()`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerScreen.ConsumerEdit.People`；`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`button.SetPressedNoSignal(button.Name == (groups ? "RecipientGroups" : "RecipientDirect"))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetPressedNoSignal(button.Name == (groups ? "RecipientGroups" : "RecipientDirect"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`members.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: members.AddThemeConstantOverride("separation", 8);`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "RecipientGroupSearch", PlaceholderText = "搜索群聊", CustomMinimumSize = new(0, 40) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "RecipientGroupSearch", PlaceholderText = "搜索群聊", CustomMinimumSize = new(0, 40) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(members)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(members);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(groupList)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(groupList);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`tabs.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tabs.GetChildren().OfType<Button>`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(0, 98), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(0, 98), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 40)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 98)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 98)`
- `Groups()`；输入表达式：`Groups()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Groups()`
- `Groups()`；输入表达式：`Groups()`；返回值紧邻使用处：`ExpressionStatementSyntax: Groups();`
- `Members()`；输入表达式：`Members()`；返回值紧邻使用处：`ExpressionStatementSyntax: Members();`
- `NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool)`；输入表达式：`PeoplePicker(content, d.People.Where(p => PrivateMessages.CanChat(d, p.Id)).ToArray(), edit.People, true, changed)`；返回值紧邻使用处：`ExpressionStatementSyntax: PeoplePicker(content, d.People.Where(p => PrivateMessages.CanChat(d, p.Id)).ToArray(), edit.People, true, changed);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(content);`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => PrivateMessages.CanChat(d, p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.People.Where(p => PrivateMessages.CanChat(d, p.Id)).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: d.People.Where(p => PrivateMessages.CanChat(d, p.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => PrivateMessages.CanChat(d, p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => PrivateMessages.CanChat(d, p.Id)).ToArray`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`tabs.GetChildren().OfType<Button>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var button in tabs.GetChildren().OfType<Button>()) button.SetPressedNoSignal(button.Name == (groups ? "RecipientGroups" : "RecipientDirect"));`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 40)`
- `CustomMinimumSize` = `new(0, 98)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Name` = `"RecipientGroupSearch"`
- `PlaceholderText` = `"搜索群聊"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `search.TextChanged` += `_ => Groups()`

<a id="symbol-cf168b0ee57f"></a>

## `Members() — void Members()`

来源：源码第 263 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Groups()`](ConsumerPickerScreen.cs.md#symbol-0aa3d7203ee8)；[`Show(bool)`](ConsumerPickerScreen.cs.md#symbol-bfd48d04a658)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool)`](PeoplePickerScreen.cs.md#symbol-80a307ead785)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerScreen.ConsumerEdit.Group`；`NationalSpire.CareerScreen.ConsumerEdit.People`；`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`members.AddChild(Text(group.Name + (activity ? " · 选择同行成员" : " · 选择一位接收者"), 16, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: members.AddChild(Text(group.Name + (activity ? " · 选择同行成员" : " · 选择一位接收者"), 16, _gold));`
- `NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool)`；输入表达式：`PeoplePicker(members, d.People.Where(p => group.Members.Contains(p.Id) && PrivateMessages.CanChat(d, p.Id)).ToArray(), edit.People, !activity, changed, 164, showPortraits: activity)`；返回值紧邻使用处：`ExpressionStatementSyntax: PeoplePicker(members, d.People.Where(p => group.Members.Contains(p.Id) && PrivateMessages.CanChat(d, p.Id)).ToArray(), edit.People, !activity, changed, 164, showPortraits: activity);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(group.Name + (activity ? " · 选择同行成员" : " · 选择一位接收者"), 16, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(group.Name + (activity ? " · 选择同行成员" : " · 选择一位接收者"), 16, _gold)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(members)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(members);`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(d).FirstOrDefault`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: group.Members.Contains(p.Id) && PrivateMessages.CanChat(d, p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GroupChats.Visible(d).FirstOrDefault(g => g.Id == edit.Group)`；返回值紧邻使用处：`IsPatternExpressionSyntax: GroupChats.Visible(d).FirstOrDefault(g => g.Id == edit.Group) is not { } group`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.People.Where(p => group.Members.Contains(p.Id) && PrivateMessages.CanChat(d, p.Id)).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: d.People.Where(p => group.Members.Contains(p.Id) && PrivateMessages.CanChat(d, p.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => group.Members.Contains(p.Id) && PrivateMessages.CanChat(d, p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => group.Members.Contains(p.Id) && PrivateMessages.CanChat(d, p.Id)).ToArray`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`group.Members.Contains(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: group.Members.Contains(p.Id) && PrivateMessages.CanChat(d, p.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0aa3d7203ee8"></a>

## `Groups() — void Groups()`

来源：源码第 270 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Groups()`](ConsumerPickerScreen.cs.md#symbol-0aa3d7203ee8)；[`Show(bool)`](ConsumerPickerScreen.cs.md#symbol-bfd48d04a658)

**调用：** [`Groups()`](ConsumerPickerScreen.cs.md#symbol-0aa3d7203ee8)；[`Members()`](ConsumerPickerScreen.cs.md#symbol-cf168b0ee57f)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`string.Contains(string, System.StringComparison)`；`string.Trim()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Groups()`；`Members()`；`NationalSpire.CareerScreen.ConsumerEdit.Group`；`NationalSpire.CareerScreen.ConsumerEdit.People`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`groupList.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: groupList.AddChild(button);`
- `Groups()`；输入表达式：`Groups()`；返回值紧邻使用处：`ExpressionStatementSyntax: Groups();`
- `Members()`；输入表达式：`Members()`；返回值紧邻使用处：`ExpressionStatementSyntax: Members();`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(group.Name + " · " + group.Members.Count + "人", group.Id == edit.Group, () => { edit.Group = group.Id; edit.People.Clear(); Groups(); Members(); changed(); }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton(group.Name + " · " + group.Members.Count + "人", group.Id == edit.Group, () => { edit.Group = group.Id; edit.People.Clear(); Groups(); Members(); changed(); }, 0)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(groupList)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(groupList);`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(d).Where`
- `string.Contains(string, System.StringComparison)`；输入表达式：`g.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase)`
- `string.Trim()`；输入表达式：`search.Text.Trim()`；返回值紧邻使用处：`ArgumentSyntax: search.Text.Trim()`
- `System.Action.Invoke()`；输入表达式：`changed()`；返回值紧邻使用处：`ExpressionStatementSyntax: changed();`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`edit.People.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: edit.People.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`GroupChats.Visible(d).Where(g => g.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var group in GroupChats.Visible(d).Where(g => g.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase)))                      {                          var button = FilterButton(group.Name + " · " + group.Members.Count + "人", group.Id == edit.Group, () => { edit.Group = group.Id; edit.People.Clear(); Groups(); Members(); changed(); }, 0);                          button.Name = "RecipientGroup_" + group.Id; groupList.AddChild(button);                      }`

**赋值（含属性/字段和局部值）：**

- `button.Name` = `"RecipientGroup_" + group.Id`
- `edit.Group` = `group.Id`
