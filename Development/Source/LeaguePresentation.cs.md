# LeaguePresentation.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`14D86EBBC90DB0040F0F9C1E2C0C62D5E503D46C9C9571C09F92D1CBBBA4CDD4`。来源：[源码](../../LeaguePresentation.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CareerScreen.LeagueControl`、`NationalSpire.LeagueGate`。

字段、事件及初始值（源码原样）：

```csharp
private double _time;
private float _door,_impact;
```

<a id="symbol-6a784448b41b"></a>

## `NationalSpire.CareerScreen.LeagueExitButton(System.Action) — internal static Button LeagueExitButton(Action pressed)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.InstallExit(MegaCrit.Sts2.Core.Nodes.NRun)`](LeagueNativeMatch.cs.md#symbol-c7bf6cbb732d)

**调用：** [`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerFocusOutline.ThemeMarker`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；`NationalSpire.CareerScreen.LeagueControl.Back`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeConstantOverride(CareerFocusOutline.ThemeMarker,1)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeConstantOverride(CareerFocusOutline.ThemeMarker,1);`
- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`button.AddThemeFontOverride("font",CareerVisuals.InterfaceText(600))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontOverride("font",CareerVisuals.InterfaceText(600));`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("退出联赛",pressed,140,kind:LeagueControl.Back)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton("退出联赛",pressed,140,kind:LeagueControl.Back)`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText(600)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.InterfaceText(600)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3412750f7453"></a>

## `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl) — private static Button LeagueButton(string title,Action pressed,float width,bool selected=false,string accent="d9ba83",Texture2D? emblem=null,LeagueControl kind=LeagueControl.Action)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`](LeagueDeckEditor.cs.md#symbol-947b5653f588)；[`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)；[`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`](LeagueDeckEditor.cs.md#symbol-19b872317e2a)；[`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.LeagueExitButton(System.Action)`](LeaguePresentation.cs.md#symbol-6a784448b41b)；[`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.CareerScreen.LeagueInspect(NationalSpire.LeagueCards.Entry, bool)`](LeagueScreen.cs.md#symbol-69ed9740453e)；[`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)；[`NationalSpire.CareerScreen.MirrorAppointmentArena(NationalSpire.CareerData, NationalSpire.CareerMatch)`](LeagueArenaScreen.cs.md#symbol-6ac7616bf9f0)；[`Reveal()`](LeagueScreen.cs.md#symbol-31cea69eebc3)

**调用：** [`NationalSpire.CareerMoney.Display(string)`](LifeData.cs.md#symbol-4a2afc43261a)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Button.Button()`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxFlat.SetBorderWidthAll(int)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Display(string)`；`NationalSpire.CareerScreen.LeagueControl.Action`；`NationalSpire.CareerScreen.LeagueControl.Back`；`NationalSpire.CareerScreen.LeagueControl.Filter`；`NationalSpire.CareerScreen.LeagueControl.Primary`；`NationalSpire.CareerScreen.LeagueControl.Step`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button{Text=CareerMoney.Display(title),CustomMinimumSize=new(width,step?38:flat?42:52),MouseDefaultCursorShape=CursorShape.PointingHand,              Icon=emblem,ExpandIcon=true,SizeFlagsHorizontal=SizeFlags.ShrinkCenter}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Button{Text=CareerMoney.Display(title),CustomMinimumSize=new(width,step?38:flat?42:52),MouseDefaultCursorShape=CursorShape.PointingHand,              Icon=emblem,ExpandIcon=true,SizeFlagsHorizontal=SizeFlags.ShrinkCenter}`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`button.DrawColoredPolygon([c+Vector2.Up*3,c+Vector2.Right*3,c+Vector2.Down*3,c+Vector2.Left*3],color)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.DrawColoredPolygon([c+Vector2.Up*3,c+Vector2.Right*3,c+Vector2.Down*3,c+Vector2.Left*3],color);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`button.DrawLine(new(0,9),new(0,sz.Y-9),new Color(ink,.3f),1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.DrawLine(new(0,9),new(0,sz.Y-9),new Color(ink,.3f),1,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`button.DrawLine(new(12,sz.Y-5),new(sz.X-17,sz.Y-5),color,1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.DrawLine(new(12,sz.Y-5),new(sz.X-17,sz.Y-5),color,1,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`button.DrawLine(new(sz.X-1,9),new(sz.X-1,sz.Y-9),new Color(ink,.3f),1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.DrawLine(new(sz.X-1,9),new(sz.X-1,sz.Y-9),new Color(ink,.3f),1,true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`button.DrawPolyline([c+new Vector2(-3*dir,-5),c+new Vector2(2*dir,0),c+new Vector2(-3*dir,5)],color,1.6f,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.DrawPolyline([c+new Vector2(-3*dir,-5),c+new Vector2(2*dir,0),c+new Vector2(-3*dir,5)],color,1.6f,true);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(ink,.25f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: state=="hover"?new Color(ink,.25f):new Color(ink,0f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(ink,.3f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(ink,.3f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(ink,0f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: state=="hover"?new Color(ink,.25f):new Color(ink,0f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(ink,button.Disabled?.18f:selected?.92f:.61f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: primary&&!button.Disabled?new Color("775e39"):new Color(ink,button.Disabled?.18f:selected?.92f:.61f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(ink,selected?.13f:state=="hover"?.09f:0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BgColor=new Color(ink,selected?.13f:state=="hover"?.09f:0)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("19272e")`；返回值紧邻使用处：`ArgumentSyntax: new Color("19272e")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("62717c")`；返回值紧邻使用处：`ArgumentSyntax: new Color("62717c")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("775e39")`；返回值紧邻使用处：`ConditionalExpressionSyntax: primary&&!button.Disabled?new Color("775e39"):new Color(ink,button.Disabled?.18f:selected?.92f:.61f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("d6dddf")`；返回值紧邻使用处：`ConditionalExpressionSyntax: selected?ink:new Color("d6dddf")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("f4daa3")`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BorderColor=new Color("f4daa3")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(accent)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Color(accent)`
- `Godot.Color.Color(string)`；输入表达式：`new Color(state=="normal"?"ddbf8c":"f5ddb1")`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BgColor=new Color(state=="normal"?"ddbf8c":"f5ddb1")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_color",selected?ink:new Color("d6dddf"))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_color",selected?ink:new Color("d6dddf"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_disabled_color",new Color("62717c"))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_disabled_color",new Color("62717c"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_hover_color",ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_hover_color",ink);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride(state,new Color("19272e"))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride(state,new Color("19272e"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeConstantOverride("h_separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeConstantOverride("h_separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeConstantOverride("icon_max_width",34)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeConstantOverride("icon_max_width",34);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size",21)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size",21);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size",width<65?21:17)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size",width<65?21:17);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state,style)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state,style);`
- `Godot.StyleBoxFlat.SetBorderWidthAll(int)`；输入表达式：`style.SetBorderWidthAll(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: style.SetBorderWidthAll(0);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-3*dir,-5)`；返回值紧邻使用处：`BinaryExpressionSyntax: c+new Vector2(-3*dir,-5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-3*dir,5)`；返回值紧邻使用处：`BinaryExpressionSyntax: c+new Vector2(-3*dir,5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(10,sz.Y/2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Vector2(10,sz.Y/2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(2*dir,0)`；返回值紧邻使用处：`BinaryExpressionSyntax: c+new Vector2(2*dir,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,9)`；返回值紧邻使用处：`ArgumentSyntax: new(0,9)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,sz.Y-9)`；返回值紧邻使用处：`ArgumentSyntax: new(0,sz.Y-9)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(12,sz.Y-5)`；返回值紧邻使用处：`ArgumentSyntax: new(12,sz.Y-5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(primary?sz.X-15:16,sz.Y/2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new(primary?sz.X-15:16,sz.Y/2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(sz.X-1,9)`；返回值紧邻使用处：`ArgumentSyntax: new(sz.X-1,9)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(sz.X-1,sz.Y-9)`；返回值紧邻使用处：`ArgumentSyntax: new(sz.X-1,sz.Y-9)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(sz.X-17,sz.Y-5)`；返回值紧邻使用处：`ArgumentSyntax: new(sz.X-17,sz.Y-5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,step?38:flat?42:52)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(width,step?38:flat?42:52)`
- `NationalSpire.CareerMoney.Display(string)`；输入表达式：`CareerMoney.Display(title)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text=CareerMoney.Display(title)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(fill,border,width<65?10:4,width<65?3:9)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerVisuals.Box(fill,border,width<65?10:4,width<65?3:9)`

**赋值（含属性/字段和局部值）：**

- `button.Draw` += `()=>{              var sz=button.Size;var color=primary&&!button.Disabled?new Color("775e39"):new Color(ink,button.Disabled?.18f:selected?.92f:.61f);              if(step&&button.Text=="＋")button.DrawLine(new(0,9),new(0,sz.Y-9),new Color(ink,.3f),1,true);              if(step&&button.Text=="−")button.DrawLine(new(sz.X-1,9),new(sz.X-1,sz.Y-9),new Color(ink,.3f),1,true);              if(kind==LeagueControl.Filter){var c=new Vector2(10,sz.Y/2);button.DrawColoredPolygon([c+Vector2.Up*3,c+Vector2.Right*3,c+Vector2.Down*3,c+Vector2.Left*3],color);}              if(primary||kind==LeagueControl.Back){float dir=primary?1:-1;Vector2 c=new(primary?sz.X-15:16,sz.Y/2);button.DrawPolyline([c+new Vector2(-3*dir,-5),c+new Vector2(2*dir,0),c+new Vector2(-3*dir,5)],color,1.6f,true);}              if(primary)button.DrawLine(new(12,sz.Y-5),new(sz.X-17,sz.Y-5),color,1,true);          }`
- `button.Pressed` += `pressed`
- `CustomMinimumSize` = `new(width,step?38:flat?42:52)`
- `ExpandIcon` = `true`
- `Icon` = `emblem`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`
- `style.BgColor` = `new Color(ink,selected?.13f:state=="hover"?.09f:0)`
- `style.BgColor` = `new Color(state=="normal"?"ddbf8c":"f5ddb1")`
- `style.BgColor` = `state=="hover"?new Color(ink,.25f):new Color(ink,0f)`
- `style.BorderColor` = `new Color("f4daa3")`
- `style.BorderWidthBottom` = `selected&&state=="normal"?3:1`
- `style.BorderWidthBottom` = `selected||state=="hover"?2:0`
- `style.BorderWidthLeft` = `style.BorderWidthTop=0`
- `style.BorderWidthRight` = `style.BorderWidthLeft=style.BorderWidthTop=0`
- `style.BorderWidthTop` = `0`
- `style.ContentMarginLeft` = `style.ContentMarginRight=2`
- `style.ContentMarginRight` = `2`
- `style.ContentMarginRight` = `34`
- `style.CornerRadiusBottomLeft` = `style.CornerRadiusBottomRight=18`
- `style.CornerRadiusBottomLeft` = `width<65?10:12`
- `style.CornerRadiusBottomRight` = `18`
- `style.CornerRadiusTopLeft` = `style.CornerRadiusTopRight=style.CornerRadiusBottomLeft=style.CornerRadiusBottomRight=18`
- `style.CornerRadiusTopRight` = `style.CornerRadiusBottomLeft=style.CornerRadiusBottomRight=18`
- `style.CornerRadiusTopRight` = `style.CornerRadiusBottomLeft=width<65?10:12`
- `Text` = `CareerMoney.Display(title)`

<a id="symbol-d0f5e74370fa"></a>

## `NationalSpire.LeagueGate.Door — public float Door`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueGate._door`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_door` = `value`

<a id="symbol-4a41135b87a3"></a>

## `NationalSpire.LeagueGate.Impact — public float Impact`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueGate._impact`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_impact` = `value`

<a id="symbol-81cb77b4a66b"></a>

## `NationalSpire.LeagueGate._Process(double) — public override void _Process(double delta)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueGate._time`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_time` += `delta`

<a id="symbol-5304a85826be"></a>

## `NationalSpire.LeagueGate._Draw() — public override void _Draw()`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Q(float, float)`](LeaguePresentation.cs.md#symbol-737b03012b24)；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string, float)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Rotated(float)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueGate._door`；`NationalSpire.LeagueGate._impact`；`NationalSpire.LeagueGate._time`；`Q(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(c,109*unit,(float)_time,(float)_time+.75f,20,blue,2*unit,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(c,109*unit,(float)_time,(float)_time+.75f,20,blue,2*unit,true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(c,r*unit,0,Mathf.Tau,100,new Color(gold,r==91?.65f:.21f),1.5f*unit,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(c,r*unit,0,Mathf.Tau,100,new Color(gold,r==91?.65f:.21f),1.5f*unit,true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(hc,66*unit,dir<0?Mathf.Pi*.5f:-Mathf.Pi*.5f,dir<0?Mathf.Pi*1.5f:Mathf.Pi*.5f,50,gold,3*unit,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(hc,66*unit,dir<0?Mathf.Pi*.5f:-Mathf.Pi*.5f,dir<0?Mathf.Pi*1.5f:Mathf.Pi*.5f,50,gold,3*unit,true);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(band,new Color(k==0?"152b35":"292a2a"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(band,new Color(k==0?"152b35":"292a2a"));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(panel,new Color(dir<0?"1c303b":"303439"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(panel,new Color(dir<0?"1c303b":"303439"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(band[0],band[1],new Color(tone,.38f),2*unit,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(band[0],band[1],new Color(tone,.38f),2*unit,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(band[2],band[3],new Color(tone,.26f),unit,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(band[2],band[3],new Color(tone,.26f),unit,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(c+v*95*unit,c+v*(i%5==0?104:98)*unit,new Color(gold,.63f),unit,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(c+v*95*unit,c+v*(i%5==0?104:98)*unit,new Color(gold,.63f),unit,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(c+v*r,c+v*(r+12*unit*_impact),new Color(gold,_impact),2*unit,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(c+v*r,c+v*(r+12*unit*_impact),new Color(gold,_impact),2*unit,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(c.X,0),new(c.X,s.Y),new Color("ffedcd",_impact),6*unit,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(c.X,0),new(c.X,s.Y),new Color("ffedcd",_impact),6*unit,true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(edge,gold,4*unit,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(edge,gold,4*unit,true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(stroke,new Color(dir<0?blue:gold,n==2?.55f:.18f),2*unit,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(stroke,new Color(dir<0?blue:gold,n==2?.55f:.18f),2*unit,true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new(Vector2.Zero,s),new Color("0c1722"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new(Vector2.Zero,s),new Color("0c1722"));`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(dir<0?blue:gold,n==2?.55f:.18f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(dir<0?blue:gold,n==2?.55f:.18f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(gold,_impact)`；返回值紧邻使用处：`ArgumentSyntax: new Color(gold,_impact)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(gold,.63f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(gold,.63f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(gold,r==91?.65f:.21f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(gold,r==91?.65f:.21f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(tone,.26f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(tone,.26f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(tone,.38f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(tone,.38f)`
- `Godot.Color.Color(string, float)`；输入表达式：`new Color("ffedcd",_impact)`；返回值紧邻使用处：`ArgumentSyntax: new Color("ffedcd",_impact)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0c1722")`；返回值紧邻使用处：`ArgumentSyntax: new Color("0c1722")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("7fc8cd")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Color("7fc8cd")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("e7c588")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Color("e7c588")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(dir<0?"1c303b":"303439")`；返回值紧邻使用处：`ArgumentSyntax: new Color(dir<0?"1c303b":"303439")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(k==0?"152b35":"292a2a")`；返回值紧邻使用处：`ArgumentSyntax: new Color(k==0?"152b35":"292a2a")`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new(Vector2.Zero,s)`；返回值紧邻使用处：`ArgumentSyntax: new(Vector2.Zero,s)`
- `Godot.Vector2.Rotated(float)`；输入表达式：`Vector2.Right.Rotated(i*2.39996f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Vector2.Right.Rotated(i*2.39996f)`
- `Godot.Vector2.Rotated(float)`；输入表达式：`Vector2.Up.Rotated(i*Mathf.Tau/60)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Vector2.Up.Rotated(i*Mathf.Tau/60)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(at,c.Y)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Vector2(at,c.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(dir*s.X*.10f,-62*unit)`；返回值紧邻使用处：`BinaryExpressionSyntax: c+new Vector2(dir*s.X*.10f,-62*unit)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(dir*s.X*.13f,115*unit)`；返回值紧邻使用处：`BinaryExpressionSyntax: c+new Vector2(dir*s.X*.13f,115*unit)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(dir*s.X*.56f,-s.Y*.36f)`；返回值紧邻使用处：`BinaryExpressionSyntax: c+new Vector2(dir*s.X*.56f,-s.Y*.36f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(dir*s.X*.56f,s.Y*.42f)`；返回值紧邻使用处：`BinaryExpressionSyntax: c+new Vector2(dir*s.X*.56f,s.Y*.42f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(c.X,0)`；返回值紧邻使用处：`ArgumentSyntax: new(c.X,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(c.X,s.Y)`；返回值紧邻使用处：`ArgumentSyntax: new(c.X,s.Y)`
- `Q(float, float)`；输入表达式：`Q(0,.38f)`；返回值紧邻使用处：`ExpressionElementSyntax: Q(0,.38f)`
- `Q(float, float)`；输入表达式：`Q(0,.62f)`；返回值紧邻使用处：`ExpressionElementSyntax: Q(0,.62f)`
- `Q(float, float)`；输入表达式：`Q(28,.30f)`；返回值紧邻使用处：`ExpressionElementSyntax: Q(28,.30f)`
- `Q(float, float)`；输入表达式：`Q(28,.70f)`；返回值紧邻使用处：`ExpressionElementSyntax: Q(28,.70f)`
- `Q(float, float)`；输入表达式：`Q(28,0)`；返回值紧邻使用处：`ExpressionElementSyntax: Q(28,0)`
- `Q(float, float)`；输入表达式：`Q(28,1)`；返回值紧邻使用处：`ExpressionElementSyntax: Q(28,1)`
- `Q(float, float)`；输入表达式：`Q(s.X/unit,0)`；返回值紧邻使用处：`ExpressionElementSyntax: Q(s.X/unit,0)`
- `Q(float, float)`；输入表达式：`Q(s.X/unit,1)`；返回值紧邻使用处：`ExpressionElementSyntax: Q(s.X/unit,1)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`edge.Select(p=>p+Vector2.Right*dir*(9+n*n*9)*unit)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: edge.Select(p=>p+Vector2.Right*dir*(9+n*n*9)*unit).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`edge.Select(p=>p+Vector2.Right*dir*(9+n*n*9)*unit).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =edge.Select(p=>p+Vector2.Right*dir*(9+n*n*9)*unit).ToArray()`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(s.X/1700,s.Y/900)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(s.X/1700,s.Y/900)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-737b03012b24"></a>

## `Q(float, float) — Vector2 Q(float x,float y)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueGate._Draw()`](LeaguePresentation.cs.md#symbol-5304a85826be)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(at+dir*x*unit,y*s.Y)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>new(at+dir*x*unit,y*s.Y)`

**赋值（含属性/字段和局部值）：**
