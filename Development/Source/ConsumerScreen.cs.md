# ConsumerScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`E1A19DF43023BAD1335030F8B18EFC5DB25F9D928178056AD19E8CD0CA43FC23`。来源：[源码](../../ConsumerScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private string _shopTier = ConsumerCatalog.Mass;
private string _shopCategory = "全部", _shopSelected = "";
private bool _shopOwned;
private int _shopPage;
```

<a id="symbol-992c668fa0a5"></a>

## `NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData) — private void ConsumerShop(CareerData d)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** `Godot.Button.Button()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`IgnoreMouse(Godot.Node)`](ConsumerScreen.cs.md#symbol-de528fcbab82)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerCatalog.InTier(string)`](ConsumerData.cs.md#symbol-4d4f5c1ae5a0)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-96ce04ee8974)；[`NationalSpire.ConsumerPurchases.ConsumerPurchases(NationalSpire.CareerData)`](ConsumerPurchases.cs.md#symbol-270a101e0b54)；[`NationalSpire.ConsumerPurchases.Label(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-09446309617d)；[`NationalSpire.ConsumerPurchases.Promotions(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-81c188784d64)；[`NationalSpire.ConsumerPurchases.ThisSeason(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-8b20d9717189)；[`NationalSpire.ConsumerSeal.ConsumerSeal()`](ConsumerVisuals.cs.md#symbol-3a6432da4809)；[`NationalSpire.ConsumerVisuals.Accent(bool)`](ConsumerVisuals.cs.md#symbol-03b075ea8cd2)；[`NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`](ConsumerVisuals.cs.md#symbol-4d4df8cb62c8)；[`NationalSpire.ConsumerVisuals.Style(bool, bool)`](ConsumerVisuals.cs.md#symbol-340545590823)；`NationalSpire.LifestyleArt.LifestyleArt()`；[`Select(NationalSpire.Good)`](ConsumerScreen.cs.md#symbol-5012d526c517)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `IgnoreMouse(Godot.Node)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._shopCategory`；`NationalSpire.CareerScreen._shopOwned`；`NationalSpire.CareerScreen._shopPage`；`NationalSpire.CareerScreen._shopSelected`；`NationalSpire.CareerScreen._shopTier`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerCatalog.InTier(string)`；`NationalSpire.ConsumerCatalog.TierOrder`；`NationalSpire.ConsumerEngine.Price(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerPurchases.Collection`；`NationalSpire.ConsumerPurchases.Label(NationalSpire.Good)`；`NationalSpire.ConsumerPurchases.Promotions(NationalSpire.Good)`；`NationalSpire.ConsumerPurchases.ThisSeason(NationalSpire.Good)`；`NationalSpire.ConsumerSeal.Count`；`NationalSpire.ConsumerSeal.Current`；`NationalSpire.ConsumerSeal.Promo`；`NationalSpire.ConsumerSeal.Ticket`；`NationalSpire.ConsumerVisuals.Accent(bool)`；`NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`；`NationalSpire.ConsumerVisuals.Style(bool, bool)`；`NationalSpire.Good.Category`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.Good.Promo`；`NationalSpire.Good.Repeatable`；`NationalSpire.LifestyleArt.Category`；`NationalSpire.LifestyleArt.ProductId`；`Select(NationalSpire.Good)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = "Product_" + good.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 235) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = "Product_" + good.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 235) }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + side, 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + side, 16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`badge.AddThemeStyleboxOverride("panel", ConsumerVisuals.Style(current, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.AddThemeStyleboxOverride("panel", ConsumerVisuals.Style(current, true));`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(0, 100), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(0, 100), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`art.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: art.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`badge.SetAnchorsAndOffsetsPreset(LayoutPreset.TopRight)`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.SetAnchorsAndOffsetsPreset(LayoutPreset.TopRight);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(navigation)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(navigation);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`artwork.AddChild(art)`；返回值紧邻使用处：`ExpressionStatementSyntax: artwork.AddChild(art);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`artwork.AddChild(badge)`；返回值紧邻使用处：`ExpressionStatementSyntax: artwork.AddChild(badge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`badge.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(d, good):N0}", 23, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(d, good):N0}", 23, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(good.Category, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(good.Category, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(good.Name, 20, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(good.Name, 20, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(artwork)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(artwork);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`catalog.AddChild(Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: catalog.AddChild(Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`catalog.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: catalog.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`catalog.AddChild(pages)`；返回值紧邻使用处：`ExpressionStatementSyntax: catalog.AddChild(pages);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`categories.AddChild(FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.AddChild(FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(catalog)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(catalog);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(categories)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(categories);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(detail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`navigation.AddChild(FilterButton("我的收藏", _shopOwned, () => { _shopOwned = true; _shopPage = 0; _shopCategory = "全部"; Render(); }, 130))`；返回值紧邻使用处：`ExpressionStatementSyntax: navigation.AddChild(FilterButton("我的收藏", _shopOwned, () => { _shopOwned = true; _shopPage = 0; _shopCategory = "全部"; Render(); }, 130));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`navigation.AddChild(FilterButton(tier, !_shopOwned && _shopTier == tier, () => { _shopTier = tier; _shopOwned = false; _shopPage = 0; _shopCategory = "全部"; Render(); }, 110))`；返回值紧邻使用处：`ExpressionStatementSyntax: navigation.AddChild(FilterButton(tier, !_shopOwned && _shopTier == tier, () => { _shopTier = tier; _shopOwned = false; _shopPage = 0; _shopCategory = "全部"; Render(); }, 110));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pages.AddChild(Button("← 上一页", () => { _shopPage--; Render(); }, 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: pages.AddChild(Button("← 上一页", () => { _shopPage--; Render(); }, 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pages.AddChild(Button("下一页 →", () => { _shopPage++; Render(); }, 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: pages.AddChild(Button("下一页 →", () => { _shopPage++; Render(); }, 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pages.AddChild(Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + 5) / 6)}", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: pages.AddChild(Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + 5) / 6)}", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new ConsumerSeal { Current = current, Ticket = good.Repeatable, Promo = good.Promo, Count = purchases.Promotions(good) })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new ConsumerSeal { Current = current, Ticket = good.Repeatable, Promo = good.Promo, Count = purchases.Promotions(good) });`
- `Godot.Node.QueueFree()`；输入表达式：`detail.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.QueueFree();`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { CustomMinimumSize = new(140, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { CustomMinimumSize = new(140, 0) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 2 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 2 }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 100)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 235)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 235)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(140, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(140, 0)`
- `IgnoreMouse(Godot.Node)`；输入表达式：`IgnoreMouse(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: IgnoreMouse(margin);`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("← 上一页", () => { _shopPage--; Render(); }, 140)`；返回值紧邻使用处：`ArgumentSyntax: Button("← 上一页", () => { _shopPage--; Render(); }, 140)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("下一页 →", () => { _shopPage++; Render(); }, 140)`；返回值紧邻使用处：`ArgumentSyntax: Button("下一页 →", () => { _shopPage++; Render(); }, 140)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`；输入表达式：`ConsumerDetail(d, selected, purchases, body)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerDetail(d, selected, purchases, body);`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton("我的收藏", _shopOwned, () => { _shopOwned = true; _shopPage = 0; _shopCategory = "全部"; Render(); }, 130)`；返回值紧邻使用处：`ArgumentSyntax: FilterButton("我的收藏", _shopOwned, () => { _shopOwned = true; _shopPage = 0; _shopCategory = "全部"; Render(); }, 130)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 140)`；返回值紧邻使用处：`ArgumentSyntax: FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 140)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(tier, !_shopOwned && _shopTier == tier, () => { _shopTier = tier; _shopOwned = false; _shopPage = 0; _shopCategory = "全部"; Render(); }, 110)`；返回值紧邻使用处：`ArgumentSyntax: FilterButton(tier, !_shopOwned && _shopTier == tier, () => { _shopTier = tier; _shopOwned = false; _shopPage = 0; _shopCategory = "全部"; Render(); }, 110)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(detail)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(detail)`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + 5) / 6)}", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + 5) / 6)}", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(d, good):N0}", 23, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(d, good):N0}", 23, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(good.Category, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(good.Category, 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(good.Name, 20, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(good.Name, 20, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(label, 14, ConsumerVisuals.Accent(current))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(label, 14, ConsumerVisuals.Accent(current))`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(_shopSelected)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerCatalog.Get(_shopSelected) is not { } selected`
- `NationalSpire.ConsumerCatalog.InTier(string)`；输入表达式：`ConsumerCatalog.InTier(_shopTier)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _shopOwned ? purchases.Collection : ConsumerCatalog.InTier(_shopTier)`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(d, good)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerEngine.Price(d, good):N0}`
- `NationalSpire.ConsumerPurchases.ConsumerPurchases(NationalSpire.CareerData)`；输入表达式：`new ConsumerPurchases(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ConsumerPurchases(d)`
- `NationalSpire.ConsumerPurchases.Label(NationalSpire.Good)`；输入表达式：`purchases.Label(good)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = purchases.Label(good)`
- `NationalSpire.ConsumerPurchases.Promotions(NationalSpire.Good)`；输入表达式：`purchases.Promotions(good)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Count = purchases.Promotions(good)`
- `NationalSpire.ConsumerPurchases.ThisSeason(NationalSpire.Good)`；输入表达式：`purchases.ThisSeason(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: purchases.ThisSeason(good) || good.Promo`
- `NationalSpire.ConsumerSeal.ConsumerSeal()`；输入表达式：`new ConsumerSeal { Current = current, Ticket = good.Repeatable, Promo = good.Promo, Count = purchases.Promotions(good) }`；返回值紧邻使用处：`ArgumentSyntax: new ConsumerSeal { Current = current, Ticket = good.Repeatable, Promo = good.Promo, Count = purchases.Promotions(good) }`
- `NationalSpire.ConsumerVisuals.Accent(bool)`；输入表达式：`ConsumerVisuals.Accent(current)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerVisuals.Accent(current)`
- `NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`；输入表达式：`ConsumerVisuals.ProductStyle(card, current, good.Id == _shopSelected)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerVisuals.ProductStyle(card, current, good.Id == _shopSelected);`
- `NationalSpire.ConsumerVisuals.Style(bool, bool)`；输入表达式：`ConsumerVisuals.Style(current, true)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerVisuals.Style(current, true)`
- `NationalSpire.LifestyleArt.LifestyleArt()`；输入表达式：`new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name }`
- `Select(NationalSpire.Good)`；输入表达式：`Select(good)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Select(good)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`goods.Any(g => g.Id == _shopSelected)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !goods.Any(g => g.Id == _shopSelected)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "全部" }.Concat(groups)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string category in new[] { "全部" }.Concat(groups)) categories.AddChild(FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 140));`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`groups.Contains(_shopCategory)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !groups.Contains(_shopCategory)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`available.Select(g => g.Category).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Select(g => g.Category).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`goods.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: goods.FirstOrDefault()?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`available.Select(g => g.Category)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Select(g => g.Category).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`goods.Skip(_shopPage * 6)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: goods.Skip(_shopPage * 6).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`goods.Skip(_shopPage * 6).Take(6)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var good in goods.Skip(_shopPage * 6).Take(6)) { var card = new Button { Name = "Product_" + good.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 235) }; grid.AddChild(card); cards.Add((card, good)); card.Pressed += () => Select(good); var margin = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }; card.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); foreach (string side in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + side, 16); var box = new VBoxContainer(); margin.AddChild(box); string label = purchases.Label(good); bool current = purchases.ThisSeason(good) || good.Promo; ConsumerVisuals.ProductStyle(card, current, good.Id == _shopSelected); var artwork = new Control { CustomMinimumSize = new(0, 100), SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddChild(artwork); var art = new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name }; artwork.AddChild(art); art.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); if (!_shopOwned && label.Length > 0) { var badge = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }; artwork.AddChild(badge); badge.SetAnchorsAndOffsetsPreset(LayoutPreset.TopRight); badge.GrowHorizontal = GrowDirection.Begin; badge.AddThemeStyleboxOverride("panel", ConsumerVisuals.Style(current, true)); var row = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; badge.AddChild(row); row.AddChild(new ConsumerSeal { Current = current, Ticket = good.Repeatable, Promo = good.Promo, Count = purchases.Promotions(good) }); var caption = Text(label, 14, ConsumerVisuals.Accent(current)); caption.AutowrapMode = TextServer.AutowrapMode.Off; row.AddChild(caption); } box.AddChild(Text(good.Category, 14, _muted)); box.AddChild(Text(good.Name, 20, _ink)); box.AddChild(Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(d, good):N0}", 23, CareerVisuals.Teal)); void IgnoreMouse(Node node) { if (node is Control control) control.MouseFilter = MouseFilterEnum.Ignore; foreach (var child in node.GetChildren()) IgnoreMouse(child); } IgnoreMouse(margin); }`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`(_shopOwned ? purchases.Collection : ConsumerCatalog.InTier(_shopTier)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (_shopOwned ? purchases.Collection : ConsumerCatalog.InTier(_shopTier)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`available.Select(g => g.Category).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = available.Select(g => g.Category).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`available.Where(g => _shopCategory == "全部" || g.Category == _shopCategory).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = available.Where(g => _shopCategory == "全部" || g.Category == _shopCategory).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`available.Where(g => _shopCategory == "全部" || g.Category == _shopCategory)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(g => _shopCategory == "全部" || g.Category == _shopCategory).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`cards.Add((card, good))`；返回值紧邻使用处：`ExpressionStatementSyntax: cards.Add((card, good));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(Button Button, Good Good)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(Button Button, Good Good)>()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, (goods.Length - 1) / 6)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, (goods.Length - 1) / 6)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, (goods.Length + 5) / 6)`；返回值紧邻使用处：`InterpolationSyntax: {Math.Max(1, (goods.Length + 5) / 6)}`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_shopPage, Math.Max(0, (goods.Length - 1) / 6))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _shopPage = Math.Min(_shopPage, Math.Max(0, (goods.Length - 1) / 6))`

**赋值（含属性/字段和局部值）：**

- `Category` = `good.Category + " " + good.Name`
- `Columns` = `2`
- `Count` = `purchases.Promotions(good)`
- `Current` = `current`
- `CustomMinimumSize` = `new(0, 100)`
- `CustomMinimumSize` = `new(0, 235)`
- `CustomMinimumSize` = `new(140, 0)`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"Product_" + good.Id`
- `ProductId` = `good.Id`
- `Promo` = `good.Promo`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsStretchRatio` = `2`
- `Ticket` = `good.Repeatable`
- `_shopCategory` = `"全部"`
- `_shopCategory` = `category`
- `_shopOwned` = `false`
- `_shopOwned` = `true`
- `_shopPage` = `0`
- `_shopPage` = `Math.Min(_shopPage, Math.Max(0, (goods.Length - 1) / 6))`
- `_shopSelected` = `goods.FirstOrDefault()?.Id ?? ""`
- `_shopTier` = `tier`
- `badge.GrowHorizontal` = `GrowDirection.Begin`
- `caption.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `card.Pressed` += `() => Select(good)`
- `detail.SizeFlagsStretchRatio` = `1`

<a id="symbol-5012d526c517"></a>

## `Select(NationalSpire.Good) — void Select(Good good)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.ConsumerPurchases.ThisSeason(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-8b20d9717189)；[`NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`](ConsumerVisuals.cs.md#symbol-4d4df8cb62c8)；`Godot.Node.GetChildren(bool)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`

**字段、属性、事件及方法组引用：** `(Godot.Button Button, NationalSpire.Good Good).Button`；`(Godot.Button Button, NationalSpire.Good Good).Good`；`NationalSpire.CareerScreen._shopSelected`；`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`；`NationalSpire.ConsumerPurchases.ThisSeason(NationalSpire.Good)`；`NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`；`NationalSpire.Good.Id`；`NationalSpire.Good.Promo`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetChildren(bool)`；输入表达式：`body.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in body.GetChildren()) { body.RemoveChild(child); child.QueueFree(); }`
- `Godot.Node.QueueFree()`；输入表达式：`child.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: child.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`body.RemoveChild(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.RemoveChild(child);`
- `NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`；输入表达式：`ConsumerDetail(d, good, purchases, body)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerDetail(d, good, purchases, body);`
- `NationalSpire.ConsumerPurchases.ThisSeason(NationalSpire.Good)`；输入表达式：`purchases.ThisSeason(item.Good)`；返回值紧邻使用处：`BinaryExpressionSyntax: purchases.ThisSeason(item.Good) || item.Good.Promo`
- `NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`；输入表达式：`ConsumerVisuals.ProductStyle(item.Button, purchases.ThisSeason(item.Good) || item.Good.Promo, item.Good.Id == _shopSelected)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerVisuals.ProductStyle(item.Button, purchases.ThisSeason(item.Good) || item.Good.Promo, item.Good.Id == _shopSelected);`

**赋值（含属性/字段和局部值）：**

- `_shopSelected` = `good.Id`

<a id="symbol-de528fcbab82"></a>

## `IgnoreMouse(Godot.Node) — void IgnoreMouse(Node node)`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`IgnoreMouse(Godot.Node)`](ConsumerScreen.cs.md#symbol-de528fcbab82)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** [`IgnoreMouse(Godot.Node)`](ConsumerScreen.cs.md#symbol-de528fcbab82)；`Godot.Node.GetChildren(bool)`

**字段、属性、事件及方法组引用：** `IgnoreMouse(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetChildren(bool)`；输入表达式：`node.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in node.GetChildren()) IgnoreMouse(child);`
- `IgnoreMouse(Godot.Node)`；输入表达式：`IgnoreMouse(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: IgnoreMouse(child);`

**赋值（含属性/字段和局部值）：**

- `control.MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-d0b5fafc7e7c"></a>

## `NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer) — private void ConsumerDetail(CareerData d, Good selected, ConsumerPurchases purchases, VBoxContainer body)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`Select(NationalSpire.Good)`](ConsumerScreen.cs.md#symbol-5012d526c517)

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerAudience.PromotionGain(int, int, int)`](CareerAudience.cs.md#symbol-d4f18e34de92)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.ConsumerInvite(NationalSpire.CareerData, NationalSpire.Good, string, int)`](ConsumerScreen.cs.md#symbol-244128db5d80)；[`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`](ConsumerScreen.cs.md#symbol-a26966f14e5c)；[`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)；[`NationalSpire.CareerScreen.GuardInvitationButton(Godot.Button, NationalSpire.CareerData)`](DateDiaryScreen.cs.md#symbol-6147e79e0285)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`](ConsumerEngine.cs.md#symbol-0e32f20201c1)；[`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-d9e767adce72)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-96ce04ee8974)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-e824ab276330)；[`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`](ConsumerGifts.cs.md#symbol-da833f356cc6)；[`NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`](ConsumerInvitationStock.cs.md#symbol-83c43c134057)；[`NationalSpire.ConsumerInvitationStock.Ticket(NationalSpire.Good)`](ConsumerInvitationStock.cs.md#symbol-6ac4bb7a00c7)；[`NationalSpire.ConsumerPurchases.Day(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-0d5481a79067)；[`NationalSpire.ConsumerQuantity.ConsumerQuantity()`](ConsumerGiftControls.cs.md#symbol-0eddfdec0f89)；[`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)；`NationalSpire.LifestyleArt.LifestyleArt()`；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；[`ShopAction(string, System.Action)`](ConsumerScreen.cs.md#symbol-462f74358c6b)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.PromotionGain(int, int, int)`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.ConsumerInvite(NationalSpire.CareerData, NationalSpire.Good, string, int)`；`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`；`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`；`NationalSpire.CareerScreen.GuardInvitationButton(Godot.Button, NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._shopOwned`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`；`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerEngine.Price(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；`NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`；`NationalSpire.ConsumerInvitationStock.Ticket(NationalSpire.Good)`；`NationalSpire.ConsumerPurchases.Day(NationalSpire.Good)`；`NationalSpire.ConsumerQuantity.Changed`；`NationalSpire.ConsumerQuantity.Initialize(int)`；`NationalSpire.ConsumerQuantity.Minimum`；`NationalSpire.ConsumerQuantity.Valid`；`NationalSpire.ConsumerQuantity.Value`；`NationalSpire.ConsumerState.GiftStock`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.Good.Category`；`NationalSpire.Good.Durable`；`NationalSpire.Good.Giftable`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.Good.Promo`；`NationalSpire.Good.Slots`；`NationalSpire.Good.Tier`；`NationalSpire.Good.Verbs`；`NationalSpire.GoodVerb.Id`；`NationalSpire.GoodVerb.Name`；`NationalSpire.GoodVerb.Slots`；`NationalSpire.LifestyleArt.Category`；`NationalSpire.LifestyleArt.ProductId`；`NationalSpire.OwnedGood.Durable`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.UsedSeason`；`NationalSpire.OwnedGood.UsedVerbs`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`ShopAction(string, System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`pricing.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: pricing.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("向好感已满的恋人献上誓约之戒，许下一生的承诺。", 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("向好感已满的恋人献上誓约之戒，许下一生的承诺。", 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("向已收到誓约之戒的对象发起婚礼邀约。", 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("向已收到誓约之戒的对象发起婚礼邀约。", 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("收藏后可举办\n" + string.Join("\n", selected.Verbs.Select(v => v.Name)), 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("收藏后可举办\n" + string.Join("\n", selected.Verbs.Select(v => v.Name)), 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected)), 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected)), 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"可赠库存 {ConsumerGifts.Available(d, selected.Id):N0}", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"可赠库存 {ConsumerGifts.Available(d, selected.Id):N0}", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"可邀约库存 {ConsumerInvitationStock.Available(d, selected.Id):N0}", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"可邀约库存 {ConsumerInvitationStock.Available(d, selected.Id):N0}", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}\n每赛季最多3次", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}\n每赛季最多3次", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(selected.Name, 28, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(selected.Name, 28, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(selected.Tier + " / " + selected.Category, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(selected.Tier + " / " + selected.Category, 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(new LifestyleArt { ProductId = selected.Id, Category = selected.Category + " " + selected.Name, CustomMinimumSize = new(0, 205), SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(new LifestyleArt { ProductId = selected.Id, Category = selected.Category + " " + selected.Name, CustomMinimumSize = new(0, 205), SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(pricing)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(pricing);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pricing.AddChild(amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: pricing.AddChild(amount);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pricing.AddChild(price)`；返回值紧邻使用处：`ExpressionStatementSyntax: pricing.AddChild(price);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 205)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 205)`
- `NationalSpire.CareerAudience.PromotionGain(int, int, int)`；输入表达式：`CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id))`；返回值紧邻使用处：`InterpolationSyntax: {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(verb.Name + (used ? " · 本季已举办" : $" · ${ConsumerEngine.HospitalityFee(d, selected):N0}"), () => ConsumerInvite(d, selected, verb.Id, verb.Slots), 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(verb.Name + (used ? " · 本季已举办" : $" · ${ConsumerEngine.HospitalityFee(d, selected):N0}"), () => ConsumerInvite(d, selected, verb.Id, verb.Slots), 0)`
- `NationalSpire.CareerScreen.ConsumerInvite(NationalSpire.CareerData, NationalSpire.Good, string, int)`；输入表达式：`ConsumerInvite(d, selected, "", selected.Slots)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConsumerInvite(d, selected, "", selected.Slots)`
- `NationalSpire.CareerScreen.ConsumerInvite(NationalSpire.CareerData, NationalSpire.Good, string, int)`；输入表达式：`ConsumerInvite(d, selected, verb.Id, verb.Slots)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConsumerInvite(d, selected, verb.Id, verb.Slots)`
- `NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`；输入表达式：`ConsumerSubmit(d, selected, "", [], quantity)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConsumerSubmit(d, selected, "", [], quantity)`
- `NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`；输入表达式：`GiftRecipientPicker(d, selected, 0)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GiftRecipientPicker(d, selected, 0)`
- `NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`；输入表达式：`GiftRecipientPicker(d, selected, 0, false, "", selected.Slots, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GiftRecipientPicker(d, selected, 0, false, "", selected.Slots, true)`
- `NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`；输入表达式：`GiftRecipientPicker(d, selected, 1, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GiftRecipientPicker(d, selected, 1, true)`
- `NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`；输入表达式：`GiftRecipientPicker(d, selected, quantity)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GiftRecipientPicker(d, selected, quantity)`
- `NationalSpire.CareerScreen.GuardInvitationButton(Godot.Button, NationalSpire.CareerData)`；输入表达式：`GuardInvitationButton(button, d)`；返回值紧邻使用处：`ExpressionStatementSyntax: GuardInvitationButton(button, d);`
- `NationalSpire.CareerScreen.GuardInvitationButton(Godot.Button, NationalSpire.CareerData)`；输入表达式：`GuardInvitationButton(invite, d)`；返回值紧邻使用处：`ExpressionStatementSyntax: GuardInvitationButton(invite, d);`
- `NationalSpire.CareerScreen.GuardInvitationButton(Godot.Button, NationalSpire.CareerData)`；输入表达式：`GuardInvitationButton(wedding, d)`；返回值紧邻使用处：`ExpressionStatementSyntax: GuardInvitationButton(wedding, d);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("向好感已满的恋人献上誓约之戒，许下一生的承诺。", 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("向好感已满的恋人献上誓约之戒，许下一生的承诺。", 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("向已收到誓约之戒的对象发起婚礼邀约。", 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("向已收到誓约之戒的对象发起婚礼邀约。", 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("收藏后可举办\n" + string.Join("\n", selected.Verbs.Select(v => v.Name)), 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("收藏后可举办\n" + string.Join("\n", selected.Verbs.Select(v => v.Name)), 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected)), 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected)), 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"${ConsumerEngine.Price(d, selected):N0}", 32, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text($"${ConsumerEngine.Price(d, selected):N0}", 32, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"可赠库存 {ConsumerGifts.Available(d, selected.Id):N0}", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"可赠库存 {ConsumerGifts.Available(d, selected.Id):N0}", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"可邀约库存 {ConsumerInvitationStock.Available(d, selected.Id):N0}", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"可邀约库存 {ConsumerInvitationStock.Available(d, selected.Id):N0}", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}\n每赛季最多3次", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}\n每赛季最多3次", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(error ?? "", 15, new Color("ee929d"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(error ?? "", 15, new Color("ee929d"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(selected.Name, 28, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(selected.Name, 28, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(selected.Tier + " / " + selected.Category, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(selected.Tier + " / " + selected.Category, 15, _muted)`
- `NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`；输入表达式：`ConsumerEngine.BuyError(d, selected)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerEngine.BuyError(d, selected)`
- `NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`；输入表达式：`ConsumerEngine.BuyError(d, selected, quantity)`；返回值紧邻使用处：`ConditionalExpressionSyntax: amount.Valid ? ConsumerEngine.BuyError(d, selected, quantity) : "请输入有效的购买数量。"`
- `NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerEngine.HospitalityFee(d, selected)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerEngine.HospitalityFee(d, selected):N0}`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(d, selected)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerEngine.Price(d, selected):N0}`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(d, selected)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerEngine.Price(d, selected) * (decimal)quantity`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(selected)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerEngine.Price(selected)`
- `NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；输入表达式：`ConsumerEngine.Uses(d, selected.Id)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerEngine.Uses(d, selected.Id)`
- `NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；输入表达式：`ConsumerGifts.Available(d, selected.Id)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerGifts.Available(d, selected.Id):N0}`
- `NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；输入表达式：`ConsumerGifts.Available(d, selected.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerGifts.Available(d, selected.Id) == 0`
- `NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`；输入表达式：`ConsumerInvitationStock.Available(d, selected.Id)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerInvitationStock.Available(d, selected.Id):N0}`
- `NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`；输入表达式：`ConsumerInvitationStock.Available(d, selected.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerInvitationStock.Available(d, selected.Id) == 0`
- `NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`；输入表达式：`ConsumerInvitationStock.Available(d, selected.Id, verb.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerInvitationStock.Available(d, selected.Id, verb.Id) == 0`
- `NationalSpire.ConsumerInvitationStock.Ticket(NationalSpire.Good)`；输入表达式：`ConsumerInvitationStock.Ticket(selected)`；返回值紧邻使用处：`IfStatementSyntax: if (ConsumerInvitationStock.Ticket(selected)) body.AddChild(Text($"可邀约库存 {ConsumerInvitationStock.Available(d, selected.Id):N0}", 16, _muted));`
- `NationalSpire.ConsumerPurchases.Day(NationalSpire.Good)`；输入表达式：`purchases.Day(selected)`；返回值紧邻使用处：`ArgumentSyntax: purchases.Day(selected)`
- `NationalSpire.ConsumerQuantity.ConsumerQuantity()`；输入表达式：`new() { Name = "ShopQuantity", Minimum = 1 }`；返回值紧邻使用处：`AssignmentExpressionSyntax: amount = new() { Name = "ShopQuantity", Minimum = 1 }`
- `NationalSpire.ConsumerQuantity.Initialize(int)`；输入表达式：`amount.Initialize(1)`；返回值紧邻使用处：`ExpressionStatementSyntax: amount.Initialize(1);`
- `NationalSpire.LifestyleArt.LifestyleArt()`；输入表达式：`new LifestyleArt { ProductId = selected.Id, Category = selected.Category + " " + selected.Name, CustomMinimumSize = new(0, 205), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new LifestyleArt { ProductId = selected.Id, Category = selected.Category + " " + selected.Name, CustomMinimumSize = new(0, 205), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, purchases.Day(selected))`；返回值紧邻使用处：`BinaryExpressionSyntax: "最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected))`
- `ShopAction(string, System.Action)`；输入表达式：`ShopAction("购买", () => ConsumerSubmit(d, selected, "", [], quantity))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ShopAction("购买", () => ConsumerSubmit(d, selected, "", [], quantity))`
- `ShopAction(string, System.Action)`；输入表达式：`ShopAction("赠送", () => GiftRecipientPicker(d, selected, 0))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ShopAction("赠送", () => GiftRecipientPicker(d, selected, 0)).Disabled`
- `ShopAction(string, System.Action)`；输入表达式：`ShopAction("赠送", () => GiftRecipientPicker(d, selected, quantity))`；返回值紧邻使用处：`AssignmentExpressionSyntax: gift = ShopAction("赠送", () => GiftRecipientPicker(d, selected, quantity))`
- `ShopAction(string, System.Action)`；输入表达式：`ShopAction("邀约", () => ConsumerInvite(d, selected, "", selected.Slots))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ShopAction("邀约", () => ConsumerInvite(d, selected, "", selected.Slots))`
- `ShopAction(string, System.Action)`；输入表达式：`ShopAction("邀约", () => GiftRecipientPicker(d, selected, 0, false, "", selected.Slots, true))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ShopAction("邀约", () => GiftRecipientPicker(d, selected, 0, false, "", selected.Slots, true))`
- `ShopAction(string, System.Action)`；输入表达式：`ShopAction("邀约", () => GiftRecipientPicker(d, selected, 1, true))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ShopAction("邀约", () => GiftRecipientPicker(d, selected, 1, true))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Consumer.Goods.FirstOrDefault(g => g.Id == selected.Id && g.Durable)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Consumer.Goods.FirstOrDefault(g => g.Id == selected.Id && g.Durable)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`selected.Verbs.Select(v => v.Name)`；返回值紧邻使用处：`ArgumentSyntax: selected.Verbs.Select(v => v.Name)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.Life.Consumer.GiftStock.GetValueOrDefault(selected.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Life.Consumer.GiftStock.GetValueOrDefault(selected.Id) > 0`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`owned.UsedVerbs.Contains(verb.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: owned != null && owned.UsedSeason == d.Season && owned.UsedVerbs.Contains(verb.Id)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", selected.Verbs.Select(v => v.Name))`；返回值紧邻使用处：`BinaryExpressionSyntax: "收藏后可举办\n" + string.Join("\n", selected.Verbs.Select(v => v.Name))`

**赋值（含属性/字段和局部值）：**

- `Category` = `selected.Category + " " + selected.Name`
- `CustomMinimumSize` = `new(0, 205)`
- `Minimum` = `1`
- `Name` = `"ShopQuantity"`
- `ProductId` = `selected.Id`
- `ShopAction("赠送", () => GiftRecipientPicker(d, selected, 0)).Disabled` = `ConsumerGifts.Available(d, selected.Id) == 0`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `amount.Changed` += `() => { quantity = amount.Value; price.Text = $"${ConsumerEngine.Price(d, selected) * (decimal)quantity:N0}"; string? invalid = amount.Valid ? ConsumerEngine.BuyError(d, selected, quantity) : "请输入有效的购买数量。"; purchase.Disabled = invalid != null; if (gift != null) gift.Disabled = invalid != null; status.Text = invalid ?? ""; status.Visible = invalid != null; }`
- `amount` = `new() { Name = "ShopQuantity", Minimum = 1 }`
- `button.Disabled` = `used || ConsumerInvitationStock.Available(d, selected.Id, verb.Id) == 0`
- `gift.Disabled` = `error != null`
- `gift.Disabled` = `invalid != null`
- `gift` = `ShopAction("赠送", () => GiftRecipientPicker(d, selected, quantity))`
- `invite.Disabled` = `ConsumerInvitationStock.Available(d, selected.Id) == 0`
- `invite.Disabled` = `error != null`
- `invite.TooltipText` = `error ?? "确认对象后购买并预留活动，取消附件可返还库存。"`
- `price.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `price.Text` = `$"${ConsumerEngine.Price(d, selected) * (decimal)quantity:N0}"`
- `purchase.Disabled` = `error != null`
- `purchase.Disabled` = `invalid != null`
- `purchase.TooltipText` = `error ?? ""`
- `quantity` = `amount.Value`
- `status.Text` = `invalid ?? ""`
- `status.Visible` = `error != null`
- `status.Visible` = `invalid != null`

<a id="symbol-462f74358c6b"></a>

## `ShopAction(string, System.Action) — Button ShopAction(string label, Action action)`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)

**调用：** `Godot.Control.GetCombinedMinimumSize()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Button(string, System.Action, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`button.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: button.GetCombinedMinimumSize().X`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(button);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(button.GetCombinedMinimumSize().X, button.CustomMinimumSize.Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(button.GetCombinedMinimumSize().X, button.CustomMinimumSize.Y)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("确认购买", action)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("确认购买", action)`

**赋值（含属性/字段和局部值）：**

- `button.CustomMinimumSize` = `new(button.GetCombinedMinimumSize().X, button.CustomMinimumSize.Y)`
- `button.Text` = `label`

<a id="symbol-a26966f14e5c"></a>

## `NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int) — private void ConsumerSubmit(CareerData d, Good good, string verb, List<string> guests, int quantity = 1)`

来源：源码第 141 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)

**调用：** [`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerEngine.cs.md#symbol-c0beece783ab)；`NationalSpire.ConsumerOrder.ConsumerOrder(string, System.Collections.Generic.List<string>, int, bool)`；[`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](EconomicActions.cs.md#symbol-6ec38e492fe6)；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`；`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；`NationalSpire.Good.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand(kind, good.Id, text: JsonSerializer.Serialize(new ConsumerOrder(verb, guests, quantity)))`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand(kind, good.Id, text: JsonSerializer.Serialize(new ConsumerOrder(verb, guests, quantity)))) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error, true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`；输入表达式：`ConsumerEngine.Buy(value, good.Id, guests, quantity)`；返回值紧邻使用处：`ConditionalExpressionSyntax: verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests, quantity) : ConsumerEngine.Use(value, good.Id, verb, guests)`
- `NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；输入表达式：`ConsumerEngine.Use(value, good.Id, verb, guests)`；返回值紧邻使用处：`ConditionalExpressionSyntax: verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests, quantity) : ConsumerEngine.Use(value, good.Id, verb, guests)`
- `NationalSpire.ConsumerOrder.ConsumerOrder(string, System.Collections.Generic.List<string>, int, bool)`；输入表达式：`new ConsumerOrder(verb, guests, quantity)`；返回值紧邻使用处：`ArgumentSyntax: new ConsumerOrder(verb, guests, quantity)`
- `NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；输入表达式：`EconomicActions.Save(d, value => verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests, quantity) : ConsumerEngine.Use(value, good.Id, verb, guests))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EconomicActions.Save(d, value => verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests, quantity) : ConsumerEngine.Use(value, good.Id, verb, guests))`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new ConsumerOrder(verb, guests, quantity))`；返回值紧邻使用处：`ArgumentSyntax: text: JsonSerializer.Serialize(new ConsumerOrder(verb, guests, quantity))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-244128db5d80"></a>

## `NationalSpire.CareerScreen.ConsumerInvite(NationalSpire.CareerData, NationalSpire.Good, string, int) — private void ConsumerInvite(CareerData d, Good good, string verb, int slots)`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)

**调用：** [`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`；输入表达式：`GiftRecipientPicker(d, good, 0, false, verb, slots)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => GiftRecipientPicker(d, good, 0, false, verb, slots)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-509582b2b893"></a>

## `NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData) — private void FanChart(CareerData d)`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`](CareerAudience.cs.md#symbol-c169fde4fb8f)；[`NationalSpire.CareerAudience.QuoteMultiplier(int)`](CareerAudience.cs.md#symbol-f8e484fe597e)；[`NationalSpire.CareerAudience.Title(int)`](CareerAudience.cs.md#symbol-84c90f2dbee3)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`](CareerAvatars.cs.md#symbol-89d5865e1272)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`double.ToString(string?)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ProgressBar.ProgressBar()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Linq.Enumerable.Range(int, int)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `(int Floor, string Name).Floor`；`(int Floor, string Name).Name`；`(string Id, int Fans).Fans`；`(string Id, int Fans).Id`；`NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`；`NationalSpire.CareerAudience.QuoteMultiplier(int)`；`NationalSpire.CareerAudience.Title(int)`；`NationalSpire.CareerAudience.Titles`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `double.ToString(string?)`；输入表达式：`CareerAudience.QuoteMultiplier(d.Fans).ToString("0.00")`；返回值紧邻使用处：`BinaryExpressionSyntax: "×" + CareerAudience.QuoteMultiplier(d.Fans).ToString("0.00")`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(hero)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(hero);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(podium)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(podium);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("世界人气榜", 24, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("世界人气榜", 24, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PersonLink(d, winner.Id, CareerEngine.DisplayName(d, winner.Id), position == 0 ? 76 : 60))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PersonLink(d, winner.Id, CareerEngine.DisplayName(d, winner.Id), position == 0 ? 76 : 60));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(CareerAudience.Title(winner.Fans), 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(CareerAudience.Title(winner.Fans), 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(position == 0 ? "01 / 人气之巅" : $"{position + 1:00} / 焦点选手", 18, position == 0 ? _gold : _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(position == 0 ? "01 / 人气之巅" : $"{position + 1:00} / 焦点选手", 18, position == 0 ? _gold : _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(title, 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(title, 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(value, 32, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(value, 32, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(winner.Fans.ToString("N0"), 26, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(winner.Fans.ToString("N0"), 26, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heroBody.AddChild(metrics)`；返回值紧邻使用处：`ExpressionStatementSyntax: heroBody.AddChild(metrics);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heroBody.AddChild(new ProgressBar { MaxValue = next.Floor, Value = d.Fans, ShowPercentage = false, CustomMinimumSize = new(0, 10) })`；返回值紧邻使用处：`ExpressionStatementSyntax: heroBody.AddChild(new ProgressBar { MaxValue = next.Floor, Value = d.Fans, ShowPercentage = false, CustomMinimumSize = new(0, 10) });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heroBody.AddChild(PersonLink(d, "player", CareerEngine.Name(d) + " · " + CareerAudience.Title(d.Fans), 82))`；返回值紧邻使用处：`ExpressionStatementSyntax: heroBody.AddChild(PersonLink(d, "player", CareerEngine.Name(d) + " · " + CareerAudience.Title(d.Fans), 82));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heroBody.AddChild(Text("AUDIENCE / 关注与声望", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: heroBody.AddChild(Text("AUDIENCE / 关注与声望", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heroBody.AddChild(Text($"下一称号 · {next.Name}  /  {next.Floor:N0}关注", 17, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: heroBody.AddChild(Text($"下一称号 · {next.Name}  /  {next.Floor:N0}关注", 17, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Inner(card).AddChild(PersonLink(d, row.Id, $"{index + 1:00}   {CareerEngine.DisplayName(d, row.Id)}   {row.Fans:N0}关注", 42))`；返回值紧邻使用处：`ExpressionStatementSyntax: Inner(card).AddChild(PersonLink(d, row.Id, $"{index + 1:00}   {CareerEngine.DisplayName(d, row.Id)}   {row.Fans:N0}关注", 42));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`metrics.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: metrics.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`podium.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: podium.AddChild(card);`
- `Godot.ProgressBar.ProgressBar()`；输入表达式：`new ProgressBar { MaxValue = next.Floor, Value = d.Fans, ShowPercentage = false, CustomMinimumSize = new(0, 10) }`；返回值紧邻使用处：`ArgumentSyntax: new ProgressBar { MaxValue = next.Floor, Value = d.Fans, ShowPercentage = false, CustomMinimumSize = new(0, 10) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 10)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 10)`
- `int.ToString(string?)`；输入表达式：`d.Fans.ToString("N0")`；返回值紧邻使用处：`ArgumentSyntax: d.Fans.ToString("N0")`
- `int.ToString(string?)`；输入表达式：`winner.Fans.ToString("N0")`；返回值紧邻使用处：`ArgumentSyntax: winner.Fans.ToString("N0")`
- `NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`；输入表达式：`CareerAudience.Followers(p)`；返回值紧邻使用处：`ArgumentSyntax: Fans: CareerAudience.Followers(p)`
- `NationalSpire.CareerAudience.QuoteMultiplier(int)`；输入表达式：`CareerAudience.QuoteMultiplier(d.Fans)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerAudience.QuoteMultiplier(d.Fans).ToString`
- `NationalSpire.CareerAudience.Title(int)`；输入表达式：`CareerAudience.Title(d.Fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + " · " + CareerAudience.Title(d.Fans)`
- `NationalSpire.CareerAudience.Title(int)`；输入表达式：`CareerAudience.Title(winner.Fans)`；返回值紧邻使用处：`ArgumentSyntax: CareerAudience.Title(winner.Fans)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, row.Id)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, row.Id)}`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, winner.Id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(d, winner.Id)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + " · "`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Inner(card).AddChild`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(hero)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(hero)`
- `NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`；输入表达式：`PersonLink(d, "player", CareerEngine.Name(d) + " · " + CareerAudience.Title(d.Fans), 82)`；返回值紧邻使用处：`ArgumentSyntax: PersonLink(d, "player", CareerEngine.Name(d) + " · " + CareerAudience.Title(d.Fans), 82)`
- `NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`；输入表达式：`PersonLink(d, row.Id, $"{index + 1:00}   {CareerEngine.DisplayName(d, row.Id)}   {row.Fans:N0}关注", 42)`；返回值紧邻使用处：`ArgumentSyntax: PersonLink(d, row.Id, $"{index + 1:00}   {CareerEngine.DisplayName(d, row.Id)}   {row.Fans:N0}关注", 42)`
- `NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`；输入表达式：`PersonLink(d, winner.Id, CareerEngine.DisplayName(d, winner.Id), position == 0 ? 76 : 60)`；返回值紧邻使用处：`ArgumentSyntax: PersonLink(d, winner.Id, CareerEngine.DisplayName(d, winner.Id), position == 0 ? 76 : 60)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("世界人气榜", 24, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("世界人气榜", 24, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("AUDIENCE / 关注与声望", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("AUDIENCE / 关注与声望", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"下一称号 · {next.Name}  /  {next.Floor:N0}关注", 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text($"下一称号 · {next.Name}  /  {next.Floor:N0}关注", 17, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CareerAudience.Title(winner.Fans), 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(CareerAudience.Title(winner.Fans), 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(position == 0 ? "01 / 人气之巅" : $"{position + 1:00} / 焦点选手", 18, position == 0 ? _gold : _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(position == 0 ? "01 / 人气之巅" : $"{position + 1:00} / 焦点选手", 18, position == 0 ? _gold : _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(value, 32, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(value, 32, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(winner.Fans.ToString("N0"), 26, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(winner.Fans.ToString("N0"), 26, CareerVisuals.Teal)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChats.Human(d)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))              .Append((Id: "player", Fans: d.Fans))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))              .Append((Id: "player", Fans: d.Fans)).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`Enumerable.Range(0, Math.Min(20, rows.Count)).Concat(Enumerable.Range(Math.Max(0, rank - 3), Math.Min(5, rows.Count - Math.Max(0, rank - 3))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, Math.Min(20, rows.Count)).Concat(Enumerable.Range(Math.Max(0, rank - 3), Math.Min(5, rows.Count - Math.Max(0, rank - 3)))).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`Enumerable.Range(0, Math.Min(20, rows.Count)).Concat(Enumerable.Range(Math.Max(0, rank - 3), Math.Min(5, rows.Count - Math.Max(0, rank - 3)))).Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (int index in Enumerable.Range(0, Math.Min(20, rows.Count)).Concat(Enumerable.Range(Math.Max(0, rank - 3), Math.Min(5, rows.Count - Math.Max(0, rank - 3)))).Distinct())          {              var row = rows[index]; var card = Card(); _content.AddChild(card);              Inner(card).AddChild(PersonLink(d, row.Id, $"{index + 1:00}   {CareerEngine.DisplayName(d, row.Id)}   {row.Fans:N0}关注", 42));          }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CareerAudience.Titles.FirstOrDefault(t => t.Floor > d.Fans)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerAudience.Titles.FirstOrDefault(t => t.Floor > d.Fans)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))              .Append((Id: "player", Fans: d.Fans)).OrderByDescending(p => p.Fans)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))              .Append((Id: "player", Fans: d.Fans)).OrderByDescending(p => p.Fans).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))              .Append`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))              .Append((Id: "player", Fans: d.Fans)).OrderByDescending(p => p.Fans).ThenBy(p => p.Id, StringComparer.Ordinal).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))              .Append((Id: "player", Fans: d.Fans)).OrderByDescending(p => p.Fans).ThenBy(p => p.Id, StringComparer.Ordinal).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { 1, 0, 2 }.Where(i => i < rows.Count)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (int position in new[] { 1, 0, 2 }.Where(i => i < rows.Count))          {              var winner = rows[position]; var card = Card(); podium.AddChild(card); var box = Inner(card);              box.AddChild(Text(position == 0 ? "01 / 人气之巅" : $"{position + 1:00} / 焦点选手", 18, position == 0 ? _gold : _muted));              box.AddChild(PersonLink(d, winner.Id, CareerEngine.DisplayName(d, winner.Id), position == 0 ? 76 : 60));              box.AddChild(Text(winner.Fans.ToString("N0"), 26, CareerVisuals.Teal));              box.AddChild(Text(CareerAudience.Title(winner.Fans), 16, _muted));          }`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(p.Id)`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`rows.FindIndex(p => p.Id == "player")`；返回值紧邻使用处：`BinaryExpressionSyntax: rows.FindIndex(p => p.Id == "player") + 1`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, Math.Min(20, rows.Count))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, Math.Min(20, rows.Count)).Concat`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(Math.Max(0, rank - 3), Math.Min(5, rows.Count - Math.Max(0, rank - 3)))`；返回值紧邻使用处：`ArgumentSyntax: Enumerable.Range(Math.Max(0, rank - 3), Math.Min(5, rows.Count - Math.Max(0, rank - 3)))`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))              .Append((Id: "player", Fans: d.Fans)).OrderByDescending(p => p.Fans).ThenBy(p => p.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))              .Append((Id: "player", Fans: d.Fans)).OrderByDescending(p => p.Fans).ThenBy(p => p.Id, StringComparer.Ordinal).ToList`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, rank - 3)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, rank - 3)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, rank - 3)`；返回值紧邻使用处：`BinaryExpressionSyntax: rows.Count - Math.Max(0, rank - 3)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(20, rows.Count)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(20, rows.Count)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(5, rows.Count - Math.Max(0, rank - 3))`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(5, rows.Count - Math.Max(0, rank - 3))`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 10)`
- `MaxValue` = `next.Floor`
- `ShowPercentage` = `false`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Value` = `d.Fans`
