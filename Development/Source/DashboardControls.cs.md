# DashboardControls.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F835AED87AFCC9E6D5BFA42A5D413068570A9B50DF43A8D29246C5C762AFFB59`。来源：[源码](../../DashboardControls.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly string[] ButtonStates = ["normal", "hover", "pressed", "hover_pressed", "disabled"];
private static Theme? _dashboardTheme;
private static readonly Dictionary<(string Fill, string Border, int Radius, int Padding), StyleBoxFlat> SurfaceStyles = new();
```

<a id="symbol-72d1c6b180c3"></a>

## `NationalSpire.CareerScreen.DashboardTheme() — private static Theme DashboardTheme()`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.OpenCareerView(Godot.Control, NationalSpire.ICareerSession?, string?, string)`](CareerScreen.cs.md#symbol-3d547eb16e05)；[`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`](CareerDashboard.cs.md#symbol-fd46a77c3667)

**调用：** [`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Resource.Duplicate(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dashboardTheme`；`NationalSpire.CareerVisuals.CreateTheme()`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_dashboardTheme)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dashboardTheme!=null && IsInstanceValid(_dashboardTheme)`
- `Godot.Resource.Duplicate(bool)`；输入表达式：`CareerVisuals.CreateTheme().Duplicate(false)`；返回值紧邻使用处：`CastExpressionSyntax: (Theme)CareerVisuals.CreateTheme().Duplicate(false)`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.CreateTheme().Duplicate`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText()`；返回值紧邻使用处：`AssignmentExpressionSyntax: theme.DefaultFont=CareerVisuals.InterfaceText()`

**赋值（含属性/字段和局部值）：**

- `_dashboardTheme` = `theme`
- `theme.DefaultFont` = `CareerVisuals.InterfaceText()`

<a id="symbol-bf15f4abfdcb"></a>

## `NationalSpire.CareerScreen.Hairline(string) — private static ColorRect Hairline(string color="3a536080")`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`](CalendarPlansScreen.cs.md#symbol-d4b6dfb814ed)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.DayEntry(Godot.VBoxContainer, string, string, string)`](CareerScreen.cs.md#symbol-6b6d63fc08b3)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.HomeIdentity(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerDashboard.cs.md#symbol-69636991bb5e)；[`NationalSpire.CareerScreen.RosterMembers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](ClubRosterScreen.cs.md#symbol-9ed06d3d7953)；[`Section(Godot.Container, string, string, string, System.Action, System.Action<Godot.HBoxContainer>?)`](CareerScreen.cs.md#symbol-4e5ebbc4b254)

**调用：** `Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color(color)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color=new Color(color)`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new()      {          Color=new Color(color), CustomMinimumSize=new(0,1), MouseFilter=MouseFilterEnum.Ignore      }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new()      {          Color=new Color(color), CustomMinimumSize=new(0,1), MouseFilter=MouseFilterEnum.Ignore      }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,1)`

**赋值（含属性/字段和局部值）：**

- `Color` = `new Color(color)`
- `CustomMinimumSize` = `new(0,1)`
- `MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-34af00babbac"></a>

## `NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool) — private static void ButtonIcon(Button button, string icon, int size, bool trailing=false)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ArenaIconButton(string, string, System.Action, bool)`](MatchArenaScreen.cs.md#symbol-a95468bbc287)；[`NationalSpire.CareerScreen.ArenaTextAction(string, string, Godot.Color, System.Action)`](MatchArenaScreen.cs.md#symbol-2b8f5772ff95)；[`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`](CommunityFilters.cs.md#symbol-19e3d9d8326a)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)

**调用：** [`NationalSpire.CareerScreen.NavigationIcon(string)`](CareerDashboard.cs.md#symbol-3c49977c9503)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.NavigationIcon(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeConstantOverride("h_separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeConstantOverride("h_separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeConstantOverride("icon_max_width",size)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeConstantOverride("icon_max_width",size);`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon(icon)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.Icon = NavigationIcon(icon)`

**赋值（含属性/字段和局部值）：**

- `button.ExpandIcon` = `true`
- `button.Icon` = `NavigationIcon(icon)`
- `button.IconAlignment` = `trailing ? HorizontalAlignment.Right : HorizontalAlignment.Left`

<a id="symbol-d545a37403bd"></a>

## `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?) — private static Button TextLink(string title, Action action, int size=15, bool underline=false, string? icon=null)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.CalendarEncounters(NationalSpire.CareerData, Godot.VBoxContainer, int, System.Collections.Generic.IEnumerable<NationalSpire.RandomEventRecord>)`](RandomEventScreen.cs.md#symbol-e447383e7699)；[`NationalSpire.CareerScreen.ClubAffiliationLink(NationalSpire.CareerData, NationalSpire.CareerClub?, bool)`](ProfileScreen.cs.md#symbol-144ebef36b30)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.HomeInvitation(Godot.Container, string, string, System.Action)`](CareerDashboard.cs.md#symbol-45b939cf9037)；[`NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`](CalendarPlansScreen.cs.md#symbol-0f7a307ccb1c)；[`Section(Godot.Container, string, string, string, System.Action, System.Action<Godot.HBoxContainer>?)`](CareerScreen.cs.md#symbol-4e5ebbc4b254)

**调用：** [`NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`](DashboardControls.cs.md#symbol-34af00babbac)；[`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；`Godot.BaseButton.IsHovered()`；`Godot.Button.Button()`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.HasFocus()`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Mathf.Ceil(float)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`button.IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: button.IsHovered() || button.HasFocus()`
- `Godot.Button.Button()`；输入表达式：`new Button { Text=title, MouseDefaultCursorShape=CursorShape.PointingHand,              SizeFlagsHorizontal=SizeFlags.ShrinkBegin, SizeFlagsVertical=SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text=title, MouseDefaultCursorShape=CursorShape.PointingHand,              SizeFlagsHorizontal=SizeFlags.ShrinkBegin, SizeFlagsVertical=SizeFlags.ShrinkCenter }`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`button.DrawLine(new(0,button.Size.Y-1),new(button.Size.X,button.Size.Y-1),              button.IsHovered() || button.HasFocus() ? CareerVisuals.Gold : CareerVisuals.Teal)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>button.DrawLine(new(0,button.Size.Y-1),new(button.Size.X,button.Size.Y-1),              button.IsHovered() || button.HasFocus() ? CareerVisuals.Gold : CareerVisuals.Teal)`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_color",CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_color",CareerVisuals.Teal);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("icon_"+state+"_color",state=="normal"?CareerVisuals.Teal:CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("icon_"+state+"_color",state=="normal"?CareerVisuals.Teal:CareerVisuals.Gold);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride(state,CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride(state,CareerVisuals.Gold);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size",size)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size",size);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("focus",new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("focus",new StyleBoxEmpty());`
- `Godot.Control.HasFocus()`；输入表达式：`button.HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: button.IsHovered() || button.HasFocus()`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X`
- `Godot.Mathf.Ceil(float)`；输入表达式：`Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X)`；返回值紧邻使用处：`BinaryExpressionSyntax: Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X)+27`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,button.Size.Y-1)`；返回值紧邻使用处：`ArgumentSyntax: new(0,button.Size.Y-1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(button.Size.X,button.Size.Y-1)`；返回值紧邻使用处：`ArgumentSyntax: new(button.Size.X,button.Size.Y-1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X)+27,30)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X)+27,30)`
- `NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；输入表达式：`ButtonIcon(button,icon,17,trailing:true)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIcon(button,icon,17,trailing:true);`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(button,"00000000","00000000","00000000","00000000")`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(button,"00000000","00000000","00000000","00000000");`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.InterfaceText().GetStringSize`

**赋值（含属性/字段和局部值）：**

- `button.CustomMinimumSize` = `new(Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X)+27,30)`
- `button.Draw` += `()=>button.DrawLine(new(0,button.Size.Y-1),new(button.Size.X,button.Size.Y-1),              button.IsHovered() || button.HasFocus() ? CareerVisuals.Gold : CareerVisuals.Teal)`
- `button.MouseEntered` += `button.QueueRedraw`
- `button.MouseExited` += `button.QueueRedraw`
- `button.Pressed` += `action`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Text` = `title`

<a id="symbol-86a5104d5792"></a>

## `NationalSpire.CareerScreen.SurfaceStyle(string, string, int, int) — private static StyleBoxFlat SurfaceStyle(string fill, string border, int radius, int padding)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.SurfaceStyles`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(fill, border, radius, padding)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style = CareerVisuals.Box(fill, border, radius, padding)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`SurfaceStyles.TryGetValue(key, out var style)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SurfaceStyles.TryGetValue(key, out var style)`

**赋值（含属性/字段和局部值）：**

- `style` = `CareerVisuals.Box(fill, border, radius, padding)`
- `SurfaceStyles[key]` = `style = CareerVisuals.Box(fill, border, radius, padding)`

<a id="symbol-0374e90f1c3f"></a>

## `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int) — private static void ButtonSurface(Button button, string fill, string border, string hoverFill,          string hoverBorder, int padding = 0, int radius = 5)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`MonthArrow(bool, int)`](CareerScreen.cs.md#symbol-a77d86a0b7fd)；[`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`](CommunityFilters.cs.md#symbol-19e3d9d8326a)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.CalendarCommands(NationalSpire.CareerData, Godot.HBoxContainer)`](CalendarPlansScreen.cs.md#symbol-0019411c0ad4)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`](CalendarPlansScreen.cs.md#symbol-0f7a307ccb1c)；[`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)；[`NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`](ClubRosterScreen.cs.md#symbol-540dea7ac6fc)；[`NationalSpire.CareerScreen.StyleNavigationRail()`](CareerScreen.cs.md#symbol-d4c2ebafd21b)；[`NationalSpire.CareerScreen.StyleRosterPicker(Godot.OptionButton, int, int)`](ClubRosterScreen.cs.md#symbol-15be3d74c4b5)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；[`Picker(string, int)`](FixtureScheduleScreen.cs.md#symbol-2539b9b56cc0)

**调用：** [`NationalSpire.CareerScreen.SurfaceStyle(string, string, int, int)`](DashboardControls.cs.md#symbol-86a5104d5792)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ButtonStates`；`NationalSpire.CareerScreen.SurfaceStyle(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("focus", focus)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("focus", focus);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, SurfaceStyle(hover ? hoverFill : fill,                  hover ? hoverBorder : border, radius, padding))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, SurfaceStyle(hover ? hoverFill : fill,                  hover ? hoverBorder : border, radius, padding));`
- `NationalSpire.CareerScreen.SurfaceStyle(string, string, int, int)`；输入表达式：`SurfaceStyle("00000000", "80e7db", radius, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SurfaceStyle("00000000", "80e7db", radius, 0)`
- `NationalSpire.CareerScreen.SurfaceStyle(string, string, int, int)`；输入表达式：`SurfaceStyle(hover ? hoverFill : fill,                  hover ? hoverBorder : border, radius, padding)`；返回值紧邻使用处：`ArgumentSyntax: SurfaceStyle(hover ? hoverFill : fill,                  hover ? hoverBorder : border, radius, padding)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d6b849a02619"></a>

## `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?) — private static Button FramedAction(string title, Action action, string? icon = null,          bool trailing = false, int width = 0, int height = 42, bool quiet = false, Color? ink = null, Color? iconColor = null)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`](CommunityFilters.cs.md#symbol-19e3d9d8326a)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`](CalendarPlansScreen.cs.md#symbol-0f7a307ccb1c)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult)`](MatchArenaScreen.cs.md#symbol-e4b38ce6c04b)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`Vote(string, string, int)`](CareerSession.cs.md#symbol-7f18c59fff80)

**调用：** [`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；`Godot.Button.Button()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = title, CustomMinimumSize = new(width,height),              MouseDefaultCursorShape = CursorShape.PointingHand, ExpandIcon = true,              IconAlignment = trailing ? HorizontalAlignment.Right : HorizontalAlignment.Left }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = title, CustomMinimumSize = new(width,height),              MouseDefaultCursorShape = CursorShape.PointingHand, ExpandIcon = true,              IconAlignment = trailing ? HorizontalAlignment.Right : HorizontalAlignment.Left }`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_color",ink??CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_color",ink??CareerVisuals.Ink);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeConstantOverride("h_separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeConstantOverride("h_separation", 9);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`group.AddThemeConstantOverride("separation",9)`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddThemeConstantOverride("separation",9);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`group.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.GetCombinedMinimumSize().X`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`group.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: group.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer {Name="ButtonCaption",Alignment=BoxContainer.AlignmentMode.Center,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer {Name="ButtonCaption",Alignment=BoxContainer.AlignmentMode.Center,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(group)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(group);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(Glyph(icon,17,iconColor??ink??CareerVisuals.Ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(Glyph(icon,17,iconColor??ink??CareerVisuals.Ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(Glyph(icon,19,iconColor??ink??CareerVisuals.Ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(Glyph(icon,19,iconColor??ink??CareerVisuals.Ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(label);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Max(width,group.GetCombinedMinimumSize().X+24),height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize=new(Math.Max(width,group.GetCombinedMinimumSize().X+24),height)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(width,height)`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(button, quiet ? "00000000" : "1d3040", quiet ? "304a5a" : "395365", "28434c", "658c91", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(button, quiet ? "00000000" : "1d3040", quiet ? "304a5a" : "395365", "28434c", "658c91", 6);`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(title,17,ink??CareerVisuals.Ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(title,17,ink??CareerVisuals.Ink)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph(icon,17,iconColor??ink??CareerVisuals.Ink)`；返回值紧邻使用处：`ArgumentSyntax: Glyph(icon,17,iconColor??ink??CareerVisuals.Ink)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph(icon,19,iconColor??ink??CareerVisuals.Ink)`；返回值紧邻使用处：`ArgumentSyntax: Glyph(icon,19,iconColor??ink??CareerVisuals.Ink)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(width,group.GetCombinedMinimumSize().X+24)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(width,group.GetCombinedMinimumSize().X+24)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `button.AccessibilityName` = `title`
- `button.CustomMinimumSize` = `new(Math.Max(width,group.GetCombinedMinimumSize().X+24),height)`
- `button.Pressed` += `action`
- `button.Text` = `""`
- `CustomMinimumSize` = `new(width,height)`
- `ExpandIcon` = `true`
- `IconAlignment` = `trailing ? HorizontalAlignment.Right : HorizontalAlignment.Left`
- `label.SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"ButtonCaption"`
- `Text` = `title`

<a id="symbol-f6780ccb3f84"></a>

## `NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int) — private static CheckButton DashboardSwitch(string label,bool value,Action<bool> changed,int width,int height)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`](CommunityFilters.cs.md#symbol-19e3d9d8326a)；[`NationalSpire.CareerScreen.CalendarCommands(NationalSpire.CareerData, Godot.HBoxContainer)`](CalendarPlansScreen.cs.md#symbol-0019411c0ad4)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)

**调用：** `Godot.CheckButton.CheckButton()`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CheckButton.CheckButton()`；输入表达式：`new CheckButton { Text = label, ButtonPressed = value, Alignment = HorizontalAlignment.Left,              SizeFlagsVertical = SizeFlags.ShrinkCenter, CustomMinimumSize = new(width,height), MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckButton { Text = label, ButtonPressed = value, Alignment = HorizontalAlignment.Left,              SizeFlagsVertical = SizeFlags.ShrinkCenter, CustomMinimumSize = new(width,height), MouseDefaultCursorShape = CursorShape.PointingHand }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(width,height)`
- `System.Action<T>.Invoke(T)`；输入表达式：`changed(on)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: on => changed(on)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `HorizontalAlignment.Left`
- `ButtonPressed` = `value`
- `CustomMinimumSize` = `new(width,height)`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Text` = `label`
- `toggle.Toggled` += `on => changed(on)`

<a id="symbol-23c9e2f4b76f"></a>

## `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color) — private static TextureRect Glyph(string name, int size, Color color)`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)；[`NationalSpire.CareerScreen.DayEntry(Godot.VBoxContainer, string, string, string)`](CareerScreen.cs.md#symbol-6b6d63fc08b3)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.HomeIdentity(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerDashboard.cs.md#symbol-69636991bb5e)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)；[`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)；[`Rail(string, string, string, System.Action, int, int)`](CareerDashboard.cs.md#symbol-6e8445894fef)；[`Reward(string, string, string)`](SettlementScreen.cs.md#symbol-041ac351a89e)

**调用：** [`NationalSpire.CareerScreen.NavigationIcon(string)`](CareerDashboard.cs.md#symbol-3c49977c9503)；`Godot.TextureRect.TextureRect()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.NavigationIcon(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = NavigationIcon(name), CustomMinimumSize = new(size,size),              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered,              SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore, SelfModulate = color }`；返回值紧邻使用处：`ReturnStatementSyntax: return new TextureRect { Texture = NavigationIcon(name), CustomMinimumSize = new(size,size),              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered,              SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore, SelfModulate = color };`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(size,size)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(size,size)`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon(name)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture = NavigationIcon(name)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(size,size)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SelfModulate` = `color`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Texture` = `NavigationIcon(name)`

<a id="symbol-1c4fb2c61c90"></a>

## `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool) — private static Label DashboardLabel(string title, int size, Color color, bool wrap = false)`

来源：源码第 119 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`AddHeading(Godot.Control, string, string, bool, bool)`](FixtureScheduleScreen.cs.md#symbol-c2de97a57d37)；[`Column(string)`](SettlementScreen.cs.md#symbol-e18b79567949)；[`Field(string, string)`](CalendarPlansScreen.cs.md#symbol-124400be032a)；[`Metric(string, string, Godot.Color)`](CareerBoardsScreen.cs.md#symbol-fedc3d937d1a)；[`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.AddLedgerTable(Godot.VBoxContainer, NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.FinanceEntry>, int)`](CareerBoardsScreen.cs.md#symbol-efdf49030123)；[`NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`](CalendarPlansScreen.cs.md#symbol-d4b6dfb814ed)；[`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.DayEntry(Godot.VBoxContainer, string, string, string)`](CareerScreen.cs.md#symbol-6b6d63fc08b3)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.HomeIdentity(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerDashboard.cs.md#symbol-69636991bb5e)；[`NationalSpire.CareerScreen.HomeInvitation(Godot.Container, string, string, System.Action)`](CareerDashboard.cs.md#symbol-45b939cf9037)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.LedgerRow(string[], bool)`](CareerBoardsScreen.cs.md#symbol-ebfdc210bad4)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`](CalendarPlansScreen.cs.md#symbol-0f7a307ccb1c)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.ProfileStats(NationalSpire.CareerData, string, bool, params (string Label, string Value)[])`](ProfileScreen.cs.md#symbol-9b40bfda8802)；[`NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string)`](ClubRosterScreen.cs.md#symbol-e2f1b514a2f4)；[`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)；[`NationalSpire.CareerScreen.RosterMembers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](ClubRosterScreen.cs.md#symbol-9ed06d3d7953)；[`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)；[`NationalSpire.CareerScreen.SaveRow(Godot.VBoxContainer, string, string, string, bool, System.Func<string, System.Threading.Tasks.Task>, bool)`](CareerLibraryScreen.cs.md#symbol-ba7dbc5dacaa)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.UpcomingDays(NationalSpire.CareerData, Godot.VBoxContainer)`](CalendarPlansScreen.cs.md#symbol-33f94161db0f)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`Rail(string, string, string, System.Action, int, int)`](CareerDashboard.cs.md#symbol-6e8445894fef)；[`Reward(string, string, string)`](SettlementScreen.cs.md#symbol-041ac351a89e)；[`Section(string, int)`](CareerBoardsScreen.cs.md#symbol-e5ca66f58dc2)；[`Stat(string, string)`](ClubRosterScreen.cs.md#symbol-e5effcdd65f3)；[`Stat(string)`](ProfileScreen.cs.md#symbol-5fa6aca0fafa)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeConstantOverride("line_spacing", 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeConstantOverride("line_spacing", 1);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title,size,color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(title,size,color)`

**赋值（含属性/字段和局部值）：**

- `label.AutowrapMode` = `wrap ? TextServer.AutowrapMode.WordSmart : TextServer.AutowrapMode.Off`

<a id="symbol-ebb2fedbb4fc"></a>

## `NationalSpire.CareerScreen.Inset(int, int) — private static MarginContainer Inset(int horizontal, int vertical)`

来源：源码第 127 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.AddLedgerTable(Godot.VBoxContainer, NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.FinanceEntry>, int)`](CareerBoardsScreen.cs.md#symbol-efdf49030123)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.LedgerRow(string[], bool)`](CareerBoardsScreen.cs.md#symbol-ebfdc210bad4)；[`NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`](CalendarPlansScreen.cs.md#symbol-0f7a307ccb1c)；[`NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string)`](ClubRosterScreen.cs.md#symbol-e2f1b514a2f4)；[`NationalSpire.CareerScreen.RosterMembers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](ClubRosterScreen.cs.md#symbol-9ed06d3d7953)；[`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)；[`NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container)`](CareerDashboard.cs.md#symbol-fc9ce0453d21)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.MarginContainer.MarginContainer()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_bottom", vertical)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_bottom", vertical);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_left", horizontal)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_left", horizontal);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_right", horizontal)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_right", horizontal);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_top", vertical)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_top", vertical);`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`

**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-5fcff8206cb6"></a>

## `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string) — private static Button ActionRow(Container parent, string name, string title, Action action, Control content,          int height, int insetX, int insetY, string fill, string border, string hover)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`](CalendarPlansScreen.cs.md#symbol-d4b6dfb814ed)；[`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.HomeIdentity(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerDashboard.cs.md#symbol-69636991bb5e)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)

**调用：** [`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；`Godot.Button.Button()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.Inset(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = "Action", AccessibilityName = title, MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = "Action", AccessibilityName = title, MouseDefaultCursorShape = CursorShape.PointingHand }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { Name = name, CustomMinimumSize = new(0,height), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { Name = name, CustomMinimumSize = new(0,height), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(inset);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0,height)`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(button, fill, border, hover, border)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(button, fill, border, hover, border);`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(insetX,insetY)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inset(insetX,insetY)`

**赋值（含属性/字段和局部值）：**

- `AccessibilityName` = `title`
- `button.Pressed` += `action`
- `content.MouseFilter` = `MouseFilterEnum.Ignore`
- `CustomMinimumSize` = `new(0,height)`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `Name` = `"Action"`
- `Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-d7fcbfd7f416"></a>

## `NationalSpire.CareerScreen.Baseline(Godot.Control) — private static void Baseline(Control strip)`

来源：源码第 154 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`](CareerDashboard.cs.md#symbol-5eacabf68317)

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Color.Color(string)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`strip.DrawLine(new(0,strip.Size.Y-1),new(strip.Size.X,strip.Size.Y-1),new Color("47627299"))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => strip.DrawLine(new(0,strip.Size.Y-1),new(strip.Size.X,strip.Size.Y-1),new Color("47627299"))`
- `Godot.Color.Color(string)`；输入表达式：`new Color("47627299")`；返回值紧邻使用处：`ArgumentSyntax: new Color("47627299")`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,strip.Size.Y-1)`；返回值紧邻使用处：`ArgumentSyntax: new(0,strip.Size.Y-1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(strip.Size.X,strip.Size.Y-1)`；返回值紧邻使用处：`ArgumentSyntax: new(strip.Size.X,strip.Size.Y-1)`

**赋值（含属性/字段和局部值）：**

- `strip.Draw` += `() => strip.DrawLine(new(0,strip.Size.Y-1),new(strip.Size.X,strip.Size.Y-1),new Color("47627299"))`
- `strip.Resized` += `strip.QueueRedraw`
