# LifeScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`E5611E1A51E8B3FDF23B0D36D95AC38E825A2910CE76D847ED4A7F066AA46D8E`。来源：[源码](../../LifeScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private string _lifeSection = "消费商城";
private int _lifeHistoryLimit = 8;
```

<a id="symbol-0cdff88b6131"></a>

## `NationalSpire.CareerScreen.Life(NationalSpire.CareerData) — private void Life(CareerData d)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`NationalSpire.CareerScreen.AddLifeRepairNotices(NationalSpire.CareerData, Godot.VBoxContainer)`](LifeScreen.cs.md#symbol-e1843514c51a)；[`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)；[`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-825caeb63a3b)；[`NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`](MarketScreen.cs.md#symbol-333b046d27f4)；[`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b665478390f0)；[`NationalSpire.CareerScreen.OpenLifePage(string)`](CareerDashboard.cs.md#symbol-0d80fbb19407)；[`NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container)`](CareerDashboard.cs.md#symbol-fc9ce0453d21)；[`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`](CareerDashboard.cs.md#symbol-5eacabf68317)；[`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`](CareerDashboard.cs.md#symbol-fd46a77c3667)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._calendarMode`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.AddLifeRepairNotices(NationalSpire.CareerData, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.OpenLifePage(string)`；`NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container)`；`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`options.AddChild(FilterButton(name, _lifeSection == name, () => OpenLifePage(name), 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: options.AddChild(FilterButton(name, _lifeSection == name, () => OpenLifePage(name), 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`SecondaryTabInset(_content).AddChild(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: SecondaryTabInset(_content).AddChild(options);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(UnderlineTab("消费商城", () => OpenLifePage("消费商城"), _lifeSection == "消费商城"))`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(UnderlineTab("消费商城", () => OpenLifePage("消费商城"), _lifeSection == "消费商城"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(UnderlineTab("遗物手办", () => OpenLifePage("我的空间"), _lifeSection == "我的空间"))`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(UnderlineTab("遗物手办", () => OpenLifePage("我的空间"), _lifeSection == "我的空间"));`
- `NationalSpire.CareerScreen.AddLifeRepairNotices(NationalSpire.CareerData, Godot.VBoxContainer)`；输入表达式：`AddLifeRepairNotices(d, _content)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddLifeRepairNotices(d, _content);`
- `NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`；输入表达式：`AssetsPage(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: AssetsPage(d);`
- `NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`；输入表达式：`Calendar(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Calendar(d);`
- `NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`；输入表达式：`ConsumerShop(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerShop(d);`
- `NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`；输入表达式：`DevelopmentScreen(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: DevelopmentScreen(d);`
- `NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`；输入表达式：`FanChart(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: FanChart(d);`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(name, _lifeSection == name, () => OpenLifePage(name), 140)`；返回值紧邻使用处：`ArgumentSyntax: FilterButton(name, _lifeSection == name, () => OpenLifePage(name), 140)`
- `NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`；输入表达式：`LifeCollection(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: LifeCollection(d);`
- `NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`；输入表达式：`LifeNews(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: LifeNews(d);`
- `NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`；输入表达式：`MarketScreen(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketScreen(d);`
- `NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`；输入表达式：`NationRanking(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: NationRanking(d);`
- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage("我的空间")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenLifePage("我的空间")`
- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage("消费商城")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenLifePage("消费商城")`
- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage(name)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenLifePage(name)`
- `NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container)`；输入表达式：`SecondaryTabInset(_content)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SecondaryTabInset(_content).AddChild`
- `NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；输入表达式：`TabStrip(_content,30,secondary:true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TabStrip(_content,30,secondary:true)`
- `NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；输入表达式：`UnderlineTab("消费商城", () => OpenLifePage("消费商城"), _lifeSection == "消费商城")`；返回值紧邻使用处：`ArgumentSyntax: UnderlineTab("消费商城", () => OpenLifePage("消费商城"), _lifeSection == "消费商城")`
- `NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；输入表达式：`UnderlineTab("遗物手办", () => OpenLifePage("我的空间"), _lifeSection == "我的空间")`；返回值紧邻使用处：`ArgumentSyntax: UnderlineTab("遗物手办", () => OpenLifePage("我的空间"), _lifeSection == "我的空间")`
- `NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`；输入表达式：`WorldHonors(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: WorldHonors(d);`

**赋值（含属性/字段和局部值）：**

- `_calendarMode` = `"计划"`
- `_tab` = `"日程"`

<a id="symbol-e1843514c51a"></a>

## `NationalSpire.CareerScreen.AddLifeRepairNotices(NationalSpire.CareerData, Godot.VBoxContainer) — private static void AddLifeRepairNotices(CareerData data, VBoxContainer target)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.RepairNotices`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`target.AddChild(Text(note, 16, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: target.AddChild(Text(note, 16, CareerVisuals.Teal));`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(note, 16, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(note, 16, CareerVisuals.Teal)`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`data.Life.RepairNotices.TakeLast(4)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string note in data.Life.RepairNotices.TakeLast(4)) target.AddChild(Text(note, 16, CareerVisuals.Teal));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d61ca43b835f"></a>

## `NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action) — private void ConfirmLife(string title, string question, Action action)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)

**调用：** [`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog(title, question, () => { action(); return true; })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ShowCareerDialog(title, question, () => { action(); return true; })`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7fd7cd27279c"></a>

## `NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData) — private void LifeCollection(CareerData d)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`NationalSpire.CareerRelics.Offers(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-5393973f2695)；[`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-b30378b84f42)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-4344e458a80a)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `(string Country, int Points).Country`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Collection`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerLifeState.RestockDay`；`NationalSpire.CareerLifeState.Shop`；`NationalSpire.CareerRelics.Catalog`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Offers(NationalSpire.CareerData)`；`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._lifeHistoryLimit`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`owned.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`owned.AddThemeConstantOverride("v_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.AddThemeConstantOverride("v_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`store.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: store.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`store.AddThemeConstantOverride("v_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: store.AddThemeConstantOverride("v_separation", 16);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button("查看更多收藏", () => { _lifeHistoryLimit += 12; Render(); }, 190))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button("查看更多收藏", () => { _lifeHistoryLimit += 12; Render(); }, 190));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(owned)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(owned);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(store)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(store);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("◆ " + item, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("◆ " + item, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("摆在这里，陪伴你的职业生涯。效果仅用于赛场之外，不会把遗物带入对局。", 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("摆在这里，陪伴你的职业生涯。效果仅用于赛场之外，不会把遗物带入对局。", 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("本期没有新藏品上架。现有收藏继续生效。", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("本期没有新藏品上架。现有收藏继续生效。", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("生活纪念", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("生活纪念", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("同款收藏长期生效。货架每14天更新，国运排名越高，可选藏品越多。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("同款收藏长期生效。货架每14天更新，国运排名越高，可选藏品越多。", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("已拥有的收藏", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("已拥有的收藏", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text($"本期手办 · {d.Esports.Country}国运第{CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1}名 · {GameCalendar.Text(d, d.Life.RestockDay)}上新", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text($"本期手办 · {d.Esports.Country}国运第{CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1}名 · {GameCalendar.Text(d, d.Life.RestockDay)}上新", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text($"遗物手办 · 已收藏 {d.Life.Figurines.Count} / {CareerRelics.Catalog.Length}", 25, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text($"遗物手办 · 已收藏 {d.Life.Figurines.Count} / {CareerRelics.Catalog.Length}", 25, _gold));`
- `NationalSpire.CareerRelics.Offers(NationalSpire.CareerData)`；输入表达式：`CareerRelics.Offers(d)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in CareerRelics.Offers(d)) FigurineCard(d, store, item, false);`
- `NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`；输入表达式：`CareerRelics.Shop(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerRelics.Shop(d);`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("查看更多收藏", () => { _lifeHistoryLimit += 12; Render(); }, 190)`；返回值紧邻使用处：`ArgumentSyntax: Button("查看更多收藏", () => { _lifeHistoryLimit += 12; Render(); }, 190)`
- `NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`；输入表达式：`FigurineCard(d, owned, item, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: FigurineCard(d, owned, item, true);`
- `NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`；输入表达式：`FigurineCard(d, store, item, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: FigurineCard(d, store, item, false);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("◆ " + item, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("◆ " + item, 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("摆在这里，陪伴你的职业生涯。效果仅用于赛场之外，不会把遗物带入对局。", 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("摆在这里，陪伴你的职业生涯。效果仅用于赛场之外，不会把遗物带入对局。", 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("本期没有新藏品上架。现有收藏继续生效。", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("本期没有新藏品上架。现有收藏继续生效。", 18, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("生活纪念", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("生活纪念", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("同款收藏长期生效。货架每14天更新，国运排名越高，可选藏品越多。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("同款收藏长期生效。货架每14天更新，国运排名越高，可选藏品越多。", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("已拥有的收藏", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("已拥有的收藏", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"本期手办 · {d.Esports.Country}国运第{CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1}名 · {GameCalendar.Text(d, d.Life.RestockDay)}上新", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text($"本期手办 · {d.Esports.Country}国运第{CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1}名 · {GameCalendar.Text(d, d.Life.RestockDay)}上新", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"遗物手办 · 已收藏 {d.Life.Figurines.Count} / {CareerRelics.Catalog.Length}", 25, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text($"遗物手办 · 已收藏 {d.Life.Figurines.Count} / {CareerRelics.Catalog.Length}", 25, _gold)`
- `NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData)`；输入表达式：`CircuitLedger.NationTable(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CircuitLedger.NationTable(d).FindIndex`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, d.Life.RestockDay)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(d, d.Life.RestockDay)}`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.Life.Figurines.ContainsKey(r.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => d.Life.Figurines.ContainsKey(r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`d.Life.Collection.Values.TakeLast(_lifeHistoryLimit).Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in d.Life.Collection.Values.TakeLast(_lifeHistoryLimit).Reverse()) _content.AddChild(Text("◆ " + item, 17, _ink));`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`d.Life.Collection.Values.TakeLast(_lifeHistoryLimit)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Collection.Values.TakeLast(_lifeHistoryLimit).Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CareerRelics.Catalog.Where(r => d.Life.Figurines.ContainsKey(r.Id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in CareerRelics.Catalog.Where(r => d.Life.Figurines.ContainsKey(r.Id))) FigurineCard(d, owned, item, true);`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1`

**赋值（含属性/字段和局部值）：**

- `_lifeHistoryLimit` += `12`
- `Columns` = `2`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-8732620351f6"></a>

## `NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool) — private void FigurineCard(CareerData d, GridContainer parent, CareerRelics.Item item, bool owned)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b350b30a8d9)；[`NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`](CareerRelics.cs.md#symbol-0475739162e2)；[`NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`](CareerRelics.cs.md#symbol-27dcdb7c3aa9)；[`NationalSpire.CareerRelics.Status(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`](CareerRelics.cs.md#symbol-cdd79095d49f)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`](LifeScreen.cs.md#symbol-d61ca43b835f)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.RelicArt.Read(string)`](RelicArt.cs.md#symbol-1d35c476ee42)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`；`NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；`NationalSpire.CareerRelics.Item.Effect`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Item.Name`；`NationalSpire.CareerRelics.Item.Price`；`NationalSpire.CareerRelics.Item.Uses`；`NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；`NationalSpire.CareerRelics.Status(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.RelicArt.Read(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 18);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(purchase)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(purchase);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"原价 {CareerMoney.Format(item.Price)} · 送货员七折", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"原价 {CareerMoney.Format(item.Price)} · 送货员七折", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(item.Effect, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(item.Effect, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new TextureRect { Texture = texture, CustomMinimumSize = new Vector2(76, 76),              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new TextureRect { Texture = texture, CustomMinimumSize = new Vector2(76, 76),              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text("◆", 40, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text("◆", 40, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`title.AddChild(Text(item.Name + " · 手办", 22, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddChild(Text(item.Name + " · 手办", 22, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`title.AddChild(Text(owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price), 16, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddChild(Text(owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price), 16, CareerVisuals.Teal));`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = texture, CustomMinimumSize = new Vector2(76, 76),              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new TextureRect { Texture = texture, CustomMinimumSize = new Vector2(76, 76),              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(76, 76)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(76, 76)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(CareerRelics.PurchasePrice(d, item))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(item.Price)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(item.Price)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(price)`；返回值紧邻使用处：`ConditionalExpressionSyntax: owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price)`
- `NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`；输入表达式：`CareerRelics.Buy(d, item.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.Buy(d, item.Id)`
- `NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`CareerRelics.CanBuy(d, item)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.CanBuy(d, item)`
- `NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`CareerRelics.PurchasePrice(d, item)`；返回值紧邻使用处：`ArgumentSyntax: CareerRelics.PurchasePrice(d, item)`
- `NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`CareerRelics.PurchasePrice(d, item)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.PurchasePrice(d, item)`
- `NationalSpire.CareerRelics.Status(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`CareerRelics.Status(d, item)`；返回值紧邻使用处：`ConditionalExpressionSyntax: owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(refill ? "重新购买 · 恢复次数" : collected ? "已经收藏" : "购买手办", () => ConfirmLife(refill ? "恢复手办次数" : "购买手办", refill ? $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 重新购买{item.Name}手办，将次数恢复为 {item.Uses} 次？" : $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 收藏{item.Name}手办？", () =>              { if (MultiplayerCommand("relic", item.Id)) return; var error = CareerRelics.Buy(d, item.Id); Render(); Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null); }), 170)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(refill ? "重新购买 · 恢复次数" : collected ? "已经收藏" : "购买手办", () => ConfirmLife(refill ? "恢复手办次数" : "购买手办", refill ? $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 重新购买{item.Name}手办，将次数恢复为 {item.Uses} 次？" : $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 收藏{item.Name}手办？", () =>              { if (MultiplayerCommand("relic", item.Id)) return; var error = CareerRelics.Buy(d, item.Id); Render(); Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null); }), 170)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；输入表达式：`ConfirmLife(refill ? "恢复手办次数" : "购买手办", refill ? $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 重新购买{item.Name}手办，将次数恢复为 {item.Uses} 次？" : $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 收藏{item.Name}手办？", () =>              { if (MultiplayerCommand("relic", item.Id)) return; var error = CareerRelics.Buy(d, item.Id); Render(); Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null); })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmLife(refill ? "恢复手办次数" : "购买手办", refill ? $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 重新购买{item.Name}手办，将次数恢复为 {item.Uses} 次？" : $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 收藏{item.Name}手办？", () =>              { if (MultiplayerCommand("relic", item.Id)) return; var error = CareerRelics.Buy(d, item.Id); Render(); Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null); })`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("relic", item.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("relic", item.Id)) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("◆", 40, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("◆", 40, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"原价 {CareerMoney.Format(item.Price)} · 送货员七折", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"原价 {CareerMoney.Format(item.Price)} · 送货员七折", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(item.Effect, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(item.Effect, 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(item.Name + " · 手办", 22, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(item.Name + " · 手办", 22, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price), 16, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price), 16, CareerVisuals.Teal)`
- `NationalSpire.RelicArt.Read(string)`；输入表达式：`RelicArt.Read(item.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RelicArt.Read(item.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.Life.Figurines.ContainsKey(item.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Figurines.ContainsKey(item.Id)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new Vector2(76, 76)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `purchase.Disabled` = `!canBuy || d.Credits < price`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Texture` = `texture`

<a id="symbol-b0bc87216d33"></a>

## `NationalSpire.CareerScreen.RenamePlayer(NationalSpire.CareerData) — private void RenamePlayer(CareerData data)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerNames.Rename(NationalSpire.CareerData, string)`](CareerNames.cs.md#symbol-68b4cb4672cb)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.GrabFocus()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerNames.Rename(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GrabFocus()`；输入表达式：`.GrabFocus()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: input?.GrabFocus()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: input = new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(500, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(500, 48)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = CareerEngine.Name(data)`
- `NationalSpire.CareerNames.Rename(NationalSpire.CareerData, string)`；输入表达式：`CareerNames.Rename(data, input.Text)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerNames.Rename(data, input.Text) is { } error`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("rename", text: input.Text)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("rename", text: input.Text)) return true;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("游戏名已更新。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("游戏名已更新。", false);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("修改游戏名", "只修改当前生涯的名字。旧帖子保留原文，点击旧名字仍可查看你的档案。", () =>          {              if (MultiplayerCommand("rename", text: input.Text)) return true;              if (CareerNames.Rename(data, input.Text) is { } error) { status.Text = error; return false; }              Render(); Notice("游戏名已更新。", false); return true;          }, "确认改名", box =>          {              input = new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }; box.AddChild(input);              status = Text("旧内容保留原名。", 16, _muted); box.AddChild(status);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("修改游戏名", "只修改当前生涯的名字。旧帖子保留原文，点击旧名字仍可查看你的档案。", () =>          {              if (MultiplayerCommand("rename", text: input.Text)) return true;              if (CareerNames.Rename(data, input.Text) is { } error) { status.Text = error; return false; }              Render(); Notice("游戏名已更新。", false); return true;          }, "确认改名", box =>          {              input = new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }; box.AddChild(input);              status = Text("旧内容保留原名。", 16, _muted); box.AddChild(status);          });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("旧内容保留原名。", 16, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: status = Text("旧内容保留原名。", 16, _muted)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new Vector2(500, 48)`
- `input` = `new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }`
- `Name` = `"CareerRenameInput"`
- `status.Text` = `error`
- `status` = `Text("旧内容保留原名。", 16, _muted)`
- `Text` = `CareerEngine.Name(data)`

<a id="symbol-825caeb63a3b"></a>

## `NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData) — private void LifeNews(CareerData d)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`](CareerNavigation.cs.md#symbol-3888620952df)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.State`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._lifeHistoryLimit`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.LifeEvent.Day`；`NationalSpire.LifeEvent.Detail`；`NationalSpire.LifeEvent.Important`；`NationalSpire.LifeEvent.PostId`；`NationalSpire.LifeEvent.Title`；`NationalSpire.LifeEvent.Topic`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button("查看更早消息", () => { _lifeHistoryLimit += 12; Render(); }, 200))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button("查看更早消息", () => { _lifeHistoryLimit += 12; Render(); }, 200));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("公开活动和项目成果会在这里公布。", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("公开活动和项目成果会在这里公布。", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("活动公告与公开进展", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("活动公告与公开进展", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Button("查看相关讨论", () => OpenPost(post), 190))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Button("查看相关讨论", () => OpenPost(post), 190));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"{GameCalendar.Text(d, e.Day)} · {e.Topic}", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"{GameCalendar.Text(d, e.Day)} · {e.Topic}", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(e.Detail, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(e.Detail, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(e.Title, 21, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(e.Title, 21, _gold));`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("查看更早消息", () => { _lifeHistoryLimit += 12; Render(); }, 200)`；返回值紧邻使用处：`ArgumentSyntax: Button("查看更早消息", () => { _lifeHistoryLimit += 12; Render(); }, 200)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("查看相关讨论", () => OpenPost(post), 190)`；返回值紧邻使用处：`ArgumentSyntax: Button("查看相关讨论", () => OpenPost(post), 190)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；输入表达式：`OpenPost(post)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPost(post)`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("公开活动和项目成果会在这里公布。", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("公开活动和项目成果会在这里公布。", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("活动公告与公开进展", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("活动公告与公开进展", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{GameCalendar.Text(d, e.Day)} · {e.Topic}", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{GameCalendar.Text(d, e.Day)} · {e.Topic}", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(e.Detail, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(e.Detail, 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(e.Title, 21, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(e.Title, 21, _gold)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).FirstOrDefault`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, e.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(d, e.Day)}`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(d).FirstOrDefault(p => p.Id == e.PostId && p.NewsGeneration.State == "completed")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(d).FirstOrDefault(p => p.Id == e.PostId && p.NewsGeneration.State == "completed")`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Events.OrderByDescending(e => e.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`events.Take(_lifeHistoryLimit)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var e in events.Take(_lifeHistoryLimit))          {              var card = Card(); _content.AddChild(card); var box = Inner(card);              box.AddChild(Text(e.Title, 21, _gold)); box.AddChild(Text($"{GameCalendar.Text(d, e.Day)} · {e.Topic}", 15, _muted)); box.AddChild(Text(e.Detail, 17, _ink));              var post = CommunityThreads.All(d).FirstOrDefault(p => p.Id == e.PostId && p.NewsGeneration.State == "completed");              if (post != null) box.AddChild(Button("查看相关讨论", () => OpenPost(post), 190));          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending(e => e.Important).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending(e => e.Important).ToList()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending(e => e.Important)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending(e => e.Important).ToList`

**赋值（含属性/字段和局部值）：**

- `_lifeHistoryLimit` += `12`
