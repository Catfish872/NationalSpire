# OpeningClubEditor.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`911B79A0DB383EC0E2DDCFE54330C3B3C4E1D2F422B5ECE838A15686BC5032C5`。来源：[源码](../../OpeningClubEditor.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OpeningClubEditor`、`NationalSpire.OpeningClubOverlay`。

字段、事件及初始值（源码原样）：

```csharp
internal Action? Dismiss;
```

<a id="symbol-b42cc4282417"></a>

## `NationalSpire.OpeningClubEditor.Sign(NationalSpire.CareerData, NationalSpire.CareerClub) — private static string? Sign(CareerData d,CareerClub club)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningClubEditor.Choose(Godot.Control, NationalSpire.CareerData, NationalSpire.CareerOpeningWorld)`](OpeningClubEditor.cs.md#symbol-e9ebb9b42754)

**调用：** [`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`](CareerCommerce.cs.md#symbol-81a4731f8949)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；`NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsCareer.Offers`；`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；输入表达式：`CareerCommerce.Quote(d,club)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerCommerce.Quote(d,club)`
- `NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`；输入表达式：`EsportsWorld.AcceptOffer(d,offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EsportsWorld.AcceptOffer(d,offer)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Offers.Add(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Offers.Add(offer);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`d.Esports.Offers.Remove(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Offers.Remove(offer);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(3,d.Esports.License)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Esports.License=Math.Max(3,d.Esports.License)`

**赋值（含属性/字段和局部值）：**

- `d.Esports.License` = `Math.Max(3,d.Esports.License)`

<a id="symbol-e9ebb9b42754"></a>

## `NationalSpire.OpeningClubEditor.Choose(Godot.Control, NationalSpire.CareerData, NationalSpire.CareerOpeningWorld) — internal static async Task Choose(Control parent, CareerData d, CareerOpeningWorld plan)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string, NationalSpire.NpcGenerationSetup?, bool)`](Coop/CoopScreen.cs.md#symbol-ba4470b4052c)

**调用：** [`ButtonIn(Godot.Container, string, System.Action?)`](OpeningClubEditor.cs.md#symbol-a05f4d43e5ef)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.LandscapeViewport.StageOf(Godot.Control)`](DashboardViewport.cs.md#symbol-736b054e3fef)；[`NationalSpire.OpeningClubEditor.Sign(NationalSpire.CareerData, NationalSpire.CareerClub)`](OpeningClubEditor.cs.md#symbol-b42cc4282417)；[`NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`](OpeningControls.cs.md#symbol-93105b3962ff)；[`NationalSpire.OwnedClubs.CreateAtOpening(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-1e93d0ae5761)；[`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft, bool)`](OwnedClubs.cs.md#symbol-a6d6b4537b16)；[`Render()`](OpeningClubEditor.cs.md#symbol-0b4184e47a8c)；`Godot.ButtonGroup.ButtonGroup()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.CenterContainer.CenterContainer()`；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GrabFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Label.Label()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.Node.GetViewport()`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.Node.QueueFree()`；`Godot.PanelContainer.PanelContainer()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`Godot.Viewport.GuiGetFocusOwner()`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`NationalSpire.ClubDraft.ClubDraft()`；`NationalSpire.OpeningClubOverlay.OpeningClubOverlay()`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.OperationCanceledException.OperationCanceledException(string?)`；`System.Threading.Tasks.TaskCompletionSource<TResult>.TaskCompletionSource(System.Threading.Tasks.TaskCreationOptions)`；`System.Threading.Tasks.TaskCompletionSource<TResult>.TrySetResult(TResult)`

**字段、属性、事件及方法组引用：** `ButtonIn(Godot.Container, string, System.Action?)`；`NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Name`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerOpeningWorld.ClubCountry`；`NationalSpire.CareerOpeningWorld.ClubMode`；`NationalSpire.CareerOpeningWorld.ClubName`；`NationalSpire.CareerOpeningWorld.ClubSelection.Country`；`NationalSpire.CareerOpeningWorld.ClubSelection.Id`；`NationalSpire.CareerOpeningWorld.ClubSelection.Name`；`NationalSpire.CareerOpeningWorld.ClubSponsor`；`NationalSpire.CareerOpeningWorld.JoiningClub`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.ClubDraft.Name`；`NationalSpire.ClubDraft.Region`；`NationalSpire.ClubDraft.Sponsor`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.LandscapeViewport.StageOf(Godot.Control)`；`NationalSpire.OpeningClubEditor.Sign(NationalSpire.CareerData, NationalSpire.CareerClub)`；`NationalSpire.OpeningClubOverlay.Dismiss`；`NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；`NationalSpire.OwnedClubs.CreateAtOpening(NationalSpire.CareerData, NationalSpire.ClubDraft)`；`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft, bool)`；`Render()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(actions,"返回开局设置",()=>done.TrySetResult(false))`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIn(actions,"返回开局设置",()=>done.TrySetResult(false));`
- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(actions,plan.ClubMode=="加盟" ? "确认加盟" : "确认建队",()=>{              if(plan.ClubMode=="自建")              {                  if(OwnedClubs.CreationError(d,draft,true) is { } err){status.Text=err;return;}                  OwnedClubs.CreateAtOpening(d,draft);              }              else              {                  if(EsportsWorld.Club(d,selectedClub) is not { } club){status.Text="请选择一家俱乐部。";return;}                  if(Sign(d,club) is { } err){status.Text=err;return;}              }              done.TrySetResult(true);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIn(actions,plan.ClubMode=="加盟" ? "确认加盟" : "确认建队",()=>{              if(plan.ClubMode=="自建")              {                  if(OwnedClubs.CreationError(d,draft,true) is { } err){status.Text=err;return;}                  OwnedClubs.CreateAtOpening(d,draft);              }              else              {                  if(EsportsWorld.Club(d,selectedClub) is not { } club){status.Text="请选择一家俱乐部。";return;}                  if(Sign(d,club) is { } err){status.Text=err;return;}              }              done.TrySetResult(true);          });`
- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(nav,"上一页",null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ButtonIn(nav,"上一页",null)`
- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(nav,"下一页",null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ButtonIn(nav,"下一页",null)`
- `Godot.ButtonGroup.ButtonGroup()`；输入表达式：`new ButtonGroup()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ButtonGroup()`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`previous.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: GodotObject.IsInstanceValid(previous)&&previous.IsVisibleInTree()`
- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CenterContainer()`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new(0,0,0,.76f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color=new(0,0,0,.76f)`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`intro.AddThemeColorOverride("font_color",CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: intro.AddThemeColorOverride("font_color",CareerVisuals.Gold);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation",8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`header.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddThemeConstantOverride("separation",12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("112230","385566",12,22))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("112230","385566",12,22));`
- `Godot.Control.GrabFocus()`；输入表达式：`previous.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: previous.GrabFocus();`
- `Godot.Control.GrabFocus()`；输入表达式：`search.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: search.GrabFocus();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`center.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(c)`；返回值紧邻使用处：`IfStatementSyntax: if(GodotObject.IsInstanceValid(c))c.FocusBehaviorRecursive=focus;`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: GodotObject.IsInstanceValid(previous)&&previous.IsVisibleInTree()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(shade)`；返回值紧邻使用处：`IfStatementSyntax: if(GodotObject.IsInstanceValid(shade))shade.QueueFree();`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns=2, SizeFlagsHorizontal=Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns=2, SizeFlagsHorizontal=Control.SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`
- `Godot.Label.Label()`；输入表达式：`new Label { AutowrapMode=TextServer.AutowrapMode.WordSmart }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { AutowrapMode=TextServer.AutowrapMode.WordSmart }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text="初始资金  " + CareerMoney.Format(d.Credits) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text="初始资金  " + CareerMoney.Format(d.Credits) }`
- `Godot.Label.Label()`；输入表达式：`new Label()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Label()`
- `Godot.Label.Label()`；输入表达式：`new Label{Text="合同方案",CustomMinimumSize=new(86,0)}`；返回值紧邻使用处：`ArgumentSyntax: new Label{Text="合同方案",CustomMinimumSize=new(86,0)}`
- `Godot.Label.Label()`；输入表达式：`new Label{Text="签约席位",CustomMinimumSize=new(86,0)}`；返回值紧邻使用处：`ArgumentSyntax: new Label{Text="签约席位",CustomMinimumSize=new(86,0)}`
- `Godot.Label.Label()`；输入表达式：`new Label{Text=plan.ClubMode=="加盟"?"选择初始俱乐部":"创建俱乐部 · 安排阵容"}`；返回值紧邻使用处：`ArgumentSyntax: new Label{Text=plan.ClubMode=="加盟"?"选择初始俱乐部":"创建俱乐部 · 安排阵容"}`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { PlaceholderText=plan.ClubMode=="自建" ? "自由市场 · 输入姓名可搜索全部 NPC" : "搜索俱乐部名称或赛区" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { PlaceholderText=plan.ClubMode=="自建" ? "自由市场 · 输入姓名可搜索全部 NPC" : "搜索俱乐部名称或赛区" }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(intro)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(intro);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(nav)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(nav);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(rosterPane)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(rosterPane);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(slots)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(slots);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contracts.AddChild(new Label{Text="合同方案",CustomMinimumSize=new(86,0)})`；返回值紧邻使用处：`ExpressionStatementSyntax: contracts.AddChild(new Label{Text="合同方案",CustomMinimumSize=new(86,0)});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(CareerScreen.Glyph("users-round",26,CareerVisuals.Gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(CareerScreen.Glyph("users-round",26,CareerVisuals.Gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(new Label{Text=plan.ClubMode=="加盟"?"选择初始俱乐部":"创建俱乐部 · 安排阵容"})`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(new Label{Text=plan.ClubMode=="加盟"?"选择初始俱乐部":"创建俱乐部 · 安排阵容"});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`host.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: host.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`nav.AddChild(pages)`；返回值紧邻使用处：`ExpressionStatementSyntax: nav.AddChild(pages);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`positions.AddChild(new Label{Text="签约席位",CustomMinimumSize=new(86,0)})`；返回值紧邻使用处：`ExpressionStatementSyntax: positions.AddChild(new Label{Text="签约席位",CustomMinimumSize=new(86,0)});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rosterPane.AddChild(roster)`；返回值紧邻使用处：`ExpressionStatementSyntax: rosterPane.AddChild(roster);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(center);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`slots.AddChild(contracts)`；返回值紧邻使用处：`ExpressionStatementSyntax: slots.AddChild(contracts);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`slots.AddChild(positions)`；返回值紧邻使用处：`ExpressionStatementSyntax: slots.AddChild(positions);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`host.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: host.GetChildren().OfType<Control>`
- `Godot.Node.GetViewport()`；输入表达式：`host.GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: host.GetViewport().GuiGetFocusOwner`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`body.MoveChild(slots,2)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.MoveChild(slots,2);`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer{CustomMinimumSize=new(1000,690)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer{CustomMinimumSize=new(1000,690)}`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer{Visible=false,CustomMinimumSize=new(0,64),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ScrollContainer{Visible=false,CustomMinimumSize=new(0,64),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,64)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,64)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(1000,690)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(1000,690)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(86,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(86,0)`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`host.GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =host.GetViewport().GuiGetFocusOwner()`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { SizeFlagsVertical=Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { SizeFlagsVertical=Control.SizeFlags.ExpandFill }`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(d.Credits)`；返回值紧邻使用处：`BinaryExpressionSyntax: "初始资金  " + CareerMoney.Format(d.Credits)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`CareerScreen.Glyph("users-round",26,CareerVisuals.Gold)`；返回值紧邻使用处：`ArgumentSyntax: CareerScreen.Glyph("users-round",26,CareerVisuals.Gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("112230","385566",12,22)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("112230","385566",12,22)`
- `NationalSpire.ClubDraft.ClubDraft()`；输入表达式：`new ClubDraft { Region=region, Name=plan.ClubName, Sponsor=plan.ClubSponsor }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ClubDraft { Region=region, Name=plan.ClubName, Sponsor=plan.ClubSponsor }`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d,pick.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d,pick.Id) is { } team`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d,selectedClub)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d,selectedClub) is not { } club`
- `NationalSpire.LandscapeViewport.StageOf(Godot.Control)`；输入表达式：`LandscapeViewport.StageOf(parent)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LandscapeViewport.StageOf(parent)`
- `NationalSpire.OpeningClubEditor.Sign(NationalSpire.CareerData, NationalSpire.CareerClub)`；输入表达式：`Sign(d,club)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Sign(d,club) is { } err`
- `NationalSpire.OpeningClubOverlay.OpeningClubOverlay()`；输入表达式：`new OpeningClubOverlay{Color=new(0,0,0,.76f),Name="OpeningClubOverlay",ZIndex=145,FocusBehaviorRecursive=Control.FocusBehaviorRecursiveEnum.Enabled,Dismiss=()=>done.TrySetResult(false)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new OpeningClubOverlay{Color=new(0,0,0,.76f),Name="OpeningClubOverlay",ZIndex=145,FocusBehaviorRecursive=Control.FocusBehaviorRecursiveEnum.Enabled,Dismiss=()=>done.TrySetResult(false)}`
- `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；输入表达式：`OpeningControls.Chip(contracts,termGroup,name,id==term,()=>{term=id;Render();})`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Chip(contracts,termGroup,name,id==term,()=>{term=id;Render();});`
- `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；输入表达式：`OpeningControls.Chip(positions,seatGroup,s,s==seat,()=>seat=s)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Chip(positions,seatGroup,s,s==seat,()=>seat=s);`
- `NationalSpire.OwnedClubs.CreateAtOpening(NationalSpire.CareerData, NationalSpire.ClubDraft)`；输入表达式：`OwnedClubs.CreateAtOpening(d,draft)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.CreateAtOpening(d,draft);`
- `NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft, bool)`；输入表达式：`OwnedClubs.CreationError(d,draft,true)`；返回值紧邻使用处：`IsPatternExpressionSyntax: OwnedClubs.CreationError(d,draft,true) is { } err`
- `Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`EsportsWorld.Countries.Contains(plan.ClubCountry)`；返回值紧邻使用处：`ConditionalExpressionSyntax: EsportsWorld.Countries.Contains(plan.ClubCountry) ? plan.ClubCountry : d.Esports.Country`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`host.GetChildren().OfType<Control>().Where(c=>c.Visible).Select(c=>(c,c.FocusBehaviorRecursive))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: host.GetChildren().OfType<Control>().Where(c=>c.Visible).Select(c=>(c,c.FocusBehaviorRecursive)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`host.GetChildren().OfType<Control>().Where(c=>c.Visible).Select(c=>(c,c.FocusBehaviorRecursive)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =host.GetChildren().OfType<Control>().Where(c=>c.Visible).Select(c=>(c,c.FocusBehaviorRecursive)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`host.GetChildren().OfType<Control>().Where(c=>c.Visible)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: host.GetChildren().OfType<Control>().Where(c=>c.Visible).Select`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`host.GetChildren().OfType<Control>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: host.GetChildren().OfType<Control>().Where`
- `System.OperationCanceledException.OperationCanceledException(string?)`；输入表达式：`new OperationCanceledException("已返回开局设置。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new OperationCanceledException("已返回开局设置。");`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.TaskCompletionSource(System.Threading.Tasks.TaskCreationOptions)`；输入表达式：`new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously)`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.TrySetResult(TResult)`；输入表达式：`done.TrySetResult(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>done.TrySetResult(false)`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.TrySetResult(TResult)`；输入表达式：`done.TrySetResult(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: done.TrySetResult(true);`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `c.FocusBehaviorRecursive` = `Control.FocusBehaviorRecursiveEnum.Disabled`
- `c.FocusBehaviorRecursive` = `focus`
- `Color` = `new(0,0,0,.76f)`
- `Columns` = `2`
- `CustomMinimumSize` = `new(0,64)`
- `CustomMinimumSize` = `new(1000,690)`
- `CustomMinimumSize` = `new(86,0)`
- `Dismiss` = `()=>done.TrySetResult(false)`
- `FocusBehaviorRecursive` = `Control.FocusBehaviorRecursiveEnum.Enabled`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Name` = `"OpeningClubOverlay"`
- `Name` = `plan.ClubName`
- `next.Pressed` += `()=>{page++; Render();}`
- `page` = `0`
- `PlaceholderText` = `plan.ClubMode=="自建" ? "自由市场 · 输入姓名可搜索全部 NPC" : "搜索俱乐部名称或赛区"`
- `prev.Pressed` += `()=>{page--; Render();}`
- `Region` = `region`
- `search.TextChanged` += `_=>{page=0;Render();}`
- `seat` = `s`
- `shade.TreeExiting` += `()=>done.TrySetResult(false)`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `Control.SizeFlags.ExpandFill`
- `Sponsor` = `plan.ClubSponsor`
- `status.Text` = `"请选择一家俱乐部。"`
- `status.Text` = `err`
- `term` = `id`
- `Text` = `"初始资金  " + CareerMoney.Format(d.Credits)`
- `Text` = `"合同方案"`
- `Text` = `"签约席位"`
- `Text` = `plan.ClubMode=="加盟"?"选择初始俱乐部":"创建俱乐部 · 安排阵容"`
- `Visible` = `false`
- `ZIndex` = `145`

<a id="symbol-a05f4d43e5ef"></a>

## `ButtonIn(Godot.Container, string, System.Action?) — Button ButtonIn(Container row,string title,Action? click)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningClubEditor.Choose(Godot.Control, NationalSpire.CareerData, NationalSpire.CareerOpeningWorld)`](OpeningClubEditor.cs.md#symbol-e9ebb9b42754)；[`Render()`](OpeningClubEditor.cs.md#symbol-0b4184e47a8c)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(b);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(100,40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(100,40)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Text=title,CustomMinimumSize=new(100,40),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastButton { Text=title,CustomMinimumSize=new(100,40),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill }`

**赋值（含属性/字段和局部值）：**

- `b.Pressed` += `click.Invoke`
- `CustomMinimumSize` = `new(100,40)`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Text` = `title`

<a id="symbol-0b4184e47a8c"></a>

## `Render() — void Render()`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningClubEditor.Choose(Godot.Control, NationalSpire.CareerData, NationalSpire.CareerOpeningWorld)`](OpeningClubEditor.cs.md#symbol-e9ebb9b42754)；[`Render()`](OpeningClubEditor.cs.md#symbol-0b4184e47a8c)

**调用：** [`ButtonIn(Godot.Container, string, System.Action?)`](OpeningClubEditor.cs.md#symbol-a05f4d43e5ef)；[`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`](CareerCommerce.cs.md#symbol-81a4731f8949)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；[`NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-86d3ae3f2a68)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-522aa99991c7)；[`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-6507b91ba56b)；[`Render()`](OpeningClubEditor.cs.md#symbol-0b4184e47a8c)；[`Tile(string, string, string, bool, System.Action)`](OpeningClubEditor.cs.md#symbol-f5ca20b15dd5)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.ClubSigning.ClubSigning()`；`string.Contains(string, System.StringComparison)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Collections.Generic.List<T>.ToArray()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `ButtonIn(Godot.Container, string, System.Action?)`；`NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Name`；`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerOpeningWorld.ClubMode`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.ClubDraft.Name`；`NationalSpire.ClubDraft.Region`；`NationalSpire.ClubDraft.Signings`；`NationalSpire.ClubOffer.SeasonPay`；`NationalSpire.ClubOffer.SigningBonus`；`NationalSpire.ClubOffer.WinBonus`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.ClubSigning.Position`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；`NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft)`；`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedPlayerContract.Signing`；`Render()`；`Tile(string, string, string, bool, System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(roster,pick.Position+" · "+CareerEngine.DisplayName(d,pick.PersonId)+" ×",()=>{draft.Signings.Remove(pick);Render();})`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIn(roster,pick.Position+" · "+CareerEngine.DisplayName(d,pick.PersonId)+" ×",()=>{draft.Signings.Remove(pick);Render();});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(OpeningControls.Label("没有匹配的结果"))`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(OpeningControls.Label("没有匹配的结果"));`
- `NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；输入表达式：`CareerCommerce.Quote(d,club)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerCommerce.Quote(d,club)`
- `NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；输入表达式：`CareerCommerce.Quote(d,selected)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerCommerce.Quote(d,selected)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,pick.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: pick.Position+" · "+CareerEngine.DisplayName(d,pick.PersonId)`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d)-cost`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(CareerMoney.Balance(d)-cost)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(CareerMoney.Balance(d)-cost)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(cost)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(cost)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(o.SeasonPay)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(o.SeasonPay)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(o.SigningBonus)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(o.SigningBonus)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(o.WinBonus)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(o.WinBonus)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(offer.SeasonPay)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(offer.SeasonPay)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(quote.Signing)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(quote.Signing)}`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(grid);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(roster)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(roster);`
- `NationalSpire.ClubSigning.ClubSigning()`；输入表达式：`new(){PersonId=p.Id,Plan=term,Position=seat}`；返回值紧邻使用处：`ArgumentSyntax: new(){PersonId=p.Id,Plan=term,Position=seat}`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d,p.ClubId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: EsportsWorld.Club(d,p.ClubId)?.Name`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d,selectedClub)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EsportsWorld.Club(d,selectedClub)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.ClubId==selectedClub&&EsportsWorld.IsProfessional(p)`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("没有匹配的结果")`；返回值紧邻使用处：`ArgumentSyntax: OpeningControls.Label("没有匹配的结果")`
- `NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.Candidates(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: q.Length==0?OwnedClubs.Candidates(d):d.People.Where(p=>p.Id!="player"&&!humans.Contains(p.Id)&&(p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase))`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.Humans(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OwnedClubs.Humans(d)`
- `NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft)`；输入表达式：`OwnedClubs.InitialCost(d,draft)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OwnedClubs.InitialCost(d,draft)`
- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`OwnedClubs.Quote(p,term)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OwnedClubs.Quote(p,term)`
- `Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `string.Contains(string, System.StringComparison)`；输入表达式：`(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`(p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Id!="player"&&!humans.Contains(p.Id)&&(p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" ",p.HandleAliases)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、",names)`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、",names)}`
- `string.Trim()`；输入表达式：`search.Text.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =search.Text.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`draft.Signings.Any(s=>s.PersonId==p.Id)`；返回值紧邻使用处：`ArgumentSyntax: draft.Signings.Any(s=>s.PersonId==p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)).OrderByDescending(c=>c.Id==initialClubId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)).OrderByDescending(c=>c.Id==initialClubId).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p=>p.ClubId==selectedClub&&EsportsWorld.IsProfessional(p)).OrderByDescending(p=>p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p=>p.ClubId==selectedClub&&EsportsWorld.IsProfessional(p)).OrderByDescending(p=>p.Rating).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.People.Where(p=>p.ClubId==selectedClub&&EsportsWorld.IsProfessional(p)).OrderByDescending(p=>p.Rating).Take(5).Select(p=>p.PublicName)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =d.People.Where(p=>p.ClubId==selectedClub&&EsportsWorld.IsProfessional(p)).OrderByDescending(p=>p.Rating).Take(5).Select(p=>p.PublicName)`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`clubs.Skip(page*10)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: clubs.Skip(page*10).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`people.Skip(page*10)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Skip(page*10).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`clubs.Skip(page*10).Take(10)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var club in clubs.Skip(page*10).Take(10)){                      var offer=CareerCommerce.Quote(d,club);                      Tile(club.Name,$"{club.Country}赛区  ·  赛季薪资 {CareerMoney.Format(offer.SeasonPay)}","flag",selectedClub==club.Id,()=>{selectedClub=club.Id;Render();});                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.People.Where(p=>p.ClubId==selectedClub&&EsportsWorld.IsProfessional(p)).OrderByDescending(p=>p.Rating).Take(5)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p=>p.ClubId==selectedClub&&EsportsWorld.IsProfessional(p)).OrderByDescending(p=>p.Rating).Take(5).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`people.Skip(page*10).Take(10)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var p in people.Skip(page*10).Take(10)){                      var quote=OwnedClubs.Quote(p,term);                      Tile(p.PublicName,$"{EsportsWorld.Club(d,p.ClubId)?.Name??"自由选手"}  ·  进阶 {p.MaxAscension}  ·  签约 {CareerMoney.Format(quote.Signing)}","contact-round",draft.Signings.Any(s=>s.PersonId==p.Id),()=>{                          draft.Signings.RemoveAll(s=>s.PersonId==p.Id);draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat});Render();});                  }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`(q.Length==0?OwnedClubs.Candidates(d):d.People.Where(p=>p.Id!="player"&&!humans.Contains(p.Id)&&(p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase))).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =(q.Length==0?OwnedClubs.Candidates(d):d.People.Where(p=>p.Id!="player"&&!humans.Contains(p.Id)&&(p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)).OrderByDescending(c=>c.Id==initialClubId).ThenByDescending(c=>c.Country==region).ThenBy(c=>c.Name).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)).OrderByDescending(c=>c.Id==initialClubId).ThenByDescending(c=>c.Country==region).ThenBy(c=>c.Name).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p=>p.ClubId==selectedClub&&EsportsWorld.IsProfessional(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p=>p.ClubId==selectedClub&&EsportsWorld.IsProfessional(p)).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p=>p.Id!="player"&&!humans.Contains(p.Id)&&(p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`ConditionalExpressionSyntax: q.Length==0?OwnedClubs.Candidates(d):d.People.Where(p=>p.Id!="player"&&!humans.Contains(p.Id)&&(p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat})`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat});`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`humans.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !humans.Contains(p.Id)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`draft.Signings.Remove(pick)`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.Signings.Remove(pick);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`draft.Signings.RemoveAll(s=>s.PersonId==p.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.Signings.RemoveAll(s=>s.PersonId==p.Id);`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`draft.Signings.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var pick in draft.Signings.ToArray())ButtonIn(roster,pick.Position+" · "+CareerEngine.DisplayName(d,pick.PersonId)+" ×",()=>{draft.Signings.Remove(pick);Render();});`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)).OrderByDescending(c=>c.Id==initialClubId).ThenByDescending(c=>c.Country==region).ThenBy(c=>c.Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)).OrderByDescending(c=>c.Id==initialClubId).ThenByDescending(c=>c.Country==region).ThenBy(c=>c.Name).ToList`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)).OrderByDescending(c=>c.Id==initialClubId).ThenByDescending(c=>c.Country==region)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)).OrderByDescending(c=>c.Id==initialClubId).ThenByDescending(c=>c.Country==region).ThenBy`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(page,0,Math.Max(0,(total-1)/10))`；返回值紧邻使用处：`AssignmentExpressionSyntax: page=Math.Clamp(page,0,Math.Max(0,(total-1)/10))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,(total-1)/10)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,(total-1)/10)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,(total+9)/10)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(1,(total+9)/10)`
- `Tile(string, string, string, bool, System.Action)`；输入表达式：`Tile(club.Name,$"{club.Country}赛区  ·  赛季薪资 {CareerMoney.Format(offer.SeasonPay)}","flag",selectedClub==club.Id,()=>{selectedClub=club.Id;Render();})`；返回值紧邻使用处：`ExpressionStatementSyntax: Tile(club.Name,$"{club.Country}赛区  ·  赛季薪资 {CareerMoney.Format(offer.SeasonPay)}","flag",selectedClub==club.Id,()=>{selectedClub=club.Id;Render();});`
- `Tile(string, string, string, bool, System.Action)`；输入表达式：`Tile(p.PublicName,$"{EsportsWorld.Club(d,p.ClubId)?.Name??"自由选手"}  ·  进阶 {p.MaxAscension}  ·  签约 {CareerMoney.Format(quote.Signing)}","contact-round",draft.Signings.Any(s=>s.PersonId==p.Id),()=>{                          draft.Signings.RemoveAll(s=>s.PersonId==p.Id);draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat});Render();})`；返回值紧邻使用处：`ExpressionStatementSyntax: Tile(p.PublicName,$"{EsportsWorld.Club(d,p.ClubId)?.Name??"自由选手"}  ·  进阶 {p.MaxAscension}  ·  签约 {CareerMoney.Format(quote.Signing)}","contact-round",draft.Signings.Any(s=>s.PersonId==p.Id),()=>{                          draft.Signings.RemoveAll(s=>s.PersonId==p.Id);draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat});Render();});`

**赋值（含属性/字段和局部值）：**

- `next.Disabled` = `page+1==count`
- `page` = `Math.Clamp(page,0,Math.Max(0,(total-1)/10))`
- `pages.Text` = `$"{page+1} / {count}"`
- `PersonId` = `p.Id`
- `Plan` = `term`
- `Position` = `seat`
- `prev.Disabled` = `page==0`
- `rosterPane.Visible` = `draft.Signings.Count>0`
- `scroll.ScrollVertical` = `0`
- `selectedClub` = `club.Id`
- `status.Text` = `"选择俱乐部查看阵容与合同。"`
- `status.Text` = `$"{draft.Name}  ·  {draft.Region}赛区    注册与签约 {CareerMoney.Format(cost)}    结余 {CareerMoney.Format(CareerMoney.Balance(d)-cost)}"`
- `status.Text` = `$"{selected.Name}    签约金 {CareerMoney.Format(o.SigningBonus)}    赛季薪资 {CareerMoney.Format(o.SeasonPay)}    胜场奖金 {CareerMoney.Format(o.WinBonus)}\n职业阵容    {string.Join("、",names)}"`
- `total` = `clubs.Count`
- `total` = `people.Count`

<a id="symbol-f5ca20b15dd5"></a>

## `Tile(string, string, string, bool, System.Action) — void Tile(string title,string details,string icon,bool chosen,Action select)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Render()`](OpeningClubEditor.cs.md#symbol-0b4184e47a8c)

**调用：** [`NationalSpire.OpeningControls.Card(Godot.Container, string, string, string, bool, System.Action, Godot.ButtonGroup?)`](OpeningControls.cs.md#symbol-16ab05b87293)

**字段、属性、事件及方法组引用：** `NationalSpire.OpeningControls.Card(Godot.Container, string, string, string, bool, System.Action, Godot.ButtonGroup?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OpeningControls.Card(Godot.Container, string, string, string, bool, System.Action, Godot.ButtonGroup?)`；输入表达式：`OpeningControls.Card(grid,title,details,icon,chosen,select)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>OpeningControls.Card(grid,title,details,icon,chosen,select)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-94c5562db661"></a>

## `NationalSpire.OpeningClubOverlay._Input(Godot.InputEvent) — public override void _Input(InputEvent e)`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Node.GetViewport()`；`Godot.Viewport.SetInputAsHandled()`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.OpeningClubOverlay.Dismiss`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().SetInputAsHandled`
- `Godot.Viewport.SetInputAsHandled()`；输入表达式：`GetViewport().SetInputAsHandled()`；返回值紧邻使用处：`ExpressionStatementSyntax: GetViewport().SetInputAsHandled();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Dismiss?.Invoke()`

**赋值（含属性/字段和局部值）：**
