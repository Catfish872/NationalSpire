# PortraitStyleScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C66CC004E3E91C6C6397DEE32CD0E9800ED37B74364FCEA9EB7BA03A2E05F9CA`。来源：[源码](../../PortraitStyleScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-f030328fcc3e"></a>

## `NationalSpire.CareerScreen.DrawPortraitStyles(Godot.VBoxContainer, NationalSpire.PortraitDesign) — private void DrawPortraitStyles(VBoxContainer parent, PortraitDesign design)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawPage()`](PortraitDesignScreen.cs.md#symbol-4a5867e03395)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.PortraitModelPrompts.Default(string)`](PortraitModelPrompts.cs.md#symbol-e2cc08446a70)；[`NationalSpire.PortraitModelPrompts.Get(NationalSpire.PortraitDesign)`](PortraitModelPrompts.cs.md#symbol-78c7c2214dc7)；`System.Array.FindIndex<T>(T[], System.Predicate<T>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._muted`；`NationalSpire.PortraitDesign.ModelConstraints`；`NationalSpire.PortraitDesign.PromptModel`；`NationalSpire.PortraitModelPrompts.Default(string)`；`NationalSpire.PortraitModelPrompts.Get(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitModelPrompts.Models`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`input.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("选择绘制模型并调整约束；参考图片与画风要求在外部生图对话中上传。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("选择绘制模型并调整约束；参考图片与画风要求在外部生图对话中上传。", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(toggle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Button("恢复该模型预设", () => { design.ModelConstraints.Remove(design.PromptModel); input.Text = PortraitModelPrompts.Default(design.PromptModel); }, 190))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Button("恢复该模型预设", () => { design.ModelConstraints.Remove(design.PromptModel); input.Text = PortraitModelPrompts.Default(design.PromptModel); }, 190));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(choice);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choice.AddItem(model.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.AddItem(model.Name);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "PortraitModelChoice", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "PortraitModelChoice", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`choice.Select(Math.Max(0, index))`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.Select(Math.Max(0, index));`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "PortraitModelPrompt", Text = PortraitModelPrompts.Get(design), CustomMinimumSize = new(0, 220), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "PortraitModelPrompt", Text = PortraitModelPrompts.Get(design), CustomMinimumSize = new(0, 220), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "PortraitModelConstraints", Visible = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "PortraitModelConstraints", Visible = false }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 220)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 220)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("恢复该模型预设", () => { design.ModelConstraints.Remove(design.PromptModel); input.Text = PortraitModelPrompts.Default(design.PromptModel); }, 190)`；返回值紧邻使用处：`ArgumentSyntax: Button("恢复该模型预设", () => { design.ModelConstraints.Remove(design.PromptModel); input.Text = PortraitModelPrompts.Default(design.PromptModel); }, 190)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("画风调试与噪点控制 ▾", () => { body.Visible = !body.Visible; toggle.Text = body.Visible ? "画风调试与噪点控制 ▴" : "画风调试与噪点控制 ▾"; }, 300)`；返回值紧邻使用处：`AssignmentExpressionSyntax: toggle = Button("画风调试与噪点控制 ▾", () => { body.Visible = !body.Visible; toggle.Text = body.Visible ? "画风调试与噪点控制 ▴" : "画风调试与噪点控制 ▾"; }, 300)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("选择绘制模型并调整约束；参考图片与画风要求在外部生图对话中上传。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("选择绘制模型并调整约束；参考图片与画风要求在外部生图对话中上传。", 15, _muted)`
- `NationalSpire.PortraitModelPrompts.Default(string)`；输入表达式：`PortraitModelPrompts.Default(design.PromptModel)`；返回值紧邻使用处：`AssignmentExpressionSyntax: input.Text = PortraitModelPrompts.Default(design.PromptModel)`
- `NationalSpire.PortraitModelPrompts.Get(NationalSpire.PortraitDesign)`；输入表达式：`PortraitModelPrompts.Get(design)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = PortraitModelPrompts.Get(design)`
- `NationalSpire.PortraitModelPrompts.Get(NationalSpire.PortraitDesign)`；输入表达式：`PortraitModelPrompts.Get(design)`；返回值紧邻使用处：`AssignmentExpressionSyntax: input.Text = PortraitModelPrompts.Get(design)`
- `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；输入表达式：`Array.FindIndex(PortraitModelPrompts.Models, m => m.Id == design.PromptModel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Array.FindIndex(PortraitModelPrompts.Models, m => m.Id == design.PromptModel)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`design.ModelConstraints.Remove(design.PromptModel)`；返回值紧邻使用处：`ExpressionStatementSyntax: design.ModelConstraints.Remove(design.PromptModel);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, index)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, index)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 220)`
- `CustomMinimumSize` = `new(0, 42)`
- `Name` = `"PortraitModelChoice"`
- `Name` = `"PortraitModelConstraints"`
- `Name` = `"PortraitModelPrompt"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `PortraitModelPrompts.Get(design)`
- `Visible` = `false`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`
- `body.Visible` = `!body.Visible`
- `choice.ItemSelected` += `selected => { design.PromptModel = PortraitModelPrompts.Models[(int)selected].Id; input.Text = PortraitModelPrompts.Get(design); }`
- `design.ModelConstraints[design.PromptModel]` = `input.Text`
- `design.ModelConstraints` ??= `[]`
- `design.PromptModel` = `PortraitModelPrompts.Models[(int)selected].Id`
- `design.PromptModel` = `PortraitModelPrompts.Models[0].Id`
- `input.TextChanged` += `() => design.ModelConstraints[design.PromptModel] = input.Text`
- `input.Text` = `PortraitModelPrompts.Default(design.PromptModel)`
- `input.Text` = `PortraitModelPrompts.Get(design)`
- `toggle.Name` = `"PortraitStyleToggle"`
- `toggle.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `toggle.Text` = `body.Visible ? "画风调试与噪点控制 ▴" : "画风调试与噪点控制 ▾"`
- `toggle` = `Button("画风调试与噪点控制 ▾", () => { body.Visible = !body.Visible; toggle.Text = body.Visible ? "画风调试与噪点控制 ▴" : "画风调试与噪点控制 ▾"; }, 300)`
