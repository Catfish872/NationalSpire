# CareerDropdownLayer.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`053829AF299A21AD5A9C461ED4E9010CC235BB78E378917DA4076DF1AB3F5F06`。来源：[源码](../../CareerDropdownLayer.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerDropdownLayer`。

字段、事件及初始值（源码原样）：

```csharp
private Button? _anchor;
private PopupMenu? _menu;
private ItemList? _list;
private Action? _closed;
```

<a id="symbol-4de44cb328a0"></a>

## `NationalSpire.CareerDropdownLayer.At(Godot.Control) — internal static CareerDropdownLayer At(Control control)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatModelPickerOpen`](ChatUtilitiesScreen.cs.md#symbol-381ceff6cf39)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)；[`NationalSpire.CareerScreen.TickWeekly(double)`](WeeklyScreen.cs.md#symbol-90f7d7772fea)

**调用：** [`NationalSpire.LandscapeViewport.StageOf(Godot.Control)`](DashboardViewport.cs.md#symbol-736b054e3fef)；`Godot.Node.GetNode<T>(Godot.NodePath)`

**字段、属性、事件及方法组引用：** `NationalSpire.LandscapeViewport.StageOf(Godot.Control)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetNode<T>(Godot.NodePath)`；输入表达式：`LandscapeViewport.StageOf(control).GetNode<CareerDropdownLayer>("CareerDropdowns")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => LandscapeViewport.StageOf(control).GetNode<CareerDropdownLayer>("CareerDropdowns")`
- `NationalSpire.LandscapeViewport.StageOf(Godot.Control)`；输入表达式：`LandscapeViewport.StageOf(control)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LandscapeViewport.StageOf(control).GetNode<CareerDropdownLayer>`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9296f1acb0ef"></a>

## `NationalSpire.CareerDropdownLayer.Showing(Godot.Button) — internal bool Showing(Button control)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatModelPickerOpen`](ChatUtilitiesScreen.cs.md#symbol-381ceff6cf39)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)；[`NationalSpire.CareerScreen.TickWeekly(double)`](WeeklyScreen.cs.md#symbol-90f7d7772fea)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerDropdownLayer._anchor`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b5729ac5226d"></a>

## `NationalSpire.CareerDropdownLayer._Input(Godot.InputEvent) — public override void _Input(InputEvent e)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerDropdownLayer.Close()`](CareerDropdownLayer.cs.md#symbol-52d15bb810b8)；[`NationalSpire.CareerDropdownLayer.Open(Godot.Button, Godot.PopupMenu, System.Action?)`](CareerDropdownLayer.cs.md#symbol-bf23af955811)；[`NationalSpire.LandscapeViewport.StageOf(Godot.Control)`](DashboardViewport.cs.md#symbol-736b054e3fef)；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.InputEvent.IsActionPressed(Godot.StringName, bool, bool)`；`Godot.MenuButton.GetPopup()`；`Godot.Node.GetParent()`；`Godot.Node.GetViewport()`；`Godot.OptionButton.GetPopup()`；`Godot.Viewport.GuiGetFocusOwner()`；`Godot.Viewport.GuiGetHoveredControl()`；`Godot.Viewport.SetInputAsHandled()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerDropdownLayer._anchor`；`NationalSpire.CareerDropdownLayer.Close()`；`NationalSpire.CareerDropdownLayer.Open(Godot.Button, Godot.PopupMenu, System.Action?)`；`NationalSpire.LandscapeViewport.StageOf(Godot.Control)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsVisibleInTree()`
- `Godot.InputEvent.IsActionPressed(Godot.StringName, bool, bool)`；输入表达式：`e.IsActionPressed("ui_accept")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !e.IsActionPressed("ui_accept")`
- `Godot.InputEvent.IsActionPressed(Godot.StringName, bool, bool)`；输入表达式：`e.IsActionPressed("ui_cancel")`；返回值紧邻使用处：`IfStatementSyntax: if (e.IsActionPressed("ui_cancel")) { viewport.SetInputAsHandled(); Close(); }`
- `Godot.MenuButton.GetPopup()`；输入表达式：`m.GetPopup()`；返回值紧邻使用处：`SwitchExpressionArmSyntax: MenuButton m => m.GetPopup()`
- `Godot.Node.GetParent()`；输入表达式：`GetParent()`；返回值紧邻使用处：`BinaryExpressionSyntax: LandscapeViewport.StageOf(b) != GetParent()`
- `Godot.Node.GetParent()`；输入表达式：`n.GetParent()`；返回值紧邻使用处：`AssignmentExpressionSyntax: n = n.GetParent()`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetViewport()`
- `Godot.OptionButton.GetPopup()`；输入表达式：`o.GetPopup()`；返回值紧邻使用处：`SwitchExpressionArmSyntax: OptionButton o => o.GetPopup()`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`viewport.GuiGetFocusOwner()`；返回值紧邻使用处：`ConditionalExpressionSyntax: click ? viewport.GuiGetHoveredControl() : viewport.GuiGetFocusOwner()`
- `Godot.Viewport.GuiGetHoveredControl()`；输入表达式：`viewport.GuiGetHoveredControl()`；返回值紧邻使用处：`ConditionalExpressionSyntax: click ? viewport.GuiGetHoveredControl() : viewport.GuiGetFocusOwner()`
- `Godot.Viewport.SetInputAsHandled()`；输入表达式：`viewport.SetInputAsHandled()`；返回值紧邻使用处：`ExpressionStatementSyntax: viewport.SetInputAsHandled();`
- `NationalSpire.CareerDropdownLayer.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`
- `NationalSpire.CareerDropdownLayer.Open(Godot.Button, Godot.PopupMenu, System.Action?)`；输入表达式：`Open(b, menu)`；返回值紧邻使用处：`ExpressionStatementSyntax: Open(b, menu);`
- `NationalSpire.LandscapeViewport.StageOf(Godot.Control)`；输入表达式：`LandscapeViewport.StageOf(b)`；返回值紧邻使用处：`BinaryExpressionSyntax: LandscapeViewport.StageOf(b) != GetParent()`

**赋值（含属性/字段和局部值）：**

- `n` = `n.GetParent()`

<a id="symbol-da836734abc7"></a>

## `NationalSpire.CareerDropdownLayer._GuiInput(Godot.InputEvent) — public override void _GuiInput(InputEvent e)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerDropdownLayer.Close()`](CareerDropdownLayer.cs.md#symbol-52d15bb810b8)；`Godot.Control.AcceptEvent()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerDropdownLayer._anchor`；`NationalSpire.CareerDropdownLayer.Close()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AcceptEvent()`；输入表达式：`AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: AcceptEvent();`
- `NationalSpire.CareerDropdownLayer.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bf23af955811"></a>

## `NationalSpire.CareerDropdownLayer.Open(Godot.Button, Godot.PopupMenu, System.Action?) — internal void Open(Button anchor, PopupMenu menu, Action? closed = null)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerDropdownLayer._Input(Godot.InputEvent)`](CareerDropdownLayer.cs.md#symbol-b5729ac5226d)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)

**调用：** [`NationalSpire.CareerDropdownLayer.Caption(Godot.PopupMenu, Godot.Button, int)`](CareerDropdownLayer.cs.md#symbol-3f6f454148f0)；[`NationalSpire.CareerDropdownLayer.Choose(int)`](CareerDropdownLayer.cs.md#symbol-2c282384c30b)；[`NationalSpire.CareerDropdownLayer.Close()`](CareerDropdownLayer.cs.md#symbol-52d15bb810b8)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；`Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.CanvasItem.MoveToFront()`；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；`Godot.Control.GrabFocus()`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.GodotObject.EmitSignal(Godot.StringName, params Godot.Variant[])`；`Godot.ItemList.AddItem(string, Godot.Texture2D, bool)`；`Godot.ItemList.EnsureCurrentIsVisible()`；`Godot.ItemList.ForceUpdateListSize()`；`Godot.ItemList.GetItemRect(int, bool)`；`Godot.ItemList.ItemList()`；`Godot.ItemList.Select(int, bool)`；`Godot.ItemList.SetItemDisabled(int, bool)`；`Godot.ItemList.SetItemTooltip(int, string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PopupMenu.GetItemIcon(int)`；`Godot.PopupMenu.GetItemTooltip(int)`；`Godot.PopupMenu.IsItemChecked(int)`；`Godot.PopupMenu.IsItemDisabled(int)`；`Godot.PopupMenu.IsItemRadioCheckable(int)`；`Godot.PopupMenu.IsItemSeparator(int)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Transform2D.AffineInverse()`；`Godot.Vector2.Vector2(float, float)`；`Godot.Vector2I.Vector2I(int, int)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Math.Clamp(float, float, float)`；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerDropdownLayer._anchor`；`NationalSpire.CareerDropdownLayer._closed`；`NationalSpire.CareerDropdownLayer._list`；`NationalSpire.CareerDropdownLayer._menu`；`NationalSpire.CareerDropdownLayer.AnchorVisibility()`；`NationalSpire.CareerDropdownLayer.Caption(Godot.PopupMenu, Godot.Button, int)`；`NationalSpire.CareerDropdownLayer.Choose(int)`；`NationalSpire.CareerDropdownLayer.Close()`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`anchor.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`BinaryExpressionSyntax: GetGlobalTransformWithCanvas().AffineInverse() * anchor.GetGlobalTransformWithCanvas()`
- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.CanvasItem.MoveToFront()`；输入表达式：`MoveToFront()`；返回值紧邻使用处：`ExpressionStatementSyntax: MoveToFront();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0,0,0,.35f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: panel.ShadowColor = new Color(0,0,0,.35f)`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`list.AddThemeColorOverride("font_color",CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeColorOverride("font_color",CareerVisuals.Ink);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`list.AddThemeColorOverride("font_selected_color",CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeColorOverride("font_selected_color",CareerVisuals.Teal);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("icon_margin",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("icon_margin",8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("v_separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("v_separation",10);`
- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`list.AddThemeFontOverride("font",CareerVisuals.InterfaceText())`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeFontOverride("font",CareerVisuals.InterfaceText());`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeFontSizeOverride("font_size",18)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeFontSizeOverride("font_size",18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`list.AddThemeStyleboxOverride("focus",new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeStyleboxOverride("focus",new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`list.AddThemeStyleboxOverride("hovered",CareerVisuals.Box("213b49","365866",5,4))`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeStyleboxOverride("hovered",CareerVisuals.Box("213b49","365866",5,4));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`list.AddThemeStyleboxOverride("panel",panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeStyleboxOverride("panel",panel);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`list.AddThemeStyleboxOverride(state,selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeStyleboxOverride(state,selected);`
- `Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；输入表达式：`list.GetThemeFont("font")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = list.GetThemeFont("font")`
- `Godot.Control.GrabFocus()`；输入表达式：`list.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: list.GrabFocus();`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`font.GetStringSize(label,fontSize:18)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: font.GetStringSize(label,fontSize:18).X`
- `Godot.GodotObject.EmitSignal(Godot.StringName, params Godot.Variant[])`；输入表达式：`menu.EmitSignal(PopupMenu.SignalName.AboutToPopup)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.EmitSignal(PopupMenu.SignalName.AboutToPopup);`
- `Godot.ItemList.AddItem(string, Godot.Texture2D, bool)`；输入表达式：`list.AddItem(label,menu.GetItemIcon(i),!disabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddItem(label,menu.GetItemIcon(i),!disabled);`
- `Godot.ItemList.EnsureCurrentIsVisible()`；输入表达式：`list.EnsureCurrentIsVisible()`；返回值紧邻使用处：`ExpressionStatementSyntax: list.EnsureCurrentIsVisible();`
- `Godot.ItemList.ForceUpdateListSize()`；输入表达式：`list.ForceUpdateListSize()`；返回值紧邻使用处：`ExpressionStatementSyntax: list.ForceUpdateListSize();`
- `Godot.ItemList.GetItemRect(int, bool)`；输入表达式：`list.GetItemRect(menu.ItemCount-1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: list.GetItemRect(menu.ItemCount-1).End`
- `Godot.ItemList.ItemList()`；输入表达式：`new ItemList { Name = "CareerDropdownItems", MaxColumns = 1, AllowRmbSelect = false,             FixedIconSize = new(26,26), MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ItemList { Name = "CareerDropdownItems", MaxColumns = 1, AllowRmbSelect = false,             FixedIconSize = new(26,26), MouseDefaultCursorShape = CursorShape.PointingHand }`
- `Godot.ItemList.Select(int, bool)`；输入表达式：`list.Select(current)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.Select(current);`
- `Godot.ItemList.SetItemDisabled(int, bool)`；输入表达式：`list.SetItemDisabled(i,disabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.SetItemDisabled(i,disabled);`
- `Godot.ItemList.SetItemTooltip(int, string)`；输入表达式：`list.SetItemTooltip(i,menu.GetItemTooltip(i))`；返回值紧邻使用处：`ExpressionStatementSyntax: list.SetItemTooltip(i,menu.GetItemTooltip(i));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(list);`
- `Godot.PopupMenu.GetItemIcon(int)`；输入表达式：`menu.GetItemIcon(i)`；返回值紧邻使用处：`ArgumentSyntax: menu.GetItemIcon(i)`
- `Godot.PopupMenu.GetItemIcon(int)`；输入表达式：`menu.GetItemIcon(i)`；返回值紧邻使用处：`BinaryExpressionSyntax: menu.GetItemIcon(i)!=null`
- `Godot.PopupMenu.GetItemTooltip(int)`；输入表达式：`menu.GetItemTooltip(i)`；返回值紧邻使用处：`ArgumentSyntax: menu.GetItemTooltip(i)`
- `Godot.PopupMenu.IsItemChecked(int)`；输入表达式：`menu.IsItemChecked(i)`；返回值紧邻使用处：`BinaryExpressionSyntax: menu.IsItemRadioCheckable(i) && menu.IsItemChecked(i)`
- `Godot.PopupMenu.IsItemDisabled(int)`；输入表达式：`menu.IsItemDisabled(i)`；返回值紧邻使用处：`BinaryExpressionSyntax: menu.IsItemDisabled(i) || menu.IsItemSeparator(i)`
- `Godot.PopupMenu.IsItemRadioCheckable(int)`；输入表达式：`menu.IsItemRadioCheckable(i)`；返回值紧邻使用处：`BinaryExpressionSyntax: menu.IsItemRadioCheckable(i) && menu.IsItemChecked(i)`
- `Godot.PopupMenu.IsItemSeparator(int)`；输入表达式：`menu.IsItemSeparator(i)`；返回值紧邻使用处：`BinaryExpressionSyntax: menu.IsItemDisabled(i) || menu.IsItemSeparator(i)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero,anchor.Size)`；返回值紧邻使用处：`BinaryExpressionSyntax: transform * new Rect2(Vector2.Zero,anchor.Size)`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: GetGlobalTransformWithCanvas().AffineInverse() * anchor.GetGlobalTransformWithCanvas()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Clamp(rect.Position.X,8,Math.Max(8,Size.X-list.Size.X-8)),             down ? rect.End.Y+4 : rect.Position.Y-4-list.Size.Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: list.Position = new(Math.Clamp(rect.Position.X,8,Math.Max(8,Size.X-list.Size.X-8)),             down ? rect.End.Y+4 : rect.Position.Y-4-list.Size.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Min(width,Size.X-16),480)`；返回值紧邻使用处：`AssignmentExpressionSyntax: list.Size=new(Math.Min(width,Size.X-16),480)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Min(width,Size.X-16),Math.Min(height,Math.Max(40,down?below:above)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: list.Size = new(Math.Min(width,Size.X-16),Math.Min(height,Math.Max(40,down?below:above)))`
- `Godot.Vector2I.Vector2I(int, int)`；输入表达式：`new(26,26)`；返回值紧邻使用处：`AssignmentExpressionSyntax: FixedIconSize = new(26,26)`
- `NationalSpire.CareerDropdownLayer.Caption(Godot.PopupMenu, Godot.Button, int)`；输入表达式：`Caption(menu,anchor,i)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Caption(menu,anchor,i)`
- `NationalSpire.CareerDropdownLayer.Choose(int)`；输入表达式：`Choose((int)i)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choose((int)i);`
- `NationalSpire.CareerDropdownLayer.Choose(int)`；输入表达式：`Choose((int)i)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i => Choose((int)i)`
- `NationalSpire.CareerDropdownLayer.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("132534", "4c6d7c", 9, 8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box("132534", "4c6d7c", 9, 8)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("213b49","365866",5,4)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("213b49","365866",5,4)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("25464f","589994",5,4)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box("25464f","589994",5,4)`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText()`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.InterfaceText()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: closed?.Invoke()`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(rect.Position.X,8,Math.Max(8,Size.X-list.Size.X-8))`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(rect.Position.X,8,Math.Max(8,Size.X-list.Size.X-8))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(40,down?below:above)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(40,down?below:above)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(8,Size.X-list.Size.X-8)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(8,Size.X-list.Size.X-8)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(width,font.GetStringSize(label,fontSize:18).X + (menu.GetItemIcon(i)!=null ? 72 : 44))`；返回值紧邻使用处：`AssignmentExpressionSyntax: width = Math.Max(width,font.GetStringSize(label,fontSize:18).X + (menu.GetItemIcon(i)!=null ? 72 : 44))`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(480, list.GetItemRect(menu.ItemCount-1).End.Y + 19)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(480, list.GetItemRect(menu.ItemCount-1).End.Y + 19)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(height,Math.Max(40,down?below:above))`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(height,Math.Max(40,down?below:above))`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(width,Size.X-16)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(width,Size.X-16)`

**赋值（含属性/字段和局部值）：**

- `_anchor` = `anchor`
- `_closed` = `closed`
- `_list` = `list`
- `_menu` = `menu`
- `AllowRmbSelect` = `false`
- `anchor.TreeExiting` += `Close`
- `anchor.VisibilityChanged` += `AnchorVisibility`
- `current` = `i`
- `FixedIconSize` = `new(26,26)`
- `list.ItemActivated` += `i => Choose((int)i)`
- `list.ItemClicked` += `(i,_,button) => { if (button == (long)MouseButton.Left) Choose((int)i); }`
- `list.Position` = `new(Math.Clamp(rect.Position.X,8,Math.Max(8,Size.X-list.Size.X-8)),             down ? rect.End.Y+4 : rect.Position.Y-4-list.Size.Y)`
- `list.Size` = `new(Math.Min(width,Size.X-16),480)`
- `list.Size` = `new(Math.Min(width,Size.X-16),Math.Min(height,Math.Max(40,down?below:above)))`
- `MaxColumns` = `1`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"CareerDropdownItems"`
- `panel.ShadowColor` = `new Color(0,0,0,.35f)`
- `panel.ShadowSize` = `5`
- `width` = `Math.Max(width,font.GetStringSize(label,fontSize:18).X + (menu.GetItemIcon(i)!=null ? 72 : 44))`

<a id="symbol-3f6f454148f0"></a>

## `NationalSpire.CareerDropdownLayer.Caption(Godot.PopupMenu, Godot.Button, int) — private static string Caption(PopupMenu menu,Button anchor,int i)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerDropdownLayer.Choose(int)`](CareerDropdownLayer.cs.md#symbol-2c282384c30b)；[`NationalSpire.CareerDropdownLayer.Open(Godot.Button, Godot.PopupMenu, System.Action?)`](CareerDropdownLayer.cs.md#symbol-bf23af955811)

**调用：** `Godot.PopupMenu.GetItemText(int)`；`Godot.PopupMenu.IsItemCheckable(int)`；`Godot.PopupMenu.IsItemChecked(int)`；`Godot.PopupMenu.IsItemRadioCheckable(int)`；`Godot.PopupMenu.IsItemSeparator(int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.PopupMenu.GetItemText(int)`；输入表达式：`menu.GetItemText(i)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = menu.GetItemText(i)`
- `Godot.PopupMenu.IsItemCheckable(int)`；输入表达式：`menu.IsItemCheckable(i)`；返回值紧邻使用处：`BinaryExpressionSyntax: menu.IsItemCheckable(i) || menu.IsItemRadioCheckable(i)`
- `Godot.PopupMenu.IsItemChecked(int)`；输入表达式：`menu.IsItemChecked(i)`；返回值紧邻使用处：`ConditionalExpressionSyntax: menu.IsItemChecked(i) ? "✓   " : "　   "`
- `Godot.PopupMenu.IsItemRadioCheckable(int)`；输入表达式：`menu.IsItemRadioCheckable(i)`；返回值紧邻使用处：`BinaryExpressionSyntax: menu.IsItemCheckable(i) || menu.IsItemRadioCheckable(i)`
- `Godot.PopupMenu.IsItemSeparator(int)`；输入表达式：`menu.IsItemSeparator(i)`；返回值紧邻使用处：`BinaryExpressionSyntax: menu.IsItemSeparator(i) && label.Length==0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2c282384c30b"></a>

## `NationalSpire.CareerDropdownLayer.Choose(int) — private void Choose(int index)`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerDropdownLayer.Open(Godot.Button, Godot.PopupMenu, System.Action?)`](CareerDropdownLayer.cs.md#symbol-bf23af955811)

**调用：** [`NationalSpire.CareerDropdownLayer.Caption(Godot.PopupMenu, Godot.Button, int)`](CareerDropdownLayer.cs.md#symbol-3f6f454148f0)；[`NationalSpire.CareerDropdownLayer.Close()`](CareerDropdownLayer.cs.md#symbol-52d15bb810b8)；`Godot.GodotObject.EmitSignal(Godot.StringName, params Godot.Variant[])`；`Godot.ItemList.SetItemText(int, string)`；`Godot.OptionButton.Select(int)`；`Godot.PopupMenu.GetItemId(int)`；`Godot.PopupMenu.IsItemCheckable(int)`；`Godot.PopupMenu.IsItemDisabled(int)`；`Godot.PopupMenu.IsItemSeparator(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerDropdownLayer._anchor`；`NationalSpire.CareerDropdownLayer._list`；`NationalSpire.CareerDropdownLayer._menu`；`NationalSpire.CareerDropdownLayer.Caption(Godot.PopupMenu, Godot.Button, int)`；`NationalSpire.CareerDropdownLayer.Close()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.EmitSignal(Godot.StringName, params Godot.Variant[])`；输入表达式：`menu.EmitSignal(PopupMenu.SignalName.IdPressed,(long)id)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.EmitSignal(PopupMenu.SignalName.IdPressed,(long)id);`
- `Godot.GodotObject.EmitSignal(Godot.StringName, params Godot.Variant[])`；输入表达式：`option.EmitSignal(OptionButton.SignalName.ItemSelected,(long)index)`；返回值紧邻使用处：`ExpressionStatementSyntax: option.EmitSignal(OptionButton.SignalName.ItemSelected,(long)index);`
- `Godot.ItemList.SetItemText(int, string)`；输入表达式：`_list.SetItemText(i,Caption(menu,anchor,i))`；返回值紧邻使用处：`ExpressionStatementSyntax: _list.SetItemText(i,Caption(menu,anchor,i));`
- `Godot.OptionButton.Select(int)`；输入表达式：`option.Select(index)`；返回值紧邻使用处：`ExpressionStatementSyntax: option.Select(index);`
- `Godot.PopupMenu.GetItemId(int)`；输入表达式：`menu.GetItemId(index)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =menu.GetItemId(index)`
- `Godot.PopupMenu.IsItemCheckable(int)`；输入表达式：`menu.IsItemCheckable(index)`；返回值紧邻使用处：`ConditionalExpressionSyntax: menu.IsItemCheckable(index) ? !menu.HideOnCheckableItemSelection : !menu.HideOnItemSelection`
- `Godot.PopupMenu.IsItemDisabled(int)`；输入表达式：`menu.IsItemDisabled(index)`；返回值紧邻使用处：`BinaryExpressionSyntax: _anchor is not {} anchor || _menu is not {} menu || menu.IsItemDisabled(index)`
- `Godot.PopupMenu.IsItemSeparator(int)`；输入表达式：`menu.IsItemSeparator(index)`；返回值紧邻使用处：`BinaryExpressionSyntax: _anchor is not {} anchor || _menu is not {} menu || menu.IsItemDisabled(index) || menu.IsItemSeparator(index)`
- `NationalSpire.CareerDropdownLayer.Caption(Godot.PopupMenu, Godot.Button, int)`；输入表达式：`Caption(menu,anchor,i)`；返回值紧邻使用处：`ArgumentSyntax: Caption(menu,anchor,i)`
- `NationalSpire.CareerDropdownLayer.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-db6375db3ada"></a>

## `NationalSpire.CareerDropdownLayer.AnchorVisibility() — private void AnchorVisibility()`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerDropdownLayer.Close()`](CareerDropdownLayer.cs.md#symbol-52d15bb810b8)；`Godot.CanvasItem.IsVisibleInTree()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerDropdownLayer._anchor`；`NationalSpire.CareerDropdownLayer.Close()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`.IsVisibleInTree()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _anchor?.IsVisibleInTree()`
- `NationalSpire.CareerDropdownLayer.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-52d15bb810b8"></a>

## `NationalSpire.CareerDropdownLayer.Close() — internal void Close()`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerDropdownLayer._GuiInput(Godot.InputEvent)`](CareerDropdownLayer.cs.md#symbol-da836734abc7)；[`NationalSpire.CareerDropdownLayer._Input(Godot.InputEvent)`](CareerDropdownLayer.cs.md#symbol-b5729ac5226d)；[`NationalSpire.CareerDropdownLayer.AnchorVisibility()`](CareerDropdownLayer.cs.md#symbol-db6375db3ada)；[`NationalSpire.CareerDropdownLayer.Choose(int)`](CareerDropdownLayer.cs.md#symbol-2c282384c30b)；[`NationalSpire.CareerDropdownLayer.Open(Godot.Button, Godot.PopupMenu, System.Action?)`](CareerDropdownLayer.cs.md#symbol-bf23af955811)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GetFocusModeWithOverride()`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.IsInsideTree()`；`Godot.Node.QueueFree()`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerDropdownLayer._anchor`；`NationalSpire.CareerDropdownLayer._closed`；`NationalSpire.CareerDropdownLayer._list`；`NationalSpire.CareerDropdownLayer._menu`；`NationalSpire.CareerDropdownLayer.AnchorVisibility()`；`NationalSpire.CareerDropdownLayer.Close()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_list!.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _list!.Hide();`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`anchor.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: anchor.IsVisibleInTree() && anchor.IsInsideTree()`
- `Godot.Control.GetFocusModeWithOverride()`；输入表达式：`anchor.GetFocusModeWithOverride()`；返回值紧邻使用处：`BinaryExpressionSyntax: anchor.GetFocusModeWithOverride()!=FocusModeEnum.None`
- `Godot.Control.GrabFocus()`；输入表达式：`anchor.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: anchor.GrabFocus();`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`anchor.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !anchor.IsQueuedForDeletion()`
- `Godot.Node.IsInsideTree()`；输入表达式：`anchor.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: anchor.IsVisibleInTree() && anchor.IsInsideTree()`
- `Godot.Node.QueueFree()`；输入表达式：`_list.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _list.QueueFree();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: closed?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_anchor` = `null`
- `_closed` = `null`
- `_list` = `null`
- `_menu` = `null`
- `anchor.TreeExiting` -= `Close`
- `anchor.VisibilityChanged` -= `AnchorVisibility`
- `MouseFilter` = `MouseFilterEnum.Ignore`
