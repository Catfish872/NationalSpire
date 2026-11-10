# OpeningClubEditor.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9E7F4245DD1884C80524BF3721AF9CFB48D1400EF3C6FF9C17B605015F21551B`。来源：[源码](../../OpeningClubEditor.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OpeningClubEditor`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-e9ebb9b42754"></a>

## `NationalSpire.OpeningClubEditor.Choose(Godot.Control, NationalSpire.CareerData, NationalSpire.CareerOpeningWorld) — internal static async Task Choose(Control parent, CareerData d, CareerOpeningWorld plan)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string, NationalSpire.NpcGenerationSetup?, bool)`](Coop/CoopScreen.cs.md#symbol-ba4470b4052c)

**调用：** [`ButtonIn(Godot.Container, string, System.Action?)`](OpeningClubEditor.cs.md#symbol-f2c640b93786)；[`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`](CareerCommerce.cs.md#symbol-81a4731f8949)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.OwnedClubs.CreateAtOpening(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-1e93d0ae5761)；[`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft, bool)`](OwnedClubs.cs.md#symbol-a6d6b4537b16)；[`Render()`](OpeningClubEditor.cs.md#symbol-4f3fab6688ad)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Label.Label()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.Node.QueueFree()`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2I.Vector2I(int, int)`；`Godot.Window.PopupCenteredClamped(Godot.Vector2I?, float)`；`Godot.Window.Window()`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`NationalSpire.ClubDraft.ClubDraft()`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(int, int)`；`System.OperationCanceledException.OperationCanceledException(string?)`；`System.Threading.Tasks.TaskCompletionSource<TResult>.TaskCompletionSource()`；`System.Threading.Tasks.TaskCompletionSource<TResult>.TrySetResult(TResult)`

**字段、属性、事件及方法组引用：** `ButtonIn(Godot.Container, string, System.Action?)`；`NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Name`；`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerOpeningWorld.ClubCountry`；`NationalSpire.CareerOpeningWorld.ClubMode`；`NationalSpire.CareerOpeningWorld.ClubName`；`NationalSpire.CareerOpeningWorld.ClubSponsor`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.ClubDraft.Name`；`NationalSpire.ClubDraft.Region`；`NationalSpire.ClubDraft.Sponsor`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsCareer.Offers`；`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.OwnedClubs.CreateAtOpening(NationalSpire.CareerData, NationalSpire.ClubDraft)`；`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft, bool)`；`Render()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(actions,"返回开局设置",()=>done.TrySetResult(false))`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIn(actions,"返回开局设置",()=>done.TrySetResult(false));`
- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(actions,plan.ClubMode=="加盟" ? "确认加盟" : "确认建队",()=>{             if(plan.ClubMode=="自建")             {                 if(OwnedClubs.CreationError(d,draft,true) is { } err){status.Text=err;return;}                 OwnedClubs.CreateAtOpening(d,draft);             }             else             {                 if(EsportsWorld.Club(d,selectedClub) is not { } club){status.Text="请选择一家俱乐部。";return;}                 var offer=CareerCommerce.Quote(d,club);d.Esports.Offers.Add(offer);d.Esports.License=Math.Max(3,d.Esports.License);                 if(EsportsWorld.AcceptOffer(d,offer) is { } err){status.Text=err;return;}             }             done.TrySetResult(true);         })`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIn(actions,plan.ClubMode=="加盟" ? "确认加盟" : "确认建队",()=>{             if(plan.ClubMode=="自建")             {                 if(OwnedClubs.CreationError(d,draft,true) is { } err){status.Text=err;return;}                 OwnedClubs.CreateAtOpening(d,draft);             }             else             {                 if(EsportsWorld.Club(d,selectedClub) is not { } club){status.Text="请选择一家俱乐部。";return;}                 var offer=CareerCommerce.Quote(d,club);d.Esports.Offers.Add(offer);d.Esports.License=Math.Max(3,d.Esports.License);                 if(EsportsWorld.AcceptOffer(d,offer) is { } err){status.Text=err;return;}             }             done.TrySetResult(true);         });`
- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(nav,"上一页",null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ButtonIn(nav,"上一页",null)`
- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(nav,"下一页",null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ButtonIn(nav,"下一页",null)`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`intro.AddThemeColorOverride("font_color",CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: intro.AddThemeColorOverride("font_color",CareerVisuals.Gold);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",10);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("112230","385566",12,22))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("112230","385566",12,22));`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`panel.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(window)`；返回值紧邻使用处：`IfStatementSyntax: if(GodotObject.IsInstanceValid(window)) window.QueueFree();`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns=2, SizeFlagsHorizontal=Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns=2, SizeFlagsHorizontal=Control.SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.Label.Label()`；输入表达式：`new Label { AutowrapMode=TextServer.AutowrapMode.WordSmart }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { AutowrapMode=TextServer.AutowrapMode.WordSmart }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text="初始资金  " + CareerMoney.Format(d.Credits) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text="初始资金  " + CareerMoney.Format(d.Credits) }`
- `Godot.Label.Label()`；输入表达式：`new Label()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Label()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { PlaceholderText=plan.ClubMode=="自建" ? "自由市场 · 输入姓名可搜索全部 NPC" : "搜索俱乐部名称或赛区" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { PlaceholderText=plan.ClubMode=="自建" ? "自由市场 · 输入姓名可搜索全部 NPC" : "搜索俱乐部名称或赛区" }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(intro)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(intro);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(nav)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(nav);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(roster)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(roster);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(slots)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(slots);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`nav.AddChild(pages)`；返回值紧邻使用处：`ExpressionStatementSyntax: nav.AddChild(pages);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(window)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(window);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`slots.AddChild(contract)`；返回值紧邻使用处：`ExpressionStatementSyntax: slots.AddChild(contract);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`slots.AddChild(seat)`；返回值紧邻使用处：`ExpressionStatementSyntax: slots.AddChild(seat);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`window.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: window.AddChild(panel);`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`body.MoveChild(slots,2)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.MoveChild(slots,2);`
- `Godot.Node.QueueFree()`；输入表达式：`window.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: window.QueueFree();`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`contract.AddItem(s)`；返回值紧邻使用处：`ExpressionStatementSyntax: contract.AddItem(s);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`seat.AddItem(s)`；返回值紧邻使用处：`ExpressionStatementSyntax: seat.AddItem(s);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton()`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new OptionButton()`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2I.Vector2I(int, int)`；输入表达式：`new(820,620)`；返回值紧邻使用处：`ArgumentSyntax: new(820,620)`
- `Godot.Window.PopupCenteredClamped(Godot.Vector2I?, float)`；输入表达式：`window.PopupCenteredClamped(new(820,620))`；返回值紧邻使用处：`ExpressionStatementSyntax: window.PopupCenteredClamped(new(820,620));`
- `Godot.Window.Window()`；输入表达式：`new Window { Title=plan.ClubMode == "加盟" ? "选择初始俱乐部" : "创建俱乐部 · 安排阵容", Exclusive=true, Transient=true, Theme=parent.Theme }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Window { Title=plan.ClubMode == "加盟" ? "选择初始俱乐部" : "创建俱乐部 · 安排阵容", Exclusive=true, Transient=true, Theme=parent.Theme }`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { SizeFlagsVertical=Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { SizeFlagsVertical=Control.SizeFlags.ExpandFill }`
- `NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；输入表达式：`CareerCommerce.Quote(d,club)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerCommerce.Quote(d,club)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(d.Credits)`；返回值紧邻使用处：`BinaryExpressionSyntax: "初始资金  " + CareerMoney.Format(d.Credits)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("112230","385566",12,22)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("112230","385566",12,22)`
- `NationalSpire.ClubDraft.ClubDraft()`；输入表达式：`new ClubDraft { Region=region, Name=plan.ClubName, Sponsor=plan.ClubSponsor }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ClubDraft { Region=region, Name=plan.ClubName, Sponsor=plan.ClubSponsor }`
- `NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`；输入表达式：`EsportsWorld.AcceptOffer(d,offer)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.AcceptOffer(d,offer) is { } err`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d,selectedClub)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d,selectedClub) is not { } club`
- `NationalSpire.OwnedClubs.CreateAtOpening(NationalSpire.CareerData, NationalSpire.ClubDraft)`；输入表达式：`OwnedClubs.CreateAtOpening(d,draft)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.CreateAtOpening(d,draft);`
- `NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft, bool)`；输入表达式：`OwnedClubs.CreationError(d,draft,true)`；返回值紧邻使用处：`IsPatternExpressionSyntax: OwnedClubs.CreationError(d,draft,true) is { } err`
- `Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `Render()`；输入表达式：`Render()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _=>Render()`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`EsportsWorld.Countries.Contains(plan.ClubCountry)`；返回值紧邻使用处：`ConditionalExpressionSyntax: EsportsWorld.Countries.Contains(plan.ClubCountry) ? plan.ClubCountry : d.Esports.Country`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.FirstOrDefault(c => c.Name == plan.ClubName && c.Country == region)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Esports.Clubs.FirstOrDefault(c => c.Name == plan.ClubName && c.Country == region)?.Id`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Offers.Add(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Offers.Add(offer);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(3,d.Esports.License)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Esports.License=Math.Max(3,d.Esports.License)`
- `System.OperationCanceledException.OperationCanceledException(string?)`；输入表达式：`new OperationCanceledException("已返回开局设置。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new OperationCanceledException("已返回开局设置。");`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.TaskCompletionSource()`；输入表达式：`new TaskCompletionSource<bool>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TaskCompletionSource<bool>()`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.TrySetResult(TResult)`；输入表达式：`done.TrySetResult(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>done.TrySetResult(false)`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.TrySetResult(TResult)`；输入表达式：`done.TrySetResult(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: done.TrySetResult(true);`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `Columns` = `2`
- `contract.ItemSelected` += `_=>Render()`
- `d.Esports.License` = `Math.Max(3,d.Esports.License)`
- `Exclusive` = `true`
- `Name` = `plan.ClubName`
- `next.Pressed` += `()=>{page++; Render();}`
- `page` = `0`
- `PlaceholderText` = `plan.ClubMode=="自建" ? "自由市场 · 输入姓名可搜索全部 NPC" : "搜索俱乐部名称或赛区"`
- `prev.Pressed` += `()=>{page--; Render();}`
- `Region` = `region`
- `search.TextChanged` += `_=>{page=0;Render();}`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `Control.SizeFlags.ExpandFill`
- `Sponsor` = `plan.ClubSponsor`
- `status.Text` = `"请选择一家俱乐部。"`
- `status.Text` = `err`
- `Text` = `"初始资金  " + CareerMoney.Format(d.Credits)`
- `Theme` = `parent.Theme`
- `Title` = `plan.ClubMode == "加盟" ? "选择初始俱乐部" : "创建俱乐部 · 安排阵容"`
- `Transient` = `true`
- `window.CloseRequested` += `()=>done.TrySetResult(false)`
- `window.TreeExiting` += `()=>done.TrySetResult(false)`

<a id="symbol-f2c640b93786"></a>

## `ButtonIn(Godot.Container, string, System.Action?) — Button ButtonIn(Container row,string title,Action? click)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningClubEditor.Choose(Godot.Control, NationalSpire.CareerData, NationalSpire.CareerOpeningWorld)`](OpeningClubEditor.cs.md#symbol-e9ebb9b42754)；[`Render()`](OpeningClubEditor.cs.md#symbol-4f3fab6688ad)

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

<a id="symbol-4f3fab6688ad"></a>

## `Render() — void Render()`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningClubEditor.Choose(Godot.Control, NationalSpire.CareerData, NationalSpire.CareerOpeningWorld)`](OpeningClubEditor.cs.md#symbol-e9ebb9b42754)；[`Render()`](OpeningClubEditor.cs.md#symbol-4f3fab6688ad)

**调用：** [`ButtonIn(Godot.Container, string, System.Action?)`](OpeningClubEditor.cs.md#symbol-f2c640b93786)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-86d3ae3f2a68)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-522aa99991c7)；[`Render()`](OpeningClubEditor.cs.md#symbol-4f3fab6688ad)；`Godot.OptionButton.GetItemText(int)`；`NationalSpire.ClubSigning.ClubSigning()`；`string.Contains(string, System.StringComparison)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Collections.Generic.List<T>.ToArray()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `(string Title, string Detail, System.Action Select).Detail`；`(string Title, string Detail, System.Action Select).Select`；`(string Title, string Detail, System.Action Select).Title`；`ButtonIn(Godot.Container, string, System.Action?)`；`NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Name`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerOpeningWorld.ClubMode`；`NationalSpire.CareerOpeningWorld.ClubName`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.ClubDraft.Name`；`NationalSpire.ClubDraft.Region`；`NationalSpire.ClubDraft.Signings`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.ClubSigning.Position`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft)`；`Render()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(grid,c.Title+"\n"+c.Detail,c.Select)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIn(grid,c.Title+"\n"+c.Detail,c.Select);`
- `ButtonIn(Godot.Container, string, System.Action?)`；输入表达式：`ButtonIn(roster,pick.Position+" · "+CareerEngine.DisplayName(d,pick.PersonId)+" ×",()=>{draft.Signings.Remove(pick);Render();})`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIn(roster,pick.Position+" · "+CareerEngine.DisplayName(d,pick.PersonId)+" ×",()=>{draft.Signings.Remove(pick);Render();});`
- `Godot.OptionButton.GetItemText(int)`；输入表达式：`seat.GetItemText(seat.Selected)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Position=seat.GetItemText(seat.Selected)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,pick.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: pick.Position+" · "+CareerEngine.DisplayName(d,pick.PersonId)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(OwnedClubs.InitialCost(d,draft))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(OwnedClubs.InitialCost(d,draft))}`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(grid);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(roster)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(roster);`
- `NationalSpire.ClubSigning.ClubSigning()`；输入表达式：`new(){PersonId=p.Id,Plan=term,Position=seat.GetItemText(seat.Selected)}`；返回值紧邻使用处：`ArgumentSyntax: new(){PersonId=p.Id,Plan=term,Position=seat.GetItemText(seat.Selected)}`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d,p.ClubId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: EsportsWorld.Club(d,p.ClubId)?.Name`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d,selectedClub)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EsportsWorld.Club(d,selectedClub)`
- `NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.Candidates(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: q.Length==0 ? OwnedClubs.Candidates(d) : d.People.Where(p=>!OwnedClubs.Humans(d).Contains(p.Id) && p.Id!="player" &&                     (p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase))`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.Humans(d).Contains`
- `NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft)`；输入表达式：`OwnedClubs.InitialCost(d,draft)`；返回值紧邻使用处：`ArgumentSyntax: OwnedClubs.InitialCost(d,draft)`
- `Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `string.Contains(string, System.StringComparison)`；输入表达式：`(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: q.Length==0 || (c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`(p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: !OwnedClubs.Humans(d).Contains(p.Id) && p.Id!="player" &&                     (p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" ",p.HandleAliases)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)`
- `string.Trim()`；输入表达式：`search.Text.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =search.Text.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.Clubs.Where(c=>q.Length==0 || (c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase))                             .OrderByDescending(c=>c.Name==plan.ClubName)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c=>q.Length==0 || (c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase))                             .OrderByDescending(c=>c.Name==plan.ClubName).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`choices.Skip(page*10)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choices.Skip(page*10).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`choices.Skip(page*10).Take(10)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in choices.Skip(page*10).Take(10)) ButtonIn(grid,c.Title+"\n"+c.Detail,c.Select);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.Where(c=>q.Length==0 || (c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c=>q.Length==0 || (c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase))                             .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p=>!OwnedClubs.Humans(d).Contains(p.Id) && p.Id!="player" &&                     (p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`ConditionalExpressionSyntax: q.Length==0 ? OwnedClubs.Candidates(d) : d.People.Where(p=>!OwnedClubs.Humans(d).Contains(p.Id) && p.Id!="player" &&                     (p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`choices.Add((club.Name,club.Country+"赛区",()=>{ selectedClub=club.Id; Render(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Add((club.Name,club.Country+"赛区",()=>{ selectedClub=club.Id; Render(); }));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`choices.Add((p.PublicName,EsportsWorld.Club(d,p.ClubId)?.Name ?? "自由选手",()=>{                         draft.Signings.RemoveAll(s=>s.PersonId==p.Id);                         draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat.GetItemText(seat.Selected)}); Render();                     }))`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Add((p.PublicName,EsportsWorld.Club(d,p.ClubId)?.Name ?? "自由选手",()=>{                         draft.Signings.RemoveAll(s=>s.PersonId==p.Id);                         draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat.GetItemText(seat.Selected)}); Render();                     }));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat.GetItemText(seat.Selected)})`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat.GetItemText(seat.Selected)});`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`OwnedClubs.Humans(d).Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.Humans(d).Contains(p.Id)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Title,string Detail,Action Select)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<(string Title,string Detail,Action Select)>()`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`draft.Signings.Remove(pick)`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.Signings.Remove(pick);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`draft.Signings.RemoveAll(s=>s.PersonId==p.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.Signings.RemoveAll(s=>s.PersonId==p.Id);`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`draft.Signings.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var pick in draft.Signings.ToArray()) ButtonIn(roster,pick.Position+" · "+CareerEngine.DisplayName(d,pick.PersonId)+" ×",()=>{draft.Signings.Remove(pick);Render();});`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.Clubs.Where(c=>q.Length==0 || (c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase))                             .OrderByDescending(c=>c.Name==plan.ClubName).ThenByDescending(c=>c.Country==region).ThenBy(c=>c.Name)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var club in d.Esports.Clubs.Where(c=>q.Length==0 || (c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase))                             .OrderByDescending(c=>c.Name==plan.ClubName).ThenByDescending(c=>c.Country==region).ThenBy(c=>c.Name))                 {                     choices.Add((club.Name,club.Country+"赛区",()=>{ selectedClub=club.Id; Render(); }));                 }`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.Clubs.Where(c=>q.Length==0 || (c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase))                             .OrderByDescending(c=>c.Name==plan.ClubName).ThenByDescending(c=>c.Country==region)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c=>q.Length==0 || (c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase))                             .OrderByDescending(c=>c.Name==plan.ClubName).ThenByDescending(c=>c.Country==region).ThenBy`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(page,0,count-1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: page=Math.Clamp(page,0,count-1)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,(choices.Count+9)/10)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(1,(choices.Count+9)/10)`

**赋值（含属性/字段和局部值）：**

- `next.Disabled` = `page+1==count`
- `page` = `Math.Clamp(page,0,count-1)`
- `pages.Text` = `$"{page+1} / {count}"`
- `PersonId` = `p.Id`
- `Plan` = `term`
- `Position` = `seat.GetItemText(seat.Selected)`
- `prev.Disabled` = `page==0`
- `selectedClub` = `club.Id`
- `status.Text` = `$"{draft.Name}  ·  {draft.Region}赛区    注册与签约合计  {CareerMoney.Format(OwnedClubs.InitialCost(d,draft))}"`
- `status.Text` = `current==null ? "选择要代表的俱乐部" : "已选择  "+current.Name+" · "+current.Country+"赛区"`
