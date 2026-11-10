# OpeningWorldEditor.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`DA20930BAA1CF393EDDD1A974575006E986E5EFEC58C35416DAB317CA4B6E10F`。来源：[源码](../../OpeningWorldEditor.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OpeningWorldEditor`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-8745b893c0a1"></a>

## `NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld, string) — internal static Action<string> Draw(VBoxContainer parent, CareerOpeningWorld world,string region="中国")`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawDraft()`](NpcGenerationScreen.cs.md#symbol-d79d22cd9ca9)

**调用：** [`Field(string)`](OpeningWorldEditor.cs.md#symbol-21822c8432b7)；[`Nation()`](OpeningWorldEditor.cs.md#symbol-171a8e241cb0)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`](OpeningControls.cs.md#symbol-93105b3962ff)；[`NationalSpire.OpeningControls.Field(Godot.Container, string)`](OpeningControls.cs.md#symbol-bd0e4ff57612)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；[`NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`](OpeningControls.cs.md#symbol-c7ec3402431e)；[`Terms()`](OpeningWorldEditor.cs.md#symbol-594d83774a62)；`Godot.ButtonGroup.ButtonGroup()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.SpinBox.SpinBox()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`

**字段、属性、事件及方法组引用：** `Field(string)`；`Nation()`；`NationalSpire.CareerOpeningWorld.ClubCountry`；`NationalSpire.CareerOpeningWorld.ClubMode`；`NationalSpire.CareerOpeningWorld.ClubName`；`NationalSpire.CareerOpeningWorld.ClubSelection.Country`；`NationalSpire.CareerOpeningWorld.ClubSelection.Name`；`NationalSpire.CareerOpeningWorld.ClubSponsor`；`NationalSpire.CareerOpeningWorld.JoiningClub`；`NationalSpire.CareerOpeningWorld.Levels`；`NationalSpire.CareerOpeningWorld.Season`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；`NationalSpire.OpeningControls.Field(Godot.Container, string)`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；`NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`；`Terms()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(string)`；输入表达式：`Field("参赛身份")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Field("参赛身份")`
- `Field(string)`；输入表达式：`Field("加入赛季")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Field("加入赛季").AddChild`
- `Godot.ButtonGroup.ButtonGroup()`；输入表达式：`new ButtonGroup()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ButtonGroup()`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation",18)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation",18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`join.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: join.AddThemeConstantOverride("separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",18)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",18);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer{Columns=3}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new GridContainer{Columns=3}`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HFlowContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit{Text=world.ClubName,PlaceholderText="俱乐部名称"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LineEdit{Text=world.ClubName,PlaceholderText="俱乐部名称"}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(extras)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(extras);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(join)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(join);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`clubField.AddChild(modes)`；返回值紧邻使用处：`ExpressionStatementSyntax: clubField.AddChild(modes);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`countries.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: countries.AddChild(b);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`expanded.AddChild(countries)`；返回值紧邻使用处：`ExpressionStatementSyntax: expanded.AddChild(countries);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`expanded.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: expanded.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`expanded.AddChild(OpeningControls.Label("每项默认随世界发展。拖动滑块指定加入生涯时的等级，点击还原可恢复自然发展。"))`；返回值紧邻使用处：`ExpressionStatementSyntax: expanded.AddChild(OpeningControls.Label("每项默认随世界发展。拖动滑块指定加入生涯时的等级，点击还原可恢复自然发展。"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`extras.AddChild(terms)`；返回值紧邻使用处：`ExpressionStatementSyntax: extras.AddChild(terms);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Field("加入赛季").AddChild(season)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field("加入赛季").AddChild(season);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`join.AddChild(CareerScreen.Glyph("flag",22,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: join.AddChild(CareerScreen.Glyph("flag",22,CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`join.AddChild(team)`；返回值紧邻使用处：`ExpressionStatementSyntax: join.AddChild(team);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`OpeningControls.Field(extras,"队名").AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Field(extras,"队名").AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`OpeningControls.Field(extras,"建队赞助").AddChild(sponsors)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Field(extras,"建队赞助").AddChild(sponsors);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`OpeningControls.Field(extras,"俱乐部赛区").AddChild(regions)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Field(extras,"俱乐部赛区").AddChild(regions);`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox{MinValue=1,MaxValue=100,AllowGreater=true,Step=1,Value=world.Season,CustomMinimumSize=new(120,40)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new SpinBox{MinValue=1,MaxValue=100,AllowGreater=true,Step=1,Value=world.Season,CustomMinimumSize=new(120,40)}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(120,40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(120,40)`
- `Nation()`；输入表达式：`Nation()`；返回值紧邻使用处：`ExpressionStatementSyntax: Nation();`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton{Text=n,ToggleMode=true,ButtonGroup=tabs,ButtonPressed=n==chosen}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastButton{Text=n,ToggleMode=true,ButtonGroup=tabs,ButtonPressed=n==chosen}`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`CareerScreen.Glyph("flag",22,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: CareerScreen.Glyph("flag",22,CareerVisuals.Teal)`
- `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；输入表达式：`OpeningControls.Chip(modes,group,label,world.ClubMode==id,()=>{world.ClubMode=id;extras.Visible=id=="自建";join.Visible=id=="加盟";})`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Chip(modes,group,label,world.ClubMode==id,()=>{world.ClubMode=id;extras.Visible=id=="自建";join.Visible=id=="加盟";});`
- `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；输入表达式：`OpeningControls.Chip(regions,regionGroup,n,n==(world.ClubCountry.Length==0?region:world.ClubCountry),()=>{world.ClubCountry=n;Terms();})`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: n=>OpeningControls.Chip(regions,regionGroup,n,n==(world.ClubCountry.Length==0?region:world.ClubCountry),()=>{world.ClubCountry=n;Terms();})`
- `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；输入表达式：`OpeningControls.Chip(sponsors,sponsorGroup,label,id==world.ClubSponsor,()=>{world.ClubSponsor=id;Terms();})`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Chip(sponsors,sponsorGroup,label,id==world.ClubSponsor,()=>{world.ClubSponsor=id;Terms();});`
- `NationalSpire.OpeningControls.Field(Godot.Container, string)`；输入表达式：`OpeningControls.Field(extras,"队名")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OpeningControls.Field(extras,"队名").AddChild`
- `NationalSpire.OpeningControls.Field(Godot.Container, string)`；输入表达式：`OpeningControls.Field(extras,"建队赞助")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OpeningControls.Field(extras,"建队赞助").AddChild`
- `NationalSpire.OpeningControls.Field(Godot.Container, string)`；输入表达式：`OpeningControls.Field(extras,"俱乐部赛区")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OpeningControls.Field(extras,"俱乐部赛区").AddChild`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OpeningControls.Label("")`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("每项默认随世界发展。拖动滑块指定加入生涯时的等级，点击还原可恢复自然发展。")`；返回值紧邻使用处：`ArgumentSyntax: OpeningControls.Label("每项默认随世界发展。拖动滑块指定加入生涯时的等级，点击还原可恢复自然发展。")`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label(world.JoiningClub is { } c?$"{c.Name}  ·  {c.Country}赛区":"开始时选择俱乐部",20,CareerVisuals.Ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OpeningControls.Label(world.JoiningClub is { } c?$"{c.Name}  ·  {c.Country}赛区":"开始时选择俱乐部",20,CareerVisuals.Ink)`
- `NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`；输入表达式：`OpeningControls.Section(parent,"各国初始发展水平","landmark","经济 · 社会 · 民生",world.Levels.Count>0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OpeningControls.Section(parent,"各国初始发展水平","landmark","经济 · 社会 · 民生",world.Levels.Count>0)`
- `NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`；输入表达式：`OpeningControls.Section(parent,"赛季与俱乐部","trophy","加入时间 · 参赛身份",true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OpeningControls.Section(parent,"赛季与俱乐部","trophy","加入时间 · 参赛身份",true)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`regionButtons.TryGetValue(n,out var current)`；返回值紧邻使用处：`BinaryExpressionSyntax: world.ClubCountry.Length==0 && regionButtons.TryGetValue(n,out var current)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`EsportsWorld.Countries.ToDictionary(n=>n,n=>OpeningControls.Chip(regions,regionGroup,n,n==(world.ClubCountry.Length==0?region:world.ClubCountry),()=>{world.ClubCountry=n;Terms();}))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EsportsWorld.Countries.ToDictionary(n=>n,n=>OpeningControls.Chip(regions,regionGroup,n,n==(world.ClubCountry.Length==0?region:world.ClubCountry),()=>{world.ClubCountry=n;Terms();}))`
- `Terms()`；输入表达式：`Terms()`；返回值紧邻使用处：`ExpressionStatementSyntax: Terms();`

**赋值（含属性/字段和局部值）：**

- `AllowGreater` = `true`
- `b.Pressed` += `()=>{chosen=n;Nation();}`
- `ButtonGroup` = `tabs`
- `ButtonPressed` = `n==chosen`
- `chosen` = `n`
- `clubField.SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Columns` = `3`
- `current.ButtonPressed` = `true`
- `CustomMinimumSize` = `new(120,40)`
- `extras.Visible` = `id=="自建"`
- `extras.Visible` = `world.ClubMode=="自建"`
- `join.Visible` = `id=="加盟"`
- `join.Visible` = `world.ClubMode=="加盟"`
- `MaxValue` = `100`
- `MinValue` = `1`
- `name.TextChanged` += `v=>world.ClubName=v`
- `PlaceholderText` = `"俱乐部名称"`
- `region` = `n`
- `season.ValueChanged` += `v=>world.Season=(int)v`
- `Step` = `1`
- `team.SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Text` = `n`
- `Text` = `world.ClubName`
- `ToggleMode` = `true`
- `Value` = `world.Season`
- `world.ClubCountry` = `n`
- `world.ClubMode` = `id`
- `world.ClubName` = `v`
- `world.ClubSponsor` = `id`
- `world.Season` = `(int)v`

<a id="symbol-21822c8432b7"></a>

## `Field(string) — VBoxContainer Field(string caption)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld, string)`](OpeningWorldEditor.cs.md#symbol-8745b893c0a1)

**调用：** `Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Label.Label()`；输入表达式：`new Label{Text=caption}`；返回值紧邻使用处：`ArgumentSyntax: new Label{Text=caption}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(new Label{Text=caption})`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(new Label{Text=caption});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(col)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(col);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`

**赋值（含属性/字段和局部值）：**

- `Text` = `caption`

<a id="symbol-594d83774a62"></a>

## `Terms() — void Terms()`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld, string)`](OpeningWorldEditor.cs.md#symbol-8745b893c0a1)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-fb2b56604db1)；`NationalSpire.CareerData.CareerData()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerOpeningWorld.ClubCountry`；`NationalSpire.CareerOpeningWorld.ClubSponsor`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；`NationalSpire.OwnedSponsor.Weekly`；`NationalSpire.OwnedSponsor.WinBonus`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerData.CareerData()`；输入表达式：`new CareerData()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CareerData()`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(offer.Weekly)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(offer.Weekly)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(offer.WinBonus)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(offer.WinBonus)}`
- `NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.SponsorQuote(d,world.ClubSponsor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OwnedClubs.SponsorQuote(d,world.ClubSponsor)`

**赋值（含属性/字段和局部值）：**

- `d.Esports.Country` = `world.ClubCountry.Length==0?region:world.ClubCountry`
- `terms.Text` = `"无赞助收入"`
- `terms.Text` = `$"每周支持 {CareerMoney.Format(offer.Weekly)}    胜场奖金 {CareerMoney.Format(offer.WinBonus)}"`

<a id="symbol-171a8e241cb0"></a>

## `Nation() — void Nation()`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld, string)`](OpeningWorldEditor.cs.md#symbol-8745b893c0a1)

**调用：** [`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`Set(int)`](OpeningWorldEditor.cs.md#symbol-c1f80735d1a7)；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSlider.HSlider()`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Range.SetValueNoSignal(double)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerOpeningWorld.Levels`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalDevelopment.Indicator.Name`；`Set(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider{MinValue=0,MaxValue=9,Step=1,TickCount=10,TicksOnBorders=true,Value=world.Levels.GetValueOrDefault(nation)?.GetValueOrDefault(indicator.Id)??0,CustomMinimumSize=new(115,34),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HSlider{MinValue=0,MaxValue=9,Step=1,TickCount=10,TicksOnBorders=true,Value=world.Levels.GetValueOrDefault(nation)?.GetValueOrDefault(indicator.Id)??0,CustomMinimumSize=new(115,34),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`
- `Godot.Label.Label()`；输入表达式：`new Label{Text=custom?$"{level.Value:0} 级":"自然",CustomMinimumSize=new(42,0)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Label{Text=custom?$"{level.Value:0} 级":"自然",CustomMinimumSize=new(42,0)}`
- `Godot.Label.Label()`；输入表达式：`new Label{Text=indicator.Name}`；返回值紧邻使用处：`ArgumentSyntax: new Label{Text=indicator.Name}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`field.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: field.AddChild(line);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`field.AddChild(new Label{Text=indicator.Name})`；返回值紧邻使用处：`ExpressionStatementSyntax: field.AddChild(new Label{Text=indicator.Name});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(field)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(field);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(level)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(level);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(readout)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(readout);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(reset)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(reset);`
- `Godot.Range.SetValueNoSignal(double)`；输入表达式：`level.SetValueNoSignal(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: level.SetValueNoSignal(0);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(115,34)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(115,34)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(42,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(42,0)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton{Text="还原",Disabled=!custom}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastButton{Text="还原",Disabled=!custom}`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(grid);`
- `Set(int)`；输入表达式：`Set((int)level.Value)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Set((int)level.Value)`
- `Set(int)`；输入表达式：`Set((int)v)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: v=>Set((int)v)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`levels.Remove(indicator.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: levels.Remove(indicator.Id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`world.Levels.Remove(nation)`；返回值紧邻使用处：`ExpressionStatementSyntax: world.Levels.Remove(nation);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`.TryGetValue(indicator.Id,out _)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: world.Levels.GetValueOrDefault(nation)?.TryGetValue(indicator.Id,out _)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`world.Levels.TryGetValue(nation,out var levels)`；返回值紧邻使用处：`IfStatementSyntax: if(world.Levels.TryGetValue(nation,out var levels)){levels.Remove(indicator.Id);if(levels.Count==0)world.Levels.Remove(nation);}`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(indicator.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: world.Levels.GetValueOrDefault(nation)?.GetValueOrDefault(indicator.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`world.Levels.GetValueOrDefault(nation)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: world.Levels.GetValueOrDefault(nation)?.GetValueOrDefault(indicator.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`world.Levels.GetValueOrDefault(nation)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: world.Levels.GetValueOrDefault(nation)?.TryGetValue(indicator.Id,out _)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(115,34)`
- `CustomMinimumSize` = `new(42,0)`
- `Disabled` = `!custom`
- `level.DragStarted` += `()=>Set((int)level.Value)`
- `level.ValueChanged` += `v=>Set((int)v)`
- `MaxValue` = `9`
- `MinValue` = `0`
- `readout.Text` = `"自然"`
- `reset.Disabled` = `true`
- `reset.Pressed` += `()=>{if(world.Levels.TryGetValue(nation,out var levels)){levels.Remove(indicator.Id);if(levels.Count==0)world.Levels.Remove(nation);}level.SetValueNoSignal(0);readout.Text="自然";reset.Disabled=true;}`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Step` = `1`
- `Text` = `"还原"`
- `Text` = `custom?$"{level.Value:0} 级":"自然"`
- `Text` = `indicator.Name`
- `TickCount` = `10`
- `TicksOnBorders` = `true`
- `Value` = `world.Levels.GetValueOrDefault(nation)?.GetValueOrDefault(indicator.Id)??0`

<a id="symbol-c1f80735d1a7"></a>

## `Set(int) — void Set(int value)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Nation()`](OpeningWorldEditor.cs.md#symbol-171a8e241cb0)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerOpeningWorld.Levels`；`NationalSpire.NationalDevelopment.Indicator.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`world.Levels.TryGetValue(nation,out var levels)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !world.Levels.TryGetValue(nation,out var levels)`

**赋值（含属性/字段和局部值）：**

- `levels[indicator.Id]` = `value`
- `levels` = `[]`
- `readout.Text` = `$"{value} 级"`
- `reset.Disabled` = `false`
- `world.Levels[nation]` = `levels=[]`
