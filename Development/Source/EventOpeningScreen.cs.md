# EventOpeningScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`EEC0A713C2E7E3B3210D7D2935D4516C3BA5F910BED6941D15502EF6AE65B4A3`。来源：[源码](../../EventOpeningScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.EventStoryView`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
internal Action? EditMaterial, EditPeople;
private HBoxContainer _openingCards = null!;
private Label _materialSummary = null!, _peopleSummary = null!;
```

<a id="symbol-d336e0b002ed"></a>

## `NationalSpire.EventStoryView.Opening — internal EventOpeningChoice Opening`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.EventOpeningChoice.EventOpeningChoice(NationalSpire.RandomEventSeed?, string[]?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EventOpeningChoice.EventOpeningChoice(NationalSpire.RandomEventSeed?, string[]?)`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9f7ebd4b5222"></a>

## `NationalSpire.EventStoryView.BuildOpeningCards() — private void BuildOpeningCards()`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView._Ready()`](RandomEventScreen.cs.md#symbol-d31ee33f7cb0)

**调用：** [`Card(string, string, string, System.Action)`](EventOpeningScreen.cs.md#symbol-2f8bce80dc37)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Card(string, string, string, System.Action)`；`NationalSpire.EventStoryView._materialSummary`；`NationalSpire.EventStoryView._openingCards`；`NationalSpire.EventStoryView._peopleSummary`；`NationalSpire.EventStoryView._reading`；`NationalSpire.EventStoryView.EditMaterial`；`NationalSpire.EventStoryView.EditPeople`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Card(string, string, string, System.Action)`；输入表达式：`Card("参与人物","users-round","EventPeople",() => EditPeople?.Invoke())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _peopleSummary = Card("参与人物","users-round","EventPeople",() => EditPeople?.Invoke())`
- `Card(string, string, string, System.Action)`；输入表达式：`Card("事件素材","book-open","EventMaterial",() => EditMaterial?.Invoke())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _materialSummary = Card("事件素材","book-open","EventMaterial",() => EditMaterial?.Invoke())`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_openingCards.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: _openingCards.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _openingCards = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_reading.AddChild(_openingCards)`；返回值紧邻使用处：`ExpressionStatementSyntax: _reading.AddChild(_openingCards);`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: EditMaterial?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: EditPeople?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_materialSummary` = `Card("事件素材","book-open","EventMaterial",() => EditMaterial?.Invoke())`
- `_openingCards` = `new HBoxContainer()`
- `_peopleSummary` = `Card("参与人物","users-round","EventPeople",() => EditPeople?.Invoke())`

<a id="symbol-2f8bce80dc37"></a>

## `Card(string, string, string, System.Action) — Label Card(string title, string icon, string name, Action edit)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.BuildOpeningCards()`](EventOpeningScreen.cs.md#symbol-9f7ebd4b5222)

**调用：** [`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.EventStoryView.ActionButton(string, System.Action)`](RandomEventScreen.cs.md#symbol-8068df83bcbc)；[`NationalSpire.EventStoryView.Words(string, int, Godot.Color)`](RandomEventScreen.cs.md#symbol-56ea79fa7863)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EventStoryView._openingCards`；`NationalSpire.EventStoryView.ActionButton(string, System.Action)`；`NationalSpire.EventStoryView.Ink`；`NationalSpire.EventStoryView.Muted`；`NationalSpire.EventStoryView.Words(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`col.AddThemeConstantOverride("separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddThemeConstantOverride("separation", 6);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`col.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_openingCards.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: _openingCards.AddChild(b);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`b.AddChild(col)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AddChild(col);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(summary)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(summary);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(CareerScreen.Glyph("chevron-right", 15, Muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(CareerScreen.Glyph("chevron-right", 15, Muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(CareerScreen.Glyph(icon, 19, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(CareerScreen.Glyph(icon, 19, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(label);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = BoxContainer.AlignmentMode.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = BoxContainer.AlignmentMode.Center }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: summary.CustomMinimumSize = new(0, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 98)`；返回值紧邻使用处：`AssignmentExpressionSyntax: b.CustomMinimumSize = new(0, 98)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`CareerScreen.Glyph("chevron-right", 15, Muted)`；返回值紧邻使用处：`ArgumentSyntax: CareerScreen.Glyph("chevron-right", 15, Muted)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`CareerScreen.Glyph(icon, 19, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: CareerScreen.Glyph(icon, 19, CareerVisuals.Teal)`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("", edit)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ActionButton("", edit)`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("随机", 16, Muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Words("随机", 16, Muted)`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words(title, 17, Ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Words(title, 17, Ink)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `b.AccessibilityName` = `title`
- `b.CustomMinimumSize` = `new(0, 98)`
- `b.Name` = `name`
- `b.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `col.OffsetLeft` = `14`
- `col.OffsetRight` = `-14`
- `label.MouseFilter` = `MouseFilterEnum.Ignore`
- `label.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `summary.CustomMinimumSize` = `new(0, 44)`
- `summary.MaxLinesVisible` = `2`
- `summary.MouseFilter` = `MouseFilterEnum.Ignore`
- `summary.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `summary.VerticalAlignment` = `VerticalAlignment.Top`

<a id="symbol-8cc9e786a7f2"></a>

## `NationalSpire.EventStoryView.SetOpening(NationalSpire.EventOpeningChoice, NationalSpire.CareerData) — internal void SetOpening(EventOpeningChoice value, CareerData data)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditEventMaterial(NationalSpire.EventStoryView)`](EventOpeningScreen.cs.md#symbol-682979c85474)；[`NationalSpire.CareerScreen.EditEventPeople(NationalSpire.EventStoryView)`](EventOpeningScreen.cs.md#symbol-4517eea6ac6b)

**调用：** [`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`Summary(Godot.Label, string?)`](EventOpeningScreen.cs.md#symbol-1d23e107c4fe)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventOpeningChoice.Material`；`NationalSpire.EventOpeningChoice.People`；`NationalSpire.EventStoryView._materialSummary`；`NationalSpire.EventStoryView._peopleSummary`；`NationalSpire.EventStoryView.Opening`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.RandomEventSeed.Detail`；`Summary(Godot.Label, string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(data,p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => GroupChats.Name(data,p)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", people.Select(p => GroupChats.Name(data,p)))`；返回值紧邻使用处：`SwitchExpressionArmSyntax: var people => string.Join("、", people.Select(p => GroupChats.Name(data,p)))`
- `Summary(Godot.Label, string?)`；输入表达式：`Summary(_materialSummary, value.Material?.Detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: Summary(_materialSummary, value.Material?.Detail);`
- `Summary(Godot.Label, string?)`；输入表达式：`Summary(_peopleSummary, value.People switch { null => null, { Length: 0 } => "玩家独自经历",             var people => string.Join("、", people.Select(p => GroupChats.Name(data,p))) })`；返回值紧邻使用处：`ExpressionStatementSyntax: Summary(_peopleSummary, value.People switch { null => null, { Length: 0 } => "玩家独自经历",             var people => string.Join("、", people.Select(p => GroupChats.Name(data,p))) });`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`people.Select(p => GroupChats.Name(data,p))`；返回值紧邻使用处：`ArgumentSyntax: people.Select(p => GroupChats.Name(data,p))`

**赋值（含属性/字段和局部值）：**

- `Opening` = `value`

<a id="symbol-1d23e107c4fe"></a>

## `Summary(Godot.Label, string?) — void Summary(Label label, string? detail)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.SetOpening(NationalSpire.EventOpeningChoice, NationalSpire.CareerData)`](EventOpeningScreen.cs.md#symbol-8cc9e786a7f2)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Node.GetParent()`；`Godot.Node.GetParent<T>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`；`NationalSpire.EventStoryView.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("font_color", detail == null ? Muted : CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("font_color", detail == null ? Muted : CareerVisuals.Teal);`
- `Godot.Node.GetParent()`；输入表达式：`label.GetParent()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: label.GetParent().GetParent<Button>`
- `Godot.Node.GetParent<T>()`；输入表达式：`label.GetParent().GetParent<Button>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: label.GetParent().GetParent<Button>().TooltipText`

**赋值（含属性/字段和局部值）：**

- `label.GetParent().GetParent<Button>().TooltipText` = `detail ?? "随机"`
- `label.Text` = `detail ?? "随机"`

<a id="symbol-a040f56f2385"></a>

## `NationalSpire.CareerScreen.EventModeTabs(Godot.VBoxContainer, string[], int, System.Action<int>) — private static void EventModeTabs(VBoxContainer parent, string[] names, int initial, Action<int> select)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditEventMaterial(NationalSpire.EventStoryView)`](EventOpeningScreen.cs.md#symbol-682979c85474)；[`NationalSpire.CareerScreen.EditEventPeople(NationalSpire.EventStoryView)`](EventOpeningScreen.cs.md#symbol-4517eea6ac6b)

**调用：** [`NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`](OpeningControls.cs.md#symbol-93105b3962ff)；`Godot.ButtonGroup.ButtonGroup()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ButtonGroup.ButtonGroup()`；输入表达式：`new ButtonGroup()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ButtonGroup()`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 8);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(row);`
- `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；输入表达式：`OpeningControls.Chip(row, group, names[i], i == initial, () => select(index))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OpeningControls.Chip(row, group, names[i], i == initial, () => select(index))`
- `System.Action<T>.Invoke(T)`；输入表达式：`select(index)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => select(index)`

**赋值（含属性/字段和局部值）：**

- `tab.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-4517eea6ac6b"></a>

## `NationalSpire.CareerScreen.EditEventPeople(NationalSpire.EventStoryView) — private void EditEventPeople(EventStoryView view)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenRandomEvent(string)`](RandomEventScreen.cs.md#symbol-b6a9dfbe8e4f)

**调用：** [`NationalSpire.CareerScreen.EventModeTabs(Godot.VBoxContainer, string[], int, System.Action<int>)`](EventOpeningScreen.cs.md#symbol-a040f56f2385)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.EventStoryView.SetOpening(NationalSpire.EventOpeningChoice, NationalSpire.CareerData)`](EventOpeningScreen.cs.md#symbol-8cc9e786a7f2)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；[`ShowMode(int)`](EventOpeningScreen.cs.md#symbol-6869e9ee7f56)；[`Update()`](EventOpeningScreen.cs.md#symbol-4b7cf9594fb0)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.EventModeTabs(Godot.VBoxContainer, string[], int, System.Action<int>)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.EventOpeningChoice.People`；`NationalSpire.EventStoryView.Opening`；`NationalSpire.EventStoryView.SetOpening(NationalSpire.EventOpeningChoice, NationalSpire.CareerData)`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；`ShowMode(int)`；`Update()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`picker.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddThemeConstantOverride("separation", 10);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(note)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(note);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(picker);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `NationalSpire.CareerScreen.EventModeTabs(Godot.VBoxContainer, string[], int, System.Action<int>)`；输入表达式：`EventModeTabs(box, ["随机","玩家独自经历","指定人物"], mode, ShowMode)`；返回值紧邻使用处：`ExpressionStatementSyntax: EventModeTabs(box, ["随机","玩家独自经历","指定人物"], mode, ShowMode);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("参与人物", "", () =>         {             view.SetOpening(view.Opening with { People = mode switch { 0 => null, 1 => [], _ => chosen.ToArray() } }, data);             return true;         }, "采用选择", box =>         {             var picker = new VBoxContainer(); picker.AddThemeConstantOverride("separation", 10);             var note = OpeningControls.Label("");             void ShowMode(int value)             {                 mode = value; note.Visible = mode != 2; picker.Visible = mode == 2;                 note.Text = mode == 0 ? "让故事决定今天会遇见谁，也可能是独自度过的一天。" : "这次只写玩家自己的经历。";                 if (mode == 2 && picker.GetChildCount() == 0)                     PeoplePicker(picker, PrivateMessages.ChatCandidates(data).ToArray(), chosen, false, Update, 224);                 Update();             }             EventModeTabs(box, ["随机","玩家独自经历","指定人物"], mode, ShowMode);             box.AddChild(note); box.AddChild(picker); ShowMode(mode);         }, footer: (_,_,b) => { confirm = b; Update(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("参与人物", "", () =>         {             view.SetOpening(view.Opening with { People = mode switch { 0 => null, 1 => [], _ => chosen.ToArray() } }, data);             return true;         }, "采用选择", box =>         {             var picker = new VBoxContainer(); picker.AddThemeConstantOverride("separation", 10);             var note = OpeningControls.Label("");             void ShowMode(int value)             {                 mode = value; note.Visible = mode != 2; picker.Visible = mode == 2;                 note.Text = mode == 0 ? "让故事决定今天会遇见谁，也可能是独自度过的一天。" : "这次只写玩家自己的经历。";                 if (mode == 2 && picker.GetChildCount() == 0)                     PeoplePicker(picker, PrivateMessages.ChatCandidates(data).ToArray(), chosen, false, Update, 224);                 Update();             }             EventModeTabs(box, ["随机","玩家独自经历","指定人物"], mode, ShowMode);             box.AddChild(note); box.AddChild(picker); ShowMode(mode);         }, footer: (_,_,b) => { confirm = b; Update(); });`
- `NationalSpire.EventStoryView.SetOpening(NationalSpire.EventOpeningChoice, NationalSpire.CareerData)`；输入表达式：`view.SetOpening(view.Opening with { People = mode switch { 0 => null, 1 => [], _ => chosen.ToArray() } }, data)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.SetOpening(view.Opening with { People = mode switch { 0 => null, 1 => [], _ => chosen.ToArray() } }, data);`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OpeningControls.Label("")`
- `ShowMode(int)`；输入表达式：`ShowMode(mode)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowMode(mode);`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: previous?.ToHashSet(StringComparer.Ordinal) ?? new()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`chosen.ToArray()`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => chosen.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`.ToHashSet(StringComparer.Ordinal)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: previous?.ToHashSet(StringComparer.Ordinal)`
- `Update()`；输入表达式：`Update()`；返回值紧邻使用处：`ExpressionStatementSyntax: Update();`

**赋值（含属性/字段和局部值）：**

- `confirm` = `b`
- `People` = `mode switch { 0 => null, 1 => [], _ => chosen.ToArray() }`

<a id="symbol-4b7cf9594fb0"></a>

## `Update() — void Update()`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditEventPeople(NationalSpire.EventStoryView)`](EventOpeningScreen.cs.md#symbol-4517eea6ac6b)；[`ShowMode(int)`](EventOpeningScreen.cs.md#symbol-6869e9ee7f56)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `confirm.Disabled` = `mode == 2 && chosen.Count == 0`

<a id="symbol-6869e9ee7f56"></a>

## `ShowMode(int) — void ShowMode(int value)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditEventPeople(NationalSpire.EventStoryView)`](EventOpeningScreen.cs.md#symbol-4517eea6ac6b)

**调用：** [`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool, string)`](PeoplePickerScreen.cs.md#symbol-bb0e3159d994)；[`NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-a6a32e618e4c)；[`Update()`](EventOpeningScreen.cs.md#symbol-4b7cf9594fb0)；`Godot.Node.GetChildCount(bool)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool, string)`；`NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData)`；`Update()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetChildCount(bool)`；输入表达式：`picker.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: picker.GetChildCount() == 0`
- `NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool, string)`；输入表达式：`PeoplePicker(picker, PrivateMessages.ChatCandidates(data).ToArray(), chosen, false, Update, 224)`；返回值紧邻使用处：`ExpressionStatementSyntax: PeoplePicker(picker, PrivateMessages.ChatCandidates(data).ToArray(), chosen, false, Update, 224);`
- `NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.ChatCandidates(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`PrivateMessages.ChatCandidates(data).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.ChatCandidates(data).ToArray()`
- `Update()`；输入表达式：`Update()`；返回值紧邻使用处：`ExpressionStatementSyntax: Update();`

**赋值（含属性/字段和局部值）：**

- `mode` = `value`
- `note.Text` = `mode == 0 ? "让故事决定今天会遇见谁，也可能是独自度过的一天。" : "这次只写玩家自己的经历。"`
- `note.Visible` = `mode != 2`
- `picker.Visible` = `mode == 2`

<a id="symbol-682979c85474"></a>

## `NationalSpire.CareerScreen.EditEventMaterial(NationalSpire.EventStoryView) — private void EditEventMaterial(EventStoryView view)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenRandomEvent(string)`](RandomEventScreen.cs.md#symbol-b6a9dfbe8e4f)

**调用：** [`NationalSpire.CareerScreen.EventModeTabs(Godot.VBoxContainer, string[], int, System.Action<int>)`](EventOpeningScreen.cs.md#symbol-a040f56f2385)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.EventStoryView.SetOpening(NationalSpire.EventOpeningChoice, NationalSpire.CareerData)`](EventOpeningScreen.cs.md#symbol-8cc9e786a7f2)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；[`ShowMode(int)`](EventOpeningScreen.cs.md#symbol-534904817524)；[`Update()`](EventOpeningScreen.cs.md#symbol-486f43135b34)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.RandomEventSeed.RandomEventSeed(string, string)`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.EventModeTabs(Godot.VBoxContainer, string[], int, System.Action<int>)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.EventOpeningChoice.Material`；`NationalSpire.EventStoryView.Opening`；`NationalSpire.EventStoryView.SetOpening(NationalSpire.EventOpeningChoice, NationalSpire.CareerData)`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；`NationalSpire.RandomEventSeed.Category`；`NationalSpire.RandomEventSeed.Detail`；`ShowMode(int)`；`Update()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`library.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: library.AddThemeConstantOverride("separation", 9);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`write.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: write.AddThemeConstantOverride("separation", 9);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(library)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(library);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(note)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(note);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(write)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(write);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`write.AddChild(editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: write.AddChild(editor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`write.AddChild(OpeningControls.Label("这段文字只用于今天的际遇。",14))`；返回值紧邻使用处：`ExpressionStatementSyntax: write.AddChild(OpeningControls.Label("这段文字只用于今天的际遇。",14));`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "EventSeedInput", Text = input, PlaceholderText = "写下故事的开端，例如雨停后的旧书店里，有人留下一张没有署名的书签……",                 WrapMode = TextEdit.LineWrappingMode.Boundary, CustomMinimumSize = new(0,140) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "EventSeedInput", Text = input, PlaceholderText = "写下故事的开端，例如雨停后的旧书店里，有人留下一张没有署名的书签……",                 WrapMode = TextEdit.LineWrappingMode.Boundary, CustomMinimumSize = new(0,140) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,140)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0,140)`
- `NationalSpire.CareerScreen.EventModeTabs(Godot.VBoxContainer, string[], int, System.Action<int>)`；输入表达式：`EventModeTabs(box, ["随机","从事件池选择","自己填写"], mode, ShowMode)`；返回值紧邻使用处：`ExpressionStatementSyntax: EventModeTabs(box, ["随机","从事件池选择","自己填写"], mode, ShowMode);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("事件素材", "", () =>         {             var seed = mode switch { 1 => selected, 2 when !string.IsNullOrWhiteSpace(input) => new RandomEventSeed("",input.Trim()), _ => null };             view.SetOpening(view.Opening with { Material = seed }, d); return true;         }, "采用选择", box =>         {             var note = OpeningControls.Label("从当前事件池抽取一段生活片刻，遇见怎样的故事，留到开始时揭晓。");             var library = new VBoxContainer(); library.AddThemeConstantOverride("separation", 9);             var write = new VBoxContainer(); write.AddThemeConstantOverride("separation", 9);             var editor = new TextEdit { Name = "EventSeedInput", Text = input, PlaceholderText = "写下故事的开端，例如雨停后的旧书店里，有人留下一张没有署名的书签……",                 WrapMode = TextEdit.LineWrappingMode.Boundary, CustomMinimumSize = new(0,140) };             write.AddChild(editor); write.AddChild(OpeningControls.Label("这段文字只用于今天的际遇。",14));             editor.TextChanged += () => input = editor.Text;             void ShowMode(int value)             {                 mode = value; note.Visible = mode == 0; library.Visible = mode == 1; write.Visible = mode == 2;                 if (mode == 1 && library.GetChildCount() == 0) LoadEventLibrary(library, selected, value => { selected = value; Update(); });                 Update();             }             EventModeTabs(box, ["随机","从事件池选择","自己填写"], mode, ShowMode);             box.AddChild(note); box.AddChild(library); box.AddChild(write); ShowMode(mode);         }, footer: (_,_,b) => { confirm = b; Update(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("事件素材", "", () =>         {             var seed = mode switch { 1 => selected, 2 when !string.IsNullOrWhiteSpace(input) => new RandomEventSeed("",input.Trim()), _ => null };             view.SetOpening(view.Opening with { Material = seed }, d); return true;         }, "采用选择", box =>         {             var note = OpeningControls.Label("从当前事件池抽取一段生活片刻，遇见怎样的故事，留到开始时揭晓。");             var library = new VBoxContainer(); library.AddThemeConstantOverride("separation", 9);             var write = new VBoxContainer(); write.AddThemeConstantOverride("separation", 9);             var editor = new TextEdit { Name = "EventSeedInput", Text = input, PlaceholderText = "写下故事的开端，例如雨停后的旧书店里，有人留下一张没有署名的书签……",                 WrapMode = TextEdit.LineWrappingMode.Boundary, CustomMinimumSize = new(0,140) };             write.AddChild(editor); write.AddChild(OpeningControls.Label("这段文字只用于今天的际遇。",14));             editor.TextChanged += () => input = editor.Text;             void ShowMode(int value)             {                 mode = value; note.Visible = mode == 0; library.Visible = mode == 1; write.Visible = mode == 2;                 if (mode == 1 && library.GetChildCount() == 0) LoadEventLibrary(library, selected, value => { selected = value; Update(); });                 Update();             }             EventModeTabs(box, ["随机","从事件池选择","自己填写"], mode, ShowMode);             box.AddChild(note); box.AddChild(library); box.AddChild(write); ShowMode(mode);         }, footer: (_,_,b) => { confirm = b; Update(); });`
- `NationalSpire.EventStoryView.SetOpening(NationalSpire.EventOpeningChoice, NationalSpire.CareerData)`；输入表达式：`view.SetOpening(view.Opening with { Material = seed }, d)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.SetOpening(view.Opening with { Material = seed }, d);`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("从当前事件池抽取一段生活片刻，遇见怎样的故事，留到开始时揭晓。")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OpeningControls.Label("从当前事件池抽取一段生活片刻，遇见怎样的故事，留到开始时揭晓。")`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("这段文字只用于今天的际遇。",14)`；返回值紧邻使用处：`ArgumentSyntax: OpeningControls.Label("这段文字只用于今天的际遇。",14)`
- `NationalSpire.RandomEventSeed.RandomEventSeed(string, string)`；输入表达式：`new RandomEventSeed("",input.Trim())`；返回值紧邻使用处：`SwitchExpressionArmSyntax: 2 when !string.IsNullOrWhiteSpace(input) => new RandomEventSeed("",input.Trim())`
- `ShowMode(int)`；输入表达式：`ShowMode(mode)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowMode(mode);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(input)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(input)`
- `string.Trim()`；输入表达式：`input.Trim()`；返回值紧邻使用处：`ArgumentSyntax: input.Trim()`
- `Update()`；输入表达式：`Update()`；返回值紧邻使用处：`ExpressionStatementSyntax: Update();`

**赋值（含属性/字段和局部值）：**

- `confirm` = `b`
- `CustomMinimumSize` = `new(0,140)`
- `editor.TextChanged` += `() => input = editor.Text`
- `input` = `editor.Text`
- `Material` = `seed`
- `Name` = `"EventSeedInput"`
- `PlaceholderText` = `"写下故事的开端，例如雨停后的旧书店里，有人留下一张没有署名的书签……"`
- `Text` = `input`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-486f43135b34"></a>

## `Update() — void Update()`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditEventMaterial(NationalSpire.EventStoryView)`](EventOpeningScreen.cs.md#symbol-682979c85474)；[`ShowMode(int)`](EventOpeningScreen.cs.md#symbol-534904817524)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `confirm.Disabled` = `mode == 1 && selected == null`

<a id="symbol-534904817524"></a>

## `ShowMode(int) — void ShowMode(int value)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditEventMaterial(NationalSpire.EventStoryView)`](EventOpeningScreen.cs.md#symbol-682979c85474)

**调用：** [`NationalSpire.CareerScreen.LoadEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`](EventOpeningScreen.cs.md#symbol-6b8a94f5911f)；[`Update()`](EventOpeningScreen.cs.md#symbol-486f43135b34)；`Godot.Node.GetChildCount(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.LoadEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`；`Update()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetChildCount(bool)`；输入表达式：`library.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: library.GetChildCount() == 0`
- `NationalSpire.CareerScreen.LoadEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`；输入表达式：`LoadEventLibrary(library, selected, value => { selected = value; Update(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadEventLibrary(library, selected, value => { selected = value; Update(); });`
- `Update()`；输入表达式：`Update()`；返回值紧邻使用处：`ExpressionStatementSyntax: Update();`

**赋值（含属性/字段和局部值）：**

- `library.Visible` = `mode == 1`
- `mode` = `value`
- `note.Visible` = `mode == 0`
- `selected` = `value`
- `write.Visible` = `mode == 2`

<a id="symbol-6b8a94f5911f"></a>

## `NationalSpire.CareerScreen.LoadEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>) — private async void LoadEventLibrary(VBoxContainer box, RandomEventSeed? current, Action<RandomEventSeed> choose)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LoadEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`](EventOpeningScreen.cs.md#symbol-6b8a94f5911f)；[`ShowMode(int)`](EventOpeningScreen.cs.md#symbol-534904817524)

**调用：** [`NationalSpire.CareerScreen.DrawEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed[], NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`](EventOpeningScreen.cs.md#symbol-4326f3c30ef2)；[`NationalSpire.CareerScreen.LoadEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`](EventOpeningScreen.cs.md#symbol-6b8a94f5911f)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；[`NationalSpire.Coop.CoopCareerSession.ReadEventPool(System.Threading.CancellationToken)`](Coop/CoopCareerSession.cs.md#symbol-ddd5192fa0da)；[`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`](EventPools.cs.md#symbol-5c94170cef9e)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；`Godot.CanvasItem.Hide()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Threading.CancellationTokenSource.CancellationTokenSource()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Ai`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen.DrawEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed[], NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`；`NationalSpire.CareerScreen.LoadEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.Coop.CoopCareerSession.ReadEventPool(System.Threading.CancellationToken)`；`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；`NationalSpire.EventPools.Snapshot.Random`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`retry!.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: retry!.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`status.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: status.Hide();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(box)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(box)) box.TreeExiting -= cancel.Cancel;`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(retry)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(retry);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `NationalSpire.CareerScreen.DrawEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed[], NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`；输入表达式：`DrawEventLibrary(box,entries,current,choose)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawEventLibrary(box,entries,current,choose);`
- `NationalSpire.CareerScreen.DrawEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed[], NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`；输入表达式：`DrawEventLibrary(box,EventPools.Get(ViewData.Ai).Random,current,choose)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawEventLibrary(box,EventPools.Get(ViewData.Ai).Random,current,choose);`
- `NationalSpire.CareerScreen.LoadEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`；输入表达式：`LoadEventLibrary(box,current,choose)`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadEventLibrary(box,current,choose);`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("重新读取", () => { retry!.Hide(); status.Hide(); LoadEventLibrary(box,current,choose); })`；返回值紧邻使用处：`AssignmentExpressionSyntax: retry = TextLink("重新读取", () => { retry!.Hide(); status.Hide(); LoadEventLibrary(box,current,choose); })`
- `NationalSpire.Coop.CoopCareerSession.ReadEventPool(System.Threading.CancellationToken)`；输入表达式：`room.ReadEventPool(cancel.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await room.ReadEventPool(cancel.Token)`
- `NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；输入表达式：`EventPools.Get(ViewData.Ai)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EventPools.Get(ViewData.Ai).Random`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("正在读取事件池…")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OpeningControls.Label("正在读取事件池…")`
- `System.Threading.CancellationTokenSource.CancellationTokenSource()`；输入表达式：`new CancellationTokenSource()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CancellationTokenSource()`

**赋值（含属性/字段和局部值）：**

- `box.TreeExiting` -= `cancel.Cancel`
- `box.TreeExiting` += `cancel.Cancel`
- `entries` = `await room.ReadEventPool(cancel.Token)`
- `retry` = `TextLink("重新读取", () => { retry!.Hide(); status.Hide(); LoadEventLibrary(box,current,choose); })`
- `status.Text` = `"暂时未能读取房主的事件池。"`

<a id="symbol-4326f3c30ef2"></a>

## `NationalSpire.CareerScreen.DrawEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed[], NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>) — private void DrawEventLibrary(VBoxContainer box, RandomEventSeed[] entries, RandomEventSeed? current, Action<RandomEventSeed> choose)`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LoadEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`](EventOpeningScreen.cs.md#symbol-6b8a94f5911f)

**调用：** [`NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`](OpeningControls.cs.md#symbol-93105b3962ff)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；[`Refresh()`](EventOpeningScreen.cs.md#symbol-f2701df7b482)；[`Summary()`](EventOpeningScreen.cs.md#symbol-9f9caac8a63d)；`Godot.ButtonGroup.ButtonGroup()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`；`NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；`NationalSpire.RandomEventSeed.Category`；`Refresh()`；`Summary()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ButtonGroup.ButtonGroup()`；输入表达式：`new ButtonGroup()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ButtonGroup()`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`categories.AddThemeConstantOverride("h_separation",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.AddThemeConstantOverride("h_separation",6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`categories.AddThemeConstantOverride("v_separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.AddThemeConstantOverride("v_separation",4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation",6);`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "EventSeedSearch", PlaceholderText = "搜索素材内容", CustomMinimumSize = new(0,42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "EventSeedSearch", PlaceholderText = "搜索素材内容", CustomMinimumSize = new(0,42) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(categories)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(categories);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(detail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(list);`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(0,206), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(0,206), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,206)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0,206)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: detail.CustomMinimumSize = new(0,40)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0,42)`
- `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；输入表达式：`OpeningControls.Chip(categories,filters,category,filter==category,()=> { filter=category; Refresh(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Chip(categories,filters,category,filter==category,()=> { filter=category; Refresh(); });`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("",15,CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OpeningControls.Label("",15,CareerVisuals.Teal)`
- `Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Refresh()`
- `Summary()`；输入表达式：`Summary()`；返回值紧邻使用处：`ExpressionStatementSyntax: Summary();`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`entries.Select(s=>s.Category).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entries.Select(s=>s.Category).Distinct().Prepend`
- `System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；输入表达式：`entries.Select(s=>s.Category).Distinct().Prepend("全部")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var category in entries.Select(s=>s.Category).Distinct().Prepend("全部"))             OpeningControls.Chip(categories,filters,category,filter==category,()=> { filter=category; Refresh(); });`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(s=>s.Category)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entries.Select(s=>s.Category).Distinct`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0,206)`
- `CustomMinimumSize` = `new(0,42)`
- `detail.CustomMinimumSize` = `new(0,40)`
- `detail.MaxLinesVisible` = `2`
- `detail.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `filter` = `category`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Name` = `"EventSeedSearch"`
- `PlaceholderText` = `"搜索素材内容"`
- `search.TextChanged` += `_ => Refresh()`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-9f9caac8a63d"></a>

## `Summary() — void Summary()`

来源：源码第 152 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`More()`](EventOpeningScreen.cs.md#symbol-4ebed0e8c0e9)；[`NationalSpire.CareerScreen.DrawEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed[], NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`](EventOpeningScreen.cs.md#symbol-4326f3c30ef2)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventSeed.Detail`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `detail.Text` = `current == null ? "请选择一条素材" : "已选  ·  " + current.Detail`
- `detail.TooltipText` = `current?.Detail ?? ""`

<a id="symbol-f2701df7b482"></a>

## `Refresh() — void Refresh()`

来源：源码第 153 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DrawEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed[], NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`](EventOpeningScreen.cs.md#symbol-4326f3c30ef2)

**调用：** [`More()`](EventOpeningScreen.cs.md#symbol-4ebed0e8c0e9)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`string.Contains(string, System.StringComparison)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `More()`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；`NationalSpire.RandomEventSeed.Category`；`NationalSpire.RandomEventSeed.Detail`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(OpeningControls.Label("没有找到符合条件的素材。"))`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(OpeningControls.Label("没有找到符合条件的素材。"));`
- `More()`；输入表达式：`More()`；返回值紧邻使用处：`ExpressionStatementSyntax: More();`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(list);`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("没有找到符合条件的素材。")`；返回值紧邻使用处：`ArgumentSyntax: OpeningControls.Label("没有找到符合条件的素材。")`
- `string.Contains(string, System.StringComparison)`；输入表达式：`s.Detail.Contains(search.Text.Trim(),StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: (filter == "全部" || s.Category == filter) && s.Detail.Contains(search.Text.Trim(),StringComparison.OrdinalIgnoreCase)`
- `string.Trim()`；输入表达式：`search.Text.Trim()`；返回值紧邻使用处：`ArgumentSyntax: search.Text.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`entries.Where(s => (filter == "全部" || s.Category == filter) && s.Detail.Contains(search.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entries.Where(s => (filter == "全部" || s.Category == filter) && s.Detail.Contains(search.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`entries.Where(s => (filter == "全部" || s.Category == filter) && s.Detail.Contains(search.Text.Trim(),StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entries.Where(s => (filter == "全部" || s.Category == filter) && s.Detail.Contains(search.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToArray`

**赋值（含属性/字段和局部值）：**

- `scroll.ScrollVertical` = `0`

<a id="symbol-4ebed0e8c0e9"></a>

## `More() — void More()`

来源：源码第 159 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`More()`](EventOpeningScreen.cs.md#symbol-4ebed0e8c0e9)；[`Refresh()`](EventOpeningScreen.cs.md#symbol-f2701df7b482)

**调用：** [`More()`](EventOpeningScreen.cs.md#symbol-4ebed0e8c0e9)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；[`Summary()`](EventOpeningScreen.cs.md#symbol-9f9caac8a63d)；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`

**字段、属性、事件及方法组引用：** `More()`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；`NationalSpire.RandomEventSeed.Detail`；`Summary()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`b.AddThemeFontSizeOverride("font_size",16)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AddThemeFontSizeOverride("font_size",16);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(b);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(more)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(more);`
- `Godot.Node.QueueFree()`；输入表达式：`more!.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: more!.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`list.RemoveChild(more!)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.RemoveChild(more!);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,41)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0,41)`
- `More()`；输入表达式：`More()`；返回值紧邻使用处：`ExpressionStatementSyntax: More();`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Text = seed.Detail, TooltipText = seed.Detail, Alignment = HorizontalAlignment.Left,                         AutowrapMode = TextServer.AutowrapMode.WordSmart, ToggleMode = true, ButtonGroup = options,                         ButtonPressed = seed == current, CustomMinimumSize = new(0,41) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Text = seed.Detail, TooltipText = seed.Detail, Alignment = HorizontalAlignment.Left,                         AutowrapMode = TextServer.AutowrapMode.WordSmart, ToggleMode = true, ButtonGroup = options,                         ButtonPressed = seed == current, CustomMinimumSize = new(0,41) }`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("查看更多素材", () => { list.RemoveChild(more!); more!.QueueFree(); More(); })`；返回值紧邻使用处：`AssignmentExpressionSyntax: more = TextLink("查看更多素材", () => { list.RemoveChild(more!); more!.QueueFree(); More(); })`
- `Summary()`；输入表达式：`Summary()`；返回值紧邻使用处：`ExpressionStatementSyntax: Summary();`
- `System.Action<T>.Invoke(T)`；输入表达式：`choose(seed)`；返回值紧邻使用处：`ExpressionStatementSyntax: choose(seed);`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`results.Skip(shown)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: results.Skip(shown).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`results.Skip(shown).Take(12)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var seed in results.Skip(shown).Take(12))                 {                     var b = new BroadcastButton { Text = seed.Detail, TooltipText = seed.Detail, Alignment = HorizontalAlignment.Left,                         AutowrapMode = TextServer.AutowrapMode.WordSmart, ToggleMode = true, ButtonGroup = options,                         ButtonPressed = seed == current, CustomMinimumSize = new(0,41) };                     b.AddThemeFontSizeOverride("font_size",16); list.AddChild(b);                     b.Pressed += () => { current = seed; choose(seed); Summary(); };                 }`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `HorizontalAlignment.Left`
- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `b.Pressed` += `() => { current = seed; choose(seed); Summary(); }`
- `ButtonGroup` = `options`
- `ButtonPressed` = `seed == current`
- `current` = `seed`
- `CustomMinimumSize` = `new(0,41)`
- `more` = `TextLink("查看更多素材", () => { list.RemoveChild(more!); more!.QueueFree(); More(); })`
- `shown` += `12`
- `Text` = `seed.Detail`
- `ToggleMode` = `true`
- `TooltipText` = `seed.Detail`
