# AffectionSettingsScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`7A047F5815FF73321B801323E5D9AFE6E2D80C2A8B9F880BF723B068FFAF83DB`。来源：[源码](../../AffectionSettingsScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-2fc9af32beab"></a>

## `NationalSpire.CareerScreen.AffectionSettings(NationalSpire.CareerData) — private void AffectionSettings(CareerData data)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.CheckBox.CheckBox()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.AffectionCompetition.Set(NationalSpire.CareerData, bool)`](AffectionCompetition.cs.md#symbol-febdbaec2db0)；[`NationalSpire.AffectionRules.Description(NationalSpire.RomanceDifficulty)`](AffectionRules.cs.md#symbol-3d1e544d7431)；[`NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`](AffectionRules.cs.md#symbol-8616d6a806d2)；[`NationalSpire.AffectionRules.Name(NationalSpire.RomanceDifficulty)`](AffectionRules.cs.md#symbol-9bae9ef9e418)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)；[`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)；`System.Array.IndexOf<T>(T[], T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionCompetition.Set(NationalSpire.CareerData, bool)`；`NationalSpire.AffectionRules.Description(NationalSpire.RomanceDifficulty)`；`NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；`NationalSpire.AffectionRules.Name(NationalSpire.RomanceDifficulty)`；`NationalSpire.CareerData.AffectionLinkedClearChance`；`NationalSpire.CareerData.RomanceDifficulty`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.ICareerSession.Host`；`NationalSpire.ICareerSession.Refresh()`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；`NationalSpire.RomanceDifficulty.Charming`；`NationalSpire.RomanceDifficulty.Insulated`；`NationalSpire.RomanceDifficulty.Natural`；`NationalSpire.RomanceDifficulty.Reserved`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`linked.SetPressedNoSignal(ViewData.AffectionLinkedClearChance)`；返回值紧邻使用处：`ExpressionStatementSyntax: linked.SetPressedNoSignal(ViewData.AffectionLinkedClearChance);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`linked.SetPressedNoSignal(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: linked.SetPressedNoSignal(previous);`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "AffectionLinkedClearChance", Text = "将NPC通关率与好感挂钩", ButtonPressed = data.AffectionLinkedClearChance, Disabled = _multiplayer is { Host: false }, SizeFlagsHorizontal = SizeFlags.ShrinkEnd, SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "AffectionLinkedClearChance", Text = "将NPC通关率与好感挂钩", ButtonPressed = data.AffectionLinkedClearChance, Disabled = _multiplayer is { Host: false }, SizeFlagsHorizontal = SizeFlags.ShrinkEnd, SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`detailRow.AddThemeConstantOverride("separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: detailRow.AddThemeConstantOverride("separation", 24);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(linked)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(linked)) linked.SetPressedNoSignal(ViewData.AffectionLinkedClearChance);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(picker)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(picker)) { picker.Select(Array.IndexOf(modes, AffectionRules.Mode(ViewData))); description.Text = AffectionRules.Description(AffectionRules.Mode(ViewData)); }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "AffectionDescriptionRow" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "AffectionDescriptionRow" }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("对本生涯后续交互生效；已发送的私聊沿发送时难度结算。已有好感保留。" + (_multiplayer != null ? "由房主设置，全队共用。" : ""), 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("对本生涯后续交互生效；已发送的私聊沿发送时难度结算。已有好感保留。" + (_multiplayer != null ? "由房主设置，全队共用。" : ""), 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("攻略难度", 24, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("攻略难度", 24, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(detailRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(detailRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(picker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`detailRow.AddChild(description)`；返回值紧邻使用处：`ExpressionStatementSyntax: detailRow.AddChild(description);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`detailRow.AddChild(linked)`；返回值紧邻使用处：`ExpressionStatementSyntax: detailRow.AddChild(linked);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`picker.AddItem(AffectionRules.Name(mode) + (mode == RomanceDifficulty.Natural ? " · 默认" : ""))`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddItem(AffectionRules.Name(mode) + (mode == RomanceDifficulty.Natural ? " · 默认" : ""));`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "RomanceDifficulty", CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "RomanceDifficulty", CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.OptionButton.Select(int)`；输入表达式：`picker.Select(Array.IndexOf(modes, AffectionRules.Mode(ViewData)))`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.Select(Array.IndexOf(modes, AffectionRules.Mode(ViewData)));`
- `Godot.OptionButton.Select(int)`；输入表达式：`picker.Select(Array.IndexOf(modes, AffectionRules.Mode(data)))`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.Select(Array.IndexOf(modes, AffectionRules.Mode(data)));`
- `Godot.OptionButton.Select(int)`；输入表达式：`picker.Select(Array.IndexOf(modes, previous))`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.Select(Array.IndexOf(modes, previous));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 48)`
- `NationalSpire.AffectionCompetition.Set(NationalSpire.CareerData, bool)`；输入表达式：`AffectionCompetition.Set(data, previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: AffectionCompetition.Set(data, previous);`
- `NationalSpire.AffectionCompetition.Set(NationalSpire.CareerData, bool)`；输入表达式：`AffectionCompetition.Set(data, value)`；返回值紧邻使用处：`ExpressionStatementSyntax: AffectionCompetition.Set(data, value);`
- `NationalSpire.AffectionRules.Description(NationalSpire.RomanceDifficulty)`；输入表达式：`AffectionRules.Description(AffectionRules.Mode(ViewData))`；返回值紧邻使用处：`AssignmentExpressionSyntax: description.Text = AffectionRules.Description(AffectionRules.Mode(ViewData))`
- `NationalSpire.AffectionRules.Description(NationalSpire.RomanceDifficulty)`；输入表达式：`AffectionRules.Description(AffectionRules.Mode(data))`；返回值紧邻使用处：`ArgumentSyntax: AffectionRules.Description(AffectionRules.Mode(data))`
- `NationalSpire.AffectionRules.Description(NationalSpire.RomanceDifficulty)`；输入表达式：`AffectionRules.Description(mode)`；返回值紧邻使用处：`AssignmentExpressionSyntax: description.Text = AffectionRules.Description(mode)`
- `NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；输入表达式：`AffectionRules.Mode(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: AffectionRules.Mode(ViewData)`
- `NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；输入表达式：`AffectionRules.Mode(data)`；返回值紧邻使用处：`ArgumentSyntax: AffectionRules.Mode(data)`
- `NationalSpire.AffectionRules.Name(NationalSpire.RomanceDifficulty)`；输入表达式：`AffectionRules.Name(mode)`；返回值紧邻使用处：`BinaryExpressionSyntax: AffectionRules.Name(mode) + (mode == RomanceDifficulty.Natural ? " · 默认" : "")`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("保存失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("保存失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("攻略难度已保存。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("攻略难度已保存。", false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("对本生涯后续交互生效；已发送的私聊沿发送时难度结算。已有好感保留。" + (_multiplayer != null ? "由房主设置，全队共用。" : ""), 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("对本生涯后续交互生效；已发送的私聊沿发送时难度结算。已有好感保留。" + (_multiplayer != null ? "由房主设置，全队共用。" : ""), 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("攻略难度", 24, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("攻略难度", 24, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(AffectionRules.Description(AffectionRules.Mode(data)), 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(AffectionRules.Description(AffectionRules.Mode(data)), 16, _muted)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`_multiplayer.Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Refresh();`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send("affection-clear-chance", number: value ? 1 : 0, accepted: () => { _multiplayer.Refresh(); if (IsInstanceValid(linked)) linked.SetPressedNoSignal(ViewData.AffectionLinkedClearChance); })`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send("affection-clear-chance", number: value ? 1 : 0, accepted: () => { _multiplayer.Refresh(); if (IsInstanceValid(linked)) linked.SetPressedNoSignal(ViewData.AffectionLinkedClearChance); });`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send("romance-difficulty", number: (int)mode, accepted: () => { _multiplayer.Refresh(); if (IsInstanceValid(picker)) { picker.Select(Array.IndexOf(modes, AffectionRules.Mode(ViewData))); description.Text = AffectionRules.Description(AffectionRules.Mode(ViewData)); } })`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send("romance-difficulty", number: (int)mode, accepted: () => { _multiplayer.Refresh(); if (IsInstanceValid(picker)) { picker.Select(Array.IndexOf(modes, AffectionRules.Mode(ViewData))); description.Text = AffectionRules.Description(AffectionRules.Mode(ViewData)); } });`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(modes, AffectionRules.Mode(ViewData))`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(modes, AffectionRules.Mode(ViewData))`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(modes, AffectionRules.Mode(data))`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(modes, AffectionRules.Mode(data))`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(modes, previous)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(modes, previous)`

**赋值（含属性/字段和局部值）：**

- `ButtonPressed` = `data.AffectionLinkedClearChance`
- `CustomMinimumSize` = `new(0, 48)`
- `Disabled` = `_multiplayer is { Host: false }`
- `Name` = `"AffectionDescriptionRow"`
- `Name` = `"AffectionLinkedClearChance"`
- `Name` = `"RomanceDifficulty"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Text` = `"将NPC通关率与好感挂钩"`
- `data.RomanceDifficulty` = `mode`
- `data.RomanceDifficulty` = `previous`
- `description.Name` = `"AffectionDescription"`
- `description.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `description.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `description.Text` = `AffectionRules.Description(AffectionRules.Mode(ViewData))`
- `description.Text` = `AffectionRules.Description(mode)`
- `linked.Toggled` += `value => { if (_multiplayer != null) { linked.SetPressedNoSignal(ViewData.AffectionLinkedClearChance); _multiplayer.Send("affection-clear-chance", number: value ? 1 : 0, accepted: () => { _multiplayer.Refresh(); if (IsInstanceValid(linked)) linked.SetPressedNoSignal(ViewData.AffectionLinkedClearChance); }); return; } bool previous = data.AffectionLinkedClearChance; AffectionCompetition.Set(data, value); try { CareerStore.Save(data); } catch (Exception e) { AffectionCompetition.Set(data, previous); linked.SetPressedNoSignal(previous); Notice("保存失败：" + e.Message, true); } }`
- `linked.TooltipText` = `"队友好感影响训练、交流成长及通关率；其他俱乐部角色的正向好感会降低其通关率。联机采用对该NPC好感最高的玩家。"`
- `picker.Disabled` = `_multiplayer is { Host: false }`
- `picker.ItemSelected` += `index => { var mode = modes[(int)index]; if (_multiplayer != null) { picker.Select(Array.IndexOf(modes, AffectionRules.Mode(ViewData))); _multiplayer.Send("romance-difficulty", number: (int)mode, accepted: () => { _multiplayer.Refresh(); if (IsInstanceValid(picker)) { picker.Select(Array.IndexOf(modes, AffectionRules.Mode(ViewData))); description.Text = AffectionRules.Description(AffectionRules.Mode(ViewData)); } }); return; } var previous = data.RomanceDifficulty; data.RomanceDifficulty = mode; try { CareerStore.Save(data); description.Text = AffectionRules.Description(mode); Notice("攻略难度已保存。", false); } catch (Exception e) { data.RomanceDifficulty = previous; picker.Select(Array.IndexOf(modes, previous)); Notice("保存失败：" + e.Message, true); } }`
