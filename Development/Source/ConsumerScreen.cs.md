# ConsumerScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`CC91DE81A4622045D337A03414D99D3A98A964C2C14B0D4A33C39C46F97A0EAD`。来源：[源码](../../ConsumerScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private const int ShopRows = 3, ShopColumns = 2, MinProductHeight = 184, ProductGap = 14, ShopPagerHeight = 40;
private const int ShopPageSize = ShopRows * ShopColumns;
private string _shopTier = ConsumerCatalog.Mass;
private string _shopCategory = "全部", _shopSelected = "";
private bool _shopOwned;
private int _shopPage;
```

<a id="symbol-76b18b4a51c9"></a>

## `NationalSpire.CareerScreen.OpenShopShelf(string?) — private void OpenShopShelf(string? tier)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)

**调用：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`Select()`](ConsumerScreen.cs.md#symbol-d7cbb96319e8)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._tab`；`Select()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(Select)`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(Select);`
- `Select()`；输入表达式：`Select()`；返回值紧邻使用处：`ExpressionStatementSyntax: Select();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d7cbb96319e8"></a>

## `Select() — void Select()`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenShopShelf(string?)`](ConsumerScreen.cs.md#symbol-76b18b4a51c9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._shopCategory`；`NationalSpire.CareerScreen._shopOwned`；`NationalSpire.CareerScreen._shopPage`；`NationalSpire.CareerScreen._shopSelected`；`NationalSpire.CareerScreen._shopTier`；`NationalSpire.CareerScreen._tab`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_lifeSection` = `"消费商城"`
- `_shopCategory` = `"全部"`
- `_shopOwned` = `tier == null`
- `_shopPage` = `0`
- `_shopSelected` = `""`
- `_shopTier` = `tier`
- `_tab` = `"生涯生活"`

<a id="symbol-992c668fa0a5"></a>

## `NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData) — private void ConsumerShop(CareerData d)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** `Godot.Button.Button()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`IgnoreMouse(Godot.Node)`](ConsumerScreen.cs.md#symbol-192b1857e51b)；[`NationalSpire.CareerScreen.AddLifeRepairNotices(NationalSpire.CareerData, Godot.VBoxContainer)`](LifeScreen.cs.md#symbol-e1843514c51a)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerScreen.OpenShopShelf(string?)`](ConsumerScreen.cs.md#symbol-76b18b4a51c9)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerCatalog.InTier(string)`](ConsumerData.cs.md#symbol-4d4f5c1ae5a0)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.ConsumerPurchases.ConsumerPurchases(NationalSpire.CareerData)`](ConsumerPurchases.cs.md#symbol-270a101e0b54)；[`NationalSpire.ConsumerPurchases.Label(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-09446309617d)；[`NationalSpire.ConsumerPurchases.Promotions(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-81c188784d64)；[`NationalSpire.ConsumerPurchases.ThisSeason(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-8b20d9717189)；[`NationalSpire.ConsumerSeal.ConsumerSeal()`](ConsumerVisuals.cs.md#symbol-3a6432da4809)；[`NationalSpire.ConsumerVisuals.Accent(bool)`](ConsumerVisuals.cs.md#symbol-03b075ea8cd2)；[`NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`](ConsumerVisuals.cs.md#symbol-4d4df8cb62c8)；[`NationalSpire.ConsumerVisuals.Style(bool, bool)`](ConsumerVisuals.cs.md#symbol-340545590823)；`NationalSpire.LifestyleArt.LifestyleArt()`；[`Select(NationalSpire.Good)`](ConsumerScreen.cs.md#symbol-5012d526c517)；[`ShelfRow(Godot.Control, Godot.Control, Godot.Control)`](ConsumerScreen.cs.md#symbol-05e2e3c1bac0)；[`Spacer()`](ConsumerScreen.cs.md#symbol-403162b5d469)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `IgnoreMouse(Godot.Node)`；`NationalSpire.CareerScreen.AddLifeRepairNotices(NationalSpire.CareerData, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerScreen.MinProductHeight`；`NationalSpire.CareerScreen.OpenShopShelf(string?)`；`NationalSpire.CareerScreen.ProductGap`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShopColumns`；`NationalSpire.CareerScreen.ShopPageSize`；`NationalSpire.CareerScreen.ShopPagerHeight`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._shopCategory`；`NationalSpire.CareerScreen._shopOwned`；`NationalSpire.CareerScreen._shopPage`；`NationalSpire.CareerScreen._shopSelected`；`NationalSpire.CareerScreen._shopTier`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerCatalog.InTier(string)`；`NationalSpire.ConsumerCatalog.TierOrder`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerPurchases.Collection`；`NationalSpire.ConsumerPurchases.Label(NationalSpire.Good)`；`NationalSpire.ConsumerPurchases.Promotions(NationalSpire.Good)`；`NationalSpire.ConsumerPurchases.ThisSeason(NationalSpire.Good)`；`NationalSpire.ConsumerSeal.Count`；`NationalSpire.ConsumerSeal.Current`；`NationalSpire.ConsumerSeal.Promo`；`NationalSpire.ConsumerSeal.Ticket`；`NationalSpire.ConsumerVisuals.Accent(bool)`；`NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`；`NationalSpire.ConsumerVisuals.Style(bool, bool)`；`NationalSpire.Good.Category`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.Good.Promo`；`NationalSpire.Good.Repeatable`；`NationalSpire.LifestyleArt.Category`；`NationalSpire.LifestyleArt.ProductId`；`Select(NationalSpire.Good)`；`ShelfRow(Godot.Control, Godot.Control, Godot.Control)`；`Spacer()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = "Product_" + good.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, MinProductHeight) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = "Product_" + good.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, MinProductHeight) }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`filters.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", ProductGap)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", ProductGap);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", ProductGap)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", ProductGap);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_bottom", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_bottom", 4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_bottom", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_bottom", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_left", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_left", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_right", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_right", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_top", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_top", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`shelf.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: shelf.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tiers.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: tiers.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`badge.AddThemeStyleboxOverride("panel", ConsumerVisuals.Style(current, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.AddThemeStyleboxOverride("panel", ConsumerVisuals.Style(current, true));`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(0, 42), SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(0, 42), SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(0, MinProductHeight), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new Control { CustomMinimumSize = new(0, MinProductHeight), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`art.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: art.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`badge.SetAnchorsAndOffsetsPreset(LayoutPreset.TopRight)`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.SetAnchorsAndOffsetsPreset(LayoutPreset.TopRight);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Name = "ShopGrid", Columns = ShopColumns }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Name = "ShopGrid", Columns = ShopColumns }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "ShopPagination", CustomMinimumSize = new(0, ShopPagerHeight) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "ShopPagination", CustomMinimumSize = new(0, ShopPagerHeight) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "ShopTiers" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "ShopTiers" }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`artwork.AddChild(art)`；返回值紧邻使用处：`ExpressionStatementSyntax: artwork.AddChild(art);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`artwork.AddChild(badge)`；返回值紧邻使用处：`ExpressionStatementSyntax: artwork.AddChild(badge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`badge.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(good):N0}", 23, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(good):N0}", 23, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(good.Category, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(good.Category, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(good.Name, 20, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(good.Name, 20, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(artwork)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(artwork);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`collection.AddChild(FilterButton("我的收藏", _shopOwned, () => OpenShopShelf(null), 130))`；返回值紧邻使用处：`ExpressionStatementSyntax: collection.AddChild(FilterButton("我的收藏", _shopOwned, () => OpenShopShelf(null), 130));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filterScroll.AddChild(filters)`；返回值紧邻使用处：`ExpressionStatementSyntax: filterScroll.AddChild(filters);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(new Control { CustomMinimumSize = new(0, MinProductHeight), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(new Control { CustomMinimumSize = new(0, MinProductHeight), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(shelf)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(shelf);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pages.AddChild(FramedAction("← 上一页", () => { _shopPage--; Render(); }, width: 140, height: ShopPagerHeight))`；返回值紧邻使用处：`ExpressionStatementSyntax: pages.AddChild(FramedAction("← 上一页", () => { _shopPage--; Render(); }, width: 140, height: ShopPagerHeight));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pages.AddChild(FramedAction("下一页 →", () => { _shopPage++; Render(); }, width: 140, height: ShopPagerHeight))`；返回值紧邻使用处：`ExpressionStatementSyntax: pages.AddChild(FramedAction("下一页 →", () => { _shopPage++; Render(); }, width: 140, height: ShopPagerHeight));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pages.AddChild(Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + ShopPageSize - 1) / ShopPageSize)}", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: pages.AddChild(Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + ShopPageSize - 1) / ShopPageSize)}", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new ConsumerSeal { Current = current, Ticket = good.Repeatable, Promo = good.Promo, Count = purchases.Promotions(good) })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new ConsumerSeal { Current = current, Ticket = good.Repeatable, Promo = good.Promo, Count = purchases.Promotions(good) });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tiers.AddChild(filter)`；返回值紧邻使用处：`ExpressionStatementSyntax: tiers.AddChild(filter);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, MinProductHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, MinProductHeight)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, ShopPagerHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, ShopPagerHeight)`
- `IgnoreMouse(Godot.Node)`；输入表达式：`IgnoreMouse(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: IgnoreMouse(margin);`
- `NationalSpire.CareerScreen.AddLifeRepairNotices(NationalSpire.CareerData, Godot.VBoxContainer)`；输入表达式：`AddLifeRepairNotices(d, filters)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddLifeRepairNotices(d, filters);`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`；输入表达式：`ConsumerDetail(d, selected, purchases, body)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerDetail(d, selected, purchases, body);`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton("我的收藏", _shopOwned, () => OpenShopShelf(null), 130)`；返回值紧邻使用处：`ArgumentSyntax: FilterButton("我的收藏", _shopOwned, () => OpenShopShelf(null), 130)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 0)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(tier, !_shopOwned && _shopTier == tier, () => OpenShopShelf(tier), 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton(tier, !_shopOwned && _shopTier == tier, () => OpenShopShelf(tier), 0)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("← 上一页", () => { _shopPage--; Render(); }, width: 140, height: ShopPagerHeight)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("← 上一页", () => { _shopPage--; Render(); }, width: 140, height: ShopPagerHeight)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("下一页 →", () => { _shopPage++; Render(); }, width: 140, height: ShopPagerHeight)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("下一页 →", () => { _shopPage++; Render(); }, width: 140, height: ShopPagerHeight)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(detail)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(detail)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(0, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inset(0, 0)`
- `NationalSpire.CareerScreen.OpenShopShelf(string?)`；输入表达式：`OpenShopShelf(null)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenShopShelf(null)`
- `NationalSpire.CareerScreen.OpenShopShelf(string?)`；输入表达式：`OpenShopShelf(tier)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenShopShelf(tier)`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + ShopPageSize - 1) / ShopPageSize)}", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + ShopPageSize - 1) / ShopPageSize)}", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(good):N0}", 23, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(good):N0}", 23, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(good.Category, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(good.Category, 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(good.Name, 20, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(good.Name, 20, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(label, 14, ConsumerVisuals.Accent(current))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(label, 14, ConsumerVisuals.Accent(current))`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(_shopSelected)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerCatalog.Get(_shopSelected) is { } selected`
- `NationalSpire.ConsumerCatalog.InTier(string)`；输入表达式：`ConsumerCatalog.InTier(_shopTier)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _shopOwned ? purchases.Collection : ConsumerCatalog.InTier(_shopTier)`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(good)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerEngine.Price(good):N0}`
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
- `ShelfRow(Godot.Control, Godot.Control, Godot.Control)`；输入表达式：`ShelfRow(Spacer(), pages, Spacer())`；返回值紧邻使用处：`ExpressionStatementSyntax: ShelfRow(Spacer(), pages, Spacer());`
- `ShelfRow(Godot.Control, Godot.Control, Godot.Control)`；输入表达式：`ShelfRow(Spacer(), tiers, collection)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShelfRow(Spacer(), tiers, collection);`
- `ShelfRow(Godot.Control, Godot.Control, Godot.Control)`；输入表达式：`ShelfRow(filterScroll, grid, detail)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ShelfRow(filterScroll, grid, detail).SizeFlagsVertical`
- `Spacer()`；输入表达式：`Spacer()`；返回值紧邻使用处：`ArgumentSyntax: Spacer()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`pageGoods.Any(g => g.Id == _shopSelected)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !pageGoods.Any(g => g.Id == _shopSelected)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "全部" }.Concat(groups)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string category in new[] { "全部" }.Concat(groups)) { var button = FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 0); button.SizeFlagsHorizontal = SizeFlags.ExpandFill; filters.AddChild(button); }`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`groups.Contains(_shopCategory)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !groups.Contains(_shopCategory)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`available.Select(g => g.Category).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Select(g => g.Category).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`pageGoods.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: pageGoods.FirstOrDefault()?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`available.Select(g => g.Category)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Select(g => g.Category).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`goods.Skip(_shopPage * ShopPageSize)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: goods.Skip(_shopPage * ShopPageSize).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`goods.Skip(_shopPage * ShopPageSize).Take(ShopPageSize)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: goods.Skip(_shopPage * ShopPageSize).Take(ShopPageSize).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`(_shopOwned ? purchases.Collection : ConsumerCatalog.InTier(_shopTier)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (_shopOwned ? purchases.Collection : ConsumerCatalog.InTier(_shopTier)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`available.Select(g => g.Category).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = available.Select(g => g.Category).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`available.Where(g => _shopCategory == "全部" || g.Category == _shopCategory).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = available.Where(g => _shopCategory == "全部" || g.Category == _shopCategory).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`goods.Skip(_shopPage * ShopPageSize).Take(ShopPageSize).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = goods.Skip(_shopPage * ShopPageSize).Take(ShopPageSize).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`available.Where(g => _shopCategory == "全部" || g.Category == _shopCategory)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(g => _shopCategory == "全部" || g.Category == _shopCategory).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`cards.Add((card, good))`；返回值紧邻使用处：`ExpressionStatementSyntax: cards.Add((card, good));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(Button Button, Good Good)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(Button Button, Good Good)>()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, (goods.Length - 1) / ShopPageSize)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, (goods.Length - 1) / ShopPageSize)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, (goods.Length + ShopPageSize - 1) / ShopPageSize)`；返回值紧邻使用处：`InterpolationSyntax: {Math.Max(1, (goods.Length + ShopPageSize - 1) / ShopPageSize)}`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_shopPage, Math.Max(0, (goods.Length - 1) / ShopPageSize))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _shopPage = Math.Min(_shopPage, Math.Max(0, (goods.Length - 1) / ShopPageSize))`

**赋值（含属性/字段和局部值）：**

- `Category` = `good.Category + " " + good.Name`
- `Columns` = `ShopColumns`
- `Count` = `purchases.Promotions(good)`
- `Current` = `current`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(0, MinProductHeight)`
- `CustomMinimumSize` = `new(0, ShopPagerHeight)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"Product_" + good.Id`
- `Name` = `"ShopGrid"`
- `Name` = `"ShopPagination"`
- `Name` = `"ShopTiers"`
- `ProductId` = `good.Id`
- `Promo` = `good.Promo`
- `ShelfRow(filterScroll, grid, detail).SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `Ticket` = `good.Repeatable`
- `_content.SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `_shopCategory` = `"全部"`
- `_shopCategory` = `category`
- `_shopPage` = `0`
- `_shopPage` = `Math.Min(_shopPage, Math.Max(0, (goods.Length - 1) / ShopPageSize))`
- `_shopSelected` = `pageGoods.FirstOrDefault()?.Id ?? ""`
- `badge.GrowHorizontal` = `GrowDirection.Begin`
- `button.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `caption.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `card.Pressed` += `() => Select(good)`
- `detail.Name` = `"ShopPurchase"`
- `filter.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `inset.SizeFlagsVertical` = `SizeFlags.ExpandFill`

<a id="symbol-05e2e3c1bac0"></a>

## `ShelfRow(Godot.Control, Godot.Control, Godot.Control) — HBoxContainer ShelfRow(Control filters, Control products, Control purchase)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ProductGap`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", ProductGap)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", ProductGap);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(filters)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(filters);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(products)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(products);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(purchase)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(purchase);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shelf.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: shelf.AddChild(row);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(140, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: filters.CustomMinimumSize = new(140, 0)`

**赋值（含属性/字段和局部值）：**

- `filters.CustomMinimumSize` = `new(140, 0)`
- `products.SizeFlagsHorizontal` = `purchase.SizeFlagsHorizontal = SizeFlags.ExpandFill`
- `products.SizeFlagsStretchRatio` = `2`
- `purchase.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-403162b5d469"></a>

## `Spacer() — static Control Spacer()`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** `Godot.Control.Control()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.Control()`；输入表达式：`new() { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new() { MouseFilter = MouseFilterEnum.Ignore }`

**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-5012d526c517"></a>

## `Select(NationalSpire.Good) — void Select(Good good)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** `Godot.Node.GetChildren(bool)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；[`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.ConsumerPurchases.ThisSeason(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-8b20d9717189)；[`NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`](ConsumerVisuals.cs.md#symbol-4d4df8cb62c8)

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

<a id="symbol-192b1857e51b"></a>

## `IgnoreMouse(Godot.Node) — void IgnoreMouse(Node node)`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`IgnoreMouse(Godot.Node)`](ConsumerScreen.cs.md#symbol-192b1857e51b)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** `Godot.Node.GetChildren(bool)`；[`IgnoreMouse(Godot.Node)`](ConsumerScreen.cs.md#symbol-192b1857e51b)

**字段、属性、事件及方法组引用：** `IgnoreMouse(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetChildren(bool)`；输入表达式：`node.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in node.GetChildren()) IgnoreMouse(child);`
- `IgnoreMouse(Godot.Node)`；输入表达式：`IgnoreMouse(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: IgnoreMouse(child);`

**赋值（含属性/字段和局部值）：**

- `control.MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-d0b5fafc7e7c"></a>

## `NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer) — private void ConsumerDetail(CareerData d, Good selected, ConsumerPurchases purchases, VBoxContainer body)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`Select(NationalSpire.Good)`](ConsumerScreen.cs.md#symbol-5012d526c517)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.GodotObject.Free()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildCount(bool)`；`Godot.Node.GetChildren(bool)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerAudience.PromotionGain(int, int, long)`](CareerAudience.cs.md#symbol-e10664ed2197)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.ConsumerConfirmPurchase(NationalSpire.CareerData, NationalSpire.Good, int)`](ConsumerCommerceScreen.cs.md#symbol-deb0704ef9e4)；[`NationalSpire.CareerScreen.ConsumerTarget(NationalSpire.Good, bool)`](ConsumerCommerceScreen.cs.md#symbol-4d2c83181e84)；[`NationalSpire.CareerScreen.Hairline(string)`](DashboardControls.cs.md#symbol-bf15f4abfdcb)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerAttachments.cs.md#symbol-6c24344e1310)；[`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`](ConsumerEngine.cs.md#symbol-9a6a5bbc9c38)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.ConsumerEngine.RemainingPurchases(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-09b4e1679d14)；[`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-e824ab276330)；[`NationalSpire.ConsumerPurchases.Day(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-0d5481a79067)；[`NationalSpire.ConsumerQuantity.ConsumerQuantity()`](ConsumerGiftControls.cs.md#symbol-0eddfdec0f89)；[`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`NationalSpire.LifestyleArt.LifestyleArt()`；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.PromotionGain(int, int, long)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.ConsumerConfirmPurchase(NationalSpire.CareerData, NationalSpire.Good, int)`；`NationalSpire.CareerScreen.ConsumerTarget(NationalSpire.Good, bool)`；`NationalSpire.CareerScreen.Hairline(string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._shopOwned`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerCatalog.PromoPerSeason`；`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerEngine.RemainingPurchases(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerPurchases.Day(NationalSpire.Good)`；`NationalSpire.ConsumerQuantity.Changed`；`NationalSpire.ConsumerQuantity.Initialize(int)`；`NationalSpire.ConsumerQuantity.Maximum`；`NationalSpire.ConsumerQuantity.Minimum`；`NationalSpire.ConsumerQuantity.Valid`；`NationalSpire.ConsumerQuantity.Value`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.Good.Activities`；`NationalSpire.Good.Category`；`NationalSpire.Good.Collectible`；`NationalSpire.Good.Durable`；`NationalSpire.Good.Giftable`；`NationalSpire.Good.Id`；`NationalSpire.Good.Instant`；`NationalSpire.Good.Name`；`NationalSpire.Good.Promo`；`NationalSpire.Good.Tier`；`NationalSpire.Good.Verbs`；`NationalSpire.GoodVerb.Name`；`NationalSpire.LifestyleArt.Category`；`NationalSpire.LifestyleArt.ProductId`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`activities.AddThemeConstantOverride("separation", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: activities.AddThemeConstantOverride("separation", 4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`info.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: info.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`product.AddThemeConstantOverride("separation", 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: product.AddThemeConstantOverride("separation", 5);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.GodotObject.Free()`；输入表达式：`actions.Free()`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.Free();`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("赠送礼物", () => ConsumerTarget(selected, false), 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("赠送礼物", () => ConsumerTarget(selected, false), 0));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("邀约活动", () => ConsumerTarget(selected, true), 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("邀约活动", () => ConsumerTarget(selected, true), 0));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`activities.AddChild(Text("收藏后可举办", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: activities.AddChild(Text("收藏后可举办", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`activities.AddChild(Text(verb.Name, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: activities.AddChild(Text(verb.Name, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Hairline("3a5360"))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Hairline("3a5360"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("使用聊天输入栏的＋添加活动附件，约定日期和同行者。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("使用聊天输入栏的＋添加活动附件，约定日期和同行者。", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("即时消费", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("即时消费", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected)), 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected)), 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"${ConsumerEngine.Price(selected):N0}", 32, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"${ConsumerEngine.Price(selected):N0}", 32, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"当天临时保留 ×{ConsumerAttachments.Available(d, selected)} · {GameCalendar.Text(d, d.Day)}有效", 16, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"当天临时保留 ×{ConsumerAttachments.Available(d, selected)} · {GameCalendar.Text(d, d.Day)}有效", 16, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"每赛季限{ConsumerCatalog.PromoPerSeason}次 · 本季剩余{ConsumerEngine.RemainingPurchases(d, selected)}次", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"每赛季限{ConsumerCatalog.PromoPerSeason}次 · 本季剩余{ConsumerEngine.RemainingPurchases(d, selected)}次", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(info)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(info);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(new Control { SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(new Control { SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(new LifestyleArt { ProductId = selected.Id, Category = selected.Category + " " + selected.Name, CustomMinimumSize = new(0, 160), SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(new LifestyleArt { ProductId = selected.Id, Category = selected.Category + " " + selected.Name, CustomMinimumSize = new(0, 160), SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(purchase)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(purchase);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(quantity)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(quantity);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`info.AddChild(activities)`；返回值紧邻使用处：`ExpressionStatementSyntax: info.AddChild(activities);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`info.AddChild(product)`；返回值紧邻使用处：`ExpressionStatementSyntax: info.AddChild(product);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`product.AddChild(Text(selected.Name, 28, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: product.AddChild(Text(selected.Name, 28, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`product.AddChild(Text(selected.Tier + " / " + selected.Category, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: product.AddChild(Text(selected.Tier + " / " + selected.Category, 15, _muted));`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`actions.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: actions.GetChildCount() > 0`
- `Godot.Node.GetChildren(bool)`；输入表达式：`actions.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: actions.GetChildren().OfType<Button>`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "ShopCollectionActivities", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "ShopCollectionActivities", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "ShopProductSummary", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "ShopProductSummary", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 160)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 160)`
- `NationalSpire.CareerAudience.PromotionGain(int, int, long)`；输入表达式：`CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id))`；返回值紧邻使用处：`InterpolationSyntax: {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("赠送礼物", () => ConsumerTarget(selected, false), 0)`；返回值紧邻使用处：`ArgumentSyntax: Button("赠送礼物", () => ConsumerTarget(selected, false), 0)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("邀约活动", () => ConsumerTarget(selected, true), 0)`；返回值紧邻使用处：`ArgumentSyntax: Button("邀约活动", () => ConsumerTarget(selected, true), 0)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(error ?? "确认购买", () => ConsumerConfirmPurchase(d, selected, quantity.Value), 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(error ?? "确认购买", () => ConsumerConfirmPurchase(d, selected, quantity.Value), 0)`
- `NationalSpire.CareerScreen.ConsumerConfirmPurchase(NationalSpire.CareerData, NationalSpire.Good, int)`；输入表达式：`ConsumerConfirmPurchase(d, selected, quantity.Value)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConsumerConfirmPurchase(d, selected, quantity.Value)`
- `NationalSpire.CareerScreen.ConsumerTarget(NationalSpire.Good, bool)`；输入表达式：`ConsumerTarget(selected, false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConsumerTarget(selected, false)`
- `NationalSpire.CareerScreen.ConsumerTarget(NationalSpire.Good, bool)`；输入表达式：`ConsumerTarget(selected, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConsumerTarget(selected, true)`
- `NationalSpire.CareerScreen.Hairline(string)`；输入表达式：`Hairline("3a5360")`；返回值紧邻使用处：`ArgumentSyntax: Hairline("3a5360")`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("使用聊天输入栏的＋添加活动附件，约定日期和同行者。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("使用聊天输入栏的＋添加活动附件，约定日期和同行者。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("即时消费", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("即时消费", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("收藏后可举办", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("收藏后可举办", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected)), 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected)), 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"${ConsumerEngine.Price(selected):N0}", 32, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text($"${ConsumerEngine.Price(selected):N0}", 32, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"当天临时保留 ×{ConsumerAttachments.Available(d, selected)} · {GameCalendar.Text(d, d.Day)}有效", 16, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text($"当天临时保留 ×{ConsumerAttachments.Available(d, selected)} · {GameCalendar.Text(d, d.Day)}有效", 16, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"每赛季限{ConsumerCatalog.PromoPerSeason}次 · 本季剩余{ConsumerEngine.RemainingPurchases(d, selected)}次", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"每赛季限{ConsumerCatalog.PromoPerSeason}次 · 本季剩余{ConsumerEngine.RemainingPurchases(d, selected)}次", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(selected.Name, 28, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(selected.Name, 28, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(selected.Tier + " / " + selected.Category, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(selected.Tier + " / " + selected.Category, 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(verb.Name, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(verb.Name, 17, _ink)`
- `NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerAttachments.Available(d, selected)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerAttachments.Available(d, selected) > 0`
- `NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerAttachments.Available(d, selected)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerAttachments.Available(d, selected)}`
- `NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`；输入表达式：`ConsumerEngine.BuyError(d, selected)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerEngine.BuyError(d, selected)`
- `NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`；输入表达式：`ConsumerEngine.BuyError(d, selected, quantity.Value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: quantity.Valid ? ConsumerEngine.BuyError(d, selected, quantity.Value) : "请输入有效的购买数量。"`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(selected)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerEngine.Price(selected):N0}`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(selected)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerEngine.Price(selected)`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(selected)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerEngine.Price(selected) * (decimal)quantity.Value`
- `NationalSpire.ConsumerEngine.RemainingPurchases(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerEngine.RemainingPurchases(d, selected)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerEngine.RemainingPurchases(d, selected)}`
- `NationalSpire.ConsumerEngine.RemainingPurchases(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerEngine.RemainingPurchases(d, selected)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerEngine.RemainingPurchases(d, selected)`
- `NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；输入表达式：`ConsumerEngine.Uses(d, selected.Id)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerEngine.Uses(d, selected.Id)`
- `NationalSpire.ConsumerPurchases.Day(NationalSpire.Good)`；输入表达式：`purchases.Day(selected)`；返回值紧邻使用处：`ArgumentSyntax: purchases.Day(selected)`
- `NationalSpire.ConsumerQuantity.ConsumerQuantity()`；输入表达式：`new ConsumerQuantity { Minimum = 1, Maximum = Math.Max(1, ConsumerEngine.RemainingPurchases(d, selected)) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ConsumerQuantity { Minimum = 1, Maximum = Math.Max(1, ConsumerEngine.RemainingPurchases(d, selected)) }`
- `NationalSpire.ConsumerQuantity.Initialize(int)`；输入表达式：`quantity.Initialize(1)`；返回值紧邻使用处：`ExpressionStatementSyntax: quantity.Initialize(1);`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, d.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(d, d.Day)}`
- `NationalSpire.LifestyleArt.LifestyleArt()`；输入表达式：`new LifestyleArt { ProductId = selected.Id, Category = selected.Category + " " + selected.Name, CustomMinimumSize = new(0, 160), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new LifestyleArt { ProductId = selected.Id, Category = selected.Category + " " + selected.Name, CustomMinimumSize = new(0, 160), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, purchases.Day(selected))`；返回值紧邻使用处：`BinaryExpressionSyntax: "最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>()`；输入表达式：`selected.Activities.Any()`；返回值紧邻使用处：`IfStatementSyntax: if (selected.Activities.Any()) actions.AddChild(Button("邀约活动", () => ConsumerTarget(selected, true), 0));`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`actions.GetChildren().OfType<Button>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var button in actions.GetChildren().OfType<Button>()) button.SizeFlagsHorizontal = SizeFlags.ExpandFill;`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, ConsumerEngine.RemainingPurchases(d, selected))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Maximum = Math.Max(1, ConsumerEngine.RemainingPurchases(d, selected))`

**赋值（含属性/字段和局部值）：**

- `Category` = `selected.Category + " " + selected.Name`
- `CustomMinimumSize` = `new(0, 160)`
- `Maximum` = `Math.Max(1, ConsumerEngine.RemainingPurchases(d, selected))`
- `Minimum` = `1`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"ShopCollectionActivities"`
- `Name` = `"ShopProductSummary"`
- `ProductId` = `selected.Id`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `button.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `purchase.Disabled` = `error != null`
- `purchase.Disabled` = `message != null`
- `purchase.Text` = `message ?? $"购买 · ${ConsumerEngine.Price(selected) * (decimal)quantity.Value:N0}"`
- `quantity.Changed` += `() => { string? message = quantity.Valid ? ConsumerEngine.BuyError(d, selected, quantity.Value) : "请输入有效的购买数量。"; purchase.Text = message ?? $"购买 · ${ConsumerEngine.Price(selected) * (decimal)quantity.Value:N0}"; purchase.Disabled = message != null; }`

<a id="symbol-f212593005f6"></a>

## `NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int) — private void ConsumerSubmit(CareerData d, Good good, string verb, List<string> guests, int quantity = 1)`

来源：源码第 192 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerConfirmPurchase(NationalSpire.CareerData, NationalSpire.Good, int)`](ConsumerCommerceScreen.cs.md#symbol-deb0704ef9e4)

**调用：** [`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool, bool)`](ConsumerEngine.cs.md#symbol-2d5bf22bd5bc)；`NationalSpire.ConsumerOrder.ConsumerOrder(string, System.Collections.Generic.List<string>, int)`；[`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](EconomicActions.cs.md#symbol-6ec38e492fe6)；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`；`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool, bool)`；`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；`NationalSpire.Good.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand(kind, good.Id, text: JsonSerializer.Serialize(new ConsumerOrder(verb, guests, quantity)))`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand(kind, good.Id, text: JsonSerializer.Serialize(new ConsumerOrder(verb, guests, quantity)))) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error, true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`；输入表达式：`ConsumerEngine.Buy(value, good.Id, guests, quantity)`；返回值紧邻使用处：`ConditionalExpressionSyntax: verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests, quantity) : ConsumerEngine.Use(value, good.Id, verb, guests)`
- `NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool, bool)`；输入表达式：`ConsumerEngine.Use(value, good.Id, verb, guests)`；返回值紧邻使用处：`ConditionalExpressionSyntax: verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests, quantity) : ConsumerEngine.Use(value, good.Id, verb, guests)`
- `NationalSpire.ConsumerOrder.ConsumerOrder(string, System.Collections.Generic.List<string>, int)`；输入表达式：`new ConsumerOrder(verb, guests, quantity)`；返回值紧邻使用处：`ArgumentSyntax: new ConsumerOrder(verb, guests, quantity)`
- `NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；输入表达式：`EconomicActions.Save(d, value => verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests, quantity) : ConsumerEngine.Use(value, good.Id, verb, guests))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EconomicActions.Save(d, value => verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests, quantity) : ConsumerEngine.Use(value, good.Id, verb, guests))`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new ConsumerOrder(verb, guests, quantity))`；返回值紧邻使用处：`ArgumentSyntax: text: JsonSerializer.Serialize(new ConsumerOrder(verb, guests, quantity))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-509582b2b893"></a>

## `NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData) — private void FanChart(CareerData d)`

来源：源码第 199 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-c8e7b9304826)

**调用：** `Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ProgressBar.ProgressBar()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`](CareerAudience.cs.md#symbol-c169fde4fb8f)；[`NationalSpire.CareerAudience.QuoteMultiplier(int)`](CareerAudience.cs.md#symbol-f8e484fe597e)；[`NationalSpire.CareerAudience.Title(int)`](CareerAudience.cs.md#symbol-84c90f2dbee3)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`](CareerAvatars.cs.md#symbol-89d5865e1272)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Linq.Enumerable.Range(int, int)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`；`double.ToString(string?)`；`int.ToString(string?)`

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
