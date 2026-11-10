# OpeningControls.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`79C3AAAB279C2E1C3EF6394982440C9B19EDC57F3B91845FDED22B9D6C945F4B`。来源：[源码](../../OpeningControls.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OpeningControls`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-1a0d93051996"></a>

## `NationalSpire.OpeningControls.Label(string, int, Godot.Color?) — internal static Label Label(string text,int size=16,Color? color=null)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawOffers()`](OpeningPlayerEditor.cs.md#symbol-f19f33792b7e)；[`NationalSpire.CareerScreen.DrawEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed[], NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`](EventOpeningScreen.cs.md#symbol-4326f3c30ef2)；[`NationalSpire.CareerScreen.EditEventMaterial(NationalSpire.EventStoryView)`](EventOpeningScreen.cs.md#symbol-682979c85474)；[`NationalSpire.CareerScreen.EditEventPeople(NationalSpire.EventStoryView)`](EventOpeningScreen.cs.md#symbol-4517eea6ac6b)；[`NationalSpire.CareerScreen.LoadEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`](EventOpeningScreen.cs.md#symbol-6b8a94f5911f)；[`NationalSpire.OpeningControls.Card(Godot.Container, string, string, string, bool, System.Action, Godot.ButtonGroup?)`](OpeningControls.cs.md#symbol-16ab05b87293)；[`NationalSpire.OpeningControls.Field(Godot.Container, string)`](OpeningControls.cs.md#symbol-bd0e4ff57612)；[`NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`](OpeningControls.cs.md#symbol-c7ec3402431e)；[`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?, System.Action<string>?)`](OpeningPlayerEditor.cs.md#symbol-8ef16a8054cb)；[`NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld, string)`](OpeningWorldEditor.cs.md#symbol-8745b893c0a1)；[`Refresh()`](EventOpeningScreen.cs.md#symbol-f2701df7b482)；[`Render()`](OpeningClubEditor.cs.md#symbol-0b4184e47a8c)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`l.AddThemeColorOverride("font_color",color??CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: l.AddThemeColorOverride("font_color",color??CareerVisuals.Muted);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`l.AddThemeFontSizeOverride("font_size",size)`；返回值紧邻使用处：`ExpressionStatementSyntax: l.AddThemeFontSizeOverride("font_size",size);`
- `Godot.Label.Label()`；输入表达式：`new Label{Text=text,AutowrapMode=TextServer.AutowrapMode.WordSmart}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Label{Text=text,AutowrapMode=TextServer.AutowrapMode.WordSmart}`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `Text` = `text`

<a id="symbol-c7ec3402431e"></a>

## `NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?) — internal static VBoxContainer Section(Container parent,string name,string icon,string detail,bool open=false,Color? accent=null)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool, string)`](NpcGenerationScreen.cs.md#symbol-7f1e60697c26)；[`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?, System.Action<string>?)`](OpeningPlayerEditor.cs.md#symbol-8ef16a8054cb)；[`NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld, string)`](OpeningWorldEditor.cs.md#symbol-8745b893c0a1)

**调用：** [`Fold(bool)`](OpeningControls.cs.md#symbol-37b5eaaa784a)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；`Godot.Button.Button()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `Fold(bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Fold(bool)`；输入表达式：`Fold(open)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fold(open);`
- `Godot.Button.Button()`；输入表达式：`new Button{Flat=true,ToggleMode=true,ButtonPressed=open,AccessibilityName=name,CustomMinimumSize=new(0,44),MouseDefaultCursorShape=Control.CursorShape.PointingHand}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Button{Flat=true,ToggleMode=true,ButtonPressed=open,AccessibilityName=name,CustomMinimumSize=new(0,44),MouseDefaultCursorShape=Control.CursorShape.PointingHand}`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation",14)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation",14);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("132430","354d5c",9,12))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("132430","354d5c",9,12));`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`line.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer{MouseFilter=Control.MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer{MouseFilter=Control.MouseFilterEnum.Ignore}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`head.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: head.AddChild(line);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(CareerScreen.Glyph(icon,23,accent??CareerVisuals.Gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(CareerScreen.Glyph(icon,23,accent??CareerVisuals.Gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(down)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(down);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(summary)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(summary);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(up)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(up);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(shell)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(shell);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shell.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: shell.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shell.AddChild(head)`；返回值紧邻使用处：`ExpressionStatementSyntax: shell.AddChild(head);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,44)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`CareerScreen.Glyph("chevron-down",18,CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerScreen.Glyph("chevron-down",18,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`CareerScreen.Glyph("chevron-up",18,CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerScreen.Glyph("chevron-up",18,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`CareerScreen.Glyph(icon,23,accent??CareerVisuals.Gold)`；返回值紧邻使用处：`ArgumentSyntax: CareerScreen.Glyph(icon,23,accent??CareerVisuals.Gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("132430","354d5c",9,12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("132430","354d5c",9,12)`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`Label(detail)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Label(detail)`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`Label(name,21,CareerVisuals.Ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Label(name,21,CareerVisuals.Ink)`

**赋值（含属性/字段和局部值）：**

- `AccessibilityName` = `name`
- `ButtonPressed` = `open`
- `CustomMinimumSize` = `new(0,44)`
- `Flat` = `true`
- `head.Toggled` += `Fold`
- `heading.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `line.OffsetLeft` = `9`
- `line.OffsetRight` = `-9`
- `MouseDefaultCursorShape` = `Control.CursorShape.PointingHand`
- `MouseFilter` = `Control.MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `summary.HorizontalAlignment` = `HorizontalAlignment.Right`
- `summary.SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `ToggleMode` = `true`

<a id="symbol-37b5eaaa784a"></a>

## `Fold(bool) — void Fold(bool on)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`](OpeningControls.cs.md#symbol-c7ec3402431e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `box.Visible` = `on`
- `down.Visible` = `!on`
- `up.Visible` = `on`

<a id="symbol-16ab05b87293"></a>

## `NationalSpire.OpeningControls.Card(Godot.Container, string, string, string, bool, System.Action, Godot.ButtonGroup?) — internal static Button Card(Container parent,string title,string detail,string icon,bool chosen,Action select,ButtonGroup? group=null)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool, string)`](NpcGenerationScreen.cs.md#symbol-7f1e60697c26)；[`Tile(string, string, string, bool, System.Action)`](OpeningClubEditor.cs.md#symbol-f5ca20b15dd5)

**调用：** [`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation",12);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`line.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer{MouseFilter=Control.MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer{MouseFilter=Control.MouseFilterEnum.Ignore}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(line);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(CareerScreen.Glyph(icon,23,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(CareerScreen.Glyph(icon,23,CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(words)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(words);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Label(detail,15))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Label(detail,15));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Label(title,20,CareerVisuals.Ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Label(title,20,CareerVisuals.Ink));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{MouseFilter=Control.MouseFilterEnum.Ignore,Alignment=BoxContainer.AlignmentMode.Center,SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{MouseFilter=Control.MouseFilterEnum.Ignore,Alignment=BoxContainer.AlignmentMode.Center,SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,74)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,74)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton{AccessibilityName=title,ToggleMode=true,ButtonGroup=group,ButtonPressed=chosen,CustomMinimumSize=new(0,74),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastButton{AccessibilityName=title,ToggleMode=true,ButtonGroup=group,ButtonPressed=chosen,CustomMinimumSize=new(0,74),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`CareerScreen.Glyph(icon,23,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: CareerScreen.Glyph(icon,23,CareerVisuals.Teal)`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`Label(detail,15)`；返回值紧邻使用处：`ArgumentSyntax: Label(detail,15)`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`Label(title,20,CareerVisuals.Ink)`；返回值紧邻使用处：`ArgumentSyntax: Label(title,20,CareerVisuals.Ink)`

**赋值（含属性/字段和局部值）：**

- `AccessibilityName` = `title`
- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `button.Pressed` += `select.Invoke`
- `ButtonGroup` = `group`
- `ButtonPressed` = `chosen`
- `CustomMinimumSize` = `new(0,74)`
- `line.OffsetLeft` = `16`
- `line.OffsetRight` = `-12`
- `MouseFilter` = `Control.MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `ToggleMode` = `true`

<a id="symbol-93105b3962ff"></a>

## `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action) — internal static Button Chip(Container parent,ButtonGroup group,string title,bool chosen,Action select)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DrawEventLibrary(Godot.VBoxContainer, NationalSpire.RandomEventSeed[], NationalSpire.RandomEventSeed?, System.Action<NationalSpire.RandomEventSeed>)`](EventOpeningScreen.cs.md#symbol-4326f3c30ef2)；[`NationalSpire.CareerScreen.EventModeTabs(Godot.VBoxContainer, string[], int, System.Action<int>)`](EventOpeningScreen.cs.md#symbol-a040f56f2385)；[`NationalSpire.OpeningClubEditor.Choose(Godot.Control, NationalSpire.CareerData, NationalSpire.CareerOpeningWorld)`](OpeningClubEditor.cs.md#symbol-e9ebb9b42754)；[`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?, System.Action<string>?)`](OpeningPlayerEditor.cs.md#symbol-8ef16a8054cb)；[`NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld, string)`](OpeningWorldEditor.cs.md#symbol-8745b893c0a1)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(b);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(66,39)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(66,39)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton{Text=title,ToggleMode=true,ButtonGroup=group,ButtonPressed=chosen,CustomMinimumSize=new(66,39)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastButton{Text=title,ToggleMode=true,ButtonGroup=group,ButtonPressed=chosen,CustomMinimumSize=new(66,39)}`

**赋值（含属性/字段和局部值）：**

- `b.Pressed` += `select.Invoke`
- `ButtonGroup` = `group`
- `ButtonPressed` = `chosen`
- `CustomMinimumSize` = `new(66,39)`
- `Text` = `title`
- `ToggleMode` = `true`

<a id="symbol-bd0e4ff57612"></a>

## `NationalSpire.OpeningControls.Field(Godot.Container, string) — internal static VBoxContainer Field(Container grid,string name)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool, string)`](NpcGenerationScreen.cs.md#symbol-7f1e60697c26)；[`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?, System.Action<string>?)`](OpeningPlayerEditor.cs.md#symbol-8ef16a8054cb)；[`NationalSpire.OpeningWorldEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningWorld, string)`](OpeningWorldEditor.cs.md#symbol-8745b893c0a1)；[`Number(string, string, string, System.Action<string>)`](OpeningPlayerEditor.cs.md#symbol-f2f1b5cd9779)

**调用：** [`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`col.AddThemeConstantOverride("separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddThemeConstantOverride("separation",4);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(Label(name))`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(Label(name));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(col)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(col);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`Label(name)`；返回值紧邻使用处：`ArgumentSyntax: Label(name)`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
