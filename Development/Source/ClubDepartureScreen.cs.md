# ClubDepartureScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`3C89EF1B5C3E4FDEA0961C5243CBC629346B8B7ECC5F3FCEF2AAD286A64F995C`。来源：[源码](../../ClubDepartureScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-6954ceb20cdf"></a>

## `NationalSpire.CareerScreen.ClubLeaveDialog() — private void ClubLeaveDialog()`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ClubDeparture.Error(NationalSpire.CareerData)`](ClubDeparture.cs.md#symbol-6a8d833b4197)；[`NationalSpire.ClubDeparture.Leave(NationalSpire.CareerData)`](ClubDeparture.cs.md#symbol-1579a5b3a3c8)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.RichTextLabel.RichTextLabel()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerScreen._clubDraft`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._ownerSection`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ClubDeparture.Error(NationalSpire.CareerData)`；`NationalSpire.ClubDeparture.Leave(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`message.AddThemeColorOverride("default_color", _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: message.AddThemeColorOverride("default_color", _ink);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`message.AddThemeFontSizeOverride("normal_font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: message.AddThemeFontSizeOverride("normal_font_size", 18);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(message);`
- `Godot.RichTextLabel.RichTextLabel()`；输入表达式：`new RichTextLabel { Name = "ClubDepartureWarning", BbcodeEnabled = true, FitContent = true, ScrollActive = false,                     SizeFlagsHorizontal = SizeFlags.ExpandFill, Text = "退出后将[color=#ee929d][b]永久失去[/b][/color]俱乐部管理权且可能无法再次加入同俱乐部，是否确认？" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new RichTextLabel { Name = "ClubDepartureWarning", BbcodeEnabled = true, FitContent = true, ScrollActive = false,                     SizeFlagsHorizontal = SizeFlags.ExpandFill, Text = "退出后将[color=#ee929d][b]永久失去[/b][/color]俱乐部管理权且可能无法再次加入同俱乐部，是否确认？" }`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-leave-club", data.Esports.ClubId)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("propose-leave-club", data.Esports.ClubId)) return true;`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("退出俱乐部", owner ? "" : "退出后可能无法再次加入同俱乐部，是否确认？", () =>         {             var data = ViewData;             if (ClubDeparture.Error(data) is { } reason) { error!.Text = reason; return false; }             if (MultiplayerCommand("propose-leave-club", data.Esports.ClubId)) return true;             var result = ClubDeparture.Leave(data);             if (result != null) { error!.Text = result; return false; }             _clubDraft = null; _ownerSection = "阵容"; Render(); return true;         }, "确认退出", box =>         {             if (owner)             {                 var message = new RichTextLabel { Name = "ClubDepartureWarning", BbcodeEnabled = true, FitContent = true, ScrollActive = false,                     SizeFlagsHorizontal = SizeFlags.ExpandFill, Text = "退出后将[color=#ee929d][b]永久失去[/b][/color]俱乐部管理权且可能无法再次加入同俱乐部，是否确认？" };                 message.AddThemeFontSizeOverride("normal_font_size", 18); message.AddThemeColorOverride("default_color", _ink); box.AddChild(message);             }             error = Text("", 16, new Color("ee929d")); error.Name = "ClubDepartureError"; box.AddChild(error);         })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("退出俱乐部", owner ? "" : "退出后可能无法再次加入同俱乐部，是否确认？", () =>         {             var data = ViewData;             if (ClubDeparture.Error(data) is { } reason) { error!.Text = reason; return false; }             if (MultiplayerCommand("propose-leave-club", data.Esports.ClubId)) return true;             var result = ClubDeparture.Leave(data);             if (result != null) { error!.Text = result; return false; }             _clubDraft = null; _ownerSection = "阵容"; Render(); return true;         }, "确认退出", box =>         {             if (owner)             {                 var message = new RichTextLabel { Name = "ClubDepartureWarning", BbcodeEnabled = true, FitContent = true, ScrollActive = false,                     SizeFlagsHorizontal = SizeFlags.ExpandFill, Text = "退出后将[color=#ee929d][b]永久失去[/b][/color]俱乐部管理权且可能无法再次加入同俱乐部，是否确认？" };                 message.AddThemeFontSizeOverride("normal_font_size", 18); message.AddThemeColorOverride("default_color", _ink); box.AddChild(message);             }             error = Text("", 16, new Color("ee929d")); error.Name = "ClubDepartureError"; box.AddChild(error);         });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 16, new Color("ee929d"))`
- `NationalSpire.ClubDeparture.Error(NationalSpire.CareerData)`；输入表达式：`ClubDeparture.Error(data)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ClubDeparture.Error(data) is { } reason`
- `NationalSpire.ClubDeparture.Leave(NationalSpire.CareerData)`；输入表达式：`ClubDeparture.Leave(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubDeparture.Leave(data)`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.IsOwner(ViewData)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.IsOwner(ViewData)`

**赋值（含属性/字段和局部值）：**

- `_clubDraft` = `null`
- `_ownerSection` = `"阵容"`
- `BbcodeEnabled` = `true`
- `error!.Text` = `reason`
- `error!.Text` = `result`
- `error.Name` = `"ClubDepartureError"`
- `error` = `Text("", 16, new Color("ee929d"))`
- `FitContent` = `true`
- `Name` = `"ClubDepartureWarning"`
- `ScrollActive` = `false`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `"退出后将[color=#ee929d][b]永久失去[/b][/color]俱乐部管理权且可能无法再次加入同俱乐部，是否确认？"`
