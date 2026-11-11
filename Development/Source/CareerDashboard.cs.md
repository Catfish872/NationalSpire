# CareerDashboard.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8E0D281FA53718D8C93BE747D6A55DD17236E214A6FAE7011D1BE6EC3472B4DE`。来源：[源码](../../CareerDashboard.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private HBoxContainer _sectionBar = null!;
private Button _walletButton = null!;
private Label _planDot = null!;
private int _calendarMonth, _weekDay;
private string _eventHeaderSelection = "", _styledRail = "";
private string _calendarMode = "日程", _planKey = "", _planTarget = "", _board = "人气榜", _rankRegion = "";
private string _fixtureScope = "国内赛事", _fixtureKind = "", _fixtureRegion = "", _fixtureInternational = "", _reviewId = "", _arenaMatchId = "";
private bool _domesticMine = true, _otherRegionsMine, _showCalendarPlans;
private int _planScroll;
private static readonly Dictionary<string, Texture2D> NavigationIcons = new();
private const int MainWidth = 1423, HomeSideWidth = 328, HomeColumnGap = 27;
private Label _railMailCount = null!, _railPostCount = null!, _communityCaption = null!;
private static Texture2D? _brandTexture;
private Button _railPortrait = null!;
private CareerAvatar _railPortraitImage = null!;
```

<a id="symbol-8b9858221a0a"></a>

## `NationalSpire.CareerScreen.MyFixtures — private bool MyFixtures`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._domesticMine`；`NationalSpire.CareerScreen._fixtureScope`；`NationalSpire.CareerScreen._otherRegionsMine`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_domesticMine` = `value`
- `_otherRegionsMine` = `value`

<a id="symbol-3c49977c9503"></a>

## `NationalSpire.CareerScreen.NavigationIcon(string) — private static Texture2D? NavigationIcon(string key)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`MonthArrow(bool, int)`](CareerScreen.cs.md#symbol-950248099d2c)；[`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`](DashboardControls.cs.md#symbol-34af00babbac)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string)`](MatchArenaScreen.cs.md#symbol-c382a00cf2e6)；[`NationalSpire.CareerScreen.PlanCard.ShowExpanded(bool)`](CalendarPlansScreen.cs.md#symbol-c9a82d9a2cd6)；[`NationalSpire.CareerScreen.SaveRow(Godot.VBoxContainer, string, string, string, bool, System.Func<string, System.Threading.Tasks.Task>, bool)`](CareerLibraryScreen.cs.md#symbol-ba7dbc5dacaa)；[`Side(bool, string, bool)`](FixtureScheduleScreen.cs.md#symbol-766128f05c3d)

**调用：** `Godot.Image.Image()`；`Godot.Image.LoadSvgFromString(string, float)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.IO.StreamReader.ReadToEnd()`；`System.IO.StreamReader.StreamReader(System.IO.Stream)`；`System.Reflection.Assembly.GetManifestResourceStream(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.NavigationIcons`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadSvgFromString(string, float)`；输入表达式：`image.LoadSvgFromString(reader.ReadToEnd(), 4)`；返回值紧邻使用处：`BinaryExpressionSyntax: image.LoadSvgFromString(reader.ReadToEnd(), 4) != Error.Ok`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`AssignmentExpressionSyntax: NavigationIcons[key] = ImageTexture.CreateFromImage(image)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`NavigationIcons.TryGetValue(key, out var icon)`；返回值紧邻使用处：`IfStatementSyntax: if (NavigationIcons.TryGetValue(key, out var icon)) return icon;`
- `System.IO.StreamReader.ReadToEnd()`；输入表达式：`reader.ReadToEnd()`；返回值紧邻使用处：`ArgumentSyntax: reader.ReadToEnd()`
- `System.IO.StreamReader.StreamReader(System.IO.Stream)`；输入表达式：`new System.IO.StreamReader(stream)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new System.IO.StreamReader(stream)`
- `System.Reflection.Assembly.GetManifestResourceStream(string)`；输入表达式：`typeof(CareerScreen).Assembly.GetManifestResourceStream("NationalSpire.Navigation." + key + ".svg")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = typeof(CareerScreen).Assembly.GetManifestResourceStream("NationalSpire.Navigation." + key + ".svg")`

**赋值（含属性/字段和局部值）：**

- `NavigationIcons[key]` = `ImageTexture.CreateFromImage(image)`

<a id="symbol-22831701f7f1"></a>

## `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool) — private static Button CaptionButton(string label, Action action, bool selected = false)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`MonthArrow(bool, int)`](CareerScreen.cs.md#symbol-950248099d2c)；[`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.ClubPlanEntry()`](CareerWorldScreen.cs.md#symbol-1607d360210f)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string)`](MatchArenaScreen.cs.md#symbol-c382a00cf2e6)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-c8e7b9304826)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`Participant(string, string, string, bool, string?)`](MatchArenaScreen.cs.md#symbol-c7b37568ec95)

**调用：** `Godot.Button.Button()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxFlat.StyleBoxFlat()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ButtonStates`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = label, MouseDefaultCursorShape = CursorShape.PointingHand, CustomMinimumSize = new(0,42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = label, MouseDefaultCursorShape = CursorShape.PointingHand, CustomMinimumSize = new(0,42) }`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`b.AddThemeColorOverride("font_color", CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AddThemeColorOverride("font_color", CareerVisuals.Teal);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`b.AddThemeStyleboxOverride("focus",new StyleBoxFlat { BgColor=Colors.Transparent,BorderWidthBottom=2,BorderColor=CareerVisuals.Teal })`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AddThemeStyleboxOverride("focus",new StyleBoxFlat { BgColor=Colors.Transparent,BorderWidthBottom=2,BorderColor=CareerVisuals.Teal });`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`b.AddThemeStyleboxOverride(style, box)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AddThemeStyleboxOverride(style, box);`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat { BgColor = Colors.Transparent, BorderColor = CareerVisuals.Teal,                  BorderWidthBottom = selected || style == "hover" ? 2 : 0, ContentMarginLeft = 10, ContentMarginRight = 10,                  ContentMarginTop = 3, ContentMarginBottom = 5 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StyleBoxFlat { BgColor = Colors.Transparent, BorderColor = CareerVisuals.Teal,                  BorderWidthBottom = selected || style == "hover" ? 2 : 0, ContentMarginLeft = 10, ContentMarginRight = 10,                  ContentMarginTop = 3, ContentMarginBottom = 5 }`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat { BgColor=Colors.Transparent,BorderWidthBottom=2,BorderColor=CareerVisuals.Teal }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxFlat { BgColor=Colors.Transparent,BorderWidthBottom=2,BorderColor=CareerVisuals.Teal }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0,42)`

**赋值（含属性/字段和局部值）：**

- `b.Pressed` += `action`
- `BgColor` = `Colors.Transparent`
- `BorderColor` = `CareerVisuals.Teal`
- `BorderWidthBottom` = `2`
- `BorderWidthBottom` = `selected || style == "hover" ? 2 : 0`
- `ContentMarginBottom` = `5`
- `ContentMarginLeft` = `10`
- `ContentMarginRight` = `10`
- `ContentMarginTop` = `3`
- `CustomMinimumSize` = `new(0,42)`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `Text` = `label`

<a id="symbol-fd46a77c3667"></a>

## `NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool) — private static Button UnderlineTab(string label, Action action, bool selected, int width=120, int size=20, bool gold=false, bool ranking=false)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.DashboardHeader(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-959727dcb8cd)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-c8e7b9304826)

**调用：** [`ColorText(bool)`](CareerDashboard.cs.md#symbol-87150ae0a985)；[`NationalSpire.CareerScreen.DashboardTheme()`](DashboardControls.cs.md#symbol-72d1c6b180c3)；`Godot.BaseButton.IsHovered()`；`Godot.Button.Button()`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.HasFocus()`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `ColorText(bool)`；`NationalSpire.CareerScreen.ButtonStates`；`NationalSpire.CareerScreen.DashboardTheme()`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `ColorText(bool)`；输入表达式：`ColorText(button.HasFocus())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ColorText(button.HasFocus())`
- `ColorText(bool)`；输入表达式：`ColorText(button.IsHovered())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ColorText(button.IsHovered())`
- `ColorText(bool)`；输入表达式：`ColorText(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ColorText(true)`
- `Godot.BaseButton.IsHovered()`；输入表达式：`button.IsHovered()`；返回值紧邻使用处：`ArgumentSyntax: button.IsHovered()`
- `Godot.Button.Button()`；输入表达式：`new Button { Text=label, MouseDefaultCursorShape=CursorShape.PointingHand,              CustomMinimumSize=new(width,gold ? 54 : 44), SizeFlagsVertical=SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text=label, MouseDefaultCursorShape=CursorShape.PointingHand,              CustomMinimumSize=new(width,gold ? 54 : 44), SizeFlagsVertical=SizeFlags.ShrinkCenter }`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`button.DrawLine(new(x-half,button.Size.Y-3),new(x+half,button.Size.Y-3),CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.DrawLine(new(x-half,button.Size.Y-3),new(x+half,button.Size.Y-3),CareerVisuals.Muted);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`button.DrawRect(new(x-half,button.Size.Y-4,2*half,3),accent)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.DrawRect(new(x-half,button.Size.Y-4,2*half,3),accent);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride(state,normal)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride(state,normal);`
- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`button.AddThemeFontOverride("font",DashboardTheme().DefaultFont)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontOverride("font",DashboardTheme().DefaultFont);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size",size)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size",size);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state,new StyleBoxEmpty { ContentMarginBottom=5 })`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state,new StyleBoxEmpty { ContentMarginBottom=5 });`
- `Godot.Control.HasFocus()`；输入表达式：`button.HasFocus()`；返回值紧邻使用处：`ArgumentSyntax: button.HasFocus()`
- `Godot.Control.HasFocus()`；输入表达式：`button.HasFocus()`；返回值紧邻使用处：`IfStatementSyntax: if (button.HasFocus()) button.DrawLine(new(x-half,button.Size.Y-3),new(x+half,button.Size.Y-3),CareerVisuals.Muted);`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new(x-half,button.Size.Y-4,2*half,3)`；返回值紧邻使用处：`ArgumentSyntax: new(x-half,button.Size.Y-4,2*half,3)`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty { ContentMarginBottom=5 }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty { ContentMarginBottom=5 }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,gold ? 54 : 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(width,gold ? 54 : 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x-half,button.Size.Y-3)`；返回值紧邻使用处：`ArgumentSyntax: new(x-half,button.Size.Y-3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x+half,button.Size.Y-3)`；返回值紧邻使用处：`ArgumentSyntax: new(x+half,button.Size.Y-3)`
- `NationalSpire.CareerScreen.DashboardTheme()`；输入表达式：`DashboardTheme()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DashboardTheme().DefaultFont`

**赋值（含属性/字段和局部值）：**

- `button.Draw` += `() =>          {              float x = button.Size.X/2, half = ranking ? button.Size.X/2-10 : size;              if (selected) button.DrawRect(new(x-half,button.Size.Y-4,2*half,3),accent);              else if (button.HasFocus()) button.DrawLine(new(x-half,button.Size.Y-3),new(x+half,button.Size.Y-3),CareerVisuals.Muted);          }`
- `button.FocusEntered` += `() => ColorText(true)`
- `button.FocusExited` += `() => ColorText(button.IsHovered())`
- `button.MouseEntered` += `() => ColorText(true)`
- `button.MouseExited` += `() => ColorText(button.HasFocus())`
- `button.Pressed` += `action`
- `ContentMarginBottom` = `5`
- `CustomMinimumSize` = `new(width,gold ? 54 : 44)`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Text` = `label`

<a id="symbol-87150ae0a985"></a>

## `ColorText(bool) — void ColorText(bool entered)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`](CareerDashboard.cs.md#symbol-fd46a77c3667)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`button.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: button.QueueRedraw();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_focus_color",color)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_focus_color",color);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_hover_color",color)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_hover_color",color);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a7b926e9dfcd"></a>

## `NationalSpire.CareerScreen.HomeButtonPair(string) — private static HBoxContainer HomeButtonPair(string name)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.HomeSideWidth`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`pair.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.AddThemeConstantOverride("separation", 10);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = name, CustomMinimumSize = new(HomeSideWidth, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = name, CustomMinimumSize = new(HomeSideWidth, 0) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(HomeSideWidth, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(HomeSideWidth, 0)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(HomeSideWidth, 0)`
- `Name` = `name`

<a id="symbol-fc9ce0453d21"></a>

## `NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container) — private static MarginContainer SecondaryTabInset(Container parent)`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`](CareerDashboard.cs.md#symbol-5eacabf68317)

**调用：** [`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Inset(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(inset);`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(0, 5)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inset(0, 5)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5eacabf68317"></a>

## `NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool) — private static HBoxContainer TabStrip(Container parent, int gap=20, bool baseline=false, bool secondary=false)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-c8e7b9304826)；[`NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult, Godot.HBoxContainer)`](MatchArenaScreen.cs.md#symbol-2553d6834735)

**调用：** [`NationalSpire.CareerScreen.Baseline(Godot.Control)`](DashboardControls.cs.md#symbol-d7fcbfd7f416)；[`NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container)`](CareerDashboard.cs.md#symbol-fc9ce0453d21)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Baseline(Godot.Control)`；`NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`strip.AddThemeConstantOverride("separation",gap)`；返回值紧邻使用处：`ExpressionStatementSyntax: strip.AddThemeConstantOverride("separation",gap);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill, Alignment=BoxContainer.AlignmentMode.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill, Alignment=BoxContainer.AlignmentMode.Center }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(strip)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(strip);`
- `NationalSpire.CareerScreen.Baseline(Godot.Control)`；输入表达式：`Baseline(strip)`；返回值紧邻使用处：`ExpressionStatementSyntax: Baseline(strip);`
- `NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container)`；输入表达式：`SecondaryTabInset(parent)`；返回值紧邻使用处：`AssignmentExpressionSyntax: parent = SecondaryTabInset(parent)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `parent` = `SecondaryTabInset(parent)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-980545ae56ef"></a>

## `NationalSpire.CareerScreen.RailCount(Godot.Button) — private static Label RailCount(Button host)`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)

**调用：** [`NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`](CareerDashboard.cs.md#symbol-e49412bc4596)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.CanvasItem.Hide()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`count.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: count.Hide();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("102030")`；返回值紧邻使用处：`ArgumentSyntax: new Color("102030")`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`count.AddThemeStyleboxOverride("normal",CareerVisuals.Box("ef9295","0c1824",12,0))`；返回值紧邻使用处：`ExpressionStatementSyntax: count.AddThemeStyleboxOverride("normal",CareerVisuals.Box("ef9295","0c1824",12,0));`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(host,count,53,4,21,21)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(host,count,53,4,21,21);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("",12,new Color("102030"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text("",12,new Color("102030"))`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("ef9295","0c1824",12,0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("ef9295","0c1824",12,0)`

**赋值（含属性/字段和局部值）：**

- `count.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `count.HorizontalAlignment` = `HorizontalAlignment.Center`
- `count.VerticalAlignment` = `VerticalAlignment.Center`

<a id="symbol-3aa4baebd6f7"></a>

## `NationalSpire.CareerScreen.SetRailCount(Godot.Label, int) — private static void SetRailCount(Label count,int value)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)；[`NationalSpire.CareerScreen.UpdateCommunityBadge()`](CommunityScreen.cs.md#symbol-09dc30b97d0c)

**调用：** `int.ToString()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`value.ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: value>99?"99+":value.ToString()`

**赋值（含属性/字段和局部值）：**

- `count.Text` = `value>99?"99+":value.ToString()`
- `count.Visible` = `value>0`

<a id="symbol-15e9bc391bf6"></a>

## `NationalSpire.CareerScreen.Dot(Godot.Control) — private static Label Dot(Control host)`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Color.Color(string)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("f18589")`；返回值紧邻使用处：`ArgumentSyntax: new Color("f18589")`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`dot.SetAnchorsAndOffsetsPreset(LayoutPreset.TopRight)`；返回值紧邻使用处：`ExpressionStatementSyntax: dot.SetAnchorsAndOffsetsPreset(LayoutPreset.TopRight);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`host.AddChild(dot)`；返回值紧邻使用处：`ExpressionStatementSyntax: host.AddChild(dot);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("●", 15, new Color("f18589"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("●", 15, new Color("f18589"))`

**赋值（含属性/字段和局部值）：**

- `dot.MouseFilter` = `MouseFilterEnum.Ignore`
- `dot.OffsetLeft` = `-20`
- `dot.OffsetRight` = `-3`
- `dot.OffsetTop` = `0`

<a id="symbol-bf1cbb6ed943"></a>

## `NationalSpire.CareerScreen.PendingPlans(NationalSpire.CareerData) — private static bool PendingPlans(CareerData d)`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AvailablePlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-1eb97a843d59)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)

**调用：** [`NationalSpire.CareerScreen.PendingInvitation(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CalendarPlansScreen.cs.md#symbol-251c1e76df1b)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerScreen.PendingInvitation(NationalSpire.CareerData, NationalSpire.LifeActivity)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.PendingInvitation(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`PendingInvitation(d, a)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => PendingInvitation(d, a)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Any(a => PendingInvitation(d, a))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Life.Activities.Any(a => PendingInvitation(d, a))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a0e5a4138c47"></a>

## `NationalSpire.CareerScreen.FlatPanel(Godot.Container, string, int, string, int) — private static VBoxContainer FlatPanel(Container parent,string name,int height,string fill,int padding)`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** [`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box(fill,"344e5e",7,padding))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box(fill,"344e5e",7,padding));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(panel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name=name, CustomMinimumSize=new(0,height),SizeFlagsHorizontal=SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer { Name=name, CustomMinimumSize=new(0,height),SizeFlagsHorizontal=SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,height)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`ReturnStatementSyntax: return Inner(panel);`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(fill,"344e5e",7,padding)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(fill,"344e5e",7,padding)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0,height)`
- `Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-e49412bc4596"></a>

## `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float) — private static void Put(Control parent, Control child, float x, float y, float width, float height)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string)`](MatchArenaScreen.cs.md#symbol-c382a00cf2e6)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.RailCount(Godot.Button)`](CareerDashboard.cs.md#symbol-980545ae56ef)；[`Rail(string, string, string, System.Action, int, int)`](CareerDashboard.cs.md#symbol-78ce68fbb9ef)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(child);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: child.Size = new(width,height)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x,y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: child.Position = new(x,y)`

**赋值（含属性/字段和局部值）：**

- `child.Position` = `new(x,y)`
- `child.Size` = `new(width,height)`

<a id="symbol-b38b76efe383"></a>

## `NationalSpire.CareerScreen.BrandTexture() — private static Texture2D? BrandTexture()`

来源：源码第 133 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Image.Image()`；`Godot.Image.LoadPngFromBuffer(byte[])`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.IO.Stream.CopyTo(System.IO.Stream)`；`System.Reflection.Assembly.GetManifestResourceStream(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._brandTexture`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_brandTexture)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(_brandTexture)) return _brandTexture;`
- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadPngFromBuffer(byte[])`；输入表达式：`image.LoadPngFromBuffer(bytes.ToArray())`；返回值紧邻使用处：`BinaryExpressionSyntax: image.LoadPngFromBuffer(bytes.ToArray()) == Error.Ok`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _brandTexture = ImageTexture.CreateFromImage(image)`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new System.IO.MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new System.IO.MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`bytes.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: bytes.ToArray()`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`stream.CopyTo(bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.CopyTo(bytes);`
- `System.Reflection.Assembly.GetManifestResourceStream(string)`；输入表达式：`typeof(CareerScreen).Assembly.GetManifestResourceStream("NationalSpire.Navigation.brand-lockup.png")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = typeof(CareerScreen).Assembly.GetManifestResourceStream("NationalSpire.Navigation.brand-lockup.png")`

**赋值（含属性/字段和局部值）：**

- `_brandTexture` = `ImageTexture.CreateFromImage(image)`

<a id="symbol-168b77d78644"></a>

## `NationalSpire.CareerScreen.BuildDashboardShell() — private void BuildDashboardShell()`

来源：源码第 143 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Build()`](CareerScreen.cs.md#symbol-8b4784fe3138)

**调用：** [`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.Baseline(Godot.Control)`](DashboardControls.cs.md#symbol-d7fcbfd7f416)；[`NationalSpire.CareerScreen.BrandTexture()`](CareerDashboard.cs.md#symbol-b38b76efe383)；[`NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`](DashboardControls.cs.md#symbol-34af00babbac)；[`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.Close()`](CareerScreen.cs.md#symbol-80dfd99fda3e)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.DashboardTheme()`](DashboardControls.cs.md#symbol-72d1c6b180c3)；[`NationalSpire.CareerScreen.Dot(Godot.Control)`](CareerDashboard.cs.md#symbol-15e9bc391bf6)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.GoHub(string)`](CareerDashboard.cs.md#symbol-06744bf6f9f0)；[`NationalSpire.CareerScreen.Hairline(string)`](DashboardControls.cs.md#symbol-bf15f4abfdcb)；[`NationalSpire.CareerScreen.HomeButtonPair(string)`](CareerDashboard.cs.md#symbol-a7b926e9dfcd)；[`NationalSpire.CareerScreen.OpenCalendarDay(int)`](CalendarPlansScreen.cs.md#symbol-d6b7c872ea02)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`](CareerDashboard.cs.md#symbol-e49412bc4596)；[`NationalSpire.CareerScreen.RailCount(Godot.Button)`](CareerDashboard.cs.md#symbol-980545ae56ef)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；[`NationalSpire.ICareerSession.OpenRoom()`](CareerSession.cs.md#symbol-c0271c6664ef)；[`Rail(string, string, string, System.Action, int, int)`](CareerDashboard.cs.md#symbol-78ce68fbb9ef)；`Godot.Button.Button()`；`Godot.CanvasItem.Hide()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.Panel.Panel()`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`string.TrimStart(char)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen._backButton`；`NationalSpire.CareerScreen._boundData`；`NationalSpire.CareerScreen._breadcrumb`；`NationalSpire.CareerScreen._calendarMode`；`NationalSpire.CareerScreen._communityCaption`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._notice`；`NationalSpire.CareerScreen._pageTitle`；`NationalSpire.CareerScreen._planDot`；`NationalSpire.CareerScreen._privateBadge`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._railMailCount`；`NationalSpire.CareerScreen._railPortrait`；`NationalSpire.CareerScreen._railPortraitImage`；`NationalSpire.CareerScreen._railPostCount`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._seasonDate`；`NationalSpire.CareerScreen._sectionBar`；`NationalSpire.CareerScreen._selectedDay`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen._status`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._updatesButton`；`NationalSpire.CareerScreen._walletButton`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.Back()`；`NationalSpire.CareerScreen.Baseline(Godot.Control)`；`NationalSpire.CareerScreen.BrandTexture()`；`NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.Close()`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.DashboardTheme()`；`NationalSpire.CareerScreen.Dot(Godot.Control)`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；`NationalSpire.CareerScreen.GoHub(string)`；`NationalSpire.CareerScreen.Hairline(string)`；`NationalSpire.CareerScreen.HomeButtonPair(string)`；`NationalSpire.CareerScreen.HomeColumnGap`；`NationalSpire.CareerScreen.MainWidth`；`NationalSpire.CareerScreen.OpenCalendarDay(int)`；`NationalSpire.CareerScreen.OpenCommunity()`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；`NationalSpire.CareerScreen.RailCount(Godot.Button)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.Diagnostics.ModVersion`；`NationalSpire.ICareerSession.OpenRoom()`；`Rail(string, string, string, System.Action, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Flat=true, TooltipText="返回主菜单", MouseDefaultCursorShape=CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Flat=true, TooltipText="返回主菜单", MouseDefaultCursorShape=CursorShape.PointingHand }`
- `Godot.CanvasItem.Hide()`；输入表达式：`_breadcrumb.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _breadcrumb.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_notice.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _notice.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_status.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _status.Hide();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_seasonDate.AddThemeColorOverride("font_color",_muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _seasonDate.AddThemeColorOverride("font_color",_muted);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_walletButton.AddThemeColorOverride("font_color", _gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: _walletButton.AddThemeColorOverride("font_color", _gold);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_walletButton.AddThemeColorOverride("icon_normal_color", _gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: _walletButton.AddThemeColorOverride("icon_normal_color", _gold);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_content.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_sectionBar.AddThemeConstantOverride("separation",32)`；返回值紧邻使用处：`ExpressionStatementSyntax: _sectionBar.AddThemeConstantOverride("separation",32);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`brand.AddThemeConstantOverride("separation", 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: brand.AddThemeConstantOverride("separation", 1);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`dateSlot.AddThemeConstantOverride("margin_bottom", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: dateSlot.AddThemeConstantOverride("margin_bottom", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`dateSlot.AddThemeConstantOverride("margin_right", HomeColumnGap - headerGap)`；返回值紧邻使用处：`ExpressionStatementSyntax: dateSlot.AddThemeConstantOverride("margin_right", HomeColumnGap - headerGap);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`header.AddThemeConstantOverride("separation", headerGap)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddThemeConstantOverride("separation", headerGap);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`main.AddThemeConstantOverride("separation", 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: main.AddThemeConstantOverride("separation", 0);`
- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`_pageTitle.AddThemeFontOverride("font", CareerVisuals.InterfaceText(tracking: 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: _pageTitle.AddThemeFontOverride("font", CareerVisuals.InterfaceText(tracking: 2));`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_walletButton.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: _walletButton.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`frame.AddThemeStyleboxOverride("panel", CareerVisuals.Box("0c1824","2d4250",8,0))`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.AddThemeStyleboxOverride("panel", CareerVisuals.Box("0c1824","2d4250",8,0));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, MouseFilter=MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sectionBar = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, MouseFilter=MouseFilterEnum.Ignore }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "CareerHeader", Theme = DashboardTheme() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "CareerHeader", Theme = DashboardTheme() }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_scroll.AddChild(_content)`；返回值紧邻使用处：`ExpressionStatementSyntax: _scroll.AddChild(_content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(_status)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(_status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`brand.AddChild(new TextureRect { Texture = mark, CustomMinimumSize = new(76,80),                  ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered,                  MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: brand.AddChild(new TextureRect { Texture = mark, CustomMinimumSize = new(76,80),                  ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered,                  MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`brand.AddChild(version)`；返回值紧邻使用处：`ExpressionStatementSyntax: brand.AddChild(version);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`dateSlot.AddChild(_seasonDate)`；返回值紧邻使用处：`ExpressionStatementSyntax: dateSlot.AddChild(_seasonDate);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(_backButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(_backButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(_breadcrumb)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(_breadcrumb);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(_pageTitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(_pageTitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(CaptionButton("队伍", () => { var team = _multiplayer; Close(); team.OpenRoom(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(CaptionButton("队伍", () => { var team = _multiplayer; Close(); team.OpenRoom(); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(dateSlot)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(dateSlot);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(utilities)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(utilities);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`main.AddChild(_notice)`；返回值紧邻使用处：`ExpressionStatementSyntax: main.AddChild(_notice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`main.AddChild(_scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: main.AddChild(_scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`utilities.AddChild(_walletButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: utilities.AddChild(_walletButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`utilities.AddChild(menu)`；返回值紧邻使用处：`ExpressionStatementSyntax: utilities.AddChild(menu);`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`_railPortrait.GetChild<CareerAvatar>(0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _railPortraitImage = _railPortrait.GetChild<CareerAvatar>(0)`
- `Godot.Panel.Panel()`；输入表达式：`new Panel { Name = "CareerNavigationColumn", Theme=DashboardTheme() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Panel { Name = "CareerNavigationColumn", Theme=DashboardTheme() }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = mark, CustomMinimumSize = new(76,80),                  ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered,                  MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new TextureRect { Texture = mark, CustomMinimumSize = new(76,80),                  ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered,                  MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "CareerBrand", Alignment = BoxContainer.AlignmentMode.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "CareerBrand", Alignment = BoxContainer.AlignmentMode.Center }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "CareerContent", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _content = new VBoxContainer { Name = "CareerContent", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 30)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _seasonDate.CustomMinimumSize = new(0, 30)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(76,80)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(76,80)`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { Name = "CareerContentScroll", SizeFlagsVertical = SizeFlags.ExpandFill, SizeFlagsHorizontal = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _scroll = new BroadcastScroll { Name = "CareerContentScroll", SizeFlagsVertical = SizeFlags.ExpandFill, SizeFlagsHorizontal = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(_boundData, "player", 48)`；返回值紧邻使用处：`CastExpressionSyntax: (Button)Avatar(_boundData, "player", 48)`
- `NationalSpire.CareerScreen.Baseline(Godot.Control)`；输入表达式：`Baseline(_sectionBar)`；返回值紧邻使用处：`ExpressionStatementSyntax: Baseline(_sectionBar);`
- `NationalSpire.CareerScreen.BrandTexture()`；输入表达式：`BrandTexture()`；返回值紧邻使用处：`IsPatternExpressionSyntax: BrandTexture() is { } mark`
- `NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；输入表达式：`ButtonIcon(_backButton, "arrow-left", 27)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIcon(_backButton, "arrow-left", 27);`
- `NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；输入表达式：`ButtonIcon(_walletButton, "wallet", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIcon(_walletButton, "wallet", 20);`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(exit,"00000000","00000000","00000000","00000000")`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(exit,"00000000","00000000","00000000","00000000");`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("队伍", () => { var team = _multiplayer; Close(); team.OpenRoom(); })`；返回值紧邻使用处：`ArgumentSyntax: CaptionButton("队伍", () => { var team = _multiplayer; Close(); team.OpenRoom(); })`
- `NationalSpire.CareerScreen.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("", 26, _ink)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pageTitle = DashboardLabel("", 26, _ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("",11,_gold)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _communityCaption=DashboardLabel("",11,_gold)`
- `NationalSpire.CareerScreen.DashboardTheme()`；输入表达式：`DashboardTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme = DashboardTheme()`
- `NationalSpire.CareerScreen.DashboardTheme()`；输入表达式：`DashboardTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme=DashboardTheme()`
- `NationalSpire.CareerScreen.Dot(Godot.Control)`；输入表达式：`Dot(Rail("日程","日程安排","calendar-days",()=>GoHub("日程"),197))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _planDot=Dot(Rail("日程","日程安排","calendar-days",()=>GoHub("日程"),197))`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("", () => GoHub("我的资产"), height: 46, quiet: true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _walletButton = FramedAction("", () => GoHub("我的资产"), height: 46, quiet: true)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("", Back, width: 41, height: 41, quiet: true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _backButton = FramedAction("", Back, width: 41, height: 41, quiet: true)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("返回主菜单", Close, "arrow-up-right", trailing: true, height: 46, quiet: true, iconColor: _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FramedAction("返回主菜单", Close, "arrow-up-right", trailing: true, height: 46, quiet: true, iconColor: _gold)`
- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("模组设置")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>GoHub("模组设置")`
- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("日程")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>GoHub("日程")`
- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("赛事")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>GoHub("赛事")`
- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("生涯生活")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>GoHub("生涯生活")`
- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("首页")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>GoHub("首页")`
- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("我的资产")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GoHub("我的资产")`
- `NationalSpire.CareerScreen.Hairline(string)`；输入表达式：`Hairline("748d9d59")`；返回值紧邻使用处：`ArgumentSyntax: Hairline("748d9d59")`
- `NationalSpire.CareerScreen.HomeButtonPair(string)`；输入表达式：`HomeButtonPair("HeaderUtilities")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = HomeButtonPair("HeaderUtilities")`
- `NationalSpire.CareerScreen.OpenCalendarDay(int)`；输入表达式：`OpenCalendarDay(ViewData.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenCalendarDay(ViewData.Day);`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenPrivateMessages()`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(_stage, _sectionBar, 148, 77, 1423, 52)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(_stage, _sectionBar, 148, 77, 1423, 52);`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(_stage, brand, 28, 13, 94, 104)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(_stage, brand, 28, 13, 94, 104);`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(_stage, exit, brand.Position.X, brand.Position.Y, brand.Size.X, brand.Size.Y)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(_stage, exit, brand.Position.X, brand.Position.Y, brand.Size.X, brand.Size.Y);`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(_stage, frame, 28, 133, 94, 839)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(_stage, frame, 28, 133, 94, 839);`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(_stage, header, 148, 25, MainWidth, 72)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(_stage, header, 148, 25, MainWidth, 72);`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(_stage, main, 148, 133, MainWidth, 840)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(_stage, main, 148, 133, MainWidth, 840);`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(_updatesButton,_communityCaption,2,64,72,18)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(_updatesButton,_communityCaption,2,64,72,18);`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(frame, _railPortrait, 23, 525, 48, 48)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(frame, _railPortrait, 23, 525, 48, 48);`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(frame,Hairline("748d9d59"),16,777,62,1)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(frame,Hairline("748d9d59"),16,777,62,1);`
- `NationalSpire.CareerScreen.RailCount(Godot.Button)`；输入表达式：`RailCount(_privateBadge)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _railMailCount=RailCount(_privateBadge)`
- `NationalSpire.CareerScreen.RailCount(Godot.Button)`；输入表达式：`RailCount(_updatesButton)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _railPostCount=RailCount(_updatesButton)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _breadcrumb = Text("", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("",16,_gold)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _notice = Text("",16,_gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("",16,_muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _status = Text("",16,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("v" + Diagnostics.ModVersion.TrimStart('v'), 12, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("v" + Diagnostics.ModVersion.TrimStart('v'), 12, _gold)`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("", () =>          {              if (_privateOverlay != null || _tab != "日程" || _calendarMode != "当日" || _selectedDay != ViewData.Day) OpenCalendarDay(ViewData.Day);          },16)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _seasonDate = TextLink("", () =>          {              if (_privateOverlay != null || _tab != "日程" || _calendarMode != "当日" || _selectedDay != ViewData.Day) OpenCalendarDay(ViewData.Day);          },16)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0c1824","2d4250",8,0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("0c1824","2d4250",8,0)`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText(tracking: 2)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.InterfaceText(tracking: 2)`
- `NationalSpire.ICareerSession.OpenRoom()`；输入表达式：`team.OpenRoom()`；返回值紧邻使用处：`ExpressionStatementSyntax: team.OpenRoom();`
- `Rail(string, string, string, System.Action, int, int)`；输入表达式：`Rail("模组设置","设置","settings-2",()=>GoHub("模组设置"),782,55)`；返回值紧邻使用处：`ExpressionStatementSyntax: Rail("模组设置","设置","settings-2",()=>GoHub("模组设置"),782,55);`
- `Rail(string, string, string, System.Action, int, int)`；输入表达式：`Rail("日程","日程安排","calendar-days",()=>GoHub("日程"),197)`；返回值紧邻使用处：`ArgumentSyntax: Rail("日程","日程安排","calendar-days",()=>GoHub("日程"),197)`
- `Rail(string, string, string, System.Action, int, int)`；输入表达式：`Rail("赛事","赛事赛程","swords",()=>GoHub("赛事"),109)`；返回值紧邻使用处：`ExpressionStatementSyntax: Rail("赛事","赛事赛程","swords",()=>GoHub("赛事"),109);`
- `Rail(string, string, string, System.Action, int, int)`；输入表达式：`Rail("社区","社区","messages-square",OpenCommunity,681,88)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _updatesButton=Rail("社区","社区","messages-square",OpenCommunity,681,88)`
- `Rail(string, string, string, System.Action, int, int)`；输入表达式：`Rail("生涯生活","消费投资","money-bag",()=>GoHub("生涯生活"),285)`；返回值紧邻使用处：`ExpressionStatementSyntax: Rail("生涯生活","消费投资","money-bag",()=>GoHub("生涯生活"),285);`
- `Rail(string, string, string, System.Action, int, int)`；输入表达式：`Rail("首页","首页","house",()=>GoHub("首页"),21)`；返回值紧邻使用处：`ExpressionStatementSyntax: Rail("首页","首页","house",()=>GoHub("首页"),21);`
- `Rail(string, string, string, System.Action, int, int)`；输入表达式：`Rail("通讯","私信","mail",()=>OpenPrivateMessages(),591)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateBadge=Rail("通讯","私信","mail",()=>OpenPrivateMessages(),591)`
- `string.TrimStart(char)`；输入表达式：`Diagnostics.ModVersion.TrimStart('v')`；返回值紧邻使用处：`BinaryExpressionSyntax: "v" + Diagnostics.ModVersion.TrimStart('v')`

**赋值（含属性/字段和局部值）：**

- `_backButton.AccessibilityName` = `_backButton.TooltipText = "返回上一页"`
- `_backButton.IconAlignment` = `HorizontalAlignment.Center`
- `_backButton.Name` = `"CareerBack"`
- `_backButton.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `_backButton.TooltipText` = `"返回上一页"`
- `_backButton` = `FramedAction("", Back, width: 41, height: 41, quiet: true)`
- `_breadcrumb` = `Text("", 15, _muted)`
- `_communityCaption.HorizontalAlignment` = `HorizontalAlignment.Center`
- `_communityCaption.Name` = `"UpdateCount"`
- `_communityCaption.VerticalAlignment` = `VerticalAlignment.Center`
- `_communityCaption` = `DashboardLabel("",11,_gold)`
- `_content.ChildOrderChanged` += `_scroll.QueueSort`
- `_content` = `new VBoxContainer { Name = "CareerContent", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_notice` = `Text("",16,_gold)`
- `_pageTitle` = `DashboardLabel("", 26, _ink)`
- `_planDot` = `Dot(Rail("日程","日程安排","calendar-days",()=>GoHub("日程"),197))`
- `_privateBadge` = `Rail("通讯","私信","mail",()=>OpenPrivateMessages(),591)`
- `_railMailCount` = `RailCount(_privateBadge)`
- `_railPortrait.Name` = `"RailPortrait"`
- `_railPortrait` = `(Button)Avatar(_boundData, "player", 48)`
- `_railPortraitImage` = `_railPortrait.GetChild<CareerAvatar>(0)`
- `_railPostCount` = `RailCount(_updatesButton)`
- `_scroll` = `new BroadcastScroll { Name = "CareerContentScroll", SizeFlagsVertical = SizeFlags.ExpandFill, SizeFlagsHorizontal = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `_seasonDate.Alignment` = `HorizontalAlignment.Right`
- `_seasonDate.CustomMinimumSize` = `new(0, 30)`
- `_seasonDate.Name` = `"SeasonDate"`
- `_seasonDate.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `_seasonDate.TooltipText` = `"查看今天的日程"`
- `_seasonDate` = `TextLink("", () =>          {              if (_privateOverlay != null || _tab != "日程" || _calendarMode != "当日" || _selectedDay != ViewData.Day) OpenCalendarDay(ViewData.Day);          },16)`
- `_sectionBar` = `new HBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, MouseFilter=MouseFilterEnum.Ignore }`
- `_status` = `Text("",16,_muted)`
- `_updatesButton` = `Rail("社区","社区","messages-square",OpenCommunity,681,88)`
- `_walletButton.ClipText` = `true`
- `_walletButton.Name` = `"HeaderWallet"`
- `_walletButton.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `_walletButton` = `FramedAction("", () => GoHub("我的资产"), height: 46, quiet: true)`
- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `CustomMinimumSize` = `new(76,80)`
- `exit.Pressed` += `Close`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `Flat` = `true`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `menu.Name` = `"HeaderMainMenu"`
- `menu.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"CareerBrand"`
- `Name` = `"CareerContent"`
- `Name` = `"CareerContentScroll"`
- `Name` = `"CareerHeader"`
- `Name` = `"CareerNavigationColumn"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Texture` = `mark`
- `Theme` = `DashboardTheme()`
- `TooltipText` = `"返回主菜单"`
- `utilities.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `version.HorizontalAlignment` = `HorizontalAlignment.Center`

<a id="symbol-78ce68fbb9ef"></a>

## `Rail(string, string, string, System.Action, int, int) — Button Rail(string key,string label,string icon,Action action,int y,int height=78)`

来源：源码第 157 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`](CareerDashboard.cs.md#symbol-e49412bc4596)；`Godot.BaseButton.IsHovered()`；`Godot.Control.GetThemeColor(Godot.StringName, Godot.StringName)`；`Godot.Control.HasFocus()`；`NationalSpire.BroadcastButton.BroadcastButton()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._navButtons`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`b.IsHovered()`；返回值紧邻使用处：`ConditionalExpressionSyntax: b.IsHovered() ? "font_hover_color" : b.HasFocus() ? "font_focus_color" : "font_color"`
- `Godot.Control.GetThemeColor(Godot.StringName, Godot.StringName)`；输入表达式：`b.GetThemeColor(state)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =b.GetThemeColor(state)`
- `Godot.Control.HasFocus()`；输入表达式：`b.HasFocus()`；返回值紧邻使用处：`ConditionalExpressionSyntax: b.HasFocus() ? "font_focus_color" : "font_color"`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Name="Rail"+icon, AccessibilityName=label, MouseDefaultCursorShape=CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Name="Rail"+icon, AccessibilityName=label, MouseDefaultCursorShape=CursorShape.PointingHand }`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(label,13,Colors.White)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(label,13,Colors.White)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph(icon,size,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Glyph(icon,size,_muted)`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(b,caption,settings ? 32 : 0,settings ? 15 : key=="社区" ? 38 : 43,settings ? 36 : 76,21)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(b,caption,settings ? 32 : 0,settings ? 15 : key=="社区" ? 38 : 43,settings ? 36 : 76,21);`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(b,mark,settings ? 12 : (76-size)/2,settings ? 18 : key=="社区" ? 12 : 14,size,size)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(b,mark,settings ? 12 : (76-size)/2,settings ? 18 : key=="社区" ? 12 : 14,size,size);`
- `NationalSpire.CareerScreen.Put(Godot.Control, Godot.Control, float, float, float, float)`；输入表达式：`Put(frame,b,9,y,76,height)`；返回值紧邻使用处：`ExpressionStatementSyntax: Put(frame,b,9,y,76,height);`

**赋值（含属性/字段和局部值）：**

- `_navButtons[key]` = `b`
- `AccessibilityName` = `label`
- `b.Draw` += `()=>{                  string state=b.IsHovered() ? "font_hover_color" : b.HasFocus() ? "font_focus_color" : "font_color";                  var color=b.GetThemeColor(state);                  mark.SelfModulate=color; caption.SelfModulate=color;              }`
- `b.Pressed` += `action`
- `caption.HorizontalAlignment` = `HorizontalAlignment.Center`
- `caption.Name` = `"RailCaption"`
- `caption.SelfModulate` = `color`
- `caption.VerticalAlignment` = `VerticalAlignment.Center`
- `mark.SelfModulate` = `color`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `Name` = `"Rail"+icon`

<a id="symbol-69636991bb5e"></a>

## `NationalSpire.CareerScreen.HomeIdentity(NationalSpire.CareerData, Godot.VBoxContainer) — private void HomeIdentity(CareerData data,VBoxContainer side)`

来源：源码第 253 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.ClubAffiliationLink(NationalSpire.CareerData, NationalSpire.CareerClub?, bool)`](ProfileScreen.cs.md#symbol-144ebef36b30)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.Hairline(string)`](DashboardControls.cs.md#symbol-bf15f4abfdcb)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`](CircuitLedger.cs.md#symbol-73238d706495)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString(string?)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerHonor.Title`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.ClubAffiliationLink(NationalSpire.CareerData, NationalSpire.CareerClub?, bool)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Hairline(string)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.Honors`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",13)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",13);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`copy.AddThemeConstantOverride("separation",5)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddThemeConstantOverride("separation",5);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`metric.AddThemeConstantOverride("separation",3)`；返回值紧邻使用处：`ExpressionStatementSyntax: metric.AddThemeConstantOverride("separation",3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 7);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`title.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddThemeConstantOverride("separation",12);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new(0, 21) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new(0, 21) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Hairline("3a5360"))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Hairline("3a5360"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(stats)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(stats);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(DashboardLabel(CareerEngine.Name(data),24,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(DashboardLabel(CareerEngine.Name(data),24,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(DashboardLabel(data.Esports.Country+" · "+EsportsWorld.ClubName(data,data.Esports.ClubId),14,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(DashboardLabel(data.Esports.Country+" · "+EsportsWorld.ClubName(data,data.Esports.ClubId),14,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`metric.AddChild(DashboardLabel(label,14,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: metric.AddChild(DashboardLabel(label,14,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`metric.AddChild(DashboardLabel(value,24,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: metric.AddChild(DashboardLabel(value,24,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Glyph("trophy", 15, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Glyph("trophy", 15, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(honor)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(honor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(link)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(link);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stats.AddChild(metric)`；返回值紧邻使用处：`ExpressionStatementSyntax: stats.AddChild(metric);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`title.AddChild(Avatar(data,"player",68,false))`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddChild(Avatar(data,"player",68,false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`title.AddChild(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddChild(copy);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center,SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center,SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {MouseFilter=MouseFilterEnum.Ignore, SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {MouseFilter=MouseFilterEnum.Ignore, SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 21)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 21)`
- `int.ToString(string?)`；输入表达式：`CircuitLedger.Points(data,"player").ToString("N0")`；返回值紧邻使用处：`ArgumentSyntax: CircuitLedger.Points(data,"player").ToString("N0")`
- `int.ToString(string?)`；输入表达式：`data.Fans.ToString("N0")`；返回值紧邻使用处：`ArgumentSyntax: data.Fans.ToString("N0")`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(data)`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(side,"HomeIdentity","个人档案",()=>OpenPerson("player"),body,284,21,18,"142632","3a5360","203744")`；返回值紧邻使用处：`ExpressionStatementSyntax: ActionRow(side,"HomeIdentity","个人档案",()=>OpenPerson("player"),body,284,21,18,"142632","3a5360","203744");`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data,"player",68,false)`；返回值紧邻使用处：`ArgumentSyntax: Avatar(data,"player",68,false)`
- `NationalSpire.CareerScreen.ClubAffiliationLink(NationalSpire.CareerData, NationalSpire.CareerClub?, bool)`；输入表达式：`ClubAffiliationLink(data, EsportsWorld.Club(data, data.Esports.ClubId), true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubAffiliationLink(data, EsportsWorld.Club(data, data.Esports.ClubId), true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(CareerEngine.Name(data),24,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(CareerEngine.Name(data),24,_ink,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(data.Esports.Country+" · "+EsportsWorld.ClubName(data,data.Esports.ClubId),14,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(data.Esports.Country+" · "+EsportsWorld.ClubName(data,data.Esports.ClubId),14,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(honors[i].Title, 14, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel(honors[i].Title, 14, _gold)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(label,14,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(label,14,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(value,24,_gold)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(value,24,_gold)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("trophy", 15, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Glyph("trophy", 15, _gold)`
- `NationalSpire.CareerScreen.Hairline(string)`；输入表达式：`Hairline("3a5360")`；返回值紧邻使用处：`ArgumentSyntax: Hairline("3a5360")`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson("player")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenPerson("player")`
- `NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`；输入表达式：`CircuitLedger.Points(data,"player")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CircuitLedger.Points(data,"player").ToString`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(data, data.Esports.ClubId)`；返回值紧邻使用处：`ArgumentSyntax: EsportsWorld.Club(data, data.Esports.ClubId)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data,data.Esports.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Esports.Country+" · "+EsportsWorld.ClubName(data,data.Esports.ClubId)`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`data.Esports.Honors.TakeLast(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Esports.Honors.TakeLast(2).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`data.Esports.Honors.TakeLast(2).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Esports.Honors.TakeLast(2).ToArray()`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `CustomMinimumSize` = `new(0, 21)`
- `honor.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `honor.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `honor.TooltipText` = `honors[i].Title`
- `link.Name` = `"HomeClubLink"`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-45b939cf9037"></a>

## `NationalSpire.CareerScreen.HomeInvitation(Godot.Container, string, string, System.Action) — private static void HomeInvitation(Container parent,string message,string action,Action open)`

来源：源码第 296 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；`NationalSpire.CareerVisuals.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation",6);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(DashboardLabel(message,16,CareerVisuals.Muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(DashboardLabel(message,16,CareerVisuals.Muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(TextLink(action,open,16,icon:"arrow-up-right"))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(TextLink(action,open,16,icon:"arrow-up-right"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(box);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center,SizeFlagsHorizontal=SizeFlags.ExpandFill,SizeFlagsVertical=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center,SizeFlagsHorizontal=SizeFlags.ExpandFill,SizeFlagsVertical=SizeFlags.ExpandFill}`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(message,16,CareerVisuals.Muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(message,16,CareerVisuals.Muted)`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink(action,open,16,icon:"arrow-up-right")`；返回值紧邻使用处：`ArgumentSyntax: TextLink(action,open,16,icon:"arrow-up-right")`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`

<a id="symbol-06744bf6f9f0"></a>

## `NationalSpire.CareerScreen.GoHub(string) — private void GoHub(string tab)`

来源：源码第 304 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`Select(string)`](CareerDashboard.cs.md#symbol-79d37566e720)

**调用：** [`NationalSpire.CareerScreen.ClearPlan()`](CareerDashboard.cs.md#symbol-26b8e8ad029b)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen._arenaMatchId`；`NationalSpire.CareerScreen._calendarMode`；`NationalSpire.CareerScreen._calendarMonth`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._selectedDay`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.ClearPlan()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen.Visit(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ClearPlan()`；输入表达式：`ClearPlan()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearPlan();`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = tab; _competitionId = null; _reviewId = ""; _arenaMatchId = ""; _personId = null; _postId = null;              if (tab == "生涯生活") _lifeSection = "消费商城";              if (tab == "日程") { _calendarMode = "日程"; _calendarMonth = 0; _selectedDay = ViewData.Day; ClearPlan(); }          })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _tab = tab; _competitionId = null; _reviewId = ""; _arenaMatchId = ""; _personId = null; _postId = null;              if (tab == "生涯生活") _lifeSection = "消费商城";              if (tab == "日程") { _calendarMode = "日程"; _calendarMonth = 0; _selectedDay = ViewData.Day; ClearPlan(); }          });`

**赋值（含属性/字段和局部值）：**

- `_arenaMatchId` = `""`
- `_calendarMode` = `"日程"`
- `_calendarMonth` = `0`
- `_competitionId` = `null`
- `_lifeSection` = `"消费商城"`
- `_personId` = `null`
- `_postId` = `null`
- `_reviewId` = `""`
- `_selectedDay` = `ViewData.Day`
- `_tab` = `tab`

<a id="symbol-f89ee4fff8a0"></a>

## `NationalSpire.CareerScreen.EventHub — private bool EventHub`

来源：源码第 312 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b903320e311b"></a>

## `NationalSpire.CareerScreen.ActiveRail — private string ActiveRail`

来源：源码第 313 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`；`NationalSpire.CareerScreen.EventHub`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-52ec8ee2b3ad"></a>

## `NationalSpire.CareerScreen.UpdateHeaderAccount(NationalSpire.CareerData) — private void UpdateHeaderAccount(CareerData d)`

来源：源码第 314 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DashboardHeader(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-959727dcb8cd)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)

**调用：** [`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.BindPortrait(NationalSpire.CareerData, string, NationalSpire.CareerAvatar, Godot.Button?)`](CareerAvatars.cs.md#symbol-37774acf84fe)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._railPortrait`；`NationalSpire.CareerScreen._railPortraitImage`；`NationalSpire.CareerScreen._seasonDate`；`NationalSpire.CareerScreen._walletButton`；`NationalSpire.CareerScreen.BindPortrait(NationalSpire.CareerData, string, NationalSpire.CareerAvatar, Godot.Button?)`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Balance(d)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(CareerMoney.Balance(d))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _walletButton.TooltipText = CareerMoney.Format(CareerMoney.Balance(d))`
- `NationalSpire.CareerScreen.BindPortrait(NationalSpire.CareerData, string, NationalSpire.CareerAvatar, Godot.Button?)`；输入表达式：`BindPortrait(d, "player", _railPortraitImage, _railPortrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: BindPortrait(d, "player", _railPortraitImage, _railPortrait);`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(d,d.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Date(d,d.Day):yyyy.MM.dd}`

**赋值（含属性/字段和局部值）：**

- `_seasonDate.Disabled` = `_walletButton.Disabled = d.Failure != null`
- `_seasonDate.Text` = `$"赛季 {d.Season:00}  ·  {GameCalendar.Date(d,d.Day):yyyy.MM.dd}"`
- `_walletButton.Disabled` = `d.Failure != null`
- `_walletButton.Text` = `_walletButton.TooltipText = CareerMoney.Format(CareerMoney.Balance(d))`
- `_walletButton.TooltipText` = `CareerMoney.Format(CareerMoney.Balance(d))`

<a id="symbol-959727dcb8cd"></a>

## `NationalSpire.CareerScreen.DashboardHeader(NationalSpire.CareerData) — private void DashboardHeader(CareerData d)`

来源：源码第 321 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`NationalSpire.CareerScreen.AvailablePlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-1eb97a843d59)；[`NationalSpire.CareerScreen.IsLatestReview(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-7436948d6a10)；[`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`](CareerDashboard.cs.md#symbol-fd46a77c3667)；[`NationalSpire.CareerScreen.UpdateHeaderAccount(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-52ec8ee2b3ad)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`Select(string)`](CareerDashboard.cs.md#symbol-79d37566e720)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._backButton`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._eventHeaderSelection`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._pageTitle`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._planDot`；`NationalSpire.CareerScreen._sectionBar`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`；`NationalSpire.CareerScreen.AvailablePlans(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.CanGoBack`；`NationalSpire.CareerScreen.EventHub`；`NationalSpire.CareerScreen.IsLatestReview(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；`NationalSpire.CareerScreen.UpdateHeaderAccount(NationalSpire.CareerData)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.ICareerSession.Host`；`Select(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_sectionBar.AddChild(tab)`；返回值紧邻使用处：`ExpressionStatementSyntax: _sectionBar.AddChild(tab);`
- `NationalSpire.CareerScreen.AvailablePlans(NationalSpire.CareerData)`；输入表达式：`AvailablePlans(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _planDot.Visible = AvailablePlans(d)`
- `NationalSpire.CareerScreen.IsLatestReview(NationalSpire.CareerData)`；输入表达式：`IsLatestReview(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsLatestReview(d)`
- `NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；输入表达式：`UnderlineTab(name, () => Select(name), active==name,120,23,true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UnderlineTab(name, () => Select(name), active==name,120,23,true)`
- `NationalSpire.CareerScreen.UpdateHeaderAccount(NationalSpire.CareerData)`；输入表达式：`UpdateHeaderAccount(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateHeaderAccount(d);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_sectionBar)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_sectionBar);`
- `Select(string)`；输入表达式：`Select(name)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Select(name)`

**赋值（含属性/字段和局部值）：**

- `_backButton.Visible` = `CanGoBack && (_tab != "结算" || !IsLatestReview(d))`
- `_eventHeaderSelection` = `selection`
- `_pageTitle.Text` = `_tab switch { "首页"=>"生涯大厅","日程"=>"日程安排","赛事"=>"赛事赛程","赛程"=>"赛程","生涯生活" => _lifeSection == "公开消息" ? "公开消息" : "消费投资",              "赛事与俱乐部" when _competitionId==null && _worldSection is "赛事总览" or "晋级规则" => "赛事信息",              "赛事与俱乐部" => _worldSection, "选手档案" or "创建角色" => "档案馆", "社区" => "尖塔社区", _=>_tab }`
- `_planDot.Visible` = `AvailablePlans(d)`
- `_sectionBar.Visible` = `EventHub || life || profiles`
- `tab.Disabled` = `true`
- `tab.MouseDefaultCursorShape` = `CursorShape.Arrow`
- `tab.TooltipText` = `"由房主创建角色"`

<a id="symbol-79d37566e720"></a>

## `Select(string) — void Select(string name)`

来源：源码第 343 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DashboardHeader(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-959727dcb8cd)

**调用：** [`NationalSpire.CareerScreen.GoHub(string)`](CareerDashboard.cs.md#symbol-06744bf6f9f0)；[`NationalSpire.CareerScreen.OpenLifePage(string)`](CareerDashboard.cs.md#symbol-0d80fbb19407)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CareerScreen.OpenProfileCreator()`](CharacterCardScreen.cs.md#symbol-ea7be3662f2e)；[`NationalSpire.CareerScreen.OpenProfileList(string?)`](CareerNavigation.cs.md#symbol-fa604705ef07)；[`NationalSpire.CareerScreen.OpenWorldSection(string)`](CareerNavigation.cs.md#symbol-e41ea7b0d93d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.GoHub(string)`；`NationalSpire.CareerScreen.OpenLifePage(string)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerScreen.OpenProfileCreator()`；`NationalSpire.CareerScreen.OpenProfileList(string?)`；`NationalSpire.CareerScreen.OpenWorldSection(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("赛程")`；返回值紧邻使用处：`ExpressionStatementSyntax: GoHub("赛程");`
- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("赛事")`；返回值紧邻使用处：`ExpressionStatementSyntax: GoHub("赛事");`
- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage("国运榜")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenLifePage("国运榜");`
- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage("交易市场")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenLifePage("交易市场");`
- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage("消费商城")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenLifePage("消费商城");`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson("player")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPerson("player");`
- `NationalSpire.CareerScreen.OpenProfileCreator()`；输入表达式：`OpenProfileCreator()`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenProfileCreator();`
- `NationalSpire.CareerScreen.OpenProfileList(string?)`；输入表达式：`OpenProfileList()`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenProfileList();`
- `NationalSpire.CareerScreen.OpenWorldSection(string)`；输入表达式：`OpenWorldSection("俱乐部")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenWorldSection("俱乐部");`
- `NationalSpire.CareerScreen.OpenWorldSection(string)`；输入表达式：`OpenWorldSection("赛事总览")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenWorldSection("赛事总览");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0d80fbb19407"></a>

## `NationalSpire.CareerScreen.OpenLifePage(string) — private void OpenLifePage(string name)`

来源：源码第 370 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)；[`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`](CommunityFilters.cs.md#symbol-19e3d9d8326a)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.OpenWorldSection(string)`](CareerNavigation.cs.md#symbol-e41ea7b0d93d)；[`OpenMarket()`](CareerScreen.cs.md#symbol-b56f5758541f)；[`Select(string)`](CareerDashboard.cs.md#symbol-79d37566e720)

**调用：** [`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Visit(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(()=>{ _tab="生涯生活"; _lifeSection=name; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(()=>{ _tab="生涯生活"; _lifeSection=name; });`

**赋值（含属性/字段和局部值）：**

- `_lifeSection` = `name`
- `_tab` = `"生涯生活"`

<a id="symbol-26b8e8ad029b"></a>

## `NationalSpire.CareerScreen.ClearPlan() — private void ClearPlan()`

来源：源码第 374 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.ClubPlanEntry()`](CareerWorldScreen.cs.md#symbol-1607d360210f)；[`NationalSpire.CareerScreen.FinishPlan(string?)`](CalendarPlansScreen.cs.md#symbol-100b2aec3e40)；[`NationalSpire.CareerScreen.GoHub(string)`](CareerDashboard.cs.md#symbol-06744bf6f9f0)；[`NationalSpire.CareerScreen.OpenCalendarDay(int)`](CalendarPlansScreen.cs.md#symbol-d6b7c872ea02)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._planKey`；`NationalSpire.CareerScreen._planScroll`；`NationalSpire.CareerScreen._planTarget`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_planKey` = `""`
- `_planScroll` = `0`
- `_planTarget` = `""`
