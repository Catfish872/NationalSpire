# MatchArenaScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`115A97855BA15C3C1D8E7A20933A2E56EF352CB7032BDB2F4997421089D4E554`。来源：[源码](../../MatchArenaScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MatchArenaBackdrop`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private const int CharacterTileHeight = 60, CharacterTileInset = 18, CharacterCaptionGap = 16;
private Label? _arenaCharacter;
```

<a id="symbol-7955c9e18fc3"></a>

## `NationalSpire.MatchArenaBackdrop.Launch — public bool Launch`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1eaa4b9b695f"></a>

## `NationalSpire.MatchArenaBackdrop._Draw() — public override void _Draw()`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Diamond(float)`](MatchArenaScreen.cs.md#symbol-dfb318f86410)；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolygon(Godot.Vector2[], Godot.Color[], Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `Diamond(float)`；`NationalSpire.MatchArenaBackdrop.Launch`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Diamond(float)`；输入表达式：`Diamond(74)`；返回值紧邻使用处：`ArgumentSyntax: Diamond(74)`
- `Diamond(float)`；输入表达式：`Diamond(74)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Diamond(74).Append`
- `Diamond(float)`；输入表达式：`Diamond(94)`；返回值紧邻使用处：`ArgumentSyntax: Diamond(94)`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(Diamond(74),new Color("152d38"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(Diamond(74),new Color("152d38"));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(Diamond(94),new Color("29474f"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(Diamond(94),new Color("29474f"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(top,bottom,new Color("80e7db53"),1.6f,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(top,bottom,new Color("80e7db53"),1.6f,true);`
- `Godot.CanvasItem.DrawPolygon(Godot.Vector2[], Godot.Color[], Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawPolygon([top,new(w,0),new(w,h),bottom],[new("17383b"),new("17313b"),new("162a38"),new("18313b")])`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolygon([top,new(w,0),new(w,h),bottom],[new("17383b"),new("17313b"),new("162a38"),new("18313b")]);`
- `Godot.CanvasItem.DrawPolygon(Godot.Vector2[], Godot.Color[], Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawPolygon([Vector2.Zero,top,bottom,new(0,h)],[new("26313b"),new("20303b"),new("172a38"),new("1d2d39")])`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolygon([Vector2.Zero,top,bottom,new(0,h)],[new("26313b"),new("20303b"),new("172a38"),new("1d2d39")]);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(loop,new Color("75c6bf"),2,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(loop,new Color("75c6bf"),2,true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；输入表达式：`DrawRect(new Rect2(Vector2.Zero,Size),new Color("4d6570"),false,1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(Vector2.Zero,Size),new Color("4d6570"),false,1);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("152d38")`；返回值紧邻使用处：`ArgumentSyntax: new Color("152d38")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("29474f")`；返回值紧邻使用处：`ArgumentSyntax: new Color("29474f")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("4d6570")`；返回值紧邻使用处：`ArgumentSyntax: new Color("4d6570")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("75c6bf")`；返回值紧邻使用处：`ArgumentSyntax: new Color("75c6bf")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("80e7db53")`；返回值紧邻使用处：`ArgumentSyntax: new Color("80e7db53")`
- `Godot.Color.Color(string)`；输入表达式：`new("162a38")`；返回值紧邻使用处：`ExpressionElementSyntax: new("162a38")`
- `Godot.Color.Color(string)`；输入表达式：`new("172a38")`；返回值紧邻使用处：`ExpressionElementSyntax: new("172a38")`
- `Godot.Color.Color(string)`；输入表达式：`new("17313b")`；返回值紧邻使用处：`ExpressionElementSyntax: new("17313b")`
- `Godot.Color.Color(string)`；输入表达式：`new("17383b")`；返回值紧邻使用处：`ExpressionElementSyntax: new("17383b")`
- `Godot.Color.Color(string)`；输入表达式：`new("18313b")`；返回值紧邻使用处：`ExpressionElementSyntax: new("18313b")`
- `Godot.Color.Color(string)`；输入表达式：`new("1d2d39")`；返回值紧邻使用处：`ExpressionElementSyntax: new("1d2d39")`
- `Godot.Color.Color(string)`；输入表达式：`new("20303b")`；返回值紧邻使用处：`ExpressionElementSyntax: new("20303b")`
- `Godot.Color.Color(string)`；输入表达式：`new("26313b")`；返回值紧邻使用处：`ExpressionElementSyntax: new("26313b")`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero,Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero,Size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0,-74)`；返回值紧邻使用处：`BinaryExpressionSyntax: center+new Vector2(0,-74)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w*.385523f,h)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Vector2(w*.385523f,h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w*.565523f,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Vector2(w*.565523f,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w*.5f,176)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Vector2(w*.5f,176)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,h)`；返回值紧邻使用处：`ExpressionElementSyntax: new(0,h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w,0)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w,h)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w,h)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`Diamond(74).Append(center+new Vector2(0,-74))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Diamond(74).Append(center+new Vector2(0,-74)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Diamond(74).Append(center+new Vector2(0,-74)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Diamond(74).Append(center+new Vector2(0,-74)).ToArray()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dfb318f86410"></a>

## `Diamond(float) — Vector2[] Diamond(float r)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchArenaBackdrop._Draw()`](MatchArenaScreen.cs.md#symbol-1eaa4b9b695f)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-r,0)`；返回值紧邻使用处：`BinaryExpressionSyntax: center+new Vector2(-r,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0,-r)`；返回值紧邻使用处：`BinaryExpressionSyntax: center+new Vector2(0,-r)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0,r)`；返回值紧邻使用处：`BinaryExpressionSyntax: center+new Vector2(0,r)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(r,0)`；返回值紧邻使用处：`BinaryExpressionSyntax: center+new Vector2(r,0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a95468bbc287"></a>

## `NationalSpire.CareerScreen.ArenaIconButton(string, string, System.Action, bool) — private static Button ArenaIconButton(string title, string icon, Action open, bool choice=false)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.MatchReviewButton(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-8876eaeddb03)

**调用：** [`NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`](DashboardControls.cs.md#symbol-34af00babbac)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；`Godot.Button.Button()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Mathf.Ceil(float)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；`NationalSpire.CareerScreen.ButtonStates`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text=title, CustomMinimumSize=new(width,choice?34:52), ToggleMode=choice,              SizeFlagsHorizontal=SizeFlags.ShrinkEnd, SizeFlagsVertical=SizeFlags.ShrinkCenter, MouseDefaultCursorShape=CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Button { Text=title, CustomMinimumSize=new(width,choice?34:52), ToggleMode=choice,              SizeFlagsHorizontal=SizeFlags.ShrinkEnd, SizeFlagsVertical=SizeFlags.ShrinkCenter, MouseDefaultCursorShape=CursorShape.PointingHand }`
- `Godot.Color.Color(string)`；输入表达式：`new Color("82939e")`；返回值紧邻使用处：`ConditionalExpressionSyntax: state=="disabled"? new Color("82939e") : selected? CareerVisuals.Teal : choice?CareerVisuals.Muted:CareerVisuals.Ink`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("icon_"+state+"_color",color)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("icon_"+state+"_color",color);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride(state=="normal"?"font_color":"font_"+state+"_color",color)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride(state=="normal"?"font_color":"font_"+state+"_color",color);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size",size)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size",size);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state,style)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state,style);`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X`
- `Godot.Mathf.Ceil(float)`；输入表达式：`Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X)`；返回值紧邻使用处：`BinaryExpressionSyntax: Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X)+29`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,choice?34:52)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(width,choice?34:52)`
- `NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；输入表达式：`ButtonIcon(button,icon,19)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIcon(button,icon,19);`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(hover?"28434c":choice?"1d3040":"00000000",selected?"80e7db":hover?"658c91":choice?"395365":"304a5a",6,4)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerVisuals.Box(hover?"28434c":choice?"1d3040":"00000000",selected?"80e7db":hover?"658c91":choice?"395365":"304a5a",6,4)`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.InterfaceText().GetStringSize`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(182,content+34)`；返回值紧邻使用处：`ConditionalExpressionSyntax: choice?content+26:Math.Max(182,content+34)`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `open`
- `CustomMinimumSize` = `new(width,choice?34:52)`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `style.ContentMarginLeft` = `style.ContentMarginRight=(width-content)/2`
- `style.ContentMarginRight` = `(width-content)/2`
- `Text` = `title`
- `ToggleMode` = `choice`

<a id="symbol-22155287ec1d"></a>

## `NationalSpire.CareerScreen.ArenaCharacterMenu(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CharacterModel>, int, int, System.Action<int>) — private static OptionButton ArenaCharacterMenu(IReadOnlyList<CharacterModel> characters, int first, int selected, Action<int> choose)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`LoadPortrait(int)`](MatchArenaScreen.cs.md#symbol-e00182c65271)；[`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`](PlayerArchive.cs.md#symbol-9ab35bc5f38f)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.GetItemId(int)`；`Godot.OptionButton.GetPopup()`；`Godot.OptionButton.OptionButton()`；`Godot.Resource.Duplicate(bool)`；`Godot.Theme.GetStylebox(Godot.StringName, Godot.StringName)`；`Godot.Vector2.Vector2(float, float)`；`Godot.Window.AddThemeConstantOverride(Godot.StringName, int)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `LoadMenuPortraits()`；`LoadPortrait(int)`；`NationalSpire.CareerAvatarIcon.Pixels`；`NationalSpire.CareerScreen.ButtonStates`；`NationalSpire.CareerScreen.CharacterCaptionGap`；`NationalSpire.CareerScreen.CharacterTileHeight`；`NationalSpire.CareerScreen.CharacterTileInset`；`NationalSpire.CareerVisuals.CreateTheme()`；`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`picker.AddThemeColorOverride("icon_" + state + "_color", Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddThemeColorOverride("icon_" + state + "_color", Colors.White);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`picker.AddThemeColorOverride("icon_focus_color", Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddThemeColorOverride("icon_focus_color", Colors.White);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`picker.AddThemeConstantOverride("h_separation", CharacterCaptionGap)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddThemeConstantOverride("h_separation", CharacterCaptionGap);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`picker.AddThemeConstantOverride("icon_max_width", CareerAvatarIcon.Pixels)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddThemeConstantOverride("icon_max_width", CareerAvatarIcon.Pixels);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`picker.AddThemeFontSizeOverride("font_size", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddThemeFontSizeOverride("font_size", 22);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`picker.AddThemeStyleboxOverride(state, style)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddThemeStyleboxOverride(state, style);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`picker.AddItem(PlayerArchive.CharacterName(characters[i].Id), i)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddItem(PlayerArchive.CharacterName(characters[i].Id), i);`
- `Godot.OptionButton.GetItemId(int)`；输入表达式：`picker.GetItemId((int)item)`；返回值紧邻使用处：`ArgumentSyntax: picker.GetItemId((int)item)`
- `Godot.OptionButton.GetPopup()`；输入表达式：`picker.GetPopup()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = picker.GetPopup()`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "OtherCharacters", AccessibilityName = "选择其他出战角色",              CustomMinimumSize = new(0, CharacterTileHeight), SizeFlagsHorizontal = SizeFlags.ExpandFill, Alignment = HorizontalAlignment.Left,              FitToLongestItem = false, ClipText = true, AllowReselect = true,              TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "OtherCharacters", AccessibilityName = "选择其他出战角色",              CustomMinimumSize = new(0, CharacterTileHeight), SizeFlagsHorizontal = SizeFlags.ExpandFill, Alignment = HorizontalAlignment.Left,              FitToLongestItem = false, ClipText = true, AllowReselect = true,              TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, MouseDefaultCursorShape = CursorShape.PointingHand }`
- `Godot.Resource.Duplicate(bool)`；输入表达式：`theme.GetStylebox(state, "OptionButton").Duplicate()`；返回值紧邻使用处：`CastExpressionSyntax: (StyleBoxFlat)theme.GetStylebox(state, "OptionButton").Duplicate()`
- `Godot.Theme.GetStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`theme.GetStylebox(state, "OptionButton")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: theme.GetStylebox(state, "OptionButton").Duplicate`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, CharacterTileHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, CharacterTileHeight)`
- `Godot.Window.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`menu.AddThemeConstantOverride("h_separation", CharacterCaptionGap)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.AddThemeConstantOverride("h_separation", CharacterCaptionGap);`
- `Godot.Window.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`menu.AddThemeConstantOverride("icon_max_width", CareerAvatarIcon.Pixels)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.AddThemeConstantOverride("icon_max_width", CareerAvatarIcon.Pixels);`
- `LoadPortrait(int)`；输入表达式：`LoadPortrait((int)item)`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadPortrait((int)item);`
- `LoadPortrait(int)`；输入表达式：`LoadPortrait(selected - first)`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadPortrait(selected - first);`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.CreateTheme()`
- `NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`PlayerArchive.CharacterName(characters[i].Id)`；返回值紧邻使用处：`ArgumentSyntax: PlayerArchive.CharacterName(characters[i].Id)`
- `System.Action<T>.Invoke(T)`；输入表达式：`choose(picker.GetItemId((int)item))`；返回值紧邻使用处：`ExpressionStatementSyntax: choose(picker.GetItemId((int)item));`

**赋值（含属性/字段和局部值）：**

- `AccessibilityName` = `"选择其他出战角色"`
- `Alignment` = `HorizontalAlignment.Left`
- `AllowReselect` = `true`
- `ClipText` = `true`
- `CustomMinimumSize` = `new(0, CharacterTileHeight)`
- `FitToLongestItem` = `false`
- `menu.AboutToPopup` += `LoadMenuPortraits`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `Name` = `"OtherCharacters"`
- `picker.ItemSelected` += `item => { LoadPortrait((int)item); choose(picker.GetItemId((int)item)); }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `style.ContentMarginBottom` = `(CharacterTileHeight - CareerAvatarIcon.Pixels) / 2`
- `style.ContentMarginLeft` = `style.ContentMarginRight = CharacterTileInset`
- `style.ContentMarginRight` = `CharacterTileInset`
- `style.ContentMarginTop` = `style.ContentMarginBottom = (CharacterTileHeight - CareerAvatarIcon.Pixels) / 2`
- `TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`

<a id="symbol-e00182c65271"></a>

## `LoadPortrait(int) — void LoadPortrait(int item)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`LoadMenuPortraits()`](MatchArenaScreen.cs.md#symbol-f18fe2d306eb)；[`NationalSpire.CareerScreen.ArenaCharacterMenu(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CharacterModel>, int, int, System.Action<int>)`](MatchArenaScreen.cs.md#symbol-22155287ec1d)

**调用：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；`Godot.OptionButton.GetItemIcon(int)`；`Godot.OptionButton.GetItemId(int)`；`Godot.OptionButton.SetItemIcon(int, Godot.Texture2D)`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.CareerAvatarIcon.CareerAvatarIcon()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.CareerAvatarIcon.Art`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.GetItemIcon(int)`；输入表达式：`picker.GetItemIcon(item)`；返回值紧邻使用处：`BinaryExpressionSyntax: picker.GetItemIcon(item) != null`
- `Godot.OptionButton.GetItemId(int)`；输入表达式：`picker.GetItemId(item)`；返回值紧邻使用处：`ArgumentSyntax: picker.GetItemId(item)`
- `Godot.OptionButton.SetItemIcon(int, Godot.Texture2D)`；输入表达式：`picker.SetItemIcon(item, new CareerAvatarIcon { Art = art })`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.SetItemIcon(item, new CareerAvatarIcon { Art = art });`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`characters[picker.GetItemId(item)].Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: characters[picker.GetItemId(item)].Id.ToString()`
- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(characters[picker.GetItemId(item)].Id.ToString(), 0, false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AvatarAssets.Load(characters[picker.GetItemId(item)].Id.ToString(), 0, false)`
- `NationalSpire.CareerAvatarIcon.CareerAvatarIcon()`；输入表达式：`new CareerAvatarIcon { Art = art }`；返回值紧邻使用处：`ArgumentSyntax: new CareerAvatarIcon { Art = art }`

**赋值（含属性/字段和局部值）：**

- `Art` = `art`

<a id="symbol-f18fe2d306eb"></a>

## `LoadMenuPortraits() — void LoadMenuPortraits()`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`LoadPortrait(int)`](MatchArenaScreen.cs.md#symbol-e00182c65271)

**字段、属性、事件及方法组引用：** `LoadMenuPortraits()`；`LoadPortrait(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `LoadPortrait(int)`；输入表达式：`LoadPortrait(i)`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadPortrait(i);`

**赋值（含属性/字段和局部值）：**

- `menu.AboutToPopup` -= `LoadMenuPortraits`

<a id="symbol-2b8f5772ff95"></a>

## `NationalSpire.CareerScreen.ArenaTextAction(string, string, Godot.Color, System.Action) — private static Button ArenaTextAction(string title, string icon, Color hover, Action activate)`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`](DashboardControls.cs.md#symbol-34af00babbac)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；`Godot.BaseButton.IsHovered()`；`Godot.Button.Button()`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Color.Lightened(float)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.HasFocus()`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Mathf.Ceil(float)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；`NationalSpire.CareerScreen.ButtonStates`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.CareerVisuals.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`button.IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: button.IsHovered() || button.HasFocus()`
- `Godot.Button.Button()`；输入表达式：`new Button { Text = title, CustomMinimumSize = new(iconSize + gap + textWidth, 34),              Alignment = HorizontalAlignment.Right, SizeFlagsVertical = SizeFlags.ShrinkCenter,              MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = title, CustomMinimumSize = new(iconSize + gap + textWidth, 34),              Alignment = HorizontalAlignment.Right, SizeFlagsVertical = SizeFlags.ShrinkCenter,              MouseDefaultCursorShape = CursorShape.PointingHand }`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`button.DrawLine(new(button.Size.X - textWidth, button.Size.Y - 2), new(button.Size.X, button.Size.Y - 2), hover, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.DrawLine(new(button.Size.X - textWidth, button.Size.Y - 2), new(button.Size.X, button.Size.Y - 2), hover, 1);`
- `Godot.Color.Lightened(float)`；输入表达式：`CareerVisuals.Muted.Lightened(.18f)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Muted.Lightened(.18f)`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_" + state + "_color", hover)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_" + state + "_color", hover);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_color", CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_color", CareerVisuals.Muted);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("icon_" + state + "_color", hover)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("icon_" + state + "_color", hover);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("icon_normal_color", CareerVisuals.Muted.Lightened(.18f))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("icon_normal_color", CareerVisuals.Muted.Lightened(.18f));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeConstantOverride("h_separation", gap)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeConstantOverride("h_separation", gap);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", fontSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", fontSize);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, empty)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, empty);`
- `Godot.Control.HasFocus()`；输入表达式：`button.HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: button.IsHovered() || button.HasFocus()`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`CareerVisuals.InterfaceText().GetStringSize(title, fontSize: fontSize)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.InterfaceText().GetStringSize(title, fontSize: fontSize).X`
- `Godot.Mathf.Ceil(float)`；输入表达式：`Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title, fontSize: fontSize).X)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title, fontSize: fontSize).X)`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(button.Size.X - textWidth, button.Size.Y - 2)`；返回值紧邻使用处：`ArgumentSyntax: new(button.Size.X - textWidth, button.Size.Y - 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(button.Size.X, button.Size.Y - 2)`；返回值紧邻使用处：`ArgumentSyntax: new(button.Size.X, button.Size.Y - 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(iconSize + gap + textWidth, 34)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(iconSize + gap + textWidth, 34)`
- `NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；输入表达式：`ButtonIcon(button, icon, iconSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIcon(button, icon, iconSize);`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.InterfaceText().GetStringSize`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`ButtonStates.Append("focus")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var state in ButtonStates.Append("focus")) button.AddThemeStyleboxOverride(state, empty);`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `HorizontalAlignment.Right`
- `button.Draw` += `() =>          {              if (button.IsHovered() || button.HasFocus())                  button.DrawLine(new(button.Size.X - textWidth, button.Size.Y - 2), new(button.Size.X, button.Size.Y - 2), hover, 1);          }`
- `button.Pressed` += `activate`
- `CustomMinimumSize` = `new(iconSize + gap + textWidth, 34)`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Text` = `title`

<a id="symbol-8876eaeddb03"></a>

## `NationalSpire.CareerScreen.MatchReviewButton(NationalSpire.CareerData) — private Button MatchReviewButton(CareerData data)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.CareerScreen.ArenaIconButton(string, string, System.Action, bool)`](MatchArenaScreen.cs.md#symbol-a95468bbc287)；[`NationalSpire.CareerScreen.OpenReview(string)`](MatchArenaScreen.cs.md#symbol-1c01e409299f)；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Results`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerScreen.ArenaIconButton(string, string, System.Action, bool)`；`NationalSpire.CareerScreen.OpenReview(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ArenaIconButton(string, string, System.Action, bool)`；输入表达式：`ArenaIconButton("比赛回顾","history",()=>OpenReview(data.Results.LastOrDefault()?.MatchId??""))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ArenaIconButton("比赛回顾","history",()=>OpenReview(data.Results.LastOrDefault()?.MatchId??""))`
- `NationalSpire.CareerScreen.OpenReview(string)`；输入表达式：`OpenReview(data.Results.LastOrDefault()?.MatchId??"")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenReview(data.Results.LastOrDefault()?.MatchId??"")`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`data.Results.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.Results.LastOrDefault()?.MatchId`

**赋值（含属性/字段和局部值）：**

- `button.Disabled` = `data.Results.Count==0`

<a id="symbol-8f255f3d5c6b"></a>

## `NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData) — private CareerResult? ReviewRecord(CareerData d)`

来源：源码第 128 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-e39690a57e80)；[`NationalSpire.CareerScreen.IsLatestReview(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-7436948d6a10)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingSettlementId`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.FailureDecision.Result`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`d.Results.LastOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Results.LastOrDefault(r=>r.MatchId==(_reviewId.Length>0?_reviewId:d.PendingSettlementId)) ?? d.Results.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Results.LastOrDefault(r=>r.MatchId==(_reviewId.Length>0?_reviewId:d.PendingSettlementId))`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Results.LastOrDefault(r=>r.MatchId==(_reviewId.Length>0?_reviewId:d.PendingSettlementId)) ?? d.Results.LastOrDefault()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7436948d6a10"></a>

## `NationalSpire.CareerScreen.IsLatestReview(NationalSpire.CareerData) — private bool IsLatestReview(CareerData d)`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DashboardHeader(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-959727dcb8cd)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-8f255f3d5c6b)；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`；输入表达式：`ReviewRecord(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: ReviewRecord(d)==d.Results.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`d.Results.LastOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: ReviewRecord(d)==d.Results.LastOrDefault()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1c01e409299f"></a>

## `NationalSpire.CareerScreen.OpenReview(string) — private void OpenReview(string id)`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.MatchReviewButton(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-8876eaeddb03)

**调用：** [`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Visit(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(()=>{_tab="结算";_reviewId=id;})`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Visit(()=>{_tab="结算";_reviewId=id;})`

**赋值（含属性/字段和局部值）：**

- `_reviewId` = `id`
- `_tab` = `"结算"`

<a id="symbol-e39690a57e80"></a>

## `NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData) — private void AcknowledgeReview(CareerData d)`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Close(bool)`](CareerScreen.cs.md#symbol-9bfd6bc6f6d3)；[`NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult, Godot.HBoxContainer)`](MatchArenaScreen.cs.md#symbol-2553d6834735)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`Page(int)`](MatchArenaScreen.cs.md#symbol-9cee07a82214)

**调用：** [`NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-8f255f3d5c6b)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingSettlementId`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`；输入表达式：`ReviewRecord(d)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ReviewRecord(d)?.MatchId`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`

**赋值（含属性/字段和局部值）：**

- `d.PendingSettlementId` = `""`

<a id="symbol-2553d6834735"></a>

## `NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult, Godot.HBoxContainer) — private void ReviewPager(CareerData d,CareerResult result,HBoxContainer actions)`

来源：源码第 137 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-e39690a57e80)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ResumeSettledDate(NationalSpire.CareerData, NationalSpire.CareerMatch)`](DateGameReturn.cs.md#symbol-9e75de0044f4)；[`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`](CareerDashboard.cs.md#symbol-5eacabf68317)；[`Page(int)`](MatchArenaScreen.cs.md#symbol-9cee07a82214)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Collections.Generic.Stack<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerScreen._arenaMatchId`；`NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ResumeSettledDate(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；`NationalSpire.DateGameState.ReturnPending`；`Page(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(FramedAction("返回赛场",()=>          {              AcknowledgeReview(d);              if(d.Matches.FirstOrDefault(m=>m.Id==result.MatchId && m.DateGame?.ReturnPending==true) is { } date && ResumeSettledDate(d,date)) return;              _reviewId=""; _arenaMatchId=""; _tab="赛事"; _backHistory.Clear();_scroll.ScrollVertical=0;Render();          },"chevron-right",trailing:true,width:140,height:40))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(FramedAction("返回赛场",()=>          {              AcknowledgeReview(d);              if(d.Matches.FirstOrDefault(m=>m.Id==result.MatchId && m.DateGame?.ReturnPending==true) is { } date && ResumeSettledDate(d,date)) return;              _reviewId=""; _arenaMatchId=""; _tab="赛事"; _backHistory.Clear();_scroll.ScrollVertical=0;Render();          },"chevron-right",trailing:true,width:140,height:40));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(FramedAction("上一场",()=>Page(i-1),"chevron-left",width:140,height:40))`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(FramedAction("上一场",()=>Page(i-1),"chevron-left",width:140,height:40));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(FramedAction("下一场",()=>Page(i+1),"chevron-right",trailing:true,width:140,height:40))`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(FramedAction("下一场",()=>Page(i+1),"chevron-right",trailing:true,width:140,height:40));`
- `NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData)`；输入表达式：`AcknowledgeReview(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: AcknowledgeReview(d);`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("返回赛场",()=>          {              AcknowledgeReview(d);              if(d.Matches.FirstOrDefault(m=>m.Id==result.MatchId && m.DateGame?.ReturnPending==true) is { } date && ResumeSettledDate(d,date)) return;              _reviewId=""; _arenaMatchId=""; _tab="赛事"; _backHistory.Clear();_scroll.ScrollVertical=0;Render();          },"chevron-right",trailing:true,width:140,height:40)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("返回赛场",()=>          {              AcknowledgeReview(d);              if(d.Matches.FirstOrDefault(m=>m.Id==result.MatchId && m.DateGame?.ReturnPending==true) is { } date && ResumeSettledDate(d,date)) return;              _reviewId=""; _arenaMatchId=""; _tab="赛事"; _backHistory.Clear();_scroll.ScrollVertical=0;Render();          },"chevron-right",trailing:true,width:140,height:40)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("上一场",()=>Page(i-1),"chevron-left",width:140,height:40)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("上一场",()=>Page(i-1),"chevron-left",width:140,height:40)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("下一场",()=>Page(i+1),"chevron-right",trailing:true,width:140,height:40)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("下一场",()=>Page(i+1),"chevron-right",trailing:true,width:140,height:40)`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ResumeSettledDate(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`ResumeSettledDate(d,date)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Matches.FirstOrDefault(m=>m.Id==result.MatchId && m.DateGame?.ReturnPending==true) is { } date && ResumeSettledDate(d,date)`
- `NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；输入表达式：`TabStrip(_content,14)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =TabStrip(_content,14)`
- `Page(int)`；输入表达式：`Page(i-1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Page(i-1)`
- `Page(int)`；输入表达式：`Page(i+1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Page(i+1)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.FirstOrDefault(m=>m.Id==result.MatchId && m.DateGame?.ReturnPending==true)`；返回值紧邻使用处：`IsPatternExpressionSyntax: d.Matches.FirstOrDefault(m=>m.Id==result.MatchId && m.DateGame?.ReturnPending==true) is { } date`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`d.Results.IndexOf(result)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =d.Results.IndexOf(result)`
- `System.Collections.Generic.Stack<T>.Clear()`；输入表达式：`_backHistory.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Clear();`

**赋值（含属性/字段和局部值）：**

- `_arenaMatchId` = `""`
- `_reviewId` = `""`
- `_scroll.ScrollVertical` = `0`
- `_tab` = `"赛事"`

<a id="symbol-9cee07a82214"></a>

## `Page(int) — void Page(int index)`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult, Godot.HBoxContainer)`](MatchArenaScreen.cs.md#symbol-2553d6834735)

**调用：** [`NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-e39690a57e80)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Results`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Render()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData)`；输入表达式：`AcknowledgeReview(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: AcknowledgeReview(d);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`

**赋值（含属性/字段和局部值）：**

- `_reviewId` = `d.Results[index].MatchId`
- `_scroll.ScrollVertical` = `0`

<a id="symbol-8a35d94d8045"></a>

## `NationalSpire.CareerScreen.ArenaCharacterName(string) — private static string ArenaCharacterName(string id)`

来源：源码第 155 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)；[`Participant(string, string, string, bool, string?)`](MatchArenaScreen.cs.md#symbol-c7b37568ec95)；[`Side(bool, string, bool)`](FixtureScheduleScreen.cs.md#symbol-766128f05c3d)

**调用：** [`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`](PlayerArchive.cs.md#symbol-9ab35bc5f38f)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`string.Equals(string?, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameBridge.Characters()`；`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Id.ToString().Equals`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault`
- `NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`PlayerArchive.CharacterName(character.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: character==null?id:PlayerArchive.CharacterName(character.Id)`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`c.Id.Entry.Equals(id,StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString().Equals(id,StringComparison.OrdinalIgnoreCase) || c.Id.Entry.Equals(id,StringComparison.OrdinalIgnoreCase)`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`c.Id.ToString().Equals(id,StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString().Equals(id,StringComparison.OrdinalIgnoreCase) || c.Id.Entry.Equals(id,StringComparison.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().FirstOrDefault(c=>c.Id.ToString().Equals(id,StringComparison.OrdinalIgnoreCase) || c.Id.Entry.Equals(id,StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =GameBridge.Characters().FirstOrDefault(c=>c.Id.ToString().Equals(id,StringComparison.OrdinalIgnoreCase) || c.Id.Entry.Equals(id,StringComparison.OrdinalIgnoreCase))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c382a00cf2e6"></a>

## `NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string) — private void MatchArena(CareerData d,string title,string opponent,string opponentName,string state,string playerCharacter,Color accent,          out HBoxContainer actions, int day, Action? launch=null, string? playerPerformance=null, string? rivalPerformance=null, string source="赛事")`

来源：源码第 161 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`Center(Godot.Control, float, float, float, float)`](MatchArenaScreen.cs.md#symbol-bf615569daf9)；[`Line(string, int, Godot.Color)`](MatchArenaScreen.cs.md#symbol-13ce45b12552)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.NavigationIcon(string)`](CareerDashboard.cs.md#symbol-3c49977c9503)；[`NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`](CareerDashboard.cs.md#symbol-e49412bc4596)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；[`Participant(string, string, string, bool, string?)`](MatchArenaScreen.cs.md#symbol-c7b37568ec95)；`Godot.BaseButton.IsHovered()`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；`Godot.Control.HasFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.MatchArenaBackdrop.MatchArenaBackdrop()`；`NationalSpire.MatchMedallion.MatchMedallion()`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.DateOnly.ToString(string?)`

**字段、属性、事件及方法组引用：** `Center(Godot.Control, float, float, float, float)`；`Line(string, int, Godot.Color)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ButtonStates`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.NavigationIcon(string)`；`NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；`NationalSpire.ICareerSession.Host`；`NationalSpire.MatchArenaBackdrop.Launch`；`NationalSpire.MatchMedallion.Accent`；`NationalSpire.MatchMedallion.Victory`；`Participant(string, string, string, bool, string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(actions,.5f,launch==null?375:340,360,40)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(actions,.5f,launch==null?375:340,360,40);`
- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(emblem,.5f,86,170,180)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(emblem,.5f,86,170,180);`
- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(heading,.5f,274,300,57)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(heading,.5f,274,300,57);`
- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(Line(state,42,accent),.5f,274,300,57)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(Line(state,42,accent),.5f,274,300,57);`
- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(Line(state=="胜利"?"VICTORY":state=="失败"?"DEFEAT":"DRAW",15,_muted),.5f,339,200,24)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(Line(state=="胜利"?"VICTORY":state=="失败"?"DEFEAT":"DRAW",15,_muted),.5f,339,200,24);`
- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(Line(title,19,_gold),.5f,20,426,60)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(Line(title,19,_gold),.5f,20,426,60);`
- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(new MatchMedallion {Victory=state=="胜利",Accent=accent,MouseFilter=MouseFilterEnum.Ignore},.5f,86,170,180)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(new MatchMedallion {Victory=state=="胜利",Accent=accent,MouseFilter=MouseFilterEnum.Ignore},.5f,86,170,180);`
- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(src,1,20,180,26)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(src,1,20,180,26);`
- `Godot.BaseButton.IsHovered()`；输入表达式：`emblem.IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: heading.Disabled || emblem.IsHovered()`
- `Godot.BaseButton.IsHovered()`；输入表达式：`heading.IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: heading.IsHovered() || heading.HasFocus()`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`heading.DrawLine(new(x,y),new(x+width,y),CareerVisuals.Teal,2)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.DrawLine(new(x,y),new(x+width,y),CareerVisuals.Teal,2);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`emblem.AddThemeColorOverride("icon_"+style+"_color",_gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: emblem.AddThemeColorOverride("icon_"+style+"_color",_gold);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`emblem.AddThemeColorOverride("icon_normal_color",CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: emblem.AddThemeColorOverride("icon_normal_color",CareerVisuals.Teal);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`heading.AddThemeColorOverride("font_color",CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddThemeColorOverride("font_color",CareerVisuals.Teal);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation",20)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation",20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`emblem.AddThemeConstantOverride("icon_max_width",73)`；返回值紧邻使用处：`ExpressionStatementSyntax: emblem.AddThemeConstantOverride("icon_max_width",73);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`heading.AddThemeFontSizeOverride("font_size",size)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddThemeFontSizeOverride("font_size",size);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`emblem.AddThemeStyleboxOverride(style,new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: emblem.AddThemeStyleboxOverride(style,new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`heading.AddThemeStyleboxOverride(style,new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddThemeStyleboxOverride(style,new StyleBoxEmpty());`
- `Godot.Control.Control()`；输入表达式：`new Control { Name=launch==null?"SettlementHero":"MatchHero", CustomMinimumSize=new(0,480) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Control { Name=launch==null?"SettlementHero":"MatchHero", CustomMinimumSize=new(0,480) }`
- `Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；输入表达式：`heading.GetThemeFont("font")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: heading.GetThemeFont("font").GetStringSize`
- `Godot.Control.HasFocus()`；输入表达式：`heading.HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: heading.IsHovered() || heading.HasFocus()`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`backdrop.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: backdrop.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`heading.GetThemeFont("font").GetStringSize(state,fontSize:size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: heading.GetThemeFont("font").GetStringSize(state,fontSize:size).X`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}`；返回值紧邻使用处：`AssignmentExpressionSyntax: actions=new HBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(host)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(host);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`host.AddChild(backdrop)`；返回值紧邻使用处：`ExpressionStatementSyntax: host.AddChild(backdrop);`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,480)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,480)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x,y)`；返回值紧邻使用处：`ArgumentSyntax: new(x,y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x+width,y)`；返回值紧邻使用处：`ArgumentSyntax: new(x+width,y)`
- `Line(string, int, Godot.Color)`；输入表达式：`Line(source,14,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Line(source,14,_muted)`
- `Line(string, int, Godot.Color)`；输入表达式：`Line(state,42,accent)`；返回值紧邻使用处：`ArgumentSyntax: Line(state,42,accent)`
- `Line(string, int, Godot.Color)`；输入表达式：`Line(state=="胜利"?"VICTORY":state=="失败"?"DEFEAT":"DRAW",15,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Line(state=="胜利"?"VICTORY":state=="失败"?"DEFEAT":"DRAW",15,_muted)`
- `Line(string, int, Godot.Color)`；输入表达式：`Line(title,19,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Line(title,19,_gold)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(d)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d,opponent)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d,opponent)?.Character`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("",launch)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CaptionButton("",launch)`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton(state,launch)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CaptionButton(state,launch)`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon(state=="前往比赛日"?"fast-forward":"swords-start")`；返回值紧邻使用处：`AssignmentExpressionSyntax: emblem.Icon=NavigationIcon(state=="前往比赛日"?"fast-forward":"swords-start")`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(host,date,28,20,200,26)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(host,date,28,20,200,26);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(GameCalendar.Date(d,day).ToString("yyyy.MM.dd"),14,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(GameCalendar.Date(d,day).ToString("yyyy.MM.dd"),14,_muted)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(d,day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(d,day).ToString`
- `NationalSpire.MatchArenaBackdrop.MatchArenaBackdrop()`；输入表达式：`new MatchArenaBackdrop { Launch=launch!=null, MouseFilter=MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new MatchArenaBackdrop { Launch=launch!=null, MouseFilter=MouseFilterEnum.Ignore }`
- `NationalSpire.MatchMedallion.MatchMedallion()`；输入表达式：`new MatchMedallion {Victory=state=="胜利",Accent=accent,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`ArgumentSyntax: new MatchMedallion {Victory=state=="胜利",Accent=accent,MouseFilter=MouseFilterEnum.Ignore}`
- `Participant(string, string, string, bool, string?)`；输入表达式：`Participant("player",CareerEngine.Name(d),playerCharacter,true,playerPerformance)`；返回值紧邻使用处：`ExpressionStatementSyntax: Participant("player",CareerEngine.Name(d),playerCharacter,true,playerPerformance);`
- `Participant(string, string, string, bool, string?)`；输入表达式：`Participant(opponent,opponentName,CareerEngine.Person(d,opponent)?.Character??"",false,rivalPerformance)`；返回值紧邻使用处：`ExpressionStatementSyntax: Participant(opponent,opponentName,CareerEngine.Person(d,opponent)?.Character??"",false,rivalPerformance);`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`ButtonStates.Append("focus")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var style in ButtonStates.Append("focus")) emblem.AddThemeStyleboxOverride(style,new StyleBoxEmpty());`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`ButtonStates.Append("focus")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var style in ButtonStates.Append("focus")) heading.AddThemeStyleboxOverride(style,new StyleBoxEmpty());`
- `System.DateOnly.ToString(string?)`；输入表达式：`GameCalendar.Date(d,day).ToString("yyyy.MM.dd")`；返回值紧邻使用处：`ArgumentSyntax: GameCalendar.Date(d,day).ToString("yyyy.MM.dd")`

**赋值（含属性/字段和局部值）：**

- `Accent` = `accent`
- `actions.MouseFilter` = `MouseFilterEnum.Ignore`
- `actions` = `new HBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}`
- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `CustomMinimumSize` = `new(0,480)`
- `emblem.Disabled` = `_multiplayer is {Host:false}`
- `emblem.ExpandIcon` = `true`
- `emblem.Icon` = `NavigationIcon(state=="前往比赛日"?"fast-forward":"swords-start")`
- `emblem.IconAlignment` = `HorizontalAlignment.Center`
- `emblem.MouseEntered` += `heading.QueueRedraw`
- `emblem.MouseExited` += `heading.QueueRedraw`
- `emblem.Name` = `"ArenaStart"`
- `emblem.TooltipText` = `state`
- `heading.Disabled` = `emblem.Disabled`
- `heading.Draw` += `()=>              {                  if (heading.Disabled || emblem.IsHovered() || !(heading.IsHovered() || heading.HasFocus())) return;                  float width=heading.GetThemeFont("font").GetStringSize(state,fontSize:size).X;                  float x=(heading.Size.X-width)/2, y=heading.Size.Y-3;                  heading.DrawLine(new(x,y),new(x+width,y),CareerVisuals.Teal,2);              }`
- `heading.Name` = `"ArenaStateAction"`
- `Launch` = `launch!=null`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `launch==null?"SettlementHero":"MatchHero"`
- `src.HorizontalAlignment` = `HorizontalAlignment.Right`
- `src.OffsetLeft` = `-210`
- `src.OffsetRight` = `-28`
- `Victory` = `state=="胜利"`

<a id="symbol-bf615569daf9"></a>

## `Center(Godot.Control, float, float, float, float) — void Center(Control node,float fraction,float y,float width,float height)`

来源：源码第 168 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string)`](MatchArenaScreen.cs.md#symbol-c382a00cf2e6)；[`Participant(string, string, string, bool, string?)`](MatchArenaScreen.cs.md#symbol-c7b37568ec95)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`host.AddChild(node)`；返回值紧邻使用处：`ExpressionStatementSyntax: host.AddChild(node);`

**赋值（含属性/字段和局部值）：**

- `node.AnchorLeft` = `node.AnchorRight=fraction`
- `node.AnchorRight` = `fraction`
- `node.OffsetBottom` = `y+height`
- `node.OffsetLeft` = `-width/2`
- `node.OffsetRight` = `width/2`
- `node.OffsetTop` = `y`

<a id="symbol-13ce45b12552"></a>

## `Line(string, int, Godot.Color) — Label Line(string value,int size,Color color)`

来源：源码第 173 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string)`](MatchArenaScreen.cs.md#symbol-c382a00cf2e6)；[`Participant(string, string, string, bool, string?)`](MatchArenaScreen.cs.md#symbol-c7b37568ec95)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(value,size,color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(value,size,color)`

**赋值（含属性/字段和局部值）：**

- `label.HorizontalAlignment` = `HorizontalAlignment.Center`
- `label.VerticalAlignment` = `VerticalAlignment.Center`

<a id="symbol-c7b37568ec95"></a>

## `Participant(string, string, string, bool, string?) — void Participant(string id,string name,string character,bool player,string? performance)`

来源：源码第 177 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string)`](MatchArenaScreen.cs.md#symbol-c382a00cf2e6)

**调用：** [`Center(Godot.Control, float, float, float, float)`](MatchArenaScreen.cs.md#symbol-bf615569daf9)；[`Line(string, int, Godot.Color)`](MatchArenaScreen.cs.md#symbol-13ce45b12552)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.ArenaCharacterName(string)`](MatchArenaScreen.cs.md#symbol-8a35d94d8045)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`string.IsNullOrWhiteSpace(string?)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `Center(Godot.Control, float, float, float, float)`；`Line(string, int, Godot.Color)`；`NationalSpire.CareerData.AvatarHighestClear`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerScreen._arenaCharacter`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ArenaCharacterName(string)`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(Avatar(d,id,170),x,77,170,170)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(Avatar(d,id,170),x,77,170,170);`
- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(detail,x,315,400,68)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(detail,x,315,400,68);`
- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(Line(performance,21,_ink),x,390,410,42)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(Line(performance,21,_ink),x,390,410,42);`
- `Center(Godot.Control, float, float, float, float)`；输入表达式：`Center(link,x,longName ? 249 : 257,420,longName ? 65 : 52)`；返回值紧邻使用处：`ExpressionStatementSyntax: Center(link,x,longName ? 249 : 257,420,longName ? 65 : 52);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`link.AddThemeColorOverride("font_color",player?_gold:_ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: link.AddThemeColorOverride("font_color",player?_gold:_ink);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`link.AddThemeFontSizeOverride("font_size",longName ? 23 : 30)`；返回值紧邻使用处：`ExpressionStatementSyntax: link.AddThemeFontSizeOverride("font_size",longName ? 23 : 30);`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`CareerVisuals.InterfaceText().GetStringSize(name,fontSize:30)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.InterfaceText().GetStringSize(name,fontSize:30).X`
- `Line(string, int, Godot.Color)`；输入表达式：`Line($"{country} · {EsportsWorld.ClubName(d,club)}\n最高进阶 {(player?Math.Max(0,d.AvatarHighestClear):person?.MaxAscension??0)} · {ArenaCharacterName(character)}",17,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Line($"{country} · {EsportsWorld.ClubName(d,club)}\n最高进阶 {(player?Math.Max(0,d.AvatarHighestClear):person?.MaxAscension??0)} · {ArenaCharacterName(character)}",17,_muted)`
- `Line(string, int, Godot.Color)`；输入表达式：`Line(performance,21,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Line(performance,21,_ink)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d,id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerEngine.Person(d,id)`
- `NationalSpire.CareerScreen.ArenaCharacterName(string)`；输入表达式：`ArenaCharacterName(character)`；返回值紧邻使用处：`InterpolationSyntax: {ArenaCharacterName(character)}`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(d,id,170)`；返回值紧邻使用处：`ArgumentSyntax: Avatar(d,id,170)`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton(name,()=>OpenPerson(id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CaptionButton(name,()=>OpenPerson(id))`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenPerson(id)`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.InterfaceText().GetStringSize`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d,club)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.ClubName(d,club)}`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(performance)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(performance)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,d.AvatarHighestClear)`；返回值紧邻使用处：`ConditionalExpressionSyntax: player?Math.Max(0,d.AvatarHighestClear):person?.MaxAscension??0`

**赋值（含属性/字段和局部值）：**

- `_arenaCharacter` = `detail`
- `link.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `link.TooltipText` = `name`
