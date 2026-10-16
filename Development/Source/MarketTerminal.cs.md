# MarketTerminal.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`272ED4CA7B262CF95B4EC32674C2A6ADA74C3080F440E50D9BDC7859A29F5282`。来源：[源码](../../MarketTerminal.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketTerminal`、`NationalSpire.MarketChart`。

字段、事件及初始值（源码原样）：

```csharp
private CareerData? _data;
private Action<MarketOrder>? _submit;
private Action<string>? _person;
private MarketInspectionResult? _inspection;
private int _inspectionGeneration;
private bool _inspectionBusy;
private MarketEvent[] _selectedEvents = [];
private readonly Label[] _metrics = new Label[4];
private readonly MarketAssetButton[] _rows = new MarketAssetButton[8];
private readonly MarketPositionCard[] _holdings = new MarketPositionCard[5];
private readonly Label[] _trades = new Label[5];
private readonly MarketEventRow[] _events = new MarketEventRow[4];
private readonly Label[] _sources = new Label[3];
private readonly Dictionary<string, string> _searchText = [];
private readonly HashSet<string> _watch = [];
private string _identity = "", _selected = "", _query = "";
private bool _forex, _watchOnly, _settingAmount;
private int _portion;
private int _page, _pageCount = 1, _holdPage, _tradePage, _range = 60, _sort;
private string _country = "全部", _sector = "全部";
private Label _name = null!, _quote = null!, _description = null!, _fee = null!, _assetCount = null!;
private Label _depth = null!, _volatility = null!, _newsTitle = null!, _cost = null!, _notional = null!, _buyPrice = null!, _sellPrice = null!;
private ProgressBar _volatilityBar = null!;
private VBoxContainer _overview = null!;
private Button _pin = null!;
private MarketAmountInput _amount = null!, _transfer = null!;
private OptionButton _leverage = null!;
private HBoxContainer _columns = null!;
private VBoxContainer _right = null!;
private ScrollContainer _assetScroll = null!;
private MarketChart _chart = null!;
private readonly ConfigFile _preferences = new();
private bool _loaded;
private IEnumerator<bool>? _builder;
private MarketAsset[] _visible = [];
private MarketPoint[] _points = [];
private string _seed = "";
private int _hover = -1;
private decimal _displayScale = 1;
```

<a id="symbol-f68caab7d69a"></a>

## `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?) — private Label Label(string text, int size = 16, Color? color = null)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`AmountRow(string)`](MarketTerminal.cs.md#symbol-2cc118ecba54)；[`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("font_color", color ?? CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("font_color", color ?? CareerVisuals.Muted);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", size);`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = text, SizeFlagsHorizontal = SizeFlags.ExpandFill, AutowrapMode = TextServer.AutowrapMode.WordSmart, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = text, SizeFlagsHorizontal = SizeFlags.ExpandFill, AutowrapMode = TextServer.AutowrapMode.WordSmart, MouseFilter = MouseFilterEnum.Ignore }`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `text`

<a id="symbol-e98fd552cf86"></a>

## `NationalSpire.MarketTerminal.Button(string, System.Action) — private Button Button(string text, Action action)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** `Godot.Button.Button()`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = text, SizeFlagsHorizontal = SizeFlags.ExpandFill, ClipText = true, CustomMinimumSize = new(0, 40) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = text, SizeFlagsHorizontal = SizeFlags.ExpandFill, ClipText = true, CustomMinimumSize = new(0, 40) }`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 40)`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `action`
- `ClipText` = `true`
- `CustomMinimumSize` = `new(0, 40)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `text`

<a id="symbol-3d766989e03d"></a>

## `NationalSpire.MarketTerminal.Panel(Godot.Node, float) — private VBoxContainer Panel(Node parent, float ratio = 1)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10232f", "345363", 10, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10232f", "345363", 10, 10));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(panel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = ratio }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = ratio }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("10232f", "345363", 10, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("10232f", "345363", 10, 10)`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsStretchRatio` = `ratio`

<a id="symbol-965685631592"></a>

## `NationalSpire.MarketTerminal.Money() — private static MarketAmountInput Money()`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`NationalSpire.MarketAmountInput.MarketAmountInput()`](MarketAmountInput.cs.md#symbol-8bd963175996)；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 46)`
- `NationalSpire.MarketAmountInput.MarketAmountInput()`；输入表达式：`new() { MinValue = 0, MaxValue = long.MaxValue * 10.0, AllowGreater = true, Value = 1000, Step = .01, Prefix = "$", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 46) }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new() { MinValue = 0, MaxValue = long.MaxValue * 10.0, AllowGreater = true, Value = 1000, Step = .01, Prefix = "$", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 46) }`

**赋值（含属性/字段和局部值）：**

- `AllowGreater` = `true`
- `CustomMinimumSize` = `new(0, 46)`
- `MaxValue` = `long.MaxValue * 10.0`
- `MinValue` = `0`
- `Prefix` = `"$"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Step` = `.01`
- `Value` = `1000`

<a id="symbol-ca583ab46f87"></a>

## `NationalSpire.MarketTerminal.MarketTerminal() — internal MarketTerminal()`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerListCache.Market`](CareerListCache.cs.md#symbol-8e4ce39fadc2)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)；`Godot.Resource.Duplicate(bool)`；`Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；`Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；`System.Collections.Generic.IEnumerable<T>.GetEnumerator()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.CreateTheme()`；`NationalSpire.MarketTerminal._builder`；`NationalSpire.MarketTerminal.Build()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Resource.Duplicate(bool)`；输入表达式：`CareerVisuals.CreateTheme().Duplicate()`；返回值紧邻使用处：`CastExpressionSyntax: (Theme)CareerVisuals.CreateTheme().Duplicate()`
- `Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；输入表达式：`Theme.SetConstant("separation", "HBoxContainer", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: Theme.SetConstant("separation", "HBoxContainer", 8);`
- `Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；输入表达式：`Theme.SetConstant("separation", "VBoxContainer", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: Theme.SetConstant("separation", "VBoxContainer", 6);`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`Theme.SetStylebox("hover", type, CareerVisuals.Box("28495a", "70d4bc", 6, 6))`；返回值紧邻使用处：`ExpressionStatementSyntax: Theme.SetStylebox("hover", type, CareerVisuals.Box("28495a", "70d4bc", 6, 6));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`Theme.SetStylebox("normal", "LineEdit", CareerVisuals.Box("101c2a", "395365", 6, 6))`；返回值紧邻使用处：`ExpressionStatementSyntax: Theme.SetStylebox("normal", "LineEdit", CareerVisuals.Box("101c2a", "395365", 6, 6));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`Theme.SetStylebox("normal", type, CareerVisuals.Box("1d3040", "395365", 6, 6))`；返回值紧邻使用处：`ExpressionStatementSyntax: Theme.SetStylebox("normal", type, CareerVisuals.Box("1d3040", "395365", 6, 6));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`Theme.SetStylebox("pressed", type, CareerVisuals.Box("304f60", "e5c18b", 6, 6))`；返回值紧邻使用处：`ExpressionStatementSyntax: Theme.SetStylebox("pressed", type, CareerVisuals.Box("304f60", "e5c18b", 6, 6));`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("101c2a", "395365", 6, 6)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("101c2a", "395365", 6, 6)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("1d3040", "395365", 6, 6)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("1d3040", "395365", 6, 6)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("28495a", "70d4bc", 6, 6)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("28495a", "70d4bc", 6, 6)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("304f60", "e5c18b", 6, 6)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("304f60", "e5c18b", 6, 6)`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.CreateTheme().Duplicate`
- `NationalSpire.MarketTerminal.Build()`；输入表达式：`Build()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Build().GetEnumerator`
- `System.Collections.Generic.IEnumerable<T>.GetEnumerator()`；输入表达式：`Build().GetEnumerator()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _builder = Build().GetEnumerator()`

**赋值（含属性/字段和局部值）：**

- `_builder` = `Build().GetEnumerator()`
- `Theme.DefaultFontSize` = `16`
- `Theme` = `(Theme)CareerVisuals.CreateTheme().Duplicate()`

<a id="symbol-64aae4a775dc"></a>

## `NationalSpire.MarketTerminal.Prepare(double) — internal bool Prepare(double budgetMilliseconds)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerListCache._Process(double)`](CareerListCache.cs.md#symbol-e8085c360313)；[`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`](MarketTerminal.cs.md#symbol-09b1a1ea6de7)

**调用：** `System.Collections.IEnumerator.MoveNext()`；`System.Diagnostics.Stopwatch.StartNew()`；`System.IDisposable.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketTerminal._builder`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.IEnumerator.MoveNext()`；输入表达式：`_builder.MoveNext()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_builder.MoveNext()`
- `System.Diagnostics.Stopwatch.StartNew()`；输入表达式：`System.Diagnostics.Stopwatch.StartNew()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Diagnostics.Stopwatch.StartNew()`
- `System.IDisposable.Dispose()`；输入表达式：`_builder.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: _builder.Dispose();`

**赋值（含属性/字段和局部值）：**

- `_builder` = `null`

<a id="symbol-285abee5b9f5"></a>

## `NationalSpire.MarketTerminal.Build() — private IEnumerable<bool> Build()`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.MarketTerminal()`](MarketTerminal.cs.md#symbol-ca583ab46f87)

**调用：** [`AmountRow(string)`](MarketTerminal.cs.md#symbol-2cc118ecba54)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketAssetButton.MarketAssetButton()`](MarketVisuals.cs.md#symbol-3e8aa8ef1217)；[`NationalSpire.MarketEventRow.MarketEventRow()`](MarketVisuals.cs.md#symbol-b32cc5c2b62a)；[`NationalSpire.MarketPositionCard.MarketPositionCard(System.Action, System.Action<NationalSpire.MarketOrder>)`](MarketVisuals.cs.md#symbol-66bfead77ff7)；[`NationalSpire.MarketTerminal.Button(string, System.Action)`](MarketTerminal.cs.md#symbol-e98fd552cf86)；[`NationalSpire.MarketTerminal.ChangePage(int)`](MarketTerminal.cs.md#symbol-83787d38907b)；[`NationalSpire.MarketTerminal.ClosePosition(int)`](MarketTerminal.cs.md#symbol-1a0f641bc735)；[`NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`](MarketTerminal.cs.md#symbol-f68caab7d69a)；[`NationalSpire.MarketTerminal.Money()`](MarketTerminal.cs.md#symbol-965685631592)；[`NationalSpire.MarketTerminal.Open(int)`](MarketTerminal.cs.md#symbol-9665309ab157)；[`NationalSpire.MarketTerminal.Panel(Godot.Node, float)`](MarketTerminal.cs.md#symbol-3d766989e03d)；[`NationalSpire.MarketTerminal.RefreshAccount(bool)`](MarketTerminal.cs.md#symbol-9559baf40113)；[`NationalSpire.MarketTerminal.RefreshChart()`](MarketTerminal.cs.md#symbol-e1b73bf4bb8f)；[`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)；[`NationalSpire.MarketTerminal.ResetList()`](MarketTerminal.cs.md#symbol-d43e3b0284a7)；[`NationalSpire.MarketTerminal.SelectRow(int)`](MarketTerminal.cs.md#symbol-3c5b757d5a8f)；[`NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder)`](MarketTerminal.cs.md#symbol-63d52edc18fa)；[`NationalSpire.MarketVisuals.ActionStyle(Godot.Button, string)`](MarketVisuals.cs.md#symbol-5703b8242580)；`Godot.CheckBox.CheckBox()`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.HSeparator.HSeparator()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetParent()`；`Godot.Node.Reparent(Godot.Node, bool)`；`Godot.OptionButton.AddIconItem(Godot.Texture2D, string, int)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.GetItemText(int)`；`Godot.OptionButton.OptionButton()`；`Godot.ProgressBar.ProgressBar()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.SpinBox.Apply()`；`Godot.SpinBox.GetLineEdit()`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.MarketChart.MarketChart()`；`NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `AmountRow(string)`；`NationalSpire.CareerMarket.Leverages`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.MarketAmountInput.Amount`；`NationalSpire.MarketEvent.Person`；`NationalSpire.MarketTerminal._amount`；`NationalSpire.MarketTerminal._assetCount`；`NationalSpire.MarketTerminal._assetScroll`；`NationalSpire.MarketTerminal._buyPrice`；`NationalSpire.MarketTerminal._chart`；`NationalSpire.MarketTerminal._columns`；`NationalSpire.MarketTerminal._cost`；`NationalSpire.MarketTerminal._country`；`NationalSpire.MarketTerminal._depth`；`NationalSpire.MarketTerminal._description`；`NationalSpire.MarketTerminal._events`；`NationalSpire.MarketTerminal._fee`；`NationalSpire.MarketTerminal._forex`；`NationalSpire.MarketTerminal._holdings`；`NationalSpire.MarketTerminal._holdPage`；`NationalSpire.MarketTerminal._leverage`；`NationalSpire.MarketTerminal._metrics`；`NationalSpire.MarketTerminal._name`；`NationalSpire.MarketTerminal._newsTitle`；`NationalSpire.MarketTerminal._notional`；`NationalSpire.MarketTerminal._overview`；`NationalSpire.MarketTerminal._person`；`NationalSpire.MarketTerminal._pin`；`NationalSpire.MarketTerminal._portion`；`NationalSpire.MarketTerminal._query`；`NationalSpire.MarketTerminal._quote`；`NationalSpire.MarketTerminal._range`；`NationalSpire.MarketTerminal._right`；`NationalSpire.MarketTerminal._rows`；`NationalSpire.MarketTerminal._sector`；`NationalSpire.MarketTerminal._selectedEvents`；`NationalSpire.MarketTerminal._sellPrice`；`NationalSpire.MarketTerminal._settingAmount`；`NationalSpire.MarketTerminal._sort`；`NationalSpire.MarketTerminal._sources`；`NationalSpire.MarketTerminal._tradePage`；`NationalSpire.MarketTerminal._trades`；`NationalSpire.MarketTerminal._transfer`；`NationalSpire.MarketTerminal._volatility`；`NationalSpire.MarketTerminal._volatilityBar`；`NationalSpire.MarketTerminal._watchOnly`；`NationalSpire.MarketTerminal.Button(string, System.Action)`；`NationalSpire.MarketTerminal.ChangePage(int)`；`NationalSpire.MarketTerminal.ClosePosition(int)`；`NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；`NationalSpire.MarketTerminal.Money()`；`NationalSpire.MarketTerminal.Open(int)`；`NationalSpire.MarketTerminal.Panel(Godot.Node, float)`；`NationalSpire.MarketTerminal.RefreshAccount(bool)`；`NationalSpire.MarketTerminal.RefreshChart()`；`NationalSpire.MarketTerminal.RefreshFee()`；`NationalSpire.MarketTerminal.ResetList()`；`NationalSpire.MarketTerminal.SelectRow(int)`；`NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder)`；`NationalSpire.MarketTerminal.ToggleWatch()`；`NationalSpire.MarketVisuals.ActionStyle(Godot.Button, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `AmountRow(string)`；输入表达式：`AmountRow("交易总额")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _notional = AmountRow("交易总额")`
- `AmountRow(string)`；输入表达式：`AmountRow("手续费")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _fee = AmountRow("手续费")`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Text = "只看自选" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Text = "只看自选" }`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_volatilityBar.AddThemeStyleboxOverride("background", CareerVisuals.Box("091923", "203844", 3, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: _volatilityBar.AddThemeStyleboxOverride("background", CareerVisuals.Box("091923", "203844", 3, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_volatilityBar.AddThemeStyleboxOverride("fill", CareerVisuals.Box("e4b367", "e4b367", 3, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: _volatilityBar.AddThemeStyleboxOverride("fill", CareerVisuals.Box("e4b367", "e4b367", 3, 0));`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2 }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _columns = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator()`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { PlaceholderText = "搜索品牌、选手或俱乐部", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { PlaceholderText = "搜索品牌、选手或俱乐部", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_assetScroll.AddChild(assetList)`；返回值紧邻使用处：`ExpressionStatementSyntax: _assetScroll.AddChild(assetList);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_overview.AddChild(sources)`；返回值紧邻使用处：`ExpressionStatementSyntax: _overview.AddChild(sources);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_overview.AddChild(traits)`；返回值紧邻使用处：`ExpressionStatementSyntax: _overview.AddChild(traits);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(_amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(_amount);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(_buyPrice)`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(_buyPrice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(_leverage)`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(_leverage);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(_sellPrice)`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(_sellPrice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(_transfer)`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(_transfer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(Button("还清借款", () => Submit(new("repay-all"))))`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(Button("还清借款", () => Submit(new("repay-all"))));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(buy)`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(buy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(Label("保证金", 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(Label("保证金", 14));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(Label("杠杆倍数", 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(Label("杠杆倍数", 14));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(Label("借款 $500—50,000，日利率按金额为0.02% / 0.04% / 0.07%。", 13))`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(Label("借款 $500—50,000，日利率按金额为0.02% / 0.04% / 0.07%。", 13));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(Label("下单", 22, CareerVisuals.Gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(Label("下单", 22, CareerVisuals.Gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(Label("资金存取", 22, CareerVisuals.Gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(Label("资金存取", 22, CareerVisuals.Gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(new HSeparator())`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(new HSeparator());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(portions)`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(portions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(sell)`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(sell);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_right.AddChild(transfers)`；返回值紧邻使用处：`ExpressionStatementSyntax: _right.AddChild(transfers);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(bottom)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(bottom);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(top)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(top);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`assetList.AddChild(_rows[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: assetList.AddChild(_rows[i]);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(icon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(Label(title, 13))`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(Label(title, 13));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(_metrics[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(_metrics[i]);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(_volatilityBar)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(_volatilityBar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(Label(titles[i], 15))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(Label(titles[i], 15));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(value);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(_chart)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(_chart);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(_description)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(_description);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(_events[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(_events[i]);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(_newsTitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(_newsTitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(_overview)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(_overview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(_quote)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(_quote);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(ranges)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(ranges);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cost.AddChild(_cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: cost.AddChild(_cost);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cost.AddChild(Label("合计扣款", 13))`；返回值紧邻使用处：`ExpressionStatementSyntax: cost.AddChild(Label("合计扣款", 13));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(country)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(country);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(sector)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(sector);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(_name)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(_name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(_pin)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(_pin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`holdings.AddChild(_holdings[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: holdings.AddChild(_holdings[i]);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`holdings.AddChild(hp)`；返回值紧邻使用处：`ExpressionStatementSyntax: holdings.AddChild(hp);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`holdings.AddChild(Label("持仓", 22, CareerVisuals.Gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: holdings.AddChild(Label("持仓", 22, CareerVisuals.Gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`hp.AddChild(Button("←", () => { _holdPage = Math.Max(0, _holdPage - 1); RefreshAccount(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: hp.AddChild(Button("←", () => { _holdPage = Math.Max(0, _holdPage - 1); RefreshAccount(); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`hp.AddChild(Button("→", () => { _holdPage++; RefreshAccount(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: hp.AddChild(Button("→", () => { _holdPage++; RefreshAccount(); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`kinds.AddChild(brands)`；返回值紧邻使用处：`ExpressionStatementSyntax: kinds.AddChild(brands);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`kinds.AddChild(forex)`；返回值紧邻使用处：`ExpressionStatementSyntax: kinds.AddChild(forex);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ledger.AddChild(_trades[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: ledger.AddChild(_trades[i]);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ledger.AddChild(Label("结算与成交", 22, CareerVisuals.Gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: ledger.AddChild(Label("结算与成交", 22, CareerVisuals.Gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ledger.AddChild(tp)`；返回值紧邻使用处：`ExpressionStatementSyntax: ledger.AddChild(tp);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(_assetCount)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(_assetCount);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(_assetScroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(_assetScroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(filters)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(filters);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(kinds)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(kinds);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(Label("MARKET / 行情", 21, CareerVisuals.Gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(Label("MARKET / 行情", 21, CareerVisuals.Gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(pages)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(pages);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(sort)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(sort);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(watched)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(watched);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pages.AddChild(Button("←", () => ChangePage(-1)))`；返回值紧邻使用处：`ExpressionStatementSyntax: pages.AddChild(Button("←", () => ChangePage(-1)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pages.AddChild(Button("→", () => ChangePage(1)))`；返回值紧邻使用处：`ExpressionStatementSyntax: pages.AddChild(Button("→", () => ChangePage(1)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`portions.AddChild(Button(percent + "%", () =>          {              _portion = percent; RefreshFee();          }))`；返回值紧邻使用处：`ExpressionStatementSyntax: portions.AddChild(Button(percent + "%", () =>          {              _portion = percent; RefreshFee();          }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ranges.AddChild(Button(count + "日", () => { _range = count; RefreshChart(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: ranges.AddChild(Button(count + "日", () => { _range = count; RefreshChart(); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`source.AddChild(_sources[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: source.AddChild(_sources[i]);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`source.AddChild(new TextureRect { Texture = LifestyleArt.Icon(i == 0 ? "训练装备" : i == 1 ? "人气榜" : "交易市场"), CustomMinimumSize = new(16, 16), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered })`；返回值紧邻使用处：`ExpressionStatementSyntax: source.AddChild(new TextureRect { Texture = LifestyleArt.Icon(i == 0 ? "训练装备" : i == 1 ? "人气榜" : "交易市场"), CustomMinimumSize = new(16, 16), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sources.AddChild(source)`；返回值紧邻使用处：`ExpressionStatementSyntax: sources.AddChild(source);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tp.AddChild(Button("←", () => { _tradePage = Math.Max(0, _tradePage - 1); RefreshAccount(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: tp.AddChild(Button("←", () => { _tradePage = Math.Max(0, _tradePage - 1); RefreshAccount(); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tp.AddChild(Button("→", () => { _tradePage++; RefreshAccount(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: tp.AddChild(Button("→", () => { _tradePage++; RefreshAccount(); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`transfers.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: transfers.AddChild(button);`
- `Godot.Node.GetParent()`；输入表达式：`_right.GetParent()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _right.GetParent()`
- `Godot.Node.GetParent()`；输入表达式：`panel.GetParent()`；返回值紧邻使用处：`BinaryExpressionSyntax: panel.GetParent() != _columns`
- `Godot.Node.GetParent()`；输入表达式：`panel.GetParent()`；返回值紧邻使用处：`BinaryExpressionSyntax: panel.GetParent() == _columns`
- `Godot.Node.Reparent(Godot.Node, bool)`；输入表达式：`panel.Reparent(_columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.Reparent(_columns);`
- `Godot.Node.Reparent(Godot.Node, bool)`；输入表达式：`panel.Reparent(this)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.Reparent(this);`
- `Godot.OptionButton.AddIconItem(Godot.Texture2D, string, int)`；输入表达式：`_leverage.AddIconItem(LifestyleArt.Icon("杠杆"), value + " ×")`；返回值紧邻使用处：`ExpressionStatementSyntax: _leverage.AddIconItem(LifestyleArt.Icon("杠杆"), value + " ×");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`country.AddItem(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: country.AddItem(value);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`sector.AddItem(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: sector.AddItem(value);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`sort.AddItem(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: sort.AddItem(value);`
- `Godot.OptionButton.GetItemText(int)`；输入表达式：`country.GetItemText((int)i)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _country = country.GetItemText((int)i)`
- `Godot.OptionButton.GetItemText(int)`；输入表达式：`sector.GetItemText((int)i)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sector = sector.GetItemText((int)i)`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _leverage = new OptionButton()`
- `Godot.ProgressBar.ProgressBar()`；输入表达式：`new ProgressBar { MaxValue = .03, Step = .000001, ShowPercentage = false, CustomMinimumSize = new(0, 5), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _volatilityBar = new ProgressBar { MaxValue = .03, Step = .000001, ShowPercentage = false, CustomMinimumSize = new(0, 5), MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { Name = "MarketAssets", HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled,              SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 284), MouseFilter = MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _assetScroll = new ScrollContainer { Name = "MarketAssets", HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled,              SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 284), MouseFilter = MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`
- `Godot.SpinBox.Apply()`；输入表达式：`_transfer.Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: _transfer.Apply();`
- `Godot.SpinBox.GetLineEdit()`；输入表达式：`_amount.GetLineEdit()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _amount.GetLineEdit().TextChanged`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = LifestyleArt.Icon(i == 0 ? "训练装备" : i == 1 ? "人气榜" : "交易市场"), CustomMinimumSize = new(16, 16), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`；返回值紧邻使用处：`ArgumentSyntax: new TextureRect { Texture = LifestyleArt.Icon(i == 0 ? "训练装备" : i == 1 ? "人气榜" : "交易市场"), CustomMinimumSize = new(16, 16), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = LifestyleArt.Icon(title == "承接规模" ? "外汇" : "波动"), CustomMinimumSize = new(18, 18), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextureRect { Texture = LifestyleArt.Icon(title == "承接规模" ? "外汇" : "波动"), CustomMinimumSize = new(18, 18), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _overview = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 270)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 270)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 284)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 284)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 5)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(16, 16)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(16, 16)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(18, 18)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(18, 18)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(48, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pin.CustomMinimumSize = new(48, 40)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("091923", "203844", 3, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("091923", "203844", 3, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("e4b367", "e4b367", 3, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("e4b367", "e4b367", 3, 0)`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon("杠杆")`；返回值紧邻使用处：`ArgumentSyntax: LifestyleArt.Icon("杠杆")`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon("日常消费")`；返回值紧邻使用处：`AssignmentExpressionSyntax: brands.Icon = LifestyleArt.Icon("日常消费")`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon("外汇")`；返回值紧邻使用处：`AssignmentExpressionSyntax: forex.Icon = LifestyleArt.Icon("外汇")`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(action is "deposit" or "withdraw" ? "外汇" : "收支记录")`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.Icon = LifestyleArt.Icon(action is "deposit" or "withdraw" ? "外汇" : "收支记录")`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(i == 0 ? "训练装备" : i == 1 ? "人气榜" : "交易市场")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture = LifestyleArt.Icon(i == 0 ? "训练装备" : i == 1 ? "人气榜" : "交易市场")`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(title == "承接规模" ? "外汇" : "波动")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture = LifestyleArt.Icon(title == "承接规模" ? "外汇" : "波动")`
- `NationalSpire.MarketAssetButton.MarketAssetButton()`；输入表达式：`new MarketAssetButton()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _rows[i] = new MarketAssetButton()`
- `NationalSpire.MarketChart.MarketChart()`；输入表达式：`new MarketChart { CustomMinimumSize = new(0, 270), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chart = new MarketChart { CustomMinimumSize = new(0, 270), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.MarketEventRow.MarketEventRow()`；输入表达式：`new MarketEventRow()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _events[i] = new MarketEventRow()`
- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new("repay-all")`；返回值紧邻使用处：`ArgumentSyntax: new("repay-all")`
- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new(action, Amount: amount)`；返回值紧邻使用处：`ArgumentSyntax: new(action, Amount: amount)`
- `NationalSpire.MarketPositionCard.MarketPositionCard(System.Action, System.Action<NationalSpire.MarketOrder>)`；输入表达式：`new MarketPositionCard(() => ClosePosition(row), Submit)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _holdings[i] = new MarketPositionCard(() => ClosePosition(row), Submit)`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("←", () => { _holdPage = Math.Max(0, _holdPage - 1); RefreshAccount(); })`；返回值紧邻使用处：`ArgumentSyntax: Button("←", () => { _holdPage = Math.Max(0, _holdPage - 1); RefreshAccount(); })`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("←", () => { _tradePage = Math.Max(0, _tradePage - 1); RefreshAccount(); })`；返回值紧邻使用处：`ArgumentSyntax: Button("←", () => { _tradePage = Math.Max(0, _tradePage - 1); RefreshAccount(); })`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("←", () => ChangePage(-1))`；返回值紧邻使用处：`ArgumentSyntax: Button("←", () => ChangePage(-1))`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("→", () => { _holdPage++; RefreshAccount(); })`；返回值紧邻使用处：`ArgumentSyntax: Button("→", () => { _holdPage++; RefreshAccount(); })`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("→", () => { _tradePage++; RefreshAccount(); })`；返回值紧邻使用处：`ArgumentSyntax: Button("→", () => { _tradePage++; RefreshAccount(); })`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("→", () => ChangePage(1))`；返回值紧邻使用处：`ArgumentSyntax: Button("→", () => ChangePage(1))`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("☆", ToggleWatch)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pin = Button("☆", ToggleWatch)`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("还清借款", () => Submit(new("repay-all")))`；返回值紧邻使用处：`ArgumentSyntax: Button("还清借款", () => Submit(new("repay-all")))`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("品牌", () => { _forex = false; ResetList(); })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("品牌", () => { _forex = false; ResetList(); })`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("外汇", () => { _forex = true; ResetList(); })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("外汇", () => { _forex = true; ResetList(); })`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("做多", () => Open(1))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("做多", () => Open(1))`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button("做空", () => Open(-1))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("做空", () => Open(-1))`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button(count + "日", () => { _range = count; RefreshChart(); })`；返回值紧邻使用处：`ArgumentSyntax: Button(count + "日", () => { _range = count; RefreshChart(); })`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button(percent + "%", () =>          {              _portion = percent; RefreshFee();          })`；返回值紧邻使用处：`ArgumentSyntax: Button(percent + "%", () =>          {              _portion = percent; RefreshFee();          })`
- `NationalSpire.MarketTerminal.Button(string, System.Action)`；输入表达式：`Button(title, () => { decimal amount = _transfer.Amount / 10; _transfer.Apply(); Submit(new(action, Amount: amount)); })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(title, () => { decimal amount = _transfer.Amount / 10; _transfer.Apply(); Submit(new(action, Amount: amount)); })`
- `NationalSpire.MarketTerminal.ChangePage(int)`；输入表达式：`ChangePage(-1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ChangePage(-1)`
- `NationalSpire.MarketTerminal.ChangePage(int)`；输入表达式：`ChangePage(1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ChangePage(1)`
- `NationalSpire.MarketTerminal.ClosePosition(int)`；输入表达式：`ClosePosition(row)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ClosePosition(row)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 13)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _buyPrice = Label("", 13)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 13)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sellPrice = Label("", 13)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 13)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sources[i] = Label("", 13)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 15)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _description = Label("", 15)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 16)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _trades[i] = Label("", 16)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 21, CareerVisuals.Gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Label("", 21, CareerVisuals.Gold)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 26, CareerVisuals.Gold)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _cost = Label("", 26, CareerVisuals.Gold)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 26, CareerVisuals.Gold)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _name = Label("", 26, CareerVisuals.Gold)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 27, CareerVisuals.Gold)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _metrics[i] = Label("", 27, CareerVisuals.Gold)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 30, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _quote = Label("", 30, CareerVisuals.Teal)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _assetCount = Label("")`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("保证金", 14)`；返回值紧邻使用处：`ArgumentSyntax: Label("保证金", 14)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("持仓", 22, CareerVisuals.Gold)`；返回值紧邻使用处：`ArgumentSyntax: Label("持仓", 22, CareerVisuals.Gold)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("杠杆倍数", 14)`；返回值紧邻使用处：`ArgumentSyntax: Label("杠杆倍数", 14)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("合计扣款", 13)`；返回值紧邻使用处：`ArgumentSyntax: Label("合计扣款", 13)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("结算与成交", 22, CareerVisuals.Gold)`；返回值紧邻使用处：`ArgumentSyntax: Label("结算与成交", 22, CareerVisuals.Gold)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("借款 $500—50,000，日利率按金额为0.02% / 0.04% / 0.07%。", 13)`；返回值紧邻使用处：`ArgumentSyntax: Label("借款 $500—50,000，日利率按金额为0.02% / 0.04% / 0.07%。", 13)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("近期动态", 18, CareerVisuals.Gold)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _newsTitle = Label("近期动态", 18, CareerVisuals.Gold)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("下单", 22, CareerVisuals.Gold)`；返回值紧邻使用处：`ArgumentSyntax: Label("下单", 22, CareerVisuals.Gold)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("资金存取", 22, CareerVisuals.Gold)`；返回值紧邻使用处：`ArgumentSyntax: Label("资金存取", 22, CareerVisuals.Gold)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("MARKET / 行情", 21, CareerVisuals.Gold)`；返回值紧邻使用处：`ArgumentSyntax: Label("MARKET / 行情", 21, CareerVisuals.Gold)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label(title, 13)`；返回值紧邻使用处：`ArgumentSyntax: Label(title, 13)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label(titles[i], 15)`；返回值紧邻使用处：`ArgumentSyntax: Label(titles[i], 15)`
- `NationalSpire.MarketTerminal.Money()`；输入表达式：`Money()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _amount = Money()`
- `NationalSpire.MarketTerminal.Money()`；输入表达式：`Money()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _transfer = Money()`
- `NationalSpire.MarketTerminal.Open(int)`；输入表达式：`Open(-1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Open(-1)`
- `NationalSpire.MarketTerminal.Open(int)`；输入表达式：`Open(1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Open(1)`
- `NationalSpire.MarketTerminal.Panel(Godot.Node, float)`；输入表达式：`Panel(_columns, 22)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Panel(_columns, 22)`
- `NationalSpire.MarketTerminal.Panel(Godot.Node, float)`；输入表达式：`Panel(_columns, 25)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _right = Panel(_columns, 25)`
- `NationalSpire.MarketTerminal.Panel(Godot.Node, float)`；输入表达式：`Panel(_columns, 53)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Panel(_columns, 53)`
- `NationalSpire.MarketTerminal.Panel(Godot.Node, float)`；输入表达式：`Panel(_right)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Panel(_right)`
- `NationalSpire.MarketTerminal.Panel(Godot.Node, float)`；输入表达式：`Panel(bottom)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Panel(bottom)`
- `NationalSpire.MarketTerminal.Panel(Godot.Node, float)`；输入表达式：`Panel(top)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Panel(top)`
- `NationalSpire.MarketTerminal.Panel(Godot.Node, float)`；输入表达式：`Panel(traits)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Panel(traits)`
- `NationalSpire.MarketTerminal.RefreshAccount(bool)`；输入表达式：`RefreshAccount()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshAccount();`
- `NationalSpire.MarketTerminal.RefreshChart()`；输入表达式：`RefreshChart()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshChart();`
- `NationalSpire.MarketTerminal.RefreshFee()`；输入表达式：`RefreshFee()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshFee();`
- `NationalSpire.MarketTerminal.RefreshFee()`；输入表达式：`RefreshFee()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => RefreshFee()`
- `NationalSpire.MarketTerminal.ResetList()`；输入表达式：`ResetList()`；返回值紧邻使用处：`ExpressionStatementSyntax: ResetList();`
- `NationalSpire.MarketTerminal.SelectRow(int)`；输入表达式：`SelectRow(row)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => SelectRow(row)`
- `NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder)`；输入表达式：`Submit(new("repay-all"))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Submit(new("repay-all"))`
- `NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder)`；输入表达式：`Submit(new(action, Amount: amount))`；返回值紧邻使用处：`ExpressionStatementSyntax: Submit(new(action, Amount: amount));`
- `NationalSpire.MarketVisuals.ActionStyle(Godot.Button, string)`；输入表达式：`MarketVisuals.ActionStyle(buy, "做多")`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketVisuals.ActionStyle(buy, "做多");`
- `NationalSpire.MarketVisuals.ActionStyle(Godot.Button, string)`；输入表达式：`MarketVisuals.ActionStyle(sell, "做空")`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketVisuals.ActionStyle(sell, "做空");`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(_selectedEvents[row].Person)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _person?.Invoke(_selectedEvents[row].Person)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "全部" }.Concat(EsportsWorld.Countries)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string value in new[] { "全部" }.Concat(EsportsWorld.Countries)) country.AddItem(value);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, _holdPage - 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _holdPage = Math.Max(0, _holdPage - 1)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, _tradePage - 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _tradePage = Math.Max(0, _tradePage - 1)`

**赋值（含属性/字段和局部值）：**

- `_amount.GetLineEdit().TextChanged` += `_ => { if (!_settingAmount) { _portion = 0; RefreshFee(); } }`
- `_amount.Step` = `.01`
- `_amount.UpdateOnTextChanged` = `true`
- `_amount.ValueChanged` += `_ => { if (!_settingAmount) { _portion = 0; RefreshFee(); } }`
- `_amount` = `Money()`
- `_assetCount` = `Label("")`
- `_assetScroll` = `new ScrollContainer { Name = "MarketAssets", HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled,              SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 284), MouseFilter = MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`
- `_buyPrice` = `Label("", 13)`
- `_chart` = `new MarketChart { CustomMinimumSize = new(0, 270), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_columns` = `new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_cost` = `Label("", 26, CareerVisuals.Gold)`
- `_country` = `country.GetItemText((int)i)`
- `_depth` = `value`
- `_description` = `Label("", 15)`
- `_events[i].Pressed` += `() => { if (row < _selectedEvents.Length && _selectedEvents[row].Person.Length > 0) _person?.Invoke(_selectedEvents[row].Person); }`
- `_events[i]` = `new MarketEventRow()`
- `_fee` = `AmountRow("手续费")`
- `_forex` = `false`
- `_forex` = `true`
- `_holdings[i]` = `new MarketPositionCard(() => ClosePosition(row), Submit)`
- `_holdPage` = `Math.Max(0, _holdPage - 1)`
- `_leverage.ItemSelected` += `_ => RefreshFee()`
- `_leverage` = `new OptionButton()`
- `_metrics[i]` = `Label("", 27, CareerVisuals.Gold)`
- `_name` = `Label("", 26, CareerVisuals.Gold)`
- `_newsTitle` = `Label("近期动态", 18, CareerVisuals.Gold)`
- `_notional` = `AmountRow("交易总额")`
- `_overview` = `new VBoxContainer()`
- `_pin.CustomMinimumSize` = `new(48, 40)`
- `_pin.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `_pin` = `Button("☆", ToggleWatch)`
- `_portion` = `0`
- `_portion` = `percent`
- `_query` = `value`
- `_quote` = `Label("", 30, CareerVisuals.Teal)`
- `_range` = `count`
- `_right` = `Panel(_columns, 25)`
- `_rows[i].Pressed` += `() => SelectRow(row)`
- `_rows[i]` = `new MarketAssetButton()`
- `_sector` = `sector.GetItemText((int)i)`
- `_sellPrice` = `Label("", 13)`
- `_sort` = `(int)i`
- `_sources[i].AutowrapMode` = `TextServer.AutowrapMode.Off`
- `_sources[i].SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `_sources[i]` = `Label("", 13)`
- `_tradePage` = `Math.Max(0, _tradePage - 1)`
- `_trades[i]` = `Label("", 16)`
- `_transfer` = `Money()`
- `_volatility` = `value`
- `_volatilityBar` = `new ProgressBar { MaxValue = .03, Step = .000001, ShowPercentage = false, CustomMinimumSize = new(0, 5), MouseFilter = MouseFilterEnum.Ignore }`
- `_watchOnly` = `value`
- `brands.Icon` = `LifestyleArt.Icon("日常消费")`
- `button.Icon` = `LifestyleArt.Icon(action is "deposit" or "withdraw" ? "外汇" : "收支记录")`
- `card.TooltipText` = `"承接规模越大，同等金额订单造成的成交价差越小。"`
- `card.TooltipText` = `"数值越大，日常报价起伏通常越明显。刻度范围0%至3%。"`
- `Columns` = `2`
- `country.ItemSelected` += `i => { _country = country.GetItemText((int)i); ResetList(); }`
- `CustomMinimumSize` = `new(0, 270)`
- `CustomMinimumSize` = `new(0, 284)`
- `CustomMinimumSize` = `new(0, 5)`
- `CustomMinimumSize` = `new(16, 16)`
- `CustomMinimumSize` = `new(18, 18)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `forex.Icon` = `LifestyleArt.Icon("外汇")`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `left.SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `MaxValue` = `.03`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `MouseForcePassScrollEvents` = `false`
- `Name` = `"MarketAssets"`
- `PlaceholderText` = `"搜索品牌、选手或俱乐部"`
- `Resized` += `() =>          {              var panel = _right.GetParent(); bool narrow = Size.X < 1050;              if (narrow && panel.GetParent() == _columns) panel.Reparent(this);              else if (!narrow && panel.GetParent() != _columns) panel.Reparent(_columns);          }`
- `search.TextChanged` += `value => { _query = value; ResetList(); }`
- `sector.ItemSelected` += `i => { _sector = sector.GetItemText((int)i); ResetList(); }`
- `sell.Name` = `"Short"`
- `ShowPercentage` = `false`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `sort.ItemSelected` += `i => { _sort = (int)i; ResetList(); }`
- `Step` = `.000001`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Text` = `"只看自选"`
- `Texture` = `LifestyleArt.Icon(i == 0 ? "训练装备" : i == 1 ? "人气榜" : "交易市场")`
- `Texture` = `LifestyleArt.Icon(title == "承接规模" ? "外汇" : "波动")`
- `watched.Toggled` += `value => { _watchOnly = value; ResetList(); }`

<a id="symbol-2cc118ecba54"></a>

## `AmountRow(string) — Label AmountRow(string title)`

来源：源码第 175 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`](MarketTerminal.cs.md#symbol-f68caab7d69a)；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cost.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: cost.AddChild(line);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(Label(title, 13))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(Label(title, 13));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(value);`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label("", 14)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Label("", 14)`
- `NationalSpire.MarketTerminal.Label(string, int, Godot.Color?)`；输入表达式：`Label(title, 13)`；返回值紧邻使用处：`ArgumentSyntax: Label(title, 13)`

**赋值（含属性/字段和局部值）：**

- `value.HorizontalAlignment` = `HorizontalAlignment.Right`

<a id="symbol-09b1a1ea6de7"></a>

## `NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>) — internal void Bind(CareerData d, Action<MarketOrder> submit, Action<string> person)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`](MarketScreen.cs.md#symbol-333b046d27f4)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.MarketDynamics.Links(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-ed217f617f49)；[`NationalSpire.MarketDynamics.Partners(NationalSpire.CareerData, NationalSpire.MarketDynamics.SponsorLink[]?)`](MarketDynamics.cs.md#symbol-01f5459a2989)；[`NationalSpire.MarketTerminal.Prepare(double)`](MarketTerminal.cs.md#symbol-64aae4a775dc)；[`NationalSpire.MarketTerminal.RefreshAccount(bool)`](MarketTerminal.cs.md#symbol-9559baf40113)；[`NationalSpire.MarketTerminal.RefreshList()`](MarketTerminal.cs.md#symbol-38f64566d7c6)；`Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；`Godot.ConfigFile.HasSectionKey(string, string)`；`Godot.ConfigFile.Load(string)`；`Godot.Variant.AsStringArray()`；`object.ReferenceEquals(object?, object?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketAsset.Sector`；`NationalSpire.MarketCatalog.Assets`；`NationalSpire.MarketDynamics.Links(NationalSpire.CareerData)`；`NationalSpire.MarketDynamics.Partners(NationalSpire.CareerData, NationalSpire.MarketDynamics.SponsorLink[]?)`；`NationalSpire.MarketDynamics.SponsorLink.Brand`；`NationalSpire.MarketDynamics.SponsorLink.Club`；`NationalSpire.MarketDynamics.SponsorLink.Target`；`NationalSpire.MarketInspectionResult.Revision`；`NationalSpire.MarketState.Revision`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._holdPage`；`NationalSpire.MarketTerminal._identity`；`NationalSpire.MarketTerminal._inspection`；`NationalSpire.MarketTerminal._loaded`；`NationalSpire.MarketTerminal._page`；`NationalSpire.MarketTerminal._person`；`NationalSpire.MarketTerminal._portion`；`NationalSpire.MarketTerminal._preferences`；`NationalSpire.MarketTerminal._searchText`；`NationalSpire.MarketTerminal._selected`；`NationalSpire.MarketTerminal._submit`；`NationalSpire.MarketTerminal._tradePage`；`NationalSpire.MarketTerminal._watch`；`NationalSpire.MarketTerminal.Prepare(double)`；`NationalSpire.MarketTerminal.RefreshAccount(bool)`；`NationalSpire.MarketTerminal.RefreshList()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`_preferences.GetValue(identity, "watch")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _preferences.GetValue(identity, "watch").AsStringArray`
- `Godot.ConfigFile.HasSectionKey(string, string)`；输入表达式：`_preferences.HasSectionKey(identity, "watch")`；返回值紧邻使用处：`IfStatementSyntax: if (_preferences.HasSectionKey(identity, "watch")) foreach (string id in _preferences.GetValue(identity, "watch").AsStringArray()) _watch.Add(id);`
- `Godot.ConfigFile.Load(string)`；输入表达式：`_preferences.Load("user://NationalSpire_market.cfg")`；返回值紧邻使用处：`ExpressionStatementSyntax: _preferences.Load("user://NationalSpire_market.cfg");`
- `Godot.Variant.AsStringArray()`；输入表达式：`_preferences.GetValue(identity, "watch").AsStringArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in _preferences.GetValue(identity, "watch").AsStringArray()) _watch.Add(id);`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == "player" ? CareerEngine.Name(d) : id`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, l.Target)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: l => EsportsWorld.ClubName(d, l.Target)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, p.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.PublicName + " " + EsportsWorld.ClubName(d, p.ClubId)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.WorldId + ":" + GroupChats.Human(d)`
- `NationalSpire.MarketDynamics.Links(NationalSpire.CareerData)`；输入表达式：`MarketDynamics.Links(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketDynamics.Links(d)`
- `NationalSpire.MarketDynamics.Partners(NationalSpire.CareerData, NationalSpire.MarketDynamics.SponsorLink[]?)`；输入表达式：`MarketDynamics.Partners(d, links)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketDynamics.Partners(d, links)`
- `NationalSpire.MarketTerminal.Prepare(double)`；输入表达式：`Prepare(double.PositiveInfinity)`；返回值紧邻使用处：`ExpressionStatementSyntax: Prepare(double.PositiveInfinity);`
- `NationalSpire.MarketTerminal.RefreshAccount(bool)`；输入表达式：`RefreshAccount()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshAccount();`
- `NationalSpire.MarketTerminal.RefreshList()`；输入表达式：`RefreshList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshList();`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(_data, d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(_data, d)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" ", (partners.GetValueOrDefault(asset.Name) ?? []).Select(id => people.TryGetValue(id, out var p) ? p.PublicName + " " + EsportsWorld.ClubName(d, p.ClubId) : id == "player" ? CareerEngine.Name(d) : id))`；返回值紧邻使用处：`BinaryExpressionSyntax: asset.Name + " " + asset.Country + " " + asset.Sector + " " + clubs.GetValueOrDefault(asset.Name) + " " + string.Join(" ", (partners.GetValueOrDefault(asset.Name) ?? []).Select(id => people.TryGetValue(id, out var p) ? p.PublicName + " " + EsportsWorld.ClubName(d, p.ClubId) : id == "player" ? CareerEngine.Name(d) : id))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" ", g.Select(l => EsportsWorld.ClubName(d, l.Target)).Distinct())`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => string.Join(" ", g.Select(l => EsportsWorld.ClubName(d, l.Target)).Distinct())`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_searchText.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _searchText.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`people.TryGetValue(id, out var p)`；返回值紧邻使用处：`ConditionalExpressionSyntax: people.TryGetValue(id, out var p) ? p.PublicName + " " + EsportsWorld.ClubName(d, p.ClubId) : id == "player" ? CareerEngine.Name(d) : id`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_watch.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _watch.Add(id);`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_watch.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _watch.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`g.Select(l => EsportsWorld.ClubName(d, l.Target)).Distinct()`；返回值紧邻使用处：`ArgumentSyntax: g.Select(l => EsportsWorld.ClubName(d, l.Target)).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`links.Where(l => l.Club).GroupBy(l => l.Brand)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: links.Where(l => l.Club).GroupBy(l => l.Brand).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`(partners.GetValueOrDefault(asset.Name) ?? []).Select(id => people.TryGetValue(id, out var p) ? p.PublicName + " " + EsportsWorld.ClubName(d, p.ClubId) : id == "player" ? CareerEngine.Name(d) : id)`；返回值紧邻使用处：`ArgumentSyntax: (partners.GetValueOrDefault(asset.Name) ?? []).Select(id => people.TryGetValue(id, out var p) ? p.PublicName + " " + EsportsWorld.ClubName(d, p.ClubId) : id == "player" ? CareerEngine.Name(d) : id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Select(l => EsportsWorld.ClubName(d, l.Target))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Select(l => EsportsWorld.ClubName(d, l.Target)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`links.Where(l => l.Club).GroupBy(l => l.Brand).ToDictionary(g => g.Key,              g => string.Join(" ", g.Select(l => EsportsWorld.ClubName(d, l.Target)).Distinct()))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = links.Where(l => l.Club).GroupBy(l => l.Brand).ToDictionary(g => g.Key,              g => string.Join(" ", g.Select(l => EsportsWorld.ClubName(d, l.Target)).Distinct()))`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.ToDictionary(p => p.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.ToDictionary(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`links.Where(l => l.Club)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: links.Where(l => l.Club).GroupBy`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`clubs.GetValueOrDefault(asset.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: asset.Name + " " + asset.Country + " " + asset.Sector + " " + clubs.GetValueOrDefault(asset.Name)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`partners.GetValueOrDefault(asset.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: partners.GetValueOrDefault(asset.Name) ?? []`

**赋值（含属性/字段和局部值）：**

- `_data` = `d`
- `_holdPage` = `_tradePage = 0`
- `_identity` = `identity`
- `_inspection` = `null`
- `_loaded` = `true`
- `_page` = `_holdPage = _tradePage = 0`
- `_person` = `person`
- `_portion` = `0`
- `_searchText[asset.Id]` = `asset.Name + " " + asset.Country + " " + asset.Sector + " " + clubs.GetValueOrDefault(asset.Name) + " " + string.Join(" ", (partners.GetValueOrDefault(asset.Name) ?? []).Select(id => people.TryGetValue(id, out var p) ? p.PublicName + " " + EsportsWorld.ClubName(d, p.ClubId) : id == "player" ? CareerEngine.Name(d) : id))`
- `_selected` = `""`
- `_submit` = `submit`
- `_tradePage` = `0`

<a id="symbol-76844d4631c4"></a>

## `NationalSpire.MarketTerminal.Unbind() — internal void Unbind()`

来源：源码第 221 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerListCache.Release()`](CareerListCache.cs.md#symbol-395e4ab9a213)

**调用：** [`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`](MarketVisuals.cs.md#symbol-fd36a7e27494)；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._holdings`；`NationalSpire.MarketTerminal._inspection`；`NationalSpire.MarketTerminal._inspectionGeneration`；`NationalSpire.MarketTerminal._person`；`NationalSpire.MarketTerminal._searchText`；`NationalSpire.MarketTerminal._selectedEvents`；`NationalSpire.MarketTerminal._submit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`；输入表达式：`.Bind(null, null)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: card?.Bind(null, null)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_searchText.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _searchText.Clear();`

**赋值（含属性/字段和局部值）：**

- `_data` = `null`
- `_inspection` = `null`
- `_person` = `null`
- `_selectedEvents` = `[]`
- `_submit` = `null`

<a id="symbol-d43e3b0284a7"></a>

## `NationalSpire.MarketTerminal.ResetList() — private void ResetList()`

来源：源码第 223 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`NationalSpire.MarketTerminal.RefreshList()`](MarketTerminal.cs.md#symbol-38f64566d7c6)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketTerminal._assetScroll`；`NationalSpire.MarketTerminal._page`；`NationalSpire.MarketTerminal.RefreshList()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketTerminal.RefreshList()`；输入表达式：`RefreshList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshList();`

**赋值（含属性/字段和局部值）：**

- `_assetScroll.ScrollVertical` = `0`
- `_page` = `0`

<a id="symbol-83787d38907b"></a>

## `NationalSpire.MarketTerminal.ChangePage(int) — private void ChangePage(int direction)`

来源：源码第 224 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`NationalSpire.MarketTerminal.RefreshList()`](MarketTerminal.cs.md#symbol-38f64566d7c6)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketTerminal._assetScroll`；`NationalSpire.MarketTerminal._page`；`NationalSpire.MarketTerminal._pageCount`；`NationalSpire.MarketTerminal.RefreshList()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketTerminal.RefreshList()`；输入表达式：`RefreshList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshList();`

**赋值（含属性/字段和局部值）：**

- `_assetScroll.ScrollVertical` = `0`
- `_page` = `(_page + direction + _pageCount) % _pageCount`

<a id="symbol-045b28b90c31"></a>

## `NationalSpire.MarketTerminal.SortValue(NationalSpire.MarketAsset) — private double SortValue(MarketAsset asset)`

来源：源码第 225 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`](MarketDynamics.cs.md#symbol-9fa2a14727ca)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.CareerData.WorldId`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`；`NationalSpire.MarketPoint.Price`；`NationalSpire.MarketQuote.History`；`NationalSpire.MarketQuote.Previous`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._sort`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`；输入表达式：`MarketDynamics.Volatility(_data.WorldId, asset)`；返回值紧邻使用处：`ReturnStatementSyntax: return MarketDynamics.Volatility(_data.WorldId, asset);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, q.History.Count - (_sort == 1 ? 8 : 31))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, q.History.Count - (_sort == 1 ? 8 : 31))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-38f64566d7c6"></a>

## `NationalSpire.MarketTerminal.RefreshList() — private void RefreshList()`

来源：源码第 232 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`](MarketTerminal.cs.md#symbol-09b1a1ea6de7)；[`NationalSpire.MarketTerminal.ChangePage(int)`](MarketTerminal.cs.md#symbol-83787d38907b)；[`NationalSpire.MarketTerminal.ResetList()`](MarketTerminal.cs.md#symbol-d43e3b0284a7)；[`NationalSpire.MarketTerminal.ToggleWatch()`](MarketTerminal.cs.md#symbol-0579dd458274)

**调用：** [`NationalSpire.MarketAssetButton.Bind(NationalSpire.MarketAsset, NationalSpire.MarketQuote, bool, bool)`](MarketVisuals.cs.md#symbol-4e16b3f4bac4)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)；`string.Contains(string, System.StringComparison)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Sector`；`NationalSpire.MarketAssetButton.Bind(NationalSpire.MarketAsset, NationalSpire.MarketQuote, bool, bool)`；`NationalSpire.MarketCatalog.Assets`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketTerminal._assetCount`；`NationalSpire.MarketTerminal._country`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._forex`；`NationalSpire.MarketTerminal._page`；`NationalSpire.MarketTerminal._pageCount`；`NationalSpire.MarketTerminal._query`；`NationalSpire.MarketTerminal._rows`；`NationalSpire.MarketTerminal._searchText`；`NationalSpire.MarketTerminal._sector`；`NationalSpire.MarketTerminal._selected`；`NationalSpire.MarketTerminal._visible`；`NationalSpire.MarketTerminal._watch`；`NationalSpire.MarketTerminal._watchOnly`；`NationalSpire.MarketTerminal.RefreshSelection()`；`NationalSpire.MarketTerminal.SortValue(NationalSpire.MarketAsset)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketAssetButton.Bind(NationalSpire.MarketAsset, NationalSpire.MarketQuote, bool, bool)`；输入表达式：`_rows[i].Bind(asset, _data.Market.Quotes[asset.Id], _watch.Contains(asset.Id), asset.Id == _selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: _rows[i].Bind(asset, _data.Market.Quotes[asset.Id], _watch.Contains(asset.Id), asset.Id == _selected);`
- `NationalSpire.MarketTerminal.RefreshSelection()`；输入表达式：`RefreshSelection()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshSelection();`
- `string.Contains(string, System.StringComparison)`；输入表达式：`_searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_watch.Contains(a.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !_watchOnly || _watch.Contains(a.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_watch.Contains(a.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => _watch.Contains(a.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_watch.Contains(asset.Id)`；返回值紧邻使用处：`ArgumentSyntax: _watch.Contains(asset.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`assets.Any(a => a.Id == _selected)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !assets.Any(a => a.Id == _selected)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`assets.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: assets.FirstOrDefault()?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))              .OrderByDescending(a => _watch.Contains(a.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))              .OrderByDescending(a => _watch.Contains(a.Id)).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`assets.Skip(_page * _rows.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: assets.Skip(_page * _rows.Length).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`assets.Skip(_page * _rows.Length).Take(_rows.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: assets.Skip(_page * _rows.Length).Take(_rows.Length).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`assets.Skip(_page * _rows.Length).Take(_rows.Length).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _visible = assets.Skip(_page * _rows.Length).Take(_rows.Length).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))              .OrderByDescending(a => _watch.Contains(a.Id)).ThenByDescending(SortValue).ThenBy(a => a.Id, StringComparer.Ordinal).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))              .OrderByDescending(a => _watch.Contains(a.Id)).ThenByDescending(SortValue).ThenBy(a => a.Id, StringComparer.Ordinal).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))              .OrderByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))              .OrderByDescending(a => _watch.Contains(a.Id)).ThenByDescending(SortValue).ThenBy(a => a.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))              .OrderByDescending(a => _watch.Contains(a.Id)).ThenByDescending(SortValue).ThenBy(a => a.Id, StringComparer.Ordinal).ToArray`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))              .OrderByDescending(a => _watch.Contains(a.Id)).ThenByDescending(SortValue)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)              && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))              .OrderByDescending(a => _watch.Contains(a.Id)).ThenByDescending(SortValue).ThenBy`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, (assets.Length + _rows.Length - 1) / _rows.Length)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pageCount = Math.Max(1, (assets.Length + _rows.Length - 1) / _rows.Length)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_page, _pageCount - 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _page = Math.Min(_page, _pageCount - 1)`

**赋值（含属性/字段和局部值）：**

- `_assetCount.Text` = `$"{assets.Length} 项 · {_page + 1} / {_pageCount}"`
- `_page` = `Math.Min(_page, _pageCount - 1)`
- `_pageCount` = `Math.Max(1, (assets.Length + _rows.Length - 1) / _rows.Length)`
- `_rows[i].Visible` = `i < _visible.Length`
- `_selected` = `assets.FirstOrDefault()?.Id ?? ""`
- `_visible` = `assets.Skip(_page * _rows.Length).Take(_rows.Length).ToArray()`

<a id="symbol-3c5b757d5a8f"></a>

## `NationalSpire.MarketTerminal.SelectRow(int) — private void SelectRow(int row)`

来源：源码第 251 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Id`；`NationalSpire.MarketTerminal._selected`；`NationalSpire.MarketTerminal._visible`；`NationalSpire.MarketTerminal.RefreshSelection()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketTerminal.RefreshSelection()`；输入表达式：`RefreshSelection()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshSelection();`

**赋值（含属性/字段和局部值）：**

- `_selected` = `_visible[row].Id`

<a id="symbol-c8cd06b76400"></a>

## `NationalSpire.MarketTerminal.RefreshSelection() — private void RefreshSelection()`

来源：源码第 252 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshList()`](MarketTerminal.cs.md#symbol-38f64566d7c6)；[`NationalSpire.MarketTerminal.SelectRow(int)`](MarketTerminal.cs.md#symbol-3c5b757d5a8f)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketChart.Set(NationalSpire.MarketPoint[], string, decimal)`](MarketTerminal.cs.md#symbol-22dfa2e243b9)；[`NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`](MarketDynamics.cs.md#symbol-9fa2a14727ca)；[`NationalSpire.MarketEventRow.Bind(NationalSpire.MarketEvent, string)`](MarketVisuals.cs.md#symbol-30fd495127a5)；[`NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`](MarketExecution.cs.md#symbol-c74291f4d6c7)；[`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)；[`NationalSpire.MarketTerminal.EventTitle(NationalSpire.MarketEvent, NationalSpire.MarketAsset)`](MarketTerminal.cs.md#symbol-17a172f5c790)；[`NationalSpire.MarketTerminal.RefreshChart()`](MarketTerminal.cs.md#symbol-e1b73bf4bb8f)；[`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)；[`NationalSpire.MarketVisuals.Accent(string)`](MarketVisuals.cs.md#symbol-7251a1de5493)；[`NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`](MarketVisuals.cs.md#symbol-7d1876899194)；[`NationalSpire.RegionalOrganizations.SponsorDescription(string)`](RegionalOrganizations.cs.md#symbol-421e3c666278)；`decimal.ToString(string?)`；`double.ToString(string?)`；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Node.GetChild(int, bool)`；`Godot.Node.GetNode<T>(Godot.NodePath)`；`Godot.Node.GetParent()`；`string.Replace(string, string?)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `(NationalSpire.MarketEvent Event, string Title).Event`；`(NationalSpire.MarketEvent Event, string Title).Title`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketAsset.Sector`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketChart.Set(NationalSpire.MarketPoint[], string, decimal)`；`NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`；`NationalSpire.MarketEvent.Asset`；`NationalSpire.MarketEventRow.Bind(NationalSpire.MarketEvent, string)`；`NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`；`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketQuote.ClearingDepthUnits`；`NationalSpire.MarketQuote.Previous`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Events`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketTerminal._buyPrice`；`NationalSpire.MarketTerminal._chart`；`NationalSpire.MarketTerminal._cost`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._depth`；`NationalSpire.MarketTerminal._description`；`NationalSpire.MarketTerminal._events`；`NationalSpire.MarketTerminal._fee`；`NationalSpire.MarketTerminal._name`；`NationalSpire.MarketTerminal._newsTitle`；`NationalSpire.MarketTerminal._notional`；`NationalSpire.MarketTerminal._overview`；`NationalSpire.MarketTerminal._pin`；`NationalSpire.MarketTerminal._quote`；`NationalSpire.MarketTerminal._right`；`NationalSpire.MarketTerminal._rows`；`NationalSpire.MarketTerminal._selected`；`NationalSpire.MarketTerminal._selectedEvents`；`NationalSpire.MarketTerminal._sellPrice`；`NationalSpire.MarketTerminal._sources`；`NationalSpire.MarketTerminal._visible`；`NationalSpire.MarketTerminal._volatility`；`NationalSpire.MarketTerminal._volatilityBar`；`NationalSpire.MarketTerminal._watch`；`NationalSpire.MarketTerminal.EventTitle(NationalSpire.MarketEvent, NationalSpire.MarketAsset)`；`NationalSpire.MarketTerminal.RefreshChart()`；`NationalSpire.MarketTerminal.RefreshFee()`；`NationalSpire.MarketVisuals.Accent(string)`；`NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`；`NationalSpire.RegionalOrganizations.SponsorDescription(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`(depth / 1_000_000_000_000m).ToString("0.##")`；返回值紧邻使用处：`BinaryExpressionSyntax: (depth / 1_000_000_000_000m).ToString("0.##") + " 万亿美元"`
- `decimal.ToString(string?)`；输入表达式：`(depth / 100_000_000m).ToString("0.##")`；返回值紧邻使用处：`BinaryExpressionSyntax: (depth / 100_000_000m).ToString("0.##") + " 亿美元"`
- `decimal.ToString(string?)`；输入表达式：`quote.Price.ToString("0.00000")`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n1 人民币 = " + quote.Price.ToString("0.00000")`
- `decimal.ToString(string?)`；输入表达式：`quote.Price.ToString("0.00000")`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? quote.Price.ToString("0.00000") : CareerMoney.Format(quote.Price)`
- `double.ToString(string?)`；输入表达式：`volatility.ToString("0.00%")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _volatility.Text = volatility.ToString("0.00%")`
- `Godot.CanvasItem.Hide()`；输入表达式：`_newsTitle.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _newsTitle.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_overview.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _overview.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`item.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`_overview.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _overview.Show();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_name.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector))`；返回值紧邻使用处：`ExpressionStatementSyntax: _name.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_sources[i].AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector))`；返回值紧邻使用处：`ExpressionStatementSyntax: _sources[i].AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector));`
- `Godot.Node.GetChild(int, bool)`；输入表达式：`_sources[0].GetParent().GetChild(0)`；返回值紧邻使用处：`CastExpressionSyntax: (TextureRect)_sources[0].GetParent().GetChild(0)`
- `Godot.Node.GetNode<T>(Godot.NodePath)`；输入表达式：`_right.GetNode<Control>("Short")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _right.GetNode<Control>("Short").Visible`
- `Godot.Node.GetParent()`；输入表达式：`_sources[0].GetParent()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _sources[0].GetParent().GetChild`
- `Godot.Node.GetParent()`；输入表达式：`_sources[i].GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (Control)_sources[i].GetParent()`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(quote.Price)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? quote.Price.ToString("0.00000") : CareerMoney.Format(quote.Price)`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(asset.Forex ? "外汇" : asset.Sector)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ((TextureRect)_sources[0].GetParent().GetChild(0)).Texture = LifestyleArt.Icon(asset.Forex ? "外汇" : asset.Sector)`
- `NationalSpire.MarketChart.Set(NationalSpire.MarketPoint[], string, decimal)`；输入表达式：`_chart.Set([], "")`；返回值紧邻使用处：`ExpressionStatementSyntax: _chart.Set([], "");`
- `NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`；输入表达式：`MarketDynamics.Volatility(_data.WorldId, asset)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketDynamics.Volatility(_data.WorldId, asset)`
- `NationalSpire.MarketEventRow.Bind(NationalSpire.MarketEvent, string)`；输入表达式：`_events[i].Bind(news[i].Event, news[i].Title)`；返回值紧邻使用处：`ExpressionStatementSyntax: _events[i].Bind(news[i].Event, news[i].Title);`
- `NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`；输入表达式：`MarketExecution.Depth(asset)`；返回值紧邻使用处：`ConditionalExpressionSyntax: depthQuote.ClearingDepthUnits > 0 ? depthQuote.ClearingDepthUnits * MarketExecution.ReferencePrice(depthQuote) : MarketExecution.Depth(asset)`
- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(depthQuote)`；返回值紧邻使用处：`BinaryExpressionSyntax: depthQuote.ClearingDepthUnits * MarketExecution.ReferencePrice(depthQuote)`
- `NationalSpire.MarketTerminal.EventTitle(NationalSpire.MarketEvent, NationalSpire.MarketAsset)`；输入表达式：`EventTitle(e, asset)`；返回值紧邻使用处：`ArgumentSyntax: Title: EventTitle(e, asset)`
- `NationalSpire.MarketTerminal.RefreshChart()`；输入表达式：`RefreshChart()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshChart();`
- `NationalSpire.MarketTerminal.RefreshFee()`；输入表达式：`RefreshFee()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshFee();`
- `NationalSpire.MarketVisuals.Accent(string)`；输入表达式：`MarketVisuals.Accent(asset.Sector)`；返回值紧邻使用处：`ArgumentSyntax: MarketVisuals.Accent(asset.Sector)`
- `NationalSpire.MarketVisuals.Style(Godot.Button, string, bool)`；输入表达式：`MarketVisuals.Style(_rows[i], _visible[i].Sector, _visible[i].Id == _selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketVisuals.Style(_rows[i], _visible[i].Sector, _visible[i].Id == _selected);`
- `NationalSpire.RegionalOrganizations.SponsorDescription(string)`；输入表达式：`RegionalOrganizations.SponsorDescription(asset.Name)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? "" : RegionalOrganizations.SponsorDescription(asset.Name)`
- `string.Replace(string, string?)`；输入表达式：`asset.Name.Replace("人民币 / ", "")`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n1 人民币 = " + quote.Price.ToString("0.00000") + " " + asset.Name.Replace("人民币 / ", "")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_watch.Contains(_selected)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _watch.Contains(_selected) ? "★" : "☆"`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`_data.Market.Events.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _data.Market.Events.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`_data.Market.Events.AsEnumerable().Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _data.Market.Events.AsEnumerable().Reverse().Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)              .Select(e => (Event: e, Title: EventTitle(e, asset)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)              .Select(e => (Event: e, Title: EventTitle(e, asset))).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`news.Select(e => e.Event)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: news.Select(e => e.Event).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`_data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)              .Select(e => (Event: e, Title: EventTitle(e, asset))).Where(e => e.Title.Length > 0).Take(_events.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)              .Select(e => (Event: e, Title: EventTitle(e, asset))).Where(e => e.Title.Length > 0).Take(_events.Length).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)              .Select(e => (Event: e, Title: EventTitle(e, asset))).Where(e => e.Title.Length > 0).Take(_events.Length).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)              .Select(e => (Event: e, Title: EventTitle(e, asset))).Where(e => e.Title.Length > 0).Take(_events.Length).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`news.Select(e => e.Event).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _selectedEvents = news.Select(e => e.Event).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)              .Select(e => (Event: e, Title: EventTitle(e, asset))).Where(e => e.Title.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)              .Select(e => (Event: e, Title: EventTitle(e, asset))).Where(e => e.Title.Length > 0).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)              .Select`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`MarketCatalog.ById.TryGetValue(_selected, out var asset)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !MarketCatalog.ById.TryGetValue(_selected, out var asset)`

**赋值（含属性/字段和局部值）：**

- `_buyPrice.Text` = `_sellPrice.Text = ""`
- `_cost.Text` = `_notional.Text = _buyPrice.Text = _sellPrice.Text = ""`
- `_depth.Text` = `depth >= 1_000_000_000_000m ? (depth / 1_000_000_000_000m).ToString("0.##") + " 万亿美元" : (depth / 100_000_000m).ToString("0.##") + " 亿美元"`
- `_description.Text` = `_fee.Text = _cost.Text = _notional.Text = _buyPrice.Text = _sellPrice.Text = ""`
- `_description.Text` = `asset.Country + " · " + asset.Sector + (asset.Forex ? "\n1 人民币 = " + quote.Price.ToString("0.00000") + " " + asset.Name.Replace("人民币 / ", "") : "")`
- `_events[i].Visible` = `i < news.Length`
- `_fee.Text` = `_cost.Text = _notional.Text = _buyPrice.Text = _sellPrice.Text = ""`
- `_name.Text` = `"没有符合条件的资产"`
- `_name.Text` = `asset.Name`
- `_name.TooltipText` = `""`
- `_name.TooltipText` = `asset.Forex ? "" : RegionalOrganizations.SponsorDescription(asset.Name)`
- `_newsTitle.Visible` = `news.Length > 0`
- `_notional.Text` = `_buyPrice.Text = _sellPrice.Text = ""`
- `_pin.Text` = `_watch.Contains(_selected) ? "★" : "☆"`
- `_quote.Text` = `_description.Text = _fee.Text = _cost.Text = _notional.Text = _buyPrice.Text = _sellPrice.Text = ""`
- `_quote.Text` = `(asset.Forex ? quote.Price.ToString("0.00000") : CareerMoney.Format(quote.Price)) + $"   {quote.Price / quote.Previous - 1:+0.00%;-0.00%;0.00%}"`
- `_right.GetNode<Control>("Short").Visible` = `true`
- `_selectedEvents` = `[]`
- `_selectedEvents` = `news.Select(e => e.Event).ToArray()`
- `_sellPrice.Text` = `""`
- `_sources[i].Text` = `sources[i]`
- `_volatility.Text` = `volatility.ToString("0.00%")`
- `_volatilityBar.Value` = `volatility`
- `((TextureRect)_sources[0].GetParent().GetChild(0)).Texture` = `LifestyleArt.Icon(asset.Forex ? "外汇" : asset.Sector)`
- `source.Visible` = `i < sources.Length`

<a id="symbol-e1b73bf4bb8f"></a>

## `NationalSpire.MarketTerminal.RefreshChart() — private void RefreshChart()`

来源：源码第 287 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)

**调用：** [`NationalSpire.MarketChart.Set(NationalSpire.MarketPoint[], string, decimal)`](MarketTerminal.cs.md#symbol-22dfa2e243b9)；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.CareerData.WorldId`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketChart.Set(NationalSpire.MarketPoint[], string, decimal)`；`NationalSpire.MarketQuote.History`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketTerminal._chart`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._range`；`NationalSpire.MarketTerminal._selected`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketChart.Set(NationalSpire.MarketPoint[], string, decimal)`；输入表达式：`_chart.Set(_data.Market.Quotes[_selected].History.TakeLast(_range).ToArray(), _data.WorldId + asset.Id, asset.Forex ? 1 : 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chart.Set(_data.Market.Quotes[_selected].History.TakeLast(_range).ToArray(), _data.WorldId + asset.Id, asset.Forex ? 1 : 10);`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`_data.Market.Quotes[_selected].History.TakeLast(_range)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _data.Market.Quotes[_selected].History.TakeLast(_range).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_data.Market.Quotes[_selected].History.TakeLast(_range).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: _data.Market.Quotes[_selected].History.TakeLast(_range).ToArray()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`MarketCatalog.ById.TryGetValue(_selected, out var asset)`；返回值紧邻使用处：`BinaryExpressionSyntax: _data != null && MarketCatalog.ById.TryGetValue(_selected, out var asset)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-17a172f5c790"></a>

## `NationalSpire.MarketTerminal.EventTitle(NationalSpire.MarketEvent, NationalSpire.MarketAsset) — private string EventTitle(MarketEvent item, MarketAsset asset)`

来源：源码第 292 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)

**调用：** `string.Contains(string)`；`string.IndexOf(string, System.StringComparison)`；`string.StartsWith(string, System.StringComparison)`；`string.TrimStart(params char[]?)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketEvent.Competition`；`NationalSpire.MarketEvent.Text`；`NationalSpire.MarketTerminal._data`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Contains(string)`；输入表达式：`item.Text.Contains("次日")`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Text.Contains("下一日") || item.Text.Contains("次日")`
- `string.Contains(string)`；输入表达式：`item.Text.Contains("待计入")`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Text.Contains("下一日") || item.Text.Contains("次日") || item.Text.Contains("待计入")`
- `string.Contains(string)`；输入表达式：`item.Text.Contains("下一日")`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Text.Contains("下一日") || item.Text.Contains("次日")`
- `string.Contains(string)`；输入表达式：`item.Text.Contains("已计入")`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Text.Contains("已写入") || item.Text.Contains("已计入")`
- `string.Contains(string)`；输入表达式：`item.Text.Contains("已写入")`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Text.Contains("已写入") || item.Text.Contains("已计入")`
- `string.IndexOf(string, System.StringComparison)`；输入表达式：`item.Text.IndexOf("赛果", StringComparison.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = item.Text.IndexOf("赛果", StringComparison.Ordinal)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`item.Text.StartsWith(asset.Name, StringComparison.Ordinal)`；返回值紧邻使用处：`ConditionalExpressionSyntax: item.Text.StartsWith(asset.Name, StringComparison.Ordinal) ? item.Text[asset.Name.Length..].TrimStart(' ', '·', '：') : item.Text`
- `string.TrimStart(params char[]?)`；输入表达式：`item.Text[asset.Name.Length..].TrimStart(' ', '·', '：')`；返回值紧邻使用处：`ConditionalExpressionSyntax: item.Text.StartsWith(asset.Name, StringComparison.Ordinal) ? item.Text[asset.Name.Length..].TrimStart(' ', '·', '：') : item.Text`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_data!.Esports.Competitions.FirstOrDefault(c => c.Id == item.Competition)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _data!.Esports.Competitions.FirstOrDefault(c => c.Id == item.Competition)?.Name`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(end, 64)`；返回值紧邻使用处：`RangeExpressionSyntax: ..Math.Min(end, 64)`

**赋值（含属性/字段和局部值）：**

- `name` = `end > 0 ? item.Text[..Math.Min(end, 64)] : "赛事表现"`

<a id="symbol-306487121584"></a>

## `NationalSpire.MarketTerminal.OrderMargin(NationalSpire.MarketAsset, int) — private decimal OrderMargin(MarketAsset asset, int leverage)`

来源：源码第 306 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Open(int)`](MarketTerminal.cs.md#symbol-9665309ab157)；[`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)；[`NationalSpire.MarketTerminal.RequestInspection()`](MarketTerminal.cs.md#symbol-332ba74db6e5)

**调用：** [`NationalSpire.CareerMarket.BudgetMargin(NationalSpire.MarketAsset, decimal, int, int)`](CareerMarket.cs.md#symbol-f2a928a00b17)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerMarket.BudgetMargin(NationalSpire.MarketAsset, decimal, int, int)`；`NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketAmountInput.Amount`；`NationalSpire.MarketTerminal._amount`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._portion`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.BudgetMargin(NationalSpire.MarketAsset, decimal, int, int)`；输入表达式：`CareerMarket.BudgetMargin(asset, _data!.Life.Trading.Cash, leverage, _portion)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _portion > 0          ? CareerMarket.BudgetMargin(asset, _data!.Life.Trading.Cash, leverage, _portion) : _amount.Amount / 10`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1c08f523080f"></a>

## `NationalSpire.MarketTerminal.RefreshFee() — private void RefreshFee()`

来源：源码第 308 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)；[`NationalSpire.MarketTerminal.SetOrderMargin(decimal)`](MarketTerminal.cs.md#symbol-5c2e4be798a5)

**调用：** [`NationalSpire.CareerMarket.BudgetMargin(NationalSpire.MarketAsset, decimal, int, int)`](CareerMarket.cs.md#symbol-f2a928a00b17)；[`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`](CareerMarket.cs.md#symbol-8f53c28594f3)；[`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-9439f9696cab)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.MarketAmountInput.SetAmount(decimal)`](MarketAmountInput.cs.md#symbol-b73158988cf2)；[`NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`](MarketClearing.cs.md#symbol-e90e0ab892c9)；[`NationalSpire.MarketTerminal.OrderMargin(NationalSpire.MarketAsset, int)`](MarketTerminal.cs.md#symbol-306487121584)；[`NationalSpire.MarketTerminal.RequestInspection()`](MarketTerminal.cs.md#symbol-332ba74db6e5)；[`Quote(decimal)`](MarketTerminal.cs.md#symbol-21e2888e28ce)；`NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.InspectMarket`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerMarket.BudgetMargin(NationalSpire.MarketAsset, decimal, int, int)`；`NationalSpire.CareerMarket.Leverages`；`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketAmountInput.SetAmount(decimal)`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`；`NationalSpire.MarketClearing.Result.Average`；`NationalSpire.MarketTerminal._amount`；`NationalSpire.MarketTerminal._buyPrice`；`NationalSpire.MarketTerminal._cost`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._fee`；`NationalSpire.MarketTerminal._leverage`；`NationalSpire.MarketTerminal._notional`；`NationalSpire.MarketTerminal._portion`；`NationalSpire.MarketTerminal._selected`；`NationalSpire.MarketTerminal._sellPrice`；`NationalSpire.MarketTerminal._settingAmount`；`NationalSpire.MarketTerminal.OrderMargin(NationalSpire.MarketAsset, int)`；`NationalSpire.MarketTerminal.RequestInspection()`；`Quote(decimal)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.BudgetMargin(NationalSpire.MarketAsset, decimal, int, int)`；输入表达式：`CareerMarket.BudgetMargin(asset, _data.Life.Trading.Cash, leverage, _portion)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMarket.BudgetMargin(asset, _data.Life.Trading.Cash, leverage, _portion) * 10`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`CareerMarket.OpenFee(asset, margin, leverage)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerMarket.OpenFee(asset, margin, leverage)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(fee)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _fee.Text = CareerMoney.Compact(fee)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(margin * leverage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _notional.Text = CareerMoney.Compact(margin * leverage)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(margin + fee)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _cost.Text = CareerMoney.Compact(margin + fee)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(fee)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _fee.TooltipText = CareerMoney.Format(fee)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(margin * leverage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _notional.TooltipText = CareerMoney.Format(margin * leverage)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(margin + fee)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _cost.TooltipText = CareerMoney.Format(margin + fee)`
- `NationalSpire.MarketAmountInput.SetAmount(decimal)`；输入表达式：`_amount.SetAmount(CareerMarket.BudgetMargin(asset, _data.Life.Trading.Cash, leverage, _portion) * 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: _amount.SetAmount(CareerMarket.BudgetMargin(asset, _data.Life.Trading.Cash, leverage, _portion) * 10);`
- `NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`；输入表达式：`MarketClearing.Preview(_data, new("open", asset.Id, margin, -1, leverage), false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketClearing.Preview(_data, new("open", asset.Id, margin, -1, leverage), false)`
- `NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`；输入表达式：`MarketClearing.Preview(_data, new("open", asset.Id, margin, 1, leverage), false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketClearing.Preview(_data, new("open", asset.Id, margin, 1, leverage), false)`
- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new("open", asset.Id, margin, -1, leverage)`；返回值紧邻使用处：`ArgumentSyntax: new("open", asset.Id, margin, -1, leverage)`
- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new("open", asset.Id, margin, 1, leverage)`；返回值紧邻使用处：`ArgumentSyntax: new("open", asset.Id, margin, 1, leverage)`
- `NationalSpire.MarketTerminal.OrderMargin(NationalSpire.MarketAsset, int)`；输入表达式：`OrderMargin(asset, leverage)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OrderMargin(asset, leverage)`
- `NationalSpire.MarketTerminal.RequestInspection()`；输入表达式：`RequestInspection()`；返回值紧邻使用处：`ExpressionStatementSyntax: RequestInspection();`
- `Quote(decimal)`；输入表达式：`Quote(buy.Average)`；返回值紧邻使用处：`BinaryExpressionSyntax: "预计成交均价  " + Quote(buy.Average)`
- `Quote(decimal)`；输入表达式：`Quote(sell.Average)`；返回值紧邻使用处：`BinaryExpressionSyntax: "预计成交均价  " + Quote(sell.Average)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`MarketCatalog.ById.TryGetValue(_selected, out var asset)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !MarketCatalog.ById.TryGetValue(_selected, out var asset)`

**赋值（含属性/字段和局部值）：**

- `_buyPrice.Text` = `_sellPrice.Text = "正在计算成交均价"`
- `_buyPrice.Text` = `"预计成交均价  " + Quote(buy.Average)`
- `_cost.MouseFilter` = `_notional.MouseFilter = _fee.MouseFilter = MouseFilterEnum.Pass`
- `_cost.Text` = `CareerMoney.Compact(margin + fee)`
- `_cost.TooltipText` = `CareerMoney.Format(margin + fee)`
- `_fee.MouseFilter` = `MouseFilterEnum.Pass`
- `_fee.Text` = `CareerMoney.Compact(fee)`
- `_fee.TooltipText` = `CareerMoney.Format(fee)`
- `_notional.MouseFilter` = `_fee.MouseFilter = MouseFilterEnum.Pass`
- `_notional.Text` = `CareerMoney.Compact(margin * leverage)`
- `_notional.TooltipText` = `CareerMoney.Format(margin * leverage)`
- `_sellPrice.Text` = `"预计成交均价  " + Quote(sell.Average)`
- `_sellPrice.Text` = `"正在计算成交均价"`
- `_settingAmount` = `false`
- `_settingAmount` = `true`

<a id="symbol-21e2888e28ce"></a>

## `Quote(decimal) — string Quote(decimal value)`

来源：源码第 320 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；`decimal.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.MarketAsset.Forex`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`value.ToString("0.00000")`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? value.ToString("0.00000") : CareerMoney.Format(value)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? value.ToString("0.00000") : CareerMoney.Format(value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-332ba74db6e5"></a>

## `NationalSpire.MarketTerminal.RequestInspection() — private async void RequestInspection()`

来源：源码第 332 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshAccount(bool)`](MarketTerminal.cs.md#symbol-9559baf40113)；[`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)；[`NationalSpire.MarketTerminal.RequestInspection()`](MarketTerminal.cs.md#symbol-332ba74db6e5)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.MarketTerminal.OrderMargin(NationalSpire.MarketAsset, int)`](MarketTerminal.cs.md#symbol-306487121584)；[`NationalSpire.MarketTerminal.RefreshAccount(bool)`](MarketTerminal.cs.md#symbol-9559baf40113)；[`NationalSpire.MarketTerminal.RequestInspection()`](MarketTerminal.cs.md#symbol-332ba74db6e5)；[`Quote(decimal)`](MarketTerminal.cs.md#symbol-1cda59f3a28e)；`NationalSpire.MarketInspection.MarketInspection(string, decimal, int, int[], bool)`；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.Threading.Tasks.Task.Delay(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.InspectMarket`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerMarket.Leverages`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketInspectionResult.Buy`；`NationalSpire.MarketInspectionResult.Revision`；`NationalSpire.MarketInspectionResult.Sell`；`NationalSpire.MarketOrderPreview.Average`；`NationalSpire.MarketPosition.Id`；`NationalSpire.MarketState.Revision`；`NationalSpire.MarketTerminal._buyPrice`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._holdPage`；`NationalSpire.MarketTerminal._inspection`；`NationalSpire.MarketTerminal._inspectionBusy`；`NationalSpire.MarketTerminal._inspectionGeneration`；`NationalSpire.MarketTerminal._leverage`；`NationalSpire.MarketTerminal._selected`；`NationalSpire.MarketTerminal._sellPrice`；`NationalSpire.MarketTerminal.OrderMargin(NationalSpire.MarketAsset, int)`；`NationalSpire.MarketTerminal.RefreshAccount(bool)`；`NationalSpire.MarketTerminal.RequestInspection()`；`Quote(decimal)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("market.remote-preview", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("market.remote-preview", error);`
- `NationalSpire.MarketInspection.MarketInspection(string, decimal, int, int[], bool)`；输入表达式：`new MarketInspection(asset.Id, OrderMargin(asset, leverage), leverage, data.Life.Trading.Positions.Skip(_holdPage * 5).Take(5).Select(p => p.Id).ToArray())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarketInspection(asset.Id, OrderMargin(asset, leverage), leverage, data.Life.Trading.Positions.Skip(_holdPage * 5).Take(5).Select(p => p.Id).ToArray())`
- `NationalSpire.MarketTerminal.OrderMargin(NationalSpire.MarketAsset, int)`；输入表达式：`OrderMargin(asset, leverage)`；返回值紧邻使用处：`ArgumentSyntax: OrderMargin(asset, leverage)`
- `NationalSpire.MarketTerminal.RefreshAccount(bool)`；输入表达式：`RefreshAccount(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshAccount(false);`
- `NationalSpire.MarketTerminal.RequestInspection()`；输入表达式：`RequestInspection()`；返回值紧邻使用处：`ExpressionStatementSyntax: RequestInspection();`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(_data, data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(_data, data)`
- `Quote(decimal)`；输入表达式：`Quote(result.Buy.Average)`；返回值紧邻使用处：`BinaryExpressionSyntax: "预计成交均价  " + Quote(result.Buy.Average)`
- `Quote(decimal)`；输入表达式：`Quote(result.Sell.Average)`；返回值紧邻使用处：`BinaryExpressionSyntax: "预计成交均价  " + Quote(result.Sell.Average)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.Life.Trading.Positions.Skip(_holdPage * 5).Take(5).Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Trading.Positions.Skip(_holdPage * 5).Take(5).Select(p => p.Id).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`data.Life.Trading.Positions.Skip(_holdPage * 5)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Trading.Positions.Skip(_holdPage * 5).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`data.Life.Trading.Positions.Skip(_holdPage * 5).Take(5)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Trading.Positions.Skip(_holdPage * 5).Take(5).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`data.Life.Trading.Positions.Skip(_holdPage * 5).Take(5).Select(p => p.Id).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: data.Life.Trading.Positions.Skip(_holdPage * 5).Take(5).Select(p => p.Id).ToArray()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`MarketCatalog.ById.TryGetValue(_selected, out var asset)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !MarketCatalog.ById.TryGetValue(_selected, out var asset)`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`data.InspectMarket(request)`；返回值紧邻使用处：`AwaitExpressionSyntax: await data.InspectMarket(request)`
- `System.Threading.Tasks.Task.Delay(int)`；输入表达式：`Task.Delay(120)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Delay(120)`

**赋值（含属性/字段和局部值）：**

- `_buyPrice.Text` = `_sellPrice.Text = "报价读取失败，点击下单时重新计算"`
- `_buyPrice.Text` = `"预计成交均价  " + Quote(result.Buy.Average)`
- `_inspection` = `result`
- `_inspectionBusy` = `false`
- `_inspectionBusy` = `true`
- `_sellPrice.Text` = `"报价读取失败，点击下单时重新计算"`
- `_sellPrice.Text` = `"预计成交均价  " + Quote(result.Sell.Average)`

<a id="symbol-1cda59f3a28e"></a>

## `Quote(decimal) — string Quote(decimal value)`

来源：源码第 345 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RequestInspection()`](MarketTerminal.cs.md#symbol-332ba74db6e5)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；`decimal.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.MarketAsset.Forex`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`value.ToString("0.00000")`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? value.ToString("0.00000") : CareerMoney.Format(value)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? value.ToString("0.00000") : CareerMoney.Format(value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9559baf40113"></a>

## `NationalSpire.MarketTerminal.RefreshAccount(bool) — private void RefreshAccount(bool requestInspection = true)`

来源：源码第 356 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`](MarketTerminal.cs.md#symbol-09b1a1ea6de7)；[`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)；[`NationalSpire.MarketTerminal.RequestInspection()`](MarketTerminal.cs.md#symbol-332ba74db6e5)

**调用：** [`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-9439f9696cab)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`](MarketClearing.cs.md#symbol-2192e2bdcb1e)；[`NationalSpire.MarketClearing.PreviewClose(NationalSpire.CareerData, NationalSpire.MarketPosition)`](MarketClearing.cs.md#symbol-554374f533fb)；[`NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>?)`](MarketExecution.cs.md#symbol-38a7df5abf7b)；[`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`](MarketVisuals.cs.md#symbol-fd36a7e27494)；[`NationalSpire.MarketTerminal.RequestInspection()`](MarketTerminal.cs.md#symbol-332ba74db6e5)；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.InspectMarket`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketAccount.Debt`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketAccount.Trades`；`NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`；`NationalSpire.MarketClearing.PreviewClose(NationalSpire.CareerData, NationalSpire.MarketPosition)`；`NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>?)`；`NationalSpire.MarketInspectionResult.Exits`；`NationalSpire.MarketInspectionResult.Net`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.Id`；`NationalSpire.MarketPosition.Margin`；`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketState.Revision`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._holdings`；`NationalSpire.MarketTerminal._holdPage`；`NationalSpire.MarketTerminal._inspection`；`NationalSpire.MarketTerminal._metrics`；`NationalSpire.MarketTerminal._tradePage`；`NationalSpire.MarketTerminal._trades`；`NationalSpire.MarketTerminal.RequestInspection()`；`NationalSpire.MarketTrade.Change`；`NationalSpire.MarketTrade.Day`；`NationalSpire.MarketTrade.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(trades[i].Change)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Compact(trades[i].Change)}`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(values[i])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _metrics[i].Text = CareerMoney.Compact(values[i])`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(values[i])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _metrics[i].TooltipText = CareerMoney.Format(values[i])`
- `NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`；输入表达式：`MarketClearing.Accounts(_data)`；返回值紧邻使用处：`ArgumentSyntax: MarketClearing.Accounts(_data)`
- `NationalSpire.MarketClearing.PreviewClose(NationalSpire.CareerData, NationalSpire.MarketPosition)`；输入表达式：`MarketClearing.PreviewClose(_data, p)`；返回值紧邻使用处：`ConditionalExpressionSyntax: remote ? _inspection?.Exits.GetValueOrDefault(p.Id) : MarketClearing.PreviewClose(_data, p)`
- `NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>?)`；输入表达式：`MarketExecution.LiquidationValue(_data.Market, account, MarketClearing.Accounts(_data))`；返回值紧邻使用处：`ConditionalExpressionSyntax: remote ? _inspection?.Net ?? 0 : MarketExecution.LiquidationValue(_data.Market, account, MarketClearing.Accounts(_data))`
- `NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`；输入表达式：`_holdings[i].Bind(p, p == null ? null : _data.Market.Quotes[p.Asset], _data.Market.Revision, exit, remote && exit == null)`；返回值紧邻使用处：`ExpressionStatementSyntax: _holdings[i].Bind(p, p == null ? null : _data.Market.Quotes[p.Asset], _data.Market.Revision, exit, remote && exit == null);`
- `NationalSpire.MarketTerminal.RequestInspection()`；输入表达式：`RequestInspection()`；返回值紧邻使用处：`ExpressionStatementSyntax: RequestInspection();`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`account.Trades.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: account.Trades.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`account.Positions.Skip(_holdPage * 5 + i).FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = account.Positions.Skip(_holdPage * 5 + i).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`account.Trades.AsEnumerable().Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: account.Trades.AsEnumerable().Reverse().Skip`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`account.Positions.Skip(_holdPage * 5 + i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: account.Positions.Skip(_holdPage * 5 + i).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`account.Trades.AsEnumerable().Reverse().Skip(_tradePage * 5)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: account.Trades.AsEnumerable().Reverse().Skip(_tradePage * 5).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`account.Positions.Sum(p => p.Margin)`；返回值紧邻使用处：`ExpressionElementSyntax: account.Positions.Sum(p => p.Margin)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`account.Trades.AsEnumerable().Reverse().Skip(_tradePage * 5).Take(5)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: account.Trades.AsEnumerable().Reverse().Skip(_tradePage * 5).Take(5).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`account.Trades.AsEnumerable().Reverse().Skip(_tradePage * 5).Take(5).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = account.Trades.AsEnumerable().Reverse().Skip(_tradePage * 5).Take(5).ToArray()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Exits.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _inspection?.Exits.GetValueOrDefault(p.Id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, (account.Positions.Count - 1) / 5)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, (account.Positions.Count - 1) / 5)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, (account.Trades.Count - 1) / 5)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, (account.Trades.Count - 1) / 5)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_holdPage, Math.Max(0, (account.Positions.Count - 1) / 5))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _holdPage = Math.Min(_holdPage, Math.Max(0, (account.Positions.Count - 1) / 5))`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_tradePage, Math.Max(0, (account.Trades.Count - 1) / 5))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _tradePage = Math.Min(_tradePage, Math.Max(0, (account.Trades.Count - 1) / 5))`

**赋值（含属性/字段和局部值）：**

- `_holdings[i].Visible` = `p != null || i == 0`
- `_holdPage` = `Math.Min(_holdPage, Math.Max(0, (account.Positions.Count - 1) / 5))`
- `_metrics[0].Text` = `"正在计算"`
- `_metrics[0].TooltipText` = `""`
- `_metrics[i].MouseFilter` = `MouseFilterEnum.Pass`
- `_metrics[i].Text` = `CareerMoney.Compact(values[i])`
- `_metrics[i].TooltipText` = `CareerMoney.Format(values[i])`
- `_tradePage` = `Math.Min(_tradePage, Math.Max(0, (account.Trades.Count - 1) / 5))`
- `_trades[i].Text` = `i < trades.Length ? $"第{trades[i].Day}天 · {trades[i].Text}\n{CareerMoney.Compact(trades[i].Change)}" : "暂无成交"`
- `_trades[i].Visible` = `i < trades.Length || i == 0`

<a id="symbol-0579dd458274"></a>

## `NationalSpire.MarketTerminal.ToggleWatch() — private void ToggleWatch()`

来源：源码第 375 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketTerminal.RefreshList()`](MarketTerminal.cs.md#symbol-38f64566d7c6)；`Godot.ConfigFile.Save(string)`；`Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketTerminal._identity`；`NationalSpire.MarketTerminal._preferences`；`NationalSpire.MarketTerminal._selected`；`NationalSpire.MarketTerminal._watch`；`NationalSpire.MarketTerminal.RefreshList()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.Save(string)`；输入表达式：`_preferences.Save("user://NationalSpire_market.cfg")`；返回值紧邻使用处：`ExpressionStatementSyntax: _preferences.Save("user://NationalSpire_market.cfg");`
- `Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；输入表达式：`_preferences.SetValue(_identity, "watch", _watch.Order().ToArray())`；返回值紧邻使用处：`ExpressionStatementSyntax: _preferences.SetValue(_identity, "watch", _watch.Order().ToArray());`
- `NationalSpire.MarketTerminal.RefreshList()`；输入表达式：`RefreshList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshList();`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_watch.Add(_selected)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_watch.Add(_selected)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`_watch.Remove(_selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: _watch.Remove(_selected);`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`_watch.Order()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _watch.Order().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_watch.Order().ToArray()`；返回值紧邻使用处：`ArgumentSyntax: _watch.Order().ToArray()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-63d52edc18fa"></a>

## `NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder) — private void Submit(MarketOrder order)`

来源：源码第 381 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)；[`NationalSpire.MarketTerminal.ClosePosition(int)`](MarketTerminal.cs.md#symbol-1a0f641bc735)；[`NationalSpire.MarketTerminal.Open(int)`](MarketTerminal.cs.md#symbol-9665309ab157)

**调用：** `System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.MarketTerminal._submit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(order)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _submit?.Invoke(order)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5c2e4be798a5"></a>

## `NationalSpire.MarketTerminal.SetOrderMargin(decimal) — internal void SetOrderMargin(decimal margin)`

来源：源码第 382 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)

**调用：** [`NationalSpire.MarketAmountInput.SetAmount(decimal)`](MarketAmountInput.cs.md#symbol-b73158988cf2)；[`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAmountInput.SetAmount(decimal)`；`NationalSpire.MarketTerminal._amount`；`NationalSpire.MarketTerminal._portion`；`NationalSpire.MarketTerminal._settingAmount`；`NationalSpire.MarketTerminal.RefreshFee()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketAmountInput.SetAmount(decimal)`；输入表达式：`_amount.SetAmount(margin * 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: _amount.SetAmount(margin * 10);`
- `NationalSpire.MarketTerminal.RefreshFee()`；输入表达式：`RefreshFee()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshFee();`

**赋值（含属性/字段和局部值）：**

- `_portion` = `0`
- `_settingAmount` = `false`
- `_settingAmount` = `true`

<a id="symbol-9665309ab157"></a>

## `NationalSpire.MarketTerminal.Open(int) — private void Open(int direction)`

来源：源码第 386 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`NationalSpire.MarketTerminal.OrderMargin(NationalSpire.MarketAsset, int)`](MarketTerminal.cs.md#symbol-306487121584)；[`NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder)`](MarketTerminal.cs.md#symbol-63d52edc18fa)；`Godot.SpinBox.Apply()`；`NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.CareerMarket.Leverages`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketState.Revision`；`NationalSpire.MarketTerminal._amount`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._leverage`；`NationalSpire.MarketTerminal._selected`；`NationalSpire.MarketTerminal._settingAmount`；`NationalSpire.MarketTerminal.OrderMargin(NationalSpire.MarketAsset, int)`；`NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.SpinBox.Apply()`；输入表达式：`_amount.Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: _amount.Apply();`
- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new("open", _selected, amount, direction, leverage, QuoteRevision: _data.Market.Revision)`；返回值紧邻使用处：`ArgumentSyntax: new("open", _selected, amount, direction, leverage, QuoteRevision: _data.Market.Revision)`
- `NationalSpire.MarketTerminal.OrderMargin(NationalSpire.MarketAsset, int)`；输入表达式：`OrderMargin(asset, leverage)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OrderMargin(asset, leverage)`
- `NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder)`；输入表达式：`Submit(new("open", _selected, amount, direction, leverage, QuoteRevision: _data.Market.Revision))`；返回值紧邻使用处：`ExpressionStatementSyntax: Submit(new("open", _selected, amount, direction, leverage, QuoteRevision: _data.Market.Revision));`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`MarketCatalog.ById.TryGetValue(_selected, out var asset)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !MarketCatalog.ById.TryGetValue(_selected, out var asset)`

**赋值（含属性/字段和局部值）：**

- `_settingAmount` = `false`
- `_settingAmount` = `true`

<a id="symbol-1a0f641bc735"></a>

## `NationalSpire.MarketTerminal.ClosePosition(int) — private void ClosePosition(int row)`

来源：源码第 394 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)

**调用：** [`NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder)`](MarketTerminal.cs.md#symbol-63d52edc18fa)；`NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketPosition.Id`；`NationalSpire.MarketState.Revision`；`NationalSpire.MarketTerminal._data`；`NationalSpire.MarketTerminal._holdPage`；`NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new("close", Position: p.Id, QuoteRevision: _data.Market.Revision)`；返回值紧邻使用处：`ArgumentSyntax: new("close", Position: p.Id, QuoteRevision: _data.Market.Revision)`
- `NationalSpire.MarketTerminal.Submit(NationalSpire.MarketOrder)`；输入表达式：`Submit(new("close", Position: p.Id, QuoteRevision: _data.Market.Revision))`；返回值紧邻使用处：`ExpressionStatementSyntax: Submit(new("close", Position: p.Id, QuoteRevision: _data.Market.Revision));`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`_data.Life.Trading.Positions.Skip(_holdPage * 5 + row).FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _data.Life.Trading.Positions.Skip(_holdPage * 5 + row).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`_data.Life.Trading.Positions.Skip(_holdPage * 5 + row)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _data.Life.Trading.Positions.Skip(_holdPage * 5 + row).FirstOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-88fdb4c0e3f3"></a>

## `NationalSpire.MarketChart.Points — public MarketPoint[] Points`

来源：源码第 407 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketChart.Set(NationalSpire.MarketPoint[], string, decimal)`](MarketTerminal.cs.md#symbol-22dfa2e243b9)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketChart._points`；`NationalSpire.MarketChart._seed`；`NationalSpire.MarketChart.Set(NationalSpire.MarketPoint[], string, decimal)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketChart.Set(NationalSpire.MarketPoint[], string, decimal)`；输入表达式：`Set(value, _seed)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Set(value, _seed)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-22dfa2e243b9"></a>

## `NationalSpire.MarketChart.Set(NationalSpire.MarketPoint[], string, decimal) — public void Set(MarketPoint[] points, string seed, decimal displayScale = 1)`

来源：源码第 408 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketChart.Points`](MarketTerminal.cs.md#symbol-88fdb4c0e3f3)；[`NationalSpire.MarketTerminal.RefreshChart()`](MarketTerminal.cs.md#symbol-e1b73bf4bb8f)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketChart._displayScale`；`NationalSpire.MarketChart._hover`；`NationalSpire.MarketChart._points`；`NationalSpire.MarketChart._seed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_displayScale` = `displayScale`
- `_hover` = `-1`
- `_points` = `points`
- `_seed` = `seed`

<a id="symbol-064212e23548"></a>

## `NationalSpire.MarketChart._Ready() — public override void _Ready()`

来源：源码第 409 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketChart._hover`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_hover` = `-1`
- `MouseExited` += `() => { _hover = -1; QueueRedraw(); }`
- `Resized` += `QueueRedraw`

<a id="symbol-1a59bdaab0d5"></a>

## `NationalSpire.MarketChart._GuiInput(Godot.InputEvent) — public override void _GuiInput(InputEvent e)`

来源：源码第 410 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketChart._hover`；`NationalSpire.MarketChart._points`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp((int)((mouse.Position.X - 8) / Math.Max(1, Size.X - 90) * _points.Length), 0, _points.Length - 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _hover = Math.Clamp((int)((mouse.Position.X - 8) / Math.Max(1, Size.X - 90) * _points.Length), 0, _points.Length - 1)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(1, Size.X - 90)`；返回值紧邻使用处：`BinaryExpressionSyntax: (mouse.Position.X - 8) / Math.Max(1, Size.X - 90)`

**赋值（含属性/字段和局部值）：**

- `_hover` = `Math.Clamp((int)((mouse.Position.X - 8) / Math.Max(1, Size.X - 90) * _points.Length), 0, _points.Length - 1)`

<a id="symbol-b9c7f00ce2d0"></a>

## `NationalSpire.MarketChart._Draw() — public override void _Draw()`

来源：源码第 414 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`Y(decimal)`](MarketTerminal.cs.md#symbol-c3cda4635013)；`decimal.ToString(string?)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；`Godot.Color.Color(string)`；`Godot.Control.GetThemeDefaultFont()`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, decimal>)`；`System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, decimal>)`；`System.Math.Abs(float)`；`System.Math.Max(decimal, decimal)`；`System.Math.Max(float, float)`；`System.Math.Min(decimal, decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.MarketChart._displayScale`；`NationalSpire.MarketChart._hover`；`NationalSpire.MarketChart._points`；`NationalSpire.MarketChart._seed`；`NationalSpire.MarketPoint.Day`；`NationalSpire.MarketPoint.Price`；`Y(decimal)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`((high - range * i / 4) * _displayScale).ToString(_displayScale == 1 ? "0.0000" : "0.00")`；返回值紧邻使用处：`ArgumentSyntax: ((high - range * i / 4) * _displayScale).ToString(_displayScale == 1 ? "0.0000" : "0.00")`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(8, Y(last.Price)), new(area.End.X, Y(last.Price)), CareerVisuals.Gold, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(8, Y(last.Price)), new(area.End.X, Y(last.Price)), CareerVisuals.Gold, 1);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(8, y), new(area.End.X, y), new Color("29434b"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(8, y), new(area.End.X, y), new Color("29434b"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(x, 28), new(x, area.End.Y), new Color("7b9b9c"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(x, 28), new(x, area.End.Y), new Color("7b9b9c"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(x, Y(Math.Max(open, close) + wick)), new(x, Y(Math.Min(open, close) - wick)), color, 1.3f)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(x, Y(Math.Max(open, close) + wick)), new(x, Y(Math.Min(open, close) - wick)), color, 1.3f);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(Vector2.Zero, Size), new Color("0b1c25"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(Vector2.Zero, Size), new Color("0b1c25"));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(x - Math.Max(1, step * .3f), Y(Math.Max(open, close)), Math.Max(2, step * .6f), Math.Max(2, Math.Abs(Y(open) - Y(close)))), color)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(x - Math.Max(1, step * .3f), Y(Math.Max(open, close)), Math.Max(2, step * .6f), Math.Max(2, Math.Abs(Y(open) - Y(close)))), color);`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, new(10, 20), $"第{_points[_hover].Day}天  开 {(_hover > 0 ? _points[_hover - 1].Price : _points[_hover].Price) * _displayScale:0.0000}  收 {_points[_hover].Price * _displayScale:0.0000}", fontSize: 14, modulate: CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, new(10, 20), $"第{_points[_hover].Day}天  开 {(_hover > 0 ? _points[_hover - 1].Price : _points[_hover].Price) * _displayScale:0.0000}  收 {_points[_hover].Price * _displayScale:0.0000}", fontSize: 14, modulate: CareerVisuals.Gold);`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, new(8, Size.Y - 8), _points[0].Day > 0 ? "D" + _points[0].Day : "开市前", fontSize: 13, modulate: CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, new(8, Size.Y - 8), _points[0].Day > 0 ? "D" + _points[0].Day : "开市前", fontSize: 13, modulate: CareerVisuals.Muted);`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, new(area.End.X - 48, Size.Y - 8), "D" + last.Day, fontSize: 13, modulate: CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, new(area.End.X - 48, Size.Y - 8), "D" + last.Day, fontSize: 13, modulate: CareerVisuals.Muted);`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, new(area.End.X + 8, y + 5), ((high - range * i / 4) * _displayScale).ToString(_displayScale == 1 ? "0.0000" : "0.00"), fontSize: 13, modulate: CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, new(area.End.X + 8, y + 5), ((high - range * i / 4) * _displayScale).ToString(_displayScale == 1 ? "0.0000" : "0.00"), fontSize: 13, modulate: CareerVisuals.Muted);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0b1c25")`；返回值紧邻使用处：`ArgumentSyntax: new Color("0b1c25")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("29434b")`；返回值紧邻使用处：`ArgumentSyntax: new Color("29434b")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("7b9b9c")`；返回值紧邻使用处：`ArgumentSyntax: new Color("7b9b9c")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("82d7b5")`；返回值紧邻使用处：`ConditionalExpressionSyntax: close >= open ? new Color("82d7b5") : new Color("ee98aa")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ee98aa")`；返回值紧邻使用处：`ConditionalExpressionSyntax: close >= open ? new Color("82d7b5") : new Color("ee98aa")`
- `Godot.Control.GetThemeDefaultFont()`；输入表达式：`GetThemeDefaultFont()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetThemeDefaultFont()`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(8, 30, Size.X - 90, Size.Y - 60)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(8, 30, Size.X - 90, Size.Y - 60)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(x - Math.Max(1, step * .3f), Y(Math.Max(open, close)), Math.Max(2, step * .6f), Math.Max(2, Math.Abs(Y(open) - Y(close))))`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(x - Math.Max(1, step * .3f), Y(Math.Max(open, close)), Math.Max(2, step * .6f), Math.Max(2, Math.Abs(Y(open) - Y(close))))`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(10, 20)`；返回值紧邻使用处：`ArgumentSyntax: new(10, 20)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(8, Size.Y - 8)`；返回值紧邻使用处：`ArgumentSyntax: new(8, Size.Y - 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(8, Y(last.Price))`；返回值紧邻使用处：`ArgumentSyntax: new(8, Y(last.Price))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(8, y)`；返回值紧邻使用处：`ArgumentSyntax: new(8, y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(area.End.X - 48, Size.Y - 8)`；返回值紧邻使用处：`ArgumentSyntax: new(area.End.X - 48, Size.Y - 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(area.End.X + 8, y + 5)`；返回值紧邻使用处：`ArgumentSyntax: new(area.End.X + 8, y + 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(area.End.X, Y(last.Price))`；返回值紧邻使用处：`ArgumentSyntax: new(area.End.X, Y(last.Price))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(area.End.X, y)`；返回值紧邻使用处：`ArgumentSyntax: new(area.End.X, y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x, 28)`；返回值紧邻使用处：`ArgumentSyntax: new(x, 28)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x, area.End.Y)`；返回值紧邻使用处：`ArgumentSyntax: new(x, area.End.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x, Y(Math.Max(open, close) + wick))`；返回值紧邻使用处：`ArgumentSyntax: new(x, Y(Math.Max(open, close) + wick))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x, Y(Math.Min(open, close) - wick))`；返回值紧邻使用处：`ArgumentSyntax: new(x, Y(Math.Min(open, close) - wick))`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(_seed + _points[i].Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(_seed + _points[i].Day) % 1000`
- `System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, decimal>)`；输入表达式：`_points.Max(p => p.Price)`；返回值紧邻使用处：`BinaryExpressionSyntax: _points.Max(p => p.Price) * 1.012m`
- `System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, decimal>)`；输入表达式：`_points.Min(p => p.Price)`；返回值紧邻使用处：`BinaryExpressionSyntax: _points.Min(p => p.Price) * .988m`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(Y(open) - Y(close))`；返回值紧邻使用处：`ArgumentSyntax: Math.Abs(Y(open) - Y(close))`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(open, close)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(open, close)`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(open, close)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(open, close) + wick`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(1, step * .3f)`；返回值紧邻使用处：`BinaryExpressionSyntax: x - Math.Max(1, step * .3f)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(2, Math.Abs(Y(open) - Y(close)))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(2, Math.Abs(Y(open) - Y(close)))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(2, step * .6f)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(2, step * .6f)`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(open, close)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(open, close) - wick`
- `Y(decimal)`；输入表达式：`Y(close)`；返回值紧邻使用处：`BinaryExpressionSyntax: Y(open) - Y(close)`
- `Y(decimal)`；输入表达式：`Y(last.Price)`；返回值紧邻使用处：`ArgumentSyntax: Y(last.Price)`
- `Y(decimal)`；输入表达式：`Y(Math.Max(open, close) + wick)`；返回值紧邻使用处：`ArgumentSyntax: Y(Math.Max(open, close) + wick)`
- `Y(decimal)`；输入表达式：`Y(Math.Max(open, close))`；返回值紧邻使用处：`ArgumentSyntax: Y(Math.Max(open, close))`
- `Y(decimal)`；输入表达式：`Y(Math.Min(open, close) - wick)`；返回值紧邻使用处：`ArgumentSyntax: Y(Math.Min(open, close) - wick)`
- `Y(decimal)`；输入表达式：`Y(open)`；返回值紧邻使用处：`BinaryExpressionSyntax: Y(open) - Y(close)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c3cda4635013"></a>

## `Y(decimal) — float Y(decimal value)`

来源：源码第 419 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketChart._Draw()`](MarketTerminal.cs.md#symbol-b9c7f00ce2d0)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
