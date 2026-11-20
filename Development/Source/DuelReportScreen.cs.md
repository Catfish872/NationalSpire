# DuelReportScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D5E11CECCBEA95115ADFF4729A3B190FB627A7B7DB02B77008051A709C2938E4`。来源：[源码](../../DuelReportScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-9fcea98c8fe1"></a>

## `NationalSpire.CareerScreen.ReportPanel(string, string, int) — private static PanelContainer ReportPanel(string fill, string edge, int padding = 14)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DuelReportView(Godot.VBoxContainer, NationalSpire.DuelReport, bool)`](DuelReportScreen.cs.md#symbol-4edd420a2689)；[`NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`](LeagueArenaScreen.cs.md#symbol-53c6da8a2b7e)；[`NationalSpire.CareerScreen.ReportCard(NationalSpire.DuelCardFace, out Godot.VBoxContainer)`](DuelReportScreen.cs.md#symbol-ca484e5b67df)；[`NationalSpire.CareerScreen.RoundTable(Godot.MarginContainer, Godot.VBoxContainer, NationalSpire.DuelReport)`](DuelReportScreen.cs.md#symbol-468db1f7ab7f)；[`Select(int)`](DuelReportScreen.cs.md#symbol-0b9bbeff8923)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.PanelContainer.PanelContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box(fill,edge,7,padding))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box(fill,edge,7,padding));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(fill,edge,7,padding)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(fill,edge,7,padding)`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-929c22d0a91a"></a>

## `NationalSpire.CareerScreen.ReportCell(string, int, Godot.Color, bool) — private static Label ReportCell(string value, int width, Color ink, bool first = false)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Row(Godot.VBoxContainer, string[], Godot.Color, bool)`](DuelReportScreen.cs.md#symbol-616f88fc5e8d)；[`Select(int)`](DuelReportScreen.cs.md#symbol-0b9bbeff8923)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,26)`；返回值紧邻使用处：`AssignmentExpressionSyntax: cell.CustomMinimumSize = new(width,26)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(value,16,ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(value,16,ink)`

**赋值（含属性/字段和局部值）：**

- `cell.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `cell.CustomMinimumSize` = `new(width,26)`
- `cell.HorizontalAlignment` = `first ? HorizontalAlignment.Left : HorizontalAlignment.Center`
- `cell.SizeFlagsHorizontal` = `first ? SizeFlags.ExpandFill : SizeFlags.ShrinkCenter`
- `cell.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `cell.TooltipText` = `value`

<a id="symbol-4edd420a2689"></a>

## `NationalSpire.CareerScreen.DuelReportView(Godot.VBoxContainer, NationalSpire.DuelReport, bool) — private void DuelReportView(VBoxContainer parent, DuelReport report, bool inDialog)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`](LeagueArenaScreen.cs.md#symbol-53c6da8a2b7e)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShowDuelReport(NationalSpire.DuelReport)`](LeagueArenaScreen.cs.md#symbol-15a0698166cc)

**调用：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.ReportPanel(string, string, int)`](DuelReportScreen.cs.md#symbol-9fcea98c8fe1)；[`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`](CareerDashboard.cs.md#symbol-5eacabf68317)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`Select(int)`](DuelReportScreen.cs.md#symbol-0b9bbeff8923)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ProgressBar.ProgressBar()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CareerAvatar.CareerAvatar()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `AlignHeader()`；`NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.ReportPanel(string, string, int)`；`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.DuelParticipant.Character`；`NationalSpire.DuelParticipant.EndHp`；`NationalSpire.DuelParticipant.EndMax`；`NationalSpire.DuelParticipant.Name`；`NationalSpire.DuelParticipant.OpenHp`；`NationalSpire.DuelParticipant.OpenMax`；`NationalSpire.DuelParticipant.Opponent`；`NationalSpire.DuelParticipant.PersonId`；`NationalSpire.DuelReport.Note`；`NationalSpire.DuelReport.OpponentOpens`；`NationalSpire.DuelReport.People`；`NationalSpire.DuelReport.PlayersWon`；`Select(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`roster.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: roster.AddThemeConstantOverride("separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`view.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.AddThemeConstantOverride("separation",12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`meter.AddThemeStyleboxOverride("background",CareerVisuals.Box("0e1923","0e1923",2,0))`；返回值紧邻使用处：`ExpressionStatementSyntax: meter.AddThemeStyleboxOverride("background",CareerVisuals.Box("0e1923","0e1923",2,0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`meter.AddThemeStyleboxOverride("fill",CareerVisuals.Box(opponent?"b59a66":"65b8b4",opponent?"b59a66":"65b8b4",2,0))`；返回值紧邻使用处：`ExpressionStatementSyntax: meter.AddThemeStyleboxOverride("fill",CareerVisuals.Box(opponent?"b59a66":"65b8b4",opponent?"b59a66":"65b8b4",2,0));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(Text((opponent?"对手":"我方")+(opponent==report.OpponentOpens?"  ·  先手":"  ·  后手"),16,color))`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(Text((opponent?"对手":"我方")+(opponent==report.OpponentOpens?"  ·  先手":"  ·  后手"),16,color));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(won)`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(won);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`id.AddChild(Text(p.Character,15,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: id.AddChild(Text(p.Character,15,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`id.AddChild(Text(p.Name,20,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: id.AddChild(Text(p.Name,20,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`life.AddChild(hp)`；返回值紧邻使用处：`ExpressionStatementSyntax: life.AddChild(hp);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`life.AddChild(meter)`；返回值紧邻使用处：`ExpressionStatementSyntax: life.AddChild(meter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`members.AddChild(roster)`；返回值紧邻使用处：`ExpressionStatementSyntax: members.AddChild(roster);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(view)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(view);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`roster.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: roster.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(id);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(life)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(life);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new CareerAvatar{Art=art,CustomMinimumSize=new(48,48),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore})`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new CareerAvatar{Art=art,CustomMinimumSize=new(48,48),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`view.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`view.AddChild(members)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.AddChild(members);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`view.AddChild(roster)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.AddChild(roster);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`view.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`view.AddChild(Text(report.Note,17,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: view.AddChild(Text(report.Note,17,_gold));`
- `Godot.ProgressBar.ProgressBar()`；输入表达式：`new ProgressBar{CustomMinimumSize=new(94,5),MaxValue=Math.Max(1,p.EndMax),Value=p.EndHp,ShowPercentage=false}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ProgressBar{CustomMinimumSize=new(94,5),MaxValue=Math.Max(1,p.EndMax),Value=p.EndHp,ShowPercentage=false}`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize=new(0,190),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ScrollContainer { CustomMinimumSize=new(0,190),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled }`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer{CustomMinimumSize=new(inDialog?800:0,inDialog?285:380),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ScrollContainer{CustomMinimumSize=new(inDialog?800:0,inDialog?285:380),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name="DuelReportView",SizeFlagsHorizontal=SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name="DuelReportView",SizeFlagsHorizontal=SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{SizeFlagsVertical=SizeFlags.ShrinkCenter}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{SizeFlagsVertical=SizeFlags.ShrinkCenter}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,190)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,190)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(48,48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(48,48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(94,5)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(94,5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(inDialog?800:0,inDialog?285:380)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(inDialog?800:0,inDialog?285:380)`
- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(p.Character,0,false)`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.PersonId.Length>0?CareerAvatars.ForPerson(ViewData,p.PersonId):AvatarAssets.Load(p.Character,0,false)`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar{Art=art,CustomMinimumSize=new(48,48),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`ArgumentSyntax: new CareerAvatar{Art=art,CustomMinimumSize=new(48,48),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore}`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(ViewData,p.PersonId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.PersonId.Length>0?CareerAvatars.ForPerson(ViewData,p.PersonId):AvatarAssets.Load(p.Character,0,false)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.ReportPanel(string, string, int)`；输入表达式：`ReportPanel(opponent?"28292b":"152d36",opponent?"61503a":"345760")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReportPanel(opponent?"28292b":"152d36",opponent?"61503a":"345760")`
- `NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；输入表达式：`TabStrip(view,12)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =TabStrip(view,12)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("获胜",16,_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text("获胜",16,_gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((opponent?"对手":"我方")+(opponent==report.OpponentOpens?"  ·  先手":"  ·  后手"),16,color)`；返回值紧邻使用处：`ArgumentSyntax: Text((opponent?"对手":"我方")+(opponent==report.OpponentOpens?"  ·  先手":"  ·  后手"),16,color)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{p.OpenHp}/{p.OpenMax} → {p.EndHp}/{p.EndMax}",16,color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text($"{p.OpenHp}/{p.OpenMax} → {p.EndHp}/{p.EndMax}",16,color)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(p.Character,15,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(p.Character,15,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(p.Name,20,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(p.Name,20,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(report.Note,17,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(report.Note,17,_gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0e1923","0e1923",2,0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("0e1923","0e1923",2,0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(opponent?"b59a66":"65b8b4",opponent?"b59a66":"65b8b4",2,0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(opponent?"b59a66":"65b8b4",opponent?"b59a66":"65b8b4",2,0)`
- `Select(int)`；输入表达式：`Select(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: Select(0);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`report.People.GroupBy(p=>p.Opponent).Any(side=>side.Count()>2)`；返回值紧邻使用处：`BinaryExpressionSyntax: inDialog && report.People.GroupBy(p=>p.Opponent).Any(side=>side.Count()>2)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`side.Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: side.Count()>2`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`report.People.GroupBy(p=>p.Opponent)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: report.People.GroupBy(p=>p.Opponent).Any`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`report.People.Where(p=>p.Opponent==opponent)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var p in report.People.Where(p=>p.Opponent==opponent)){                  var row = new HBoxContainer();row.AddThemeConstantOverride("separation",12);box.AddChild(row);                  var art=p.PersonId.Length>0?CareerAvatars.ForPerson(ViewData,p.PersonId):AvatarAssets.Load(p.Character,0,false);                  row.AddChild(new CareerAvatar{Art=art,CustomMinimumSize=new(48,48),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore});                  var id=new VBoxContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill};row.AddChild(id);                  id.AddChild(Text(p.Name,20,_ink));id.AddChild(Text(p.Character,15,_muted));                  var life=new VBoxContainer{SizeFlagsVertical=SizeFlags.ShrinkCenter};row.AddChild(life);                  var hp=Text($"{p.OpenHp}/{p.OpenMax} → {p.EndHp}/{p.EndMax}",16,color);hp.AutowrapMode=TextServer.AutowrapMode.Off;hp.TooltipText=$"开局 {p.OpenHp}/{p.OpenMax}  ·  终局 {p.EndHp}/{p.EndMax}";life.AddChild(hp);                  var meter=new ProgressBar{CustomMinimumSize=new(94,5),MaxValue=Math.Max(1,p.EndMax),Value=p.EndHp,ShowPercentage=false};                  meter.AddThemeStyleboxOverride("background",CareerVisuals.Box("0e1923","0e1923",2,0));                  meter.AddThemeStyleboxOverride("fill",CareerVisuals.Box(opponent?"b59a66":"65b8b4",opponent?"b59a66":"65b8b4",2,0));life.AddChild(meter);              }`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,p.EndMax)`；返回值紧邻使用处：`AssignmentExpressionSyntax: MaxValue=Math.Max(1,p.EndMax)`

**赋值（含属性/字段和局部值）：**

- `Art` = `art`
- `body.Resized` += `AlignHeader`
- `CustomMinimumSize` = `new(0,190)`
- `CustomMinimumSize` = `new(48,48)`
- `CustomMinimumSize` = `new(94,5)`
- `CustomMinimumSize` = `new(inDialog?800:0,inDialog?285:380)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `hp.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `hp.TooltipText` = `$"开局 {p.OpenHp}/{p.OpenMax}  ·  终局 {p.EndHp}/{p.EndMax}"`
- `MaxValue` = `Math.Max(1,p.EndMax)`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"DuelReportView"`
- `scroll.Resized` += `AlignHeader`
- `ShowPercentage` = `false`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Value` = `p.EndHp`
- `won.HorizontalAlignment` = `HorizontalAlignment.Right`

<a id="symbol-e2199555b606"></a>

## `AlignHeader() — void AlignHeader()`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`System.Math.Max(int, int)`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`header.AddThemeConstantOverride("margin_right",Math.Max(0,(int)Math.Round(scroll.Size.X-body.Size.X)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => header.AddThemeConstantOverride("margin_right",Math.Max(0,(int)Math.Round(scroll.Size.X-body.Size.X)))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,(int)Math.Round(scroll.Size.X-body.Size.X))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,(int)Math.Round(scroll.Size.X-body.Size.X))`
- `System.Math.Round(double)`；输入表达式：`Math.Round(scroll.Size.X-body.Size.X)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(scroll.Size.X-body.Size.X)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0b9bbeff8923"></a>

## `Select(int) — void Select(int page)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DuelReportView(Godot.VBoxContainer, NationalSpire.DuelReport, bool)`](DuelReportScreen.cs.md#symbol-4edd420a2689)；[`Select(int)`](DuelReportScreen.cs.md#symbol-0b9bbeff8923)

**调用：** [`Faces(string, System.Collections.Generic.IEnumerable<NationalSpire.DuelCardFace>, string)`](DuelReportScreen.cs.md#symbol-595f1e2e02d6)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.ReportCell(string, int, Godot.Color, bool)`](DuelReportScreen.cs.md#symbol-929c22d0a91a)；[`NationalSpire.CareerScreen.ReportPanel(string, string, int)`](DuelReportScreen.cs.md#symbol-9fcea98c8fe1)；[`NationalSpire.CareerScreen.RoundTable(Godot.MarginContainer, Godot.VBoxContainer, NationalSpire.DuelReport)`](DuelReportScreen.cs.md#symbol-468db1f7ab7f)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`](CareerDashboard.cs.md#symbol-fd46a77c3667)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`Select(int)`](DuelReportScreen.cs.md#symbol-0b9bbeff8923)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildCount(bool)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.DuelCardStep.DuelCardStep(int, string, string, bool)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.Enumerable.Range(int, int)`

**字段、属性、事件及方法组引用：** `Faces(string, System.Collections.Generic.IEnumerable<NationalSpire.DuelCardFace>, string)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.ReportCell(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.ReportPanel(string, string, int)`；`NationalSpire.CareerScreen.RoundTable(Godot.MarginContainer, Godot.VBoxContainer, NationalSpire.DuelReport)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.DuelCardStep.Actor`；`NationalSpire.DuelCardStep.Card`；`NationalSpire.DuelCardStep.Generated`；`NationalSpire.DuelCardStep.Target`；`NationalSpire.DuelParticipant.Deck`；`NationalSpire.DuelParticipant.Name`；`NationalSpire.DuelParticipant.Opponent`；`NationalSpire.DuelReplay.Decks`；`NationalSpire.DuelReplay.Faces`；`NationalSpire.DuelReplay.Rounds`；`NationalSpire.DuelReplayStep.Actor`；`NationalSpire.DuelReplayStep.Card`；`NationalSpire.DuelReplayStep.Face`；`NationalSpire.DuelReplayStep.Generated`；`NationalSpire.DuelReplayStep.Target`；`NationalSpire.DuelReport.People`；`NationalSpire.DuelReport.PlayedFaces`；`NationalSpire.DuelReport.Replay`；`NationalSpire.DuelReport.Rounds`；`NationalSpire.DuelRound.Number`；`NationalSpire.DuelRound.Sequence`；`NationalSpire.DuelSequenceRun.Cards`；`NationalSpire.DuelSequenceRun.Repeats`；`Select(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Faces(string, System.Collections.Generic.IEnumerable<NationalSpire.DuelCardFace>, string)`；输入表达式：`Faces("关键回合另见牌面",report.PlayedFaces,"")`；返回值紧邻使用处：`ExpressionStatementSyntax: Faces("关键回合另见牌面",report.PlayedFaces,"");`
- `Faces(string, System.Collections.Generic.IEnumerable<NationalSpire.DuelCardFace>, string)`；输入表达式：`Faces(p.Name+"的部分牌面",p.Deck,"")`；返回值紧邻使用处：`ExpressionStatementSyntax: Faces(p.Name+"的部分牌面",p.Deck,"");`
- `Faces(string, System.Collections.Generic.IEnumerable<NationalSpire.DuelCardFace>, string)`；输入表达式：`Faces(report.People[i].Name+"的起始牌组",deck.Select(id=>replay.Faces[id]),"张")`；返回值紧邻使用处：`ExpressionStatementSyntax: Faces(report.People[i].Name+"的起始牌组",deck.Select(id=>replay.Faces[id]),"张");`
- `Faces(string, System.Collections.Generic.IEnumerable<NationalSpire.DuelCardFace>, string)`；输入表达式：`Faces(report.People[i].Name+"在战中另行打出的牌面",played[i].Where(id=>!inDeck.Contains(id)).Select(id=>replay.Faces[id]),"次")`；返回值紧邻使用处：`ExpressionStatementSyntax: Faces(report.People[i].Name+"在战中另行打出的牌面",played[i].Where(id=>!inDeck.Contains(id)).Select(id=>replay.Faces[id]),"次");`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`flow.AddThemeConstantOverride("h_separation",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: flow.AddThemeConstantOverride("h_separation",6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`flow.AddThemeConstantOverride("v_separation",7)`；返回值紧邻使用处：`ExpressionStatementSyntax: flow.AddThemeConstantOverride("v_separation",7);`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: flow=new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("历史战报仅保存了部分牌面。",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("历史战报仅保存了部分牌面。",16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("历史战报仅保存了关键回合的牌序。",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("历史战报仅保存了关键回合的牌序。",16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(flow)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(flow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("本回合未出牌",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("本回合未出牌",16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"第 {round.Number} 回合  ·  完整出牌顺序",18,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"第 {round.Number} 回合  ·  完整出牌顺序",18,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(p.Name,16,p.Opponent?_gold:CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(p.Name,16,p.Opponent?_gold:CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`chip.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: chip.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`flow.AddChild(chip)`；返回值紧邻使用处：`ExpressionStatementSyntax: flow.AddChild(chip);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`flow.AddChild(ReportCell("›",14,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: flow.AddChild(ReportCell("›",14,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabRow.AddChild(UnderlineTab(tabs[i],()=>Select(dest),i==page,130,18))`；返回值紧邻使用处：`ExpressionStatementSyntax: tabRow.AddChild(UnderlineTab(tabs[i],()=>Select(dest),i==page,130,18));`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`flow!.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: flow!.GetChildCount()>0`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(800,page==2?342:285)`；返回值紧邻使用处：`AssignmentExpressionSyntax: scroll.CustomMinimumSize=new(800,page==2?342:285)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inner(panel)`
- `NationalSpire.CareerScreen.ReportCell(string, int, Godot.Color, bool)`；输入表达式：`ReportCell("›",14,_muted)`；返回值紧邻使用处：`ArgumentSyntax: ReportCell("›",14,_muted)`
- `NationalSpire.CareerScreen.ReportPanel(string, string, int)`；输入表达式：`ReportPanel("142530","304653")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ReportPanel("142530","304653")`
- `NationalSpire.CareerScreen.ReportPanel(string, string, int)`；输入表达式：`ReportPanel("1d3340","3b5260",7)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ReportPanel("1d3340","3b5260",7)`
- `NationalSpire.CareerScreen.RoundTable(Godot.MarginContainer, Godot.VBoxContainer, NationalSpire.DuelReport)`；输入表达式：`RoundTable(header,body,report)`；返回值紧邻使用处：`ExpressionStatementSyntax: RoundTable(header,body,report);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("本回合未出牌",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("本回合未出牌",16,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("历史战报仅保存了部分牌面。",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("历史战报仅保存了部分牌面。",16,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("历史战报仅保存了关键回合的牌序。",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("历史战报仅保存了关键回合的牌序。",16,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第 {round.Number} 回合  ·  完整出牌顺序",18,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text($"第 {round.Number} 回合  ·  完整出牌顺序",18,_gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(action.Card+(action.Generated?"  ✧":""),17,_ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(action.Card+(action.Generated?"  ✧":""),17,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(p.Name,16,p.Opponent?_gold:CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(p.Name,16,p.Opponent?_gold:CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；输入表达式：`UnderlineTab(tabs[i],()=>Select(dest),i==page,130,18)`；返回值紧邻使用处：`ArgumentSyntax: UnderlineTab(tabs[i],()=>Select(dest),i==page,130,18)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(body);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(header);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(tabRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(tabRow);`
- `NationalSpire.DuelCardStep.DuelCardStep(int, string, string, bool)`；输入表达式：`new DuelCardStep(s.Actor,s.Card,s.Target,s.Generated)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s=>new DuelCardStep(s.Actor,s.Card,s.Target,s.Generated)`
- `Select(int)`；输入表达式：`Select(dest)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Select(dest)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" · ",new[]{action.Generated?"战中获得":"",action.Target.Length>0?"目标 "+action.Target:""}.Where(t=>t.Length>0))`；返回值紧邻使用处：`AssignmentExpressionSyntax: label.TooltipText=string.Join(" · ",new[]{action.Generated?"战中获得":"",action.Target.Length>0?"目标 "+action.Target:""}.Where(t=>t.Length>0))`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`inDeck.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !inDeck.Contains(id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`deck.Select(id=>replay.Faces[id])`；返回值紧邻使用处：`ArgumentSyntax: deck.Select(id=>replay.Faces[id])`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`played[i].Where(id=>!inDeck.Contains(id)).Select(id=>replay.Faces[id])`；返回值紧邻使用处：`ArgumentSyntax: played[i].Where(id=>!inDeck.Contains(id)).Select(id=>replay.Faces[id])`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`replay.Rounds[round.Number].Select(s=>new DuelCardStep(s.Actor,s.Card,s.Target,s.Generated))`；返回值紧邻使用处：`ConditionalExpressionSyntax: report.Replay is {} replay                          ? replay.Rounds[round.Number].Select(s=>new DuelCardStep(s.Actor,s.Card,s.Target,s.Generated))                          : round.Sequence.SelectMany(run=>Enumerable.Range(0,run.Repeats).SelectMany(_=>run.Cards))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`Enumerable.Range(0,run.Repeats).SelectMany(_=>run.Cards)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: run=>Enumerable.Range(0,run.Repeats).SelectMany(_=>run.Cards)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`replay.Rounds.Values.SelectMany(steps=>steps)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: replay.Rounds.Values.SelectMany(steps=>steps).ToLookup`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`round.Sequence.SelectMany(run=>Enumerable.Range(0,run.Repeats).SelectMany(_=>run.Cards))`；返回值紧邻使用处：`ConditionalExpressionSyntax: report.Replay is {} replay                          ? replay.Rounds[round.Number].Select(s=>new DuelCardStep(s.Actor,s.Card,s.Target,s.Generated))                          : round.Sequence.SelectMany(run=>Enumerable.Range(0,run.Repeats).SelectMany(_=>run.Cards))`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`deck.ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =deck.ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`replay.Rounds.Values.SelectMany(steps=>steps).ToLookup(s=>s.Actor,s=>s.Face)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =replay.Rounds.Values.SelectMany(steps=>steps).ToLookup(s=>s.Actor,s=>s.Face)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[]{action.Generated?"战中获得":"",action.Target.Length>0?"目标 "+action.Target:""}.Where(t=>t.Length>0)`；返回值紧邻使用处：`ArgumentSyntax: new[]{action.Generated?"战中获得":"",action.Target.Length>0?"目标 "+action.Target:""}.Where(t=>t.Length>0)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`played[i].Where(id=>!inDeck.Contains(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: played[i].Where(id=>!inDeck.Contains(id)).Select`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0,run.Repeats)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,run.Repeats).SelectMany`

**赋值（含属性/字段和局部值）：**

- `chip.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `flow` = `new HFlowContainer()`
- `header.Visible` = `page==0`
- `label.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `label.TooltipText` = `string.Join(" · ",new[]{action.Generated?"战中获得":"",action.Target.Length>0?"目标 "+action.Target:""}.Where(t=>t.Length>0))`
- `last` = `action.Actor`
- `scroll.CustomMinimumSize` = `new(800,page==2?342:285)`
- `scroll.ScrollVertical` = `0`

<a id="symbol-595f1e2e02d6"></a>

## `Faces(string, System.Collections.Generic.IEnumerable<NationalSpire.DuelCardFace>, string) — void Faces(string title,IEnumerable<DuelCardFace> faces,string unit)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Select(int)`](DuelReportScreen.cs.md#symbol-0b9bbeff8923)

**调用：** [`NationalSpire.CareerScreen.ReportCard(NationalSpire.DuelCardFace, out Godot.VBoxContainer)`](DuelReportScreen.cs.md#symbol-ca484e5b67df)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ReportCard(NationalSpire.DuelCardFace, out Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation",10);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer{Columns=Math.Max(1,(int)(body.Size.X/235)),SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new GridContainer{Columns=Math.Max(1,(int)(body.Size.X/235)),SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(title,18,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(title,18,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(tile)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(tile);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stack.AddChild(count)`；返回值紧邻使用处：`ExpressionStatementSyntax: stack.AddChild(count);`
- `NationalSpire.CareerScreen.ReportCard(NationalSpire.DuelCardFace, out Godot.VBoxContainer)`；输入表达式：`ReportCard(item.Key,out var stack)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ReportCard(item.Key,out var stack)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title,18,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(title,18,_gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(unit=="张"?$"牌组中 {item.Count()} 张":$"打出 {item.Count()} 次",16,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(unit=="张"?$"牌组中 {item.Count()} 张":$"打出 {item.Count()} 次",16,_muted)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`item.Count()`；返回值紧邻使用处：`InterpolationSyntax: {item.Count()}`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`faces.GroupBy(f=>f)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: faces.GroupBy(f=>f).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`faces.GroupBy(f=>f).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =faces.GroupBy(f=>f).ToList()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,(int)(body.Size.X/235))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Columns=Math.Max(1,(int)(body.Size.X/235))`

**赋值（含属性/字段和局部值）：**

- `Columns` = `Math.Max(1,(int)(body.Size.X/235))`
- `count.HorizontalAlignment` = `HorizontalAlignment.Center`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-ca484e5b67df"></a>

## `NationalSpire.CareerScreen.ReportCard(NationalSpire.DuelCardFace, out Godot.VBoxContainer) — private Control ReportCard(DuelCardFace face,out VBoxContainer stack)`

来源：源码第 129 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Faces(string, System.Collections.Generic.IEnumerable<NationalSpire.DuelCardFace>, string)`](DuelReportScreen.cs.md#symbol-595f1e2e02d6)

**调用：** [`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`](LeagueScreen.cs.md#symbol-3fa69e107266)；[`NationalSpire.CareerScreen.ReportPanel(string, string, int)`](DuelReportScreen.cs.md#symbol-9fcea98c8fe1)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；[`NationalSpire.LeagueCards.CollectionTier(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueCards.cs.md#symbol-18182181d83f)；[`NationalSpire.LeagueCards.Improve(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueCards.cs.md#symbol-f7cfc6d3c1a6)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Models.CardModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard)`；`MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；`MegaCrit.Sts2.Core.Models.ModelId.ModelId(string, string)`；`MegaCrit.Sts2.Core.Saves.Runs.SerializableCard.SerializableCard()`；`NationalSpire.LeagueCards.Entry.Entry(MegaCrit.Sts2.Core.Models.CardModel, string, int)`；`string.StartsWith(string, System.StringComparison)`；`System.Math.Max(int, int)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`；`NationalSpire.CareerScreen.ReportPanel(string, string, int)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.DuelCardFace.Id`；`NationalSpire.DuelCardFace.Level`；`NationalSpire.DuelCardFace.State`；`NationalSpire.DuelCardFace.Text`；`NationalSpire.GameText.Plain(string)`；`NationalSpire.LeagueCards.CollectionTier(MegaCrit.Sts2.Core.Models.CardModel)`；`NationalSpire.LeagueCards.Improve(MegaCrit.Sts2.Core.Models.CardModel)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`archive.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: archive.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(Text(face.Text.Length>0?face.Text:face.Id,18,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(Text(face.Text.Length>0?face.Text:face.Id,18,_ink));`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`stack.GetChild<LeagueCardFace>(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: stack.GetChild<LeagueCardFace>(0).CustomMinimumSize`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: stack=new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(205,282)`；返回值紧邻使用处：`AssignmentExpressionSyntax: stack.GetChild<LeagueCardFace>(0).CustomMinimumSize=new(205,282)`
- `MegaCrit.Sts2.Core.Models.CardModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard)`；输入表达式：`MegaCrit.Sts2.Core.Models.CardModel.FromSerializable(snapshot)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =MegaCrit.Sts2.Core.Models.CardModel.FromSerializable(snapshot)`
- `MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<MegaCrit.Sts2.Core.Models.CardModel>(new("CARD",face.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<MegaCrit.Sts2.Core.Models.CardModel>(new("CARD",face.Id))`
- `MegaCrit.Sts2.Core.Models.ModelId.ModelId(string, string)`；输入表达式：`new("CARD",face.Id)`；返回值紧邻使用处：`ArgumentSyntax: new("CARD",face.Id)`
- `MegaCrit.Sts2.Core.Saves.Runs.SerializableCard.SerializableCard()`；输入表达式：`new MegaCrit.Sts2.Core.Saves.Runs.SerializableCard{Id=model.Id,CurrentUpgradeLevel=face.Level??0}`；返回值紧邻使用处：`ConditionalExpressionSyntax: face.State is {} json                      ? System.Text.Json.JsonSerializer.Deserialize<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard>(json)                      : new MegaCrit.Sts2.Core.Saves.Runs.SerializableCard{Id=model.Id,CurrentUpgradeLevel=face.Level??0}`
- `NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`；输入表达式：`LeagueTile(entry,out stack)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueTile(entry,out stack)`
- `NationalSpire.CareerScreen.ReportPanel(string, string, int)`；输入表达式：`ReportPanel("142530","304653")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ReportPanel("142530","304653")`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(face.Text.Length>0?face.Text:face.Id,18,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(face.Text.Length>0?face.Text:face.Id,18,_ink)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(saved.Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: GameText.Plain(saved.Title)+"+"`
- `NationalSpire.LeagueCards.CollectionTier(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`LeagueCards.CollectionTier(model)`；返回值紧邻使用处：`ArgumentSyntax: LeagueCards.CollectionTier(model)`
- `NationalSpire.LeagueCards.Entry.Entry(MegaCrit.Sts2.Core.Models.CardModel, string, int)`；输入表达式：`new LeagueCards.Entry(saved,"",Math.Max(0,LeagueCards.CollectionTier(model)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueCards.Entry(saved,"",Math.Max(0,LeagueCards.CollectionTier(model)))`
- `NationalSpire.LeagueCards.Improve(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`LeagueCards.Improve(saved)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueCards.Improve(saved);`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`face.Text.StartsWith(GameText.Plain(saved.Title)+"+",StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: face.Level==null && saved.IsUpgradable && face.Text.StartsWith(GameText.Plain(saved.Title)+"+",StringComparison.Ordinal)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,LeagueCards.CollectionTier(model))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,LeagueCards.CollectionTier(model))`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Deserialize<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard>(json)`；返回值紧邻使用处：`ConditionalExpressionSyntax: face.State is {} json                      ? System.Text.Json.JsonSerializer.Deserialize<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard>(json)                      : new MegaCrit.Sts2.Core.Saves.Runs.SerializableCard{Id=model.Id,CurrentUpgradeLevel=face.Level??0}`

**赋值（含属性/字段和局部值）：**

- `CurrentUpgradeLevel` = `face.Level??0`
- `Id` = `model.Id`
- `stack.GetChild<LeagueCardFace>(0).CustomMinimumSize` = `new(205,282)`
- `stack` = `new VBoxContainer()`

<a id="symbol-468db1f7ab7f"></a>

## `NationalSpire.CareerScreen.RoundTable(Godot.MarginContainer, Godot.VBoxContainer, NationalSpire.DuelReport) — private void RoundTable(MarginContainer header,VBoxContainer body,DuelReport report)`

来源：源码第 151 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Select(int)`](DuelReportScreen.cs.md#symbol-0b9bbeff8923)

**调用：** [`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.ReportPanel(string, string, int)`](DuelReportScreen.cs.md#symbol-9fcea98c8fe1)；[`Row(Godot.VBoxContainer, string[], Godot.Color, bool)`](DuelReportScreen.cs.md#symbol-616f88fc5e8d)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`int.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.ReportPanel(string, string, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.DuelParticipant.Name`；`NationalSpire.DuelParticipant.Opponent`；`NationalSpire.DuelReport.People`；`NationalSpire.DuelReport.Rounds`；`NationalSpire.DuelRound.Number`；`NationalSpire.DuelRound.Totals`；`NationalSpire.DuelTurnTotals.Attack`；`NationalSpire.DuelTurnTotals.Block`；`NationalSpire.DuelTurnTotals.Cards`；`NationalSpire.DuelTurnTotals.Damage`；`NationalSpire.DuelTurnTotals.Doom`；`NationalSpire.DuelTurnTotals.DoomIntent`；`NationalSpire.DuelTurnTotals.Draw`；`NationalSpire.DuelTurnTotals.Energy`；`Row(Godot.VBoxContainer, string[], Godot.Color, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(heading);`
- `int.ToString()`；输入表达式：`r.Number.ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: i==0?r.Number.ToString():""`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(heading)`；返回值紧邻使用处：`ArgumentSyntax: Inner(heading)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inner(panel)`
- `NationalSpire.CareerScreen.ReportPanel(string, string, int)`；输入表达式：`ReportPanel("101e29","283c49",8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ReportPanel("101e29","283c49",8)`
- `NationalSpire.CareerScreen.ReportPanel(string, string, int)`；输入表达式：`ReportPanel("14232f","2c414e",8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ReportPanel("14232f","2c414e",8)`
- `Row(Godot.VBoxContainer, string[], Godot.Color, bool)`；输入表达式：`Row(box,[i==0?r.Number.ToString():"",p.Name,$"{s.Cards}",$"{s.Attack}",$"{s.Block}",$"{s.Damage}",$"{s.Draw}",$"{s.Energy}",$"{s.DoomIntent}",$"{s.Doom}"],p.Opponent?_gold:CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Row(box,[i==0?r.Number.ToString():"",p.Name,$"{s.Cards}",$"{s.Attack}",$"{s.Block}",$"{s.Damage}",$"{s.Draw}",$"{s.Energy}",$"{s.DoomIntent}",$"{s.Doom}"],p.Opponent?_gold:CareerVisuals.Teal);`
- `Row(Godot.VBoxContainer, string[], Godot.Color, bool)`；输入表达式：`Row(Inner(heading),["回合","选手","出牌","攻击意图","格挡抵消","实际伤害","抽牌","耗能","灾厄意图","施加层数"],_muted,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Row(Inner(heading),["回合","选手","出牌","攻击意图","格挡抵消","实际伤害","抽牌","耗能","灾厄意图","施加层数"],_muted,true);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`r.Totals.Any(s=>s.DoomIntent!=0||s.Doom!=0)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r=>r.Totals.Any(s=>s.DoomIntent!=0||s.Doom!=0)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`report.Rounds.Any(r=>r.Totals.Any(s=>s.DoomIntent!=0||s.Doom!=0))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =report.Rounds.Any(r=>r.Totals.Any(s=>s.DoomIntent!=0||s.Doom!=0))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-616f88fc5e8d"></a>

## `Row(Godot.VBoxContainer, string[], Godot.Color, bool) — void Row(VBoxContainer box,string[] values,Color ink,bool headings=false)`

来源：源码第 157 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RoundTable(Godot.MarginContainer, Godot.VBoxContainer, NationalSpire.DuelReport)`](DuelReportScreen.cs.md#symbol-468db1f7ab7f)

**调用：** [`NationalSpire.CareerScreen.ReportCell(string, int, Godot.Color, bool)`](DuelReportScreen.cs.md#symbol-929c22d0a91a)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`Godot.TextureRect.TextureRect()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ReportCell(string, int, Godot.Color, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation",4);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`icon.SetAnchorsAndOffsetsPreset(LayoutPreset.Center)`；返回值紧邻使用处：`ExpressionStatementSyntax: icon.SetAnchorsAndOffsetsPreset(LayoutPreset.Center);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(line);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cell.AddChild(icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: cell.AddChild(icon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(cell)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(cell);`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<Texture2D>("res://images/"+icons[i])`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ResourceLoader.Load<Texture2D>("res://images/"+icons[i])`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect{Texture=texture,ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,                      StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new TextureRect{Texture=texture,ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,                      StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore}`
- `NationalSpire.CareerScreen.ReportCell(string, int, Godot.Color, bool)`；输入表达式：`ReportCell(values[i],widths[i],ink,i==1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ReportCell(values[i],widths[i],ink,i==1)`

**赋值（含属性/字段和局部值）：**

- `cell.MouseFilter` = `MouseFilterEnum.Pass`
- `cell.Text` = `""`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `icon.OffsetBottom` = `14`
- `icon.OffsetLeft` = `-14`
- `icon.OffsetRight` = `14`
- `icon.OffsetTop` = `-14`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Texture` = `texture`
