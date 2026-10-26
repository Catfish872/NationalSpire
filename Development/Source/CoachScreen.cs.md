# CoachScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D217BFDF0C25085B90248BE2A3CD4C3AD47FD264D5D91D349611F5EE9372474A`。来源：[源码](../../CoachScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private readonly HashSet<string> _privateExpandedTraining = [];
```

<a id="symbol-7f703533cff4"></a>

## `NationalSpire.CareerScreen.CoachManagement(NationalSpire.CareerData) — private void CoachManagement(CareerData d)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`](OwnedClubScreen.cs.md#symbol-9c161e058b4e)；[`NationalSpire.CareerScreen.ClubButton(string, System.Action, int)`](OwnedClubScreen.cs.md#symbol-745c5ca62e51)；[`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`](OwnedClubScreen.cs.md#symbol-dea530bc8e29)；[`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-5e31a957c01c)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`](CareerSession.cs.md#symbol-a13f3923812a)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-d1aa71b14a7b)；[`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；`NationalSpire.CareerScreen.ClubButton(string, System.Action, int)`；`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`；`NationalSpire.CareerScreen.ClubLeaveDialog()`；`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；`NationalSpire.CoachAppointment.PersonId`；`NationalSpire.CoachAppointment.Season`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.CoachAppointments`；`NationalSpire.OwnedClubState.PlayerCoach`；`NationalSpire.OwnedClubState.PlayerNextPosition`；`NationalSpire.OwnedClubState.PlayerPositionSeason`；`NationalSpire.OwnedClubState.PlayerReplacement`；`NationalSpire.OwnedClubState.PlayerReserve`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`positionActions.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: positionActions.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("h_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("h_separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("v_separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("v_separation", 10);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(ClubButton("撤销席位申请", () => ClubAction(d, "player-position", target: "取消"), 170))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(ClubButton("撤销席位申请", () => ClubAction(d, "player-position", target: "取消"), 170));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(pending)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(pending);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"第{o.PlayerPositionSeason}赛季转为{o.PlayerNextPosition} · 与{CareerEngine.DisplayName(d, o.PlayerReplacement)}调整席位", 17, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"第{o.PlayerPositionSeason}赛季转为{o.PlayerNextPosition} · 与{CareerEngine.DisplayName(d, o.PlayerReplacement)}调整席位", 17, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pending.AddChild(ClubButton("取消调整", () => ClubAction(d, "coach-cancel", target: a.PersonId), 120))`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.AddChild(ClubButton("取消调整", () => ClubAction(d, "coach-cancel", target: a.PersonId), 120));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pending.AddChild(Text($"{CareerEngine.DisplayName(d, a.PersonId)} · 第{a.Season}赛季转任教练", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.AddChild(Text($"{CareerEngine.DisplayName(d, a.PersonId)} · 第{a.Season}赛季转任教练", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`positionActions.AddChild(ClubButton(o.PlayerReserve ? "恢复首发" : "退出首发", () => PlayerPositionDialog(d), 190))`；返回值紧邻使用处：`ExpressionStatementSyntax: positionActions.AddChild(ClubButton(o.PlayerReserve ? "恢复首发" : "退出首发", () => PlayerPositionDialog(d), 190));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`positionActions.AddChild(TeamButton("退出俱乐部", ClubLeaveDialog, 190))`；返回值紧邻使用处：`ExpressionStatementSyntax: positionActions.AddChild(TeamButton("退出俱乐部", ClubLeaveDialog, 190));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(ClubButton(o.PlayerCoach ? "结束教练任职" : "兼任教练", () =>                  ShowCareerDialog(o.PlayerCoach ? "结束教练任职" : "兼任教练", o.PlayerCoach ? "停止未完成的教练训练，已获得成长保留。" : "可在队员私信中附上训练计划，由对方确认后开始。", () => { ClubAction(d, "player-coach", o.PlayerCoach ? "0" : "1"); return true; }), 170))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(ClubButton(o.PlayerCoach ? "结束教练任职" : "兼任教练", () =>                  ShowCareerDialog(o.PlayerCoach ? "结束教练任职" : "兼任教练", o.PlayerCoach ? "停止未完成的教练训练，已获得成长保留。" : "可在队员私信中附上训练计划，由对方确认后开始。", () => { ClubAction(d, "player-coach", o.PlayerCoach ? "0" : "1"); return true; }), 170));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(positionActions)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(positionActions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(TeamButton("退出俱乐部", ClubLeaveDialog, 190))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(TeamButton("退出俱乐部", ClubLeaveDialog, 190));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text($"当前陪练系数 ×{ClubCoaching.Factor(d):0.#}", 20, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text($"当前陪练系数 ×{ClubCoaching.Factor(d):0.#}", 20, CareerVisuals.Teal));`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, a.PersonId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, a.PersonId)}`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, o.PlayerReplacement)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, o.PlayerReplacement)}`
- `NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；输入表达式：`ClubAction(d, "coach-cancel", target: a.PersonId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ClubAction(d, "coach-cancel", target: a.PersonId)`
- `NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；输入表达式：`ClubAction(d, "player-coach", o.PlayerCoach ? "0" : "1")`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubAction(d, "player-coach", o.PlayerCoach ? "0" : "1");`
- `NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；输入表达式：`ClubAction(d, "player-position", target: "取消")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ClubAction(d, "player-position", target: "取消")`
- `NationalSpire.CareerScreen.ClubButton(string, System.Action, int)`；输入表达式：`ClubButton("撤销席位申请", () => ClubAction(d, "player-position", target: "取消"), 170)`；返回值紧邻使用处：`ArgumentSyntax: ClubButton("撤销席位申请", () => ClubAction(d, "player-position", target: "取消"), 170)`
- `NationalSpire.CareerScreen.ClubButton(string, System.Action, int)`；输入表达式：`ClubButton("取消调整", () => ClubAction(d, "coach-cancel", target: a.PersonId), 120)`；返回值紧邻使用处：`ArgumentSyntax: ClubButton("取消调整", () => ClubAction(d, "coach-cancel", target: a.PersonId), 120)`
- `NationalSpire.CareerScreen.ClubButton(string, System.Action, int)`；输入表达式：`ClubButton(o.PlayerCoach ? "结束教练任职" : "兼任教练", () =>                  ShowCareerDialog(o.PlayerCoach ? "结束教练任职" : "兼任教练", o.PlayerCoach ? "停止未完成的教练训练，已获得成长保留。" : "可在队员私信中附上训练计划，由对方确认后开始。", () => { ClubAction(d, "player-coach", o.PlayerCoach ? "0" : "1"); return true; }), 170)`；返回值紧邻使用处：`ArgumentSyntax: ClubButton(o.PlayerCoach ? "结束教练任职" : "兼任教练", () =>                  ShowCareerDialog(o.PlayerCoach ? "结束教练任职" : "兼任教练", o.PlayerCoach ? "停止未完成的教练训练，已获得成长保留。" : "可在队员私信中附上训练计划，由对方确认后开始。", () => { ClubAction(d, "player-coach", o.PlayerCoach ? "0" : "1"); return true; }), 170)`
- `NationalSpire.CareerScreen.ClubButton(string, System.Action, int)`；输入表达式：`ClubButton(o.PlayerReserve ? "恢复首发" : "退出首发", () => PlayerPositionDialog(d), 190)`；返回值紧邻使用处：`ArgumentSyntax: ClubButton(o.PlayerReserve ? "恢复首发" : "退出首发", () => PlayerPositionDialog(d), 190)`
- `NationalSpire.CareerScreen.ClubCard(string, string?, bool)`；输入表达式：`ClubCard("教练与席位", "教练提升轮换与青训陪练效果，多名教练取最高加成。")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubCard("教练与席位", "教练提升轮换与青训陪练效果，多名教练取最高加成。")`
- `NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData)`；输入表达式：`PlayerPositionDialog(d)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PlayerPositionDialog(d)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog(o.PlayerCoach ? "结束教练任职" : "兼任教练", o.PlayerCoach ? "停止未完成的教练训练，已获得成长保留。" : "可在队员私信中附上训练计划，由对方确认后开始。", () => { ClubAction(d, "player-coach", o.PlayerCoach ? "0" : "1"); return true; })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () =>                  ShowCareerDialog(o.PlayerCoach ? "结束教练任职" : "兼任教练", o.PlayerCoach ? "停止未完成的教练训练，已获得成长保留。" : "可在队员私信中附上训练计划，由对方确认后开始。", () => { ClubAction(d, "player-coach", o.PlayerCoach ? "0" : "1"); return true; })`
- `NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；输入表达式：`TeamButton("退出俱乐部", ClubLeaveDialog, 190)`；返回值紧邻使用处：`ArgumentSyntax: TeamButton("退出俱乐部", ClubLeaveDialog, 190)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{CareerEngine.DisplayName(d, a.PersonId)} · 第{a.Season}赛季转任教练", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{CareerEngine.DisplayName(d, a.PersonId)} · 第{a.Season}赛季转任教练", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"当前陪练系数 ×{ClubCoaching.Factor(d):0.#}", 20, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text($"当前陪练系数 ×{ClubCoaching.Factor(d):0.#}", 20, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第{o.PlayerPositionSeason}赛季转为{o.PlayerNextPosition} · 与{CareerEngine.DisplayName(d, o.PlayerReplacement)}调整席位", 17, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text($"第{o.PlayerPositionSeason}赛季转为{o.PlayerNextPosition} · 与{CareerEngine.DisplayName(d, o.PlayerReplacement)}调整席位", 17, _gold)`
- `NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.Factor(d)`；返回值紧邻使用处：`InterpolationSyntax: {ClubCoaching.Factor(d):0.#}`
- `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerFeatures(d)`；返回值紧邻使用处：`IfStatementSyntax: if (ClubCoaching.PlayerFeatures(d))          {              row.AddChild(ClubButton(o.PlayerCoach ? "结束教练任职" : "兼任教练", () =>                  ShowCareerDialog(o.PlayerCoach ? "结束教练任职" : "兼任教练", o.PlayerCoach ? "停止未完成的教练训练，已获得成长保留。" : "可在队员私信中附上训练计划，由对方确认后开始。", () => { ClubAction(d, "player-coach", o.PlayerCoach ? "0" : "1"); return true; }), 170));              var positionActions = new HBoxContainer(); positionActions.AddThemeConstantOverride("separation", 12); row.AddChild(positionActions);              positionActions.AddChild(ClubButton(o.PlayerReserve ? "恢复首发" : "退出首发", () => PlayerPositionDialog(d), 190));              positionActions.AddChild(TeamButton("退出俱乐部", ClubLeaveDialog, 190));              if (o.PlayerPositionSeason > 0)              {                  box.AddChild(Text($"第{o.PlayerPositionSeason}赛季转为{o.PlayerNextPosition} · 与{CareerEngine.DisplayName(d, o.PlayerReplacement)}调整席位", 17, _gold));                  box.AddChild(ClubButton("撤销席位申请", () => ClubAction(d, "player-position", target: "取消"), 170));              }          }          else row.AddChild(TeamButton("退出俱乐部", ClubLeaveDialog, 190));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5e31a957c01c"></a>

## `NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData) — private void PlayerPositionDialog(CareerData d)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CoachManagement(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-7f703533cff4)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`](OwnedClubScreen.cs.md#symbol-d2eca2f3e48f)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.ClubCoaching.SetPlayerPosition(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-68aeffe9f915)；[`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-e1cbaaf9f832)；[`NationalSpire.OwnedClubSchedule.PlayerPositionTiming(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-f0ca76b12647)；`Godot.Color.Color(string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；`NationalSpire.ClubCoaching.SetPlayerPosition(NationalSpire.CareerData, string, string)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`；`NationalSpire.OwnedClubSchedule.PlayerPositionTiming(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.PlayerReserve`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(ClubSelect(ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray(), 0, i => selected = ids[i]))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(ClubSelect(ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray(), 0, i => selected = ids[i]));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(CareerEngine.Name(d) + (reserve ? " · 首发 → 轮换" : " · 轮换 → 首发"), 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(CareerEngine.Name(d) + (reserve ? " · 首发 → 轮换" : " · 轮换 → 首发"), 18, _ink));`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + (reserve ? " · 首发 → 轮换" : " · 轮换 → 首发")`
- `NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；输入表达式：`ClubSelect(ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray(), 0, i => selected = ids[i])`；返回值紧邻使用处：`ArgumentSyntax: ClubSelect(ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray(), 0, i => selected = ids[i])`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog(reserve ? "退出首发" : "恢复首发", OwnedClubSchedule.PlayerPositionTiming(d), () =>          {              var result = ClubCoaching.SetPlayerPosition(d, reserve ? "轮换" : "首发", selected);              if (result != null) { error!.Text = result; return false; }              Render(); return true;          }, "确认调整", box =>          {              box.AddChild(Text(CareerEngine.Name(d) + (reserve ? " · 首发 → 轮换" : " · 轮换 → 首发"), 18, _ink));              if (ids.Count > 0) box.AddChild(ClubSelect(ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray(), 0, i => selected = ids[i]));              error = Text(ids.Count == 0 ? "没有符合条件的接替人选，请先补齐阵容。" : "", 16, new Color("ee929d")); box.AddChild(error);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(reserve ? "退出首发" : "恢复首发", OwnedClubSchedule.PlayerPositionTiming(d), () =>          {              var result = ClubCoaching.SetPlayerPosition(d, reserve ? "轮换" : "首发", selected);              if (result != null) { error!.Text = result; return false; }              Render(); return true;          }, "确认调整", box =>          {              box.AddChild(Text(CareerEngine.Name(d) + (reserve ? " · 首发 → 轮换" : " · 轮换 → 首发"), 18, _ink));              if (ids.Count > 0) box.AddChild(ClubSelect(ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray(), 0, i => selected = ids[i]));              error = Text(ids.Count == 0 ? "没有符合条件的接替人选，请先补齐阵容。" : "", 16, new Color("ee929d")); box.AddChild(error);          });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CareerEngine.Name(d) + (reserve ? " · 首发 → 轮换" : " · 轮换 → 首发"), 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(CareerEngine.Name(d) + (reserve ? " · 首发 → 轮换" : " · 轮换 → 首发"), 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(ids.Count == 0 ? "没有符合条件的接替人选，请先补齐阵容。" : "", 16, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text(ids.Count == 0 ? "没有符合条件的接替人选，请先补齐阵容。" : "", 16, new Color("ee929d"))`
- `NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；输入表达式：`ClubCoaching.Replacements(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: reserve ? ClubCoaching.Replacements(d) : OwnedClubs.ReplaceableStarters(d)`
- `NationalSpire.ClubCoaching.SetPlayerPosition(NationalSpire.CareerData, string, string)`；输入表达式：`ClubCoaching.SetPlayerPosition(d, reserve ? "轮换" : "首发", selected)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubCoaching.SetPlayerPosition(d, reserve ? "轮换" : "首发", selected)`
- `NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ReplaceableStarters(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: reserve ? ClubCoaching.Replacements(d) : OwnedClubs.ReplaceableStarters(d)`
- `NationalSpire.OwnedClubSchedule.PlayerPositionTiming(NationalSpire.CareerData)`；输入表达式：`OwnedClubSchedule.PlayerPositionTiming(d)`；返回值紧邻使用处：`ArgumentSyntax: OwnedClubSchedule.PlayerPositionTiming(d)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`ids.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: ids.FirstOrDefault() ?? ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray()`

**赋值（含属性/字段和局部值）：**

- `error!.Text` = `result`
- `error` = `Text(ids.Count == 0 ? "没有符合条件的接替人选，请先补齐阵容。" : "", 16, new Color("ee929d"))`
- `selected` = `ids[i]`

<a id="symbol-e2df497af307"></a>

## `NationalSpire.CareerScreen.CoachAppointmentDialog(NationalSpire.CareerData, string) — private void CoachAppointmentDialog(CareerData d, string id)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`](OwnedClubScreen.cs.md#symbol-d2eca2f3e48f)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-15fbcfa0d281)；[`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.ClubCoaching.Scheduled(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-4f8141b24cff)；`Godot.Color.Color(string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`；`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；`NationalSpire.ClubCoaching.Scheduled(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.Starters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(ClubSelect(ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i)).ToArray(), 0, i => replacement = ids[i]))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(ClubSelect(ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i)).ToArray(), 0, i => replacement = ids[i]));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, i)`；返回值紧邻使用处：`BinaryExpressionSyntax: "接替首发 · " + CareerEngine.DisplayName(d, i)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(d, id) + (scheduled ? " · 下赛季生效" : " · 立即生效")`
- `NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；输入表达式：`ClubSelect(ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i)).ToArray(), 0, i => replacement = ids[i])`；返回值紧邻使用处：`ArgumentSyntax: ClubSelect(ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i)).ToArray(), 0, i => replacement = ids[i])`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("owned-coach", id, replacement)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("owned-coach", id, replacement)) return true;`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("转任教练", CareerEngine.DisplayName(d, id) + (scheduled ? " · 下赛季生效" : " · 立即生效") + "\n合同待遇保留，转任后不再兼任选手。", () =>          {              if (MultiplayerCommand("owned-coach", id, replacement)) return true;              var result = ClubCoaching.Appoint(d, id, replacement);              if (result != null) { error!.Text = result; return false; }              Render(); return true;          }, "确认转任", box =>          {              if (ids.Count > 0) box.AddChild(ClubSelect(ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i)).ToArray(), 0, i => replacement = ids[i]));              error = Text("", 16, new Color("ee929d")); box.AddChild(error);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("转任教练", CareerEngine.DisplayName(d, id) + (scheduled ? " · 下赛季生效" : " · 立即生效") + "\n合同待遇保留，转任后不再兼任选手。", () =>          {              if (MultiplayerCommand("owned-coach", id, replacement)) return true;              var result = ClubCoaching.Appoint(d, id, replacement);              if (result != null) { error!.Text = result; return false; }              Render(); return true;          }, "确认转任", box =>          {              if (ids.Count > 0) box.AddChild(ClubSelect(ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i)).ToArray(), 0, i => replacement = ids[i]));              error = Text("", 16, new Color("ee929d")); box.AddChild(error);          });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 16, new Color("ee929d"))`
- `NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`；输入表达式：`ClubCoaching.Appoint(d, id, replacement)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubCoaching.Appoint(d, id, replacement)`
- `NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；输入表达式：`ClubCoaching.Replacements(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: o.Starters.Contains(id) ? ClubCoaching.Replacements(d, id) : []`
- `NationalSpire.ClubCoaching.Scheduled(NationalSpire.CareerData, string)`；输入表达式：`ClubCoaching.Scheduled(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubCoaching.Scheduled(d, id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`ids.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: ids.FirstOrDefault() ?? ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i)).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i)).ToArray()`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Starters.Contains(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: o.Starters.Contains(id) ? ClubCoaching.Replacements(d, id) : []`

**赋值（含属性/字段和局部值）：**

- `error!.Text` = `result`
- `error` = `Text("", 16, new Color("ee929d"))`
- `replacement` = `ids[i]`

<a id="symbol-2609d8a7ba68"></a>

## `NationalSpire.CareerScreen.PrivateTrainingPicker() — private void PrivateTrainingPicker()`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ClubCoaching.cs.md#symbol-061ee769bb78)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateOffer.PrivateOffer()`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Weeks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(picker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text("训练周期", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text("训练周期", 18, _ink));`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`picker.AddItem(w + "周")`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddItem(w + "周");`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { CustomMinimumSize = new(150, 46) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { CustomMinimumSize = new(150, 46) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`picker.Select(3)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.Select(3);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(680, 150), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`AssignmentExpressionSyntax: input = new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(680, 150), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(150, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(150, 46)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(680, 150)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(680, 150)`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(attachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachPrivate(attachment);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("制定训练计划", "发送附件，由队员确认训练内容。", () =>          {              var attachment = new PrivateOffer { Kind = "training", Detail = input!.Text.Trim(), Weeks = weeks };              if (ClubCoaching.TrainingError(ViewData, _privatePerson, attachment) is { } result) { error!.Text = result; return false; }              AttachPrivate(attachment); return true;          }, "添加附件", box =>          {              input = new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(680, 150), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(input);              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);              row.AddChild(Text("训练周期", 18, _ink));              var picker = new OptionButton { CustomMinimumSize = new(150, 46) }; for (int w = 1; w <= 4; w++) picker.AddItem(w + "周");              picker.Select(3); picker.ItemSelected += i => weeks = (int)i + 1; row.AddChild(picker);              error = Text("", 16, new Color("ee929d")); box.AddChild(error);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("制定训练计划", "发送附件，由队员确认训练内容。", () =>          {              var attachment = new PrivateOffer { Kind = "training", Detail = input!.Text.Trim(), Weeks = weeks };              if (ClubCoaching.TrainingError(ViewData, _privatePerson, attachment) is { } result) { error!.Text = result; return false; }              AttachPrivate(attachment); return true;          }, "添加附件", box =>          {              input = new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(680, 150), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(input);              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);              row.AddChild(Text("训练周期", 18, _ink));              var picker = new OptionButton { CustomMinimumSize = new(150, 46) }; for (int w = 1; w <= 4; w++) picker.AddItem(w + "周");              picker.Select(3); picker.ItemSelected += i => weeks = (int)i + 1; row.AddChild(picker);              error = Text("", 16, new Color("ee929d")); box.AddChild(error);          });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 16, new Color("ee929d"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("训练周期", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("训练周期", 18, _ink)`
- `NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`ClubCoaching.TrainingError(ViewData, _privatePerson, attachment)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ClubCoaching.TrainingError(ViewData, _privatePerson, attachment) is { } result`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = "training", Detail = input!.Text.Trim(), Weeks = weeks }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = "training", Detail = input!.Text.Trim(), Weeks = weeks }`
- `string.Trim()`；输入表达式：`input!.Text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Detail = input!.Text.Trim()`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(150, 46)`
- `CustomMinimumSize` = `new(680, 150)`
- `Detail` = `input!.Text.Trim()`
- `error!.Text` = `result`
- `error` = `Text("", 16, new Color("ee929d"))`
- `input` = `new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(680, 150), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Kind` = `"training"`
- `picker.ItemSelected` += `i => weeks = (int)i + 1`
- `PlaceholderText` = `"填写训练内容"`
- `weeks` = `(int)i + 1`
- `Weeks` = `weeks`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-78315f2693ca"></a>

## `NationalSpire.CareerScreen.PrivateLineupPicker() — private void PrivateLineupPicker()`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`](OwnedClubScreen.cs.md#symbol-d2eca2f3e48f)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CoachLineups.Candidates(NationalSpire.CareerData)`](CoachLineups.cs.md#symbol-17ae59ab26cf)；[`NationalSpire.CoachLineups.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](CoachLineups.cs.md#symbol-be04a02d4a9c)；[`NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CoachLineups.cs.md#symbol-f16167ebabfe)；[`NationalSpire.CoachLineups.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](CoachLineups.cs.md#symbol-fac9e8c2eaeb)；[`Preview()`](CoachScreen.cs.md#symbol-019409d8f84e)；`Godot.Color.Color(string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Season`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CoachLineups.Candidates(NationalSpire.CareerData)`；`NationalSpire.CoachLineups.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.CoachLineups.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.FirstPerson`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.SecondPerson`；`Preview()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(ClubSelect(labels, 0, i => { first = members[i].Id; Preview(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(ClubSelect(labels, 0, i => { first = members[i].Id; Preview(); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(ClubSelect(labels, Math.Max(0, members.FindIndex(p => p.Id == second)), i => { second = members[i].Id; Preview(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(ClubSelect(labels, Math.Max(0, members.FindIndex(p => p.Id == second)), i => { second = members[i].Id; Preview(); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(preview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("调整队员", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("调整队员", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("交换席位的队员", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("交换席位的队员", 17, _muted));`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(attachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachPrivate(attachment);`
- `NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；输入表达式：`ClubSelect(labels, 0, i => { first = members[i].Id; Preview(); })`；返回值紧邻使用处：`ArgumentSyntax: ClubSelect(labels, 0, i => { first = members[i].Id; Preview(); })`
- `NationalSpire.CareerScreen.ClubSelect(string[], int, System.Action<int>)`；输入表达式：`ClubSelect(labels, Math.Max(0, members.FindIndex(p => p.Id == second)), i => { second = members[i].Id; Preview(); })`；返回值紧邻使用处：`ArgumentSyntax: ClubSelect(labels, Math.Max(0, members.FindIndex(p => p.Id == second)), i => { second = members[i].Id; Preview(); })`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("", 18, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: preview = PrivateText("", 18, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("请求调整阵容", $"由教练答复，第{data.Season + 1}赛季生效。", () =>          {              var attachment = new PrivateOffer { Kind = "lineup", FirstPerson = first, SecondPerson = second };              if (CoachLineups.Error(ViewData, _privatePerson, attachment) is { } result) { error!.Text = result; return false; }              attachment.Detail = CoachLineups.Prepare(ViewData, attachment); AttachPrivate(attachment); return true;          }, "添加附件", box =>          {              string[] labels = members.Select(p => $"{p.PublicName}{(p.Id == "player" ? "（你）" : "")} · {CoachLineups.Position(data, p)} · A{p.MaxAscension}").ToArray();              if (members.Count > 0)              {                  box.AddChild(Text("调整队员", 17, _muted));                  box.AddChild(ClubSelect(labels, 0, i => { first = members[i].Id; Preview(); }));                  box.AddChild(Text("交换席位的队员", 17, _muted));                  box.AddChild(ClubSelect(labels, Math.Max(0, members.FindIndex(p => p.Id == second)), i => { second = members[i].Id; Preview(); }));              }              preview = PrivateText("", 18, CareerVisuals.Teal); box.AddChild(preview); Preview();              error = Text(members.Count == 0 ? "目前没有可调整的队员。" : "", 16, new Color("ee929d")); box.AddChild(error);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("请求调整阵容", $"由教练答复，第{data.Season + 1}赛季生效。", () =>          {              var attachment = new PrivateOffer { Kind = "lineup", FirstPerson = first, SecondPerson = second };              if (CoachLineups.Error(ViewData, _privatePerson, attachment) is { } result) { error!.Text = result; return false; }              attachment.Detail = CoachLineups.Prepare(ViewData, attachment); AttachPrivate(attachment); return true;          }, "添加附件", box =>          {              string[] labels = members.Select(p => $"{p.PublicName}{(p.Id == "player" ? "（你）" : "")} · {CoachLineups.Position(data, p)} · A{p.MaxAscension}").ToArray();              if (members.Count > 0)              {                  box.AddChild(Text("调整队员", 17, _muted));                  box.AddChild(ClubSelect(labels, 0, i => { first = members[i].Id; Preview(); }));                  box.AddChild(Text("交换席位的队员", 17, _muted));                  box.AddChild(ClubSelect(labels, Math.Max(0, members.FindIndex(p => p.Id == second)), i => { second = members[i].Id; Preview(); }));              }              preview = PrivateText("", 18, CareerVisuals.Teal); box.AddChild(preview); Preview();              error = Text(members.Count == 0 ? "目前没有可调整的队员。" : "", 16, new Color("ee929d")); box.AddChild(error);          });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("调整队员", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("调整队员", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("交换席位的队员", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("交换席位的队员", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(members.Count == 0 ? "目前没有可调整的队员。" : "", 16, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text(members.Count == 0 ? "目前没有可调整的队员。" : "", 16, new Color("ee929d"))`
- `NationalSpire.CoachLineups.Candidates(NationalSpire.CareerData)`；输入表达式：`CoachLineups.Candidates(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoachLineups.Candidates(data)`
- `NationalSpire.CoachLineups.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`CoachLineups.Error(ViewData, _privatePerson, attachment)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CoachLineups.Error(ViewData, _privatePerson, attachment) is { } result`
- `NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`CoachLineups.Position(data, members[0])`；返回值紧邻使用处：`BinaryExpressionSyntax: CoachLineups.Position(data, p) != CoachLineups.Position(data, members[0])`
- `NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`CoachLineups.Position(data, p)`；返回值紧邻使用处：`BinaryExpressionSyntax: CoachLineups.Position(data, p) != CoachLineups.Position(data, members[0])`
- `NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`CoachLineups.Position(data, p)`；返回值紧邻使用处：`InterpolationSyntax: {CoachLineups.Position(data, p)}`
- `NationalSpire.CoachLineups.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`CoachLineups.Prepare(ViewData, attachment)`；返回值紧邻使用处：`AssignmentExpressionSyntax: attachment.Detail = CoachLineups.Prepare(ViewData, attachment)`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = "lineup", FirstPerson = first, SecondPerson = second }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = "lineup", FirstPerson = first, SecondPerson = second }`
- `Preview()`；输入表达式：`Preview()`；返回值紧邻使用处：`ExpressionStatementSyntax: Preview();`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`members.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: members.FirstOrDefault()?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`members.FirstOrDefault(p => first.Length > 0 && CoachLineups.Position(data, p) != CoachLineups.Position(data, members[0]))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: members.FirstOrDefault(p => first.Length > 0 && CoachLineups.Position(data, p) != CoachLineups.Position(data, members[0]))?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`members.Select(p => $"{p.PublicName}{(p.Id == "player" ? "（你）" : "")} · {CoachLineups.Position(data, p)} · A{p.MaxAscension}")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: members.Select(p => $"{p.PublicName}{(p.Id == "player" ? "（你）" : "")} · {CoachLineups.Position(data, p)} · A{p.MaxAscension}").ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`members.Select(p => $"{p.PublicName}{(p.Id == "player" ? "（你）" : "")} · {CoachLineups.Position(data, p)} · A{p.MaxAscension}").ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = members.Select(p => $"{p.PublicName}{(p.Id == "player" ? "（你）" : "")} · {CoachLineups.Position(data, p)} · A{p.MaxAscension}").ToArray()`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`members.FindIndex(p => p.Id == second)`；返回值紧邻使用处：`ArgumentSyntax: members.FindIndex(p => p.Id == second)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, members.FindIndex(p => p.Id == second))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, members.FindIndex(p => p.Id == second))`

**赋值（含属性/字段和局部值）：**

- `attachment.Detail` = `CoachLineups.Prepare(ViewData, attachment)`
- `error!.Text` = `result`
- `error` = `Text(members.Count == 0 ? "目前没有可调整的队员。" : "", 16, new Color("ee929d"))`
- `first` = `members[i].Id`
- `FirstPerson` = `first`
- `Kind` = `"lineup"`
- `preview` = `PrivateText("", 18, CareerVisuals.Teal)`
- `second` = `members[i].Id`
- `SecondPerson` = `second`

<a id="symbol-019409d8f84e"></a>

## `Preview() — void Preview()`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateLineupPicker()`](CoachScreen.cs.md#symbol-78315f2693ca)

**调用：** [`NationalSpire.CoachLineups.Description(NationalSpire.CareerData, NationalSpire.CoachLineupRequest)`](CoachLineups.cs.md#symbol-e39f2e8f62ab)；[`NationalSpire.CoachLineups.Person(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-559e961ef669)；[`NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CoachLineups.cs.md#symbol-f16167ebabfe)；`NationalSpire.CoachLineupRequest.CoachLineupRequest()`

**字段、属性、事件及方法组引用：** `NationalSpire.CoachLineupRequest.First`；`NationalSpire.CoachLineupRequest.FirstPosition`；`NationalSpire.CoachLineupRequest.Second`；`NationalSpire.CoachLineupRequest.SecondPosition`；`NationalSpire.CoachLineups.Description(NationalSpire.CareerData, NationalSpire.CoachLineupRequest)`；`NationalSpire.CoachLineups.Person(NationalSpire.CareerData, string)`；`NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CoachLineupRequest.CoachLineupRequest()`；输入表达式：`new() { First = first, Second = second, FirstPosition = CoachLineups.Position(data, CoachLineups.Person(data, first)!), SecondPosition = CoachLineups.Position(data, CoachLineups.Person(data, second)!) }`；返回值紧邻使用处：`ArgumentSyntax: new() { First = first, Second = second, FirstPosition = CoachLineups.Position(data, CoachLineups.Person(data, first)!), SecondPosition = CoachLineups.Position(data, CoachLineups.Person(data, second)!) }`
- `NationalSpire.CoachLineups.Description(NationalSpire.CareerData, NationalSpire.CoachLineupRequest)`；输入表达式：`CoachLineups.Description(data, new() { First = first, Second = second, FirstPosition = CoachLineups.Position(data, CoachLineups.Person(data, first)!), SecondPosition = CoachLineups.Position(data, CoachLineups.Person(data, second)!) })`；返回值紧邻使用处：`ConditionalExpressionSyntax: first.Length > 0 && second.Length > 0                  ? CoachLineups.Description(data, new() { First = first, Second = second, FirstPosition = CoachLineups.Position(data, CoachLineups.Person(data, first)!), SecondPosition = CoachLineups.Position(data, CoachLineups.Person(data, second)!) }) : "请选择两名队员。"`
- `NationalSpire.CoachLineups.Person(NationalSpire.CareerData, string)`；输入表达式：`CoachLineups.Person(data, first)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CoachLineups.Person(data, first)!`
- `NationalSpire.CoachLineups.Person(NationalSpire.CareerData, string)`；输入表达式：`CoachLineups.Person(data, second)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CoachLineups.Person(data, second)!`
- `NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`CoachLineups.Position(data, CoachLineups.Person(data, first)!)`；返回值紧邻使用处：`AssignmentExpressionSyntax: FirstPosition = CoachLineups.Position(data, CoachLineups.Person(data, first)!)`
- `NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`CoachLineups.Position(data, CoachLineups.Person(data, second)!)`；返回值紧邻使用处：`AssignmentExpressionSyntax: SecondPosition = CoachLineups.Position(data, CoachLineups.Person(data, second)!)`

**赋值（含属性/字段和局部值）：**

- `First` = `first`
- `FirstPosition` = `CoachLineups.Position(data, CoachLineups.Person(data, first)!)`
- `preview.Text` = `first.Length > 0 && second.Length > 0                  ? CoachLineups.Description(data, new() { First = first, Second = second, FirstPosition = CoachLineups.Position(data, CoachLineups.Person(data, first)!), SecondPosition = CoachLineups.Position(data, CoachLineups.Person(data, second)!) }) : "请选择两名队员。"`
- `Second` = `second`
- `SecondPosition` = `CoachLineups.Position(data, CoachLineups.Person(data, second)!)`

<a id="symbol-c01675f974f7"></a>

## `NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?) — private void PrivateLineupCard(CareerData data, CoachLineupRequest request, VBoxContainer parent, Action<string, PrivateMessageCommand>? send = null)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CoachLineups.Description(NationalSpire.CareerData, NationalSpire.CoachLineupRequest)`](CoachLineups.cs.md#symbol-e39f2e8f62ab)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Action<T1, T2>.Invoke(T1, T2)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CoachLineupRequest.Id`；`NationalSpire.CoachLineupRequest.Reason`；`NationalSpire.CoachLineupRequest.Season`；`NationalSpire.CoachLineupRequest.State`；`NationalSpire.CoachLineups.Description(NationalSpire.CareerData, NationalSpire.CoachLineupRequest)`；`NationalSpire.PrivateMessageCommand.Offer`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inner.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("193440", "6aa9a8", 9, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("193440", "6aa9a8", 9, 18));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(PrivateButton("取消调整", () => { if (send != null) send("lineup-cancel", new() { Offer = request.Id }); else PrivateCommand("dm-lineup-cancel", new() { Offer = request.Id }); }, 130))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(PrivateButton("取消调整", () => { if (send != null) send("lineup-cancel", new() { Offer = request.Id }); else PrivateCommand("dm-lineup-cancel", new() { Offer = request.Id }); }, 130));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(PrivateText(CoachLineups.Description(data, request), 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(PrivateText(CoachLineups.Description(data, request), 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(PrivateText(request.Reason, 16, new Color("ee929d")))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(PrivateText(request.Reason, 16, new Color("ee929d")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(Text("阵容调整 · " + request.State, 21, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(Text("阵容调整 · " + request.State, 21, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(Text($"第{request.Season}赛季", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(Text($"第{request.Season}赛季", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(panel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "CoachLineupCard" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "CoachLineupCard" }`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("取消调整", () => { if (send != null) send("lineup-cancel", new() { Offer = request.Id }); else PrivateCommand("dm-lineup-cancel", new() { Offer = request.Id }); }, 130)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("取消调整", () => { if (send != null) send("lineup-cancel", new() { Offer = request.Id }); else PrivateCommand("dm-lineup-cancel", new() { Offer = request.Id }); }, 130)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-lineup-cancel", new() { Offer = request.Id })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-lineup-cancel", new() { Offer = request.Id });`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(CoachLineups.Description(data, request), 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(CoachLineups.Description(data, request), 18, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(request.Reason, 16, new Color("ee929d"))`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(request.Reason, 16, new Color("ee929d"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("阵容调整 · " + request.State, 21, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("阵容调整 · " + request.State, 21, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第{request.Season}赛季", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"第{request.Season}赛季", 16, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("193440", "6aa9a8", 9, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("193440", "6aa9a8", 9, 18)`
- `NationalSpire.CoachLineups.Description(NationalSpire.CareerData, NationalSpire.CoachLineupRequest)`；输入表达式：`CoachLineups.Description(data, request)`；返回值紧邻使用处：`ArgumentSyntax: CoachLineups.Description(data, request)`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = request.Id }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = request.Id }`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`send("lineup-cancel", new() { Offer = request.Id })`；返回值紧邻使用处：`ExpressionStatementSyntax: send("lineup-cancel", new() { Offer = request.Id });`

**赋值（含属性/字段和局部值）：**

- `Name` = `"CoachLineupCard"`
- `Offer` = `request.Id`

<a id="symbol-c316f7a67f3e"></a>

## `NationalSpire.CareerScreen.TrainingCompletions(System.Collections.Generic.IEnumerable<NationalSpire.PrivateOffer>, long, long) — private Queue<CoachTrainingPlan> TrainingCompletions(IEnumerable<PrivateOffer> offers, long first, long end)`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-1ed5bef75319)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Queue<T>.Queue(System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ViewData`；`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；`NationalSpire.CoachTrainingPlan.CompletionOrder`；`NationalSpire.CoachTrainingPlan.Id`；`NationalSpire.CoachTrainingPlan.State`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MemoryDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.TrainingPlans(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.TrainingPlans(ViewData).Where`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ids.Contains(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.State == "已完成" && p.CompletionOrder > 0              && p.CompletionOrder >= first && p.CompletionOrder < end && ids.Contains(p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ClubCoaching.TrainingPlans(ViewData).Where(p => p.State == "已完成" && p.CompletionOrder > 0              && p.CompletionOrder >= first && p.CompletionOrder < end && ids.Contains(p.Id)).OrderBy(p => p.CompletionOrder)`；返回值紧邻使用处：`ArgumentSyntax: ClubCoaching.TrainingPlans(ViewData).Where(p => p.State == "已完成" && p.CompletionOrder > 0              && p.CompletionOrder >= first && p.CompletionOrder < end && ids.Contains(p.Id)).OrderBy(p => p.CompletionOrder)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`offers.Where(o => o.Kind == "training" && !o.MemoryDeleted).Select(o => o.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "training" && !o.MemoryDeleted).Select(o => o.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`offers.Where(o => o.Kind == "training" && !o.MemoryDeleted).Select(o => o.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = offers.Where(o => o.Kind == "training" && !o.MemoryDeleted).Select(o => o.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ClubCoaching.TrainingPlans(ViewData).Where(p => p.State == "已完成" && p.CompletionOrder > 0              && p.CompletionOrder >= first && p.CompletionOrder < end && ids.Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.TrainingPlans(ViewData).Where(p => p.State == "已完成" && p.CompletionOrder > 0              && p.CompletionOrder >= first && p.CompletionOrder < end && ids.Contains(p.Id)).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Where(o => o.Kind == "training" && !o.MemoryDeleted)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "training" && !o.MemoryDeleted).Select`
- `System.Collections.Generic.Queue<T>.Queue(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new(ClubCoaching.TrainingPlans(ViewData).Where(p => p.State == "已完成" && p.CompletionOrder > 0              && p.CompletionOrder >= first && p.CompletionOrder < end && ids.Contains(p.Id)).OrderBy(p => p.CompletionOrder))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(ClubCoaching.TrainingPlans(ViewData).Where(p => p.State == "已完成" && p.CompletionOrder > 0              && p.CompletionOrder >= first && p.CompletionOrder < end && ids.Contains(p.Id)).OrderBy(p => p.CompletionOrder));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9deab8f6abda"></a>

## `NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long) — private void TrainingCompletionsThrough(Queue<CoachTrainingPlan> plans, long order)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NoticesThrough(long)`](GroupChatScreen.cs.md#symbol-cfcadd7edb2e)

**调用：** [`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.TryPeek(out T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CoachTrainingPlan.CompletionDay`；`NationalSpire.CoachTrainingPlan.CompletionOrder`；`NationalSpire.CoachTrainingPlan.PersonId`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(PrivateLine(PrivateAppointments.DateText(ViewData, plan.CompletionDay) + " · " + GroupChats.Name(ViewData, plan.PersonId), 13, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(PrivateLine(PrivateAppointments.DateText(ViewData, plan.CompletionDay) + " · " + GroupChats.Name(ViewData, plan.PersonId), 13, _muted));`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(PrivateAppointments.DateText(ViewData, plan.CompletionDay) + " · " + GroupChats.Name(ViewData, plan.PersonId), 13, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(PrivateAppointments.DateText(ViewData, plan.CompletionDay) + " · " + GroupChats.Name(ViewData, plan.PersonId), 13, _muted)`
- `NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；输入表达式：`PrivateTrainingCard(ViewData, plan, _privateBody)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateTrainingCard(ViewData, plan, _privateBody);`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, plan.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.DateText(ViewData, plan.CompletionDay) + " · " + GroupChats.Name(ViewData, plan.PersonId)`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(ViewData, plan.CompletionDay)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.DateText(ViewData, plan.CompletionDay) + " · "`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`plans.Dequeue()`；返回值紧邻使用处：`ExpressionStatementSyntax: plans.Dequeue();`
- `System.Collections.Generic.Queue<T>.TryPeek(out T)`；输入表达式：`plans.TryPeek(out var plan)`；返回值紧邻使用处：`BinaryExpressionSyntax: plans.TryPeek(out var plan) && plan.CompletionOrder <= order`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c2e37e4a0f14"></a>

## `NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?) — private void PrivateTrainingCard(CareerData data, CoachTrainingPlan plan, VBoxContainer parent, Action<string, PrivateMessageCommand>? send = null)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`](CoachScreen.cs.md#symbol-9deab8f6abda)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ProgressBar.ProgressBar()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CareerDisclosureButton.CareerDisclosureButton()`；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Action<T1, T2>.Invoke(T1, T2)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateExpandedTraining`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CoachTrainingPlan.Content`；`NationalSpire.CoachTrainingPlan.EndDay`；`NationalSpire.CoachTrainingPlan.Gained`；`NationalSpire.CoachTrainingPlan.Id`；`NationalSpire.CoachTrainingPlan.PaidWeeks`；`NationalSpire.CoachTrainingPlan.PersonId`；`NationalSpire.CoachTrainingPlan.StartDay`；`NationalSpire.CoachTrainingPlan.State`；`NationalSpire.CoachTrainingPlan.Weeks`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`toggle.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.QueueRedraw();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`toggle.AddThemeColorOverride(state, _muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeColorOverride(state, _muted);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inner.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`toggle.AddThemeFontSizeOverride("font_size", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeFontSizeOverride("font_size", 14);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("193440", "6aa9a8", 9, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("193440", "6aa9a8", 9, 18));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`toggle.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginRight = 20 })`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginRight = 20 });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(PrivateButton("取消训练", () => { if (send != null) send("training-cancel", new()); else PrivateCommand("dm-training-cancel", new()); }, 130))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(PrivateButton("取消训练", () => { if (send != null) send("training-cancel", new()); else PrivateCommand("dm-training-cancel", new()); }, 130));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(Text($"{PrivateAppointments.DateText(data, plan.StartDay)}—{PrivateAppointments.DateText(data, plan.EndDay)}", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(Text($"{PrivateAppointments.DateText(data, plan.StartDay)}—{PrivateAppointments.DateText(data, plan.EndDay)}", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(Text($"完成 {plan.PaidWeeks}/{plan.Weeks} 周 · 永久成长 +{plan.Gained * 100:0.##}%", 17, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(Text($"完成 {plan.PaidWeeks}/{plan.Weeks} 周 · 永久成长 +{plan.Gained * 100:0.##}%", 17, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(Text((send != null ? GroupChats.Name(data, plan.PersonId) + " · " : "") + "教练训练 · " + plan.State, 21, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(Text((send != null ? GroupChats.Name(data, plan.PersonId) + " · " : "") + "教练训练 · " + plan.State, 21, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(details)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(details);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(progress)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(progress);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(toggle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(panel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "CoachTrainingCard" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "CoachTrainingCard" }`
- `Godot.ProgressBar.ProgressBar()`；输入表达式：`new ProgressBar { MinValue = 0, MaxValue = plan.Weeks, Value = plan.PaidWeeks, ShowPercentage = false, CustomMinimumSize = new(0, 8), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ProgressBar { MinValue = 0, MaxValue = plan.Weeks, Value = plan.PaidWeeks, ShowPercentage = false, CustomMinimumSize = new(0, 8), MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty { ContentMarginRight = 20 }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty { ContentMarginRight = 20 }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 8)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 8)`
- `NationalSpire.CareerDisclosureButton.CareerDisclosureButton()`；输入表达式：`new CareerDisclosureButton { Name = "TrainingToggle_" + plan.Id, Text = details.Visible ? "收起" : "展开", Flat = true, ToggleMode = true, ButtonPressed = details.Visible, SizeFlagsHorizontal = SizeFlags.ShrinkBegin, MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerDisclosureButton { Name = "TrainingToggle_" + plan.Id, Text = details.Visible ? "收起" : "展开", Flat = true, ToggleMode = true, ButtonPressed = details.Visible, SizeFlagsHorizontal = SizeFlags.ShrinkBegin, MouseDefaultCursorShape = CursorShape.PointingHand }`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("取消训练", () => { if (send != null) send("training-cancel", new()); else PrivateCommand("dm-training-cancel", new()); }, 130)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("取消训练", () => { if (send != null) send("training-cancel", new()); else PrivateCommand("dm-training-cancel", new()); }, 130)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-training-cancel", new())`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-training-cancel", new());`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(plan.Content, 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateText(plan.Content, 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{PrivateAppointments.DateText(data, plan.StartDay)}—{PrivateAppointments.DateText(data, plan.EndDay)}", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{PrivateAppointments.DateText(data, plan.StartDay)}—{PrivateAppointments.DateText(data, plan.EndDay)}", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"完成 {plan.PaidWeeks}/{plan.Weeks} 周 · 永久成长 +{plan.Gained * 100:0.##}%", 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text($"完成 {plan.PaidWeeks}/{plan.Weeks} 周 · 永久成长 +{plan.Gained * 100:0.##}%", 17, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((send != null ? GroupChats.Name(data, plan.PersonId) + " · " : "") + "教练训练 · " + plan.State, 21, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text((send != null ? GroupChats.Name(data, plan.PersonId) + " · " : "") + "教练训练 · " + plan.State, 21, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("193440", "6aa9a8", 9, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("193440", "6aa9a8", 9, 18)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(data, plan.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(data, plan.PersonId) + " · "`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(data, plan.EndDay)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(data, plan.EndDay)}`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(data, plan.StartDay)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(data, plan.StartDay)}`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`send("training-cancel", new())`；返回值紧邻使用处：`ExpressionStatementSyntax: send("training-cancel", new());`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_privateExpandedTraining.Add(plan.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateExpandedTraining.Add(plan.Id);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_privateExpandedTraining.Contains(plan.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: details.Visible = _privateExpandedTraining.Contains(plan.Id)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`_privateExpandedTraining.Remove(plan.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_privateExpandedTraining.Remove(plan.Id)`

**赋值（含属性/字段和局部值）：**

- `ButtonPressed` = `details.Visible`
- `ContentMarginRight` = `20`
- `CustomMinimumSize` = `new(0, 8)`
- `Flat` = `true`
- `MaxValue` = `plan.Weeks`
- `MinValue` = `0`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"CoachTrainingCard"`
- `Name` = `"TrainingToggle_" + plan.Id`
- `ShowPercentage` = `false`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `Text` = `details.Visible ? "收起" : "展开"`
- `ToggleMode` = `true`
- `Value` = `plan.PaidWeeks`
- `details.Name` = `"TrainingDetails_" + plan.Id`
- `details.Visible` = `_privateExpandedTraining.Contains(plan.Id)`
- `details.Visible` = `expanded`
- `toggle.ButtonPressed` = `expanded`
- `toggle.Pressed` += `() => { bool expanded = !_privateExpandedTraining.Remove(plan.Id); if (expanded) _privateExpandedTraining.Add(plan.Id); details.Visible = expanded; toggle.ButtonPressed = expanded; toggle.Text = expanded ? "收起" : "展开"; toggle.QueueRedraw(); }`
- `toggle.Text` = `expanded ? "收起" : "展开"`
