# PrivateOathScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B09E33D19E6562536053B9285B6B57316217B53070125137CD4BACD8CD6756D0`。来源：[源码](../../PrivateOathScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-bcbfed5b53c6"></a>

## `NationalSpire.CareerScreen.AddPrivateOath(NationalSpire.CareerData, NationalSpire.PrivateRelation) — private void AddPrivateOath(CareerData data, PrivateRelation relation)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`Decide(string)`](PrivateOathScreen.cs.md#symbol-e3aa37292b2b)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`

**字段、属性、事件及方法组引用：** `Decide(string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.PrivateRelation.Appearance`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.OathDeferred`；`NationalSpire.PrivateRelation.OathPromptHidden`；`NationalSpire.PrivateRelation.OathReleaseReason`；`NationalSpire.RelationshipAppearance.OathEligible`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Decide(string)`；输入表达式：`Decide("keep")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Decide("keep")`
- `Decide(string)`；输入表达式：`Decide("release")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Decide("release")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("f3c4da")`；返回值紧邻使用处：`ArgumentSyntax: new Color("f3c4da")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`reply.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: reply.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("243448", "bca4c4", 8, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("243448", "bca4c4", 8, 16));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateSelectableText(relation.OathReleaseReason, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateSelectableText(relation.OathReleaseReason, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText("搁置誓约：点击好感徽章后再次求婚", 19, new Color("f3c4da")))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText("搁置誓约：点击好感徽章后再次求婚", 19, new Color("f3c4da")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText($"是否为{CareerEngine.DisplayName(data, person)}戴上钻戒？", 19, new Color("f3c4da")))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText($"是否为{CareerEngine.DisplayName(data, person)}戴上钻戒？", 19, new Color("f3c4da")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText(CareerEngine.DisplayName(data, person) + "提出解除誓约", 19, new Color("f3c4da")))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText(CareerEngine.DisplayName(data, person) + "提出解除誓约", 19, new Color("f3c4da")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(reply)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(reply);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("回复并继续沟通", () => Decide("keep"), 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("回复并继续沟通", () => Decide("keep"), 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("回复并解除誓约", () => Decide("release"), 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("回复并解除誓约", () => Decide("release"), 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("暂不处理", () => PrivateCommand("dm-oath-defer", new()), 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("暂不处理", () => PrivateCommand("dm-oath-defer", new()), 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("确认收起", () => PrivateCommand("dm-oath-close", new()), 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("确认收起", () => PrivateCommand("dm-oath-close", new()), 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("确认誓约", () => PrivateCommand("dm-oath-confirm", new()), 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("确认誓约", () => PrivateCommand("dm-oath-confirm", new()), 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("重新求婚", () => PrivateCommand("dm-oath-open", new()), 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("重新求婚", () => PrivateCommand("dm-oath-open", new()), 140));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "PrivateOathPrompt" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "PrivateOathPrompt" }`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "OathReleaseReply", PlaceholderText = "写下给对方的回复…", CustomMinimumSize = new(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "OathReleaseReply", PlaceholderText = "写下给对方的回复…", CustomMinimumSize = new(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 90)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 90)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, person) + "提出解除誓约"`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, person)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, person)}`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("回复并继续沟通", () => Decide("keep"), 180)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("回复并继续沟通", () => Decide("keep"), 180)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("回复并解除誓约", () => Decide("release"), 180)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("回复并解除誓约", () => Decide("release"), 180)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("暂不处理", () => PrivateCommand("dm-oath-defer", new()), 140)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("暂不处理", () => PrivateCommand("dm-oath-defer", new()), 140)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("确认收起", () => PrivateCommand("dm-oath-close", new()), 140)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("确认收起", () => PrivateCommand("dm-oath-close", new()), 140)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("确认誓约", () => PrivateCommand("dm-oath-confirm", new()), 140)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("确认誓约", () => PrivateCommand("dm-oath-confirm", new()), 140)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("重新求婚", () => PrivateCommand("dm-oath-open", new()), 140)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("重新求婚", () => PrivateCommand("dm-oath-open", new()), 140)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-oath-close", new())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-oath-close", new())`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-oath-confirm", new())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-oath-confirm", new())`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-oath-defer", new())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-oath-defer", new())`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-oath-open", new())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-oath-open", new())`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(relation.OathReleaseReason, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText(relation.OathReleaseReason, 17, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("搁置誓约：点击好感徽章后再次求婚", 19, new Color("f3c4da"))`；返回值紧邻使用处：`ArgumentSyntax: PrivateText("搁置誓约：点击好感徽章后再次求婚", 19, new Color("f3c4da"))`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText($"是否为{CareerEngine.DisplayName(data, person)}戴上钻戒？", 19, new Color("f3c4da"))`；返回值紧邻使用处：`ArgumentSyntax: PrivateText($"是否为{CareerEngine.DisplayName(data, person)}戴上钻戒？", 19, new Color("f3c4da"))`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(CareerEngine.DisplayName(data, person) + "提出解除誓约", 19, new Color("f3c4da"))`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(CareerEngine.DisplayName(data, person) + "提出解除誓约", 19, new Color("f3c4da"))`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("243448", "bca4c4", 8, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("243448", "bca4c4", 8, 16)`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 90)`
- `Name` = `"OathReleaseReply"`
- `Name` = `"PrivateOathPrompt"`
- `PlaceholderText` = `"写下给对方的回复…"`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-e3aa37292b2b"></a>

## `Decide(string) — void Decide(string part)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOath(NationalSpire.CareerData, NationalSpire.PrivateRelation)`](PrivateOathScreen.cs.md#symbol-bcbfed5b53c6)

**调用：** [`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-oath-release", new() { Text = reply.Text, Part = part })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateCommand("dm-oath-release", new() { Text = reply.Text, Part = part })`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Text = reply.Text, Part = part }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = reply.Text, Part = part }`

**赋值（含属性/字段和局部值）：**

- `Part` = `part`
- `Text` = `reply.Text`
