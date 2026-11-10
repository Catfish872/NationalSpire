# ClubRosterScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B496531DE0561AA2A213A66390184390507DCBC80A6903575090D3FA422E0A1C`。来源：[源码](../../ClubRosterScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly string[] RosterPositions = ["首发","教练","轮换","青训"];
```

<a id="symbol-9ed06d3d7953"></a>

## `NationalSpire.CareerScreen.RosterMembers(NationalSpire.CareerData, NationalSpire.OwnedClubState) — private void RosterMembers(CareerData data, OwnedClubState club)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`](OwnedClubScreen.cs.md#symbol-9c161e058b4e)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Hairline(string)`](DashboardControls.cs.md#symbol-bf15f4abfdcb)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData, string?)`](CoachScreen.cs.md#symbol-a537f69fc7d9)；[`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)；[`NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`](ClubRosterScreen.cs.md#symbol-540dea7ac6fc)；[`NationalSpire.CareerScreen.TogglePlayerCoach(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-6fefaeeb11b8)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-d1aa71b14a7b)；[`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-26fb5cc468c4)；[`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-11696548c7d5)；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.Insert(int, T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Hairline(string)`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData, string?)`；`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`；`NationalSpire.CareerScreen.RosterPositions`；`NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`；`NationalSpire.CareerScreen.TogglePlayerCoach(NationalSpire.CareerData)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubState.PlayerCoach`；`NationalSpire.OwnedClubState.PlayerNextPosition`；`NationalSpire.OwnedClubState.PlayerPositionSeason`；`NationalSpire.OwnedClubState.PlayerReplacement`；`NationalSpire.OwnedClubState.PlayerReserve`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`panel.DrawLine(new(17,1),new(63,1),new Color("799aa5"),2)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => panel.DrawLine(new(17,1),new(63,1),new Color("799aa5"),2)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("799aa5")`；返回值紧邻使用处：`ArgumentSyntax: new Color("799aa5")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`group.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddThemeConstantOverride("separation",0);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`heading.AddThemeConstantOverride("separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddThemeConstantOverride("separation",8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`padding.AddThemeConstantOverride("margin_bottom",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: padding.AddThemeConstantOverride("margin_bottom",0);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel",surface)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel",surface);`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(8, 0), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new Control { CustomMinimumSize = new(8, 0), MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(DashboardLabel("教练提升轮换与青训陪练效果，多名教练取最高加成。", 16, _muted, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(DashboardLabel("教练提升轮换与青训陪练效果，多名教练取最高加成。", 16, _muted, true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(DashboardLabel("前往招募选择选手。",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(DashboardLabel("前往招募选择选手。",16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(Hairline("526e8059"))`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(Hairline("526e8059"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(padding)`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(padding);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(pending)`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(pending);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(count)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(count);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(DashboardLabel($"×{ClubCoaching.Factor(data):0.#}", 20, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(DashboardLabel($"×{ClubCoaching.Factor(data):0.#}", 20, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(new Control { CustomMinimumSize = new(8, 0), MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(new Control { CustomMinimumSize = new(8, 0), MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(RosterTool("恢复首发",()=>PlayerPositionDialog(data)))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(RosterTool("恢复首发",()=>PlayerPositionDialog(data)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(RosterTool("兼任教练",()=>TogglePlayerCoach(data)))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(RosterTool("兼任教练",()=>TogglePlayerCoach(data)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`padding.AddChild(member)`；返回值紧邻使用处：`ExpressionStatementSyntax: padding.AddChild(member);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(group)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(group);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pending.AddChild(DashboardLabel($"第{club.PlayerPositionSeason}赛季转为{club.PlayerNextPosition} · 与{CareerEngine.DisplayName(data,club.PlayerReplacement)}调整席位",16,_gold,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.AddChild(DashboardLabel($"第{club.PlayerPositionSeason}赛季转为{club.PlayerNextPosition} · 与{CareerEngine.DisplayName(data,club.PlayerReplacement)}调整席位",16,_gold,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pending.AddChild(RosterTool("撤销席位申请",()=>ClubAction(data,"player-position",target:"取消")))`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.AddChild(RosterTool("撤销席位申请",()=>ClubAction(data,"player-position",target:"取消")));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(17,1)`；返回值紧邻使用处：`ArgumentSyntax: new(17,1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(63,1)`；返回值紧邻使用处：`ArgumentSyntax: new(63,1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(8, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(8, 0)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data,club.PlayerReplacement)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data,club.PlayerReplacement)}`
- `NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；输入表达式：`ClubAction(data,"player-position",target:"取消")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>ClubAction(data,"player-position",target:"取消")`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("/ "+ids.Count+" 人", 18, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel("/ "+ids.Count+" 人", 18, _muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("当前陪练系数", 20, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel("当前陪练系数", 20, _muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("教练提升轮换与青训陪练效果，多名教练取最高加成。", 16, _muted, true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("教练提升轮换与青训陪练效果，多名教练取最高加成。", 16, _muted, true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("前往招募选择选手。",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("前往招募选择选手。",16,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"×{ClubCoaching.Factor(data):0.#}", 20, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel($"×{ClubCoaching.Factor(data):0.#}", 20, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"第{club.PlayerPositionSeason}赛季转为{club.PlayerNextPosition} · 与{CareerEngine.DisplayName(data,club.PlayerReplacement)}调整席位",16,_gold,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel($"第{club.PlayerPositionSeason}赛季转为{club.PlayerNextPosition} · 与{CareerEngine.DisplayName(data,club.PlayerReplacement)}调整席位",16,_gold,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(role,23,_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel(role,23,_gold)`
- `NationalSpire.CareerScreen.Hairline(string)`；输入表达式：`Hairline("526e8059")`；返回值紧邻使用处：`ArgumentSyntax: Hairline("526e8059")`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(0,14)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inset(0,14)`
- `NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData, string?)`；输入表达式：`PlayerPositionDialog(data)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>PlayerPositionDialog(data)`
- `NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`；输入表达式：`RosterMember(data,club,member,ids[index],role,humans.Contains(ids[index]))`；返回值紧邻使用处：`ExpressionStatementSyntax: RosterMember(data,club,member,ids[index],role,humans.Contains(ids[index]));`
- `NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`；输入表达式：`RosterTool("撤销席位申请",()=>ClubAction(data,"player-position",target:"取消"))`；返回值紧邻使用处：`ArgumentSyntax: RosterTool("撤销席位申请",()=>ClubAction(data,"player-position",target:"取消"))`
- `NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`；输入表达式：`RosterTool("恢复首发",()=>PlayerPositionDialog(data))`；返回值紧邻使用处：`ArgumentSyntax: RosterTool("恢复首发",()=>PlayerPositionDialog(data))`
- `NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`；输入表达式：`RosterTool("兼任教练",()=>TogglePlayerCoach(data))`；返回值紧邻使用处：`ArgumentSyntax: RosterTool("兼任教练",()=>TogglePlayerCoach(data))`
- `NationalSpire.CareerScreen.TogglePlayerCoach(NationalSpire.CareerData)`；输入表达式：`TogglePlayerCoach(data)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>TogglePlayerCoach(data)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("152534","334958",8,24)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box("152534","334958",8,24)`
- `NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.Factor(data)`；返回值紧邻使用处：`InterpolationSyntax: {ClubCoaching.Factor(data):0.#}`
- `NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerCoach(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: role=="教练" && ClubCoaching.PlayerCoach(data)`
- `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerFeatures(data)`；返回值紧邻使用处：`IfStatementSyntax: if (ClubCoaching.PlayerFeatures(data))              {                  if (role=="首发" && club.PlayerReserve)                      heading.AddChild(RosterTool("恢复首发",()=>PlayerPositionDialog(data)));                  if (role=="教练" && !club.PlayerCoach)                      heading.AddChild(RosterTool("兼任教练",()=>TogglePlayerCoach(data)));                  if (role=="首发" && club.PlayerPositionSeason>0)                  {                      var pending = new HBoxContainer(); group.AddChild(pending);                      pending.AddChild(DashboardLabel($"第{club.PlayerPositionSeason}赛季转为{club.PlayerNextPosition} · 与{CareerEngine.DisplayName(data,club.PlayerReplacement)}调整席位",16,_gold,true));                      pending.AddChild(RosterTool("撤销席位申请",()=>ClubAction(data,"player-position",target:"取消")));                  }              }`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.Humans(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.Humans(data).ToHashSet`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`OwnedClubs.PositionList(club,role)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.PositionList(club,role).ToList`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`humans.Contains(ids[index])`；返回值紧邻使用处：`ArgumentSyntax: humans.Contains(ids[index])`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`OwnedClubs.Humans(data).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.Humans(data).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`OwnedClubs.PositionList(club,role).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.PositionList(club,role).ToList()`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`ids.Contains("player")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ids.Contains("player")`
- `System.Collections.Generic.List<T>.Insert(int, T)`；输入表达式：`ids.Insert(0,"player")`；返回值紧邻使用处：`ExpressionStatementSyntax: ids.Insert(0,"player");`

**赋值（含属性/字段和局部值）：**

- `count.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `CustomMinimumSize` = `new(8, 0)`
- `label.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `panel.Draw` += `() => panel.DrawLine(new(17,1),new(63,1),new Color("799aa5"),2)`
- `surface.ContentMarginBottom` = `20`
- `surface.ContentMarginTop` = `surface.ContentMarginBottom = 20`
- `title.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`

<a id="symbol-8191d4b2f80f"></a>

## `NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool) — private void RosterMember(CareerData data, OwnedClubState club, VBoxContainer parent, string id, string role, bool human)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterMembers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](ClubRosterScreen.cs.md#symbol-9ed06d3d7953)

**调用：** [`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-b9f8261f2cf2)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.ArenaCharacterName(string)`](MatchArenaScreen.cs.md#symbol-8a35d94d8045)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`](OwnedClubScreen.cs.md#symbol-9c161e058b4e)；[`NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`](OwnedClubScreen.cs.md#symbol-d2eca2f3e48f)；[`NationalSpire.CareerScreen.CoachAppointmentDialog(NationalSpire.CareerData, string)`](CoachScreen.cs.md#symbol-e2df497af307)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData, string?)`](CoachScreen.cs.md#symbol-a537f69fc7d9)；[`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)；[`NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`](ClubRosterScreen.cs.md#symbol-540dea7ac6fc)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.StyleRosterPicker(Godot.OptionButton, int, int)`](ClubRosterScreen.cs.md#symbol-15be3d74c4b5)；[`NationalSpire.CareerScreen.TogglePlayerCoach(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-6fefaeeb11b8)；[`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-c0a761e9458d)；[`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-26fb5cc468c4)；[`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)；[`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；[`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`](MatchRules.cs.md#symbol-a0517de2db43)；[`NationalSpire.OwnedClubs.ExitFee(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract)`](OwnedClubs.cs.md#symbol-157b8775d91c)；[`NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-1036b8f22501)；[`NationalSpire.OwnedClubs.PlanName(string)`](OwnedClubs.cs.md#symbol-f0042770c2f0)；[`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-11696548c7d5)；[`NationalSpire.OwnedClubs.Tier(NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-87d58351738a)；[`NationalSpire.PlayerArchive.Read(bool)`](PlayerArchive.cs.md#symbol-153514d4aa72)；[`Tool(string, System.Action)`](ClubRosterScreen.cs.md#symbol-7808fa25f82f)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetParent<T>()`；`Godot.OptionButton.Select(int)`；`Godot.OptionButton.SetItemDisabled(int, bool)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`string.IsNullOrEmpty(string?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchiveSnapshot.WinRate`；`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.AvatarHighestClear`；`NationalSpire.CareerData.HumanClears`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；`NationalSpire.CareerScreen.ArenaCharacterName(string)`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.CanManageClub`；`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；`NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；`NationalSpire.CareerScreen.CoachAppointmentDialog(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData, string?)`；`NationalSpire.CareerScreen.RosterPositions`；`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`；`NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.StyleRosterPicker(Godot.OptionButton, int, int)`；`NationalSpire.CareerScreen.TogglePlayerCoach(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerPerson)`；`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；`NationalSpire.CoachAppointment.PersonId`；`NationalSpire.CoachAppointment.Season`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`；`NationalSpire.OwnedClubs.ExitFee(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract)`；`NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.PlanName(string)`；`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubs.Tier(NationalSpire.CareerPerson)`；`NationalSpire.OwnedClubState.CoachAppointments`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.HumanPayDue`；`NationalSpire.OwnedClubState.HumanWeeklyWage`；`NationalSpire.OwnedClubState.HumanWinBonus`；`NationalSpire.OwnedClubState.ManagerId`；`NationalSpire.OwnedClubState.PlayerCoach`；`NationalSpire.OwnedPlayerContract.EndDay`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Plan`；`NationalSpire.OwnedPlayerContract.Wage`；`NationalSpire.OwnedPlayerContract.WinBonus`；`NationalSpire.PlayerArchive.Read(bool)`；`Tool(string, System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`facts.AddThemeConstantOverride("separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: facts.AddThemeConstantOverride("separation",4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`identity.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddThemeConstantOverride("separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`labels.AddThemeConstantOverride("separation",3)`；返回值紧邻使用处：`ExpressionStatementSyntax: labels.AddThemeConstantOverride("separation",3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation",22)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation",22);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`pending.AddThemeConstantOverride("separation",16)`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.AddThemeConstantOverride("separation",16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tools.AddThemeConstantOverride("h_separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddThemeConstantOverride("h_separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tools.AddThemeConstantOverride("v_separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddThemeConstantOverride("v_separation",8);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer {Name="RosterMember_"+id}`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer {Name="RosterMember_"+id}`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer {Name="RosterTools",CustomMinimumSize=new(560,0),SizeFlagsHorizontal=SizeFlags.ExpandFill,              SizeFlagsStretchRatio=1.52f,SizeFlagsVertical=SizeFlags.ShrinkCenter, Alignment=FlowContainer.AlignmentMode.End}`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer {Name="RosterTools",CustomMinimumSize=new(560,0),SizeFlagsHorizontal=SizeFlags.ExpandFill,              SizeFlagsStretchRatio=1.52f,SizeFlagsVertical=SizeFlags.ShrinkCenter, Alignment=FlowContainer.AlignmentMode.End}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`facts.AddChild(DashboardLabel("俱乐部部长",15,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: facts.AddChild(DashboardLabel("俱乐部部长",15,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`facts.AddChild(DashboardLabel($"{OwnedClubs.PlanName(contract.Plan)} · 周薪 {CareerMoney.Format(contract.Wage)} · 获胜 {CareerMoney.Format(contract.WinBonus)} · {GameCalendar.Date(data,contract.EndDay):M/d} 续约",15,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: facts.AddChild(DashboardLabel($"{OwnedClubs.PlanName(contract.Plan)} · 周薪 {CareerMoney.Format(contract.Wage)} · 获胜 {CareerMoney.Format(contract.WinBonus)} · {GameCalendar.Date(data,contract.EndDay):M/d} 续约",15,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`facts.AddChild(DashboardLabel($"周薪 {CareerMoney.Format(club.HumanWeeklyWage)} · 获胜 {CareerMoney.Format(club.HumanWinBonus)} · 待付 {CareerMoney.Format(club.HumanPayDue.GetValueOrDefault(id))}",15,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: facts.AddChild(DashboardLabel($"周薪 {CareerMoney.Format(club.HumanWeeklyWage)} · 获胜 {CareerMoney.Format(club.HumanWinBonus)} · 待付 {CareerMoney.Format(club.HumanPayDue.GetValueOrDefault(id))}",15,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`facts.AddChild(DashboardLabel($"最高进阶 {level} · 通关率 {rate}",16,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: facts.AddChild(DashboardLabel($"最高进阶 {level} · 通关率 {rate}",16,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`facts.AddChild(DashboardLabel(role=="教练" ? $"陪练系数 ×{ClubCoaching.Factor(person):0.#}" :              $"进阶 {person.MaxAscension} · A8 预计通关率 {MatchRules.ClearChance(data,person,8)*100:0.#}%",16,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: facts.AddChild(DashboardLabel(role=="教练" ? $"陪练系数 ×{ClubCoaching.Factor(person):0.#}" :              $"进阶 {person.MaxAscension} · A8 预计通关率 {MatchRules.ClearChance(data,person,8)*100:0.#}%",16,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(Avatar(data,id,49,false))`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(Avatar(data,id,49,false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(Glyph("chevron-right",17,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(Glyph("chevron-right",17,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(labels)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(labels);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`labels.AddChild(nameLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: labels.AddChild(nameLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`labels.AddChild(subtitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: labels.AddChild(subtitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(facts)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(facts);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(tools)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(tools);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(line);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(pending)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(pending);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pending.AddChild(note)`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.AddChild(note);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pending.AddChild(RosterTool("取消调整",()=>ClubAction(data,"coach-cancel",target:id),90,32))`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.AddChild(RosterTool("取消调整",()=>ClubAction(data,"coach-cancel",target:id),90,32));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddChild(picker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(RosterTool(club.PlayerCoach ? "结束教练" : "兼任教练",()=>TogglePlayerCoach(data)))`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddChild(RosterTool(club.PlayerCoach ? "结束教练" : "兼任教练",()=>TogglePlayerCoach(data)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(select)`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddChild(select);`
- `Godot.Node.GetParent<T>()`；输入表达式：`open.GetParent<Control>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = open.GetParent<Control>()`
- `Godot.OptionButton.Select(int)`；输入表达式：`picker.Select(0)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _=>picker.Select(0)`
- `Godot.OptionButton.Select(int)`；输入表达式：`select.Select(0)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _=>select.Select(0)`
- `Godot.OptionButton.SetItemDisabled(int, bool)`；输入表达式：`picker.SetItemDisabled(0,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.SetItemDisabled(0,true);`
- `Godot.OptionButton.SetItemDisabled(int, bool)`；输入表达式：`select.SetItemDisabled(0,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: select.SetItemDisabled(0,true);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {Name="RosterFacts",CustomMinimumSize=new(300,0),SizeFlagsHorizontal=SizeFlags.ExpandFill,              SizeFlagsVertical=SizeFlags.ShrinkCenter}`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer {Name="RosterFacts",CustomMinimumSize=new(300,0),SizeFlagsHorizontal=SizeFlags.ExpandFill,              SizeFlagsVertical=SizeFlags.ShrinkCenter}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center}`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(220,61)`；返回值紧邻使用处：`AssignmentExpressionSyntax: nameCard.CustomMinimumSize=new(220,61)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(300,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(300,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(560,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(560,0)`
- `int.ToString()`；输入表达式：`highest.ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: highest < 0 ? "—" : highest.ToString()`
- `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.MainCharacter(data,id)`；返回值紧邻使用处：`ArgumentSyntax: CareerAvatars.MainCharacter(data,id)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data,i)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i=>CareerEngine.DisplayName(data,i)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data,id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.DisplayName(data,id)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data,id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(data,id)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(club.HumanPayDue.GetValueOrDefault(id))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(club.HumanPayDue.GetValueOrDefault(id))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(club.HumanWeeklyWage)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(club.HumanWeeklyWage)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(club.HumanWinBonus)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(club.HumanWinBonus)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(contract.Wage)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(contract.Wage)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(contract.WinBonus)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(contract.WinBonus)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(OwnedClubs.ExitFee(data,contract))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(OwnedClubs.ExitFee(data,contract))}`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(line,"RosterIdentity",name,()=>OpenPerson(id),identity,61,8,5,"1b303e","395365","28434c")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ActionRow(line,"RosterIdentity",name,()=>OpenPerson(id),identity,61,8,5,"1b303e","395365","28434c")`
- `NationalSpire.CareerScreen.ArenaCharacterName(string)`；输入表达式：`ArenaCharacterName(CareerAvatars.MainCharacter(data,id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ArenaCharacterName(CareerAvatars.MainCharacter(data,id))`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data,id,49,false)`；返回值紧邻使用处：`ArgumentSyntax: Avatar(data,id,49,false)`
- `NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；输入表达式：`ClubAction(data,"coach-cancel",target:id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>ClubAction(data,"coach-cancel",target:id)`
- `NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；输入表达式：`ClubAction(data,"position",destination,id)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubAction(data,"position",destination,id);`
- `NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；输入表达式：`ClubAction(data,"release",target:id)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubAction(data,"release",target:id);`
- `NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；输入表达式：`ClubSelect(["交换位置",..candidates.Select(i=>CareerEngine.DisplayName(data,i))],0,index=>                  { if (index>0) RosterSwapDialog(data,id,candidates,candidates[index-1]); })`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ClubSelect(["交换位置",..candidates.Select(i=>CareerEngine.DisplayName(data,i))],0,index=>                  { if (index>0) RosterSwapDialog(data,id,candidates,candidates[index-1]); })`
- `NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；输入表达式：`ClubSelect(["退出首发",..candidates.Select(i=>CareerEngine.DisplayName(data,i))],0,index=>                      { if (index>0) PlayerPositionDialog(data,candidates[index-1]); })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubSelect(["退出首发",..candidates.Select(i=>CareerEngine.DisplayName(data,i))],0,index=>                      { if (index>0) PlayerPositionDialog(data,candidates[index-1]); })`
- `NationalSpire.CareerScreen.CoachAppointmentDialog(NationalSpire.CareerData, string)`；输入表达式：`CoachAppointmentDialog(data,id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>CoachAppointmentDialog(data,id)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("俱乐部部长",15,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("俱乐部部长",15,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"{OwnedClubs.PlanName(contract.Plan)} · 周薪 {CareerMoney.Format(contract.Wage)} · 获胜 {CareerMoney.Format(contract.WinBonus)} · {GameCalendar.Date(data,contract.EndDay):M/d} 续约",15,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel($"{OwnedClubs.PlanName(contract.Plan)} · 周薪 {CareerMoney.Format(contract.Wage)} · 获胜 {CareerMoney.Format(contract.WinBonus)} · {GameCalendar.Date(data,contract.EndDay):M/d} 续约",15,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"第 {appointment.Season} 赛季转任教练",16,_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel($"第 {appointment.Season} 赛季转任教练",16,_gold)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"周薪 {CareerMoney.Format(club.HumanWeeklyWage)} · 获胜 {CareerMoney.Format(club.HumanWinBonus)} · 待付 {CareerMoney.Format(club.HumanPayDue.GetValueOrDefault(id))}",15,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel($"周薪 {CareerMoney.Format(club.HumanWeeklyWage)} · 获胜 {CareerMoney.Format(club.HumanWinBonus)} · 待付 {CareerMoney.Format(club.HumanPayDue.GetValueOrDefault(id))}",15,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"最高进阶 {level} · 通关率 {rate}",16,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel($"最高进阶 {level} · 通关率 {rate}",16,_ink,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(character.Length==0 ? rank : rank+" · "+character,15,_muted,true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel(character.Length==0 ? rank : rank+" · "+character,15,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(name,20,_ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(name,20,_ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(role=="教练" ? $"陪练系数 ×{ClubCoaching.Factor(person):0.#}" :              $"进阶 {person.MaxAscension} · A8 预计通关率 {MatchRules.ClearChance(data,person,8)*100:0.#}%",16,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(role=="教练" ? $"陪练系数 ×{ClubCoaching.Factor(person):0.#}" :              $"进阶 {person.MaxAscension} · A8 预计通关率 {MatchRules.ClearChance(data,person,8)*100:0.#}%",16,_ink,true)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("chevron-right",17,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Glyph("chevron-right",17,_muted)`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenPerson(id)`
- `NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData, string?)`；输入表达式：`PlayerPositionDialog(data,candidates[index-1])`；返回值紧邻使用处：`ExpressionStatementSyntax: PlayerPositionDialog(data,candidates[index-1]);`
- `NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`；输入表达式：`RosterSwapDialog(data,id,candidates,candidates[index-1])`；返回值紧邻使用处：`ExpressionStatementSyntax: RosterSwapDialog(data,id,candidates,candidates[index-1]);`
- `NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`；输入表达式：`RosterTool("取消调整",()=>ClubAction(data,"coach-cancel",target:id),90,32)`；返回值紧邻使用处：`ArgumentSyntax: RosterTool("取消调整",()=>ClubAction(data,"coach-cancel",target:id),90,32)`
- `NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`；输入表达式：`RosterTool(club.PlayerCoach ? "结束教练" : "兼任教练",()=>TogglePlayerCoach(data))`；返回值紧邻使用处：`ArgumentSyntax: RosterTool(club.PlayerCoach ? "结束教练" : "兼任教练",()=>TogglePlayerCoach(data))`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("解除合同",$"{name} 的解约补偿为 {CareerMoney.Format(OwnedClubs.ExitFee(data,contract))}。",              ()=>{ClubAction(data,"release",target:id);return true;})`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>ShowCareerDialog("解除合同",$"{name} 的解约补偿为 {CareerMoney.Format(OwnedClubs.ExitFee(data,contract))}。",              ()=>{ClubAction(data,"release",target:id);return true;})`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog(action,detail,()=>{ClubAction(data,"position",destination,id);return true;})`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>ShowCareerDialog(action,detail,()=>{ClubAction(data,"position",destination,id);return true;})`
- `NationalSpire.CareerScreen.StyleRosterPicker(Godot.OptionButton, int, int)`；输入表达式：`StyleRosterPicker(picker,190,43)`；返回值紧邻使用处：`ExpressionStatementSyntax: StyleRosterPicker(picker,190,43);`
- `NationalSpire.CareerScreen.StyleRosterPicker(Godot.OptionButton, int, int)`；输入表达式：`StyleRosterPicker(select,190,43)`；返回值紧邻使用处：`ExpressionStatementSyntax: StyleRosterPicker(select,190,43);`
- `NationalSpire.CareerScreen.TogglePlayerCoach(NationalSpire.CareerData)`；输入表达式：`TogglePlayerCoach(data)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>TogglePlayerCoach(data)`
- `NationalSpire.ClubCoaching.Factor(NationalSpire.CareerPerson)`；输入表达式：`ClubCoaching.Factor(person)`；返回值紧邻使用处：`InterpolationSyntax: {ClubCoaching.Factor(person):0.#}`
- `NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerCoach(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: id=="player" && ClubCoaching.PlayerCoach(data)`
- `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerFeatures(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: ClubCoaching.PlayerFeatures(data) && id=="player"`
- `NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；输入表达式：`ClubCoaching.Replacements(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubCoaching.Replacements(data)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data,contract.EndDay)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Date(data,contract.EndDay):M/d}`
- `NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`；输入表达式：`MatchRules.ClearChance(data,person,8)`；返回值紧邻使用处：`BinaryExpressionSyntax: MatchRules.ClearChance(data,person,8)*100`
- `NationalSpire.OwnedClubs.ExitFee(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract)`；输入表达式：`OwnedClubs.ExitFee(data,contract)`；返回值紧邻使用处：`ArgumentSyntax: OwnedClubs.ExitFee(data,contract)`
- `NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.PaidHumans(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.PaidHumans(data).Contains`
- `NationalSpire.OwnedClubs.PlanName(string)`；输入表达式：`OwnedClubs.PlanName(contract.Plan)`；返回值紧邻使用处：`InterpolationSyntax: {OwnedClubs.PlanName(contract.Plan)}`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`OwnedClubs.PositionList(club,r)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r=>OwnedClubs.PositionList(club,r)`
- `NationalSpire.OwnedClubs.Tier(NationalSpire.CareerPerson)`；输入表达式：`OwnedClubs.Tier(person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: human || person==null ? role : OwnedClubs.Tier(person)`
- `NationalSpire.PlayerArchive.Read(bool)`；输入表达式：`PlayerArchive.Read(false)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PlayerArchive.Read(false).WinRate`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(s)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrEmpty(s)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" · ",new[]{name,rank,person?.Role,character}.Where(s=>!string.IsNullOrEmpty(s)).Distinct())`；返回值紧邻使用处：`AssignmentExpressionSyntax: open.TooltipText=string.Join(" · ",new[]{name,rank,person?.Role,character}.Where(s=>!string.IsNullOrEmpty(s)).Distinct())`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`club.Contracts.Any(c=>c.PersonId==member)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: member=>club.Contracts.Any(c=>c.PersonId==member)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`new[]{name,rank,person?.Role,character}.Where(s=>!string.IsNullOrEmpty(s)).Distinct()`；返回值紧邻使用处：`ArgumentSyntax: new[]{name,rank,person?.Role,character}.Where(s=>!string.IsNullOrEmpty(s)).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`club.CoachAppointments.FirstOrDefault(a=>a.PersonId==id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: club.CoachAppointments.FirstOrDefault(a=>a.PersonId==id) is { } appointment`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`club.Contracts.FirstOrDefault(c=>c.PersonId==id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = club.Contracts.FirstOrDefault(c=>c.PersonId==id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`candidates.Select(i=>CareerEngine.DisplayName(data,i))`；返回值紧邻使用处：`SpreadElementSyntax: ..candidates.Select(i=>CareerEngine.DisplayName(data,i))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`RosterPositions.Where(r=>r!=role && r!="教练").SelectMany(r=>OwnedClubs.PositionList(club,r))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: RosterPositions.Where(r=>r!=role && r!="教练").SelectMany(r=>OwnedClubs.PositionList(club,r))                  .Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`RosterPositions.Where(r=>r!=role && r!="教练").SelectMany(r=>OwnedClubs.PositionList(club,r))                  .Where(member=>club.Contracts.Any(c=>c.PersonId==member)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =RosterPositions.Where(r=>r!=role && r!="教练").SelectMany(r=>OwnedClubs.PositionList(club,r))                  .Where(member=>club.Contracts.Any(c=>c.PersonId==member)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[]{name,rank,person?.Role,character}.Where(s=>!string.IsNullOrEmpty(s))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[]{name,rank,person?.Role,character}.Where(s=>!string.IsNullOrEmpty(s)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`RosterPositions.Where(r=>r!=role && r!="教练").SelectMany(r=>OwnedClubs.PositionList(club,r))                  .Where(member=>club.Contracts.Any(c=>c.PersonId==member))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: RosterPositions.Where(r=>r!=role && r!="教练").SelectMany(r=>OwnedClubs.PositionList(club,r))                  .Where(member=>club.Contracts.Any(c=>c.PersonId==member)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`RosterPositions.Where(r=>r!=role && r!="教练")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: RosterPositions.Where(r=>r!=role && r!="教练").SelectMany`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`data.HumanClears.GetValueOrDefault(id,-1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id=="player" ? data.AvatarHighestClear : data.HumanClears.GetValueOrDefault(id,-1)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`club.HumanPayDue.GetValueOrDefault(id)`；返回值紧邻使用处：`ArgumentSyntax: club.HumanPayDue.GetValueOrDefault(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`OwnedClubs.PaidHumans(data).Contains(id)`；返回值紧邻使用处：`IfStatementSyntax: if (OwnedClubs.PaidHumans(data).Contains(id))                  facts.AddChild(DashboardLabel($"周薪 {CareerMoney.Format(club.HumanWeeklyWage)} · 获胜 {CareerMoney.Format(club.HumanWinBonus)} · 待付 {CareerMoney.Format(club.HumanPayDue.GetValueOrDefault(id))}",15,_muted,true));`
- `Tool(string, System.Action)`；输入表达式：`Tool("解除合同",()=>ShowCareerDialog("解除合同",$"{name} 的解约补偿为 {CareerMoney.Format(OwnedClubs.ExitFee(data,contract))}。",              ()=>{ClubAction(data,"release",target:id);return true;}))`；返回值紧邻使用处：`ExpressionStatementSyntax: Tool("解除合同",()=>ShowCareerDialog("解除合同",$"{name} 的解约补偿为 {CareerMoney.Format(OwnedClubs.ExitFee(data,contract))}。",              ()=>{ClubAction(data,"release",target:id);return true;}));`
- `Tool(string, System.Action)`；输入表达式：`Tool("转任教练",()=>CoachAppointmentDialog(data,id))`；返回值紧邻使用处：`ExpressionStatementSyntax: Tool("转任教练",()=>CoachAppointmentDialog(data,id));`
- `Tool(string, System.Action)`；输入表达式：`Tool(action,()=>ShowCareerDialog(action,detail,()=>{ClubAction(data,"position",destination,id);return true;}))`；返回值紧邻使用处：`ExpressionStatementSyntax: Tool(action,()=>ShowCareerDialog(action,detail,()=>{ClubAction(data,"position",destination,id);return true;}));`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `Alignment` = `FlowContainer.AlignmentMode.End`
- `CustomMinimumSize` = `new(300,0)`
- `CustomMinimumSize` = `new(560,0)`
- `Name` = `"RosterFacts"`
- `Name` = `"RosterMember_"+id`
- `Name` = `"RosterTools"`
- `nameCard.CustomMinimumSize` = `new(220,61)`
- `nameCard.SizeFlagsStretchRatio` = `.81f`
- `nameCard.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `nameLabel.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `note.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `open.TooltipText` = `string.Join(" · ",new[]{name,rank,person?.Role,character}.Where(s=>!string.IsNullOrEmpty(s)).Distinct())`
- `picker.Disabled` = `candidates.Count==0`
- `picker.ItemSelected` += `_=>picker.Select(0)`
- `picker.Name` = `"PlayerSeatExchange"`
- `rank` += `" · 兼任教练"`
- `select.ItemSelected` += `_=>select.Select(0)`
- `select.Name` = `"RosterExchange"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsStretchRatio` = `1.52f`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-7808fa25f82f"></a>

## `Tool(string, System.Action) — void Tool(string text,Action command)`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)

**调用：** [`NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`](ClubRosterScreen.cs.md#symbol-540dea7ac6fc)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(RosterTool(text,command))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => tools.AddChild(RosterTool(text,command))`
- `NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`；输入表达式：`RosterTool(text,command)`；返回值紧邻使用处：`ArgumentSyntax: RosterTool(text,command)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-15be3d74c4b5"></a>

## `NationalSpire.CareerScreen.StyleRosterPicker(Godot.OptionButton, int, int) — private static void StyleRosterPicker(OptionButton picker,int width,int height)`

来源：源码第 152 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)；[`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)

**调用：** [`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`picker.AddThemeFontSizeOverride("font_size",16)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddThemeFontSizeOverride("font_size",16);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: picker.CustomMinimumSize=new(width,height)`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(picker,"1d3040","395365","28434c","658c91",7,6)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(picker,"1d3040","395365","28434c","658c91",7,6);`

**赋值（含属性/字段和局部值）：**

- `picker.CustomMinimumSize` = `new(width,height)`
- `picker.FitToLongestItem` = `false`
- `picker.SizeFlagsHorizontal` = `width > 0 ? SizeFlags.ShrinkEnd : SizeFlags.ExpandFill`

<a id="symbol-540dea7ac6fc"></a>

## `NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int) — private Button RosterTool(string title,Action action,int width=116,int height=43)`

来源：源码第 160 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)；[`NationalSpire.CareerScreen.RosterMembers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](ClubRosterScreen.cs.md#symbol-9ed06d3d7953)；[`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)；[`Tool(string, System.Action)`](ClubRosterScreen.cs.md#symbol-7808fa25f82f)

**调用：** [`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.ClubButton(string, System.Action, int)`](OwnedClubScreen.cs.md#symbol-745c5ca62e51)；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.ClubButton(string, System.Action, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size",16)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size",16);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize=new(width,height)`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(button,"1d3040","395365","28434c","658c91",6,6)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(button,"1d3040","395365","28434c","658c91",6,6);`
- `NationalSpire.CareerScreen.ClubButton(string, System.Action, int)`；输入表达式：`ClubButton(title,action,width)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ClubButton(title,action,width)`

**赋值（含属性/字段和局部值）：**

- `button.CustomMinimumSize` = `new(width,height)`

<a id="symbol-e2f1b514a2f4"></a>

## `NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string) — private void RosterCandidate(CareerData data,VBoxContainer card,string id,string label)`

来源：源码第 168 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；[`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`](MatchRules.cs.md#symbol-a0517de2db43)；[`NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-e5d4bf00dda1)；[`Stat(string, string)`](ClubRosterScreen.cs.md#symbol-e5effcdd65f3)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Mathf.Ceil(float)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Name`；`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.AvatarIdentity.Frame`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`；`NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；`Stat(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_top",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_top",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`name.AddThemeConstantOverride("separation",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddThemeConstantOverride("separation",6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`stats.AddThemeConstantOverride("separation",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: stats.AddThemeConstantOverride("separation",6);`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`CareerVisuals.InterfaceText().GetStringSize(person.PublicName,fontSize:23)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.InterfaceText().GetStringSize(person.PublicName,fontSize:23).X`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}`
- `Godot.Mathf.Ceil(float)`；输入表达式：`Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(person.PublicName,fontSize:23).X)`；返回值紧邻使用处：`BinaryExpressionSyntax: Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(person.PublicName,fontSize:23).X)+2`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(DashboardLabel(label+" · "+OwnedClubs.Position(data.Esports.OwnedClub!,id),15,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(DashboardLabel(label+" · "+OwnedClubs.Position(data.Esports.OwnedClub!,id),15,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(portraitMargin)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(portraitMargin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(stats)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(stats);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`name.AddChild(identity)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddChild(identity);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`name.AddChild(small)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddChild(small);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`portraitMargin.AddChild(portrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: portraitMargin.AddChild(portrait);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Min(295,Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(person.PublicName,fontSize:23).X)+2),0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: identity.CustomMinimumSize=new(Math.Min(295,Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(person.PublicName,fontSize:23).X)+2),0)`
- `int.ToString()`；输入表达式：`person.MaxAscension.ToString()`；返回值紧邻使用处：`ArgumentSyntax: person.MaxAscension.ToString()`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(data,id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AvatarHonors.ForPerson(data,id).Frame`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data,id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data,id)!`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data,id,104,false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Avatar(data,id,104,false)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("ID",12,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel("ID",12,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(label+" · "+OwnedClubs.Position(data.Esports.OwnedClub!,id),15,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(label+" · "+OwnedClubs.Position(data.Esports.OwnedClub!,id),15,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(person.PublicName,23,_ink,true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(person.PublicName,23,_ink,true)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(0,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inset(0,0)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(0,8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inset(0,8)`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerVisuals.InterfaceText().GetStringSize`
- `NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`；输入表达式：`MatchRules.ClearChance(data,person,8)`；返回值紧邻使用处：`BinaryExpressionSyntax: MatchRules.ClearChance(data,person,8)*100`
- `NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；输入表达式：`OwnedClubs.Position(data.Esports.OwnedClub!,id)`；返回值紧邻使用处：`BinaryExpressionSyntax: label+" · "+OwnedClubs.Position(data.Esports.OwnedClub!,id)`
- `Stat(string, string)`；输入表达式：`Stat("称号",AvatarHonors.ForPerson(data,id).Frame.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: Stat("称号",AvatarHonors.ForPerson(data,id).Frame.Name);`
- `Stat(string, string)`；输入表达式：`Stat("最高进阶",person.MaxAscension.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Stat("最高进阶",person.MaxAscension.ToString());`
- `Stat(string, string)`；输入表达式：`Stat("A8 预计通关率",$"{MatchRules.ClearChance(data,person,8)*100:0.#}%")`；返回值紧邻使用处：`ExpressionStatementSyntax: Stat("A8 预计通关率",$"{MatchRules.ClearChance(data,person,8)*100:0.#}%");`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(295,Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(person.PublicName,fontSize:23).X)+2)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(295,Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(person.PublicName,fontSize:23).X)+2)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `identity.CustomMinimumSize` = `new(Math.Min(295,Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(person.PublicName,fontSize:23).X)+2),0)`
- `identity.HorizontalAlignment` = `HorizontalAlignment.Center`
- `identity.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `portrait.SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`
- `small.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`

<a id="symbol-e5effcdd65f3"></a>

## `Stat(string, string) — void Stat(string key,string value)`

来源：源码第 181 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string)`](ClubRosterScreen.cs.md#symbol-e2f1b514a2f4)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(DashboardLabel(key,16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(DashboardLabel(key,16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(field)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(field);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stats.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: stats.AddChild(row);`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(key,16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(key,16,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(value,16,_ink,true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(value,16,_ink,true)`

**赋值（含属性/字段和局部值）：**

- `field.HorizontalAlignment` = `HorizontalAlignment.Right`

<a id="symbol-fb8f38826212"></a>

## `NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string) — private void RosterSwapDialog(CareerData data,string outgoing,List<string> candidates,string incoming)`

来源：源码第 191 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)

**调用：** [`CardBody(string)`](ClubRosterScreen.cs.md#symbol-2881554ecb3b)；[`Check()`](ClubRosterScreen.cs.md#symbol-e25dd00cc6ce)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`](OwnedClubScreen.cs.md#symbol-d2eca2f3e48f)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string)`](ClubRosterScreen.cs.md#symbol-e2f1b514a2f4)；[`NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`](ClubRosterScreen.cs.md#symbol-540dea7ac6fc)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.StyleRosterPicker(Godot.OptionButton, int, int)`](ClubRosterScreen.cs.md#symbol-15be3d74c4b5)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-e5d4bf00dda1)；[`Stale(NationalSpire.CareerData)`](ClubRosterScreen.cs.md#symbol-f8e232d28fbb)；[`Submit(bool)`](ClubRosterScreen.cs.md#symbol-54e7a9e81310)；`Godot.CenterContainer.CenterContainer()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.Node.GetParent<T>()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.List<T>.IndexOf(T)`

**字段、属性、事件及方法组引用：** `CardBody(string)`；`Check()`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string)`；`NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.StyleRosterPicker(Godot.OptionButton, int, int)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubState.ClubId`；`Stale(NationalSpire.CareerData)`；`Submit(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CardBody(string)`；输入表达式：`CardBody("IncomingCard")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CardBody("IncomingCard")`
- `CardBody(string)`；输入表达式：`CardBody("OutgoingCard")`；返回值紧邻使用处：`ArgumentSyntax: CardBody("OutgoingCard")`
- `Check()`；输入表达式：`Check()`；返回值紧邻使用处：`ExpressionStatementSyntax: Check();`
- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer {CustomMinimumSize=new(52,0)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CenterContainer {CustomMinimumSize=new(52,0)}`
- `Godot.Color.Color(string)`；输入表达式：`new Color("00000070")`；返回值紧邻使用处：`AssignmentExpressionSyntax: surface.ShadowColor=new Color("00000070")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("e1bd8a")`；返回值紧邻使用处：`ArgumentSyntax: new Color("e1bd8a")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("f0bbb4")`；返回值紧邻使用处：`ArgumentSyntax: new Color("f0bbb4")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`release.AddThemeColorOverride("font_color",new Color("f0bbb4"))`；返回值紧邻使用处：`ExpressionStatementSyntax: release.AddThemeColorOverride("font_color",new Color("f0bbb4"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`swap.AddThemeColorOverride("font_color",_gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: swap.AddThemeColorOverride("font_color",_gold);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",18)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`buttons.AddThemeConstantOverride("separation",13)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddThemeConstantOverride("separation",13);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`fields.AddThemeConstantOverride("separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddThemeConstantOverride("separation",4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`pair.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.AddThemeConstantOverride("separation",0);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`pickerMargin.AddThemeConstantOverride("margin_top",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: pickerMargin.AddThemeConstantOverride("margin_top",8);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`b.AddThemeFontSizeOverride("font_size",18)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AddThemeFontSizeOverride("font_size",18);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`body.GetChild<Label>(0).AddThemeFontSizeOverride("font_size",30)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.GetChild<Label>(0).AddThemeFontSizeOverride("font_size",30);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer {Name="SwapPair"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer {Name="SwapPair"}`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`arrow.AddChild(Glyph("arrow-right-left",24,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: arrow.AddChild(Glyph("arrow-right-left",24,CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(costs)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(costs);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(feedback)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(feedback);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(pair)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(pair);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(release)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(release);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`costs.AddChild(DashboardLabel("解约补偿",17,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: costs.AddChild(DashboardLabel("解约补偿",17,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`costs.AddChild(fee)`；返回值紧邻使用处：`ExpressionStatementSyntax: costs.AddChild(fee);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`next.AddChild(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: next.AddChild(fields);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`next.AddChild(pickerMargin)`；返回值紧邻使用处：`ExpressionStatementSyntax: next.AddChild(pickerMargin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pair.AddChild(arrow)`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.AddChild(arrow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pickerMargin.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: pickerMargin.AddChild(picker);`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`body.GetChild<Label>(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.GetChild<Label>(0).AddThemeFontSizeOverride`
- `Godot.Node.GetParent<T>()`；输入表达式：`body.GetParent<PanelContainer>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.GetParent<PanelContainer>().CustomMinimumSize`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(52,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(52,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(880,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: body.GetParent<PanelContainer>().CustomMinimumSize=new(880,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(b==release?137:88,47)`；返回值紧邻使用处：`AssignmentExpressionSyntax: b.CustomMinimumSize=new(b==release?137:88,47)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data,id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id=>CareerEngine.DisplayName(data,id)`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(cancel,"00000000","304a5a","28434c","658c91",9)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(cancel,"00000000","304a5a","28434c","658c91",9);`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(release,"3c2b2d","815851","533638","cc8f86",9)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(release,"3c2b2d","815851","533638","cc8f86",9);`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(swap,"31545b","7b9487","385d61","eed39b",9)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(swap,"31545b","7b9487","385d61","eed39b",9);`
- `NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；输入表达式：`ClubSelect(candidates.Select(id=>CareerEngine.DisplayName(data,id)).ToArray(),candidates.IndexOf(incoming),index=>              {                  incoming=candidates[index]; CareerVisuals.ClearContent(fields);                  if (Stale(ViewData)==null) RosterCandidate(ViewData,fields,incoming,"替换选手");                  Check();              })`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ClubSelect(candidates.Select(id=>CareerEngine.DisplayName(data,id)).ToArray(),candidates.IndexOf(incoming),index=>              {                  incoming=candidates[index]; CareerVisuals.ClearContent(fields);                  if (Stale(ViewData)==null) RosterCandidate(ViewData,fields,incoming,"替换选手");                  Check();              })`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("",16,new Color("e1bd8a"),true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: feedback=DashboardLabel("",16,new Color("e1bd8a"),true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("",18,_gold)`；返回值紧邻使用处：`AssignmentExpressionSyntax: fee=DashboardLabel("",18,_gold)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("解约补偿",17,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("解约补偿",17,_muted)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("arrow-right-left",24,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Glyph("arrow-right-left",24,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(0,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inset(0,0)`
- `NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string)`；输入表达式：`RosterCandidate(data,CardBody("OutgoingCard"),outgoing,"被替换选手")`；返回值紧邻使用处：`ExpressionStatementSyntax: RosterCandidate(data,CardBody("OutgoingCard"),outgoing,"被替换选手");`
- `NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string)`；输入表达式：`RosterCandidate(data,fields,incoming,"替换选手")`；返回值紧邻使用处：`ExpressionStatementSyntax: RosterCandidate(data,fields,incoming,"替换选手");`
- `NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string)`；输入表达式：`RosterCandidate(ViewData,fields,incoming,"替换选手")`；返回值紧邻使用处：`ExpressionStatementSyntax: RosterCandidate(ViewData,fields,incoming,"替换选手");`
- `NationalSpire.CareerScreen.RosterTool(string, System.Action, int, int)`；输入表达式：`RosterTool("解约并更换",()=>Submit(true))`；返回值紧邻使用处：`AssignmentExpressionSyntax: release=RosterTool("解约并更换",()=>Submit(true))`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("调整阵容","",()=>Submit(false),"替换",body=>          {              body.GetParent<PanelContainer>().CustomMinimumSize=new(880,0); body.CustomMinimumSize=Vector2.Zero;              body.GetChild<Label>(0).AddThemeFontSizeOverride("font_size",30); body.AddThemeConstantOverride("separation",18);              var pair=new HBoxContainer {Name="SwapPair"}; pair.AddThemeConstantOverride("separation",0); body.AddChild(pair);              VBoxContainer CardBody(string name)              {                  var panel=new PanelContainer {Name=name,SizeFlagsHorizontal=SizeFlags.ExpandFill};                  var style=CareerVisuals.Box("192e3c","3a5464",7,19); style.ContentMarginTop=15;style.ContentMarginBottom=16;                  panel.AddThemeStyleboxOverride("panel",style); pair.AddChild(panel);                  var box=Inner(panel);box.AddThemeConstantOverride("separation",4); return box;              }              RosterCandidate(data,CardBody("OutgoingCard"),outgoing,"被替换选手");              var arrow=new CenterContainer {CustomMinimumSize=new(52,0)}; pair.AddChild(arrow); arrow.AddChild(Glyph("arrow-right-left",24,CareerVisuals.Teal));              var next=CardBody("IncomingCard");              var fields=new VBoxContainer(); fields.AddThemeConstantOverride("separation",4); next.AddChild(fields); RosterCandidate(data,fields,incoming,"替换选手");              var pickerMargin=Inset(0,0); pickerMargin.AddThemeConstantOverride("margin_top",8); next.AddChild(pickerMargin);              var picker=ClubSelect(candidates.Select(id=>CareerEngine.DisplayName(data,id)).ToArray(),candidates.IndexOf(incoming),index=>              {                  incoming=candidates[index]; CareerVisuals.ClearContent(fields);                  if (Stale(ViewData)==null) RosterCandidate(ViewData,fields,incoming,"替换选手");                  Check();              });              StyleRosterPicker(picker,0,38); picker.Name="SwapCandidate"; pickerMargin.AddChild(picker);              var costs=new HBoxContainer(); body.AddChild(costs); costs.AddChild(DashboardLabel("解约补偿",17,_muted));              fee=DashboardLabel("",18,_gold); fee.HorizontalAlignment=HorizontalAlignment.Right; costs.AddChild(fee);              feedback=DashboardLabel("",16,new Color("e1bd8a"),true); feedback.Name="SwapFeedback"; body.AddChild(feedback);          },surface:surface,footer:(buttons,cancel,accept)=>          {              swap=accept; release=RosterTool("解约并更换",()=>Submit(true)); buttons.AddChild(release);              buttons.Name="RosterDialogActions"; buttons.AddThemeConstantOverride("separation",13);              foreach (var b in new[]{cancel,swap,release}) { b.CustomMinimumSize=new(b==release?137:88,47); b.AddThemeFontSizeOverride("font_size",18); }              ButtonSurface(cancel,"00000000","304a5a","28434c","658c91",9);              ButtonSurface(swap,"31545b","7b9487","385d61","eed39b",9); swap.AddThemeColorOverride("font_color",_gold);              ButtonSurface(release,"3c2b2d","815851","533638","cc8f86",9); release.AddThemeColorOverride("font_color",new Color("f0bbb4"));              Check();          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("调整阵容","",()=>Submit(false),"替换",body=>          {              body.GetParent<PanelContainer>().CustomMinimumSize=new(880,0); body.CustomMinimumSize=Vector2.Zero;              body.GetChild<Label>(0).AddThemeFontSizeOverride("font_size",30); body.AddThemeConstantOverride("separation",18);              var pair=new HBoxContainer {Name="SwapPair"}; pair.AddThemeConstantOverride("separation",0); body.AddChild(pair);              VBoxContainer CardBody(string name)              {                  var panel=new PanelContainer {Name=name,SizeFlagsHorizontal=SizeFlags.ExpandFill};                  var style=CareerVisuals.Box("192e3c","3a5464",7,19); style.ContentMarginTop=15;style.ContentMarginBottom=16;                  panel.AddThemeStyleboxOverride("panel",style); pair.AddChild(panel);                  var box=Inner(panel);box.AddThemeConstantOverride("separation",4); return box;              }              RosterCandidate(data,CardBody("OutgoingCard"),outgoing,"被替换选手");              var arrow=new CenterContainer {CustomMinimumSize=new(52,0)}; pair.AddChild(arrow); arrow.AddChild(Glyph("arrow-right-left",24,CareerVisuals.Teal));              var next=CardBody("IncomingCard");              var fields=new VBoxContainer(); fields.AddThemeConstantOverride("separation",4); next.AddChild(fields); RosterCandidate(data,fields,incoming,"替换选手");              var pickerMargin=Inset(0,0); pickerMargin.AddThemeConstantOverride("margin_top",8); next.AddChild(pickerMargin);              var picker=ClubSelect(candidates.Select(id=>CareerEngine.DisplayName(data,id)).ToArray(),candidates.IndexOf(incoming),index=>              {                  incoming=candidates[index]; CareerVisuals.ClearContent(fields);                  if (Stale(ViewData)==null) RosterCandidate(ViewData,fields,incoming,"替换选手");                  Check();              });              StyleRosterPicker(picker,0,38); picker.Name="SwapCandidate"; pickerMargin.AddChild(picker);              var costs=new HBoxContainer(); body.AddChild(costs); costs.AddChild(DashboardLabel("解约补偿",17,_muted));              fee=DashboardLabel("",18,_gold); fee.HorizontalAlignment=HorizontalAlignment.Right; costs.AddChild(fee);              feedback=DashboardLabel("",16,new Color("e1bd8a"),true); feedback.Name="SwapFeedback"; body.AddChild(feedback);          },surface:surface,footer:(buttons,cancel,accept)=>          {              swap=accept; release=RosterTool("解约并更换",()=>Submit(true)); buttons.AddChild(release);              buttons.Name="RosterDialogActions"; buttons.AddThemeConstantOverride("separation",13);              foreach (var b in new[]{cancel,swap,release}) { b.CustomMinimumSize=new(b==release?137:88,47); b.AddThemeFontSizeOverride("font_size",18); }              ButtonSurface(cancel,"00000000","304a5a","28434c","658c91",9);              ButtonSurface(swap,"31545b","7b9487","385d61","eed39b",9); swap.AddThemeColorOverride("font_color",_gold);              ButtonSurface(release,"3c2b2d","815851","533638","cc8f86",9); release.AddThemeColorOverride("font_color",new Color("f0bbb4"));              Check();          });`
- `NationalSpire.CareerScreen.StyleRosterPicker(Godot.OptionButton, int, int)`；输入表达式：`StyleRosterPicker(picker,0,38)`；返回值紧邻使用处：`ExpressionStatementSyntax: StyleRosterPicker(picker,0,38);`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("142633","65838e",10,32)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerVisuals.Box("142633","65838e",10,32)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(fields);`
- `NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；输入表达式：`OwnedClubs.Position(opened,id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id=>OwnedClubs.Position(opened,id)`
- `NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；输入表达式：`OwnedClubs.Position(opened,outgoing)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OwnedClubs.Position(opened,outgoing)`
- `Stale(NationalSpire.CareerData)`；输入表达式：`Stale(ViewData)`；返回值紧邻使用处：`BinaryExpressionSyntax: Stale(ViewData)==null`
- `Submit(bool)`；输入表达式：`Submit(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Submit(false)`
- `Submit(bool)`；输入表达式：`Submit(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Submit(true)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`candidates.Select(id=>CareerEngine.DisplayName(data,id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Select(id=>CareerEngine.DisplayName(data,id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`candidates.Select(id=>CareerEngine.DisplayName(data,id)).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: candidates.Select(id=>CareerEngine.DisplayName(data,id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`candidates.ToDictionary(id=>id,id=>OwnedClubs.Position(opened,id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =candidates.ToDictionary(id=>id,id=>OwnedClubs.Position(opened,id))`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`candidates.IndexOf(incoming)`；返回值紧邻使用处：`ArgumentSyntax: candidates.IndexOf(incoming)`

**赋值（含属性/字段和局部值）：**

- `b.CustomMinimumSize` = `new(b==release?137:88,47)`
- `body.CustomMinimumSize` = `Vector2.Zero`
- `body.GetParent<PanelContainer>().CustomMinimumSize` = `new(880,0)`
- `buttons.Name` = `"RosterDialogActions"`
- `CustomMinimumSize` = `new(52,0)`
- `fee.HorizontalAlignment` = `HorizontalAlignment.Right`
- `fee` = `DashboardLabel("",18,_gold)`
- `feedback.Name` = `"SwapFeedback"`
- `feedback` = `DashboardLabel("",16,new Color("e1bd8a"),true)`
- `incoming` = `candidates[index]`
- `Name` = `"SwapPair"`
- `picker.Name` = `"SwapCandidate"`
- `release` = `RosterTool("解约并更换",()=>Submit(true))`
- `surface.ContentMarginBottom` = `27`
- `surface.ContentMarginTop` = `surface.ContentMarginBottom=27`
- `surface.ShadowColor` = `new Color("00000070")`
- `surface.ShadowSize` = `18`
- `swap` = `accept`

<a id="symbol-f8e232d28fbb"></a>

## `Stale(NationalSpire.CareerData) — string? Stale(CareerData live)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Check()`](ClubRosterScreen.cs.md#symbol-e25dd00cc6ce)；[`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)

**调用：** [`NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-e5d4bf00dda1)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerScreen.CanManageClub`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；输入表达式：`OwnedClubs.Position(club,incoming)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.Position(club,incoming)!=positions[incoming]`
- `NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；输入表达式：`OwnedClubs.Position(club,outgoing)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.Position(club,outgoing)!=oldPosition`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`club.Contracts.Any(c=>c.PersonId==incoming)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !club.Contracts.Any(c=>c.PersonId==incoming)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`club.Contracts.Any(c=>c.PersonId==outgoing)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !club.Contracts.Any(c=>c.PersonId==outgoing)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e25dd00cc6ce"></a>

## `Check() — void Check()`

来源：源码第 203 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)；[`Submit(bool)`](ClubRosterScreen.cs.md#symbol-54e7a9e81310)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.OwnedClubs.ExitFee(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract)`](OwnedClubs.cs.md#symbol-157b8775d91c)；[`NationalSpire.OwnedClubs.ReplaceAndReleaseError(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-a5fd8dde164b)；[`NationalSpire.OwnedClubs.SwapError(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-2a9eac826d7a)；[`Stale(NationalSpire.CareerData)`](ClubRosterScreen.cs.md#symbol-f8e232d28fbb)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.ExitFee(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract)`；`NationalSpire.OwnedClubs.ReplaceAndReleaseError(NationalSpire.CareerData, string, string)`；`NationalSpire.OwnedClubs.SwapError(NationalSpire.CareerData, string, string)`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.PersonId`；`Stale(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(OwnedClubs.ExitFee(live,contract))`；返回值紧邻使用处：`ConditionalExpressionSyntax: contract==null?"—":CareerMoney.Format(OwnedClubs.ExitFee(live,contract))`
- `NationalSpire.OwnedClubs.ExitFee(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract)`；输入表达式：`OwnedClubs.ExitFee(live,contract)`；返回值紧邻使用处：`ArgumentSyntax: OwnedClubs.ExitFee(live,contract)`
- `NationalSpire.OwnedClubs.ReplaceAndReleaseError(NationalSpire.CareerData, string, string)`；输入表达式：`OwnedClubs.ReplaceAndReleaseError(live,outgoing,incoming)`；返回值紧邻使用处：`BinaryExpressionSyntax: stale??OwnedClubs.ReplaceAndReleaseError(live,outgoing,incoming)`
- `NationalSpire.OwnedClubs.SwapError(NationalSpire.CareerData, string, string)`；输入表达式：`OwnedClubs.SwapError(live,outgoing,incoming)`；返回值紧邻使用处：`BinaryExpressionSyntax: stale??OwnedClubs.SwapError(live,outgoing,incoming)`
- `Stale(NationalSpire.CareerData)`；输入表达式：`Stale(live)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Stale(live)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("　",new[]{                  swapError==null?"":"替换 · "+swapError, releaseError==null?"":"解约并更换 · "+releaseError}.Where(s=>s.Length>0))`；返回值紧邻使用处：`ConditionalExpressionSyntax: swapError==releaseError ? swapError??"" : string.Join("　",new[]{                  swapError==null?"":"替换 · "+swapError, releaseError==null?"":"解约并更换 · "+releaseError}.Where(s=>s.Length>0))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Contracts.FirstOrDefault(c=>c.PersonId==outgoing)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: live.Esports.OwnedClub?.Contracts.FirstOrDefault(c=>c.PersonId==outgoing)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[]{                  swapError==null?"":"替换 · "+swapError, releaseError==null?"":"解约并更换 · "+releaseError}.Where(s=>s.Length>0)`；返回值紧邻使用处：`ArgumentSyntax: new[]{                  swapError==null?"":"替换 · "+swapError, releaseError==null?"":"解约并更换 · "+releaseError}.Where(s=>s.Length>0)`

**赋值（含属性/字段和局部值）：**

- `fee.Text` = `contract==null?"—":CareerMoney.Format(OwnedClubs.ExitFee(live,contract))`
- `feedback.Text` = `swapError==releaseError ? swapError??"" : string.Join("　",new[]{                  swapError==null?"":"替换 · "+swapError, releaseError==null?"":"解约并更换 · "+releaseError}.Where(s=>s.Length>0))`
- `feedback.Visible` = `feedback.Text.Length>0`
- `release.Disabled` = `releaseError!=null`
- `swap.Disabled` = `swapError!=null`

<a id="symbol-54e7a9e81310"></a>

## `Submit(bool) — bool Submit(bool terminate)`

来源：源码第 216 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)

**调用：** [`Check()`](ClubRosterScreen.cs.md#symbol-e25dd00cc6ce)；[`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`](OwnedClubScreen.cs.md#symbol-9c161e058b4e)；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Check()`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；`NationalSpire.CareerScreen.ViewData`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Check()`；输入表达式：`Check()`；返回值紧邻使用处：`ExpressionStatementSyntax: Check();`
- `NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；输入表达式：`ClubAction(ViewData,terminate?"replace-release":"swap",incoming,outgoing)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubAction(ViewData,terminate?"replace-release":"swap",incoming,outgoing);`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2881554ecb3b"></a>

## `CardBody(string) — VBoxContainer CardBody(string name)`

来源：源码第 228 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)

**调用：** [`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation",4);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel",style)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel",style);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pair.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.AddChild(panel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer {Name=name,SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer {Name=name,SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inner(panel)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("192e3c","3a5464",7,19)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerVisuals.Box("192e3c","3a5464",7,19)`

**赋值（含属性/字段和局部值）：**

- `Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `style.ContentMarginBottom` = `16`
- `style.ContentMarginTop` = `15`
