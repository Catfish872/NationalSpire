# ChatToolToggle.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6D3927F0B417501BF7ED116A88C7CB2DB667E99E50D7EC1DF4959A6D5C9F8324`。来源：[源码](../../ChatToolToggle.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.ChatToolIcon`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-cdbc2a8ad7ca"></a>

## `NationalSpire.CareerScreen.BuildChatToolToggle(Godot.HBoxContainer) — private void BuildChatToolToggle(HBoxContainer actions)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.AiSettingsStore.Save(NationalSpire.AiOptions)`](AiSettingsStore.cs.md#symbol-ba3b31b1bb7c)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`Paint(bool)`](ChatToolToggle.cs.md#symbol-3ff003a6c7cb)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.ChatToolIcon.ChatToolIcon()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.ChatTools`；`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.AiSettingsStore.Save(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ChatToolIcon.Enabled`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`Paint(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(icon);`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(ViewData.Ai)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiSettingsStore.Load(ViewData.Ai)`
- `NationalSpire.AiSettingsStore.Save(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Save(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiSettingsStore.Save(options);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", () => { }, 46)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("", () => { }, 46)`
- `NationalSpire.ChatToolIcon.ChatToolIcon()`；输入表达式：`new ChatToolIcon { Enabled = options.ChatTools, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ChatToolIcon { Enabled = options.ChatTools, MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("chat.tools.settings", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("chat.tools.settings", e);`
- `Paint(bool)`；输入表达式：`Paint(enabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: Paint(enabled);`
- `Paint(bool)`；输入表达式：`Paint(options.ChatTools)`；返回值紧邻使用处：`ExpressionStatementSyntax: Paint(options.ChatTools);`

**赋值（含属性/字段和局部值）：**

- `button.ButtonPressed` = `options.ChatTools`
- `button.Name` = `"ChatToolMode"`
- `button.SizeFlagsVertical` = `SizeFlags.Fill`
- `button.Toggled` += `enabled =>         {             options.ChatTools = enabled; ViewData.Ai.ChatTools = enabled; Paint(enabled);             try { AiSettingsStore.Save(options); }             catch (Exception e) { Diagnostics.Error("chat.tools.settings", e); }         }`
- `button.ToggleMode` = `true`
- `button.TooltipText` = `"开启严格工具调用：AI总是口头答应但不生效？尝试开启此选项使用API允许的强制工具调用进行交互。\n已测试 DeepSeek 官方 API，其他渠道可用性未知。"`
- `Enabled` = `options.ChatTools`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `options.ChatTools` = `enabled`
- `ViewData.Ai.ChatTools` = `enabled`

<a id="symbol-3ff003a6c7cb"></a>

## `Paint(bool) — void Paint(bool enabled)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildChatToolToggle(Godot.HBoxContainer)`](ChatToolToggle.cs.md#symbol-cdbc2a8ad7ca)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.CanvasItem.QueueRedraw()`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ChatToolIcon.Enabled`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`icon.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: icon.QueueRedraw();`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(enabled ? "244850" : "1c3040", enabled ? "78dcd2" : "405b70", 8, 8))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(enabled ? "244850" : "1c3040", enabled ? "78dcd2" : "405b70", 8, 8));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("244850", "78dcd2", 8, 8))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("244850", "78dcd2", 8, 8));`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("244850", "78dcd2", 8, 8)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("244850", "78dcd2", 8, 8)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(enabled ? "244850" : "1c3040", enabled ? "78dcd2" : "405b70", 8, 8)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(enabled ? "244850" : "1c3040", enabled ? "78dcd2" : "405b70", 8, 8)`

**赋值（含属性/字段和局部值）：**

- `icon.Enabled` = `enabled`

<a id="symbol-1c12262f73c9"></a>

## `NationalSpire.ChatToolIcon.Enabled — public bool Enabled`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1df6a9235c66"></a>

## `NationalSpire.ChatToolIcon._Ready() — public override void _Ready()`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`

**赋值（含属性/字段和局部值）：**

- `Resized` += `QueueRedraw`

<a id="symbol-2f55f6cb5779"></a>

## `NationalSpire.ChatToolIcon._Draw() — public override void _Draw()`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color, bool, float, bool)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.Color.Color(string)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatToolIcon.Enabled`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center + new Vector2(7, 7), 5, 0, Mathf.Tau, 24, color, 1.2f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center + new Vector2(7, 7), 5, 0, Mathf.Tau, 24, color, 1.2f, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color, bool, float, bool)`；输入表达式：`DrawCircle(center + new Vector2(7, 7), 6, new("142a36"), true, -1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(center + new Vector2(7, 7), 6, new("142a36"), true, -1, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + new Vector2(2, -5), center + new Vector2(-2, 4), color, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + new Vector2(2, -5), center + new Vector2(-2, 4), color, 1.8f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([center + new Vector2(-3, -9), center + new Vector2(-9, -9), center + new Vector2(-9, 8), center + new Vector2(-3, 8)], color, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([center + new Vector2(-3, -9), center + new Vector2(-9, -9), center + new Vector2(-9, 8), center + new Vector2(-3, 8)], color, 1.8f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([center + new Vector2(3, -9), center + new Vector2(9, -9), center + new Vector2(9, -1)], color, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([center + new Vector2(3, -9), center + new Vector2(9, -9), center + new Vector2(9, -1)], color, 1.8f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([center + new Vector2(3, 7), center + new Vector2(6, 10), center + new Vector2(11, 4)], color, 1.9f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([center + new Vector2(3, 7), center + new Vector2(6, 10), center + new Vector2(11, 4)], color, 1.9f, true);`
- `Godot.Color.Color(string)`；输入表达式：`new("142a36")`；返回值紧邻使用处：`ArgumentSyntax: new("142a36")`
- `Godot.Color.Color(string)`；输入表达式：`new("78dcd2")`；返回值紧邻使用处：`ConditionalExpressionSyntax: Enabled ? new("78dcd2") : new("adbdcc")`
- `Godot.Color.Color(string)`；输入表达式：`new("adbdcc")`；返回值紧邻使用处：`ConditionalExpressionSyntax: Enabled ? new("78dcd2") : new("adbdcc")`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-2, 4)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-2, 4)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-3, -9)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-3, -9)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-3, 8)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-3, 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-9, -9)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-9, -9)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-9, 8)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-9, 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(11, 4)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(11, 4)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(2, -5)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(2, -5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(3, -9)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(3, -9)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(3, 7)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(3, 7)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(6, 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(6, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(7, 7)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(7, 7)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(9, -1)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(9, -1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(9, -9)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(9, -9)`

**赋值（含属性/字段和局部值）：**
