# LeagueArenaScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`246557AAB993FD3ECC7D27F829F1B8972678CDBFE5824F15A432EC439DD0D86C`。来源：[源码](../../LeagueArenaScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CareerScreen.Opening`。

字段、事件及初始值（源码原样）：

```csharp
private Task? _animation;
internal string? CharacterSound;
private static Opening? _opening;
```

<a id="symbol-fff1f7f80e4d"></a>

## `NationalSpire.CareerScreen.LeaguePortrait(NationalSpire.AvatarArt, int, int) — private static CareerAvatar LeaguePortrait(AvatarArt art,int tier,int size)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`Side(bool, NationalSpire.AvatarArt, int, string, string)`](LeagueArenaScreen.cs.md#symbol-81dd2d9b1aaf)

**调用：** `Godot.Vector2.Vector2(float, float)`；`NationalSpire.AvatarIdentity.AvatarIdentity(NationalSpire.AvatarFrame, int, string, string)`；`NationalSpire.CareerAvatar.CareerAvatar()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.Frames`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(size,size)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(size,size)`
- `NationalSpire.AvatarIdentity.AvatarIdentity(NationalSpire.AvatarFrame, int, string, string)`；输入表达式：`new(frame,-1,"","")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Identity=new(frame,-1,"","")`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new(){Art=art,Identity=new(frame,-1,"",""),CustomMinimumSize=new(size,size),MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`ReturnStatementSyntax: return new(){Art=art,Identity=new(frame,-1,"",""),CustomMinimumSize=new(size,size),MouseFilter=MouseFilterEnum.Ignore};`

**赋值（含属性/字段和局部值）：**

- `Art` = `art`
- `CustomMinimumSize` = `new(size,size)`
- `Identity` = `new(frame,-1,"","")`
- `MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-bd915636fa04"></a>

## `NationalSpire.CareerScreen.LeagueScore(NationalSpire.LeagueReceipt) — private static string LeagueScore(LeagueReceipt r)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`](LeagueArenaScreen.cs.md#symbol-53c6da8a2b7e)

**调用：** [`NationalSpire.LeagueLadder.Tier(int)`](LeagueLadder.cs.md#symbol-b15a71b48f9a)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueLadder.Names`；`NationalSpire.LeagueLadder.Tier(int)`；`NationalSpire.LeagueReceipt.After`；`NationalSpire.LeagueReceipt.Before`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueLadder.Tier(int)`；输入表达式：`LeagueLadder.Tier(r.After)`；返回值紧邻使用处：`ArgumentSyntax: LeagueLadder.Tier(r.After)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3c3abfed3567"></a>

## `NationalSpire.CareerScreen.LeaguePrize(NationalSpire.LeagueReceipt) — private static string LeaguePrize(LeagueReceipt r)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`](LeagueArenaScreen.cs.md#symbol-53c6da8a2b7e)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.LeagueReceipt.Prize`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(r.Prize)`；返回值紧邻使用处：`BinaryExpressionSyntax: "胜场奖金   +"+CareerMoney.Format(r.Prize)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9fa96420666c"></a>

## `NationalSpire.CareerScreen.LeagueAward(NationalSpire.LeagueReceipt) — private void LeagueAward(LeagueReceipt receipt)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Done()`](LeagueScreen.cs.md#symbol-d964f7e2b387)；[`NationalSpire.CareerScreen.PresentTeamReceipt()`](LeagueTeamMatch.cs.md#symbol-70a7f721c6f0)

**调用：** [`NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`](LeagueArenaScreen.cs.md#symbol-53c6da8a2b7e)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`；输入表达式：`RankedReport(receipt,true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>RankedReport(receipt,true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-53c6da8a2b7e"></a>

## `NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool) — private void RankedReport(LeagueReceipt receipt,bool justFinished)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.LeagueAward(NationalSpire.LeagueReceipt)`](LeagueArenaScreen.cs.md#symbol-9fa96420666c)

**调用：** [`NationalSpire.CareerScreen.DuelReportView(Godot.VBoxContainer, NationalSpire.DuelReport, bool)`](DuelReportScreen.cs.md#symbol-4edd420a2689)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.LeaguePrize(NationalSpire.LeagueReceipt)`](LeagueArenaScreen.cs.md#symbol-3c3abfed3567)；[`NationalSpire.CareerScreen.LeagueScore(NationalSpire.LeagueReceipt)`](LeagueArenaScreen.cs.md#symbol-bd915636fa04)；[`NationalSpire.CareerScreen.LeagueSound(string)`](LeagueScreen.cs.md#symbol-74fb1d846f7f)；[`NationalSpire.CareerScreen.ReportPanel(string, string, int)`](DuelReportScreen.cs.md#symbol-9fcea98c8fe1)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.CreateTween()`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；`NationalSpire.LeagueSeal.LeagueSeal()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.DuelReportView(Godot.VBoxContainer, NationalSpire.DuelReport, bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.LeaguePrize(NationalSpire.LeagueReceipt)`；`NationalSpire.CareerScreen.LeagueScore(NationalSpire.LeagueReceipt)`；`NationalSpire.CareerScreen.LeagueSound(string)`；`NationalSpire.CareerScreen.ReportPanel(string, string, int)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.LeagueFinish.Report`；`NationalSpire.LeagueReceipt.Fight`；`NationalSpire.LeagueReceipt.Won`；`NationalSpire.LeagueSeal.Burst`；`NationalSpire.LeagueSeal.Ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new(1,1,1,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: panel.Modulate=new(1,1,1,0)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",12);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`seal.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: seal.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(seal)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(seal);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Glyph("trophy",28,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Glyph("trophy",28,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(points)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(points);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(prize)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(prize);`
- `Godot.Node.CreateTween()`；输入表达式：`panel.CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: panel.CreateTween().TweenProperty`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`panel.CreateTween().TweenProperty(panel,"modulate:a",1,.34)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.CreateTween().TweenProperty(panel,"modulate:a",1,.34);`
- `NationalSpire.CareerScreen.DuelReportView(Godot.VBoxContainer, NationalSpire.DuelReport, bool)`；输入表达式：`DuelReportView(box,report,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DuelReportView(box,report,true);`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("trophy",28,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Glyph("trophy",28,_gold)`
- `NationalSpire.CareerScreen.LeaguePrize(NationalSpire.LeagueReceipt)`；输入表达式：`LeaguePrize(receipt)`；返回值紧邻使用处：`ArgumentSyntax: LeaguePrize(receipt)`
- `NationalSpire.CareerScreen.LeagueScore(NationalSpire.LeagueReceipt)`；输入表达式：`LeagueScore(receipt)`；返回值紧邻使用处：`ArgumentSyntax: LeagueScore(receipt)`
- `NationalSpire.CareerScreen.LeagueSound(string)`；输入表达式：`LeagueSound("event:/sfx/ui/timeline/ui_timeline_unlock")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueSound("event:/sfx/ui/timeline/ui_timeline_unlock");`
- `NationalSpire.CareerScreen.ReportPanel(string, string, int)`；输入表达式：`ReportPanel("1c2c36","49606a",12)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ReportPanel("1c2c36","49606a",12)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog(receipt.Won?"对决胜利":"对决惜败","",()=>true,"返回对战",box=>{              var panel=ReportPanel("1c2c36","49606a",12);panel.Name="LeagueRankSummary";box.AddChild(panel);              var row=new HBoxContainer();row.AddThemeConstantOverride("separation",12);panel.AddChild(row);              row.AddChild(Glyph("trophy",28,_gold));              var points=Text(LeagueScore(receipt),24,_gold);points.AutowrapMode=TextServer.AutowrapMode.Off;row.AddChild(points);              var prize=Text(LeaguePrize(receipt),17,_muted);prize.HorizontalAlignment=HorizontalAlignment.Right;row.AddChild(prize);              if(receipt.Fight.Report is {} report)DuelReportView(box,report,true);              if(justFinished){                  panel.Modulate=new(1,1,1,0);panel.CreateTween().TweenProperty(panel,"modulate:a",1,.34);                  if(receipt.Won){                      LeagueSound("event:/sfx/ui/timeline/ui_timeline_unlock");                      var seal=new LeagueSeal{Burst=true,Ink=_gold,MouseFilter=MouseFilterEnum.Ignore};                      panel.AddChild(seal);seal.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);                  }              }          },showCancel:false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(receipt.Won?"对决胜利":"对决惜败","",()=>true,"返回对战",box=>{              var panel=ReportPanel("1c2c36","49606a",12);panel.Name="LeagueRankSummary";box.AddChild(panel);              var row=new HBoxContainer();row.AddThemeConstantOverride("separation",12);panel.AddChild(row);              row.AddChild(Glyph("trophy",28,_gold));              var points=Text(LeagueScore(receipt),24,_gold);points.AutowrapMode=TextServer.AutowrapMode.Off;row.AddChild(points);              var prize=Text(LeaguePrize(receipt),17,_muted);prize.HorizontalAlignment=HorizontalAlignment.Right;row.AddChild(prize);              if(receipt.Fight.Report is {} report)DuelReportView(box,report,true);              if(justFinished){                  panel.Modulate=new(1,1,1,0);panel.CreateTween().TweenProperty(panel,"modulate:a",1,.34);                  if(receipt.Won){                      LeagueSound("event:/sfx/ui/timeline/ui_timeline_unlock");                      var seal=new LeagueSeal{Burst=true,Ink=_gold,MouseFilter=MouseFilterEnum.Ignore};                      panel.AddChild(seal);seal.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);                  }              }          },showCancel:false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(LeaguePrize(receipt),17,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(LeaguePrize(receipt),17,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(LeagueScore(receipt),24,_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(LeagueScore(receipt),24,_gold)`
- `NationalSpire.LeagueSeal.LeagueSeal()`；输入表达式：`new LeagueSeal{Burst=true,Ink=_gold,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueSeal{Burst=true,Ink=_gold,MouseFilter=MouseFilterEnum.Ignore}`

**赋值（含属性/字段和局部值）：**

- `Burst` = `true`
- `Ink` = `_gold`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `panel.Modulate` = `new(1,1,1,0)`
- `panel.Name` = `"LeagueRankSummary"`
- `points.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `prize.HorizontalAlignment` = `HorizontalAlignment.Right`

<a id="symbol-15a0698166cc"></a>

## `NationalSpire.CareerScreen.ShowDuelReport(NationalSpire.DuelReport) — private void ShowDuelReport(DuelReport report)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DetailHeading()`](SettlementScreen.cs.md#symbol-9fa7e6f11d08)

**调用：** [`NationalSpire.CareerScreen.DuelReportView(Godot.VBoxContainer, NationalSpire.DuelReport, bool)`](DuelReportScreen.cs.md#symbol-4edd420a2689)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DuelReportView(Godot.VBoxContainer, NationalSpire.DuelReport, bool)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.DuelReportView(Godot.VBoxContainer, NationalSpire.DuelReport, bool)`；输入表达式：`DuelReportView(box,report,true)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: box=>DuelReportView(box,report,true)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("对决战报","",()=>true,"返回",box=>DuelReportView(box,report,true),showCancel:false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("对决战报","",()=>true,"返回",box=>DuelReportView(box,report,true),showCancel:false);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-59be112523d9"></a>

## `NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData) — private void LeagueArena(CareerData d)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)

**调用：** [`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；[`NationalSpire.CareerScreen.LeagueGo(string)`](LeagueScreen.cs.md#symbol-46069e214cbd)；[`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`](LeagueScreen.cs.md#symbol-c7e40485fba6)；[`NationalSpire.CareerScreen.LeaguePortrait(NationalSpire.AvatarArt, int, int)`](LeagueArenaScreen.cs.md#symbol-fff1f7f80e4d)；[`NationalSpire.CareerScreen.LeaguePrize(NationalSpire.LeagueReceipt)`](LeagueArenaScreen.cs.md#symbol-3c3abfed3567)；[`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`](LeagueScreen.cs.md#symbol-df3facf7c8b0)；[`NationalSpire.CareerScreen.LeagueScore(NationalSpire.LeagueReceipt)`](LeagueArenaScreen.cs.md#symbol-bd915636fa04)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.PresentTeamReceipt()`](LeagueTeamMatch.cs.md#symbol-70a7f721c6f0)；[`NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`](LeagueArenaScreen.cs.md#symbol-53c6da8a2b7e)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueCards.GroupName(string)`](LeagueCards.cs.md#symbol-92f715052b3d)；[`NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-66c78042d433)；[`NationalSpire.LeagueLadder.Tier(int)`](LeagueLadder.cs.md#symbol-b15a71b48f9a)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ProgressBar.ProgressBar()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.LeagueFoil.LeagueFoil()`；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._leagueBusy`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；`NationalSpire.CareerScreen.LeagueControl.Primary`；`NationalSpire.CareerScreen.LeagueGo(string)`；`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`；`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；`NationalSpire.CareerScreen.LeaguePortrait(NationalSpire.AvatarArt, int, int)`；`NationalSpire.CareerScreen.LeaguePrize(NationalSpire.LeagueReceipt)`；`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；`NationalSpire.CareerScreen.LeagueScore(NationalSpire.LeagueReceipt)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.PresentTeamReceipt()`；`NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ICareerSession.Host`；`NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.DuelLosses`；`NationalSpire.LeagueAlbum.DuelWins`；`NationalSpire.LeagueAlbum.LastDuel`；`NationalSpire.LeagueAlbum.Rating`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.GroupName(string)`；`NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.Roles`；`NationalSpire.LeagueFinish.Opponent`；`NationalSpire.LeagueFinish.Tier`；`NationalSpire.LeagueFoil.Wide`；`NationalSpire.LeagueLadder.Names`；`NationalSpire.LeagueLadder.Thresholds`；`NationalSpire.LeagueLadder.Tier(int)`；`NationalSpire.LeagueReceipt.Fight`；`NationalSpire.LeagueReceipt.Won`；`NationalSpire.LeagueSolverLink.Supported`；`NationalSpire.LeagueSolverLink.Unavailable`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",10);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`banner.AddThemeStyleboxOverride("panel",pad)`；返回值紧邻使用处：`ExpressionStatementSyntax: banner.AddThemeStyleboxOverride("panel",pad);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`meter.AddThemeStyleboxOverride("background",CareerVisuals.Box("172530","34424b",5,0))`；返回值紧邻使用处：`ExpressionStatementSyntax: meter.AddThemeStyleboxOverride("background",CareerVisuals.Box("172530","34424b",5,0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`meter.AddThemeStyleboxOverride("fill",CareerVisuals.Box("c9a15e","f0d695",5,0))`；返回值紧邻使用处：`ExpressionStatementSyntax: meter.AddThemeStyleboxOverride("fill",CareerVisuals.Box("c9a15e","f0d695",5,0));`
- `Godot.Control.Control()`；输入表达式：`new Control{MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Control{MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`head.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: head.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(banner)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(banner);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`backdrop.AddChild(head)`；返回值紧邻使用处：`ExpressionStatementSyntax: backdrop.AddChild(head);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`banner.AddChild(backdrop)`；返回值紧邻使用处：`ExpressionStatementSyntax: banner.AddChild(backdrop);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`banner.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: banner.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("镜面对决",48,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("镜面对决",48,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(deck==null?"先选择出战职业与牌组。":$"{LeagueCards.GroupName(a.Captain)}   ·   {deck.Values.Sum()} 张出战卡牌",20,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(deck==null?"先选择出战职业与牌组。":$"{LeagueCards.GroupName(a.Captain)}   ·   {deck.Values.Sum()} 张出战卡牌",20,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"{last.Fight.Opponent}   ·   {LeagueLadder.Names[last.Fight.Tier]}对手     /     {LeagueScore(last)}     /     {LeaguePrize(last)}",20,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"{last.Fight.Opponent}   ·   {LeagueLadder.Names[last.Fight.Tier]}对手     /     {LeagueScore(last)}     /     {LeaguePrize(last)}",20,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(LeagueNumber($"联赛邀请赛   /   {LeagueLadder.Names[tier]}   ·   {a.Rating} 分   ·   {a.DuelWins} 胜 {a.DuelLosses} 负",360,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(LeagueNumber($"联赛邀请赛   /   {LeagueLadder.Names[tier]}   ·   {a.Rating} 分   ·   {a.DuelWins} 胜 {a.DuelLosses} 负",360,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(LeaguePortrait(CareerAvatars.ForPerson(d,"player"),tier,62))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(LeaguePortrait(CareerAvatars.ForPerson(d,"player"),tier,62));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(Text("上场对决   /   "+(last.Won?"胜利":"惜败"),26,last.Won?_gold:_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(Text("上场对决   /   "+(last.Won?"胜利":"惜败"),26,last.Won?_gold:_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(TextLink("查看战报",()=>RankedReport(last,false),16,icon:"arrow-up-right"))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(TextLink("查看战报",()=>RankedReport(last,false),16,icon:"arrow-up-right"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(LeagueButton("调整牌组",()=>LeagueGo("组卡"),145))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(LeagueButton("调整牌组",()=>LeagueGo("组卡"),145));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(start)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(start);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`progress.AddChild(meter)`；返回值紧邻使用处：`ExpressionStatementSyntax: progress.AddChild(meter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`progress.AddChild(Text(tier==LeagueLadder.Names.Length-1?"已达最高段位":$"距{LeagueLadder.Names[tier+1]}还差 {next-a.Rating} 分",18,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: progress.AddChild(Text(tier==LeagueLadder.Names.Length-1?"已达最高段位":$"距{LeagueLadder.Names[tier+1]}还差 {next-a.Rating} 分",18,_gold));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer()`
- `Godot.ProgressBar.ProgressBar()`；输入表达式：`new ProgressBar{CustomMinimumSize=new(235,12),ShowPercentage=false,SizeFlagsVertical=SizeFlags.ShrinkCenter,MaxValue=tier==LeagueLadder.Names.Length-1?1:next-floor,Value=tier==LeagueLadder.Names.Length-1?1:a.Rating-floor}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ProgressBar{CustomMinimumSize=new(235,12),ShowPercentage=false,SizeFlagsVertical=SizeFlags.ShrinkCenter,MaxValue=tier==LeagueLadder.Names.Length-1?1:next-floor,Value=tier==LeagueLadder.Names.Length-1?1:a.Rating-floor}`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty{ContentMarginLeft=42,ContentMarginRight=42,ContentMarginTop=28,ContentMarginBottom=28}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new StyleBoxEmpty{ContentMarginLeft=42,ContentMarginRight=42,ContentMarginTop=28,ContentMarginBottom=28}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(235,12)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(235,12)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(d,"player")`；返回值紧邻使用处：`ArgumentSyntax: CareerAvatars.ForPerson(d,"player")`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inner(panel)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:_multiplayer==null?"匹配对手":"团体匹配",()=>{if(MultiplayerCommand("propose-league-team"))return;if(!_leagueBusy)_=LeagueMatch(d);},LeagueSolverLink.Supported?195:300,kind:LeagueControl.Primary)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:_multiplayer==null?"匹配对手":"团体匹配",()=>{if(MultiplayerCommand("propose-league-team"))return;if(!_leagueBusy)_=LeagueMatch(d);},LeagueSolverLink.Supported?195:300,kind:LeagueControl.Primary)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("调整牌组",()=>LeagueGo("组卡"),145)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("调整牌组",()=>LeagueGo("组卡"),145)`
- `NationalSpire.CareerScreen.LeagueGo(string)`；输入表达式：`LeagueGo("组卡")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueGo("组卡")`
- `NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`；输入表达式：`LeagueMatch(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=LeagueMatch(d)`
- `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；输入表达式：`LeagueNumber($"联赛邀请赛   /   {LeagueLadder.Names[tier]}   ·   {a.Rating} 分   ·   {a.DuelWins} 胜 {a.DuelLosses} 负",360,_gold)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNumber($"联赛邀请赛   /   {LeagueLadder.Names[tier]}   ·   {a.Rating} 分   ·   {a.DuelWins} 胜 {a.DuelLosses} 负",360,_gold)`
- `NationalSpire.CareerScreen.LeaguePortrait(NationalSpire.AvatarArt, int, int)`；输入表达式：`LeaguePortrait(CareerAvatars.ForPerson(d,"player"),tier,62)`；返回值紧邻使用处：`ArgumentSyntax: LeaguePortrait(CareerAvatars.ForPerson(d,"player"),tier,62)`
- `NationalSpire.CareerScreen.LeaguePrize(NationalSpire.LeagueReceipt)`；输入表达式：`LeaguePrize(last)`；返回值紧邻使用处：`InterpolationSyntax: {LeaguePrize(last)}`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(body,14)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(body,14)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(body)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(body)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(box)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(box)`
- `NationalSpire.CareerScreen.LeagueScore(NationalSpire.LeagueReceipt)`；输入表达式：`LeagueScore(last)`；返回值紧邻使用处：`InterpolationSyntax: {LeagueScore(last)}`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-league-team")`；返回值紧邻使用处：`IfStatementSyntax: if(MultiplayerCommand("propose-league-team"))return;`
- `NationalSpire.CareerScreen.PresentTeamReceipt()`；输入表达式：`PresentTeamReceipt()`；返回值紧邻使用处：`ExpressionStatementSyntax: PresentTeamReceipt();`
- `NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`；输入表达式：`RankedReport(last,false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>RankedReport(last,false)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("镜面对决",48,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("镜面对决",48,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("上场对决   /   "+(last.Won?"胜利":"惜败"),26,last.Won?_gold:_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("上场对决   /   "+(last.Won?"胜利":"惜败"),26,last.Won?_gold:_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{last.Fight.Opponent}   ·   {LeagueLadder.Names[last.Fight.Tier]}对手     /     {LeagueScore(last)}     /     {LeaguePrize(last)}",20,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{last.Fight.Opponent}   ·   {LeagueLadder.Names[last.Fight.Tier]}对手     /     {LeagueScore(last)}     /     {LeaguePrize(last)}",20,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(deck==null?"先选择出战职业与牌组。":$"{LeagueCards.GroupName(a.Captain)}   ·   {deck.Values.Sum()} 张出战卡牌",20,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(deck==null?"先选择出战职业与牌组。":$"{LeagueCards.GroupName(a.Captain)}   ·   {deck.Values.Sum()} 张出战卡牌",20,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(tier==LeagueLadder.Names.Length-1?"已达最高段位":$"距{LeagueLadder.Names[tier+1]}还差 {next-a.Rating} 分",18,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(tier==LeagueLadder.Names.Length-1?"已达最高段位":$"距{LeagueLadder.Names[tier+1]}还差 {next-a.Rating} 分",18,_gold)`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("查看战报",()=>RankedReport(last,false),16,icon:"arrow-up-right")`；返回值紧邻使用处：`ArgumentSyntax: TextLink("查看战报",()=>RankedReport(last,false),16,icon:"arrow-up-right")`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172530","34424b",5,0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("172530","34424b",5,0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("c9a15e","f0d695",5,0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("c9a15e","f0d695",5,0)`
- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Deck(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Deck(a)`
- `NationalSpire.LeagueCards.GroupName(string)`；输入表达式：`LeagueCards.GroupName(a.Captain)`；返回值紧邻使用处：`InterpolationSyntax: {LeagueCards.GroupName(a.Captain)}`
- `NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Ready(a)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LeagueCards.Ready(a)`
- `NationalSpire.LeagueFoil.LeagueFoil()`；输入表达式：`new LeagueFoil{Wide=true,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueFoil{Wide=true,MouseFilter=MouseFilterEnum.Ignore}`
- `NationalSpire.LeagueLadder.Tier(int)`；输入表达式：`LeagueLadder.Tier(a.Rating)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueLadder.Tier(a.Rating)`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`deck.Values.Sum()`；返回值紧邻使用处：`InterpolationSyntax: {deck.Values.Sum()}`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`LeagueCards.Roles.Any(r=>r.Id.Entry==a.Captain)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LeagueCards.Roles.Any(r=>r.Id.Entry==a.Captain)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(LeagueLadder.Thresholds.Length-1,tier+1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(LeagueLadder.Thresholds.Length-1,tier+1)`

**赋值（含属性/字段和局部值）：**

- `_` = `LeagueMatch(d)`
- `ContentMarginBottom` = `28`
- `ContentMarginLeft` = `42`
- `ContentMarginRight` = `42`
- `ContentMarginTop` = `28`
- `CustomMinimumSize` = `new(235,12)`
- `head.OffsetBottom` = `28`
- `head.OffsetLeft` = `-42`
- `head.OffsetRight` = `42`
- `head.OffsetTop` = `-28`
- `heading.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `MaxValue` = `tier==LeagueLadder.Names.Length-1?1:next-floor`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `ShowPercentage` = `false`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `start.Disabled` = `!LeagueSolverLink.Supported||_multiplayer is {Host:false}||_leagueBusy||!LeagueCards.Ready(a)||!LeagueCards.Roles.Any(r=>r.Id.Entry==a.Captain)`
- `Value` = `tier==LeagueLadder.Names.Length-1?1:a.Rating-floor`
- `Wide` = `true`

<a id="symbol-6ac7616bf9f0"></a>

## `NationalSpire.CareerScreen.MirrorAppointmentArena(NationalSpire.CareerData, NationalSpire.CareerMatch) — private void MirrorAppointmentArena(CareerData data,CareerMatch match)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；[`NationalSpire.CareerScreen.LeagueGo(string)`](LeagueScreen.cs.md#symbol-46069e214cbd)；[`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string, string?)`](MatchArenaScreen.cs.md#symbol-c4eb3ccea4ca)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.LeagueCards.GroupName(string)`](LeagueCards.cs.md#symbol-92f715052b3d)；[`NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-66c78042d433)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.FindChild(string, bool, bool)`

**字段、属性、事件及方法组引用：** `Launch()`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；`NationalSpire.CareerScreen.LeagueGo(string)`；`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string, string?)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueCards.GroupName(string)`；`NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueSolverLink.Supported`；`NationalSpire.LeagueSolverLink.Unavailable`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(LeagueButton("调整牌组",()=>LeagueGo("组卡"),145))`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(LeagueButton("调整牌组",()=>LeagueGo("组卡"),145));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(Text(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:"请先准备 35 张出战牌。",18,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(Text(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:"请先准备 35 张出战牌。",18,_muted));`
- `Godot.Node.FindChild(string, bool, bool)`；输入表达式：`_content.FindChild(name,true,false)`；返回值紧邻使用处：`IsPatternExpressionSyntax: _content.FindChild(name,true,false) is Button b`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data,match.OpponentId)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(data,match.OpponentId)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("调整牌组",()=>LeagueGo("组卡"),145)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("调整牌组",()=>LeagueGo("组卡"),145)`
- `NationalSpire.CareerScreen.LeagueGo(string)`；输入表达式：`LeagueGo("组卡")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueGo("组卡")`
- `NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string, string?)`；输入表达式：`MatchArena(data,match.Event,match.OpponentId,CareerEngine.DisplayName(data,match.OpponentId),              future?"前往比赛日":"开始镜面对决",role,CareerVisuals.Teal,out var controls,match.Day,Launch,seed:match.Seed)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchArena(data,match.Event,match.OpponentId,CareerEngine.DisplayName(data,match.OpponentId),              future?"前往比赛日":"开始镜面对决",role,CareerVisuals.Teal,out var controls,match.Day,Launch,seed:match.Seed);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:"请先准备 35 张出战牌。",18,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:"请先准备 35 张出战牌。",18,_muted)`
- `NationalSpire.LeagueCards.GroupName(string)`；输入表达式：`LeagueCards.GroupName(album.Captain)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.GroupName(album.Captain)`
- `NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Ready(album)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LeagueCards.Ready(album)`

**赋值（含属性/字段和局部值）：**

- `b.Disabled` = `true`

<a id="symbol-0e458038824c"></a>

## `Launch() — async void Launch()`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)；[`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-66c78042d433)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerScreen._leagueBusy`；`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueSolverLink.Supported`；`NationalSpire.LeagueSolverLink.Unavailable`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`；输入表达式：`CareerEngine.AdvanceToDay(data,match.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.AdvanceToDay(data,match.Day);`
- `NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`；输入表达式：`LeagueMatch(data,match)`；返回值紧邻使用处：`AwaitExpressionSyntax: await LeagueMatch(data,match)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-advance","direct",number:match.Day)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !MultiplayerCommand("propose-advance","direct",number:match.Day)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-start",match.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !MultiplayerCommand("propose-start",match.Id)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:"请先准备 35 张出战牌。",true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:"请先准备 35 张出战牌。",true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Ready(album)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LeagueCards.Ready(album)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-601c9785c32a"></a>

## `NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?) — private async Task LeagueMatch(CareerData d,CareerMatch? appointment=null)`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Launch()`](LeagueArenaScreen.cs.md#symbol-0e458038824c)；[`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)

**调用：** [`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`](LeagueArenaScreen.cs.md#symbol-b602cebe9951)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.LeagueArchetypes.Name(string, string)`](LeagueArchetypes.cs.md#symbol-eed6465b998c)；[`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueCards.GroupName(string)`](LeagueCards.cs.md#symbol-92f715052b3d)；[`NationalSpire.LeagueLadder.Invited(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, string)`](LeagueLadder.cs.md#symbol-9dbd4f842c20)；[`NationalSpire.LeagueLadder.Match(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, System.Random, int)`](LeagueLadder.cs.md#symbol-5aa41a3b4644)；[`NationalSpire.LeagueLadder.PrepareRoster(NationalSpire.CareerData)`](LeagueLadder.cs.md#symbol-fc32b34df886)；[`NationalSpire.LeagueLadder.RivalOpens(int)`](LeagueLadder.cs.md#symbol-3b4c257e5975)；[`NationalSpire.LeagueLadder.Tier(int)`](LeagueLadder.cs.md#symbol-b15a71b48f9a)；[`NationalSpire.LeagueSolverLink.Prepare()`](LeagueSolverLink.cs.md#symbol-1ecd89ef590b)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`NationalSpire.LeagueLadder.Draw.Draw(NationalSpire.CareerData)`；`System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Exception.GetBaseException()`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Linq.Enumerable.Repeat<TResult>(TResult, int)`；`System.Random.Next()`；`System.Random.Random()`

**字段、属性、事件及方法组引用：** `(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).Name`；`(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).PersonId`；`(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).Role`；`(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).Style`；`(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).Tier`；`Begin()`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.LeagueRoster`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._leagueBusy`；`NationalSpire.CareerScreen._leagueRival`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.Rating`；`NationalSpire.LeagueAlbum.Upgrades`；`NationalSpire.LeagueArchetypes.Name(string, string)`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.GroupName(string)`；`NationalSpire.LeagueCards.Roles`；`NationalSpire.LeagueLadder.Invited(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, string)`；`NationalSpire.LeagueLadder.Match(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, System.Random, int)`；`NationalSpire.LeagueLadder.PrepareRoster(NationalSpire.CareerData)`；`NationalSpire.LeagueLadder.RivalOpens(int)`；`NationalSpire.LeagueLadder.Tier(int)`；`NationalSpire.LeagueSolverLink.Prepare()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(this)`；返回值紧邻使用处：`BinaryExpressionSyntax: GodotObject.IsInstanceValid(this)&&IsInsideTree()`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: GodotObject.IsInstanceValid(this)&&IsInsideTree()`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(rival.IconTexture,_gold,match.Name)`；返回值紧邻使用处：`ConditionalExpressionSyntax: match.PersonId==null?new(rival.IconTexture,_gold,match.Name):CareerAvatars.ForPerson(d,match.PersonId)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(d,"player")`；返回值紧邻使用处：`ArgumentSyntax: CareerAvatars.ForPerson(d,"player")`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(d,match.PersonId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: match.PersonId==null?new(rival.IconTexture,_gold,match.Name):CareerAvatars.ForPerson(d,match.PersonId)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(e.GetBaseException().Message,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(e.GetBaseException().Message,true);`
- `NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`；输入表达式：`OpeningGate(appointment?.Event ?? "国运尖塔   /   联赛邀请赛",CareerAvatars.ForPerson(d,"player"),LeagueLadder.Tier(a.Rating),LeagueCards.GroupName(role.Id.Entry),"我的牌组",                  match.PersonId==null?new(rival.IconTexture,_gold,match.Name):CareerAvatars.ForPerson(d,match.PersonId),match.Tier,LeagueCards.GroupName(rival.Id.Entry),match.Name+" · "+LeagueArchetypes.Name(rival.Id.Entry,match.Style),LeagueLadder.RivalOpens(seed)?"对手先手":"你方先手", Begin)`；返回值紧邻使用处：`AwaitExpressionSyntax: await OpeningGate(appointment?.Event ?? "国运尖塔   /   联赛邀请赛",CareerAvatars.ForPerson(d,"player"),LeagueLadder.Tier(a.Rating),LeagueCards.GroupName(role.Id.Entry),"我的牌组",                  match.PersonId==null?new(rival.IconTexture,_gold,match.Name):CareerAvatars.ForPerson(d,match.PersonId),match.Tier,LeagueCards.GroupName(rival.Id.Entry),match.Name+" · "+LeagueArchetypes.Name(rival.Id.Entry,match.Style),LeagueLadder.RivalOpens(seed)?"对手先手":"你方先手", Begin)`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("league-match",e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("league-match",e);`
- `NationalSpire.LeagueArchetypes.Name(string, string)`；输入表达式：`LeagueArchetypes.Name(rival.Id.Entry,match.Style)`；返回值紧邻使用处：`BinaryExpressionSyntax: match.Name+" · "+LeagueArchetypes.Name(rival.Id.Entry,match.Style)`
- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Deck(a)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: LeagueCards.Deck(a)!`
- `NationalSpire.LeagueCards.GroupName(string)`；输入表达式：`LeagueCards.GroupName(rival.Id.Entry)`；返回值紧邻使用处：`ArgumentSyntax: LeagueCards.GroupName(rival.Id.Entry)`
- `NationalSpire.LeagueCards.GroupName(string)`；输入表达式：`LeagueCards.GroupName(role.Id.Entry)`；返回值紧邻使用处：`ArgumentSyntax: LeagueCards.GroupName(role.Id.Entry)`
- `NationalSpire.LeagueLadder.Draw.Draw(NationalSpire.CareerData)`；输入表达式：`new LeagueLadder.Draw(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueLadder.Draw(d)`
- `NationalSpire.LeagueLadder.Invited(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, string)`；输入表达式：`LeagueLadder.Invited(d.LeagueRoster!,draw,appointment.OpponentId)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueLadder.Invited(d.LeagueRoster!,draw,appointment.OpponentId) ?? throw new InvalidOperationException("这位选手的职业暂时无法参加镜面对决。")`
- `NationalSpire.LeagueLadder.Match(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, System.Random, int)`；输入表达式：`LeagueLadder.Match(d.LeagueRoster!,draw,rng,LeagueLadder.Tier(a.Rating))`；返回值紧邻使用处：`ConditionalExpressionSyntax: appointment==null ? LeagueLadder.Match(d.LeagueRoster!,draw,rng,LeagueLadder.Tier(a.Rating))                  : LeagueLadder.Invited(d.LeagueRoster!,draw,appointment.OpponentId) ?? throw new InvalidOperationException("这位选手的职业暂时无法参加镜面对决。")`
- `NationalSpire.LeagueLadder.PrepareRoster(NationalSpire.CareerData)`；输入表达式：`LeagueLadder.PrepareRoster(d)`；返回值紧邻使用处：`IfStatementSyntax: if(LeagueLadder.PrepareRoster(d))CareerStore.Save(d);`
- `NationalSpire.LeagueLadder.RivalOpens(int)`；输入表达式：`LeagueLadder.RivalOpens(seed)`；返回值紧邻使用处：`ConditionalExpressionSyntax: LeagueLadder.RivalOpens(seed)?"对手先手":"你方先手"`
- `NationalSpire.LeagueLadder.Tier(int)`；输入表达式：`LeagueLadder.Tier(a.Rating)`；返回值紧邻使用处：`ArgumentSyntax: LeagueLadder.Tier(a.Rating)`
- `NationalSpire.LeagueSolverLink.Prepare()`；输入表达式：`LeagueSolverLink.Prepare()`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueSolverLink.Prepare();`
- `System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；输入表达式：`.ToDictionary()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: a.Upgrades.GetValueOrDefault(a.Captain)?.ToDictionary()`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`LeagueCards.Deck(a)!.SelectMany(x=>Enumerable.Repeat(LeagueCards.Catalog[x.Key].Model,x.Value))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.Deck(a)!.SelectMany(x=>Enumerable.Repeat(LeagueCards.Catalog[x.Key].Model,x.Value)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`roles.Single(r=>r.Id.Entry==a.Captain)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =roles.Single(r=>r.Id.Entry==a.Captain)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`LeagueCards.Deck(a)!.SelectMany(x=>Enumerable.Repeat(LeagueCards.Catalog[x.Key].Model,x.Value)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Deck(a)!.SelectMany(x=>Enumerable.Repeat(LeagueCards.Catalog[x.Key].Model,x.Value)).ToArray()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Upgrades.GetValueOrDefault(a.Captain)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: a.Upgrades.GetValueOrDefault(a.Captain)?.ToDictionary()`
- `System.Exception.GetBaseException()`；输入表达式：`e.GetBaseException()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.GetBaseException().Message`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("这位选手的职业暂时无法参加镜面对决。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("这位选手的职业暂时无法参加镜面对决。")`
- `System.Linq.Enumerable.Repeat<TResult>(TResult, int)`；输入表达式：`Enumerable.Repeat(LeagueCards.Catalog[x.Key].Model,x.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x=>Enumerable.Repeat(LeagueCards.Catalog[x.Key].Model,x.Value)`
- `System.Random.Next()`；输入表达式：`rng.Next()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =rng.Next()`
- `System.Random.Random()`；输入表达式：`new Random()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Random()`

**赋值（含属性/字段和局部值）：**

- `_leagueBusy` = `false`
- `_leagueBusy` = `true`
- `_leagueRival` = `match.Name`

<a id="symbol-8456a000aa0c"></a>

## `Begin() — async Task Begin()`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueArchetypes.Resolve(string, string)`](LeagueArchetypes.cs.md#symbol-8cffe8f79fa2)；[`NationalSpire.LeagueLadder.Build(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string)`](LeagueLadder.cs.md#symbol-a46e08a27495)；[`NationalSpire.LeagueLadder.Tier(int)`](LeagueLadder.cs.md#symbol-b15a71b48f9a)；[`NationalSpire.LeagueLadder.UpgradePlan(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random)`](LeagueLadder.cs.md#symbol-8988ba35b084)；[`NationalSpire.LeagueNativeMatch.StartMirror(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?, string?, string?)`](LeagueNativeMatch.cs.md#symbol-a60b957088cc)；`Godot.Node.IsInsideTree()`；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).PersonId`；`(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).Style`；`(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).Tier`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerScreen._leagueRival`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.ICareerSession.Message`；`NationalSpire.LeagueAlbum.Rating`；`NationalSpire.LeagueArchetypes.Resolve(string, string)`；`NationalSpire.LeagueLadder.Build(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string)`；`NationalSpire.LeagueLadder.Tier(int)`；`NationalSpire.LeagueLadder.UpgradePlan(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random)`；`NationalSpire.LeagueNativeMatch.StartMirror(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?, string?, string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: session!=null&&IsInsideTree()`
- `NationalSpire.LeagueArchetypes.Resolve(string, string)`；输入表达式：`LeagueArchetypes.Resolve(rival.Id.Entry,match.Style)`；返回值紧邻使用处：`ArgumentSyntax: LeagueArchetypes.Resolve(rival.Id.Entry,match.Style)`
- `NationalSpire.LeagueLadder.Build(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string)`；输入表达式：`LeagueLadder.Build(rival,rng,match.Tier,match.Style)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueLadder.Build(rival,rng,match.Tier,match.Style).ToArray`
- `NationalSpire.LeagueLadder.Tier(int)`；输入表达式：`LeagueLadder.Tier(a.Rating)`；返回值紧邻使用处：`ArgumentSyntax: LeagueLadder.Tier(a.Rating)`
- `NationalSpire.LeagueLadder.UpgradePlan(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random)`；输入表达式：`LeagueLadder.UpgradePlan(rivalCards,LeagueArchetypes.Resolve(rival.Id.Entry,match.Style),match.Tier,rng)`；返回值紧邻使用处：`ArgumentSyntax: LeagueLadder.UpgradePlan(rivalCards,LeagueArchetypes.Resolve(rival.Id.Entry,match.Style),match.Tier,rng)`
- `NationalSpire.LeagueNativeMatch.StartMirror(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?, string?, string?)`；输入表达式：`LeagueNativeMatch.StartMirror(role,selected,rival,rivalCards,seed,session,_leagueRival,match.Tier,upgrades,LeagueLadder.UpgradePlan(rivalCards,LeagueArchetypes.Resolve(rival.Id.Entry,match.Style),match.Tier,rng),LeagueLadder.Tier(a.Rating),match.Style,match.PersonId,appointment?.Id)`；返回值紧邻使用处：`AwaitExpressionSyntax: await LeagueNativeMatch.StartMirror(role,selected,rival,rivalCards,seed,session,_leagueRival,match.Tier,upgrades,LeagueLadder.UpgradePlan(rivalCards,LeagueArchetypes.Resolve(rival.Id.Entry,match.Style),match.Tier,rng),LeagueLadder.Tier(a.Rating),match.Style,match.PersonId,appointment?.Id)`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`LeagueLadder.Build(rival,rng,match.Tier,match.Style).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueLadder.Build(rival,rng,match.Tier,match.Style).ToArray()`

**赋值（含属性/字段和局部值）：**

- `_multiplayer` = `null`
- `_multiplayer` = `session`
- `session.Message` -= `Notice`
- `session.Message` += `Notice`

<a id="symbol-037fa373f660"></a>

## `NationalSpire.CareerScreen.Opening.Visible — internal bool Visible`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c871e7a27a03"></a>

## `NationalSpire.CareerScreen.Opening.LoadChapter(System.Threading.Tasks.Task) — internal async Task LoadChapter(Task assets)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpeningChapter(System.Threading.Tasks.Task)`](LeagueArenaScreen.cs.md#symbol-5f1f6efd38ec)

**调用：** `System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Threading.Tasks.Task.WhenAll(params System.Threading.Tasks.Task[])`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Opening._animation`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<TResult>.Invoke()`；输入表达式：`countdown()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _animation??=countdown()`
- `System.Threading.Tasks.Task.WhenAll(params System.Threading.Tasks.Task[])`；输入表达式：`Task.WhenAll(assets,_animation)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.WhenAll(assets,_animation)`

**赋值（含属性/字段和局部值）：**

- `_animation` ??= `countdown()`

<a id="symbol-a63c53a4d9b3"></a>

## `NationalSpire.CareerScreen.Opening.Reveal() — internal void Reveal()`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RevealOpening()`](LeagueArenaScreen.cs.md#symbol-bf9d7644463b)

**调用：** [`NationalSpire.CareerScreen.LeagueSound(string)`](LeagueScreen.cs.md#symbol-74fb1d846f7f)；`Godot.CanvasItem.Hide()`；`MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.UpdateMusic()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.LeagueSound(string)`；`NationalSpire.CareerScreen.Opening.CharacterSound`；`NationalSpire.CareerScreen.Opening.Visible`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`gate.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: gate.Hide();`
- `MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.UpdateMusic()`；输入表达式：`.UpdateMusic()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.Instance?.UpdateMusic()`
- `NationalSpire.CareerScreen.LeagueSound(string)`；输入表达式：`LeagueSound(CharacterSound)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueSound(CharacterSound);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-64063993b150"></a>

## `NationalSpire.CareerScreen.OpeningVisible — internal static bool OpeningVisible`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._opening`；`NationalSpire.CareerScreen.Opening.Visible`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-714fe2bbacbd"></a>

## `NationalSpire.CareerScreen.UseOpening(string?) — internal static bool UseOpening(string? sound=null)`

来源：源码第 126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](GameBridge.cs.md#symbol-59b73a224875)；[`Begin()`](LeagueTeamMatch.cs.md#symbol-7d973fd93537)；[`NationalSpire.Coop.CoopSteamRunPlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`](Coop/CoopNativeRun.cs.md#symbol-b889ef6fb033)；[`NationalSpire.LeagueNativeMatch.StartMirror(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?, string?, string?)`](LeagueNativeMatch.cs.md#symbol-a60b957088cc)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._opening`；`NationalSpire.CareerScreen.Opening.CharacterSound`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `opening.CharacterSound` = `sound`

<a id="symbol-5f1f6efd38ec"></a>

## `NationalSpire.CareerScreen.OpeningChapter(System.Threading.Tasks.Task) — internal static Task OpeningChapter(Task assets)`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchStartLoadPatch.Postfix(System.Reflection.MethodBase, ref System.Threading.Tasks.Task)`](MatchStartWatch.cs.md#symbol-1823c1ed83e0)

**调用：** [`NationalSpire.CareerScreen.Opening.LoadChapter(System.Threading.Tasks.Task)`](LeagueArenaScreen.cs.md#symbol-c871e7a27a03)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._opening`；`NationalSpire.CareerScreen.Opening.LoadChapter(System.Threading.Tasks.Task)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Opening.LoadChapter(System.Threading.Tasks.Task)`；输入表达式：`.LoadChapter(assets)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _opening?.LoadChapter(assets)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bf9d7644463b"></a>

## `NationalSpire.CareerScreen.RevealOpening() — internal static void RevealOpening()`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningRoomReveal.Prefix(Godot.Control?)`](MatchStartWatch.cs.md#symbol-ded27ae4f0bc)

**调用：** [`NationalSpire.CareerScreen.Opening.Reveal()`](LeagueArenaScreen.cs.md#symbol-a63c53a4d9b3)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._opening`；`NationalSpire.CareerScreen.Opening.Reveal()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Opening.Reveal()`；输入表达式：`.Reveal()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _opening?.Reveal()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b602cebe9951"></a>

## `NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>) — internal async Task OpeningGate(string title,AvatarArt home,int homeTier,string homeName,string homeDetail,AvatarArt away,int awayTier,string awayName,string awayDetail,string note,Func<Task> begin)`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FormalGate(NationalSpire.CareerData, NationalSpire.CareerMatch, string, System.Func<System.Threading.Tasks.Task>)`](LeagueArenaScreen.cs.md#symbol-72880a76b76f)；[`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`Caption(string, int, Godot.Color, float, float, float, float)`](LeagueArenaScreen.cs.md#symbol-7f5c9a8aac1e)；[`NationalSpire.MatchStartWatch.Begin(Godot.Node, string, System.Func<bool>, System.Action)`](MatchStartWatch.cs.md#symbol-a39a7334ee0a)；[`NationalSpire.MatchStartWatch.Finish()`](MatchStartWatch.cs.md#symbol-2b2800aa6a80)；[`Side(bool, NationalSpire.AvatarArt, int, string, string)`](LeagueArenaScreen.cs.md#symbol-81dd2d9b1aaf)；`Godot.CanvasLayer.CanvasLayer()`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetTree()`；`Godot.Node.QueueFree()`；`NationalSpire.CareerScreen.Opening.Opening(NationalSpire.LeagueGate, System.Func<System.Threading.Tasks.Task>)`；`NationalSpire.LeagueGate.LeagueGate()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Animate()`；`Caption(string, int, Godot.Color, float, float, float, float)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._opening`；`NationalSpire.MatchStartWatch.Begin(Godot.Node, string, System.Func<bool>, System.Action)`；`NationalSpire.MatchStartWatch.Finish()`；`NationalSpire.MatchStartWatch.IsActive`；`Side(bool, NationalSpire.AvatarArt, int, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Caption(string, int, Godot.Color, float, float, float, float)`；输入表达式：`Caption(note,18,_muted,.5f,.70f,500,48)`；返回值紧邻使用处：`ExpressionStatementSyntax: Caption(note,18,_muted,.5f,.70f,500,48);`
- `Caption(string, int, Godot.Color, float, float, float, float)`；输入表达式：`Caption(title,23,_gold,.5f,.19f,720,65)`；返回值紧邻使用处：`ExpressionStatementSyntax: Caption(title,23,_gold,.5f,.19f,720,65);`
- `Godot.CanvasLayer.CanvasLayer()`；输入表达式：`new CanvasLayer{Layer=1000,Name="LeagueOpeningLayer"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CanvasLayer{Layer=1000,Name="LeagueOpeningLayer"}`
- `Godot.Control.Control()`；输入表达式：`new Control{MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Control{MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`labels.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: labels.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`tree.ToSignal(RenderingServer.Singleton,RenderingServer.SignalName.FramePostDraw)`；返回值紧邻使用处：`AwaitExpressionSyntax: await tree.ToSignal(RenderingServer.Singleton,RenderingServer.SignalName.FramePostDraw)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`game.AddChild(layer)`；返回值紧邻使用处：`ExpressionStatementSyntax: game.AddChild(layer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layer.AddChild(overlay)`；返回值紧邻使用处：`ExpressionStatementSyntax: layer.AddChild(overlay);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`overlay.AddChild(labels)`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.AddChild(labels);`
- `Godot.Node.GetTree()`；输入表达式：`game.GetTree()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =game.GetTree()`
- `Godot.Node.QueueFree()`；输入表达式：`layer.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: layer.QueueFree();`
- `NationalSpire.CareerScreen.Opening.Opening(NationalSpire.LeagueGate, System.Func<System.Threading.Tasks.Task>)`；输入表达式：`new(overlay,Animate)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _opening=new(overlay,Animate)`
- `NationalSpire.LeagueGate.LeagueGate()`；输入表达式：`new LeagueGate{Name="LeagueMatchGate",Theme=Theme,MouseFilter=MouseFilterEnum.Stop}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueGate{Name="LeagueMatchGate",Theme=Theme,MouseFilter=MouseFilterEnum.Stop}`
- `NationalSpire.MatchStartWatch.Begin(Godot.Node, string, System.Func<bool>, System.Action)`；输入表达式：`MatchStartWatch.Begin(game,title,()=>MegaCrit.Sts2.Core.Saves.SaveManager.Instance.HasRunSave,game.Quit)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MatchStartWatch.IsActive?null:MatchStartWatch.Begin(game,title,()=>MegaCrit.Sts2.Core.Saves.SaveManager.Instance.HasRunSave,game.Quit)`
- `NationalSpire.MatchStartWatch.Finish()`；输入表达式：`.Finish()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: watch?.Finish()`
- `Side(bool, NationalSpire.AvatarArt, int, string, string)`；输入表达式：`Side(false,away,awayTier,awayName,awayDetail)`；返回值紧邻使用处：`ExpressionStatementSyntax: Side(false,away,awayTier,awayName,awayDetail);`
- `Side(bool, NationalSpire.AvatarArt, int, string, string)`；输入表达式：`Side(true,home,homeTier,homeName,homeDetail)`；返回值紧邻使用处：`ExpressionStatementSyntax: Side(true,home,homeTier,homeName,homeDetail);`
- `System.Func<TResult>.Invoke()`；输入表达式：`begin()`；返回值紧邻使用处：`AwaitExpressionSyntax: await begin()`

**赋值（含属性/字段和局部值）：**

- `_opening` = `new(overlay,Animate)`
- `_opening` = `null`
- `Layer` = `1000`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"LeagueMatchGate"`
- `Name` = `"LeagueOpeningLayer"`
- `Theme` = `Theme`

<a id="symbol-7f5c9a8aac1e"></a>

## `Caption(string, int, Godot.Color, float, float, float, float) — Label Caption(string copy,int size,Color color,float x,float y,float width,float height)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Animate()`](LeagueArenaScreen.cs.md#symbol-920ca2d97f7a)；[`NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`](LeagueArenaScreen.cs.md#symbol-b602cebe9951)；[`Side(bool, NationalSpire.AvatarArt, int, string, string)`](LeagueArenaScreen.cs.md#symbol-81dd2d9b1aaf)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`labels.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: labels.AddChild(label);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(copy,size,color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(copy,size,color)`

**赋值（含属性/字段和局部值）：**

- `label.AnchorBottom` = `y`
- `label.AnchorLeft` = `label.AnchorRight=x`
- `label.AnchorRight` = `x`
- `label.AnchorTop` = `label.AnchorBottom=y`
- `label.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `label.HorizontalAlignment` = `HorizontalAlignment.Center`
- `label.OffsetBottom` = `height/2`
- `label.OffsetLeft` = `-width/2`
- `label.OffsetRight` = `width/2`
- `label.OffsetTop` = `-height/2`
- `label.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `label.VerticalAlignment` = `VerticalAlignment.Center`

<a id="symbol-f2bd917ac9a8"></a>

## `Pause(float) — async Task Pause(float time)`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Animate()`](LeagueArenaScreen.cs.md#symbol-920ca2d97f7a)

**调用：** `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.SceneTree.CreateTimer(double, bool, bool, bool)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`tree.ToSignal(tree.CreateTimer(time),SceneTreeTimer.SignalName.Timeout)`；返回值紧邻使用处：`AwaitExpressionSyntax: await tree.ToSignal(tree.CreateTimer(time),SceneTreeTimer.SignalName.Timeout)`
- `Godot.SceneTree.CreateTimer(double, bool, bool, bool)`；输入表达式：`tree.CreateTimer(time)`；返回值紧邻使用处：`ArgumentSyntax: tree.CreateTimer(time)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81dd2d9b1aaf"></a>

## `Side(bool, NationalSpire.AvatarArt, int, string, string) — void Side(bool left,AvatarArt art,int tier,string name,string detail)`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`](LeagueArenaScreen.cs.md#symbol-b602cebe9951)

**调用：** [`Caption(string, int, Godot.Color, float, float, float, float)`](LeagueArenaScreen.cs.md#symbol-7f5c9a8aac1e)；[`NationalSpire.CareerScreen.LeaguePortrait(NationalSpire.AvatarArt, int, int)`](LeagueArenaScreen.cs.md#symbol-fff1f7f80e4d)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `Caption(string, int, Godot.Color, float, float, float, float)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.LeaguePortrait(NationalSpire.AvatarArt, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Caption(string, int, Godot.Color, float, float, float, float)`；输入表达式：`Caption(detail,19,_gold,x,.58f,430,50)`；返回值紧邻使用处：`ExpressionStatementSyntax: Caption(detail,19,_gold,x,.58f,430,50);`
- `Caption(string, int, Godot.Color, float, float, float, float)`；输入表达式：`Caption(name,34,_ink,x,.50f,430,64)`；返回值紧邻使用处：`ExpressionStatementSyntax: Caption(name,34,_ink,x,.50f,430,64);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`labels.AddChild(portrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: labels.AddChild(portrait);`
- `NationalSpire.CareerScreen.LeaguePortrait(NationalSpire.AvatarArt, int, int)`；输入表达式：`LeaguePortrait(art,tier,78)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeaguePortrait(art,tier,78)`

**赋值（含属性/字段和局部值）：**

- `portrait.AnchorBottom` = `.33f`
- `portrait.AnchorLeft` = `portrait.AnchorRight=x`
- `portrait.AnchorRight` = `x`
- `portrait.AnchorTop` = `portrait.AnchorBottom=.33f`
- `portrait.OffsetBottom` = `39`
- `portrait.OffsetLeft` = `portrait.OffsetTop=-39`
- `portrait.OffsetRight` = `portrait.OffsetBottom=39`
- `portrait.OffsetTop` = `-39`

<a id="symbol-920ca2d97f7a"></a>

## `Animate() — async Task Animate()`

来源：源码第 160 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Caption(string, int, Godot.Color, float, float, float, float)`](LeagueArenaScreen.cs.md#symbol-7f5c9a8aac1e)；[`NationalSpire.CareerScreen.LeagueSound(string)`](LeagueScreen.cs.md#symbol-74fb1d846f7f)；[`Pause(float)`](LeagueArenaScreen.cs.md#symbol-f2bd917ac9a8)；`Godot.Callable.From<T0>(System.Action<T0>)`；`Godot.Color.Color(float, float, float, float)`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.MethodTweener.SetEase(Godot.Tween.EaseType)`；`Godot.MethodTweener.SetTrans(Godot.Tween.TransitionType)`；`Godot.Node.CreateTween()`；`Godot.Tween.SetParallel(bool)`；`Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`

**字段、属性、事件及方法组引用：** `Caption(string, int, Godot.Color, float, float, float, float)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.LeagueSound(string)`；`NationalSpire.LeagueGate.Door`；`NationalSpire.LeagueGate.Impact`；`Pause(float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Caption(string, int, Godot.Color, float, float, float, float)`；输入表达式：`Caption("",82,_ink,.5f,.5f,230,140)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Caption("",82,_ink,.5f,.5f,230,140)`
- `Godot.Callable.From<T0>(System.Action<T0>)`；输入表达式：`Callable.From<float>(v=>overlay.Door=v)`；返回值紧邻使用处：`ArgumentSyntax: Callable.From<float>(v=>overlay.Door=v)`
- `Godot.Callable.From<T0>(System.Action<T0>)`；输入表达式：`Callable.From<float>(v=>overlay.Impact=v)`；返回值紧邻使用处：`ArgumentSyntax: Callable.From<float>(v=>overlay.Impact=v)`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1,1,1,.25f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: number.Modulate=new Color(1,1,1,.25f)`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`tree.ToSignal(flash,Tween.SignalName.Finished)`；返回值紧邻使用处：`AwaitExpressionSyntax: await tree.ToSignal(flash,Tween.SignalName.Finished)`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`tree.ToSignal(gate,Tween.SignalName.Finished)`；返回值紧邻使用处：`AwaitExpressionSyntax: await tree.ToSignal(gate,Tween.SignalName.Finished)`
- `Godot.MethodTweener.SetEase(Godot.Tween.EaseType)`；输入表达式：`gate.TweenMethod(Callable.From<float>(v=>overlay.Door=v),0f,1f,.36).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.In)`；返回值紧邻使用处：`ExpressionStatementSyntax: gate.TweenMethod(Callable.From<float>(v=>overlay.Door=v),0f,1f,.36).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.In);`
- `Godot.MethodTweener.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`gate.TweenMethod(Callable.From<float>(v=>overlay.Door=v),0f,1f,.36).SetTrans(Tween.TransitionType.Cubic)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: gate.TweenMethod(Callable.From<float>(v=>overlay.Door=v),0f,1f,.36).SetTrans(Tween.TransitionType.Cubic).SetEase`
- `Godot.Node.CreateTween()`；输入表达式：`number.CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: number.CreateTween().TweenProperty`
- `Godot.Node.CreateTween()`；输入表达式：`overlay.CreateTween()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =overlay.CreateTween()`
- `Godot.Node.CreateTween()`；输入表达式：`overlay.CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: overlay.CreateTween().SetParallel`
- `Godot.Tween.SetParallel(bool)`；输入表达式：`overlay.CreateTween().SetParallel()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =overlay.CreateTween().SetParallel()`
- `Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；输入表达式：`flash.TweenMethod(Callable.From<float>(v=>overlay.Impact=v),1f,0f,.40)`；返回值紧邻使用处：`ExpressionStatementSyntax: flash.TweenMethod(Callable.From<float>(v=>overlay.Impact=v),1f,0f,.40);`
- `Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；输入表达式：`gate.TweenMethod(Callable.From<float>(v=>overlay.Door=v),0f,1f,.36)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: gate.TweenMethod(Callable.From<float>(v=>overlay.Door=v),0f,1f,.36).SetTrans`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`gate.TweenProperty(labels,"modulate:a",0,.20)`；返回值紧邻使用处：`ExpressionStatementSyntax: gate.TweenProperty(labels,"modulate:a",0,.20);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`number.CreateTween().TweenProperty(number,"modulate:a",1,.16)`；返回值紧邻使用处：`ExpressionStatementSyntax: number.CreateTween().TweenProperty(number,"modulate:a",1,.16);`
- `NationalSpire.CareerScreen.LeagueSound(string)`；输入表达式：`LeagueSound("event:/sfx/ui/pause_close")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueSound("event:/sfx/ui/pause_close");`
- `NationalSpire.CareerScreen.LeagueSound(string)`；输入表达式：`LeagueSound(value=="1"?"event:/sfx/ui/clicks/ui_click":"event:/sfx/ui/clicks/ui_hover")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueSound(value=="1"?"event:/sfx/ui/clicks/ui_click":"event:/sfx/ui/clicks/ui_hover");`
- `Pause(float)`；输入表达式：`Pause(1f)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Pause(1f)`

**赋值（含属性/字段和局部值）：**

- `number.Modulate` = `new Color(1,1,1,.25f)`
- `number.Name` = `"Countdown"`
- `number.Text` = `value`
- `overlay.Door` = `v`
- `overlay.Impact` = `1`
- `overlay.Impact` = `v`

<a id="symbol-72880a76b76f"></a>

## `NationalSpire.CareerScreen.FormalGate(NationalSpire.CareerData, NationalSpire.CareerMatch, string, System.Func<System.Threading.Tasks.Task>) — internal async Task FormalGate(CareerData d, CareerMatch match, string character, Func<Task> begin)`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.BeginRun(string, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>)`](Coop/CoopNativeRun.cs.md#symbol-ddd22369fd06)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.AvatarImages.CopyOpeningIcon(Godot.Texture2D?)`](AvatarImages.cs.md#symbol-a24fac77bc73)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.ArenaCharacterName(string)`](MatchArenaScreen.cs.md#symbol-8a35d94d8045)；[`NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`](LeagueArenaScreen.cs.md#symbol-b602cebe9951)

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarImages.CopyOpeningIcon(Godot.Texture2D?)`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerScreen.ArenaCharacterName(string)`；`NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarImages.CopyOpeningIcon(Godot.Texture2D?)`；输入表达式：`AvatarImages.CopyOpeningIcon(away.Texture)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AvatarImages.CopyOpeningIcon(away.Texture)`
- `NationalSpire.AvatarImages.CopyOpeningIcon(Godot.Texture2D?)`；输入表达式：`AvatarImages.CopyOpeningIcon(home.Texture)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AvatarImages.CopyOpeningIcon(home.Texture)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(d, "player")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerAvatars.ForPerson(d, "player")`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(d, match.OpponentId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerAvatars.ForPerson(d, match.OpponentId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, match.OpponentId)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(d, match.OpponentId)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(d)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, match.OpponentId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d, match.OpponentId)?.Character`
- `NationalSpire.CareerScreen.ArenaCharacterName(string)`；输入表达式：`ArenaCharacterName(CareerEngine.Person(d, match.OpponentId)?.Character ?? "")`；返回值紧邻使用处：`ArgumentSyntax: ArenaCharacterName(CareerEngine.Person(d, match.OpponentId)?.Character ?? "")`
- `NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`；输入表达式：`OpeningGate(match.Event, home, 0, CareerEngine.Name(d), character, away, 0,              CareerEngine.DisplayName(d, match.OpponentId),              ArenaCharacterName(CareerEngine.Person(d, match.OpponentId)?.Character ?? ""), "正式比赛", begin)`；返回值紧邻使用处：`AwaitExpressionSyntax: await OpeningGate(match.Event, home, 0, CareerEngine.Name(d), character, away, 0,              CareerEngine.DisplayName(d, match.OpponentId),              ArenaCharacterName(CareerEngine.Person(d, match.OpponentId)?.Character ?? ""), "正式比赛", begin)`

**赋值（含属性/字段和局部值）：**

- `away` = `away with { Texture = awayIcon }`
- `home` = `home with { Texture = homeIcon }`
- `Texture` = `awayIcon`
- `Texture` = `homeIcon`
