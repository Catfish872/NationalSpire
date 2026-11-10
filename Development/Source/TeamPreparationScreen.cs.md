# TeamPreparationScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F55F193D4D182230034A32DCAC8A4FC9C188BF0E0044FDA407A751B0A2291441`。来源：[源码](../../TeamPreparationScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-a2bb56539ef4"></a>

## `NationalSpire.CareerScreen.ConfirmTeamPreparation(NationalSpire.CareerData, string) — private void ConfirmTeamPreparation(CareerData data,string id)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData, string)`](TeamPreparationScreen.cs.md#symbol-57b7570c5a7d)；[`NationalSpire.CareerScreen.TeamPreparationPlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-a5b07c06671a)

**调用：** [`NationalSpire.CareerScreen.FinishPlan(string?)`](CalendarPlansScreen.cs.md#symbol-100b2aec3e40)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`](TeamPreparation.cs.md#symbol-440f4ccf2595)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ClearPlan()`；`NationalSpire.CareerScreen.FinishPlan(string?)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.FinishPlan(string?)`；输入表达式：`FinishPlan(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishPlan(error);`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("team-preparation",id,accepted:ClearPlan)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("team-preparation",id,accepted:ClearPlan)) return;`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`；输入表达式：`TeamPreparations.Buy(data,id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =TeamPreparations.Buy(data,id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-57b7570c5a7d"></a>

## `NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData, string) — private void RenderTeamPreparations(CareerData data, string competitionId)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.ConfirmTeamPreparation(NationalSpire.CareerData, string)`](TeamPreparationScreen.cs.md#symbol-a2bb56539ef4)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`](TeamPreparation.cs.md#symbol-f2f72b62407b)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.TeamPreparations`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.ConfirmTeamPreparation(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.ICareerSession.Host`；`NationalSpire.TeamPreparation.CompetitionId`；`NationalSpire.TeamPreparation.Remaining`；`NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`；`NationalSpire.TeamPreparations.Cost`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 22);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(words)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(words);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Text("集体备赛 · " + competition.Name, 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Text("集体备赛 · " + competition.Name, 23, _gold));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(TeamPreparations.Cost)`；返回值紧邻使用处：`BinaryExpressionSyntax: "安排备赛 " + CareerMoney.Format(TeamPreparations.Cost)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(current == null ? "安排备赛 " + CareerMoney.Format(TeamPreparations.Cost) : "备赛生效 · 剩余" + current.Remaining + "轮", () => ConfirmTeamPreparation(data,competition.Id), 265)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(current == null ? "安排备赛 " + CareerMoney.Format(TeamPreparations.Cost) : "备赛生效 · 剩余" + current.Remaining + "轮", () => ConfirmTeamPreparation(data,competition.Id), 265)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.ConfirmTeamPreparation(NationalSpire.CareerData, string)`；输入表达式：`ConfirmTeamPreparation(data,competition.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmTeamPreparation(data,competition.Id)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("集体备赛 · " + competition.Name, 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("集体备赛 · " + competition.Name, 23, _gold)`
- `NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`；输入表达式：`TeamPreparations.Available(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: TeamPreparations.Available(data).Where`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.TeamPreparations.FirstOrDefault(p => p.CompetitionId == competition.Id && p.Remaining > 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.TeamPreparations.FirstOrDefault(p => p.CompetitionId == competition.Id && p.Remaining > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`TeamPreparations.Available(data).Where(c=>c.Id==competitionId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var competition in TeamPreparations.Available(data).Where(c=>c.Id==competitionId)) { var card = Card(); card.Name = "TeamPreparationCard"; _content.AddChild(card); var box = Inner(card); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 22); box.AddChild(row); var words = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(words); words.AddChild(Text("集体备赛 · " + competition.Name, 23, _gold)); words.AddChild(Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted)); var current = data.TeamPreparations.FirstOrDefault(p => p.CompetitionId == competition.Id && p.Remaining > 0); var button = Button(current == null ? "安排备赛 " + CareerMoney.Format(TeamPreparations.Cost) : "备赛生效 · 剩余" + current.Remaining + "轮", () => ConfirmTeamPreparation(data,competition.Id), 265); button.Disabled = current != null || _multiplayer is {Host:false}; row.AddChild(button); }`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `button.Disabled` = `current != null || _multiplayer is {Host:false}`
- `card.Name` = `"TeamPreparationCard"`
