# OpeningWorldEditor.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`7A6088AA25B62FE50A82BCF3A458805428F1911E67AE9E5C402C9BDEF3760775`。来源：[源码](../../OpeningWorldEditor.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OpeningWorldEditor`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-404e75faa99e"></a>

## `NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld) — internal static void Draw(VBoxContainer parent, CareerOpeningWorld world)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawDraft()`](NpcGenerationScreen.cs.md#symbol-d8cd8d2dd3cc)

**调用：** [`Choice(string, string[], string[], string, System.Action<string>)`](OpeningWorldEditor.cs.md#symbol-5ede24bd4b77)；[`Field(string)`](OpeningWorldEditor.cs.md#symbol-bcd948bf9319)；[`Nation()`](OpeningWorldEditor.cs.md#symbol-702d90a9c3b4)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.ButtonGroup.ButtonGroup()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GridContainer.GridContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Label.Label()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.SpinBox.SpinBox()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`；`NationalSpire.BroadcastPanel.BroadcastPanel()`；`NationalSpire.CareerDisclosureButton.CareerDisclosureButton()`

**字段、属性、事件及方法组引用：** `Choice(string, string[], string[], string, System.Action<string>)`；`Field(string)`；`Nation()`；`NationalSpire.BroadcastPanel.Accent`；`NationalSpire.CareerDisclosureButton.ArrowOnLeft`；`NationalSpire.CareerOpeningWorld.ClubCountry`；`NationalSpire.CareerOpeningWorld.ClubMode`；`NationalSpire.CareerOpeningWorld.ClubName`；`NationalSpire.CareerOpeningWorld.ClubSponsor`；`NationalSpire.CareerOpeningWorld.Levels`；`NationalSpire.CareerOpeningWorld.Season`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.EsportsWorld.Countries`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choice(string, string[], string[], string, System.Action<string>)`；输入表达式：`Choice("参赛地区",["沿用赛区",..EsportsWorld.Countries],["",..EsportsWorld.Countries],world.ClubCountry,v=>world.ClubCountry=v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("参赛地区",["沿用赛区",..EsportsWorld.Countries],["",..EsportsWorld.Countries],world.ClubCountry,v=>world.ClubCountry=v);`
- `Choice(string, string[], string[], string, System.Action<string>)`；输入表达式：`Choice("俱乐部",["自由选手","加盟现有俱乐部","创建俱乐部"],["","加盟","自建"],world.ClubMode,v=>{world.ClubMode=v;extras.Visible=v=="自建";})`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("俱乐部",["自由选手","加盟现有俱乐部","创建俱乐部"],["","加盟","自建"],world.ClubMode,v=>{world.ClubMode=v;extras.Visible=v=="自建";});`
- `Choice(string, string[], string[], string, System.Action<string>)`；输入表达式：`Choice("俱乐部赞助",["无赞助","稳定支持","成绩奖励","品牌推广"],["","steady","results","fans"],world.ClubSponsor,v=>world.ClubSponsor=v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("俱乐部赞助",["无赞助","稳定支持","成绩奖励","品牌推广"],["","steady","results","fans"],world.ClubSponsor,v=>world.ClubSponsor=v);`
- `Field(string)`；输入表达式：`Field("队名")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Field("队名").AddChild`
- `Field(string)`；输入表达式：`Field("加入赛季")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Field("加入赛季").AddChild`
- `Godot.ButtonGroup.ButtonGroup()`；输入表达式：`new ButtonGroup()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ButtonGroup()`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`heading.AddThemeColorOverride("font_color",CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddThemeColorOverride("font_color",CareerVisuals.Gold);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("h_separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("h_separation",12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152633","365565",10,16))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152633","365565",10,16));`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer{Columns=3}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new GridContainer{Columns=3}`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HFlowContainer()`
- `Godot.Label.Label()`；输入表达式：`new Label{Text="赛季与俱乐部"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Label{Text="赛季与俱乐部"}`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit{Text=world.ClubName,PlaceholderText="俱乐部名称",CustomMinimumSize=new(166,40)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LineEdit{Text=world.ClubName,PlaceholderText="俱乐部名称",CustomMinimumSize=new(166,40)}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(expanded)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(expanded);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(extras)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(extras);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(show)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(show);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`countries.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: countries.AddChild(b);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`expanded.AddChild(countries)`；返回值紧邻使用处：`ExpressionStatementSyntax: expanded.AddChild(countries);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`expanded.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: expanded.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Field("队名").AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field("队名").AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Field("加入赛季").AddChild(season)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field("加入赛季").AddChild(season);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(card);`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox{MinValue=1,MaxValue=100,AllowGreater=true,Step=1,Value=world.Season,CustomMinimumSize=new(120,40)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new SpinBox{MinValue=1,MaxValue=100,AllowGreater=true,Step=1,Value=world.Season,CustomMinimumSize=new(120,40)}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{Visible=world.Levels.Count>0}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{Visible=world.Levels.Count>0}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(120,40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(120,40)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(166,40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(166,40)`
- `Nation()`；输入表达式：`Nation()`；返回值紧邻使用处：`ExpressionStatementSyntax: Nation();`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton{Text=n,ToggleMode=true,ButtonGroup=tabs,ButtonPressed=n==chosen}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastButton{Text=n,ToggleMode=true,ButtonGroup=tabs,ButtonPressed=n==chosen}`
- `NationalSpire.BroadcastPanel.BroadcastPanel()`；输入表达式：`new BroadcastPanel { Accent=CareerVisuals.Gold }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastPanel { Accent=CareerVisuals.Gold }`
- `NationalSpire.CareerDisclosureButton.CareerDisclosureButton()`；输入表达式：`new CareerDisclosureButton{Text="各国初始发展水平",ArrowOnLeft=true,ToggleMode=true,ButtonPressed=expanded.Visible}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CareerDisclosureButton{Text="各国初始发展水平",ArrowOnLeft=true,ToggleMode=true,ButtonPressed=expanded.Visible}`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("152633","365565",10,16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("152633","365565",10,16)`

**赋值（含属性/字段和局部值）：**

- `Accent` = `CareerVisuals.Gold`
- `AllowGreater` = `true`
- `ArrowOnLeft` = `true`
- `b.Pressed` += `()=>{chosen=n;Nation();}`
- `ButtonGroup` = `tabs`
- `ButtonPressed` = `expanded.Visible`
- `ButtonPressed` = `n==chosen`
- `chosen` = `n`
- `Columns` = `3`
- `CustomMinimumSize` = `new(120,40)`
- `CustomMinimumSize` = `new(166,40)`
- `expanded.Visible` = `on`
- `extras.Visible` = `v=="自建"`
- `extras.Visible` = `world.ClubMode=="自建"`
- `MaxValue` = `100`
- `MinValue` = `1`
- `name.TextChanged` += `v=>world.ClubName=v`
- `PlaceholderText` = `"俱乐部名称"`
- `row` = `extras`
- `row` = `top`
- `season.ValueChanged` += `v=>world.Season=(int)v`
- `show.Toggled` += `on=>expanded.Visible=on`
- `Step` = `1`
- `Text` = `"各国初始发展水平"`
- `Text` = `"赛季与俱乐部"`
- `Text` = `n`
- `Text` = `world.ClubName`
- `ToggleMode` = `true`
- `Value` = `world.Season`
- `Visible` = `world.Levels.Count>0`
- `world.ClubCountry` = `v`
- `world.ClubMode` = `v`
- `world.ClubName` = `v`
- `world.ClubSponsor` = `v`
- `world.Season` = `(int)v`

<a id="symbol-bcd948bf9319"></a>

## `Field(string) — VBoxContainer Field(string caption)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choice(string, string[], string[], string, System.Action<string>)`](OpeningWorldEditor.cs.md#symbol-5ede24bd4b77)；[`NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld)`](OpeningWorldEditor.cs.md#symbol-404e75faa99e)

**调用：** `Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Label.Label()`；输入表达式：`new Label{Text=caption}`；返回值紧邻使用处：`ArgumentSyntax: new Label{Text=caption}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(new Label{Text=caption})`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(new Label{Text=caption});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(col)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(col);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`

**赋值（含属性/字段和局部值）：**

- `Text` = `caption`

<a id="symbol-5ede24bd4b77"></a>

## `Choice(string, string[], string[], string, System.Action<string>) — OptionButton Choice(string caption,string[] names,string[] values,string current,Action<string> set)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld)`](OpeningWorldEditor.cs.md#symbol-404e75faa99e)

**调用：** [`Field(string)`](OpeningWorldEditor.cs.md#symbol-bcd948bf9319)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Array.IndexOf<T>(T[], T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `Field(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(string)`；输入表达式：`Field(caption)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Field(caption).AddChild`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Field(caption).AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field(caption).AddChild(box);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`box.AddItem(n)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddItem(n);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton{FitToLongestItem=false,CustomMinimumSize=new(150,40)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new OptionButton{FitToLongestItem=false,CustomMinimumSize=new(150,40)}`
- `Godot.OptionButton.Select(int)`；输入表达式：`box.Select(Math.Max(0,Array.IndexOf(values,current)))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.Select(Math.Max(0,Array.IndexOf(values,current)));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(150,40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(150,40)`
- `System.Action<T>.Invoke(T)`；输入表达式：`set(values[(int)i])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i=>set(values[(int)i])`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(values,current)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(values,current)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,Array.IndexOf(values,current))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,Array.IndexOf(values,current))`

**赋值（含属性/字段和局部值）：**

- `box.ItemSelected` += `i=>set(values[(int)i])`
- `CustomMinimumSize` = `new(150,40)`
- `FitToLongestItem` = `false`

<a id="symbol-702d90a9c3b4"></a>

## `Nation() — void Nation()`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld)`](OpeningWorldEditor.cs.md#symbol-404e75faa99e)

**调用：** [`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.VBoxContainer.VBoxContainer()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerOpeningWorld.Levels`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalDevelopment.Indicator.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Label.Label()`；输入表达式：`new Label{Text=indicator.Name}`；返回值紧邻使用处：`ArgumentSyntax: new Label{Text=indicator.Name}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`field.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: field.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`field.AddChild(new Label{Text=indicator.Name})`；返回值紧邻使用处：`ExpressionStatementSyntax: field.AddChild(new Label{Text=indicator.Name});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(field)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(field);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choices.AddItem("沿用世界发展")`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddItem("沿用世界发展");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choices.AddItem(i+" 级")`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddItem(i+" 级");`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new OptionButton()`
- `Godot.OptionButton.Select(int)`；输入表达式：`choices.Select(world.Levels.GetValueOrDefault(chosen)?.TryGetValue(indicator.Id,out int lvl)==true?lvl+1:0)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Select(world.Levels.GetValueOrDefault(chosen)?.TryGetValue(indicator.Id,out int lvl)==true?lvl+1:0);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(grid);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`levels.Remove(indicator.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: levels.Remove(indicator.Id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`world.Levels.Remove(nation)`；返回值紧邻使用处：`ExpressionStatementSyntax: world.Levels.Remove(nation);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`.TryGetValue(indicator.Id,out int lvl)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: world.Levels.GetValueOrDefault(chosen)?.TryGetValue(indicator.Id,out int lvl)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`world.Levels.TryGetValue(nation,out var levels)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !world.Levels.TryGetValue(nation,out var levels)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`world.Levels.GetValueOrDefault(chosen)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: world.Levels.GetValueOrDefault(chosen)?.TryGetValue(indicator.Id,out int lvl)`

**赋值（含属性/字段和局部值）：**

- `choices.ItemSelected` += `index=>{                     if(!world.Levels.TryGetValue(nation,out var levels)) world.Levels[nation]=levels=[];                     if(index>0)levels[indicator.Id]=(int)index-1;else levels.Remove(indicator.Id);                     if(levels.Count==0)world.Levels.Remove(nation);                 }`
- `levels[indicator.Id]` = `(int)index-1`
- `levels` = `[]`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Text` = `indicator.Name`
- `world.Levels[nation]` = `levels=[]`
