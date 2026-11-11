# CareerClubPresentation.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`612B691007D11866A88B51C39899E2E17B737BE1BDD3481C203E089E33C282B6`。来源：[源码](../../CareerClubPresentation.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-86ece89f239d"></a>

## `NationalSpire.CareerScreen.InfoRow(Godot.Container) — private static HBoxContainer InfoRow(Container parent)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AchievementOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-f467edff90d1)；[`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-7094bac60c25)；[`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubPracticePreview(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.ClubSigning, bool)`](OwnedClubScreen.cs.md#symbol-db042267110f)；[`NationalSpire.CareerScreen.ClubSummary(NationalSpire.CareerData, NationalSpire.CareerClub, Godot.Container)`](CareerWorldScreen.cs.md#symbol-119e71d5db33)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)；[`NationalSpire.CareerScreen.PracticeRules(Godot.Container)`](CareerClubPresentation.cs.md#symbol-e9f9acda2cd5)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`](CareerClubPresentation.cs.md#symbol-2970a082b74e)；[`NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`](CareerClubPresentation.cs.md#symbol-b07f4ae318bc)；[`Terms(Godot.VBoxContainer, NationalSpire.SponsorContract, bool)`](CircuitScreen.cs.md#symbol-f6f24e76befe)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 14);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(row);`

**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-f603281ab648"></a>

## `NationalSpire.CareerScreen.InfoColumn(Godot.Container) — private static VBoxContainer InfoColumn(Container parent)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChoiceField(Godot.Container, string)`](CareerClubPresentation.cs.md#symbol-13fc3204a4de)；[`NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-7094bac60c25)；[`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubPracticePreview(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.ClubSigning, bool)`](OwnedClubScreen.cs.md#symbol-db042267110f)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`](CareerClubPresentation.cs.md#symbol-b07f4ae318bc)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`col.AddThemeConstantOverride("separation", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddThemeConstantOverride("separation", 4);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(col)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(col);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, Alignment = BoxContainer.AlignmentMode.Center, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, Alignment = BoxContainer.AlignmentMode.Center, MouseFilter = MouseFilterEnum.Ignore }`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-13fc3204a4de"></a>

## `NationalSpire.CareerScreen.ChoiceField(Godot.Container, string) — private VBoxContainer ChoiceField(Container parent, string title)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)

**调用：** [`NationalSpire.CareerScreen.InfoColumn(Godot.Container)`](CareerClubPresentation.cs.md#symbol-f603281ab648)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.InfoColumn(Godot.Container)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(Text(title, 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(Text(title, 16, _muted));`
- `NationalSpire.CareerScreen.InfoColumn(Godot.Container)`；输入表达式：`InfoColumn(parent)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = InfoColumn(parent)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, 16, _muted)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b07f4ae318bc"></a>

## `NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[]) — private void StatStrip(Container parent, Color color, params (string Title, string Value)[] stats)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AchievementOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-f467edff90d1)；[`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-7094bac60c25)；[`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubPracticePreview(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.ClubSigning, bool)`](OwnedClubScreen.cs.md#symbol-db042267110f)；[`NationalSpire.CareerScreen.ClubSummary(NationalSpire.CareerData, NationalSpire.CareerClub, Godot.Container)`](CareerWorldScreen.cs.md#symbol-119e71d5db33)；[`NationalSpire.CareerScreen.PracticeRules(Godot.Container)`](CareerClubPresentation.cs.md#symbol-e9f9acda2cd5)；[`Terms(Godot.VBoxContainer, NationalSpire.SponsorContract, bool)`](CircuitScreen.cs.md#symbol-f6f24e76befe)

**调用：** [`NationalSpire.CareerScreen.InfoColumn(Godot.Container)`](CareerClubPresentation.cs.md#symbol-f603281ab648)；[`NationalSpire.CareerScreen.InfoRow(Godot.Container)`](CareerClubPresentation.cs.md#symbol-86ece89f239d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildCount(bool)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `(string Title, string Value).Title`；`(string Title, string Value).Value`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.InfoColumn(Godot.Container)`；`NationalSpire.CareerScreen.InfoRow(Godot.Container)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("385264")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new Color("385264")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Color = new Color("385264"), CustomMinimumSize = new(1,0), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new ColorRect { Color = new Color("385264"), CustomMinimumSize = new(1,0), MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(Text(stat.Title, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(Text(stat.Title, 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(Text(stat.Value, 20, color))`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(Text(stat.Value, 20, color));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new ColorRect { Color = new Color("385264"), CustomMinimumSize = new(1,0), MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new ColorRect { Color = new Color("385264"), CustomMinimumSize = new(1,0), MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`row.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: row.GetChildCount() > 0`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(1,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(1,0)`
- `NationalSpire.CareerScreen.InfoColumn(Godot.Container)`；输入表达式：`InfoColumn(row)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = InfoColumn(row)`
- `NationalSpire.CareerScreen.InfoRow(Godot.Container)`；输入表达式：`InfoRow(parent)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = InfoRow(parent)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(stat.Title, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(stat.Title, 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(stat.Value, 20, color)`；返回值紧邻使用处：`ArgumentSyntax: Text(stat.Value, 20, color)`

**赋值（含属性/字段和局部值）：**

- `Color` = `new Color("385264")`
- `CustomMinimumSize` = `new(1,0)`
- `MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-c2304b3521e0"></a>

## `NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string) — private static VBoxContainer FoldDetails(Container parent, Container buttons, string label)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AchievementOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-f467edff90d1)；[`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-7094bac60c25)；[`NationalSpire.CareerScreen.ClubSummary(NationalSpire.CareerData, NationalSpire.CareerClub, Godot.Container)`](CareerWorldScreen.cs.md#symbol-119e71d5db33)；[`NationalSpire.CareerScreen.PracticeRules(Godot.Container)`](CareerClubPresentation.cs.md#symbol-e9f9acda2cd5)；[`Terms(Godot.VBoxContainer, NationalSpire.SponsorContract, bool)`](CircuitScreen.cs.md#symbol-f6f24e76befe)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CareerDisclosureButton.CareerDisclosureButton()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerDisclosureButton.ArrowInset`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`toggle.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.QueueRedraw();`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`toggle.AddThemeFontSizeOverride("font_size",16)`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeFontSizeOverride("font_size",16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`toggle.AddThemeStyleboxOverride(state,padding)`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeStyleboxOverride(state,padding);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(toggle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(content);`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty { ContentMarginLeft=8, ContentMarginRight=32, ContentMarginTop=3, ContentMarginBottom=3 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StyleBoxEmpty { ContentMarginLeft=8, ContentMarginRight=32, ContentMarginTop=3, ContentMarginBottom=3 }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Visible = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Visible = false }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,36)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0,36)`
- `NationalSpire.CareerDisclosureButton.CareerDisclosureButton()`；输入表达式：`new CareerDisclosureButton { Text = label, Flat = true, ToggleMode = true, ArrowInset = 8,             Alignment = HorizontalAlignment.Left,             CustomMinimumSize = new(0,36), SizeFlagsHorizontal = SizeFlags.ShrinkBegin }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerDisclosureButton { Text = label, Flat = true, ToggleMode = true, ArrowInset = 8,             Alignment = HorizontalAlignment.Left,             CustomMinimumSize = new(0,36), SizeFlagsHorizontal = SizeFlags.ShrinkBegin }`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `HorizontalAlignment.Left`
- `ArrowInset` = `8`
- `content.Visible` = `open`
- `ContentMarginBottom` = `3`
- `ContentMarginLeft` = `8`
- `ContentMarginRight` = `32`
- `ContentMarginTop` = `3`
- `CustomMinimumSize` = `new(0,36)`
- `Flat` = `true`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `Text` = `label`
- `toggle.Toggled` += `open => { content.Visible=open; toggle.QueueRedraw(); }`
- `ToggleMode` = `true`
- `Visible` = `false`

<a id="symbol-e9f9acda2cd5"></a>

## `NationalSpire.CareerScreen.PracticeRules(Godot.Container) — private void PracticeRules(Container parent)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.RosterMembers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](ClubRosterScreen.cs.md#symbol-9ed06d3d7953)

**调用：** [`NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string)`](CareerClubPresentation.cs.md#symbol-c2304b3521e0)；[`NationalSpire.CareerScreen.InfoRow(Godot.Container)`](CareerClubPresentation.cs.md#symbol-86ece89f239d)；[`NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`](CareerClubPresentation.cs.md#symbol-b07f4ae318bc)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string)`；`NationalSpire.CareerScreen.InfoRow(Godot.Container)`；`NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`more.AddChild(Text("轮换、青训分组计算，各组按陪练贡献排序。",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: more.AddChild(Text("轮换、青训分组计算，各组按陪练贡献排序。",16,_muted));`
- `NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string)`；输入表达式：`FoldDetails(parent,bar,"陪练贡献")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FoldDetails(parent,bar,"陪练贡献")`
- `NationalSpire.CareerScreen.InfoRow(Godot.Container)`；输入表达式：`InfoRow(parent)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = InfoRow(parent)`
- `NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`；输入表达式：`StatStrip(more,_ink,("组内前 3 名","100%"),("第 4 名","约 30%"),("第 5 名","约 16%"),("此后","逐人递减"))`；返回值紧邻使用处：`ExpressionStatementSyntax: StatStrip(more,_ink,("组内前 3 名","100%"),("第 4 名","约 30%"),("第 5 名","约 16%"),("此后","逐人递减"));`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("轮换、青训分组计算，各组按陪练贡献排序。",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("轮换、青训分组计算，各组按陪练贡献排序。",16,_muted)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2970a082b74e"></a>

## `NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool) — private HBoxContainer SponsorLine(string title, string badge, string first, string second, Color color, bool heading=false)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AchievementOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-f467edff90d1)；[`NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-7094bac60c25)；[`NationalSpire.CareerScreen.ClubSummary(NationalSpire.CareerData, NationalSpire.CareerClub, Godot.Container)`](CareerWorldScreen.cs.md#symbol-119e71d5db33)；[`Reward(string, int, int)`](CareerClubPresentation.cs.md#symbol-981a77e0f241)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.InfoRow(Godot.Container)`](CareerClubPresentation.cs.md#symbol-86ece89f239d)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.InfoRow(Godot.Container)`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation",12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter=MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter=MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`brand.AddChild(DashboardLabel(badge,15,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: brand.AddChild(DashboardLabel(badge,15,CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`brand.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: brand.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(field)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(field);`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(badge,15,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(badge,15,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(title,heading?16:19,color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel(title,heading?16:19,color)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(value,heading?16:19,color,true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(value,heading?16:19,color,true)`
- `NationalSpire.CareerScreen.InfoRow(Godot.Container)`；输入表达式：`InfoRow(line)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = InfoRow(line)`

**赋值（含属性/字段和局部值）：**

- `brand.SizeFlagsStretchRatio` = `1.7f`
- `field.HorizontalAlignment` = `HorizontalAlignment.Right`
- `field.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `name.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`

<a id="symbol-7094bac60c25"></a>

## `NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState) — private void ClubBrandOffers(CareerData d, OwnedClubState o)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)

**调用：** [`Current(NationalSpire.OwnedSponsor)`](CareerClubPresentation.cs.md#symbol-83d594c8cf60)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`](OwnedClubScreen.cs.md#symbol-9c161e058b4e)；[`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`](OwnedClubScreen.cs.md#symbol-dea530bc8e29)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string)`](CareerClubPresentation.cs.md#symbol-c2304b3521e0)；[`NationalSpire.CareerScreen.Hairline(string)`](DashboardControls.cs.md#symbol-bf15f4abfdcb)；[`NationalSpire.CareerScreen.InfoColumn(Godot.Container)`](CareerClubPresentation.cs.md#symbol-f603281ab648)；[`NationalSpire.CareerScreen.InfoRow(Godot.Container)`](CareerClubPresentation.cs.md#symbol-86ece89f239d)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`](CareerClubPresentation.cs.md#symbol-2970a082b74e)；[`NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`](CareerClubPresentation.cs.md#symbol-b07f4ae318bc)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`](ClubAudience.cs.md#symbol-6a78e48d0de3)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-fb2b56604db1)；[`NationalSpire.RegionalOrganizations.SponsorDescription(string)`](RegionalOrganizations.cs.md#symbol-421e3c666278)；[`StaticLine(Godot.Control)`](CareerClubPresentation.cs.md#symbol-95d1a55971b4)；[`Weekly(NationalSpire.OwnedSponsor)`](CareerClubPresentation.cs.md#symbol-44e04f0629c0)；[`Win(NationalSpire.OwnedSponsor)`](CareerClubPresentation.cs.md#symbol-bd93a36f55ec)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(string id, NationalSpire.OwnedSponsor offer).offer`；`Current(NationalSpire.OwnedSponsor)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；`NationalSpire.CareerScreen.CanManageClub`；`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string)`；`NationalSpire.CareerScreen.Hairline(string)`；`NationalSpire.CareerScreen.InfoColumn(Godot.Container)`；`NationalSpire.CareerScreen.InfoRow(Godot.Container)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`；`NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.NextSponsor`；`NationalSpire.OwnedClubState.Sponsor`；`NationalSpire.OwnedSponsor.Brand`；`NationalSpire.OwnedSponsor.EndDay`；`NationalSpire.RegionalOrganizations.SponsorDescription(string)`；`StaticLine(Godot.Control)`；`Weekly(NationalSpire.OwnedSponsor)`；`Win(NationalSpire.OwnedSponsor)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Current(NationalSpire.OwnedSponsor)`；输入表达式：`Current(s)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Current(s)`
- `Current(NationalSpire.OwnedSponsor)`；输入表达式：`Current(v.offer)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: v=>Current(v.offer)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Hairline())`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Hairline());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`brands.AddChild(Text(s.Brand+" · "+RegionalOrganizations.SponsorDescription(s.Brand),16,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: brands.AddChild(Text(s.Brand+" · "+RegionalOrganizations.SponsorDescription(s.Brand),16,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`head.AddChild(end)`；返回值紧邻使用处：`ExpressionStatementSyntax: head.AddChild(end);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`InfoColumn(footer).AddChild(Text("8 周一约 · 到期自动续约",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: InfoColumn(footer).AddChild(Text("8 周一约 · 到期自动续约",16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`InfoColumn(head).AddChild(Text("俱乐部品牌赞助",25,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: InfoColumn(head).AddChild(Text("俱乐部品牌赞助",25,_ink));`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(Weekly(active))`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Format(Weekly(active))`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(Weekly(s))`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Format(Weekly(s))`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(Win(active))`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Format(Win(active))`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(Win(s))`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Format(Win(s))`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(box,"ClubSponsor_"+id,s.Brand,()=>ShowCareerDialog(active==null?"确认赞助":"确认下期赞助",                 active==null?"选择 "+s.Brand+"？":"选择 "+s.Brand+"？当前合同按期执行。",()=>{ ClubAction(d,"sponsor",target:id);return true; }),                 line,48,14,6,next?"203e43":"162a37",next?"63b7b2":"344b58","24414d")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ActionRow(box,"ClubSponsor_"+id,s.Brand,()=>ShowCareerDialog(active==null?"确认赞助":"确认下期赞助",                 active==null?"选择 "+s.Brand+"？":"选择 "+s.Brand+"？当前合同按期执行。",()=>{ ClubAction(d,"sponsor",target:id);return true; }),                 line,48,14,6,next?"203e43":"162a37",next?"63b7b2":"344b58","24414d")`
- `NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；输入表达式：`ClubAction(d,"sponsor",target:id)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubAction(d,"sponsor",target:id);`
- `NationalSpire.CareerScreen.ClubCard(string, string?, bool)`；输入表达式：`ClubCard("")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ClubCard("")`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("本期至 "+GameCalendar.Text(d,active.EndDay),16,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel("本期至 "+GameCalendar.Text(d,active.EndDay),16,_muted)`
- `NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string)`；输入表达式：`FoldDetails(box,footer,"结算说明")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FoldDetails(box,footer,"结算说明")`
- `NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string)`；输入表达式：`FoldDetails(box,footer,"品牌介绍")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FoldDetails(box,footer,"品牌介绍")`
- `NationalSpire.CareerScreen.Hairline(string)`；输入表达式：`Hairline()`；返回值紧邻使用处：`ArgumentSyntax: Hairline()`
- `NationalSpire.CareerScreen.InfoColumn(Godot.Container)`；输入表达式：`InfoColumn(footer)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: InfoColumn(footer).AddChild`
- `NationalSpire.CareerScreen.InfoColumn(Godot.Container)`；输入表达式：`InfoColumn(head)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: InfoColumn(head).AddChild`
- `NationalSpire.CareerScreen.InfoRow(Godot.Container)`；输入表达式：`InfoRow(box)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =InfoRow(box)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog(active==null?"确认赞助":"确认下期赞助",                 active==null?"选择 "+s.Brand+"？":"选择 "+s.Brand+"？当前合同按期执行。",()=>{ ClubAction(d,"sponsor",target:id);return true; })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>ShowCareerDialog(active==null?"确认赞助":"确认下期赞助",                 active==null?"选择 "+s.Brand+"？":"选择 "+s.Brand+"？当前合同按期执行。",()=>{ ClubAction(d,"sponsor",target:id);return true; })`
- `NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`；输入表达式：`SponsorLine(active.Brand,"本期",CareerMoney.Format(Weekly(active)),CareerMoney.Format(Win(active)),_ink)`；返回值紧邻使用处：`ArgumentSyntax: SponsorLine(active.Brand,"本期",CareerMoney.Format(Weekly(active)),CareerMoney.Format(Win(active)),_ink)`
- `NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`；输入表达式：`SponsorLine(active==null?"选择合作品牌":"选择下期品牌","", "预计周收入","预计每胜奖金",_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: SponsorLine(active==null?"选择合作品牌":"选择下期品牌","", "预计周收入","预计每胜奖金",_muted,true)`
- `NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`；输入表达式：`SponsorLine(s.Brand,badge,CareerMoney.Format(Weekly(s)),CareerMoney.Format(Win(s)),_ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =SponsorLine(s.Brand,badge,CareerMoney.Format(Weekly(s)),CareerMoney.Format(Win(s)),_ink)`
- `NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`；输入表达式：`StatStrip(settlement,_ink,("表中报价","按当前俱乐部关注数估算"),("实际收入","按付款时的俱乐部关注数结算"))`；返回值紧邻使用处：`ExpressionStatementSyntax: StatStrip(settlement,_ink,("表中报价","按当前俱乐部关注数估算"),("实际收入","按付款时的俱乐部关注数结算"));`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("8 周一约 · 到期自动续约",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("8 周一约 · 到期自动续约",16,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("俱乐部品牌赞助",25,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("俱乐部品牌赞助",25,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(s.Brand+" · "+RegionalOrganizations.SponsorDescription(s.Brand),16,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(s.Brand+" · "+RegionalOrganizations.SponsorDescription(s.Brand),16,_ink)`
- `NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；输入表达式：`ClubAudience.Total(d,o.ClubId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ClubAudience.Total(d,o.ClubId)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d,active.EndDay)`；返回值紧邻使用处：`BinaryExpressionSyntax: "本期至 "+GameCalendar.Text(d,active.EndDay)`
- `NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.SponsorQuote(d,id)`；返回值紧邻使用处：`ArgumentSyntax: offer:OwnedClubs.SponsorQuote(d,id)`
- `NationalSpire.RegionalOrganizations.SponsorDescription(string)`；输入表达式：`RegionalOrganizations.SponsorDescription(s.Brand)`；返回值紧邻使用处：`BinaryExpressionSyntax: s.Brand+" · "+RegionalOrganizations.SponsorDescription(s.Brand)`
- `StaticLine(Godot.Control)`；输入表达式：`StaticLine(SponsorLine(active.Brand,"本期",CareerMoney.Format(Weekly(active)),CareerMoney.Format(Win(active)),_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: StaticLine(SponsorLine(active.Brand,"本期",CareerMoney.Format(Weekly(active)),CareerMoney.Format(Win(active)),_ink));`
- `StaticLine(Godot.Control)`；输入表达式：`StaticLine(SponsorLine(active==null?"选择合作品牌":"选择下期品牌","", "预计周收入","预计每胜奖金",_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: StaticLine(SponsorLine(active==null?"选择合作品牌":"选择下期品牌","", "预计周收入","预计每胜奖金",_muted,true));`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("  ",new[]{current?"本期":"",next?"下期已选":""}.Where(t=>t.Length>0))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =string.Join("  ",new[]{current?"本期":"",next?"下期已选":""}.Where(t=>t.Length>0))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Any(v=>Current(v.offer))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !offers.Any(v=>Current(v.offer))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`new[]{"steady","results","fans"}.Select(id=>(id,offer:OwnedClubs.SponsorQuote(d,id)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[]{"steady","results","fans"}.Select(id=>(id,offer:OwnedClubs.SponsorQuote(d,id))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[]{"steady","results","fans"}.Select(id=>(id,offer:OwnedClubs.SponsorQuote(d,id))).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new[]{"steady","results","fans"}.Select(id=>(id,offer:OwnedClubs.SponsorQuote(d,id))).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[]{current?"本期":"",next?"下期已选":""}.Where(t=>t.Length>0)`；返回值紧邻使用处：`ArgumentSyntax: new[]{current?"本期":"",next?"下期已选":""}.Where(t=>t.Length>0)`
- `Weekly(NationalSpire.OwnedSponsor)`；输入表达式：`Weekly(active)`；返回值紧邻使用处：`ArgumentSyntax: Weekly(active)`
- `Weekly(NationalSpire.OwnedSponsor)`；输入表达式：`Weekly(s)`；返回值紧邻使用处：`ArgumentSyntax: Weekly(s)`
- `Win(NationalSpire.OwnedSponsor)`；输入表达式：`Win(active)`；返回值紧邻使用处：`ArgumentSyntax: Win(active)`
- `Win(NationalSpire.OwnedSponsor)`；输入表达式：`Win(s)`；返回值紧邻使用处：`ArgumentSyntax: Win(s)`

**赋值（含属性/字段和局部值）：**

- `button.Disabled` = `!CanManageClub`
- `button.TooltipText` = `"由房主管理俱乐部"`
- `end.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`

<a id="symbol-44e04f0629c0"></a>

## `Weekly(NationalSpire.OwnedSponsor) — int Weekly(OwnedSponsor s)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Current(NationalSpire.OwnedSponsor)`](CareerClubPresentation.cs.md#symbol-83d594c8cf60)；[`NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-7094bac60c25)

**调用：** [`NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`](OwnedClubs.cs.md#symbol-c9d09ed04c48)

**字段、属性、事件及方法组引用：** `NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`；输入表达式：`OwnedClubs.SponsorWeekly(s,fans)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>OwnedClubs.SponsorWeekly(s,fans)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bd93a36f55ec"></a>

## `Win(NationalSpire.OwnedSponsor) — int Win(OwnedSponsor s)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Current(NationalSpire.OwnedSponsor)`](CareerClubPresentation.cs.md#symbol-83d594c8cf60)；[`NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-7094bac60c25)

**调用：** [`NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int)`](OwnedClubs.cs.md#symbol-27e3d96628f4)

**字段、属性、事件及方法组引用：** `NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int)`；输入表达式：`OwnedClubs.SponsorWinBonus(s,fans)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>OwnedClubs.SponsorWinBonus(s,fans)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-83d594c8cf60"></a>

## `Current(NationalSpire.OwnedSponsor) — bool Current(OwnedSponsor s)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-7094bac60c25)

**调用：** [`Weekly(NationalSpire.OwnedSponsor)`](CareerClubPresentation.cs.md#symbol-44e04f0629c0)；[`Win(NationalSpire.OwnedSponsor)`](CareerClubPresentation.cs.md#symbol-bd93a36f55ec)

**字段、属性、事件及方法组引用：** `NationalSpire.OwnedSponsor.Brand`；`Weekly(NationalSpire.OwnedSponsor)`；`Win(NationalSpire.OwnedSponsor)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Weekly(NationalSpire.OwnedSponsor)`；输入表达式：`Weekly(active)`；返回值紧邻使用处：`BinaryExpressionSyntax: Weekly(s)==Weekly(active)`
- `Weekly(NationalSpire.OwnedSponsor)`；输入表达式：`Weekly(s)`；返回值紧邻使用处：`BinaryExpressionSyntax: Weekly(s)==Weekly(active)`
- `Win(NationalSpire.OwnedSponsor)`；输入表达式：`Win(active)`；返回值紧邻使用处：`BinaryExpressionSyntax: Win(s)==Win(active)`
- `Win(NationalSpire.OwnedSponsor)`；输入表达式：`Win(s)`；返回值紧邻使用处：`BinaryExpressionSyntax: Win(s)==Win(active)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-95d1a55971b4"></a>

## `StaticLine(Godot.Control) — void StaticLine(Control line)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-7094bac60c25)

**调用：** [`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Inset(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(line);`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(14,4)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inset(14,4)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f467edff90d1"></a>

## `NationalSpire.CareerScreen.AchievementOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState) — private void AchievementOffers(CareerData d, OwnedClubState o)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`](OwnedClubScreen.cs.md#symbol-dea530bc8e29)；[`NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string)`](CareerClubPresentation.cs.md#symbol-c2304b3521e0)；[`NationalSpire.CareerScreen.InfoRow(Godot.Container)`](CareerClubPresentation.cs.md#symbol-86ece89f239d)；[`NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`](CareerClubPresentation.cs.md#symbol-2970a082b74e)；[`NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`](CareerClubPresentation.cs.md#symbol-b07f4ae318bc)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.OwnedClubs.AchievementWeekly(NationalSpire.CareerData, int?)`](OwnedClubs.cs.md#symbol-6261fe2caa42)；[`NationalSpire.OwnedClubs.PlacementReward(string, int)`](OwnedClubs.cs.md#symbol-5451d41611c1)；[`Reward(string, int, int)`](CareerClubPresentation.cs.md#symbol-981a77e0f241)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(int Fans, int Weekly).Fans`；`(int Fans, int Weekly).Weekly`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`；`NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string)`；`NationalSpire.CareerScreen.InfoRow(Godot.Container)`；`NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`；`NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.OwnedAchievementSponsor.EndDay`；`NationalSpire.OwnedAchievementSponsor.StartDay`；`NationalSpire.OwnedAchievementSponsor.Title`；`NationalSpire.OwnedAchievementSponsor.Weekly`；`NationalSpire.OwnedClubs.AchievementWeekly(NationalSpire.CareerData, int?)`；`NationalSpire.OwnedClubs.PlacementReward(string, int)`；`NationalSpire.OwnedClubState.AchievementSponsors`；`Reward(string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(SponsorLine("有效赞助","","每周金额","到期日",_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(SponsorLine("有效赞助","","每周金额","到期日",_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(SponsorLine(deal.Title,"",CareerMoney.Format(deal.Weekly),GameCalendar.Text(d,deal.EndDay),_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(SponsorLine(deal.Title,"",CareerMoney.Format(deal.Weekly),GameCalendar.Text(d,deal.EndDay),_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rules.AddChild(SponsorLine("达成成绩","","增加关注","每周金额",_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: rules.AddChild(SponsorLine("达成成绩","","增加关注","每周金额",_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rules.AddChild(Text("联赛连胜奖励每季每档一次。签约奖为每周金额的两倍。",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: rules.AddChild(Text("联赛连胜奖励每季每档一次。签约奖为每周金额的两倍。",16,_muted));`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(deal.Weekly)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Format(deal.Weekly)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(OwnedClubs.AchievementWeekly(d))`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Format(OwnedClubs.AchievementWeekly(d))`
- `NationalSpire.CareerScreen.ClubCard(string, string?, bool)`；输入表达式：`ClubCard("成绩赞助")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ClubCard("成绩赞助")`
- `NationalSpire.CareerScreen.FoldDetails(Godot.Container, Godot.Container, string)`；输入表达式：`FoldDetails(box,bar,"查看奖励规则")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FoldDetails(box,bar,"查看奖励规则")`
- `NationalSpire.CareerScreen.InfoRow(Godot.Container)`；输入表达式：`InfoRow(box)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =InfoRow(box)`
- `NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`；输入表达式：`SponsorLine("达成成绩","","增加关注","每周金额",_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: SponsorLine("达成成绩","","增加关注","每周金额",_muted,true)`
- `NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`；输入表达式：`SponsorLine("有效赞助","","每周金额","到期日",_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: SponsorLine("有效赞助","","每周金额","到期日",_muted,true)`
- `NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`；输入表达式：`SponsorLine(deal.Title,"",CareerMoney.Format(deal.Weekly),GameCalendar.Text(d,deal.EndDay),_ink)`；返回值紧邻使用处：`ArgumentSyntax: SponsorLine(deal.Title,"",CareerMoney.Format(deal.Weekly),GameCalendar.Text(d,deal.EndDay),_ink)`
- `NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`；输入表达式：`StatStrip(box,_gold,("本周按最高一档领取",CareerMoney.Format(OwnedClubs.AchievementWeekly(d))),("每份期限","8 周"))`；返回值紧邻使用处：`ExpressionStatementSyntax: StatStrip(box,_gold,("本周按最高一档领取",CareerMoney.Format(OwnedClubs.AchievementWeekly(d))),("每份期限","8 周"));`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("联赛连胜奖励每季每档一次。签约奖为每周金额的两倍。",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("联赛连胜奖励每季每档一次。签约奖为每周金额的两倍。",16,_muted)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d,deal.EndDay)`；返回值紧邻使用处：`ArgumentSyntax: GameCalendar.Text(d,deal.EndDay)`
- `NationalSpire.OwnedClubs.AchievementWeekly(NationalSpire.CareerData, int?)`；输入表达式：`OwnedClubs.AchievementWeekly(d)`；返回值紧邻使用处：`ArgumentSyntax: OwnedClubs.AchievementWeekly(d)`
- `NationalSpire.OwnedClubs.PlacementReward(string, int)`；输入表达式：`OwnedClubs.PlacementReward(kind,rank)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OwnedClubs.PlacementReward(kind,rank)`
- `Reward(string, int, int)`；输入表达式：`Reward("联赛三连胜",600,300)`；返回值紧邻使用处：`ExpressionStatementSyntax: Reward("联赛三连胜",600,300);`
- `Reward(string, int, int)`；输入表达式：`Reward("联赛五连胜",1200,600)`；返回值紧邻使用处：`ExpressionStatementSyntax: Reward("联赛五连胜",1200,600);`
- `Reward(string, int, int)`；输入表达式：`Reward((kind=="league"?"联赛 · ":"洲际赛 · ")+stage,reward.Fans,reward.Weekly)`；返回值紧邻使用处：`ExpressionStatementSyntax: Reward((kind=="league"?"联赛 · ":"洲际赛 · ")+stage,reward.Fans,reward.Weekly);`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`o.AchievementSponsors.Where(s=>s.StartDay<=d.Day && s.EndDay>d.Day).OrderByDescending(s=>s.Weekly)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.AchievementSponsors.Where(s=>s.StartDay<=d.Day && s.EndDay>d.Day).OrderByDescending(s=>s.Weekly).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`o.AchievementSponsors.Where(s=>s.StartDay<=d.Day && s.EndDay>d.Day).OrderByDescending(s=>s.Weekly).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =o.AchievementSponsors.Where(s=>s.StartDay<=d.Day && s.EndDay>d.Day).OrderByDescending(s=>s.Weekly).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.AchievementSponsors.Where(s=>s.StartDay<=d.Day && s.EndDay>d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.AchievementSponsors.Where(s=>s.StartDay<=d.Day && s.EndDay>d.Day).OrderByDescending`

**赋值（含属性/字段和局部值）：**


<a id="symbol-981a77e0f241"></a>

## `Reward(string, int, int) — void Reward(string title,int fans,int weekly)`

来源：源码第 107 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AchievementOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-f467edff90d1)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`](CareerClubPresentation.cs.md#symbol-2970a082b74e)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rules.AddChild(SponsorLine(title,"",$"+{fans:N0}",CareerMoney.Format(weekly),_ink))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>rules.AddChild(SponsorLine(title,"",$"+{fans:N0}",CareerMoney.Format(weekly),_ink))`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(weekly)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Format(weekly)`
- `NationalSpire.CareerScreen.SponsorLine(string, string, string, string, Godot.Color, bool)`；输入表达式：`SponsorLine(title,"",$"+{fans:N0}",CareerMoney.Format(weekly),_ink)`；返回值紧邻使用处：`ArgumentSyntax: SponsorLine(title,"",$"+{fans:N0}",CareerMoney.Format(weekly),_ink)`

**赋值（含属性/字段和局部值）：**
