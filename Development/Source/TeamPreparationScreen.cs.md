# TeamPreparationScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`E76EC076DC087516A73861FEC920889F39F95E8ABD09B86C980608BEE74987B0`。来源：[源码](../../TeamPreparationScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-57b7570c5a7d"></a>

## `NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData) — private void RenderTeamPreparations(CareerData data)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`](TeamPreparation.cs.md#symbol-f2f72b62407b)；[`NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`](TeamPreparation.cs.md#symbol-440f4ccf2595)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.TeamPreparations`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.TeamPreparation.CompetitionId`；`NationalSpire.TeamPreparation.Remaining`；`NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`；`NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`；`NationalSpire.TeamPreparations.Cost`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 22);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(words)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(words);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Text("集体备赛 · " + competition.Name, 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Text("集体备赛 · " + competition.Name, 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(TeamPreparations.Cost)`；返回值紧邻使用处：`BinaryExpressionSyntax: "安排备赛 " + CareerMoney.Format(TeamPreparations.Cost)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(current == null ? "安排备赛 " + CareerMoney.Format(TeamPreparations.Cost) : "备赛生效 · 剩余" + current.Remaining + "轮", () =>             {                 if (MultiplayerCommand("team-preparation", competition.Id)) return;                 var error = TeamPreparations.Buy(data, competition.Id); CareerStore.Save(data); Render(); if (error != null) Notice(error, true);             }, 265)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(current == null ? "安排备赛 " + CareerMoney.Format(TeamPreparations.Cost) : "备赛生效 · 剩余" + current.Remaining + "轮", () =>             {                 if (MultiplayerCommand("team-preparation", competition.Id)) return;                 var error = TeamPreparations.Buy(data, competition.Id); CareerStore.Save(data); Render(); if (error != null) Notice(error, true);             }, 265)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("team-preparation", competition.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("team-preparation", competition.Id)) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error, true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("集体备赛 · " + competition.Name, 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("集体备赛 · " + competition.Name, 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`；输入表达式：`TeamPreparations.Available(data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var competition in TeamPreparations.Available(data))         {             var card = Card(); card.Name = "TeamPreparationCard"; _content.AddChild(card); var box = Inner(card);             var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 22); box.AddChild(row);             var words = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(words);             words.AddChild(Text("集体备赛 · " + competition.Name, 23, _gold));             words.AddChild(Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted));             var current = data.TeamPreparations.FirstOrDefault(p => p.CompetitionId == competition.Id && p.Remaining > 0);             var button = Button(current == null ? "安排备赛 " + CareerMoney.Format(TeamPreparations.Cost) : "备赛生效 · 剩余" + current.Remaining + "轮", () =>             {                 if (MultiplayerCommand("team-preparation", competition.Id)) return;                 var error = TeamPreparations.Buy(data, competition.Id); CareerStore.Save(data); Render(); if (error != null) Notice(error, true);             }, 265);             button.Disabled = current != null; row.AddChild(button);         }`
- `NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`；输入表达式：`TeamPreparations.Buy(data, competition.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TeamPreparations.Buy(data, competition.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.TeamPreparations.FirstOrDefault(p => p.CompetitionId == competition.Id && p.Remaining > 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.TeamPreparations.FirstOrDefault(p => p.CompetitionId == competition.Id && p.Remaining > 0)`

**赋值（含属性/字段和局部值）：**

- `button.Disabled` = `current != null`
- `card.Name` = `"TeamPreparationCard"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
